using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Scene;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001324 RID: 4900
[Preserve]
public class Lua_BlackJack_ProjectL_Scene_ClientBattleActor_GraphicState : LuaObject
{
	// Token: 0x0601A53E RID: 107838 RVA: 0x007C7558 File Offset: 0x007C5758
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleActor.GraphicState o = new ClientBattleActor.GraphicState();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, o);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A53F RID: 107839 RVA: 0x007C75A0 File Offset: 0x007C57A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_graphic(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleActor.GraphicState graphicState = (ClientBattleActor.GraphicState)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, graphicState.m_graphic);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A540 RID: 107840 RVA: 0x007C75F4 File Offset: 0x007C57F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_graphic(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleActor.GraphicState graphicState = (ClientBattleActor.GraphicState)LuaObject.checkSelf(l);
			GenericGraphic graphic;
			LuaObject.checkType<GenericGraphic>(l, 2, out graphic);
			graphicState.m_graphic = graphic;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A541 RID: 107841 RVA: 0x007C764C File Offset: 0x007C584C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_hideCountdown(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleActor.GraphicState graphicState = (ClientBattleActor.GraphicState)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, graphicState.m_hideCountdown);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A542 RID: 107842 RVA: 0x007C76A0 File Offset: 0x007C58A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_hideCountdown(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleActor.GraphicState graphicState = (ClientBattleActor.GraphicState)LuaObject.checkSelf(l);
			float hideCountdown;
			LuaObject.checkType(l, 2, out hideCountdown);
			graphicState.m_hideCountdown = hideCountdown;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A543 RID: 107843 RVA: 0x007C76F8 File Offset: 0x007C58F8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Scene.ClientBattleActor.GraphicState");
		string name = "m_graphic";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleActor_GraphicState.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleActor_GraphicState.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleActor_GraphicState.get_m_graphic);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Scene_ClientBattleActor_GraphicState.<>f__mg$cache0;
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleActor_GraphicState.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleActor_GraphicState.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleActor_GraphicState.set_m_graphic);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Scene_ClientBattleActor_GraphicState.<>f__mg$cache1, true);
		string name2 = "m_hideCountdown";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleActor_GraphicState.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleActor_GraphicState.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleActor_GraphicState.get_m_hideCountdown);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Scene_ClientBattleActor_GraphicState.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleActor_GraphicState.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleActor_GraphicState.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleActor_GraphicState.set_m_hideCountdown);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Scene_ClientBattleActor_GraphicState.<>f__mg$cache3, true);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleActor_GraphicState.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleActor_GraphicState.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleActor_GraphicState.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Scene_ClientBattleActor_GraphicState.<>f__mg$cache4, typeof(ClientBattleActor.GraphicState));
	}

	// Token: 0x040108D8 RID: 67800
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040108D9 RID: 67801
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040108DA RID: 67802
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040108DB RID: 67803
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040108DC RID: 67804
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;
}
