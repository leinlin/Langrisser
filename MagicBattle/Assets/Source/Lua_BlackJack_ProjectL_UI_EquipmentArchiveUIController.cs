using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x02001421 RID: 5153
[Preserve]
public class Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController : LuaObject
{
	// Token: 0x0601D583 RID: 120195 RVA: 0x00945530 File Offset: 0x00943730
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetTask(IntPtr l)
	{
		int result;
		try
		{
			EquipmentArchiveUIController equipmentArchiveUIController = (EquipmentArchiveUIController)LuaObject.checkSelf(l);
			ArchiveUITask task;
			LuaObject.checkType<ArchiveUITask>(l, 2, out task);
			equipmentArchiveUIController.SetTask(task);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D584 RID: 120196 RVA: 0x00945588 File Offset: 0x00943788
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int EnterController(IntPtr l)
	{
		int result;
		try
		{
			EquipmentArchiveUIController equipmentArchiveUIController = (EquipmentArchiveUIController)LuaObject.checkSelf(l);
			equipmentArchiveUIController.EnterController();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D585 RID: 120197 RVA: 0x009455D4 File Offset: 0x009437D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			EquipmentArchiveUIController equipmentArchiveUIController = (EquipmentArchiveUIController)LuaObject.checkSelf(l);
			equipmentArchiveUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D586 RID: 120198 RVA: 0x00945628 File Offset: 0x00943828
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ItemListCompare(IntPtr l)
	{
		int result;
		try
		{
			EquipmentArchiveUIController equipmentArchiveUIController = (EquipmentArchiveUIController)LuaObject.checkSelf(l);
			EquipmentArchiveUIController.EquipmentInfoWrap equipmentWrap;
			LuaObject.checkType<EquipmentArchiveUIController.EquipmentInfoWrap>(l, 2, out equipmentWrap);
			EquipmentArchiveUIController.EquipmentInfoWrap equipmentWrap2;
			LuaObject.checkType<EquipmentArchiveUIController.EquipmentInfoWrap>(l, 3, out equipmentWrap2);
			int i = equipmentArchiveUIController.m_luaExportHelper.ItemListCompare(equipmentWrap, equipmentWrap2);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D587 RID: 120199 RVA: 0x0094569C File Offset: 0x0094389C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RefreshItem(IntPtr l)
	{
		int result;
		try
		{
			EquipmentArchiveUIController equipmentArchiveUIController = (EquipmentArchiveUIController)LuaObject.checkSelf(l);
			ArchiveItemUIController archiveItemUIController;
			LuaObject.checkType<ArchiveItemUIController>(l, 2, out archiveItemUIController);
			equipmentArchiveUIController.m_luaExportHelper.RefreshItem(archiveItemUIController);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D588 RID: 120200 RVA: 0x009456F8 File Offset: 0x009438F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RefreshItemCount(IntPtr l)
	{
		int result;
		try
		{
			EquipmentArchiveUIController equipmentArchiveUIController = (EquipmentArchiveUIController)LuaObject.checkSelf(l);
			int currentCount;
			LuaObject.checkType(l, 2, out currentCount);
			int maxCount;
			LuaObject.checkType(l, 3, out maxCount);
			equipmentArchiveUIController.m_luaExportHelper.RefreshItemCount(currentCount, maxCount);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D589 RID: 120201 RVA: 0x00945764 File Offset: 0x00943964
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CreateItemList(IntPtr l)
	{
		int result;
		try
		{
			EquipmentArchiveUIController equipmentArchiveUIController = (EquipmentArchiveUIController)LuaObject.checkSelf(l);
			List<EquipmentArchiveUIController.EquipmentInfoWrap> equipmentInfoWrapList;
			LuaObject.checkType<List<EquipmentArchiveUIController.EquipmentInfoWrap>>(l, 2, out equipmentInfoWrapList);
			equipmentArchiveUIController.m_luaExportHelper.CreateItemList(equipmentInfoWrapList);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D58A RID: 120202 RVA: 0x009457C0 File Offset: 0x009439C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DestroyItemBagList(IntPtr l)
	{
		int result;
		try
		{
			EquipmentArchiveUIController equipmentArchiveUIController = (EquipmentArchiveUIController)LuaObject.checkSelf(l);
			equipmentArchiveUIController.m_luaExportHelper.DestroyItemBagList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D58B RID: 120203 RVA: 0x00945814 File Offset: 0x00943A14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RefreshItemBagWithHeroData(IntPtr l)
	{
		int result;
		try
		{
			EquipmentArchiveUIController equipmentArchiveUIController = (EquipmentArchiveUIController)LuaObject.checkSelf(l);
			EquipmentArchiveUIController.EquipmentInfoWrap equipmentInfoWrap;
			LuaObject.checkType<EquipmentArchiveUIController.EquipmentInfoWrap>(l, 2, out equipmentInfoWrap);
			equipmentArchiveUIController.m_luaExportHelper.RefreshItemBagWithHeroData(equipmentInfoWrap);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D58C RID: 120204 RVA: 0x00945870 File Offset: 0x00943A70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnReturnClick(IntPtr l)
	{
		int result;
		try
		{
			EquipmentArchiveUIController equipmentArchiveUIController = (EquipmentArchiveUIController)LuaObject.checkSelf(l);
			equipmentArchiveUIController.m_luaExportHelper.OnReturnClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D58D RID: 120205 RVA: 0x009458C4 File Offset: 0x00943AC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnItemClick(IntPtr l)
	{
		int result;
		try
		{
			EquipmentArchiveUIController equipmentArchiveUIController = (EquipmentArchiveUIController)LuaObject.checkSelf(l);
			ArchiveItemUIController archiveItemUIController;
			LuaObject.checkType<ArchiveItemUIController>(l, 2, out archiveItemUIController);
			equipmentArchiveUIController.m_luaExportHelper.OnItemClick(archiveItemUIController);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D58E RID: 120206 RVA: 0x00945920 File Offset: 0x00943B20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnEquipmentFilterSwitchClick(IntPtr l)
	{
		int result;
		try
		{
			EquipmentArchiveUIController equipmentArchiveUIController = (EquipmentArchiveUIController)LuaObject.checkSelf(l);
			GameObject obj;
			LuaObject.checkType<GameObject>(l, 2, out obj);
			equipmentArchiveUIController.m_luaExportHelper.OnEquipmentFilterSwitchClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D58F RID: 120207 RVA: 0x0094597C File Offset: 0x00943B7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnEquipmentFilterClick(IntPtr l)
	{
		int result;
		try
		{
			EquipmentArchiveUIController equipmentArchiveUIController = (EquipmentArchiveUIController)LuaObject.checkSelf(l);
			equipmentArchiveUIController.m_luaExportHelper.OnEquipmentFilterClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D590 RID: 120208 RVA: 0x009459D0 File Offset: 0x00943BD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnFilterBGClick(IntPtr l)
	{
		int result;
		try
		{
			EquipmentArchiveUIController equipmentArchiveUIController = (EquipmentArchiveUIController)LuaObject.checkSelf(l);
			equipmentArchiveUIController.m_luaExportHelper.OnFilterBGClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D591 RID: 120209 RVA: 0x00945A24 File Offset: 0x00943C24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnGetItemPathClick(IntPtr l)
	{
		int result;
		try
		{
			EquipmentArchiveUIController equipmentArchiveUIController = (EquipmentArchiveUIController)LuaObject.checkSelf(l);
			equipmentArchiveUIController.m_luaExportHelper.OnGetItemPathClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D592 RID: 120210 RVA: 0x00945A78 File Offset: 0x00943C78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateChildrenCallbackDelegate(IntPtr l)
	{
		int result;
		try
		{
			EquipmentArchiveUIController equipmentArchiveUIController = (EquipmentArchiveUIController)LuaObject.checkSelf(l);
			int index;
			LuaObject.checkType(l, 2, out index);
			Transform trans;
			LuaObject.checkType<Transform>(l, 3, out trans);
			equipmentArchiveUIController.m_luaExportHelper.UpdateChildrenCallbackDelegate(index, trans);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D593 RID: 120211 RVA: 0x00945AE4 File Offset: 0x00943CE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			EquipmentArchiveUIController equipmentArchiveUIController = (EquipmentArchiveUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			equipmentArchiveUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D594 RID: 120212 RVA: 0x00945B50 File Offset: 0x00943D50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			EquipmentArchiveUIController equipmentArchiveUIController = (EquipmentArchiveUIController)LuaObject.checkSelf(l);
			equipmentArchiveUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D595 RID: 120213 RVA: 0x00945BA4 File Offset: 0x00943DA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			EquipmentArchiveUIController equipmentArchiveUIController = (EquipmentArchiveUIController)LuaObject.checkSelf(l);
			equipmentArchiveUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D596 RID: 120214 RVA: 0x00945BF8 File Offset: 0x00943DF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			EquipmentArchiveUIController equipmentArchiveUIController = (EquipmentArchiveUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = equipmentArchiveUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601D597 RID: 120215 RVA: 0x00945CA0 File Offset: 0x00943EA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			EquipmentArchiveUIController equipmentArchiveUIController = (EquipmentArchiveUIController)LuaObject.checkSelf(l);
			equipmentArchiveUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D598 RID: 120216 RVA: 0x00945CF4 File Offset: 0x00943EF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			EquipmentArchiveUIController equipmentArchiveUIController = (EquipmentArchiveUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			equipmentArchiveUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D599 RID: 120217 RVA: 0x00945D60 File Offset: 0x00943F60
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
				EquipmentArchiveUIController equipmentArchiveUIController = (EquipmentArchiveUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				equipmentArchiveUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				EquipmentArchiveUIController equipmentArchiveUIController2 = (EquipmentArchiveUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				equipmentArchiveUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601D59A RID: 120218 RVA: 0x00945E70 File Offset: 0x00944070
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			EquipmentArchiveUIController equipmentArchiveUIController = (EquipmentArchiveUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			equipmentArchiveUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D59B RID: 120219 RVA: 0x00945EDC File Offset: 0x009440DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			EquipmentArchiveUIController equipmentArchiveUIController = (EquipmentArchiveUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			equipmentArchiveUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D59C RID: 120220 RVA: 0x00945F48 File Offset: 0x00944148
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			EquipmentArchiveUIController equipmentArchiveUIController = (EquipmentArchiveUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			equipmentArchiveUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D59D RID: 120221 RVA: 0x00945FB4 File Offset: 0x009441B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			EquipmentArchiveUIController equipmentArchiveUIController = (EquipmentArchiveUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			equipmentArchiveUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D59E RID: 120222 RVA: 0x00946020 File Offset: 0x00944220
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
				EquipmentArchiveUIController equipmentArchiveUIController = (EquipmentArchiveUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				equipmentArchiveUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				EquipmentArchiveUIController equipmentArchiveUIController2 = (EquipmentArchiveUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				equipmentArchiveUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601D59F RID: 120223 RVA: 0x00946130 File Offset: 0x00944330
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			EquipmentArchiveUIController equipmentArchiveUIController = (EquipmentArchiveUIController)LuaObject.checkSelf(l);
			string s = equipmentArchiveUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601D5A0 RID: 120224 RVA: 0x0094618C File Offset: 0x0094438C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_prefabAnimation(IntPtr l)
	{
		int result;
		try
		{
			EquipmentArchiveUIController equipmentArchiveUIController = (EquipmentArchiveUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentArchiveUIController.m_luaExportHelper.m_prefabAnimation);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D5A1 RID: 120225 RVA: 0x009461E4 File Offset: 0x009443E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_prefabAnimation(IntPtr l)
	{
		int result;
		try
		{
			EquipmentArchiveUIController equipmentArchiveUIController = (EquipmentArchiveUIController)LuaObject.checkSelf(l);
			CommonUIStateController prefabAnimation;
			LuaObject.checkType<CommonUIStateController>(l, 2, out prefabAnimation);
			equipmentArchiveUIController.m_luaExportHelper.m_prefabAnimation = prefabAnimation;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D5A2 RID: 120226 RVA: 0x00946240 File Offset: 0x00944440
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_returnButton(IntPtr l)
	{
		int result;
		try
		{
			EquipmentArchiveUIController equipmentArchiveUIController = (EquipmentArchiveUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentArchiveUIController.m_luaExportHelper.m_returnButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D5A3 RID: 120227 RVA: 0x00946298 File Offset: 0x00944498
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_returnButton(IntPtr l)
	{
		int result;
		try
		{
			EquipmentArchiveUIController equipmentArchiveUIController = (EquipmentArchiveUIController)LuaObject.checkSelf(l);
			Button returnButton;
			LuaObject.checkType<Button>(l, 2, out returnButton);
			equipmentArchiveUIController.m_luaExportHelper.m_returnButton = returnButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D5A4 RID: 120228 RVA: 0x009462F4 File Offset: 0x009444F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_equipmentInfoPanel(IntPtr l)
	{
		int result;
		try
		{
			EquipmentArchiveUIController equipmentArchiveUIController = (EquipmentArchiveUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentArchiveUIController.m_luaExportHelper.m_equipmentInfoPanel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D5A5 RID: 120229 RVA: 0x0094634C File Offset: 0x0094454C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_equipmentInfoPanel(IntPtr l)
	{
		int result;
		try
		{
			EquipmentArchiveUIController equipmentArchiveUIController = (EquipmentArchiveUIController)LuaObject.checkSelf(l);
			GameObject equipmentInfoPanel;
			LuaObject.checkType<GameObject>(l, 2, out equipmentInfoPanel);
			equipmentArchiveUIController.m_luaExportHelper.m_equipmentInfoPanel = equipmentInfoPanel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D5A6 RID: 120230 RVA: 0x009463A8 File Offset: 0x009445A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_getButton(IntPtr l)
	{
		int result;
		try
		{
			EquipmentArchiveUIController equipmentArchiveUIController = (EquipmentArchiveUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentArchiveUIController.m_luaExportHelper.m_getButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D5A7 RID: 120231 RVA: 0x00946400 File Offset: 0x00944600
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_getButton(IntPtr l)
	{
		int result;
		try
		{
			EquipmentArchiveUIController equipmentArchiveUIController = (EquipmentArchiveUIController)LuaObject.checkSelf(l);
			Button getButton;
			LuaObject.checkType<Button>(l, 2, out getButton);
			equipmentArchiveUIController.m_luaExportHelper.m_getButton = getButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D5A8 RID: 120232 RVA: 0x0094645C File Offset: 0x0094465C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_aLLItemToggle(IntPtr l)
	{
		int result;
		try
		{
			EquipmentArchiveUIController equipmentArchiveUIController = (EquipmentArchiveUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentArchiveUIController.m_luaExportHelper.m_aLLItemToggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D5A9 RID: 120233 RVA: 0x009464B4 File Offset: 0x009446B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_aLLItemToggle(IntPtr l)
	{
		int result;
		try
		{
			EquipmentArchiveUIController equipmentArchiveUIController = (EquipmentArchiveUIController)LuaObject.checkSelf(l);
			Toggle aLLItemToggle;
			LuaObject.checkType<Toggle>(l, 2, out aLLItemToggle);
			equipmentArchiveUIController.m_luaExportHelper.m_aLLItemToggle = aLLItemToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D5AA RID: 120234 RVA: 0x00946510 File Offset: 0x00944710
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_weaponItemToggle(IntPtr l)
	{
		int result;
		try
		{
			EquipmentArchiveUIController equipmentArchiveUIController = (EquipmentArchiveUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentArchiveUIController.m_luaExportHelper.m_weaponItemToggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D5AB RID: 120235 RVA: 0x00946568 File Offset: 0x00944768
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_weaponItemToggle(IntPtr l)
	{
		int result;
		try
		{
			EquipmentArchiveUIController equipmentArchiveUIController = (EquipmentArchiveUIController)LuaObject.checkSelf(l);
			Toggle weaponItemToggle;
			LuaObject.checkType<Toggle>(l, 2, out weaponItemToggle);
			equipmentArchiveUIController.m_luaExportHelper.m_weaponItemToggle = weaponItemToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D5AC RID: 120236 RVA: 0x009465C4 File Offset: 0x009447C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_armorItemToggle(IntPtr l)
	{
		int result;
		try
		{
			EquipmentArchiveUIController equipmentArchiveUIController = (EquipmentArchiveUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentArchiveUIController.m_luaExportHelper.m_armorItemToggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D5AD RID: 120237 RVA: 0x0094661C File Offset: 0x0094481C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_armorItemToggle(IntPtr l)
	{
		int result;
		try
		{
			EquipmentArchiveUIController equipmentArchiveUIController = (EquipmentArchiveUIController)LuaObject.checkSelf(l);
			Toggle armorItemToggle;
			LuaObject.checkType<Toggle>(l, 2, out armorItemToggle);
			equipmentArchiveUIController.m_luaExportHelper.m_armorItemToggle = armorItemToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D5AE RID: 120238 RVA: 0x00946678 File Offset: 0x00944878
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_helmetItemToggle(IntPtr l)
	{
		int result;
		try
		{
			EquipmentArchiveUIController equipmentArchiveUIController = (EquipmentArchiveUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentArchiveUIController.m_luaExportHelper.m_helmetItemToggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D5AF RID: 120239 RVA: 0x009466D0 File Offset: 0x009448D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_helmetItemToggle(IntPtr l)
	{
		int result;
		try
		{
			EquipmentArchiveUIController equipmentArchiveUIController = (EquipmentArchiveUIController)LuaObject.checkSelf(l);
			Toggle helmetItemToggle;
			LuaObject.checkType<Toggle>(l, 2, out helmetItemToggle);
			equipmentArchiveUIController.m_luaExportHelper.m_helmetItemToggle = helmetItemToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D5B0 RID: 120240 RVA: 0x0094672C File Offset: 0x0094492C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_ornamentItemToggle(IntPtr l)
	{
		int result;
		try
		{
			EquipmentArchiveUIController equipmentArchiveUIController = (EquipmentArchiveUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentArchiveUIController.m_luaExportHelper.m_ornamentItemToggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D5B1 RID: 120241 RVA: 0x00946784 File Offset: 0x00944984
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_ornamentItemToggle(IntPtr l)
	{
		int result;
		try
		{
			EquipmentArchiveUIController equipmentArchiveUIController = (EquipmentArchiveUIController)LuaObject.checkSelf(l);
			Toggle ornamentItemToggle;
			LuaObject.checkType<Toggle>(l, 2, out ornamentItemToggle);
			equipmentArchiveUIController.m_luaExportHelper.m_ornamentItemToggle = ornamentItemToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D5B2 RID: 120242 RVA: 0x009467E0 File Offset: 0x009449E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_otherItemToggle(IntPtr l)
	{
		int result;
		try
		{
			EquipmentArchiveUIController equipmentArchiveUIController = (EquipmentArchiveUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentArchiveUIController.m_luaExportHelper.m_otherItemToggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D5B3 RID: 120243 RVA: 0x00946838 File Offset: 0x00944A38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_otherItemToggle(IntPtr l)
	{
		int result;
		try
		{
			EquipmentArchiveUIController equipmentArchiveUIController = (EquipmentArchiveUIController)LuaObject.checkSelf(l);
			Toggle otherItemToggle;
			LuaObject.checkType<Toggle>(l, 2, out otherItemToggle);
			equipmentArchiveUIController.m_luaExportHelper.m_otherItemToggle = otherItemToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D5B4 RID: 120244 RVA: 0x00946894 File Offset: 0x00944A94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_filterText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentArchiveUIController equipmentArchiveUIController = (EquipmentArchiveUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentArchiveUIController.m_luaExportHelper.m_filterText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D5B5 RID: 120245 RVA: 0x009468EC File Offset: 0x00944AEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_filterText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentArchiveUIController equipmentArchiveUIController = (EquipmentArchiveUIController)LuaObject.checkSelf(l);
			Text filterText;
			LuaObject.checkType<Text>(l, 2, out filterText);
			equipmentArchiveUIController.m_luaExportHelper.m_filterText = filterText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D5B6 RID: 120246 RVA: 0x00946948 File Offset: 0x00944B48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_equipmentFilterButton(IntPtr l)
	{
		int result;
		try
		{
			EquipmentArchiveUIController equipmentArchiveUIController = (EquipmentArchiveUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentArchiveUIController.m_luaExportHelper.m_equipmentFilterButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D5B7 RID: 120247 RVA: 0x009469A0 File Offset: 0x00944BA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_equipmentFilterButton(IntPtr l)
	{
		int result;
		try
		{
			EquipmentArchiveUIController equipmentArchiveUIController = (EquipmentArchiveUIController)LuaObject.checkSelf(l);
			Button equipmentFilterButton;
			LuaObject.checkType<Button>(l, 2, out equipmentFilterButton);
			equipmentArchiveUIController.m_luaExportHelper.m_equipmentFilterButton = equipmentFilterButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D5B8 RID: 120248 RVA: 0x009469FC File Offset: 0x00944BFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_filterPanel(IntPtr l)
	{
		int result;
		try
		{
			EquipmentArchiveUIController equipmentArchiveUIController = (EquipmentArchiveUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentArchiveUIController.m_luaExportHelper.m_filterPanel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D5B9 RID: 120249 RVA: 0x00946A54 File Offset: 0x00944C54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_filterPanel(IntPtr l)
	{
		int result;
		try
		{
			EquipmentArchiveUIController equipmentArchiveUIController = (EquipmentArchiveUIController)LuaObject.checkSelf(l);
			GameObject filterPanel;
			LuaObject.checkType<GameObject>(l, 2, out filterPanel);
			equipmentArchiveUIController.m_luaExportHelper.m_filterPanel = filterPanel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D5BA RID: 120250 RVA: 0x00946AB0 File Offset: 0x00944CB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_filterBGButton(IntPtr l)
	{
		int result;
		try
		{
			EquipmentArchiveUIController equipmentArchiveUIController = (EquipmentArchiveUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentArchiveUIController.m_luaExportHelper.m_filterBGButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D5BB RID: 120251 RVA: 0x00946B08 File Offset: 0x00944D08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_filterBGButton(IntPtr l)
	{
		int result;
		try
		{
			EquipmentArchiveUIController equipmentArchiveUIController = (EquipmentArchiveUIController)LuaObject.checkSelf(l);
			Button filterBGButton;
			LuaObject.checkType<Button>(l, 2, out filterBGButton);
			equipmentArchiveUIController.m_luaExportHelper.m_filterBGButton = filterBGButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D5BC RID: 120252 RVA: 0x00946B64 File Offset: 0x00944D64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_itemContentInfinityGrid(IntPtr l)
	{
		int result;
		try
		{
			EquipmentArchiveUIController equipmentArchiveUIController = (EquipmentArchiveUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentArchiveUIController.m_luaExportHelper.m_itemContentInfinityGrid);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D5BD RID: 120253 RVA: 0x00946BBC File Offset: 0x00944DBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_itemContentInfinityGrid(IntPtr l)
	{
		int result;
		try
		{
			EquipmentArchiveUIController equipmentArchiveUIController = (EquipmentArchiveUIController)LuaObject.checkSelf(l);
			InfinityGridLayoutGroup itemContentInfinityGrid;
			LuaObject.checkType<InfinityGridLayoutGroup>(l, 2, out itemContentInfinityGrid);
			equipmentArchiveUIController.m_luaExportHelper.m_itemContentInfinityGrid = itemContentInfinityGrid;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D5BE RID: 120254 RVA: 0x00946C18 File Offset: 0x00944E18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_itemContent(IntPtr l)
	{
		int result;
		try
		{
			EquipmentArchiveUIController equipmentArchiveUIController = (EquipmentArchiveUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentArchiveUIController.m_luaExportHelper.m_itemContent);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D5BF RID: 120255 RVA: 0x00946C70 File Offset: 0x00944E70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_itemContent(IntPtr l)
	{
		int result;
		try
		{
			EquipmentArchiveUIController equipmentArchiveUIController = (EquipmentArchiveUIController)LuaObject.checkSelf(l);
			GameObject itemContent;
			LuaObject.checkType<GameObject>(l, 2, out itemContent);
			equipmentArchiveUIController.m_luaExportHelper.m_itemContent = itemContent;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D5C0 RID: 120256 RVA: 0x00946CCC File Offset: 0x00944ECC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_itemPrefab(IntPtr l)
	{
		int result;
		try
		{
			EquipmentArchiveUIController equipmentArchiveUIController = (EquipmentArchiveUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentArchiveUIController.m_luaExportHelper.m_itemPrefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D5C1 RID: 120257 RVA: 0x00946D24 File Offset: 0x00944F24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_itemPrefab(IntPtr l)
	{
		int result;
		try
		{
			EquipmentArchiveUIController equipmentArchiveUIController = (EquipmentArchiveUIController)LuaObject.checkSelf(l);
			GameObject itemPrefab;
			LuaObject.checkType<GameObject>(l, 2, out itemPrefab);
			equipmentArchiveUIController.m_luaExportHelper.m_itemPrefab = itemPrefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D5C2 RID: 120258 RVA: 0x00946D80 File Offset: 0x00944F80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_currentItemCountText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentArchiveUIController equipmentArchiveUIController = (EquipmentArchiveUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentArchiveUIController.m_luaExportHelper.m_currentItemCountText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D5C3 RID: 120259 RVA: 0x00946DD8 File Offset: 0x00944FD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_currentItemCountText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentArchiveUIController equipmentArchiveUIController = (EquipmentArchiveUIController)LuaObject.checkSelf(l);
			Text currentItemCountText;
			LuaObject.checkType<Text>(l, 2, out currentItemCountText);
			equipmentArchiveUIController.m_luaExportHelper.m_currentItemCountText = currentItemCountText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D5C4 RID: 120260 RVA: 0x00946E34 File Offset: 0x00945034
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_maxItemCountText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentArchiveUIController equipmentArchiveUIController = (EquipmentArchiveUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentArchiveUIController.m_luaExportHelper.m_maxItemCountText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D5C5 RID: 120261 RVA: 0x00946E8C File Offset: 0x0094508C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_maxItemCountText(IntPtr l)
	{
		int result;
		try
		{
			EquipmentArchiveUIController equipmentArchiveUIController = (EquipmentArchiveUIController)LuaObject.checkSelf(l);
			Text maxItemCountText;
			LuaObject.checkType<Text>(l, 2, out maxItemCountText);
			equipmentArchiveUIController.m_luaExportHelper.m_maxItemCountText = maxItemCountText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D5C6 RID: 120262 RVA: 0x00946EE8 File Offset: 0x009450E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_selectBagItemList(IntPtr l)
	{
		int result;
		try
		{
			EquipmentArchiveUIController equipmentArchiveUIController = (EquipmentArchiveUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentArchiveUIController.m_luaExportHelper.m_selectBagItemList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D5C7 RID: 120263 RVA: 0x00946F40 File Offset: 0x00945140
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_selectBagItemList(IntPtr l)
	{
		int result;
		try
		{
			EquipmentArchiveUIController equipmentArchiveUIController = (EquipmentArchiveUIController)LuaObject.checkSelf(l);
			List<EquipmentArchiveUIController.EquipmentInfoWrap> selectBagItemList;
			LuaObject.checkType<List<EquipmentArchiveUIController.EquipmentInfoWrap>>(l, 2, out selectBagItemList);
			equipmentArchiveUIController.m_luaExportHelper.m_selectBagItemList = selectBagItemList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D5C8 RID: 120264 RVA: 0x00946F9C File Offset: 0x0094519C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_allBagItemList(IntPtr l)
	{
		int result;
		try
		{
			EquipmentArchiveUIController equipmentArchiveUIController = (EquipmentArchiveUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentArchiveUIController.m_luaExportHelper.m_allBagItemList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D5C9 RID: 120265 RVA: 0x00946FF4 File Offset: 0x009451F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_allBagItemList(IntPtr l)
	{
		int result;
		try
		{
			EquipmentArchiveUIController equipmentArchiveUIController = (EquipmentArchiveUIController)LuaObject.checkSelf(l);
			List<EquipmentArchiveUIController.EquipmentInfoWrap> allBagItemList;
			LuaObject.checkType<List<EquipmentArchiveUIController.EquipmentInfoWrap>>(l, 2, out allBagItemList);
			equipmentArchiveUIController.m_luaExportHelper.m_allBagItemList = allBagItemList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D5CA RID: 120266 RVA: 0x00947050 File Offset: 0x00945250
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_armorBagItemList(IntPtr l)
	{
		int result;
		try
		{
			EquipmentArchiveUIController equipmentArchiveUIController = (EquipmentArchiveUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentArchiveUIController.m_luaExportHelper.m_armorBagItemList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D5CB RID: 120267 RVA: 0x009470A8 File Offset: 0x009452A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_armorBagItemList(IntPtr l)
	{
		int result;
		try
		{
			EquipmentArchiveUIController equipmentArchiveUIController = (EquipmentArchiveUIController)LuaObject.checkSelf(l);
			List<EquipmentArchiveUIController.EquipmentInfoWrap> armorBagItemList;
			LuaObject.checkType<List<EquipmentArchiveUIController.EquipmentInfoWrap>>(l, 2, out armorBagItemList);
			equipmentArchiveUIController.m_luaExportHelper.m_armorBagItemList = armorBagItemList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D5CC RID: 120268 RVA: 0x00947104 File Offset: 0x00945304
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_helmetBagItemList(IntPtr l)
	{
		int result;
		try
		{
			EquipmentArchiveUIController equipmentArchiveUIController = (EquipmentArchiveUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentArchiveUIController.m_luaExportHelper.m_helmetBagItemList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D5CD RID: 120269 RVA: 0x0094715C File Offset: 0x0094535C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_helmetBagItemList(IntPtr l)
	{
		int result;
		try
		{
			EquipmentArchiveUIController equipmentArchiveUIController = (EquipmentArchiveUIController)LuaObject.checkSelf(l);
			List<EquipmentArchiveUIController.EquipmentInfoWrap> helmetBagItemList;
			LuaObject.checkType<List<EquipmentArchiveUIController.EquipmentInfoWrap>>(l, 2, out helmetBagItemList);
			equipmentArchiveUIController.m_luaExportHelper.m_helmetBagItemList = helmetBagItemList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D5CE RID: 120270 RVA: 0x009471B8 File Offset: 0x009453B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_ornamentBagItemList(IntPtr l)
	{
		int result;
		try
		{
			EquipmentArchiveUIController equipmentArchiveUIController = (EquipmentArchiveUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentArchiveUIController.m_luaExportHelper.m_ornamentBagItemList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D5CF RID: 120271 RVA: 0x00947210 File Offset: 0x00945410
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_ornamentBagItemList(IntPtr l)
	{
		int result;
		try
		{
			EquipmentArchiveUIController equipmentArchiveUIController = (EquipmentArchiveUIController)LuaObject.checkSelf(l);
			List<EquipmentArchiveUIController.EquipmentInfoWrap> ornamentBagItemList;
			LuaObject.checkType<List<EquipmentArchiveUIController.EquipmentInfoWrap>>(l, 2, out ornamentBagItemList);
			equipmentArchiveUIController.m_luaExportHelper.m_ornamentBagItemList = ornamentBagItemList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D5D0 RID: 120272 RVA: 0x0094726C File Offset: 0x0094546C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_weaponBagItemList(IntPtr l)
	{
		int result;
		try
		{
			EquipmentArchiveUIController equipmentArchiveUIController = (EquipmentArchiveUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentArchiveUIController.m_luaExportHelper.m_weaponBagItemList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D5D1 RID: 120273 RVA: 0x009472C4 File Offset: 0x009454C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_weaponBagItemList(IntPtr l)
	{
		int result;
		try
		{
			EquipmentArchiveUIController equipmentArchiveUIController = (EquipmentArchiveUIController)LuaObject.checkSelf(l);
			List<EquipmentArchiveUIController.EquipmentInfoWrap> weaponBagItemList;
			LuaObject.checkType<List<EquipmentArchiveUIController.EquipmentInfoWrap>>(l, 2, out weaponBagItemList);
			equipmentArchiveUIController.m_luaExportHelper.m_weaponBagItemList = weaponBagItemList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D5D2 RID: 120274 RVA: 0x00947320 File Offset: 0x00945520
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_otherBagItemList(IntPtr l)
	{
		int result;
		try
		{
			EquipmentArchiveUIController equipmentArchiveUIController = (EquipmentArchiveUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentArchiveUIController.m_luaExportHelper.m_otherBagItemList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D5D3 RID: 120275 RVA: 0x00947378 File Offset: 0x00945578
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_otherBagItemList(IntPtr l)
	{
		int result;
		try
		{
			EquipmentArchiveUIController equipmentArchiveUIController = (EquipmentArchiveUIController)LuaObject.checkSelf(l);
			List<EquipmentArchiveUIController.EquipmentInfoWrap> otherBagItemList;
			LuaObject.checkType<List<EquipmentArchiveUIController.EquipmentInfoWrap>>(l, 2, out otherBagItemList);
			equipmentArchiveUIController.m_luaExportHelper.m_otherBagItemList = otherBagItemList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D5D4 RID: 120276 RVA: 0x009473D4 File Offset: 0x009455D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_task(IntPtr l)
	{
		int result;
		try
		{
			EquipmentArchiveUIController equipmentArchiveUIController = (EquipmentArchiveUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentArchiveUIController.m_luaExportHelper.m_task);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D5D5 RID: 120277 RVA: 0x0094742C File Offset: 0x0094562C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_task(IntPtr l)
	{
		int result;
		try
		{
			EquipmentArchiveUIController equipmentArchiveUIController = (EquipmentArchiveUIController)LuaObject.checkSelf(l);
			ArchiveUITask task;
			LuaObject.checkType<ArchiveUITask>(l, 2, out task);
			equipmentArchiveUIController.m_luaExportHelper.m_task = task;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D5D6 RID: 120278 RVA: 0x00947488 File Offset: 0x00945688
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			EquipmentArchiveUIController equipmentArchiveUIController = (EquipmentArchiveUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentArchiveUIController.m_luaExportHelper.m_playerContext);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D5D7 RID: 120279 RVA: 0x009474E0 File Offset: 0x009456E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			EquipmentArchiveUIController equipmentArchiveUIController = (EquipmentArchiveUIController)LuaObject.checkSelf(l);
			ProjectLPlayerContext playerContext;
			LuaObject.checkType<ProjectLPlayerContext>(l, 2, out playerContext);
			equipmentArchiveUIController.m_luaExportHelper.m_playerContext = playerContext;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D5D8 RID: 120280 RVA: 0x0094753C File Offset: 0x0094573C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			EquipmentArchiveUIController equipmentArchiveUIController = (EquipmentArchiveUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentArchiveUIController.m_luaExportHelper.m_configDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D5D9 RID: 120281 RVA: 0x00947594 File Offset: 0x00945794
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			EquipmentArchiveUIController equipmentArchiveUIController = (EquipmentArchiveUIController)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			equipmentArchiveUIController.m_luaExportHelper.m_configDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D5DA RID: 120282 RVA: 0x009475F0 File Offset: 0x009457F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_itemUIControllerList(IntPtr l)
	{
		int result;
		try
		{
			EquipmentArchiveUIController equipmentArchiveUIController = (EquipmentArchiveUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentArchiveUIController.m_luaExportHelper.m_itemUIControllerList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D5DB RID: 120283 RVA: 0x00947648 File Offset: 0x00945848
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_itemUIControllerList(IntPtr l)
	{
		int result;
		try
		{
			EquipmentArchiveUIController equipmentArchiveUIController = (EquipmentArchiveUIController)LuaObject.checkSelf(l);
			List<ArchiveItemUIController> itemUIControllerList;
			LuaObject.checkType<List<ArchiveItemUIController>>(l, 2, out itemUIControllerList);
			equipmentArchiveUIController.m_luaExportHelper.m_itemUIControllerList = itemUIControllerList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D5DC RID: 120284 RVA: 0x009476A4 File Offset: 0x009458A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_selectEquipmentInfoWrap(IntPtr l)
	{
		int result;
		try
		{
			EquipmentArchiveUIController equipmentArchiveUIController = (EquipmentArchiveUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentArchiveUIController.m_luaExportHelper.m_selectEquipmentInfoWrap);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D5DD RID: 120285 RVA: 0x009476FC File Offset: 0x009458FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_selectEquipmentInfoWrap(IntPtr l)
	{
		int result;
		try
		{
			EquipmentArchiveUIController equipmentArchiveUIController = (EquipmentArchiveUIController)LuaObject.checkSelf(l);
			EquipmentArchiveUIController.EquipmentInfoWrap selectEquipmentInfoWrap;
			LuaObject.checkType<EquipmentArchiveUIController.EquipmentInfoWrap>(l, 2, out selectEquipmentInfoWrap);
			equipmentArchiveUIController.m_luaExportHelper.m_selectEquipmentInfoWrap = selectEquipmentInfoWrap;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D5DE RID: 120286 RVA: 0x00947758 File Offset: 0x00945958
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_itemDetailInfoController(IntPtr l)
	{
		int result;
		try
		{
			EquipmentArchiveUIController equipmentArchiveUIController = (EquipmentArchiveUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentArchiveUIController.m_luaExportHelper.m_itemDetailInfoController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D5DF RID: 120287 RVA: 0x009477B0 File Offset: 0x009459B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_itemDetailInfoController(IntPtr l)
	{
		int result;
		try
		{
			EquipmentArchiveUIController equipmentArchiveUIController = (EquipmentArchiveUIController)LuaObject.checkSelf(l);
			ArchiveItemDetailInfoController itemDetailInfoController;
			LuaObject.checkType<ArchiveItemDetailInfoController>(l, 2, out itemDetailInfoController);
			equipmentArchiveUIController.m_luaExportHelper.m_itemDetailInfoController = itemDetailInfoController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D5E0 RID: 120288 RVA: 0x0094780C File Offset: 0x00945A0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_allOwnItemCount(IntPtr l)
	{
		int result;
		try
		{
			EquipmentArchiveUIController equipmentArchiveUIController = (EquipmentArchiveUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentArchiveUIController.m_luaExportHelper.m_allOwnItemCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D5E1 RID: 120289 RVA: 0x00947864 File Offset: 0x00945A64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_allOwnItemCount(IntPtr l)
	{
		int result;
		try
		{
			EquipmentArchiveUIController equipmentArchiveUIController = (EquipmentArchiveUIController)LuaObject.checkSelf(l);
			int allOwnItemCount;
			LuaObject.checkType(l, 2, out allOwnItemCount);
			equipmentArchiveUIController.m_luaExportHelper.m_allOwnItemCount = allOwnItemCount;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D5E2 RID: 120290 RVA: 0x009478C0 File Offset: 0x00945AC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_armorOwnItemCount(IntPtr l)
	{
		int result;
		try
		{
			EquipmentArchiveUIController equipmentArchiveUIController = (EquipmentArchiveUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentArchiveUIController.m_luaExportHelper.m_armorOwnItemCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D5E3 RID: 120291 RVA: 0x00947918 File Offset: 0x00945B18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_armorOwnItemCount(IntPtr l)
	{
		int result;
		try
		{
			EquipmentArchiveUIController equipmentArchiveUIController = (EquipmentArchiveUIController)LuaObject.checkSelf(l);
			int armorOwnItemCount;
			LuaObject.checkType(l, 2, out armorOwnItemCount);
			equipmentArchiveUIController.m_luaExportHelper.m_armorOwnItemCount = armorOwnItemCount;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D5E4 RID: 120292 RVA: 0x00947974 File Offset: 0x00945B74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_helmetOwnItemCount(IntPtr l)
	{
		int result;
		try
		{
			EquipmentArchiveUIController equipmentArchiveUIController = (EquipmentArchiveUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentArchiveUIController.m_luaExportHelper.m_helmetOwnItemCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D5E5 RID: 120293 RVA: 0x009479CC File Offset: 0x00945BCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_helmetOwnItemCount(IntPtr l)
	{
		int result;
		try
		{
			EquipmentArchiveUIController equipmentArchiveUIController = (EquipmentArchiveUIController)LuaObject.checkSelf(l);
			int helmetOwnItemCount;
			LuaObject.checkType(l, 2, out helmetOwnItemCount);
			equipmentArchiveUIController.m_luaExportHelper.m_helmetOwnItemCount = helmetOwnItemCount;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D5E6 RID: 120294 RVA: 0x00947A28 File Offset: 0x00945C28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_ornamentOwnItemCount(IntPtr l)
	{
		int result;
		try
		{
			EquipmentArchiveUIController equipmentArchiveUIController = (EquipmentArchiveUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentArchiveUIController.m_luaExportHelper.m_ornamentOwnItemCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D5E7 RID: 120295 RVA: 0x00947A80 File Offset: 0x00945C80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_ornamentOwnItemCount(IntPtr l)
	{
		int result;
		try
		{
			EquipmentArchiveUIController equipmentArchiveUIController = (EquipmentArchiveUIController)LuaObject.checkSelf(l);
			int ornamentOwnItemCount;
			LuaObject.checkType(l, 2, out ornamentOwnItemCount);
			equipmentArchiveUIController.m_luaExportHelper.m_ornamentOwnItemCount = ornamentOwnItemCount;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D5E8 RID: 120296 RVA: 0x00947ADC File Offset: 0x00945CDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_weaponOwnItemCount(IntPtr l)
	{
		int result;
		try
		{
			EquipmentArchiveUIController equipmentArchiveUIController = (EquipmentArchiveUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentArchiveUIController.m_luaExportHelper.m_weaponOwnItemCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D5E9 RID: 120297 RVA: 0x00947B34 File Offset: 0x00945D34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_weaponOwnItemCount(IntPtr l)
	{
		int result;
		try
		{
			EquipmentArchiveUIController equipmentArchiveUIController = (EquipmentArchiveUIController)LuaObject.checkSelf(l);
			int weaponOwnItemCount;
			LuaObject.checkType(l, 2, out weaponOwnItemCount);
			equipmentArchiveUIController.m_luaExportHelper.m_weaponOwnItemCount = weaponOwnItemCount;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D5EA RID: 120298 RVA: 0x00947B90 File Offset: 0x00945D90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_otherOwnItemCount(IntPtr l)
	{
		int result;
		try
		{
			EquipmentArchiveUIController equipmentArchiveUIController = (EquipmentArchiveUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentArchiveUIController.m_luaExportHelper.m_otherOwnItemCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D5EB RID: 120299 RVA: 0x00947BE8 File Offset: 0x00945DE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_otherOwnItemCount(IntPtr l)
	{
		int result;
		try
		{
			EquipmentArchiveUIController equipmentArchiveUIController = (EquipmentArchiveUIController)LuaObject.checkSelf(l);
			int otherOwnItemCount;
			LuaObject.checkType(l, 2, out otherOwnItemCount);
			equipmentArchiveUIController.m_luaExportHelper.m_otherOwnItemCount = otherOwnItemCount;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D5EC RID: 120300 RVA: 0x00947C44 File Offset: 0x00945E44
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.EquipmentArchiveUIController");
		if (Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.SetTask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.EnterController);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.ItemListCompare);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.RefreshItem);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.RefreshItemCount);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.CreateItemList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.DestroyItemBagList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.RefreshItemBagWithHeroData);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.OnReturnClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.OnItemClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.OnEquipmentFilterSwitchClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.OnEquipmentFilterClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.OnFilterBGClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.OnGetItemPathClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.UpdateChildrenCallbackDelegate);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache1C);
		string name = "m_prefabAnimation";
		if (Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.get_m_prefabAnimation);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache1D;
		if (Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.set_m_prefabAnimation);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache1E, true);
		string name2 = "m_returnButton";
		if (Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.get_m_returnButton);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache1F;
		if (Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.set_m_returnButton);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache20, true);
		string name3 = "m_equipmentInfoPanel";
		if (Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.get_m_equipmentInfoPanel);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache21;
		if (Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.set_m_equipmentInfoPanel);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache22, true);
		string name4 = "m_getButton";
		if (Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.get_m_getButton);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache23;
		if (Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.set_m_getButton);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache24, true);
		string name5 = "m_aLLItemToggle";
		if (Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.get_m_aLLItemToggle);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache25;
		if (Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.set_m_aLLItemToggle);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache26, true);
		string name6 = "m_weaponItemToggle";
		if (Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.get_m_weaponItemToggle);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache27;
		if (Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.set_m_weaponItemToggle);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache28, true);
		string name7 = "m_armorItemToggle";
		if (Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.get_m_armorItemToggle);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache29;
		if (Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.set_m_armorItemToggle);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache2A, true);
		string name8 = "m_helmetItemToggle";
		if (Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.get_m_helmetItemToggle);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache2B;
		if (Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.set_m_helmetItemToggle);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache2C, true);
		string name9 = "m_ornamentItemToggle";
		if (Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.get_m_ornamentItemToggle);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache2D;
		if (Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.set_m_ornamentItemToggle);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache2E, true);
		string name10 = "m_otherItemToggle";
		if (Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.get_m_otherItemToggle);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache2F;
		if (Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.set_m_otherItemToggle);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache30, true);
		string name11 = "m_filterText";
		if (Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.get_m_filterText);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache31;
		if (Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.set_m_filterText);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache32, true);
		string name12 = "m_equipmentFilterButton";
		if (Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.get_m_equipmentFilterButton);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache33;
		if (Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.set_m_equipmentFilterButton);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache34, true);
		string name13 = "m_filterPanel";
		if (Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.get_m_filterPanel);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache35;
		if (Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.set_m_filterPanel);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache36, true);
		string name14 = "m_filterBGButton";
		if (Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.get_m_filterBGButton);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache37;
		if (Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.set_m_filterBGButton);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache38, true);
		string name15 = "m_itemContentInfinityGrid";
		if (Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.get_m_itemContentInfinityGrid);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache39;
		if (Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.set_m_itemContentInfinityGrid);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache3A, true);
		string name16 = "m_itemContent";
		if (Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.get_m_itemContent);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache3B;
		if (Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.set_m_itemContent);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache3C, true);
		string name17 = "m_itemPrefab";
		if (Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.get_m_itemPrefab);
		}
		LuaCSFunction get17 = Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache3D;
		if (Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.set_m_itemPrefab);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache3E, true);
		string name18 = "m_currentItemCountText";
		if (Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.get_m_currentItemCountText);
		}
		LuaCSFunction get18 = Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache3F;
		if (Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.set_m_currentItemCountText);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache40, true);
		string name19 = "m_maxItemCountText";
		if (Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.get_m_maxItemCountText);
		}
		LuaCSFunction get19 = Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache41;
		if (Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.set_m_maxItemCountText);
		}
		LuaObject.addMember(l, name19, get19, Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache42, true);
		string name20 = "m_selectBagItemList";
		if (Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.get_m_selectBagItemList);
		}
		LuaCSFunction get20 = Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache43;
		if (Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.set_m_selectBagItemList);
		}
		LuaObject.addMember(l, name20, get20, Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache44, true);
		string name21 = "m_allBagItemList";
		if (Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.get_m_allBagItemList);
		}
		LuaCSFunction get21 = Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache45;
		if (Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache46 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache46 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.set_m_allBagItemList);
		}
		LuaObject.addMember(l, name21, get21, Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache46, true);
		string name22 = "m_armorBagItemList";
		if (Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache47 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache47 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.get_m_armorBagItemList);
		}
		LuaCSFunction get22 = Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache47;
		if (Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache48 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache48 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.set_m_armorBagItemList);
		}
		LuaObject.addMember(l, name22, get22, Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache48, true);
		string name23 = "m_helmetBagItemList";
		if (Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache49 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache49 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.get_m_helmetBagItemList);
		}
		LuaCSFunction get23 = Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache49;
		if (Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache4A == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache4A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.set_m_helmetBagItemList);
		}
		LuaObject.addMember(l, name23, get23, Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache4A, true);
		string name24 = "m_ornamentBagItemList";
		if (Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache4B == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache4B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.get_m_ornamentBagItemList);
		}
		LuaCSFunction get24 = Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache4B;
		if (Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache4C == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache4C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.set_m_ornamentBagItemList);
		}
		LuaObject.addMember(l, name24, get24, Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache4C, true);
		string name25 = "m_weaponBagItemList";
		if (Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache4D == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache4D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.get_m_weaponBagItemList);
		}
		LuaCSFunction get25 = Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache4D;
		if (Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache4E == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache4E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.set_m_weaponBagItemList);
		}
		LuaObject.addMember(l, name25, get25, Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache4E, true);
		string name26 = "m_otherBagItemList";
		if (Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache4F == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache4F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.get_m_otherBagItemList);
		}
		LuaCSFunction get26 = Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache4F;
		if (Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache50 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache50 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.set_m_otherBagItemList);
		}
		LuaObject.addMember(l, name26, get26, Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache50, true);
		string name27 = "m_task";
		if (Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache51 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache51 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.get_m_task);
		}
		LuaCSFunction get27 = Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache51;
		if (Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache52 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache52 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.set_m_task);
		}
		LuaObject.addMember(l, name27, get27, Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache52, true);
		string name28 = "m_playerContext";
		if (Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache53 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache53 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.get_m_playerContext);
		}
		LuaCSFunction get28 = Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache53;
		if (Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache54 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache54 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.set_m_playerContext);
		}
		LuaObject.addMember(l, name28, get28, Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache54, true);
		string name29 = "m_configDataLoader";
		if (Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache55 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache55 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.get_m_configDataLoader);
		}
		LuaCSFunction get29 = Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache55;
		if (Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache56 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache56 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.set_m_configDataLoader);
		}
		LuaObject.addMember(l, name29, get29, Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache56, true);
		string name30 = "m_itemUIControllerList";
		if (Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache57 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache57 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.get_m_itemUIControllerList);
		}
		LuaCSFunction get30 = Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache57;
		if (Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache58 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache58 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.set_m_itemUIControllerList);
		}
		LuaObject.addMember(l, name30, get30, Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache58, true);
		string name31 = "m_selectEquipmentInfoWrap";
		if (Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache59 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache59 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.get_m_selectEquipmentInfoWrap);
		}
		LuaCSFunction get31 = Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache59;
		if (Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache5A == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache5A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.set_m_selectEquipmentInfoWrap);
		}
		LuaObject.addMember(l, name31, get31, Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache5A, true);
		string name32 = "m_itemDetailInfoController";
		if (Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache5B == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache5B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.get_m_itemDetailInfoController);
		}
		LuaCSFunction get32 = Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache5B;
		if (Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache5C == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache5C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.set_m_itemDetailInfoController);
		}
		LuaObject.addMember(l, name32, get32, Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache5C, true);
		string name33 = "m_allOwnItemCount";
		if (Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache5D == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache5D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.get_m_allOwnItemCount);
		}
		LuaCSFunction get33 = Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache5D;
		if (Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache5E == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache5E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.set_m_allOwnItemCount);
		}
		LuaObject.addMember(l, name33, get33, Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache5E, true);
		string name34 = "m_armorOwnItemCount";
		if (Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache5F == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache5F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.get_m_armorOwnItemCount);
		}
		LuaCSFunction get34 = Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache5F;
		if (Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache60 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache60 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.set_m_armorOwnItemCount);
		}
		LuaObject.addMember(l, name34, get34, Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache60, true);
		string name35 = "m_helmetOwnItemCount";
		if (Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache61 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache61 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.get_m_helmetOwnItemCount);
		}
		LuaCSFunction get35 = Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache61;
		if (Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache62 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache62 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.set_m_helmetOwnItemCount);
		}
		LuaObject.addMember(l, name35, get35, Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache62, true);
		string name36 = "m_ornamentOwnItemCount";
		if (Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache63 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache63 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.get_m_ornamentOwnItemCount);
		}
		LuaCSFunction get36 = Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache63;
		if (Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache64 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache64 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.set_m_ornamentOwnItemCount);
		}
		LuaObject.addMember(l, name36, get36, Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache64, true);
		string name37 = "m_weaponOwnItemCount";
		if (Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache65 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache65 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.get_m_weaponOwnItemCount);
		}
		LuaCSFunction get37 = Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache65;
		if (Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache66 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache66 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.set_m_weaponOwnItemCount);
		}
		LuaObject.addMember(l, name37, get37, Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache66, true);
		string name38 = "m_otherOwnItemCount";
		if (Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache67 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache67 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.get_m_otherOwnItemCount);
		}
		LuaCSFunction get38 = Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache67;
		if (Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache68 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache68 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.set_m_otherOwnItemCount);
		}
		LuaObject.addMember(l, name38, get38, Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.<>f__mg$cache68, true);
		LuaObject.createTypeMetatable(l, null, typeof(EquipmentArchiveUIController), typeof(UIControllerBase));
	}

	// Token: 0x04013723 RID: 79651
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04013724 RID: 79652
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04013725 RID: 79653
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04013726 RID: 79654
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04013727 RID: 79655
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04013728 RID: 79656
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04013729 RID: 79657
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0401372A RID: 79658
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0401372B RID: 79659
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0401372C RID: 79660
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0401372D RID: 79661
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0401372E RID: 79662
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0401372F RID: 79663
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04013730 RID: 79664
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04013731 RID: 79665
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04013732 RID: 79666
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04013733 RID: 79667
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04013734 RID: 79668
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04013735 RID: 79669
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04013736 RID: 79670
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04013737 RID: 79671
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04013738 RID: 79672
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04013739 RID: 79673
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0401373A RID: 79674
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0401373B RID: 79675
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0401373C RID: 79676
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0401373D RID: 79677
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0401373E RID: 79678
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0401373F RID: 79679
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04013740 RID: 79680
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04013741 RID: 79681
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04013742 RID: 79682
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04013743 RID: 79683
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04013744 RID: 79684
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04013745 RID: 79685
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04013746 RID: 79686
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04013747 RID: 79687
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04013748 RID: 79688
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04013749 RID: 79689
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0401374A RID: 79690
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0401374B RID: 79691
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x0401374C RID: 79692
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x0401374D RID: 79693
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x0401374E RID: 79694
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x0401374F RID: 79695
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04013750 RID: 79696
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04013751 RID: 79697
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04013752 RID: 79698
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04013753 RID: 79699
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04013754 RID: 79700
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04013755 RID: 79701
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x04013756 RID: 79702
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x04013757 RID: 79703
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x04013758 RID: 79704
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x04013759 RID: 79705
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x0401375A RID: 79706
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x0401375B RID: 79707
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x0401375C RID: 79708
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x0401375D RID: 79709
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x0401375E RID: 79710
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x0401375F RID: 79711
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x04013760 RID: 79712
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x04013761 RID: 79713
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x04013762 RID: 79714
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x04013763 RID: 79715
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x04013764 RID: 79716
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x04013765 RID: 79717
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x04013766 RID: 79718
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x04013767 RID: 79719
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x04013768 RID: 79720
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x04013769 RID: 79721
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;

	// Token: 0x0401376A RID: 79722
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache47;

	// Token: 0x0401376B RID: 79723
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache48;

	// Token: 0x0401376C RID: 79724
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache49;

	// Token: 0x0401376D RID: 79725
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4A;

	// Token: 0x0401376E RID: 79726
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4B;

	// Token: 0x0401376F RID: 79727
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4C;

	// Token: 0x04013770 RID: 79728
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4D;

	// Token: 0x04013771 RID: 79729
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4E;

	// Token: 0x04013772 RID: 79730
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4F;

	// Token: 0x04013773 RID: 79731
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache50;

	// Token: 0x04013774 RID: 79732
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache51;

	// Token: 0x04013775 RID: 79733
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache52;

	// Token: 0x04013776 RID: 79734
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache53;

	// Token: 0x04013777 RID: 79735
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache54;

	// Token: 0x04013778 RID: 79736
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache55;

	// Token: 0x04013779 RID: 79737
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache56;

	// Token: 0x0401377A RID: 79738
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache57;

	// Token: 0x0401377B RID: 79739
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache58;

	// Token: 0x0401377C RID: 79740
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache59;

	// Token: 0x0401377D RID: 79741
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5A;

	// Token: 0x0401377E RID: 79742
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5B;

	// Token: 0x0401377F RID: 79743
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5C;

	// Token: 0x04013780 RID: 79744
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5D;

	// Token: 0x04013781 RID: 79745
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5E;

	// Token: 0x04013782 RID: 79746
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5F;

	// Token: 0x04013783 RID: 79747
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache60;

	// Token: 0x04013784 RID: 79748
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache61;

	// Token: 0x04013785 RID: 79749
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache62;

	// Token: 0x04013786 RID: 79750
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache63;

	// Token: 0x04013787 RID: 79751
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache64;

	// Token: 0x04013788 RID: 79752
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache65;

	// Token: 0x04013789 RID: 79753
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache66;

	// Token: 0x0401378A RID: 79754
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache67;

	// Token: 0x0401378B RID: 79755
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache68;
}
