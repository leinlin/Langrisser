using System;
using System.Runtime.CompilerServices;
using UnityEngine.Events;

namespace SLua
{
	// Token: 0x02001889 RID: 6281
	public class LuaUnityEvent_int : LuaObject
	{
		// Token: 0x06024494 RID: 148628 RVA: 0x00CC22FC File Offset: 0x00CC04FC
		[MonoPInvokeCallback(typeof(LuaCSFunction))]
		public static int AddListener(IntPtr l)
		{
			int result;
			try
			{
				UnityEvent<int> unityEvent = LuaObject.checkSelf<UnityEvent<int>>(l);
				UnityAction<int> call;
				LuaUnityEvent_int.checkType(l, 2, out call);
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

		// Token: 0x06024495 RID: 148629 RVA: 0x00CC2350 File Offset: 0x00CC0550
		[MonoPInvokeCallback(typeof(LuaCSFunction))]
		public static int RemoveListener(IntPtr l)
		{
			int result;
			try
			{
				UnityEvent<int> unityEvent = LuaObject.checkSelf<UnityEvent<int>>(l);
				UnityAction<int> call;
				LuaUnityEvent_int.checkType(l, 2, out call);
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

		// Token: 0x06024496 RID: 148630 RVA: 0x00CC23A4 File Offset: 0x00CC05A4
		[MonoPInvokeCallback(typeof(LuaCSFunction))]
		public static int Invoke(IntPtr l)
		{
			int result;
			try
			{
				UnityEvent<int> unityEvent = LuaObject.checkSelf<UnityEvent<int>>(l);
				int arg;
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

		// Token: 0x06024497 RID: 148631 RVA: 0x00CC23F8 File Offset: 0x00CC05F8
		public static void reg(IntPtr l)
		{
			LuaObject.getTypeTable(l, typeof(LuaUnityEvent_int).FullName);
			if (LuaUnityEvent_int.<>f__mg$cache0 == null)
			{
				LuaUnityEvent_int.<>f__mg$cache0 = new LuaCSFunction(LuaUnityEvent_int.AddListener);
			}
			LuaObject.addMember(l, LuaUnityEvent_int.<>f__mg$cache0);
			if (LuaUnityEvent_int.<>f__mg$cache1 == null)
			{
				LuaUnityEvent_int.<>f__mg$cache1 = new LuaCSFunction(LuaUnityEvent_int.RemoveListener);
			}
			LuaObject.addMember(l, LuaUnityEvent_int.<>f__mg$cache1);
			if (LuaUnityEvent_int.<>f__mg$cache2 == null)
			{
				LuaUnityEvent_int.<>f__mg$cache2 = new LuaCSFunction(LuaUnityEvent_int.Invoke);
			}
			LuaObject.addMember(l, LuaUnityEvent_int.<>f__mg$cache2);
			LuaObject.createTypeMetatable(l, null, typeof(LuaUnityEvent_int), typeof(UnityEventBase));
		}

		// Token: 0x06024498 RID: 148632 RVA: 0x00CC24A0 File Offset: 0x00CC06A0
		private static bool checkType(IntPtr l, int p, out UnityAction<int> ua)
		{
			LuaDLL.luaL_checktype(l, p, LuaTypes.LUA_TFUNCTION);
			LuaDelegate ld;
			LuaObject.checkType(l, p, out ld);
			if (ld.d != null)
			{
				ua = (UnityAction<int>)ld.d;
				return true;
			}
			l = LuaState.get(l).L;
			ua = delegate(int v0)
			{
				int num = LuaObject.pushTry(l);
				LuaObject.pushValue(l, v0);
				ld.pcall(1, num);
				LuaDLL.lua_settop(l, num - 1);
			};
			ld.d = ua;
			return true;
		}

		// Token: 0x04019FE2 RID: 106466
		[CompilerGenerated]
		private static LuaCSFunction <>f__mg$cache0;

		// Token: 0x04019FE3 RID: 106467
		[CompilerGenerated]
		private static LuaCSFunction <>f__mg$cache1;

		// Token: 0x04019FE4 RID: 106468
		[CompilerGenerated]
		private static LuaCSFunction <>f__mg$cache2;
	}
}
