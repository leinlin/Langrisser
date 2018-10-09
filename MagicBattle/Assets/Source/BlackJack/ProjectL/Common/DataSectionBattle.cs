using System;
using System.Collections.Generic;
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x020004C2 RID: 1218
	[CustomLuaClass]
	public class DataSectionBattle : DataSection
	{
		// Token: 0x06004A7E RID: 19070 RVA: 0x0017444C File Offset: 0x0017264C
		public DataSectionBattle()
		{
			this.Teams = new Dictionary<int, List<int>>();
			this.ProcessingBattleInfo = new ProcessingBattle();
			this.GotBattleTreasureIds = new List<int>();
			this.DailyArmyRandomSeedDict = new Dictionary<int, int>();
			this.EveryTimeArmyRandomSeedDict = new Dictionary<int, int>();
			this.ArenaBattleStatus = ArenaBattleStatus.None;
			this.ArenaBattleId = int.MinValue;
			this.ArenaBattleRandomSeed = int.MinValue;
		}

		// Token: 0x06004A7F RID: 19071 RVA: 0x001744B4 File Offset: 0x001726B4
		public override void ClearInitedData()
		{
			this.Teams.Clear();
			this.GotBattleTreasureIds.Clear();
			this.ProcessingBattleInfo = new ProcessingBattle();
			this.DailyArmyRandomSeedDict.Clear();
			this.EveryTimeArmyRandomSeedDict.Clear();
		}

		// Token: 0x06004A80 RID: 19072 RVA: 0x001744F0 File Offset: 0x001726F0
		public override object SerializeToClient()
		{
			DSBattleNtf dsbattleNtf = new DSBattleNtf();
			dsbattleNtf.Version = (uint)base.Version;
			foreach (KeyValuePair<int, List<int>> keyValuePair in this.Teams)
			{
				ProTeam proTeam = new ProTeam();
				proTeam.BattleType = Convert.ToInt32(keyValuePair.Key);
				proTeam.Heroes.AddRange(keyValuePair.Value);
				dsbattleNtf.Teams.Add(proTeam);
			}
			dsbattleNtf.ProcessingBattleInfo = ProcessingBattle.BattleProcessingToPbBattleProcessing(this.ProcessingBattleInfo);
			dsbattleNtf.GotBattleTreasureIds.AddRange(this.GotBattleTreasureIds);
			dsbattleNtf.ArenaBattleStatus = (int)this.ArenaBattleStatus;
			dsbattleNtf.ArenaBattleId = this.ArenaBattleId;
			dsbattleNtf.ArenaBattleRandomSeed = this.ArenaBattleRandomSeed;
			dsbattleNtf.BattleRoomId = this.BattleRoomId;
			return dsbattleNtf;
		}

		// Token: 0x06004A81 RID: 19073 RVA: 0x001745E0 File Offset: 0x001727E0
		public void InitProcessingBattle(ProcessingBattle info)
		{
			this.ProcessingBattleInfo = info;
		}

		// Token: 0x06004A82 RID: 19074 RVA: 0x001745EC File Offset: 0x001727EC
		public void InitTeams(Dictionary<int, List<int>> teams)
		{
			this.Teams = new Dictionary<int, List<int>>(teams);
		}

		// Token: 0x06004A83 RID: 19075 RVA: 0x001745FC File Offset: 0x001727FC
		public void SetTeam(int teamTypeId, List<int> heroes)
		{
			List<int> list;
			if (this.Teams.TryGetValue(teamTypeId, out list))
			{
				list.Clear();
				list.AddRange(heroes);
			}
			else
			{
				list = new List<int>();
				list.AddRange(heroes);
				this.Teams.Add(teamTypeId, list);
			}
			base.SetDirty(true);
		}

		// Token: 0x06004A84 RID: 19076 RVA: 0x00174650 File Offset: 0x00172850
		public List<int> GetTeam(int teamTypeId)
		{
			List<int> result;
			if (this.Teams.TryGetValue(teamTypeId, out result))
			{
				return result;
			}
			return new List<int>();
		}

		// Token: 0x06004A85 RID: 19077 RVA: 0x00174678 File Offset: 0x00172878
		public void SetProcessingBattleInfo(BattleType type, int typeId)
		{
			this.ProcessingBattleInfo.Type = type;
			this.ProcessingBattleInfo.TypeId = typeId;
			this.ProcessingBattleInfo.Params.Clear();
			base.SetDirty(true);
		}

		// Token: 0x06004A86 RID: 19078 RVA: 0x001746AC File Offset: 0x001728AC
		public void SetRandomSeed(int randomSeed)
		{
			this.ProcessingBattleInfo.RandomSeed = randomSeed;
		}

		// Token: 0x06004A87 RID: 19079 RVA: 0x001746BC File Offset: 0x001728BC
		public void SetArmyRandomSeed(int ArmyRandomSeed)
		{
			this.ProcessingBattleInfo.ArmyRandomSeed = ArmyRandomSeed;
		}

		// Token: 0x06004A88 RID: 19080 RVA: 0x001746CC File Offset: 0x001728CC
		public int GetArmyRandomSeed()
		{
			return this.ProcessingBattleInfo.ArmyRandomSeed;
		}

		// Token: 0x06004A89 RID: 19081 RVA: 0x001746DC File Offset: 0x001728DC
		public bool IsGotBattleTreasureId(int id)
		{
			return this.GotBattleTreasureIds.Contains(id);
		}

		// Token: 0x06004A8A RID: 19082 RVA: 0x001746EC File Offset: 0x001728EC
		public void AddBattleTreasureId(int id)
		{
			this.GotBattleTreasureIds.Add(id);
		}

		// Token: 0x06004A8B RID: 19083 RVA: 0x001746FC File Offset: 0x001728FC
		public int GetArmyRandomSeedByBattleId(int battleId)
		{
			int result = 0;
			if (this.DailyArmyRandomSeedDict.TryGetValue(battleId, out result))
			{
				return result;
			}
			this.EveryTimeArmyRandomSeedDict.TryGetValue(battleId, out result);
			return result;
		}

		// Token: 0x06004A8C RID: 19084 RVA: 0x00174730 File Offset: 0x00172930
		public void RemoveEveryTimeArmyRandomSeed(int battleId)
		{
			if (this.EveryTimeArmyRandomSeedDict.ContainsKey(battleId))
			{
				this.EveryTimeArmyRandomSeedDict.Remove(battleId);
				base.SetDirty(true);
			}
		}

		// Token: 0x06004A8D RID: 19085 RVA: 0x00174758 File Offset: 0x00172958
		public void AddEveryTimeArmyRandomSeed(int battleId, int randomSeed)
		{
			if (this.EveryTimeArmyRandomSeedDict.ContainsKey(battleId))
			{
				this.EveryTimeArmyRandomSeedDict[battleId] = randomSeed;
			}
			else
			{
				this.EveryTimeArmyRandomSeedDict.Add(battleId, randomSeed);
			}
			base.SetDirty(true);
		}

		// Token: 0x06004A8E RID: 19086 RVA: 0x00174794 File Offset: 0x00172994
		public void AddDailyTimeArmyRandomSeed(int battleId, int randomSeed)
		{
			if (this.DailyArmyRandomSeedDict.ContainsKey(battleId))
			{
				this.DailyArmyRandomSeedDict[battleId] = randomSeed;
			}
			else
			{
				this.DailyArmyRandomSeedDict.Add(battleId, randomSeed);
			}
			base.SetDirty(true);
		}

		// Token: 0x06004A8F RID: 19087 RVA: 0x001747D0 File Offset: 0x001729D0
		public void InitDailyTimeArmyRandomSeed(int bettleId, int armyRandomSeed)
		{
			this.DailyArmyRandomSeedDict.Add(bettleId, armyRandomSeed);
		}

		// Token: 0x06004A90 RID: 19088 RVA: 0x001747E0 File Offset: 0x001729E0
		public void InitEveryTimeArmyRandomSeed(int bettleId, int armyRandomSeed)
		{
			this.EveryTimeArmyRandomSeedDict.Add(bettleId, armyRandomSeed);
		}

		// Token: 0x06004A91 RID: 19089 RVA: 0x001747F0 File Offset: 0x001729F0
		public void ClearDailyArmyRandomSeeds()
		{
			this.DailyArmyRandomSeedDict.Clear();
			base.SetDirty(true);
		}

		// Token: 0x06004A92 RID: 19090 RVA: 0x00174804 File Offset: 0x00172A04
		public void ClearProcesingBattleInfo()
		{
			this.ProcessingBattleInfo = new ProcessingBattle();
			base.SetDirty(true);
		}

		// Token: 0x17001266 RID: 4710
		// (get) Token: 0x06004A93 RID: 19091 RVA: 0x00174818 File Offset: 0x00172A18
		// (set) Token: 0x06004A94 RID: 19092 RVA: 0x00174820 File Offset: 0x00172A20
		public ProcessingBattle ProcessingBattleInfo { get; private set; }

		// Token: 0x17001267 RID: 4711
		// (get) Token: 0x06004A95 RID: 19093 RVA: 0x0017482C File Offset: 0x00172A2C
		// (set) Token: 0x06004A96 RID: 19094 RVA: 0x00174834 File Offset: 0x00172A34
		public Dictionary<int, List<int>> Teams { get; set; }

		// Token: 0x17001268 RID: 4712
		// (get) Token: 0x06004A97 RID: 19095 RVA: 0x00174840 File Offset: 0x00172A40
		// (set) Token: 0x06004A98 RID: 19096 RVA: 0x00174848 File Offset: 0x00172A48
		public List<int> GotBattleTreasureIds { get; set; }

		// Token: 0x17001269 RID: 4713
		// (get) Token: 0x06004A99 RID: 19097 RVA: 0x00174854 File Offset: 0x00172A54
		// (set) Token: 0x06004A9A RID: 19098 RVA: 0x0017485C File Offset: 0x00172A5C
		public Dictionary<int, int> DailyArmyRandomSeedDict { get; set; }

		// Token: 0x1700126A RID: 4714
		// (get) Token: 0x06004A9B RID: 19099 RVA: 0x00174868 File Offset: 0x00172A68
		// (set) Token: 0x06004A9C RID: 19100 RVA: 0x00174870 File Offset: 0x00172A70
		public Dictionary<int, int> EveryTimeArmyRandomSeedDict { get; set; }

		// Token: 0x1700126B RID: 4715
		// (get) Token: 0x06004A9D RID: 19101 RVA: 0x0017487C File Offset: 0x00172A7C
		// (set) Token: 0x06004A9E RID: 19102 RVA: 0x00174884 File Offset: 0x00172A84
		public ArenaBattleStatus ArenaBattleStatus { get; set; }

		// Token: 0x1700126C RID: 4716
		// (get) Token: 0x06004A9F RID: 19103 RVA: 0x00174890 File Offset: 0x00172A90
		// (set) Token: 0x06004AA0 RID: 19104 RVA: 0x00174898 File Offset: 0x00172A98
		public int ArenaBattleId { get; set; }

		// Token: 0x1700126D RID: 4717
		// (get) Token: 0x06004AA1 RID: 19105 RVA: 0x001748A4 File Offset: 0x00172AA4
		// (set) Token: 0x06004AA2 RID: 19106 RVA: 0x001748AC File Offset: 0x00172AAC
		public int ArenaBattleRandomSeed { get; set; }

		// Token: 0x1700126E RID: 4718
		// (get) Token: 0x06004AA3 RID: 19107 RVA: 0x001748B8 File Offset: 0x00172AB8
		// (set) Token: 0x06004AA4 RID: 19108 RVA: 0x001748C0 File Offset: 0x00172AC0
		public ulong BattleRoomId { get; set; }
	}
}
