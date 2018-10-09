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

// Token: 0x020015B7 RID: 5559
[Preserve]
public class Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController : LuaObject
{
	// Token: 0x06021C7C RID: 138364 RVA: 0x00B7A34C File Offset: 0x00B7854C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitTrainingSkillEvolutionMaterial(IntPtr l)
	{
		int result;
		try
		{
			TrainingSkillEvolutionMaterialUIController trainingSkillEvolutionMaterialUIController = (TrainingSkillEvolutionMaterialUIController)LuaObject.checkSelf(l);
			GoodsType goodsType;
			LuaObject.checkEnum<GoodsType>(l, 2, out goodsType);
			int goodsId;
			LuaObject.checkType(l, 3, out goodsId);
			int needCount;
			LuaObject.checkType(l, 4, out needCount);
			trainingSkillEvolutionMaterialUIController.InitTrainingSkillEvolutionMaterial(goodsType, goodsId, needCount);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021C7D RID: 138365 RVA: 0x00B7A3C0 File Offset: 0x00B785C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			TrainingSkillEvolutionMaterialUIController trainingSkillEvolutionMaterialUIController = (TrainingSkillEvolutionMaterialUIController)LuaObject.checkSelf(l);
			trainingSkillEvolutionMaterialUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021C7E RID: 138366 RVA: 0x00B7A414 File Offset: 0x00B78614
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnClick(IntPtr l)
	{
		int result;
		try
		{
			TrainingSkillEvolutionMaterialUIController trainingSkillEvolutionMaterialUIController = (TrainingSkillEvolutionMaterialUIController)LuaObject.checkSelf(l);
			trainingSkillEvolutionMaterialUIController.m_luaExportHelper.OnClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021C7F RID: 138367 RVA: 0x00B7A468 File Offset: 0x00B78668
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			TrainingSkillEvolutionMaterialUIController trainingSkillEvolutionMaterialUIController = (TrainingSkillEvolutionMaterialUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			trainingSkillEvolutionMaterialUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021C80 RID: 138368 RVA: 0x00B7A4D4 File Offset: 0x00B786D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			TrainingSkillEvolutionMaterialUIController trainingSkillEvolutionMaterialUIController = (TrainingSkillEvolutionMaterialUIController)LuaObject.checkSelf(l);
			trainingSkillEvolutionMaterialUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021C81 RID: 138369 RVA: 0x00B7A528 File Offset: 0x00B78728
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			TrainingSkillEvolutionMaterialUIController trainingSkillEvolutionMaterialUIController = (TrainingSkillEvolutionMaterialUIController)LuaObject.checkSelf(l);
			trainingSkillEvolutionMaterialUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021C82 RID: 138370 RVA: 0x00B7A57C File Offset: 0x00B7877C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			TrainingSkillEvolutionMaterialUIController trainingSkillEvolutionMaterialUIController = (TrainingSkillEvolutionMaterialUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = trainingSkillEvolutionMaterialUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x06021C83 RID: 138371 RVA: 0x00B7A624 File Offset: 0x00B78824
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			TrainingSkillEvolutionMaterialUIController trainingSkillEvolutionMaterialUIController = (TrainingSkillEvolutionMaterialUIController)LuaObject.checkSelf(l);
			trainingSkillEvolutionMaterialUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021C84 RID: 138372 RVA: 0x00B7A678 File Offset: 0x00B78878
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			TrainingSkillEvolutionMaterialUIController trainingSkillEvolutionMaterialUIController = (TrainingSkillEvolutionMaterialUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			trainingSkillEvolutionMaterialUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021C85 RID: 138373 RVA: 0x00B7A6E4 File Offset: 0x00B788E4
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
				TrainingSkillEvolutionMaterialUIController trainingSkillEvolutionMaterialUIController = (TrainingSkillEvolutionMaterialUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				trainingSkillEvolutionMaterialUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				TrainingSkillEvolutionMaterialUIController trainingSkillEvolutionMaterialUIController2 = (TrainingSkillEvolutionMaterialUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				trainingSkillEvolutionMaterialUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x06021C86 RID: 138374 RVA: 0x00B7A7F4 File Offset: 0x00B789F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			TrainingSkillEvolutionMaterialUIController trainingSkillEvolutionMaterialUIController = (TrainingSkillEvolutionMaterialUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			trainingSkillEvolutionMaterialUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021C87 RID: 138375 RVA: 0x00B7A860 File Offset: 0x00B78A60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			TrainingSkillEvolutionMaterialUIController trainingSkillEvolutionMaterialUIController = (TrainingSkillEvolutionMaterialUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			trainingSkillEvolutionMaterialUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021C88 RID: 138376 RVA: 0x00B7A8CC File Offset: 0x00B78ACC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			TrainingSkillEvolutionMaterialUIController trainingSkillEvolutionMaterialUIController = (TrainingSkillEvolutionMaterialUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			trainingSkillEvolutionMaterialUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021C89 RID: 138377 RVA: 0x00B7A938 File Offset: 0x00B78B38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			TrainingSkillEvolutionMaterialUIController trainingSkillEvolutionMaterialUIController = (TrainingSkillEvolutionMaterialUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			trainingSkillEvolutionMaterialUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021C8A RID: 138378 RVA: 0x00B7A9A4 File Offset: 0x00B78BA4
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
				TrainingSkillEvolutionMaterialUIController trainingSkillEvolutionMaterialUIController = (TrainingSkillEvolutionMaterialUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				trainingSkillEvolutionMaterialUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				TrainingSkillEvolutionMaterialUIController trainingSkillEvolutionMaterialUIController2 = (TrainingSkillEvolutionMaterialUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				trainingSkillEvolutionMaterialUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x06021C8B RID: 138379 RVA: 0x00B7AAB4 File Offset: 0x00B78CB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			TrainingSkillEvolutionMaterialUIController trainingSkillEvolutionMaterialUIController = (TrainingSkillEvolutionMaterialUIController)LuaObject.checkSelf(l);
			string s = trainingSkillEvolutionMaterialUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x06021C8C RID: 138380 RVA: 0x00B7AB10 File Offset: 0x00B78D10
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callDele_EventOnClick(IntPtr l)
	{
		int result;
		try
		{
			TrainingSkillEvolutionMaterialUIController trainingSkillEvolutionMaterialUIController = (TrainingSkillEvolutionMaterialUIController)LuaObject.checkSelf(l);
			GoodsType arg;
			LuaObject.checkEnum<GoodsType>(l, 2, out arg);
			int arg2;
			LuaObject.checkType(l, 3, out arg2);
			int arg3;
			LuaObject.checkType(l, 4, out arg3);
			trainingSkillEvolutionMaterialUIController.m_luaExportHelper.__callDele_EventOnClick(arg, arg2, arg3);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021C8D RID: 138381 RVA: 0x00B7AB88 File Offset: 0x00B78D88
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __clearDele_EventOnClick(IntPtr l)
	{
		int result;
		try
		{
			TrainingSkillEvolutionMaterialUIController trainingSkillEvolutionMaterialUIController = (TrainingSkillEvolutionMaterialUIController)LuaObject.checkSelf(l);
			GoodsType arg;
			LuaObject.checkEnum<GoodsType>(l, 2, out arg);
			int arg2;
			LuaObject.checkType(l, 3, out arg2);
			int arg3;
			LuaObject.checkType(l, 4, out arg3);
			trainingSkillEvolutionMaterialUIController.m_luaExportHelper.__clearDele_EventOnClick(arg, arg2, arg3);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021C8E RID: 138382 RVA: 0x00B7AC00 File Offset: 0x00B78E00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnClick(IntPtr l)
	{
		int result;
		try
		{
			TrainingSkillEvolutionMaterialUIController trainingSkillEvolutionMaterialUIController = (TrainingSkillEvolutionMaterialUIController)LuaObject.checkSelf(l);
			Action<GoodsType, int, int> value;
			int num = LuaObject.checkDelegate<Action<GoodsType, int, int>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					trainingSkillEvolutionMaterialUIController.EventOnClick += value;
				}
				else if (num == 2)
				{
					trainingSkillEvolutionMaterialUIController.EventOnClick -= value;
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

	// Token: 0x06021C8F RID: 138383 RVA: 0x00B7AC80 File Offset: 0x00B78E80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_materialCountStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			TrainingSkillEvolutionMaterialUIController trainingSkillEvolutionMaterialUIController = (TrainingSkillEvolutionMaterialUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, trainingSkillEvolutionMaterialUIController.m_luaExportHelper.m_materialCountStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021C90 RID: 138384 RVA: 0x00B7ACD8 File Offset: 0x00B78ED8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_materialCountStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			TrainingSkillEvolutionMaterialUIController trainingSkillEvolutionMaterialUIController = (TrainingSkillEvolutionMaterialUIController)LuaObject.checkSelf(l);
			CommonUIStateController materialCountStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out materialCountStateCtrl);
			trainingSkillEvolutionMaterialUIController.m_luaExportHelper.m_materialCountStateCtrl = materialCountStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021C91 RID: 138385 RVA: 0x00B7AD34 File Offset: 0x00B78F34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_materialHaveCount(IntPtr l)
	{
		int result;
		try
		{
			TrainingSkillEvolutionMaterialUIController trainingSkillEvolutionMaterialUIController = (TrainingSkillEvolutionMaterialUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, trainingSkillEvolutionMaterialUIController.m_luaExportHelper.m_materialHaveCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021C92 RID: 138386 RVA: 0x00B7AD8C File Offset: 0x00B78F8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_materialHaveCount(IntPtr l)
	{
		int result;
		try
		{
			TrainingSkillEvolutionMaterialUIController trainingSkillEvolutionMaterialUIController = (TrainingSkillEvolutionMaterialUIController)LuaObject.checkSelf(l);
			Text materialHaveCount;
			LuaObject.checkType<Text>(l, 2, out materialHaveCount);
			trainingSkillEvolutionMaterialUIController.m_luaExportHelper.m_materialHaveCount = materialHaveCount;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021C93 RID: 138387 RVA: 0x00B7ADE8 File Offset: 0x00B78FE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_materialNeedCount(IntPtr l)
	{
		int result;
		try
		{
			TrainingSkillEvolutionMaterialUIController trainingSkillEvolutionMaterialUIController = (TrainingSkillEvolutionMaterialUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, trainingSkillEvolutionMaterialUIController.m_luaExportHelper.m_materialNeedCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021C94 RID: 138388 RVA: 0x00B7AE40 File Offset: 0x00B79040
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_materialNeedCount(IntPtr l)
	{
		int result;
		try
		{
			TrainingSkillEvolutionMaterialUIController trainingSkillEvolutionMaterialUIController = (TrainingSkillEvolutionMaterialUIController)LuaObject.checkSelf(l);
			Text materialNeedCount;
			LuaObject.checkType<Text>(l, 2, out materialNeedCount);
			trainingSkillEvolutionMaterialUIController.m_luaExportHelper.m_materialNeedCount = materialNeedCount;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021C95 RID: 138389 RVA: 0x00B7AE9C File Offset: 0x00B7909C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_materialIconImage(IntPtr l)
	{
		int result;
		try
		{
			TrainingSkillEvolutionMaterialUIController trainingSkillEvolutionMaterialUIController = (TrainingSkillEvolutionMaterialUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, trainingSkillEvolutionMaterialUIController.m_luaExportHelper.m_materialIconImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021C96 RID: 138390 RVA: 0x00B7AEF4 File Offset: 0x00B790F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_materialIconImage(IntPtr l)
	{
		int result;
		try
		{
			TrainingSkillEvolutionMaterialUIController trainingSkillEvolutionMaterialUIController = (TrainingSkillEvolutionMaterialUIController)LuaObject.checkSelf(l);
			Image materialIconImage;
			LuaObject.checkType<Image>(l, 2, out materialIconImage);
			trainingSkillEvolutionMaterialUIController.m_luaExportHelper.m_materialIconImage = materialIconImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021C97 RID: 138391 RVA: 0x00B7AF50 File Offset: 0x00B79150
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_materialFrameImage(IntPtr l)
	{
		int result;
		try
		{
			TrainingSkillEvolutionMaterialUIController trainingSkillEvolutionMaterialUIController = (TrainingSkillEvolutionMaterialUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, trainingSkillEvolutionMaterialUIController.m_luaExportHelper.m_materialFrameImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021C98 RID: 138392 RVA: 0x00B7AFA8 File Offset: 0x00B791A8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_materialFrameImage(IntPtr l)
	{
		int result;
		try
		{
			TrainingSkillEvolutionMaterialUIController trainingSkillEvolutionMaterialUIController = (TrainingSkillEvolutionMaterialUIController)LuaObject.checkSelf(l);
			Image materialFrameImage;
			LuaObject.checkType<Image>(l, 2, out materialFrameImage);
			trainingSkillEvolutionMaterialUIController.m_luaExportHelper.m_materialFrameImage = materialFrameImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021C99 RID: 138393 RVA: 0x00B7B004 File Offset: 0x00B79204
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_materialButton(IntPtr l)
	{
		int result;
		try
		{
			TrainingSkillEvolutionMaterialUIController trainingSkillEvolutionMaterialUIController = (TrainingSkillEvolutionMaterialUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, trainingSkillEvolutionMaterialUIController.m_luaExportHelper.m_materialButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021C9A RID: 138394 RVA: 0x00B7B05C File Offset: 0x00B7925C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_materialButton(IntPtr l)
	{
		int result;
		try
		{
			TrainingSkillEvolutionMaterialUIController trainingSkillEvolutionMaterialUIController = (TrainingSkillEvolutionMaterialUIController)LuaObject.checkSelf(l);
			Button materialButton;
			LuaObject.checkType<Button>(l, 2, out materialButton);
			trainingSkillEvolutionMaterialUIController.m_luaExportHelper.m_materialButton = materialButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021C9B RID: 138395 RVA: 0x00B7B0B8 File Offset: 0x00B792B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_goodsType(IntPtr l)
	{
		int result;
		try
		{
			TrainingSkillEvolutionMaterialUIController trainingSkillEvolutionMaterialUIController = (TrainingSkillEvolutionMaterialUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)trainingSkillEvolutionMaterialUIController.m_luaExportHelper.m_goodsType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021C9C RID: 138396 RVA: 0x00B7B110 File Offset: 0x00B79310
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_goodsType(IntPtr l)
	{
		int result;
		try
		{
			TrainingSkillEvolutionMaterialUIController trainingSkillEvolutionMaterialUIController = (TrainingSkillEvolutionMaterialUIController)LuaObject.checkSelf(l);
			GoodsType goodsType;
			LuaObject.checkEnum<GoodsType>(l, 2, out goodsType);
			trainingSkillEvolutionMaterialUIController.m_luaExportHelper.m_goodsType = goodsType;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021C9D RID: 138397 RVA: 0x00B7B16C File Offset: 0x00B7936C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_goodsId(IntPtr l)
	{
		int result;
		try
		{
			TrainingSkillEvolutionMaterialUIController trainingSkillEvolutionMaterialUIController = (TrainingSkillEvolutionMaterialUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, trainingSkillEvolutionMaterialUIController.m_luaExportHelper.m_goodsId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021C9E RID: 138398 RVA: 0x00B7B1C4 File Offset: 0x00B793C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_goodsId(IntPtr l)
	{
		int result;
		try
		{
			TrainingSkillEvolutionMaterialUIController trainingSkillEvolutionMaterialUIController = (TrainingSkillEvolutionMaterialUIController)LuaObject.checkSelf(l);
			int goodsId;
			LuaObject.checkType(l, 2, out goodsId);
			trainingSkillEvolutionMaterialUIController.m_luaExportHelper.m_goodsId = goodsId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021C9F RID: 138399 RVA: 0x00B7B220 File Offset: 0x00B79420
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_needCount(IntPtr l)
	{
		int result;
		try
		{
			TrainingSkillEvolutionMaterialUIController trainingSkillEvolutionMaterialUIController = (TrainingSkillEvolutionMaterialUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, trainingSkillEvolutionMaterialUIController.m_luaExportHelper.m_needCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021CA0 RID: 138400 RVA: 0x00B7B278 File Offset: 0x00B79478
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_needCount(IntPtr l)
	{
		int result;
		try
		{
			TrainingSkillEvolutionMaterialUIController trainingSkillEvolutionMaterialUIController = (TrainingSkillEvolutionMaterialUIController)LuaObject.checkSelf(l);
			int needCount;
			LuaObject.checkType(l, 2, out needCount);
			trainingSkillEvolutionMaterialUIController.m_luaExportHelper.m_needCount = needCount;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021CA1 RID: 138401 RVA: 0x00B7B2D4 File Offset: 0x00B794D4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.TrainingSkillEvolutionMaterialUIController");
		if (Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.InitTrainingSkillEvolutionMaterial);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.OnClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.__callDele_EventOnClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.__clearDele_EventOnClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.<>f__mg$cache11);
		string name = "EventOnClick";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.set_EventOnClick);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.<>f__mg$cache12, true);
		string name2 = "m_materialCountStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.get_m_materialCountStateCtrl);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.<>f__mg$cache13;
		if (Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.set_m_materialCountStateCtrl);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.<>f__mg$cache14, true);
		string name3 = "m_materialHaveCount";
		if (Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.get_m_materialHaveCount);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.<>f__mg$cache15;
		if (Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.set_m_materialHaveCount);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.<>f__mg$cache16, true);
		string name4 = "m_materialNeedCount";
		if (Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.get_m_materialNeedCount);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.<>f__mg$cache17;
		if (Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.set_m_materialNeedCount);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.<>f__mg$cache18, true);
		string name5 = "m_materialIconImage";
		if (Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.get_m_materialIconImage);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.<>f__mg$cache19;
		if (Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.set_m_materialIconImage);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.<>f__mg$cache1A, true);
		string name6 = "m_materialFrameImage";
		if (Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.get_m_materialFrameImage);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.<>f__mg$cache1B;
		if (Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.set_m_materialFrameImage);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.<>f__mg$cache1C, true);
		string name7 = "m_materialButton";
		if (Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.get_m_materialButton);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.<>f__mg$cache1D;
		if (Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.set_m_materialButton);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.<>f__mg$cache1E, true);
		string name8 = "m_goodsType";
		if (Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.get_m_goodsType);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.<>f__mg$cache1F;
		if (Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.set_m_goodsType);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.<>f__mg$cache20, true);
		string name9 = "m_goodsId";
		if (Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.get_m_goodsId);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.<>f__mg$cache21;
		if (Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.set_m_goodsId);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.<>f__mg$cache22, true);
		string name10 = "m_needCount";
		if (Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.get_m_needCount);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.<>f__mg$cache23;
		if (Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.set_m_needCount);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.<>f__mg$cache24, true);
		LuaObject.createTypeMetatable(l, null, typeof(TrainingSkillEvolutionMaterialUIController), typeof(UIControllerBase));
	}

	// Token: 0x04017AF0 RID: 97008
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04017AF1 RID: 97009
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04017AF2 RID: 97010
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04017AF3 RID: 97011
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04017AF4 RID: 97012
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04017AF5 RID: 97013
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04017AF6 RID: 97014
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04017AF7 RID: 97015
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04017AF8 RID: 97016
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04017AF9 RID: 97017
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04017AFA RID: 97018
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04017AFB RID: 97019
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04017AFC RID: 97020
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04017AFD RID: 97021
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04017AFE RID: 97022
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04017AFF RID: 97023
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04017B00 RID: 97024
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04017B01 RID: 97025
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04017B02 RID: 97026
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04017B03 RID: 97027
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04017B04 RID: 97028
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04017B05 RID: 97029
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04017B06 RID: 97030
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04017B07 RID: 97031
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04017B08 RID: 97032
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04017B09 RID: 97033
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04017B0A RID: 97034
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04017B0B RID: 97035
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04017B0C RID: 97036
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04017B0D RID: 97037
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04017B0E RID: 97038
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04017B0F RID: 97039
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04017B10 RID: 97040
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04017B11 RID: 97041
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04017B12 RID: 97042
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04017B13 RID: 97043
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04017B14 RID: 97044
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;
}
