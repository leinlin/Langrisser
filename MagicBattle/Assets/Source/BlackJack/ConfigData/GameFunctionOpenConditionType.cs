using System;
using ProtoBuf;

namespace BlackJack.ConfigData
{
	// Token: 0x020002C6 RID: 710
	[ProtoContract(Name = "GameFunctionOpenConditionType")]
	public enum GameFunctionOpenConditionType
	{
		// Token: 0x04001DB4 RID: 7604
		[ProtoEnum(Name = "GameFunctionOpenConditionType_None", Value = 0)]
		GameFunctionOpenConditionType_None,
		// Token: 0x04001DB5 RID: 7605
		[ProtoEnum(Name = "GameFunctionOpenConditionType_PlayerLevel", Value = 1)]
		GameFunctionOpenConditionType_PlayerLevel,
		// Token: 0x04001DB6 RID: 7606
		[ProtoEnum(Name = "GameFunctionOpenConditionType_Scenario", Value = 2)]
		GameFunctionOpenConditionType_Scenario,
		// Token: 0x04001DB7 RID: 7607
		[ProtoEnum(Name = "GameFunctionOpenConditionType_WaypointEvent", Value = 3)]
		GameFunctionOpenConditionType_WaypointEvent,
		// Token: 0x04001DB8 RID: 7608
		[ProtoEnum(Name = "GameFunctionOpenConditionType_RiftLevel", Value = 4)]
		GameFunctionOpenConditionType_RiftLevel
	}
}
