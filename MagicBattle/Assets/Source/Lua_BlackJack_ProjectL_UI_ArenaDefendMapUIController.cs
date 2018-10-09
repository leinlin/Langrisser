using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Misc;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x02001370 RID: 4976
[Preserve]
public class Lua_BlackJack_ProjectL_UI_ArenaDefendMapUIController : LuaObject
{
	// Token: 0x0601ADAF RID: 109999 RVA: 0x00807CF0 File Offset: 0x00805EF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Initialize(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendMapUIController arenaDefendMapUIController = (ArenaDefendMapUIController)LuaObject.checkSelf(l);
			ArenaDefendBattle battle;
			LuaObject.checkType<ArenaDefendBattle>(l, 2, out battle);
			arenaDefendMapUIController.Initialize(battle);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ADB0 RID: 110000 RVA: 0x00807D48 File Offset: 0x00805F48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowStagePosition(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendMapUIController arenaDefendMapUIController = (ArenaDefendMapUIController)LuaObject.checkSelf(l);
			GridPosition pos;
			LuaObject.checkValueType<GridPosition>(l, 2, out pos);
			bool isEmpty;
			LuaObject.checkType(l, 3, out isEmpty);
			arenaDefendMapUIController.ShowStagePosition(pos, isEmpty);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ADB1 RID: 110001 RVA: 0x00807DAC File Offset: 0x00805FAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowStageAttackerPosition(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendMapUIController arenaDefendMapUIController = (ArenaDefendMapUIController)LuaObject.checkSelf(l);
			GridPosition pos;
			LuaObject.checkValueType<GridPosition>(l, 2, out pos);
			arenaDefendMapUIController.ShowStageAttackerPosition(pos);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ADB2 RID: 110002 RVA: 0x00807E04 File Offset: 0x00806004
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HideStagePositions(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendMapUIController arenaDefendMapUIController = (ArenaDefendMapUIController)LuaObject.checkSelf(l);
			arenaDefendMapUIController.HideStagePositions();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ADB3 RID: 110003 RVA: 0x00807E50 File Offset: 0x00806050
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayOnStageFx(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendMapUIController arenaDefendMapUIController = (ArenaDefendMapUIController)LuaObject.checkSelf(l);
			GridPosition pos;
			LuaObject.checkValueType<GridPosition>(l, 2, out pos);
			arenaDefendMapUIController.PlayOnStageFx(pos);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ADB4 RID: 110004 RVA: 0x00807EA8 File Offset: 0x008060A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendMapUIController arenaDefendMapUIController = (ArenaDefendMapUIController)LuaObject.checkSelf(l);
			arenaDefendMapUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ADB5 RID: 110005 RVA: 0x00807EFC File Offset: 0x008060FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StagePositionToWorldPosition(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendMapUIController arenaDefendMapUIController = (ArenaDefendMapUIController)LuaObject.checkSelf(l);
			GridPosition pos;
			LuaObject.checkValueType<GridPosition>(l, 2, out pos);
			Vector3 o = arenaDefendMapUIController.m_luaExportHelper.StagePositionToWorldPosition(pos);
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

	// Token: 0x0601ADB6 RID: 110006 RVA: 0x00807F64 File Offset: 0x00806164
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GridPositionToWorldPosition(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendMapUIController arenaDefendMapUIController = (ArenaDefendMapUIController)LuaObject.checkSelf(l);
			GridPosition p;
			LuaObject.checkValueType<GridPosition>(l, 2, out p);
			float z;
			LuaObject.checkType(l, 3, out z);
			Vector3 o = arenaDefendMapUIController.m_luaExportHelper.GridPositionToWorldPosition(p, z);
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

	// Token: 0x0601ADB7 RID: 110007 RVA: 0x00807FD8 File Offset: 0x008061D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendMapUIController arenaDefendMapUIController = (ArenaDefendMapUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			arenaDefendMapUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ADB8 RID: 110008 RVA: 0x00808044 File Offset: 0x00806244
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendMapUIController arenaDefendMapUIController = (ArenaDefendMapUIController)LuaObject.checkSelf(l);
			arenaDefendMapUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ADB9 RID: 110009 RVA: 0x00808098 File Offset: 0x00806298
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendMapUIController arenaDefendMapUIController = (ArenaDefendMapUIController)LuaObject.checkSelf(l);
			arenaDefendMapUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ADBA RID: 110010 RVA: 0x008080EC File Offset: 0x008062EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendMapUIController arenaDefendMapUIController = (ArenaDefendMapUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = arenaDefendMapUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601ADBB RID: 110011 RVA: 0x00808194 File Offset: 0x00806394
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendMapUIController arenaDefendMapUIController = (ArenaDefendMapUIController)LuaObject.checkSelf(l);
			arenaDefendMapUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ADBC RID: 110012 RVA: 0x008081E8 File Offset: 0x008063E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendMapUIController arenaDefendMapUIController = (ArenaDefendMapUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			arenaDefendMapUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ADBD RID: 110013 RVA: 0x00808254 File Offset: 0x00806454
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
				ArenaDefendMapUIController arenaDefendMapUIController = (ArenaDefendMapUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				arenaDefendMapUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				ArenaDefendMapUIController arenaDefendMapUIController2 = (ArenaDefendMapUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				arenaDefendMapUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601ADBE RID: 110014 RVA: 0x00808364 File Offset: 0x00806564
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendMapUIController arenaDefendMapUIController = (ArenaDefendMapUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			arenaDefendMapUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ADBF RID: 110015 RVA: 0x008083D0 File Offset: 0x008065D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendMapUIController arenaDefendMapUIController = (ArenaDefendMapUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			arenaDefendMapUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ADC0 RID: 110016 RVA: 0x0080843C File Offset: 0x0080663C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendMapUIController arenaDefendMapUIController = (ArenaDefendMapUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			arenaDefendMapUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ADC1 RID: 110017 RVA: 0x008084A8 File Offset: 0x008066A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendMapUIController arenaDefendMapUIController = (ArenaDefendMapUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			arenaDefendMapUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ADC2 RID: 110018 RVA: 0x00808514 File Offset: 0x00806714
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
				ArenaDefendMapUIController arenaDefendMapUIController = (ArenaDefendMapUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				arenaDefendMapUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				ArenaDefendMapUIController arenaDefendMapUIController2 = (ArenaDefendMapUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				arenaDefendMapUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601ADC3 RID: 110019 RVA: 0x00808624 File Offset: 0x00806824
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendMapUIController arenaDefendMapUIController = (ArenaDefendMapUIController)LuaObject.checkSelf(l);
			string s = arenaDefendMapUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601ADC4 RID: 110020 RVA: 0x00808680 File Offset: 0x00806880
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddChildPrefab_s(IntPtr l)
	{
		int result;
		try
		{
			GameObject go;
			LuaObject.checkType<GameObject>(l, 1, out go);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			ArenaDefendMapUIController.LuaExportHelper.AddChildPrefab(go, assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ADC5 RID: 110021 RVA: 0x008086D8 File Offset: 0x008068D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_stagePosition0Pool(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendMapUIController arenaDefendMapUIController = (ArenaDefendMapUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaDefendMapUIController.m_luaExportHelper.m_stagePosition0Pool);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ADC6 RID: 110022 RVA: 0x00808730 File Offset: 0x00806930
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_stagePosition0Pool(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendMapUIController arenaDefendMapUIController = (ArenaDefendMapUIController)LuaObject.checkSelf(l);
			GameObjectPool stagePosition0Pool;
			LuaObject.checkType<GameObjectPool>(l, 2, out stagePosition0Pool);
			arenaDefendMapUIController.m_luaExportHelper.m_stagePosition0Pool = stagePosition0Pool;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ADC7 RID: 110023 RVA: 0x0080878C File Offset: 0x0080698C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_stagePosition1Pool(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendMapUIController arenaDefendMapUIController = (ArenaDefendMapUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaDefendMapUIController.m_luaExportHelper.m_stagePosition1Pool);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ADC8 RID: 110024 RVA: 0x008087E4 File Offset: 0x008069E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_stagePosition1Pool(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendMapUIController arenaDefendMapUIController = (ArenaDefendMapUIController)LuaObject.checkSelf(l);
			GameObjectPool stagePosition1Pool;
			LuaObject.checkType<GameObjectPool>(l, 2, out stagePosition1Pool);
			arenaDefendMapUIController.m_luaExportHelper.m_stagePosition1Pool = stagePosition1Pool;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ADC9 RID: 110025 RVA: 0x00808840 File Offset: 0x00806A40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_gridGameObject(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendMapUIController arenaDefendMapUIController = (ArenaDefendMapUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaDefendMapUIController.m_luaExportHelper.m_gridGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ADCA RID: 110026 RVA: 0x00808898 File Offset: 0x00806A98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_gridGameObject(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendMapUIController arenaDefendMapUIController = (ArenaDefendMapUIController)LuaObject.checkSelf(l);
			GameObject gridGameObject;
			LuaObject.checkType<GameObject>(l, 2, out gridGameObject);
			arenaDefendMapUIController.m_luaExportHelper.m_gridGameObject = gridGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ADCB RID: 110027 RVA: 0x008088F4 File Offset: 0x00806AF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_prefabsGameObject(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendMapUIController arenaDefendMapUIController = (ArenaDefendMapUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaDefendMapUIController.m_luaExportHelper.m_prefabsGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ADCC RID: 110028 RVA: 0x0080894C File Offset: 0x00806B4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_prefabsGameObject(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendMapUIController arenaDefendMapUIController = (ArenaDefendMapUIController)LuaObject.checkSelf(l);
			GameObject prefabsGameObject;
			LuaObject.checkType<GameObject>(l, 2, out prefabsGameObject);
			arenaDefendMapUIController.m_luaExportHelper.m_prefabsGameObject = prefabsGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ADCD RID: 110029 RVA: 0x008089A8 File Offset: 0x00806BA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_arenaDefendBattle(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendMapUIController arenaDefendMapUIController = (ArenaDefendMapUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaDefendMapUIController.m_luaExportHelper.m_arenaDefendBattle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ADCE RID: 110030 RVA: 0x00808A00 File Offset: 0x00806C00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_arenaDefendBattle(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendMapUIController arenaDefendMapUIController = (ArenaDefendMapUIController)LuaObject.checkSelf(l);
			ArenaDefendBattle arenaDefendBattle;
			LuaObject.checkType<ArenaDefendBattle>(l, 2, out arenaDefendBattle);
			arenaDefendMapUIController.m_luaExportHelper.m_arenaDefendBattle = arenaDefendBattle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ADCF RID: 110031 RVA: 0x00808A5C File Offset: 0x00806C5C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.ArenaDefendMapUIController");
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendMapUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendMapUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendMapUIController.Initialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendMapUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendMapUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendMapUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendMapUIController.ShowStagePosition);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendMapUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendMapUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendMapUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendMapUIController.ShowStageAttackerPosition);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendMapUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendMapUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendMapUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendMapUIController.HideStagePositions);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendMapUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendMapUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendMapUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendMapUIController.PlayOnStageFx);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendMapUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendMapUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendMapUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendMapUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendMapUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendMapUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendMapUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendMapUIController.StagePositionToWorldPosition);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendMapUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendMapUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendMapUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendMapUIController.GridPositionToWorldPosition);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendMapUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendMapUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendMapUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendMapUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendMapUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendMapUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendMapUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendMapUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendMapUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendMapUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendMapUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendMapUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendMapUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendMapUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendMapUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendMapUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendMapUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendMapUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendMapUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendMapUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendMapUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendMapUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendMapUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendMapUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendMapUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendMapUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendMapUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendMapUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendMapUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendMapUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendMapUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendMapUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendMapUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendMapUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendMapUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendMapUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendMapUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendMapUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendMapUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendMapUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendMapUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendMapUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendMapUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendMapUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendMapUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendMapUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendMapUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendMapUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendMapUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendMapUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendMapUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendMapUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendMapUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendMapUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendMapUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendMapUIController.AddChildPrefab_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendMapUIController.<>f__mg$cache15);
		string name = "m_stagePosition0Pool";
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendMapUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendMapUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendMapUIController.get_m_stagePosition0Pool);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_ArenaDefendMapUIController.<>f__mg$cache16;
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendMapUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendMapUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendMapUIController.set_m_stagePosition0Pool);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_ArenaDefendMapUIController.<>f__mg$cache17, true);
		string name2 = "m_stagePosition1Pool";
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendMapUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendMapUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendMapUIController.get_m_stagePosition1Pool);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_ArenaDefendMapUIController.<>f__mg$cache18;
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendMapUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendMapUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendMapUIController.set_m_stagePosition1Pool);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_ArenaDefendMapUIController.<>f__mg$cache19, true);
		string name3 = "m_gridGameObject";
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendMapUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendMapUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendMapUIController.get_m_gridGameObject);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_ArenaDefendMapUIController.<>f__mg$cache1A;
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendMapUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendMapUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendMapUIController.set_m_gridGameObject);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_ArenaDefendMapUIController.<>f__mg$cache1B, true);
		string name4 = "m_prefabsGameObject";
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendMapUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendMapUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendMapUIController.get_m_prefabsGameObject);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_ArenaDefendMapUIController.<>f__mg$cache1C;
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendMapUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendMapUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendMapUIController.set_m_prefabsGameObject);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_ArenaDefendMapUIController.<>f__mg$cache1D, true);
		string name5 = "m_arenaDefendBattle";
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendMapUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendMapUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendMapUIController.get_m_arenaDefendBattle);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_ArenaDefendMapUIController.<>f__mg$cache1E;
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendMapUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendMapUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendMapUIController.set_m_arenaDefendBattle);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_ArenaDefendMapUIController.<>f__mg$cache1F, true);
		LuaObject.createTypeMetatable(l, null, typeof(ArenaDefendMapUIController), typeof(UIControllerBase));
	}

	// Token: 0x040110B1 RID: 69809
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040110B2 RID: 69810
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040110B3 RID: 69811
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040110B4 RID: 69812
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040110B5 RID: 69813
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040110B6 RID: 69814
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040110B7 RID: 69815
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040110B8 RID: 69816
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x040110B9 RID: 69817
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x040110BA RID: 69818
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x040110BB RID: 69819
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x040110BC RID: 69820
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x040110BD RID: 69821
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x040110BE RID: 69822
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x040110BF RID: 69823
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x040110C0 RID: 69824
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x040110C1 RID: 69825
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x040110C2 RID: 69826
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x040110C3 RID: 69827
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x040110C4 RID: 69828
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x040110C5 RID: 69829
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x040110C6 RID: 69830
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x040110C7 RID: 69831
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x040110C8 RID: 69832
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x040110C9 RID: 69833
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x040110CA RID: 69834
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x040110CB RID: 69835
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x040110CC RID: 69836
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x040110CD RID: 69837
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x040110CE RID: 69838
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x040110CF RID: 69839
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x040110D0 RID: 69840
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;
}
