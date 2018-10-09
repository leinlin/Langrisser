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

// Token: 0x020013FC RID: 5116
[Preserve]
public class Lua_BlackJack_ProjectL_UI_ClimbTowerRewardListItemUIController : LuaObject
{
	// Token: 0x0601CC23 RID: 117795 RVA: 0x008F9EFC File Offset: 0x008F80FC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetReward(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerRewardListItemUIController climbTowerRewardListItemUIController = (ClimbTowerRewardListItemUIController)LuaObject.checkSelf(l);
			List<Goods> rewardList;
			LuaObject.checkType<List<Goods>>(l, 2, out rewardList);
			string name;
			LuaObject.checkType(l, 3, out name);
			climbTowerRewardListItemUIController.SetReward(rewardList, name);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CC24 RID: 117796 RVA: 0x008F9F60 File Offset: 0x008F8160
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerRewardListItemUIController climbTowerRewardListItemUIController = (ClimbTowerRewardListItemUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			climbTowerRewardListItemUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CC25 RID: 117797 RVA: 0x008F9FCC File Offset: 0x008F81CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerRewardListItemUIController climbTowerRewardListItemUIController = (ClimbTowerRewardListItemUIController)LuaObject.checkSelf(l);
			climbTowerRewardListItemUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CC26 RID: 117798 RVA: 0x008FA020 File Offset: 0x008F8220
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerRewardListItemUIController climbTowerRewardListItemUIController = (ClimbTowerRewardListItemUIController)LuaObject.checkSelf(l);
			climbTowerRewardListItemUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CC27 RID: 117799 RVA: 0x008FA074 File Offset: 0x008F8274
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerRewardListItemUIController climbTowerRewardListItemUIController = (ClimbTowerRewardListItemUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = climbTowerRewardListItemUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601CC28 RID: 117800 RVA: 0x008FA11C File Offset: 0x008F831C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerRewardListItemUIController climbTowerRewardListItemUIController = (ClimbTowerRewardListItemUIController)LuaObject.checkSelf(l);
			climbTowerRewardListItemUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CC29 RID: 117801 RVA: 0x008FA170 File Offset: 0x008F8370
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerRewardListItemUIController climbTowerRewardListItemUIController = (ClimbTowerRewardListItemUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			climbTowerRewardListItemUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CC2A RID: 117802 RVA: 0x008FA1DC File Offset: 0x008F83DC
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
				ClimbTowerRewardListItemUIController climbTowerRewardListItemUIController = (ClimbTowerRewardListItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				climbTowerRewardListItemUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				ClimbTowerRewardListItemUIController climbTowerRewardListItemUIController2 = (ClimbTowerRewardListItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				climbTowerRewardListItemUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601CC2B RID: 117803 RVA: 0x008FA2EC File Offset: 0x008F84EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerRewardListItemUIController climbTowerRewardListItemUIController = (ClimbTowerRewardListItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			climbTowerRewardListItemUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CC2C RID: 117804 RVA: 0x008FA358 File Offset: 0x008F8558
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerRewardListItemUIController climbTowerRewardListItemUIController = (ClimbTowerRewardListItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			climbTowerRewardListItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CC2D RID: 117805 RVA: 0x008FA3C4 File Offset: 0x008F85C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerRewardListItemUIController climbTowerRewardListItemUIController = (ClimbTowerRewardListItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			climbTowerRewardListItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CC2E RID: 117806 RVA: 0x008FA430 File Offset: 0x008F8630
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerRewardListItemUIController climbTowerRewardListItemUIController = (ClimbTowerRewardListItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			climbTowerRewardListItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CC2F RID: 117807 RVA: 0x008FA49C File Offset: 0x008F869C
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
				ClimbTowerRewardListItemUIController climbTowerRewardListItemUIController = (ClimbTowerRewardListItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				climbTowerRewardListItemUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				ClimbTowerRewardListItemUIController climbTowerRewardListItemUIController2 = (ClimbTowerRewardListItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				climbTowerRewardListItemUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601CC30 RID: 117808 RVA: 0x008FA5AC File Offset: 0x008F87AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerRewardListItemUIController climbTowerRewardListItemUIController = (ClimbTowerRewardListItemUIController)LuaObject.checkSelf(l);
			string s = climbTowerRewardListItemUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601CC31 RID: 117809 RVA: 0x008FA608 File Offset: 0x008F8808
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_nameText(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerRewardListItemUIController climbTowerRewardListItemUIController = (ClimbTowerRewardListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, climbTowerRewardListItemUIController.m_luaExportHelper.m_nameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CC32 RID: 117810 RVA: 0x008FA660 File Offset: 0x008F8860
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_nameText(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerRewardListItemUIController climbTowerRewardListItemUIController = (ClimbTowerRewardListItemUIController)LuaObject.checkSelf(l);
			Text nameText;
			LuaObject.checkType<Text>(l, 2, out nameText);
			climbTowerRewardListItemUIController.m_luaExportHelper.m_nameText = nameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CC33 RID: 117811 RVA: 0x008FA6BC File Offset: 0x008F88BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_rewardGroupTransform(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerRewardListItemUIController climbTowerRewardListItemUIController = (ClimbTowerRewardListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, climbTowerRewardListItemUIController.m_luaExportHelper.m_rewardGroupTransform);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CC34 RID: 117812 RVA: 0x008FA714 File Offset: 0x008F8914
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_rewardGroupTransform(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerRewardListItemUIController climbTowerRewardListItemUIController = (ClimbTowerRewardListItemUIController)LuaObject.checkSelf(l);
			Transform rewardGroupTransform;
			LuaObject.checkType<Transform>(l, 2, out rewardGroupTransform);
			climbTowerRewardListItemUIController.m_luaExportHelper.m_rewardGroupTransform = rewardGroupTransform;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CC35 RID: 117813 RVA: 0x008FA770 File Offset: 0x008F8970
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.ClimbTowerRewardListItemUIController");
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerRewardListItemUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerRewardListItemUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerRewardListItemUIController.SetReward);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerRewardListItemUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerRewardListItemUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerRewardListItemUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerRewardListItemUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerRewardListItemUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerRewardListItemUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerRewardListItemUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerRewardListItemUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerRewardListItemUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerRewardListItemUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerRewardListItemUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerRewardListItemUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerRewardListItemUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerRewardListItemUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerRewardListItemUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerRewardListItemUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerRewardListItemUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerRewardListItemUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerRewardListItemUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerRewardListItemUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerRewardListItemUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerRewardListItemUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerRewardListItemUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerRewardListItemUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerRewardListItemUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerRewardListItemUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerRewardListItemUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerRewardListItemUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerRewardListItemUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerRewardListItemUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerRewardListItemUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerRewardListItemUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerRewardListItemUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerRewardListItemUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerRewardListItemUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerRewardListItemUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerRewardListItemUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerRewardListItemUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerRewardListItemUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerRewardListItemUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerRewardListItemUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerRewardListItemUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerRewardListItemUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerRewardListItemUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerRewardListItemUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerRewardListItemUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerRewardListItemUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerRewardListItemUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerRewardListItemUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerRewardListItemUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerRewardListItemUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerRewardListItemUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerRewardListItemUIController.<>f__mg$cacheD);
		string name = "m_nameText";
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerRewardListItemUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerRewardListItemUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerRewardListItemUIController.get_m_nameText);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_ClimbTowerRewardListItemUIController.<>f__mg$cacheE;
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerRewardListItemUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerRewardListItemUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerRewardListItemUIController.set_m_nameText);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_ClimbTowerRewardListItemUIController.<>f__mg$cacheF, true);
		string name2 = "m_rewardGroupTransform";
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerRewardListItemUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerRewardListItemUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerRewardListItemUIController.get_m_rewardGroupTransform);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_ClimbTowerRewardListItemUIController.<>f__mg$cache10;
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerRewardListItemUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerRewardListItemUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerRewardListItemUIController.set_m_rewardGroupTransform);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_ClimbTowerRewardListItemUIController.<>f__mg$cache11, true);
		LuaObject.createTypeMetatable(l, null, typeof(ClimbTowerRewardListItemUIController), typeof(UIControllerBase));
	}

	// Token: 0x04012E0D RID: 77325
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04012E0E RID: 77326
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04012E0F RID: 77327
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04012E10 RID: 77328
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04012E11 RID: 77329
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04012E12 RID: 77330
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04012E13 RID: 77331
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04012E14 RID: 77332
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04012E15 RID: 77333
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04012E16 RID: 77334
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04012E17 RID: 77335
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04012E18 RID: 77336
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04012E19 RID: 77337
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04012E1A RID: 77338
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04012E1B RID: 77339
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04012E1C RID: 77340
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04012E1D RID: 77341
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04012E1E RID: 77342
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;
}
