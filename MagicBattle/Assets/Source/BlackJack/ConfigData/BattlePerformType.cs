using System;
using ProtoBuf;

namespace BlackJack.ConfigData
{
	// Token: 0x020002D6 RID: 726
	[ProtoContract(Name = "BattlePerformType")]
	public enum BattlePerformType
	{
		// Token: 0x040021D9 RID: 8665
		[ProtoEnum(Name = "BattlePerformType_None", Value = 0)]
		BattlePerformType_None,
		// Token: 0x040021DA RID: 8666
		[ProtoEnum(Name = "BattlePerformType_Dialog", Value = 1)]
		BattlePerformType_Dialog,
		// Token: 0x040021DB RID: 8667
		[ProtoEnum(Name = "BattlePerformType_PlayMusic", Value = 2)]
		BattlePerformType_PlayMusic,
		// Token: 0x040021DC RID: 8668
		[ProtoEnum(Name = "BattlePerformType_PlaySound", Value = 3)]
		BattlePerformType_PlaySound,
		// Token: 0x040021DD RID: 8669
		[ProtoEnum(Name = "BattlePerformType_PlayFx", Value = 4)]
		BattlePerformType_PlayFx,
		// Token: 0x040021DE RID: 8670
		[ProtoEnum(Name = "BattlePerformType_PlayActorFx", Value = 5)]
		BattlePerformType_PlayActorFx,
		// Token: 0x040021DF RID: 8671
		[ProtoEnum(Name = "BattlePerformType_ChangeTerrain", Value = 6)]
		BattlePerformType_ChangeTerrain,
		// Token: 0x040021E0 RID: 8672
		[ProtoEnum(Name = "BattlePerformType_CameraFocusPosition", Value = 7)]
		BattlePerformType_CameraFocusPosition,
		// Token: 0x040021E1 RID: 8673
		[ProtoEnum(Name = "BattlePerformType_CameraFocusActor", Value = 8)]
		BattlePerformType_CameraFocusActor,
		// Token: 0x040021E2 RID: 8674
		[ProtoEnum(Name = "BattlePerformType_CreateActor", Value = 9)]
		BattlePerformType_CreateActor,
		// Token: 0x040021E3 RID: 8675
		[ProtoEnum(Name = "BattlePerformType_CreateActorNear", Value = 10)]
		BattlePerformType_CreateActorNear,
		// Token: 0x040021E4 RID: 8676
		[ProtoEnum(Name = "BattlePerformType_RemoveActor", Value = 11)]
		BattlePerformType_RemoveActor,
		// Token: 0x040021E5 RID: 8677
		[ProtoEnum(Name = "BattlePerformType_ActorMove", Value = 12)]
		BattlePerformType_ActorMove,
		// Token: 0x040021E6 RID: 8678
		[ProtoEnum(Name = "BattlePerformType_ActorMoveNear", Value = 13)]
		BattlePerformType_ActorMoveNear,
		// Token: 0x040021E7 RID: 8679
		[ProtoEnum(Name = "BattlePerformType_ActorAttack", Value = 14)]
		BattlePerformType_ActorAttack,
		// Token: 0x040021E8 RID: 8680
		[ProtoEnum(Name = "BattlePerformType_ActorSkill", Value = 15)]
		BattlePerformType_ActorSkill,
		// Token: 0x040021E9 RID: 8681
		[ProtoEnum(Name = "BattlePerformType_ActorDir", Value = 16)]
		BattlePerformType_ActorDir,
		// Token: 0x040021EA RID: 8682
		[ProtoEnum(Name = "BattlePerformType_ActorAnimation", Value = 17)]
		BattlePerformType_ActorAnimation,
		// Token: 0x040021EB RID: 8683
		[ProtoEnum(Name = "BattlePerformType_ActorIdle", Value = 18)]
		BattlePerformType_ActorIdle,
		// Token: 0x040021EC RID: 8684
		[ProtoEnum(Name = "BattlePerformType_WaitTime", Value = 19)]
		BattlePerformType_WaitTime,
		// Token: 0x040021ED RID: 8685
		[ProtoEnum(Name = "BattlePerformType_StopBattle", Value = 20)]
		BattlePerformType_StopBattle
	}
}
