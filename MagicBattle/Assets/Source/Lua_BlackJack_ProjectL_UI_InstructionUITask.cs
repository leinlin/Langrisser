using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020014F0 RID: 5360
[Preserve]
public class Lua_BlackJack_ProjectL_UI_InstructionUITask : LuaObject
{
	// Token: 0x0601FA35 RID: 129589 RVA: 0x00A691BC File Offset: 0x00A673BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			string name;
			LuaObject.checkType(l, 2, out name);
			InstructionUITask o = new InstructionUITask(name);
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

	// Token: 0x0601FA36 RID: 129590 RVA: 0x00A69210 File Offset: 0x00A67410
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartUITask_s(IntPtr l)
	{
		int result;
		try
		{
			string prefabName;
			LuaObject.checkType(l, 1, out prefabName);
			InstructionUITask o = InstructionUITask.StartUITask(prefabName);
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

	// Token: 0x0601FA37 RID: 129591 RVA: 0x00A69264 File Offset: 0x00A67464
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnStart(IntPtr l)
	{
		int result;
		try
		{
			InstructionUITask instructionUITask = (InstructionUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = instructionUITask.m_luaExportHelper.OnStart(intent);
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

	// Token: 0x0601FA38 RID: 129592 RVA: 0x00A692CC File Offset: 0x00A674CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnResume(IntPtr l)
	{
		int result;
		try
		{
			InstructionUITask instructionUITask = (InstructionUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = instructionUITask.m_luaExportHelper.OnResume(intent);
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

	// Token: 0x0601FA39 RID: 129593 RVA: 0x00A69334 File Offset: 0x00A67534
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitDataFromUIIntent(IntPtr l)
	{
		int result;
		try
		{
			InstructionUITask instructionUITask = (InstructionUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			instructionUITask.m_luaExportHelper.InitDataFromUIIntent(intent);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FA3A RID: 129594 RVA: 0x00A69390 File Offset: 0x00A67590
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			InstructionUITask instructionUITask = (InstructionUITask)LuaObject.checkSelf(l);
			bool b = instructionUITask.m_luaExportHelper.IsNeedLoadDynamicRes();
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

	// Token: 0x0601FA3B RID: 129595 RVA: 0x00A693EC File Offset: 0x00A675EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitAllUIControllers(IntPtr l)
	{
		int result;
		try
		{
			InstructionUITask instructionUITask = (InstructionUITask)LuaObject.checkSelf(l);
			instructionUITask.m_luaExportHelper.InitAllUIControllers();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FA3C RID: 129596 RVA: 0x00A69440 File Offset: 0x00A67640
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearAllContextAndRes(IntPtr l)
	{
		int result;
		try
		{
			InstructionUITask instructionUITask = (InstructionUITask)LuaObject.checkSelf(l);
			instructionUITask.m_luaExportHelper.ClearAllContextAndRes();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FA3D RID: 129597 RVA: 0x00A69494 File Offset: 0x00A67694
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateView(IntPtr l)
	{
		int result;
		try
		{
			InstructionUITask instructionUITask = (InstructionUITask)LuaObject.checkSelf(l);
			instructionUITask.m_luaExportHelper.UpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FA3E RID: 129598 RVA: 0x00A694E8 File Offset: 0x00A676E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InstructionUIController_OnClose(IntPtr l)
	{
		int result;
		try
		{
			InstructionUITask instructionUITask = (InstructionUITask)LuaObject.checkSelf(l);
			instructionUITask.m_luaExportHelper.InstructionUIController_OnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FA3F RID: 129599 RVA: 0x00A6953C File Offset: 0x00A6773C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStart(IntPtr l)
	{
		int result;
		try
		{
			InstructionUITask instructionUITask = (InstructionUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = instructionUITask.m_luaExportHelper.__callBase_OnStart(intent);
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

	// Token: 0x0601FA40 RID: 129600 RVA: 0x00A695A4 File Offset: 0x00A677A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStop(IntPtr l)
	{
		int result;
		try
		{
			InstructionUITask instructionUITask = (InstructionUITask)LuaObject.checkSelf(l);
			instructionUITask.m_luaExportHelper.__callBase_OnStop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FA41 RID: 129601 RVA: 0x00A695F8 File Offset: 0x00A677F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnPause(IntPtr l)
	{
		int result;
		try
		{
			InstructionUITask instructionUITask = (InstructionUITask)LuaObject.checkSelf(l);
			instructionUITask.m_luaExportHelper.__callBase_OnPause();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FA42 RID: 129602 RVA: 0x00A6964C File Offset: 0x00A6784C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnResume(IntPtr l)
	{
		int result;
		try
		{
			InstructionUITask instructionUITask = (InstructionUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = instructionUITask.m_luaExportHelper.__callBase_OnResume(intent);
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

	// Token: 0x0601FA43 RID: 129603 RVA: 0x00A696B4 File Offset: 0x00A678B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnNewIntent(IntPtr l)
	{
		int result;
		try
		{
			InstructionUITask instructionUITask = (InstructionUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = instructionUITask.m_luaExportHelper.__callBase_OnNewIntent(intent);
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

	// Token: 0x0601FA44 RID: 129604 RVA: 0x00A6971C File Offset: 0x00A6791C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_EnableUIInput(IntPtr l)
	{
		int result;
		try
		{
			InstructionUITask instructionUITask = (InstructionUITask)LuaObject.checkSelf(l);
			bool isEnable;
			LuaObject.checkType(l, 2, out isEnable);
			bool? isGlobalEnable;
			LuaObject.checkNullable<bool>(l, 3, out isGlobalEnable);
			instructionUITask.m_luaExportHelper.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FA45 RID: 129605 RVA: 0x00A69788 File Offset: 0x00A67988
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			InstructionUITask instructionUITask = (InstructionUITask)LuaObject.checkSelf(l);
			bool b = instructionUITask.m_luaExportHelper.__callBase_IsNeedLoadDynamicRes();
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

	// Token: 0x0601FA46 RID: 129606 RVA: 0x00A697E4 File Offset: 0x00A679E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAllDynamicResForLoad(IntPtr l)
	{
		int result;
		try
		{
			InstructionUITask instructionUITask = (InstructionUITask)LuaObject.checkSelf(l);
			List<string> o = instructionUITask.m_luaExportHelper.__callBase_CollectAllDynamicResForLoad();
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

	// Token: 0x0601FA47 RID: 129607 RVA: 0x00A69840 File Offset: 0x00A67A40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_RegisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			InstructionUITask instructionUITask = (InstructionUITask)LuaObject.checkSelf(l);
			instructionUITask.m_luaExportHelper.__callBase_RegisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FA48 RID: 129608 RVA: 0x00A69894 File Offset: 0x00A67A94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_UnregisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			InstructionUITask instructionUITask = (InstructionUITask)LuaObject.checkSelf(l);
			instructionUITask.m_luaExportHelper.__callBase_UnregisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FA49 RID: 129609 RVA: 0x00A698E8 File Offset: 0x00A67AE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PostUpdateView(IntPtr l)
	{
		int result;
		try
		{
			InstructionUITask instructionUITask = (InstructionUITask)LuaObject.checkSelf(l);
			instructionUITask.m_luaExportHelper.__callBase_PostUpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FA4A RID: 129610 RVA: 0x00A6993C File Offset: 0x00A67B3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectPreloadResourceList(IntPtr l)
	{
		int result;
		try
		{
			InstructionUITask instructionUITask = (InstructionUITask)LuaObject.checkSelf(l);
			instructionUITask.m_luaExportHelper.__callBase_CollectPreloadResourceList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FA4B RID: 129611 RVA: 0x00A69990 File Offset: 0x00A67B90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearAssetList(IntPtr l)
	{
		int result;
		try
		{
			InstructionUITask instructionUITask = (InstructionUITask)LuaObject.checkSelf(l);
			instructionUITask.m_luaExportHelper.__callBase_ClearAssetList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FA4C RID: 129612 RVA: 0x00A699E4 File Offset: 0x00A67BE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAsset(IntPtr l)
	{
		int result;
		try
		{
			InstructionUITask instructionUITask = (InstructionUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			instructionUITask.m_luaExportHelper.__callBase_CollectAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FA4D RID: 129613 RVA: 0x00A69A40 File Offset: 0x00A67C40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectSpriteAsset(IntPtr l)
	{
		int result;
		try
		{
			InstructionUITask instructionUITask = (InstructionUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			instructionUITask.m_luaExportHelper.__callBase_CollectSpriteAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FA4E RID: 129614 RVA: 0x00A69A9C File Offset: 0x00A67C9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectFxAsset(IntPtr l)
	{
		int result;
		try
		{
			InstructionUITask instructionUITask = (InstructionUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			instructionUITask.m_luaExportHelper.__callBase_CollectFxAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FA4F RID: 129615 RVA: 0x00A69AF8 File Offset: 0x00A67CF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_StartLoadCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			InstructionUITask instructionUITask = (InstructionUITask)LuaObject.checkSelf(l);
			Action onLoadCompleted;
			LuaObject.checkDelegate<Action>(l, 2, out onLoadCompleted);
			instructionUITask.m_luaExportHelper.__callBase_StartLoadCustomAssets(onLoadCompleted);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FA50 RID: 129616 RVA: 0x00A69B54 File Offset: 0x00A67D54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsLoadingCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			InstructionUITask instructionUITask = (InstructionUITask)LuaObject.checkSelf(l);
			bool b = instructionUITask.m_luaExportHelper.__callBase_IsLoadingCustomAssets();
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

	// Token: 0x0601FA51 RID: 129617 RVA: 0x00A69BB0 File Offset: 0x00A67DB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsPipeLineRunning(IntPtr l)
	{
		int result;
		try
		{
			InstructionUITask instructionUITask = (InstructionUITask)LuaObject.checkSelf(l);
			bool b = instructionUITask.m_luaExportHelper.__callBase_IsPipeLineRunning();
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

	// Token: 0x0601FA52 RID: 129618 RVA: 0x00A69C0C File Offset: 0x00A67E0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsOpeningUI(IntPtr l)
	{
		int result;
		try
		{
			InstructionUITask instructionUITask = (InstructionUITask)LuaObject.checkSelf(l);
			bool b = instructionUITask.m_luaExportHelper.__callBase_IsOpeningUI();
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

	// Token: 0x0601FA53 RID: 129619 RVA: 0x00A69C68 File Offset: 0x00A67E68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ReturnPrevUITask(IntPtr l)
	{
		int result;
		try
		{
			InstructionUITask instructionUITask = (InstructionUITask)LuaObject.checkSelf(l);
			UITaskBase o = instructionUITask.m_luaExportHelper.__callBase_ReturnPrevUITask();
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

	// Token: 0x0601FA54 RID: 129620 RVA: 0x00A69CC4 File Offset: 0x00A67EC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearUnusedDynamicResourceCache(IntPtr l)
	{
		int result;
		try
		{
			InstructionUITask instructionUITask = (InstructionUITask)LuaObject.checkSelf(l);
			instructionUITask.m_luaExportHelper.__callBase_ClearUnusedDynamicResourceCache();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FA55 RID: 129621 RVA: 0x00A69D18 File Offset: 0x00A67F18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnMemoryWarning(IntPtr l)
	{
		int result;
		try
		{
			InstructionUITask instructionUITask = (InstructionUITask)LuaObject.checkSelf(l);
			instructionUITask.m_luaExportHelper.__callBase_OnMemoryWarning();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FA56 RID: 129622 RVA: 0x00A69D6C File Offset: 0x00A67F6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			InstructionUITask instructionUITask = (InstructionUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, instructionUITask.m_luaExportHelper.m_layerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FA57 RID: 129623 RVA: 0x00A69DC4 File Offset: 0x00A67FC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			InstructionUITask instructionUITask = (InstructionUITask)LuaObject.checkSelf(l);
			UITaskBase.LayerDesc[] layerDescArray;
			LuaObject.checkArray<UITaskBase.LayerDesc>(l, 2, out layerDescArray);
			instructionUITask.m_luaExportHelper.m_layerDescArray = layerDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FA58 RID: 129624 RVA: 0x00A69E20 File Offset: 0x00A68020
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			InstructionUITask instructionUITask = (InstructionUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, instructionUITask.m_luaExportHelper.m_uiCtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FA59 RID: 129625 RVA: 0x00A69E78 File Offset: 0x00A68078
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			InstructionUITask instructionUITask = (InstructionUITask)LuaObject.checkSelf(l);
			UITaskBase.UIControllerDesc[] uiCtrlDescArray;
			LuaObject.checkArray<UITaskBase.UIControllerDesc>(l, 2, out uiCtrlDescArray);
			instructionUITask.m_luaExportHelper.m_uiCtrlDescArray = uiCtrlDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FA5A RID: 129626 RVA: 0x00A69ED4 File Offset: 0x00A680D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_instructionUIController(IntPtr l)
	{
		int result;
		try
		{
			InstructionUITask instructionUITask = (InstructionUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, instructionUITask.m_luaExportHelper.m_instructionUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FA5B RID: 129627 RVA: 0x00A69F2C File Offset: 0x00A6812C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_instructionUIController(IntPtr l)
	{
		int result;
		try
		{
			InstructionUITask instructionUITask = (InstructionUITask)LuaObject.checkSelf(l);
			InstructionUIController instructionUIController;
			LuaObject.checkType<InstructionUIController>(l, 2, out instructionUIController);
			instructionUITask.m_luaExportHelper.m_instructionUIController = instructionUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FA5C RID: 129628 RVA: 0x00A69F88 File Offset: 0x00A68188
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_prefabName(IntPtr l)
	{
		int result;
		try
		{
			InstructionUITask instructionUITask = (InstructionUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, instructionUITask.m_luaExportHelper.m_prefabName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FA5D RID: 129629 RVA: 0x00A69FE0 File Offset: 0x00A681E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_prefabName(IntPtr l)
	{
		int result;
		try
		{
			InstructionUITask instructionUITask = (InstructionUITask)LuaObject.checkSelf(l);
			string prefabName;
			LuaObject.checkType(l, 2, out prefabName);
			instructionUITask.m_luaExportHelper.m_prefabName = prefabName;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FA5E RID: 129630 RVA: 0x00A6A03C File Offset: 0x00A6823C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LayerDescArray(IntPtr l)
	{
		int result;
		try
		{
			InstructionUITask instructionUITask = (InstructionUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, instructionUITask.m_luaExportHelper.LayerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FA5F RID: 129631 RVA: 0x00A6A094 File Offset: 0x00A68294
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_UICtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			InstructionUITask instructionUITask = (InstructionUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, instructionUITask.m_luaExportHelper.UICtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FA60 RID: 129632 RVA: 0x00A6A0EC File Offset: 0x00A682EC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.InstructionUITask");
		if (Lua_BlackJack_ProjectL_UI_InstructionUITask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_InstructionUITask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InstructionUITask.StartUITask_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_InstructionUITask.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_InstructionUITask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_InstructionUITask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InstructionUITask.OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_InstructionUITask.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_InstructionUITask.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_InstructionUITask.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InstructionUITask.OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_InstructionUITask.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_InstructionUITask.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_InstructionUITask.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InstructionUITask.InitDataFromUIIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_InstructionUITask.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_InstructionUITask.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_InstructionUITask.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InstructionUITask.IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_InstructionUITask.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_InstructionUITask.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_InstructionUITask.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InstructionUITask.InitAllUIControllers);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_InstructionUITask.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_InstructionUITask.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_InstructionUITask.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InstructionUITask.ClearAllContextAndRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_InstructionUITask.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_InstructionUITask.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_InstructionUITask.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InstructionUITask.UpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_InstructionUITask.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_InstructionUITask.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_InstructionUITask.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InstructionUITask.InstructionUIController_OnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_InstructionUITask.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_InstructionUITask.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_InstructionUITask.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InstructionUITask.__callBase_OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_InstructionUITask.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_InstructionUITask.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_InstructionUITask.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InstructionUITask.__callBase_OnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_InstructionUITask.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_InstructionUITask.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_InstructionUITask.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InstructionUITask.__callBase_OnPause);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_InstructionUITask.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_InstructionUITask.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_InstructionUITask.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InstructionUITask.__callBase_OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_InstructionUITask.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_InstructionUITask.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_InstructionUITask.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InstructionUITask.__callBase_OnNewIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_InstructionUITask.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_InstructionUITask.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_InstructionUITask.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InstructionUITask.__callBase_EnableUIInput);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_InstructionUITask.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_InstructionUITask.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_InstructionUITask.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InstructionUITask.__callBase_IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_InstructionUITask.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_InstructionUITask.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_InstructionUITask.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InstructionUITask.__callBase_CollectAllDynamicResForLoad);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_InstructionUITask.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_InstructionUITask.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_InstructionUITask.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InstructionUITask.__callBase_RegisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_InstructionUITask.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_InstructionUITask.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_InstructionUITask.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InstructionUITask.__callBase_UnregisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_InstructionUITask.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_InstructionUITask.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_InstructionUITask.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InstructionUITask.__callBase_PostUpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_InstructionUITask.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_InstructionUITask.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_InstructionUITask.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InstructionUITask.__callBase_CollectPreloadResourceList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_InstructionUITask.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_InstructionUITask.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_InstructionUITask.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InstructionUITask.__callBase_ClearAssetList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_InstructionUITask.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_InstructionUITask.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_InstructionUITask.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InstructionUITask.__callBase_CollectAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_InstructionUITask.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_InstructionUITask.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_InstructionUITask.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InstructionUITask.__callBase_CollectSpriteAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_InstructionUITask.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_InstructionUITask.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_InstructionUITask.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InstructionUITask.__callBase_CollectFxAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_InstructionUITask.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_InstructionUITask.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_InstructionUITask.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InstructionUITask.__callBase_StartLoadCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_InstructionUITask.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_InstructionUITask.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_InstructionUITask.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InstructionUITask.__callBase_IsLoadingCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_InstructionUITask.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_InstructionUITask.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_InstructionUITask.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InstructionUITask.__callBase_IsPipeLineRunning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_InstructionUITask.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_InstructionUITask.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_InstructionUITask.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InstructionUITask.__callBase_IsOpeningUI);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_InstructionUITask.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_InstructionUITask.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_InstructionUITask.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InstructionUITask.__callBase_ReturnPrevUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_InstructionUITask.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_InstructionUITask.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_InstructionUITask.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InstructionUITask.__callBase_ClearUnusedDynamicResourceCache);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_InstructionUITask.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_InstructionUITask.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_InstructionUITask.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InstructionUITask.__callBase_OnMemoryWarning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_InstructionUITask.<>f__mg$cache1F);
		string name = "m_layerDescArray";
		if (Lua_BlackJack_ProjectL_UI_InstructionUITask.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_InstructionUITask.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InstructionUITask.get_m_layerDescArray);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_InstructionUITask.<>f__mg$cache20;
		if (Lua_BlackJack_ProjectL_UI_InstructionUITask.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_InstructionUITask.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InstructionUITask.set_m_layerDescArray);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_InstructionUITask.<>f__mg$cache21, true);
		string name2 = "m_uiCtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_InstructionUITask.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_InstructionUITask.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InstructionUITask.get_m_uiCtrlDescArray);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_InstructionUITask.<>f__mg$cache22;
		if (Lua_BlackJack_ProjectL_UI_InstructionUITask.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_InstructionUITask.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InstructionUITask.set_m_uiCtrlDescArray);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_InstructionUITask.<>f__mg$cache23, true);
		string name3 = "m_instructionUIController";
		if (Lua_BlackJack_ProjectL_UI_InstructionUITask.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_InstructionUITask.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InstructionUITask.get_m_instructionUIController);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_InstructionUITask.<>f__mg$cache24;
		if (Lua_BlackJack_ProjectL_UI_InstructionUITask.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_InstructionUITask.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InstructionUITask.set_m_instructionUIController);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_InstructionUITask.<>f__mg$cache25, true);
		string name4 = "m_prefabName";
		if (Lua_BlackJack_ProjectL_UI_InstructionUITask.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_InstructionUITask.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InstructionUITask.get_m_prefabName);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_InstructionUITask.<>f__mg$cache26;
		if (Lua_BlackJack_ProjectL_UI_InstructionUITask.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_InstructionUITask.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InstructionUITask.set_m_prefabName);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_InstructionUITask.<>f__mg$cache27, true);
		string name5 = "LayerDescArray";
		if (Lua_BlackJack_ProjectL_UI_InstructionUITask.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_InstructionUITask.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InstructionUITask.get_LayerDescArray);
		}
		LuaObject.addMember(l, name5, Lua_BlackJack_ProjectL_UI_InstructionUITask.<>f__mg$cache28, null, true);
		string name6 = "UICtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_InstructionUITask.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_InstructionUITask.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InstructionUITask.get_UICtrlDescArray);
		}
		LuaObject.addMember(l, name6, Lua_BlackJack_ProjectL_UI_InstructionUITask.<>f__mg$cache29, null, true);
		if (Lua_BlackJack_ProjectL_UI_InstructionUITask.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_InstructionUITask.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InstructionUITask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_InstructionUITask.<>f__mg$cache2A, typeof(InstructionUITask), typeof(UITask));
	}

	// Token: 0x04015A37 RID: 88631
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04015A38 RID: 88632
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04015A39 RID: 88633
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04015A3A RID: 88634
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04015A3B RID: 88635
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04015A3C RID: 88636
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04015A3D RID: 88637
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04015A3E RID: 88638
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04015A3F RID: 88639
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04015A40 RID: 88640
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04015A41 RID: 88641
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04015A42 RID: 88642
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04015A43 RID: 88643
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04015A44 RID: 88644
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04015A45 RID: 88645
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04015A46 RID: 88646
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04015A47 RID: 88647
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04015A48 RID: 88648
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04015A49 RID: 88649
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04015A4A RID: 88650
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04015A4B RID: 88651
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04015A4C RID: 88652
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04015A4D RID: 88653
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04015A4E RID: 88654
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04015A4F RID: 88655
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04015A50 RID: 88656
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04015A51 RID: 88657
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04015A52 RID: 88658
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04015A53 RID: 88659
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04015A54 RID: 88660
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04015A55 RID: 88661
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04015A56 RID: 88662
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04015A57 RID: 88663
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04015A58 RID: 88664
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04015A59 RID: 88665
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04015A5A RID: 88666
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04015A5B RID: 88667
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04015A5C RID: 88668
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04015A5D RID: 88669
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04015A5E RID: 88670
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04015A5F RID: 88671
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04015A60 RID: 88672
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04015A61 RID: 88673
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;
}
