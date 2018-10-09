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

// Token: 0x0200143D RID: 5181
[Preserve]
public class Lua_BlackJack_ProjectL_UI_FettersInformationLifeItemUIController : LuaObject
{
	// Token: 0x0601DD18 RID: 122136 RVA: 0x00981CD8 File Offset: 0x0097FED8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitLifeItem(IntPtr l)
	{
		int result;
		try
		{
			FettersInformationLifeItemUIController fettersInformationLifeItemUIController = (FettersInformationLifeItemUIController)LuaObject.checkSelf(l);
			int biographyId;
			LuaObject.checkType(l, 2, out biographyId);
			fettersInformationLifeItemUIController.InitLifeItem(biographyId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DD19 RID: 122137 RVA: 0x00981D30 File Offset: 0x0097FF30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateIsNewValue(IntPtr l)
	{
		int result;
		try
		{
			FettersInformationLifeItemUIController fettersInformationLifeItemUIController = (FettersInformationLifeItemUIController)LuaObject.checkSelf(l);
			fettersInformationLifeItemUIController.UpdateIsNewValue();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DD1A RID: 122138 RVA: 0x00981D7C File Offset: 0x0097FF7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsNewTagActive(IntPtr l)
	{
		int result;
		try
		{
			FettersInformationLifeItemUIController fettersInformationLifeItemUIController = (FettersInformationLifeItemUIController)LuaObject.checkSelf(l);
			bool b = fettersInformationLifeItemUIController.IsNewTagActive();
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

	// Token: 0x0601DD1B RID: 122139 RVA: 0x00981DD0 File Offset: 0x0097FFD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			FettersInformationLifeItemUIController fettersInformationLifeItemUIController = (FettersInformationLifeItemUIController)LuaObject.checkSelf(l);
			fettersInformationLifeItemUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DD1C RID: 122140 RVA: 0x00981E24 File Offset: 0x00980024
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsBiographyRead(IntPtr l)
	{
		int result;
		try
		{
			FettersInformationLifeItemUIController fettersInformationLifeItemUIController = (FettersInformationLifeItemUIController)LuaObject.checkSelf(l);
			int id;
			LuaObject.checkType(l, 2, out id);
			bool b = fettersInformationLifeItemUIController.m_luaExportHelper.IsBiographyRead(id);
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

	// Token: 0x0601DD1D RID: 122141 RVA: 0x00981E8C File Offset: 0x0098008C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			FettersInformationLifeItemUIController fettersInformationLifeItemUIController = (FettersInformationLifeItemUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			fettersInformationLifeItemUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DD1E RID: 122142 RVA: 0x00981EF8 File Offset: 0x009800F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			FettersInformationLifeItemUIController fettersInformationLifeItemUIController = (FettersInformationLifeItemUIController)LuaObject.checkSelf(l);
			fettersInformationLifeItemUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DD1F RID: 122143 RVA: 0x00981F4C File Offset: 0x0098014C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			FettersInformationLifeItemUIController fettersInformationLifeItemUIController = (FettersInformationLifeItemUIController)LuaObject.checkSelf(l);
			fettersInformationLifeItemUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DD20 RID: 122144 RVA: 0x00981FA0 File Offset: 0x009801A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			FettersInformationLifeItemUIController fettersInformationLifeItemUIController = (FettersInformationLifeItemUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = fettersInformationLifeItemUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601DD21 RID: 122145 RVA: 0x00982048 File Offset: 0x00980248
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			FettersInformationLifeItemUIController fettersInformationLifeItemUIController = (FettersInformationLifeItemUIController)LuaObject.checkSelf(l);
			fettersInformationLifeItemUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DD22 RID: 122146 RVA: 0x0098209C File Offset: 0x0098029C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			FettersInformationLifeItemUIController fettersInformationLifeItemUIController = (FettersInformationLifeItemUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			fettersInformationLifeItemUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DD23 RID: 122147 RVA: 0x00982108 File Offset: 0x00980308
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
				FettersInformationLifeItemUIController fettersInformationLifeItemUIController = (FettersInformationLifeItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				fettersInformationLifeItemUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				FettersInformationLifeItemUIController fettersInformationLifeItemUIController2 = (FettersInformationLifeItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				fettersInformationLifeItemUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601DD24 RID: 122148 RVA: 0x00982218 File Offset: 0x00980418
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			FettersInformationLifeItemUIController fettersInformationLifeItemUIController = (FettersInformationLifeItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			fettersInformationLifeItemUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DD25 RID: 122149 RVA: 0x00982284 File Offset: 0x00980484
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			FettersInformationLifeItemUIController fettersInformationLifeItemUIController = (FettersInformationLifeItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			fettersInformationLifeItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DD26 RID: 122150 RVA: 0x009822F0 File Offset: 0x009804F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			FettersInformationLifeItemUIController fettersInformationLifeItemUIController = (FettersInformationLifeItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			fettersInformationLifeItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DD27 RID: 122151 RVA: 0x0098235C File Offset: 0x0098055C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			FettersInformationLifeItemUIController fettersInformationLifeItemUIController = (FettersInformationLifeItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			fettersInformationLifeItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DD28 RID: 122152 RVA: 0x009823C8 File Offset: 0x009805C8
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
				FettersInformationLifeItemUIController fettersInformationLifeItemUIController = (FettersInformationLifeItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				fettersInformationLifeItemUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				FettersInformationLifeItemUIController fettersInformationLifeItemUIController2 = (FettersInformationLifeItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				fettersInformationLifeItemUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601DD29 RID: 122153 RVA: 0x009824D8 File Offset: 0x009806D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			FettersInformationLifeItemUIController fettersInformationLifeItemUIController = (FettersInformationLifeItemUIController)LuaObject.checkSelf(l);
			string s = fettersInformationLifeItemUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601DD2A RID: 122154 RVA: 0x00982534 File Offset: 0x00980734
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			FettersInformationLifeItemUIController fettersInformationLifeItemUIController = (FettersInformationLifeItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersInformationLifeItemUIController.m_luaExportHelper.m_uiStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DD2B RID: 122155 RVA: 0x0098258C File Offset: 0x0098078C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			FettersInformationLifeItemUIController fettersInformationLifeItemUIController = (FettersInformationLifeItemUIController)LuaObject.checkSelf(l);
			CommonUIStateController uiStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out uiStateCtrl);
			fettersInformationLifeItemUIController.m_luaExportHelper.m_uiStateCtrl = uiStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DD2C RID: 122156 RVA: 0x009825E8 File Offset: 0x009807E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_unlockContentText(IntPtr l)
	{
		int result;
		try
		{
			FettersInformationLifeItemUIController fettersInformationLifeItemUIController = (FettersInformationLifeItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersInformationLifeItemUIController.m_luaExportHelper.m_unlockContentText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DD2D RID: 122157 RVA: 0x00982640 File Offset: 0x00980840
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_unlockContentText(IntPtr l)
	{
		int result;
		try
		{
			FettersInformationLifeItemUIController fettersInformationLifeItemUIController = (FettersInformationLifeItemUIController)LuaObject.checkSelf(l);
			Text unlockContentText;
			LuaObject.checkType<Text>(l, 2, out unlockContentText);
			fettersInformationLifeItemUIController.m_luaExportHelper.m_unlockContentText = unlockContentText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DD2E RID: 122158 RVA: 0x0098269C File Offset: 0x0098089C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_unlockTitleText(IntPtr l)
	{
		int result;
		try
		{
			FettersInformationLifeItemUIController fettersInformationLifeItemUIController = (FettersInformationLifeItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersInformationLifeItemUIController.m_luaExportHelper.m_unlockTitleText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DD2F RID: 122159 RVA: 0x009826F4 File Offset: 0x009808F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_unlockTitleText(IntPtr l)
	{
		int result;
		try
		{
			FettersInformationLifeItemUIController fettersInformationLifeItemUIController = (FettersInformationLifeItemUIController)LuaObject.checkSelf(l);
			Text unlockTitleText;
			LuaObject.checkType<Text>(l, 2, out unlockTitleText);
			fettersInformationLifeItemUIController.m_luaExportHelper.m_unlockTitleText = unlockTitleText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DD30 RID: 122160 RVA: 0x00982750 File Offset: 0x00980950
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_lockText(IntPtr l)
	{
		int result;
		try
		{
			FettersInformationLifeItemUIController fettersInformationLifeItemUIController = (FettersInformationLifeItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersInformationLifeItemUIController.m_luaExportHelper.m_lockText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DD31 RID: 122161 RVA: 0x009827A8 File Offset: 0x009809A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_lockText(IntPtr l)
	{
		int result;
		try
		{
			FettersInformationLifeItemUIController fettersInformationLifeItemUIController = (FettersInformationLifeItemUIController)LuaObject.checkSelf(l);
			Text lockText;
			LuaObject.checkType<Text>(l, 2, out lockText);
			fettersInformationLifeItemUIController.m_luaExportHelper.m_lockText = lockText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DD32 RID: 122162 RVA: 0x00982804 File Offset: 0x00980A04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroBiographyInfo(IntPtr l)
	{
		int result;
		try
		{
			FettersInformationLifeItemUIController fettersInformationLifeItemUIController = (FettersInformationLifeItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersInformationLifeItemUIController.m_heroBiographyInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DD33 RID: 122163 RVA: 0x00982858 File Offset: 0x00980A58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroBiographyInfo(IntPtr l)
	{
		int result;
		try
		{
			FettersInformationLifeItemUIController fettersInformationLifeItemUIController = (FettersInformationLifeItemUIController)LuaObject.checkSelf(l);
			ConfigDataHeroBiographyInfo heroBiographyInfo;
			LuaObject.checkType<ConfigDataHeroBiographyInfo>(l, 2, out heroBiographyInfo);
			fettersInformationLifeItemUIController.m_heroBiographyInfo = heroBiographyInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DD34 RID: 122164 RVA: 0x009828B0 File Offset: 0x00980AB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_IsNew(IntPtr l)
	{
		int result;
		try
		{
			FettersInformationLifeItemUIController fettersInformationLifeItemUIController = (FettersInformationLifeItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersInformationLifeItemUIController.IsNew);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DD35 RID: 122165 RVA: 0x00982908 File Offset: 0x00980B08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_IsNew(IntPtr l)
	{
		int result;
		try
		{
			FettersInformationLifeItemUIController fettersInformationLifeItemUIController = (FettersInformationLifeItemUIController)LuaObject.checkSelf(l);
			bool? isNew;
			LuaObject.checkNullable<bool>(l, 2, out isNew);
			fettersInformationLifeItemUIController.IsNew = isNew;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DD36 RID: 122166 RVA: 0x00982960 File Offset: 0x00980B60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isLock(IntPtr l)
	{
		int result;
		try
		{
			FettersInformationLifeItemUIController fettersInformationLifeItemUIController = (FettersInformationLifeItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersInformationLifeItemUIController.m_luaExportHelper.m_isLock);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DD37 RID: 122167 RVA: 0x009829B8 File Offset: 0x00980BB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isLock(IntPtr l)
	{
		int result;
		try
		{
			FettersInformationLifeItemUIController fettersInformationLifeItemUIController = (FettersInformationLifeItemUIController)LuaObject.checkSelf(l);
			bool isLock;
			LuaObject.checkType(l, 2, out isLock);
			fettersInformationLifeItemUIController.m_luaExportHelper.m_isLock = isLock;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DD38 RID: 122168 RVA: 0x00982A14 File Offset: 0x00980C14
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.FettersInformationLifeItemUIController");
		if (Lua_BlackJack_ProjectL_UI_FettersInformationLifeItemUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersInformationLifeItemUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersInformationLifeItemUIController.InitLifeItem);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersInformationLifeItemUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_FettersInformationLifeItemUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersInformationLifeItemUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersInformationLifeItemUIController.UpdateIsNewValue);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersInformationLifeItemUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_FettersInformationLifeItemUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersInformationLifeItemUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersInformationLifeItemUIController.IsNewTagActive);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersInformationLifeItemUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_FettersInformationLifeItemUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersInformationLifeItemUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersInformationLifeItemUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersInformationLifeItemUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_FettersInformationLifeItemUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersInformationLifeItemUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersInformationLifeItemUIController.IsBiographyRead);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersInformationLifeItemUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_FettersInformationLifeItemUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersInformationLifeItemUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersInformationLifeItemUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersInformationLifeItemUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_FettersInformationLifeItemUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersInformationLifeItemUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersInformationLifeItemUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersInformationLifeItemUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_FettersInformationLifeItemUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersInformationLifeItemUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersInformationLifeItemUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersInformationLifeItemUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_FettersInformationLifeItemUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersInformationLifeItemUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersInformationLifeItemUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersInformationLifeItemUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_FettersInformationLifeItemUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersInformationLifeItemUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersInformationLifeItemUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersInformationLifeItemUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_FettersInformationLifeItemUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersInformationLifeItemUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersInformationLifeItemUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersInformationLifeItemUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_FettersInformationLifeItemUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersInformationLifeItemUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersInformationLifeItemUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersInformationLifeItemUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_FettersInformationLifeItemUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersInformationLifeItemUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersInformationLifeItemUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersInformationLifeItemUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_FettersInformationLifeItemUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersInformationLifeItemUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersInformationLifeItemUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersInformationLifeItemUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_FettersInformationLifeItemUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersInformationLifeItemUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersInformationLifeItemUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersInformationLifeItemUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_FettersInformationLifeItemUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersInformationLifeItemUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersInformationLifeItemUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersInformationLifeItemUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_FettersInformationLifeItemUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersInformationLifeItemUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersInformationLifeItemUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersInformationLifeItemUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_FettersInformationLifeItemUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersInformationLifeItemUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersInformationLifeItemUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersInformationLifeItemUIController.<>f__mg$cache11);
		string name = "m_uiStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_FettersInformationLifeItemUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersInformationLifeItemUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersInformationLifeItemUIController.get_m_uiStateCtrl);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_FettersInformationLifeItemUIController.<>f__mg$cache12;
		if (Lua_BlackJack_ProjectL_UI_FettersInformationLifeItemUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersInformationLifeItemUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersInformationLifeItemUIController.set_m_uiStateCtrl);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_FettersInformationLifeItemUIController.<>f__mg$cache13, true);
		string name2 = "m_unlockContentText";
		if (Lua_BlackJack_ProjectL_UI_FettersInformationLifeItemUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersInformationLifeItemUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersInformationLifeItemUIController.get_m_unlockContentText);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_FettersInformationLifeItemUIController.<>f__mg$cache14;
		if (Lua_BlackJack_ProjectL_UI_FettersInformationLifeItemUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersInformationLifeItemUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersInformationLifeItemUIController.set_m_unlockContentText);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_FettersInformationLifeItemUIController.<>f__mg$cache15, true);
		string name3 = "m_unlockTitleText";
		if (Lua_BlackJack_ProjectL_UI_FettersInformationLifeItemUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersInformationLifeItemUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersInformationLifeItemUIController.get_m_unlockTitleText);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_FettersInformationLifeItemUIController.<>f__mg$cache16;
		if (Lua_BlackJack_ProjectL_UI_FettersInformationLifeItemUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersInformationLifeItemUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersInformationLifeItemUIController.set_m_unlockTitleText);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_FettersInformationLifeItemUIController.<>f__mg$cache17, true);
		string name4 = "m_lockText";
		if (Lua_BlackJack_ProjectL_UI_FettersInformationLifeItemUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersInformationLifeItemUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersInformationLifeItemUIController.get_m_lockText);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_FettersInformationLifeItemUIController.<>f__mg$cache18;
		if (Lua_BlackJack_ProjectL_UI_FettersInformationLifeItemUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersInformationLifeItemUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersInformationLifeItemUIController.set_m_lockText);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_FettersInformationLifeItemUIController.<>f__mg$cache19, true);
		string name5 = "m_heroBiographyInfo";
		if (Lua_BlackJack_ProjectL_UI_FettersInformationLifeItemUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersInformationLifeItemUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersInformationLifeItemUIController.get_m_heroBiographyInfo);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_FettersInformationLifeItemUIController.<>f__mg$cache1A;
		if (Lua_BlackJack_ProjectL_UI_FettersInformationLifeItemUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersInformationLifeItemUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersInformationLifeItemUIController.set_m_heroBiographyInfo);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_FettersInformationLifeItemUIController.<>f__mg$cache1B, true);
		string name6 = "IsNew";
		if (Lua_BlackJack_ProjectL_UI_FettersInformationLifeItemUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersInformationLifeItemUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersInformationLifeItemUIController.get_IsNew);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_FettersInformationLifeItemUIController.<>f__mg$cache1C;
		if (Lua_BlackJack_ProjectL_UI_FettersInformationLifeItemUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersInformationLifeItemUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersInformationLifeItemUIController.set_IsNew);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_FettersInformationLifeItemUIController.<>f__mg$cache1D, true);
		string name7 = "m_isLock";
		if (Lua_BlackJack_ProjectL_UI_FettersInformationLifeItemUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersInformationLifeItemUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersInformationLifeItemUIController.get_m_isLock);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_FettersInformationLifeItemUIController.<>f__mg$cache1E;
		if (Lua_BlackJack_ProjectL_UI_FettersInformationLifeItemUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersInformationLifeItemUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersInformationLifeItemUIController.set_m_isLock);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_FettersInformationLifeItemUIController.<>f__mg$cache1F, true);
		LuaObject.createTypeMetatable(l, null, typeof(FettersInformationLifeItemUIController), typeof(UIControllerBase));
	}

	// Token: 0x04013E80 RID: 81536
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04013E81 RID: 81537
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04013E82 RID: 81538
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04013E83 RID: 81539
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04013E84 RID: 81540
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04013E85 RID: 81541
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04013E86 RID: 81542
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04013E87 RID: 81543
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04013E88 RID: 81544
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04013E89 RID: 81545
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04013E8A RID: 81546
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04013E8B RID: 81547
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04013E8C RID: 81548
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04013E8D RID: 81549
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04013E8E RID: 81550
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04013E8F RID: 81551
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04013E90 RID: 81552
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04013E91 RID: 81553
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04013E92 RID: 81554
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04013E93 RID: 81555
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04013E94 RID: 81556
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04013E95 RID: 81557
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04013E96 RID: 81558
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04013E97 RID: 81559
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04013E98 RID: 81560
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04013E99 RID: 81561
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04013E9A RID: 81562
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04013E9B RID: 81563
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04013E9C RID: 81564
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04013E9D RID: 81565
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04013E9E RID: 81566
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04013E9F RID: 81567
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;
}
