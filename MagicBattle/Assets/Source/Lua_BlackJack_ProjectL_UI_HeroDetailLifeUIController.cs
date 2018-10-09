using System;
using System.Collections.Generic;
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

// Token: 0x020014B5 RID: 5301
[Preserve]
public class Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController : LuaObject
{
	// Token: 0x0601EE7B RID: 126587 RVA: 0x00A0AE38 File Offset: 0x00A09038
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateViewInLife(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailLifeUIController heroDetailLifeUIController = (HeroDetailLifeUIController)LuaObject.checkSelf(l);
			Hero hero;
			LuaObject.checkType<Hero>(l, 2, out hero);
			heroDetailLifeUIController.UpdateViewInLife(hero);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE7C RID: 126588 RVA: 0x00A0AE90 File Offset: 0x00A09090
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetCommonUIState(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailLifeUIController heroDetailLifeUIController = (HeroDetailLifeUIController)LuaObject.checkSelf(l);
			string commonUIState;
			LuaObject.checkType(l, 2, out commonUIState);
			heroDetailLifeUIController.SetCommonUIState(commonUIState);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE7D RID: 126589 RVA: 0x00A0AEE8 File Offset: 0x00A090E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailLifeUIController heroDetailLifeUIController = (HeroDetailLifeUIController)LuaObject.checkSelf(l);
			heroDetailLifeUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE7E RID: 126590 RVA: 0x00A0AF3C File Offset: 0x00A0913C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnDisable(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailLifeUIController heroDetailLifeUIController = (HeroDetailLifeUIController)LuaObject.checkSelf(l);
			heroDetailLifeUIController.m_luaExportHelper.OnDisable();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE7F RID: 126591 RVA: 0x00A0AF90 File Offset: 0x00A09190
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateHeroLifeList(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailLifeUIController heroDetailLifeUIController = (HeroDetailLifeUIController)LuaObject.checkSelf(l);
			heroDetailLifeUIController.m_luaExportHelper.UpdateHeroLifeList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE80 RID: 126592 RVA: 0x00A0AFE4 File Offset: 0x00A091E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateHeroVoiceList(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailLifeUIController heroDetailLifeUIController = (HeroDetailLifeUIController)LuaObject.checkSelf(l);
			heroDetailLifeUIController.m_luaExportHelper.UpdateHeroVoiceList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE81 RID: 126593 RVA: 0x00A0B038 File Offset: 0x00A09238
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateToggleNewTag(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailLifeUIController heroDetailLifeUIController = (HeroDetailLifeUIController)LuaObject.checkSelf(l);
			heroDetailLifeUIController.m_luaExportHelper.UpdateToggleNewTag();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE82 RID: 126594 RVA: 0x00A0B08C File Offset: 0x00A0928C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnPeofermanceVoiceButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailLifeUIController heroDetailLifeUIController = (HeroDetailLifeUIController)LuaObject.checkSelf(l);
			FettersInformationVoiceItemUIController ctrl;
			LuaObject.checkType<FettersInformationVoiceItemUIController>(l, 2, out ctrl);
			heroDetailLifeUIController.m_luaExportHelper.OnPeofermanceVoiceButtonClick(ctrl);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE83 RID: 126595 RVA: 0x00A0B0E8 File Offset: 0x00A092E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnToggleLifeValueChange(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailLifeUIController heroDetailLifeUIController = (HeroDetailLifeUIController)LuaObject.checkSelf(l);
			bool isOn;
			LuaObject.checkType(l, 2, out isOn);
			heroDetailLifeUIController.m_luaExportHelper.OnToggleLifeValueChange(isOn);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE84 RID: 126596 RVA: 0x00A0B144 File Offset: 0x00A09344
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnToggleVoiceValueChange(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailLifeUIController heroDetailLifeUIController = (HeroDetailLifeUIController)LuaObject.checkSelf(l);
			bool isOn;
			LuaObject.checkType(l, 2, out isOn);
			heroDetailLifeUIController.m_luaExportHelper.OnToggleVoiceValueChange(isOn);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE85 RID: 126597 RVA: 0x00A0B1A0 File Offset: 0x00A093A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ResetScrollViewPosition(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailLifeUIController heroDetailLifeUIController = (HeroDetailLifeUIController)LuaObject.checkSelf(l);
			heroDetailLifeUIController.m_luaExportHelper.ResetScrollViewPosition();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE86 RID: 126598 RVA: 0x00A0B1F4 File Offset: 0x00A093F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailLifeUIController heroDetailLifeUIController = (HeroDetailLifeUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			heroDetailLifeUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE87 RID: 126599 RVA: 0x00A0B260 File Offset: 0x00A09460
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailLifeUIController heroDetailLifeUIController = (HeroDetailLifeUIController)LuaObject.checkSelf(l);
			heroDetailLifeUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE88 RID: 126600 RVA: 0x00A0B2B4 File Offset: 0x00A094B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailLifeUIController heroDetailLifeUIController = (HeroDetailLifeUIController)LuaObject.checkSelf(l);
			heroDetailLifeUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE89 RID: 126601 RVA: 0x00A0B308 File Offset: 0x00A09508
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailLifeUIController heroDetailLifeUIController = (HeroDetailLifeUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = heroDetailLifeUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601EE8A RID: 126602 RVA: 0x00A0B3B0 File Offset: 0x00A095B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailLifeUIController heroDetailLifeUIController = (HeroDetailLifeUIController)LuaObject.checkSelf(l);
			heroDetailLifeUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE8B RID: 126603 RVA: 0x00A0B404 File Offset: 0x00A09604
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailLifeUIController heroDetailLifeUIController = (HeroDetailLifeUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			heroDetailLifeUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE8C RID: 126604 RVA: 0x00A0B470 File Offset: 0x00A09670
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
				HeroDetailLifeUIController heroDetailLifeUIController = (HeroDetailLifeUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				heroDetailLifeUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				HeroDetailLifeUIController heroDetailLifeUIController2 = (HeroDetailLifeUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				heroDetailLifeUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601EE8D RID: 126605 RVA: 0x00A0B580 File Offset: 0x00A09780
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailLifeUIController heroDetailLifeUIController = (HeroDetailLifeUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroDetailLifeUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE8E RID: 126606 RVA: 0x00A0B5EC File Offset: 0x00A097EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailLifeUIController heroDetailLifeUIController = (HeroDetailLifeUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroDetailLifeUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE8F RID: 126607 RVA: 0x00A0B658 File Offset: 0x00A09858
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailLifeUIController heroDetailLifeUIController = (HeroDetailLifeUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroDetailLifeUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE90 RID: 126608 RVA: 0x00A0B6C4 File Offset: 0x00A098C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailLifeUIController heroDetailLifeUIController = (HeroDetailLifeUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroDetailLifeUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE91 RID: 126609 RVA: 0x00A0B730 File Offset: 0x00A09930
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
				HeroDetailLifeUIController heroDetailLifeUIController = (HeroDetailLifeUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				heroDetailLifeUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				HeroDetailLifeUIController heroDetailLifeUIController2 = (HeroDetailLifeUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				heroDetailLifeUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601EE92 RID: 126610 RVA: 0x00A0B840 File Offset: 0x00A09A40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailLifeUIController heroDetailLifeUIController = (HeroDetailLifeUIController)LuaObject.checkSelf(l);
			string s = heroDetailLifeUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601EE93 RID: 126611 RVA: 0x00A0B89C File Offset: 0x00A09A9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnVoiceItemClick(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailLifeUIController heroDetailLifeUIController = (HeroDetailLifeUIController)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			heroDetailLifeUIController.m_luaExportHelper.__callDele_EventOnVoiceItemClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE94 RID: 126612 RVA: 0x00A0B8F8 File Offset: 0x00A09AF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnVoiceItemClick(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailLifeUIController heroDetailLifeUIController = (HeroDetailLifeUIController)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			heroDetailLifeUIController.m_luaExportHelper.__clearDele_EventOnVoiceItemClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE95 RID: 126613 RVA: 0x00A0B954 File Offset: 0x00A09B54
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_marginTransform(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailLifeUIController heroDetailLifeUIController = (HeroDetailLifeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailLifeUIController.m_luaExportHelper.m_marginTransform);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE96 RID: 126614 RVA: 0x00A0B9AC File Offset: 0x00A09BAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_marginTransform(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailLifeUIController heroDetailLifeUIController = (HeroDetailLifeUIController)LuaObject.checkSelf(l);
			RectTransform marginTransform;
			LuaObject.checkType<RectTransform>(l, 2, out marginTransform);
			heroDetailLifeUIController.m_luaExportHelper.m_marginTransform = marginTransform;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE97 RID: 126615 RVA: 0x00A0BA08 File Offset: 0x00A09C08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_toggleLife(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailLifeUIController heroDetailLifeUIController = (HeroDetailLifeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailLifeUIController.m_luaExportHelper.m_toggleLife);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE98 RID: 126616 RVA: 0x00A0BA60 File Offset: 0x00A09C60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_toggleLife(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailLifeUIController heroDetailLifeUIController = (HeroDetailLifeUIController)LuaObject.checkSelf(l);
			ToggleEx toggleLife;
			LuaObject.checkType<ToggleEx>(l, 2, out toggleLife);
			heroDetailLifeUIController.m_luaExportHelper.m_toggleLife = toggleLife;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE99 RID: 126617 RVA: 0x00A0BABC File Offset: 0x00A09CBC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_toggleVoice(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailLifeUIController heroDetailLifeUIController = (HeroDetailLifeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailLifeUIController.m_luaExportHelper.m_toggleVoice);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE9A RID: 126618 RVA: 0x00A0BB14 File Offset: 0x00A09D14
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_toggleVoice(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailLifeUIController heroDetailLifeUIController = (HeroDetailLifeUIController)LuaObject.checkSelf(l);
			ToggleEx toggleVoice;
			LuaObject.checkType<ToggleEx>(l, 2, out toggleVoice);
			heroDetailLifeUIController.m_luaExportHelper.m_toggleVoice = toggleVoice;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE9B RID: 126619 RVA: 0x00A0BB70 File Offset: 0x00A09D70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_toggleLifeRedPoint(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailLifeUIController heroDetailLifeUIController = (HeroDetailLifeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailLifeUIController.m_luaExportHelper.m_toggleLifeRedPoint);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE9C RID: 126620 RVA: 0x00A0BBC8 File Offset: 0x00A09DC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_toggleLifeRedPoint(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailLifeUIController heroDetailLifeUIController = (HeroDetailLifeUIController)LuaObject.checkSelf(l);
			GameObject toggleLifeRedPoint;
			LuaObject.checkType<GameObject>(l, 2, out toggleLifeRedPoint);
			heroDetailLifeUIController.m_luaExportHelper.m_toggleLifeRedPoint = toggleLifeRedPoint;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE9D RID: 126621 RVA: 0x00A0BC24 File Offset: 0x00A09E24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_toggleVoiceRedPoint(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailLifeUIController heroDetailLifeUIController = (HeroDetailLifeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailLifeUIController.m_luaExportHelper.m_toggleVoiceRedPoint);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE9E RID: 126622 RVA: 0x00A0BC7C File Offset: 0x00A09E7C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_toggleVoiceRedPoint(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailLifeUIController heroDetailLifeUIController = (HeroDetailLifeUIController)LuaObject.checkSelf(l);
			GameObject toggleVoiceRedPoint;
			LuaObject.checkType<GameObject>(l, 2, out toggleVoiceRedPoint);
			heroDetailLifeUIController.m_luaExportHelper.m_toggleVoiceRedPoint = toggleVoiceRedPoint;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE9F RID: 126623 RVA: 0x00A0BCD8 File Offset: 0x00A09ED8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_lifeScrollRect(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailLifeUIController heroDetailLifeUIController = (HeroDetailLifeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailLifeUIController.m_luaExportHelper.m_lifeScrollRect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EEA0 RID: 126624 RVA: 0x00A0BD30 File Offset: 0x00A09F30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_lifeScrollRect(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailLifeUIController heroDetailLifeUIController = (HeroDetailLifeUIController)LuaObject.checkSelf(l);
			ScrollRect lifeScrollRect;
			LuaObject.checkType<ScrollRect>(l, 2, out lifeScrollRect);
			heroDetailLifeUIController.m_luaExportHelper.m_lifeScrollRect = lifeScrollRect;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EEA1 RID: 126625 RVA: 0x00A0BD8C File Offset: 0x00A09F8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_voiceScrollRect(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailLifeUIController heroDetailLifeUIController = (HeroDetailLifeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailLifeUIController.m_luaExportHelper.m_voiceScrollRect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EEA2 RID: 126626 RVA: 0x00A0BDE4 File Offset: 0x00A09FE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_voiceScrollRect(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailLifeUIController heroDetailLifeUIController = (HeroDetailLifeUIController)LuaObject.checkSelf(l);
			ScrollRect voiceScrollRect;
			LuaObject.checkType<ScrollRect>(l, 2, out voiceScrollRect);
			heroDetailLifeUIController.m_luaExportHelper.m_voiceScrollRect = voiceScrollRect;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EEA3 RID: 126627 RVA: 0x00A0BE40 File Offset: 0x00A0A040
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_lifeContent(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailLifeUIController heroDetailLifeUIController = (HeroDetailLifeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailLifeUIController.m_luaExportHelper.m_lifeContent);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EEA4 RID: 126628 RVA: 0x00A0BE98 File Offset: 0x00A0A098
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_lifeContent(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailLifeUIController heroDetailLifeUIController = (HeroDetailLifeUIController)LuaObject.checkSelf(l);
			GameObject lifeContent;
			LuaObject.checkType<GameObject>(l, 2, out lifeContent);
			heroDetailLifeUIController.m_luaExportHelper.m_lifeContent = lifeContent;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EEA5 RID: 126629 RVA: 0x00A0BEF4 File Offset: 0x00A0A0F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_voiceContent(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailLifeUIController heroDetailLifeUIController = (HeroDetailLifeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailLifeUIController.m_luaExportHelper.m_voiceContent);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EEA6 RID: 126630 RVA: 0x00A0BF4C File Offset: 0x00A0A14C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_voiceContent(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailLifeUIController heroDetailLifeUIController = (HeroDetailLifeUIController)LuaObject.checkSelf(l);
			GameObject voiceContent;
			LuaObject.checkType<GameObject>(l, 2, out voiceContent);
			heroDetailLifeUIController.m_luaExportHelper.m_voiceContent = voiceContent;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EEA7 RID: 126631 RVA: 0x00A0BFA8 File Offset: 0x00A0A1A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_voiceCVNameText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailLifeUIController heroDetailLifeUIController = (HeroDetailLifeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailLifeUIController.m_luaExportHelper.m_voiceCVNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EEA8 RID: 126632 RVA: 0x00A0C000 File Offset: 0x00A0A200
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_voiceCVNameText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailLifeUIController heroDetailLifeUIController = (HeroDetailLifeUIController)LuaObject.checkSelf(l);
			Text voiceCVNameText;
			LuaObject.checkType<Text>(l, 2, out voiceCVNameText);
			heroDetailLifeUIController.m_luaExportHelper.m_voiceCVNameText = voiceCVNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EEA9 RID: 126633 RVA: 0x00A0C05C File Offset: 0x00A0A25C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnVoiceItemClick(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailLifeUIController heroDetailLifeUIController = (HeroDetailLifeUIController)LuaObject.checkSelf(l);
			Action<int> value;
			int num = LuaObject.checkDelegate<Action<int>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					heroDetailLifeUIController.EventOnVoiceItemClick += value;
				}
				else if (num == 2)
				{
					heroDetailLifeUIController.EventOnVoiceItemClick -= value;
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

	// Token: 0x0601EEAA RID: 126634 RVA: 0x00A0C0DC File Offset: 0x00A0A2DC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_hero(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailLifeUIController heroDetailLifeUIController = (HeroDetailLifeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailLifeUIController.m_luaExportHelper.m_hero);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EEAB RID: 126635 RVA: 0x00A0C134 File Offset: 0x00A0A334
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_hero(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailLifeUIController heroDetailLifeUIController = (HeroDetailLifeUIController)LuaObject.checkSelf(l);
			Hero hero;
			LuaObject.checkType<Hero>(l, 2, out hero);
			heroDetailLifeUIController.m_luaExportHelper.m_hero = hero;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EEAC RID: 126636 RVA: 0x00A0C190 File Offset: 0x00A0A390
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_heroInformationInfo(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailLifeUIController heroDetailLifeUIController = (HeroDetailLifeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailLifeUIController.m_luaExportHelper.m_heroInformationInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EEAD RID: 126637 RVA: 0x00A0C1E8 File Offset: 0x00A0A3E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroInformationInfo(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailLifeUIController heroDetailLifeUIController = (HeroDetailLifeUIController)LuaObject.checkSelf(l);
			ConfigDataHeroInformationInfo heroInformationInfo;
			LuaObject.checkType<ConfigDataHeroInformationInfo>(l, 2, out heroInformationInfo);
			heroDetailLifeUIController.m_luaExportHelper.m_heroInformationInfo = heroInformationInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EEAE RID: 126638 RVA: 0x00A0C244 File Offset: 0x00A0A444
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_biographyCtrlList(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailLifeUIController heroDetailLifeUIController = (HeroDetailLifeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailLifeUIController.m_luaExportHelper.biographyCtrlList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EEAF RID: 126639 RVA: 0x00A0C29C File Offset: 0x00A0A49C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_biographyCtrlList(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailLifeUIController heroDetailLifeUIController = (HeroDetailLifeUIController)LuaObject.checkSelf(l);
			List<FettersInformationLifeItemUIController> biographyCtrlList;
			LuaObject.checkType<List<FettersInformationLifeItemUIController>>(l, 2, out biographyCtrlList);
			heroDetailLifeUIController.m_luaExportHelper.biographyCtrlList = biographyCtrlList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EEB0 RID: 126640 RVA: 0x00A0C2F8 File Offset: 0x00A0A4F8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_voiceCtrlList(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailLifeUIController heroDetailLifeUIController = (HeroDetailLifeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailLifeUIController.m_luaExportHelper.voiceCtrlList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EEB1 RID: 126641 RVA: 0x00A0C350 File Offset: 0x00A0A550
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_voiceCtrlList(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailLifeUIController heroDetailLifeUIController = (HeroDetailLifeUIController)LuaObject.checkSelf(l);
			List<FettersInformationVoiceItemUIController> voiceCtrlList;
			LuaObject.checkType<List<FettersInformationVoiceItemUIController>>(l, 2, out voiceCtrlList);
			heroDetailLifeUIController.m_luaExportHelper.voiceCtrlList = voiceCtrlList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EEB2 RID: 126642 RVA: 0x00A0C3AC File Offset: 0x00A0A5AC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_isInVoiceTab(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailLifeUIController heroDetailLifeUIController = (HeroDetailLifeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailLifeUIController.m_luaExportHelper.isInVoiceTab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EEB3 RID: 126643 RVA: 0x00A0C404 File Offset: 0x00A0A604
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_isInVoiceTab(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailLifeUIController heroDetailLifeUIController = (HeroDetailLifeUIController)LuaObject.checkSelf(l);
			bool isInVoiceTab;
			LuaObject.checkType(l, 2, out isInVoiceTab);
			heroDetailLifeUIController.m_luaExportHelper.isInVoiceTab = isInVoiceTab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EEB4 RID: 126644 RVA: 0x00A0C460 File Offset: 0x00A0A660
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailLifeUIController heroDetailLifeUIController = (HeroDetailLifeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailLifeUIController.m_luaExportHelper.m_configDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EEB5 RID: 126645 RVA: 0x00A0C4B8 File Offset: 0x00A0A6B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailLifeUIController heroDetailLifeUIController = (HeroDetailLifeUIController)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			heroDetailLifeUIController.m_luaExportHelper.m_configDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EEB6 RID: 126646 RVA: 0x00A0C514 File Offset: 0x00A0A714
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.HeroDetailLifeUIController");
		if (Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.UpdateViewInLife);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.SetCommonUIState);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.OnDisable);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.UpdateHeroLifeList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.UpdateHeroVoiceList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.UpdateToggleNewTag);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.OnPeofermanceVoiceButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.OnToggleLifeValueChange);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.OnToggleVoiceValueChange);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.ResetScrollViewPosition);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.__callDele_EventOnVoiceItemClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.__clearDele_EventOnVoiceItemClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache19);
		string name = "m_marginTransform";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.get_m_marginTransform);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache1A;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.set_m_marginTransform);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache1B, true);
		string name2 = "m_toggleLife";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.get_m_toggleLife);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache1C;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.set_m_toggleLife);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache1D, true);
		string name3 = "m_toggleVoice";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.get_m_toggleVoice);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache1E;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.set_m_toggleVoice);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache1F, true);
		string name4 = "m_toggleLifeRedPoint";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.get_m_toggleLifeRedPoint);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache20;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.set_m_toggleLifeRedPoint);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache21, true);
		string name5 = "m_toggleVoiceRedPoint";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.get_m_toggleVoiceRedPoint);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache22;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.set_m_toggleVoiceRedPoint);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache23, true);
		string name6 = "m_lifeScrollRect";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.get_m_lifeScrollRect);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache24;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.set_m_lifeScrollRect);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache25, true);
		string name7 = "m_voiceScrollRect";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.get_m_voiceScrollRect);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache26;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.set_m_voiceScrollRect);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache27, true);
		string name8 = "m_lifeContent";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.get_m_lifeContent);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache28;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.set_m_lifeContent);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache29, true);
		string name9 = "m_voiceContent";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.get_m_voiceContent);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache2A;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.set_m_voiceContent);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache2B, true);
		string name10 = "m_voiceCVNameText";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.get_m_voiceCVNameText);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache2C;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.set_m_voiceCVNameText);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache2D, true);
		string name11 = "EventOnVoiceItemClick";
		LuaCSFunction get11 = null;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.set_EventOnVoiceItemClick);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache2E, true);
		string name12 = "m_hero";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.get_m_hero);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache2F;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.set_m_hero);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache30, true);
		string name13 = "m_heroInformationInfo";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.get_m_heroInformationInfo);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache31;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.set_m_heroInformationInfo);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache32, true);
		string name14 = "biographyCtrlList";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.get_biographyCtrlList);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache33;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.set_biographyCtrlList);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache34, true);
		string name15 = "voiceCtrlList";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.get_voiceCtrlList);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache35;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.set_voiceCtrlList);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache36, true);
		string name16 = "isInVoiceTab";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.get_isInVoiceTab);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache37;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.set_isInVoiceTab);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache38, true);
		string name17 = "m_configDataLoader";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.get_m_configDataLoader);
		}
		LuaCSFunction get17 = Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache39;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.set_m_configDataLoader);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.<>f__mg$cache3A, true);
		LuaObject.createTypeMetatable(l, null, typeof(HeroDetailLifeUIController), typeof(UIControllerBase));
	}

	// Token: 0x04014EF3 RID: 85747
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04014EF4 RID: 85748
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04014EF5 RID: 85749
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04014EF6 RID: 85750
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04014EF7 RID: 85751
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04014EF8 RID: 85752
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04014EF9 RID: 85753
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04014EFA RID: 85754
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04014EFB RID: 85755
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04014EFC RID: 85756
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04014EFD RID: 85757
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04014EFE RID: 85758
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04014EFF RID: 85759
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04014F00 RID: 85760
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04014F01 RID: 85761
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04014F02 RID: 85762
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04014F03 RID: 85763
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04014F04 RID: 85764
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04014F05 RID: 85765
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04014F06 RID: 85766
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04014F07 RID: 85767
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04014F08 RID: 85768
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04014F09 RID: 85769
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04014F0A RID: 85770
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04014F0B RID: 85771
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04014F0C RID: 85772
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04014F0D RID: 85773
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04014F0E RID: 85774
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04014F0F RID: 85775
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04014F10 RID: 85776
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04014F11 RID: 85777
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04014F12 RID: 85778
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04014F13 RID: 85779
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04014F14 RID: 85780
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04014F15 RID: 85781
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04014F16 RID: 85782
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04014F17 RID: 85783
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04014F18 RID: 85784
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04014F19 RID: 85785
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04014F1A RID: 85786
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04014F1B RID: 85787
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04014F1C RID: 85788
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04014F1D RID: 85789
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04014F1E RID: 85790
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04014F1F RID: 85791
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04014F20 RID: 85792
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04014F21 RID: 85793
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04014F22 RID: 85794
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04014F23 RID: 85795
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04014F24 RID: 85796
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04014F25 RID: 85797
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x04014F26 RID: 85798
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x04014F27 RID: 85799
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x04014F28 RID: 85800
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x04014F29 RID: 85801
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x04014F2A RID: 85802
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x04014F2B RID: 85803
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x04014F2C RID: 85804
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x04014F2D RID: 85805
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;
}
