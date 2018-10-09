using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x02001508 RID: 5384
[Preserve]
public class Lua_BlackJack_ProjectL_UI_ManualUIController : LuaObject
{
	// Token: 0x0601FE2B RID: 130603 RVA: 0x00A87F28 File Offset: 0x00A86128
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetTask(IntPtr l)
	{
		int result;
		try
		{
			ManualUIController manualUIController = (ManualUIController)LuaObject.checkSelf(l);
			ArchiveUITask task;
			LuaObject.checkType<ArchiveUITask>(l, 2, out task);
			manualUIController.SetTask(task);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FE2C RID: 130604 RVA: 0x00A87F80 File Offset: 0x00A86180
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			ManualUIController manualUIController = (ManualUIController)LuaObject.checkSelf(l);
			manualUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FE2D RID: 130605 RVA: 0x00A87FD4 File Offset: 0x00A861D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnEquipmentClick(IntPtr l)
	{
		int result;
		try
		{
			ManualUIController manualUIController = (ManualUIController)LuaObject.checkSelf(l);
			manualUIController.m_luaExportHelper.OnEquipmentClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FE2E RID: 130606 RVA: 0x00A88028 File Offset: 0x00A86228
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnHeroClick(IntPtr l)
	{
		int result;
		try
		{
			ManualUIController manualUIController = (ManualUIController)LuaObject.checkSelf(l);
			manualUIController.m_luaExportHelper.OnHeroClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FE2F RID: 130607 RVA: 0x00A8807C File Offset: 0x00A8627C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnReturnClick(IntPtr l)
	{
		int result;
		try
		{
			ManualUIController manualUIController = (ManualUIController)LuaObject.checkSelf(l);
			manualUIController.m_luaExportHelper.OnReturnClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FE30 RID: 130608 RVA: 0x00A880D0 File Offset: 0x00A862D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnDetailClick(IntPtr l)
	{
		int result;
		try
		{
			ManualUIController manualUIController = (ManualUIController)LuaObject.checkSelf(l);
			manualUIController.m_luaExportHelper.OnDetailClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FE31 RID: 130609 RVA: 0x00A88124 File Offset: 0x00A86324
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			ManualUIController manualUIController = (ManualUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			manualUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FE32 RID: 130610 RVA: 0x00A88190 File Offset: 0x00A86390
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			ManualUIController manualUIController = (ManualUIController)LuaObject.checkSelf(l);
			manualUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FE33 RID: 130611 RVA: 0x00A881E4 File Offset: 0x00A863E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			ManualUIController manualUIController = (ManualUIController)LuaObject.checkSelf(l);
			manualUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FE34 RID: 130612 RVA: 0x00A88238 File Offset: 0x00A86438
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			ManualUIController manualUIController = (ManualUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = manualUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601FE35 RID: 130613 RVA: 0x00A882E0 File Offset: 0x00A864E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			ManualUIController manualUIController = (ManualUIController)LuaObject.checkSelf(l);
			manualUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FE36 RID: 130614 RVA: 0x00A88334 File Offset: 0x00A86534
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ManualUIController manualUIController = (ManualUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			manualUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FE37 RID: 130615 RVA: 0x00A883A0 File Offset: 0x00A865A0
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
				ManualUIController manualUIController = (ManualUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				manualUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				ManualUIController manualUIController2 = (ManualUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				manualUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601FE38 RID: 130616 RVA: 0x00A884B0 File Offset: 0x00A866B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			ManualUIController manualUIController = (ManualUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			manualUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FE39 RID: 130617 RVA: 0x00A8851C File Offset: 0x00A8671C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			ManualUIController manualUIController = (ManualUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			manualUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FE3A RID: 130618 RVA: 0x00A88588 File Offset: 0x00A86788
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			ManualUIController manualUIController = (ManualUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			manualUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FE3B RID: 130619 RVA: 0x00A885F4 File Offset: 0x00A867F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			ManualUIController manualUIController = (ManualUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			manualUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FE3C RID: 130620 RVA: 0x00A88660 File Offset: 0x00A86860
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
				ManualUIController manualUIController = (ManualUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				manualUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				ManualUIController manualUIController2 = (ManualUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				manualUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601FE3D RID: 130621 RVA: 0x00A88770 File Offset: 0x00A86970
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			ManualUIController manualUIController = (ManualUIController)LuaObject.checkSelf(l);
			string s = manualUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601FE3E RID: 130622 RVA: 0x00A887CC File Offset: 0x00A869CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_equipmentButton(IntPtr l)
	{
		int result;
		try
		{
			ManualUIController manualUIController = (ManualUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, manualUIController.m_luaExportHelper.m_equipmentButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FE3F RID: 130623 RVA: 0x00A88824 File Offset: 0x00A86A24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_equipmentButton(IntPtr l)
	{
		int result;
		try
		{
			ManualUIController manualUIController = (ManualUIController)LuaObject.checkSelf(l);
			Button equipmentButton;
			LuaObject.checkType<Button>(l, 2, out equipmentButton);
			manualUIController.m_luaExportHelper.m_equipmentButton = equipmentButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FE40 RID: 130624 RVA: 0x00A88880 File Offset: 0x00A86A80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroButton(IntPtr l)
	{
		int result;
		try
		{
			ManualUIController manualUIController = (ManualUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, manualUIController.m_luaExportHelper.m_heroButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FE41 RID: 130625 RVA: 0x00A888D8 File Offset: 0x00A86AD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroButton(IntPtr l)
	{
		int result;
		try
		{
			ManualUIController manualUIController = (ManualUIController)LuaObject.checkSelf(l);
			Button heroButton;
			LuaObject.checkType<Button>(l, 2, out heroButton);
			manualUIController.m_luaExportHelper.m_heroButton = heroButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FE42 RID: 130626 RVA: 0x00A88934 File Offset: 0x00A86B34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_returnButton(IntPtr l)
	{
		int result;
		try
		{
			ManualUIController manualUIController = (ManualUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, manualUIController.m_luaExportHelper.m_returnButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FE43 RID: 130627 RVA: 0x00A8898C File Offset: 0x00A86B8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_returnButton(IntPtr l)
	{
		int result;
		try
		{
			ManualUIController manualUIController = (ManualUIController)LuaObject.checkSelf(l);
			Button returnButton;
			LuaObject.checkType<Button>(l, 2, out returnButton);
			manualUIController.m_luaExportHelper.m_returnButton = returnButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FE44 RID: 130628 RVA: 0x00A889E8 File Offset: 0x00A86BE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_detailButton(IntPtr l)
	{
		int result;
		try
		{
			ManualUIController manualUIController = (ManualUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, manualUIController.m_luaExportHelper.m_detailButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FE45 RID: 130629 RVA: 0x00A88A40 File Offset: 0x00A86C40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_detailButton(IntPtr l)
	{
		int result;
		try
		{
			ManualUIController manualUIController = (ManualUIController)LuaObject.checkSelf(l);
			Button detailButton;
			LuaObject.checkType<Button>(l, 2, out detailButton);
			manualUIController.m_luaExportHelper.m_detailButton = detailButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FE46 RID: 130630 RVA: 0x00A88A9C File Offset: 0x00A86C9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_task(IntPtr l)
	{
		int result;
		try
		{
			ManualUIController manualUIController = (ManualUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, manualUIController.m_luaExportHelper.m_task);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FE47 RID: 130631 RVA: 0x00A88AF4 File Offset: 0x00A86CF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_task(IntPtr l)
	{
		int result;
		try
		{
			ManualUIController manualUIController = (ManualUIController)LuaObject.checkSelf(l);
			ArchiveUITask task;
			LuaObject.checkType<ArchiveUITask>(l, 2, out task);
			manualUIController.m_luaExportHelper.m_task = task;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FE48 RID: 130632 RVA: 0x00A88B50 File Offset: 0x00A86D50
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.ManualUIController");
		if (Lua_BlackJack_ProjectL_UI_ManualUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_ManualUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ManualUIController.SetTask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ManualUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_ManualUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_ManualUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ManualUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ManualUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_ManualUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_ManualUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ManualUIController.OnEquipmentClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ManualUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_ManualUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_ManualUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ManualUIController.OnHeroClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ManualUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_ManualUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_ManualUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ManualUIController.OnReturnClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ManualUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_ManualUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_ManualUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ManualUIController.OnDetailClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ManualUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_ManualUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_ManualUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ManualUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ManualUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_ManualUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_ManualUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ManualUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ManualUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_ManualUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_ManualUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ManualUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ManualUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_ManualUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_ManualUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ManualUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ManualUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_ManualUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_ManualUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ManualUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ManualUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_ManualUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_ManualUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ManualUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ManualUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_ManualUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_ManualUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ManualUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ManualUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_ManualUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_ManualUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ManualUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ManualUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_ManualUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_ManualUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ManualUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ManualUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_ManualUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_ManualUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ManualUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ManualUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_ManualUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_ManualUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ManualUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ManualUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_ManualUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_ManualUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ManualUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ManualUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_ManualUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_ManualUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ManualUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ManualUIController.<>f__mg$cache12);
		string name = "m_equipmentButton";
		if (Lua_BlackJack_ProjectL_UI_ManualUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_ManualUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ManualUIController.get_m_equipmentButton);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_ManualUIController.<>f__mg$cache13;
		if (Lua_BlackJack_ProjectL_UI_ManualUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_ManualUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ManualUIController.set_m_equipmentButton);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_ManualUIController.<>f__mg$cache14, true);
		string name2 = "m_heroButton";
		if (Lua_BlackJack_ProjectL_UI_ManualUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_ManualUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ManualUIController.get_m_heroButton);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_ManualUIController.<>f__mg$cache15;
		if (Lua_BlackJack_ProjectL_UI_ManualUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_ManualUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ManualUIController.set_m_heroButton);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_ManualUIController.<>f__mg$cache16, true);
		string name3 = "m_returnButton";
		if (Lua_BlackJack_ProjectL_UI_ManualUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_ManualUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ManualUIController.get_m_returnButton);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_ManualUIController.<>f__mg$cache17;
		if (Lua_BlackJack_ProjectL_UI_ManualUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_ManualUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ManualUIController.set_m_returnButton);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_ManualUIController.<>f__mg$cache18, true);
		string name4 = "m_detailButton";
		if (Lua_BlackJack_ProjectL_UI_ManualUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_ManualUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ManualUIController.get_m_detailButton);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_ManualUIController.<>f__mg$cache19;
		if (Lua_BlackJack_ProjectL_UI_ManualUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_ManualUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ManualUIController.set_m_detailButton);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_ManualUIController.<>f__mg$cache1A, true);
		string name5 = "m_task";
		if (Lua_BlackJack_ProjectL_UI_ManualUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_ManualUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ManualUIController.get_m_task);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_ManualUIController.<>f__mg$cache1B;
		if (Lua_BlackJack_ProjectL_UI_ManualUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_ManualUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ManualUIController.set_m_task);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_ManualUIController.<>f__mg$cache1C, true);
		LuaObject.createTypeMetatable(l, null, typeof(ManualUIController), typeof(UIControllerBase));
	}

	// Token: 0x04015DFD RID: 89597
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04015DFE RID: 89598
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04015DFF RID: 89599
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04015E00 RID: 89600
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04015E01 RID: 89601
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04015E02 RID: 89602
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04015E03 RID: 89603
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04015E04 RID: 89604
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04015E05 RID: 89605
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04015E06 RID: 89606
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04015E07 RID: 89607
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04015E08 RID: 89608
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04015E09 RID: 89609
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04015E0A RID: 89610
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04015E0B RID: 89611
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04015E0C RID: 89612
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04015E0D RID: 89613
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04015E0E RID: 89614
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04015E0F RID: 89615
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04015E10 RID: 89616
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04015E11 RID: 89617
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04015E12 RID: 89618
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04015E13 RID: 89619
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04015E14 RID: 89620
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04015E15 RID: 89621
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04015E16 RID: 89622
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04015E17 RID: 89623
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04015E18 RID: 89624
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04015E19 RID: 89625
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;
}
