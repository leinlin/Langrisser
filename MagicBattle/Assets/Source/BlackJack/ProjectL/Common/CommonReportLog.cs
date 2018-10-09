using System;
using System.Collections.Generic;
using System.Text;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Battle;
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x02000408 RID: 1032
	[CustomLuaClass]
	public class CommonReportLog
	{
		// Token: 0x06003C60 RID: 15456 RVA: 0x00111ED0 File Offset: 0x001100D0
		public static string RandomEventLevelZonesReportLog(List<RandomEventLevelZone> zones, string logHeader)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendLine();
			string value = string.Format("{0}_{1} LevelZone Begin###############", CommonReportLog.RandomEventFunctionHeader, logHeader);
			stringBuilder.AppendLine(value);
			for (int i = 0; i < zones.Count; i++)
			{
				stringBuilder.AppendLine(CommonReportLog.RandomEventLevelZoneReportLog(zones[i], logHeader + i.ToString()));
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06003C61 RID: 15457 RVA: 0x00111F48 File Offset: 0x00110148
		public static string RandomEventLevelZoneReportLog(RandomEventLevelZone zone, string zoneName)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendLine();
			string value = string.Format("{0}_{1} LevelZoneId = {2}###############", CommonReportLog.RandomEventFunctionHeader, zoneName, zone.LevelZoneId);
			stringBuilder.AppendLine(value);
			foreach (RandomEventGroup group in zone.Groups.Values)
			{
				stringBuilder.AppendLine(CommonReportLog.Message(group));
			}
			stringBuilder.AppendLine();
			return stringBuilder.ToString();
		}

		// Token: 0x06003C62 RID: 15458 RVA: 0x00111FF0 File Offset: 0x001101F0
		private static string Message(RandomEventGroup group)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendFormat("Index = {0}, ", group.Index);
			stringBuilder.AppendFormat("Nums = {0}, ", group.Nums);
			stringBuilder.AppendFormat("MaxNums = {0}", group.MaxNums);
			return stringBuilder.ToString();
		}

		// Token: 0x06003C63 RID: 15459 RVA: 0x00112050 File Offset: 0x00110250
		public static string RandomEventsReportLog(List<RandomEvent> randomEvents, string optionType)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendLine();
			string value = string.Format("{0}_{1} All RandomEvent Data Begin###############", CommonReportLog.RandomEventFunctionHeader, optionType);
			stringBuilder.AppendLine(value);
			for (int i = 0; i < randomEvents.Count; i++)
			{
				stringBuilder.AppendLine(CommonReportLog.RandomEventReportLog(randomEvents[i], optionType));
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06003C64 RID: 15460 RVA: 0x001120B4 File Offset: 0x001102B4
		public static string RandomEventReportLog(RandomEvent randomEvent, string optionType)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendLine();
			string value = string.Format("{0}_{1} RandomEvent Data###############", CommonReportLog.RandomEventFunctionHeader, optionType);
			stringBuilder.AppendLine(value);
			stringBuilder.AppendFormat("RandomEventId = {0}, ", randomEvent.EventId);
			stringBuilder.AppendFormat("WayPointId = {0}, ", randomEvent.WayPointId);
			stringBuilder.AppendFormat("Lives = {0}, ", randomEvent.Lives);
			stringBuilder.AppendFormat("ExpiredTime = {0}", new DateTime(randomEvent.ExpiredTime));
			return stringBuilder.ToString();
		}

		// Token: 0x06003C65 RID: 15461 RVA: 0x00112150 File Offset: 0x00110350
		public static string IntListReportLog(List<int> list, string listName)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendFormat("{0} : ", listName);
			foreach (int num in list)
			{
				stringBuilder.AppendFormat("{0} ", num);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06003C66 RID: 15462 RVA: 0x001121CC File Offset: 0x001103CC
		public static string InitDictionary(Dictionary<int, int> dict, string dictName)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendFormat("{0} : ", dictName);
			foreach (KeyValuePair<int, int> keyValuePair in dict)
			{
				stringBuilder.AppendFormat("[{0} = {1}] ", keyValuePair.Key, keyValuePair.Value);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06003C67 RID: 15463 RVA: 0x0011225C File Offset: 0x0011045C
		public static string StringDictionaryReportLog(Dictionary<string, int> dict)
		{
			if (dict.Count == 0)
			{
				return "null";
			}
			StringBuilder stringBuilder = new StringBuilder();
			foreach (KeyValuePair<string, int> keyValuePair in dict)
			{
				stringBuilder.AppendFormat("{0}:{1};", keyValuePair.Key, keyValuePair.Value);
			}
			string text = stringBuilder.ToString();
			if (text.EndsWith(";"))
			{
				return text.Remove(text.Length - 1);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06003C68 RID: 15464 RVA: 0x00112310 File Offset: 0x00110510
		public static string WayPointReportLog(List<ConfigDataWaypointInfo> wayPointInfos, Dictionary<int, WayPointStatus> wayPointStates, string functionType, string optionType, string selectStandard = "NULL")
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendLine();
			string value = string.Format("###############{0}_{1} SelectStandard = {2}############### : ", functionType, optionType, selectStandard);
			stringBuilder.AppendLine(value);
			foreach (ConfigDataWaypointInfo configDataWaypointInfo in wayPointInfos)
			{
				WayPointStatus wayPointStatus;
				if (wayPointStates.TryGetValue(configDataWaypointInfo.ID, out wayPointStatus))
				{
					stringBuilder.AppendFormat("WayPointId = {0}, FunctionType = {1}, CurrentStatus = {2}, Style = {3}", new object[]
					{
						configDataWaypointInfo.ID,
						configDataWaypointInfo.FuncType,
						wayPointStatus,
						configDataWaypointInfo.StyleType
					});
					stringBuilder.AppendLine();
				}
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06003C69 RID: 15465 RVA: 0x001123EC File Offset: 0x001105EC
		public static string BattleReport(BattleReportLog report, string owner)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendLine();
			stringBuilder.AppendFormat("########################{0} Battle Report Begin########################", owner);
			stringBuilder.AppendLine();
			stringBuilder.AppendFormat("UserId = {0}, PlayerName = {1}", report.UserId, report.PlayerName);
			stringBuilder.AppendLine();
			stringBuilder.AppendFormat("BattleType = {0}, BattleId = {1}, RandomNumberSeed = {2}, ArmyRandomNumberSeed = {3}", new object[]
			{
				report.Type,
				report.BattleId,
				report.RandomNumberSeed,
				report.ArmyRandomNumberSeed
			});
			stringBuilder.AppendLine();
			stringBuilder.Append(CommonReportLog.Message(report.MineTeam, "Mine"));
			stringBuilder.Append(CommonReportLog.Message(report.OpponentTeam, "Opponent"));
			stringBuilder.Append(CommonReportLog.Message(report.Players));
			stringBuilder.Append(CommonReportLog.Message(report.MineCommands, "Mine"));
			stringBuilder.Append(CommonReportLog.Message(report.CheckSums));
			if (report.OpponentCommands != null)
			{
				stringBuilder.AppendLine(CommonReportLog.Message(report.OpponentCommands, "Opponent"));
			}
			stringBuilder.AppendFormat("#######################{0} Battle Report End#######################", owner);
			return stringBuilder.ToString();
		}

		// Token: 0x06003C6A RID: 15466 RVA: 0x00112528 File Offset: 0x00110728
		public static string Message(List<BattleActorSetup> team, string teamName)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendFormat("***********************{0} Team Members Begin***********************", teamName);
			stringBuilder.AppendLine();
			for (int i = 0; i < team.Count; i++)
			{
				stringBuilder.AppendFormat("Member{0} : {1}", i, CommonReportLog.Message(team[i]));
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06003C6B RID: 15467 RVA: 0x0011258C File Offset: 0x0011078C
		private static string Message(BattleActorSetup actor)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendLine();
			stringBuilder.AppendFormat("HeroId = {0}, ", actor.HeroInfo.ID);
			stringBuilder.AppendFormat("HeroLevel = {0}, ", actor.HeroLevel);
			stringBuilder.AppendFormat("HeroStar = {0}, ", actor.HeroStar);
			stringBuilder.AppendFormat("JobConnectionId = {0}, ", actor.JobConnectionInfo.ID);
			stringBuilder.AppendFormat("JobLevel = {0}, ", actor.JobLevel);
			stringBuilder.AppendFormat("SoldierId = {0}, ", (actor.SoldierInfo != null) ? actor.SoldierInfo.ID : 0);
			stringBuilder.AppendFormat("HeroCharImageSkinResourceId = {0}, ", (actor.HeroCharImageSkinResourceInfo != null) ? actor.HeroCharImageSkinResourceInfo.ID : 0);
			stringBuilder.AppendFormat("HeroModelSkinResourceId = {0}, ", (actor.HeroModelSkinResourceInfo != null) ? actor.HeroModelSkinResourceInfo.ID : 0);
			stringBuilder.AppendFormat("SoldierModelSkinResourceId = {0}, ", (actor.SoldierModelSkinResourceInfo != null) ? actor.SoldierModelSkinResourceInfo.ID : 0);
			stringBuilder.AppendFormat("Position = ({0},{1}), ", actor.Position.x, actor.Position.y);
			stringBuilder.AppendFormat("IsNpc = {0}, ", actor.IsNpc);
			stringBuilder.AppendFormat("BehaviorId = {0}, ", actor.BehaviorId);
			stringBuilder.AppendFormat("GroupId = {0}, ", actor.GroupId);
			stringBuilder.AppendFormat("ActionValue = {0}, ", actor.ActionValue);
			stringBuilder.AppendFormat("ActorId = {0} ", actor.ActorId);
			stringBuilder.AppendFormat("PlayerIndex = {0} ", actor.PlayerIndex);
			stringBuilder.AppendLine();
			if (actor.SkillInfos != null)
			{
				stringBuilder.Append("Skills: ");
				foreach (ConfigDataSkillInfo configDataSkillInfo in actor.SkillInfos)
				{
					stringBuilder.AppendFormat("{0} ", configDataSkillInfo.ID);
				}
				stringBuilder.AppendLine();
			}
			if (actor.MasterJobInfos != null)
			{
				stringBuilder.Append("MasterJobs: ");
				foreach (ConfigDataJobInfo configDataJobInfo in actor.MasterJobInfos)
				{
					stringBuilder.AppendFormat("{0} ", configDataJobInfo.ID);
				}
				stringBuilder.AppendLine();
			}
			if (actor.Equipments != null)
			{
				stringBuilder.Append("Equipments: ");
				foreach (BattleActorEquipment battleActorEquipment in actor.Equipments)
				{
					stringBuilder.AppendFormat("{0}_{1} ", battleActorEquipment.EquipmentInfo.ID, battleActorEquipment.Level);
				}
				stringBuilder.AppendLine();
			}
			if (actor.ResonanceSkillInfos != null)
			{
				stringBuilder.Append("ResonanceSkills: ");
				foreach (ConfigDataSkillInfo configDataSkillInfo2 in actor.ResonanceSkillInfos)
				{
					stringBuilder.AppendFormat("{0} ", configDataSkillInfo2.ID);
				}
				stringBuilder.AppendLine();
			}
			if (actor.FetterSkillInfos != null)
			{
				stringBuilder.Append("FetterSkills: ");
				foreach (ConfigDataSkillInfo configDataSkillInfo3 in actor.FetterSkillInfos)
				{
					stringBuilder.AppendFormat("{0} ", configDataSkillInfo3.ID);
				}
				stringBuilder.AppendLine();
			}
			if (actor.ExtraPassiveSkillInfos != null)
			{
				stringBuilder.Append("ExtraPassiveSkills: ");
				foreach (ConfigDataSkillInfo configDataSkillInfo4 in actor.ExtraPassiveSkillInfos)
				{
					stringBuilder.AppendFormat("{0} ", configDataSkillInfo4.ID);
				}
				stringBuilder.AppendLine();
			}
			if (actor.ExtraTalentSkillInfo != null)
			{
				stringBuilder.AppendFormat("ExtraTalentSkill: {0}", actor.ExtraTalentSkillInfo.ID);
				stringBuilder.AppendLine();
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06003C6C RID: 15468 RVA: 0x00112A28 File Offset: 0x00110C28
		private static string Message(List<BattlePlayer> players)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendFormat("***********************Players Begin***********************", new object[0]);
			stringBuilder.AppendLine();
			for (int i = 0; i < players.Count; i++)
			{
				stringBuilder.AppendFormat("Players{0} : {1}", i, CommonReportLog.Message(players[i]));
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06003C6D RID: 15469 RVA: 0x00112A90 File Offset: 0x00110C90
		private static string Message(BattlePlayer player)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendLine();
			stringBuilder.AppendFormat("PlayerLevel = {0}, SessionId = {1}", player.PlayerLevel, player.SessionId);
			stringBuilder.AppendLine();
			if (player.TrainingTechs != null)
			{
				stringBuilder.Append("TrainingTechs: ");
				foreach (BattlePlayerTrainingTech battlePlayerTrainingTech in player.TrainingTechs)
				{
					stringBuilder.AppendFormat("{0}_{1} ", battlePlayerTrainingTech.TrainingTechInfo.ID, battlePlayerTrainingTech.Level);
				}
				stringBuilder.AppendLine();
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06003C6E RID: 15470 RVA: 0x00112B40 File Offset: 0x00110D40
		public static string BattleRoomBattle(BattleRoomBattleLog log, string owner)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendLine();
			stringBuilder.AppendFormat("########################{0} BattleRoomBattleLog Begin########################", owner);
			stringBuilder.AppendLine();
			stringBuilder.AppendFormat("RoomId = {0}, RoomType = {1}, BattleId = {2}, RandomNumberSeed = {3}, ArmyRandomNumberSeed = {4}", new object[]
			{
				log.RoomId,
				log.BattleRoomType,
				log.BattleId,
				log.RandomNumberSeed,
				log.ArmyRandomNumberSeed
			});
			stringBuilder.AppendLine();
			stringBuilder.Append(CommonReportLog.Message(log.Team0, "Team0"));
			stringBuilder.Append(CommonReportLog.Message(log.Team1, "Team1"));
			stringBuilder.Append(CommonReportLog.Message(log.Players));
			stringBuilder.AppendFormat("#######################{0} BattleRoomBattleLog End#######################", owner);
			return stringBuilder.ToString();
		}

		// Token: 0x06003C6F RID: 15471 RVA: 0x00112C20 File Offset: 0x00110E20
		public static string Message(List<BattleCommand> commands, string ownerName)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendFormat("***********************{0} Commands Begin***********************", ownerName);
			stringBuilder.AppendLine();
			for (int i = 0; i < commands.Count; i++)
			{
				stringBuilder.AppendFormat("Command{0}: {1}", i, CommonReportLog.Message(commands[i]));
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06003C70 RID: 15472 RVA: 0x00112C84 File Offset: 0x00110E84
		private static string Message(BattleCommand command)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendLine();
			stringBuilder.AppendFormat("CommandType = {0}, ", command.Type);
			stringBuilder.AppendFormat("Step = {0}, ", command.Step);
			stringBuilder.AppendFormat("ActorId = {0}, ", command.ActorId);
			stringBuilder.AppendFormat("Target1 Position = ({0},{1}), ", command.TargetPosition.x, command.TargetPosition.y);
			stringBuilder.AppendFormat("Target2 Position = ({0},{1})", command.TargetPosition2.x, command.TargetPosition2.y);
			stringBuilder.AppendLine();
			return stringBuilder.ToString();
		}

		// Token: 0x06003C71 RID: 15473 RVA: 0x00112D48 File Offset: 0x00110F48
		private static string Message(List<int> battleChecksums)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendFormat("***********************Checksum Begin***********************", new object[0]);
			stringBuilder.AppendLine();
			for (int i = 0; i < battleChecksums.Count; i++)
			{
				stringBuilder.AppendFormat("Step{0}: {1}", i, battleChecksums[i]);
				stringBuilder.AppendLine();
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06003C72 RID: 15474 RVA: 0x00112DB8 File Offset: 0x00110FB8
		public static string GoodsListReportLog(List<Goods> goodsList, string desc)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendFormat("{0} : {1}", desc, goodsList.Count);
			stringBuilder.AppendLine();
			stringBuilder.AppendLine("输出格式为：GoodsType,GoodsId,Nums");
			foreach (Goods goods in goodsList)
			{
				stringBuilder.AppendFormat("{0,-8},{1,-8},{2,-8}", (int)goods.GoodsType, goods.Id, goods.Count);
				stringBuilder.AppendLine();
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06003C73 RID: 15475 RVA: 0x00112E74 File Offset: 0x00111074
		public static string ProGoodsListReport(List<ProGoods> pbGoodsList, string desc)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendFormat("{0} : {1}", desc, pbGoodsList.Count);
			stringBuilder.AppendLine();
			foreach (ProGoods proGoods in pbGoodsList)
			{
				stringBuilder.AppendFormat("GoodsType = {0}, GoodsId = {1}, Nums = {2}, InstanceId = {3}", new object[]
				{
					proGoods.GoodsType,
					proGoods.Id,
					proGoods.Nums,
					proGoods.InstanceId
				});
				stringBuilder.AppendLine();
			}
			return stringBuilder.ToString();
		}

		// Token: 0x04002DEB RID: 11755
		private static string RandomEventFunctionHeader = "###############RandomEventFunction";
	}
}
