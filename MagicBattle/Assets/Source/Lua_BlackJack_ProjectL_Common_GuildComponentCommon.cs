using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200122C RID: 4652
[Preserve]
public class Lua_BlackJack_ProjectL_Common_GuildComponentCommon : LuaObject
{
	// Token: 0x060181E8 RID: 98792 RVA: 0x006B442C File Offset: 0x006B262C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			GuildComponentCommon o = new GuildComponentCommon();
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

	// Token: 0x060181E9 RID: 98793 RVA: 0x006B4474 File Offset: 0x006B2674
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetName(IntPtr l)
	{
		int result;
		try
		{
			GuildComponentCommon guildComponentCommon = (GuildComponentCommon)LuaObject.checkSelf(l);
			string name = guildComponentCommon.GetName();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, name);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060181EA RID: 98794 RVA: 0x006B44C8 File Offset: 0x006B26C8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Init(IntPtr l)
	{
		int result;
		try
		{
			GuildComponentCommon guildComponentCommon = (GuildComponentCommon)LuaObject.checkSelf(l);
			guildComponentCommon.Init();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060181EB RID: 98795 RVA: 0x006B4514 File Offset: 0x006B2714
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PostInit(IntPtr l)
	{
		int result;
		try
		{
			GuildComponentCommon guildComponentCommon = (GuildComponentCommon)LuaObject.checkSelf(l);
			guildComponentCommon.PostInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060181EC RID: 98796 RVA: 0x006B4560 File Offset: 0x006B2760
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int DeInit(IntPtr l)
	{
		int result;
		try
		{
			GuildComponentCommon guildComponentCommon = (GuildComponentCommon)LuaObject.checkSelf(l);
			guildComponentCommon.DeInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060181ED RID: 98797 RVA: 0x006B45AC File Offset: 0x006B27AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Tick(IntPtr l)
	{
		int result;
		try
		{
			GuildComponentCommon guildComponentCommon = (GuildComponentCommon)LuaObject.checkSelf(l);
			uint deltaMillisecond;
			LuaObject.checkType(l, 2, out deltaMillisecond);
			guildComponentCommon.Tick(deltaMillisecond);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060181EE RID: 98798 RVA: 0x006B4604 File Offset: 0x006B2804
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PostDeSerialize(IntPtr l)
	{
		int result;
		try
		{
			GuildComponentCommon guildComponentCommon = (GuildComponentCommon)LuaObject.checkSelf(l);
			guildComponentCommon.PostDeSerialize();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060181EF RID: 98799 RVA: 0x006B4650 File Offset: 0x006B2850
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HasOwnGuild(IntPtr l)
	{
		int result;
		try
		{
			GuildComponentCommon guildComponentCommon = (GuildComponentCommon)LuaObject.checkSelf(l);
			bool b = guildComponentCommon.HasOwnGuild();
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

	// Token: 0x060181F0 RID: 98800 RVA: 0x006B46A4 File Offset: 0x006B28A4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int QuitGuild(IntPtr l)
	{
		int result;
		try
		{
			GuildComponentCommon guildComponentCommon = (GuildComponentCommon)LuaObject.checkSelf(l);
			DateTime nextJoinTime;
			LuaObject.checkValueType<DateTime>(l, 2, out nextJoinTime);
			guildComponentCommon.QuitGuild(nextJoinTime);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060181F1 RID: 98801 RVA: 0x006B46FC File Offset: 0x006B28FC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetGuildId(IntPtr l)
	{
		int result;
		try
		{
			GuildComponentCommon guildComponentCommon = (GuildComponentCommon)LuaObject.checkSelf(l);
			string guildId = guildComponentCommon.GetGuildId();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060181F2 RID: 98802 RVA: 0x006B4750 File Offset: 0x006B2950
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetGuildId(IntPtr l)
	{
		int result;
		try
		{
			GuildComponentCommon guildComponentCommon = (GuildComponentCommon)LuaObject.checkSelf(l);
			string guildId;
			LuaObject.checkType(l, 2, out guildId);
			guildComponentCommon.SetGuildId(guildId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060181F3 RID: 98803 RVA: 0x006B47A8 File Offset: 0x006B29A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CanCreateGuild(IntPtr l)
	{
		int result;
		try
		{
			GuildComponentCommon guildComponentCommon = (GuildComponentCommon)LuaObject.checkSelf(l);
			string guildName;
			LuaObject.checkType(l, 2, out guildName);
			string hiringDeclaration;
			LuaObject.checkType(l, 3, out hiringDeclaration);
			int joinLevel;
			LuaObject.checkType(l, 4, out joinLevel);
			int i = guildComponentCommon.CanCreateGuild(guildName, hiringDeclaration, joinLevel);
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

	// Token: 0x060181F4 RID: 98804 RVA: 0x006B4824 File Offset: 0x006B2A24
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CanJoinGuild(IntPtr l)
	{
		int result;
		try
		{
			GuildComponentCommon guildComponentCommon = (GuildComponentCommon)LuaObject.checkSelf(l);
			int i = guildComponentCommon.CanJoinGuild();
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

	// Token: 0x060181F5 RID: 98805 RVA: 0x006B4878 File Offset: 0x006B2A78
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CanQuitGuild(IntPtr l)
	{
		int result;
		try
		{
			GuildComponentCommon guildComponentCommon = (GuildComponentCommon)LuaObject.checkSelf(l);
			int i = guildComponentCommon.CanQuitGuild();
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

	// Token: 0x060181F6 RID: 98806 RVA: 0x006B48CC File Offset: 0x006B2ACC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CanKickOutGuild(IntPtr l)
	{
		int result;
		try
		{
			GuildComponentCommon guildComponentCommon = (GuildComponentCommon)LuaObject.checkSelf(l);
			int i = guildComponentCommon.CanKickOutGuild();
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

	// Token: 0x060181F7 RID: 98807 RVA: 0x006B4920 File Offset: 0x006B2B20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CanApplyToJoinGuild(IntPtr l)
	{
		int result;
		try
		{
			GuildComponentCommon guildComponentCommon = (GuildComponentCommon)LuaObject.checkSelf(l);
			int i = guildComponentCommon.CanApplyToJoinGuild();
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

	// Token: 0x060181F8 RID: 98808 RVA: 0x006B4974 File Offset: 0x006B2B74
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CanConfirmJoinGuildInvitation(IntPtr l)
	{
		int result;
		try
		{
			GuildComponentCommon guildComponentCommon = (GuildComponentCommon)LuaObject.checkSelf(l);
			string guildId;
			LuaObject.checkType(l, 2, out guildId);
			int i = guildComponentCommon.CanConfirmJoinGuildInvitation(guildId);
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

	// Token: 0x060181F9 RID: 98809 RVA: 0x006B49D8 File Offset: 0x006B2BD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RefuseJoinGuildInvitation(IntPtr l)
	{
		int result;
		try
		{
			GuildComponentCommon guildComponentCommon = (GuildComponentCommon)LuaObject.checkSelf(l);
			string guildId;
			LuaObject.checkType(l, 2, out guildId);
			guildComponentCommon.RefuseJoinGuildInvitation(guildId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060181FA RID: 98810 RVA: 0x006B4A30 File Offset: 0x006B2C30
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int RefuseAllJoinGuildInvitation(IntPtr l)
	{
		int result;
		try
		{
			GuildComponentCommon guildComponentCommon = (GuildComponentCommon)LuaObject.checkSelf(l);
			guildComponentCommon.RefuseAllJoinGuildInvitation();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060181FB RID: 98811 RVA: 0x006B4A7C File Offset: 0x006B2C7C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CheckGuildName(IntPtr l)
	{
		int result;
		try
		{
			GuildComponentCommon guildComponentCommon = (GuildComponentCommon)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			int i = guildComponentCommon.CheckGuildName(name);
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

	// Token: 0x060181FC RID: 98812 RVA: 0x006B4AE0 File Offset: 0x006B2CE0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CheckGuildSearch(IntPtr l)
	{
		int result;
		try
		{
			GuildComponentCommon guildComponentCommon = (GuildComponentCommon)LuaObject.checkSelf(l);
			string searchText;
			LuaObject.checkType(l, 2, out searchText);
			int i = guildComponentCommon.CheckGuildSearch(searchText);
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

	// Token: 0x060181FD RID: 98813 RVA: 0x006B4B44 File Offset: 0x006B2D44
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CheckGuildRandomList(IntPtr l)
	{
		int result;
		try
		{
			GuildComponentCommon guildComponentCommon = (GuildComponentCommon)LuaObject.checkSelf(l);
			int i = guildComponentCommon.CheckGuildRandomList();
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

	// Token: 0x060181FE RID: 98814 RVA: 0x006B4B98 File Offset: 0x006B2D98
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CheckGuildInvitePlayerList(IntPtr l)
	{
		int result;
		try
		{
			GuildComponentCommon guildComponentCommon = (GuildComponentCommon)LuaObject.checkSelf(l);
			int i = guildComponentCommon.CheckGuildInvitePlayerList();
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

	// Token: 0x060181FF RID: 98815 RVA: 0x006B4BEC File Offset: 0x006B2DEC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CanSetGuildHiringDeclaration(IntPtr l)
	{
		int result;
		try
		{
			GuildComponentCommon guildComponentCommon = (GuildComponentCommon)LuaObject.checkSelf(l);
			string hiringDeclaration;
			LuaObject.checkType(l, 2, out hiringDeclaration);
			int i = guildComponentCommon.CanSetGuildHiringDeclaration(hiringDeclaration);
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

	// Token: 0x06018200 RID: 98816 RVA: 0x006B4C50 File Offset: 0x006B2E50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CheckGuildHiringDeclaration(IntPtr l)
	{
		int result;
		try
		{
			GuildComponentCommon guildComponentCommon = (GuildComponentCommon)LuaObject.checkSelf(l);
			string hiringDeclaration;
			LuaObject.checkType(l, 2, out hiringDeclaration);
			int i = guildComponentCommon.CheckGuildHiringDeclaration(hiringDeclaration);
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

	// Token: 0x06018201 RID: 98817 RVA: 0x006B4CB4 File Offset: 0x006B2EB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CanSetGuildAnnouncement(IntPtr l)
	{
		int result;
		try
		{
			GuildComponentCommon guildComponentCommon = (GuildComponentCommon)LuaObject.checkSelf(l);
			string announcement;
			LuaObject.checkType(l, 2, out announcement);
			int i = guildComponentCommon.CanSetGuildAnnouncement(announcement);
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

	// Token: 0x06018202 RID: 98818 RVA: 0x006B4D18 File Offset: 0x006B2F18
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CheckGuildAnnouncement(IntPtr l)
	{
		int result;
		try
		{
			GuildComponentCommon guildComponentCommon = (GuildComponentCommon)LuaObject.checkSelf(l);
			string announcement;
			LuaObject.checkType(l, 2, out announcement);
			int i = guildComponentCommon.CheckGuildAnnouncement(announcement);
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

	// Token: 0x06018203 RID: 98819 RVA: 0x006B4D7C File Offset: 0x006B2F7C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CanStartMassiveCombat(IntPtr l)
	{
		int result;
		try
		{
			GuildComponentCommon guildComponentCommon = (GuildComponentCommon)LuaObject.checkSelf(l);
			int i = guildComponentCommon.CanStartMassiveCombat();
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

	// Token: 0x06018204 RID: 98820 RVA: 0x006B4DD0 File Offset: 0x006B2FD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CanTheseHeroesAttackStronghold(IntPtr l)
	{
		int result;
		try
		{
			GuildComponentCommon guildComponentCommon = (GuildComponentCommon)LuaObject.checkSelf(l);
			List<int> heroIds;
			LuaObject.checkType<List<int>>(l, 2, out heroIds);
			int i = guildComponentCommon.CanTheseHeroesAttackStronghold(heroIds);
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

	// Token: 0x06018205 RID: 98821 RVA: 0x006B4E34 File Offset: 0x006B3034
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CanAttackStronghold(IntPtr l)
	{
		int result;
		try
		{
			GuildComponentCommon guildComponentCommon = (GuildComponentCommon)LuaObject.checkSelf(l);
			int levelId;
			LuaObject.checkType(l, 2, out levelId);
			int i = guildComponentCommon.CanAttackStronghold(levelId);
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

	// Token: 0x06018206 RID: 98822 RVA: 0x006B4E98 File Offset: 0x006B3098
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetMassiveCombatUnusedHeroes(IntPtr l)
	{
		int result;
		try
		{
			GuildComponentCommon guildComponentCommon = (GuildComponentCommon)LuaObject.checkSelf(l);
			List<Hero> massiveCombatUnusedHeroes = guildComponentCommon.GetMassiveCombatUnusedHeroes();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, massiveCombatUnusedHeroes);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018207 RID: 98823 RVA: 0x006B4EEC File Offset: 0x006B30EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetEliminateRate(IntPtr l)
	{
		int result;
		try
		{
			GuildComponentCommon guildComponentCommon = (GuildComponentCommon)LuaObject.checkSelf(l);
			GuildMassiveCombatInfo combat;
			LuaObject.checkType<GuildMassiveCombatInfo>(l, 2, out combat);
			int eliminateRate = guildComponentCommon.GetEliminateRate(combat);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, eliminateRate);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018208 RID: 98824 RVA: 0x006B4F50 File Offset: 0x006B3150
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetStrongholdEliminateRate(IntPtr l)
	{
		int result;
		try
		{
			GuildComponentCommon guildComponentCommon = (GuildComponentCommon)LuaObject.checkSelf(l);
			GuildMassiveCombatStronghold stronghold;
			LuaObject.checkType<GuildMassiveCombatStronghold>(l, 2, out stronghold);
			int strongholdEliminateRate = guildComponentCommon.GetStrongholdEliminateRate(stronghold);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, strongholdEliminateRate);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018209 RID: 98825 RVA: 0x006B4FB4 File Offset: 0x006B31B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetStartedCombatThisWeek(IntPtr l)
	{
		int result;
		try
		{
			GuildComponentCommon guildComponentCommon = (GuildComponentCommon)LuaObject.checkSelf(l);
			GuildMassiveCombatGeneral generalInfo;
			LuaObject.checkType<GuildMassiveCombatGeneral>(l, 2, out generalInfo);
			int startedCombatThisWeek = guildComponentCommon.GetStartedCombatThisWeek(generalInfo);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, startedCombatThisWeek);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601820A RID: 98826 RVA: 0x006B5018 File Offset: 0x006B3218
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnFlushPlayerGuild(IntPtr l)
	{
		int result;
		try
		{
			GuildComponentCommon guildComponentCommon = (GuildComponentCommon)LuaObject.checkSelf(l);
			guildComponentCommon.m_luaExportHelper.OnFlushPlayerGuild();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601820B RID: 98827 RVA: 0x006B506C File Offset: 0x006B326C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			GuildComponentCommon guildComponentCommon = (GuildComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildComponentCommon.m_luaExportHelper.m_configDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601820C RID: 98828 RVA: 0x006B50C4 File Offset: 0x006B32C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			GuildComponentCommon guildComponentCommon = (GuildComponentCommon)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			guildComponentCommon.m_luaExportHelper.m_configDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601820D RID: 98829 RVA: 0x006B5120 File Offset: 0x006B3320
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_basicInfo(IntPtr l)
	{
		int result;
		try
		{
			GuildComponentCommon guildComponentCommon = (GuildComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildComponentCommon.m_luaExportHelper.m_basicInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601820E RID: 98830 RVA: 0x006B5178 File Offset: 0x006B3378
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_basicInfo(IntPtr l)
	{
		int result;
		try
		{
			GuildComponentCommon guildComponentCommon = (GuildComponentCommon)LuaObject.checkSelf(l);
			PlayerBasicInfoComponentCommon basicInfo;
			LuaObject.checkType<PlayerBasicInfoComponentCommon>(l, 2, out basicInfo);
			guildComponentCommon.m_luaExportHelper.m_basicInfo = basicInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601820F RID: 98831 RVA: 0x006B51D4 File Offset: 0x006B33D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_hero(IntPtr l)
	{
		int result;
		try
		{
			GuildComponentCommon guildComponentCommon = (GuildComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildComponentCommon.m_luaExportHelper.m_hero);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018210 RID: 98832 RVA: 0x006B522C File Offset: 0x006B342C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_hero(IntPtr l)
	{
		int result;
		try
		{
			GuildComponentCommon guildComponentCommon = (GuildComponentCommon)LuaObject.checkSelf(l);
			HeroComponentCommon hero;
			LuaObject.checkType<HeroComponentCommon>(l, 2, out hero);
			guildComponentCommon.m_luaExportHelper.m_hero = hero;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018211 RID: 98833 RVA: 0x006B5288 File Offset: 0x006B3488
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_bag(IntPtr l)
	{
		int result;
		try
		{
			GuildComponentCommon guildComponentCommon = (GuildComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildComponentCommon.m_luaExportHelper.m_bag);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018212 RID: 98834 RVA: 0x006B52E0 File Offset: 0x006B34E0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_bag(IntPtr l)
	{
		int result;
		try
		{
			GuildComponentCommon guildComponentCommon = (GuildComponentCommon)LuaObject.checkSelf(l);
			BagComponentCommon bag;
			LuaObject.checkType<BagComponentCommon>(l, 2, out bag);
			guildComponentCommon.m_luaExportHelper.m_bag = bag;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018213 RID: 98835 RVA: 0x006B533C File Offset: 0x006B353C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_guildDS(IntPtr l)
	{
		int result;
		try
		{
			GuildComponentCommon guildComponentCommon = (GuildComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildComponentCommon.m_luaExportHelper.m_guildDS);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018214 RID: 98836 RVA: 0x006B5394 File Offset: 0x006B3594
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_guildDS(IntPtr l)
	{
		int result;
		try
		{
			GuildComponentCommon guildComponentCommon = (GuildComponentCommon)LuaObject.checkSelf(l);
			DataSectionGuild guildDS;
			LuaObject.checkType<DataSectionGuild>(l, 2, out guildDS);
			guildComponentCommon.m_luaExportHelper.m_guildDS = guildDS;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018215 RID: 98837 RVA: 0x006B53F0 File Offset: 0x006B35F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_latGuildSearchTime(IntPtr l)
	{
		int result;
		try
		{
			GuildComponentCommon guildComponentCommon = (GuildComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildComponentCommon.m_luaExportHelper.m_latGuildSearchTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018216 RID: 98838 RVA: 0x006B544C File Offset: 0x006B364C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_latGuildSearchTime(IntPtr l)
	{
		int result;
		try
		{
			GuildComponentCommon guildComponentCommon = (GuildComponentCommon)LuaObject.checkSelf(l);
			DateTime latGuildSearchTime;
			LuaObject.checkValueType<DateTime>(l, 2, out latGuildSearchTime);
			guildComponentCommon.m_luaExportHelper.m_latGuildSearchTime = latGuildSearchTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018217 RID: 98839 RVA: 0x006B54A8 File Offset: 0x006B36A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_latGuildRandomListTime(IntPtr l)
	{
		int result;
		try
		{
			GuildComponentCommon guildComponentCommon = (GuildComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildComponentCommon.m_luaExportHelper.m_latGuildRandomListTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018218 RID: 98840 RVA: 0x006B5504 File Offset: 0x006B3704
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_latGuildRandomListTime(IntPtr l)
	{
		int result;
		try
		{
			GuildComponentCommon guildComponentCommon = (GuildComponentCommon)LuaObject.checkSelf(l);
			DateTime latGuildRandomListTime;
			LuaObject.checkValueType<DateTime>(l, 2, out latGuildRandomListTime);
			guildComponentCommon.m_luaExportHelper.m_latGuildRandomListTime = latGuildRandomListTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018219 RID: 98841 RVA: 0x006B5560 File Offset: 0x006B3760
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_latGuildInvitePlayerListTime(IntPtr l)
	{
		int result;
		try
		{
			GuildComponentCommon guildComponentCommon = (GuildComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildComponentCommon.m_luaExportHelper.m_latGuildInvitePlayerListTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601821A RID: 98842 RVA: 0x006B55BC File Offset: 0x006B37BC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_latGuildInvitePlayerListTime(IntPtr l)
	{
		int result;
		try
		{
			GuildComponentCommon guildComponentCommon = (GuildComponentCommon)LuaObject.checkSelf(l);
			DateTime latGuildInvitePlayerListTime;
			LuaObject.checkValueType<DateTime>(l, 2, out latGuildInvitePlayerListTime);
			guildComponentCommon.m_luaExportHelper.m_latGuildInvitePlayerListTime = latGuildInvitePlayerListTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601821B RID: 98843 RVA: 0x006B5618 File Offset: 0x006B3818
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Owner(IntPtr l)
	{
		int result;
		try
		{
			GuildComponentCommon guildComponentCommon = (GuildComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildComponentCommon.Owner);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601821C RID: 98844 RVA: 0x006B566C File Offset: 0x006B386C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Owner(IntPtr l)
	{
		int result;
		try
		{
			GuildComponentCommon guildComponentCommon = (GuildComponentCommon)LuaObject.checkSelf(l);
			IComponentOwner owner;
			LuaObject.checkType<IComponentOwner>(l, 2, out owner);
			guildComponentCommon.Owner = owner;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601821D RID: 98845 RVA: 0x006B56C4 File Offset: 0x006B38C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_GuildId(IntPtr l)
	{
		int result;
		try
		{
			GuildComponentCommon guildComponentCommon = (GuildComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildComponentCommon.GuildId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601821E RID: 98846 RVA: 0x006B5718 File Offset: 0x006B3918
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_NextJoinTime(IntPtr l)
	{
		int result;
		try
		{
			GuildComponentCommon guildComponentCommon = (GuildComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildComponentCommon.NextJoinTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601821F RID: 98847 RVA: 0x006B5770 File Offset: 0x006B3970
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_GuildDS(IntPtr l)
	{
		int result;
		try
		{
			GuildComponentCommon guildComponentCommon = (GuildComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildComponentCommon.GuildDS);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018220 RID: 98848 RVA: 0x006B57C4 File Offset: 0x006B39C4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_GetGuildLastUpdateTime(IntPtr l)
	{
		int result;
		try
		{
			GuildComponentCommon guildComponentCommon = (GuildComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildComponentCommon.GetGuildLastUpdateTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018221 RID: 98849 RVA: 0x006B5818 File Offset: 0x006B3A18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_GetGuildLastUpdateTime(IntPtr l)
	{
		int result;
		try
		{
			GuildComponentCommon guildComponentCommon = (GuildComponentCommon)LuaObject.checkSelf(l);
			long getGuildLastUpdateTime;
			LuaObject.checkType(l, 2, out getGuildLastUpdateTime);
			guildComponentCommon.GetGuildLastUpdateTime = getGuildLastUpdateTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018222 RID: 98850 RVA: 0x006B5870 File Offset: 0x006B3A70
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.GuildComponentCommon");
		if (Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildComponentCommon.GetName);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildComponentCommon.Init);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildComponentCommon.PostInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildComponentCommon.DeInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildComponentCommon.Tick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildComponentCommon.PostDeSerialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildComponentCommon.HasOwnGuild);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildComponentCommon.QuitGuild);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildComponentCommon.GetGuildId);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildComponentCommon.SetGuildId);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildComponentCommon.CanCreateGuild);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildComponentCommon.CanJoinGuild);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildComponentCommon.CanQuitGuild);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildComponentCommon.CanKickOutGuild);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildComponentCommon.CanApplyToJoinGuild);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildComponentCommon.CanConfirmJoinGuildInvitation);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildComponentCommon.RefuseJoinGuildInvitation);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildComponentCommon.RefuseAllJoinGuildInvitation);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildComponentCommon.CheckGuildName);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildComponentCommon.CheckGuildSearch);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildComponentCommon.CheckGuildRandomList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildComponentCommon.CheckGuildInvitePlayerList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildComponentCommon.CanSetGuildHiringDeclaration);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildComponentCommon.CheckGuildHiringDeclaration);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildComponentCommon.CanSetGuildAnnouncement);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildComponentCommon.CheckGuildAnnouncement);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildComponentCommon.CanStartMassiveCombat);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildComponentCommon.CanTheseHeroesAttackStronghold);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildComponentCommon.CanAttackStronghold);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildComponentCommon.GetMassiveCombatUnusedHeroes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildComponentCommon.GetEliminateRate);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildComponentCommon.GetStrongholdEliminateRate);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildComponentCommon.GetStartedCombatThisWeek);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildComponentCommon.OnFlushPlayerGuild);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache21);
		string name = "m_configDataLoader";
		if (Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildComponentCommon.get_m_configDataLoader);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache22;
		if (Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildComponentCommon.set_m_configDataLoader);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache23, true);
		string name2 = "m_basicInfo";
		if (Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildComponentCommon.get_m_basicInfo);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache24;
		if (Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildComponentCommon.set_m_basicInfo);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache25, true);
		string name3 = "m_hero";
		if (Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildComponentCommon.get_m_hero);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache26;
		if (Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildComponentCommon.set_m_hero);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache27, true);
		string name4 = "m_bag";
		if (Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildComponentCommon.get_m_bag);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache28;
		if (Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildComponentCommon.set_m_bag);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache29, true);
		string name5 = "m_guildDS";
		if (Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildComponentCommon.get_m_guildDS);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache2A;
		if (Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildComponentCommon.set_m_guildDS);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache2B, true);
		string name6 = "m_latGuildSearchTime";
		if (Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildComponentCommon.get_m_latGuildSearchTime);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache2C;
		if (Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildComponentCommon.set_m_latGuildSearchTime);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache2D, true);
		string name7 = "m_latGuildRandomListTime";
		if (Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildComponentCommon.get_m_latGuildRandomListTime);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache2E;
		if (Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildComponentCommon.set_m_latGuildRandomListTime);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache2F, true);
		string name8 = "m_latGuildInvitePlayerListTime";
		if (Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildComponentCommon.get_m_latGuildInvitePlayerListTime);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache30;
		if (Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildComponentCommon.set_m_latGuildInvitePlayerListTime);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache31, true);
		string name9 = "Owner";
		if (Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildComponentCommon.get_Owner);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache32;
		if (Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildComponentCommon.set_Owner);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache33, true);
		string name10 = "GuildId";
		if (Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildComponentCommon.get_GuildId);
		}
		LuaObject.addMember(l, name10, Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache34, null, true);
		string name11 = "NextJoinTime";
		if (Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildComponentCommon.get_NextJoinTime);
		}
		LuaObject.addMember(l, name11, Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache35, null, true);
		string name12 = "GuildDS";
		if (Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildComponentCommon.get_GuildDS);
		}
		LuaObject.addMember(l, name12, Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache36, null, true);
		string name13 = "GetGuildLastUpdateTime";
		if (Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildComponentCommon.get_GetGuildLastUpdateTime);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache37;
		if (Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildComponentCommon.set_GetGuildLastUpdateTime);
		}
		LuaObject.addMember(l, name13, get10, Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache38, true);
		if (Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GuildComponentCommon.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_GuildComponentCommon.<>f__mg$cache39, typeof(GuildComponentCommon));
	}

	// Token: 0x0400E772 RID: 59250
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400E773 RID: 59251
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400E774 RID: 59252
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400E775 RID: 59253
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400E776 RID: 59254
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400E777 RID: 59255
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400E778 RID: 59256
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400E779 RID: 59257
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400E77A RID: 59258
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400E77B RID: 59259
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400E77C RID: 59260
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400E77D RID: 59261
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400E77E RID: 59262
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400E77F RID: 59263
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400E780 RID: 59264
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400E781 RID: 59265
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400E782 RID: 59266
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400E783 RID: 59267
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400E784 RID: 59268
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400E785 RID: 59269
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400E786 RID: 59270
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400E787 RID: 59271
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400E788 RID: 59272
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400E789 RID: 59273
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400E78A RID: 59274
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400E78B RID: 59275
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0400E78C RID: 59276
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0400E78D RID: 59277
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0400E78E RID: 59278
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0400E78F RID: 59279
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0400E790 RID: 59280
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0400E791 RID: 59281
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0400E792 RID: 59282
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0400E793 RID: 59283
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0400E794 RID: 59284
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0400E795 RID: 59285
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0400E796 RID: 59286
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0400E797 RID: 59287
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0400E798 RID: 59288
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0400E799 RID: 59289
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0400E79A RID: 59290
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x0400E79B RID: 59291
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x0400E79C RID: 59292
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x0400E79D RID: 59293
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x0400E79E RID: 59294
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x0400E79F RID: 59295
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x0400E7A0 RID: 59296
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x0400E7A1 RID: 59297
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x0400E7A2 RID: 59298
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x0400E7A3 RID: 59299
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x0400E7A4 RID: 59300
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x0400E7A5 RID: 59301
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x0400E7A6 RID: 59302
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x0400E7A7 RID: 59303
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x0400E7A8 RID: 59304
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x0400E7A9 RID: 59305
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x0400E7AA RID: 59306
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x0400E7AB RID: 59307
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;
}
