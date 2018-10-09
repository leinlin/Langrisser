using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x020014B1 RID: 5297
[Preserve]
public class Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController : LuaObject
{
	// Token: 0x0601EBE5 RID: 125925 RVA: 0x009F6270 File Offset: 0x009F4470
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateViewInAddExpState(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailAddExpUIController heroDetailAddExpUIController = (HeroDetailAddExpUIController)LuaObject.checkSelf(l);
			Hero hero;
			LuaObject.checkType<Hero>(l, 2, out hero);
			heroDetailAddExpUIController.UpdateViewInAddExpState(hero);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EBE6 RID: 125926 RVA: 0x009F62C8 File Offset: 0x009F44C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateAddExpPanel(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailAddExpUIController heroDetailAddExpUIController = (HeroDetailAddExpUIController)LuaObject.checkSelf(l);
			heroDetailAddExpUIController.UpdateAddExpPanel();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EBE7 RID: 125927 RVA: 0x009F6314 File Offset: 0x009F4514
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UseFirstExpBagItemForUserGuide(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailAddExpUIController heroDetailAddExpUIController = (HeroDetailAddExpUIController)LuaObject.checkSelf(l);
			HeroExpItemUIController ctrl;
			LuaObject.checkType<HeroExpItemUIController>(l, 2, out ctrl);
			heroDetailAddExpUIController.UseFirstExpBagItemForUserGuide(ctrl);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EBE8 RID: 125928 RVA: 0x009F636C File Offset: 0x009F456C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailAddExpUIController heroDetailAddExpUIController = (HeroDetailAddExpUIController)LuaObject.checkSelf(l);
			heroDetailAddExpUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EBE9 RID: 125929 RVA: 0x009F63C0 File Offset: 0x009F45C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HeroAddExpLvUpEffect(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailAddExpUIController heroDetailAddExpUIController = (HeroDetailAddExpUIController)LuaObject.checkSelf(l);
			heroDetailAddExpUIController.m_luaExportHelper.HeroAddExpLvUpEffect();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EBEA RID: 125930 RVA: 0x009F6414 File Offset: 0x009F4614
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnExpItemClick(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailAddExpUIController heroDetailAddExpUIController = (HeroDetailAddExpUIController)LuaObject.checkSelf(l);
			HeroExpItemUIController ctrl;
			LuaObject.checkType<HeroExpItemUIController>(l, 2, out ctrl);
			heroDetailAddExpUIController.m_luaExportHelper.OnExpItemClick(ctrl);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EBEB RID: 125931 RVA: 0x009F6470 File Offset: 0x009F4670
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int LocalAddExpTick(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailAddExpUIController heroDetailAddExpUIController = (HeroDetailAddExpUIController)LuaObject.checkSelf(l);
			heroDetailAddExpUIController.m_luaExportHelper.LocalAddExpTick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EBEC RID: 125932 RVA: 0x009F64C4 File Offset: 0x009F46C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddProgressImageWidth(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailAddExpUIController heroDetailAddExpUIController = (HeroDetailAddExpUIController)LuaObject.checkSelf(l);
			float totalWidth;
			LuaObject.checkType(l, 2, out totalWidth);
			float desWidth;
			LuaObject.checkType(l, 3, out desWidth);
			float intervalTime;
			LuaObject.checkType(l, 4, out intervalTime);
			IEnumerator o = heroDetailAddExpUIController.m_luaExportHelper.AddProgressImageWidth(totalWidth, desWidth, intervalTime);
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

	// Token: 0x0601EBED RID: 125933 RVA: 0x009F6548 File Offset: 0x009F4748
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnLocalAddExpFinishedSendReq(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailAddExpUIController heroDetailAddExpUIController = (HeroDetailAddExpUIController)LuaObject.checkSelf(l);
			int usedCount;
			LuaObject.checkType(l, 2, out usedCount);
			heroDetailAddExpUIController.m_luaExportHelper.OnLocalAddExpFinishedSendReq(usedCount);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EBEE RID: 125934 RVA: 0x009F65A4 File Offset: 0x009F47A4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int WaitTimeThenDoEvent(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailAddExpUIController heroDetailAddExpUIController = (HeroDetailAddExpUIController)LuaObject.checkSelf(l);
			int count;
			LuaObject.checkType(l, 2, out count);
			IEnumerator o = heroDetailAddExpUIController.m_luaExportHelper.WaitTimeThenDoEvent(count);
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

	// Token: 0x0601EBEF RID: 125935 RVA: 0x009F660C File Offset: 0x009F480C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CanExpItemUse(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailAddExpUIController heroDetailAddExpUIController = (HeroDetailAddExpUIController)LuaObject.checkSelf(l);
			int heroLv;
			LuaObject.checkType(l, 2, out heroLv);
			int herpExp;
			LuaObject.checkType(l, 3, out herpExp);
			bool b = heroDetailAddExpUIController.m_luaExportHelper.CanExpItemUse(heroLv, herpExp);
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

	// Token: 0x0601EBF0 RID: 125936 RVA: 0x009F6680 File Offset: 0x009F4880
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnAddExpConfirmButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailAddExpUIController heroDetailAddExpUIController = (HeroDetailAddExpUIController)LuaObject.checkSelf(l);
			heroDetailAddExpUIController.m_luaExportHelper.OnAddExpConfirmButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EBF1 RID: 125937 RVA: 0x009F66D4 File Offset: 0x009F48D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnAddExpCanelButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailAddExpUIController heroDetailAddExpUIController = (HeroDetailAddExpUIController)LuaObject.checkSelf(l);
			heroDetailAddExpUIController.m_luaExportHelper.OnAddExpCanelButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EBF2 RID: 125938 RVA: 0x009F6728 File Offset: 0x009F4928
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CloseAddExpPanel(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailAddExpUIController heroDetailAddExpUIController = (HeroDetailAddExpUIController)LuaObject.checkSelf(l);
			heroDetailAddExpUIController.m_luaExportHelper.CloseAddExpPanel();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EBF3 RID: 125939 RVA: 0x009F677C File Offset: 0x009F497C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailAddExpUIController heroDetailAddExpUIController = (HeroDetailAddExpUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			heroDetailAddExpUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EBF4 RID: 125940 RVA: 0x009F67E8 File Offset: 0x009F49E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailAddExpUIController heroDetailAddExpUIController = (HeroDetailAddExpUIController)LuaObject.checkSelf(l);
			heroDetailAddExpUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EBF5 RID: 125941 RVA: 0x009F683C File Offset: 0x009F4A3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailAddExpUIController heroDetailAddExpUIController = (HeroDetailAddExpUIController)LuaObject.checkSelf(l);
			heroDetailAddExpUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EBF6 RID: 125942 RVA: 0x009F6890 File Offset: 0x009F4A90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailAddExpUIController heroDetailAddExpUIController = (HeroDetailAddExpUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = heroDetailAddExpUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601EBF7 RID: 125943 RVA: 0x009F6938 File Offset: 0x009F4B38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailAddExpUIController heroDetailAddExpUIController = (HeroDetailAddExpUIController)LuaObject.checkSelf(l);
			heroDetailAddExpUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EBF8 RID: 125944 RVA: 0x009F698C File Offset: 0x009F4B8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailAddExpUIController heroDetailAddExpUIController = (HeroDetailAddExpUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			heroDetailAddExpUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EBF9 RID: 125945 RVA: 0x009F69F8 File Offset: 0x009F4BF8
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
				HeroDetailAddExpUIController heroDetailAddExpUIController = (HeroDetailAddExpUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				heroDetailAddExpUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				HeroDetailAddExpUIController heroDetailAddExpUIController2 = (HeroDetailAddExpUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				heroDetailAddExpUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601EBFA RID: 125946 RVA: 0x009F6B08 File Offset: 0x009F4D08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailAddExpUIController heroDetailAddExpUIController = (HeroDetailAddExpUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroDetailAddExpUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EBFB RID: 125947 RVA: 0x009F6B74 File Offset: 0x009F4D74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailAddExpUIController heroDetailAddExpUIController = (HeroDetailAddExpUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroDetailAddExpUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EBFC RID: 125948 RVA: 0x009F6BE0 File Offset: 0x009F4DE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailAddExpUIController heroDetailAddExpUIController = (HeroDetailAddExpUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroDetailAddExpUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EBFD RID: 125949 RVA: 0x009F6C4C File Offset: 0x009F4E4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailAddExpUIController heroDetailAddExpUIController = (HeroDetailAddExpUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroDetailAddExpUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EBFE RID: 125950 RVA: 0x009F6CB8 File Offset: 0x009F4EB8
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
				HeroDetailAddExpUIController heroDetailAddExpUIController = (HeroDetailAddExpUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				heroDetailAddExpUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				HeroDetailAddExpUIController heroDetailAddExpUIController2 = (HeroDetailAddExpUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				heroDetailAddExpUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601EBFF RID: 125951 RVA: 0x009F6DC8 File Offset: 0x009F4FC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailAddExpUIController heroDetailAddExpUIController = (HeroDetailAddExpUIController)LuaObject.checkSelf(l);
			string s = heroDetailAddExpUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601EC00 RID: 125952 RVA: 0x009F6E24 File Offset: 0x009F5024
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnReturn(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailAddExpUIController heroDetailAddExpUIController = (HeroDetailAddExpUIController)LuaObject.checkSelf(l);
			heroDetailAddExpUIController.m_luaExportHelper.__callDele_EventOnReturn();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EC01 RID: 125953 RVA: 0x009F6E78 File Offset: 0x009F5078
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnReturn(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailAddExpUIController heroDetailAddExpUIController = (HeroDetailAddExpUIController)LuaObject.checkSelf(l);
			heroDetailAddExpUIController.m_luaExportHelper.__clearDele_EventOnReturn();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EC02 RID: 125954 RVA: 0x009F6ECC File Offset: 0x009F50CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnHeroAddExp(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailAddExpUIController heroDetailAddExpUIController = (HeroDetailAddExpUIController)LuaObject.checkSelf(l);
			int arg;
			LuaObject.checkType(l, 2, out arg);
			BagItemBase arg2;
			LuaObject.checkType<BagItemBase>(l, 3, out arg2);
			int arg3;
			LuaObject.checkType(l, 4, out arg3);
			Action arg4;
			LuaObject.checkDelegate<Action>(l, 5, out arg4);
			heroDetailAddExpUIController.m_luaExportHelper.__callDele_EventOnHeroAddExp(arg, arg2, arg3, arg4);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EC03 RID: 125955 RVA: 0x009F6F50 File Offset: 0x009F5150
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnHeroAddExp(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailAddExpUIController heroDetailAddExpUIController = (HeroDetailAddExpUIController)LuaObject.checkSelf(l);
			int arg;
			LuaObject.checkType(l, 2, out arg);
			BagItemBase arg2;
			LuaObject.checkType<BagItemBase>(l, 3, out arg2);
			int arg3;
			LuaObject.checkType(l, 4, out arg3);
			Action arg4;
			LuaObject.checkDelegate<Action>(l, 5, out arg4);
			heroDetailAddExpUIController.m_luaExportHelper.__clearDele_EventOnHeroAddExp(arg, arg2, arg3, arg4);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EC04 RID: 125956 RVA: 0x009F6FD4 File Offset: 0x009F51D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_rootGo(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailAddExpUIController heroDetailAddExpUIController = (HeroDetailAddExpUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailAddExpUIController.m_luaExportHelper.m_rootGo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EC05 RID: 125957 RVA: 0x009F702C File Offset: 0x009F522C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_rootGo(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailAddExpUIController heroDetailAddExpUIController = (HeroDetailAddExpUIController)LuaObject.checkSelf(l);
			GameObject rootGo;
			LuaObject.checkType<GameObject>(l, 2, out rootGo);
			heroDetailAddExpUIController.m_luaExportHelper.m_rootGo = rootGo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EC06 RID: 125958 RVA: 0x009F7088 File Offset: 0x009F5288
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_closeAddExpButton(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailAddExpUIController heroDetailAddExpUIController = (HeroDetailAddExpUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailAddExpUIController.m_luaExportHelper.m_closeAddExpButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EC07 RID: 125959 RVA: 0x009F70E0 File Offset: 0x009F52E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_closeAddExpButton(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailAddExpUIController heroDetailAddExpUIController = (HeroDetailAddExpUIController)LuaObject.checkSelf(l);
			Button closeAddExpButton;
			LuaObject.checkType<Button>(l, 2, out closeAddExpButton);
			heroDetailAddExpUIController.m_luaExportHelper.m_closeAddExpButton = closeAddExpButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EC08 RID: 125960 RVA: 0x009F713C File Offset: 0x009F533C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_addExpScrollViewContent(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailAddExpUIController heroDetailAddExpUIController = (HeroDetailAddExpUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailAddExpUIController.m_luaExportHelper.m_addExpScrollViewContent);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EC09 RID: 125961 RVA: 0x009F7194 File Offset: 0x009F5394
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_addExpScrollViewContent(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailAddExpUIController heroDetailAddExpUIController = (HeroDetailAddExpUIController)LuaObject.checkSelf(l);
			GameObject addExpScrollViewContent;
			LuaObject.checkType<GameObject>(l, 2, out addExpScrollViewContent);
			heroDetailAddExpUIController.m_luaExportHelper.m_addExpScrollViewContent = addExpScrollViewContent;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EC0A RID: 125962 RVA: 0x009F71F0 File Offset: 0x009F53F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_addExpPanelLvValueText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailAddExpUIController heroDetailAddExpUIController = (HeroDetailAddExpUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailAddExpUIController.m_luaExportHelper.m_addExpPanelLvValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EC0B RID: 125963 RVA: 0x009F7248 File Offset: 0x009F5448
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_addExpPanelLvValueText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailAddExpUIController heroDetailAddExpUIController = (HeroDetailAddExpUIController)LuaObject.checkSelf(l);
			Text addExpPanelLvValueText;
			LuaObject.checkType<Text>(l, 2, out addExpPanelLvValueText);
			heroDetailAddExpUIController.m_luaExportHelper.m_addExpPanelLvValueText = addExpPanelLvValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EC0C RID: 125964 RVA: 0x009F72A4 File Offset: 0x009F54A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_addExpPanelLvValueMaxText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailAddExpUIController heroDetailAddExpUIController = (HeroDetailAddExpUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailAddExpUIController.m_luaExportHelper.m_addExpPanelLvValueMaxText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EC0D RID: 125965 RVA: 0x009F72FC File Offset: 0x009F54FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_addExpPanelLvValueMaxText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailAddExpUIController heroDetailAddExpUIController = (HeroDetailAddExpUIController)LuaObject.checkSelf(l);
			Text addExpPanelLvValueMaxText;
			LuaObject.checkType<Text>(l, 2, out addExpPanelLvValueMaxText);
			heroDetailAddExpUIController.m_luaExportHelper.m_addExpPanelLvValueMaxText = addExpPanelLvValueMaxText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EC0E RID: 125966 RVA: 0x009F7358 File Offset: 0x009F5558
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_addExpPanelHeroNameText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailAddExpUIController heroDetailAddExpUIController = (HeroDetailAddExpUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailAddExpUIController.m_luaExportHelper.m_addExpPanelHeroNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EC0F RID: 125967 RVA: 0x009F73B0 File Offset: 0x009F55B0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_addExpPanelHeroNameText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailAddExpUIController heroDetailAddExpUIController = (HeroDetailAddExpUIController)LuaObject.checkSelf(l);
			Text addExpPanelHeroNameText;
			LuaObject.checkType<Text>(l, 2, out addExpPanelHeroNameText);
			heroDetailAddExpUIController.m_luaExportHelper.m_addExpPanelHeroNameText = addExpPanelHeroNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EC10 RID: 125968 RVA: 0x009F740C File Offset: 0x009F560C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_addExpPanelLevelUpEffect(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailAddExpUIController heroDetailAddExpUIController = (HeroDetailAddExpUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailAddExpUIController.m_luaExportHelper.m_addExpPanelLevelUpEffect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EC11 RID: 125969 RVA: 0x009F7464 File Offset: 0x009F5664
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_addExpPanelLevelUpEffect(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailAddExpUIController heroDetailAddExpUIController = (HeroDetailAddExpUIController)LuaObject.checkSelf(l);
			GameObject addExpPanelLevelUpEffect;
			LuaObject.checkType<GameObject>(l, 2, out addExpPanelLevelUpEffect);
			heroDetailAddExpUIController.m_luaExportHelper.m_addExpPanelLevelUpEffect = addExpPanelLevelUpEffect;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EC12 RID: 125970 RVA: 0x009F74C0 File Offset: 0x009F56C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_addExpPanelHeroIconImg(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailAddExpUIController heroDetailAddExpUIController = (HeroDetailAddExpUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailAddExpUIController.m_luaExportHelper.m_addExpPanelHeroIconImg);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EC13 RID: 125971 RVA: 0x009F7518 File Offset: 0x009F5718
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_addExpPanelHeroIconImg(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailAddExpUIController heroDetailAddExpUIController = (HeroDetailAddExpUIController)LuaObject.checkSelf(l);
			Image addExpPanelHeroIconImg;
			LuaObject.checkType<Image>(l, 2, out addExpPanelHeroIconImg);
			heroDetailAddExpUIController.m_luaExportHelper.m_addExpPanelHeroIconImg = addExpPanelHeroIconImg;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EC14 RID: 125972 RVA: 0x009F7574 File Offset: 0x009F5774
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_addExpPanelExpValueText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailAddExpUIController heroDetailAddExpUIController = (HeroDetailAddExpUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailAddExpUIController.m_luaExportHelper.m_addExpPanelExpValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EC15 RID: 125973 RVA: 0x009F75CC File Offset: 0x009F57CC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_addExpPanelExpValueText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailAddExpUIController heroDetailAddExpUIController = (HeroDetailAddExpUIController)LuaObject.checkSelf(l);
			Text addExpPanelExpValueText;
			LuaObject.checkType<Text>(l, 2, out addExpPanelExpValueText);
			heroDetailAddExpUIController.m_luaExportHelper.m_addExpPanelExpValueText = addExpPanelExpValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EC16 RID: 125974 RVA: 0x009F7628 File Offset: 0x009F5828
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_addExpPanelExpProgressImg(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailAddExpUIController heroDetailAddExpUIController = (HeroDetailAddExpUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailAddExpUIController.m_luaExportHelper.m_addExpPanelExpProgressImg);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EC17 RID: 125975 RVA: 0x009F7680 File Offset: 0x009F5880
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_addExpPanelExpProgressImg(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailAddExpUIController heroDetailAddExpUIController = (HeroDetailAddExpUIController)LuaObject.checkSelf(l);
			Image addExpPanelExpProgressImg;
			LuaObject.checkType<Image>(l, 2, out addExpPanelExpProgressImg);
			heroDetailAddExpUIController.m_luaExportHelper.m_addExpPanelExpProgressImg = addExpPanelExpProgressImg;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EC18 RID: 125976 RVA: 0x009F76DC File Offset: 0x009F58DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_addExpPanelLevelUp3DEffect(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailAddExpUIController heroDetailAddExpUIController = (HeroDetailAddExpUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailAddExpUIController.m_luaExportHelper.m_addExpPanelLevelUp3DEffect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EC19 RID: 125977 RVA: 0x009F7734 File Offset: 0x009F5934
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_addExpPanelLevelUp3DEffect(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailAddExpUIController heroDetailAddExpUIController = (HeroDetailAddExpUIController)LuaObject.checkSelf(l);
			GameObject addExpPanelLevelUp3DEffect;
			LuaObject.checkType<GameObject>(l, 2, out addExpPanelLevelUp3DEffect);
			heroDetailAddExpUIController.m_luaExportHelper.m_addExpPanelLevelUp3DEffect = addExpPanelLevelUp3DEffect;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EC1A RID: 125978 RVA: 0x009F7790 File Offset: 0x009F5990
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_addExpPanelNoExpItemTip(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailAddExpUIController heroDetailAddExpUIController = (HeroDetailAddExpUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailAddExpUIController.m_luaExportHelper.m_addExpPanelNoExpItemTip);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EC1B RID: 125979 RVA: 0x009F77E8 File Offset: 0x009F59E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_addExpPanelNoExpItemTip(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailAddExpUIController heroDetailAddExpUIController = (HeroDetailAddExpUIController)LuaObject.checkSelf(l);
			GameObject addExpPanelNoExpItemTip;
			LuaObject.checkType<GameObject>(l, 2, out addExpPanelNoExpItemTip);
			heroDetailAddExpUIController.m_luaExportHelper.m_addExpPanelNoExpItemTip = addExpPanelNoExpItemTip;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EC1C RID: 125980 RVA: 0x009F7844 File Offset: 0x009F5A44
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_addExpConfirmPanel(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailAddExpUIController heroDetailAddExpUIController = (HeroDetailAddExpUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailAddExpUIController.m_luaExportHelper.m_addExpConfirmPanel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EC1D RID: 125981 RVA: 0x009F789C File Offset: 0x009F5A9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_addExpConfirmPanel(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailAddExpUIController heroDetailAddExpUIController = (HeroDetailAddExpUIController)LuaObject.checkSelf(l);
			GameObject addExpConfirmPanel;
			LuaObject.checkType<GameObject>(l, 2, out addExpConfirmPanel);
			heroDetailAddExpUIController.m_luaExportHelper.m_addExpConfirmPanel = addExpConfirmPanel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EC1E RID: 125982 RVA: 0x009F78F8 File Offset: 0x009F5AF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_addExpConfirmPanelTip1(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailAddExpUIController heroDetailAddExpUIController = (HeroDetailAddExpUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailAddExpUIController.m_luaExportHelper.m_addExpConfirmPanelTip1);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EC1F RID: 125983 RVA: 0x009F7950 File Offset: 0x009F5B50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_addExpConfirmPanelTip1(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailAddExpUIController heroDetailAddExpUIController = (HeroDetailAddExpUIController)LuaObject.checkSelf(l);
			Text addExpConfirmPanelTip;
			LuaObject.checkType<Text>(l, 2, out addExpConfirmPanelTip);
			heroDetailAddExpUIController.m_luaExportHelper.m_addExpConfirmPanelTip1 = addExpConfirmPanelTip;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EC20 RID: 125984 RVA: 0x009F79AC File Offset: 0x009F5BAC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_addExpConfirmPanelTip2(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailAddExpUIController heroDetailAddExpUIController = (HeroDetailAddExpUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailAddExpUIController.m_luaExportHelper.m_addExpConfirmPanelTip2);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EC21 RID: 125985 RVA: 0x009F7A04 File Offset: 0x009F5C04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_addExpConfirmPanelTip2(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailAddExpUIController heroDetailAddExpUIController = (HeroDetailAddExpUIController)LuaObject.checkSelf(l);
			Text addExpConfirmPanelTip;
			LuaObject.checkType<Text>(l, 2, out addExpConfirmPanelTip);
			heroDetailAddExpUIController.m_luaExportHelper.m_addExpConfirmPanelTip2 = addExpConfirmPanelTip;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EC22 RID: 125986 RVA: 0x009F7A60 File Offset: 0x009F5C60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_addExpConfirmPanelConfirmButton(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailAddExpUIController heroDetailAddExpUIController = (HeroDetailAddExpUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailAddExpUIController.m_luaExportHelper.m_addExpConfirmPanelConfirmButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EC23 RID: 125987 RVA: 0x009F7AB8 File Offset: 0x009F5CB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_addExpConfirmPanelConfirmButton(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailAddExpUIController heroDetailAddExpUIController = (HeroDetailAddExpUIController)LuaObject.checkSelf(l);
			Button addExpConfirmPanelConfirmButton;
			LuaObject.checkType<Button>(l, 2, out addExpConfirmPanelConfirmButton);
			heroDetailAddExpUIController.m_luaExportHelper.m_addExpConfirmPanelConfirmButton = addExpConfirmPanelConfirmButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EC24 RID: 125988 RVA: 0x009F7B14 File Offset: 0x009F5D14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_addExpConfirmPanelCancelButton(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailAddExpUIController heroDetailAddExpUIController = (HeroDetailAddExpUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailAddExpUIController.m_luaExportHelper.m_addExpConfirmPanelCancelButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EC25 RID: 125989 RVA: 0x009F7B6C File Offset: 0x009F5D6C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_addExpConfirmPanelCancelButton(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailAddExpUIController heroDetailAddExpUIController = (HeroDetailAddExpUIController)LuaObject.checkSelf(l);
			Button addExpConfirmPanelCancelButton;
			LuaObject.checkType<Button>(l, 2, out addExpConfirmPanelCancelButton);
			heroDetailAddExpUIController.m_luaExportHelper.m_addExpConfirmPanelCancelButton = addExpConfirmPanelCancelButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EC26 RID: 125990 RVA: 0x009F7BC8 File Offset: 0x009F5DC8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_addExpConfirmPanelBgButton(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailAddExpUIController heroDetailAddExpUIController = (HeroDetailAddExpUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailAddExpUIController.m_luaExportHelper.m_addExpConfirmPanelBgButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EC27 RID: 125991 RVA: 0x009F7C20 File Offset: 0x009F5E20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_addExpConfirmPanelBgButton(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailAddExpUIController heroDetailAddExpUIController = (HeroDetailAddExpUIController)LuaObject.checkSelf(l);
			Button addExpConfirmPanelBgButton;
			LuaObject.checkType<Button>(l, 2, out addExpConfirmPanelBgButton);
			heroDetailAddExpUIController.m_luaExportHelper.m_addExpConfirmPanelBgButton = addExpConfirmPanelBgButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EC28 RID: 125992 RVA: 0x009F7C7C File Offset: 0x009F5E7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnReturn(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailAddExpUIController heroDetailAddExpUIController = (HeroDetailAddExpUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					heroDetailAddExpUIController.EventOnReturn += value;
				}
				else if (num == 2)
				{
					heroDetailAddExpUIController.EventOnReturn -= value;
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

	// Token: 0x0601EC29 RID: 125993 RVA: 0x009F7CFC File Offset: 0x009F5EFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnHeroAddExp(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailAddExpUIController heroDetailAddExpUIController = (HeroDetailAddExpUIController)LuaObject.checkSelf(l);
			Action<int, BagItemBase, int, Action> value;
			int num = LuaObject.checkDelegate<Action<int, BagItemBase, int, Action>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					heroDetailAddExpUIController.EventOnHeroAddExp += value;
				}
				else if (num == 2)
				{
					heroDetailAddExpUIController.EventOnHeroAddExp -= value;
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

	// Token: 0x0601EC2A RID: 125994 RVA: 0x009F7D7C File Offset: 0x009F5F7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isHeroLvUp(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailAddExpUIController heroDetailAddExpUIController = (HeroDetailAddExpUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailAddExpUIController.m_luaExportHelper.m_isHeroLvUp);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EC2B RID: 125995 RVA: 0x009F7DD4 File Offset: 0x009F5FD4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_isHeroLvUp(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailAddExpUIController heroDetailAddExpUIController = (HeroDetailAddExpUIController)LuaObject.checkSelf(l);
			bool isHeroLvUp;
			LuaObject.checkType(l, 2, out isHeroLvUp);
			heroDetailAddExpUIController.m_luaExportHelper.m_isHeroLvUp = isHeroLvUp;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EC2C RID: 125996 RVA: 0x009F7E30 File Offset: 0x009F6030
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isFirstIn(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailAddExpUIController heroDetailAddExpUIController = (HeroDetailAddExpUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailAddExpUIController.m_luaExportHelper.m_isFirstIn);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EC2D RID: 125997 RVA: 0x009F7E88 File Offset: 0x009F6088
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isFirstIn(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailAddExpUIController heroDetailAddExpUIController = (HeroDetailAddExpUIController)LuaObject.checkSelf(l);
			bool isFirstIn;
			LuaObject.checkType(l, 2, out isFirstIn);
			heroDetailAddExpUIController.m_luaExportHelper.m_isFirstIn = isFirstIn;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EC2E RID: 125998 RVA: 0x009F7EE4 File Offset: 0x009F60E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_canLastClickExpItemUse(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailAddExpUIController heroDetailAddExpUIController = (HeroDetailAddExpUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailAddExpUIController.m_luaExportHelper.m_canLastClickExpItemUse);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EC2F RID: 125999 RVA: 0x009F7F3C File Offset: 0x009F613C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_canLastClickExpItemUse(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailAddExpUIController heroDetailAddExpUIController = (HeroDetailAddExpUIController)LuaObject.checkSelf(l);
			bool canLastClickExpItemUse;
			LuaObject.checkType(l, 2, out canLastClickExpItemUse);
			heroDetailAddExpUIController.m_luaExportHelper.m_canLastClickExpItemUse = canLastClickExpItemUse;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EC30 RID: 126000 RVA: 0x009F7F98 File Offset: 0x009F6198
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_hero(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailAddExpUIController heroDetailAddExpUIController = (HeroDetailAddExpUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailAddExpUIController.m_luaExportHelper.m_hero);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EC31 RID: 126001 RVA: 0x009F7FF0 File Offset: 0x009F61F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_hero(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailAddExpUIController heroDetailAddExpUIController = (HeroDetailAddExpUIController)LuaObject.checkSelf(l);
			Hero hero;
			LuaObject.checkType<Hero>(l, 2, out hero);
			heroDetailAddExpUIController.m_luaExportHelper.m_hero = hero;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EC32 RID: 126002 RVA: 0x009F804C File Offset: 0x009F624C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_expProgressBarWidth2(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailAddExpUIController heroDetailAddExpUIController = (HeroDetailAddExpUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailAddExpUIController.m_luaExportHelper.m_expProgressBarWidth2);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EC33 RID: 126003 RVA: 0x009F80A4 File Offset: 0x009F62A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_expProgressBarWidth2(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailAddExpUIController heroDetailAddExpUIController = (HeroDetailAddExpUIController)LuaObject.checkSelf(l);
			float expProgressBarWidth;
			LuaObject.checkType(l, 2, out expProgressBarWidth);
			heroDetailAddExpUIController.m_luaExportHelper.m_expProgressBarWidth2 = expProgressBarWidth;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EC34 RID: 126004 RVA: 0x009F8100 File Offset: 0x009F6300
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_totalUseExpItemCount(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailAddExpUIController heroDetailAddExpUIController = (HeroDetailAddExpUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailAddExpUIController.m_luaExportHelper.m_totalUseExpItemCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EC35 RID: 126005 RVA: 0x009F8158 File Offset: 0x009F6358
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_totalUseExpItemCount(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailAddExpUIController heroDetailAddExpUIController = (HeroDetailAddExpUIController)LuaObject.checkSelf(l);
			int totalUseExpItemCount;
			LuaObject.checkType(l, 2, out totalUseExpItemCount);
			heroDetailAddExpUIController.m_luaExportHelper.m_totalUseExpItemCount = totalUseExpItemCount;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EC36 RID: 126006 RVA: 0x009F81B4 File Offset: 0x009F63B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_tempHeroLevel(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailAddExpUIController heroDetailAddExpUIController = (HeroDetailAddExpUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailAddExpUIController.m_luaExportHelper.m_tempHeroLevel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EC37 RID: 126007 RVA: 0x009F820C File Offset: 0x009F640C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_tempHeroLevel(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailAddExpUIController heroDetailAddExpUIController = (HeroDetailAddExpUIController)LuaObject.checkSelf(l);
			int tempHeroLevel;
			LuaObject.checkType(l, 2, out tempHeroLevel);
			heroDetailAddExpUIController.m_luaExportHelper.m_tempHeroLevel = tempHeroLevel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EC38 RID: 126008 RVA: 0x009F8268 File Offset: 0x009F6468
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_tempHeroExp(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailAddExpUIController heroDetailAddExpUIController = (HeroDetailAddExpUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailAddExpUIController.m_luaExportHelper.m_tempHeroExp);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EC39 RID: 126009 RVA: 0x009F82C0 File Offset: 0x009F64C0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_tempHeroExp(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailAddExpUIController heroDetailAddExpUIController = (HeroDetailAddExpUIController)LuaObject.checkSelf(l);
			int tempHeroExp;
			LuaObject.checkType(l, 2, out tempHeroExp);
			heroDetailAddExpUIController.m_luaExportHelper.m_tempHeroExp = tempHeroExp;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EC3A RID: 126010 RVA: 0x009F831C File Offset: 0x009F651C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_tempAddExp(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailAddExpUIController heroDetailAddExpUIController = (HeroDetailAddExpUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailAddExpUIController.m_luaExportHelper.m_tempAddExp);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EC3B RID: 126011 RVA: 0x009F8374 File Offset: 0x009F6574
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_tempAddExp(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailAddExpUIController heroDetailAddExpUIController = (HeroDetailAddExpUIController)LuaObject.checkSelf(l);
			int tempAddExp;
			LuaObject.checkType(l, 2, out tempAddExp);
			heroDetailAddExpUIController.m_luaExportHelper.m_tempAddExp = tempAddExp;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EC3C RID: 126012 RVA: 0x009F83D0 File Offset: 0x009F65D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroLastLevel(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailAddExpUIController heroDetailAddExpUIController = (HeroDetailAddExpUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailAddExpUIController.m_luaExportHelper.m_heroLastLevel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EC3D RID: 126013 RVA: 0x009F8428 File Offset: 0x009F6628
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroLastLevel(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailAddExpUIController heroDetailAddExpUIController = (HeroDetailAddExpUIController)LuaObject.checkSelf(l);
			int heroLastLevel;
			LuaObject.checkType(l, 2, out heroLastLevel);
			heroDetailAddExpUIController.m_luaExportHelper.m_heroLastLevel = heroLastLevel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EC3E RID: 126014 RVA: 0x009F8484 File Offset: 0x009F6684
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_curExpBagItemCtrl(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailAddExpUIController heroDetailAddExpUIController = (HeroDetailAddExpUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailAddExpUIController.m_luaExportHelper.m_curExpBagItemCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EC3F RID: 126015 RVA: 0x009F84DC File Offset: 0x009F66DC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_curExpBagItemCtrl(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailAddExpUIController heroDetailAddExpUIController = (HeroDetailAddExpUIController)LuaObject.checkSelf(l);
			HeroExpItemUIController curExpBagItemCtrl;
			LuaObject.checkType<HeroExpItemUIController>(l, 2, out curExpBagItemCtrl);
			heroDetailAddExpUIController.m_luaExportHelper.m_curExpBagItemCtrl = curExpBagItemCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EC40 RID: 126016 RVA: 0x009F8538 File Offset: 0x009F6738
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_expCtrlList(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailAddExpUIController heroDetailAddExpUIController = (HeroDetailAddExpUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailAddExpUIController.m_expCtrlList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EC41 RID: 126017 RVA: 0x009F858C File Offset: 0x009F678C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_expCtrlList(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailAddExpUIController heroDetailAddExpUIController = (HeroDetailAddExpUIController)LuaObject.checkSelf(l);
			List<HeroExpItemUIController> expCtrlList;
			LuaObject.checkType<List<HeroExpItemUIController>>(l, 2, out expCtrlList);
			heroDetailAddExpUIController.m_expCtrlList = expCtrlList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EC42 RID: 126018 RVA: 0x009F85E4 File Offset: 0x009F67E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailAddExpUIController heroDetailAddExpUIController = (HeroDetailAddExpUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailAddExpUIController.m_luaExportHelper.m_playerContext);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EC43 RID: 126019 RVA: 0x009F863C File Offset: 0x009F683C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailAddExpUIController heroDetailAddExpUIController = (HeroDetailAddExpUIController)LuaObject.checkSelf(l);
			ProjectLPlayerContext playerContext;
			LuaObject.checkType<ProjectLPlayerContext>(l, 2, out playerContext);
			heroDetailAddExpUIController.m_luaExportHelper.m_playerContext = playerContext;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EC44 RID: 126020 RVA: 0x009F8698 File Offset: 0x009F6898
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailAddExpUIController heroDetailAddExpUIController = (HeroDetailAddExpUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailAddExpUIController.m_luaExportHelper.m_configDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EC45 RID: 126021 RVA: 0x009F86F0 File Offset: 0x009F68F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailAddExpUIController heroDetailAddExpUIController = (HeroDetailAddExpUIController)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			heroDetailAddExpUIController.m_luaExportHelper.m_configDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EC46 RID: 126022 RVA: 0x009F874C File Offset: 0x009F694C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_addImageCoroutineCount(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailAddExpUIController heroDetailAddExpUIController = (HeroDetailAddExpUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailAddExpUIController.m_luaExportHelper.m_addImageCoroutineCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EC47 RID: 126023 RVA: 0x009F87A4 File Offset: 0x009F69A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_addImageCoroutineCount(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailAddExpUIController heroDetailAddExpUIController = (HeroDetailAddExpUIController)LuaObject.checkSelf(l);
			int addImageCoroutineCount;
			LuaObject.checkType(l, 2, out addImageCoroutineCount);
			heroDetailAddExpUIController.m_luaExportHelper.m_addImageCoroutineCount = addImageCoroutineCount;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EC48 RID: 126024 RVA: 0x009F8800 File Offset: 0x009F6A00
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.HeroDetailAddExpUIController");
		if (Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.UpdateViewInAddExpState);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.UpdateAddExpPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.UseFirstExpBagItemForUserGuide);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.HeroAddExpLvUpEffect);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.OnExpItemClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.LocalAddExpTick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.AddProgressImageWidth);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.OnLocalAddExpFinishedSendReq);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.WaitTimeThenDoEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.CanExpItemUse);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.OnAddExpConfirmButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.OnAddExpCanelButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.CloseAddExpPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.__callDele_EventOnReturn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.__clearDele_EventOnReturn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.__callDele_EventOnHeroAddExp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.__clearDele_EventOnHeroAddExp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache1E);
		string name = "m_rootGo";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.get_m_rootGo);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache1F;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.set_m_rootGo);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache20, true);
		string name2 = "m_closeAddExpButton";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.get_m_closeAddExpButton);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache21;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.set_m_closeAddExpButton);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache22, true);
		string name3 = "m_addExpScrollViewContent";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.get_m_addExpScrollViewContent);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache23;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.set_m_addExpScrollViewContent);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache24, true);
		string name4 = "m_addExpPanelLvValueText";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.get_m_addExpPanelLvValueText);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache25;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.set_m_addExpPanelLvValueText);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache26, true);
		string name5 = "m_addExpPanelLvValueMaxText";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.get_m_addExpPanelLvValueMaxText);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache27;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.set_m_addExpPanelLvValueMaxText);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache28, true);
		string name6 = "m_addExpPanelHeroNameText";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.get_m_addExpPanelHeroNameText);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache29;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.set_m_addExpPanelHeroNameText);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache2A, true);
		string name7 = "m_addExpPanelLevelUpEffect";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.get_m_addExpPanelLevelUpEffect);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache2B;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.set_m_addExpPanelLevelUpEffect);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache2C, true);
		string name8 = "m_addExpPanelHeroIconImg";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.get_m_addExpPanelHeroIconImg);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache2D;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.set_m_addExpPanelHeroIconImg);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache2E, true);
		string name9 = "m_addExpPanelExpValueText";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.get_m_addExpPanelExpValueText);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache2F;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.set_m_addExpPanelExpValueText);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache30, true);
		string name10 = "m_addExpPanelExpProgressImg";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.get_m_addExpPanelExpProgressImg);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache31;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.set_m_addExpPanelExpProgressImg);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache32, true);
		string name11 = "m_addExpPanelLevelUp3DEffect";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.get_m_addExpPanelLevelUp3DEffect);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache33;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.set_m_addExpPanelLevelUp3DEffect);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache34, true);
		string name12 = "m_addExpPanelNoExpItemTip";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.get_m_addExpPanelNoExpItemTip);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache35;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.set_m_addExpPanelNoExpItemTip);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache36, true);
		string name13 = "m_addExpConfirmPanel";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.get_m_addExpConfirmPanel);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache37;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.set_m_addExpConfirmPanel);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache38, true);
		string name14 = "m_addExpConfirmPanelTip1";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.get_m_addExpConfirmPanelTip1);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache39;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.set_m_addExpConfirmPanelTip1);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache3A, true);
		string name15 = "m_addExpConfirmPanelTip2";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.get_m_addExpConfirmPanelTip2);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache3B;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.set_m_addExpConfirmPanelTip2);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache3C, true);
		string name16 = "m_addExpConfirmPanelConfirmButton";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.get_m_addExpConfirmPanelConfirmButton);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache3D;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.set_m_addExpConfirmPanelConfirmButton);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache3E, true);
		string name17 = "m_addExpConfirmPanelCancelButton";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.get_m_addExpConfirmPanelCancelButton);
		}
		LuaCSFunction get17 = Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache3F;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.set_m_addExpConfirmPanelCancelButton);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache40, true);
		string name18 = "m_addExpConfirmPanelBgButton";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.get_m_addExpConfirmPanelBgButton);
		}
		LuaCSFunction get18 = Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache41;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.set_m_addExpConfirmPanelBgButton);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache42, true);
		string name19 = "EventOnReturn";
		LuaCSFunction get19 = null;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.set_EventOnReturn);
		}
		LuaObject.addMember(l, name19, get19, Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache43, true);
		string name20 = "EventOnHeroAddExp";
		LuaCSFunction get20 = null;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.set_EventOnHeroAddExp);
		}
		LuaObject.addMember(l, name20, get20, Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache44, true);
		string name21 = "m_isHeroLvUp";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.get_m_isHeroLvUp);
		}
		LuaCSFunction get21 = Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache45;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache46 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache46 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.set_m_isHeroLvUp);
		}
		LuaObject.addMember(l, name21, get21, Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache46, true);
		string name22 = "m_isFirstIn";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache47 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache47 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.get_m_isFirstIn);
		}
		LuaCSFunction get22 = Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache47;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache48 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache48 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.set_m_isFirstIn);
		}
		LuaObject.addMember(l, name22, get22, Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache48, true);
		string name23 = "m_canLastClickExpItemUse";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache49 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache49 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.get_m_canLastClickExpItemUse);
		}
		LuaCSFunction get23 = Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache49;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache4A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache4A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.set_m_canLastClickExpItemUse);
		}
		LuaObject.addMember(l, name23, get23, Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache4A, true);
		string name24 = "m_hero";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache4B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache4B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.get_m_hero);
		}
		LuaCSFunction get24 = Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache4B;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache4C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache4C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.set_m_hero);
		}
		LuaObject.addMember(l, name24, get24, Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache4C, true);
		string name25 = "m_expProgressBarWidth2";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache4D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache4D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.get_m_expProgressBarWidth2);
		}
		LuaCSFunction get25 = Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache4D;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache4E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache4E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.set_m_expProgressBarWidth2);
		}
		LuaObject.addMember(l, name25, get25, Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache4E, true);
		string name26 = "m_totalUseExpItemCount";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache4F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache4F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.get_m_totalUseExpItemCount);
		}
		LuaCSFunction get26 = Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache4F;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache50 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache50 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.set_m_totalUseExpItemCount);
		}
		LuaObject.addMember(l, name26, get26, Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache50, true);
		string name27 = "m_tempHeroLevel";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache51 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache51 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.get_m_tempHeroLevel);
		}
		LuaCSFunction get27 = Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache51;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache52 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache52 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.set_m_tempHeroLevel);
		}
		LuaObject.addMember(l, name27, get27, Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache52, true);
		string name28 = "m_tempHeroExp";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache53 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache53 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.get_m_tempHeroExp);
		}
		LuaCSFunction get28 = Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache53;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache54 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache54 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.set_m_tempHeroExp);
		}
		LuaObject.addMember(l, name28, get28, Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache54, true);
		string name29 = "m_tempAddExp";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache55 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache55 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.get_m_tempAddExp);
		}
		LuaCSFunction get29 = Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache55;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache56 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache56 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.set_m_tempAddExp);
		}
		LuaObject.addMember(l, name29, get29, Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache56, true);
		string name30 = "m_heroLastLevel";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache57 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache57 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.get_m_heroLastLevel);
		}
		LuaCSFunction get30 = Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache57;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache58 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache58 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.set_m_heroLastLevel);
		}
		LuaObject.addMember(l, name30, get30, Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache58, true);
		string name31 = "m_curExpBagItemCtrl";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache59 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache59 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.get_m_curExpBagItemCtrl);
		}
		LuaCSFunction get31 = Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache59;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache5A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache5A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.set_m_curExpBagItemCtrl);
		}
		LuaObject.addMember(l, name31, get31, Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache5A, true);
		string name32 = "m_expCtrlList";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache5B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache5B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.get_m_expCtrlList);
		}
		LuaCSFunction get32 = Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache5B;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache5C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache5C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.set_m_expCtrlList);
		}
		LuaObject.addMember(l, name32, get32, Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache5C, true);
		string name33 = "m_playerContext";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache5D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache5D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.get_m_playerContext);
		}
		LuaCSFunction get33 = Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache5D;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache5E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache5E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.set_m_playerContext);
		}
		LuaObject.addMember(l, name33, get33, Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache5E, true);
		string name34 = "m_configDataLoader";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache5F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache5F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.get_m_configDataLoader);
		}
		LuaCSFunction get34 = Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache5F;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache60 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache60 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.set_m_configDataLoader);
		}
		LuaObject.addMember(l, name34, get34, Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache60, true);
		string name35 = "m_addImageCoroutineCount";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache61 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache61 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.get_m_addImageCoroutineCount);
		}
		LuaCSFunction get35 = Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache61;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache62 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache62 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.set_m_addImageCoroutineCount);
		}
		LuaObject.addMember(l, name35, get35, Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.<>f__mg$cache62, true);
		LuaObject.createTypeMetatable(l, null, typeof(HeroDetailAddExpUIController), typeof(UIControllerBase));
	}

	// Token: 0x04014C65 RID: 85093
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04014C66 RID: 85094
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04014C67 RID: 85095
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04014C68 RID: 85096
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04014C69 RID: 85097
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04014C6A RID: 85098
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04014C6B RID: 85099
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04014C6C RID: 85100
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04014C6D RID: 85101
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04014C6E RID: 85102
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04014C6F RID: 85103
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04014C70 RID: 85104
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04014C71 RID: 85105
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04014C72 RID: 85106
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04014C73 RID: 85107
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04014C74 RID: 85108
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04014C75 RID: 85109
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04014C76 RID: 85110
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04014C77 RID: 85111
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04014C78 RID: 85112
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04014C79 RID: 85113
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04014C7A RID: 85114
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04014C7B RID: 85115
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04014C7C RID: 85116
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04014C7D RID: 85117
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04014C7E RID: 85118
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04014C7F RID: 85119
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04014C80 RID: 85120
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04014C81 RID: 85121
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04014C82 RID: 85122
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04014C83 RID: 85123
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04014C84 RID: 85124
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04014C85 RID: 85125
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04014C86 RID: 85126
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04014C87 RID: 85127
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04014C88 RID: 85128
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04014C89 RID: 85129
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04014C8A RID: 85130
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04014C8B RID: 85131
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04014C8C RID: 85132
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04014C8D RID: 85133
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04014C8E RID: 85134
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04014C8F RID: 85135
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04014C90 RID: 85136
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04014C91 RID: 85137
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04014C92 RID: 85138
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04014C93 RID: 85139
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04014C94 RID: 85140
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04014C95 RID: 85141
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04014C96 RID: 85142
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04014C97 RID: 85143
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x04014C98 RID: 85144
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x04014C99 RID: 85145
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x04014C9A RID: 85146
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x04014C9B RID: 85147
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x04014C9C RID: 85148
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x04014C9D RID: 85149
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x04014C9E RID: 85150
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x04014C9F RID: 85151
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x04014CA0 RID: 85152
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x04014CA1 RID: 85153
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x04014CA2 RID: 85154
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x04014CA3 RID: 85155
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x04014CA4 RID: 85156
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x04014CA5 RID: 85157
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x04014CA6 RID: 85158
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x04014CA7 RID: 85159
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x04014CA8 RID: 85160
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x04014CA9 RID: 85161
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x04014CAA RID: 85162
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x04014CAB RID: 85163
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;

	// Token: 0x04014CAC RID: 85164
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache47;

	// Token: 0x04014CAD RID: 85165
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache48;

	// Token: 0x04014CAE RID: 85166
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache49;

	// Token: 0x04014CAF RID: 85167
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4A;

	// Token: 0x04014CB0 RID: 85168
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4B;

	// Token: 0x04014CB1 RID: 85169
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4C;

	// Token: 0x04014CB2 RID: 85170
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4D;

	// Token: 0x04014CB3 RID: 85171
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4E;

	// Token: 0x04014CB4 RID: 85172
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4F;

	// Token: 0x04014CB5 RID: 85173
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache50;

	// Token: 0x04014CB6 RID: 85174
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache51;

	// Token: 0x04014CB7 RID: 85175
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache52;

	// Token: 0x04014CB8 RID: 85176
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache53;

	// Token: 0x04014CB9 RID: 85177
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache54;

	// Token: 0x04014CBA RID: 85178
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache55;

	// Token: 0x04014CBB RID: 85179
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache56;

	// Token: 0x04014CBC RID: 85180
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache57;

	// Token: 0x04014CBD RID: 85181
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache58;

	// Token: 0x04014CBE RID: 85182
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache59;

	// Token: 0x04014CBF RID: 85183
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5A;

	// Token: 0x04014CC0 RID: 85184
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5B;

	// Token: 0x04014CC1 RID: 85185
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5C;

	// Token: 0x04014CC2 RID: 85186
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5D;

	// Token: 0x04014CC3 RID: 85187
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5E;

	// Token: 0x04014CC4 RID: 85188
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5F;

	// Token: 0x04014CC5 RID: 85189
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache60;

	// Token: 0x04014CC6 RID: 85190
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache61;

	// Token: 0x04014CC7 RID: 85191
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache62;
}
