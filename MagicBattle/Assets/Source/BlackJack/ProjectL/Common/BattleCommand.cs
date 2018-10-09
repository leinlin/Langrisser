using System;
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x0200036B RID: 875
	[CustomLuaClass]
	public class BattleCommand
	{
		// Token: 0x060031D9 RID: 12761 RVA: 0x000C43C8 File Offset: 0x000C25C8
		public static BattleCommand PBBattleCommandToBattleCommand(ProBattleCommand pbBattleCommand)
		{
			return new BattleCommand
			{
				Type = (BattleCommandType)pbBattleCommand.CommandType,
				Step = pbBattleCommand.Step,
				ActorId = pbBattleCommand.ActorId,
				SkillIndex = pbBattleCommand.SkillIndex,
				TargetPosition = BattleCommand.PBBattlePositionToGridPosition(pbBattleCommand.TargetPosition),
				TargetPosition2 = BattleCommand.PBBattlePositionToGridPosition(pbBattleCommand.TargetPosition2)
			};
		}

		// Token: 0x060031DA RID: 12762 RVA: 0x000C4430 File Offset: 0x000C2630
		public static ProBattleCommand BattleCommandToPBBattleCommand(BattleCommand battleCommand)
		{
			return new ProBattleCommand
			{
				CommandType = (int)battleCommand.Type,
				Step = battleCommand.Step,
				ActorId = battleCommand.ActorId,
				SkillIndex = battleCommand.SkillIndex,
				TargetPosition = BattleCommand.GridPositionToPBBattlePosition(battleCommand.TargetPosition),
				TargetPosition2 = BattleCommand.GridPositionToPBBattlePosition(battleCommand.TargetPosition2)
			};
		}

		// Token: 0x060031DB RID: 12763 RVA: 0x000C4498 File Offset: 0x000C2698
		public static ProBattlePosition GridPositionToPBBattlePosition(GridPosition gridPosition)
		{
			return new ProBattlePosition
			{
				X = gridPosition.x,
				Y = gridPosition.y
			};
		}

		// Token: 0x060031DC RID: 12764 RVA: 0x000C44C8 File Offset: 0x000C26C8
		public static GridPosition PBBattlePositionToGridPosition(ProBattlePosition pbBattlePosition)
		{
			return new GridPosition
			{
				x = pbBattlePosition.X,
				y = pbBattlePosition.Y
			};
		}

		// Token: 0x0400265D RID: 9821
		public BattleCommandType Type;

		// Token: 0x0400265E RID: 9822
		public int Step;

		// Token: 0x0400265F RID: 9823
		public int ActorId;

		// Token: 0x04002660 RID: 9824
		public int SkillIndex;

		// Token: 0x04002661 RID: 9825
		public GridPosition TargetPosition;

		// Token: 0x04002662 RID: 9826
		public GridPosition TargetPosition2;
	}
}
