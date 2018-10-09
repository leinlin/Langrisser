using System;
using System.Runtime.CompilerServices;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace SLua
{
	// Token: 0x0200188D RID: 6285
	public class LuaUnityEvent_UnityEngine_EventSystems_BaseEventData : LuaObject
	{
		// Token: 0x060244A4 RID: 148644 RVA: 0x00CC280C File Offset: 0x00CC0A0C
		[MonoPInvokeCallback(typeof(LuaCSFunction))]
		public static int AddListener(IntPtr l)
		{
			int result;
			try
			{
				UnityEvent<BaseEventData> unityEvent = LuaObject.checkSelf<UnityEvent<BaseEventData>>(l);
				UnityAction<BaseEventData> call;
				LuaUnityEvent_UnityEngine_EventSystems_BaseEventData.checkType(l, 2, out call);
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

		// Token: 0x060244A5 RID: 148645 RVA: 0x00CC2860 File Offset: 0x00CC0A60
		[MonoPInvokeCallback(typeof(LuaCSFunction))]
		public static int RemoveListener(IntPtr l)
		{
			int result;
			try
			{
				UnityEvent<BaseEventData> unityEvent = LuaObject.checkSelf<UnityEvent<BaseEventData>>(l);
				UnityAction<BaseEventData> call;
				LuaUnityEvent_UnityEngine_EventSystems_BaseEventData.checkType(l, 2, out call);
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

		// Token: 0x060244A6 RID: 148646 RVA: 0x00CC28B4 File Offset: 0x00CC0AB4
		[MonoPInvokeCallback(typeof(LuaCSFunction))]
		public static int Invoke(IntPtr l)
		{
			int result;
			try
			{
				UnityEvent<BaseEventData> unityEvent = LuaObject.checkSelf<UnityEvent<BaseEventData>>(l);
				BaseEventData arg;
				LuaObject.checkType<BaseEventData>(l, 2, out arg);
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

		// Token: 0x060244A7 RID: 148647 RVA: 0x00CC2908 File Offset: 0x00CC0B08
		public static void reg(IntPtr l)
		{
			LuaObject.getTypeTable(l, typeof(LuaUnityEvent_UnityEngine_EventSystems_BaseEventData).FullName);
			if (LuaUnityEvent_UnityEngine_EventSystems_BaseEventData.<>f__mg$cache0 == null)
			{
				LuaUnityEvent_UnityEngine_EventSystems_BaseEventData.<>f__mg$cache0 = new LuaCSFunction(LuaUnityEvent_UnityEngine_EventSystems_BaseEventData.AddListener);
			}
			LuaObject.addMember(l, LuaUnityEvent_UnityEngine_EventSystems_BaseEventData.<>f__mg$cache0);
			if (LuaUnityEvent_UnityEngine_EventSystems_BaseEventData.<>f__mg$cache1 == null)
			{
				LuaUnityEvent_UnityEngine_EventSystems_BaseEventData.<>f__mg$cache1 = new LuaCSFunction(LuaUnityEvent_UnityEngine_EventSystems_BaseEventData.RemoveListener);
			}
			LuaObject.addMember(l, LuaUnityEvent_UnityEngine_EventSystems_BaseEventData.<>f__mg$cache1);
			if (LuaUnityEvent_UnityEngine_EventSystems_BaseEventData.<>f__mg$cache2 == null)
			{
				LuaUnityEvent_UnityEngine_EventSystems_BaseEventData.<>f__mg$cache2 = new LuaCSFunction(LuaUnityEvent_UnityEngine_EventSystems_BaseEventData.Invoke);
			}
			LuaObject.addMember(l, LuaUnityEvent_UnityEngine_EventSystems_BaseEventData.<>f__mg$cache2);
			LuaObject.createTypeMetatable(l, null, typeof(LuaUnityEvent_UnityEngine_EventSystems_BaseEventData), typeof(UnityEventBase));
		}

		// Token: 0x060244A8 RID: 148648 RVA: 0x00CC29B0 File Offset: 0x00CC0BB0
		private static bool checkType(IntPtr l, int p, out UnityAction<BaseEventData> ua)
		{
			LuaDLL.luaL_checktype(l, p, LuaTypes.LUA_TFUNCTION);
			LuaDelegate ld;
			LuaObject.checkType(l, p, out ld);
			if (ld.d != null)
			{
				ua = (UnityAction<BaseEventData>)ld.d;
				return true;
			}
			l = LuaState.get(l).L;
			ua = delegate(BaseEventData v0)
			{
				int num = LuaObject.pushTry(l);
				LuaObject.pushValue(l, v0);
				ld.pcall(1, num);
				LuaDLL.lua_settop(l, num - 1);
			};
			ld.d = ua;
			return true;
		}

		// Token: 0x04019FEC RID: 106476
		[CompilerGenerated]
		private static LuaCSFunction <>f__mg$cache0;

		// Token: 0x04019FED RID: 106477
		[CompilerGenerated]
		private static LuaCSFunction <>f__mg$cache1;

		// Token: 0x04019FEE RID: 106478
		[CompilerGenerated]
		private static LuaCSFunction <>f__mg$cache2;
	}
}
