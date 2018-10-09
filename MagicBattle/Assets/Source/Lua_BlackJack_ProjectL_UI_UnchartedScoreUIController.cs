using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Scene;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x020015CC RID: 5580
[Preserve]
public class Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController : LuaObject
{
	// Token: 0x06021F58 RID: 139096 RVA: 0x00B908B0 File Offset: 0x00B8EAB0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Open(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUIController unchartedScoreUIController = (UnchartedScoreUIController)LuaObject.checkSelf(l);
			unchartedScoreUIController.Open();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021F59 RID: 139097 RVA: 0x00B908FC File Offset: 0x00B8EAFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetBattleType(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUIController unchartedScoreUIController = (UnchartedScoreUIController)LuaObject.checkSelf(l);
			BattleType battleType;
			LuaObject.checkEnum<BattleType>(l, 2, out battleType);
			unchartedScoreUIController.SetBattleType(battleType);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021F5A RID: 139098 RVA: 0x00B90954 File Offset: 0x00B8EB54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetScore(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUIController unchartedScoreUIController = (UnchartedScoreUIController)LuaObject.checkSelf(l);
			int score;
			LuaObject.checkType(l, 2, out score);
			unchartedScoreUIController.SetScore(score);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021F5B RID: 139099 RVA: 0x00B909AC File Offset: 0x00B8EBAC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetUnchartedScoreInfo(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUIController unchartedScoreUIController = (UnchartedScoreUIController)LuaObject.checkSelf(l);
			ConfigDataUnchartedScoreInfo unchartedScoreInfo;
			LuaObject.checkType<ConfigDataUnchartedScoreInfo>(l, 2, out unchartedScoreInfo);
			ConfigDataUnchartedScoreModelInfo unchartedScoreModelInfo;
			LuaObject.checkType<ConfigDataUnchartedScoreModelInfo>(l, 3, out unchartedScoreModelInfo);
			unchartedScoreUIController.SetUnchartedScoreInfo(unchartedScoreInfo, unchartedScoreModelInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021F5C RID: 139100 RVA: 0x00B90A10 File Offset: 0x00B8EC10
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetAllUnchartedScoreLevelListItems(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUIController unchartedScoreUIController = (UnchartedScoreUIController)LuaObject.checkSelf(l);
			IEnumerable<ConfigDataScoreLevelInfo> allUnchartedScoreLevelListItems;
			LuaObject.checkType<IEnumerable<ConfigDataScoreLevelInfo>>(l, 2, out allUnchartedScoreLevelListItems);
			unchartedScoreUIController.SetAllUnchartedScoreLevelListItems(allUnchartedScoreLevelListItems);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021F5D RID: 139101 RVA: 0x00B90A68 File Offset: 0x00B8EC68
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetAllUnchartedChallengeLevelListItems(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUIController unchartedScoreUIController = (UnchartedScoreUIController)LuaObject.checkSelf(l);
			IEnumerable<ConfigDataChallengeLevelInfo> allUnchartedChallengeLevelListItems;
			LuaObject.checkType<IEnumerable<ConfigDataChallengeLevelInfo>>(l, 2, out allUnchartedChallengeLevelListItems);
			unchartedScoreUIController.SetAllUnchartedChallengeLevelListItems(allUnchartedChallengeLevelListItems);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021F5E RID: 139102 RVA: 0x00B90AC0 File Offset: 0x00B8ECC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetDailyRewardCount(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUIController unchartedScoreUIController = (UnchartedScoreUIController)LuaObject.checkSelf(l);
			int restCount;
			LuaObject.checkType(l, 2, out restCount);
			int allCount;
			LuaObject.checkType(l, 3, out allCount);
			unchartedScoreUIController.SetDailyRewardCount(restCount, allCount);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021F5F RID: 139103 RVA: 0x00B90B24 File Offset: 0x00B8ED24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowScoreReward(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUIController unchartedScoreUIController = (UnchartedScoreUIController)LuaObject.checkSelf(l);
			unchartedScoreUIController.ShowScoreReward();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021F60 RID: 139104 RVA: 0x00B90B70 File Offset: 0x00B8ED70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowRecommendHero(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUIController unchartedScoreUIController = (UnchartedScoreUIController)LuaObject.checkSelf(l);
			unchartedScoreUIController.ShowRecommendHero();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021F61 RID: 139105 RVA: 0x00B90BBC File Offset: 0x00B8EDBC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUIController unchartedScoreUIController = (UnchartedScoreUIController)LuaObject.checkSelf(l);
			unchartedScoreUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021F62 RID: 139106 RVA: 0x00B90C10 File Offset: 0x00B8EE10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CreateSpineGraphic(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUIController unchartedScoreUIController = (UnchartedScoreUIController)LuaObject.checkSelf(l);
			ConfigDataUnchartedScoreModelInfo unchartedScoreModelInfo;
			LuaObject.checkType<ConfigDataUnchartedScoreModelInfo>(l, 2, out unchartedScoreModelInfo);
			unchartedScoreUIController.m_luaExportHelper.CreateSpineGraphic(unchartedScoreModelInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021F63 RID: 139107 RVA: 0x00B90C6C File Offset: 0x00B8EE6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DestroySpineGraphic(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUIController unchartedScoreUIController = (UnchartedScoreUIController)LuaObject.checkSelf(l);
			unchartedScoreUIController.m_luaExportHelper.DestroySpineGraphic();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021F64 RID: 139108 RVA: 0x00B90CC0 File Offset: 0x00B8EEC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Co_ScrollToItem(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUIController unchartedScoreUIController = (UnchartedScoreUIController)LuaObject.checkSelf(l);
			ScrollRect scrollRect;
			LuaObject.checkType<ScrollRect>(l, 2, out scrollRect);
			int itemCount;
			LuaObject.checkType(l, 3, out itemCount);
			int idx;
			LuaObject.checkType(l, 4, out idx);
			IEnumerator o = unchartedScoreUIController.m_luaExportHelper.Co_ScrollToItem(scrollRect, itemCount, idx);
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

	// Token: 0x06021F65 RID: 139109 RVA: 0x00B90D44 File Offset: 0x00B8EF44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HideScoreReward(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUIController unchartedScoreUIController = (UnchartedScoreUIController)LuaObject.checkSelf(l);
			unchartedScoreUIController.m_luaExportHelper.HideScoreReward();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021F66 RID: 139110 RVA: 0x00B90D98 File Offset: 0x00B8EF98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HideRecommendHero(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUIController unchartedScoreUIController = (UnchartedScoreUIController)LuaObject.checkSelf(l);
			unchartedScoreUIController.m_luaExportHelper.HideRecommendHero();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021F67 RID: 139111 RVA: 0x00B90DEC File Offset: 0x00B8EFEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnReturnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUIController unchartedScoreUIController = (UnchartedScoreUIController)LuaObject.checkSelf(l);
			unchartedScoreUIController.m_luaExportHelper.OnReturnButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021F68 RID: 139112 RVA: 0x00B90E40 File Offset: 0x00B8F040
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnHelpButtonClick(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUIController unchartedScoreUIController = (UnchartedScoreUIController)LuaObject.checkSelf(l);
			unchartedScoreUIController.m_luaExportHelper.OnHelpButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021F69 RID: 139113 RVA: 0x00B90E94 File Offset: 0x00B8F094
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnTeamButtonClick(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUIController unchartedScoreUIController = (UnchartedScoreUIController)LuaObject.checkSelf(l);
			unchartedScoreUIController.m_luaExportHelper.OnTeamButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021F6A RID: 139114 RVA: 0x00B90EE8 File Offset: 0x00B8F0E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnRewardButtonClick(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUIController unchartedScoreUIController = (UnchartedScoreUIController)LuaObject.checkSelf(l);
			unchartedScoreUIController.m_luaExportHelper.OnRewardButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021F6B RID: 139115 RVA: 0x00B90F3C File Offset: 0x00B8F13C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnRecommendHeroButtonClick(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUIController unchartedScoreUIController = (UnchartedScoreUIController)LuaObject.checkSelf(l);
			unchartedScoreUIController.m_luaExportHelper.OnRecommendHeroButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021F6C RID: 139116 RVA: 0x00B90F90 File Offset: 0x00B8F190
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnScoreLevelToggleValueChanged(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUIController unchartedScoreUIController = (UnchartedScoreUIController)LuaObject.checkSelf(l);
			bool on;
			LuaObject.checkType(l, 2, out on);
			unchartedScoreUIController.m_luaExportHelper.OnScoreLevelToggleValueChanged(on);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021F6D RID: 139117 RVA: 0x00B90FEC File Offset: 0x00B8F1EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnChallengeLevelToggleValueChanged(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUIController unchartedScoreUIController = (UnchartedScoreUIController)LuaObject.checkSelf(l);
			bool on;
			LuaObject.checkType(l, 2, out on);
			unchartedScoreUIController.m_luaExportHelper.OnChallengeLevelToggleValueChanged(on);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021F6E RID: 139118 RVA: 0x00B91048 File Offset: 0x00B8F248
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnScoreRewardCloseButtonClick(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUIController unchartedScoreUIController = (UnchartedScoreUIController)LuaObject.checkSelf(l);
			unchartedScoreUIController.m_luaExportHelper.OnScoreRewardCloseButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021F6F RID: 139119 RVA: 0x00B9109C File Offset: 0x00B8F29C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnRecommendHeroBGButtonClick(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUIController unchartedScoreUIController = (UnchartedScoreUIController)LuaObject.checkSelf(l);
			unchartedScoreUIController.m_luaExportHelper.OnRecommendHeroBGButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021F70 RID: 139120 RVA: 0x00B910F0 File Offset: 0x00B8F2F0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int UnchartedScoreLevelListItem_OnStartButtonClick(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUIController unchartedScoreUIController = (UnchartedScoreUIController)LuaObject.checkSelf(l);
			UnchartedScoreLevelListItemUIController ctrl;
			LuaObject.checkType<UnchartedScoreLevelListItemUIController>(l, 2, out ctrl);
			unchartedScoreUIController.m_luaExportHelper.UnchartedScoreLevelListItem_OnStartButtonClick(ctrl);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021F71 RID: 139121 RVA: 0x00B9114C File Offset: 0x00B8F34C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUIController unchartedScoreUIController = (UnchartedScoreUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			unchartedScoreUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021F72 RID: 139122 RVA: 0x00B911B8 File Offset: 0x00B8F3B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUIController unchartedScoreUIController = (UnchartedScoreUIController)LuaObject.checkSelf(l);
			unchartedScoreUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021F73 RID: 139123 RVA: 0x00B9120C File Offset: 0x00B8F40C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUIController unchartedScoreUIController = (UnchartedScoreUIController)LuaObject.checkSelf(l);
			unchartedScoreUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021F74 RID: 139124 RVA: 0x00B91260 File Offset: 0x00B8F460
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUIController unchartedScoreUIController = (UnchartedScoreUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = unchartedScoreUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x06021F75 RID: 139125 RVA: 0x00B91308 File Offset: 0x00B8F508
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUIController unchartedScoreUIController = (UnchartedScoreUIController)LuaObject.checkSelf(l);
			unchartedScoreUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021F76 RID: 139126 RVA: 0x00B9135C File Offset: 0x00B8F55C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUIController unchartedScoreUIController = (UnchartedScoreUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			unchartedScoreUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021F77 RID: 139127 RVA: 0x00B913C8 File Offset: 0x00B8F5C8
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
				UnchartedScoreUIController unchartedScoreUIController = (UnchartedScoreUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				unchartedScoreUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				UnchartedScoreUIController unchartedScoreUIController2 = (UnchartedScoreUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				unchartedScoreUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x06021F78 RID: 139128 RVA: 0x00B914D8 File Offset: 0x00B8F6D8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUIController unchartedScoreUIController = (UnchartedScoreUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			unchartedScoreUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021F79 RID: 139129 RVA: 0x00B91544 File Offset: 0x00B8F744
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUIController unchartedScoreUIController = (UnchartedScoreUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			unchartedScoreUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021F7A RID: 139130 RVA: 0x00B915B0 File Offset: 0x00B8F7B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUIController unchartedScoreUIController = (UnchartedScoreUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			unchartedScoreUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021F7B RID: 139131 RVA: 0x00B9161C File Offset: 0x00B8F81C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUIController unchartedScoreUIController = (UnchartedScoreUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			unchartedScoreUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021F7C RID: 139132 RVA: 0x00B91688 File Offset: 0x00B8F888
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
				UnchartedScoreUIController unchartedScoreUIController = (UnchartedScoreUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				unchartedScoreUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				UnchartedScoreUIController unchartedScoreUIController2 = (UnchartedScoreUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				unchartedScoreUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x06021F7D RID: 139133 RVA: 0x00B91798 File Offset: 0x00B8F998
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUIController unchartedScoreUIController = (UnchartedScoreUIController)LuaObject.checkSelf(l);
			string s = unchartedScoreUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x06021F7E RID: 139134 RVA: 0x00B917F4 File Offset: 0x00B8F9F4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callDele_EventOnReturn(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUIController unchartedScoreUIController = (UnchartedScoreUIController)LuaObject.checkSelf(l);
			unchartedScoreUIController.m_luaExportHelper.__callDele_EventOnReturn();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021F7F RID: 139135 RVA: 0x00B91848 File Offset: 0x00B8FA48
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __clearDele_EventOnReturn(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUIController unchartedScoreUIController = (UnchartedScoreUIController)LuaObject.checkSelf(l);
			unchartedScoreUIController.m_luaExportHelper.__clearDele_EventOnReturn();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021F80 RID: 139136 RVA: 0x00B9189C File Offset: 0x00B8FA9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnShowHelp(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUIController unchartedScoreUIController = (UnchartedScoreUIController)LuaObject.checkSelf(l);
			unchartedScoreUIController.m_luaExportHelper.__callDele_EventOnShowHelp();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021F81 RID: 139137 RVA: 0x00B918F0 File Offset: 0x00B8FAF0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __clearDele_EventOnShowHelp(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUIController unchartedScoreUIController = (UnchartedScoreUIController)LuaObject.checkSelf(l);
			unchartedScoreUIController.m_luaExportHelper.__clearDele_EventOnShowHelp();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021F82 RID: 139138 RVA: 0x00B91944 File Offset: 0x00B8FB44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnShowTeam(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUIController unchartedScoreUIController = (UnchartedScoreUIController)LuaObject.checkSelf(l);
			unchartedScoreUIController.m_luaExportHelper.__callDele_EventOnShowTeam();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021F83 RID: 139139 RVA: 0x00B91998 File Offset: 0x00B8FB98
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __clearDele_EventOnShowTeam(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUIController unchartedScoreUIController = (UnchartedScoreUIController)LuaObject.checkSelf(l);
			unchartedScoreUIController.m_luaExportHelper.__clearDele_EventOnShowTeam();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021F84 RID: 139140 RVA: 0x00B919EC File Offset: 0x00B8FBEC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callDele_EventOnChangeBattleType(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUIController unchartedScoreUIController = (UnchartedScoreUIController)LuaObject.checkSelf(l);
			BattleType obj;
			LuaObject.checkEnum<BattleType>(l, 2, out obj);
			unchartedScoreUIController.m_luaExportHelper.__callDele_EventOnChangeBattleType(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021F85 RID: 139141 RVA: 0x00B91A48 File Offset: 0x00B8FC48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnChangeBattleType(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUIController unchartedScoreUIController = (UnchartedScoreUIController)LuaObject.checkSelf(l);
			BattleType obj;
			LuaObject.checkEnum<BattleType>(l, 2, out obj);
			unchartedScoreUIController.m_luaExportHelper.__clearDele_EventOnChangeBattleType(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021F86 RID: 139142 RVA: 0x00B91AA4 File Offset: 0x00B8FCA4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callDele_EventOnStartUnchartedScoreLevel(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUIController unchartedScoreUIController = (UnchartedScoreUIController)LuaObject.checkSelf(l);
			ConfigDataScoreLevelInfo obj;
			LuaObject.checkType<ConfigDataScoreLevelInfo>(l, 2, out obj);
			unchartedScoreUIController.m_luaExportHelper.__callDele_EventOnStartUnchartedScoreLevel(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021F87 RID: 139143 RVA: 0x00B91B00 File Offset: 0x00B8FD00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnStartUnchartedScoreLevel(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUIController unchartedScoreUIController = (UnchartedScoreUIController)LuaObject.checkSelf(l);
			ConfigDataScoreLevelInfo obj;
			LuaObject.checkType<ConfigDataScoreLevelInfo>(l, 2, out obj);
			unchartedScoreUIController.m_luaExportHelper.__clearDele_EventOnStartUnchartedScoreLevel(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021F88 RID: 139144 RVA: 0x00B91B5C File Offset: 0x00B8FD5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnStartUnchartedChallengeLevel(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUIController unchartedScoreUIController = (UnchartedScoreUIController)LuaObject.checkSelf(l);
			ConfigDataChallengeLevelInfo obj;
			LuaObject.checkType<ConfigDataChallengeLevelInfo>(l, 2, out obj);
			unchartedScoreUIController.m_luaExportHelper.__callDele_EventOnStartUnchartedChallengeLevel(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021F89 RID: 139145 RVA: 0x00B91BB8 File Offset: 0x00B8FDB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnStartUnchartedChallengeLevel(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUIController unchartedScoreUIController = (UnchartedScoreUIController)LuaObject.checkSelf(l);
			ConfigDataChallengeLevelInfo obj;
			LuaObject.checkType<ConfigDataChallengeLevelInfo>(l, 2, out obj);
			unchartedScoreUIController.m_luaExportHelper.__clearDele_EventOnStartUnchartedChallengeLevel(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021F8A RID: 139146 RVA: 0x00B91C14 File Offset: 0x00B8FE14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ScrollToItem_s(IntPtr l)
	{
		int result;
		try
		{
			ScrollRect scrollRect;
			LuaObject.checkType<ScrollRect>(l, 1, out scrollRect);
			int itemCount;
			LuaObject.checkType(l, 2, out itemCount);
			int idx;
			LuaObject.checkType(l, 3, out idx);
			UnchartedScoreUIController.LuaExportHelper.ScrollToItem(scrollRect, itemCount, idx);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021F8B RID: 139147 RVA: 0x00B91C78 File Offset: 0x00B8FE78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnReturn(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUIController unchartedScoreUIController = (UnchartedScoreUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					unchartedScoreUIController.EventOnReturn += value;
				}
				else if (num == 2)
				{
					unchartedScoreUIController.EventOnReturn -= value;
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

	// Token: 0x06021F8C RID: 139148 RVA: 0x00B91CF8 File Offset: 0x00B8FEF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnShowHelp(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUIController unchartedScoreUIController = (UnchartedScoreUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					unchartedScoreUIController.EventOnShowHelp += value;
				}
				else if (num == 2)
				{
					unchartedScoreUIController.EventOnShowHelp -= value;
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

	// Token: 0x06021F8D RID: 139149 RVA: 0x00B91D78 File Offset: 0x00B8FF78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnShowTeam(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUIController unchartedScoreUIController = (UnchartedScoreUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					unchartedScoreUIController.EventOnShowTeam += value;
				}
				else if (num == 2)
				{
					unchartedScoreUIController.EventOnShowTeam -= value;
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

	// Token: 0x06021F8E RID: 139150 RVA: 0x00B91DF8 File Offset: 0x00B8FFF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnChangeBattleType(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUIController unchartedScoreUIController = (UnchartedScoreUIController)LuaObject.checkSelf(l);
			Action<BattleType> value;
			int num = LuaObject.checkDelegate<Action<BattleType>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					unchartedScoreUIController.EventOnChangeBattleType += value;
				}
				else if (num == 2)
				{
					unchartedScoreUIController.EventOnChangeBattleType -= value;
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

	// Token: 0x06021F8F RID: 139151 RVA: 0x00B91E78 File Offset: 0x00B90078
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnStartUnchartedScoreLevel(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUIController unchartedScoreUIController = (UnchartedScoreUIController)LuaObject.checkSelf(l);
			Action<ConfigDataScoreLevelInfo> value;
			int num = LuaObject.checkDelegate<Action<ConfigDataScoreLevelInfo>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					unchartedScoreUIController.EventOnStartUnchartedScoreLevel += value;
				}
				else if (num == 2)
				{
					unchartedScoreUIController.EventOnStartUnchartedScoreLevel -= value;
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

	// Token: 0x06021F90 RID: 139152 RVA: 0x00B91EF8 File Offset: 0x00B900F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnStartUnchartedChallengeLevel(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUIController unchartedScoreUIController = (UnchartedScoreUIController)LuaObject.checkSelf(l);
			Action<ConfigDataChallengeLevelInfo> value;
			int num = LuaObject.checkDelegate<Action<ConfigDataChallengeLevelInfo>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					unchartedScoreUIController.EventOnStartUnchartedChallengeLevel += value;
				}
				else if (num == 2)
				{
					unchartedScoreUIController.EventOnStartUnchartedChallengeLevel -= value;
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

	// Token: 0x06021F91 RID: 139153 RVA: 0x00B91F78 File Offset: 0x00B90178
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiStateController(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUIController unchartedScoreUIController = (UnchartedScoreUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, unchartedScoreUIController.m_luaExportHelper.m_uiStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021F92 RID: 139154 RVA: 0x00B91FD0 File Offset: 0x00B901D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiStateController(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUIController unchartedScoreUIController = (UnchartedScoreUIController)LuaObject.checkSelf(l);
			CommonUIStateController uiStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out uiStateController);
			unchartedScoreUIController.m_luaExportHelper.m_uiStateController = uiStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021F93 RID: 139155 RVA: 0x00B9202C File Offset: 0x00B9022C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_returnButton(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUIController unchartedScoreUIController = (UnchartedScoreUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, unchartedScoreUIController.m_luaExportHelper.m_returnButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021F94 RID: 139156 RVA: 0x00B92084 File Offset: 0x00B90284
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_returnButton(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUIController unchartedScoreUIController = (UnchartedScoreUIController)LuaObject.checkSelf(l);
			Button returnButton;
			LuaObject.checkType<Button>(l, 2, out returnButton);
			unchartedScoreUIController.m_luaExportHelper.m_returnButton = returnButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021F95 RID: 139157 RVA: 0x00B920E0 File Offset: 0x00B902E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_helpButton(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUIController unchartedScoreUIController = (UnchartedScoreUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, unchartedScoreUIController.m_luaExportHelper.m_helpButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021F96 RID: 139158 RVA: 0x00B92138 File Offset: 0x00B90338
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_helpButton(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUIController unchartedScoreUIController = (UnchartedScoreUIController)LuaObject.checkSelf(l);
			Button helpButton;
			LuaObject.checkType<Button>(l, 2, out helpButton);
			unchartedScoreUIController.m_luaExportHelper.m_helpButton = helpButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021F97 RID: 139159 RVA: 0x00B92194 File Offset: 0x00B90394
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_teamButton(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUIController unchartedScoreUIController = (UnchartedScoreUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, unchartedScoreUIController.m_luaExportHelper.m_teamButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021F98 RID: 139160 RVA: 0x00B921EC File Offset: 0x00B903EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_teamButton(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUIController unchartedScoreUIController = (UnchartedScoreUIController)LuaObject.checkSelf(l);
			Button teamButton;
			LuaObject.checkType<Button>(l, 2, out teamButton);
			unchartedScoreUIController.m_luaExportHelper.m_teamButton = teamButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021F99 RID: 139161 RVA: 0x00B92248 File Offset: 0x00B90448
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_dailyRewardCountText(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUIController unchartedScoreUIController = (UnchartedScoreUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, unchartedScoreUIController.m_luaExportHelper.m_dailyRewardCountText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021F9A RID: 139162 RVA: 0x00B922A0 File Offset: 0x00B904A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_dailyRewardCountText(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUIController unchartedScoreUIController = (UnchartedScoreUIController)LuaObject.checkSelf(l);
			Text dailyRewardCountText;
			LuaObject.checkType<Text>(l, 2, out dailyRewardCountText);
			unchartedScoreUIController.m_luaExportHelper.m_dailyRewardCountText = dailyRewardCountText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021F9B RID: 139163 RVA: 0x00B922FC File Offset: 0x00B904FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_activityNameText(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUIController unchartedScoreUIController = (UnchartedScoreUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, unchartedScoreUIController.m_luaExportHelper.m_activityNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021F9C RID: 139164 RVA: 0x00B92354 File Offset: 0x00B90554
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_activityNameText(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUIController unchartedScoreUIController = (UnchartedScoreUIController)LuaObject.checkSelf(l);
			Text activityNameText;
			LuaObject.checkType<Text>(l, 2, out activityNameText);
			unchartedScoreUIController.m_luaExportHelper.m_activityNameText = activityNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021F9D RID: 139165 RVA: 0x00B923B0 File Offset: 0x00B905B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_activityUIStateController(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUIController unchartedScoreUIController = (UnchartedScoreUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, unchartedScoreUIController.m_luaExportHelper.m_activityUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021F9E RID: 139166 RVA: 0x00B92408 File Offset: 0x00B90608
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_activityUIStateController(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUIController unchartedScoreUIController = (UnchartedScoreUIController)LuaObject.checkSelf(l);
			CommonUIStateController activityUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out activityUIStateController);
			unchartedScoreUIController.m_luaExportHelper.m_activityUIStateController = activityUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021F9F RID: 139167 RVA: 0x00B92464 File Offset: 0x00B90664
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_charGo(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUIController unchartedScoreUIController = (UnchartedScoreUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, unchartedScoreUIController.m_luaExportHelper.m_charGo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021FA0 RID: 139168 RVA: 0x00B924BC File Offset: 0x00B906BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_charGo(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUIController unchartedScoreUIController = (UnchartedScoreUIController)LuaObject.checkSelf(l);
			GameObject charGo;
			LuaObject.checkType<GameObject>(l, 2, out charGo);
			unchartedScoreUIController.m_luaExportHelper.m_charGo = charGo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021FA1 RID: 139169 RVA: 0x00B92518 File Offset: 0x00B90718
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_levelListScrollRect(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUIController unchartedScoreUIController = (UnchartedScoreUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, unchartedScoreUIController.m_luaExportHelper.m_levelListScrollRect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021FA2 RID: 139170 RVA: 0x00B92570 File Offset: 0x00B90770
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_levelListScrollRect(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUIController unchartedScoreUIController = (UnchartedScoreUIController)LuaObject.checkSelf(l);
			ScrollRect levelListScrollRect;
			LuaObject.checkType<ScrollRect>(l, 2, out levelListScrollRect);
			unchartedScoreUIController.m_luaExportHelper.m_levelListScrollRect = levelListScrollRect;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021FA3 RID: 139171 RVA: 0x00B925CC File Offset: 0x00B907CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_scoreLevelToggle(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUIController unchartedScoreUIController = (UnchartedScoreUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, unchartedScoreUIController.m_luaExportHelper.m_scoreLevelToggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021FA4 RID: 139172 RVA: 0x00B92624 File Offset: 0x00B90824
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_scoreLevelToggle(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUIController unchartedScoreUIController = (UnchartedScoreUIController)LuaObject.checkSelf(l);
			Toggle scoreLevelToggle;
			LuaObject.checkType<Toggle>(l, 2, out scoreLevelToggle);
			unchartedScoreUIController.m_luaExportHelper.m_scoreLevelToggle = scoreLevelToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021FA5 RID: 139173 RVA: 0x00B92680 File Offset: 0x00B90880
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_challengeLevelToggle(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUIController unchartedScoreUIController = (UnchartedScoreUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, unchartedScoreUIController.m_luaExportHelper.m_challengeLevelToggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021FA6 RID: 139174 RVA: 0x00B926D8 File Offset: 0x00B908D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_challengeLevelToggle(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUIController unchartedScoreUIController = (UnchartedScoreUIController)LuaObject.checkSelf(l);
			Toggle challengeLevelToggle;
			LuaObject.checkType<Toggle>(l, 2, out challengeLevelToggle);
			unchartedScoreUIController.m_luaExportHelper.m_challengeLevelToggle = challengeLevelToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021FA7 RID: 139175 RVA: 0x00B92734 File Offset: 0x00B90934
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_rewardButton(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUIController unchartedScoreUIController = (UnchartedScoreUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, unchartedScoreUIController.m_luaExportHelper.m_rewardButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021FA8 RID: 139176 RVA: 0x00B9278C File Offset: 0x00B9098C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_rewardButton(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUIController unchartedScoreUIController = (UnchartedScoreUIController)LuaObject.checkSelf(l);
			Button rewardButton;
			LuaObject.checkType<Button>(l, 2, out rewardButton);
			unchartedScoreUIController.m_luaExportHelper.m_rewardButton = rewardButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021FA9 RID: 139177 RVA: 0x00B927E8 File Offset: 0x00B909E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_recommendHeroButton(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUIController unchartedScoreUIController = (UnchartedScoreUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, unchartedScoreUIController.m_luaExportHelper.m_recommendHeroButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021FAA RID: 139178 RVA: 0x00B92840 File Offset: 0x00B90A40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_recommendHeroButton(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUIController unchartedScoreUIController = (UnchartedScoreUIController)LuaObject.checkSelf(l);
			Button recommendHeroButton;
			LuaObject.checkType<Button>(l, 2, out recommendHeroButton);
			unchartedScoreUIController.m_luaExportHelper.m_recommendHeroButton = recommendHeroButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021FAB RID: 139179 RVA: 0x00B9289C File Offset: 0x00B90A9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_scoreText(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUIController unchartedScoreUIController = (UnchartedScoreUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, unchartedScoreUIController.m_luaExportHelper.m_scoreText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021FAC RID: 139180 RVA: 0x00B928F4 File Offset: 0x00B90AF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_scoreText(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUIController unchartedScoreUIController = (UnchartedScoreUIController)LuaObject.checkSelf(l);
			Text scoreText;
			LuaObject.checkType<Text>(l, 2, out scoreText);
			unchartedScoreUIController.m_luaExportHelper.m_scoreText = scoreText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021FAD RID: 139181 RVA: 0x00B92950 File Offset: 0x00B90B50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_scoreRewardUIStateController(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUIController unchartedScoreUIController = (UnchartedScoreUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, unchartedScoreUIController.m_luaExportHelper.m_scoreRewardUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021FAE RID: 139182 RVA: 0x00B929A8 File Offset: 0x00B90BA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_scoreRewardUIStateController(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUIController unchartedScoreUIController = (UnchartedScoreUIController)LuaObject.checkSelf(l);
			CommonUIStateController scoreRewardUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out scoreRewardUIStateController);
			unchartedScoreUIController.m_luaExportHelper.m_scoreRewardUIStateController = scoreRewardUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021FAF RID: 139183 RVA: 0x00B92A04 File Offset: 0x00B90C04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_scoreRewardBGButton(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUIController unchartedScoreUIController = (UnchartedScoreUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, unchartedScoreUIController.m_luaExportHelper.m_scoreRewardBGButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021FB0 RID: 139184 RVA: 0x00B92A5C File Offset: 0x00B90C5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_scoreRewardBGButton(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUIController unchartedScoreUIController = (UnchartedScoreUIController)LuaObject.checkSelf(l);
			Button scoreRewardBGButton;
			LuaObject.checkType<Button>(l, 2, out scoreRewardBGButton);
			unchartedScoreUIController.m_luaExportHelper.m_scoreRewardBGButton = scoreRewardBGButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021FB1 RID: 139185 RVA: 0x00B92AB8 File Offset: 0x00B90CB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_scoreRewardScollRect(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUIController unchartedScoreUIController = (UnchartedScoreUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, unchartedScoreUIController.m_luaExportHelper.m_scoreRewardScollRect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021FB2 RID: 139186 RVA: 0x00B92B10 File Offset: 0x00B90D10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_scoreRewardScollRect(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUIController unchartedScoreUIController = (UnchartedScoreUIController)LuaObject.checkSelf(l);
			ScrollRect scoreRewardScollRect;
			LuaObject.checkType<ScrollRect>(l, 2, out scoreRewardScollRect);
			unchartedScoreUIController.m_luaExportHelper.m_scoreRewardScollRect = scoreRewardScollRect;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021FB3 RID: 139187 RVA: 0x00B92B6C File Offset: 0x00B90D6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_scoreRewardScoreNameText(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUIController unchartedScoreUIController = (UnchartedScoreUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, unchartedScoreUIController.m_luaExportHelper.m_scoreRewardScoreNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021FB4 RID: 139188 RVA: 0x00B92BC4 File Offset: 0x00B90DC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_scoreRewardScoreNameText(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUIController unchartedScoreUIController = (UnchartedScoreUIController)LuaObject.checkSelf(l);
			Text scoreRewardScoreNameText;
			LuaObject.checkType<Text>(l, 2, out scoreRewardScoreNameText);
			unchartedScoreUIController.m_luaExportHelper.m_scoreRewardScoreNameText = scoreRewardScoreNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021FB5 RID: 139189 RVA: 0x00B92C20 File Offset: 0x00B90E20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_scoreRewardScoreText(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUIController unchartedScoreUIController = (UnchartedScoreUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, unchartedScoreUIController.m_luaExportHelper.m_scoreRewardScoreText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021FB6 RID: 139190 RVA: 0x00B92C78 File Offset: 0x00B90E78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_scoreRewardScoreText(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUIController unchartedScoreUIController = (UnchartedScoreUIController)LuaObject.checkSelf(l);
			Text scoreRewardScoreText;
			LuaObject.checkType<Text>(l, 2, out scoreRewardScoreText);
			unchartedScoreUIController.m_luaExportHelper.m_scoreRewardScoreText = scoreRewardScoreText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021FB7 RID: 139191 RVA: 0x00B92CD4 File Offset: 0x00B90ED4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_recommendHeroUIStateController(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUIController unchartedScoreUIController = (UnchartedScoreUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, unchartedScoreUIController.m_luaExportHelper.m_recommendHeroUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021FB8 RID: 139192 RVA: 0x00B92D2C File Offset: 0x00B90F2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_recommendHeroUIStateController(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUIController unchartedScoreUIController = (UnchartedScoreUIController)LuaObject.checkSelf(l);
			CommonUIStateController recommendHeroUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out recommendHeroUIStateController);
			unchartedScoreUIController.m_luaExportHelper.m_recommendHeroUIStateController = recommendHeroUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021FB9 RID: 139193 RVA: 0x00B92D88 File Offset: 0x00B90F88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_recommendHeroBGButton(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUIController unchartedScoreUIController = (UnchartedScoreUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, unchartedScoreUIController.m_luaExportHelper.m_recommendHeroBGButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021FBA RID: 139194 RVA: 0x00B92DE0 File Offset: 0x00B90FE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_recommendHeroBGButton(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUIController unchartedScoreUIController = (UnchartedScoreUIController)LuaObject.checkSelf(l);
			Button recommendHeroBGButton;
			LuaObject.checkType<Button>(l, 2, out recommendHeroBGButton);
			unchartedScoreUIController.m_luaExportHelper.m_recommendHeroBGButton = recommendHeroBGButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021FBB RID: 139195 RVA: 0x00B92E3C File Offset: 0x00B9103C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_recommendHeroGroupScrollRect(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUIController unchartedScoreUIController = (UnchartedScoreUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, unchartedScoreUIController.m_luaExportHelper.m_recommendHeroGroupScrollRect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021FBC RID: 139196 RVA: 0x00B92E94 File Offset: 0x00B91094
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_recommendHeroGroupScrollRect(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUIController unchartedScoreUIController = (UnchartedScoreUIController)LuaObject.checkSelf(l);
			ScrollRect recommendHeroGroupScrollRect;
			LuaObject.checkType<ScrollRect>(l, 2, out recommendHeroGroupScrollRect);
			unchartedScoreUIController.m_luaExportHelper.m_recommendHeroGroupScrollRect = recommendHeroGroupScrollRect;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021FBD RID: 139197 RVA: 0x00B92EF0 File Offset: 0x00B910F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_recommendHeroDescText(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUIController unchartedScoreUIController = (UnchartedScoreUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, unchartedScoreUIController.m_luaExportHelper.m_recommendHeroDescText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021FBE RID: 139198 RVA: 0x00B92F48 File Offset: 0x00B91148
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_recommendHeroDescText(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUIController unchartedScoreUIController = (UnchartedScoreUIController)LuaObject.checkSelf(l);
			Text recommendHeroDescText;
			LuaObject.checkType<Text>(l, 2, out recommendHeroDescText);
			unchartedScoreUIController.m_luaExportHelper.m_recommendHeroDescText = recommendHeroDescText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021FBF RID: 139199 RVA: 0x00B92FA4 File Offset: 0x00B911A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_prefabsGameObject(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUIController unchartedScoreUIController = (UnchartedScoreUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, unchartedScoreUIController.m_luaExportHelper.m_prefabsGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021FC0 RID: 139200 RVA: 0x00B92FFC File Offset: 0x00B911FC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_prefabsGameObject(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUIController unchartedScoreUIController = (UnchartedScoreUIController)LuaObject.checkSelf(l);
			GameObject prefabsGameObject;
			LuaObject.checkType<GameObject>(l, 2, out prefabsGameObject);
			unchartedScoreUIController.m_luaExportHelper.m_prefabsGameObject = prefabsGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021FC1 RID: 139201 RVA: 0x00B93058 File Offset: 0x00B91258
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_unchartedScoreLevelListItemPrefab(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUIController unchartedScoreUIController = (UnchartedScoreUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, unchartedScoreUIController.m_luaExportHelper.m_unchartedScoreLevelListItemPrefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021FC2 RID: 139202 RVA: 0x00B930B0 File Offset: 0x00B912B0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_unchartedScoreLevelListItemPrefab(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUIController unchartedScoreUIController = (UnchartedScoreUIController)LuaObject.checkSelf(l);
			GameObject unchartedScoreLevelListItemPrefab;
			LuaObject.checkType<GameObject>(l, 2, out unchartedScoreLevelListItemPrefab);
			unchartedScoreUIController.m_luaExportHelper.m_unchartedScoreLevelListItemPrefab = unchartedScoreLevelListItemPrefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021FC3 RID: 139203 RVA: 0x00B9310C File Offset: 0x00B9130C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_scoreRewardItemPrefab(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUIController unchartedScoreUIController = (UnchartedScoreUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, unchartedScoreUIController.m_luaExportHelper.m_scoreRewardItemPrefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021FC4 RID: 139204 RVA: 0x00B93164 File Offset: 0x00B91364
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_scoreRewardItemPrefab(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUIController unchartedScoreUIController = (UnchartedScoreUIController)LuaObject.checkSelf(l);
			GameObject scoreRewardItemPrefab;
			LuaObject.checkType<GameObject>(l, 2, out scoreRewardItemPrefab);
			unchartedScoreUIController.m_luaExportHelper.m_scoreRewardItemPrefab = scoreRewardItemPrefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021FC5 RID: 139205 RVA: 0x00B931C0 File Offset: 0x00B913C0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_recommendHeroItemPrefab(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUIController unchartedScoreUIController = (UnchartedScoreUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, unchartedScoreUIController.m_luaExportHelper.m_recommendHeroItemPrefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021FC6 RID: 139206 RVA: 0x00B93218 File Offset: 0x00B91418
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_recommendHeroItemPrefab(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUIController unchartedScoreUIController = (UnchartedScoreUIController)LuaObject.checkSelf(l);
			GameObject recommendHeroItemPrefab;
			LuaObject.checkType<GameObject>(l, 2, out recommendHeroItemPrefab);
			unchartedScoreUIController.m_luaExportHelper.m_recommendHeroItemPrefab = recommendHeroItemPrefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021FC7 RID: 139207 RVA: 0x00B93274 File Offset: 0x00B91474
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isIgnoreToggleEvent(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUIController unchartedScoreUIController = (UnchartedScoreUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, unchartedScoreUIController.m_luaExportHelper.m_isIgnoreToggleEvent);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021FC8 RID: 139208 RVA: 0x00B932CC File Offset: 0x00B914CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isIgnoreToggleEvent(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUIController unchartedScoreUIController = (UnchartedScoreUIController)LuaObject.checkSelf(l);
			bool isIgnoreToggleEvent;
			LuaObject.checkType(l, 2, out isIgnoreToggleEvent);
			unchartedScoreUIController.m_luaExportHelper.m_isIgnoreToggleEvent = isIgnoreToggleEvent;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021FC9 RID: 139209 RVA: 0x00B93328 File Offset: 0x00B91528
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_unchartedScoreInfo(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUIController unchartedScoreUIController = (UnchartedScoreUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, unchartedScoreUIController.m_luaExportHelper.m_unchartedScoreInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021FCA RID: 139210 RVA: 0x00B93380 File Offset: 0x00B91580
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_unchartedScoreInfo(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUIController unchartedScoreUIController = (UnchartedScoreUIController)LuaObject.checkSelf(l);
			ConfigDataUnchartedScoreInfo unchartedScoreInfo;
			LuaObject.checkType<ConfigDataUnchartedScoreInfo>(l, 2, out unchartedScoreInfo);
			unchartedScoreUIController.m_luaExportHelper.m_unchartedScoreInfo = unchartedScoreInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021FCB RID: 139211 RVA: 0x00B933DC File Offset: 0x00B915DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_graphic(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUIController unchartedScoreUIController = (UnchartedScoreUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, unchartedScoreUIController.m_luaExportHelper.m_graphic);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021FCC RID: 139212 RVA: 0x00B93434 File Offset: 0x00B91634
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_graphic(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreUIController unchartedScoreUIController = (UnchartedScoreUIController)LuaObject.checkSelf(l);
			UISpineGraphic graphic;
			LuaObject.checkType<UISpineGraphic>(l, 2, out graphic);
			unchartedScoreUIController.m_luaExportHelper.m_graphic = graphic;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021FCD RID: 139213 RVA: 0x00B93490 File Offset: 0x00B91690
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.UnchartedScoreUIController");
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.Open);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.SetBattleType);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.SetScore);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.SetUnchartedScoreInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.SetAllUnchartedScoreLevelListItems);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.SetAllUnchartedChallengeLevelListItems);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.SetDailyRewardCount);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.ShowScoreReward);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.ShowRecommendHero);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.CreateSpineGraphic);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.DestroySpineGraphic);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.Co_ScrollToItem);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.HideScoreReward);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.HideRecommendHero);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.OnReturnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.OnHelpButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.OnTeamButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.OnRewardButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.OnRecommendHeroButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.OnScoreLevelToggleValueChanged);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.OnChallengeLevelToggleValueChanged);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.OnScoreRewardCloseButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.OnRecommendHeroBGButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.UnchartedScoreLevelListItem_OnStartButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache25);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.__callDele_EventOnReturn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache26);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.__clearDele_EventOnReturn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache27);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.__callDele_EventOnShowHelp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache28);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.__clearDele_EventOnShowHelp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache29);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.__callDele_EventOnShowTeam);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache2A);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.__clearDele_EventOnShowTeam);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache2B);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.__callDele_EventOnChangeBattleType);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache2C);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.__clearDele_EventOnChangeBattleType);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache2D);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.__callDele_EventOnStartUnchartedScoreLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache2E);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.__clearDele_EventOnStartUnchartedScoreLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache2F);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.__callDele_EventOnStartUnchartedChallengeLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache30);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.__clearDele_EventOnStartUnchartedChallengeLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache31);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.ScrollToItem_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache32);
		string name = "EventOnReturn";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.set_EventOnReturn);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache33, true);
		string name2 = "EventOnShowHelp";
		LuaCSFunction get2 = null;
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.set_EventOnShowHelp);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache34, true);
		string name3 = "EventOnShowTeam";
		LuaCSFunction get3 = null;
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.set_EventOnShowTeam);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache35, true);
		string name4 = "EventOnChangeBattleType";
		LuaCSFunction get4 = null;
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.set_EventOnChangeBattleType);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache36, true);
		string name5 = "EventOnStartUnchartedScoreLevel";
		LuaCSFunction get5 = null;
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.set_EventOnStartUnchartedScoreLevel);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache37, true);
		string name6 = "EventOnStartUnchartedChallengeLevel";
		LuaCSFunction get6 = null;
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.set_EventOnStartUnchartedChallengeLevel);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache38, true);
		string name7 = "m_uiStateController";
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.get_m_uiStateController);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache39;
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.set_m_uiStateController);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache3A, true);
		string name8 = "m_returnButton";
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.get_m_returnButton);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache3B;
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.set_m_returnButton);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache3C, true);
		string name9 = "m_helpButton";
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.get_m_helpButton);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache3D;
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.set_m_helpButton);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache3E, true);
		string name10 = "m_teamButton";
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.get_m_teamButton);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache3F;
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.set_m_teamButton);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache40, true);
		string name11 = "m_dailyRewardCountText";
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.get_m_dailyRewardCountText);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache41;
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.set_m_dailyRewardCountText);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache42, true);
		string name12 = "m_activityNameText";
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.get_m_activityNameText);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache43;
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.set_m_activityNameText);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache44, true);
		string name13 = "m_activityUIStateController";
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.get_m_activityUIStateController);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache45;
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache46 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache46 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.set_m_activityUIStateController);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache46, true);
		string name14 = "m_charGo";
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache47 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache47 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.get_m_charGo);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache47;
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache48 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache48 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.set_m_charGo);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache48, true);
		string name15 = "m_levelListScrollRect";
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache49 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache49 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.get_m_levelListScrollRect);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache49;
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache4A == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache4A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.set_m_levelListScrollRect);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache4A, true);
		string name16 = "m_scoreLevelToggle";
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache4B == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache4B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.get_m_scoreLevelToggle);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache4B;
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache4C == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache4C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.set_m_scoreLevelToggle);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache4C, true);
		string name17 = "m_challengeLevelToggle";
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache4D == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache4D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.get_m_challengeLevelToggle);
		}
		LuaCSFunction get17 = Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache4D;
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache4E == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache4E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.set_m_challengeLevelToggle);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache4E, true);
		string name18 = "m_rewardButton";
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache4F == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache4F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.get_m_rewardButton);
		}
		LuaCSFunction get18 = Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache4F;
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache50 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache50 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.set_m_rewardButton);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache50, true);
		string name19 = "m_recommendHeroButton";
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache51 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache51 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.get_m_recommendHeroButton);
		}
		LuaCSFunction get19 = Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache51;
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache52 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache52 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.set_m_recommendHeroButton);
		}
		LuaObject.addMember(l, name19, get19, Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache52, true);
		string name20 = "m_scoreText";
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache53 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache53 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.get_m_scoreText);
		}
		LuaCSFunction get20 = Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache53;
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache54 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache54 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.set_m_scoreText);
		}
		LuaObject.addMember(l, name20, get20, Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache54, true);
		string name21 = "m_scoreRewardUIStateController";
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache55 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache55 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.get_m_scoreRewardUIStateController);
		}
		LuaCSFunction get21 = Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache55;
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache56 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache56 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.set_m_scoreRewardUIStateController);
		}
		LuaObject.addMember(l, name21, get21, Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache56, true);
		string name22 = "m_scoreRewardBGButton";
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache57 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache57 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.get_m_scoreRewardBGButton);
		}
		LuaCSFunction get22 = Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache57;
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache58 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache58 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.set_m_scoreRewardBGButton);
		}
		LuaObject.addMember(l, name22, get22, Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache58, true);
		string name23 = "m_scoreRewardScollRect";
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache59 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache59 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.get_m_scoreRewardScollRect);
		}
		LuaCSFunction get23 = Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache59;
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache5A == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache5A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.set_m_scoreRewardScollRect);
		}
		LuaObject.addMember(l, name23, get23, Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache5A, true);
		string name24 = "m_scoreRewardScoreNameText";
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache5B == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache5B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.get_m_scoreRewardScoreNameText);
		}
		LuaCSFunction get24 = Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache5B;
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache5C == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache5C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.set_m_scoreRewardScoreNameText);
		}
		LuaObject.addMember(l, name24, get24, Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache5C, true);
		string name25 = "m_scoreRewardScoreText";
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache5D == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache5D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.get_m_scoreRewardScoreText);
		}
		LuaCSFunction get25 = Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache5D;
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache5E == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache5E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.set_m_scoreRewardScoreText);
		}
		LuaObject.addMember(l, name25, get25, Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache5E, true);
		string name26 = "m_recommendHeroUIStateController";
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache5F == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache5F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.get_m_recommendHeroUIStateController);
		}
		LuaCSFunction get26 = Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache5F;
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache60 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache60 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.set_m_recommendHeroUIStateController);
		}
		LuaObject.addMember(l, name26, get26, Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache60, true);
		string name27 = "m_recommendHeroBGButton";
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache61 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache61 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.get_m_recommendHeroBGButton);
		}
		LuaCSFunction get27 = Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache61;
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache62 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache62 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.set_m_recommendHeroBGButton);
		}
		LuaObject.addMember(l, name27, get27, Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache62, true);
		string name28 = "m_recommendHeroGroupScrollRect";
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache63 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache63 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.get_m_recommendHeroGroupScrollRect);
		}
		LuaCSFunction get28 = Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache63;
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache64 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache64 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.set_m_recommendHeroGroupScrollRect);
		}
		LuaObject.addMember(l, name28, get28, Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache64, true);
		string name29 = "m_recommendHeroDescText";
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache65 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache65 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.get_m_recommendHeroDescText);
		}
		LuaCSFunction get29 = Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache65;
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache66 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache66 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.set_m_recommendHeroDescText);
		}
		LuaObject.addMember(l, name29, get29, Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache66, true);
		string name30 = "m_prefabsGameObject";
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache67 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache67 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.get_m_prefabsGameObject);
		}
		LuaCSFunction get30 = Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache67;
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache68 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache68 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.set_m_prefabsGameObject);
		}
		LuaObject.addMember(l, name30, get30, Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache68, true);
		string name31 = "m_unchartedScoreLevelListItemPrefab";
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache69 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache69 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.get_m_unchartedScoreLevelListItemPrefab);
		}
		LuaCSFunction get31 = Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache69;
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache6A == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache6A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.set_m_unchartedScoreLevelListItemPrefab);
		}
		LuaObject.addMember(l, name31, get31, Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache6A, true);
		string name32 = "m_scoreRewardItemPrefab";
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache6B == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache6B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.get_m_scoreRewardItemPrefab);
		}
		LuaCSFunction get32 = Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache6B;
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache6C == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache6C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.set_m_scoreRewardItemPrefab);
		}
		LuaObject.addMember(l, name32, get32, Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache6C, true);
		string name33 = "m_recommendHeroItemPrefab";
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache6D == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache6D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.get_m_recommendHeroItemPrefab);
		}
		LuaCSFunction get33 = Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache6D;
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache6E == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache6E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.set_m_recommendHeroItemPrefab);
		}
		LuaObject.addMember(l, name33, get33, Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache6E, true);
		string name34 = "m_isIgnoreToggleEvent";
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache6F == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache6F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.get_m_isIgnoreToggleEvent);
		}
		LuaCSFunction get34 = Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache6F;
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache70 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache70 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.set_m_isIgnoreToggleEvent);
		}
		LuaObject.addMember(l, name34, get34, Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache70, true);
		string name35 = "m_unchartedScoreInfo";
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache71 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache71 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.get_m_unchartedScoreInfo);
		}
		LuaCSFunction get35 = Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache71;
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache72 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache72 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.set_m_unchartedScoreInfo);
		}
		LuaObject.addMember(l, name35, get35, Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache72, true);
		string name36 = "m_graphic";
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache73 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache73 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.get_m_graphic);
		}
		LuaCSFunction get36 = Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache73;
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache74 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache74 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.set_m_graphic);
		}
		LuaObject.addMember(l, name36, get36, Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.<>f__mg$cache74, true);
		LuaObject.createTypeMetatable(l, null, typeof(UnchartedScoreUIController), typeof(UIControllerBase));
	}

	// Token: 0x04017DA2 RID: 97698
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04017DA3 RID: 97699
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04017DA4 RID: 97700
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04017DA5 RID: 97701
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04017DA6 RID: 97702
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04017DA7 RID: 97703
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04017DA8 RID: 97704
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04017DA9 RID: 97705
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04017DAA RID: 97706
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04017DAB RID: 97707
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04017DAC RID: 97708
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04017DAD RID: 97709
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04017DAE RID: 97710
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04017DAF RID: 97711
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04017DB0 RID: 97712
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04017DB1 RID: 97713
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04017DB2 RID: 97714
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04017DB3 RID: 97715
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04017DB4 RID: 97716
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04017DB5 RID: 97717
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04017DB6 RID: 97718
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04017DB7 RID: 97719
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04017DB8 RID: 97720
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04017DB9 RID: 97721
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04017DBA RID: 97722
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04017DBB RID: 97723
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04017DBC RID: 97724
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04017DBD RID: 97725
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04017DBE RID: 97726
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04017DBF RID: 97727
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04017DC0 RID: 97728
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04017DC1 RID: 97729
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04017DC2 RID: 97730
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04017DC3 RID: 97731
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04017DC4 RID: 97732
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04017DC5 RID: 97733
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04017DC6 RID: 97734
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04017DC7 RID: 97735
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04017DC8 RID: 97736
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04017DC9 RID: 97737
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04017DCA RID: 97738
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04017DCB RID: 97739
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04017DCC RID: 97740
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04017DCD RID: 97741
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04017DCE RID: 97742
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04017DCF RID: 97743
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04017DD0 RID: 97744
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04017DD1 RID: 97745
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04017DD2 RID: 97746
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04017DD3 RID: 97747
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04017DD4 RID: 97748
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x04017DD5 RID: 97749
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x04017DD6 RID: 97750
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x04017DD7 RID: 97751
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x04017DD8 RID: 97752
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x04017DD9 RID: 97753
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x04017DDA RID: 97754
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x04017DDB RID: 97755
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x04017DDC RID: 97756
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x04017DDD RID: 97757
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x04017DDE RID: 97758
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x04017DDF RID: 97759
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x04017DE0 RID: 97760
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x04017DE1 RID: 97761
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x04017DE2 RID: 97762
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x04017DE3 RID: 97763
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x04017DE4 RID: 97764
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x04017DE5 RID: 97765
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x04017DE6 RID: 97766
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x04017DE7 RID: 97767
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x04017DE8 RID: 97768
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;

	// Token: 0x04017DE9 RID: 97769
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache47;

	// Token: 0x04017DEA RID: 97770
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache48;

	// Token: 0x04017DEB RID: 97771
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache49;

	// Token: 0x04017DEC RID: 97772
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4A;

	// Token: 0x04017DED RID: 97773
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4B;

	// Token: 0x04017DEE RID: 97774
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4C;

	// Token: 0x04017DEF RID: 97775
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4D;

	// Token: 0x04017DF0 RID: 97776
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4E;

	// Token: 0x04017DF1 RID: 97777
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4F;

	// Token: 0x04017DF2 RID: 97778
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache50;

	// Token: 0x04017DF3 RID: 97779
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache51;

	// Token: 0x04017DF4 RID: 97780
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache52;

	// Token: 0x04017DF5 RID: 97781
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache53;

	// Token: 0x04017DF6 RID: 97782
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache54;

	// Token: 0x04017DF7 RID: 97783
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache55;

	// Token: 0x04017DF8 RID: 97784
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache56;

	// Token: 0x04017DF9 RID: 97785
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache57;

	// Token: 0x04017DFA RID: 97786
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache58;

	// Token: 0x04017DFB RID: 97787
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache59;

	// Token: 0x04017DFC RID: 97788
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5A;

	// Token: 0x04017DFD RID: 97789
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5B;

	// Token: 0x04017DFE RID: 97790
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5C;

	// Token: 0x04017DFF RID: 97791
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5D;

	// Token: 0x04017E00 RID: 97792
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5E;

	// Token: 0x04017E01 RID: 97793
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5F;

	// Token: 0x04017E02 RID: 97794
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache60;

	// Token: 0x04017E03 RID: 97795
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache61;

	// Token: 0x04017E04 RID: 97796
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache62;

	// Token: 0x04017E05 RID: 97797
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache63;

	// Token: 0x04017E06 RID: 97798
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache64;

	// Token: 0x04017E07 RID: 97799
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache65;

	// Token: 0x04017E08 RID: 97800
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache66;

	// Token: 0x04017E09 RID: 97801
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache67;

	// Token: 0x04017E0A RID: 97802
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache68;

	// Token: 0x04017E0B RID: 97803
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache69;

	// Token: 0x04017E0C RID: 97804
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6A;

	// Token: 0x04017E0D RID: 97805
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6B;

	// Token: 0x04017E0E RID: 97806
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6C;

	// Token: 0x04017E0F RID: 97807
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6D;

	// Token: 0x04017E10 RID: 97808
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6E;

	// Token: 0x04017E11 RID: 97809
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6F;

	// Token: 0x04017E12 RID: 97810
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache70;

	// Token: 0x04017E13 RID: 97811
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache71;

	// Token: 0x04017E14 RID: 97812
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache72;

	// Token: 0x04017E15 RID: 97813
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache73;

	// Token: 0x04017E16 RID: 97814
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache74;
}
