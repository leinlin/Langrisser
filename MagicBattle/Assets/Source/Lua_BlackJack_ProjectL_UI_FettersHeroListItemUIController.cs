using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x0200143C RID: 5180
[Preserve]
public class Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController : LuaObject
{
	// Token: 0x0601DCEF RID: 122095 RVA: 0x00980760 File Offset: 0x0097E960
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitFettersHeroListItem(IntPtr l)
	{
		int result;
		try
		{
			FettersHeroListItemUIController fettersHeroListItemUIController = (FettersHeroListItemUIController)LuaObject.checkSelf(l);
			Hero hero;
			LuaObject.checkType<Hero>(l, 2, out hero);
			fettersHeroListItemUIController.InitFettersHeroListItem(hero);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DCF0 RID: 122096 RVA: 0x009807B8 File Offset: 0x0097E9B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			FettersHeroListItemUIController fettersHeroListItemUIController = (FettersHeroListItemUIController)LuaObject.checkSelf(l);
			fettersHeroListItemUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DCF1 RID: 122097 RVA: 0x0098080C File Offset: 0x0097EA0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnHeroItemClick(IntPtr l)
	{
		int result;
		try
		{
			FettersHeroListItemUIController fettersHeroListItemUIController = (FettersHeroListItemUIController)LuaObject.checkSelf(l);
			fettersHeroListItemUIController.m_luaExportHelper.OnHeroItemClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DCF2 RID: 122098 RVA: 0x00980860 File Offset: 0x0097EA60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			FettersHeroListItemUIController fettersHeroListItemUIController = (FettersHeroListItemUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			fettersHeroListItemUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DCF3 RID: 122099 RVA: 0x009808CC File Offset: 0x0097EACC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			FettersHeroListItemUIController fettersHeroListItemUIController = (FettersHeroListItemUIController)LuaObject.checkSelf(l);
			fettersHeroListItemUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DCF4 RID: 122100 RVA: 0x00980920 File Offset: 0x0097EB20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			FettersHeroListItemUIController fettersHeroListItemUIController = (FettersHeroListItemUIController)LuaObject.checkSelf(l);
			fettersHeroListItemUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DCF5 RID: 122101 RVA: 0x00980974 File Offset: 0x0097EB74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			FettersHeroListItemUIController fettersHeroListItemUIController = (FettersHeroListItemUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = fettersHeroListItemUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601DCF6 RID: 122102 RVA: 0x00980A1C File Offset: 0x0097EC1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			FettersHeroListItemUIController fettersHeroListItemUIController = (FettersHeroListItemUIController)LuaObject.checkSelf(l);
			fettersHeroListItemUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DCF7 RID: 122103 RVA: 0x00980A70 File Offset: 0x0097EC70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			FettersHeroListItemUIController fettersHeroListItemUIController = (FettersHeroListItemUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			fettersHeroListItemUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DCF8 RID: 122104 RVA: 0x00980ADC File Offset: 0x0097ECDC
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
				FettersHeroListItemUIController fettersHeroListItemUIController = (FettersHeroListItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				fettersHeroListItemUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				FettersHeroListItemUIController fettersHeroListItemUIController2 = (FettersHeroListItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				fettersHeroListItemUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601DCF9 RID: 122105 RVA: 0x00980BEC File Offset: 0x0097EDEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			FettersHeroListItemUIController fettersHeroListItemUIController = (FettersHeroListItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			fettersHeroListItemUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DCFA RID: 122106 RVA: 0x00980C58 File Offset: 0x0097EE58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			FettersHeroListItemUIController fettersHeroListItemUIController = (FettersHeroListItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			fettersHeroListItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DCFB RID: 122107 RVA: 0x00980CC4 File Offset: 0x0097EEC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			FettersHeroListItemUIController fettersHeroListItemUIController = (FettersHeroListItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			fettersHeroListItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DCFC RID: 122108 RVA: 0x00980D30 File Offset: 0x0097EF30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			FettersHeroListItemUIController fettersHeroListItemUIController = (FettersHeroListItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			fettersHeroListItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DCFD RID: 122109 RVA: 0x00980D9C File Offset: 0x0097EF9C
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
				FettersHeroListItemUIController fettersHeroListItemUIController = (FettersHeroListItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				fettersHeroListItemUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				FettersHeroListItemUIController fettersHeroListItemUIController2 = (FettersHeroListItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				fettersHeroListItemUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601DCFE RID: 122110 RVA: 0x00980EAC File Offset: 0x0097F0AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			FettersHeroListItemUIController fettersHeroListItemUIController = (FettersHeroListItemUIController)LuaObject.checkSelf(l);
			string s = fettersHeroListItemUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601DCFF RID: 122111 RVA: 0x00980F08 File Offset: 0x0097F108
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnClick(IntPtr l)
	{
		int result;
		try
		{
			FettersHeroListItemUIController fettersHeroListItemUIController = (FettersHeroListItemUIController)LuaObject.checkSelf(l);
			Hero obj;
			LuaObject.checkType<Hero>(l, 2, out obj);
			fettersHeroListItemUIController.m_luaExportHelper.__callDele_EventOnClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DD00 RID: 122112 RVA: 0x00980F64 File Offset: 0x0097F164
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnClick(IntPtr l)
	{
		int result;
		try
		{
			FettersHeroListItemUIController fettersHeroListItemUIController = (FettersHeroListItemUIController)LuaObject.checkSelf(l);
			Hero obj;
			LuaObject.checkType<Hero>(l, 2, out obj);
			fettersHeroListItemUIController.m_luaExportHelper.__clearDele_EventOnClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DD01 RID: 122113 RVA: 0x00980FC0 File Offset: 0x0097F1C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnClick(IntPtr l)
	{
		int result;
		try
		{
			FettersHeroListItemUIController fettersHeroListItemUIController = (FettersHeroListItemUIController)LuaObject.checkSelf(l);
			Action<Hero> value;
			int num = LuaObject.checkDelegate<Action<Hero>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					fettersHeroListItemUIController.EventOnClick += value;
				}
				else if (num == 2)
				{
					fettersHeroListItemUIController.EventOnClick -= value;
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

	// Token: 0x0601DD02 RID: 122114 RVA: 0x00981040 File Offset: 0x0097F240
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_stateCtrl(IntPtr l)
	{
		int result;
		try
		{
			FettersHeroListItemUIController fettersHeroListItemUIController = (FettersHeroListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersHeroListItemUIController.m_luaExportHelper.m_stateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DD03 RID: 122115 RVA: 0x00981098 File Offset: 0x0097F298
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_stateCtrl(IntPtr l)
	{
		int result;
		try
		{
			FettersHeroListItemUIController fettersHeroListItemUIController = (FettersHeroListItemUIController)LuaObject.checkSelf(l);
			CommonUIStateController stateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out stateCtrl);
			fettersHeroListItemUIController.m_luaExportHelper.m_stateCtrl = stateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DD04 RID: 122116 RVA: 0x009810F4 File Offset: 0x0097F2F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroStar(IntPtr l)
	{
		int result;
		try
		{
			FettersHeroListItemUIController fettersHeroListItemUIController = (FettersHeroListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersHeroListItemUIController.m_luaExportHelper.m_heroStar);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DD05 RID: 122117 RVA: 0x0098114C File Offset: 0x0097F34C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroStar(IntPtr l)
	{
		int result;
		try
		{
			FettersHeroListItemUIController fettersHeroListItemUIController = (FettersHeroListItemUIController)LuaObject.checkSelf(l);
			GameObject heroStar;
			LuaObject.checkType<GameObject>(l, 2, out heroStar);
			fettersHeroListItemUIController.m_luaExportHelper.m_heroStar = heroStar;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DD06 RID: 122118 RVA: 0x009811A8 File Offset: 0x0097F3A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroLvText(IntPtr l)
	{
		int result;
		try
		{
			FettersHeroListItemUIController fettersHeroListItemUIController = (FettersHeroListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersHeroListItemUIController.m_luaExportHelper.m_heroLvText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DD07 RID: 122119 RVA: 0x00981200 File Offset: 0x0097F400
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroLvText(IntPtr l)
	{
		int result;
		try
		{
			FettersHeroListItemUIController fettersHeroListItemUIController = (FettersHeroListItemUIController)LuaObject.checkSelf(l);
			Text heroLvText;
			LuaObject.checkType<Text>(l, 2, out heroLvText);
			fettersHeroListItemUIController.m_luaExportHelper.m_heroLvText = heroLvText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DD08 RID: 122120 RVA: 0x0098125C File Offset: 0x0097F45C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_ssrFrameEffect(IntPtr l)
	{
		int result;
		try
		{
			FettersHeroListItemUIController fettersHeroListItemUIController = (FettersHeroListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersHeroListItemUIController.m_luaExportHelper.m_ssrFrameEffect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DD09 RID: 122121 RVA: 0x009812B4 File Offset: 0x0097F4B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_ssrFrameEffect(IntPtr l)
	{
		int result;
		try
		{
			FettersHeroListItemUIController fettersHeroListItemUIController = (FettersHeroListItemUIController)LuaObject.checkSelf(l);
			GameObject ssrFrameEffect;
			LuaObject.checkType<GameObject>(l, 2, out ssrFrameEffect);
			fettersHeroListItemUIController.m_luaExportHelper.m_ssrFrameEffect = ssrFrameEffect;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DD0A RID: 122122 RVA: 0x00981310 File Offset: 0x0097F510
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_frameImg(IntPtr l)
	{
		int result;
		try
		{
			FettersHeroListItemUIController fettersHeroListItemUIController = (FettersHeroListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersHeroListItemUIController.m_luaExportHelper.m_frameImg);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DD0B RID: 122123 RVA: 0x00981368 File Offset: 0x0097F568
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_frameImg(IntPtr l)
	{
		int result;
		try
		{
			FettersHeroListItemUIController fettersHeroListItemUIController = (FettersHeroListItemUIController)LuaObject.checkSelf(l);
			Image frameImg;
			LuaObject.checkType<Image>(l, 2, out frameImg);
			fettersHeroListItemUIController.m_luaExportHelper.m_frameImg = frameImg;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DD0C RID: 122124 RVA: 0x009813C4 File Offset: 0x0097F5C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroIconImg(IntPtr l)
	{
		int result;
		try
		{
			FettersHeroListItemUIController fettersHeroListItemUIController = (FettersHeroListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersHeroListItemUIController.m_luaExportHelper.m_heroIconImg);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DD0D RID: 122125 RVA: 0x0098141C File Offset: 0x0097F61C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroIconImg(IntPtr l)
	{
		int result;
		try
		{
			FettersHeroListItemUIController fettersHeroListItemUIController = (FettersHeroListItemUIController)LuaObject.checkSelf(l);
			Image heroIconImg;
			LuaObject.checkType<Image>(l, 2, out heroIconImg);
			fettersHeroListItemUIController.m_luaExportHelper.m_heroIconImg = heroIconImg;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DD0E RID: 122126 RVA: 0x00981478 File Offset: 0x0097F678
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_redMark(IntPtr l)
	{
		int result;
		try
		{
			FettersHeroListItemUIController fettersHeroListItemUIController = (FettersHeroListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersHeroListItemUIController.m_luaExportHelper.m_redMark);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DD0F RID: 122127 RVA: 0x009814D0 File Offset: 0x0097F6D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_redMark(IntPtr l)
	{
		int result;
		try
		{
			FettersHeroListItemUIController fettersHeroListItemUIController = (FettersHeroListItemUIController)LuaObject.checkSelf(l);
			GameObject redMark;
			LuaObject.checkType<GameObject>(l, 2, out redMark);
			fettersHeroListItemUIController.m_luaExportHelper.m_redMark = redMark;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DD10 RID: 122128 RVA: 0x0098152C File Offset: 0x0097F72C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_favorabilityValueTextRed(IntPtr l)
	{
		int result;
		try
		{
			FettersHeroListItemUIController fettersHeroListItemUIController = (FettersHeroListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersHeroListItemUIController.m_luaExportHelper.m_favorabilityValueTextRed);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DD11 RID: 122129 RVA: 0x00981584 File Offset: 0x0097F784
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_favorabilityValueTextRed(IntPtr l)
	{
		int result;
		try
		{
			FettersHeroListItemUIController fettersHeroListItemUIController = (FettersHeroListItemUIController)LuaObject.checkSelf(l);
			Text favorabilityValueTextRed;
			LuaObject.checkType<Text>(l, 2, out favorabilityValueTextRed);
			fettersHeroListItemUIController.m_luaExportHelper.m_favorabilityValueTextRed = favorabilityValueTextRed;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DD12 RID: 122130 RVA: 0x009815E0 File Offset: 0x0097F7E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_favorabilityValueTextPink(IntPtr l)
	{
		int result;
		try
		{
			FettersHeroListItemUIController fettersHeroListItemUIController = (FettersHeroListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersHeroListItemUIController.m_luaExportHelper.m_favorabilityValueTextPink);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DD13 RID: 122131 RVA: 0x00981638 File Offset: 0x0097F838
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_favorabilityValueTextPink(IntPtr l)
	{
		int result;
		try
		{
			FettersHeroListItemUIController fettersHeroListItemUIController = (FettersHeroListItemUIController)LuaObject.checkSelf(l);
			Text favorabilityValueTextPink;
			LuaObject.checkType<Text>(l, 2, out favorabilityValueTextPink);
			fettersHeroListItemUIController.m_luaExportHelper.m_favorabilityValueTextPink = favorabilityValueTextPink;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DD14 RID: 122132 RVA: 0x00981694 File Offset: 0x0097F894
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_hero(IntPtr l)
	{
		int result;
		try
		{
			FettersHeroListItemUIController fettersHeroListItemUIController = (FettersHeroListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersHeroListItemUIController.m_hero);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DD15 RID: 122133 RVA: 0x009816E8 File Offset: 0x0097F8E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_hero(IntPtr l)
	{
		int result;
		try
		{
			FettersHeroListItemUIController fettersHeroListItemUIController = (FettersHeroListItemUIController)LuaObject.checkSelf(l);
			Hero hero;
			LuaObject.checkType<Hero>(l, 2, out hero);
			fettersHeroListItemUIController.m_hero = hero;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DD16 RID: 122134 RVA: 0x00981740 File Offset: 0x0097F940
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.FettersHeroListItemUIController");
		if (Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.InitFettersHeroListItem);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.OnHeroItemClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.__callDele_EventOnClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.__clearDele_EventOnClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.<>f__mg$cache11);
		string name = "EventOnClick";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.set_EventOnClick);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.<>f__mg$cache12, true);
		string name2 = "m_stateCtrl";
		if (Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.get_m_stateCtrl);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.<>f__mg$cache13;
		if (Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.set_m_stateCtrl);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.<>f__mg$cache14, true);
		string name3 = "m_heroStar";
		if (Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.get_m_heroStar);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.<>f__mg$cache15;
		if (Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.set_m_heroStar);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.<>f__mg$cache16, true);
		string name4 = "m_heroLvText";
		if (Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.get_m_heroLvText);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.<>f__mg$cache17;
		if (Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.set_m_heroLvText);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.<>f__mg$cache18, true);
		string name5 = "m_ssrFrameEffect";
		if (Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.get_m_ssrFrameEffect);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.<>f__mg$cache19;
		if (Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.set_m_ssrFrameEffect);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.<>f__mg$cache1A, true);
		string name6 = "m_frameImg";
		if (Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.get_m_frameImg);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.<>f__mg$cache1B;
		if (Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.set_m_frameImg);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.<>f__mg$cache1C, true);
		string name7 = "m_heroIconImg";
		if (Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.get_m_heroIconImg);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.<>f__mg$cache1D;
		if (Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.set_m_heroIconImg);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.<>f__mg$cache1E, true);
		string name8 = "m_redMark";
		if (Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.get_m_redMark);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.<>f__mg$cache1F;
		if (Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.set_m_redMark);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.<>f__mg$cache20, true);
		string name9 = "m_favorabilityValueTextRed";
		if (Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.get_m_favorabilityValueTextRed);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.<>f__mg$cache21;
		if (Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.set_m_favorabilityValueTextRed);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.<>f__mg$cache22, true);
		string name10 = "m_favorabilityValueTextPink";
		if (Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.get_m_favorabilityValueTextPink);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.<>f__mg$cache23;
		if (Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.set_m_favorabilityValueTextPink);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.<>f__mg$cache24, true);
		string name11 = "m_hero";
		if (Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.get_m_hero);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.<>f__mg$cache25;
		if (Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.set_m_hero);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.<>f__mg$cache26, true);
		LuaObject.createTypeMetatable(l, null, typeof(FettersHeroListItemUIController), typeof(UIControllerBase));
	}

	// Token: 0x04013E59 RID: 81497
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04013E5A RID: 81498
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04013E5B RID: 81499
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04013E5C RID: 81500
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04013E5D RID: 81501
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04013E5E RID: 81502
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04013E5F RID: 81503
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04013E60 RID: 81504
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04013E61 RID: 81505
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04013E62 RID: 81506
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04013E63 RID: 81507
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04013E64 RID: 81508
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04013E65 RID: 81509
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04013E66 RID: 81510
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04013E67 RID: 81511
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04013E68 RID: 81512
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04013E69 RID: 81513
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04013E6A RID: 81514
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04013E6B RID: 81515
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04013E6C RID: 81516
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04013E6D RID: 81517
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04013E6E RID: 81518
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04013E6F RID: 81519
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04013E70 RID: 81520
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04013E71 RID: 81521
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04013E72 RID: 81522
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04013E73 RID: 81523
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04013E74 RID: 81524
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04013E75 RID: 81525
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04013E76 RID: 81526
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04013E77 RID: 81527
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04013E78 RID: 81528
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04013E79 RID: 81529
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04013E7A RID: 81530
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04013E7B RID: 81531
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04013E7C RID: 81532
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04013E7D RID: 81533
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04013E7E RID: 81534
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04013E7F RID: 81535
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;
}
