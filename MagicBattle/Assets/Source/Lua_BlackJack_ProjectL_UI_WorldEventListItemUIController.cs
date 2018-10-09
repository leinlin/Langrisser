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

// Token: 0x020015E2 RID: 5602
[Preserve]
public class Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController : LuaObject
{
	// Token: 0x060223A2 RID: 140194 RVA: 0x00BB2218 File Offset: 0x00BB0418
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetEventInfo(IntPtr l)
	{
		int result;
		try
		{
			WorldEventListItemUIController worldEventListItemUIController = (WorldEventListItemUIController)LuaObject.checkSelf(l);
			ConfigDataWaypointInfo waypointInfo;
			LuaObject.checkType<ConfigDataWaypointInfo>(l, 2, out waypointInfo);
			ConfigDataEventInfo eventInfo;
			LuaObject.checkType<ConfigDataEventInfo>(l, 3, out eventInfo);
			worldEventListItemUIController.SetEventInfo(waypointInfo, eventInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060223A3 RID: 140195 RVA: 0x00BB227C File Offset: 0x00BB047C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetExpireTime(IntPtr l)
	{
		int result;
		try
		{
			WorldEventListItemUIController worldEventListItemUIController = (WorldEventListItemUIController)LuaObject.checkSelf(l);
			long expireTime;
			LuaObject.checkType(l, 2, out expireTime);
			worldEventListItemUIController.SetExpireTime(expireTime);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060223A4 RID: 140196 RVA: 0x00BB22D4 File Offset: 0x00BB04D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetWaypointInfo(IntPtr l)
	{
		int result;
		try
		{
			WorldEventListItemUIController worldEventListItemUIController = (WorldEventListItemUIController)LuaObject.checkSelf(l);
			ConfigDataWaypointInfo waypointInfo = worldEventListItemUIController.GetWaypointInfo();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, waypointInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060223A5 RID: 140197 RVA: 0x00BB2328 File Offset: 0x00BB0528
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetEventInfo(IntPtr l)
	{
		int result;
		try
		{
			WorldEventListItemUIController worldEventListItemUIController = (WorldEventListItemUIController)LuaObject.checkSelf(l);
			ConfigDataEventInfo eventInfo = worldEventListItemUIController.GetEventInfo();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, eventInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060223A6 RID: 140198 RVA: 0x00BB237C File Offset: 0x00BB057C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			WorldEventListItemUIController worldEventListItemUIController = (WorldEventListItemUIController)LuaObject.checkSelf(l);
			worldEventListItemUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060223A7 RID: 140199 RVA: 0x00BB23D0 File Offset: 0x00BB05D0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int UpdateRemainTime(IntPtr l)
	{
		int result;
		try
		{
			WorldEventListItemUIController worldEventListItemUIController = (WorldEventListItemUIController)LuaObject.checkSelf(l);
			worldEventListItemUIController.m_luaExportHelper.UpdateRemainTime();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060223A8 RID: 140200 RVA: 0x00BB2424 File Offset: 0x00BB0624
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnClick(IntPtr l)
	{
		int result;
		try
		{
			WorldEventListItemUIController worldEventListItemUIController = (WorldEventListItemUIController)LuaObject.checkSelf(l);
			worldEventListItemUIController.m_luaExportHelper.OnClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060223A9 RID: 140201 RVA: 0x00BB2478 File Offset: 0x00BB0678
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Update(IntPtr l)
	{
		int result;
		try
		{
			WorldEventListItemUIController worldEventListItemUIController = (WorldEventListItemUIController)LuaObject.checkSelf(l);
			worldEventListItemUIController.m_luaExportHelper.Update();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060223AA RID: 140202 RVA: 0x00BB24CC File Offset: 0x00BB06CC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			WorldEventListItemUIController worldEventListItemUIController = (WorldEventListItemUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			worldEventListItemUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060223AB RID: 140203 RVA: 0x00BB2538 File Offset: 0x00BB0738
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			WorldEventListItemUIController worldEventListItemUIController = (WorldEventListItemUIController)LuaObject.checkSelf(l);
			worldEventListItemUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060223AC RID: 140204 RVA: 0x00BB258C File Offset: 0x00BB078C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			WorldEventListItemUIController worldEventListItemUIController = (WorldEventListItemUIController)LuaObject.checkSelf(l);
			worldEventListItemUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060223AD RID: 140205 RVA: 0x00BB25E0 File Offset: 0x00BB07E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			WorldEventListItemUIController worldEventListItemUIController = (WorldEventListItemUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = worldEventListItemUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x060223AE RID: 140206 RVA: 0x00BB2688 File Offset: 0x00BB0888
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			WorldEventListItemUIController worldEventListItemUIController = (WorldEventListItemUIController)LuaObject.checkSelf(l);
			worldEventListItemUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060223AF RID: 140207 RVA: 0x00BB26DC File Offset: 0x00BB08DC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			WorldEventListItemUIController worldEventListItemUIController = (WorldEventListItemUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			worldEventListItemUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060223B0 RID: 140208 RVA: 0x00BB2748 File Offset: 0x00BB0948
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
				WorldEventListItemUIController worldEventListItemUIController = (WorldEventListItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				worldEventListItemUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				WorldEventListItemUIController worldEventListItemUIController2 = (WorldEventListItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				worldEventListItemUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x060223B1 RID: 140209 RVA: 0x00BB2858 File Offset: 0x00BB0A58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			WorldEventListItemUIController worldEventListItemUIController = (WorldEventListItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			worldEventListItemUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060223B2 RID: 140210 RVA: 0x00BB28C4 File Offset: 0x00BB0AC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			WorldEventListItemUIController worldEventListItemUIController = (WorldEventListItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			worldEventListItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060223B3 RID: 140211 RVA: 0x00BB2930 File Offset: 0x00BB0B30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			WorldEventListItemUIController worldEventListItemUIController = (WorldEventListItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			worldEventListItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060223B4 RID: 140212 RVA: 0x00BB299C File Offset: 0x00BB0B9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			WorldEventListItemUIController worldEventListItemUIController = (WorldEventListItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			worldEventListItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060223B5 RID: 140213 RVA: 0x00BB2A08 File Offset: 0x00BB0C08
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
				WorldEventListItemUIController worldEventListItemUIController = (WorldEventListItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				worldEventListItemUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				WorldEventListItemUIController worldEventListItemUIController2 = (WorldEventListItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				worldEventListItemUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x060223B6 RID: 140214 RVA: 0x00BB2B18 File Offset: 0x00BB0D18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			WorldEventListItemUIController worldEventListItemUIController = (WorldEventListItemUIController)LuaObject.checkSelf(l);
			string s = worldEventListItemUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x060223B7 RID: 140215 RVA: 0x00BB2B74 File Offset: 0x00BB0D74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnClick(IntPtr l)
	{
		int result;
		try
		{
			WorldEventListItemUIController worldEventListItemUIController = (WorldEventListItemUIController)LuaObject.checkSelf(l);
			WorldEventListItemUIController obj;
			LuaObject.checkType<WorldEventListItemUIController>(l, 2, out obj);
			worldEventListItemUIController.m_luaExportHelper.__callDele_EventOnClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060223B8 RID: 140216 RVA: 0x00BB2BD0 File Offset: 0x00BB0DD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnClick(IntPtr l)
	{
		int result;
		try
		{
			WorldEventListItemUIController worldEventListItemUIController = (WorldEventListItemUIController)LuaObject.checkSelf(l);
			WorldEventListItemUIController obj;
			LuaObject.checkType<WorldEventListItemUIController>(l, 2, out obj);
			worldEventListItemUIController.m_luaExportHelper.__clearDele_EventOnClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060223B9 RID: 140217 RVA: 0x00BB2C2C File Offset: 0x00BB0E2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnClick(IntPtr l)
	{
		int result;
		try
		{
			WorldEventListItemUIController worldEventListItemUIController = (WorldEventListItemUIController)LuaObject.checkSelf(l);
			Action<WorldEventListItemUIController> value;
			int num = LuaObject.checkDelegate<Action<WorldEventListItemUIController>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					worldEventListItemUIController.EventOnClick += value;
				}
				else if (num == 2)
				{
					worldEventListItemUIController.EventOnClick -= value;
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

	// Token: 0x060223BA RID: 140218 RVA: 0x00BB2CAC File Offset: 0x00BB0EAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_button(IntPtr l)
	{
		int result;
		try
		{
			WorldEventListItemUIController worldEventListItemUIController = (WorldEventListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldEventListItemUIController.m_luaExportHelper.m_button);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060223BB RID: 140219 RVA: 0x00BB2D04 File Offset: 0x00BB0F04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_button(IntPtr l)
	{
		int result;
		try
		{
			WorldEventListItemUIController worldEventListItemUIController = (WorldEventListItemUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			worldEventListItemUIController.m_luaExportHelper.m_button = button;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060223BC RID: 140220 RVA: 0x00BB2D60 File Offset: 0x00BB0F60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_iconImage(IntPtr l)
	{
		int result;
		try
		{
			WorldEventListItemUIController worldEventListItemUIController = (WorldEventListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldEventListItemUIController.m_luaExportHelper.m_iconImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060223BD RID: 140221 RVA: 0x00BB2DB8 File Offset: 0x00BB0FB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_iconImage(IntPtr l)
	{
		int result;
		try
		{
			WorldEventListItemUIController worldEventListItemUIController = (WorldEventListItemUIController)LuaObject.checkSelf(l);
			Image iconImage;
			LuaObject.checkType<Image>(l, 2, out iconImage);
			worldEventListItemUIController.m_luaExportHelper.m_iconImage = iconImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060223BE RID: 140222 RVA: 0x00BB2E14 File Offset: 0x00BB1014
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_titleText(IntPtr l)
	{
		int result;
		try
		{
			WorldEventListItemUIController worldEventListItemUIController = (WorldEventListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldEventListItemUIController.m_luaExportHelper.m_titleText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060223BF RID: 140223 RVA: 0x00BB2E6C File Offset: 0x00BB106C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_titleText(IntPtr l)
	{
		int result;
		try
		{
			WorldEventListItemUIController worldEventListItemUIController = (WorldEventListItemUIController)LuaObject.checkSelf(l);
			Text titleText;
			LuaObject.checkType<Text>(l, 2, out titleText);
			worldEventListItemUIController.m_luaExportHelper.m_titleText = titleText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060223C0 RID: 140224 RVA: 0x00BB2EC8 File Offset: 0x00BB10C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_energyText(IntPtr l)
	{
		int result;
		try
		{
			WorldEventListItemUIController worldEventListItemUIController = (WorldEventListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldEventListItemUIController.m_luaExportHelper.m_energyText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060223C1 RID: 140225 RVA: 0x00BB2F20 File Offset: 0x00BB1120
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_energyText(IntPtr l)
	{
		int result;
		try
		{
			WorldEventListItemUIController worldEventListItemUIController = (WorldEventListItemUIController)LuaObject.checkSelf(l);
			Text energyText;
			LuaObject.checkType<Text>(l, 2, out energyText);
			worldEventListItemUIController.m_luaExportHelper.m_energyText = energyText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060223C2 RID: 140226 RVA: 0x00BB2F7C File Offset: 0x00BB117C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_levelText(IntPtr l)
	{
		int result;
		try
		{
			WorldEventListItemUIController worldEventListItemUIController = (WorldEventListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldEventListItemUIController.m_luaExportHelper.m_levelText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060223C3 RID: 140227 RVA: 0x00BB2FD4 File Offset: 0x00BB11D4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_levelText(IntPtr l)
	{
		int result;
		try
		{
			WorldEventListItemUIController worldEventListItemUIController = (WorldEventListItemUIController)LuaObject.checkSelf(l);
			Text levelText;
			LuaObject.checkType<Text>(l, 2, out levelText);
			worldEventListItemUIController.m_luaExportHelper.m_levelText = levelText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060223C4 RID: 140228 RVA: 0x00BB3030 File Offset: 0x00BB1230
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_timeGameObject(IntPtr l)
	{
		int result;
		try
		{
			WorldEventListItemUIController worldEventListItemUIController = (WorldEventListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldEventListItemUIController.m_luaExportHelper.m_timeGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060223C5 RID: 140229 RVA: 0x00BB3088 File Offset: 0x00BB1288
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_timeGameObject(IntPtr l)
	{
		int result;
		try
		{
			WorldEventListItemUIController worldEventListItemUIController = (WorldEventListItemUIController)LuaObject.checkSelf(l);
			GameObject timeGameObject;
			LuaObject.checkType<GameObject>(l, 2, out timeGameObject);
			worldEventListItemUIController.m_luaExportHelper.m_timeGameObject = timeGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060223C6 RID: 140230 RVA: 0x00BB30E4 File Offset: 0x00BB12E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_timeText(IntPtr l)
	{
		int result;
		try
		{
			WorldEventListItemUIController worldEventListItemUIController = (WorldEventListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldEventListItemUIController.m_luaExportHelper.m_timeText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060223C7 RID: 140231 RVA: 0x00BB313C File Offset: 0x00BB133C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_timeText(IntPtr l)
	{
		int result;
		try
		{
			WorldEventListItemUIController worldEventListItemUIController = (WorldEventListItemUIController)LuaObject.checkSelf(l);
			Text timeText;
			LuaObject.checkType<Text>(l, 2, out timeText);
			worldEventListItemUIController.m_luaExportHelper.m_timeText = timeText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060223C8 RID: 140232 RVA: 0x00BB3198 File Offset: 0x00BB1398
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_wayPointInfo(IntPtr l)
	{
		int result;
		try
		{
			WorldEventListItemUIController worldEventListItemUIController = (WorldEventListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldEventListItemUIController.m_luaExportHelper.m_wayPointInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060223C9 RID: 140233 RVA: 0x00BB31F0 File Offset: 0x00BB13F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_wayPointInfo(IntPtr l)
	{
		int result;
		try
		{
			WorldEventListItemUIController worldEventListItemUIController = (WorldEventListItemUIController)LuaObject.checkSelf(l);
			ConfigDataWaypointInfo wayPointInfo;
			LuaObject.checkType<ConfigDataWaypointInfo>(l, 2, out wayPointInfo);
			worldEventListItemUIController.m_luaExportHelper.m_wayPointInfo = wayPointInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060223CA RID: 140234 RVA: 0x00BB324C File Offset: 0x00BB144C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_eventInfo(IntPtr l)
	{
		int result;
		try
		{
			WorldEventListItemUIController worldEventListItemUIController = (WorldEventListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldEventListItemUIController.m_luaExportHelper.m_eventInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060223CB RID: 140235 RVA: 0x00BB32A4 File Offset: 0x00BB14A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_eventInfo(IntPtr l)
	{
		int result;
		try
		{
			WorldEventListItemUIController worldEventListItemUIController = (WorldEventListItemUIController)LuaObject.checkSelf(l);
			ConfigDataEventInfo eventInfo;
			LuaObject.checkType<ConfigDataEventInfo>(l, 2, out eventInfo);
			worldEventListItemUIController.m_luaExportHelper.m_eventInfo = eventInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060223CC RID: 140236 RVA: 0x00BB3300 File Offset: 0x00BB1500
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_expireTime(IntPtr l)
	{
		int result;
		try
		{
			WorldEventListItemUIController worldEventListItemUIController = (WorldEventListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldEventListItemUIController.m_luaExportHelper.m_expireTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060223CD RID: 140237 RVA: 0x00BB335C File Offset: 0x00BB155C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_expireTime(IntPtr l)
	{
		int result;
		try
		{
			WorldEventListItemUIController worldEventListItemUIController = (WorldEventListItemUIController)LuaObject.checkSelf(l);
			DateTime expireTime;
			LuaObject.checkValueType<DateTime>(l, 2, out expireTime);
			worldEventListItemUIController.m_luaExportHelper.m_expireTime = expireTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060223CE RID: 140238 RVA: 0x00BB33B8 File Offset: 0x00BB15B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_updateCountdown(IntPtr l)
	{
		int result;
		try
		{
			WorldEventListItemUIController worldEventListItemUIController = (WorldEventListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldEventListItemUIController.m_luaExportHelper.m_updateCountdown);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060223CF RID: 140239 RVA: 0x00BB3410 File Offset: 0x00BB1610
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_updateCountdown(IntPtr l)
	{
		int result;
		try
		{
			WorldEventListItemUIController worldEventListItemUIController = (WorldEventListItemUIController)LuaObject.checkSelf(l);
			float updateCountdown;
			LuaObject.checkType(l, 2, out updateCountdown);
			worldEventListItemUIController.m_luaExportHelper.m_updateCountdown = updateCountdown;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060223D0 RID: 140240 RVA: 0x00BB346C File Offset: 0x00BB166C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.WorldEventListItemUIController");
		if (Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.SetEventInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.SetExpireTime);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.GetWaypointInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.GetEventInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.UpdateRemainTime);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.OnClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.Update);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.__callDele_EventOnClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.__clearDele_EventOnClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.<>f__mg$cache16);
		string name = "EventOnClick";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.set_EventOnClick);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.<>f__mg$cache17, true);
		string name2 = "m_button";
		if (Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.get_m_button);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.<>f__mg$cache18;
		if (Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.set_m_button);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.<>f__mg$cache19, true);
		string name3 = "m_iconImage";
		if (Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.get_m_iconImage);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.<>f__mg$cache1A;
		if (Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.set_m_iconImage);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.<>f__mg$cache1B, true);
		string name4 = "m_titleText";
		if (Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.get_m_titleText);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.<>f__mg$cache1C;
		if (Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.set_m_titleText);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.<>f__mg$cache1D, true);
		string name5 = "m_energyText";
		if (Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.get_m_energyText);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.<>f__mg$cache1E;
		if (Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.set_m_energyText);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.<>f__mg$cache1F, true);
		string name6 = "m_levelText";
		if (Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.get_m_levelText);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.<>f__mg$cache20;
		if (Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.set_m_levelText);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.<>f__mg$cache21, true);
		string name7 = "m_timeGameObject";
		if (Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.get_m_timeGameObject);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.<>f__mg$cache22;
		if (Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.set_m_timeGameObject);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.<>f__mg$cache23, true);
		string name8 = "m_timeText";
		if (Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.get_m_timeText);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.<>f__mg$cache24;
		if (Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.set_m_timeText);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.<>f__mg$cache25, true);
		string name9 = "m_wayPointInfo";
		if (Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.get_m_wayPointInfo);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.<>f__mg$cache26;
		if (Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.set_m_wayPointInfo);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.<>f__mg$cache27, true);
		string name10 = "m_eventInfo";
		if (Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.get_m_eventInfo);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.<>f__mg$cache28;
		if (Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.set_m_eventInfo);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.<>f__mg$cache29, true);
		string name11 = "m_expireTime";
		if (Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.get_m_expireTime);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.<>f__mg$cache2A;
		if (Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.set_m_expireTime);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.<>f__mg$cache2B, true);
		string name12 = "m_updateCountdown";
		if (Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.get_m_updateCountdown);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.<>f__mg$cache2C;
		if (Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.set_m_updateCountdown);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.<>f__mg$cache2D, true);
		LuaObject.createTypeMetatable(l, null, typeof(WorldEventListItemUIController), typeof(UIControllerBase));
	}

	// Token: 0x040181C0 RID: 98752
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040181C1 RID: 98753
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040181C2 RID: 98754
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040181C3 RID: 98755
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040181C4 RID: 98756
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040181C5 RID: 98757
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040181C6 RID: 98758
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040181C7 RID: 98759
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x040181C8 RID: 98760
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x040181C9 RID: 98761
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x040181CA RID: 98762
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x040181CB RID: 98763
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x040181CC RID: 98764
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x040181CD RID: 98765
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x040181CE RID: 98766
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x040181CF RID: 98767
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x040181D0 RID: 98768
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x040181D1 RID: 98769
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x040181D2 RID: 98770
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x040181D3 RID: 98771
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x040181D4 RID: 98772
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x040181D5 RID: 98773
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x040181D6 RID: 98774
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x040181D7 RID: 98775
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x040181D8 RID: 98776
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x040181D9 RID: 98777
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x040181DA RID: 98778
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x040181DB RID: 98779
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x040181DC RID: 98780
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x040181DD RID: 98781
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x040181DE RID: 98782
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x040181DF RID: 98783
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x040181E0 RID: 98784
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x040181E1 RID: 98785
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x040181E2 RID: 98786
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x040181E3 RID: 98787
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x040181E4 RID: 98788
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x040181E5 RID: 98789
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x040181E6 RID: 98790
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x040181E7 RID: 98791
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x040181E8 RID: 98792
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x040181E9 RID: 98793
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x040181EA RID: 98794
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x040181EB RID: 98795
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x040181EC RID: 98796
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x040181ED RID: 98797
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;
}
