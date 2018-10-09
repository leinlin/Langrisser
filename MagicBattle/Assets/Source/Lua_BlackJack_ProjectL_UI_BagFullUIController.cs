using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x02001390 RID: 5008
[Preserve]
public class Lua_BlackJack_ProjectL_UI_BagFullUIController : LuaObject
{
	// Token: 0x0601B4C8 RID: 111816 RVA: 0x00840858 File Offset: 0x0083EA58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Open(IntPtr l)
	{
		int result;
		try
		{
			BagFullUIController bagFullUIController = (BagFullUIController)LuaObject.checkSelf(l);
			bagFullUIController.Open();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B4C9 RID: 111817 RVA: 0x008408A4 File Offset: 0x0083EAA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Close(IntPtr l)
	{
		int result;
		try
		{
			BagFullUIController bagFullUIController = (BagFullUIController)LuaObject.checkSelf(l);
			Action onEnd;
			LuaObject.checkDelegate<Action>(l, 2, out onEnd);
			bagFullUIController.Close(onEnd);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B4CA RID: 111818 RVA: 0x008408FC File Offset: 0x0083EAFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateView(IntPtr l)
	{
		int result;
		try
		{
			BagFullUIController bagFullUIController = (BagFullUIController)LuaObject.checkSelf(l);
			bagFullUIController.UpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B4CB RID: 111819 RVA: 0x00840948 File Offset: 0x0083EB48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			BagFullUIController bagFullUIController = (BagFullUIController)LuaObject.checkSelf(l);
			bagFullUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B4CC RID: 111820 RVA: 0x0084099C File Offset: 0x0083EB9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnReturnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			BagFullUIController bagFullUIController = (BagFullUIController)LuaObject.checkSelf(l);
			bagFullUIController.m_luaExportHelper.OnReturnButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B4CD RID: 111821 RVA: 0x008409F0 File Offset: 0x0083EBF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnGotoBagButtonClick(IntPtr l)
	{
		int result;
		try
		{
			BagFullUIController bagFullUIController = (BagFullUIController)LuaObject.checkSelf(l);
			bagFullUIController.m_luaExportHelper.OnGotoBagButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B4CE RID: 111822 RVA: 0x00840A44 File Offset: 0x0083EC44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			BagFullUIController bagFullUIController = (BagFullUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			bagFullUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B4CF RID: 111823 RVA: 0x00840AB0 File Offset: 0x0083ECB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			BagFullUIController bagFullUIController = (BagFullUIController)LuaObject.checkSelf(l);
			bagFullUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B4D0 RID: 111824 RVA: 0x00840B04 File Offset: 0x0083ED04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			BagFullUIController bagFullUIController = (BagFullUIController)LuaObject.checkSelf(l);
			bagFullUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B4D1 RID: 111825 RVA: 0x00840B58 File Offset: 0x0083ED58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			BagFullUIController bagFullUIController = (BagFullUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = bagFullUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601B4D2 RID: 111826 RVA: 0x00840C00 File Offset: 0x0083EE00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			BagFullUIController bagFullUIController = (BagFullUIController)LuaObject.checkSelf(l);
			bagFullUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B4D3 RID: 111827 RVA: 0x00840C54 File Offset: 0x0083EE54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			BagFullUIController bagFullUIController = (BagFullUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			bagFullUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B4D4 RID: 111828 RVA: 0x00840CC0 File Offset: 0x0083EEC0
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
				BagFullUIController bagFullUIController = (BagFullUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				bagFullUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				BagFullUIController bagFullUIController2 = (BagFullUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				bagFullUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601B4D5 RID: 111829 RVA: 0x00840DD0 File Offset: 0x0083EFD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			BagFullUIController bagFullUIController = (BagFullUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			bagFullUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B4D6 RID: 111830 RVA: 0x00840E3C File Offset: 0x0083F03C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			BagFullUIController bagFullUIController = (BagFullUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			bagFullUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B4D7 RID: 111831 RVA: 0x00840EA8 File Offset: 0x0083F0A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			BagFullUIController bagFullUIController = (BagFullUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			bagFullUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B4D8 RID: 111832 RVA: 0x00840F14 File Offset: 0x0083F114
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			BagFullUIController bagFullUIController = (BagFullUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			bagFullUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B4D9 RID: 111833 RVA: 0x00840F80 File Offset: 0x0083F180
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
				BagFullUIController bagFullUIController = (BagFullUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				bagFullUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				BagFullUIController bagFullUIController2 = (BagFullUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				bagFullUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601B4DA RID: 111834 RVA: 0x00841090 File Offset: 0x0083F290
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			BagFullUIController bagFullUIController = (BagFullUIController)LuaObject.checkSelf(l);
			string s = bagFullUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601B4DB RID: 111835 RVA: 0x008410EC File Offset: 0x0083F2EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnReturn(IntPtr l)
	{
		int result;
		try
		{
			BagFullUIController bagFullUIController = (BagFullUIController)LuaObject.checkSelf(l);
			bagFullUIController.m_luaExportHelper.__callDele_EventOnReturn();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B4DC RID: 111836 RVA: 0x00841140 File Offset: 0x0083F340
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnReturn(IntPtr l)
	{
		int result;
		try
		{
			BagFullUIController bagFullUIController = (BagFullUIController)LuaObject.checkSelf(l);
			bagFullUIController.m_luaExportHelper.__clearDele_EventOnReturn();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B4DD RID: 111837 RVA: 0x00841194 File Offset: 0x0083F394
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnGotoBag(IntPtr l)
	{
		int result;
		try
		{
			BagFullUIController bagFullUIController = (BagFullUIController)LuaObject.checkSelf(l);
			bagFullUIController.m_luaExportHelper.__callDele_EventOnGotoBag();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B4DE RID: 111838 RVA: 0x008411E8 File Offset: 0x0083F3E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnGotoBag(IntPtr l)
	{
		int result;
		try
		{
			BagFullUIController bagFullUIController = (BagFullUIController)LuaObject.checkSelf(l);
			bagFullUIController.m_luaExportHelper.__clearDele_EventOnGotoBag();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B4DF RID: 111839 RVA: 0x0084123C File Offset: 0x0083F43C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnReturn(IntPtr l)
	{
		int result;
		try
		{
			BagFullUIController bagFullUIController = (BagFullUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					bagFullUIController.EventOnReturn += value;
				}
				else if (num == 2)
				{
					bagFullUIController.EventOnReturn -= value;
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

	// Token: 0x0601B4E0 RID: 111840 RVA: 0x008412BC File Offset: 0x0083F4BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnGotoBag(IntPtr l)
	{
		int result;
		try
		{
			BagFullUIController bagFullUIController = (BagFullUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					bagFullUIController.EventOnGotoBag += value;
				}
				else if (num == 2)
				{
					bagFullUIController.EventOnGotoBag -= value;
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

	// Token: 0x0601B4E1 RID: 111841 RVA: 0x0084133C File Offset: 0x0083F53C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_stateCtrl(IntPtr l)
	{
		int result;
		try
		{
			BagFullUIController bagFullUIController = (BagFullUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagFullUIController.m_luaExportHelper.m_stateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B4E2 RID: 111842 RVA: 0x00841394 File Offset: 0x0083F594
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_stateCtrl(IntPtr l)
	{
		int result;
		try
		{
			BagFullUIController bagFullUIController = (BagFullUIController)LuaObject.checkSelf(l);
			CommonUIStateController stateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out stateCtrl);
			bagFullUIController.m_luaExportHelper.m_stateCtrl = stateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B4E3 RID: 111843 RVA: 0x008413F0 File Offset: 0x0083F5F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_bgButton(IntPtr l)
	{
		int result;
		try
		{
			BagFullUIController bagFullUIController = (BagFullUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagFullUIController.m_luaExportHelper.m_bgButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B4E4 RID: 111844 RVA: 0x00841448 File Offset: 0x0083F648
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_bgButton(IntPtr l)
	{
		int result;
		try
		{
			BagFullUIController bagFullUIController = (BagFullUIController)LuaObject.checkSelf(l);
			Button bgButton;
			LuaObject.checkType<Button>(l, 2, out bgButton);
			bagFullUIController.m_luaExportHelper.m_bgButton = bgButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B4E5 RID: 111845 RVA: 0x008414A4 File Offset: 0x0083F6A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_returnButton(IntPtr l)
	{
		int result;
		try
		{
			BagFullUIController bagFullUIController = (BagFullUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagFullUIController.m_luaExportHelper.m_returnButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B4E6 RID: 111846 RVA: 0x008414FC File Offset: 0x0083F6FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_returnButton(IntPtr l)
	{
		int result;
		try
		{
			BagFullUIController bagFullUIController = (BagFullUIController)LuaObject.checkSelf(l);
			Button returnButton;
			LuaObject.checkType<Button>(l, 2, out returnButton);
			bagFullUIController.m_luaExportHelper.m_returnButton = returnButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B4E7 RID: 111847 RVA: 0x00841558 File Offset: 0x0083F758
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_gotoBagButton(IntPtr l)
	{
		int result;
		try
		{
			BagFullUIController bagFullUIController = (BagFullUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagFullUIController.m_luaExportHelper.m_gotoBagButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B4E8 RID: 111848 RVA: 0x008415B0 File Offset: 0x0083F7B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_gotoBagButton(IntPtr l)
	{
		int result;
		try
		{
			BagFullUIController bagFullUIController = (BagFullUIController)LuaObject.checkSelf(l);
			Button gotoBagButton;
			LuaObject.checkType<Button>(l, 2, out gotoBagButton);
			bagFullUIController.m_luaExportHelper.m_gotoBagButton = gotoBagButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B4E9 RID: 111849 RVA: 0x0084160C File Offset: 0x0083F80C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_countStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			BagFullUIController bagFullUIController = (BagFullUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagFullUIController.m_luaExportHelper.m_countStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B4EA RID: 111850 RVA: 0x00841664 File Offset: 0x0083F864
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_countStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			BagFullUIController bagFullUIController = (BagFullUIController)LuaObject.checkSelf(l);
			CommonUIStateController countStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out countStateCtrl);
			bagFullUIController.m_luaExportHelper.m_countStateCtrl = countStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B4EB RID: 111851 RVA: 0x008416C0 File Offset: 0x0083F8C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_countText(IntPtr l)
	{
		int result;
		try
		{
			BagFullUIController bagFullUIController = (BagFullUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagFullUIController.m_luaExportHelper.m_countText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B4EC RID: 111852 RVA: 0x00841718 File Offset: 0x0083F918
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_countText(IntPtr l)
	{
		int result;
		try
		{
			BagFullUIController bagFullUIController = (BagFullUIController)LuaObject.checkSelf(l);
			Text countText;
			LuaObject.checkType<Text>(l, 2, out countText);
			bagFullUIController.m_luaExportHelper.m_countText = countText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B4ED RID: 111853 RVA: 0x00841774 File Offset: 0x0083F974
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_countMaxText(IntPtr l)
	{
		int result;
		try
		{
			BagFullUIController bagFullUIController = (BagFullUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagFullUIController.m_luaExportHelper.m_countMaxText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B4EE RID: 111854 RVA: 0x008417CC File Offset: 0x0083F9CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_countMaxText(IntPtr l)
	{
		int result;
		try
		{
			BagFullUIController bagFullUIController = (BagFullUIController)LuaObject.checkSelf(l);
			Text countMaxText;
			LuaObject.checkType<Text>(l, 2, out countMaxText);
			bagFullUIController.m_luaExportHelper.m_countMaxText = countMaxText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B4EF RID: 111855 RVA: 0x00841828 File Offset: 0x0083FA28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isOpened(IntPtr l)
	{
		int result;
		try
		{
			BagFullUIController bagFullUIController = (BagFullUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagFullUIController.m_luaExportHelper.m_isOpened);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B4F0 RID: 111856 RVA: 0x00841880 File Offset: 0x0083FA80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isOpened(IntPtr l)
	{
		int result;
		try
		{
			BagFullUIController bagFullUIController = (BagFullUIController)LuaObject.checkSelf(l);
			bool isOpened;
			LuaObject.checkType(l, 2, out isOpened);
			bagFullUIController.m_luaExportHelper.m_isOpened = isOpened;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B4F1 RID: 111857 RVA: 0x008418DC File Offset: 0x0083FADC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.BagFullUIController");
		if (Lua_BlackJack_ProjectL_UI_BagFullUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagFullUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagFullUIController.Open);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagFullUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_BagFullUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagFullUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagFullUIController.Close);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagFullUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_BagFullUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagFullUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagFullUIController.UpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagFullUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_BagFullUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagFullUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagFullUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagFullUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_BagFullUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagFullUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagFullUIController.OnReturnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagFullUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_BagFullUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagFullUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagFullUIController.OnGotoBagButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagFullUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_BagFullUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagFullUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagFullUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagFullUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_BagFullUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagFullUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagFullUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagFullUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_BagFullUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagFullUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagFullUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagFullUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_BagFullUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagFullUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagFullUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagFullUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_BagFullUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_BagFullUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagFullUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagFullUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_BagFullUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_BagFullUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagFullUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagFullUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_BagFullUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_BagFullUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagFullUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagFullUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_BagFullUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_BagFullUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagFullUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagFullUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_BagFullUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_BagFullUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagFullUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagFullUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_BagFullUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_BagFullUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagFullUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagFullUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_BagFullUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagFullUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagFullUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagFullUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_BagFullUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagFullUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagFullUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagFullUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_BagFullUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagFullUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagFullUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagFullUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_BagFullUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagFullUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagFullUIController.__callDele_EventOnReturn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagFullUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_BagFullUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagFullUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagFullUIController.__clearDele_EventOnReturn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagFullUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_BagFullUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagFullUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagFullUIController.__callDele_EventOnGotoBag);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagFullUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_BagFullUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagFullUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagFullUIController.__clearDele_EventOnGotoBag);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagFullUIController.<>f__mg$cache16);
		string name = "EventOnReturn";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_BagFullUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagFullUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagFullUIController.set_EventOnReturn);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_BagFullUIController.<>f__mg$cache17, true);
		string name2 = "EventOnGotoBag";
		LuaCSFunction get2 = null;
		if (Lua_BlackJack_ProjectL_UI_BagFullUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagFullUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagFullUIController.set_EventOnGotoBag);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_BagFullUIController.<>f__mg$cache18, true);
		string name3 = "m_stateCtrl";
		if (Lua_BlackJack_ProjectL_UI_BagFullUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagFullUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagFullUIController.get_m_stateCtrl);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_BagFullUIController.<>f__mg$cache19;
		if (Lua_BlackJack_ProjectL_UI_BagFullUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_BagFullUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagFullUIController.set_m_stateCtrl);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_BagFullUIController.<>f__mg$cache1A, true);
		string name4 = "m_bgButton";
		if (Lua_BlackJack_ProjectL_UI_BagFullUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_BagFullUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagFullUIController.get_m_bgButton);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_BagFullUIController.<>f__mg$cache1B;
		if (Lua_BlackJack_ProjectL_UI_BagFullUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_BagFullUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagFullUIController.set_m_bgButton);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_BagFullUIController.<>f__mg$cache1C, true);
		string name5 = "m_returnButton";
		if (Lua_BlackJack_ProjectL_UI_BagFullUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_BagFullUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagFullUIController.get_m_returnButton);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_BagFullUIController.<>f__mg$cache1D;
		if (Lua_BlackJack_ProjectL_UI_BagFullUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_BagFullUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagFullUIController.set_m_returnButton);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_BagFullUIController.<>f__mg$cache1E, true);
		string name6 = "m_gotoBagButton";
		if (Lua_BlackJack_ProjectL_UI_BagFullUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_BagFullUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagFullUIController.get_m_gotoBagButton);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_BagFullUIController.<>f__mg$cache1F;
		if (Lua_BlackJack_ProjectL_UI_BagFullUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagFullUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagFullUIController.set_m_gotoBagButton);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_BagFullUIController.<>f__mg$cache20, true);
		string name7 = "m_countStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_BagFullUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagFullUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagFullUIController.get_m_countStateCtrl);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_BagFullUIController.<>f__mg$cache21;
		if (Lua_BlackJack_ProjectL_UI_BagFullUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagFullUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagFullUIController.set_m_countStateCtrl);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_BagFullUIController.<>f__mg$cache22, true);
		string name8 = "m_countText";
		if (Lua_BlackJack_ProjectL_UI_BagFullUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagFullUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagFullUIController.get_m_countText);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_BagFullUIController.<>f__mg$cache23;
		if (Lua_BlackJack_ProjectL_UI_BagFullUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagFullUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagFullUIController.set_m_countText);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_BagFullUIController.<>f__mg$cache24, true);
		string name9 = "m_countMaxText";
		if (Lua_BlackJack_ProjectL_UI_BagFullUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagFullUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagFullUIController.get_m_countMaxText);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_BagFullUIController.<>f__mg$cache25;
		if (Lua_BlackJack_ProjectL_UI_BagFullUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagFullUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagFullUIController.set_m_countMaxText);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_BagFullUIController.<>f__mg$cache26, true);
		string name10 = "m_isOpened";
		if (Lua_BlackJack_ProjectL_UI_BagFullUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagFullUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagFullUIController.get_m_isOpened);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_BagFullUIController.<>f__mg$cache27;
		if (Lua_BlackJack_ProjectL_UI_BagFullUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagFullUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagFullUIController.set_m_isOpened);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_BagFullUIController.<>f__mg$cache28, true);
		LuaObject.createTypeMetatable(l, null, typeof(BagFullUIController), typeof(UIControllerBase));
	}

	// Token: 0x0401178A RID: 71562
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0401178B RID: 71563
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0401178C RID: 71564
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0401178D RID: 71565
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0401178E RID: 71566
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0401178F RID: 71567
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04011790 RID: 71568
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04011791 RID: 71569
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04011792 RID: 71570
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04011793 RID: 71571
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04011794 RID: 71572
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04011795 RID: 71573
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04011796 RID: 71574
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04011797 RID: 71575
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04011798 RID: 71576
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04011799 RID: 71577
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0401179A RID: 71578
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0401179B RID: 71579
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0401179C RID: 71580
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0401179D RID: 71581
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0401179E RID: 71582
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0401179F RID: 71583
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x040117A0 RID: 71584
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x040117A1 RID: 71585
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x040117A2 RID: 71586
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x040117A3 RID: 71587
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x040117A4 RID: 71588
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x040117A5 RID: 71589
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x040117A6 RID: 71590
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x040117A7 RID: 71591
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x040117A8 RID: 71592
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x040117A9 RID: 71593
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x040117AA RID: 71594
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x040117AB RID: 71595
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x040117AC RID: 71596
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x040117AD RID: 71597
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x040117AE RID: 71598
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x040117AF RID: 71599
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x040117B0 RID: 71600
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x040117B1 RID: 71601
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x040117B2 RID: 71602
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;
}
