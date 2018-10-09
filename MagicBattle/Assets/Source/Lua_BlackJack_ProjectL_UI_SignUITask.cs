using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200157A RID: 5498
[Preserve]
public class Lua_BlackJack_ProjectL_UI_SignUITask : LuaObject
{
	// Token: 0x06021102 RID: 135426 RVA: 0x00B1E720 File Offset: 0x00B1C920
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			string name;
			LuaObject.checkType(l, 2, out name);
			SignUITask o = new SignUITask(name);
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

	// Token: 0x06021103 RID: 135427 RVA: 0x00B1E774 File Offset: 0x00B1C974
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			SignUITask signUITask = (SignUITask)LuaObject.checkSelf(l);
			bool b = signUITask.m_luaExportHelper.IsNeedLoadDynamicRes();
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

	// Token: 0x06021104 RID: 135428 RVA: 0x00B1E7D0 File Offset: 0x00B1C9D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitAllUIControllers(IntPtr l)
	{
		int result;
		try
		{
			SignUITask signUITask = (SignUITask)LuaObject.checkSelf(l);
			signUITask.m_luaExportHelper.InitAllUIControllers();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021105 RID: 135429 RVA: 0x00B1E824 File Offset: 0x00B1CA24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearAllContextAndRes(IntPtr l)
	{
		int result;
		try
		{
			SignUITask signUITask = (SignUITask)LuaObject.checkSelf(l);
			signUITask.m_luaExportHelper.ClearAllContextAndRes();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021106 RID: 135430 RVA: 0x00B1E878 File Offset: 0x00B1CA78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateView(IntPtr l)
	{
		int result;
		try
		{
			SignUITask signUITask = (SignUITask)LuaObject.checkSelf(l);
			signUITask.m_luaExportHelper.UpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021107 RID: 135431 RVA: 0x00B1E8CC File Offset: 0x00B1CACC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnTodaySignItemClick(IntPtr l)
	{
		int result;
		try
		{
			SignUITask signUITask = (SignUITask)LuaObject.checkSelf(l);
			signUITask.m_luaExportHelper.OnTodaySignItemClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021108 RID: 135432 RVA: 0x00B1E920 File Offset: 0x00B1CB20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnTodaySignBoxClick(IntPtr l)
	{
		int result;
		try
		{
			SignUITask signUITask = (SignUITask)LuaObject.checkSelf(l);
			GoodsType type;
			LuaObject.checkEnum<GoodsType>(l, 2, out type);
			int id;
			LuaObject.checkType(l, 3, out id);
			int count;
			LuaObject.checkType(l, 4, out count);
			signUITask.m_luaExportHelper.OnTodaySignBoxClick(type, id, count);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021109 RID: 135433 RVA: 0x00B1E998 File Offset: 0x00B1CB98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HandleBoxOpenNetTask(IntPtr l)
	{
		int result;
		try
		{
			SignUITask signUITask = (SignUITask)LuaObject.checkSelf(l);
			GoodsType type;
			LuaObject.checkEnum<GoodsType>(l, 2, out type);
			int id;
			LuaObject.checkType(l, 3, out id);
			int count;
			LuaObject.checkType(l, 4, out count);
			signUITask.m_luaExportHelper.HandleBoxOpenNetTask(type, id, count);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602110A RID: 135434 RVA: 0x00B1EA10 File Offset: 0x00B1CC10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnSignCloseButtonClick(IntPtr l)
	{
		int result;
		try
		{
			SignUITask signUITask = (SignUITask)LuaObject.checkSelf(l);
			signUITask.m_luaExportHelper.OnSignCloseButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602110B RID: 135435 RVA: 0x00B1EA64 File Offset: 0x00B1CC64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStart(IntPtr l)
	{
		int result;
		try
		{
			SignUITask signUITask = (SignUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = signUITask.m_luaExportHelper.__callBase_OnStart(intent);
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

	// Token: 0x0602110C RID: 135436 RVA: 0x00B1EACC File Offset: 0x00B1CCCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStop(IntPtr l)
	{
		int result;
		try
		{
			SignUITask signUITask = (SignUITask)LuaObject.checkSelf(l);
			signUITask.m_luaExportHelper.__callBase_OnStop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602110D RID: 135437 RVA: 0x00B1EB20 File Offset: 0x00B1CD20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnPause(IntPtr l)
	{
		int result;
		try
		{
			SignUITask signUITask = (SignUITask)LuaObject.checkSelf(l);
			signUITask.m_luaExportHelper.__callBase_OnPause();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602110E RID: 135438 RVA: 0x00B1EB74 File Offset: 0x00B1CD74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnResume(IntPtr l)
	{
		int result;
		try
		{
			SignUITask signUITask = (SignUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = signUITask.m_luaExportHelper.__callBase_OnResume(intent);
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

	// Token: 0x0602110F RID: 135439 RVA: 0x00B1EBDC File Offset: 0x00B1CDDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnNewIntent(IntPtr l)
	{
		int result;
		try
		{
			SignUITask signUITask = (SignUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = signUITask.m_luaExportHelper.__callBase_OnNewIntent(intent);
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

	// Token: 0x06021110 RID: 135440 RVA: 0x00B1EC44 File Offset: 0x00B1CE44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_EnableUIInput(IntPtr l)
	{
		int result;
		try
		{
			SignUITask signUITask = (SignUITask)LuaObject.checkSelf(l);
			bool isEnable;
			LuaObject.checkType(l, 2, out isEnable);
			bool? isGlobalEnable;
			LuaObject.checkNullable<bool>(l, 3, out isGlobalEnable);
			signUITask.m_luaExportHelper.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021111 RID: 135441 RVA: 0x00B1ECB0 File Offset: 0x00B1CEB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			SignUITask signUITask = (SignUITask)LuaObject.checkSelf(l);
			bool b = signUITask.m_luaExportHelper.__callBase_IsNeedLoadDynamicRes();
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

	// Token: 0x06021112 RID: 135442 RVA: 0x00B1ED0C File Offset: 0x00B1CF0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAllDynamicResForLoad(IntPtr l)
	{
		int result;
		try
		{
			SignUITask signUITask = (SignUITask)LuaObject.checkSelf(l);
			List<string> o = signUITask.m_luaExportHelper.__callBase_CollectAllDynamicResForLoad();
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

	// Token: 0x06021113 RID: 135443 RVA: 0x00B1ED68 File Offset: 0x00B1CF68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_RegisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			SignUITask signUITask = (SignUITask)LuaObject.checkSelf(l);
			signUITask.m_luaExportHelper.__callBase_RegisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021114 RID: 135444 RVA: 0x00B1EDBC File Offset: 0x00B1CFBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_UnregisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			SignUITask signUITask = (SignUITask)LuaObject.checkSelf(l);
			signUITask.m_luaExportHelper.__callBase_UnregisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021115 RID: 135445 RVA: 0x00B1EE10 File Offset: 0x00B1D010
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PostUpdateView(IntPtr l)
	{
		int result;
		try
		{
			SignUITask signUITask = (SignUITask)LuaObject.checkSelf(l);
			signUITask.m_luaExportHelper.__callBase_PostUpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021116 RID: 135446 RVA: 0x00B1EE64 File Offset: 0x00B1D064
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectPreloadResourceList(IntPtr l)
	{
		int result;
		try
		{
			SignUITask signUITask = (SignUITask)LuaObject.checkSelf(l);
			signUITask.m_luaExportHelper.__callBase_CollectPreloadResourceList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021117 RID: 135447 RVA: 0x00B1EEB8 File Offset: 0x00B1D0B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearAssetList(IntPtr l)
	{
		int result;
		try
		{
			SignUITask signUITask = (SignUITask)LuaObject.checkSelf(l);
			signUITask.m_luaExportHelper.__callBase_ClearAssetList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021118 RID: 135448 RVA: 0x00B1EF0C File Offset: 0x00B1D10C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAsset(IntPtr l)
	{
		int result;
		try
		{
			SignUITask signUITask = (SignUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			signUITask.m_luaExportHelper.__callBase_CollectAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021119 RID: 135449 RVA: 0x00B1EF68 File Offset: 0x00B1D168
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectSpriteAsset(IntPtr l)
	{
		int result;
		try
		{
			SignUITask signUITask = (SignUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			signUITask.m_luaExportHelper.__callBase_CollectSpriteAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602111A RID: 135450 RVA: 0x00B1EFC4 File Offset: 0x00B1D1C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectFxAsset(IntPtr l)
	{
		int result;
		try
		{
			SignUITask signUITask = (SignUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			signUITask.m_luaExportHelper.__callBase_CollectFxAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602111B RID: 135451 RVA: 0x00B1F020 File Offset: 0x00B1D220
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_StartLoadCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			SignUITask signUITask = (SignUITask)LuaObject.checkSelf(l);
			Action onLoadCompleted;
			LuaObject.checkDelegate<Action>(l, 2, out onLoadCompleted);
			signUITask.m_luaExportHelper.__callBase_StartLoadCustomAssets(onLoadCompleted);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602111C RID: 135452 RVA: 0x00B1F07C File Offset: 0x00B1D27C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsLoadingCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			SignUITask signUITask = (SignUITask)LuaObject.checkSelf(l);
			bool b = signUITask.m_luaExportHelper.__callBase_IsLoadingCustomAssets();
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

	// Token: 0x0602111D RID: 135453 RVA: 0x00B1F0D8 File Offset: 0x00B1D2D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsPipeLineRunning(IntPtr l)
	{
		int result;
		try
		{
			SignUITask signUITask = (SignUITask)LuaObject.checkSelf(l);
			bool b = signUITask.m_luaExportHelper.__callBase_IsPipeLineRunning();
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

	// Token: 0x0602111E RID: 135454 RVA: 0x00B1F134 File Offset: 0x00B1D334
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsOpeningUI(IntPtr l)
	{
		int result;
		try
		{
			SignUITask signUITask = (SignUITask)LuaObject.checkSelf(l);
			bool b = signUITask.m_luaExportHelper.__callBase_IsOpeningUI();
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

	// Token: 0x0602111F RID: 135455 RVA: 0x00B1F190 File Offset: 0x00B1D390
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ReturnPrevUITask(IntPtr l)
	{
		int result;
		try
		{
			SignUITask signUITask = (SignUITask)LuaObject.checkSelf(l);
			UITaskBase o = signUITask.m_luaExportHelper.__callBase_ReturnPrevUITask();
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

	// Token: 0x06021120 RID: 135456 RVA: 0x00B1F1EC File Offset: 0x00B1D3EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearUnusedDynamicResourceCache(IntPtr l)
	{
		int result;
		try
		{
			SignUITask signUITask = (SignUITask)LuaObject.checkSelf(l);
			signUITask.m_luaExportHelper.__callBase_ClearUnusedDynamicResourceCache();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021121 RID: 135457 RVA: 0x00B1F240 File Offset: 0x00B1D440
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnMemoryWarning(IntPtr l)
	{
		int result;
		try
		{
			SignUITask signUITask = (SignUITask)LuaObject.checkSelf(l);
			signUITask.m_luaExportHelper.__callBase_OnMemoryWarning();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021122 RID: 135458 RVA: 0x00B1F294 File Offset: 0x00B1D494
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			SignUITask signUITask = (SignUITask)LuaObject.checkSelf(l);
			signUITask.m_luaExportHelper.__callDele_EventOnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021123 RID: 135459 RVA: 0x00B1F2E8 File Offset: 0x00B1D4E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			SignUITask signUITask = (SignUITask)LuaObject.checkSelf(l);
			signUITask.m_luaExportHelper.__clearDele_EventOnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021124 RID: 135460 RVA: 0x00B1F33C File Offset: 0x00B1D53C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			SignUITask signUITask = (SignUITask)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					signUITask.EventOnClose += value;
				}
				else if (num == 2)
				{
					signUITask.EventOnClose -= value;
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

	// Token: 0x06021125 RID: 135461 RVA: 0x00B1F3BC File Offset: 0x00B1D5BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			SignUITask signUITask = (SignUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, signUITask.m_luaExportHelper.m_layerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021126 RID: 135462 RVA: 0x00B1F414 File Offset: 0x00B1D614
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			SignUITask signUITask = (SignUITask)LuaObject.checkSelf(l);
			UITaskBase.LayerDesc[] layerDescArray;
			LuaObject.checkArray<UITaskBase.LayerDesc>(l, 2, out layerDescArray);
			signUITask.m_luaExportHelper.m_layerDescArray = layerDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021127 RID: 135463 RVA: 0x00B1F470 File Offset: 0x00B1D670
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			SignUITask signUITask = (SignUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, signUITask.m_luaExportHelper.m_uiCtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021128 RID: 135464 RVA: 0x00B1F4C8 File Offset: 0x00B1D6C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			SignUITask signUITask = (SignUITask)LuaObject.checkSelf(l);
			UITaskBase.UIControllerDesc[] uiCtrlDescArray;
			LuaObject.checkArray<UITaskBase.UIControllerDesc>(l, 2, out uiCtrlDescArray);
			signUITask.m_luaExportHelper.m_uiCtrlDescArray = uiCtrlDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021129 RID: 135465 RVA: 0x00B1F524 File Offset: 0x00B1D724
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_signRewardListUIController(IntPtr l)
	{
		int result;
		try
		{
			SignUITask signUITask = (SignUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, signUITask.m_luaExportHelper.m_signRewardListUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602112A RID: 135466 RVA: 0x00B1F57C File Offset: 0x00B1D77C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_signRewardListUIController(IntPtr l)
	{
		int result;
		try
		{
			SignUITask signUITask = (SignUITask)LuaObject.checkSelf(l);
			SignRewardListUIController signRewardListUIController;
			LuaObject.checkType<SignRewardListUIController>(l, 2, out signRewardListUIController);
			signUITask.m_luaExportHelper.m_signRewardListUIController = signRewardListUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602112B RID: 135467 RVA: 0x00B1F5D8 File Offset: 0x00B1D7D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isAutoSign(IntPtr l)
	{
		int result;
		try
		{
			SignUITask signUITask = (SignUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, signUITask.m_luaExportHelper.m_isAutoSign);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602112C RID: 135468 RVA: 0x00B1F630 File Offset: 0x00B1D830
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isAutoSign(IntPtr l)
	{
		int result;
		try
		{
			SignUITask signUITask = (SignUITask)LuaObject.checkSelf(l);
			bool isAutoSign;
			LuaObject.checkType(l, 2, out isAutoSign);
			signUITask.m_luaExportHelper.m_isAutoSign = isAutoSign;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602112D RID: 135469 RVA: 0x00B1F68C File Offset: 0x00B1D88C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			SignUITask signUITask = (SignUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, signUITask.m_luaExportHelper.m_playerContext);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602112E RID: 135470 RVA: 0x00B1F6E4 File Offset: 0x00B1D8E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			SignUITask signUITask = (SignUITask)LuaObject.checkSelf(l);
			ProjectLPlayerContext playerContext;
			LuaObject.checkType<ProjectLPlayerContext>(l, 2, out playerContext);
			signUITask.m_luaExportHelper.m_playerContext = playerContext;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602112F RID: 135471 RVA: 0x00B1F740 File Offset: 0x00B1D940
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LayerDescArray(IntPtr l)
	{
		int result;
		try
		{
			SignUITask signUITask = (SignUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, signUITask.m_luaExportHelper.LayerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021130 RID: 135472 RVA: 0x00B1F798 File Offset: 0x00B1D998
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_UICtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			SignUITask signUITask = (SignUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, signUITask.m_luaExportHelper.UICtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021131 RID: 135473 RVA: 0x00B1F7F0 File Offset: 0x00B1D9F0
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.SignUITask");
		if (Lua_BlackJack_ProjectL_UI_SignUITask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_SignUITask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignUITask.IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SignUITask.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_SignUITask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_SignUITask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignUITask.InitAllUIControllers);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SignUITask.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_SignUITask.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_SignUITask.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignUITask.ClearAllContextAndRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SignUITask.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_SignUITask.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_SignUITask.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignUITask.UpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SignUITask.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_SignUITask.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_SignUITask.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignUITask.OnTodaySignItemClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SignUITask.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_SignUITask.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_SignUITask.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignUITask.OnTodaySignBoxClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SignUITask.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_SignUITask.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_SignUITask.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignUITask.HandleBoxOpenNetTask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SignUITask.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_SignUITask.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_SignUITask.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignUITask.OnSignCloseButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SignUITask.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_SignUITask.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_SignUITask.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignUITask.__callBase_OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SignUITask.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_SignUITask.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_SignUITask.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignUITask.__callBase_OnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SignUITask.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_SignUITask.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_SignUITask.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignUITask.__callBase_OnPause);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SignUITask.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_SignUITask.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_SignUITask.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignUITask.__callBase_OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SignUITask.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_SignUITask.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_SignUITask.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignUITask.__callBase_OnNewIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SignUITask.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_SignUITask.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_SignUITask.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignUITask.__callBase_EnableUIInput);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SignUITask.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_SignUITask.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_SignUITask.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignUITask.__callBase_IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SignUITask.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_SignUITask.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_SignUITask.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignUITask.__callBase_CollectAllDynamicResForLoad);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SignUITask.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_SignUITask.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_SignUITask.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignUITask.__callBase_RegisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SignUITask.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_SignUITask.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_SignUITask.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignUITask.__callBase_UnregisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SignUITask.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_SignUITask.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_SignUITask.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignUITask.__callBase_PostUpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SignUITask.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_SignUITask.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_SignUITask.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignUITask.__callBase_CollectPreloadResourceList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SignUITask.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_SignUITask.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_SignUITask.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignUITask.__callBase_ClearAssetList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SignUITask.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_SignUITask.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_SignUITask.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignUITask.__callBase_CollectAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SignUITask.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_SignUITask.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_SignUITask.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignUITask.__callBase_CollectSpriteAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SignUITask.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_SignUITask.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_SignUITask.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignUITask.__callBase_CollectFxAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SignUITask.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_SignUITask.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_SignUITask.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignUITask.__callBase_StartLoadCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SignUITask.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_SignUITask.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_SignUITask.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignUITask.__callBase_IsLoadingCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SignUITask.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_SignUITask.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_SignUITask.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignUITask.__callBase_IsPipeLineRunning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SignUITask.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_SignUITask.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_SignUITask.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignUITask.__callBase_IsOpeningUI);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SignUITask.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_SignUITask.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_SignUITask.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignUITask.__callBase_ReturnPrevUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SignUITask.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_SignUITask.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_SignUITask.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignUITask.__callBase_ClearUnusedDynamicResourceCache);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SignUITask.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_SignUITask.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_SignUITask.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignUITask.__callBase_OnMemoryWarning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SignUITask.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_SignUITask.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_SignUITask.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignUITask.__callDele_EventOnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SignUITask.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_SignUITask.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_SignUITask.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignUITask.__clearDele_EventOnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SignUITask.<>f__mg$cache20);
		string name = "EventOnClose";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_SignUITask.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_SignUITask.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignUITask.set_EventOnClose);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_SignUITask.<>f__mg$cache21, true);
		string name2 = "m_layerDescArray";
		if (Lua_BlackJack_ProjectL_UI_SignUITask.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_SignUITask.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignUITask.get_m_layerDescArray);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_SignUITask.<>f__mg$cache22;
		if (Lua_BlackJack_ProjectL_UI_SignUITask.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_SignUITask.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignUITask.set_m_layerDescArray);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_SignUITask.<>f__mg$cache23, true);
		string name3 = "m_uiCtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_SignUITask.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_SignUITask.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignUITask.get_m_uiCtrlDescArray);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_SignUITask.<>f__mg$cache24;
		if (Lua_BlackJack_ProjectL_UI_SignUITask.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_SignUITask.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignUITask.set_m_uiCtrlDescArray);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_SignUITask.<>f__mg$cache25, true);
		string name4 = "m_signRewardListUIController";
		if (Lua_BlackJack_ProjectL_UI_SignUITask.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_SignUITask.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignUITask.get_m_signRewardListUIController);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_SignUITask.<>f__mg$cache26;
		if (Lua_BlackJack_ProjectL_UI_SignUITask.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_SignUITask.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignUITask.set_m_signRewardListUIController);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_SignUITask.<>f__mg$cache27, true);
		string name5 = "m_isAutoSign";
		if (Lua_BlackJack_ProjectL_UI_SignUITask.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_SignUITask.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignUITask.get_m_isAutoSign);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_SignUITask.<>f__mg$cache28;
		if (Lua_BlackJack_ProjectL_UI_SignUITask.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_SignUITask.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignUITask.set_m_isAutoSign);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_SignUITask.<>f__mg$cache29, true);
		string name6 = "m_playerContext";
		if (Lua_BlackJack_ProjectL_UI_SignUITask.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_SignUITask.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignUITask.get_m_playerContext);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_SignUITask.<>f__mg$cache2A;
		if (Lua_BlackJack_ProjectL_UI_SignUITask.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_SignUITask.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignUITask.set_m_playerContext);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_SignUITask.<>f__mg$cache2B, true);
		string name7 = "LayerDescArray";
		if (Lua_BlackJack_ProjectL_UI_SignUITask.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_SignUITask.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignUITask.get_LayerDescArray);
		}
		LuaObject.addMember(l, name7, Lua_BlackJack_ProjectL_UI_SignUITask.<>f__mg$cache2C, null, true);
		string name8 = "UICtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_SignUITask.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_SignUITask.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignUITask.get_UICtrlDescArray);
		}
		LuaObject.addMember(l, name8, Lua_BlackJack_ProjectL_UI_SignUITask.<>f__mg$cache2D, null, true);
		if (Lua_BlackJack_ProjectL_UI_SignUITask.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_SignUITask.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SignUITask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_SignUITask.<>f__mg$cache2E, typeof(SignUITask), typeof(UITask));
	}

	// Token: 0x04016FF0 RID: 94192
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04016FF1 RID: 94193
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04016FF2 RID: 94194
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04016FF3 RID: 94195
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04016FF4 RID: 94196
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04016FF5 RID: 94197
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04016FF6 RID: 94198
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04016FF7 RID: 94199
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04016FF8 RID: 94200
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04016FF9 RID: 94201
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04016FFA RID: 94202
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04016FFB RID: 94203
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04016FFC RID: 94204
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04016FFD RID: 94205
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04016FFE RID: 94206
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04016FFF RID: 94207
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04017000 RID: 94208
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04017001 RID: 94209
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04017002 RID: 94210
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04017003 RID: 94211
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04017004 RID: 94212
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04017005 RID: 94213
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04017006 RID: 94214
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04017007 RID: 94215
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04017008 RID: 94216
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04017009 RID: 94217
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0401700A RID: 94218
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0401700B RID: 94219
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0401700C RID: 94220
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0401700D RID: 94221
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0401700E RID: 94222
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0401700F RID: 94223
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04017010 RID: 94224
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04017011 RID: 94225
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04017012 RID: 94226
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04017013 RID: 94227
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04017014 RID: 94228
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04017015 RID: 94229
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04017016 RID: 94230
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04017017 RID: 94231
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04017018 RID: 94232
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04017019 RID: 94233
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x0401701A RID: 94234
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x0401701B RID: 94235
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x0401701C RID: 94236
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x0401701D RID: 94237
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x0401701E RID: 94238
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;
}
