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

// Token: 0x02001562 RID: 5474
[Preserve]
public class Lua_BlackJack_ProjectL_UI_RiftChapterUnlockConditionItemUIController : LuaObject
{
	// Token: 0x06020C5C RID: 134236 RVA: 0x00AF9244 File Offset: 0x00AF7444
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetCondition(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterUnlockConditionItemUIController riftChapterUnlockConditionItemUIController = (RiftChapterUnlockConditionItemUIController)LuaObject.checkSelf(l);
			RiftChapterUnlockConditionType condition;
			LuaObject.checkEnum<RiftChapterUnlockConditionType>(l, 2, out condition);
			int param;
			LuaObject.checkType(l, 3, out param);
			riftChapterUnlockConditionItemUIController.SetCondition(condition, param);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020C5D RID: 134237 RVA: 0x00AF92A8 File Offset: 0x00AF74A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GoScenario(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterUnlockConditionItemUIController riftChapterUnlockConditionItemUIController = (RiftChapterUnlockConditionItemUIController)LuaObject.checkSelf(l);
			riftChapterUnlockConditionItemUIController.m_luaExportHelper.GoScenario();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020C5E RID: 134238 RVA: 0x00AF92FC File Offset: 0x00AF74FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterUnlockConditionItemUIController riftChapterUnlockConditionItemUIController = (RiftChapterUnlockConditionItemUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			riftChapterUnlockConditionItemUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020C5F RID: 134239 RVA: 0x00AF9368 File Offset: 0x00AF7568
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterUnlockConditionItemUIController riftChapterUnlockConditionItemUIController = (RiftChapterUnlockConditionItemUIController)LuaObject.checkSelf(l);
			riftChapterUnlockConditionItemUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020C60 RID: 134240 RVA: 0x00AF93BC File Offset: 0x00AF75BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterUnlockConditionItemUIController riftChapterUnlockConditionItemUIController = (RiftChapterUnlockConditionItemUIController)LuaObject.checkSelf(l);
			riftChapterUnlockConditionItemUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020C61 RID: 134241 RVA: 0x00AF9410 File Offset: 0x00AF7610
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterUnlockConditionItemUIController riftChapterUnlockConditionItemUIController = (RiftChapterUnlockConditionItemUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = riftChapterUnlockConditionItemUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x06020C62 RID: 134242 RVA: 0x00AF94B8 File Offset: 0x00AF76B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterUnlockConditionItemUIController riftChapterUnlockConditionItemUIController = (RiftChapterUnlockConditionItemUIController)LuaObject.checkSelf(l);
			riftChapterUnlockConditionItemUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020C63 RID: 134243 RVA: 0x00AF950C File Offset: 0x00AF770C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterUnlockConditionItemUIController riftChapterUnlockConditionItemUIController = (RiftChapterUnlockConditionItemUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			riftChapterUnlockConditionItemUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020C64 RID: 134244 RVA: 0x00AF9578 File Offset: 0x00AF7778
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
				RiftChapterUnlockConditionItemUIController riftChapterUnlockConditionItemUIController = (RiftChapterUnlockConditionItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				riftChapterUnlockConditionItemUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				RiftChapterUnlockConditionItemUIController riftChapterUnlockConditionItemUIController2 = (RiftChapterUnlockConditionItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				riftChapterUnlockConditionItemUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x06020C65 RID: 134245 RVA: 0x00AF9688 File Offset: 0x00AF7888
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterUnlockConditionItemUIController riftChapterUnlockConditionItemUIController = (RiftChapterUnlockConditionItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			riftChapterUnlockConditionItemUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020C66 RID: 134246 RVA: 0x00AF96F4 File Offset: 0x00AF78F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterUnlockConditionItemUIController riftChapterUnlockConditionItemUIController = (RiftChapterUnlockConditionItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			riftChapterUnlockConditionItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020C67 RID: 134247 RVA: 0x00AF9760 File Offset: 0x00AF7960
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterUnlockConditionItemUIController riftChapterUnlockConditionItemUIController = (RiftChapterUnlockConditionItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			riftChapterUnlockConditionItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020C68 RID: 134248 RVA: 0x00AF97CC File Offset: 0x00AF79CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterUnlockConditionItemUIController riftChapterUnlockConditionItemUIController = (RiftChapterUnlockConditionItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			riftChapterUnlockConditionItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020C69 RID: 134249 RVA: 0x00AF9838 File Offset: 0x00AF7A38
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
				RiftChapterUnlockConditionItemUIController riftChapterUnlockConditionItemUIController = (RiftChapterUnlockConditionItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				riftChapterUnlockConditionItemUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				RiftChapterUnlockConditionItemUIController riftChapterUnlockConditionItemUIController2 = (RiftChapterUnlockConditionItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				riftChapterUnlockConditionItemUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x06020C6A RID: 134250 RVA: 0x00AF9948 File Offset: 0x00AF7B48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterUnlockConditionItemUIController riftChapterUnlockConditionItemUIController = (RiftChapterUnlockConditionItemUIController)LuaObject.checkSelf(l);
			string s = riftChapterUnlockConditionItemUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x06020C6B RID: 134251 RVA: 0x00AF99A4 File Offset: 0x00AF7BA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnGoToScenario(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterUnlockConditionItemUIController riftChapterUnlockConditionItemUIController = (RiftChapterUnlockConditionItemUIController)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			riftChapterUnlockConditionItemUIController.m_luaExportHelper.__callDele_EventOnGoToScenario(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020C6C RID: 134252 RVA: 0x00AF9A00 File Offset: 0x00AF7C00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnGoToScenario(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterUnlockConditionItemUIController riftChapterUnlockConditionItemUIController = (RiftChapterUnlockConditionItemUIController)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			riftChapterUnlockConditionItemUIController.m_luaExportHelper.__clearDele_EventOnGoToScenario(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020C6D RID: 134253 RVA: 0x00AF9A5C File Offset: 0x00AF7C5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_text(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterUnlockConditionItemUIController riftChapterUnlockConditionItemUIController = (RiftChapterUnlockConditionItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, riftChapterUnlockConditionItemUIController.m_luaExportHelper.m_text);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020C6E RID: 134254 RVA: 0x00AF9AB4 File Offset: 0x00AF7CB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_text(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterUnlockConditionItemUIController riftChapterUnlockConditionItemUIController = (RiftChapterUnlockConditionItemUIController)LuaObject.checkSelf(l);
			Text text;
			LuaObject.checkType<Text>(l, 2, out text);
			riftChapterUnlockConditionItemUIController.m_luaExportHelper.m_text = text;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020C6F RID: 134255 RVA: 0x00AF9B10 File Offset: 0x00AF7D10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_goButton(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterUnlockConditionItemUIController riftChapterUnlockConditionItemUIController = (RiftChapterUnlockConditionItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, riftChapterUnlockConditionItemUIController.m_luaExportHelper.m_goButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020C70 RID: 134256 RVA: 0x00AF9B68 File Offset: 0x00AF7D68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_goButton(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterUnlockConditionItemUIController riftChapterUnlockConditionItemUIController = (RiftChapterUnlockConditionItemUIController)LuaObject.checkSelf(l);
			Button goButton;
			LuaObject.checkType<Button>(l, 2, out goButton);
			riftChapterUnlockConditionItemUIController.m_luaExportHelper.m_goButton = goButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020C71 RID: 134257 RVA: 0x00AF9BC4 File Offset: 0x00AF7DC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_scenarioID(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterUnlockConditionItemUIController riftChapterUnlockConditionItemUIController = (RiftChapterUnlockConditionItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, riftChapterUnlockConditionItemUIController.m_luaExportHelper.m_scenarioID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020C72 RID: 134258 RVA: 0x00AF9C1C File Offset: 0x00AF7E1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_scenarioID(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterUnlockConditionItemUIController riftChapterUnlockConditionItemUIController = (RiftChapterUnlockConditionItemUIController)LuaObject.checkSelf(l);
			int scenarioID;
			LuaObject.checkType(l, 2, out scenarioID);
			riftChapterUnlockConditionItemUIController.m_luaExportHelper.m_scenarioID = scenarioID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020C73 RID: 134259 RVA: 0x00AF9C78 File Offset: 0x00AF7E78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnGoToScenario(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterUnlockConditionItemUIController riftChapterUnlockConditionItemUIController = (RiftChapterUnlockConditionItemUIController)LuaObject.checkSelf(l);
			Action<int> value;
			int num = LuaObject.checkDelegate<Action<int>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					riftChapterUnlockConditionItemUIController.EventOnGoToScenario += value;
				}
				else if (num == 2)
				{
					riftChapterUnlockConditionItemUIController.EventOnGoToScenario -= value;
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

	// Token: 0x06020C74 RID: 134260 RVA: 0x00AF9CF8 File Offset: 0x00AF7EF8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.RiftChapterUnlockConditionItemUIController");
		if (Lua_BlackJack_ProjectL_UI_RiftChapterUnlockConditionItemUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterUnlockConditionItemUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterUnlockConditionItemUIController.SetCondition);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftChapterUnlockConditionItemUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_RiftChapterUnlockConditionItemUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterUnlockConditionItemUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterUnlockConditionItemUIController.GoScenario);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftChapterUnlockConditionItemUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_RiftChapterUnlockConditionItemUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterUnlockConditionItemUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterUnlockConditionItemUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftChapterUnlockConditionItemUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_RiftChapterUnlockConditionItemUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterUnlockConditionItemUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterUnlockConditionItemUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftChapterUnlockConditionItemUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_RiftChapterUnlockConditionItemUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterUnlockConditionItemUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterUnlockConditionItemUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftChapterUnlockConditionItemUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_RiftChapterUnlockConditionItemUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterUnlockConditionItemUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterUnlockConditionItemUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftChapterUnlockConditionItemUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_RiftChapterUnlockConditionItemUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterUnlockConditionItemUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterUnlockConditionItemUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftChapterUnlockConditionItemUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_RiftChapterUnlockConditionItemUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterUnlockConditionItemUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterUnlockConditionItemUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftChapterUnlockConditionItemUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_RiftChapterUnlockConditionItemUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterUnlockConditionItemUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterUnlockConditionItemUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftChapterUnlockConditionItemUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_RiftChapterUnlockConditionItemUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterUnlockConditionItemUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterUnlockConditionItemUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftChapterUnlockConditionItemUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_RiftChapterUnlockConditionItemUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterUnlockConditionItemUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterUnlockConditionItemUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftChapterUnlockConditionItemUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_RiftChapterUnlockConditionItemUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterUnlockConditionItemUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterUnlockConditionItemUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftChapterUnlockConditionItemUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_RiftChapterUnlockConditionItemUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterUnlockConditionItemUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterUnlockConditionItemUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftChapterUnlockConditionItemUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_RiftChapterUnlockConditionItemUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterUnlockConditionItemUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterUnlockConditionItemUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftChapterUnlockConditionItemUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_RiftChapterUnlockConditionItemUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterUnlockConditionItemUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterUnlockConditionItemUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftChapterUnlockConditionItemUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_RiftChapterUnlockConditionItemUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterUnlockConditionItemUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterUnlockConditionItemUIController.__callDele_EventOnGoToScenario);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftChapterUnlockConditionItemUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_RiftChapterUnlockConditionItemUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterUnlockConditionItemUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterUnlockConditionItemUIController.__clearDele_EventOnGoToScenario);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftChapterUnlockConditionItemUIController.<>f__mg$cache10);
		string name = "m_text";
		if (Lua_BlackJack_ProjectL_UI_RiftChapterUnlockConditionItemUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterUnlockConditionItemUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterUnlockConditionItemUIController.get_m_text);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_RiftChapterUnlockConditionItemUIController.<>f__mg$cache11;
		if (Lua_BlackJack_ProjectL_UI_RiftChapterUnlockConditionItemUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterUnlockConditionItemUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterUnlockConditionItemUIController.set_m_text);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_RiftChapterUnlockConditionItemUIController.<>f__mg$cache12, true);
		string name2 = "m_goButton";
		if (Lua_BlackJack_ProjectL_UI_RiftChapterUnlockConditionItemUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterUnlockConditionItemUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterUnlockConditionItemUIController.get_m_goButton);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_RiftChapterUnlockConditionItemUIController.<>f__mg$cache13;
		if (Lua_BlackJack_ProjectL_UI_RiftChapterUnlockConditionItemUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterUnlockConditionItemUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterUnlockConditionItemUIController.set_m_goButton);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_RiftChapterUnlockConditionItemUIController.<>f__mg$cache14, true);
		string name3 = "m_scenarioID";
		if (Lua_BlackJack_ProjectL_UI_RiftChapterUnlockConditionItemUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterUnlockConditionItemUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterUnlockConditionItemUIController.get_m_scenarioID);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_RiftChapterUnlockConditionItemUIController.<>f__mg$cache15;
		if (Lua_BlackJack_ProjectL_UI_RiftChapterUnlockConditionItemUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterUnlockConditionItemUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterUnlockConditionItemUIController.set_m_scenarioID);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_RiftChapterUnlockConditionItemUIController.<>f__mg$cache16, true);
		string name4 = "EventOnGoToScenario";
		LuaCSFunction get4 = null;
		if (Lua_BlackJack_ProjectL_UI_RiftChapterUnlockConditionItemUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterUnlockConditionItemUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterUnlockConditionItemUIController.set_EventOnGoToScenario);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_RiftChapterUnlockConditionItemUIController.<>f__mg$cache17, true);
		LuaObject.createTypeMetatable(l, null, typeof(RiftChapterUnlockConditionItemUIController), typeof(UIControllerBase));
	}

	// Token: 0x04016B7A RID: 93050
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04016B7B RID: 93051
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04016B7C RID: 93052
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04016B7D RID: 93053
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04016B7E RID: 93054
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04016B7F RID: 93055
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04016B80 RID: 93056
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04016B81 RID: 93057
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04016B82 RID: 93058
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04016B83 RID: 93059
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04016B84 RID: 93060
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04016B85 RID: 93061
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04016B86 RID: 93062
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04016B87 RID: 93063
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04016B88 RID: 93064
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04016B89 RID: 93065
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04016B8A RID: 93066
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04016B8B RID: 93067
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04016B8C RID: 93068
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04016B8D RID: 93069
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04016B8E RID: 93070
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04016B8F RID: 93071
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04016B90 RID: 93072
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04016B91 RID: 93073
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;
}
