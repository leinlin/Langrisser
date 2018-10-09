using System;
using ProtoBuf;

namespace BlackJack.ConfigData
{
	// Token: 0x020002D4 RID: 724
	[ProtoContract(Name = "BattleEventActionType")]
	public enum BattleEventActionType
	{
		// Token: 0x040021BB RID: 8635
		[ProtoEnum(Name = "BattleEventActionType_None", Value = 0)]
		BattleEventActionType_None,
		// Token: 0x040021BC RID: 8636
		[ProtoEnum(Name = "BattleEventActionType_Relief", Value = 1)]
		BattleEventActionType_Relief,
		// Token: 0x040021BD RID: 8637
		[ProtoEnum(Name = "BattleEventActionType_Retreat", Value = 2)]
		BattleEventActionType_Retreat,
		// Token: 0x040021BE RID: 8638
		[ProtoEnum(Name = "BattleEventActionType_Dialog", Value = 3)]
		BattleEventActionType_Dialog,
		// Token: 0x040021BF RID: 8639
		[ProtoEnum(Name = "BattleEventActionType_ChangeTeam", Value = 4)]
		BattleEventActionType_ChangeTeam,
		// Token: 0x040021C0 RID: 8640
		[ProtoEnum(Name = "BattleEventActionType_AttachBuff", Value = 5)]
		BattleEventActionType_AttachBuff,
		// Token: 0x040021C1 RID: 8641
		[ProtoEnum(Name = "BattleEventActionType_Music", Value = 6)]
		BattleEventActionType_Music,
		// Token: 0x040021C2 RID: 8642
		[ProtoEnum(Name = "BattleEventActionType_ChangeTerrain", Value = 7)]
		BattleEventActionType_ChangeTerrain,
		// Token: 0x040021C3 RID: 8643
		[ProtoEnum(Name = "BattleEventActionType_Perform", Value = 8)]
		BattleEventActionType_Perform,
		// Token: 0x040021C4 RID: 8644
		[ProtoEnum(Name = "BattleEventActionType_ChangeBehavior", Value = 9)]
		BattleEventActionType_ChangeBehavior,
		// Token: 0x040021C5 RID: 8645
		[ProtoEnum(Name = "BattleEventActionType_RetreatPosition", Value = 10)]
		BattleEventActionType_RetreatPosition,
		// Token: 0x040021C6 RID: 8646
		[ProtoEnum(Name = "BattleEventActionType_Replace", Value = 11)]
		BattleEventActionType_Replace,
		// Token: 0x040021C7 RID: 8647
		[ProtoEnum(Name = "BattleEventActionType_RemoveBuff", Value = 12)]
		BattleEventActionType_RemoveBuff,
		// Token: 0x040021C8 RID: 8648
		[ProtoEnum(Name = "BattleEventActionType_AttachBuffPosition", Value = 13)]
		BattleEventActionType_AttachBuffPosition
	}
}
