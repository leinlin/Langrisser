using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Protocol;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200122B RID: 4651
[Preserve]
public class Lua_BlackJack_ProjectL_Common_Guild : LuaObject
{
	// Token: 0x060181BB RID: 98747 RVA: 0x006B2FC8 File Offset: 0x006B11C8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			Guild o = new Guild();
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

	// Token: 0x060181BC RID: 98748 RVA: 0x006B3010 File Offset: 0x006B1210
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int WeeklyFlush(IntPtr l)
	{
		int result;
		try
		{
			Guild guild = (Guild)LuaObject.checkSelf(l);
			guild.WeeklyFlush();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060181BD RID: 98749 RVA: 0x006B305C File Offset: 0x006B125C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddMember(IntPtr l)
	{
		int result;
		try
		{
			Guild guild = (Guild)LuaObject.checkSelf(l);
			GuildMember member;
			LuaObject.checkType<GuildMember>(l, 2, out member);
			GuildMemberCacheObject o = guild.AddMember(member);
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

	// Token: 0x060181BE RID: 98750 RVA: 0x006B30C0 File Offset: 0x006B12C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FindMember(IntPtr l)
	{
		int result;
		try
		{
			Guild guild = (Guild)LuaObject.checkSelf(l);
			string userId;
			LuaObject.checkType(l, 2, out userId);
			GuildMemberCacheObject o = guild.FindMember(userId);
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

	// Token: 0x060181BF RID: 98751 RVA: 0x006B3124 File Offset: 0x006B1324
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int RemoveMember(IntPtr l)
	{
		int result;
		try
		{
			Guild guild = (Guild)LuaObject.checkSelf(l);
			GuildMemberCacheObject cache;
			LuaObject.checkType<GuildMemberCacheObject>(l, 2, out cache);
			guild.RemoveMember(cache);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060181C0 RID: 98752 RVA: 0x006B317C File Offset: 0x006B137C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsEmpty(IntPtr l)
	{
		int result;
		try
		{
			Guild guild = (Guild)LuaObject.checkSelf(l);
			bool b = guild.IsEmpty();
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

	// Token: 0x060181C1 RID: 98753 RVA: 0x006B31D0 File Offset: 0x006B13D0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetPresident(IntPtr l)
	{
		int result;
		try
		{
			Guild guild = (Guild)LuaObject.checkSelf(l);
			GuildMemberCacheObject president = guild.GetPresident();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, president);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060181C2 RID: 98754 RVA: 0x006B3224 File Offset: 0x006B1424
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetVicePresidentNums(IntPtr l)
	{
		int result;
		try
		{
			Guild guild = (Guild)LuaObject.checkSelf(l);
			int vicePresidentNums = guild.GetVicePresidentNums();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, vicePresidentNums);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060181C3 RID: 98755 RVA: 0x006B3278 File Offset: 0x006B1478
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetMemberUserIds(IntPtr l)
	{
		int result;
		try
		{
			Guild guild = (Guild)LuaObject.checkSelf(l);
			List<string> memberUserIds = guild.GetMemberUserIds();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, memberUserIds);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060181C4 RID: 98756 RVA: 0x006B32CC File Offset: 0x006B14CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetAdminUserIds(IntPtr l)
	{
		int result;
		try
		{
			Guild guild = (Guild)LuaObject.checkSelf(l);
			List<string> adminUserIds = guild.GetAdminUserIds();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, adminUserIds);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060181C5 RID: 98757 RVA: 0x006B3320 File Offset: 0x006B1520
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ToPb_s(IntPtr l)
	{
		int result;
		try
		{
			Guild g;
			LuaObject.checkType<Guild>(l, 1, out g);
			ProGuild o = Guild.ToPb(g);
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

	// Token: 0x060181C6 RID: 98758 RVA: 0x006B3374 File Offset: 0x006B1574
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FromPb_s(IntPtr l)
	{
		int result;
		try
		{
			ProGuild pb;
			LuaObject.checkType<ProGuild>(l, 1, out pb);
			Guild o = Guild.FromPb(pb);
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

	// Token: 0x060181C7 RID: 98759 RVA: 0x006B33C8 File Offset: 0x006B15C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Logs(IntPtr l)
	{
		int result;
		try
		{
			Guild guild = (Guild)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guild.Logs);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060181C8 RID: 98760 RVA: 0x006B341C File Offset: 0x006B161C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Logs(IntPtr l)
	{
		int result;
		try
		{
			Guild guild = (Guild)LuaObject.checkSelf(l);
			List<GuildLog> logs;
			LuaObject.checkType<List<GuildLog>>(l, 2, out logs);
			guild.Logs = logs;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060181C9 RID: 98761 RVA: 0x006B3474 File Offset: 0x006B1674
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_MassiveCombat(IntPtr l)
	{
		int result;
		try
		{
			Guild guild = (Guild)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guild.MassiveCombat);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060181CA RID: 98762 RVA: 0x006B34C8 File Offset: 0x006B16C8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_MassiveCombat(IntPtr l)
	{
		int result;
		try
		{
			Guild guild = (Guild)LuaObject.checkSelf(l);
			GuildMassiveCombatGeneral massiveCombat;
			LuaObject.checkType<GuildMassiveCombatGeneral>(l, 2, out massiveCombat);
			guild.MassiveCombat = massiveCombat;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060181CB RID: 98763 RVA: 0x006B3520 File Offset: 0x006B1720
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_GuildMemberCountMax(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Guild.GuildMemberCountMax);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060181CC RID: 98764 RVA: 0x006B3568 File Offset: 0x006B1768
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_GuildMemberCountMax(IntPtr l)
	{
		int result;
		try
		{
			int guildMemberCountMax;
			LuaObject.checkType(l, 2, out guildMemberCountMax);
			Guild.GuildMemberCountMax = guildMemberCountMax;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060181CD RID: 98765 RVA: 0x006B35B4 File Offset: 0x006B17B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Id(IntPtr l)
	{
		int result;
		try
		{
			Guild guild = (Guild)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guild.Id);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060181CE RID: 98766 RVA: 0x006B3608 File Offset: 0x006B1808
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Id(IntPtr l)
	{
		int result;
		try
		{
			Guild guild = (Guild)LuaObject.checkSelf(l);
			string id;
			LuaObject.checkType(l, 2, out id);
			guild.Id = id;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060181CF RID: 98767 RVA: 0x006B3660 File Offset: 0x006B1860
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Name(IntPtr l)
	{
		int result;
		try
		{
			Guild guild = (Guild)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guild.Name);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060181D0 RID: 98768 RVA: 0x006B36B4 File Offset: 0x006B18B4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Name(IntPtr l)
	{
		int result;
		try
		{
			Guild guild = (Guild)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			guild.Name = name;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060181D1 RID: 98769 RVA: 0x006B370C File Offset: 0x006B190C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Bulletin(IntPtr l)
	{
		int result;
		try
		{
			Guild guild = (Guild)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guild.Bulletin);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060181D2 RID: 98770 RVA: 0x006B3760 File Offset: 0x006B1960
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Bulletin(IntPtr l)
	{
		int result;
		try
		{
			Guild guild = (Guild)LuaObject.checkSelf(l);
			string bulletin;
			LuaObject.checkType(l, 2, out bulletin);
			guild.Bulletin = bulletin;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060181D3 RID: 98771 RVA: 0x006B37B8 File Offset: 0x006B19B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_HiringDeclaration(IntPtr l)
	{
		int result;
		try
		{
			Guild guild = (Guild)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guild.HiringDeclaration);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060181D4 RID: 98772 RVA: 0x006B380C File Offset: 0x006B1A0C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_HiringDeclaration(IntPtr l)
	{
		int result;
		try
		{
			Guild guild = (Guild)LuaObject.checkSelf(l);
			string hiringDeclaration;
			LuaObject.checkType(l, 2, out hiringDeclaration);
			guild.HiringDeclaration = hiringDeclaration;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060181D5 RID: 98773 RVA: 0x006B3864 File Offset: 0x006B1A64
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_AutoJoin(IntPtr l)
	{
		int result;
		try
		{
			Guild guild = (Guild)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guild.AutoJoin);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060181D6 RID: 98774 RVA: 0x006B38B8 File Offset: 0x006B1AB8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_AutoJoin(IntPtr l)
	{
		int result;
		try
		{
			Guild guild = (Guild)LuaObject.checkSelf(l);
			bool autoJoin;
			LuaObject.checkType(l, 2, out autoJoin);
			guild.AutoJoin = autoJoin;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060181D7 RID: 98775 RVA: 0x006B3910 File Offset: 0x006B1B10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_JoinLevel(IntPtr l)
	{
		int result;
		try
		{
			Guild guild = (Guild)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guild.JoinLevel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060181D8 RID: 98776 RVA: 0x006B3964 File Offset: 0x006B1B64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_JoinLevel(IntPtr l)
	{
		int result;
		try
		{
			Guild guild = (Guild)LuaObject.checkSelf(l);
			int joinLevel;
			LuaObject.checkType(l, 2, out joinLevel);
			guild.JoinLevel = joinLevel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060181D9 RID: 98777 RVA: 0x006B39BC File Offset: 0x006B1BBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_TotalBattlePower(IntPtr l)
	{
		int result;
		try
		{
			Guild guild = (Guild)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guild.TotalBattlePower);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060181DA RID: 98778 RVA: 0x006B3A10 File Offset: 0x006B1C10
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_TotalBattlePower(IntPtr l)
	{
		int result;
		try
		{
			Guild guild = (Guild)LuaObject.checkSelf(l);
			int totalBattlePower;
			LuaObject.checkType(l, 2, out totalBattlePower);
			guild.TotalBattlePower = totalBattlePower;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060181DB RID: 98779 RVA: 0x006B3A68 File Offset: 0x006B1C68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_TotalActivities(IntPtr l)
	{
		int result;
		try
		{
			Guild guild = (Guild)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guild.TotalActivities);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060181DC RID: 98780 RVA: 0x006B3ABC File Offset: 0x006B1CBC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_TotalActivities(IntPtr l)
	{
		int result;
		try
		{
			Guild guild = (Guild)LuaObject.checkSelf(l);
			int totalActivities;
			LuaObject.checkType(l, 2, out totalActivities);
			guild.TotalActivities = totalActivities;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060181DD RID: 98781 RVA: 0x006B3B14 File Offset: 0x006B1D14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LastWeekActivities(IntPtr l)
	{
		int result;
		try
		{
			Guild guild = (Guild)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guild.LastWeekActivities);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060181DE RID: 98782 RVA: 0x006B3B68 File Offset: 0x006B1D68
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_LastWeekActivities(IntPtr l)
	{
		int result;
		try
		{
			Guild guild = (Guild)LuaObject.checkSelf(l);
			int lastWeekActivities;
			LuaObject.checkType(l, 2, out lastWeekActivities);
			guild.LastWeekActivities = lastWeekActivities;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060181DF RID: 98783 RVA: 0x006B3BC0 File Offset: 0x006B1DC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_CurrentWeekActivities(IntPtr l)
	{
		int result;
		try
		{
			Guild guild = (Guild)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guild.CurrentWeekActivities);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060181E0 RID: 98784 RVA: 0x006B3C14 File Offset: 0x006B1E14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_CurrentWeekActivities(IntPtr l)
	{
		int result;
		try
		{
			Guild guild = (Guild)LuaObject.checkSelf(l);
			int currentWeekActivities;
			LuaObject.checkType(l, 2, out currentWeekActivities);
			guild.CurrentWeekActivities = currentWeekActivities;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060181E1 RID: 98785 RVA: 0x006B3C6C File Offset: 0x006B1E6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Activities(IntPtr l)
	{
		int result;
		try
		{
			Guild guild = (Guild)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guild.Activities);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060181E2 RID: 98786 RVA: 0x006B3CC0 File Offset: 0x006B1EC0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Activities(IntPtr l)
	{
		int result;
		try
		{
			Guild guild = (Guild)LuaObject.checkSelf(l);
			int activities;
			LuaObject.checkType(l, 2, out activities);
			guild.Activities = activities;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060181E3 RID: 98787 RVA: 0x006B3D18 File Offset: 0x006B1F18
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Members(IntPtr l)
	{
		int result;
		try
		{
			Guild guild = (Guild)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guild.Members);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060181E4 RID: 98788 RVA: 0x006B3D6C File Offset: 0x006B1F6C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Members(IntPtr l)
	{
		int result;
		try
		{
			Guild guild = (Guild)LuaObject.checkSelf(l);
			List<GuildMemberCacheObject> members;
			LuaObject.checkType<List<GuildMemberCacheObject>>(l, 2, out members);
			guild.Members = members;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060181E5 RID: 98789 RVA: 0x006B3DC4 File Offset: 0x006B1FC4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_IsMemberFull(IntPtr l)
	{
		int result;
		try
		{
			Guild guild = (Guild)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guild.IsMemberFull);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060181E6 RID: 98790 RVA: 0x006B3E18 File Offset: 0x006B2018
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.Guild");
		if (Lua_BlackJack_ProjectL_Common_Guild.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_Guild.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Guild.WeeklyFlush);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_Guild.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_Guild.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_Guild.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Guild.AddMember);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_Guild.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Common_Guild.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_Guild.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Guild.FindMember);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_Guild.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Common_Guild.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_Guild.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Guild.RemoveMember);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_Guild.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_Common_Guild.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_Guild.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Guild.IsEmpty);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_Guild.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_Common_Guild.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_Guild.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Guild.GetPresident);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_Guild.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_Common_Guild.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_Guild.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Guild.GetVicePresidentNums);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_Guild.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_Common_Guild.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_Guild.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Guild.GetMemberUserIds);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_Guild.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_Common_Guild.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_Guild.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Guild.GetAdminUserIds);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_Guild.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_Common_Guild.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Common_Guild.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Guild.ToPb_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_Guild.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_Common_Guild.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Common_Guild.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Guild.FromPb_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_Guild.<>f__mg$cacheA);
		string name = "Logs";
		if (Lua_BlackJack_ProjectL_Common_Guild.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Common_Guild.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Guild.get_Logs);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_Guild.<>f__mg$cacheB;
		if (Lua_BlackJack_ProjectL_Common_Guild.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Common_Guild.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Guild.set_Logs);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_Guild.<>f__mg$cacheC, true);
		string name2 = "MassiveCombat";
		if (Lua_BlackJack_ProjectL_Common_Guild.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Common_Guild.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Guild.get_MassiveCombat);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_Guild.<>f__mg$cacheD;
		if (Lua_BlackJack_ProjectL_Common_Guild.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Common_Guild.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Guild.set_MassiveCombat);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_Guild.<>f__mg$cacheE, true);
		string name3 = "GuildMemberCountMax";
		if (Lua_BlackJack_ProjectL_Common_Guild.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_Common_Guild.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Guild.get_GuildMemberCountMax);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Common_Guild.<>f__mg$cacheF;
		if (Lua_BlackJack_ProjectL_Common_Guild.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_Common_Guild.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Guild.set_GuildMemberCountMax);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Common_Guild.<>f__mg$cache10, false);
		string name4 = "Id";
		if (Lua_BlackJack_ProjectL_Common_Guild.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_Common_Guild.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Guild.get_Id);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Common_Guild.<>f__mg$cache11;
		if (Lua_BlackJack_ProjectL_Common_Guild.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_Common_Guild.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Guild.set_Id);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Common_Guild.<>f__mg$cache12, true);
		string name5 = "Name";
		if (Lua_BlackJack_ProjectL_Common_Guild.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_Common_Guild.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Guild.get_Name);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_Common_Guild.<>f__mg$cache13;
		if (Lua_BlackJack_ProjectL_Common_Guild.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_Common_Guild.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Guild.set_Name);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_Common_Guild.<>f__mg$cache14, true);
		string name6 = "Bulletin";
		if (Lua_BlackJack_ProjectL_Common_Guild.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_Common_Guild.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Guild.get_Bulletin);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_Common_Guild.<>f__mg$cache15;
		if (Lua_BlackJack_ProjectL_Common_Guild.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_Common_Guild.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Guild.set_Bulletin);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_Common_Guild.<>f__mg$cache16, true);
		string name7 = "HiringDeclaration";
		if (Lua_BlackJack_ProjectL_Common_Guild.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_Common_Guild.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Guild.get_HiringDeclaration);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_Common_Guild.<>f__mg$cache17;
		if (Lua_BlackJack_ProjectL_Common_Guild.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_Common_Guild.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Guild.set_HiringDeclaration);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_Common_Guild.<>f__mg$cache18, true);
		string name8 = "AutoJoin";
		if (Lua_BlackJack_ProjectL_Common_Guild.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_Common_Guild.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Guild.get_AutoJoin);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_Common_Guild.<>f__mg$cache19;
		if (Lua_BlackJack_ProjectL_Common_Guild.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_Common_Guild.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Guild.set_AutoJoin);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_Common_Guild.<>f__mg$cache1A, true);
		string name9 = "JoinLevel";
		if (Lua_BlackJack_ProjectL_Common_Guild.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_Common_Guild.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Guild.get_JoinLevel);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_Common_Guild.<>f__mg$cache1B;
		if (Lua_BlackJack_ProjectL_Common_Guild.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_Common_Guild.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Guild.set_JoinLevel);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_Common_Guild.<>f__mg$cache1C, true);
		string name10 = "TotalBattlePower";
		if (Lua_BlackJack_ProjectL_Common_Guild.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_Common_Guild.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Guild.get_TotalBattlePower);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_Common_Guild.<>f__mg$cache1D;
		if (Lua_BlackJack_ProjectL_Common_Guild.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_Common_Guild.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Guild.set_TotalBattlePower);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_Common_Guild.<>f__mg$cache1E, true);
		string name11 = "TotalActivities";
		if (Lua_BlackJack_ProjectL_Common_Guild.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_Common_Guild.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Guild.get_TotalActivities);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_Common_Guild.<>f__mg$cache1F;
		if (Lua_BlackJack_ProjectL_Common_Guild.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_Common_Guild.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Guild.set_TotalActivities);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_Common_Guild.<>f__mg$cache20, true);
		string name12 = "LastWeekActivities";
		if (Lua_BlackJack_ProjectL_Common_Guild.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_Common_Guild.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Guild.get_LastWeekActivities);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_Common_Guild.<>f__mg$cache21;
		if (Lua_BlackJack_ProjectL_Common_Guild.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_Common_Guild.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Guild.set_LastWeekActivities);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_Common_Guild.<>f__mg$cache22, true);
		string name13 = "CurrentWeekActivities";
		if (Lua_BlackJack_ProjectL_Common_Guild.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_Common_Guild.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Guild.get_CurrentWeekActivities);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_Common_Guild.<>f__mg$cache23;
		if (Lua_BlackJack_ProjectL_Common_Guild.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_Common_Guild.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Guild.set_CurrentWeekActivities);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_Common_Guild.<>f__mg$cache24, true);
		string name14 = "Activities";
		if (Lua_BlackJack_ProjectL_Common_Guild.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_Common_Guild.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Guild.get_Activities);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_Common_Guild.<>f__mg$cache25;
		if (Lua_BlackJack_ProjectL_Common_Guild.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_Common_Guild.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Guild.set_Activities);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_Common_Guild.<>f__mg$cache26, true);
		string name15 = "Members";
		if (Lua_BlackJack_ProjectL_Common_Guild.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_Common_Guild.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Guild.get_Members);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_Common_Guild.<>f__mg$cache27;
		if (Lua_BlackJack_ProjectL_Common_Guild.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_Common_Guild.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Guild.set_Members);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_Common_Guild.<>f__mg$cache28, true);
		string name16 = "IsMemberFull";
		if (Lua_BlackJack_ProjectL_Common_Guild.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_Common_Guild.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Guild.get_IsMemberFull);
		}
		LuaObject.addMember(l, name16, Lua_BlackJack_ProjectL_Common_Guild.<>f__mg$cache29, null, true);
		if (Lua_BlackJack_ProjectL_Common_Guild.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_Common_Guild.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Guild.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_Guild.<>f__mg$cache2A, typeof(Guild));
	}

	// Token: 0x0400E747 RID: 59207
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400E748 RID: 59208
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400E749 RID: 59209
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400E74A RID: 59210
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400E74B RID: 59211
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400E74C RID: 59212
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400E74D RID: 59213
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400E74E RID: 59214
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400E74F RID: 59215
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400E750 RID: 59216
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400E751 RID: 59217
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400E752 RID: 59218
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400E753 RID: 59219
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400E754 RID: 59220
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400E755 RID: 59221
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400E756 RID: 59222
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400E757 RID: 59223
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400E758 RID: 59224
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400E759 RID: 59225
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400E75A RID: 59226
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400E75B RID: 59227
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400E75C RID: 59228
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400E75D RID: 59229
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400E75E RID: 59230
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400E75F RID: 59231
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400E760 RID: 59232
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0400E761 RID: 59233
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0400E762 RID: 59234
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0400E763 RID: 59235
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0400E764 RID: 59236
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0400E765 RID: 59237
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0400E766 RID: 59238
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0400E767 RID: 59239
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0400E768 RID: 59240
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0400E769 RID: 59241
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0400E76A RID: 59242
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0400E76B RID: 59243
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0400E76C RID: 59244
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0400E76D RID: 59245
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0400E76E RID: 59246
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0400E76F RID: 59247
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x0400E770 RID: 59248
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x0400E771 RID: 59249
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;
}
