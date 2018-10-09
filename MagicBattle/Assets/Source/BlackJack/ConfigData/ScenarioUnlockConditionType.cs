using System;
using ProtoBuf;

namespace BlackJack.ConfigData
{
	// Token: 0x020002BD RID: 701
	[ProtoContract(Name = "ScenarioUnlockConditionType")]
	public enum ScenarioUnlockConditionType
	{
		// Token: 0x04001CDD RID: 7389
		[ProtoEnum(Name = "ScenarioUnlockConditionType_None", Value = 0)]
		ScenarioUnlockConditionType_None,
		// Token: 0x04001CDE RID: 7390
		[ProtoEnum(Name = "ScenarioUnlockConditionType_PlayerLevel", Value = 1)]
		ScenarioUnlockConditionType_PlayerLevel,
		// Token: 0x04001CDF RID: 7391
		[ProtoEnum(Name = "ScenarioUnlockConditionType_RiftLevel", Value = 2)]
		ScenarioUnlockConditionType_RiftLevel,
		// Token: 0x04001CE0 RID: 7392
		[ProtoEnum(Name = "ScenarioUnlockConditionType_Count", Value = 3)]
		ScenarioUnlockConditionType_Count
	}
}
