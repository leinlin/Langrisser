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

// Token: 0x02001436 RID: 5174
[Preserve]
public class Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController : LuaObject
{
	// Token: 0x0601DAA4 RID: 121508 RVA: 0x0096DBEC File Offset: 0x0096BDEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitFettersConfessionEvolutionMaterial(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionEvolutionMaterialUIController fettersConfessionEvolutionMaterialUIController = (FettersConfessionEvolutionMaterialUIController)LuaObject.checkSelf(l);
			GoodsType goodsType;
			LuaObject.checkEnum<GoodsType>(l, 2, out goodsType);
			int goodsId;
			LuaObject.checkType(l, 3, out goodsId);
			int needCount;
			LuaObject.checkType(l, 4, out needCount);
			fettersConfessionEvolutionMaterialUIController.InitFettersConfessionEvolutionMaterial(goodsType, goodsId, needCount);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DAA5 RID: 121509 RVA: 0x0096DC60 File Offset: 0x0096BE60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionEvolutionMaterialUIController fettersConfessionEvolutionMaterialUIController = (FettersConfessionEvolutionMaterialUIController)LuaObject.checkSelf(l);
			fettersConfessionEvolutionMaterialUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DAA6 RID: 121510 RVA: 0x0096DCB4 File Offset: 0x0096BEB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnClick(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionEvolutionMaterialUIController fettersConfessionEvolutionMaterialUIController = (FettersConfessionEvolutionMaterialUIController)LuaObject.checkSelf(l);
			fettersConfessionEvolutionMaterialUIController.m_luaExportHelper.OnClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DAA7 RID: 121511 RVA: 0x0096DD08 File Offset: 0x0096BF08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionEvolutionMaterialUIController fettersConfessionEvolutionMaterialUIController = (FettersConfessionEvolutionMaterialUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			fettersConfessionEvolutionMaterialUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DAA8 RID: 121512 RVA: 0x0096DD74 File Offset: 0x0096BF74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionEvolutionMaterialUIController fettersConfessionEvolutionMaterialUIController = (FettersConfessionEvolutionMaterialUIController)LuaObject.checkSelf(l);
			fettersConfessionEvolutionMaterialUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DAA9 RID: 121513 RVA: 0x0096DDC8 File Offset: 0x0096BFC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionEvolutionMaterialUIController fettersConfessionEvolutionMaterialUIController = (FettersConfessionEvolutionMaterialUIController)LuaObject.checkSelf(l);
			fettersConfessionEvolutionMaterialUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DAAA RID: 121514 RVA: 0x0096DE1C File Offset: 0x0096C01C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionEvolutionMaterialUIController fettersConfessionEvolutionMaterialUIController = (FettersConfessionEvolutionMaterialUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = fettersConfessionEvolutionMaterialUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601DAAB RID: 121515 RVA: 0x0096DEC4 File Offset: 0x0096C0C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionEvolutionMaterialUIController fettersConfessionEvolutionMaterialUIController = (FettersConfessionEvolutionMaterialUIController)LuaObject.checkSelf(l);
			fettersConfessionEvolutionMaterialUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DAAC RID: 121516 RVA: 0x0096DF18 File Offset: 0x0096C118
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionEvolutionMaterialUIController fettersConfessionEvolutionMaterialUIController = (FettersConfessionEvolutionMaterialUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			fettersConfessionEvolutionMaterialUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DAAD RID: 121517 RVA: 0x0096DF84 File Offset: 0x0096C184
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
				FettersConfessionEvolutionMaterialUIController fettersConfessionEvolutionMaterialUIController = (FettersConfessionEvolutionMaterialUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				fettersConfessionEvolutionMaterialUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				FettersConfessionEvolutionMaterialUIController fettersConfessionEvolutionMaterialUIController2 = (FettersConfessionEvolutionMaterialUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				fettersConfessionEvolutionMaterialUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601DAAE RID: 121518 RVA: 0x0096E094 File Offset: 0x0096C294
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionEvolutionMaterialUIController fettersConfessionEvolutionMaterialUIController = (FettersConfessionEvolutionMaterialUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			fettersConfessionEvolutionMaterialUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DAAF RID: 121519 RVA: 0x0096E100 File Offset: 0x0096C300
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionEvolutionMaterialUIController fettersConfessionEvolutionMaterialUIController = (FettersConfessionEvolutionMaterialUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			fettersConfessionEvolutionMaterialUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DAB0 RID: 121520 RVA: 0x0096E16C File Offset: 0x0096C36C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionEvolutionMaterialUIController fettersConfessionEvolutionMaterialUIController = (FettersConfessionEvolutionMaterialUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			fettersConfessionEvolutionMaterialUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DAB1 RID: 121521 RVA: 0x0096E1D8 File Offset: 0x0096C3D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionEvolutionMaterialUIController fettersConfessionEvolutionMaterialUIController = (FettersConfessionEvolutionMaterialUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			fettersConfessionEvolutionMaterialUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DAB2 RID: 121522 RVA: 0x0096E244 File Offset: 0x0096C444
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
				FettersConfessionEvolutionMaterialUIController fettersConfessionEvolutionMaterialUIController = (FettersConfessionEvolutionMaterialUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				fettersConfessionEvolutionMaterialUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				FettersConfessionEvolutionMaterialUIController fettersConfessionEvolutionMaterialUIController2 = (FettersConfessionEvolutionMaterialUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				fettersConfessionEvolutionMaterialUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601DAB3 RID: 121523 RVA: 0x0096E354 File Offset: 0x0096C554
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionEvolutionMaterialUIController fettersConfessionEvolutionMaterialUIController = (FettersConfessionEvolutionMaterialUIController)LuaObject.checkSelf(l);
			string s = fettersConfessionEvolutionMaterialUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601DAB4 RID: 121524 RVA: 0x0096E3B0 File Offset: 0x0096C5B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnClick(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionEvolutionMaterialUIController fettersConfessionEvolutionMaterialUIController = (FettersConfessionEvolutionMaterialUIController)LuaObject.checkSelf(l);
			GoodsType arg;
			LuaObject.checkEnum<GoodsType>(l, 2, out arg);
			int arg2;
			LuaObject.checkType(l, 3, out arg2);
			int arg3;
			LuaObject.checkType(l, 4, out arg3);
			fettersConfessionEvolutionMaterialUIController.m_luaExportHelper.__callDele_EventOnClick(arg, arg2, arg3);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DAB5 RID: 121525 RVA: 0x0096E428 File Offset: 0x0096C628
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnClick(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionEvolutionMaterialUIController fettersConfessionEvolutionMaterialUIController = (FettersConfessionEvolutionMaterialUIController)LuaObject.checkSelf(l);
			GoodsType arg;
			LuaObject.checkEnum<GoodsType>(l, 2, out arg);
			int arg2;
			LuaObject.checkType(l, 3, out arg2);
			int arg3;
			LuaObject.checkType(l, 4, out arg3);
			fettersConfessionEvolutionMaterialUIController.m_luaExportHelper.__clearDele_EventOnClick(arg, arg2, arg3);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DAB6 RID: 121526 RVA: 0x0096E4A0 File Offset: 0x0096C6A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnClick(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionEvolutionMaterialUIController fettersConfessionEvolutionMaterialUIController = (FettersConfessionEvolutionMaterialUIController)LuaObject.checkSelf(l);
			Action<GoodsType, int, int> value;
			int num = LuaObject.checkDelegate<Action<GoodsType, int, int>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					fettersConfessionEvolutionMaterialUIController.EventOnClick += value;
				}
				else if (num == 2)
				{
					fettersConfessionEvolutionMaterialUIController.EventOnClick -= value;
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

	// Token: 0x0601DAB7 RID: 121527 RVA: 0x0096E520 File Offset: 0x0096C720
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_stateCtrl(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionEvolutionMaterialUIController fettersConfessionEvolutionMaterialUIController = (FettersConfessionEvolutionMaterialUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersConfessionEvolutionMaterialUIController.m_luaExportHelper.m_stateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DAB8 RID: 121528 RVA: 0x0096E578 File Offset: 0x0096C778
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_stateCtrl(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionEvolutionMaterialUIController fettersConfessionEvolutionMaterialUIController = (FettersConfessionEvolutionMaterialUIController)LuaObject.checkSelf(l);
			CommonUIStateController stateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out stateCtrl);
			fettersConfessionEvolutionMaterialUIController.m_luaExportHelper.m_stateCtrl = stateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DAB9 RID: 121529 RVA: 0x0096E5D4 File Offset: 0x0096C7D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_materialCountStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionEvolutionMaterialUIController fettersConfessionEvolutionMaterialUIController = (FettersConfessionEvolutionMaterialUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersConfessionEvolutionMaterialUIController.m_luaExportHelper.m_materialCountStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DABA RID: 121530 RVA: 0x0096E62C File Offset: 0x0096C82C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_materialCountStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionEvolutionMaterialUIController fettersConfessionEvolutionMaterialUIController = (FettersConfessionEvolutionMaterialUIController)LuaObject.checkSelf(l);
			CommonUIStateController materialCountStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out materialCountStateCtrl);
			fettersConfessionEvolutionMaterialUIController.m_luaExportHelper.m_materialCountStateCtrl = materialCountStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DABB RID: 121531 RVA: 0x0096E688 File Offset: 0x0096C888
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_materialHaveCount(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionEvolutionMaterialUIController fettersConfessionEvolutionMaterialUIController = (FettersConfessionEvolutionMaterialUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersConfessionEvolutionMaterialUIController.m_luaExportHelper.m_materialHaveCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DABC RID: 121532 RVA: 0x0096E6E0 File Offset: 0x0096C8E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_materialHaveCount(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionEvolutionMaterialUIController fettersConfessionEvolutionMaterialUIController = (FettersConfessionEvolutionMaterialUIController)LuaObject.checkSelf(l);
			Text materialHaveCount;
			LuaObject.checkType<Text>(l, 2, out materialHaveCount);
			fettersConfessionEvolutionMaterialUIController.m_luaExportHelper.m_materialHaveCount = materialHaveCount;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DABD RID: 121533 RVA: 0x0096E73C File Offset: 0x0096C93C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_materialNeedCount(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionEvolutionMaterialUIController fettersConfessionEvolutionMaterialUIController = (FettersConfessionEvolutionMaterialUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersConfessionEvolutionMaterialUIController.m_luaExportHelper.m_materialNeedCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DABE RID: 121534 RVA: 0x0096E794 File Offset: 0x0096C994
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_materialNeedCount(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionEvolutionMaterialUIController fettersConfessionEvolutionMaterialUIController = (FettersConfessionEvolutionMaterialUIController)LuaObject.checkSelf(l);
			Text materialNeedCount;
			LuaObject.checkType<Text>(l, 2, out materialNeedCount);
			fettersConfessionEvolutionMaterialUIController.m_luaExportHelper.m_materialNeedCount = materialNeedCount;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DABF RID: 121535 RVA: 0x0096E7F0 File Offset: 0x0096C9F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_materialIconImage(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionEvolutionMaterialUIController fettersConfessionEvolutionMaterialUIController = (FettersConfessionEvolutionMaterialUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersConfessionEvolutionMaterialUIController.m_luaExportHelper.m_materialIconImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DAC0 RID: 121536 RVA: 0x0096E848 File Offset: 0x0096CA48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_materialIconImage(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionEvolutionMaterialUIController fettersConfessionEvolutionMaterialUIController = (FettersConfessionEvolutionMaterialUIController)LuaObject.checkSelf(l);
			Image materialIconImage;
			LuaObject.checkType<Image>(l, 2, out materialIconImage);
			fettersConfessionEvolutionMaterialUIController.m_luaExportHelper.m_materialIconImage = materialIconImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DAC1 RID: 121537 RVA: 0x0096E8A4 File Offset: 0x0096CAA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_materialBgImage(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionEvolutionMaterialUIController fettersConfessionEvolutionMaterialUIController = (FettersConfessionEvolutionMaterialUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersConfessionEvolutionMaterialUIController.m_luaExportHelper.m_materialBgImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DAC2 RID: 121538 RVA: 0x0096E8FC File Offset: 0x0096CAFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_materialBgImage(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionEvolutionMaterialUIController fettersConfessionEvolutionMaterialUIController = (FettersConfessionEvolutionMaterialUIController)LuaObject.checkSelf(l);
			Image materialBgImage;
			LuaObject.checkType<Image>(l, 2, out materialBgImage);
			fettersConfessionEvolutionMaterialUIController.m_luaExportHelper.m_materialBgImage = materialBgImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DAC3 RID: 121539 RVA: 0x0096E958 File Offset: 0x0096CB58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_materialButton(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionEvolutionMaterialUIController fettersConfessionEvolutionMaterialUIController = (FettersConfessionEvolutionMaterialUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersConfessionEvolutionMaterialUIController.m_luaExportHelper.m_materialButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DAC4 RID: 121540 RVA: 0x0096E9B0 File Offset: 0x0096CBB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_materialButton(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionEvolutionMaterialUIController fettersConfessionEvolutionMaterialUIController = (FettersConfessionEvolutionMaterialUIController)LuaObject.checkSelf(l);
			Button materialButton;
			LuaObject.checkType<Button>(l, 2, out materialButton);
			fettersConfessionEvolutionMaterialUIController.m_luaExportHelper.m_materialButton = materialButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DAC5 RID: 121541 RVA: 0x0096EA0C File Offset: 0x0096CC0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_goodsType(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionEvolutionMaterialUIController fettersConfessionEvolutionMaterialUIController = (FettersConfessionEvolutionMaterialUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)fettersConfessionEvolutionMaterialUIController.m_luaExportHelper.m_goodsType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DAC6 RID: 121542 RVA: 0x0096EA64 File Offset: 0x0096CC64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_goodsType(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionEvolutionMaterialUIController fettersConfessionEvolutionMaterialUIController = (FettersConfessionEvolutionMaterialUIController)LuaObject.checkSelf(l);
			GoodsType goodsType;
			LuaObject.checkEnum<GoodsType>(l, 2, out goodsType);
			fettersConfessionEvolutionMaterialUIController.m_luaExportHelper.m_goodsType = goodsType;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DAC7 RID: 121543 RVA: 0x0096EAC0 File Offset: 0x0096CCC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_goodsId(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionEvolutionMaterialUIController fettersConfessionEvolutionMaterialUIController = (FettersConfessionEvolutionMaterialUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersConfessionEvolutionMaterialUIController.m_luaExportHelper.m_goodsId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DAC8 RID: 121544 RVA: 0x0096EB18 File Offset: 0x0096CD18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_goodsId(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionEvolutionMaterialUIController fettersConfessionEvolutionMaterialUIController = (FettersConfessionEvolutionMaterialUIController)LuaObject.checkSelf(l);
			int goodsId;
			LuaObject.checkType(l, 2, out goodsId);
			fettersConfessionEvolutionMaterialUIController.m_luaExportHelper.m_goodsId = goodsId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DAC9 RID: 121545 RVA: 0x0096EB74 File Offset: 0x0096CD74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_needCount(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionEvolutionMaterialUIController fettersConfessionEvolutionMaterialUIController = (FettersConfessionEvolutionMaterialUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersConfessionEvolutionMaterialUIController.m_luaExportHelper.m_needCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DACA RID: 121546 RVA: 0x0096EBCC File Offset: 0x0096CDCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_needCount(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionEvolutionMaterialUIController fettersConfessionEvolutionMaterialUIController = (FettersConfessionEvolutionMaterialUIController)LuaObject.checkSelf(l);
			int needCount;
			LuaObject.checkType(l, 2, out needCount);
			fettersConfessionEvolutionMaterialUIController.m_luaExportHelper.m_needCount = needCount;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DACB RID: 121547 RVA: 0x0096EC28 File Offset: 0x0096CE28
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.FettersConfessionEvolutionMaterialUIController");
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.InitFettersConfessionEvolutionMaterial);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.OnClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.__callDele_EventOnClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.__clearDele_EventOnClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.<>f__mg$cache11);
		string name = "EventOnClick";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.set_EventOnClick);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.<>f__mg$cache12, true);
		string name2 = "m_stateCtrl";
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.get_m_stateCtrl);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.<>f__mg$cache13;
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.set_m_stateCtrl);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.<>f__mg$cache14, true);
		string name3 = "m_materialCountStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.get_m_materialCountStateCtrl);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.<>f__mg$cache15;
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.set_m_materialCountStateCtrl);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.<>f__mg$cache16, true);
		string name4 = "m_materialHaveCount";
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.get_m_materialHaveCount);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.<>f__mg$cache17;
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.set_m_materialHaveCount);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.<>f__mg$cache18, true);
		string name5 = "m_materialNeedCount";
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.get_m_materialNeedCount);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.<>f__mg$cache19;
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.set_m_materialNeedCount);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.<>f__mg$cache1A, true);
		string name6 = "m_materialIconImage";
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.get_m_materialIconImage);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.<>f__mg$cache1B;
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.set_m_materialIconImage);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.<>f__mg$cache1C, true);
		string name7 = "m_materialBgImage";
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.get_m_materialBgImage);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.<>f__mg$cache1D;
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.set_m_materialBgImage);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.<>f__mg$cache1E, true);
		string name8 = "m_materialButton";
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.get_m_materialButton);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.<>f__mg$cache1F;
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.set_m_materialButton);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.<>f__mg$cache20, true);
		string name9 = "m_goodsType";
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.get_m_goodsType);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.<>f__mg$cache21;
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.set_m_goodsType);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.<>f__mg$cache22, true);
		string name10 = "m_goodsId";
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.get_m_goodsId);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.<>f__mg$cache23;
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.set_m_goodsId);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.<>f__mg$cache24, true);
		string name11 = "m_needCount";
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.get_m_needCount);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.<>f__mg$cache25;
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.set_m_needCount);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.<>f__mg$cache26, true);
		LuaObject.createTypeMetatable(l, null, typeof(FettersConfessionEvolutionMaterialUIController), typeof(UIControllerBase));
	}

	// Token: 0x04013C1A RID: 80922
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04013C1B RID: 80923
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04013C1C RID: 80924
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04013C1D RID: 80925
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04013C1E RID: 80926
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04013C1F RID: 80927
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04013C20 RID: 80928
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04013C21 RID: 80929
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04013C22 RID: 80930
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04013C23 RID: 80931
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04013C24 RID: 80932
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04013C25 RID: 80933
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04013C26 RID: 80934
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04013C27 RID: 80935
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04013C28 RID: 80936
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04013C29 RID: 80937
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04013C2A RID: 80938
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04013C2B RID: 80939
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04013C2C RID: 80940
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04013C2D RID: 80941
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04013C2E RID: 80942
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04013C2F RID: 80943
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04013C30 RID: 80944
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04013C31 RID: 80945
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04013C32 RID: 80946
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04013C33 RID: 80947
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04013C34 RID: 80948
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04013C35 RID: 80949
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04013C36 RID: 80950
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04013C37 RID: 80951
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04013C38 RID: 80952
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04013C39 RID: 80953
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04013C3A RID: 80954
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04013C3B RID: 80955
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04013C3C RID: 80956
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04013C3D RID: 80957
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04013C3E RID: 80958
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04013C3F RID: 80959
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04013C40 RID: 80960
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;
}
