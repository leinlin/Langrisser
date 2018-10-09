using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x020013DA RID: 5082
[Preserve]
public class Lua_BlackJack_ProjectL_UI_BusinessCardOftenUsedHeroItemController : LuaObject
{
	// Token: 0x0601C6CF RID: 116431 RVA: 0x008D04C8 File Offset: 0x008CE6C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateItemInfo(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardOftenUsedHeroItemController businessCardOftenUsedHeroItemController = (BusinessCardOftenUsedHeroItemController)LuaObject.checkSelf(l);
			string headIconName;
			LuaObject.checkType(l, 2, out headIconName);
			int heroId;
			LuaObject.checkType(l, 3, out heroId);
			businessCardOftenUsedHeroItemController.UpdateItemInfo(headIconName, heroId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C6D0 RID: 116432 RVA: 0x008D052C File Offset: 0x008CE72C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardOftenUsedHeroItemController businessCardOftenUsedHeroItemController = (BusinessCardOftenUsedHeroItemController)LuaObject.checkSelf(l);
			businessCardOftenUsedHeroItemController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C6D1 RID: 116433 RVA: 0x008D0580 File Offset: 0x008CE780
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardOftenUsedHeroItemController businessCardOftenUsedHeroItemController = (BusinessCardOftenUsedHeroItemController)LuaObject.checkSelf(l);
			businessCardOftenUsedHeroItemController.m_luaExportHelper.OnButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C6D2 RID: 116434 RVA: 0x008D05D4 File Offset: 0x008CE7D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardOftenUsedHeroItemController businessCardOftenUsedHeroItemController = (BusinessCardOftenUsedHeroItemController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			businessCardOftenUsedHeroItemController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C6D3 RID: 116435 RVA: 0x008D0640 File Offset: 0x008CE840
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardOftenUsedHeroItemController businessCardOftenUsedHeroItemController = (BusinessCardOftenUsedHeroItemController)LuaObject.checkSelf(l);
			businessCardOftenUsedHeroItemController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C6D4 RID: 116436 RVA: 0x008D0694 File Offset: 0x008CE894
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardOftenUsedHeroItemController businessCardOftenUsedHeroItemController = (BusinessCardOftenUsedHeroItemController)LuaObject.checkSelf(l);
			businessCardOftenUsedHeroItemController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C6D5 RID: 116437 RVA: 0x008D06E8 File Offset: 0x008CE8E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardOftenUsedHeroItemController businessCardOftenUsedHeroItemController = (BusinessCardOftenUsedHeroItemController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = businessCardOftenUsedHeroItemController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601C6D6 RID: 116438 RVA: 0x008D0790 File Offset: 0x008CE990
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardOftenUsedHeroItemController businessCardOftenUsedHeroItemController = (BusinessCardOftenUsedHeroItemController)LuaObject.checkSelf(l);
			businessCardOftenUsedHeroItemController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C6D7 RID: 116439 RVA: 0x008D07E4 File Offset: 0x008CE9E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardOftenUsedHeroItemController businessCardOftenUsedHeroItemController = (BusinessCardOftenUsedHeroItemController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			businessCardOftenUsedHeroItemController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C6D8 RID: 116440 RVA: 0x008D0850 File Offset: 0x008CEA50
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
				BusinessCardOftenUsedHeroItemController businessCardOftenUsedHeroItemController = (BusinessCardOftenUsedHeroItemController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				businessCardOftenUsedHeroItemController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				BusinessCardOftenUsedHeroItemController businessCardOftenUsedHeroItemController2 = (BusinessCardOftenUsedHeroItemController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				businessCardOftenUsedHeroItemController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601C6D9 RID: 116441 RVA: 0x008D0960 File Offset: 0x008CEB60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardOftenUsedHeroItemController businessCardOftenUsedHeroItemController = (BusinessCardOftenUsedHeroItemController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			businessCardOftenUsedHeroItemController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C6DA RID: 116442 RVA: 0x008D09CC File Offset: 0x008CEBCC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardOftenUsedHeroItemController businessCardOftenUsedHeroItemController = (BusinessCardOftenUsedHeroItemController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			businessCardOftenUsedHeroItemController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C6DB RID: 116443 RVA: 0x008D0A38 File Offset: 0x008CEC38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardOftenUsedHeroItemController businessCardOftenUsedHeroItemController = (BusinessCardOftenUsedHeroItemController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			businessCardOftenUsedHeroItemController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C6DC RID: 116444 RVA: 0x008D0AA4 File Offset: 0x008CECA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardOftenUsedHeroItemController businessCardOftenUsedHeroItemController = (BusinessCardOftenUsedHeroItemController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			businessCardOftenUsedHeroItemController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C6DD RID: 116445 RVA: 0x008D0B10 File Offset: 0x008CED10
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
				BusinessCardOftenUsedHeroItemController businessCardOftenUsedHeroItemController = (BusinessCardOftenUsedHeroItemController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				businessCardOftenUsedHeroItemController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				BusinessCardOftenUsedHeroItemController businessCardOftenUsedHeroItemController2 = (BusinessCardOftenUsedHeroItemController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				businessCardOftenUsedHeroItemController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601C6DE RID: 116446 RVA: 0x008D0C20 File Offset: 0x008CEE20
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardOftenUsedHeroItemController businessCardOftenUsedHeroItemController = (BusinessCardOftenUsedHeroItemController)LuaObject.checkSelf(l);
			string s = businessCardOftenUsedHeroItemController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601C6DF RID: 116447 RVA: 0x008D0C7C File Offset: 0x008CEE7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnClick(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardOftenUsedHeroItemController businessCardOftenUsedHeroItemController = (BusinessCardOftenUsedHeroItemController)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			businessCardOftenUsedHeroItemController.m_luaExportHelper.__callDele_EventOnClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C6E0 RID: 116448 RVA: 0x008D0CD8 File Offset: 0x008CEED8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnClick(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardOftenUsedHeroItemController businessCardOftenUsedHeroItemController = (BusinessCardOftenUsedHeroItemController)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			businessCardOftenUsedHeroItemController.m_luaExportHelper.__clearDele_EventOnClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C6E1 RID: 116449 RVA: 0x008D0D34 File Offset: 0x008CEF34
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_button(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardOftenUsedHeroItemController businessCardOftenUsedHeroItemController = (BusinessCardOftenUsedHeroItemController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardOftenUsedHeroItemController.m_luaExportHelper.m_button);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C6E2 RID: 116450 RVA: 0x008D0D8C File Offset: 0x008CEF8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_button(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardOftenUsedHeroItemController businessCardOftenUsedHeroItemController = (BusinessCardOftenUsedHeroItemController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			businessCardOftenUsedHeroItemController.m_luaExportHelper.m_button = button;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C6E3 RID: 116451 RVA: 0x008D0DE8 File Offset: 0x008CEFE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_headIconImage(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardOftenUsedHeroItemController businessCardOftenUsedHeroItemController = (BusinessCardOftenUsedHeroItemController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardOftenUsedHeroItemController.m_luaExportHelper.m_headIconImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C6E4 RID: 116452 RVA: 0x008D0E40 File Offset: 0x008CF040
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_headIconImage(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardOftenUsedHeroItemController businessCardOftenUsedHeroItemController = (BusinessCardOftenUsedHeroItemController)LuaObject.checkSelf(l);
			Image headIconImage;
			LuaObject.checkType<Image>(l, 2, out headIconImage);
			businessCardOftenUsedHeroItemController.m_luaExportHelper.m_headIconImage = headIconImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C6E5 RID: 116453 RVA: 0x008D0E9C File Offset: 0x008CF09C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnClick(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardOftenUsedHeroItemController businessCardOftenUsedHeroItemController = (BusinessCardOftenUsedHeroItemController)LuaObject.checkSelf(l);
			Action<int> value;
			int num = LuaObject.checkDelegate<Action<int>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					businessCardOftenUsedHeroItemController.EventOnClick += value;
				}
				else if (num == 2)
				{
					businessCardOftenUsedHeroItemController.EventOnClick -= value;
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

	// Token: 0x0601C6E6 RID: 116454 RVA: 0x008D0F1C File Offset: 0x008CF11C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_HeadId(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardOftenUsedHeroItemController businessCardOftenUsedHeroItemController = (BusinessCardOftenUsedHeroItemController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardOftenUsedHeroItemController.HeadId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C6E7 RID: 116455 RVA: 0x008D0F70 File Offset: 0x008CF170
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_HeadId(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardOftenUsedHeroItemController businessCardOftenUsedHeroItemController = (BusinessCardOftenUsedHeroItemController)LuaObject.checkSelf(l);
			int headId;
			LuaObject.checkType(l, 2, out headId);
			businessCardOftenUsedHeroItemController.HeadId = headId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C6E8 RID: 116456 RVA: 0x008D0FC8 File Offset: 0x008CF1C8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.BusinessCardOftenUsedHeroItemController");
		if (Lua_BlackJack_ProjectL_UI_BusinessCardOftenUsedHeroItemController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardOftenUsedHeroItemController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardOftenUsedHeroItemController.UpdateItemInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardOftenUsedHeroItemController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardOftenUsedHeroItemController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardOftenUsedHeroItemController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardOftenUsedHeroItemController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardOftenUsedHeroItemController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardOftenUsedHeroItemController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardOftenUsedHeroItemController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardOftenUsedHeroItemController.OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardOftenUsedHeroItemController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardOftenUsedHeroItemController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardOftenUsedHeroItemController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardOftenUsedHeroItemController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardOftenUsedHeroItemController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardOftenUsedHeroItemController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardOftenUsedHeroItemController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardOftenUsedHeroItemController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardOftenUsedHeroItemController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardOftenUsedHeroItemController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardOftenUsedHeroItemController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardOftenUsedHeroItemController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardOftenUsedHeroItemController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardOftenUsedHeroItemController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardOftenUsedHeroItemController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardOftenUsedHeroItemController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardOftenUsedHeroItemController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardOftenUsedHeroItemController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardOftenUsedHeroItemController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardOftenUsedHeroItemController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardOftenUsedHeroItemController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardOftenUsedHeroItemController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardOftenUsedHeroItemController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardOftenUsedHeroItemController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardOftenUsedHeroItemController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardOftenUsedHeroItemController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardOftenUsedHeroItemController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardOftenUsedHeroItemController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardOftenUsedHeroItemController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardOftenUsedHeroItemController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardOftenUsedHeroItemController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardOftenUsedHeroItemController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardOftenUsedHeroItemController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardOftenUsedHeroItemController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardOftenUsedHeroItemController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardOftenUsedHeroItemController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardOftenUsedHeroItemController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardOftenUsedHeroItemController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardOftenUsedHeroItemController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardOftenUsedHeroItemController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardOftenUsedHeroItemController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardOftenUsedHeroItemController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardOftenUsedHeroItemController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardOftenUsedHeroItemController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardOftenUsedHeroItemController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardOftenUsedHeroItemController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardOftenUsedHeroItemController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardOftenUsedHeroItemController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardOftenUsedHeroItemController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardOftenUsedHeroItemController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardOftenUsedHeroItemController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardOftenUsedHeroItemController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardOftenUsedHeroItemController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardOftenUsedHeroItemController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardOftenUsedHeroItemController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardOftenUsedHeroItemController.__callDele_EventOnClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardOftenUsedHeroItemController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardOftenUsedHeroItemController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardOftenUsedHeroItemController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardOftenUsedHeroItemController.__clearDele_EventOnClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardOftenUsedHeroItemController.<>f__mg$cache11);
		string name = "m_button";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardOftenUsedHeroItemController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardOftenUsedHeroItemController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardOftenUsedHeroItemController.get_m_button);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_BusinessCardOftenUsedHeroItemController.<>f__mg$cache12;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardOftenUsedHeroItemController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardOftenUsedHeroItemController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardOftenUsedHeroItemController.set_m_button);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_BusinessCardOftenUsedHeroItemController.<>f__mg$cache13, true);
		string name2 = "m_headIconImage";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardOftenUsedHeroItemController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardOftenUsedHeroItemController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardOftenUsedHeroItemController.get_m_headIconImage);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_BusinessCardOftenUsedHeroItemController.<>f__mg$cache14;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardOftenUsedHeroItemController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardOftenUsedHeroItemController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardOftenUsedHeroItemController.set_m_headIconImage);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_BusinessCardOftenUsedHeroItemController.<>f__mg$cache15, true);
		string name3 = "EventOnClick";
		LuaCSFunction get3 = null;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardOftenUsedHeroItemController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardOftenUsedHeroItemController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardOftenUsedHeroItemController.set_EventOnClick);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_BusinessCardOftenUsedHeroItemController.<>f__mg$cache16, true);
		string name4 = "HeadId";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardOftenUsedHeroItemController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardOftenUsedHeroItemController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardOftenUsedHeroItemController.get_HeadId);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_BusinessCardOftenUsedHeroItemController.<>f__mg$cache17;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardOftenUsedHeroItemController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardOftenUsedHeroItemController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardOftenUsedHeroItemController.set_HeadId);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_BusinessCardOftenUsedHeroItemController.<>f__mg$cache18, true);
		LuaObject.createTypeMetatable(l, null, typeof(BusinessCardOftenUsedHeroItemController), typeof(UIControllerBase));
	}

	// Token: 0x040128FD RID: 76029
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040128FE RID: 76030
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040128FF RID: 76031
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04012900 RID: 76032
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04012901 RID: 76033
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04012902 RID: 76034
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04012903 RID: 76035
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04012904 RID: 76036
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04012905 RID: 76037
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04012906 RID: 76038
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04012907 RID: 76039
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04012908 RID: 76040
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04012909 RID: 76041
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0401290A RID: 76042
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0401290B RID: 76043
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0401290C RID: 76044
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0401290D RID: 76045
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0401290E RID: 76046
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0401290F RID: 76047
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04012910 RID: 76048
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04012911 RID: 76049
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04012912 RID: 76050
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04012913 RID: 76051
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04012914 RID: 76052
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04012915 RID: 76053
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;
}
