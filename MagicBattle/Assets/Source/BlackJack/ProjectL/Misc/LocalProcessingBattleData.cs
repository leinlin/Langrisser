using System;
using BlackJack.ProjectL.Common;
using SLua;

namespace BlackJack.ProjectL.Misc
{
	// Token: 0x0200087C RID: 2172
	[CustomLuaClass]
	public class LocalProcessingBattleData
	{
		// Token: 0x06006BC2 RID: 27586 RVA: 0x001E3460 File Offset: 0x001E1660
		public void Clear()
		{
			this.Version = 0;
			this.Type = 0;
			this.TypeId = 0;
			this.RandomSeed = 0;
			this.ArmyRandomSeed = 0;
			this.Step = 0;
			this.RegretCount = 0;
			this.BattleCommands = null;
		}

		// Token: 0x040052E4 RID: 21220
		public int Version;

		// Token: 0x040052E5 RID: 21221
		public int Type;

		// Token: 0x040052E6 RID: 21222
		public int TypeId;

		// Token: 0x040052E7 RID: 21223
		public int RandomSeed;

		// Token: 0x040052E8 RID: 21224
		public int ArmyRandomSeed;

		// Token: 0x040052E9 RID: 21225
		public int Step;

		// Token: 0x040052EA RID: 21226
		public int RegretCount;

		// Token: 0x040052EB RID: 21227
		public LocalProcessingBattleData.LocalBattleCommand[] BattleCommands;

		// Token: 0x0200087D RID: 2173
		[CustomLuaClass]
		public class LocalBattleCommand
		{
			// Token: 0x06006BC4 RID: 27588 RVA: 0x001E34A4 File Offset: 0x001E16A4
			public BattleCommand ToBattleCommand()
			{
				return new BattleCommand
				{
					Type = (BattleCommandType)this.Type,
					Step = this.Step,
					ActorId = this.Actor,
					SkillIndex = this.Skill,
					TargetPosition = new GridPosition(this.PX, this.PY),
					TargetPosition2 = new GridPosition(this.P2X, this.P2Y)
				};
			}

			// Token: 0x06006BC5 RID: 27589 RVA: 0x001E3518 File Offset: 0x001E1718
			public void FromBattleCommand(BattleCommand cmd)
			{
				this.Type = (int)cmd.Type;
				this.Step = cmd.Step;
				this.Actor = cmd.ActorId;
				this.Skill = cmd.SkillIndex;
				this.PX = cmd.TargetPosition.x;
				this.PY = cmd.TargetPosition.y;
				this.P2X = cmd.TargetPosition2.x;
				this.P2Y = cmd.TargetPosition2.y;
			}

			// Token: 0x040052EC RID: 21228
			public int Type;

			// Token: 0x040052ED RID: 21229
			public int Step;

			// Token: 0x040052EE RID: 21230
			public int Actor;

			// Token: 0x040052EF RID: 21231
			public int Skill;

			// Token: 0x040052F0 RID: 21232
			public int PX;

			// Token: 0x040052F1 RID: 21233
			public int PY;

			// Token: 0x040052F2 RID: 21234
			public int P2X;

			// Token: 0x040052F3 RID: 21235
			public int P2Y;
		}
	}
}
