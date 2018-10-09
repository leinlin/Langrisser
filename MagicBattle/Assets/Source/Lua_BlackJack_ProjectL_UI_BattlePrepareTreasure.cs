using System;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Scene;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x020013AE RID: 5038
[Preserve]
public class Lua_BlackJack_ProjectL_UI_BattlePrepareTreasure : LuaObject
{
	// Token: 0x0601BC18 RID: 113688 RVA: 0x0087A9BC File Offset: 0x00878BBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareTreasure o = new BattlePrepareTreasure();
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

	// Token: 0x0601BC19 RID: 113689 RVA: 0x0087AA04 File Offset: 0x00878C04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Initialize(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareTreasure battlePrepareTreasure = (BattlePrepareTreasure)LuaObject.checkSelf(l);
			ClientBattle clientBattle;
			LuaObject.checkType<ClientBattle>(l, 2, out clientBattle);
			ConfigDataBattleTreasureInfo treasureInfo;
			LuaObject.checkType<ConfigDataBattleTreasureInfo>(l, 3, out treasureInfo);
			battlePrepareTreasure.Initialize(clientBattle, treasureInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BC1A RID: 113690 RVA: 0x0087AA68 File Offset: 0x00878C68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetBattleTreasureInfo(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareTreasure battlePrepareTreasure = (BattlePrepareTreasure)LuaObject.checkSelf(l);
			ConfigDataBattleTreasureInfo battleTreasureInfo = battlePrepareTreasure.GetBattleTreasureInfo();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleTreasureInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BC1B RID: 113691 RVA: 0x0087AABC File Offset: 0x00878CBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Destroy(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareTreasure battlePrepareTreasure = (BattlePrepareTreasure)LuaObject.checkSelf(l);
			battlePrepareTreasure.Destroy();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BC1C RID: 113692 RVA: 0x0087AB08 File Offset: 0x00878D08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Pause(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareTreasure battlePrepareTreasure = (BattlePrepareTreasure)LuaObject.checkSelf(l);
			bool pause;
			LuaObject.checkType(l, 2, out pause);
			battlePrepareTreasure.Pause(pause);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BC1D RID: 113693 RVA: 0x0087AB60 File Offset: 0x00878D60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetOpened(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareTreasure battlePrepareTreasure = (BattlePrepareTreasure)LuaObject.checkSelf(l);
			bool opened;
			LuaObject.checkType(l, 2, out opened);
			battlePrepareTreasure.SetOpened(opened);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BC1E RID: 113694 RVA: 0x0087ABB8 File Offset: 0x00878DB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsOpened(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareTreasure battlePrepareTreasure = (BattlePrepareTreasure)LuaObject.checkSelf(l);
			bool b = battlePrepareTreasure.IsOpened();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BC1F RID: 113695 RVA: 0x0087AC0C File Offset: 0x00878E0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ComputeGraphicPosition(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareTreasure battlePrepareTreasure = (BattlePrepareTreasure)LuaObject.checkSelf(l);
			Vector2 p;
			LuaObject.checkType(l, 2, out p);
			float zoffset;
			LuaObject.checkType(l, 3, out zoffset);
			Vector3 o = battlePrepareTreasure.m_luaExportHelper.ComputeGraphicPosition(p, zoffset);
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

	// Token: 0x0601BC20 RID: 113696 RVA: 0x0087AC80 File Offset: 0x00878E80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_clientBattle(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareTreasure battlePrepareTreasure = (BattlePrepareTreasure)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareTreasure.m_luaExportHelper.m_clientBattle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BC21 RID: 113697 RVA: 0x0087ACD8 File Offset: 0x00878ED8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_clientBattle(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareTreasure battlePrepareTreasure = (BattlePrepareTreasure)LuaObject.checkSelf(l);
			ClientBattle clientBattle;
			LuaObject.checkType<ClientBattle>(l, 2, out clientBattle);
			battlePrepareTreasure.m_luaExportHelper.m_clientBattle = clientBattle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BC22 RID: 113698 RVA: 0x0087AD34 File Offset: 0x00878F34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_battleTreasureInfo(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareTreasure battlePrepareTreasure = (BattlePrepareTreasure)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareTreasure.m_luaExportHelper.m_battleTreasureInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BC23 RID: 113699 RVA: 0x0087AD8C File Offset: 0x00878F8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_battleTreasureInfo(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareTreasure battlePrepareTreasure = (BattlePrepareTreasure)LuaObject.checkSelf(l);
			ConfigDataBattleTreasureInfo battleTreasureInfo;
			LuaObject.checkType<ConfigDataBattleTreasureInfo>(l, 2, out battleTreasureInfo);
			battlePrepareTreasure.m_luaExportHelper.m_battleTreasureInfo = battleTreasureInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BC24 RID: 113700 RVA: 0x0087ADE8 File Offset: 0x00878FE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_graphic(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareTreasure battlePrepareTreasure = (BattlePrepareTreasure)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareTreasure.m_luaExportHelper.m_graphic);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BC25 RID: 113701 RVA: 0x0087AE40 File Offset: 0x00879040
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_graphic(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareTreasure battlePrepareTreasure = (BattlePrepareTreasure)LuaObject.checkSelf(l);
			GenericGraphic graphic;
			LuaObject.checkType<GenericGraphic>(l, 2, out graphic);
			battlePrepareTreasure.m_luaExportHelper.m_graphic = graphic;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BC26 RID: 113702 RVA: 0x0087AE9C File Offset: 0x0087909C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_position(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareTreasure battlePrepareTreasure = (BattlePrepareTreasure)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareTreasure.m_luaExportHelper.m_position);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BC27 RID: 113703 RVA: 0x0087AEF8 File Offset: 0x008790F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_position(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareTreasure battlePrepareTreasure = (BattlePrepareTreasure)LuaObject.checkSelf(l);
			GridPosition position;
			LuaObject.checkValueType<GridPosition>(l, 2, out position);
			battlePrepareTreasure.m_luaExportHelper.m_position = position;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BC28 RID: 113704 RVA: 0x0087AF54 File Offset: 0x00879154
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isOpened(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareTreasure battlePrepareTreasure = (BattlePrepareTreasure)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePrepareTreasure.m_luaExportHelper.m_isOpened);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BC29 RID: 113705 RVA: 0x0087AFAC File Offset: 0x008791AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isOpened(IntPtr l)
	{
		int result;
		try
		{
			BattlePrepareTreasure battlePrepareTreasure = (BattlePrepareTreasure)LuaObject.checkSelf(l);
			bool isOpened;
			LuaObject.checkType(l, 2, out isOpened);
			battlePrepareTreasure.m_luaExportHelper.m_isOpened = isOpened;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BC2A RID: 113706 RVA: 0x0087B008 File Offset: 0x00879208
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.BattlePrepareTreasure");
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareTreasure.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareTreasure.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareTreasure.Initialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareTreasure.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareTreasure.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareTreasure.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareTreasure.GetBattleTreasureInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareTreasure.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareTreasure.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareTreasure.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareTreasure.Destroy);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareTreasure.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareTreasure.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareTreasure.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareTreasure.Pause);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareTreasure.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareTreasure.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareTreasure.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareTreasure.SetOpened);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareTreasure.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareTreasure.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareTreasure.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareTreasure.IsOpened);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareTreasure.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareTreasure.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareTreasure.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareTreasure.ComputeGraphicPosition);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattlePrepareTreasure.<>f__mg$cache6);
		string name = "m_clientBattle";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareTreasure.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareTreasure.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareTreasure.get_m_clientBattle);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_BattlePrepareTreasure.<>f__mg$cache7;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareTreasure.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareTreasure.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareTreasure.set_m_clientBattle);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_BattlePrepareTreasure.<>f__mg$cache8, true);
		string name2 = "m_battleTreasureInfo";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareTreasure.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareTreasure.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareTreasure.get_m_battleTreasureInfo);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_BattlePrepareTreasure.<>f__mg$cache9;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareTreasure.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareTreasure.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareTreasure.set_m_battleTreasureInfo);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_BattlePrepareTreasure.<>f__mg$cacheA, true);
		string name3 = "m_graphic";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareTreasure.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareTreasure.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareTreasure.get_m_graphic);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_BattlePrepareTreasure.<>f__mg$cacheB;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareTreasure.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareTreasure.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareTreasure.set_m_graphic);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_BattlePrepareTreasure.<>f__mg$cacheC, true);
		string name4 = "m_position";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareTreasure.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareTreasure.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareTreasure.get_m_position);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_BattlePrepareTreasure.<>f__mg$cacheD;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareTreasure.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareTreasure.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareTreasure.set_m_position);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_BattlePrepareTreasure.<>f__mg$cacheE, true);
		string name5 = "m_isOpened";
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareTreasure.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareTreasure.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareTreasure.get_m_isOpened);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_BattlePrepareTreasure.<>f__mg$cacheF;
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareTreasure.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareTreasure.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareTreasure.set_m_isOpened);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_BattlePrepareTreasure.<>f__mg$cache10, true);
		if (Lua_BlackJack_ProjectL_UI_BattlePrepareTreasure.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattlePrepareTreasure.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattlePrepareTreasure.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_BattlePrepareTreasure.<>f__mg$cache11, typeof(BattlePrepareTreasure));
	}

	// Token: 0x04011E9E RID: 73374
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04011E9F RID: 73375
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04011EA0 RID: 73376
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04011EA1 RID: 73377
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04011EA2 RID: 73378
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04011EA3 RID: 73379
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04011EA4 RID: 73380
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04011EA5 RID: 73381
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04011EA6 RID: 73382
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04011EA7 RID: 73383
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04011EA8 RID: 73384
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04011EA9 RID: 73385
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04011EAA RID: 73386
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04011EAB RID: 73387
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04011EAC RID: 73388
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04011EAD RID: 73389
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04011EAE RID: 73390
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04011EAF RID: 73391
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;
}
