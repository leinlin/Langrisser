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

// Token: 0x020014D6 RID: 5334
[Preserve]
public class Lua_BlackJack_ProjectL_UI_HeroPhantomButton : LuaObject
{
	// Token: 0x0601F60D RID: 128525 RVA: 0x00A47B18 File Offset: 0x00A45D18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetHeroPhantomInfo(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomButton heroPhantomButton = (HeroPhantomButton)LuaObject.checkSelf(l);
			ConfigDataHeroPhantomInfo heroPhantomInfo;
			LuaObject.checkType<ConfigDataHeroPhantomInfo>(l, 2, out heroPhantomInfo);
			heroPhantomButton.SetHeroPhantomInfo(heroPhantomInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F60E RID: 128526 RVA: 0x00A47B70 File Offset: 0x00A45D70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetHeroPhantomInfo(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomButton heroPhantomButton = (HeroPhantomButton)LuaObject.checkSelf(l);
			ConfigDataHeroPhantomInfo heroPhantomInfo = heroPhantomButton.GetHeroPhantomInfo();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroPhantomInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F60F RID: 128527 RVA: 0x00A47BC4 File Offset: 0x00A45DC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomButton heroPhantomButton = (HeroPhantomButton)LuaObject.checkSelf(l);
			heroPhantomButton.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F610 RID: 128528 RVA: 0x00A47C18 File Offset: 0x00A45E18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomButton heroPhantomButton = (HeroPhantomButton)LuaObject.checkSelf(l);
			heroPhantomButton.m_luaExportHelper.OnButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F611 RID: 128529 RVA: 0x00A47C6C File Offset: 0x00A45E6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomButton heroPhantomButton = (HeroPhantomButton)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			heroPhantomButton.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F612 RID: 128530 RVA: 0x00A47CD8 File Offset: 0x00A45ED8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomButton heroPhantomButton = (HeroPhantomButton)LuaObject.checkSelf(l);
			heroPhantomButton.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F613 RID: 128531 RVA: 0x00A47D2C File Offset: 0x00A45F2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomButton heroPhantomButton = (HeroPhantomButton)LuaObject.checkSelf(l);
			heroPhantomButton.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F614 RID: 128532 RVA: 0x00A47D80 File Offset: 0x00A45F80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomButton heroPhantomButton = (HeroPhantomButton)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = heroPhantomButton.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601F615 RID: 128533 RVA: 0x00A47E28 File Offset: 0x00A46028
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomButton heroPhantomButton = (HeroPhantomButton)LuaObject.checkSelf(l);
			heroPhantomButton.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F616 RID: 128534 RVA: 0x00A47E7C File Offset: 0x00A4607C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomButton heroPhantomButton = (HeroPhantomButton)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			heroPhantomButton.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F617 RID: 128535 RVA: 0x00A47EE8 File Offset: 0x00A460E8
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
				HeroPhantomButton heroPhantomButton = (HeroPhantomButton)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				heroPhantomButton.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				HeroPhantomButton heroPhantomButton2 = (HeroPhantomButton)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				heroPhantomButton2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601F618 RID: 128536 RVA: 0x00A47FF8 File Offset: 0x00A461F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomButton heroPhantomButton = (HeroPhantomButton)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroPhantomButton.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F619 RID: 128537 RVA: 0x00A48064 File Offset: 0x00A46264
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomButton heroPhantomButton = (HeroPhantomButton)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroPhantomButton.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F61A RID: 128538 RVA: 0x00A480D0 File Offset: 0x00A462D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomButton heroPhantomButton = (HeroPhantomButton)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroPhantomButton.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F61B RID: 128539 RVA: 0x00A4813C File Offset: 0x00A4633C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomButton heroPhantomButton = (HeroPhantomButton)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroPhantomButton.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F61C RID: 128540 RVA: 0x00A481A8 File Offset: 0x00A463A8
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
				HeroPhantomButton heroPhantomButton = (HeroPhantomButton)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				heroPhantomButton.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				HeroPhantomButton heroPhantomButton2 = (HeroPhantomButton)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				heroPhantomButton2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601F61D RID: 128541 RVA: 0x00A482B8 File Offset: 0x00A464B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomButton heroPhantomButton = (HeroPhantomButton)LuaObject.checkSelf(l);
			string s = heroPhantomButton.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601F61E RID: 128542 RVA: 0x00A48314 File Offset: 0x00A46514
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnStartHeroPhantom(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomButton heroPhantomButton = (HeroPhantomButton)LuaObject.checkSelf(l);
			HeroPhantomButton obj;
			LuaObject.checkType<HeroPhantomButton>(l, 2, out obj);
			heroPhantomButton.m_luaExportHelper.__callDele_EventOnStartHeroPhantom(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F61F RID: 128543 RVA: 0x00A48370 File Offset: 0x00A46570
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnStartHeroPhantom(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomButton heroPhantomButton = (HeroPhantomButton)LuaObject.checkSelf(l);
			HeroPhantomButton obj;
			LuaObject.checkType<HeroPhantomButton>(l, 2, out obj);
			heroPhantomButton.m_luaExportHelper.__clearDele_EventOnStartHeroPhantom(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F620 RID: 128544 RVA: 0x00A483CC File Offset: 0x00A465CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_button(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomButton heroPhantomButton = (HeroPhantomButton)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroPhantomButton.m_luaExportHelper.m_button);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F621 RID: 128545 RVA: 0x00A48424 File Offset: 0x00A46624
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_button(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomButton heroPhantomButton = (HeroPhantomButton)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			heroPhantomButton.m_luaExportHelper.m_button = button;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F622 RID: 128546 RVA: 0x00A48480 File Offset: 0x00A46680
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiStateController(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomButton heroPhantomButton = (HeroPhantomButton)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroPhantomButton.m_luaExportHelper.m_uiStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F623 RID: 128547 RVA: 0x00A484D8 File Offset: 0x00A466D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiStateController(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomButton heroPhantomButton = (HeroPhantomButton)LuaObject.checkSelf(l);
			CommonUIStateController uiStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out uiStateController);
			heroPhantomButton.m_luaExportHelper.m_uiStateController = uiStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F624 RID: 128548 RVA: 0x00A48534 File Offset: 0x00A46734
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_image(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomButton heroPhantomButton = (HeroPhantomButton)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroPhantomButton.m_luaExportHelper.m_image);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F625 RID: 128549 RVA: 0x00A4858C File Offset: 0x00A4678C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_image(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomButton heroPhantomButton = (HeroPhantomButton)LuaObject.checkSelf(l);
			Image image;
			LuaObject.checkType<Image>(l, 2, out image);
			heroPhantomButton.m_luaExportHelper.m_image = image;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F626 RID: 128550 RVA: 0x00A485E8 File Offset: 0x00A467E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_timeText(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomButton heroPhantomButton = (HeroPhantomButton)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroPhantomButton.m_luaExportHelper.m_timeText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F627 RID: 128551 RVA: 0x00A48640 File Offset: 0x00A46840
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_timeText(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomButton heroPhantomButton = (HeroPhantomButton)LuaObject.checkSelf(l);
			Text timeText;
			LuaObject.checkType<Text>(l, 2, out timeText);
			heroPhantomButton.m_luaExportHelper.m_timeText = timeText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F628 RID: 128552 RVA: 0x00A4869C File Offset: 0x00A4689C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_achievementCountText(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomButton heroPhantomButton = (HeroPhantomButton)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroPhantomButton.m_luaExportHelper.m_achievementCountText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F629 RID: 128553 RVA: 0x00A486F4 File Offset: 0x00A468F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_achievementCountText(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomButton heroPhantomButton = (HeroPhantomButton)LuaObject.checkSelf(l);
			Text achievementCountText;
			LuaObject.checkType<Text>(l, 2, out achievementCountText);
			heroPhantomButton.m_luaExportHelper.m_achievementCountText = achievementCountText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F62A RID: 128554 RVA: 0x00A48750 File Offset: 0x00A46950
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnStartHeroPhantom(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomButton heroPhantomButton = (HeroPhantomButton)LuaObject.checkSelf(l);
			Action<HeroPhantomButton> value;
			int num = LuaObject.checkDelegate<Action<HeroPhantomButton>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					heroPhantomButton.EventOnStartHeroPhantom += value;
				}
				else if (num == 2)
				{
					heroPhantomButton.EventOnStartHeroPhantom -= value;
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

	// Token: 0x0601F62B RID: 128555 RVA: 0x00A487D0 File Offset: 0x00A469D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroPhantomInfo(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomButton heroPhantomButton = (HeroPhantomButton)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroPhantomButton.m_luaExportHelper.m_heroPhantomInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F62C RID: 128556 RVA: 0x00A48828 File Offset: 0x00A46A28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroPhantomInfo(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomButton heroPhantomButton = (HeroPhantomButton)LuaObject.checkSelf(l);
			ConfigDataHeroPhantomInfo heroPhantomInfo;
			LuaObject.checkType<ConfigDataHeroPhantomInfo>(l, 2, out heroPhantomInfo);
			heroPhantomButton.m_luaExportHelper.m_heroPhantomInfo = heroPhantomInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F62D RID: 128557 RVA: 0x00A48884 File Offset: 0x00A46A84
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.HeroPhantomButton");
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomButton.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomButton.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomButton.SetHeroPhantomInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroPhantomButton.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomButton.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomButton.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomButton.GetHeroPhantomInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroPhantomButton.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomButton.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomButton.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomButton.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroPhantomButton.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomButton.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomButton.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomButton.OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroPhantomButton.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomButton.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomButton.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomButton.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroPhantomButton.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomButton.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomButton.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomButton.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroPhantomButton.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomButton.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomButton.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomButton.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroPhantomButton.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomButton.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomButton.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomButton.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroPhantomButton.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomButton.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomButton.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomButton.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroPhantomButton.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomButton.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomButton.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomButton.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroPhantomButton.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomButton.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomButton.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomButton.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroPhantomButton.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomButton.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomButton.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomButton.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroPhantomButton.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomButton.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomButton.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomButton.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroPhantomButton.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomButton.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomButton.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomButton.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroPhantomButton.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomButton.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomButton.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomButton.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroPhantomButton.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomButton.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomButton.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomButton.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroPhantomButton.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomButton.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomButton.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomButton.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroPhantomButton.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomButton.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomButton.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomButton.__callDele_EventOnStartHeroPhantom);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroPhantomButton.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomButton.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomButton.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomButton.__clearDele_EventOnStartHeroPhantom);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroPhantomButton.<>f__mg$cache12);
		string name = "m_button";
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomButton.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomButton.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomButton.get_m_button);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_HeroPhantomButton.<>f__mg$cache13;
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomButton.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomButton.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomButton.set_m_button);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_HeroPhantomButton.<>f__mg$cache14, true);
		string name2 = "m_uiStateController";
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomButton.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomButton.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomButton.get_m_uiStateController);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_HeroPhantomButton.<>f__mg$cache15;
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomButton.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomButton.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomButton.set_m_uiStateController);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_HeroPhantomButton.<>f__mg$cache16, true);
		string name3 = "m_image";
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomButton.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomButton.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomButton.get_m_image);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_HeroPhantomButton.<>f__mg$cache17;
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomButton.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomButton.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomButton.set_m_image);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_HeroPhantomButton.<>f__mg$cache18, true);
		string name4 = "m_timeText";
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomButton.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomButton.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomButton.get_m_timeText);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_HeroPhantomButton.<>f__mg$cache19;
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomButton.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomButton.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomButton.set_m_timeText);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_HeroPhantomButton.<>f__mg$cache1A, true);
		string name5 = "m_achievementCountText";
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomButton.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomButton.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomButton.get_m_achievementCountText);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_HeroPhantomButton.<>f__mg$cache1B;
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomButton.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomButton.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomButton.set_m_achievementCountText);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_HeroPhantomButton.<>f__mg$cache1C, true);
		string name6 = "EventOnStartHeroPhantom";
		LuaCSFunction get6 = null;
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomButton.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomButton.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomButton.set_EventOnStartHeroPhantom);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_HeroPhantomButton.<>f__mg$cache1D, true);
		string name7 = "m_heroPhantomInfo";
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomButton.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomButton.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomButton.get_m_heroPhantomInfo);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_HeroPhantomButton.<>f__mg$cache1E;
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomButton.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomButton.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomButton.set_m_heroPhantomInfo);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_HeroPhantomButton.<>f__mg$cache1F, true);
		LuaObject.createTypeMetatable(l, null, typeof(HeroPhantomButton), typeof(UIControllerBase));
	}

	// Token: 0x04015643 RID: 87619
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04015644 RID: 87620
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04015645 RID: 87621
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04015646 RID: 87622
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04015647 RID: 87623
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04015648 RID: 87624
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04015649 RID: 87625
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0401564A RID: 87626
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0401564B RID: 87627
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0401564C RID: 87628
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0401564D RID: 87629
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0401564E RID: 87630
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0401564F RID: 87631
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04015650 RID: 87632
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04015651 RID: 87633
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04015652 RID: 87634
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04015653 RID: 87635
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04015654 RID: 87636
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04015655 RID: 87637
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04015656 RID: 87638
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04015657 RID: 87639
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04015658 RID: 87640
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04015659 RID: 87641
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0401565A RID: 87642
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0401565B RID: 87643
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0401565C RID: 87644
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0401565D RID: 87645
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0401565E RID: 87646
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0401565F RID: 87647
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04015660 RID: 87648
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04015661 RID: 87649
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04015662 RID: 87650
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;
}
