using System;
using System.Collections;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x0200155A RID: 5466
[Preserve]
public class Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController : LuaObject
{
	// Token: 0x06020AD6 RID: 133846 RVA: 0x00AECAE0 File Offset: 0x00AEACE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetBackgroundTransform(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsDescUIController rewardGoodsDescUIController = (RewardGoodsDescUIController)LuaObject.checkSelf(l);
			RectTransform backgroundTransform = rewardGoodsDescUIController.GetBackgroundTransform();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, backgroundTransform);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020AD7 RID: 133847 RVA: 0x00AECB34 File Offset: 0x00AEAD34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowRewardGoodsDesc(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsDescUIController rewardGoodsDescUIController = (RewardGoodsDescUIController)LuaObject.checkSelf(l);
			PrefabControllerBase ctrl;
			LuaObject.checkType<PrefabControllerBase>(l, 2, out ctrl);
			GoodsType goodsType;
			LuaObject.checkEnum<GoodsType>(l, 3, out goodsType);
			int goodsId;
			LuaObject.checkType(l, 4, out goodsId);
			int alignType;
			LuaObject.checkType(l, 5, out alignType);
			GameObject gameObjectForPosCalc;
			LuaObject.checkType<GameObject>(l, 6, out gameObjectForPosCalc);
			bool isNeedAutoClose;
			LuaObject.checkType(l, 7, out isNeedAutoClose);
			rewardGoodsDescUIController.ShowRewardGoodsDesc(ctrl, goodsType, goodsId, alignType, gameObjectForPosCalc, isNeedAutoClose);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020AD8 RID: 133848 RVA: 0x00AECBCC File Offset: 0x00AEADCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowPanel(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsDescUIController rewardGoodsDescUIController = (RewardGoodsDescUIController)LuaObject.checkSelf(l);
			rewardGoodsDescUIController.ShowPanel();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020AD9 RID: 133849 RVA: 0x00AECC18 File Offset: 0x00AEAE18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsDescUIController rewardGoodsDescUIController = (RewardGoodsDescUIController)LuaObject.checkSelf(l);
			rewardGoodsDescUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020ADA RID: 133850 RVA: 0x00AECC6C File Offset: 0x00AEAE6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitRewardGoodsDescInfo(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsDescUIController rewardGoodsDescUIController = (RewardGoodsDescUIController)LuaObject.checkSelf(l);
			GoodsType goodsType;
			LuaObject.checkEnum<GoodsType>(l, 2, out goodsType);
			int goodsId;
			LuaObject.checkType(l, 3, out goodsId);
			bool isNeedAutoClose;
			LuaObject.checkType(l, 4, out isNeedAutoClose);
			rewardGoodsDescUIController.m_luaExportHelper.InitRewardGoodsDescInfo(goodsType, goodsId, isNeedAutoClose);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020ADB RID: 133851 RVA: 0x00AECCE4 File Offset: 0x00AEAEE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetEquipmentPropInfo(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsDescUIController rewardGoodsDescUIController = (RewardGoodsDescUIController)LuaObject.checkSelf(l);
			int equipmentPropInfo;
			LuaObject.checkType(l, 2, out equipmentPropInfo);
			rewardGoodsDescUIController.m_luaExportHelper.SetEquipmentPropInfo(equipmentPropInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020ADC RID: 133852 RVA: 0x00AECD40 File Offset: 0x00AEAF40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetPropItems(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsDescUIController rewardGoodsDescUIController = (RewardGoodsDescUIController)LuaObject.checkSelf(l);
			PropertyModifyType type;
			LuaObject.checkEnum<PropertyModifyType>(l, 2, out type);
			int value;
			LuaObject.checkType(l, 3, out value);
			rewardGoodsDescUIController.m_luaExportHelper.SetPropItems(type, value);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020ADD RID: 133853 RVA: 0x00AECDAC File Offset: 0x00AEAFAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClosePanel(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsDescUIController rewardGoodsDescUIController = (RewardGoodsDescUIController)LuaObject.checkSelf(l);
			rewardGoodsDescUIController.m_luaExportHelper.ClosePanel();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020ADE RID: 133854 RVA: 0x00AECE00 File Offset: 0x00AEB000
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsDescUIController rewardGoodsDescUIController = (RewardGoodsDescUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			rewardGoodsDescUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020ADF RID: 133855 RVA: 0x00AECE6C File Offset: 0x00AEB06C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsDescUIController rewardGoodsDescUIController = (RewardGoodsDescUIController)LuaObject.checkSelf(l);
			rewardGoodsDescUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020AE0 RID: 133856 RVA: 0x00AECEC0 File Offset: 0x00AEB0C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsDescUIController rewardGoodsDescUIController = (RewardGoodsDescUIController)LuaObject.checkSelf(l);
			rewardGoodsDescUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020AE1 RID: 133857 RVA: 0x00AECF14 File Offset: 0x00AEB114
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsDescUIController rewardGoodsDescUIController = (RewardGoodsDescUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = rewardGoodsDescUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x06020AE2 RID: 133858 RVA: 0x00AECFBC File Offset: 0x00AEB1BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsDescUIController rewardGoodsDescUIController = (RewardGoodsDescUIController)LuaObject.checkSelf(l);
			rewardGoodsDescUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020AE3 RID: 133859 RVA: 0x00AED010 File Offset: 0x00AEB210
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsDescUIController rewardGoodsDescUIController = (RewardGoodsDescUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			rewardGoodsDescUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020AE4 RID: 133860 RVA: 0x00AED07C File Offset: 0x00AEB27C
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
				RewardGoodsDescUIController rewardGoodsDescUIController = (RewardGoodsDescUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				rewardGoodsDescUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				RewardGoodsDescUIController rewardGoodsDescUIController2 = (RewardGoodsDescUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				rewardGoodsDescUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x06020AE5 RID: 133861 RVA: 0x00AED18C File Offset: 0x00AEB38C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsDescUIController rewardGoodsDescUIController = (RewardGoodsDescUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			rewardGoodsDescUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020AE6 RID: 133862 RVA: 0x00AED1F8 File Offset: 0x00AEB3F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsDescUIController rewardGoodsDescUIController = (RewardGoodsDescUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			rewardGoodsDescUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020AE7 RID: 133863 RVA: 0x00AED264 File Offset: 0x00AEB464
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsDescUIController rewardGoodsDescUIController = (RewardGoodsDescUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			rewardGoodsDescUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020AE8 RID: 133864 RVA: 0x00AED2D0 File Offset: 0x00AEB4D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsDescUIController rewardGoodsDescUIController = (RewardGoodsDescUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			rewardGoodsDescUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020AE9 RID: 133865 RVA: 0x00AED33C File Offset: 0x00AEB53C
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
				RewardGoodsDescUIController rewardGoodsDescUIController = (RewardGoodsDescUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				rewardGoodsDescUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				RewardGoodsDescUIController rewardGoodsDescUIController2 = (RewardGoodsDescUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				rewardGoodsDescUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x06020AEA RID: 133866 RVA: 0x00AED44C File Offset: 0x00AEB64C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsDescUIController rewardGoodsDescUIController = (RewardGoodsDescUIController)LuaObject.checkSelf(l);
			string s = rewardGoodsDescUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x06020AEB RID: 133867 RVA: 0x00AED4A8 File Offset: 0x00AEB6A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsDescUIController rewardGoodsDescUIController = (RewardGoodsDescUIController)LuaObject.checkSelf(l);
			rewardGoodsDescUIController.m_luaExportHelper.__callDele_EventOnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020AEC RID: 133868 RVA: 0x00AED4FC File Offset: 0x00AEB6FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsDescUIController rewardGoodsDescUIController = (RewardGoodsDescUIController)LuaObject.checkSelf(l);
			rewardGoodsDescUIController.m_luaExportHelper.__clearDele_EventOnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020AED RID: 133869 RVA: 0x00AED550 File Offset: 0x00AEB750
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Co_ShowRewardGoodsDesc_s(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsDescUIController descCtrl;
			LuaObject.checkType<RewardGoodsDescUIController>(l, 1, out descCtrl);
			GameObject gameObjectForPosCalc;
			LuaObject.checkType<GameObject>(l, 2, out gameObjectForPosCalc);
			int alignType;
			LuaObject.checkType(l, 3, out alignType);
			IEnumerator o = RewardGoodsDescUIController.LuaExportHelper.Co_ShowRewardGoodsDesc(descCtrl, gameObjectForPosCalc, alignType);
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

	// Token: 0x06020AEE RID: 133870 RVA: 0x00AED5C0 File Offset: 0x00AEB7C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsDescUIController rewardGoodsDescUIController = (RewardGoodsDescUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					rewardGoodsDescUIController.EventOnClose += value;
				}
				else if (num == 2)
				{
					rewardGoodsDescUIController.EventOnClose -= value;
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

	// Token: 0x06020AEF RID: 133871 RVA: 0x00AED640 File Offset: 0x00AEB840
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_goodsType(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsDescUIController rewardGoodsDescUIController = (RewardGoodsDescUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)rewardGoodsDescUIController.m_luaExportHelper.m_goodsType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020AF0 RID: 133872 RVA: 0x00AED698 File Offset: 0x00AEB898
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_goodsType(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsDescUIController rewardGoodsDescUIController = (RewardGoodsDescUIController)LuaObject.checkSelf(l);
			GoodsType goodsType;
			LuaObject.checkEnum<GoodsType>(l, 2, out goodsType);
			rewardGoodsDescUIController.m_luaExportHelper.m_goodsType = goodsType;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020AF1 RID: 133873 RVA: 0x00AED6F4 File Offset: 0x00AEB8F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_goodsId(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsDescUIController rewardGoodsDescUIController = (RewardGoodsDescUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rewardGoodsDescUIController.m_luaExportHelper.m_goodsId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020AF2 RID: 133874 RVA: 0x00AED74C File Offset: 0x00AEB94C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_goodsId(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsDescUIController rewardGoodsDescUIController = (RewardGoodsDescUIController)LuaObject.checkSelf(l);
			int goodsId;
			LuaObject.checkType(l, 2, out goodsId);
			rewardGoodsDescUIController.m_luaExportHelper.m_goodsId = goodsId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020AF3 RID: 133875 RVA: 0x00AED7A8 File Offset: 0x00AEB9A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiStateController(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsDescUIController rewardGoodsDescUIController = (RewardGoodsDescUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rewardGoodsDescUIController.m_luaExportHelper.m_uiStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020AF4 RID: 133876 RVA: 0x00AED800 File Offset: 0x00AEBA00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiStateController(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsDescUIController rewardGoodsDescUIController = (RewardGoodsDescUIController)LuaObject.checkSelf(l);
			CommonUIStateController uiStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out uiStateController);
			rewardGoodsDescUIController.m_luaExportHelper.m_uiStateController = uiStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020AF5 RID: 133877 RVA: 0x00AED85C File Offset: 0x00AEBA5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_HPGo(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsDescUIController rewardGoodsDescUIController = (RewardGoodsDescUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rewardGoodsDescUIController.m_luaExportHelper.HPGo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020AF6 RID: 133878 RVA: 0x00AED8B4 File Offset: 0x00AEBAB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_HPGo(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsDescUIController rewardGoodsDescUIController = (RewardGoodsDescUIController)LuaObject.checkSelf(l);
			GameObject hpgo;
			LuaObject.checkType<GameObject>(l, 2, out hpgo);
			rewardGoodsDescUIController.m_luaExportHelper.HPGo = hpgo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020AF7 RID: 133879 RVA: 0x00AED910 File Offset: 0x00AEBB10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ATGo(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsDescUIController rewardGoodsDescUIController = (RewardGoodsDescUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rewardGoodsDescUIController.m_luaExportHelper.ATGo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020AF8 RID: 133880 RVA: 0x00AED968 File Offset: 0x00AEBB68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ATGo(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsDescUIController rewardGoodsDescUIController = (RewardGoodsDescUIController)LuaObject.checkSelf(l);
			GameObject atgo;
			LuaObject.checkType<GameObject>(l, 2, out atgo);
			rewardGoodsDescUIController.m_luaExportHelper.ATGo = atgo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020AF9 RID: 133881 RVA: 0x00AED9C4 File Offset: 0x00AEBBC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_DFGo(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsDescUIController rewardGoodsDescUIController = (RewardGoodsDescUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rewardGoodsDescUIController.m_luaExportHelper.DFGo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020AFA RID: 133882 RVA: 0x00AEDA1C File Offset: 0x00AEBC1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_DFGo(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsDescUIController rewardGoodsDescUIController = (RewardGoodsDescUIController)LuaObject.checkSelf(l);
			GameObject dfgo;
			LuaObject.checkType<GameObject>(l, 2, out dfgo);
			rewardGoodsDescUIController.m_luaExportHelper.DFGo = dfgo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020AFB RID: 133883 RVA: 0x00AEDA78 File Offset: 0x00AEBC78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_MagicGo(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsDescUIController rewardGoodsDescUIController = (RewardGoodsDescUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rewardGoodsDescUIController.m_luaExportHelper.MagicGo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020AFC RID: 133884 RVA: 0x00AEDAD0 File Offset: 0x00AEBCD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_MagicGo(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsDescUIController rewardGoodsDescUIController = (RewardGoodsDescUIController)LuaObject.checkSelf(l);
			GameObject magicGo;
			LuaObject.checkType<GameObject>(l, 2, out magicGo);
			rewardGoodsDescUIController.m_luaExportHelper.MagicGo = magicGo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020AFD RID: 133885 RVA: 0x00AEDB2C File Offset: 0x00AEBD2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_MagicDFGo(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsDescUIController rewardGoodsDescUIController = (RewardGoodsDescUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rewardGoodsDescUIController.m_luaExportHelper.MagicDFGo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020AFE RID: 133886 RVA: 0x00AEDB84 File Offset: 0x00AEBD84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_MagicDFGo(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsDescUIController rewardGoodsDescUIController = (RewardGoodsDescUIController)LuaObject.checkSelf(l);
			GameObject magicDFGo;
			LuaObject.checkType<GameObject>(l, 2, out magicDFGo);
			rewardGoodsDescUIController.m_luaExportHelper.MagicDFGo = magicDFGo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020AFF RID: 133887 RVA: 0x00AEDBE0 File Offset: 0x00AEBDE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_DEXGo(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsDescUIController rewardGoodsDescUIController = (RewardGoodsDescUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rewardGoodsDescUIController.m_luaExportHelper.DEXGo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020B00 RID: 133888 RVA: 0x00AEDC38 File Offset: 0x00AEBE38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_DEXGo(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsDescUIController rewardGoodsDescUIController = (RewardGoodsDescUIController)LuaObject.checkSelf(l);
			GameObject dexgo;
			LuaObject.checkType<GameObject>(l, 2, out dexgo);
			rewardGoodsDescUIController.m_luaExportHelper.DEXGo = dexgo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020B01 RID: 133889 RVA: 0x00AEDC94 File Offset: 0x00AEBE94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_HPText(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsDescUIController rewardGoodsDescUIController = (RewardGoodsDescUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rewardGoodsDescUIController.m_luaExportHelper.HPText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020B02 RID: 133890 RVA: 0x00AEDCEC File Offset: 0x00AEBEEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_HPText(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsDescUIController rewardGoodsDescUIController = (RewardGoodsDescUIController)LuaObject.checkSelf(l);
			Text hptext;
			LuaObject.checkType<Text>(l, 2, out hptext);
			rewardGoodsDescUIController.m_luaExportHelper.HPText = hptext;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020B03 RID: 133891 RVA: 0x00AEDD48 File Offset: 0x00AEBF48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ATText(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsDescUIController rewardGoodsDescUIController = (RewardGoodsDescUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rewardGoodsDescUIController.m_luaExportHelper.ATText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020B04 RID: 133892 RVA: 0x00AEDDA0 File Offset: 0x00AEBFA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ATText(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsDescUIController rewardGoodsDescUIController = (RewardGoodsDescUIController)LuaObject.checkSelf(l);
			Text attext;
			LuaObject.checkType<Text>(l, 2, out attext);
			rewardGoodsDescUIController.m_luaExportHelper.ATText = attext;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020B05 RID: 133893 RVA: 0x00AEDDFC File Offset: 0x00AEBFFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_DFText(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsDescUIController rewardGoodsDescUIController = (RewardGoodsDescUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rewardGoodsDescUIController.m_luaExportHelper.DFText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020B06 RID: 133894 RVA: 0x00AEDE54 File Offset: 0x00AEC054
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_DFText(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsDescUIController rewardGoodsDescUIController = (RewardGoodsDescUIController)LuaObject.checkSelf(l);
			Text dftext;
			LuaObject.checkType<Text>(l, 2, out dftext);
			rewardGoodsDescUIController.m_luaExportHelper.DFText = dftext;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020B07 RID: 133895 RVA: 0x00AEDEB0 File Offset: 0x00AEC0B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_MagicText(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsDescUIController rewardGoodsDescUIController = (RewardGoodsDescUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rewardGoodsDescUIController.m_luaExportHelper.MagicText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020B08 RID: 133896 RVA: 0x00AEDF08 File Offset: 0x00AEC108
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_MagicText(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsDescUIController rewardGoodsDescUIController = (RewardGoodsDescUIController)LuaObject.checkSelf(l);
			Text magicText;
			LuaObject.checkType<Text>(l, 2, out magicText);
			rewardGoodsDescUIController.m_luaExportHelper.MagicText = magicText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020B09 RID: 133897 RVA: 0x00AEDF64 File Offset: 0x00AEC164
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_MagicDFText(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsDescUIController rewardGoodsDescUIController = (RewardGoodsDescUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rewardGoodsDescUIController.m_luaExportHelper.MagicDFText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020B0A RID: 133898 RVA: 0x00AEDFBC File Offset: 0x00AEC1BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_MagicDFText(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsDescUIController rewardGoodsDescUIController = (RewardGoodsDescUIController)LuaObject.checkSelf(l);
			Text magicDFText;
			LuaObject.checkType<Text>(l, 2, out magicDFText);
			rewardGoodsDescUIController.m_luaExportHelper.MagicDFText = magicDFText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020B0B RID: 133899 RVA: 0x00AEE018 File Offset: 0x00AEC218
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_DEXText(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsDescUIController rewardGoodsDescUIController = (RewardGoodsDescUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rewardGoodsDescUIController.m_luaExportHelper.DEXText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020B0C RID: 133900 RVA: 0x00AEE070 File Offset: 0x00AEC270
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_DEXText(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsDescUIController rewardGoodsDescUIController = (RewardGoodsDescUIController)LuaObject.checkSelf(l);
			Text dextext;
			LuaObject.checkType<Text>(l, 2, out dextext);
			rewardGoodsDescUIController.m_luaExportHelper.DEXText = dextext;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020B0D RID: 133901 RVA: 0x00AEE0CC File Offset: 0x00AEC2CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_backgroundTransform(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsDescUIController rewardGoodsDescUIController = (RewardGoodsDescUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rewardGoodsDescUIController.m_luaExportHelper.m_backgroundTransform);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020B0E RID: 133902 RVA: 0x00AEE124 File Offset: 0x00AEC324
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_backgroundTransform(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsDescUIController rewardGoodsDescUIController = (RewardGoodsDescUIController)LuaObject.checkSelf(l);
			RectTransform backgroundTransform;
			LuaObject.checkType<RectTransform>(l, 2, out backgroundTransform);
			rewardGoodsDescUIController.m_luaExportHelper.m_backgroundTransform = backgroundTransform;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020B0F RID: 133903 RVA: 0x00AEE180 File Offset: 0x00AEC380
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.RewardGoodsDescUIController");
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.GetBackgroundTransform);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.ShowRewardGoodsDesc);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.ShowPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.InitRewardGoodsDescInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.SetEquipmentPropInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.SetPropItems);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.ClosePanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.__callDele_EventOnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.__clearDele_EventOnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.Co_ShowRewardGoodsDesc_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache17);
		string name = "EventOnClose";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.set_EventOnClose);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache18, true);
		string name2 = "m_goodsType";
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.get_m_goodsType);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache19;
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.set_m_goodsType);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache1A, true);
		string name3 = "m_goodsId";
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.get_m_goodsId);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache1B;
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.set_m_goodsId);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache1C, true);
		string name4 = "m_uiStateController";
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.get_m_uiStateController);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache1D;
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.set_m_uiStateController);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache1E, true);
		string name5 = "HPGo";
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.get_HPGo);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache1F;
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.set_HPGo);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache20, true);
		string name6 = "ATGo";
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.get_ATGo);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache21;
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.set_ATGo);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache22, true);
		string name7 = "DFGo";
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.get_DFGo);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache23;
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.set_DFGo);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache24, true);
		string name8 = "MagicGo";
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.get_MagicGo);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache25;
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.set_MagicGo);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache26, true);
		string name9 = "MagicDFGo";
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.get_MagicDFGo);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache27;
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.set_MagicDFGo);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache28, true);
		string name10 = "DEXGo";
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.get_DEXGo);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache29;
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.set_DEXGo);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache2A, true);
		string name11 = "HPText";
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.get_HPText);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache2B;
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.set_HPText);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache2C, true);
		string name12 = "ATText";
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.get_ATText);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache2D;
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.set_ATText);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache2E, true);
		string name13 = "DFText";
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.get_DFText);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache2F;
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.set_DFText);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache30, true);
		string name14 = "MagicText";
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.get_MagicText);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache31;
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.set_MagicText);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache32, true);
		string name15 = "MagicDFText";
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.get_MagicDFText);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache33;
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.set_MagicDFText);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache34, true);
		string name16 = "DEXText";
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.get_DEXText);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache35;
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.set_DEXText);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache36, true);
		string name17 = "m_backgroundTransform";
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.get_m_backgroundTransform);
		}
		LuaCSFunction get17 = Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache37;
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.set_m_backgroundTransform);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.<>f__mg$cache38, true);
		LuaObject.createTypeMetatable(l, null, typeof(RewardGoodsDescUIController), typeof(UIControllerBase));
	}

	// Token: 0x04016A04 RID: 92676
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04016A05 RID: 92677
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04016A06 RID: 92678
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04016A07 RID: 92679
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04016A08 RID: 92680
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04016A09 RID: 92681
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04016A0A RID: 92682
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04016A0B RID: 92683
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04016A0C RID: 92684
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04016A0D RID: 92685
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04016A0E RID: 92686
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04016A0F RID: 92687
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04016A10 RID: 92688
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04016A11 RID: 92689
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04016A12 RID: 92690
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04016A13 RID: 92691
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04016A14 RID: 92692
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04016A15 RID: 92693
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04016A16 RID: 92694
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04016A17 RID: 92695
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04016A18 RID: 92696
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04016A19 RID: 92697
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04016A1A RID: 92698
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04016A1B RID: 92699
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04016A1C RID: 92700
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04016A1D RID: 92701
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04016A1E RID: 92702
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04016A1F RID: 92703
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04016A20 RID: 92704
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04016A21 RID: 92705
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04016A22 RID: 92706
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04016A23 RID: 92707
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04016A24 RID: 92708
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04016A25 RID: 92709
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04016A26 RID: 92710
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04016A27 RID: 92711
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04016A28 RID: 92712
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04016A29 RID: 92713
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04016A2A RID: 92714
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04016A2B RID: 92715
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04016A2C RID: 92716
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04016A2D RID: 92717
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04016A2E RID: 92718
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04016A2F RID: 92719
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04016A30 RID: 92720
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04016A31 RID: 92721
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04016A32 RID: 92722
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04016A33 RID: 92723
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04016A34 RID: 92724
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04016A35 RID: 92725
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04016A36 RID: 92726
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x04016A37 RID: 92727
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x04016A38 RID: 92728
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x04016A39 RID: 92729
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x04016A3A RID: 92730
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x04016A3B RID: 92731
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x04016A3C RID: 92732
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;
}
