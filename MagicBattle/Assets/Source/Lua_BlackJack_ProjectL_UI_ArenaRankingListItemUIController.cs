using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.Protocol;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x0200137E RID: 4990
[Preserve]
public class Lua_BlackJack_ProjectL_UI_ArenaRankingListItemUIController : LuaObject
{
	// Token: 0x0601B005 RID: 110597 RVA: 0x0081AA78 File Offset: 0x00818C78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetRanking(IntPtr l)
	{
		int result;
		try
		{
			ArenaRankingListItemUIController arenaRankingListItemUIController = (ArenaRankingListItemUIController)LuaObject.checkSelf(l);
			int ranking;
			LuaObject.checkType(l, 2, out ranking);
			arenaRankingListItemUIController.SetRanking(ranking);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B006 RID: 110598 RVA: 0x0081AAD0 File Offset: 0x00818CD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetIndex(IntPtr l)
	{
		int result;
		try
		{
			ArenaRankingListItemUIController arenaRankingListItemUIController = (ArenaRankingListItemUIController)LuaObject.checkSelf(l);
			int index;
			LuaObject.checkType(l, 2, out index);
			arenaRankingListItemUIController.SetIndex(index);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B007 RID: 110599 RVA: 0x0081AB28 File Offset: 0x00818D28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetPlayer(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				ArenaRankingListItemUIController arenaRankingListItemUIController = (ArenaRankingListItemUIController)LuaObject.checkSelf(l);
				ProArenaTopRankPlayer player;
				LuaObject.checkType<ProArenaTopRankPlayer>(l, 2, out player);
				arenaRankingListItemUIController.SetPlayer(player);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 3)
			{
				ArenaRankingListItemUIController arenaRankingListItemUIController2 = (ArenaRankingListItemUIController)LuaObject.checkSelf(l);
				ProRealTimePVPLeaderboardPlayerInfo player2;
				LuaObject.checkType<ProRealTimePVPLeaderboardPlayerInfo>(l, 2, out player2);
				ProUserSummary userSummary;
				LuaObject.checkType<ProUserSummary>(l, 3, out userSummary);
				arenaRankingListItemUIController2.SetPlayer(player2, userSummary);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function SetPlayer to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B008 RID: 110600 RVA: 0x0081ABEC File Offset: 0x00818DEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			ArenaRankingListItemUIController arenaRankingListItemUIController = (ArenaRankingListItemUIController)LuaObject.checkSelf(l);
			arenaRankingListItemUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B009 RID: 110601 RVA: 0x0081AC40 File Offset: 0x00818E40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			ArenaRankingListItemUIController arenaRankingListItemUIController = (ArenaRankingListItemUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			arenaRankingListItemUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B00A RID: 110602 RVA: 0x0081ACAC File Offset: 0x00818EAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			ArenaRankingListItemUIController arenaRankingListItemUIController = (ArenaRankingListItemUIController)LuaObject.checkSelf(l);
			arenaRankingListItemUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B00B RID: 110603 RVA: 0x0081AD00 File Offset: 0x00818F00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			ArenaRankingListItemUIController arenaRankingListItemUIController = (ArenaRankingListItemUIController)LuaObject.checkSelf(l);
			arenaRankingListItemUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B00C RID: 110604 RVA: 0x0081AD54 File Offset: 0x00818F54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			ArenaRankingListItemUIController arenaRankingListItemUIController = (ArenaRankingListItemUIController)LuaObject.checkSelf(l);
			Type fieldType;
			LuaObject.checkType(l, 2, out fieldType);
			string path;
			LuaObject.checkType(l, 3, out path);
			AutoBindAttribute.InitState initState;
			LuaObject.checkEnum<AutoBindAttribute.InitState>(l, 4, out initState);
			string fieldName;
			LuaObject.checkType(l, 5, out fieldName);
			string ctrlName;
			LuaObject.checkType(l, 6, out ctrlName);
			bool optional;
			LuaObject.checkType(l, 7, out optional);
			UnityEngine.Object o = arenaRankingListItemUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601B00D RID: 110605 RVA: 0x0081ADFC File Offset: 0x00818FFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			ArenaRankingListItemUIController arenaRankingListItemUIController = (ArenaRankingListItemUIController)LuaObject.checkSelf(l);
			arenaRankingListItemUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B00E RID: 110606 RVA: 0x0081AE50 File Offset: 0x00819050
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ArenaRankingListItemUIController arenaRankingListItemUIController = (ArenaRankingListItemUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			arenaRankingListItemUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B00F RID: 110607 RVA: 0x0081AEBC File Offset: 0x008190BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonClickListener(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(string[]), typeof(Action<UIControllerBase>)))
			{
				ArenaRankingListItemUIController arenaRankingListItemUIController = (ArenaRankingListItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				arenaRankingListItemUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				ArenaRankingListItemUIController arenaRankingListItemUIController2 = (ArenaRankingListItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				arenaRankingListItemUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function __callBase_SetButtonClickListener to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B010 RID: 110608 RVA: 0x0081AFCC File Offset: 0x008191CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			ArenaRankingListItemUIController arenaRankingListItemUIController = (ArenaRankingListItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			arenaRankingListItemUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B011 RID: 110609 RVA: 0x0081B038 File Offset: 0x00819238
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			ArenaRankingListItemUIController arenaRankingListItemUIController = (ArenaRankingListItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			arenaRankingListItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B012 RID: 110610 RVA: 0x0081B0A4 File Offset: 0x008192A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			ArenaRankingListItemUIController arenaRankingListItemUIController = (ArenaRankingListItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			arenaRankingListItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B013 RID: 110611 RVA: 0x0081B110 File Offset: 0x00819310
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			ArenaRankingListItemUIController arenaRankingListItemUIController = (ArenaRankingListItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			arenaRankingListItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B014 RID: 110612 RVA: 0x0081B17C File Offset: 0x0081937C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetToggleValueChangedListener(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(string[]), typeof(Action<UIControllerBase, bool>)))
			{
				ArenaRankingListItemUIController arenaRankingListItemUIController = (ArenaRankingListItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				arenaRankingListItemUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				ArenaRankingListItemUIController arenaRankingListItemUIController2 = (ArenaRankingListItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				arenaRankingListItemUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function __callBase_SetToggleValueChangedListener to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B015 RID: 110613 RVA: 0x0081B28C File Offset: 0x0081948C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			ArenaRankingListItemUIController arenaRankingListItemUIController = (ArenaRankingListItemUIController)LuaObject.checkSelf(l);
			string s = arenaRankingListItemUIController.m_luaExportHelper.__callBase_ToString();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, s);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B016 RID: 110614 RVA: 0x0081B2E8 File Offset: 0x008194E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_rankingImage(IntPtr l)
	{
		int result;
		try
		{
			ArenaRankingListItemUIController arenaRankingListItemUIController = (ArenaRankingListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaRankingListItemUIController.m_luaExportHelper.m_rankingImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B017 RID: 110615 RVA: 0x0081B340 File Offset: 0x00819540
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_rankingImage(IntPtr l)
	{
		int result;
		try
		{
			ArenaRankingListItemUIController arenaRankingListItemUIController = (ArenaRankingListItemUIController)LuaObject.checkSelf(l);
			Image rankingImage;
			LuaObject.checkType<Image>(l, 2, out rankingImage);
			arenaRankingListItemUIController.m_luaExportHelper.m_rankingImage = rankingImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B018 RID: 110616 RVA: 0x0081B39C File Offset: 0x0081959C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_rankingText(IntPtr l)
	{
		int result;
		try
		{
			ArenaRankingListItemUIController arenaRankingListItemUIController = (ArenaRankingListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaRankingListItemUIController.m_luaExportHelper.m_rankingText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B019 RID: 110617 RVA: 0x0081B3F4 File Offset: 0x008195F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_rankingText(IntPtr l)
	{
		int result;
		try
		{
			ArenaRankingListItemUIController arenaRankingListItemUIController = (ArenaRankingListItemUIController)LuaObject.checkSelf(l);
			Text rankingText;
			LuaObject.checkType<Text>(l, 2, out rankingText);
			arenaRankingListItemUIController.m_luaExportHelper.m_rankingText = rankingText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B01A RID: 110618 RVA: 0x0081B450 File Offset: 0x00819650
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerNameText(IntPtr l)
	{
		int result;
		try
		{
			ArenaRankingListItemUIController arenaRankingListItemUIController = (ArenaRankingListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaRankingListItemUIController.m_luaExportHelper.m_playerNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B01B RID: 110619 RVA: 0x0081B4A8 File Offset: 0x008196A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerNameText(IntPtr l)
	{
		int result;
		try
		{
			ArenaRankingListItemUIController arenaRankingListItemUIController = (ArenaRankingListItemUIController)LuaObject.checkSelf(l);
			Text playerNameText;
			LuaObject.checkType<Text>(l, 2, out playerNameText);
			arenaRankingListItemUIController.m_luaExportHelper.m_playerNameText = playerNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B01C RID: 110620 RVA: 0x0081B504 File Offset: 0x00819704
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_arenaPointsText(IntPtr l)
	{
		int result;
		try
		{
			ArenaRankingListItemUIController arenaRankingListItemUIController = (ArenaRankingListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaRankingListItemUIController.m_luaExportHelper.m_arenaPointsText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B01D RID: 110621 RVA: 0x0081B55C File Offset: 0x0081975C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_arenaPointsText(IntPtr l)
	{
		int result;
		try
		{
			ArenaRankingListItemUIController arenaRankingListItemUIController = (ArenaRankingListItemUIController)LuaObject.checkSelf(l);
			Text arenaPointsText;
			LuaObject.checkType<Text>(l, 2, out arenaPointsText);
			arenaRankingListItemUIController.m_luaExportHelper.m_arenaPointsText = arenaPointsText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B01E RID: 110622 RVA: 0x0081B5B8 File Offset: 0x008197B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_backgroundGameObject(IntPtr l)
	{
		int result;
		try
		{
			ArenaRankingListItemUIController arenaRankingListItemUIController = (ArenaRankingListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaRankingListItemUIController.m_luaExportHelper.m_backgroundGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B01F RID: 110623 RVA: 0x0081B610 File Offset: 0x00819810
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_backgroundGameObject(IntPtr l)
	{
		int result;
		try
		{
			ArenaRankingListItemUIController arenaRankingListItemUIController = (ArenaRankingListItemUIController)LuaObject.checkSelf(l);
			GameObject backgroundGameObject;
			LuaObject.checkType<GameObject>(l, 2, out backgroundGameObject);
			arenaRankingListItemUIController.m_luaExportHelper.m_backgroundGameObject = backgroundGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B020 RID: 110624 RVA: 0x0081B66C File Offset: 0x0081986C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerIconImage(IntPtr l)
	{
		int result;
		try
		{
			ArenaRankingListItemUIController arenaRankingListItemUIController = (ArenaRankingListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaRankingListItemUIController.m_luaExportHelper.m_playerIconImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B021 RID: 110625 RVA: 0x0081B6C4 File Offset: 0x008198C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerIconImage(IntPtr l)
	{
		int result;
		try
		{
			ArenaRankingListItemUIController arenaRankingListItemUIController = (ArenaRankingListItemUIController)LuaObject.checkSelf(l);
			Image playerIconImage;
			LuaObject.checkType<Image>(l, 2, out playerIconImage);
			arenaRankingListItemUIController.m_luaExportHelper.m_playerIconImage = playerIconImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B022 RID: 110626 RVA: 0x0081B720 File Offset: 0x00819920
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerHeadFrameTransform(IntPtr l)
	{
		int result;
		try
		{
			ArenaRankingListItemUIController arenaRankingListItemUIController = (ArenaRankingListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaRankingListItemUIController.m_luaExportHelper.m_playerHeadFrameTransform);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B023 RID: 110627 RVA: 0x0081B778 File Offset: 0x00819978
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerHeadFrameTransform(IntPtr l)
	{
		int result;
		try
		{
			ArenaRankingListItemUIController arenaRankingListItemUIController = (ArenaRankingListItemUIController)LuaObject.checkSelf(l);
			Transform playerHeadFrameTransform;
			LuaObject.checkType<Transform>(l, 2, out playerHeadFrameTransform);
			arenaRankingListItemUIController.m_luaExportHelper.m_playerHeadFrameTransform = playerHeadFrameTransform;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B024 RID: 110628 RVA: 0x0081B7D4 File Offset: 0x008199D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_arenaLevelIconImage(IntPtr l)
	{
		int result;
		try
		{
			ArenaRankingListItemUIController arenaRankingListItemUIController = (ArenaRankingListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaRankingListItemUIController.m_luaExportHelper.m_arenaLevelIconImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B025 RID: 110629 RVA: 0x0081B82C File Offset: 0x00819A2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_arenaLevelIconImage(IntPtr l)
	{
		int result;
		try
		{
			ArenaRankingListItemUIController arenaRankingListItemUIController = (ArenaRankingListItemUIController)LuaObject.checkSelf(l);
			Image arenaLevelIconImage;
			LuaObject.checkType<Image>(l, 2, out arenaLevelIconImage);
			arenaRankingListItemUIController.m_luaExportHelper.m_arenaLevelIconImage = arenaLevelIconImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B026 RID: 110630 RVA: 0x0081B888 File Offset: 0x00819A88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerLevelText(IntPtr l)
	{
		int result;
		try
		{
			ArenaRankingListItemUIController arenaRankingListItemUIController = (ArenaRankingListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaRankingListItemUIController.m_luaExportHelper.m_playerLevelText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B027 RID: 110631 RVA: 0x0081B8E0 File Offset: 0x00819AE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerLevelText(IntPtr l)
	{
		int result;
		try
		{
			ArenaRankingListItemUIController arenaRankingListItemUIController = (ArenaRankingListItemUIController)LuaObject.checkSelf(l);
			Text playerLevelText;
			LuaObject.checkType<Text>(l, 2, out playerLevelText);
			arenaRankingListItemUIController.m_luaExportHelper.m_playerLevelText = playerLevelText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B028 RID: 110632 RVA: 0x0081B93C File Offset: 0x00819B3C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.ArenaRankingListItemUIController");
		if (Lua_BlackJack_ProjectL_UI_ArenaRankingListItemUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaRankingListItemUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaRankingListItemUIController.SetRanking);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaRankingListItemUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_ArenaRankingListItemUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaRankingListItemUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaRankingListItemUIController.SetIndex);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaRankingListItemUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_ArenaRankingListItemUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaRankingListItemUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaRankingListItemUIController.SetPlayer);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaRankingListItemUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_ArenaRankingListItemUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaRankingListItemUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaRankingListItemUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaRankingListItemUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_ArenaRankingListItemUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaRankingListItemUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaRankingListItemUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaRankingListItemUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_ArenaRankingListItemUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaRankingListItemUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaRankingListItemUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaRankingListItemUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_ArenaRankingListItemUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaRankingListItemUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaRankingListItemUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaRankingListItemUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_ArenaRankingListItemUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaRankingListItemUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaRankingListItemUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaRankingListItemUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_ArenaRankingListItemUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaRankingListItemUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaRankingListItemUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaRankingListItemUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_ArenaRankingListItemUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaRankingListItemUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaRankingListItemUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaRankingListItemUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_ArenaRankingListItemUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaRankingListItemUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaRankingListItemUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaRankingListItemUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_ArenaRankingListItemUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaRankingListItemUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaRankingListItemUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaRankingListItemUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_ArenaRankingListItemUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaRankingListItemUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaRankingListItemUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaRankingListItemUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_ArenaRankingListItemUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaRankingListItemUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaRankingListItemUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaRankingListItemUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_ArenaRankingListItemUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaRankingListItemUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaRankingListItemUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaRankingListItemUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_ArenaRankingListItemUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaRankingListItemUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaRankingListItemUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaRankingListItemUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_ArenaRankingListItemUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaRankingListItemUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaRankingListItemUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaRankingListItemUIController.<>f__mg$cache10);
		string name = "m_rankingImage";
		if (Lua_BlackJack_ProjectL_UI_ArenaRankingListItemUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaRankingListItemUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaRankingListItemUIController.get_m_rankingImage);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_ArenaRankingListItemUIController.<>f__mg$cache11;
		if (Lua_BlackJack_ProjectL_UI_ArenaRankingListItemUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaRankingListItemUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaRankingListItemUIController.set_m_rankingImage);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_ArenaRankingListItemUIController.<>f__mg$cache12, true);
		string name2 = "m_rankingText";
		if (Lua_BlackJack_ProjectL_UI_ArenaRankingListItemUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaRankingListItemUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaRankingListItemUIController.get_m_rankingText);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_ArenaRankingListItemUIController.<>f__mg$cache13;
		if (Lua_BlackJack_ProjectL_UI_ArenaRankingListItemUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaRankingListItemUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaRankingListItemUIController.set_m_rankingText);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_ArenaRankingListItemUIController.<>f__mg$cache14, true);
		string name3 = "m_playerNameText";
		if (Lua_BlackJack_ProjectL_UI_ArenaRankingListItemUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaRankingListItemUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaRankingListItemUIController.get_m_playerNameText);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_ArenaRankingListItemUIController.<>f__mg$cache15;
		if (Lua_BlackJack_ProjectL_UI_ArenaRankingListItemUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaRankingListItemUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaRankingListItemUIController.set_m_playerNameText);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_ArenaRankingListItemUIController.<>f__mg$cache16, true);
		string name4 = "m_arenaPointsText";
		if (Lua_BlackJack_ProjectL_UI_ArenaRankingListItemUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaRankingListItemUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaRankingListItemUIController.get_m_arenaPointsText);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_ArenaRankingListItemUIController.<>f__mg$cache17;
		if (Lua_BlackJack_ProjectL_UI_ArenaRankingListItemUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaRankingListItemUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaRankingListItemUIController.set_m_arenaPointsText);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_ArenaRankingListItemUIController.<>f__mg$cache18, true);
		string name5 = "m_backgroundGameObject";
		if (Lua_BlackJack_ProjectL_UI_ArenaRankingListItemUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaRankingListItemUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaRankingListItemUIController.get_m_backgroundGameObject);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_ArenaRankingListItemUIController.<>f__mg$cache19;
		if (Lua_BlackJack_ProjectL_UI_ArenaRankingListItemUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaRankingListItemUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaRankingListItemUIController.set_m_backgroundGameObject);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_ArenaRankingListItemUIController.<>f__mg$cache1A, true);
		string name6 = "m_playerIconImage";
		if (Lua_BlackJack_ProjectL_UI_ArenaRankingListItemUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaRankingListItemUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaRankingListItemUIController.get_m_playerIconImage);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_ArenaRankingListItemUIController.<>f__mg$cache1B;
		if (Lua_BlackJack_ProjectL_UI_ArenaRankingListItemUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaRankingListItemUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaRankingListItemUIController.set_m_playerIconImage);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_ArenaRankingListItemUIController.<>f__mg$cache1C, true);
		string name7 = "m_playerHeadFrameTransform";
		if (Lua_BlackJack_ProjectL_UI_ArenaRankingListItemUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaRankingListItemUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaRankingListItemUIController.get_m_playerHeadFrameTransform);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_ArenaRankingListItemUIController.<>f__mg$cache1D;
		if (Lua_BlackJack_ProjectL_UI_ArenaRankingListItemUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaRankingListItemUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaRankingListItemUIController.set_m_playerHeadFrameTransform);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_ArenaRankingListItemUIController.<>f__mg$cache1E, true);
		string name8 = "m_arenaLevelIconImage";
		if (Lua_BlackJack_ProjectL_UI_ArenaRankingListItemUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaRankingListItemUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaRankingListItemUIController.get_m_arenaLevelIconImage);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_ArenaRankingListItemUIController.<>f__mg$cache1F;
		if (Lua_BlackJack_ProjectL_UI_ArenaRankingListItemUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaRankingListItemUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaRankingListItemUIController.set_m_arenaLevelIconImage);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_ArenaRankingListItemUIController.<>f__mg$cache20, true);
		string name9 = "m_playerLevelText";
		if (Lua_BlackJack_ProjectL_UI_ArenaRankingListItemUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaRankingListItemUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaRankingListItemUIController.get_m_playerLevelText);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_ArenaRankingListItemUIController.<>f__mg$cache21;
		if (Lua_BlackJack_ProjectL_UI_ArenaRankingListItemUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaRankingListItemUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaRankingListItemUIController.set_m_playerLevelText);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_ArenaRankingListItemUIController.<>f__mg$cache22, true);
		LuaObject.createTypeMetatable(l, null, typeof(ArenaRankingListItemUIController), typeof(UIControllerBase));
	}

	// Token: 0x040112EB RID: 70379
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040112EC RID: 70380
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040112ED RID: 70381
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040112EE RID: 70382
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040112EF RID: 70383
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040112F0 RID: 70384
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040112F1 RID: 70385
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040112F2 RID: 70386
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x040112F3 RID: 70387
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x040112F4 RID: 70388
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x040112F5 RID: 70389
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x040112F6 RID: 70390
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x040112F7 RID: 70391
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x040112F8 RID: 70392
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x040112F9 RID: 70393
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x040112FA RID: 70394
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x040112FB RID: 70395
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x040112FC RID: 70396
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x040112FD RID: 70397
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x040112FE RID: 70398
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x040112FF RID: 70399
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04011300 RID: 70400
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04011301 RID: 70401
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04011302 RID: 70402
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04011303 RID: 70403
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04011304 RID: 70404
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04011305 RID: 70405
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04011306 RID: 70406
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04011307 RID: 70407
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04011308 RID: 70408
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04011309 RID: 70409
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0401130A RID: 70410
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0401130B RID: 70411
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0401130C RID: 70412
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0401130D RID: 70413
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;
}
