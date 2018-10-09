using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Scene;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x020013F3 RID: 5107
[Preserve]
public class Lua_BlackJack_ProjectL_UI_ClimbTowerFloorItemUIController : LuaObject
{
	// Token: 0x0601CB28 RID: 117544 RVA: 0x008F2348 File Offset: 0x008F0548
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetTowerFloor(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerFloorItemUIController climbTowerFloorItemUIController = (ClimbTowerFloorItemUIController)LuaObject.checkSelf(l);
			ConfigDataTowerFloorInfo floorInfo;
			LuaObject.checkType<ConfigDataTowerFloorInfo>(l, 2, out floorInfo);
			ConfigDataTowerLevelInfo levelInfo;
			LuaObject.checkType<ConfigDataTowerLevelInfo>(l, 3, out levelInfo);
			GameObject rewardGoodsPrefab;
			LuaObject.checkType<GameObject>(l, 4, out rewardGoodsPrefab);
			climbTowerFloorItemUIController.SetTowerFloor(floorInfo, levelInfo, rewardGoodsPrefab);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CB29 RID: 117545 RVA: 0x008F23BC File Offset: 0x008F05BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetState(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerFloorItemUIController climbTowerFloorItemUIController = (ClimbTowerFloorItemUIController)LuaObject.checkSelf(l);
			bool isCleared;
			LuaObject.checkType(l, 2, out isCleared);
			bool isLocked;
			LuaObject.checkType(l, 3, out isLocked);
			Action onEnd;
			LuaObject.checkDelegate<Action>(l, 4, out onEnd);
			climbTowerFloorItemUIController.SetState(isCleared, isLocked, onEnd);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CB2A RID: 117546 RVA: 0x008F2430 File Offset: 0x008F0630
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CreateSpineGraphic(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerFloorItemUIController climbTowerFloorItemUIController = (ClimbTowerFloorItemUIController)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			climbTowerFloorItemUIController.CreateSpineGraphic(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CB2B RID: 117547 RVA: 0x008F2488 File Offset: 0x008F0688
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DestroySpineGraphic(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerFloorItemUIController climbTowerFloorItemUIController = (ClimbTowerFloorItemUIController)LuaObject.checkSelf(l);
			climbTowerFloorItemUIController.DestroySpineGraphic();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CB2C RID: 117548 RVA: 0x008F24D4 File Offset: 0x008F06D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerFloorItemUIController climbTowerFloorItemUIController = (ClimbTowerFloorItemUIController)LuaObject.checkSelf(l);
			climbTowerFloorItemUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CB2D RID: 117549 RVA: 0x008F2528 File Offset: 0x008F0728
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerFloorItemUIController climbTowerFloorItemUIController = (ClimbTowerFloorItemUIController)LuaObject.checkSelf(l);
			climbTowerFloorItemUIController.m_luaExportHelper.OnButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CB2E RID: 117550 RVA: 0x008F257C File Offset: 0x008F077C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerFloorItemUIController climbTowerFloorItemUIController = (ClimbTowerFloorItemUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			climbTowerFloorItemUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CB2F RID: 117551 RVA: 0x008F25E8 File Offset: 0x008F07E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerFloorItemUIController climbTowerFloorItemUIController = (ClimbTowerFloorItemUIController)LuaObject.checkSelf(l);
			climbTowerFloorItemUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CB30 RID: 117552 RVA: 0x008F263C File Offset: 0x008F083C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerFloorItemUIController climbTowerFloorItemUIController = (ClimbTowerFloorItemUIController)LuaObject.checkSelf(l);
			climbTowerFloorItemUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CB31 RID: 117553 RVA: 0x008F2690 File Offset: 0x008F0890
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerFloorItemUIController climbTowerFloorItemUIController = (ClimbTowerFloorItemUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = climbTowerFloorItemUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601CB32 RID: 117554 RVA: 0x008F2738 File Offset: 0x008F0938
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerFloorItemUIController climbTowerFloorItemUIController = (ClimbTowerFloorItemUIController)LuaObject.checkSelf(l);
			climbTowerFloorItemUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CB33 RID: 117555 RVA: 0x008F278C File Offset: 0x008F098C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerFloorItemUIController climbTowerFloorItemUIController = (ClimbTowerFloorItemUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			climbTowerFloorItemUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CB34 RID: 117556 RVA: 0x008F27F8 File Offset: 0x008F09F8
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
				ClimbTowerFloorItemUIController climbTowerFloorItemUIController = (ClimbTowerFloorItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				climbTowerFloorItemUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				ClimbTowerFloorItemUIController climbTowerFloorItemUIController2 = (ClimbTowerFloorItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				climbTowerFloorItemUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601CB35 RID: 117557 RVA: 0x008F2908 File Offset: 0x008F0B08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerFloorItemUIController climbTowerFloorItemUIController = (ClimbTowerFloorItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			climbTowerFloorItemUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CB36 RID: 117558 RVA: 0x008F2974 File Offset: 0x008F0B74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerFloorItemUIController climbTowerFloorItemUIController = (ClimbTowerFloorItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			climbTowerFloorItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CB37 RID: 117559 RVA: 0x008F29E0 File Offset: 0x008F0BE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerFloorItemUIController climbTowerFloorItemUIController = (ClimbTowerFloorItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			climbTowerFloorItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CB38 RID: 117560 RVA: 0x008F2A4C File Offset: 0x008F0C4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerFloorItemUIController climbTowerFloorItemUIController = (ClimbTowerFloorItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			climbTowerFloorItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CB39 RID: 117561 RVA: 0x008F2AB8 File Offset: 0x008F0CB8
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
				ClimbTowerFloorItemUIController climbTowerFloorItemUIController = (ClimbTowerFloorItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				climbTowerFloorItemUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				ClimbTowerFloorItemUIController climbTowerFloorItemUIController2 = (ClimbTowerFloorItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				climbTowerFloorItemUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601CB3A RID: 117562 RVA: 0x008F2BC8 File Offset: 0x008F0DC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerFloorItemUIController climbTowerFloorItemUIController = (ClimbTowerFloorItemUIController)LuaObject.checkSelf(l);
			string s = climbTowerFloorItemUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601CB3B RID: 117563 RVA: 0x008F2C24 File Offset: 0x008F0E24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerFloorItemUIController climbTowerFloorItemUIController = (ClimbTowerFloorItemUIController)LuaObject.checkSelf(l);
			Action<ClimbTowerFloorItemUIController> action;
			int num = LuaObject.checkDelegate<Action<ClimbTowerFloorItemUIController>>(l, 2, out action);
			if (num == 0)
			{
				climbTowerFloorItemUIController.EventOnButtonClick = action;
			}
			else if (num == 1)
			{
				ClimbTowerFloorItemUIController climbTowerFloorItemUIController2 = climbTowerFloorItemUIController;
				climbTowerFloorItemUIController2.EventOnButtonClick = (Action<ClimbTowerFloorItemUIController>)Delegate.Combine(climbTowerFloorItemUIController2.EventOnButtonClick, action);
			}
			else if (num == 2)
			{
				ClimbTowerFloorItemUIController climbTowerFloorItemUIController3 = climbTowerFloorItemUIController;
				climbTowerFloorItemUIController3.EventOnButtonClick = (Action<ClimbTowerFloorItemUIController>)Delegate.Remove(climbTowerFloorItemUIController3.EventOnButtonClick, action);
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

	// Token: 0x0601CB3C RID: 117564 RVA: 0x008F2CCC File Offset: 0x008F0ECC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiStateController(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerFloorItemUIController climbTowerFloorItemUIController = (ClimbTowerFloorItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, climbTowerFloorItemUIController.m_luaExportHelper.m_uiStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CB3D RID: 117565 RVA: 0x008F2D24 File Offset: 0x008F0F24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiStateController(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerFloorItemUIController climbTowerFloorItemUIController = (ClimbTowerFloorItemUIController)LuaObject.checkSelf(l);
			CommonUIStateController uiStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out uiStateController);
			climbTowerFloorItemUIController.m_luaExportHelper.m_uiStateController = uiStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CB3E RID: 117566 RVA: 0x008F2D80 File Offset: 0x008F0F80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_graphicGameObject(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerFloorItemUIController climbTowerFloorItemUIController = (ClimbTowerFloorItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, climbTowerFloorItemUIController.m_luaExportHelper.m_graphicGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CB3F RID: 117567 RVA: 0x008F2DD8 File Offset: 0x008F0FD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_graphicGameObject(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerFloorItemUIController climbTowerFloorItemUIController = (ClimbTowerFloorItemUIController)LuaObject.checkSelf(l);
			GameObject graphicGameObject;
			LuaObject.checkType<GameObject>(l, 2, out graphicGameObject);
			climbTowerFloorItemUIController.m_luaExportHelper.m_graphicGameObject = graphicGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CB40 RID: 117568 RVA: 0x008F2E34 File Offset: 0x008F1034
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_rewardGroupTransform(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerFloorItemUIController climbTowerFloorItemUIController = (ClimbTowerFloorItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, climbTowerFloorItemUIController.m_luaExportHelper.m_rewardGroupTransform);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CB41 RID: 117569 RVA: 0x008F2E8C File Offset: 0x008F108C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_rewardGroupTransform(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerFloorItemUIController climbTowerFloorItemUIController = (ClimbTowerFloorItemUIController)LuaObject.checkSelf(l);
			Transform rewardGroupTransform;
			LuaObject.checkType<Transform>(l, 2, out rewardGroupTransform);
			climbTowerFloorItemUIController.m_luaExportHelper.m_rewardGroupTransform = rewardGroupTransform;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CB42 RID: 117570 RVA: 0x008F2EE8 File Offset: 0x008F10E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_spineGraphic(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerFloorItemUIController climbTowerFloorItemUIController = (ClimbTowerFloorItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, climbTowerFloorItemUIController.m_luaExportHelper.m_spineGraphic);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CB43 RID: 117571 RVA: 0x008F2F40 File Offset: 0x008F1140
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_spineGraphic(IntPtr l)
	{
		int result;
		try
		{
			ClimbTowerFloorItemUIController climbTowerFloorItemUIController = (ClimbTowerFloorItemUIController)LuaObject.checkSelf(l);
			UISpineGraphic spineGraphic;
			LuaObject.checkType<UISpineGraphic>(l, 2, out spineGraphic);
			climbTowerFloorItemUIController.m_luaExportHelper.m_spineGraphic = spineGraphic;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CB44 RID: 117572 RVA: 0x008F2F9C File Offset: 0x008F119C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.ClimbTowerFloorItemUIController");
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerFloorItemUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerFloorItemUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerFloorItemUIController.SetTowerFloor);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerFloorItemUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerFloorItemUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerFloorItemUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerFloorItemUIController.SetState);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerFloorItemUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerFloorItemUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerFloorItemUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerFloorItemUIController.CreateSpineGraphic);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerFloorItemUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerFloorItemUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerFloorItemUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerFloorItemUIController.DestroySpineGraphic);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerFloorItemUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerFloorItemUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerFloorItemUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerFloorItemUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerFloorItemUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerFloorItemUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerFloorItemUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerFloorItemUIController.OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerFloorItemUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerFloorItemUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerFloorItemUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerFloorItemUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerFloorItemUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerFloorItemUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerFloorItemUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerFloorItemUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerFloorItemUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerFloorItemUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerFloorItemUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerFloorItemUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerFloorItemUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerFloorItemUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerFloorItemUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerFloorItemUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerFloorItemUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerFloorItemUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerFloorItemUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerFloorItemUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerFloorItemUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerFloorItemUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerFloorItemUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerFloorItemUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerFloorItemUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerFloorItemUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerFloorItemUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerFloorItemUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerFloorItemUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerFloorItemUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerFloorItemUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerFloorItemUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerFloorItemUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerFloorItemUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerFloorItemUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerFloorItemUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerFloorItemUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerFloorItemUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerFloorItemUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerFloorItemUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerFloorItemUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerFloorItemUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerFloorItemUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerFloorItemUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerFloorItemUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerFloorItemUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerFloorItemUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerFloorItemUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerFloorItemUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerFloorItemUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerFloorItemUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerFloorItemUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ClimbTowerFloorItemUIController.<>f__mg$cache12);
		string name = "EventOnButtonClick";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerFloorItemUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerFloorItemUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerFloorItemUIController.set_EventOnButtonClick);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_ClimbTowerFloorItemUIController.<>f__mg$cache13, true);
		string name2 = "m_uiStateController";
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerFloorItemUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerFloorItemUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerFloorItemUIController.get_m_uiStateController);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_ClimbTowerFloorItemUIController.<>f__mg$cache14;
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerFloorItemUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerFloorItemUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerFloorItemUIController.set_m_uiStateController);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_ClimbTowerFloorItemUIController.<>f__mg$cache15, true);
		string name3 = "m_graphicGameObject";
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerFloorItemUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerFloorItemUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerFloorItemUIController.get_m_graphicGameObject);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_ClimbTowerFloorItemUIController.<>f__mg$cache16;
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerFloorItemUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerFloorItemUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerFloorItemUIController.set_m_graphicGameObject);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_ClimbTowerFloorItemUIController.<>f__mg$cache17, true);
		string name4 = "m_rewardGroupTransform";
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerFloorItemUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerFloorItemUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerFloorItemUIController.get_m_rewardGroupTransform);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_ClimbTowerFloorItemUIController.<>f__mg$cache18;
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerFloorItemUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerFloorItemUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerFloorItemUIController.set_m_rewardGroupTransform);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_ClimbTowerFloorItemUIController.<>f__mg$cache19, true);
		string name5 = "m_spineGraphic";
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerFloorItemUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerFloorItemUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerFloorItemUIController.get_m_spineGraphic);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_ClimbTowerFloorItemUIController.<>f__mg$cache1A;
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerFloorItemUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerFloorItemUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerFloorItemUIController.set_m_spineGraphic);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_ClimbTowerFloorItemUIController.<>f__mg$cache1B, true);
		LuaObject.createTypeMetatable(l, null, typeof(ClimbTowerFloorItemUIController), typeof(UIControllerBase));
	}

	// Token: 0x04012D24 RID: 77092
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04012D25 RID: 77093
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04012D26 RID: 77094
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04012D27 RID: 77095
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04012D28 RID: 77096
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04012D29 RID: 77097
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04012D2A RID: 77098
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04012D2B RID: 77099
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04012D2C RID: 77100
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04012D2D RID: 77101
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04012D2E RID: 77102
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04012D2F RID: 77103
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04012D30 RID: 77104
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04012D31 RID: 77105
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04012D32 RID: 77106
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04012D33 RID: 77107
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04012D34 RID: 77108
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04012D35 RID: 77109
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04012D36 RID: 77110
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04012D37 RID: 77111
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04012D38 RID: 77112
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04012D39 RID: 77113
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04012D3A RID: 77114
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04012D3B RID: 77115
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04012D3C RID: 77116
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04012D3D RID: 77117
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04012D3E RID: 77118
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04012D3F RID: 77119
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;
}
