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

// Token: 0x020015C4 RID: 5572
[Preserve]
public class Lua_BlackJack_ProjectL_UI_UnchartedScoreButton : LuaObject
{
	// Token: 0x06021EBB RID: 138939 RVA: 0x00B8B928 File Offset: 0x00B89B28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetUnchartedScoreInfo(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreButton unchartedScoreButton = (UnchartedScoreButton)LuaObject.checkSelf(l);
			ConfigDataUnchartedScoreInfo unchartedScoreInfo;
			LuaObject.checkType<ConfigDataUnchartedScoreInfo>(l, 2, out unchartedScoreInfo);
			unchartedScoreButton.SetUnchartedScoreInfo(unchartedScoreInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021EBC RID: 138940 RVA: 0x00B8B980 File Offset: 0x00B89B80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetUnchartedScoreInfo(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreButton unchartedScoreButton = (UnchartedScoreButton)LuaObject.checkSelf(l);
			ConfigDataUnchartedScoreInfo unchartedScoreInfo = unchartedScoreButton.GetUnchartedScoreInfo();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, unchartedScoreInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021EBD RID: 138941 RVA: 0x00B8B9D4 File Offset: 0x00B89BD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreButton unchartedScoreButton = (UnchartedScoreButton)LuaObject.checkSelf(l);
			unchartedScoreButton.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021EBE RID: 138942 RVA: 0x00B8BA28 File Offset: 0x00B89C28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreButton unchartedScoreButton = (UnchartedScoreButton)LuaObject.checkSelf(l);
			unchartedScoreButton.m_luaExportHelper.OnButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021EBF RID: 138943 RVA: 0x00B8BA7C File Offset: 0x00B89C7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreButton unchartedScoreButton = (UnchartedScoreButton)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			unchartedScoreButton.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021EC0 RID: 138944 RVA: 0x00B8BAE8 File Offset: 0x00B89CE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreButton unchartedScoreButton = (UnchartedScoreButton)LuaObject.checkSelf(l);
			unchartedScoreButton.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021EC1 RID: 138945 RVA: 0x00B8BB3C File Offset: 0x00B89D3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreButton unchartedScoreButton = (UnchartedScoreButton)LuaObject.checkSelf(l);
			unchartedScoreButton.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021EC2 RID: 138946 RVA: 0x00B8BB90 File Offset: 0x00B89D90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreButton unchartedScoreButton = (UnchartedScoreButton)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = unchartedScoreButton.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x06021EC3 RID: 138947 RVA: 0x00B8BC38 File Offset: 0x00B89E38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreButton unchartedScoreButton = (UnchartedScoreButton)LuaObject.checkSelf(l);
			unchartedScoreButton.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021EC4 RID: 138948 RVA: 0x00B8BC8C File Offset: 0x00B89E8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreButton unchartedScoreButton = (UnchartedScoreButton)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			unchartedScoreButton.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021EC5 RID: 138949 RVA: 0x00B8BCF8 File Offset: 0x00B89EF8
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
				UnchartedScoreButton unchartedScoreButton = (UnchartedScoreButton)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				unchartedScoreButton.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				UnchartedScoreButton unchartedScoreButton2 = (UnchartedScoreButton)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				unchartedScoreButton2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x06021EC6 RID: 138950 RVA: 0x00B8BE08 File Offset: 0x00B8A008
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreButton unchartedScoreButton = (UnchartedScoreButton)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			unchartedScoreButton.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021EC7 RID: 138951 RVA: 0x00B8BE74 File Offset: 0x00B8A074
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreButton unchartedScoreButton = (UnchartedScoreButton)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			unchartedScoreButton.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021EC8 RID: 138952 RVA: 0x00B8BEE0 File Offset: 0x00B8A0E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreButton unchartedScoreButton = (UnchartedScoreButton)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			unchartedScoreButton.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021EC9 RID: 138953 RVA: 0x00B8BF4C File Offset: 0x00B8A14C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreButton unchartedScoreButton = (UnchartedScoreButton)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			unchartedScoreButton.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021ECA RID: 138954 RVA: 0x00B8BFB8 File Offset: 0x00B8A1B8
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
				UnchartedScoreButton unchartedScoreButton = (UnchartedScoreButton)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				unchartedScoreButton.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				UnchartedScoreButton unchartedScoreButton2 = (UnchartedScoreButton)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				unchartedScoreButton2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x06021ECB RID: 138955 RVA: 0x00B8C0C8 File Offset: 0x00B8A2C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreButton unchartedScoreButton = (UnchartedScoreButton)LuaObject.checkSelf(l);
			string s = unchartedScoreButton.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x06021ECC RID: 138956 RVA: 0x00B8C124 File Offset: 0x00B8A324
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnStartUnchartedScore(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreButton unchartedScoreButton = (UnchartedScoreButton)LuaObject.checkSelf(l);
			UnchartedScoreButton obj;
			LuaObject.checkType<UnchartedScoreButton>(l, 2, out obj);
			unchartedScoreButton.m_luaExportHelper.__callDele_EventOnStartUnchartedScore(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021ECD RID: 138957 RVA: 0x00B8C180 File Offset: 0x00B8A380
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnStartUnchartedScore(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreButton unchartedScoreButton = (UnchartedScoreButton)LuaObject.checkSelf(l);
			UnchartedScoreButton obj;
			LuaObject.checkType<UnchartedScoreButton>(l, 2, out obj);
			unchartedScoreButton.m_luaExportHelper.__clearDele_EventOnStartUnchartedScore(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021ECE RID: 138958 RVA: 0x00B8C1DC File Offset: 0x00B8A3DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_button(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreButton unchartedScoreButton = (UnchartedScoreButton)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, unchartedScoreButton.m_luaExportHelper.m_button);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021ECF RID: 138959 RVA: 0x00B8C234 File Offset: 0x00B8A434
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_button(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreButton unchartedScoreButton = (UnchartedScoreButton)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			unchartedScoreButton.m_luaExportHelper.m_button = button;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021ED0 RID: 138960 RVA: 0x00B8C290 File Offset: 0x00B8A490
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiStateController(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreButton unchartedScoreButton = (UnchartedScoreButton)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, unchartedScoreButton.m_luaExportHelper.m_uiStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021ED1 RID: 138961 RVA: 0x00B8C2E8 File Offset: 0x00B8A4E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiStateController(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreButton unchartedScoreButton = (UnchartedScoreButton)LuaObject.checkSelf(l);
			CommonUIStateController uiStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out uiStateController);
			unchartedScoreButton.m_luaExportHelper.m_uiStateController = uiStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021ED2 RID: 138962 RVA: 0x00B8C344 File Offset: 0x00B8A544
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_image(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreButton unchartedScoreButton = (UnchartedScoreButton)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, unchartedScoreButton.m_luaExportHelper.m_image);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021ED3 RID: 138963 RVA: 0x00B8C39C File Offset: 0x00B8A59C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_image(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreButton unchartedScoreButton = (UnchartedScoreButton)LuaObject.checkSelf(l);
			Image image;
			LuaObject.checkType<Image>(l, 2, out image);
			unchartedScoreButton.m_luaExportHelper.m_image = image;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021ED4 RID: 138964 RVA: 0x00B8C3F8 File Offset: 0x00B8A5F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_imageGrey(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreButton unchartedScoreButton = (UnchartedScoreButton)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, unchartedScoreButton.m_luaExportHelper.m_imageGrey);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021ED5 RID: 138965 RVA: 0x00B8C450 File Offset: 0x00B8A650
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_imageGrey(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreButton unchartedScoreButton = (UnchartedScoreButton)LuaObject.checkSelf(l);
			Image imageGrey;
			LuaObject.checkType<Image>(l, 2, out imageGrey);
			unchartedScoreButton.m_luaExportHelper.m_imageGrey = imageGrey;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021ED6 RID: 138966 RVA: 0x00B8C4AC File Offset: 0x00B8A6AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_timeText(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreButton unchartedScoreButton = (UnchartedScoreButton)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, unchartedScoreButton.m_luaExportHelper.m_timeText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021ED7 RID: 138967 RVA: 0x00B8C504 File Offset: 0x00B8A704
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_timeText(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreButton unchartedScoreButton = (UnchartedScoreButton)LuaObject.checkSelf(l);
			Text timeText;
			LuaObject.checkType<Text>(l, 2, out timeText);
			unchartedScoreButton.m_luaExportHelper.m_timeText = timeText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021ED8 RID: 138968 RVA: 0x00B8C560 File Offset: 0x00B8A760
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_timeGreyText(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreButton unchartedScoreButton = (UnchartedScoreButton)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, unchartedScoreButton.m_luaExportHelper.m_timeGreyText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021ED9 RID: 138969 RVA: 0x00B8C5B8 File Offset: 0x00B8A7B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_timeGreyText(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreButton unchartedScoreButton = (UnchartedScoreButton)LuaObject.checkSelf(l);
			Text timeGreyText;
			LuaObject.checkType<Text>(l, 2, out timeGreyText);
			unchartedScoreButton.m_luaExportHelper.m_timeGreyText = timeGreyText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021EDA RID: 138970 RVA: 0x00B8C614 File Offset: 0x00B8A814
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_numberText(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreButton unchartedScoreButton = (UnchartedScoreButton)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, unchartedScoreButton.m_luaExportHelper.m_numberText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021EDB RID: 138971 RVA: 0x00B8C66C File Offset: 0x00B8A86C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_numberText(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreButton unchartedScoreButton = (UnchartedScoreButton)LuaObject.checkSelf(l);
			Text numberText;
			LuaObject.checkType<Text>(l, 2, out numberText);
			unchartedScoreButton.m_luaExportHelper.m_numberText = numberText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021EDC RID: 138972 RVA: 0x00B8C6C8 File Offset: 0x00B8A8C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnStartUnchartedScore(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreButton unchartedScoreButton = (UnchartedScoreButton)LuaObject.checkSelf(l);
			Action<UnchartedScoreButton> value;
			int num = LuaObject.checkDelegate<Action<UnchartedScoreButton>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					unchartedScoreButton.EventOnStartUnchartedScore += value;
				}
				else if (num == 2)
				{
					unchartedScoreButton.EventOnStartUnchartedScore -= value;
				}
			}
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021EDD RID: 138973 RVA: 0x00B8C748 File Offset: 0x00B8A948
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_unchartedScoreInfo(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreButton unchartedScoreButton = (UnchartedScoreButton)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, unchartedScoreButton.m_luaExportHelper.m_unchartedScoreInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021EDE RID: 138974 RVA: 0x00B8C7A0 File Offset: 0x00B8A9A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_unchartedScoreInfo(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreButton unchartedScoreButton = (UnchartedScoreButton)LuaObject.checkSelf(l);
			ConfigDataUnchartedScoreInfo unchartedScoreInfo;
			LuaObject.checkType<ConfigDataUnchartedScoreInfo>(l, 2, out unchartedScoreInfo);
			unchartedScoreButton.m_luaExportHelper.m_unchartedScoreInfo = unchartedScoreInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021EDF RID: 138975 RVA: 0x00B8C7FC File Offset: 0x00B8A9FC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.UnchartedScoreButton");
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreButton.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreButton.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreButton.SetUnchartedScoreInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreButton.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreButton.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreButton.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreButton.GetUnchartedScoreInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreButton.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreButton.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreButton.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreButton.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreButton.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreButton.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreButton.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreButton.OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreButton.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreButton.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreButton.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreButton.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreButton.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreButton.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreButton.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreButton.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreButton.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreButton.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreButton.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreButton.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreButton.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreButton.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreButton.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreButton.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreButton.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreButton.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreButton.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreButton.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreButton.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreButton.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreButton.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreButton.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreButton.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreButton.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreButton.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreButton.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreButton.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreButton.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreButton.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreButton.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreButton.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreButton.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreButton.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreButton.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreButton.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreButton.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreButton.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreButton.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreButton.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreButton.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreButton.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreButton.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreButton.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreButton.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreButton.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreButton.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreButton.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreButton.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreButton.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreButton.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreButton.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreButton.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreButton.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreButton.__callDele_EventOnStartUnchartedScore);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreButton.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreButton.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreButton.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreButton.__clearDele_EventOnStartUnchartedScore);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreButton.<>f__mg$cache12);
		string name = "m_button";
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreButton.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreButton.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreButton.get_m_button);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_UnchartedScoreButton.<>f__mg$cache13;
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreButton.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreButton.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreButton.set_m_button);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_UnchartedScoreButton.<>f__mg$cache14, true);
		string name2 = "m_uiStateController";
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreButton.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreButton.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreButton.get_m_uiStateController);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_UnchartedScoreButton.<>f__mg$cache15;
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreButton.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreButton.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreButton.set_m_uiStateController);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_UnchartedScoreButton.<>f__mg$cache16, true);
		string name3 = "m_image";
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreButton.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreButton.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreButton.get_m_image);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_UnchartedScoreButton.<>f__mg$cache17;
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreButton.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreButton.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreButton.set_m_image);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_UnchartedScoreButton.<>f__mg$cache18, true);
		string name4 = "m_imageGrey";
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreButton.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreButton.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreButton.get_m_imageGrey);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_UnchartedScoreButton.<>f__mg$cache19;
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreButton.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreButton.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreButton.set_m_imageGrey);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_UnchartedScoreButton.<>f__mg$cache1A, true);
		string name5 = "m_timeText";
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreButton.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreButton.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreButton.get_m_timeText);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_UnchartedScoreButton.<>f__mg$cache1B;
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreButton.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreButton.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreButton.set_m_timeText);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_UnchartedScoreButton.<>f__mg$cache1C, true);
		string name6 = "m_timeGreyText";
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreButton.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreButton.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreButton.get_m_timeGreyText);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_UnchartedScoreButton.<>f__mg$cache1D;
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreButton.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreButton.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreButton.set_m_timeGreyText);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_UnchartedScoreButton.<>f__mg$cache1E, true);
		string name7 = "m_numberText";
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreButton.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreButton.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreButton.get_m_numberText);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_UnchartedScoreButton.<>f__mg$cache1F;
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreButton.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreButton.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreButton.set_m_numberText);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_UnchartedScoreButton.<>f__mg$cache20, true);
		string name8 = "EventOnStartUnchartedScore";
		LuaCSFunction get8 = null;
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreButton.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreButton.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreButton.set_EventOnStartUnchartedScore);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_UnchartedScoreButton.<>f__mg$cache21, true);
		string name9 = "m_unchartedScoreInfo";
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreButton.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreButton.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreButton.get_m_unchartedScoreInfo);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_UnchartedScoreButton.<>f__mg$cache22;
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreButton.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreButton.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreButton.set_m_unchartedScoreInfo);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_UnchartedScoreButton.<>f__mg$cache23, true);
		LuaObject.createTypeMetatable(l, null, typeof(UnchartedScoreButton), typeof(UIControllerBase));
	}

	// Token: 0x04017D15 RID: 97557
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04017D16 RID: 97558
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04017D17 RID: 97559
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04017D18 RID: 97560
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04017D19 RID: 97561
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04017D1A RID: 97562
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04017D1B RID: 97563
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04017D1C RID: 97564
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04017D1D RID: 97565
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04017D1E RID: 97566
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04017D1F RID: 97567
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04017D20 RID: 97568
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04017D21 RID: 97569
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04017D22 RID: 97570
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04017D23 RID: 97571
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04017D24 RID: 97572
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04017D25 RID: 97573
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04017D26 RID: 97574
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04017D27 RID: 97575
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04017D28 RID: 97576
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04017D29 RID: 97577
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04017D2A RID: 97578
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04017D2B RID: 97579
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04017D2C RID: 97580
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04017D2D RID: 97581
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04017D2E RID: 97582
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04017D2F RID: 97583
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04017D30 RID: 97584
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04017D31 RID: 97585
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04017D32 RID: 97586
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04017D33 RID: 97587
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04017D34 RID: 97588
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04017D35 RID: 97589
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04017D36 RID: 97590
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04017D37 RID: 97591
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04017D38 RID: 97592
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;
}
