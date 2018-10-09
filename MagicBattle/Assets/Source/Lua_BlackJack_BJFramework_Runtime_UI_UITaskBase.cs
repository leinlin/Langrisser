using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Scene;
using BlackJack.BJFramework.Runtime.TaskNs;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.Utils;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x0200112C RID: 4396
[Preserve]
public class Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase : LuaObject
{
	// Token: 0x06015E41 RID: 89665 RVA: 0x005AB840 File Offset: 0x005A9A40
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			string name;
			LuaObject.checkType(l, 2, out name);
			UITaskBase o = new UITaskBase(name);
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

	// Token: 0x06015E42 RID: 89666 RVA: 0x005AB894 File Offset: 0x005A9A94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitlizeBeforeManagerStartIt(IntPtr l)
	{
		int result;
		try
		{
			UITaskBase uitaskBase = (UITaskBase)LuaObject.checkSelf(l);
			uitaskBase.InitlizeBeforeManagerStartIt();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015E43 RID: 89667 RVA: 0x005AB8E0 File Offset: 0x005A9AE0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int PrepareForStartOrResume(IntPtr l)
	{
		int result;
		try
		{
			UITaskBase uitaskBase = (UITaskBase)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			Action<bool> onPrepareEnd;
			LuaObject.checkDelegate<Action<bool>>(l, 3, out onPrepareEnd);
			uitaskBase.PrepareForStartOrResume(intent, onPrepareEnd);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015E44 RID: 89668 RVA: 0x005AB944 File Offset: 0x005A9B44
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnNewIntent(IntPtr l)
	{
		int result;
		try
		{
			UITaskBase uitaskBase = (UITaskBase)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = uitaskBase.OnNewIntent(intent);
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

	// Token: 0x06015E45 RID: 89669 RVA: 0x005AB9A8 File Offset: 0x005A9BA8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int RedirectPipLineOnAllResReady(IntPtr l)
	{
		int result;
		try
		{
			UITaskBase uitaskBase = (UITaskBase)LuaObject.checkSelf(l);
			Action callBack;
			LuaObject.checkDelegate<Action>(l, 2, out callBack);
			uitaskBase.RedirectPipLineOnAllResReady(callBack);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015E46 RID: 89670 RVA: 0x005ABA00 File Offset: 0x005A9C00
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ReturnFromRedirectPipLineOnLoadAllResCompleted(IntPtr l)
	{
		int result;
		try
		{
			UITaskBase uitaskBase = (UITaskBase)LuaObject.checkSelf(l);
			uitaskBase.ReturnFromRedirectPipLineOnLoadAllResCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015E47 RID: 89671 RVA: 0x005ABA4C File Offset: 0x005A9C4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int EnableUIInput(IntPtr l)
	{
		int result;
		try
		{
			UITaskBase uitaskBase = (UITaskBase)LuaObject.checkSelf(l);
			bool isEnable;
			LuaObject.checkType(l, 2, out isEnable);
			bool? isGlobalEnable;
			LuaObject.checkNullable<bool>(l, 3, out isGlobalEnable);
			uitaskBase.EnableUIInput(isEnable, isGlobalEnable);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015E48 RID: 89672 RVA: 0x005ABAB0 File Offset: 0x005A9CB0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int PostDelayTimeExecuteAction(IntPtr l)
	{
		int result;
		try
		{
			UITaskBase uitaskBase = (UITaskBase)LuaObject.checkSelf(l);
			Action action;
			LuaObject.checkDelegate<Action>(l, 2, out action);
			float delaySeconds;
			LuaObject.checkType(l, 3, out delaySeconds);
			uitaskBase.PostDelayTimeExecuteAction(action, delaySeconds);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015E49 RID: 89673 RVA: 0x005ABB14 File Offset: 0x005A9D14
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int PostDelayTicksExecuteAction(IntPtr l)
	{
		int result;
		try
		{
			UITaskBase uitaskBase = (UITaskBase)LuaObject.checkSelf(l);
			Action action;
			LuaObject.checkDelegate<Action>(l, 2, out action);
			ulong delayTickCount;
			LuaObject.checkType(l, 3, out delayTickCount);
			uitaskBase.PostDelayTicksExecuteAction(action, delayTickCount);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015E4A RID: 89674 RVA: 0x005ABB78 File Offset: 0x005A9D78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HasTag(IntPtr l)
	{
		int result;
		try
		{
			UITaskBase uitaskBase = (UITaskBase)LuaObject.checkSelf(l);
			string tag;
			LuaObject.checkType(l, 2, out tag);
			bool b = uitaskBase.HasTag(tag);
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

	// Token: 0x06015E4B RID: 89675 RVA: 0x005ABBDC File Offset: 0x005A9DDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnStart(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(object)))
			{
				UITaskBase uitaskBase = (UITaskBase)LuaObject.checkSelf(l);
				object param;
				LuaObject.checkType<object>(l, 2, out param);
				bool b = uitaskBase.m_luaExportHelper.OnStart(param);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(UIIntent)))
			{
				UITaskBase uitaskBase2 = (UITaskBase)LuaObject.checkSelf(l);
				UIIntent intent;
				LuaObject.checkType<UIIntent>(l, 2, out intent);
				bool b2 = uitaskBase2.m_luaExportHelper.OnStart(intent);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function OnStart to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015E4C RID: 89676 RVA: 0x005ABCD4 File Offset: 0x005A9ED4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetPipeLineCtx(IntPtr l)
	{
		int result;
		try
		{
			UITaskBase uitaskBase = (UITaskBase)LuaObject.checkSelf(l);
			UITaskPipeLineCtx pipeLineCtx = uitaskBase.m_luaExportHelper.GetPipeLineCtx();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, pipeLineCtx);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015E4D RID: 89677 RVA: 0x005ABD30 File Offset: 0x005A9F30
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CreatePipeLineCtx(IntPtr l)
	{
		int result;
		try
		{
			UITaskBase uitaskBase = (UITaskBase)LuaObject.checkSelf(l);
			UITaskPipeLineCtx o = uitaskBase.m_luaExportHelper.CreatePipeLineCtx();
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

	// Token: 0x06015E4E RID: 89678 RVA: 0x005ABD8C File Offset: 0x005A9F8C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnStop(IntPtr l)
	{
		int result;
		try
		{
			UITaskBase uitaskBase = (UITaskBase)LuaObject.checkSelf(l);
			uitaskBase.m_luaExportHelper.OnStop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015E4F RID: 89679 RVA: 0x005ABDE0 File Offset: 0x005A9FE0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnPause(IntPtr l)
	{
		int result;
		try
		{
			UITaskBase uitaskBase = (UITaskBase)LuaObject.checkSelf(l);
			uitaskBase.m_luaExportHelper.OnPause();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015E50 RID: 89680 RVA: 0x005ABE34 File Offset: 0x005AA034
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnResume(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(object)))
			{
				UITaskBase uitaskBase = (UITaskBase)LuaObject.checkSelf(l);
				object param;
				LuaObject.checkType<object>(l, 2, out param);
				bool b = uitaskBase.m_luaExportHelper.OnResume(param);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(UIIntent)))
			{
				UITaskBase uitaskBase2 = (UITaskBase)LuaObject.checkSelf(l);
				UIIntent intent;
				LuaObject.checkType<UIIntent>(l, 2, out intent);
				bool b2 = uitaskBase2.m_luaExportHelper.OnResume(intent);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function OnResume to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015E51 RID: 89681 RVA: 0x005ABF2C File Offset: 0x005AA12C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartUpdatePipeLine(IntPtr l)
	{
		int result;
		try
		{
			UITaskBase uitaskBase = (UITaskBase)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool onlyUpdateView;
			LuaObject.checkType(l, 3, out onlyUpdateView);
			bool canBeSkip;
			LuaObject.checkType(l, 4, out canBeSkip);
			bool enableQueue;
			LuaObject.checkType(l, 5, out enableQueue);
			bool b = uitaskBase.m_luaExportHelper.StartUpdatePipeLine(intent, onlyUpdateView, canBeSkip, enableQueue);
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

	// Token: 0x06015E52 RID: 89682 RVA: 0x005ABFBC File Offset: 0x005AA1BC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int NeedSkipUpdatePipeLine(IntPtr l)
	{
		int result;
		try
		{
			UITaskBase uitaskBase = (UITaskBase)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool onlyUpdateView;
			LuaObject.checkType(l, 3, out onlyUpdateView);
			bool b = uitaskBase.m_luaExportHelper.NeedSkipUpdatePipeLine(intent, onlyUpdateView);
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

	// Token: 0x06015E53 RID: 89683 RVA: 0x005AC030 File Offset: 0x005AA230
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsNeedUpdateDataCache(IntPtr l)
	{
		int result;
		try
		{
			UITaskBase uitaskBase = (UITaskBase)LuaObject.checkSelf(l);
			bool b = uitaskBase.m_luaExportHelper.IsNeedUpdateDataCache();
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

	// Token: 0x06015E54 RID: 89684 RVA: 0x005AC08C File Offset: 0x005AA28C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateDataCache(IntPtr l)
	{
		int result;
		try
		{
			UITaskBase uitaskBase = (UITaskBase)LuaObject.checkSelf(l);
			uitaskBase.m_luaExportHelper.UpdateDataCache();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015E55 RID: 89685 RVA: 0x005AC0E0 File Offset: 0x005AA2E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsNeedLoadStaticRes(IntPtr l)
	{
		int result;
		try
		{
			UITaskBase uitaskBase = (UITaskBase)LuaObject.checkSelf(l);
			bool b = uitaskBase.m_luaExportHelper.IsNeedLoadStaticRes();
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

	// Token: 0x06015E56 RID: 89686 RVA: 0x005AC13C File Offset: 0x005AA33C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartLoadStaticRes(IntPtr l)
	{
		int result;
		try
		{
			UITaskBase uitaskBase = (UITaskBase)LuaObject.checkSelf(l);
			uitaskBase.m_luaExportHelper.StartLoadStaticRes();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015E57 RID: 89687 RVA: 0x005AC190 File Offset: 0x005AA390
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CheckLayerDescArray(IntPtr l)
	{
		int result;
		try
		{
			UITaskBase uitaskBase = (UITaskBase)LuaObject.checkSelf(l);
			List<UITaskBase.LayerDesc> layerDescArray;
			LuaObject.checkType<List<UITaskBase.LayerDesc>>(l, 2, out layerDescArray);
			uitaskBase.m_luaExportHelper.CheckLayerDescArray(layerDescArray);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015E58 RID: 89688 RVA: 0x005AC1EC File Offset: 0x005AA3EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnLoadStaticResCompleted(IntPtr l)
	{
		int result;
		try
		{
			UITaskBase uitaskBase = (UITaskBase)LuaObject.checkSelf(l);
			uitaskBase.m_luaExportHelper.OnLoadStaticResCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015E59 RID: 89689 RVA: 0x005AC240 File Offset: 0x005AA440
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			UITaskBase uitaskBase = (UITaskBase)LuaObject.checkSelf(l);
			bool b = uitaskBase.m_luaExportHelper.IsNeedLoadDynamicRes();
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

	// Token: 0x06015E5A RID: 89690 RVA: 0x005AC29C File Offset: 0x005AA49C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			UITaskBase uitaskBase = (UITaskBase)LuaObject.checkSelf(l);
			uitaskBase.m_luaExportHelper.StartLoadDynamicRes();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015E5B RID: 89691 RVA: 0x005AC2F0 File Offset: 0x005AA4F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CollectAllDynamicResForLoad(IntPtr l)
	{
		int result;
		try
		{
			UITaskBase uitaskBase = (UITaskBase)LuaObject.checkSelf(l);
			List<string> o = uitaskBase.m_luaExportHelper.CollectAllDynamicResForLoad();
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

	// Token: 0x06015E5C RID: 89692 RVA: 0x005AC34C File Offset: 0x005AA54C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CollectAllStaticResDescForLoad(IntPtr l)
	{
		int result;
		try
		{
			UITaskBase uitaskBase = (UITaskBase)LuaObject.checkSelf(l);
			List<UITaskBase.LayerDesc> o = uitaskBase.m_luaExportHelper.CollectAllStaticResDescForLoad();
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

	// Token: 0x06015E5D RID: 89693 RVA: 0x005AC3A8 File Offset: 0x005AA5A8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CalculateDynamicResReallyNeedLoad(IntPtr l)
	{
		int result;
		try
		{
			UITaskBase uitaskBase = (UITaskBase)LuaObject.checkSelf(l);
			List<string> resPathList;
			LuaObject.checkType<List<string>>(l, 2, out resPathList);
			HashSet<string> o = uitaskBase.m_luaExportHelper.CalculateDynamicResReallyNeedLoad(resPathList);
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

	// Token: 0x06015E5E RID: 89694 RVA: 0x005AC410 File Offset: 0x005AA610
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnLoadDynamicResCompleted(IntPtr l)
	{
		int result;
		try
		{
			UITaskBase uitaskBase = (UITaskBase)LuaObject.checkSelf(l);
			uitaskBase.m_luaExportHelper.OnLoadDynamicResCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015E5F RID: 89695 RVA: 0x005AC464 File Offset: 0x005AA664
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnLoadAllResCompleted(IntPtr l)
	{
		int result;
		try
		{
			UITaskBase uitaskBase = (UITaskBase)LuaObject.checkSelf(l);
			uitaskBase.m_luaExportHelper.OnLoadAllResCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015E60 RID: 89696 RVA: 0x005AC4B8 File Offset: 0x005AA6B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitLayerStateOnLoadAllResCompleted(IntPtr l)
	{
		int result;
		try
		{
			UITaskBase uitaskBase = (UITaskBase)LuaObject.checkSelf(l);
			uitaskBase.m_luaExportHelper.InitLayerStateOnLoadAllResCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015E61 RID: 89697 RVA: 0x005AC50C File Offset: 0x005AA70C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int InitAllUIControllers(IntPtr l)
	{
		int result;
		try
		{
			UITaskBase uitaskBase = (UITaskBase)LuaObject.checkSelf(l);
			uitaskBase.m_luaExportHelper.InitAllUIControllers();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015E62 RID: 89698 RVA: 0x005AC560 File Offset: 0x005AA760
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PostOnLoadAllResCompleted(IntPtr l)
	{
		int result;
		try
		{
			UITaskBase uitaskBase = (UITaskBase)LuaObject.checkSelf(l);
			uitaskBase.m_luaExportHelper.PostOnLoadAllResCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015E63 RID: 89699 RVA: 0x005AC5B4 File Offset: 0x005AA7B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsLoadAllResCompleted(IntPtr l)
	{
		int result;
		try
		{
			UITaskBase uitaskBase = (UITaskBase)LuaObject.checkSelf(l);
			bool b = uitaskBase.m_luaExportHelper.IsLoadAllResCompleted();
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

	// Token: 0x06015E64 RID: 89700 RVA: 0x005AC610 File Offset: 0x005AA810
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartUpdateView(IntPtr l)
	{
		int result;
		try
		{
			UITaskBase uitaskBase = (UITaskBase)LuaObject.checkSelf(l);
			uitaskBase.m_luaExportHelper.StartUpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015E65 RID: 89701 RVA: 0x005AC664 File Offset: 0x005AA864
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateView(IntPtr l)
	{
		int result;
		try
		{
			UITaskBase uitaskBase = (UITaskBase)LuaObject.checkSelf(l);
			uitaskBase.m_luaExportHelper.UpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015E66 RID: 89702 RVA: 0x005AC6B8 File Offset: 0x005AA8B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RegUpdateViewPlayingEffect(IntPtr l)
	{
		int result;
		try
		{
			UITaskBase uitaskBase = (UITaskBase)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			int timeout;
			LuaObject.checkType(l, 3, out timeout);
			Action<string> onTimeOut;
			LuaObject.checkDelegate<Action<string>>(l, 4, out onTimeOut);
			uitaskBase.m_luaExportHelper.RegUpdateViewPlayingEffect(name, timeout, onTimeOut);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015E67 RID: 89703 RVA: 0x005AC730 File Offset: 0x005AA930
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UnregUpdateViewPlayingEffect(IntPtr l)
	{
		int result;
		try
		{
			UITaskBase uitaskBase = (UITaskBase)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			bool isTimeOut;
			LuaObject.checkType(l, 3, out isTimeOut);
			uitaskBase.m_luaExportHelper.UnregUpdateViewPlayingEffect(name, isTimeOut);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015E68 RID: 89704 RVA: 0x005AC79C File Offset: 0x005AA99C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PostUpdateView(IntPtr l)
	{
		int result;
		try
		{
			UITaskBase uitaskBase = (UITaskBase)LuaObject.checkSelf(l);
			uitaskBase.m_luaExportHelper.PostUpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015E69 RID: 89705 RVA: 0x005AC7F0 File Offset: 0x005AA9F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PostUpdateViewBeforeClearContext(IntPtr l)
	{
		int result;
		try
		{
			UITaskBase uitaskBase = (UITaskBase)LuaObject.checkSelf(l);
			uitaskBase.m_luaExportHelper.PostUpdateViewBeforeClearContext();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015E6A RID: 89706 RVA: 0x005AC844 File Offset: 0x005AAA44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HideAllView(IntPtr l)
	{
		int result;
		try
		{
			UITaskBase uitaskBase = (UITaskBase)LuaObject.checkSelf(l);
			uitaskBase.m_luaExportHelper.HideAllView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015E6B RID: 89707 RVA: 0x005AC898 File Offset: 0x005AAA98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearAllContextAndRes(IntPtr l)
	{
		int result;
		try
		{
			UITaskBase uitaskBase = (UITaskBase)LuaObject.checkSelf(l);
			uitaskBase.m_luaExportHelper.ClearAllContextAndRes();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015E6C RID: 89708 RVA: 0x005AC8EC File Offset: 0x005AAAEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SaveContextInIntentOnPause(IntPtr l)
	{
		int result;
		try
		{
			UITaskBase uitaskBase = (UITaskBase)LuaObject.checkSelf(l);
			uitaskBase.m_luaExportHelper.SaveContextInIntentOnPause();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015E6D RID: 89709 RVA: 0x005AC940 File Offset: 0x005AAB40
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ClearContextOnPause(IntPtr l)
	{
		int result;
		try
		{
			UITaskBase uitaskBase = (UITaskBase)LuaObject.checkSelf(l);
			uitaskBase.m_luaExportHelper.ClearContextOnPause();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015E6E RID: 89710 RVA: 0x005AC994 File Offset: 0x005AAB94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearContextOnIntentChange(IntPtr l)
	{
		int result;
		try
		{
			UITaskBase uitaskBase = (UITaskBase)LuaObject.checkSelf(l);
			UIIntent newIntent;
			LuaObject.checkType<UIIntent>(l, 2, out newIntent);
			uitaskBase.m_luaExportHelper.ClearContextOnIntentChange(newIntent);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015E6F RID: 89711 RVA: 0x005AC9F0 File Offset: 0x005AABF0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ClearContextOnUpdateViewEnd(IntPtr l)
	{
		int result;
		try
		{
			UITaskBase uitaskBase = (UITaskBase)LuaObject.checkSelf(l);
			uitaskBase.m_luaExportHelper.ClearContextOnUpdateViewEnd();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015E70 RID: 89712 RVA: 0x005ACA44 File Offset: 0x005AAC44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetLayerDescByName(IntPtr l)
	{
		int result;
		try
		{
			UITaskBase uitaskBase = (UITaskBase)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			UITaskBase.LayerDesc layerDescByName = uitaskBase.m_luaExportHelper.GetLayerDescByName(name);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, layerDescByName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015E71 RID: 89713 RVA: 0x005ACAAC File Offset: 0x005AACAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetLayerByName(IntPtr l)
	{
		int result;
		try
		{
			UITaskBase uitaskBase = (UITaskBase)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			SceneLayerBase layerByName = uitaskBase.m_luaExportHelper.GetLayerByName(name);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, layerByName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015E72 RID: 89714 RVA: 0x005ACB14 File Offset: 0x005AAD14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RegisterModesDefine(IntPtr l)
	{
		int result;
		try
		{
			UITaskBase uitaskBase = (UITaskBase)LuaObject.checkSelf(l);
			string defaultMode;
			LuaObject.checkType(l, 2, out defaultMode);
			string[] modes;
			LuaObject.checkParams(l, 3, out modes);
			uitaskBase.m_luaExportHelper.RegisterModesDefine(defaultMode, modes);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015E73 RID: 89715 RVA: 0x005ACB80 File Offset: 0x005AAD80
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetCurrentMode(IntPtr l)
	{
		int result;
		try
		{
			UITaskBase uitaskBase = (UITaskBase)LuaObject.checkSelf(l);
			string currentMode;
			LuaObject.checkType(l, 2, out currentMode);
			bool b = uitaskBase.m_luaExportHelper.SetCurrentMode(currentMode);
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

	// Token: 0x06015E74 RID: 89716 RVA: 0x005ACBE8 File Offset: 0x005AADE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetIsNeedPauseTimeOut(IntPtr l)
	{
		int result;
		try
		{
			UITaskBase uitaskBase = (UITaskBase)LuaObject.checkSelf(l);
			bool isNeedPauseTimeOut;
			LuaObject.checkType(l, 2, out isNeedPauseTimeOut);
			uitaskBase.m_luaExportHelper.SetIsNeedPauseTimeOut(isNeedPauseTimeOut);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015E75 RID: 89717 RVA: 0x005ACC44 File Offset: 0x005AAE44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnTick(IntPtr l)
	{
		int result;
		try
		{
			UITaskBase uitaskBase = (UITaskBase)LuaObject.checkSelf(l);
			uitaskBase.m_luaExportHelper.OnTick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015E76 RID: 89718 RVA: 0x005ACC98 File Offset: 0x005AAE98
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int TickForDelayTimeExecuteActionList(IntPtr l)
	{
		int result;
		try
		{
			UITaskBase uitaskBase = (UITaskBase)LuaObject.checkSelf(l);
			uitaskBase.m_luaExportHelper.TickForDelayTimeExecuteActionList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015E77 RID: 89719 RVA: 0x005ACCEC File Offset: 0x005AAEEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetTag(IntPtr l)
	{
		int result;
		try
		{
			UITaskBase uitaskBase = (UITaskBase)LuaObject.checkSelf(l);
			string tag;
			LuaObject.checkType(l, 2, out tag);
			uitaskBase.m_luaExportHelper.SetTag(tag);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015E78 RID: 89720 RVA: 0x005ACD48 File Offset: 0x005AAF48
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_Start(IntPtr l)
	{
		int result;
		try
		{
			UITaskBase uitaskBase = (UITaskBase)LuaObject.checkSelf(l);
			object param;
			LuaObject.checkType<object>(l, 2, out param);
			bool b = uitaskBase.m_luaExportHelper.__callBase_Start(param);
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

	// Token: 0x06015E79 RID: 89721 RVA: 0x005ACDB0 File Offset: 0x005AAFB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Stop(IntPtr l)
	{
		int result;
		try
		{
			UITaskBase uitaskBase = (UITaskBase)LuaObject.checkSelf(l);
			uitaskBase.m_luaExportHelper.__callBase_Stop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015E7A RID: 89722 RVA: 0x005ACE04 File Offset: 0x005AB004
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Pause(IntPtr l)
	{
		int result;
		try
		{
			UITaskBase uitaskBase = (UITaskBase)LuaObject.checkSelf(l);
			uitaskBase.m_luaExportHelper.__callBase_Pause();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015E7B RID: 89723 RVA: 0x005ACE58 File Offset: 0x005AB058
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Resume(IntPtr l)
	{
		int result;
		try
		{
			UITaskBase uitaskBase = (UITaskBase)LuaObject.checkSelf(l);
			object param;
			LuaObject.checkType<object>(l, 2, out param);
			bool b = uitaskBase.m_luaExportHelper.__callBase_Resume(param);
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

	// Token: 0x06015E7C RID: 89724 RVA: 0x005ACEC0 File Offset: 0x005AB0C0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_ClearOnStopEvent(IntPtr l)
	{
		int result;
		try
		{
			UITaskBase uitaskBase = (UITaskBase)LuaObject.checkSelf(l);
			uitaskBase.m_luaExportHelper.__callBase_ClearOnStopEvent();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015E7D RID: 89725 RVA: 0x005ACF14 File Offset: 0x005AB114
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ExecAfterTicks(IntPtr l)
	{
		int result;
		try
		{
			UITaskBase uitaskBase = (UITaskBase)LuaObject.checkSelf(l);
			Action action;
			LuaObject.checkDelegate<Action>(l, 2, out action);
			ulong delayTickCount;
			LuaObject.checkType(l, 3, out delayTickCount);
			uitaskBase.m_luaExportHelper.__callBase_ExecAfterTicks(action, delayTickCount);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015E7E RID: 89726 RVA: 0x005ACF80 File Offset: 0x005AB180
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStart(IntPtr l)
	{
		int result;
		try
		{
			UITaskBase uitaskBase = (UITaskBase)LuaObject.checkSelf(l);
			object param;
			LuaObject.checkType<object>(l, 2, out param);
			bool b = uitaskBase.m_luaExportHelper.__callBase_OnStart(param);
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

	// Token: 0x06015E7F RID: 89727 RVA: 0x005ACFE8 File Offset: 0x005AB1E8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnPause(IntPtr l)
	{
		int result;
		try
		{
			UITaskBase uitaskBase = (UITaskBase)LuaObject.checkSelf(l);
			uitaskBase.m_luaExportHelper.__callBase_OnPause();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015E80 RID: 89728 RVA: 0x005AD03C File Offset: 0x005AB23C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnResume(IntPtr l)
	{
		int result;
		try
		{
			UITaskBase uitaskBase = (UITaskBase)LuaObject.checkSelf(l);
			object param;
			LuaObject.checkType<object>(l, 2, out param);
			bool b = uitaskBase.m_luaExportHelper.__callBase_OnResume(param);
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

	// Token: 0x06015E81 RID: 89729 RVA: 0x005AD0A4 File Offset: 0x005AB2A4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnStop(IntPtr l)
	{
		int result;
		try
		{
			UITaskBase uitaskBase = (UITaskBase)LuaObject.checkSelf(l);
			uitaskBase.m_luaExportHelper.__callBase_OnStop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015E82 RID: 89730 RVA: 0x005AD0F8 File Offset: 0x005AB2F8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnTick(IntPtr l)
	{
		int result;
		try
		{
			UITaskBase uitaskBase = (UITaskBase)LuaObject.checkSelf(l);
			uitaskBase.m_luaExportHelper.__callBase_OnTick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015E83 RID: 89731 RVA: 0x005AD14C File Offset: 0x005AB34C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			UITaskBase uitaskBase = (UITaskBase)LuaObject.checkSelf(l);
			string s = uitaskBase.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x06015E84 RID: 89732 RVA: 0x005AD1A8 File Offset: 0x005AB3A8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callDele_EventOnPostUpdateView(IntPtr l)
	{
		int result;
		try
		{
			UITaskBase uitaskBase = (UITaskBase)LuaObject.checkSelf(l);
			UITaskBase obj;
			LuaObject.checkType<UITaskBase>(l, 2, out obj);
			uitaskBase.m_luaExportHelper.__callDele_EventOnPostUpdateView(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015E85 RID: 89733 RVA: 0x005AD204 File Offset: 0x005AB404
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnPostUpdateView(IntPtr l)
	{
		int result;
		try
		{
			UITaskBase uitaskBase = (UITaskBase)LuaObject.checkSelf(l);
			UITaskBase obj;
			LuaObject.checkType<UITaskBase>(l, 2, out obj);
			uitaskBase.m_luaExportHelper.__clearDele_EventOnPostUpdateView(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015E86 RID: 89734 RVA: 0x005AD260 File Offset: 0x005AB460
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnPostUpdateView(IntPtr l)
	{
		int result;
		try
		{
			UITaskBase uitaskBase = (UITaskBase)LuaObject.checkSelf(l);
			Action<UITaskBase> value;
			int num = LuaObject.checkDelegate<Action<UITaskBase>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					uitaskBase.EventOnPostUpdateView += value;
				}
				else if (num == 2)
				{
					uitaskBase.EventOnPostUpdateView -= value;
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

	// Token: 0x06015E87 RID: 89735 RVA: 0x005AD2E0 File Offset: 0x005AB4E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_modeDefine(IntPtr l)
	{
		int result;
		try
		{
			UITaskBase uitaskBase = (UITaskBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, uitaskBase.m_luaExportHelper.m_modeDefine);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015E88 RID: 89736 RVA: 0x005AD338 File Offset: 0x005AB538
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_modeDefine(IntPtr l)
	{
		int result;
		try
		{
			UITaskBase uitaskBase = (UITaskBase)LuaObject.checkSelf(l);
			List<string> modeDefine;
			LuaObject.checkType<List<string>>(l, 2, out modeDefine);
			uitaskBase.m_luaExportHelper.m_modeDefine = modeDefine;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015E89 RID: 89737 RVA: 0x005AD394 File Offset: 0x005AB594
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_currIntent(IntPtr l)
	{
		int result;
		try
		{
			UITaskBase uitaskBase = (UITaskBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, uitaskBase.m_luaExportHelper.m_currIntent);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015E8A RID: 89738 RVA: 0x005AD3EC File Offset: 0x005AB5EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_currIntent(IntPtr l)
	{
		int result;
		try
		{
			UITaskBase uitaskBase = (UITaskBase)LuaObject.checkSelf(l);
			UIIntent currIntent;
			LuaObject.checkType<UIIntent>(l, 2, out currIntent);
			uitaskBase.m_luaExportHelper.m_currIntent = currIntent;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015E8B RID: 89739 RVA: 0x005AD448 File Offset: 0x005AB648
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_currMode(IntPtr l)
	{
		int result;
		try
		{
			UITaskBase uitaskBase = (UITaskBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, uitaskBase.m_luaExportHelper.m_currMode);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015E8C RID: 89740 RVA: 0x005AD4A0 File Offset: 0x005AB6A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_currMode(IntPtr l)
	{
		int result;
		try
		{
			UITaskBase uitaskBase = (UITaskBase)LuaObject.checkSelf(l);
			string currMode;
			LuaObject.checkType(l, 2, out currMode);
			uitaskBase.m_luaExportHelper.m_currMode = currMode;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015E8D RID: 89741 RVA: 0x005AD4FC File Offset: 0x005AB6FC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_isUIInputEnable(IntPtr l)
	{
		int result;
		try
		{
			UITaskBase uitaskBase = (UITaskBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, uitaskBase.m_luaExportHelper.m_isUIInputEnable);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015E8E RID: 89742 RVA: 0x005AD554 File Offset: 0x005AB754
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isUIInputEnable(IntPtr l)
	{
		int result;
		try
		{
			UITaskBase uitaskBase = (UITaskBase)LuaObject.checkSelf(l);
			bool isUIInputEnable;
			LuaObject.checkType(l, 2, out isUIInputEnable);
			uitaskBase.m_luaExportHelper.m_isUIInputEnable = isUIInputEnable;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015E8F RID: 89743 RVA: 0x005AD5B0 File Offset: 0x005AB7B0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_enableUIInputLog(IntPtr l)
	{
		int result;
		try
		{
			UITaskBase uitaskBase = (UITaskBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, uitaskBase.m_luaExportHelper.m_enableUIInputLog);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015E90 RID: 89744 RVA: 0x005AD608 File Offset: 0x005AB808
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_enableUIInputLog(IntPtr l)
	{
		int result;
		try
		{
			UITaskBase uitaskBase = (UITaskBase)LuaObject.checkSelf(l);
			bool enableUIInputLog;
			LuaObject.checkType(l, 2, out enableUIInputLog);
			uitaskBase.m_luaExportHelper.m_enableUIInputLog = enableUIInputLog;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015E91 RID: 89745 RVA: 0x005AD664 File Offset: 0x005AB864
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_loadingStaticResCorutineCount(IntPtr l)
	{
		int result;
		try
		{
			UITaskBase uitaskBase = (UITaskBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, uitaskBase.m_luaExportHelper.m_loadingStaticResCorutineCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015E92 RID: 89746 RVA: 0x005AD6BC File Offset: 0x005AB8BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_loadingStaticResCorutineCount(IntPtr l)
	{
		int result;
		try
		{
			UITaskBase uitaskBase = (UITaskBase)LuaObject.checkSelf(l);
			int loadingStaticResCorutineCount;
			LuaObject.checkType(l, 2, out loadingStaticResCorutineCount);
			uitaskBase.m_luaExportHelper.m_loadingStaticResCorutineCount = loadingStaticResCorutineCount;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015E93 RID: 89747 RVA: 0x005AD718 File Offset: 0x005AB918
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_loadingDynamicResCorutineCount(IntPtr l)
	{
		int result;
		try
		{
			UITaskBase uitaskBase = (UITaskBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, uitaskBase.m_luaExportHelper.m_loadingDynamicResCorutineCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015E94 RID: 89748 RVA: 0x005AD770 File Offset: 0x005AB970
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_loadingDynamicResCorutineCount(IntPtr l)
	{
		int result;
		try
		{
			UITaskBase uitaskBase = (UITaskBase)LuaObject.checkSelf(l);
			int loadingDynamicResCorutineCount;
			LuaObject.checkType(l, 2, out loadingDynamicResCorutineCount);
			uitaskBase.m_luaExportHelper.m_loadingDynamicResCorutineCount = loadingDynamicResCorutineCount;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015E95 RID: 89749 RVA: 0x005AD7CC File Offset: 0x005AB9CC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_playingUpdateViewEffectList(IntPtr l)
	{
		int result;
		try
		{
			UITaskBase uitaskBase = (UITaskBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, uitaskBase.m_luaExportHelper.m_playingUpdateViewEffectList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015E96 RID: 89750 RVA: 0x005AD824 File Offset: 0x005ABA24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playingUpdateViewEffectList(IntPtr l)
	{
		int result;
		try
		{
			UITaskBase uitaskBase = (UITaskBase)LuaObject.checkSelf(l);
			List<UITaskBase.PlayingUpdateViewEffectItem> playingUpdateViewEffectList;
			LuaObject.checkType<List<UITaskBase.PlayingUpdateViewEffectItem>>(l, 2, out playingUpdateViewEffectList);
			uitaskBase.m_luaExportHelper.m_playingUpdateViewEffectList = playingUpdateViewEffectList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015E97 RID: 89751 RVA: 0x005AD880 File Offset: 0x005ABA80
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_layerArray(IntPtr l)
	{
		int result;
		try
		{
			UITaskBase uitaskBase = (UITaskBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, uitaskBase.m_luaExportHelper.m_layerArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015E98 RID: 89752 RVA: 0x005AD8D8 File Offset: 0x005ABAD8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_layerArray(IntPtr l)
	{
		int result;
		try
		{
			UITaskBase uitaskBase = (UITaskBase)LuaObject.checkSelf(l);
			SceneLayerBase[] layerArray;
			LuaObject.checkArray<SceneLayerBase>(l, 2, out layerArray);
			uitaskBase.m_luaExportHelper.m_layerArray = layerArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015E99 RID: 89753 RVA: 0x005AD934 File Offset: 0x005ABB34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiCtrlArray(IntPtr l)
	{
		int result;
		try
		{
			UITaskBase uitaskBase = (UITaskBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, uitaskBase.m_luaExportHelper.m_uiCtrlArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015E9A RID: 89754 RVA: 0x005AD98C File Offset: 0x005ABB8C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_uiCtrlArray(IntPtr l)
	{
		int result;
		try
		{
			UITaskBase uitaskBase = (UITaskBase)LuaObject.checkSelf(l);
			UIControllerBase[] uiCtrlArray;
			LuaObject.checkArray<UIControllerBase>(l, 2, out uiCtrlArray);
			uitaskBase.m_luaExportHelper.m_uiCtrlArray = uiCtrlArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015E9B RID: 89755 RVA: 0x005AD9E8 File Offset: 0x005ABBE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_currPipeLineCtx(IntPtr l)
	{
		int result;
		try
		{
			UITaskBase uitaskBase = (UITaskBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, uitaskBase.m_luaExportHelper.m_currPipeLineCtx);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015E9C RID: 89756 RVA: 0x005ADA40 File Offset: 0x005ABC40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_currPipeLineCtx(IntPtr l)
	{
		int result;
		try
		{
			UITaskBase uitaskBase = (UITaskBase)LuaObject.checkSelf(l);
			UITaskPipeLineCtx currPipeLineCtx;
			LuaObject.checkType<UITaskPipeLineCtx>(l, 2, out currPipeLineCtx);
			uitaskBase.m_luaExportHelper.m_currPipeLineCtx = currPipeLineCtx;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015E9D RID: 89757 RVA: 0x005ADA9C File Offset: 0x005ABC9C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_dynamicResCacheDict(IntPtr l)
	{
		int result;
		try
		{
			UITaskBase uitaskBase = (UITaskBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, uitaskBase.m_luaExportHelper.m_dynamicResCacheDict);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015E9E RID: 89758 RVA: 0x005ADAF4 File Offset: 0x005ABCF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_dynamicResCacheDict(IntPtr l)
	{
		int result;
		try
		{
			UITaskBase uitaskBase = (UITaskBase)LuaObject.checkSelf(l);
			Dictionary<string, UnityEngine.Object> dynamicResCacheDict;
			LuaObject.checkType<Dictionary<string, UnityEngine.Object>>(l, 2, out dynamicResCacheDict);
			uitaskBase.m_luaExportHelper.m_dynamicResCacheDict = dynamicResCacheDict;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015E9F RID: 89759 RVA: 0x005ADB50 File Offset: 0x005ABD50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_corutineHelper(IntPtr l)
	{
		int result;
		try
		{
			UITaskBase uitaskBase = (UITaskBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, uitaskBase.m_luaExportHelper.m_corutineHelper);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015EA0 RID: 89760 RVA: 0x005ADBA8 File Offset: 0x005ABDA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_corutineHelper(IntPtr l)
	{
		int result;
		try
		{
			UITaskBase uitaskBase = (UITaskBase)LuaObject.checkSelf(l);
			TinyCorutineHelper corutineHelper;
			LuaObject.checkType<TinyCorutineHelper>(l, 2, out corutineHelper);
			uitaskBase.m_luaExportHelper.m_corutineHelper = corutineHelper;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015EA1 RID: 89761 RVA: 0x005ADC04 File Offset: 0x005ABE04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_blockPipeLine(IntPtr l)
	{
		int result;
		try
		{
			UITaskBase uitaskBase = (UITaskBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, uitaskBase.m_luaExportHelper.m_blockPipeLine);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015EA2 RID: 89762 RVA: 0x005ADC5C File Offset: 0x005ABE5C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_blockPipeLine(IntPtr l)
	{
		int result;
		try
		{
			UITaskBase uitaskBase = (UITaskBase)LuaObject.checkSelf(l);
			bool blockPipeLine;
			LuaObject.checkType(l, 2, out blockPipeLine);
			uitaskBase.m_luaExportHelper.m_blockPipeLine = blockPipeLine;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015EA3 RID: 89763 RVA: 0x005ADCB8 File Offset: 0x005ABEB8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_lastStartUpdatePipeLineTime(IntPtr l)
	{
		int result;
		try
		{
			UITaskBase uitaskBase = (UITaskBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, uitaskBase.m_luaExportHelper.m_lastStartUpdatePipeLineTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015EA4 RID: 89764 RVA: 0x005ADD10 File Offset: 0x005ABF10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_lastStartUpdatePipeLineTime(IntPtr l)
	{
		int result;
		try
		{
			UITaskBase uitaskBase = (UITaskBase)LuaObject.checkSelf(l);
			ulong lastStartUpdatePipeLineTime;
			LuaObject.checkType(l, 2, out lastStartUpdatePipeLineTime);
			uitaskBase.m_luaExportHelper.m_lastStartUpdatePipeLineTime = lastStartUpdatePipeLineTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015EA5 RID: 89765 RVA: 0x005ADD6C File Offset: 0x005ABF6C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_delayTimeExecList(IntPtr l)
	{
		int result;
		try
		{
			UITaskBase uitaskBase = (UITaskBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, uitaskBase.m_luaExportHelper.m_delayTimeExecList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015EA6 RID: 89766 RVA: 0x005ADDC4 File Offset: 0x005ABFC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_delayTimeExecList(IntPtr l)
	{
		int result;
		try
		{
			UITaskBase uitaskBase = (UITaskBase)LuaObject.checkSelf(l);
			LinkedList<UITaskBase.DelayTimeExecItem> delayTimeExecList;
			LuaObject.checkType<LinkedList<UITaskBase.DelayTimeExecItem>>(l, 2, out delayTimeExecList);
			uitaskBase.m_luaExportHelper.m_delayTimeExecList = delayTimeExecList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015EA7 RID: 89767 RVA: 0x005ADE20 File Offset: 0x005AC020
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_piplineQueue(IntPtr l)
	{
		int result;
		try
		{
			UITaskBase uitaskBase = (UITaskBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, uitaskBase.m_luaExportHelper.m_piplineQueue);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015EA8 RID: 89768 RVA: 0x005ADE78 File Offset: 0x005AC078
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_piplineQueue(IntPtr l)
	{
		int result;
		try
		{
			UITaskBase uitaskBase = (UITaskBase)LuaObject.checkSelf(l);
			List<UITaskBase.PiplineQueueItem> piplineQueue;
			LuaObject.checkType<List<UITaskBase.PiplineQueueItem>>(l, 2, out piplineQueue);
			uitaskBase.m_luaExportHelper.m_piplineQueue = piplineQueue;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015EA9 RID: 89769 RVA: 0x005ADED4 File Offset: 0x005AC0D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_tagList(IntPtr l)
	{
		int result;
		try
		{
			UITaskBase uitaskBase = (UITaskBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, uitaskBase.m_luaExportHelper.m_tagList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015EAA RID: 89770 RVA: 0x005ADF2C File Offset: 0x005AC12C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_tagList(IntPtr l)
	{
		int result;
		try
		{
			UITaskBase uitaskBase = (UITaskBase)LuaObject.checkSelf(l);
			List<string> tagList;
			LuaObject.checkType<List<string>>(l, 2, out tagList);
			uitaskBase.m_luaExportHelper.m_tagList = tagList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015EAB RID: 89771 RVA: 0x005ADF88 File Offset: 0x005AC188
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_CurrentIntent(IntPtr l)
	{
		int result;
		try
		{
			UITaskBase uitaskBase = (UITaskBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, uitaskBase.CurrentIntent);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015EAC RID: 89772 RVA: 0x005ADFDC File Offset: 0x005AC1DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_IsUIInputEnable(IntPtr l)
	{
		int result;
		try
		{
			UITaskBase uitaskBase = (UITaskBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, uitaskBase.m_luaExportHelper.IsUIInputEnable);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015EAD RID: 89773 RVA: 0x005AE034 File Offset: 0x005AC234
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_IsGlobalUIInputEnable(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, UITaskBase.LuaExportHelper.IsGlobalUIInputEnable);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015EAE RID: 89774 RVA: 0x005AE07C File Offset: 0x005AC27C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_MainLayer(IntPtr l)
	{
		int result;
		try
		{
			UITaskBase uitaskBase = (UITaskBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, uitaskBase.m_luaExportHelper.MainLayer);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015EAF RID: 89775 RVA: 0x005AE0D4 File Offset: 0x005AC2D4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_LayerDescArray(IntPtr l)
	{
		int result;
		try
		{
			UITaskBase uitaskBase = (UITaskBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, uitaskBase.m_luaExportHelper.LayerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015EB0 RID: 89776 RVA: 0x005AE12C File Offset: 0x005AC32C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_UICtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			UITaskBase uitaskBase = (UITaskBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, uitaskBase.m_luaExportHelper.UICtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015EB1 RID: 89777 RVA: 0x005AE184 File Offset: 0x005AC384
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_IsNeedPauseTimeOut(IntPtr l)
	{
		int result;
		try
		{
			UITaskBase uitaskBase = (UITaskBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, uitaskBase.IsNeedPauseTimeOut);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015EB2 RID: 89778 RVA: 0x005AE1D8 File Offset: 0x005AC3D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_IsNeedPauseTimeOut(IntPtr l)
	{
		int result;
		try
		{
			UITaskBase uitaskBase = (UITaskBase)LuaObject.checkSelf(l);
			bool isNeedPauseTimeOut;
			LuaObject.checkType(l, 2, out isNeedPauseTimeOut);
			uitaskBase.m_luaExportHelper.IsNeedPauseTimeOut = isNeedPauseTimeOut;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015EB3 RID: 89779 RVA: 0x005AE234 File Offset: 0x005AC434
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.BJFramework.Runtime.UI.UITaskBase");
		if (Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.InitlizeBeforeManagerStartIt);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache0);
		if (Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.PrepareForStartOrResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache1);
		if (Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.OnNewIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache2);
		if (Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.RedirectPipLineOnAllResReady);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache3);
		if (Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.ReturnFromRedirectPipLineOnLoadAllResCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache4);
		if (Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.EnableUIInput);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache5);
		if (Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.PostDelayTimeExecuteAction);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache6);
		if (Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.PostDelayTicksExecuteAction);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache7);
		if (Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.HasTag);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache8);
		if (Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache9);
		if (Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.GetPipeLineCtx);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cacheA);
		if (Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.CreatePipeLineCtx);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cacheB);
		if (Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.OnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cacheC);
		if (Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.OnPause);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cacheD);
		if (Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cacheE);
		if (Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.StartUpdatePipeLine);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cacheF);
		if (Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.NeedSkipUpdatePipeLine);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache10);
		if (Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.IsNeedUpdateDataCache);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache11);
		if (Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.UpdateDataCache);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache12);
		if (Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.IsNeedLoadStaticRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache13);
		if (Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.StartLoadStaticRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache14);
		if (Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.CheckLayerDescArray);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache15);
		if (Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.OnLoadStaticResCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache16);
		if (Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache17);
		if (Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.StartLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache18);
		if (Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.CollectAllDynamicResForLoad);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache19);
		if (Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.CollectAllStaticResDescForLoad);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache1A);
		if (Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.CalculateDynamicResReallyNeedLoad);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache1B);
		if (Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.OnLoadDynamicResCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache1C);
		if (Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.OnLoadAllResCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache1D);
		if (Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.InitLayerStateOnLoadAllResCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache1E);
		if (Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.InitAllUIControllers);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache1F);
		if (Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.PostOnLoadAllResCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache20);
		if (Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.IsLoadAllResCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache21);
		if (Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.StartUpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache22);
		if (Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.UpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache23);
		if (Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.RegUpdateViewPlayingEffect);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache24);
		if (Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.UnregUpdateViewPlayingEffect);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache25);
		if (Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.PostUpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache26);
		if (Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.PostUpdateViewBeforeClearContext);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache27);
		if (Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.HideAllView);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache28);
		if (Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.ClearAllContextAndRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache29);
		if (Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.SaveContextInIntentOnPause);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache2A);
		if (Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.ClearContextOnPause);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache2B);
		if (Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.ClearContextOnIntentChange);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache2C);
		if (Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.ClearContextOnUpdateViewEnd);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache2D);
		if (Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.GetLayerDescByName);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache2E);
		if (Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.GetLayerByName);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache2F);
		if (Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.RegisterModesDefine);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache30);
		if (Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.SetCurrentMode);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache31);
		if (Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.SetIsNeedPauseTimeOut);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache32);
		if (Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.OnTick);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache33);
		if (Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.TickForDelayTimeExecuteActionList);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache34);
		if (Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.SetTag);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache35);
		if (Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.__callBase_Start);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache36);
		if (Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.__callBase_Stop);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache37);
		if (Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.__callBase_Pause);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache38);
		if (Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.__callBase_Resume);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache39);
		if (Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.__callBase_ClearOnStopEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache3A);
		if (Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.__callBase_ExecAfterTicks);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache3B);
		if (Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.__callBase_OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache3C);
		if (Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.__callBase_OnPause);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache3D);
		if (Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.__callBase_OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache3E);
		if (Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.__callBase_OnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache3F);
		if (Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.__callBase_OnTick);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache40);
		if (Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache41);
		if (Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.__callDele_EventOnPostUpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache42);
		if (Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.__clearDele_EventOnPostUpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache43);
		string name = "EventOnPostUpdateView";
		LuaCSFunction get = null;
		if (Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.set_EventOnPostUpdateView);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache44, true);
		string name2 = "m_modeDefine";
		if (Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.get_m_modeDefine);
		}
		LuaCSFunction get2 = Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache45;
		if (Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache46 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache46 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.set_m_modeDefine);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache46, true);
		string name3 = "m_currIntent";
		if (Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache47 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache47 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.get_m_currIntent);
		}
		LuaCSFunction get3 = Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache47;
		if (Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache48 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache48 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.set_m_currIntent);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache48, true);
		string name4 = "m_currMode";
		if (Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache49 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache49 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.get_m_currMode);
		}
		LuaCSFunction get4 = Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache49;
		if (Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache4A == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache4A = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.set_m_currMode);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache4A, true);
		string name5 = "m_isUIInputEnable";
		if (Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache4B == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache4B = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.get_m_isUIInputEnable);
		}
		LuaCSFunction get5 = Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache4B;
		if (Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache4C == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache4C = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.set_m_isUIInputEnable);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache4C, true);
		string name6 = "m_enableUIInputLog";
		if (Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache4D == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache4D = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.get_m_enableUIInputLog);
		}
		LuaCSFunction get6 = Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache4D;
		if (Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache4E == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache4E = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.set_m_enableUIInputLog);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache4E, true);
		string name7 = "m_loadingStaticResCorutineCount";
		if (Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache4F == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache4F = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.get_m_loadingStaticResCorutineCount);
		}
		LuaCSFunction get7 = Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache4F;
		if (Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache50 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache50 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.set_m_loadingStaticResCorutineCount);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache50, true);
		string name8 = "m_loadingDynamicResCorutineCount";
		if (Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache51 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache51 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.get_m_loadingDynamicResCorutineCount);
		}
		LuaCSFunction get8 = Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache51;
		if (Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache52 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache52 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.set_m_loadingDynamicResCorutineCount);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache52, true);
		string name9 = "m_playingUpdateViewEffectList";
		if (Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache53 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache53 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.get_m_playingUpdateViewEffectList);
		}
		LuaCSFunction get9 = Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache53;
		if (Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache54 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache54 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.set_m_playingUpdateViewEffectList);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache54, true);
		string name10 = "m_layerArray";
		if (Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache55 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache55 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.get_m_layerArray);
		}
		LuaCSFunction get10 = Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache55;
		if (Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache56 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache56 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.set_m_layerArray);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache56, true);
		string name11 = "m_uiCtrlArray";
		if (Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache57 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache57 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.get_m_uiCtrlArray);
		}
		LuaCSFunction get11 = Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache57;
		if (Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache58 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache58 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.set_m_uiCtrlArray);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache58, true);
		string name12 = "m_currPipeLineCtx";
		if (Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache59 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache59 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.get_m_currPipeLineCtx);
		}
		LuaCSFunction get12 = Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache59;
		if (Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache5A == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache5A = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.set_m_currPipeLineCtx);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache5A, true);
		string name13 = "m_dynamicResCacheDict";
		if (Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache5B == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache5B = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.get_m_dynamicResCacheDict);
		}
		LuaCSFunction get13 = Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache5B;
		if (Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache5C == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache5C = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.set_m_dynamicResCacheDict);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache5C, true);
		string name14 = "m_corutineHelper";
		if (Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache5D == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache5D = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.get_m_corutineHelper);
		}
		LuaCSFunction get14 = Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache5D;
		if (Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache5E == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache5E = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.set_m_corutineHelper);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache5E, true);
		string name15 = "m_blockPipeLine";
		if (Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache5F == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache5F = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.get_m_blockPipeLine);
		}
		LuaCSFunction get15 = Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache5F;
		if (Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache60 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache60 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.set_m_blockPipeLine);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache60, true);
		string name16 = "m_lastStartUpdatePipeLineTime";
		if (Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache61 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache61 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.get_m_lastStartUpdatePipeLineTime);
		}
		LuaCSFunction get16 = Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache61;
		if (Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache62 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache62 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.set_m_lastStartUpdatePipeLineTime);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache62, true);
		string name17 = "m_delayTimeExecList";
		if (Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache63 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache63 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.get_m_delayTimeExecList);
		}
		LuaCSFunction get17 = Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache63;
		if (Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache64 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache64 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.set_m_delayTimeExecList);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache64, true);
		string name18 = "m_piplineQueue";
		if (Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache65 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache65 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.get_m_piplineQueue);
		}
		LuaCSFunction get18 = Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache65;
		if (Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache66 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache66 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.set_m_piplineQueue);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache66, true);
		string name19 = "m_tagList";
		if (Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache67 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache67 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.get_m_tagList);
		}
		LuaCSFunction get19 = Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache67;
		if (Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache68 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache68 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.set_m_tagList);
		}
		LuaObject.addMember(l, name19, get19, Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache68, true);
		string name20 = "CurrentIntent";
		if (Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache69 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache69 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.get_CurrentIntent);
		}
		LuaObject.addMember(l, name20, Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache69, null, true);
		string name21 = "IsUIInputEnable";
		if (Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache6A == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache6A = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.get_IsUIInputEnable);
		}
		LuaObject.addMember(l, name21, Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache6A, null, true);
		string name22 = "IsGlobalUIInputEnable";
		if (Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache6B == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache6B = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.get_IsGlobalUIInputEnable);
		}
		LuaObject.addMember(l, name22, Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache6B, null, false);
		string name23 = "MainLayer";
		if (Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache6C == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache6C = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.get_MainLayer);
		}
		LuaObject.addMember(l, name23, Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache6C, null, true);
		string name24 = "LayerDescArray";
		if (Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache6D == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache6D = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.get_LayerDescArray);
		}
		LuaObject.addMember(l, name24, Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache6D, null, true);
		string name25 = "UICtrlDescArray";
		if (Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache6E == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache6E = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.get_UICtrlDescArray);
		}
		LuaObject.addMember(l, name25, Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache6E, null, true);
		string name26 = "IsNeedPauseTimeOut";
		if (Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache6F == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache6F = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.get_IsNeedPauseTimeOut);
		}
		LuaCSFunction get20 = Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache6F;
		if (Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache70 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache70 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.set_IsNeedPauseTimeOut);
		}
		LuaObject.addMember(l, name26, get20, Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache70, true);
		if (Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache71 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache71 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.<>f__mg$cache71, typeof(UITaskBase), typeof(Task));
	}

	// Token: 0x0400C5CB RID: 50635
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400C5CC RID: 50636
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400C5CD RID: 50637
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400C5CE RID: 50638
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400C5CF RID: 50639
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400C5D0 RID: 50640
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400C5D1 RID: 50641
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400C5D2 RID: 50642
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400C5D3 RID: 50643
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400C5D4 RID: 50644
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400C5D5 RID: 50645
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400C5D6 RID: 50646
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400C5D7 RID: 50647
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400C5D8 RID: 50648
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400C5D9 RID: 50649
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400C5DA RID: 50650
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400C5DB RID: 50651
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400C5DC RID: 50652
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400C5DD RID: 50653
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400C5DE RID: 50654
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400C5DF RID: 50655
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400C5E0 RID: 50656
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400C5E1 RID: 50657
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400C5E2 RID: 50658
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400C5E3 RID: 50659
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400C5E4 RID: 50660
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0400C5E5 RID: 50661
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0400C5E6 RID: 50662
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0400C5E7 RID: 50663
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0400C5E8 RID: 50664
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0400C5E9 RID: 50665
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0400C5EA RID: 50666
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0400C5EB RID: 50667
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0400C5EC RID: 50668
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0400C5ED RID: 50669
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0400C5EE RID: 50670
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0400C5EF RID: 50671
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0400C5F0 RID: 50672
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0400C5F1 RID: 50673
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0400C5F2 RID: 50674
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0400C5F3 RID: 50675
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x0400C5F4 RID: 50676
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x0400C5F5 RID: 50677
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x0400C5F6 RID: 50678
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x0400C5F7 RID: 50679
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x0400C5F8 RID: 50680
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x0400C5F9 RID: 50681
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x0400C5FA RID: 50682
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x0400C5FB RID: 50683
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x0400C5FC RID: 50684
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x0400C5FD RID: 50685
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x0400C5FE RID: 50686
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x0400C5FF RID: 50687
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x0400C600 RID: 50688
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x0400C601 RID: 50689
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x0400C602 RID: 50690
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x0400C603 RID: 50691
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x0400C604 RID: 50692
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x0400C605 RID: 50693
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x0400C606 RID: 50694
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x0400C607 RID: 50695
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x0400C608 RID: 50696
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x0400C609 RID: 50697
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x0400C60A RID: 50698
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x0400C60B RID: 50699
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x0400C60C RID: 50700
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x0400C60D RID: 50701
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x0400C60E RID: 50702
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x0400C60F RID: 50703
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x0400C610 RID: 50704
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x0400C611 RID: 50705
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;

	// Token: 0x0400C612 RID: 50706
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache47;

	// Token: 0x0400C613 RID: 50707
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache48;

	// Token: 0x0400C614 RID: 50708
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache49;

	// Token: 0x0400C615 RID: 50709
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4A;

	// Token: 0x0400C616 RID: 50710
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4B;

	// Token: 0x0400C617 RID: 50711
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4C;

	// Token: 0x0400C618 RID: 50712
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4D;

	// Token: 0x0400C619 RID: 50713
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4E;

	// Token: 0x0400C61A RID: 50714
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4F;

	// Token: 0x0400C61B RID: 50715
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache50;

	// Token: 0x0400C61C RID: 50716
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache51;

	// Token: 0x0400C61D RID: 50717
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache52;

	// Token: 0x0400C61E RID: 50718
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache53;

	// Token: 0x0400C61F RID: 50719
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache54;

	// Token: 0x0400C620 RID: 50720
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache55;

	// Token: 0x0400C621 RID: 50721
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache56;

	// Token: 0x0400C622 RID: 50722
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache57;

	// Token: 0x0400C623 RID: 50723
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache58;

	// Token: 0x0400C624 RID: 50724
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache59;

	// Token: 0x0400C625 RID: 50725
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5A;

	// Token: 0x0400C626 RID: 50726
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5B;

	// Token: 0x0400C627 RID: 50727
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5C;

	// Token: 0x0400C628 RID: 50728
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5D;

	// Token: 0x0400C629 RID: 50729
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5E;

	// Token: 0x0400C62A RID: 50730
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5F;

	// Token: 0x0400C62B RID: 50731
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache60;

	// Token: 0x0400C62C RID: 50732
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache61;

	// Token: 0x0400C62D RID: 50733
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache62;

	// Token: 0x0400C62E RID: 50734
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache63;

	// Token: 0x0400C62F RID: 50735
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache64;

	// Token: 0x0400C630 RID: 50736
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache65;

	// Token: 0x0400C631 RID: 50737
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache66;

	// Token: 0x0400C632 RID: 50738
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache67;

	// Token: 0x0400C633 RID: 50739
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache68;

	// Token: 0x0400C634 RID: 50740
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache69;

	// Token: 0x0400C635 RID: 50741
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6A;

	// Token: 0x0400C636 RID: 50742
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6B;

	// Token: 0x0400C637 RID: 50743
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6C;

	// Token: 0x0400C638 RID: 50744
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6D;

	// Token: 0x0400C639 RID: 50745
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6E;

	// Token: 0x0400C63A RID: 50746
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6F;

	// Token: 0x0400C63B RID: 50747
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache70;

	// Token: 0x0400C63C RID: 50748
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache71;
}
