using System;
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

// Token: 0x02001438 RID: 5176
[Preserve]
public class Lua_BlackJack_ProjectL_UI_FettersConfessionUIController : LuaObject
{
	// Token: 0x0601DB05 RID: 121605 RVA: 0x00970EAC File Offset: 0x0096F0AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateViewInFettersConfession(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			Hero hero;
			LuaObject.checkType<Hero>(l, 2, out hero);
			fettersConfessionUIController.UpdateViewInFettersConfession(hero);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DB06 RID: 121606 RVA: 0x00970F04 File Offset: 0x0096F104
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnConfessionAndRewardSucceedEffect(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			List<Goods> rewards;
			LuaObject.checkType<List<Goods>>(l, 2, out rewards);
			fettersConfessionUIController.OnConfessionAndRewardSucceedEffect(rewards);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DB07 RID: 121607 RVA: 0x00970F5C File Offset: 0x0096F15C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			fettersConfessionUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DB08 RID: 121608 RVA: 0x00970FB0 File Offset: 0x0096F1B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnDisable(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			fettersConfessionUIController.m_luaExportHelper.OnDisable();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DB09 RID: 121609 RVA: 0x00971004 File Offset: 0x0096F204
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetSkillDetailPanel(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			ConfigDataHeroFetterInfo skillDetailPanel;
			LuaObject.checkType<ConfigDataHeroFetterInfo>(l, 2, out skillDetailPanel);
			fettersConfessionUIController.m_luaExportHelper.SetSkillDetailPanel(skillDetailPanel);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DB0A RID: 121610 RVA: 0x00971060 File Offset: 0x0096F260
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetSkillInfoGroup(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			ConfigDataHeroFetterInfo skillInfoGroup;
			LuaObject.checkType<ConfigDataHeroFetterInfo>(l, 2, out skillInfoGroup);
			fettersConfessionUIController.m_luaExportHelper.SetSkillInfoGroup(skillInfoGroup);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DB0B RID: 121611 RVA: 0x009710BC File Offset: 0x0096F2BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetLockStateInfo(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			ConfigDataHeroFetterInfo lockStateInfo;
			LuaObject.checkType<ConfigDataHeroFetterInfo>(l, 2, out lockStateInfo);
			fettersConfessionUIController.m_luaExportHelper.SetLockStateInfo(lockStateInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DB0C RID: 121612 RVA: 0x00971118 File Offset: 0x0096F318
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetFettersCoditionDesc(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			HeroFetterCompletionCondition condition;
			LuaObject.checkType<HeroFetterCompletionCondition>(l, 2, out condition);
			string fettersCoditionDesc = fettersConfessionUIController.m_luaExportHelper.GetFettersCoditionDesc(condition);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersCoditionDesc);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DB0D RID: 121613 RVA: 0x00971180 File Offset: 0x0096F380
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetUnlockStateInfo(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			ConfigDataHeroFetterInfo unlockStateInfo;
			LuaObject.checkType<ConfigDataHeroFetterInfo>(l, 2, out unlockStateInfo);
			fettersConfessionUIController.m_luaExportHelper.SetUnlockStateInfo(unlockStateInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DB0E RID: 121614 RVA: 0x009711DC File Offset: 0x0096F3DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetConfessionAndRewardInfo(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			fettersConfessionUIController.m_luaExportHelper.SetConfessionAndRewardInfo();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DB0F RID: 121615 RVA: 0x00971230 File Offset: 0x0096F430
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnFettersSkillItemClick(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			FettersConfessionSkillItemUIController ctrl;
			LuaObject.checkType<FettersConfessionSkillItemUIController>(l, 2, out ctrl);
			fettersConfessionUIController.m_luaExportHelper.OnFettersSkillItemClick(ctrl);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DB10 RID: 121616 RVA: 0x0097128C File Offset: 0x0096F48C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnConfessionToggleValueChanged(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			bool isOn;
			LuaObject.checkType(l, 2, out isOn);
			fettersConfessionUIController.m_luaExportHelper.OnConfessionToggleValueChanged(isOn);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DB11 RID: 121617 RVA: 0x009712E8 File Offset: 0x0096F4E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnEvolutionMaterialClick(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			GoodsType goodsType;
			LuaObject.checkEnum<GoodsType>(l, 2, out goodsType);
			int id;
			LuaObject.checkType(l, 3, out id);
			int needCount;
			LuaObject.checkType(l, 4, out needCount);
			fettersConfessionUIController.m_luaExportHelper.OnEvolutionMaterialClick(goodsType, id, needCount);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DB12 RID: 121618 RVA: 0x00971360 File Offset: 0x0096F560
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnSkillUnlockButtonClick(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			fettersConfessionUIController.m_luaExportHelper.OnSkillUnlockButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DB13 RID: 121619 RVA: 0x009713B4 File Offset: 0x0096F5B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnSkillDetailUnlockGreyButtonClick(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			fettersConfessionUIController.m_luaExportHelper.OnSkillDetailUnlockGreyButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DB14 RID: 121620 RVA: 0x00971408 File Offset: 0x0096F608
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnUnlockStateEvolutionButtonClcik(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			fettersConfessionUIController.m_luaExportHelper.OnUnlockStateEvolutionButtonClcik();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DB15 RID: 121621 RVA: 0x0097145C File Offset: 0x0096F65C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnConfessionAndRewardButtonClick(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			fettersConfessionUIController.m_luaExportHelper.OnConfessionAndRewardButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DB16 RID: 121622 RVA: 0x009714B0 File Offset: 0x0096F6B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnReturnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			fettersConfessionUIController.m_luaExportHelper.OnReturnButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DB17 RID: 121623 RVA: 0x00971504 File Offset: 0x0096F704
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnFastLevelButtonClick(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			fettersConfessionUIController.m_luaExportHelper.OnFastLevelButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DB18 RID: 121624 RVA: 0x00971558 File Offset: 0x0096F758
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnHelpButtonClick(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			fettersConfessionUIController.m_luaExportHelper.OnHelpButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DB19 RID: 121625 RVA: 0x009715AC File Offset: 0x0096F7AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnGoldAddButtonClick(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			fettersConfessionUIController.m_luaExportHelper.OnGoldAddButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DB1A RID: 121626 RVA: 0x00971600 File Offset: 0x0096F800
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnCrystalAddButtonClick(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			fettersConfessionUIController.m_luaExportHelper.OnCrystalAddButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DB1B RID: 121627 RVA: 0x00971654 File Offset: 0x0096F854
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			fettersConfessionUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DB1C RID: 121628 RVA: 0x009716C0 File Offset: 0x0096F8C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			fettersConfessionUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DB1D RID: 121629 RVA: 0x00971714 File Offset: 0x0096F914
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			fettersConfessionUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DB1E RID: 121630 RVA: 0x00971768 File Offset: 0x0096F968
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = fettersConfessionUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601DB1F RID: 121631 RVA: 0x00971810 File Offset: 0x0096FA10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			fettersConfessionUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DB20 RID: 121632 RVA: 0x00971864 File Offset: 0x0096FA64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			fettersConfessionUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DB21 RID: 121633 RVA: 0x009718D0 File Offset: 0x0096FAD0
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
				FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				fettersConfessionUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				FettersConfessionUIController fettersConfessionUIController2 = (FettersConfessionUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				fettersConfessionUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601DB22 RID: 121634 RVA: 0x009719E0 File Offset: 0x0096FBE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			fettersConfessionUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DB23 RID: 121635 RVA: 0x00971A4C File Offset: 0x0096FC4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			fettersConfessionUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DB24 RID: 121636 RVA: 0x00971AB8 File Offset: 0x0096FCB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			fettersConfessionUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DB25 RID: 121637 RVA: 0x00971B24 File Offset: 0x0096FD24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			fettersConfessionUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DB26 RID: 121638 RVA: 0x00971B90 File Offset: 0x0096FD90
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
				FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				fettersConfessionUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				FettersConfessionUIController fettersConfessionUIController2 = (FettersConfessionUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				fettersConfessionUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601DB27 RID: 121639 RVA: 0x00971CA0 File Offset: 0x0096FEA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			string s = fettersConfessionUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601DB28 RID: 121640 RVA: 0x00971CFC File Offset: 0x0096FEFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnReturn(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			fettersConfessionUIController.m_luaExportHelper.__callDele_EventOnReturn();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DB29 RID: 121641 RVA: 0x00971D50 File Offset: 0x0096FF50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnReturn(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			fettersConfessionUIController.m_luaExportHelper.__clearDele_EventOnReturn();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DB2A RID: 121642 RVA: 0x00971DA4 File Offset: 0x0096FFA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnShowHelp(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			fettersConfessionUIController.m_luaExportHelper.__callDele_EventOnShowHelp();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DB2B RID: 121643 RVA: 0x00971DF8 File Offset: 0x0096FFF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnShowHelp(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			fettersConfessionUIController.m_luaExportHelper.__clearDele_EventOnShowHelp();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DB2C RID: 121644 RVA: 0x00971E4C File Offset: 0x0097004C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnGoldAdd(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			fettersConfessionUIController.m_luaExportHelper.__callDele_EventOnGoldAdd();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DB2D RID: 121645 RVA: 0x00971EA0 File Offset: 0x009700A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnGoldAdd(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			fettersConfessionUIController.m_luaExportHelper.__clearDele_EventOnGoldAdd();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DB2E RID: 121646 RVA: 0x00971EF4 File Offset: 0x009700F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnAddCrystal(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			fettersConfessionUIController.m_luaExportHelper.__callDele_EventOnAddCrystal();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DB2F RID: 121647 RVA: 0x00971F48 File Offset: 0x00970148
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnAddCrystal(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			fettersConfessionUIController.m_luaExportHelper.__clearDele_EventOnAddCrystal();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DB30 RID: 121648 RVA: 0x00971F9C File Offset: 0x0097019C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnHeroFetterConfess(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			fettersConfessionUIController.m_luaExportHelper.__callDele_EventOnHeroFetterConfess(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DB31 RID: 121649 RVA: 0x00971FF8 File Offset: 0x009701F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnHeroFetterConfess(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			fettersConfessionUIController.m_luaExportHelper.__clearDele_EventOnHeroFetterConfess(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DB32 RID: 121650 RVA: 0x00972054 File Offset: 0x00970254
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnEvolutionButtonClick(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			int arg;
			LuaObject.checkType(l, 2, out arg);
			int arg2;
			LuaObject.checkType(l, 3, out arg2);
			Action arg3;
			LuaObject.checkDelegate<Action>(l, 4, out arg3);
			fettersConfessionUIController.m_luaExportHelper.__callDele_EventOnEvolutionButtonClick(arg, arg2, arg3);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DB33 RID: 121651 RVA: 0x009720CC File Offset: 0x009702CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnEvolutionButtonClick(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			int arg;
			LuaObject.checkType(l, 2, out arg);
			int arg2;
			LuaObject.checkType(l, 3, out arg2);
			Action arg3;
			LuaObject.checkDelegate<Action>(l, 4, out arg3);
			fettersConfessionUIController.m_luaExportHelper.__clearDele_EventOnEvolutionButtonClick(arg, arg2, arg3);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DB34 RID: 121652 RVA: 0x00972144 File Offset: 0x00970344
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnEvolutionMaterialClick(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			GoodsType arg;
			LuaObject.checkEnum<GoodsType>(l, 2, out arg);
			int arg2;
			LuaObject.checkType(l, 3, out arg2);
			int arg3;
			LuaObject.checkType(l, 4, out arg3);
			fettersConfessionUIController.m_luaExportHelper.__callDele_EventOnEvolutionMaterialClick(arg, arg2, arg3);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DB35 RID: 121653 RVA: 0x009721BC File Offset: 0x009703BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnEvolutionMaterialClick(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			GoodsType arg;
			LuaObject.checkEnum<GoodsType>(l, 2, out arg);
			int arg2;
			LuaObject.checkType(l, 3, out arg2);
			int arg3;
			LuaObject.checkType(l, 4, out arg3);
			fettersConfessionUIController.m_luaExportHelper.__clearDele_EventOnEvolutionMaterialClick(arg, arg2, arg3);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DB36 RID: 121654 RVA: 0x00972234 File Offset: 0x00970434
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnSkillUnlockButtonClick(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			int arg;
			LuaObject.checkType(l, 2, out arg);
			int arg2;
			LuaObject.checkType(l, 3, out arg2);
			Action<List<Goods>> arg3;
			LuaObject.checkDelegate<Action<List<Goods>>>(l, 4, out arg3);
			fettersConfessionUIController.m_luaExportHelper.__callDele_EventOnSkillUnlockButtonClick(arg, arg2, arg3);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DB37 RID: 121655 RVA: 0x009722AC File Offset: 0x009704AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnSkillUnlockButtonClick(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			int arg;
			LuaObject.checkType(l, 2, out arg);
			int arg2;
			LuaObject.checkType(l, 3, out arg2);
			Action<List<Goods>> arg3;
			LuaObject.checkDelegate<Action<List<Goods>>>(l, 4, out arg3);
			fettersConfessionUIController.m_luaExportHelper.__clearDele_EventOnSkillUnlockButtonClick(arg, arg2, arg3);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DB38 RID: 121656 RVA: 0x00972324 File Offset: 0x00970524
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnReturn(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					fettersConfessionUIController.EventOnReturn += value;
				}
				else if (num == 2)
				{
					fettersConfessionUIController.EventOnReturn -= value;
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

	// Token: 0x0601DB39 RID: 121657 RVA: 0x009723A4 File Offset: 0x009705A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnShowHelp(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					fettersConfessionUIController.EventOnShowHelp += value;
				}
				else if (num == 2)
				{
					fettersConfessionUIController.EventOnShowHelp -= value;
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

	// Token: 0x0601DB3A RID: 121658 RVA: 0x00972424 File Offset: 0x00970624
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnGoldAdd(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					fettersConfessionUIController.EventOnGoldAdd += value;
				}
				else if (num == 2)
				{
					fettersConfessionUIController.EventOnGoldAdd -= value;
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

	// Token: 0x0601DB3B RID: 121659 RVA: 0x009724A4 File Offset: 0x009706A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnAddCrystal(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					fettersConfessionUIController.EventOnAddCrystal += value;
				}
				else if (num == 2)
				{
					fettersConfessionUIController.EventOnAddCrystal -= value;
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

	// Token: 0x0601DB3C RID: 121660 RVA: 0x00972524 File Offset: 0x00970724
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnHeroFetterConfess(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			Action<int> value;
			int num = LuaObject.checkDelegate<Action<int>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					fettersConfessionUIController.EventOnHeroFetterConfess += value;
				}
				else if (num == 2)
				{
					fettersConfessionUIController.EventOnHeroFetterConfess -= value;
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

	// Token: 0x0601DB3D RID: 121661 RVA: 0x009725A4 File Offset: 0x009707A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnEvolutionButtonClick(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			Action<int, int, Action> value;
			int num = LuaObject.checkDelegate<Action<int, int, Action>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					fettersConfessionUIController.EventOnEvolutionButtonClick += value;
				}
				else if (num == 2)
				{
					fettersConfessionUIController.EventOnEvolutionButtonClick -= value;
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

	// Token: 0x0601DB3E RID: 121662 RVA: 0x00972624 File Offset: 0x00970824
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnEvolutionMaterialClick(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			Action<GoodsType, int, int> value;
			int num = LuaObject.checkDelegate<Action<GoodsType, int, int>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					fettersConfessionUIController.EventOnEvolutionMaterialClick += value;
				}
				else if (num == 2)
				{
					fettersConfessionUIController.EventOnEvolutionMaterialClick -= value;
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

	// Token: 0x0601DB3F RID: 121663 RVA: 0x009726A4 File Offset: 0x009708A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnSkillUnlockButtonClick(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			Action<int, int, Action<List<Goods>>> value;
			int num = LuaObject.checkDelegate<Action<int, int, Action<List<Goods>>>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					fettersConfessionUIController.EventOnSkillUnlockButtonClick += value;
				}
				else if (num == 2)
				{
					fettersConfessionUIController.EventOnSkillUnlockButtonClick -= value;
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

	// Token: 0x0601DB40 RID: 121664 RVA: 0x00972724 File Offset: 0x00970924
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_marginTransform(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersConfessionUIController.m_luaExportHelper.m_marginTransform);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DB41 RID: 121665 RVA: 0x0097277C File Offset: 0x0097097C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_marginTransform(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			RectTransform marginTransform;
			LuaObject.checkType<RectTransform>(l, 2, out marginTransform);
			fettersConfessionUIController.m_luaExportHelper.m_marginTransform = marginTransform;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DB42 RID: 121666 RVA: 0x009727D8 File Offset: 0x009709D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_commonUIStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersConfessionUIController.m_luaExportHelper.m_commonUIStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DB43 RID: 121667 RVA: 0x00972830 File Offset: 0x00970A30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_commonUIStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			CommonUIStateController commonUIStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out commonUIStateCtrl);
			fettersConfessionUIController.m_luaExportHelper.m_commonUIStateCtrl = commonUIStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DB44 RID: 121668 RVA: 0x0097288C File Offset: 0x00970A8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_returnButton(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersConfessionUIController.m_luaExportHelper.m_returnButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DB45 RID: 121669 RVA: 0x009728E4 File Offset: 0x00970AE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_returnButton(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			Button returnButton;
			LuaObject.checkType<Button>(l, 2, out returnButton);
			fettersConfessionUIController.m_luaExportHelper.m_returnButton = returnButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DB46 RID: 121670 RVA: 0x00972940 File Offset: 0x00970B40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_helpButton(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersConfessionUIController.m_luaExportHelper.m_helpButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DB47 RID: 121671 RVA: 0x00972998 File Offset: 0x00970B98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_helpButton(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			Button helpButton;
			LuaObject.checkType<Button>(l, 2, out helpButton);
			fettersConfessionUIController.m_luaExportHelper.m_helpButton = helpButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DB48 RID: 121672 RVA: 0x009729F4 File Offset: 0x00970BF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_skillGroupContent(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersConfessionUIController.m_luaExportHelper.m_skillGroupContent);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DB49 RID: 121673 RVA: 0x00972A4C File Offset: 0x00970C4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_skillGroupContent(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			GameObject skillGroupContent;
			LuaObject.checkType<GameObject>(l, 2, out skillGroupContent);
			fettersConfessionUIController.m_luaExportHelper.m_skillGroupContent = skillGroupContent;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DB4A RID: 121674 RVA: 0x00972AA8 File Offset: 0x00970CA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_centerSkillStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersConfessionUIController.m_luaExportHelper.m_centerSkillStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DB4B RID: 121675 RVA: 0x00972B00 File Offset: 0x00970D00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_centerSkillStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			CommonUIStateController centerSkillStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out centerSkillStateCtrl);
			fettersConfessionUIController.m_luaExportHelper.m_centerSkillStateCtrl = centerSkillStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DB4C RID: 121676 RVA: 0x00972B5C File Offset: 0x00970D5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_confessionToggle(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersConfessionUIController.m_luaExportHelper.m_confessionToggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DB4D RID: 121677 RVA: 0x00972BB4 File Offset: 0x00970DB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_confessionToggle(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			ToggleEx confessionToggle;
			LuaObject.checkType<ToggleEx>(l, 2, out confessionToggle);
			fettersConfessionUIController.m_luaExportHelper.m_confessionToggle = confessionToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DB4E RID: 121678 RVA: 0x00972C10 File Offset: 0x00970E10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_skillDetailStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersConfessionUIController.m_luaExportHelper.m_skillDetailStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DB4F RID: 121679 RVA: 0x00972C68 File Offset: 0x00970E68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_skillDetailStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			CommonUIStateController skillDetailStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out skillDetailStateCtrl);
			fettersConfessionUIController.m_luaExportHelper.m_skillDetailStateCtrl = skillDetailStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DB50 RID: 121680 RVA: 0x00972CC4 File Offset: 0x00970EC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_skillDetailInfoIconImage(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersConfessionUIController.m_luaExportHelper.m_skillDetailInfoIconImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DB51 RID: 121681 RVA: 0x00972D1C File Offset: 0x00970F1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_skillDetailInfoIconImage(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			Image skillDetailInfoIconImage;
			LuaObject.checkType<Image>(l, 2, out skillDetailInfoIconImage);
			fettersConfessionUIController.m_luaExportHelper.m_skillDetailInfoIconImage = skillDetailInfoIconImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DB52 RID: 121682 RVA: 0x00972D78 File Offset: 0x00970F78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_skillDetailInfoLockIconGo(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersConfessionUIController.m_luaExportHelper.m_skillDetailInfoLockIconGo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DB53 RID: 121683 RVA: 0x00972DD0 File Offset: 0x00970FD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_skillDetailInfoLockIconGo(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			GameObject skillDetailInfoLockIconGo;
			LuaObject.checkType<GameObject>(l, 2, out skillDetailInfoLockIconGo);
			fettersConfessionUIController.m_luaExportHelper.m_skillDetailInfoLockIconGo = skillDetailInfoLockIconGo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DB54 RID: 121684 RVA: 0x00972E2C File Offset: 0x0097102C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_skillDetailInfoSkillNameText(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersConfessionUIController.m_luaExportHelper.m_skillDetailInfoSkillNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DB55 RID: 121685 RVA: 0x00972E84 File Offset: 0x00971084
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_skillDetailInfoSkillNameText(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			Text skillDetailInfoSkillNameText;
			LuaObject.checkType<Text>(l, 2, out skillDetailInfoSkillNameText);
			fettersConfessionUIController.m_luaExportHelper.m_skillDetailInfoSkillNameText = skillDetailInfoSkillNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DB56 RID: 121686 RVA: 0x00972EE0 File Offset: 0x009710E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_skillDetailInfoSkillLvText(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersConfessionUIController.m_luaExportHelper.m_skillDetailInfoSkillLvText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DB57 RID: 121687 RVA: 0x00972F38 File Offset: 0x00971138
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_skillDetailInfoSkillLvText(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			Text skillDetailInfoSkillLvText;
			LuaObject.checkType<Text>(l, 2, out skillDetailInfoSkillLvText);
			fettersConfessionUIController.m_luaExportHelper.m_skillDetailInfoSkillLvText = skillDetailInfoSkillLvText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DB58 RID: 121688 RVA: 0x00972F94 File Offset: 0x00971194
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_skillDetailInfoSkillLvMaxText(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersConfessionUIController.m_luaExportHelper.m_skillDetailInfoSkillLvMaxText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DB59 RID: 121689 RVA: 0x00972FEC File Offset: 0x009711EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_skillDetailInfoSkillLvMaxText(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			GameObject skillDetailInfoSkillLvMaxText;
			LuaObject.checkType<GameObject>(l, 2, out skillDetailInfoSkillLvMaxText);
			fettersConfessionUIController.m_luaExportHelper.m_skillDetailInfoSkillLvMaxText = skillDetailInfoSkillLvMaxText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DB5A RID: 121690 RVA: 0x00973048 File Offset: 0x00971248
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_skillDetailDescText(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersConfessionUIController.m_luaExportHelper.m_skillDetailDescText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DB5B RID: 121691 RVA: 0x009730A0 File Offset: 0x009712A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_skillDetailDescText(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			Text skillDetailDescText;
			LuaObject.checkType<Text>(l, 2, out skillDetailDescText);
			fettersConfessionUIController.m_luaExportHelper.m_skillDetailDescText = skillDetailDescText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DB5C RID: 121692 RVA: 0x009730FC File Offset: 0x009712FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_skillDetailCondition1StateCtrl(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersConfessionUIController.m_luaExportHelper.m_skillDetailCondition1StateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DB5D RID: 121693 RVA: 0x00973154 File Offset: 0x00971354
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_skillDetailCondition1StateCtrl(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			CommonUIStateController skillDetailCondition1StateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out skillDetailCondition1StateCtrl);
			fettersConfessionUIController.m_luaExportHelper.m_skillDetailCondition1StateCtrl = skillDetailCondition1StateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DB5E RID: 121694 RVA: 0x009731B0 File Offset: 0x009713B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_skillDetailConditionUnlockInfoText1(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersConfessionUIController.m_luaExportHelper.m_skillDetailConditionUnlockInfoText1);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DB5F RID: 121695 RVA: 0x00973208 File Offset: 0x00971408
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_skillDetailConditionUnlockInfoText1(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			Text skillDetailConditionUnlockInfoText;
			LuaObject.checkType<Text>(l, 2, out skillDetailConditionUnlockInfoText);
			fettersConfessionUIController.m_luaExportHelper.m_skillDetailConditionUnlockInfoText1 = skillDetailConditionUnlockInfoText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DB60 RID: 121696 RVA: 0x00973264 File Offset: 0x00971464
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_skillDetailCondition2StateCtrl(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersConfessionUIController.m_luaExportHelper.m_skillDetailCondition2StateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DB61 RID: 121697 RVA: 0x009732BC File Offset: 0x009714BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_skillDetailCondition2StateCtrl(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			CommonUIStateController skillDetailCondition2StateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out skillDetailCondition2StateCtrl);
			fettersConfessionUIController.m_luaExportHelper.m_skillDetailCondition2StateCtrl = skillDetailCondition2StateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DB62 RID: 121698 RVA: 0x00973318 File Offset: 0x00971518
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_skillDetailConditionUnlockInfoText2(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersConfessionUIController.m_luaExportHelper.m_skillDetailConditionUnlockInfoText2);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DB63 RID: 121699 RVA: 0x00973370 File Offset: 0x00971570
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_skillDetailConditionUnlockInfoText2(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			Text skillDetailConditionUnlockInfoText;
			LuaObject.checkType<Text>(l, 2, out skillDetailConditionUnlockInfoText);
			fettersConfessionUIController.m_luaExportHelper.m_skillDetailConditionUnlockInfoText2 = skillDetailConditionUnlockInfoText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DB64 RID: 121700 RVA: 0x009733CC File Offset: 0x009715CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_skillDetailUnlockRewardGoods(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersConfessionUIController.m_luaExportHelper.m_skillDetailUnlockRewardGoods);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DB65 RID: 121701 RVA: 0x00973424 File Offset: 0x00971624
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_skillDetailUnlockRewardGoods(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			GameObject skillDetailUnlockRewardGoods;
			LuaObject.checkType<GameObject>(l, 2, out skillDetailUnlockRewardGoods);
			fettersConfessionUIController.m_luaExportHelper.m_skillDetailUnlockRewardGoods = skillDetailUnlockRewardGoods;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DB66 RID: 121702 RVA: 0x00973480 File Offset: 0x00971680
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_skillDetailUnlockButton(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersConfessionUIController.m_luaExportHelper.m_skillDetailUnlockButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DB67 RID: 121703 RVA: 0x009734D8 File Offset: 0x009716D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_skillDetailUnlockButton(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			Button skillDetailUnlockButton;
			LuaObject.checkType<Button>(l, 2, out skillDetailUnlockButton);
			fettersConfessionUIController.m_luaExportHelper.m_skillDetailUnlockButton = skillDetailUnlockButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DB68 RID: 121704 RVA: 0x00973534 File Offset: 0x00971734
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_skillDetailUnlockButtonStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersConfessionUIController.m_luaExportHelper.m_skillDetailUnlockButtonStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DB69 RID: 121705 RVA: 0x0097358C File Offset: 0x0097178C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_skillDetailUnlockButtonStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			CommonUIStateController skillDetailUnlockButtonStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out skillDetailUnlockButtonStateCtrl);
			fettersConfessionUIController.m_luaExportHelper.m_skillDetailUnlockButtonStateCtrl = skillDetailUnlockButtonStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DB6A RID: 121706 RVA: 0x009735E8 File Offset: 0x009717E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_skillDetailUnlockGreyButton(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersConfessionUIController.m_luaExportHelper.m_skillDetailUnlockGreyButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DB6B RID: 121707 RVA: 0x00973640 File Offset: 0x00971840
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_skillDetailUnlockGreyButton(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			Button skillDetailUnlockGreyButton;
			LuaObject.checkType<Button>(l, 2, out skillDetailUnlockGreyButton);
			fettersConfessionUIController.m_luaExportHelper.m_skillDetailUnlockGreyButton = skillDetailUnlockGreyButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DB6C RID: 121708 RVA: 0x0097369C File Offset: 0x0097189C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_skillDetailUnlockRewardNameText(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersConfessionUIController.m_luaExportHelper.m_skillDetailUnlockRewardNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DB6D RID: 121709 RVA: 0x009736F4 File Offset: 0x009718F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_skillDetailUnlockRewardNameText(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			Text skillDetailUnlockRewardNameText;
			LuaObject.checkType<Text>(l, 2, out skillDetailUnlockRewardNameText);
			fettersConfessionUIController.m_luaExportHelper.m_skillDetailUnlockRewardNameText = skillDetailUnlockRewardNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DB6E RID: 121710 RVA: 0x00973750 File Offset: 0x00971950
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_skillDetailUnlockStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersConfessionUIController.m_luaExportHelper.m_skillDetailUnlockStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DB6F RID: 121711 RVA: 0x009737A8 File Offset: 0x009719A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_skillDetailUnlockStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			CommonUIStateController skillDetailUnlockStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out skillDetailUnlockStateCtrl);
			fettersConfessionUIController.m_luaExportHelper.m_skillDetailUnlockStateCtrl = skillDetailUnlockStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DB70 RID: 121712 RVA: 0x00973804 File Offset: 0x00971A04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_skillDetailUnlockStateNowInfoText(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersConfessionUIController.m_luaExportHelper.m_skillDetailUnlockStateNowInfoText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DB71 RID: 121713 RVA: 0x0097385C File Offset: 0x00971A5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_skillDetailUnlockStateNowInfoText(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			Text skillDetailUnlockStateNowInfoText;
			LuaObject.checkType<Text>(l, 2, out skillDetailUnlockStateNowInfoText);
			fettersConfessionUIController.m_luaExportHelper.m_skillDetailUnlockStateNowInfoText = skillDetailUnlockStateNowInfoText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DB72 RID: 121714 RVA: 0x009738B8 File Offset: 0x00971AB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_skillDetailUnlockStateAfterText(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersConfessionUIController.m_luaExportHelper.m_skillDetailUnlockStateAfterText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DB73 RID: 121715 RVA: 0x00973910 File Offset: 0x00971B10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_skillDetailUnlockStateAfterText(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			Text skillDetailUnlockStateAfterText;
			LuaObject.checkType<Text>(l, 2, out skillDetailUnlockStateAfterText);
			fettersConfessionUIController.m_luaExportHelper.m_skillDetailUnlockStateAfterText = skillDetailUnlockStateAfterText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DB74 RID: 121716 RVA: 0x0097396C File Offset: 0x00971B6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_skillDetailUnlockStateConsumeTextStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersConfessionUIController.m_luaExportHelper.m_skillDetailUnlockStateConsumeTextStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DB75 RID: 121717 RVA: 0x009739C4 File Offset: 0x00971BC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_skillDetailUnlockStateConsumeTextStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			CommonUIStateController skillDetailUnlockStateConsumeTextStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out skillDetailUnlockStateConsumeTextStateCtrl);
			fettersConfessionUIController.m_luaExportHelper.m_skillDetailUnlockStateConsumeTextStateCtrl = skillDetailUnlockStateConsumeTextStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DB76 RID: 121718 RVA: 0x00973A20 File Offset: 0x00971C20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_skillDetailUnlockStateConsumeValueText(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersConfessionUIController.m_luaExportHelper.m_skillDetailUnlockStateConsumeValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DB77 RID: 121719 RVA: 0x00973A78 File Offset: 0x00971C78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_skillDetailUnlockStateConsumeValueText(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			Text skillDetailUnlockStateConsumeValueText;
			LuaObject.checkType<Text>(l, 2, out skillDetailUnlockStateConsumeValueText);
			fettersConfessionUIController.m_luaExportHelper.m_skillDetailUnlockStateConsumeValueText = skillDetailUnlockStateConsumeValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DB78 RID: 121720 RVA: 0x00973AD4 File Offset: 0x00971CD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_skillDetailUnlockEvolutionMaterial1(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersConfessionUIController.m_luaExportHelper.m_skillDetailUnlockEvolutionMaterial1);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DB79 RID: 121721 RVA: 0x00973B2C File Offset: 0x00971D2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_skillDetailUnlockEvolutionMaterial1(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			GameObject skillDetailUnlockEvolutionMaterial;
			LuaObject.checkType<GameObject>(l, 2, out skillDetailUnlockEvolutionMaterial);
			fettersConfessionUIController.m_luaExportHelper.m_skillDetailUnlockEvolutionMaterial1 = skillDetailUnlockEvolutionMaterial;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DB7A RID: 121722 RVA: 0x00973B88 File Offset: 0x00971D88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_skillDetailUnlockEvolutionMaterial2(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersConfessionUIController.m_luaExportHelper.m_skillDetailUnlockEvolutionMaterial2);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DB7B RID: 121723 RVA: 0x00973BE0 File Offset: 0x00971DE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_skillDetailUnlockEvolutionMaterial2(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			GameObject skillDetailUnlockEvolutionMaterial;
			LuaObject.checkType<GameObject>(l, 2, out skillDetailUnlockEvolutionMaterial);
			fettersConfessionUIController.m_luaExportHelper.m_skillDetailUnlockEvolutionMaterial2 = skillDetailUnlockEvolutionMaterial;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DB7C RID: 121724 RVA: 0x00973C3C File Offset: 0x00971E3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_skillDetailUnlockEvolutionMaterialStateCtrl1(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersConfessionUIController.m_luaExportHelper.m_skillDetailUnlockEvolutionMaterialStateCtrl1);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DB7D RID: 121725 RVA: 0x00973C94 File Offset: 0x00971E94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_skillDetailUnlockEvolutionMaterialStateCtrl1(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			CommonUIStateController skillDetailUnlockEvolutionMaterialStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out skillDetailUnlockEvolutionMaterialStateCtrl);
			fettersConfessionUIController.m_luaExportHelper.m_skillDetailUnlockEvolutionMaterialStateCtrl1 = skillDetailUnlockEvolutionMaterialStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DB7E RID: 121726 RVA: 0x00973CF0 File Offset: 0x00971EF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_skillDetailUnlockEvolutionMaterialStateCtrl2(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersConfessionUIController.m_luaExportHelper.m_skillDetailUnlockEvolutionMaterialStateCtrl2);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DB7F RID: 121727 RVA: 0x00973D48 File Offset: 0x00971F48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_skillDetailUnlockEvolutionMaterialStateCtrl2(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			CommonUIStateController skillDetailUnlockEvolutionMaterialStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out skillDetailUnlockEvolutionMaterialStateCtrl);
			fettersConfessionUIController.m_luaExportHelper.m_skillDetailUnlockEvolutionMaterialStateCtrl2 = skillDetailUnlockEvolutionMaterialStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DB80 RID: 121728 RVA: 0x00973DA4 File Offset: 0x00971FA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_skillDetailUnlockStateEvolutionButton(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersConfessionUIController.m_luaExportHelper.m_skillDetailUnlockStateEvolutionButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DB81 RID: 121729 RVA: 0x00973DFC File Offset: 0x00971FFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_skillDetailUnlockStateEvolutionButton(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			Button skillDetailUnlockStateEvolutionButton;
			LuaObject.checkType<Button>(l, 2, out skillDetailUnlockStateEvolutionButton);
			fettersConfessionUIController.m_luaExportHelper.m_skillDetailUnlockStateEvolutionButton = skillDetailUnlockStateEvolutionButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DB82 RID: 121730 RVA: 0x00973E58 File Offset: 0x00972058
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_skillDetailEnhanceSuccessEffectPanelStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersConfessionUIController.m_luaExportHelper.m_skillDetailEnhanceSuccessEffectPanelStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DB83 RID: 121731 RVA: 0x00973EB0 File Offset: 0x009720B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_skillDetailEnhanceSuccessEffectPanelStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			CommonUIStateController skillDetailEnhanceSuccessEffectPanelStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out skillDetailEnhanceSuccessEffectPanelStateCtrl);
			fettersConfessionUIController.m_luaExportHelper.m_skillDetailEnhanceSuccessEffectPanelStateCtrl = skillDetailEnhanceSuccessEffectPanelStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DB84 RID: 121732 RVA: 0x00973F0C File Offset: 0x0097210C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_skillDetailConfessionAndRewardStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersConfessionUIController.m_luaExportHelper.m_skillDetailConfessionAndRewardStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DB85 RID: 121733 RVA: 0x00973F64 File Offset: 0x00972164
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_skillDetailConfessionAndRewardStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			CommonUIStateController skillDetailConfessionAndRewardStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out skillDetailConfessionAndRewardStateCtrl);
			fettersConfessionUIController.m_luaExportHelper.m_skillDetailConfessionAndRewardStateCtrl = skillDetailConfessionAndRewardStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DB86 RID: 121734 RVA: 0x00973FC0 File Offset: 0x009721C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_skillDetailConfessionAndRewardScrollViewContent(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersConfessionUIController.m_luaExportHelper.m_skillDetailConfessionAndRewardScrollViewContent);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DB87 RID: 121735 RVA: 0x00974018 File Offset: 0x00972218
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_skillDetailConfessionAndRewardScrollViewContent(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			GameObject skillDetailConfessionAndRewardScrollViewContent;
			LuaObject.checkType<GameObject>(l, 2, out skillDetailConfessionAndRewardScrollViewContent);
			fettersConfessionUIController.m_luaExportHelper.m_skillDetailConfessionAndRewardScrollViewContent = skillDetailConfessionAndRewardScrollViewContent;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DB88 RID: 121736 RVA: 0x00974074 File Offset: 0x00972274
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_skillDetailConfessionAndRewardFemaleButton(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersConfessionUIController.m_luaExportHelper.m_skillDetailConfessionAndRewardFemaleButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DB89 RID: 121737 RVA: 0x009740CC File Offset: 0x009722CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_skillDetailConfessionAndRewardFemaleButton(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			Button skillDetailConfessionAndRewardFemaleButton;
			LuaObject.checkType<Button>(l, 2, out skillDetailConfessionAndRewardFemaleButton);
			fettersConfessionUIController.m_luaExportHelper.m_skillDetailConfessionAndRewardFemaleButton = skillDetailConfessionAndRewardFemaleButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DB8A RID: 121738 RVA: 0x00974128 File Offset: 0x00972328
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_skillDetailConfessionAndRewardFemaleRewardGoods(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersConfessionUIController.m_luaExportHelper.m_skillDetailConfessionAndRewardFemaleRewardGoods);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DB8B RID: 121739 RVA: 0x00974180 File Offset: 0x00972380
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_skillDetailConfessionAndRewardFemaleRewardGoods(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			GameObject skillDetailConfessionAndRewardFemaleRewardGoods;
			LuaObject.checkType<GameObject>(l, 2, out skillDetailConfessionAndRewardFemaleRewardGoods);
			fettersConfessionUIController.m_luaExportHelper.m_skillDetailConfessionAndRewardFemaleRewardGoods = skillDetailConfessionAndRewardFemaleRewardGoods;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DB8C RID: 121740 RVA: 0x009741DC File Offset: 0x009723DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_skillDetailConfessionAndRewardFemaleRewardGoodsNameText(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersConfessionUIController.m_luaExportHelper.m_skillDetailConfessionAndRewardFemaleRewardGoodsNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DB8D RID: 121741 RVA: 0x00974234 File Offset: 0x00972434
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_skillDetailConfessionAndRewardFemaleRewardGoodsNameText(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			Text skillDetailConfessionAndRewardFemaleRewardGoodsNameText;
			LuaObject.checkType<Text>(l, 2, out skillDetailConfessionAndRewardFemaleRewardGoodsNameText);
			fettersConfessionUIController.m_luaExportHelper.m_skillDetailConfessionAndRewardFemaleRewardGoodsNameText = skillDetailConfessionAndRewardFemaleRewardGoodsNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DB8E RID: 121742 RVA: 0x00974290 File Offset: 0x00972490
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_skillDetailConfessionAndRewardMaleButton(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersConfessionUIController.m_luaExportHelper.m_skillDetailConfessionAndRewardMaleButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DB8F RID: 121743 RVA: 0x009742E8 File Offset: 0x009724E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_skillDetailConfessionAndRewardMaleButton(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			Button skillDetailConfessionAndRewardMaleButton;
			LuaObject.checkType<Button>(l, 2, out skillDetailConfessionAndRewardMaleButton);
			fettersConfessionUIController.m_luaExportHelper.m_skillDetailConfessionAndRewardMaleButton = skillDetailConfessionAndRewardMaleButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DB90 RID: 121744 RVA: 0x00974344 File Offset: 0x00972544
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_skillDetailConfessionAndRewardMaleRewardGoods(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersConfessionUIController.m_luaExportHelper.m_skillDetailConfessionAndRewardMaleRewardGoods);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DB91 RID: 121745 RVA: 0x0097439C File Offset: 0x0097259C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_skillDetailConfessionAndRewardMaleRewardGoods(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			GameObject skillDetailConfessionAndRewardMaleRewardGoods;
			LuaObject.checkType<GameObject>(l, 2, out skillDetailConfessionAndRewardMaleRewardGoods);
			fettersConfessionUIController.m_luaExportHelper.m_skillDetailConfessionAndRewardMaleRewardGoods = skillDetailConfessionAndRewardMaleRewardGoods;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DB92 RID: 121746 RVA: 0x009743F8 File Offset: 0x009725F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_skillDetailConfessionAndRewardMaleRewardGoodsNameText(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersConfessionUIController.m_luaExportHelper.m_skillDetailConfessionAndRewardMaleRewardGoodsNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DB93 RID: 121747 RVA: 0x00974450 File Offset: 0x00972650
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_skillDetailConfessionAndRewardMaleRewardGoodsNameText(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			Text skillDetailConfessionAndRewardMaleRewardGoodsNameText;
			LuaObject.checkType<Text>(l, 2, out skillDetailConfessionAndRewardMaleRewardGoodsNameText);
			fettersConfessionUIController.m_luaExportHelper.m_skillDetailConfessionAndRewardMaleRewardGoodsNameText = skillDetailConfessionAndRewardMaleRewardGoodsNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DB94 RID: 121748 RVA: 0x009744AC File Offset: 0x009726AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_skillDetailUnlockStateConditionPrefab(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersConfessionUIController.m_luaExportHelper.m_skillDetailUnlockStateConditionPrefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DB95 RID: 121749 RVA: 0x00974504 File Offset: 0x00972704
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_skillDetailUnlockStateConditionPrefab(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			GameObject skillDetailUnlockStateConditionPrefab;
			LuaObject.checkType<GameObject>(l, 2, out skillDetailUnlockStateConditionPrefab);
			fettersConfessionUIController.m_luaExportHelper.m_skillDetailUnlockStateConditionPrefab = skillDetailUnlockStateConditionPrefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DB96 RID: 121750 RVA: 0x00974560 File Offset: 0x00972760
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerResourceCrystalText(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersConfessionUIController.m_luaExportHelper.m_playerResourceCrystalText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DB97 RID: 121751 RVA: 0x009745B8 File Offset: 0x009727B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerResourceCrystalText(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			Text playerResourceCrystalText;
			LuaObject.checkType<Text>(l, 2, out playerResourceCrystalText);
			fettersConfessionUIController.m_luaExportHelper.m_playerResourceCrystalText = playerResourceCrystalText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DB98 RID: 121752 RVA: 0x00974614 File Offset: 0x00972814
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerResourceCrystalAddButton(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersConfessionUIController.m_luaExportHelper.m_playerResourceCrystalAddButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DB99 RID: 121753 RVA: 0x0097466C File Offset: 0x0097286C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerResourceCrystalAddButton(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			Button playerResourceCrystalAddButton;
			LuaObject.checkType<Button>(l, 2, out playerResourceCrystalAddButton);
			fettersConfessionUIController.m_luaExportHelper.m_playerResourceCrystalAddButton = playerResourceCrystalAddButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DB9A RID: 121754 RVA: 0x009746C8 File Offset: 0x009728C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerResourceGoldenText(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersConfessionUIController.m_luaExportHelper.m_playerResourceGoldenText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DB9B RID: 121755 RVA: 0x00974720 File Offset: 0x00972920
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerResourceGoldenText(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			Text playerResourceGoldenText;
			LuaObject.checkType<Text>(l, 2, out playerResourceGoldenText);
			fettersConfessionUIController.m_luaExportHelper.m_playerResourceGoldenText = playerResourceGoldenText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DB9C RID: 121756 RVA: 0x0097477C File Offset: 0x0097297C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerResourceGoldenAddButton(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersConfessionUIController.m_luaExportHelper.m_playerResourceGoldenAddButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DB9D RID: 121757 RVA: 0x009747D4 File Offset: 0x009729D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerResourceGoldenAddButton(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			Button playerResourceGoldenAddButton;
			LuaObject.checkType<Button>(l, 2, out playerResourceGoldenAddButton);
			fettersConfessionUIController.m_luaExportHelper.m_playerResourceGoldenAddButton = playerResourceGoldenAddButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DB9E RID: 121758 RVA: 0x00974830 File Offset: 0x00972A30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_fastLevelButton(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersConfessionUIController.m_luaExportHelper.m_fastLevelButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DB9F RID: 121759 RVA: 0x00974888 File Offset: 0x00972A88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_fastLevelButton(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			Button fastLevelButton;
			LuaObject.checkType<Button>(l, 2, out fastLevelButton);
			fettersConfessionUIController.m_luaExportHelper.m_fastLevelButton = fastLevelButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DBA0 RID: 121760 RVA: 0x009748E4 File Offset: 0x00972AE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_fastLevelButtonInputField(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersConfessionUIController.m_luaExportHelper.m_fastLevelButtonInputField);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DBA1 RID: 121761 RVA: 0x0097493C File Offset: 0x00972B3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_fastLevelButtonInputField(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			InputField fastLevelButtonInputField;
			LuaObject.checkType<InputField>(l, 2, out fastLevelButtonInputField);
			fettersConfessionUIController.m_luaExportHelper.m_fastLevelButtonInputField = fastLevelButtonInputField;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DBA2 RID: 121762 RVA: 0x00974998 File Offset: 0x00972B98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_hero(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersConfessionUIController.m_luaExportHelper.m_hero);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DBA3 RID: 121763 RVA: 0x009749F0 File Offset: 0x00972BF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_hero(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			Hero hero;
			LuaObject.checkType<Hero>(l, 2, out hero);
			fettersConfessionUIController.m_luaExportHelper.m_hero = hero;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DBA4 RID: 121764 RVA: 0x00974A4C File Offset: 0x00972C4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_isFirstIn(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersConfessionUIController.m_luaExportHelper.isFirstIn);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DBA5 RID: 121765 RVA: 0x00974AA4 File Offset: 0x00972CA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_isFirstIn(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			bool isFirstIn;
			LuaObject.checkType(l, 2, out isFirstIn);
			fettersConfessionUIController.m_luaExportHelper.isFirstIn = isFirstIn;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DBA6 RID: 121766 RVA: 0x00974B00 File Offset: 0x00972D00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isMale(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersConfessionUIController.m_luaExportHelper.m_isMale);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DBA7 RID: 121767 RVA: 0x00974B58 File Offset: 0x00972D58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isMale(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			bool isMale;
			LuaObject.checkType(l, 2, out isMale);
			fettersConfessionUIController.m_luaExportHelper.m_isMale = isMale;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DBA8 RID: 121768 RVA: 0x00974BB4 File Offset: 0x00972DB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_curFetterSkillCtrl(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersConfessionUIController.m_luaExportHelper.m_curFetterSkillCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DBA9 RID: 121769 RVA: 0x00974C0C File Offset: 0x00972E0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_curFetterSkillCtrl(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			FettersConfessionSkillItemUIController curFetterSkillCtrl;
			LuaObject.checkType<FettersConfessionSkillItemUIController>(l, 2, out curFetterSkillCtrl);
			fettersConfessionUIController.m_luaExportHelper.m_curFetterSkillCtrl = curFetterSkillCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DBAA RID: 121770 RVA: 0x00974C68 File Offset: 0x00972E68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersConfessionUIController.m_luaExportHelper.m_playerContext);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DBAB RID: 121771 RVA: 0x00974CC0 File Offset: 0x00972EC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			ProjectLPlayerContext playerContext;
			LuaObject.checkType<ProjectLPlayerContext>(l, 2, out playerContext);
			fettersConfessionUIController.m_luaExportHelper.m_playerContext = playerContext;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DBAC RID: 121772 RVA: 0x00974D1C File Offset: 0x00972F1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersConfessionUIController.m_luaExportHelper.m_configDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DBAD RID: 121773 RVA: 0x00974D74 File Offset: 0x00972F74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionUIController fettersConfessionUIController = (FettersConfessionUIController)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			fettersConfessionUIController.m_luaExportHelper.m_configDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DBAE RID: 121774 RVA: 0x00974DD0 File Offset: 0x00972FD0
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.FettersConfessionUIController");
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.UpdateViewInFettersConfession);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.OnConfessionAndRewardSucceedEffect);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.OnDisable);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.SetSkillDetailPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.SetSkillInfoGroup);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.SetLockStateInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.GetFettersCoditionDesc);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.SetUnlockStateInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.SetConfessionAndRewardInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.OnFettersSkillItemClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.OnConfessionToggleValueChanged);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.OnEvolutionMaterialClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.OnSkillUnlockButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.OnSkillDetailUnlockGreyButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.OnUnlockStateEvolutionButtonClcik);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.OnConfessionAndRewardButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.OnReturnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.OnFastLevelButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.OnHelpButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.OnGoldAddButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.OnCrystalAddButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.__callDele_EventOnReturn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.__clearDele_EventOnReturn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.__callDele_EventOnShowHelp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache25);
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.__clearDele_EventOnShowHelp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache26);
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.__callDele_EventOnGoldAdd);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache27);
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.__clearDele_EventOnGoldAdd);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache28);
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.__callDele_EventOnAddCrystal);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache29);
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.__clearDele_EventOnAddCrystal);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache2A);
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.__callDele_EventOnHeroFetterConfess);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache2B);
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.__clearDele_EventOnHeroFetterConfess);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache2C);
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.__callDele_EventOnEvolutionButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache2D);
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.__clearDele_EventOnEvolutionButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache2E);
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.__callDele_EventOnEvolutionMaterialClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache2F);
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.__clearDele_EventOnEvolutionMaterialClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache30);
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.__callDele_EventOnSkillUnlockButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache31);
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.__clearDele_EventOnSkillUnlockButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache32);
		string name = "EventOnReturn";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.set_EventOnReturn);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache33, true);
		string name2 = "EventOnShowHelp";
		LuaCSFunction get2 = null;
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.set_EventOnShowHelp);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache34, true);
		string name3 = "EventOnGoldAdd";
		LuaCSFunction get3 = null;
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.set_EventOnGoldAdd);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache35, true);
		string name4 = "EventOnAddCrystal";
		LuaCSFunction get4 = null;
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.set_EventOnAddCrystal);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache36, true);
		string name5 = "EventOnHeroFetterConfess";
		LuaCSFunction get5 = null;
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.set_EventOnHeroFetterConfess);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache37, true);
		string name6 = "EventOnEvolutionButtonClick";
		LuaCSFunction get6 = null;
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.set_EventOnEvolutionButtonClick);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache38, true);
		string name7 = "EventOnEvolutionMaterialClick";
		LuaCSFunction get7 = null;
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.set_EventOnEvolutionMaterialClick);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache39, true);
		string name8 = "EventOnSkillUnlockButtonClick";
		LuaCSFunction get8 = null;
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.set_EventOnSkillUnlockButtonClick);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache3A, true);
		string name9 = "m_marginTransform";
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.get_m_marginTransform);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache3B;
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.set_m_marginTransform);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache3C, true);
		string name10 = "m_commonUIStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.get_m_commonUIStateCtrl);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache3D;
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.set_m_commonUIStateCtrl);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache3E, true);
		string name11 = "m_returnButton";
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.get_m_returnButton);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache3F;
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.set_m_returnButton);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache40, true);
		string name12 = "m_helpButton";
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.get_m_helpButton);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache41;
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.set_m_helpButton);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache42, true);
		string name13 = "m_skillGroupContent";
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.get_m_skillGroupContent);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache43;
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.set_m_skillGroupContent);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache44, true);
		string name14 = "m_centerSkillStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.get_m_centerSkillStateCtrl);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache45;
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache46 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache46 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.set_m_centerSkillStateCtrl);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache46, true);
		string name15 = "m_confessionToggle";
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache47 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache47 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.get_m_confessionToggle);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache47;
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache48 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache48 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.set_m_confessionToggle);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache48, true);
		string name16 = "m_skillDetailStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache49 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache49 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.get_m_skillDetailStateCtrl);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache49;
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache4A == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache4A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.set_m_skillDetailStateCtrl);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache4A, true);
		string name17 = "m_skillDetailInfoIconImage";
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache4B == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache4B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.get_m_skillDetailInfoIconImage);
		}
		LuaCSFunction get17 = Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache4B;
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache4C == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache4C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.set_m_skillDetailInfoIconImage);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache4C, true);
		string name18 = "m_skillDetailInfoLockIconGo";
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache4D == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache4D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.get_m_skillDetailInfoLockIconGo);
		}
		LuaCSFunction get18 = Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache4D;
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache4E == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache4E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.set_m_skillDetailInfoLockIconGo);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache4E, true);
		string name19 = "m_skillDetailInfoSkillNameText";
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache4F == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache4F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.get_m_skillDetailInfoSkillNameText);
		}
		LuaCSFunction get19 = Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache4F;
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache50 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache50 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.set_m_skillDetailInfoSkillNameText);
		}
		LuaObject.addMember(l, name19, get19, Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache50, true);
		string name20 = "m_skillDetailInfoSkillLvText";
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache51 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache51 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.get_m_skillDetailInfoSkillLvText);
		}
		LuaCSFunction get20 = Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache51;
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache52 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache52 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.set_m_skillDetailInfoSkillLvText);
		}
		LuaObject.addMember(l, name20, get20, Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache52, true);
		string name21 = "m_skillDetailInfoSkillLvMaxText";
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache53 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache53 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.get_m_skillDetailInfoSkillLvMaxText);
		}
		LuaCSFunction get21 = Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache53;
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache54 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache54 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.set_m_skillDetailInfoSkillLvMaxText);
		}
		LuaObject.addMember(l, name21, get21, Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache54, true);
		string name22 = "m_skillDetailDescText";
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache55 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache55 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.get_m_skillDetailDescText);
		}
		LuaCSFunction get22 = Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache55;
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache56 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache56 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.set_m_skillDetailDescText);
		}
		LuaObject.addMember(l, name22, get22, Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache56, true);
		string name23 = "m_skillDetailCondition1StateCtrl";
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache57 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache57 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.get_m_skillDetailCondition1StateCtrl);
		}
		LuaCSFunction get23 = Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache57;
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache58 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache58 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.set_m_skillDetailCondition1StateCtrl);
		}
		LuaObject.addMember(l, name23, get23, Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache58, true);
		string name24 = "m_skillDetailConditionUnlockInfoText1";
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache59 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache59 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.get_m_skillDetailConditionUnlockInfoText1);
		}
		LuaCSFunction get24 = Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache59;
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache5A == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache5A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.set_m_skillDetailConditionUnlockInfoText1);
		}
		LuaObject.addMember(l, name24, get24, Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache5A, true);
		string name25 = "m_skillDetailCondition2StateCtrl";
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache5B == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache5B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.get_m_skillDetailCondition2StateCtrl);
		}
		LuaCSFunction get25 = Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache5B;
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache5C == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache5C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.set_m_skillDetailCondition2StateCtrl);
		}
		LuaObject.addMember(l, name25, get25, Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache5C, true);
		string name26 = "m_skillDetailConditionUnlockInfoText2";
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache5D == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache5D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.get_m_skillDetailConditionUnlockInfoText2);
		}
		LuaCSFunction get26 = Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache5D;
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache5E == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache5E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.set_m_skillDetailConditionUnlockInfoText2);
		}
		LuaObject.addMember(l, name26, get26, Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache5E, true);
		string name27 = "m_skillDetailUnlockRewardGoods";
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache5F == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache5F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.get_m_skillDetailUnlockRewardGoods);
		}
		LuaCSFunction get27 = Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache5F;
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache60 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache60 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.set_m_skillDetailUnlockRewardGoods);
		}
		LuaObject.addMember(l, name27, get27, Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache60, true);
		string name28 = "m_skillDetailUnlockButton";
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache61 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache61 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.get_m_skillDetailUnlockButton);
		}
		LuaCSFunction get28 = Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache61;
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache62 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache62 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.set_m_skillDetailUnlockButton);
		}
		LuaObject.addMember(l, name28, get28, Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache62, true);
		string name29 = "m_skillDetailUnlockButtonStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache63 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache63 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.get_m_skillDetailUnlockButtonStateCtrl);
		}
		LuaCSFunction get29 = Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache63;
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache64 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache64 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.set_m_skillDetailUnlockButtonStateCtrl);
		}
		LuaObject.addMember(l, name29, get29, Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache64, true);
		string name30 = "m_skillDetailUnlockGreyButton";
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache65 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache65 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.get_m_skillDetailUnlockGreyButton);
		}
		LuaCSFunction get30 = Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache65;
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache66 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache66 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.set_m_skillDetailUnlockGreyButton);
		}
		LuaObject.addMember(l, name30, get30, Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache66, true);
		string name31 = "m_skillDetailUnlockRewardNameText";
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache67 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache67 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.get_m_skillDetailUnlockRewardNameText);
		}
		LuaCSFunction get31 = Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache67;
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache68 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache68 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.set_m_skillDetailUnlockRewardNameText);
		}
		LuaObject.addMember(l, name31, get31, Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache68, true);
		string name32 = "m_skillDetailUnlockStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache69 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache69 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.get_m_skillDetailUnlockStateCtrl);
		}
		LuaCSFunction get32 = Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache69;
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache6A == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache6A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.set_m_skillDetailUnlockStateCtrl);
		}
		LuaObject.addMember(l, name32, get32, Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache6A, true);
		string name33 = "m_skillDetailUnlockStateNowInfoText";
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache6B == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache6B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.get_m_skillDetailUnlockStateNowInfoText);
		}
		LuaCSFunction get33 = Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache6B;
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache6C == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache6C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.set_m_skillDetailUnlockStateNowInfoText);
		}
		LuaObject.addMember(l, name33, get33, Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache6C, true);
		string name34 = "m_skillDetailUnlockStateAfterText";
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache6D == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache6D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.get_m_skillDetailUnlockStateAfterText);
		}
		LuaCSFunction get34 = Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache6D;
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache6E == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache6E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.set_m_skillDetailUnlockStateAfterText);
		}
		LuaObject.addMember(l, name34, get34, Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache6E, true);
		string name35 = "m_skillDetailUnlockStateConsumeTextStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache6F == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache6F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.get_m_skillDetailUnlockStateConsumeTextStateCtrl);
		}
		LuaCSFunction get35 = Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache6F;
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache70 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache70 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.set_m_skillDetailUnlockStateConsumeTextStateCtrl);
		}
		LuaObject.addMember(l, name35, get35, Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache70, true);
		string name36 = "m_skillDetailUnlockStateConsumeValueText";
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache71 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache71 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.get_m_skillDetailUnlockStateConsumeValueText);
		}
		LuaCSFunction get36 = Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache71;
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache72 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache72 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.set_m_skillDetailUnlockStateConsumeValueText);
		}
		LuaObject.addMember(l, name36, get36, Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache72, true);
		string name37 = "m_skillDetailUnlockEvolutionMaterial1";
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache73 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache73 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.get_m_skillDetailUnlockEvolutionMaterial1);
		}
		LuaCSFunction get37 = Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache73;
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache74 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache74 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.set_m_skillDetailUnlockEvolutionMaterial1);
		}
		LuaObject.addMember(l, name37, get37, Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache74, true);
		string name38 = "m_skillDetailUnlockEvolutionMaterial2";
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache75 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache75 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.get_m_skillDetailUnlockEvolutionMaterial2);
		}
		LuaCSFunction get38 = Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache75;
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache76 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache76 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.set_m_skillDetailUnlockEvolutionMaterial2);
		}
		LuaObject.addMember(l, name38, get38, Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache76, true);
		string name39 = "m_skillDetailUnlockEvolutionMaterialStateCtrl1";
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache77 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache77 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.get_m_skillDetailUnlockEvolutionMaterialStateCtrl1);
		}
		LuaCSFunction get39 = Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache77;
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache78 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache78 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.set_m_skillDetailUnlockEvolutionMaterialStateCtrl1);
		}
		LuaObject.addMember(l, name39, get39, Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache78, true);
		string name40 = "m_skillDetailUnlockEvolutionMaterialStateCtrl2";
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache79 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache79 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.get_m_skillDetailUnlockEvolutionMaterialStateCtrl2);
		}
		LuaCSFunction get40 = Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache79;
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache7A == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache7A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.set_m_skillDetailUnlockEvolutionMaterialStateCtrl2);
		}
		LuaObject.addMember(l, name40, get40, Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache7A, true);
		string name41 = "m_skillDetailUnlockStateEvolutionButton";
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache7B == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache7B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.get_m_skillDetailUnlockStateEvolutionButton);
		}
		LuaCSFunction get41 = Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache7B;
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache7C == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache7C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.set_m_skillDetailUnlockStateEvolutionButton);
		}
		LuaObject.addMember(l, name41, get41, Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache7C, true);
		string name42 = "m_skillDetailEnhanceSuccessEffectPanelStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache7D == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache7D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.get_m_skillDetailEnhanceSuccessEffectPanelStateCtrl);
		}
		LuaCSFunction get42 = Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache7D;
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache7E == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache7E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.set_m_skillDetailEnhanceSuccessEffectPanelStateCtrl);
		}
		LuaObject.addMember(l, name42, get42, Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache7E, true);
		string name43 = "m_skillDetailConfessionAndRewardStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache7F == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache7F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.get_m_skillDetailConfessionAndRewardStateCtrl);
		}
		LuaCSFunction get43 = Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache7F;
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache80 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache80 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.set_m_skillDetailConfessionAndRewardStateCtrl);
		}
		LuaObject.addMember(l, name43, get43, Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache80, true);
		string name44 = "m_skillDetailConfessionAndRewardScrollViewContent";
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache81 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache81 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.get_m_skillDetailConfessionAndRewardScrollViewContent);
		}
		LuaCSFunction get44 = Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache81;
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache82 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache82 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.set_m_skillDetailConfessionAndRewardScrollViewContent);
		}
		LuaObject.addMember(l, name44, get44, Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache82, true);
		string name45 = "m_skillDetailConfessionAndRewardFemaleButton";
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache83 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache83 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.get_m_skillDetailConfessionAndRewardFemaleButton);
		}
		LuaCSFunction get45 = Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache83;
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache84 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache84 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.set_m_skillDetailConfessionAndRewardFemaleButton);
		}
		LuaObject.addMember(l, name45, get45, Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache84, true);
		string name46 = "m_skillDetailConfessionAndRewardFemaleRewardGoods";
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache85 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache85 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.get_m_skillDetailConfessionAndRewardFemaleRewardGoods);
		}
		LuaCSFunction get46 = Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache85;
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache86 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache86 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.set_m_skillDetailConfessionAndRewardFemaleRewardGoods);
		}
		LuaObject.addMember(l, name46, get46, Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache86, true);
		string name47 = "m_skillDetailConfessionAndRewardFemaleRewardGoodsNameText";
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache87 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache87 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.get_m_skillDetailConfessionAndRewardFemaleRewardGoodsNameText);
		}
		LuaCSFunction get47 = Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache87;
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache88 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache88 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.set_m_skillDetailConfessionAndRewardFemaleRewardGoodsNameText);
		}
		LuaObject.addMember(l, name47, get47, Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache88, true);
		string name48 = "m_skillDetailConfessionAndRewardMaleButton";
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache89 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache89 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.get_m_skillDetailConfessionAndRewardMaleButton);
		}
		LuaCSFunction get48 = Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache89;
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache8A == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache8A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.set_m_skillDetailConfessionAndRewardMaleButton);
		}
		LuaObject.addMember(l, name48, get48, Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache8A, true);
		string name49 = "m_skillDetailConfessionAndRewardMaleRewardGoods";
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache8B == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache8B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.get_m_skillDetailConfessionAndRewardMaleRewardGoods);
		}
		LuaCSFunction get49 = Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache8B;
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache8C == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache8C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.set_m_skillDetailConfessionAndRewardMaleRewardGoods);
		}
		LuaObject.addMember(l, name49, get49, Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache8C, true);
		string name50 = "m_skillDetailConfessionAndRewardMaleRewardGoodsNameText";
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache8D == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache8D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.get_m_skillDetailConfessionAndRewardMaleRewardGoodsNameText);
		}
		LuaCSFunction get50 = Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache8D;
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache8E == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache8E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.set_m_skillDetailConfessionAndRewardMaleRewardGoodsNameText);
		}
		LuaObject.addMember(l, name50, get50, Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache8E, true);
		string name51 = "m_skillDetailUnlockStateConditionPrefab";
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache8F == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache8F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.get_m_skillDetailUnlockStateConditionPrefab);
		}
		LuaCSFunction get51 = Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache8F;
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache90 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache90 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.set_m_skillDetailUnlockStateConditionPrefab);
		}
		LuaObject.addMember(l, name51, get51, Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache90, true);
		string name52 = "m_playerResourceCrystalText";
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache91 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache91 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.get_m_playerResourceCrystalText);
		}
		LuaCSFunction get52 = Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache91;
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache92 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache92 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.set_m_playerResourceCrystalText);
		}
		LuaObject.addMember(l, name52, get52, Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache92, true);
		string name53 = "m_playerResourceCrystalAddButton";
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache93 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache93 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.get_m_playerResourceCrystalAddButton);
		}
		LuaCSFunction get53 = Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache93;
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache94 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache94 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.set_m_playerResourceCrystalAddButton);
		}
		LuaObject.addMember(l, name53, get53, Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache94, true);
		string name54 = "m_playerResourceGoldenText";
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache95 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache95 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.get_m_playerResourceGoldenText);
		}
		LuaCSFunction get54 = Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache95;
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache96 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache96 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.set_m_playerResourceGoldenText);
		}
		LuaObject.addMember(l, name54, get54, Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache96, true);
		string name55 = "m_playerResourceGoldenAddButton";
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache97 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache97 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.get_m_playerResourceGoldenAddButton);
		}
		LuaCSFunction get55 = Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache97;
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache98 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache98 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.set_m_playerResourceGoldenAddButton);
		}
		LuaObject.addMember(l, name55, get55, Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache98, true);
		string name56 = "m_fastLevelButton";
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache99 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache99 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.get_m_fastLevelButton);
		}
		LuaCSFunction get56 = Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache99;
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache9A == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache9A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.set_m_fastLevelButton);
		}
		LuaObject.addMember(l, name56, get56, Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache9A, true);
		string name57 = "m_fastLevelButtonInputField";
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache9B == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache9B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.get_m_fastLevelButtonInputField);
		}
		LuaCSFunction get57 = Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache9B;
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache9C == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache9C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.set_m_fastLevelButtonInputField);
		}
		LuaObject.addMember(l, name57, get57, Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache9C, true);
		string name58 = "m_hero";
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache9D == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache9D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.get_m_hero);
		}
		LuaCSFunction get58 = Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache9D;
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache9E == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache9E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.set_m_hero);
		}
		LuaObject.addMember(l, name58, get58, Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache9E, true);
		string name59 = "isFirstIn";
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache9F == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache9F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.get_isFirstIn);
		}
		LuaCSFunction get59 = Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cache9F;
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cacheA0 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cacheA0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.set_isFirstIn);
		}
		LuaObject.addMember(l, name59, get59, Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cacheA0, true);
		string name60 = "m_isMale";
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cacheA1 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cacheA1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.get_m_isMale);
		}
		LuaCSFunction get60 = Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cacheA1;
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cacheA2 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cacheA2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.set_m_isMale);
		}
		LuaObject.addMember(l, name60, get60, Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cacheA2, true);
		string name61 = "m_curFetterSkillCtrl";
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cacheA3 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cacheA3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.get_m_curFetterSkillCtrl);
		}
		LuaCSFunction get61 = Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cacheA3;
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cacheA4 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cacheA4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.set_m_curFetterSkillCtrl);
		}
		LuaObject.addMember(l, name61, get61, Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cacheA4, true);
		string name62 = "m_playerContext";
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cacheA5 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cacheA5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.get_m_playerContext);
		}
		LuaCSFunction get62 = Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cacheA5;
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cacheA6 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cacheA6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.set_m_playerContext);
		}
		LuaObject.addMember(l, name62, get62, Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cacheA6, true);
		string name63 = "m_configDataLoader";
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cacheA7 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cacheA7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.get_m_configDataLoader);
		}
		LuaCSFunction get63 = Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cacheA7;
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cacheA8 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cacheA8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.set_m_configDataLoader);
		}
		LuaObject.addMember(l, name63, get63, Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.<>f__mg$cacheA8, true);
		LuaObject.createTypeMetatable(l, null, typeof(FettersConfessionUIController), typeof(UIControllerBase));
	}

	// Token: 0x04013C77 RID: 81015
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04013C78 RID: 81016
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04013C79 RID: 81017
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04013C7A RID: 81018
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04013C7B RID: 81019
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04013C7C RID: 81020
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04013C7D RID: 81021
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04013C7E RID: 81022
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04013C7F RID: 81023
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04013C80 RID: 81024
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04013C81 RID: 81025
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04013C82 RID: 81026
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04013C83 RID: 81027
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04013C84 RID: 81028
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04013C85 RID: 81029
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04013C86 RID: 81030
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04013C87 RID: 81031
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04013C88 RID: 81032
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04013C89 RID: 81033
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04013C8A RID: 81034
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04013C8B RID: 81035
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04013C8C RID: 81036
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04013C8D RID: 81037
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04013C8E RID: 81038
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04013C8F RID: 81039
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04013C90 RID: 81040
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04013C91 RID: 81041
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04013C92 RID: 81042
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04013C93 RID: 81043
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04013C94 RID: 81044
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04013C95 RID: 81045
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04013C96 RID: 81046
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04013C97 RID: 81047
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04013C98 RID: 81048
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04013C99 RID: 81049
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04013C9A RID: 81050
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04013C9B RID: 81051
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04013C9C RID: 81052
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04013C9D RID: 81053
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04013C9E RID: 81054
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04013C9F RID: 81055
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04013CA0 RID: 81056
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04013CA1 RID: 81057
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04013CA2 RID: 81058
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04013CA3 RID: 81059
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04013CA4 RID: 81060
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04013CA5 RID: 81061
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04013CA6 RID: 81062
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04013CA7 RID: 81063
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04013CA8 RID: 81064
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04013CA9 RID: 81065
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x04013CAA RID: 81066
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x04013CAB RID: 81067
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x04013CAC RID: 81068
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x04013CAD RID: 81069
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x04013CAE RID: 81070
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x04013CAF RID: 81071
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x04013CB0 RID: 81072
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x04013CB1 RID: 81073
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x04013CB2 RID: 81074
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x04013CB3 RID: 81075
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x04013CB4 RID: 81076
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x04013CB5 RID: 81077
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x04013CB6 RID: 81078
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x04013CB7 RID: 81079
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x04013CB8 RID: 81080
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x04013CB9 RID: 81081
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x04013CBA RID: 81082
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x04013CBB RID: 81083
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x04013CBC RID: 81084
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x04013CBD RID: 81085
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;

	// Token: 0x04013CBE RID: 81086
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache47;

	// Token: 0x04013CBF RID: 81087
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache48;

	// Token: 0x04013CC0 RID: 81088
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache49;

	// Token: 0x04013CC1 RID: 81089
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4A;

	// Token: 0x04013CC2 RID: 81090
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4B;

	// Token: 0x04013CC3 RID: 81091
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4C;

	// Token: 0x04013CC4 RID: 81092
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4D;

	// Token: 0x04013CC5 RID: 81093
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4E;

	// Token: 0x04013CC6 RID: 81094
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4F;

	// Token: 0x04013CC7 RID: 81095
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache50;

	// Token: 0x04013CC8 RID: 81096
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache51;

	// Token: 0x04013CC9 RID: 81097
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache52;

	// Token: 0x04013CCA RID: 81098
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache53;

	// Token: 0x04013CCB RID: 81099
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache54;

	// Token: 0x04013CCC RID: 81100
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache55;

	// Token: 0x04013CCD RID: 81101
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache56;

	// Token: 0x04013CCE RID: 81102
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache57;

	// Token: 0x04013CCF RID: 81103
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache58;

	// Token: 0x04013CD0 RID: 81104
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache59;

	// Token: 0x04013CD1 RID: 81105
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5A;

	// Token: 0x04013CD2 RID: 81106
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5B;

	// Token: 0x04013CD3 RID: 81107
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5C;

	// Token: 0x04013CD4 RID: 81108
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5D;

	// Token: 0x04013CD5 RID: 81109
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5E;

	// Token: 0x04013CD6 RID: 81110
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5F;

	// Token: 0x04013CD7 RID: 81111
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache60;

	// Token: 0x04013CD8 RID: 81112
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache61;

	// Token: 0x04013CD9 RID: 81113
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache62;

	// Token: 0x04013CDA RID: 81114
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache63;

	// Token: 0x04013CDB RID: 81115
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache64;

	// Token: 0x04013CDC RID: 81116
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache65;

	// Token: 0x04013CDD RID: 81117
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache66;

	// Token: 0x04013CDE RID: 81118
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache67;

	// Token: 0x04013CDF RID: 81119
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache68;

	// Token: 0x04013CE0 RID: 81120
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache69;

	// Token: 0x04013CE1 RID: 81121
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6A;

	// Token: 0x04013CE2 RID: 81122
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6B;

	// Token: 0x04013CE3 RID: 81123
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6C;

	// Token: 0x04013CE4 RID: 81124
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6D;

	// Token: 0x04013CE5 RID: 81125
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6E;

	// Token: 0x04013CE6 RID: 81126
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6F;

	// Token: 0x04013CE7 RID: 81127
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache70;

	// Token: 0x04013CE8 RID: 81128
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache71;

	// Token: 0x04013CE9 RID: 81129
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache72;

	// Token: 0x04013CEA RID: 81130
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache73;

	// Token: 0x04013CEB RID: 81131
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache74;

	// Token: 0x04013CEC RID: 81132
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache75;

	// Token: 0x04013CED RID: 81133
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache76;

	// Token: 0x04013CEE RID: 81134
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache77;

	// Token: 0x04013CEF RID: 81135
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache78;

	// Token: 0x04013CF0 RID: 81136
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache79;

	// Token: 0x04013CF1 RID: 81137
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7A;

	// Token: 0x04013CF2 RID: 81138
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7B;

	// Token: 0x04013CF3 RID: 81139
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7C;

	// Token: 0x04013CF4 RID: 81140
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7D;

	// Token: 0x04013CF5 RID: 81141
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7E;

	// Token: 0x04013CF6 RID: 81142
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7F;

	// Token: 0x04013CF7 RID: 81143
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache80;

	// Token: 0x04013CF8 RID: 81144
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache81;

	// Token: 0x04013CF9 RID: 81145
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache82;

	// Token: 0x04013CFA RID: 81146
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache83;

	// Token: 0x04013CFB RID: 81147
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache84;

	// Token: 0x04013CFC RID: 81148
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache85;

	// Token: 0x04013CFD RID: 81149
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache86;

	// Token: 0x04013CFE RID: 81150
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache87;

	// Token: 0x04013CFF RID: 81151
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache88;

	// Token: 0x04013D00 RID: 81152
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache89;

	// Token: 0x04013D01 RID: 81153
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8A;

	// Token: 0x04013D02 RID: 81154
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8B;

	// Token: 0x04013D03 RID: 81155
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8C;

	// Token: 0x04013D04 RID: 81156
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8D;

	// Token: 0x04013D05 RID: 81157
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8E;

	// Token: 0x04013D06 RID: 81158
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8F;

	// Token: 0x04013D07 RID: 81159
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache90;

	// Token: 0x04013D08 RID: 81160
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache91;

	// Token: 0x04013D09 RID: 81161
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache92;

	// Token: 0x04013D0A RID: 81162
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache93;

	// Token: 0x04013D0B RID: 81163
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache94;

	// Token: 0x04013D0C RID: 81164
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache95;

	// Token: 0x04013D0D RID: 81165
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache96;

	// Token: 0x04013D0E RID: 81166
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache97;

	// Token: 0x04013D0F RID: 81167
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache98;

	// Token: 0x04013D10 RID: 81168
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache99;

	// Token: 0x04013D11 RID: 81169
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9A;

	// Token: 0x04013D12 RID: 81170
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9B;

	// Token: 0x04013D13 RID: 81171
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9C;

	// Token: 0x04013D14 RID: 81172
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9D;

	// Token: 0x04013D15 RID: 81173
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9E;

	// Token: 0x04013D16 RID: 81174
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9F;

	// Token: 0x04013D17 RID: 81175
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA0;

	// Token: 0x04013D18 RID: 81176
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA1;

	// Token: 0x04013D19 RID: 81177
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA2;

	// Token: 0x04013D1A RID: 81178
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA3;

	// Token: 0x04013D1B RID: 81179
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA4;

	// Token: 0x04013D1C RID: 81180
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA5;

	// Token: 0x04013D1D RID: 81181
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA6;

	// Token: 0x04013D1E RID: 81182
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA7;

	// Token: 0x04013D1F RID: 81183
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA8;
}
