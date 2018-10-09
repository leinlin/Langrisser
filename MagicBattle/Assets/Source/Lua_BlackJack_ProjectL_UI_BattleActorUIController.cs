using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Battle;
using BlackJack.ProjectL.Scene;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x0200139A RID: 5018
[Preserve]
public class Lua_BlackJack_ProjectL_UI_BattleActorUIController : LuaObject
{
	// Token: 0x0601B784 RID: 112516 RVA: 0x008563B8 File Offset: 0x008545B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetArmyInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleActorUIController battleActorUIController = (BattleActorUIController)LuaObject.checkSelf(l);
			ConfigDataArmyInfo armyInfo;
			LuaObject.checkType<ConfigDataArmyInfo>(l, 2, out armyInfo);
			battleActorUIController.SetArmyInfo(armyInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B785 RID: 112517 RVA: 0x00856410 File Offset: 0x00854610
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetHpBarType(IntPtr l)
	{
		int result;
		try
		{
			BattleActorUIController battleActorUIController = (BattleActorUIController)LuaObject.checkSelf(l);
			int hpBarType;
			LuaObject.checkType(l, 2, out hpBarType);
			battleActorUIController.SetHpBarType(hpBarType);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B786 RID: 112518 RVA: 0x00856468 File Offset: 0x00854668
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowTag(IntPtr l)
	{
		int result;
		try
		{
			BattleActorUIController battleActorUIController = (BattleActorUIController)LuaObject.checkSelf(l);
			StageActorTagType tagType;
			LuaObject.checkEnum<StageActorTagType>(l, 2, out tagType);
			battleActorUIController.ShowTag(tagType);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B787 RID: 112519 RVA: 0x008564C0 File Offset: 0x008546C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowProtect(IntPtr l)
	{
		int result;
		try
		{
			BattleActorUIController battleActorUIController = (BattleActorUIController)LuaObject.checkSelf(l);
			bool show;
			LuaObject.checkType(l, 2, out show);
			battleActorUIController.ShowProtect(show);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B788 RID: 112520 RVA: 0x00856518 File Offset: 0x00854718
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowBan(IntPtr l)
	{
		int result;
		try
		{
			BattleActorUIController battleActorUIController = (BattleActorUIController)LuaObject.checkSelf(l);
			bool show;
			LuaObject.checkType(l, 2, out show);
			battleActorUIController.ShowBan(show);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B789 RID: 112521 RVA: 0x00856570 File Offset: 0x00854770
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowPlayerIndexTag(IntPtr l)
	{
		int result;
		try
		{
			BattleActorUIController battleActorUIController = (BattleActorUIController)LuaObject.checkSelf(l);
			bool show;
			LuaObject.checkType(l, 2, out show);
			battleActorUIController.ShowPlayerIndexTag(show);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B78A RID: 112522 RVA: 0x008565C8 File Offset: 0x008547C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetPlayerIndex(IntPtr l)
	{
		int result;
		try
		{
			BattleActorUIController battleActorUIController = (BattleActorUIController)LuaObject.checkSelf(l);
			int playerIndex;
			LuaObject.checkType(l, 2, out playerIndex);
			battleActorUIController.SetPlayerIndex(playerIndex);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B78B RID: 112523 RVA: 0x00856620 File Offset: 0x00854820
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetHp(IntPtr l)
	{
		int result;
		try
		{
			BattleActorUIController battleActorUIController = (BattleActorUIController)LuaObject.checkSelf(l);
			int hp;
			LuaObject.checkType(l, 2, out hp);
			int hpValue;
			LuaObject.checkType(l, 3, out hpValue);
			battleActorUIController.SetHp(hp, hpValue);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B78C RID: 112524 RVA: 0x00856684 File Offset: 0x00854884
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetBuff(IntPtr l)
	{
		int result;
		try
		{
			BattleActorUIController battleActorUIController = (BattleActorUIController)LuaObject.checkSelf(l);
			BattleActor a;
			LuaObject.checkType<BattleActor>(l, 2, out a);
			List<ClientActorBuff> buffs;
			LuaObject.checkType<List<ClientActorBuff>>(l, 3, out buffs);
			battleActorUIController.SetBuff(a, buffs);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B78D RID: 112525 RVA: 0x008566E8 File Offset: 0x008548E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			BattleActorUIController battleActorUIController = (BattleActorUIController)LuaObject.checkSelf(l);
			battleActorUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B78E RID: 112526 RVA: 0x0085673C File Offset: 0x0085493C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			BattleActorUIController battleActorUIController = (BattleActorUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			battleActorUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B78F RID: 112527 RVA: 0x008567A8 File Offset: 0x008549A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			BattleActorUIController battleActorUIController = (BattleActorUIController)LuaObject.checkSelf(l);
			battleActorUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B790 RID: 112528 RVA: 0x008567FC File Offset: 0x008549FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			BattleActorUIController battleActorUIController = (BattleActorUIController)LuaObject.checkSelf(l);
			battleActorUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B791 RID: 112529 RVA: 0x00856850 File Offset: 0x00854A50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			BattleActorUIController battleActorUIController = (BattleActorUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = battleActorUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601B792 RID: 112530 RVA: 0x008568F8 File Offset: 0x00854AF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			BattleActorUIController battleActorUIController = (BattleActorUIController)LuaObject.checkSelf(l);
			battleActorUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B793 RID: 112531 RVA: 0x0085694C File Offset: 0x00854B4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			BattleActorUIController battleActorUIController = (BattleActorUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			battleActorUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B794 RID: 112532 RVA: 0x008569B8 File Offset: 0x00854BB8
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
				BattleActorUIController battleActorUIController = (BattleActorUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				battleActorUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				BattleActorUIController battleActorUIController2 = (BattleActorUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				battleActorUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601B795 RID: 112533 RVA: 0x00856AC8 File Offset: 0x00854CC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			BattleActorUIController battleActorUIController = (BattleActorUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			battleActorUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B796 RID: 112534 RVA: 0x00856B34 File Offset: 0x00854D34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			BattleActorUIController battleActorUIController = (BattleActorUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			battleActorUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B797 RID: 112535 RVA: 0x00856BA0 File Offset: 0x00854DA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			BattleActorUIController battleActorUIController = (BattleActorUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			battleActorUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B798 RID: 112536 RVA: 0x00856C0C File Offset: 0x00854E0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			BattleActorUIController battleActorUIController = (BattleActorUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			battleActorUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B799 RID: 112537 RVA: 0x00856C78 File Offset: 0x00854E78
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
				BattleActorUIController battleActorUIController = (BattleActorUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				battleActorUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				BattleActorUIController battleActorUIController2 = (BattleActorUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				battleActorUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601B79A RID: 112538 RVA: 0x00856D88 File Offset: 0x00854F88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			BattleActorUIController battleActorUIController = (BattleActorUIController)LuaObject.checkSelf(l);
			string s = battleActorUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601B79B RID: 112539 RVA: 0x00856DE4 File Offset: 0x00854FE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_hpImage(IntPtr l)
	{
		int result;
		try
		{
			BattleActorUIController battleActorUIController = (BattleActorUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActorUIController.m_luaExportHelper.m_hpImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B79C RID: 112540 RVA: 0x00856E3C File Offset: 0x0085503C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_hpImage(IntPtr l)
	{
		int result;
		try
		{
			BattleActorUIController battleActorUIController = (BattleActorUIController)LuaObject.checkSelf(l);
			Image hpImage;
			LuaObject.checkType<Image>(l, 2, out hpImage);
			battleActorUIController.m_luaExportHelper.m_hpImage = hpImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B79D RID: 112541 RVA: 0x00856E98 File Offset: 0x00855098
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_armyIconImage(IntPtr l)
	{
		int result;
		try
		{
			BattleActorUIController battleActorUIController = (BattleActorUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActorUIController.m_luaExportHelper.m_armyIconImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B79E RID: 112542 RVA: 0x00856EF0 File Offset: 0x008550F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_armyIconImage(IntPtr l)
	{
		int result;
		try
		{
			BattleActorUIController battleActorUIController = (BattleActorUIController)LuaObject.checkSelf(l);
			Image armyIconImage;
			LuaObject.checkType<Image>(l, 2, out armyIconImage);
			battleActorUIController.m_luaExportHelper.m_armyIconImage = armyIconImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B79F RID: 112543 RVA: 0x00856F4C File Offset: 0x0085514C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerTagImage(IntPtr l)
	{
		int result;
		try
		{
			BattleActorUIController battleActorUIController = (BattleActorUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActorUIController.m_luaExportHelper.m_playerTagImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B7A0 RID: 112544 RVA: 0x00856FA4 File Offset: 0x008551A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerTagImage(IntPtr l)
	{
		int result;
		try
		{
			BattleActorUIController battleActorUIController = (BattleActorUIController)LuaObject.checkSelf(l);
			Image playerTagImage;
			LuaObject.checkType<Image>(l, 2, out playerTagImage);
			battleActorUIController.m_luaExportHelper.m_playerTagImage = playerTagImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B7A1 RID: 112545 RVA: 0x00857000 File Offset: 0x00855200
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_enforceGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleActorUIController battleActorUIController = (BattleActorUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActorUIController.m_luaExportHelper.m_enforceGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B7A2 RID: 112546 RVA: 0x00857058 File Offset: 0x00855258
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_enforceGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleActorUIController battleActorUIController = (BattleActorUIController)LuaObject.checkSelf(l);
			GameObject enforceGameObject;
			LuaObject.checkType<GameObject>(l, 2, out enforceGameObject);
			battleActorUIController.m_luaExportHelper.m_enforceGameObject = enforceGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B7A3 RID: 112547 RVA: 0x008570B4 File Offset: 0x008552B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_npcGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleActorUIController battleActorUIController = (BattleActorUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActorUIController.m_luaExportHelper.m_npcGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B7A4 RID: 112548 RVA: 0x0085710C File Offset: 0x0085530C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_npcGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleActorUIController battleActorUIController = (BattleActorUIController)LuaObject.checkSelf(l);
			GameObject npcGameObject;
			LuaObject.checkType<GameObject>(l, 2, out npcGameObject);
			battleActorUIController.m_luaExportHelper.m_npcGameObject = npcGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B7A5 RID: 112549 RVA: 0x00857168 File Offset: 0x00855368
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_protectGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleActorUIController battleActorUIController = (BattleActorUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActorUIController.m_luaExportHelper.m_protectGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B7A6 RID: 112550 RVA: 0x008571C0 File Offset: 0x008553C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_protectGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleActorUIController battleActorUIController = (BattleActorUIController)LuaObject.checkSelf(l);
			GameObject protectGameObject;
			LuaObject.checkType<GameObject>(l, 2, out protectGameObject);
			battleActorUIController.m_luaExportHelper.m_protectGameObject = protectGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B7A7 RID: 112551 RVA: 0x0085721C File Offset: 0x0085541C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_banGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleActorUIController battleActorUIController = (BattleActorUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActorUIController.m_luaExportHelper.m_banGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B7A8 RID: 112552 RVA: 0x00857274 File Offset: 0x00855474
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_banGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleActorUIController battleActorUIController = (BattleActorUIController)LuaObject.checkSelf(l);
			GameObject banGameObject;
			LuaObject.checkType<GameObject>(l, 2, out banGameObject);
			battleActorUIController.m_luaExportHelper.m_banGameObject = banGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B7A9 RID: 112553 RVA: 0x008572D0 File Offset: 0x008554D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_scoreBonusGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleActorUIController battleActorUIController = (BattleActorUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActorUIController.m_luaExportHelper.m_scoreBonusGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B7AA RID: 112554 RVA: 0x00857328 File Offset: 0x00855528
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_scoreBonusGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleActorUIController battleActorUIController = (BattleActorUIController)LuaObject.checkSelf(l);
			GameObject scoreBonusGameObject;
			LuaObject.checkType<GameObject>(l, 2, out scoreBonusGameObject);
			battleActorUIController.m_luaExportHelper.m_scoreBonusGameObject = scoreBonusGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B7AB RID: 112555 RVA: 0x00857384 File Offset: 0x00855584
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_powerUpGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleActorUIController battleActorUIController = (BattleActorUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActorUIController.m_luaExportHelper.m_powerUpGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B7AC RID: 112556 RVA: 0x008573DC File Offset: 0x008555DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_powerUpGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleActorUIController battleActorUIController = (BattleActorUIController)LuaObject.checkSelf(l);
			GameObject powerUpGameObject;
			LuaObject.checkType<GameObject>(l, 2, out powerUpGameObject);
			battleActorUIController.m_luaExportHelper.m_powerUpGameObject = powerUpGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B7AD RID: 112557 RVA: 0x00857438 File Offset: 0x00855638
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_campUpGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleActorUIController battleActorUIController = (BattleActorUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActorUIController.m_luaExportHelper.m_campUpGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B7AE RID: 112558 RVA: 0x00857490 File Offset: 0x00855690
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_campUpGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleActorUIController battleActorUIController = (BattleActorUIController)LuaObject.checkSelf(l);
			GameObject campUpGameObject;
			LuaObject.checkType<GameObject>(l, 2, out campUpGameObject);
			battleActorUIController.m_luaExportHelper.m_campUpGameObject = campUpGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B7AF RID: 112559 RVA: 0x008574EC File Offset: 0x008556EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_buffImages(IntPtr l)
	{
		int result;
		try
		{
			BattleActorUIController battleActorUIController = (BattleActorUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActorUIController.m_luaExportHelper.m_buffImages);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B7B0 RID: 112560 RVA: 0x00857544 File Offset: 0x00855744
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_buffImages(IntPtr l)
	{
		int result;
		try
		{
			BattleActorUIController battleActorUIController = (BattleActorUIController)LuaObject.checkSelf(l);
			Image[] buffImages;
			LuaObject.checkArray<Image>(l, 2, out buffImages);
			battleActorUIController.m_luaExportHelper.m_buffImages = buffImages;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B7B1 RID: 112561 RVA: 0x008575A0 File Offset: 0x008557A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_buffTexts(IntPtr l)
	{
		int result;
		try
		{
			BattleActorUIController battleActorUIController = (BattleActorUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActorUIController.m_luaExportHelper.m_buffTexts);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B7B2 RID: 112562 RVA: 0x008575F8 File Offset: 0x008557F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_buffTexts(IntPtr l)
	{
		int result;
		try
		{
			BattleActorUIController battleActorUIController = (BattleActorUIController)LuaObject.checkSelf(l);
			Text[] buffTexts;
			LuaObject.checkArray<Text>(l, 2, out buffTexts);
			battleActorUIController.m_luaExportHelper.m_buffTexts = buffTexts;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B7B3 RID: 112563 RVA: 0x00857654 File Offset: 0x00855854
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.BattleActorUIController");
		if (Lua_BlackJack_ProjectL_UI_BattleActorUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorUIController.SetArmyInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleActorUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_BattleActorUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorUIController.SetHpBarType);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleActorUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_BattleActorUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorUIController.ShowTag);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleActorUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_BattleActorUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorUIController.ShowProtect);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleActorUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_BattleActorUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorUIController.ShowBan);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleActorUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_BattleActorUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorUIController.ShowPlayerIndexTag);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleActorUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_BattleActorUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorUIController.SetPlayerIndex);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleActorUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_BattleActorUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorUIController.SetHp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleActorUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_BattleActorUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorUIController.SetBuff);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleActorUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_BattleActorUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleActorUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_BattleActorUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleActorUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_BattleActorUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleActorUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_BattleActorUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleActorUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_BattleActorUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleActorUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_BattleActorUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleActorUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_BattleActorUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleActorUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_BattleActorUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleActorUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_BattleActorUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleActorUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_BattleActorUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleActorUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_BattleActorUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleActorUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_BattleActorUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleActorUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_BattleActorUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleActorUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_BattleActorUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleActorUIController.<>f__mg$cache16);
		string name = "m_hpImage";
		if (Lua_BlackJack_ProjectL_UI_BattleActorUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorUIController.get_m_hpImage);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_BattleActorUIController.<>f__mg$cache17;
		if (Lua_BlackJack_ProjectL_UI_BattleActorUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorUIController.set_m_hpImage);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_BattleActorUIController.<>f__mg$cache18, true);
		string name2 = "m_armyIconImage";
		if (Lua_BlackJack_ProjectL_UI_BattleActorUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorUIController.get_m_armyIconImage);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_BattleActorUIController.<>f__mg$cache19;
		if (Lua_BlackJack_ProjectL_UI_BattleActorUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorUIController.set_m_armyIconImage);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_BattleActorUIController.<>f__mg$cache1A, true);
		string name3 = "m_playerTagImage";
		if (Lua_BlackJack_ProjectL_UI_BattleActorUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorUIController.get_m_playerTagImage);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_BattleActorUIController.<>f__mg$cache1B;
		if (Lua_BlackJack_ProjectL_UI_BattleActorUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorUIController.set_m_playerTagImage);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_BattleActorUIController.<>f__mg$cache1C, true);
		string name4 = "m_enforceGameObject";
		if (Lua_BlackJack_ProjectL_UI_BattleActorUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorUIController.get_m_enforceGameObject);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_BattleActorUIController.<>f__mg$cache1D;
		if (Lua_BlackJack_ProjectL_UI_BattleActorUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorUIController.set_m_enforceGameObject);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_BattleActorUIController.<>f__mg$cache1E, true);
		string name5 = "m_npcGameObject";
		if (Lua_BlackJack_ProjectL_UI_BattleActorUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorUIController.get_m_npcGameObject);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_BattleActorUIController.<>f__mg$cache1F;
		if (Lua_BlackJack_ProjectL_UI_BattleActorUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorUIController.set_m_npcGameObject);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_BattleActorUIController.<>f__mg$cache20, true);
		string name6 = "m_protectGameObject";
		if (Lua_BlackJack_ProjectL_UI_BattleActorUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorUIController.get_m_protectGameObject);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_BattleActorUIController.<>f__mg$cache21;
		if (Lua_BlackJack_ProjectL_UI_BattleActorUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorUIController.set_m_protectGameObject);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_BattleActorUIController.<>f__mg$cache22, true);
		string name7 = "m_banGameObject";
		if (Lua_BlackJack_ProjectL_UI_BattleActorUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorUIController.get_m_banGameObject);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_BattleActorUIController.<>f__mg$cache23;
		if (Lua_BlackJack_ProjectL_UI_BattleActorUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorUIController.set_m_banGameObject);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_BattleActorUIController.<>f__mg$cache24, true);
		string name8 = "m_scoreBonusGameObject";
		if (Lua_BlackJack_ProjectL_UI_BattleActorUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorUIController.get_m_scoreBonusGameObject);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_BattleActorUIController.<>f__mg$cache25;
		if (Lua_BlackJack_ProjectL_UI_BattleActorUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorUIController.set_m_scoreBonusGameObject);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_BattleActorUIController.<>f__mg$cache26, true);
		string name9 = "m_powerUpGameObject";
		if (Lua_BlackJack_ProjectL_UI_BattleActorUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorUIController.get_m_powerUpGameObject);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_BattleActorUIController.<>f__mg$cache27;
		if (Lua_BlackJack_ProjectL_UI_BattleActorUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorUIController.set_m_powerUpGameObject);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_BattleActorUIController.<>f__mg$cache28, true);
		string name10 = "m_campUpGameObject";
		if (Lua_BlackJack_ProjectL_UI_BattleActorUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorUIController.get_m_campUpGameObject);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_BattleActorUIController.<>f__mg$cache29;
		if (Lua_BlackJack_ProjectL_UI_BattleActorUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorUIController.set_m_campUpGameObject);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_BattleActorUIController.<>f__mg$cache2A, true);
		string name11 = "m_buffImages";
		if (Lua_BlackJack_ProjectL_UI_BattleActorUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorUIController.get_m_buffImages);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_BattleActorUIController.<>f__mg$cache2B;
		if (Lua_BlackJack_ProjectL_UI_BattleActorUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorUIController.set_m_buffImages);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_BattleActorUIController.<>f__mg$cache2C, true);
		string name12 = "m_buffTexts";
		if (Lua_BlackJack_ProjectL_UI_BattleActorUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorUIController.get_m_buffTexts);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_BattleActorUIController.<>f__mg$cache2D;
		if (Lua_BlackJack_ProjectL_UI_BattleActorUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleActorUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleActorUIController.set_m_buffTexts);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_BattleActorUIController.<>f__mg$cache2E, true);
		LuaObject.createTypeMetatable(l, null, typeof(BattleActorUIController), typeof(UIControllerBase));
	}

	// Token: 0x04011A32 RID: 72242
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04011A33 RID: 72243
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04011A34 RID: 72244
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04011A35 RID: 72245
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04011A36 RID: 72246
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04011A37 RID: 72247
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04011A38 RID: 72248
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04011A39 RID: 72249
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04011A3A RID: 72250
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04011A3B RID: 72251
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04011A3C RID: 72252
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04011A3D RID: 72253
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04011A3E RID: 72254
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04011A3F RID: 72255
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04011A40 RID: 72256
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04011A41 RID: 72257
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04011A42 RID: 72258
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04011A43 RID: 72259
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04011A44 RID: 72260
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04011A45 RID: 72261
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04011A46 RID: 72262
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04011A47 RID: 72263
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04011A48 RID: 72264
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04011A49 RID: 72265
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04011A4A RID: 72266
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04011A4B RID: 72267
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04011A4C RID: 72268
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04011A4D RID: 72269
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04011A4E RID: 72270
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04011A4F RID: 72271
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04011A50 RID: 72272
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04011A51 RID: 72273
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04011A52 RID: 72274
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04011A53 RID: 72275
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04011A54 RID: 72276
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04011A55 RID: 72277
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04011A56 RID: 72278
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04011A57 RID: 72279
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04011A58 RID: 72280
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04011A59 RID: 72281
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04011A5A RID: 72282
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04011A5B RID: 72283
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04011A5C RID: 72284
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04011A5D RID: 72285
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04011A5E RID: 72286
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04011A5F RID: 72287
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04011A60 RID: 72288
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;
}
