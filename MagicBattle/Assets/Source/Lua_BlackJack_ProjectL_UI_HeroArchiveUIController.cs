using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.Scene;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x0200149E RID: 5278
[Preserve]
public class Lua_BlackJack_ProjectL_UI_HeroArchiveUIController : LuaObject
{
	// Token: 0x0601E8B5 RID: 125109 RVA: 0x009DCF38 File Offset: 0x009DB138
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetTask(IntPtr l)
	{
		int result;
		try
		{
			HeroArchiveUIController heroArchiveUIController = (HeroArchiveUIController)LuaObject.checkSelf(l);
			ArchiveUITask task;
			LuaObject.checkType<ArchiveUITask>(l, 2, out task);
			heroArchiveUIController.SetTask(task);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E8B6 RID: 125110 RVA: 0x009DCF90 File Offset: 0x009DB190
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int EnterController(IntPtr l)
	{
		int result;
		try
		{
			HeroArchiveUIController heroArchiveUIController = (HeroArchiveUIController)LuaObject.checkSelf(l);
			heroArchiveUIController.EnterController();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E8B7 RID: 125111 RVA: 0x009DCFDC File Offset: 0x009DB1DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HeroCountRefresh(IntPtr l)
	{
		int result;
		try
		{
			HeroArchiveUIController heroArchiveUIController = (HeroArchiveUIController)LuaObject.checkSelf(l);
			int ownCount;
			LuaObject.checkType(l, 2, out ownCount);
			int maxCount;
			LuaObject.checkType(l, 3, out maxCount);
			heroArchiveUIController.HeroCountRefresh(ownCount, maxCount);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E8B8 RID: 125112 RVA: 0x009DD040 File Offset: 0x009DB240
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CreateHeroGraphic(IntPtr l)
	{
		int result;
		try
		{
			HeroArchiveUIController heroArchiveUIController = (HeroArchiveUIController)LuaObject.checkSelf(l);
			HeroArchiveUIController.HeroWrap heroWrap;
			LuaObject.checkType<HeroArchiveUIController.HeroWrap>(l, 2, out heroWrap);
			heroArchiveUIController.CreateHeroGraphic(heroWrap);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E8B9 RID: 125113 RVA: 0x009DD098 File Offset: 0x009DB298
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			HeroArchiveUIController heroArchiveUIController = (HeroArchiveUIController)LuaObject.checkSelf(l);
			heroArchiveUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E8BA RID: 125114 RVA: 0x009DD0EC File Offset: 0x009DB2EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HeroListCompare(IntPtr l)
	{
		int result;
		try
		{
			HeroArchiveUIController heroArchiveUIController = (HeroArchiveUIController)LuaObject.checkSelf(l);
			HeroArchiveUIController.HeroWrap heroWrap;
			LuaObject.checkType<HeroArchiveUIController.HeroWrap>(l, 2, out heroWrap);
			HeroArchiveUIController.HeroWrap heroWrap2;
			LuaObject.checkType<HeroArchiveUIController.HeroWrap>(l, 3, out heroWrap2);
			int i = heroArchiveUIController.m_luaExportHelper.HeroListCompare(heroWrap, heroWrap2);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E8BB RID: 125115 RVA: 0x009DD160 File Offset: 0x009DB360
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetHeroFinalJobList(IntPtr l)
	{
		int result;
		try
		{
			HeroArchiveUIController heroArchiveUIController = (HeroArchiveUIController)LuaObject.checkSelf(l);
			ConfigDataHeroInfo heroInfo;
			LuaObject.checkType<ConfigDataHeroInfo>(l, 2, out heroInfo);
			List<ConfigDataJobConnectionInfo> heroFinalJobList = heroArchiveUIController.m_luaExportHelper.GetHeroFinalJobList(heroInfo);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroFinalJobList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E8BC RID: 125116 RVA: 0x009DD1C8 File Offset: 0x009DB3C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HeroDrawRefresh(IntPtr l)
	{
		int result;
		try
		{
			HeroArchiveUIController heroArchiveUIController = (HeroArchiveUIController)LuaObject.checkSelf(l);
			HeroHeadUIController heroHeadUIController;
			LuaObject.checkType<HeroHeadUIController>(l, 2, out heroHeadUIController);
			heroArchiveUIController.m_luaExportHelper.HeroDrawRefresh(heroHeadUIController);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E8BD RID: 125117 RVA: 0x009DD224 File Offset: 0x009DB424
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CreateHeroHeadList(IntPtr l)
	{
		int result;
		try
		{
			HeroArchiveUIController heroArchiveUIController = (HeroArchiveUIController)LuaObject.checkSelf(l);
			List<HeroArchiveUIController.HeroWrap> heroList;
			LuaObject.checkType<List<HeroArchiveUIController.HeroWrap>>(l, 2, out heroList);
			heroArchiveUIController.m_luaExportHelper.CreateHeroHeadList(heroList);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E8BE RID: 125118 RVA: 0x009DD280 File Offset: 0x009DB480
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DestroyHeroHeadList(IntPtr l)
	{
		int result;
		try
		{
			HeroArchiveUIController heroArchiveUIController = (HeroArchiveUIController)LuaObject.checkSelf(l);
			heroArchiveUIController.m_luaExportHelper.DestroyHeroHeadList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E8BF RID: 125119 RVA: 0x009DD2D4 File Offset: 0x009DB4D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RefreshHeroHeadWithHeroData(IntPtr l)
	{
		int result;
		try
		{
			HeroArchiveUIController heroArchiveUIController = (HeroArchiveUIController)LuaObject.checkSelf(l);
			HeroArchiveUIController.HeroWrap heroWrap;
			LuaObject.checkType<HeroArchiveUIController.HeroWrap>(l, 2, out heroWrap);
			heroArchiveUIController.m_luaExportHelper.RefreshHeroHeadWithHeroData(heroWrap);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E8C0 RID: 125120 RVA: 0x009DD330 File Offset: 0x009DB530
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnReturnClick(IntPtr l)
	{
		int result;
		try
		{
			HeroArchiveUIController heroArchiveUIController = (HeroArchiveUIController)LuaObject.checkSelf(l);
			heroArchiveUIController.m_luaExportHelper.OnReturnClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E8C1 RID: 125121 RVA: 0x009DD384 File Offset: 0x009DB584
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnCharFilterClick(IntPtr l)
	{
		int result;
		try
		{
			HeroArchiveUIController heroArchiveUIController = (HeroArchiveUIController)LuaObject.checkSelf(l);
			GameObject obj;
			LuaObject.checkType<GameObject>(l, 2, out obj);
			heroArchiveUIController.m_luaExportHelper.OnCharFilterClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E8C2 RID: 125122 RVA: 0x009DD3E0 File Offset: 0x009DB5E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnHeroHeadClick(IntPtr l)
	{
		int result;
		try
		{
			HeroArchiveUIController heroArchiveUIController = (HeroArchiveUIController)LuaObject.checkSelf(l);
			HeroHeadUIController heroHeadUIController;
			LuaObject.checkType<HeroHeadUIController>(l, 2, out heroHeadUIController);
			heroArchiveUIController.m_luaExportHelper.OnHeroHeadClick(heroHeadUIController);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E8C3 RID: 125123 RVA: 0x009DD43C File Offset: 0x009DB63C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnHeroShowClick(IntPtr l)
	{
		int result;
		try
		{
			HeroArchiveUIController heroArchiveUIController = (HeroArchiveUIController)LuaObject.checkSelf(l);
			heroArchiveUIController.m_luaExportHelper.OnHeroShowClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E8C4 RID: 125124 RVA: 0x009DD490 File Offset: 0x009DB690
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnHeroHeadListRefresh(IntPtr l)
	{
		int result;
		try
		{
			HeroArchiveUIController heroArchiveUIController = (HeroArchiveUIController)LuaObject.checkSelf(l);
			int index;
			LuaObject.checkType(l, 2, out index);
			Transform trans;
			LuaObject.checkType<Transform>(l, 3, out trans);
			heroArchiveUIController.m_luaExportHelper.OnHeroHeadListRefresh(index, trans);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E8C5 RID: 125125 RVA: 0x009DD4FC File Offset: 0x009DB6FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			HeroArchiveUIController heroArchiveUIController = (HeroArchiveUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			heroArchiveUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E8C6 RID: 125126 RVA: 0x009DD568 File Offset: 0x009DB768
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			HeroArchiveUIController heroArchiveUIController = (HeroArchiveUIController)LuaObject.checkSelf(l);
			heroArchiveUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E8C7 RID: 125127 RVA: 0x009DD5BC File Offset: 0x009DB7BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			HeroArchiveUIController heroArchiveUIController = (HeroArchiveUIController)LuaObject.checkSelf(l);
			heroArchiveUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E8C8 RID: 125128 RVA: 0x009DD610 File Offset: 0x009DB810
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			HeroArchiveUIController heroArchiveUIController = (HeroArchiveUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = heroArchiveUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601E8C9 RID: 125129 RVA: 0x009DD6B8 File Offset: 0x009DB8B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			HeroArchiveUIController heroArchiveUIController = (HeroArchiveUIController)LuaObject.checkSelf(l);
			heroArchiveUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E8CA RID: 125130 RVA: 0x009DD70C File Offset: 0x009DB90C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroArchiveUIController heroArchiveUIController = (HeroArchiveUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			heroArchiveUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E8CB RID: 125131 RVA: 0x009DD778 File Offset: 0x009DB978
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
				HeroArchiveUIController heroArchiveUIController = (HeroArchiveUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				heroArchiveUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				HeroArchiveUIController heroArchiveUIController2 = (HeroArchiveUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				heroArchiveUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601E8CC RID: 125132 RVA: 0x009DD888 File Offset: 0x009DBA88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			HeroArchiveUIController heroArchiveUIController = (HeroArchiveUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroArchiveUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E8CD RID: 125133 RVA: 0x009DD8F4 File Offset: 0x009DBAF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			HeroArchiveUIController heroArchiveUIController = (HeroArchiveUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroArchiveUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E8CE RID: 125134 RVA: 0x009DD960 File Offset: 0x009DBB60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			HeroArchiveUIController heroArchiveUIController = (HeroArchiveUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroArchiveUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E8CF RID: 125135 RVA: 0x009DD9CC File Offset: 0x009DBBCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			HeroArchiveUIController heroArchiveUIController = (HeroArchiveUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroArchiveUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E8D0 RID: 125136 RVA: 0x009DDA38 File Offset: 0x009DBC38
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
				HeroArchiveUIController heroArchiveUIController = (HeroArchiveUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				heroArchiveUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				HeroArchiveUIController heroArchiveUIController2 = (HeroArchiveUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				heroArchiveUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601E8D1 RID: 125137 RVA: 0x009DDB48 File Offset: 0x009DBD48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			HeroArchiveUIController heroArchiveUIController = (HeroArchiveUIController)LuaObject.checkSelf(l);
			string s = heroArchiveUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601E8D2 RID: 125138 RVA: 0x009DDBA4 File Offset: 0x009DBDA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_prefabAnimation(IntPtr l)
	{
		int result;
		try
		{
			HeroArchiveUIController heroArchiveUIController = (HeroArchiveUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroArchiveUIController.m_luaExportHelper.m_prefabAnimation);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E8D3 RID: 125139 RVA: 0x009DDBFC File Offset: 0x009DBDFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_prefabAnimation(IntPtr l)
	{
		int result;
		try
		{
			HeroArchiveUIController heroArchiveUIController = (HeroArchiveUIController)LuaObject.checkSelf(l);
			CommonUIStateController prefabAnimation;
			LuaObject.checkType<CommonUIStateController>(l, 2, out prefabAnimation);
			heroArchiveUIController.m_luaExportHelper.m_prefabAnimation = prefabAnimation;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E8D4 RID: 125140 RVA: 0x009DDC58 File Offset: 0x009DBE58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_returnButton(IntPtr l)
	{
		int result;
		try
		{
			HeroArchiveUIController heroArchiveUIController = (HeroArchiveUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroArchiveUIController.m_luaExportHelper.m_returnButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E8D5 RID: 125141 RVA: 0x009DDCB0 File Offset: 0x009DBEB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_returnButton(IntPtr l)
	{
		int result;
		try
		{
			HeroArchiveUIController heroArchiveUIController = (HeroArchiveUIController)LuaObject.checkSelf(l);
			Button returnButton;
			LuaObject.checkType<Button>(l, 2, out returnButton);
			heroArchiveUIController.m_luaExportHelper.m_returnButton = returnButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E8D6 RID: 125142 RVA: 0x009DDD0C File Offset: 0x009DBF0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroShowButton(IntPtr l)
	{
		int result;
		try
		{
			HeroArchiveUIController heroArchiveUIController = (HeroArchiveUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroArchiveUIController.m_luaExportHelper.m_heroShowButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E8D7 RID: 125143 RVA: 0x009DDD64 File Offset: 0x009DBF64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroShowButton(IntPtr l)
	{
		int result;
		try
		{
			HeroArchiveUIController heroArchiveUIController = (HeroArchiveUIController)LuaObject.checkSelf(l);
			Button heroShowButton;
			LuaObject.checkType<Button>(l, 2, out heroShowButton);
			heroArchiveUIController.m_luaExportHelper.m_heroShowButton = heroShowButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E8D8 RID: 125144 RVA: 0x009DDDC0 File Offset: 0x009DBFC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroScrollRect(IntPtr l)
	{
		int result;
		try
		{
			HeroArchiveUIController heroArchiveUIController = (HeroArchiveUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroArchiveUIController.m_luaExportHelper.m_heroScrollRect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E8D9 RID: 125145 RVA: 0x009DDE18 File Offset: 0x009DC018
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroScrollRect(IntPtr l)
	{
		int result;
		try
		{
			HeroArchiveUIController heroArchiveUIController = (HeroArchiveUIController)LuaObject.checkSelf(l);
			ScrollRect heroScrollRect;
			LuaObject.checkType<ScrollRect>(l, 2, out heroScrollRect);
			heroArchiveUIController.m_luaExportHelper.m_heroScrollRect = heroScrollRect;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E8DA RID: 125146 RVA: 0x009DDE74 File Offset: 0x009DC074
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroContent(IntPtr l)
	{
		int result;
		try
		{
			HeroArchiveUIController heroArchiveUIController = (HeroArchiveUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroArchiveUIController.m_luaExportHelper.m_heroContent);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E8DB RID: 125147 RVA: 0x009DDECC File Offset: 0x009DC0CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroContent(IntPtr l)
	{
		int result;
		try
		{
			HeroArchiveUIController heroArchiveUIController = (HeroArchiveUIController)LuaObject.checkSelf(l);
			GameObject heroContent;
			LuaObject.checkType<GameObject>(l, 2, out heroContent);
			heroArchiveUIController.m_luaExportHelper.m_heroContent = heroContent;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E8DC RID: 125148 RVA: 0x009DDF28 File Offset: 0x009DC128
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroContentInfinityGrid(IntPtr l)
	{
		int result;
		try
		{
			HeroArchiveUIController heroArchiveUIController = (HeroArchiveUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroArchiveUIController.m_luaExportHelper.m_heroContentInfinityGrid);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E8DD RID: 125149 RVA: 0x009DDF80 File Offset: 0x009DC180
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroContentInfinityGrid(IntPtr l)
	{
		int result;
		try
		{
			HeroArchiveUIController heroArchiveUIController = (HeroArchiveUIController)LuaObject.checkSelf(l);
			InfinityGridLayoutGroup heroContentInfinityGrid;
			LuaObject.checkType<InfinityGridLayoutGroup>(l, 2, out heroContentInfinityGrid);
			heroArchiveUIController.m_luaExportHelper.m_heroContentInfinityGrid = heroContentInfinityGrid;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E8DE RID: 125150 RVA: 0x009DDFDC File Offset: 0x009DC1DC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_heroHeadPrefab(IntPtr l)
	{
		int result;
		try
		{
			HeroArchiveUIController heroArchiveUIController = (HeroArchiveUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroArchiveUIController.m_luaExportHelper.m_heroHeadPrefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E8DF RID: 125151 RVA: 0x009DE034 File Offset: 0x009DC234
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroHeadPrefab(IntPtr l)
	{
		int result;
		try
		{
			HeroArchiveUIController heroArchiveUIController = (HeroArchiveUIController)LuaObject.checkSelf(l);
			GameObject heroHeadPrefab;
			LuaObject.checkType<GameObject>(l, 2, out heroHeadPrefab);
			heroArchiveUIController.m_luaExportHelper.m_heroHeadPrefab = heroHeadPrefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E8E0 RID: 125152 RVA: 0x009DE090 File Offset: 0x009DC290
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_ownHeroCountText(IntPtr l)
	{
		int result;
		try
		{
			HeroArchiveUIController heroArchiveUIController = (HeroArchiveUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroArchiveUIController.m_luaExportHelper.m_ownHeroCountText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E8E1 RID: 125153 RVA: 0x009DE0E8 File Offset: 0x009DC2E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_ownHeroCountText(IntPtr l)
	{
		int result;
		try
		{
			HeroArchiveUIController heroArchiveUIController = (HeroArchiveUIController)LuaObject.checkSelf(l);
			Text ownHeroCountText;
			LuaObject.checkType<Text>(l, 2, out ownHeroCountText);
			heroArchiveUIController.m_luaExportHelper.m_ownHeroCountText = ownHeroCountText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E8E2 RID: 125154 RVA: 0x009DE144 File Offset: 0x009DC344
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroEnglishNameText(IntPtr l)
	{
		int result;
		try
		{
			HeroArchiveUIController heroArchiveUIController = (HeroArchiveUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroArchiveUIController.m_luaExportHelper.m_heroEnglishNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E8E3 RID: 125155 RVA: 0x009DE19C File Offset: 0x009DC39C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroEnglishNameText(IntPtr l)
	{
		int result;
		try
		{
			HeroArchiveUIController heroArchiveUIController = (HeroArchiveUIController)LuaObject.checkSelf(l);
			Text heroEnglishNameText;
			LuaObject.checkType<Text>(l, 2, out heroEnglishNameText);
			heroArchiveUIController.m_luaExportHelper.m_heroEnglishNameText = heroEnglishNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E8E4 RID: 125156 RVA: 0x009DE1F8 File Offset: 0x009DC3F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_spineJobDummy(IntPtr l)
	{
		int result;
		try
		{
			HeroArchiveUIController heroArchiveUIController = (HeroArchiveUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroArchiveUIController.m_luaExportHelper.m_spineJobDummy);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E8E5 RID: 125157 RVA: 0x009DE250 File Offset: 0x009DC450
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_spineJobDummy(IntPtr l)
	{
		int result;
		try
		{
			HeroArchiveUIController heroArchiveUIController = (HeroArchiveUIController)LuaObject.checkSelf(l);
			GameObject spineJobDummy;
			LuaObject.checkType<GameObject>(l, 2, out spineJobDummy);
			heroArchiveUIController.m_luaExportHelper.m_spineJobDummy = spineJobDummy;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E8E6 RID: 125158 RVA: 0x009DE2AC File Offset: 0x009DC4AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_introTextscrollRect(IntPtr l)
	{
		int result;
		try
		{
			HeroArchiveUIController heroArchiveUIController = (HeroArchiveUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroArchiveUIController.m_luaExportHelper.m_introTextscrollRect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E8E7 RID: 125159 RVA: 0x009DE304 File Offset: 0x009DC504
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_introTextscrollRect(IntPtr l)
	{
		int result;
		try
		{
			HeroArchiveUIController heroArchiveUIController = (HeroArchiveUIController)LuaObject.checkSelf(l);
			ScrollRect introTextscrollRect;
			LuaObject.checkType<ScrollRect>(l, 2, out introTextscrollRect);
			heroArchiveUIController.m_luaExportHelper.m_introTextscrollRect = introTextscrollRect;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E8E8 RID: 125160 RVA: 0x009DE360 File Offset: 0x009DC560
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroIntroText(IntPtr l)
	{
		int result;
		try
		{
			HeroArchiveUIController heroArchiveUIController = (HeroArchiveUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroArchiveUIController.m_luaExportHelper.m_heroIntroText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E8E9 RID: 125161 RVA: 0x009DE3B8 File Offset: 0x009DC5B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroIntroText(IntPtr l)
	{
		int result;
		try
		{
			HeroArchiveUIController heroArchiveUIController = (HeroArchiveUIController)LuaObject.checkSelf(l);
			Text heroIntroText;
			LuaObject.checkType<Text>(l, 2, out heroIntroText);
			heroArchiveUIController.m_luaExportHelper.m_heroIntroText = heroIntroText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E8EA RID: 125162 RVA: 0x009DE414 File Offset: 0x009DC614
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroObtainText(IntPtr l)
	{
		int result;
		try
		{
			HeroArchiveUIController heroArchiveUIController = (HeroArchiveUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroArchiveUIController.m_luaExportHelper.m_heroObtainText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E8EB RID: 125163 RVA: 0x009DE46C File Offset: 0x009DC66C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroObtainText(IntPtr l)
	{
		int result;
		try
		{
			HeroArchiveUIController heroArchiveUIController = (HeroArchiveUIController)LuaObject.checkSelf(l);
			Text heroObtainText;
			LuaObject.checkType<Text>(l, 2, out heroObtainText);
			heroArchiveUIController.m_luaExportHelper.m_heroObtainText = heroObtainText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E8EC RID: 125164 RVA: 0x009DE4C8 File Offset: 0x009DC6C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroDrawShowDummy(IntPtr l)
	{
		int result;
		try
		{
			HeroArchiveUIController heroArchiveUIController = (HeroArchiveUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroArchiveUIController.m_luaExportHelper.m_heroDrawShowDummy);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E8ED RID: 125165 RVA: 0x009DE520 File Offset: 0x009DC720
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroDrawShowDummy(IntPtr l)
	{
		int result;
		try
		{
			HeroArchiveUIController heroArchiveUIController = (HeroArchiveUIController)LuaObject.checkSelf(l);
			GameObject heroDrawShowDummy;
			LuaObject.checkType<GameObject>(l, 2, out heroDrawShowDummy);
			heroArchiveUIController.m_luaExportHelper.m_heroDrawShowDummy = heroDrawShowDummy;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E8EE RID: 125166 RVA: 0x009DE57C File Offset: 0x009DC77C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroMessageGroup(IntPtr l)
	{
		int result;
		try
		{
			HeroArchiveUIController heroArchiveUIController = (HeroArchiveUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroArchiveUIController.m_luaExportHelper.m_heroMessageGroup);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E8EF RID: 125167 RVA: 0x009DE5D4 File Offset: 0x009DC7D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroMessageGroup(IntPtr l)
	{
		int result;
		try
		{
			HeroArchiveUIController heroArchiveUIController = (HeroArchiveUIController)LuaObject.checkSelf(l);
			GameObject heroMessageGroup;
			LuaObject.checkType<GameObject>(l, 2, out heroMessageGroup);
			heroArchiveUIController.m_luaExportHelper.m_heroMessageGroup = heroMessageGroup;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E8F0 RID: 125168 RVA: 0x009DE630 File Offset: 0x009DC830
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_charALLToggle(IntPtr l)
	{
		int result;
		try
		{
			HeroArchiveUIController heroArchiveUIController = (HeroArchiveUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroArchiveUIController.m_luaExportHelper.m_charALLToggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E8F1 RID: 125169 RVA: 0x009DE688 File Offset: 0x009DC888
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_charALLToggle(IntPtr l)
	{
		int result;
		try
		{
			HeroArchiveUIController heroArchiveUIController = (HeroArchiveUIController)LuaObject.checkSelf(l);
			Toggle charALLToggle;
			LuaObject.checkType<Toggle>(l, 2, out charALLToggle);
			heroArchiveUIController.m_luaExportHelper.m_charALLToggle = charALLToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E8F2 RID: 125170 RVA: 0x009DE6E4 File Offset: 0x009DC8E4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_charSSRToggle(IntPtr l)
	{
		int result;
		try
		{
			HeroArchiveUIController heroArchiveUIController = (HeroArchiveUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroArchiveUIController.m_luaExportHelper.m_charSSRToggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E8F3 RID: 125171 RVA: 0x009DE73C File Offset: 0x009DC93C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_charSSRToggle(IntPtr l)
	{
		int result;
		try
		{
			HeroArchiveUIController heroArchiveUIController = (HeroArchiveUIController)LuaObject.checkSelf(l);
			Toggle charSSRToggle;
			LuaObject.checkType<Toggle>(l, 2, out charSSRToggle);
			heroArchiveUIController.m_luaExportHelper.m_charSSRToggle = charSSRToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E8F4 RID: 125172 RVA: 0x009DE798 File Offset: 0x009DC998
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_charSRToggle(IntPtr l)
	{
		int result;
		try
		{
			HeroArchiveUIController heroArchiveUIController = (HeroArchiveUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroArchiveUIController.m_luaExportHelper.m_charSRToggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E8F5 RID: 125173 RVA: 0x009DE7F0 File Offset: 0x009DC9F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_charSRToggle(IntPtr l)
	{
		int result;
		try
		{
			HeroArchiveUIController heroArchiveUIController = (HeroArchiveUIController)LuaObject.checkSelf(l);
			Toggle charSRToggle;
			LuaObject.checkType<Toggle>(l, 2, out charSRToggle);
			heroArchiveUIController.m_luaExportHelper.m_charSRToggle = charSRToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E8F6 RID: 125174 RVA: 0x009DE84C File Offset: 0x009DCA4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_charRToggle(IntPtr l)
	{
		int result;
		try
		{
			HeroArchiveUIController heroArchiveUIController = (HeroArchiveUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroArchiveUIController.m_luaExportHelper.m_charRToggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E8F7 RID: 125175 RVA: 0x009DE8A4 File Offset: 0x009DCAA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_charRToggle(IntPtr l)
	{
		int result;
		try
		{
			HeroArchiveUIController heroArchiveUIController = (HeroArchiveUIController)LuaObject.checkSelf(l);
			Toggle charRToggle;
			LuaObject.checkType<Toggle>(l, 2, out charRToggle);
			heroArchiveUIController.m_luaExportHelper.m_charRToggle = charRToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E8F8 RID: 125176 RVA: 0x009DE900 File Offset: 0x009DCB00
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_messageGroupUIComponent(IntPtr l)
	{
		int result;
		try
		{
			HeroArchiveUIController heroArchiveUIController = (HeroArchiveUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroArchiveUIController.m_luaExportHelper.m_messageGroupUIComponent);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E8F9 RID: 125177 RVA: 0x009DE958 File Offset: 0x009DCB58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_messageGroupUIComponent(IntPtr l)
	{
		int result;
		try
		{
			HeroArchiveUIController heroArchiveUIController = (HeroArchiveUIController)LuaObject.checkSelf(l);
			HeroMessageGroupUIComponent messageGroupUIComponent;
			LuaObject.checkType<HeroMessageGroupUIComponent>(l, 2, out messageGroupUIComponent);
			heroArchiveUIController.m_luaExportHelper.m_messageGroupUIComponent = messageGroupUIComponent;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E8FA RID: 125178 RVA: 0x009DE9B4 File Offset: 0x009DCBB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_task(IntPtr l)
	{
		int result;
		try
		{
			HeroArchiveUIController heroArchiveUIController = (HeroArchiveUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroArchiveUIController.m_luaExportHelper.m_task);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E8FB RID: 125179 RVA: 0x009DEA0C File Offset: 0x009DCC0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_task(IntPtr l)
	{
		int result;
		try
		{
			HeroArchiveUIController heroArchiveUIController = (HeroArchiveUIController)LuaObject.checkSelf(l);
			ArchiveUITask task;
			LuaObject.checkType<ArchiveUITask>(l, 2, out task);
			heroArchiveUIController.m_luaExportHelper.m_task = task;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E8FC RID: 125180 RVA: 0x009DEA68 File Offset: 0x009DCC68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			HeroArchiveUIController heroArchiveUIController = (HeroArchiveUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroArchiveUIController.m_luaExportHelper.m_playerContext);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E8FD RID: 125181 RVA: 0x009DEAC0 File Offset: 0x009DCCC0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			HeroArchiveUIController heroArchiveUIController = (HeroArchiveUIController)LuaObject.checkSelf(l);
			ProjectLPlayerContext playerContext;
			LuaObject.checkType<ProjectLPlayerContext>(l, 2, out playerContext);
			heroArchiveUIController.m_luaExportHelper.m_playerContext = playerContext;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E8FE RID: 125182 RVA: 0x009DEB1C File Offset: 0x009DCD1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			HeroArchiveUIController heroArchiveUIController = (HeroArchiveUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroArchiveUIController.m_luaExportHelper.m_configDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E8FF RID: 125183 RVA: 0x009DEB74 File Offset: 0x009DCD74
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			HeroArchiveUIController heroArchiveUIController = (HeroArchiveUIController)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			heroArchiveUIController.m_luaExportHelper.m_configDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E900 RID: 125184 RVA: 0x009DEBD0 File Offset: 0x009DCDD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_selectHeroList(IntPtr l)
	{
		int result;
		try
		{
			HeroArchiveUIController heroArchiveUIController = (HeroArchiveUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroArchiveUIController.m_luaExportHelper.m_selectHeroList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E901 RID: 125185 RVA: 0x009DEC28 File Offset: 0x009DCE28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_selectHeroList(IntPtr l)
	{
		int result;
		try
		{
			HeroArchiveUIController heroArchiveUIController = (HeroArchiveUIController)LuaObject.checkSelf(l);
			List<HeroArchiveUIController.HeroWrap> selectHeroList;
			LuaObject.checkType<List<HeroArchiveUIController.HeroWrap>>(l, 2, out selectHeroList);
			heroArchiveUIController.m_luaExportHelper.m_selectHeroList = selectHeroList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E902 RID: 125186 RVA: 0x009DEC84 File Offset: 0x009DCE84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroAllList(IntPtr l)
	{
		int result;
		try
		{
			HeroArchiveUIController heroArchiveUIController = (HeroArchiveUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroArchiveUIController.m_luaExportHelper.m_heroAllList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E903 RID: 125187 RVA: 0x009DECDC File Offset: 0x009DCEDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroAllList(IntPtr l)
	{
		int result;
		try
		{
			HeroArchiveUIController heroArchiveUIController = (HeroArchiveUIController)LuaObject.checkSelf(l);
			List<HeroArchiveUIController.HeroWrap> heroAllList;
			LuaObject.checkType<List<HeroArchiveUIController.HeroWrap>>(l, 2, out heroAllList);
			heroArchiveUIController.m_luaExportHelper.m_heroAllList = heroAllList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E904 RID: 125188 RVA: 0x009DED38 File Offset: 0x009DCF38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroSSRList(IntPtr l)
	{
		int result;
		try
		{
			HeroArchiveUIController heroArchiveUIController = (HeroArchiveUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroArchiveUIController.m_luaExportHelper.m_heroSSRList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E905 RID: 125189 RVA: 0x009DED90 File Offset: 0x009DCF90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroSSRList(IntPtr l)
	{
		int result;
		try
		{
			HeroArchiveUIController heroArchiveUIController = (HeroArchiveUIController)LuaObject.checkSelf(l);
			List<HeroArchiveUIController.HeroWrap> heroSSRList;
			LuaObject.checkType<List<HeroArchiveUIController.HeroWrap>>(l, 2, out heroSSRList);
			heroArchiveUIController.m_luaExportHelper.m_heroSSRList = heroSSRList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E906 RID: 125190 RVA: 0x009DEDEC File Offset: 0x009DCFEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroSRList(IntPtr l)
	{
		int result;
		try
		{
			HeroArchiveUIController heroArchiveUIController = (HeroArchiveUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroArchiveUIController.m_luaExportHelper.m_heroSRList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E907 RID: 125191 RVA: 0x009DEE44 File Offset: 0x009DD044
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroSRList(IntPtr l)
	{
		int result;
		try
		{
			HeroArchiveUIController heroArchiveUIController = (HeroArchiveUIController)LuaObject.checkSelf(l);
			List<HeroArchiveUIController.HeroWrap> heroSRList;
			LuaObject.checkType<List<HeroArchiveUIController.HeroWrap>>(l, 2, out heroSRList);
			heroArchiveUIController.m_luaExportHelper.m_heroSRList = heroSRList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E908 RID: 125192 RVA: 0x009DEEA0 File Offset: 0x009DD0A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroRList(IntPtr l)
	{
		int result;
		try
		{
			HeroArchiveUIController heroArchiveUIController = (HeroArchiveUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroArchiveUIController.m_luaExportHelper.m_heroRList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E909 RID: 125193 RVA: 0x009DEEF8 File Offset: 0x009DD0F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroRList(IntPtr l)
	{
		int result;
		try
		{
			HeroArchiveUIController heroArchiveUIController = (HeroArchiveUIController)LuaObject.checkSelf(l);
			List<HeroArchiveUIController.HeroWrap> heroRList;
			LuaObject.checkType<List<HeroArchiveUIController.HeroWrap>>(l, 2, out heroRList);
			heroArchiveUIController.m_luaExportHelper.m_heroRList = heroRList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E90A RID: 125194 RVA: 0x009DEF54 File Offset: 0x009DD154
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_heroHeadUIControllerList(IntPtr l)
	{
		int result;
		try
		{
			HeroArchiveUIController heroArchiveUIController = (HeroArchiveUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroArchiveUIController.m_luaExportHelper.m_heroHeadUIControllerList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E90B RID: 125195 RVA: 0x009DEFAC File Offset: 0x009DD1AC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_heroHeadUIControllerList(IntPtr l)
	{
		int result;
		try
		{
			HeroArchiveUIController heroArchiveUIController = (HeroArchiveUIController)LuaObject.checkSelf(l);
			List<HeroHeadUIController> heroHeadUIControllerList;
			LuaObject.checkType<List<HeroHeadUIController>>(l, 2, out heroHeadUIControllerList);
			heroArchiveUIController.m_luaExportHelper.m_heroHeadUIControllerList = heroHeadUIControllerList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E90C RID: 125196 RVA: 0x009DF008 File Offset: 0x009DD208
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_selectHeroWrap(IntPtr l)
	{
		int result;
		try
		{
			HeroArchiveUIController heroArchiveUIController = (HeroArchiveUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroArchiveUIController.m_luaExportHelper.m_selectHeroWrap);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E90D RID: 125197 RVA: 0x009DF060 File Offset: 0x009DD260
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_selectHeroWrap(IntPtr l)
	{
		int result;
		try
		{
			HeroArchiveUIController heroArchiveUIController = (HeroArchiveUIController)LuaObject.checkSelf(l);
			HeroArchiveUIController.HeroWrap selectHeroWrap;
			LuaObject.checkType<HeroArchiveUIController.HeroWrap>(l, 2, out selectHeroWrap);
			heroArchiveUIController.m_luaExportHelper.m_selectHeroWrap = selectHeroWrap;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E90E RID: 125198 RVA: 0x009DF0BC File Offset: 0x009DD2BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_selectHeroPainting(IntPtr l)
	{
		int result;
		try
		{
			HeroArchiveUIController heroArchiveUIController = (HeroArchiveUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroArchiveUIController.m_luaExportHelper.m_selectHeroPainting);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E90F RID: 125199 RVA: 0x009DF114 File Offset: 0x009DD314
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_selectHeroPainting(IntPtr l)
	{
		int result;
		try
		{
			HeroArchiveUIController heroArchiveUIController = (HeroArchiveUIController)LuaObject.checkSelf(l);
			GameObject selectHeroPainting;
			LuaObject.checkType<GameObject>(l, 2, out selectHeroPainting);
			heroArchiveUIController.m_luaExportHelper.m_selectHeroPainting = selectHeroPainting;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E910 RID: 125200 RVA: 0x009DF170 File Offset: 0x009DD370
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_jobSpineGraphicList(IntPtr l)
	{
		int result;
		try
		{
			HeroArchiveUIController heroArchiveUIController = (HeroArchiveUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroArchiveUIController.m_luaExportHelper.m_jobSpineGraphicList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E911 RID: 125201 RVA: 0x009DF1C8 File Offset: 0x009DD3C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_jobSpineGraphicList(IntPtr l)
	{
		int result;
		try
		{
			HeroArchiveUIController heroArchiveUIController = (HeroArchiveUIController)LuaObject.checkSelf(l);
			List<UISpineGraphic> jobSpineGraphicList;
			LuaObject.checkType<List<UISpineGraphic>>(l, 2, out jobSpineGraphicList);
			heroArchiveUIController.m_luaExportHelper.m_jobSpineGraphicList = jobSpineGraphicList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E912 RID: 125202 RVA: 0x009DF224 File Offset: 0x009DD424
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_allOwnHeroCount(IntPtr l)
	{
		int result;
		try
		{
			HeroArchiveUIController heroArchiveUIController = (HeroArchiveUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroArchiveUIController.m_luaExportHelper.m_allOwnHeroCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E913 RID: 125203 RVA: 0x009DF27C File Offset: 0x009DD47C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_allOwnHeroCount(IntPtr l)
	{
		int result;
		try
		{
			HeroArchiveUIController heroArchiveUIController = (HeroArchiveUIController)LuaObject.checkSelf(l);
			int allOwnHeroCount;
			LuaObject.checkType(l, 2, out allOwnHeroCount);
			heroArchiveUIController.m_luaExportHelper.m_allOwnHeroCount = allOwnHeroCount;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E914 RID: 125204 RVA: 0x009DF2D8 File Offset: 0x009DD4D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_ssrOwnHeroCount(IntPtr l)
	{
		int result;
		try
		{
			HeroArchiveUIController heroArchiveUIController = (HeroArchiveUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroArchiveUIController.m_luaExportHelper.m_ssrOwnHeroCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E915 RID: 125205 RVA: 0x009DF330 File Offset: 0x009DD530
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_ssrOwnHeroCount(IntPtr l)
	{
		int result;
		try
		{
			HeroArchiveUIController heroArchiveUIController = (HeroArchiveUIController)LuaObject.checkSelf(l);
			int ssrOwnHeroCount;
			LuaObject.checkType(l, 2, out ssrOwnHeroCount);
			heroArchiveUIController.m_luaExportHelper.m_ssrOwnHeroCount = ssrOwnHeroCount;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E916 RID: 125206 RVA: 0x009DF38C File Offset: 0x009DD58C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_srOwnHeroCount(IntPtr l)
	{
		int result;
		try
		{
			HeroArchiveUIController heroArchiveUIController = (HeroArchiveUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroArchiveUIController.m_luaExportHelper.m_srOwnHeroCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E917 RID: 125207 RVA: 0x009DF3E4 File Offset: 0x009DD5E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_srOwnHeroCount(IntPtr l)
	{
		int result;
		try
		{
			HeroArchiveUIController heroArchiveUIController = (HeroArchiveUIController)LuaObject.checkSelf(l);
			int srOwnHeroCount;
			LuaObject.checkType(l, 2, out srOwnHeroCount);
			heroArchiveUIController.m_luaExportHelper.m_srOwnHeroCount = srOwnHeroCount;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E918 RID: 125208 RVA: 0x009DF440 File Offset: 0x009DD640
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_rOwnHeroCount(IntPtr l)
	{
		int result;
		try
		{
			HeroArchiveUIController heroArchiveUIController = (HeroArchiveUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroArchiveUIController.m_luaExportHelper.m_rOwnHeroCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E919 RID: 125209 RVA: 0x009DF498 File Offset: 0x009DD698
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_rOwnHeroCount(IntPtr l)
	{
		int result;
		try
		{
			HeroArchiveUIController heroArchiveUIController = (HeroArchiveUIController)LuaObject.checkSelf(l);
			int rOwnHeroCount;
			LuaObject.checkType(l, 2, out rOwnHeroCount);
			heroArchiveUIController.m_luaExportHelper.m_rOwnHeroCount = rOwnHeroCount;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E91A RID: 125210 RVA: 0x009DF4F4 File Offset: 0x009DD6F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_FinalJobRank(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, HeroArchiveUIController.LuaExportHelper.FinalJobRank);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E91B RID: 125211 RVA: 0x009DF53C File Offset: 0x009DD73C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.HeroArchiveUIController");
		if (Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.SetTask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.EnterController);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.HeroCountRefresh);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.CreateHeroGraphic);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.HeroListCompare);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.GetHeroFinalJobList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.HeroDrawRefresh);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.CreateHeroHeadList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.DestroyHeroHeadList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.RefreshHeroHeadWithHeroData);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.OnReturnClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.OnCharFilterClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.OnHeroHeadClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.OnHeroShowClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.OnHeroHeadListRefresh);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache1C);
		string name = "m_prefabAnimation";
		if (Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.get_m_prefabAnimation);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache1D;
		if (Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.set_m_prefabAnimation);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache1E, true);
		string name2 = "m_returnButton";
		if (Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.get_m_returnButton);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache1F;
		if (Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.set_m_returnButton);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache20, true);
		string name3 = "m_heroShowButton";
		if (Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.get_m_heroShowButton);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache21;
		if (Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.set_m_heroShowButton);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache22, true);
		string name4 = "m_heroScrollRect";
		if (Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.get_m_heroScrollRect);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache23;
		if (Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.set_m_heroScrollRect);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache24, true);
		string name5 = "m_heroContent";
		if (Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.get_m_heroContent);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache25;
		if (Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.set_m_heroContent);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache26, true);
		string name6 = "m_heroContentInfinityGrid";
		if (Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.get_m_heroContentInfinityGrid);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache27;
		if (Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.set_m_heroContentInfinityGrid);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache28, true);
		string name7 = "m_heroHeadPrefab";
		if (Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.get_m_heroHeadPrefab);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache29;
		if (Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.set_m_heroHeadPrefab);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache2A, true);
		string name8 = "m_ownHeroCountText";
		if (Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.get_m_ownHeroCountText);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache2B;
		if (Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.set_m_ownHeroCountText);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache2C, true);
		string name9 = "m_heroEnglishNameText";
		if (Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.get_m_heroEnglishNameText);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache2D;
		if (Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.set_m_heroEnglishNameText);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache2E, true);
		string name10 = "m_spineJobDummy";
		if (Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.get_m_spineJobDummy);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache2F;
		if (Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.set_m_spineJobDummy);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache30, true);
		string name11 = "m_introTextscrollRect";
		if (Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.get_m_introTextscrollRect);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache31;
		if (Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.set_m_introTextscrollRect);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache32, true);
		string name12 = "m_heroIntroText";
		if (Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.get_m_heroIntroText);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache33;
		if (Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.set_m_heroIntroText);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache34, true);
		string name13 = "m_heroObtainText";
		if (Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.get_m_heroObtainText);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache35;
		if (Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.set_m_heroObtainText);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache36, true);
		string name14 = "m_heroDrawShowDummy";
		if (Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.get_m_heroDrawShowDummy);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache37;
		if (Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.set_m_heroDrawShowDummy);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache38, true);
		string name15 = "m_heroMessageGroup";
		if (Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.get_m_heroMessageGroup);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache39;
		if (Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.set_m_heroMessageGroup);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache3A, true);
		string name16 = "m_charALLToggle";
		if (Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.get_m_charALLToggle);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache3B;
		if (Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.set_m_charALLToggle);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache3C, true);
		string name17 = "m_charSSRToggle";
		if (Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.get_m_charSSRToggle);
		}
		LuaCSFunction get17 = Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache3D;
		if (Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.set_m_charSSRToggle);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache3E, true);
		string name18 = "m_charSRToggle";
		if (Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.get_m_charSRToggle);
		}
		LuaCSFunction get18 = Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache3F;
		if (Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.set_m_charSRToggle);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache40, true);
		string name19 = "m_charRToggle";
		if (Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.get_m_charRToggle);
		}
		LuaCSFunction get19 = Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache41;
		if (Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.set_m_charRToggle);
		}
		LuaObject.addMember(l, name19, get19, Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache42, true);
		string name20 = "m_messageGroupUIComponent";
		if (Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.get_m_messageGroupUIComponent);
		}
		LuaCSFunction get20 = Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache43;
		if (Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.set_m_messageGroupUIComponent);
		}
		LuaObject.addMember(l, name20, get20, Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache44, true);
		string name21 = "m_task";
		if (Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.get_m_task);
		}
		LuaCSFunction get21 = Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache45;
		if (Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache46 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache46 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.set_m_task);
		}
		LuaObject.addMember(l, name21, get21, Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache46, true);
		string name22 = "m_playerContext";
		if (Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache47 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache47 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.get_m_playerContext);
		}
		LuaCSFunction get22 = Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache47;
		if (Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache48 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache48 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.set_m_playerContext);
		}
		LuaObject.addMember(l, name22, get22, Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache48, true);
		string name23 = "m_configDataLoader";
		if (Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache49 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache49 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.get_m_configDataLoader);
		}
		LuaCSFunction get23 = Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache49;
		if (Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache4A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache4A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.set_m_configDataLoader);
		}
		LuaObject.addMember(l, name23, get23, Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache4A, true);
		string name24 = "m_selectHeroList";
		if (Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache4B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache4B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.get_m_selectHeroList);
		}
		LuaCSFunction get24 = Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache4B;
		if (Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache4C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache4C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.set_m_selectHeroList);
		}
		LuaObject.addMember(l, name24, get24, Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache4C, true);
		string name25 = "m_heroAllList";
		if (Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache4D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache4D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.get_m_heroAllList);
		}
		LuaCSFunction get25 = Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache4D;
		if (Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache4E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache4E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.set_m_heroAllList);
		}
		LuaObject.addMember(l, name25, get25, Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache4E, true);
		string name26 = "m_heroSSRList";
		if (Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache4F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache4F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.get_m_heroSSRList);
		}
		LuaCSFunction get26 = Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache4F;
		if (Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache50 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache50 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.set_m_heroSSRList);
		}
		LuaObject.addMember(l, name26, get26, Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache50, true);
		string name27 = "m_heroSRList";
		if (Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache51 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache51 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.get_m_heroSRList);
		}
		LuaCSFunction get27 = Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache51;
		if (Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache52 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache52 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.set_m_heroSRList);
		}
		LuaObject.addMember(l, name27, get27, Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache52, true);
		string name28 = "m_heroRList";
		if (Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache53 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache53 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.get_m_heroRList);
		}
		LuaCSFunction get28 = Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache53;
		if (Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache54 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache54 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.set_m_heroRList);
		}
		LuaObject.addMember(l, name28, get28, Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache54, true);
		string name29 = "m_heroHeadUIControllerList";
		if (Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache55 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache55 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.get_m_heroHeadUIControllerList);
		}
		LuaCSFunction get29 = Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache55;
		if (Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache56 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache56 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.set_m_heroHeadUIControllerList);
		}
		LuaObject.addMember(l, name29, get29, Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache56, true);
		string name30 = "m_selectHeroWrap";
		if (Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache57 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache57 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.get_m_selectHeroWrap);
		}
		LuaCSFunction get30 = Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache57;
		if (Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache58 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache58 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.set_m_selectHeroWrap);
		}
		LuaObject.addMember(l, name30, get30, Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache58, true);
		string name31 = "m_selectHeroPainting";
		if (Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache59 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache59 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.get_m_selectHeroPainting);
		}
		LuaCSFunction get31 = Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache59;
		if (Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache5A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache5A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.set_m_selectHeroPainting);
		}
		LuaObject.addMember(l, name31, get31, Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache5A, true);
		string name32 = "m_jobSpineGraphicList";
		if (Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache5B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache5B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.get_m_jobSpineGraphicList);
		}
		LuaCSFunction get32 = Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache5B;
		if (Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache5C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache5C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.set_m_jobSpineGraphicList);
		}
		LuaObject.addMember(l, name32, get32, Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache5C, true);
		string name33 = "m_allOwnHeroCount";
		if (Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache5D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache5D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.get_m_allOwnHeroCount);
		}
		LuaCSFunction get33 = Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache5D;
		if (Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache5E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache5E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.set_m_allOwnHeroCount);
		}
		LuaObject.addMember(l, name33, get33, Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache5E, true);
		string name34 = "m_ssrOwnHeroCount";
		if (Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache5F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache5F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.get_m_ssrOwnHeroCount);
		}
		LuaCSFunction get34 = Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache5F;
		if (Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache60 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache60 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.set_m_ssrOwnHeroCount);
		}
		LuaObject.addMember(l, name34, get34, Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache60, true);
		string name35 = "m_srOwnHeroCount";
		if (Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache61 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache61 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.get_m_srOwnHeroCount);
		}
		LuaCSFunction get35 = Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache61;
		if (Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache62 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache62 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.set_m_srOwnHeroCount);
		}
		LuaObject.addMember(l, name35, get35, Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache62, true);
		string name36 = "m_rOwnHeroCount";
		if (Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache63 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache63 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.get_m_rOwnHeroCount);
		}
		LuaCSFunction get36 = Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache63;
		if (Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache64 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache64 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.set_m_rOwnHeroCount);
		}
		LuaObject.addMember(l, name36, get36, Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache64, true);
		string name37 = "FinalJobRank";
		if (Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache65 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache65 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.get_FinalJobRank);
		}
		LuaObject.addMember(l, name37, Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.<>f__mg$cache65, null, false);
		LuaObject.createTypeMetatable(l, null, typeof(HeroArchiveUIController), typeof(UIControllerBase));
	}

	// Token: 0x0401495B RID: 84315
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0401495C RID: 84316
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0401495D RID: 84317
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0401495E RID: 84318
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0401495F RID: 84319
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04014960 RID: 84320
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04014961 RID: 84321
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04014962 RID: 84322
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04014963 RID: 84323
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04014964 RID: 84324
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04014965 RID: 84325
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04014966 RID: 84326
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04014967 RID: 84327
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04014968 RID: 84328
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04014969 RID: 84329
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0401496A RID: 84330
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0401496B RID: 84331
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0401496C RID: 84332
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0401496D RID: 84333
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0401496E RID: 84334
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0401496F RID: 84335
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04014970 RID: 84336
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04014971 RID: 84337
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04014972 RID: 84338
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04014973 RID: 84339
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04014974 RID: 84340
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04014975 RID: 84341
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04014976 RID: 84342
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04014977 RID: 84343
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04014978 RID: 84344
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04014979 RID: 84345
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0401497A RID: 84346
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0401497B RID: 84347
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0401497C RID: 84348
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0401497D RID: 84349
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0401497E RID: 84350
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0401497F RID: 84351
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04014980 RID: 84352
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04014981 RID: 84353
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04014982 RID: 84354
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04014983 RID: 84355
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04014984 RID: 84356
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04014985 RID: 84357
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04014986 RID: 84358
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04014987 RID: 84359
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04014988 RID: 84360
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04014989 RID: 84361
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x0401498A RID: 84362
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x0401498B RID: 84363
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x0401498C RID: 84364
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x0401498D RID: 84365
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x0401498E RID: 84366
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x0401498F RID: 84367
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x04014990 RID: 84368
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x04014991 RID: 84369
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x04014992 RID: 84370
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x04014993 RID: 84371
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x04014994 RID: 84372
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x04014995 RID: 84373
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x04014996 RID: 84374
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x04014997 RID: 84375
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x04014998 RID: 84376
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x04014999 RID: 84377
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x0401499A RID: 84378
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x0401499B RID: 84379
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x0401499C RID: 84380
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x0401499D RID: 84381
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x0401499E RID: 84382
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x0401499F RID: 84383
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x040149A0 RID: 84384
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x040149A1 RID: 84385
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;

	// Token: 0x040149A2 RID: 84386
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache47;

	// Token: 0x040149A3 RID: 84387
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache48;

	// Token: 0x040149A4 RID: 84388
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache49;

	// Token: 0x040149A5 RID: 84389
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4A;

	// Token: 0x040149A6 RID: 84390
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4B;

	// Token: 0x040149A7 RID: 84391
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4C;

	// Token: 0x040149A8 RID: 84392
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4D;

	// Token: 0x040149A9 RID: 84393
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4E;

	// Token: 0x040149AA RID: 84394
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4F;

	// Token: 0x040149AB RID: 84395
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache50;

	// Token: 0x040149AC RID: 84396
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache51;

	// Token: 0x040149AD RID: 84397
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache52;

	// Token: 0x040149AE RID: 84398
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache53;

	// Token: 0x040149AF RID: 84399
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache54;

	// Token: 0x040149B0 RID: 84400
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache55;

	// Token: 0x040149B1 RID: 84401
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache56;

	// Token: 0x040149B2 RID: 84402
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache57;

	// Token: 0x040149B3 RID: 84403
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache58;

	// Token: 0x040149B4 RID: 84404
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache59;

	// Token: 0x040149B5 RID: 84405
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5A;

	// Token: 0x040149B6 RID: 84406
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5B;

	// Token: 0x040149B7 RID: 84407
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5C;

	// Token: 0x040149B8 RID: 84408
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5D;

	// Token: 0x040149B9 RID: 84409
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5E;

	// Token: 0x040149BA RID: 84410
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5F;

	// Token: 0x040149BB RID: 84411
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache60;

	// Token: 0x040149BC RID: 84412
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache61;

	// Token: 0x040149BD RID: 84413
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache62;

	// Token: 0x040149BE RID: 84414
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache63;

	// Token: 0x040149BF RID: 84415
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache64;

	// Token: 0x040149C0 RID: 84416
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache65;
}
