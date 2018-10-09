using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x02001398 RID: 5016
[Preserve]
public class Lua_BlackJack_ProjectL_UI_BattleAchievementItemUIController : LuaObject
{
	// Token: 0x0601B6B0 RID: 112304 RVA: 0x0084F928 File Offset: 0x0084DB28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetAchievement(IntPtr l)
	{
		int result;
		try
		{
			BattleAchievementItemUIController battleAchievementItemUIController = (BattleAchievementItemUIController)LuaObject.checkSelf(l);
			ConfigDataBattleAchievementInfo achievement;
			LuaObject.checkType<ConfigDataBattleAchievementInfo>(l, 2, out achievement);
			battleAchievementItemUIController.SetAchievement(achievement);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B6B1 RID: 112305 RVA: 0x0084F980 File Offset: 0x0084DB80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetRewards(IntPtr l)
	{
		int result;
		try
		{
			BattleAchievementItemUIController battleAchievementItemUIController = (BattleAchievementItemUIController)LuaObject.checkSelf(l);
			List<Goods> rewards;
			LuaObject.checkType<List<Goods>>(l, 2, out rewards);
			battleAchievementItemUIController.SetRewards(rewards);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B6B2 RID: 112306 RVA: 0x0084F9D8 File Offset: 0x0084DBD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetComplete(IntPtr l)
	{
		int result;
		try
		{
			BattleAchievementItemUIController battleAchievementItemUIController = (BattleAchievementItemUIController)LuaObject.checkSelf(l);
			bool complete;
			LuaObject.checkType(l, 2, out complete);
			battleAchievementItemUIController.SetComplete(complete);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B6B3 RID: 112307 RVA: 0x0084FA30 File Offset: 0x0084DC30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			BattleAchievementItemUIController battleAchievementItemUIController = (BattleAchievementItemUIController)LuaObject.checkSelf(l);
			battleAchievementItemUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B6B4 RID: 112308 RVA: 0x0084FA84 File Offset: 0x0084DC84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			BattleAchievementItemUIController battleAchievementItemUIController = (BattleAchievementItemUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			battleAchievementItemUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B6B5 RID: 112309 RVA: 0x0084FAF0 File Offset: 0x0084DCF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			BattleAchievementItemUIController battleAchievementItemUIController = (BattleAchievementItemUIController)LuaObject.checkSelf(l);
			battleAchievementItemUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B6B6 RID: 112310 RVA: 0x0084FB44 File Offset: 0x0084DD44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			BattleAchievementItemUIController battleAchievementItemUIController = (BattleAchievementItemUIController)LuaObject.checkSelf(l);
			battleAchievementItemUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B6B7 RID: 112311 RVA: 0x0084FB98 File Offset: 0x0084DD98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			BattleAchievementItemUIController battleAchievementItemUIController = (BattleAchievementItemUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = battleAchievementItemUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601B6B8 RID: 112312 RVA: 0x0084FC40 File Offset: 0x0084DE40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			BattleAchievementItemUIController battleAchievementItemUIController = (BattleAchievementItemUIController)LuaObject.checkSelf(l);
			battleAchievementItemUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B6B9 RID: 112313 RVA: 0x0084FC94 File Offset: 0x0084DE94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			BattleAchievementItemUIController battleAchievementItemUIController = (BattleAchievementItemUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			battleAchievementItemUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B6BA RID: 112314 RVA: 0x0084FD00 File Offset: 0x0084DF00
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
				BattleAchievementItemUIController battleAchievementItemUIController = (BattleAchievementItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				battleAchievementItemUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				BattleAchievementItemUIController battleAchievementItemUIController2 = (BattleAchievementItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				battleAchievementItemUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601B6BB RID: 112315 RVA: 0x0084FE10 File Offset: 0x0084E010
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			BattleAchievementItemUIController battleAchievementItemUIController = (BattleAchievementItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			battleAchievementItemUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B6BC RID: 112316 RVA: 0x0084FE7C File Offset: 0x0084E07C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			BattleAchievementItemUIController battleAchievementItemUIController = (BattleAchievementItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			battleAchievementItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B6BD RID: 112317 RVA: 0x0084FEE8 File Offset: 0x0084E0E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			BattleAchievementItemUIController battleAchievementItemUIController = (BattleAchievementItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			battleAchievementItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B6BE RID: 112318 RVA: 0x0084FF54 File Offset: 0x0084E154
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			BattleAchievementItemUIController battleAchievementItemUIController = (BattleAchievementItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			battleAchievementItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B6BF RID: 112319 RVA: 0x0084FFC0 File Offset: 0x0084E1C0
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
				BattleAchievementItemUIController battleAchievementItemUIController = (BattleAchievementItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				battleAchievementItemUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				BattleAchievementItemUIController battleAchievementItemUIController2 = (BattleAchievementItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				battleAchievementItemUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601B6C0 RID: 112320 RVA: 0x008500D0 File Offset: 0x0084E2D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			BattleAchievementItemUIController battleAchievementItemUIController = (BattleAchievementItemUIController)LuaObject.checkSelf(l);
			string s = battleAchievementItemUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601B6C1 RID: 112321 RVA: 0x0085012C File Offset: 0x0084E32C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_nameText(IntPtr l)
	{
		int result;
		try
		{
			BattleAchievementItemUIController battleAchievementItemUIController = (BattleAchievementItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleAchievementItemUIController.m_luaExportHelper.m_nameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B6C2 RID: 112322 RVA: 0x00850184 File Offset: 0x0084E384
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_nameText(IntPtr l)
	{
		int result;
		try
		{
			BattleAchievementItemUIController battleAchievementItemUIController = (BattleAchievementItemUIController)LuaObject.checkSelf(l);
			Text nameText;
			LuaObject.checkType<Text>(l, 2, out nameText);
			battleAchievementItemUIController.m_luaExportHelper.m_nameText = nameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B6C3 RID: 112323 RVA: 0x008501E0 File Offset: 0x0084E3E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_descText(IntPtr l)
	{
		int result;
		try
		{
			BattleAchievementItemUIController battleAchievementItemUIController = (BattleAchievementItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleAchievementItemUIController.m_luaExportHelper.m_descText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B6C4 RID: 112324 RVA: 0x00850238 File Offset: 0x0084E438
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_descText(IntPtr l)
	{
		int result;
		try
		{
			BattleAchievementItemUIController battleAchievementItemUIController = (BattleAchievementItemUIController)LuaObject.checkSelf(l);
			Text descText;
			LuaObject.checkType<Text>(l, 2, out descText);
			battleAchievementItemUIController.m_luaExportHelper.m_descText = descText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B6C5 RID: 112325 RVA: 0x00850294 File Offset: 0x0084E494
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_rewardGoodsGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleAchievementItemUIController battleAchievementItemUIController = (BattleAchievementItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleAchievementItemUIController.m_luaExportHelper.m_rewardGoodsGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B6C6 RID: 112326 RVA: 0x008502EC File Offset: 0x0084E4EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_rewardGoodsGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleAchievementItemUIController battleAchievementItemUIController = (BattleAchievementItemUIController)LuaObject.checkSelf(l);
			GameObject rewardGoodsGameObject;
			LuaObject.checkType<GameObject>(l, 2, out rewardGoodsGameObject);
			battleAchievementItemUIController.m_luaExportHelper.m_rewardGoodsGameObject = rewardGoodsGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B6C7 RID: 112327 RVA: 0x00850348 File Offset: 0x0084E548
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_completeGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleAchievementItemUIController battleAchievementItemUIController = (BattleAchievementItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleAchievementItemUIController.m_luaExportHelper.m_completeGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B6C8 RID: 112328 RVA: 0x008503A0 File Offset: 0x0084E5A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_completeGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleAchievementItemUIController battleAchievementItemUIController = (BattleAchievementItemUIController)LuaObject.checkSelf(l);
			GameObject completeGameObject;
			LuaObject.checkType<GameObject>(l, 2, out completeGameObject);
			battleAchievementItemUIController.m_luaExportHelper.m_completeGameObject = completeGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B6C9 RID: 112329 RVA: 0x008503FC File Offset: 0x0084E5FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_rewardGoodsUIController(IntPtr l)
	{
		int result;
		try
		{
			BattleAchievementItemUIController battleAchievementItemUIController = (BattleAchievementItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleAchievementItemUIController.m_luaExportHelper.m_rewardGoodsUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B6CA RID: 112330 RVA: 0x00850454 File Offset: 0x0084E654
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_rewardGoodsUIController(IntPtr l)
	{
		int result;
		try
		{
			BattleAchievementItemUIController battleAchievementItemUIController = (BattleAchievementItemUIController)LuaObject.checkSelf(l);
			RewardGoodsUIController rewardGoodsUIController;
			LuaObject.checkType<RewardGoodsUIController>(l, 2, out rewardGoodsUIController);
			battleAchievementItemUIController.m_luaExportHelper.m_rewardGoodsUIController = rewardGoodsUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B6CB RID: 112331 RVA: 0x008504B0 File Offset: 0x0084E6B0
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.BattleAchievementItemUIController");
		if (Lua_BlackJack_ProjectL_UI_BattleAchievementItemUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleAchievementItemUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleAchievementItemUIController.SetAchievement);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleAchievementItemUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_BattleAchievementItemUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleAchievementItemUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleAchievementItemUIController.SetRewards);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleAchievementItemUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_BattleAchievementItemUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleAchievementItemUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleAchievementItemUIController.SetComplete);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleAchievementItemUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_BattleAchievementItemUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleAchievementItemUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleAchievementItemUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleAchievementItemUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_BattleAchievementItemUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleAchievementItemUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleAchievementItemUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleAchievementItemUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_BattleAchievementItemUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleAchievementItemUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleAchievementItemUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleAchievementItemUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_BattleAchievementItemUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleAchievementItemUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleAchievementItemUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleAchievementItemUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_BattleAchievementItemUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleAchievementItemUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleAchievementItemUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleAchievementItemUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_BattleAchievementItemUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleAchievementItemUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleAchievementItemUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleAchievementItemUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_BattleAchievementItemUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleAchievementItemUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleAchievementItemUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleAchievementItemUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_BattleAchievementItemUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleAchievementItemUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleAchievementItemUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleAchievementItemUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_BattleAchievementItemUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleAchievementItemUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleAchievementItemUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleAchievementItemUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_BattleAchievementItemUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleAchievementItemUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleAchievementItemUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleAchievementItemUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_BattleAchievementItemUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleAchievementItemUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleAchievementItemUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleAchievementItemUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_BattleAchievementItemUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleAchievementItemUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleAchievementItemUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleAchievementItemUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_BattleAchievementItemUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleAchievementItemUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleAchievementItemUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleAchievementItemUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_BattleAchievementItemUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleAchievementItemUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleAchievementItemUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleAchievementItemUIController.<>f__mg$cache10);
		string name = "m_nameText";
		if (Lua_BlackJack_ProjectL_UI_BattleAchievementItemUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleAchievementItemUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleAchievementItemUIController.get_m_nameText);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_BattleAchievementItemUIController.<>f__mg$cache11;
		if (Lua_BlackJack_ProjectL_UI_BattleAchievementItemUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleAchievementItemUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleAchievementItemUIController.set_m_nameText);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_BattleAchievementItemUIController.<>f__mg$cache12, true);
		string name2 = "m_descText";
		if (Lua_BlackJack_ProjectL_UI_BattleAchievementItemUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleAchievementItemUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleAchievementItemUIController.get_m_descText);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_BattleAchievementItemUIController.<>f__mg$cache13;
		if (Lua_BlackJack_ProjectL_UI_BattleAchievementItemUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleAchievementItemUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleAchievementItemUIController.set_m_descText);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_BattleAchievementItemUIController.<>f__mg$cache14, true);
		string name3 = "m_rewardGoodsGameObject";
		if (Lua_BlackJack_ProjectL_UI_BattleAchievementItemUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleAchievementItemUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleAchievementItemUIController.get_m_rewardGoodsGameObject);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_BattleAchievementItemUIController.<>f__mg$cache15;
		if (Lua_BlackJack_ProjectL_UI_BattleAchievementItemUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleAchievementItemUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleAchievementItemUIController.set_m_rewardGoodsGameObject);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_BattleAchievementItemUIController.<>f__mg$cache16, true);
		string name4 = "m_completeGameObject";
		if (Lua_BlackJack_ProjectL_UI_BattleAchievementItemUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleAchievementItemUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleAchievementItemUIController.get_m_completeGameObject);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_BattleAchievementItemUIController.<>f__mg$cache17;
		if (Lua_BlackJack_ProjectL_UI_BattleAchievementItemUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleAchievementItemUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleAchievementItemUIController.set_m_completeGameObject);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_BattleAchievementItemUIController.<>f__mg$cache18, true);
		string name5 = "m_rewardGoodsUIController";
		if (Lua_BlackJack_ProjectL_UI_BattleAchievementItemUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleAchievementItemUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleAchievementItemUIController.get_m_rewardGoodsUIController);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_BattleAchievementItemUIController.<>f__mg$cache19;
		if (Lua_BlackJack_ProjectL_UI_BattleAchievementItemUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleAchievementItemUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleAchievementItemUIController.set_m_rewardGoodsUIController);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_BattleAchievementItemUIController.<>f__mg$cache1A, true);
		LuaObject.createTypeMetatable(l, null, typeof(BattleAchievementItemUIController), typeof(UIControllerBase));
	}

	// Token: 0x04011962 RID: 72034
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04011963 RID: 72035
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04011964 RID: 72036
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04011965 RID: 72037
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04011966 RID: 72038
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04011967 RID: 72039
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04011968 RID: 72040
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04011969 RID: 72041
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0401196A RID: 72042
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0401196B RID: 72043
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0401196C RID: 72044
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0401196D RID: 72045
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0401196E RID: 72046
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0401196F RID: 72047
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04011970 RID: 72048
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04011971 RID: 72049
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04011972 RID: 72050
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04011973 RID: 72051
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04011974 RID: 72052
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04011975 RID: 72053
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04011976 RID: 72054
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04011977 RID: 72055
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04011978 RID: 72056
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04011979 RID: 72057
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0401197A RID: 72058
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0401197B RID: 72059
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0401197C RID: 72060
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;
}
