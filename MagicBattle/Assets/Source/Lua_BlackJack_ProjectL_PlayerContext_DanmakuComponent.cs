using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020012C0 RID: 4800
[Preserve]
public class Lua_BlackJack_ProjectL_PlayerContext_DanmakuComponent : LuaObject
{
	// Token: 0x060193F0 RID: 103408 RVA: 0x0073AFB4 File Offset: 0x007391B4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			DanmakuComponent o = new DanmakuComponent();
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

	// Token: 0x060193F1 RID: 103409 RVA: 0x0073AFFC File Offset: 0x007391FC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Init(IntPtr l)
	{
		int result;
		try
		{
			DanmakuComponent danmakuComponent = (DanmakuComponent)LuaObject.checkSelf(l);
			danmakuComponent.Init();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060193F2 RID: 103410 RVA: 0x0073B048 File Offset: 0x00739248
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PostInit(IntPtr l)
	{
		int result;
		try
		{
			DanmakuComponent danmakuComponent = (DanmakuComponent)LuaObject.checkSelf(l);
			danmakuComponent.PostInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060193F3 RID: 103411 RVA: 0x0073B094 File Offset: 0x00739294
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DeInit(IntPtr l)
	{
		int result;
		try
		{
			DanmakuComponent danmakuComponent = (DanmakuComponent)LuaObject.checkSelf(l);
			danmakuComponent.DeInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060193F4 RID: 103412 RVA: 0x0073B0E0 File Offset: 0x007392E0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetLevelDanmaku(IntPtr l)
	{
		int result;
		try
		{
			DanmakuComponent danmakuComponent = (DanmakuComponent)LuaObject.checkSelf(l);
			LevelDanmaku levelDanmaku;
			LuaObject.checkType<LevelDanmaku>(l, 2, out levelDanmaku);
			danmakuComponent.SetLevelDanmaku(levelDanmaku);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060193F5 RID: 103413 RVA: 0x0073B138 File Offset: 0x00739338
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetLevelDanmaku(IntPtr l)
	{
		int result;
		try
		{
			DanmakuComponent danmakuComponent = (DanmakuComponent)LuaObject.checkSelf(l);
			LevelDanmaku levelDanmaku = danmakuComponent.GetLevelDanmaku();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, levelDanmaku);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060193F6 RID: 103414 RVA: 0x0073B18C File Offset: 0x0073938C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PostLevelDanmaku(IntPtr l)
	{
		int result;
		try
		{
			DanmakuComponent danmakuComponent = (DanmakuComponent)LuaObject.checkSelf(l);
			PostDanmakuEntry entry;
			LuaObject.checkType<PostDanmakuEntry>(l, 2, out entry);
			danmakuComponent.PostLevelDanmaku(entry);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060193F7 RID: 103415 RVA: 0x0073B1E4 File Offset: 0x007393E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearLevelDanmaku(IntPtr l)
	{
		int result;
		try
		{
			DanmakuComponent danmakuComponent = (DanmakuComponent)LuaObject.checkSelf(l);
			danmakuComponent.ClearLevelDanmaku();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060193F8 RID: 103416 RVA: 0x0073B230 File Offset: 0x00739430
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetPostedLevelDanmaku(IntPtr l)
	{
		int result;
		try
		{
			DanmakuComponent danmakuComponent = (DanmakuComponent)LuaObject.checkSelf(l);
			List<PostDanmakuEntry> postedLevelDanmaku = danmakuComponent.GetPostedLevelDanmaku();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, postedLevelDanmaku);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060193F9 RID: 103417 RVA: 0x0073B284 File Offset: 0x00739484
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ClearNewSendDanmakuTurnList(IntPtr l)
	{
		int result;
		try
		{
			DanmakuComponent danmakuComponent = (DanmakuComponent)LuaObject.checkSelf(l);
			danmakuComponent.ClearNewSendDanmakuTurnList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060193FA RID: 103418 RVA: 0x0073B2D0 File Offset: 0x007394D0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int FilterSensitiveWords(IntPtr l)
	{
		int result;
		try
		{
			DanmakuComponent danmakuComponent = (DanmakuComponent)LuaObject.checkSelf(l);
			danmakuComponent.m_luaExportHelper.FilterSensitiveWords();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060193FB RID: 103419 RVA: 0x0073B324 File Offset: 0x00739524
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int BuildLevelDanmakuOrderByTime(IntPtr l)
	{
		int result;
		try
		{
			DanmakuComponent danmakuComponent = (DanmakuComponent)LuaObject.checkSelf(l);
			LevelDanmaku source;
			LuaObject.checkType<LevelDanmaku>(l, 2, out source);
			LevelDanmaku o = danmakuComponent.m_luaExportHelper.BuildLevelDanmakuOrderByTime(source);
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

	// Token: 0x060193FC RID: 103420 RVA: 0x0073B38C File Offset: 0x0073958C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int AddPostDanmakuEntryToLocalLevelDanmaku(IntPtr l)
	{
		int result;
		try
		{
			DanmakuComponent danmakuComponent = (DanmakuComponent)LuaObject.checkSelf(l);
			PostDanmakuEntry entry;
			LuaObject.checkType<PostDanmakuEntry>(l, 2, out entry);
			danmakuComponent.m_luaExportHelper.AddPostDanmakuEntryToLocalLevelDanmaku(entry);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060193FD RID: 103421 RVA: 0x0073B3E8 File Offset: 0x007395E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddTurnDanmakuToLevelDanmaku(IntPtr l)
	{
		int result;
		try
		{
			DanmakuComponent danmakuComponent = (DanmakuComponent)LuaObject.checkSelf(l);
			PostDanmakuEntry entry;
			LuaObject.checkType<PostDanmakuEntry>(l, 2, out entry);
			danmakuComponent.m_luaExportHelper.AddTurnDanmakuToLevelDanmaku(entry);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060193FE RID: 103422 RVA: 0x0073B444 File Offset: 0x00739644
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CreateDanmakuEntry(IntPtr l)
	{
		int result;
		try
		{
			DanmakuComponent danmakuComponent = (DanmakuComponent)LuaObject.checkSelf(l);
			PostDanmakuEntry entry;
			LuaObject.checkType<PostDanmakuEntry>(l, 2, out entry);
			DanmakuEntry o = danmakuComponent.m_luaExportHelper.CreateDanmakuEntry(entry);
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

	// Token: 0x060193FF RID: 103423 RVA: 0x0073B4AC File Offset: 0x007396AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetName(IntPtr l)
	{
		int result;
		try
		{
			DanmakuComponent danmakuComponent = (DanmakuComponent)LuaObject.checkSelf(l);
			string s = danmakuComponent.m_luaExportHelper.__callBase_GetName();
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

	// Token: 0x06019400 RID: 103424 RVA: 0x0073B508 File Offset: 0x00739708
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Init(IntPtr l)
	{
		int result;
		try
		{
			DanmakuComponent danmakuComponent = (DanmakuComponent)LuaObject.checkSelf(l);
			danmakuComponent.m_luaExportHelper.__callBase_Init();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019401 RID: 103425 RVA: 0x0073B55C File Offset: 0x0073975C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_PostInit(IntPtr l)
	{
		int result;
		try
		{
			DanmakuComponent danmakuComponent = (DanmakuComponent)LuaObject.checkSelf(l);
			danmakuComponent.m_luaExportHelper.__callBase_PostInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019402 RID: 103426 RVA: 0x0073B5B0 File Offset: 0x007397B0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_DeInit(IntPtr l)
	{
		int result;
		try
		{
			DanmakuComponent danmakuComponent = (DanmakuComponent)LuaObject.checkSelf(l);
			danmakuComponent.m_luaExportHelper.__callBase_DeInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019403 RID: 103427 RVA: 0x0073B604 File Offset: 0x00739804
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Tick(IntPtr l)
	{
		int result;
		try
		{
			DanmakuComponent danmakuComponent = (DanmakuComponent)LuaObject.checkSelf(l);
			uint deltaMillisecond;
			LuaObject.checkType(l, 2, out deltaMillisecond);
			danmakuComponent.m_luaExportHelper.__callBase_Tick(deltaMillisecond);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019404 RID: 103428 RVA: 0x0073B660 File Offset: 0x00739860
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_PostDeSerialize(IntPtr l)
	{
		int result;
		try
		{
			DanmakuComponent danmakuComponent = (DanmakuComponent)LuaObject.checkSelf(l);
			danmakuComponent.m_luaExportHelper.__callBase_PostDeSerialize();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019405 RID: 103429 RVA: 0x0073B6B4 File Offset: 0x007398B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CanGetLevelDanmaku(IntPtr l)
	{
		int result;
		try
		{
			DanmakuComponent danmakuComponent = (DanmakuComponent)LuaObject.checkSelf(l);
			int gameFunctionTypeId;
			LuaObject.checkType(l, 2, out gameFunctionTypeId);
			int locationId;
			LuaObject.checkType(l, 3, out locationId);
			int i = danmakuComponent.m_luaExportHelper.__callBase_CanGetLevelDanmaku(gameFunctionTypeId, locationId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019406 RID: 103430 RVA: 0x0073B728 File Offset: 0x00739928
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_CanPostLevelDanmaku(IntPtr l)
	{
		int result;
		try
		{
			DanmakuComponent danmakuComponent = (DanmakuComponent)LuaObject.checkSelf(l);
			int gameFunctionTypeId;
			LuaObject.checkType(l, 2, out gameFunctionTypeId);
			int locationId;
			LuaObject.checkType(l, 3, out locationId);
			List<PostDanmakuEntry> entries;
			LuaObject.checkType<List<PostDanmakuEntry>>(l, 4, out entries);
			int i = danmakuComponent.m_luaExportHelper.__callBase_CanPostLevelDanmaku(gameFunctionTypeId, locationId, entries);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019407 RID: 103431 RVA: 0x0073B7AC File Offset: 0x007399AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CombineLevelDanmakuKey(IntPtr l)
	{
		int result;
		try
		{
			DanmakuComponent danmakuComponent = (DanmakuComponent)LuaObject.checkSelf(l);
			int gameFunctionTypeId;
			LuaObject.checkType(l, 2, out gameFunctionTypeId);
			int locationId;
			LuaObject.checkType(l, 3, out locationId);
			string s = danmakuComponent.m_luaExportHelper.__callBase_CombineLevelDanmakuKey(gameFunctionTypeId, locationId);
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

	// Token: 0x06019408 RID: 103432 RVA: 0x0073B820 File Offset: 0x00739A20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_TruncateDanmakuOrNot(IntPtr l)
	{
		int result;
		try
		{
			DanmakuComponent danmakuComponent = (DanmakuComponent)LuaObject.checkSelf(l);
			PostDanmakuEntry entry;
			LuaObject.checkType<PostDanmakuEntry>(l, 2, out entry);
			danmakuComponent.m_luaExportHelper.__callBase_TruncateDanmakuOrNot(entry);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019409 RID: 103433 RVA: 0x0073B87C File Offset: 0x00739A7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_postDanmakuEntries(IntPtr l)
	{
		int result;
		try
		{
			DanmakuComponent danmakuComponent = (DanmakuComponent)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, danmakuComponent.m_luaExportHelper.m_postDanmakuEntries);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601940A RID: 103434 RVA: 0x0073B8D4 File Offset: 0x00739AD4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_postDanmakuEntries(IntPtr l)
	{
		int result;
		try
		{
			DanmakuComponent danmakuComponent = (DanmakuComponent)LuaObject.checkSelf(l);
			List<PostDanmakuEntry> postDanmakuEntries;
			LuaObject.checkType<List<PostDanmakuEntry>>(l, 2, out postDanmakuEntries);
			danmakuComponent.m_luaExportHelper.m_postDanmakuEntries = postDanmakuEntries;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601940B RID: 103435 RVA: 0x0073B930 File Offset: 0x00739B30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_levelDanmaku(IntPtr l)
	{
		int result;
		try
		{
			DanmakuComponent danmakuComponent = (DanmakuComponent)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, danmakuComponent.m_luaExportHelper.m_levelDanmaku);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601940C RID: 103436 RVA: 0x0073B988 File Offset: 0x00739B88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_levelDanmaku(IntPtr l)
	{
		int result;
		try
		{
			DanmakuComponent danmakuComponent = (DanmakuComponent)LuaObject.checkSelf(l);
			LevelDanmaku levelDanmaku;
			LuaObject.checkType<LevelDanmaku>(l, 2, out levelDanmaku);
			danmakuComponent.m_luaExportHelper.m_levelDanmaku = levelDanmaku;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601940D RID: 103437 RVA: 0x0073B9E4 File Offset: 0x00739BE4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_newSendDanmakuTurnList(IntPtr l)
	{
		int result;
		try
		{
			DanmakuComponent danmakuComponent = (DanmakuComponent)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, danmakuComponent.m_luaExportHelper.m_newSendDanmakuTurnList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601940E RID: 103438 RVA: 0x0073BA3C File Offset: 0x00739C3C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_newSendDanmakuTurnList(IntPtr l)
	{
		int result;
		try
		{
			DanmakuComponent danmakuComponent = (DanmakuComponent)LuaObject.checkSelf(l);
			List<int> newSendDanmakuTurnList;
			LuaObject.checkType<List<int>>(l, 2, out newSendDanmakuTurnList);
			danmakuComponent.m_luaExportHelper.m_newSendDanmakuTurnList = newSendDanmakuTurnList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601940F RID: 103439 RVA: 0x0073BA98 File Offset: 0x00739C98
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.PlayerContext.DanmakuComponent");
		if (Lua_BlackJack_ProjectL_PlayerContext_DanmakuComponent.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_DanmakuComponent.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_DanmakuComponent.Init);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_DanmakuComponent.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_PlayerContext_DanmakuComponent.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_DanmakuComponent.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_DanmakuComponent.PostInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_DanmakuComponent.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_PlayerContext_DanmakuComponent.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_DanmakuComponent.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_DanmakuComponent.DeInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_DanmakuComponent.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_PlayerContext_DanmakuComponent.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_DanmakuComponent.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_DanmakuComponent.SetLevelDanmaku);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_DanmakuComponent.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_PlayerContext_DanmakuComponent.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_DanmakuComponent.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_DanmakuComponent.GetLevelDanmaku);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_DanmakuComponent.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_PlayerContext_DanmakuComponent.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_DanmakuComponent.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_DanmakuComponent.PostLevelDanmaku);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_DanmakuComponent.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_PlayerContext_DanmakuComponent.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_DanmakuComponent.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_DanmakuComponent.ClearLevelDanmaku);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_DanmakuComponent.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_PlayerContext_DanmakuComponent.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_DanmakuComponent.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_DanmakuComponent.GetPostedLevelDanmaku);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_DanmakuComponent.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_PlayerContext_DanmakuComponent.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_DanmakuComponent.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_DanmakuComponent.ClearNewSendDanmakuTurnList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_DanmakuComponent.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_PlayerContext_DanmakuComponent.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_DanmakuComponent.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_DanmakuComponent.FilterSensitiveWords);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_DanmakuComponent.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_PlayerContext_DanmakuComponent.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_DanmakuComponent.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_DanmakuComponent.BuildLevelDanmakuOrderByTime);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_DanmakuComponent.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_PlayerContext_DanmakuComponent.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_DanmakuComponent.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_DanmakuComponent.AddPostDanmakuEntryToLocalLevelDanmaku);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_DanmakuComponent.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_PlayerContext_DanmakuComponent.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_DanmakuComponent.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_DanmakuComponent.AddTurnDanmakuToLevelDanmaku);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_DanmakuComponent.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_PlayerContext_DanmakuComponent.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_DanmakuComponent.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_DanmakuComponent.CreateDanmakuEntry);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_DanmakuComponent.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_PlayerContext_DanmakuComponent.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_DanmakuComponent.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_DanmakuComponent.__callBase_GetName);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_DanmakuComponent.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_PlayerContext_DanmakuComponent.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_DanmakuComponent.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_DanmakuComponent.__callBase_Init);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_DanmakuComponent.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_PlayerContext_DanmakuComponent.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_DanmakuComponent.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_DanmakuComponent.__callBase_PostInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_DanmakuComponent.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_PlayerContext_DanmakuComponent.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_DanmakuComponent.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_DanmakuComponent.__callBase_DeInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_DanmakuComponent.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_PlayerContext_DanmakuComponent.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_DanmakuComponent.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_DanmakuComponent.__callBase_Tick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_DanmakuComponent.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_PlayerContext_DanmakuComponent.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_DanmakuComponent.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_DanmakuComponent.__callBase_PostDeSerialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_DanmakuComponent.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_PlayerContext_DanmakuComponent.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_DanmakuComponent.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_DanmakuComponent.__callBase_CanGetLevelDanmaku);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_DanmakuComponent.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_PlayerContext_DanmakuComponent.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_DanmakuComponent.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_DanmakuComponent.__callBase_CanPostLevelDanmaku);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_DanmakuComponent.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_PlayerContext_DanmakuComponent.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_DanmakuComponent.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_DanmakuComponent.__callBase_CombineLevelDanmakuKey);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_DanmakuComponent.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_PlayerContext_DanmakuComponent.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_DanmakuComponent.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_DanmakuComponent.__callBase_TruncateDanmakuOrNot);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_DanmakuComponent.<>f__mg$cache17);
		string name = "m_postDanmakuEntries";
		if (Lua_BlackJack_ProjectL_PlayerContext_DanmakuComponent.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_DanmakuComponent.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_DanmakuComponent.get_m_postDanmakuEntries);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_PlayerContext_DanmakuComponent.<>f__mg$cache18;
		if (Lua_BlackJack_ProjectL_PlayerContext_DanmakuComponent.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_DanmakuComponent.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_DanmakuComponent.set_m_postDanmakuEntries);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_PlayerContext_DanmakuComponent.<>f__mg$cache19, true);
		string name2 = "m_levelDanmaku";
		if (Lua_BlackJack_ProjectL_PlayerContext_DanmakuComponent.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_DanmakuComponent.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_DanmakuComponent.get_m_levelDanmaku);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_PlayerContext_DanmakuComponent.<>f__mg$cache1A;
		if (Lua_BlackJack_ProjectL_PlayerContext_DanmakuComponent.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_DanmakuComponent.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_DanmakuComponent.set_m_levelDanmaku);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_PlayerContext_DanmakuComponent.<>f__mg$cache1B, true);
		string name3 = "m_newSendDanmakuTurnList";
		if (Lua_BlackJack_ProjectL_PlayerContext_DanmakuComponent.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_DanmakuComponent.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_DanmakuComponent.get_m_newSendDanmakuTurnList);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_PlayerContext_DanmakuComponent.<>f__mg$cache1C;
		if (Lua_BlackJack_ProjectL_PlayerContext_DanmakuComponent.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_DanmakuComponent.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_DanmakuComponent.set_m_newSendDanmakuTurnList);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_PlayerContext_DanmakuComponent.<>f__mg$cache1D, true);
		if (Lua_BlackJack_ProjectL_PlayerContext_DanmakuComponent.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_DanmakuComponent.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_DanmakuComponent.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_PlayerContext_DanmakuComponent.<>f__mg$cache1E, typeof(DanmakuComponent), typeof(DanmakuComponentCommon));
	}

	// Token: 0x0400F852 RID: 63570
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400F853 RID: 63571
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400F854 RID: 63572
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400F855 RID: 63573
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400F856 RID: 63574
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400F857 RID: 63575
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400F858 RID: 63576
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400F859 RID: 63577
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400F85A RID: 63578
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400F85B RID: 63579
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400F85C RID: 63580
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400F85D RID: 63581
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400F85E RID: 63582
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400F85F RID: 63583
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400F860 RID: 63584
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400F861 RID: 63585
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400F862 RID: 63586
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400F863 RID: 63587
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400F864 RID: 63588
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400F865 RID: 63589
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400F866 RID: 63590
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400F867 RID: 63591
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400F868 RID: 63592
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400F869 RID: 63593
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400F86A RID: 63594
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400F86B RID: 63595
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0400F86C RID: 63596
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0400F86D RID: 63597
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0400F86E RID: 63598
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0400F86F RID: 63599
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0400F870 RID: 63600
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;
}
