using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x0200156C RID: 5484
[Preserve]
public class Lua_BlackJack_ProjectL_UI_ScrollItemBaseUIController : LuaObject
{
	// Token: 0x06020DFB RID: 134651 RVA: 0x00B06160 File Offset: 0x00B04360
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Init(IntPtr l)
	{
		int result;
		try
		{
			ScrollItemBaseUIController scrollItemBaseUIController = (ScrollItemBaseUIController)LuaObject.checkSelf(l);
			UIControllerBase ownerCtrl;
			LuaObject.checkType<UIControllerBase>(l, 2, out ownerCtrl);
			bool isCareItemClick;
			LuaObject.checkType(l, 3, out isCareItemClick);
			scrollItemBaseUIController.Init(ownerCtrl, isCareItemClick);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020DFC RID: 134652 RVA: 0x00B061C4 File Offset: 0x00B043C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ScrollCellIndex(IntPtr l)
	{
		int result;
		try
		{
			ScrollItemBaseUIController scrollItemBaseUIController = (ScrollItemBaseUIController)LuaObject.checkSelf(l);
			int itemIndex;
			LuaObject.checkType(l, 2, out itemIndex);
			scrollItemBaseUIController.ScrollCellIndex(itemIndex);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020DFD RID: 134653 RVA: 0x00B0621C File Offset: 0x00B0441C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnScrollItemClick(IntPtr l)
	{
		int result;
		try
		{
			ScrollItemBaseUIController scrollItemBaseUIController = (ScrollItemBaseUIController)LuaObject.checkSelf(l);
			scrollItemBaseUIController.OnScrollItemClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020DFE RID: 134654 RVA: 0x00B06268 File Offset: 0x00B04468
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnScrollItemDoubleClick(IntPtr l)
	{
		int result;
		try
		{
			ScrollItemBaseUIController scrollItemBaseUIController = (ScrollItemBaseUIController)LuaObject.checkSelf(l);
			scrollItemBaseUIController.OnScrollItemDoubleClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020DFF RID: 134655 RVA: 0x00B062B4 File Offset: 0x00B044B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnScrollItem3DTouch(IntPtr l)
	{
		int result;
		try
		{
			ScrollItemBaseUIController scrollItemBaseUIController = (ScrollItemBaseUIController)LuaObject.checkSelf(l);
			scrollItemBaseUIController.OnScrollItem3DTouch();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020E00 RID: 134656 RVA: 0x00B06300 File Offset: 0x00B04500
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			ScrollItemBaseUIController scrollItemBaseUIController = (ScrollItemBaseUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			scrollItemBaseUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020E01 RID: 134657 RVA: 0x00B0636C File Offset: 0x00B0456C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			ScrollItemBaseUIController scrollItemBaseUIController = (ScrollItemBaseUIController)LuaObject.checkSelf(l);
			scrollItemBaseUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020E02 RID: 134658 RVA: 0x00B063C0 File Offset: 0x00B045C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			ScrollItemBaseUIController scrollItemBaseUIController = (ScrollItemBaseUIController)LuaObject.checkSelf(l);
			scrollItemBaseUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020E03 RID: 134659 RVA: 0x00B06414 File Offset: 0x00B04614
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			ScrollItemBaseUIController scrollItemBaseUIController = (ScrollItemBaseUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = scrollItemBaseUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x06020E04 RID: 134660 RVA: 0x00B064BC File Offset: 0x00B046BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			ScrollItemBaseUIController scrollItemBaseUIController = (ScrollItemBaseUIController)LuaObject.checkSelf(l);
			scrollItemBaseUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020E05 RID: 134661 RVA: 0x00B06510 File Offset: 0x00B04710
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ScrollItemBaseUIController scrollItemBaseUIController = (ScrollItemBaseUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			scrollItemBaseUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020E06 RID: 134662 RVA: 0x00B0657C File Offset: 0x00B0477C
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
				ScrollItemBaseUIController scrollItemBaseUIController = (ScrollItemBaseUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				scrollItemBaseUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				ScrollItemBaseUIController scrollItemBaseUIController2 = (ScrollItemBaseUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				scrollItemBaseUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x06020E07 RID: 134663 RVA: 0x00B0668C File Offset: 0x00B0488C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			ScrollItemBaseUIController scrollItemBaseUIController = (ScrollItemBaseUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			scrollItemBaseUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020E08 RID: 134664 RVA: 0x00B066F8 File Offset: 0x00B048F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			ScrollItemBaseUIController scrollItemBaseUIController = (ScrollItemBaseUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			scrollItemBaseUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020E09 RID: 134665 RVA: 0x00B06764 File Offset: 0x00B04964
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			ScrollItemBaseUIController scrollItemBaseUIController = (ScrollItemBaseUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			scrollItemBaseUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020E0A RID: 134666 RVA: 0x00B067D0 File Offset: 0x00B049D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			ScrollItemBaseUIController scrollItemBaseUIController = (ScrollItemBaseUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			scrollItemBaseUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020E0B RID: 134667 RVA: 0x00B0683C File Offset: 0x00B04A3C
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
				ScrollItemBaseUIController scrollItemBaseUIController = (ScrollItemBaseUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				scrollItemBaseUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				ScrollItemBaseUIController scrollItemBaseUIController2 = (ScrollItemBaseUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				scrollItemBaseUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x06020E0C RID: 134668 RVA: 0x00B0694C File Offset: 0x00B04B4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			ScrollItemBaseUIController scrollItemBaseUIController = (ScrollItemBaseUIController)LuaObject.checkSelf(l);
			string s = scrollItemBaseUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x06020E0D RID: 134669 RVA: 0x00B069A8 File Offset: 0x00B04BA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnUIItemNeedFill(IntPtr l)
	{
		int result;
		try
		{
			ScrollItemBaseUIController scrollItemBaseUIController = (ScrollItemBaseUIController)LuaObject.checkSelf(l);
			Action<UIControllerBase> action;
			int num = LuaObject.checkDelegate<Action<UIControllerBase>>(l, 2, out action);
			if (num == 0)
			{
				scrollItemBaseUIController.EventOnUIItemNeedFill = action;
			}
			else if (num == 1)
			{
				ScrollItemBaseUIController scrollItemBaseUIController2 = scrollItemBaseUIController;
				scrollItemBaseUIController2.EventOnUIItemNeedFill = (Action<UIControllerBase>)Delegate.Combine(scrollItemBaseUIController2.EventOnUIItemNeedFill, action);
			}
			else if (num == 2)
			{
				ScrollItemBaseUIController scrollItemBaseUIController3 = scrollItemBaseUIController;
				scrollItemBaseUIController3.EventOnUIItemNeedFill = (Action<UIControllerBase>)Delegate.Remove(scrollItemBaseUIController3.EventOnUIItemNeedFill, action);
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

	// Token: 0x06020E0E RID: 134670 RVA: 0x00B06A50 File Offset: 0x00B04C50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnUIItemClick(IntPtr l)
	{
		int result;
		try
		{
			ScrollItemBaseUIController scrollItemBaseUIController = (ScrollItemBaseUIController)LuaObject.checkSelf(l);
			Action<UIControllerBase> action;
			int num = LuaObject.checkDelegate<Action<UIControllerBase>>(l, 2, out action);
			if (num == 0)
			{
				scrollItemBaseUIController.EventOnUIItemClick = action;
			}
			else if (num == 1)
			{
				ScrollItemBaseUIController scrollItemBaseUIController2 = scrollItemBaseUIController;
				scrollItemBaseUIController2.EventOnUIItemClick = (Action<UIControllerBase>)Delegate.Combine(scrollItemBaseUIController2.EventOnUIItemClick, action);
			}
			else if (num == 2)
			{
				ScrollItemBaseUIController scrollItemBaseUIController3 = scrollItemBaseUIController;
				scrollItemBaseUIController3.EventOnUIItemClick = (Action<UIControllerBase>)Delegate.Remove(scrollItemBaseUIController3.EventOnUIItemClick, action);
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

	// Token: 0x06020E0F RID: 134671 RVA: 0x00B06AF8 File Offset: 0x00B04CF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnUIItemDoubleClick(IntPtr l)
	{
		int result;
		try
		{
			ScrollItemBaseUIController scrollItemBaseUIController = (ScrollItemBaseUIController)LuaObject.checkSelf(l);
			Action<UIControllerBase> action;
			int num = LuaObject.checkDelegate<Action<UIControllerBase>>(l, 2, out action);
			if (num == 0)
			{
				scrollItemBaseUIController.EventOnUIItemDoubleClick = action;
			}
			else if (num == 1)
			{
				ScrollItemBaseUIController scrollItemBaseUIController2 = scrollItemBaseUIController;
				scrollItemBaseUIController2.EventOnUIItemDoubleClick = (Action<UIControllerBase>)Delegate.Combine(scrollItemBaseUIController2.EventOnUIItemDoubleClick, action);
			}
			else if (num == 2)
			{
				ScrollItemBaseUIController scrollItemBaseUIController3 = scrollItemBaseUIController;
				scrollItemBaseUIController3.EventOnUIItemDoubleClick = (Action<UIControllerBase>)Delegate.Remove(scrollItemBaseUIController3.EventOnUIItemDoubleClick, action);
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

	// Token: 0x06020E10 RID: 134672 RVA: 0x00B06BA0 File Offset: 0x00B04DA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnUIItem3DTouch(IntPtr l)
	{
		int result;
		try
		{
			ScrollItemBaseUIController scrollItemBaseUIController = (ScrollItemBaseUIController)LuaObject.checkSelf(l);
			Action<UIControllerBase> action;
			int num = LuaObject.checkDelegate<Action<UIControllerBase>>(l, 2, out action);
			if (num == 0)
			{
				scrollItemBaseUIController.EventOnUIItem3DTouch = action;
			}
			else if (num == 1)
			{
				ScrollItemBaseUIController scrollItemBaseUIController2 = scrollItemBaseUIController;
				scrollItemBaseUIController2.EventOnUIItem3DTouch = (Action<UIControllerBase>)Delegate.Combine(scrollItemBaseUIController2.EventOnUIItem3DTouch, action);
			}
			else if (num == 2)
			{
				ScrollItemBaseUIController scrollItemBaseUIController3 = scrollItemBaseUIController;
				scrollItemBaseUIController3.EventOnUIItem3DTouch = (Action<UIControllerBase>)Delegate.Remove(scrollItemBaseUIController3.EventOnUIItem3DTouch, action);
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

	// Token: 0x06020E11 RID: 134673 RVA: 0x00B06C48 File Offset: 0x00B04E48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_itemIndex(IntPtr l)
	{
		int result;
		try
		{
			ScrollItemBaseUIController scrollItemBaseUIController = (ScrollItemBaseUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, scrollItemBaseUIController.m_itemIndex);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020E12 RID: 134674 RVA: 0x00B06C9C File Offset: 0x00B04E9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_itemIndex(IntPtr l)
	{
		int result;
		try
		{
			ScrollItemBaseUIController scrollItemBaseUIController = (ScrollItemBaseUIController)LuaObject.checkSelf(l);
			int itemIndex;
			LuaObject.checkType(l, 2, out itemIndex);
			scrollItemBaseUIController.m_itemIndex = itemIndex;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020E13 RID: 134675 RVA: 0x00B06CF4 File Offset: 0x00B04EF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_ownerCtrl(IntPtr l)
	{
		int result;
		try
		{
			ScrollItemBaseUIController scrollItemBaseUIController = (ScrollItemBaseUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, scrollItemBaseUIController.m_ownerCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020E14 RID: 134676 RVA: 0x00B06D48 File Offset: 0x00B04F48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_ownerCtrl(IntPtr l)
	{
		int result;
		try
		{
			ScrollItemBaseUIController scrollItemBaseUIController = (ScrollItemBaseUIController)LuaObject.checkSelf(l);
			UIControllerBase ownerCtrl;
			LuaObject.checkType<UIControllerBase>(l, 2, out ownerCtrl);
			scrollItemBaseUIController.m_ownerCtrl = ownerCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020E15 RID: 134677 RVA: 0x00B06DA0 File Offset: 0x00B04FA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_3dTouchEventTrigger(IntPtr l)
	{
		int result;
		try
		{
			ScrollItemBaseUIController scrollItemBaseUIController = (ScrollItemBaseUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, scrollItemBaseUIController.m_luaExportHelper.m_3dTouchEventTrigger);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020E16 RID: 134678 RVA: 0x00B06DF8 File Offset: 0x00B04FF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_3dTouchEventTrigger(IntPtr l)
	{
		int result;
		try
		{
			ScrollItemBaseUIController scrollItemBaseUIController = (ScrollItemBaseUIController)LuaObject.checkSelf(l);
			ThreeDTouchEventListener 3dTouchEventTrigger;
			LuaObject.checkType<ThreeDTouchEventListener>(l, 2, out 3dTouchEventTrigger);
			scrollItemBaseUIController.m_luaExportHelper.m_3dTouchEventTrigger = 3dTouchEventTrigger;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020E17 RID: 134679 RVA: 0x00B06E54 File Offset: 0x00B05054
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ItemIndex(IntPtr l)
	{
		int result;
		try
		{
			ScrollItemBaseUIController scrollItemBaseUIController = (ScrollItemBaseUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, scrollItemBaseUIController.ItemIndex);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020E18 RID: 134680 RVA: 0x00B06EA8 File Offset: 0x00B050A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ItemIndex(IntPtr l)
	{
		int result;
		try
		{
			ScrollItemBaseUIController scrollItemBaseUIController = (ScrollItemBaseUIController)LuaObject.checkSelf(l);
			int itemIndex;
			LuaObject.checkType(l, 2, out itemIndex);
			scrollItemBaseUIController.ItemIndex = itemIndex;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020E19 RID: 134681 RVA: 0x00B06F00 File Offset: 0x00B05100
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.ScrollItemBaseUIController");
		if (Lua_BlackJack_ProjectL_UI_ScrollItemBaseUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_ScrollItemBaseUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ScrollItemBaseUIController.Init);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ScrollItemBaseUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_ScrollItemBaseUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_ScrollItemBaseUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ScrollItemBaseUIController.ScrollCellIndex);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ScrollItemBaseUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_ScrollItemBaseUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_ScrollItemBaseUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ScrollItemBaseUIController.OnScrollItemClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ScrollItemBaseUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_ScrollItemBaseUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_ScrollItemBaseUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ScrollItemBaseUIController.OnScrollItemDoubleClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ScrollItemBaseUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_ScrollItemBaseUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_ScrollItemBaseUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ScrollItemBaseUIController.OnScrollItem3DTouch);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ScrollItemBaseUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_ScrollItemBaseUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_ScrollItemBaseUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ScrollItemBaseUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ScrollItemBaseUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_ScrollItemBaseUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_ScrollItemBaseUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ScrollItemBaseUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ScrollItemBaseUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_ScrollItemBaseUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_ScrollItemBaseUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ScrollItemBaseUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ScrollItemBaseUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_ScrollItemBaseUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_ScrollItemBaseUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ScrollItemBaseUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ScrollItemBaseUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_ScrollItemBaseUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_ScrollItemBaseUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ScrollItemBaseUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ScrollItemBaseUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_ScrollItemBaseUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_ScrollItemBaseUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ScrollItemBaseUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ScrollItemBaseUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_ScrollItemBaseUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_ScrollItemBaseUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ScrollItemBaseUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ScrollItemBaseUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_ScrollItemBaseUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_ScrollItemBaseUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ScrollItemBaseUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ScrollItemBaseUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_ScrollItemBaseUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_ScrollItemBaseUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ScrollItemBaseUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ScrollItemBaseUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_ScrollItemBaseUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_ScrollItemBaseUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ScrollItemBaseUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ScrollItemBaseUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_ScrollItemBaseUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_ScrollItemBaseUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ScrollItemBaseUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ScrollItemBaseUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_ScrollItemBaseUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_ScrollItemBaseUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ScrollItemBaseUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ScrollItemBaseUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_ScrollItemBaseUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_ScrollItemBaseUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ScrollItemBaseUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ScrollItemBaseUIController.<>f__mg$cache11);
		string name = "EventOnUIItemNeedFill";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_ScrollItemBaseUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_ScrollItemBaseUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ScrollItemBaseUIController.set_EventOnUIItemNeedFill);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_ScrollItemBaseUIController.<>f__mg$cache12, true);
		string name2 = "EventOnUIItemClick";
		LuaCSFunction get2 = null;
		if (Lua_BlackJack_ProjectL_UI_ScrollItemBaseUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_ScrollItemBaseUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ScrollItemBaseUIController.set_EventOnUIItemClick);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_ScrollItemBaseUIController.<>f__mg$cache13, true);
		string name3 = "EventOnUIItemDoubleClick";
		LuaCSFunction get3 = null;
		if (Lua_BlackJack_ProjectL_UI_ScrollItemBaseUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_ScrollItemBaseUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ScrollItemBaseUIController.set_EventOnUIItemDoubleClick);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_ScrollItemBaseUIController.<>f__mg$cache14, true);
		string name4 = "EventOnUIItem3DTouch";
		LuaCSFunction get4 = null;
		if (Lua_BlackJack_ProjectL_UI_ScrollItemBaseUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_ScrollItemBaseUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ScrollItemBaseUIController.set_EventOnUIItem3DTouch);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_ScrollItemBaseUIController.<>f__mg$cache15, true);
		string name5 = "m_itemIndex";
		if (Lua_BlackJack_ProjectL_UI_ScrollItemBaseUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_ScrollItemBaseUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ScrollItemBaseUIController.get_m_itemIndex);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_ScrollItemBaseUIController.<>f__mg$cache16;
		if (Lua_BlackJack_ProjectL_UI_ScrollItemBaseUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_ScrollItemBaseUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ScrollItemBaseUIController.set_m_itemIndex);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_ScrollItemBaseUIController.<>f__mg$cache17, true);
		string name6 = "m_ownerCtrl";
		if (Lua_BlackJack_ProjectL_UI_ScrollItemBaseUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_ScrollItemBaseUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ScrollItemBaseUIController.get_m_ownerCtrl);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_ScrollItemBaseUIController.<>f__mg$cache18;
		if (Lua_BlackJack_ProjectL_UI_ScrollItemBaseUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_ScrollItemBaseUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ScrollItemBaseUIController.set_m_ownerCtrl);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_ScrollItemBaseUIController.<>f__mg$cache19, true);
		string name7 = "m_3dTouchEventTrigger";
		if (Lua_BlackJack_ProjectL_UI_ScrollItemBaseUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_ScrollItemBaseUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ScrollItemBaseUIController.get_m_3dTouchEventTrigger);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_ScrollItemBaseUIController.<>f__mg$cache1A;
		if (Lua_BlackJack_ProjectL_UI_ScrollItemBaseUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_ScrollItemBaseUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ScrollItemBaseUIController.set_m_3dTouchEventTrigger);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_ScrollItemBaseUIController.<>f__mg$cache1B, true);
		string name8 = "ItemIndex";
		if (Lua_BlackJack_ProjectL_UI_ScrollItemBaseUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_ScrollItemBaseUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ScrollItemBaseUIController.get_ItemIndex);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_ScrollItemBaseUIController.<>f__mg$cache1C;
		if (Lua_BlackJack_ProjectL_UI_ScrollItemBaseUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_ScrollItemBaseUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ScrollItemBaseUIController.set_ItemIndex);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_ScrollItemBaseUIController.<>f__mg$cache1D, true);
		LuaObject.createTypeMetatable(l, null, typeof(ScrollItemBaseUIController), typeof(UIControllerBase));
	}

	// Token: 0x04016D05 RID: 93445
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04016D06 RID: 93446
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04016D07 RID: 93447
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04016D08 RID: 93448
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04016D09 RID: 93449
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04016D0A RID: 93450
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04016D0B RID: 93451
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04016D0C RID: 93452
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04016D0D RID: 93453
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04016D0E RID: 93454
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04016D0F RID: 93455
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04016D10 RID: 93456
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04016D11 RID: 93457
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04016D12 RID: 93458
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04016D13 RID: 93459
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04016D14 RID: 93460
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04016D15 RID: 93461
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04016D16 RID: 93462
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04016D17 RID: 93463
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04016D18 RID: 93464
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04016D19 RID: 93465
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04016D1A RID: 93466
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04016D1B RID: 93467
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04016D1C RID: 93468
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04016D1D RID: 93469
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04016D1E RID: 93470
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04016D1F RID: 93471
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04016D20 RID: 93472
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04016D21 RID: 93473
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04016D22 RID: 93474
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;
}
