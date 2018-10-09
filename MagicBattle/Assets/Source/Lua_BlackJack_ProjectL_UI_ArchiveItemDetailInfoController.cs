using System;
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

// Token: 0x02001365 RID: 4965
[Preserve]
public class Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController : LuaObject
{
	// Token: 0x0601AC64 RID: 109668 RVA: 0x007FDA60 File Offset: 0x007FBC60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetData(IntPtr l)
	{
		int result;
		try
		{
			ArchiveItemDetailInfoController archiveItemDetailInfoController = (ArchiveItemDetailInfoController)LuaObject.checkSelf(l);
			EquipmentArchiveUIController.EquipmentInfoWrap data;
			LuaObject.checkType<EquipmentArchiveUIController.EquipmentInfoWrap>(l, 2, out data);
			archiveItemDetailInfoController.SetData(data);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AC65 RID: 109669 RVA: 0x007FDAB8 File Offset: 0x007FBCB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Refresh(IntPtr l)
	{
		int result;
		try
		{
			ArchiveItemDetailInfoController archiveItemDetailInfoController = (ArchiveItemDetailInfoController)LuaObject.checkSelf(l);
			archiveItemDetailInfoController.Refresh();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AC66 RID: 109670 RVA: 0x007FDB04 File Offset: 0x007FBD04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			ArchiveItemDetailInfoController archiveItemDetailInfoController = (ArchiveItemDetailInfoController)LuaObject.checkSelf(l);
			archiveItemDetailInfoController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AC67 RID: 109671 RVA: 0x007FDB58 File Offset: 0x007FBD58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClosePropDisplay(IntPtr l)
	{
		int result;
		try
		{
			ArchiveItemDetailInfoController archiveItemDetailInfoController = (ArchiveItemDetailInfoController)LuaObject.checkSelf(l);
			archiveItemDetailInfoController.m_luaExportHelper.ClosePropDisplay();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AC68 RID: 109672 RVA: 0x007FDBAC File Offset: 0x007FBDAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetEquipmentPropItem(IntPtr l)
	{
		int result;
		try
		{
			ArchiveItemDetailInfoController archiveItemDetailInfoController = (ArchiveItemDetailInfoController)LuaObject.checkSelf(l);
			PropertyModifyType type;
			LuaObject.checkEnum<PropertyModifyType>(l, 2, out type);
			int value;
			LuaObject.checkType(l, 3, out value);
			archiveItemDetailInfoController.m_luaExportHelper.SetEquipmentPropItem(type, value);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AC69 RID: 109673 RVA: 0x007FDC18 File Offset: 0x007FBE18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			ArchiveItemDetailInfoController archiveItemDetailInfoController = (ArchiveItemDetailInfoController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			archiveItemDetailInfoController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AC6A RID: 109674 RVA: 0x007FDC84 File Offset: 0x007FBE84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			ArchiveItemDetailInfoController archiveItemDetailInfoController = (ArchiveItemDetailInfoController)LuaObject.checkSelf(l);
			archiveItemDetailInfoController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AC6B RID: 109675 RVA: 0x007FDCD8 File Offset: 0x007FBED8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			ArchiveItemDetailInfoController archiveItemDetailInfoController = (ArchiveItemDetailInfoController)LuaObject.checkSelf(l);
			archiveItemDetailInfoController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AC6C RID: 109676 RVA: 0x007FDD2C File Offset: 0x007FBF2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			ArchiveItemDetailInfoController archiveItemDetailInfoController = (ArchiveItemDetailInfoController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = archiveItemDetailInfoController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601AC6D RID: 109677 RVA: 0x007FDDD4 File Offset: 0x007FBFD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			ArchiveItemDetailInfoController archiveItemDetailInfoController = (ArchiveItemDetailInfoController)LuaObject.checkSelf(l);
			archiveItemDetailInfoController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AC6E RID: 109678 RVA: 0x007FDE28 File Offset: 0x007FC028
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ArchiveItemDetailInfoController archiveItemDetailInfoController = (ArchiveItemDetailInfoController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			archiveItemDetailInfoController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AC6F RID: 109679 RVA: 0x007FDE94 File Offset: 0x007FC094
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
				ArchiveItemDetailInfoController archiveItemDetailInfoController = (ArchiveItemDetailInfoController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				archiveItemDetailInfoController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				ArchiveItemDetailInfoController archiveItemDetailInfoController2 = (ArchiveItemDetailInfoController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				archiveItemDetailInfoController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601AC70 RID: 109680 RVA: 0x007FDFA4 File Offset: 0x007FC1A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			ArchiveItemDetailInfoController archiveItemDetailInfoController = (ArchiveItemDetailInfoController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			archiveItemDetailInfoController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AC71 RID: 109681 RVA: 0x007FE010 File Offset: 0x007FC210
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			ArchiveItemDetailInfoController archiveItemDetailInfoController = (ArchiveItemDetailInfoController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			archiveItemDetailInfoController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AC72 RID: 109682 RVA: 0x007FE07C File Offset: 0x007FC27C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			ArchiveItemDetailInfoController archiveItemDetailInfoController = (ArchiveItemDetailInfoController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			archiveItemDetailInfoController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AC73 RID: 109683 RVA: 0x007FE0E8 File Offset: 0x007FC2E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			ArchiveItemDetailInfoController archiveItemDetailInfoController = (ArchiveItemDetailInfoController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			archiveItemDetailInfoController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AC74 RID: 109684 RVA: 0x007FE154 File Offset: 0x007FC354
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
				ArchiveItemDetailInfoController archiveItemDetailInfoController = (ArchiveItemDetailInfoController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				archiveItemDetailInfoController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				ArchiveItemDetailInfoController archiveItemDetailInfoController2 = (ArchiveItemDetailInfoController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				archiveItemDetailInfoController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601AC75 RID: 109685 RVA: 0x007FE264 File Offset: 0x007FC464
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			ArchiveItemDetailInfoController archiveItemDetailInfoController = (ArchiveItemDetailInfoController)LuaObject.checkSelf(l);
			string s = archiveItemDetailInfoController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601AC76 RID: 109686 RVA: 0x007FE2C0 File Offset: 0x007FC4C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_nameText(IntPtr l)
	{
		int result;
		try
		{
			ArchiveItemDetailInfoController archiveItemDetailInfoController = (ArchiveItemDetailInfoController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, archiveItemDetailInfoController.m_luaExportHelper.m_nameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AC77 RID: 109687 RVA: 0x007FE318 File Offset: 0x007FC518
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_nameText(IntPtr l)
	{
		int result;
		try
		{
			ArchiveItemDetailInfoController archiveItemDetailInfoController = (ArchiveItemDetailInfoController)LuaObject.checkSelf(l);
			Text nameText;
			LuaObject.checkType<Text>(l, 2, out nameText);
			archiveItemDetailInfoController.m_luaExportHelper.m_nameText = nameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AC78 RID: 109688 RVA: 0x007FE374 File Offset: 0x007FC574
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_itemIamge(IntPtr l)
	{
		int result;
		try
		{
			ArchiveItemDetailInfoController archiveItemDetailInfoController = (ArchiveItemDetailInfoController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, archiveItemDetailInfoController.m_luaExportHelper.m_itemIamge);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AC79 RID: 109689 RVA: 0x007FE3CC File Offset: 0x007FC5CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_itemIamge(IntPtr l)
	{
		int result;
		try
		{
			ArchiveItemDetailInfoController archiveItemDetailInfoController = (ArchiveItemDetailInfoController)LuaObject.checkSelf(l);
			Image itemIamge;
			LuaObject.checkType<Image>(l, 2, out itemIamge);
			archiveItemDetailInfoController.m_luaExportHelper.m_itemIamge = itemIamge;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AC7A RID: 109690 RVA: 0x007FE428 File Offset: 0x007FC628
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_equipLimitGroupAnimation(IntPtr l)
	{
		int result;
		try
		{
			ArchiveItemDetailInfoController archiveItemDetailInfoController = (ArchiveItemDetailInfoController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, archiveItemDetailInfoController.m_luaExportHelper.m_equipLimitGroupAnimation);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AC7B RID: 109691 RVA: 0x007FE480 File Offset: 0x007FC680
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_equipLimitGroupAnimation(IntPtr l)
	{
		int result;
		try
		{
			ArchiveItemDetailInfoController archiveItemDetailInfoController = (ArchiveItemDetailInfoController)LuaObject.checkSelf(l);
			CommonUIStateController equipLimitGroupAnimation;
			LuaObject.checkType<CommonUIStateController>(l, 2, out equipLimitGroupAnimation);
			archiveItemDetailInfoController.m_luaExportHelper.m_equipLimitGroupAnimation = equipLimitGroupAnimation;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AC7C RID: 109692 RVA: 0x007FE4DC File Offset: 0x007FC6DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_equipLimitContent(IntPtr l)
	{
		int result;
		try
		{
			ArchiveItemDetailInfoController archiveItemDetailInfoController = (ArchiveItemDetailInfoController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, archiveItemDetailInfoController.m_luaExportHelper.m_equipLimitContent);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AC7D RID: 109693 RVA: 0x007FE534 File Offset: 0x007FC734
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_equipLimitContent(IntPtr l)
	{
		int result;
		try
		{
			ArchiveItemDetailInfoController archiveItemDetailInfoController = (ArchiveItemDetailInfoController)LuaObject.checkSelf(l);
			GameObject equipLimitContent;
			LuaObject.checkType<GameObject>(l, 2, out equipLimitContent);
			archiveItemDetailInfoController.m_luaExportHelper.m_equipLimitContent = equipLimitContent;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AC7E RID: 109694 RVA: 0x007FE590 File Offset: 0x007FC790
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_descEquipUnlimitText(IntPtr l)
	{
		int result;
		try
		{
			ArchiveItemDetailInfoController archiveItemDetailInfoController = (ArchiveItemDetailInfoController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, archiveItemDetailInfoController.m_luaExportHelper.m_descEquipUnlimitText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AC7F RID: 109695 RVA: 0x007FE5E8 File Offset: 0x007FC7E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_descEquipUnlimitText(IntPtr l)
	{
		int result;
		try
		{
			ArchiveItemDetailInfoController archiveItemDetailInfoController = (ArchiveItemDetailInfoController)LuaObject.checkSelf(l);
			Text descEquipUnlimitText;
			LuaObject.checkType<Text>(l, 2, out descEquipUnlimitText);
			archiveItemDetailInfoController.m_luaExportHelper.m_descEquipUnlimitText = descEquipUnlimitText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AC80 RID: 109696 RVA: 0x007FE644 File Offset: 0x007FC844
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_equipmentExplain(IntPtr l)
	{
		int result;
		try
		{
			ArchiveItemDetailInfoController archiveItemDetailInfoController = (ArchiveItemDetailInfoController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, archiveItemDetailInfoController.m_luaExportHelper.m_equipmentExplain);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AC81 RID: 109697 RVA: 0x007FE69C File Offset: 0x007FC89C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_equipmentExplain(IntPtr l)
	{
		int result;
		try
		{
			ArchiveItemDetailInfoController archiveItemDetailInfoController = (ArchiveItemDetailInfoController)LuaObject.checkSelf(l);
			Text equipmentExplain;
			LuaObject.checkType<Text>(l, 2, out equipmentExplain);
			archiveItemDetailInfoController.m_luaExportHelper.m_equipmentExplain = equipmentExplain;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AC82 RID: 109698 RVA: 0x007FE6F8 File Offset: 0x007FC8F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_HPGameObject(IntPtr l)
	{
		int result;
		try
		{
			ArchiveItemDetailInfoController archiveItemDetailInfoController = (ArchiveItemDetailInfoController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, archiveItemDetailInfoController.m_luaExportHelper.m_HPGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AC83 RID: 109699 RVA: 0x007FE750 File Offset: 0x007FC950
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_HPGameObject(IntPtr l)
	{
		int result;
		try
		{
			ArchiveItemDetailInfoController archiveItemDetailInfoController = (ArchiveItemDetailInfoController)LuaObject.checkSelf(l);
			GameObject hpgameObject;
			LuaObject.checkType<GameObject>(l, 2, out hpgameObject);
			archiveItemDetailInfoController.m_luaExportHelper.m_HPGameObject = hpgameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AC84 RID: 109700 RVA: 0x007FE7AC File Offset: 0x007FC9AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_HPText(IntPtr l)
	{
		int result;
		try
		{
			ArchiveItemDetailInfoController archiveItemDetailInfoController = (ArchiveItemDetailInfoController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, archiveItemDetailInfoController.m_luaExportHelper.m_HPText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AC85 RID: 109701 RVA: 0x007FE804 File Offset: 0x007FCA04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_HPText(IntPtr l)
	{
		int result;
		try
		{
			ArchiveItemDetailInfoController archiveItemDetailInfoController = (ArchiveItemDetailInfoController)LuaObject.checkSelf(l);
			Text hptext;
			LuaObject.checkType<Text>(l, 2, out hptext);
			archiveItemDetailInfoController.m_luaExportHelper.m_HPText = hptext;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AC86 RID: 109702 RVA: 0x007FE860 File Offset: 0x007FCA60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_ATGameObject(IntPtr l)
	{
		int result;
		try
		{
			ArchiveItemDetailInfoController archiveItemDetailInfoController = (ArchiveItemDetailInfoController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, archiveItemDetailInfoController.m_luaExportHelper.m_ATGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AC87 RID: 109703 RVA: 0x007FE8B8 File Offset: 0x007FCAB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_ATGameObject(IntPtr l)
	{
		int result;
		try
		{
			ArchiveItemDetailInfoController archiveItemDetailInfoController = (ArchiveItemDetailInfoController)LuaObject.checkSelf(l);
			GameObject atgameObject;
			LuaObject.checkType<GameObject>(l, 2, out atgameObject);
			archiveItemDetailInfoController.m_luaExportHelper.m_ATGameObject = atgameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AC88 RID: 109704 RVA: 0x007FE914 File Offset: 0x007FCB14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_ATText(IntPtr l)
	{
		int result;
		try
		{
			ArchiveItemDetailInfoController archiveItemDetailInfoController = (ArchiveItemDetailInfoController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, archiveItemDetailInfoController.m_luaExportHelper.m_ATText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AC89 RID: 109705 RVA: 0x007FE96C File Offset: 0x007FCB6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_ATText(IntPtr l)
	{
		int result;
		try
		{
			ArchiveItemDetailInfoController archiveItemDetailInfoController = (ArchiveItemDetailInfoController)LuaObject.checkSelf(l);
			Text attext;
			LuaObject.checkType<Text>(l, 2, out attext);
			archiveItemDetailInfoController.m_luaExportHelper.m_ATText = attext;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AC8A RID: 109706 RVA: 0x007FE9C8 File Offset: 0x007FCBC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_DFGameObject(IntPtr l)
	{
		int result;
		try
		{
			ArchiveItemDetailInfoController archiveItemDetailInfoController = (ArchiveItemDetailInfoController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, archiveItemDetailInfoController.m_luaExportHelper.m_DFGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AC8B RID: 109707 RVA: 0x007FEA20 File Offset: 0x007FCC20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_DFGameObject(IntPtr l)
	{
		int result;
		try
		{
			ArchiveItemDetailInfoController archiveItemDetailInfoController = (ArchiveItemDetailInfoController)LuaObject.checkSelf(l);
			GameObject dfgameObject;
			LuaObject.checkType<GameObject>(l, 2, out dfgameObject);
			archiveItemDetailInfoController.m_luaExportHelper.m_DFGameObject = dfgameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AC8C RID: 109708 RVA: 0x007FEA7C File Offset: 0x007FCC7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_DFText(IntPtr l)
	{
		int result;
		try
		{
			ArchiveItemDetailInfoController archiveItemDetailInfoController = (ArchiveItemDetailInfoController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, archiveItemDetailInfoController.m_luaExportHelper.m_DFText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AC8D RID: 109709 RVA: 0x007FEAD4 File Offset: 0x007FCCD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_DFText(IntPtr l)
	{
		int result;
		try
		{
			ArchiveItemDetailInfoController archiveItemDetailInfoController = (ArchiveItemDetailInfoController)LuaObject.checkSelf(l);
			Text dftext;
			LuaObject.checkType<Text>(l, 2, out dftext);
			archiveItemDetailInfoController.m_luaExportHelper.m_DFText = dftext;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AC8E RID: 109710 RVA: 0x007FEB30 File Offset: 0x007FCD30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_MagicDFGameObject(IntPtr l)
	{
		int result;
		try
		{
			ArchiveItemDetailInfoController archiveItemDetailInfoController = (ArchiveItemDetailInfoController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, archiveItemDetailInfoController.m_luaExportHelper.m_MagicDFGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AC8F RID: 109711 RVA: 0x007FEB88 File Offset: 0x007FCD88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_MagicDFGameObject(IntPtr l)
	{
		int result;
		try
		{
			ArchiveItemDetailInfoController archiveItemDetailInfoController = (ArchiveItemDetailInfoController)LuaObject.checkSelf(l);
			GameObject magicDFGameObject;
			LuaObject.checkType<GameObject>(l, 2, out magicDFGameObject);
			archiveItemDetailInfoController.m_luaExportHelper.m_MagicDFGameObject = magicDFGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AC90 RID: 109712 RVA: 0x007FEBE4 File Offset: 0x007FCDE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_MagicDFText(IntPtr l)
	{
		int result;
		try
		{
			ArchiveItemDetailInfoController archiveItemDetailInfoController = (ArchiveItemDetailInfoController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, archiveItemDetailInfoController.m_luaExportHelper.m_MagicDFText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AC91 RID: 109713 RVA: 0x007FEC3C File Offset: 0x007FCE3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_MagicDFText(IntPtr l)
	{
		int result;
		try
		{
			ArchiveItemDetailInfoController archiveItemDetailInfoController = (ArchiveItemDetailInfoController)LuaObject.checkSelf(l);
			Text magicDFText;
			LuaObject.checkType<Text>(l, 2, out magicDFText);
			archiveItemDetailInfoController.m_luaExportHelper.m_MagicDFText = magicDFText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AC92 RID: 109714 RVA: 0x007FEC98 File Offset: 0x007FCE98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_MagicGameObject(IntPtr l)
	{
		int result;
		try
		{
			ArchiveItemDetailInfoController archiveItemDetailInfoController = (ArchiveItemDetailInfoController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, archiveItemDetailInfoController.m_luaExportHelper.m_MagicGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AC93 RID: 109715 RVA: 0x007FECF0 File Offset: 0x007FCEF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_MagicGameObject(IntPtr l)
	{
		int result;
		try
		{
			ArchiveItemDetailInfoController archiveItemDetailInfoController = (ArchiveItemDetailInfoController)LuaObject.checkSelf(l);
			GameObject magicGameObject;
			LuaObject.checkType<GameObject>(l, 2, out magicGameObject);
			archiveItemDetailInfoController.m_luaExportHelper.m_MagicGameObject = magicGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AC94 RID: 109716 RVA: 0x007FED4C File Offset: 0x007FCF4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_MagicText(IntPtr l)
	{
		int result;
		try
		{
			ArchiveItemDetailInfoController archiveItemDetailInfoController = (ArchiveItemDetailInfoController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, archiveItemDetailInfoController.m_luaExportHelper.m_MagicText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AC95 RID: 109717 RVA: 0x007FEDA4 File Offset: 0x007FCFA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_MagicText(IntPtr l)
	{
		int result;
		try
		{
			ArchiveItemDetailInfoController archiveItemDetailInfoController = (ArchiveItemDetailInfoController)LuaObject.checkSelf(l);
			Text magicText;
			LuaObject.checkType<Text>(l, 2, out magicText);
			archiveItemDetailInfoController.m_luaExportHelper.m_MagicText = magicText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AC96 RID: 109718 RVA: 0x007FEE00 File Offset: 0x007FD000
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_DexGameObject(IntPtr l)
	{
		int result;
		try
		{
			ArchiveItemDetailInfoController archiveItemDetailInfoController = (ArchiveItemDetailInfoController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, archiveItemDetailInfoController.m_luaExportHelper.m_DexGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AC97 RID: 109719 RVA: 0x007FEE58 File Offset: 0x007FD058
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_DexGameObject(IntPtr l)
	{
		int result;
		try
		{
			ArchiveItemDetailInfoController archiveItemDetailInfoController = (ArchiveItemDetailInfoController)LuaObject.checkSelf(l);
			GameObject dexGameObject;
			LuaObject.checkType<GameObject>(l, 2, out dexGameObject);
			archiveItemDetailInfoController.m_luaExportHelper.m_DexGameObject = dexGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AC98 RID: 109720 RVA: 0x007FEEB4 File Offset: 0x007FD0B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_DexText(IntPtr l)
	{
		int result;
		try
		{
			ArchiveItemDetailInfoController archiveItemDetailInfoController = (ArchiveItemDetailInfoController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, archiveItemDetailInfoController.m_luaExportHelper.m_DexText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AC99 RID: 109721 RVA: 0x007FEF0C File Offset: 0x007FD10C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_DexText(IntPtr l)
	{
		int result;
		try
		{
			ArchiveItemDetailInfoController archiveItemDetailInfoController = (ArchiveItemDetailInfoController)LuaObject.checkSelf(l);
			Text dexText;
			LuaObject.checkType<Text>(l, 2, out dexText);
			archiveItemDetailInfoController.m_luaExportHelper.m_DexText = dexText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AC9A RID: 109722 RVA: 0x007FEF68 File Offset: 0x007FD168
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_skillAnimation(IntPtr l)
	{
		int result;
		try
		{
			ArchiveItemDetailInfoController archiveItemDetailInfoController = (ArchiveItemDetailInfoController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, archiveItemDetailInfoController.m_luaExportHelper.m_skillAnimation);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AC9B RID: 109723 RVA: 0x007FEFC0 File Offset: 0x007FD1C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_skillAnimation(IntPtr l)
	{
		int result;
		try
		{
			ArchiveItemDetailInfoController archiveItemDetailInfoController = (ArchiveItemDetailInfoController)LuaObject.checkSelf(l);
			CommonUIStateController skillAnimation;
			LuaObject.checkType<CommonUIStateController>(l, 2, out skillAnimation);
			archiveItemDetailInfoController.m_luaExportHelper.m_skillAnimation = skillAnimation;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AC9C RID: 109724 RVA: 0x007FF01C File Offset: 0x007FD21C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_skillContentAnimation(IntPtr l)
	{
		int result;
		try
		{
			ArchiveItemDetailInfoController archiveItemDetailInfoController = (ArchiveItemDetailInfoController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, archiveItemDetailInfoController.m_luaExportHelper.m_skillContentAnimation);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AC9D RID: 109725 RVA: 0x007FF074 File Offset: 0x007FD274
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_skillContentAnimation(IntPtr l)
	{
		int result;
		try
		{
			ArchiveItemDetailInfoController archiveItemDetailInfoController = (ArchiveItemDetailInfoController)LuaObject.checkSelf(l);
			CommonUIStateController skillContentAnimation;
			LuaObject.checkType<CommonUIStateController>(l, 2, out skillContentAnimation);
			archiveItemDetailInfoController.m_luaExportHelper.m_skillContentAnimation = skillContentAnimation;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AC9E RID: 109726 RVA: 0x007FF0D0 File Offset: 0x007FD2D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_skillBelongText(IntPtr l)
	{
		int result;
		try
		{
			ArchiveItemDetailInfoController archiveItemDetailInfoController = (ArchiveItemDetailInfoController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, archiveItemDetailInfoController.m_luaExportHelper.m_skillBelongText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AC9F RID: 109727 RVA: 0x007FF128 File Offset: 0x007FD328
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_skillBelongText(IntPtr l)
	{
		int result;
		try
		{
			ArchiveItemDetailInfoController archiveItemDetailInfoController = (ArchiveItemDetailInfoController)LuaObject.checkSelf(l);
			Text skillBelongText;
			LuaObject.checkType<Text>(l, 2, out skillBelongText);
			archiveItemDetailInfoController.m_luaExportHelper.m_skillBelongText = skillBelongText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ACA0 RID: 109728 RVA: 0x007FF184 File Offset: 0x007FD384
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_skillBelongBGText(IntPtr l)
	{
		int result;
		try
		{
			ArchiveItemDetailInfoController archiveItemDetailInfoController = (ArchiveItemDetailInfoController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, archiveItemDetailInfoController.m_luaExportHelper.m_skillBelongBGText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ACA1 RID: 109729 RVA: 0x007FF1DC File Offset: 0x007FD3DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_skillBelongBGText(IntPtr l)
	{
		int result;
		try
		{
			ArchiveItemDetailInfoController archiveItemDetailInfoController = (ArchiveItemDetailInfoController)LuaObject.checkSelf(l);
			GameObject skillBelongBGText;
			LuaObject.checkType<GameObject>(l, 2, out skillBelongBGText);
			archiveItemDetailInfoController.m_luaExportHelper.m_skillBelongBGText = skillBelongBGText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ACA2 RID: 109730 RVA: 0x007FF238 File Offset: 0x007FD438
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_skillUnlockConditionText(IntPtr l)
	{
		int result;
		try
		{
			ArchiveItemDetailInfoController archiveItemDetailInfoController = (ArchiveItemDetailInfoController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, archiveItemDetailInfoController.m_luaExportHelper.m_skillUnlockConditionText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ACA3 RID: 109731 RVA: 0x007FF290 File Offset: 0x007FD490
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_skillUnlockConditionText(IntPtr l)
	{
		int result;
		try
		{
			ArchiveItemDetailInfoController archiveItemDetailInfoController = (ArchiveItemDetailInfoController)LuaObject.checkSelf(l);
			Text skillUnlockConditionText;
			LuaObject.checkType<Text>(l, 2, out skillUnlockConditionText);
			archiveItemDetailInfoController.m_luaExportHelper.m_skillUnlockConditionText = skillUnlockConditionText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ACA4 RID: 109732 RVA: 0x007FF2EC File Offset: 0x007FD4EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_skillDescText(IntPtr l)
	{
		int result;
		try
		{
			ArchiveItemDetailInfoController archiveItemDetailInfoController = (ArchiveItemDetailInfoController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, archiveItemDetailInfoController.m_luaExportHelper.m_skillDescText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ACA5 RID: 109733 RVA: 0x007FF344 File Offset: 0x007FD544
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_skillDescText(IntPtr l)
	{
		int result;
		try
		{
			ArchiveItemDetailInfoController archiveItemDetailInfoController = (ArchiveItemDetailInfoController)LuaObject.checkSelf(l);
			Text skillDescText;
			LuaObject.checkType<Text>(l, 2, out skillDescText);
			archiveItemDetailInfoController.m_luaExportHelper.m_skillDescText = skillDescText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ACA6 RID: 109734 RVA: 0x007FF3A0 File Offset: 0x007FD5A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_skillNameText(IntPtr l)
	{
		int result;
		try
		{
			ArchiveItemDetailInfoController archiveItemDetailInfoController = (ArchiveItemDetailInfoController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, archiveItemDetailInfoController.m_luaExportHelper.m_skillNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ACA7 RID: 109735 RVA: 0x007FF3F8 File Offset: 0x007FD5F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_skillNameText(IntPtr l)
	{
		int result;
		try
		{
			ArchiveItemDetailInfoController archiveItemDetailInfoController = (ArchiveItemDetailInfoController)LuaObject.checkSelf(l);
			Text skillNameText;
			LuaObject.checkType<Text>(l, 2, out skillNameText);
			archiveItemDetailInfoController.m_luaExportHelper.m_skillNameText = skillNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ACA8 RID: 109736 RVA: 0x007FF454 File Offset: 0x007FD654
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			ArchiveItemDetailInfoController archiveItemDetailInfoController = (ArchiveItemDetailInfoController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, archiveItemDetailInfoController.m_luaExportHelper.m_playerContext);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ACA9 RID: 109737 RVA: 0x007FF4AC File Offset: 0x007FD6AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			ArchiveItemDetailInfoController archiveItemDetailInfoController = (ArchiveItemDetailInfoController)LuaObject.checkSelf(l);
			ProjectLPlayerContext playerContext;
			LuaObject.checkType<ProjectLPlayerContext>(l, 2, out playerContext);
			archiveItemDetailInfoController.m_luaExportHelper.m_playerContext = playerContext;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ACAA RID: 109738 RVA: 0x007FF508 File Offset: 0x007FD708
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			ArchiveItemDetailInfoController archiveItemDetailInfoController = (ArchiveItemDetailInfoController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, archiveItemDetailInfoController.m_luaExportHelper.m_configDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ACAB RID: 109739 RVA: 0x007FF560 File Offset: 0x007FD760
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			ArchiveItemDetailInfoController archiveItemDetailInfoController = (ArchiveItemDetailInfoController)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			archiveItemDetailInfoController.m_luaExportHelper.m_configDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ACAC RID: 109740 RVA: 0x007FF5BC File Offset: 0x007FD7BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_equipmentInfoWrap(IntPtr l)
	{
		int result;
		try
		{
			ArchiveItemDetailInfoController archiveItemDetailInfoController = (ArchiveItemDetailInfoController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, archiveItemDetailInfoController.m_luaExportHelper.m_equipmentInfoWrap);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ACAD RID: 109741 RVA: 0x007FF614 File Offset: 0x007FD814
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_equipmentInfoWrap(IntPtr l)
	{
		int result;
		try
		{
			ArchiveItemDetailInfoController archiveItemDetailInfoController = (ArchiveItemDetailInfoController)LuaObject.checkSelf(l);
			EquipmentArchiveUIController.EquipmentInfoWrap equipmentInfoWrap;
			LuaObject.checkType<EquipmentArchiveUIController.EquipmentInfoWrap>(l, 2, out equipmentInfoWrap);
			archiveItemDetailInfoController.m_luaExportHelper.m_equipmentInfoWrap = equipmentInfoWrap;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ACAE RID: 109742 RVA: 0x007FF670 File Offset: 0x007FD870
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.ArchiveItemDetailInfoController");
		if (Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.SetData);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.Refresh);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.ClosePropDisplay);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.SetEquipmentPropItem);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache11);
		string name = "m_nameText";
		if (Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.get_m_nameText);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache12;
		if (Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.set_m_nameText);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache13, true);
		string name2 = "m_itemIamge";
		if (Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.get_m_itemIamge);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache14;
		if (Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.set_m_itemIamge);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache15, true);
		string name3 = "m_equipLimitGroupAnimation";
		if (Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.get_m_equipLimitGroupAnimation);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache16;
		if (Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.set_m_equipLimitGroupAnimation);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache17, true);
		string name4 = "m_equipLimitContent";
		if (Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.get_m_equipLimitContent);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache18;
		if (Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.set_m_equipLimitContent);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache19, true);
		string name5 = "m_descEquipUnlimitText";
		if (Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.get_m_descEquipUnlimitText);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache1A;
		if (Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.set_m_descEquipUnlimitText);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache1B, true);
		string name6 = "m_equipmentExplain";
		if (Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.get_m_equipmentExplain);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache1C;
		if (Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.set_m_equipmentExplain);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache1D, true);
		string name7 = "m_HPGameObject";
		if (Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.get_m_HPGameObject);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache1E;
		if (Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.set_m_HPGameObject);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache1F, true);
		string name8 = "m_HPText";
		if (Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.get_m_HPText);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache20;
		if (Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.set_m_HPText);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache21, true);
		string name9 = "m_ATGameObject";
		if (Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.get_m_ATGameObject);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache22;
		if (Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.set_m_ATGameObject);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache23, true);
		string name10 = "m_ATText";
		if (Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.get_m_ATText);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache24;
		if (Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.set_m_ATText);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache25, true);
		string name11 = "m_DFGameObject";
		if (Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.get_m_DFGameObject);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache26;
		if (Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.set_m_DFGameObject);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache27, true);
		string name12 = "m_DFText";
		if (Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.get_m_DFText);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache28;
		if (Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.set_m_DFText);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache29, true);
		string name13 = "m_MagicDFGameObject";
		if (Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.get_m_MagicDFGameObject);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache2A;
		if (Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.set_m_MagicDFGameObject);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache2B, true);
		string name14 = "m_MagicDFText";
		if (Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.get_m_MagicDFText);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache2C;
		if (Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.set_m_MagicDFText);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache2D, true);
		string name15 = "m_MagicGameObject";
		if (Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.get_m_MagicGameObject);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache2E;
		if (Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.set_m_MagicGameObject);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache2F, true);
		string name16 = "m_MagicText";
		if (Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.get_m_MagicText);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache30;
		if (Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.set_m_MagicText);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache31, true);
		string name17 = "m_DexGameObject";
		if (Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.get_m_DexGameObject);
		}
		LuaCSFunction get17 = Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache32;
		if (Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.set_m_DexGameObject);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache33, true);
		string name18 = "m_DexText";
		if (Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.get_m_DexText);
		}
		LuaCSFunction get18 = Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache34;
		if (Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.set_m_DexText);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache35, true);
		string name19 = "m_skillAnimation";
		if (Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.get_m_skillAnimation);
		}
		LuaCSFunction get19 = Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache36;
		if (Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.set_m_skillAnimation);
		}
		LuaObject.addMember(l, name19, get19, Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache37, true);
		string name20 = "m_skillContentAnimation";
		if (Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.get_m_skillContentAnimation);
		}
		LuaCSFunction get20 = Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache38;
		if (Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.set_m_skillContentAnimation);
		}
		LuaObject.addMember(l, name20, get20, Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache39, true);
		string name21 = "m_skillBelongText";
		if (Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.get_m_skillBelongText);
		}
		LuaCSFunction get21 = Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache3A;
		if (Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.set_m_skillBelongText);
		}
		LuaObject.addMember(l, name21, get21, Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache3B, true);
		string name22 = "m_skillBelongBGText";
		if (Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.get_m_skillBelongBGText);
		}
		LuaCSFunction get22 = Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache3C;
		if (Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.set_m_skillBelongBGText);
		}
		LuaObject.addMember(l, name22, get22, Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache3D, true);
		string name23 = "m_skillUnlockConditionText";
		if (Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.get_m_skillUnlockConditionText);
		}
		LuaCSFunction get23 = Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache3E;
		if (Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.set_m_skillUnlockConditionText);
		}
		LuaObject.addMember(l, name23, get23, Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache3F, true);
		string name24 = "m_skillDescText";
		if (Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.get_m_skillDescText);
		}
		LuaCSFunction get24 = Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache40;
		if (Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.set_m_skillDescText);
		}
		LuaObject.addMember(l, name24, get24, Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache41, true);
		string name25 = "m_skillNameText";
		if (Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.get_m_skillNameText);
		}
		LuaCSFunction get25 = Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache42;
		if (Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.set_m_skillNameText);
		}
		LuaObject.addMember(l, name25, get25, Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache43, true);
		string name26 = "m_playerContext";
		if (Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.get_m_playerContext);
		}
		LuaCSFunction get26 = Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache44;
		if (Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.set_m_playerContext);
		}
		LuaObject.addMember(l, name26, get26, Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache45, true);
		string name27 = "m_configDataLoader";
		if (Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache46 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache46 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.get_m_configDataLoader);
		}
		LuaCSFunction get27 = Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache46;
		if (Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache47 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache47 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.set_m_configDataLoader);
		}
		LuaObject.addMember(l, name27, get27, Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache47, true);
		string name28 = "m_equipmentInfoWrap";
		if (Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache48 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache48 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.get_m_equipmentInfoWrap);
		}
		LuaCSFunction get28 = Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache48;
		if (Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache49 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache49 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.set_m_equipmentInfoWrap);
		}
		LuaObject.addMember(l, name28, get28, Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.<>f__mg$cache49, true);
		LuaObject.createTypeMetatable(l, null, typeof(ArchiveItemDetailInfoController), typeof(UIControllerBase));
	}

	// Token: 0x04010F7C RID: 69500
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04010F7D RID: 69501
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04010F7E RID: 69502
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04010F7F RID: 69503
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04010F80 RID: 69504
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04010F81 RID: 69505
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04010F82 RID: 69506
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04010F83 RID: 69507
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04010F84 RID: 69508
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04010F85 RID: 69509
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04010F86 RID: 69510
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04010F87 RID: 69511
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04010F88 RID: 69512
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04010F89 RID: 69513
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04010F8A RID: 69514
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04010F8B RID: 69515
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04010F8C RID: 69516
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04010F8D RID: 69517
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04010F8E RID: 69518
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04010F8F RID: 69519
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04010F90 RID: 69520
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04010F91 RID: 69521
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04010F92 RID: 69522
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04010F93 RID: 69523
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04010F94 RID: 69524
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04010F95 RID: 69525
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04010F96 RID: 69526
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04010F97 RID: 69527
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04010F98 RID: 69528
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04010F99 RID: 69529
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04010F9A RID: 69530
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04010F9B RID: 69531
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04010F9C RID: 69532
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04010F9D RID: 69533
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04010F9E RID: 69534
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04010F9F RID: 69535
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04010FA0 RID: 69536
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04010FA1 RID: 69537
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04010FA2 RID: 69538
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04010FA3 RID: 69539
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04010FA4 RID: 69540
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04010FA5 RID: 69541
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04010FA6 RID: 69542
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04010FA7 RID: 69543
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04010FA8 RID: 69544
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04010FA9 RID: 69545
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04010FAA RID: 69546
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04010FAB RID: 69547
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04010FAC RID: 69548
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04010FAD RID: 69549
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04010FAE RID: 69550
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x04010FAF RID: 69551
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x04010FB0 RID: 69552
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x04010FB1 RID: 69553
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x04010FB2 RID: 69554
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x04010FB3 RID: 69555
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x04010FB4 RID: 69556
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x04010FB5 RID: 69557
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x04010FB6 RID: 69558
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x04010FB7 RID: 69559
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x04010FB8 RID: 69560
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x04010FB9 RID: 69561
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x04010FBA RID: 69562
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x04010FBB RID: 69563
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x04010FBC RID: 69564
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x04010FBD RID: 69565
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x04010FBE RID: 69566
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x04010FBF RID: 69567
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x04010FC0 RID: 69568
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x04010FC1 RID: 69569
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x04010FC2 RID: 69570
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;

	// Token: 0x04010FC3 RID: 69571
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache47;

	// Token: 0x04010FC4 RID: 69572
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache48;

	// Token: 0x04010FC5 RID: 69573
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache49;
}
