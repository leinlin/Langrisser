using System;
using SLua;

namespace BlackJack.ProjectL.Scene
{
	// Token: 0x02000969 RID: 2409
	[CustomLuaClass]
	public class ClientBattleConst
	{
		// Token: 0x0400622E RID: 25134
		public const int TickRate = 30;

		// Token: 0x0400622F RID: 25135
		public const float TickTime = 0.0333333351f;

		// Token: 0x04006230 RID: 25136
		public const float GridWidth = 2f;

		// Token: 0x04006231 RID: 25137
		public const float GridHeight = 2f;

		// Token: 0x04006232 RID: 25138
		public const float FootHeightScale = 0.25f;

		// Token: 0x04006233 RID: 25139
		public const int StartCombatEffectTime = 500;

		// Token: 0x04006234 RID: 25140
		public const int StopCombatEffectTime = 500;

		// Token: 0x04006235 RID: 25141
		public const int SkillFadeTime = 300;

		// Token: 0x04006236 RID: 25142
		public const float SkillFadeZOffset = 30f;

		// Token: 0x04006237 RID: 25143
		public const float GuardZOffset = -1f;

		// Token: 0x04006238 RID: 25144
		public const float ActorFxZOffset = -20f;

		// Token: 0x04006239 RID: 25145
		public const float TreasureIdleZOffset = 1f;

		// Token: 0x0400623A RID: 25146
		public const float TreasureOpenZOffset = -1f;

		// Token: 0x0400623B RID: 25147
		public const int ActorActStartCombatTime = 700;

		// Token: 0x0400623C RID: 25148
		public const int ActorActStopCombatTime = 300;

		// Token: 0x0400623D RID: 25149
		public const int ActorActImmuneTime = 500;

		// Token: 0x0400623E RID: 25150
		public const int ActorActStartGuardDelay = 800;

		// Token: 0x0400623F RID: 25151
		public const int ActorActStopGuardDelay = 300;

		// Token: 0x04006240 RID: 25152
		public const int ActorActPassiveSkillTime = 1200;

		// Token: 0x04006241 RID: 25153
		public const int ActorActPassiveSkillHitTime = 400;

		// Token: 0x04006242 RID: 25154
		public const int ActorActAppearTime = 500;

		// Token: 0x04006243 RID: 25155
		public const int ActorActDisappearTime = 500;

		// Token: 0x04006244 RID: 25156
		public const int ActorActTelelportDisappearDelayTime = 500;

		// Token: 0x04006245 RID: 25157
		public const int ActorActTelelportAppearDelayTime = 500;

		// Token: 0x04006246 RID: 25158
		public const int ActorActSummonDelayTime = 500;

		// Token: 0x04006247 RID: 25159
		public const int ActorActChangeTeamTime = 500;

		// Token: 0x04006248 RID: 25160
		public const int ActorActPunchMoveTime = 400;

		// Token: 0x04006249 RID: 25161
		public const int ActorActExchangeMoveTime = 300;

		// Token: 0x0400624A RID: 25162
		public const int ActorActReplaceTime = 500;

		// Token: 0x0400624B RID: 25163
		public const int ActorActDieTime = 300;

		// Token: 0x0400624C RID: 25164
		public const int ActorActDieHideTime = 200;

		// Token: 0x0400624D RID: 25165
		public const int TargetIconTime = 500;

		// Token: 0x0400624E RID: 25166
		public const int HpBarBuffCountMax = 3;

		// Token: 0x0400624F RID: 25167
		public const int BattleResultHeroCountMax = 5;

		// Token: 0x04006250 RID: 25168
		public const float FastBattleTimeScale = 1.3f;
	}
}
