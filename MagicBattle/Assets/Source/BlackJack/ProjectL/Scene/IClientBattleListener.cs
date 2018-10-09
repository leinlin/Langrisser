using System;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Battle;
using BlackJack.ProjectL.Common;

namespace BlackJack.ProjectL.Scene
{
	// Token: 0x02000970 RID: 2416
	public interface IClientBattleListener
	{
		// Token: 0x06008A17 RID: 35351
		void OnStartBattle();

		// Token: 0x06008A18 RID: 35352
		void OnStopBattle(bool win, bool skipPerform);

		// Token: 0x06008A19 RID: 35353
		void OnShowBattleWinCondition(ConfigDataBattleWinConditionInfo winConditionInfo, GridPosition targetPos);

		// Token: 0x06008A1A RID: 35354
		void OnHideBattleWinCondition(ConfigDataBattleWinConditionInfo winConditionInfo, GridPosition targetPos);

		// Token: 0x06008A1B RID: 35355
		void OnShowBattleLoseCondition(ConfigDataBattleLoseConditionInfo loseConditionInfo, GridPosition targetPos);

		// Token: 0x06008A1C RID: 35356
		void OnHideBattleLoseCondition(ConfigDataBattleLoseConditionInfo loseConditionInfo, GridPosition targetPos);

		// Token: 0x06008A1D RID: 35357
		void OnNextTurn(int turn);

		// Token: 0x06008A1E RID: 35358
		void OnNextTurnAnimationEnd(int turn);

		// Token: 0x06008A1F RID: 35359
		void OnNextTeam(int team);

		// Token: 0x06008A20 RID: 35360
		void OnNextPlayer(int playerIndex);

		// Token: 0x06008A21 RID: 35361
		void OnNextActor(BattleActor actor);

		// Token: 0x06008A22 RID: 35362
		void OnClientActorActive(ClientBattleActor a, bool newStep, int step);

		// Token: 0x06008A23 RID: 35363
		void OnClientActorMove(ClientBattleActor a);

		// Token: 0x06008A24 RID: 35364
		void OnClientActorTryMove(ClientBattleActor a);

		// Token: 0x06008A25 RID: 35365
		void OnClientActorNoAct(ClientBattleActor a);

		// Token: 0x06008A26 RID: 35366
		void OnClientActorTarget(ClientBattleActor a, ConfigDataSkillInfo skill, GridPosition pos, int armyRelationValue);

		// Token: 0x06008A27 RID: 35367
		void OnClientActorSkill(ClientBattleActor a, ConfigDataSkillInfo skillInfo);

		// Token: 0x06008A28 RID: 35368
		void OnClientActorSkillEnd(ClientBattleActor a, ConfigDataSkillInfo skillInfo);

		// Token: 0x06008A29 RID: 35369
		void OnClientActorSkillHit(ClientBattleActor a, ConfigDataSkillInfo skill, int heroHpModify, int soldierHpModify, DamageNumberType damageNumberType);

		// Token: 0x06008A2A RID: 35370
		void OnClientActorBuffHit(ClientBattleActor a, ConfigDataBuffInfo buffInfo, int heroHpModify, int soldierHpModify, DamageNumberType damageNumberType);

		// Token: 0x06008A2B RID: 35371
		void OnClientActorTerrainHit(ClientBattleActor a, ConfigDataTerrainInfo terrainInfo, int heroHpModify, int soldierHpModify, DamageNumberType damageNumberType);

		// Token: 0x06008A2C RID: 35372
		void OnClientActorImmune(ClientBattleActor a);

		// Token: 0x06008A2D RID: 35373
		void OnClientActorPassiveSkill(ClientBattleActor a, BuffState sourceBuffState);

		// Token: 0x06008A2E RID: 35374
		void OnClientActorGuard(ClientBattleActor a, ClientBattleActor target);

		// Token: 0x06008A2F RID: 35375
		void OnClientActorDie(ClientBattleActor a);

		// Token: 0x06008A30 RID: 35376
		void OnClientActorAppear(ClientBattleActor a);

		// Token: 0x06008A31 RID: 35377
		void OnCancelCombat();

		// Token: 0x06008A32 RID: 35378
		void OnPreStartCombat(ClientBattleActor a, ClientBattleActor b);

		// Token: 0x06008A33 RID: 35379
		void OnStartCombat(ClientBattleActor a, ClientBattleActor b, bool splitScreen);

		// Token: 0x06008A34 RID: 35380
		void OnPreStopCombat();

		// Token: 0x06008A35 RID: 35381
		void OnStopCombat();

		// Token: 0x06008A36 RID: 35382
		void OnPrepareFastCombat(ClientBattleActor a, ClientBattleActor b, ConfigDataSkillInfo attackerSkillInfo);

		// Token: 0x06008A37 RID: 35383
		void OnStartFastCombat(FastCombatActorInfo a, FastCombatActorInfo b);

		// Token: 0x06008A38 RID: 35384
		void OnCombatActorHit(CombatActor a, CombatActor attacker, ConfigDataSkillInfo skill, int hpModify, int totalDamage, DamageNumberType damageNumberType);

		// Token: 0x06008A39 RID: 35385
		void OnStartSkillCutscene(ConfigDataSkillInfo skillInfo, ConfigDataCutsceneInfo cutsceneInfo, int team);

		// Token: 0x06008A3A RID: 35386
		void OnStartPassiveSkillCutscene(BuffState sourceBuffState, int team);

		// Token: 0x06008A3B RID: 35387
		void OnStopSkillCutscene();

		// Token: 0x06008A3C RID: 35388
		void OnStartBattleDialog(ConfigDataBattleDialogInfo dialogInfo);

		// Token: 0x06008A3D RID: 35389
		void OnStartBattleTreasureDialog(ConfigDataBattleTreasureInfo treasureInfo);

		// Token: 0x06008A3E RID: 35390
		void OnShowBattleTreasureReward(ConfigDataBattleTreasureInfo treasureInfo);

		// Token: 0x06008A3F RID: 35391
		void OnStartBattlePerform();

		// Token: 0x06008A40 RID: 35392
		void OnStopBattlePerform();

		// Token: 0x06008A41 RID: 35393
		void OnScreenEffect(string name);
	}
}
