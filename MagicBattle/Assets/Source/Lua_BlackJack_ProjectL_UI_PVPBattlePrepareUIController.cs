using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x0200153E RID: 5438
[Preserve]
public class Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController : LuaObject
{
	// Token: 0x06020754 RID: 132948 RVA: 0x00AD1138 File Offset: 0x00ACF338
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowOrder(IntPtr l)
	{
		int result;
		try
		{
			PVPBattlePrepareUIController pvpbattlePrepareUIController = (PVPBattlePrepareUIController)LuaObject.checkSelf(l);
			bool isFirst;
			LuaObject.checkType(l, 2, out isFirst);
			Action onEnd;
			LuaObject.checkDelegate<Action>(l, 3, out onEnd);
			pvpbattlePrepareUIController.ShowOrder(isFirst, onEnd);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020755 RID: 132949 RVA: 0x00AD119C File Offset: 0x00ACF39C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowPrepareState(IntPtr l)
	{
		int result;
		try
		{
			PVPBattlePrepareUIController pvpbattlePrepareUIController = (PVPBattlePrepareUIController)LuaObject.checkSelf(l);
			bool show;
			LuaObject.checkType(l, 2, out show);
			pvpbattlePrepareUIController.ShowPrepareState(show);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020756 RID: 132950 RVA: 0x00AD11F4 File Offset: 0x00ACF3F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowPickMyHero(IntPtr l)
	{
		int result;
		try
		{
			PVPBattlePrepareUIController pvpbattlePrepareUIController = (PVPBattlePrepareUIController)LuaObject.checkSelf(l);
			int heroCount;
			LuaObject.checkType(l, 2, out heroCount);
			pvpbattlePrepareUIController.ShowPickMyHero(heroCount);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020757 RID: 132951 RVA: 0x00AD124C File Offset: 0x00ACF44C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowWaitOpponent(IntPtr l)
	{
		int result;
		try
		{
			PVPBattlePrepareUIController pvpbattlePrepareUIController = (PVPBattlePrepareUIController)LuaObject.checkSelf(l);
			pvpbattlePrepareUIController.ShowWaitOpponent();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020758 RID: 132952 RVA: 0x00AD1298 File Offset: 0x00ACF498
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowProtectIndicator(IntPtr l)
	{
		int result;
		try
		{
			PVPBattlePrepareUIController pvpbattlePrepareUIController = (PVPBattlePrepareUIController)LuaObject.checkSelf(l);
			int side;
			LuaObject.checkType(l, 2, out side);
			pvpbattlePrepareUIController.ShowProtectIndicator(side);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020759 RID: 132953 RVA: 0x00AD12F0 File Offset: 0x00ACF4F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowBanIndicator(IntPtr l)
	{
		int result;
		try
		{
			PVPBattlePrepareUIController pvpbattlePrepareUIController = (PVPBattlePrepareUIController)LuaObject.checkSelf(l);
			int side;
			LuaObject.checkType(l, 2, out side);
			pvpbattlePrepareUIController.ShowBanIndicator(side);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602075A RID: 132954 RVA: 0x00AD1348 File Offset: 0x00ACF548
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowPrepareCompleteCountdown(IntPtr l)
	{
		int result;
		try
		{
			PVPBattlePrepareUIController pvpbattlePrepareUIController = (PVPBattlePrepareUIController)LuaObject.checkSelf(l);
			Action onEnd;
			LuaObject.checkDelegate<Action>(l, 2, out onEnd);
			pvpbattlePrepareUIController.ShowPrepareCompleteCountdown(onEnd);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602075B RID: 132955 RVA: 0x00AD13A0 File Offset: 0x00ACF5A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetPickHeroCount(IntPtr l)
	{
		int result;
		try
		{
			PVPBattlePrepareUIController pvpbattlePrepareUIController = (PVPBattlePrepareUIController)LuaObject.checkSelf(l);
			int pickHeroCount;
			LuaObject.checkType(l, 2, out pickHeroCount);
			pvpbattlePrepareUIController.SetPickHeroCount(pickHeroCount);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602075C RID: 132956 RVA: 0x00AD13F8 File Offset: 0x00ACF5F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetProtectHeroCount(IntPtr l)
	{
		int result;
		try
		{
			PVPBattlePrepareUIController pvpbattlePrepareUIController = (PVPBattlePrepareUIController)LuaObject.checkSelf(l);
			int protectHeroCount;
			LuaObject.checkType(l, 2, out protectHeroCount);
			pvpbattlePrepareUIController.SetProtectHeroCount(protectHeroCount);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602075D RID: 132957 RVA: 0x00AD1450 File Offset: 0x00ACF650
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetBanHeroCount(IntPtr l)
	{
		int result;
		try
		{
			PVPBattlePrepareUIController pvpbattlePrepareUIController = (PVPBattlePrepareUIController)LuaObject.checkSelf(l);
			int banHeroCount;
			LuaObject.checkType(l, 2, out banHeroCount);
			pvpbattlePrepareUIController.SetBanHeroCount(banHeroCount);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602075E RID: 132958 RVA: 0x00AD14A8 File Offset: 0x00ACF6A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetPrepareConfirmButtonState(IntPtr l)
	{
		int result;
		try
		{
			PVPBattlePrepareUIController pvpbattlePrepareUIController = (PVPBattlePrepareUIController)LuaObject.checkSelf(l);
			bool prepareConfirmButtonState;
			LuaObject.checkType(l, 2, out prepareConfirmButtonState);
			pvpbattlePrepareUIController.SetPrepareConfirmButtonState(prepareConfirmButtonState);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602075F RID: 132959 RVA: 0x00AD1500 File Offset: 0x00ACF700
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetPrepareCountdown(IntPtr l)
	{
		int result;
		try
		{
			PVPBattlePrepareUIController pvpbattlePrepareUIController = (PVPBattlePrepareUIController)LuaObject.checkSelf(l);
			TimeSpan prepareCountdown;
			LuaObject.checkValueType<TimeSpan>(l, 2, out prepareCountdown);
			pvpbattlePrepareUIController.SetPrepareCountdown(prepareCountdown);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020760 RID: 132960 RVA: 0x00AD1558 File Offset: 0x00ACF758
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			PVPBattlePrepareUIController pvpbattlePrepareUIController = (PVPBattlePrepareUIController)LuaObject.checkSelf(l);
			pvpbattlePrepareUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020761 RID: 132961 RVA: 0x00AD15AC File Offset: 0x00ACF7AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetFigureState(IntPtr l)
	{
		int result;
		try
		{
			PVPBattlePrepareUIController pvpbattlePrepareUIController = (PVPBattlePrepareUIController)LuaObject.checkSelf(l);
			int idx;
			LuaObject.checkType(l, 2, out idx);
			string stateName;
			LuaObject.checkType(l, 3, out stateName);
			pvpbattlePrepareUIController.m_luaExportHelper.SetFigureState(idx, stateName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020762 RID: 132962 RVA: 0x00AD1618 File Offset: 0x00ACF818
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnPrepareConfirmButtonClick(IntPtr l)
	{
		int result;
		try
		{
			PVPBattlePrepareUIController pvpbattlePrepareUIController = (PVPBattlePrepareUIController)LuaObject.checkSelf(l);
			pvpbattlePrepareUIController.m_luaExportHelper.OnPrepareConfirmButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020763 RID: 132963 RVA: 0x00AD166C File Offset: 0x00ACF86C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			PVPBattlePrepareUIController pvpbattlePrepareUIController = (PVPBattlePrepareUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			pvpbattlePrepareUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020764 RID: 132964 RVA: 0x00AD16D8 File Offset: 0x00ACF8D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			PVPBattlePrepareUIController pvpbattlePrepareUIController = (PVPBattlePrepareUIController)LuaObject.checkSelf(l);
			pvpbattlePrepareUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020765 RID: 132965 RVA: 0x00AD172C File Offset: 0x00ACF92C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			PVPBattlePrepareUIController pvpbattlePrepareUIController = (PVPBattlePrepareUIController)LuaObject.checkSelf(l);
			pvpbattlePrepareUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020766 RID: 132966 RVA: 0x00AD1780 File Offset: 0x00ACF980
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			PVPBattlePrepareUIController pvpbattlePrepareUIController = (PVPBattlePrepareUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = pvpbattlePrepareUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x06020767 RID: 132967 RVA: 0x00AD1828 File Offset: 0x00ACFA28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			PVPBattlePrepareUIController pvpbattlePrepareUIController = (PVPBattlePrepareUIController)LuaObject.checkSelf(l);
			pvpbattlePrepareUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020768 RID: 132968 RVA: 0x00AD187C File Offset: 0x00ACFA7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			PVPBattlePrepareUIController pvpbattlePrepareUIController = (PVPBattlePrepareUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			pvpbattlePrepareUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020769 RID: 132969 RVA: 0x00AD18E8 File Offset: 0x00ACFAE8
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
				PVPBattlePrepareUIController pvpbattlePrepareUIController = (PVPBattlePrepareUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				pvpbattlePrepareUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				PVPBattlePrepareUIController pvpbattlePrepareUIController2 = (PVPBattlePrepareUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				pvpbattlePrepareUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0602076A RID: 132970 RVA: 0x00AD19F8 File Offset: 0x00ACFBF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			PVPBattlePrepareUIController pvpbattlePrepareUIController = (PVPBattlePrepareUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			pvpbattlePrepareUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602076B RID: 132971 RVA: 0x00AD1A64 File Offset: 0x00ACFC64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			PVPBattlePrepareUIController pvpbattlePrepareUIController = (PVPBattlePrepareUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			pvpbattlePrepareUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602076C RID: 132972 RVA: 0x00AD1AD0 File Offset: 0x00ACFCD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			PVPBattlePrepareUIController pvpbattlePrepareUIController = (PVPBattlePrepareUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			pvpbattlePrepareUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602076D RID: 132973 RVA: 0x00AD1B3C File Offset: 0x00ACFD3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			PVPBattlePrepareUIController pvpbattlePrepareUIController = (PVPBattlePrepareUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			pvpbattlePrepareUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602076E RID: 132974 RVA: 0x00AD1BA8 File Offset: 0x00ACFDA8
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
				PVPBattlePrepareUIController pvpbattlePrepareUIController = (PVPBattlePrepareUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				pvpbattlePrepareUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				PVPBattlePrepareUIController pvpbattlePrepareUIController2 = (PVPBattlePrepareUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				pvpbattlePrepareUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0602076F RID: 132975 RVA: 0x00AD1CB8 File Offset: 0x00ACFEB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			PVPBattlePrepareUIController pvpbattlePrepareUIController = (PVPBattlePrepareUIController)LuaObject.checkSelf(l);
			string s = pvpbattlePrepareUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x06020770 RID: 132976 RVA: 0x00AD1D14 File Offset: 0x00ACFF14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnPrepareConfirm(IntPtr l)
	{
		int result;
		try
		{
			PVPBattlePrepareUIController pvpbattlePrepareUIController = (PVPBattlePrepareUIController)LuaObject.checkSelf(l);
			pvpbattlePrepareUIController.m_luaExportHelper.__callDele_EventOnPrepareConfirm();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020771 RID: 132977 RVA: 0x00AD1D68 File Offset: 0x00ACFF68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnPrepareConfirm(IntPtr l)
	{
		int result;
		try
		{
			PVPBattlePrepareUIController pvpbattlePrepareUIController = (PVPBattlePrepareUIController)LuaObject.checkSelf(l);
			pvpbattlePrepareUIController.m_luaExportHelper.__clearDele_EventOnPrepareConfirm();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020772 RID: 132978 RVA: 0x00AD1DBC File Offset: 0x00ACFFBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnPrepareConfirm(IntPtr l)
	{
		int result;
		try
		{
			PVPBattlePrepareUIController pvpbattlePrepareUIController = (PVPBattlePrepareUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					pvpbattlePrepareUIController.EventOnPrepareConfirm += value;
				}
				else if (num == 2)
				{
					pvpbattlePrepareUIController.EventOnPrepareConfirm -= value;
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

	// Token: 0x06020773 RID: 132979 RVA: 0x00AD1E3C File Offset: 0x00AD003C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_orderUIStateController(IntPtr l)
	{
		int result;
		try
		{
			PVPBattlePrepareUIController pvpbattlePrepareUIController = (PVPBattlePrepareUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, pvpbattlePrepareUIController.m_luaExportHelper.m_orderUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020774 RID: 132980 RVA: 0x00AD1E94 File Offset: 0x00AD0094
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_orderUIStateController(IntPtr l)
	{
		int result;
		try
		{
			PVPBattlePrepareUIController pvpbattlePrepareUIController = (PVPBattlePrepareUIController)LuaObject.checkSelf(l);
			CommonUIStateController orderUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out orderUIStateController);
			pvpbattlePrepareUIController.m_luaExportHelper.m_orderUIStateController = orderUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020775 RID: 132981 RVA: 0x00AD1EF0 File Offset: 0x00AD00F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_orderFirstGameObject(IntPtr l)
	{
		int result;
		try
		{
			PVPBattlePrepareUIController pvpbattlePrepareUIController = (PVPBattlePrepareUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, pvpbattlePrepareUIController.m_luaExportHelper.m_orderFirstGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020776 RID: 132982 RVA: 0x00AD1F48 File Offset: 0x00AD0148
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_orderFirstGameObject(IntPtr l)
	{
		int result;
		try
		{
			PVPBattlePrepareUIController pvpbattlePrepareUIController = (PVPBattlePrepareUIController)LuaObject.checkSelf(l);
			GameObject orderFirstGameObject;
			LuaObject.checkType<GameObject>(l, 2, out orderFirstGameObject);
			pvpbattlePrepareUIController.m_luaExportHelper.m_orderFirstGameObject = orderFirstGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020777 RID: 132983 RVA: 0x00AD1FA4 File Offset: 0x00AD01A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_orderAfterGameObject(IntPtr l)
	{
		int result;
		try
		{
			PVPBattlePrepareUIController pvpbattlePrepareUIController = (PVPBattlePrepareUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, pvpbattlePrepareUIController.m_luaExportHelper.m_orderAfterGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020778 RID: 132984 RVA: 0x00AD1FFC File Offset: 0x00AD01FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_orderAfterGameObject(IntPtr l)
	{
		int result;
		try
		{
			PVPBattlePrepareUIController pvpbattlePrepareUIController = (PVPBattlePrepareUIController)LuaObject.checkSelf(l);
			GameObject orderAfterGameObject;
			LuaObject.checkType<GameObject>(l, 2, out orderAfterGameObject);
			pvpbattlePrepareUIController.m_luaExportHelper.m_orderAfterGameObject = orderAfterGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020779 RID: 132985 RVA: 0x00AD2058 File Offset: 0x00AD0258
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_prepareStateGameObject(IntPtr l)
	{
		int result;
		try
		{
			PVPBattlePrepareUIController pvpbattlePrepareUIController = (PVPBattlePrepareUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, pvpbattlePrepareUIController.m_luaExportHelper.m_prepareStateGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602077A RID: 132986 RVA: 0x00AD20B0 File Offset: 0x00AD02B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_prepareStateGameObject(IntPtr l)
	{
		int result;
		try
		{
			PVPBattlePrepareUIController pvpbattlePrepareUIController = (PVPBattlePrepareUIController)LuaObject.checkSelf(l);
			GameObject prepareStateGameObject;
			LuaObject.checkType<GameObject>(l, 2, out prepareStateGameObject);
			pvpbattlePrepareUIController.m_luaExportHelper.m_prepareStateGameObject = prepareStateGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602077B RID: 132987 RVA: 0x00AD210C File Offset: 0x00AD030C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_prepareMyTimeUIStateController(IntPtr l)
	{
		int result;
		try
		{
			PVPBattlePrepareUIController pvpbattlePrepareUIController = (PVPBattlePrepareUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, pvpbattlePrepareUIController.m_luaExportHelper.m_prepareMyTimeUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602077C RID: 132988 RVA: 0x00AD2164 File Offset: 0x00AD0364
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_prepareMyTimeUIStateController(IntPtr l)
	{
		int result;
		try
		{
			PVPBattlePrepareUIController pvpbattlePrepareUIController = (PVPBattlePrepareUIController)LuaObject.checkSelf(l);
			CommonUIStateController prepareMyTimeUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out prepareMyTimeUIStateController);
			pvpbattlePrepareUIController.m_luaExportHelper.m_prepareMyTimeUIStateController = prepareMyTimeUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602077D RID: 132989 RVA: 0x00AD21C0 File Offset: 0x00AD03C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_prepareMyTimeText(IntPtr l)
	{
		int result;
		try
		{
			PVPBattlePrepareUIController pvpbattlePrepareUIController = (PVPBattlePrepareUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, pvpbattlePrepareUIController.m_luaExportHelper.m_prepareMyTimeText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602077E RID: 132990 RVA: 0x00AD2218 File Offset: 0x00AD0418
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_prepareMyTimeText(IntPtr l)
	{
		int result;
		try
		{
			PVPBattlePrepareUIController pvpbattlePrepareUIController = (PVPBattlePrepareUIController)LuaObject.checkSelf(l);
			Text prepareMyTimeText;
			LuaObject.checkType<Text>(l, 2, out prepareMyTimeText);
			pvpbattlePrepareUIController.m_luaExportHelper.m_prepareMyTimeText = prepareMyTimeText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602077F RID: 132991 RVA: 0x00AD2274 File Offset: 0x00AD0474
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_prepareMyStateUIStateController(IntPtr l)
	{
		int result;
		try
		{
			PVPBattlePrepareUIController pvpbattlePrepareUIController = (PVPBattlePrepareUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, pvpbattlePrepareUIController.m_luaExportHelper.m_prepareMyStateUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020780 RID: 132992 RVA: 0x00AD22CC File Offset: 0x00AD04CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_prepareMyStateUIStateController(IntPtr l)
	{
		int result;
		try
		{
			PVPBattlePrepareUIController pvpbattlePrepareUIController = (PVPBattlePrepareUIController)LuaObject.checkSelf(l);
			CommonUIStateController prepareMyStateUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out prepareMyStateUIStateController);
			pvpbattlePrepareUIController.m_luaExportHelper.m_prepareMyStateUIStateController = prepareMyStateUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020781 RID: 132993 RVA: 0x00AD2328 File Offset: 0x00AD0528
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_prepareMyStateTextUIStateController(IntPtr l)
	{
		int result;
		try
		{
			PVPBattlePrepareUIController pvpbattlePrepareUIController = (PVPBattlePrepareUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, pvpbattlePrepareUIController.m_luaExportHelper.m_prepareMyStateTextUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020782 RID: 132994 RVA: 0x00AD2380 File Offset: 0x00AD0580
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_prepareMyStateTextUIStateController(IntPtr l)
	{
		int result;
		try
		{
			PVPBattlePrepareUIController pvpbattlePrepareUIController = (PVPBattlePrepareUIController)LuaObject.checkSelf(l);
			CommonUIStateController prepareMyStateTextUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out prepareMyStateTextUIStateController);
			pvpbattlePrepareUIController.m_luaExportHelper.m_prepareMyStateTextUIStateController = prepareMyStateTextUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020783 RID: 132995 RVA: 0x00AD23DC File Offset: 0x00AD05DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_prepareMyFigure1UIStateController(IntPtr l)
	{
		int result;
		try
		{
			PVPBattlePrepareUIController pvpbattlePrepareUIController = (PVPBattlePrepareUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, pvpbattlePrepareUIController.m_luaExportHelper.m_prepareMyFigure1UIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020784 RID: 132996 RVA: 0x00AD2434 File Offset: 0x00AD0634
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_prepareMyFigure1UIStateController(IntPtr l)
	{
		int result;
		try
		{
			PVPBattlePrepareUIController pvpbattlePrepareUIController = (PVPBattlePrepareUIController)LuaObject.checkSelf(l);
			CommonUIStateController prepareMyFigure1UIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out prepareMyFigure1UIStateController);
			pvpbattlePrepareUIController.m_luaExportHelper.m_prepareMyFigure1UIStateController = prepareMyFigure1UIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020785 RID: 132997 RVA: 0x00AD2490 File Offset: 0x00AD0690
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_prepareMyFigure2UIStateController(IntPtr l)
	{
		int result;
		try
		{
			PVPBattlePrepareUIController pvpbattlePrepareUIController = (PVPBattlePrepareUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, pvpbattlePrepareUIController.m_luaExportHelper.m_prepareMyFigure2UIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020786 RID: 132998 RVA: 0x00AD24E8 File Offset: 0x00AD06E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_prepareMyFigure2UIStateController(IntPtr l)
	{
		int result;
		try
		{
			PVPBattlePrepareUIController pvpbattlePrepareUIController = (PVPBattlePrepareUIController)LuaObject.checkSelf(l);
			CommonUIStateController prepareMyFigure2UIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out prepareMyFigure2UIStateController);
			pvpbattlePrepareUIController.m_luaExportHelper.m_prepareMyFigure2UIStateController = prepareMyFigure2UIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020787 RID: 132999 RVA: 0x00AD2544 File Offset: 0x00AD0744
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_prepareConfirmButton(IntPtr l)
	{
		int result;
		try
		{
			PVPBattlePrepareUIController pvpbattlePrepareUIController = (PVPBattlePrepareUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, pvpbattlePrepareUIController.m_luaExportHelper.m_prepareConfirmButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020788 RID: 133000 RVA: 0x00AD259C File Offset: 0x00AD079C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_prepareConfirmButton(IntPtr l)
	{
		int result;
		try
		{
			PVPBattlePrepareUIController pvpbattlePrepareUIController = (PVPBattlePrepareUIController)LuaObject.checkSelf(l);
			Button prepareConfirmButton;
			LuaObject.checkType<Button>(l, 2, out prepareConfirmButton);
			pvpbattlePrepareUIController.m_luaExportHelper.m_prepareConfirmButton = prepareConfirmButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020789 RID: 133001 RVA: 0x00AD25F8 File Offset: 0x00AD07F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_prepareConfirmButtonUIStateController(IntPtr l)
	{
		int result;
		try
		{
			PVPBattlePrepareUIController pvpbattlePrepareUIController = (PVPBattlePrepareUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, pvpbattlePrepareUIController.m_luaExportHelper.m_prepareConfirmButtonUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602078A RID: 133002 RVA: 0x00AD2650 File Offset: 0x00AD0850
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_prepareConfirmButtonUIStateController(IntPtr l)
	{
		int result;
		try
		{
			PVPBattlePrepareUIController pvpbattlePrepareUIController = (PVPBattlePrepareUIController)LuaObject.checkSelf(l);
			CommonUIStateController prepareConfirmButtonUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out prepareConfirmButtonUIStateController);
			pvpbattlePrepareUIController.m_luaExportHelper.m_prepareConfirmButtonUIStateController = prepareConfirmButtonUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602078B RID: 133003 RVA: 0x00AD26AC File Offset: 0x00AD08AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_prepareOpponentUIStateController(IntPtr l)
	{
		int result;
		try
		{
			PVPBattlePrepareUIController pvpbattlePrepareUIController = (PVPBattlePrepareUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, pvpbattlePrepareUIController.m_luaExportHelper.m_prepareOpponentUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602078C RID: 133004 RVA: 0x00AD2704 File Offset: 0x00AD0904
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_prepareOpponentUIStateController(IntPtr l)
	{
		int result;
		try
		{
			PVPBattlePrepareUIController pvpbattlePrepareUIController = (PVPBattlePrepareUIController)LuaObject.checkSelf(l);
			CommonUIStateController prepareOpponentUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out prepareOpponentUIStateController);
			pvpbattlePrepareUIController.m_luaExportHelper.m_prepareOpponentUIStateController = prepareOpponentUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602078D RID: 133005 RVA: 0x00AD2760 File Offset: 0x00AD0960
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_prepareOpponentTimeText(IntPtr l)
	{
		int result;
		try
		{
			PVPBattlePrepareUIController pvpbattlePrepareUIController = (PVPBattlePrepareUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, pvpbattlePrepareUIController.m_luaExportHelper.m_prepareOpponentTimeText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602078E RID: 133006 RVA: 0x00AD27B8 File Offset: 0x00AD09B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_prepareOpponentTimeText(IntPtr l)
	{
		int result;
		try
		{
			PVPBattlePrepareUIController pvpbattlePrepareUIController = (PVPBattlePrepareUIController)LuaObject.checkSelf(l);
			Text prepareOpponentTimeText;
			LuaObject.checkType<Text>(l, 2, out prepareOpponentTimeText);
			pvpbattlePrepareUIController.m_luaExportHelper.m_prepareOpponentTimeText = prepareOpponentTimeText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602078F RID: 133007 RVA: 0x00AD2814 File Offset: 0x00AD0A14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_protectBanGroupUIStateController(IntPtr l)
	{
		int result;
		try
		{
			PVPBattlePrepareUIController pvpbattlePrepareUIController = (PVPBattlePrepareUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, pvpbattlePrepareUIController.m_luaExportHelper.m_protectBanGroupUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020790 RID: 133008 RVA: 0x00AD286C File Offset: 0x00AD0A6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_protectBanGroupUIStateController(IntPtr l)
	{
		int result;
		try
		{
			PVPBattlePrepareUIController pvpbattlePrepareUIController = (PVPBattlePrepareUIController)LuaObject.checkSelf(l);
			CommonUIStateController protectBanGroupUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out protectBanGroupUIStateController);
			pvpbattlePrepareUIController.m_luaExportHelper.m_protectBanGroupUIStateController = protectBanGroupUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020791 RID: 133009 RVA: 0x00AD28C8 File Offset: 0x00AD0AC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_protectUIStateController(IntPtr l)
	{
		int result;
		try
		{
			PVPBattlePrepareUIController pvpbattlePrepareUIController = (PVPBattlePrepareUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, pvpbattlePrepareUIController.m_luaExportHelper.m_protectUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020792 RID: 133010 RVA: 0x00AD2920 File Offset: 0x00AD0B20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_protectUIStateController(IntPtr l)
	{
		int result;
		try
		{
			PVPBattlePrepareUIController pvpbattlePrepareUIController = (PVPBattlePrepareUIController)LuaObject.checkSelf(l);
			CommonUIStateController protectUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out protectUIStateController);
			pvpbattlePrepareUIController.m_luaExportHelper.m_protectUIStateController = protectUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020793 RID: 133011 RVA: 0x00AD297C File Offset: 0x00AD0B7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_banUIStateController(IntPtr l)
	{
		int result;
		try
		{
			PVPBattlePrepareUIController pvpbattlePrepareUIController = (PVPBattlePrepareUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, pvpbattlePrepareUIController.m_luaExportHelper.m_banUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020794 RID: 133012 RVA: 0x00AD29D4 File Offset: 0x00AD0BD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_banUIStateController(IntPtr l)
	{
		int result;
		try
		{
			PVPBattlePrepareUIController pvpbattlePrepareUIController = (PVPBattlePrepareUIController)LuaObject.checkSelf(l);
			CommonUIStateController banUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out banUIStateController);
			pvpbattlePrepareUIController.m_luaExportHelper.m_banUIStateController = banUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020795 RID: 133013 RVA: 0x00AD2A30 File Offset: 0x00AD0C30
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.PVPBattlePrepareUIController");
		if (Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.ShowOrder);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.ShowPrepareState);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.ShowPickMyHero);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.ShowWaitOpponent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.ShowProtectIndicator);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.ShowBanIndicator);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.ShowPrepareCompleteCountdown);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.SetPickHeroCount);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.SetProtectHeroCount);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.SetBanHeroCount);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.SetPrepareConfirmButtonState);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.SetPrepareCountdown);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.SetFigureState);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.OnPrepareConfirmButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.__callDele_EventOnPrepareConfirm);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.__clearDele_EventOnPrepareConfirm);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache1D);
		string name = "EventOnPrepareConfirm";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.set_EventOnPrepareConfirm);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache1E, true);
		string name2 = "m_orderUIStateController";
		if (Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.get_m_orderUIStateController);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache1F;
		if (Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.set_m_orderUIStateController);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache20, true);
		string name3 = "m_orderFirstGameObject";
		if (Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.get_m_orderFirstGameObject);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache21;
		if (Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.set_m_orderFirstGameObject);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache22, true);
		string name4 = "m_orderAfterGameObject";
		if (Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.get_m_orderAfterGameObject);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache23;
		if (Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.set_m_orderAfterGameObject);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache24, true);
		string name5 = "m_prepareStateGameObject";
		if (Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.get_m_prepareStateGameObject);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache25;
		if (Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.set_m_prepareStateGameObject);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache26, true);
		string name6 = "m_prepareMyTimeUIStateController";
		if (Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.get_m_prepareMyTimeUIStateController);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache27;
		if (Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.set_m_prepareMyTimeUIStateController);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache28, true);
		string name7 = "m_prepareMyTimeText";
		if (Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.get_m_prepareMyTimeText);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache29;
		if (Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.set_m_prepareMyTimeText);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache2A, true);
		string name8 = "m_prepareMyStateUIStateController";
		if (Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.get_m_prepareMyStateUIStateController);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache2B;
		if (Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.set_m_prepareMyStateUIStateController);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache2C, true);
		string name9 = "m_prepareMyStateTextUIStateController";
		if (Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.get_m_prepareMyStateTextUIStateController);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache2D;
		if (Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.set_m_prepareMyStateTextUIStateController);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache2E, true);
		string name10 = "m_prepareMyFigure1UIStateController";
		if (Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.get_m_prepareMyFigure1UIStateController);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache2F;
		if (Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.set_m_prepareMyFigure1UIStateController);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache30, true);
		string name11 = "m_prepareMyFigure2UIStateController";
		if (Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.get_m_prepareMyFigure2UIStateController);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache31;
		if (Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.set_m_prepareMyFigure2UIStateController);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache32, true);
		string name12 = "m_prepareConfirmButton";
		if (Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.get_m_prepareConfirmButton);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache33;
		if (Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.set_m_prepareConfirmButton);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache34, true);
		string name13 = "m_prepareConfirmButtonUIStateController";
		if (Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.get_m_prepareConfirmButtonUIStateController);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache35;
		if (Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.set_m_prepareConfirmButtonUIStateController);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache36, true);
		string name14 = "m_prepareOpponentUIStateController";
		if (Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.get_m_prepareOpponentUIStateController);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache37;
		if (Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.set_m_prepareOpponentUIStateController);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache38, true);
		string name15 = "m_prepareOpponentTimeText";
		if (Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.get_m_prepareOpponentTimeText);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache39;
		if (Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.set_m_prepareOpponentTimeText);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache3A, true);
		string name16 = "m_protectBanGroupUIStateController";
		if (Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.get_m_protectBanGroupUIStateController);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache3B;
		if (Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.set_m_protectBanGroupUIStateController);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache3C, true);
		string name17 = "m_protectUIStateController";
		if (Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.get_m_protectUIStateController);
		}
		LuaCSFunction get17 = Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache3D;
		if (Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.set_m_protectUIStateController);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache3E, true);
		string name18 = "m_banUIStateController";
		if (Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.get_m_banUIStateController);
		}
		LuaCSFunction get18 = Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache3F;
		if (Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.set_m_banUIStateController);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.<>f__mg$cache40, true);
		LuaObject.createTypeMetatable(l, null, typeof(PVPBattlePrepareUIController), typeof(UIControllerBase));
	}

	// Token: 0x040166BA RID: 91834
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040166BB RID: 91835
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040166BC RID: 91836
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040166BD RID: 91837
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040166BE RID: 91838
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040166BF RID: 91839
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040166C0 RID: 91840
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040166C1 RID: 91841
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x040166C2 RID: 91842
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x040166C3 RID: 91843
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x040166C4 RID: 91844
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x040166C5 RID: 91845
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x040166C6 RID: 91846
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x040166C7 RID: 91847
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x040166C8 RID: 91848
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x040166C9 RID: 91849
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x040166CA RID: 91850
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x040166CB RID: 91851
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x040166CC RID: 91852
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x040166CD RID: 91853
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x040166CE RID: 91854
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x040166CF RID: 91855
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x040166D0 RID: 91856
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x040166D1 RID: 91857
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x040166D2 RID: 91858
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x040166D3 RID: 91859
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x040166D4 RID: 91860
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x040166D5 RID: 91861
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x040166D6 RID: 91862
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x040166D7 RID: 91863
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x040166D8 RID: 91864
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x040166D9 RID: 91865
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x040166DA RID: 91866
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x040166DB RID: 91867
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x040166DC RID: 91868
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x040166DD RID: 91869
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x040166DE RID: 91870
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x040166DF RID: 91871
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x040166E0 RID: 91872
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x040166E1 RID: 91873
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x040166E2 RID: 91874
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x040166E3 RID: 91875
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x040166E4 RID: 91876
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x040166E5 RID: 91877
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x040166E6 RID: 91878
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x040166E7 RID: 91879
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x040166E8 RID: 91880
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x040166E9 RID: 91881
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x040166EA RID: 91882
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x040166EB RID: 91883
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x040166EC RID: 91884
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x040166ED RID: 91885
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x040166EE RID: 91886
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x040166EF RID: 91887
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x040166F0 RID: 91888
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x040166F1 RID: 91889
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x040166F2 RID: 91890
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x040166F3 RID: 91891
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x040166F4 RID: 91892
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x040166F5 RID: 91893
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x040166F6 RID: 91894
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x040166F7 RID: 91895
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x040166F8 RID: 91896
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x040166F9 RID: 91897
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x040166FA RID: 91898
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;
}
