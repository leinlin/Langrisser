using System;
using UnityEngine;

namespace SLua
{
	// Token: 0x02000003 RID: 3
	public class LuaThreadWrapper : LuaVar
	{
		// Token: 0x060001B5 RID: 437 RVA: 0x0000930C File Offset: 0x0000750C
		public LuaThreadWrapper(LuaFunction func)
		{
			UnityEngine.Debug.LogFormat("LuaThreadWrapper.ctor/1: {0}", new object[]
			{
				LuaDLL.lua_gettop(func.L)
			});
			this.state = LuaState.get(func.L);
			this._thread = LuaDLL.lua_newthread(func.L);
			this.valueref = LuaDLL.luaL_ref(func.L, LuaIndexes.LUA_REGISTRYINDEX);
			func.push(func.L);
			LuaDLL.lua_xmove(func.L, this._thread, 1);
			UnityEngine.Debug.LogFormat("LuaThreadWrapper.ctor/2: {0}", new object[]
			{
				LuaDLL.lua_gettop(func.L)
			});
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x000093BC File Offset: 0x000075BC
		~LuaThreadWrapper()
		{
			UnityEngine.Debug.Log("~LuaThreadWrapper");
			this.Dispose(false);
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x000093F8 File Offset: 0x000075F8
		public override void Dispose(bool disposeManagedResources)
		{
			base.Dispose(disposeManagedResources);
			this._thread = IntPtr.Zero;
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x0000940C File Offset: 0x0000760C
		public bool EqualsTo(IntPtr L)
		{
			return this._thread == L;
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x0000941C File Offset: 0x0000761C
		private object TopObjects(int nArgs)
		{
			if (nArgs == 0)
			{
				return null;
			}
			if (nArgs == 1)
			{
				return LuaObject.checkVar(this._thread, -1);
			}
			object[] array = new object[nArgs];
			for (int i = 1; i <= nArgs; i++)
			{
				array[i - 1] = LuaObject.checkVar(this._thread, i);
			}
			return array;
		}

		// Token: 0x060001BA RID: 442 RVA: 0x00009474 File Offset: 0x00007674
		public bool Resume(out object retVal)
		{
			if (this._thread == IntPtr.Zero)
			{
				Logger.LogError("thread: already disposed?", false);
				retVal = null;
				return false;
			}
			int num = LuaDLL.lua_status(this._thread);
			if (num != 0 && num != 1)
			{
				Logger.LogError("thread: wrong status ?= " + num, false);
				retVal = null;
				return false;
			}
			int num2 = LuaDLL.lua_resume(this._thread, 0);
			if (num2 != 1)
			{
				if (num2 != 0)
				{
					string arg = LuaDLL.lua_tostring(this._thread, -1);
					Logger.LogError(string.Format("wrong result ?= {0} err: {1}", num2, arg), false);
				}
				retVal = null;
				return false;
			}
			int nArgs = LuaDLL.lua_gettop(this._thread);
			retVal = this.TopObjects(nArgs);
			return true;
		}

		// Token: 0x04000001 RID: 1
		private IntPtr _thread;
	}
}
