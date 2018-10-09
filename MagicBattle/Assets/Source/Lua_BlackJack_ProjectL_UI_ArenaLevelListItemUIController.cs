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

// Token: 0x02001375 RID: 4981
[Preserve]
public class Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController : LuaObject
{
	// Token: 0x0601AF6D RID: 110445 RVA: 0x00816070 File Offset: 0x00814270
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetArenaLevelInfo(IntPtr l)
	{
		int result;
		try
		{
			ArenaLevelListItemUIController arenaLevelListItemUIController = (ArenaLevelListItemUIController)LuaObject.checkSelf(l);
			ConfigDataArenaLevelInfo arenaLevelInfo;
			LuaObject.checkType<ConfigDataArenaLevelInfo>(l, 2, out arenaLevelInfo);
			GameObject rewardGoodsPrefab;
			LuaObject.checkType<GameObject>(l, 3, out rewardGoodsPrefab);
			int playerArenaLevelId;
			LuaObject.checkType(l, 4, out playerArenaLevelId);
			arenaLevelListItemUIController.SetArenaLevelInfo(arenaLevelInfo, rewardGoodsPrefab, playerArenaLevelId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AF6E RID: 110446 RVA: 0x008160E4 File Offset: 0x008142E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetDanInfo(IntPtr l)
	{
		int result;
		try
		{
			ArenaLevelListItemUIController arenaLevelListItemUIController = (ArenaLevelListItemUIController)LuaObject.checkSelf(l);
			ConfigDataRealTimePVPDanInfo danInfo;
			LuaObject.checkType<ConfigDataRealTimePVPDanInfo>(l, 2, out danInfo);
			GameObject rewardGoodsPrefab;
			LuaObject.checkType<GameObject>(l, 3, out rewardGoodsPrefab);
			int playerDanId;
			LuaObject.checkType(l, 4, out playerDanId);
			arenaLevelListItemUIController.SetDanInfo(danInfo, rewardGoodsPrefab, playerDanId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AF6F RID: 110447 RVA: 0x00816158 File Offset: 0x00814358
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			ArenaLevelListItemUIController arenaLevelListItemUIController = (ArenaLevelListItemUIController)LuaObject.checkSelf(l);
			arenaLevelListItemUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AF70 RID: 110448 RVA: 0x008161AC File Offset: 0x008143AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			ArenaLevelListItemUIController arenaLevelListItemUIController = (ArenaLevelListItemUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			arenaLevelListItemUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AF71 RID: 110449 RVA: 0x00816218 File Offset: 0x00814418
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			ArenaLevelListItemUIController arenaLevelListItemUIController = (ArenaLevelListItemUIController)LuaObject.checkSelf(l);
			arenaLevelListItemUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AF72 RID: 110450 RVA: 0x0081626C File Offset: 0x0081446C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			ArenaLevelListItemUIController arenaLevelListItemUIController = (ArenaLevelListItemUIController)LuaObject.checkSelf(l);
			arenaLevelListItemUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AF73 RID: 110451 RVA: 0x008162C0 File Offset: 0x008144C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			ArenaLevelListItemUIController arenaLevelListItemUIController = (ArenaLevelListItemUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = arenaLevelListItemUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601AF74 RID: 110452 RVA: 0x00816368 File Offset: 0x00814568
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			ArenaLevelListItemUIController arenaLevelListItemUIController = (ArenaLevelListItemUIController)LuaObject.checkSelf(l);
			arenaLevelListItemUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AF75 RID: 110453 RVA: 0x008163BC File Offset: 0x008145BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ArenaLevelListItemUIController arenaLevelListItemUIController = (ArenaLevelListItemUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			arenaLevelListItemUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AF76 RID: 110454 RVA: 0x00816428 File Offset: 0x00814628
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
				ArenaLevelListItemUIController arenaLevelListItemUIController = (ArenaLevelListItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				arenaLevelListItemUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				ArenaLevelListItemUIController arenaLevelListItemUIController2 = (ArenaLevelListItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				arenaLevelListItemUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601AF77 RID: 110455 RVA: 0x00816538 File Offset: 0x00814738
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			ArenaLevelListItemUIController arenaLevelListItemUIController = (ArenaLevelListItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			arenaLevelListItemUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AF78 RID: 110456 RVA: 0x008165A4 File Offset: 0x008147A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			ArenaLevelListItemUIController arenaLevelListItemUIController = (ArenaLevelListItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			arenaLevelListItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AF79 RID: 110457 RVA: 0x00816610 File Offset: 0x00814810
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			ArenaLevelListItemUIController arenaLevelListItemUIController = (ArenaLevelListItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			arenaLevelListItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AF7A RID: 110458 RVA: 0x0081667C File Offset: 0x0081487C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			ArenaLevelListItemUIController arenaLevelListItemUIController = (ArenaLevelListItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			arenaLevelListItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AF7B RID: 110459 RVA: 0x008166E8 File Offset: 0x008148E8
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
				ArenaLevelListItemUIController arenaLevelListItemUIController = (ArenaLevelListItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				arenaLevelListItemUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				ArenaLevelListItemUIController arenaLevelListItemUIController2 = (ArenaLevelListItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				arenaLevelListItemUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601AF7C RID: 110460 RVA: 0x008167F8 File Offset: 0x008149F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			ArenaLevelListItemUIController arenaLevelListItemUIController = (ArenaLevelListItemUIController)LuaObject.checkSelf(l);
			string s = arenaLevelListItemUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601AF7D RID: 110461 RVA: 0x00816854 File Offset: 0x00814A54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_arenaLevelUIStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			ArenaLevelListItemUIController arenaLevelListItemUIController = (ArenaLevelListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaLevelListItemUIController.m_luaExportHelper.m_arenaLevelUIStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AF7E RID: 110462 RVA: 0x008168AC File Offset: 0x00814AAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_arenaLevelUIStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			ArenaLevelListItemUIController arenaLevelListItemUIController = (ArenaLevelListItemUIController)LuaObject.checkSelf(l);
			CommonUIStateController arenaLevelUIStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out arenaLevelUIStateCtrl);
			arenaLevelListItemUIController.m_luaExportHelper.m_arenaLevelUIStateCtrl = arenaLevelUIStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AF7F RID: 110463 RVA: 0x00816908 File Offset: 0x00814B08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_lowUIStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			ArenaLevelListItemUIController arenaLevelListItemUIController = (ArenaLevelListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaLevelListItemUIController.m_luaExportHelper.m_lowUIStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AF80 RID: 110464 RVA: 0x00816960 File Offset: 0x00814B60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_lowUIStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			ArenaLevelListItemUIController arenaLevelListItemUIController = (ArenaLevelListItemUIController)LuaObject.checkSelf(l);
			CommonUIStateController lowUIStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out lowUIStateCtrl);
			arenaLevelListItemUIController.m_luaExportHelper.m_lowUIStateCtrl = lowUIStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AF81 RID: 110465 RVA: 0x008169BC File Offset: 0x00814BBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_lowLevelUIStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			ArenaLevelListItemUIController arenaLevelListItemUIController = (ArenaLevelListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaLevelListItemUIController.m_luaExportHelper.m_lowLevelUIStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AF82 RID: 110466 RVA: 0x00816A14 File Offset: 0x00814C14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_lowLevelUIStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			ArenaLevelListItemUIController arenaLevelListItemUIController = (ArenaLevelListItemUIController)LuaObject.checkSelf(l);
			CommonUIStateController lowLevelUIStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out lowLevelUIStateCtrl);
			arenaLevelListItemUIController.m_luaExportHelper.m_lowLevelUIStateCtrl = lowLevelUIStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AF83 RID: 110467 RVA: 0x00816A70 File Offset: 0x00814C70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_lowLevelIconImage(IntPtr l)
	{
		int result;
		try
		{
			ArenaLevelListItemUIController arenaLevelListItemUIController = (ArenaLevelListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaLevelListItemUIController.m_luaExportHelper.m_lowLevelIconImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AF84 RID: 110468 RVA: 0x00816AC8 File Offset: 0x00814CC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_lowLevelIconImage(IntPtr l)
	{
		int result;
		try
		{
			ArenaLevelListItemUIController arenaLevelListItemUIController = (ArenaLevelListItemUIController)LuaObject.checkSelf(l);
			Image lowLevelIconImage;
			LuaObject.checkType<Image>(l, 2, out lowLevelIconImage);
			arenaLevelListItemUIController.m_luaExportHelper.m_lowLevelIconImage = lowLevelIconImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AF85 RID: 110469 RVA: 0x00816B24 File Offset: 0x00814D24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_lowLevelText(IntPtr l)
	{
		int result;
		try
		{
			ArenaLevelListItemUIController arenaLevelListItemUIController = (ArenaLevelListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaLevelListItemUIController.m_luaExportHelper.m_lowLevelText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AF86 RID: 110470 RVA: 0x00816B7C File Offset: 0x00814D7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_lowLevelText(IntPtr l)
	{
		int result;
		try
		{
			ArenaLevelListItemUIController arenaLevelListItemUIController = (ArenaLevelListItemUIController)LuaObject.checkSelf(l);
			Text lowLevelText;
			LuaObject.checkType<Text>(l, 2, out lowLevelText);
			arenaLevelListItemUIController.m_luaExportHelper.m_lowLevelText = lowLevelText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AF87 RID: 110471 RVA: 0x00816BD8 File Offset: 0x00814DD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_lowRewardGroupGameObject(IntPtr l)
	{
		int result;
		try
		{
			ArenaLevelListItemUIController arenaLevelListItemUIController = (ArenaLevelListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaLevelListItemUIController.m_luaExportHelper.m_lowRewardGroupGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AF88 RID: 110472 RVA: 0x00816C30 File Offset: 0x00814E30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_lowRewardGroupGameObject(IntPtr l)
	{
		int result;
		try
		{
			ArenaLevelListItemUIController arenaLevelListItemUIController = (ArenaLevelListItemUIController)LuaObject.checkSelf(l);
			GameObject lowRewardGroupGameObject;
			LuaObject.checkType<GameObject>(l, 2, out lowRewardGroupGameObject);
			arenaLevelListItemUIController.m_luaExportHelper.m_lowRewardGroupGameObject = lowRewardGroupGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AF89 RID: 110473 RVA: 0x00816C8C File Offset: 0x00814E8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_lowArenaPointText(IntPtr l)
	{
		int result;
		try
		{
			ArenaLevelListItemUIController arenaLevelListItemUIController = (ArenaLevelListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaLevelListItemUIController.m_luaExportHelper.m_lowArenaPointText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AF8A RID: 110474 RVA: 0x00816CE4 File Offset: 0x00814EE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_lowArenaPointText(IntPtr l)
	{
		int result;
		try
		{
			ArenaLevelListItemUIController arenaLevelListItemUIController = (ArenaLevelListItemUIController)LuaObject.checkSelf(l);
			Text lowArenaPointText;
			LuaObject.checkType<Text>(l, 2, out lowArenaPointText);
			arenaLevelListItemUIController.m_luaExportHelper.m_lowArenaPointText = lowArenaPointText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AF8B RID: 110475 RVA: 0x00816D40 File Offset: 0x00814F40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_middleUIStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			ArenaLevelListItemUIController arenaLevelListItemUIController = (ArenaLevelListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaLevelListItemUIController.m_luaExportHelper.m_middleUIStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AF8C RID: 110476 RVA: 0x00816D98 File Offset: 0x00814F98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_middleUIStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			ArenaLevelListItemUIController arenaLevelListItemUIController = (ArenaLevelListItemUIController)LuaObject.checkSelf(l);
			CommonUIStateController middleUIStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out middleUIStateCtrl);
			arenaLevelListItemUIController.m_luaExportHelper.m_middleUIStateCtrl = middleUIStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AF8D RID: 110477 RVA: 0x00816DF4 File Offset: 0x00814FF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_middleLevelUIStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			ArenaLevelListItemUIController arenaLevelListItemUIController = (ArenaLevelListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaLevelListItemUIController.m_luaExportHelper.m_middleLevelUIStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AF8E RID: 110478 RVA: 0x00816E4C File Offset: 0x0081504C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_middleLevelUIStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			ArenaLevelListItemUIController arenaLevelListItemUIController = (ArenaLevelListItemUIController)LuaObject.checkSelf(l);
			CommonUIStateController middleLevelUIStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out middleLevelUIStateCtrl);
			arenaLevelListItemUIController.m_luaExportHelper.m_middleLevelUIStateCtrl = middleLevelUIStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AF8F RID: 110479 RVA: 0x00816EA8 File Offset: 0x008150A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_middleLevelIconImage(IntPtr l)
	{
		int result;
		try
		{
			ArenaLevelListItemUIController arenaLevelListItemUIController = (ArenaLevelListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaLevelListItemUIController.m_luaExportHelper.m_middleLevelIconImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AF90 RID: 110480 RVA: 0x00816F00 File Offset: 0x00815100
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_middleLevelIconImage(IntPtr l)
	{
		int result;
		try
		{
			ArenaLevelListItemUIController arenaLevelListItemUIController = (ArenaLevelListItemUIController)LuaObject.checkSelf(l);
			Image middleLevelIconImage;
			LuaObject.checkType<Image>(l, 2, out middleLevelIconImage);
			arenaLevelListItemUIController.m_luaExportHelper.m_middleLevelIconImage = middleLevelIconImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AF91 RID: 110481 RVA: 0x00816F5C File Offset: 0x0081515C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_middleLevelText(IntPtr l)
	{
		int result;
		try
		{
			ArenaLevelListItemUIController arenaLevelListItemUIController = (ArenaLevelListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaLevelListItemUIController.m_luaExportHelper.m_middleLevelText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AF92 RID: 110482 RVA: 0x00816FB4 File Offset: 0x008151B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_middleLevelText(IntPtr l)
	{
		int result;
		try
		{
			ArenaLevelListItemUIController arenaLevelListItemUIController = (ArenaLevelListItemUIController)LuaObject.checkSelf(l);
			Text middleLevelText;
			LuaObject.checkType<Text>(l, 2, out middleLevelText);
			arenaLevelListItemUIController.m_luaExportHelper.m_middleLevelText = middleLevelText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AF93 RID: 110483 RVA: 0x00817010 File Offset: 0x00815210
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_middleRewardGroupGameObject(IntPtr l)
	{
		int result;
		try
		{
			ArenaLevelListItemUIController arenaLevelListItemUIController = (ArenaLevelListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaLevelListItemUIController.m_luaExportHelper.m_middleRewardGroupGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AF94 RID: 110484 RVA: 0x00817068 File Offset: 0x00815268
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_middleRewardGroupGameObject(IntPtr l)
	{
		int result;
		try
		{
			ArenaLevelListItemUIController arenaLevelListItemUIController = (ArenaLevelListItemUIController)LuaObject.checkSelf(l);
			GameObject middleRewardGroupGameObject;
			LuaObject.checkType<GameObject>(l, 2, out middleRewardGroupGameObject);
			arenaLevelListItemUIController.m_luaExportHelper.m_middleRewardGroupGameObject = middleRewardGroupGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AF95 RID: 110485 RVA: 0x008170C4 File Offset: 0x008152C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_middleArenaPointText(IntPtr l)
	{
		int result;
		try
		{
			ArenaLevelListItemUIController arenaLevelListItemUIController = (ArenaLevelListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaLevelListItemUIController.m_luaExportHelper.m_middleArenaPointText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AF96 RID: 110486 RVA: 0x0081711C File Offset: 0x0081531C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_middleArenaPointText(IntPtr l)
	{
		int result;
		try
		{
			ArenaLevelListItemUIController arenaLevelListItemUIController = (ArenaLevelListItemUIController)LuaObject.checkSelf(l);
			Text middleArenaPointText;
			LuaObject.checkType<Text>(l, 2, out middleArenaPointText);
			arenaLevelListItemUIController.m_luaExportHelper.m_middleArenaPointText = middleArenaPointText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AF97 RID: 110487 RVA: 0x00817178 File Offset: 0x00815378
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_highUIStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			ArenaLevelListItemUIController arenaLevelListItemUIController = (ArenaLevelListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaLevelListItemUIController.m_luaExportHelper.m_highUIStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AF98 RID: 110488 RVA: 0x008171D0 File Offset: 0x008153D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_highUIStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			ArenaLevelListItemUIController arenaLevelListItemUIController = (ArenaLevelListItemUIController)LuaObject.checkSelf(l);
			CommonUIStateController highUIStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out highUIStateCtrl);
			arenaLevelListItemUIController.m_luaExportHelper.m_highUIStateCtrl = highUIStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AF99 RID: 110489 RVA: 0x0081722C File Offset: 0x0081542C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_highLevelUIStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			ArenaLevelListItemUIController arenaLevelListItemUIController = (ArenaLevelListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaLevelListItemUIController.m_luaExportHelper.m_highLevelUIStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AF9A RID: 110490 RVA: 0x00817284 File Offset: 0x00815484
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_highLevelUIStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			ArenaLevelListItemUIController arenaLevelListItemUIController = (ArenaLevelListItemUIController)LuaObject.checkSelf(l);
			CommonUIStateController highLevelUIStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out highLevelUIStateCtrl);
			arenaLevelListItemUIController.m_luaExportHelper.m_highLevelUIStateCtrl = highLevelUIStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AF9B RID: 110491 RVA: 0x008172E0 File Offset: 0x008154E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_highLevelIconImage(IntPtr l)
	{
		int result;
		try
		{
			ArenaLevelListItemUIController arenaLevelListItemUIController = (ArenaLevelListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaLevelListItemUIController.m_luaExportHelper.m_highLevelIconImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AF9C RID: 110492 RVA: 0x00817338 File Offset: 0x00815538
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_highLevelIconImage(IntPtr l)
	{
		int result;
		try
		{
			ArenaLevelListItemUIController arenaLevelListItemUIController = (ArenaLevelListItemUIController)LuaObject.checkSelf(l);
			Image highLevelIconImage;
			LuaObject.checkType<Image>(l, 2, out highLevelIconImage);
			arenaLevelListItemUIController.m_luaExportHelper.m_highLevelIconImage = highLevelIconImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AF9D RID: 110493 RVA: 0x00817394 File Offset: 0x00815594
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_highLevelText(IntPtr l)
	{
		int result;
		try
		{
			ArenaLevelListItemUIController arenaLevelListItemUIController = (ArenaLevelListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaLevelListItemUIController.m_luaExportHelper.m_highLevelText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AF9E RID: 110494 RVA: 0x008173EC File Offset: 0x008155EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_highLevelText(IntPtr l)
	{
		int result;
		try
		{
			ArenaLevelListItemUIController arenaLevelListItemUIController = (ArenaLevelListItemUIController)LuaObject.checkSelf(l);
			Text highLevelText;
			LuaObject.checkType<Text>(l, 2, out highLevelText);
			arenaLevelListItemUIController.m_luaExportHelper.m_highLevelText = highLevelText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AF9F RID: 110495 RVA: 0x00817448 File Offset: 0x00815648
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_highRewardGroupGameObject(IntPtr l)
	{
		int result;
		try
		{
			ArenaLevelListItemUIController arenaLevelListItemUIController = (ArenaLevelListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaLevelListItemUIController.m_luaExportHelper.m_highRewardGroupGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AFA0 RID: 110496 RVA: 0x008174A0 File Offset: 0x008156A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_highRewardGroupGameObject(IntPtr l)
	{
		int result;
		try
		{
			ArenaLevelListItemUIController arenaLevelListItemUIController = (ArenaLevelListItemUIController)LuaObject.checkSelf(l);
			GameObject highRewardGroupGameObject;
			LuaObject.checkType<GameObject>(l, 2, out highRewardGroupGameObject);
			arenaLevelListItemUIController.m_luaExportHelper.m_highRewardGroupGameObject = highRewardGroupGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AFA1 RID: 110497 RVA: 0x008174FC File Offset: 0x008156FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_highArenaPointText(IntPtr l)
	{
		int result;
		try
		{
			ArenaLevelListItemUIController arenaLevelListItemUIController = (ArenaLevelListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaLevelListItemUIController.m_luaExportHelper.m_highArenaPointText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AFA2 RID: 110498 RVA: 0x00817554 File Offset: 0x00815754
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_highArenaPointText(IntPtr l)
	{
		int result;
		try
		{
			ArenaLevelListItemUIController arenaLevelListItemUIController = (ArenaLevelListItemUIController)LuaObject.checkSelf(l);
			Text highArenaPointText;
			LuaObject.checkType<Text>(l, 2, out highArenaPointText);
			arenaLevelListItemUIController.m_luaExportHelper.m_highArenaPointText = highArenaPointText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AFA3 RID: 110499 RVA: 0x008175B0 File Offset: 0x008157B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_topUIStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			ArenaLevelListItemUIController arenaLevelListItemUIController = (ArenaLevelListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaLevelListItemUIController.m_luaExportHelper.m_topUIStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AFA4 RID: 110500 RVA: 0x00817608 File Offset: 0x00815808
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_topUIStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			ArenaLevelListItemUIController arenaLevelListItemUIController = (ArenaLevelListItemUIController)LuaObject.checkSelf(l);
			CommonUIStateController topUIStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out topUIStateCtrl);
			arenaLevelListItemUIController.m_luaExportHelper.m_topUIStateCtrl = topUIStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AFA5 RID: 110501 RVA: 0x00817664 File Offset: 0x00815864
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_topLevelIconImage(IntPtr l)
	{
		int result;
		try
		{
			ArenaLevelListItemUIController arenaLevelListItemUIController = (ArenaLevelListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaLevelListItemUIController.m_luaExportHelper.m_topLevelIconImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AFA6 RID: 110502 RVA: 0x008176BC File Offset: 0x008158BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_topLevelIconImage(IntPtr l)
	{
		int result;
		try
		{
			ArenaLevelListItemUIController arenaLevelListItemUIController = (ArenaLevelListItemUIController)LuaObject.checkSelf(l);
			Image topLevelIconImage;
			LuaObject.checkType<Image>(l, 2, out topLevelIconImage);
			arenaLevelListItemUIController.m_luaExportHelper.m_topLevelIconImage = topLevelIconImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AFA7 RID: 110503 RVA: 0x00817718 File Offset: 0x00815918
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_topLevelText(IntPtr l)
	{
		int result;
		try
		{
			ArenaLevelListItemUIController arenaLevelListItemUIController = (ArenaLevelListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaLevelListItemUIController.m_luaExportHelper.m_topLevelText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AFA8 RID: 110504 RVA: 0x00817770 File Offset: 0x00815970
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_topLevelText(IntPtr l)
	{
		int result;
		try
		{
			ArenaLevelListItemUIController arenaLevelListItemUIController = (ArenaLevelListItemUIController)LuaObject.checkSelf(l);
			Text topLevelText;
			LuaObject.checkType<Text>(l, 2, out topLevelText);
			arenaLevelListItemUIController.m_luaExportHelper.m_topLevelText = topLevelText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AFA9 RID: 110505 RVA: 0x008177CC File Offset: 0x008159CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_topRewardGroupGameObject(IntPtr l)
	{
		int result;
		try
		{
			ArenaLevelListItemUIController arenaLevelListItemUIController = (ArenaLevelListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaLevelListItemUIController.m_luaExportHelper.m_topRewardGroupGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AFAA RID: 110506 RVA: 0x00817824 File Offset: 0x00815A24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_topRewardGroupGameObject(IntPtr l)
	{
		int result;
		try
		{
			ArenaLevelListItemUIController arenaLevelListItemUIController = (ArenaLevelListItemUIController)LuaObject.checkSelf(l);
			GameObject topRewardGroupGameObject;
			LuaObject.checkType<GameObject>(l, 2, out topRewardGroupGameObject);
			arenaLevelListItemUIController.m_luaExportHelper.m_topRewardGroupGameObject = topRewardGroupGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AFAB RID: 110507 RVA: 0x00817880 File Offset: 0x00815A80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_topArenaPointText(IntPtr l)
	{
		int result;
		try
		{
			ArenaLevelListItemUIController arenaLevelListItemUIController = (ArenaLevelListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaLevelListItemUIController.m_luaExportHelper.m_topArenaPointText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AFAC RID: 110508 RVA: 0x008178D8 File Offset: 0x00815AD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_topArenaPointText(IntPtr l)
	{
		int result;
		try
		{
			ArenaLevelListItemUIController arenaLevelListItemUIController = (ArenaLevelListItemUIController)LuaObject.checkSelf(l);
			Text topArenaPointText;
			LuaObject.checkType<Text>(l, 2, out topArenaPointText);
			arenaLevelListItemUIController.m_luaExportHelper.m_topArenaPointText = topArenaPointText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AFAD RID: 110509 RVA: 0x00817934 File Offset: 0x00815B34
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.ArenaLevelListItemUIController");
		if (Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.SetArenaLevelInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.SetDanInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cacheF);
		string name = "m_arenaLevelUIStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.get_m_arenaLevelUIStateCtrl);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache10;
		if (Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.set_m_arenaLevelUIStateCtrl);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache11, true);
		string name2 = "m_lowUIStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.get_m_lowUIStateCtrl);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache12;
		if (Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.set_m_lowUIStateCtrl);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache13, true);
		string name3 = "m_lowLevelUIStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.get_m_lowLevelUIStateCtrl);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache14;
		if (Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.set_m_lowLevelUIStateCtrl);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache15, true);
		string name4 = "m_lowLevelIconImage";
		if (Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.get_m_lowLevelIconImage);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache16;
		if (Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.set_m_lowLevelIconImage);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache17, true);
		string name5 = "m_lowLevelText";
		if (Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.get_m_lowLevelText);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache18;
		if (Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.set_m_lowLevelText);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache19, true);
		string name6 = "m_lowRewardGroupGameObject";
		if (Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.get_m_lowRewardGroupGameObject);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache1A;
		if (Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.set_m_lowRewardGroupGameObject);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache1B, true);
		string name7 = "m_lowArenaPointText";
		if (Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.get_m_lowArenaPointText);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache1C;
		if (Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.set_m_lowArenaPointText);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache1D, true);
		string name8 = "m_middleUIStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.get_m_middleUIStateCtrl);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache1E;
		if (Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.set_m_middleUIStateCtrl);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache1F, true);
		string name9 = "m_middleLevelUIStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.get_m_middleLevelUIStateCtrl);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache20;
		if (Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.set_m_middleLevelUIStateCtrl);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache21, true);
		string name10 = "m_middleLevelIconImage";
		if (Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.get_m_middleLevelIconImage);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache22;
		if (Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.set_m_middleLevelIconImage);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache23, true);
		string name11 = "m_middleLevelText";
		if (Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.get_m_middleLevelText);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache24;
		if (Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.set_m_middleLevelText);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache25, true);
		string name12 = "m_middleRewardGroupGameObject";
		if (Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.get_m_middleRewardGroupGameObject);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache26;
		if (Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.set_m_middleRewardGroupGameObject);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache27, true);
		string name13 = "m_middleArenaPointText";
		if (Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.get_m_middleArenaPointText);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache28;
		if (Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.set_m_middleArenaPointText);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache29, true);
		string name14 = "m_highUIStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.get_m_highUIStateCtrl);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache2A;
		if (Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.set_m_highUIStateCtrl);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache2B, true);
		string name15 = "m_highLevelUIStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.get_m_highLevelUIStateCtrl);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache2C;
		if (Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.set_m_highLevelUIStateCtrl);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache2D, true);
		string name16 = "m_highLevelIconImage";
		if (Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.get_m_highLevelIconImage);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache2E;
		if (Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.set_m_highLevelIconImage);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache2F, true);
		string name17 = "m_highLevelText";
		if (Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.get_m_highLevelText);
		}
		LuaCSFunction get17 = Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache30;
		if (Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.set_m_highLevelText);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache31, true);
		string name18 = "m_highRewardGroupGameObject";
		if (Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.get_m_highRewardGroupGameObject);
		}
		LuaCSFunction get18 = Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache32;
		if (Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.set_m_highRewardGroupGameObject);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache33, true);
		string name19 = "m_highArenaPointText";
		if (Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.get_m_highArenaPointText);
		}
		LuaCSFunction get19 = Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache34;
		if (Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.set_m_highArenaPointText);
		}
		LuaObject.addMember(l, name19, get19, Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache35, true);
		string name20 = "m_topUIStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.get_m_topUIStateCtrl);
		}
		LuaCSFunction get20 = Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache36;
		if (Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.set_m_topUIStateCtrl);
		}
		LuaObject.addMember(l, name20, get20, Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache37, true);
		string name21 = "m_topLevelIconImage";
		if (Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.get_m_topLevelIconImage);
		}
		LuaCSFunction get21 = Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache38;
		if (Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.set_m_topLevelIconImage);
		}
		LuaObject.addMember(l, name21, get21, Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache39, true);
		string name22 = "m_topLevelText";
		if (Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.get_m_topLevelText);
		}
		LuaCSFunction get22 = Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache3A;
		if (Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.set_m_topLevelText);
		}
		LuaObject.addMember(l, name22, get22, Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache3B, true);
		string name23 = "m_topRewardGroupGameObject";
		if (Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.get_m_topRewardGroupGameObject);
		}
		LuaCSFunction get23 = Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache3C;
		if (Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.set_m_topRewardGroupGameObject);
		}
		LuaObject.addMember(l, name23, get23, Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache3D, true);
		string name24 = "m_topArenaPointText";
		if (Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.get_m_topArenaPointText);
		}
		LuaCSFunction get24 = Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache3E;
		if (Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.set_m_topArenaPointText);
		}
		LuaObject.addMember(l, name24, get24, Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.<>f__mg$cache3F, true);
		LuaObject.createTypeMetatable(l, null, typeof(ArenaLevelListItemUIController), typeof(UIControllerBase));
	}

	// Token: 0x04011265 RID: 70245
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04011266 RID: 70246
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04011267 RID: 70247
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04011268 RID: 70248
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04011269 RID: 70249
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0401126A RID: 70250
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0401126B RID: 70251
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0401126C RID: 70252
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0401126D RID: 70253
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0401126E RID: 70254
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0401126F RID: 70255
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04011270 RID: 70256
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04011271 RID: 70257
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04011272 RID: 70258
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04011273 RID: 70259
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04011274 RID: 70260
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04011275 RID: 70261
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04011276 RID: 70262
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04011277 RID: 70263
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04011278 RID: 70264
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04011279 RID: 70265
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0401127A RID: 70266
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0401127B RID: 70267
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0401127C RID: 70268
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0401127D RID: 70269
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0401127E RID: 70270
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0401127F RID: 70271
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04011280 RID: 70272
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04011281 RID: 70273
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04011282 RID: 70274
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04011283 RID: 70275
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04011284 RID: 70276
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04011285 RID: 70277
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04011286 RID: 70278
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04011287 RID: 70279
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04011288 RID: 70280
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04011289 RID: 70281
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0401128A RID: 70282
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0401128B RID: 70283
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0401128C RID: 70284
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0401128D RID: 70285
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x0401128E RID: 70286
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x0401128F RID: 70287
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04011290 RID: 70288
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04011291 RID: 70289
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04011292 RID: 70290
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04011293 RID: 70291
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04011294 RID: 70292
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04011295 RID: 70293
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04011296 RID: 70294
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04011297 RID: 70295
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x04011298 RID: 70296
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x04011299 RID: 70297
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x0401129A RID: 70298
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x0401129B RID: 70299
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x0401129C RID: 70300
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x0401129D RID: 70301
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x0401129E RID: 70302
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x0401129F RID: 70303
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x040112A0 RID: 70304
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x040112A1 RID: 70305
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x040112A2 RID: 70306
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x040112A3 RID: 70307
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x040112A4 RID: 70308
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;
}
