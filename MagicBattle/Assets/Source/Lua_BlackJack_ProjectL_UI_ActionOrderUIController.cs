using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x0200134F RID: 4943
[Preserve]
public class Lua_BlackJack_ProjectL_UI_ActionOrderUIController : LuaObject
{
	// Token: 0x0601A8DD RID: 108765 RVA: 0x007E19AC File Offset: 0x007DFBAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Open(IntPtr l)
	{
		int result;
		try
		{
			ActionOrderUIController actionOrderUIController = (ActionOrderUIController)LuaObject.checkSelf(l);
			actionOrderUIController.Open();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A8DE RID: 108766 RVA: 0x007E19F8 File Offset: 0x007DFBF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetHeros(IntPtr l)
	{
		int result;
		try
		{
			ActionOrderUIController actionOrderUIController = (ActionOrderUIController)LuaObject.checkSelf(l);
			List<BattleHero> heros;
			LuaObject.checkType<List<BattleHero>>(l, 2, out heros);
			actionOrderUIController.SetHeros(heros);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A8DF RID: 108767 RVA: 0x007E1A50 File Offset: 0x007DFC50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetHeroActionOrderIndex(IntPtr l)
	{
		int result;
		try
		{
			ActionOrderUIController actionOrderUIController = (ActionOrderUIController)LuaObject.checkSelf(l);
			BattleHero hero;
			LuaObject.checkType<BattleHero>(l, 2, out hero);
			int heroActionOrderIndex = actionOrderUIController.GetHeroActionOrderIndex(hero);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroActionOrderIndex);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A8E0 RID: 108768 RVA: 0x007E1AB4 File Offset: 0x007DFCB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			ActionOrderUIController actionOrderUIController = (ActionOrderUIController)LuaObject.checkSelf(l);
			actionOrderUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A8E1 RID: 108769 RVA: 0x007E1B08 File Offset: 0x007DFD08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnDisable(IntPtr l)
	{
		int result;
		try
		{
			ActionOrderUIController actionOrderUIController = (ActionOrderUIController)LuaObject.checkSelf(l);
			actionOrderUIController.m_luaExportHelper.OnDisable();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A8E2 RID: 108770 RVA: 0x007E1B5C File Offset: 0x007DFD5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnApplicationPause(IntPtr l)
	{
		int result;
		try
		{
			ActionOrderUIController actionOrderUIController = (ActionOrderUIController)LuaObject.checkSelf(l);
			bool isPause;
			LuaObject.checkType(l, 2, out isPause);
			actionOrderUIController.m_luaExportHelper.OnApplicationPause(isPause);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A8E3 RID: 108771 RVA: 0x007E1BB8 File Offset: 0x007DFDB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnApplicationFocus(IntPtr l)
	{
		int result;
		try
		{
			ActionOrderUIController actionOrderUIController = (ActionOrderUIController)LuaObject.checkSelf(l);
			bool focus;
			LuaObject.checkType(l, 2, out focus);
			actionOrderUIController.m_luaExportHelper.OnApplicationFocus(focus);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A8E4 RID: 108772 RVA: 0x007E1C14 File Offset: 0x007DFE14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CreateActionOrderButton(IntPtr l)
	{
		int result;
		try
		{
			ActionOrderUIController actionOrderUIController = (ActionOrderUIController)LuaObject.checkSelf(l);
			BattleHero hero;
			LuaObject.checkType<BattleHero>(l, 2, out hero);
			Transform parent;
			LuaObject.checkType<Transform>(l, 3, out parent);
			ArenaActionOrderButton o = actionOrderUIController.m_luaExportHelper.CreateActionOrderButton(hero, parent);
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

	// Token: 0x0601A8E5 RID: 108773 RVA: 0x007E1C88 File Offset: 0x007DFE88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CreateDraggingActionOrderButton(IntPtr l)
	{
		int result;
		try
		{
			ActionOrderUIController actionOrderUIController = (ActionOrderUIController)LuaObject.checkSelf(l);
			BattleHero hero;
			LuaObject.checkType<BattleHero>(l, 2, out hero);
			actionOrderUIController.m_luaExportHelper.CreateDraggingActionOrderButton(hero);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A8E6 RID: 108774 RVA: 0x007E1CE4 File Offset: 0x007DFEE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DestroyDragginActionOrderButton(IntPtr l)
	{
		int result;
		try
		{
			ActionOrderUIController actionOrderUIController = (ActionOrderUIController)LuaObject.checkSelf(l);
			actionOrderUIController.m_luaExportHelper.DestroyDragginActionOrderButton();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A8E7 RID: 108775 RVA: 0x007E1D38 File Offset: 0x007DFF38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int MoveDraggingActionOrderButton(IntPtr l)
	{
		int result;
		try
		{
			ActionOrderUIController actionOrderUIController = (ActionOrderUIController)LuaObject.checkSelf(l);
			Vector2 pos;
			LuaObject.checkType(l, 2, out pos);
			actionOrderUIController.m_luaExportHelper.MoveDraggingActionOrderButton(pos);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A8E8 RID: 108776 RVA: 0x007E1D94 File Offset: 0x007DFF94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DropDraggingActionOrderButton(IntPtr l)
	{
		int result;
		try
		{
			ActionOrderUIController actionOrderUIController = (ActionOrderUIController)LuaObject.checkSelf(l);
			Vector3 pos;
			LuaObject.checkType(l, 2, out pos);
			actionOrderUIController.m_luaExportHelper.DropDraggingActionOrderButton(pos);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A8E9 RID: 108777 RVA: 0x007E1DF0 File Offset: 0x007DFFF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBackgroundButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ActionOrderUIController actionOrderUIController = (ActionOrderUIController)LuaObject.checkSelf(l);
			actionOrderUIController.m_luaExportHelper.OnBackgroundButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A8EA RID: 108778 RVA: 0x007E1E44 File Offset: 0x007E0044
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnOkButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ActionOrderUIController actionOrderUIController = (ActionOrderUIController)LuaObject.checkSelf(l);
			actionOrderUIController.m_luaExportHelper.OnOkButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A8EB RID: 108779 RVA: 0x007E1E98 File Offset: 0x007E0098
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ActionOrderButton_OnClick(IntPtr l)
	{
		int result;
		try
		{
			ActionOrderUIController actionOrderUIController = (ActionOrderUIController)LuaObject.checkSelf(l);
			ArenaActionOrderButton b;
			LuaObject.checkType<ArenaActionOrderButton>(l, 2, out b);
			actionOrderUIController.m_luaExportHelper.ActionOrderButton_OnClick(b);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A8EC RID: 108780 RVA: 0x007E1EF4 File Offset: 0x007E00F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ActionOrderButton_OnBeginDrag(IntPtr l)
	{
		int result;
		try
		{
			ActionOrderUIController actionOrderUIController = (ActionOrderUIController)LuaObject.checkSelf(l);
			ArenaActionOrderButton b;
			LuaObject.checkType<ArenaActionOrderButton>(l, 2, out b);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 3, out eventData);
			actionOrderUIController.m_luaExportHelper.ActionOrderButton_OnBeginDrag(b, eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A8ED RID: 108781 RVA: 0x007E1F60 File Offset: 0x007E0160
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ActionOrderButton_OnEndDrag(IntPtr l)
	{
		int result;
		try
		{
			ActionOrderUIController actionOrderUIController = (ActionOrderUIController)LuaObject.checkSelf(l);
			ArenaActionOrderButton b;
			LuaObject.checkType<ArenaActionOrderButton>(l, 2, out b);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 3, out eventData);
			actionOrderUIController.m_luaExportHelper.ActionOrderButton_OnEndDrag(b, eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A8EE RID: 108782 RVA: 0x007E1FCC File Offset: 0x007E01CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ActionOrderButton_OnDrag(IntPtr l)
	{
		int result;
		try
		{
			ActionOrderUIController actionOrderUIController = (ActionOrderUIController)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			actionOrderUIController.m_luaExportHelper.ActionOrderButton_OnDrag(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A8EF RID: 108783 RVA: 0x007E2028 File Offset: 0x007E0228
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ActionOrderButton_OnDrop(IntPtr l)
	{
		int result;
		try
		{
			ActionOrderUIController actionOrderUIController = (ActionOrderUIController)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			actionOrderUIController.m_luaExportHelper.ActionOrderButton_OnDrop(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A8F0 RID: 108784 RVA: 0x007E2084 File Offset: 0x007E0284
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			ActionOrderUIController actionOrderUIController = (ActionOrderUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			actionOrderUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A8F1 RID: 108785 RVA: 0x007E20F0 File Offset: 0x007E02F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			ActionOrderUIController actionOrderUIController = (ActionOrderUIController)LuaObject.checkSelf(l);
			actionOrderUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A8F2 RID: 108786 RVA: 0x007E2144 File Offset: 0x007E0344
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			ActionOrderUIController actionOrderUIController = (ActionOrderUIController)LuaObject.checkSelf(l);
			actionOrderUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A8F3 RID: 108787 RVA: 0x007E2198 File Offset: 0x007E0398
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			ActionOrderUIController actionOrderUIController = (ActionOrderUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = actionOrderUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601A8F4 RID: 108788 RVA: 0x007E2240 File Offset: 0x007E0440
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			ActionOrderUIController actionOrderUIController = (ActionOrderUIController)LuaObject.checkSelf(l);
			actionOrderUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A8F5 RID: 108789 RVA: 0x007E2294 File Offset: 0x007E0494
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ActionOrderUIController actionOrderUIController = (ActionOrderUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			actionOrderUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A8F6 RID: 108790 RVA: 0x007E2300 File Offset: 0x007E0500
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
				ActionOrderUIController actionOrderUIController = (ActionOrderUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				actionOrderUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				ActionOrderUIController actionOrderUIController2 = (ActionOrderUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				actionOrderUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601A8F7 RID: 108791 RVA: 0x007E2410 File Offset: 0x007E0610
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			ActionOrderUIController actionOrderUIController = (ActionOrderUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			actionOrderUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A8F8 RID: 108792 RVA: 0x007E247C File Offset: 0x007E067C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			ActionOrderUIController actionOrderUIController = (ActionOrderUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			actionOrderUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A8F9 RID: 108793 RVA: 0x007E24E8 File Offset: 0x007E06E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			ActionOrderUIController actionOrderUIController = (ActionOrderUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			actionOrderUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A8FA RID: 108794 RVA: 0x007E2554 File Offset: 0x007E0754
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			ActionOrderUIController actionOrderUIController = (ActionOrderUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			actionOrderUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A8FB RID: 108795 RVA: 0x007E25C0 File Offset: 0x007E07C0
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
				ActionOrderUIController actionOrderUIController = (ActionOrderUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				actionOrderUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				ActionOrderUIController actionOrderUIController2 = (ActionOrderUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				actionOrderUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601A8FC RID: 108796 RVA: 0x007E26D0 File Offset: 0x007E08D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			ActionOrderUIController actionOrderUIController = (ActionOrderUIController)LuaObject.checkSelf(l);
			string s = actionOrderUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601A8FD RID: 108797 RVA: 0x007E272C File Offset: 0x007E092C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnConfirm(IntPtr l)
	{
		int result;
		try
		{
			ActionOrderUIController actionOrderUIController = (ActionOrderUIController)LuaObject.checkSelf(l);
			actionOrderUIController.m_luaExportHelper.__callDele_EventOnConfirm();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A8FE RID: 108798 RVA: 0x007E2780 File Offset: 0x007E0980
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnConfirm(IntPtr l)
	{
		int result;
		try
		{
			ActionOrderUIController actionOrderUIController = (ActionOrderUIController)LuaObject.checkSelf(l);
			actionOrderUIController.m_luaExportHelper.__clearDele_EventOnConfirm();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A8FF RID: 108799 RVA: 0x007E27D4 File Offset: 0x007E09D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnConfirm(IntPtr l)
	{
		int result;
		try
		{
			ActionOrderUIController actionOrderUIController = (ActionOrderUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					actionOrderUIController.EventOnConfirm += value;
				}
				else if (num == 2)
				{
					actionOrderUIController.EventOnConfirm -= value;
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

	// Token: 0x0601A900 RID: 108800 RVA: 0x007E2854 File Offset: 0x007E0A54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiStateController(IntPtr l)
	{
		int result;
		try
		{
			ActionOrderUIController actionOrderUIController = (ActionOrderUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, actionOrderUIController.m_luaExportHelper.m_uiStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A901 RID: 108801 RVA: 0x007E28AC File Offset: 0x007E0AAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiStateController(IntPtr l)
	{
		int result;
		try
		{
			ActionOrderUIController actionOrderUIController = (ActionOrderUIController)LuaObject.checkSelf(l);
			CommonUIStateController uiStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out uiStateController);
			actionOrderUIController.m_luaExportHelper.m_uiStateController = uiStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A902 RID: 108802 RVA: 0x007E2908 File Offset: 0x007E0B08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_backgroundButton(IntPtr l)
	{
		int result;
		try
		{
			ActionOrderUIController actionOrderUIController = (ActionOrderUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, actionOrderUIController.m_luaExportHelper.m_backgroundButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A903 RID: 108803 RVA: 0x007E2960 File Offset: 0x007E0B60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_backgroundButton(IntPtr l)
	{
		int result;
		try
		{
			ActionOrderUIController actionOrderUIController = (ActionOrderUIController)LuaObject.checkSelf(l);
			Button backgroundButton;
			LuaObject.checkType<Button>(l, 2, out backgroundButton);
			actionOrderUIController.m_luaExportHelper.m_backgroundButton = backgroundButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A904 RID: 108804 RVA: 0x007E29BC File Offset: 0x007E0BBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_actionOrdersGameObject(IntPtr l)
	{
		int result;
		try
		{
			ActionOrderUIController actionOrderUIController = (ActionOrderUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, actionOrderUIController.m_luaExportHelper.m_actionOrdersGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A905 RID: 108805 RVA: 0x007E2A14 File Offset: 0x007E0C14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_actionOrdersGameObject(IntPtr l)
	{
		int result;
		try
		{
			ActionOrderUIController actionOrderUIController = (ActionOrderUIController)LuaObject.checkSelf(l);
			GameObject actionOrdersGameObject;
			LuaObject.checkType<GameObject>(l, 2, out actionOrdersGameObject);
			actionOrderUIController.m_luaExportHelper.m_actionOrdersGameObject = actionOrdersGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A906 RID: 108806 RVA: 0x007E2A70 File Offset: 0x007E0C70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_okButton(IntPtr l)
	{
		int result;
		try
		{
			ActionOrderUIController actionOrderUIController = (ActionOrderUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, actionOrderUIController.m_luaExportHelper.m_okButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A907 RID: 108807 RVA: 0x007E2AC8 File Offset: 0x007E0CC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_okButton(IntPtr l)
	{
		int result;
		try
		{
			ActionOrderUIController actionOrderUIController = (ActionOrderUIController)LuaObject.checkSelf(l);
			Button okButton;
			LuaObject.checkType<Button>(l, 2, out okButton);
			actionOrderUIController.m_luaExportHelper.m_okButton = okButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A908 RID: 108808 RVA: 0x007E2B24 File Offset: 0x007E0D24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_prefabsGameObject(IntPtr l)
	{
		int result;
		try
		{
			ActionOrderUIController actionOrderUIController = (ActionOrderUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, actionOrderUIController.m_luaExportHelper.m_prefabsGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A909 RID: 108809 RVA: 0x007E2B7C File Offset: 0x007E0D7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_prefabsGameObject(IntPtr l)
	{
		int result;
		try
		{
			ActionOrderUIController actionOrderUIController = (ActionOrderUIController)LuaObject.checkSelf(l);
			GameObject prefabsGameObject;
			LuaObject.checkType<GameObject>(l, 2, out prefabsGameObject);
			actionOrderUIController.m_luaExportHelper.m_prefabsGameObject = prefabsGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A90A RID: 108810 RVA: 0x007E2BD8 File Offset: 0x007E0DD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_actionOrderButtonPrefab(IntPtr l)
	{
		int result;
		try
		{
			ActionOrderUIController actionOrderUIController = (ActionOrderUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, actionOrderUIController.m_luaExportHelper.m_actionOrderButtonPrefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A90B RID: 108811 RVA: 0x007E2C30 File Offset: 0x007E0E30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_actionOrderButtonPrefab(IntPtr l)
	{
		int result;
		try
		{
			ActionOrderUIController actionOrderUIController = (ActionOrderUIController)LuaObject.checkSelf(l);
			GameObject actionOrderButtonPrefab;
			LuaObject.checkType<GameObject>(l, 2, out actionOrderButtonPrefab);
			actionOrderUIController.m_luaExportHelper.m_actionOrderButtonPrefab = actionOrderButtonPrefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A90C RID: 108812 RVA: 0x007E2C8C File Offset: 0x007E0E8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_actionOrderButtons(IntPtr l)
	{
		int result;
		try
		{
			ActionOrderUIController actionOrderUIController = (ActionOrderUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, actionOrderUIController.m_luaExportHelper.m_actionOrderButtons);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A90D RID: 108813 RVA: 0x007E2CE4 File Offset: 0x007E0EE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_actionOrderButtons(IntPtr l)
	{
		int result;
		try
		{
			ActionOrderUIController actionOrderUIController = (ActionOrderUIController)LuaObject.checkSelf(l);
			ArenaActionOrderButton[] actionOrderButtons;
			LuaObject.checkArray<ArenaActionOrderButton>(l, 2, out actionOrderButtons);
			actionOrderUIController.m_luaExportHelper.m_actionOrderButtons = actionOrderButtons;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A90E RID: 108814 RVA: 0x007E2D40 File Offset: 0x007E0F40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_draggingActionOrderButton(IntPtr l)
	{
		int result;
		try
		{
			ActionOrderUIController actionOrderUIController = (ActionOrderUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, actionOrderUIController.m_luaExportHelper.m_draggingActionOrderButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A90F RID: 108815 RVA: 0x007E2D98 File Offset: 0x007E0F98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_draggingActionOrderButton(IntPtr l)
	{
		int result;
		try
		{
			ActionOrderUIController actionOrderUIController = (ActionOrderUIController)LuaObject.checkSelf(l);
			ArenaActionOrderButton draggingActionOrderButton;
			LuaObject.checkType<ArenaActionOrderButton>(l, 2, out draggingActionOrderButton);
			actionOrderUIController.m_luaExportHelper.m_draggingActionOrderButton = draggingActionOrderButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A910 RID: 108816 RVA: 0x007E2DF4 File Offset: 0x007E0FF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_draggingActionOrderButtonIndex(IntPtr l)
	{
		int result;
		try
		{
			ActionOrderUIController actionOrderUIController = (ActionOrderUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, actionOrderUIController.m_luaExportHelper.m_draggingActionOrderButtonIndex);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A911 RID: 108817 RVA: 0x007E2E4C File Offset: 0x007E104C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_draggingActionOrderButtonIndex(IntPtr l)
	{
		int result;
		try
		{
			ActionOrderUIController actionOrderUIController = (ActionOrderUIController)LuaObject.checkSelf(l);
			int draggingActionOrderButtonIndex;
			LuaObject.checkType(l, 2, out draggingActionOrderButtonIndex);
			actionOrderUIController.m_luaExportHelper.m_draggingActionOrderButtonIndex = draggingActionOrderButtonIndex;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A912 RID: 108818 RVA: 0x007E2EA8 File Offset: 0x007E10A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_camera(IntPtr l)
	{
		int result;
		try
		{
			ActionOrderUIController actionOrderUIController = (ActionOrderUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, actionOrderUIController.m_luaExportHelper.m_camera);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A913 RID: 108819 RVA: 0x007E2F00 File Offset: 0x007E1100
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_camera(IntPtr l)
	{
		int result;
		try
		{
			ActionOrderUIController actionOrderUIController = (ActionOrderUIController)LuaObject.checkSelf(l);
			Camera camera;
			LuaObject.checkType<Camera>(l, 2, out camera);
			actionOrderUIController.m_luaExportHelper.m_camera = camera;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A914 RID: 108820 RVA: 0x007E2F5C File Offset: 0x007E115C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.ActionOrderUIController");
		if (Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActionOrderUIController.Open);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActionOrderUIController.SetHeros);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActionOrderUIController.GetHeroActionOrderIndex);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActionOrderUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActionOrderUIController.OnDisable);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActionOrderUIController.OnApplicationPause);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActionOrderUIController.OnApplicationFocus);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActionOrderUIController.CreateActionOrderButton);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActionOrderUIController.CreateDraggingActionOrderButton);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActionOrderUIController.DestroyDragginActionOrderButton);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActionOrderUIController.MoveDraggingActionOrderButton);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActionOrderUIController.DropDraggingActionOrderButton);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActionOrderUIController.OnBackgroundButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActionOrderUIController.OnOkButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActionOrderUIController.ActionOrderButton_OnClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActionOrderUIController.ActionOrderButton_OnBeginDrag);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActionOrderUIController.ActionOrderButton_OnEndDrag);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActionOrderUIController.ActionOrderButton_OnDrag);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActionOrderUIController.ActionOrderButton_OnDrop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActionOrderUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActionOrderUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActionOrderUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActionOrderUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActionOrderUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActionOrderUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActionOrderUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActionOrderUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActionOrderUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActionOrderUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActionOrderUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActionOrderUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActionOrderUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActionOrderUIController.__callDele_EventOnConfirm);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActionOrderUIController.__clearDele_EventOnConfirm);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cache21);
		string name = "EventOnConfirm";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActionOrderUIController.set_EventOnConfirm);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cache22, true);
		string name2 = "m_uiStateController";
		if (Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActionOrderUIController.get_m_uiStateController);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cache23;
		if (Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActionOrderUIController.set_m_uiStateController);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cache24, true);
		string name3 = "m_backgroundButton";
		if (Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActionOrderUIController.get_m_backgroundButton);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cache25;
		if (Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActionOrderUIController.set_m_backgroundButton);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cache26, true);
		string name4 = "m_actionOrdersGameObject";
		if (Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActionOrderUIController.get_m_actionOrdersGameObject);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cache27;
		if (Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActionOrderUIController.set_m_actionOrdersGameObject);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cache28, true);
		string name5 = "m_okButton";
		if (Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActionOrderUIController.get_m_okButton);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cache29;
		if (Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActionOrderUIController.set_m_okButton);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cache2A, true);
		string name6 = "m_prefabsGameObject";
		if (Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActionOrderUIController.get_m_prefabsGameObject);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cache2B;
		if (Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActionOrderUIController.set_m_prefabsGameObject);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cache2C, true);
		string name7 = "m_actionOrderButtonPrefab";
		if (Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActionOrderUIController.get_m_actionOrderButtonPrefab);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cache2D;
		if (Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActionOrderUIController.set_m_actionOrderButtonPrefab);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cache2E, true);
		string name8 = "m_actionOrderButtons";
		if (Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActionOrderUIController.get_m_actionOrderButtons);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cache2F;
		if (Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActionOrderUIController.set_m_actionOrderButtons);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cache30, true);
		string name9 = "m_draggingActionOrderButton";
		if (Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActionOrderUIController.get_m_draggingActionOrderButton);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cache31;
		if (Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActionOrderUIController.set_m_draggingActionOrderButton);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cache32, true);
		string name10 = "m_draggingActionOrderButtonIndex";
		if (Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActionOrderUIController.get_m_draggingActionOrderButtonIndex);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cache33;
		if (Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActionOrderUIController.set_m_draggingActionOrderButtonIndex);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cache34, true);
		string name11 = "m_camera";
		if (Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActionOrderUIController.get_m_camera);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cache35;
		if (Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActionOrderUIController.set_m_camera);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_ActionOrderUIController.<>f__mg$cache36, true);
		LuaObject.createTypeMetatable(l, null, typeof(ActionOrderUIController), typeof(UIControllerBase));
	}

	// Token: 0x04010C21 RID: 68641
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04010C22 RID: 68642
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04010C23 RID: 68643
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04010C24 RID: 68644
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04010C25 RID: 68645
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04010C26 RID: 68646
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04010C27 RID: 68647
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04010C28 RID: 68648
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04010C29 RID: 68649
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04010C2A RID: 68650
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04010C2B RID: 68651
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04010C2C RID: 68652
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04010C2D RID: 68653
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04010C2E RID: 68654
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04010C2F RID: 68655
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04010C30 RID: 68656
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04010C31 RID: 68657
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04010C32 RID: 68658
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04010C33 RID: 68659
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04010C34 RID: 68660
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04010C35 RID: 68661
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04010C36 RID: 68662
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04010C37 RID: 68663
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04010C38 RID: 68664
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04010C39 RID: 68665
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04010C3A RID: 68666
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04010C3B RID: 68667
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04010C3C RID: 68668
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04010C3D RID: 68669
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04010C3E RID: 68670
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04010C3F RID: 68671
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04010C40 RID: 68672
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04010C41 RID: 68673
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04010C42 RID: 68674
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04010C43 RID: 68675
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04010C44 RID: 68676
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04010C45 RID: 68677
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04010C46 RID: 68678
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04010C47 RID: 68679
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04010C48 RID: 68680
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04010C49 RID: 68681
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04010C4A RID: 68682
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04010C4B RID: 68683
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04010C4C RID: 68684
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04010C4D RID: 68685
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04010C4E RID: 68686
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04010C4F RID: 68687
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04010C50 RID: 68688
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04010C51 RID: 68689
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04010C52 RID: 68690
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04010C53 RID: 68691
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x04010C54 RID: 68692
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x04010C55 RID: 68693
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x04010C56 RID: 68694
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x04010C57 RID: 68695
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;
}
