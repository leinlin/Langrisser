using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Protocol;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020011B8 RID: 4536
[Preserve]
public class Lua_BlackJack_ProjectL_Common_ArenaBattleReport : LuaObject
{
	// Token: 0x060177E4 RID: 96228 RVA: 0x0066BB70 File Offset: 0x00669D70
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 1)
			{
				ArenaBattleReport o = new ArenaBattleReport();
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 2, typeof(BattleReport)))
			{
				BattleReport battleReport;
				LuaObject.checkType<BattleReport>(l, 2, out battleReport);
				ArenaBattleReport o = new ArenaBattleReport(battleReport);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 2, typeof(ArenaBattleReport)))
			{
				ArenaBattleReport other;
				LuaObject.checkType<ArenaBattleReport>(l, 2, out other);
				ArenaBattleReport o = new ArenaBattleReport(other);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else
			{
				result = LuaObject.error(l, "New object failed.");
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060177E5 RID: 96229 RVA: 0x0066BC54 File Offset: 0x00669E54
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int PBArenaBattleReportToArenaBattleReport_s(IntPtr l)
	{
		int result;
		try
		{
			ProArenaBattleReport pbArenaBattleReport;
			LuaObject.checkType<ProArenaBattleReport>(l, 1, out pbArenaBattleReport);
			bool isBattleData;
			LuaObject.checkType(l, 2, out isBattleData);
			ArenaBattleReport o = ArenaBattleReport.PBArenaBattleReportToArenaBattleReport(pbArenaBattleReport, isBattleData);
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

	// Token: 0x060177E6 RID: 96230 RVA: 0x0066BCB4 File Offset: 0x00669EB4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ArenaBattleReportToPBArenaBattleReport_s(IntPtr l)
	{
		int result;
		try
		{
			ArenaBattleReport arenaBattleReport;
			LuaObject.checkType<ArenaBattleReport>(l, 1, out arenaBattleReport);
			bool isBattleData;
			LuaObject.checkType(l, 2, out isBattleData);
			ProArenaBattleReport o = ArenaBattleReport.ArenaBattleReportToPBArenaBattleReport(arenaBattleReport, isBattleData);
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

	// Token: 0x060177E7 RID: 96231 RVA: 0x0066BD14 File Offset: 0x00669F14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_DefenderHeroes(IntPtr l)
	{
		int result;
		try
		{
			ArenaBattleReport arenaBattleReport = (ArenaBattleReport)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaBattleReport.DefenderHeroes);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060177E8 RID: 96232 RVA: 0x0066BD68 File Offset: 0x00669F68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_DefenderHeroes(IntPtr l)
	{
		int result;
		try
		{
			ArenaBattleReport arenaBattleReport = (ArenaBattleReport)LuaObject.checkSelf(l);
			List<BattleHero> defenderHeroes;
			LuaObject.checkType<List<BattleHero>>(l, 2, out defenderHeroes);
			arenaBattleReport.DefenderHeroes = defenderHeroes;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060177E9 RID: 96233 RVA: 0x0066BDC0 File Offset: 0x00669FC0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_DefenderTechs(IntPtr l)
	{
		int result;
		try
		{
			ArenaBattleReport arenaBattleReport = (ArenaBattleReport)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaBattleReport.DefenderTechs);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060177EA RID: 96234 RVA: 0x0066BE14 File Offset: 0x0066A014
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_DefenderTechs(IntPtr l)
	{
		int result;
		try
		{
			ArenaBattleReport arenaBattleReport = (ArenaBattleReport)LuaObject.checkSelf(l);
			List<TrainingTech> defenderTechs;
			LuaObject.checkType<List<TrainingTech>>(l, 2, out defenderTechs);
			arenaBattleReport.DefenderTechs = defenderTechs;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060177EB RID: 96235 RVA: 0x0066BE6C File Offset: 0x0066A06C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_AttackerHeroes(IntPtr l)
	{
		int result;
		try
		{
			ArenaBattleReport arenaBattleReport = (ArenaBattleReport)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaBattleReport.AttackerHeroes);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060177EC RID: 96236 RVA: 0x0066BEC0 File Offset: 0x0066A0C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_AttackerHeroes(IntPtr l)
	{
		int result;
		try
		{
			ArenaBattleReport arenaBattleReport = (ArenaBattleReport)LuaObject.checkSelf(l);
			List<BattleHero> attackerHeroes;
			LuaObject.checkType<List<BattleHero>>(l, 2, out attackerHeroes);
			arenaBattleReport.AttackerHeroes = attackerHeroes;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060177ED RID: 96237 RVA: 0x0066BF18 File Offset: 0x0066A118
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_AttackerTechs(IntPtr l)
	{
		int result;
		try
		{
			ArenaBattleReport arenaBattleReport = (ArenaBattleReport)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaBattleReport.AttackerTechs);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060177EE RID: 96238 RVA: 0x0066BF6C File Offset: 0x0066A16C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_AttackerTechs(IntPtr l)
	{
		int result;
		try
		{
			ArenaBattleReport arenaBattleReport = (ArenaBattleReport)LuaObject.checkSelf(l);
			List<TrainingTech> attackerTechs;
			LuaObject.checkType<List<TrainingTech>>(l, 2, out attackerTechs);
			arenaBattleReport.AttackerTechs = attackerTechs;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060177EF RID: 96239 RVA: 0x0066BFC4 File Offset: 0x0066A1C4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Status(IntPtr l)
	{
		int result;
		try
		{
			ArenaBattleReport arenaBattleReport = (ArenaBattleReport)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)arenaBattleReport.Status);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060177F0 RID: 96240 RVA: 0x0066C018 File Offset: 0x0066A218
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Status(IntPtr l)
	{
		int result;
		try
		{
			ArenaBattleReport arenaBattleReport = (ArenaBattleReport)LuaObject.checkSelf(l);
			ArenaBattleReportStatus status;
			LuaObject.checkEnum<ArenaBattleReportStatus>(l, 2, out status);
			arenaBattleReport.Status = status;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060177F1 RID: 96241 RVA: 0x0066C070 File Offset: 0x0066A270
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ArenaDefenderRuleId(IntPtr l)
	{
		int result;
		try
		{
			ArenaBattleReport arenaBattleReport = (ArenaBattleReport)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaBattleReport.ArenaDefenderRuleId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060177F2 RID: 96242 RVA: 0x0066C0C4 File Offset: 0x0066A2C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ArenaDefenderRuleId(IntPtr l)
	{
		int result;
		try
		{
			ArenaBattleReport arenaBattleReport = (ArenaBattleReport)LuaObject.checkSelf(l);
			int arenaDefenderRuleId;
			LuaObject.checkType(l, 2, out arenaDefenderRuleId);
			arenaBattleReport.ArenaDefenderRuleId = arenaDefenderRuleId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060177F3 RID: 96243 RVA: 0x0066C11C File Offset: 0x0066A31C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_DefenderUserId(IntPtr l)
	{
		int result;
		try
		{
			ArenaBattleReport arenaBattleReport = (ArenaBattleReport)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaBattleReport.DefenderUserId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060177F4 RID: 96244 RVA: 0x0066C170 File Offset: 0x0066A370
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_DefenderUserId(IntPtr l)
	{
		int result;
		try
		{
			ArenaBattleReport arenaBattleReport = (ArenaBattleReport)LuaObject.checkSelf(l);
			string defenderUserId;
			LuaObject.checkType(l, 2, out defenderUserId);
			arenaBattleReport.DefenderUserId = defenderUserId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060177F5 RID: 96245 RVA: 0x0066C1C8 File Offset: 0x0066A3C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_DefenderName(IntPtr l)
	{
		int result;
		try
		{
			ArenaBattleReport arenaBattleReport = (ArenaBattleReport)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaBattleReport.DefenderName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060177F6 RID: 96246 RVA: 0x0066C21C File Offset: 0x0066A41C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_DefenderName(IntPtr l)
	{
		int result;
		try
		{
			ArenaBattleReport arenaBattleReport = (ArenaBattleReport)LuaObject.checkSelf(l);
			string defenderName;
			LuaObject.checkType(l, 2, out defenderName);
			arenaBattleReport.DefenderName = defenderName;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060177F7 RID: 96247 RVA: 0x0066C274 File Offset: 0x0066A474
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_DefenderLevel(IntPtr l)
	{
		int result;
		try
		{
			ArenaBattleReport arenaBattleReport = (ArenaBattleReport)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaBattleReport.DefenderLevel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060177F8 RID: 96248 RVA: 0x0066C2C8 File Offset: 0x0066A4C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_DefenderLevel(IntPtr l)
	{
		int result;
		try
		{
			ArenaBattleReport arenaBattleReport = (ArenaBattleReport)LuaObject.checkSelf(l);
			int defenderLevel;
			LuaObject.checkType(l, 2, out defenderLevel);
			arenaBattleReport.DefenderLevel = defenderLevel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060177F9 RID: 96249 RVA: 0x0066C320 File Offset: 0x0066A520
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_AttackerUserId(IntPtr l)
	{
		int result;
		try
		{
			ArenaBattleReport arenaBattleReport = (ArenaBattleReport)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaBattleReport.AttackerUserId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060177FA RID: 96250 RVA: 0x0066C374 File Offset: 0x0066A574
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_AttackerUserId(IntPtr l)
	{
		int result;
		try
		{
			ArenaBattleReport arenaBattleReport = (ArenaBattleReport)LuaObject.checkSelf(l);
			string attackerUserId;
			LuaObject.checkType(l, 2, out attackerUserId);
			arenaBattleReport.AttackerUserId = attackerUserId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060177FB RID: 96251 RVA: 0x0066C3CC File Offset: 0x0066A5CC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_AttackerName(IntPtr l)
	{
		int result;
		try
		{
			ArenaBattleReport arenaBattleReport = (ArenaBattleReport)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaBattleReport.AttackerName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060177FC RID: 96252 RVA: 0x0066C420 File Offset: 0x0066A620
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_AttackerName(IntPtr l)
	{
		int result;
		try
		{
			ArenaBattleReport arenaBattleReport = (ArenaBattleReport)LuaObject.checkSelf(l);
			string attackerName;
			LuaObject.checkType(l, 2, out attackerName);
			arenaBattleReport.AttackerName = attackerName;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060177FD RID: 96253 RVA: 0x0066C478 File Offset: 0x0066A678
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_AttackerLevel(IntPtr l)
	{
		int result;
		try
		{
			ArenaBattleReport arenaBattleReport = (ArenaBattleReport)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaBattleReport.AttackerLevel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060177FE RID: 96254 RVA: 0x0066C4CC File Offset: 0x0066A6CC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_AttackerLevel(IntPtr l)
	{
		int result;
		try
		{
			ArenaBattleReport arenaBattleReport = (ArenaBattleReport)LuaObject.checkSelf(l);
			int attackerLevel;
			LuaObject.checkType(l, 2, out attackerLevel);
			arenaBattleReport.AttackerLevel = attackerLevel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060177FF RID: 96255 RVA: 0x0066C524 File Offset: 0x0066A724
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_AttackerGotArenaPoints(IntPtr l)
	{
		int result;
		try
		{
			ArenaBattleReport arenaBattleReport = (ArenaBattleReport)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaBattleReport.AttackerGotArenaPoints);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017800 RID: 96256 RVA: 0x0066C578 File Offset: 0x0066A778
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_AttackerGotArenaPoints(IntPtr l)
	{
		int result;
		try
		{
			ArenaBattleReport arenaBattleReport = (ArenaBattleReport)LuaObject.checkSelf(l);
			int attackerGotArenaPoints;
			LuaObject.checkType(l, 2, out attackerGotArenaPoints);
			arenaBattleReport.AttackerGotArenaPoints = attackerGotArenaPoints;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017801 RID: 96257 RVA: 0x0066C5D0 File Offset: 0x0066A7D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_DefenderGotArenaPoints(IntPtr l)
	{
		int result;
		try
		{
			ArenaBattleReport arenaBattleReport = (ArenaBattleReport)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaBattleReport.DefenderGotArenaPoints);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017802 RID: 96258 RVA: 0x0066C624 File Offset: 0x0066A824
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_DefenderGotArenaPoints(IntPtr l)
	{
		int result;
		try
		{
			ArenaBattleReport arenaBattleReport = (ArenaBattleReport)LuaObject.checkSelf(l);
			int defenderGotArenaPoints;
			LuaObject.checkType(l, 2, out defenderGotArenaPoints);
			arenaBattleReport.DefenderGotArenaPoints = defenderGotArenaPoints;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017803 RID: 96259 RVA: 0x0066C67C File Offset: 0x0066A87C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_CreateTime(IntPtr l)
	{
		int result;
		try
		{
			ArenaBattleReport arenaBattleReport = (ArenaBattleReport)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaBattleReport.CreateTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017804 RID: 96260 RVA: 0x0066C6D0 File Offset: 0x0066A8D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_CreateTime(IntPtr l)
	{
		int result;
		try
		{
			ArenaBattleReport arenaBattleReport = (ArenaBattleReport)LuaObject.checkSelf(l);
			long createTime;
			LuaObject.checkType(l, 2, out createTime);
			arenaBattleReport.CreateTime = createTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017805 RID: 96261 RVA: 0x0066C728 File Offset: 0x0066A928
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_OpponentHeadIcon(IntPtr l)
	{
		int result;
		try
		{
			ArenaBattleReport arenaBattleReport = (ArenaBattleReport)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaBattleReport.OpponentHeadIcon);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017806 RID: 96262 RVA: 0x0066C77C File Offset: 0x0066A97C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_OpponentHeadIcon(IntPtr l)
	{
		int result;
		try
		{
			ArenaBattleReport arenaBattleReport = (ArenaBattleReport)LuaObject.checkSelf(l);
			int opponentHeadIcon;
			LuaObject.checkType(l, 2, out opponentHeadIcon);
			arenaBattleReport.OpponentHeadIcon = opponentHeadIcon;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017807 RID: 96263 RVA: 0x0066C7D4 File Offset: 0x0066A9D4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.ArenaBattleReport");
		if (Lua_BlackJack_ProjectL_Common_ArenaBattleReport.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaBattleReport.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaBattleReport.PBArenaBattleReportToArenaBattleReport_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ArenaBattleReport.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_ArenaBattleReport.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaBattleReport.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaBattleReport.ArenaBattleReportToPBArenaBattleReport_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ArenaBattleReport.<>f__mg$cache1);
		string name = "DefenderHeroes";
		if (Lua_BlackJack_ProjectL_Common_ArenaBattleReport.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaBattleReport.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaBattleReport.get_DefenderHeroes);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_ArenaBattleReport.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_Common_ArenaBattleReport.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaBattleReport.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaBattleReport.set_DefenderHeroes);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_ArenaBattleReport.<>f__mg$cache3, true);
		string name2 = "DefenderTechs";
		if (Lua_BlackJack_ProjectL_Common_ArenaBattleReport.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaBattleReport.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaBattleReport.get_DefenderTechs);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_ArenaBattleReport.<>f__mg$cache4;
		if (Lua_BlackJack_ProjectL_Common_ArenaBattleReport.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaBattleReport.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaBattleReport.set_DefenderTechs);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_ArenaBattleReport.<>f__mg$cache5, true);
		string name3 = "AttackerHeroes";
		if (Lua_BlackJack_ProjectL_Common_ArenaBattleReport.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaBattleReport.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaBattleReport.get_AttackerHeroes);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Common_ArenaBattleReport.<>f__mg$cache6;
		if (Lua_BlackJack_ProjectL_Common_ArenaBattleReport.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaBattleReport.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaBattleReport.set_AttackerHeroes);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Common_ArenaBattleReport.<>f__mg$cache7, true);
		string name4 = "AttackerTechs";
		if (Lua_BlackJack_ProjectL_Common_ArenaBattleReport.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaBattleReport.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaBattleReport.get_AttackerTechs);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Common_ArenaBattleReport.<>f__mg$cache8;
		if (Lua_BlackJack_ProjectL_Common_ArenaBattleReport.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaBattleReport.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaBattleReport.set_AttackerTechs);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Common_ArenaBattleReport.<>f__mg$cache9, true);
		string name5 = "Status";
		if (Lua_BlackJack_ProjectL_Common_ArenaBattleReport.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaBattleReport.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaBattleReport.get_Status);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_Common_ArenaBattleReport.<>f__mg$cacheA;
		if (Lua_BlackJack_ProjectL_Common_ArenaBattleReport.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaBattleReport.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaBattleReport.set_Status);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_Common_ArenaBattleReport.<>f__mg$cacheB, true);
		string name6 = "ArenaDefenderRuleId";
		if (Lua_BlackJack_ProjectL_Common_ArenaBattleReport.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaBattleReport.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaBattleReport.get_ArenaDefenderRuleId);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_Common_ArenaBattleReport.<>f__mg$cacheC;
		if (Lua_BlackJack_ProjectL_Common_ArenaBattleReport.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaBattleReport.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaBattleReport.set_ArenaDefenderRuleId);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_Common_ArenaBattleReport.<>f__mg$cacheD, true);
		string name7 = "DefenderUserId";
		if (Lua_BlackJack_ProjectL_Common_ArenaBattleReport.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaBattleReport.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaBattleReport.get_DefenderUserId);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_Common_ArenaBattleReport.<>f__mg$cacheE;
		if (Lua_BlackJack_ProjectL_Common_ArenaBattleReport.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaBattleReport.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaBattleReport.set_DefenderUserId);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_Common_ArenaBattleReport.<>f__mg$cacheF, true);
		string name8 = "DefenderName";
		if (Lua_BlackJack_ProjectL_Common_ArenaBattleReport.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaBattleReport.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaBattleReport.get_DefenderName);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_Common_ArenaBattleReport.<>f__mg$cache10;
		if (Lua_BlackJack_ProjectL_Common_ArenaBattleReport.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaBattleReport.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaBattleReport.set_DefenderName);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_Common_ArenaBattleReport.<>f__mg$cache11, true);
		string name9 = "DefenderLevel";
		if (Lua_BlackJack_ProjectL_Common_ArenaBattleReport.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaBattleReport.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaBattleReport.get_DefenderLevel);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_Common_ArenaBattleReport.<>f__mg$cache12;
		if (Lua_BlackJack_ProjectL_Common_ArenaBattleReport.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaBattleReport.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaBattleReport.set_DefenderLevel);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_Common_ArenaBattleReport.<>f__mg$cache13, true);
		string name10 = "AttackerUserId";
		if (Lua_BlackJack_ProjectL_Common_ArenaBattleReport.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaBattleReport.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaBattleReport.get_AttackerUserId);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_Common_ArenaBattleReport.<>f__mg$cache14;
		if (Lua_BlackJack_ProjectL_Common_ArenaBattleReport.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaBattleReport.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaBattleReport.set_AttackerUserId);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_Common_ArenaBattleReport.<>f__mg$cache15, true);
		string name11 = "AttackerName";
		if (Lua_BlackJack_ProjectL_Common_ArenaBattleReport.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaBattleReport.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaBattleReport.get_AttackerName);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_Common_ArenaBattleReport.<>f__mg$cache16;
		if (Lua_BlackJack_ProjectL_Common_ArenaBattleReport.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaBattleReport.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaBattleReport.set_AttackerName);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_Common_ArenaBattleReport.<>f__mg$cache17, true);
		string name12 = "AttackerLevel";
		if (Lua_BlackJack_ProjectL_Common_ArenaBattleReport.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaBattleReport.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaBattleReport.get_AttackerLevel);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_Common_ArenaBattleReport.<>f__mg$cache18;
		if (Lua_BlackJack_ProjectL_Common_ArenaBattleReport.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaBattleReport.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaBattleReport.set_AttackerLevel);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_Common_ArenaBattleReport.<>f__mg$cache19, true);
		string name13 = "AttackerGotArenaPoints";
		if (Lua_BlackJack_ProjectL_Common_ArenaBattleReport.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaBattleReport.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaBattleReport.get_AttackerGotArenaPoints);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_Common_ArenaBattleReport.<>f__mg$cache1A;
		if (Lua_BlackJack_ProjectL_Common_ArenaBattleReport.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaBattleReport.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaBattleReport.set_AttackerGotArenaPoints);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_Common_ArenaBattleReport.<>f__mg$cache1B, true);
		string name14 = "DefenderGotArenaPoints";
		if (Lua_BlackJack_ProjectL_Common_ArenaBattleReport.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaBattleReport.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaBattleReport.get_DefenderGotArenaPoints);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_Common_ArenaBattleReport.<>f__mg$cache1C;
		if (Lua_BlackJack_ProjectL_Common_ArenaBattleReport.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaBattleReport.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaBattleReport.set_DefenderGotArenaPoints);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_Common_ArenaBattleReport.<>f__mg$cache1D, true);
		string name15 = "CreateTime";
		if (Lua_BlackJack_ProjectL_Common_ArenaBattleReport.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaBattleReport.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaBattleReport.get_CreateTime);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_Common_ArenaBattleReport.<>f__mg$cache1E;
		if (Lua_BlackJack_ProjectL_Common_ArenaBattleReport.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaBattleReport.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaBattleReport.set_CreateTime);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_Common_ArenaBattleReport.<>f__mg$cache1F, true);
		string name16 = "OpponentHeadIcon";
		if (Lua_BlackJack_ProjectL_Common_ArenaBattleReport.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaBattleReport.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaBattleReport.get_OpponentHeadIcon);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_Common_ArenaBattleReport.<>f__mg$cache20;
		if (Lua_BlackJack_ProjectL_Common_ArenaBattleReport.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaBattleReport.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaBattleReport.set_OpponentHeadIcon);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_Common_ArenaBattleReport.<>f__mg$cache21, true);
		if (Lua_BlackJack_ProjectL_Common_ArenaBattleReport.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaBattleReport.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaBattleReport.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_ArenaBattleReport.<>f__mg$cache22, typeof(ArenaBattleReport), typeof(BattleReport));
	}

	// Token: 0x0400DE56 RID: 56918
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400DE57 RID: 56919
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400DE58 RID: 56920
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400DE59 RID: 56921
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400DE5A RID: 56922
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400DE5B RID: 56923
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400DE5C RID: 56924
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400DE5D RID: 56925
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400DE5E RID: 56926
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400DE5F RID: 56927
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400DE60 RID: 56928
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400DE61 RID: 56929
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400DE62 RID: 56930
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400DE63 RID: 56931
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400DE64 RID: 56932
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400DE65 RID: 56933
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400DE66 RID: 56934
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400DE67 RID: 56935
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400DE68 RID: 56936
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400DE69 RID: 56937
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400DE6A RID: 56938
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400DE6B RID: 56939
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400DE6C RID: 56940
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400DE6D RID: 56941
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400DE6E RID: 56942
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400DE6F RID: 56943
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0400DE70 RID: 56944
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0400DE71 RID: 56945
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0400DE72 RID: 56946
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0400DE73 RID: 56947
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0400DE74 RID: 56948
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0400DE75 RID: 56949
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0400DE76 RID: 56950
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0400DE77 RID: 56951
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0400DE78 RID: 56952
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;
}
