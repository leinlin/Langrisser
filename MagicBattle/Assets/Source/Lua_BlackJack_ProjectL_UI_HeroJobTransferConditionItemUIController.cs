using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x020014CB RID: 5323
[Preserve]
public class Lua_BlackJack_ProjectL_UI_HeroJobTransferConditionItemUIController : LuaObject
{
	// Token: 0x0601F25D RID: 127581 RVA: 0x00A2A4CC File Offset: 0x00A286CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitConditionItem(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferConditionItemUIController heroJobTransferConditionItemUIController = (HeroJobTransferConditionItemUIController)LuaObject.checkSelf(l);
			ConfigDataJobUnlockConditionInfo condition;
			LuaObject.checkType<ConfigDataJobUnlockConditionInfo>(l, 2, out condition);
			HeroJob heroJob;
			LuaObject.checkType<HeroJob>(l, 3, out heroJob);
			heroJobTransferConditionItemUIController.InitConditionItem(condition, heroJob);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F25E RID: 127582 RVA: 0x00A2A530 File Offset: 0x00A28730
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferConditionItemUIController heroJobTransferConditionItemUIController = (HeroJobTransferConditionItemUIController)LuaObject.checkSelf(l);
			heroJobTransferConditionItemUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F25F RID: 127583 RVA: 0x00A2A584 File Offset: 0x00A28784
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferConditionItemUIController heroJobTransferConditionItemUIController = (HeroJobTransferConditionItemUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			heroJobTransferConditionItemUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F260 RID: 127584 RVA: 0x00A2A5F0 File Offset: 0x00A287F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferConditionItemUIController heroJobTransferConditionItemUIController = (HeroJobTransferConditionItemUIController)LuaObject.checkSelf(l);
			heroJobTransferConditionItemUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F261 RID: 127585 RVA: 0x00A2A644 File Offset: 0x00A28844
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferConditionItemUIController heroJobTransferConditionItemUIController = (HeroJobTransferConditionItemUIController)LuaObject.checkSelf(l);
			heroJobTransferConditionItemUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F262 RID: 127586 RVA: 0x00A2A698 File Offset: 0x00A28898
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferConditionItemUIController heroJobTransferConditionItemUIController = (HeroJobTransferConditionItemUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = heroJobTransferConditionItemUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601F263 RID: 127587 RVA: 0x00A2A740 File Offset: 0x00A28940
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferConditionItemUIController heroJobTransferConditionItemUIController = (HeroJobTransferConditionItemUIController)LuaObject.checkSelf(l);
			heroJobTransferConditionItemUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F264 RID: 127588 RVA: 0x00A2A794 File Offset: 0x00A28994
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferConditionItemUIController heroJobTransferConditionItemUIController = (HeroJobTransferConditionItemUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			heroJobTransferConditionItemUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F265 RID: 127589 RVA: 0x00A2A800 File Offset: 0x00A28A00
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
				HeroJobTransferConditionItemUIController heroJobTransferConditionItemUIController = (HeroJobTransferConditionItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				heroJobTransferConditionItemUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				HeroJobTransferConditionItemUIController heroJobTransferConditionItemUIController2 = (HeroJobTransferConditionItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				heroJobTransferConditionItemUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601F266 RID: 127590 RVA: 0x00A2A910 File Offset: 0x00A28B10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferConditionItemUIController heroJobTransferConditionItemUIController = (HeroJobTransferConditionItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroJobTransferConditionItemUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F267 RID: 127591 RVA: 0x00A2A97C File Offset: 0x00A28B7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferConditionItemUIController heroJobTransferConditionItemUIController = (HeroJobTransferConditionItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroJobTransferConditionItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F268 RID: 127592 RVA: 0x00A2A9E8 File Offset: 0x00A28BE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferConditionItemUIController heroJobTransferConditionItemUIController = (HeroJobTransferConditionItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroJobTransferConditionItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F269 RID: 127593 RVA: 0x00A2AA54 File Offset: 0x00A28C54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferConditionItemUIController heroJobTransferConditionItemUIController = (HeroJobTransferConditionItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroJobTransferConditionItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F26A RID: 127594 RVA: 0x00A2AAC0 File Offset: 0x00A28CC0
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
				HeroJobTransferConditionItemUIController heroJobTransferConditionItemUIController = (HeroJobTransferConditionItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				heroJobTransferConditionItemUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				HeroJobTransferConditionItemUIController heroJobTransferConditionItemUIController2 = (HeroJobTransferConditionItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				heroJobTransferConditionItemUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601F26B RID: 127595 RVA: 0x00A2ABD0 File Offset: 0x00A28DD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferConditionItemUIController heroJobTransferConditionItemUIController = (HeroJobTransferConditionItemUIController)LuaObject.checkSelf(l);
			string s = heroJobTransferConditionItemUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601F26C RID: 127596 RVA: 0x00A2AC2C File Offset: 0x00A28E2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_text(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferConditionItemUIController heroJobTransferConditionItemUIController = (HeroJobTransferConditionItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobTransferConditionItemUIController.m_luaExportHelper.m_text);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F26D RID: 127597 RVA: 0x00A2AC84 File Offset: 0x00A28E84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_text(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferConditionItemUIController heroJobTransferConditionItemUIController = (HeroJobTransferConditionItemUIController)LuaObject.checkSelf(l);
			Text text;
			LuaObject.checkType<Text>(l, 2, out text);
			heroJobTransferConditionItemUIController.m_luaExportHelper.m_text = text;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F26E RID: 127598 RVA: 0x00A2ACE0 File Offset: 0x00A28EE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_finishTag(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferConditionItemUIController heroJobTransferConditionItemUIController = (HeroJobTransferConditionItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobTransferConditionItemUIController.m_luaExportHelper.m_finishTag);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F26F RID: 127599 RVA: 0x00A2AD38 File Offset: 0x00A28F38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_finishTag(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferConditionItemUIController heroJobTransferConditionItemUIController = (HeroJobTransferConditionItemUIController)LuaObject.checkSelf(l);
			GameObject finishTag;
			LuaObject.checkType<GameObject>(l, 2, out finishTag);
			heroJobTransferConditionItemUIController.m_luaExportHelper.m_finishTag = finishTag;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F270 RID: 127600 RVA: 0x00A2AD94 File Offset: 0x00A28F94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ConditionInfo(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferConditionItemUIController heroJobTransferConditionItemUIController = (HeroJobTransferConditionItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobTransferConditionItemUIController.ConditionInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F271 RID: 127601 RVA: 0x00A2ADE8 File Offset: 0x00A28FE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ConditionInfo(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferConditionItemUIController heroJobTransferConditionItemUIController = (HeroJobTransferConditionItemUIController)LuaObject.checkSelf(l);
			ConfigDataJobUnlockConditionInfo conditionInfo;
			LuaObject.checkType<ConfigDataJobUnlockConditionInfo>(l, 2, out conditionInfo);
			heroJobTransferConditionItemUIController.m_luaExportHelper.ConditionInfo = conditionInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F272 RID: 127602 RVA: 0x00A2AE44 File Offset: 0x00A29044
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.HeroJobTransferConditionItemUIController");
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferConditionItemUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferConditionItemUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferConditionItemUIController.InitConditionItem);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferConditionItemUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferConditionItemUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferConditionItemUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferConditionItemUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferConditionItemUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferConditionItemUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferConditionItemUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferConditionItemUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferConditionItemUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferConditionItemUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferConditionItemUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferConditionItemUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferConditionItemUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferConditionItemUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferConditionItemUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferConditionItemUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferConditionItemUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferConditionItemUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferConditionItemUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferConditionItemUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferConditionItemUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferConditionItemUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferConditionItemUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferConditionItemUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferConditionItemUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferConditionItemUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferConditionItemUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferConditionItemUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferConditionItemUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferConditionItemUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferConditionItemUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferConditionItemUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferConditionItemUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferConditionItemUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferConditionItemUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferConditionItemUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferConditionItemUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferConditionItemUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferConditionItemUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferConditionItemUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferConditionItemUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferConditionItemUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferConditionItemUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferConditionItemUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferConditionItemUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferConditionItemUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferConditionItemUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferConditionItemUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferConditionItemUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferConditionItemUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferConditionItemUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferConditionItemUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferConditionItemUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferConditionItemUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferConditionItemUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferConditionItemUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferConditionItemUIController.<>f__mg$cacheE);
		string name = "m_text";
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferConditionItemUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferConditionItemUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferConditionItemUIController.get_m_text);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_HeroJobTransferConditionItemUIController.<>f__mg$cacheF;
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferConditionItemUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferConditionItemUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferConditionItemUIController.set_m_text);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_HeroJobTransferConditionItemUIController.<>f__mg$cache10, true);
		string name2 = "m_finishTag";
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferConditionItemUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferConditionItemUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferConditionItemUIController.get_m_finishTag);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_HeroJobTransferConditionItemUIController.<>f__mg$cache11;
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferConditionItemUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferConditionItemUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferConditionItemUIController.set_m_finishTag);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_HeroJobTransferConditionItemUIController.<>f__mg$cache12, true);
		string name3 = "ConditionInfo";
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferConditionItemUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferConditionItemUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferConditionItemUIController.get_ConditionInfo);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_HeroJobTransferConditionItemUIController.<>f__mg$cache13;
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferConditionItemUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferConditionItemUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferConditionItemUIController.set_ConditionInfo);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_HeroJobTransferConditionItemUIController.<>f__mg$cache14, true);
		LuaObject.createTypeMetatable(l, null, typeof(HeroJobTransferConditionItemUIController), typeof(UIControllerBase));
	}

	// Token: 0x040152A9 RID: 86697
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040152AA RID: 86698
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040152AB RID: 86699
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040152AC RID: 86700
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040152AD RID: 86701
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040152AE RID: 86702
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040152AF RID: 86703
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040152B0 RID: 86704
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x040152B1 RID: 86705
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x040152B2 RID: 86706
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x040152B3 RID: 86707
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x040152B4 RID: 86708
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x040152B5 RID: 86709
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x040152B6 RID: 86710
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x040152B7 RID: 86711
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x040152B8 RID: 86712
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x040152B9 RID: 86713
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x040152BA RID: 86714
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x040152BB RID: 86715
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x040152BC RID: 86716
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x040152BD RID: 86717
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;
}
