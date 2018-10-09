using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x0200137F RID: 4991
[Preserve]
public class Lua_BlackJack_ProjectL_UI_ArenaRankingRewardListItemUIController : LuaObject
{
	// Token: 0x0601B02A RID: 110634 RVA: 0x0081BE40 File Offset: 0x0081A040
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetArenaRankRewardInfo(IntPtr l)
	{
		int result;
		try
		{
			ArenaRankingRewardListItemUIController arenaRankingRewardListItemUIController = (ArenaRankingRewardListItemUIController)LuaObject.checkSelf(l);
			ConfigDataArenaRankRewardInfo rankRewardInfo;
			LuaObject.checkType<ConfigDataArenaRankRewardInfo>(l, 2, out rankRewardInfo);
			GameObject rewardGoodPrefab;
			LuaObject.checkType<GameObject>(l, 3, out rewardGoodPrefab);
			arenaRankingRewardListItemUIController.SetArenaRankRewardInfo(rankRewardInfo, rewardGoodPrefab);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B02B RID: 110635 RVA: 0x0081BEA4 File Offset: 0x0081A0A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetRealTimePVPRankBonusInfo(IntPtr l)
	{
		int result;
		try
		{
			ArenaRankingRewardListItemUIController arenaRankingRewardListItemUIController = (ArenaRankingRewardListItemUIController)LuaObject.checkSelf(l);
			ConfigDataRealTimePVPRankingRewardInfo rankRewardInfo;
			LuaObject.checkType<ConfigDataRealTimePVPRankingRewardInfo>(l, 2, out rankRewardInfo);
			GameObject rewardGoodPrefab;
			LuaObject.checkType<GameObject>(l, 3, out rewardGoodPrefab);
			arenaRankingRewardListItemUIController.SetRealTimePVPRankBonusInfo(rankRewardInfo, rewardGoodPrefab);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B02C RID: 110636 RVA: 0x0081BF08 File Offset: 0x0081A108
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetIndex(IntPtr l)
	{
		int result;
		try
		{
			ArenaRankingRewardListItemUIController arenaRankingRewardListItemUIController = (ArenaRankingRewardListItemUIController)LuaObject.checkSelf(l);
			int index;
			LuaObject.checkType(l, 2, out index);
			arenaRankingRewardListItemUIController.SetIndex(index);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B02D RID: 110637 RVA: 0x0081BF60 File Offset: 0x0081A160
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			ArenaRankingRewardListItemUIController arenaRankingRewardListItemUIController = (ArenaRankingRewardListItemUIController)LuaObject.checkSelf(l);
			arenaRankingRewardListItemUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B02E RID: 110638 RVA: 0x0081BFB4 File Offset: 0x0081A1B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			ArenaRankingRewardListItemUIController arenaRankingRewardListItemUIController = (ArenaRankingRewardListItemUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			arenaRankingRewardListItemUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B02F RID: 110639 RVA: 0x0081C020 File Offset: 0x0081A220
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			ArenaRankingRewardListItemUIController arenaRankingRewardListItemUIController = (ArenaRankingRewardListItemUIController)LuaObject.checkSelf(l);
			arenaRankingRewardListItemUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B030 RID: 110640 RVA: 0x0081C074 File Offset: 0x0081A274
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			ArenaRankingRewardListItemUIController arenaRankingRewardListItemUIController = (ArenaRankingRewardListItemUIController)LuaObject.checkSelf(l);
			arenaRankingRewardListItemUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B031 RID: 110641 RVA: 0x0081C0C8 File Offset: 0x0081A2C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			ArenaRankingRewardListItemUIController arenaRankingRewardListItemUIController = (ArenaRankingRewardListItemUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = arenaRankingRewardListItemUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601B032 RID: 110642 RVA: 0x0081C170 File Offset: 0x0081A370
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			ArenaRankingRewardListItemUIController arenaRankingRewardListItemUIController = (ArenaRankingRewardListItemUIController)LuaObject.checkSelf(l);
			arenaRankingRewardListItemUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B033 RID: 110643 RVA: 0x0081C1C4 File Offset: 0x0081A3C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ArenaRankingRewardListItemUIController arenaRankingRewardListItemUIController = (ArenaRankingRewardListItemUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			arenaRankingRewardListItemUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B034 RID: 110644 RVA: 0x0081C230 File Offset: 0x0081A430
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
				ArenaRankingRewardListItemUIController arenaRankingRewardListItemUIController = (ArenaRankingRewardListItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				arenaRankingRewardListItemUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				ArenaRankingRewardListItemUIController arenaRankingRewardListItemUIController2 = (ArenaRankingRewardListItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				arenaRankingRewardListItemUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601B035 RID: 110645 RVA: 0x0081C340 File Offset: 0x0081A540
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			ArenaRankingRewardListItemUIController arenaRankingRewardListItemUIController = (ArenaRankingRewardListItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			arenaRankingRewardListItemUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B036 RID: 110646 RVA: 0x0081C3AC File Offset: 0x0081A5AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			ArenaRankingRewardListItemUIController arenaRankingRewardListItemUIController = (ArenaRankingRewardListItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			arenaRankingRewardListItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B037 RID: 110647 RVA: 0x0081C418 File Offset: 0x0081A618
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			ArenaRankingRewardListItemUIController arenaRankingRewardListItemUIController = (ArenaRankingRewardListItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			arenaRankingRewardListItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B038 RID: 110648 RVA: 0x0081C484 File Offset: 0x0081A684
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			ArenaRankingRewardListItemUIController arenaRankingRewardListItemUIController = (ArenaRankingRewardListItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			arenaRankingRewardListItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B039 RID: 110649 RVA: 0x0081C4F0 File Offset: 0x0081A6F0
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
				ArenaRankingRewardListItemUIController arenaRankingRewardListItemUIController = (ArenaRankingRewardListItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				arenaRankingRewardListItemUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				ArenaRankingRewardListItemUIController arenaRankingRewardListItemUIController2 = (ArenaRankingRewardListItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				arenaRankingRewardListItemUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601B03A RID: 110650 RVA: 0x0081C600 File Offset: 0x0081A800
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			ArenaRankingRewardListItemUIController arenaRankingRewardListItemUIController = (ArenaRankingRewardListItemUIController)LuaObject.checkSelf(l);
			string s = arenaRankingRewardListItemUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601B03B RID: 110651 RVA: 0x0081C65C File Offset: 0x0081A85C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_nameText(IntPtr l)
	{
		int result;
		try
		{
			ArenaRankingRewardListItemUIController arenaRankingRewardListItemUIController = (ArenaRankingRewardListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaRankingRewardListItemUIController.m_luaExportHelper.m_nameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B03C RID: 110652 RVA: 0x0081C6B4 File Offset: 0x0081A8B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_nameText(IntPtr l)
	{
		int result;
		try
		{
			ArenaRankingRewardListItemUIController arenaRankingRewardListItemUIController = (ArenaRankingRewardListItemUIController)LuaObject.checkSelf(l);
			Text nameText;
			LuaObject.checkType<Text>(l, 2, out nameText);
			arenaRankingRewardListItemUIController.m_luaExportHelper.m_nameText = nameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B03D RID: 110653 RVA: 0x0081C710 File Offset: 0x0081A910
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_rewardGroupGameObject(IntPtr l)
	{
		int result;
		try
		{
			ArenaRankingRewardListItemUIController arenaRankingRewardListItemUIController = (ArenaRankingRewardListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaRankingRewardListItemUIController.m_luaExportHelper.m_rewardGroupGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B03E RID: 110654 RVA: 0x0081C768 File Offset: 0x0081A968
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_rewardGroupGameObject(IntPtr l)
	{
		int result;
		try
		{
			ArenaRankingRewardListItemUIController arenaRankingRewardListItemUIController = (ArenaRankingRewardListItemUIController)LuaObject.checkSelf(l);
			GameObject rewardGroupGameObject;
			LuaObject.checkType<GameObject>(l, 2, out rewardGroupGameObject);
			arenaRankingRewardListItemUIController.m_luaExportHelper.m_rewardGroupGameObject = rewardGroupGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B03F RID: 110655 RVA: 0x0081C7C4 File Offset: 0x0081A9C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_backgroundGameObject(IntPtr l)
	{
		int result;
		try
		{
			ArenaRankingRewardListItemUIController arenaRankingRewardListItemUIController = (ArenaRankingRewardListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaRankingRewardListItemUIController.m_luaExportHelper.m_backgroundGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B040 RID: 110656 RVA: 0x0081C81C File Offset: 0x0081AA1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_backgroundGameObject(IntPtr l)
	{
		int result;
		try
		{
			ArenaRankingRewardListItemUIController arenaRankingRewardListItemUIController = (ArenaRankingRewardListItemUIController)LuaObject.checkSelf(l);
			GameObject backgroundGameObject;
			LuaObject.checkType<GameObject>(l, 2, out backgroundGameObject);
			arenaRankingRewardListItemUIController.m_luaExportHelper.m_backgroundGameObject = backgroundGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B041 RID: 110657 RVA: 0x0081C878 File Offset: 0x0081AA78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_noRewardGameObject(IntPtr l)
	{
		int result;
		try
		{
			ArenaRankingRewardListItemUIController arenaRankingRewardListItemUIController = (ArenaRankingRewardListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaRankingRewardListItemUIController.m_luaExportHelper.m_noRewardGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B042 RID: 110658 RVA: 0x0081C8D0 File Offset: 0x0081AAD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_noRewardGameObject(IntPtr l)
	{
		int result;
		try
		{
			ArenaRankingRewardListItemUIController arenaRankingRewardListItemUIController = (ArenaRankingRewardListItemUIController)LuaObject.checkSelf(l);
			GameObject noRewardGameObject;
			LuaObject.checkType<GameObject>(l, 2, out noRewardGameObject);
			arenaRankingRewardListItemUIController.m_luaExportHelper.m_noRewardGameObject = noRewardGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B043 RID: 110659 RVA: 0x0081C92C File Offset: 0x0081AB2C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.ArenaRankingRewardListItemUIController");
		if (Lua_BlackJack_ProjectL_UI_ArenaRankingRewardListItemUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaRankingRewardListItemUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaRankingRewardListItemUIController.SetArenaRankRewardInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaRankingRewardListItemUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_ArenaRankingRewardListItemUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaRankingRewardListItemUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaRankingRewardListItemUIController.SetRealTimePVPRankBonusInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaRankingRewardListItemUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_ArenaRankingRewardListItemUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaRankingRewardListItemUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaRankingRewardListItemUIController.SetIndex);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaRankingRewardListItemUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_ArenaRankingRewardListItemUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaRankingRewardListItemUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaRankingRewardListItemUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaRankingRewardListItemUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_ArenaRankingRewardListItemUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaRankingRewardListItemUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaRankingRewardListItemUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaRankingRewardListItemUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_ArenaRankingRewardListItemUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaRankingRewardListItemUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaRankingRewardListItemUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaRankingRewardListItemUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_ArenaRankingRewardListItemUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaRankingRewardListItemUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaRankingRewardListItemUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaRankingRewardListItemUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_ArenaRankingRewardListItemUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaRankingRewardListItemUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaRankingRewardListItemUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaRankingRewardListItemUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_ArenaRankingRewardListItemUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaRankingRewardListItemUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaRankingRewardListItemUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaRankingRewardListItemUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_ArenaRankingRewardListItemUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaRankingRewardListItemUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaRankingRewardListItemUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaRankingRewardListItemUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_ArenaRankingRewardListItemUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaRankingRewardListItemUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaRankingRewardListItemUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaRankingRewardListItemUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_ArenaRankingRewardListItemUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaRankingRewardListItemUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaRankingRewardListItemUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaRankingRewardListItemUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_ArenaRankingRewardListItemUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaRankingRewardListItemUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaRankingRewardListItemUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaRankingRewardListItemUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_ArenaRankingRewardListItemUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaRankingRewardListItemUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaRankingRewardListItemUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaRankingRewardListItemUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_ArenaRankingRewardListItemUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaRankingRewardListItemUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaRankingRewardListItemUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaRankingRewardListItemUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_ArenaRankingRewardListItemUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaRankingRewardListItemUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaRankingRewardListItemUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaRankingRewardListItemUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_ArenaRankingRewardListItemUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaRankingRewardListItemUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaRankingRewardListItemUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaRankingRewardListItemUIController.<>f__mg$cache10);
		string name = "m_nameText";
		if (Lua_BlackJack_ProjectL_UI_ArenaRankingRewardListItemUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaRankingRewardListItemUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaRankingRewardListItemUIController.get_m_nameText);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_ArenaRankingRewardListItemUIController.<>f__mg$cache11;
		if (Lua_BlackJack_ProjectL_UI_ArenaRankingRewardListItemUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaRankingRewardListItemUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaRankingRewardListItemUIController.set_m_nameText);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_ArenaRankingRewardListItemUIController.<>f__mg$cache12, true);
		string name2 = "m_rewardGroupGameObject";
		if (Lua_BlackJack_ProjectL_UI_ArenaRankingRewardListItemUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaRankingRewardListItemUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaRankingRewardListItemUIController.get_m_rewardGroupGameObject);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_ArenaRankingRewardListItemUIController.<>f__mg$cache13;
		if (Lua_BlackJack_ProjectL_UI_ArenaRankingRewardListItemUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaRankingRewardListItemUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaRankingRewardListItemUIController.set_m_rewardGroupGameObject);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_ArenaRankingRewardListItemUIController.<>f__mg$cache14, true);
		string name3 = "m_backgroundGameObject";
		if (Lua_BlackJack_ProjectL_UI_ArenaRankingRewardListItemUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaRankingRewardListItemUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaRankingRewardListItemUIController.get_m_backgroundGameObject);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_ArenaRankingRewardListItemUIController.<>f__mg$cache15;
		if (Lua_BlackJack_ProjectL_UI_ArenaRankingRewardListItemUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaRankingRewardListItemUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaRankingRewardListItemUIController.set_m_backgroundGameObject);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_ArenaRankingRewardListItemUIController.<>f__mg$cache16, true);
		string name4 = "m_noRewardGameObject";
		if (Lua_BlackJack_ProjectL_UI_ArenaRankingRewardListItemUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaRankingRewardListItemUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaRankingRewardListItemUIController.get_m_noRewardGameObject);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_ArenaRankingRewardListItemUIController.<>f__mg$cache17;
		if (Lua_BlackJack_ProjectL_UI_ArenaRankingRewardListItemUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaRankingRewardListItemUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaRankingRewardListItemUIController.set_m_noRewardGameObject);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_ArenaRankingRewardListItemUIController.<>f__mg$cache18, true);
		LuaObject.createTypeMetatable(l, null, typeof(ArenaRankingRewardListItemUIController), typeof(UIControllerBase));
	}

	// Token: 0x0401130E RID: 70414
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0401130F RID: 70415
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04011310 RID: 70416
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04011311 RID: 70417
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04011312 RID: 70418
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04011313 RID: 70419
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04011314 RID: 70420
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04011315 RID: 70421
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04011316 RID: 70422
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04011317 RID: 70423
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04011318 RID: 70424
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04011319 RID: 70425
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0401131A RID: 70426
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0401131B RID: 70427
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0401131C RID: 70428
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0401131D RID: 70429
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0401131E RID: 70430
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0401131F RID: 70431
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04011320 RID: 70432
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04011321 RID: 70433
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04011322 RID: 70434
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04011323 RID: 70435
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04011324 RID: 70436
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04011325 RID: 70437
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04011326 RID: 70438
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;
}
