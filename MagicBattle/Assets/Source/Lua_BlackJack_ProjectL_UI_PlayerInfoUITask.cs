using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200152C RID: 5420
[Preserve]
public class Lua_BlackJack_ProjectL_UI_PlayerInfoUITask : LuaObject
{
	// Token: 0x0602038D RID: 131981 RVA: 0x00AB3060 File Offset: 0x00AB1260
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			string name;
			LuaObject.checkType(l, 2, out name);
			PlayerInfoUITask o = new PlayerInfoUITask(name);
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

	// Token: 0x0602038E RID: 131982 RVA: 0x00AB30B4 File Offset: 0x00AB12B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUITask playerInfoUITask = (PlayerInfoUITask)LuaObject.checkSelf(l);
			bool b = playerInfoUITask.m_luaExportHelper.IsNeedLoadDynamicRes();
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

	// Token: 0x0602038F RID: 131983 RVA: 0x00AB3110 File Offset: 0x00AB1310
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitAllUIControllers(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUITask playerInfoUITask = (PlayerInfoUITask)LuaObject.checkSelf(l);
			playerInfoUITask.m_luaExportHelper.InitAllUIControllers();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020390 RID: 131984 RVA: 0x00AB3164 File Offset: 0x00AB1364
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearAllContextAndRes(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUITask playerInfoUITask = (PlayerInfoUITask)LuaObject.checkSelf(l);
			playerInfoUITask.m_luaExportHelper.ClearAllContextAndRes();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020391 RID: 131985 RVA: 0x00AB31B8 File Offset: 0x00AB13B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnStart(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUITask playerInfoUITask = (PlayerInfoUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = playerInfoUITask.m_luaExportHelper.OnStart(intent);
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

	// Token: 0x06020392 RID: 131986 RVA: 0x00AB3220 File Offset: 0x00AB1420
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnStop(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUITask playerInfoUITask = (PlayerInfoUITask)LuaObject.checkSelf(l);
			playerInfoUITask.m_luaExportHelper.OnStop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020393 RID: 131987 RVA: 0x00AB3274 File Offset: 0x00AB1474
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateView(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUITask playerInfoUITask = (PlayerInfoUITask)LuaObject.checkSelf(l);
			playerInfoUITask.m_luaExportHelper.UpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020394 RID: 131988 RVA: 0x00AB32C8 File Offset: 0x00AB14C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayerInfoUIController_OnClose(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUITask playerInfoUITask = (PlayerInfoUITask)LuaObject.checkSelf(l);
			playerInfoUITask.m_luaExportHelper.PlayerInfoUIController_OnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020395 RID: 131989 RVA: 0x00AB331C File Offset: 0x00AB151C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayerInfoUIController_OnShowChangeIconPanel(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUITask playerInfoUITask = (PlayerInfoUITask)LuaObject.checkSelf(l);
			playerInfoUITask.m_luaExportHelper.PlayerInfoUIController_OnShowChangeIconPanel();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020396 RID: 131990 RVA: 0x00AB3370 File Offset: 0x00AB1570
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayerInfoUIController_OnChangeName(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUITask playerInfoUITask = (PlayerInfoUITask)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			playerInfoUITask.m_luaExportHelper.PlayerInfoUIController_OnChangeName(name);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020397 RID: 131991 RVA: 0x00AB33CC File Offset: 0x00AB15CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayerInfoUIController_OnWatchMyBusinessCard(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUITask playerInfoUITask = (PlayerInfoUITask)LuaObject.checkSelf(l);
			playerInfoUITask.m_luaExportHelper.PlayerInfoUIController_OnWatchMyBusinessCard();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020398 RID: 131992 RVA: 0x00AB3420 File Offset: 0x00AB1620
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayerInfoUIController_OnChangeHeadPortraitAndHeadFrame(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUITask playerInfoUITask = (PlayerInfoUITask)LuaObject.checkSelf(l);
			int headPortraitId;
			LuaObject.checkType(l, 2, out headPortraitId);
			int headFreameId;
			LuaObject.checkType(l, 3, out headFreameId);
			playerInfoUITask.m_luaExportHelper.PlayerInfoUIController_OnChangeHeadPortraitAndHeadFrame(headPortraitId, headFreameId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020399 RID: 131993 RVA: 0x00AB348C File Offset: 0x00AB168C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayerInfoUIController_OnRedemptionCodeUse(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUITask playerInfoUITask = (PlayerInfoUITask)LuaObject.checkSelf(l);
			string key;
			LuaObject.checkType(l, 2, out key);
			Action<int> onSucceed;
			LuaObject.checkDelegate<Action<int>>(l, 3, out onSucceed);
			playerInfoUITask.m_luaExportHelper.PlayerInfoUIController_OnRedemptionCodeUse(key, onSucceed);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602039A RID: 131994 RVA: 0x00AB34F8 File Offset: 0x00AB16F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayerSettingUIController_OnClose(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUITask playerInfoUITask = (PlayerInfoUITask)LuaObject.checkSelf(l);
			playerInfoUITask.m_luaExportHelper.PlayerSettingUIController_OnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602039B RID: 131995 RVA: 0x00AB354C File Offset: 0x00AB174C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayerInfoUIController_OnShowSign(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUITask playerInfoUITask = (PlayerInfoUITask)LuaObject.checkSelf(l);
			playerInfoUITask.m_luaExportHelper.PlayerInfoUIController_OnShowSign();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602039C RID: 131996 RVA: 0x00AB35A0 File Offset: 0x00AB17A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SignUITask_OnLoadAllResCompleted(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUITask playerInfoUITask = (PlayerInfoUITask)LuaObject.checkSelf(l);
			playerInfoUITask.m_luaExportHelper.SignUITask_OnLoadAllResCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602039D RID: 131997 RVA: 0x00AB35F4 File Offset: 0x00AB17F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayerInfoUIController_OnShowPlayerSetting(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUITask playerInfoUITask = (PlayerInfoUITask)LuaObject.checkSelf(l);
			playerInfoUITask.m_luaExportHelper.PlayerInfoUIController_OnShowPlayerSetting();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602039E RID: 131998 RVA: 0x00AB3648 File Offset: 0x00AB1848
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayerInfoUIController_OnChangeRECState(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUITask playerInfoUITask = (PlayerInfoUITask)LuaObject.checkSelf(l);
			bool isOn;
			LuaObject.checkType(l, 2, out isOn);
			playerInfoUITask.m_luaExportHelper.PlayerInfoUIController_OnChangeRECState(isOn);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602039F RID: 131999 RVA: 0x00AB36A4 File Offset: 0x00AB18A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayerInfoUIController_OnCrystalNotEnough(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUITask playerInfoUITask = (PlayerInfoUITask)LuaObject.checkSelf(l);
			playerInfoUITask.m_luaExportHelper.PlayerInfoUIController_OnCrystalNotEnough();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060203A0 RID: 132000 RVA: 0x00AB36F8 File Offset: 0x00AB18F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStart(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUITask playerInfoUITask = (PlayerInfoUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = playerInfoUITask.m_luaExportHelper.__callBase_OnStart(intent);
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

	// Token: 0x060203A1 RID: 132001 RVA: 0x00AB3760 File Offset: 0x00AB1960
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStop(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUITask playerInfoUITask = (PlayerInfoUITask)LuaObject.checkSelf(l);
			playerInfoUITask.m_luaExportHelper.__callBase_OnStop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060203A2 RID: 132002 RVA: 0x00AB37B4 File Offset: 0x00AB19B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnPause(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUITask playerInfoUITask = (PlayerInfoUITask)LuaObject.checkSelf(l);
			playerInfoUITask.m_luaExportHelper.__callBase_OnPause();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060203A3 RID: 132003 RVA: 0x00AB3808 File Offset: 0x00AB1A08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnResume(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUITask playerInfoUITask = (PlayerInfoUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = playerInfoUITask.m_luaExportHelper.__callBase_OnResume(intent);
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

	// Token: 0x060203A4 RID: 132004 RVA: 0x00AB3870 File Offset: 0x00AB1A70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnNewIntent(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUITask playerInfoUITask = (PlayerInfoUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = playerInfoUITask.m_luaExportHelper.__callBase_OnNewIntent(intent);
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

	// Token: 0x060203A5 RID: 132005 RVA: 0x00AB38D8 File Offset: 0x00AB1AD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_EnableUIInput(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUITask playerInfoUITask = (PlayerInfoUITask)LuaObject.checkSelf(l);
			bool isEnable;
			LuaObject.checkType(l, 2, out isEnable);
			bool? isGlobalEnable;
			LuaObject.checkNullable<bool>(l, 3, out isGlobalEnable);
			playerInfoUITask.m_luaExportHelper.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060203A6 RID: 132006 RVA: 0x00AB3944 File Offset: 0x00AB1B44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUITask playerInfoUITask = (PlayerInfoUITask)LuaObject.checkSelf(l);
			bool b = playerInfoUITask.m_luaExportHelper.__callBase_IsNeedLoadDynamicRes();
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

	// Token: 0x060203A7 RID: 132007 RVA: 0x00AB39A0 File Offset: 0x00AB1BA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAllDynamicResForLoad(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUITask playerInfoUITask = (PlayerInfoUITask)LuaObject.checkSelf(l);
			List<string> o = playerInfoUITask.m_luaExportHelper.__callBase_CollectAllDynamicResForLoad();
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

	// Token: 0x060203A8 RID: 132008 RVA: 0x00AB39FC File Offset: 0x00AB1BFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_RegisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUITask playerInfoUITask = (PlayerInfoUITask)LuaObject.checkSelf(l);
			playerInfoUITask.m_luaExportHelper.__callBase_RegisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060203A9 RID: 132009 RVA: 0x00AB3A50 File Offset: 0x00AB1C50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_UnregisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUITask playerInfoUITask = (PlayerInfoUITask)LuaObject.checkSelf(l);
			playerInfoUITask.m_luaExportHelper.__callBase_UnregisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060203AA RID: 132010 RVA: 0x00AB3AA4 File Offset: 0x00AB1CA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PostUpdateView(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUITask playerInfoUITask = (PlayerInfoUITask)LuaObject.checkSelf(l);
			playerInfoUITask.m_luaExportHelper.__callBase_PostUpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060203AB RID: 132011 RVA: 0x00AB3AF8 File Offset: 0x00AB1CF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectPreloadResourceList(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUITask playerInfoUITask = (PlayerInfoUITask)LuaObject.checkSelf(l);
			playerInfoUITask.m_luaExportHelper.__callBase_CollectPreloadResourceList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060203AC RID: 132012 RVA: 0x00AB3B4C File Offset: 0x00AB1D4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearAssetList(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUITask playerInfoUITask = (PlayerInfoUITask)LuaObject.checkSelf(l);
			playerInfoUITask.m_luaExportHelper.__callBase_ClearAssetList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060203AD RID: 132013 RVA: 0x00AB3BA0 File Offset: 0x00AB1DA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAsset(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUITask playerInfoUITask = (PlayerInfoUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			playerInfoUITask.m_luaExportHelper.__callBase_CollectAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060203AE RID: 132014 RVA: 0x00AB3BFC File Offset: 0x00AB1DFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectSpriteAsset(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUITask playerInfoUITask = (PlayerInfoUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			playerInfoUITask.m_luaExportHelper.__callBase_CollectSpriteAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060203AF RID: 132015 RVA: 0x00AB3C58 File Offset: 0x00AB1E58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectFxAsset(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUITask playerInfoUITask = (PlayerInfoUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			playerInfoUITask.m_luaExportHelper.__callBase_CollectFxAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060203B0 RID: 132016 RVA: 0x00AB3CB4 File Offset: 0x00AB1EB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_StartLoadCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUITask playerInfoUITask = (PlayerInfoUITask)LuaObject.checkSelf(l);
			Action onLoadCompleted;
			LuaObject.checkDelegate<Action>(l, 2, out onLoadCompleted);
			playerInfoUITask.m_luaExportHelper.__callBase_StartLoadCustomAssets(onLoadCompleted);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060203B1 RID: 132017 RVA: 0x00AB3D10 File Offset: 0x00AB1F10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsLoadingCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUITask playerInfoUITask = (PlayerInfoUITask)LuaObject.checkSelf(l);
			bool b = playerInfoUITask.m_luaExportHelper.__callBase_IsLoadingCustomAssets();
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

	// Token: 0x060203B2 RID: 132018 RVA: 0x00AB3D6C File Offset: 0x00AB1F6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsPipeLineRunning(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUITask playerInfoUITask = (PlayerInfoUITask)LuaObject.checkSelf(l);
			bool b = playerInfoUITask.m_luaExportHelper.__callBase_IsPipeLineRunning();
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

	// Token: 0x060203B3 RID: 132019 RVA: 0x00AB3DC8 File Offset: 0x00AB1FC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsOpeningUI(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUITask playerInfoUITask = (PlayerInfoUITask)LuaObject.checkSelf(l);
			bool b = playerInfoUITask.m_luaExportHelper.__callBase_IsOpeningUI();
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

	// Token: 0x060203B4 RID: 132020 RVA: 0x00AB3E24 File Offset: 0x00AB2024
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ReturnPrevUITask(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUITask playerInfoUITask = (PlayerInfoUITask)LuaObject.checkSelf(l);
			UITaskBase o = playerInfoUITask.m_luaExportHelper.__callBase_ReturnPrevUITask();
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

	// Token: 0x060203B5 RID: 132021 RVA: 0x00AB3E80 File Offset: 0x00AB2080
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearUnusedDynamicResourceCache(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUITask playerInfoUITask = (PlayerInfoUITask)LuaObject.checkSelf(l);
			playerInfoUITask.m_luaExportHelper.__callBase_ClearUnusedDynamicResourceCache();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060203B6 RID: 132022 RVA: 0x00AB3ED4 File Offset: 0x00AB20D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnMemoryWarning(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUITask playerInfoUITask = (PlayerInfoUITask)LuaObject.checkSelf(l);
			playerInfoUITask.m_luaExportHelper.__callBase_OnMemoryWarning();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060203B7 RID: 132023 RVA: 0x00AB3F28 File Offset: 0x00AB2128
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUITask playerInfoUITask = (PlayerInfoUITask)LuaObject.checkSelf(l);
			playerInfoUITask.m_luaExportHelper.__callDele_EventOnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060203B8 RID: 132024 RVA: 0x00AB3F7C File Offset: 0x00AB217C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUITask playerInfoUITask = (PlayerInfoUITask)LuaObject.checkSelf(l);
			playerInfoUITask.m_luaExportHelper.__clearDele_EventOnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060203B9 RID: 132025 RVA: 0x00AB3FD0 File Offset: 0x00AB21D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUITask playerInfoUITask = (PlayerInfoUITask)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					playerInfoUITask.EventOnClose += value;
				}
				else if (num == 2)
				{
					playerInfoUITask.EventOnClose -= value;
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

	// Token: 0x060203BA RID: 132026 RVA: 0x00AB4050 File Offset: 0x00AB2250
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUITask playerInfoUITask = (PlayerInfoUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerInfoUITask.m_luaExportHelper.m_layerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060203BB RID: 132027 RVA: 0x00AB40A8 File Offset: 0x00AB22A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUITask playerInfoUITask = (PlayerInfoUITask)LuaObject.checkSelf(l);
			UITaskBase.LayerDesc[] layerDescArray;
			LuaObject.checkArray<UITaskBase.LayerDesc>(l, 2, out layerDescArray);
			playerInfoUITask.m_luaExportHelper.m_layerDescArray = layerDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060203BC RID: 132028 RVA: 0x00AB4104 File Offset: 0x00AB2304
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUITask playerInfoUITask = (PlayerInfoUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerInfoUITask.m_luaExportHelper.m_uiCtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060203BD RID: 132029 RVA: 0x00AB415C File Offset: 0x00AB235C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUITask playerInfoUITask = (PlayerInfoUITask)LuaObject.checkSelf(l);
			UITaskBase.UIControllerDesc[] uiCtrlDescArray;
			LuaObject.checkArray<UITaskBase.UIControllerDesc>(l, 2, out uiCtrlDescArray);
			playerInfoUITask.m_luaExportHelper.m_uiCtrlDescArray = uiCtrlDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060203BE RID: 132030 RVA: 0x00AB41B8 File Offset: 0x00AB23B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUITask playerInfoUITask = (PlayerInfoUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerInfoUITask.m_luaExportHelper.m_playerContext);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060203BF RID: 132031 RVA: 0x00AB4210 File Offset: 0x00AB2410
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUITask playerInfoUITask = (PlayerInfoUITask)LuaObject.checkSelf(l);
			ProjectLPlayerContext playerContext;
			LuaObject.checkType<ProjectLPlayerContext>(l, 2, out playerContext);
			playerInfoUITask.m_luaExportHelper.m_playerContext = playerContext;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060203C0 RID: 132032 RVA: 0x00AB426C File Offset: 0x00AB246C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerInfoUIController(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUITask playerInfoUITask = (PlayerInfoUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerInfoUITask.m_luaExportHelper.m_playerInfoUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060203C1 RID: 132033 RVA: 0x00AB42C4 File Offset: 0x00AB24C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerInfoUIController(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUITask playerInfoUITask = (PlayerInfoUITask)LuaObject.checkSelf(l);
			PlayerInfoUIController playerInfoUIController;
			LuaObject.checkType<PlayerInfoUIController>(l, 2, out playerInfoUIController);
			playerInfoUITask.m_luaExportHelper.m_playerInfoUIController = playerInfoUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060203C2 RID: 132034 RVA: 0x00AB4320 File Offset: 0x00AB2520
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LayerDescArray(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUITask playerInfoUITask = (PlayerInfoUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerInfoUITask.m_luaExportHelper.LayerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060203C3 RID: 132035 RVA: 0x00AB4378 File Offset: 0x00AB2578
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_UICtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUITask playerInfoUITask = (PlayerInfoUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerInfoUITask.m_luaExportHelper.UICtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060203C4 RID: 132036 RVA: 0x00AB43D0 File Offset: 0x00AB25D0
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.PlayerInfoUITask");
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.InitAllUIControllers);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.ClearAllContextAndRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.OnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.UpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.PlayerInfoUIController_OnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.PlayerInfoUIController_OnShowChangeIconPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.PlayerInfoUIController_OnChangeName);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.PlayerInfoUIController_OnWatchMyBusinessCard);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.PlayerInfoUIController_OnChangeHeadPortraitAndHeadFrame);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.PlayerInfoUIController_OnRedemptionCodeUse);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.PlayerSettingUIController_OnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.PlayerInfoUIController_OnShowSign);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.SignUITask_OnLoadAllResCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.PlayerInfoUIController_OnShowPlayerSetting);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.PlayerInfoUIController_OnChangeRECState);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.PlayerInfoUIController_OnCrystalNotEnough);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.__callBase_OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.__callBase_OnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.__callBase_OnPause);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.__callBase_OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.__callBase_OnNewIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.__callBase_EnableUIInput);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.__callBase_IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.__callBase_CollectAllDynamicResForLoad);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.__callBase_RegisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.__callBase_UnregisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.__callBase_PostUpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.__callBase_CollectPreloadResourceList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.__callBase_ClearAssetList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.__callBase_CollectAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.__callBase_CollectSpriteAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.__callBase_CollectFxAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.__callBase_StartLoadCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.__callBase_IsLoadingCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.__callBase_IsPipeLineRunning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.__callBase_IsOpeningUI);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cache25);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.__callBase_ReturnPrevUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cache26);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.__callBase_ClearUnusedDynamicResourceCache);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cache27);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.__callBase_OnMemoryWarning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cache28);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.__callDele_EventOnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cache29);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.__clearDele_EventOnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cache2A);
		string name = "EventOnClose";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.set_EventOnClose);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cache2B, true);
		string name2 = "m_layerDescArray";
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.get_m_layerDescArray);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cache2C;
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.set_m_layerDescArray);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cache2D, true);
		string name3 = "m_uiCtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.get_m_uiCtrlDescArray);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cache2E;
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.set_m_uiCtrlDescArray);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cache2F, true);
		string name4 = "m_playerContext";
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.get_m_playerContext);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cache30;
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.set_m_playerContext);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cache31, true);
		string name5 = "m_playerInfoUIController";
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.get_m_playerInfoUIController);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cache32;
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.set_m_playerInfoUIController);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cache33, true);
		string name6 = "LayerDescArray";
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.get_LayerDescArray);
		}
		LuaObject.addMember(l, name6, Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cache34, null, true);
		string name7 = "UICtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.get_UICtrlDescArray);
		}
		LuaObject.addMember(l, name7, Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cache35, null, true);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.<>f__mg$cache36, typeof(PlayerInfoUITask), typeof(UITask));
	}

	// Token: 0x04016317 RID: 90903
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04016318 RID: 90904
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04016319 RID: 90905
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0401631A RID: 90906
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0401631B RID: 90907
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0401631C RID: 90908
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0401631D RID: 90909
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0401631E RID: 90910
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0401631F RID: 90911
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04016320 RID: 90912
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04016321 RID: 90913
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04016322 RID: 90914
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04016323 RID: 90915
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04016324 RID: 90916
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04016325 RID: 90917
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04016326 RID: 90918
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04016327 RID: 90919
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04016328 RID: 90920
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04016329 RID: 90921
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0401632A RID: 90922
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0401632B RID: 90923
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0401632C RID: 90924
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0401632D RID: 90925
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0401632E RID: 90926
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0401632F RID: 90927
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04016330 RID: 90928
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04016331 RID: 90929
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04016332 RID: 90930
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04016333 RID: 90931
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04016334 RID: 90932
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04016335 RID: 90933
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04016336 RID: 90934
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04016337 RID: 90935
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04016338 RID: 90936
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04016339 RID: 90937
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0401633A RID: 90938
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0401633B RID: 90939
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0401633C RID: 90940
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0401633D RID: 90941
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0401633E RID: 90942
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0401633F RID: 90943
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04016340 RID: 90944
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04016341 RID: 90945
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04016342 RID: 90946
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04016343 RID: 90947
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04016344 RID: 90948
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04016345 RID: 90949
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04016346 RID: 90950
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04016347 RID: 90951
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04016348 RID: 90952
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04016349 RID: 90953
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x0401634A RID: 90954
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x0401634B RID: 90955
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x0401634C RID: 90956
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x0401634D RID: 90957
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;
}
