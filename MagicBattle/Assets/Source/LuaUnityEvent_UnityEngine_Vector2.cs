using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

namespace SLua
{
	// Token: 0x0200188F RID: 6287
	public class LuaUnityEvent_UnityEngine_Vector2 : LuaObject
	{
		// Token: 0x060244AC RID: 148652 RVA: 0x00CC2A94 File Offset: 0x00CC0C94
		[MonoPInvokeCallback(typeof(LuaCSFunction))]
		public static int AddListener(IntPtr l)
		{
			int result;
			try
			{
				UnityEvent<Vector2> unityEvent = LuaObject.checkSelf<UnityEvent<Vector2>>(l);
				UnityAction<Vector2> call;
				LuaUnityEvent_UnityEngine_Vector2.checkType(l, 2, out call);
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

		// Token: 0x060244AD RID: 148653 RVA: 0x00CC2AE8 File Offset: 0x00CC0CE8
		[MonoPInvokeCallback(typeof(LuaCSFunction))]
		public static int RemoveListener(IntPtr l)
		{
			int result;
			try
			{
				UnityEvent<Vector2> unityEvent = LuaObject.checkSelf<UnityEvent<Vector2>>(l);
				UnityAction<Vector2> call;
				LuaUnityEvent_UnityEngine_Vector2.checkType(l, 2, out call);
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

		// Token: 0x060244AE RID: 148654 RVA: 0x00CC2B3C File Offset: 0x00CC0D3C
		[MonoPInvokeCallback(typeof(LuaCSFunction))]
		public static int Invoke(IntPtr l)
		{
			int result;
			try
			{
				UnityEvent<Vector2> unityEvent = LuaObject.checkSelf<UnityEvent<Vector2>>(l);
				Vector2 arg;
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

		// Token: 0x060244AF RID: 148655 RVA: 0x00CC2B90 File Offset: 0x00CC0D90
		public static void reg(IntPtr l)
		{
			LuaObject.getTypeTable(l, typeof(LuaUnityEvent_UnityEngine_Vector2).FullName);
			if (LuaUnityEvent_UnityEngine_Vector2.<>f__mg$cache0 == null)
			{
				LuaUnityEvent_UnityEngine_Vector2.<>f__mg$cache0 = new LuaCSFunction(LuaUnityEvent_UnityEngine_Vector2.AddListener);
			}
			LuaObject.addMember(l, LuaUnityEvent_UnityEngine_Vector2.<>f__mg$cache0);
			if (LuaUnityEvent_UnityEngine_Vector2.<>f__mg$cache1 == null)
			{
				LuaUnityEvent_UnityEngine_Vector2.<>f__mg$cache1 = new LuaCSFunction(LuaUnityEvent_UnityEngine_Vector2.RemoveListener);
			}
			LuaObject.addMember(l, LuaUnityEvent_UnityEngine_Vector2.<>f__mg$cache1);
			if (LuaUnityEvent_UnityEngine_Vector2.<>f__mg$cache2 == null)
			{
				LuaUnityEvent_UnityEngine_Vector2.<>f__mg$cache2 = new LuaCSFunction(LuaUnityEvent_UnityEngine_Vector2.Invoke);
			}
			LuaObject.addMember(l, LuaUnityEvent_UnityEngine_Vector2.<>f__mg$cache2);
			LuaObject.createTypeMetatable(l, null, typeof(LuaUnityEvent_UnityEngine_Vector2), typeof(UnityEventBase));
		}

		// Token: 0x060244B0 RID: 148656 RVA: 0x00CC2C38 File Offset: 0x00CC0E38
		private static bool checkType(IntPtr l, int p, out UnityAction<Vector2> ua)
		{
			LuaDLL.luaL_checktype(l, p, LuaTypes.LUA_TFUNCTION);
			LuaDelegate ld;
			LuaObject.checkType(l, p, out ld);
			if (ld.d != null)
			{
				ua = (UnityAction<Vector2>)ld.d;
				return true;
			}
			l = LuaState.get(l).L;
			ua = delegate(Vector2 v0)
			{
				int num = LuaObject.pushTry(l);
				LuaObject.pushValue(l, v0);
				ld.pcall(1, num);
				LuaDLL.lua_settop(l, num - 1);
			};
			ld.d = ua;
			return true;
		}

		// Token: 0x04019FF1 RID: 106481
		[CompilerGenerated]
		private static LuaCSFunction <>f__mg$cache0;

		// Token: 0x04019FF2 RID: 106482
		[CompilerGenerated]
		private static LuaCSFunction <>f__mg$cache1;

		// Token: 0x04019FF3 RID: 106483
		[CompilerGenerated]
		private static LuaCSFunction <>f__mg$cache2;
	}
}
