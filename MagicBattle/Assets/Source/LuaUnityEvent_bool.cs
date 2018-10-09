using System;
using System.Runtime.CompilerServices;
using UnityEngine.Events;

namespace SLua
{
	// Token: 0x02001885 RID: 6277
	public class LuaUnityEvent_bool : LuaObject
	{
		// Token: 0x06024484 RID: 148612 RVA: 0x00CC1DEC File Offset: 0x00CBFFEC
		[MonoPInvokeCallback(typeof(LuaCSFunction))]
		public static int AddListener(IntPtr l)
		{
			int result;
			try
			{
				UnityEvent<bool> unityEvent = LuaObject.checkSelf<UnityEvent<bool>>(l);
				UnityAction<bool> call;
				LuaUnityEvent_bool.checkType(l, 2, out call);
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

		// Token: 0x06024485 RID: 148613 RVA: 0x00CC1E40 File Offset: 0x00CC0040
		[MonoPInvokeCallback(typeof(LuaCSFunction))]
		public static int RemoveListener(IntPtr l)
		{
			int result;
			try
			{
				UnityEvent<bool> unityEvent = LuaObject.checkSelf<UnityEvent<bool>>(l);
				UnityAction<bool> call;
				LuaUnityEvent_bool.checkType(l, 2, out call);
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

		// Token: 0x06024486 RID: 148614 RVA: 0x00CC1E94 File Offset: 0x00CC0094
		[MonoPInvokeCallback(typeof(LuaCSFunction))]
		public static int Invoke(IntPtr l)
		{
			int result;
			try
			{
				UnityEvent<bool> unityEvent = LuaObject.checkSelf<UnityEvent<bool>>(l);
				bool arg;
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

		// Token: 0x06024487 RID: 148615 RVA: 0x00CC1EE8 File Offset: 0x00CC00E8
		public static void reg(IntPtr l)
		{
			LuaObject.getTypeTable(l, typeof(LuaUnityEvent_bool).FullName);
			if (LuaUnityEvent_bool.<>f__mg$cache0 == null)
			{
				LuaUnityEvent_bool.<>f__mg$cache0 = new LuaCSFunction(LuaUnityEvent_bool.AddListener);
			}
			LuaObject.addMember(l, LuaUnityEvent_bool.<>f__mg$cache0);
			if (LuaUnityEvent_bool.<>f__mg$cache1 == null)
			{
				LuaUnityEvent_bool.<>f__mg$cache1 = new LuaCSFunction(LuaUnityEvent_bool.RemoveListener);
			}
			LuaObject.addMember(l, LuaUnityEvent_bool.<>f__mg$cache1);
			if (LuaUnityEvent_bool.<>f__mg$cache2 == null)
			{
				LuaUnityEvent_bool.<>f__mg$cache2 = new LuaCSFunction(LuaUnityEvent_bool.Invoke);
			}
			LuaObject.addMember(l, LuaUnityEvent_bool.<>f__mg$cache2);
			LuaObject.createTypeMetatable(l, null, typeof(LuaUnityEvent_bool), typeof(UnityEventBase));
		}

		// Token: 0x06024488 RID: 148616 RVA: 0x00CC1F90 File Offset: 0x00CC0190
		private static bool checkType(IntPtr l, int p, out UnityAction<bool> ua)
		{
			LuaDLL.luaL_checktype(l, p, LuaTypes.LUA_TFUNCTION);
			LuaDelegate ld;
			LuaObject.checkType(l, p, out ld);
			if (ld.d != null)
			{
				ua = (UnityAction<bool>)ld.d;
				return true;
			}
			l = LuaState.get(l).L;
			ua = delegate(bool v0)
			{
				int num = LuaObject.pushTry(l);
				LuaObject.pushValue(l, v0);
				ld.pcall(1, num);
				LuaDLL.lua_settop(l, num - 1);
			};
			ld.d = ua;
			return true;
		}

		// Token: 0x04019FD8 RID: 106456
		[CompilerGenerated]
		private static LuaCSFunction <>f__mg$cache0;

		// Token: 0x04019FD9 RID: 106457
		[CompilerGenerated]
		private static LuaCSFunction <>f__mg$cache1;

		// Token: 0x04019FDA RID: 106458
		[CompilerGenerated]
		private static LuaCSFunction <>f__mg$cache2;
	}
}
