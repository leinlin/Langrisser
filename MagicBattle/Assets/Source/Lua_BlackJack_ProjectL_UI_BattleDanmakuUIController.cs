using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x0200139E RID: 5022
[Preserve]
public class Lua_BlackJack_ProjectL_UI_BattleDanmakuUIController : LuaObject
{
	// Token: 0x0601B7D1 RID: 112593 RVA: 0x00858A50 File Offset: 0x00856C50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowCurTurnDanmaku(IntPtr l)
	{
		int result;
		try
		{
			BattleDanmakuUIController battleDanmakuUIController = (BattleDanmakuUIController)LuaObject.checkSelf(l);
			int turn;
			LuaObject.checkType(l, 2, out turn);
			battleDanmakuUIController.ShowCurTurnDanmaku(turn);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B7D2 RID: 112594 RVA: 0x00858AA8 File Offset: 0x00856CA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowOneDanmaku(IntPtr l)
	{
		int result;
		try
		{
			BattleDanmakuUIController battleDanmakuUIController = (BattleDanmakuUIController)LuaObject.checkSelf(l);
			DanmakuEntry danmaku;
			LuaObject.checkType<DanmakuEntry>(l, 2, out danmaku);
			battleDanmakuUIController.ShowOneDanmaku(danmaku);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B7D3 RID: 112595 RVA: 0x00858B00 File Offset: 0x00856D00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			BattleDanmakuUIController battleDanmakuUIController = (BattleDanmakuUIController)LuaObject.checkSelf(l);
			battleDanmakuUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B7D4 RID: 112596 RVA: 0x00858B54 File Offset: 0x00856D54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Co_ShowDanmakus(IntPtr l)
	{
		int result;
		try
		{
			BattleDanmakuUIController battleDanmakuUIController = (BattleDanmakuUIController)LuaObject.checkSelf(l);
			List<DanmakuEntry> danmakus;
			LuaObject.checkType<List<DanmakuEntry>>(l, 2, out danmakus);
			IEnumerator o = battleDanmakuUIController.m_luaExportHelper.Co_ShowDanmakus(danmakus);
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

	// Token: 0x0601B7D5 RID: 112597 RVA: 0x00858BBC File Offset: 0x00856DBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetRandomYPOsition(IntPtr l)
	{
		int result;
		try
		{
			BattleDanmakuUIController battleDanmakuUIController = (BattleDanmakuUIController)LuaObject.checkSelf(l);
			int randomYPOsition = battleDanmakuUIController.m_luaExportHelper.GetRandomYPOsition();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, randomYPOsition);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B7D6 RID: 112598 RVA: 0x00858C18 File Offset: 0x00856E18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsYPositonAvailable(IntPtr l)
	{
		int result;
		try
		{
			BattleDanmakuUIController battleDanmakuUIController = (BattleDanmakuUIController)LuaObject.checkSelf(l);
			int y;
			LuaObject.checkType(l, 2, out y);
			int listCount;
			LuaObject.checkType(l, 3, out listCount);
			bool b = battleDanmakuUIController.m_luaExportHelper.IsYPositonAvailable(y, listCount);
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

	// Token: 0x0601B7D7 RID: 112599 RVA: 0x00858C8C File Offset: 0x00856E8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			BattleDanmakuUIController battleDanmakuUIController = (BattleDanmakuUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			battleDanmakuUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B7D8 RID: 112600 RVA: 0x00858CF8 File Offset: 0x00856EF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			BattleDanmakuUIController battleDanmakuUIController = (BattleDanmakuUIController)LuaObject.checkSelf(l);
			battleDanmakuUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B7D9 RID: 112601 RVA: 0x00858D4C File Offset: 0x00856F4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			BattleDanmakuUIController battleDanmakuUIController = (BattleDanmakuUIController)LuaObject.checkSelf(l);
			battleDanmakuUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B7DA RID: 112602 RVA: 0x00858DA0 File Offset: 0x00856FA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			BattleDanmakuUIController battleDanmakuUIController = (BattleDanmakuUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = battleDanmakuUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601B7DB RID: 112603 RVA: 0x00858E48 File Offset: 0x00857048
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			BattleDanmakuUIController battleDanmakuUIController = (BattleDanmakuUIController)LuaObject.checkSelf(l);
			battleDanmakuUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B7DC RID: 112604 RVA: 0x00858E9C File Offset: 0x0085709C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			BattleDanmakuUIController battleDanmakuUIController = (BattleDanmakuUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			battleDanmakuUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B7DD RID: 112605 RVA: 0x00858F08 File Offset: 0x00857108
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
				BattleDanmakuUIController battleDanmakuUIController = (BattleDanmakuUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				battleDanmakuUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				BattleDanmakuUIController battleDanmakuUIController2 = (BattleDanmakuUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				battleDanmakuUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601B7DE RID: 112606 RVA: 0x00859018 File Offset: 0x00857218
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			BattleDanmakuUIController battleDanmakuUIController = (BattleDanmakuUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			battleDanmakuUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B7DF RID: 112607 RVA: 0x00859084 File Offset: 0x00857284
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			BattleDanmakuUIController battleDanmakuUIController = (BattleDanmakuUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			battleDanmakuUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B7E0 RID: 112608 RVA: 0x008590F0 File Offset: 0x008572F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			BattleDanmakuUIController battleDanmakuUIController = (BattleDanmakuUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			battleDanmakuUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B7E1 RID: 112609 RVA: 0x0085915C File Offset: 0x0085735C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			BattleDanmakuUIController battleDanmakuUIController = (BattleDanmakuUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			battleDanmakuUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B7E2 RID: 112610 RVA: 0x008591C8 File Offset: 0x008573C8
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
				BattleDanmakuUIController battleDanmakuUIController = (BattleDanmakuUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				battleDanmakuUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				BattleDanmakuUIController battleDanmakuUIController2 = (BattleDanmakuUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				battleDanmakuUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601B7E3 RID: 112611 RVA: 0x008592D8 File Offset: 0x008574D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			BattleDanmakuUIController battleDanmakuUIController = (BattleDanmakuUIController)LuaObject.checkSelf(l);
			string s = battleDanmakuUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601B7E4 RID: 112612 RVA: 0x00859334 File Offset: 0x00857534
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_danmakuContent(IntPtr l)
	{
		int result;
		try
		{
			BattleDanmakuUIController battleDanmakuUIController = (BattleDanmakuUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleDanmakuUIController.m_luaExportHelper.m_danmakuContent);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B7E5 RID: 112613 RVA: 0x0085938C File Offset: 0x0085758C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_danmakuContent(IntPtr l)
	{
		int result;
		try
		{
			BattleDanmakuUIController battleDanmakuUIController = (BattleDanmakuUIController)LuaObject.checkSelf(l);
			GameObject danmakuContent;
			LuaObject.checkType<GameObject>(l, 2, out danmakuContent);
			battleDanmakuUIController.m_luaExportHelper.m_danmakuContent = danmakuContent;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B7E6 RID: 112614 RVA: 0x008593E8 File Offset: 0x008575E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_danmakuCommonText(IntPtr l)
	{
		int result;
		try
		{
			BattleDanmakuUIController battleDanmakuUIController = (BattleDanmakuUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleDanmakuUIController.m_luaExportHelper.m_danmakuCommonText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B7E7 RID: 112615 RVA: 0x00859440 File Offset: 0x00857640
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_danmakuCommonText(IntPtr l)
	{
		int result;
		try
		{
			BattleDanmakuUIController battleDanmakuUIController = (BattleDanmakuUIController)LuaObject.checkSelf(l);
			Text danmakuCommonText;
			LuaObject.checkType<Text>(l, 2, out danmakuCommonText);
			battleDanmakuUIController.m_luaExportHelper.m_danmakuCommonText = danmakuCommonText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B7E8 RID: 112616 RVA: 0x0085949C File Offset: 0x0085769C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_danmakuMyText(IntPtr l)
	{
		int result;
		try
		{
			BattleDanmakuUIController battleDanmakuUIController = (BattleDanmakuUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleDanmakuUIController.m_luaExportHelper.m_danmakuMyText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B7E9 RID: 112617 RVA: 0x008594F4 File Offset: 0x008576F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_danmakuMyText(IntPtr l)
	{
		int result;
		try
		{
			BattleDanmakuUIController battleDanmakuUIController = (BattleDanmakuUIController)LuaObject.checkSelf(l);
			Text danmakuMyText;
			LuaObject.checkType<Text>(l, 2, out danmakuMyText);
			battleDanmakuUIController.m_luaExportHelper.m_danmakuMyText = danmakuMyText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B7EA RID: 112618 RVA: 0x00859550 File Offset: 0x00857750
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_danmakuYPosList(IntPtr l)
	{
		int result;
		try
		{
			BattleDanmakuUIController battleDanmakuUIController = (BattleDanmakuUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleDanmakuUIController.m_luaExportHelper.m_danmakuYPosList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B7EB RID: 112619 RVA: 0x008595A8 File Offset: 0x008577A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_danmakuYPosList(IntPtr l)
	{
		int result;
		try
		{
			BattleDanmakuUIController battleDanmakuUIController = (BattleDanmakuUIController)LuaObject.checkSelf(l);
			List<int> danmakuYPosList;
			LuaObject.checkType<List<int>>(l, 2, out danmakuYPosList);
			battleDanmakuUIController.m_luaExportHelper.m_danmakuYPosList = danmakuYPosList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B7EC RID: 112620 RVA: 0x00859604 File Offset: 0x00857804
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			BattleDanmakuUIController battleDanmakuUIController = (BattleDanmakuUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleDanmakuUIController.m_luaExportHelper.m_configDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B7ED RID: 112621 RVA: 0x0085965C File Offset: 0x0085785C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			BattleDanmakuUIController battleDanmakuUIController = (BattleDanmakuUIController)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			battleDanmakuUIController.m_luaExportHelper.m_configDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B7EE RID: 112622 RVA: 0x008596B8 File Offset: 0x008578B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			BattleDanmakuUIController battleDanmakuUIController = (BattleDanmakuUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleDanmakuUIController.m_luaExportHelper.m_playerContext);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B7EF RID: 112623 RVA: 0x00859710 File Offset: 0x00857910
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			BattleDanmakuUIController battleDanmakuUIController = (BattleDanmakuUIController)LuaObject.checkSelf(l);
			ProjectLPlayerContext playerContext;
			LuaObject.checkType<ProjectLPlayerContext>(l, 2, out playerContext);
			battleDanmakuUIController.m_luaExportHelper.m_playerContext = playerContext;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B7F0 RID: 112624 RVA: 0x0085976C File Offset: 0x0085796C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.BattleDanmakuUIController");
		if (Lua_BlackJack_ProjectL_UI_BattleDanmakuUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDanmakuUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDanmakuUIController.ShowCurTurnDanmaku);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleDanmakuUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_BattleDanmakuUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDanmakuUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDanmakuUIController.ShowOneDanmaku);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleDanmakuUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_BattleDanmakuUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDanmakuUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDanmakuUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleDanmakuUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_BattleDanmakuUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDanmakuUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDanmakuUIController.Co_ShowDanmakus);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleDanmakuUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_BattleDanmakuUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDanmakuUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDanmakuUIController.GetRandomYPOsition);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleDanmakuUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_BattleDanmakuUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDanmakuUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDanmakuUIController.IsYPositonAvailable);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleDanmakuUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_BattleDanmakuUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDanmakuUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDanmakuUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleDanmakuUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_BattleDanmakuUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDanmakuUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDanmakuUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleDanmakuUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_BattleDanmakuUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDanmakuUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDanmakuUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleDanmakuUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_BattleDanmakuUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDanmakuUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDanmakuUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleDanmakuUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_BattleDanmakuUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDanmakuUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDanmakuUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleDanmakuUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_BattleDanmakuUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDanmakuUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDanmakuUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleDanmakuUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_BattleDanmakuUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDanmakuUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDanmakuUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleDanmakuUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_BattleDanmakuUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDanmakuUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDanmakuUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleDanmakuUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_BattleDanmakuUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDanmakuUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDanmakuUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleDanmakuUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_BattleDanmakuUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDanmakuUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDanmakuUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleDanmakuUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_BattleDanmakuUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDanmakuUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDanmakuUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleDanmakuUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_BattleDanmakuUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDanmakuUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDanmakuUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleDanmakuUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_BattleDanmakuUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDanmakuUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDanmakuUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleDanmakuUIController.<>f__mg$cache12);
		string name = "m_danmakuContent";
		if (Lua_BlackJack_ProjectL_UI_BattleDanmakuUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDanmakuUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDanmakuUIController.get_m_danmakuContent);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_BattleDanmakuUIController.<>f__mg$cache13;
		if (Lua_BlackJack_ProjectL_UI_BattleDanmakuUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDanmakuUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDanmakuUIController.set_m_danmakuContent);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_BattleDanmakuUIController.<>f__mg$cache14, true);
		string name2 = "m_danmakuCommonText";
		if (Lua_BlackJack_ProjectL_UI_BattleDanmakuUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDanmakuUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDanmakuUIController.get_m_danmakuCommonText);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_BattleDanmakuUIController.<>f__mg$cache15;
		if (Lua_BlackJack_ProjectL_UI_BattleDanmakuUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDanmakuUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDanmakuUIController.set_m_danmakuCommonText);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_BattleDanmakuUIController.<>f__mg$cache16, true);
		string name3 = "m_danmakuMyText";
		if (Lua_BlackJack_ProjectL_UI_BattleDanmakuUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDanmakuUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDanmakuUIController.get_m_danmakuMyText);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_BattleDanmakuUIController.<>f__mg$cache17;
		if (Lua_BlackJack_ProjectL_UI_BattleDanmakuUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDanmakuUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDanmakuUIController.set_m_danmakuMyText);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_BattleDanmakuUIController.<>f__mg$cache18, true);
		string name4 = "m_danmakuYPosList";
		if (Lua_BlackJack_ProjectL_UI_BattleDanmakuUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDanmakuUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDanmakuUIController.get_m_danmakuYPosList);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_BattleDanmakuUIController.<>f__mg$cache19;
		if (Lua_BlackJack_ProjectL_UI_BattleDanmakuUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDanmakuUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDanmakuUIController.set_m_danmakuYPosList);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_BattleDanmakuUIController.<>f__mg$cache1A, true);
		string name5 = "m_configDataLoader";
		if (Lua_BlackJack_ProjectL_UI_BattleDanmakuUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDanmakuUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDanmakuUIController.get_m_configDataLoader);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_BattleDanmakuUIController.<>f__mg$cache1B;
		if (Lua_BlackJack_ProjectL_UI_BattleDanmakuUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDanmakuUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDanmakuUIController.set_m_configDataLoader);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_BattleDanmakuUIController.<>f__mg$cache1C, true);
		string name6 = "m_playerContext";
		if (Lua_BlackJack_ProjectL_UI_BattleDanmakuUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDanmakuUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDanmakuUIController.get_m_playerContext);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_BattleDanmakuUIController.<>f__mg$cache1D;
		if (Lua_BlackJack_ProjectL_UI_BattleDanmakuUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleDanmakuUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleDanmakuUIController.set_m_playerContext);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_BattleDanmakuUIController.<>f__mg$cache1E, true);
		LuaObject.createTypeMetatable(l, null, typeof(BattleDanmakuUIController), typeof(UIControllerBase));
	}

	// Token: 0x04011A77 RID: 72311
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04011A78 RID: 72312
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04011A79 RID: 72313
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04011A7A RID: 72314
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04011A7B RID: 72315
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04011A7C RID: 72316
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04011A7D RID: 72317
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04011A7E RID: 72318
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04011A7F RID: 72319
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04011A80 RID: 72320
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04011A81 RID: 72321
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04011A82 RID: 72322
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04011A83 RID: 72323
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04011A84 RID: 72324
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04011A85 RID: 72325
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04011A86 RID: 72326
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04011A87 RID: 72327
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04011A88 RID: 72328
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04011A89 RID: 72329
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04011A8A RID: 72330
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04011A8B RID: 72331
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04011A8C RID: 72332
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04011A8D RID: 72333
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04011A8E RID: 72334
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04011A8F RID: 72335
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04011A90 RID: 72336
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04011A91 RID: 72337
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04011A92 RID: 72338
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04011A93 RID: 72339
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04011A94 RID: 72340
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04011A95 RID: 72341
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;
}
