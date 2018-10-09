using System;
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

// Token: 0x020014B9 RID: 5305
[Preserve]
public class Lua_BlackJack_ProjectL_UI_HeroDragButton : LuaObject
{
	// Token: 0x0601EFC9 RID: 126921 RVA: 0x00A158F0 File Offset: 0x00A13AF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Destroy(IntPtr l)
	{
		int result;
		try
		{
			HeroDragButton heroDragButton = (HeroDragButton)LuaObject.checkSelf(l);
			heroDragButton.Destroy();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EFCA RID: 126922 RVA: 0x00A1593C File Offset: 0x00A13B3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetHero(IntPtr l)
	{
		int result;
		try
		{
			HeroDragButton heroDragButton = (HeroDragButton)LuaObject.checkSelf(l);
			BattleHero hero;
			LuaObject.checkType<BattleHero>(l, 2, out hero);
			heroDragButton.SetHero(hero);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EFCB RID: 126923 RVA: 0x00A15994 File Offset: 0x00A13B94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetHero(IntPtr l)
	{
		int result;
		try
		{
			HeroDragButton heroDragButton = (HeroDragButton)LuaObject.checkSelf(l);
			BattleHero hero = heroDragButton.GetHero();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, hero);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EFCC RID: 126924 RVA: 0x00A159E8 File Offset: 0x00A13BE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetPosition(IntPtr l)
	{
		int result;
		try
		{
			HeroDragButton heroDragButton = (HeroDragButton)LuaObject.checkSelf(l);
			GridPosition position;
			LuaObject.checkValueType<GridPosition>(l, 2, out position);
			heroDragButton.SetPosition(position);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EFCD RID: 126925 RVA: 0x00A15A40 File Offset: 0x00A13C40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetPosition(IntPtr l)
	{
		int result;
		try
		{
			HeroDragButton heroDragButton = (HeroDragButton)LuaObject.checkSelf(l);
			GridPosition position = heroDragButton.GetPosition();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, position);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EFCE RID: 126926 RVA: 0x00A15A9C File Offset: 0x00A13C9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DisableRaycastTarget(IntPtr l)
	{
		int result;
		try
		{
			HeroDragButton heroDragButton = (HeroDragButton)LuaObject.checkSelf(l);
			heroDragButton.DisableRaycastTarget();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EFCF RID: 126927 RVA: 0x00A15AE8 File Offset: 0x00A13CE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetEnabled(IntPtr l)
	{
		int result;
		try
		{
			HeroDragButton heroDragButton = (HeroDragButton)LuaObject.checkSelf(l);
			bool enabled;
			LuaObject.checkType(l, 2, out enabled);
			heroDragButton.SetEnabled(enabled);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EFD0 RID: 126928 RVA: 0x00A15B40 File Offset: 0x00A13D40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsEnabled(IntPtr l)
	{
		int result;
		try
		{
			HeroDragButton heroDragButton = (HeroDragButton)LuaObject.checkSelf(l);
			bool b = heroDragButton.IsEnabled();
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

	// Token: 0x0601EFD1 RID: 126929 RVA: 0x00A15B94 File Offset: 0x00A13D94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetTagType(IntPtr l)
	{
		int result;
		try
		{
			HeroDragButton heroDragButton = (HeroDragButton)LuaObject.checkSelf(l);
			StageActorTagType tagType;
			LuaObject.checkEnum<StageActorTagType>(l, 2, out tagType);
			heroDragButton.SetTagType(tagType);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EFD2 RID: 126930 RVA: 0x00A15BEC File Offset: 0x00A13DEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnPointerDown(IntPtr l)
	{
		int result;
		try
		{
			HeroDragButton heroDragButton = (HeroDragButton)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			heroDragButton.OnPointerDown(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EFD3 RID: 126931 RVA: 0x00A15C44 File Offset: 0x00A13E44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnPointerUp(IntPtr l)
	{
		int result;
		try
		{
			HeroDragButton heroDragButton = (HeroDragButton)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			heroDragButton.OnPointerUp(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EFD4 RID: 126932 RVA: 0x00A15C9C File Offset: 0x00A13E9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnPointerClick(IntPtr l)
	{
		int result;
		try
		{
			HeroDragButton heroDragButton = (HeroDragButton)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			heroDragButton.OnPointerClick(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EFD5 RID: 126933 RVA: 0x00A15CF4 File Offset: 0x00A13EF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CancelDrag(IntPtr l)
	{
		int result;
		try
		{
			HeroDragButton heroDragButton = (HeroDragButton)LuaObject.checkSelf(l);
			heroDragButton.CancelDrag();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EFD6 RID: 126934 RVA: 0x00A15D40 File Offset: 0x00A13F40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			HeroDragButton heroDragButton = (HeroDragButton)LuaObject.checkSelf(l);
			heroDragButton.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EFD7 RID: 126935 RVA: 0x00A15D94 File Offset: 0x00A13F94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBeginDrag(IntPtr l)
	{
		int result;
		try
		{
			HeroDragButton heroDragButton = (HeroDragButton)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			heroDragButton.m_luaExportHelper.OnBeginDrag(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EFD8 RID: 126936 RVA: 0x00A15DF0 File Offset: 0x00A13FF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnEndDrag(IntPtr l)
	{
		int result;
		try
		{
			HeroDragButton heroDragButton = (HeroDragButton)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			heroDragButton.m_luaExportHelper.OnEndDrag(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EFD9 RID: 126937 RVA: 0x00A15E4C File Offset: 0x00A1404C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnDrag(IntPtr l)
	{
		int result;
		try
		{
			HeroDragButton heroDragButton = (HeroDragButton)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			heroDragButton.m_luaExportHelper.OnDrag(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EFDA RID: 126938 RVA: 0x00A15EA8 File Offset: 0x00A140A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnDrop(IntPtr l)
	{
		int result;
		try
		{
			HeroDragButton heroDragButton = (HeroDragButton)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			heroDragButton.m_luaExportHelper.OnDrop(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EFDB RID: 126939 RVA: 0x00A15F04 File Offset: 0x00A14104
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Update(IntPtr l)
	{
		int result;
		try
		{
			HeroDragButton heroDragButton = (HeroDragButton)LuaObject.checkSelf(l);
			heroDragButton.m_luaExportHelper.Update();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EFDC RID: 126940 RVA: 0x00A15F58 File Offset: 0x00A14158
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			HeroDragButton heroDragButton = (HeroDragButton)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			heroDragButton.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EFDD RID: 126941 RVA: 0x00A15FC4 File Offset: 0x00A141C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			HeroDragButton heroDragButton = (HeroDragButton)LuaObject.checkSelf(l);
			heroDragButton.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EFDE RID: 126942 RVA: 0x00A16018 File Offset: 0x00A14218
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			HeroDragButton heroDragButton = (HeroDragButton)LuaObject.checkSelf(l);
			heroDragButton.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EFDF RID: 126943 RVA: 0x00A1606C File Offset: 0x00A1426C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			HeroDragButton heroDragButton = (HeroDragButton)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = heroDragButton.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601EFE0 RID: 126944 RVA: 0x00A16114 File Offset: 0x00A14314
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			HeroDragButton heroDragButton = (HeroDragButton)LuaObject.checkSelf(l);
			heroDragButton.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EFE1 RID: 126945 RVA: 0x00A16168 File Offset: 0x00A14368
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroDragButton heroDragButton = (HeroDragButton)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			heroDragButton.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EFE2 RID: 126946 RVA: 0x00A161D4 File Offset: 0x00A143D4
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
				HeroDragButton heroDragButton = (HeroDragButton)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				heroDragButton.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				HeroDragButton heroDragButton2 = (HeroDragButton)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				heroDragButton2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601EFE3 RID: 126947 RVA: 0x00A162E4 File Offset: 0x00A144E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			HeroDragButton heroDragButton = (HeroDragButton)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroDragButton.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EFE4 RID: 126948 RVA: 0x00A16350 File Offset: 0x00A14550
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			HeroDragButton heroDragButton = (HeroDragButton)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroDragButton.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EFE5 RID: 126949 RVA: 0x00A163BC File Offset: 0x00A145BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			HeroDragButton heroDragButton = (HeroDragButton)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroDragButton.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EFE6 RID: 126950 RVA: 0x00A16428 File Offset: 0x00A14628
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			HeroDragButton heroDragButton = (HeroDragButton)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroDragButton.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EFE7 RID: 126951 RVA: 0x00A16494 File Offset: 0x00A14694
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
				HeroDragButton heroDragButton = (HeroDragButton)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				heroDragButton.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				HeroDragButton heroDragButton2 = (HeroDragButton)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				heroDragButton2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601EFE8 RID: 126952 RVA: 0x00A165A4 File Offset: 0x00A147A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			HeroDragButton heroDragButton = (HeroDragButton)LuaObject.checkSelf(l);
			string s = heroDragButton.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601EFE9 RID: 126953 RVA: 0x00A16600 File Offset: 0x00A14800
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnClick(IntPtr l)
	{
		int result;
		try
		{
			HeroDragButton heroDragButton = (HeroDragButton)LuaObject.checkSelf(l);
			HeroDragButton obj;
			LuaObject.checkType<HeroDragButton>(l, 2, out obj);
			heroDragButton.m_luaExportHelper.__callDele_EventOnClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EFEA RID: 126954 RVA: 0x00A1665C File Offset: 0x00A1485C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnClick(IntPtr l)
	{
		int result;
		try
		{
			HeroDragButton heroDragButton = (HeroDragButton)LuaObject.checkSelf(l);
			HeroDragButton obj;
			LuaObject.checkType<HeroDragButton>(l, 2, out obj);
			heroDragButton.m_luaExportHelper.__clearDele_EventOnClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EFEB RID: 126955 RVA: 0x00A166B8 File Offset: 0x00A148B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnBeginDrag(IntPtr l)
	{
		int result;
		try
		{
			HeroDragButton heroDragButton = (HeroDragButton)LuaObject.checkSelf(l);
			HeroDragButton arg;
			LuaObject.checkType<HeroDragButton>(l, 2, out arg);
			PointerEventData arg2;
			LuaObject.checkType<PointerEventData>(l, 3, out arg2);
			heroDragButton.m_luaExportHelper.__callDele_EventOnBeginDrag(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EFEC RID: 126956 RVA: 0x00A16724 File Offset: 0x00A14924
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnBeginDrag(IntPtr l)
	{
		int result;
		try
		{
			HeroDragButton heroDragButton = (HeroDragButton)LuaObject.checkSelf(l);
			HeroDragButton arg;
			LuaObject.checkType<HeroDragButton>(l, 2, out arg);
			PointerEventData arg2;
			LuaObject.checkType<PointerEventData>(l, 3, out arg2);
			heroDragButton.m_luaExportHelper.__clearDele_EventOnBeginDrag(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EFED RID: 126957 RVA: 0x00A16790 File Offset: 0x00A14990
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnEndDrag(IntPtr l)
	{
		int result;
		try
		{
			HeroDragButton heroDragButton = (HeroDragButton)LuaObject.checkSelf(l);
			HeroDragButton arg;
			LuaObject.checkType<HeroDragButton>(l, 2, out arg);
			PointerEventData arg2;
			LuaObject.checkType<PointerEventData>(l, 3, out arg2);
			heroDragButton.m_luaExportHelper.__callDele_EventOnEndDrag(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EFEE RID: 126958 RVA: 0x00A167FC File Offset: 0x00A149FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnEndDrag(IntPtr l)
	{
		int result;
		try
		{
			HeroDragButton heroDragButton = (HeroDragButton)LuaObject.checkSelf(l);
			HeroDragButton arg;
			LuaObject.checkType<HeroDragButton>(l, 2, out arg);
			PointerEventData arg2;
			LuaObject.checkType<PointerEventData>(l, 3, out arg2);
			heroDragButton.m_luaExportHelper.__clearDele_EventOnEndDrag(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EFEF RID: 126959 RVA: 0x00A16868 File Offset: 0x00A14A68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnDrag(IntPtr l)
	{
		int result;
		try
		{
			HeroDragButton heroDragButton = (HeroDragButton)LuaObject.checkSelf(l);
			PointerEventData obj;
			LuaObject.checkType<PointerEventData>(l, 2, out obj);
			heroDragButton.m_luaExportHelper.__callDele_EventOnDrag(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EFF0 RID: 126960 RVA: 0x00A168C4 File Offset: 0x00A14AC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnDrag(IntPtr l)
	{
		int result;
		try
		{
			HeroDragButton heroDragButton = (HeroDragButton)LuaObject.checkSelf(l);
			PointerEventData obj;
			LuaObject.checkType<PointerEventData>(l, 2, out obj);
			heroDragButton.m_luaExportHelper.__clearDele_EventOnDrag(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EFF1 RID: 126961 RVA: 0x00A16920 File Offset: 0x00A14B20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnDrop(IntPtr l)
	{
		int result;
		try
		{
			HeroDragButton heroDragButton = (HeroDragButton)LuaObject.checkSelf(l);
			PointerEventData obj;
			LuaObject.checkType<PointerEventData>(l, 2, out obj);
			heroDragButton.m_luaExportHelper.__callDele_EventOnDrop(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EFF2 RID: 126962 RVA: 0x00A1697C File Offset: 0x00A14B7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnDrop(IntPtr l)
	{
		int result;
		try
		{
			HeroDragButton heroDragButton = (HeroDragButton)LuaObject.checkSelf(l);
			PointerEventData obj;
			LuaObject.checkType<PointerEventData>(l, 2, out obj);
			heroDragButton.m_luaExportHelper.__clearDele_EventOnDrop(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EFF3 RID: 126963 RVA: 0x00A169D8 File Offset: 0x00A14BD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnClick(IntPtr l)
	{
		int result;
		try
		{
			HeroDragButton heroDragButton = (HeroDragButton)LuaObject.checkSelf(l);
			Action<HeroDragButton> value;
			int num = LuaObject.checkDelegate<Action<HeroDragButton>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					heroDragButton.EventOnClick += value;
				}
				else if (num == 2)
				{
					heroDragButton.EventOnClick -= value;
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

	// Token: 0x0601EFF4 RID: 126964 RVA: 0x00A16A58 File Offset: 0x00A14C58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnBeginDrag(IntPtr l)
	{
		int result;
		try
		{
			HeroDragButton heroDragButton = (HeroDragButton)LuaObject.checkSelf(l);
			Action<HeroDragButton, PointerEventData> value;
			int num = LuaObject.checkDelegate<Action<HeroDragButton, PointerEventData>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					heroDragButton.EventOnBeginDrag += value;
				}
				else if (num == 2)
				{
					heroDragButton.EventOnBeginDrag -= value;
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

	// Token: 0x0601EFF5 RID: 126965 RVA: 0x00A16AD8 File Offset: 0x00A14CD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnEndDrag(IntPtr l)
	{
		int result;
		try
		{
			HeroDragButton heroDragButton = (HeroDragButton)LuaObject.checkSelf(l);
			Action<HeroDragButton, PointerEventData> value;
			int num = LuaObject.checkDelegate<Action<HeroDragButton, PointerEventData>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					heroDragButton.EventOnEndDrag += value;
				}
				else if (num == 2)
				{
					heroDragButton.EventOnEndDrag -= value;
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

	// Token: 0x0601EFF6 RID: 126966 RVA: 0x00A16B58 File Offset: 0x00A14D58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnDrag(IntPtr l)
	{
		int result;
		try
		{
			HeroDragButton heroDragButton = (HeroDragButton)LuaObject.checkSelf(l);
			Action<PointerEventData> value;
			int num = LuaObject.checkDelegate<Action<PointerEventData>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					heroDragButton.EventOnDrag += value;
				}
				else if (num == 2)
				{
					heroDragButton.EventOnDrag -= value;
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

	// Token: 0x0601EFF7 RID: 126967 RVA: 0x00A16BD8 File Offset: 0x00A14DD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnDrop(IntPtr l)
	{
		int result;
		try
		{
			HeroDragButton heroDragButton = (HeroDragButton)LuaObject.checkSelf(l);
			Action<PointerEventData> value;
			int num = LuaObject.checkDelegate<Action<PointerEventData>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					heroDragButton.EventOnDrop += value;
				}
				else if (num == 2)
				{
					heroDragButton.EventOnDrop -= value;
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

	// Token: 0x0601EFF8 RID: 126968 RVA: 0x00A16C58 File Offset: 0x00A14E58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_button(IntPtr l)
	{
		int result;
		try
		{
			HeroDragButton heroDragButton = (HeroDragButton)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDragButton.m_luaExportHelper.m_button);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EFF9 RID: 126969 RVA: 0x00A16CB0 File Offset: 0x00A14EB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_button(IntPtr l)
	{
		int result;
		try
		{
			HeroDragButton heroDragButton = (HeroDragButton)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			heroDragButton.m_luaExportHelper.m_button = button;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EFFA RID: 126970 RVA: 0x00A16D0C File Offset: 0x00A14F0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_headImage(IntPtr l)
	{
		int result;
		try
		{
			HeroDragButton heroDragButton = (HeroDragButton)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDragButton.m_luaExportHelper.m_headImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EFFB RID: 126971 RVA: 0x00A16D64 File Offset: 0x00A14F64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_headImage(IntPtr l)
	{
		int result;
		try
		{
			HeroDragButton heroDragButton = (HeroDragButton)LuaObject.checkSelf(l);
			Image headImage;
			LuaObject.checkType<Image>(l, 2, out headImage);
			heroDragButton.m_luaExportHelper.m_headImage = headImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EFFC RID: 126972 RVA: 0x00A16DC0 File Offset: 0x00A14FC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_armyImage(IntPtr l)
	{
		int result;
		try
		{
			HeroDragButton heroDragButton = (HeroDragButton)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDragButton.m_luaExportHelper.m_armyImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EFFD RID: 126973 RVA: 0x00A16E18 File Offset: 0x00A15018
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_armyImage(IntPtr l)
	{
		int result;
		try
		{
			HeroDragButton heroDragButton = (HeroDragButton)LuaObject.checkSelf(l);
			Image armyImage;
			LuaObject.checkType<Image>(l, 2, out armyImage);
			heroDragButton.m_luaExportHelper.m_armyImage = armyImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EFFE RID: 126974 RVA: 0x00A16E74 File Offset: 0x00A15074
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_levelText(IntPtr l)
	{
		int result;
		try
		{
			HeroDragButton heroDragButton = (HeroDragButton)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDragButton.m_luaExportHelper.m_levelText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EFFF RID: 126975 RVA: 0x00A16ECC File Offset: 0x00A150CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_levelText(IntPtr l)
	{
		int result;
		try
		{
			HeroDragButton heroDragButton = (HeroDragButton)LuaObject.checkSelf(l);
			Text levelText;
			LuaObject.checkType<Text>(l, 2, out levelText);
			heroDragButton.m_luaExportHelper.m_levelText = levelText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F000 RID: 126976 RVA: 0x00A16F28 File Offset: 0x00A15128
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_scoreBonusTagGameObject(IntPtr l)
	{
		int result;
		try
		{
			HeroDragButton heroDragButton = (HeroDragButton)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDragButton.m_luaExportHelper.m_scoreBonusTagGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F001 RID: 126977 RVA: 0x00A16F80 File Offset: 0x00A15180
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_scoreBonusTagGameObject(IntPtr l)
	{
		int result;
		try
		{
			HeroDragButton heroDragButton = (HeroDragButton)LuaObject.checkSelf(l);
			GameObject scoreBonusTagGameObject;
			LuaObject.checkType<GameObject>(l, 2, out scoreBonusTagGameObject);
			heroDragButton.m_luaExportHelper.m_scoreBonusTagGameObject = scoreBonusTagGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F002 RID: 126978 RVA: 0x00A16FDC File Offset: 0x00A151DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_powerUpTagGameObject(IntPtr l)
	{
		int result;
		try
		{
			HeroDragButton heroDragButton = (HeroDragButton)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDragButton.m_luaExportHelper.m_powerUpTagGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F003 RID: 126979 RVA: 0x00A17034 File Offset: 0x00A15234
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_powerUpTagGameObject(IntPtr l)
	{
		int result;
		try
		{
			HeroDragButton heroDragButton = (HeroDragButton)LuaObject.checkSelf(l);
			GameObject powerUpTagGameObject;
			LuaObject.checkType<GameObject>(l, 2, out powerUpTagGameObject);
			heroDragButton.m_luaExportHelper.m_powerUpTagGameObject = powerUpTagGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F004 RID: 126980 RVA: 0x00A17090 File Offset: 0x00A15290
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_campUpTagGameObject(IntPtr l)
	{
		int result;
		try
		{
			HeroDragButton heroDragButton = (HeroDragButton)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDragButton.m_luaExportHelper.m_campUpTagGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F005 RID: 126981 RVA: 0x00A170E8 File Offset: 0x00A152E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_campUpTagGameObject(IntPtr l)
	{
		int result;
		try
		{
			HeroDragButton heroDragButton = (HeroDragButton)LuaObject.checkSelf(l);
			GameObject campUpTagGameObject;
			LuaObject.checkType<GameObject>(l, 2, out campUpTagGameObject);
			heroDragButton.m_luaExportHelper.m_campUpTagGameObject = campUpTagGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F006 RID: 126982 RVA: 0x00A17144 File Offset: 0x00A15344
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiStateController(IntPtr l)
	{
		int result;
		try
		{
			HeroDragButton heroDragButton = (HeroDragButton)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDragButton.m_luaExportHelper.m_uiStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F007 RID: 126983 RVA: 0x00A1719C File Offset: 0x00A1539C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiStateController(IntPtr l)
	{
		int result;
		try
		{
			HeroDragButton heroDragButton = (HeroDragButton)LuaObject.checkSelf(l);
			CommonUIStateController uiStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out uiStateController);
			heroDragButton.m_luaExportHelper.m_uiStateController = uiStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F008 RID: 126984 RVA: 0x00A171F8 File Offset: 0x00A153F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_position(IntPtr l)
	{
		int result;
		try
		{
			HeroDragButton heroDragButton = (HeroDragButton)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDragButton.m_luaExportHelper.m_position);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F009 RID: 126985 RVA: 0x00A17254 File Offset: 0x00A15454
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_position(IntPtr l)
	{
		int result;
		try
		{
			HeroDragButton heroDragButton = (HeroDragButton)LuaObject.checkSelf(l);
			GridPosition position;
			LuaObject.checkValueType<GridPosition>(l, 2, out position);
			heroDragButton.m_luaExportHelper.m_position = position;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F00A RID: 126986 RVA: 0x00A172B0 File Offset: 0x00A154B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_hero(IntPtr l)
	{
		int result;
		try
		{
			HeroDragButton heroDragButton = (HeroDragButton)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDragButton.m_luaExportHelper.m_hero);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F00B RID: 126987 RVA: 0x00A17308 File Offset: 0x00A15508
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_hero(IntPtr l)
	{
		int result;
		try
		{
			HeroDragButton heroDragButton = (HeroDragButton)LuaObject.checkSelf(l);
			BattleHero hero;
			LuaObject.checkType<BattleHero>(l, 2, out hero);
			heroDragButton.m_luaExportHelper.m_hero = hero;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F00C RID: 126988 RVA: 0x00A17364 File Offset: 0x00A15564
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isEnabled(IntPtr l)
	{
		int result;
		try
		{
			HeroDragButton heroDragButton = (HeroDragButton)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDragButton.m_luaExportHelper.m_isEnabled);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F00D RID: 126989 RVA: 0x00A173BC File Offset: 0x00A155BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isEnabled(IntPtr l)
	{
		int result;
		try
		{
			HeroDragButton heroDragButton = (HeroDragButton)LuaObject.checkSelf(l);
			bool isEnabled;
			LuaObject.checkType(l, 2, out isEnabled);
			heroDragButton.m_luaExportHelper.m_isEnabled = isEnabled;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F00E RID: 126990 RVA: 0x00A17418 File Offset: 0x00A15618
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_InvalidPointerDownID(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, HeroDragButton.LuaExportHelper.InvalidPointerDownID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F00F RID: 126991 RVA: 0x00A17460 File Offset: 0x00A15660
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_pointerDownId(IntPtr l)
	{
		int result;
		try
		{
			HeroDragButton heroDragButton = (HeroDragButton)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDragButton.m_luaExportHelper.m_pointerDownId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F010 RID: 126992 RVA: 0x00A174B8 File Offset: 0x00A156B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_pointerDownId(IntPtr l)
	{
		int result;
		try
		{
			HeroDragButton heroDragButton = (HeroDragButton)LuaObject.checkSelf(l);
			int pointerDownId;
			LuaObject.checkType(l, 2, out pointerDownId);
			heroDragButton.m_luaExportHelper.m_pointerDownId = pointerDownId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F011 RID: 126993 RVA: 0x00A17514 File Offset: 0x00A15714
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isDetectingDrag(IntPtr l)
	{
		int result;
		try
		{
			HeroDragButton heroDragButton = (HeroDragButton)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDragButton.m_luaExportHelper.m_isDetectingDrag);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F012 RID: 126994 RVA: 0x00A1756C File Offset: 0x00A1576C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isDetectingDrag(IntPtr l)
	{
		int result;
		try
		{
			HeroDragButton heroDragButton = (HeroDragButton)LuaObject.checkSelf(l);
			bool isDetectingDrag;
			LuaObject.checkType(l, 2, out isDetectingDrag);
			heroDragButton.m_luaExportHelper.m_isDetectingDrag = isDetectingDrag;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F013 RID: 126995 RVA: 0x00A175C8 File Offset: 0x00A157C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_ignoreClick(IntPtr l)
	{
		int result;
		try
		{
			HeroDragButton heroDragButton = (HeroDragButton)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDragButton.m_luaExportHelper.m_ignoreClick);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F014 RID: 126996 RVA: 0x00A17620 File Offset: 0x00A15820
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_ignoreClick(IntPtr l)
	{
		int result;
		try
		{
			HeroDragButton heroDragButton = (HeroDragButton)LuaObject.checkSelf(l);
			bool ignoreClick;
			LuaObject.checkType(l, 2, out ignoreClick);
			heroDragButton.m_luaExportHelper.m_ignoreClick = ignoreClick;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F015 RID: 126997 RVA: 0x00A1767C File Offset: 0x00A1587C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_pointerDownPosition(IntPtr l)
	{
		int result;
		try
		{
			HeroDragButton heroDragButton = (HeroDragButton)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDragButton.m_luaExportHelper.m_pointerDownPosition);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F016 RID: 126998 RVA: 0x00A176D4 File Offset: 0x00A158D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_pointerDownPosition(IntPtr l)
	{
		int result;
		try
		{
			HeroDragButton heroDragButton = (HeroDragButton)LuaObject.checkSelf(l);
			Vector2 pointerDownPosition;
			LuaObject.checkType(l, 2, out pointerDownPosition);
			heroDragButton.m_luaExportHelper.m_pointerDownPosition = pointerDownPosition;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F017 RID: 126999 RVA: 0x00A17730 File Offset: 0x00A15930
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_dragEventData(IntPtr l)
	{
		int result;
		try
		{
			HeroDragButton heroDragButton = (HeroDragButton)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDragButton.m_luaExportHelper.m_dragEventData);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F018 RID: 127000 RVA: 0x00A17788 File Offset: 0x00A15988
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_dragEventData(IntPtr l)
	{
		int result;
		try
		{
			HeroDragButton heroDragButton = (HeroDragButton)LuaObject.checkSelf(l);
			PointerEventData dragEventData;
			LuaObject.checkType<PointerEventData>(l, 2, out dragEventData);
			heroDragButton.m_luaExportHelper.m_dragEventData = dragEventData;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F019 RID: 127001 RVA: 0x00A177E4 File Offset: 0x00A159E4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.HeroDragButton");
		if (Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDragButton.Destroy);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDragButton.SetHero);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDragButton.GetHero);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDragButton.SetPosition);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDragButton.GetPosition);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDragButton.DisableRaycastTarget);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDragButton.SetEnabled);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDragButton.IsEnabled);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDragButton.SetTagType);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDragButton.OnPointerDown);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDragButton.OnPointerUp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDragButton.OnPointerClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDragButton.CancelDrag);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDragButton.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDragButton.OnBeginDrag);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDragButton.OnEndDrag);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDragButton.OnDrag);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDragButton.OnDrop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDragButton.Update);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDragButton.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDragButton.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDragButton.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDragButton.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDragButton.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDragButton.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDragButton.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDragButton.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDragButton.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDragButton.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDragButton.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDragButton.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDragButton.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDragButton.__callDele_EventOnClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDragButton.__clearDele_EventOnClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDragButton.__callDele_EventOnBeginDrag);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDragButton.__clearDele_EventOnBeginDrag);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDragButton.__callDele_EventOnEndDrag);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDragButton.__clearDele_EventOnEndDrag);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache25);
		if (Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDragButton.__callDele_EventOnDrag);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache26);
		if (Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDragButton.__clearDele_EventOnDrag);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache27);
		if (Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDragButton.__callDele_EventOnDrop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache28);
		if (Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDragButton.__clearDele_EventOnDrop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache29);
		string name = "EventOnClick";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDragButton.set_EventOnClick);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache2A, true);
		string name2 = "EventOnBeginDrag";
		LuaCSFunction get2 = null;
		if (Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDragButton.set_EventOnBeginDrag);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache2B, true);
		string name3 = "EventOnEndDrag";
		LuaCSFunction get3 = null;
		if (Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDragButton.set_EventOnEndDrag);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache2C, true);
		string name4 = "EventOnDrag";
		LuaCSFunction get4 = null;
		if (Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDragButton.set_EventOnDrag);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache2D, true);
		string name5 = "EventOnDrop";
		LuaCSFunction get5 = null;
		if (Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDragButton.set_EventOnDrop);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache2E, true);
		string name6 = "m_button";
		if (Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDragButton.get_m_button);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache2F;
		if (Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDragButton.set_m_button);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache30, true);
		string name7 = "m_headImage";
		if (Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDragButton.get_m_headImage);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache31;
		if (Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDragButton.set_m_headImage);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache32, true);
		string name8 = "m_armyImage";
		if (Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDragButton.get_m_armyImage);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache33;
		if (Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDragButton.set_m_armyImage);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache34, true);
		string name9 = "m_levelText";
		if (Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDragButton.get_m_levelText);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache35;
		if (Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDragButton.set_m_levelText);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache36, true);
		string name10 = "m_scoreBonusTagGameObject";
		if (Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDragButton.get_m_scoreBonusTagGameObject);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache37;
		if (Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDragButton.set_m_scoreBonusTagGameObject);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache38, true);
		string name11 = "m_powerUpTagGameObject";
		if (Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDragButton.get_m_powerUpTagGameObject);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache39;
		if (Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDragButton.set_m_powerUpTagGameObject);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache3A, true);
		string name12 = "m_campUpTagGameObject";
		if (Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDragButton.get_m_campUpTagGameObject);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache3B;
		if (Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDragButton.set_m_campUpTagGameObject);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache3C, true);
		string name13 = "m_uiStateController";
		if (Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDragButton.get_m_uiStateController);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache3D;
		if (Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDragButton.set_m_uiStateController);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache3E, true);
		string name14 = "m_position";
		if (Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDragButton.get_m_position);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache3F;
		if (Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDragButton.set_m_position);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache40, true);
		string name15 = "m_hero";
		if (Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDragButton.get_m_hero);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache41;
		if (Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDragButton.set_m_hero);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache42, true);
		string name16 = "m_isEnabled";
		if (Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDragButton.get_m_isEnabled);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache43;
		if (Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDragButton.set_m_isEnabled);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache44, true);
		string name17 = "InvalidPointerDownID";
		if (Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDragButton.get_InvalidPointerDownID);
		}
		LuaObject.addMember(l, name17, Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache45, null, false);
		string name18 = "m_pointerDownId";
		if (Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache46 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache46 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDragButton.get_m_pointerDownId);
		}
		LuaCSFunction get17 = Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache46;
		if (Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache47 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache47 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDragButton.set_m_pointerDownId);
		}
		LuaObject.addMember(l, name18, get17, Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache47, true);
		string name19 = "m_isDetectingDrag";
		if (Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache48 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache48 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDragButton.get_m_isDetectingDrag);
		}
		LuaCSFunction get18 = Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache48;
		if (Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache49 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache49 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDragButton.set_m_isDetectingDrag);
		}
		LuaObject.addMember(l, name19, get18, Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache49, true);
		string name20 = "m_ignoreClick";
		if (Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache4A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache4A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDragButton.get_m_ignoreClick);
		}
		LuaCSFunction get19 = Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache4A;
		if (Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache4B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache4B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDragButton.set_m_ignoreClick);
		}
		LuaObject.addMember(l, name20, get19, Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache4B, true);
		string name21 = "m_pointerDownPosition";
		if (Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache4C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache4C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDragButton.get_m_pointerDownPosition);
		}
		LuaCSFunction get20 = Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache4C;
		if (Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache4D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache4D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDragButton.set_m_pointerDownPosition);
		}
		LuaObject.addMember(l, name21, get20, Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache4D, true);
		string name22 = "m_dragEventData";
		if (Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache4E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache4E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDragButton.get_m_dragEventData);
		}
		LuaCSFunction get21 = Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache4E;
		if (Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache4F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache4F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDragButton.set_m_dragEventData);
		}
		LuaObject.addMember(l, name22, get21, Lua_BlackJack_ProjectL_UI_HeroDragButton.<>f__mg$cache4F, true);
		LuaObject.createTypeMetatable(l, null, typeof(HeroDragButton), typeof(UIControllerBase));
	}

	// Token: 0x04015039 RID: 86073
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0401503A RID: 86074
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0401503B RID: 86075
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0401503C RID: 86076
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0401503D RID: 86077
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0401503E RID: 86078
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0401503F RID: 86079
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04015040 RID: 86080
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04015041 RID: 86081
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04015042 RID: 86082
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04015043 RID: 86083
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04015044 RID: 86084
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04015045 RID: 86085
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04015046 RID: 86086
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04015047 RID: 86087
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04015048 RID: 86088
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04015049 RID: 86089
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0401504A RID: 86090
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0401504B RID: 86091
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0401504C RID: 86092
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0401504D RID: 86093
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0401504E RID: 86094
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0401504F RID: 86095
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04015050 RID: 86096
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04015051 RID: 86097
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04015052 RID: 86098
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04015053 RID: 86099
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04015054 RID: 86100
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04015055 RID: 86101
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04015056 RID: 86102
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04015057 RID: 86103
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04015058 RID: 86104
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04015059 RID: 86105
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0401505A RID: 86106
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0401505B RID: 86107
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0401505C RID: 86108
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0401505D RID: 86109
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0401505E RID: 86110
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0401505F RID: 86111
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04015060 RID: 86112
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04015061 RID: 86113
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04015062 RID: 86114
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04015063 RID: 86115
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04015064 RID: 86116
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04015065 RID: 86117
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04015066 RID: 86118
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04015067 RID: 86119
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04015068 RID: 86120
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04015069 RID: 86121
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x0401506A RID: 86122
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x0401506B RID: 86123
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x0401506C RID: 86124
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x0401506D RID: 86125
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x0401506E RID: 86126
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x0401506F RID: 86127
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x04015070 RID: 86128
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x04015071 RID: 86129
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x04015072 RID: 86130
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x04015073 RID: 86131
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x04015074 RID: 86132
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x04015075 RID: 86133
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x04015076 RID: 86134
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x04015077 RID: 86135
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x04015078 RID: 86136
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x04015079 RID: 86137
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x0401507A RID: 86138
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x0401507B RID: 86139
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x0401507C RID: 86140
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x0401507D RID: 86141
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x0401507E RID: 86142
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x0401507F RID: 86143
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;

	// Token: 0x04015080 RID: 86144
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache47;

	// Token: 0x04015081 RID: 86145
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache48;

	// Token: 0x04015082 RID: 86146
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache49;

	// Token: 0x04015083 RID: 86147
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4A;

	// Token: 0x04015084 RID: 86148
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4B;

	// Token: 0x04015085 RID: 86149
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4C;

	// Token: 0x04015086 RID: 86150
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4D;

	// Token: 0x04015087 RID: 86151
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4E;

	// Token: 0x04015088 RID: 86152
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4F;
}
