using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Scene;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x02001580 RID: 5504
[Preserve]
public class Lua_BlackJack_ProjectL_UI_SoldierManualItemUIController : LuaObject
{
	// Token: 0x06021201 RID: 135681 RVA: 0x00B2697C File Offset: 0x00B24B7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitSoldierItem(IntPtr l)
	{
		int result;
		try
		{
			SoldierManualItemUIController soldierManualItemUIController = (SoldierManualItemUIController)LuaObject.checkSelf(l);
			ConfigDataSoldierInfo soldierInfo;
			LuaObject.checkType<ConfigDataSoldierInfo>(l, 2, out soldierInfo);
			soldierManualItemUIController.InitSoldierItem(soldierInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021202 RID: 135682 RVA: 0x00B269D4 File Offset: 0x00B24BD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetClickImageActive(IntPtr l)
	{
		int result;
		try
		{
			SoldierManualItemUIController soldierManualItemUIController = (SoldierManualItemUIController)LuaObject.checkSelf(l);
			bool clickImageActive;
			LuaObject.checkType(l, 2, out clickImageActive);
			soldierManualItemUIController.SetClickImageActive(clickImageActive);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021203 RID: 135683 RVA: 0x00B26A2C File Offset: 0x00B24C2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			SoldierManualItemUIController soldierManualItemUIController = (SoldierManualItemUIController)LuaObject.checkSelf(l);
			soldierManualItemUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021204 RID: 135684 RVA: 0x00B26A80 File Offset: 0x00B24C80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnSoldierItemClick(IntPtr l)
	{
		int result;
		try
		{
			SoldierManualItemUIController soldierManualItemUIController = (SoldierManualItemUIController)LuaObject.checkSelf(l);
			soldierManualItemUIController.m_luaExportHelper.OnSoldierItemClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021205 RID: 135685 RVA: 0x00B26AD4 File Offset: 0x00B24CD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			SoldierManualItemUIController soldierManualItemUIController = (SoldierManualItemUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			soldierManualItemUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021206 RID: 135686 RVA: 0x00B26B40 File Offset: 0x00B24D40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			SoldierManualItemUIController soldierManualItemUIController = (SoldierManualItemUIController)LuaObject.checkSelf(l);
			soldierManualItemUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021207 RID: 135687 RVA: 0x00B26B94 File Offset: 0x00B24D94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			SoldierManualItemUIController soldierManualItemUIController = (SoldierManualItemUIController)LuaObject.checkSelf(l);
			soldierManualItemUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021208 RID: 135688 RVA: 0x00B26BE8 File Offset: 0x00B24DE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			SoldierManualItemUIController soldierManualItemUIController = (SoldierManualItemUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = soldierManualItemUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x06021209 RID: 135689 RVA: 0x00B26C90 File Offset: 0x00B24E90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			SoldierManualItemUIController soldierManualItemUIController = (SoldierManualItemUIController)LuaObject.checkSelf(l);
			soldierManualItemUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602120A RID: 135690 RVA: 0x00B26CE4 File Offset: 0x00B24EE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			SoldierManualItemUIController soldierManualItemUIController = (SoldierManualItemUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			soldierManualItemUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602120B RID: 135691 RVA: 0x00B26D50 File Offset: 0x00B24F50
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
				SoldierManualItemUIController soldierManualItemUIController = (SoldierManualItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				soldierManualItemUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				SoldierManualItemUIController soldierManualItemUIController2 = (SoldierManualItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				soldierManualItemUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0602120C RID: 135692 RVA: 0x00B26E60 File Offset: 0x00B25060
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			SoldierManualItemUIController soldierManualItemUIController = (SoldierManualItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			soldierManualItemUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602120D RID: 135693 RVA: 0x00B26ECC File Offset: 0x00B250CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			SoldierManualItemUIController soldierManualItemUIController = (SoldierManualItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			soldierManualItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602120E RID: 135694 RVA: 0x00B26F38 File Offset: 0x00B25138
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			SoldierManualItemUIController soldierManualItemUIController = (SoldierManualItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			soldierManualItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602120F RID: 135695 RVA: 0x00B26FA4 File Offset: 0x00B251A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			SoldierManualItemUIController soldierManualItemUIController = (SoldierManualItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			soldierManualItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021210 RID: 135696 RVA: 0x00B27010 File Offset: 0x00B25210
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
				SoldierManualItemUIController soldierManualItemUIController = (SoldierManualItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				soldierManualItemUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				SoldierManualItemUIController soldierManualItemUIController2 = (SoldierManualItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				soldierManualItemUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x06021211 RID: 135697 RVA: 0x00B27120 File Offset: 0x00B25320
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			SoldierManualItemUIController soldierManualItemUIController = (SoldierManualItemUIController)LuaObject.checkSelf(l);
			string s = soldierManualItemUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x06021212 RID: 135698 RVA: 0x00B2717C File Offset: 0x00B2537C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnSoldierItemClick(IntPtr l)
	{
		int result;
		try
		{
			SoldierManualItemUIController soldierManualItemUIController = (SoldierManualItemUIController)LuaObject.checkSelf(l);
			SoldierManualItemUIController obj;
			LuaObject.checkType<SoldierManualItemUIController>(l, 2, out obj);
			soldierManualItemUIController.m_luaExportHelper.__callDele_EventOnSoldierItemClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021213 RID: 135699 RVA: 0x00B271D8 File Offset: 0x00B253D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnSoldierItemClick(IntPtr l)
	{
		int result;
		try
		{
			SoldierManualItemUIController soldierManualItemUIController = (SoldierManualItemUIController)LuaObject.checkSelf(l);
			SoldierManualItemUIController obj;
			LuaObject.checkType<SoldierManualItemUIController>(l, 2, out obj);
			soldierManualItemUIController.m_luaExportHelper.__clearDele_EventOnSoldierItemClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021214 RID: 135700 RVA: 0x00B27234 File Offset: 0x00B25434
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnSoldierItemClick(IntPtr l)
	{
		int result;
		try
		{
			SoldierManualItemUIController soldierManualItemUIController = (SoldierManualItemUIController)LuaObject.checkSelf(l);
			Action<SoldierManualItemUIController> value;
			int num = LuaObject.checkDelegate<Action<SoldierManualItemUIController>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					soldierManualItemUIController.EventOnSoldierItemClick += value;
				}
				else if (num == 2)
				{
					soldierManualItemUIController.EventOnSoldierItemClick -= value;
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

	// Token: 0x06021215 RID: 135701 RVA: 0x00B272B4 File Offset: 0x00B254B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierNameText(IntPtr l)
	{
		int result;
		try
		{
			SoldierManualItemUIController soldierManualItemUIController = (SoldierManualItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, soldierManualItemUIController.m_luaExportHelper.m_soldierNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021216 RID: 135702 RVA: 0x00B2730C File Offset: 0x00B2550C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierNameText(IntPtr l)
	{
		int result;
		try
		{
			SoldierManualItemUIController soldierManualItemUIController = (SoldierManualItemUIController)LuaObject.checkSelf(l);
			Text soldierNameText;
			LuaObject.checkType<Text>(l, 2, out soldierNameText);
			soldierManualItemUIController.m_luaExportHelper.m_soldierNameText = soldierNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021217 RID: 135703 RVA: 0x00B27368 File Offset: 0x00B25568
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_clickImage(IntPtr l)
	{
		int result;
		try
		{
			SoldierManualItemUIController soldierManualItemUIController = (SoldierManualItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, soldierManualItemUIController.m_luaExportHelper.m_clickImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021218 RID: 135704 RVA: 0x00B273C0 File Offset: 0x00B255C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_clickImage(IntPtr l)
	{
		int result;
		try
		{
			SoldierManualItemUIController soldierManualItemUIController = (SoldierManualItemUIController)LuaObject.checkSelf(l);
			GameObject clickImage;
			LuaObject.checkType<GameObject>(l, 2, out clickImage);
			soldierManualItemUIController.m_luaExportHelper.m_clickImage = clickImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021219 RID: 135705 RVA: 0x00B2741C File Offset: 0x00B2561C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_lockObj(IntPtr l)
	{
		int result;
		try
		{
			SoldierManualItemUIController soldierManualItemUIController = (SoldierManualItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, soldierManualItemUIController.m_luaExportHelper.m_lockObj);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602121A RID: 135706 RVA: 0x00B27474 File Offset: 0x00B25674
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_lockObj(IntPtr l)
	{
		int result;
		try
		{
			SoldierManualItemUIController soldierManualItemUIController = (SoldierManualItemUIController)LuaObject.checkSelf(l);
			GameObject lockObj;
			LuaObject.checkType<GameObject>(l, 2, out lockObj);
			soldierManualItemUIController.m_luaExportHelper.m_lockObj = lockObj;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602121B RID: 135707 RVA: 0x00B274D0 File Offset: 0x00B256D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierGraphic(IntPtr l)
	{
		int result;
		try
		{
			SoldierManualItemUIController soldierManualItemUIController = (SoldierManualItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, soldierManualItemUIController.m_luaExportHelper.m_soldierGraphic);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602121C RID: 135708 RVA: 0x00B27528 File Offset: 0x00B25728
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierGraphic(IntPtr l)
	{
		int result;
		try
		{
			SoldierManualItemUIController soldierManualItemUIController = (SoldierManualItemUIController)LuaObject.checkSelf(l);
			GameObject soldierGraphic;
			LuaObject.checkType<GameObject>(l, 2, out soldierGraphic);
			soldierManualItemUIController.m_luaExportHelper.m_soldierGraphic = soldierGraphic;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602121D RID: 135709 RVA: 0x00B27584 File Offset: 0x00B25784
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_graphic(IntPtr l)
	{
		int result;
		try
		{
			SoldierManualItemUIController soldierManualItemUIController = (SoldierManualItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, soldierManualItemUIController.m_luaExportHelper.m_graphic);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602121E RID: 135710 RVA: 0x00B275DC File Offset: 0x00B257DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_graphic(IntPtr l)
	{
		int result;
		try
		{
			SoldierManualItemUIController soldierManualItemUIController = (SoldierManualItemUIController)LuaObject.checkSelf(l);
			UISpineGraphic graphic;
			LuaObject.checkType<UISpineGraphic>(l, 2, out graphic);
			soldierManualItemUIController.m_luaExportHelper.m_graphic = graphic;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602121F RID: 135711 RVA: 0x00B27638 File Offset: 0x00B25838
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_SoldierInfo(IntPtr l)
	{
		int result;
		try
		{
			SoldierManualItemUIController soldierManualItemUIController = (SoldierManualItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, soldierManualItemUIController.SoldierInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021220 RID: 135712 RVA: 0x00B2768C File Offset: 0x00B2588C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_SoldierInfo(IntPtr l)
	{
		int result;
		try
		{
			SoldierManualItemUIController soldierManualItemUIController = (SoldierManualItemUIController)LuaObject.checkSelf(l);
			ConfigDataSoldierInfo soldierInfo;
			LuaObject.checkType<ConfigDataSoldierInfo>(l, 2, out soldierInfo);
			soldierManualItemUIController.SoldierInfo = soldierInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021221 RID: 135713 RVA: 0x00B276E4 File Offset: 0x00B258E4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.SoldierManualItemUIController");
		if (Lua_BlackJack_ProjectL_UI_SoldierManualItemUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierManualItemUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierManualItemUIController.InitSoldierItem);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SoldierManualItemUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_SoldierManualItemUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierManualItemUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierManualItemUIController.SetClickImageActive);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SoldierManualItemUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_SoldierManualItemUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierManualItemUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierManualItemUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SoldierManualItemUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_SoldierManualItemUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierManualItemUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierManualItemUIController.OnSoldierItemClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SoldierManualItemUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_SoldierManualItemUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierManualItemUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierManualItemUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SoldierManualItemUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_SoldierManualItemUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierManualItemUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierManualItemUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SoldierManualItemUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_SoldierManualItemUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierManualItemUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierManualItemUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SoldierManualItemUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_SoldierManualItemUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierManualItemUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierManualItemUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SoldierManualItemUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_SoldierManualItemUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierManualItemUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierManualItemUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SoldierManualItemUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_SoldierManualItemUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierManualItemUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierManualItemUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SoldierManualItemUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_SoldierManualItemUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierManualItemUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierManualItemUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SoldierManualItemUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_SoldierManualItemUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierManualItemUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierManualItemUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SoldierManualItemUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_SoldierManualItemUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierManualItemUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierManualItemUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SoldierManualItemUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_SoldierManualItemUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierManualItemUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierManualItemUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SoldierManualItemUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_SoldierManualItemUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierManualItemUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierManualItemUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SoldierManualItemUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_SoldierManualItemUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierManualItemUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierManualItemUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SoldierManualItemUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_SoldierManualItemUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierManualItemUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierManualItemUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SoldierManualItemUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_SoldierManualItemUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierManualItemUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierManualItemUIController.__callDele_EventOnSoldierItemClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SoldierManualItemUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_SoldierManualItemUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierManualItemUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierManualItemUIController.__clearDele_EventOnSoldierItemClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SoldierManualItemUIController.<>f__mg$cache12);
		string name = "EventOnSoldierItemClick";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_SoldierManualItemUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierManualItemUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierManualItemUIController.set_EventOnSoldierItemClick);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_SoldierManualItemUIController.<>f__mg$cache13, true);
		string name2 = "m_soldierNameText";
		if (Lua_BlackJack_ProjectL_UI_SoldierManualItemUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierManualItemUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierManualItemUIController.get_m_soldierNameText);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_SoldierManualItemUIController.<>f__mg$cache14;
		if (Lua_BlackJack_ProjectL_UI_SoldierManualItemUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierManualItemUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierManualItemUIController.set_m_soldierNameText);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_SoldierManualItemUIController.<>f__mg$cache15, true);
		string name3 = "m_clickImage";
		if (Lua_BlackJack_ProjectL_UI_SoldierManualItemUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierManualItemUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierManualItemUIController.get_m_clickImage);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_SoldierManualItemUIController.<>f__mg$cache16;
		if (Lua_BlackJack_ProjectL_UI_SoldierManualItemUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierManualItemUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierManualItemUIController.set_m_clickImage);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_SoldierManualItemUIController.<>f__mg$cache17, true);
		string name4 = "m_lockObj";
		if (Lua_BlackJack_ProjectL_UI_SoldierManualItemUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierManualItemUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierManualItemUIController.get_m_lockObj);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_SoldierManualItemUIController.<>f__mg$cache18;
		if (Lua_BlackJack_ProjectL_UI_SoldierManualItemUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierManualItemUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierManualItemUIController.set_m_lockObj);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_SoldierManualItemUIController.<>f__mg$cache19, true);
		string name5 = "m_soldierGraphic";
		if (Lua_BlackJack_ProjectL_UI_SoldierManualItemUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierManualItemUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierManualItemUIController.get_m_soldierGraphic);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_SoldierManualItemUIController.<>f__mg$cache1A;
		if (Lua_BlackJack_ProjectL_UI_SoldierManualItemUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierManualItemUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierManualItemUIController.set_m_soldierGraphic);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_SoldierManualItemUIController.<>f__mg$cache1B, true);
		string name6 = "m_graphic";
		if (Lua_BlackJack_ProjectL_UI_SoldierManualItemUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierManualItemUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierManualItemUIController.get_m_graphic);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_SoldierManualItemUIController.<>f__mg$cache1C;
		if (Lua_BlackJack_ProjectL_UI_SoldierManualItemUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierManualItemUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierManualItemUIController.set_m_graphic);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_SoldierManualItemUIController.<>f__mg$cache1D, true);
		string name7 = "SoldierInfo";
		if (Lua_BlackJack_ProjectL_UI_SoldierManualItemUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierManualItemUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierManualItemUIController.get_SoldierInfo);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_SoldierManualItemUIController.<>f__mg$cache1E;
		if (Lua_BlackJack_ProjectL_UI_SoldierManualItemUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierManualItemUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierManualItemUIController.set_SoldierInfo);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_SoldierManualItemUIController.<>f__mg$cache1F, true);
		LuaObject.createTypeMetatable(l, null, typeof(SoldierManualItemUIController), typeof(UIControllerBase));
	}

	// Token: 0x040170E3 RID: 94435
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040170E4 RID: 94436
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040170E5 RID: 94437
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040170E6 RID: 94438
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040170E7 RID: 94439
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040170E8 RID: 94440
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040170E9 RID: 94441
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040170EA RID: 94442
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x040170EB RID: 94443
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x040170EC RID: 94444
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x040170ED RID: 94445
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x040170EE RID: 94446
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x040170EF RID: 94447
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x040170F0 RID: 94448
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x040170F1 RID: 94449
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x040170F2 RID: 94450
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x040170F3 RID: 94451
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x040170F4 RID: 94452
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x040170F5 RID: 94453
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x040170F6 RID: 94454
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x040170F7 RID: 94455
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x040170F8 RID: 94456
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x040170F9 RID: 94457
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x040170FA RID: 94458
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x040170FB RID: 94459
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x040170FC RID: 94460
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x040170FD RID: 94461
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x040170FE RID: 94462
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x040170FF RID: 94463
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04017100 RID: 94464
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04017101 RID: 94465
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04017102 RID: 94466
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;
}
