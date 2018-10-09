using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020012BD RID: 4797
[Preserve]
public class Lua_BlackJack_ProjectL_PlayerContext_CommentComponent : LuaObject
{
	// Token: 0x06019399 RID: 103321 RVA: 0x0073855C File Offset: 0x0073675C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			CommentComponent o = new CommentComponent();
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

	// Token: 0x0601939A RID: 103322 RVA: 0x007385A4 File Offset: 0x007367A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Init(IntPtr l)
	{
		int result;
		try
		{
			CommentComponent commentComponent = (CommentComponent)LuaObject.checkSelf(l);
			commentComponent.Init();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601939B RID: 103323 RVA: 0x007385F0 File Offset: 0x007367F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PostInit(IntPtr l)
	{
		int result;
		try
		{
			CommentComponent commentComponent = (CommentComponent)LuaObject.checkSelf(l);
			commentComponent.PostInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601939C RID: 103324 RVA: 0x0073863C File Offset: 0x0073683C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DeInit(IntPtr l)
	{
		int result;
		try
		{
			CommentComponent commentComponent = (CommentComponent)LuaObject.checkSelf(l);
			commentComponent.DeInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601939D RID: 103325 RVA: 0x00738688 File Offset: 0x00736888
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetHeroComment(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				CommentComponent commentComponent = (CommentComponent)LuaObject.checkSelf(l);
				int heroId;
				LuaObject.checkType(l, 2, out heroId);
				HeroComment heroComment = commentComponent.GetHeroComment(heroId);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, heroComment);
				result = 2;
			}
			else if (num == 4)
			{
				CommentComponent commentComponent2 = (CommentComponent)LuaObject.checkSelf(l);
				int heroId2;
				LuaObject.checkType(l, 2, out heroId2);
				HeroComment heroComment2;
				LuaObject.checkType<HeroComment>(l, 3, out heroComment2);
				PlayerHeroCommentEntry playerCommentEntry;
				LuaObject.checkType<PlayerHeroCommentEntry>(l, 4, out playerCommentEntry);
				int heroComment3 = commentComponent2.GetHeroComment(heroId2, heroComment2, playerCommentEntry);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, heroComment3);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function GetHeroComment to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601939E RID: 103326 RVA: 0x0073876C File Offset: 0x0073696C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CommentHero(IntPtr l)
	{
		int result;
		try
		{
			CommentComponent commentComponent = (CommentComponent)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			HeroCommentEntry commentEntry;
			LuaObject.checkType<HeroCommentEntry>(l, 3, out commentEntry);
			long lastUpdateTime;
			LuaObject.checkType(l, 4, out lastUpdateTime);
			int i = commentComponent.CommentHero(heroId, commentEntry, lastUpdateTime);
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

	// Token: 0x0601939F RID: 103327 RVA: 0x007387E8 File Offset: 0x007369E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PraiseHeroCommentEntry(IntPtr l)
	{
		int result;
		try
		{
			CommentComponent commentComponent = (CommentComponent)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			ulong entryInstanceId;
			LuaObject.checkType(l, 3, out entryInstanceId);
			long lastUpdateTime;
			LuaObject.checkType(l, 4, out lastUpdateTime);
			int i = commentComponent.PraiseHeroCommentEntry(heroId, entryInstanceId, lastUpdateTime);
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

	// Token: 0x060193A0 RID: 103328 RVA: 0x00738864 File Offset: 0x00736A64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetHeroCommentEntries(IntPtr l)
	{
		int result;
		try
		{
			CommentComponent commentComponent = (CommentComponent)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			List<HeroCommentEntry> heroCommentEntries = commentComponent.GetHeroCommentEntries(heroId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroCommentEntries);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060193A1 RID: 103329 RVA: 0x007388C8 File Offset: 0x00736AC8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetLastUpdateTime(IntPtr l)
	{
		int result;
		try
		{
			CommentComponent commentComponent = (CommentComponent)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			long lastUpdateTime = commentComponent.GetLastUpdateTime(heroId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, lastUpdateTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060193A2 RID: 103330 RVA: 0x0073892C File Offset: 0x00736B2C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ClearAllComment(IntPtr l)
	{
		int result;
		try
		{
			CommentComponent commentComponent = (CommentComponent)LuaObject.checkSelf(l);
			commentComponent.ClearAllComment();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060193A3 RID: 103331 RVA: 0x00738978 File Offset: 0x00736B78
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int InitPlayerHeroCommentEntry(IntPtr l)
	{
		int result;
		try
		{
			CommentComponent commentComponent = (CommentComponent)LuaObject.checkSelf(l);
			HeroComment cacheHeroComment;
			LuaObject.checkType<HeroComment>(l, 2, out cacheHeroComment);
			PlayerHeroCommentEntry playerCommentEntry;
			LuaObject.checkType<PlayerHeroCommentEntry>(l, 3, out playerCommentEntry);
			commentComponent.m_luaExportHelper.InitPlayerHeroCommentEntry(cacheHeroComment, playerCommentEntry);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060193A4 RID: 103332 RVA: 0x007389E4 File Offset: 0x00736BE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddHeroComment(IntPtr l)
	{
		int result;
		try
		{
			CommentComponent commentComponent = (CommentComponent)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			HeroComment cacheHeroComment;
			LuaObject.checkType<HeroComment>(l, 3, out cacheHeroComment);
			HeroComment heroComment;
			LuaObject.checkType<HeroComment>(l, 4, out heroComment);
			commentComponent.m_luaExportHelper.AddHeroComment(heroId, cacheHeroComment, heroComment);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060193A5 RID: 103333 RVA: 0x00738A5C File Offset: 0x00736C5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FindHeroComment(IntPtr l)
	{
		int result;
		try
		{
			CommentComponent commentComponent = (CommentComponent)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			HeroComment o = commentComponent.m_luaExportHelper.FindHeroComment(heroId);
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

	// Token: 0x060193A6 RID: 103334 RVA: 0x00738AC4 File Offset: 0x00736CC4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_GetName(IntPtr l)
	{
		int result;
		try
		{
			CommentComponent commentComponent = (CommentComponent)LuaObject.checkSelf(l);
			string s = commentComponent.m_luaExportHelper.__callBase_GetName();
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

	// Token: 0x060193A7 RID: 103335 RVA: 0x00738B20 File Offset: 0x00736D20
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_Init(IntPtr l)
	{
		int result;
		try
		{
			CommentComponent commentComponent = (CommentComponent)LuaObject.checkSelf(l);
			commentComponent.m_luaExportHelper.__callBase_Init();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060193A8 RID: 103336 RVA: 0x00738B74 File Offset: 0x00736D74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PostInit(IntPtr l)
	{
		int result;
		try
		{
			CommentComponent commentComponent = (CommentComponent)LuaObject.checkSelf(l);
			commentComponent.m_luaExportHelper.__callBase_PostInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060193A9 RID: 103337 RVA: 0x00738BC8 File Offset: 0x00736DC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_DeInit(IntPtr l)
	{
		int result;
		try
		{
			CommentComponent commentComponent = (CommentComponent)LuaObject.checkSelf(l);
			commentComponent.m_luaExportHelper.__callBase_DeInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060193AA RID: 103338 RVA: 0x00738C1C File Offset: 0x00736E1C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_Tick(IntPtr l)
	{
		int result;
		try
		{
			CommentComponent commentComponent = (CommentComponent)LuaObject.checkSelf(l);
			uint deltaMillisecond;
			LuaObject.checkType(l, 2, out deltaMillisecond);
			commentComponent.m_luaExportHelper.__callBase_Tick(deltaMillisecond);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060193AB RID: 103339 RVA: 0x00738C78 File Offset: 0x00736E78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PostDeSerialize(IntPtr l)
	{
		int result;
		try
		{
			CommentComponent commentComponent = (CommentComponent)LuaObject.checkSelf(l);
			commentComponent.m_luaExportHelper.__callBase_PostDeSerialize();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060193AC RID: 103340 RVA: 0x00738CCC File Offset: 0x00736ECC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_CanCommentHero(IntPtr l)
	{
		int result;
		try
		{
			CommentComponent commentComponent = (CommentComponent)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			int i = commentComponent.m_luaExportHelper.__callBase_CanCommentHero(heroId);
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

	// Token: 0x060193AD RID: 103341 RVA: 0x00738D34 File Offset: 0x00736F34
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_CanPraiseHeroCommentEntry(IntPtr l)
	{
		int result;
		try
		{
			CommentComponent commentComponent = (CommentComponent)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			ulong entryInstanceId;
			LuaObject.checkType(l, 3, out entryInstanceId);
			int i = commentComponent.m_luaExportHelper.__callBase_CanPraiseHeroCommentEntry(heroId, entryInstanceId);
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

	// Token: 0x060193AE RID: 103342 RVA: 0x00738DA8 File Offset: 0x00736FA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CanGetHeroComment(IntPtr l)
	{
		int result;
		try
		{
			CommentComponent commentComponent = (CommentComponent)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			int i = commentComponent.m_luaExportHelper.__callBase_CanGetHeroComment(heroId);
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

	// Token: 0x060193AF RID: 103343 RVA: 0x00738E10 File Offset: 0x00737010
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_CanViewPlayerHero(IntPtr l)
	{
		int result;
		try
		{
			CommentComponent commentComponent = (CommentComponent)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			int i = commentComponent.m_luaExportHelper.__callBase_CanViewPlayerHero(heroId);
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

	// Token: 0x060193B0 RID: 103344 RVA: 0x00738E78 File Offset: 0x00737078
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_IsNeedTruncateHeroComment(IntPtr l)
	{
		int result;
		try
		{
			CommentComponent commentComponent = (CommentComponent)LuaObject.checkSelf(l);
			string content;
			LuaObject.checkType(l, 2, out content);
			bool b = commentComponent.m_luaExportHelper.__callBase_IsNeedTruncateHeroComment(content);
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

	// Token: 0x060193B1 RID: 103345 RVA: 0x00738EE0 File Offset: 0x007370E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_TruncateHeroComment(IntPtr l)
	{
		int result;
		try
		{
			CommentComponent commentComponent = (CommentComponent)LuaObject.checkSelf(l);
			string content;
			LuaObject.checkType(l, 2, out content);
			string s = commentComponent.m_luaExportHelper.__callBase_TruncateHeroComment(content);
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

	// Token: 0x060193B2 RID: 103346 RVA: 0x00738F48 File Offset: 0x00737148
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_FindPlayerHeroCommentEntry(IntPtr l)
	{
		int result;
		try
		{
			CommentComponent commentComponent = (CommentComponent)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			PlayerHeroCommentEntry o = commentComponent.m_luaExportHelper.__callBase_FindPlayerHeroCommentEntry(heroId);
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

	// Token: 0x060193B3 RID: 103347 RVA: 0x00738FB0 File Offset: 0x007371B0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_heroComments(IntPtr l)
	{
		int result;
		try
		{
			CommentComponent commentComponent = (CommentComponent)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, commentComponent.m_luaExportHelper.m_heroComments);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060193B4 RID: 103348 RVA: 0x00739008 File Offset: 0x00737208
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroComments(IntPtr l)
	{
		int result;
		try
		{
			CommentComponent commentComponent = (CommentComponent)LuaObject.checkSelf(l);
			Dictionary<int, HeroComment> heroComments;
			LuaObject.checkType<Dictionary<int, HeroComment>>(l, 2, out heroComments);
			commentComponent.m_luaExportHelper.m_heroComments = heroComments;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060193B5 RID: 103349 RVA: 0x00739064 File Offset: 0x00737264
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.PlayerContext.CommentComponent");
		if (Lua_BlackJack_ProjectL_PlayerContext_CommentComponent.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_CommentComponent.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_CommentComponent.Init);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_CommentComponent.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_PlayerContext_CommentComponent.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_CommentComponent.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_CommentComponent.PostInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_CommentComponent.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_PlayerContext_CommentComponent.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_CommentComponent.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_CommentComponent.DeInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_CommentComponent.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_PlayerContext_CommentComponent.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_CommentComponent.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_CommentComponent.GetHeroComment);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_CommentComponent.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_PlayerContext_CommentComponent.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_CommentComponent.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_CommentComponent.CommentHero);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_CommentComponent.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_PlayerContext_CommentComponent.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_CommentComponent.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_CommentComponent.PraiseHeroCommentEntry);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_CommentComponent.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_PlayerContext_CommentComponent.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_CommentComponent.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_CommentComponent.GetHeroCommentEntries);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_CommentComponent.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_PlayerContext_CommentComponent.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_CommentComponent.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_CommentComponent.GetLastUpdateTime);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_CommentComponent.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_PlayerContext_CommentComponent.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_CommentComponent.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_CommentComponent.ClearAllComment);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_CommentComponent.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_PlayerContext_CommentComponent.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_CommentComponent.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_CommentComponent.InitPlayerHeroCommentEntry);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_CommentComponent.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_PlayerContext_CommentComponent.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_CommentComponent.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_CommentComponent.AddHeroComment);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_CommentComponent.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_PlayerContext_CommentComponent.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_CommentComponent.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_CommentComponent.FindHeroComment);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_CommentComponent.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_PlayerContext_CommentComponent.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_CommentComponent.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_CommentComponent.__callBase_GetName);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_CommentComponent.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_PlayerContext_CommentComponent.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_CommentComponent.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_CommentComponent.__callBase_Init);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_CommentComponent.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_PlayerContext_CommentComponent.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_CommentComponent.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_CommentComponent.__callBase_PostInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_CommentComponent.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_PlayerContext_CommentComponent.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_CommentComponent.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_CommentComponent.__callBase_DeInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_CommentComponent.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_PlayerContext_CommentComponent.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_CommentComponent.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_CommentComponent.__callBase_Tick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_CommentComponent.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_PlayerContext_CommentComponent.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_CommentComponent.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_CommentComponent.__callBase_PostDeSerialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_CommentComponent.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_PlayerContext_CommentComponent.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_CommentComponent.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_CommentComponent.__callBase_CanCommentHero);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_CommentComponent.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_PlayerContext_CommentComponent.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_CommentComponent.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_CommentComponent.__callBase_CanPraiseHeroCommentEntry);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_CommentComponent.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_PlayerContext_CommentComponent.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_CommentComponent.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_CommentComponent.__callBase_CanGetHeroComment);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_CommentComponent.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_PlayerContext_CommentComponent.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_CommentComponent.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_CommentComponent.__callBase_CanViewPlayerHero);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_CommentComponent.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_PlayerContext_CommentComponent.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_CommentComponent.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_CommentComponent.__callBase_IsNeedTruncateHeroComment);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_CommentComponent.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_PlayerContext_CommentComponent.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_CommentComponent.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_CommentComponent.__callBase_TruncateHeroComment);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_CommentComponent.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_PlayerContext_CommentComponent.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_CommentComponent.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_CommentComponent.__callBase_FindPlayerHeroCommentEntry);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_CommentComponent.<>f__mg$cache18);
		string name = "m_heroComments";
		if (Lua_BlackJack_ProjectL_PlayerContext_CommentComponent.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_CommentComponent.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_CommentComponent.get_m_heroComments);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_PlayerContext_CommentComponent.<>f__mg$cache19;
		if (Lua_BlackJack_ProjectL_PlayerContext_CommentComponent.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_CommentComponent.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_CommentComponent.set_m_heroComments);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_PlayerContext_CommentComponent.<>f__mg$cache1A, true);
		if (Lua_BlackJack_ProjectL_PlayerContext_CommentComponent.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_CommentComponent.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_CommentComponent.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_PlayerContext_CommentComponent.<>f__mg$cache1B, typeof(CommentComponent), typeof(CommentComponentCommon));
	}

	// Token: 0x0400F801 RID: 63489
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400F802 RID: 63490
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400F803 RID: 63491
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400F804 RID: 63492
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400F805 RID: 63493
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400F806 RID: 63494
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400F807 RID: 63495
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400F808 RID: 63496
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400F809 RID: 63497
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400F80A RID: 63498
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400F80B RID: 63499
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400F80C RID: 63500
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400F80D RID: 63501
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400F80E RID: 63502
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400F80F RID: 63503
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400F810 RID: 63504
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400F811 RID: 63505
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400F812 RID: 63506
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400F813 RID: 63507
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400F814 RID: 63508
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400F815 RID: 63509
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400F816 RID: 63510
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400F817 RID: 63511
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400F818 RID: 63512
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400F819 RID: 63513
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400F81A RID: 63514
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0400F81B RID: 63515
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0400F81C RID: 63516
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;
}
