using System;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using FixMath.NET;

namespace BlackJack.ProjectL.Battle
{
	// Token: 0x020003C7 RID: 967
	public interface IBattleListener
	{
		// Token: 0x06003999 RID: 14745
		void OnBattleActorCreate(BattleActor a, bool visible);

		// Token: 0x0600399A RID: 14746
		void OnBattleActorCreateEnd(BattleActor a);

		// Token: 0x0600399B RID: 14747
		void OnBattleActorActive(BattleActor a, bool autoSelect);

		// Token: 0x0600399C RID: 14748
		void OnBattleActorActionBegin(BattleActor a);

		// Token: 0x0600399D RID: 14749
		void OnBattleActorActionEnd(BattleActor a);

		// Token: 0x0600399E RID: 14750
		void OnBattleActorMove(BattleActor a, GridPosition p, int dir);

		// Token: 0x0600399F RID: 14751
		void OnBattleActorPerformMove(BattleActor a, GridPosition p, int dir, bool cameraFollow);

		// Token: 0x060039A0 RID: 14752
		void OnBattleActorPunchMove(BattleActor a, string fxName, bool isHurt);

		// Token: 0x060039A1 RID: 14753
		void OnBattleActorExchangeMove(BattleActor a, BattleActor b, int moveType, string fxName);

		// Token: 0x060039A2 RID: 14754
		void OnBattleActorSetDir(BattleActor a, int dir);

		// Token: 0x060039A3 RID: 14755
		void OnBattleActorPlayFx(BattleActor a, string fxName, int attachMode);

		// Token: 0x060039A4 RID: 14756
		void OnBattleActorPlayAnimation(BattleActor a, string animationName, int animationTime);

		// Token: 0x060039A5 RID: 14757
		void OnBattleActorChangeIdleAnimation(BattleActor a, string idleAnimationName);

		// Token: 0x060039A6 RID: 14758
		void OnBattleActorSkill(BattleActor a, ConfigDataSkillInfo skillInfo, GridPosition p);

		// Token: 0x060039A7 RID: 14759
		void OnBattleActorSkillHitBegin(BattleActor a, ConfigDataSkillInfo skillInfo, bool isRebound);

		// Token: 0x060039A8 RID: 14760
		void OnBattleActorSkillHit(BattleActor a, ConfigDataSkillInfo skillInfo, int heroHpModify, int soldierHpModify, DamageNumberType damageNumberType, bool isRebound);

		// Token: 0x060039A9 RID: 14761
		void OnBattleActorSkillHitEnd(BattleActor a, ConfigDataSkillInfo skillInfo, bool isRebound);

		// Token: 0x060039AA RID: 14762
		void OnBattleActorAttachBuff(BattleActor a, BuffState buffState);

		// Token: 0x060039AB RID: 14763
		void OnBattleActorDetachBuff(BattleActor a, BuffState buffState);

		// Token: 0x060039AC RID: 14764
		void OnBattleActorImmune(BattleActor a);

		// Token: 0x060039AD RID: 14765
		void OnBattleActorPassiveSkill(BattleActor a, BattleActor target, BuffState sourceBuffState);

		// Token: 0x060039AE RID: 14766
		void OnBattleActorBuffHit(BattleActor a, BuffState buffState, int heroHpModify, int soldierHpModify, DamageNumberType damageNumberType);

		// Token: 0x060039AF RID: 14767
		void OnBattleActorTerrainHit(BattleActor a, ConfigDataTerrainInfo terrainInfo, int heroHpModify, int soldierHpModify, DamageNumberType damageNumberType);

		// Token: 0x060039B0 RID: 14768
		void OnBattleActorTeleport(BattleActor a, ConfigDataSkillInfo skillInfo, GridPosition p);

		// Token: 0x060039B1 RID: 14769
		void OnBattleActorSummon(BattleActor a, ConfigDataSkillInfo skillInfo);

		// Token: 0x060039B2 RID: 14770
		void OnBattleActorDie(BattleActor a, bool isAfterCombat);

		// Token: 0x060039B3 RID: 14771
		void OnBattleActorAppear(BattleActor a, int effectType, string fxName);

		// Token: 0x060039B4 RID: 14772
		void OnBattleActorDisappear(BattleActor a, int effectType, string fxName);

		// Token: 0x060039B5 RID: 14773
		void OnBattleActorChangeTeam(BattleActor a);

		// Token: 0x060039B6 RID: 14774
		void OnBattleActorChangeArmy(BattleActor a);

		// Token: 0x060039B7 RID: 14775
		void OnBattleActorReplace(BattleActor a0, BattleActor a1, string fxName);

		// Token: 0x060039B8 RID: 14776
		void OnBattleActorCameraFocus(BattleActor a);

		// Token: 0x060039B9 RID: 14777
		void OnBattleActorGainBattleTreasure(BattleActor a, ConfigDataBattleTreasureInfo treasureInfo);

		// Token: 0x060039BA RID: 14778
		void OnStartGuard(BattleActor a, BattleActor target);

