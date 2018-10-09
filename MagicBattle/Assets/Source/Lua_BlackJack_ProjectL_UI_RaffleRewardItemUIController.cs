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

// Token: 0x02001541 RID: 5441
[Preserve]
public class Lua_BlackJack_ProjectL_UI_RaffleRewardItemUIController : LuaObject
{
	// Token: 0x060207CD RID: 133069 RVA: 0x00AD4DEC File Offset: 0x00AD2FEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateRaffleRewardItemInfo(IntPtr l)
	{
		int result;
		try
		{
			RaffleRewardItemUIController raffleRewardItemUIController = (RaffleRewardItemUIController)LuaObject.checkSelf(l);
			int level;
			LuaObject.checkType(l, 2, out level);
			List<RaffleItem> itemList;
			LuaObject.checkType<List<RaffleItem>>(l, 3, out itemList);
			HashSet<int> drawedRaffleIds;
			LuaObject.checkType<HashSet<int>>(l, 4, out drawedRaffleIds);
			raffleRewardItemUIController.UpdateRaffleRewardItemInfo(level, itemList, drawedRaffleIds);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060207CE RID: 133070 RVA: 0x00AD4E60 File Offset: 0x00AD3060
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateRewardItemGotState(IntPtr l)
	{
		int result;
		try
		{
			RaffleRewardItemUIController raffleRewardItemUIController = (RaffleRewardItemUIController)LuaObject.checkSelf(l);
			List<RaffleItem> itemList;
			LuaObject.checkType<List<RaffleItem>>(l, 2, out itemList);
			HashSet<int> drawedRaffleIds;
			LuaObject.checkType<HashSet<int>>(l, 3, out drawedRaffleIds);
			raffleRewardItemUIController.UpdateRewardItemGotState(itemList, drawedRaffleIds);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060207CF RID: 133071 RVA: 0x00AD4EC4 File Offset: 0x00AD30C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetLvNameByLevel(IntPtr l)
	{
		int result;
		try
		{
			RaffleRewardItemUIController raffleRewardItemUIController = (RaffleRewardItemUIController)LuaObject.checkSelf(l);
			int level;
			LuaObject.checkType(l, 2, out level);
			string lvNameByLevel = raffleRewardItemUIController.GetLvNameByLevel(level);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, lvNameByLevel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060207D0 RID: 133072 RVA: 0x00AD4F28 File Offset: 0x00AD3128
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetLevelStrByLevel(IntPtr l)
	{
		int result;
		try
		{
			RaffleRewardItemUIController raffleRewardItemUIController = (RaffleRewardItemUIController)LuaObject.checkSelf(l);
			int level;
			LuaObject.checkType(l, 2, out level);
			StringTableId levelStrByLevel = raffleRewardItemUIController.m_luaExportHelper.GetLevelStrByLevel(level);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)levelStrByLevel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060207D1 RID: 133073 RVA: 0x00AD4F90 File Offset: 0x00AD3190
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetLvStateNameByLevel(IntPtr l)
	{
		int result;
		try
		{
			RaffleRewardItemUIController raffleRewardItemUIController = (RaffleRewardItemUIController)LuaObject.checkSelf(l);
			int level;
			LuaObject.checkType(l, 2, out level);
			string lvStateNameByLevel = raffleRewardItemUIController.m_luaExportHelper.GetLvStateNameByLevel(level);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, lvStateNameByLevel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060207D2 RID: 133074 RVA: 0x00AD4FF8 File Offset: 0x00AD31F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			RaffleRewardItemUIController raffleRewardItemUIController = (RaffleRewardItemUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			raffleRewardItemUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060207D3 RID: 133075 RVA: 0x00AD5064 File Offset: 0x00AD3264
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			RaffleRewardItemUIController raffleRewardItemUIController = (RaffleRewardItemUIController)LuaObject.checkSelf(l);
			raffleRewardItemUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060207D4 RID: 133076 RVA: 0x00AD50B8 File Offset: 0x00AD32B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			RaffleRewardItemUIController raffleRewardItemUIController = (RaffleRewardItemUIController)LuaObject.checkSelf(l);
			raffleRewardItemUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060207D5 RID: 133077 RVA: 0x00AD510C File Offset: 0x00AD330C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			RaffleRewardItemUIController raffleRewardItemUIController = (RaffleRewardItemUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = raffleRewardItemUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x060207D6 RID: 133078 RVA: 0x00AD51B4 File Offset: 0x00AD33B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			RaffleRewardItemUIController raffleRewardItemUIController = (RaffleRewardItemUIController)LuaObject.checkSelf(l);
			raffleRewardItemUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060207D7 RID: 133079 RVA: 0x00AD5208 File Offset: 0x00AD3408
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			RaffleRewardItemUIController raffleRewardItemUIController = (RaffleRewardItemUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			raffleRewardItemUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060207D8 RID: 133080 RVA: 0x00AD5274 File Offset: 0x00AD3474
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
				RaffleRewardItemUIController raffleRewardItemUIController = (RaffleRewardItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				raffleRewardItemUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				RaffleRewardItemUIController raffleRewardItemUIController2 = (RaffleRewardItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				raffleRewardItemUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x060207D9 RID: 133081 RVA: 0x00AD5384 File Offset: 0x00AD3584
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			RaffleRewardItemUIController raffleRewardItemUIController = (RaffleRewardItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			raffleRewardItemUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060207DA RID: 133082 RVA: 0x00AD53F0 File Offset: 0x00AD35F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			RaffleRewardItemUIController raffleRewardItemUIController = (RaffleRewardItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			raffleRewardItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060207DB RID: 133083 RVA: 0x00AD545C File Offset: 0x00AD365C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			RaffleRewardItemUIController raffleRewardItemUIController = (RaffleRewardItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			raffleRewardItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060207DC RID: 133084 RVA: 0x00AD54C8 File Offset: 0x00AD36C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			RaffleRewardItemUIController raffleRewardItemUIController = (RaffleRewardItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			raffleRewardItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060207DD RID: 133085 RVA: 0x00AD5534 File Offset: 0x00AD3734
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
				RaffleRewardItemUIController raffleRewardItemUIController = (RaffleRewardItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				raffleRewardItemUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				RaffleRewardItemUIController raffleRewardItemUIController2 = (RaffleRewardItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				raffleRewardItemUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x060207DE RID: 133086 RVA: 0x00AD5644 File Offset: 0x00AD3844
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			RaffleRewardItemUIController raffleRewardItemUIController = (RaffleRewardItemUIController)LuaObject.checkSelf(l);
			string s = raffleRewardItemUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x060207DF RID: 133087 RVA: 0x00AD56A0 File Offset: 0x00AD38A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_goodsCtrlList(IntPtr l)
	{
		int result;
		try
		{
			RaffleRewardItemUIController raffleRewardItemUIController = (RaffleRewardItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, raffleRewardItemUIController.m_luaExportHelper.m_goodsCtrlList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060207E0 RID: 133088 RVA: 0x00AD56F8 File Offset: 0x00AD38F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_goodsCtrlList(IntPtr l)
	{
		int result;
		try
		{
			RaffleRewardItemUIController raffleRewardItemUIController = (RaffleRewardItemUIController)LuaObject.checkSelf(l);
			List<RewardGoodsUIController> goodsCtrlList;
			LuaObject.checkType<List<RewardGoodsUIController>>(l, 2, out goodsCtrlList);
			raffleRewardItemUIController.m_luaExportHelper.m_goodsCtrlList = goodsCtrlList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060207E1 RID: 133089 RVA: 0x00AD5754 File Offset: 0x00AD3954
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_UIStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			RaffleRewardItemUIController raffleRewardItemUIController = (RaffleRewardItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, raffleRewardItemUIController.UIStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060207E2 RID: 133090 RVA: 0x00AD57A8 File Offset: 0x00AD39A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_UIStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			RaffleRewardItemUIController raffleRewardItemUIController = (RaffleRewardItemUIController)LuaObject.checkSelf(l);
			CommonUIStateController uistateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out uistateCtrl);
			raffleRewardItemUIController.UIStateCtrl = uistateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060207E3 RID: 133091 RVA: 0x00AD5800 File Offset: 0x00AD3A00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LevelText(IntPtr l)
	{
		int result;
		try
		{
			RaffleRewardItemUIController raffleRewardItemUIController = (RaffleRewardItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, raffleRewardItemUIController.LevelText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060207E4 RID: 133092 RVA: 0x00AD5854 File Offset: 0x00AD3A54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_LevelText(IntPtr l)
	{
		int result;
		try
		{
			RaffleRewardItemUIController raffleRewardItemUIController = (RaffleRewardItemUIController)LuaObject.checkSelf(l);
			Text levelText;
			LuaObject.checkType<Text>(l, 2, out levelText);
			raffleRewardItemUIController.LevelText = levelText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060207E5 RID: 133093 RVA: 0x00AD58AC File Offset: 0x00AD3AAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_GoodsItemRoot(IntPtr l)
	{
		int result;
		try
		{
			RaffleRewardItemUIController raffleRewardItemUIController = (RaffleRewardItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, raffleRewardItemUIController.GoodsItemRoot);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060207E6 RID: 133094 RVA: 0x00AD5900 File Offset: 0x00AD3B00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_GoodsItemRoot(IntPtr l)
	{
		int result;
		try
		{
			RaffleRewardItemUIController raffleRewardItemUIController = (RaffleRewardItemUIController)LuaObject.checkSelf(l);
			Transform goodsItemRoot;
			LuaObject.checkType<Transform>(l, 2, out goodsItemRoot);
			raffleRewardItemUIController.GoodsItemRoot = goodsItemRoot;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060207E7 RID: 133095 RVA: 0x00AD5958 File Offset: 0x00AD3B58
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.RaffleRewardItemUIController");
		if (Lua_BlackJack_ProjectL_UI_RaffleRewardItemUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleRewardItemUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleRewardItemUIController.UpdateRaffleRewardItemInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaffleRewardItemUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_RaffleRewardItemUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleRewardItemUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleRewardItemUIController.UpdateRewardItemGotState);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaffleRewardItemUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_RaffleRewardItemUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleRewardItemUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleRewardItemUIController.GetLvNameByLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaffleRewardItemUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_RaffleRewardItemUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleRewardItemUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleRewardItemUIController.GetLevelStrByLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaffleRewardItemUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_RaffleRewardItemUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleRewardItemUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleRewardItemUIController.GetLvStateNameByLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaffleRewardItemUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_RaffleRewardItemUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleRewardItemUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleRewardItemUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaffleRewardItemUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_RaffleRewardItemUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleRewardItemUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleRewardItemUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaffleRewardItemUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_RaffleRewardItemUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleRewardItemUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleRewardItemUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaffleRewardItemUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_RaffleRewardItemUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleRewardItemUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleRewardItemUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaffleRewardItemUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_RaffleRewardItemUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleRewardItemUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleRewardItemUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaffleRewardItemUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_RaffleRewardItemUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleRewardItemUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleRewardItemUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaffleRewardItemUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_RaffleRewardItemUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleRewardItemUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleRewardItemUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaffleRewardItemUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_RaffleRewardItemUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleRewardItemUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleRewardItemUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaffleRewardItemUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_RaffleRewardItemUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleRewardItemUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleRewardItemUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaffleRewardItemUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_RaffleRewardItemUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleRewardItemUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleRewardItemUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaffleRewardItemUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_RaffleRewardItemUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleRewardItemUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleRewardItemUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaffleRewardItemUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_RaffleRewardItemUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleRewardItemUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleRewardItemUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaffleRewardItemUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_RaffleRewardItemUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleRewardItemUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleRewardItemUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RaffleRewardItemUIController.<>f__mg$cache11);
		string name = "m_goodsCtrlList";
		if (Lua_BlackJack_ProjectL_UI_RaffleRewardItemUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleRewardItemUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleRewardItemUIController.get_m_goodsCtrlList);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_RaffleRewardItemUIController.<>f__mg$cache12;
		if (Lua_BlackJack_ProjectL_UI_RaffleRewardItemUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleRewardItemUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleRewardItemUIController.set_m_goodsCtrlList);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_RaffleRewardItemUIController.<>f__mg$cache13, true);
		string name2 = "UIStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_RaffleRewardItemUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleRewardItemUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleRewardItemUIController.get_UIStateCtrl);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_RaffleRewardItemUIController.<>f__mg$cache14;
		if (Lua_BlackJack_ProjectL_UI_RaffleRewardItemUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleRewardItemUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleRewardItemUIController.set_UIStateCtrl);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_RaffleRewardItemUIController.<>f__mg$cache15, true);
		string name3 = "LevelText";
		if (Lua_BlackJack_ProjectL_UI_RaffleRewardItemUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleRewardItemUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleRewardItemUIController.get_LevelText);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_RaffleRewardItemUIController.<>f__mg$cache16;
		if (Lua_BlackJack_ProjectL_UI_RaffleRewardItemUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleRewardItemUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleRewardItemUIController.set_LevelText);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_RaffleRewardItemUIController.<>f__mg$cache17, true);
		string name4 = "GoodsItemRoot";
		if (Lua_BlackJack_ProjectL_UI_RaffleRewardItemUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleRewardItemUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleRewardItemUIController.get_GoodsItemRoot);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_RaffleRewardItemUIController.<>f__mg$cache18;
		if (Lua_BlackJack_ProjectL_UI_RaffleRewardItemUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleRewardItemUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleRewardItemUIController.set_GoodsItemRoot);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_RaffleRewardItemUIController.<>f__mg$cache19, true);
		LuaObject.createTypeMetatable(l, null, typeof(RaffleRewardItemUIController), typeof(UIControllerBase));
	}

	// Token: 0x0401672D RID: 91949
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0401672E RID: 91950
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0401672F RID: 91951
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04016730 RID: 91952
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04016731 RID: 91953
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04016732 RID: 91954
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04016733 RID: 91955
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04016734 RID: 91956
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04016735 RID: 91957
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04016736 RID: 91958
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04016737 RID: 91959
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04016738 RID: 91960
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04016739 RID: 91961
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0401673A RID: 91962
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0401673B RID: 91963
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0401673C RID: 91964
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0401673D RID: 91965
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0401673E RID: 91966
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0401673F RID: 91967
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04016740 RID: 91968
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04016741 RID: 91969
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04016742 RID: 91970
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04016743 RID: 91971
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04016744 RID: 91972
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04016745 RID: 91973
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04016746 RID: 91974
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;
}
