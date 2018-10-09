using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectLBasic;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x020015EE RID: 5614
[Preserve]
public class Lua_BlackJack_ProjectLBasic_ShowHideEvent : LuaObject
{
	// Token: 0x060227B5 RID: 141237 RVA: 0x00BD2D3C File Offset: 0x00BD0F3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_eventParam(IntPtr l)
	{
		int result;
		try
		{
			ShowHideEvent showHideEvent = (ShowHideEvent)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, showHideEvent.m_eventParam);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060227B6 RID: 141238 RVA: 0x00BD2D90 File Offset: 0x00BD0F90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_eventParam(IntPtr l)
	{
		int result;
		try
		{
			ShowHideEvent showHideEvent = (ShowHideEvent)LuaObject.checkSelf(l);
			string eventParam;
			LuaObject.checkType(l, 2, out eventParam);
			showHideEvent.m_eventParam = eventParam;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060227B7 RID: 141239 RVA: 0x00BD2DE8 File Offset: 0x00BD0FE8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectLBasic.ShowHideEvent");
		string name = "m_eventParam";
		if (Lua_BlackJack_ProjectLBasic_ShowHideEvent.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectLBasic_ShowHideEvent.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectLBasic_ShowHideEvent.get_m_eventParam);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectLBasic_ShowHideEvent.<>f__mg$cache0;
		if (Lua_BlackJack_ProjectLBasic_ShowHideEvent.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectLBasic_ShowHideEvent.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectLBasic_ShowHideEvent.set_m_eventParam);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectLBasic_ShowHideEvent.<>f__mg$cache1, true);
		LuaObject.createTypeMetatable(l, null, typeof(ShowHideEvent), typeof(MonoBehaviour));
	}

	// Token: 0x040185BB RID: 99771
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040185BC RID: 99772
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;
}
