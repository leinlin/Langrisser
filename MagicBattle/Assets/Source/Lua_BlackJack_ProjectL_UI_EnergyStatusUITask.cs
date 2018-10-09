using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x02001420 RID: 5152
[Preserve]
public class Lua_BlackJack_ProjectL_UI_EnergyStatusUITask : LuaObject
{
	// Token: 0x0601D553 RID: 120147 RVA: 0x00943E78 File Offset: 0x00942078
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			string name;
			LuaObject.checkType(l, 2, out name);
			EnergyStatusUITask o = new EnergyStatusUITask(name);
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

	// Token: 0x0601D554 RID: 120148 RVA: 0x00943ECC File Offset: 0x009420CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartUITask_s(IntPtr l)
	{
		int result;
		try
		{
			Vector3 vector;
			LuaObject.checkType(l, 1, out vector);
			EnergyStatusUITask o = EnergyStatusUITask.StartUITask(vector);
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

	// Token: 0x0601D555 RID: 120149 RVA: 0x00943F20 File Offset: 0x00942120
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnStart(IntPtr l)
	{
		int result;
		try
		{
			EnergyStatusUITask energyStatusUITask = (EnergyStatusUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = energyStatusUITask.m_luaExportHelper.OnStart(intent);
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

	// Token: 0x0601D556 RID: 120150 RVA: 0x00943F88 File Offset: 0x00942188
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnResume(IntPtr l)
	{
		int result;
		try
		{
			EnergyStatusUITask energyStatusUITask = (EnergyStatusUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = energyStatusUITask.m_luaExportHelper.OnResume(intent);
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

	// Token: 0x0601D557 RID: 120151 RVA: 0x00943FF0 File Offset: 0x009421F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitAllUIControllers(IntPtr l)
	{
		int result;
		try
		{
			EnergyStatusUITask energyStatusUITask = (EnergyStatusUITask)LuaObject.checkSelf(l);
			energyStatusUITask.m_luaExportHelper.InitAllUIControllers();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D558 RID: 120152 RVA: 0x00944044 File Offset: 0x00942244
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearAllContextAndRes(IntPtr l)
	{
		int result;
		try
		{
			EnergyStatusUITask energyStatusUITask = (EnergyStatusUITask)LuaObject.checkSelf(l);
			energyStatusUITask.m_luaExportHelper.ClearAllContextAndRes();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D559 RID: 120153 RVA: 0x00944098 File Offset: 0x00942298
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateView(IntPtr l)
	{
		int result;
		try
		{
			EnergyStatusUITask energyStatusUITask = (EnergyStatusUITask)LuaObject.checkSelf(l);
			energyStatusUITask.m_luaExportHelper.UpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D55A RID: 120154 RVA: 0x009440EC File Offset: 0x009422EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnTick(IntPtr l)
	{
		int result;
		try
		{
			EnergyStatusUITask energyStatusUITask = (EnergyStatusUITask)LuaObject.checkSelf(l);
			energyStatusUITask.m_luaExportHelper.OnTick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D55B RID: 120155 RVA: 0x00944140 File Offset: 0x00942340
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitDataFromUIIntent(IntPtr l)
	{
		int result;
		try
		{
			EnergyStatusUITask energyStatusUITask = (EnergyStatusUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			energyStatusUITask.m_luaExportHelper.InitDataFromUIIntent(intent);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D55C RID: 120156 RVA: 0x0094419C File Offset: 0x0094239C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int EnergyStatusUIController_OnClose(IntPtr l)
	{
		int result;
		try
		{
			EnergyStatusUITask energyStatusUITask = (EnergyStatusUITask)LuaObject.checkSelf(l);
			energyStatusUITask.m_luaExportHelper.EnergyStatusUIController_OnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D55D RID: 120157 RVA: 0x009441F0 File Offset: 0x009423F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStart(IntPtr l)
	{
		int result;
		try
		{
			EnergyStatusUITask energyStatusUITask = (EnergyStatusUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = energyStatusUITask.m_luaExportHelper.__callBase_OnStart(intent);
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

	// Token: 0x0601D55E RID: 120158 RVA: 0x00944258 File Offset: 0x00942458
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStop(IntPtr l)
	{
		int result;
		try
		{
			EnergyStatusUITask energyStatusUITask = (EnergyStatusUITask)LuaObject.checkSelf(l);
			energyStatusUITask.m_luaExportHelper.__callBase_OnStop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D55F RID: 120159 RVA: 0x009442AC File Offset: 0x009424AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnPause(IntPtr l)
	{
		int result;
		try
		{
			EnergyStatusUITask energyStatusUITask = (EnergyStatusUITask)LuaObject.checkSelf(l);
			energyStatusUITask.m_luaExportHelper.__callBase_OnPause();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D560 RID: 120160 RVA: 0x00944300 File Offset: 0x00942500
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnResume(IntPtr l)
	{
		int result;
		try
		{
			EnergyStatusUITask energyStatusUITask = (EnergyStatusUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = energyStatusUITask.m_luaExportHelper.__callBase_OnResume(intent);
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

	// Token: 0x0601D561 RID: 120161 RVA: 0x00944368 File Offset: 0x00942568
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnNewIntent(IntPtr l)
	{
		int result;
		try
		{
			EnergyStatusUITask energyStatusUITask = (EnergyStatusUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = energyStatusUITask.m_luaExportHelper.__callBase_OnNewIntent(intent);
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

	// Token: 0x0601D562 RID: 120162 RVA: 0x009443D0 File Offset: 0x009425D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_EnableUIInput(IntPtr l)
	{
		int result;
		try
		{
			EnergyStatusUITask energyStatusUITask = (EnergyStatusUITask)LuaObject.checkSelf(l);
			bool isEnable;
			LuaObject.checkType(l, 2, out isEnable);
			bool? isGlobalEnable;
			LuaObject.checkNullable<bool>(l, 3, out isGlobalEnable);
			energyStatusUITask.m_luaExportHelper.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D563 RID: 120163 RVA: 0x0094443C File Offset: 0x0094263C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			EnergyStatusUITask energyStatusUITask = (EnergyStatusUITask)LuaObject.checkSelf(l);
			bool b = energyStatusUITask.m_luaExportHelper.__callBase_IsNeedLoadDynamicRes();
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

	// Token: 0x0601D564 RID: 120164 RVA: 0x00944498 File Offset: 0x00942698
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAllDynamicResForLoad(IntPtr l)
	{
		int result;
		try
		{
			EnergyStatusUITask energyStatusUITask = (EnergyStatusUITask)LuaObject.checkSelf(l);
			List<string> o = energyStatusUITask.m_luaExportHelper.__callBase_CollectAllDynamicResForLoad();
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

	// Token: 0x0601D565 RID: 120165 RVA: 0x009444F4 File Offset: 0x009426F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_RegisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			EnergyStatusUITask energyStatusUITask = (EnergyStatusUITask)LuaObject.checkSelf(l);
			energyStatusUITask.m_luaExportHelper.__callBase_RegisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D566 RID: 120166 RVA: 0x00944548 File Offset: 0x00942748
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_UnregisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			EnergyStatusUITask energyStatusUITask = (EnergyStatusUITask)LuaObject.checkSelf(l);
			energyStatusUITask.m_luaExportHelper.__callBase_UnregisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D567 RID: 120167 RVA: 0x0094459C File Offset: 0x0094279C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_PostUpdateView(IntPtr l)
	{
		int result;
		try
		{
			EnergyStatusUITask energyStatusUITask = (EnergyStatusUITask)LuaObject.checkSelf(l);
			energyStatusUITask.m_luaExportHelper.__callBase_PostUpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D568 RID: 120168 RVA: 0x009445F0 File Offset: 0x009427F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectPreloadResourceList(IntPtr l)
	{
		int result;
		try
		{
			EnergyStatusUITask energyStatusUITask = (EnergyStatusUITask)LuaObject.checkSelf(l);
			energyStatusUITask.m_luaExportHelper.__callBase_CollectPreloadResourceList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D569 RID: 120169 RVA: 0x00944644 File Offset: 0x00942844
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearAssetList(IntPtr l)
	{
		int result;
		try
		{
			EnergyStatusUITask energyStatusUITask = (EnergyStatusUITask)LuaObject.checkSelf(l);
			energyStatusUITask.m_luaExportHelper.__callBase_ClearAssetList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D56A RID: 120170 RVA: 0x00944698 File Offset: 0x00942898
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAsset(IntPtr l)
	{
		int result;
		try
		{
			EnergyStatusUITask energyStatusUITask = (EnergyStatusUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			energyStatusUITask.m_luaExportHelper.__callBase_CollectAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D56B RID: 120171 RVA: 0x009446F4 File Offset: 0x009428F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectSpriteAsset(IntPtr l)
	{
		int result;
		try
		{
			EnergyStatusUITask energyStatusUITask = (EnergyStatusUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			energyStatusUITask.m_luaExportHelper.__callBase_CollectSpriteAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D56C RID: 120172 RVA: 0x00944750 File Offset: 0x00942950
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectFxAsset(IntPtr l)
	{
		int result;
		try
		{
			EnergyStatusUITask energyStatusUITask = (EnergyStatusUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			energyStatusUITask.m_luaExportHelper.__callBase_CollectFxAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D56D RID: 120173 RVA: 0x009447AC File Offset: 0x009429AC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_StartLoadCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			EnergyStatusUITask energyStatusUITask = (EnergyStatusUITask)LuaObject.checkSelf(l);
			Action onLoadCompleted;
			LuaObject.checkDelegate<Action>(l, 2, out onLoadCompleted);
			energyStatusUITask.m_luaExportHelper.__callBase_StartLoadCustomAssets(onLoadCompleted);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D56E RID: 120174 RVA: 0x00944808 File Offset: 0x00942A08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsLoadingCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			EnergyStatusUITask energyStatusUITask = (EnergyStatusUITask)LuaObject.checkSelf(l);
			bool b = energyStatusUITask.m_luaExportHelper.__callBase_IsLoadingCustomAssets();
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

	// Token: 0x0601D56F RID: 120175 RVA: 0x00944864 File Offset: 0x00942A64
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_IsPipeLineRunning(IntPtr l)
	{
		int result;
		try
		{
			EnergyStatusUITask energyStatusUITask = (EnergyStatusUITask)LuaObject.checkSelf(l);
			bool b = energyStatusUITask.m_luaExportHelper.__callBase_IsPipeLineRunning();
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

	// Token: 0x0601D570 RID: 120176 RVA: 0x009448C0 File Offset: 0x00942AC0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_IsOpeningUI(IntPtr l)
	{
		int result;
		try
		{
			EnergyStatusUITask energyStatusUITask = (EnergyStatusUITask)LuaObject.checkSelf(l);
			bool b = energyStatusUITask.m_luaExportHelper.__callBase_IsOpeningUI();
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

	// Token: 0x0601D571 RID: 120177 RVA: 0x0094491C File Offset: 0x00942B1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ReturnPrevUITask(IntPtr l)
	{
		int result;
		try
		{
			EnergyStatusUITask energyStatusUITask = (EnergyStatusUITask)LuaObject.checkSelf(l);
			UITaskBase o = energyStatusUITask.m_luaExportHelper.__callBase_ReturnPrevUITask();
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

	// Token: 0x0601D572 RID: 120178 RVA: 0x00944978 File Offset: 0x00942B78
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_ClearUnusedDynamicResourceCache(IntPtr l)
	{
		int result;
		try
		{
			EnergyStatusUITask energyStatusUITask = (EnergyStatusUITask)LuaObject.checkSelf(l);
			energyStatusUITask.m_luaExportHelper.__callBase_ClearUnusedDynamicResourceCache();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D573 RID: 120179 RVA: 0x009449CC File Offset: 0x00942BCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnMemoryWarning(IntPtr l)
	{
		int result;
		try
		{
			EnergyStatusUITask energyStatusUITask = (EnergyStatusUITask)LuaObject.checkSelf(l);
			energyStatusUITask.m_luaExportHelper.__callBase_OnMemoryWarning();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D574 RID: 120180 RVA: 0x00944A20 File Offset: 0x00942C20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			EnergyStatusUITask energyStatusUITask = (EnergyStatusUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, energyStatusUITask.m_luaExportHelper.m_layerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D575 RID: 120181 RVA: 0x00944A78 File Offset: 0x00942C78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			EnergyStatusUITask energyStatusUITask = (EnergyStatusUITask)LuaObject.checkSelf(l);
			UITaskBase.LayerDesc[] layerDescArray;
			LuaObject.checkArray<UITaskBase.LayerDesc>(l, 2, out layerDescArray);
			energyStatusUITask.m_luaExportHelper.m_layerDescArray = layerDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D576 RID: 120182 RVA: 0x00944AD4 File Offset: 0x00942CD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			EnergyStatusUITask energyStatusUITask = (EnergyStatusUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, energyStatusUITask.m_luaExportHelper.m_uiCtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D577 RID: 120183 RVA: 0x00944B2C File Offset: 0x00942D2C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			EnergyStatusUITask energyStatusUITask = (EnergyStatusUITask)LuaObject.checkSelf(l);
			UITaskBase.UIControllerDesc[] uiCtrlDescArray;
			LuaObject.checkArray<UITaskBase.UIControllerDesc>(l, 2, out uiCtrlDescArray);
			energyStatusUITask.m_luaExportHelper.m_uiCtrlDescArray = uiCtrlDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D578 RID: 120184 RVA: 0x00944B88 File Offset: 0x00942D88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ParamKey_EnergyStatusPostion(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, EnergyStatusUITask.LuaExportHelper.ParamKey_EnergyStatusPostion);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D579 RID: 120185 RVA: 0x00944BD0 File Offset: 0x00942DD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_energyStatusUIController(IntPtr l)
	{
		int result;
		try
		{
			EnergyStatusUITask energyStatusUITask = (EnergyStatusUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, energyStatusUITask.m_luaExportHelper.m_energyStatusUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D57A RID: 120186 RVA: 0x00944C28 File Offset: 0x00942E28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_energyStatusUIController(IntPtr l)
	{
		int result;
		try
		{
			EnergyStatusUITask energyStatusUITask = (EnergyStatusUITask)LuaObject.checkSelf(l);
			EnergyStatusUIController energyStatusUIController;
			LuaObject.checkType<EnergyStatusUIController>(l, 2, out energyStatusUIController);
			energyStatusUITask.m_luaExportHelper.m_energyStatusUIController = energyStatusUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D57B RID: 120187 RVA: 0x00944C84 File Offset: 0x00942E84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_nowSeconds(IntPtr l)
	{
		int result;
		try
		{
			EnergyStatusUITask energyStatusUITask = (EnergyStatusUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, energyStatusUITask.m_luaExportHelper.m_nowSeconds);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D57C RID: 120188 RVA: 0x00944CDC File Offset: 0x00942EDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_nowSeconds(IntPtr l)
	{
		int result;
		try
		{
			EnergyStatusUITask energyStatusUITask = (EnergyStatusUITask)LuaObject.checkSelf(l);
			int nowSeconds;
			LuaObject.checkType(l, 2, out nowSeconds);
			energyStatusUITask.m_luaExportHelper.m_nowSeconds = nowSeconds;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D57D RID: 120189 RVA: 0x00944D38 File Offset: 0x00942F38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_energyStatusPosition(IntPtr l)
	{
		int result;
		try
		{
			EnergyStatusUITask energyStatusUITask = (EnergyStatusUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, energyStatusUITask.m_luaExportHelper.m_energyStatusPosition);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D57E RID: 120190 RVA: 0x00944D90 File Offset: 0x00942F90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_energyStatusPosition(IntPtr l)
	{
		int result;
		try
		{
			EnergyStatusUITask energyStatusUITask = (EnergyStatusUITask)LuaObject.checkSelf(l);
			Vector3 energyStatusPosition;
			LuaObject.checkType(l, 2, out energyStatusPosition);
			energyStatusUITask.m_luaExportHelper.m_energyStatusPosition = energyStatusPosition;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D57F RID: 120191 RVA: 0x00944DEC File Offset: 0x00942FEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LayerDescArray(IntPtr l)
	{
		int result;
		try
		{
			EnergyStatusUITask energyStatusUITask = (EnergyStatusUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, energyStatusUITask.m_luaExportHelper.LayerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D580 RID: 120192 RVA: 0x00944E44 File Offset: 0x00943044
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_UICtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			EnergyStatusUITask energyStatusUITask = (EnergyStatusUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, energyStatusUITask.m_luaExportHelper.UICtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D581 RID: 120193 RVA: 0x00944E9C File Offset: 0x0094309C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.EnergyStatusUITask");
		if (Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.StartUITask_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.InitAllUIControllers);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.ClearAllContextAndRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.UpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.OnTick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.InitDataFromUIIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.EnergyStatusUIController_OnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.__callBase_OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.__callBase_OnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.__callBase_OnPause);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.__callBase_OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.__callBase_OnNewIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.__callBase_EnableUIInput);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.__callBase_IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.__callBase_CollectAllDynamicResForLoad);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.__callBase_RegisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.__callBase_UnregisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.__callBase_PostUpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.__callBase_CollectPreloadResourceList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.__callBase_ClearAssetList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.__callBase_CollectAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.__callBase_CollectSpriteAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.__callBase_CollectFxAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.__callBase_StartLoadCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.__callBase_IsLoadingCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.__callBase_IsPipeLineRunning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.__callBase_IsOpeningUI);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.__callBase_ReturnPrevUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.__callBase_ClearUnusedDynamicResourceCache);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.__callBase_OnMemoryWarning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.<>f__mg$cache1F);
		string name = "m_layerDescArray";
		if (Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.get_m_layerDescArray);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.<>f__mg$cache20;
		if (Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.set_m_layerDescArray);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.<>f__mg$cache21, true);
		string name2 = "m_uiCtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.get_m_uiCtrlDescArray);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.<>f__mg$cache22;
		if (Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.set_m_uiCtrlDescArray);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.<>f__mg$cache23, true);
		string name3 = "ParamKey_EnergyStatusPostion";
		if (Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.get_ParamKey_EnergyStatusPostion);
		}
		LuaObject.addMember(l, name3, Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.<>f__mg$cache24, null, false);
		string name4 = "m_energyStatusUIController";
		if (Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.get_m_energyStatusUIController);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.<>f__mg$cache25;
		if (Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.set_m_energyStatusUIController);
		}
		LuaObject.addMember(l, name4, get3, Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.<>f__mg$cache26, true);
		string name5 = "m_nowSeconds";
		if (Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.get_m_nowSeconds);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.<>f__mg$cache27;
		if (Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.set_m_nowSeconds);
		}
		LuaObject.addMember(l, name5, get4, Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.<>f__mg$cache28, true);
		string name6 = "m_energyStatusPosition";
		if (Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.get_m_energyStatusPosition);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.<>f__mg$cache29;
		if (Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.set_m_energyStatusPosition);
		}
		LuaObject.addMember(l, name6, get5, Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.<>f__mg$cache2A, true);
		string name7 = "LayerDescArray";
		if (Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.get_LayerDescArray);
		}
		LuaObject.addMember(l, name7, Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.<>f__mg$cache2B, null, true);
		string name8 = "UICtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.get_UICtrlDescArray);
		}
		LuaObject.addMember(l, name8, Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.<>f__mg$cache2C, null, true);
		if (Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.<>f__mg$cache2D, typeof(EnergyStatusUITask), typeof(UITask));
	}

	// Token: 0x040136F5 RID: 79605
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040136F6 RID: 79606
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040136F7 RID: 79607
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040136F8 RID: 79608
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040136F9 RID: 79609
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040136FA RID: 79610
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040136FB RID: 79611
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040136FC RID: 79612
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x040136FD RID: 79613
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x040136FE RID: 79614
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x040136FF RID: 79615
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04013700 RID: 79616
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04013701 RID: 79617
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04013702 RID: 79618
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04013703 RID: 79619
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04013704 RID: 79620
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04013705 RID: 79621
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04013706 RID: 79622
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04013707 RID: 79623
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04013708 RID: 79624
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04013709 RID: 79625
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0401370A RID: 79626
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0401370B RID: 79627
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0401370C RID: 79628
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0401370D RID: 79629
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0401370E RID: 79630
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0401370F RID: 79631
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04013710 RID: 79632
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04013711 RID: 79633
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04013712 RID: 79634
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04013713 RID: 79635
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04013714 RID: 79636
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04013715 RID: 79637
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04013716 RID: 79638
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04013717 RID: 79639
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04013718 RID: 79640
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04013719 RID: 79641
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0401371A RID: 79642
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0401371B RID: 79643
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0401371C RID: 79644
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0401371D RID: 79645
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x0401371E RID: 79646
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x0401371F RID: 79647
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04013720 RID: 79648
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04013721 RID: 79649
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04013722 RID: 79650
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;
}
