using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.Protocol;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020012C8 RID: 4808
[Preserve]
public class Lua_BlackJack_ProjectL_PlayerContext_GuildComponent : LuaObject
{
	// Token: 0x060194B8 RID: 103608 RVA: 0x00740CC8 File Offset: 0x0073EEC8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			GuildComponent o = new GuildComponent();
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

	// Token: 0x060194B9 RID: 103609 RVA: 0x00740D10 File Offset: 0x0073EF10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Init(IntPtr l)
	{
		int result;
		try
		{
			GuildComponent guildComponent = (GuildComponent)LuaObject.checkSelf(l);
			guildComponent.Init();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060194BA RID: 103610 RVA: 0x00740D5C File Offset: 0x0073EF5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetGuildLogContent(IntPtr l)
	{
		int result;
		try
		{
			GuildComponent guildComponent = (GuildComponent)LuaObject.checkSelf(l);
			GuildLog log;
			LuaObject.checkType<GuildLog>(l, 2, out log);
			string guildLogContent = guildComponent.GetGuildLogContent(log);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildLogContent);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060194BB RID: 103611 RVA: 0x00740DC0 File Offset: 0x0073EFC0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetGuildDataSection(IntPtr l)
	{
		int result;
		try
		{
			GuildComponent guildComponent = (GuildComponent)LuaObject.checkSelf(l);
			DSGuildNtf guildDataSection;
			LuaObject.checkType<DSGuildNtf>(l, 2, out guildDataSection);
			guildComponent.SetGuildDataSection(guildDataSection);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060194BC RID: 103612 RVA: 0x00740E18 File Offset: 0x0073F018
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int RefreshGuild(IntPtr l)
	{
		int result;
		try
		{
			GuildComponent guildComponent = (GuildComponent)LuaObject.checkSelf(l);
			ProGuild proGuild;
			LuaObject.checkType<ProGuild>(l, 2, out proGuild);
			guildComponent.RefreshGuild(proGuild);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060194BD RID: 103613 RVA: 0x00740E70 File Offset: 0x0073F070
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int RefreshGuildListJoinState(IntPtr l)
	{
		int result;
		try
		{
			GuildComponent guildComponent = (GuildComponent)LuaObject.checkSelf(l);
			string id;
			LuaObject.checkType(l, 2, out id);
			bool isJoinRequest;
			LuaObject.checkType(l, 3, out isJoinRequest);
			guildComponent.RefreshGuildListJoinState(id, isJoinRequest);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060194BE RID: 103614 RVA: 0x00740ED4 File Offset: 0x0073F0D4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int PlayerRefuseGuild(IntPtr l)
	{
		int result;
		try
		{
			GuildComponent guildComponent = (GuildComponent)LuaObject.checkSelf(l);
			string guildID;
			LuaObject.checkType(l, 2, out guildID);
			guildComponent.PlayerRefuseGuild(guildID);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060194BF RID: 103615 RVA: 0x00740F2C File Offset: 0x0073F12C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ResetGuild(IntPtr l)
	{
		int result;
		try
		{
			GuildComponent guildComponent = (GuildComponent)LuaObject.checkSelf(l);
			guildComponent.ResetGuild();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060194C0 RID: 103616 RVA: 0x00740F78 File Offset: 0x0073F178
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_GetName(IntPtr l)
	{
		int result;
		try
		{
			GuildComponent guildComponent = (GuildComponent)LuaObject.checkSelf(l);
			string s = guildComponent.m_luaExportHelper.__callBase_GetName();
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

	// Token: 0x060194C1 RID: 103617 RVA: 0x00740FD4 File Offset: 0x0073F1D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Init(IntPtr l)
	{
		int result;
		try
		{
			GuildComponent guildComponent = (GuildComponent)LuaObject.checkSelf(l);
			guildComponent.m_luaExportHelper.__callBase_Init();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060194C2 RID: 103618 RVA: 0x00741028 File Offset: 0x0073F228
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PostInit(IntPtr l)
	{
		int result;
		try
		{
			GuildComponent guildComponent = (GuildComponent)LuaObject.checkSelf(l);
			guildComponent.m_luaExportHelper.__callBase_PostInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060194C3 RID: 103619 RVA: 0x0074107C File Offset: 0x0073F27C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_DeInit(IntPtr l)
	{
		int result;
		try
		{
			GuildComponent guildComponent = (GuildComponent)LuaObject.checkSelf(l);
			guildComponent.m_luaExportHelper.__callBase_DeInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060194C4 RID: 103620 RVA: 0x007410D0 File Offset: 0x0073F2D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Tick(IntPtr l)
	{
		int result;
		try
		{
			GuildComponent guildComponent = (GuildComponent)LuaObject.checkSelf(l);
			uint deltaMillisecond;
			LuaObject.checkType(l, 2, out deltaMillisecond);
			guildComponent.m_luaExportHelper.__callBase_Tick(deltaMillisecond);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060194C5 RID: 103621 RVA: 0x0074112C File Offset: 0x0073F32C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_PostDeSerialize(IntPtr l)
	{
		int result;
		try
		{
			GuildComponent guildComponent = (GuildComponent)LuaObject.checkSelf(l);
			guildComponent.m_luaExportHelper.__callBase_PostDeSerialize();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060194C6 RID: 103622 RVA: 0x00741180 File Offset: 0x0073F380
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_HasOwnGuild(IntPtr l)
	{
		int result;
		try
		{
			GuildComponent guildComponent = (GuildComponent)LuaObject.checkSelf(l);
			bool b = guildComponent.m_luaExportHelper.__callBase_HasOwnGuild();
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

	// Token: 0x060194C7 RID: 103623 RVA: 0x007411DC File Offset: 0x0073F3DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_QuitGuild(IntPtr l)
	{
		int result;
		try
		{
			GuildComponent guildComponent = (GuildComponent)LuaObject.checkSelf(l);
			DateTime nextJoinTime;
			LuaObject.checkValueType<DateTime>(l, 2, out nextJoinTime);
			guildComponent.m_luaExportHelper.__callBase_QuitGuild(nextJoinTime);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060194C8 RID: 103624 RVA: 0x00741238 File Offset: 0x0073F438
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_GetGuildId(IntPtr l)
	{
		int result;
		try
		{
			GuildComponent guildComponent = (GuildComponent)LuaObject.checkSelf(l);
			string s = guildComponent.m_luaExportHelper.__callBase_GetGuildId();
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

	// Token: 0x060194C9 RID: 103625 RVA: 0x00741294 File Offset: 0x0073F494
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetGuildId(IntPtr l)
	{
		int result;
		try
		{
			GuildComponent guildComponent = (GuildComponent)LuaObject.checkSelf(l);
			string id;
			LuaObject.checkType(l, 2, out id);
			guildComponent.m_luaExportHelper.__callBase_SetGuildId(id);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060194CA RID: 103626 RVA: 0x007412F0 File Offset: 0x0073F4F0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_CanCreateGuild(IntPtr l)
	{
		int result;
		try
		{
			GuildComponent guildComponent = (GuildComponent)LuaObject.checkSelf(l);
			string guildName;
			LuaObject.checkType(l, 2, out guildName);
			string hiringDeclaration;
			LuaObject.checkType(l, 3, out hiringDeclaration);
			int joinLevel;
			LuaObject.checkType(l, 4, out joinLevel);
			int i = guildComponent.m_luaExportHelper.__callBase_CanCreateGuild(guildName, hiringDeclaration, joinLevel);
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

	// Token: 0x060194CB RID: 103627 RVA: 0x00741374 File Offset: 0x0073F574
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_CanJoinGuild(IntPtr l)
	{
		int result;
		try
		{
			GuildComponent guildComponent = (GuildComponent)LuaObject.checkSelf(l);
			int i = guildComponent.m_luaExportHelper.__callBase_CanJoinGuild();
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

	// Token: 0x060194CC RID: 103628 RVA: 0x007413D0 File Offset: 0x0073F5D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CanQuitGuild(IntPtr l)
	{
		int result;
		try
		{
			GuildComponent guildComponent = (GuildComponent)LuaObject.checkSelf(l);
			int i = guildComponent.m_luaExportHelper.__callBase_CanQuitGuild();
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

	// Token: 0x060194CD RID: 103629 RVA: 0x0074142C File Offset: 0x0073F62C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CanKickOutGuild(IntPtr l)
	{
		int result;
		try
		{
			GuildComponent guildComponent = (GuildComponent)LuaObject.checkSelf(l);
			int i = guildComponent.m_luaExportHelper.__callBase_CanKickOutGuild();
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

	// Token: 0x060194CE RID: 103630 RVA: 0x00741488 File Offset: 0x0073F688
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_CanApplyToJoinGuild(IntPtr l)
	{
		int result;
		try
		{
			GuildComponent guildComponent = (GuildComponent)LuaObject.checkSelf(l);
			int i = guildComponent.m_luaExportHelper.__callBase_CanApplyToJoinGuild();
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

	// Token: 0x060194CF RID: 103631 RVA: 0x007414E4 File Offset: 0x0073F6E4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_CanConfirmJoinGuildInvitation(IntPtr l)
	{
		int result;
		try
		{
			GuildComponent guildComponent = (GuildComponent)LuaObject.checkSelf(l);
			string guildId;
			LuaObject.checkType(l, 2, out guildId);
			int i = guildComponent.m_luaExportHelper.__callBase_CanConfirmJoinGuildInvitation(guildId);
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

	// Token: 0x060194D0 RID: 103632 RVA: 0x0074154C File Offset: 0x0073F74C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_RefuseJoinGuildInvitation(IntPtr l)
	{
		int result;
		try
		{
			GuildComponent guildComponent = (GuildComponent)LuaObject.checkSelf(l);
			string guildId;
			LuaObject.checkType(l, 2, out guildId);
			guildComponent.m_luaExportHelper.__callBase_RefuseJoinGuildInvitation(guildId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060194D1 RID: 103633 RVA: 0x007415A8 File Offset: 0x0073F7A8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_RefuseAllJoinGuildInvitation(IntPtr l)
	{
		int result;
		try
		{
			GuildComponent guildComponent = (GuildComponent)LuaObject.checkSelf(l);
			guildComponent.m_luaExportHelper.__callBase_RefuseAllJoinGuildInvitation();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060194D2 RID: 103634 RVA: 0x007415FC File Offset: 0x0073F7FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CheckGuildName(IntPtr l)
	{
		int result;
		try
		{
			GuildComponent guildComponent = (GuildComponent)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			int i = guildComponent.m_luaExportHelper.__callBase_CheckGuildName(name);
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

	// Token: 0x060194D3 RID: 103635 RVA: 0x00741664 File Offset: 0x0073F864
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_CheckGuildSearch(IntPtr l)
	{
		int result;
		try
		{
			GuildComponent guildComponent = (GuildComponent)LuaObject.checkSelf(l);
			string searchText;
			LuaObject.checkType(l, 2, out searchText);
			int i = guildComponent.m_luaExportHelper.__callBase_CheckGuildSearch(searchText);
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

	// Token: 0x060194D4 RID: 103636 RVA: 0x007416CC File Offset: 0x0073F8CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CheckGuildRandomList(IntPtr l)
	{
		int result;
		try
		{
			GuildComponent guildComponent = (GuildComponent)LuaObject.checkSelf(l);
			int i = guildComponent.m_luaExportHelper.__callBase_CheckGuildRandomList();
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

	// Token: 0x060194D5 RID: 103637 RVA: 0x00741728 File Offset: 0x0073F928
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CheckGuildInvitePlayerList(IntPtr l)
	{
		int result;
		try
		{
			GuildComponent guildComponent = (GuildComponent)LuaObject.checkSelf(l);
			int i = guildComponent.m_luaExportHelper.__callBase_CheckGuildInvitePlayerList();
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

	// Token: 0x060194D6 RID: 103638 RVA: 0x00741784 File Offset: 0x0073F984
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_CanSetGuildHiringDeclaration(IntPtr l)
	{
		int result;
		try
		{
			GuildComponent guildComponent = (GuildComponent)LuaObject.checkSelf(l);
			string hiringDeclaration;
			LuaObject.checkType(l, 2, out hiringDeclaration);
			int i = guildComponent.m_luaExportHelper.__callBase_CanSetGuildHiringDeclaration(hiringDeclaration);
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

	// Token: 0x060194D7 RID: 103639 RVA: 0x007417EC File Offset: 0x0073F9EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CheckGuildHiringDeclaration(IntPtr l)
	{
		int result;
		try
		{
			GuildComponent guildComponent = (GuildComponent)LuaObject.checkSelf(l);
			string hiringDeclaration;
			LuaObject.checkType(l, 2, out hiringDeclaration);
			int i = guildComponent.m_luaExportHelper.__callBase_CheckGuildHiringDeclaration(hiringDeclaration);
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

	// Token: 0x060194D8 RID: 103640 RVA: 0x00741854 File Offset: 0x0073FA54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CanSetGuildAnnouncement(IntPtr l)
	{
		int result;
		try
		{
			GuildComponent guildComponent = (GuildComponent)LuaObject.checkSelf(l);
			string announcement;
			LuaObject.checkType(l, 2, out announcement);
			int i = guildComponent.m_luaExportHelper.__callBase_CanSetGuildAnnouncement(announcement);
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

	// Token: 0x060194D9 RID: 103641 RVA: 0x007418BC File Offset: 0x0073FABC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CheckGuildAnnouncement(IntPtr l)
	{
		int result;
		try
		{
			GuildComponent guildComponent = (GuildComponent)LuaObject.checkSelf(l);
			string announcement;
			LuaObject.checkType(l, 2, out announcement);
			int i = guildComponent.m_luaExportHelper.__callBase_CheckGuildAnnouncement(announcement);
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

	// Token: 0x060194DA RID: 103642 RVA: 0x00741924 File Offset: 0x0073FB24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CanStartMassiveCombat(IntPtr l)
	{
		int result;
		try
		{
			GuildComponent guildComponent = (GuildComponent)LuaObject.checkSelf(l);
			int i = guildComponent.m_luaExportHelper.__callBase_CanStartMassiveCombat();
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

	// Token: 0x060194DB RID: 103643 RVA: 0x00741980 File Offset: 0x0073FB80
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_CanTheseHeroesAttackStronghold(IntPtr l)
	{
		int result;
		try
		{
			GuildComponent guildComponent = (GuildComponent)LuaObject.checkSelf(l);
			List<int> heroIds;
			LuaObject.checkType<List<int>>(l, 2, out heroIds);
			int i = guildComponent.m_luaExportHelper.__callBase_CanTheseHeroesAttackStronghold(heroIds);
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

	// Token: 0x060194DC RID: 103644 RVA: 0x007419E8 File Offset: 0x0073FBE8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_CanAttackStronghold(IntPtr l)
	{
		int result;
		try
		{
			GuildComponent guildComponent = (GuildComponent)LuaObject.checkSelf(l);
			int levelId;
			LuaObject.checkType(l, 2, out levelId);
			int i = guildComponent.m_luaExportHelper.__callBase_CanAttackStronghold(levelId);
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

	// Token: 0x060194DD RID: 103645 RVA: 0x00741A50 File Offset: 0x0073FC50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetMassiveCombatUnusedHeroes(IntPtr l)
	{
		int result;
		try
		{
			GuildComponent guildComponent = (GuildComponent)LuaObject.checkSelf(l);
			List<Hero> o = guildComponent.m_luaExportHelper.__callBase_GetMassiveCombatUnusedHeroes();
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

	// Token: 0x060194DE RID: 103646 RVA: 0x00741AAC File Offset: 0x0073FCAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetEliminateRate(IntPtr l)
	{
		int result;
		try
		{
			GuildComponent guildComponent = (GuildComponent)LuaObject.checkSelf(l);
			GuildMassiveCombatInfo combat;
			LuaObject.checkType<GuildMassiveCombatInfo>(l, 2, out combat);
			int i = guildComponent.m_luaExportHelper.__callBase_GetEliminateRate(combat);
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

	// Token: 0x060194DF RID: 103647 RVA: 0x00741B14 File Offset: 0x0073FD14
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_GetStrongholdEliminateRate(IntPtr l)
	{
		int result;
		try
		{
			GuildComponent guildComponent = (GuildComponent)LuaObject.checkSelf(l);
			GuildMassiveCombatStronghold stronghold;
			LuaObject.checkType<GuildMassiveCombatStronghold>(l, 2, out stronghold);
			int i = guildComponent.m_luaExportHelper.__callBase_GetStrongholdEliminateRate(stronghold);
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

	// Token: 0x060194E0 RID: 103648 RVA: 0x00741B7C File Offset: 0x0073FD7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetStartedCombatThisWeek(IntPtr l)
	{
		int result;
		try
		{
			GuildComponent guildComponent = (GuildComponent)LuaObject.checkSelf(l);
			GuildMassiveCombatGeneral generalInfo;
			LuaObject.checkType<GuildMassiveCombatGeneral>(l, 2, out generalInfo);
			int i = guildComponent.m_luaExportHelper.__callBase_GetStartedCombatThisWeek(generalInfo);
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

	// Token: 0x060194E1 RID: 103649 RVA: 0x00741BE4 File Offset: 0x0073FDE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_guild(IntPtr l)
	{
		int result;
		try
		{
			GuildComponent guildComponent = (GuildComponent)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildComponent.m_guild);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060194E2 RID: 103650 RVA: 0x00741C38 File Offset: 0x0073FE38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_guild(IntPtr l)
	{
		int result;
		try
		{
			GuildComponent guildComponent = (GuildComponent)LuaObject.checkSelf(l);
			Guild guild;
			LuaObject.checkType<Guild>(l, 2, out guild);
			guildComponent.m_guild = guild;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060194E3 RID: 103651 RVA: 0x00741C90 File Offset: 0x0073FE90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_guildInviteUserIdList(IntPtr l)
	{
		int result;
		try
		{
			GuildComponent guildComponent = (GuildComponent)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildComponent.m_guildInviteUserIdList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060194E4 RID: 103652 RVA: 0x00741CE4 File Offset: 0x0073FEE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_guildInviteUserIdList(IntPtr l)
	{
		int result;
		try
		{
			GuildComponent guildComponent = (GuildComponent)LuaObject.checkSelf(l);
			List<string> guildInviteUserIdList;
			LuaObject.checkType<List<string>>(l, 2, out guildInviteUserIdList);
			guildComponent.m_guildInviteUserIdList = guildInviteUserIdList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060194E5 RID: 103653 RVA: 0x00741D3C File Offset: 0x0073FF3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_guildSearchList(IntPtr l)
	{
		int result;
		try
		{
			GuildComponent guildComponent = (GuildComponent)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildComponent.m_guildSearchList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060194E6 RID: 103654 RVA: 0x00741D90 File Offset: 0x0073FF90
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_guildSearchList(IntPtr l)
	{
		int result;
		try
		{
			GuildComponent guildComponent = (GuildComponent)LuaObject.checkSelf(l);
			List<GuildSearchInfo> guildSearchList;
			LuaObject.checkType<List<GuildSearchInfo>>(l, 2, out guildSearchList);
			guildComponent.m_guildSearchList = guildSearchList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060194E7 RID: 103655 RVA: 0x00741DE8 File Offset: 0x0073FFE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_guildRecommendList(IntPtr l)
	{
		int result;
		try
		{
			GuildComponent guildComponent = (GuildComponent)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildComponent.m_guildRecommendList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060194E8 RID: 103656 RVA: 0x00741E3C File Offset: 0x0074003C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_guildRecommendList(IntPtr l)
	{
		int result;
		try
		{
			GuildComponent guildComponent = (GuildComponent)LuaObject.checkSelf(l);
			List<GuildSearchInfo> guildRecommendList;
			LuaObject.checkType<List<GuildSearchInfo>>(l, 2, out guildRecommendList);
			guildComponent.m_guildRecommendList = guildRecommendList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060194E9 RID: 103657 RVA: 0x00741E94 File Offset: 0x00740094
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_guildJoinInvitationList(IntPtr l)
	{
		int result;
		try
		{
			GuildComponent guildComponent = (GuildComponent)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildComponent.m_guildJoinInvitationList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060194EA RID: 103658 RVA: 0x00741EE8 File Offset: 0x007400E8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_guildJoinInvitationList(IntPtr l)
	{
		int result;
		try
		{
			GuildComponent guildComponent = (GuildComponent)LuaObject.checkSelf(l);
			List<GuildJoinInvitation> guildJoinInvitationList;
			LuaObject.checkType<List<GuildJoinInvitation>>(l, 2, out guildJoinInvitationList);
			guildComponent.m_guildJoinInvitationList = guildJoinInvitationList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060194EB RID: 103659 RVA: 0x00741F40 File Offset: 0x00740140
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_guildJoinApplyList(IntPtr l)
	{
		int result;
		try
		{
			GuildComponent guildComponent = (GuildComponent)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildComponent.m_guildJoinApplyList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060194EC RID: 103660 RVA: 0x00741F94 File Offset: 0x00740194
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_guildJoinApplyList(IntPtr l)
	{
		int result;
		try
		{
			GuildComponent guildComponent = (GuildComponent)LuaObject.checkSelf(l);
			List<UserSummary> guildJoinApplyList;
			LuaObject.checkType<List<UserSummary>>(l, 2, out guildJoinApplyList);
			guildComponent.m_guildJoinApplyList = guildJoinApplyList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060194ED RID: 103661 RVA: 0x00741FEC File Offset: 0x007401EC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.PlayerContext.GuildComponent");
		if (Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.Init);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.GetGuildLogContent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.SetGuildDataSection);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.RefreshGuild);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.RefreshGuildListJoinState);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.PlayerRefuseGuild);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.ResetGuild);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.__callBase_GetName);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.__callBase_Init);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.__callBase_PostInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.__callBase_DeInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.__callBase_Tick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.__callBase_PostDeSerialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.__callBase_HasOwnGuild);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.__callBase_QuitGuild);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.__callBase_GetGuildId);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.__callBase_SetGuildId);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.__callBase_CanCreateGuild);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.__callBase_CanJoinGuild);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.__callBase_CanQuitGuild);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.__callBase_CanKickOutGuild);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.__callBase_CanApplyToJoinGuild);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.__callBase_CanConfirmJoinGuildInvitation);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.__callBase_RefuseJoinGuildInvitation);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.__callBase_RefuseAllJoinGuildInvitation);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.__callBase_CheckGuildName);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.__callBase_CheckGuildSearch);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.__callBase_CheckGuildRandomList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.__callBase_CheckGuildInvitePlayerList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.__callBase_CanSetGuildHiringDeclaration);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.__callBase_CheckGuildHiringDeclaration);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.__callBase_CanSetGuildAnnouncement);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.__callBase_CheckGuildAnnouncement);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.__callBase_CanStartMassiveCombat);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.__callBase_CanTheseHeroesAttackStronghold);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.__callBase_CanAttackStronghold);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.__callBase_GetMassiveCombatUnusedHeroes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.__callBase_GetEliminateRate);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cache25);
		if (Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.__callBase_GetStrongholdEliminateRate);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cache26);
		if (Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.__callBase_GetStartedCombatThisWeek);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cache27);
		string name = "m_guild";
		if (Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.get_m_guild);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cache28;
		if (Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.set_m_guild);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cache29, true);
		string name2 = "m_guildInviteUserIdList";
		if (Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.get_m_guildInviteUserIdList);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cache2A;
		if (Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.set_m_guildInviteUserIdList);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cache2B, true);
		string name3 = "m_guildSearchList";
		if (Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.get_m_guildSearchList);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cache2C;
		if (Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.set_m_guildSearchList);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cache2D, true);
		string name4 = "m_guildRecommendList";
		if (Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.get_m_guildRecommendList);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cache2E;
		if (Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.set_m_guildRecommendList);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cache2F, true);
		string name5 = "m_guildJoinInvitationList";
		if (Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.get_m_guildJoinInvitationList);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cache30;
		if (Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.set_m_guildJoinInvitationList);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cache31, true);
		string name6 = "m_guildJoinApplyList";
		if (Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.get_m_guildJoinApplyList);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cache32;
		if (Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.set_m_guildJoinApplyList);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cache33, true);
		if (Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.<>f__mg$cache34, typeof(GuildComponent), typeof(GuildComponentCommon));
	}

	// Token: 0x0400F90A RID: 63754
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400F90B RID: 63755
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400F90C RID: 63756
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400F90D RID: 63757
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400F90E RID: 63758
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400F90F RID: 63759
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400F910 RID: 63760
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400F911 RID: 63761
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400F912 RID: 63762
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400F913 RID: 63763
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400F914 RID: 63764
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400F915 RID: 63765
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400F916 RID: 63766
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400F917 RID: 63767
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400F918 RID: 63768
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400F919 RID: 63769
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400F91A RID: 63770
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400F91B RID: 63771
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400F91C RID: 63772
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400F91D RID: 63773
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400F91E RID: 63774
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400F91F RID: 63775
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400F920 RID: 63776
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400F921 RID: 63777
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400F922 RID: 63778
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400F923 RID: 63779
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0400F924 RID: 63780
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0400F925 RID: 63781
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0400F926 RID: 63782
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0400F927 RID: 63783
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0400F928 RID: 63784
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0400F929 RID: 63785
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0400F92A RID: 63786
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0400F92B RID: 63787
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0400F92C RID: 63788
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0400F92D RID: 63789
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0400F92E RID: 63790
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0400F92F RID: 63791
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0400F930 RID: 63792
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0400F931 RID: 63793
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0400F932 RID: 63794
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x0400F933 RID: 63795
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x0400F934 RID: 63796
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x0400F935 RID: 63797
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x0400F936 RID: 63798
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x0400F937 RID: 63799
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x0400F938 RID: 63800
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x0400F939 RID: 63801
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x0400F93A RID: 63802
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x0400F93B RID: 63803
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x0400F93C RID: 63804
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x0400F93D RID: 63805
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x0400F93E RID: 63806
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;
}
