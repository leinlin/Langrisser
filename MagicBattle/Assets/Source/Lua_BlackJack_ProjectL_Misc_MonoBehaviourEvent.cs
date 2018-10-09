using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Misc;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x020012AE RID: 4782
[Preserve]
public class Lua_BlackJack_ProjectL_Misc_MonoBehaviourEvent : LuaObject
{
	// Token: 0x0601913C RID: 102716 RVA: 0x007260D4 File Offset: 0x007242D4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetListener(IntPtr l)
	{
		int result;
		try
		{
			MonoBehaviourEvent monoBehaviourEvent = (MonoBehaviourEvent)LuaObject.checkSelf(l);
			IMonoBehaviourEventListener listener;
			LuaObject.checkType<IMonoBehaviourEventListener>(l, 2, out listener);
			monoBehaviourEvent.SetListener(listener);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601913D RID: 102717 RVA: 0x0072612C File Offset: 0x0072432C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Misc.MonoBehaviourEvent");
		if (Lua_BlackJack_ProjectL_Misc_MonoBehaviourEvent.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Misc_MonoBehaviourEvent.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_MonoBehaviourEvent.SetListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Misc_MonoBehaviourEvent.<>f__mg$cache0);
		LuaObject.createTypeMetatable(l, null, typeof(MonoBehaviourEvent), typeof(MonoBehaviour));
	}

	// Token: 0x0400F5C2 RID: 62914
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
