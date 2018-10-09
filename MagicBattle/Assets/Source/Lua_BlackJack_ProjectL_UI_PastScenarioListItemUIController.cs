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

// Token: 0x02001522 RID: 5410
[Preserve]
public class Lua_BlackJack_ProjectL_UI_PastScenarioListItemUIController : LuaObject
{
	// Token: 0x060201F3 RID: 131571 RVA: 0x00AA60E4 File Offset: 0x00AA42E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetScenarioInfo(IntPtr l)
	{
		int result;
		try
		{
			PastScenarioListItemUIController pastScenarioListItemUIController = (PastScenarioListItemUIController)LuaObject.checkSelf(l);
			ConfigDataScenarioInfo scenarioInfo;
			LuaObject.checkType<ConfigDataScenarioInfo>(l, 2, out scenarioInfo);
			pastScenarioListItemUIController.SetScenarioInfo(scenarioInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060201F4 RID: 131572 RVA: 0x00AA613C File Offset: 0x00AA433C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetScenarioInfo(IntPtr l)
	{
		int result;
		try
		{
			PastScenarioListItemUIController pastScenarioListItemUIController = (PastScenarioListItemUIController)LuaObject.checkSelf(l);
			ConfigDataScenarioInfo scenarioInfo = pastScenarioListItemUIController.GetScenarioInfo();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, scenarioInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060201F5 RID: 131573 RVA: 0x00AA6190 File Offset: 0x00AA4390
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			PastScenarioListItemUIController pastScenarioListItemUIController = (PastScenarioListItemUIController)LuaObject.checkSelf(l);
			pastScenarioListItemUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060201F6 RID: 131574 RVA: 0x00AA61E4 File Offset: 0x00AA43E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnStartButtonClick(IntPtr l)
	{
		int result;
		try
		{
			PastScenarioListItemUIController pastScenarioListItemUIController = (PastScenarioListItemUIController)LuaObject.checkSelf(l);
			pastScenarioListItemUIController.m_luaExportHelper.OnStartButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060201F7 RID: 131575 RVA: 0x00AA6238 File Offset: 0x00AA4438
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			PastScenarioListItemUIController pastScenarioListItemUIController = (PastScenarioListItemUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			pastScenarioListItemUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060201F8 RID: 131576 RVA: 0x00AA62A4 File Offset: 0x00AA44A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			PastScenarioListItemUIController pastScenarioListItemUIController = (PastScenarioListItemUIController)LuaObject.checkSelf(l);
			pastScenarioListItemUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060201F9 RID: 131577 RVA: 0x00AA62F8 File Offset: 0x00AA44F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			PastScenarioListItemUIController pastScenarioListItemUIController = (PastScenarioListItemUIController)LuaObject.checkSelf(l);
			pastScenarioListItemUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060201FA RID: 131578 RVA: 0x00AA634C File Offset: 0x00AA454C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			PastScenarioListItemUIController pastScenarioListItemUIController = (PastScenarioListItemUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = pastScenarioListItemUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x060201FB RID: 131579 RVA: 0x00AA63F4 File Offset: 0x00AA45F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			PastScenarioListItemUIController pastScenarioListItemUIController = (PastScenarioListItemUIController)LuaObject.checkSelf(l);
			pastScenarioListItemUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060201FC RID: 131580 RVA: 0x00AA6448 File Offset: 0x00AA4648
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			PastScenarioListItemUIController pastScenarioListItemUIController = (PastScenarioListItemUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			pastScenarioListItemUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060201FD RID: 131581 RVA: 0x00AA64B4 File Offset: 0x00AA46B4
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
				PastScenarioListItemUIController pastScenarioListItemUIController = (PastScenarioListItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				pastScenarioListItemUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				PastScenarioListItemUIController pastScenarioListItemUIController2 = (PastScenarioListItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				pastScenarioListItemUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x060201FE RID: 131582 RVA: 0x00AA65C4 File Offset: 0x00AA47C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			PastScenarioListItemUIController pastScenarioListItemUIController = (PastScenarioListItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			pastScenarioListItemUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060201FF RID: 131583 RVA: 0x00AA6630 File Offset: 0x00AA4830
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			PastScenarioListItemUIController pastScenarioListItemUIController = (PastScenarioListItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			pastScenarioListItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020200 RID: 131584 RVA: 0x00AA669C File Offset: 0x00AA489C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			PastScenarioListItemUIController pastScenarioListItemUIController = (PastScenarioListItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			pastScenarioListItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020201 RID: 131585 RVA: 0x00AA6708 File Offset: 0x00AA4908
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			PastScenarioListItemUIController pastScenarioListItemUIController = (PastScenarioListItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			pastScenarioListItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020202 RID: 131586 RVA: 0x00AA6774 File Offset: 0x00AA4974
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetToggleValueChangedListener(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(string[]), typeof(Action<UIControllerBase, bool>)))
			{
				PastScenarioListItemUIController pastScenarioListItemUIController = (PastScenarioListItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				pastScenarioListItemUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				PastScenarioListItemUIController pastScenarioListItemUIController2 = (PastScenarioListItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				pastScenarioListItemUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x06020203 RID: 131587 RVA: 0x00AA6884 File Offset: 0x00AA4A84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			PastScenarioListItemUIController pastScenarioListItemUIController = (PastScenarioListItemUIController)LuaObject.checkSelf(l);
			string s = pastScenarioListItemUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x06020204 RID: 131588 RVA: 0x00AA68E0 File Offset: 0x00AA4AE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnStart(IntPtr l)
	{
		int result;
		try
		{
			PastScenarioListItemUIController pastScenarioListItemUIController = (PastScenarioListItemUIController)LuaObject.checkSelf(l);
			PastScenarioListItemUIController obj;
			LuaObject.checkType<PastScenarioListItemUIController>(l, 2, out obj);
			pastScenarioListItemUIController.m_luaExportHelper.__callDele_EventOnStart(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020205 RID: 131589 RVA: 0x00AA693C File Offset: 0x00AA4B3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnStart(IntPtr l)
	{
		int result;
		try
		{
			PastScenarioListItemUIController pastScenarioListItemUIController = (PastScenarioListItemUIController)LuaObject.checkSelf(l);
			PastScenarioListItemUIController obj;
			LuaObject.checkType<PastScenarioListItemUIController>(l, 2, out obj);
			pastScenarioListItemUIController.m_luaExportHelper.__clearDele_EventOnStart(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020206 RID: 131590 RVA: 0x00AA6998 File Offset: 0x00AA4B98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnStart(IntPtr l)
	{
		int result;
		try
		{
			PastScenarioListItemUIController pastScenarioListItemUIController = (PastScenarioListItemUIController)LuaObject.checkSelf(l);
			Action<PastScenarioListItemUIController> value;
			int num = LuaObject.checkDelegate<Action<PastScenarioListItemUIController>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					pastScenarioListItemUIController.EventOnStart += value;
				}
				else if (num == 2)
				{
					pastScenarioListItemUIController.EventOnStart -= value;
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

	// Token: 0x06020207 RID: 131591 RVA: 0x00AA6A18 File Offset: 0x00AA4C18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_startButton(IntPtr l)
	{
		int result;
		try
		{
			PastScenarioListItemUIController pastScenarioListItemUIController = (PastScenarioListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, pastScenarioListItemUIController.m_luaExportHelper.m_startButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020208 RID: 131592 RVA: 0x00AA6A70 File Offset: 0x00AA4C70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_startButton(IntPtr l)
	{
		int result;
		try
		{
			PastScenarioListItemUIController pastScenarioListItemUIController = (PastScenarioListItemUIController)LuaObject.checkSelf(l);
			Button startButton;
			LuaObject.checkType<Button>(l, 2, out startButton);
			pastScenarioListItemUIController.m_luaExportHelper.m_startButton = startButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020209 RID: 131593 RVA: 0x00AA6ACC File Offset: 0x00AA4CCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_nameText(IntPtr l)
	{
		int result;
		try
		{
			PastScenarioListItemUIController pastScenarioListItemUIController = (PastScenarioListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, pastScenarioListItemUIController.m_luaExportHelper.m_nameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602020A RID: 131594 RVA: 0x00AA6B24 File Offset: 0x00AA4D24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_nameText(IntPtr l)
	{
		int result;
		try
		{
			PastScenarioListItemUIController pastScenarioListItemUIController = (PastScenarioListItemUIController)LuaObject.checkSelf(l);
			Text nameText;
			LuaObject.checkType<Text>(l, 2, out nameText);
			pastScenarioListItemUIController.m_luaExportHelper.m_nameText = nameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602020B RID: 131595 RVA: 0x00AA6B80 File Offset: 0x00AA4D80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_levelText(IntPtr l)
	{
		int result;
		try
		{
			PastScenarioListItemUIController pastScenarioListItemUIController = (PastScenarioListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, pastScenarioListItemUIController.m_luaExportHelper.m_levelText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602020C RID: 131596 RVA: 0x00AA6BD8 File Offset: 0x00AA4DD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_levelText(IntPtr l)
	{
		int result;
		try
		{
			PastScenarioListItemUIController pastScenarioListItemUIController = (PastScenarioListItemUIController)LuaObject.checkSelf(l);
			Text levelText;
			LuaObject.checkType<Text>(l, 2, out levelText);
			pastScenarioListItemUIController.m_luaExportHelper.m_levelText = levelText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602020D RID: 131597 RVA: 0x00AA6C34 File Offset: 0x00AA4E34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_energyText(IntPtr l)
	{
		int result;
		try
		{
			PastScenarioListItemUIController pastScenarioListItemUIController = (PastScenarioListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, pastScenarioListItemUIController.m_luaExportHelper.m_energyText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602020E RID: 131598 RVA: 0x00AA6C8C File Offset: 0x00AA4E8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_energyText(IntPtr l)
	{
		int result;
		try
		{
			PastScenarioListItemUIController pastScenarioListItemUIController = (PastScenarioListItemUIController)LuaObject.checkSelf(l);
			Text energyText;
			LuaObject.checkType<Text>(l, 2, out energyText);
			pastScenarioListItemUIController.m_luaExportHelper.m_energyText = energyText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602020F RID: 131599 RVA: 0x00AA6CE8 File Offset: 0x00AA4EE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_rewardGoodsListGameObject(IntPtr l)
	{
		int result;
		try
		{
			PastScenarioListItemUIController pastScenarioListItemUIController = (PastScenarioListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, pastScenarioListItemUIController.m_luaExportHelper.m_rewardGoodsListGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020210 RID: 131600 RVA: 0x00AA6D40 File Offset: 0x00AA4F40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_rewardGoodsListGameObject(IntPtr l)
	{
		int result;
		try
		{
			PastScenarioListItemUIController pastScenarioListItemUIController = (PastScenarioListItemUIController)LuaObject.checkSelf(l);
			GameObject rewardGoodsListGameObject;
			LuaObject.checkType<GameObject>(l, 2, out rewardGoodsListGameObject);
			pastScenarioListItemUIController.m_luaExportHelper.m_rewardGoodsListGameObject = rewardGoodsListGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020211 RID: 131601 RVA: 0x00AA6D9C File Offset: 0x00AA4F9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_scenarioInfo(IntPtr l)
	{
		int result;
		try
		{
			PastScenarioListItemUIController pastScenarioListItemUIController = (PastScenarioListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, pastScenarioListItemUIController.m_luaExportHelper.m_scenarioInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020212 RID: 131602 RVA: 0x00AA6DF4 File Offset: 0x00AA4FF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_scenarioInfo(IntPtr l)
	{
		int result;
		try
		{
			PastScenarioListItemUIController pastScenarioListItemUIController = (PastScenarioListItemUIController)LuaObject.checkSelf(l);
			ConfigDataScenarioInfo scenarioInfo;
			LuaObject.checkType<ConfigDataScenarioInfo>(l, 2, out scenarioInfo);
			pastScenarioListItemUIController.m_luaExportHelper.m_scenarioInfo = scenarioInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020213 RID: 131603 RVA: 0x00AA6E50 File Offset: 0x00AA5050
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.PastScenarioListItemUIController");
		if (Lua_BlackJack_ProjectL_UI_PastScenarioListItemUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_PastScenarioListItemUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PastScenarioListItemUIController.SetScenarioInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PastScenarioListItemUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_PastScenarioListItemUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_PastScenarioListItemUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PastScenarioListItemUIController.GetScenarioInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PastScenarioListItemUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_PastScenarioListItemUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_PastScenarioListItemUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PastScenarioListItemUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PastScenarioListItemUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_PastScenarioListItemUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_PastScenarioListItemUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PastScenarioListItemUIController.OnStartButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PastScenarioListItemUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_PastScenarioListItemUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_PastScenarioListItemUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PastScenarioListItemUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PastScenarioListItemUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_PastScenarioListItemUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_PastScenarioListItemUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PastScenarioListItemUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PastScenarioListItemUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_PastScenarioListItemUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_PastScenarioListItemUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PastScenarioListItemUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PastScenarioListItemUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_PastScenarioListItemUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_PastScenarioListItemUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PastScenarioListItemUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PastScenarioListItemUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_PastScenarioListItemUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_PastScenarioListItemUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PastScenarioListItemUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PastScenarioListItemUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_PastScenarioListItemUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_PastScenarioListItemUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PastScenarioListItemUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PastScenarioListItemUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_PastScenarioListItemUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_PastScenarioListItemUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PastScenarioListItemUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PastScenarioListItemUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_PastScenarioListItemUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_PastScenarioListItemUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PastScenarioListItemUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PastScenarioListItemUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_PastScenarioListItemUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_PastScenarioListItemUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PastScenarioListItemUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PastScenarioListItemUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_PastScenarioListItemUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_PastScenarioListItemUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PastScenarioListItemUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PastScenarioListItemUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_PastScenarioListItemUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_PastScenarioListItemUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PastScenarioListItemUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PastScenarioListItemUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_PastScenarioListItemUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_PastScenarioListItemUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PastScenarioListItemUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PastScenarioListItemUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_PastScenarioListItemUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_PastScenarioListItemUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PastScenarioListItemUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PastScenarioListItemUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_PastScenarioListItemUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_PastScenarioListItemUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PastScenarioListItemUIController.__callDele_EventOnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PastScenarioListItemUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_PastScenarioListItemUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_PastScenarioListItemUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PastScenarioListItemUIController.__clearDele_EventOnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PastScenarioListItemUIController.<>f__mg$cache12);
		string name = "EventOnStart";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_PastScenarioListItemUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_PastScenarioListItemUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PastScenarioListItemUIController.set_EventOnStart);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_PastScenarioListItemUIController.<>f__mg$cache13, true);
		string name2 = "m_startButton";
		if (Lua_BlackJack_ProjectL_UI_PastScenarioListItemUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_PastScenarioListItemUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PastScenarioListItemUIController.get_m_startButton);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_PastScenarioListItemUIController.<>f__mg$cache14;
		if (Lua_BlackJack_ProjectL_UI_PastScenarioListItemUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_PastScenarioListItemUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PastScenarioListItemUIController.set_m_startButton);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_PastScenarioListItemUIController.<>f__mg$cache15, true);
		string name3 = "m_nameText";
		if (Lua_BlackJack_ProjectL_UI_PastScenarioListItemUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_PastScenarioListItemUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PastScenarioListItemUIController.get_m_nameText);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_PastScenarioListItemUIController.<>f__mg$cache16;
		if (Lua_BlackJack_ProjectL_UI_PastScenarioListItemUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_PastScenarioListItemUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PastScenarioListItemUIController.set_m_nameText);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_PastScenarioListItemUIController.<>f__mg$cache17, true);
		string name4 = "m_levelText";
		if (Lua_BlackJack_ProjectL_UI_PastScenarioListItemUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_PastScenarioListItemUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PastScenarioListItemUIController.get_m_levelText);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_PastScenarioListItemUIController.<>f__mg$cache18;
		if (Lua_BlackJack_ProjectL_UI_PastScenarioListItemUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_PastScenarioListItemUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PastScenarioListItemUIController.set_m_levelText);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_PastScenarioListItemUIController.<>f__mg$cache19, true);
		string name5 = "m_energyText";
		if (Lua_BlackJack_ProjectL_UI_PastScenarioListItemUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_PastScenarioListItemUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PastScenarioListItemUIController.get_m_energyText);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_PastScenarioListItemUIController.<>f__mg$cache1A;
		if (Lua_BlackJack_ProjectL_UI_PastScenarioListItemUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_PastScenarioListItemUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PastScenarioListItemUIController.set_m_energyText);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_PastScenarioListItemUIController.<>f__mg$cache1B, true);
		string name6 = "m_rewardGoodsListGameObject";
		if (Lua_BlackJack_ProjectL_UI_PastScenarioListItemUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_PastScenarioListItemUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PastScenarioListItemUIController.get_m_rewardGoodsListGameObject);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_PastScenarioListItemUIController.<>f__mg$cache1C;
		if (Lua_BlackJack_ProjectL_UI_PastScenarioListItemUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_PastScenarioListItemUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PastScenarioListItemUIController.set_m_rewardGoodsListGameObject);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_PastScenarioListItemUIController.<>f__mg$cache1D, true);
		string name7 = "m_scenarioInfo";
		if (Lua_BlackJack_ProjectL_UI_PastScenarioListItemUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_PastScenarioListItemUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PastScenarioListItemUIController.get_m_scenarioInfo);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_PastScenarioListItemUIController.<>f__mg$cache1E;
		if (Lua_BlackJack_ProjectL_UI_PastScenarioListItemUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_PastScenarioListItemUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PastScenarioListItemUIController.set_m_scenarioInfo);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_PastScenarioListItemUIController.<>f__mg$cache1F, true);
		LuaObject.createTypeMetatable(l, null, typeof(PastScenarioListItemUIController), typeof(UIControllerBase));
	}

	// Token: 0x04016191 RID: 90513
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04016192 RID: 90514
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04016193 RID: 90515
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04016194 RID: 90516
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04016195 RID: 90517
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04016196 RID: 90518
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04016197 RID: 90519
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04016198 RID: 90520
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04016199 RID: 90521
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0401619A RID: 90522
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0401619B RID: 90523
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0401619C RID: 90524
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0401619D RID: 90525
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0401619E RID: 90526
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0401619F RID: 90527
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x040161A0 RID: 90528
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x040161A1 RID: 90529
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x040161A2 RID: 90530
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x040161A3 RID: 90531
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x040161A4 RID: 90532
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x040161A5 RID: 90533
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x040161A6 RID: 90534
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x040161A7 RID: 90535
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x040161A8 RID: 90536
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x040161A9 RID: 90537
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x040161AA RID: 90538
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x040161AB RID: 90539
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x040161AC RID: 90540
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x040161AD RID: 90541
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x040161AE RID: 90542
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x040161AF RID: 90543
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x040161B0 RID: 90544
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;
}
