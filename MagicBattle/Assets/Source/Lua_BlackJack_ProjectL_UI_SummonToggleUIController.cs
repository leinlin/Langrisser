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

// Token: 0x0200158D RID: 5517
[Preserve]
public class Lua_BlackJack_ProjectL_UI_SummonToggleUIController : LuaObject
{
	// Token: 0x060215D5 RID: 136661 RVA: 0x00B452DC File Offset: 0x00B434DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetSummonToggleInfo(IntPtr l)
	{
		int result;
		try
		{
			SummonToggleUIController summonToggleUIController = (SummonToggleUIController)LuaObject.checkSelf(l);
			int summonToggleInfo;
			LuaObject.checkType(l, 2, out summonToggleInfo);
			summonToggleUIController.SetSummonToggleInfo(summonToggleInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060215D6 RID: 136662 RVA: 0x00B45334 File Offset: 0x00B43534
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetToggleIsOn(IntPtr l)
	{
		int result;
		try
		{
			SummonToggleUIController summonToggleUIController = (SummonToggleUIController)LuaObject.checkSelf(l);
			bool toggleIsOn;
			LuaObject.checkType(l, 2, out toggleIsOn);
			summonToggleUIController.SetToggleIsOn(toggleIsOn);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060215D7 RID: 136663 RVA: 0x00B4538C File Offset: 0x00B4358C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			SummonToggleUIController summonToggleUIController = (SummonToggleUIController)LuaObject.checkSelf(l);
			summonToggleUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060215D8 RID: 136664 RVA: 0x00B453E0 File Offset: 0x00B435E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnToggleValueChanged(IntPtr l)
	{
		int result;
		try
		{
			SummonToggleUIController summonToggleUIController = (SummonToggleUIController)LuaObject.checkSelf(l);
			bool isOn;
			LuaObject.checkType(l, 2, out isOn);
			summonToggleUIController.m_luaExportHelper.OnToggleValueChanged(isOn);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060215D9 RID: 136665 RVA: 0x00B4543C File Offset: 0x00B4363C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			SummonToggleUIController summonToggleUIController = (SummonToggleUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			summonToggleUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060215DA RID: 136666 RVA: 0x00B454A8 File Offset: 0x00B436A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			SummonToggleUIController summonToggleUIController = (SummonToggleUIController)LuaObject.checkSelf(l);
			summonToggleUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060215DB RID: 136667 RVA: 0x00B454FC File Offset: 0x00B436FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			SummonToggleUIController summonToggleUIController = (SummonToggleUIController)LuaObject.checkSelf(l);
			summonToggleUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060215DC RID: 136668 RVA: 0x00B45550 File Offset: 0x00B43750
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			SummonToggleUIController summonToggleUIController = (SummonToggleUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = summonToggleUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x060215DD RID: 136669 RVA: 0x00B455F8 File Offset: 0x00B437F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			SummonToggleUIController summonToggleUIController = (SummonToggleUIController)LuaObject.checkSelf(l);
			summonToggleUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060215DE RID: 136670 RVA: 0x00B4564C File Offset: 0x00B4384C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			SummonToggleUIController summonToggleUIController = (SummonToggleUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			summonToggleUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060215DF RID: 136671 RVA: 0x00B456B8 File Offset: 0x00B438B8
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
				SummonToggleUIController summonToggleUIController = (SummonToggleUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				summonToggleUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				SummonToggleUIController summonToggleUIController2 = (SummonToggleUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				summonToggleUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x060215E0 RID: 136672 RVA: 0x00B457C8 File Offset: 0x00B439C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			SummonToggleUIController summonToggleUIController = (SummonToggleUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			summonToggleUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060215E1 RID: 136673 RVA: 0x00B45834 File Offset: 0x00B43A34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			SummonToggleUIController summonToggleUIController = (SummonToggleUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			summonToggleUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060215E2 RID: 136674 RVA: 0x00B458A0 File Offset: 0x00B43AA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			SummonToggleUIController summonToggleUIController = (SummonToggleUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			summonToggleUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060215E3 RID: 136675 RVA: 0x00B4590C File Offset: 0x00B43B0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			SummonToggleUIController summonToggleUIController = (SummonToggleUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			summonToggleUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060215E4 RID: 136676 RVA: 0x00B45978 File Offset: 0x00B43B78
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
				SummonToggleUIController summonToggleUIController = (SummonToggleUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				summonToggleUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				SummonToggleUIController summonToggleUIController2 = (SummonToggleUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				summonToggleUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x060215E5 RID: 136677 RVA: 0x00B45A88 File Offset: 0x00B43C88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			SummonToggleUIController summonToggleUIController = (SummonToggleUIController)LuaObject.checkSelf(l);
			string s = summonToggleUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x060215E6 RID: 136678 RVA: 0x00B45AE4 File Offset: 0x00B43CE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnToggleClick(IntPtr l)
	{
		int result;
		try
		{
			SummonToggleUIController summonToggleUIController = (SummonToggleUIController)LuaObject.checkSelf(l);
			SummonToggleUIController obj;
			LuaObject.checkType<SummonToggleUIController>(l, 2, out obj);
			summonToggleUIController.m_luaExportHelper.__callDele_EventOnToggleClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060215E7 RID: 136679 RVA: 0x00B45B40 File Offset: 0x00B43D40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnToggleClick(IntPtr l)
	{
		int result;
		try
		{
			SummonToggleUIController summonToggleUIController = (SummonToggleUIController)LuaObject.checkSelf(l);
			SummonToggleUIController obj;
			LuaObject.checkType<SummonToggleUIController>(l, 2, out obj);
			summonToggleUIController.m_luaExportHelper.__clearDele_EventOnToggleClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060215E8 RID: 136680 RVA: 0x00B45B9C File Offset: 0x00B43D9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnToggleClick(IntPtr l)
	{
		int result;
		try
		{
			SummonToggleUIController summonToggleUIController = (SummonToggleUIController)LuaObject.checkSelf(l);
			Action<SummonToggleUIController> value;
			int num = LuaObject.checkDelegate<Action<SummonToggleUIController>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					summonToggleUIController.EventOnToggleClick += value;
				}
				else if (num == 2)
				{
					summonToggleUIController.EventOnToggleClick -= value;
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

	// Token: 0x060215E9 RID: 136681 RVA: 0x00B45C1C File Offset: 0x00B43E1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_toggle(IntPtr l)
	{
		int result;
		try
		{
			SummonToggleUIController summonToggleUIController = (SummonToggleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, summonToggleUIController.m_luaExportHelper.m_toggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060215EA RID: 136682 RVA: 0x00B45C74 File Offset: 0x00B43E74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_toggle(IntPtr l)
	{
		int result;
		try
		{
			SummonToggleUIController summonToggleUIController = (SummonToggleUIController)LuaObject.checkSelf(l);
			Toggle toggle;
			LuaObject.checkType<Toggle>(l, 2, out toggle);
			summonToggleUIController.m_luaExportHelper.m_toggle = toggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060215EB RID: 136683 RVA: 0x00B45CD0 File Offset: 0x00B43ED0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_clickIconImage(IntPtr l)
	{
		int result;
		try
		{
			SummonToggleUIController summonToggleUIController = (SummonToggleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, summonToggleUIController.m_luaExportHelper.m_clickIconImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060215EC RID: 136684 RVA: 0x00B45D28 File Offset: 0x00B43F28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_clickIconImage(IntPtr l)
	{
		int result;
		try
		{
			SummonToggleUIController summonToggleUIController = (SummonToggleUIController)LuaObject.checkSelf(l);
			Image clickIconImage;
			LuaObject.checkType<Image>(l, 2, out clickIconImage);
			summonToggleUIController.m_luaExportHelper.m_clickIconImage = clickIconImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060215ED RID: 136685 RVA: 0x00B45D84 File Offset: 0x00B43F84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_unClickIconImage(IntPtr l)
	{
		int result;
		try
		{
			SummonToggleUIController summonToggleUIController = (SummonToggleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, summonToggleUIController.m_luaExportHelper.m_unClickIconImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060215EE RID: 136686 RVA: 0x00B45DDC File Offset: 0x00B43FDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_unClickIconImage(IntPtr l)
	{
		int result;
		try
		{
			SummonToggleUIController summonToggleUIController = (SummonToggleUIController)LuaObject.checkSelf(l);
			Image unClickIconImage;
			LuaObject.checkType<Image>(l, 2, out unClickIconImage);
			summonToggleUIController.m_luaExportHelper.m_unClickIconImage = unClickIconImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060215EF RID: 136687 RVA: 0x00B45E38 File Offset: 0x00B44038
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_nameClickText(IntPtr l)
	{
		int result;
		try
		{
			SummonToggleUIController summonToggleUIController = (SummonToggleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, summonToggleUIController.m_luaExportHelper.m_nameClickText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060215F0 RID: 136688 RVA: 0x00B45E90 File Offset: 0x00B44090
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_nameClickText(IntPtr l)
	{
		int result;
		try
		{
			SummonToggleUIController summonToggleUIController = (SummonToggleUIController)LuaObject.checkSelf(l);
			Text nameClickText;
			LuaObject.checkType<Text>(l, 2, out nameClickText);
			summonToggleUIController.m_luaExportHelper.m_nameClickText = nameClickText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060215F1 RID: 136689 RVA: 0x00B45EEC File Offset: 0x00B440EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_nameUnClickText(IntPtr l)
	{
		int result;
		try
		{
			SummonToggleUIController summonToggleUIController = (SummonToggleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, summonToggleUIController.m_luaExportHelper.m_nameUnClickText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060215F2 RID: 136690 RVA: 0x00B45F44 File Offset: 0x00B44144
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_nameUnClickText(IntPtr l)
	{
		int result;
		try
		{
			SummonToggleUIController summonToggleUIController = (SummonToggleUIController)LuaObject.checkSelf(l);
			Text nameUnClickText;
			LuaObject.checkType<Text>(l, 2, out nameUnClickText);
			summonToggleUIController.m_luaExportHelper.m_nameUnClickText = nameUnClickText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060215F3 RID: 136691 RVA: 0x00B45FA0 File Offset: 0x00B441A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_timeClickText(IntPtr l)
	{
		int result;
		try
		{
			SummonToggleUIController summonToggleUIController = (SummonToggleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, summonToggleUIController.m_luaExportHelper.m_timeClickText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060215F4 RID: 136692 RVA: 0x00B45FF8 File Offset: 0x00B441F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_timeClickText(IntPtr l)
	{
		int result;
		try
		{
			SummonToggleUIController summonToggleUIController = (SummonToggleUIController)LuaObject.checkSelf(l);
			Text timeClickText;
			LuaObject.checkType<Text>(l, 2, out timeClickText);
			summonToggleUIController.m_luaExportHelper.m_timeClickText = timeClickText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060215F5 RID: 136693 RVA: 0x00B46054 File Offset: 0x00B44254
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_timeUnClickText(IntPtr l)
	{
		int result;
		try
		{
			SummonToggleUIController summonToggleUIController = (SummonToggleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, summonToggleUIController.m_luaExportHelper.m_timeUnClickText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060215F6 RID: 136694 RVA: 0x00B460AC File Offset: 0x00B442AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_timeUnClickText(IntPtr l)
	{
		int result;
		try
		{
			SummonToggleUIController summonToggleUIController = (SummonToggleUIController)LuaObject.checkSelf(l);
			Text timeUnClickText;
			LuaObject.checkType<Text>(l, 2, out timeUnClickText);
			summonToggleUIController.m_luaExportHelper.m_timeUnClickText = timeUnClickText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060215F7 RID: 136695 RVA: 0x00B46108 File Offset: 0x00B44308
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_CardPool(IntPtr l)
	{
		int result;
		try
		{
			SummonToggleUIController summonToggleUIController = (SummonToggleUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, summonToggleUIController.CardPool);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060215F8 RID: 136696 RVA: 0x00B4615C File Offset: 0x00B4435C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_CardPool(IntPtr l)
	{
		int result;
		try
		{
			SummonToggleUIController summonToggleUIController = (SummonToggleUIController)LuaObject.checkSelf(l);
			CardPool cardPool;
			LuaObject.checkType<CardPool>(l, 2, out cardPool);
			summonToggleUIController.m_luaExportHelper.CardPool = cardPool;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060215F9 RID: 136697 RVA: 0x00B461B8 File Offset: 0x00B443B8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.SummonToggleUIController");
		if (Lua_BlackJack_ProjectL_UI_SummonToggleUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_SummonToggleUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SummonToggleUIController.SetSummonToggleInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SummonToggleUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_SummonToggleUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_SummonToggleUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SummonToggleUIController.SetToggleIsOn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SummonToggleUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_SummonToggleUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_SummonToggleUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SummonToggleUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SummonToggleUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_SummonToggleUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_SummonToggleUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SummonToggleUIController.OnToggleValueChanged);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SummonToggleUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_SummonToggleUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_SummonToggleUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SummonToggleUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SummonToggleUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_SummonToggleUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_SummonToggleUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SummonToggleUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SummonToggleUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_SummonToggleUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_SummonToggleUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SummonToggleUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SummonToggleUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_SummonToggleUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_SummonToggleUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SummonToggleUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SummonToggleUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_SummonToggleUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_SummonToggleUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SummonToggleUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SummonToggleUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_SummonToggleUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_SummonToggleUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SummonToggleUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SummonToggleUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_SummonToggleUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_SummonToggleUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SummonToggleUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SummonToggleUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_SummonToggleUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_SummonToggleUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SummonToggleUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SummonToggleUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_SummonToggleUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_SummonToggleUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SummonToggleUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SummonToggleUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_SummonToggleUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_SummonToggleUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SummonToggleUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SummonToggleUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_SummonToggleUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_SummonToggleUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SummonToggleUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SummonToggleUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_SummonToggleUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_SummonToggleUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SummonToggleUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SummonToggleUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_SummonToggleUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_SummonToggleUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SummonToggleUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SummonToggleUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_SummonToggleUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_SummonToggleUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SummonToggleUIController.__callDele_EventOnToggleClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SummonToggleUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_SummonToggleUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_SummonToggleUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SummonToggleUIController.__clearDele_EventOnToggleClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SummonToggleUIController.<>f__mg$cache12);
		string name = "EventOnToggleClick";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_SummonToggleUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_SummonToggleUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SummonToggleUIController.set_EventOnToggleClick);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_SummonToggleUIController.<>f__mg$cache13, true);
		string name2 = "m_toggle";
		if (Lua_BlackJack_ProjectL_UI_SummonToggleUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_SummonToggleUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SummonToggleUIController.get_m_toggle);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_SummonToggleUIController.<>f__mg$cache14;
		if (Lua_BlackJack_ProjectL_UI_SummonToggleUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_SummonToggleUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SummonToggleUIController.set_m_toggle);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_SummonToggleUIController.<>f__mg$cache15, true);
		string name3 = "m_clickIconImage";
		if (Lua_BlackJack_ProjectL_UI_SummonToggleUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_SummonToggleUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SummonToggleUIController.get_m_clickIconImage);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_SummonToggleUIController.<>f__mg$cache16;
		if (Lua_BlackJack_ProjectL_UI_SummonToggleUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_SummonToggleUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SummonToggleUIController.set_m_clickIconImage);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_SummonToggleUIController.<>f__mg$cache17, true);
		string name4 = "m_unClickIconImage";
		if (Lua_BlackJack_ProjectL_UI_SummonToggleUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_SummonToggleUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SummonToggleUIController.get_m_unClickIconImage);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_SummonToggleUIController.<>f__mg$cache18;
		if (Lua_BlackJack_ProjectL_UI_SummonToggleUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_SummonToggleUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SummonToggleUIController.set_m_unClickIconImage);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_SummonToggleUIController.<>f__mg$cache19, true);
		string name5 = "m_nameClickText";
		if (Lua_BlackJack_ProjectL_UI_SummonToggleUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_SummonToggleUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SummonToggleUIController.get_m_nameClickText);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_SummonToggleUIController.<>f__mg$cache1A;
		if (Lua_BlackJack_ProjectL_UI_SummonToggleUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_SummonToggleUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SummonToggleUIController.set_m_nameClickText);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_SummonToggleUIController.<>f__mg$cache1B, true);
		string name6 = "m_nameUnClickText";
		if (Lua_BlackJack_ProjectL_UI_SummonToggleUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_SummonToggleUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SummonToggleUIController.get_m_nameUnClickText);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_SummonToggleUIController.<>f__mg$cache1C;
		if (Lua_BlackJack_ProjectL_UI_SummonToggleUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_SummonToggleUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SummonToggleUIController.set_m_nameUnClickText);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_SummonToggleUIController.<>f__mg$cache1D, true);
		string name7 = "m_timeClickText";
		if (Lua_BlackJack_ProjectL_UI_SummonToggleUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_SummonToggleUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SummonToggleUIController.get_m_timeClickText);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_SummonToggleUIController.<>f__mg$cache1E;
		if (Lua_BlackJack_ProjectL_UI_SummonToggleUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_SummonToggleUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SummonToggleUIController.set_m_timeClickText);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_SummonToggleUIController.<>f__mg$cache1F, true);
		string name8 = "m_timeUnClickText";
		if (Lua_BlackJack_ProjectL_UI_SummonToggleUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_SummonToggleUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SummonToggleUIController.get_m_timeUnClickText);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_SummonToggleUIController.<>f__mg$cache20;
		if (Lua_BlackJack_ProjectL_UI_SummonToggleUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_SummonToggleUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SummonToggleUIController.set_m_timeUnClickText);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_SummonToggleUIController.<>f__mg$cache21, true);
		string name9 = "CardPool";
		if (Lua_BlackJack_ProjectL_UI_SummonToggleUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_SummonToggleUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SummonToggleUIController.get_CardPool);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_SummonToggleUIController.<>f__mg$cache22;
		if (Lua_BlackJack_ProjectL_UI_SummonToggleUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_SummonToggleUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SummonToggleUIController.set_CardPool);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_SummonToggleUIController.<>f__mg$cache23, true);
		LuaObject.createTypeMetatable(l, null, typeof(SummonToggleUIController), typeof(UIControllerBase));
	}

	// Token: 0x0401749D RID: 95389
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0401749E RID: 95390
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0401749F RID: 95391
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040174A0 RID: 95392
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040174A1 RID: 95393
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040174A2 RID: 95394
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040174A3 RID: 95395
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040174A4 RID: 95396
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x040174A5 RID: 95397
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x040174A6 RID: 95398
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x040174A7 RID: 95399
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x040174A8 RID: 95400
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x040174A9 RID: 95401
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x040174AA RID: 95402
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x040174AB RID: 95403
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x040174AC RID: 95404
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x040174AD RID: 95405
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x040174AE RID: 95406
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x040174AF RID: 95407
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x040174B0 RID: 95408
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x040174B1 RID: 95409
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x040174B2 RID: 95410
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x040174B3 RID: 95411
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x040174B4 RID: 95412
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x040174B5 RID: 95413
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x040174B6 RID: 95414
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x040174B7 RID: 95415
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x040174B8 RID: 95416
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x040174B9 RID: 95417
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x040174BA RID: 95418
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x040174BB RID: 95419
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x040174BC RID: 95420
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x040174BD RID: 95421
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x040174BE RID: 95422
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x040174BF RID: 95423
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x040174C0 RID: 95424
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;
}
