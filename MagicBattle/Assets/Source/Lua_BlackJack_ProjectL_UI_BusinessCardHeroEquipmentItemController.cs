using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x020013D7 RID: 5079
[Preserve]
public class Lua_BlackJack_ProjectL_UI_BusinessCardHeroEquipmentItemController : LuaObject
{
	// Token: 0x0601C678 RID: 116344 RVA: 0x008CD83C File Offset: 0x008CBA3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetEquipmentInfo(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardHeroEquipmentItemController businessCardHeroEquipmentItemController = (BusinessCardHeroEquipmentItemController)LuaObject.checkSelf(l);
			BattleHeroEquipment equipmentInfo;
			LuaObject.checkType<BattleHeroEquipment>(l, 2, out equipmentInfo);
			businessCardHeroEquipmentItemController.SetEquipmentInfo(equipmentInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C679 RID: 116345 RVA: 0x008CD894 File Offset: 0x008CBA94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetEquipment(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardHeroEquipmentItemController businessCardHeroEquipmentItemController = (BusinessCardHeroEquipmentItemController)LuaObject.checkSelf(l);
			BattleHeroEquipment equipment = businessCardHeroEquipmentItemController.GetEquipment();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipment);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C67A RID: 116346 RVA: 0x008CD8E8 File Offset: 0x008CBAE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardHeroEquipmentItemController businessCardHeroEquipmentItemController = (BusinessCardHeroEquipmentItemController)LuaObject.checkSelf(l);
			businessCardHeroEquipmentItemController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C67B RID: 116347 RVA: 0x008CD93C File Offset: 0x008CBB3C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnItemClick(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardHeroEquipmentItemController businessCardHeroEquipmentItemController = (BusinessCardHeroEquipmentItemController)LuaObject.checkSelf(l);
			businessCardHeroEquipmentItemController.m_luaExportHelper.OnItemClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C67C RID: 116348 RVA: 0x008CD990 File Offset: 0x008CBB90
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardHeroEquipmentItemController businessCardHeroEquipmentItemController = (BusinessCardHeroEquipmentItemController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			businessCardHeroEquipmentItemController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C67D RID: 116349 RVA: 0x008CD9FC File Offset: 0x008CBBFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardHeroEquipmentItemController businessCardHeroEquipmentItemController = (BusinessCardHeroEquipmentItemController)LuaObject.checkSelf(l);
			businessCardHeroEquipmentItemController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C67E RID: 116350 RVA: 0x008CDA50 File Offset: 0x008CBC50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardHeroEquipmentItemController businessCardHeroEquipmentItemController = (BusinessCardHeroEquipmentItemController)LuaObject.checkSelf(l);
			businessCardHeroEquipmentItemController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C67F RID: 116351 RVA: 0x008CDAA4 File Offset: 0x008CBCA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardHeroEquipmentItemController businessCardHeroEquipmentItemController = (BusinessCardHeroEquipmentItemController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = businessCardHeroEquipmentItemController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601C680 RID: 116352 RVA: 0x008CDB4C File Offset: 0x008CBD4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardHeroEquipmentItemController businessCardHeroEquipmentItemController = (BusinessCardHeroEquipmentItemController)LuaObject.checkSelf(l);
			businessCardHeroEquipmentItemController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C681 RID: 116353 RVA: 0x008CDBA0 File Offset: 0x008CBDA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardHeroEquipmentItemController businessCardHeroEquipmentItemController = (BusinessCardHeroEquipmentItemController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			businessCardHeroEquipmentItemController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C682 RID: 116354 RVA: 0x008CDC0C File Offset: 0x008CBE0C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetButtonClickListener(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(string[]), typeof(Action<UIControllerBase>)))
			{
				BusinessCardHeroEquipmentItemController businessCardHeroEquipmentItemController = (BusinessCardHeroEquipmentItemController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				businessCardHeroEquipmentItemController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				BusinessCardHeroEquipmentItemController businessCardHeroEquipmentItemController2 = (BusinessCardHeroEquipmentItemController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				businessCardHeroEquipmentItemController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601C683 RID: 116355 RVA: 0x008CDD1C File Offset: 0x008CBF1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardHeroEquipmentItemController businessCardHeroEquipmentItemController = (BusinessCardHeroEquipmentItemController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			businessCardHeroEquipmentItemController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C684 RID: 116356 RVA: 0x008CDD88 File Offset: 0x008CBF88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardHeroEquipmentItemController businessCardHeroEquipmentItemController = (BusinessCardHeroEquipmentItemController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			businessCardHeroEquipmentItemController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C685 RID: 116357 RVA: 0x008CDDF4 File Offset: 0x008CBFF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardHeroEquipmentItemController businessCardHeroEquipmentItemController = (BusinessCardHeroEquipmentItemController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			businessCardHeroEquipmentItemController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C686 RID: 116358 RVA: 0x008CDE60 File Offset: 0x008CC060
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardHeroEquipmentItemController businessCardHeroEquipmentItemController = (BusinessCardHeroEquipmentItemController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			businessCardHeroEquipmentItemController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C687 RID: 116359 RVA: 0x008CDECC File Offset: 0x008CC0CC
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
				BusinessCardHeroEquipmentItemController businessCardHeroEquipmentItemController = (BusinessCardHeroEquipmentItemController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				businessCardHeroEquipmentItemController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				BusinessCardHeroEquipmentItemController businessCardHeroEquipmentItemController2 = (BusinessCardHeroEquipmentItemController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				businessCardHeroEquipmentItemController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601C688 RID: 116360 RVA: 0x008CDFDC File Offset: 0x008CC1DC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardHeroEquipmentItemController businessCardHeroEquipmentItemController = (BusinessCardHeroEquipmentItemController)LuaObject.checkSelf(l);
			string s = businessCardHeroEquipmentItemController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601C689 RID: 116361 RVA: 0x008CE038 File Offset: 0x008CC238
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnClick(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardHeroEquipmentItemController businessCardHeroEquipmentItemController = (BusinessCardHeroEquipmentItemController)LuaObject.checkSelf(l);
			BusinessCardHeroEquipmentItemController obj;
			LuaObject.checkType<BusinessCardHeroEquipmentItemController>(l, 2, out obj);
			businessCardHeroEquipmentItemController.m_luaExportHelper.__callDele_EventOnClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C68A RID: 116362 RVA: 0x008CE094 File Offset: 0x008CC294
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __clearDele_EventOnClick(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardHeroEquipmentItemController businessCardHeroEquipmentItemController = (BusinessCardHeroEquipmentItemController)LuaObject.checkSelf(l);
			BusinessCardHeroEquipmentItemController obj;
			LuaObject.checkType<BusinessCardHeroEquipmentItemController>(l, 2, out obj);
			businessCardHeroEquipmentItemController.m_luaExportHelper.__clearDele_EventOnClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C68B RID: 116363 RVA: 0x008CE0F0 File Offset: 0x008CC2F0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_EventOnClick(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardHeroEquipmentItemController businessCardHeroEquipmentItemController = (BusinessCardHeroEquipmentItemController)LuaObject.checkSelf(l);
			Action<BusinessCardHeroEquipmentItemController> value;
			int num = LuaObject.checkDelegate<Action<BusinessCardHeroEquipmentItemController>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					businessCardHeroEquipmentItemController.EventOnClick += value;
				}
				else if (num == 2)
				{
					businessCardHeroEquipmentItemController.EventOnClick -= value;
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

	// Token: 0x0601C68C RID: 116364 RVA: 0x008CE170 File Offset: 0x008CC370
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_equipmentItemButton(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardHeroEquipmentItemController businessCardHeroEquipmentItemController = (BusinessCardHeroEquipmentItemController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardHeroEquipmentItemController.m_luaExportHelper.m_equipmentItemButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C68D RID: 116365 RVA: 0x008CE1C8 File Offset: 0x008CC3C8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_equipmentItemButton(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardHeroEquipmentItemController businessCardHeroEquipmentItemController = (BusinessCardHeroEquipmentItemController)LuaObject.checkSelf(l);
			Button equipmentItemButton;
			LuaObject.checkType<Button>(l, 2, out equipmentItemButton);
			businessCardHeroEquipmentItemController.m_luaExportHelper.m_equipmentItemButton = equipmentItemButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C68E RID: 116366 RVA: 0x008CE224 File Offset: 0x008CC424
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_equipmentItemBGImage(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardHeroEquipmentItemController businessCardHeroEquipmentItemController = (BusinessCardHeroEquipmentItemController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardHeroEquipmentItemController.m_luaExportHelper.m_equipmentItemBGImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C68F RID: 116367 RVA: 0x008CE27C File Offset: 0x008CC47C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_equipmentItemBGImage(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardHeroEquipmentItemController businessCardHeroEquipmentItemController = (BusinessCardHeroEquipmentItemController)LuaObject.checkSelf(l);
			Image equipmentItemBGImage;
			LuaObject.checkType<Image>(l, 2, out equipmentItemBGImage);
			businessCardHeroEquipmentItemController.m_luaExportHelper.m_equipmentItemBGImage = equipmentItemBGImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C690 RID: 116368 RVA: 0x008CE2D8 File Offset: 0x008CC4D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_equipmentSSREffectGameObject(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardHeroEquipmentItemController businessCardHeroEquipmentItemController = (BusinessCardHeroEquipmentItemController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardHeroEquipmentItemController.m_luaExportHelper.m_equipmentSSREffectGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C691 RID: 116369 RVA: 0x008CE330 File Offset: 0x008CC530
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_equipmentSSREffectGameObject(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardHeroEquipmentItemController businessCardHeroEquipmentItemController = (BusinessCardHeroEquipmentItemController)LuaObject.checkSelf(l);
			GameObject equipmentSSREffectGameObject;
			LuaObject.checkType<GameObject>(l, 2, out equipmentSSREffectGameObject);
			businessCardHeroEquipmentItemController.m_luaExportHelper.m_equipmentSSREffectGameObject = equipmentSSREffectGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C692 RID: 116370 RVA: 0x008CE38C File Offset: 0x008CC58C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_equipmentItemIcon(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardHeroEquipmentItemController businessCardHeroEquipmentItemController = (BusinessCardHeroEquipmentItemController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardHeroEquipmentItemController.m_luaExportHelper.m_equipmentItemIcon);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C693 RID: 116371 RVA: 0x008CE3E4 File Offset: 0x008CC5E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_equipmentItemIcon(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardHeroEquipmentItemController businessCardHeroEquipmentItemController = (BusinessCardHeroEquipmentItemController)LuaObject.checkSelf(l);
			Image equipmentItemIcon;
			LuaObject.checkType<Image>(l, 2, out equipmentItemIcon);
			businessCardHeroEquipmentItemController.m_luaExportHelper.m_equipmentItemIcon = equipmentItemIcon;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C694 RID: 116372 RVA: 0x008CE440 File Offset: 0x008CC640
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_equipmentItemStarGroup(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardHeroEquipmentItemController businessCardHeroEquipmentItemController = (BusinessCardHeroEquipmentItemController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardHeroEquipmentItemController.m_luaExportHelper.m_equipmentItemStarGroup);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C695 RID: 116373 RVA: 0x008CE498 File Offset: 0x008CC698
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_equipmentItemStarGroup(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardHeroEquipmentItemController businessCardHeroEquipmentItemController = (BusinessCardHeroEquipmentItemController)LuaObject.checkSelf(l);
			GameObject equipmentItemStarGroup;
			LuaObject.checkType<GameObject>(l, 2, out equipmentItemStarGroup);
			businessCardHeroEquipmentItemController.m_luaExportHelper.m_equipmentItemStarGroup = equipmentItemStarGroup;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C696 RID: 116374 RVA: 0x008CE4F4 File Offset: 0x008CC6F4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_equipment(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardHeroEquipmentItemController businessCardHeroEquipmentItemController = (BusinessCardHeroEquipmentItemController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardHeroEquipmentItemController.m_luaExportHelper.m_equipment);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C697 RID: 116375 RVA: 0x008CE54C File Offset: 0x008CC74C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_equipment(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardHeroEquipmentItemController businessCardHeroEquipmentItemController = (BusinessCardHeroEquipmentItemController)LuaObject.checkSelf(l);
			BattleHeroEquipment equipment;
			LuaObject.checkType<BattleHeroEquipment>(l, 2, out equipment);
			businessCardHeroEquipmentItemController.m_luaExportHelper.m_equipment = equipment;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C698 RID: 116376 RVA: 0x008CE5A8 File Offset: 0x008CC7A8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.BusinessCardHeroEquipmentItemController");
		if (Lua_BlackJack_ProjectL_UI_BusinessCardHeroEquipmentItemController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardHeroEquipmentItemController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardHeroEquipmentItemController.SetEquipmentInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardHeroEquipmentItemController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardHeroEquipmentItemController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardHeroEquipmentItemController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardHeroEquipmentItemController.GetEquipment);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardHeroEquipmentItemController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardHeroEquipmentItemController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardHeroEquipmentItemController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardHeroEquipmentItemController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardHeroEquipmentItemController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardHeroEquipmentItemController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardHeroEquipmentItemController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardHeroEquipmentItemController.OnItemClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardHeroEquipmentItemController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardHeroEquipmentItemController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardHeroEquipmentItemController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardHeroEquipmentItemController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardHeroEquipmentItemController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardHeroEquipmentItemController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardHeroEquipmentItemController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardHeroEquipmentItemController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardHeroEquipmentItemController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardHeroEquipmentItemController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardHeroEquipmentItemController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardHeroEquipmentItemController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardHeroEquipmentItemController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardHeroEquipmentItemController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardHeroEquipmentItemController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardHeroEquipmentItemController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardHeroEquipmentItemController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardHeroEquipmentItemController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardHeroEquipmentItemController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardHeroEquipmentItemController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardHeroEquipmentItemController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardHeroEquipmentItemController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardHeroEquipmentItemController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardHeroEquipmentItemController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardHeroEquipmentItemController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardHeroEquipmentItemController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardHeroEquipmentItemController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardHeroEquipmentItemController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardHeroEquipmentItemController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardHeroEquipmentItemController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardHeroEquipmentItemController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardHeroEquipmentItemController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardHeroEquipmentItemController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardHeroEquipmentItemController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardHeroEquipmentItemController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardHeroEquipmentItemController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardHeroEquipmentItemController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardHeroEquipmentItemController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardHeroEquipmentItemController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardHeroEquipmentItemController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardHeroEquipmentItemController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardHeroEquipmentItemController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardHeroEquipmentItemController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardHeroEquipmentItemController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardHeroEquipmentItemController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardHeroEquipmentItemController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardHeroEquipmentItemController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardHeroEquipmentItemController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardHeroEquipmentItemController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardHeroEquipmentItemController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardHeroEquipmentItemController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardHeroEquipmentItemController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardHeroEquipmentItemController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardHeroEquipmentItemController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardHeroEquipmentItemController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardHeroEquipmentItemController.__callDele_EventOnClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardHeroEquipmentItemController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardHeroEquipmentItemController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardHeroEquipmentItemController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardHeroEquipmentItemController.__clearDele_EventOnClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardHeroEquipmentItemController.<>f__mg$cache12);
		string name = "EventOnClick";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardHeroEquipmentItemController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardHeroEquipmentItemController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardHeroEquipmentItemController.set_EventOnClick);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_BusinessCardHeroEquipmentItemController.<>f__mg$cache13, true);
		string name2 = "m_equipmentItemButton";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardHeroEquipmentItemController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardHeroEquipmentItemController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardHeroEquipmentItemController.get_m_equipmentItemButton);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_BusinessCardHeroEquipmentItemController.<>f__mg$cache14;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardHeroEquipmentItemController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardHeroEquipmentItemController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardHeroEquipmentItemController.set_m_equipmentItemButton);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_BusinessCardHeroEquipmentItemController.<>f__mg$cache15, true);
		string name3 = "m_equipmentItemBGImage";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardHeroEquipmentItemController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardHeroEquipmentItemController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardHeroEquipmentItemController.get_m_equipmentItemBGImage);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_BusinessCardHeroEquipmentItemController.<>f__mg$cache16;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardHeroEquipmentItemController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardHeroEquipmentItemController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardHeroEquipmentItemController.set_m_equipmentItemBGImage);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_BusinessCardHeroEquipmentItemController.<>f__mg$cache17, true);
		string name4 = "m_equipmentSSREffectGameObject";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardHeroEquipmentItemController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardHeroEquipmentItemController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardHeroEquipmentItemController.get_m_equipmentSSREffectGameObject);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_BusinessCardHeroEquipmentItemController.<>f__mg$cache18;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardHeroEquipmentItemController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardHeroEquipmentItemController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardHeroEquipmentItemController.set_m_equipmentSSREffectGameObject);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_BusinessCardHeroEquipmentItemController.<>f__mg$cache19, true);
		string name5 = "m_equipmentItemIcon";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardHeroEquipmentItemController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardHeroEquipmentItemController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardHeroEquipmentItemController.get_m_equipmentItemIcon);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_BusinessCardHeroEquipmentItemController.<>f__mg$cache1A;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardHeroEquipmentItemController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardHeroEquipmentItemController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardHeroEquipmentItemController.set_m_equipmentItemIcon);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_BusinessCardHeroEquipmentItemController.<>f__mg$cache1B, true);
		string name6 = "m_equipmentItemStarGroup";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardHeroEquipmentItemController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardHeroEquipmentItemController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardHeroEquipmentItemController.get_m_equipmentItemStarGroup);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_BusinessCardHeroEquipmentItemController.<>f__mg$cache1C;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardHeroEquipmentItemController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardHeroEquipmentItemController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardHeroEquipmentItemController.set_m_equipmentItemStarGroup);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_BusinessCardHeroEquipmentItemController.<>f__mg$cache1D, true);
		string name7 = "m_equipment";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardHeroEquipmentItemController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardHeroEquipmentItemController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardHeroEquipmentItemController.get_m_equipment);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_BusinessCardHeroEquipmentItemController.<>f__mg$cache1E;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardHeroEquipmentItemController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardHeroEquipmentItemController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardHeroEquipmentItemController.set_m_equipment);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_BusinessCardHeroEquipmentItemController.<>f__mg$cache1F, true);
		LuaObject.createTypeMetatable(l, null, typeof(BusinessCardHeroEquipmentItemController), typeof(UIControllerBase));
	}

	// Token: 0x040128AC RID: 75948
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040128AD RID: 75949
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040128AE RID: 75950
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040128AF RID: 75951
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040128B0 RID: 75952
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040128B1 RID: 75953
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040128B2 RID: 75954
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040128B3 RID: 75955
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x040128B4 RID: 75956
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x040128B5 RID: 75957
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x040128B6 RID: 75958
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x040128B7 RID: 75959
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x040128B8 RID: 75960
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x040128B9 RID: 75961
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x040128BA RID: 75962
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x040128BB RID: 75963
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x040128BC RID: 75964
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x040128BD RID: 75965
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x040128BE RID: 75966
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x040128BF RID: 75967
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x040128C0 RID: 75968
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x040128C1 RID: 75969
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x040128C2 RID: 75970
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x040128C3 RID: 75971
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x040128C4 RID: 75972
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x040128C5 RID: 75973
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x040128C6 RID: 75974
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x040128C7 RID: 75975
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x040128C8 RID: 75976
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x040128C9 RID: 75977
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x040128CA RID: 75978
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x040128CB RID: 75979
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;
}
