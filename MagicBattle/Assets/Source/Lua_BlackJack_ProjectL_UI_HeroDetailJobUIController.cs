using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.Scene;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x020014B4 RID: 5300
[Preserve]
public class Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController : LuaObject
{
	// Token: 0x0601ED9A RID: 126362 RVA: 0x00A03E74 File Offset: 0x00A02074
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateViewInJobState(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			Hero hero;
			LuaObject.checkType<Hero>(l, 2, out hero);
			heroDetailJobUIController.UpdateViewInJobState(hero);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ED9B RID: 126363 RVA: 0x00A03ECC File Offset: 0x00A020CC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsJobLvUpgradeFinished(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			bool b = heroDetailJobUIController.IsJobLvUpgradeFinished();
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

	// Token: 0x0601ED9C RID: 126364 RVA: 0x00A03F20 File Offset: 0x00A02120
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetCommonUIState(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			string commonUIState;
			LuaObject.checkType(l, 2, out commonUIState);
			heroDetailJobUIController.SetCommonUIState(commonUIState);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ED9D RID: 126365 RVA: 0x00A03F78 File Offset: 0x00A02178
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			heroDetailJobUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ED9E RID: 126366 RVA: 0x00A03FCC File Offset: 0x00A021CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowJobDetailPanel(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			heroDetailJobUIController.m_luaExportHelper.ShowJobDetailPanel();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ED9F RID: 126367 RVA: 0x00A04020 File Offset: 0x00A02220
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowJobUpgradePanel(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			heroDetailJobUIController.m_luaExportHelper.ShowJobUpgradePanel();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EDA0 RID: 126368 RVA: 0x00A04074 File Offset: 0x00A02274
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetUpperLimitBreak(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			heroDetailJobUIController.m_luaExportHelper.SetUpperLimitBreak();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EDA1 RID: 126369 RVA: 0x00A040C8 File Offset: 0x00A022C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetPropertyLearned(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			heroDetailJobUIController.m_luaExportHelper.SetPropertyLearned();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EDA2 RID: 126370 RVA: 0x00A0411C File Offset: 0x00A0231C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnJobLearnedSkillClick(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			heroDetailJobUIController.m_luaExportHelper.OnJobLearnedSkillClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EDA3 RID: 126371 RVA: 0x00A04170 File Offset: 0x00A02370
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnJobLearnedSoldierClick(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			heroDetailJobUIController.m_luaExportHelper.OnJobLearnedSoldierClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EDA4 RID: 126372 RVA: 0x00A041C4 File Offset: 0x00A023C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnJobLearnedMasterClick(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			heroDetailJobUIController.m_luaExportHelper.OnJobLearnedMasterClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EDA5 RID: 126373 RVA: 0x00A04218 File Offset: 0x00A02418
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetJobLvMasterInfo(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			heroDetailJobUIController.m_luaExportHelper.SetJobLvMasterInfo();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EDA6 RID: 126374 RVA: 0x00A0426C File Offset: 0x00A0246C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetMasterRewardProperty(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			PropertyModifyType type;
			LuaObject.checkEnum<PropertyModifyType>(l, 2, out type);
			int value;
			LuaObject.checkType(l, 3, out value);
			heroDetailJobUIController.m_luaExportHelper.SetMasterRewardProperty(type, value);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EDA7 RID: 126375 RVA: 0x00A042D8 File Offset: 0x00A024D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowJobMaterialPanel(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			heroDetailJobUIController.m_luaExportHelper.ShowJobMaterialPanel();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EDA8 RID: 126376 RVA: 0x00A0432C File Offset: 0x00A0252C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnJobMaterialClick(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			JobMaterialEquipedUIController ctrl;
			LuaObject.checkType<JobMaterialEquipedUIController>(l, 2, out ctrl);
			heroDetailJobUIController.m_luaExportHelper.OnJobMaterialClick(ctrl);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EDA9 RID: 126377 RVA: 0x00A04388 File Offset: 0x00A02588
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnJobLvUpgradeButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			heroDetailJobUIController.m_luaExportHelper.OnJobLvUpgradeButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EDAA RID: 126378 RVA: 0x00A043DC File Offset: 0x00A025DC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnJobLvUpgradeSucceed(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			heroDetailJobUIController.m_luaExportHelper.OnJobLvUpgradeSucceed();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EDAB RID: 126379 RVA: 0x00A04430 File Offset: 0x00A02630
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int JobLVUpgradeEffect(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			IEnumerator o = heroDetailJobUIController.m_luaExportHelper.JobLVUpgradeEffect();
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

	// Token: 0x0601EDAC RID: 126380 RVA: 0x00A0448C File Offset: 0x00A0268C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetJobUpgradeInfo(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			heroDetailJobUIController.m_luaExportHelper.SetJobUpgradeInfo();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EDAD RID: 126381 RVA: 0x00A044E0 File Offset: 0x00A026E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowLearnedSkillAndSoldier(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			heroDetailJobUIController.m_luaExportHelper.ShowLearnedSkillAndSoldier();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EDAE RID: 126382 RVA: 0x00A04534 File Offset: 0x00A02734
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CloseLearnedSkillPanel(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			heroDetailJobUIController.m_luaExportHelper.CloseLearnedSkillPanel();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EDAF RID: 126383 RVA: 0x00A04588 File Offset: 0x00A02788
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnJobUpgradeGroupGoContinueBGButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			heroDetailJobUIController.m_luaExportHelper.OnJobUpgradeGroupGoContinueBGButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EDB0 RID: 126384 RVA: 0x00A045DC File Offset: 0x00A027DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnJobMasterRewardGroupGoReturnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			heroDetailJobUIController.m_luaExportHelper.OnJobMasterRewardGroupGoReturnButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EDB1 RID: 126385 RVA: 0x00A04630 File Offset: 0x00A02830
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CloseLearnedPanel(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			heroDetailJobUIController.m_luaExportHelper.CloseLearnedPanel();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EDB2 RID: 126386 RVA: 0x00A04684 File Offset: 0x00A02884
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StopAndCloseUIEffect(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			heroDetailJobUIController.m_luaExportHelper.StopAndCloseUIEffect();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EDB3 RID: 126387 RVA: 0x00A046D8 File Offset: 0x00A028D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			heroDetailJobUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EDB4 RID: 126388 RVA: 0x00A04744 File Offset: 0x00A02944
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			heroDetailJobUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EDB5 RID: 126389 RVA: 0x00A04798 File Offset: 0x00A02998
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			heroDetailJobUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EDB6 RID: 126390 RVA: 0x00A047EC File Offset: 0x00A029EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = heroDetailJobUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601EDB7 RID: 126391 RVA: 0x00A04894 File Offset: 0x00A02A94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			heroDetailJobUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EDB8 RID: 126392 RVA: 0x00A048E8 File Offset: 0x00A02AE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			heroDetailJobUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EDB9 RID: 126393 RVA: 0x00A04954 File Offset: 0x00A02B54
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetButtonClickListener(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(string[]), typeof(Action<UIControllerBase>)))
			{
				HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				heroDetailJobUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				HeroDetailJobUIController heroDetailJobUIController2 = (HeroDetailJobUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				heroDetailJobUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601EDBA RID: 126394 RVA: 0x00A04A64 File Offset: 0x00A02C64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroDetailJobUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EDBB RID: 126395 RVA: 0x00A04AD0 File Offset: 0x00A02CD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroDetailJobUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EDBC RID: 126396 RVA: 0x00A04B3C File Offset: 0x00A02D3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroDetailJobUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EDBD RID: 126397 RVA: 0x00A04BA8 File Offset: 0x00A02DA8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroDetailJobUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EDBE RID: 126398 RVA: 0x00A04C14 File Offset: 0x00A02E14
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetToggleValueChangedListener(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(string[]), typeof(Action<UIControllerBase, bool>)))
			{
				HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				heroDetailJobUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				HeroDetailJobUIController heroDetailJobUIController2 = (HeroDetailJobUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				heroDetailJobUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601EDBF RID: 126399 RVA: 0x00A04D24 File Offset: 0x00A02F24
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			string s = heroDetailJobUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601EDC0 RID: 126400 RVA: 0x00A04D80 File Offset: 0x00A02F80
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callDele_EventOnJobLvUpgrade(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			int arg;
			LuaObject.checkType(l, 2, out arg);
			int arg2;
			LuaObject.checkType(l, 3, out arg2);
			Action arg3;
			LuaObject.checkDelegate<Action>(l, 4, out arg3);
			heroDetailJobUIController.m_luaExportHelper.__callDele_EventOnJobLvUpgrade(arg, arg2, arg3);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EDC1 RID: 126401 RVA: 0x00A04DF8 File Offset: 0x00A02FF8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __clearDele_EventOnJobLvUpgrade(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			int arg;
			LuaObject.checkType(l, 2, out arg);
			int arg2;
			LuaObject.checkType(l, 3, out arg2);
			Action arg3;
			LuaObject.checkDelegate<Action>(l, 4, out arg3);
			heroDetailJobUIController.m_luaExportHelper.__clearDele_EventOnJobLvUpgrade(arg, arg2, arg3);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EDC2 RID: 126402 RVA: 0x00A04E70 File Offset: 0x00A03070
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnShowGetPath(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			GoodsType arg;
			LuaObject.checkEnum<GoodsType>(l, 2, out arg);
			int arg2;
			LuaObject.checkType(l, 3, out arg2);
			int arg3;
			LuaObject.checkType(l, 4, out arg3);
			heroDetailJobUIController.m_luaExportHelper.__callDele_EventOnShowGetPath(arg, arg2, arg3);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EDC3 RID: 126403 RVA: 0x00A04EE8 File Offset: 0x00A030E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnShowGetPath(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			GoodsType arg;
			LuaObject.checkEnum<GoodsType>(l, 2, out arg);
			int arg2;
			LuaObject.checkType(l, 3, out arg2);
			int arg3;
			LuaObject.checkType(l, 4, out arg3);
			heroDetailJobUIController.m_luaExportHelper.__clearDele_EventOnShowGetPath(arg, arg2, arg3);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EDC4 RID: 126404 RVA: 0x00A04F60 File Offset: 0x00A03160
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnUpdateView(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			heroDetailJobUIController.m_luaExportHelper.__callDele_EventOnUpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EDC5 RID: 126405 RVA: 0x00A04FB4 File Offset: 0x00A031B4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __clearDele_EventOnUpdateView(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			heroDetailJobUIController.m_luaExportHelper.__clearDele_EventOnUpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EDC6 RID: 126406 RVA: 0x00A05008 File Offset: 0x00A03208
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_marginTransform(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailJobUIController.m_luaExportHelper.m_marginTransform);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EDC7 RID: 126407 RVA: 0x00A05060 File Offset: 0x00A03260
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_marginTransform(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			RectTransform marginTransform;
			LuaObject.checkType<RectTransform>(l, 2, out marginTransform);
			heroDetailJobUIController.m_luaExportHelper.m_marginTransform = marginTransform;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EDC8 RID: 126408 RVA: 0x00A050BC File Offset: 0x00A032BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_infoPanelStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailJobUIController.m_luaExportHelper.m_infoPanelStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EDC9 RID: 126409 RVA: 0x00A05114 File Offset: 0x00A03314
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_infoPanelStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			CommonUIStateController infoPanelStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out infoPanelStateCtrl);
			heroDetailJobUIController.m_luaExportHelper.m_infoPanelStateCtrl = infoPanelStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EDCA RID: 126410 RVA: 0x00A05170 File Offset: 0x00A03370
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_jobNameText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailJobUIController.m_luaExportHelper.m_jobNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EDCB RID: 126411 RVA: 0x00A051C8 File Offset: 0x00A033C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_jobNameText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			Text jobNameText;
			LuaObject.checkType<Text>(l, 2, out jobNameText);
			heroDetailJobUIController.m_luaExportHelper.m_jobNameText = jobNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EDCC RID: 126412 RVA: 0x00A05224 File Offset: 0x00A03424
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_jobDescText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailJobUIController.m_luaExportHelper.m_jobDescText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EDCD RID: 126413 RVA: 0x00A0527C File Offset: 0x00A0347C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_jobDescText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			Text jobDescText;
			LuaObject.checkType<Text>(l, 2, out jobDescText);
			heroDetailJobUIController.m_luaExportHelper.m_jobDescText = jobDescText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EDCE RID: 126414 RVA: 0x00A052D8 File Offset: 0x00A034D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_jobArmyImage(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailJobUIController.m_luaExportHelper.m_jobArmyImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EDCF RID: 126415 RVA: 0x00A05330 File Offset: 0x00A03530
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_jobArmyImage(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			Image jobArmyImage;
			LuaObject.checkType<Image>(l, 2, out jobArmyImage);
			heroDetailJobUIController.m_luaExportHelper.m_jobArmyImage = jobArmyImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EDD0 RID: 126416 RVA: 0x00A0538C File Offset: 0x00A0358C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_curJobUpgradeGo(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailJobUIController.m_luaExportHelper.m_curJobUpgradeGo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EDD1 RID: 126417 RVA: 0x00A053E4 File Offset: 0x00A035E4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_curJobUpgradeGo(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			GameObject curJobUpgradeGo;
			LuaObject.checkType<GameObject>(l, 2, out curJobUpgradeGo);
			heroDetailJobUIController.m_luaExportHelper.m_curJobUpgradeGo = curJobUpgradeGo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EDD2 RID: 126418 RVA: 0x00A05440 File Offset: 0x00A03640
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_curJobLv(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailJobUIController.m_luaExportHelper.m_curJobLv);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EDD3 RID: 126419 RVA: 0x00A05498 File Offset: 0x00A03698
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_curJobLv(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			GameObject curJobLv;
			LuaObject.checkType<GameObject>(l, 2, out curJobLv);
			heroDetailJobUIController.m_luaExportHelper.m_curJobLv = curJobLv;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EDD4 RID: 126420 RVA: 0x00A054F4 File Offset: 0x00A036F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_curJobLvBg(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailJobUIController.m_luaExportHelper.m_curJobLvBg);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EDD5 RID: 126421 RVA: 0x00A0554C File Offset: 0x00A0374C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_curJobLvBg(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			GameObject curJobLvBg;
			LuaObject.checkType<GameObject>(l, 2, out curJobLvBg);
			heroDetailJobUIController.m_luaExportHelper.m_curJobLvBg = curJobLvBg;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EDD6 RID: 126422 RVA: 0x00A055A8 File Offset: 0x00A037A8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_nextJobLvObj(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailJobUIController.m_luaExportHelper.m_nextJobLvObj);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EDD7 RID: 126423 RVA: 0x00A05600 File Offset: 0x00A03800
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_nextJobLvObj(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			GameObject nextJobLvObj;
			LuaObject.checkType<GameObject>(l, 2, out nextJobLvObj);
			heroDetailJobUIController.m_luaExportHelper.m_nextJobLvObj = nextJobLvObj;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EDD8 RID: 126424 RVA: 0x00A0565C File Offset: 0x00A0385C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_nextJobLv(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailJobUIController.m_luaExportHelper.m_nextJobLv);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EDD9 RID: 126425 RVA: 0x00A056B4 File Offset: 0x00A038B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_nextJobLv(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			GameObject nextJobLv;
			LuaObject.checkType<GameObject>(l, 2, out nextJobLv);
			heroDetailJobUIController.m_luaExportHelper.m_nextJobLv = nextJobLv;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EDDA RID: 126426 RVA: 0x00A05710 File Offset: 0x00A03910
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_nextJobLvBg(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailJobUIController.m_luaExportHelper.m_nextJobLvBg);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EDDB RID: 126427 RVA: 0x00A05768 File Offset: 0x00A03968
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_nextJobLvBg(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			GameObject nextJobLvBg;
			LuaObject.checkType<GameObject>(l, 2, out nextJobLvBg);
			heroDetailJobUIController.m_luaExportHelper.m_nextJobLvBg = nextJobLvBg;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EDDC RID: 126428 RVA: 0x00A057C4 File Offset: 0x00A039C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_jobMasterImg(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailJobUIController.m_luaExportHelper.m_jobMasterImg);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EDDD RID: 126429 RVA: 0x00A0581C File Offset: 0x00A03A1C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_jobMasterImg(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			GameObject jobMasterImg;
			LuaObject.checkType<GameObject>(l, 2, out jobMasterImg);
			heroDetailJobUIController.m_luaExportHelper.m_jobMasterImg = jobMasterImg;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EDDE RID: 126430 RVA: 0x00A05878 File Offset: 0x00A03A78
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_jobLvArrowObj(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailJobUIController.m_luaExportHelper.m_jobLvArrowObj);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EDDF RID: 126431 RVA: 0x00A058D0 File Offset: 0x00A03AD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_jobLvArrowObj(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			GameObject jobLvArrowObj;
			LuaObject.checkType<GameObject>(l, 2, out jobLvArrowObj);
			heroDetailJobUIController.m_luaExportHelper.m_jobLvArrowObj = jobLvArrowObj;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EDE0 RID: 126432 RVA: 0x00A0592C File Offset: 0x00A03B2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_jobUpGameObject(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailJobUIController.m_luaExportHelper.m_jobUpGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EDE1 RID: 126433 RVA: 0x00A05984 File Offset: 0x00A03B84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_jobUpGameObject(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			GameObject jobUpGameObject;
			LuaObject.checkType<GameObject>(l, 2, out jobUpGameObject);
			heroDetailJobUIController.m_luaExportHelper.m_jobUpGameObject = jobUpGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EDE2 RID: 126434 RVA: 0x00A059E0 File Offset: 0x00A03BE0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_jobLearnedSkill(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailJobUIController.m_luaExportHelper.m_jobLearnedSkill);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EDE3 RID: 126435 RVA: 0x00A05A38 File Offset: 0x00A03C38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_jobLearnedSkill(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			GameObject jobLearnedSkill;
			LuaObject.checkType<GameObject>(l, 2, out jobLearnedSkill);
			heroDetailJobUIController.m_luaExportHelper.m_jobLearnedSkill = jobLearnedSkill;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EDE4 RID: 126436 RVA: 0x00A05A94 File Offset: 0x00A03C94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_jobLearnedSkillIconImage(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailJobUIController.m_luaExportHelper.m_jobLearnedSkillIconImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EDE5 RID: 126437 RVA: 0x00A05AEC File Offset: 0x00A03CEC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_jobLearnedSkillIconImage(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			Image jobLearnedSkillIconImage;
			LuaObject.checkType<Image>(l, 2, out jobLearnedSkillIconImage);
			heroDetailJobUIController.m_luaExportHelper.m_jobLearnedSkillIconImage = jobLearnedSkillIconImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EDE6 RID: 126438 RVA: 0x00A05B48 File Offset: 0x00A03D48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_jobLearnedSkillNameText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailJobUIController.m_luaExportHelper.m_jobLearnedSkillNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EDE7 RID: 126439 RVA: 0x00A05BA0 File Offset: 0x00A03DA0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_jobLearnedSkillNameText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			Text jobLearnedSkillNameText;
			LuaObject.checkType<Text>(l, 2, out jobLearnedSkillNameText);
			heroDetailJobUIController.m_luaExportHelper.m_jobLearnedSkillNameText = jobLearnedSkillNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EDE8 RID: 126440 RVA: 0x00A05BFC File Offset: 0x00A03DFC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_jobLearnedSoldier(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailJobUIController.m_luaExportHelper.m_jobLearnedSoldier);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EDE9 RID: 126441 RVA: 0x00A05C54 File Offset: 0x00A03E54
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_jobLearnedSoldier(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			GameObject jobLearnedSoldier;
			LuaObject.checkType<GameObject>(l, 2, out jobLearnedSoldier);
			heroDetailJobUIController.m_luaExportHelper.m_jobLearnedSoldier = jobLearnedSoldier;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EDEA RID: 126442 RVA: 0x00A05CB0 File Offset: 0x00A03EB0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_jobLearnedSoldierIconImage(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailJobUIController.m_luaExportHelper.m_jobLearnedSoldierIconImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EDEB RID: 126443 RVA: 0x00A05D08 File Offset: 0x00A03F08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_jobLearnedSoldierIconImage(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			Image jobLearnedSoldierIconImage;
			LuaObject.checkType<Image>(l, 2, out jobLearnedSoldierIconImage);
			heroDetailJobUIController.m_luaExportHelper.m_jobLearnedSoldierIconImage = jobLearnedSoldierIconImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EDEC RID: 126444 RVA: 0x00A05D64 File Offset: 0x00A03F64
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_jobLearnedSoldierNameText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailJobUIController.m_luaExportHelper.m_jobLearnedSoldierNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EDED RID: 126445 RVA: 0x00A05DBC File Offset: 0x00A03FBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_jobLearnedSoldierNameText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			Text jobLearnedSoldierNameText;
			LuaObject.checkType<Text>(l, 2, out jobLearnedSoldierNameText);
			heroDetailJobUIController.m_luaExportHelper.m_jobLearnedSoldierNameText = jobLearnedSoldierNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EDEE RID: 126446 RVA: 0x00A05E18 File Offset: 0x00A04018
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_jobLearnedMaster(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailJobUIController.m_luaExportHelper.m_jobLearnedMaster);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EDEF RID: 126447 RVA: 0x00A05E70 File Offset: 0x00A04070
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_jobLearnedMaster(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			GameObject jobLearnedMaster;
			LuaObject.checkType<GameObject>(l, 2, out jobLearnedMaster);
			heroDetailJobUIController.m_luaExportHelper.m_jobLearnedMaster = jobLearnedMaster;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EDF0 RID: 126448 RVA: 0x00A05ECC File Offset: 0x00A040CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_jobDescContent(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailJobUIController.m_luaExportHelper.m_jobDescContent);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EDF1 RID: 126449 RVA: 0x00A05F24 File Offset: 0x00A04124
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_jobDescContent(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			GameObject jobDescContent;
			LuaObject.checkType<GameObject>(l, 2, out jobDescContent);
			heroDetailJobUIController.m_luaExportHelper.m_jobDescContent = jobDescContent;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EDF2 RID: 126450 RVA: 0x00A05F80 File Offset: 0x00A04180
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_masterRewardPanel(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailJobUIController.m_luaExportHelper.m_masterRewardPanel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EDF3 RID: 126451 RVA: 0x00A05FD8 File Offset: 0x00A041D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_masterRewardPanel(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			GameObject masterRewardPanel;
			LuaObject.checkType<GameObject>(l, 2, out masterRewardPanel);
			heroDetailJobUIController.m_luaExportHelper.m_masterRewardPanel = masterRewardPanel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EDF4 RID: 126452 RVA: 0x00A06034 File Offset: 0x00A04234
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_propAddObj(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailJobUIController.m_luaExportHelper.m_propAddObj);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EDF5 RID: 126453 RVA: 0x00A0608C File Offset: 0x00A0428C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_propAddObj(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			GameObject propAddObj;
			LuaObject.checkType<GameObject>(l, 2, out propAddObj);
			heroDetailJobUIController.m_luaExportHelper.m_propAddObj = propAddObj;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EDF6 RID: 126454 RVA: 0x00A060E8 File Offset: 0x00A042E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_masterRewardPanelJobIcon(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailJobUIController.m_luaExportHelper.m_masterRewardPanelJobIcon);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EDF7 RID: 126455 RVA: 0x00A06140 File Offset: 0x00A04340
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_masterRewardPanelJobIcon(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			Image masterRewardPanelJobIcon;
			LuaObject.checkType<Image>(l, 2, out masterRewardPanelJobIcon);
			heroDetailJobUIController.m_luaExportHelper.m_masterRewardPanelJobIcon = masterRewardPanelJobIcon;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EDF8 RID: 126456 RVA: 0x00A0619C File Offset: 0x00A0439C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_masterRewardPanelNameText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailJobUIController.m_luaExportHelper.m_masterRewardPanelNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EDF9 RID: 126457 RVA: 0x00A061F4 File Offset: 0x00A043F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_masterRewardPanelNameText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			Text masterRewardPanelNameText;
			LuaObject.checkType<Text>(l, 2, out masterRewardPanelNameText);
			heroDetailJobUIController.m_luaExportHelper.m_masterRewardPanelNameText = masterRewardPanelNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EDFA RID: 126458 RVA: 0x00A06250 File Offset: 0x00A04450
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_propHPAddValueText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailJobUIController.m_luaExportHelper.m_propHPAddValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EDFB RID: 126459 RVA: 0x00A062A8 File Offset: 0x00A044A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_propHPAddValueText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			Text propHPAddValueText;
			LuaObject.checkType<Text>(l, 2, out propHPAddValueText);
			heroDetailJobUIController.m_luaExportHelper.m_propHPAddValueText = propHPAddValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EDFC RID: 126460 RVA: 0x00A06304 File Offset: 0x00A04504
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_propATAddValueText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailJobUIController.m_luaExportHelper.m_propATAddValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EDFD RID: 126461 RVA: 0x00A0635C File Offset: 0x00A0455C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_propATAddValueText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			Text propATAddValueText;
			LuaObject.checkType<Text>(l, 2, out propATAddValueText);
			heroDetailJobUIController.m_luaExportHelper.m_propATAddValueText = propATAddValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EDFE RID: 126462 RVA: 0x00A063B8 File Offset: 0x00A045B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_propDFAddValueText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailJobUIController.m_luaExportHelper.m_propDFAddValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EDFF RID: 126463 RVA: 0x00A06410 File Offset: 0x00A04610
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_propDFAddValueText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			Text propDFAddValueText;
			LuaObject.checkType<Text>(l, 2, out propDFAddValueText);
			heroDetailJobUIController.m_luaExportHelper.m_propDFAddValueText = propDFAddValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE00 RID: 126464 RVA: 0x00A0646C File Offset: 0x00A0466C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_propMagicAddValueText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailJobUIController.m_luaExportHelper.m_propMagicAddValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE01 RID: 126465 RVA: 0x00A064C4 File Offset: 0x00A046C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_propMagicAddValueText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			Text propMagicAddValueText;
			LuaObject.checkType<Text>(l, 2, out propMagicAddValueText);
			heroDetailJobUIController.m_luaExportHelper.m_propMagicAddValueText = propMagicAddValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE02 RID: 126466 RVA: 0x00A06520 File Offset: 0x00A04720
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_propMagicDFAddValueText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailJobUIController.m_luaExportHelper.m_propMagicDFAddValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE03 RID: 126467 RVA: 0x00A06578 File Offset: 0x00A04778
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_propMagicDFAddValueText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			Text propMagicDFAddValueText;
			LuaObject.checkType<Text>(l, 2, out propMagicDFAddValueText);
			heroDetailJobUIController.m_luaExportHelper.m_propMagicDFAddValueText = propMagicDFAddValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE04 RID: 126468 RVA: 0x00A065D4 File Offset: 0x00A047D4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_propDEXAddValueText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailJobUIController.m_luaExportHelper.m_propDEXAddValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE05 RID: 126469 RVA: 0x00A0662C File Offset: 0x00A0482C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_propDEXAddValueText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			Text propDEXAddValueText;
			LuaObject.checkType<Text>(l, 2, out propDEXAddValueText);
			heroDetailJobUIController.m_luaExportHelper.m_propDEXAddValueText = propDEXAddValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE06 RID: 126470 RVA: 0x00A06688 File Offset: 0x00A04888
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_propHPAddObj(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailJobUIController.m_luaExportHelper.m_propHPAddObj);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE07 RID: 126471 RVA: 0x00A066E0 File Offset: 0x00A048E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_propHPAddObj(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			GameObject propHPAddObj;
			LuaObject.checkType<GameObject>(l, 2, out propHPAddObj);
			heroDetailJobUIController.m_luaExportHelper.m_propHPAddObj = propHPAddObj;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE08 RID: 126472 RVA: 0x00A0673C File Offset: 0x00A0493C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_propATAddObj(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailJobUIController.m_luaExportHelper.m_propATAddObj);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE09 RID: 126473 RVA: 0x00A06794 File Offset: 0x00A04994
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_propATAddObj(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			GameObject propATAddObj;
			LuaObject.checkType<GameObject>(l, 2, out propATAddObj);
			heroDetailJobUIController.m_luaExportHelper.m_propATAddObj = propATAddObj;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE0A RID: 126474 RVA: 0x00A067F0 File Offset: 0x00A049F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_propDFAddObj(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailJobUIController.m_luaExportHelper.m_propDFAddObj);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE0B RID: 126475 RVA: 0x00A06848 File Offset: 0x00A04A48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_propDFAddObj(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			GameObject propDFAddObj;
			LuaObject.checkType<GameObject>(l, 2, out propDFAddObj);
			heroDetailJobUIController.m_luaExportHelper.m_propDFAddObj = propDFAddObj;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE0C RID: 126476 RVA: 0x00A068A4 File Offset: 0x00A04AA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_propMagicAddObj(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailJobUIController.m_luaExportHelper.m_propMagicAddObj);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE0D RID: 126477 RVA: 0x00A068FC File Offset: 0x00A04AFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_propMagicAddObj(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			GameObject propMagicAddObj;
			LuaObject.checkType<GameObject>(l, 2, out propMagicAddObj);
			heroDetailJobUIController.m_luaExportHelper.m_propMagicAddObj = propMagicAddObj;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE0E RID: 126478 RVA: 0x00A06958 File Offset: 0x00A04B58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_propMagicDFAddObj(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailJobUIController.m_luaExportHelper.m_propMagicDFAddObj);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE0F RID: 126479 RVA: 0x00A069B0 File Offset: 0x00A04BB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_propMagicDFAddObj(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			GameObject propMagicDFAddObj;
			LuaObject.checkType<GameObject>(l, 2, out propMagicDFAddObj);
			heroDetailJobUIController.m_luaExportHelper.m_propMagicDFAddObj = propMagicDFAddObj;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE10 RID: 126480 RVA: 0x00A06A0C File Offset: 0x00A04C0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_propDEXAddObj(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailJobUIController.m_luaExportHelper.m_propDEXAddObj);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE11 RID: 126481 RVA: 0x00A06A64 File Offset: 0x00A04C64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_propDEXAddObj(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			GameObject propDEXAddObj;
			LuaObject.checkType<GameObject>(l, 2, out propDEXAddObj);
			heroDetailJobUIController.m_luaExportHelper.m_propDEXAddObj = propDEXAddObj;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE12 RID: 126482 RVA: 0x00A06AC0 File Offset: 0x00A04CC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_jobMaterialObj(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailJobUIController.m_luaExportHelper.m_jobMaterialObj);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE13 RID: 126483 RVA: 0x00A06B18 File Offset: 0x00A04D18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_jobMaterialObj(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			GameObject jobMaterialObj;
			LuaObject.checkType<GameObject>(l, 2, out jobMaterialObj);
			heroDetailJobUIController.m_luaExportHelper.m_jobMaterialObj = jobMaterialObj;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE14 RID: 126484 RVA: 0x00A06B74 File Offset: 0x00A04D74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_jobMaterialObj1(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailJobUIController.m_luaExportHelper.m_jobMaterialObj1);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE15 RID: 126485 RVA: 0x00A06BCC File Offset: 0x00A04DCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_jobMaterialObj1(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			GameObject jobMaterialObj;
			LuaObject.checkType<GameObject>(l, 2, out jobMaterialObj);
			heroDetailJobUIController.m_luaExportHelper.m_jobMaterialObj1 = jobMaterialObj;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE16 RID: 126486 RVA: 0x00A06C28 File Offset: 0x00A04E28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_jobMaterialObj2(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailJobUIController.m_luaExportHelper.m_jobMaterialObj2);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE17 RID: 126487 RVA: 0x00A06C80 File Offset: 0x00A04E80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_jobMaterialObj2(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			GameObject jobMaterialObj;
			LuaObject.checkType<GameObject>(l, 2, out jobMaterialObj);
			heroDetailJobUIController.m_luaExportHelper.m_jobMaterialObj2 = jobMaterialObj;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE18 RID: 126488 RVA: 0x00A06CDC File Offset: 0x00A04EDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_jobMaterialObj3(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailJobUIController.m_luaExportHelper.m_jobMaterialObj3);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE19 RID: 126489 RVA: 0x00A06D34 File Offset: 0x00A04F34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_jobMaterialObj3(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			GameObject jobMaterialObj;
			LuaObject.checkType<GameObject>(l, 2, out jobMaterialObj);
			heroDetailJobUIController.m_luaExportHelper.m_jobMaterialObj3 = jobMaterialObj;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE1A RID: 126490 RVA: 0x00A06D90 File Offset: 0x00A04F90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_jobLvUpgradeButton(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailJobUIController.m_luaExportHelper.m_jobLvUpgradeButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE1B RID: 126491 RVA: 0x00A06DE8 File Offset: 0x00A04FE8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_jobLvUpgradeButton(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			Button jobLvUpgradeButton;
			LuaObject.checkType<Button>(l, 2, out jobLvUpgradeButton);
			heroDetailJobUIController.m_luaExportHelper.m_jobLvUpgradeButton = jobLvUpgradeButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE1C RID: 126492 RVA: 0x00A06E44 File Offset: 0x00A05044
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_jobMaterialLvLimitCtrl(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailJobUIController.m_luaExportHelper.m_jobMaterialLvLimitCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE1D RID: 126493 RVA: 0x00A06E9C File Offset: 0x00A0509C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_jobMaterialLvLimitCtrl(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			CommonUIStateController jobMaterialLvLimitCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out jobMaterialLvLimitCtrl);
			heroDetailJobUIController.m_luaExportHelper.m_jobMaterialLvLimitCtrl = jobMaterialLvLimitCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE1E RID: 126494 RVA: 0x00A06EF8 File Offset: 0x00A050F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_jobMaterialLvLimitText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailJobUIController.m_luaExportHelper.m_jobMaterialLvLimitText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE1F RID: 126495 RVA: 0x00A06F50 File Offset: 0x00A05150
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_jobMaterialLvLimitText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			Text jobMaterialLvLimitText;
			LuaObject.checkType<Text>(l, 2, out jobMaterialLvLimitText);
			heroDetailJobUIController.m_luaExportHelper.m_jobMaterialLvLimitText = jobMaterialLvLimitText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE20 RID: 126496 RVA: 0x00A06FAC File Offset: 0x00A051AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_jobLvUpgradeBtnArtEffect(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailJobUIController.m_luaExportHelper.m_jobLvUpgradeBtnArtEffect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE21 RID: 126497 RVA: 0x00A07004 File Offset: 0x00A05204
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_jobLvUpgradeBtnArtEffect(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			GameObject jobLvUpgradeBtnArtEffect;
			LuaObject.checkType<GameObject>(l, 2, out jobLvUpgradeBtnArtEffect);
			heroDetailJobUIController.m_luaExportHelper.m_jobLvUpgradeBtnArtEffect = jobLvUpgradeBtnArtEffect;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE22 RID: 126498 RVA: 0x00A07060 File Offset: 0x00A05260
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_jobLvUpgradeFrameEffect(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailJobUIController.m_luaExportHelper.m_jobLvUpgradeFrameEffect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE23 RID: 126499 RVA: 0x00A070B8 File Offset: 0x00A052B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_jobLvUpgradeFrameEffect(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			GameObject jobLvUpgradeFrameEffect;
			LuaObject.checkType<GameObject>(l, 2, out jobLvUpgradeFrameEffect);
			heroDetailJobUIController.m_luaExportHelper.m_jobLvUpgradeFrameEffect = jobLvUpgradeFrameEffect;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE24 RID: 126500 RVA: 0x00A07114 File Offset: 0x00A05314
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_jobLvUpgradeFlyEffect(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailJobUIController.m_luaExportHelper.m_jobLvUpgradeFlyEffect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE25 RID: 126501 RVA: 0x00A0716C File Offset: 0x00A0536C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_jobLvUpgradeFlyEffect(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			GameObject jobLvUpgradeFlyEffect;
			LuaObject.checkType<GameObject>(l, 2, out jobLvUpgradeFlyEffect);
			heroDetailJobUIController.m_luaExportHelper.m_jobLvUpgradeFlyEffect = jobLvUpgradeFlyEffect;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE26 RID: 126502 RVA: 0x00A071C8 File Offset: 0x00A053C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_jobLvUpgradeFlyEffectIcon1(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailJobUIController.m_luaExportHelper.m_jobLvUpgradeFlyEffectIcon1);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE27 RID: 126503 RVA: 0x00A07220 File Offset: 0x00A05420
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_jobLvUpgradeFlyEffectIcon1(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			Image jobLvUpgradeFlyEffectIcon;
			LuaObject.checkType<Image>(l, 2, out jobLvUpgradeFlyEffectIcon);
			heroDetailJobUIController.m_luaExportHelper.m_jobLvUpgradeFlyEffectIcon1 = jobLvUpgradeFlyEffectIcon;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE28 RID: 126504 RVA: 0x00A0727C File Offset: 0x00A0547C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_jobLvUpgradeFlyEffectIcon2(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailJobUIController.m_luaExportHelper.m_jobLvUpgradeFlyEffectIcon2);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE29 RID: 126505 RVA: 0x00A072D4 File Offset: 0x00A054D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_jobLvUpgradeFlyEffectIcon2(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			Image jobLvUpgradeFlyEffectIcon;
			LuaObject.checkType<Image>(l, 2, out jobLvUpgradeFlyEffectIcon);
			heroDetailJobUIController.m_luaExportHelper.m_jobLvUpgradeFlyEffectIcon2 = jobLvUpgradeFlyEffectIcon;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE2A RID: 126506 RVA: 0x00A07330 File Offset: 0x00A05530
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_jobLvUpgradeFlyEffectIcon3(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailJobUIController.m_luaExportHelper.m_jobLvUpgradeFlyEffectIcon3);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE2B RID: 126507 RVA: 0x00A07388 File Offset: 0x00A05588
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_jobLvUpgradeFlyEffectIcon3(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			Image jobLvUpgradeFlyEffectIcon;
			LuaObject.checkType<Image>(l, 2, out jobLvUpgradeFlyEffectIcon);
			heroDetailJobUIController.m_luaExportHelper.m_jobLvUpgradeFlyEffectIcon3 = jobLvUpgradeFlyEffectIcon;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE2C RID: 126508 RVA: 0x00A073E4 File Offset: 0x00A055E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_jobLvUpgradeFlyEffectIcon4(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailJobUIController.m_luaExportHelper.m_jobLvUpgradeFlyEffectIcon4);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE2D RID: 126509 RVA: 0x00A0743C File Offset: 0x00A0563C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_jobLvUpgradeFlyEffectIcon4(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			Image jobLvUpgradeFlyEffectIcon;
			LuaObject.checkType<Image>(l, 2, out jobLvUpgradeFlyEffectIcon);
			heroDetailJobUIController.m_luaExportHelper.m_jobLvUpgradeFlyEffectIcon4 = jobLvUpgradeFlyEffectIcon;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE2E RID: 126510 RVA: 0x00A07498 File Offset: 0x00A05698
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_jobLvUpgradeStarUpEffect(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailJobUIController.m_luaExportHelper.m_jobLvUpgradeStarUpEffect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE2F RID: 126511 RVA: 0x00A074F0 File Offset: 0x00A056F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_jobLvUpgradeStarUpEffect(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			GameObject jobLvUpgradeStarUpEffect;
			LuaObject.checkType<GameObject>(l, 2, out jobLvUpgradeStarUpEffect);
			heroDetailJobUIController.m_luaExportHelper.m_jobLvUpgradeStarUpEffect = jobLvUpgradeStarUpEffect;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE30 RID: 126512 RVA: 0x00A0754C File Offset: 0x00A0574C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_jobMasterRewardGroupGo(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailJobUIController.m_luaExportHelper.m_jobMasterRewardGroupGo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE31 RID: 126513 RVA: 0x00A075A4 File Offset: 0x00A057A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_jobMasterRewardGroupGo(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			GameObject jobMasterRewardGroupGo;
			LuaObject.checkType<GameObject>(l, 2, out jobMasterRewardGroupGo);
			heroDetailJobUIController.m_luaExportHelper.m_jobMasterRewardGroupGo = jobMasterRewardGroupGo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE32 RID: 126514 RVA: 0x00A07600 File Offset: 0x00A05800
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_jobMasterRewardGroupGoReturnButton(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailJobUIController.m_luaExportHelper.m_jobMasterRewardGroupGoReturnButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE33 RID: 126515 RVA: 0x00A07658 File Offset: 0x00A05858
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_jobMasterRewardGroupGoReturnButton(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			Button jobMasterRewardGroupGoReturnButton;
			LuaObject.checkType<Button>(l, 2, out jobMasterRewardGroupGoReturnButton);
			heroDetailJobUIController.m_luaExportHelper.m_jobMasterRewardGroupGoReturnButton = jobMasterRewardGroupGoReturnButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE34 RID: 126516 RVA: 0x00A076B4 File Offset: 0x00A058B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_jobUpgradeGroupGo(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailJobUIController.m_luaExportHelper.m_jobUpgradeGroupGo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE35 RID: 126517 RVA: 0x00A0770C File Offset: 0x00A0590C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_jobUpgradeGroupGo(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			GameObject jobUpgradeGroupGo;
			LuaObject.checkType<GameObject>(l, 2, out jobUpgradeGroupGo);
			heroDetailJobUIController.m_luaExportHelper.m_jobUpgradeGroupGo = jobUpgradeGroupGo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE36 RID: 126518 RVA: 0x00A07768 File Offset: 0x00A05968
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_jobUpgradeGroupGoContinueBGButton(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailJobUIController.m_luaExportHelper.m_jobUpgradeGroupGoContinueBGButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE37 RID: 126519 RVA: 0x00A077C0 File Offset: 0x00A059C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_jobUpgradeGroupGoContinueBGButton(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			Button jobUpgradeGroupGoContinueBGButton;
			LuaObject.checkType<Button>(l, 2, out jobUpgradeGroupGoContinueBGButton);
			heroDetailJobUIController.m_luaExportHelper.m_jobUpgradeGroupGoContinueBGButton = jobUpgradeGroupGoContinueBGButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE38 RID: 126520 RVA: 0x00A0781C File Offset: 0x00A05A1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_jobUpgradeSuccessInfoPanelHpText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailJobUIController.m_luaExportHelper.m_jobUpgradeSuccessInfoPanelHpText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE39 RID: 126521 RVA: 0x00A07874 File Offset: 0x00A05A74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_jobUpgradeSuccessInfoPanelHpText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			Text jobUpgradeSuccessInfoPanelHpText;
			LuaObject.checkType<Text>(l, 2, out jobUpgradeSuccessInfoPanelHpText);
			heroDetailJobUIController.m_luaExportHelper.m_jobUpgradeSuccessInfoPanelHpText = jobUpgradeSuccessInfoPanelHpText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE3A RID: 126522 RVA: 0x00A078D0 File Offset: 0x00A05AD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_jobUpgradeSuccessInfoPanelHpAddText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailJobUIController.m_luaExportHelper.m_jobUpgradeSuccessInfoPanelHpAddText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE3B RID: 126523 RVA: 0x00A07928 File Offset: 0x00A05B28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_jobUpgradeSuccessInfoPanelHpAddText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			Text jobUpgradeSuccessInfoPanelHpAddText;
			LuaObject.checkType<Text>(l, 2, out jobUpgradeSuccessInfoPanelHpAddText);
			heroDetailJobUIController.m_luaExportHelper.m_jobUpgradeSuccessInfoPanelHpAddText = jobUpgradeSuccessInfoPanelHpAddText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE3C RID: 126524 RVA: 0x00A07984 File Offset: 0x00A05B84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_jobUpgradeSuccessInfoPanelATText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailJobUIController.m_luaExportHelper.m_jobUpgradeSuccessInfoPanelATText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE3D RID: 126525 RVA: 0x00A079DC File Offset: 0x00A05BDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_jobUpgradeSuccessInfoPanelATText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			Text jobUpgradeSuccessInfoPanelATText;
			LuaObject.checkType<Text>(l, 2, out jobUpgradeSuccessInfoPanelATText);
			heroDetailJobUIController.m_luaExportHelper.m_jobUpgradeSuccessInfoPanelATText = jobUpgradeSuccessInfoPanelATText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE3E RID: 126526 RVA: 0x00A07A38 File Offset: 0x00A05C38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_jobUpgradeSuccessInfoPanelATAddText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailJobUIController.m_luaExportHelper.m_jobUpgradeSuccessInfoPanelATAddText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE3F RID: 126527 RVA: 0x00A07A90 File Offset: 0x00A05C90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_jobUpgradeSuccessInfoPanelATAddText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			Text jobUpgradeSuccessInfoPanelATAddText;
			LuaObject.checkType<Text>(l, 2, out jobUpgradeSuccessInfoPanelATAddText);
			heroDetailJobUIController.m_luaExportHelper.m_jobUpgradeSuccessInfoPanelATAddText = jobUpgradeSuccessInfoPanelATAddText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE40 RID: 126528 RVA: 0x00A07AEC File Offset: 0x00A05CEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_jobUpgradeSuccessInfoPanelMagicText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailJobUIController.m_luaExportHelper.m_jobUpgradeSuccessInfoPanelMagicText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE41 RID: 126529 RVA: 0x00A07B44 File Offset: 0x00A05D44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_jobUpgradeSuccessInfoPanelMagicText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			Text jobUpgradeSuccessInfoPanelMagicText;
			LuaObject.checkType<Text>(l, 2, out jobUpgradeSuccessInfoPanelMagicText);
			heroDetailJobUIController.m_luaExportHelper.m_jobUpgradeSuccessInfoPanelMagicText = jobUpgradeSuccessInfoPanelMagicText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE42 RID: 126530 RVA: 0x00A07BA0 File Offset: 0x00A05DA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_jobUpgradeSuccessInfoPanelMagicAddText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailJobUIController.m_luaExportHelper.m_jobUpgradeSuccessInfoPanelMagicAddText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE43 RID: 126531 RVA: 0x00A07BF8 File Offset: 0x00A05DF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_jobUpgradeSuccessInfoPanelMagicAddText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			Text jobUpgradeSuccessInfoPanelMagicAddText;
			LuaObject.checkType<Text>(l, 2, out jobUpgradeSuccessInfoPanelMagicAddText);
			heroDetailJobUIController.m_luaExportHelper.m_jobUpgradeSuccessInfoPanelMagicAddText = jobUpgradeSuccessInfoPanelMagicAddText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE44 RID: 126532 RVA: 0x00A07C54 File Offset: 0x00A05E54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_jobUpgradeSuccessInfoPanelDFText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailJobUIController.m_luaExportHelper.m_jobUpgradeSuccessInfoPanelDFText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE45 RID: 126533 RVA: 0x00A07CAC File Offset: 0x00A05EAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_jobUpgradeSuccessInfoPanelDFText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			Text jobUpgradeSuccessInfoPanelDFText;
			LuaObject.checkType<Text>(l, 2, out jobUpgradeSuccessInfoPanelDFText);
			heroDetailJobUIController.m_luaExportHelper.m_jobUpgradeSuccessInfoPanelDFText = jobUpgradeSuccessInfoPanelDFText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE46 RID: 126534 RVA: 0x00A07D08 File Offset: 0x00A05F08
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_jobUpgradeSuccessInfoPanelDFAddText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailJobUIController.m_luaExportHelper.m_jobUpgradeSuccessInfoPanelDFAddText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE47 RID: 126535 RVA: 0x00A07D60 File Offset: 0x00A05F60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_jobUpgradeSuccessInfoPanelDFAddText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			Text jobUpgradeSuccessInfoPanelDFAddText;
			LuaObject.checkType<Text>(l, 2, out jobUpgradeSuccessInfoPanelDFAddText);
			heroDetailJobUIController.m_luaExportHelper.m_jobUpgradeSuccessInfoPanelDFAddText = jobUpgradeSuccessInfoPanelDFAddText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE48 RID: 126536 RVA: 0x00A07DBC File Offset: 0x00A05FBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_jobUpgradeSuccessInfoPanelMagicDFText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailJobUIController.m_luaExportHelper.m_jobUpgradeSuccessInfoPanelMagicDFText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE49 RID: 126537 RVA: 0x00A07E14 File Offset: 0x00A06014
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_jobUpgradeSuccessInfoPanelMagicDFText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			Text jobUpgradeSuccessInfoPanelMagicDFText;
			LuaObject.checkType<Text>(l, 2, out jobUpgradeSuccessInfoPanelMagicDFText);
			heroDetailJobUIController.m_luaExportHelper.m_jobUpgradeSuccessInfoPanelMagicDFText = jobUpgradeSuccessInfoPanelMagicDFText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE4A RID: 126538 RVA: 0x00A07E70 File Offset: 0x00A06070
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_jobUpgradeSuccessInfoPanelMagicDFAddText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailJobUIController.m_luaExportHelper.m_jobUpgradeSuccessInfoPanelMagicDFAddText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE4B RID: 126539 RVA: 0x00A07EC8 File Offset: 0x00A060C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_jobUpgradeSuccessInfoPanelMagicDFAddText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			Text jobUpgradeSuccessInfoPanelMagicDFAddText;
			LuaObject.checkType<Text>(l, 2, out jobUpgradeSuccessInfoPanelMagicDFAddText);
			heroDetailJobUIController.m_luaExportHelper.m_jobUpgradeSuccessInfoPanelMagicDFAddText = jobUpgradeSuccessInfoPanelMagicDFAddText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE4C RID: 126540 RVA: 0x00A07F24 File Offset: 0x00A06124
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_jobUpgradeSuccessInfoPanelDexText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailJobUIController.m_luaExportHelper.m_jobUpgradeSuccessInfoPanelDexText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE4D RID: 126541 RVA: 0x00A07F7C File Offset: 0x00A0617C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_jobUpgradeSuccessInfoPanelDexText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			Text jobUpgradeSuccessInfoPanelDexText;
			LuaObject.checkType<Text>(l, 2, out jobUpgradeSuccessInfoPanelDexText);
			heroDetailJobUIController.m_luaExportHelper.m_jobUpgradeSuccessInfoPanelDexText = jobUpgradeSuccessInfoPanelDexText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE4E RID: 126542 RVA: 0x00A07FD8 File Offset: 0x00A061D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_jobUpgradeSuccessInfoPanelDexAddText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailJobUIController.m_luaExportHelper.m_jobUpgradeSuccessInfoPanelDexAddText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE4F RID: 126543 RVA: 0x00A08030 File Offset: 0x00A06230
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_jobUpgradeSuccessInfoPanelDexAddText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			Text jobUpgradeSuccessInfoPanelDexAddText;
			LuaObject.checkType<Text>(l, 2, out jobUpgradeSuccessInfoPanelDexAddText);
			heroDetailJobUIController.m_luaExportHelper.m_jobUpgradeSuccessInfoPanelDexAddText = jobUpgradeSuccessInfoPanelDexAddText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE50 RID: 126544 RVA: 0x00A0808C File Offset: 0x00A0628C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_learnedPanel(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailJobUIController.m_luaExportHelper.m_learnedPanel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE51 RID: 126545 RVA: 0x00A080E4 File Offset: 0x00A062E4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_learnedPanel(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			GameObject learnedPanel;
			LuaObject.checkType<GameObject>(l, 2, out learnedPanel);
			heroDetailJobUIController.m_luaExportHelper.m_learnedPanel = learnedPanel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE52 RID: 126546 RVA: 0x00A08140 File Offset: 0x00A06340
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_learnedPanelCloseBtn(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailJobUIController.m_luaExportHelper.m_learnedPanelCloseBtn);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE53 RID: 126547 RVA: 0x00A08198 File Offset: 0x00A06398
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_learnedPanelCloseBtn(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			Button learnedPanelCloseBtn;
			LuaObject.checkType<Button>(l, 2, out learnedPanelCloseBtn);
			heroDetailJobUIController.m_luaExportHelper.m_learnedPanelCloseBtn = learnedPanelCloseBtn;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE54 RID: 126548 RVA: 0x00A081F4 File Offset: 0x00A063F4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_learnedPanelSkillCloseBtn(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailJobUIController.m_luaExportHelper.m_learnedPanelSkillCloseBtn);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE55 RID: 126549 RVA: 0x00A0824C File Offset: 0x00A0644C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_learnedPanelSkillCloseBtn(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			Button learnedPanelSkillCloseBtn;
			LuaObject.checkType<Button>(l, 2, out learnedPanelSkillCloseBtn);
			heroDetailJobUIController.m_luaExportHelper.m_learnedPanelSkillCloseBtn = learnedPanelSkillCloseBtn;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE56 RID: 126550 RVA: 0x00A082A8 File Offset: 0x00A064A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_learnedPanelSkillPanel(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailJobUIController.m_luaExportHelper.m_learnedPanelSkillPanel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE57 RID: 126551 RVA: 0x00A08300 File Offset: 0x00A06500
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_learnedPanelSkillPanel(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			GameObject learnedPanelSkillPanel;
			LuaObject.checkType<GameObject>(l, 2, out learnedPanelSkillPanel);
			heroDetailJobUIController.m_luaExportHelper.m_learnedPanelSkillPanel = learnedPanelSkillPanel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE58 RID: 126552 RVA: 0x00A0835C File Offset: 0x00A0655C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_learnedPanelSoldierPanel(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailJobUIController.m_luaExportHelper.m_learnedPanelSoldierPanel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE59 RID: 126553 RVA: 0x00A083B4 File Offset: 0x00A065B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_learnedPanelSoldierPanel(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			GameObject learnedPanelSoldierPanel;
			LuaObject.checkType<GameObject>(l, 2, out learnedPanelSoldierPanel);
			heroDetailJobUIController.m_luaExportHelper.m_learnedPanelSoldierPanel = learnedPanelSoldierPanel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE5A RID: 126554 RVA: 0x00A08410 File Offset: 0x00A06610
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_learnedPanelSkillIcon(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailJobUIController.m_luaExportHelper.m_learnedPanelSkillIcon);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE5B RID: 126555 RVA: 0x00A08468 File Offset: 0x00A06668
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_learnedPanelSkillIcon(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			Image learnedPanelSkillIcon;
			LuaObject.checkType<Image>(l, 2, out learnedPanelSkillIcon);
			heroDetailJobUIController.m_luaExportHelper.m_learnedPanelSkillIcon = learnedPanelSkillIcon;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE5C RID: 126556 RVA: 0x00A084C4 File Offset: 0x00A066C4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_learnedPanelSoldierGraphicObj(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailJobUIController.m_luaExportHelper.m_learnedPanelSoldierGraphicObj);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE5D RID: 126557 RVA: 0x00A0851C File Offset: 0x00A0671C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_learnedPanelSoldierGraphicObj(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			GameObject learnedPanelSoldierGraphicObj;
			LuaObject.checkType<GameObject>(l, 2, out learnedPanelSoldierGraphicObj);
			heroDetailJobUIController.m_luaExportHelper.m_learnedPanelSoldierGraphicObj = learnedPanelSoldierGraphicObj;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE5E RID: 126558 RVA: 0x00A08578 File Offset: 0x00A06778
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_learnedPanelSkillName(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailJobUIController.m_luaExportHelper.m_learnedPanelSkillName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE5F RID: 126559 RVA: 0x00A085D0 File Offset: 0x00A067D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_learnedPanelSkillName(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			Text learnedPanelSkillName;
			LuaObject.checkType<Text>(l, 2, out learnedPanelSkillName);
			heroDetailJobUIController.m_luaExportHelper.m_learnedPanelSkillName = learnedPanelSkillName;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE60 RID: 126560 RVA: 0x00A0862C File Offset: 0x00A0682C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_learnedPanelSoldierName(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailJobUIController.m_luaExportHelper.m_learnedPanelSoldierName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE61 RID: 126561 RVA: 0x00A08684 File Offset: 0x00A06884
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_learnedPanelSoldierName(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			Text learnedPanelSoldierName;
			LuaObject.checkType<Text>(l, 2, out learnedPanelSoldierName);
			heroDetailJobUIController.m_luaExportHelper.m_learnedPanelSoldierName = learnedPanelSoldierName;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE62 RID: 126562 RVA: 0x00A086E0 File Offset: 0x00A068E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnJobLvUpgrade(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			Action<int, int, Action> value;
			int num = LuaObject.checkDelegate<Action<int, int, Action>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					heroDetailJobUIController.EventOnJobLvUpgrade += value;
				}
				else if (num == 2)
				{
					heroDetailJobUIController.EventOnJobLvUpgrade -= value;
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

	// Token: 0x0601EE63 RID: 126563 RVA: 0x00A08760 File Offset: 0x00A06960
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnShowGetPath(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			Action<GoodsType, int, int> value;
			int num = LuaObject.checkDelegate<Action<GoodsType, int, int>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					heroDetailJobUIController.EventOnShowGetPath += value;
				}
				else if (num == 2)
				{
					heroDetailJobUIController.EventOnShowGetPath -= value;
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

	// Token: 0x0601EE64 RID: 126564 RVA: 0x00A087E0 File Offset: 0x00A069E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnUpdateView(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					heroDetailJobUIController.EventOnUpdateView += value;
				}
				else if (num == 2)
				{
					heroDetailJobUIController.EventOnUpdateView -= value;
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

	// Token: 0x0601EE65 RID: 126565 RVA: 0x00A08860 File Offset: 0x00A06A60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_hero(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailJobUIController.m_luaExportHelper.m_hero);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE66 RID: 126566 RVA: 0x00A088B8 File Offset: 0x00A06AB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_hero(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			Hero hero;
			LuaObject.checkType<Hero>(l, 2, out hero);
			heroDetailJobUIController.m_luaExportHelper.m_hero = hero;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE67 RID: 126567 RVA: 0x00A08914 File Offset: 0x00A06B14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_jobMaterialObjList(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailJobUIController.m_luaExportHelper.m_jobMaterialObjList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE68 RID: 126568 RVA: 0x00A0896C File Offset: 0x00A06B6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_jobMaterialObjList(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			List<GameObject> jobMaterialObjList;
			LuaObject.checkType<List<GameObject>>(l, 2, out jobMaterialObjList);
			heroDetailJobUIController.m_luaExportHelper.m_jobMaterialObjList = jobMaterialObjList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE69 RID: 126569 RVA: 0x00A089C8 File Offset: 0x00A06BC8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_learndSoldierGraphic(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailJobUIController.m_luaExportHelper.m_learndSoldierGraphic);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE6A RID: 126570 RVA: 0x00A08A20 File Offset: 0x00A06C20
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_learndSoldierGraphic(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			UISpineGraphic learndSoldierGraphic;
			LuaObject.checkType<UISpineGraphic>(l, 2, out learndSoldierGraphic);
			heroDetailJobUIController.m_luaExportHelper.m_learndSoldierGraphic = learndSoldierGraphic;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE6B RID: 126571 RVA: 0x00A08A7C File Offset: 0x00A06C7C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_learnSkillInfo(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailJobUIController.m_luaExportHelper.m_learnSkillInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE6C RID: 126572 RVA: 0x00A08AD4 File Offset: 0x00A06CD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_learnSkillInfo(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			ConfigDataSkillInfo learnSkillInfo;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 2, out learnSkillInfo);
			heroDetailJobUIController.m_luaExportHelper.m_learnSkillInfo = learnSkillInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE6D RID: 126573 RVA: 0x00A08B30 File Offset: 0x00A06D30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_learnSoliderInfo(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailJobUIController.m_luaExportHelper.m_learnSoliderInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE6E RID: 126574 RVA: 0x00A08B88 File Offset: 0x00A06D88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_learnSoliderInfo(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			ConfigDataSoldierInfo learnSoliderInfo;
			LuaObject.checkType<ConfigDataSoldierInfo>(l, 2, out learnSoliderInfo);
			heroDetailJobUIController.m_luaExportHelper.m_learnSoliderInfo = learnSoliderInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE6F RID: 126575 RVA: 0x00A08BE4 File Offset: 0x00A06DE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_curjobNeedMaterials(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailJobUIController.m_luaExportHelper.m_curjobNeedMaterials);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE70 RID: 126576 RVA: 0x00A08C3C File Offset: 0x00A06E3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_curjobNeedMaterials(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			List<Goods> curjobNeedMaterials;
			LuaObject.checkType<List<Goods>>(l, 2, out curjobNeedMaterials);
			heroDetailJobUIController.m_luaExportHelper.m_curjobNeedMaterials = curjobNeedMaterials;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE71 RID: 126577 RVA: 0x00A08C98 File Offset: 0x00A06E98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isCloseJobUpgradePanel(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailJobUIController.m_luaExportHelper.m_isCloseJobUpgradePanel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE72 RID: 126578 RVA: 0x00A08CF0 File Offset: 0x00A06EF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isCloseJobUpgradePanel(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			bool isCloseJobUpgradePanel;
			LuaObject.checkType(l, 2, out isCloseJobUpgradePanel);
			heroDetailJobUIController.m_luaExportHelper.m_isCloseJobUpgradePanel = isCloseJobUpgradePanel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE73 RID: 126579 RVA: 0x00A08D4C File Offset: 0x00A06F4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isCloseJobMasterRewardPanel(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailJobUIController.m_luaExportHelper.m_isCloseJobMasterRewardPanel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE74 RID: 126580 RVA: 0x00A08DA4 File Offset: 0x00A06FA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isCloseJobMasterRewardPanel(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			bool isCloseJobMasterRewardPanel;
			LuaObject.checkType(l, 2, out isCloseJobMasterRewardPanel);
			heroDetailJobUIController.m_luaExportHelper.m_isCloseJobMasterRewardPanel = isCloseJobMasterRewardPanel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE75 RID: 126581 RVA: 0x00A08E00 File Offset: 0x00A07000
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailJobUIController.m_luaExportHelper.m_playerContext);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE76 RID: 126582 RVA: 0x00A08E58 File Offset: 0x00A07058
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			ProjectLPlayerContext playerContext;
			LuaObject.checkType<ProjectLPlayerContext>(l, 2, out playerContext);
			heroDetailJobUIController.m_luaExportHelper.m_playerContext = playerContext;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE77 RID: 126583 RVA: 0x00A08EB4 File Offset: 0x00A070B4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailJobUIController.m_luaExportHelper.m_configDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE78 RID: 126584 RVA: 0x00A08F0C File Offset: 0x00A0710C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailJobUIController heroDetailJobUIController = (HeroDetailJobUIController)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			heroDetailJobUIController.m_luaExportHelper.m_configDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EE79 RID: 126585 RVA: 0x00A08F68 File Offset: 0x00A07168
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.HeroDetailJobUIController");
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.UpdateViewInJobState);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.IsJobLvUpgradeFinished);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.SetCommonUIState);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.ShowJobDetailPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.ShowJobUpgradePanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.SetUpperLimitBreak);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.SetPropertyLearned);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.OnJobLearnedSkillClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.OnJobLearnedSoldierClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.OnJobLearnedMasterClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.SetJobLvMasterInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.SetMasterRewardProperty);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.ShowJobMaterialPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.OnJobMaterialClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.OnJobLvUpgradeButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.OnJobLvUpgradeSucceed);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.JobLVUpgradeEffect);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.SetJobUpgradeInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.ShowLearnedSkillAndSoldier);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.CloseLearnedSkillPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.OnJobUpgradeGroupGoContinueBGButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.OnJobMasterRewardGroupGoReturnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.CloseLearnedPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.StopAndCloseUIEffect);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache25);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.__callDele_EventOnJobLvUpgrade);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache26);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.__clearDele_EventOnJobLvUpgrade);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache27);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.__callDele_EventOnShowGetPath);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache28);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.__clearDele_EventOnShowGetPath);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache29);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.__callDele_EventOnUpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache2A);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.__clearDele_EventOnUpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache2B);
		string name = "m_marginTransform";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.get_m_marginTransform);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache2C;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.set_m_marginTransform);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache2D, true);
		string name2 = "m_infoPanelStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.get_m_infoPanelStateCtrl);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache2E;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.set_m_infoPanelStateCtrl);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache2F, true);
		string name3 = "m_jobNameText";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.get_m_jobNameText);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache30;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.set_m_jobNameText);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache31, true);
		string name4 = "m_jobDescText";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.get_m_jobDescText);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache32;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.set_m_jobDescText);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache33, true);
		string name5 = "m_jobArmyImage";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.get_m_jobArmyImage);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache34;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.set_m_jobArmyImage);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache35, true);
		string name6 = "m_curJobUpgradeGo";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.get_m_curJobUpgradeGo);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache36;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.set_m_curJobUpgradeGo);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache37, true);
		string name7 = "m_curJobLv";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.get_m_curJobLv);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache38;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.set_m_curJobLv);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache39, true);
		string name8 = "m_curJobLvBg";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.get_m_curJobLvBg);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache3A;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.set_m_curJobLvBg);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache3B, true);
		string name9 = "m_nextJobLvObj";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.get_m_nextJobLvObj);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache3C;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.set_m_nextJobLvObj);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache3D, true);
		string name10 = "m_nextJobLv";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.get_m_nextJobLv);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache3E;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.set_m_nextJobLv);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache3F, true);
		string name11 = "m_nextJobLvBg";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.get_m_nextJobLvBg);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache40;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.set_m_nextJobLvBg);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache41, true);
		string name12 = "m_jobMasterImg";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.get_m_jobMasterImg);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache42;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.set_m_jobMasterImg);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache43, true);
		string name13 = "m_jobLvArrowObj";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.get_m_jobLvArrowObj);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache44;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.set_m_jobLvArrowObj);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache45, true);
		string name14 = "m_jobUpGameObject";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache46 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache46 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.get_m_jobUpGameObject);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache46;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache47 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache47 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.set_m_jobUpGameObject);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache47, true);
		string name15 = "m_jobLearnedSkill";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache48 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache48 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.get_m_jobLearnedSkill);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache48;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache49 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache49 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.set_m_jobLearnedSkill);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache49, true);
		string name16 = "m_jobLearnedSkillIconImage";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache4A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache4A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.get_m_jobLearnedSkillIconImage);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache4A;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache4B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache4B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.set_m_jobLearnedSkillIconImage);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache4B, true);
		string name17 = "m_jobLearnedSkillNameText";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache4C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache4C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.get_m_jobLearnedSkillNameText);
		}
		LuaCSFunction get17 = Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache4C;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache4D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache4D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.set_m_jobLearnedSkillNameText);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache4D, true);
		string name18 = "m_jobLearnedSoldier";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache4E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache4E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.get_m_jobLearnedSoldier);
		}
		LuaCSFunction get18 = Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache4E;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache4F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache4F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.set_m_jobLearnedSoldier);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache4F, true);
		string name19 = "m_jobLearnedSoldierIconImage";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache50 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache50 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.get_m_jobLearnedSoldierIconImage);
		}
		LuaCSFunction get19 = Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache50;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache51 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache51 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.set_m_jobLearnedSoldierIconImage);
		}
		LuaObject.addMember(l, name19, get19, Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache51, true);
		string name20 = "m_jobLearnedSoldierNameText";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache52 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache52 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.get_m_jobLearnedSoldierNameText);
		}
		LuaCSFunction get20 = Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache52;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache53 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache53 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.set_m_jobLearnedSoldierNameText);
		}
		LuaObject.addMember(l, name20, get20, Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache53, true);
		string name21 = "m_jobLearnedMaster";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache54 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache54 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.get_m_jobLearnedMaster);
		}
		LuaCSFunction get21 = Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache54;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache55 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache55 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.set_m_jobLearnedMaster);
		}
		LuaObject.addMember(l, name21, get21, Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache55, true);
		string name22 = "m_jobDescContent";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache56 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache56 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.get_m_jobDescContent);
		}
		LuaCSFunction get22 = Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache56;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache57 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache57 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.set_m_jobDescContent);
		}
		LuaObject.addMember(l, name22, get22, Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache57, true);
		string name23 = "m_masterRewardPanel";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache58 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache58 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.get_m_masterRewardPanel);
		}
		LuaCSFunction get23 = Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache58;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache59 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache59 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.set_m_masterRewardPanel);
		}
		LuaObject.addMember(l, name23, get23, Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache59, true);
		string name24 = "m_propAddObj";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache5A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache5A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.get_m_propAddObj);
		}
		LuaCSFunction get24 = Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache5A;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache5B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache5B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.set_m_propAddObj);
		}
		LuaObject.addMember(l, name24, get24, Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache5B, true);
		string name25 = "m_masterRewardPanelJobIcon";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache5C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache5C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.get_m_masterRewardPanelJobIcon);
		}
		LuaCSFunction get25 = Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache5C;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache5D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache5D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.set_m_masterRewardPanelJobIcon);
		}
		LuaObject.addMember(l, name25, get25, Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache5D, true);
		string name26 = "m_masterRewardPanelNameText";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache5E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache5E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.get_m_masterRewardPanelNameText);
		}
		LuaCSFunction get26 = Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache5E;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache5F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache5F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.set_m_masterRewardPanelNameText);
		}
		LuaObject.addMember(l, name26, get26, Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache5F, true);
		string name27 = "m_propHPAddValueText";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache60 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache60 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.get_m_propHPAddValueText);
		}
		LuaCSFunction get27 = Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache60;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache61 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache61 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.set_m_propHPAddValueText);
		}
		LuaObject.addMember(l, name27, get27, Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache61, true);
		string name28 = "m_propATAddValueText";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache62 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache62 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.get_m_propATAddValueText);
		}
		LuaCSFunction get28 = Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache62;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache63 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache63 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.set_m_propATAddValueText);
		}
		LuaObject.addMember(l, name28, get28, Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache63, true);
		string name29 = "m_propDFAddValueText";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache64 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache64 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.get_m_propDFAddValueText);
		}
		LuaCSFunction get29 = Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache64;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache65 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache65 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.set_m_propDFAddValueText);
		}
		LuaObject.addMember(l, name29, get29, Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache65, true);
		string name30 = "m_propMagicAddValueText";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache66 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache66 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.get_m_propMagicAddValueText);
		}
		LuaCSFunction get30 = Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache66;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache67 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache67 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.set_m_propMagicAddValueText);
		}
		LuaObject.addMember(l, name30, get30, Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache67, true);
		string name31 = "m_propMagicDFAddValueText";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache68 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache68 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.get_m_propMagicDFAddValueText);
		}
		LuaCSFunction get31 = Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache68;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache69 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache69 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.set_m_propMagicDFAddValueText);
		}
		LuaObject.addMember(l, name31, get31, Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache69, true);
		string name32 = "m_propDEXAddValueText";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache6A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache6A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.get_m_propDEXAddValueText);
		}
		LuaCSFunction get32 = Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache6A;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache6B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache6B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.set_m_propDEXAddValueText);
		}
		LuaObject.addMember(l, name32, get32, Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache6B, true);
		string name33 = "m_propHPAddObj";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache6C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache6C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.get_m_propHPAddObj);
		}
		LuaCSFunction get33 = Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache6C;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache6D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache6D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.set_m_propHPAddObj);
		}
		LuaObject.addMember(l, name33, get33, Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache6D, true);
		string name34 = "m_propATAddObj";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache6E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache6E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.get_m_propATAddObj);
		}
		LuaCSFunction get34 = Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache6E;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache6F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache6F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.set_m_propATAddObj);
		}
		LuaObject.addMember(l, name34, get34, Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache6F, true);
		string name35 = "m_propDFAddObj";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache70 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache70 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.get_m_propDFAddObj);
		}
		LuaCSFunction get35 = Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache70;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache71 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache71 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.set_m_propDFAddObj);
		}
		LuaObject.addMember(l, name35, get35, Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache71, true);
		string name36 = "m_propMagicAddObj";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache72 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache72 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.get_m_propMagicAddObj);
		}
		LuaCSFunction get36 = Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache72;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache73 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache73 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.set_m_propMagicAddObj);
		}
		LuaObject.addMember(l, name36, get36, Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache73, true);
		string name37 = "m_propMagicDFAddObj";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache74 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache74 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.get_m_propMagicDFAddObj);
		}
		LuaCSFunction get37 = Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache74;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache75 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache75 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.set_m_propMagicDFAddObj);
		}
		LuaObject.addMember(l, name37, get37, Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache75, true);
		string name38 = "m_propDEXAddObj";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache76 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache76 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.get_m_propDEXAddObj);
		}
		LuaCSFunction get38 = Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache76;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache77 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache77 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.set_m_propDEXAddObj);
		}
		LuaObject.addMember(l, name38, get38, Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache77, true);
		string name39 = "m_jobMaterialObj";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache78 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache78 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.get_m_jobMaterialObj);
		}
		LuaCSFunction get39 = Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache78;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache79 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache79 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.set_m_jobMaterialObj);
		}
		LuaObject.addMember(l, name39, get39, Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache79, true);
		string name40 = "m_jobMaterialObj1";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache7A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache7A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.get_m_jobMaterialObj1);
		}
		LuaCSFunction get40 = Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache7A;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache7B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache7B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.set_m_jobMaterialObj1);
		}
		LuaObject.addMember(l, name40, get40, Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache7B, true);
		string name41 = "m_jobMaterialObj2";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache7C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache7C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.get_m_jobMaterialObj2);
		}
		LuaCSFunction get41 = Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache7C;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache7D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache7D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.set_m_jobMaterialObj2);
		}
		LuaObject.addMember(l, name41, get41, Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache7D, true);
		string name42 = "m_jobMaterialObj3";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache7E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache7E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.get_m_jobMaterialObj3);
		}
		LuaCSFunction get42 = Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache7E;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache7F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache7F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.set_m_jobMaterialObj3);
		}
		LuaObject.addMember(l, name42, get42, Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache7F, true);
		string name43 = "m_jobLvUpgradeButton";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache80 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache80 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.get_m_jobLvUpgradeButton);
		}
		LuaCSFunction get43 = Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache80;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache81 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache81 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.set_m_jobLvUpgradeButton);
		}
		LuaObject.addMember(l, name43, get43, Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache81, true);
		string name44 = "m_jobMaterialLvLimitCtrl";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache82 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache82 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.get_m_jobMaterialLvLimitCtrl);
		}
		LuaCSFunction get44 = Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache82;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache83 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache83 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.set_m_jobMaterialLvLimitCtrl);
		}
		LuaObject.addMember(l, name44, get44, Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache83, true);
		string name45 = "m_jobMaterialLvLimitText";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache84 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache84 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.get_m_jobMaterialLvLimitText);
		}
		LuaCSFunction get45 = Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache84;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache85 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache85 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.set_m_jobMaterialLvLimitText);
		}
		LuaObject.addMember(l, name45, get45, Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache85, true);
		string name46 = "m_jobLvUpgradeBtnArtEffect";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache86 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache86 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.get_m_jobLvUpgradeBtnArtEffect);
		}
		LuaCSFunction get46 = Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache86;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache87 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache87 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.set_m_jobLvUpgradeBtnArtEffect);
		}
		LuaObject.addMember(l, name46, get46, Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache87, true);
		string name47 = "m_jobLvUpgradeFrameEffect";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache88 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache88 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.get_m_jobLvUpgradeFrameEffect);
		}
		LuaCSFunction get47 = Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache88;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache89 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache89 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.set_m_jobLvUpgradeFrameEffect);
		}
		LuaObject.addMember(l, name47, get47, Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache89, true);
		string name48 = "m_jobLvUpgradeFlyEffect";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache8A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache8A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.get_m_jobLvUpgradeFlyEffect);
		}
		LuaCSFunction get48 = Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache8A;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache8B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache8B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.set_m_jobLvUpgradeFlyEffect);
		}
		LuaObject.addMember(l, name48, get48, Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache8B, true);
		string name49 = "m_jobLvUpgradeFlyEffectIcon1";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache8C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache8C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.get_m_jobLvUpgradeFlyEffectIcon1);
		}
		LuaCSFunction get49 = Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache8C;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache8D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache8D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.set_m_jobLvUpgradeFlyEffectIcon1);
		}
		LuaObject.addMember(l, name49, get49, Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache8D, true);
		string name50 = "m_jobLvUpgradeFlyEffectIcon2";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache8E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache8E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.get_m_jobLvUpgradeFlyEffectIcon2);
		}
		LuaCSFunction get50 = Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache8E;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache8F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache8F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.set_m_jobLvUpgradeFlyEffectIcon2);
		}
		LuaObject.addMember(l, name50, get50, Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache8F, true);
		string name51 = "m_jobLvUpgradeFlyEffectIcon3";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache90 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache90 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.get_m_jobLvUpgradeFlyEffectIcon3);
		}
		LuaCSFunction get51 = Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache90;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache91 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache91 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.set_m_jobLvUpgradeFlyEffectIcon3);
		}
		LuaObject.addMember(l, name51, get51, Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache91, true);
		string name52 = "m_jobLvUpgradeFlyEffectIcon4";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache92 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache92 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.get_m_jobLvUpgradeFlyEffectIcon4);
		}
		LuaCSFunction get52 = Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache92;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache93 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache93 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.set_m_jobLvUpgradeFlyEffectIcon4);
		}
		LuaObject.addMember(l, name52, get52, Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache93, true);
		string name53 = "m_jobLvUpgradeStarUpEffect";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache94 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache94 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.get_m_jobLvUpgradeStarUpEffect);
		}
		LuaCSFunction get53 = Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache94;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache95 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache95 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.set_m_jobLvUpgradeStarUpEffect);
		}
		LuaObject.addMember(l, name53, get53, Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache95, true);
		string name54 = "m_jobMasterRewardGroupGo";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache96 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache96 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.get_m_jobMasterRewardGroupGo);
		}
		LuaCSFunction get54 = Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache96;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache97 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache97 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.set_m_jobMasterRewardGroupGo);
		}
		LuaObject.addMember(l, name54, get54, Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache97, true);
		string name55 = "m_jobMasterRewardGroupGoReturnButton";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache98 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache98 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.get_m_jobMasterRewardGroupGoReturnButton);
		}
		LuaCSFunction get55 = Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache98;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache99 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache99 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.set_m_jobMasterRewardGroupGoReturnButton);
		}
		LuaObject.addMember(l, name55, get55, Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache99, true);
		string name56 = "m_jobUpgradeGroupGo";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache9A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache9A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.get_m_jobUpgradeGroupGo);
		}
		LuaCSFunction get56 = Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache9A;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache9B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache9B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.set_m_jobUpgradeGroupGo);
		}
		LuaObject.addMember(l, name56, get56, Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache9B, true);
		string name57 = "m_jobUpgradeGroupGoContinueBGButton";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache9C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache9C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.get_m_jobUpgradeGroupGoContinueBGButton);
		}
		LuaCSFunction get57 = Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache9C;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache9D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache9D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.set_m_jobUpgradeGroupGoContinueBGButton);
		}
		LuaObject.addMember(l, name57, get57, Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache9D, true);
		string name58 = "m_jobUpgradeSuccessInfoPanelHpText";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache9E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache9E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.get_m_jobUpgradeSuccessInfoPanelHpText);
		}
		LuaCSFunction get58 = Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache9E;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache9F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache9F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.set_m_jobUpgradeSuccessInfoPanelHpText);
		}
		LuaObject.addMember(l, name58, get58, Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cache9F, true);
		string name59 = "m_jobUpgradeSuccessInfoPanelHpAddText";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheA0 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheA0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.get_m_jobUpgradeSuccessInfoPanelHpAddText);
		}
		LuaCSFunction get59 = Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheA0;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheA1 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheA1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.set_m_jobUpgradeSuccessInfoPanelHpAddText);
		}
		LuaObject.addMember(l, name59, get59, Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheA1, true);
		string name60 = "m_jobUpgradeSuccessInfoPanelATText";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheA2 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheA2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.get_m_jobUpgradeSuccessInfoPanelATText);
		}
		LuaCSFunction get60 = Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheA2;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheA3 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheA3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.set_m_jobUpgradeSuccessInfoPanelATText);
		}
		LuaObject.addMember(l, name60, get60, Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheA3, true);
		string name61 = "m_jobUpgradeSuccessInfoPanelATAddText";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheA4 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheA4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.get_m_jobUpgradeSuccessInfoPanelATAddText);
		}
		LuaCSFunction get61 = Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheA4;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheA5 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheA5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.set_m_jobUpgradeSuccessInfoPanelATAddText);
		}
		LuaObject.addMember(l, name61, get61, Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheA5, true);
		string name62 = "m_jobUpgradeSuccessInfoPanelMagicText";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheA6 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheA6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.get_m_jobUpgradeSuccessInfoPanelMagicText);
		}
		LuaCSFunction get62 = Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheA6;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheA7 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheA7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.set_m_jobUpgradeSuccessInfoPanelMagicText);
		}
		LuaObject.addMember(l, name62, get62, Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheA7, true);
		string name63 = "m_jobUpgradeSuccessInfoPanelMagicAddText";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheA8 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheA8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.get_m_jobUpgradeSuccessInfoPanelMagicAddText);
		}
		LuaCSFunction get63 = Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheA8;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheA9 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheA9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.set_m_jobUpgradeSuccessInfoPanelMagicAddText);
		}
		LuaObject.addMember(l, name63, get63, Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheA9, true);
		string name64 = "m_jobUpgradeSuccessInfoPanelDFText";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheAA == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheAA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.get_m_jobUpgradeSuccessInfoPanelDFText);
		}
		LuaCSFunction get64 = Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheAA;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheAB == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheAB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.set_m_jobUpgradeSuccessInfoPanelDFText);
		}
		LuaObject.addMember(l, name64, get64, Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheAB, true);
		string name65 = "m_jobUpgradeSuccessInfoPanelDFAddText";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheAC == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheAC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.get_m_jobUpgradeSuccessInfoPanelDFAddText);
		}
		LuaCSFunction get65 = Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheAC;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheAD == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheAD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.set_m_jobUpgradeSuccessInfoPanelDFAddText);
		}
		LuaObject.addMember(l, name65, get65, Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheAD, true);
		string name66 = "m_jobUpgradeSuccessInfoPanelMagicDFText";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheAE == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheAE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.get_m_jobUpgradeSuccessInfoPanelMagicDFText);
		}
		LuaCSFunction get66 = Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheAE;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheAF == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheAF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.set_m_jobUpgradeSuccessInfoPanelMagicDFText);
		}
		LuaObject.addMember(l, name66, get66, Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheAF, true);
		string name67 = "m_jobUpgradeSuccessInfoPanelMagicDFAddText";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheB0 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheB0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.get_m_jobUpgradeSuccessInfoPanelMagicDFAddText);
		}
		LuaCSFunction get67 = Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheB0;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheB1 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheB1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.set_m_jobUpgradeSuccessInfoPanelMagicDFAddText);
		}
		LuaObject.addMember(l, name67, get67, Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheB1, true);
		string name68 = "m_jobUpgradeSuccessInfoPanelDexText";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheB2 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheB2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.get_m_jobUpgradeSuccessInfoPanelDexText);
		}
		LuaCSFunction get68 = Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheB2;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheB3 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheB3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.set_m_jobUpgradeSuccessInfoPanelDexText);
		}
		LuaObject.addMember(l, name68, get68, Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheB3, true);
		string name69 = "m_jobUpgradeSuccessInfoPanelDexAddText";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheB4 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheB4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.get_m_jobUpgradeSuccessInfoPanelDexAddText);
		}
		LuaCSFunction get69 = Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheB4;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheB5 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheB5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.set_m_jobUpgradeSuccessInfoPanelDexAddText);
		}
		LuaObject.addMember(l, name69, get69, Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheB5, true);
		string name70 = "m_learnedPanel";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheB6 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheB6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.get_m_learnedPanel);
		}
		LuaCSFunction get70 = Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheB6;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheB7 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheB7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.set_m_learnedPanel);
		}
		LuaObject.addMember(l, name70, get70, Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheB7, true);
		string name71 = "m_learnedPanelCloseBtn";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheB8 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheB8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.get_m_learnedPanelCloseBtn);
		}
		LuaCSFunction get71 = Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheB8;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheB9 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheB9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.set_m_learnedPanelCloseBtn);
		}
		LuaObject.addMember(l, name71, get71, Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheB9, true);
		string name72 = "m_learnedPanelSkillCloseBtn";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheBA == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheBA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.get_m_learnedPanelSkillCloseBtn);
		}
		LuaCSFunction get72 = Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheBA;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheBB == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheBB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.set_m_learnedPanelSkillCloseBtn);
		}
		LuaObject.addMember(l, name72, get72, Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheBB, true);
		string name73 = "m_learnedPanelSkillPanel";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheBC == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheBC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.get_m_learnedPanelSkillPanel);
		}
		LuaCSFunction get73 = Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheBC;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheBD == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheBD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.set_m_learnedPanelSkillPanel);
		}
		LuaObject.addMember(l, name73, get73, Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheBD, true);
		string name74 = "m_learnedPanelSoldierPanel";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheBE == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheBE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.get_m_learnedPanelSoldierPanel);
		}
		LuaCSFunction get74 = Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheBE;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheBF == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheBF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.set_m_learnedPanelSoldierPanel);
		}
		LuaObject.addMember(l, name74, get74, Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheBF, true);
		string name75 = "m_learnedPanelSkillIcon";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheC0 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheC0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.get_m_learnedPanelSkillIcon);
		}
		LuaCSFunction get75 = Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheC0;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheC1 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheC1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.set_m_learnedPanelSkillIcon);
		}
		LuaObject.addMember(l, name75, get75, Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheC1, true);
		string name76 = "m_learnedPanelSoldierGraphicObj";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheC2 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheC2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.get_m_learnedPanelSoldierGraphicObj);
		}
		LuaCSFunction get76 = Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheC2;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheC3 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheC3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.set_m_learnedPanelSoldierGraphicObj);
		}
		LuaObject.addMember(l, name76, get76, Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheC3, true);
		string name77 = "m_learnedPanelSkillName";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheC4 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheC4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.get_m_learnedPanelSkillName);
		}
		LuaCSFunction get77 = Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheC4;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheC5 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheC5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.set_m_learnedPanelSkillName);
		}
		LuaObject.addMember(l, name77, get77, Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheC5, true);
		string name78 = "m_learnedPanelSoldierName";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheC6 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheC6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.get_m_learnedPanelSoldierName);
		}
		LuaCSFunction get78 = Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheC6;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheC7 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheC7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.set_m_learnedPanelSoldierName);
		}
		LuaObject.addMember(l, name78, get78, Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheC7, true);
		string name79 = "EventOnJobLvUpgrade";
		LuaCSFunction get79 = null;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheC8 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheC8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.set_EventOnJobLvUpgrade);
		}
		LuaObject.addMember(l, name79, get79, Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheC8, true);
		string name80 = "EventOnShowGetPath";
		LuaCSFunction get80 = null;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheC9 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheC9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.set_EventOnShowGetPath);
		}
		LuaObject.addMember(l, name80, get80, Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheC9, true);
		string name81 = "EventOnUpdateView";
		LuaCSFunction get81 = null;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheCA == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheCA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.set_EventOnUpdateView);
		}
		LuaObject.addMember(l, name81, get81, Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheCA, true);
		string name82 = "m_hero";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheCB == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheCB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.get_m_hero);
		}
		LuaCSFunction get82 = Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheCB;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheCC == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheCC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.set_m_hero);
		}
		LuaObject.addMember(l, name82, get82, Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheCC, true);
		string name83 = "m_jobMaterialObjList";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheCD == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheCD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.get_m_jobMaterialObjList);
		}
		LuaCSFunction get83 = Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheCD;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheCE == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheCE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.set_m_jobMaterialObjList);
		}
		LuaObject.addMember(l, name83, get83, Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheCE, true);
		string name84 = "m_learndSoldierGraphic";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheCF == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheCF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.get_m_learndSoldierGraphic);
		}
		LuaCSFunction get84 = Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheCF;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheD0 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheD0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.set_m_learndSoldierGraphic);
		}
		LuaObject.addMember(l, name84, get84, Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheD0, true);
		string name85 = "m_learnSkillInfo";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheD1 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheD1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.get_m_learnSkillInfo);
		}
		LuaCSFunction get85 = Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheD1;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheD2 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheD2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.set_m_learnSkillInfo);
		}
		LuaObject.addMember(l, name85, get85, Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheD2, true);
		string name86 = "m_learnSoliderInfo";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheD3 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheD3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.get_m_learnSoliderInfo);
		}
		LuaCSFunction get86 = Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheD3;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheD4 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheD4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.set_m_learnSoliderInfo);
		}
		LuaObject.addMember(l, name86, get86, Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheD4, true);
		string name87 = "m_curjobNeedMaterials";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheD5 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheD5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.get_m_curjobNeedMaterials);
		}
		LuaCSFunction get87 = Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheD5;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheD6 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheD6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.set_m_curjobNeedMaterials);
		}
		LuaObject.addMember(l, name87, get87, Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheD6, true);
		string name88 = "m_isCloseJobUpgradePanel";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheD7 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheD7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.get_m_isCloseJobUpgradePanel);
		}
		LuaCSFunction get88 = Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheD7;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheD8 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheD8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.set_m_isCloseJobUpgradePanel);
		}
		LuaObject.addMember(l, name88, get88, Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheD8, true);
		string name89 = "m_isCloseJobMasterRewardPanel";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheD9 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheD9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.get_m_isCloseJobMasterRewardPanel);
		}
		LuaCSFunction get89 = Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheD9;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheDA == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheDA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.set_m_isCloseJobMasterRewardPanel);
		}
		LuaObject.addMember(l, name89, get89, Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheDA, true);
		string name90 = "m_playerContext";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheDB == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheDB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.get_m_playerContext);
		}
		LuaCSFunction get90 = Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheDB;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheDC == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheDC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.set_m_playerContext);
		}
		LuaObject.addMember(l, name90, get90, Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheDC, true);
		string name91 = "m_configDataLoader";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheDD == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheDD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.get_m_configDataLoader);
		}
		LuaCSFunction get91 = Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheDD;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheDE == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheDE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.set_m_configDataLoader);
		}
		LuaObject.addMember(l, name91, get91, Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.<>f__mg$cacheDE, true);
		LuaObject.createTypeMetatable(l, null, typeof(HeroDetailJobUIController), typeof(UIControllerBase));
	}

	// Token: 0x04014E14 RID: 85524
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04014E15 RID: 85525
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04014E16 RID: 85526
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04014E17 RID: 85527
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04014E18 RID: 85528
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04014E19 RID: 85529
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04014E1A RID: 85530
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04014E1B RID: 85531
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04014E1C RID: 85532
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04014E1D RID: 85533
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04014E1E RID: 85534
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04014E1F RID: 85535
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04014E20 RID: 85536
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04014E21 RID: 85537
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04014E22 RID: 85538
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04014E23 RID: 85539
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04014E24 RID: 85540
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04014E25 RID: 85541
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04014E26 RID: 85542
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04014E27 RID: 85543
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04014E28 RID: 85544
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04014E29 RID: 85545
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04014E2A RID: 85546
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04014E2B RID: 85547
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04014E2C RID: 85548
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04014E2D RID: 85549
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04014E2E RID: 85550
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04014E2F RID: 85551
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04014E30 RID: 85552
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04014E31 RID: 85553
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04014E32 RID: 85554
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04014E33 RID: 85555
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04014E34 RID: 85556
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04014E35 RID: 85557
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04014E36 RID: 85558
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04014E37 RID: 85559
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04014E38 RID: 85560
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04014E39 RID: 85561
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04014E3A RID: 85562
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04014E3B RID: 85563
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04014E3C RID: 85564
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04014E3D RID: 85565
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04014E3E RID: 85566
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04014E3F RID: 85567
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04014E40 RID: 85568
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04014E41 RID: 85569
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04014E42 RID: 85570
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04014E43 RID: 85571
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04014E44 RID: 85572
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04014E45 RID: 85573
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04014E46 RID: 85574
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x04014E47 RID: 85575
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x04014E48 RID: 85576
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x04014E49 RID: 85577
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x04014E4A RID: 85578
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x04014E4B RID: 85579
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x04014E4C RID: 85580
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x04014E4D RID: 85581
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x04014E4E RID: 85582
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x04014E4F RID: 85583
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x04014E50 RID: 85584
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x04014E51 RID: 85585
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x04014E52 RID: 85586
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x04014E53 RID: 85587
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x04014E54 RID: 85588
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x04014E55 RID: 85589
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x04014E56 RID: 85590
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x04014E57 RID: 85591
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x04014E58 RID: 85592
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x04014E59 RID: 85593
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x04014E5A RID: 85594
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;

	// Token: 0x04014E5B RID: 85595
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache47;

	// Token: 0x04014E5C RID: 85596
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache48;

	// Token: 0x04014E5D RID: 85597
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache49;

	// Token: 0x04014E5E RID: 85598
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4A;

	// Token: 0x04014E5F RID: 85599
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4B;

	// Token: 0x04014E60 RID: 85600
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4C;

	// Token: 0x04014E61 RID: 85601
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4D;

	// Token: 0x04014E62 RID: 85602
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4E;

	// Token: 0x04014E63 RID: 85603
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4F;

	// Token: 0x04014E64 RID: 85604
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache50;

	// Token: 0x04014E65 RID: 85605
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache51;

	// Token: 0x04014E66 RID: 85606
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache52;

	// Token: 0x04014E67 RID: 85607
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache53;

	// Token: 0x04014E68 RID: 85608
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache54;

	// Token: 0x04014E69 RID: 85609
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache55;

	// Token: 0x04014E6A RID: 85610
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache56;

	// Token: 0x04014E6B RID: 85611
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache57;

	// Token: 0x04014E6C RID: 85612
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache58;

	// Token: 0x04014E6D RID: 85613
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache59;

	// Token: 0x04014E6E RID: 85614
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5A;

	// Token: 0x04014E6F RID: 85615
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5B;

	// Token: 0x04014E70 RID: 85616
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5C;

	// Token: 0x04014E71 RID: 85617
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5D;

	// Token: 0x04014E72 RID: 85618
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5E;

	// Token: 0x04014E73 RID: 85619
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5F;

	// Token: 0x04014E74 RID: 85620
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache60;

	// Token: 0x04014E75 RID: 85621
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache61;

	// Token: 0x04014E76 RID: 85622
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache62;

	// Token: 0x04014E77 RID: 85623
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache63;

	// Token: 0x04014E78 RID: 85624
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache64;

	// Token: 0x04014E79 RID: 85625
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache65;

	// Token: 0x04014E7A RID: 85626
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache66;

	// Token: 0x04014E7B RID: 85627
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache67;

	// Token: 0x04014E7C RID: 85628
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache68;

	// Token: 0x04014E7D RID: 85629
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache69;

	// Token: 0x04014E7E RID: 85630
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6A;

	// Token: 0x04014E7F RID: 85631
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6B;

	// Token: 0x04014E80 RID: 85632
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6C;

	// Token: 0x04014E81 RID: 85633
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6D;

	// Token: 0x04014E82 RID: 85634
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6E;

	// Token: 0x04014E83 RID: 85635
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6F;

	// Token: 0x04014E84 RID: 85636
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache70;

	// Token: 0x04014E85 RID: 85637
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache71;

	// Token: 0x04014E86 RID: 85638
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache72;

	// Token: 0x04014E87 RID: 85639
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache73;

	// Token: 0x04014E88 RID: 85640
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache74;

	// Token: 0x04014E89 RID: 85641
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache75;

	// Token: 0x04014E8A RID: 85642
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache76;

	// Token: 0x04014E8B RID: 85643
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache77;

	// Token: 0x04014E8C RID: 85644
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache78;

	// Token: 0x04014E8D RID: 85645
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache79;

	// Token: 0x04014E8E RID: 85646
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7A;

	// Token: 0x04014E8F RID: 85647
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7B;

	// Token: 0x04014E90 RID: 85648
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7C;

	// Token: 0x04014E91 RID: 85649
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7D;

	// Token: 0x04014E92 RID: 85650
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7E;

	// Token: 0x04014E93 RID: 85651
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7F;

	// Token: 0x04014E94 RID: 85652
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache80;

	// Token: 0x04014E95 RID: 85653
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache81;

	// Token: 0x04014E96 RID: 85654
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache82;

	// Token: 0x04014E97 RID: 85655
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache83;

	// Token: 0x04014E98 RID: 85656
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache84;

	// Token: 0x04014E99 RID: 85657
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache85;

	// Token: 0x04014E9A RID: 85658
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache86;

	// Token: 0x04014E9B RID: 85659
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache87;

	// Token: 0x04014E9C RID: 85660
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache88;

	// Token: 0x04014E9D RID: 85661
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache89;

	// Token: 0x04014E9E RID: 85662
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8A;

	// Token: 0x04014E9F RID: 85663
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8B;

	// Token: 0x04014EA0 RID: 85664
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8C;

	// Token: 0x04014EA1 RID: 85665
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8D;

	// Token: 0x04014EA2 RID: 85666
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8E;

	// Token: 0x04014EA3 RID: 85667
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8F;

	// Token: 0x04014EA4 RID: 85668
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache90;

	// Token: 0x04014EA5 RID: 85669
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache91;

	// Token: 0x04014EA6 RID: 85670
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache92;

	// Token: 0x04014EA7 RID: 85671
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache93;

	// Token: 0x04014EA8 RID: 85672
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache94;

	// Token: 0x04014EA9 RID: 85673
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache95;

	// Token: 0x04014EAA RID: 85674
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache96;

	// Token: 0x04014EAB RID: 85675
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache97;

	// Token: 0x04014EAC RID: 85676
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache98;

	// Token: 0x04014EAD RID: 85677
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache99;

	// Token: 0x04014EAE RID: 85678
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9A;

	// Token: 0x04014EAF RID: 85679
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9B;

	// Token: 0x04014EB0 RID: 85680
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9C;

	// Token: 0x04014EB1 RID: 85681
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9D;

	// Token: 0x04014EB2 RID: 85682
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9E;

	// Token: 0x04014EB3 RID: 85683
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9F;

	// Token: 0x04014EB4 RID: 85684
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA0;

	// Token: 0x04014EB5 RID: 85685
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA1;

	// Token: 0x04014EB6 RID: 85686
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA2;

	// Token: 0x04014EB7 RID: 85687
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA3;

	// Token: 0x04014EB8 RID: 85688
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA4;

	// Token: 0x04014EB9 RID: 85689
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA5;

	// Token: 0x04014EBA RID: 85690
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA6;

	// Token: 0x04014EBB RID: 85691
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA7;

	// Token: 0x04014EBC RID: 85692
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA8;

	// Token: 0x04014EBD RID: 85693
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA9;

	// Token: 0x04014EBE RID: 85694
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAA;

	// Token: 0x04014EBF RID: 85695
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAB;

	// Token: 0x04014EC0 RID: 85696
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAC;

	// Token: 0x04014EC1 RID: 85697
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAD;

	// Token: 0x04014EC2 RID: 85698
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAE;

	// Token: 0x04014EC3 RID: 85699
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAF;

	// Token: 0x04014EC4 RID: 85700
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB0;

	// Token: 0x04014EC5 RID: 85701
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB1;

	// Token: 0x04014EC6 RID: 85702
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB2;

	// Token: 0x04014EC7 RID: 85703
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB3;

	// Token: 0x04014EC8 RID: 85704
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB4;

	// Token: 0x04014EC9 RID: 85705
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB5;

	// Token: 0x04014ECA RID: 85706
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB6;

	// Token: 0x04014ECB RID: 85707
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB7;

	// Token: 0x04014ECC RID: 85708
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB8;

	// Token: 0x04014ECD RID: 85709
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB9;

	// Token: 0x04014ECE RID: 85710
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBA;

	// Token: 0x04014ECF RID: 85711
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBB;

	// Token: 0x04014ED0 RID: 85712
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBC;

	// Token: 0x04014ED1 RID: 85713
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBD;

	// Token: 0x04014ED2 RID: 85714
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBE;

	// Token: 0x04014ED3 RID: 85715
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBF;

	// Token: 0x04014ED4 RID: 85716
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC0;

	// Token: 0x04014ED5 RID: 85717
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC1;

	// Token: 0x04014ED6 RID: 85718
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC2;

	// Token: 0x04014ED7 RID: 85719
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC3;

	// Token: 0x04014ED8 RID: 85720
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC4;

	// Token: 0x04014ED9 RID: 85721
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC5;

	// Token: 0x04014EDA RID: 85722
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC6;

	// Token: 0x04014EDB RID: 85723
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC7;

	// Token: 0x04014EDC RID: 85724
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC8;

	// Token: 0x04014EDD RID: 85725
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC9;

	// Token: 0x04014EDE RID: 85726
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCA;

	// Token: 0x04014EDF RID: 85727
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCB;

	// Token: 0x04014EE0 RID: 85728
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCC;

	// Token: 0x04014EE1 RID: 85729
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCD;

	// Token: 0x04014EE2 RID: 85730
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCE;

	// Token: 0x04014EE3 RID: 85731
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCF;

	// Token: 0x04014EE4 RID: 85732
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD0;

	// Token: 0x04014EE5 RID: 85733
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD1;

	// Token: 0x04014EE6 RID: 85734
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD2;

	// Token: 0x04014EE7 RID: 85735
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD3;

	// Token: 0x04014EE8 RID: 85736
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD4;

	// Token: 0x04014EE9 RID: 85737
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD5;

	// Token: 0x04014EEA RID: 85738
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD6;

	// Token: 0x04014EEB RID: 85739
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD7;

	// Token: 0x04014EEC RID: 85740
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD8;

	// Token: 0x04014EED RID: 85741
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD9;

	// Token: 0x04014EEE RID: 85742
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDA;

	// Token: 0x04014EEF RID: 85743
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDB;

	// Token: 0x04014EF0 RID: 85744
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDC;

	// Token: 0x04014EF1 RID: 85745
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDD;

	// Token: 0x04014EF2 RID: 85746
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDE;
}
