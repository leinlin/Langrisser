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

// Token: 0x020014D9 RID: 5337
[Preserve]
public class Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController : LuaObject
{
	// Token: 0x0601F639 RID: 128569 RVA: 0x00A49084 File Offset: 0x00A47284
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetHeroPhantomLevelInfo(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomLevelListItemUIController heroPhantomLevelListItemUIController = (HeroPhantomLevelListItemUIController)LuaObject.checkSelf(l);
			ConfigDataHeroPhantomLevelInfo heroPhantomLevelInfo;
			LuaObject.checkType<ConfigDataHeroPhantomLevelInfo>(l, 2, out heroPhantomLevelInfo);
			heroPhantomLevelListItemUIController.SetHeroPhantomLevelInfo(heroPhantomLevelInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F63A RID: 128570 RVA: 0x00A490DC File Offset: 0x00A472DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetHeroPhantomLevelInfo(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomLevelListItemUIController heroPhantomLevelListItemUIController = (HeroPhantomLevelListItemUIController)LuaObject.checkSelf(l);
			ConfigDataHeroPhantomLevelInfo heroPhantomLevelInfo = heroPhantomLevelListItemUIController.GetHeroPhantomLevelInfo();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroPhantomLevelInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F63B RID: 128571 RVA: 0x00A49130 File Offset: 0x00A47330
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetLocked(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomLevelListItemUIController heroPhantomLevelListItemUIController = (HeroPhantomLevelListItemUIController)LuaObject.checkSelf(l);
			bool locked;
			LuaObject.checkType(l, 2, out locked);
			heroPhantomLevelListItemUIController.SetLocked(locked);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F63C RID: 128572 RVA: 0x00A49188 File Offset: 0x00A47388
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomLevelListItemUIController heroPhantomLevelListItemUIController = (HeroPhantomLevelListItemUIController)LuaObject.checkSelf(l);
			heroPhantomLevelListItemUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F63D RID: 128573 RVA: 0x00A491DC File Offset: 0x00A473DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnStartButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomLevelListItemUIController heroPhantomLevelListItemUIController = (HeroPhantomLevelListItemUIController)LuaObject.checkSelf(l);
			heroPhantomLevelListItemUIController.m_luaExportHelper.OnStartButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F63E RID: 128574 RVA: 0x00A49230 File Offset: 0x00A47430
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnAchievementButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomLevelListItemUIController heroPhantomLevelListItemUIController = (HeroPhantomLevelListItemUIController)LuaObject.checkSelf(l);
			heroPhantomLevelListItemUIController.m_luaExportHelper.OnAchievementButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F63F RID: 128575 RVA: 0x00A49284 File Offset: 0x00A47484
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnLockedButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomLevelListItemUIController heroPhantomLevelListItemUIController = (HeroPhantomLevelListItemUIController)LuaObject.checkSelf(l);
			heroPhantomLevelListItemUIController.m_luaExportHelper.OnLockedButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F640 RID: 128576 RVA: 0x00A492D8 File Offset: 0x00A474D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomLevelListItemUIController heroPhantomLevelListItemUIController = (HeroPhantomLevelListItemUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			heroPhantomLevelListItemUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F641 RID: 128577 RVA: 0x00A49344 File Offset: 0x00A47544
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomLevelListItemUIController heroPhantomLevelListItemUIController = (HeroPhantomLevelListItemUIController)LuaObject.checkSelf(l);
			heroPhantomLevelListItemUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F642 RID: 128578 RVA: 0x00A49398 File Offset: 0x00A47598
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomLevelListItemUIController heroPhantomLevelListItemUIController = (HeroPhantomLevelListItemUIController)LuaObject.checkSelf(l);
			heroPhantomLevelListItemUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F643 RID: 128579 RVA: 0x00A493EC File Offset: 0x00A475EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomLevelListItemUIController heroPhantomLevelListItemUIController = (HeroPhantomLevelListItemUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = heroPhantomLevelListItemUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601F644 RID: 128580 RVA: 0x00A49494 File Offset: 0x00A47694
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomLevelListItemUIController heroPhantomLevelListItemUIController = (HeroPhantomLevelListItemUIController)LuaObject.checkSelf(l);
			heroPhantomLevelListItemUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F645 RID: 128581 RVA: 0x00A494E8 File Offset: 0x00A476E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomLevelListItemUIController heroPhantomLevelListItemUIController = (HeroPhantomLevelListItemUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			heroPhantomLevelListItemUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F646 RID: 128582 RVA: 0x00A49554 File Offset: 0x00A47754
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
				HeroPhantomLevelListItemUIController heroPhantomLevelListItemUIController = (HeroPhantomLevelListItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				heroPhantomLevelListItemUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				HeroPhantomLevelListItemUIController heroPhantomLevelListItemUIController2 = (HeroPhantomLevelListItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				heroPhantomLevelListItemUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601F647 RID: 128583 RVA: 0x00A49664 File Offset: 0x00A47864
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomLevelListItemUIController heroPhantomLevelListItemUIController = (HeroPhantomLevelListItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroPhantomLevelListItemUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F648 RID: 128584 RVA: 0x00A496D0 File Offset: 0x00A478D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomLevelListItemUIController heroPhantomLevelListItemUIController = (HeroPhantomLevelListItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroPhantomLevelListItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F649 RID: 128585 RVA: 0x00A4973C File Offset: 0x00A4793C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomLevelListItemUIController heroPhantomLevelListItemUIController = (HeroPhantomLevelListItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroPhantomLevelListItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F64A RID: 128586 RVA: 0x00A497A8 File Offset: 0x00A479A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomLevelListItemUIController heroPhantomLevelListItemUIController = (HeroPhantomLevelListItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroPhantomLevelListItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F64B RID: 128587 RVA: 0x00A49814 File Offset: 0x00A47A14
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
				HeroPhantomLevelListItemUIController heroPhantomLevelListItemUIController = (HeroPhantomLevelListItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				heroPhantomLevelListItemUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				HeroPhantomLevelListItemUIController heroPhantomLevelListItemUIController2 = (HeroPhantomLevelListItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				heroPhantomLevelListItemUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601F64C RID: 128588 RVA: 0x00A49924 File Offset: 0x00A47B24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomLevelListItemUIController heroPhantomLevelListItemUIController = (HeroPhantomLevelListItemUIController)LuaObject.checkSelf(l);
			string s = heroPhantomLevelListItemUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601F64D RID: 128589 RVA: 0x00A49980 File Offset: 0x00A47B80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnStartButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomLevelListItemUIController heroPhantomLevelListItemUIController = (HeroPhantomLevelListItemUIController)LuaObject.checkSelf(l);
			HeroPhantomLevelListItemUIController obj;
			LuaObject.checkType<HeroPhantomLevelListItemUIController>(l, 2, out obj);
			heroPhantomLevelListItemUIController.m_luaExportHelper.__callDele_EventOnStartButtonClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F64E RID: 128590 RVA: 0x00A499DC File Offset: 0x00A47BDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnStartButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomLevelListItemUIController heroPhantomLevelListItemUIController = (HeroPhantomLevelListItemUIController)LuaObject.checkSelf(l);
			HeroPhantomLevelListItemUIController obj;
			LuaObject.checkType<HeroPhantomLevelListItemUIController>(l, 2, out obj);
			heroPhantomLevelListItemUIController.m_luaExportHelper.__clearDele_EventOnStartButtonClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F64F RID: 128591 RVA: 0x00A49A38 File Offset: 0x00A47C38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnAchievementButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomLevelListItemUIController heroPhantomLevelListItemUIController = (HeroPhantomLevelListItemUIController)LuaObject.checkSelf(l);
			HeroPhantomLevelListItemUIController obj;
			LuaObject.checkType<HeroPhantomLevelListItemUIController>(l, 2, out obj);
			heroPhantomLevelListItemUIController.m_luaExportHelper.__callDele_EventOnAchievementButtonClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F650 RID: 128592 RVA: 0x00A49A94 File Offset: 0x00A47C94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnAchievementButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomLevelListItemUIController heroPhantomLevelListItemUIController = (HeroPhantomLevelListItemUIController)LuaObject.checkSelf(l);
			HeroPhantomLevelListItemUIController obj;
			LuaObject.checkType<HeroPhantomLevelListItemUIController>(l, 2, out obj);
			heroPhantomLevelListItemUIController.m_luaExportHelper.__clearDele_EventOnAchievementButtonClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F651 RID: 128593 RVA: 0x00A49AF0 File Offset: 0x00A47CF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnStartButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomLevelListItemUIController heroPhantomLevelListItemUIController = (HeroPhantomLevelListItemUIController)LuaObject.checkSelf(l);
			Action<HeroPhantomLevelListItemUIController> value;
			int num = LuaObject.checkDelegate<Action<HeroPhantomLevelListItemUIController>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					heroPhantomLevelListItemUIController.EventOnStartButtonClick += value;
				}
				else if (num == 2)
				{
					heroPhantomLevelListItemUIController.EventOnStartButtonClick -= value;
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

	// Token: 0x0601F652 RID: 128594 RVA: 0x00A49B70 File Offset: 0x00A47D70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnAchievementButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomLevelListItemUIController heroPhantomLevelListItemUIController = (HeroPhantomLevelListItemUIController)LuaObject.checkSelf(l);
			Action<HeroPhantomLevelListItemUIController> value;
			int num = LuaObject.checkDelegate<Action<HeroPhantomLevelListItemUIController>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					heroPhantomLevelListItemUIController.EventOnAchievementButtonClick += value;
				}
				else if (num == 2)
				{
					heroPhantomLevelListItemUIController.EventOnAchievementButtonClick -= value;
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

	// Token: 0x0601F653 RID: 128595 RVA: 0x00A49BF0 File Offset: 0x00A47DF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_levelText(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomLevelListItemUIController heroPhantomLevelListItemUIController = (HeroPhantomLevelListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroPhantomLevelListItemUIController.m_luaExportHelper.m_levelText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F654 RID: 128596 RVA: 0x00A49C48 File Offset: 0x00A47E48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_levelText(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomLevelListItemUIController heroPhantomLevelListItemUIController = (HeroPhantomLevelListItemUIController)LuaObject.checkSelf(l);
			Text levelText;
			LuaObject.checkType<Text>(l, 2, out levelText);
			heroPhantomLevelListItemUIController.m_luaExportHelper.m_levelText = levelText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F655 RID: 128597 RVA: 0x00A49CA4 File Offset: 0x00A47EA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_energyText(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomLevelListItemUIController heroPhantomLevelListItemUIController = (HeroPhantomLevelListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroPhantomLevelListItemUIController.m_luaExportHelper.m_energyText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F656 RID: 128598 RVA: 0x00A49CFC File Offset: 0x00A47EFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_energyText(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomLevelListItemUIController heroPhantomLevelListItemUIController = (HeroPhantomLevelListItemUIController)LuaObject.checkSelf(l);
			Text energyText;
			LuaObject.checkType<Text>(l, 2, out energyText);
			heroPhantomLevelListItemUIController.m_luaExportHelper.m_energyText = energyText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F657 RID: 128599 RVA: 0x00A49D58 File Offset: 0x00A47F58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_lockedButton(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomLevelListItemUIController heroPhantomLevelListItemUIController = (HeroPhantomLevelListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroPhantomLevelListItemUIController.m_luaExportHelper.m_lockedButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F658 RID: 128600 RVA: 0x00A49DB0 File Offset: 0x00A47FB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_lockedButton(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomLevelListItemUIController heroPhantomLevelListItemUIController = (HeroPhantomLevelListItemUIController)LuaObject.checkSelf(l);
			Button lockedButton;
			LuaObject.checkType<Button>(l, 2, out lockedButton);
			heroPhantomLevelListItemUIController.m_luaExportHelper.m_lockedButton = lockedButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F659 RID: 128601 RVA: 0x00A49E0C File Offset: 0x00A4800C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_achievementButton(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomLevelListItemUIController heroPhantomLevelListItemUIController = (HeroPhantomLevelListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroPhantomLevelListItemUIController.m_luaExportHelper.m_achievementButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F65A RID: 128602 RVA: 0x00A49E64 File Offset: 0x00A48064
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_achievementButton(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomLevelListItemUIController heroPhantomLevelListItemUIController = (HeroPhantomLevelListItemUIController)LuaObject.checkSelf(l);
			Button achievementButton;
			LuaObject.checkType<Button>(l, 2, out achievementButton);
			heroPhantomLevelListItemUIController.m_luaExportHelper.m_achievementButton = achievementButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F65B RID: 128603 RVA: 0x00A49EC0 File Offset: 0x00A480C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_achievementCount(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomLevelListItemUIController heroPhantomLevelListItemUIController = (HeroPhantomLevelListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroPhantomLevelListItemUIController.m_luaExportHelper.m_achievementCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F65C RID: 128604 RVA: 0x00A49F18 File Offset: 0x00A48118
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_achievementCount(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomLevelListItemUIController heroPhantomLevelListItemUIController = (HeroPhantomLevelListItemUIController)LuaObject.checkSelf(l);
			Text achievementCount;
			LuaObject.checkType<Text>(l, 2, out achievementCount);
			heroPhantomLevelListItemUIController.m_luaExportHelper.m_achievementCount = achievementCount;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F65D RID: 128605 RVA: 0x00A49F74 File Offset: 0x00A48174
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_startButton(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomLevelListItemUIController heroPhantomLevelListItemUIController = (HeroPhantomLevelListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroPhantomLevelListItemUIController.m_luaExportHelper.m_startButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F65E RID: 128606 RVA: 0x00A49FCC File Offset: 0x00A481CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_startButton(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomLevelListItemUIController heroPhantomLevelListItemUIController = (HeroPhantomLevelListItemUIController)LuaObject.checkSelf(l);
			Button startButton;
			LuaObject.checkType<Button>(l, 2, out startButton);
			heroPhantomLevelListItemUIController.m_luaExportHelper.m_startButton = startButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F65F RID: 128607 RVA: 0x00A4A028 File Offset: 0x00A48228
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_rewardGroupGameObject(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomLevelListItemUIController heroPhantomLevelListItemUIController = (HeroPhantomLevelListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroPhantomLevelListItemUIController.m_luaExportHelper.m_rewardGroupGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F660 RID: 128608 RVA: 0x00A4A080 File Offset: 0x00A48280
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_rewardGroupGameObject(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomLevelListItemUIController heroPhantomLevelListItemUIController = (HeroPhantomLevelListItemUIController)LuaObject.checkSelf(l);
			GameObject rewardGroupGameObject;
			LuaObject.checkType<GameObject>(l, 2, out rewardGroupGameObject);
			heroPhantomLevelListItemUIController.m_luaExportHelper.m_rewardGroupGameObject = rewardGroupGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F661 RID: 128609 RVA: 0x00A4A0DC File Offset: 0x00A482DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_firstCleanUIStateController(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomLevelListItemUIController heroPhantomLevelListItemUIController = (HeroPhantomLevelListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroPhantomLevelListItemUIController.m_luaExportHelper.m_firstCleanUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F662 RID: 128610 RVA: 0x00A4A134 File Offset: 0x00A48334
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_firstCleanUIStateController(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomLevelListItemUIController heroPhantomLevelListItemUIController = (HeroPhantomLevelListItemUIController)LuaObject.checkSelf(l);
			CommonUIStateController firstCleanUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out firstCleanUIStateController);
			heroPhantomLevelListItemUIController.m_luaExportHelper.m_firstCleanUIStateController = firstCleanUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F663 RID: 128611 RVA: 0x00A4A190 File Offset: 0x00A48390
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_firstRewardGroupGameObject(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomLevelListItemUIController heroPhantomLevelListItemUIController = (HeroPhantomLevelListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroPhantomLevelListItemUIController.m_luaExportHelper.m_firstRewardGroupGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F664 RID: 128612 RVA: 0x00A4A1E8 File Offset: 0x00A483E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_firstRewardGroupGameObject(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomLevelListItemUIController heroPhantomLevelListItemUIController = (HeroPhantomLevelListItemUIController)LuaObject.checkSelf(l);
			GameObject firstRewardGroupGameObject;
			LuaObject.checkType<GameObject>(l, 2, out firstRewardGroupGameObject);
			heroPhantomLevelListItemUIController.m_luaExportHelper.m_firstRewardGroupGameObject = firstRewardGroupGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F665 RID: 128613 RVA: 0x00A4A244 File Offset: 0x00A48444
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroPhantomLevelInfo(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomLevelListItemUIController heroPhantomLevelListItemUIController = (HeroPhantomLevelListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroPhantomLevelListItemUIController.m_luaExportHelper.m_heroPhantomLevelInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F666 RID: 128614 RVA: 0x00A4A29C File Offset: 0x00A4849C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroPhantomLevelInfo(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomLevelListItemUIController heroPhantomLevelListItemUIController = (HeroPhantomLevelListItemUIController)LuaObject.checkSelf(l);
			ConfigDataHeroPhantomLevelInfo heroPhantomLevelInfo;
			LuaObject.checkType<ConfigDataHeroPhantomLevelInfo>(l, 2, out heroPhantomLevelInfo);
			heroPhantomLevelListItemUIController.m_luaExportHelper.m_heroPhantomLevelInfo = heroPhantomLevelInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F667 RID: 128615 RVA: 0x00A4A2F8 File Offset: 0x00A484F8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.HeroPhantomLevelListItemUIController");
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.SetHeroPhantomLevelInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.GetHeroPhantomLevelInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.SetLocked);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.OnStartButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.OnAchievementButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.OnLockedButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.__callDele_EventOnStartButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.__clearDele_EventOnStartButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.__callDele_EventOnAchievementButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.__clearDele_EventOnAchievementButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.<>f__mg$cache17);
		string name = "EventOnStartButtonClick";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.set_EventOnStartButtonClick);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.<>f__mg$cache18, true);
		string name2 = "EventOnAchievementButtonClick";
		LuaCSFunction get2 = null;
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.set_EventOnAchievementButtonClick);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.<>f__mg$cache19, true);
		string name3 = "m_levelText";
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.get_m_levelText);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.<>f__mg$cache1A;
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.set_m_levelText);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.<>f__mg$cache1B, true);
		string name4 = "m_energyText";
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.get_m_energyText);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.<>f__mg$cache1C;
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.set_m_energyText);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.<>f__mg$cache1D, true);
		string name5 = "m_lockedButton";
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.get_m_lockedButton);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.<>f__mg$cache1E;
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.set_m_lockedButton);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.<>f__mg$cache1F, true);
		string name6 = "m_achievementButton";
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.get_m_achievementButton);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.<>f__mg$cache20;
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.set_m_achievementButton);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.<>f__mg$cache21, true);
		string name7 = "m_achievementCount";
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.get_m_achievementCount);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.<>f__mg$cache22;
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.set_m_achievementCount);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.<>f__mg$cache23, true);
		string name8 = "m_startButton";
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.get_m_startButton);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.<>f__mg$cache24;
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.set_m_startButton);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.<>f__mg$cache25, true);
		string name9 = "m_rewardGroupGameObject";
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.get_m_rewardGroupGameObject);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.<>f__mg$cache26;
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.set_m_rewardGroupGameObject);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.<>f__mg$cache27, true);
		string name10 = "m_firstCleanUIStateController";
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.get_m_firstCleanUIStateController);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.<>f__mg$cache28;
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.set_m_firstCleanUIStateController);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.<>f__mg$cache29, true);
		string name11 = "m_firstRewardGroupGameObject";
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.get_m_firstRewardGroupGameObject);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.<>f__mg$cache2A;
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.set_m_firstRewardGroupGameObject);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.<>f__mg$cache2B, true);
		string name12 = "m_heroPhantomLevelInfo";
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.get_m_heroPhantomLevelInfo);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.<>f__mg$cache2C;
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.set_m_heroPhantomLevelInfo);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.<>f__mg$cache2D, true);
		LuaObject.createTypeMetatable(l, null, typeof(HeroPhantomLevelListItemUIController), typeof(UIControllerBase));
	}

	// Token: 0x04015669 RID: 87657
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0401566A RID: 87658
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0401566B RID: 87659
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0401566C RID: 87660
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0401566D RID: 87661
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0401566E RID: 87662
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0401566F RID: 87663
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04015670 RID: 87664
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04015671 RID: 87665
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04015672 RID: 87666
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04015673 RID: 87667
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04015674 RID: 87668
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04015675 RID: 87669
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04015676 RID: 87670
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04015677 RID: 87671
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04015678 RID: 87672
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04015679 RID: 87673
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0401567A RID: 87674
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0401567B RID: 87675
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0401567C RID: 87676
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0401567D RID: 87677
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0401567E RID: 87678
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0401567F RID: 87679
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04015680 RID: 87680
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04015681 RID: 87681
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04015682 RID: 87682
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04015683 RID: 87683
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04015684 RID: 87684
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04015685 RID: 87685
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04015686 RID: 87686
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04015687 RID: 87687
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04015688 RID: 87688
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04015689 RID: 87689
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0401568A RID: 87690
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0401568B RID: 87691
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0401568C RID: 87692
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0401568D RID: 87693
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0401568E RID: 87694
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0401568F RID: 87695
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04015690 RID: 87696
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04015691 RID: 87697
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04015692 RID: 87698
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04015693 RID: 87699
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04015694 RID: 87700
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04015695 RID: 87701
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04015696 RID: 87702
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;
}
