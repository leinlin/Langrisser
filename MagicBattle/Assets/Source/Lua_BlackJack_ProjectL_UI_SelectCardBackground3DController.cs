using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x0200156E RID: 5486
[Preserve]
public class Lua_BlackJack_ProjectL_UI_SelectCardBackground3DController : LuaObject
{
	// Token: 0x06020E45 RID: 134725 RVA: 0x00B0876C File Offset: 0x00B0696C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowClockEffect(IntPtr l)
	{
		int result;
		try
		{
			SelectCardBackground3DController selectCardBackground3DController = (SelectCardBackground3DController)LuaObject.checkSelf(l);
			bool isShow;
			LuaObject.checkType(l, 2, out isShow);
			selectCardBackground3DController.ShowClockEffect(isShow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020E46 RID: 134726 RVA: 0x00B087C4 File Offset: 0x00B069C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowLightEffect(IntPtr l)
	{
		int result;
		try
		{
			SelectCardBackground3DController selectCardBackground3DController = (SelectCardBackground3DController)LuaObject.checkSelf(l);
			bool isShow;
			LuaObject.checkType(l, 2, out isShow);
			selectCardBackground3DController.ShowLightEffect(isShow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020E47 RID: 134727 RVA: 0x00B0881C File Offset: 0x00B06A1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowGetEffect(IntPtr l)
	{
		int result;
		try
		{
			SelectCardBackground3DController selectCardBackground3DController = (SelectCardBackground3DController)LuaObject.checkSelf(l);
			bool isShow;
			LuaObject.checkType(l, 2, out isShow);
			int rank;
			LuaObject.checkType(l, 3, out rank);
			selectCardBackground3DController.ShowGetEffect(isShow, rank);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020E48 RID: 134728 RVA: 0x00B08880 File Offset: 0x00B06A80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnClockDrag(IntPtr l)
	{
		int result;
		try
		{
			SelectCardBackground3DController selectCardBackground3DController = (SelectCardBackground3DController)LuaObject.checkSelf(l);
			int rank;
			LuaObject.checkType(l, 2, out rank);
			Action finishedEvent;
			LuaObject.checkDelegate<Action>(l, 3, out finishedEvent);
			selectCardBackground3DController.OnClockDrag(rank, finishedEvent);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020E49 RID: 134729 RVA: 0x00B088E4 File Offset: 0x00B06AE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			SelectCardBackground3DController selectCardBackground3DController = (SelectCardBackground3DController)LuaObject.checkSelf(l);
			selectCardBackground3DController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020E4A RID: 134730 RVA: 0x00B08938 File Offset: 0x00B06B38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			SelectCardBackground3DController selectCardBackground3DController = (SelectCardBackground3DController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			selectCardBackground3DController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020E4B RID: 134731 RVA: 0x00B089A4 File Offset: 0x00B06BA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			SelectCardBackground3DController selectCardBackground3DController = (SelectCardBackground3DController)LuaObject.checkSelf(l);
			selectCardBackground3DController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020E4C RID: 134732 RVA: 0x00B089F8 File Offset: 0x00B06BF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			SelectCardBackground3DController selectCardBackground3DController = (SelectCardBackground3DController)LuaObject.checkSelf(l);
			selectCardBackground3DController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020E4D RID: 134733 RVA: 0x00B08A4C File Offset: 0x00B06C4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			SelectCardBackground3DController selectCardBackground3DController = (SelectCardBackground3DController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = selectCardBackground3DController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x06020E4E RID: 134734 RVA: 0x00B08AF4 File Offset: 0x00B06CF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			SelectCardBackground3DController selectCardBackground3DController = (SelectCardBackground3DController)LuaObject.checkSelf(l);
			selectCardBackground3DController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020E4F RID: 134735 RVA: 0x00B08B48 File Offset: 0x00B06D48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			SelectCardBackground3DController selectCardBackground3DController = (SelectCardBackground3DController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			selectCardBackground3DController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020E50 RID: 134736 RVA: 0x00B08BB4 File Offset: 0x00B06DB4
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
				SelectCardBackground3DController selectCardBackground3DController = (SelectCardBackground3DController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				selectCardBackground3DController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				SelectCardBackground3DController selectCardBackground3DController2 = (SelectCardBackground3DController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				selectCardBackground3DController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x06020E51 RID: 134737 RVA: 0x00B08CC4 File Offset: 0x00B06EC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			SelectCardBackground3DController selectCardBackground3DController = (SelectCardBackground3DController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			selectCardBackground3DController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020E52 RID: 134738 RVA: 0x00B08D30 File Offset: 0x00B06F30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			SelectCardBackground3DController selectCardBackground3DController = (SelectCardBackground3DController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			selectCardBackground3DController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020E53 RID: 134739 RVA: 0x00B08D9C File Offset: 0x00B06F9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			SelectCardBackground3DController selectCardBackground3DController = (SelectCardBackground3DController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			selectCardBackground3DController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020E54 RID: 134740 RVA: 0x00B08E08 File Offset: 0x00B07008
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			SelectCardBackground3DController selectCardBackground3DController = (SelectCardBackground3DController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			selectCardBackground3DController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020E55 RID: 134741 RVA: 0x00B08E74 File Offset: 0x00B07074
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
				SelectCardBackground3DController selectCardBackground3DController = (SelectCardBackground3DController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				selectCardBackground3DController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				SelectCardBackground3DController selectCardBackground3DController2 = (SelectCardBackground3DController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				selectCardBackground3DController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x06020E56 RID: 134742 RVA: 0x00B08F84 File Offset: 0x00B07184
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			SelectCardBackground3DController selectCardBackground3DController = (SelectCardBackground3DController)LuaObject.checkSelf(l);
			string s = selectCardBackground3DController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x06020E57 RID: 134743 RVA: 0x00B08FE0 File Offset: 0x00B071E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_lightEffect(IntPtr l)
	{
		int result;
		try
		{
			SelectCardBackground3DController selectCardBackground3DController = (SelectCardBackground3DController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, selectCardBackground3DController.m_luaExportHelper.m_lightEffect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020E58 RID: 134744 RVA: 0x00B09038 File Offset: 0x00B07238
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_lightEffect(IntPtr l)
	{
		int result;
		try
		{
			SelectCardBackground3DController selectCardBackground3DController = (SelectCardBackground3DController)LuaObject.checkSelf(l);
			GameObject lightEffect;
			LuaObject.checkType<GameObject>(l, 2, out lightEffect);
			selectCardBackground3DController.m_luaExportHelper.m_lightEffect = lightEffect;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020E59 RID: 134745 RVA: 0x00B09094 File Offset: 0x00B07294
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_clockEffect(IntPtr l)
	{
		int result;
		try
		{
			SelectCardBackground3DController selectCardBackground3DController = (SelectCardBackground3DController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, selectCardBackground3DController.m_luaExportHelper.m_clockEffect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020E5A RID: 134746 RVA: 0x00B090EC File Offset: 0x00B072EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_clockEffect(IntPtr l)
	{
		int result;
		try
		{
			SelectCardBackground3DController selectCardBackground3DController = (SelectCardBackground3DController)LuaObject.checkSelf(l);
			GameObject clockEffect;
			LuaObject.checkType<GameObject>(l, 2, out clockEffect);
			selectCardBackground3DController.m_luaExportHelper.m_clockEffect = clockEffect;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020E5B RID: 134747 RVA: 0x00B09148 File Offset: 0x00B07348
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_clockEffectStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			SelectCardBackground3DController selectCardBackground3DController = (SelectCardBackground3DController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, selectCardBackground3DController.m_luaExportHelper.m_clockEffectStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020E5C RID: 134748 RVA: 0x00B091A0 File Offset: 0x00B073A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_clockEffectStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			SelectCardBackground3DController selectCardBackground3DController = (SelectCardBackground3DController)LuaObject.checkSelf(l);
			CommonUIStateController clockEffectStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out clockEffectStateCtrl);
			selectCardBackground3DController.m_luaExportHelper.m_clockEffectStateCtrl = clockEffectStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020E5D RID: 134749 RVA: 0x00B091FC File Offset: 0x00B073FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_getEffect(IntPtr l)
	{
		int result;
		try
		{
			SelectCardBackground3DController selectCardBackground3DController = (SelectCardBackground3DController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, selectCardBackground3DController.m_luaExportHelper.m_getEffect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020E5E RID: 134750 RVA: 0x00B09254 File Offset: 0x00B07454
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_getEffect(IntPtr l)
	{
		int result;
		try
		{
			SelectCardBackground3DController selectCardBackground3DController = (SelectCardBackground3DController)LuaObject.checkSelf(l);
			GameObject getEffect;
			LuaObject.checkType<GameObject>(l, 2, out getEffect);
			selectCardBackground3DController.m_luaExportHelper.m_getEffect = getEffect;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020E5F RID: 134751 RVA: 0x00B092B0 File Offset: 0x00B074B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_getEffectSR(IntPtr l)
	{
		int result;
		try
		{
			SelectCardBackground3DController selectCardBackground3DController = (SelectCardBackground3DController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, selectCardBackground3DController.m_luaExportHelper.m_getEffectSR);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020E60 RID: 134752 RVA: 0x00B09308 File Offset: 0x00B07508
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_getEffectSR(IntPtr l)
	{
		int result;
		try
		{
			SelectCardBackground3DController selectCardBackground3DController = (SelectCardBackground3DController)LuaObject.checkSelf(l);
			GameObject getEffectSR;
			LuaObject.checkType<GameObject>(l, 2, out getEffectSR);
			selectCardBackground3DController.m_luaExportHelper.m_getEffectSR = getEffectSR;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020E61 RID: 134753 RVA: 0x00B09364 File Offset: 0x00B07564
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_getEffectSSR(IntPtr l)
	{
		int result;
		try
		{
			SelectCardBackground3DController selectCardBackground3DController = (SelectCardBackground3DController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, selectCardBackground3DController.m_luaExportHelper.m_getEffectSSR);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020E62 RID: 134754 RVA: 0x00B093BC File Offset: 0x00B075BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_getEffectSSR(IntPtr l)
	{
		int result;
		try
		{
			SelectCardBackground3DController selectCardBackground3DController = (SelectCardBackground3DController)LuaObject.checkSelf(l);
			GameObject getEffectSSR;
			LuaObject.checkType<GameObject>(l, 2, out getEffectSSR);
			selectCardBackground3DController.m_luaExportHelper.m_getEffectSSR = getEffectSSR;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020E63 RID: 134755 RVA: 0x00B09418 File Offset: 0x00B07618
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.SelectCardBackground3DController");
		if (Lua_BlackJack_ProjectL_UI_SelectCardBackground3DController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardBackground3DController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardBackground3DController.ShowClockEffect);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectCardBackground3DController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_SelectCardBackground3DController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardBackground3DController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardBackground3DController.ShowLightEffect);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectCardBackground3DController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_SelectCardBackground3DController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardBackground3DController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardBackground3DController.ShowGetEffect);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectCardBackground3DController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_SelectCardBackground3DController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardBackground3DController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardBackground3DController.OnClockDrag);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectCardBackground3DController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_SelectCardBackground3DController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardBackground3DController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardBackground3DController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectCardBackground3DController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_SelectCardBackground3DController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardBackground3DController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardBackground3DController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectCardBackground3DController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_SelectCardBackground3DController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardBackground3DController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardBackground3DController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectCardBackground3DController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_SelectCardBackground3DController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardBackground3DController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardBackground3DController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectCardBackground3DController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_SelectCardBackground3DController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardBackground3DController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardBackground3DController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectCardBackground3DController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_SelectCardBackground3DController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardBackground3DController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardBackground3DController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectCardBackground3DController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_SelectCardBackground3DController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardBackground3DController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardBackground3DController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectCardBackground3DController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_SelectCardBackground3DController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardBackground3DController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardBackground3DController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectCardBackground3DController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_SelectCardBackground3DController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardBackground3DController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardBackground3DController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectCardBackground3DController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_SelectCardBackground3DController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardBackground3DController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardBackground3DController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectCardBackground3DController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_SelectCardBackground3DController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardBackground3DController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardBackground3DController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectCardBackground3DController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_SelectCardBackground3DController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardBackground3DController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardBackground3DController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectCardBackground3DController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_SelectCardBackground3DController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardBackground3DController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardBackground3DController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectCardBackground3DController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_SelectCardBackground3DController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardBackground3DController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardBackground3DController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectCardBackground3DController.<>f__mg$cache11);
		string name = "m_lightEffect";
		if (Lua_BlackJack_ProjectL_UI_SelectCardBackground3DController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardBackground3DController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardBackground3DController.get_m_lightEffect);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_SelectCardBackground3DController.<>f__mg$cache12;
		if (Lua_BlackJack_ProjectL_UI_SelectCardBackground3DController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardBackground3DController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardBackground3DController.set_m_lightEffect);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_SelectCardBackground3DController.<>f__mg$cache13, true);
		string name2 = "m_clockEffect";
		if (Lua_BlackJack_ProjectL_UI_SelectCardBackground3DController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardBackground3DController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardBackground3DController.get_m_clockEffect);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_SelectCardBackground3DController.<>f__mg$cache14;
		if (Lua_BlackJack_ProjectL_UI_SelectCardBackground3DController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardBackground3DController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardBackground3DController.set_m_clockEffect);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_SelectCardBackground3DController.<>f__mg$cache15, true);
		string name3 = "m_clockEffectStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_SelectCardBackground3DController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardBackground3DController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardBackground3DController.get_m_clockEffectStateCtrl);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_SelectCardBackground3DController.<>f__mg$cache16;
		if (Lua_BlackJack_ProjectL_UI_SelectCardBackground3DController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardBackground3DController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardBackground3DController.set_m_clockEffectStateCtrl);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_SelectCardBackground3DController.<>f__mg$cache17, true);
		string name4 = "m_getEffect";
		if (Lua_BlackJack_ProjectL_UI_SelectCardBackground3DController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardBackground3DController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardBackground3DController.get_m_getEffect);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_SelectCardBackground3DController.<>f__mg$cache18;
		if (Lua_BlackJack_ProjectL_UI_SelectCardBackground3DController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardBackground3DController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardBackground3DController.set_m_getEffect);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_SelectCardBackground3DController.<>f__mg$cache19, true);
		string name5 = "m_getEffectSR";
		if (Lua_BlackJack_ProjectL_UI_SelectCardBackground3DController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardBackground3DController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardBackground3DController.get_m_getEffectSR);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_SelectCardBackground3DController.<>f__mg$cache1A;
		if (Lua_BlackJack_ProjectL_UI_SelectCardBackground3DController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardBackground3DController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardBackground3DController.set_m_getEffectSR);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_SelectCardBackground3DController.<>f__mg$cache1B, true);
		string name6 = "m_getEffectSSR";
		if (Lua_BlackJack_ProjectL_UI_SelectCardBackground3DController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardBackground3DController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardBackground3DController.get_m_getEffectSSR);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_SelectCardBackground3DController.<>f__mg$cache1C;
		if (Lua_BlackJack_ProjectL_UI_SelectCardBackground3DController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectCardBackground3DController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectCardBackground3DController.set_m_getEffectSSR);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_SelectCardBackground3DController.<>f__mg$cache1D, true);
		LuaObject.createTypeMetatable(l, null, typeof(SelectCardBackground3DController), typeof(UIControllerBase));
	}

	// Token: 0x04016D4B RID: 93515
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04016D4C RID: 93516
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04016D4D RID: 93517
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04016D4E RID: 93518
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04016D4F RID: 93519
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04016D50 RID: 93520
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04016D51 RID: 93521
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04016D52 RID: 93522
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04016D53 RID: 93523
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04016D54 RID: 93524
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04016D55 RID: 93525
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04016D56 RID: 93526
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04016D57 RID: 93527
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04016D58 RID: 93528
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04016D59 RID: 93529
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04016D5A RID: 93530
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04016D5B RID: 93531
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04016D5C RID: 93532
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04016D5D RID: 93533
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04016D5E RID: 93534
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04016D5F RID: 93535
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04016D60 RID: 93536
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04016D61 RID: 93537
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04016D62 RID: 93538
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04016D63 RID: 93539
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04016D64 RID: 93540
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04016D65 RID: 93541
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04016D66 RID: 93542
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04016D67 RID: 93543
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04016D68 RID: 93544
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;
}
