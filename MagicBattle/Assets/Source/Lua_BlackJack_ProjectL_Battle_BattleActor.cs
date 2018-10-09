using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Battle;
using BlackJack.ProjectL.Common;
using BlackJack.UtilityTools;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200118F RID: 4495
[Preserve]
public class Lua_BlackJack_ProjectL_Battle_BattleActor : LuaObject
{
	// Token: 0x06017028 RID: 94248 RVA: 0x0062F91C File Offset: 0x0062DB1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			BattleActor o = new BattleActor();
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

	// Token: 0x06017029 RID: 94249 RVA: 0x0062F964 File Offset: 0x0062DB64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Dispose(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			battleActor.Dispose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601702A RID: 94250 RVA: 0x0062F9B0 File Offset: 0x0062DBB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Initialize(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			BattleTeam team;
			LuaObject.checkType<BattleTeam>(l, 2, out team);
			ConfigDataHeroInfo heroInfo;
			LuaObject.checkType<ConfigDataHeroInfo>(l, 3, out heroInfo);
			ConfigDataJobConnectionInfo jobConnectionInfo;
			LuaObject.checkType<ConfigDataJobConnectionInfo>(l, 4, out jobConnectionInfo);
			ConfigDataSoldierInfo soldierInfo;
			LuaObject.checkType<ConfigDataSoldierInfo>(l, 5, out soldierInfo);
			ConfigDataSkillInfo[] skillInfos;
			LuaObject.checkArray<ConfigDataSkillInfo>(l, 6, out skillInfos);
			ConfigDataJobInfo[] masterJobInfos;
			LuaObject.checkArray<ConfigDataJobInfo>(l, 7, out masterJobInfos);
			BattleActorEquipment[] equipments;
			LuaObject.checkArray<BattleActorEquipment>(l, 8, out equipments);
			ConfigDataSkillInfo[] resonanceSkillInfos;
			LuaObject.checkArray<ConfigDataSkillInfo>(l, 9, out resonanceSkillInfos);
			ConfigDataSkillInfo[] fetterSkillInfos;
			LuaObject.checkArray<ConfigDataSkillInfo>(l, 10, out fetterSkillInfos);
			int heroLevel;
			LuaObject.checkType(l, 11, out heroLevel);
			int heroStar;
			LuaObject.checkType(l, 12, out heroStar);
			int jobLevel;
			LuaObject.checkType(l, 13, out jobLevel);
			int soldierCount;
			LuaObject.checkType(l, 14, out soldierCount);
			GridPosition pos;
			LuaObject.checkValueType<GridPosition>(l, 15, out pos);
			int dir;
			LuaObject.checkType(l, 16, out dir);
			bool isNpc;
			LuaObject.checkType(l, 17, out isNpc);
			int actionValue;
			LuaObject.checkType(l, 18, out actionValue);
			int behaviorId;
			LuaObject.checkType(l, 19, out behaviorId);
			int groupId;
			LuaObject.checkType(l, 20, out groupId);
			BattleActorSourceType sourceType;
			LuaObject.checkEnum<BattleActorSourceType>(l, 21, out sourceType);
			int playerIndex;
			LuaObject.checkType(l, 22, out playerIndex);
			battleActor.Initialize(team, heroInfo, jobConnectionInfo, soldierInfo, skillInfos, masterJobInfos, equipments, resonanceSkillInfos, fetterSkillInfos, heroLevel, heroStar, jobLevel, soldierCount, pos, dir, isNpc, actionValue, behaviorId, groupId, sourceType, playerIndex);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601702B RID: 94251 RVA: 0x0062FB14 File Offset: 0x0062DD14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitializeSkin(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			ConfigDataCharImageSkinResourceInfo heroCharImageSkinInfo;
			LuaObject.checkType<ConfigDataCharImageSkinResourceInfo>(l, 2, out heroCharImageSkinInfo);
			ConfigDataModelSkinResourceInfo heroModelSkinInfo;
			LuaObject.checkType<ConfigDataModelSkinResourceInfo>(l, 3, out heroModelSkinInfo);
			ConfigDataModelSkinResourceInfo soldierModelSkinInfo;
			LuaObject.checkType<ConfigDataModelSkinResourceInfo>(l, 4, out soldierModelSkinInfo);
			battleActor.InitializeSkin(heroCharImageSkinInfo, heroModelSkinInfo, soldierModelSkinInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601702C RID: 94252 RVA: 0x0062FB88 File Offset: 0x0062DD88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitializeExtraPassiveSkillAndTalent(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			List<ConfigDataSkillInfo> skillInfos;
			LuaObject.checkType<List<ConfigDataSkillInfo>>(l, 2, out skillInfos);
			ConfigDataSkillInfo talentSkillInfo;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 3, out talentSkillInfo);
			battleActor.InitializeExtraPassiveSkillAndTalent(skillInfos, talentSkillInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601702D RID: 94253 RVA: 0x0062FBEC File Offset: 0x0062DDEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitializeEnd(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			bool visible;
			LuaObject.checkType(l, 2, out visible);
			int heroHp;
			LuaObject.checkType(l, 3, out heroHp);
			int soldierHp;
			LuaObject.checkType(l, 4, out soldierHp);
			battleActor.InitializeEnd(visible, heroHp, soldierHp);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601702E RID: 94254 RVA: 0x0062FC60 File Offset: 0x0062DE60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateBattleProperties(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			battleActor.UpdateBattleProperties();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601702F RID: 94255 RVA: 0x0062FCAC File Offset: 0x0062DEAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateBattlePropertiesInCombat(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			BattleActor other;
			LuaObject.checkType<BattleActor>(l, 2, out other);
			bool isAttacker;
			LuaObject.checkType(l, 3, out isAttacker);
			int distance;
			LuaObject.checkType(l, 4, out distance);
			battleActor.UpdateBattlePropertiesInCombat(other, isAttacker, distance);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017030 RID: 94256 RVA: 0x0062FD20 File Offset: 0x0062DF20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CollectJobMasterPropertyModifiers(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			BattlePropertyModifier pm;
			LuaObject.checkType<BattlePropertyModifier>(l, 2, out pm);
			battleActor.CollectJobMasterPropertyModifiers(pm);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017031 RID: 94257 RVA: 0x0062FD78 File Offset: 0x0062DF78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CollectEquipmentPropertyModifiers(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			BattlePropertyModifier pm;
			LuaObject.checkType<BattlePropertyModifier>(l, 2, out pm);
			battleActor.CollectEquipmentPropertyModifiers(pm);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017032 RID: 94258 RVA: 0x0062FDD0 File Offset: 0x0062DFD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetDirection(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			int direction;
			LuaObject.checkType(l, 2, out direction);
			battleActor.SetDirection(direction);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017033 RID: 94259 RVA: 0x0062FE28 File Offset: 0x0062E028
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FaceTo(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			GridPosition p;
			LuaObject.checkValueType<GridPosition>(l, 2, out p);
			battleActor.FaceTo(p);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017034 RID: 94260 RVA: 0x0062FE80 File Offset: 0x0062E080
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GuardMove(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			GridPosition p;
			LuaObject.checkValueType<GridPosition>(l, 2, out p);
			battleActor.GuardMove(p);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017035 RID: 94261 RVA: 0x0062FED8 File Offset: 0x0062E0D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UnguardMove(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			battleActor.UnguardMove();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017036 RID: 94262 RVA: 0x0062FF24 File Offset: 0x0062E124
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetTerrain(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			ConfigDataTerrainInfo terrain = battleActor.GetTerrain();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, terrain);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017037 RID: 94263 RVA: 0x0062FF78 File Offset: 0x0062E178
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetBuffEffectedTerrain(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			ConfigDataTerrainInfo buffEffectedTerrain = battleActor.GetBuffEffectedTerrain();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, buffEffectedTerrain);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017038 RID: 94264 RVA: 0x0062FFCC File Offset: 0x0062E1CC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ChangeTeam(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			int team;
			LuaObject.checkType(l, 2, out team);
			bool isNpc;
			LuaObject.checkType(l, 3, out isNpc);
			battleActor.ChangeTeam(team, isNpc);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017039 RID: 94265 RVA: 0x00630030 File Offset: 0x0062E230
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CreateBattleCommand(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			BattleCommandType type;
			LuaObject.checkEnum<BattleCommandType>(l, 2, out type);
			BattleCommand o = battleActor.CreateBattleCommand(type);
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

	// Token: 0x0601703A RID: 94266 RVA: 0x00630094 File Offset: 0x0062E294
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int StartBattle(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			battleActor.StartBattle();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601703B RID: 94267 RVA: 0x006300E0 File Offset: 0x0062E2E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StopBattle(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			bool win;
			LuaObject.checkType(l, 2, out win);
			battleActor.StopBattle(win);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601703C RID: 94268 RVA: 0x00630138 File Offset: 0x0062E338
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int NextTurn(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			battleActor.NextTurn();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601703D RID: 94269 RVA: 0x00630184 File Offset: 0x0062E384
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ActionBegin(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			battleActor.ActionBegin();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601703E RID: 94270 RVA: 0x006301D0 File Offset: 0x0062E3D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ActionEnd(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			battleActor.ActionEnd();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601703F RID: 94271 RVA: 0x0063021C File Offset: 0x0062E41C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsActionFinished(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			bool b = battleActor.IsActionFinished();
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

	// Token: 0x06017040 RID: 94272 RVA: 0x00630270 File Offset: 0x0062E470
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CanAction(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			bool b = battleActor.CanAction();
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

	// Token: 0x06017041 RID: 94273 RVA: 0x006302C4 File Offset: 0x0062E4C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FindPath(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(GridPosition), typeof(GridPosition), typeof(int), typeof(int), typeof(int), typeof(List<GridPosition>)))
			{
				BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
				GridPosition start;
				LuaObject.checkValueType<GridPosition>(l, 2, out start);
				GridPosition goal;
				LuaObject.checkValueType<GridPosition>(l, 3, out goal);
				int movePoint;
				LuaObject.checkType(l, 4, out movePoint);
				int ignoreTeamNumber;
				LuaObject.checkType(l, 5, out ignoreTeamNumber);
				int inRegion;
				LuaObject.checkType(l, 6, out inRegion);
				List<GridPosition> path;
				LuaObject.checkType<List<GridPosition>>(l, 7, out path);
				bool b = battleActor.FindPath(start, goal, movePoint, ignoreTeamNumber, inRegion, path);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(GridPosition), typeof(GridPosition), typeof(int), typeof(int), typeof(List<GridPosition>), typeof(bool)))
			{
				BattleActor battleActor2 = (BattleActor)LuaObject.checkSelf(l);
				GridPosition start2;
				LuaObject.checkValueType<GridPosition>(l, 2, out start2);
				GridPosition goal2;
				LuaObject.checkValueType<GridPosition>(l, 3, out goal2);
				int movePoint2;
				LuaObject.checkType(l, 4, out movePoint2);
				int inRegion2;
				LuaObject.checkType(l, 5, out inRegion2);
				List<GridPosition> path2;
				LuaObject.checkType<List<GridPosition>>(l, 6, out path2);
				bool findNearestIfFail;
				LuaObject.checkType(l, 7, out findNearestIfFail);
				bool b2 = battleActor2.FindPath(start2, goal2, movePoint2, inRegion2, path2, findNearestIfFail);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function FindPath to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017042 RID: 94274 RVA: 0x0063049C File Offset: 0x0062E69C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int FindMoveRegion(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			GridPosition start;
			LuaObject.checkValueType<GridPosition>(l, 2, out start);
			List<GridPosition> region;
			LuaObject.checkType<List<GridPosition>>(l, 3, out region);
			battleActor.FindMoveRegion(start, region);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017043 RID: 94275 RVA: 0x00630500 File Offset: 0x0062E700
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int HasExecutedCommandType(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			BattleCommandType cmdType;
			LuaObject.checkEnum<BattleCommandType>(l, 2, out cmdType);
			bool b = battleActor.HasExecutedCommandType(cmdType);
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

	// Token: 0x06017044 RID: 94276 RVA: 0x00630564 File Offset: 0x0062E764
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ExecuteMoveCommand(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			GridPosition p;
			LuaObject.checkValueType<GridPosition>(l, 2, out p);
			bool b = battleActor.ExecuteMoveCommand(p);
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

	// Token: 0x06017045 RID: 94277 RVA: 0x006305C8 File Offset: 0x0062E7C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ExecutePerformMoveCommand(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			GridPosition p;
			LuaObject.checkValueType<GridPosition>(l, 2, out p);
			bool cameraFollow;
			LuaObject.checkType(l, 3, out cameraFollow);
			bool b = battleActor.ExecutePerformMoveCommand(p, cameraFollow);
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

	// Token: 0x06017046 RID: 94278 RVA: 0x00630638 File Offset: 0x0062E838
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ExecuteCombatCommand(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			BattleActor target;
			LuaObject.checkType<BattleActor>(l, 2, out target);
			ConfigDataSkillInfo skillInfo;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 3, out skillInfo);
			bool isPerform;
			LuaObject.checkType(l, 4, out isPerform);
			bool b = battleActor.ExecuteCombatCommand(target, skillInfo, isPerform);
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

	// Token: 0x06017047 RID: 94279 RVA: 0x006306B4 File Offset: 0x0062E8B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ExecuteSkillCommand(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			int skillIndex;
			LuaObject.checkType(l, 2, out skillIndex);
			GridPosition p;
			LuaObject.checkValueType<GridPosition>(l, 3, out p);
			GridPosition p2;
			LuaObject.checkValueType<GridPosition>(l, 4, out p2);
			bool b = battleActor.ExecuteSkillCommand(skillIndex, p, p2);
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

	// Token: 0x06017048 RID: 94280 RVA: 0x00630730 File Offset: 0x0062E930
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ExecutePerformSkillCommand(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			ConfigDataSkillInfo skillInfo;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 2, out skillInfo);
			GridPosition p;
			LuaObject.checkValueType<GridPosition>(l, 3, out p);
			GridPosition p2;
			LuaObject.checkValueType<GridPosition>(l, 4, out p2);
			bool b = battleActor.ExecutePerformSkillCommand(skillInfo, p, p2);
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

	// Token: 0x06017049 RID: 94281 RVA: 0x006307AC File Offset: 0x0062E9AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ExecuteDoneCommand(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			bool b = battleActor.ExecuteDoneCommand();
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

	// Token: 0x0601704A RID: 94282 RVA: 0x00630800 File Offset: 0x0062EA00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsDead(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			bool b = battleActor.IsDead();
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

	// Token: 0x0601704B RID: 94283 RVA: 0x00630854 File Offset: 0x0062EA54
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsRetreat(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			bool b = battleActor.IsRetreat();
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

	// Token: 0x0601704C RID: 94284 RVA: 0x006308A8 File Offset: 0x0062EAA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsDeadOrRetreat(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			bool b = battleActor.IsDeadOrRetreat();
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

	// Token: 0x0601704D RID: 94285 RVA: 0x006308FC File Offset: 0x0062EAFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetVisible(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			bool visible;
			LuaObject.checkType(l, 2, out visible);
			battleActor.SetVisible(visible);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601704E RID: 94286 RVA: 0x00630954 File Offset: 0x0062EB54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsVisible(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			bool b = battleActor.IsVisible();
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

	// Token: 0x0601704F RID: 94287 RVA: 0x006309A8 File Offset: 0x0062EBA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsInvincible(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			bool b = battleActor.IsInvincible();
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

	// Token: 0x06017050 RID: 94288 RVA: 0x006309FC File Offset: 0x0062EBFC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsSummoned(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			bool b = battleActor.IsSummoned();
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

	// Token: 0x06017051 RID: 94289 RVA: 0x00630A50 File Offset: 0x0062EC50
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsNpc(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			bool b = battleActor.IsNpc();
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

	// Token: 0x06017052 RID: 94290 RVA: 0x00630AA4 File Offset: 0x0062ECA4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsAINpc(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			bool b = battleActor.IsAINpc();
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

	// Token: 0x06017053 RID: 94291 RVA: 0x00630AF8 File Offset: 0x0062ECF8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsPlayerNpc(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			bool b = battleActor.IsPlayerNpc();
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

	// Token: 0x06017054 RID: 94292 RVA: 0x00630B4C File Offset: 0x0062ED4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsPlayerActor(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			bool b = battleActor.IsPlayerActor();
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

	// Token: 0x06017055 RID: 94293 RVA: 0x00630BA0 File Offset: 0x0062EDA0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsAIActor(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			bool b = battleActor.IsAIActor();
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

	// Token: 0x06017056 RID: 94294 RVA: 0x00630BF4 File Offset: 0x0062EDF4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CanBeTarget(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			bool b = battleActor.CanBeTarget();
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

	// Token: 0x06017057 RID: 94295 RVA: 0x00630C48 File Offset: 0x0062EE48
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetHeroHealthPoint(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			int heroHealthPoint;
			LuaObject.checkType(l, 2, out heroHealthPoint);
			battleActor.SetHeroHealthPoint(heroHealthPoint);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017058 RID: 94296 RVA: 0x00630CA0 File Offset: 0x0062EEA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetSoldierTotalHealthPoint(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			int soldierTotalHealthPoint;
			LuaObject.checkType(l, 2, out soldierTotalHealthPoint);
			battleActor.SetSoldierTotalHealthPoint(soldierTotalHealthPoint);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017059 RID: 94297 RVA: 0x00630CF8 File Offset: 0x0062EEF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CheckDie(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			BattleActor attacker;
			LuaObject.checkType<BattleActor>(l, 2, out attacker);
			battleActor.CheckDie(attacker);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601705A RID: 94298 RVA: 0x00630D50 File Offset: 0x0062EF50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Retreat(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			int effectType;
			LuaObject.checkType(l, 2, out effectType);
			string fxName;
			LuaObject.checkType(l, 3, out fxName);
			bool notifyListener;
			LuaObject.checkType(l, 4, out notifyListener);
			battleActor.Retreat(effectType, fxName, notifyListener);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601705B RID: 94299 RVA: 0x00630DC4 File Offset: 0x0062EFC4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetSoldierAttackDistance(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			int soldierAttackDistance = battleActor.GetSoldierAttackDistance();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, soldierAttackDistance);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601705C RID: 94300 RVA: 0x00630E18 File Offset: 0x0062F018
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetMaxAttackDistance(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			int maxAttackDistance = battleActor.GetMaxAttackDistance();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, maxAttackDistance);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601705D RID: 94301 RVA: 0x00630E6C File Offset: 0x0062F06C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetTalentSkillInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			ConfigDataSkillInfo talentSkillInfo = battleActor.GetTalentSkillInfo();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, talentSkillInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601705E RID: 94302 RVA: 0x00630EC0 File Offset: 0x0062F0C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetSkillDistance(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			ConfigDataSkillInfo skillInfo;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 2, out skillInfo);
			int skillDistance = battleActor.GetSkillDistance(skillInfo);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, skillDistance);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601705F RID: 94303 RVA: 0x00630F24 File Offset: 0x0062F124
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetMovePoint(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			int movePoint = battleActor.GetMovePoint();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, movePoint);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017060 RID: 94304 RVA: 0x00630F78 File Offset: 0x0062F178
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetMoveType(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			MoveType moveType = battleActor.GetMoveType();
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)moveType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017061 RID: 94305 RVA: 0x00630FCC File Offset: 0x0062F1CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetTotalHealthPoint(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			int totalHealthPoint = battleActor.GetTotalHealthPoint();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, totalHealthPoint);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017062 RID: 94306 RVA: 0x00631020 File Offset: 0x0062F220
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetTotalHealthPointMax(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			int totalHealthPointMax = battleActor.GetTotalHealthPointMax();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, totalHealthPointMax);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017063 RID: 94307 RVA: 0x00631074 File Offset: 0x0062F274
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetSoldierCount(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			int soldierCount = battleActor.GetSoldierCount();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, soldierCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017064 RID: 94308 RVA: 0x006310C8 File Offset: 0x0062F2C8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetLastDamageBySkill(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			ConfigDataSkillInfo lastDamageBySkill;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 2, out lastDamageBySkill);
			battleActor.SetLastDamageBySkill(lastDamageBySkill);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017065 RID: 94309 RVA: 0x00631120 File Offset: 0x0062F320
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetLastDamageBySkill(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			ConfigDataSkillInfo lastDamageBySkill = battleActor.GetLastDamageBySkill();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, lastDamageBySkill);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017066 RID: 94310 RVA: 0x00631174 File Offset: 0x0062F374
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetFirstDamageTurn(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			int firstDamageTurn;
			LuaObject.checkType(l, 2, out firstDamageTurn);
			battleActor.SetFirstDamageTurn(firstDamageTurn);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017067 RID: 94311 RVA: 0x006311CC File Offset: 0x0062F3CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetFirstDamageTurn(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			int firstDamageTurn = battleActor.GetFirstDamageTurn();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, firstDamageTurn);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017068 RID: 94312 RVA: 0x00631220 File Offset: 0x0062F420
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetSetisfyCondition(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			int setisfyCondition;
			LuaObject.checkType(l, 2, out setisfyCondition);
			battleActor.SetSetisfyCondition(setisfyCondition);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017069 RID: 94313 RVA: 0x00631278 File Offset: 0x0062F478
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsSatisfyCondition(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			int conditionId;
			LuaObject.checkType(l, 2, out conditionId);
			bool b = battleActor.IsSatisfyCondition(conditionId);
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

	// Token: 0x0601706A RID: 94314 RVA: 0x006312DC File Offset: 0x0062F4DC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetDeathAnimType(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			int deathAnimType = battleActor.GetDeathAnimType();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, deathAnimType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601706B RID: 94315 RVA: 0x00631330 File Offset: 0x0062F530
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetBeCriticalAttack(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			bool beCriticalAttack;
			LuaObject.checkType(l, 2, out beCriticalAttack);
			battleActor.SetBeCriticalAttack(beCriticalAttack);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601706C RID: 94316 RVA: 0x00631388 File Offset: 0x0062F588
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetBeKillAttack(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			bool beKillAttack;
			LuaObject.checkType(l, 2, out beKillAttack);
			battleActor.SetBeKillAttack(beKillAttack);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601706D RID: 94317 RVA: 0x006313E0 File Offset: 0x0062F5E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetActionCriticalAttack(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			battleActor.SetActionCriticalAttack();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601706E RID: 94318 RVA: 0x0063142C File Offset: 0x0062F62C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetActionKillActor(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			battleActor.SetActionKillActor();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601706F RID: 94319 RVA: 0x00631478 File Offset: 0x0062F678
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetActionDamageActor(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			battleActor.SetActionDamageActor();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017070 RID: 94320 RVA: 0x006314C4 File Offset: 0x0062F6C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsExtraAction(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			bool b = battleActor.IsExtraAction();
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

	// Token: 0x06017071 RID: 94321 RVA: 0x00631518 File Offset: 0x0062F718
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsExtraActionMoving(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			bool b = battleActor.IsExtraActionMoving();
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

	// Token: 0x06017072 RID: 94322 RVA: 0x0063156C File Offset: 0x0062F76C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetActionCount(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			short actionCount = battleActor.GetActionCount();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, actionCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017073 RID: 94323 RVA: 0x006315C0 File Offset: 0x0062F7C0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IncreaseCombatAttackCount(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			battleActor.IncreaseCombatAttackCount();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017074 RID: 94324 RVA: 0x0063160C File Offset: 0x0062F80C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetCombatAttackCount(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			short combatAttackCount = battleActor.GetCombatAttackCount();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatAttackCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017075 RID: 94325 RVA: 0x00631660 File Offset: 0x0062F860
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IncreaseBeCombatAttackCount(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			battleActor.IncreaseBeCombatAttackCount();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017076 RID: 94326 RVA: 0x006316AC File Offset: 0x0062F8AC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetBeCombatAttackCount(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			short beCombatAttackCount = battleActor.GetBeCombatAttackCount();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, beCombatAttackCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017077 RID: 94327 RVA: 0x00631700 File Offset: 0x0062F900
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IncreaseUseSkillCount(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			battleActor.IncreaseUseSkillCount();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017078 RID: 94328 RVA: 0x0063174C File Offset: 0x0062F94C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetUseSkillCount(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			short useSkillCount = battleActor.GetUseSkillCount();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, useSkillCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017079 RID: 94329 RVA: 0x006317A0 File Offset: 0x0062F9A0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IncreaseKillActorCount(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			battleActor.IncreaseKillActorCount();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601707A RID: 94330 RVA: 0x006317EC File Offset: 0x0062F9EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetKillActorCount(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			int killActorCount = battleActor.GetKillActorCount();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, killActorCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601707B RID: 94331 RVA: 0x00631840 File Offset: 0x0062FA40
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetKillerActor(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			BattleActor killerActor = battleActor.GetKillerActor();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, killerActor);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601707C RID: 94332 RVA: 0x00631894 File Offset: 0x0062FA94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetDieTurn(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			int dieTurn = battleActor.GetDieTurn();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dieTurn);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601707D RID: 94333 RVA: 0x006318E8 File Offset: 0x0062FAE8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetSourceType(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			BattleActorSourceType sourceType = battleActor.GetSourceType();
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)sourceType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601707E RID: 94334 RVA: 0x0063193C File Offset: 0x0062FB3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IncreaseBeAttackedCount(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			battleActor.IncreaseBeAttackedCount();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601707F RID: 94335 RVA: 0x00631988 File Offset: 0x0062FB88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetBehaviorId(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			int behaviorId = battleActor.GetBehaviorId();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, behaviorId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017080 RID: 94336 RVA: 0x006319DC File Offset: 0x0062FBDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetBehavior(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			int behavior;
			LuaObject.checkType(l, 2, out behavior);
			battleActor.SetBehavior(behavior);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017081 RID: 94337 RVA: 0x00631A34 File Offset: 0x0062FC34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CheckBehaviorCondition(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			BehaviorCondition condition;
			LuaObject.checkEnum<BehaviorCondition>(l, 2, out condition);
			ConfigDataBehavior.ParamData param;
			LuaObject.checkType<ConfigDataBehavior.ParamData>(l, 3, out param);
			bool b = battleActor.CheckBehaviorCondition(condition, param);
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

	// Token: 0x06017082 RID: 94338 RVA: 0x00631AA4 File Offset: 0x0062FCA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FindEmptyGridInCanAttackAndTouchRange(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			GridPosition startPoint;
			LuaObject.checkValueType<GridPosition>(l, 2, out startPoint);
			int attackDistance;
			LuaObject.checkType(l, 3, out attackDistance);
			int shape;
			LuaObject.checkType(l, 4, out shape);
			GridPosition gridPosition = battleActor.FindEmptyGridInCanAttackAndTouchRange(startPoint, attackDistance, shape);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, gridPosition);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017083 RID: 94339 RVA: 0x00631B28 File Offset: 0x0062FD28
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int FindActorsInCanAttackAndTouchRange(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			List<BattleActor> destActors;
			LuaObject.checkType<List<BattleActor>>(l, 2, out destActors);
			GridPosition startPoint;
			LuaObject.checkValueType<GridPosition>(l, 3, out startPoint);
			int attackDistance;
			LuaObject.checkType(l, 4, out attackDistance);
			int shape;
			LuaObject.checkType(l, 5, out shape);
			bool excludeSelf;
			LuaObject.checkType(l, 6, out excludeSelf);
			List<BattleActor> o = battleActor.FindActorsInCanAttackAndTouchRange(destActors, startPoint, attackDistance, shape, excludeSelf);
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

	// Token: 0x06017084 RID: 94340 RVA: 0x00631BBC File Offset: 0x0062FDBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GenerateAIBattleCommand(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			battleActor.GenerateAIBattleCommand();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017085 RID: 94341 RVA: 0x00631C08 File Offset: 0x0062FE08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetBuffStates(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			List<BuffState> buffStates = battleActor.GetBuffStates();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, buffStates);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017086 RID: 94342 RVA: 0x00631C5C File Offset: 0x0062FE5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AttachBuff(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			ConfigDataBuffInfo buffInfo;
			LuaObject.checkType<ConfigDataBuffInfo>(l, 2, out buffInfo);
			BattleActor applyer;
			LuaObject.checkType<BattleActor>(l, 3, out applyer);
			BuffSourceType sourceType;
			LuaObject.checkEnum<BuffSourceType>(l, 4, out sourceType);
			ConfigDataSkillInfo sourceSkillInfo;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 5, out sourceSkillInfo);
			BuffState sourceBuffState;
			LuaObject.checkType<BuffState>(l, 6, out sourceBuffState);
			bool b = battleActor.AttachBuff(buffInfo, applyer, sourceType, sourceSkillInfo, sourceBuffState);
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

	// Token: 0x06017087 RID: 94343 RVA: 0x00631CF0 File Offset: 0x0062FEF0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int RemoveBuffList(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			List<int> buffIds;
			LuaObject.checkType<List<int>>(l, 2, out buffIds);
			int i = battleActor.RemoveBuffList(buffIds);
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

	// Token: 0x06017088 RID: 94344 RVA: 0x00631D54 File Offset: 0x0062FF54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SkillDispelBuff(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			ConfigDataSkillInfo skillInfo;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 2, out skillInfo);
			battleActor.SkillDispelBuff(skillInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017089 RID: 94345 RVA: 0x00631DAC File Offset: 0x0062FFAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CollectBuffPropertyModifiersAndFightTags(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			BattlePropertyModifier pm;
			LuaObject.checkType<BattlePropertyModifier>(l, 2, out pm);
			uint o;
			LuaObject.checkType(l, 3, out o);
			bool collectStatic;
			LuaObject.checkType(l, 4, out collectStatic);
			bool collectDynamic;
			LuaObject.checkType(l, 5, out collectDynamic);
			battleActor.CollectBuffPropertyModifiersAndFightTags(pm, ref o, collectStatic, collectDynamic);
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

	// Token: 0x0601708A RID: 94346 RVA: 0x00631E34 File Offset: 0x00630034
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CollectBuffPropertyExchange(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			BattleProperty battleProperty;
			LuaObject.checkType<BattleProperty>(l, 2, out battleProperty);
			BattlePropertyModifier pm;
			LuaObject.checkType<BattlePropertyModifier>(l, 3, out pm);
			battleActor.CollectBuffPropertyExchange(battleProperty, pm);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601708B RID: 94347 RVA: 0x00631E98 File Offset: 0x00630098
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CollectBuffPropertyReplace(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			battleActor.CollectBuffPropertyReplace();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601708C RID: 94348 RVA: 0x00631EE4 File Offset: 0x006300E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateAllAuras(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			battleActor.UpdateAllAuras();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601708D RID: 94349 RVA: 0x00631F30 File Offset: 0x00630130
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HasFightTag(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			FightTag ft;
			LuaObject.checkEnum<FightTag>(l, 2, out ft);
			bool b = battleActor.HasFightTag(ft);
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

	// Token: 0x0601708E RID: 94350 RVA: 0x00631F94 File Offset: 0x00630194
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HasBuffType(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			BuffType bt;
			LuaObject.checkEnum<BuffType>(l, 2, out bt);
			bool b = battleActor.HasBuffType(bt);
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

	// Token: 0x0601708F RID: 94351 RVA: 0x00631FF8 File Offset: 0x006301F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsBuffEffective(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			BuffState bs;
			LuaObject.checkType<BuffState>(l, 2, out bs);
			bool b = battleActor.IsBuffEffective(bs);
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

	// Token: 0x06017090 RID: 94352 RVA: 0x0063205C File Offset: 0x0063025C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ComputeBuffReboundDamage(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			ConfigDataSkillInfo skillInfo;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 2, out skillInfo);
			int damage;
			LuaObject.checkType(l, 3, out damage);
			int i = battleActor.ComputeBuffReboundDamage(skillInfo, damage);
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

	// Token: 0x06017091 RID: 94353 RVA: 0x006320CC File Offset: 0x006302CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetBuffOverrideMovePointCost(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			int buffOverrideMovePointCost = battleActor.GetBuffOverrideMovePointCost();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, buffOverrideMovePointCost);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017092 RID: 94354 RVA: 0x00632120 File Offset: 0x00630320
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetBuffOverrideTerrain(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			ConfigDataTerrainInfo buffOverrideTerrain = battleActor.GetBuffOverrideTerrain();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, buffOverrideTerrain);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017093 RID: 94355 RVA: 0x00632174 File Offset: 0x00630374
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int AddBuffArmyRelationAttack(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			int targetArmyId;
			LuaObject.checkType(l, 2, out targetArmyId);
			bool targetIsHero;
			LuaObject.checkType(l, 3, out targetIsHero);
			ArmyRelationData armyRelationData;
			LuaObject.checkValueType<ArmyRelationData>(l, 4, out armyRelationData);
			battleActor.AddBuffArmyRelationAttack(targetArmyId, targetIsHero, ref armyRelationData);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, armyRelationData);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017094 RID: 94356 RVA: 0x006321F4 File Offset: 0x006303F4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int AddBuffArmyRelationDefend(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			int targetArmyId;
			LuaObject.checkType(l, 2, out targetArmyId);
			bool targetIsHero;
			LuaObject.checkType(l, 3, out targetIsHero);
			ArmyRelationData armyRelationData;
			LuaObject.checkValueType<ArmyRelationData>(l, 4, out armyRelationData);
			battleActor.AddBuffArmyRelationDefend(targetArmyId, targetIsHero, ref armyRelationData);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, armyRelationData);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017095 RID: 94357 RVA: 0x00632274 File Offset: 0x00630474
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int AddBuffArmyRelationModifyAttack(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			int restrainValue;
			LuaObject.checkType(l, 2, out restrainValue);
			bool targetIsHero;
			LuaObject.checkType(l, 3, out targetIsHero);
			ArmyRelationData armyRelationData;
			LuaObject.checkValueType<ArmyRelationData>(l, 4, out armyRelationData);
			battleActor.AddBuffArmyRelationModifyAttack(restrainValue, targetIsHero, ref armyRelationData);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, armyRelationData);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017096 RID: 94358 RVA: 0x006322F4 File Offset: 0x006304F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddBuffArmyRelationModifyDefend(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			int restrainValue;
			LuaObject.checkType(l, 2, out restrainValue);
			bool targetIsHero;
			LuaObject.checkType(l, 3, out targetIsHero);
			ArmyRelationData armyRelationData;
			LuaObject.checkValueType<ArmyRelationData>(l, 4, out armyRelationData);
			battleActor.AddBuffArmyRelationModifyDefend(restrainValue, targetIsHero, ref armyRelationData);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, armyRelationData);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017097 RID: 94359 RVA: 0x00632374 File Offset: 0x00630574
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsBuffForceMagicDamage(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			bool attackerIsHero;
			LuaObject.checkType(l, 2, out attackerIsHero);
			bool b = battleActor.IsBuffForceMagicDamage(attackerIsHero);
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

	// Token: 0x06017098 RID: 94360 RVA: 0x006323D8 File Offset: 0x006305D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ActionEndBuffDoubleMove(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			bool isKill;
			LuaObject.checkType(l, 2, out isKill);
			bool isCritical;
			LuaObject.checkType(l, 3, out isCritical);
			battleActor.ActionEndBuffDoubleMove(isKill, isCritical);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017099 RID: 94361 RVA: 0x0063243C File Offset: 0x0063063C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CombatBuffHeal(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			BattleActor target;
			LuaObject.checkType<BattleActor>(l, 2, out target);
			bool beforeCombat;
			LuaObject.checkType(l, 3, out beforeCombat);
			bool isAttacker;
			LuaObject.checkType(l, 4, out isAttacker);
			int distance;
			LuaObject.checkType(l, 5, out distance);
			bool isCritical;
			LuaObject.checkType(l, 6, out isCritical);
			int heroDamage;
			LuaObject.checkType(l, 7, out heroDamage);
			int soldierDamage;
			LuaObject.checkType(l, 8, out soldierDamage);
			battleActor.CombatBuffHeal(target, beforeCombat, isAttacker, distance, isCritical, heroDamage, soldierDamage);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601709A RID: 94362 RVA: 0x006324E0 File Offset: 0x006306E0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CombatBuffHealOther(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			BattleActor target;
			LuaObject.checkType<BattleActor>(l, 2, out target);
			bool beforeCombat;
			LuaObject.checkType(l, 3, out beforeCombat);
			bool isAttacker;
			LuaObject.checkType(l, 4, out isAttacker);
			int soldierDamage;
			LuaObject.checkType(l, 5, out soldierDamage);
			bool isCritical;
			LuaObject.checkType(l, 6, out isCritical);
			int distance;
			LuaObject.checkType(l, 7, out distance);
			int heroDamage;
			LuaObject.checkType(l, 8, out heroDamage);
			battleActor.CombatBuffHealOther(target, beforeCombat, isAttacker, soldierDamage, isCritical, distance, heroDamage);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601709B RID: 94363 RVA: 0x00632584 File Offset: 0x00630784
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CombatBuffDamage(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			BattleActor target;
			LuaObject.checkType<BattleActor>(l, 2, out target);
			bool beforeCombat;
			LuaObject.checkType(l, 3, out beforeCombat);
			bool isAttacker;
			LuaObject.checkType(l, 4, out isAttacker);
			int distance;
			LuaObject.checkType(l, 5, out distance);
			bool isCritical;
			LuaObject.checkType(l, 6, out isCritical);
			battleActor.CombatBuffDamage(target, beforeCombat, isAttacker, distance, isCritical);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601709C RID: 94364 RVA: 0x00632610 File Offset: 0x00630810
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CombatApplyBuff(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			BattleActor target;
			LuaObject.checkType<BattleActor>(l, 2, out target);
			bool beforeCombat;
			LuaObject.checkType(l, 3, out beforeCombat);
			bool isAttacker;
			LuaObject.checkType(l, 4, out isAttacker);
			int distance;
			LuaObject.checkType(l, 5, out distance);
			bool isCritical;
			LuaObject.checkType(l, 6, out isCritical);
			battleActor.CombatApplyBuff(target, beforeCombat, isAttacker, distance, isCritical);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601709D RID: 94365 RVA: 0x0063269C File Offset: 0x0063089C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int AttackApplyBuff(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			List<BattleActor> targets;
			LuaObject.checkType<List<BattleActor>>(l, 2, out targets);
			battleActor.AttackApplyBuff(targets);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601709E RID: 94366 RVA: 0x006326F4 File Offset: 0x006308F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AttackBuffDamage(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			List<BattleActor> targets;
			LuaObject.checkType<List<BattleActor>>(l, 2, out targets);
			bool beforeCombat;
			LuaObject.checkType(l, 3, out beforeCombat);
			bool isAttacker;
			LuaObject.checkType(l, 4, out isAttacker);
			int combatDistance;
			LuaObject.checkType(l, 5, out combatDistance);
			battleActor.AttackBuffDamage(targets, beforeCombat, isAttacker, combatDistance);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601709F RID: 94367 RVA: 0x00632774 File Offset: 0x00630974
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AttackRemoveBuff(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			List<BattleActor> targets;
			LuaObject.checkType<List<BattleActor>>(l, 2, out targets);
			bool beforeCombat;
			LuaObject.checkType(l, 3, out beforeCombat);
			bool isAttacker;
			LuaObject.checkType(l, 4, out isAttacker);
			int combatDistance;
			LuaObject.checkType(l, 5, out combatDistance);
			battleActor.AttackRemoveBuff(targets, beforeCombat, isAttacker, combatDistance);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060170A0 RID: 94368 RVA: 0x006327F4 File Offset: 0x006309F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AttackRemoveSkillCooldown(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			ConfigDataSkillInfo skillInfo;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 2, out skillInfo);
			bool isCritical;
			LuaObject.checkType(l, 3, out isCritical);
			bool isKill;
			LuaObject.checkType(l, 4, out isKill);
			battleActor.AttackRemoveSkillCooldown(skillInfo, isCritical, isKill);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060170A1 RID: 94369 RVA: 0x00632868 File Offset: 0x00630A68
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int BattleFieldSkillApplyBuff(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			List<BattleActor> targets;
			LuaObject.checkType<List<BattleActor>>(l, 2, out targets);
			battleActor.BattleFieldSkillApplyBuff(targets);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060170A2 RID: 94370 RVA: 0x006328C0 File Offset: 0x00630AC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AttackBuffPunch(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			BattleActor target;
			LuaObject.checkType<BattleActor>(l, 2, out target);
			battleActor.AttackBuffPunch(target);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060170A3 RID: 94371 RVA: 0x00632918 File Offset: 0x00630B18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AttackBuffDrag(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			BattleActor target;
			LuaObject.checkType<BattleActor>(l, 2, out target);
			battleActor.AttackBuffDrag(target);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060170A4 RID: 94372 RVA: 0x00632970 File Offset: 0x00630B70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AttackBuffExchangePosition(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			BattleActor target;
			LuaObject.checkType<BattleActor>(l, 2, out target);
			bool isTargetGurad;
			LuaObject.checkType(l, 3, out isTargetGurad);
			battleActor.AttackBuffExchangePosition(target, isTargetGurad);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060170A5 RID: 94373 RVA: 0x006329D4 File Offset: 0x00630BD4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CombatArmyChange(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			BattleActor target;
			LuaObject.checkType<BattleActor>(l, 2, out target);
			battleActor.CombatArmyChange(target);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060170A6 RID: 94374 RVA: 0x00632A2C File Offset: 0x00630C2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BuffDoubleAttack(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			BuffState o = battleActor.BuffDoubleAttack();
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

	// Token: 0x060170A7 RID: 94375 RVA: 0x00632A80 File Offset: 0x00630C80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BuffUndead(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			battleActor.BuffUndead();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060170A8 RID: 94376 RVA: 0x00632ACC File Offset: 0x00630CCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetGuardActor(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			ConfigDataSkillInfo skillInfo;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 2, out skillInfo);
			BattleActor guardActor = battleActor.GetGuardActor(skillInfo);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guardActor);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060170A9 RID: 94377 RVA: 0x00632B30 File Offset: 0x00630D30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AfterCombatDetachBuff(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			battleActor.AfterCombatDetachBuff();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060170AA RID: 94378 RVA: 0x00632B7C File Offset: 0x00630D7C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetSkillState(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			int index;
			LuaObject.checkType(l, 2, out index);
			BattleSkillState skillState = battleActor.GetSkillState(index);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, skillState);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060170AB RID: 94379 RVA: 0x00632BE0 File Offset: 0x00630DE0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetSkillStateById(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			int skillID;
			LuaObject.checkType(l, 2, out skillID);
			BattleSkillState skillStateById = battleActor.GetSkillStateById(skillID);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, skillStateById);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060170AC RID: 94380 RVA: 0x00632C44 File Offset: 0x00630E44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetSkillStates(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			List<BattleSkillState> skillStates = battleActor.GetSkillStates();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, skillStates);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060170AD RID: 94381 RVA: 0x00632C98 File Offset: 0x00630E98
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CanUseSkillOnTarget(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			ConfigDataSkillInfo skillInfo;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 2, out skillInfo);
			BattleActor target;
			LuaObject.checkType<BattleActor>(l, 3, out target);
			bool b = battleActor.CanUseSkillOnTarget(skillInfo, target);
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

	// Token: 0x060170AE RID: 94382 RVA: 0x00632D08 File Offset: 0x00630F08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsBattlefiledSkillApplyTarget(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			ConfigDataSkillInfo skillInfo;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 2, out skillInfo);
			BattleActor target;
			LuaObject.checkType<BattleActor>(l, 3, out target);
			bool b = battleActor.IsBattlefiledSkillApplyTarget(skillInfo, target);
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

	// Token: 0x060170AF RID: 94383 RVA: 0x00632D78 File Offset: 0x00630F78
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CombatBy(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			BattleActor attacker;
			LuaObject.checkType<BattleActor>(l, 2, out attacker);
			battleActor.CombatBy(attacker);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060170B0 RID: 94384 RVA: 0x00632DD0 File Offset: 0x00630FD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetHeroAttackSkillInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			MoveType targetMoveType;
			LuaObject.checkEnum<MoveType>(l, 2, out targetMoveType);
			int distance;
			LuaObject.checkType(l, 3, out distance);
			ConfigDataSkillInfo heroAttackSkillInfo = battleActor.GetHeroAttackSkillInfo(targetMoveType, distance);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroAttackSkillInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060170B1 RID: 94385 RVA: 0x00632E40 File Offset: 0x00631040
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetSoldierAttackSkillInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			MoveType targetMoveType;
			LuaObject.checkEnum<MoveType>(l, 2, out targetMoveType);
			int distance;
			LuaObject.checkType(l, 3, out distance);
			ConfigDataSkillInfo soldierAttackSkillInfo = battleActor.GetSoldierAttackSkillInfo(targetMoveType, distance);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, soldierAttackSkillInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060170B2 RID: 94386 RVA: 0x00632EB0 File Offset: 0x006310B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ComputeMoveType_s(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobInfo heroJobInfo;
			LuaObject.checkType<ConfigDataJobInfo>(l, 1, out heroJobInfo);
			ConfigDataSoldierInfo soldierInfo;
			LuaObject.checkType<ConfigDataSoldierInfo>(l, 2, out soldierInfo);
			MoveType e = BattleActor.ComputeMoveType(heroJobInfo, soldierInfo);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)e);
			result = 2;
		}
		catch (Exception e2)
		{
			result = LuaObject.error(l, e2);
		}
		return result;
	}

	// Token: 0x060170B3 RID: 94387 RVA: 0x00632F10 File Offset: 0x00631110
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ComputeDefaultMoveType_s(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroInfo heroInfo;
			LuaObject.checkType<ConfigDataHeroInfo>(l, 1, out heroInfo);
			MoveType e = BattleActor.ComputeDefaultMoveType(heroInfo);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)e);
			result = 2;
		}
		catch (Exception e2)
		{
			result = LuaObject.error(l, e2);
		}
		return result;
	}

	// Token: 0x060170B4 RID: 94388 RVA: 0x00632F64 File Offset: 0x00631164
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SelectMinHPPercentActor_s(IntPtr l)
	{
		int result;
		try
		{
			List<BattleActor> actors;
			LuaObject.checkType<List<BattleActor>>(l, 1, out actors);
			BattleActor o = BattleActor.SelectMinHPPercentActor(actors);
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

	// Token: 0x060170B5 RID: 94389 RVA: 0x00632FB8 File Offset: 0x006311B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FindActorsAlive_s(IntPtr l)
	{
		int result;
		try
		{
			List<BattleActor> actors;
			LuaObject.checkType<List<BattleActor>>(l, 1, out actors);
			List<BattleActor> o = BattleActor.FindActorsAlive(actors);
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

	// Token: 0x060170B6 RID: 94390 RVA: 0x0063300C File Offset: 0x0063120C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ComputeBattleProperties(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			BattlePropertyModifier pm;
			LuaObject.checkType<BattlePropertyModifier>(l, 2, out pm);
			battleActor.m_luaExportHelper.ComputeBattleProperties(pm);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060170B7 RID: 94391 RVA: 0x00633068 File Offset: 0x00631268
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetPosition(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			GridPosition position;
			LuaObject.checkValueType<GridPosition>(l, 2, out position);
			battleActor.m_luaExportHelper.SetPosition(position);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060170B8 RID: 94392 RVA: 0x006330C4 File Offset: 0x006312C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int MoveTo(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			GridPosition p;
			LuaObject.checkValueType<GridPosition>(l, 2, out p);
			battleActor.m_luaExportHelper.MoveTo(p);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060170B9 RID: 94393 RVA: 0x00633120 File Offset: 0x00631320
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ClearMapActor(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			battleActor.m_luaExportHelper.ClearMapActor();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060170BA RID: 94394 RVA: 0x00633174 File Offset: 0x00631374
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PostActionTerrainDamage(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			battleActor.m_luaExportHelper.PostActionTerrainDamage();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060170BB RID: 94395 RVA: 0x006331C8 File Offset: 0x006313C8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ShouldLog(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			bool b = battleActor.m_luaExportHelper.ShouldLog();
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

	// Token: 0x060170BC RID: 94396 RVA: 0x00633224 File Offset: 0x00631424
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int AddExecutedCommandType(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			BattleCommandType cmdType;
			LuaObject.checkEnum<BattleCommandType>(l, 2, out cmdType);
			battleActor.m_luaExportHelper.AddExecutedCommandType(cmdType);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060170BD RID: 94397 RVA: 0x00633280 File Offset: 0x00631480
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsExecutedCommandType(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			BattleCommandType cmdType;
			LuaObject.checkEnum<BattleCommandType>(l, 2, out cmdType);
			bool b = battleActor.m_luaExportHelper.IsExecutedCommandType(cmdType);
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

	// Token: 0x060170BE RID: 94398 RVA: 0x006332E8 File Offset: 0x006314E8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int FindMoveAndAttackRegion(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			int distance;
			LuaObject.checkType(l, 2, out distance);
			int shape;
			LuaObject.checkType(l, 3, out shape);
			battleActor.m_luaExportHelper.FindMoveAndAttackRegion(distance, shape);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060170BF RID: 94399 RVA: 0x00633354 File Offset: 0x00631554
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int FindRandomEmptyPosition(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			int attackDistance;
			LuaObject.checkType(l, 2, out attackDistance);
			int shape;
			LuaObject.checkType(l, 3, out shape);
			GridPosition gridPosition;
			LuaObject.checkValueType<GridPosition>(l, 4, out gridPosition);
			bool b = battleActor.m_luaExportHelper.FindRandomEmptyPosition(attackDistance, shape, ref gridPosition);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			LuaObject.pushValue(l, gridPosition);
			result = 3;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060170C0 RID: 94400 RVA: 0x006333E4 File Offset: 0x006315E4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int FindAttackPosition(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			int attackDistance;
			LuaObject.checkType(l, 2, out attackDistance);
			int shape;
			LuaObject.checkType(l, 3, out shape);
			GridPosition targetPos;
			LuaObject.checkValueType<GridPosition>(l, 4, out targetPos);
			bool checkMoveRegion;
			LuaObject.checkType(l, 5, out checkMoveRegion);
			bool farAway;
			LuaObject.checkType(l, 6, out farAway);
			GridPosition gridPosition = battleActor.m_luaExportHelper.FindAttackPosition(attackDistance, shape, targetPos, checkMoveRegion, farAway);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, gridPosition);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060170C1 RID: 94401 RVA: 0x00633484 File Offset: 0x00631684
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ComputeActorScoreBuff(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			BattleActor a;
			LuaObject.checkType<BattleActor>(l, 2, out a);
			int param;
			LuaObject.checkType(l, 3, out param);
			int i = battleActor.m_luaExportHelper.ComputeActorScoreBuff(a, param);
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

	// Token: 0x060170C2 RID: 94402 RVA: 0x006334F8 File Offset: 0x006316F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SelectNearestTarget(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			BattleTeam team;
			LuaObject.checkType<BattleTeam>(l, 2, out team);
			BattleActor o = battleActor.m_luaExportHelper.SelectNearestTarget(team);
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

	// Token: 0x060170C3 RID: 94403 RVA: 0x00633560 File Offset: 0x00631760
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetAIRandomNumber(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			RandomNumber airandomNumber = battleActor.m_luaExportHelper.GetAIRandomNumber();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, airandomNumber);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060170C4 RID: 94404 RVA: 0x006335BC File Offset: 0x006317BC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetSkillTargetTeam(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			ConfigDataSkillInfo skillInfo;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 2, out skillInfo);
			BattleTeam skillTargetTeam = battleActor.m_luaExportHelper.GetSkillTargetTeam(skillInfo);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, skillTargetTeam);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060170C5 RID: 94405 RVA: 0x00633624 File Offset: 0x00631824
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CanAttackOrUseSkill(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			bool b = battleActor.m_luaExportHelper.CanAttackOrUseSkill();
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

	// Token: 0x060170C6 RID: 94406 RVA: 0x00633680 File Offset: 0x00631880
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetBehaviorState(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			BattleActor.BehaviorState behaviorState;
			LuaObject.checkEnum<BattleActor.BehaviorState>(l, 2, out behaviorState);
			battleActor.m_luaExportHelper.SetBehaviorState(behaviorState);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060170C7 RID: 94407 RVA: 0x006336DC File Offset: 0x006318DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DoBehaviorChangeRules(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			battleActor.m_luaExportHelper.DoBehaviorChangeRules();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060170C8 RID: 94408 RVA: 0x00633730 File Offset: 0x00631930
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int FindFarthestPosition(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			List<GridPosition> positions;
			LuaObject.checkType<List<GridPosition>>(l, 2, out positions);
			GridPosition startPos;
			LuaObject.checkValueType<GridPosition>(l, 3, out startPos);
			GridPosition gridPosition = battleActor.m_luaExportHelper.FindFarthestPosition(positions, startPos);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, gridPosition);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060170C9 RID: 94409 RVA: 0x006337AC File Offset: 0x006319AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FindNearestPosition(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			List<GridPosition> positions;
			LuaObject.checkType<List<GridPosition>>(l, 2, out positions);
			GridPosition startPos;
			LuaObject.checkValueType<GridPosition>(l, 3, out startPos);
			GridPosition gridPosition = battleActor.m_luaExportHelper.FindNearestPosition(positions, startPos);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, gridPosition);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060170CA RID: 94410 RVA: 0x00633828 File Offset: 0x00631A28
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int FindNearestActor(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			List<BattleActor> actors;
			LuaObject.checkType<List<BattleActor>>(l, 2, out actors);
			GridPosition startPos;
			LuaObject.checkValueType<GridPosition>(l, 3, out startPos);
			BattleActor o = battleActor.m_luaExportHelper.FindNearestActor(actors, startPos);
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

	// Token: 0x060170CB RID: 94411 RVA: 0x0063389C File Offset: 0x00631A9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DoSelectTarget(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			SelectTarget st;
			LuaObject.checkEnum<SelectTarget>(l, 2, out st);
			ConfigDataBehavior.ParamData param;
			LuaObject.checkType<ConfigDataBehavior.ParamData>(l, 3, out param);
			BehaviorTarget o = battleActor.m_luaExportHelper.DoSelectTarget(st, param);
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

	// Token: 0x060170CC RID: 94412 RVA: 0x00633910 File Offset: 0x00631B10
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int FindActorsByIDFilter(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			List<BattleActor> actors;
			LuaObject.checkType<List<BattleActor>>(l, 2, out actors);
			int[] priorIDs;
			LuaObject.checkArray<int>(l, 3, out priorIDs);
			int[] excludeIDs;
			LuaObject.checkArray<int>(l, 4, out excludeIDs);
			List<BattleActor> o = battleActor.m_luaExportHelper.FindActorsByIDFilter(actors, priorIDs, excludeIDs);
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

	// Token: 0x060170CD RID: 94413 RVA: 0x00633994 File Offset: 0x00631B94
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SelectMoveTarget(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			battleActor.m_luaExportHelper.SelectMoveTarget();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060170CE RID: 94414 RVA: 0x006339E8 File Offset: 0x00631BE8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GenerateCommandOfMove(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			GridPosition target;
			LuaObject.checkValueType<GridPosition>(l, 2, out target);
			battleActor.m_luaExportHelper.GenerateCommandOfMove(target);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060170CF RID: 94415 RVA: 0x00633A44 File Offset: 0x00631C44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FindPositionToMoveToTarget(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			GridPosition target;
			LuaObject.checkValueType<GridPosition>(l, 2, out target);
			GridPosition gridPosition = battleActor.m_luaExportHelper.FindPositionToMoveToTarget(target);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, gridPosition);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060170D0 RID: 94416 RVA: 0x00633AB0 File Offset: 0x00631CB0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ComputeRestrictScore(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			BattleActor srcActor;
			LuaObject.checkType<BattleActor>(l, 2, out srcActor);
			BattleActor destActor;
			LuaObject.checkType<BattleActor>(l, 3, out destActor);
			int i = battleActor.m_luaExportHelper.ComputeRestrictScore(srcActor, destActor);
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

	// Token: 0x060170D1 RID: 94417 RVA: 0x00633B24 File Offset: 0x00631D24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetArmyRistrictScore(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			ArmyTag a;
			LuaObject.checkEnum<ArmyTag>(l, 2, out a);
			ArmyTag b;
			LuaObject.checkEnum<ArmyTag>(l, 3, out b);
			int armyRistrictScore = battleActor.m_luaExportHelper.GetArmyRistrictScore(a, b);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, armyRistrictScore);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060170D2 RID: 94418 RVA: 0x00633B98 File Offset: 0x00631D98
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int DefaultSelectDamageSkillTarget(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			List<BattleActor> actors;
			LuaObject.checkType<List<BattleActor>>(l, 2, out actors);
			BattleActor o = battleActor.m_luaExportHelper.DefaultSelectDamageSkillTarget(actors);
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

	// Token: 0x060170D3 RID: 94419 RVA: 0x00633C00 File Offset: 0x00631E00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsSelectRangeSkill(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			bool b = battleActor.m_luaExportHelper.IsSelectRangeSkill();
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

	// Token: 0x060170D4 RID: 94420 RVA: 0x00633C5C File Offset: 0x00631E5C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int FindActorsInGrids(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			List<BattleActor> actors;
			LuaObject.checkType<List<BattleActor>>(l, 2, out actors);
			List<GridPosition> grids;
			LuaObject.checkType<List<GridPosition>>(l, 3, out grids);
			List<BattleActor> o = battleActor.m_luaExportHelper.FindActorsInGrids(actors, grids);
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

	// Token: 0x060170D5 RID: 94421 RVA: 0x00633CD0 File Offset: 0x00631ED0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FindMaxAoeSkillCoverPosition(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			ConfigDataSkillInfo si;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 2, out si);
			List<GridPosition> asCenterPositions;
			LuaObject.checkType<List<GridPosition>>(l, 3, out asCenterPositions);
			List<BattleActor> beCoveredActors;
			LuaObject.checkType<List<BattleActor>>(l, 4, out beCoveredActors);
			ClassValue<int> maxCoverActorsCount;
			LuaObject.checkType<ClassValue<int>>(l, 5, out maxCoverActorsCount);
			GridPosition gridPosition = battleActor.m_luaExportHelper.FindMaxAoeSkillCoverPosition(si, asCenterPositions, beCoveredActors, maxCoverActorsCount);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, gridPosition);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060170D6 RID: 94422 RVA: 0x00633D64 File Offset: 0x00631F64
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int FindMaxAoeSkillCoverActor(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			ConfigDataSkillInfo si;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 2, out si);
			List<BattleActor> asCenterActors;
			LuaObject.checkType<List<BattleActor>>(l, 3, out asCenterActors);
			List<BattleActor> beCoveredActors;
			LuaObject.checkType<List<BattleActor>>(l, 4, out beCoveredActors);
			ClassValue<int> maxCoverActorsCount;
			LuaObject.checkType<ClassValue<int>>(l, 5, out maxCoverActorsCount);
			BattleActor o = battleActor.m_luaExportHelper.FindMaxAoeSkillCoverActor(si, asCenterActors, beCoveredActors, maxCoverActorsCount);
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

	// Token: 0x060170D7 RID: 94423 RVA: 0x00633DF4 File Offset: 0x00631FF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DefaultSelectAttackTarget(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			battleActor.m_luaExportHelper.DefaultSelectAttackTarget();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060170D8 RID: 94424 RVA: 0x00633E48 File Offset: 0x00632048
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int FindGridsLessEqualDistance(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			GridPosition startPos;
			LuaObject.checkValueType<GridPosition>(l, 2, out startPos);
			int dist;
			LuaObject.checkType(l, 3, out dist);
			List<GridPosition> o = battleActor.m_luaExportHelper.FindGridsLessEqualDistance(startPos, dist);
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

	// Token: 0x060170D9 RID: 94425 RVA: 0x00633EBC File Offset: 0x006320BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FindActorsLessEqualDistance(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			List<BattleActor> actors;
			LuaObject.checkType<List<BattleActor>>(l, 2, out actors);
			GridPosition startPos;
			LuaObject.checkValueType<GridPosition>(l, 3, out startPos);
			int dist;
			LuaObject.checkType(l, 4, out dist);
			List<BattleActor> o = battleActor.m_luaExportHelper.FindActorsLessEqualDistance(actors, startPos, dist);
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

	// Token: 0x060170DA RID: 94426 RVA: 0x00633F40 File Offset: 0x00632140
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int DefaultSelectHealSkillTarget(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			List<BattleActor> actors;
			LuaObject.checkType<List<BattleActor>>(l, 2, out actors);
			BattleActor o = battleActor.m_luaExportHelper.DefaultSelectHealSkillTarget(actors);
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

	// Token: 0x060170DB RID: 94427 RVA: 0x00633FA8 File Offset: 0x006321A8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int DefaultSelectBuffSkillTarget(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			List<BattleActor> actors;
			LuaObject.checkType<List<BattleActor>>(l, 2, out actors);
			ConfigDataSkillInfo skill;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 3, out skill);
			BattleActor o = battleActor.m_luaExportHelper.DefaultSelectBuffSkillTarget(actors, skill);
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

	// Token: 0x060170DC RID: 94428 RVA: 0x0063401C File Offset: 0x0063221C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SelectAttackTargetInSkillRange(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			battleActor.m_luaExportHelper.SelectAttackTargetInSkillRange();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060170DD RID: 94429 RVA: 0x00634070 File Offset: 0x00632270
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FindActorsWithBuffN(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			List<BattleActor> actors;
			LuaObject.checkType<List<BattleActor>>(l, 2, out actors);
			int buffID;
			LuaObject.checkType(l, 3, out buffID);
			List<BattleActor> o = battleActor.m_luaExportHelper.FindActorsWithBuffN(actors, buffID);
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

	// Token: 0x060170DE RID: 94430 RVA: 0x006340E4 File Offset: 0x006322E4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SelectAttackTarget(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			battleActor.m_luaExportHelper.SelectAttackTarget();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060170DF RID: 94431 RVA: 0x00634138 File Offset: 0x00632338
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SelectSkill(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			battleActor.m_luaExportHelper.SelectSkill();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060170E0 RID: 94432 RVA: 0x0063418C File Offset: 0x0063238C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SelectSkillDirectReachTarget(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			battleActor.m_luaExportHelper.SelectSkillDirectReachTarget();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060170E1 RID: 94433 RVA: 0x006341E0 File Offset: 0x006323E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DefaultSelectSkill(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			int[] includeSkillIDs;
			LuaObject.checkArray<int>(l, 2, out includeSkillIDs);
			int[] excludeSkillIDs;
			LuaObject.checkArray<int>(l, 3, out excludeSkillIDs);
			battleActor.m_luaExportHelper.DefaultSelectSkill(includeSkillIDs, excludeSkillIDs);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060170E2 RID: 94434 RVA: 0x0063424C File Offset: 0x0063244C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int FindActorsInCanNormalAttackAndTouchRange(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			List<BattleActor> destActors;
			LuaObject.checkType<List<BattleActor>>(l, 2, out destActors);
			List<BattleActor> srcActors;
			LuaObject.checkType<List<BattleActor>>(l, 3, out srcActors);
			List<BattleActor> o = battleActor.m_luaExportHelper.FindActorsInCanNormalAttackAndTouchRange(destActors, srcActors);
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

	// Token: 0x060170E3 RID: 94435 RVA: 0x006342C0 File Offset: 0x006324C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsSkillAGoodAISelection(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			ConfigDataSkillInfo si;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 2, out si);
			bool b = battleActor.m_luaExportHelper.IsSkillAGoodAISelection(si);
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

	// Token: 0x060170E4 RID: 94436 RVA: 0x00634328 File Offset: 0x00632528
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FindCastSkillPosition(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			ConfigDataSkillInfo si;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 2, out si);
			BehaviorTarget t;
			LuaObject.checkType<BehaviorTarget>(l, 3, out t);
			GridPosition gridPosition = battleActor.m_luaExportHelper.FindCastSkillPosition(si, t);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, gridPosition);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060170E5 RID: 94437 RVA: 0x006343A4 File Offset: 0x006325A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FindAttackPositions(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			int attackDistance;
			LuaObject.checkType(l, 2, out attackDistance);
			int shape;
			LuaObject.checkType(l, 3, out shape);
			GridPosition targetPos;
			LuaObject.checkValueType<GridPosition>(l, 4, out targetPos);
			List<GridPosition> positions;
			LuaObject.checkType<List<GridPosition>>(l, 5, out positions);
			battleActor.m_luaExportHelper.FindAttackPositions(attackDistance, shape, targetPos, positions);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060170E6 RID: 94438 RVA: 0x00634428 File Offset: 0x00632628
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GenerateCommandOfAttack(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			battleActor.m_luaExportHelper.GenerateCommandOfAttack();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060170E7 RID: 94439 RVA: 0x0063447C File Offset: 0x0063267C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DoBehaviorMove(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			battleActor.m_luaExportHelper.DoBehaviorMove();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060170E8 RID: 94440 RVA: 0x006344D0 File Offset: 0x006326D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsAttackTargetStillValid(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			bool b = battleActor.m_luaExportHelper.IsAttackTargetStillValid();
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

	// Token: 0x060170E9 RID: 94441 RVA: 0x0063452C File Offset: 0x0063272C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int DoBehaviorAttack(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			battleActor.m_luaExportHelper.DoBehaviorAttack();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060170EA RID: 94442 RVA: 0x00634580 File Offset: 0x00632780
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AICreateBattleCommand(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			BattleCommandType type;
			LuaObject.checkEnum<BattleCommandType>(l, 2, out type);
			BattleCommand o = battleActor.m_luaExportHelper.AICreateBattleCommand(type);
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

	// Token: 0x060170EB RID: 94443 RVA: 0x006345E8 File Offset: 0x006327E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SelectAttackRegionTarget(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			BattleTeam team;
			LuaObject.checkType<BattleTeam>(l, 2, out team);
			BattleActor.ComputeActorScoreFunc computeScore;
			LuaObject.checkDelegate<BattleActor.ComputeActorScoreFunc>(l, 3, out computeScore);
			int computeScoreParam;
			LuaObject.checkType(l, 4, out computeScoreParam);
			BattleActor o = battleActor.m_luaExportHelper.SelectAttackRegionTarget(team, computeScore, computeScoreParam);
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

	// Token: 0x060170EC RID: 94444 RVA: 0x0063466C File Offset: 0x0063286C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitializeBuffs(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			battleActor.m_luaExportHelper.InitializeBuffs();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060170ED RID: 94445 RVA: 0x006346C0 File Offset: 0x006328C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AttachPassiveSkillBuffs(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			ConfigDataSkillInfo skillInfo;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 2, out skillInfo);
			BuffSourceType sourceType;
			LuaObject.checkEnum<BuffSourceType>(l, 3, out sourceType);
			battleActor.m_luaExportHelper.AttachPassiveSkillBuffs(skillInfo, sourceType);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060170EE RID: 94446 RVA: 0x0063472C File Offset: 0x0063292C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RemoveBuff(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			BuffState bs;
			LuaObject.checkType<BuffState>(l, 2, out bs);
			bool b = battleActor.m_luaExportHelper.RemoveBuff(bs);
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

	// Token: 0x060170EF RID: 94447 RVA: 0x00634794 File Offset: 0x00632994
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FindBuff(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			int buffId;
			LuaObject.checkType(l, 2, out buffId);
			BattleActor applyer;
			LuaObject.checkType<BattleActor>(l, 3, out applyer);
			BuffState o = battleActor.m_luaExportHelper.FindBuff(buffId, applyer);
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

	// Token: 0x060170F0 RID: 94448 RVA: 0x00634808 File Offset: 0x00632A08
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int RemoveAllBuffs(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			battleActor.m_luaExportHelper.RemoveAllBuffs();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060170F1 RID: 94449 RVA: 0x0063485C File Offset: 0x00632A5C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int HasBuff(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			int buffId;
			LuaObject.checkType(l, 2, out buffId);
			bool b = battleActor.m_luaExportHelper.HasBuff(buffId);
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

	// Token: 0x060170F2 RID: 94450 RVA: 0x006348C4 File Offset: 0x00632AC4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CollectPropertyModifier(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			BattlePropertyModifier pm;
			LuaObject.checkType<BattlePropertyModifier>(l, 2, out pm);
			PropertyModifyType modifyType;
			LuaObject.checkEnum<PropertyModifyType>(l, 3, out modifyType);
			int value;
			LuaObject.checkType(l, 4, out value);
			bool collectStatic;
			LuaObject.checkType(l, 5, out collectStatic);
			bool collectDynamic;
			LuaObject.checkType(l, 6, out collectDynamic);
			battleActor.m_luaExportHelper.CollectPropertyModifier(pm, modifyType, value, collectStatic, collectDynamic);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060170F3 RID: 94451 RVA: 0x00634954 File Offset: 0x00632B54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CollectOtherActorBuffPropertyModifiersAndFightTags(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			BattlePropertyModifier pm;
			LuaObject.checkType<BattlePropertyModifier>(l, 2, out pm);
			uint o;
			LuaObject.checkType(l, 3, out o);
			battleActor.m_luaExportHelper.CollectOtherActorBuffPropertyModifiersAndFightTags(pm, ref o);
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

	// Token: 0x060170F4 RID: 94452 RVA: 0x006349C8 File Offset: 0x00632BC8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CollectBuffPropertyModifiersAndFightTagsInCombat(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			BattlePropertyModifier pm;
			LuaObject.checkType<BattlePropertyModifier>(l, 2, out pm);
			uint o;
			LuaObject.checkType(l, 3, out o);
			BattleActor target;
			LuaObject.checkType<BattleActor>(l, 4, out target);
			bool isAttacker;
			LuaObject.checkType(l, 5, out isAttacker);
			int distance;
			LuaObject.checkType(l, 6, out distance);
			battleActor.m_luaExportHelper.CollectBuffPropertyModifiersAndFightTagsInCombat(pm, ref o, target, isAttacker, distance);
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

	// Token: 0x060170F5 RID: 94453 RVA: 0x00634A60 File Offset: 0x00632C60
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int RemoveAuraAppliedBuffs(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			ConfigDataBuffInfo auraBuffInfo;
			LuaObject.checkType<ConfigDataBuffInfo>(l, 2, out auraBuffInfo);
			battleActor.m_luaExportHelper.RemoveAuraAppliedBuffs(auraBuffInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060170F6 RID: 94454 RVA: 0x00634ABC File Offset: 0x00632CBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RemovePackChildBuffs(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			BuffState packBuff;
			LuaObject.checkType<BuffState>(l, 2, out packBuff);
			battleActor.m_luaExportHelper.RemovePackChildBuffs(packBuff);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060170F7 RID: 94455 RVA: 0x00634B18 File Offset: 0x00632D18
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnBuffHit(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			BuffState buffState;
			LuaObject.checkType<BuffState>(l, 2, out buffState);
			int heroHpModify;
			LuaObject.checkType(l, 3, out heroHpModify);
			int soldierHpModify;
			LuaObject.checkType(l, 4, out soldierHpModify);
			DamageNumberType damageNumberType;
			LuaObject.checkEnum<DamageNumberType>(l, 5, out damageNumberType);
			battleActor.m_luaExportHelper.OnBuffHit(buffState, heroHpModify, soldierHpModify, damageNumberType);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060170F8 RID: 94456 RVA: 0x00634B9C File Offset: 0x00632D9C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int UpdateBuffTypes(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			battleActor.m_luaExportHelper.UpdateBuffTypes();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060170F9 RID: 94457 RVA: 0x00634BF0 File Offset: 0x00632DF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetBuffType(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			BuffType bt;
			LuaObject.checkEnum<BuffType>(l, 2, out bt);
			bool on;
			LuaObject.checkType(l, 3, out on);
			battleActor.m_luaExportHelper.SetBuffType(bt, on);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060170FA RID: 94458 RVA: 0x00634C5C File Offset: 0x00632E5C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsBuffHpConditionSatisfied(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
				ConfigDataBuffInfo buffInfo;
				LuaObject.checkType<ConfigDataBuffInfo>(l, 2, out buffInfo);
				bool b = battleActor.m_luaExportHelper.IsBuffHpConditionSatisfied(buffInfo);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b);
				result = 2;
			}
			else if (num == 4)
			{
				BattleActor battleActor2 = (BattleActor)LuaObject.checkSelf(l);
				int operatorType;
				LuaObject.checkType(l, 2, out operatorType);
				int value;
				LuaObject.checkType(l, 3, out value);
				int targetType;
				LuaObject.checkType(l, 4, out targetType);
				bool b2 = battleActor2.m_luaExportHelper.IsBuffHpConditionSatisfied(operatorType, value, targetType);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function IsBuffHpConditionSatisfied to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060170FB RID: 94459 RVA: 0x00634D4C File Offset: 0x00632F4C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsBuffEffectiveConditionSatisfied(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			ConfigDataBuffInfo buffInfo;
			LuaObject.checkType<ConfigDataBuffInfo>(l, 2, out buffInfo);
			bool b = battleActor.m_luaExportHelper.IsBuffEffectiveConditionSatisfied(buffInfo);
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

	// Token: 0x060170FC RID: 94460 RVA: 0x00634DB4 File Offset: 0x00632FB4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsBuffCombatConditionSatisfied(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(BattleActor), typeof(bool), typeof(bool), typeof(int), typeof(bool), typeof(List<int>)))
			{
				BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
				BattleActor target;
				LuaObject.checkType<BattleActor>(l, 2, out target);
				bool beforeCombat;
				LuaObject.checkType(l, 3, out beforeCombat);
				bool isAttacker;
				LuaObject.checkType(l, 4, out isAttacker);
				int distance;
				LuaObject.checkType(l, 5, out distance);
				bool isCritical;
				LuaObject.checkType(l, 6, out isCritical);
				List<int> paramList;
				LuaObject.checkType<List<int>>(l, 7, out paramList);
				bool b = battleActor.m_luaExportHelper.IsBuffCombatConditionSatisfied(target, beforeCombat, isAttacker, distance, isCritical, paramList);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(BattleActor), typeof(bool), typeof(int), typeof(int), typeof(int), typeof(int)))
			{
				BattleActor battleActor2 = (BattleActor)LuaObject.checkSelf(l);
				BattleActor target2;
				LuaObject.checkType<BattleActor>(l, 2, out target2);
				bool isAttacker2;
				LuaObject.checkType(l, 3, out isAttacker2);
				int distance2;
				LuaObject.checkType(l, 4, out distance2);
				int param;
				LuaObject.checkType(l, 5, out param);
				int param2;
				LuaObject.checkType(l, 6, out param2);
				int param3;
				LuaObject.checkType(l, 7, out param3);
				bool b2 = battleActor2.m_luaExportHelper.IsBuffCombatConditionSatisfied(target2, isAttacker2, distance2, param, param2, param3);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function IsBuffCombatConditionSatisfied to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060170FD RID: 94461 RVA: 0x00634F94 File Offset: 0x00633194
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ComputeNeighborAliveActorCount(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			int teamType;
			LuaObject.checkType(l, 2, out teamType);
			int distance;
			LuaObject.checkType(l, 3, out distance);
			int i = battleActor.m_luaExportHelper.ComputeNeighborAliveActorCount(teamType, distance);
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

	// Token: 0x060170FE RID: 94462 RVA: 0x00635008 File Offset: 0x00633208
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsBuffCooldown(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			BuffState bs;
			LuaObject.checkType<BuffState>(l, 2, out bs);
			bool b = battleActor.m_luaExportHelper.IsBuffCooldown(bs);
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

	// Token: 0x060170FF RID: 94463 RVA: 0x00635070 File Offset: 0x00633270
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartBuffCooldown(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			BuffState bs;
			LuaObject.checkType<BuffState>(l, 2, out bs);
			battleActor.m_luaExportHelper.StartBuffCooldown(bs);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017100 RID: 94464 RVA: 0x006350CC File Offset: 0x006332CC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ComputeBuffCount(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			int buffId;
			LuaObject.checkType(l, 2, out buffId);
			int i = battleActor.m_luaExportHelper.ComputeBuffCount(buffId);
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

	// Token: 0x06017101 RID: 94465 RVA: 0x00635134 File Offset: 0x00633334
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ComputeEnhanceOrDebuffCount(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			int enhanceDebuffType;
			LuaObject.checkType(l, 2, out enhanceDebuffType);
			int i = battleActor.m_luaExportHelper.ComputeEnhanceOrDebuffCount(enhanceDebuffType);
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

	// Token: 0x06017102 RID: 94466 RVA: 0x0063519C File Offset: 0x0063339C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsImmuneBuffSubType(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			int subType;
			LuaObject.checkType(l, 2, out subType);
			bool b = battleActor.m_luaExportHelper.IsImmuneBuffSubType(subType);
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

	// Token: 0x06017103 RID: 94467 RVA: 0x00635204 File Offset: 0x00633404
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ActionEndBuffEffect(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			battleActor.m_luaExportHelper.ActionEndBuffEffect();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017104 RID: 94468 RVA: 0x00635258 File Offset: 0x00633458
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateBuffTime(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			battleActor.m_luaExportHelper.UpdateBuffTime();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017105 RID: 94469 RVA: 0x006352AC File Offset: 0x006334AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ActionEndBuffHealOverTime(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			bool isDamage;
			LuaObject.checkType(l, 2, out isDamage);
			battleActor.m_luaExportHelper.ActionEndBuffHealOverTime(isDamage);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017106 RID: 94470 RVA: 0x00635308 File Offset: 0x00633508
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ActionEndBuffDamageOverTime(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			battleActor.m_luaExportHelper.ActionEndBuffDamageOverTime();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017107 RID: 94471 RVA: 0x0063535C File Offset: 0x0063355C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ActionEndAddBuff(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			battleActor.m_luaExportHelper.ActionEndAddBuff();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017108 RID: 94472 RVA: 0x006353B0 File Offset: 0x006335B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ActionEndAddBuffSuper(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			bool isKill;
			LuaObject.checkType(l, 2, out isKill);
			bool isCritical;
			LuaObject.checkType(l, 3, out isCritical);
			battleActor.m_luaExportHelper.ActionEndAddBuffSuper(isKill, isCritical);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017109 RID: 94473 RVA: 0x0063541C File Offset: 0x0063361C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ActionEndRemoveDebuff(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			battleActor.m_luaExportHelper.ActionEndRemoveDebuff();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601710A RID: 94474 RVA: 0x00635470 File Offset: 0x00633670
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ActionEndRemoveEnhanceBuff(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			bool isKill;
			LuaObject.checkType(l, 2, out isKill);
			bool isCritical;
			LuaObject.checkType(l, 3, out isCritical);
			bool isDamage;
			LuaObject.checkType(l, 4, out isDamage);
			battleActor.m_luaExportHelper.ActionEndRemoveEnhanceBuff(isKill, isCritical, isDamage);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601710B RID: 94475 RVA: 0x006354E8 File Offset: 0x006336E8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ActionEndBuffBattlefieldSkill(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			bool isKill;
			LuaObject.checkType(l, 2, out isKill);
			bool isCritical;
			LuaObject.checkType(l, 3, out isCritical);
			bool isDamage;
			LuaObject.checkType(l, 4, out isDamage);
			battleActor.m_luaExportHelper.ActionEndBuffBattlefieldSkill(isKill, isCritical, isDamage);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601710C RID: 94476 RVA: 0x00635560 File Offset: 0x00633760
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ActionEndBuffNewTurn(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			bool isKill;
			LuaObject.checkType(l, 2, out isKill);
			bool isCritical;
			LuaObject.checkType(l, 3, out isCritical);
			battleActor.m_luaExportHelper.ActionEndBuffNewTurn(isKill, isCritical);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601710D RID: 94477 RVA: 0x006355CC File Offset: 0x006337CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CanBuffGuard(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			BattleActor target;
			LuaObject.checkType<BattleActor>(l, 2, out target);
			ConfigDataSkillInfo skillInfo;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 3, out skillInfo);
			bool b = battleActor.m_luaExportHelper.CanBuffGuard(target, skillInfo);
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

	// Token: 0x0601710E RID: 94478 RVA: 0x00635640 File Offset: 0x00633840
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsSkillUseable(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			int skillIndex;
			LuaObject.checkType(l, 2, out skillIndex);
			bool b = battleActor.m_luaExportHelper.IsSkillUseable(skillIndex);
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

	// Token: 0x0601710F RID: 94479 RVA: 0x006356A8 File Offset: 0x006338A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FindBattlefieldSkillApplyTargets(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			ConfigDataSkillInfo skillInfo;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 2, out skillInfo);
			GridPosition targetPos;
			LuaObject.checkValueType<GridPosition>(l, 3, out targetPos);
			List<BattleActor> targetActors;
			LuaObject.checkType<List<BattleActor>>(l, 4, out targetActors);
			battleActor.m_luaExportHelper.FindBattlefieldSkillApplyTargets(skillInfo, targetPos, targetActors);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017110 RID: 94480 RVA: 0x00635720 File Offset: 0x00633920
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ExecuteBattlefieldSkill(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			ConfigDataSkillInfo skillInfo;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 2, out skillInfo);
			GridPosition p;
			LuaObject.checkValueType<GridPosition>(l, 3, out p);
			GridPosition p2;
			LuaObject.checkValueType<GridPosition>(l, 4, out p2);
			bool b = battleActor.m_luaExportHelper.ExecuteBattlefieldSkill(skillInfo, p, p2);
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

	// Token: 0x06017111 RID: 94481 RVA: 0x006357A4 File Offset: 0x006339A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SkillAttack(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			ConfigDataSkillInfo skillInfo;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 2, out skillInfo);
			BattleActor target;
			LuaObject.checkType<BattleActor>(l, 3, out target);
			bool b = battleActor.m_luaExportHelper.SkillAttack(skillInfo, target);
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

	// Token: 0x06017112 RID: 94482 RVA: 0x00635818 File Offset: 0x00633A18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SkillSummon(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			ConfigDataSkillInfo skillInfo;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 2, out skillInfo);
			GridPosition p;
			LuaObject.checkValueType<GridPosition>(l, 3, out p);
			bool b = battleActor.m_luaExportHelper.SkillSummon(skillInfo, p);
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

	// Token: 0x06017113 RID: 94483 RVA: 0x0063588C File Offset: 0x00633A8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SkillTeleport(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			ConfigDataSkillInfo skillInfo;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 2, out skillInfo);
			BattleActor target;
			LuaObject.checkType<BattleActor>(l, 3, out target);
			GridPosition teleportPos;
			LuaObject.checkValueType<GridPosition>(l, 4, out teleportPos);
			bool b = battleActor.m_luaExportHelper.SkillTeleport(skillInfo, target, teleportPos);
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

	// Token: 0x06017114 RID: 94484 RVA: 0x00635910 File Offset: 0x00633B10
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int AttackBy(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			BattleActor attacker;
			LuaObject.checkType<BattleActor>(l, 2, out attacker);
			ConfigDataSkillInfo skillInfo;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 3, out skillInfo);
			battleActor.m_luaExportHelper.AttackBy(attacker, skillInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017115 RID: 94485 RVA: 0x0063597C File Offset: 0x00633B7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SkillAttackEnd(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			ConfigDataSkillInfo skillInfo;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 2, out skillInfo);
			List<BattleActor> targets;
			LuaObject.checkType<List<BattleActor>>(l, 3, out targets);
			battleActor.m_luaExportHelper.SkillAttackEnd(skillInfo, targets);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017116 RID: 94486 RVA: 0x006359E8 File Offset: 0x00633BE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int TeleportBy(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			BattleActor attacker;
			LuaObject.checkType<BattleActor>(l, 2, out attacker);
			ConfigDataSkillInfo skillInfo;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 3, out skillInfo);
			GridPosition p;
			LuaObject.checkValueType<GridPosition>(l, 4, out p);
			battleActor.m_luaExportHelper.TeleportBy(attacker, skillInfo, p);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017117 RID: 94487 RVA: 0x00635A60 File Offset: 0x00633C60
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SummonBy(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			BattleActor attacker;
			LuaObject.checkType<BattleActor>(l, 2, out attacker);
			ConfigDataSkillInfo skillInfo;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 3, out skillInfo);
			GridPosition p;
			LuaObject.checkValueType<GridPosition>(l, 4, out p);
			battleActor.m_luaExportHelper.SummonBy(attacker, skillInfo, p);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017118 RID: 94488 RVA: 0x00635AD8 File Offset: 0x00633CD8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_Dispose(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			battleActor.m_luaExportHelper.__callBase_Dispose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017119 RID: 94489 RVA: 0x00635B2C File Offset: 0x00633D2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Tick(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			battleActor.m_luaExportHelper.__callBase_Tick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601711A RID: 94490 RVA: 0x00635B80 File Offset: 0x00633D80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_TickGraphic(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			float dt;
			LuaObject.checkType(l, 2, out dt);
			battleActor.m_luaExportHelper.__callBase_TickGraphic(dt);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601711B RID: 94491 RVA: 0x00635BDC File Offset: 0x00633DDC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_Draw(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			battleActor.m_luaExportHelper.__callBase_Draw();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601711C RID: 94492 RVA: 0x00635C30 File Offset: 0x00633E30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Pause(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			bool pause;
			LuaObject.checkType(l, 2, out pause);
			battleActor.m_luaExportHelper.__callBase_Pause(pause);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601711D RID: 94493 RVA: 0x00635C8C File Offset: 0x00633E8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_DoPause(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			bool pause;
			LuaObject.checkType(l, 2, out pause);
			battleActor.m_luaExportHelper.__callBase_DoPause(pause);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601711E RID: 94494 RVA: 0x00635CE8 File Offset: 0x00633EE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_DeleteMe(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			battleActor.m_luaExportHelper.__callBase_DeleteMe();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601711F RID: 94495 RVA: 0x00635D3C File Offset: 0x00633F3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ComputeActorScoreDamage_s(IntPtr l)
	{
		int result;
		try
		{
			BattleActor a;
			LuaObject.checkType<BattleActor>(l, 1, out a);
			int param;
			LuaObject.checkType(l, 2, out param);
			int i = BattleActor.LuaExportHelper.ComputeActorScoreDamage(a, param);
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

	// Token: 0x06017120 RID: 94496 RVA: 0x00635D9C File Offset: 0x00633F9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ComputeActorScoreHeal_s(IntPtr l)
	{
		int result;
		try
		{
			BattleActor a;
			LuaObject.checkType<BattleActor>(l, 1, out a);
			int param;
			LuaObject.checkType(l, 2, out param);
			int i = BattleActor.LuaExportHelper.ComputeActorScoreHeal(a, param);
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

	// Token: 0x06017121 RID: 94497 RVA: 0x00635DFC File Offset: 0x00633FFC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Contains_s(IntPtr l)
	{
		int result;
		try
		{
			int[] target;
			LuaObject.checkArray<int>(l, 1, out target);
			int nr;
			LuaObject.checkType(l, 2, out nr);
			bool b = BattleActor.LuaExportHelper.Contains(target, nr);
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

	// Token: 0x06017122 RID: 94498 RVA: 0x00635E5C File Offset: 0x0063405C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int HasInt_s(IntPtr l)
	{
		int result;
		try
		{
			int value;
			LuaObject.checkType(l, 1, out value);
			int[] arr;
			LuaObject.checkArray<int>(l, 2, out arr);
			bool b = BattleActor.LuaExportHelper.HasInt(value, arr);
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

	// Token: 0x06017123 RID: 94499 RVA: 0x00635EBC File Offset: 0x006340BC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CompareBuffOrder_s(IntPtr l)
	{
		int result;
		try
		{
			BuffState b;
			LuaObject.checkType<BuffState>(l, 1, out b);
			BuffState b2;
			LuaObject.checkType<BuffState>(l, 2, out b2);
			int i = BattleActor.LuaExportHelper.CompareBuffOrder(b, b2);
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

	// Token: 0x06017124 RID: 94500 RVA: 0x00635F1C File Offset: 0x0063411C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CompareHealActor_s(IntPtr l)
	{
		int result;
		try
		{
			BattleActor a;
			LuaObject.checkType<BattleActor>(l, 1, out a);
			BattleActor a2;
			LuaObject.checkType<BattleActor>(l, 2, out a2);
			int i = BattleActor.LuaExportHelper.CompareHealActor(a, a2);
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

	// Token: 0x06017125 RID: 94501 RVA: 0x00635F7C File Offset: 0x0063417C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_team(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActor.m_luaExportHelper.m_team);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017126 RID: 94502 RVA: 0x00635FD4 File Offset: 0x006341D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_team(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			BattleTeam team;
			LuaObject.checkType<BattleTeam>(l, 2, out team);
			battleActor.m_luaExportHelper.m_team = team;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017127 RID: 94503 RVA: 0x00636030 File Offset: 0x00634230
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_position(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActor.m_luaExportHelper.m_position);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017128 RID: 94504 RVA: 0x0063608C File Offset: 0x0063428C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_position(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			GridPosition position;
			LuaObject.checkValueType<GridPosition>(l, 2, out position);
			battleActor.m_luaExportHelper.m_position = position;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017129 RID: 94505 RVA: 0x006360E8 File Offset: 0x006342E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_direction(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActor.m_luaExportHelper.m_direction);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601712A RID: 94506 RVA: 0x00636140 File Offset: 0x00634340
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_direction(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			int direction;
			LuaObject.checkType(l, 2, out direction);
			battleActor.m_luaExportHelper.m_direction = direction;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601712B RID: 94507 RVA: 0x0063619C File Offset: 0x0063439C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_initPosition(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActor.m_luaExportHelper.m_initPosition);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601712C RID: 94508 RVA: 0x006361F8 File Offset: 0x006343F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_initPosition(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			GridPosition initPosition;
			LuaObject.checkValueType<GridPosition>(l, 2, out initPosition);
			battleActor.m_luaExportHelper.m_initPosition = initPosition;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601712D RID: 94509 RVA: 0x00636254 File Offset: 0x00634454
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_beforeGuardPosition(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActor.m_luaExportHelper.m_beforeGuardPosition);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601712E RID: 94510 RVA: 0x006362B0 File Offset: 0x006344B0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_beforeGuardPosition(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			GridPosition beforeGuardPosition;
			LuaObject.checkValueType<GridPosition>(l, 2, out beforeGuardPosition);
			battleActor.m_luaExportHelper.m_beforeGuardPosition = beforeGuardPosition;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601712F RID: 94511 RVA: 0x0063630C File Offset: 0x0063450C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_heroBattleProperty(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActor.m_luaExportHelper.m_heroBattleProperty);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017130 RID: 94512 RVA: 0x00636364 File Offset: 0x00634564
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_heroBattleProperty(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			BattleProperty heroBattleProperty;
			LuaObject.checkType<BattleProperty>(l, 2, out heroBattleProperty);
			battleActor.m_luaExportHelper.m_heroBattleProperty = heroBattleProperty;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017131 RID: 94513 RVA: 0x006363C0 File Offset: 0x006345C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierBattleProperty(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActor.m_luaExportHelper.m_soldierBattleProperty);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017132 RID: 94514 RVA: 0x00636418 File Offset: 0x00634618
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierBattleProperty(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			BattleProperty soldierBattleProperty;
			LuaObject.checkType<BattleProperty>(l, 2, out soldierBattleProperty);
			battleActor.m_luaExportHelper.m_soldierBattleProperty = soldierBattleProperty;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017133 RID: 94515 RVA: 0x00636474 File Offset: 0x00634674
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_heroHealthPoint(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActor.m_luaExportHelper.m_heroHealthPoint);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017134 RID: 94516 RVA: 0x006364CC File Offset: 0x006346CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroHealthPoint(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			int heroHealthPoint;
			LuaObject.checkType(l, 2, out heroHealthPoint);
			battleActor.m_luaExportHelper.m_heroHealthPoint = heroHealthPoint;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017135 RID: 94517 RVA: 0x00636528 File Offset: 0x00634728
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierTotalHealthPoint(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActor.m_luaExportHelper.m_soldierTotalHealthPoint);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017136 RID: 94518 RVA: 0x00636580 File Offset: 0x00634780
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierTotalHealthPoint(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			int soldierTotalHealthPoint;
			LuaObject.checkType(l, 2, out soldierTotalHealthPoint);
			battleActor.m_luaExportHelper.m_soldierTotalHealthPoint = soldierTotalHealthPoint;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017137 RID: 94519 RVA: 0x006365DC File Offset: 0x006347DC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_soldierSingleHealthPointMax(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActor.m_luaExportHelper.m_soldierSingleHealthPointMax);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017138 RID: 94520 RVA: 0x00636634 File Offset: 0x00634834
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierSingleHealthPointMax(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			int soldierSingleHealthPointMax;
			LuaObject.checkType(l, 2, out soldierSingleHealthPointMax);
			battleActor.m_luaExportHelper.m_soldierSingleHealthPointMax = soldierSingleHealthPointMax;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017139 RID: 94521 RVA: 0x00636690 File Offset: 0x00634890
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_initSoldierCount(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActor.m_luaExportHelper.m_initSoldierCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601713A RID: 94522 RVA: 0x006366E8 File Offset: 0x006348E8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_initSoldierCount(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			int initSoldierCount;
			LuaObject.checkType(l, 2, out initSoldierCount);
			battleActor.m_luaExportHelper.m_initSoldierCount = initSoldierCount;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601713B RID: 94523 RVA: 0x00636744 File Offset: 0x00634944
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroLevel(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActor.m_luaExportHelper.m_heroLevel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601713C RID: 94524 RVA: 0x0063679C File Offset: 0x0063499C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroLevel(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			int heroLevel;
			LuaObject.checkType(l, 2, out heroLevel);
			battleActor.m_luaExportHelper.m_heroLevel = heroLevel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601713D RID: 94525 RVA: 0x006367F8 File Offset: 0x006349F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroStar(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActor.m_luaExportHelper.m_heroStar);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601713E RID: 94526 RVA: 0x00636850 File Offset: 0x00634A50
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_heroStar(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			int heroStar;
			LuaObject.checkType(l, 2, out heroStar);
			battleActor.m_luaExportHelper.m_heroStar = heroStar;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601713F RID: 94527 RVA: 0x006368AC File Offset: 0x00634AAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_jobLevel(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActor.m_luaExportHelper.m_jobLevel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017140 RID: 94528 RVA: 0x00636904 File Offset: 0x00634B04
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_jobLevel(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			int jobLevel;
			LuaObject.checkType(l, 2, out jobLevel);
			battleActor.m_luaExportHelper.m_jobLevel = jobLevel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017141 RID: 94529 RVA: 0x00636960 File Offset: 0x00634B60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_masterJobInfos(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActor.m_luaExportHelper.m_masterJobInfos);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017142 RID: 94530 RVA: 0x006369B8 File Offset: 0x00634BB8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_masterJobInfos(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			ConfigDataJobInfo[] masterJobInfos;
			LuaObject.checkArray<ConfigDataJobInfo>(l, 2, out masterJobInfos);
			battleActor.m_luaExportHelper.m_masterJobInfos = masterJobInfos;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017143 RID: 94531 RVA: 0x00636A14 File Offset: 0x00634C14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_equipments(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActor.m_luaExportHelper.m_equipments);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017144 RID: 94532 RVA: 0x00636A6C File Offset: 0x00634C6C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_equipments(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			BattleActorEquipment[] equipments;
			LuaObject.checkArray<BattleActorEquipment>(l, 2, out equipments);
			battleActor.m_luaExportHelper.m_equipments = equipments;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017145 RID: 94533 RVA: 0x00636AC8 File Offset: 0x00634CC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_resonanceSkillInfos(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActor.m_luaExportHelper.m_resonanceSkillInfos);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017146 RID: 94534 RVA: 0x00636B20 File Offset: 0x00634D20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_resonanceSkillInfos(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			ConfigDataSkillInfo[] resonanceSkillInfos;
			LuaObject.checkArray<ConfigDataSkillInfo>(l, 2, out resonanceSkillInfos);
			battleActor.m_luaExportHelper.m_resonanceSkillInfos = resonanceSkillInfos;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017147 RID: 94535 RVA: 0x00636B7C File Offset: 0x00634D7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_fetterSkillInfos(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActor.m_luaExportHelper.m_fetterSkillInfos);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017148 RID: 94536 RVA: 0x00636BD4 File Offset: 0x00634DD4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_fetterSkillInfos(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			ConfigDataSkillInfo[] fetterSkillInfos;
			LuaObject.checkArray<ConfigDataSkillInfo>(l, 2, out fetterSkillInfos);
			battleActor.m_luaExportHelper.m_fetterSkillInfos = fetterSkillInfos;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017149 RID: 94537 RVA: 0x00636C30 File Offset: 0x00634E30
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_actionValue(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActor.m_luaExportHelper.m_actionValue);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601714A RID: 94538 RVA: 0x00636C88 File Offset: 0x00634E88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_actionValue(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			int actionValue;
			LuaObject.checkType(l, 2, out actionValue);
			battleActor.m_luaExportHelper.m_actionValue = actionValue;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601714B RID: 94539 RVA: 0x00636CE4 File Offset: 0x00634EE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_moveType(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)battleActor.m_luaExportHelper.m_moveType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601714C RID: 94540 RVA: 0x00636D3C File Offset: 0x00634F3C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_moveType(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			MoveType moveType;
			LuaObject.checkEnum<MoveType>(l, 2, out moveType);
			battleActor.m_luaExportHelper.m_moveType = moveType;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601714D RID: 94541 RVA: 0x00636D98 File Offset: 0x00634F98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isActionFinished(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActor.m_luaExportHelper.m_isActionFinished);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601714E RID: 94542 RVA: 0x00636DF0 File Offset: 0x00634FF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isActionFinished(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			bool isActionFinished;
			LuaObject.checkType(l, 2, out isActionFinished);
			battleActor.m_luaExportHelper.m_isActionFinished = isActionFinished;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601714F RID: 94543 RVA: 0x00636E4C File Offset: 0x0063504C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_hasExtraAction(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActor.m_luaExportHelper.m_hasExtraAction);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017150 RID: 94544 RVA: 0x00636EA4 File Offset: 0x006350A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_hasExtraAction(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			bool hasExtraAction;
			LuaObject.checkType(l, 2, out hasExtraAction);
			battleActor.m_luaExportHelper.m_hasExtraAction = hasExtraAction;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017151 RID: 94545 RVA: 0x00636F00 File Offset: 0x00635100
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_hasExtraActionCount(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActor.m_luaExportHelper.m_hasExtraActionCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017152 RID: 94546 RVA: 0x00636F58 File Offset: 0x00635158
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_hasExtraActionCount(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			int hasExtraActionCount;
			LuaObject.checkType(l, 2, out hasExtraActionCount);
			battleActor.m_luaExportHelper.m_hasExtraActionCount = hasExtraActionCount;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017153 RID: 94547 RVA: 0x00636FB4 File Offset: 0x006351B4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_hasExtraMovePoint(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActor.m_luaExportHelper.m_hasExtraMovePoint);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017154 RID: 94548 RVA: 0x0063700C File Offset: 0x0063520C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_hasExtraMovePoint(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			int hasExtraMovePoint;
			LuaObject.checkType(l, 2, out hasExtraMovePoint);
			battleActor.m_luaExportHelper.m_hasExtraMovePoint = hasExtraMovePoint;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017155 RID: 94549 RVA: 0x00637068 File Offset: 0x00635268
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isExtraAction(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActor.m_luaExportHelper.m_isExtraAction);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017156 RID: 94550 RVA: 0x006370C0 File Offset: 0x006352C0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_isExtraAction(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			bool isExtraAction;
			LuaObject.checkType(l, 2, out isExtraAction);
			battleActor.m_luaExportHelper.m_isExtraAction = isExtraAction;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017157 RID: 94551 RVA: 0x0063711C File Offset: 0x0063531C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_extraActionMovePoint(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActor.m_luaExportHelper.m_extraActionMovePoint);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017158 RID: 94552 RVA: 0x00637174 File Offset: 0x00635374
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_extraActionMovePoint(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			int extraActionMovePoint;
			LuaObject.checkType(l, 2, out extraActionMovePoint);
			battleActor.m_luaExportHelper.m_extraActionMovePoint = extraActionMovePoint;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017159 RID: 94553 RVA: 0x006371D0 File Offset: 0x006353D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isVisible(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActor.m_luaExportHelper.m_isVisible);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601715A RID: 94554 RVA: 0x00637228 File Offset: 0x00635428
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isVisible(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			bool isVisible;
			LuaObject.checkType(l, 2, out isVisible);
			battleActor.m_luaExportHelper.m_isVisible = isVisible;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601715B RID: 94555 RVA: 0x00637284 File Offset: 0x00635484
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_isDie(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActor.m_luaExportHelper.m_isDie);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601715C RID: 94556 RVA: 0x006372DC File Offset: 0x006354DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isDie(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			bool isDie;
			LuaObject.checkType(l, 2, out isDie);
			battleActor.m_luaExportHelper.m_isDie = isDie;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601715D RID: 94557 RVA: 0x00637338 File Offset: 0x00635538
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_isRetreat(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActor.m_luaExportHelper.m_isRetreat);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601715E RID: 94558 RVA: 0x00637390 File Offset: 0x00635590
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isRetreat(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			bool isRetreat;
			LuaObject.checkType(l, 2, out isRetreat);
			battleActor.m_luaExportHelper.m_isRetreat = isRetreat;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601715F RID: 94559 RVA: 0x006373EC File Offset: 0x006355EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_skillStates(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActor.m_luaExportHelper.m_skillStates);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017160 RID: 94560 RVA: 0x00637444 File Offset: 0x00635644
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_skillStates(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			List<BattleSkillState> skillStates;
			LuaObject.checkType<List<BattleSkillState>>(l, 2, out skillStates);
			battleActor.m_luaExportHelper.m_skillStates = skillStates;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017161 RID: 94561 RVA: 0x006374A0 File Offset: 0x006356A0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_buffStates(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActor.m_luaExportHelper.m_buffStates);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017162 RID: 94562 RVA: 0x006374F8 File Offset: 0x006356F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_buffStates(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			List<BuffState> buffStates;
			LuaObject.checkType<List<BuffState>>(l, 2, out buffStates);
			battleActor.m_luaExportHelper.m_buffStates = buffStates;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017163 RID: 94563 RVA: 0x00637554 File Offset: 0x00635754
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_buffIdCounter(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActor.m_luaExportHelper.m_buffIdCounter);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017164 RID: 94564 RVA: 0x006375AC File Offset: 0x006357AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_buffIdCounter(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			int buffIdCounter;
			LuaObject.checkType(l, 2, out buffIdCounter);
			battleActor.m_luaExportHelper.m_buffIdCounter = buffIdCounter;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017165 RID: 94565 RVA: 0x00637608 File Offset: 0x00635808
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_buffTypes(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActor.m_luaExportHelper.m_buffTypes);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017166 RID: 94566 RVA: 0x00637660 File Offset: 0x00635860
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_buffTypes(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			ulong buffTypes;
			LuaObject.checkType(l, 2, out buffTypes);
			battleActor.m_luaExportHelper.m_buffTypes = buffTypes;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017167 RID: 94567 RVA: 0x006376BC File Offset: 0x006358BC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_fightTags(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActor.m_luaExportHelper.m_fightTags);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017168 RID: 94568 RVA: 0x00637714 File Offset: 0x00635914
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_fightTags(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			uint fightTags;
			LuaObject.checkType(l, 2, out fightTags);
			battleActor.m_luaExportHelper.m_fightTags = fightTags;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017169 RID: 94569 RVA: 0x00637770 File Offset: 0x00635970
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_summoner(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActor.m_luaExportHelper.m_summoner);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601716A RID: 94570 RVA: 0x006377C8 File Offset: 0x006359C8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_summoner(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			BattleActor summoner;
			LuaObject.checkType<BattleActor>(l, 2, out summoner);
			battleActor.m_luaExportHelper.m_summoner = summoner;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601716B RID: 94571 RVA: 0x00637824 File Offset: 0x00635A24
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_killerActor(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActor.m_luaExportHelper.m_killerActor);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601716C RID: 94572 RVA: 0x0063787C File Offset: 0x00635A7C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_killerActor(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			BattleActor killerActor;
			LuaObject.checkType<BattleActor>(l, 2, out killerActor);
			battleActor.m_luaExportHelper.m_killerActor = killerActor;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601716D RID: 94573 RVA: 0x006378D8 File Offset: 0x00635AD8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_isNpc(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActor.m_luaExportHelper.m_isNpc);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601716E RID: 94574 RVA: 0x00637930 File Offset: 0x00635B30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isNpc(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			bool isNpc;
			LuaObject.checkType(l, 2, out isNpc);
			battleActor.m_luaExportHelper.m_isNpc = isNpc;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601716F RID: 94575 RVA: 0x0063798C File Offset: 0x00635B8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isPlayerNpc(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActor.m_luaExportHelper.m_isPlayerNpc);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017170 RID: 94576 RVA: 0x006379E4 File Offset: 0x00635BE4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_isPlayerNpc(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			bool isPlayerNpc;
			LuaObject.checkType(l, 2, out isPlayerNpc);
			battleActor.m_luaExportHelper.m_isPlayerNpc = isPlayerNpc;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017171 RID: 94577 RVA: 0x00637A40 File Offset: 0x00635C40
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_sourceType(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)battleActor.m_luaExportHelper.m_sourceType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017172 RID: 94578 RVA: 0x00637A98 File Offset: 0x00635C98
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_sourceType(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			BattleActorSourceType sourceType;
			LuaObject.checkEnum<BattleActorSourceType>(l, 2, out sourceType);
			battleActor.m_luaExportHelper.m_sourceType = sourceType;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017173 RID: 94579 RVA: 0x00637AF4 File Offset: 0x00635CF4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_heroInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActor.m_luaExportHelper.m_heroInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017174 RID: 94580 RVA: 0x00637B4C File Offset: 0x00635D4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			ConfigDataHeroInfo heroInfo;
			LuaObject.checkType<ConfigDataHeroInfo>(l, 2, out heroInfo);
			battleActor.m_luaExportHelper.m_heroInfo = heroInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017175 RID: 94581 RVA: 0x00637BA8 File Offset: 0x00635DA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_jobConnectionInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActor.m_luaExportHelper.m_jobConnectionInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017176 RID: 94582 RVA: 0x00637C00 File Offset: 0x00635E00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_jobConnectionInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			ConfigDataJobConnectionInfo jobConnectionInfo;
			LuaObject.checkType<ConfigDataJobConnectionInfo>(l, 2, out jobConnectionInfo);
			battleActor.m_luaExportHelper.m_jobConnectionInfo = jobConnectionInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017177 RID: 94583 RVA: 0x00637C5C File Offset: 0x00635E5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_jobInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActor.m_luaExportHelper.m_jobInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017178 RID: 94584 RVA: 0x00637CB4 File Offset: 0x00635EB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_jobInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			ConfigDataJobInfo jobInfo;
			LuaObject.checkType<ConfigDataJobInfo>(l, 2, out jobInfo);
			battleActor.m_luaExportHelper.m_jobInfo = jobInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017179 RID: 94585 RVA: 0x00637D10 File Offset: 0x00635F10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroArmyInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActor.m_luaExportHelper.m_heroArmyInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601717A RID: 94586 RVA: 0x00637D68 File Offset: 0x00635F68
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_heroArmyInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			ConfigDataArmyInfo heroArmyInfo;
			LuaObject.checkType<ConfigDataArmyInfo>(l, 2, out heroArmyInfo);
			battleActor.m_luaExportHelper.m_heroArmyInfo = heroArmyInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601717B RID: 94587 RVA: 0x00637DC4 File Offset: 0x00635FC4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_soldierInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActor.m_luaExportHelper.m_soldierInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601717C RID: 94588 RVA: 0x00637E1C File Offset: 0x0063601C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_soldierInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			ConfigDataSoldierInfo soldierInfo;
			LuaObject.checkType<ConfigDataSoldierInfo>(l, 2, out soldierInfo);
			battleActor.m_luaExportHelper.m_soldierInfo = soldierInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601717D RID: 94589 RVA: 0x00637E78 File Offset: 0x00636078
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierArmyInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActor.m_luaExportHelper.m_soldierArmyInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601717E RID: 94590 RVA: 0x00637ED0 File Offset: 0x006360D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierArmyInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			ConfigDataArmyInfo soldierArmyInfo;
			LuaObject.checkType<ConfigDataArmyInfo>(l, 2, out soldierArmyInfo);
			battleActor.m_luaExportHelper.m_soldierArmyInfo = soldierArmyInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601717F RID: 94591 RVA: 0x00637F2C File Offset: 0x0063612C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroCharImageSkinResourceInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActor.m_luaExportHelper.m_heroCharImageSkinResourceInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017180 RID: 94592 RVA: 0x00637F84 File Offset: 0x00636184
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroCharImageSkinResourceInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			ConfigDataCharImageSkinResourceInfo heroCharImageSkinResourceInfo;
			LuaObject.checkType<ConfigDataCharImageSkinResourceInfo>(l, 2, out heroCharImageSkinResourceInfo);
			battleActor.m_luaExportHelper.m_heroCharImageSkinResourceInfo = heroCharImageSkinResourceInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017181 RID: 94593 RVA: 0x00637FE0 File Offset: 0x006361E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroModelSkinResourceInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActor.m_luaExportHelper.m_heroModelSkinResourceInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017182 RID: 94594 RVA: 0x00638038 File Offset: 0x00636238
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroModelSkinResourceInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			ConfigDataModelSkinResourceInfo heroModelSkinResourceInfo;
			LuaObject.checkType<ConfigDataModelSkinResourceInfo>(l, 2, out heroModelSkinResourceInfo);
			battleActor.m_luaExportHelper.m_heroModelSkinResourceInfo = heroModelSkinResourceInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017183 RID: 94595 RVA: 0x00638094 File Offset: 0x00636294
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_soldierModelSkinResourceInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActor.m_luaExportHelper.m_soldierModelSkinResourceInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017184 RID: 94596 RVA: 0x006380EC File Offset: 0x006362EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierModelSkinResourceInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			ConfigDataModelSkinResourceInfo soldierModelSkinResourceInfo;
			LuaObject.checkType<ConfigDataModelSkinResourceInfo>(l, 2, out soldierModelSkinResourceInfo);
			battleActor.m_luaExportHelper.m_soldierModelSkinResourceInfo = soldierModelSkinResourceInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017185 RID: 94597 RVA: 0x00638148 File Offset: 0x00636348
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_extraPassiveSkillInfos(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActor.m_luaExportHelper.m_extraPassiveSkillInfos);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017186 RID: 94598 RVA: 0x006381A0 File Offset: 0x006363A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_extraPassiveSkillInfos(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			ConfigDataSkillInfo[] extraPassiveSkillInfos;
			LuaObject.checkArray<ConfigDataSkillInfo>(l, 2, out extraPassiveSkillInfos);
			battleActor.m_luaExportHelper.m_extraPassiveSkillInfos = extraPassiveSkillInfos;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017187 RID: 94599 RVA: 0x006381FC File Offset: 0x006363FC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_extraTalentSkillInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActor.m_luaExportHelper.m_extraTalentSkillInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017188 RID: 94600 RVA: 0x00638254 File Offset: 0x00636454
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_extraTalentSkillInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			ConfigDataSkillInfo extraTalentSkillInfo;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 2, out extraTalentSkillInfo);
			battleActor.m_luaExportHelper.m_extraTalentSkillInfo = extraTalentSkillInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017189 RID: 94601 RVA: 0x006382B0 File Offset: 0x006364B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isActionCriticalAttack(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActor.m_luaExportHelper.m_isActionCriticalAttack);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601718A RID: 94602 RVA: 0x00638308 File Offset: 0x00636508
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_isActionCriticalAttack(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			bool isActionCriticalAttack;
			LuaObject.checkType(l, 2, out isActionCriticalAttack);
			battleActor.m_luaExportHelper.m_isActionCriticalAttack = isActionCriticalAttack;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601718B RID: 94603 RVA: 0x00638364 File Offset: 0x00636564
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isActionKillActor(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActor.m_luaExportHelper.m_isActionKillActor);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601718C RID: 94604 RVA: 0x006383BC File Offset: 0x006365BC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_isActionKillActor(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			bool isActionKillActor;
			LuaObject.checkType(l, 2, out isActionKillActor);
			battleActor.m_luaExportHelper.m_isActionKillActor = isActionKillActor;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601718D RID: 94605 RVA: 0x00638418 File Offset: 0x00636618
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isActionDamageActor(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActor.m_luaExportHelper.m_isActionDamageActor);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601718E RID: 94606 RVA: 0x00638470 File Offset: 0x00636670
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isActionDamageActor(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			bool isActionDamageActor;
			LuaObject.checkType(l, 2, out isActionDamageActor);
			battleActor.m_luaExportHelper.m_isActionDamageActor = isActionDamageActor;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601718F RID: 94607 RVA: 0x006384CC File Offset: 0x006366CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isBeCriticalAttack(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActor.m_luaExportHelper.m_isBeCriticalAttack);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017190 RID: 94608 RVA: 0x00638524 File Offset: 0x00636724
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_isBeCriticalAttack(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			bool isBeCriticalAttack;
			LuaObject.checkType(l, 2, out isBeCriticalAttack);
			battleActor.m_luaExportHelper.m_isBeCriticalAttack = isBeCriticalAttack;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017191 RID: 94609 RVA: 0x00638580 File Offset: 0x00636780
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_isBeKillAttack(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActor.m_luaExportHelper.m_isBeKillAttack);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017192 RID: 94610 RVA: 0x006385D8 File Offset: 0x006367D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isBeKillAttack(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			bool isBeKillAttack;
			LuaObject.checkType(l, 2, out isBeKillAttack);
			battleActor.m_luaExportHelper.m_isBeKillAttack = isBeKillAttack;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017193 RID: 94611 RVA: 0x00638634 File Offset: 0x00636834
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_actionMoveGrids(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActor.m_luaExportHelper.m_actionMoveGrids);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017194 RID: 94612 RVA: 0x0063868C File Offset: 0x0063688C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_actionMoveGrids(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			int actionMoveGrids;
			LuaObject.checkType(l, 2, out actionMoveGrids);
			battleActor.m_luaExportHelper.m_actionMoveGrids = actionMoveGrids;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017195 RID: 94613 RVA: 0x006386E8 File Offset: 0x006368E8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_actionRemainMovePoint(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActor.m_luaExportHelper.m_actionRemainMovePoint);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017196 RID: 94614 RVA: 0x00638740 File Offset: 0x00636940
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_actionRemainMovePoint(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			int actionRemainMovePoint;
			LuaObject.checkType(l, 2, out actionRemainMovePoint);
			battleActor.m_luaExportHelper.m_actionRemainMovePoint = actionRemainMovePoint;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017197 RID: 94615 RVA: 0x0063879C File Offset: 0x0063699C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_buffReplaceMovePoint(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActor.m_luaExportHelper.m_buffReplaceMovePoint);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017198 RID: 94616 RVA: 0x006387F4 File Offset: 0x006369F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_buffReplaceMovePoint(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			int buffReplaceMovePoint;
			LuaObject.checkType(l, 2, out buffReplaceMovePoint);
			battleActor.m_luaExportHelper.m_buffReplaceMovePoint = buffReplaceMovePoint;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017199 RID: 94617 RVA: 0x00638850 File Offset: 0x00636A50
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_lastDamageBySkillInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActor.m_luaExportHelper.m_lastDamageBySkillInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601719A RID: 94618 RVA: 0x006388A8 File Offset: 0x00636AA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_lastDamageBySkillInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			ConfigDataSkillInfo lastDamageBySkillInfo;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 2, out lastDamageBySkillInfo);
			battleActor.m_luaExportHelper.m_lastDamageBySkillInfo = lastDamageBySkillInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601719B RID: 94619 RVA: 0x00638904 File Offset: 0x00636B04
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_firstDamageTurn(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActor.m_luaExportHelper.m_firstDamageTurn);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601719C RID: 94620 RVA: 0x0063895C File Offset: 0x00636B5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_firstDamageTurn(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			int firstDamageTurn;
			LuaObject.checkType(l, 2, out firstDamageTurn);
			battleActor.m_luaExportHelper.m_firstDamageTurn = firstDamageTurn;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601719D RID: 94621 RVA: 0x006389B8 File Offset: 0x00636BB8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_satisfyConditions(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActor.m_luaExportHelper.m_satisfyConditions);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601719E RID: 94622 RVA: 0x00638A10 File Offset: 0x00636C10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_satisfyConditions(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			ulong satisfyConditions;
			LuaObject.checkType(l, 2, out satisfyConditions);
			battleActor.m_luaExportHelper.m_satisfyConditions = satisfyConditions;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601719F RID: 94623 RVA: 0x00638A6C File Offset: 0x00636C6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_actionCount(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActor.m_luaExportHelper.m_actionCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060171A0 RID: 94624 RVA: 0x00638AC4 File Offset: 0x00636CC4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_actionCount(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			short actionCount;
			LuaObject.checkType(l, 2, out actionCount);
			battleActor.m_luaExportHelper.m_actionCount = actionCount;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060171A1 RID: 94625 RVA: 0x00638B20 File Offset: 0x00636D20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_combatAttackCount(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActor.m_luaExportHelper.m_combatAttackCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060171A2 RID: 94626 RVA: 0x00638B78 File Offset: 0x00636D78
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_combatAttackCount(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			short combatAttackCount;
			LuaObject.checkType(l, 2, out combatAttackCount);
			battleActor.m_luaExportHelper.m_combatAttackCount = combatAttackCount;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060171A3 RID: 94627 RVA: 0x00638BD4 File Offset: 0x00636DD4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_beCombatAttackCount(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActor.m_luaExportHelper.m_beCombatAttackCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060171A4 RID: 94628 RVA: 0x00638C2C File Offset: 0x00636E2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_beCombatAttackCount(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			short beCombatAttackCount;
			LuaObject.checkType(l, 2, out beCombatAttackCount);
			battleActor.m_luaExportHelper.m_beCombatAttackCount = beCombatAttackCount;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060171A5 RID: 94629 RVA: 0x00638C88 File Offset: 0x00636E88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_useSkillCount(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActor.m_luaExportHelper.m_useSkillCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060171A6 RID: 94630 RVA: 0x00638CE0 File Offset: 0x00636EE0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_useSkillCount(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			short useSkillCount;
			LuaObject.checkType(l, 2, out useSkillCount);
			battleActor.m_luaExportHelper.m_useSkillCount = useSkillCount;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060171A7 RID: 94631 RVA: 0x00638D3C File Offset: 0x00636F3C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_killActorCount(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActor.m_luaExportHelper.m_killActorCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060171A8 RID: 94632 RVA: 0x00638D94 File Offset: 0x00636F94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_killActorCount(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			short killActorCount;
			LuaObject.checkType(l, 2, out killActorCount);
			battleActor.m_luaExportHelper.m_killActorCount = killActorCount;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060171A9 RID: 94633 RVA: 0x00638DF0 File Offset: 0x00636FF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_dieTurn(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActor.m_luaExportHelper.m_dieTurn);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060171AA RID: 94634 RVA: 0x00638E48 File Offset: 0x00637048
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_dieTurn(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			int dieTurn;
			LuaObject.checkType(l, 2, out dieTurn);
			battleActor.m_luaExportHelper.m_dieTurn = dieTurn;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060171AB RID: 94635 RVA: 0x00638EA4 File Offset: 0x006370A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_deathAnimType(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActor.m_luaExportHelper.m_deathAnimType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060171AC RID: 94636 RVA: 0x00638EFC File Offset: 0x006370FC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_deathAnimType(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			int deathAnimType;
			LuaObject.checkType(l, 2, out deathAnimType);
			battleActor.m_luaExportHelper.m_deathAnimType = deathAnimType;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060171AD RID: 94637 RVA: 0x00638F58 File Offset: 0x00637158
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_executedCommandTypes(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActor.m_luaExportHelper.m_executedCommandTypes);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060171AE RID: 94638 RVA: 0x00638FB0 File Offset: 0x006371B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_executedCommandTypes(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			uint executedCommandTypes;
			LuaObject.checkType(l, 2, out executedCommandTypes);
			battleActor.m_luaExportHelper.m_executedCommandTypes = executedCommandTypes;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060171AF RID: 94639 RVA: 0x0063900C File Offset: 0x0063720C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_executedSkillInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActor.m_luaExportHelper.m_executedSkillInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060171B0 RID: 94640 RVA: 0x00639064 File Offset: 0x00637264
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_executedSkillInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			ConfigDataSkillInfo executedSkillInfo;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 2, out executedSkillInfo);
			battleActor.m_luaExportHelper.m_executedSkillInfo = executedSkillInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060171B1 RID: 94641 RVA: 0x006390C0 File Offset: 0x006372C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerIndex(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActor.m_luaExportHelper.m_playerIndex);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060171B2 RID: 94642 RVA: 0x00639118 File Offset: 0x00637318
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_playerIndex(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			int playerIndex;
			LuaObject.checkType(l, 2, out playerIndex);
			battleActor.m_luaExportHelper.m_playerIndex = playerIndex;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060171B3 RID: 94643 RVA: 0x00639174 File Offset: 0x00637374
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_curBehaviorCfg(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActor.m_luaExportHelper.m_curBehaviorCfg);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060171B4 RID: 94644 RVA: 0x006391CC File Offset: 0x006373CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_curBehaviorCfg(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			ConfigDataBehavior curBehaviorCfg;
			LuaObject.checkType<ConfigDataBehavior>(l, 2, out curBehaviorCfg);
			battleActor.m_luaExportHelper.m_curBehaviorCfg = curBehaviorCfg;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060171B5 RID: 94645 RVA: 0x00639228 File Offset: 0x00637428
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_curBehaviorState(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)battleActor.m_luaExportHelper.m_curBehaviorState);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060171B6 RID: 94646 RVA: 0x00639280 File Offset: 0x00637480
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_curBehaviorState(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			BattleActor.BehaviorState curBehaviorState;
			LuaObject.checkEnum<BattleActor.BehaviorState>(l, 2, out curBehaviorState);
			battleActor.m_luaExportHelper.m_curBehaviorState = curBehaviorState;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060171B7 RID: 94647 RVA: 0x006392DC File Offset: 0x006374DC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_moveTarget(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActor.m_luaExportHelper.m_moveTarget);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060171B8 RID: 94648 RVA: 0x00639334 File Offset: 0x00637534
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_moveTarget(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			BehaviorTarget moveTarget;
			LuaObject.checkType<BehaviorTarget>(l, 2, out moveTarget);
			battleActor.m_luaExportHelper.m_moveTarget = moveTarget;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060171B9 RID: 94649 RVA: 0x00639390 File Offset: 0x00637590
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_attackTarget(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActor.m_luaExportHelper.m_attackTarget);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060171BA RID: 94650 RVA: 0x006393E8 File Offset: 0x006375E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_attackTarget(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			BehaviorTarget attackTarget;
			LuaObject.checkType<BehaviorTarget>(l, 2, out attackTarget);
			battleActor.m_luaExportHelper.m_attackTarget = attackTarget;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060171BB RID: 94651 RVA: 0x00639444 File Offset: 0x00637644
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_attackSkillIndex(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActor.m_luaExportHelper.m_attackSkillIndex);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060171BC RID: 94652 RVA: 0x0063949C File Offset: 0x0063769C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_attackSkillIndex(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			int attackSkillIndex;
			LuaObject.checkType(l, 2, out attackSkillIndex);
			battleActor.m_luaExportHelper.m_attackSkillIndex = attackSkillIndex;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060171BD RID: 94653 RVA: 0x006394F8 File Offset: 0x006376F8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_beAttackedCountOfTurns(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActor.m_luaExportHelper.m_beAttackedCountOfTurns);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060171BE RID: 94654 RVA: 0x00639550 File Offset: 0x00637750
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_beAttackedCountOfTurns(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			int[] beAttackedCountOfTurns;
			LuaObject.checkArray<int>(l, 2, out beAttackedCountOfTurns);
			battleActor.m_luaExportHelper.m_beAttackedCountOfTurns = beAttackedCountOfTurns;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060171BF RID: 94655 RVA: 0x006395AC File Offset: 0x006377AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_groupId(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActor.m_luaExportHelper.m_groupId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060171C0 RID: 94656 RVA: 0x00639604 File Offset: 0x00637804
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_groupId(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			int groupId;
			LuaObject.checkType(l, 2, out groupId);
			battleActor.m_luaExportHelper.m_groupId = groupId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060171C1 RID: 94657 RVA: 0x00639660 File Offset: 0x00637860
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_aiCreateBattleCommandCount(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActor.m_luaExportHelper.m_aiCreateBattleCommandCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060171C2 RID: 94658 RVA: 0x006396B8 File Offset: 0x006378B8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_aiCreateBattleCommandCount(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			int aiCreateBattleCommandCount;
			LuaObject.checkType(l, 2, out aiCreateBattleCommandCount);
			battleActor.m_luaExportHelper.m_aiCreateBattleCommandCount = aiCreateBattleCommandCount;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060171C3 RID: 94659 RVA: 0x00639714 File Offset: 0x00637914
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_healSkillTargetHPThresh(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, BattleActor.LuaExportHelper.m_healSkillTargetHPThresh);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060171C4 RID: 94660 RVA: 0x0063975C File Offset: 0x0063795C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Position(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActor.Position);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060171C5 RID: 94661 RVA: 0x006397B4 File Offset: 0x006379B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_InitPosition(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActor.InitPosition);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060171C6 RID: 94662 RVA: 0x0063980C File Offset: 0x00637A0C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Direction(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActor.Direction);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060171C7 RID: 94663 RVA: 0x00639860 File Offset: 0x00637A60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Battle(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActor.Battle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060171C8 RID: 94664 RVA: 0x006398B4 File Offset: 0x00637AB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Team(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActor.Team);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060171C9 RID: 94665 RVA: 0x00639908 File Offset: 0x00637B08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_TeamNumber(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActor.TeamNumber);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060171CA RID: 94666 RVA: 0x0063995C File Offset: 0x00637B5C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_HeroBattleProperty(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActor.HeroBattleProperty);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060171CB RID: 94667 RVA: 0x006399B0 File Offset: 0x00637BB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_SoldierBattleProperty(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActor.SoldierBattleProperty);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060171CC RID: 94668 RVA: 0x00639A04 File Offset: 0x00637C04
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_HeroHealthPoint(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActor.HeroHealthPoint);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060171CD RID: 94669 RVA: 0x00639A58 File Offset: 0x00637C58
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_SoldierTotalHealthPoint(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActor.SoldierTotalHealthPoint);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060171CE RID: 94670 RVA: 0x00639AAC File Offset: 0x00637CAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_SoldierSingleHealthPointMax(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActor.SoldierSingleHealthPointMax);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060171CF RID: 94671 RVA: 0x00639B00 File Offset: 0x00637D00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_FightTags(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActor.FightTags);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060171D0 RID: 94672 RVA: 0x00639B54 File Offset: 0x00637D54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_HeroLevel(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActor.HeroLevel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060171D1 RID: 94673 RVA: 0x00639BA8 File Offset: 0x00637DA8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_HeroStar(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActor.HeroStar);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060171D2 RID: 94674 RVA: 0x00639BFC File Offset: 0x00637DFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_JobLevel(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActor.JobLevel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060171D3 RID: 94675 RVA: 0x00639C50 File Offset: 0x00637E50
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ActionValue(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActor.ActionValue);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060171D4 RID: 94676 RVA: 0x00639CA4 File Offset: 0x00637EA4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_ActionValue(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			int actionValue;
			LuaObject.checkType(l, 2, out actionValue);
			battleActor.ActionValue = actionValue;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060171D5 RID: 94677 RVA: 0x00639CFC File Offset: 0x00637EFC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_HeroInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActor.HeroInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060171D6 RID: 94678 RVA: 0x00639D50 File Offset: 0x00637F50
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_HeroId(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActor.HeroId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060171D7 RID: 94679 RVA: 0x00639DA4 File Offset: 0x00637FA4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_HeroArmyInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActor.HeroArmyInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060171D8 RID: 94680 RVA: 0x00639DF8 File Offset: 0x00637FF8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_HeroArmyId(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActor.HeroArmyId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060171D9 RID: 94681 RVA: 0x00639E4C File Offset: 0x0063804C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_JobConnectionInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActor.JobConnectionInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060171DA RID: 94682 RVA: 0x00639EA0 File Offset: 0x006380A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_JobInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActor.JobInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060171DB RID: 94683 RVA: 0x00639EF4 File Offset: 0x006380F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_SoldierInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActor.SoldierInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060171DC RID: 94684 RVA: 0x00639F48 File Offset: 0x00638148
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_SoldierArmyInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActor.SoldierArmyInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060171DD RID: 94685 RVA: 0x00639F9C File Offset: 0x0063819C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_HeroCharImageSkinResourceInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActor.HeroCharImageSkinResourceInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060171DE RID: 94686 RVA: 0x00639FF0 File Offset: 0x006381F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_HeroModelSkinResourceInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActor.HeroModelSkinResourceInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060171DF RID: 94687 RVA: 0x0063A044 File Offset: 0x00638244
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_SoldierModelSkinResourceInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActor.SoldierModelSkinResourceInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060171E0 RID: 94688 RVA: 0x0063A098 File Offset: 0x00638298
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_PlayerIndex(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActor.PlayerIndex);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060171E1 RID: 94689 RVA: 0x0063A0EC File Offset: 0x006382EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Group(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActor.Group);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060171E2 RID: 94690 RVA: 0x0063A140 File Offset: 0x00638340
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Group(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			BehaviorGroup group;
			LuaObject.checkType<BehaviorGroup>(l, 2, out group);
			battleActor.Group = group;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060171E3 RID: 94691 RVA: 0x0063A198 File Offset: 0x00638398
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_GroupId(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActor.GroupId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060171E4 RID: 94692 RVA: 0x0063A1EC File Offset: 0x006383EC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_IsAttackedByEnemy(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActor.m_luaExportHelper.IsAttackedByEnemy);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060171E5 RID: 94693 RVA: 0x0063A244 File Offset: 0x00638444
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_IsAttackedByEnemyInLastTrun(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActor.m_luaExportHelper.IsAttackedByEnemyInLastTrun);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060171E6 RID: 94694 RVA: 0x0063A29C File Offset: 0x0063849C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_InstanceID(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActor.InstanceID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060171E7 RID: 94695 RVA: 0x0063A2F0 File Offset: 0x006384F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_NextBehaviorByChangeRules(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActor.m_luaExportHelper.NextBehaviorByChangeRules);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060171E8 RID: 94696 RVA: 0x0063A348 File Offset: 0x00638548
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_TotalHPPercent(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActor.m_luaExportHelper.TotalHPPercent);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060171E9 RID: 94697 RVA: 0x0063A3A0 File Offset: 0x006385A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_BehaviorSelectSkillInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleActor battleActor = (BattleActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActor.m_luaExportHelper.BehaviorSelectSkillInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060171EA RID: 94698 RVA: 0x0063A3F8 File Offset: 0x006385F8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Battle.BattleActor");
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.Dispose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.Initialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.InitializeSkin);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.InitializeExtraPassiveSkillAndTalent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.InitializeEnd);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.UpdateBattleProperties);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.UpdateBattlePropertiesInCombat);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.CollectJobMasterPropertyModifiers);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.CollectEquipmentPropertyModifiers);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.SetDirection);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.FaceTo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.GuardMove);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.UnguardMove);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.GetTerrain);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.GetBuffEffectedTerrain);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.ChangeTeam);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.CreateBattleCommand);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.StartBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.StopBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.NextTurn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.ActionBegin);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.ActionEnd);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.IsActionFinished);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.CanAction);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.FindPath);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.FindMoveRegion);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.HasExecutedCommandType);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.ExecuteMoveCommand);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.ExecutePerformMoveCommand);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.ExecuteCombatCommand);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.ExecuteSkillCommand);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.ExecutePerformSkillCommand);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.ExecuteDoneCommand);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.IsDead);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.IsRetreat);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.IsDeadOrRetreat);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.SetVisible);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.IsVisible);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache25);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.IsInvincible);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache26);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.IsSummoned);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache27);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.IsNpc);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache28);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.IsAINpc);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache29);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.IsPlayerNpc);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache2A);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.IsPlayerActor);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache2B);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.IsAIActor);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache2C);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.CanBeTarget);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache2D);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.SetHeroHealthPoint);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache2E);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.SetSoldierTotalHealthPoint);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache2F);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.CheckDie);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache30);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.Retreat);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache31);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.GetSoldierAttackDistance);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache32);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.GetMaxAttackDistance);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache33);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.GetTalentSkillInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache34);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.GetSkillDistance);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache35);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.GetMovePoint);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache36);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.GetMoveType);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache37);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.GetTotalHealthPoint);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache38);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.GetTotalHealthPointMax);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache39);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.GetSoldierCount);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache3A);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.SetLastDamageBySkill);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache3B);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.GetLastDamageBySkill);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache3C);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.SetFirstDamageTurn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache3D);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.GetFirstDamageTurn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache3E);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.SetSetisfyCondition);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache3F);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.IsSatisfyCondition);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache40);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.GetDeathAnimType);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache41);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.SetBeCriticalAttack);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache42);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.SetBeKillAttack);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache43);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.SetActionCriticalAttack);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache44);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.SetActionKillActor);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache45);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache46 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache46 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.SetActionDamageActor);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache46);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache47 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache47 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.IsExtraAction);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache47);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache48 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache48 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.IsExtraActionMoving);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache48);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache49 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache49 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.GetActionCount);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache49);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache4A == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache4A = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.IncreaseCombatAttackCount);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache4A);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache4B == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache4B = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.GetCombatAttackCount);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache4B);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache4C == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache4C = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.IncreaseBeCombatAttackCount);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache4C);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache4D == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache4D = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.GetBeCombatAttackCount);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache4D);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache4E == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache4E = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.IncreaseUseSkillCount);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache4E);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache4F == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache4F = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.GetUseSkillCount);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache4F);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache50 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache50 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.IncreaseKillActorCount);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache50);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache51 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache51 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.GetKillActorCount);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache51);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache52 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache52 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.GetKillerActor);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache52);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache53 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache53 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.GetDieTurn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache53);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache54 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache54 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.GetSourceType);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache54);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache55 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache55 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.IncreaseBeAttackedCount);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache55);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache56 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache56 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.GetBehaviorId);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache56);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache57 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache57 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.SetBehavior);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache57);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache58 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache58 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.CheckBehaviorCondition);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache58);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache59 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache59 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.FindEmptyGridInCanAttackAndTouchRange);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache59);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache5A == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache5A = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.FindActorsInCanAttackAndTouchRange);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache5A);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache5B == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache5B = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.GenerateAIBattleCommand);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache5B);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache5C == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache5C = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.GetBuffStates);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache5C);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache5D == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache5D = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.AttachBuff);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache5D);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache5E == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache5E = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.RemoveBuffList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache5E);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache5F == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache5F = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.SkillDispelBuff);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache5F);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache60 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache60 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.CollectBuffPropertyModifiersAndFightTags);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache60);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache61 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache61 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.CollectBuffPropertyExchange);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache61);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache62 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache62 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.CollectBuffPropertyReplace);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache62);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache63 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache63 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.UpdateAllAuras);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache63);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache64 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache64 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.HasFightTag);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache64);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache65 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache65 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.HasBuffType);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache65);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache66 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache66 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.IsBuffEffective);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache66);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache67 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache67 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.ComputeBuffReboundDamage);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache67);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache68 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache68 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.GetBuffOverrideMovePointCost);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache68);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache69 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache69 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.GetBuffOverrideTerrain);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache69);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache6A == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache6A = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.AddBuffArmyRelationAttack);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache6A);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache6B == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache6B = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.AddBuffArmyRelationDefend);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache6B);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache6C == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache6C = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.AddBuffArmyRelationModifyAttack);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache6C);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache6D == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache6D = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.AddBuffArmyRelationModifyDefend);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache6D);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache6E == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache6E = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.IsBuffForceMagicDamage);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache6E);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache6F == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache6F = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.ActionEndBuffDoubleMove);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache6F);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache70 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache70 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.CombatBuffHeal);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache70);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache71 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache71 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.CombatBuffHealOther);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache71);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache72 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache72 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.CombatBuffDamage);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache72);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache73 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache73 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.CombatApplyBuff);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache73);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache74 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache74 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.AttackApplyBuff);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache74);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache75 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache75 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.AttackBuffDamage);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache75);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache76 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache76 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.AttackRemoveBuff);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache76);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache77 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache77 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.AttackRemoveSkillCooldown);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache77);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache78 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache78 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.BattleFieldSkillApplyBuff);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache78);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache79 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache79 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.AttackBuffPunch);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache79);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache7A == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache7A = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.AttackBuffDrag);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache7A);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache7B == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache7B = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.AttackBuffExchangePosition);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache7B);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache7C == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache7C = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.CombatArmyChange);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache7C);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache7D == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache7D = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.BuffDoubleAttack);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache7D);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache7E == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache7E = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.BuffUndead);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache7E);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache7F == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache7F = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.GetGuardActor);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache7F);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache80 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache80 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.AfterCombatDetachBuff);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache80);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache81 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache81 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.GetSkillState);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache81);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache82 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache82 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.GetSkillStateById);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache82);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache83 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache83 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.GetSkillStates);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache83);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache84 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache84 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.CanUseSkillOnTarget);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache84);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache85 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache85 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.IsBattlefiledSkillApplyTarget);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache85);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache86 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache86 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.CombatBy);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache86);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache87 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache87 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.GetHeroAttackSkillInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache87);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache88 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache88 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.GetSoldierAttackSkillInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache88);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache89 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache89 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.ComputeMoveType_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache89);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache8A == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache8A = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.ComputeDefaultMoveType_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache8A);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache8B == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache8B = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.SelectMinHPPercentActor_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache8B);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache8C == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache8C = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.FindActorsAlive_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache8C);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache8D == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache8D = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.ComputeBattleProperties);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache8D);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache8E == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache8E = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.SetPosition);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache8E);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache8F == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache8F = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.MoveTo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache8F);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache90 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache90 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.ClearMapActor);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache90);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache91 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache91 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.PostActionTerrainDamage);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache91);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache92 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache92 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.ShouldLog);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache92);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache93 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache93 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.AddExecutedCommandType);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache93);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache94 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache94 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.IsExecutedCommandType);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache94);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache95 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache95 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.FindMoveAndAttackRegion);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache95);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache96 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache96 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.FindRandomEmptyPosition);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache96);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache97 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache97 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.FindAttackPosition);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache97);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache98 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache98 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.ComputeActorScoreBuff);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache98);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache99 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache99 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.SelectNearestTarget);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache99);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache9A == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache9A = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.GetAIRandomNumber);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache9A);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache9B == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache9B = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.GetSkillTargetTeam);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache9B);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache9C == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache9C = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.CanAttackOrUseSkill);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache9C);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache9D == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache9D = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.SetBehaviorState);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache9D);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache9E == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache9E = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.DoBehaviorChangeRules);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache9E);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache9F == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache9F = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.FindFarthestPosition);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache9F);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheA0 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheA0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.FindNearestPosition);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheA0);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheA1 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheA1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.FindNearestActor);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheA1);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheA2 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheA2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.DoSelectTarget);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheA2);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheA3 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheA3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.FindActorsByIDFilter);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheA3);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheA4 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheA4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.SelectMoveTarget);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheA4);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheA5 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheA5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.GenerateCommandOfMove);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheA5);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheA6 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheA6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.FindPositionToMoveToTarget);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheA6);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheA7 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheA7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.ComputeRestrictScore);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheA7);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheA8 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheA8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.GetArmyRistrictScore);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheA8);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheA9 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheA9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.DefaultSelectDamageSkillTarget);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheA9);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheAA == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheAA = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.IsSelectRangeSkill);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheAA);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheAB == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheAB = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.FindActorsInGrids);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheAB);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheAC == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheAC = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.FindMaxAoeSkillCoverPosition);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheAC);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheAD == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheAD = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.FindMaxAoeSkillCoverActor);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheAD);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheAE == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheAE = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.DefaultSelectAttackTarget);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheAE);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheAF == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheAF = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.FindGridsLessEqualDistance);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheAF);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheB0 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheB0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.FindActorsLessEqualDistance);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheB0);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheB1 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheB1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.DefaultSelectHealSkillTarget);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheB1);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheB2 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheB2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.DefaultSelectBuffSkillTarget);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheB2);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheB3 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheB3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.SelectAttackTargetInSkillRange);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheB3);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheB4 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheB4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.FindActorsWithBuffN);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheB4);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheB5 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheB5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.SelectAttackTarget);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheB5);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheB6 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheB6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.SelectSkill);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheB6);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheB7 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheB7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.SelectSkillDirectReachTarget);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheB7);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheB8 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheB8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.DefaultSelectSkill);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheB8);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheB9 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheB9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.FindActorsInCanNormalAttackAndTouchRange);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheB9);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheBA == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheBA = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.IsSkillAGoodAISelection);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheBA);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheBB == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheBB = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.FindCastSkillPosition);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheBB);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheBC == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheBC = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.FindAttackPositions);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheBC);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheBD == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheBD = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.GenerateCommandOfAttack);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheBD);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheBE == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheBE = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.DoBehaviorMove);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheBE);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheBF == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheBF = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.IsAttackTargetStillValid);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheBF);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheC0 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheC0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.DoBehaviorAttack);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheC0);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheC1 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheC1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.AICreateBattleCommand);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheC1);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheC2 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheC2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.SelectAttackRegionTarget);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheC2);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheC3 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheC3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.InitializeBuffs);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheC3);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheC4 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheC4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.AttachPassiveSkillBuffs);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheC4);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheC5 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheC5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.RemoveBuff);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheC5);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheC6 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheC6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.FindBuff);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheC6);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheC7 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheC7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.RemoveAllBuffs);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheC7);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheC8 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheC8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.HasBuff);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheC8);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheC9 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheC9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.CollectPropertyModifier);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheC9);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheCA == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheCA = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.CollectOtherActorBuffPropertyModifiersAndFightTags);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheCA);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheCB == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheCB = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.CollectBuffPropertyModifiersAndFightTagsInCombat);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheCB);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheCC == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheCC = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.RemoveAuraAppliedBuffs);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheCC);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheCD == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheCD = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.RemovePackChildBuffs);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheCD);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheCE == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheCE = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.OnBuffHit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheCE);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheCF == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheCF = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.UpdateBuffTypes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheCF);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheD0 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheD0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.SetBuffType);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheD0);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheD1 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheD1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.IsBuffHpConditionSatisfied);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheD1);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheD2 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheD2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.IsBuffEffectiveConditionSatisfied);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheD2);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheD3 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheD3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.IsBuffCombatConditionSatisfied);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheD3);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheD4 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheD4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.ComputeNeighborAliveActorCount);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheD4);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheD5 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheD5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.IsBuffCooldown);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheD5);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheD6 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheD6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.StartBuffCooldown);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheD6);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheD7 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheD7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.ComputeBuffCount);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheD7);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheD8 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheD8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.ComputeEnhanceOrDebuffCount);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheD8);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheD9 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheD9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.IsImmuneBuffSubType);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheD9);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheDA == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheDA = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.ActionEndBuffEffect);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheDA);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheDB == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheDB = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.UpdateBuffTime);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheDB);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheDC == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheDC = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.ActionEndBuffHealOverTime);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheDC);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheDD == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheDD = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.ActionEndBuffDamageOverTime);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheDD);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheDE == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheDE = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.ActionEndAddBuff);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheDE);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheDF == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheDF = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.ActionEndAddBuffSuper);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheDF);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheE0 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheE0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.ActionEndRemoveDebuff);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheE0);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheE1 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheE1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.ActionEndRemoveEnhanceBuff);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheE1);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheE2 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheE2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.ActionEndBuffBattlefieldSkill);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheE2);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheE3 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheE3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.ActionEndBuffNewTurn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheE3);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheE4 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheE4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.CanBuffGuard);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheE4);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheE5 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheE5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.IsSkillUseable);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheE5);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheE6 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheE6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.FindBattlefieldSkillApplyTargets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheE6);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheE7 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheE7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.ExecuteBattlefieldSkill);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheE7);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheE8 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheE8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.SkillAttack);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheE8);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheE9 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheE9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.SkillSummon);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheE9);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheEA == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheEA = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.SkillTeleport);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheEA);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheEB == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheEB = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.AttackBy);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheEB);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheEC == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheEC = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.SkillAttackEnd);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheEC);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheED == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheED = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.TeleportBy);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheED);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheEE == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheEE = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.SummonBy);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheEE);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheEF == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheEF = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.__callBase_Dispose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheEF);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheF0 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheF0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.__callBase_Tick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheF0);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheF1 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheF1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.__callBase_TickGraphic);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheF1);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheF2 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheF2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.__callBase_Draw);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheF2);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheF3 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheF3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.__callBase_Pause);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheF3);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheF4 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheF4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.__callBase_DoPause);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheF4);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheF5 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheF5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.__callBase_DeleteMe);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheF5);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheF6 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheF6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.ComputeActorScoreDamage_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheF6);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheF7 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheF7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.ComputeActorScoreHeal_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheF7);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheF8 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheF8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.Contains_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheF8);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheF9 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheF9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.HasInt_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheF9);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheFA == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheFA = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.CompareBuffOrder_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheFA);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheFB == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheFB = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.CompareHealActor_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheFB);
		string name = "m_team";
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheFC == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheFC = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.get_m_team);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheFC;
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheFD == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheFD = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.set_m_team);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheFD, true);
		string name2 = "m_position";
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheFE == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheFE = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.get_m_position);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheFE;
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheFF == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheFF = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.set_m_position);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cacheFF, true);
		string name3 = "m_direction";
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache100 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache100 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.get_m_direction);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache100;
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache101 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache101 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.set_m_direction);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache101, true);
		string name4 = "m_initPosition";
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache102 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache102 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.get_m_initPosition);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache102;
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache103 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache103 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.set_m_initPosition);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache103, true);
		string name5 = "m_beforeGuardPosition";
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache104 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache104 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.get_m_beforeGuardPosition);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache104;
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache105 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache105 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.set_m_beforeGuardPosition);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache105, true);
		string name6 = "m_heroBattleProperty";
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache106 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache106 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.get_m_heroBattleProperty);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache106;
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache107 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache107 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.set_m_heroBattleProperty);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache107, true);
		string name7 = "m_soldierBattleProperty";
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache108 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache108 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.get_m_soldierBattleProperty);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache108;
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache109 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache109 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.set_m_soldierBattleProperty);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache109, true);
		string name8 = "m_heroHealthPoint";
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache10A == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache10A = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.get_m_heroHealthPoint);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache10A;
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache10B == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache10B = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.set_m_heroHealthPoint);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache10B, true);
		string name9 = "m_soldierTotalHealthPoint";
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache10C == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache10C = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.get_m_soldierTotalHealthPoint);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache10C;
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache10D == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache10D = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.set_m_soldierTotalHealthPoint);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache10D, true);
		string name10 = "m_soldierSingleHealthPointMax";
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache10E == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache10E = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.get_m_soldierSingleHealthPointMax);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache10E;
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache10F == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache10F = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.set_m_soldierSingleHealthPointMax);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache10F, true);
		string name11 = "m_initSoldierCount";
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache110 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache110 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.get_m_initSoldierCount);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache110;
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache111 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache111 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.set_m_initSoldierCount);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache111, true);
		string name12 = "m_heroLevel";
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache112 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache112 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.get_m_heroLevel);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache112;
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache113 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache113 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.set_m_heroLevel);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache113, true);
		string name13 = "m_heroStar";
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache114 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache114 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.get_m_heroStar);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache114;
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache115 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache115 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.set_m_heroStar);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache115, true);
		string name14 = "m_jobLevel";
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache116 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache116 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.get_m_jobLevel);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache116;
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache117 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache117 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.set_m_jobLevel);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache117, true);
		string name15 = "m_masterJobInfos";
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache118 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache118 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.get_m_masterJobInfos);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache118;
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache119 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache119 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.set_m_masterJobInfos);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache119, true);
		string name16 = "m_equipments";
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache11A == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache11A = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.get_m_equipments);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache11A;
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache11B == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache11B = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.set_m_equipments);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache11B, true);
		string name17 = "m_resonanceSkillInfos";
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache11C == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache11C = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.get_m_resonanceSkillInfos);
		}
		LuaCSFunction get17 = Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache11C;
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache11D == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache11D = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.set_m_resonanceSkillInfos);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache11D, true);
		string name18 = "m_fetterSkillInfos";
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache11E == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache11E = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.get_m_fetterSkillInfos);
		}
		LuaCSFunction get18 = Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache11E;
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache11F == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache11F = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.set_m_fetterSkillInfos);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache11F, true);
		string name19 = "m_actionValue";
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache120 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache120 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.get_m_actionValue);
		}
		LuaCSFunction get19 = Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache120;
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache121 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache121 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.set_m_actionValue);
		}
		LuaObject.addMember(l, name19, get19, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache121, true);
		string name20 = "m_moveType";
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache122 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache122 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.get_m_moveType);
		}
		LuaCSFunction get20 = Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache122;
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache123 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache123 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.set_m_moveType);
		}
		LuaObject.addMember(l, name20, get20, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache123, true);
		string name21 = "m_isActionFinished";
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache124 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache124 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.get_m_isActionFinished);
		}
		LuaCSFunction get21 = Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache124;
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache125 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache125 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.set_m_isActionFinished);
		}
		LuaObject.addMember(l, name21, get21, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache125, true);
		string name22 = "m_hasExtraAction";
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache126 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache126 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.get_m_hasExtraAction);
		}
		LuaCSFunction get22 = Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache126;
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache127 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache127 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.set_m_hasExtraAction);
		}
		LuaObject.addMember(l, name22, get22, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache127, true);
		string name23 = "m_hasExtraActionCount";
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache128 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache128 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.get_m_hasExtraActionCount);
		}
		LuaCSFunction get23 = Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache128;
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache129 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache129 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.set_m_hasExtraActionCount);
		}
		LuaObject.addMember(l, name23, get23, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache129, true);
		string name24 = "m_hasExtraMovePoint";
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache12A == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache12A = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.get_m_hasExtraMovePoint);
		}
		LuaCSFunction get24 = Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache12A;
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache12B == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache12B = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.set_m_hasExtraMovePoint);
		}
		LuaObject.addMember(l, name24, get24, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache12B, true);
		string name25 = "m_isExtraAction";
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache12C == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache12C = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.get_m_isExtraAction);
		}
		LuaCSFunction get25 = Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache12C;
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache12D == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache12D = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.set_m_isExtraAction);
		}
		LuaObject.addMember(l, name25, get25, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache12D, true);
		string name26 = "m_extraActionMovePoint";
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache12E == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache12E = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.get_m_extraActionMovePoint);
		}
		LuaCSFunction get26 = Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache12E;
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache12F == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache12F = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.set_m_extraActionMovePoint);
		}
		LuaObject.addMember(l, name26, get26, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache12F, true);
		string name27 = "m_isVisible";
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache130 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache130 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.get_m_isVisible);
		}
		LuaCSFunction get27 = Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache130;
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache131 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache131 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.set_m_isVisible);
		}
		LuaObject.addMember(l, name27, get27, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache131, true);
		string name28 = "m_isDie";
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache132 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache132 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.get_m_isDie);
		}
		LuaCSFunction get28 = Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache132;
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache133 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache133 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.set_m_isDie);
		}
		LuaObject.addMember(l, name28, get28, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache133, true);
		string name29 = "m_isRetreat";
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache134 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache134 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.get_m_isRetreat);
		}
		LuaCSFunction get29 = Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache134;
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache135 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache135 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.set_m_isRetreat);
		}
		LuaObject.addMember(l, name29, get29, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache135, true);
		string name30 = "m_skillStates";
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache136 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache136 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.get_m_skillStates);
		}
		LuaCSFunction get30 = Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache136;
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache137 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache137 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.set_m_skillStates);
		}
		LuaObject.addMember(l, name30, get30, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache137, true);
		string name31 = "m_buffStates";
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache138 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache138 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.get_m_buffStates);
		}
		LuaCSFunction get31 = Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache138;
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache139 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache139 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.set_m_buffStates);
		}
		LuaObject.addMember(l, name31, get31, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache139, true);
		string name32 = "m_buffIdCounter";
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache13A == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache13A = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.get_m_buffIdCounter);
		}
		LuaCSFunction get32 = Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache13A;
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache13B == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache13B = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.set_m_buffIdCounter);
		}
		LuaObject.addMember(l, name32, get32, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache13B, true);
		string name33 = "m_buffTypes";
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache13C == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache13C = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.get_m_buffTypes);
		}
		LuaCSFunction get33 = Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache13C;
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache13D == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache13D = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.set_m_buffTypes);
		}
		LuaObject.addMember(l, name33, get33, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache13D, true);
		string name34 = "m_fightTags";
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache13E == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache13E = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.get_m_fightTags);
		}
		LuaCSFunction get34 = Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache13E;
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache13F == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache13F = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.set_m_fightTags);
		}
		LuaObject.addMember(l, name34, get34, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache13F, true);
		string name35 = "m_summoner";
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache140 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache140 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.get_m_summoner);
		}
		LuaCSFunction get35 = Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache140;
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache141 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache141 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.set_m_summoner);
		}
		LuaObject.addMember(l, name35, get35, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache141, true);
		string name36 = "m_killerActor";
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache142 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache142 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.get_m_killerActor);
		}
		LuaCSFunction get36 = Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache142;
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache143 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache143 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.set_m_killerActor);
		}
		LuaObject.addMember(l, name36, get36, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache143, true);
		string name37 = "m_isNpc";
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache144 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache144 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.get_m_isNpc);
		}
		LuaCSFunction get37 = Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache144;
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache145 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache145 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.set_m_isNpc);
		}
		LuaObject.addMember(l, name37, get37, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache145, true);
		string name38 = "m_isPlayerNpc";
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache146 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache146 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.get_m_isPlayerNpc);
		}
		LuaCSFunction get38 = Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache146;
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache147 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache147 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.set_m_isPlayerNpc);
		}
		LuaObject.addMember(l, name38, get38, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache147, true);
		string name39 = "m_sourceType";
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache148 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache148 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.get_m_sourceType);
		}
		LuaCSFunction get39 = Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache148;
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache149 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache149 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.set_m_sourceType);
		}
		LuaObject.addMember(l, name39, get39, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache149, true);
		string name40 = "m_heroInfo";
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache14A == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache14A = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.get_m_heroInfo);
		}
		LuaCSFunction get40 = Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache14A;
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache14B == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache14B = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.set_m_heroInfo);
		}
		LuaObject.addMember(l, name40, get40, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache14B, true);
		string name41 = "m_jobConnectionInfo";
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache14C == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache14C = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.get_m_jobConnectionInfo);
		}
		LuaCSFunction get41 = Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache14C;
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache14D == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache14D = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.set_m_jobConnectionInfo);
		}
		LuaObject.addMember(l, name41, get41, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache14D, true);
		string name42 = "m_jobInfo";
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache14E == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache14E = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.get_m_jobInfo);
		}
		LuaCSFunction get42 = Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache14E;
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache14F == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache14F = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.set_m_jobInfo);
		}
		LuaObject.addMember(l, name42, get42, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache14F, true);
		string name43 = "m_heroArmyInfo";
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache150 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache150 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.get_m_heroArmyInfo);
		}
		LuaCSFunction get43 = Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache150;
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache151 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache151 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.set_m_heroArmyInfo);
		}
		LuaObject.addMember(l, name43, get43, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache151, true);
		string name44 = "m_soldierInfo";
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache152 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache152 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.get_m_soldierInfo);
		}
		LuaCSFunction get44 = Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache152;
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache153 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache153 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.set_m_soldierInfo);
		}
		LuaObject.addMember(l, name44, get44, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache153, true);
		string name45 = "m_soldierArmyInfo";
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache154 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache154 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.get_m_soldierArmyInfo);
		}
		LuaCSFunction get45 = Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache154;
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache155 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache155 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.set_m_soldierArmyInfo);
		}
		LuaObject.addMember(l, name45, get45, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache155, true);
		string name46 = "m_heroCharImageSkinResourceInfo";
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache156 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache156 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.get_m_heroCharImageSkinResourceInfo);
		}
		LuaCSFunction get46 = Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache156;
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache157 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache157 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.set_m_heroCharImageSkinResourceInfo);
		}
		LuaObject.addMember(l, name46, get46, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache157, true);
		string name47 = "m_heroModelSkinResourceInfo";
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache158 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache158 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.get_m_heroModelSkinResourceInfo);
		}
		LuaCSFunction get47 = Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache158;
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache159 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache159 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.set_m_heroModelSkinResourceInfo);
		}
		LuaObject.addMember(l, name47, get47, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache159, true);
		string name48 = "m_soldierModelSkinResourceInfo";
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache15A == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache15A = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.get_m_soldierModelSkinResourceInfo);
		}
		LuaCSFunction get48 = Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache15A;
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache15B == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache15B = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.set_m_soldierModelSkinResourceInfo);
		}
		LuaObject.addMember(l, name48, get48, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache15B, true);
		string name49 = "m_extraPassiveSkillInfos";
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache15C == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache15C = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.get_m_extraPassiveSkillInfos);
		}
		LuaCSFunction get49 = Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache15C;
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache15D == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache15D = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.set_m_extraPassiveSkillInfos);
		}
		LuaObject.addMember(l, name49, get49, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache15D, true);
		string name50 = "m_extraTalentSkillInfo";
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache15E == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache15E = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.get_m_extraTalentSkillInfo);
		}
		LuaCSFunction get50 = Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache15E;
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache15F == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache15F = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.set_m_extraTalentSkillInfo);
		}
		LuaObject.addMember(l, name50, get50, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache15F, true);
		string name51 = "m_isActionCriticalAttack";
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache160 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache160 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.get_m_isActionCriticalAttack);
		}
		LuaCSFunction get51 = Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache160;
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache161 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache161 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.set_m_isActionCriticalAttack);
		}
		LuaObject.addMember(l, name51, get51, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache161, true);
		string name52 = "m_isActionKillActor";
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache162 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache162 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.get_m_isActionKillActor);
		}
		LuaCSFunction get52 = Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache162;
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache163 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache163 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.set_m_isActionKillActor);
		}
		LuaObject.addMember(l, name52, get52, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache163, true);
		string name53 = "m_isActionDamageActor";
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache164 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache164 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.get_m_isActionDamageActor);
		}
		LuaCSFunction get53 = Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache164;
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache165 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache165 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.set_m_isActionDamageActor);
		}
		LuaObject.addMember(l, name53, get53, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache165, true);
		string name54 = "m_isBeCriticalAttack";
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache166 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache166 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.get_m_isBeCriticalAttack);
		}
		LuaCSFunction get54 = Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache166;
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache167 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache167 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.set_m_isBeCriticalAttack);
		}
		LuaObject.addMember(l, name54, get54, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache167, true);
		string name55 = "m_isBeKillAttack";
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache168 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache168 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.get_m_isBeKillAttack);
		}
		LuaCSFunction get55 = Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache168;
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache169 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache169 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.set_m_isBeKillAttack);
		}
		LuaObject.addMember(l, name55, get55, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache169, true);
		string name56 = "m_actionMoveGrids";
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache16A == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache16A = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.get_m_actionMoveGrids);
		}
		LuaCSFunction get56 = Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache16A;
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache16B == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache16B = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.set_m_actionMoveGrids);
		}
		LuaObject.addMember(l, name56, get56, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache16B, true);
		string name57 = "m_actionRemainMovePoint";
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache16C == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache16C = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.get_m_actionRemainMovePoint);
		}
		LuaCSFunction get57 = Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache16C;
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache16D == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache16D = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.set_m_actionRemainMovePoint);
		}
		LuaObject.addMember(l, name57, get57, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache16D, true);
		string name58 = "m_buffReplaceMovePoint";
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache16E == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache16E = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.get_m_buffReplaceMovePoint);
		}
		LuaCSFunction get58 = Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache16E;
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache16F == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache16F = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.set_m_buffReplaceMovePoint);
		}
		LuaObject.addMember(l, name58, get58, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache16F, true);
		string name59 = "m_lastDamageBySkillInfo";
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache170 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache170 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.get_m_lastDamageBySkillInfo);
		}
		LuaCSFunction get59 = Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache170;
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache171 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache171 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.set_m_lastDamageBySkillInfo);
		}
		LuaObject.addMember(l, name59, get59, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache171, true);
		string name60 = "m_firstDamageTurn";
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache172 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache172 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.get_m_firstDamageTurn);
		}
		LuaCSFunction get60 = Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache172;
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache173 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache173 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.set_m_firstDamageTurn);
		}
		LuaObject.addMember(l, name60, get60, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache173, true);
		string name61 = "m_satisfyConditions";
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache174 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache174 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.get_m_satisfyConditions);
		}
		LuaCSFunction get61 = Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache174;
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache175 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache175 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.set_m_satisfyConditions);
		}
		LuaObject.addMember(l, name61, get61, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache175, true);
		string name62 = "m_actionCount";
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache176 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache176 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.get_m_actionCount);
		}
		LuaCSFunction get62 = Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache176;
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache177 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache177 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.set_m_actionCount);
		}
		LuaObject.addMember(l, name62, get62, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache177, true);
		string name63 = "m_combatAttackCount";
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache178 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache178 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.get_m_combatAttackCount);
		}
		LuaCSFunction get63 = Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache178;
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache179 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache179 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.set_m_combatAttackCount);
		}
		LuaObject.addMember(l, name63, get63, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache179, true);
		string name64 = "m_beCombatAttackCount";
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache17A == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache17A = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.get_m_beCombatAttackCount);
		}
		LuaCSFunction get64 = Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache17A;
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache17B == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache17B = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.set_m_beCombatAttackCount);
		}
		LuaObject.addMember(l, name64, get64, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache17B, true);
		string name65 = "m_useSkillCount";
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache17C == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache17C = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.get_m_useSkillCount);
		}
		LuaCSFunction get65 = Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache17C;
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache17D == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache17D = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.set_m_useSkillCount);
		}
		LuaObject.addMember(l, name65, get65, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache17D, true);
		string name66 = "m_killActorCount";
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache17E == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache17E = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.get_m_killActorCount);
		}
		LuaCSFunction get66 = Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache17E;
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache17F == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache17F = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.set_m_killActorCount);
		}
		LuaObject.addMember(l, name66, get66, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache17F, true);
		string name67 = "m_dieTurn";
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache180 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache180 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.get_m_dieTurn);
		}
		LuaCSFunction get67 = Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache180;
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache181 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache181 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.set_m_dieTurn);
		}
		LuaObject.addMember(l, name67, get67, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache181, true);
		string name68 = "m_deathAnimType";
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache182 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache182 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.get_m_deathAnimType);
		}
		LuaCSFunction get68 = Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache182;
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache183 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache183 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.set_m_deathAnimType);
		}
		LuaObject.addMember(l, name68, get68, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache183, true);
		string name69 = "m_executedCommandTypes";
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache184 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache184 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.get_m_executedCommandTypes);
		}
		LuaCSFunction get69 = Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache184;
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache185 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache185 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.set_m_executedCommandTypes);
		}
		LuaObject.addMember(l, name69, get69, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache185, true);
		string name70 = "m_executedSkillInfo";
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache186 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache186 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.get_m_executedSkillInfo);
		}
		LuaCSFunction get70 = Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache186;
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache187 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache187 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.set_m_executedSkillInfo);
		}
		LuaObject.addMember(l, name70, get70, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache187, true);
		string name71 = "m_playerIndex";
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache188 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache188 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.get_m_playerIndex);
		}
		LuaCSFunction get71 = Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache188;
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache189 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache189 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.set_m_playerIndex);
		}
		LuaObject.addMember(l, name71, get71, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache189, true);
		string name72 = "m_curBehaviorCfg";
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache18A == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache18A = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.get_m_curBehaviorCfg);
		}
		LuaCSFunction get72 = Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache18A;
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache18B == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache18B = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.set_m_curBehaviorCfg);
		}
		LuaObject.addMember(l, name72, get72, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache18B, true);
		string name73 = "m_curBehaviorState";
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache18C == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache18C = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.get_m_curBehaviorState);
		}
		LuaCSFunction get73 = Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache18C;
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache18D == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache18D = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.set_m_curBehaviorState);
		}
		LuaObject.addMember(l, name73, get73, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache18D, true);
		string name74 = "m_moveTarget";
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache18E == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache18E = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.get_m_moveTarget);
		}
		LuaCSFunction get74 = Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache18E;
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache18F == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache18F = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.set_m_moveTarget);
		}
		LuaObject.addMember(l, name74, get74, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache18F, true);
		string name75 = "m_attackTarget";
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache190 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache190 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.get_m_attackTarget);
		}
		LuaCSFunction get75 = Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache190;
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache191 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache191 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.set_m_attackTarget);
		}
		LuaObject.addMember(l, name75, get75, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache191, true);
		string name76 = "m_attackSkillIndex";
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache192 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache192 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.get_m_attackSkillIndex);
		}
		LuaCSFunction get76 = Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache192;
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache193 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache193 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.set_m_attackSkillIndex);
		}
		LuaObject.addMember(l, name76, get76, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache193, true);
		string name77 = "m_beAttackedCountOfTurns";
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache194 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache194 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.get_m_beAttackedCountOfTurns);
		}
		LuaCSFunction get77 = Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache194;
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache195 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache195 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.set_m_beAttackedCountOfTurns);
		}
		LuaObject.addMember(l, name77, get77, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache195, true);
		string name78 = "m_groupId";
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache196 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache196 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.get_m_groupId);
		}
		LuaCSFunction get78 = Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache196;
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache197 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache197 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.set_m_groupId);
		}
		LuaObject.addMember(l, name78, get78, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache197, true);
		string name79 = "m_aiCreateBattleCommandCount";
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache198 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache198 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.get_m_aiCreateBattleCommandCount);
		}
		LuaCSFunction get79 = Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache198;
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache199 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache199 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.set_m_aiCreateBattleCommandCount);
		}
		LuaObject.addMember(l, name79, get79, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache199, true);
		string name80 = "m_healSkillTargetHPThresh";
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache19A == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache19A = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.get_m_healSkillTargetHPThresh);
		}
		LuaObject.addMember(l, name80, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache19A, null, false);
		string name81 = "Position";
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache19B == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache19B = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.get_Position);
		}
		LuaObject.addMember(l, name81, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache19B, null, true);
		string name82 = "InitPosition";
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache19C == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache19C = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.get_InitPosition);
		}
		LuaObject.addMember(l, name82, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache19C, null, true);
		string name83 = "Direction";
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache19D == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache19D = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.get_Direction);
		}
		LuaObject.addMember(l, name83, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache19D, null, true);
		string name84 = "Battle";
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache19E == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache19E = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.get_Battle);
		}
		LuaObject.addMember(l, name84, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache19E, null, true);
		string name85 = "Team";
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache19F == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache19F = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.get_Team);
		}
		LuaObject.addMember(l, name85, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache19F, null, true);
		string name86 = "TeamNumber";
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache1A0 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache1A0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.get_TeamNumber);
		}
		LuaObject.addMember(l, name86, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache1A0, null, true);
		string name87 = "HeroBattleProperty";
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache1A1 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache1A1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.get_HeroBattleProperty);
		}
		LuaObject.addMember(l, name87, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache1A1, null, true);
		string name88 = "SoldierBattleProperty";
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache1A2 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache1A2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.get_SoldierBattleProperty);
		}
		LuaObject.addMember(l, name88, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache1A2, null, true);
		string name89 = "HeroHealthPoint";
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache1A3 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache1A3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.get_HeroHealthPoint);
		}
		LuaObject.addMember(l, name89, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache1A3, null, true);
		string name90 = "SoldierTotalHealthPoint";
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache1A4 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache1A4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.get_SoldierTotalHealthPoint);
		}
		LuaObject.addMember(l, name90, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache1A4, null, true);
		string name91 = "SoldierSingleHealthPointMax";
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache1A5 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache1A5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.get_SoldierSingleHealthPointMax);
		}
		LuaObject.addMember(l, name91, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache1A5, null, true);
		string name92 = "FightTags";
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache1A6 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache1A6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.get_FightTags);
		}
		LuaObject.addMember(l, name92, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache1A6, null, true);
		string name93 = "HeroLevel";
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache1A7 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache1A7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.get_HeroLevel);
		}
		LuaObject.addMember(l, name93, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache1A7, null, true);
		string name94 = "HeroStar";
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache1A8 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache1A8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.get_HeroStar);
		}
		LuaObject.addMember(l, name94, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache1A8, null, true);
		string name95 = "JobLevel";
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache1A9 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache1A9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.get_JobLevel);
		}
		LuaObject.addMember(l, name95, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache1A9, null, true);
		string name96 = "ActionValue";
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache1AA == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache1AA = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.get_ActionValue);
		}
		LuaCSFunction get80 = Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache1AA;
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache1AB == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache1AB = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.set_ActionValue);
		}
		LuaObject.addMember(l, name96, get80, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache1AB, true);
		string name97 = "HeroInfo";
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache1AC == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache1AC = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.get_HeroInfo);
		}
		LuaObject.addMember(l, name97, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache1AC, null, true);
		string name98 = "HeroId";
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache1AD == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache1AD = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.get_HeroId);
		}
		LuaObject.addMember(l, name98, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache1AD, null, true);
		string name99 = "HeroArmyInfo";
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache1AE == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache1AE = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.get_HeroArmyInfo);
		}
		LuaObject.addMember(l, name99, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache1AE, null, true);
		string name100 = "HeroArmyId";
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache1AF == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache1AF = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.get_HeroArmyId);
		}
		LuaObject.addMember(l, name100, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache1AF, null, true);
		string name101 = "JobConnectionInfo";
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache1B0 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache1B0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.get_JobConnectionInfo);
		}
		LuaObject.addMember(l, name101, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache1B0, null, true);
		string name102 = "JobInfo";
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache1B1 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache1B1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.get_JobInfo);
		}
		LuaObject.addMember(l, name102, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache1B1, null, true);
		string name103 = "SoldierInfo";
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache1B2 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache1B2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.get_SoldierInfo);
		}
		LuaObject.addMember(l, name103, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache1B2, null, true);
		string name104 = "SoldierArmyInfo";
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache1B3 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache1B3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.get_SoldierArmyInfo);
		}
		LuaObject.addMember(l, name104, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache1B3, null, true);
		string name105 = "HeroCharImageSkinResourceInfo";
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache1B4 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache1B4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.get_HeroCharImageSkinResourceInfo);
		}
		LuaObject.addMember(l, name105, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache1B4, null, true);
		string name106 = "HeroModelSkinResourceInfo";
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache1B5 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache1B5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.get_HeroModelSkinResourceInfo);
		}
		LuaObject.addMember(l, name106, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache1B5, null, true);
		string name107 = "SoldierModelSkinResourceInfo";
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache1B6 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache1B6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.get_SoldierModelSkinResourceInfo);
		}
		LuaObject.addMember(l, name107, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache1B6, null, true);
		string name108 = "PlayerIndex";
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache1B7 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache1B7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.get_PlayerIndex);
		}
		LuaObject.addMember(l, name108, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache1B7, null, true);
		string name109 = "Group";
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache1B8 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache1B8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.get_Group);
		}
		LuaCSFunction get81 = Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache1B8;
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache1B9 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache1B9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.set_Group);
		}
		LuaObject.addMember(l, name109, get81, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache1B9, true);
		string name110 = "GroupId";
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache1BA == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache1BA = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.get_GroupId);
		}
		LuaObject.addMember(l, name110, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache1BA, null, true);
		string name111 = "IsAttackedByEnemy";
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache1BB == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache1BB = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.get_IsAttackedByEnemy);
		}
		LuaObject.addMember(l, name111, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache1BB, null, true);
		string name112 = "IsAttackedByEnemyInLastTrun";
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache1BC == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache1BC = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.get_IsAttackedByEnemyInLastTrun);
		}
		LuaObject.addMember(l, name112, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache1BC, null, true);
		string name113 = "InstanceID";
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache1BD == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache1BD = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.get_InstanceID);
		}
		LuaObject.addMember(l, name113, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache1BD, null, true);
		string name114 = "NextBehaviorByChangeRules";
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache1BE == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache1BE = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.get_NextBehaviorByChangeRules);
		}
		LuaObject.addMember(l, name114, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache1BE, null, true);
		string name115 = "TotalHPPercent";
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache1BF == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache1BF = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.get_TotalHPPercent);
		}
		LuaObject.addMember(l, name115, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache1BF, null, true);
		string name116 = "BehaviorSelectSkillInfo";
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache1C0 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache1C0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.get_BehaviorSelectSkillInfo);
		}
		LuaObject.addMember(l, name116, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache1C0, null, true);
		if (Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache1C1 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache1C1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActor.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Battle_BattleActor.<>f__mg$cache1C1, typeof(BattleActor), typeof(Entity));
	}

	// Token: 0x0400D6EC RID: 55020
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400D6ED RID: 55021
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400D6EE RID: 55022
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400D6EF RID: 55023
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400D6F0 RID: 55024
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400D6F1 RID: 55025
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400D6F2 RID: 55026
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400D6F3 RID: 55027
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400D6F4 RID: 55028
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400D6F5 RID: 55029
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400D6F6 RID: 55030
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400D6F7 RID: 55031
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400D6F8 RID: 55032
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400D6F9 RID: 55033
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400D6FA RID: 55034
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400D6FB RID: 55035
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400D6FC RID: 55036
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400D6FD RID: 55037
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400D6FE RID: 55038
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400D6FF RID: 55039
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400D700 RID: 55040
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400D701 RID: 55041
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400D702 RID: 55042
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400D703 RID: 55043
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400D704 RID: 55044
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400D705 RID: 55045
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0400D706 RID: 55046
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0400D707 RID: 55047
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0400D708 RID: 55048
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0400D709 RID: 55049
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0400D70A RID: 55050
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0400D70B RID: 55051
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0400D70C RID: 55052
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0400D70D RID: 55053
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0400D70E RID: 55054
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0400D70F RID: 55055
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0400D710 RID: 55056
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0400D711 RID: 55057
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0400D712 RID: 55058
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0400D713 RID: 55059
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0400D714 RID: 55060
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x0400D715 RID: 55061
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x0400D716 RID: 55062
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x0400D717 RID: 55063
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x0400D718 RID: 55064
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x0400D719 RID: 55065
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x0400D71A RID: 55066
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x0400D71B RID: 55067
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x0400D71C RID: 55068
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x0400D71D RID: 55069
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x0400D71E RID: 55070
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x0400D71F RID: 55071
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x0400D720 RID: 55072
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x0400D721 RID: 55073
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x0400D722 RID: 55074
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x0400D723 RID: 55075
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x0400D724 RID: 55076
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x0400D725 RID: 55077
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x0400D726 RID: 55078
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x0400D727 RID: 55079
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x0400D728 RID: 55080
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x0400D729 RID: 55081
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x0400D72A RID: 55082
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x0400D72B RID: 55083
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x0400D72C RID: 55084
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x0400D72D RID: 55085
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x0400D72E RID: 55086
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x0400D72F RID: 55087
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x0400D730 RID: 55088
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x0400D731 RID: 55089
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x0400D732 RID: 55090
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;

	// Token: 0x0400D733 RID: 55091
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache47;

	// Token: 0x0400D734 RID: 55092
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache48;

	// Token: 0x0400D735 RID: 55093
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache49;

	// Token: 0x0400D736 RID: 55094
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4A;

	// Token: 0x0400D737 RID: 55095
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4B;

	// Token: 0x0400D738 RID: 55096
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4C;

	// Token: 0x0400D739 RID: 55097
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4D;

	// Token: 0x0400D73A RID: 55098
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4E;

	// Token: 0x0400D73B RID: 55099
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4F;

	// Token: 0x0400D73C RID: 55100
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache50;

	// Token: 0x0400D73D RID: 55101
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache51;

	// Token: 0x0400D73E RID: 55102
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache52;

	// Token: 0x0400D73F RID: 55103
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache53;

	// Token: 0x0400D740 RID: 55104
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache54;

	// Token: 0x0400D741 RID: 55105
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache55;

	// Token: 0x0400D742 RID: 55106
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache56;

	// Token: 0x0400D743 RID: 55107
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache57;

	// Token: 0x0400D744 RID: 55108
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache58;

	// Token: 0x0400D745 RID: 55109
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache59;

	// Token: 0x0400D746 RID: 55110
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5A;

	// Token: 0x0400D747 RID: 55111
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5B;

	// Token: 0x0400D748 RID: 55112
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5C;

	// Token: 0x0400D749 RID: 55113
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5D;

	// Token: 0x0400D74A RID: 55114
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5E;

	// Token: 0x0400D74B RID: 55115
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5F;

	// Token: 0x0400D74C RID: 55116
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache60;

	// Token: 0x0400D74D RID: 55117
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache61;

	// Token: 0x0400D74E RID: 55118
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache62;

	// Token: 0x0400D74F RID: 55119
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache63;

	// Token: 0x0400D750 RID: 55120
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache64;

	// Token: 0x0400D751 RID: 55121
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache65;

	// Token: 0x0400D752 RID: 55122
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache66;

	// Token: 0x0400D753 RID: 55123
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache67;

	// Token: 0x0400D754 RID: 55124
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache68;

	// Token: 0x0400D755 RID: 55125
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache69;

	// Token: 0x0400D756 RID: 55126
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6A;

	// Token: 0x0400D757 RID: 55127
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6B;

	// Token: 0x0400D758 RID: 55128
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6C;

	// Token: 0x0400D759 RID: 55129
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6D;

	// Token: 0x0400D75A RID: 55130
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6E;

	// Token: 0x0400D75B RID: 55131
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6F;

	// Token: 0x0400D75C RID: 55132
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache70;

	// Token: 0x0400D75D RID: 55133
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache71;

	// Token: 0x0400D75E RID: 55134
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache72;

	// Token: 0x0400D75F RID: 55135
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache73;

	// Token: 0x0400D760 RID: 55136
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache74;

	// Token: 0x0400D761 RID: 55137
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache75;

	// Token: 0x0400D762 RID: 55138
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache76;

	// Token: 0x0400D763 RID: 55139
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache77;

	// Token: 0x0400D764 RID: 55140
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache78;

	// Token: 0x0400D765 RID: 55141
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache79;

	// Token: 0x0400D766 RID: 55142
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7A;

	// Token: 0x0400D767 RID: 55143
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7B;

	// Token: 0x0400D768 RID: 55144
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7C;

	// Token: 0x0400D769 RID: 55145
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7D;

	// Token: 0x0400D76A RID: 55146
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7E;

	// Token: 0x0400D76B RID: 55147
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7F;

	// Token: 0x0400D76C RID: 55148
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache80;

	// Token: 0x0400D76D RID: 55149
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache81;

	// Token: 0x0400D76E RID: 55150
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache82;

	// Token: 0x0400D76F RID: 55151
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache83;

	// Token: 0x0400D770 RID: 55152
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache84;

	// Token: 0x0400D771 RID: 55153
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache85;

	// Token: 0x0400D772 RID: 55154
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache86;

	// Token: 0x0400D773 RID: 55155
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache87;

	// Token: 0x0400D774 RID: 55156
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache88;

	// Token: 0x0400D775 RID: 55157
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache89;

	// Token: 0x0400D776 RID: 55158
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8A;

	// Token: 0x0400D777 RID: 55159
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8B;

	// Token: 0x0400D778 RID: 55160
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8C;

	// Token: 0x0400D779 RID: 55161
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8D;

	// Token: 0x0400D77A RID: 55162
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8E;

	// Token: 0x0400D77B RID: 55163
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8F;

	// Token: 0x0400D77C RID: 55164
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache90;

	// Token: 0x0400D77D RID: 55165
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache91;

	// Token: 0x0400D77E RID: 55166
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache92;

	// Token: 0x0400D77F RID: 55167
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache93;

	// Token: 0x0400D780 RID: 55168
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache94;

	// Token: 0x0400D781 RID: 55169
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache95;

	// Token: 0x0400D782 RID: 55170
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache96;

	// Token: 0x0400D783 RID: 55171
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache97;

	// Token: 0x0400D784 RID: 55172
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache98;

	// Token: 0x0400D785 RID: 55173
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache99;

	// Token: 0x0400D786 RID: 55174
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9A;

	// Token: 0x0400D787 RID: 55175
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9B;

	// Token: 0x0400D788 RID: 55176
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9C;

	// Token: 0x0400D789 RID: 55177
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9D;

	// Token: 0x0400D78A RID: 55178
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9E;

	// Token: 0x0400D78B RID: 55179
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9F;

	// Token: 0x0400D78C RID: 55180
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA0;

	// Token: 0x0400D78D RID: 55181
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA1;

	// Token: 0x0400D78E RID: 55182
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA2;

	// Token: 0x0400D78F RID: 55183
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA3;

	// Token: 0x0400D790 RID: 55184
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA4;

	// Token: 0x0400D791 RID: 55185
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA5;

	// Token: 0x0400D792 RID: 55186
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA6;

	// Token: 0x0400D793 RID: 55187
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA7;

	// Token: 0x0400D794 RID: 55188
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA8;

	// Token: 0x0400D795 RID: 55189
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA9;

	// Token: 0x0400D796 RID: 55190
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAA;

	// Token: 0x0400D797 RID: 55191
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAB;

	// Token: 0x0400D798 RID: 55192
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAC;

	// Token: 0x0400D799 RID: 55193
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAD;

	// Token: 0x0400D79A RID: 55194
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAE;

	// Token: 0x0400D79B RID: 55195
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAF;

	// Token: 0x0400D79C RID: 55196
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB0;

	// Token: 0x0400D79D RID: 55197
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB1;

	// Token: 0x0400D79E RID: 55198
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB2;

	// Token: 0x0400D79F RID: 55199
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB3;

	// Token: 0x0400D7A0 RID: 55200
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB4;

	// Token: 0x0400D7A1 RID: 55201
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB5;

	// Token: 0x0400D7A2 RID: 55202
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB6;

	// Token: 0x0400D7A3 RID: 55203
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB7;

	// Token: 0x0400D7A4 RID: 55204
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB8;

	// Token: 0x0400D7A5 RID: 55205
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB9;

	// Token: 0x0400D7A6 RID: 55206
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBA;

	// Token: 0x0400D7A7 RID: 55207
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBB;

	// Token: 0x0400D7A8 RID: 55208
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBC;

	// Token: 0x0400D7A9 RID: 55209
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBD;

	// Token: 0x0400D7AA RID: 55210
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBE;

	// Token: 0x0400D7AB RID: 55211
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheBF;

	// Token: 0x0400D7AC RID: 55212
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC0;

	// Token: 0x0400D7AD RID: 55213
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC1;

	// Token: 0x0400D7AE RID: 55214
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC2;

	// Token: 0x0400D7AF RID: 55215
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC3;

	// Token: 0x0400D7B0 RID: 55216
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC4;

	// Token: 0x0400D7B1 RID: 55217
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC5;

	// Token: 0x0400D7B2 RID: 55218
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC6;

	// Token: 0x0400D7B3 RID: 55219
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC7;

	// Token: 0x0400D7B4 RID: 55220
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC8;

	// Token: 0x0400D7B5 RID: 55221
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC9;

	// Token: 0x0400D7B6 RID: 55222
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCA;

	// Token: 0x0400D7B7 RID: 55223
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCB;

	// Token: 0x0400D7B8 RID: 55224
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCC;

	// Token: 0x0400D7B9 RID: 55225
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCD;

	// Token: 0x0400D7BA RID: 55226
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCE;

	// Token: 0x0400D7BB RID: 55227
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheCF;

	// Token: 0x0400D7BC RID: 55228
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD0;

	// Token: 0x0400D7BD RID: 55229
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD1;

	// Token: 0x0400D7BE RID: 55230
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD2;

	// Token: 0x0400D7BF RID: 55231
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD3;

	// Token: 0x0400D7C0 RID: 55232
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD4;

	// Token: 0x0400D7C1 RID: 55233
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD5;

	// Token: 0x0400D7C2 RID: 55234
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD6;

	// Token: 0x0400D7C3 RID: 55235
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD7;

	// Token: 0x0400D7C4 RID: 55236
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD8;

	// Token: 0x0400D7C5 RID: 55237
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD9;

	// Token: 0x0400D7C6 RID: 55238
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDA;

	// Token: 0x0400D7C7 RID: 55239
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDB;

	// Token: 0x0400D7C8 RID: 55240
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDC;

	// Token: 0x0400D7C9 RID: 55241
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDD;

	// Token: 0x0400D7CA RID: 55242
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDE;

	// Token: 0x0400D7CB RID: 55243
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheDF;

	// Token: 0x0400D7CC RID: 55244
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE0;

	// Token: 0x0400D7CD RID: 55245
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE1;

	// Token: 0x0400D7CE RID: 55246
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE2;

	// Token: 0x0400D7CF RID: 55247
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE3;

	// Token: 0x0400D7D0 RID: 55248
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE4;

	// Token: 0x0400D7D1 RID: 55249
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE5;

	// Token: 0x0400D7D2 RID: 55250
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE6;

	// Token: 0x0400D7D3 RID: 55251
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE7;

	// Token: 0x0400D7D4 RID: 55252
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE8;

	// Token: 0x0400D7D5 RID: 55253
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE9;

	// Token: 0x0400D7D6 RID: 55254
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheEA;

	// Token: 0x0400D7D7 RID: 55255
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheEB;

	// Token: 0x0400D7D8 RID: 55256
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheEC;

	// Token: 0x0400D7D9 RID: 55257
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheED;

	// Token: 0x0400D7DA RID: 55258
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheEE;

	// Token: 0x0400D7DB RID: 55259
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheEF;

	// Token: 0x0400D7DC RID: 55260
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF0;

	// Token: 0x0400D7DD RID: 55261
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF1;

	// Token: 0x0400D7DE RID: 55262
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF2;

	// Token: 0x0400D7DF RID: 55263
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF3;

	// Token: 0x0400D7E0 RID: 55264
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF4;

	// Token: 0x0400D7E1 RID: 55265
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF5;

	// Token: 0x0400D7E2 RID: 55266
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF6;

	// Token: 0x0400D7E3 RID: 55267
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF7;

	// Token: 0x0400D7E4 RID: 55268
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF8;

	// Token: 0x0400D7E5 RID: 55269
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF9;

	// Token: 0x0400D7E6 RID: 55270
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheFA;

	// Token: 0x0400D7E7 RID: 55271
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheFB;

	// Token: 0x0400D7E8 RID: 55272
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheFC;

	// Token: 0x0400D7E9 RID: 55273
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheFD;

	// Token: 0x0400D7EA RID: 55274
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheFE;

	// Token: 0x0400D7EB RID: 55275
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheFF;

	// Token: 0x0400D7EC RID: 55276
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache100;

	// Token: 0x0400D7ED RID: 55277
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache101;

	// Token: 0x0400D7EE RID: 55278
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache102;

	// Token: 0x0400D7EF RID: 55279
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache103;

	// Token: 0x0400D7F0 RID: 55280
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache104;

	// Token: 0x0400D7F1 RID: 55281
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache105;

	// Token: 0x0400D7F2 RID: 55282
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache106;

	// Token: 0x0400D7F3 RID: 55283
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache107;

	// Token: 0x0400D7F4 RID: 55284
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache108;

	// Token: 0x0400D7F5 RID: 55285
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache109;

	// Token: 0x0400D7F6 RID: 55286
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10A;

	// Token: 0x0400D7F7 RID: 55287
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10B;

	// Token: 0x0400D7F8 RID: 55288
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10C;

	// Token: 0x0400D7F9 RID: 55289
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10D;

	// Token: 0x0400D7FA RID: 55290
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10E;

	// Token: 0x0400D7FB RID: 55291
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10F;

	// Token: 0x0400D7FC RID: 55292
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache110;

	// Token: 0x0400D7FD RID: 55293
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache111;

	// Token: 0x0400D7FE RID: 55294
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache112;

	// Token: 0x0400D7FF RID: 55295
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache113;

	// Token: 0x0400D800 RID: 55296
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache114;

	// Token: 0x0400D801 RID: 55297
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache115;

	// Token: 0x0400D802 RID: 55298
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache116;

	// Token: 0x0400D803 RID: 55299
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache117;

	// Token: 0x0400D804 RID: 55300
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache118;

	// Token: 0x0400D805 RID: 55301
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache119;

	// Token: 0x0400D806 RID: 55302
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11A;

	// Token: 0x0400D807 RID: 55303
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11B;

	// Token: 0x0400D808 RID: 55304
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11C;

	// Token: 0x0400D809 RID: 55305
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11D;

	// Token: 0x0400D80A RID: 55306
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11E;

	// Token: 0x0400D80B RID: 55307
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11F;

	// Token: 0x0400D80C RID: 55308
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache120;

	// Token: 0x0400D80D RID: 55309
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache121;

	// Token: 0x0400D80E RID: 55310
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache122;

	// Token: 0x0400D80F RID: 55311
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache123;

	// Token: 0x0400D810 RID: 55312
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache124;

	// Token: 0x0400D811 RID: 55313
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache125;

	// Token: 0x0400D812 RID: 55314
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache126;

	// Token: 0x0400D813 RID: 55315
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache127;

	// Token: 0x0400D814 RID: 55316
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache128;

	// Token: 0x0400D815 RID: 55317
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache129;

	// Token: 0x0400D816 RID: 55318
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12A;

	// Token: 0x0400D817 RID: 55319
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12B;

	// Token: 0x0400D818 RID: 55320
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12C;

	// Token: 0x0400D819 RID: 55321
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12D;

	// Token: 0x0400D81A RID: 55322
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12E;

	// Token: 0x0400D81B RID: 55323
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12F;

	// Token: 0x0400D81C RID: 55324
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache130;

	// Token: 0x0400D81D RID: 55325
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache131;

	// Token: 0x0400D81E RID: 55326
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache132;

	// Token: 0x0400D81F RID: 55327
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache133;

	// Token: 0x0400D820 RID: 55328
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache134;

	// Token: 0x0400D821 RID: 55329
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache135;

	// Token: 0x0400D822 RID: 55330
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache136;

	// Token: 0x0400D823 RID: 55331
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache137;

	// Token: 0x0400D824 RID: 55332
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache138;

	// Token: 0x0400D825 RID: 55333
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache139;

	// Token: 0x0400D826 RID: 55334
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13A;

	// Token: 0x0400D827 RID: 55335
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13B;

	// Token: 0x0400D828 RID: 55336
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13C;

	// Token: 0x0400D829 RID: 55337
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13D;

	// Token: 0x0400D82A RID: 55338
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13E;

	// Token: 0x0400D82B RID: 55339
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13F;

	// Token: 0x0400D82C RID: 55340
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache140;

	// Token: 0x0400D82D RID: 55341
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache141;

	// Token: 0x0400D82E RID: 55342
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache142;

	// Token: 0x0400D82F RID: 55343
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache143;

	// Token: 0x0400D830 RID: 55344
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache144;

	// Token: 0x0400D831 RID: 55345
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache145;

	// Token: 0x0400D832 RID: 55346
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache146;

	// Token: 0x0400D833 RID: 55347
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache147;

	// Token: 0x0400D834 RID: 55348
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache148;

	// Token: 0x0400D835 RID: 55349
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache149;

	// Token: 0x0400D836 RID: 55350
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14A;

	// Token: 0x0400D837 RID: 55351
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14B;

	// Token: 0x0400D838 RID: 55352
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14C;

	// Token: 0x0400D839 RID: 55353
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14D;

	// Token: 0x0400D83A RID: 55354
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14E;

	// Token: 0x0400D83B RID: 55355
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14F;

	// Token: 0x0400D83C RID: 55356
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache150;

	// Token: 0x0400D83D RID: 55357
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache151;

	// Token: 0x0400D83E RID: 55358
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache152;

	// Token: 0x0400D83F RID: 55359
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache153;

	// Token: 0x0400D840 RID: 55360
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache154;

	// Token: 0x0400D841 RID: 55361
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache155;

	// Token: 0x0400D842 RID: 55362
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache156;

	// Token: 0x0400D843 RID: 55363
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache157;

	// Token: 0x0400D844 RID: 55364
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache158;

	// Token: 0x0400D845 RID: 55365
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache159;

	// Token: 0x0400D846 RID: 55366
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15A;

	// Token: 0x0400D847 RID: 55367
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15B;

	// Token: 0x0400D848 RID: 55368
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15C;

	// Token: 0x0400D849 RID: 55369
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15D;

	// Token: 0x0400D84A RID: 55370
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15E;

	// Token: 0x0400D84B RID: 55371
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15F;

	// Token: 0x0400D84C RID: 55372
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache160;

	// Token: 0x0400D84D RID: 55373
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache161;

	// Token: 0x0400D84E RID: 55374
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache162;

	// Token: 0x0400D84F RID: 55375
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache163;

	// Token: 0x0400D850 RID: 55376
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache164;

	// Token: 0x0400D851 RID: 55377
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache165;

	// Token: 0x0400D852 RID: 55378
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache166;

	// Token: 0x0400D853 RID: 55379
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache167;

	// Token: 0x0400D854 RID: 55380
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache168;

	// Token: 0x0400D855 RID: 55381
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache169;

	// Token: 0x0400D856 RID: 55382
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16A;

	// Token: 0x0400D857 RID: 55383
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16B;

	// Token: 0x0400D858 RID: 55384
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16C;

	// Token: 0x0400D859 RID: 55385
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16D;

	// Token: 0x0400D85A RID: 55386
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16E;

	// Token: 0x0400D85B RID: 55387
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16F;

	// Token: 0x0400D85C RID: 55388
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache170;

	// Token: 0x0400D85D RID: 55389
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache171;

	// Token: 0x0400D85E RID: 55390
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache172;

	// Token: 0x0400D85F RID: 55391
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache173;

	// Token: 0x0400D860 RID: 55392
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache174;

	// Token: 0x0400D861 RID: 55393
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache175;

	// Token: 0x0400D862 RID: 55394
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache176;

	// Token: 0x0400D863 RID: 55395
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache177;

	// Token: 0x0400D864 RID: 55396
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache178;

	// Token: 0x0400D865 RID: 55397
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache179;

	// Token: 0x0400D866 RID: 55398
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17A;

	// Token: 0x0400D867 RID: 55399
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17B;

	// Token: 0x0400D868 RID: 55400
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17C;

	// Token: 0x0400D869 RID: 55401
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17D;

	// Token: 0x0400D86A RID: 55402
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17E;

	// Token: 0x0400D86B RID: 55403
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17F;

	// Token: 0x0400D86C RID: 55404
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache180;

	// Token: 0x0400D86D RID: 55405
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache181;

	// Token: 0x0400D86E RID: 55406
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache182;

	// Token: 0x0400D86F RID: 55407
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache183;

	// Token: 0x0400D870 RID: 55408
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache184;

	// Token: 0x0400D871 RID: 55409
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache185;

	// Token: 0x0400D872 RID: 55410
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache186;

	// Token: 0x0400D873 RID: 55411
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache187;

	// Token: 0x0400D874 RID: 55412
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache188;

	// Token: 0x0400D875 RID: 55413
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache189;

	// Token: 0x0400D876 RID: 55414
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18A;

	// Token: 0x0400D877 RID: 55415
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18B;

	// Token: 0x0400D878 RID: 55416
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18C;

	// Token: 0x0400D879 RID: 55417
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18D;

	// Token: 0x0400D87A RID: 55418
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18E;

	// Token: 0x0400D87B RID: 55419
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18F;

	// Token: 0x0400D87C RID: 55420
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache190;

	// Token: 0x0400D87D RID: 55421
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache191;

	// Token: 0x0400D87E RID: 55422
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache192;

	// Token: 0x0400D87F RID: 55423
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache193;

	// Token: 0x0400D880 RID: 55424
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache194;

	// Token: 0x0400D881 RID: 55425
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache195;

	// Token: 0x0400D882 RID: 55426
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache196;

	// Token: 0x0400D883 RID: 55427
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache197;

	// Token: 0x0400D884 RID: 55428
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache198;

	// Token: 0x0400D885 RID: 55429
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache199;

	// Token: 0x0400D886 RID: 55430
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19A;

	// Token: 0x0400D887 RID: 55431
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19B;

	// Token: 0x0400D888 RID: 55432
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19C;

	// Token: 0x0400D889 RID: 55433
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19D;

	// Token: 0x0400D88A RID: 55434
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19E;

	// Token: 0x0400D88B RID: 55435
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19F;

	// Token: 0x0400D88C RID: 55436
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A0;

	// Token: 0x0400D88D RID: 55437
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A1;

	// Token: 0x0400D88E RID: 55438
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A2;

	// Token: 0x0400D88F RID: 55439
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A3;

	// Token: 0x0400D890 RID: 55440
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A4;

	// Token: 0x0400D891 RID: 55441
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A5;

	// Token: 0x0400D892 RID: 55442
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A6;

	// Token: 0x0400D893 RID: 55443
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A7;

	// Token: 0x0400D894 RID: 55444
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A8;

	// Token: 0x0400D895 RID: 55445
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A9;

	// Token: 0x0400D896 RID: 55446
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1AA;

	// Token: 0x0400D897 RID: 55447
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1AB;

	// Token: 0x0400D898 RID: 55448
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1AC;

	// Token: 0x0400D899 RID: 55449
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1AD;

	// Token: 0x0400D89A RID: 55450
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1AE;

	// Token: 0x0400D89B RID: 55451
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1AF;

	// Token: 0x0400D89C RID: 55452
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B0;

	// Token: 0x0400D89D RID: 55453
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B1;

	// Token: 0x0400D89E RID: 55454
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B2;

	// Token: 0x0400D89F RID: 55455
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B3;

	// Token: 0x0400D8A0 RID: 55456
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B4;

	// Token: 0x0400D8A1 RID: 55457
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B5;

	// Token: 0x0400D8A2 RID: 55458
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B6;

	// Token: 0x0400D8A3 RID: 55459
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B7;

	// Token: 0x0400D8A4 RID: 55460
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B8;

	// Token: 0x0400D8A5 RID: 55461
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B9;

	// Token: 0x0400D8A6 RID: 55462
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1BA;

	// Token: 0x0400D8A7 RID: 55463
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1BB;

	// Token: 0x0400D8A8 RID: 55464
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1BC;

	// Token: 0x0400D8A9 RID: 55465
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1BD;

	// Token: 0x0400D8AA RID: 55466
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1BE;

	// Token: 0x0400D8AB RID: 55467
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1BF;

	// Token: 0x0400D8AC RID: 55468
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C0;

	// Token: 0x0400D8AD RID: 55469
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C1;
}
