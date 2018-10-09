using System;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Battle;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Scene;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x02001326 RID: 4902
[Preserve]
public class Lua_BlackJack_ProjectL_Scene_ClientBattleTreasure : LuaObject
{
	// Token: 0x0601A56B RID: 107883 RVA: 0x007C87F4 File Offset: 0x007C69F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleTreasure o = new ClientBattleTreasure();
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

	// Token: 0x0601A56C RID: 107884 RVA: 0x007C883C File Offset: 0x007C6A3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Initialize(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleTreasure clientBattleTreasure = (ClientBattleTreasure)LuaObject.checkSelf(l);
			ClientBattle battle;
			LuaObject.checkType<ClientBattle>(l, 2, out battle);
			ConfigDataBattleTreasureInfo treasureInfo;
			LuaObject.checkType<ConfigDataBattleTreasureInfo>(l, 3, out treasureInfo);
			clientBattleTreasure.Initialize(battle, treasureInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A56D RID: 107885 RVA: 0x007C88A0 File Offset: 0x007C6AA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Dispose(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleTreasure clientBattleTreasure = (ClientBattleTreasure)LuaObject.checkSelf(l);
			clientBattleTreasure.Dispose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A56E RID: 107886 RVA: 0x007C88EC File Offset: 0x007C6AEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Tick(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleTreasure clientBattleTreasure = (ClientBattleTreasure)LuaObject.checkSelf(l);
			clientBattleTreasure.Tick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A56F RID: 107887 RVA: 0x007C8938 File Offset: 0x007C6B38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Draw(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleTreasure clientBattleTreasure = (ClientBattleTreasure)LuaObject.checkSelf(l);
			clientBattleTreasure.Draw();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A570 RID: 107888 RVA: 0x007C8984 File Offset: 0x007C6B84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DoPause(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleTreasure clientBattleTreasure = (ClientBattleTreasure)LuaObject.checkSelf(l);
			bool pause;
			LuaObject.checkType(l, 2, out pause);
			clientBattleTreasure.DoPause(pause);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A571 RID: 107889 RVA: 0x007C89DC File Offset: 0x007C6BDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetOpened(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleTreasure clientBattleTreasure = (ClientBattleTreasure)LuaObject.checkSelf(l);
			bool opened;
			LuaObject.checkType(l, 2, out opened);
			clientBattleTreasure.SetOpened(opened);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A572 RID: 107890 RVA: 0x007C8A34 File Offset: 0x007C6C34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsOpened(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleTreasure clientBattleTreasure = (ClientBattleTreasure)LuaObject.checkSelf(l);
			bool b = clientBattleTreasure.IsOpened();
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

	// Token: 0x0601A573 RID: 107891 RVA: 0x007C8A88 File Offset: 0x007C6C88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Open(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleTreasure clientBattleTreasure = (ClientBattleTreasure)LuaObject.checkSelf(l);
			clientBattleTreasure.Open();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A574 RID: 107892 RVA: 0x007C8AD4 File Offset: 0x007C6CD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetGraphicSkillFade(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleTreasure clientBattleTreasure = (ClientBattleTreasure)LuaObject.checkSelf(l);
			bool graphicSkillFade;
			LuaObject.checkType(l, 2, out graphicSkillFade);
			clientBattleTreasure.SetGraphicSkillFade(graphicSkillFade);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A575 RID: 107893 RVA: 0x007C8B2C File Offset: 0x007C6D2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateGraphicPosition(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleTreasure clientBattleTreasure = (ClientBattleTreasure)LuaObject.checkSelf(l);
			float zoffset;
			LuaObject.checkType(l, 2, out zoffset);
			clientBattleTreasure.m_luaExportHelper.UpdateGraphicPosition(zoffset);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A576 RID: 107894 RVA: 0x007C8B88 File Offset: 0x007C6D88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ComputeGraphicPosition(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleTreasure clientBattleTreasure = (ClientBattleTreasure)LuaObject.checkSelf(l);
			Vector2 p;
			LuaObject.checkType(l, 2, out p);
			float zoffset;
			LuaObject.checkType(l, 3, out zoffset);
			Vector3 o = clientBattleTreasure.m_luaExportHelper.ComputeGraphicPosition(p, zoffset);
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

	// Token: 0x0601A577 RID: 107895 RVA: 0x007C8BFC File Offset: 0x007C6DFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Dispose(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleTreasure clientBattleTreasure = (ClientBattleTreasure)LuaObject.checkSelf(l);
			clientBattleTreasure.m_luaExportHelper.__callBase_Dispose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A578 RID: 107896 RVA: 0x007C8C50 File Offset: 0x007C6E50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Tick(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleTreasure clientBattleTreasure = (ClientBattleTreasure)LuaObject.checkSelf(l);
			clientBattleTreasure.m_luaExportHelper.__callBase_Tick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A579 RID: 107897 RVA: 0x007C8CA4 File Offset: 0x007C6EA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_TickGraphic(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleTreasure clientBattleTreasure = (ClientBattleTreasure)LuaObject.checkSelf(l);
			float dt;
			LuaObject.checkType(l, 2, out dt);
			clientBattleTreasure.m_luaExportHelper.__callBase_TickGraphic(dt);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A57A RID: 107898 RVA: 0x007C8D00 File Offset: 0x007C6F00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Draw(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleTreasure clientBattleTreasure = (ClientBattleTreasure)LuaObject.checkSelf(l);
			clientBattleTreasure.m_luaExportHelper.__callBase_Draw();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A57B RID: 107899 RVA: 0x007C8D54 File Offset: 0x007C6F54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Pause(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleTreasure clientBattleTreasure = (ClientBattleTreasure)LuaObject.checkSelf(l);
			bool pause;
			LuaObject.checkType(l, 2, out pause);
			clientBattleTreasure.m_luaExportHelper.__callBase_Pause(pause);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A57C RID: 107900 RVA: 0x007C8DB0 File Offset: 0x007C6FB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_DoPause(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleTreasure clientBattleTreasure = (ClientBattleTreasure)LuaObject.checkSelf(l);
			bool pause;
			LuaObject.checkType(l, 2, out pause);
			clientBattleTreasure.m_luaExportHelper.__callBase_DoPause(pause);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A57D RID: 107901 RVA: 0x007C8E0C File Offset: 0x007C700C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_DeleteMe(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleTreasure clientBattleTreasure = (ClientBattleTreasure)LuaObject.checkSelf(l);
			clientBattleTreasure.m_luaExportHelper.__callBase_DeleteMe();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A57E RID: 107902 RVA: 0x007C8E60 File Offset: 0x007C7060
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_clientBattle(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleTreasure clientBattleTreasure = (ClientBattleTreasure)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientBattleTreasure.m_luaExportHelper.m_clientBattle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A57F RID: 107903 RVA: 0x007C8EB8 File Offset: 0x007C70B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_clientBattle(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleTreasure clientBattleTreasure = (ClientBattleTreasure)LuaObject.checkSelf(l);
			ClientBattle clientBattle;
			LuaObject.checkType<ClientBattle>(l, 2, out clientBattle);
			clientBattleTreasure.m_luaExportHelper.m_clientBattle = clientBattle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A580 RID: 107904 RVA: 0x007C8F14 File Offset: 0x007C7114
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_battleTreasureInfo(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleTreasure clientBattleTreasure = (ClientBattleTreasure)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientBattleTreasure.m_luaExportHelper.m_battleTreasureInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A581 RID: 107905 RVA: 0x007C8F6C File Offset: 0x007C716C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_battleTreasureInfo(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleTreasure clientBattleTreasure = (ClientBattleTreasure)LuaObject.checkSelf(l);
			ConfigDataBattleTreasureInfo battleTreasureInfo;
			LuaObject.checkType<ConfigDataBattleTreasureInfo>(l, 2, out battleTreasureInfo);
			clientBattleTreasure.m_luaExportHelper.m_battleTreasureInfo = battleTreasureInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A582 RID: 107906 RVA: 0x007C8FC8 File Offset: 0x007C71C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_graphic(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleTreasure clientBattleTreasure = (ClientBattleTreasure)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientBattleTreasure.m_luaExportHelper.m_graphic);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A583 RID: 107907 RVA: 0x007C9020 File Offset: 0x007C7220
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_graphic(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleTreasure clientBattleTreasure = (ClientBattleTreasure)LuaObject.checkSelf(l);
			GenericGraphic graphic;
			LuaObject.checkType<GenericGraphic>(l, 2, out graphic);
			clientBattleTreasure.m_luaExportHelper.m_graphic = graphic;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A584 RID: 107908 RVA: 0x007C907C File Offset: 0x007C727C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_position(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleTreasure clientBattleTreasure = (ClientBattleTreasure)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientBattleTreasure.m_luaExportHelper.m_position);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A585 RID: 107909 RVA: 0x007C90D8 File Offset: 0x007C72D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_position(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleTreasure clientBattleTreasure = (ClientBattleTreasure)LuaObject.checkSelf(l);
			GridPosition position;
			LuaObject.checkValueType<GridPosition>(l, 2, out position);
			clientBattleTreasure.m_luaExportHelper.m_position = position;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A586 RID: 107910 RVA: 0x007C9134 File Offset: 0x007C7334
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isOpened(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleTreasure clientBattleTreasure = (ClientBattleTreasure)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientBattleTreasure.m_luaExportHelper.m_isOpened);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A587 RID: 107911 RVA: 0x007C918C File Offset: 0x007C738C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isOpened(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleTreasure clientBattleTreasure = (ClientBattleTreasure)LuaObject.checkSelf(l);
			bool isOpened;
			LuaObject.checkType(l, 2, out isOpened);
			clientBattleTreasure.m_luaExportHelper.m_isOpened = isOpened;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A588 RID: 107912 RVA: 0x007C91E8 File Offset: 0x007C73E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isGraphicSkillFade(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleTreasure clientBattleTreasure = (ClientBattleTreasure)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientBattleTreasure.m_luaExportHelper.m_isGraphicSkillFade);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A589 RID: 107913 RVA: 0x007C9240 File Offset: 0x007C7440
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isGraphicSkillFade(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleTreasure clientBattleTreasure = (ClientBattleTreasure)LuaObject.checkSelf(l);
			bool isGraphicSkillFade;
			LuaObject.checkType(l, 2, out isGraphicSkillFade);
			clientBattleTreasure.m_luaExportHelper.m_isGraphicSkillFade = isGraphicSkillFade;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A58A RID: 107914 RVA: 0x007C929C File Offset: 0x007C749C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Position(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleTreasure clientBattleTreasure = (ClientBattleTreasure)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientBattleTreasure.Position);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A58B RID: 107915 RVA: 0x007C92F4 File Offset: 0x007C74F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_BattleTreasureInfo(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleTreasure clientBattleTreasure = (ClientBattleTreasure)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientBattleTreasure.BattleTreasureInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A58C RID: 107916 RVA: 0x007C9348 File Offset: 0x007C7548
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Scene.ClientBattleTreasure");
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleTreasure.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleTreasure.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleTreasure.Initialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattleTreasure.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleTreasure.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleTreasure.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleTreasure.Dispose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattleTreasure.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleTreasure.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleTreasure.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleTreasure.Tick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattleTreasure.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleTreasure.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleTreasure.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleTreasure.Draw);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattleTreasure.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleTreasure.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleTreasure.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleTreasure.DoPause);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattleTreasure.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleTreasure.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleTreasure.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleTreasure.SetOpened);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattleTreasure.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleTreasure.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleTreasure.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleTreasure.IsOpened);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattleTreasure.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleTreasure.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleTreasure.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleTreasure.Open);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattleTreasure.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleTreasure.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleTreasure.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleTreasure.SetGraphicSkillFade);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattleTreasure.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleTreasure.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleTreasure.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleTreasure.UpdateGraphicPosition);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattleTreasure.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleTreasure.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleTreasure.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleTreasure.ComputeGraphicPosition);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattleTreasure.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleTreasure.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleTreasure.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleTreasure.__callBase_Dispose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattleTreasure.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleTreasure.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleTreasure.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleTreasure.__callBase_Tick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattleTreasure.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleTreasure.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleTreasure.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleTreasure.__callBase_TickGraphic);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattleTreasure.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleTreasure.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleTreasure.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleTreasure.__callBase_Draw);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattleTreasure.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleTreasure.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleTreasure.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleTreasure.__callBase_Pause);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattleTreasure.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleTreasure.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleTreasure.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleTreasure.__callBase_DoPause);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattleTreasure.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleTreasure.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleTreasure.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleTreasure.__callBase_DeleteMe);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientBattleTreasure.<>f__mg$cache11);
		string name = "m_clientBattle";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleTreasure.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleTreasure.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleTreasure.get_m_clientBattle);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Scene_ClientBattleTreasure.<>f__mg$cache12;
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleTreasure.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleTreasure.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleTreasure.set_m_clientBattle);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Scene_ClientBattleTreasure.<>f__mg$cache13, true);
		string name2 = "m_battleTreasureInfo";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleTreasure.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleTreasure.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleTreasure.get_m_battleTreasureInfo);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Scene_ClientBattleTreasure.<>f__mg$cache14;
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleTreasure.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleTreasure.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleTreasure.set_m_battleTreasureInfo);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Scene_ClientBattleTreasure.<>f__mg$cache15, true);
		string name3 = "m_graphic";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleTreasure.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleTreasure.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleTreasure.get_m_graphic);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Scene_ClientBattleTreasure.<>f__mg$cache16;
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleTreasure.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleTreasure.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleTreasure.set_m_graphic);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Scene_ClientBattleTreasure.<>f__mg$cache17, true);
		string name4 = "m_position";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleTreasure.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleTreasure.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleTreasure.get_m_position);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Scene_ClientBattleTreasure.<>f__mg$cache18;
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleTreasure.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleTreasure.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleTreasure.set_m_position);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Scene_ClientBattleTreasure.<>f__mg$cache19, true);
		string name5 = "m_isOpened";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleTreasure.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleTreasure.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleTreasure.get_m_isOpened);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_Scene_ClientBattleTreasure.<>f__mg$cache1A;
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleTreasure.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleTreasure.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleTreasure.set_m_isOpened);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_Scene_ClientBattleTreasure.<>f__mg$cache1B, true);
		string name6 = "m_isGraphicSkillFade";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleTreasure.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleTreasure.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleTreasure.get_m_isGraphicSkillFade);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_Scene_ClientBattleTreasure.<>f__mg$cache1C;
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleTreasure.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleTreasure.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleTreasure.set_m_isGraphicSkillFade);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_Scene_ClientBattleTreasure.<>f__mg$cache1D, true);
		string name7 = "Position";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleTreasure.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleTreasure.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleTreasure.get_Position);
		}
		LuaObject.addMember(l, name7, Lua_BlackJack_ProjectL_Scene_ClientBattleTreasure.<>f__mg$cache1E, null, true);
		string name8 = "BattleTreasureInfo";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleTreasure.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleTreasure.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleTreasure.get_BattleTreasureInfo);
		}
		LuaObject.addMember(l, name8, Lua_BlackJack_ProjectL_Scene_ClientBattleTreasure.<>f__mg$cache1F, null, true);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleTreasure.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleTreasure.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleTreasure.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Scene_ClientBattleTreasure.<>f__mg$cache20, typeof(ClientBattleTreasure), typeof(Entity));
	}

	// Token: 0x04010901 RID: 67841
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04010902 RID: 67842
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04010903 RID: 67843
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04010904 RID: 67844
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04010905 RID: 67845
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04010906 RID: 67846
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04010907 RID: 67847
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04010908 RID: 67848
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04010909 RID: 67849
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0401090A RID: 67850
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0401090B RID: 67851
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0401090C RID: 67852
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0401090D RID: 67853
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0401090E RID: 67854
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0401090F RID: 67855
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04010910 RID: 67856
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04010911 RID: 67857
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04010912 RID: 67858
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04010913 RID: 67859
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04010914 RID: 67860
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04010915 RID: 67861
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04010916 RID: 67862
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04010917 RID: 67863
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04010918 RID: 67864
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04010919 RID: 67865
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0401091A RID: 67866
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0401091B RID: 67867
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0401091C RID: 67868
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0401091D RID: 67869
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0401091E RID: 67870
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0401091F RID: 67871
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04010920 RID: 67872
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04010921 RID: 67873
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;
}
