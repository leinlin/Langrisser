using System;
using System.Runtime.CompilerServices;
using UnityEngine.Events;

namespace SLua
{
	// Token: 0x0200188B RID: 6283
	public class LuaUnityEvent_string : LuaObject
	{
		// Token: 0x0602449C RID: 148636 RVA: 0x00CC2584 File Offset: 0x00CC0784
		[MonoPInvokeCallback(typeof(LuaCSFunction))]
		public static int AddListener(IntPtr l)
		{
			int result;
			try
			{
				UnityEvent<string> unityEvent = LuaObject.checkSelf<UnityEvent<string>>(l);
				UnityAction<string> call;
				LuaUnityEvent_string.checkType(l, 2, out call);
				unityEvent.AddListener(call);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			catch (Exception e)
			{
				result = LuaObject.error(l, e);
			}
			return result;
		}

		// Token: 0x0602449D RID: 148637 RVA: 0x00CC25D8 File Offset: 0x00CC07D8
		[MonoPInvokeCallback(typeof(LuaCSFunction))]
		public static int RemoveListener(IntPtr l)
		{
			int result;
			try
			{
				UnityEvent<string> unityEvent = LuaObject.checkSelf<UnityEvent<string>>(l);
				UnityAction<string> call;
				LuaUnityEvent_string.checkType(l, 2, out call);
				unityEvent.RemoveListener(call);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			catch (Exception e)
			{
				result = LuaObject.error(l, e);
			}
			return result;
		}

		// Token: 0x0602449E RID: 148638 RVA: 0x00CC262C File Offset: 0x00CC082C
		[MonoPInvokeCallback(typeof(LuaCSFunction))]
		public static int Invoke(IntPtr l)
		{
			int result;
			try
			{
				UnityEvent<string> unityEvent = LuaObject.checkSelf<UnityEvent<string>>(l);
				string arg;
				LuaObject.checkType(l, 2, out arg);
				unityEvent.Invoke(arg);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			catch (Exception e)
			{
				result = LuaObject.error(l, e);
			}
			return result;
		}

		// Token: 0x0602449F RID: 148639 RVA: 0x00CC2680 File Offset: 0x00CC0880
		public static void reg(IntPtr l)
		{
			LuaObject.getTypeTable(l, typeof(LuaUnityEvent_string).FullName);
			if (LuaUnityEvent_string.<>f__mg$cache0 == null)
			{
				LuaUnityEvent_string.<>f__mg$cache0 = new LuaCSFunction(LuaUnityEvent_string.AddListener);
			}
			LuaObject.addMember(l, LuaUnityEvent_string.<>f__mg$cache0);
			if (LuaUnityEvent_string.<>f__mg$cache1 == null)
			{
				LuaUnityEvent_string.<>f__mg$cache1 = new LuaCSFunction(LuaUnityEvent_string.RemoveListener);
			}
			LuaObject.addMember(l, LuaUnityEvent_string.<>f__mg$cache1);
			if (LuaUnityEvent_string.<>f__mg$cache2 == null)
			{
				LuaUnityEvent_string.<>f__mg$cache2 = new LuaCSFunction(LuaUnityEvent_string.Invoke);
			}
			LuaObject.addMember(l, LuaUnityEvent_string.<>f__mg$cache2);
			LuaObject.createTypeMetatable(l, null, typeof(LuaUnityEvent_string), typeof(UnityEventBase));
		}

		// Token: 0x060244A0 RID: 148640 RVA: 0x00CC2728 File Offset: 0x00CC0928
		private static bool checkType(IntPtr l, int p, out UnityAction<string> ua)
		{
			LuaDLL.luaL_checktype(l, p, LuaTypes.LUA_TFUNCTION);
			LuaDelegate ld;
			LuaObject.checkType(l, p, out ld);
			if (ld.d != null)
			{
				ua = (UnityAction<string>)ld.d;
				return true;
			}
			l = LuaState.get(l).L;
			ua = delegate(string v0)
			{
				int num = LuaObject.pushTry(l);
				LuaObject.pushValue(l, v0);
				ld.pcall(1, num);
				LuaDLL.lua_settop(l, num - 1);
			};
			ld.d = ua;
			return true;
		}

		// Token: 0x04019FE7 RID: 106471
		[CompilerGenerated]
		private static LuaCSFunction <>f__mg$cache0;

		// Token: 0x04019FE8 RID: 106472
		[CompilerGenerated]
		private static LuaCSFunction <>f__mg$cache1;

		// Token: 0x04019FE9 RID: 106473
		[CompilerGenerated]
		private static LuaCSFunction <>f__mg$cache2;
	}
}
