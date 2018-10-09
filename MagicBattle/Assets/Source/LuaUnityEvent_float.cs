using System;
using System.Runtime.CompilerServices;
using UnityEngine.Events;

namespace SLua
{
	// Token: 0x02001887 RID: 6279
	public class LuaUnityEvent_float : LuaObject
	{
		// Token: 0x0602448C RID: 148620 RVA: 0x00CC2074 File Offset: 0x00CC0274
		[MonoPInvokeCallback(typeof(LuaCSFunction))]
		public static int AddListener(IntPtr l)
		{
			int result;
			try
			{
				UnityEvent<float> unityEvent = LuaObject.checkSelf<UnityEvent<float>>(l);
				UnityAction<float> call;
				LuaUnityEvent_float.checkType(l, 2, out call);
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

		// Token: 0x0602448D RID: 148621 RVA: 0x00CC20C8 File Offset: 0x00CC02C8
		[MonoPInvokeCallback(typeof(LuaCSFunction))]
		public static int RemoveListener(IntPtr l)
		{
			int result;
			try
			{
				UnityEvent<float> unityEvent = LuaObject.checkSelf<UnityEvent<float>>(l);
				UnityAction<float> call;
				LuaUnityEvent_float.checkType(l, 2, out call);
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

		// Token: 0x0602448E RID: 148622 RVA: 0x00CC211C File Offset: 0x00CC031C
		[MonoPInvokeCallback(typeof(LuaCSFunction))]
		public static int Invoke(IntPtr l)
		{
			int result;
			try
			{
				UnityEvent<float> unityEvent = LuaObject.checkSelf<UnityEvent<float>>(l);
				float arg;
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

		// Token: 0x0602448F RID: 148623 RVA: 0x00CC2170 File Offset: 0x00CC0370
		public static void reg(IntPtr l)
		{
			LuaObject.getTypeTable(l, typeof(LuaUnityEvent_float).FullName);
			if (LuaUnityEvent_float.<>f__mg$cache0 == null)
			{
				LuaUnityEvent_float.<>f__mg$cache0 = new LuaCSFunction(LuaUnityEvent_float.AddListener);
			}
			LuaObject.addMember(l, LuaUnityEvent_float.<>f__mg$cache0);
			if (LuaUnityEvent_float.<>f__mg$cache1 == null)
			{
				LuaUnityEvent_float.<>f__mg$cache1 = new LuaCSFunction(LuaUnityEvent_float.RemoveListener);
			}
			LuaObject.addMember(l, LuaUnityEvent_float.<>f__mg$cache1);
			if (LuaUnityEvent_float.<>f__mg$cache2 == null)
			{
				LuaUnityEvent_float.<>f__mg$cache2 = new LuaCSFunction(LuaUnityEvent_float.Invoke);
			}
			LuaObject.addMember(l, LuaUnityEvent_float.<>f__mg$cache2);
			LuaObject.createTypeMetatable(l, null, typeof(LuaUnityEvent_float), typeof(UnityEventBase));
		}

		// Token: 0x06024490 RID: 148624 RVA: 0x00CC2218 File Offset: 0x00CC0418
		private static bool checkType(IntPtr l, int p, out UnityAction<float> ua)
		{
			LuaDLL.luaL_checktype(l, p, LuaTypes.LUA_TFUNCTION);
			LuaDelegate ld;
			LuaObject.checkType(l, p, out ld);
			if (ld.d != null)
			{
				ua = (UnityAction<float>)ld.d;
				return true;
			}
			l = LuaState.get(l).L;
			ua = delegate(float v0)
			{
				int num = LuaObject.pushTry(l);
				LuaObject.pushValue(l, v0);
				ld.pcall(1, num);
				LuaDLL.lua_settop(l, num - 1);
			};
			ld.d = ua;
			return true;
		}

		// Token: 0x04019FDD RID: 106461
		[CompilerGenerated]
		private static LuaCSFunction <>f__mg$cache0;

		// Token: 0x04019FDE RID: 106462
		[CompilerGenerated]
		private static LuaCSFunction <>f__mg$cache1;

		// Token: 0x04019FDF RID: 106463
		[CompilerGenerated]
		private static LuaCSFunction <>f__mg$cache2;
	}
}
