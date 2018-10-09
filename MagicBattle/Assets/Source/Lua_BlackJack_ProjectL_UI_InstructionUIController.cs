using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x020014EF RID: 5359
[Preserve]
public class Lua_BlackJack_ProjectL_UI_InstructionUIController : LuaObject
{
	// Token: 0x0601FA17 RID: 129559 RVA: 0x00A681A8 File Offset: 0x00A663A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Show(IntPtr l)
	{
		int result;
		try
		{
			InstructionUIController instructionUIController = (InstructionUIController)LuaObject.checkSelf(l);
			string prefabName;
			LuaObject.checkType(l, 2, out prefabName);
			instructionUIController.Show(prefabName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FA18 RID: 129560 RVA: 0x00A68200 File Offset: 0x00A66400
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			InstructionUIController instructionUIController = (InstructionUIController)LuaObject.checkSelf(l);
			instructionUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FA19 RID: 129561 RVA: 0x00A68254 File Offset: 0x00A66454
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Close(IntPtr l)
	{
		int result;
		try
		{
			InstructionUIController instructionUIController = (InstructionUIController)LuaObject.checkSelf(l);
			Action onEnd;
			LuaObject.checkDelegate<Action>(l, 2, out onEnd);
			instructionUIController.m_luaExportHelper.Close(onEnd);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FA1A RID: 129562 RVA: 0x00A682B0 File Offset: 0x00A664B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBackgroundButtonClick(IntPtr l)
	{
		int result;
		try
		{
			InstructionUIController instructionUIController = (InstructionUIController)LuaObject.checkSelf(l);
			instructionUIController.m_luaExportHelper.OnBackgroundButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FA1B RID: 129563 RVA: 0x00A68304 File Offset: 0x00A66504
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			InstructionUIController instructionUIController = (InstructionUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			instructionUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FA1C RID: 129564 RVA: 0x00A68370 File Offset: 0x00A66570
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			InstructionUIController instructionUIController = (InstructionUIController)LuaObject.checkSelf(l);
			instructionUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FA1D RID: 129565 RVA: 0x00A683C4 File Offset: 0x00A665C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			InstructionUIController instructionUIController = (InstructionUIController)LuaObject.checkSelf(l);
			instructionUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FA1E RID: 129566 RVA: 0x00A68418 File Offset: 0x00A66618
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			InstructionUIController instructionUIController = (InstructionUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = instructionUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601FA1F RID: 129567 RVA: 0x00A684C0 File Offset: 0x00A666C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			InstructionUIController instructionUIController = (InstructionUIController)LuaObject.checkSelf(l);
			instructionUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FA20 RID: 129568 RVA: 0x00A68514 File Offset: 0x00A66714
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			InstructionUIController instructionUIController = (InstructionUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			instructionUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FA21 RID: 129569 RVA: 0x00A68580 File Offset: 0x00A66780
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
				InstructionUIController instructionUIController = (InstructionUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				instructionUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				InstructionUIController instructionUIController2 = (InstructionUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				instructionUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601FA22 RID: 129570 RVA: 0x00A68690 File Offset: 0x00A66890
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			InstructionUIController instructionUIController = (InstructionUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			instructionUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FA23 RID: 129571 RVA: 0x00A686FC File Offset: 0x00A668FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			InstructionUIController instructionUIController = (InstructionUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			instructionUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FA24 RID: 129572 RVA: 0x00A68768 File Offset: 0x00A66968
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			InstructionUIController instructionUIController = (InstructionUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			instructionUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FA25 RID: 129573 RVA: 0x00A687D4 File Offset: 0x00A669D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			InstructionUIController instructionUIController = (InstructionUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			instructionUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FA26 RID: 129574 RVA: 0x00A68840 File Offset: 0x00A66A40
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
				InstructionUIController instructionUIController = (InstructionUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				instructionUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				InstructionUIController instructionUIController2 = (InstructionUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				instructionUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601FA27 RID: 129575 RVA: 0x00A68950 File Offset: 0x00A66B50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			InstructionUIController instructionUIController = (InstructionUIController)LuaObject.checkSelf(l);
			string s = instructionUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601FA28 RID: 129576 RVA: 0x00A689AC File Offset: 0x00A66BAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			InstructionUIController instructionUIController = (InstructionUIController)LuaObject.checkSelf(l);
			instructionUIController.m_luaExportHelper.__callDele_EventOnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FA29 RID: 129577 RVA: 0x00A68A00 File Offset: 0x00A66C00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			InstructionUIController instructionUIController = (InstructionUIController)LuaObject.checkSelf(l);
			instructionUIController.m_luaExportHelper.__clearDele_EventOnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FA2A RID: 129578 RVA: 0x00A68A54 File Offset: 0x00A66C54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			InstructionUIController instructionUIController = (InstructionUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					instructionUIController.EventOnClose += value;
				}
				else if (num == 2)
				{
					instructionUIController.EventOnClose -= value;
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

	// Token: 0x0601FA2B RID: 129579 RVA: 0x00A68AD4 File Offset: 0x00A66CD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiStateController(IntPtr l)
	{
		int result;
		try
		{
			InstructionUIController instructionUIController = (InstructionUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, instructionUIController.m_luaExportHelper.m_uiStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FA2C RID: 129580 RVA: 0x00A68B2C File Offset: 0x00A66D2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiStateController(IntPtr l)
	{
		int result;
		try
		{
			InstructionUIController instructionUIController = (InstructionUIController)LuaObject.checkSelf(l);
			CommonUIStateController uiStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out uiStateController);
			instructionUIController.m_luaExportHelper.m_uiStateController = uiStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FA2D RID: 129581 RVA: 0x00A68B88 File Offset: 0x00A66D88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_backgroundButton(IntPtr l)
	{
		int result;
		try
		{
			InstructionUIController instructionUIController = (InstructionUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, instructionUIController.m_luaExportHelper.m_backgroundButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FA2E RID: 129582 RVA: 0x00A68BE0 File Offset: 0x00A66DE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_backgroundButton(IntPtr l)
	{
		int result;
		try
		{
			InstructionUIController instructionUIController = (InstructionUIController)LuaObject.checkSelf(l);
			Button backgroundButton;
			LuaObject.checkType<Button>(l, 2, out backgroundButton);
			instructionUIController.m_luaExportHelper.m_backgroundButton = backgroundButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FA2F RID: 129583 RVA: 0x00A68C3C File Offset: 0x00A66E3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_panelGameObject(IntPtr l)
	{
		int result;
		try
		{
			InstructionUIController instructionUIController = (InstructionUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, instructionUIController.m_luaExportHelper.m_panelGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FA30 RID: 129584 RVA: 0x00A68C94 File Offset: 0x00A66E94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_panelGameObject(IntPtr l)
	{
		int result;
		try
		{
			InstructionUIController instructionUIController = (InstructionUIController)LuaObject.checkSelf(l);
			GameObject panelGameObject;
			LuaObject.checkType<GameObject>(l, 2, out panelGameObject);
			instructionUIController.m_luaExportHelper.m_panelGameObject = panelGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FA31 RID: 129585 RVA: 0x00A68CF0 File Offset: 0x00A66EF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isOpened(IntPtr l)
	{
		int result;
		try
		{
			InstructionUIController instructionUIController = (InstructionUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, instructionUIController.m_luaExportHelper.m_isOpened);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FA32 RID: 129586 RVA: 0x00A68D48 File Offset: 0x00A66F48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isOpened(IntPtr l)
	{
		int result;
		try
		{
			InstructionUIController instructionUIController = (InstructionUIController)LuaObject.checkSelf(l);
			bool isOpened;
			LuaObject.checkType(l, 2, out isOpened);
			instructionUIController.m_luaExportHelper.m_isOpened = isOpened;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FA33 RID: 129587 RVA: 0x00A68DA4 File Offset: 0x00A66FA4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.InstructionUIController");
		if (Lua_BlackJack_ProjectL_UI_InstructionUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_InstructionUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InstructionUIController.Show);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_InstructionUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_InstructionUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_InstructionUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InstructionUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_InstructionUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_InstructionUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_InstructionUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InstructionUIController.Close);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_InstructionUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_InstructionUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_InstructionUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InstructionUIController.OnBackgroundButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_InstructionUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_InstructionUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_InstructionUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InstructionUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_InstructionUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_InstructionUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_InstructionUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InstructionUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_InstructionUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_InstructionUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_InstructionUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InstructionUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_InstructionUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_InstructionUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_InstructionUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InstructionUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_InstructionUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_InstructionUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_InstructionUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InstructionUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_InstructionUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_InstructionUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_InstructionUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InstructionUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_InstructionUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_InstructionUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_InstructionUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InstructionUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_InstructionUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_InstructionUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_InstructionUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InstructionUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_InstructionUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_InstructionUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_InstructionUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InstructionUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_InstructionUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_InstructionUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_InstructionUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InstructionUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_InstructionUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_InstructionUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_InstructionUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InstructionUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_InstructionUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_InstructionUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_InstructionUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InstructionUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_InstructionUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_InstructionUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_InstructionUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InstructionUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_InstructionUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_InstructionUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_InstructionUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InstructionUIController.__callDele_EventOnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_InstructionUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_InstructionUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_InstructionUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InstructionUIController.__clearDele_EventOnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_InstructionUIController.<>f__mg$cache12);
		string name = "EventOnClose";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_InstructionUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_InstructionUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InstructionUIController.set_EventOnClose);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_InstructionUIController.<>f__mg$cache13, true);
		string name2 = "m_uiStateController";
		if (Lua_BlackJack_ProjectL_UI_InstructionUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_InstructionUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InstructionUIController.get_m_uiStateController);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_InstructionUIController.<>f__mg$cache14;
		if (Lua_BlackJack_ProjectL_UI_InstructionUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_InstructionUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InstructionUIController.set_m_uiStateController);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_InstructionUIController.<>f__mg$cache15, true);
		string name3 = "m_backgroundButton";
		if (Lua_BlackJack_ProjectL_UI_InstructionUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_InstructionUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InstructionUIController.get_m_backgroundButton);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_InstructionUIController.<>f__mg$cache16;
		if (Lua_BlackJack_ProjectL_UI_InstructionUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_InstructionUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InstructionUIController.set_m_backgroundButton);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_InstructionUIController.<>f__mg$cache17, true);
		string name4 = "m_panelGameObject";
		if (Lua_BlackJack_ProjectL_UI_InstructionUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_InstructionUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InstructionUIController.get_m_panelGameObject);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_InstructionUIController.<>f__mg$cache18;
		if (Lua_BlackJack_ProjectL_UI_InstructionUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_InstructionUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InstructionUIController.set_m_panelGameObject);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_InstructionUIController.<>f__mg$cache19, true);
		string name5 = "m_isOpened";
		if (Lua_BlackJack_ProjectL_UI_InstructionUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_InstructionUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InstructionUIController.get_m_isOpened);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_InstructionUIController.<>f__mg$cache1A;
		if (Lua_BlackJack_ProjectL_UI_InstructionUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_InstructionUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InstructionUIController.set_m_isOpened);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_InstructionUIController.<>f__mg$cache1B, true);
		LuaObject.createTypeMetatable(l, null, typeof(InstructionUIController), typeof(UIControllerBase));
	}

	// Token: 0x04015A1B RID: 88603
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04015A1C RID: 88604
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04015A1D RID: 88605
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04015A1E RID: 88606
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04015A1F RID: 88607
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04015A20 RID: 88608
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04015A21 RID: 88609
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04015A22 RID: 88610
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04015A23 RID: 88611
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04015A24 RID: 88612
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04015A25 RID: 88613
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04015A26 RID: 88614
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04015A27 RID: 88615
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04015A28 RID: 88616
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04015A29 RID: 88617
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04015A2A RID: 88618
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04015A2B RID: 88619
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04015A2C RID: 88620
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04015A2D RID: 88621
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04015A2E RID: 88622
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04015A2F RID: 88623
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04015A30 RID: 88624
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04015A31 RID: 88625
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04015A32 RID: 88626
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04015A33 RID: 88627
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04015A34 RID: 88628
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04015A35 RID: 88629
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04015A36 RID: 88630
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;
}
