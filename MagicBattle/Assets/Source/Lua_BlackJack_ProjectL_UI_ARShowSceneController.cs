using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.AR;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.UI;
using SLua;
using Spine.Unity;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x0200138A RID: 5002
[Preserve]
public class Lua_BlackJack_ProjectL_UI_ARShowSceneController : LuaObject
{
	// Token: 0x0601B3A5 RID: 111525 RVA: 0x00837730 File Offset: 0x00835930
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetUITask(IntPtr l)
	{
		int result;
		try
		{
			ARShowSceneController arshowSceneController = (ARShowSceneController)LuaObject.checkSelf(l);
			ARUITask uitask;
			LuaObject.checkType<ARUITask>(l, 2, out uitask);
			arshowSceneController.SetUITask(uitask);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B3A6 RID: 111526 RVA: 0x00837788 File Offset: 0x00835988
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SummonHeroBattleShow(IntPtr l)
	{
		int result;
		try
		{
			ARShowSceneController arshowSceneController = (ARShowSceneController)LuaObject.checkSelf(l);
			int selectHeroID;
			LuaObject.checkType(l, 2, out selectHeroID);
			arshowSceneController.SummonHeroBattleShow(selectHeroID);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B3A7 RID: 111527 RVA: 0x008377E0 File Offset: 0x008359E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SummonHeroDrawShow(IntPtr l)
	{
		int result;
		try
		{
			ARShowSceneController arshowSceneController = (ARShowSceneController)LuaObject.checkSelf(l);
			int selectHeroID;
			LuaObject.checkType(l, 2, out selectHeroID);
			arshowSceneController.SummonHeroDrawShow(selectHeroID);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B3A8 RID: 111528 RVA: 0x00837838 File Offset: 0x00835A38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SummonHeroTeamShow(IntPtr l)
	{
		int result;
		try
		{
			ARShowSceneController arshowSceneController = (ARShowSceneController)LuaObject.checkSelf(l);
			arshowSceneController.SummonHeroTeamShow();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B3A9 RID: 111529 RVA: 0x00837884 File Offset: 0x00835A84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlaySingleCharAnimation(IntPtr l)
	{
		int result;
		try
		{
			ARShowSceneController arshowSceneController = (ARShowSceneController)LuaObject.checkSelf(l);
			string animationName;
			LuaObject.checkType(l, 2, out animationName);
			bool isLoop;
			LuaObject.checkType(l, 3, out isLoop);
			arshowSceneController.PlaySingleCharAnimation(animationName, isLoop);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B3AA RID: 111530 RVA: 0x008378E8 File Offset: 0x00835AE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayAnimation(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(SkeletonAnimation), typeof(HeroActionType), typeof(bool)))
			{
				ARShowSceneController arshowSceneController = (ARShowSceneController)LuaObject.checkSelf(l);
				SkeletonAnimation skeletonAnimation;
				LuaObject.checkType<SkeletonAnimation>(l, 2, out skeletonAnimation);
				HeroActionType actionType;
				LuaObject.checkEnum<HeroActionType>(l, 3, out actionType);
				bool isLoop;
				LuaObject.checkType(l, 4, out isLoop);
				arshowSceneController.PlayAnimation(skeletonAnimation, actionType, isLoop);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(SkeletonAnimation), typeof(string), typeof(bool)))
			{
				ARShowSceneController arshowSceneController2 = (ARShowSceneController)LuaObject.checkSelf(l);
				SkeletonAnimation skeletonAnimation2;
				LuaObject.checkType<SkeletonAnimation>(l, 2, out skeletonAnimation2);
				string animationName;
				LuaObject.checkType(l, 3, out animationName);
				bool isLoop2;
				LuaObject.checkType(l, 4, out isLoop2);
				arshowSceneController2.PlayAnimation(skeletonAnimation2, animationName, isLoop2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function PlayAnimation to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B3AB RID: 111531 RVA: 0x00837A28 File Offset: 0x00835C28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetCharDirection(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				ARShowSceneController arshowSceneController = (ARShowSceneController)LuaObject.checkSelf(l);
				bool charDirection;
				LuaObject.checkType(l, 2, out charDirection);
				arshowSceneController.SetCharDirection(charDirection);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 3)
			{
				ARShowSceneController arshowSceneController2 = (ARShowSceneController)LuaObject.checkSelf(l);
				GameObject charObj;
				LuaObject.checkType<GameObject>(l, 2, out charObj);
				bool isLookRight;
				LuaObject.checkType(l, 3, out isLookRight);
				arshowSceneController2.SetCharDirection(charObj, isLookRight);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function SetCharDirection to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B3AC RID: 111532 RVA: 0x00837AEC File Offset: 0x00835CEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetCharScale(IntPtr l)
	{
		int result;
		try
		{
			ARShowSceneController arshowSceneController = (ARShowSceneController)LuaObject.checkSelf(l);
			float charScale;
			LuaObject.checkType(l, 2, out charScale);
			arshowSceneController.SetCharScale(charScale);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B3AD RID: 111533 RVA: 0x00837B44 File Offset: 0x00835D44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetTeamDistance(IntPtr l)
	{
		int result;
		try
		{
			ARShowSceneController arshowSceneController = (ARShowSceneController)LuaObject.checkSelf(l);
			float teamDistance;
			LuaObject.checkType(l, 2, out teamDistance);
			arshowSceneController.SetTeamDistance(teamDistance);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B3AE RID: 111534 RVA: 0x00837B9C File Offset: 0x00835D9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DestroyChar(IntPtr l)
	{
		int result;
		try
		{
			ARShowSceneController arshowSceneController = (ARShowSceneController)LuaObject.checkSelf(l);
			arshowSceneController.DestroyChar();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B3AF RID: 111535 RVA: 0x00837BE8 File Offset: 0x00835DE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsFindPlane(IntPtr l)
	{
		int result;
		try
		{
			ARShowSceneController arshowSceneController = (ARShowSceneController)LuaObject.checkSelf(l);
			bool b = arshowSceneController.IsFindPlane();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B3B0 RID: 111536 RVA: 0x00837C3C File Offset: 0x00835E3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlaneTraceEnable(IntPtr l)
	{
		int result;
		try
		{
			ARShowSceneController arshowSceneController = (ARShowSceneController)LuaObject.checkSelf(l);
			bool isActive;
			LuaObject.checkType(l, 2, out isActive);
			arshowSceneController.PlaneTraceEnable(isActive);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B3B1 RID: 111537 RVA: 0x00837C94 File Offset: 0x00835E94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			ARShowSceneController arshowSceneController = (ARShowSceneController)LuaObject.checkSelf(l);
			arshowSceneController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B3B2 RID: 111538 RVA: 0x00837CE8 File Offset: 0x00835EE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Update(IntPtr l)
	{
		int result;
		try
		{
			ARShowSceneController arshowSceneController = (ARShowSceneController)LuaObject.checkSelf(l);
			arshowSceneController.m_luaExportHelper.Update();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B3B3 RID: 111539 RVA: 0x00837D3C File Offset: 0x00835F3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnCharClick(IntPtr l)
	{
		int result;
		try
		{
			ARShowSceneController arshowSceneController = (ARShowSceneController)LuaObject.checkSelf(l);
			GameObject obj;
			LuaObject.checkType<GameObject>(l, 2, out obj);
			arshowSceneController.m_luaExportHelper.OnCharClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B3B4 RID: 111540 RVA: 0x00837D98 File Offset: 0x00835F98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			ARShowSceneController arshowSceneController = (ARShowSceneController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			arshowSceneController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B3B5 RID: 111541 RVA: 0x00837E04 File Offset: 0x00836004
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			ARShowSceneController arshowSceneController = (ARShowSceneController)LuaObject.checkSelf(l);
			arshowSceneController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B3B6 RID: 111542 RVA: 0x00837E58 File Offset: 0x00836058
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			ARShowSceneController arshowSceneController = (ARShowSceneController)LuaObject.checkSelf(l);
			arshowSceneController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B3B7 RID: 111543 RVA: 0x00837EAC File Offset: 0x008360AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			ARShowSceneController arshowSceneController = (ARShowSceneController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = arshowSceneController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601B3B8 RID: 111544 RVA: 0x00837F54 File Offset: 0x00836154
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			ARShowSceneController arshowSceneController = (ARShowSceneController)LuaObject.checkSelf(l);
			arshowSceneController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B3B9 RID: 111545 RVA: 0x00837FA8 File Offset: 0x008361A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ARShowSceneController arshowSceneController = (ARShowSceneController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			arshowSceneController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B3BA RID: 111546 RVA: 0x00838014 File Offset: 0x00836214
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
				ARShowSceneController arshowSceneController = (ARShowSceneController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				arshowSceneController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				ARShowSceneController arshowSceneController2 = (ARShowSceneController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				arshowSceneController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601B3BB RID: 111547 RVA: 0x00838124 File Offset: 0x00836324
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			ARShowSceneController arshowSceneController = (ARShowSceneController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			arshowSceneController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B3BC RID: 111548 RVA: 0x00838190 File Offset: 0x00836390
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			ARShowSceneController arshowSceneController = (ARShowSceneController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			arshowSceneController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B3BD RID: 111549 RVA: 0x008381FC File Offset: 0x008363FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			ARShowSceneController arshowSceneController = (ARShowSceneController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			arshowSceneController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B3BE RID: 111550 RVA: 0x00838268 File Offset: 0x00836468
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			ARShowSceneController arshowSceneController = (ARShowSceneController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			arshowSceneController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B3BF RID: 111551 RVA: 0x008382D4 File Offset: 0x008364D4
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
				ARShowSceneController arshowSceneController = (ARShowSceneController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				arshowSceneController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				ARShowSceneController arshowSceneController2 = (ARShowSceneController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				arshowSceneController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601B3C0 RID: 111552 RVA: 0x008383E4 File Offset: 0x008365E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			ARShowSceneController arshowSceneController = (ARShowSceneController)LuaObject.checkSelf(l);
			string s = arshowSceneController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601B3C1 RID: 111553 RVA: 0x00838440 File Offset: 0x00836640
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_camera(IntPtr l)
	{
		int result;
		try
		{
			ARShowSceneController arshowSceneController = (ARShowSceneController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arshowSceneController.m_luaExportHelper.m_camera);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B3C2 RID: 111554 RVA: 0x00838498 File Offset: 0x00836698
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_camera(IntPtr l)
	{
		int result;
		try
		{
			ARShowSceneController arshowSceneController = (ARShowSceneController)LuaObject.checkSelf(l);
			Camera camera;
			LuaObject.checkType<Camera>(l, 2, out camera);
			arshowSceneController.m_luaExportHelper.m_camera = camera;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B3C3 RID: 111555 RVA: 0x008384F4 File Offset: 0x008366F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_focusSquare(IntPtr l)
	{
		int result;
		try
		{
			ARShowSceneController arshowSceneController = (ARShowSceneController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arshowSceneController.m_luaExportHelper.m_focusSquare);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B3C4 RID: 111556 RVA: 0x0083854C File Offset: 0x0083674C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_focusSquare(IntPtr l)
	{
		int result;
		try
		{
			ARShowSceneController arshowSceneController = (ARShowSceneController)LuaObject.checkSelf(l);
			GameObject focusSquare;
			LuaObject.checkType<GameObject>(l, 2, out focusSquare);
			arshowSceneController.m_luaExportHelper.m_focusSquare = focusSquare;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B3C5 RID: 111557 RVA: 0x008385A8 File Offset: 0x008367A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_focusSquareRenderer(IntPtr l)
	{
		int result;
		try
		{
			ARShowSceneController arshowSceneController = (ARShowSceneController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arshowSceneController.m_luaExportHelper.m_focusSquareRenderer);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B3C6 RID: 111558 RVA: 0x00838600 File Offset: 0x00836800
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_focusSquareRenderer(IntPtr l)
	{
		int result;
		try
		{
			ARShowSceneController arshowSceneController = (ARShowSceneController)LuaObject.checkSelf(l);
			Renderer focusSquareRenderer;
			LuaObject.checkType<Renderer>(l, 2, out focusSquareRenderer);
			arshowSceneController.m_luaExportHelper.m_focusSquareRenderer = focusSquareRenderer;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B3C7 RID: 111559 RVA: 0x0083865C File Offset: 0x0083685C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_charNode(IntPtr l)
	{
		int result;
		try
		{
			ARShowSceneController arshowSceneController = (ARShowSceneController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arshowSceneController.m_luaExportHelper.m_charNode);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B3C8 RID: 111560 RVA: 0x008386B4 File Offset: 0x008368B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_charNode(IntPtr l)
	{
		int result;
		try
		{
			ARShowSceneController arshowSceneController = (ARShowSceneController)LuaObject.checkSelf(l);
			GameObject charNode;
			LuaObject.checkType<GameObject>(l, 2, out charNode);
			arshowSceneController.m_luaExportHelper.m_charNode = charNode;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B3C9 RID: 111561 RVA: 0x00838710 File Offset: 0x00836910
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_charDrawNode(IntPtr l)
	{
		int result;
		try
		{
			ARShowSceneController arshowSceneController = (ARShowSceneController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arshowSceneController.m_luaExportHelper.m_charDrawNode);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B3CA RID: 111562 RVA: 0x00838768 File Offset: 0x00836968
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_charDrawNode(IntPtr l)
	{
		int result;
		try
		{
			ARShowSceneController arshowSceneController = (ARShowSceneController)LuaObject.checkSelf(l);
			GameObject charDrawNode;
			LuaObject.checkType<GameObject>(l, 2, out charDrawNode);
			arshowSceneController.m_luaExportHelper.m_charDrawNode = charDrawNode;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B3CB RID: 111563 RVA: 0x008387C4 File Offset: 0x008369C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_charGroupNode(IntPtr l)
	{
		int result;
		try
		{
			ARShowSceneController arshowSceneController = (ARShowSceneController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arshowSceneController.m_luaExportHelper.m_charGroupNode);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B3CC RID: 111564 RVA: 0x0083881C File Offset: 0x00836A1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_charGroupNode(IntPtr l)
	{
		int result;
		try
		{
			ARShowSceneController arshowSceneController = (ARShowSceneController)LuaObject.checkSelf(l);
			GameObject charGroupNode;
			LuaObject.checkType<GameObject>(l, 2, out charGroupNode);
			arshowSceneController.m_luaExportHelper.m_charGroupNode = charGroupNode;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B3CD RID: 111565 RVA: 0x00838878 File Offset: 0x00836A78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_arPlaneTrace(IntPtr l)
	{
		int result;
		try
		{
			ARShowSceneController arshowSceneController = (ARShowSceneController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arshowSceneController.m_luaExportHelper.arPlaneTrace);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B3CE RID: 111566 RVA: 0x008388D0 File Offset: 0x00836AD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_arPlaneTrace(IntPtr l)
	{
		int result;
		try
		{
			ARShowSceneController arshowSceneController = (ARShowSceneController)LuaObject.checkSelf(l);
			ARPlaneTrace arPlaneTrace;
			LuaObject.checkType<ARPlaneTrace>(l, 2, out arPlaneTrace);
			arshowSceneController.m_luaExportHelper.arPlaneTrace = arPlaneTrace;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B3CF RID: 111567 RVA: 0x0083892C File Offset: 0x00836B2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_roleSkeleton(IntPtr l)
	{
		int result;
		try
		{
			ARShowSceneController arshowSceneController = (ARShowSceneController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arshowSceneController.m_luaExportHelper.m_roleSkeleton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B3D0 RID: 111568 RVA: 0x00838984 File Offset: 0x00836B84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_roleSkeleton(IntPtr l)
	{
		int result;
		try
		{
			ARShowSceneController arshowSceneController = (ARShowSceneController)LuaObject.checkSelf(l);
			SkeletonAnimation roleSkeleton;
			LuaObject.checkType<SkeletonAnimation>(l, 2, out roleSkeleton);
			arshowSceneController.m_luaExportHelper.m_roleSkeleton = roleSkeleton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B3D1 RID: 111569 RVA: 0x008389E0 File Offset: 0x00836BE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_roleSkeletonList(IntPtr l)
	{
		int result;
		try
		{
			ARShowSceneController arshowSceneController = (ARShowSceneController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arshowSceneController.m_luaExportHelper.m_roleSkeletonList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B3D2 RID: 111570 RVA: 0x00838A38 File Offset: 0x00836C38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_roleSkeletonList(IntPtr l)
	{
		int result;
		try
		{
			ARShowSceneController arshowSceneController = (ARShowSceneController)LuaObject.checkSelf(l);
			List<SkeletonAnimation> roleSkeletonList;
			LuaObject.checkType<List<SkeletonAnimation>>(l, 2, out roleSkeletonList);
			arshowSceneController.m_luaExportHelper.m_roleSkeletonList = roleSkeletonList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B3D3 RID: 111571 RVA: 0x00838A94 File Offset: 0x00836C94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_task(IntPtr l)
	{
		int result;
		try
		{
			ARShowSceneController arshowSceneController = (ARShowSceneController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arshowSceneController.m_luaExportHelper.m_task);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B3D4 RID: 111572 RVA: 0x00838AEC File Offset: 0x00836CEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_task(IntPtr l)
	{
		int result;
		try
		{
			ARShowSceneController arshowSceneController = (ARShowSceneController)LuaObject.checkSelf(l);
			ARUITask task;
			LuaObject.checkType<ARUITask>(l, 2, out task);
			arshowSceneController.m_luaExportHelper.m_task = task;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B3D5 RID: 111573 RVA: 0x00838B48 File Offset: 0x00836D48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			ARShowSceneController arshowSceneController = (ARShowSceneController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arshowSceneController.m_luaExportHelper.m_configDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B3D6 RID: 111574 RVA: 0x00838BA0 File Offset: 0x00836DA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			ARShowSceneController arshowSceneController = (ARShowSceneController)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			arshowSceneController.m_luaExportHelper.m_configDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B3D7 RID: 111575 RVA: 0x00838BFC File Offset: 0x00836DFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			ARShowSceneController arshowSceneController = (ARShowSceneController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arshowSceneController.m_luaExportHelper.m_playerContext);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B3D8 RID: 111576 RVA: 0x00838C54 File Offset: 0x00836E54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			ARShowSceneController arshowSceneController = (ARShowSceneController)LuaObject.checkSelf(l);
			ProjectLPlayerContext playerContext;
			LuaObject.checkType<ProjectLPlayerContext>(l, 2, out playerContext);
			arshowSceneController.m_luaExportHelper.m_playerContext = playerContext;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B3D9 RID: 111577 RVA: 0x00838CB0 File Offset: 0x00836EB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_roleAnimationList(IntPtr l)
	{
		int result;
		try
		{
			ARShowSceneController arshowSceneController = (ARShowSceneController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arshowSceneController.m_luaExportHelper.m_roleAnimationList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B3DA RID: 111578 RVA: 0x00838D08 File Offset: 0x00836F08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_roleAnimationList(IntPtr l)
	{
		int result;
		try
		{
			ARShowSceneController arshowSceneController = (ARShowSceneController)LuaObject.checkSelf(l);
			string[] roleAnimationList;
			LuaObject.checkArray<string>(l, 2, out roleAnimationList);
			arshowSceneController.m_luaExportHelper.m_roleAnimationList = roleAnimationList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B3DB RID: 111579 RVA: 0x00838D64 File Offset: 0x00836F64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_isPlaneTrace(IntPtr l)
	{
		int result;
		try
		{
			ARShowSceneController arshowSceneController = (ARShowSceneController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arshowSceneController.m_luaExportHelper.isPlaneTrace);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B3DC RID: 111580 RVA: 0x00838DBC File Offset: 0x00836FBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_isPlaneTrace(IntPtr l)
	{
		int result;
		try
		{
			ARShowSceneController arshowSceneController = (ARShowSceneController)LuaObject.checkSelf(l);
			bool isPlaneTrace;
			LuaObject.checkType(l, 2, out isPlaneTrace);
			arshowSceneController.m_luaExportHelper.isPlaneTrace = isPlaneTrace;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B3DD RID: 111581 RVA: 0x00838E18 File Offset: 0x00837018
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.ARShowSceneController");
		if (Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowSceneController.SetUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowSceneController.SummonHeroBattleShow);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowSceneController.SummonHeroDrawShow);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowSceneController.SummonHeroTeamShow);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowSceneController.PlaySingleCharAnimation);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowSceneController.PlayAnimation);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowSceneController.SetCharDirection);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowSceneController.SetCharScale);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowSceneController.SetTeamDistance);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowSceneController.DestroyChar);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowSceneController.IsFindPlane);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowSceneController.PlaneTraceEnable);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowSceneController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowSceneController.Update);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowSceneController.OnCharClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowSceneController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowSceneController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowSceneController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowSceneController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowSceneController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowSceneController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowSceneController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowSceneController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowSceneController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowSceneController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowSceneController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowSceneController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowSceneController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache1B);
		string name = "m_camera";
		if (Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowSceneController.get_m_camera);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache1C;
		if (Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowSceneController.set_m_camera);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache1D, true);
		string name2 = "m_focusSquare";
		if (Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowSceneController.get_m_focusSquare);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache1E;
		if (Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowSceneController.set_m_focusSquare);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache1F, true);
		string name3 = "m_focusSquareRenderer";
		if (Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowSceneController.get_m_focusSquareRenderer);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache20;
		if (Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowSceneController.set_m_focusSquareRenderer);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache21, true);
		string name4 = "m_charNode";
		if (Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowSceneController.get_m_charNode);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache22;
		if (Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowSceneController.set_m_charNode);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache23, true);
		string name5 = "m_charDrawNode";
		if (Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowSceneController.get_m_charDrawNode);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache24;
		if (Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowSceneController.set_m_charDrawNode);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache25, true);
		string name6 = "m_charGroupNode";
		if (Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowSceneController.get_m_charGroupNode);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache26;
		if (Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowSceneController.set_m_charGroupNode);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache27, true);
		string name7 = "arPlaneTrace";
		if (Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowSceneController.get_arPlaneTrace);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache28;
		if (Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowSceneController.set_arPlaneTrace);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache29, true);
		string name8 = "m_roleSkeleton";
		if (Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowSceneController.get_m_roleSkeleton);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache2A;
		if (Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowSceneController.set_m_roleSkeleton);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache2B, true);
		string name9 = "m_roleSkeletonList";
		if (Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowSceneController.get_m_roleSkeletonList);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache2C;
		if (Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowSceneController.set_m_roleSkeletonList);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache2D, true);
		string name10 = "m_task";
		if (Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowSceneController.get_m_task);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache2E;
		if (Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowSceneController.set_m_task);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache2F, true);
		string name11 = "m_configDataLoader";
		if (Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowSceneController.get_m_configDataLoader);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache30;
		if (Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowSceneController.set_m_configDataLoader);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache31, true);
		string name12 = "m_playerContext";
		if (Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowSceneController.get_m_playerContext);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache32;
		if (Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowSceneController.set_m_playerContext);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache33, true);
		string name13 = "m_roleAnimationList";
		if (Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowSceneController.get_m_roleAnimationList);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache34;
		if (Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowSceneController.set_m_roleAnimationList);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache35, true);
		string name14 = "isPlaneTrace";
		if (Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowSceneController.get_isPlaneTrace);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache36;
		if (Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARShowSceneController.set_isPlaneTrace);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_ARShowSceneController.<>f__mg$cache37, true);
		LuaObject.createTypeMetatable(l, null, typeof(ARShowSceneController), typeof(UIControllerBase));
	}

	// Token: 0x04011673 RID: 71283
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04011674 RID: 71284
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04011675 RID: 71285
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04011676 RID: 71286
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04011677 RID: 71287
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04011678 RID: 71288
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04011679 RID: 71289
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0401167A RID: 71290
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0401167B RID: 71291
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0401167C RID: 71292
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0401167D RID: 71293
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0401167E RID: 71294
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0401167F RID: 71295
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04011680 RID: 71296
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04011681 RID: 71297
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04011682 RID: 71298
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04011683 RID: 71299
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04011684 RID: 71300
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04011685 RID: 71301
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04011686 RID: 71302
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04011687 RID: 71303
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04011688 RID: 71304
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04011689 RID: 71305
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0401168A RID: 71306
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0401168B RID: 71307
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0401168C RID: 71308
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0401168D RID: 71309
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0401168E RID: 71310
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0401168F RID: 71311
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04011690 RID: 71312
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04011691 RID: 71313
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04011692 RID: 71314
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04011693 RID: 71315
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04011694 RID: 71316
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04011695 RID: 71317
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04011696 RID: 71318
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04011697 RID: 71319
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04011698 RID: 71320
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04011699 RID: 71321
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0401169A RID: 71322
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0401169B RID: 71323
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x0401169C RID: 71324
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x0401169D RID: 71325
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x0401169E RID: 71326
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x0401169F RID: 71327
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x040116A0 RID: 71328
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x040116A1 RID: 71329
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x040116A2 RID: 71330
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x040116A3 RID: 71331
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x040116A4 RID: 71332
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x040116A5 RID: 71333
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x040116A6 RID: 71334
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x040116A7 RID: 71335
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x040116A8 RID: 71336
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x040116A9 RID: 71337
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x040116AA RID: 71338
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;
}
