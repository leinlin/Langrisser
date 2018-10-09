using System;
using System.Collections;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x0200153F RID: 5439
[Preserve]
public class Lua_BlackJack_ProjectL_UI_Raffle3DUIController : LuaObject
{
	// Token: 0x06020797 RID: 133015 RVA: 0x00AD3358 File Offset: 0x00AD1558
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Clear(IntPtr l)
	{
		int result;
		try
		{
			Raffle3DUIController raffle3DUIController = (Raffle3DUIController)LuaObject.checkSelf(l);
			raffle3DUIController.Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020798 RID: 133016 RVA: 0x00AD33A4 File Offset: 0x00AD15A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowRaffle3DModel(IntPtr l)
	{
		int result;
		try
		{
			Raffle3DUIController raffle3DUIController = (Raffle3DUIController)LuaObject.checkSelf(l);
			bool isShow;
			LuaObject.checkType(l, 2, out isShow);
			raffle3DUIController.ShowRaffle3DModel(isShow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020799 RID: 133017 RVA: 0x00AD33FC File Offset: 0x00AD15FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowDrawIdleAnimation(IntPtr l)
	{
		int result;
		try
		{
			Raffle3DUIController raffle3DUIController = (Raffle3DUIController)LuaObject.checkSelf(l);
			raffle3DUIController.ShowDrawIdleAnimation();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602079A RID: 133018 RVA: 0x00AD3448 File Offset: 0x00AD1648
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowRaffeDrawingAnimation(IntPtr l)
	{
		int result;
		try
		{
			Raffle3DUIController raffle3DUIController = (Raffle3DUIController)LuaObject.checkSelf(l);
			int level;
			LuaObject.checkType(l, 2, out level);
			Action onEnd;
			LuaObject.checkDelegate<Action>(l, 3, out onEnd);
			raffle3DUIController.ShowRaffeDrawingAnimation(level, onEnd);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602079B RID: 133019 RVA: 0x00AD34AC File Offset: 0x00AD16AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			Raffle3DUIController raffle3DUIController = (Raffle3DUIController)LuaObject.checkSelf(l);
			raffle3DUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602079C RID: 133020 RVA: 0x00AD3500 File Offset: 0x00AD1700
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetAniNameByLevel(IntPtr l)
	{
		int result;
		try
		{
			Raffle3DUIController raffle3DUIController = (Raffle3DUIController)LuaObject.checkSelf(l);
			int level;
			LuaObject.checkType(l, 2, out level);
			string aniNameByLevel = raffle3DUIController.m_luaExportHelper.GetAniNameByLevel(level);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, aniNameByLevel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602079D RID: 133021 RVA: 0x00AD3568 File Offset: 0x00AD1768
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnDrawAnimationEnd(IntPtr l)
	{
		int result;
		try
		{
			Raffle3DUIController raffle3DUIController = (Raffle3DUIController)LuaObject.checkSelf(l);
			GameObject go;
			LuaObject.checkType<GameObject>(l, 2, out go);
			string aniName;
			LuaObject.checkType(l, 3, out aniName);
			raffle3DUIController.m_luaExportHelper.OnDrawAnimationEnd(go, aniName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602079E RID: 133022 RVA: 0x00AD35D4 File Offset: 0x00AD17D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnDrawAnimationEndImp(IntPtr l)
	{
		int result;
		try
		{
			Raffle3DUIController raffle3DUIController = (Raffle3DUIController)LuaObject.checkSelf(l);
			raffle3DUIController.m_luaExportHelper.OnDrawAnimationEndImp();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602079F RID: 133023 RVA: 0x00AD3628 File Offset: 0x00AD1828
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int WaitForTime(IntPtr l)
	{
		int result;
		try
		{
			Raffle3DUIController raffle3DUIController = (Raffle3DUIController)LuaObject.checkSelf(l);
			Action action;
			LuaObject.checkDelegate<Action>(l, 2, out action);
			float time;
			LuaObject.checkType(l, 3, out time);
			IEnumerator o = raffle3DUIController.m_luaExportHelper.WaitForTime(action, time);
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

	// Token: 0x060207A0 RID: 133024 RVA: 0x00AD369C File Offset: 0x00AD189C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int On3DBgButtonClick(IntPtr l)
	{
		int result;
		try
		{
			Raffle3DUIController raffle3DUIController = (Raffle3DUIController)LuaObject.checkSelf(l);
			raffle3DUIController.m_luaExportHelper.On3DBgButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060207A1 RID: 133025 RVA: 0x00AD36F0 File Offset: 0x00AD18F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CalcThreeDCameraViewRect(IntPtr l)
	{
		int result;
		try
		{
			Raffle3DUIController raffle3DUIController = (Raffle3DUIController)LuaObject.checkSelf(l);
			Rect rect = raffle3DUIController.m_luaExportHelper.CalcThreeDCameraViewRect();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060207A2 RID: 133026 RVA: 0x00AD3750 File Offset: 0x00AD1950
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			Raffle3DUIController raffle3DUIController = (Raffle3DUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			raffle3DUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060207A3 RID: 133027 RVA: 0x00AD37BC File Offset: 0x00AD19BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			Raffle3DUIController raffle3DUIController = (Raffle3DUIController)LuaObject.checkSelf(l);
			raffle3DUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060207A4 RID: 133028 RVA: 0x00AD3810 File Offset: 0x00AD1A10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			Raffle3DUIController raffle3DUIController = (Raffle3DUIController)LuaObject.checkSelf(l);
			raffle3DUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060207A5 RID: 133029 RVA: 0x00AD3864 File Offset: 0x00AD1A64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			Raffle3DUIController raffle3DUIController = (Raffle3DUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = raffle3DUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x060207A6 RID: 133030 RVA: 0x00AD390C File Offset: 0x00AD1B0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			Raffle3DUIController raffle3DUIController = (Raffle3DUIController)LuaObject.checkSelf(l);
			raffle3DUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060207A7 RID: 133031 RVA: 0x00AD3960 File Offset: 0x00AD1B60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			Raffle3DUIController raffle3DUIController = (Raffle3DUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			raffle3DUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060207A8 RID: 133032 RVA: 0x00AD39CC File Offset: 0x00AD1BCC
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
				Raffle3DUIController raffle3DUIController = (Raffle3DUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				raffle3DUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				Raffle3DUIController raffle3DUIController2 = (Raffle3DUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				raffle3DUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x060207A9 RID: 133033 RVA: 0x00AD3ADC File Offset: 0x00AD1CDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			Raffle3DUIController raffle3DUIController = (Raffle3DUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			raffle3DUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060207AA RID: 133034 RVA: 0x00AD3B48 File Offset: 0x00AD1D48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			Raffle3DUIController raffle3DUIController = (Raffle3DUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			raffle3DUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060207AB RID: 133035 RVA: 0x00AD3BB4 File Offset: 0x00AD1DB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			Raffle3DUIController raffle3DUIController = (Raffle3DUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			raffle3DUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060207AC RID: 133036 RVA: 0x00AD3C20 File Offset: 0x00AD1E20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			Raffle3DUIController raffle3DUIController = (Raffle3DUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			raffle3DUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060207AD RID: 133037 RVA: 0x00AD3C8C File Offset: 0x00AD1E8C
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
				Raffle3DUIController raffle3DUIController = (Raffle3DUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				raffle3DUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				Raffle3DUIController raffle3DUIController2 = (Raffle3DUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				raffle3DUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x060207AE RID: 133038 RVA: 0x00AD3D9C File Offset: 0x00AD1F9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			Raffle3DUIController raffle3DUIController = (Raffle3DUIController)LuaObject.checkSelf(l);
			string s = raffle3DUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x060207AF RID: 133039 RVA: 0x00AD3DF8 File Offset: 0x00AD1FF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_m_onAnimationEnd(IntPtr l)
	{
		int result;
		try
		{
			Raffle3DUIController raffle3DUIController = (Raffle3DUIController)LuaObject.checkSelf(l);
			raffle3DUIController.m_luaExportHelper.__callDele_m_onAnimationEnd();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060207B0 RID: 133040 RVA: 0x00AD3E4C File Offset: 0x00AD204C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_m_onAnimationEnd(IntPtr l)
	{
		int result;
		try
		{
			Raffle3DUIController raffle3DUIController = (Raffle3DUIController)LuaObject.checkSelf(l);
			raffle3DUIController.m_luaExportHelper.__clearDele_m_onAnimationEnd();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060207B1 RID: 133041 RVA: 0x00AD3EA0 File Offset: 0x00AD20A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_onAnimationEnd(IntPtr l)
	{
		int result;
		try
		{
			Raffle3DUIController raffle3DUIController = (Raffle3DUIController)LuaObject.checkSelf(l);
			Action action;
			int num = LuaObject.checkDelegate<Action>(l, 2, out action);
			if (num == 0)
			{
				raffle3DUIController.m_luaExportHelper.m_onAnimationEnd = action;
			}
			else if (num == 1)
			{
				Raffle3DUIController.LuaExportHelper luaExportHelper = raffle3DUIController.m_luaExportHelper;
				luaExportHelper.m_onAnimationEnd = (Action)Delegate.Combine(luaExportHelper.m_onAnimationEnd, action);
			}
			else if (num == 2)
			{
				Raffle3DUIController.LuaExportHelper luaExportHelper2 = raffle3DUIController.m_luaExportHelper;
				luaExportHelper2.m_onAnimationEnd = (Action)Delegate.Remove(luaExportHelper2.m_onAnimationEnd, action);
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

	// Token: 0x060207B2 RID: 133042 RVA: 0x00AD3F54 File Offset: 0x00AD2154
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_AniParam_Init(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Raffle3DUIController.LuaExportHelper.AniParam_Init);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060207B3 RID: 133043 RVA: 0x00AD3F9C File Offset: 0x00AD219C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_AniParam_Init(IntPtr l)
	{
		int result;
		try
		{
			string aniParam_Init;
			LuaObject.checkType(l, 2, out aniParam_Init);
			Raffle3DUIController.LuaExportHelper.AniParam_Init = aniParam_Init;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060207B4 RID: 133044 RVA: 0x00AD3FE8 File Offset: 0x00AD21E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_AniParam_Level0(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Raffle3DUIController.LuaExportHelper.AniParam_Level0);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060207B5 RID: 133045 RVA: 0x00AD4030 File Offset: 0x00AD2230
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_AniParam_Level0(IntPtr l)
	{
		int result;
		try
		{
			string aniParam_Level;
			LuaObject.checkType(l, 2, out aniParam_Level);
			Raffle3DUIController.LuaExportHelper.AniParam_Level0 = aniParam_Level;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060207B6 RID: 133046 RVA: 0x00AD407C File Offset: 0x00AD227C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_AniParam_Level1(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Raffle3DUIController.LuaExportHelper.AniParam_Level1);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060207B7 RID: 133047 RVA: 0x00AD40C4 File Offset: 0x00AD22C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_AniParam_Level1(IntPtr l)
	{
		int result;
		try
		{
			string aniParam_Level;
			LuaObject.checkType(l, 2, out aniParam_Level);
			Raffle3DUIController.LuaExportHelper.AniParam_Level1 = aniParam_Level;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060207B8 RID: 133048 RVA: 0x00AD4110 File Offset: 0x00AD2310
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_AniParam_Level2(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Raffle3DUIController.LuaExportHelper.AniParam_Level2);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060207B9 RID: 133049 RVA: 0x00AD4158 File Offset: 0x00AD2358
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_AniParam_Level2(IntPtr l)
	{
		int result;
		try
		{
			string aniParam_Level;
			LuaObject.checkType(l, 2, out aniParam_Level);
			Raffle3DUIController.LuaExportHelper.AniParam_Level2 = aniParam_Level;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060207BA RID: 133050 RVA: 0x00AD41A4 File Offset: 0x00AD23A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_AniParam_Level3(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Raffle3DUIController.LuaExportHelper.AniParam_Level3);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060207BB RID: 133051 RVA: 0x00AD41EC File Offset: 0x00AD23EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_AniParam_Level3(IntPtr l)
	{
		int result;
		try
		{
			string aniParam_Level;
			LuaObject.checkType(l, 2, out aniParam_Level);
			Raffle3DUIController.LuaExportHelper.AniParam_Level3 = aniParam_Level;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060207BC RID: 133052 RVA: 0x00AD4238 File Offset: 0x00AD2438
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ThreeDBgButton(IntPtr l)
	{
		int result;
		try
		{
			Raffle3DUIController raffle3DUIController = (Raffle3DUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, raffle3DUIController.ThreeDBgButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060207BD RID: 133053 RVA: 0x00AD428C File Offset: 0x00AD248C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ThreeDBgButton(IntPtr l)
	{
		int result;
		try
		{
			Raffle3DUIController raffle3DUIController = (Raffle3DUIController)LuaObject.checkSelf(l);
			Button threeDBgButton;
			LuaObject.checkType<Button>(l, 2, out threeDBgButton);
			raffle3DUIController.ThreeDBgButton = threeDBgButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060207BE RID: 133054 RVA: 0x00AD42E4 File Offset: 0x00AD24E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ThreeDViewImage(IntPtr l)
	{
		int result;
		try
		{
			Raffle3DUIController raffle3DUIController = (Raffle3DUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, raffle3DUIController.ThreeDViewImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060207BF RID: 133055 RVA: 0x00AD4338 File Offset: 0x00AD2538
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ThreeDViewImage(IntPtr l)
	{
		int result;
		try
		{
			Raffle3DUIController raffle3DUIController = (Raffle3DUIController)LuaObject.checkSelf(l);
			Image threeDViewImage;
			LuaObject.checkType<Image>(l, 2, out threeDViewImage);
			raffle3DUIController.ThreeDViewImage = threeDViewImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060207C0 RID: 133056 RVA: 0x00AD4390 File Offset: 0x00AD2590
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ThreeDViewCamera(IntPtr l)
	{
		int result;
		try
		{
			Raffle3DUIController raffle3DUIController = (Raffle3DUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, raffle3DUIController.ThreeDViewCamera);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060207C1 RID: 133057 RVA: 0x00AD43E4 File Offset: 0x00AD25E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ThreeDViewCamera(IntPtr l)
	{
		int result;
		try
		{
			Raffle3DUIController raffle3DUIController = (Raffle3DUIController)LuaObject.checkSelf(l);
			Camera threeDViewCamera;
			LuaObject.checkType<Camera>(l, 2, out threeDViewCamera);
			raffle3DUIController.ThreeDViewCamera = threeDViewCamera;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060207C2 RID: 133058 RVA: 0x00AD443C File Offset: 0x00AD263C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_UIEffectStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			Raffle3DUIController raffle3DUIController = (Raffle3DUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, raffle3DUIController.UIEffectStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060207C3 RID: 133059 RVA: 0x00AD4490 File Offset: 0x00AD2690
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_UIEffectStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			Raffle3DUIController raffle3DUIController = (Raffle3DUIController)LuaObject.checkSelf(l);
			CommonUIStateController uieffectStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out uieffectStateCtrl);
			raffle3DUIController.UIEffectStateCtrl = uieffectStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060207C4 RID: 133060 RVA: 0x00AD44E8 File Offset: 0x00AD26E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LayerCamera(IntPtr l)
	{
		int result;
		try
		{
			Raffle3DUIController raffle3DUIController = (Raffle3DUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, raffle3DUIController.LayerCamera);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060207C5 RID: 133061 RVA: 0x00AD453C File Offset: 0x00AD273C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_LayerCamera(IntPtr l)
	{
		int result;
		try
		{
			Raffle3DUIController raffle3DUIController = (Raffle3DUIController)LuaObject.checkSelf(l);
			Camera layerCamera;
			LuaObject.checkType<Camera>(l, 2, out layerCamera);
			raffle3DUIController.LayerCamera = layerCamera;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060207C6 RID: 133062 RVA: 0x00AD4594 File Offset: 0x00AD2794
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.Raffle3DUIController");
		if (Lua_BlackJack_ProjectL_UI_Raffle3DUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_Raffle3DUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_Raffle3DUIController.Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_Raffle3DUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_Raffle3DUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_Raffle3DUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_Raffle3DUIController.ShowRaffle3DModel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_Raffle3DUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_Raffle3DUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_Raffle3DUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_Raffle3DUIController.ShowDrawIdleAnimation);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_Raffle3DUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_Raffle3DUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_Raffle3DUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_Raffle3DUIController.ShowRaffeDrawingAnimation);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_Raffle3DUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_Raffle3DUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_Raffle3DUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_Raffle3DUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_Raffle3DUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_Raffle3DUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_Raffle3DUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_Raffle3DUIController.GetAniNameByLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_Raffle3DUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_Raffle3DUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_Raffle3DUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_Raffle3DUIController.OnDrawAnimationEnd);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_Raffle3DUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_Raffle3DUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_Raffle3DUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_Raffle3DUIController.OnDrawAnimationEndImp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_Raffle3DUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_Raffle3DUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_Raffle3DUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_Raffle3DUIController.WaitForTime);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_Raffle3DUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_Raffle3DUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_Raffle3DUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_Raffle3DUIController.On3DBgButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_Raffle3DUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_Raffle3DUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_Raffle3DUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_Raffle3DUIController.CalcThreeDCameraViewRect);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_Raffle3DUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_Raffle3DUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_Raffle3DUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_Raffle3DUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_Raffle3DUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_Raffle3DUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_Raffle3DUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_Raffle3DUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_Raffle3DUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_Raffle3DUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_Raffle3DUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_Raffle3DUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_Raffle3DUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_Raffle3DUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_Raffle3DUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_Raffle3DUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_Raffle3DUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_Raffle3DUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_Raffle3DUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_Raffle3DUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_Raffle3DUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_Raffle3DUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_Raffle3DUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_Raffle3DUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_Raffle3DUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_Raffle3DUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_Raffle3DUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_Raffle3DUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_Raffle3DUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_Raffle3DUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_Raffle3DUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_Raffle3DUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_Raffle3DUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_Raffle3DUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_Raffle3DUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_Raffle3DUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_Raffle3DUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_Raffle3DUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_Raffle3DUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_Raffle3DUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_Raffle3DUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_Raffle3DUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_Raffle3DUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_Raffle3DUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_Raffle3DUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_Raffle3DUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_Raffle3DUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_Raffle3DUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_Raffle3DUIController.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_Raffle3DUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_Raffle3DUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_Raffle3DUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_Raffle3DUIController.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_Raffle3DUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_Raffle3DUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_Raffle3DUIController.__callDele_m_onAnimationEnd);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_Raffle3DUIController.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_Raffle3DUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_Raffle3DUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_Raffle3DUIController.__clearDele_m_onAnimationEnd);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_Raffle3DUIController.<>f__mg$cache19);
		string name = "m_onAnimationEnd";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_Raffle3DUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_Raffle3DUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_Raffle3DUIController.set_m_onAnimationEnd);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_Raffle3DUIController.<>f__mg$cache1A, true);
		string name2 = "AniParam_Init";
		if (Lua_BlackJack_ProjectL_UI_Raffle3DUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_Raffle3DUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_Raffle3DUIController.get_AniParam_Init);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_Raffle3DUIController.<>f__mg$cache1B;
		if (Lua_BlackJack_ProjectL_UI_Raffle3DUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_Raffle3DUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_Raffle3DUIController.set_AniParam_Init);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_Raffle3DUIController.<>f__mg$cache1C, false);
		string name3 = "AniParam_Level0";
		if (Lua_BlackJack_ProjectL_UI_Raffle3DUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_Raffle3DUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_Raffle3DUIController.get_AniParam_Level0);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_Raffle3DUIController.<>f__mg$cache1D;
		if (Lua_BlackJack_ProjectL_UI_Raffle3DUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_Raffle3DUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_Raffle3DUIController.set_AniParam_Level0);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_Raffle3DUIController.<>f__mg$cache1E, false);
		string name4 = "AniParam_Level1";
		if (Lua_BlackJack_ProjectL_UI_Raffle3DUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_Raffle3DUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_Raffle3DUIController.get_AniParam_Level1);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_Raffle3DUIController.<>f__mg$cache1F;
		if (Lua_BlackJack_ProjectL_UI_Raffle3DUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_Raffle3DUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_Raffle3DUIController.set_AniParam_Level1);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_Raffle3DUIController.<>f__mg$cache20, false);
		string name5 = "AniParam_Level2";
		if (Lua_BlackJack_ProjectL_UI_Raffle3DUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_Raffle3DUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_Raffle3DUIController.get_AniParam_Level2);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_Raffle3DUIController.<>f__mg$cache21;
		if (Lua_BlackJack_ProjectL_UI_Raffle3DUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_Raffle3DUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_Raffle3DUIController.set_AniParam_Level2);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_Raffle3DUIController.<>f__mg$cache22, false);
		string name6 = "AniParam_Level3";
		if (Lua_BlackJack_ProjectL_UI_Raffle3DUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_Raffle3DUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_Raffle3DUIController.get_AniParam_Level3);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_Raffle3DUIController.<>f__mg$cache23;
		if (Lua_BlackJack_ProjectL_UI_Raffle3DUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_Raffle3DUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_Raffle3DUIController.set_AniParam_Level3);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_Raffle3DUIController.<>f__mg$cache24, false);
		string name7 = "ThreeDBgButton";
		if (Lua_BlackJack_ProjectL_UI_Raffle3DUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_Raffle3DUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_Raffle3DUIController.get_ThreeDBgButton);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_Raffle3DUIController.<>f__mg$cache25;
		if (Lua_BlackJack_ProjectL_UI_Raffle3DUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_Raffle3DUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_Raffle3DUIController.set_ThreeDBgButton);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_Raffle3DUIController.<>f__mg$cache26, true);
		string name8 = "ThreeDViewImage";
		if (Lua_BlackJack_ProjectL_UI_Raffle3DUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_Raffle3DUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_Raffle3DUIController.get_ThreeDViewImage);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_Raffle3DUIController.<>f__mg$cache27;
		if (Lua_BlackJack_ProjectL_UI_Raffle3DUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_Raffle3DUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_Raffle3DUIController.set_ThreeDViewImage);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_Raffle3DUIController.<>f__mg$cache28, true);
		string name9 = "ThreeDViewCamera";
		if (Lua_BlackJack_ProjectL_UI_Raffle3DUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_Raffle3DUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_Raffle3DUIController.get_ThreeDViewCamera);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_Raffle3DUIController.<>f__mg$cache29;
		if (Lua_BlackJack_ProjectL_UI_Raffle3DUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_Raffle3DUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_Raffle3DUIController.set_ThreeDViewCamera);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_Raffle3DUIController.<>f__mg$cache2A, true);
		string name10 = "UIEffectStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_Raffle3DUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_Raffle3DUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_Raffle3DUIController.get_UIEffectStateCtrl);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_Raffle3DUIController.<>f__mg$cache2B;
		if (Lua_BlackJack_ProjectL_UI_Raffle3DUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_Raffle3DUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_Raffle3DUIController.set_UIEffectStateCtrl);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_Raffle3DUIController.<>f__mg$cache2C, true);
		string name11 = "LayerCamera";
		if (Lua_BlackJack_ProjectL_UI_Raffle3DUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_Raffle3DUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_Raffle3DUIController.get_LayerCamera);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_Raffle3DUIController.<>f__mg$cache2D;
		if (Lua_BlackJack_ProjectL_UI_Raffle3DUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_Raffle3DUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_Raffle3DUIController.set_LayerCamera);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_Raffle3DUIController.<>f__mg$cache2E, true);
		LuaObject.createTypeMetatable(l, null, typeof(Raffle3DUIController), typeof(UIControllerBase));
	}

	// Token: 0x040166FB RID: 91899
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040166FC RID: 91900
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040166FD RID: 91901
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040166FE RID: 91902
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040166FF RID: 91903
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04016700 RID: 91904
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04016701 RID: 91905
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04016702 RID: 91906
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04016703 RID: 91907
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04016704 RID: 91908
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04016705 RID: 91909
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04016706 RID: 91910
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04016707 RID: 91911
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04016708 RID: 91912
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04016709 RID: 91913
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0401670A RID: 91914
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0401670B RID: 91915
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0401670C RID: 91916
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0401670D RID: 91917
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0401670E RID: 91918
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0401670F RID: 91919
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04016710 RID: 91920
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04016711 RID: 91921
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04016712 RID: 91922
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04016713 RID: 91923
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04016714 RID: 91924
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04016715 RID: 91925
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04016716 RID: 91926
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04016717 RID: 91927
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04016718 RID: 91928
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04016719 RID: 91929
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0401671A RID: 91930
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0401671B RID: 91931
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0401671C RID: 91932
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0401671D RID: 91933
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0401671E RID: 91934
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0401671F RID: 91935
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04016720 RID: 91936
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04016721 RID: 91937
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04016722 RID: 91938
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04016723 RID: 91939
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04016724 RID: 91940
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04016725 RID: 91941
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04016726 RID: 91942
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04016727 RID: 91943
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04016728 RID: 91944
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04016729 RID: 91945
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;
}
