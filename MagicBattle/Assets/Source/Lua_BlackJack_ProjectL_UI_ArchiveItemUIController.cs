using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x02001366 RID: 4966
[Preserve]
public class Lua_BlackJack_ProjectL_UI_ArchiveItemUIController : LuaObject
{
	// Token: 0x0601ACB0 RID: 109744 RVA: 0x008000CC File Offset: 0x007FE2CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetEquipmentInfo(IntPtr l)
	{
		int result;
		try
		{
			ArchiveItemUIController archiveItemUIController = (ArchiveItemUIController)LuaObject.checkSelf(l);
			EquipmentArchiveUIController.EquipmentInfoWrap equipmentInfo;
			LuaObject.checkType<EquipmentArchiveUIController.EquipmentInfoWrap>(l, 2, out equipmentInfo);
			archiveItemUIController.SetEquipmentInfo(equipmentInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ACB1 RID: 109745 RVA: 0x00800124 File Offset: 0x007FE324
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Refresh(IntPtr l)
	{
		int result;
		try
		{
			ArchiveItemUIController archiveItemUIController = (ArchiveItemUIController)LuaObject.checkSelf(l);
			archiveItemUIController.Refresh();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ACB2 RID: 109746 RVA: 0x00800170 File Offset: 0x007FE370
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnItemClick(IntPtr l)
	{
		int result;
		try
		{
			ArchiveItemUIController archiveItemUIController = (ArchiveItemUIController)LuaObject.checkSelf(l);
			archiveItemUIController.OnItemClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ACB3 RID: 109747 RVA: 0x008001BC File Offset: 0x007FE3BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetSelected(IntPtr l)
	{
		int result;
		try
		{
			ArchiveItemUIController archiveItemUIController = (ArchiveItemUIController)LuaObject.checkSelf(l);
			bool selected;
			LuaObject.checkType(l, 2, out selected);
			archiveItemUIController.SetSelected(selected);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ACB4 RID: 109748 RVA: 0x00800214 File Offset: 0x007FE414
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			ArchiveItemUIController archiveItemUIController = (ArchiveItemUIController)LuaObject.checkSelf(l);
			archiveItemUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ACB5 RID: 109749 RVA: 0x00800268 File Offset: 0x007FE468
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			ArchiveItemUIController archiveItemUIController = (ArchiveItemUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			archiveItemUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ACB6 RID: 109750 RVA: 0x008002D4 File Offset: 0x007FE4D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			ArchiveItemUIController archiveItemUIController = (ArchiveItemUIController)LuaObject.checkSelf(l);
			archiveItemUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ACB7 RID: 109751 RVA: 0x00800328 File Offset: 0x007FE528
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			ArchiveItemUIController archiveItemUIController = (ArchiveItemUIController)LuaObject.checkSelf(l);
			archiveItemUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ACB8 RID: 109752 RVA: 0x0080037C File Offset: 0x007FE57C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			ArchiveItemUIController archiveItemUIController = (ArchiveItemUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = archiveItemUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601ACB9 RID: 109753 RVA: 0x00800424 File Offset: 0x007FE624
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			ArchiveItemUIController archiveItemUIController = (ArchiveItemUIController)LuaObject.checkSelf(l);
			archiveItemUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ACBA RID: 109754 RVA: 0x00800478 File Offset: 0x007FE678
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ArchiveItemUIController archiveItemUIController = (ArchiveItemUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			archiveItemUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ACBB RID: 109755 RVA: 0x008004E4 File Offset: 0x007FE6E4
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
				ArchiveItemUIController archiveItemUIController = (ArchiveItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				archiveItemUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				ArchiveItemUIController archiveItemUIController2 = (ArchiveItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				archiveItemUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601ACBC RID: 109756 RVA: 0x008005F4 File Offset: 0x007FE7F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			ArchiveItemUIController archiveItemUIController = (ArchiveItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			archiveItemUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ACBD RID: 109757 RVA: 0x00800660 File Offset: 0x007FE860
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			ArchiveItemUIController archiveItemUIController = (ArchiveItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			archiveItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ACBE RID: 109758 RVA: 0x008006CC File Offset: 0x007FE8CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			ArchiveItemUIController archiveItemUIController = (ArchiveItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			archiveItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ACBF RID: 109759 RVA: 0x00800738 File Offset: 0x007FE938
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			ArchiveItemUIController archiveItemUIController = (ArchiveItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			archiveItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ACC0 RID: 109760 RVA: 0x008007A4 File Offset: 0x007FE9A4
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
				ArchiveItemUIController archiveItemUIController = (ArchiveItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				archiveItemUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				ArchiveItemUIController archiveItemUIController2 = (ArchiveItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				archiveItemUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601ACC1 RID: 109761 RVA: 0x008008B4 File Offset: 0x007FEAB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			ArchiveItemUIController archiveItemUIController = (ArchiveItemUIController)LuaObject.checkSelf(l);
			string s = archiveItemUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601ACC2 RID: 109762 RVA: 0x00800910 File Offset: 0x007FEB10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_OnItemClickEvent(IntPtr l)
	{
		int result;
		try
		{
			ArchiveItemUIController archiveItemUIController = (ArchiveItemUIController)LuaObject.checkSelf(l);
			ArchiveItemUIController obj;
			LuaObject.checkType<ArchiveItemUIController>(l, 2, out obj);
			archiveItemUIController.m_luaExportHelper.__callDele_OnItemClickEvent(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ACC3 RID: 109763 RVA: 0x0080096C File Offset: 0x007FEB6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_OnItemClickEvent(IntPtr l)
	{
		int result;
		try
		{
			ArchiveItemUIController archiveItemUIController = (ArchiveItemUIController)LuaObject.checkSelf(l);
			ArchiveItemUIController obj;
			LuaObject.checkType<ArchiveItemUIController>(l, 2, out obj);
			archiveItemUIController.m_luaExportHelper.__clearDele_OnItemClickEvent(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ACC4 RID: 109764 RVA: 0x008009C8 File Offset: 0x007FEBC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_OnItemClickEvent(IntPtr l)
	{
		int result;
		try
		{
			ArchiveItemUIController archiveItemUIController = (ArchiveItemUIController)LuaObject.checkSelf(l);
			Action<ArchiveItemUIController> value;
			int num = LuaObject.checkDelegate<Action<ArchiveItemUIController>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					archiveItemUIController.OnItemClickEvent += value;
				}
				else if (num == 2)
				{
					archiveItemUIController.OnItemClickEvent -= value;
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

	// Token: 0x0601ACC5 RID: 109765 RVA: 0x00800A48 File Offset: 0x007FEC48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_ItemButton(IntPtr l)
	{
		int result;
		try
		{
			ArchiveItemUIController archiveItemUIController = (ArchiveItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, archiveItemUIController.m_luaExportHelper.m_ItemButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ACC6 RID: 109766 RVA: 0x00800AA0 File Offset: 0x007FECA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_ItemButton(IntPtr l)
	{
		int result;
		try
		{
			ArchiveItemUIController archiveItemUIController = (ArchiveItemUIController)LuaObject.checkSelf(l);
			Button itemButton;
			LuaObject.checkType<Button>(l, 2, out itemButton);
			archiveItemUIController.m_luaExportHelper.m_ItemButton = itemButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ACC7 RID: 109767 RVA: 0x00800AFC File Offset: 0x007FECFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_selectImage(IntPtr l)
	{
		int result;
		try
		{
			ArchiveItemUIController archiveItemUIController = (ArchiveItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, archiveItemUIController.m_luaExportHelper.m_selectImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ACC8 RID: 109768 RVA: 0x00800B54 File Offset: 0x007FED54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_selectImage(IntPtr l)
	{
		int result;
		try
		{
			ArchiveItemUIController archiveItemUIController = (ArchiveItemUIController)LuaObject.checkSelf(l);
			Image selectImage;
			LuaObject.checkType<Image>(l, 2, out selectImage);
			archiveItemUIController.m_luaExportHelper.m_selectImage = selectImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ACC9 RID: 109769 RVA: 0x00800BB0 File Offset: 0x007FEDB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_bgImage(IntPtr l)
	{
		int result;
		try
		{
			ArchiveItemUIController archiveItemUIController = (ArchiveItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, archiveItemUIController.m_luaExportHelper.m_bgImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ACCA RID: 109770 RVA: 0x00800C08 File Offset: 0x007FEE08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_bgImage(IntPtr l)
	{
		int result;
		try
		{
			ArchiveItemUIController archiveItemUIController = (ArchiveItemUIController)LuaObject.checkSelf(l);
			Image bgImage;
			LuaObject.checkType<Image>(l, 2, out bgImage);
			archiveItemUIController.m_luaExportHelper.m_bgImage = bgImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ACCB RID: 109771 RVA: 0x00800C64 File Offset: 0x007FEE64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_iconImage(IntPtr l)
	{
		int result;
		try
		{
			ArchiveItemUIController archiveItemUIController = (ArchiveItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, archiveItemUIController.m_luaExportHelper.m_iconImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ACCC RID: 109772 RVA: 0x00800CBC File Offset: 0x007FEEBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_iconImage(IntPtr l)
	{
		int result;
		try
		{
			ArchiveItemUIController archiveItemUIController = (ArchiveItemUIController)LuaObject.checkSelf(l);
			Image iconImage;
			LuaObject.checkType<Image>(l, 2, out iconImage);
			archiveItemUIController.m_luaExportHelper.m_iconImage = iconImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ACCD RID: 109773 RVA: 0x00800D18 File Offset: 0x007FEF18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_ssrEffect(IntPtr l)
	{
		int result;
		try
		{
			ArchiveItemUIController archiveItemUIController = (ArchiveItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, archiveItemUIController.m_luaExportHelper.m_ssrEffect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ACCE RID: 109774 RVA: 0x00800D70 File Offset: 0x007FEF70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_ssrEffect(IntPtr l)
	{
		int result;
		try
		{
			ArchiveItemUIController archiveItemUIController = (ArchiveItemUIController)LuaObject.checkSelf(l);
			GameObject ssrEffect;
			LuaObject.checkType<GameObject>(l, 2, out ssrEffect);
			archiveItemUIController.m_luaExportHelper.m_ssrEffect = ssrEffect;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ACCF RID: 109775 RVA: 0x00800DCC File Offset: 0x007FEFCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_starGroup(IntPtr l)
	{
		int result;
		try
		{
			ArchiveItemUIController archiveItemUIController = (ArchiveItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, archiveItemUIController.m_luaExportHelper.m_starGroup);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ACD0 RID: 109776 RVA: 0x00800E24 File Offset: 0x007FF024
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_starGroup(IntPtr l)
	{
		int result;
		try
		{
			ArchiveItemUIController archiveItemUIController = (ArchiveItemUIController)LuaObject.checkSelf(l);
			GameObject starGroup;
			LuaObject.checkType<GameObject>(l, 2, out starGroup);
			archiveItemUIController.m_luaExportHelper.m_starGroup = starGroup;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ACD1 RID: 109777 RVA: 0x00800E80 File Offset: 0x007FF080
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_darkCoverImage(IntPtr l)
	{
		int result;
		try
		{
			ArchiveItemUIController archiveItemUIController = (ArchiveItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, archiveItemUIController.m_luaExportHelper.m_darkCoverImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ACD2 RID: 109778 RVA: 0x00800ED8 File Offset: 0x007FF0D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_darkCoverImage(IntPtr l)
	{
		int result;
		try
		{
			ArchiveItemUIController archiveItemUIController = (ArchiveItemUIController)LuaObject.checkSelf(l);
			GameObject darkCoverImage;
			LuaObject.checkType<GameObject>(l, 2, out darkCoverImage);
			archiveItemUIController.m_luaExportHelper.m_darkCoverImage = darkCoverImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ACD3 RID: 109779 RVA: 0x00800F34 File Offset: 0x007FF134
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_equipmentInfoWrap(IntPtr l)
	{
		int result;
		try
		{
			ArchiveItemUIController archiveItemUIController = (ArchiveItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, archiveItemUIController.m_equipmentInfoWrap);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ACD4 RID: 109780 RVA: 0x00800F88 File Offset: 0x007FF188
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_equipmentInfoWrap(IntPtr l)
	{
		int result;
		try
		{
			ArchiveItemUIController archiveItemUIController = (ArchiveItemUIController)LuaObject.checkSelf(l);
			EquipmentArchiveUIController.EquipmentInfoWrap equipmentInfoWrap;
			LuaObject.checkType<EquipmentArchiveUIController.EquipmentInfoWrap>(l, 2, out equipmentInfoWrap);
			archiveItemUIController.m_equipmentInfoWrap = equipmentInfoWrap;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ACD5 RID: 109781 RVA: 0x00800FE0 File Offset: 0x007FF1E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_SSRRank(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, ArchiveItemUIController.LuaExportHelper.SSRRank);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ACD6 RID: 109782 RVA: 0x00801028 File Offset: 0x007FF228
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.ArchiveItemUIController");
		if (Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.SetEquipmentInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.Refresh);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.OnItemClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.SetSelected);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.__callDele_OnItemClickEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.__clearDele_OnItemClickEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.<>f__mg$cache13);
		string name = "OnItemClickEvent";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.set_OnItemClickEvent);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.<>f__mg$cache14, true);
		string name2 = "m_ItemButton";
		if (Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.get_m_ItemButton);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.<>f__mg$cache15;
		if (Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.set_m_ItemButton);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.<>f__mg$cache16, true);
		string name3 = "m_selectImage";
		if (Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.get_m_selectImage);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.<>f__mg$cache17;
		if (Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.set_m_selectImage);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.<>f__mg$cache18, true);
		string name4 = "m_bgImage";
		if (Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.get_m_bgImage);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.<>f__mg$cache19;
		if (Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.set_m_bgImage);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.<>f__mg$cache1A, true);
		string name5 = "m_iconImage";
		if (Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.get_m_iconImage);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.<>f__mg$cache1B;
		if (Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.set_m_iconImage);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.<>f__mg$cache1C, true);
		string name6 = "m_ssrEffect";
		if (Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.get_m_ssrEffect);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.<>f__mg$cache1D;
		if (Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.set_m_ssrEffect);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.<>f__mg$cache1E, true);
		string name7 = "m_starGroup";
		if (Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.get_m_starGroup);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.<>f__mg$cache1F;
		if (Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.set_m_starGroup);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.<>f__mg$cache20, true);
		string name8 = "m_darkCoverImage";
		if (Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.get_m_darkCoverImage);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.<>f__mg$cache21;
		if (Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.set_m_darkCoverImage);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.<>f__mg$cache22, true);
		string name9 = "m_equipmentInfoWrap";
		if (Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.get_m_equipmentInfoWrap);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.<>f__mg$cache23;
		if (Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.set_m_equipmentInfoWrap);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.<>f__mg$cache24, true);
		string name10 = "SSRRank";
		if (Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.get_SSRRank);
		}
		LuaObject.addMember(l, name10, Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.<>f__mg$cache25, null, false);
		LuaObject.createTypeMetatable(l, null, typeof(ArchiveItemUIController), typeof(UIControllerBase));
	}

	// Token: 0x04010FC6 RID: 69574
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04010FC7 RID: 69575
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04010FC8 RID: 69576
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04010FC9 RID: 69577
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04010FCA RID: 69578
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04010FCB RID: 69579
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04010FCC RID: 69580
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04010FCD RID: 69581
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04010FCE RID: 69582
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04010FCF RID: 69583
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04010FD0 RID: 69584
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04010FD1 RID: 69585
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04010FD2 RID: 69586
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04010FD3 RID: 69587
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04010FD4 RID: 69588
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04010FD5 RID: 69589
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04010FD6 RID: 69590
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04010FD7 RID: 69591
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04010FD8 RID: 69592
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04010FD9 RID: 69593
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04010FDA RID: 69594
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04010FDB RID: 69595
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04010FDC RID: 69596
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04010FDD RID: 69597
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04010FDE RID: 69598
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04010FDF RID: 69599
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04010FE0 RID: 69600
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04010FE1 RID: 69601
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04010FE2 RID: 69602
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04010FE3 RID: 69603
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04010FE4 RID: 69604
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04010FE5 RID: 69605
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04010FE6 RID: 69606
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04010FE7 RID: 69607
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04010FE8 RID: 69608
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04010FE9 RID: 69609
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04010FEA RID: 69610
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04010FEB RID: 69611
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;
}
