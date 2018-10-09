using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x020015AB RID: 5547
[Preserve]
public class Lua_BlackJack_ProjectL_UI_TestListItemUIController : LuaObject
{
	// Token: 0x060219D3 RID: 137683 RVA: 0x00B64DD8 File Offset: 0x00B62FD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Init(IntPtr l)
	{
		int result;
		try
		{
			TestListItemUIController testListItemUIController = (TestListItemUIController)LuaObject.checkSelf(l);
			Action<UIControllerBase> clickEvent;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 2, out clickEvent);
			Action<UIControllerBase> fillEvent;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out fillEvent);
			testListItemUIController.Init(clickEvent, fillEvent);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060219D4 RID: 137684 RVA: 0x00B64E3C File Offset: 0x00B6303C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetId(IntPtr l)
	{
		int result;
		try
		{
			TestListItemUIController testListItemUIController = (TestListItemUIController)LuaObject.checkSelf(l);
			int id;
			LuaObject.checkType(l, 2, out id);
			testListItemUIController.SetId(id);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060219D5 RID: 137685 RVA: 0x00B64E94 File Offset: 0x00B63094
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetId(IntPtr l)
	{
		int result;
		try
		{
			TestListItemUIController testListItemUIController = (TestListItemUIController)LuaObject.checkSelf(l);
			int id = testListItemUIController.GetId();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, id);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060219D6 RID: 137686 RVA: 0x00B64EE8 File Offset: 0x00B630E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetName(IntPtr l)
	{
		int result;
		try
		{
			TestListItemUIController testListItemUIController = (TestListItemUIController)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			testListItemUIController.SetName(name);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060219D7 RID: 137687 RVA: 0x00B64F40 File Offset: 0x00B63140
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetSelected(IntPtr l)
	{
		int result;
		try
		{
			TestListItemUIController testListItemUIController = (TestListItemUIController)LuaObject.checkSelf(l);
			bool selected;
			LuaObject.checkType(l, 2, out selected);
			testListItemUIController.SetSelected(selected);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060219D8 RID: 137688 RVA: 0x00B64F98 File Offset: 0x00B63198
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsSelected(IntPtr l)
	{
		int result;
		try
		{
			TestListItemUIController testListItemUIController = (TestListItemUIController)LuaObject.checkSelf(l);
			bool b = testListItemUIController.IsSelected();
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

	// Token: 0x060219D9 RID: 137689 RVA: 0x00B64FEC File Offset: 0x00B631EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnClick(IntPtr l)
	{
		int result;
		try
		{
			TestListItemUIController testListItemUIController = (TestListItemUIController)LuaObject.checkSelf(l);
			UnityAction action;
			LuaObject.checkDelegate<UnityAction>(l, 2, out action);
			testListItemUIController.OnClick(action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060219DA RID: 137690 RVA: 0x00B65044 File Offset: 0x00B63244
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			TestListItemUIController testListItemUIController = (TestListItemUIController)LuaObject.checkSelf(l);
			testListItemUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060219DB RID: 137691 RVA: 0x00B65098 File Offset: 0x00B63298
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			TestListItemUIController testListItemUIController = (TestListItemUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			testListItemUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060219DC RID: 137692 RVA: 0x00B65104 File Offset: 0x00B63304
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			TestListItemUIController testListItemUIController = (TestListItemUIController)LuaObject.checkSelf(l);
			testListItemUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060219DD RID: 137693 RVA: 0x00B65158 File Offset: 0x00B63358
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			TestListItemUIController testListItemUIController = (TestListItemUIController)LuaObject.checkSelf(l);
			testListItemUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060219DE RID: 137694 RVA: 0x00B651AC File Offset: 0x00B633AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			TestListItemUIController testListItemUIController = (TestListItemUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = testListItemUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x060219DF RID: 137695 RVA: 0x00B65254 File Offset: 0x00B63454
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			TestListItemUIController testListItemUIController = (TestListItemUIController)LuaObject.checkSelf(l);
			testListItemUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060219E0 RID: 137696 RVA: 0x00B652A8 File Offset: 0x00B634A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			TestListItemUIController testListItemUIController = (TestListItemUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			testListItemUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060219E1 RID: 137697 RVA: 0x00B65314 File Offset: 0x00B63514
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
				TestListItemUIController testListItemUIController = (TestListItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				testListItemUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				TestListItemUIController testListItemUIController2 = (TestListItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				testListItemUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x060219E2 RID: 137698 RVA: 0x00B65424 File Offset: 0x00B63624
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			TestListItemUIController testListItemUIController = (TestListItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			testListItemUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060219E3 RID: 137699 RVA: 0x00B65490 File Offset: 0x00B63690
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			TestListItemUIController testListItemUIController = (TestListItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			testListItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060219E4 RID: 137700 RVA: 0x00B654FC File Offset: 0x00B636FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			TestListItemUIController testListItemUIController = (TestListItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			testListItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060219E5 RID: 137701 RVA: 0x00B65568 File Offset: 0x00B63768
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			TestListItemUIController testListItemUIController = (TestListItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			testListItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060219E6 RID: 137702 RVA: 0x00B655D4 File Offset: 0x00B637D4
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
				TestListItemUIController testListItemUIController = (TestListItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				testListItemUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				TestListItemUIController testListItemUIController2 = (TestListItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				testListItemUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x060219E7 RID: 137703 RVA: 0x00B656E4 File Offset: 0x00B638E4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			TestListItemUIController testListItemUIController = (TestListItemUIController)LuaObject.checkSelf(l);
			string s = testListItemUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x060219E8 RID: 137704 RVA: 0x00B65740 File Offset: 0x00B63940
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_nameText(IntPtr l)
	{
		int result;
		try
		{
			TestListItemUIController testListItemUIController = (TestListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, testListItemUIController.m_luaExportHelper.m_nameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060219E9 RID: 137705 RVA: 0x00B65798 File Offset: 0x00B63998
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_nameText(IntPtr l)
	{
		int result;
		try
		{
			TestListItemUIController testListItemUIController = (TestListItemUIController)LuaObject.checkSelf(l);
			Text nameText;
			LuaObject.checkType<Text>(l, 2, out nameText);
			testListItemUIController.m_luaExportHelper.m_nameText = nameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060219EA RID: 137706 RVA: 0x00B657F4 File Offset: 0x00B639F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_selectedGameObject(IntPtr l)
	{
		int result;
		try
		{
			TestListItemUIController testListItemUIController = (TestListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, testListItemUIController.m_luaExportHelper.m_selectedGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060219EB RID: 137707 RVA: 0x00B6584C File Offset: 0x00B63A4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_selectedGameObject(IntPtr l)
	{
		int result;
		try
		{
			TestListItemUIController testListItemUIController = (TestListItemUIController)LuaObject.checkSelf(l);
			GameObject selectedGameObject;
			LuaObject.checkType<GameObject>(l, 2, out selectedGameObject);
			testListItemUIController.m_luaExportHelper.m_selectedGameObject = selectedGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060219EC RID: 137708 RVA: 0x00B658A8 File Offset: 0x00B63AA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ScrollItemBaseUICtrl(IntPtr l)
	{
		int result;
		try
		{
			TestListItemUIController testListItemUIController = (TestListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, testListItemUIController.ScrollItemBaseUICtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060219ED RID: 137709 RVA: 0x00B658FC File Offset: 0x00B63AFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ScrollItemBaseUICtrl(IntPtr l)
	{
		int result;
		try
		{
			TestListItemUIController testListItemUIController = (TestListItemUIController)LuaObject.checkSelf(l);
			ScrollItemBaseUIController scrollItemBaseUICtrl;
			LuaObject.checkType<ScrollItemBaseUIController>(l, 2, out scrollItemBaseUICtrl);
			testListItemUIController.ScrollItemBaseUICtrl = scrollItemBaseUICtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060219EE RID: 137710 RVA: 0x00B65954 File Offset: 0x00B63B54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_id(IntPtr l)
	{
		int result;
		try
		{
			TestListItemUIController testListItemUIController = (TestListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, testListItemUIController.m_luaExportHelper.m_id);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060219EF RID: 137711 RVA: 0x00B659AC File Offset: 0x00B63BAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_id(IntPtr l)
	{
		int result;
		try
		{
			TestListItemUIController testListItemUIController = (TestListItemUIController)LuaObject.checkSelf(l);
			int id;
			LuaObject.checkType(l, 2, out id);
			testListItemUIController.m_luaExportHelper.m_id = id;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060219F0 RID: 137712 RVA: 0x00B65A08 File Offset: 0x00B63C08
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.TestListItemUIController");
		if (Lua_BlackJack_ProjectL_UI_TestListItemUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestListItemUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestListItemUIController.Init);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestListItemUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_TestListItemUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestListItemUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestListItemUIController.SetId);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestListItemUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_TestListItemUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestListItemUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestListItemUIController.GetId);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestListItemUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_TestListItemUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestListItemUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestListItemUIController.SetName);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestListItemUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_TestListItemUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestListItemUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestListItemUIController.SetSelected);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestListItemUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_TestListItemUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestListItemUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestListItemUIController.IsSelected);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestListItemUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_TestListItemUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestListItemUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestListItemUIController.OnClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestListItemUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_TestListItemUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestListItemUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestListItemUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestListItemUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_TestListItemUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestListItemUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestListItemUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestListItemUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_TestListItemUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestListItemUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestListItemUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestListItemUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_TestListItemUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_TestListItemUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestListItemUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestListItemUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_TestListItemUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_TestListItemUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestListItemUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestListItemUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_TestListItemUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_TestListItemUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestListItemUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestListItemUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_TestListItemUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_TestListItemUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestListItemUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestListItemUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_TestListItemUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_TestListItemUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestListItemUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestListItemUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_TestListItemUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_TestListItemUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestListItemUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestListItemUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_TestListItemUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestListItemUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestListItemUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestListItemUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_TestListItemUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestListItemUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestListItemUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestListItemUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_TestListItemUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestListItemUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestListItemUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestListItemUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_TestListItemUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestListItemUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestListItemUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestListItemUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_TestListItemUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestListItemUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestListItemUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestListItemUIController.<>f__mg$cache14);
		string name = "m_nameText";
		if (Lua_BlackJack_ProjectL_UI_TestListItemUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestListItemUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestListItemUIController.get_m_nameText);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_TestListItemUIController.<>f__mg$cache15;
		if (Lua_BlackJack_ProjectL_UI_TestListItemUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestListItemUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestListItemUIController.set_m_nameText);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_TestListItemUIController.<>f__mg$cache16, true);
		string name2 = "m_selectedGameObject";
		if (Lua_BlackJack_ProjectL_UI_TestListItemUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestListItemUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestListItemUIController.get_m_selectedGameObject);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_TestListItemUIController.<>f__mg$cache17;
		if (Lua_BlackJack_ProjectL_UI_TestListItemUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestListItemUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestListItemUIController.set_m_selectedGameObject);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_TestListItemUIController.<>f__mg$cache18, true);
		string name3 = "ScrollItemBaseUICtrl";
		if (Lua_BlackJack_ProjectL_UI_TestListItemUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestListItemUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestListItemUIController.get_ScrollItemBaseUICtrl);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_TestListItemUIController.<>f__mg$cache19;
		if (Lua_BlackJack_ProjectL_UI_TestListItemUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_TestListItemUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestListItemUIController.set_ScrollItemBaseUICtrl);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_TestListItemUIController.<>f__mg$cache1A, true);
		string name4 = "m_id";
		if (Lua_BlackJack_ProjectL_UI_TestListItemUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_TestListItemUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestListItemUIController.get_m_id);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_TestListItemUIController.<>f__mg$cache1B;
		if (Lua_BlackJack_ProjectL_UI_TestListItemUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_TestListItemUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestListItemUIController.set_m_id);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_TestListItemUIController.<>f__mg$cache1C, true);
		LuaObject.createTypeMetatable(l, null, typeof(TestListItemUIController), typeof(UIControllerBase));
	}

	// Token: 0x0401785F RID: 96351
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04017860 RID: 96352
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04017861 RID: 96353
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04017862 RID: 96354
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04017863 RID: 96355
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04017864 RID: 96356
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04017865 RID: 96357
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04017866 RID: 96358
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04017867 RID: 96359
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04017868 RID: 96360
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04017869 RID: 96361
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0401786A RID: 96362
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0401786B RID: 96363
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0401786C RID: 96364
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0401786D RID: 96365
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0401786E RID: 96366
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0401786F RID: 96367
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04017870 RID: 96368
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04017871 RID: 96369
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04017872 RID: 96370
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04017873 RID: 96371
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04017874 RID: 96372
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04017875 RID: 96373
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04017876 RID: 96374
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04017877 RID: 96375
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04017878 RID: 96376
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04017879 RID: 96377
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0401787A RID: 96378
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0401787B RID: 96379
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;
}
