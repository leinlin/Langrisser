using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x020014B2 RID: 5298
[Preserve]
public class Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController : LuaObject
{
	// Token: 0x0601EC4A RID: 126026 RVA: 0x009F95D4 File Offset: 0x009F77D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateViewInEquipmentState(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			Hero hero;
			LuaObject.checkType<Hero>(l, 2, out hero);
			heroDetailEquipmentUIController.UpdateViewInEquipmentState(hero);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EC4B RID: 126027 RVA: 0x009F962C File Offset: 0x009F782C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetCommonUIState(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			string commonUIState;
			LuaObject.checkType(l, 2, out commonUIState);
			heroDetailEquipmentUIController.SetCommonUIState(commonUIState);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EC4C RID: 126028 RVA: 0x009F9684 File Offset: 0x009F7884
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			heroDetailEquipmentUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EC4D RID: 126029 RVA: 0x009F96D8 File Offset: 0x009F78D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CreateEquipmentList(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			heroDetailEquipmentUIController.m_luaExportHelper.CreateEquipmentList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EC4E RID: 126030 RVA: 0x009F972C File Offset: 0x009F792C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnEquipmentIconClick(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			HeroEquipItemUIController ctrl;
			LuaObject.checkType<HeroEquipItemUIController>(l, 2, out ctrl);
			heroDetailEquipmentUIController.m_luaExportHelper.OnEquipmentIconClick(ctrl);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EC4F RID: 126031 RVA: 0x009F9788 File Offset: 0x009F7988
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnEquipmentAddButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			HeroEquipItemUIController ctrl;
			LuaObject.checkType<HeroEquipItemUIController>(l, 2, out ctrl);
			heroDetailEquipmentUIController.m_luaExportHelper.OnEquipmentAddButtonClick(ctrl);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EC50 RID: 126032 RVA: 0x009F97E4 File Offset: 0x009F79E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HaveEquipmentInBag(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			HeroEquipItemUIController equipmentCtrl;
			LuaObject.checkType<HeroEquipItemUIController>(l, 2, out equipmentCtrl);
			bool b = heroDetailEquipmentUIController.m_luaExportHelper.HaveEquipmentInBag(equipmentCtrl);
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

	// Token: 0x0601EC51 RID: 126033 RVA: 0x009F984C File Offset: 0x009F7A4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnRuneIconButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			HeroEquipItemUIController ctrl;
			LuaObject.checkType<HeroEquipItemUIController>(l, 2, out ctrl);
			heroDetailEquipmentUIController.m_luaExportHelper.OnRuneIconButtonClick(ctrl);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EC52 RID: 126034 RVA: 0x009F98A8 File Offset: 0x009F7AA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetResonanceInfoPanel(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			EquipmentBagItem resonanceInfoPanel;
			LuaObject.checkType<EquipmentBagItem>(l, 2, out resonanceInfoPanel);
			heroDetailEquipmentUIController.m_luaExportHelper.SetResonanceInfoPanel(resonanceInfoPanel);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EC53 RID: 126035 RVA: 0x009F9904 File Offset: 0x009F7B04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CloseResonanceInfoPanel(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			heroDetailEquipmentUIController.m_luaExportHelper.CloseResonanceInfoPanel();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EC54 RID: 126036 RVA: 0x009F9958 File Offset: 0x009F7B58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetEquipmentItemDesc(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			HeroEquipItemUIController equipmentItemDesc;
			LuaObject.checkType<HeroEquipItemUIController>(l, 2, out equipmentItemDesc);
			heroDetailEquipmentUIController.m_luaExportHelper.SetEquipmentItemDesc(equipmentItemDesc);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EC55 RID: 126037 RVA: 0x009F99B4 File Offset: 0x009F7BB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetPropItems(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			PropertyModifyType type;
			LuaObject.checkEnum<PropertyModifyType>(l, 2, out type);
			int value;
			LuaObject.checkType(l, 3, out value);
			int addValue;
			LuaObject.checkType(l, 4, out addValue);
			int level;
			LuaObject.checkType(l, 5, out level);
			heroDetailEquipmentUIController.m_luaExportHelper.SetPropItems(type, value, addValue, level);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EC56 RID: 126038 RVA: 0x009F9A38 File Offset: 0x009F7C38
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnForgeButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			heroDetailEquipmentUIController.m_luaExportHelper.OnForgeButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EC57 RID: 126039 RVA: 0x009F9A8C File Offset: 0x009F7C8C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnEnchantmentButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			heroDetailEquipmentUIController.m_luaExportHelper.OnEnchantmentButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EC58 RID: 126040 RVA: 0x009F9AE0 File Offset: 0x009F7CE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnExchangeButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			heroDetailEquipmentUIController.m_luaExportHelper.OnExchangeButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EC59 RID: 126041 RVA: 0x009F9B34 File Offset: 0x009F7D34
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnAutoEquipButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			heroDetailEquipmentUIController.m_luaExportHelper.OnAutoEquipButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EC5A RID: 126042 RVA: 0x009F9B88 File Offset: 0x009F7D88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnFastRemoveButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			heroDetailEquipmentUIController.m_luaExportHelper.OnFastRemoveButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EC5B RID: 126043 RVA: 0x009F9BDC File Offset: 0x009F7DDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DisableAutoEquipButton(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			IEnumerator o = heroDetailEquipmentUIController.m_luaExportHelper.DisableAutoEquipButton();
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

	// Token: 0x0601EC5C RID: 126044 RVA: 0x009F9C38 File Offset: 0x009F7E38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CloseEquipemntItemDescGo(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			heroDetailEquipmentUIController.m_luaExportHelper.CloseEquipemntItemDescGo();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EC5D RID: 126045 RVA: 0x009F9C8C File Offset: 0x009F7E8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnEquipemntLockButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			heroDetailEquipmentUIController.m_luaExportHelper.OnEquipemntLockButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EC5E RID: 126046 RVA: 0x009F9CE0 File Offset: 0x009F7EE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			heroDetailEquipmentUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EC5F RID: 126047 RVA: 0x009F9D4C File Offset: 0x009F7F4C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			heroDetailEquipmentUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EC60 RID: 126048 RVA: 0x009F9DA0 File Offset: 0x009F7FA0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			heroDetailEquipmentUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EC61 RID: 126049 RVA: 0x009F9DF4 File Offset: 0x009F7FF4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = heroDetailEquipmentUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601EC62 RID: 126050 RVA: 0x009F9E9C File Offset: 0x009F809C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			heroDetailEquipmentUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EC63 RID: 126051 RVA: 0x009F9EF0 File Offset: 0x009F80F0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			heroDetailEquipmentUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EC64 RID: 126052 RVA: 0x009F9F5C File Offset: 0x009F815C
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
				HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				heroDetailEquipmentUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				HeroDetailEquipmentUIController heroDetailEquipmentUIController2 = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				heroDetailEquipmentUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601EC65 RID: 126053 RVA: 0x009FA06C File Offset: 0x009F826C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroDetailEquipmentUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EC66 RID: 126054 RVA: 0x009FA0D8 File Offset: 0x009F82D8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroDetailEquipmentUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EC67 RID: 126055 RVA: 0x009FA144 File Offset: 0x009F8344
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroDetailEquipmentUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EC68 RID: 126056 RVA: 0x009FA1B0 File Offset: 0x009F83B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroDetailEquipmentUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EC69 RID: 126057 RVA: 0x009FA21C File Offset: 0x009F841C
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
				HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				heroDetailEquipmentUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				HeroDetailEquipmentUIController heroDetailEquipmentUIController2 = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				heroDetailEquipmentUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601EC6A RID: 126058 RVA: 0x009FA32C File Offset: 0x009F852C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			string s = heroDetailEquipmentUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601EC6B RID: 126059 RVA: 0x009FA388 File Offset: 0x009F8588
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnAutoRemove(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			heroDetailEquipmentUIController.m_luaExportHelper.__callDele_EventOnAutoRemove(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EC6C RID: 126060 RVA: 0x009FA3E4 File Offset: 0x009F85E4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __clearDele_EventOnAutoRemove(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			heroDetailEquipmentUIController.m_luaExportHelper.__clearDele_EventOnAutoRemove(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EC6D RID: 126061 RVA: 0x009FA440 File Offset: 0x009F8640
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnAutoEquip(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			int arg;
			LuaObject.checkType(l, 2, out arg);
			Action arg2;
			LuaObject.checkDelegate<Action>(l, 3, out arg2);
			heroDetailEquipmentUIController.m_luaExportHelper.__callDele_EventOnAutoEquip(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EC6E RID: 126062 RVA: 0x009FA4AC File Offset: 0x009F86AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnAutoEquip(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			int arg;
			LuaObject.checkType(l, 2, out arg);
			Action arg2;
			LuaObject.checkDelegate<Action>(l, 3, out arg2);
			heroDetailEquipmentUIController.m_luaExportHelper.__clearDele_EventOnAutoEquip(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EC6F RID: 126063 RVA: 0x009FA518 File Offset: 0x009F8718
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnGotoEquipmentForge(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			int arg;
			LuaObject.checkType(l, 2, out arg);
			ulong arg2;
			LuaObject.checkType(l, 3, out arg2);
			heroDetailEquipmentUIController.m_luaExportHelper.__callDele_EventOnGotoEquipmentForge(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EC70 RID: 126064 RVA: 0x009FA584 File Offset: 0x009F8784
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnGotoEquipmentForge(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			int arg;
			LuaObject.checkType(l, 2, out arg);
			ulong arg2;
			LuaObject.checkType(l, 3, out arg2);
			heroDetailEquipmentUIController.m_luaExportHelper.__clearDele_EventOnGotoEquipmentForge(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EC71 RID: 126065 RVA: 0x009FA5F0 File Offset: 0x009F87F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnGotoEquipmentStore(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			int arg;
			LuaObject.checkType(l, 2, out arg);
			ulong arg2;
			LuaObject.checkType(l, 3, out arg2);
			heroDetailEquipmentUIController.m_luaExportHelper.__callDele_EventOnGotoEquipmentStore(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EC72 RID: 126066 RVA: 0x009FA65C File Offset: 0x009F885C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __clearDele_EventOnGotoEquipmentStore(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			int arg;
			LuaObject.checkType(l, 2, out arg);
			ulong arg2;
			LuaObject.checkType(l, 3, out arg2);
			heroDetailEquipmentUIController.m_luaExportHelper.__clearDele_EventOnGotoEquipmentStore(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EC73 RID: 126067 RVA: 0x009FA6C8 File Offset: 0x009F88C8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callDele_EventOnLockButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			ulong arg;
			LuaObject.checkType(l, 2, out arg);
			int arg2;
			LuaObject.checkType(l, 3, out arg2);
			Action arg3;
			LuaObject.checkDelegate<Action>(l, 4, out arg3);
			heroDetailEquipmentUIController.m_luaExportHelper.__callDele_EventOnLockButtonClick(arg, arg2, arg3);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EC74 RID: 126068 RVA: 0x009FA740 File Offset: 0x009F8940
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnLockButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			ulong arg;
			LuaObject.checkType(l, 2, out arg);
			int arg2;
			LuaObject.checkType(l, 3, out arg2);
			Action arg3;
			LuaObject.checkDelegate<Action>(l, 4, out arg3);
			heroDetailEquipmentUIController.m_luaExportHelper.__clearDele_EventOnLockButtonClick(arg, arg2, arg3);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EC75 RID: 126069 RVA: 0x009FA7B8 File Offset: 0x009F89B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnAutoRemove(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			Action<int> value;
			int num = LuaObject.checkDelegate<Action<int>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					heroDetailEquipmentUIController.EventOnAutoRemove += value;
				}
				else if (num == 2)
				{
					heroDetailEquipmentUIController.EventOnAutoRemove -= value;
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

	// Token: 0x0601EC76 RID: 126070 RVA: 0x009FA838 File Offset: 0x009F8A38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnAutoEquip(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			Action<int, Action> value;
			int num = LuaObject.checkDelegate<Action<int, Action>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					heroDetailEquipmentUIController.EventOnAutoEquip += value;
				}
				else if (num == 2)
				{
					heroDetailEquipmentUIController.EventOnAutoEquip -= value;
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

	// Token: 0x0601EC77 RID: 126071 RVA: 0x009FA8B8 File Offset: 0x009F8AB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnGotoEquipmentForge(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			Action<int, ulong> value;
			int num = LuaObject.checkDelegate<Action<int, ulong>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					heroDetailEquipmentUIController.EventOnGotoEquipmentForge += value;
				}
				else if (num == 2)
				{
					heroDetailEquipmentUIController.EventOnGotoEquipmentForge -= value;
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

	// Token: 0x0601EC78 RID: 126072 RVA: 0x009FA938 File Offset: 0x009F8B38
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_EventOnGotoEquipmentStore(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			Action<int, ulong> value;
			int num = LuaObject.checkDelegate<Action<int, ulong>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					heroDetailEquipmentUIController.EventOnGotoEquipmentStore += value;
				}
				else if (num == 2)
				{
					heroDetailEquipmentUIController.EventOnGotoEquipmentStore -= value;
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

	// Token: 0x0601EC79 RID: 126073 RVA: 0x009FA9B8 File Offset: 0x009F8BB8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_EventOnLockButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			Action<ulong, int, Action> value;
			int num = LuaObject.checkDelegate<Action<ulong, int, Action>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					heroDetailEquipmentUIController.EventOnLockButtonClick += value;
				}
				else if (num == 2)
				{
					heroDetailEquipmentUIController.EventOnLockButtonClick -= value;
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

	// Token: 0x0601EC7A RID: 126074 RVA: 0x009FAA38 File Offset: 0x009F8C38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_marginTransform(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailEquipmentUIController.m_luaExportHelper.m_marginTransform);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EC7B RID: 126075 RVA: 0x009FAA90 File Offset: 0x009F8C90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_marginTransform(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			RectTransform marginTransform;
			LuaObject.checkType<RectTransform>(l, 2, out marginTransform);
			heroDetailEquipmentUIController.m_luaExportHelper.m_marginTransform = marginTransform;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EC7C RID: 126076 RVA: 0x009FAAEC File Offset: 0x009F8CEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_equipItem(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailEquipmentUIController.m_luaExportHelper.m_equipItem);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EC7D RID: 126077 RVA: 0x009FAB44 File Offset: 0x009F8D44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_equipItem(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			GameObject equipItem;
			LuaObject.checkType<GameObject>(l, 2, out equipItem);
			heroDetailEquipmentUIController.m_luaExportHelper.m_equipItem = equipItem;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EC7E RID: 126078 RVA: 0x009FABA0 File Offset: 0x009F8DA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_equipItem1(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailEquipmentUIController.m_luaExportHelper.m_equipItem1);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EC7F RID: 126079 RVA: 0x009FABF8 File Offset: 0x009F8DF8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_equipItem1(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			GameObject equipItem;
			LuaObject.checkType<GameObject>(l, 2, out equipItem);
			heroDetailEquipmentUIController.m_luaExportHelper.m_equipItem1 = equipItem;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EC80 RID: 126080 RVA: 0x009FAC54 File Offset: 0x009F8E54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_equipItem2(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailEquipmentUIController.m_luaExportHelper.m_equipItem2);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EC81 RID: 126081 RVA: 0x009FACAC File Offset: 0x009F8EAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_equipItem2(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			GameObject equipItem;
			LuaObject.checkType<GameObject>(l, 2, out equipItem);
			heroDetailEquipmentUIController.m_luaExportHelper.m_equipItem2 = equipItem;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EC82 RID: 126082 RVA: 0x009FAD08 File Offset: 0x009F8F08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_equipItem3(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailEquipmentUIController.m_luaExportHelper.m_equipItem3);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EC83 RID: 126083 RVA: 0x009FAD60 File Offset: 0x009F8F60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_equipItem3(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			GameObject equipItem;
			LuaObject.checkType<GameObject>(l, 2, out equipItem);
			heroDetailEquipmentUIController.m_luaExportHelper.m_equipItem3 = equipItem;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EC84 RID: 126084 RVA: 0x009FADBC File Offset: 0x009F8FBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_autoEquipButton(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailEquipmentUIController.m_luaExportHelper.m_autoEquipButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EC85 RID: 126085 RVA: 0x009FAE14 File Offset: 0x009F9014
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_autoEquipButton(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			Button autoEquipButton;
			LuaObject.checkType<Button>(l, 2, out autoEquipButton);
			heroDetailEquipmentUIController.m_luaExportHelper.m_autoEquipButton = autoEquipButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EC86 RID: 126086 RVA: 0x009FAE70 File Offset: 0x009F9070
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_autoEquipButtonNormalBg(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailEquipmentUIController.m_luaExportHelper.m_autoEquipButtonNormalBg);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EC87 RID: 126087 RVA: 0x009FAEC8 File Offset: 0x009F90C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_autoEquipButtonNormalBg(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			GameObject autoEquipButtonNormalBg;
			LuaObject.checkType<GameObject>(l, 2, out autoEquipButtonNormalBg);
			heroDetailEquipmentUIController.m_luaExportHelper.m_autoEquipButtonNormalBg = autoEquipButtonNormalBg;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EC88 RID: 126088 RVA: 0x009FAF24 File Offset: 0x009F9124
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_fastRemoveButton(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailEquipmentUIController.m_luaExportHelper.m_fastRemoveButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EC89 RID: 126089 RVA: 0x009FAF7C File Offset: 0x009F917C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_fastRemoveButton(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			Button fastRemoveButton;
			LuaObject.checkType<Button>(l, 2, out fastRemoveButton);
			heroDetailEquipmentUIController.m_luaExportHelper.m_fastRemoveButton = fastRemoveButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EC8A RID: 126090 RVA: 0x009FAFD8 File Offset: 0x009F91D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_equipItemDescGo(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailEquipmentUIController.m_luaExportHelper.m_equipItemDescGo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EC8B RID: 126091 RVA: 0x009FB030 File Offset: 0x009F9230
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_equipItemDescGo(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			GameObject equipItemDescGo;
			LuaObject.checkType<GameObject>(l, 2, out equipItemDescGo);
			heroDetailEquipmentUIController.m_luaExportHelper.m_equipItemDescGo = equipItemDescGo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EC8C RID: 126092 RVA: 0x009FB08C File Offset: 0x009F928C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_equipItemDescTitleText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailEquipmentUIController.m_luaExportHelper.m_equipItemDescTitleText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EC8D RID: 126093 RVA: 0x009FB0E4 File Offset: 0x009F92E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_equipItemDescTitleText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			Text equipItemDescTitleText;
			LuaObject.checkType<Text>(l, 2, out equipItemDescTitleText);
			heroDetailEquipmentUIController.m_luaExportHelper.m_equipItemDescTitleText = equipItemDescTitleText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EC8E RID: 126094 RVA: 0x009FB140 File Offset: 0x009F9340
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_equipItemDescLvText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailEquipmentUIController.m_luaExportHelper.m_equipItemDescLvText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EC8F RID: 126095 RVA: 0x009FB198 File Offset: 0x009F9398
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_equipItemDescLvText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			Text equipItemDescLvText;
			LuaObject.checkType<Text>(l, 2, out equipItemDescLvText);
			heroDetailEquipmentUIController.m_luaExportHelper.m_equipItemDescLvText = equipItemDescLvText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EC90 RID: 126096 RVA: 0x009FB1F4 File Offset: 0x009F93F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_equipItemDescExpText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailEquipmentUIController.m_luaExportHelper.m_equipItemDescExpText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EC91 RID: 126097 RVA: 0x009FB24C File Offset: 0x009F944C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_equipItemDescExpText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			Text equipItemDescExpText;
			LuaObject.checkType<Text>(l, 2, out equipItemDescExpText);
			heroDetailEquipmentUIController.m_luaExportHelper.m_equipItemDescExpText = equipItemDescExpText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EC92 RID: 126098 RVA: 0x009FB2A8 File Offset: 0x009F94A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_equipItemDescIconImage(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailEquipmentUIController.m_luaExportHelper.m_equipItemDescIconImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EC93 RID: 126099 RVA: 0x009FB300 File Offset: 0x009F9500
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_equipItemDescIconImage(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			Image equipItemDescIconImage;
			LuaObject.checkType<Image>(l, 2, out equipItemDescIconImage);
			heroDetailEquipmentUIController.m_luaExportHelper.m_equipItemDescIconImage = equipItemDescIconImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EC94 RID: 126100 RVA: 0x009FB35C File Offset: 0x009F955C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_equipItemDescIconBg(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailEquipmentUIController.m_luaExportHelper.m_equipItemDescIconBg);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EC95 RID: 126101 RVA: 0x009FB3B4 File Offset: 0x009F95B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_equipItemDescIconBg(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			Image equipItemDescIconBg;
			LuaObject.checkType<Image>(l, 2, out equipItemDescIconBg);
			heroDetailEquipmentUIController.m_luaExportHelper.m_equipItemDescIconBg = equipItemDescIconBg;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EC96 RID: 126102 RVA: 0x009FB410 File Offset: 0x009F9610
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_equipItemDescSSREffect(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailEquipmentUIController.m_luaExportHelper.m_equipItemDescSSREffect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EC97 RID: 126103 RVA: 0x009FB468 File Offset: 0x009F9668
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_equipItemDescSSREffect(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			GameObject equipItemDescSSREffect;
			LuaObject.checkType<GameObject>(l, 2, out equipItemDescSSREffect);
			heroDetailEquipmentUIController.m_luaExportHelper.m_equipItemDescSSREffect = equipItemDescSSREffect;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EC98 RID: 126104 RVA: 0x009FB4C4 File Offset: 0x009F96C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_equipItemDescProgressImage(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailEquipmentUIController.m_luaExportHelper.m_equipItemDescProgressImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EC99 RID: 126105 RVA: 0x009FB51C File Offset: 0x009F971C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_equipItemDescProgressImage(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			Image equipItemDescProgressImage;
			LuaObject.checkType<Image>(l, 2, out equipItemDescProgressImage);
			heroDetailEquipmentUIController.m_luaExportHelper.m_equipItemDescProgressImage = equipItemDescProgressImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EC9A RID: 126106 RVA: 0x009FB578 File Offset: 0x009F9778
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_equipItemDescStarGroup(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailEquipmentUIController.m_luaExportHelper.m_equipItemDescStarGroup);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EC9B RID: 126107 RVA: 0x009FB5D0 File Offset: 0x009F97D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_equipItemDescStarGroup(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			GameObject equipItemDescStarGroup;
			LuaObject.checkType<GameObject>(l, 2, out equipItemDescStarGroup);
			heroDetailEquipmentUIController.m_luaExportHelper.m_equipItemDescStarGroup = equipItemDescStarGroup;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EC9C RID: 126108 RVA: 0x009FB62C File Offset: 0x009F982C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_equipItemDescEquipLimitContent(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailEquipmentUIController.m_luaExportHelper.m_equipItemDescEquipLimitContent);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EC9D RID: 126109 RVA: 0x009FB684 File Offset: 0x009F9884
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_equipItemDescEquipLimitContent(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			GameObject equipItemDescEquipLimitContent;
			LuaObject.checkType<GameObject>(l, 2, out equipItemDescEquipLimitContent);
			heroDetailEquipmentUIController.m_luaExportHelper.m_equipItemDescEquipLimitContent = equipItemDescEquipLimitContent;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EC9E RID: 126110 RVA: 0x009FB6E0 File Offset: 0x009F98E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_descEquipUnlimitText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailEquipmentUIController.m_luaExportHelper.m_descEquipUnlimitText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EC9F RID: 126111 RVA: 0x009FB738 File Offset: 0x009F9938
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_descEquipUnlimitText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			Text descEquipUnlimitText;
			LuaObject.checkType<Text>(l, 2, out descEquipUnlimitText);
			heroDetailEquipmentUIController.m_luaExportHelper.m_descEquipUnlimitText = descEquipUnlimitText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ECA0 RID: 126112 RVA: 0x009FB794 File Offset: 0x009F9994
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_equipItemDescPropContent(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailEquipmentUIController.m_luaExportHelper.m_equipItemDescPropContent);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ECA1 RID: 126113 RVA: 0x009FB7EC File Offset: 0x009F99EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_equipItemDescPropContent(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			GameObject equipItemDescPropContent;
			LuaObject.checkType<GameObject>(l, 2, out equipItemDescPropContent);
			heroDetailEquipmentUIController.m_luaExportHelper.m_equipItemDescPropContent = equipItemDescPropContent;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ECA2 RID: 126114 RVA: 0x009FB848 File Offset: 0x009F9A48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_equipItemDescPropATGo(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailEquipmentUIController.m_luaExportHelper.m_equipItemDescPropATGo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ECA3 RID: 126115 RVA: 0x009FB8A0 File Offset: 0x009F9AA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_equipItemDescPropATGo(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			GameObject equipItemDescPropATGo;
			LuaObject.checkType<GameObject>(l, 2, out equipItemDescPropATGo);
			heroDetailEquipmentUIController.m_luaExportHelper.m_equipItemDescPropATGo = equipItemDescPropATGo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ECA4 RID: 126116 RVA: 0x009FB8FC File Offset: 0x009F9AFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_equipItemDescPropATValueText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailEquipmentUIController.m_luaExportHelper.m_equipItemDescPropATValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ECA5 RID: 126117 RVA: 0x009FB954 File Offset: 0x009F9B54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_equipItemDescPropATValueText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			Text equipItemDescPropATValueText;
			LuaObject.checkType<Text>(l, 2, out equipItemDescPropATValueText);
			heroDetailEquipmentUIController.m_luaExportHelper.m_equipItemDescPropATValueText = equipItemDescPropATValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ECA6 RID: 126118 RVA: 0x009FB9B0 File Offset: 0x009F9BB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_equipItemDescPropDFGo(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailEquipmentUIController.m_luaExportHelper.m_equipItemDescPropDFGo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ECA7 RID: 126119 RVA: 0x009FBA08 File Offset: 0x009F9C08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_equipItemDescPropDFGo(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			GameObject equipItemDescPropDFGo;
			LuaObject.checkType<GameObject>(l, 2, out equipItemDescPropDFGo);
			heroDetailEquipmentUIController.m_luaExportHelper.m_equipItemDescPropDFGo = equipItemDescPropDFGo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ECA8 RID: 126120 RVA: 0x009FBA64 File Offset: 0x009F9C64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_equipItemDescPropDFValueText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailEquipmentUIController.m_luaExportHelper.m_equipItemDescPropDFValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ECA9 RID: 126121 RVA: 0x009FBABC File Offset: 0x009F9CBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_equipItemDescPropDFValueText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			Text equipItemDescPropDFValueText;
			LuaObject.checkType<Text>(l, 2, out equipItemDescPropDFValueText);
			heroDetailEquipmentUIController.m_luaExportHelper.m_equipItemDescPropDFValueText = equipItemDescPropDFValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ECAA RID: 126122 RVA: 0x009FBB18 File Offset: 0x009F9D18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_equipItemDescPropHPGo(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailEquipmentUIController.m_luaExportHelper.m_equipItemDescPropHPGo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ECAB RID: 126123 RVA: 0x009FBB70 File Offset: 0x009F9D70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_equipItemDescPropHPGo(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			GameObject equipItemDescPropHPGo;
			LuaObject.checkType<GameObject>(l, 2, out equipItemDescPropHPGo);
			heroDetailEquipmentUIController.m_luaExportHelper.m_equipItemDescPropHPGo = equipItemDescPropHPGo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ECAC RID: 126124 RVA: 0x009FBBCC File Offset: 0x009F9DCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_equipItemDescPropHPValueText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailEquipmentUIController.m_luaExportHelper.m_equipItemDescPropHPValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ECAD RID: 126125 RVA: 0x009FBC24 File Offset: 0x009F9E24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_equipItemDescPropHPValueText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			Text equipItemDescPropHPValueText;
			LuaObject.checkType<Text>(l, 2, out equipItemDescPropHPValueText);
			heroDetailEquipmentUIController.m_luaExportHelper.m_equipItemDescPropHPValueText = equipItemDescPropHPValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ECAE RID: 126126 RVA: 0x009FBC80 File Offset: 0x009F9E80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_equipItemDescPropMagiccGo(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailEquipmentUIController.m_luaExportHelper.m_equipItemDescPropMagiccGo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ECAF RID: 126127 RVA: 0x009FBCD8 File Offset: 0x009F9ED8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_equipItemDescPropMagiccGo(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			GameObject equipItemDescPropMagiccGo;
			LuaObject.checkType<GameObject>(l, 2, out equipItemDescPropMagiccGo);
			heroDetailEquipmentUIController.m_luaExportHelper.m_equipItemDescPropMagiccGo = equipItemDescPropMagiccGo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ECB0 RID: 126128 RVA: 0x009FBD34 File Offset: 0x009F9F34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_equipItemDescPropMagicValueText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailEquipmentUIController.m_luaExportHelper.m_equipItemDescPropMagicValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ECB1 RID: 126129 RVA: 0x009FBD8C File Offset: 0x009F9F8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_equipItemDescPropMagicValueText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			Text equipItemDescPropMagicValueText;
			LuaObject.checkType<Text>(l, 2, out equipItemDescPropMagicValueText);
			heroDetailEquipmentUIController.m_luaExportHelper.m_equipItemDescPropMagicValueText = equipItemDescPropMagicValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ECB2 RID: 126130 RVA: 0x009FBDE8 File Offset: 0x009F9FE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_equipItemDescPropMagicDFGo(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailEquipmentUIController.m_luaExportHelper.m_equipItemDescPropMagicDFGo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ECB3 RID: 126131 RVA: 0x009FBE40 File Offset: 0x009FA040
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_equipItemDescPropMagicDFGo(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			GameObject equipItemDescPropMagicDFGo;
			LuaObject.checkType<GameObject>(l, 2, out equipItemDescPropMagicDFGo);
			heroDetailEquipmentUIController.m_luaExportHelper.m_equipItemDescPropMagicDFGo = equipItemDescPropMagicDFGo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ECB4 RID: 126132 RVA: 0x009FBE9C File Offset: 0x009FA09C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_equipItemDescPropMagicDFValueText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailEquipmentUIController.m_luaExportHelper.m_equipItemDescPropMagicDFValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ECB5 RID: 126133 RVA: 0x009FBEF4 File Offset: 0x009FA0F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_equipItemDescPropMagicDFValueText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			Text equipItemDescPropMagicDFValueText;
			LuaObject.checkType<Text>(l, 2, out equipItemDescPropMagicDFValueText);
			heroDetailEquipmentUIController.m_luaExportHelper.m_equipItemDescPropMagicDFValueText = equipItemDescPropMagicDFValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ECB6 RID: 126134 RVA: 0x009FBF50 File Offset: 0x009FA150
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_equipItemDescPropDexGo(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailEquipmentUIController.m_luaExportHelper.m_equipItemDescPropDexGo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ECB7 RID: 126135 RVA: 0x009FBFA8 File Offset: 0x009FA1A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_equipItemDescPropDexGo(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			GameObject equipItemDescPropDexGo;
			LuaObject.checkType<GameObject>(l, 2, out equipItemDescPropDexGo);
			heroDetailEquipmentUIController.m_luaExportHelper.m_equipItemDescPropDexGo = equipItemDescPropDexGo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ECB8 RID: 126136 RVA: 0x009FC004 File Offset: 0x009FA204
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_equipItemDescPropDexValueText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailEquipmentUIController.m_luaExportHelper.m_equipItemDescPropDexValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ECB9 RID: 126137 RVA: 0x009FC05C File Offset: 0x009FA25C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_equipItemDescPropDexValueText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			Text equipItemDescPropDexValueText;
			LuaObject.checkType<Text>(l, 2, out equipItemDescPropDexValueText);
			heroDetailEquipmentUIController.m_luaExportHelper.m_equipItemDescPropDexValueText = equipItemDescPropDexValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ECBA RID: 126138 RVA: 0x009FC0B8 File Offset: 0x009FA2B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_descPropGroupStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailEquipmentUIController.m_luaExportHelper.m_descPropGroupStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ECBB RID: 126139 RVA: 0x009FC110 File Offset: 0x009FA310
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_descPropGroupStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			CommonUIStateController descPropGroupStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out descPropGroupStateCtrl);
			heroDetailEquipmentUIController.m_luaExportHelper.m_descPropGroupStateCtrl = descPropGroupStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ECBC RID: 126140 RVA: 0x009FC16C File Offset: 0x009FA36C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_descPropEnchantmentGroup(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailEquipmentUIController.m_luaExportHelper.m_descPropEnchantmentGroup);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ECBD RID: 126141 RVA: 0x009FC1C4 File Offset: 0x009FA3C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_descPropEnchantmentGroup(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			GameObject descPropEnchantmentGroup;
			LuaObject.checkType<GameObject>(l, 2, out descPropEnchantmentGroup);
			heroDetailEquipmentUIController.m_luaExportHelper.m_descPropEnchantmentGroup = descPropEnchantmentGroup;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ECBE RID: 126142 RVA: 0x009FC220 File Offset: 0x009FA420
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_descPropEnchantmentGroupRuneStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailEquipmentUIController.m_luaExportHelper.m_descPropEnchantmentGroupRuneStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ECBF RID: 126143 RVA: 0x009FC278 File Offset: 0x009FA478
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_descPropEnchantmentGroupRuneStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			CommonUIStateController descPropEnchantmentGroupRuneStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out descPropEnchantmentGroupRuneStateCtrl);
			heroDetailEquipmentUIController.m_luaExportHelper.m_descPropEnchantmentGroupRuneStateCtrl = descPropEnchantmentGroupRuneStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ECC0 RID: 126144 RVA: 0x009FC2D4 File Offset: 0x009FA4D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_descPropEnchantmentGroupRuneIconImage(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailEquipmentUIController.m_luaExportHelper.m_descPropEnchantmentGroupRuneIconImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ECC1 RID: 126145 RVA: 0x009FC32C File Offset: 0x009FA52C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_descPropEnchantmentGroupRuneIconImage(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			Image descPropEnchantmentGroupRuneIconImage;
			LuaObject.checkType<Image>(l, 2, out descPropEnchantmentGroupRuneIconImage);
			heroDetailEquipmentUIController.m_luaExportHelper.m_descPropEnchantmentGroupRuneIconImage = descPropEnchantmentGroupRuneIconImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ECC2 RID: 126146 RVA: 0x009FC388 File Offset: 0x009FA588
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_descPropEnchantmentGroupRuneNameText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailEquipmentUIController.m_luaExportHelper.m_descPropEnchantmentGroupRuneNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ECC3 RID: 126147 RVA: 0x009FC3E0 File Offset: 0x009FA5E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_descPropEnchantmentGroupRuneNameText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			Text descPropEnchantmentGroupRuneNameText;
			LuaObject.checkType<Text>(l, 2, out descPropEnchantmentGroupRuneNameText);
			heroDetailEquipmentUIController.m_luaExportHelper.m_descPropEnchantmentGroupRuneNameText = descPropEnchantmentGroupRuneNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ECC4 RID: 126148 RVA: 0x009FC43C File Offset: 0x009FA63C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_enchantmentValueInputField1(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailEquipmentUIController.m_luaExportHelper.m_enchantmentValueInputField1);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ECC5 RID: 126149 RVA: 0x009FC494 File Offset: 0x009FA694
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_enchantmentValueInputField1(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			InputField enchantmentValueInputField;
			LuaObject.checkType<InputField>(l, 2, out enchantmentValueInputField);
			heroDetailEquipmentUIController.m_luaExportHelper.m_enchantmentValueInputField1 = enchantmentValueInputField;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ECC6 RID: 126150 RVA: 0x009FC4F0 File Offset: 0x009FA6F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_enchantmentValueInputField2(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailEquipmentUIController.m_luaExportHelper.m_enchantmentValueInputField2);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ECC7 RID: 126151 RVA: 0x009FC548 File Offset: 0x009FA748
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_enchantmentValueInputField2(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			InputField enchantmentValueInputField;
			LuaObject.checkType<InputField>(l, 2, out enchantmentValueInputField);
			heroDetailEquipmentUIController.m_luaExportHelper.m_enchantmentValueInputField2 = enchantmentValueInputField;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ECC8 RID: 126152 RVA: 0x009FC5A4 File Offset: 0x009FA7A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_enchantmentValueInputField3(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailEquipmentUIController.m_luaExportHelper.m_enchantmentValueInputField3);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ECC9 RID: 126153 RVA: 0x009FC5FC File Offset: 0x009FA7FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_enchantmentValueInputField3(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			InputField enchantmentValueInputField;
			LuaObject.checkType<InputField>(l, 2, out enchantmentValueInputField);
			heroDetailEquipmentUIController.m_luaExportHelper.m_enchantmentValueInputField3 = enchantmentValueInputField;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ECCA RID: 126154 RVA: 0x009FC658 File Offset: 0x009FA858
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_enchantmentButton(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailEquipmentUIController.m_luaExportHelper.m_enchantmentButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ECCB RID: 126155 RVA: 0x009FC6B0 File Offset: 0x009FA8B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_enchantmentButton(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			Button enchantmentButton;
			LuaObject.checkType<Button>(l, 2, out enchantmentButton);
			heroDetailEquipmentUIController.m_luaExportHelper.m_enchantmentButton = enchantmentButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ECCC RID: 126156 RVA: 0x009FC70C File Offset: 0x009FA90C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_enchantmentValueTypes(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailEquipmentUIController.m_luaExportHelper.m_enchantmentValueTypes);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ECCD RID: 126157 RVA: 0x009FC764 File Offset: 0x009FA964
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_enchantmentValueTypes(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			ConfigDataPropertyModifyInfo[] enchantmentValueTypes;
			LuaObject.checkArray<ConfigDataPropertyModifyInfo>(l, 2, out enchantmentValueTypes);
			heroDetailEquipmentUIController.m_luaExportHelper.m_enchantmentValueTypes = enchantmentValueTypes;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ECCE RID: 126158 RVA: 0x009FC7C0 File Offset: 0x009FA9C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_slectedEquipment(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailEquipmentUIController.m_luaExportHelper.m_slectedEquipment);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ECCF RID: 126159 RVA: 0x009FC818 File Offset: 0x009FAA18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_slectedEquipment(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			EquipmentBagItem slectedEquipment;
			LuaObject.checkType<EquipmentBagItem>(l, 2, out slectedEquipment);
			heroDetailEquipmentUIController.m_luaExportHelper.m_slectedEquipment = slectedEquipment;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ECD0 RID: 126160 RVA: 0x009FC874 File Offset: 0x009FAA74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_equipItemDescSkillContent(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailEquipmentUIController.m_luaExportHelper.m_equipItemDescSkillContent);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ECD1 RID: 126161 RVA: 0x009FC8CC File Offset: 0x009FAACC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_equipItemDescSkillContent(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			GameObject equipItemDescSkillContent;
			LuaObject.checkType<GameObject>(l, 2, out equipItemDescSkillContent);
			heroDetailEquipmentUIController.m_luaExportHelper.m_equipItemDescSkillContent = equipItemDescSkillContent;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ECD2 RID: 126162 RVA: 0x009FC928 File Offset: 0x009FAB28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_equipItemDescSkillContentStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailEquipmentUIController.m_luaExportHelper.m_equipItemDescSkillContentStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ECD3 RID: 126163 RVA: 0x009FC980 File Offset: 0x009FAB80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_equipItemDescSkillContentStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			CommonUIStateController equipItemDescSkillContentStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out equipItemDescSkillContentStateCtrl);
			heroDetailEquipmentUIController.m_luaExportHelper.m_equipItemDescSkillContentStateCtrl = equipItemDescSkillContentStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ECD4 RID: 126164 RVA: 0x009FC9DC File Offset: 0x009FABDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_equipItemDescSkillNameText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailEquipmentUIController.m_luaExportHelper.m_equipItemDescSkillNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ECD5 RID: 126165 RVA: 0x009FCA34 File Offset: 0x009FAC34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_equipItemDescSkillNameText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			Text equipItemDescSkillNameText;
			LuaObject.checkType<Text>(l, 2, out equipItemDescSkillNameText);
			heroDetailEquipmentUIController.m_luaExportHelper.m_equipItemDescSkillNameText = equipItemDescSkillNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ECD6 RID: 126166 RVA: 0x009FCA90 File Offset: 0x009FAC90
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_equipItemDescSkillLvText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailEquipmentUIController.m_luaExportHelper.m_equipItemDescSkillLvText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ECD7 RID: 126167 RVA: 0x009FCAE8 File Offset: 0x009FACE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_equipItemDescSkillLvText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			Text equipItemDescSkillLvText;
			LuaObject.checkType<Text>(l, 2, out equipItemDescSkillLvText);
			heroDetailEquipmentUIController.m_luaExportHelper.m_equipItemDescSkillLvText = equipItemDescSkillLvText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ECD8 RID: 126168 RVA: 0x009FCB44 File Offset: 0x009FAD44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_equipItemDescUnlockCoditionText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailEquipmentUIController.m_luaExportHelper.m_equipItemDescUnlockCoditionText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ECD9 RID: 126169 RVA: 0x009FCB9C File Offset: 0x009FAD9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_equipItemDescUnlockCoditionText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			Text equipItemDescUnlockCoditionText;
			LuaObject.checkType<Text>(l, 2, out equipItemDescUnlockCoditionText);
			heroDetailEquipmentUIController.m_luaExportHelper.m_equipItemDescUnlockCoditionText = equipItemDescUnlockCoditionText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ECDA RID: 126170 RVA: 0x009FCBF8 File Offset: 0x009FADF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_equipItemDescSkillOwnerText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailEquipmentUIController.m_luaExportHelper.m_equipItemDescSkillOwnerText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ECDB RID: 126171 RVA: 0x009FCC50 File Offset: 0x009FAE50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_equipItemDescSkillOwnerText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			Text equipItemDescSkillOwnerText;
			LuaObject.checkType<Text>(l, 2, out equipItemDescSkillOwnerText);
			heroDetailEquipmentUIController.m_luaExportHelper.m_equipItemDescSkillOwnerText = equipItemDescSkillOwnerText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ECDC RID: 126172 RVA: 0x009FCCAC File Offset: 0x009FAEAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_equipItemDescSkillOwnerBGImage(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailEquipmentUIController.m_luaExportHelper.m_equipItemDescSkillOwnerBGImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ECDD RID: 126173 RVA: 0x009FCD04 File Offset: 0x009FAF04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_equipItemDescSkillOwnerBGImage(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			GameObject equipItemDescSkillOwnerBGImage;
			LuaObject.checkType<GameObject>(l, 2, out equipItemDescSkillOwnerBGImage);
			heroDetailEquipmentUIController.m_luaExportHelper.m_equipItemDescSkillOwnerBGImage = equipItemDescSkillOwnerBGImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ECDE RID: 126174 RVA: 0x009FCD60 File Offset: 0x009FAF60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_equipItemDescSkillDescText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailEquipmentUIController.m_luaExportHelper.m_equipItemDescSkillDescText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ECDF RID: 126175 RVA: 0x009FCDB8 File Offset: 0x009FAFB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_equipItemDescSkillDescText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			Text equipItemDescSkillDescText;
			LuaObject.checkType<Text>(l, 2, out equipItemDescSkillDescText);
			heroDetailEquipmentUIController.m_luaExportHelper.m_equipItemDescSkillDescText = equipItemDescSkillDescText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ECE0 RID: 126176 RVA: 0x009FCE14 File Offset: 0x009FB014
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_equipItemDescNotEquipSkillTip(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailEquipmentUIController.m_luaExportHelper.m_equipItemDescNotEquipSkillTip);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ECE1 RID: 126177 RVA: 0x009FCE6C File Offset: 0x009FB06C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_equipItemDescNotEquipSkillTip(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			GameObject equipItemDescNotEquipSkillTip;
			LuaObject.checkType<GameObject>(l, 2, out equipItemDescNotEquipSkillTip);
			heroDetailEquipmentUIController.m_luaExportHelper.m_equipItemDescNotEquipSkillTip = equipItemDescNotEquipSkillTip;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ECE2 RID: 126178 RVA: 0x009FCEC8 File Offset: 0x009FB0C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_equipItemDescLockButton(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailEquipmentUIController.m_luaExportHelper.m_equipItemDescLockButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ECE3 RID: 126179 RVA: 0x009FCF20 File Offset: 0x009FB120
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_equipItemDescLockButton(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			Button equipItemDescLockButton;
			LuaObject.checkType<Button>(l, 2, out equipItemDescLockButton);
			heroDetailEquipmentUIController.m_luaExportHelper.m_equipItemDescLockButton = equipItemDescLockButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ECE4 RID: 126180 RVA: 0x009FCF7C File Offset: 0x009FB17C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_equipItemDescForgeButton(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailEquipmentUIController.m_luaExportHelper.m_equipItemDescForgeButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ECE5 RID: 126181 RVA: 0x009FCFD4 File Offset: 0x009FB1D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_equipItemDescForgeButton(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			Button equipItemDescForgeButton;
			LuaObject.checkType<Button>(l, 2, out equipItemDescForgeButton);
			heroDetailEquipmentUIController.m_luaExportHelper.m_equipItemDescForgeButton = equipItemDescForgeButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ECE6 RID: 126182 RVA: 0x009FD030 File Offset: 0x009FB230
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_equipItemDescExchangeButton(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailEquipmentUIController.m_luaExportHelper.m_equipItemDescExchangeButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ECE7 RID: 126183 RVA: 0x009FD088 File Offset: 0x009FB288
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_equipItemDescExchangeButton(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			Button equipItemDescExchangeButton;
			LuaObject.checkType<Button>(l, 2, out equipItemDescExchangeButton);
			heroDetailEquipmentUIController.m_luaExportHelper.m_equipItemDescExchangeButton = equipItemDescExchangeButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ECE8 RID: 126184 RVA: 0x009FD0E4 File Offset: 0x009FB2E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_resonanceInfoPanelStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailEquipmentUIController.m_luaExportHelper.m_resonanceInfoPanelStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ECE9 RID: 126185 RVA: 0x009FD13C File Offset: 0x009FB33C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_resonanceInfoPanelStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			CommonUIStateController resonanceInfoPanelStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out resonanceInfoPanelStateCtrl);
			heroDetailEquipmentUIController.m_luaExportHelper.m_resonanceInfoPanelStateCtrl = resonanceInfoPanelStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ECEA RID: 126186 RVA: 0x009FD198 File Offset: 0x009FB398
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_resonanceInfoPanelBgButton(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailEquipmentUIController.m_luaExportHelper.m_resonanceInfoPanelBgButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ECEB RID: 126187 RVA: 0x009FD1F0 File Offset: 0x009FB3F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_resonanceInfoPanelBgButton(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			Button resonanceInfoPanelBgButton;
			LuaObject.checkType<Button>(l, 2, out resonanceInfoPanelBgButton);
			heroDetailEquipmentUIController.m_luaExportHelper.m_resonanceInfoPanelBgButton = resonanceInfoPanelBgButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ECEC RID: 126188 RVA: 0x009FD24C File Offset: 0x009FB44C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_resonanceInfoPanel2SuitStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailEquipmentUIController.m_luaExportHelper.m_resonanceInfoPanel2SuitStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ECED RID: 126189 RVA: 0x009FD2A4 File Offset: 0x009FB4A4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_resonanceInfoPanel2SuitStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			CommonUIStateController resonanceInfoPanel2SuitStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out resonanceInfoPanel2SuitStateCtrl);
			heroDetailEquipmentUIController.m_luaExportHelper.m_resonanceInfoPanel2SuitStateCtrl = resonanceInfoPanel2SuitStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ECEE RID: 126190 RVA: 0x009FD300 File Offset: 0x009FB500
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_resonanceInfoPanel2SuitInfoText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailEquipmentUIController.m_luaExportHelper.m_resonanceInfoPanel2SuitInfoText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ECEF RID: 126191 RVA: 0x009FD358 File Offset: 0x009FB558
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_resonanceInfoPanel2SuitInfoText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			Text resonanceInfoPanel2SuitInfoText;
			LuaObject.checkType<Text>(l, 2, out resonanceInfoPanel2SuitInfoText);
			heroDetailEquipmentUIController.m_luaExportHelper.m_resonanceInfoPanel2SuitInfoText = resonanceInfoPanel2SuitInfoText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ECF0 RID: 126192 RVA: 0x009FD3B4 File Offset: 0x009FB5B4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_resonanceInfoPanel4SuitStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailEquipmentUIController.m_luaExportHelper.m_resonanceInfoPanel4SuitStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ECF1 RID: 126193 RVA: 0x009FD40C File Offset: 0x009FB60C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_resonanceInfoPanel4SuitStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			CommonUIStateController resonanceInfoPanel4SuitStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out resonanceInfoPanel4SuitStateCtrl);
			heroDetailEquipmentUIController.m_luaExportHelper.m_resonanceInfoPanel4SuitStateCtrl = resonanceInfoPanel4SuitStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ECF2 RID: 126194 RVA: 0x009FD468 File Offset: 0x009FB668
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_resonanceInfoPanel4SuitInfoText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailEquipmentUIController.m_luaExportHelper.m_resonanceInfoPanel4SuitInfoText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ECF3 RID: 126195 RVA: 0x009FD4C0 File Offset: 0x009FB6C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_resonanceInfoPanel4SuitInfoText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			Text resonanceInfoPanel4SuitInfoText;
			LuaObject.checkType<Text>(l, 2, out resonanceInfoPanel4SuitInfoText);
			heroDetailEquipmentUIController.m_luaExportHelper.m_resonanceInfoPanel4SuitInfoText = resonanceInfoPanel4SuitInfoText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ECF4 RID: 126196 RVA: 0x009FD51C File Offset: 0x009FB71C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_resonanceInfoPanelNameText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailEquipmentUIController.m_luaExportHelper.m_resonanceInfoPanelNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ECF5 RID: 126197 RVA: 0x009FD574 File Offset: 0x009FB774
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_resonanceInfoPanelNameText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			Text resonanceInfoPanelNameText;
			LuaObject.checkType<Text>(l, 2, out resonanceInfoPanelNameText);
			heroDetailEquipmentUIController.m_luaExportHelper.m_resonanceInfoPanelNameText = resonanceInfoPanelNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ECF6 RID: 126198 RVA: 0x009FD5D0 File Offset: 0x009FB7D0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_slot(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailEquipmentUIController.m_luaExportHelper.m_slot);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ECF7 RID: 126199 RVA: 0x009FD628 File Offset: 0x009FB828
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_slot(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			int slot;
			LuaObject.checkType(l, 2, out slot);
			heroDetailEquipmentUIController.m_luaExportHelper.m_slot = slot;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ECF8 RID: 126200 RVA: 0x009FD684 File Offset: 0x009FB884
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_hero(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailEquipmentUIController.m_luaExportHelper.m_hero);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ECF9 RID: 126201 RVA: 0x009FD6DC File Offset: 0x009FB8DC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_hero(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			Hero hero;
			LuaObject.checkType<Hero>(l, 2, out hero);
			heroDetailEquipmentUIController.m_luaExportHelper.m_hero = hero;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ECFA RID: 126202 RVA: 0x009FD738 File Offset: 0x009FB938
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_equipmentInstanceId(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailEquipmentUIController.m_luaExportHelper.m_equipmentInstanceId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ECFB RID: 126203 RVA: 0x009FD790 File Offset: 0x009FB990
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_equipmentInstanceId(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			ulong equipmentInstanceId;
			LuaObject.checkType(l, 2, out equipmentInstanceId);
			heroDetailEquipmentUIController.m_luaExportHelper.m_equipmentInstanceId = equipmentInstanceId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ECFC RID: 126204 RVA: 0x009FD7EC File Offset: 0x009FB9EC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_equipmentGos(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailEquipmentUIController.m_luaExportHelper.m_equipmentGos);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ECFD RID: 126205 RVA: 0x009FD844 File Offset: 0x009FBA44
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_equipmentGos(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			List<GameObject> equipmentGos;
			LuaObject.checkType<List<GameObject>>(l, 2, out equipmentGos);
			heroDetailEquipmentUIController.m_luaExportHelper.m_equipmentGos = equipmentGos;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ECFE RID: 126206 RVA: 0x009FD8A0 File Offset: 0x009FBAA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailEquipmentUIController.m_luaExportHelper.m_playerContext);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ECFF RID: 126207 RVA: 0x009FD8F8 File Offset: 0x009FBAF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			ProjectLPlayerContext playerContext;
			LuaObject.checkType<ProjectLPlayerContext>(l, 2, out playerContext);
			heroDetailEquipmentUIController.m_luaExportHelper.m_playerContext = playerContext;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ED00 RID: 126208 RVA: 0x009FD954 File Offset: 0x009FBB54
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailEquipmentUIController.m_luaExportHelper.m_configDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ED01 RID: 126209 RVA: 0x009FD9AC File Offset: 0x009FBBAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailEquipmentUIController heroDetailEquipmentUIController = (HeroDetailEquipmentUIController)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			heroDetailEquipmentUIController.m_luaExportHelper.m_configDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ED02 RID: 126210 RVA: 0x009FDA08 File Offset: 0x009FBC08
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.HeroDetailEquipmentUIController");
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.UpdateViewInEquipmentState);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.SetCommonUIState);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.CreateEquipmentList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.OnEquipmentIconClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.OnEquipmentAddButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.HaveEquipmentInBag);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.OnRuneIconButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.SetResonanceInfoPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.CloseResonanceInfoPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.SetEquipmentItemDesc);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.SetPropItems);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.OnForgeButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.OnEnchantmentButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.OnExchangeButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.OnAutoEquipButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.OnFastRemoveButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.DisableAutoEquipButton);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.CloseEquipemntItemDescGo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.OnEquipemntLockButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.__callDele_EventOnAutoRemove);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.__clearDele_EventOnAutoRemove);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.__callDele_EventOnAutoEquip);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.__clearDele_EventOnAutoEquip);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.__callDele_EventOnGotoEquipmentForge);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache25);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.__clearDele_EventOnGotoEquipmentForge);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache26);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.__callDele_EventOnGotoEquipmentStore);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache27);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.__clearDele_EventOnGotoEquipmentStore);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache28);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.__callDele_EventOnLockButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache29);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.__clearDele_EventOnLockButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache2A);
		string name = "EventOnAutoRemove";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.set_EventOnAutoRemove);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache2B, true);
		string name2 = "EventOnAutoEquip";
		LuaCSFunction get2 = null;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.set_EventOnAutoEquip);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache2C, true);
		string name3 = "EventOnGotoEquipmentForge";
		LuaCSFunction get3 = null;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.set_EventOnGotoEquipmentForge);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache2D, true);
		string name4 = "EventOnGotoEquipmentStore";
		LuaCSFunction get4 = null;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.set_EventOnGotoEquipmentStore);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache2E, true);
		string name5 = "EventOnLockButtonClick";
		LuaCSFunction get5 = null;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.set_EventOnLockButtonClick);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache2F, true);
		string name6 = "m_marginTransform";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.get_m_marginTransform);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache30;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.set_m_marginTransform);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache31, true);
		string name7 = "m_equipItem";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.get_m_equipItem);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache32;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.set_m_equipItem);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache33, true);
		string name8 = "m_equipItem1";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.get_m_equipItem1);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache34;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.set_m_equipItem1);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache35, true);
		string name9 = "m_equipItem2";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.get_m_equipItem2);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache36;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.set_m_equipItem2);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache37, true);
		string name10 = "m_equipItem3";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.get_m_equipItem3);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache38;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.set_m_equipItem3);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache39, true);
		string name11 = "m_autoEquipButton";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.get_m_autoEquipButton);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache3A;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.set_m_autoEquipButton);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache3B, true);
		string name12 = "m_autoEquipButtonNormalBg";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.get_m_autoEquipButtonNormalBg);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache3C;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.set_m_autoEquipButtonNormalBg);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache3D, true);
		string name13 = "m_fastRemoveButton";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.get_m_fastRemoveButton);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache3E;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.set_m_fastRemoveButton);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache3F, true);
		string name14 = "m_equipItemDescGo";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.get_m_equipItemDescGo);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache40;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.set_m_equipItemDescGo);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache41, true);
		string name15 = "m_equipItemDescTitleText";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.get_m_equipItemDescTitleText);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache42;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.set_m_equipItemDescTitleText);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache43, true);
		string name16 = "m_equipItemDescLvText";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.get_m_equipItemDescLvText);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache44;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.set_m_equipItemDescLvText);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache45, true);
		string name17 = "m_equipItemDescExpText";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache46 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache46 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.get_m_equipItemDescExpText);
		}
		LuaCSFunction get17 = Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache46;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache47 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache47 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.set_m_equipItemDescExpText);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache47, true);
		string name18 = "m_equipItemDescIconImage";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache48 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache48 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.get_m_equipItemDescIconImage);
		}
		LuaCSFunction get18 = Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache48;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache49 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache49 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.set_m_equipItemDescIconImage);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache49, true);
		string name19 = "m_equipItemDescIconBg";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache4A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache4A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.get_m_equipItemDescIconBg);
		}
		LuaCSFunction get19 = Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache4A;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache4B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache4B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.set_m_equipItemDescIconBg);
		}
		LuaObject.addMember(l, name19, get19, Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache4B, true);
		string name20 = "m_equipItemDescSSREffect";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache4C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache4C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.get_m_equipItemDescSSREffect);
		}
		LuaCSFunction get20 = Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache4C;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache4D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache4D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.set_m_equipItemDescSSREffect);
		}
		LuaObject.addMember(l, name20, get20, Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache4D, true);
		string name21 = "m_equipItemDescProgressImage";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache4E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache4E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.get_m_equipItemDescProgressImage);
		}
		LuaCSFunction get21 = Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache4E;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache4F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache4F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.set_m_equipItemDescProgressImage);
		}
		LuaObject.addMember(l, name21, get21, Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache4F, true);
		string name22 = "m_equipItemDescStarGroup";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache50 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache50 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.get_m_equipItemDescStarGroup);
		}
		LuaCSFunction get22 = Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache50;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache51 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache51 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.set_m_equipItemDescStarGroup);
		}
		LuaObject.addMember(l, name22, get22, Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache51, true);
		string name23 = "m_equipItemDescEquipLimitContent";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache52 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache52 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.get_m_equipItemDescEquipLimitContent);
		}
		LuaCSFunction get23 = Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache52;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache53 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache53 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.set_m_equipItemDescEquipLimitContent);
		}
		LuaObject.addMember(l, name23, get23, Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache53, true);
		string name24 = "m_descEquipUnlimitText";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache54 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache54 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.get_m_descEquipUnlimitText);
		}
		LuaCSFunction get24 = Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache54;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache55 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache55 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.set_m_descEquipUnlimitText);
		}
		LuaObject.addMember(l, name24, get24, Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache55, true);
		string name25 = "m_equipItemDescPropContent";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache56 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache56 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.get_m_equipItemDescPropContent);
		}
		LuaCSFunction get25 = Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache56;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache57 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache57 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.set_m_equipItemDescPropContent);
		}
		LuaObject.addMember(l, name25, get25, Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache57, true);
		string name26 = "m_equipItemDescPropATGo";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache58 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache58 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.get_m_equipItemDescPropATGo);
		}
		LuaCSFunction get26 = Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache58;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache59 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache59 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.set_m_equipItemDescPropATGo);
		}
		LuaObject.addMember(l, name26, get26, Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache59, true);
		string name27 = "m_equipItemDescPropATValueText";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache5A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache5A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.get_m_equipItemDescPropATValueText);
		}
		LuaCSFunction get27 = Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache5A;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache5B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache5B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.set_m_equipItemDescPropATValueText);
		}
		LuaObject.addMember(l, name27, get27, Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache5B, true);
		string name28 = "m_equipItemDescPropDFGo";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache5C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache5C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.get_m_equipItemDescPropDFGo);
		}
		LuaCSFunction get28 = Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache5C;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache5D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache5D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.set_m_equipItemDescPropDFGo);
		}
		LuaObject.addMember(l, name28, get28, Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache5D, true);
		string name29 = "m_equipItemDescPropDFValueText";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache5E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache5E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.get_m_equipItemDescPropDFValueText);
		}
		LuaCSFunction get29 = Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache5E;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache5F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache5F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.set_m_equipItemDescPropDFValueText);
		}
		LuaObject.addMember(l, name29, get29, Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache5F, true);
		string name30 = "m_equipItemDescPropHPGo";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache60 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache60 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.get_m_equipItemDescPropHPGo);
		}
		LuaCSFunction get30 = Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache60;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache61 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache61 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.set_m_equipItemDescPropHPGo);
		}
		LuaObject.addMember(l, name30, get30, Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache61, true);
		string name31 = "m_equipItemDescPropHPValueText";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache62 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache62 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.get_m_equipItemDescPropHPValueText);
		}
		LuaCSFunction get31 = Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache62;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache63 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache63 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.set_m_equipItemDescPropHPValueText);
		}
		LuaObject.addMember(l, name31, get31, Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache63, true);
		string name32 = "m_equipItemDescPropMagiccGo";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache64 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache64 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.get_m_equipItemDescPropMagiccGo);
		}
		LuaCSFunction get32 = Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache64;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache65 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache65 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.set_m_equipItemDescPropMagiccGo);
		}
		LuaObject.addMember(l, name32, get32, Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache65, true);
		string name33 = "m_equipItemDescPropMagicValueText";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache66 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache66 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.get_m_equipItemDescPropMagicValueText);
		}
		LuaCSFunction get33 = Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache66;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache67 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache67 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.set_m_equipItemDescPropMagicValueText);
		}
		LuaObject.addMember(l, name33, get33, Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache67, true);
		string name34 = "m_equipItemDescPropMagicDFGo";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache68 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache68 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.get_m_equipItemDescPropMagicDFGo);
		}
		LuaCSFunction get34 = Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache68;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache69 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache69 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.set_m_equipItemDescPropMagicDFGo);
		}
		LuaObject.addMember(l, name34, get34, Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache69, true);
		string name35 = "m_equipItemDescPropMagicDFValueText";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache6A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache6A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.get_m_equipItemDescPropMagicDFValueText);
		}
		LuaCSFunction get35 = Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache6A;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache6B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache6B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.set_m_equipItemDescPropMagicDFValueText);
		}
		LuaObject.addMember(l, name35, get35, Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache6B, true);
		string name36 = "m_equipItemDescPropDexGo";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache6C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache6C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.get_m_equipItemDescPropDexGo);
		}
		LuaCSFunction get36 = Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache6C;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache6D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache6D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.set_m_equipItemDescPropDexGo);
		}
		LuaObject.addMember(l, name36, get36, Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache6D, true);
		string name37 = "m_equipItemDescPropDexValueText";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache6E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache6E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.get_m_equipItemDescPropDexValueText);
		}
		LuaCSFunction get37 = Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache6E;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache6F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache6F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.set_m_equipItemDescPropDexValueText);
		}
		LuaObject.addMember(l, name37, get37, Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache6F, true);
		string name38 = "m_descPropGroupStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache70 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache70 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.get_m_descPropGroupStateCtrl);
		}
		LuaCSFunction get38 = Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache70;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache71 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache71 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.set_m_descPropGroupStateCtrl);
		}
		LuaObject.addMember(l, name38, get38, Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache71, true);
		string name39 = "m_descPropEnchantmentGroup";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache72 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache72 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.get_m_descPropEnchantmentGroup);
		}
		LuaCSFunction get39 = Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache72;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache73 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache73 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.set_m_descPropEnchantmentGroup);
		}
		LuaObject.addMember(l, name39, get39, Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache73, true);
		string name40 = "m_descPropEnchantmentGroupRuneStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache74 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache74 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.get_m_descPropEnchantmentGroupRuneStateCtrl);
		}
		LuaCSFunction get40 = Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache74;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache75 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache75 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.set_m_descPropEnchantmentGroupRuneStateCtrl);
		}
		LuaObject.addMember(l, name40, get40, Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache75, true);
		string name41 = "m_descPropEnchantmentGroupRuneIconImage";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache76 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache76 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.get_m_descPropEnchantmentGroupRuneIconImage);
		}
		LuaCSFunction get41 = Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache76;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache77 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache77 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.set_m_descPropEnchantmentGroupRuneIconImage);
		}
		LuaObject.addMember(l, name41, get41, Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache77, true);
		string name42 = "m_descPropEnchantmentGroupRuneNameText";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache78 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache78 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.get_m_descPropEnchantmentGroupRuneNameText);
		}
		LuaCSFunction get42 = Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache78;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache79 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache79 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.set_m_descPropEnchantmentGroupRuneNameText);
		}
		LuaObject.addMember(l, name42, get42, Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache79, true);
		string name43 = "m_enchantmentValueInputField1";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache7A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache7A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.get_m_enchantmentValueInputField1);
		}
		LuaCSFunction get43 = Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache7A;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache7B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache7B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.set_m_enchantmentValueInputField1);
		}
		LuaObject.addMember(l, name43, get43, Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache7B, true);
		string name44 = "m_enchantmentValueInputField2";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache7C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache7C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.get_m_enchantmentValueInputField2);
		}
		LuaCSFunction get44 = Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache7C;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache7D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache7D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.set_m_enchantmentValueInputField2);
		}
		LuaObject.addMember(l, name44, get44, Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache7D, true);
		string name45 = "m_enchantmentValueInputField3";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache7E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache7E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.get_m_enchantmentValueInputField3);
		}
		LuaCSFunction get45 = Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache7E;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache7F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache7F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.set_m_enchantmentValueInputField3);
		}
		LuaObject.addMember(l, name45, get45, Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache7F, true);
		string name46 = "m_enchantmentButton";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache80 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache80 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.get_m_enchantmentButton);
		}
		LuaCSFunction get46 = Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache80;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache81 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache81 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.set_m_enchantmentButton);
		}
		LuaObject.addMember(l, name46, get46, Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache81, true);
		string name47 = "m_enchantmentValueTypes";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache82 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache82 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.get_m_enchantmentValueTypes);
		}
		LuaCSFunction get47 = Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache82;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache83 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache83 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.set_m_enchantmentValueTypes);
		}
		LuaObject.addMember(l, name47, get47, Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache83, true);
		string name48 = "m_slectedEquipment";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache84 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache84 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.get_m_slectedEquipment);
		}
		LuaCSFunction get48 = Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache84;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache85 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache85 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.set_m_slectedEquipment);
		}
		LuaObject.addMember(l, name48, get48, Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache85, true);
		string name49 = "m_equipItemDescSkillContent";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache86 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache86 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.get_m_equipItemDescSkillContent);
		}
		LuaCSFunction get49 = Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache86;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache87 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache87 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.set_m_equipItemDescSkillContent);
		}
		LuaObject.addMember(l, name49, get49, Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache87, true);
		string name50 = "m_equipItemDescSkillContentStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache88 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache88 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.get_m_equipItemDescSkillContentStateCtrl);
		}
		LuaCSFunction get50 = Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache88;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache89 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache89 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.set_m_equipItemDescSkillContentStateCtrl);
		}
		LuaObject.addMember(l, name50, get50, Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache89, true);
		string name51 = "m_equipItemDescSkillNameText";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache8A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache8A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.get_m_equipItemDescSkillNameText);
		}
		LuaCSFunction get51 = Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache8A;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache8B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache8B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.set_m_equipItemDescSkillNameText);
		}
		LuaObject.addMember(l, name51, get51, Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache8B, true);
		string name52 = "m_equipItemDescSkillLvText";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache8C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache8C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.get_m_equipItemDescSkillLvText);
		}
		LuaCSFunction get52 = Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache8C;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache8D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache8D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.set_m_equipItemDescSkillLvText);
		}
		LuaObject.addMember(l, name52, get52, Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache8D, true);
		string name53 = "m_equipItemDescUnlockCoditionText";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache8E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache8E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.get_m_equipItemDescUnlockCoditionText);
		}
		LuaCSFunction get53 = Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache8E;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache8F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache8F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.set_m_equipItemDescUnlockCoditionText);
		}
		LuaObject.addMember(l, name53, get53, Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache8F, true);
		string name54 = "m_equipItemDescSkillOwnerText";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache90 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache90 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.get_m_equipItemDescSkillOwnerText);
		}
		LuaCSFunction get54 = Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache90;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache91 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache91 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.set_m_equipItemDescSkillOwnerText);
		}
		LuaObject.addMember(l, name54, get54, Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache91, true);
		string name55 = "m_equipItemDescSkillOwnerBGImage";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache92 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache92 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.get_m_equipItemDescSkillOwnerBGImage);
		}
		LuaCSFunction get55 = Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache92;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache93 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache93 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.set_m_equipItemDescSkillOwnerBGImage);
		}
		LuaObject.addMember(l, name55, get55, Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache93, true);
		string name56 = "m_equipItemDescSkillDescText";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache94 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache94 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.get_m_equipItemDescSkillDescText);
		}
		LuaCSFunction get56 = Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache94;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache95 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache95 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.set_m_equipItemDescSkillDescText);
		}
		LuaObject.addMember(l, name56, get56, Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache95, true);
		string name57 = "m_equipItemDescNotEquipSkillTip";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache96 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache96 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.get_m_equipItemDescNotEquipSkillTip);
		}
		LuaCSFunction get57 = Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache96;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache97 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache97 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.set_m_equipItemDescNotEquipSkillTip);
		}
		LuaObject.addMember(l, name57, get57, Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache97, true);
		string name58 = "m_equipItemDescLockButton";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache98 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache98 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.get_m_equipItemDescLockButton);
		}
		LuaCSFunction get58 = Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache98;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache99 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache99 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.set_m_equipItemDescLockButton);
		}
		LuaObject.addMember(l, name58, get58, Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache99, true);
		string name59 = "m_equipItemDescForgeButton";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache9A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache9A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.get_m_equipItemDescForgeButton);
		}
		LuaCSFunction get59 = Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache9A;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache9B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache9B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.set_m_equipItemDescForgeButton);
		}
		LuaObject.addMember(l, name59, get59, Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache9B, true);
		string name60 = "m_equipItemDescExchangeButton";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache9C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache9C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.get_m_equipItemDescExchangeButton);
		}
		LuaCSFunction get60 = Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache9C;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache9D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache9D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.set_m_equipItemDescExchangeButton);
		}
		LuaObject.addMember(l, name60, get60, Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache9D, true);
		string name61 = "m_resonanceInfoPanelStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache9E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache9E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.get_m_resonanceInfoPanelStateCtrl);
		}
		LuaCSFunction get61 = Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache9E;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache9F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache9F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.set_m_resonanceInfoPanelStateCtrl);
		}
		LuaObject.addMember(l, name61, get61, Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cache9F, true);
		string name62 = "m_resonanceInfoPanelBgButton";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cacheA0 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cacheA0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.get_m_resonanceInfoPanelBgButton);
		}
		LuaCSFunction get62 = Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cacheA0;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cacheA1 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cacheA1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.set_m_resonanceInfoPanelBgButton);
		}
		LuaObject.addMember(l, name62, get62, Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cacheA1, true);
		string name63 = "m_resonanceInfoPanel2SuitStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cacheA2 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cacheA2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.get_m_resonanceInfoPanel2SuitStateCtrl);
		}
		LuaCSFunction get63 = Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cacheA2;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cacheA3 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cacheA3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.set_m_resonanceInfoPanel2SuitStateCtrl);
		}
		LuaObject.addMember(l, name63, get63, Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cacheA3, true);
		string name64 = "m_resonanceInfoPanel2SuitInfoText";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cacheA4 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cacheA4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.get_m_resonanceInfoPanel2SuitInfoText);
		}
		LuaCSFunction get64 = Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cacheA4;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cacheA5 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cacheA5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.set_m_resonanceInfoPanel2SuitInfoText);
		}
		LuaObject.addMember(l, name64, get64, Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cacheA5, true);
		string name65 = "m_resonanceInfoPanel4SuitStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cacheA6 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cacheA6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.get_m_resonanceInfoPanel4SuitStateCtrl);
		}
		LuaCSFunction get65 = Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cacheA6;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cacheA7 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cacheA7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.set_m_resonanceInfoPanel4SuitStateCtrl);
		}
		LuaObject.addMember(l, name65, get65, Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cacheA7, true);
		string name66 = "m_resonanceInfoPanel4SuitInfoText";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cacheA8 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cacheA8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.get_m_resonanceInfoPanel4SuitInfoText);
		}
		LuaCSFunction get66 = Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cacheA8;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cacheA9 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cacheA9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.set_m_resonanceInfoPanel4SuitInfoText);
		}
		LuaObject.addMember(l, name66, get66, Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cacheA9, true);
		string name67 = "m_resonanceInfoPanelNameText";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cacheAA == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cacheAA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.get_m_resonanceInfoPanelNameText);
		}
		LuaCSFunction get67 = Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cacheAA;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cacheAB == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cacheAB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.set_m_resonanceInfoPanelNameText);
		}
		LuaObject.addMember(l, name67, get67, Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cacheAB, true);
		string name68 = "m_slot";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cacheAC == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cacheAC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.get_m_slot);
		}
		LuaCSFunction get68 = Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cacheAC;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cacheAD == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cacheAD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.set_m_slot);
		}
		LuaObject.addMember(l, name68, get68, Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cacheAD, true);
		string name69 = "m_hero";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cacheAE == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cacheAE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.get_m_hero);
		}
		LuaCSFunction get69 = Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cacheAE;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cacheAF == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cacheAF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.set_m_hero);
		}
		LuaObject.addMember(l, name69, get69, Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cacheAF, true);
		string name70 = "m_equipmentInstanceId";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cacheB0 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cacheB0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.get_m_equipmentInstanceId);
		}
		LuaCSFunction get70 = Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cacheB0;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cacheB1 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cacheB1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.set_m_equipmentInstanceId);
		}
		LuaObject.addMember(l, name70, get70, Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cacheB1, true);
		string name71 = "m_equipmentGos";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cacheB2 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cacheB2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.get_m_equipmentGos);
		}
		LuaCSFunction get71 = Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cacheB2;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cacheB3 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cacheB3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.set_m_equipmentGos);
		}
		LuaObject.addMember(l, name71, get71, Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cacheB3, true);
		string name72 = "m_playerContext";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cacheB4 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cacheB4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.get_m_playerContext);
		}
		LuaCSFunction get72 = Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cacheB4;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cacheB5 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cacheB5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.set_m_playerContext);
		}
		LuaObject.addMember(l, name72, get72, Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cacheB5, true);
		string name73 = "m_configDataLoader";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cacheB6 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cacheB6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.get_m_configDataLoader);
		}
		LuaCSFunction get73 = Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cacheB6;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cacheB7 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cacheB7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.set_m_configDataLoader);
		}
		LuaObject.addMember(l, name73, get73, Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.<>f__mg$cacheB7, true);
		LuaObject.createTypeMetatable(l, null, typeof(HeroDetailEquipmentUIController), typeof(UIControllerBase));
	}

	// Token: 0x04014CC8 RID: 85192
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04014CC9 RID: 85193
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04014CCA RID: 85194
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04014CCB RID: 85195
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04014CCC RID: 85196
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04014CCD RID: 85197
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04014CCE RID: 85198
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04014CCF RID: 85199
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04014CD0 RID: 85200
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04014CD1 RID: 85201
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04014CD2 RID: 85202
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04014CD3 RID: 85203
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04014CD4 RID: 85204
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04014CD5 RID: 85205
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04014CD6 RID: 85206
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04014CD7 RID: 85207
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04014CD8 RID: 85208
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04014CD9 RID: 85209
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04014CDA RID: 85210
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04014CDB RID: 85211
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04014CDC RID: 85212
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04014CDD RID: 85213
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04014CDE RID: 85214
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04014CDF RID: 85215
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04014CE0 RID: 85216
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04014CE1 RID: 85217
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04014CE2 RID: 85218
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04014CE3 RID: 85219
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04014CE4 RID: 85220
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04014CE5 RID: 85221
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04014CE6 RID: 85222
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04014CE7 RID: 85223
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04014CE8 RID: 85224
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04014CE9 RID: 85225
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04014CEA RID: 85226
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04014CEB RID: 85227
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04014CEC RID: 85228
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04014CED RID: 85229
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04014CEE RID: 85230
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04014CEF RID: 85231
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04014CF0 RID: 85232
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04014CF1 RID: 85233
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04014CF2 RID: 85234
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04014CF3 RID: 85235
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04014CF4 RID: 85236
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04014CF5 RID: 85237
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04014CF6 RID: 85238
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04014CF7 RID: 85239
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04014CF8 RID: 85240
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04014CF9 RID: 85241
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04014CFA RID: 85242
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x04014CFB RID: 85243
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x04014CFC RID: 85244
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x04014CFD RID: 85245
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x04014CFE RID: 85246
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x04014CFF RID: 85247
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x04014D00 RID: 85248
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x04014D01 RID: 85249
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x04014D02 RID: 85250
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x04014D03 RID: 85251
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x04014D04 RID: 85252
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x04014D05 RID: 85253
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x04014D06 RID: 85254
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x04014D07 RID: 85255
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x04014D08 RID: 85256
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x04014D09 RID: 85257
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x04014D0A RID: 85258
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x04014D0B RID: 85259
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x04014D0C RID: 85260
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x04014D0D RID: 85261
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x04014D0E RID: 85262
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;

	// Token: 0x04014D0F RID: 85263
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache47;

	// Token: 0x04014D10 RID: 85264
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache48;

	// Token: 0x04014D11 RID: 85265
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache49;

	// Token: 0x04014D12 RID: 85266
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4A;

	// Token: 0x04014D13 RID: 85267
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4B;

	// Token: 0x04014D14 RID: 85268
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4C;

	// Token: 0x04014D15 RID: 85269
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4D;

	// Token: 0x04014D16 RID: 85270
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4E;

	// Token: 0x04014D17 RID: 85271
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4F;

	// Token: 0x04014D18 RID: 85272
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache50;

	// Token: 0x04014D19 RID: 85273
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache51;

	// Token: 0x04014D1A RID: 85274
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache52;

	// Token: 0x04014D1B RID: 85275
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache53;

	// Token: 0x04014D1C RID: 85276
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache54;

	// Token: 0x04014D1D RID: 85277
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache55;

	// Token: 0x04014D1E RID: 85278
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache56;

	// Token: 0x04014D1F RID: 85279
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache57;

	// Token: 0x04014D20 RID: 85280
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache58;

	// Token: 0x04014D21 RID: 85281
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache59;

	// Token: 0x04014D22 RID: 85282
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5A;

	// Token: 0x04014D23 RID: 85283
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5B;

	// Token: 0x04014D24 RID: 85284
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5C;

	// Token: 0x04014D25 RID: 85285
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5D;

	// Token: 0x04014D26 RID: 85286
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5E;

	// Token: 0x04014D27 RID: 85287
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5F;

	// Token: 0x04014D28 RID: 85288
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache60;

	// Token: 0x04014D29 RID: 85289
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache61;

	// Token: 0x04014D2A RID: 85290
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache62;

	// Token: 0x04014D2B RID: 85291
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache63;

	// Token: 0x04014D2C RID: 85292
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache64;

	// Token: 0x04014D2D RID: 85293
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache65;

	// Token: 0x04014D2E RID: 85294
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache66;

	// Token: 0x04014D2F RID: 85295
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache67;

	// Token: 0x04014D30 RID: 85296
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache68;

	// Token: 0x04014D31 RID: 85297
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache69;

	// Token: 0x04014D32 RID: 85298
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6A;

	// Token: 0x04014D33 RID: 85299
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6B;

	// Token: 0x04014D34 RID: 85300
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6C;

	// Token: 0x04014D35 RID: 85301
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6D;

	// Token: 0x04014D36 RID: 85302
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6E;

	// Token: 0x04014D37 RID: 85303
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6F;

	// Token: 0x04014D38 RID: 85304
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache70;

	// Token: 0x04014D39 RID: 85305
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache71;

	// Token: 0x04014D3A RID: 85306
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache72;

	// Token: 0x04014D3B RID: 85307
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache73;

	// Token: 0x04014D3C RID: 85308
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache74;

	// Token: 0x04014D3D RID: 85309
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache75;

	// Token: 0x04014D3E RID: 85310
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache76;

	// Token: 0x04014D3F RID: 85311
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache77;

	// Token: 0x04014D40 RID: 85312
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache78;

	// Token: 0x04014D41 RID: 85313
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache79;

	// Token: 0x04014D42 RID: 85314
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7A;

	// Token: 0x04014D43 RID: 85315
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7B;

	// Token: 0x04014D44 RID: 85316
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7C;

	// Token: 0x04014D45 RID: 85317
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7D;

	// Token: 0x04014D46 RID: 85318
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7E;

	// Token: 0x04014D47 RID: 85319
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7F;

	// Token: 0x04014D48 RID: 85320
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache80;

	// Token: 0x04014D49 RID: 85321
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache81;

	// Token: 0x04014D4A RID: 85322
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache82;

	// Token: 0x04014D4B RID: 85323
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache83;

	// Token: 0x04014D4C RID: 85324
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache84;

	// Token: 0x04014D4D RID: 85325
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache85;

	// Token: 0x04014D4E RID: 85326
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache86;

	// Token: 0x04014D4F RID: 85327
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache87;

	// Token: 0x04014D50 RID: 85328
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache88;

	// Token: 0x04014D51 RID: 85329
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache89;

	// Token: 0x04014D52 RID: 85330
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8A;

	// Token: 0x04014D53 RID: 85331
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8B;

	// Token: 0x04014D54 RID: 85332
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8C;

	// Token: 0x04014D55 RID: 85333
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8D;

	// Token: 0x04014D56 RID: 85334
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8E;

	// Token: 0x04014D57 RID: 85335
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8F;

	// Token: 0x04014D58 RID: 85336
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache90;

	// Token: 0x04014D59 RID: 85337
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache91;

	// Token: 0x04014D5A RID: 85338
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache92;

	// Token: 0x04014D5B RID: 85339
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache93;

	// Token: 0x04014D5C RID: 85340
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache94;

	// Token: 0x04014D5D RID: 85341
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache95;

	// Token: 0x04014D5E RID: 85342
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache96;

	// Token: 0x04014D5F RID: 85343
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache97;

	// Token: 0x04014D60 RID: 85344
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache98;

	// Token: 0x04014D61 RID: 85345
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache99;

	// Token: 0x04014D62 RID: 85346
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9A;

	// Token: 0x04014D63 RID: 85347
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9B;

	// Token: 0x04014D64 RID: 85348
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9C;

	// Token: 0x04014D65 RID: 85349
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9D;

	// Token: 0x04014D66 RID: 85350
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9E;

	// Token: 0x04014D67 RID: 85351
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9F;

	// Token: 0x04014D68 RID: 85352
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA0;

	// Token: 0x04014D69 RID: 85353
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA1;

	// Token: 0x04014D6A RID: 85354
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA2;

	// Token: 0x04014D6B RID: 85355
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA3;

	// Token: 0x04014D6C RID: 85356
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA4;

	// Token: 0x04014D6D RID: 85357
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA5;

	// Token: 0x04014D6E RID: 85358
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA6;

	// Token: 0x04014D6F RID: 85359
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA7;

	// Token: 0x04014D70 RID: 85360
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA8;

	// Token: 0x04014D71 RID: 85361
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA9;

	// Token: 0x04014D72 RID: 85362
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAA;

	// Token: 0x04014D73 RID: 85363
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAB;

	// Token: 0x04014D74 RID: 85364
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAC;

	// Token: 0x04014D75 RID: 85365
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAD;

	// Token: 0x04014D76 RID: 85366
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAE;

	// Token: 0x04014D77 RID: 85367
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAF;

	// Token: 0x04014D78 RID: 85368
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB0;

	// Token: 0x04014D79 RID: 85369
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB1;

	// Token: 0x04014D7A RID: 85370
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB2;

	// Token: 0x04014D7B RID: 85371
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB3;

	// Token: 0x04014D7C RID: 85372
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB4;

	// Token: 0x04014D7D RID: 85373
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB5;

	// Token: 0x04014D7E RID: 85374
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB6;

	// Token: 0x04014D7F RID: 85375
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB7;
}
