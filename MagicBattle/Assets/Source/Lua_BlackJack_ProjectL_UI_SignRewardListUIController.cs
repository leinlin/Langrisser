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

// Token: 0x02001579 RID: 5497
[Preserve]
public class Lua_BlackJack_ProjectL_UI_SignRewardListUIController : LuaObject
{
	// Token: 0x060210BE RID: 135358 RVA: 0x00B1C408 File Offset: 0x00B1A608
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int EnableCloseButton(IntPtr l)
	{
		int result;
		try
		{
			SignRewardListUIController signRewardListUIController = (SignRewardListUIController)LuaObject.checkSelf(l);
			bool bEnable;
			LuaObject.checkType(l, 2, out bEnable);
			signRewardListUIController.EnableCloseButton(bEnable);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060210BF RID: 135359 RVA: 0x00B1C460 File Offset: 0x00B1A660
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetSignDays(IntPtr l)
	{
		int result;
		try
		{
			SignRewardListUIController signRewardListUIController = (SignRewardListUIController)LuaObject.checkSelf(l);
			signRewardListUIController.SetSignDays();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060210C0 RID: 135360 RVA: 0x00B1C4AC File Offset: 0x00B1A6AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitSignRewardItem(IntPtr l)
	{
		int result;
		try
		{
			SignRewardListUIController signRewardListUIController = (SignRewardListUIController)LuaObject.checkSelf(l);
			signRewardListUIController.InitSignRewardItem();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060210C1 RID: 135361 RVA: 0x00B1C4F8 File Offset: 0x00B1A6F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlaySignAnimation(IntPtr l)
	{
		int result;
		try
		{
			SignRewardListUIController signRewardListUIController = (SignRewardListUIController)LuaObject.checkSelf(l);
			Action onEnd;
			LuaObject.checkDelegate<Action>(l, 2, out onEnd);
			signRewardListUIController.PlaySignAnimation(onEnd);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060210C2 RID: 135362 RVA: 0x00B1C550 File Offset: 0x00B1A750
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AutoSign(IntPtr l)
	{
		int result;
		try
		{
			SignRewardListUIController signRewardListUIController = (SignRewardListUIController)LuaObject.checkSelf(l);
			signRewardListUIController.AutoSign();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060210C3 RID: 135363 RVA: 0x00B1C59C File Offset: 0x00B1A79C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SignOpenTween(IntPtr l)
	{
		int result;
		try
		{
			SignRewardListUIController signRewardListUIController = (SignRewardListUIController)LuaObject.checkSelf(l);
			Action onEnd;
			LuaObject.checkDelegate<Action>(l, 2, out onEnd);
			signRewardListUIController.SignOpenTween(onEnd);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060210C4 RID: 135364 RVA: 0x00B1C5F4 File Offset: 0x00B1A7F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowBoxRewards(IntPtr l)
	{
		int result;
		try
		{
			SignRewardListUIController signRewardListUIController = (SignRewardListUIController)LuaObject.checkSelf(l);
			List<Goods> items;
			LuaObject.checkType<List<Goods>>(l, 2, out items);
			SignRewardItemUIController ctrl;
			LuaObject.checkType<SignRewardItemUIController>(l, 3, out ctrl);
			signRewardListUIController.ShowBoxRewards(items, ctrl);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060210C5 RID: 135365 RVA: 0x00B1C658 File Offset: 0x00B1A858
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			SignRewardListUIController signRewardListUIController = (SignRewardListUIController)LuaObject.checkSelf(l);
			signRewardListUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060210C6 RID: 135366 RVA: 0x00B1C6AC File Offset: 0x00B1A8AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CloseBoxRewardShowPanel(IntPtr l)
	{
		int result;
		try
		{
			SignRewardListUIController signRewardListUIController = (SignRewardListUIController)LuaObject.checkSelf(l);
			signRewardListUIController.m_luaExportHelper.CloseBoxRewardShowPanel();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060210C7 RID: 135367 RVA: 0x00B1C700 File Offset: 0x00B1A900
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnCloseButtonClick(IntPtr l)
	{
		int result;
		try
		{
			SignRewardListUIController signRewardListUIController = (SignRewardListUIController)LuaObject.checkSelf(l);
			signRewardListUIController.m_luaExportHelper.OnCloseButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060210C8 RID: 135368 RVA: 0x00B1C754 File Offset: 0x00B1A954
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnSignItemClick(IntPtr l)
	{
		int result;
		try
		{
			SignRewardListUIController signRewardListUIController = (SignRewardListUIController)LuaObject.checkSelf(l);
			signRewardListUIController.m_luaExportHelper.OnSignItemClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060210C9 RID: 135369 RVA: 0x00B1C7A8 File Offset: 0x00B1A9A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnSignBoxClick(IntPtr l)
	{
		int result;
		try
		{
			SignRewardListUIController signRewardListUIController = (SignRewardListUIController)LuaObject.checkSelf(l);
			GoodsType type;
			LuaObject.checkEnum<GoodsType>(l, 2, out type);
			int id;
			LuaObject.checkType(l, 3, out id);
			int count;
			LuaObject.checkType(l, 4, out count);
			signRewardListUIController.m_luaExportHelper.OnSignBoxClick(type, id, count);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060210CA RID: 135370 RVA: 0x00B1C820 File Offset: 0x00B1AA20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			SignRewardListUIController signRewardListUIController = (SignRewardListUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			signRewardListUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060210CB RID: 135371 RVA: 0x00B1C88C File Offset: 0x00B1AA8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			SignRewardListUIController signRewardListUIController = (SignRewardListUIController)LuaObject.checkSelf(l);
			signRewardListUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060210CC RID: 135372 RVA: 0x00B1C8E0 File Offset: 0x00B1AAE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			SignRewardListUIController signRewardListUIController = (SignRewardListUIController)LuaObject.checkSelf(l);
			signRewardListUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060210CD RID: 135373 RVA: 0x00B1C934 File Offset: 0x00B1AB34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			SignRewardListUIController signRewardListUIController = (SignRewardListUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = signRewardListUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x060210CE RID: 135374 RVA: 0x00B1C9DC File Offset: 0x00B1ABDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			SignRewardListUIController signRewardListUIController = (SignRewardListUIController)LuaObject.checkSelf(l);
			signRewardListUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060210CF RID: 135375 RVA: 0x00B1CA30 File Offset: 0x00B1AC30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			SignRewardListUIController signRewardListUIController = (SignRewardListUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			signRewardListUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060210D0 RID: 135376 RVA: 0x00B1CA9C File Offset: 0x00B1AC9C
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
				SignRewardListUIController signRewardListUIController = (SignRewardListUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				signRewardListUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				SignRewardListUIController signRewardListUIController2 = (SignRewardListUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				signRewardListUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x060210D1 RID: 135377 RVA: 0x00B1CBAC File Offset: 0x00B1ADAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			SignRewardListUIController signRewardListUIController = (SignRewardListUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			signRewardListUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060210D2 RID: 135378 RVA: 0x00B1CC18 File Offset: 0x00B1AE18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			SignRewardListUIController signRewardListUIController = (SignRewardListUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			signRewardListUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060210D3 RID: 135379 RVA: 0x00B1CC84 File Offset: 0x00B1AE84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			SignRewardListUIController signRewardListUIController = (SignRewardListUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			signRewardListUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060210D4 RID: 135380 RVA: 0x00B1CCF0 File Offset: 0x00B1AEF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			SignRewardListUIController signRewardListUIController = (SignRewardListUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			signRewardListUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060210D5 RID: 135381 RVA: 0x00B1CD5C File Offset: 0x00B1AF5C
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
				SignRewardListUIController signRewardListUIController = (SignRewardListUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				signRewardListUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				SignRewardListUIController signRewardListUIController2 = (SignRewardListUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				signRewardListUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x060210D6 RID: 135382 RVA: 0x00B1CE6C File Offset: 0x00B1B06C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			SignRewardListUIController signRewardListUIController = (SignRewardListUIController)LuaObject.checkSelf(l);
			string s = signRewardListUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x060210D7 RID: 135383 RVA: 0x00B1CEC8 File Offset: 0x00B1B0C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnSignTodayListClick(IntPtr l)
	{
		int result;
		try
		{
			SignRewardListUIController signRewardListUIController = (SignRewardListUIController)LuaObject.checkSelf(l);
			signRewardListUIController.m_luaExportHelper.__callDele_EventOnSignTodayListClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060210D8 RID: 135384 RVA: 0x00B1CF1C File Offset: 0x00B1B11C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnSignTodayListClick(IntPtr l)
	{
		int result;
		try
		{
			SignRewardListUIController signRewardListUIController = (SignRewardListUIController)LuaObject.checkSelf(l);
			signRewardListUIController.m_luaExportHelper.__clearDele_EventOnSignTodayListClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060210D9 RID: 135385 RVA: 0x00B1CF70 File Offset: 0x00B1B170
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnSignTodayBoxListClick(IntPtr l)
	{
		int result;
		try
		{
			SignRewardListUIController signRewardListUIController = (SignRewardListUIController)LuaObject.checkSelf(l);
			GoodsType arg;
			LuaObject.checkEnum<GoodsType>(l, 2, out arg);
			int arg2;
			LuaObject.checkType(l, 3, out arg2);
			int arg3;
			LuaObject.checkType(l, 4, out arg3);
			signRewardListUIController.m_luaExportHelper.__callDele_EventOnSignTodayBoxListClick(arg, arg2, arg3);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060210DA RID: 135386 RVA: 0x00B1CFE8 File Offset: 0x00B1B1E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnSignTodayBoxListClick(IntPtr l)
	{
		int result;
		try
		{
			SignRewardListUIController signRewardListUIController = (SignRewardListUIController)LuaObject.checkSelf(l);
			GoodsType arg;
			LuaObject.checkEnum<GoodsType>(l, 2, out arg);
			int arg2;
			LuaObject.checkType(l, 3, out arg2);
			int arg3;
			LuaObject.checkType(l, 4, out arg3);
			signRewardListUIController.m_luaExportHelper.__clearDele_EventOnSignTodayBoxListClick(arg, arg2, arg3);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060210DB RID: 135387 RVA: 0x00B1D060 File Offset: 0x00B1B260
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnSignCloseButtonClick(IntPtr l)
	{
		int result;
		try
		{
			SignRewardListUIController signRewardListUIController = (SignRewardListUIController)LuaObject.checkSelf(l);
			signRewardListUIController.m_luaExportHelper.__callDele_EventOnSignCloseButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060210DC RID: 135388 RVA: 0x00B1D0B4 File Offset: 0x00B1B2B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnSignCloseButtonClick(IntPtr l)
	{
		int result;
		try
		{
			SignRewardListUIController signRewardListUIController = (SignRewardListUIController)LuaObject.checkSelf(l);
			signRewardListUIController.m_luaExportHelper.__clearDele_EventOnSignCloseButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060210DD RID: 135389 RVA: 0x00B1D108 File Offset: 0x00B1B308
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnSignTodayListClick(IntPtr l)
	{
		int result;
		try
		{
			SignRewardListUIController signRewardListUIController = (SignRewardListUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					signRewardListUIController.EventOnSignTodayListClick += value;
				}
				else if (num == 2)
				{
					signRewardListUIController.EventOnSignTodayListClick -= value;
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

	// Token: 0x060210DE RID: 135390 RVA: 0x00B1D188 File Offset: 0x00B1B388
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnSignTodayBoxListClick(IntPtr l)
	{
		int result;
		try
		{
			SignRewardListUIController signRewardListUIController = (SignRewardListUIController)LuaObject.checkSelf(l);
			Action<GoodsType, int, int> value;
			int num = LuaObject.checkDelegate<Action<GoodsType, int, int>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					signRewardListUIController.EventOnSignTodayBoxListClick += value;
				}
				else if (num == 2)
				{
					signRewardListUIController.EventOnSignTodayBoxListClick -= value;
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

	// Token: 0x060210DF RID: 135391 RVA: 0x00B1D208 File Offset: 0x00B1B408
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnSignCloseButtonClick(IntPtr l)
	{
		int result;
		try
		{
			SignRewardListUIController signRewardListUIController = (SignRewardListUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					signRewardListUIController.EventOnSignCloseButtonClick += value;
				}
				else if (num == 2)
				{
					signRewardListUIController.EventOnSignCloseButtonClick -= value;
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

	// Token: 0x060210E0 RID: 135392 RVA: 0x00B1D288 File Offset: 0x00B1B488
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_signUIStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			SignRewardListUIController signRewardListUIController = (SignRewardListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, signRewardListUIController.m_luaExportHelper.m_signUIStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060210E1 RID: 135393 RVA: 0x00B1D2E0 File Offset: 0x00B1B4E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_signUIStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			SignRewardListUIController signRewardListUIController = (SignRewardListUIController)LuaObject.checkSelf(l);
			CommonUIStateController signUIStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out signUIStateCtrl);
			signRewardListUIController.m_luaExportHelper.m_signUIStateCtrl = signUIStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060210E2 RID: 135394 RVA: 0x00B1D33C File Offset: 0x00B1B53C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_bgButton(IntPtr l)
	{
		int result;
		try
		{
			SignRewardListUIController signRewardListUIController = (SignRewardListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, signRewardListUIController.m_luaExportHelper.m_bgButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060210E3 RID: 135395 RVA: 0x00B1D394 File Offset: 0x00B1B594
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_bgButton(IntPtr l)
	{
		int result;
		try
		{
			SignRewardListUIController signRewardListUIController = (SignRewardListUIController)LuaObject.checkSelf(l);
			Button bgButton;
			LuaObject.checkType<Button>(l, 2, out bgButton);
			signRewardListUIController.m_luaExportHelper.m_bgButton = bgButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060210E4 RID: 135396 RVA: 0x00B1D3F0 File Offset: 0x00B1B5F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_closeButton(IntPtr l)
	{
		int result;
		try
		{
			SignRewardListUIController signRewardListUIController = (SignRewardListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, signRewardListUIController.m_luaExportHelper.m_closeButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060210E5 RID: 135397 RVA: 0x00B1D448 File Offset: 0x00B1B648
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_closeButton(IntPtr l)
	{
		int result;
		try
		{
			SignRewardListUIController signRewardListUIController = (SignRewardListUIController)LuaObject.checkSelf(l);
			Button closeButton;
			LuaObject.checkType<Button>(l, 2, out closeButton);
			signRewardListUIController.m_luaExportHelper.m_closeButton = closeButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060210E6 RID: 135398 RVA: 0x00B1D4A4 File Offset: 0x00B1B6A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_scrollViewSignRewardItemContent(IntPtr l)
	{
		int result;
		try
		{
			SignRewardListUIController signRewardListUIController = (SignRewardListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, signRewardListUIController.m_luaExportHelper.m_scrollViewSignRewardItemContent);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060210E7 RID: 135399 RVA: 0x00B1D4FC File Offset: 0x00B1B6FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_scrollViewSignRewardItemContent(IntPtr l)
	{
		int result;
		try
		{
			SignRewardListUIController signRewardListUIController = (SignRewardListUIController)LuaObject.checkSelf(l);
			GameObject scrollViewSignRewardItemContent;
			LuaObject.checkType<GameObject>(l, 2, out scrollViewSignRewardItemContent);
			signRewardListUIController.m_luaExportHelper.m_scrollViewSignRewardItemContent = scrollViewSignRewardItemContent;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060210E8 RID: 135400 RVA: 0x00B1D558 File Offset: 0x00B1B758
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_signDaysMonthText(IntPtr l)
	{
		int result;
		try
		{
			SignRewardListUIController signRewardListUIController = (SignRewardListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, signRewardListUIController.m_luaExportHelper.m_signDaysMonthText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060210E9 RID: 135401 RVA: 0x00B1D5B0 File Offset: 0x00B1B7B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_signDaysMonthText(IntPtr l)
	{
		int result;
		try
		{
			SignRewardListUIController signRewardListUIController = (SignRewardListUIController)LuaObject.checkSelf(l);
			Text signDaysMonthText;
			LuaObject.checkType<Text>(l, 2, out signDaysMonthText);
			signRewardListUIController.m_luaExportHelper.m_signDaysMonthText = signDaysMonthText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060210EA RID: 135402 RVA: 0x00B1D60C File Offset: 0x00B1B80C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_showBoxRewardPanelUIStateController(IntPtr l)
	{
		int result;
		try
		{
			SignRewardListUIController signRewardListUIController = (SignRewardListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, signRewardListUIController.m_luaExportHelper.m_showBoxRewardPanelUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060210EB RID: 135403 RVA: 0x00B1D664 File Offset: 0x00B1B864
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_showBoxRewardPanelUIStateController(IntPtr l)
	{
		int result;
		try
		{
			SignRewardListUIController signRewardListUIController = (SignRewardListUIController)LuaObject.checkSelf(l);
			CommonUIStateController showBoxRewardPanelUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out showBoxRewardPanelUIStateController);
			signRewardListUIController.m_luaExportHelper.m_showBoxRewardPanelUIStateController = showBoxRewardPanelUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060210EC RID: 135404 RVA: 0x00B1D6C0 File Offset: 0x00B1B8C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_showBoxRewardPanelBGButton(IntPtr l)
	{
		int result;
		try
		{
			SignRewardListUIController signRewardListUIController = (SignRewardListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, signRewardListUIController.m_luaExportHelper.m_showBoxRewardPanelBGButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060210ED RID: 135405 RVA: 0x00B1D718 File Offset: 0x00B1B918
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_showBoxRewardPanelBGButton(IntPtr l)
	{
		int result;
		try
		{
			SignRewardListUIController signRewardListUIController = (SignRewardListUIController)LuaObject.checkSelf(l);
			Button showBoxRewardPanelBGButton;
			LuaObject.checkType<Button>(l, 2, out showBoxRewardPanelBGButton);
			signRewardListUIController.m_luaExportHelper.m_showBoxRewardPanelBGButton = showBoxRewardPanelBGButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060210EE RID: 135406 RVA: 0x00B1D774 File Offset: 0x00B1B974
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_boxRewardScrollViewObj(IntPtr l)
	{
		int result;
		try
		{
			SignRewardListUIController signRewardListUIController = (SignRewardListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, signRewardListUIController.m_luaExportHelper.m_boxRewardScrollViewObj);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060210EF RID: 135407 RVA: 0x00B1D7CC File Offset: 0x00B1B9CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_boxRewardScrollViewObj(IntPtr l)
	{
		int result;
		try
		{
			SignRewardListUIController signRewardListUIController = (SignRewardListUIController)LuaObject.checkSelf(l);
			GameObject boxRewardScrollViewObj;
			LuaObject.checkType<GameObject>(l, 2, out boxRewardScrollViewObj);
			signRewardListUIController.m_luaExportHelper.m_boxRewardScrollViewObj = boxRewardScrollViewObj;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060210F0 RID: 135408 RVA: 0x00B1D828 File Offset: 0x00B1BA28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_boxIconImage(IntPtr l)
	{
		int result;
		try
		{
			SignRewardListUIController signRewardListUIController = (SignRewardListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, signRewardListUIController.m_luaExportHelper.m_boxIconImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060210F1 RID: 135409 RVA: 0x00B1D880 File Offset: 0x00B1BA80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_boxIconImage(IntPtr l)
	{
		int result;
		try
		{
			SignRewardListUIController signRewardListUIController = (SignRewardListUIController)LuaObject.checkSelf(l);
			Image boxIconImage;
			LuaObject.checkType<Image>(l, 2, out boxIconImage);
			signRewardListUIController.m_luaExportHelper.m_boxIconImage = boxIconImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060210F2 RID: 135410 RVA: 0x00B1D8DC File Offset: 0x00B1BADC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_boxCountText(IntPtr l)
	{
		int result;
		try
		{
			SignRewardListUIController signRewardListUIController = (SignRewardListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, signRewardListUIController.m_luaExportHelper.m_boxCountText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060210F3 RID: 135411 RVA: 0x00B1D934 File Offset: 0x00B1BB34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_boxCountText(IntPtr l)
	{
		int result;
		try
		{
			SignRewardListUIController signRewardListUIController = (SignRewardListUIController)LuaObject.checkSelf(l);
			Text boxCountText;
			LuaObject.checkType<Text>(l, 2, out boxCountText);
			signRewardListUIController.m_luaExportHelper.m_boxCountText = boxCountText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060210F4 RID: 135412 RVA: 0x00B1D990 File Offset: 0x00B1BB90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_boxNameText(IntPtr l)
	{
		int result;
		try
		{
			SignRewardListUIController signRewardListUIController = (SignRewardListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, signRewardListUIController.m_luaExportHelper.m_boxNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060210F5 RID: 135413 RVA: 0x00B1D9E8 File Offset: 0x00B1BBE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_boxNameText(IntPtr l)
	{
		int result;
		try
		{
			SignRewardListUIController signRewardListUIController = (SignRewardListUIController)LuaObject.checkSelf(l);
			Text boxNameText;
			LuaObject.checkType<Text>(l, 2, out boxNameText);
			signRewardListUIController.m_luaExportHelper.m_boxNameText = boxNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060210F6 RID: 135414 RVA: 0x00B1DA44 File Offset: 0x00B1BC44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_boxHaveCountText(IntPtr l)
	{
		int result;
		try
		{
			SignRewardListUIController signRewardListUIController = (SignRewardListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, signRewardListUIController.m_luaExportHelper.m_boxHaveCountText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060210F7 RID: 135415 RVA: 0x00B1DA9C File Offset: 0x00B1BC9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_boxHaveCountText(IntPtr l)
	{
		int result;
		try
		{
			SignRewardListUIController signRewardListUIController = (SignRewardListUIController)LuaObject.checkSelf(l);
			Text boxHaveCountText;
			LuaObject.checkType<Text>(l, 2, out boxHaveCountText);
			signRewardListUIController.m_luaExportHelper.m_boxHaveCountText = boxHaveCountText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060210F8 RID: 135416 RVA: 0x00B1DAF8 File Offset: 0x00B1BCF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_boxDescText(IntPtr l)
	{
		int result;
		try
		{
			SignRewardListUIController signRewardListUIController = (SignRewardListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, signRewardListUIController.m_luaExportHelper.m_boxDescText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060210F9 RID: 135417 RVA: 0x00B1DB50 File Offset: 0x00B1BD50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_boxDescText(IntPtr l)
	{
		int result;
		try
		{
			SignRewardListUIController signRewardListUIController = (SignRewardListUIController)LuaObject.checkSelf(l);
			Text boxDescText;
			LuaObject.checkType<Text>(l, 2, out boxDescText);
			signRewardListUIController.m_luaExportHelper.m_boxDescText = boxDescText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060210FA RID: 135418 RVA: 0x00B1DBAC File Offset: 0x00B1BDAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_signBoxItemPrefab(IntPtr l)
	{
		int result;
		try
		{
			SignRewardListUIController signRewardListUIController = (SignRewardListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, signRewardListUIController.m_luaExportHelper.m_signBoxItemPrefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060210FB RID: 135419 RVA: 0x00B1DC04 File Offset: 0x00B1BE04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_signBoxItemPrefab(IntPtr l)
	{
		int result;
		try
		{
			SignRewardListUIController signRewardListUIController = (SignRewardListUIController)LuaObject.checkSelf(l);
			GameObject signBoxItemPrefab;
			LuaObject.checkType<GameObject>(l, 2, out signBoxItemPrefab);
			signRewardListUIController.m_luaExportHelper.m_signBoxItemPrefab = signBoxItemPrefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060210FC RID: 135420 RVA: 0x00B1DC60 File Offset: 0x00B1BE60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_signRewardItemCtrlList(IntPtr l)
	{
		int result;
		try
		{
			SignRewardListUIController signRewardListUIController = (SignRewardListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, signRewardListUIController.m_luaExportHelper.m_signRewardItemCtrlList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060210FD RID: 135421 RVA: 0x00B1DCB8 File Offset: 0x00B1BEB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_signRewardItemCtrlList(IntPtr l)
	{
		int result;
		try
		{
			SignRewardListUIController signRewardListUIController = (SignRewardListUIController)LuaObject.checkSelf(l);
			List<SignRewardItemUIController> signRewardItemCtrlList;
			LuaObject.checkType<List<SignRewardItemUIController>>(l, 2, out signRewardItemCtrlList);
			signRewardListUIController.m_luaExportHelper.m_signRewardItemCtrlList = signRewardItemCtrlList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060210FE RID: 135422 RVA: 0x00B1DD14 File Offset: 0x00B1BF14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			SignRewardListUIController signRewardListUIController = (SignRewardListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, signRewardListUIController.m_luaExportHelper.m_playerContext);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060210FF RID: 135423 RVA: 0x00B1DD6C File Offset: 0x00B1BF6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			SignRewardListUIController signRewardListUIController = (SignRewardListUIController)LuaObject.checkSelf(l);
			ProjectLPlayerContext playerContext;
			LuaObject.checkType<ProjectLPlayerContext>(l, 2, out playerContext);
			signRewardListUIController.m_luaExportHelper.m_playerContext = playerContext;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021100 RID: 135424 RVA: 0x00B1DDC8 File Offset: 0x00B1BFC8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.SignRewardListUIController");
		if (Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignRewardListUIController.EnableCloseButton);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignRewardListUIController.SetSignDays);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignRewardListUIController.InitSignRewardItem);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignRewardListUIController.PlaySignAnimation);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignRewardListUIController.AutoSign);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignRewardListUIController.SignOpenTween);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignRewardListUIController.ShowBoxRewards);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignRewardListUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignRewardListUIController.CloseBoxRewardShowPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignRewardListUIController.OnCloseButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignRewardListUIController.OnSignItemClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignRewardListUIController.OnSignBoxClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignRewardListUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignRewardListUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignRewardListUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignRewardListUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignRewardListUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignRewardListUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignRewardListUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignRewardListUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignRewardListUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignRewardListUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignRewardListUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignRewardListUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignRewardListUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignRewardListUIController.__callDele_EventOnSignTodayListClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignRewardListUIController.__clearDele_EventOnSignTodayListClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignRewardListUIController.__callDele_EventOnSignTodayBoxListClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignRewardListUIController.__clearDele_EventOnSignTodayBoxListClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignRewardListUIController.__callDele_EventOnSignCloseButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignRewardListUIController.__clearDele_EventOnSignCloseButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache1E);
		string name = "EventOnSignTodayListClick";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignRewardListUIController.set_EventOnSignTodayListClick);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache1F, true);
		string name2 = "EventOnSignTodayBoxListClick";
		LuaCSFunction get2 = null;
		if (Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignRewardListUIController.set_EventOnSignTodayBoxListClick);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache20, true);
		string name3 = "EventOnSignCloseButtonClick";
		LuaCSFunction get3 = null;
		if (Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignRewardListUIController.set_EventOnSignCloseButtonClick);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache21, true);
		string name4 = "m_signUIStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignRewardListUIController.get_m_signUIStateCtrl);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache22;
		if (Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignRewardListUIController.set_m_signUIStateCtrl);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache23, true);
		string name5 = "m_bgButton";
		if (Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignRewardListUIController.get_m_bgButton);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache24;
		if (Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignRewardListUIController.set_m_bgButton);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache25, true);
		string name6 = "m_closeButton";
		if (Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignRewardListUIController.get_m_closeButton);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache26;
		if (Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignRewardListUIController.set_m_closeButton);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache27, true);
		string name7 = "m_scrollViewSignRewardItemContent";
		if (Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignRewardListUIController.get_m_scrollViewSignRewardItemContent);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache28;
		if (Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignRewardListUIController.set_m_scrollViewSignRewardItemContent);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache29, true);
		string name8 = "m_signDaysMonthText";
		if (Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignRewardListUIController.get_m_signDaysMonthText);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache2A;
		if (Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignRewardListUIController.set_m_signDaysMonthText);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache2B, true);
		string name9 = "m_showBoxRewardPanelUIStateController";
		if (Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignRewardListUIController.get_m_showBoxRewardPanelUIStateController);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache2C;
		if (Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignRewardListUIController.set_m_showBoxRewardPanelUIStateController);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache2D, true);
		string name10 = "m_showBoxRewardPanelBGButton";
		if (Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignRewardListUIController.get_m_showBoxRewardPanelBGButton);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache2E;
		if (Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignRewardListUIController.set_m_showBoxRewardPanelBGButton);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache2F, true);
		string name11 = "m_boxRewardScrollViewObj";
		if (Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignRewardListUIController.get_m_boxRewardScrollViewObj);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache30;
		if (Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignRewardListUIController.set_m_boxRewardScrollViewObj);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache31, true);
		string name12 = "m_boxIconImage";
		if (Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignRewardListUIController.get_m_boxIconImage);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache32;
		if (Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignRewardListUIController.set_m_boxIconImage);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache33, true);
		string name13 = "m_boxCountText";
		if (Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignRewardListUIController.get_m_boxCountText);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache34;
		if (Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignRewardListUIController.set_m_boxCountText);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache35, true);
		string name14 = "m_boxNameText";
		if (Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignRewardListUIController.get_m_boxNameText);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache36;
		if (Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignRewardListUIController.set_m_boxNameText);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache37, true);
		string name15 = "m_boxHaveCountText";
		if (Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignRewardListUIController.get_m_boxHaveCountText);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache38;
		if (Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignRewardListUIController.set_m_boxHaveCountText);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache39, true);
		string name16 = "m_boxDescText";
		if (Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignRewardListUIController.get_m_boxDescText);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache3A;
		if (Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignRewardListUIController.set_m_boxDescText);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache3B, true);
		string name17 = "m_signBoxItemPrefab";
		if (Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignRewardListUIController.get_m_signBoxItemPrefab);
		}
		LuaCSFunction get17 = Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache3C;
		if (Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignRewardListUIController.set_m_signBoxItemPrefab);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache3D, true);
		string name18 = "m_signRewardItemCtrlList";
		if (Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignRewardListUIController.get_m_signRewardItemCtrlList);
		}
		LuaCSFunction get18 = Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache3E;
		if (Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignRewardListUIController.set_m_signRewardItemCtrlList);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache3F, true);
		string name19 = "m_playerContext";
		if (Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignRewardListUIController.get_m_playerContext);
		}
		LuaCSFunction get19 = Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache40;
		if (Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignRewardListUIController.set_m_playerContext);
		}
		LuaObject.addMember(l, name19, get19, Lua_BlackJack_ProjectL_UI_SignRewardListUIController.<>f__mg$cache41, true);
		LuaObject.createTypeMetatable(l, null, typeof(SignRewardListUIController), typeof(UIControllerBase));
	}

	// Token: 0x04016FAE RID: 94126
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04016FAF RID: 94127
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04016FB0 RID: 94128
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04016FB1 RID: 94129
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04016FB2 RID: 94130
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04016FB3 RID: 94131
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04016FB4 RID: 94132
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04016FB5 RID: 94133
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04016FB6 RID: 94134
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04016FB7 RID: 94135
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04016FB8 RID: 94136
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04016FB9 RID: 94137
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04016FBA RID: 94138
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04016FBB RID: 94139
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04016FBC RID: 94140
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04016FBD RID: 94141
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04016FBE RID: 94142
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04016FBF RID: 94143
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04016FC0 RID: 94144
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04016FC1 RID: 94145
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04016FC2 RID: 94146
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04016FC3 RID: 94147
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04016FC4 RID: 94148
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04016FC5 RID: 94149
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04016FC6 RID: 94150
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04016FC7 RID: 94151
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04016FC8 RID: 94152
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04016FC9 RID: 94153
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04016FCA RID: 94154
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04016FCB RID: 94155
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04016FCC RID: 94156
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04016FCD RID: 94157
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04016FCE RID: 94158
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04016FCF RID: 94159
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04016FD0 RID: 94160
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04016FD1 RID: 94161
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04016FD2 RID: 94162
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04016FD3 RID: 94163
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04016FD4 RID: 94164
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04016FD5 RID: 94165
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04016FD6 RID: 94166
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04016FD7 RID: 94167
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04016FD8 RID: 94168
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04016FD9 RID: 94169
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04016FDA RID: 94170
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04016FDB RID: 94171
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04016FDC RID: 94172
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04016FDD RID: 94173
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04016FDE RID: 94174
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04016FDF RID: 94175
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04016FE0 RID: 94176
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x04016FE1 RID: 94177
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x04016FE2 RID: 94178
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x04016FE3 RID: 94179
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x04016FE4 RID: 94180
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x04016FE5 RID: 94181
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x04016FE6 RID: 94182
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x04016FE7 RID: 94183
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x04016FE8 RID: 94184
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x04016FE9 RID: 94185
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x04016FEA RID: 94186
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x04016FEB RID: 94187
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x04016FEC RID: 94188
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x04016FED RID: 94189
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x04016FEE RID: 94190
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x04016FEF RID: 94191
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;
}
