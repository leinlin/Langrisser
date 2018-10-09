using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001391 RID: 5009
[Preserve]
public class Lua_BlackJack_ProjectL_UI_BagFullUITask : LuaObject
{
	// Token: 0x0601B4F3 RID: 111859 RVA: 0x00841EC0 File Offset: 0x008400C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			string name;
			LuaObject.checkType(l, 2, out name);
			BagFullUITask o = new BagFullUITask(name);
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

	// Token: 0x0601B4F4 RID: 111860 RVA: 0x00841F14 File Offset: 0x00840114
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartUITask_s(IntPtr l)
	{
		int result;
		try
		{
			UIIntent uiIntent;
			LuaObject.checkType<UIIntent>(l, 1, out uiIntent);
			BagFullUITask.StartUITask(uiIntent);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B4F5 RID: 111861 RVA: 0x00841F60 File Offset: 0x00840160
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnStart(IntPtr l)
	{
		int result;
		try
		{
			BagFullUITask bagFullUITask = (BagFullUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = bagFullUITask.m_luaExportHelper.OnStart(intent);
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

	// Token: 0x0601B4F6 RID: 111862 RVA: 0x00841FC8 File Offset: 0x008401C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnResume(IntPtr l)
	{
		int result;
		try
		{
			BagFullUITask bagFullUITask = (BagFullUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = bagFullUITask.m_luaExportHelper.OnResume(intent);
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

	// Token: 0x0601B4F7 RID: 111863 RVA: 0x00842030 File Offset: 0x00840230
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitDataFromUIIntent(IntPtr l)
	{
		int result;
		try
		{
			BagFullUITask bagFullUITask = (BagFullUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bagFullUITask.m_luaExportHelper.InitDataFromUIIntent(intent);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B4F8 RID: 111864 RVA: 0x0084208C File Offset: 0x0084028C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitAllUIControllers(IntPtr l)
	{
		int result;
		try
		{
			BagFullUITask bagFullUITask = (BagFullUITask)LuaObject.checkSelf(l);
			bagFullUITask.m_luaExportHelper.InitAllUIControllers();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B4F9 RID: 111865 RVA: 0x008420E0 File Offset: 0x008402E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearAllContextAndRes(IntPtr l)
	{
		int result;
		try
		{
			BagFullUITask bagFullUITask = (BagFullUITask)LuaObject.checkSelf(l);
			bagFullUITask.m_luaExportHelper.ClearAllContextAndRes();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B4FA RID: 111866 RVA: 0x00842134 File Offset: 0x00840334
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateView(IntPtr l)
	{
		int result;
		try
		{
			BagFullUITask bagFullUITask = (BagFullUITask)LuaObject.checkSelf(l);
			bagFullUITask.m_luaExportHelper.UpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B4FB RID: 111867 RVA: 0x00842188 File Offset: 0x00840388
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BagFullUIController_OnReturn(IntPtr l)
	{
		int result;
		try
		{
			BagFullUITask bagFullUITask = (BagFullUITask)LuaObject.checkSelf(l);
			bagFullUITask.m_luaExportHelper.BagFullUIController_OnReturn();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B4FC RID: 111868 RVA: 0x008421DC File Offset: 0x008403DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BagFullUIController_OnGotoBag(IntPtr l)
	{
		int result;
		try
		{
			BagFullUITask bagFullUITask = (BagFullUITask)LuaObject.checkSelf(l);
			bagFullUITask.m_luaExportHelper.BagFullUIController_OnGotoBag();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B4FD RID: 111869 RVA: 0x00842230 File Offset: 0x00840430
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BagListUITask_OnLoadAllResCompleted(IntPtr l)
	{
		int result;
		try
		{
			BagFullUITask bagFullUITask = (BagFullUITask)LuaObject.checkSelf(l);
			bagFullUITask.m_luaExportHelper.BagListUITask_OnLoadAllResCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B4FE RID: 111870 RVA: 0x00842284 File Offset: 0x00840484
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStart(IntPtr l)
	{
		int result;
		try
		{
			BagFullUITask bagFullUITask = (BagFullUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = bagFullUITask.m_luaExportHelper.__callBase_OnStart(intent);
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

	// Token: 0x0601B4FF RID: 111871 RVA: 0x008422EC File Offset: 0x008404EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStop(IntPtr l)
	{
		int result;
		try
		{
			BagFullUITask bagFullUITask = (BagFullUITask)LuaObject.checkSelf(l);
			bagFullUITask.m_luaExportHelper.__callBase_OnStop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B500 RID: 111872 RVA: 0x00842340 File Offset: 0x00840540
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnPause(IntPtr l)
	{
		int result;
		try
		{
			BagFullUITask bagFullUITask = (BagFullUITask)LuaObject.checkSelf(l);
			bagFullUITask.m_luaExportHelper.__callBase_OnPause();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B501 RID: 111873 RVA: 0x00842394 File Offset: 0x00840594
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnResume(IntPtr l)
	{
		int result;
		try
		{
			BagFullUITask bagFullUITask = (BagFullUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = bagFullUITask.m_luaExportHelper.__callBase_OnResume(intent);
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

	// Token: 0x0601B502 RID: 111874 RVA: 0x008423FC File Offset: 0x008405FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnNewIntent(IntPtr l)
	{
		int result;
		try
		{
			BagFullUITask bagFullUITask = (BagFullUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = bagFullUITask.m_luaExportHelper.__callBase_OnNewIntent(intent);
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

	// Token: 0x0601B503 RID: 111875 RVA: 0x00842464 File Offset: 0x00840664
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_EnableUIInput(IntPtr l)
	{
		int result;
		try
		{
			BagFullUITask bagFullUITask = (BagFullUITask)LuaObject.checkSelf(l);
			bool isEnable;
			LuaObject.checkType(l, 2, out isEnable);
			bool? isGlobalEnable;
			LuaObject.checkNullable<bool>(l, 3, out isGlobalEnable);
			bagFullUITask.m_luaExportHelper.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B504 RID: 111876 RVA: 0x008424D0 File Offset: 0x008406D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			BagFullUITask bagFullUITask = (BagFullUITask)LuaObject.checkSelf(l);
			bool b = bagFullUITask.m_luaExportHelper.__callBase_IsNeedLoadDynamicRes();
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

	// Token: 0x0601B505 RID: 111877 RVA: 0x0084252C File Offset: 0x0084072C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAllDynamicResForLoad(IntPtr l)
	{
		int result;
		try
		{
			BagFullUITask bagFullUITask = (BagFullUITask)LuaObject.checkSelf(l);
			List<string> o = bagFullUITask.m_luaExportHelper.__callBase_CollectAllDynamicResForLoad();
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

	// Token: 0x0601B506 RID: 111878 RVA: 0x00842588 File Offset: 0x00840788
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_RegisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			BagFullUITask bagFullUITask = (BagFullUITask)LuaObject.checkSelf(l);
			bagFullUITask.m_luaExportHelper.__callBase_RegisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B507 RID: 111879 RVA: 0x008425DC File Offset: 0x008407DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_UnregisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			BagFullUITask bagFullUITask = (BagFullUITask)LuaObject.checkSelf(l);
			bagFullUITask.m_luaExportHelper.__callBase_UnregisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B508 RID: 111880 RVA: 0x00842630 File Offset: 0x00840830
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PostUpdateView(IntPtr l)
	{
		int result;
		try
		{
			BagFullUITask bagFullUITask = (BagFullUITask)LuaObject.checkSelf(l);
			bagFullUITask.m_luaExportHelper.__callBase_PostUpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B509 RID: 111881 RVA: 0x00842684 File Offset: 0x00840884
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectPreloadResourceList(IntPtr l)
	{
		int result;
		try
		{
			BagFullUITask bagFullUITask = (BagFullUITask)LuaObject.checkSelf(l);
			bagFullUITask.m_luaExportHelper.__callBase_CollectPreloadResourceList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B50A RID: 111882 RVA: 0x008426D8 File Offset: 0x008408D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearAssetList(IntPtr l)
	{
		int result;
		try
		{
			BagFullUITask bagFullUITask = (BagFullUITask)LuaObject.checkSelf(l);
			bagFullUITask.m_luaExportHelper.__callBase_ClearAssetList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B50B RID: 111883 RVA: 0x0084272C File Offset: 0x0084092C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAsset(IntPtr l)
	{
		int result;
		try
		{
			BagFullUITask bagFullUITask = (BagFullUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			bagFullUITask.m_luaExportHelper.__callBase_CollectAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B50C RID: 111884 RVA: 0x00842788 File Offset: 0x00840988
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectSpriteAsset(IntPtr l)
	{
		int result;
		try
		{
			BagFullUITask bagFullUITask = (BagFullUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			bagFullUITask.m_luaExportHelper.__callBase_CollectSpriteAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B50D RID: 111885 RVA: 0x008427E4 File Offset: 0x008409E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectFxAsset(IntPtr l)
	{
		int result;
		try
		{
			BagFullUITask bagFullUITask = (BagFullUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			bagFullUITask.m_luaExportHelper.__callBase_CollectFxAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B50E RID: 111886 RVA: 0x00842840 File Offset: 0x00840A40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_StartLoadCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			BagFullUITask bagFullUITask = (BagFullUITask)LuaObject.checkSelf(l);
			Action onLoadCompleted;
			LuaObject.checkDelegate<Action>(l, 2, out onLoadCompleted);
			bagFullUITask.m_luaExportHelper.__callBase_StartLoadCustomAssets(onLoadCompleted);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B50F RID: 111887 RVA: 0x0084289C File Offset: 0x00840A9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsLoadingCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			BagFullUITask bagFullUITask = (BagFullUITask)LuaObject.checkSelf(l);
			bool b = bagFullUITask.m_luaExportHelper.__callBase_IsLoadingCustomAssets();
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

	// Token: 0x0601B510 RID: 111888 RVA: 0x008428F8 File Offset: 0x00840AF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsPipeLineRunning(IntPtr l)
	{
		int result;
		try
		{
			BagFullUITask bagFullUITask = (BagFullUITask)LuaObject.checkSelf(l);
			bool b = bagFullUITask.m_luaExportHelper.__callBase_IsPipeLineRunning();
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

	// Token: 0x0601B511 RID: 111889 RVA: 0x00842954 File Offset: 0x00840B54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsOpeningUI(IntPtr l)
	{
		int result;
		try
		{
			BagFullUITask bagFullUITask = (BagFullUITask)LuaObject.checkSelf(l);
			bool b = bagFullUITask.m_luaExportHelper.__callBase_IsOpeningUI();
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

	// Token: 0x0601B512 RID: 111890 RVA: 0x008429B0 File Offset: 0x00840BB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ReturnPrevUITask(IntPtr l)
	{
		int result;
		try
		{
			BagFullUITask bagFullUITask = (BagFullUITask)LuaObject.checkSelf(l);
			UITaskBase o = bagFullUITask.m_luaExportHelper.__callBase_ReturnPrevUITask();
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

	// Token: 0x0601B513 RID: 111891 RVA: 0x00842A0C File Offset: 0x00840C0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearUnusedDynamicResourceCache(IntPtr l)
	{
		int result;
		try
		{
			BagFullUITask bagFullUITask = (BagFullUITask)LuaObject.checkSelf(l);
			bagFullUITask.m_luaExportHelper.__callBase_ClearUnusedDynamicResourceCache();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B514 RID: 111892 RVA: 0x00842A60 File Offset: 0x00840C60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnMemoryWarning(IntPtr l)
	{
		int result;
		try
		{
			BagFullUITask bagFullUITask = (BagFullUITask)LuaObject.checkSelf(l);
			bagFullUITask.m_luaExportHelper.__callBase_OnMemoryWarning();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B515 RID: 111893 RVA: 0x00842AB4 File Offset: 0x00840CB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			BagFullUITask bagFullUITask = (BagFullUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagFullUITask.m_luaExportHelper.m_layerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B516 RID: 111894 RVA: 0x00842B0C File Offset: 0x00840D0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			BagFullUITask bagFullUITask = (BagFullUITask)LuaObject.checkSelf(l);
			UITaskBase.LayerDesc[] layerDescArray;
			LuaObject.checkArray<UITaskBase.LayerDesc>(l, 2, out layerDescArray);
			bagFullUITask.m_luaExportHelper.m_layerDescArray = layerDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B517 RID: 111895 RVA: 0x00842B68 File Offset: 0x00840D68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			BagFullUITask bagFullUITask = (BagFullUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagFullUITask.m_luaExportHelper.m_uiCtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B518 RID: 111896 RVA: 0x00842BC0 File Offset: 0x00840DC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			BagFullUITask bagFullUITask = (BagFullUITask)LuaObject.checkSelf(l);
			UITaskBase.UIControllerDesc[] uiCtrlDescArray;
			LuaObject.checkArray<UITaskBase.UIControllerDesc>(l, 2, out uiCtrlDescArray);
			bagFullUITask.m_luaExportHelper.m_uiCtrlDescArray = uiCtrlDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B519 RID: 111897 RVA: 0x00842C1C File Offset: 0x00840E1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_bagFullUIController(IntPtr l)
	{
		int result;
		try
		{
			BagFullUITask bagFullUITask = (BagFullUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagFullUITask.m_luaExportHelper.m_bagFullUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B51A RID: 111898 RVA: 0x00842C74 File Offset: 0x00840E74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_bagFullUIController(IntPtr l)
	{
		int result;
		try
		{
			BagFullUITask bagFullUITask = (BagFullUITask)LuaObject.checkSelf(l);
			BagFullUIController bagFullUIController;
			LuaObject.checkType<BagFullUIController>(l, 2, out bagFullUIController);
			bagFullUITask.m_luaExportHelper.m_bagFullUIController = bagFullUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B51B RID: 111899 RVA: 0x00842CD0 File Offset: 0x00840ED0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_lastUIIntent(IntPtr l)
	{
		int result;
		try
		{
			BagFullUITask bagFullUITask = (BagFullUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagFullUITask.m_luaExportHelper.m_lastUIIntent);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B51C RID: 111900 RVA: 0x00842D28 File Offset: 0x00840F28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_lastUIIntent(IntPtr l)
	{
		int result;
		try
		{
			BagFullUITask bagFullUITask = (BagFullUITask)LuaObject.checkSelf(l);
			UIIntent lastUIIntent;
			LuaObject.checkType<UIIntent>(l, 2, out lastUIIntent);
			bagFullUITask.m_luaExportHelper.m_lastUIIntent = lastUIIntent;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B51D RID: 111901 RVA: 0x00842D84 File Offset: 0x00840F84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LayerDescArray(IntPtr l)
	{
		int result;
		try
		{
			BagFullUITask bagFullUITask = (BagFullUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagFullUITask.m_luaExportHelper.LayerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B51E RID: 111902 RVA: 0x00842DDC File Offset: 0x00840FDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_UICtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			BagFullUITask bagFullUITask = (BagFullUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagFullUITask.m_luaExportHelper.UICtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B51F RID: 111903 RVA: 0x00842E34 File Offset: 0x00841034
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.BagFullUITask");
		if (Lua_BlackJack_ProjectL_UI_BagFullUITask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagFullUITask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagFullUITask.StartUITask_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagFullUITask.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_BagFullUITask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagFullUITask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagFullUITask.OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagFullUITask.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_BagFullUITask.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagFullUITask.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagFullUITask.OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagFullUITask.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_BagFullUITask.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagFullUITask.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagFullUITask.InitDataFromUIIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagFullUITask.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_BagFullUITask.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagFullUITask.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagFullUITask.InitAllUIControllers);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagFullUITask.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_BagFullUITask.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagFullUITask.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagFullUITask.ClearAllContextAndRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagFullUITask.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_BagFullUITask.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagFullUITask.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagFullUITask.UpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagFullUITask.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_BagFullUITask.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagFullUITask.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagFullUITask.BagFullUIController_OnReturn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagFullUITask.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_BagFullUITask.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagFullUITask.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagFullUITask.BagFullUIController_OnGotoBag);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagFullUITask.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_BagFullUITask.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagFullUITask.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagFullUITask.BagListUITask_OnLoadAllResCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagFullUITask.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_BagFullUITask.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_BagFullUITask.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagFullUITask.__callBase_OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagFullUITask.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_BagFullUITask.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_BagFullUITask.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagFullUITask.__callBase_OnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagFullUITask.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_BagFullUITask.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_BagFullUITask.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagFullUITask.__callBase_OnPause);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagFullUITask.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_BagFullUITask.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_BagFullUITask.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagFullUITask.__callBase_OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagFullUITask.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_BagFullUITask.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_BagFullUITask.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagFullUITask.__callBase_OnNewIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagFullUITask.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_BagFullUITask.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_BagFullUITask.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagFullUITask.__callBase_EnableUIInput);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagFullUITask.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_BagFullUITask.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagFullUITask.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagFullUITask.__callBase_IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagFullUITask.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_BagFullUITask.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagFullUITask.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagFullUITask.__callBase_CollectAllDynamicResForLoad);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagFullUITask.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_BagFullUITask.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagFullUITask.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagFullUITask.__callBase_RegisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagFullUITask.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_BagFullUITask.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagFullUITask.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagFullUITask.__callBase_UnregisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagFullUITask.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_BagFullUITask.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagFullUITask.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagFullUITask.__callBase_PostUpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagFullUITask.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_BagFullUITask.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagFullUITask.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagFullUITask.__callBase_CollectPreloadResourceList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagFullUITask.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_BagFullUITask.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagFullUITask.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagFullUITask.__callBase_ClearAssetList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagFullUITask.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_BagFullUITask.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagFullUITask.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagFullUITask.__callBase_CollectAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagFullUITask.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_BagFullUITask.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagFullUITask.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagFullUITask.__callBase_CollectSpriteAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagFullUITask.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_BagFullUITask.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagFullUITask.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagFullUITask.__callBase_CollectFxAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagFullUITask.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_BagFullUITask.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_BagFullUITask.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagFullUITask.__callBase_StartLoadCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagFullUITask.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_BagFullUITask.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_BagFullUITask.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagFullUITask.__callBase_IsLoadingCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagFullUITask.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_BagFullUITask.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_BagFullUITask.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagFullUITask.__callBase_IsPipeLineRunning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagFullUITask.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_BagFullUITask.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_BagFullUITask.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagFullUITask.__callBase_IsOpeningUI);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagFullUITask.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_BagFullUITask.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_BagFullUITask.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagFullUITask.__callBase_ReturnPrevUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagFullUITask.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_BagFullUITask.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_BagFullUITask.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagFullUITask.__callBase_ClearUnusedDynamicResourceCache);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagFullUITask.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_BagFullUITask.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagFullUITask.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagFullUITask.__callBase_OnMemoryWarning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagFullUITask.<>f__mg$cache20);
		string name = "m_layerDescArray";
		if (Lua_BlackJack_ProjectL_UI_BagFullUITask.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagFullUITask.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagFullUITask.get_m_layerDescArray);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_BagFullUITask.<>f__mg$cache21;
		if (Lua_BlackJack_ProjectL_UI_BagFullUITask.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagFullUITask.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagFullUITask.set_m_layerDescArray);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_BagFullUITask.<>f__mg$cache22, true);
		string name2 = "m_uiCtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_BagFullUITask.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagFullUITask.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagFullUITask.get_m_uiCtrlDescArray);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_BagFullUITask.<>f__mg$cache23;
		if (Lua_BlackJack_ProjectL_UI_BagFullUITask.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagFullUITask.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagFullUITask.set_m_uiCtrlDescArray);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_BagFullUITask.<>f__mg$cache24, true);
		string name3 = "m_bagFullUIController";
		if (Lua_BlackJack_ProjectL_UI_BagFullUITask.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagFullUITask.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagFullUITask.get_m_bagFullUIController);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_BagFullUITask.<>f__mg$cache25;
		if (Lua_BlackJack_ProjectL_UI_BagFullUITask.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagFullUITask.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagFullUITask.set_m_bagFullUIController);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_BagFullUITask.<>f__mg$cache26, true);
		string name4 = "m_lastUIIntent";
		if (Lua_BlackJack_ProjectL_UI_BagFullUITask.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagFullUITask.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagFullUITask.get_m_lastUIIntent);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_BagFullUITask.<>f__mg$cache27;
		if (Lua_BlackJack_ProjectL_UI_BagFullUITask.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagFullUITask.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagFullUITask.set_m_lastUIIntent);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_BagFullUITask.<>f__mg$cache28, true);
		string name5 = "LayerDescArray";
		if (Lua_BlackJack_ProjectL_UI_BagFullUITask.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagFullUITask.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagFullUITask.get_LayerDescArray);
		}
		LuaObject.addMember(l, name5, Lua_BlackJack_ProjectL_UI_BagFullUITask.<>f__mg$cache29, null, true);
		string name6 = "UICtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_BagFullUITask.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_BagFullUITask.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagFullUITask.get_UICtrlDescArray);
		}
		LuaObject.addMember(l, name6, Lua_BlackJack_ProjectL_UI_BagFullUITask.<>f__mg$cache2A, null, true);
		if (Lua_BlackJack_ProjectL_UI_BagFullUITask.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_BagFullUITask.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagFullUITask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_BagFullUITask.<>f__mg$cache2B, typeof(BagFullUITask), typeof(UITask));
	}

	// Token: 0x040117B3 RID: 71603
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040117B4 RID: 71604
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040117B5 RID: 71605
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040117B6 RID: 71606
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040117B7 RID: 71607
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040117B8 RID: 71608
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040117B9 RID: 71609
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040117BA RID: 71610
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x040117BB RID: 71611
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x040117BC RID: 71612
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x040117BD RID: 71613
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x040117BE RID: 71614
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x040117BF RID: 71615
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x040117C0 RID: 71616
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x040117C1 RID: 71617
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x040117C2 RID: 71618
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x040117C3 RID: 71619
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x040117C4 RID: 71620
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x040117C5 RID: 71621
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x040117C6 RID: 71622
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x040117C7 RID: 71623
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x040117C8 RID: 71624
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x040117C9 RID: 71625
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x040117CA RID: 71626
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x040117CB RID: 71627
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x040117CC RID: 71628
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x040117CD RID: 71629
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x040117CE RID: 71630
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x040117CF RID: 71631
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x040117D0 RID: 71632
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x040117D1 RID: 71633
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x040117D2 RID: 71634
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x040117D3 RID: 71635
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x040117D4 RID: 71636
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x040117D5 RID: 71637
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x040117D6 RID: 71638
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x040117D7 RID: 71639
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x040117D8 RID: 71640
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x040117D9 RID: 71641
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x040117DA RID: 71642
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x040117DB RID: 71643
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x040117DC RID: 71644
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x040117DD RID: 71645
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x040117DE RID: 71646
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;
}
