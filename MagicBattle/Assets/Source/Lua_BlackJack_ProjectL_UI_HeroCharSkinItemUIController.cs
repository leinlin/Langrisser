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

// Token: 0x020014A7 RID: 5287
[Preserve]
public class Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController : LuaObject
{
	// Token: 0x0601E9FF RID: 125439 RVA: 0x009E6F38 File Offset: 0x009E5138
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetHeroCharSkinItem(IntPtr l)
	{
		int result;
		try
		{
			HeroCharSkinItemUIController heroCharSkinItemUIController = (HeroCharSkinItemUIController)LuaObject.checkSelf(l);
			int heroSkinId;
			LuaObject.checkType(l, 2, out heroSkinId);
			int index;
			LuaObject.checkType(l, 3, out index);
			ConfigDataHeroInfo heroInfo;
			LuaObject.checkType<ConfigDataHeroInfo>(l, 4, out heroInfo);
			int heroCurSkinId;
			LuaObject.checkType(l, 5, out heroCurSkinId);
			string mode;
			LuaObject.checkType(l, 6, out mode);
			heroCharSkinItemUIController.SetHeroCharSkinItem(heroSkinId, index, heroInfo, heroCurSkinId, mode);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EA00 RID: 125440 RVA: 0x009E6FC4 File Offset: 0x009E51C4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CreateDefaultItem(IntPtr l)
	{
		int result;
		try
		{
			HeroCharSkinItemUIController heroCharSkinItemUIController = (HeroCharSkinItemUIController)LuaObject.checkSelf(l);
			ConfigDataHeroInfo heroInfo;
			LuaObject.checkType<ConfigDataHeroInfo>(l, 2, out heroInfo);
			heroCharSkinItemUIController.CreateDefaultItem(heroInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EA01 RID: 125441 RVA: 0x009E701C File Offset: 0x009E521C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowSelectImage(IntPtr l)
	{
		int result;
		try
		{
			HeroCharSkinItemUIController heroCharSkinItemUIController = (HeroCharSkinItemUIController)LuaObject.checkSelf(l);
			bool isShow;
			LuaObject.checkType(l, 2, out isShow);
			heroCharSkinItemUIController.ShowSelectImage(isShow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EA02 RID: 125442 RVA: 0x009E7074 File Offset: 0x009E5274
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetIndex(IntPtr l)
	{
		int result;
		try
		{
			HeroCharSkinItemUIController heroCharSkinItemUIController = (HeroCharSkinItemUIController)LuaObject.checkSelf(l);
			int index = heroCharSkinItemUIController.GetIndex();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, index);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EA03 RID: 125443 RVA: 0x009E70C8 File Offset: 0x009E52C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetLimitTime(IntPtr l)
	{
		int result;
		try
		{
			HeroCharSkinItemUIController heroCharSkinItemUIController = (HeroCharSkinItemUIController)LuaObject.checkSelf(l);
			heroCharSkinItemUIController.SetLimitTime();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EA04 RID: 125444 RVA: 0x009E7114 File Offset: 0x009E5314
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			HeroCharSkinItemUIController heroCharSkinItemUIController = (HeroCharSkinItemUIController)LuaObject.checkSelf(l);
			heroCharSkinItemUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EA05 RID: 125445 RVA: 0x009E7168 File Offset: 0x009E5368
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnHeroJobCardItemClick(IntPtr l)
	{
		int result;
		try
		{
			HeroCharSkinItemUIController heroCharSkinItemUIController = (HeroCharSkinItemUIController)LuaObject.checkSelf(l);
			heroCharSkinItemUIController.m_luaExportHelper.OnHeroJobCardItemClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EA06 RID: 125446 RVA: 0x009E71BC File Offset: 0x009E53BC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			HeroCharSkinItemUIController heroCharSkinItemUIController = (HeroCharSkinItemUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			heroCharSkinItemUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EA07 RID: 125447 RVA: 0x009E7228 File Offset: 0x009E5428
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			HeroCharSkinItemUIController heroCharSkinItemUIController = (HeroCharSkinItemUIController)LuaObject.checkSelf(l);
			heroCharSkinItemUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EA08 RID: 125448 RVA: 0x009E727C File Offset: 0x009E547C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			HeroCharSkinItemUIController heroCharSkinItemUIController = (HeroCharSkinItemUIController)LuaObject.checkSelf(l);
			heroCharSkinItemUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EA09 RID: 125449 RVA: 0x009E72D0 File Offset: 0x009E54D0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			HeroCharSkinItemUIController heroCharSkinItemUIController = (HeroCharSkinItemUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = heroCharSkinItemUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601EA0A RID: 125450 RVA: 0x009E7378 File Offset: 0x009E5578
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			HeroCharSkinItemUIController heroCharSkinItemUIController = (HeroCharSkinItemUIController)LuaObject.checkSelf(l);
			heroCharSkinItemUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EA0B RID: 125451 RVA: 0x009E73CC File Offset: 0x009E55CC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroCharSkinItemUIController heroCharSkinItemUIController = (HeroCharSkinItemUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			heroCharSkinItemUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EA0C RID: 125452 RVA: 0x009E7438 File Offset: 0x009E5638
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
				HeroCharSkinItemUIController heroCharSkinItemUIController = (HeroCharSkinItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				heroCharSkinItemUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				HeroCharSkinItemUIController heroCharSkinItemUIController2 = (HeroCharSkinItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				heroCharSkinItemUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601EA0D RID: 125453 RVA: 0x009E7548 File Offset: 0x009E5748
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			HeroCharSkinItemUIController heroCharSkinItemUIController = (HeroCharSkinItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroCharSkinItemUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EA0E RID: 125454 RVA: 0x009E75B4 File Offset: 0x009E57B4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			HeroCharSkinItemUIController heroCharSkinItemUIController = (HeroCharSkinItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroCharSkinItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EA0F RID: 125455 RVA: 0x009E7620 File Offset: 0x009E5820
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			HeroCharSkinItemUIController heroCharSkinItemUIController = (HeroCharSkinItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroCharSkinItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EA10 RID: 125456 RVA: 0x009E768C File Offset: 0x009E588C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			HeroCharSkinItemUIController heroCharSkinItemUIController = (HeroCharSkinItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroCharSkinItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EA11 RID: 125457 RVA: 0x009E76F8 File Offset: 0x009E58F8
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
				HeroCharSkinItemUIController heroCharSkinItemUIController = (HeroCharSkinItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				heroCharSkinItemUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				HeroCharSkinItemUIController heroCharSkinItemUIController2 = (HeroCharSkinItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				heroCharSkinItemUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601EA12 RID: 125458 RVA: 0x009E7808 File Offset: 0x009E5A08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			HeroCharSkinItemUIController heroCharSkinItemUIController = (HeroCharSkinItemUIController)LuaObject.checkSelf(l);
			string s = heroCharSkinItemUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601EA13 RID: 125459 RVA: 0x009E7864 File Offset: 0x009E5A64
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callDele_EventOnItemClick(IntPtr l)
	{
		int result;
		try
		{
			HeroCharSkinItemUIController heroCharSkinItemUIController = (HeroCharSkinItemUIController)LuaObject.checkSelf(l);
			HeroCharSkinItemUIController obj;
			LuaObject.checkType<HeroCharSkinItemUIController>(l, 2, out obj);
			heroCharSkinItemUIController.m_luaExportHelper.__callDele_EventOnItemClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EA14 RID: 125460 RVA: 0x009E78C0 File Offset: 0x009E5AC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnItemClick(IntPtr l)
	{
		int result;
		try
		{
			HeroCharSkinItemUIController heroCharSkinItemUIController = (HeroCharSkinItemUIController)LuaObject.checkSelf(l);
			HeroCharSkinItemUIController obj;
			LuaObject.checkType<HeroCharSkinItemUIController>(l, 2, out obj);
			heroCharSkinItemUIController.m_luaExportHelper.__clearDele_EventOnItemClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EA15 RID: 125461 RVA: 0x009E791C File Offset: 0x009E5B1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnItemClick(IntPtr l)
	{
		int result;
		try
		{
			HeroCharSkinItemUIController heroCharSkinItemUIController = (HeroCharSkinItemUIController)LuaObject.checkSelf(l);
			Action<HeroCharSkinItemUIController> value;
			int num = LuaObject.checkDelegate<Action<HeroCharSkinItemUIController>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					heroCharSkinItemUIController.EventOnItemClick += value;
				}
				else if (num == 2)
				{
					heroCharSkinItemUIController.EventOnItemClick -= value;
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

	// Token: 0x0601EA16 RID: 125462 RVA: 0x009E799C File Offset: 0x009E5B9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_stateCtrl(IntPtr l)
	{
		int result;
		try
		{
			HeroCharSkinItemUIController heroCharSkinItemUIController = (HeroCharSkinItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroCharSkinItemUIController.m_luaExportHelper.m_stateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EA17 RID: 125463 RVA: 0x009E79F4 File Offset: 0x009E5BF4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_stateCtrl(IntPtr l)
	{
		int result;
		try
		{
			HeroCharSkinItemUIController heroCharSkinItemUIController = (HeroCharSkinItemUIController)LuaObject.checkSelf(l);
			CommonUIStateController stateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out stateCtrl);
			heroCharSkinItemUIController.m_luaExportHelper.m_stateCtrl = stateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EA18 RID: 125464 RVA: 0x009E7A50 File Offset: 0x009E5C50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_selectImage(IntPtr l)
	{
		int result;
		try
		{
			HeroCharSkinItemUIController heroCharSkinItemUIController = (HeroCharSkinItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroCharSkinItemUIController.m_luaExportHelper.m_selectImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EA19 RID: 125465 RVA: 0x009E7AA8 File Offset: 0x009E5CA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_selectImage(IntPtr l)
	{
		int result;
		try
		{
			HeroCharSkinItemUIController heroCharSkinItemUIController = (HeroCharSkinItemUIController)LuaObject.checkSelf(l);
			GameObject selectImage;
			LuaObject.checkType<GameObject>(l, 2, out selectImage);
			heroCharSkinItemUIController.m_luaExportHelper.m_selectImage = selectImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EA1A RID: 125466 RVA: 0x009E7B04 File Offset: 0x009E5D04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_iconImage(IntPtr l)
	{
		int result;
		try
		{
			HeroCharSkinItemUIController heroCharSkinItemUIController = (HeroCharSkinItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroCharSkinItemUIController.m_luaExportHelper.m_iconImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EA1B RID: 125467 RVA: 0x009E7B5C File Offset: 0x009E5D5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_iconImage(IntPtr l)
	{
		int result;
		try
		{
			HeroCharSkinItemUIController heroCharSkinItemUIController = (HeroCharSkinItemUIController)LuaObject.checkSelf(l);
			Image iconImage;
			LuaObject.checkType<Image>(l, 2, out iconImage);
			heroCharSkinItemUIController.m_luaExportHelper.m_iconImage = iconImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EA1C RID: 125468 RVA: 0x009E7BB8 File Offset: 0x009E5DB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_nameText(IntPtr l)
	{
		int result;
		try
		{
			HeroCharSkinItemUIController heroCharSkinItemUIController = (HeroCharSkinItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroCharSkinItemUIController.m_luaExportHelper.m_nameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EA1D RID: 125469 RVA: 0x009E7C10 File Offset: 0x009E5E10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_nameText(IntPtr l)
	{
		int result;
		try
		{
			HeroCharSkinItemUIController heroCharSkinItemUIController = (HeroCharSkinItemUIController)LuaObject.checkSelf(l);
			Text nameText;
			LuaObject.checkType<Text>(l, 2, out nameText);
			heroCharSkinItemUIController.m_luaExportHelper.m_nameText = nameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EA1E RID: 125470 RVA: 0x009E7C6C File Offset: 0x009E5E6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_timeGo(IntPtr l)
	{
		int result;
		try
		{
			HeroCharSkinItemUIController heroCharSkinItemUIController = (HeroCharSkinItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroCharSkinItemUIController.m_luaExportHelper.m_timeGo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EA1F RID: 125471 RVA: 0x009E7CC4 File Offset: 0x009E5EC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_timeGo(IntPtr l)
	{
		int result;
		try
		{
			HeroCharSkinItemUIController heroCharSkinItemUIController = (HeroCharSkinItemUIController)LuaObject.checkSelf(l);
			GameObject timeGo;
			LuaObject.checkType<GameObject>(l, 2, out timeGo);
			heroCharSkinItemUIController.m_luaExportHelper.m_timeGo = timeGo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EA20 RID: 125472 RVA: 0x009E7D20 File Offset: 0x009E5F20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_timeValueText(IntPtr l)
	{
		int result;
		try
		{
			HeroCharSkinItemUIController heroCharSkinItemUIController = (HeroCharSkinItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroCharSkinItemUIController.m_luaExportHelper.m_timeValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EA21 RID: 125473 RVA: 0x009E7D78 File Offset: 0x009E5F78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_timeValueText(IntPtr l)
	{
		int result;
		try
		{
			HeroCharSkinItemUIController heroCharSkinItemUIController = (HeroCharSkinItemUIController)LuaObject.checkSelf(l);
			Text timeValueText;
			LuaObject.checkType<Text>(l, 2, out timeValueText);
			heroCharSkinItemUIController.m_luaExportHelper.m_timeValueText = timeValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EA22 RID: 125474 RVA: 0x009E7DD4 File Offset: 0x009E5FD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_timeStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			HeroCharSkinItemUIController heroCharSkinItemUIController = (HeroCharSkinItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroCharSkinItemUIController.m_luaExportHelper.m_timeStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EA23 RID: 125475 RVA: 0x009E7E2C File Offset: 0x009E602C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_timeStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			HeroCharSkinItemUIController heroCharSkinItemUIController = (HeroCharSkinItemUIController)LuaObject.checkSelf(l);
			CommonUIStateController timeStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out timeStateCtrl);
			heroCharSkinItemUIController.m_luaExportHelper.m_timeStateCtrl = timeStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EA24 RID: 125476 RVA: 0x009E7E88 File Offset: 0x009E6088
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_index(IntPtr l)
	{
		int result;
		try
		{
			HeroCharSkinItemUIController heroCharSkinItemUIController = (HeroCharSkinItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroCharSkinItemUIController.m_luaExportHelper.m_index);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EA25 RID: 125477 RVA: 0x009E7EE0 File Offset: 0x009E60E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_index(IntPtr l)
	{
		int result;
		try
		{
			HeroCharSkinItemUIController heroCharSkinItemUIController = (HeroCharSkinItemUIController)LuaObject.checkSelf(l);
			int index;
			LuaObject.checkType(l, 2, out index);
			heroCharSkinItemUIController.m_luaExportHelper.m_index = index;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EA26 RID: 125478 RVA: 0x009E7F3C File Offset: 0x009E613C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_IsDefaultSkin(IntPtr l)
	{
		int result;
		try
		{
			HeroCharSkinItemUIController heroCharSkinItemUIController = (HeroCharSkinItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroCharSkinItemUIController.IsDefaultSkin);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EA27 RID: 125479 RVA: 0x009E7F90 File Offset: 0x009E6190
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_IsDefaultSkin(IntPtr l)
	{
		int result;
		try
		{
			HeroCharSkinItemUIController heroCharSkinItemUIController = (HeroCharSkinItemUIController)LuaObject.checkSelf(l);
			bool isDefaultSkin;
			LuaObject.checkType(l, 2, out isDefaultSkin);
			heroCharSkinItemUIController.m_luaExportHelper.IsDefaultSkin = isDefaultSkin;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EA28 RID: 125480 RVA: 0x009E7FEC File Offset: 0x009E61EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_HeroInfo(IntPtr l)
	{
		int result;
		try
		{
			HeroCharSkinItemUIController heroCharSkinItemUIController = (HeroCharSkinItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroCharSkinItemUIController.HeroInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EA29 RID: 125481 RVA: 0x009E8040 File Offset: 0x009E6240
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_HeroInfo(IntPtr l)
	{
		int result;
		try
		{
			HeroCharSkinItemUIController heroCharSkinItemUIController = (HeroCharSkinItemUIController)LuaObject.checkSelf(l);
			ConfigDataHeroInfo heroInfo;
			LuaObject.checkType<ConfigDataHeroInfo>(l, 2, out heroInfo);
			heroCharSkinItemUIController.m_luaExportHelper.HeroInfo = heroInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EA2A RID: 125482 RVA: 0x009E809C File Offset: 0x009E629C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_HeroSkinInfo(IntPtr l)
	{
		int result;
		try
		{
			HeroCharSkinItemUIController heroCharSkinItemUIController = (HeroCharSkinItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroCharSkinItemUIController.HeroSkinInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EA2B RID: 125483 RVA: 0x009E80F0 File Offset: 0x009E62F0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_HeroSkinInfo(IntPtr l)
	{
		int result;
		try
		{
			HeroCharSkinItemUIController heroCharSkinItemUIController = (HeroCharSkinItemUIController)LuaObject.checkSelf(l);
			ConfigDataHeroSkinInfo heroSkinInfo;
			LuaObject.checkType<ConfigDataHeroSkinInfo>(l, 2, out heroSkinInfo);
			heroCharSkinItemUIController.m_luaExportHelper.HeroSkinInfo = heroSkinInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EA2C RID: 125484 RVA: 0x009E814C File Offset: 0x009E634C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_CharSkinInfo(IntPtr l)
	{
		int result;
		try
		{
			HeroCharSkinItemUIController heroCharSkinItemUIController = (HeroCharSkinItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroCharSkinItemUIController.CharSkinInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EA2D RID: 125485 RVA: 0x009E81A0 File Offset: 0x009E63A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_CharSkinInfo(IntPtr l)
	{
		int result;
		try
		{
			HeroCharSkinItemUIController heroCharSkinItemUIController = (HeroCharSkinItemUIController)LuaObject.checkSelf(l);
			ConfigDataCharImageSkinResourceInfo charSkinInfo;
			LuaObject.checkType<ConfigDataCharImageSkinResourceInfo>(l, 2, out charSkinInfo);
			heroCharSkinItemUIController.m_luaExportHelper.CharSkinInfo = charSkinInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EA2E RID: 125486 RVA: 0x009E81FC File Offset: 0x009E63FC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.HeroCharSkinItemUIController");
		if (Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.SetHeroCharSkinItem);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.CreateDefaultItem);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.ShowSelectImage);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.GetIndex);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.SetLimitTime);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.OnHeroJobCardItemClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.__callDele_EventOnItemClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.__clearDele_EventOnItemClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.<>f__mg$cache15);
		string name = "EventOnItemClick";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.set_EventOnItemClick);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.<>f__mg$cache16, true);
		string name2 = "m_stateCtrl";
		if (Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.get_m_stateCtrl);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.<>f__mg$cache17;
		if (Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.set_m_stateCtrl);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.<>f__mg$cache18, true);
		string name3 = "m_selectImage";
		if (Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.get_m_selectImage);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.<>f__mg$cache19;
		if (Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.set_m_selectImage);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.<>f__mg$cache1A, true);
		string name4 = "m_iconImage";
		if (Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.get_m_iconImage);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.<>f__mg$cache1B;
		if (Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.set_m_iconImage);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.<>f__mg$cache1C, true);
		string name5 = "m_nameText";
		if (Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.get_m_nameText);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.<>f__mg$cache1D;
		if (Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.set_m_nameText);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.<>f__mg$cache1E, true);
		string name6 = "m_timeGo";
		if (Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.get_m_timeGo);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.<>f__mg$cache1F;
		if (Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.set_m_timeGo);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.<>f__mg$cache20, true);
		string name7 = "m_timeValueText";
		if (Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.get_m_timeValueText);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.<>f__mg$cache21;
		if (Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.set_m_timeValueText);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.<>f__mg$cache22, true);
		string name8 = "m_timeStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.get_m_timeStateCtrl);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.<>f__mg$cache23;
		if (Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.set_m_timeStateCtrl);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.<>f__mg$cache24, true);
		string name9 = "m_index";
		if (Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.get_m_index);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.<>f__mg$cache25;
		if (Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.set_m_index);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.<>f__mg$cache26, true);
		string name10 = "IsDefaultSkin";
		if (Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.get_IsDefaultSkin);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.<>f__mg$cache27;
		if (Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.set_IsDefaultSkin);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.<>f__mg$cache28, true);
		string name11 = "HeroInfo";
		if (Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.get_HeroInfo);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.<>f__mg$cache29;
		if (Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.set_HeroInfo);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.<>f__mg$cache2A, true);
		string name12 = "HeroSkinInfo";
		if (Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.get_HeroSkinInfo);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.<>f__mg$cache2B;
		if (Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.set_HeroSkinInfo);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.<>f__mg$cache2C, true);
		string name13 = "CharSkinInfo";
		if (Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.get_CharSkinInfo);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.<>f__mg$cache2D;
		if (Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.set_CharSkinInfo);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.<>f__mg$cache2E, true);
		LuaObject.createTypeMetatable(l, null, typeof(HeroCharSkinItemUIController), typeof(UIControllerBase));
	}

	// Token: 0x04014A93 RID: 84627
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04014A94 RID: 84628
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04014A95 RID: 84629
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04014A96 RID: 84630
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04014A97 RID: 84631
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04014A98 RID: 84632
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04014A99 RID: 84633
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04014A9A RID: 84634
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04014A9B RID: 84635
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04014A9C RID: 84636
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04014A9D RID: 84637
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04014A9E RID: 84638
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04014A9F RID: 84639
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04014AA0 RID: 84640
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04014AA1 RID: 84641
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04014AA2 RID: 84642
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04014AA3 RID: 84643
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04014AA4 RID: 84644
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04014AA5 RID: 84645
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04014AA6 RID: 84646
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04014AA7 RID: 84647
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04014AA8 RID: 84648
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04014AA9 RID: 84649
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04014AAA RID: 84650
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04014AAB RID: 84651
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04014AAC RID: 84652
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04014AAD RID: 84653
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04014AAE RID: 84654
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04014AAF RID: 84655
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04014AB0 RID: 84656
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04014AB1 RID: 84657
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04014AB2 RID: 84658
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04014AB3 RID: 84659
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04014AB4 RID: 84660
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04014AB5 RID: 84661
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04014AB6 RID: 84662
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04014AB7 RID: 84663
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04014AB8 RID: 84664
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04014AB9 RID: 84665
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04014ABA RID: 84666
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04014ABB RID: 84667
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04014ABC RID: 84668
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04014ABD RID: 84669
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04014ABE RID: 84670
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04014ABF RID: 84671
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04014AC0 RID: 84672
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04014AC1 RID: 84673
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;
}
