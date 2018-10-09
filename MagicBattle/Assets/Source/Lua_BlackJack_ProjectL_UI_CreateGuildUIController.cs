using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x0200140D RID: 5133
[Preserve]
public class Lua_BlackJack_ProjectL_UI_CreateGuildUIController : LuaObject
{
	// Token: 0x0601D007 RID: 118791 RVA: 0x00919434 File Offset: 0x00917634
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Show(IntPtr l)
	{
		int result;
		try
		{
			CreateGuildUIController createGuildUIController = (CreateGuildUIController)LuaObject.checkSelf(l);
			createGuildUIController.Show();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D008 RID: 118792 RVA: 0x00919480 File Offset: 0x00917680
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			CreateGuildUIController createGuildUIController = (CreateGuildUIController)LuaObject.checkSelf(l);
			createGuildUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D009 RID: 118793 RVA: 0x009194D4 File Offset: 0x009176D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CreateGuild(IntPtr l)
	{
		int result;
		try
		{
			CreateGuildUIController createGuildUIController = (CreateGuildUIController)LuaObject.checkSelf(l);
			createGuildUIController.m_luaExportHelper.CreateGuild();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D00A RID: 118794 RVA: 0x00919528 File Offset: 0x00917728
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RefreshLevelDisplay(IntPtr l)
	{
		int result;
		try
		{
			CreateGuildUIController createGuildUIController = (CreateGuildUIController)LuaObject.checkSelf(l);
			createGuildUIController.m_luaExportHelper.RefreshLevelDisplay();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D00B RID: 118795 RVA: 0x0091957C File Offset: 0x0091777C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnCreateGuildClick(IntPtr l)
	{
		int result;
		try
		{
			CreateGuildUIController createGuildUIController = (CreateGuildUIController)LuaObject.checkSelf(l);
			createGuildUIController.m_luaExportHelper.OnCreateGuildClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D00C RID: 118796 RVA: 0x009195D0 File Offset: 0x009177D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnCloseClick(IntPtr l)
	{
		int result;
		try
		{
			CreateGuildUIController createGuildUIController = (CreateGuildUIController)LuaObject.checkSelf(l);
			createGuildUIController.m_luaExportHelper.OnCloseClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D00D RID: 118797 RVA: 0x00919624 File Offset: 0x00917824
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnForwardLevelClick(IntPtr l)
	{
		int result;
		try
		{
			CreateGuildUIController createGuildUIController = (CreateGuildUIController)LuaObject.checkSelf(l);
			createGuildUIController.m_luaExportHelper.OnForwardLevelClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D00E RID: 118798 RVA: 0x00919678 File Offset: 0x00917878
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBackwardLevelClick(IntPtr l)
	{
		int result;
		try
		{
			CreateGuildUIController createGuildUIController = (CreateGuildUIController)LuaObject.checkSelf(l);
			createGuildUIController.m_luaExportHelper.OnBackwardLevelClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D00F RID: 118799 RVA: 0x009196CC File Offset: 0x009178CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBGClick(IntPtr l)
	{
		int result;
		try
		{
			CreateGuildUIController createGuildUIController = (CreateGuildUIController)LuaObject.checkSelf(l);
			createGuildUIController.m_luaExportHelper.OnBGClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D010 RID: 118800 RVA: 0x00919720 File Offset: 0x00917920
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnLevelInputFiledEndEdit(IntPtr l)
	{
		int result;
		try
		{
			CreateGuildUIController createGuildUIController = (CreateGuildUIController)LuaObject.checkSelf(l);
			string content;
			LuaObject.checkType(l, 2, out content);
			createGuildUIController.m_luaExportHelper.OnLevelInputFiledEndEdit(content);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D011 RID: 118801 RVA: 0x0091977C File Offset: 0x0091797C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnGuildDeclaratioInputFiledEndEdit(IntPtr l)
	{
		int result;
		try
		{
			CreateGuildUIController createGuildUIController = (CreateGuildUIController)LuaObject.checkSelf(l);
			string content;
			LuaObject.checkType(l, 2, out content);
			createGuildUIController.m_luaExportHelper.OnGuildDeclaratioInputFiledEndEdit(content);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D012 RID: 118802 RVA: 0x009197D8 File Offset: 0x009179D8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			CreateGuildUIController createGuildUIController = (CreateGuildUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			createGuildUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D013 RID: 118803 RVA: 0x00919844 File Offset: 0x00917A44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			CreateGuildUIController createGuildUIController = (CreateGuildUIController)LuaObject.checkSelf(l);
			createGuildUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D014 RID: 118804 RVA: 0x00919898 File Offset: 0x00917A98
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			CreateGuildUIController createGuildUIController = (CreateGuildUIController)LuaObject.checkSelf(l);
			createGuildUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D015 RID: 118805 RVA: 0x009198EC File Offset: 0x00917AEC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			CreateGuildUIController createGuildUIController = (CreateGuildUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = createGuildUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601D016 RID: 118806 RVA: 0x00919994 File Offset: 0x00917B94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			CreateGuildUIController createGuildUIController = (CreateGuildUIController)LuaObject.checkSelf(l);
			createGuildUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D017 RID: 118807 RVA: 0x009199E8 File Offset: 0x00917BE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			CreateGuildUIController createGuildUIController = (CreateGuildUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			createGuildUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D018 RID: 118808 RVA: 0x00919A54 File Offset: 0x00917C54
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetButtonClickListener(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(string[]), typeof(Action<UIControllerBase>)))
			{
				CreateGuildUIController createGuildUIController = (CreateGuildUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				createGuildUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				CreateGuildUIController createGuildUIController2 = (CreateGuildUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				createGuildUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601D019 RID: 118809 RVA: 0x00919B64 File Offset: 0x00917D64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			CreateGuildUIController createGuildUIController = (CreateGuildUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			createGuildUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D01A RID: 118810 RVA: 0x00919BD0 File Offset: 0x00917DD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			CreateGuildUIController createGuildUIController = (CreateGuildUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			createGuildUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D01B RID: 118811 RVA: 0x00919C3C File Offset: 0x00917E3C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			CreateGuildUIController createGuildUIController = (CreateGuildUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			createGuildUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D01C RID: 118812 RVA: 0x00919CA8 File Offset: 0x00917EA8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			CreateGuildUIController createGuildUIController = (CreateGuildUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			createGuildUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D01D RID: 118813 RVA: 0x00919D14 File Offset: 0x00917F14
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetToggleValueChangedListener(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(string[]), typeof(Action<UIControllerBase, bool>)))
			{
				CreateGuildUIController createGuildUIController = (CreateGuildUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				createGuildUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				CreateGuildUIController createGuildUIController2 = (CreateGuildUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				createGuildUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601D01E RID: 118814 RVA: 0x00919E24 File Offset: 0x00918024
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			CreateGuildUIController createGuildUIController = (CreateGuildUIController)LuaObject.checkSelf(l);
			string s = createGuildUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601D01F RID: 118815 RVA: 0x00919E80 File Offset: 0x00918080
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_createGuildPanelAnimation(IntPtr l)
	{
		int result;
		try
		{
			CreateGuildUIController createGuildUIController = (CreateGuildUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, createGuildUIController.m_luaExportHelper.m_createGuildPanelAnimation);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D020 RID: 118816 RVA: 0x00919ED8 File Offset: 0x009180D8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_createGuildPanelAnimation(IntPtr l)
	{
		int result;
		try
		{
			CreateGuildUIController createGuildUIController = (CreateGuildUIController)LuaObject.checkSelf(l);
			CommonUIStateController createGuildPanelAnimation;
			LuaObject.checkType<CommonUIStateController>(l, 2, out createGuildPanelAnimation);
			createGuildUIController.m_luaExportHelper.m_createGuildPanelAnimation = createGuildPanelAnimation;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D021 RID: 118817 RVA: 0x00919F34 File Offset: 0x00918134
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_guildNameInputField(IntPtr l)
	{
		int result;
		try
		{
			CreateGuildUIController createGuildUIController = (CreateGuildUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, createGuildUIController.m_luaExportHelper.m_guildNameInputField);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D022 RID: 118818 RVA: 0x00919F8C File Offset: 0x0091818C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_guildNameInputField(IntPtr l)
	{
		int result;
		try
		{
			CreateGuildUIController createGuildUIController = (CreateGuildUIController)LuaObject.checkSelf(l);
			InputField guildNameInputField;
			LuaObject.checkType<InputField>(l, 2, out guildNameInputField);
			createGuildUIController.m_luaExportHelper.m_guildNameInputField = guildNameInputField;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D023 RID: 118819 RVA: 0x00919FE8 File Offset: 0x009181E8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_guildDeclarationInputField(IntPtr l)
	{
		int result;
		try
		{
			CreateGuildUIController createGuildUIController = (CreateGuildUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, createGuildUIController.m_luaExportHelper.m_guildDeclarationInputField);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D024 RID: 118820 RVA: 0x0091A040 File Offset: 0x00918240
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_guildDeclarationInputField(IntPtr l)
	{
		int result;
		try
		{
			CreateGuildUIController createGuildUIController = (CreateGuildUIController)LuaObject.checkSelf(l);
			InputField guildDeclarationInputField;
			LuaObject.checkType<InputField>(l, 2, out guildDeclarationInputField);
			createGuildUIController.m_luaExportHelper.m_guildDeclarationInputField = guildDeclarationInputField;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D025 RID: 118821 RVA: 0x0091A09C File Offset: 0x0091829C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_levelInputField(IntPtr l)
	{
		int result;
		try
		{
			CreateGuildUIController createGuildUIController = (CreateGuildUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, createGuildUIController.m_luaExportHelper.m_levelInputField);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D026 RID: 118822 RVA: 0x0091A0F4 File Offset: 0x009182F4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_levelInputField(IntPtr l)
	{
		int result;
		try
		{
			CreateGuildUIController createGuildUIController = (CreateGuildUIController)LuaObject.checkSelf(l);
			InputField levelInputField;
			LuaObject.checkType<InputField>(l, 2, out levelInputField);
			createGuildUIController.m_luaExportHelper.m_levelInputField = levelInputField;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D027 RID: 118823 RVA: 0x0091A150 File Offset: 0x00918350
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_forwardLevelButton(IntPtr l)
	{
		int result;
		try
		{
			CreateGuildUIController createGuildUIController = (CreateGuildUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, createGuildUIController.m_luaExportHelper.m_forwardLevelButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D028 RID: 118824 RVA: 0x0091A1A8 File Offset: 0x009183A8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_forwardLevelButton(IntPtr l)
	{
		int result;
		try
		{
			CreateGuildUIController createGuildUIController = (CreateGuildUIController)LuaObject.checkSelf(l);
			Button forwardLevelButton;
			LuaObject.checkType<Button>(l, 2, out forwardLevelButton);
			createGuildUIController.m_luaExportHelper.m_forwardLevelButton = forwardLevelButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D029 RID: 118825 RVA: 0x0091A204 File Offset: 0x00918404
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_backwardLevelButton(IntPtr l)
	{
		int result;
		try
		{
			CreateGuildUIController createGuildUIController = (CreateGuildUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, createGuildUIController.m_luaExportHelper.m_backwardLevelButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D02A RID: 118826 RVA: 0x0091A25C File Offset: 0x0091845C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_backwardLevelButton(IntPtr l)
	{
		int result;
		try
		{
			CreateGuildUIController createGuildUIController = (CreateGuildUIController)LuaObject.checkSelf(l);
			Button backwardLevelButton;
			LuaObject.checkType<Button>(l, 2, out backwardLevelButton);
			createGuildUIController.m_luaExportHelper.m_backwardLevelButton = backwardLevelButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D02B RID: 118827 RVA: 0x0091A2B8 File Offset: 0x009184B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_requireItemIamge(IntPtr l)
	{
		int result;
		try
		{
			CreateGuildUIController createGuildUIController = (CreateGuildUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, createGuildUIController.m_luaExportHelper.m_requireItemIamge);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D02C RID: 118828 RVA: 0x0091A310 File Offset: 0x00918510
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_requireItemIamge(IntPtr l)
	{
		int result;
		try
		{
			CreateGuildUIController createGuildUIController = (CreateGuildUIController)LuaObject.checkSelf(l);
			Image requireItemIamge;
			LuaObject.checkType<Image>(l, 2, out requireItemIamge);
			createGuildUIController.m_luaExportHelper.m_requireItemIamge = requireItemIamge;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D02D RID: 118829 RVA: 0x0091A36C File Offset: 0x0091856C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_approveAutoToggle(IntPtr l)
	{
		int result;
		try
		{
			CreateGuildUIController createGuildUIController = (CreateGuildUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, createGuildUIController.m_luaExportHelper.m_approveAutoToggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D02E RID: 118830 RVA: 0x0091A3C4 File Offset: 0x009185C4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_approveAutoToggle(IntPtr l)
	{
		int result;
		try
		{
			CreateGuildUIController createGuildUIController = (CreateGuildUIController)LuaObject.checkSelf(l);
			Toggle approveAutoToggle;
			LuaObject.checkType<Toggle>(l, 2, out approveAutoToggle);
			createGuildUIController.m_luaExportHelper.m_approveAutoToggle = approveAutoToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D02F RID: 118831 RVA: 0x0091A420 File Offset: 0x00918620
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_approveChairmanToggle(IntPtr l)
	{
		int result;
		try
		{
			CreateGuildUIController createGuildUIController = (CreateGuildUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, createGuildUIController.m_luaExportHelper.m_approveChairmanToggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D030 RID: 118832 RVA: 0x0091A478 File Offset: 0x00918678
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_approveChairmanToggle(IntPtr l)
	{
		int result;
		try
		{
			CreateGuildUIController createGuildUIController = (CreateGuildUIController)LuaObject.checkSelf(l);
			Toggle approveChairmanToggle;
			LuaObject.checkType<Toggle>(l, 2, out approveChairmanToggle);
			createGuildUIController.m_luaExportHelper.m_approveChairmanToggle = approveChairmanToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D031 RID: 118833 RVA: 0x0091A4D4 File Offset: 0x009186D4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_createButton(IntPtr l)
	{
		int result;
		try
		{
			CreateGuildUIController createGuildUIController = (CreateGuildUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, createGuildUIController.m_luaExportHelper.m_createButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D032 RID: 118834 RVA: 0x0091A52C File Offset: 0x0091872C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_createButton(IntPtr l)
	{
		int result;
		try
		{
			CreateGuildUIController createGuildUIController = (CreateGuildUIController)LuaObject.checkSelf(l);
			Button createButton;
			LuaObject.checkType<Button>(l, 2, out createButton);
			createGuildUIController.m_luaExportHelper.m_createButton = createButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D033 RID: 118835 RVA: 0x0091A588 File Offset: 0x00918788
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_colseButton(IntPtr l)
	{
		int result;
		try
		{
			CreateGuildUIController createGuildUIController = (CreateGuildUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, createGuildUIController.m_luaExportHelper.m_colseButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D034 RID: 118836 RVA: 0x0091A5E0 File Offset: 0x009187E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_colseButton(IntPtr l)
	{
		int result;
		try
		{
			CreateGuildUIController createGuildUIController = (CreateGuildUIController)LuaObject.checkSelf(l);
			Button colseButton;
			LuaObject.checkType<Button>(l, 2, out colseButton);
			createGuildUIController.m_luaExportHelper.m_colseButton = colseButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D035 RID: 118837 RVA: 0x0091A63C File Offset: 0x0091883C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_bgButton(IntPtr l)
	{
		int result;
		try
		{
			CreateGuildUIController createGuildUIController = (CreateGuildUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, createGuildUIController.m_luaExportHelper.m_bgButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D036 RID: 118838 RVA: 0x0091A694 File Offset: 0x00918894
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_bgButton(IntPtr l)
	{
		int result;
		try
		{
			CreateGuildUIController createGuildUIController = (CreateGuildUIController)LuaObject.checkSelf(l);
			Button bgButton;
			LuaObject.checkType<Button>(l, 2, out bgButton);
			createGuildUIController.m_luaExportHelper.m_bgButton = bgButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D037 RID: 118839 RVA: 0x0091A6F0 File Offset: 0x009188F0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			CreateGuildUIController createGuildUIController = (CreateGuildUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, createGuildUIController.m_luaExportHelper.m_playerContext);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D038 RID: 118840 RVA: 0x0091A748 File Offset: 0x00918948
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			CreateGuildUIController createGuildUIController = (CreateGuildUIController)LuaObject.checkSelf(l);
			ProjectLPlayerContext playerContext;
			LuaObject.checkType<ProjectLPlayerContext>(l, 2, out playerContext);
			createGuildUIController.m_luaExportHelper.m_playerContext = playerContext;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D039 RID: 118841 RVA: 0x0091A7A4 File Offset: 0x009189A4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			CreateGuildUIController createGuildUIController = (CreateGuildUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, createGuildUIController.m_luaExportHelper.m_configDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D03A RID: 118842 RVA: 0x0091A7FC File Offset: 0x009189FC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			CreateGuildUIController createGuildUIController = (CreateGuildUIController)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			createGuildUIController.m_luaExportHelper.m_configDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D03B RID: 118843 RVA: 0x0091A858 File Offset: 0x00918A58
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_requireLevel(IntPtr l)
	{
		int result;
		try
		{
			CreateGuildUIController createGuildUIController = (CreateGuildUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, createGuildUIController.m_luaExportHelper.m_requireLevel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D03C RID: 118844 RVA: 0x0091A8B0 File Offset: 0x00918AB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_requireLevel(IntPtr l)
	{
		int result;
		try
		{
			CreateGuildUIController createGuildUIController = (CreateGuildUIController)LuaObject.checkSelf(l);
			int requireLevel;
			LuaObject.checkType(l, 2, out requireLevel);
			createGuildUIController.m_luaExportHelper.m_requireLevel = requireLevel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D03D RID: 118845 RVA: 0x0091A90C File Offset: 0x00918B0C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_guildUITask(IntPtr l)
	{
		int result;
		try
		{
			CreateGuildUIController createGuildUIController = (CreateGuildUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, createGuildUIController.m_luaExportHelper.m_guildUITask);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D03E RID: 118846 RVA: 0x0091A964 File Offset: 0x00918B64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_guildUITask(IntPtr l)
	{
		int result;
		try
		{
			CreateGuildUIController createGuildUIController = (CreateGuildUIController)LuaObject.checkSelf(l);
			GuildUITask guildUITask;
			LuaObject.checkType<GuildUITask>(l, 2, out guildUITask);
			createGuildUIController.m_luaExportHelper.m_guildUITask = guildUITask;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D03F RID: 118847 RVA: 0x0091A9C0 File Offset: 0x00918BC0
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.CreateGuildUIController");
		if (Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateGuildUIController.Show);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateGuildUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateGuildUIController.CreateGuild);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateGuildUIController.RefreshLevelDisplay);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateGuildUIController.OnCreateGuildClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateGuildUIController.OnCloseClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateGuildUIController.OnForwardLevelClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateGuildUIController.OnBackwardLevelClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateGuildUIController.OnBGClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateGuildUIController.OnLevelInputFiledEndEdit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateGuildUIController.OnGuildDeclaratioInputFiledEndEdit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateGuildUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateGuildUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateGuildUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateGuildUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateGuildUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateGuildUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateGuildUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateGuildUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateGuildUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateGuildUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateGuildUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateGuildUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateGuildUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache17);
		string name = "m_createGuildPanelAnimation";
		if (Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateGuildUIController.get_m_createGuildPanelAnimation);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache18;
		if (Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateGuildUIController.set_m_createGuildPanelAnimation);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache19, true);
		string name2 = "m_guildNameInputField";
		if (Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateGuildUIController.get_m_guildNameInputField);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache1A;
		if (Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateGuildUIController.set_m_guildNameInputField);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache1B, true);
		string name3 = "m_guildDeclarationInputField";
		if (Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateGuildUIController.get_m_guildDeclarationInputField);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache1C;
		if (Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateGuildUIController.set_m_guildDeclarationInputField);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache1D, true);
		string name4 = "m_levelInputField";
		if (Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateGuildUIController.get_m_levelInputField);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache1E;
		if (Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateGuildUIController.set_m_levelInputField);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache1F, true);
		string name5 = "m_forwardLevelButton";
		if (Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateGuildUIController.get_m_forwardLevelButton);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache20;
		if (Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateGuildUIController.set_m_forwardLevelButton);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache21, true);
		string name6 = "m_backwardLevelButton";
		if (Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateGuildUIController.get_m_backwardLevelButton);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache22;
		if (Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateGuildUIController.set_m_backwardLevelButton);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache23, true);
		string name7 = "m_requireItemIamge";
		if (Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateGuildUIController.get_m_requireItemIamge);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache24;
		if (Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateGuildUIController.set_m_requireItemIamge);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache25, true);
		string name8 = "m_approveAutoToggle";
		if (Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateGuildUIController.get_m_approveAutoToggle);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache26;
		if (Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateGuildUIController.set_m_approveAutoToggle);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache27, true);
		string name9 = "m_approveChairmanToggle";
		if (Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateGuildUIController.get_m_approveChairmanToggle);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache28;
		if (Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateGuildUIController.set_m_approveChairmanToggle);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache29, true);
		string name10 = "m_createButton";
		if (Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateGuildUIController.get_m_createButton);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache2A;
		if (Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateGuildUIController.set_m_createButton);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache2B, true);
		string name11 = "m_colseButton";
		if (Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateGuildUIController.get_m_colseButton);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache2C;
		if (Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateGuildUIController.set_m_colseButton);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache2D, true);
		string name12 = "m_bgButton";
		if (Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateGuildUIController.get_m_bgButton);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache2E;
		if (Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateGuildUIController.set_m_bgButton);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache2F, true);
		string name13 = "m_playerContext";
		if (Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateGuildUIController.get_m_playerContext);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache30;
		if (Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateGuildUIController.set_m_playerContext);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache31, true);
		string name14 = "m_configDataLoader";
		if (Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateGuildUIController.get_m_configDataLoader);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache32;
		if (Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateGuildUIController.set_m_configDataLoader);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache33, true);
		string name15 = "m_requireLevel";
		if (Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateGuildUIController.get_m_requireLevel);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache34;
		if (Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateGuildUIController.set_m_requireLevel);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache35, true);
		string name16 = "m_guildUITask";
		if (Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateGuildUIController.get_m_guildUITask);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache36;
		if (Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CreateGuildUIController.set_m_guildUITask);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_UI_CreateGuildUIController.<>f__mg$cache37, true);
		LuaObject.createTypeMetatable(l, null, typeof(CreateGuildUIController), typeof(UIControllerBase));
	}

	// Token: 0x040131CF RID: 78287
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040131D0 RID: 78288
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040131D1 RID: 78289
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040131D2 RID: 78290
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040131D3 RID: 78291
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040131D4 RID: 78292
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040131D5 RID: 78293
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040131D6 RID: 78294
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x040131D7 RID: 78295
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x040131D8 RID: 78296
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x040131D9 RID: 78297
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x040131DA RID: 78298
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x040131DB RID: 78299
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x040131DC RID: 78300
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x040131DD RID: 78301
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x040131DE RID: 78302
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x040131DF RID: 78303
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x040131E0 RID: 78304
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x040131E1 RID: 78305
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x040131E2 RID: 78306
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x040131E3 RID: 78307
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x040131E4 RID: 78308
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x040131E5 RID: 78309
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x040131E6 RID: 78310
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x040131E7 RID: 78311
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x040131E8 RID: 78312
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x040131E9 RID: 78313
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x040131EA RID: 78314
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x040131EB RID: 78315
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x040131EC RID: 78316
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x040131ED RID: 78317
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x040131EE RID: 78318
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x040131EF RID: 78319
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x040131F0 RID: 78320
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x040131F1 RID: 78321
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x040131F2 RID: 78322
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x040131F3 RID: 78323
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x040131F4 RID: 78324
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x040131F5 RID: 78325
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x040131F6 RID: 78326
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x040131F7 RID: 78327
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x040131F8 RID: 78328
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x040131F9 RID: 78329
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x040131FA RID: 78330
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x040131FB RID: 78331
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x040131FC RID: 78332
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x040131FD RID: 78333
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x040131FE RID: 78334
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x040131FF RID: 78335
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04013200 RID: 78336
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04013201 RID: 78337
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x04013202 RID: 78338
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x04013203 RID: 78339
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x04013204 RID: 78340
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x04013205 RID: 78341
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x04013206 RID: 78342
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;
}
