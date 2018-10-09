using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020013DE RID: 5086
[Preserve]
public class Lua_BlackJack_ProjectL_UI_BusinessCardUITask : LuaObject
{
	// Token: 0x0601C834 RID: 116788 RVA: 0x008DB5DC File Offset: 0x008D97DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			string name;
			LuaObject.checkType(l, 2, out name);
			BusinessCardUITask o = new BusinessCardUITask(name);
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

	// Token: 0x0601C835 RID: 116789 RVA: 0x008DB630 File Offset: 0x008D9830
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartUITask_s(IntPtr l)
	{
		int result;
		try
		{
			UIIntent uiIntent;
			LuaObject.checkType<UIIntent>(l, 1, out uiIntent);
			BusinessCardUITask.StartUITask(uiIntent);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C836 RID: 116790 RVA: 0x008DB67C File Offset: 0x008D987C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUITask businessCardUITask = (BusinessCardUITask)LuaObject.checkSelf(l);
			bool b = businessCardUITask.m_luaExportHelper.IsNeedLoadDynamicRes();
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

	// Token: 0x0601C837 RID: 116791 RVA: 0x008DB6D8 File Offset: 0x008D98D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CollectHeroModelAssets(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUITask businessCardUITask = (BusinessCardUITask)LuaObject.checkSelf(l);
			List<BattleHero> heros;
			LuaObject.checkType<List<BattleHero>>(l, 2, out heros);
			businessCardUITask.m_luaExportHelper.CollectHeroModelAssets(heros);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C838 RID: 116792 RVA: 0x008DB734 File Offset: 0x008D9934
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitAllUIControllers(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUITask businessCardUITask = (BusinessCardUITask)LuaObject.checkSelf(l);
			businessCardUITask.m_luaExportHelper.InitAllUIControllers();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C839 RID: 116793 RVA: 0x008DB788 File Offset: 0x008D9988
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearAllContextAndRes(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUITask businessCardUITask = (BusinessCardUITask)LuaObject.checkSelf(l);
			businessCardUITask.m_luaExportHelper.ClearAllContextAndRes();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C83A RID: 116794 RVA: 0x008DB7DC File Offset: 0x008D99DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnMemoryWarning(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUITask businessCardUITask = (BusinessCardUITask)LuaObject.checkSelf(l);
			businessCardUITask.m_luaExportHelper.OnMemoryWarning();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C83B RID: 116795 RVA: 0x008DB830 File Offset: 0x008D9A30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateView(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUITask businessCardUITask = (BusinessCardUITask)LuaObject.checkSelf(l);
			businessCardUITask.m_luaExportHelper.UpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C83C RID: 116796 RVA: 0x008DB884 File Offset: 0x008D9A84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BusinessCardUIController_OnReturn(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUITask businessCardUITask = (BusinessCardUITask)LuaObject.checkSelf(l);
			bool isRandowShowValueChanged;
			LuaObject.checkType(l, 2, out isRandowShowValueChanged);
			businessCardUITask.m_luaExportHelper.BusinessCardUIController_OnReturn(isRandowShowValueChanged);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C83D RID: 116797 RVA: 0x008DB8E0 File Offset: 0x008D9AE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BusinessCardUIController_OnRandomShowChange(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUITask businessCardUITask = (BusinessCardUITask)LuaObject.checkSelf(l);
			bool isRandowShowValueChanged;
			LuaObject.checkType(l, 2, out isRandowShowValueChanged);
			businessCardUITask.m_luaExportHelper.BusinessCardUIController_OnRandomShowChange(isRandowShowValueChanged);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C83E RID: 116798 RVA: 0x008DB93C File Offset: 0x008D9B3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BusinessCardUIController_OnLike(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUITask businessCardUITask = (BusinessCardUITask)LuaObject.checkSelf(l);
			string userID;
			LuaObject.checkType(l, 2, out userID);
			businessCardUITask.m_luaExportHelper.BusinessCardUIController_OnLike(userID);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C83F RID: 116799 RVA: 0x008DB998 File Offset: 0x008D9B98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BusinessCardUIController_OnUpdateSign(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUITask businessCardUITask = (BusinessCardUITask)LuaObject.checkSelf(l);
			string sign;
			LuaObject.checkType(l, 2, out sign);
			businessCardUITask.m_luaExportHelper.BusinessCardUIController_OnUpdateSign(sign);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C840 RID: 116800 RVA: 0x008DB9F4 File Offset: 0x008D9BF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BusinessCardUIController_OnUpdateHeroSet(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUITask businessCardUITask = (BusinessCardUITask)LuaObject.checkSelf(l);
			List<BusinessCardHeroSet> heroSetList;
			LuaObject.checkType<List<BusinessCardHeroSet>>(l, 2, out heroSetList);
			businessCardUITask.m_luaExportHelper.BusinessCardUIController_OnUpdateHeroSet(heroSetList);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C841 RID: 116801 RVA: 0x008DBA50 File Offset: 0x008D9C50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BusinessCardUIController_OnArDisplayClick(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUITask businessCardUITask = (BusinessCardUITask)LuaObject.checkSelf(l);
			businessCardUITask.m_luaExportHelper.BusinessCardUIController_OnArDisplayClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C842 RID: 116802 RVA: 0x008DBAA4 File Offset: 0x008D9CA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStart(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUITask businessCardUITask = (BusinessCardUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = businessCardUITask.m_luaExportHelper.__callBase_OnStart(intent);
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

	// Token: 0x0601C843 RID: 116803 RVA: 0x008DBB0C File Offset: 0x008D9D0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStop(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUITask businessCardUITask = (BusinessCardUITask)LuaObject.checkSelf(l);
			businessCardUITask.m_luaExportHelper.__callBase_OnStop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C844 RID: 116804 RVA: 0x008DBB60 File Offset: 0x008D9D60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnPause(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUITask businessCardUITask = (BusinessCardUITask)LuaObject.checkSelf(l);
			businessCardUITask.m_luaExportHelper.__callBase_OnPause();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C845 RID: 116805 RVA: 0x008DBBB4 File Offset: 0x008D9DB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnResume(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUITask businessCardUITask = (BusinessCardUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = businessCardUITask.m_luaExportHelper.__callBase_OnResume(intent);
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

	// Token: 0x0601C846 RID: 116806 RVA: 0x008DBC1C File Offset: 0x008D9E1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnNewIntent(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUITask businessCardUITask = (BusinessCardUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = businessCardUITask.m_luaExportHelper.__callBase_OnNewIntent(intent);
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

	// Token: 0x0601C847 RID: 116807 RVA: 0x008DBC84 File Offset: 0x008D9E84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_EnableUIInput(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUITask businessCardUITask = (BusinessCardUITask)LuaObject.checkSelf(l);
			bool isEnable;
			LuaObject.checkType(l, 2, out isEnable);
			bool? isGlobalEnable;
			LuaObject.checkNullable<bool>(l, 3, out isGlobalEnable);
			businessCardUITask.m_luaExportHelper.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C848 RID: 116808 RVA: 0x008DBCF0 File Offset: 0x008D9EF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUITask businessCardUITask = (BusinessCardUITask)LuaObject.checkSelf(l);
			bool b = businessCardUITask.m_luaExportHelper.__callBase_IsNeedLoadDynamicRes();
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

	// Token: 0x0601C849 RID: 116809 RVA: 0x008DBD4C File Offset: 0x008D9F4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAllDynamicResForLoad(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUITask businessCardUITask = (BusinessCardUITask)LuaObject.checkSelf(l);
			List<string> o = businessCardUITask.m_luaExportHelper.__callBase_CollectAllDynamicResForLoad();
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

	// Token: 0x0601C84A RID: 116810 RVA: 0x008DBDA8 File Offset: 0x008D9FA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_RegisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUITask businessCardUITask = (BusinessCardUITask)LuaObject.checkSelf(l);
			businessCardUITask.m_luaExportHelper.__callBase_RegisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C84B RID: 116811 RVA: 0x008DBDFC File Offset: 0x008D9FFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_UnregisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUITask businessCardUITask = (BusinessCardUITask)LuaObject.checkSelf(l);
			businessCardUITask.m_luaExportHelper.__callBase_UnregisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C84C RID: 116812 RVA: 0x008DBE50 File Offset: 0x008DA050
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PostUpdateView(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUITask businessCardUITask = (BusinessCardUITask)LuaObject.checkSelf(l);
			businessCardUITask.m_luaExportHelper.__callBase_PostUpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C84D RID: 116813 RVA: 0x008DBEA4 File Offset: 0x008DA0A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectPreloadResourceList(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUITask businessCardUITask = (BusinessCardUITask)LuaObject.checkSelf(l);
			businessCardUITask.m_luaExportHelper.__callBase_CollectPreloadResourceList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C84E RID: 116814 RVA: 0x008DBEF8 File Offset: 0x008DA0F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearAssetList(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUITask businessCardUITask = (BusinessCardUITask)LuaObject.checkSelf(l);
			businessCardUITask.m_luaExportHelper.__callBase_ClearAssetList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C84F RID: 116815 RVA: 0x008DBF4C File Offset: 0x008DA14C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAsset(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUITask businessCardUITask = (BusinessCardUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			businessCardUITask.m_luaExportHelper.__callBase_CollectAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C850 RID: 116816 RVA: 0x008DBFA8 File Offset: 0x008DA1A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectSpriteAsset(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUITask businessCardUITask = (BusinessCardUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			businessCardUITask.m_luaExportHelper.__callBase_CollectSpriteAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C851 RID: 116817 RVA: 0x008DC004 File Offset: 0x008DA204
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectFxAsset(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUITask businessCardUITask = (BusinessCardUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			businessCardUITask.m_luaExportHelper.__callBase_CollectFxAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C852 RID: 116818 RVA: 0x008DC060 File Offset: 0x008DA260
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_StartLoadCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUITask businessCardUITask = (BusinessCardUITask)LuaObject.checkSelf(l);
			Action onLoadCompleted;
			LuaObject.checkDelegate<Action>(l, 2, out onLoadCompleted);
			businessCardUITask.m_luaExportHelper.__callBase_StartLoadCustomAssets(onLoadCompleted);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C853 RID: 116819 RVA: 0x008DC0BC File Offset: 0x008DA2BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsLoadingCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUITask businessCardUITask = (BusinessCardUITask)LuaObject.checkSelf(l);
			bool b = businessCardUITask.m_luaExportHelper.__callBase_IsLoadingCustomAssets();
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

	// Token: 0x0601C854 RID: 116820 RVA: 0x008DC118 File Offset: 0x008DA318
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsPipeLineRunning(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUITask businessCardUITask = (BusinessCardUITask)LuaObject.checkSelf(l);
			bool b = businessCardUITask.m_luaExportHelper.__callBase_IsPipeLineRunning();
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

	// Token: 0x0601C855 RID: 116821 RVA: 0x008DC174 File Offset: 0x008DA374
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_IsOpeningUI(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUITask businessCardUITask = (BusinessCardUITask)LuaObject.checkSelf(l);
			bool b = businessCardUITask.m_luaExportHelper.__callBase_IsOpeningUI();
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

	// Token: 0x0601C856 RID: 116822 RVA: 0x008DC1D0 File Offset: 0x008DA3D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ReturnPrevUITask(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUITask businessCardUITask = (BusinessCardUITask)LuaObject.checkSelf(l);
			UITaskBase o = businessCardUITask.m_luaExportHelper.__callBase_ReturnPrevUITask();
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

	// Token: 0x0601C857 RID: 116823 RVA: 0x008DC22C File Offset: 0x008DA42C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearUnusedDynamicResourceCache(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUITask businessCardUITask = (BusinessCardUITask)LuaObject.checkSelf(l);
			businessCardUITask.m_luaExportHelper.__callBase_ClearUnusedDynamicResourceCache();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C858 RID: 116824 RVA: 0x008DC280 File Offset: 0x008DA480
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnMemoryWarning(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUITask businessCardUITask = (BusinessCardUITask)LuaObject.checkSelf(l);
			businessCardUITask.m_luaExportHelper.__callBase_OnMemoryWarning();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C859 RID: 116825 RVA: 0x008DC2D4 File Offset: 0x008DA4D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUITask businessCardUITask = (BusinessCardUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardUITask.m_luaExportHelper.m_layerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C85A RID: 116826 RVA: 0x008DC32C File Offset: 0x008DA52C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUITask businessCardUITask = (BusinessCardUITask)LuaObject.checkSelf(l);
			UITaskBase.LayerDesc[] layerDescArray;
			LuaObject.checkArray<UITaskBase.LayerDesc>(l, 2, out layerDescArray);
			businessCardUITask.m_luaExportHelper.m_layerDescArray = layerDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C85B RID: 116827 RVA: 0x008DC388 File Offset: 0x008DA588
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUITask businessCardUITask = (BusinessCardUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardUITask.m_luaExportHelper.m_uiCtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C85C RID: 116828 RVA: 0x008DC3E0 File Offset: 0x008DA5E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUITask businessCardUITask = (BusinessCardUITask)LuaObject.checkSelf(l);
			UITaskBase.UIControllerDesc[] uiCtrlDescArray;
			LuaObject.checkArray<UITaskBase.UIControllerDesc>(l, 2, out uiCtrlDescArray);
			businessCardUITask.m_luaExportHelper.m_uiCtrlDescArray = uiCtrlDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C85D RID: 116829 RVA: 0x008DC43C File Offset: 0x008DA63C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_HeroTeamMaxCount(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, BusinessCardUITask.LuaExportHelper.HeroTeamMaxCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C85E RID: 116830 RVA: 0x008DC484 File Offset: 0x008DA684
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_businessCardUIController(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUITask businessCardUITask = (BusinessCardUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardUITask.m_luaExportHelper.m_businessCardUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C85F RID: 116831 RVA: 0x008DC4DC File Offset: 0x008DA6DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_businessCardUIController(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUITask businessCardUITask = (BusinessCardUITask)LuaObject.checkSelf(l);
			BusinessCardUIController businessCardUIController;
			LuaObject.checkType<BusinessCardUIController>(l, 2, out businessCardUIController);
			businessCardUITask.m_luaExportHelper.m_businessCardUIController = businessCardUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C860 RID: 116832 RVA: 0x008DC538 File Offset: 0x008DA738
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_arHeroListUIController(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUITask businessCardUITask = (BusinessCardUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardUITask.m_luaExportHelper.m_arHeroListUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C861 RID: 116833 RVA: 0x008DC590 File Offset: 0x008DA790
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_arHeroListUIController(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUITask businessCardUITask = (BusinessCardUITask)LuaObject.checkSelf(l);
			ARHeroListUIController arHeroListUIController;
			LuaObject.checkType<ARHeroListUIController>(l, 2, out arHeroListUIController);
			businessCardUITask.m_luaExportHelper.m_arHeroListUIController = arHeroListUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C862 RID: 116834 RVA: 0x008DC5EC File Offset: 0x008DA7EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUITask businessCardUITask = (BusinessCardUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardUITask.m_luaExportHelper.m_playerContext);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C863 RID: 116835 RVA: 0x008DC644 File Offset: 0x008DA844
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUITask businessCardUITask = (BusinessCardUITask)LuaObject.checkSelf(l);
			ProjectLPlayerContext playerContext;
			LuaObject.checkType<ProjectLPlayerContext>(l, 2, out playerContext);
			businessCardUITask.m_luaExportHelper.m_playerContext = playerContext;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C864 RID: 116836 RVA: 0x008DC6A0 File Offset: 0x008DA8A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUITask businessCardUITask = (BusinessCardUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardUITask.m_luaExportHelper.m_configDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C865 RID: 116837 RVA: 0x008DC6F8 File Offset: 0x008DA8F8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUITask businessCardUITask = (BusinessCardUITask)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			businessCardUITask.m_luaExportHelper.m_configDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C866 RID: 116838 RVA: 0x008DC754 File Offset: 0x008DA954
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LayerDescArray(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUITask businessCardUITask = (BusinessCardUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardUITask.m_luaExportHelper.LayerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C867 RID: 116839 RVA: 0x008DC7AC File Offset: 0x008DA9AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_UICtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardUITask businessCardUITask = (BusinessCardUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardUITask.m_luaExportHelper.UICtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C868 RID: 116840 RVA: 0x008DC804 File Offset: 0x008DAA04
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.BusinessCardUITask");
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUITask.StartUITask_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUITask.IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUITask.CollectHeroModelAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUITask.InitAllUIControllers);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUITask.ClearAllContextAndRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUITask.OnMemoryWarning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUITask.UpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUITask.BusinessCardUIController_OnReturn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUITask.BusinessCardUIController_OnRandomShowChange);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUITask.BusinessCardUIController_OnLike);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUITask.BusinessCardUIController_OnUpdateSign);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUITask.BusinessCardUIController_OnUpdateHeroSet);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUITask.BusinessCardUIController_OnArDisplayClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUITask.__callBase_OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUITask.__callBase_OnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUITask.__callBase_OnPause);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUITask.__callBase_OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUITask.__callBase_OnNewIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUITask.__callBase_EnableUIInput);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUITask.__callBase_IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUITask.__callBase_CollectAllDynamicResForLoad);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUITask.__callBase_RegisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUITask.__callBase_UnregisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUITask.__callBase_PostUpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUITask.__callBase_CollectPreloadResourceList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUITask.__callBase_ClearAssetList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUITask.__callBase_CollectAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUITask.__callBase_CollectSpriteAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUITask.__callBase_CollectFxAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUITask.__callBase_StartLoadCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUITask.__callBase_IsLoadingCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUITask.__callBase_IsPipeLineRunning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUITask.__callBase_IsOpeningUI);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUITask.__callBase_ReturnPrevUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUITask.__callBase_ClearUnusedDynamicResourceCache);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUITask.__callBase_OnMemoryWarning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cache23);
		string name = "m_layerDescArray";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUITask.get_m_layerDescArray);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cache24;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUITask.set_m_layerDescArray);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cache25, true);
		string name2 = "m_uiCtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUITask.get_m_uiCtrlDescArray);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cache26;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUITask.set_m_uiCtrlDescArray);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cache27, true);
		string name3 = "HeroTeamMaxCount";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUITask.get_HeroTeamMaxCount);
		}
		LuaObject.addMember(l, name3, Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cache28, null, false);
		string name4 = "m_businessCardUIController";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUITask.get_m_businessCardUIController);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cache29;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUITask.set_m_businessCardUIController);
		}
		LuaObject.addMember(l, name4, get3, Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cache2A, true);
		string name5 = "m_arHeroListUIController";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUITask.get_m_arHeroListUIController);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cache2B;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUITask.set_m_arHeroListUIController);
		}
		LuaObject.addMember(l, name5, get4, Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cache2C, true);
		string name6 = "m_playerContext";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUITask.get_m_playerContext);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cache2D;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUITask.set_m_playerContext);
		}
		LuaObject.addMember(l, name6, get5, Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cache2E, true);
		string name7 = "m_configDataLoader";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUITask.get_m_configDataLoader);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cache2F;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUITask.set_m_configDataLoader);
		}
		LuaObject.addMember(l, name7, get6, Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cache30, true);
		string name8 = "LayerDescArray";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUITask.get_LayerDescArray);
		}
		LuaObject.addMember(l, name8, Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cache31, null, true);
		string name9 = "UICtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUITask.get_UICtrlDescArray);
		}
		LuaObject.addMember(l, name9, Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cache32, null, true);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardUITask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_BusinessCardUITask.<>f__mg$cache33, typeof(BusinessCardUITask), typeof(UITask));
	}

	// Token: 0x04012A5A RID: 76378
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04012A5B RID: 76379
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04012A5C RID: 76380
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04012A5D RID: 76381
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04012A5E RID: 76382
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04012A5F RID: 76383
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04012A60 RID: 76384
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04012A61 RID: 76385
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04012A62 RID: 76386
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04012A63 RID: 76387
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04012A64 RID: 76388
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04012A65 RID: 76389
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04012A66 RID: 76390
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04012A67 RID: 76391
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04012A68 RID: 76392
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04012A69 RID: 76393
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04012A6A RID: 76394
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04012A6B RID: 76395
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04012A6C RID: 76396
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04012A6D RID: 76397
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04012A6E RID: 76398
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04012A6F RID: 76399
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04012A70 RID: 76400
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04012A71 RID: 76401
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04012A72 RID: 76402
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04012A73 RID: 76403
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04012A74 RID: 76404
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04012A75 RID: 76405
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04012A76 RID: 76406
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04012A77 RID: 76407
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04012A78 RID: 76408
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04012A79 RID: 76409
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04012A7A RID: 76410
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04012A7B RID: 76411
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04012A7C RID: 76412
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04012A7D RID: 76413
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04012A7E RID: 76414
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04012A7F RID: 76415
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04012A80 RID: 76416
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04012A81 RID: 76417
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04012A82 RID: 76418
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04012A83 RID: 76419
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04012A84 RID: 76420
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04012A85 RID: 76421
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04012A86 RID: 76422
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04012A87 RID: 76423
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04012A88 RID: 76424
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04012A89 RID: 76425
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04012A8A RID: 76426
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04012A8B RID: 76427
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04012A8C RID: 76428
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x04012A8D RID: 76429
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;
}
