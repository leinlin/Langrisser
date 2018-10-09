using System;
using ProtoBuf;

namespace BlackJack.ConfigData
{
	// Token: 0x020002D2 RID: 722
	[ProtoContract(Name = "BattleArmyRandomRuleType")]
	public enum BattleArmyRandomRuleType
	{
		// Token: 0x0400219F RID: 8607
		[ProtoEnum(Name = "BattleArmyRandomRuleType_None", Value = 0)]
		BattleArmyRandomRuleType_None,
		// Token: 0x040021A0 RID: 8608
		[ProtoEnum(Name = "BattleArmyRandomRuleType_EveryTime", Value = 1)]
		BattleArmyRandomRuleType_EveryTime,
		// Token: 0x040021A1 RID: 8609
		[ProtoEnum(Name = "BattleArmyRandomRuleType_DailyTime", Value = 2)]
		BattleArmyRandomRuleType_DailyTime,
		// Token: 0x040021A2 RID: 8610
		[ProtoEnum(Name = "BattleArmyRandomRuleType_ClimbTower", Value = 3)]
		BattleArmyRandomRuleType_ClimbTower
	}
}