		// Token: 0x060039BB RID: 14779
		void OnStopGuard(BattleActor a, BattleActor target);

		// Token: 0x060039BC RID: 14780
		void OnBeforeStartCombat(BattleActor a, BattleActor b, ConfigDataSkillInfo attackerSkillInfo);

		// Token: 0x060039BD RID: 14781
		void OnCancelCombat();

		// Token: 0x060039BE RID: 14782
		void OnStartCombat(BattleActor a, BattleActor b, ConfigDataSkillInfo attackerSkillInfo);

		// Token: 0x060039BF RID: 14783
		void OnPreStopCombat();

		// Token: 0x060039C0 RID: 14784
		void OnStopCombat(int teamAHeroTotalDamage, int teamASoldierTotalDamage, bool teamACriticalAttack, int teamBHeroTotalDamage, int teamBSoldierTotalDamage, bool teamBCriticalAttack);

		// Token: 0x060039C1 RID: 14785
		void OnBattleNextTurn(int turn);

		// Token: 0x060039C2 RID: 14786
		void OnBattleNextTeam(int team, bool isNpc);

		// Token: 0x060039C3 RID: 14787
		void OnBattleNextPlayer(int prevPlayerIndex, int playerIndex);

		// Token: 0x060039C4 RID: 14788
		void OnBattleNextActor(BattleActor actor);

		// Token: 0x060039C5 RID: 14789
		void OnCombatActorHit(CombatActor a, CombatActor attacker, ConfigDataSkillInfo skillInfo, int hpModify, int totalDamage, DamageNumberType damageNumberType);

		// Token: 0x060039C6 RID: 14790
		void OnCombatActorDie(CombatActor a);

		// Token: 0x060039C7 RID: 14791
		void OnStartSkillCutscene(ConfigDataSkillInfo skillInfo, ConfigDataCutsceneInfo cutsceneInfo, int team);

		// Token: 0x060039C8 RID: 14792
		void OnStartPassiveSkillCutscene(BuffState sourceBuffState, int team);

		// Token: 0x060039C9 RID: 14793
		void OnStopSkillCutscene();

		// Token: 0x060039CA RID: 14794
		void OnStartBattleDialog(ConfigDataBattleDialogInfo dialogInfo);

		// Token: 0x060039CB RID: 14795
		void OnStartBattlePerform(ConfigDataBattlePerformInfo performInfo);

		// Token: 0x060039CC RID: 14796
		void OnStopBattlePerform();

		// Token: 0x060039CD RID: 14797
		void OnChangeMapTerrain(GridPosition p, ConfigDataTerrainInfo terrainInfo);

		// Token: 0x060039CE RID: 14798
		void OnCameraFocus(GridPosition p);

		// Token: 0x060039CF RID: 14799
		void OnPlayMusic(string musicName);

		// Token: 0x060039D0 RID: 14800
		void OnPlaySound(string soundName);

		// Token: 0x060039D1 RID: 14801
		void OnPlayFx(string fxName, GridPosition p);

		// Token: 0x060039D2 RID: 14802
		void OnWaitTime(int timeInMs);

		// Token: 0x060039D3 RID: 14803
		void OnBattleTreasureCreate(ConfigDataBattleTreasureInfo treasureInfo, bool isOpened);

		// Token: 0x060039D4 RID: 14804
		IBattleGraphic CreateCombatGraphic(string assetName, float scale);

		// Token: 0x060039D5 RID: 14805
		void DestroyCombatGraphic(IBattleGraphic g);

		// Token: 0x060039D6 RID: 14806
		IBattleGraphic PlayFx(string assetName, float scale);

		// Token: 0x060039D7 RID: 14807
		void PlaySound(string name);

		// Token: 0x060039D8 RID: 14808
		void DrawLine(Vector2i p0, Vector2i p1, Colori color);

		// Token: 0x060039D9 RID: 14809
		void DrawLine(Vector2i p0, Fix64 z0, Vector2i p1, Fix64 z1, Colori color);

		// Token: 0x060039DA RID: 14810
		void LogBattleStart();

		// Token: 0x060039DB RID: 14811
		void LogBattleStop(bool isWin);

		// Token: 0x060039DC RID: 14812
		void LogBattleTeam(BattleTeam team0, BattleTeam team1);

		// Token: 0x060039DD RID: 14813
		void LogActorMove(BattleActor actor, GridPosition fromPos, GridPosition toPos);

		// Token: 0x060039DE RID: 14814
		void LogActorStandby(BattleActor actor);

		// Token: 0x060039DF RID: 14815
		void LogActorAttack(BattleActor actor, BattleActor targetActor);

		// Token: 0x060039E0 RID: 14816
		void LogActorSkill(BattleActor actor, ConfigDataSkillInfo skillInfo, BattleActor targetActor, GridPosition targetPos);

		// Token: 0x060039E1 RID: 14817
		void LogActorDie(BattleActor actor, BattleActor killerActor);
	}
}
