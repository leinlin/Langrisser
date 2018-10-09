using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Battle;
using BlackJack.ProjectL.Misc;
using BlackJack.ProjectL.Scene;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x02001399 RID: 5017
[Preserve]
public class Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController : LuaObject
{
	// Token: 0x0601B6CD RID: 112333 RVA: 0x0085089C File Offset: 0x0084EA9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Open(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			battleActorInfoUIController.Open();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B6CE RID: 112334 RVA: 0x008508E8 File Offset: 0x0084EAE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Close(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			battleActorInfoUIController.Close();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B6CF RID: 112335 RVA: 0x00850934 File Offset: 0x0084EB34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsOpened(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			bool b = battleActorInfoUIController.IsOpened();
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

	// Token: 0x0601B6D0 RID: 112336 RVA: 0x00850988 File Offset: 0x0084EB88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetActorInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			BattleActor a;
			LuaObject.checkType<BattleActor>(l, 2, out a);
			int myPlayerTeam;
			LuaObject.checkType(l, 3, out myPlayerTeam);
			battleActorInfoUIController.SetActorInfo(a, myPlayerTeam);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B6D1 RID: 112337 RVA: 0x008509EC File Offset: 0x0084EBEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnDisable(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			battleActorInfoUIController.m_luaExportHelper.OnDisable();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B6D2 RID: 112338 RVA: 0x00850A40 File Offset: 0x0084EC40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			battleActorInfoUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B6D3 RID: 112339 RVA: 0x00850A94 File Offset: 0x0084EC94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetSoldierDetailInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			BattleActor a;
			LuaObject.checkType<BattleActor>(l, 2, out a);
			ConfigDataSoldierInfo soldierInfo;
			LuaObject.checkType<ConfigDataSoldierInfo>(l, 3, out soldierInfo);
			int myPlayerTeam;
			LuaObject.checkType(l, 4, out myPlayerTeam);
			battleActorInfoUIController.m_luaExportHelper.SetSoldierDetailInfo(a, soldierInfo, myPlayerTeam);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B6D4 RID: 112340 RVA: 0x00850B0C File Offset: 0x0084ED0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CalcPropValue(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			int v;
			LuaObject.checkType(l, 2, out v);
			int v2;
			LuaObject.checkType(l, 3, out v2);
			bool isAdd;
			LuaObject.checkType(l, 4, out isAdd);
			string s = battleActorInfoUIController.m_luaExportHelper.CalcPropValue(v, v2, isAdd);
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

	// Token: 0x0601B6D5 RID: 112341 RVA: 0x00850B90 File Offset: 0x0084ED90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CreateSpineGraphic(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			float scale;
			LuaObject.checkType(l, 3, out scale);
			Vector2 offset;
			LuaObject.checkType(l, 4, out offset);
			GameObject parent;
			LuaObject.checkType<GameObject>(l, 5, out parent);
			List<ReplaceAnim> replaceAnims;
			LuaObject.checkType<List<ReplaceAnim>>(l, 6, out replaceAnims);
			UISpineGraphic o = battleActorInfoUIController.m_luaExportHelper.CreateSpineGraphic(assetName, scale, offset, parent, replaceAnims);
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

	// Token: 0x0601B6D6 RID: 112342 RVA: 0x00850C2C File Offset: 0x0084EE2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DestroySpineGraphic(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			UISpineGraphic g;
			LuaObject.checkType<UISpineGraphic>(l, 2, out g);
			battleActorInfoUIController.m_luaExportHelper.DestroySpineGraphic(g);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B6D7 RID: 112343 RVA: 0x00850C88 File Offset: 0x0084EE88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			battleActorInfoUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B6D8 RID: 112344 RVA: 0x00850CF4 File Offset: 0x0084EEF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			battleActorInfoUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B6D9 RID: 112345 RVA: 0x00850D48 File Offset: 0x0084EF48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			battleActorInfoUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B6DA RID: 112346 RVA: 0x00850D9C File Offset: 0x0084EF9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = battleActorInfoUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601B6DB RID: 112347 RVA: 0x00850E44 File Offset: 0x0084F044
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			battleActorInfoUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B6DC RID: 112348 RVA: 0x00850E98 File Offset: 0x0084F098
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			battleActorInfoUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B6DD RID: 112349 RVA: 0x00850F04 File Offset: 0x0084F104
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
				BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				battleActorInfoUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				BattleActorInfoUIController battleActorInfoUIController2 = (BattleActorInfoUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				battleActorInfoUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601B6DE RID: 112350 RVA: 0x00851014 File Offset: 0x0084F214
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			battleActorInfoUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B6DF RID: 112351 RVA: 0x00851080 File Offset: 0x0084F280
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			battleActorInfoUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B6E0 RID: 112352 RVA: 0x008510EC File Offset: 0x0084F2EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			battleActorInfoUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B6E1 RID: 112353 RVA: 0x00851158 File Offset: 0x0084F358
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			battleActorInfoUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B6E2 RID: 112354 RVA: 0x008511C4 File Offset: 0x0084F3C4
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
				BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				battleActorInfoUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				BattleActorInfoUIController battleActorInfoUIController2 = (BattleActorInfoUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				battleActorInfoUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601B6E3 RID: 112355 RVA: 0x008512D4 File Offset: 0x0084F4D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			string s = battleActorInfoUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601B6E4 RID: 112356 RVA: 0x00851330 File Offset: 0x0084F530
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiStateController(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActorInfoUIController.m_luaExportHelper.m_uiStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B6E5 RID: 112357 RVA: 0x00851388 File Offset: 0x0084F588
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiStateController(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			CommonUIStateController uiStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out uiStateController);
			battleActorInfoUIController.m_luaExportHelper.m_uiStateController = uiStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B6E6 RID: 112358 RVA: 0x008513E4 File Offset: 0x0084F5E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroNameText(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActorInfoUIController.m_luaExportHelper.m_heroNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B6E7 RID: 112359 RVA: 0x0085143C File Offset: 0x0084F63C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroNameText(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			Text heroNameText;
			LuaObject.checkType<Text>(l, 2, out heroNameText);
			battleActorInfoUIController.m_luaExportHelper.m_heroNameText = heroNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B6E8 RID: 112360 RVA: 0x00851498 File Offset: 0x0084F698
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroArmyText(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActorInfoUIController.m_luaExportHelper.m_heroArmyText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B6E9 RID: 112361 RVA: 0x008514F0 File Offset: 0x0084F6F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroArmyText(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			Text heroArmyText;
			LuaObject.checkType<Text>(l, 2, out heroArmyText);
			battleActorInfoUIController.m_luaExportHelper.m_heroArmyText = heroArmyText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B6EA RID: 112362 RVA: 0x0085154C File Offset: 0x0084F74C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroPanelGroupCtrl(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActorInfoUIController.m_luaExportHelper.m_heroPanelGroupCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B6EB RID: 112363 RVA: 0x008515A4 File Offset: 0x0084F7A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroPanelGroupCtrl(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			CommonUIStateController heroPanelGroupCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out heroPanelGroupCtrl);
			battleActorInfoUIController.m_luaExportHelper.m_heroPanelGroupCtrl = heroPanelGroupCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B6EC RID: 112364 RVA: 0x00851600 File Offset: 0x0084F800
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroIcon(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActorInfoUIController.m_luaExportHelper.m_heroIcon);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B6ED RID: 112365 RVA: 0x00851658 File Offset: 0x0084F858
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroIcon(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			Image heroIcon;
			LuaObject.checkType<Image>(l, 2, out heroIcon);
			battleActorInfoUIController.m_luaExportHelper.m_heroIcon = heroIcon;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B6EE RID: 112366 RVA: 0x008516B4 File Offset: 0x0084F8B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroArmyIcon(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActorInfoUIController.m_luaExportHelper.m_heroArmyIcon);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B6EF RID: 112367 RVA: 0x0085170C File Offset: 0x0084F90C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroArmyIcon(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			Image heroArmyIcon;
			LuaObject.checkType<Image>(l, 2, out heroArmyIcon);
			battleActorInfoUIController.m_luaExportHelper.m_heroArmyIcon = heroArmyIcon;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B6F0 RID: 112368 RVA: 0x00851768 File Offset: 0x0084F968
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroJobText(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActorInfoUIController.m_luaExportHelper.m_heroJobText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B6F1 RID: 112369 RVA: 0x008517C0 File Offset: 0x0084F9C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroJobText(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			Text heroJobText;
			LuaObject.checkType<Text>(l, 2, out heroJobText);
			battleActorInfoUIController.m_luaExportHelper.m_heroJobText = heroJobText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B6F2 RID: 112370 RVA: 0x0085181C File Offset: 0x0084FA1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroLevelText(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActorInfoUIController.m_luaExportHelper.m_heroLevelText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B6F3 RID: 112371 RVA: 0x00851874 File Offset: 0x0084FA74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroLevelText(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			Text heroLevelText;
			LuaObject.checkType<Text>(l, 2, out heroLevelText);
			battleActorInfoUIController.m_luaExportHelper.m_heroLevelText = heroLevelText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B6F4 RID: 112372 RVA: 0x008518D0 File Offset: 0x0084FAD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroHPText(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActorInfoUIController.m_luaExportHelper.m_heroHPText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B6F5 RID: 112373 RVA: 0x00851928 File Offset: 0x0084FB28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroHPText(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			Text heroHPText;
			LuaObject.checkType<Text>(l, 2, out heroHPText);
			battleActorInfoUIController.m_luaExportHelper.m_heroHPText = heroHPText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B6F6 RID: 112374 RVA: 0x00851984 File Offset: 0x0084FB84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroDEXText(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActorInfoUIController.m_luaExportHelper.m_heroDEXText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B6F7 RID: 112375 RVA: 0x008519DC File Offset: 0x0084FBDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroDEXText(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			Text heroDEXText;
			LuaObject.checkType<Text>(l, 2, out heroDEXText);
			battleActorInfoUIController.m_luaExportHelper.m_heroDEXText = heroDEXText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B6F8 RID: 112376 RVA: 0x00851A38 File Offset: 0x0084FC38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroHPImage(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActorInfoUIController.m_luaExportHelper.m_heroHPImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B6F9 RID: 112377 RVA: 0x00851A90 File Offset: 0x0084FC90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroHPImage(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			Image heroHPImage;
			LuaObject.checkType<Image>(l, 2, out heroHPImage);
			battleActorInfoUIController.m_luaExportHelper.m_heroHPImage = heroHPImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B6FA RID: 112378 RVA: 0x00851AEC File Offset: 0x0084FCEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroAttackText(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActorInfoUIController.m_luaExportHelper.m_heroAttackText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B6FB RID: 112379 RVA: 0x00851B44 File Offset: 0x0084FD44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroAttackText(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			Text heroAttackText;
			LuaObject.checkType<Text>(l, 2, out heroAttackText);
			battleActorInfoUIController.m_luaExportHelper.m_heroAttackText = heroAttackText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B6FC RID: 112380 RVA: 0x00851BA0 File Offset: 0x0084FDA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroDefenseText(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActorInfoUIController.m_luaExportHelper.m_heroDefenseText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B6FD RID: 112381 RVA: 0x00851BF8 File Offset: 0x0084FDF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroDefenseText(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			Text heroDefenseText;
			LuaObject.checkType<Text>(l, 2, out heroDefenseText);
			battleActorInfoUIController.m_luaExportHelper.m_heroDefenseText = heroDefenseText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B6FE RID: 112382 RVA: 0x00851C54 File Offset: 0x0084FE54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroMagicText(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActorInfoUIController.m_luaExportHelper.m_heroMagicText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B6FF RID: 112383 RVA: 0x00851CAC File Offset: 0x0084FEAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroMagicText(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			Text heroMagicText;
			LuaObject.checkType<Text>(l, 2, out heroMagicText);
			battleActorInfoUIController.m_luaExportHelper.m_heroMagicText = heroMagicText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B700 RID: 112384 RVA: 0x00851D08 File Offset: 0x0084FF08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroMagicDefenseText(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActorInfoUIController.m_luaExportHelper.m_heroMagicDefenseText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B701 RID: 112385 RVA: 0x00851D60 File Offset: 0x0084FF60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroMagicDefenseText(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			Text heroMagicDefenseText;
			LuaObject.checkType<Text>(l, 2, out heroMagicDefenseText);
			battleActorInfoUIController.m_luaExportHelper.m_heroMagicDefenseText = heroMagicDefenseText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B702 RID: 112386 RVA: 0x00851DBC File Offset: 0x0084FFBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroRangeText(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActorInfoUIController.m_luaExportHelper.m_heroRangeText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B703 RID: 112387 RVA: 0x00851E14 File Offset: 0x00850014
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroRangeText(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			Text heroRangeText;
			LuaObject.checkType<Text>(l, 2, out heroRangeText);
			battleActorInfoUIController.m_luaExportHelper.m_heroRangeText = heroRangeText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B704 RID: 112388 RVA: 0x00851E70 File Offset: 0x00850070
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroMoveText(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActorInfoUIController.m_luaExportHelper.m_heroMoveText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B705 RID: 112389 RVA: 0x00851EC8 File Offset: 0x008500C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroMoveText(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			Text heroMoveText;
			LuaObject.checkType<Text>(l, 2, out heroMoveText);
			battleActorInfoUIController.m_luaExportHelper.m_heroMoveText = heroMoveText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B706 RID: 112390 RVA: 0x00851F24 File Offset: 0x00850124
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActorInfoUIController.m_luaExportHelper.m_soldierGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B707 RID: 112391 RVA: 0x00851F7C File Offset: 0x0085017C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			GameObject soldierGameObject;
			LuaObject.checkType<GameObject>(l, 2, out soldierGameObject);
			battleActorInfoUIController.m_luaExportHelper.m_soldierGameObject = soldierGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B708 RID: 112392 RVA: 0x00851FD8 File Offset: 0x008501D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierNameText(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActorInfoUIController.m_luaExportHelper.m_soldierNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B709 RID: 112393 RVA: 0x00852030 File Offset: 0x00850230
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierNameText(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			Text soldierNameText;
			LuaObject.checkType<Text>(l, 2, out soldierNameText);
			battleActorInfoUIController.m_luaExportHelper.m_soldierNameText = soldierNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B70A RID: 112394 RVA: 0x0085208C File Offset: 0x0085028C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierArmyIcon(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActorInfoUIController.m_luaExportHelper.m_soldierArmyIcon);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B70B RID: 112395 RVA: 0x008520E4 File Offset: 0x008502E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierArmyIcon(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			Image soldierArmyIcon;
			LuaObject.checkType<Image>(l, 2, out soldierArmyIcon);
			battleActorInfoUIController.m_luaExportHelper.m_soldierArmyIcon = soldierArmyIcon;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B70C RID: 112396 RVA: 0x00852140 File Offset: 0x00850340
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierGraphicGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActorInfoUIController.m_luaExportHelper.m_soldierGraphicGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B70D RID: 112397 RVA: 0x00852198 File Offset: 0x00850398
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierGraphicGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			GameObject soldierGraphicGameObject;
			LuaObject.checkType<GameObject>(l, 2, out soldierGraphicGameObject);
			battleActorInfoUIController.m_luaExportHelper.m_soldierGraphicGameObject = soldierGraphicGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B70E RID: 112398 RVA: 0x008521F4 File Offset: 0x008503F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierHPImage(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActorInfoUIController.m_luaExportHelper.m_soldierHPImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B70F RID: 112399 RVA: 0x0085224C File Offset: 0x0085044C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierHPImage(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			Image soldierHPImage;
			LuaObject.checkType<Image>(l, 2, out soldierHPImage);
			battleActorInfoUIController.m_luaExportHelper.m_soldierHPImage = soldierHPImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B710 RID: 112400 RVA: 0x008522A8 File Offset: 0x008504A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierHPText(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActorInfoUIController.m_luaExportHelper.m_soldierHPText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B711 RID: 112401 RVA: 0x00852300 File Offset: 0x00850500
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierHPText(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			Text soldierHPText;
			LuaObject.checkType<Text>(l, 2, out soldierHPText);
			battleActorInfoUIController.m_luaExportHelper.m_soldierHPText = soldierHPText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B712 RID: 112402 RVA: 0x0085235C File Offset: 0x0085055C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierAttackText(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActorInfoUIController.m_luaExportHelper.m_soldierAttackText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B713 RID: 112403 RVA: 0x008523B4 File Offset: 0x008505B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierAttackText(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			Text soldierAttackText;
			LuaObject.checkType<Text>(l, 2, out soldierAttackText);
			battleActorInfoUIController.m_luaExportHelper.m_soldierAttackText = soldierAttackText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B714 RID: 112404 RVA: 0x00852410 File Offset: 0x00850610
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierDefenseText(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActorInfoUIController.m_luaExportHelper.m_soldierDefenseText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B715 RID: 112405 RVA: 0x00852468 File Offset: 0x00850668
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierDefenseText(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			Text soldierDefenseText;
			LuaObject.checkType<Text>(l, 2, out soldierDefenseText);
			battleActorInfoUIController.m_luaExportHelper.m_soldierDefenseText = soldierDefenseText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B716 RID: 112406 RVA: 0x008524C4 File Offset: 0x008506C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierMagicDFText(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActorInfoUIController.m_luaExportHelper.m_soldierMagicDFText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B717 RID: 112407 RVA: 0x0085251C File Offset: 0x0085071C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierMagicDFText(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			Text soldierMagicDFText;
			LuaObject.checkType<Text>(l, 2, out soldierMagicDFText);
			battleActorInfoUIController.m_luaExportHelper.m_soldierMagicDFText = soldierMagicDFText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B718 RID: 112408 RVA: 0x00852578 File Offset: 0x00850778
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierAttackAddText(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActorInfoUIController.m_luaExportHelper.m_soldierAttackAddText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B719 RID: 112409 RVA: 0x008525D0 File Offset: 0x008507D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierAttackAddText(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			Text soldierAttackAddText;
			LuaObject.checkType<Text>(l, 2, out soldierAttackAddText);
			battleActorInfoUIController.m_luaExportHelper.m_soldierAttackAddText = soldierAttackAddText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B71A RID: 112410 RVA: 0x0085262C File Offset: 0x0085082C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierDefenseAddText(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActorInfoUIController.m_luaExportHelper.m_soldierDefenseAddText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B71B RID: 112411 RVA: 0x00852684 File Offset: 0x00850884
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierDefenseAddText(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			Text soldierDefenseAddText;
			LuaObject.checkType<Text>(l, 2, out soldierDefenseAddText);
			battleActorInfoUIController.m_luaExportHelper.m_soldierDefenseAddText = soldierDefenseAddText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B71C RID: 112412 RVA: 0x008526E0 File Offset: 0x008508E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierMagicDFAddText(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActorInfoUIController.m_luaExportHelper.m_soldierMagicDFAddText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B71D RID: 112413 RVA: 0x00852738 File Offset: 0x00850938
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierMagicDFAddText(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			Text soldierMagicDFAddText;
			LuaObject.checkType<Text>(l, 2, out soldierMagicDFAddText);
			battleActorInfoUIController.m_luaExportHelper.m_soldierMagicDFAddText = soldierMagicDFAddText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B71E RID: 112414 RVA: 0x00852794 File Offset: 0x00850994
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_skillInfoButtonGo(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActorInfoUIController.m_luaExportHelper.m_skillInfoButtonGo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B71F RID: 112415 RVA: 0x008527EC File Offset: 0x008509EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_skillInfoButtonGo(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			Button skillInfoButtonGo;
			LuaObject.checkType<Button>(l, 2, out skillInfoButtonGo);
			battleActorInfoUIController.m_luaExportHelper.m_skillInfoButtonGo = skillInfoButtonGo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B720 RID: 112416 RVA: 0x00852848 File Offset: 0x00850A48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_skillInfoGroupTalentSkillImage(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActorInfoUIController.m_luaExportHelper.m_skillInfoGroupTalentSkillImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B721 RID: 112417 RVA: 0x008528A0 File Offset: 0x00850AA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_skillInfoGroupTalentSkillImage(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			Image skillInfoGroupTalentSkillImage;
			LuaObject.checkType<Image>(l, 2, out skillInfoGroupTalentSkillImage);
			battleActorInfoUIController.m_luaExportHelper.m_skillInfoGroupTalentSkillImage = skillInfoGroupTalentSkillImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B722 RID: 112418 RVA: 0x008528FC File Offset: 0x00850AFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_skillInfoGroupSkillGo(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActorInfoUIController.m_luaExportHelper.m_skillInfoGroupSkillGo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B723 RID: 112419 RVA: 0x00852954 File Offset: 0x00850B54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_skillInfoGroupSkillGo(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			GameObject skillInfoGroupSkillGo;
			LuaObject.checkType<GameObject>(l, 2, out skillInfoGroupSkillGo);
			battleActorInfoUIController.m_luaExportHelper.m_skillInfoGroupSkillGo = skillInfoGroupSkillGo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B724 RID: 112420 RVA: 0x008529B0 File Offset: 0x00850BB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_skillInfoGroupSkillGo2(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActorInfoUIController.m_luaExportHelper.m_skillInfoGroupSkillGo2);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B725 RID: 112421 RVA: 0x00852A08 File Offset: 0x00850C08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_skillInfoGroupSkillGo2(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			GameObject skillInfoGroupSkillGo;
			LuaObject.checkType<GameObject>(l, 2, out skillInfoGroupSkillGo);
			battleActorInfoUIController.m_luaExportHelper.m_skillInfoGroupSkillGo2 = skillInfoGroupSkillGo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B726 RID: 112422 RVA: 0x00852A64 File Offset: 0x00850C64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_skillInfoGroupSkillGo3(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActorInfoUIController.m_luaExportHelper.m_skillInfoGroupSkillGo3);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B727 RID: 112423 RVA: 0x00852ABC File Offset: 0x00850CBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_skillInfoGroupSkillGo3(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			GameObject skillInfoGroupSkillGo;
			LuaObject.checkType<GameObject>(l, 2, out skillInfoGroupSkillGo);
			battleActorInfoUIController.m_luaExportHelper.m_skillInfoGroupSkillGo3 = skillInfoGroupSkillGo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B728 RID: 112424 RVA: 0x00852B18 File Offset: 0x00850D18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_skillDetailPanel(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActorInfoUIController.m_luaExportHelper.m_skillDetailPanel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B729 RID: 112425 RVA: 0x00852B70 File Offset: 0x00850D70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_skillDetailPanel(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			GameObject skillDetailPanel;
			LuaObject.checkType<GameObject>(l, 2, out skillDetailPanel);
			battleActorInfoUIController.m_luaExportHelper.m_skillDetailPanel = skillDetailPanel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B72A RID: 112426 RVA: 0x00852BCC File Offset: 0x00850DCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_skillDetailListGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActorInfoUIController.m_luaExportHelper.m_skillDetailListGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B72B RID: 112427 RVA: 0x00852C24 File Offset: 0x00850E24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_skillDetailListGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			GameObject skillDetailListGameObject;
			LuaObject.checkType<GameObject>(l, 2, out skillDetailListGameObject);
			battleActorInfoUIController.m_luaExportHelper.m_skillDetailListGameObject = skillDetailListGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B72C RID: 112428 RVA: 0x00852C80 File Offset: 0x00850E80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_skillTalentGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActorInfoUIController.m_luaExportHelper.m_skillTalentGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B72D RID: 112429 RVA: 0x00852CD8 File Offset: 0x00850ED8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_skillTalentGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			GameObject skillTalentGameObject;
			LuaObject.checkType<GameObject>(l, 2, out skillTalentGameObject);
			battleActorInfoUIController.m_luaExportHelper.m_skillTalentGameObject = skillTalentGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B72E RID: 112430 RVA: 0x00852D34 File Offset: 0x00850F34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_skillTalentIcon(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActorInfoUIController.m_luaExportHelper.m_skillTalentIcon);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B72F RID: 112431 RVA: 0x00852D8C File Offset: 0x00850F8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_skillTalentIcon(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			Image skillTalentIcon;
			LuaObject.checkType<Image>(l, 2, out skillTalentIcon);
			battleActorInfoUIController.m_luaExportHelper.m_skillTalentIcon = skillTalentIcon;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B730 RID: 112432 RVA: 0x00852DE8 File Offset: 0x00850FE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_skillTalentNameText(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActorInfoUIController.m_luaExportHelper.m_skillTalentNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B731 RID: 112433 RVA: 0x00852E40 File Offset: 0x00851040
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_skillTalentNameText(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			Text skillTalentNameText;
			LuaObject.checkType<Text>(l, 2, out skillTalentNameText);
			battleActorInfoUIController.m_luaExportHelper.m_skillTalentNameText = skillTalentNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B732 RID: 112434 RVA: 0x00852E9C File Offset: 0x0085109C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_skillTalentDescText(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActorInfoUIController.m_luaExportHelper.m_skillTalentDescText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B733 RID: 112435 RVA: 0x00852EF4 File Offset: 0x008510F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_skillTalentDescText(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			Text skillTalentDescText;
			LuaObject.checkType<Text>(l, 2, out skillTalentDescText);
			battleActorInfoUIController.m_luaExportHelper.m_skillTalentDescText = skillTalentDescText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B734 RID: 112436 RVA: 0x00852F50 File Offset: 0x00851150
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_skillLineImage(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActorInfoUIController.m_luaExportHelper.m_skillLineImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B735 RID: 112437 RVA: 0x00852FA8 File Offset: 0x008511A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_skillLineImage(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			Image skillLineImage;
			LuaObject.checkType<Image>(l, 2, out skillLineImage);
			battleActorInfoUIController.m_luaExportHelper.m_skillLineImage = skillLineImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B736 RID: 112438 RVA: 0x00853004 File Offset: 0x00851204
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_skillListGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActorInfoUIController.m_luaExportHelper.m_skillListGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B737 RID: 112439 RVA: 0x0085305C File Offset: 0x0085125C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_skillListGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			GameObject skillListGameObject;
			LuaObject.checkType<GameObject>(l, 2, out skillListGameObject);
			battleActorInfoUIController.m_luaExportHelper.m_skillListGameObject = skillListGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B738 RID: 112440 RVA: 0x008530B8 File Offset: 0x008512B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_noSkillsAndTalentGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActorInfoUIController.m_luaExportHelper.m_noSkillsAndTalentGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B739 RID: 112441 RVA: 0x00853110 File Offset: 0x00851310
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_noSkillsAndTalentGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			GameObject noSkillsAndTalentGameObject;
			LuaObject.checkType<GameObject>(l, 2, out noSkillsAndTalentGameObject);
			battleActorInfoUIController.m_luaExportHelper.m_noSkillsAndTalentGameObject = noSkillsAndTalentGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B73A RID: 112442 RVA: 0x0085316C File Offset: 0x0085136C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_skillListContentGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActorInfoUIController.m_luaExportHelper.m_skillListContentGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B73B RID: 112443 RVA: 0x008531C4 File Offset: 0x008513C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_skillListContentGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			GameObject skillListContentGameObject;
			LuaObject.checkType<GameObject>(l, 2, out skillListContentGameObject);
			battleActorInfoUIController.m_luaExportHelper.m_skillListContentGameObject = skillListContentGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B73C RID: 112444 RVA: 0x00853220 File Offset: 0x00851420
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_debugBuffToggle(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActorInfoUIController.m_luaExportHelper.m_debugBuffToggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B73D RID: 112445 RVA: 0x00853278 File Offset: 0x00851478
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_debugBuffToggle(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			Toggle debugBuffToggle;
			LuaObject.checkType<Toggle>(l, 2, out debugBuffToggle);
			battleActorInfoUIController.m_luaExportHelper.m_debugBuffToggle = debugBuffToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B73E RID: 112446 RVA: 0x008532D4 File Offset: 0x008514D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_buffsListGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActorInfoUIController.m_luaExportHelper.m_buffsListGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B73F RID: 112447 RVA: 0x0085332C File Offset: 0x0085152C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_buffsListGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			Button buffsListGameObject;
			LuaObject.checkType<Button>(l, 2, out buffsListGameObject);
			battleActorInfoUIController.m_luaExportHelper.m_buffsListGameObject = buffsListGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B740 RID: 112448 RVA: 0x00853388 File Offset: 0x00851588
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_buffDescDetailGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActorInfoUIController.m_luaExportHelper.m_buffDescDetailGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B741 RID: 112449 RVA: 0x008533E0 File Offset: 0x008515E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_buffDescDetailGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			GameObject buffDescDetailGameObject;
			LuaObject.checkType<GameObject>(l, 2, out buffDescDetailGameObject);
			battleActorInfoUIController.m_luaExportHelper.m_buffDescDetailGameObject = buffDescDetailGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B742 RID: 112450 RVA: 0x0085343C File Offset: 0x0085163C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_buffsDescDetailListGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActorInfoUIController.m_luaExportHelper.m_buffsDescDetailListGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B743 RID: 112451 RVA: 0x00853494 File Offset: 0x00851694
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_buffsDescDetailListGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			GameObject buffsDescDetailListGameObject;
			LuaObject.checkType<GameObject>(l, 2, out buffsDescDetailListGameObject);
			battleActorInfoUIController.m_luaExportHelper.m_buffsDescDetailListGameObject = buffsDescDetailListGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B744 RID: 112452 RVA: 0x008534F0 File Offset: 0x008516F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_buffsDescContentGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActorInfoUIController.m_luaExportHelper.m_buffsDescContentGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B745 RID: 112453 RVA: 0x00853548 File Offset: 0x00851748
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_buffsDescContentGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			GameObject buffsDescContentGameObject;
			LuaObject.checkType<GameObject>(l, 2, out buffsDescContentGameObject);
			battleActorInfoUIController.m_luaExportHelper.m_buffsDescContentGameObject = buffsDescContentGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B746 RID: 112454 RVA: 0x008535A4 File Offset: 0x008517A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_noBuffsGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActorInfoUIController.m_luaExportHelper.m_noBuffsGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B747 RID: 112455 RVA: 0x008535FC File Offset: 0x008517FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_noBuffsGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			GameObject noBuffsGameObject;
			LuaObject.checkType<GameObject>(l, 2, out noBuffsGameObject);
			battleActorInfoUIController.m_luaExportHelper.m_noBuffsGameObject = noBuffsGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B748 RID: 112456 RVA: 0x00853658 File Offset: 0x00851858
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierDetailButton(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActorInfoUIController.m_luaExportHelper.m_soldierDetailButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B749 RID: 112457 RVA: 0x008536B0 File Offset: 0x008518B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierDetailButton(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			Button soldierDetailButton;
			LuaObject.checkType<Button>(l, 2, out soldierDetailButton);
			battleActorInfoUIController.m_luaExportHelper.m_soldierDetailButton = soldierDetailButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B74A RID: 112458 RVA: 0x0085370C File Offset: 0x0085190C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierDetailPanelUIStateController(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActorInfoUIController.m_luaExportHelper.m_soldierDetailPanelUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B74B RID: 112459 RVA: 0x00853764 File Offset: 0x00851964
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierDetailPanelUIStateController(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			CommonUIStateController soldierDetailPanelUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out soldierDetailPanelUIStateController);
			battleActorInfoUIController.m_luaExportHelper.m_soldierDetailPanelUIStateController = soldierDetailPanelUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B74C RID: 112460 RVA: 0x008537C0 File Offset: 0x008519C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierGraphicObj(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActorInfoUIController.m_luaExportHelper.m_soldierGraphicObj);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B74D RID: 112461 RVA: 0x00853818 File Offset: 0x00851A18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierGraphicObj(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			GameObject soldierGraphicObj;
			LuaObject.checkType<GameObject>(l, 2, out soldierGraphicObj);
			battleActorInfoUIController.m_luaExportHelper.m_soldierGraphicObj = soldierGraphicObj;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B74E RID: 112462 RVA: 0x00853874 File Offset: 0x00851A74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierIconImg(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActorInfoUIController.m_luaExportHelper.m_soldierIconImg);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B74F RID: 112463 RVA: 0x008538CC File Offset: 0x00851ACC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierIconImg(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			Image soldierIconImg;
			LuaObject.checkType<Image>(l, 2, out soldierIconImg);
			battleActorInfoUIController.m_luaExportHelper.m_soldierIconImg = soldierIconImg;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B750 RID: 112464 RVA: 0x00853928 File Offset: 0x00851B28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierTitleText(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActorInfoUIController.m_luaExportHelper.m_soldierTitleText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B751 RID: 112465 RVA: 0x00853980 File Offset: 0x00851B80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierTitleText(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			Text soldierTitleText;
			LuaObject.checkType<Text>(l, 2, out soldierTitleText);
			battleActorInfoUIController.m_luaExportHelper.m_soldierTitleText = soldierTitleText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B752 RID: 112466 RVA: 0x008539DC File Offset: 0x00851BDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierDescText(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActorInfoUIController.m_luaExportHelper.m_soldierDescText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B753 RID: 112467 RVA: 0x00853A34 File Offset: 0x00851C34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierDescText(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			Text soldierDescText;
			LuaObject.checkType<Text>(l, 2, out soldierDescText);
			battleActorInfoUIController.m_luaExportHelper.m_soldierDescText = soldierDescText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B754 RID: 112468 RVA: 0x00853A90 File Offset: 0x00851C90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierDescMeleeGo(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActorInfoUIController.m_luaExportHelper.m_soldierDescMeleeGo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B755 RID: 112469 RVA: 0x00853AE8 File Offset: 0x00851CE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierDescMeleeGo(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			GameObject soldierDescMeleeGo;
			LuaObject.checkType<GameObject>(l, 2, out soldierDescMeleeGo);
			battleActorInfoUIController.m_luaExportHelper.m_soldierDescMeleeGo = soldierDescMeleeGo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B756 RID: 112470 RVA: 0x00853B44 File Offset: 0x00851D44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierDescNotMeleeGo(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActorInfoUIController.m_luaExportHelper.m_soldierDescNotMeleeGo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B757 RID: 112471 RVA: 0x00853B9C File Offset: 0x00851D9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierDescNotMeleeGo(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			GameObject soldierDescNotMeleeGo;
			LuaObject.checkType<GameObject>(l, 2, out soldierDescNotMeleeGo);
			battleActorInfoUIController.m_luaExportHelper.m_soldierDescNotMeleeGo = soldierDescNotMeleeGo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B758 RID: 112472 RVA: 0x00853BF8 File Offset: 0x00851DF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierDescRangeValueText(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActorInfoUIController.m_luaExportHelper.m_soldierDescRangeValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B759 RID: 112473 RVA: 0x00853C50 File Offset: 0x00851E50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierDescRangeValueText(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			Text soldierDescRangeValueText;
			LuaObject.checkType<Text>(l, 2, out soldierDescRangeValueText);
			battleActorInfoUIController.m_luaExportHelper.m_soldierDescRangeValueText = soldierDescRangeValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B75A RID: 112474 RVA: 0x00853CAC File Offset: 0x00851EAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierDescMoveValueText(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActorInfoUIController.m_luaExportHelper.m_soldierDescMoveValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B75B RID: 112475 RVA: 0x00853D04 File Offset: 0x00851F04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierDescMoveValueText(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			Text soldierDescMoveValueText;
			LuaObject.checkType<Text>(l, 2, out soldierDescMoveValueText);
			battleActorInfoUIController.m_luaExportHelper.m_soldierDescMoveValueText = soldierDescMoveValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B75C RID: 112476 RVA: 0x00853D60 File Offset: 0x00851F60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierDescRestrainValueText(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActorInfoUIController.m_luaExportHelper.m_soldierDescRestrainValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B75D RID: 112477 RVA: 0x00853DB8 File Offset: 0x00851FB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierDescRestrainValueText(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			Text soldierDescRestrainValueText;
			LuaObject.checkType<Text>(l, 2, out soldierDescRestrainValueText);
			battleActorInfoUIController.m_luaExportHelper.m_soldierDescRestrainValueText = soldierDescRestrainValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B75E RID: 112478 RVA: 0x00853E14 File Offset: 0x00852014
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierDescWeakValueText(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActorInfoUIController.m_luaExportHelper.m_soldierDescWeakValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B75F RID: 112479 RVA: 0x00853E6C File Offset: 0x0085206C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierDescWeakValueText(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			Text soldierDescWeakValueText;
			LuaObject.checkType<Text>(l, 2, out soldierDescWeakValueText);
			battleActorInfoUIController.m_luaExportHelper.m_soldierDescWeakValueText = soldierDescWeakValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B760 RID: 112480 RVA: 0x00853EC8 File Offset: 0x008520C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierPropHPValueText(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActorInfoUIController.m_luaExportHelper.m_soldierPropHPValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B761 RID: 112481 RVA: 0x00853F20 File Offset: 0x00852120
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierPropHPValueText(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			Text soldierPropHPValueText;
			LuaObject.checkType<Text>(l, 2, out soldierPropHPValueText);
			battleActorInfoUIController.m_luaExportHelper.m_soldierPropHPValueText = soldierPropHPValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B762 RID: 112482 RVA: 0x00853F7C File Offset: 0x0085217C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierPropDFValueText(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActorInfoUIController.m_luaExportHelper.m_soldierPropDFValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B763 RID: 112483 RVA: 0x00853FD4 File Offset: 0x008521D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierPropDFValueText(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			Text soldierPropDFValueText;
			LuaObject.checkType<Text>(l, 2, out soldierPropDFValueText);
			battleActorInfoUIController.m_luaExportHelper.m_soldierPropDFValueText = soldierPropDFValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B764 RID: 112484 RVA: 0x00854030 File Offset: 0x00852230
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierPropATValueText(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActorInfoUIController.m_luaExportHelper.m_soldierPropATValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B765 RID: 112485 RVA: 0x00854088 File Offset: 0x00852288
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierPropATValueText(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			Text soldierPropATValueText;
			LuaObject.checkType<Text>(l, 2, out soldierPropATValueText);
			battleActorInfoUIController.m_luaExportHelper.m_soldierPropATValueText = soldierPropATValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B766 RID: 112486 RVA: 0x008540E4 File Offset: 0x008522E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierPropMagicDFValueText(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActorInfoUIController.m_luaExportHelper.m_soldierPropMagicDFValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B767 RID: 112487 RVA: 0x0085413C File Offset: 0x0085233C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierPropMagicDFValueText(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			Text soldierPropMagicDFValueText;
			LuaObject.checkType<Text>(l, 2, out soldierPropMagicDFValueText);
			battleActorInfoUIController.m_luaExportHelper.m_soldierPropMagicDFValueText = soldierPropMagicDFValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B768 RID: 112488 RVA: 0x00854198 File Offset: 0x00852398
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierPropHPAddText(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActorInfoUIController.m_luaExportHelper.m_soldierPropHPAddText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B769 RID: 112489 RVA: 0x008541F0 File Offset: 0x008523F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierPropHPAddText(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			Text soldierPropHPAddText;
			LuaObject.checkType<Text>(l, 2, out soldierPropHPAddText);
			battleActorInfoUIController.m_luaExportHelper.m_soldierPropHPAddText = soldierPropHPAddText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B76A RID: 112490 RVA: 0x0085424C File Offset: 0x0085244C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierPropDFAddText(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActorInfoUIController.m_luaExportHelper.m_soldierPropDFAddText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B76B RID: 112491 RVA: 0x008542A4 File Offset: 0x008524A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierPropDFAddText(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			Text soldierPropDFAddText;
			LuaObject.checkType<Text>(l, 2, out soldierPropDFAddText);
			battleActorInfoUIController.m_luaExportHelper.m_soldierPropDFAddText = soldierPropDFAddText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B76C RID: 112492 RVA: 0x00854300 File Offset: 0x00852500
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierPropATAddText(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActorInfoUIController.m_luaExportHelper.m_soldierPropATAddText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B76D RID: 112493 RVA: 0x00854358 File Offset: 0x00852558
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierPropATAddText(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			Text soldierPropATAddText;
			LuaObject.checkType<Text>(l, 2, out soldierPropATAddText);
			battleActorInfoUIController.m_luaExportHelper.m_soldierPropATAddText = soldierPropATAddText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B76E RID: 112494 RVA: 0x008543B4 File Offset: 0x008525B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierPropMagicDFAddText(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActorInfoUIController.m_luaExportHelper.m_soldierPropMagicDFAddText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B76F RID: 112495 RVA: 0x0085440C File Offset: 0x0085260C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierPropMagicDFAddText(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			Text soldierPropMagicDFAddText;
			LuaObject.checkType<Text>(l, 2, out soldierPropMagicDFAddText);
			battleActorInfoUIController.m_luaExportHelper.m_soldierPropMagicDFAddText = soldierPropMagicDFAddText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B770 RID: 112496 RVA: 0x00854468 File Offset: 0x00852668
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_prefabsGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActorInfoUIController.m_luaExportHelper.m_prefabsGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B771 RID: 112497 RVA: 0x008544C0 File Offset: 0x008526C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_prefabsGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			GameObject prefabsGameObject;
			LuaObject.checkType<GameObject>(l, 2, out prefabsGameObject);
			battleActorInfoUIController.m_luaExportHelper.m_prefabsGameObject = prefabsGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B772 RID: 112498 RVA: 0x0085451C File Offset: 0x0085271C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_buffDescPrefab(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActorInfoUIController.m_luaExportHelper.m_buffDescPrefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B773 RID: 112499 RVA: 0x00854574 File Offset: 0x00852774
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_buffDescPrefab(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			GameObject buffDescPrefab;
			LuaObject.checkType<GameObject>(l, 2, out buffDescPrefab);
			battleActorInfoUIController.m_luaExportHelper.m_buffDescPrefab = buffDescPrefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B774 RID: 112500 RVA: 0x008545D0 File Offset: 0x008527D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_skillDescPrefab(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActorInfoUIController.m_luaExportHelper.m_skillDescPrefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B775 RID: 112501 RVA: 0x00854628 File Offset: 0x00852828
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_skillDescPrefab(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			GameObject skillDescPrefab;
			LuaObject.checkType<GameObject>(l, 2, out skillDescPrefab);
			battleActorInfoUIController.m_luaExportHelper.m_skillDescPrefab = skillDescPrefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B776 RID: 112502 RVA: 0x00854684 File Offset: 0x00852884
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_buffIconPrefab(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActorInfoUIController.m_luaExportHelper.m_buffIconPrefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B777 RID: 112503 RVA: 0x008546DC File Offset: 0x008528DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_buffIconPrefab(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			GameObject buffIconPrefab;
			LuaObject.checkType<GameObject>(l, 2, out buffIconPrefab);
			battleActorInfoUIController.m_luaExportHelper.m_buffIconPrefab = buffIconPrefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B778 RID: 112504 RVA: 0x00854738 File Offset: 0x00852938
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_skillDescPool(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActorInfoUIController.m_luaExportHelper.m_skillDescPool);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B779 RID: 112505 RVA: 0x00854790 File Offset: 0x00852990
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_skillDescPool(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			GameObjectPool<SkillDesc> skillDescPool;
			LuaObject.checkType<GameObjectPool<SkillDesc>>(l, 2, out skillDescPool);
			battleActorInfoUIController.m_luaExportHelper.m_skillDescPool = skillDescPool;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B77A RID: 112506 RVA: 0x008547EC File Offset: 0x008529EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_buffDescPool(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActorInfoUIController.m_luaExportHelper.m_buffDescPool);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B77B RID: 112507 RVA: 0x00854844 File Offset: 0x00852A44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_buffDescPool(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			GameObjectPool<BuffDesc> buffDescPool;
			LuaObject.checkType<GameObjectPool<BuffDesc>>(l, 2, out buffDescPool);
			battleActorInfoUIController.m_luaExportHelper.m_buffDescPool = buffDescPool;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B77C RID: 112508 RVA: 0x008548A0 File Offset: 0x00852AA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierGraphic(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActorInfoUIController.m_luaExportHelper.m_soldierGraphic);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B77D RID: 112509 RVA: 0x008548F8 File Offset: 0x00852AF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierGraphic(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			UISpineGraphic soldierGraphic;
			LuaObject.checkType<UISpineGraphic>(l, 2, out soldierGraphic);
			battleActorInfoUIController.m_luaExportHelper.m_soldierGraphic = soldierGraphic;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B77E RID: 112510 RVA: 0x00854954 File Offset: 0x00852B54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierDetailGraphic(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActorInfoUIController.m_luaExportHelper.m_soldierDetailGraphic);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B77F RID: 112511 RVA: 0x008549AC File Offset: 0x00852BAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierDetailGraphic(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			UISpineGraphic soldierDetailGraphic;
			LuaObject.checkType<UISpineGraphic>(l, 2, out soldierDetailGraphic);
			battleActorInfoUIController.m_luaExportHelper.m_soldierDetailGraphic = soldierDetailGraphic;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B780 RID: 112512 RVA: 0x00854A08 File Offset: 0x00852C08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isOpened(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActorInfoUIController.m_luaExportHelper.m_isOpened);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B781 RID: 112513 RVA: 0x00854A60 File Offset: 0x00852C60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isOpened(IntPtr l)
	{
		int result;
		try
		{
			BattleActorInfoUIController battleActorInfoUIController = (BattleActorInfoUIController)LuaObject.checkSelf(l);
			bool isOpened;
			LuaObject.checkType(l, 2, out isOpened);
			battleActorInfoUIController.m_luaExportHelper.m_isOpened = isOpened;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B782 RID: 112514 RVA: 0x00854ABC File Offset: 0x00852CBC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.BattleActorInfoUIController");
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.Open);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.Close);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.IsOpened);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.SetActorInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.OnDisable);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.SetSoldierDetailInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.CalcPropValue);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.CreateSpineGraphic);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.DestroySpineGraphic);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache16);
		string name = "m_uiStateController";
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.get_m_uiStateController);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache17;
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.set_m_uiStateController);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache18, true);
		string name2 = "m_heroNameText";
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.get_m_heroNameText);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache19;
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.set_m_heroNameText);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache1A, true);
		string name3 = "m_heroArmyText";
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.get_m_heroArmyText);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache1B;
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.set_m_heroArmyText);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache1C, true);
		string name4 = "m_heroPanelGroupCtrl";
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.get_m_heroPanelGroupCtrl);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache1D;
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.set_m_heroPanelGroupCtrl);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache1E, true);
		string name5 = "m_heroIcon";
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.get_m_heroIcon);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache1F;
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.set_m_heroIcon);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache20, true);
		string name6 = "m_heroArmyIcon";
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.get_m_heroArmyIcon);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache21;
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.set_m_heroArmyIcon);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache22, true);
		string name7 = "m_heroJobText";
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.get_m_heroJobText);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache23;
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.set_m_heroJobText);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache24, true);
		string name8 = "m_heroLevelText";
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.get_m_heroLevelText);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache25;
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.set_m_heroLevelText);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache26, true);
		string name9 = "m_heroHPText";
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.get_m_heroHPText);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache27;
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.set_m_heroHPText);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache28, true);
		string name10 = "m_heroDEXText";
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.get_m_heroDEXText);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache29;
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.set_m_heroDEXText);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache2A, true);
		string name11 = "m_heroHPImage";
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.get_m_heroHPImage);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache2B;
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.set_m_heroHPImage);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache2C, true);
		string name12 = "m_heroAttackText";
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.get_m_heroAttackText);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache2D;
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.set_m_heroAttackText);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache2E, true);
		string name13 = "m_heroDefenseText";
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.get_m_heroDefenseText);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache2F;
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.set_m_heroDefenseText);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache30, true);
		string name14 = "m_heroMagicText";
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.get_m_heroMagicText);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache31;
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.set_m_heroMagicText);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache32, true);
		string name15 = "m_heroMagicDefenseText";
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.get_m_heroMagicDefenseText);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache33;
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.set_m_heroMagicDefenseText);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache34, true);
		string name16 = "m_heroRangeText";
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.get_m_heroRangeText);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache35;
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.set_m_heroRangeText);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache36, true);
		string name17 = "m_heroMoveText";
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.get_m_heroMoveText);
		}
		LuaCSFunction get17 = Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache37;
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.set_m_heroMoveText);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache38, true);
		string name18 = "m_soldierGameObject";
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.get_m_soldierGameObject);
		}
		LuaCSFunction get18 = Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache39;
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.set_m_soldierGameObject);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache3A, true);
		string name19 = "m_soldierNameText";
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.get_m_soldierNameText);
		}
		LuaCSFunction get19 = Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache3B;
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.set_m_soldierNameText);
		}
		LuaObject.addMember(l, name19, get19, Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache3C, true);
		string name20 = "m_soldierArmyIcon";
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.get_m_soldierArmyIcon);
		}
		LuaCSFunction get20 = Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache3D;
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.set_m_soldierArmyIcon);
		}
		LuaObject.addMember(l, name20, get20, Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache3E, true);
		string name21 = "m_soldierGraphicGameObject";
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.get_m_soldierGraphicGameObject);
		}
		LuaCSFunction get21 = Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache3F;
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.set_m_soldierGraphicGameObject);
		}
		LuaObject.addMember(l, name21, get21, Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache40, true);
		string name22 = "m_soldierHPImage";
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.get_m_soldierHPImage);
		}
		LuaCSFunction get22 = Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache41;
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.set_m_soldierHPImage);
		}
		LuaObject.addMember(l, name22, get22, Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache42, true);
		string name23 = "m_soldierHPText";
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.get_m_soldierHPText);
		}
		LuaCSFunction get23 = Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache43;
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.set_m_soldierHPText);
		}
		LuaObject.addMember(l, name23, get23, Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache44, true);
		string name24 = "m_soldierAttackText";
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.get_m_soldierAttackText);
		}
		LuaCSFunction get24 = Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache45;
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache46 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache46 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.set_m_soldierAttackText);
		}
		LuaObject.addMember(l, name24, get24, Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache46, true);
		string name25 = "m_soldierDefenseText";
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache47 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache47 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.get_m_soldierDefenseText);
		}
		LuaCSFunction get25 = Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache47;
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache48 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache48 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.set_m_soldierDefenseText);
		}
		LuaObject.addMember(l, name25, get25, Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache48, true);
		string name26 = "m_soldierMagicDFText";
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache49 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache49 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.get_m_soldierMagicDFText);
		}
		LuaCSFunction get26 = Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache49;
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache4A == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache4A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.set_m_soldierMagicDFText);
		}
		LuaObject.addMember(l, name26, get26, Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache4A, true);
		string name27 = "m_soldierAttackAddText";
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache4B == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache4B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.get_m_soldierAttackAddText);
		}
		LuaCSFunction get27 = Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache4B;
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache4C == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache4C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.set_m_soldierAttackAddText);
		}
		LuaObject.addMember(l, name27, get27, Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache4C, true);
		string name28 = "m_soldierDefenseAddText";
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache4D == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache4D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.get_m_soldierDefenseAddText);
		}
		LuaCSFunction get28 = Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache4D;
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache4E == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache4E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.set_m_soldierDefenseAddText);
		}
		LuaObject.addMember(l, name28, get28, Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache4E, true);
		string name29 = "m_soldierMagicDFAddText";
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache4F == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache4F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.get_m_soldierMagicDFAddText);
		}
		LuaCSFunction get29 = Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache4F;
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache50 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache50 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.set_m_soldierMagicDFAddText);
		}
		LuaObject.addMember(l, name29, get29, Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache50, true);
		string name30 = "m_skillInfoButtonGo";
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache51 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache51 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.get_m_skillInfoButtonGo);
		}
		LuaCSFunction get30 = Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache51;
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache52 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache52 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.set_m_skillInfoButtonGo);
		}
		LuaObject.addMember(l, name30, get30, Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache52, true);
		string name31 = "m_skillInfoGroupTalentSkillImage";
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache53 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache53 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.get_m_skillInfoGroupTalentSkillImage);
		}
		LuaCSFunction get31 = Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache53;
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache54 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache54 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.set_m_skillInfoGroupTalentSkillImage);
		}
		LuaObject.addMember(l, name31, get31, Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache54, true);
		string name32 = "m_skillInfoGroupSkillGo";
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache55 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache55 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.get_m_skillInfoGroupSkillGo);
		}
		LuaCSFunction get32 = Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache55;
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache56 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache56 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.set_m_skillInfoGroupSkillGo);
		}
		LuaObject.addMember(l, name32, get32, Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache56, true);
		string name33 = "m_skillInfoGroupSkillGo2";
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache57 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache57 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.get_m_skillInfoGroupSkillGo2);
		}
		LuaCSFunction get33 = Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache57;
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache58 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache58 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.set_m_skillInfoGroupSkillGo2);
		}
		LuaObject.addMember(l, name33, get33, Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache58, true);
		string name34 = "m_skillInfoGroupSkillGo3";
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache59 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache59 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.get_m_skillInfoGroupSkillGo3);
		}
		LuaCSFunction get34 = Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache59;
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache5A == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache5A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.set_m_skillInfoGroupSkillGo3);
		}
		LuaObject.addMember(l, name34, get34, Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache5A, true);
		string name35 = "m_skillDetailPanel";
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache5B == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache5B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.get_m_skillDetailPanel);
		}
		LuaCSFunction get35 = Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache5B;
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache5C == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache5C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.set_m_skillDetailPanel);
		}
		LuaObject.addMember(l, name35, get35, Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache5C, true);
		string name36 = "m_skillDetailListGameObject";
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache5D == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache5D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.get_m_skillDetailListGameObject);
		}
		LuaCSFunction get36 = Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache5D;
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache5E == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache5E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.set_m_skillDetailListGameObject);
		}
		LuaObject.addMember(l, name36, get36, Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache5E, true);
		string name37 = "m_skillTalentGameObject";
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache5F == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache5F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.get_m_skillTalentGameObject);
		}
		LuaCSFunction get37 = Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache5F;
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache60 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache60 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.set_m_skillTalentGameObject);
		}
		LuaObject.addMember(l, name37, get37, Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache60, true);
		string name38 = "m_skillTalentIcon";
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache61 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache61 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.get_m_skillTalentIcon);
		}
		LuaCSFunction get38 = Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache61;
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache62 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache62 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.set_m_skillTalentIcon);
		}
		LuaObject.addMember(l, name38, get38, Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache62, true);
		string name39 = "m_skillTalentNameText";
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache63 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache63 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.get_m_skillTalentNameText);
		}
		LuaCSFunction get39 = Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache63;
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache64 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache64 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.set_m_skillTalentNameText);
		}
		LuaObject.addMember(l, name39, get39, Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache64, true);
		string name40 = "m_skillTalentDescText";
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache65 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache65 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.get_m_skillTalentDescText);
		}
		LuaCSFunction get40 = Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache65;
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache66 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache66 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.set_m_skillTalentDescText);
		}
		LuaObject.addMember(l, name40, get40, Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache66, true);
		string name41 = "m_skillLineImage";
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache67 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache67 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.get_m_skillLineImage);
		}
		LuaCSFunction get41 = Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache67;
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache68 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache68 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.set_m_skillLineImage);
		}
		LuaObject.addMember(l, name41, get41, Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache68, true);
		string name42 = "m_skillListGameObject";
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache69 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache69 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.get_m_skillListGameObject);
		}
		LuaCSFunction get42 = Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache69;
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache6A == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache6A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.set_m_skillListGameObject);
		}
		LuaObject.addMember(l, name42, get42, Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache6A, true);
		string name43 = "m_noSkillsAndTalentGameObject";
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache6B == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache6B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.get_m_noSkillsAndTalentGameObject);
		}
		LuaCSFunction get43 = Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache6B;
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache6C == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache6C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.set_m_noSkillsAndTalentGameObject);
		}
		LuaObject.addMember(l, name43, get43, Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache6C, true);
		string name44 = "m_skillListContentGameObject";
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache6D == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache6D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.get_m_skillListContentGameObject);
		}
		LuaCSFunction get44 = Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache6D;
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache6E == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache6E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.set_m_skillListContentGameObject);
		}
		LuaObject.addMember(l, name44, get44, Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache6E, true);
		string name45 = "m_debugBuffToggle";
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache6F == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache6F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.get_m_debugBuffToggle);
		}
		LuaCSFunction get45 = Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache6F;
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache70 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache70 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.set_m_debugBuffToggle);
		}
		LuaObject.addMember(l, name45, get45, Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache70, true);
		string name46 = "m_buffsListGameObject";
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache71 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache71 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.get_m_buffsListGameObject);
		}
		LuaCSFunction get46 = Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache71;
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache72 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache72 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.set_m_buffsListGameObject);
		}
		LuaObject.addMember(l, name46, get46, Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache72, true);
		string name47 = "m_buffDescDetailGameObject";
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache73 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache73 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.get_m_buffDescDetailGameObject);
		}
		LuaCSFunction get47 = Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache73;
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache74 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache74 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.set_m_buffDescDetailGameObject);
		}
		LuaObject.addMember(l, name47, get47, Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache74, true);
		string name48 = "m_buffsDescDetailListGameObject";
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache75 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache75 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.get_m_buffsDescDetailListGameObject);
		}
		LuaCSFunction get48 = Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache75;
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache76 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache76 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.set_m_buffsDescDetailListGameObject);
		}
		LuaObject.addMember(l, name48, get48, Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache76, true);
		string name49 = "m_buffsDescContentGameObject";
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache77 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache77 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.get_m_buffsDescContentGameObject);
		}
		LuaCSFunction get49 = Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache77;
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache78 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache78 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.set_m_buffsDescContentGameObject);
		}
		LuaObject.addMember(l, name49, get49, Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache78, true);
		string name50 = "m_noBuffsGameObject";
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache79 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache79 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.get_m_noBuffsGameObject);
		}
		LuaCSFunction get50 = Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache79;
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache7A == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache7A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.set_m_noBuffsGameObject);
		}
		LuaObject.addMember(l, name50, get50, Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache7A, true);
		string name51 = "m_soldierDetailButton";
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache7B == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache7B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.get_m_soldierDetailButton);
		}
		LuaCSFunction get51 = Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache7B;
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache7C == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache7C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.set_m_soldierDetailButton);
		}
		LuaObject.addMember(l, name51, get51, Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache7C, true);
		string name52 = "m_soldierDetailPanelUIStateController";
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache7D == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache7D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.get_m_soldierDetailPanelUIStateController);
		}
		LuaCSFunction get52 = Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache7D;
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache7E == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache7E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.set_m_soldierDetailPanelUIStateController);
		}
		LuaObject.addMember(l, name52, get52, Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache7E, true);
		string name53 = "m_soldierGraphicObj";
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache7F == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache7F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.get_m_soldierGraphicObj);
		}
		LuaCSFunction get53 = Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache7F;
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache80 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache80 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.set_m_soldierGraphicObj);
		}
		LuaObject.addMember(l, name53, get53, Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache80, true);
		string name54 = "m_soldierIconImg";
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache81 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache81 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.get_m_soldierIconImg);
		}
		LuaCSFunction get54 = Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache81;
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache82 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache82 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.set_m_soldierIconImg);
		}
		LuaObject.addMember(l, name54, get54, Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache82, true);
		string name55 = "m_soldierTitleText";
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache83 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache83 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.get_m_soldierTitleText);
		}
		LuaCSFunction get55 = Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache83;
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache84 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache84 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.set_m_soldierTitleText);
		}
		LuaObject.addMember(l, name55, get55, Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache84, true);
		string name56 = "m_soldierDescText";
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache85 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache85 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.get_m_soldierDescText);
		}
		LuaCSFunction get56 = Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache85;
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache86 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache86 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.set_m_soldierDescText);
		}
		LuaObject.addMember(l, name56, get56, Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache86, true);
		string name57 = "m_soldierDescMeleeGo";
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache87 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache87 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.get_m_soldierDescMeleeGo);
		}
		LuaCSFunction get57 = Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache87;
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache88 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache88 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.set_m_soldierDescMeleeGo);
		}
		LuaObject.addMember(l, name57, get57, Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache88, true);
		string name58 = "m_soldierDescNotMeleeGo";
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache89 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache89 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.get_m_soldierDescNotMeleeGo);
		}
		LuaCSFunction get58 = Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache89;
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache8A == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache8A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.set_m_soldierDescNotMeleeGo);
		}
		LuaObject.addMember(l, name58, get58, Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache8A, true);
		string name59 = "m_soldierDescRangeValueText";
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache8B == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache8B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.get_m_soldierDescRangeValueText);
		}
		LuaCSFunction get59 = Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache8B;
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache8C == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache8C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.set_m_soldierDescRangeValueText);
		}
		LuaObject.addMember(l, name59, get59, Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache8C, true);
		string name60 = "m_soldierDescMoveValueText";
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache8D == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache8D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.get_m_soldierDescMoveValueText);
		}
		LuaCSFunction get60 = Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache8D;
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache8E == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache8E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.set_m_soldierDescMoveValueText);
		}
		LuaObject.addMember(l, name60, get60, Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache8E, true);
		string name61 = "m_soldierDescRestrainValueText";
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache8F == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache8F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.get_m_soldierDescRestrainValueText);
		}
		LuaCSFunction get61 = Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache8F;
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache90 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache90 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.set_m_soldierDescRestrainValueText);
		}
		LuaObject.addMember(l, name61, get61, Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache90, true);
		string name62 = "m_soldierDescWeakValueText";
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache91 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache91 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.get_m_soldierDescWeakValueText);
		}
		LuaCSFunction get62 = Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache91;
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache92 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache92 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.set_m_soldierDescWeakValueText);
		}
		LuaObject.addMember(l, name62, get62, Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache92, true);
		string name63 = "m_soldierPropHPValueText";
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache93 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache93 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.get_m_soldierPropHPValueText);
		}
		LuaCSFunction get63 = Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache93;
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache94 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache94 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.set_m_soldierPropHPValueText);
		}
		LuaObject.addMember(l, name63, get63, Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache94, true);
		string name64 = "m_soldierPropDFValueText";
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache95 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache95 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.get_m_soldierPropDFValueText);
		}
		LuaCSFunction get64 = Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache95;
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache96 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache96 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.set_m_soldierPropDFValueText);
		}
		LuaObject.addMember(l, name64, get64, Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache96, true);
		string name65 = "m_soldierPropATValueText";
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache97 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache97 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.get_m_soldierPropATValueText);
		}
		LuaCSFunction get65 = Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache97;
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache98 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache98 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.set_m_soldierPropATValueText);
		}
		LuaObject.addMember(l, name65, get65, Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache98, true);
		string name66 = "m_soldierPropMagicDFValueText";
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache99 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache99 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.get_m_soldierPropMagicDFValueText);
		}
		LuaCSFunction get66 = Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache99;
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache9A == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache9A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.set_m_soldierPropMagicDFValueText);
		}
		LuaObject.addMember(l, name66, get66, Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache9A, true);
		string name67 = "m_soldierPropHPAddText";
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache9B == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache9B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.get_m_soldierPropHPAddText);
		}
		LuaCSFunction get67 = Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache9B;
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache9C == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache9C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.set_m_soldierPropHPAddText);
		}
		LuaObject.addMember(l, name67, get67, Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache9C, true);
		string name68 = "m_soldierPropDFAddText";
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache9D == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache9D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.get_m_soldierPropDFAddText);
		}
		LuaCSFunction get68 = Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache9D;
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache9E == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache9E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.set_m_soldierPropDFAddText);
		}
		LuaObject.addMember(l, name68, get68, Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache9E, true);
		string name69 = "m_soldierPropATAddText";
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache9F == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache9F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.get_m_soldierPropATAddText);
		}
		LuaCSFunction get69 = Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cache9F;
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cacheA0 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cacheA0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.set_m_soldierPropATAddText);
		}
		LuaObject.addMember(l, name69, get69, Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cacheA0, true);
		string name70 = "m_soldierPropMagicDFAddText";
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cacheA1 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cacheA1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.get_m_soldierPropMagicDFAddText);
		}
		LuaCSFunction get70 = Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cacheA1;
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cacheA2 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cacheA2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.set_m_soldierPropMagicDFAddText);
		}
		LuaObject.addMember(l, name70, get70, Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cacheA2, true);
		string name71 = "m_prefabsGameObject";
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cacheA3 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cacheA3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.get_m_prefabsGameObject);
		}
		LuaCSFunction get71 = Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cacheA3;
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cacheA4 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cacheA4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.set_m_prefabsGameObject);
		}
		LuaObject.addMember(l, name71, get71, Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cacheA4, true);
		string name72 = "m_buffDescPrefab";
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cacheA5 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cacheA5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.get_m_buffDescPrefab);
		}
		LuaCSFunction get72 = Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cacheA5;
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cacheA6 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cacheA6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.set_m_buffDescPrefab);
		}
		LuaObject.addMember(l, name72, get72, Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cacheA6, true);
		string name73 = "m_skillDescPrefab";
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cacheA7 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cacheA7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.get_m_skillDescPrefab);
		}
		LuaCSFunction get73 = Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cacheA7;
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cacheA8 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cacheA8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.set_m_skillDescPrefab);
		}
		LuaObject.addMember(l, name73, get73, Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cacheA8, true);
		string name74 = "m_buffIconPrefab";
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cacheA9 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cacheA9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.get_m_buffIconPrefab);
		}
		LuaCSFunction get74 = Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cacheA9;
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cacheAA == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cacheAA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.set_m_buffIconPrefab);
		}
		LuaObject.addMember(l, name74, get74, Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cacheAA, true);
		string name75 = "m_skillDescPool";
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cacheAB == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cacheAB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.get_m_skillDescPool);
		}
		LuaCSFunction get75 = Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cacheAB;
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cacheAC == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cacheAC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.set_m_skillDescPool);
		}
		LuaObject.addMember(l, name75, get75, Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cacheAC, true);
		string name76 = "m_buffDescPool";
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cacheAD == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cacheAD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.get_m_buffDescPool);
		}
		LuaCSFunction get76 = Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cacheAD;
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cacheAE == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cacheAE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.set_m_buffDescPool);
		}
		LuaObject.addMember(l, name76, get76, Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cacheAE, true);
		string name77 = "m_soldierGraphic";
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cacheAF == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cacheAF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.get_m_soldierGraphic);
		}
		LuaCSFunction get77 = Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cacheAF;
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cacheB0 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cacheB0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.set_m_soldierGraphic);
		}
		LuaObject.addMember(l, name77, get77, Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cacheB0, true);
		string name78 = "m_soldierDetailGraphic";
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cacheB1 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cacheB1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.get_m_soldierDetailGraphic);
		}
		LuaCSFunction get78 = Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cacheB1;
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cacheB2 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cacheB2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.set_m_soldierDetailGraphic);
		}
		LuaObject.addMember(l, name78, get78, Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cacheB2, true);
		string name79 = "m_isOpened";
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cacheB3 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cacheB3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.get_m_isOpened);
		}
		LuaCSFunction get79 = Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cacheB3;
		if (Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cacheB4 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cacheB4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.set_m_isOpened);
		}
		LuaObject.addMember(l, name79, get79, Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.<>f__mg$cacheB4, true);
		LuaObject.createTypeMetatable(l, null, typeof(BattleActorInfoUIController), typeof(UIControllerBase));
	}

	// Token: 0x0401197D RID: 72061
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0401197E RID: 72062
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0401197F RID: 72063
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04011980 RID: 72064
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04011981 RID: 72065
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04011982 RID: 72066
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04011983 RID: 72067
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04011984 RID: 72068
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04011985 RID: 72069
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04011986 RID: 72070
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04011987 RID: 72071
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04011988 RID: 72072
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04011989 RID: 72073
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0401198A RID: 72074
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0401198B RID: 72075
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0401198C RID: 72076
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0401198D RID: 72077
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0401198E RID: 72078
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0401198F RID: 72079
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04011990 RID: 72080
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04011991 RID: 72081
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04011992 RID: 72082
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04011993 RID: 72083
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04011994 RID: 72084
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04011995 RID: 72085
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04011996 RID: 72086
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04011997 RID: 72087
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04011998 RID: 72088
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04011999 RID: 72089
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0401199A RID: 72090
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0401199B RID: 72091
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0401199C RID: 72092
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0401199D RID: 72093
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0401199E RID: 72094
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0401199F RID: 72095
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x040119A0 RID: 72096
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x040119A1 RID: 72097
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x040119A2 RID: 72098
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x040119A3 RID: 72099
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x040119A4 RID: 72100
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x040119A5 RID: 72101
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x040119A6 RID: 72102
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x040119A7 RID: 72103
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x040119A8 RID: 72104
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x040119A9 RID: 72105
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x040119AA RID: 72106
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x040119AB RID: 72107
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x040119AC RID: 72108
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x040119AD RID: 72109
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x040119AE RID: 72110
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x040119AF RID: 72111
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x040119B0 RID: 72112
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x040119B1 RID: 72113
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x040119B2 RID: 72114
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x040119B3 RID: 72115
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x040119B4 RID: 72116
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x040119B5 RID: 72117
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x040119B6 RID: 72118
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x040119B7 RID: 72119
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x040119B8 RID: 72120
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x040119B9 RID: 72121
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x040119BA RID: 72122
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x040119BB RID: 72123
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x040119BC RID: 72124
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x040119BD RID: 72125
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x040119BE RID: 72126
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x040119BF RID: 72127
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x040119C0 RID: 72128
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x040119C1 RID: 72129
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x040119C2 RID: 72130
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x040119C3 RID: 72131
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;

	// Token: 0x040119C4 RID: 72132
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache47;

	// Token: 0x040119C5 RID: 72133
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache48;

	// Token: 0x040119C6 RID: 72134
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache49;

	// Token: 0x040119C7 RID: 72135
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4A;

	// Token: 0x040119C8 RID: 72136
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4B;

	// Token: 0x040119C9 RID: 72137
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4C;

	// Token: 0x040119CA RID: 72138
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4D;

	// Token: 0x040119CB RID: 72139
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4E;

	// Token: 0x040119CC RID: 72140
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4F;

	// Token: 0x040119CD RID: 72141
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache50;

	// Token: 0x040119CE RID: 72142
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache51;

	// Token: 0x040119CF RID: 72143
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache52;

	// Token: 0x040119D0 RID: 72144
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache53;

	// Token: 0x040119D1 RID: 72145
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache54;

	// Token: 0x040119D2 RID: 72146
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache55;

	// Token: 0x040119D3 RID: 72147
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache56;

	// Token: 0x040119D4 RID: 72148
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache57;

	// Token: 0x040119D5 RID: 72149
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache58;

	// Token: 0x040119D6 RID: 72150
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache59;

	// Token: 0x040119D7 RID: 72151
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5A;

	// Token: 0x040119D8 RID: 72152
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5B;

	// Token: 0x040119D9 RID: 72153
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5C;

	// Token: 0x040119DA RID: 72154
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5D;

	// Token: 0x040119DB RID: 72155
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5E;

	// Token: 0x040119DC RID: 72156
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5F;

	// Token: 0x040119DD RID: 72157
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache60;

	// Token: 0x040119DE RID: 72158
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache61;

	// Token: 0x040119DF RID: 72159
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache62;

	// Token: 0x040119E0 RID: 72160
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache63;

	// Token: 0x040119E1 RID: 72161
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache64;

	// Token: 0x040119E2 RID: 72162
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache65;

	// Token: 0x040119E3 RID: 72163
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache66;

	// Token: 0x040119E4 RID: 72164
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache67;

	// Token: 0x040119E5 RID: 72165
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache68;

	// Token: 0x040119E6 RID: 72166
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache69;

	// Token: 0x040119E7 RID: 72167
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6A;

	// Token: 0x040119E8 RID: 72168
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6B;

	// Token: 0x040119E9 RID: 72169
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6C;

	// Token: 0x040119EA RID: 72170
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6D;

	// Token: 0x040119EB RID: 72171
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6E;

	// Token: 0x040119EC RID: 72172
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6F;

	// Token: 0x040119ED RID: 72173
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache70;

	// Token: 0x040119EE RID: 72174
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache71;

	// Token: 0x040119EF RID: 72175
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache72;

	// Token: 0x040119F0 RID: 72176
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache73;

	// Token: 0x040119F1 RID: 72177
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache74;

	// Token: 0x040119F2 RID: 72178
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache75;

	// Token: 0x040119F3 RID: 72179
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache76;

	// Token: 0x040119F4 RID: 72180
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache77;

	// Token: 0x040119F5 RID: 72181
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache78;

	// Token: 0x040119F6 RID: 72182
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache79;

	// Token: 0x040119F7 RID: 72183
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7A;

	// Token: 0x040119F8 RID: 72184
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7B;

	// Token: 0x040119F9 RID: 72185
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7C;

	// Token: 0x040119FA RID: 72186
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7D;

	// Token: 0x040119FB RID: 72187
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7E;

	// Token: 0x040119FC RID: 72188
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7F;

	// Token: 0x040119FD RID: 72189
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache80;

	// Token: 0x040119FE RID: 72190
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache81;

	// Token: 0x040119FF RID: 72191
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache82;

	// Token: 0x04011A00 RID: 72192
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache83;

	// Token: 0x04011A01 RID: 72193
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache84;

	// Token: 0x04011A02 RID: 72194
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache85;

	// Token: 0x04011A03 RID: 72195
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache86;

	// Token: 0x04011A04 RID: 72196
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache87;

	// Token: 0x04011A05 RID: 72197
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache88;

	// Token: 0x04011A06 RID: 72198
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache89;

	// Token: 0x04011A07 RID: 72199
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8A;

	// Token: 0x04011A08 RID: 72200
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8B;

	// Token: 0x04011A09 RID: 72201
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8C;

	// Token: 0x04011A0A RID: 72202
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8D;

	// Token: 0x04011A0B RID: 72203
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8E;

	// Token: 0x04011A0C RID: 72204
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8F;

	// Token: 0x04011A0D RID: 72205
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache90;

	// Token: 0x04011A0E RID: 72206
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache91;

	// Token: 0x04011A0F RID: 72207
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache92;

	// Token: 0x04011A10 RID: 72208
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache93;

	// Token: 0x04011A11 RID: 72209
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache94;

	// Token: 0x04011A12 RID: 72210
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache95;

	// Token: 0x04011A13 RID: 72211
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache96;

	// Token: 0x04011A14 RID: 72212
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache97;

	// Token: 0x04011A15 RID: 72213
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache98;

	// Token: 0x04011A16 RID: 72214
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache99;

	// Token: 0x04011A17 RID: 72215
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9A;

	// Token: 0x04011A18 RID: 72216
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9B;

	// Token: 0x04011A19 RID: 72217
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9C;

	// Token: 0x04011A1A RID: 72218
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9D;

	// Token: 0x04011A1B RID: 72219
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9E;

	// Token: 0x04011A1C RID: 72220
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9F;

	// Token: 0x04011A1D RID: 72221
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA0;

	// Token: 0x04011A1E RID: 72222
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA1;

	// Token: 0x04011A1F RID: 72223
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA2;

	// Token: 0x04011A20 RID: 72224
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA3;

	// Token: 0x04011A21 RID: 72225
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA4;

	// Token: 0x04011A22 RID: 72226
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA5;

	// Token: 0x04011A23 RID: 72227
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA6;

	// Token: 0x04011A24 RID: 72228
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA7;

	// Token: 0x04011A25 RID: 72229
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA8;

	// Token: 0x04011A26 RID: 72230
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA9;

	// Token: 0x04011A27 RID: 72231
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAA;

	// Token: 0x04011A28 RID: 72232
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAB;

	// Token: 0x04011A29 RID: 72233
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAC;

	// Token: 0x04011A2A RID: 72234
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAD;

	// Token: 0x04011A2B RID: 72235
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAE;

	// Token: 0x04011A2C RID: 72236
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAF;

	// Token: 0x04011A2D RID: 72237
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB0;

	// Token: 0x04011A2E RID: 72238
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB1;

	// Token: 0x04011A2F RID: 72239
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB2;

	// Token: 0x04011A30 RID: 72240
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB3;

	// Token: 0x04011A31 RID: 72241
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB4;
}
