using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x02001578 RID: 5496
[Preserve]
public class Lua_BlackJack_ProjectL_UI_SignRewardItemUIController : LuaObject
{
	// Token: 0x0602108A RID: 135306 RVA: 0x00B1A898 File Offset: 0x00B18A98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnPointerClick(IntPtr l)
	{
		int result;
		try
		{
			SignRewardItemUIController signRewardItemUIController = (SignRewardItemUIController)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			signRewardItemUIController.OnPointerClick(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602108B RID: 135307 RVA: 0x00B1A8F0 File Offset: 0x00B18AF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetReward(IntPtr l)
	{
		int result;
		try
		{
			SignRewardItemUIController signRewardItemUIController = (SignRewardItemUIController)LuaObject.checkSelf(l);
			Goods reward;
			LuaObject.checkType<Goods>(l, 2, out reward);
			signRewardItemUIController.SetReward(reward);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602108C RID: 135308 RVA: 0x00B1A948 File Offset: 0x00B18B48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetDay(IntPtr l)
	{
		int result;
		try
		{
			SignRewardItemUIController signRewardItemUIController = (SignRewardItemUIController)LuaObject.checkSelf(l);
			int day;
			LuaObject.checkType(l, 2, out day);
			signRewardItemUIController.SetDay(day);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602108D RID: 135309 RVA: 0x00B1A9A0 File Offset: 0x00B18BA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlaySignAnimation(IntPtr l)
	{
		int result;
		try
		{
			SignRewardItemUIController signRewardItemUIController = (SignRewardItemUIController)LuaObject.checkSelf(l);
			Action onEnd;
			LuaObject.checkDelegate<Action>(l, 2, out onEnd);
			signRewardItemUIController.PlaySignAnimation(onEnd);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602108E RID: 135310 RVA: 0x00B1A9F8 File Offset: 0x00B18BF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int TodayAutoSign(IntPtr l)
	{
		int result;
		try
		{
			SignRewardItemUIController signRewardItemUIController = (SignRewardItemUIController)LuaObject.checkSelf(l);
			signRewardItemUIController.TodayAutoSign();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602108F RID: 135311 RVA: 0x00B1AA44 File Offset: 0x00B18C44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetGoodsType(IntPtr l)
	{
		int result;
		try
		{
			SignRewardItemUIController signRewardItemUIController = (SignRewardItemUIController)LuaObject.checkSelf(l);
			GoodsType goodsType = signRewardItemUIController.GetGoodsType();
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)goodsType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021090 RID: 135312 RVA: 0x00B1AA98 File Offset: 0x00B18C98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetGoodsId(IntPtr l)
	{
		int result;
		try
		{
			SignRewardItemUIController signRewardItemUIController = (SignRewardItemUIController)LuaObject.checkSelf(l);
			int goodsId = signRewardItemUIController.GetGoodsId();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, goodsId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021091 RID: 135313 RVA: 0x00B1AAEC File Offset: 0x00B18CEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetGoodsCount(IntPtr l)
	{
		int result;
		try
		{
			SignRewardItemUIController signRewardItemUIController = (SignRewardItemUIController)LuaObject.checkSelf(l);
			int goodsCount = signRewardItemUIController.GetGoodsCount();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, goodsCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021092 RID: 135314 RVA: 0x00B1AB40 File Offset: 0x00B18D40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			SignRewardItemUIController signRewardItemUIController = (SignRewardItemUIController)LuaObject.checkSelf(l);
			signRewardItemUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021093 RID: 135315 RVA: 0x00B1AB94 File Offset: 0x00B18D94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Co_ChangeStateToSigning(IntPtr l)
	{
		int result;
		try
		{
			SignRewardItemUIController signRewardItemUIController = (SignRewardItemUIController)LuaObject.checkSelf(l);
			Action onEnd;
			LuaObject.checkDelegate<Action>(l, 2, out onEnd);
			IEnumerator o = signRewardItemUIController.m_luaExportHelper.Co_ChangeStateToSigning(onEnd);
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

	// Token: 0x06021094 RID: 135316 RVA: 0x00B1ABFC File Offset: 0x00B18DFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			SignRewardItemUIController signRewardItemUIController = (SignRewardItemUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			signRewardItemUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021095 RID: 135317 RVA: 0x00B1AC68 File Offset: 0x00B18E68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			SignRewardItemUIController signRewardItemUIController = (SignRewardItemUIController)LuaObject.checkSelf(l);
			signRewardItemUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021096 RID: 135318 RVA: 0x00B1ACBC File Offset: 0x00B18EBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			SignRewardItemUIController signRewardItemUIController = (SignRewardItemUIController)LuaObject.checkSelf(l);
			signRewardItemUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021097 RID: 135319 RVA: 0x00B1AD10 File Offset: 0x00B18F10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			SignRewardItemUIController signRewardItemUIController = (SignRewardItemUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = signRewardItemUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x06021098 RID: 135320 RVA: 0x00B1ADB8 File Offset: 0x00B18FB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			SignRewardItemUIController signRewardItemUIController = (SignRewardItemUIController)LuaObject.checkSelf(l);
			signRewardItemUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021099 RID: 135321 RVA: 0x00B1AE0C File Offset: 0x00B1900C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			SignRewardItemUIController signRewardItemUIController = (SignRewardItemUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			signRewardItemUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602109A RID: 135322 RVA: 0x00B1AE78 File Offset: 0x00B19078
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
				SignRewardItemUIController signRewardItemUIController = (SignRewardItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				signRewardItemUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				SignRewardItemUIController signRewardItemUIController2 = (SignRewardItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				signRewardItemUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0602109B RID: 135323 RVA: 0x00B1AF88 File Offset: 0x00B19188
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			SignRewardItemUIController signRewardItemUIController = (SignRewardItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			signRewardItemUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602109C RID: 135324 RVA: 0x00B1AFF4 File Offset: 0x00B191F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			SignRewardItemUIController signRewardItemUIController = (SignRewardItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			signRewardItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602109D RID: 135325 RVA: 0x00B1B060 File Offset: 0x00B19260
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			SignRewardItemUIController signRewardItemUIController = (SignRewardItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			signRewardItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602109E RID: 135326 RVA: 0x00B1B0CC File Offset: 0x00B192CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			SignRewardItemUIController signRewardItemUIController = (SignRewardItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			signRewardItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602109F RID: 135327 RVA: 0x00B1B138 File Offset: 0x00B19338
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
				SignRewardItemUIController signRewardItemUIController = (SignRewardItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				signRewardItemUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				SignRewardItemUIController signRewardItemUIController2 = (SignRewardItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				signRewardItemUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x060210A0 RID: 135328 RVA: 0x00B1B248 File Offset: 0x00B19448
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			SignRewardItemUIController signRewardItemUIController = (SignRewardItemUIController)LuaObject.checkSelf(l);
			string s = signRewardItemUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x060210A1 RID: 135329 RVA: 0x00B1B2A4 File Offset: 0x00B194A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnSignTodayItemClick(IntPtr l)
	{
		int result;
		try
		{
			SignRewardItemUIController signRewardItemUIController = (SignRewardItemUIController)LuaObject.checkSelf(l);
			signRewardItemUIController.m_luaExportHelper.__callDele_EventOnSignTodayItemClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060210A2 RID: 135330 RVA: 0x00B1B2F8 File Offset: 0x00B194F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnSignTodayItemClick(IntPtr l)
	{
		int result;
		try
		{
			SignRewardItemUIController signRewardItemUIController = (SignRewardItemUIController)LuaObject.checkSelf(l);
			signRewardItemUIController.m_luaExportHelper.__clearDele_EventOnSignTodayItemClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060210A3 RID: 135331 RVA: 0x00B1B34C File Offset: 0x00B1954C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnSignTodayBoxOpenClick(IntPtr l)
	{
		int result;
		try
		{
			SignRewardItemUIController signRewardItemUIController = (SignRewardItemUIController)LuaObject.checkSelf(l);
			GoodsType arg;
			LuaObject.checkEnum<GoodsType>(l, 2, out arg);
			int arg2;
			LuaObject.checkType(l, 3, out arg2);
			int arg3;
			LuaObject.checkType(l, 4, out arg3);
			signRewardItemUIController.m_luaExportHelper.__callDele_EventOnSignTodayBoxOpenClick(arg, arg2, arg3);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060210A4 RID: 135332 RVA: 0x00B1B3C4 File Offset: 0x00B195C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnSignTodayBoxOpenClick(IntPtr l)
	{
		int result;
		try
		{
			SignRewardItemUIController signRewardItemUIController = (SignRewardItemUIController)LuaObject.checkSelf(l);
			GoodsType arg;
			LuaObject.checkEnum<GoodsType>(l, 2, out arg);
			int arg2;
			LuaObject.checkType(l, 3, out arg2);
			int arg3;
			LuaObject.checkType(l, 4, out arg3);
			signRewardItemUIController.m_luaExportHelper.__clearDele_EventOnSignTodayBoxOpenClick(arg, arg2, arg3);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060210A5 RID: 135333 RVA: 0x00B1B43C File Offset: 0x00B1963C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnShowBoxRewards(IntPtr l)
	{
		int result;
		try
		{
			SignRewardItemUIController signRewardItemUIController = (SignRewardItemUIController)LuaObject.checkSelf(l);
			List<Goods> arg;
			LuaObject.checkType<List<Goods>>(l, 2, out arg);
			SignRewardItemUIController arg2;
			LuaObject.checkType<SignRewardItemUIController>(l, 3, out arg2);
			signRewardItemUIController.m_luaExportHelper.__callDele_EventOnShowBoxRewards(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060210A6 RID: 135334 RVA: 0x00B1B4A8 File Offset: 0x00B196A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnShowBoxRewards(IntPtr l)
	{
		int result;
		try
		{
			SignRewardItemUIController signRewardItemUIController = (SignRewardItemUIController)LuaObject.checkSelf(l);
			List<Goods> arg;
			LuaObject.checkType<List<Goods>>(l, 2, out arg);
			SignRewardItemUIController arg2;
			LuaObject.checkType<SignRewardItemUIController>(l, 3, out arg2);
			signRewardItemUIController.m_luaExportHelper.__clearDele_EventOnShowBoxRewards(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060210A7 RID: 135335 RVA: 0x00B1B514 File Offset: 0x00B19714
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnSignTodayItemClick(IntPtr l)
	{
		int result;
		try
		{
			SignRewardItemUIController signRewardItemUIController = (SignRewardItemUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					signRewardItemUIController.EventOnSignTodayItemClick += value;
				}
				else if (num == 2)
				{
					signRewardItemUIController.EventOnSignTodayItemClick -= value;
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

	// Token: 0x060210A8 RID: 135336 RVA: 0x00B1B594 File Offset: 0x00B19794
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnSignTodayBoxOpenClick(IntPtr l)
	{
		int result;
		try
		{
			SignRewardItemUIController signRewardItemUIController = (SignRewardItemUIController)LuaObject.checkSelf(l);
			Action<GoodsType, int, int> value;
			int num = LuaObject.checkDelegate<Action<GoodsType, int, int>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					signRewardItemUIController.EventOnSignTodayBoxOpenClick += value;
				}
				else if (num == 2)
				{
					signRewardItemUIController.EventOnSignTodayBoxOpenClick -= value;
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

	// Token: 0x060210A9 RID: 135337 RVA: 0x00B1B614 File Offset: 0x00B19814
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnShowBoxRewards(IntPtr l)
	{
		int result;
		try
		{
			SignRewardItemUIController signRewardItemUIController = (SignRewardItemUIController)LuaObject.checkSelf(l);
			Action<List<Goods>, SignRewardItemUIController> value;
			int num = LuaObject.checkDelegate<Action<List<Goods>, SignRewardItemUIController>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					signRewardItemUIController.EventOnShowBoxRewards += value;
				}
				else if (num == 2)
				{
					signRewardItemUIController.EventOnShowBoxRewards -= value;
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

	// Token: 0x060210AA RID: 135338 RVA: 0x00B1B694 File Offset: 0x00B19894
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_signItemGoodsDummy(IntPtr l)
	{
		int result;
		try
		{
			SignRewardItemUIController signRewardItemUIController = (SignRewardItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, signRewardItemUIController.m_luaExportHelper.m_signItemGoodsDummy);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060210AB RID: 135339 RVA: 0x00B1B6EC File Offset: 0x00B198EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_signItemGoodsDummy(IntPtr l)
	{
		int result;
		try
		{
			SignRewardItemUIController signRewardItemUIController = (SignRewardItemUIController)LuaObject.checkSelf(l);
			GameObject signItemGoodsDummy;
			LuaObject.checkType<GameObject>(l, 2, out signItemGoodsDummy);
			signRewardItemUIController.m_luaExportHelper.m_signItemGoodsDummy = signItemGoodsDummy;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060210AC RID: 135340 RVA: 0x00B1B748 File Offset: 0x00B19948
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_itemFrameImage(IntPtr l)
	{
		int result;
		try
		{
			SignRewardItemUIController signRewardItemUIController = (SignRewardItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, signRewardItemUIController.m_itemFrameImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060210AD RID: 135341 RVA: 0x00B1B79C File Offset: 0x00B1999C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_itemFrameImage(IntPtr l)
	{
		int result;
		try
		{
			SignRewardItemUIController signRewardItemUIController = (SignRewardItemUIController)LuaObject.checkSelf(l);
			Image itemFrameImage;
			LuaObject.checkType<Image>(l, 2, out itemFrameImage);
			signRewardItemUIController.m_itemFrameImage = itemFrameImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060210AE RID: 135342 RVA: 0x00B1B7F4 File Offset: 0x00B199F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_signItemUIStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			SignRewardItemUIController signRewardItemUIController = (SignRewardItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, signRewardItemUIController.m_luaExportHelper.m_signItemUIStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060210AF RID: 135343 RVA: 0x00B1B84C File Offset: 0x00B19A4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_signItemUIStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			SignRewardItemUIController signRewardItemUIController = (SignRewardItemUIController)LuaObject.checkSelf(l);
			CommonUIStateController signItemUIStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out signItemUIStateCtrl);
			signRewardItemUIController.m_luaExportHelper.m_signItemUIStateCtrl = signItemUIStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060210B0 RID: 135344 RVA: 0x00B1B8A8 File Offset: 0x00B19AA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_dayText(IntPtr l)
	{
		int result;
		try
		{
			SignRewardItemUIController signRewardItemUIController = (SignRewardItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, signRewardItemUIController.m_luaExportHelper.m_dayText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060210B1 RID: 135345 RVA: 0x00B1B900 File Offset: 0x00B19B00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_dayText(IntPtr l)
	{
		int result;
		try
		{
			SignRewardItemUIController signRewardItemUIController = (SignRewardItemUIController)LuaObject.checkSelf(l);
			Text dayText;
			LuaObject.checkType<Text>(l, 2, out dayText);
			signRewardItemUIController.m_luaExportHelper.m_dayText = dayText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060210B2 RID: 135346 RVA: 0x00B1B95C File Offset: 0x00B19B5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_signState(IntPtr l)
	{
		int result;
		try
		{
			SignRewardItemUIController signRewardItemUIController = (SignRewardItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)signRewardItemUIController.m_luaExportHelper.m_signState);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060210B3 RID: 135347 RVA: 0x00B1B9B4 File Offset: 0x00B19BB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_signState(IntPtr l)
	{
		int result;
		try
		{
			SignRewardItemUIController signRewardItemUIController = (SignRewardItemUIController)LuaObject.checkSelf(l);
			SignRewardItemUIController.SignState signState;
			LuaObject.checkEnum<SignRewardItemUIController.SignState>(l, 2, out signState);
			signRewardItemUIController.m_luaExportHelper.m_signState = signState;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060210B4 RID: 135348 RVA: 0x00B1BA10 File Offset: 0x00B19C10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_goodsType(IntPtr l)
	{
		int result;
		try
		{
			SignRewardItemUIController signRewardItemUIController = (SignRewardItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)signRewardItemUIController.m_luaExportHelper.m_goodsType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060210B5 RID: 135349 RVA: 0x00B1BA68 File Offset: 0x00B19C68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_goodsType(IntPtr l)
	{
		int result;
		try
		{
			SignRewardItemUIController signRewardItemUIController = (SignRewardItemUIController)LuaObject.checkSelf(l);
			GoodsType goodsType;
			LuaObject.checkEnum<GoodsType>(l, 2, out goodsType);
			signRewardItemUIController.m_luaExportHelper.m_goodsType = goodsType;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060210B6 RID: 135350 RVA: 0x00B1BAC4 File Offset: 0x00B19CC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_goodsId(IntPtr l)
	{
		int result;
		try
		{
			SignRewardItemUIController signRewardItemUIController = (SignRewardItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, signRewardItemUIController.m_luaExportHelper.m_goodsId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060210B7 RID: 135351 RVA: 0x00B1BB1C File Offset: 0x00B19D1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_goodsId(IntPtr l)
	{
		int result;
		try
		{
			SignRewardItemUIController signRewardItemUIController = (SignRewardItemUIController)LuaObject.checkSelf(l);
			int goodsId;
			LuaObject.checkType(l, 2, out goodsId);
			signRewardItemUIController.m_luaExportHelper.m_goodsId = goodsId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060210B8 RID: 135352 RVA: 0x00B1BB78 File Offset: 0x00B19D78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_goodsCount(IntPtr l)
	{
		int result;
		try
		{
			SignRewardItemUIController signRewardItemUIController = (SignRewardItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, signRewardItemUIController.m_luaExportHelper.m_goodsCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060210B9 RID: 135353 RVA: 0x00B1BBD0 File Offset: 0x00B19DD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_goodsCount(IntPtr l)
	{
		int result;
		try
		{
			SignRewardItemUIController signRewardItemUIController = (SignRewardItemUIController)LuaObject.checkSelf(l);
			int goodsCount;
			LuaObject.checkType(l, 2, out goodsCount);
			signRewardItemUIController.m_luaExportHelper.m_goodsCount = goodsCount;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060210BA RID: 135354 RVA: 0x00B1BC2C File Offset: 0x00B19E2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_itemInfo(IntPtr l)
	{
		int result;
		try
		{
			SignRewardItemUIController signRewardItemUIController = (SignRewardItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, signRewardItemUIController.m_luaExportHelper.m_itemInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060210BB RID: 135355 RVA: 0x00B1BC84 File Offset: 0x00B19E84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_itemInfo(IntPtr l)
	{
		int result;
		try
		{
			SignRewardItemUIController signRewardItemUIController = (SignRewardItemUIController)LuaObject.checkSelf(l);
			ConfigDataItemInfo itemInfo;
			LuaObject.checkType<ConfigDataItemInfo>(l, 2, out itemInfo);
			signRewardItemUIController.m_luaExportHelper.m_itemInfo = itemInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060210BC RID: 135356 RVA: 0x00B1BCE0 File Offset: 0x00B19EE0
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.SignRewardItemUIController");
		if (Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.OnPointerClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.SetReward);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.SetDay);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.PlaySignAnimation);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.TodayAutoSign);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.GetGoodsType);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.GetGoodsId);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.GetGoodsCount);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.Co_ChangeStateToSigning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.__callDele_EventOnSignTodayItemClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.__clearDele_EventOnSignTodayItemClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.__callDele_EventOnSignTodayBoxOpenClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.__clearDele_EventOnSignTodayBoxOpenClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.__callDele_EventOnShowBoxRewards);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.__clearDele_EventOnShowBoxRewards);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cache1C);
		string name = "EventOnSignTodayItemClick";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.set_EventOnSignTodayItemClick);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cache1D, true);
		string name2 = "EventOnSignTodayBoxOpenClick";
		LuaCSFunction get2 = null;
		if (Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.set_EventOnSignTodayBoxOpenClick);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cache1E, true);
		string name3 = "EventOnShowBoxRewards";
		LuaCSFunction get3 = null;
		if (Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.set_EventOnShowBoxRewards);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cache1F, true);
		string name4 = "m_signItemGoodsDummy";
		if (Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.get_m_signItemGoodsDummy);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cache20;
		if (Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.set_m_signItemGoodsDummy);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cache21, true);
		string name5 = "m_itemFrameImage";
		if (Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.get_m_itemFrameImage);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cache22;
		if (Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.set_m_itemFrameImage);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cache23, true);
		string name6 = "m_signItemUIStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.get_m_signItemUIStateCtrl);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cache24;
		if (Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.set_m_signItemUIStateCtrl);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cache25, true);
		string name7 = "m_dayText";
		if (Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.get_m_dayText);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cache26;
		if (Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.set_m_dayText);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cache27, true);
		string name8 = "m_signState";
		if (Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.get_m_signState);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cache28;
		if (Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.set_m_signState);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cache29, true);
		string name9 = "m_goodsType";
		if (Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.get_m_goodsType);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cache2A;
		if (Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.set_m_goodsType);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cache2B, true);
		string name10 = "m_goodsId";
		if (Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.get_m_goodsId);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cache2C;
		if (Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.set_m_goodsId);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cache2D, true);
		string name11 = "m_goodsCount";
		if (Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.get_m_goodsCount);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cache2E;
		if (Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.set_m_goodsCount);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cache2F, true);
		string name12 = "m_itemInfo";
		if (Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.get_m_itemInfo);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cache30;
		if (Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.set_m_itemInfo);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.<>f__mg$cache31, true);
		LuaObject.createTypeMetatable(l, null, typeof(SignRewardItemUIController), typeof(UIControllerBase));
	}

	// Token: 0x04016F7C RID: 94076
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04016F7D RID: 94077
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04016F7E RID: 94078
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04016F7F RID: 94079
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04016F80 RID: 94080
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04016F81 RID: 94081
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04016F82 RID: 94082
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04016F83 RID: 94083
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04016F84 RID: 94084
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04016F85 RID: 94085
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04016F86 RID: 94086
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04016F87 RID: 94087
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04016F88 RID: 94088
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04016F89 RID: 94089
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04016F8A RID: 94090
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04016F8B RID: 94091
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04016F8C RID: 94092
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04016F8D RID: 94093
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04016F8E RID: 94094
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04016F8F RID: 94095
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04016F90 RID: 94096
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04016F91 RID: 94097
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04016F92 RID: 94098
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04016F93 RID: 94099
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04016F94 RID: 94100
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04016F95 RID: 94101
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04016F96 RID: 94102
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04016F97 RID: 94103
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04016F98 RID: 94104
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04016F99 RID: 94105
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04016F9A RID: 94106
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04016F9B RID: 94107
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04016F9C RID: 94108
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04016F9D RID: 94109
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04016F9E RID: 94110
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04016F9F RID: 94111
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04016FA0 RID: 94112
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04016FA1 RID: 94113
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04016FA2 RID: 94114
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04016FA3 RID: 94115
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04016FA4 RID: 94116
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04016FA5 RID: 94117
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04016FA6 RID: 94118
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04016FA7 RID: 94119
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04016FA8 RID: 94120
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04016FA9 RID: 94121
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04016FAA RID: 94122
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04016FAB RID: 94123
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04016FAC RID: 94124
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04016FAD RID: 94125
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;
}
