using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Scene;
using BlackJack.BJFramework.Runtime.TaskNs;
using BlackJack.Utils;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x02001120 RID: 4384
[Preserve]
public class Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase : LuaObject
{
	// Token: 0x06015C6D RID: 89197 RVA: 0x0059D5C8 File Offset: 0x0059B7C8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			string name;
			LuaObject.checkType(l, 2, out name);
			MapSceneTaskBase o = new MapSceneTaskBase(name);
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

	// Token: 0x06015C6E RID: 89198 RVA: 0x0059D61C File Offset: 0x0059B81C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int InitPipeCtxDefault(IntPtr l)
	{
		int result;
		try
		{
			MapSceneTaskBase mapSceneTaskBase = (MapSceneTaskBase)LuaObject.checkSelf(l);
			mapSceneTaskBase.m_luaExportHelper.InitPipeCtxDefault();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015C6F RID: 89199 RVA: 0x0059D670 File Offset: 0x0059B870
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnStart(IntPtr l)
	{
		int result;
		try
		{
			MapSceneTaskBase mapSceneTaskBase = (MapSceneTaskBase)LuaObject.checkSelf(l);
			object param;
			LuaObject.checkType<object>(l, 2, out param);
			bool b = mapSceneTaskBase.m_luaExportHelper.OnStart(param);
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

	// Token: 0x06015C70 RID: 89200 RVA: 0x0059D6D8 File Offset: 0x0059B8D8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnStop(IntPtr l)
	{
		int result;
		try
		{
			MapSceneTaskBase mapSceneTaskBase = (MapSceneTaskBase)LuaObject.checkSelf(l);
			mapSceneTaskBase.m_luaExportHelper.OnStop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015C71 RID: 89201 RVA: 0x0059D72C File Offset: 0x0059B92C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnPause(IntPtr l)
	{
		int result;
		try
		{
			MapSceneTaskBase mapSceneTaskBase = (MapSceneTaskBase)LuaObject.checkSelf(l);
			mapSceneTaskBase.m_luaExportHelper.OnPause();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015C72 RID: 89202 RVA: 0x0059D780 File Offset: 0x0059B980
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int StartUpdatePipeLine(IntPtr l)
	{
		int result;
		try
		{
			MapSceneTaskBase mapSceneTaskBase = (MapSceneTaskBase)LuaObject.checkSelf(l);
			MapSceneUpdatePipeLineCtxBase pipeCtx;
			LuaObject.checkType<MapSceneUpdatePipeLineCtxBase>(l, 2, out pipeCtx);
			bool b = mapSceneTaskBase.m_luaExportHelper.StartUpdatePipeLine(pipeCtx);
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

	// Token: 0x06015C73 RID: 89203 RVA: 0x0059D7E8 File Offset: 0x0059B9E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AllocPipeLineCtx(IntPtr l)
	{
		int result;
		try
		{
			MapSceneTaskBase mapSceneTaskBase = (MapSceneTaskBase)LuaObject.checkSelf(l);
			MapSceneUpdatePipeLineCtxBase o = mapSceneTaskBase.m_luaExportHelper.AllocPipeLineCtx();
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

	// Token: 0x06015C74 RID: 89204 RVA: 0x0059D844 File Offset: 0x0059BA44
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CreatePipeLineCtx(IntPtr l)
	{
		int result;
		try
		{
			MapSceneTaskBase mapSceneTaskBase = (MapSceneTaskBase)LuaObject.checkSelf(l);
			MapSceneUpdatePipeLineCtxBase o = mapSceneTaskBase.m_luaExportHelper.CreatePipeLineCtx();
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

	// Token: 0x06015C75 RID: 89205 RVA: 0x0059D8A0 File Offset: 0x0059BAA0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int StartPipeLineCtx(IntPtr l)
	{
		int result;
		try
		{
			MapSceneTaskBase mapSceneTaskBase = (MapSceneTaskBase)LuaObject.checkSelf(l);
			MapSceneUpdatePipeLineCtxBase pipeCtx;
			LuaObject.checkType<MapSceneUpdatePipeLineCtxBase>(l, 2, out pipeCtx);
			bool b = mapSceneTaskBase.m_luaExportHelper.StartPipeLineCtx(pipeCtx);
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

	// Token: 0x06015C76 RID: 89206 RVA: 0x0059D908 File Offset: 0x0059BB08
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ReleasePipeLineCtx(IntPtr l)
	{
		int result;
		try
		{
			MapSceneTaskBase mapSceneTaskBase = (MapSceneTaskBase)LuaObject.checkSelf(l);
			MapSceneUpdatePipeLineCtxBase pipeCtx;
			LuaObject.checkType<MapSceneUpdatePipeLineCtxBase>(l, 2, out pipeCtx);
			mapSceneTaskBase.m_luaExportHelper.ReleasePipeLineCtx(pipeCtx);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015C77 RID: 89207 RVA: 0x0059D964 File Offset: 0x0059BB64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsNeedUpdateDataCache(IntPtr l)
	{
		int result;
		try
		{
			MapSceneTaskBase mapSceneTaskBase = (MapSceneTaskBase)LuaObject.checkSelf(l);
			MapSceneUpdatePipeLineCtxBase pipeCtx;
			LuaObject.checkType<MapSceneUpdatePipeLineCtxBase>(l, 2, out pipeCtx);
			bool b = mapSceneTaskBase.m_luaExportHelper.IsNeedUpdateDataCache(pipeCtx);
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

	// Token: 0x06015C78 RID: 89208 RVA: 0x0059D9CC File Offset: 0x0059BBCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateDataCache(IntPtr l)
	{
		int result;
		try
		{
			MapSceneTaskBase mapSceneTaskBase = (MapSceneTaskBase)LuaObject.checkSelf(l);
			MapSceneUpdatePipeLineCtxBase pipeCtx;
			LuaObject.checkType<MapSceneUpdatePipeLineCtxBase>(l, 2, out pipeCtx);
			mapSceneTaskBase.m_luaExportHelper.UpdateDataCache(pipeCtx);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015C79 RID: 89209 RVA: 0x0059DA28 File Offset: 0x0059BC28
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int PreProcessBeforeResLoad(IntPtr l)
	{
		int result;
		try
		{
			MapSceneTaskBase mapSceneTaskBase = (MapSceneTaskBase)LuaObject.checkSelf(l);
			MapSceneUpdatePipeLineCtxBase pipeCtx;
			LuaObject.checkType<MapSceneUpdatePipeLineCtxBase>(l, 2, out pipeCtx);
			mapSceneTaskBase.m_luaExportHelper.PreProcessBeforeResLoad(pipeCtx);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015C7A RID: 89210 RVA: 0x0059DA84 File Offset: 0x0059BC84
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsNeedLoadStaticRes(IntPtr l)
	{
		int result;
		try
		{
			MapSceneTaskBase mapSceneTaskBase = (MapSceneTaskBase)LuaObject.checkSelf(l);
			bool b = mapSceneTaskBase.m_luaExportHelper.IsNeedLoadStaticRes();
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

	// Token: 0x06015C7B RID: 89211 RVA: 0x0059DAE0 File Offset: 0x0059BCE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartLoadStaticRes(IntPtr l)
	{
		int result;
		try
		{
			MapSceneTaskBase mapSceneTaskBase = (MapSceneTaskBase)LuaObject.checkSelf(l);
			MapSceneUpdatePipeLineCtxBase pipeCtx;
			LuaObject.checkType<MapSceneUpdatePipeLineCtxBase>(l, 2, out pipeCtx);
			mapSceneTaskBase.m_luaExportHelper.StartLoadStaticRes(pipeCtx);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015C7C RID: 89212 RVA: 0x0059DB3C File Offset: 0x0059BD3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnLoadStaticResCompleted(IntPtr l)
	{
		int result;
		try
		{
			MapSceneTaskBase mapSceneTaskBase = (MapSceneTaskBase)LuaObject.checkSelf(l);
			MapSceneUpdatePipeLineCtxBase pipeCtx;
			LuaObject.checkType<MapSceneUpdatePipeLineCtxBase>(l, 2, out pipeCtx);
			mapSceneTaskBase.m_luaExportHelper.OnLoadStaticResCompleted(pipeCtx);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015C7D RID: 89213 RVA: 0x0059DB98 File Offset: 0x0059BD98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsNeedCollectAllDynamicResForLoad(IntPtr l)
	{
		int result;
		try
		{
			MapSceneTaskBase mapSceneTaskBase = (MapSceneTaskBase)LuaObject.checkSelf(l);
			MapSceneUpdatePipeLineCtxBase pipeCtx;
			LuaObject.checkType<MapSceneUpdatePipeLineCtxBase>(l, 2, out pipeCtx);
			bool b = mapSceneTaskBase.m_luaExportHelper.IsNeedCollectAllDynamicResForLoad(pipeCtx);
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

	// Token: 0x06015C7E RID: 89214 RVA: 0x0059DC00 File Offset: 0x0059BE00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CollectAllDynamicResForLoad(IntPtr l)
	{
		int result;
		try
		{
			MapSceneTaskBase mapSceneTaskBase = (MapSceneTaskBase)LuaObject.checkSelf(l);
			MapSceneUpdatePipeLineCtxBase pipeCtx;
			LuaObject.checkType<MapSceneUpdatePipeLineCtxBase>(l, 2, out pipeCtx);
			List<string> o = mapSceneTaskBase.m_luaExportHelper.CollectAllDynamicResForLoad(pipeCtx);
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

	// Token: 0x06015C7F RID: 89215 RVA: 0x0059DC68 File Offset: 0x0059BE68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			MapSceneTaskBase mapSceneTaskBase = (MapSceneTaskBase)LuaObject.checkSelf(l);
			List<string> resPathList;
			LuaObject.checkType<List<string>>(l, 2, out resPathList);
			MapSceneUpdatePipeLineCtxBase pipeCtx;
			LuaObject.checkType<MapSceneUpdatePipeLineCtxBase>(l, 3, out pipeCtx);
			mapSceneTaskBase.m_luaExportHelper.StartLoadDynamicRes(resPathList, pipeCtx);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015C80 RID: 89216 RVA: 0x0059DCD4 File Offset: 0x0059BED4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CalculateDynamicResReallyNeedLoad(IntPtr l)
	{
		int result;
		try
		{
			MapSceneTaskBase mapSceneTaskBase = (MapSceneTaskBase)LuaObject.checkSelf(l);
			List<string> resPathList;
			LuaObject.checkType<List<string>>(l, 2, out resPathList);
			HashSet<string> o = mapSceneTaskBase.m_luaExportHelper.CalculateDynamicResReallyNeedLoad(resPathList);
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

	// Token: 0x06015C81 RID: 89217 RVA: 0x0059DD3C File Offset: 0x0059BF3C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnLoadDynamicResCompleted(IntPtr l)
	{
		int result;
		try
		{
			MapSceneTaskBase mapSceneTaskBase = (MapSceneTaskBase)LuaObject.checkSelf(l);
			Dictionary<string, UnityEngine.Object> resDict;
			LuaObject.checkType<Dictionary<string, UnityEngine.Object>>(l, 2, out resDict);
			MapSceneUpdatePipeLineCtxBase pipeCtx;
			LuaObject.checkType<MapSceneUpdatePipeLineCtxBase>(l, 3, out pipeCtx);
			mapSceneTaskBase.m_luaExportHelper.OnLoadDynamicResCompleted(resDict, pipeCtx);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015C82 RID: 89218 RVA: 0x0059DDA8 File Offset: 0x0059BFA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsLoadAllResCompleted(IntPtr l)
	{
		int result;
		try
		{
			MapSceneTaskBase mapSceneTaskBase = (MapSceneTaskBase)LuaObject.checkSelf(l);
			MapSceneUpdatePipeLineCtxBase pipeCtx;
			LuaObject.checkType<MapSceneUpdatePipeLineCtxBase>(l, 2, out pipeCtx);
			bool b = mapSceneTaskBase.m_luaExportHelper.IsLoadAllResCompleted(pipeCtx);
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

	// Token: 0x06015C83 RID: 89219 RVA: 0x0059DE10 File Offset: 0x0059C010
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnLoadAllResCompleted(IntPtr l)
	{
		int result;
		try
		{
			MapSceneTaskBase mapSceneTaskBase = (MapSceneTaskBase)LuaObject.checkSelf(l);
			MapSceneUpdatePipeLineCtxBase pipeCtx;
			LuaObject.checkType<MapSceneUpdatePipeLineCtxBase>(l, 2, out pipeCtx);
			mapSceneTaskBase.m_luaExportHelper.OnLoadAllResCompleted(pipeCtx);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015C84 RID: 89220 RVA: 0x0059DE6C File Offset: 0x0059C06C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitLayerStateOnLoadAllResCompleted(IntPtr l)
	{
		int result;
		try
		{
			MapSceneTaskBase mapSceneTaskBase = (MapSceneTaskBase)LuaObject.checkSelf(l);
			MapSceneUpdatePipeLineCtxBase pipeCtx;
			LuaObject.checkType<MapSceneUpdatePipeLineCtxBase>(l, 2, out pipeCtx);
			mapSceneTaskBase.m_luaExportHelper.InitLayerStateOnLoadAllResCompleted(pipeCtx);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015C85 RID: 89221 RVA: 0x0059DEC8 File Offset: 0x0059C0C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartUpdateView(IntPtr l)
	{
		int result;
		try
		{
			MapSceneTaskBase mapSceneTaskBase = (MapSceneTaskBase)LuaObject.checkSelf(l);
			MapSceneUpdatePipeLineCtxBase pipeCtx;
			LuaObject.checkType<MapSceneUpdatePipeLineCtxBase>(l, 2, out pipeCtx);
			mapSceneTaskBase.m_luaExportHelper.StartUpdateView(pipeCtx);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015C86 RID: 89222 RVA: 0x0059DF24 File Offset: 0x0059C124
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateView(IntPtr l)
	{
		int result;
		try
		{
			MapSceneTaskBase mapSceneTaskBase = (MapSceneTaskBase)LuaObject.checkSelf(l);
			MapSceneUpdatePipeLineCtxBase pipeCtx;
			LuaObject.checkType<MapSceneUpdatePipeLineCtxBase>(l, 2, out pipeCtx);
			mapSceneTaskBase.m_luaExportHelper.UpdateView(pipeCtx);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015C87 RID: 89223 RVA: 0x0059DF80 File Offset: 0x0059C180
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int PostUpdateView(IntPtr l)
	{
		int result;
		try
		{
			MapSceneTaskBase mapSceneTaskBase = (MapSceneTaskBase)LuaObject.checkSelf(l);
			MapSceneUpdatePipeLineCtxBase pipeCtx;
			LuaObject.checkType<MapSceneUpdatePipeLineCtxBase>(l, 2, out pipeCtx);
			mapSceneTaskBase.m_luaExportHelper.PostUpdateView(pipeCtx);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015C88 RID: 89224 RVA: 0x0059DFDC File Offset: 0x0059C1DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HideAllView(IntPtr l)
	{
		int result;
		try
		{
			MapSceneTaskBase mapSceneTaskBase = (MapSceneTaskBase)LuaObject.checkSelf(l);
			mapSceneTaskBase.m_luaExportHelper.HideAllView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015C89 RID: 89225 RVA: 0x0059E030 File Offset: 0x0059C230
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearAllContextAndRes(IntPtr l)
	{
		int result;
		try
		{
			MapSceneTaskBase mapSceneTaskBase = (MapSceneTaskBase)LuaObject.checkSelf(l);
			mapSceneTaskBase.m_luaExportHelper.ClearAllContextAndRes();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015C8A RID: 89226 RVA: 0x0059E084 File Offset: 0x0059C284
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ClearContextOnPause(IntPtr l)
	{
		int result;
		try
		{
			MapSceneTaskBase mapSceneTaskBase = (MapSceneTaskBase)LuaObject.checkSelf(l);
			mapSceneTaskBase.m_luaExportHelper.ClearContextOnPause();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015C8B RID: 89227 RVA: 0x0059E0D8 File Offset: 0x0059C2D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnTick(IntPtr l)
	{
		int result;
		try
		{
			MapSceneTaskBase mapSceneTaskBase = (MapSceneTaskBase)LuaObject.checkSelf(l);
			mapSceneTaskBase.m_luaExportHelper.OnTick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015C8C RID: 89228 RVA: 0x0059E12C File Offset: 0x0059C32C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ReleaseDynamicResCache(IntPtr l)
	{
		int result;
		try
		{
			MapSceneTaskBase mapSceneTaskBase = (MapSceneTaskBase)LuaObject.checkSelf(l);
			string path;
			LuaObject.checkType(l, 2, out path);
			mapSceneTaskBase.m_luaExportHelper.ReleaseDynamicResCache(path);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015C8D RID: 89229 RVA: 0x0059E188 File Offset: 0x0059C388
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int LockDynamicResCache(IntPtr l)
	{
		int result;
		try
		{
			MapSceneTaskBase mapSceneTaskBase = (MapSceneTaskBase)LuaObject.checkSelf(l);
			string path;
			LuaObject.checkType(l, 2, out path);
			mapSceneTaskBase.m_luaExportHelper.LockDynamicResCache(path);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015C8E RID: 89230 RVA: 0x0059E1E4 File Offset: 0x0059C3E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UnlockDynamicResCache(IntPtr l)
	{
		int result;
		try
		{
			MapSceneTaskBase mapSceneTaskBase = (MapSceneTaskBase)LuaObject.checkSelf(l);
			string path;
			LuaObject.checkType(l, 2, out path);
			mapSceneTaskBase.m_luaExportHelper.UnlockDynamicResCache(path);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015C8F RID: 89231 RVA: 0x0059E240 File Offset: 0x0059C440
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UnlockAllDynamicResCache(IntPtr l)
	{
		int result;
		try
		{
			MapSceneTaskBase mapSceneTaskBase = (MapSceneTaskBase)LuaObject.checkSelf(l);
			mapSceneTaskBase.m_luaExportHelper.UnlockAllDynamicResCache();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015C90 RID: 89232 RVA: 0x0059E294 File Offset: 0x0059C494
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int TickDynamicResCache(IntPtr l)
	{
		int result;
		try
		{
			MapSceneTaskBase mapSceneTaskBase = (MapSceneTaskBase)LuaObject.checkSelf(l);
			mapSceneTaskBase.m_luaExportHelper.TickDynamicResCache();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015C91 RID: 89233 RVA: 0x0059E2E8 File Offset: 0x0059C4E8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_Start(IntPtr l)
	{
		int result;
		try
		{
			MapSceneTaskBase mapSceneTaskBase = (MapSceneTaskBase)LuaObject.checkSelf(l);
			object param;
			LuaObject.checkType<object>(l, 2, out param);
			bool b = mapSceneTaskBase.m_luaExportHelper.__callBase_Start(param);
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

	// Token: 0x06015C92 RID: 89234 RVA: 0x0059E350 File Offset: 0x0059C550
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_Stop(IntPtr l)
	{
		int result;
		try
		{
			MapSceneTaskBase mapSceneTaskBase = (MapSceneTaskBase)LuaObject.checkSelf(l);
			mapSceneTaskBase.m_luaExportHelper.__callBase_Stop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015C93 RID: 89235 RVA: 0x0059E3A4 File Offset: 0x0059C5A4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_Pause(IntPtr l)
	{
		int result;
		try
		{
			MapSceneTaskBase mapSceneTaskBase = (MapSceneTaskBase)LuaObject.checkSelf(l);
			mapSceneTaskBase.m_luaExportHelper.__callBase_Pause();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015C94 RID: 89236 RVA: 0x0059E3F8 File Offset: 0x0059C5F8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_Resume(IntPtr l)
	{
		int result;
		try
		{
			MapSceneTaskBase mapSceneTaskBase = (MapSceneTaskBase)LuaObject.checkSelf(l);
			object param;
			LuaObject.checkType<object>(l, 2, out param);
			bool b = mapSceneTaskBase.m_luaExportHelper.__callBase_Resume(param);
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

	// Token: 0x06015C95 RID: 89237 RVA: 0x0059E460 File Offset: 0x0059C660
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearOnStopEvent(IntPtr l)
	{
		int result;
		try
		{
			MapSceneTaskBase mapSceneTaskBase = (MapSceneTaskBase)LuaObject.checkSelf(l);
			mapSceneTaskBase.m_luaExportHelper.__callBase_ClearOnStopEvent();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015C96 RID: 89238 RVA: 0x0059E4B4 File Offset: 0x0059C6B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ExecAfterTicks(IntPtr l)
	{
		int result;
		try
		{
			MapSceneTaskBase mapSceneTaskBase = (MapSceneTaskBase)LuaObject.checkSelf(l);
			Action action;
			LuaObject.checkDelegate<Action>(l, 2, out action);
			ulong delayTickCount;
			LuaObject.checkType(l, 3, out delayTickCount);
			mapSceneTaskBase.m_luaExportHelper.__callBase_ExecAfterTicks(action, delayTickCount);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015C97 RID: 89239 RVA: 0x0059E520 File Offset: 0x0059C720
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStart(IntPtr l)
	{
		int result;
		try
		{
			MapSceneTaskBase mapSceneTaskBase = (MapSceneTaskBase)LuaObject.checkSelf(l);
			object param;
			LuaObject.checkType<object>(l, 2, out param);
			bool b = mapSceneTaskBase.m_luaExportHelper.__callBase_OnStart(param);
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

	// Token: 0x06015C98 RID: 89240 RVA: 0x0059E588 File Offset: 0x0059C788
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnPause(IntPtr l)
	{
		int result;
		try
		{
			MapSceneTaskBase mapSceneTaskBase = (MapSceneTaskBase)LuaObject.checkSelf(l);
			mapSceneTaskBase.m_luaExportHelper.__callBase_OnPause();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015C99 RID: 89241 RVA: 0x0059E5DC File Offset: 0x0059C7DC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnResume(IntPtr l)
	{
		int result;
		try
		{
			MapSceneTaskBase mapSceneTaskBase = (MapSceneTaskBase)LuaObject.checkSelf(l);
			object param;
			LuaObject.checkType<object>(l, 2, out param);
			bool b = mapSceneTaskBase.m_luaExportHelper.__callBase_OnResume(param);
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

	// Token: 0x06015C9A RID: 89242 RVA: 0x0059E644 File Offset: 0x0059C844
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnStop(IntPtr l)
	{
		int result;
		try
		{
			MapSceneTaskBase mapSceneTaskBase = (MapSceneTaskBase)LuaObject.checkSelf(l);
			mapSceneTaskBase.m_luaExportHelper.__callBase_OnStop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015C9B RID: 89243 RVA: 0x0059E698 File Offset: 0x0059C898
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnTick(IntPtr l)
	{
		int result;
		try
		{
			MapSceneTaskBase mapSceneTaskBase = (MapSceneTaskBase)LuaObject.checkSelf(l);
			mapSceneTaskBase.m_luaExportHelper.__callBase_OnTick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015C9C RID: 89244 RVA: 0x0059E6EC File Offset: 0x0059C8EC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			MapSceneTaskBase mapSceneTaskBase = (MapSceneTaskBase)LuaObject.checkSelf(l);
			string s = mapSceneTaskBase.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x06015C9D RID: 89245 RVA: 0x0059E748 File Offset: 0x0059C948
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_pipeCtxDefault(IntPtr l)
	{
		int result;
		try
		{
			MapSceneTaskBase mapSceneTaskBase = (MapSceneTaskBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, mapSceneTaskBase.m_luaExportHelper.m_pipeCtxDefault);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015C9E RID: 89246 RVA: 0x0059E7A0 File Offset: 0x0059C9A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_pipeCtxDefault(IntPtr l)
	{
		int result;
		try
		{
			MapSceneTaskBase mapSceneTaskBase = (MapSceneTaskBase)LuaObject.checkSelf(l);
			MapSceneUpdatePipeLineCtxBase pipeCtxDefault;
			LuaObject.checkType<MapSceneUpdatePipeLineCtxBase>(l, 2, out pipeCtxDefault);
			mapSceneTaskBase.m_luaExportHelper.m_pipeCtxDefault = pipeCtxDefault;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015C9F RID: 89247 RVA: 0x0059E7FC File Offset: 0x0059C9FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_runingPipeLineCtxList(IntPtr l)
	{
		int result;
		try
		{
			MapSceneTaskBase mapSceneTaskBase = (MapSceneTaskBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, mapSceneTaskBase.m_luaExportHelper.m_runingPipeLineCtxList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015CA0 RID: 89248 RVA: 0x0059E854 File Offset: 0x0059CA54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_runingPipeLineCtxList(IntPtr l)
	{
		int result;
		try
		{
			MapSceneTaskBase mapSceneTaskBase = (MapSceneTaskBase)LuaObject.checkSelf(l);
			List<MapSceneUpdatePipeLineCtxBase> runingPipeLineCtxList;
			LuaObject.checkType<List<MapSceneUpdatePipeLineCtxBase>>(l, 2, out runingPipeLineCtxList);
			mapSceneTaskBase.m_luaExportHelper.m_runingPipeLineCtxList = runingPipeLineCtxList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015CA1 RID: 89249 RVA: 0x0059E8B0 File Offset: 0x0059CAB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_unusingPipeLineCtxList(IntPtr l)
	{
		int result;
		try
		{
			MapSceneTaskBase mapSceneTaskBase = (MapSceneTaskBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, mapSceneTaskBase.m_luaExportHelper.m_unusingPipeLineCtxList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015CA2 RID: 89250 RVA: 0x0059E908 File Offset: 0x0059CB08
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_unusingPipeLineCtxList(IntPtr l)
	{
		int result;
		try
		{
			MapSceneTaskBase mapSceneTaskBase = (MapSceneTaskBase)LuaObject.checkSelf(l);
			List<MapSceneUpdatePipeLineCtxBase> unusingPipeLineCtxList;
			LuaObject.checkType<List<MapSceneUpdatePipeLineCtxBase>>(l, 2, out unusingPipeLineCtxList);
			mapSceneTaskBase.m_luaExportHelper.m_unusingPipeLineCtxList = unusingPipeLineCtxList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015CA3 RID: 89251 RVA: 0x0059E964 File Offset: 0x0059CB64
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_pipeLineWait2Start(IntPtr l)
	{
		int result;
		try
		{
			MapSceneTaskBase mapSceneTaskBase = (MapSceneTaskBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, mapSceneTaskBase.m_luaExportHelper.m_pipeLineWait2Start);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015CA4 RID: 89252 RVA: 0x0059E9BC File Offset: 0x0059CBBC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_pipeLineWait2Start(IntPtr l)
	{
		int result;
		try
		{
			MapSceneTaskBase mapSceneTaskBase = (MapSceneTaskBase)LuaObject.checkSelf(l);
			List<MapSceneUpdatePipeLineCtxBase> pipeLineWait2Start;
			LuaObject.checkType<List<MapSceneUpdatePipeLineCtxBase>>(l, 2, out pipeLineWait2Start);
			mapSceneTaskBase.m_luaExportHelper.m_pipeLineWait2Start = pipeLineWait2Start;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015CA5 RID: 89253 RVA: 0x0059EA18 File Offset: 0x0059CC18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_layerArray(IntPtr l)
	{
		int result;
		try
		{
			MapSceneTaskBase mapSceneTaskBase = (MapSceneTaskBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, mapSceneTaskBase.m_luaExportHelper.m_layerArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015CA6 RID: 89254 RVA: 0x0059EA70 File Offset: 0x0059CC70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_layerArray(IntPtr l)
	{
		int result;
		try
		{
			MapSceneTaskBase mapSceneTaskBase = (MapSceneTaskBase)LuaObject.checkSelf(l);
			SceneLayerBase[] layerArray;
			LuaObject.checkArray<SceneLayerBase>(l, 2, out layerArray);
			mapSceneTaskBase.m_luaExportHelper.m_layerArray = layerArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015CA7 RID: 89255 RVA: 0x0059EACC File Offset: 0x0059CCCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_dynamicResCacheDict(IntPtr l)
	{
		int result;
		try
		{
			MapSceneTaskBase mapSceneTaskBase = (MapSceneTaskBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, mapSceneTaskBase.m_luaExportHelper.m_dynamicResCacheDict);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015CA8 RID: 89256 RVA: 0x0059EB24 File Offset: 0x0059CD24
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_dynamicResCacheDict(IntPtr l)
	{
		int result;
		try
		{
			MapSceneTaskBase mapSceneTaskBase = (MapSceneTaskBase)LuaObject.checkSelf(l);
			Dictionary<string, MapSceneTaskBase.DynamicResCacheItem> dynamicResCacheDict;
			LuaObject.checkType<Dictionary<string, MapSceneTaskBase.DynamicResCacheItem>>(l, 2, out dynamicResCacheDict);
			mapSceneTaskBase.m_luaExportHelper.m_dynamicResCacheDict = dynamicResCacheDict;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015CA9 RID: 89257 RVA: 0x0059EB80 File Offset: 0x0059CD80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_wait2ReleaseResList(IntPtr l)
	{
		int result;
		try
		{
			MapSceneTaskBase mapSceneTaskBase = (MapSceneTaskBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, mapSceneTaskBase.m_luaExportHelper.m_wait2ReleaseResList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015CAA RID: 89258 RVA: 0x0059EBD8 File Offset: 0x0059CDD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_wait2ReleaseResList(IntPtr l)
	{
		int result;
		try
		{
			MapSceneTaskBase mapSceneTaskBase = (MapSceneTaskBase)LuaObject.checkSelf(l);
			List<string> wait2ReleaseResList;
			LuaObject.checkType<List<string>>(l, 2, out wait2ReleaseResList);
			mapSceneTaskBase.m_luaExportHelper.m_wait2ReleaseResList = wait2ReleaseResList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015CAB RID: 89259 RVA: 0x0059EC34 File Offset: 0x0059CE34
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_corutineHelper(IntPtr l)
	{
		int result;
		try
		{
			MapSceneTaskBase mapSceneTaskBase = (MapSceneTaskBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, mapSceneTaskBase.m_luaExportHelper.m_corutineHelper);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015CAC RID: 89260 RVA: 0x0059EC8C File Offset: 0x0059CE8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_corutineHelper(IntPtr l)
	{
		int result;
		try
		{
			MapSceneTaskBase mapSceneTaskBase = (MapSceneTaskBase)LuaObject.checkSelf(l);
			TinyCorutineHelper corutineHelper;
			LuaObject.checkType<TinyCorutineHelper>(l, 2, out corutineHelper);
			mapSceneTaskBase.m_luaExportHelper.m_corutineHelper = corutineHelper;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015CAD RID: 89261 RVA: 0x0059ECE8 File Offset: 0x0059CEE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_unloadDynamicResTimeInterval(IntPtr l)
	{
		int result;
		try
		{
			MapSceneTaskBase mapSceneTaskBase = (MapSceneTaskBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, mapSceneTaskBase.m_luaExportHelper.m_unloadDynamicResTimeInterval);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015CAE RID: 89262 RVA: 0x0059ED40 File Offset: 0x0059CF40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_unloadDynamicResTimeInterval(IntPtr l)
	{
		int result;
		try
		{
			MapSceneTaskBase mapSceneTaskBase = (MapSceneTaskBase)LuaObject.checkSelf(l);
			int unloadDynamicResTimeInterval;
			LuaObject.checkType(l, 2, out unloadDynamicResTimeInterval);
			mapSceneTaskBase.m_luaExportHelper.m_unloadDynamicResTimeInterval = unloadDynamicResTimeInterval;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015CAF RID: 89263 RVA: 0x0059ED9C File Offset: 0x0059CF9C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_nextUnLoadDynamicResTime(IntPtr l)
	{
		int result;
		try
		{
			MapSceneTaskBase mapSceneTaskBase = (MapSceneTaskBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, mapSceneTaskBase.m_luaExportHelper.m_nextUnLoadDynamicResTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015CB0 RID: 89264 RVA: 0x0059EDF8 File Offset: 0x0059CFF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_nextUnLoadDynamicResTime(IntPtr l)
	{
		int result;
		try
		{
			MapSceneTaskBase mapSceneTaskBase = (MapSceneTaskBase)LuaObject.checkSelf(l);
			DateTime nextUnLoadDynamicResTime;
			LuaObject.checkValueType<DateTime>(l, 2, out nextUnLoadDynamicResTime);
			mapSceneTaskBase.m_luaExportHelper.m_nextUnLoadDynamicResTime = nextUnLoadDynamicResTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015CB1 RID: 89265 RVA: 0x0059EE54 File Offset: 0x0059D054
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_mainLayer(IntPtr l)
	{
		int result;
		try
		{
			MapSceneTaskBase mapSceneTaskBase = (MapSceneTaskBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, mapSceneTaskBase.m_luaExportHelper.m_mainLayer);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015CB2 RID: 89266 RVA: 0x0059EEAC File Offset: 0x0059D0AC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_LayerDescArray(IntPtr l)
	{
		int result;
		try
		{
			MapSceneTaskBase mapSceneTaskBase = (MapSceneTaskBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, mapSceneTaskBase.m_luaExportHelper.LayerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015CB3 RID: 89267 RVA: 0x0059EF04 File Offset: 0x0059D104
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.BJFramework.Runtime.TaskNs.MapSceneTaskBase");
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.InitPipeCtxDefault);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache0);
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache1);
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.OnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache2);
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.OnPause);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache3);
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.StartUpdatePipeLine);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache4);
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.AllocPipeLineCtx);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache5);
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.CreatePipeLineCtx);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache6);
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.StartPipeLineCtx);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache7);
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.ReleasePipeLineCtx);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache8);
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.IsNeedUpdateDataCache);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache9);
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.UpdateDataCache);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cacheA);
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.PreProcessBeforeResLoad);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cacheB);
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.IsNeedLoadStaticRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cacheC);
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.StartLoadStaticRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cacheD);
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.OnLoadStaticResCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cacheE);
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.IsNeedCollectAllDynamicResForLoad);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cacheF);
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.CollectAllDynamicResForLoad);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache10);
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.StartLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache11);
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.CalculateDynamicResReallyNeedLoad);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache12);
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.OnLoadDynamicResCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache13);
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.IsLoadAllResCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache14);
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.OnLoadAllResCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache15);
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.InitLayerStateOnLoadAllResCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache16);
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.StartUpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache17);
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.UpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache18);
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.PostUpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache19);
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.HideAllView);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache1A);
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.ClearAllContextAndRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache1B);
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.ClearContextOnPause);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache1C);
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.OnTick);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache1D);
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.ReleaseDynamicResCache);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache1E);
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.LockDynamicResCache);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache1F);
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.UnlockDynamicResCache);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache20);
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.UnlockAllDynamicResCache);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache21);
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.TickDynamicResCache);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache22);
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.__callBase_Start);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache23);
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.__callBase_Stop);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache24);
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.__callBase_Pause);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache25);
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.__callBase_Resume);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache26);
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.__callBase_ClearOnStopEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache27);
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.__callBase_ExecAfterTicks);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache28);
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.__callBase_OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache29);
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.__callBase_OnPause);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache2A);
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.__callBase_OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache2B);
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.__callBase_OnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache2C);
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.__callBase_OnTick);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache2D);
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache2E);
		string name = "m_pipeCtxDefault";
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.get_m_pipeCtxDefault);
		}
		LuaCSFunction get = Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache2F;
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.set_m_pipeCtxDefault);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache30, true);
		string name2 = "m_runingPipeLineCtxList";
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.get_m_runingPipeLineCtxList);
		}
		LuaCSFunction get2 = Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache31;
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.set_m_runingPipeLineCtxList);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache32, true);
		string name3 = "m_unusingPipeLineCtxList";
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.get_m_unusingPipeLineCtxList);
		}
		LuaCSFunction get3 = Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache33;
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.set_m_unusingPipeLineCtxList);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache34, true);
		string name4 = "m_pipeLineWait2Start";
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.get_m_pipeLineWait2Start);
		}
		LuaCSFunction get4 = Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache35;
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.set_m_pipeLineWait2Start);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache36, true);
		string name5 = "m_layerArray";
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.get_m_layerArray);
		}
		LuaCSFunction get5 = Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache37;
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.set_m_layerArray);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache38, true);
		string name6 = "m_dynamicResCacheDict";
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.get_m_dynamicResCacheDict);
		}
		LuaCSFunction get6 = Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache39;
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.set_m_dynamicResCacheDict);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache3A, true);
		string name7 = "m_wait2ReleaseResList";
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.get_m_wait2ReleaseResList);
		}
		LuaCSFunction get7 = Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache3B;
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.set_m_wait2ReleaseResList);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache3C, true);
		string name8 = "m_corutineHelper";
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.get_m_corutineHelper);
		}
		LuaCSFunction get8 = Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache3D;
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.set_m_corutineHelper);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache3E, true);
		string name9 = "m_unloadDynamicResTimeInterval";
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.get_m_unloadDynamicResTimeInterval);
		}
		LuaCSFunction get9 = Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache3F;
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.set_m_unloadDynamicResTimeInterval);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache40, true);
		string name10 = "m_nextUnLoadDynamicResTime";
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.get_m_nextUnLoadDynamicResTime);
		}
		LuaCSFunction get10 = Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache41;
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.set_m_nextUnLoadDynamicResTime);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache42, true);
		string name11 = "m_mainLayer";
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.get_m_mainLayer);
		}
		LuaObject.addMember(l, name11, Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache43, null, true);
		string name12 = "LayerDescArray";
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.get_LayerDescArray);
		}
		LuaObject.addMember(l, name12, Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache44, null, true);
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.<>f__mg$cache45, typeof(MapSceneTaskBase), typeof(Task));
	}

	// Token: 0x0400C40F RID: 50191
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400C410 RID: 50192
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400C411 RID: 50193
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400C412 RID: 50194
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400C413 RID: 50195
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400C414 RID: 50196
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400C415 RID: 50197
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400C416 RID: 50198
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400C417 RID: 50199
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400C418 RID: 50200
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400C419 RID: 50201
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400C41A RID: 50202
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400C41B RID: 50203
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400C41C RID: 50204
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400C41D RID: 50205
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400C41E RID: 50206
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400C41F RID: 50207
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400C420 RID: 50208
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400C421 RID: 50209
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400C422 RID: 50210
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400C423 RID: 50211
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400C424 RID: 50212
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400C425 RID: 50213
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400C426 RID: 50214
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400C427 RID: 50215
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400C428 RID: 50216
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0400C429 RID: 50217
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0400C42A RID: 50218
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0400C42B RID: 50219
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0400C42C RID: 50220
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0400C42D RID: 50221
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0400C42E RID: 50222
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0400C42F RID: 50223
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0400C430 RID: 50224
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0400C431 RID: 50225
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0400C432 RID: 50226
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0400C433 RID: 50227
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0400C434 RID: 50228
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0400C435 RID: 50229
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0400C436 RID: 50230
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0400C437 RID: 50231
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x0400C438 RID: 50232
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x0400C439 RID: 50233
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x0400C43A RID: 50234
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x0400C43B RID: 50235
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x0400C43C RID: 50236
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x0400C43D RID: 50237
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x0400C43E RID: 50238
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x0400C43F RID: 50239
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x0400C440 RID: 50240
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x0400C441 RID: 50241
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x0400C442 RID: 50242
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x0400C443 RID: 50243
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x0400C444 RID: 50244
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x0400C445 RID: 50245
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x0400C446 RID: 50246
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x0400C447 RID: 50247
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x0400C448 RID: 50248
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x0400C449 RID: 50249
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x0400C44A RID: 50250
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x0400C44B RID: 50251
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x0400C44C RID: 50252
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x0400C44D RID: 50253
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x0400C44E RID: 50254
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x0400C44F RID: 50255
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x0400C450 RID: 50256
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x0400C451 RID: 50257
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x0400C452 RID: 50258
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x0400C453 RID: 50259
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x0400C454 RID: 50260
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;
}
