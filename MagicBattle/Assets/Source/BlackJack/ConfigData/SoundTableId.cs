using System;
using ProtoBuf;

namespace BlackJack.ConfigData
{
	// Token: 0x020002F6 RID: 758
	[ProtoContract(Name = "SoundTableId")]
	public enum SoundTableId
	{
		// Token: 0x04002319 RID: 8985
		[ProtoEnum(Name = "SoundTableId_None", Value = 0)]
		SoundTableId_None,
		// Token: 0x0400231A RID: 8986
		[ProtoEnum(Name = "SoundTableId_SelectHero", Value = 1)]
		SoundTableId_SelectHero,
		// Token: 0x0400231B RID: 8987
		[ProtoEnum(Name = "SoundTableId_DragHero", Value = 2)]
		SoundTableId_DragHero,
		// Token: 0x0400231C RID: 8988
		[ProtoEnum(Name = "SoundTableId_DropHero", Value = 3)]
		SoundTableId_DropHero,
		// Token: 0x0400231D RID: 8989
		[ProtoEnum(Name = "SoundTableId_Error", Value = 4)]
		SoundTableId_Error,
		// Token: 0x0400231E RID: 8990
		[ProtoEnum(Name = "SoundTableId_LoginMusic", Value = 5)]
		SoundTableId_LoginMusic,
		// Token: 0x0400231F RID: 8991
		[ProtoEnum(Name = "SoundTableId_ChangeJobMusic", Value = 6)]
		SoundTableId_ChangeJobMusic,
		// Token: 0x04002320 RID: 8992
		[ProtoEnum(Name = "SoundTableId_ChangeJobMusic2", Value = 7)]
		SoundTableId_ChangeJobMusic2,
		// Token: 0x04002321 RID: 8993
		[ProtoEnum(Name = "SoundTableId_GoddessDialogMusic", Value = 8)]
		SoundTableId_GoddessDialogMusic,
		// Token: 0x04002322 RID: 8994
		[ProtoEnum(Name = "SoundTableId_BattleMoveWalk", Value = 9)]
		SoundTableId_BattleMoveWalk,
		// Token: 0x04002323 RID: 8995
		[ProtoEnum(Name = "SoundTableId_BattleMoveRide", Value = 10)]
		SoundTableId_BattleMoveRide,
		// Token: 0x04002324 RID: 8996
		[ProtoEnum(Name = "SoundTableId_BattleMoveFly", Value = 11)]
		SoundTableId_BattleMoveFly,
		// Token: 0x04002325 RID: 8997
		[ProtoEnum(Name = "SoundTableId_HeroJobTransferMusic", Value = 12)]
		SoundTableId_HeroJobTransferMusic,
		// Token: 0x04002326 RID: 8998
		[ProtoEnum(Name = "SoundTableId_ShowStartAnimation", Value = 13)]
		SoundTableId_ShowStartAnimation,
		// Token: 0x04002327 RID: 8999
		[ProtoEnum(Name = "SoundTableId_HeroDieAtCombat", Value = 14)]
		SoundTableId_HeroDieAtCombat,
		// Token: 0x04002328 RID: 9000
		[ProtoEnum(Name = "SoundTableId_AddExpToHero", Value = 15)]
		SoundTableId_AddExpToHero,
		// Token: 0x04002329 RID: 9001
		[ProtoEnum(Name = "SoundTableId_SkipCombatHeroDead", Value = 16)]
		SoundTableId_SkipCombatHeroDead,
		// Token: 0x0400232A RID: 9002
		[ProtoEnum(Name = "SoundTableId_SkipCombatSoldierDead", Value = 17)]
		SoundTableId_SkipCombatSoldierDead,
		// Token: 0x0400232B RID: 9003
		[ProtoEnum(Name = "SoundTableId_SkipCombatHpBreakL", Value = 18)]
		SoundTableId_SkipCombatHpBreakL,
		// Token: 0x0400232C RID: 9004
		[ProtoEnum(Name = "SoundTableId_SkipCombatHpBreakS", Value = 19)]
		SoundTableId_SkipCombatHpBreakS,
		// Token: 0x0400232D RID: 9005
		[ProtoEnum(Name = "SoundTableId_HeroDungeonEnter", Value = 20)]
		SoundTableId_HeroDungeonEnter,
		// Token: 0x0400232E RID: 9006
		[ProtoEnum(Name = "SoundTableId_HeroDungeonGearRoll", Value = 21)]
		SoundTableId_HeroDungeonGearRoll,
		// Token: 0x0400232F RID: 9007
		[ProtoEnum(Name = "SoundTableId_ShowDangerRegion", Value = 22)]
		SoundTableId_ShowDangerRegion
	}
}
