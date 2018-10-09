using System;
using System.Collections;
using System.Diagnostics;
using System.Threading;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Battle;
using BlackJack.ProjectL.Misc;
using BlackJack.ProjectL.Scene;
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000AFE RID: 2814
	[HotFix]
	public class PreCombatUIController : UIControllerBase
	{
		// Token: 0x0600BC55 RID: 48213 RVA: 0x0034C648 File Offset: 0x0034A848
		private PreCombatUIController()
		{
		}

		// Token: 0x0600BC56 RID: 48214 RVA: 0x0034C65C File Offset: 0x0034A85C
		private void OnDisable()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnDisable_hotfix != null)
			{
				this.m_OnDisable_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_isOpened = false;
			this.m_isFastCombat = false;
		}

		// Token: 0x0600BC57 RID: 48215 RVA: 0x0034C6CC File Offset: 0x0034A8CC
		protected override void OnBindFiledsCompleted()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnBindFiledsCompleted_hotfix != null)
			{
				this.m_OnBindFiledsCompleted_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.OnBindFiledsCompleted();
			this.m_okButton.onClick.AddListener(new UnityAction(this.OnOkButtonClick));
			this.m_cancelButton.onClick.AddListener(new UnityAction(this.OnCancelButtonClick));
			this.m_backgroundButton.onClick.AddListener(new UnityAction(this.OnBackgroundButtonClick));
			UIUtility.SetTweenIgnoreTimeScale(base.gameObject, false);
			this.m_battlePreviewStateCtrl.SetActionForUIStateFinshed("Close", delegate
			{
				base.gameObject.SetActive(false);
			});
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			this.m_propertyComputer.Init(configDataLoader);
			UIUtility.MarginAdjustHorizontal(this.m_marginTransform);
		}

		// Token: 0x0600BC58 RID: 48216 RVA: 0x0034C7D8 File Offset: 0x0034A9D8
		public void Initialize(FxPlayer fxPlayer)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitializeFxPlayer_hotfix != null)
			{
				this.m_InitializeFxPlayer_hotfix.call(new object[]
				{
					this,
					fxPlayer
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_fxPlayer = fxPlayer;
		}

		// Token: 0x0600BC59 RID: 48217 RVA: 0x0034C850 File Offset: 0x0034AA50
		public void Open()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Open_hotfix != null)
			{
				this.m_Open_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_isOpened = true;
			this.Show();
			this.ShowOkCancelButton(true);
		}

		// Token: 0x0600BC5A RID: 48218 RVA: 0x0034C8C4 File Offset: 0x0034AAC4
		public bool IsOpened()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsOpened_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsOpened_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_isOpened;
		}

		// Token: 0x0600BC5B RID: 48219 RVA: 0x0034C938 File Offset: 0x0034AB38
		public bool IsFastCombat()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsFastCombat_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsFastCombat_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_isFastCombat;
		}

		// Token: 0x0600BC5C RID: 48220 RVA: 0x0034C9AC File Offset: 0x0034ABAC
		private void Show()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Show_hotfix != null)
			{
				this.m_Show_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.gameObject.SetActive(true);
			this.m_battlePreviewStateCtrl.SetToUIState("Show", false, true);
			this.m_actor0SituationGroup.gameObject.SetActive(this.m_armyRelationValue != 0);
			this.m_actor1SituationGroup.gameObject.SetActive(this.m_armyRelationValue != 0);
			this.m_actor0PassiveSkillUIStateController.gameObject.SetActive(false);
			this.m_actor1PassiveSkillUIStateController.gameObject.SetActive(false);
		}

		// Token: 0x0600BC5D RID: 48221 RVA: 0x0034CA84 File Offset: 0x0034AC84
		private void ShowOkCancelButton(bool show)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowOkCancelButtonBoolean_hotfix != null)
			{
				this.m_ShowOkCancelButtonBoolean_hotfix.call(new object[]
				{
					this,
					show
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_okButton.gameObject.SetActive(show);
			this.m_cancelButton.gameObject.SetActive(show);
		}

		// Token: 0x0600BC5E RID: 48222 RVA: 0x0034CB18 File Offset: 0x0034AD18
		public void SetBattleActorInfo(BattleActor a0, BattleActor a1, ConfigDataTerrainInfo terrain0, ConfigDataTerrainInfo terrain1, bool isMagicAttack0, bool isMagicAttack1, int armyRelationValue, ConfigDataSkillInfo attackerSkillInfo, int attackerSide)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetBattleActorInfoBattleActorBattleActorConfigDataTerrainInfoConfigDataTerrainInfoBooleanBooleanInt32ConfigDataSkillInfoInt32_hotfix != null)
			{
				this.m_SetBattleActorInfoBattleActorBattleActorConfigDataTerrainInfoConfigDataTerrainInfoBooleanBooleanInt32ConfigDataSkillInfoInt32_hotfix.call(new object[]
				{
					this,
					a0,
					a1,
					terrain0,
					terrain1,
					isMagicAttack0,
					isMagicAttack1,
					armyRelationValue,
					attackerSkillInfo,
					attackerSide
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_armyRelationValue = armyRelationValue;
			if (terrain0 != null)
			{
				this.m_actor0TerrainText.text = terrain0.Name;
				this.m_actor0TerrainDefText.text = terrain0.BattleBonus + "%";
				this.m_actor0TerrainImage.sprite = AssetUtility.Instance.GetSprite(terrain0.InfoImage);
			}
			this.m_propertyComputer.ComputeHeroBuffProperties(a0);
			BattleProperty property = this.m_propertyComputer.Property1;
			this.m_actor0CharUIStateController.SetToUIState("Normal", false, true);
			ConfigDataCharImageInfo charImageInfo = a0.HeroInfo.GetCharImageInfo(a0.HeroStar);
			if (charImageInfo != null)
			{
				this.m_actor0CharIcon.sprite = AssetUtility.Instance.GetSprite(AssetUtility.MakeSpriteAssetName(charImageInfo.CardHeadImage, "_0"));
			}
			this.m_actor0TypeIcon.sprite = AssetUtility.Instance.GetSprite(a0.HeroArmyInfo.Icon);
			this.SetHeroHp(0, a0.HeroHealthPoint, property.HealthPointMax);
			this.m_actor0NameText.text = a0.HeroInfo.Name;
			this.m_actor0LvValueText.text = a0.HeroLevel.ToString();
			if (isMagicAttack0)
			{
				this.m_actor0Proprety1NameText.SetToUIState("Magic", false, true);
				this.m_actor0Proprety1ValueText.text = property.Magic.ToString();
			}
			else
			{
				this.m_actor0Proprety1NameText.SetToUIState("AT", false, true);
				this.m_actor0Proprety1ValueText.text = property.Attack.ToString();
			}
			if (isMagicAttack1)
			{
				this.m_actor0Proprety2NameText.SetToUIState("MagicDF", false, true);
				this.m_actor0Proprety2ValueText.text = property.MagicDefense.ToString();
			}
			else
			{
				this.m_actor0Proprety2NameText.SetToUIState("DF", false, true);
				this.m_actor0Proprety2ValueText.text = property.Defense.ToString();
			}
			if (a0.SoldierInfo != null)
			{
				this.m_actor0SoldierGroupGameObject.SetActive(true);
				this.m_actor0SoldierTypeIcon.sprite = AssetUtility.Instance.GetSprite(a0.SoldierArmyInfo.Icon);
				this.m_actor0SoldierNameText.text = a0.SoldierInfo.Name;
				this.SetSoldierHp(0, a0.SoldierTotalHealthPoint, a0.SoldierBattleProperty.HealthPointMax);
			}
			else
			{
				this.m_actor0SoldierGroupGameObject.SetActive(false);
			}
			this.m_actor0SituationGroup.gameObject.SetActive(armyRelationValue != 0);
			if (armyRelationValue > 0)
			{
				this.m_actor0SituationGroup.SetToUIState("Advantage", false, true);
			}
			else if (armyRelationValue < 0)
			{
				this.m_actor0SituationGroup.SetToUIState("Weak", false, true);
			}
			if (terrain1 != null)
			{
				this.m_actor1TerrainText.text = terrain1.Name;
				this.m_actor1TerrainDefText.text = terrain1.BattleBonus + "%";
				this.m_actor1TerrainImage.sprite = AssetUtility.Instance.GetSprite(terrain1.InfoImage);
			}
			this.m_propertyComputer.ComputeHeroBuffProperties(a1);
			property = this.m_propertyComputer.Property1;
			this.m_actor1CharUIStateController.SetToUIState("Normal", false, true);
			ConfigDataCharImageInfo charImageInfo2 = a1.HeroInfo.GetCharImageInfo(a1.HeroStar);
			if (charImageInfo2 != null)
			{
				this.m_actor1CharIcon.sprite = AssetUtility.Instance.GetSprite(AssetUtility.MakeSpriteAssetName(charImageInfo2.CardHeadImage, "_0"));
			}
			this.m_actor1TypeIcon.sprite = AssetUtility.Instance.GetSprite(a1.HeroArmyInfo.Icon);
			this.SetHeroHp(1, a1.HeroHealthPoint, property.HealthPointMax);
			this.m_actor1NameText.text = a1.HeroInfo.Name;
			this.m_actor1LvValueText.text = a1.HeroLevel.ToString();
			if (isMagicAttack1)
			{
				this.m_actor1Proprety1NameText.SetToUIState("Magic", false, true);
				this.m_actor1Proprety1ValueText.text = property.Magic.ToString();
			}
			else
			{
				this.m_actor1Proprety1NameText.SetToUIState("AT", false, true);
				this.m_actor1Proprety1ValueText.text = property.Attack.ToString();
			}
			if (isMagicAttack0)
			{
				this.m_actor1Proprety2NameText.SetToUIState("MagicDF", false, true);
				this.m_actor1Proprety2ValueText.text = property.MagicDefense.ToString();
			}
			else
			{
				this.m_actor1Proprety2NameText.SetToUIState("DF", false, true);
				this.m_actor1Proprety2ValueText.text = property.Defense.ToString();
			}
			if (a1.SoldierInfo != null)
			{
				this.m_actor1SoldierGroupGameObject.SetActive(true);
				this.m_actor1SoldierTypeIcon.sprite = AssetUtility.Instance.GetSprite(a1.SoldierArmyInfo.Icon);
				this.m_actor1SoldierNameText.text = a1.SoldierInfo.Name;
				this.SetSoldierHp(1, a1.SoldierTotalHealthPoint, a1.SoldierBattleProperty.HealthPointMax);
			}
			else
			{
				this.m_actor1SoldierGroupGameObject.SetActive(false);
			}
			this.m_actor1SituationGroup.gameObject.SetActive(armyRelationValue != 0);
			if (armyRelationValue < 0)
			{
				this.m_actor1SituationGroup.SetToUIState("Advantage", false, true);
			}
			else if (armyRelationValue > 0)
			{
				this.m_actor1SituationGroup.SetToUIState("Weak", false, true);
			}
			this.m_actor0SkillGo.SetActive(attackerSkillInfo != null && attackerSide == 0);
			this.m_actor1SkillGo.SetActive(attackerSkillInfo != null && attackerSide == 1);
			if (attackerSkillInfo != null)
			{
				if (attackerSide == 0)
				{
					this.m_actor0SkillIconImage.sprite = AssetUtility.Instance.GetSprite(attackerSkillInfo.Icon);
				}
				else
				{
					this.m_actor1SkillIconImage.sprite = AssetUtility.Instance.GetSprite(attackerSkillInfo.Icon);
				}
			}
		}

		// Token: 0x0600BC5F RID: 48223 RVA: 0x0034D204 File Offset: 0x0034B404
		private void SetHeroHp(int side, int hp, int hpMax)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetHeroHpInt32Int32Int32_hotfix != null)
			{
				this.m_SetHeroHpInt32Int32Int32_hotfix.call(new object[]
				{
					this,
					side,
					hp,
					hpMax
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (side == 0)
			{
				this.m_actor0HpText.text = hp + " / " + hpMax;
				this.m_actor0HpProgressBar.fillAmount = (float)hp / (float)hpMax;
			}
			else if (side == 1)
			{
				this.m_actor1HpText.text = hp + " / " + hpMax;
				this.m_actor1HpProgressBar.fillAmount = (float)hp / (float)hpMax;
			}
		}

		// Token: 0x0600BC60 RID: 48224 RVA: 0x0034D308 File Offset: 0x0034B508
		private void SetSoldierHp(int side, int hp, int hpMax)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetSoldierHpInt32Int32Int32_hotfix != null)
			{
				this.m_SetSoldierHpInt32Int32Int32_hotfix.call(new object[]
				{
					this,
					side,
					hp,
					hpMax
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (side == 0)
			{
				this.m_actor0SoldierHpText.text = hp + " / " + hpMax;
				this.m_actor0SoldierHpProgressBar.fillAmount = (float)hp / (float)hpMax;
			}
			else if (side == 1)
			{
				this.m_actor1SoldierHpText.text = hp + " / " + hpMax;
				this.m_actor1SoldierHpProgressBar.fillAmount = (float)hp / (float)hpMax;
			}
		}

		// Token: 0x0600BC61 RID: 48225 RVA: 0x0034D40C File Offset: 0x0034B60C
		public void OpenAndShowFastCombat(FastCombatActorInfo a0, FastCombatActorInfo a1)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OpenAndShowFastCombatFastCombatActorInfoFastCombatActorInfo_hotfix != null)
			{
				this.m_OpenAndShowFastCombatFastCombatActorInfoFastCombatActorInfo_hotfix.call(new object[]
				{
					this,
					a0,
					a1
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_isOpened = true;
			this.m_isFastCombat = true;
			this.Show();
			this.ShowOkCancelButton(false);
			base.StartCoroutine(this.Co_OpenAndFastCombat(a0, a1));
		}

		// Token: 0x0600BC62 RID: 48226 RVA: 0x0034D4B8 File Offset: 0x0034B6B8
		[DebuggerHidden]
		private IEnumerator Co_OpenAndFastCombat(FastCombatActorInfo a0, FastCombatActorInfo a1)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Co_OpenAndFastCombatFastCombatActorInfoFastCombatActorInfo_hotfix != null)
			{
				return (IEnumerator)this.m_Co_OpenAndFastCombatFastCombatActorInfoFastCombatActorInfo_hotfix.call(new object[]
				{
					this,
					a0,
					a1
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			PreCombatUIController.<Co_OpenAndFastCombat>c__Iterator0 <Co_OpenAndFastCombat>c__Iterator = new PreCombatUIController.<Co_OpenAndFastCombat>c__Iterator0();
			<Co_OpenAndFastCombat>c__Iterator.a0 = a0;
			<Co_OpenAndFastCombat>c__Iterator.a1 = a1;
			<Co_OpenAndFastCombat>c__Iterator.$this = this;
			return <Co_OpenAndFastCombat>c__Iterator;
		}

		// Token: 0x0600BC63 RID: 48227 RVA: 0x0034D560 File Offset: 0x0034B760
		public void ShowFastCombat(FastCombatActorInfo a0, FastCombatActorInfo a1)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowFastCombatFastCombatActorInfoFastCombatActorInfo_hotfix != null)
			{
				this.m_ShowFastCombatFastCombatActorInfoFastCombatActorInfo_hotfix.call(new object[]
				{
					this,
					a0,
					a1
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.StartCoroutine(this.Co_FastCombat(a0, a1));
		}

		// Token: 0x0600BC64 RID: 48228 RVA: 0x0034D5F0 File Offset: 0x0034B7F0
		[DebuggerHidden]
		private IEnumerator Co_FastCombat(FastCombatActorInfo a0, FastCombatActorInfo a1)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Co_FastCombatFastCombatActorInfoFastCombatActorInfo_hotfix != null)
			{
				return (IEnumerator)this.m_Co_FastCombatFastCombatActorInfoFastCombatActorInfo_hotfix.call(new object[]
				{
					this,
					a0,
					a1
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			PreCombatUIController.<Co_FastCombat>c__Iterator1 <Co_FastCombat>c__Iterator = new PreCombatUIController.<Co_FastCombat>c__Iterator1();
			<Co_FastCombat>c__Iterator.a0 = a0;
			<Co_FastCombat>c__Iterator.a1 = a1;
			<Co_FastCombat>c__Iterator.$this = this;
			return <Co_FastCombat>c__Iterator;
		}

		// Token: 0x0600BC65 RID: 48229 RVA: 0x0034D698 File Offset: 0x0034B898
		[DebuggerHidden]
		private IEnumerator Co_PlayDamage(int side, FastCombatActorInfo a)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Co_PlayDamageInt32FastCombatActorInfo_hotfix != null)
			{
				return (IEnumerator)this.m_Co_PlayDamageInt32FastCombatActorInfo_hotfix.call(new object[]
				{
					this,
					side,
					a
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			PreCombatUIController.<Co_PlayDamage>c__Iterator2 <Co_PlayDamage>c__Iterator = new PreCombatUIController.<Co_PlayDamage>c__Iterator2();
			<Co_PlayDamage>c__Iterator.side = side;
			<Co_PlayDamage>c__Iterator.a = a;
			<Co_PlayDamage>c__Iterator.$this = this;
			return <Co_PlayDamage>c__Iterator;
		}

		// Token: 0x0600BC66 RID: 48230 RVA: 0x0034D740 File Offset: 0x0034B940
		[DebuggerHidden]
		private IEnumerator Co_PlayDamage(GameObject fxParent, int side, int beforeHp, int afterHp, int hpMax, bool isHero, int totalDamage, bool isCritical)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Co_PlayDamageGameObjectInt32Int32Int32Int32BooleanInt32Boolean_hotfix != null)
			{
				return (IEnumerator)this.m_Co_PlayDamageGameObjectInt32Int32Int32Int32BooleanInt32Boolean_hotfix.call(new object[]
				{
					this,
					fxParent,
					side,
					beforeHp,
					afterHp,
					hpMax,
					isHero,
					totalDamage,
					isCritical
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			PreCombatUIController.<Co_PlayDamage>c__Iterator3 <Co_PlayDamage>c__Iterator = new PreCombatUIController.<Co_PlayDamage>c__Iterator3();
			<Co_PlayDamage>c__Iterator.beforeHp = beforeHp;
			<Co_PlayDamage>c__Iterator.afterHp = afterHp;
			<Co_PlayDamage>c__Iterator.hpMax = hpMax;
			<Co_PlayDamage>c__Iterator.isHero = isHero;
			<Co_PlayDamage>c__Iterator.side = side;
			<Co_PlayDamage>c__Iterator.totalDamage = totalDamage;
			<Co_PlayDamage>c__Iterator.isCritical = isCritical;
			<Co_PlayDamage>c__Iterator.fxParent = fxParent;
			<Co_PlayDamage>c__Iterator.$this = this;
			return <Co_PlayDamage>c__Iterator;
		}

		// Token: 0x0600BC67 RID: 48231 RVA: 0x0034D878 File Offset: 0x0034BA78
		private void PlayDamageFx(GameObject fxParent, int side, int hp, int hpMax, int damage, bool isLargeFx)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayDamageFxGameObjectInt32Int32Int32Int32Boolean_hotfix != null)
			{
				this.m_PlayDamageFxGameObjectInt32Int32Int32Int32Boolean_hotfix.call(new object[]
				{
					this,
					fxParent,
					side,
					hp,
					hpMax,
					damage,
					isLargeFx
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_fxPlayer == null)
			{
				return;
			}
			if (damage + hp > hpMax)
			{
				damage = hpMax - hp;
			}
			float x = (float)damage / (float)hpMax;
			bool flag = (side == 0 && UIUtility.IsUITaskRunning(typeof(ChatUITask))) || UIUtility.IsUITaskRunning(typeof(BusinessCardUITask));
			GenericGraphic genericGraphic = null;
			if (isLargeFx)
			{
				if (!flag)
				{
					genericGraphic = this.m_fxPlayer.Play("FX/UI_ABS/UIFX_HPBarBreak_L_Pfb.prefab");
				}
				AudioUtility.PlaySound(SoundTableId.SoundTableId_SkipCombatHpBreakL);
			}
			else
			{
				if (!flag)
				{
					genericGraphic = this.m_fxPlayer.Play("FX/UI_ABS/UIFX_HPBarBreak_S_Pfb.prefab");
				}
				AudioUtility.PlaySound(SoundTableId.SoundTableId_SkipCombatHpBreakS);
			}
			if (genericGraphic != null)
			{
				genericGraphic.AutoDelete(true);
				genericGraphic.SetPrefabScale(new Vector3(x, 1f, 1f));
				genericGraphic.SetParent(fxParent);
				RectTransform rectTransform = fxParent.transform as RectTransform;
				if (rectTransform != null)
				{
					Vector3 zero = Vector3.zero;
					zero.x = (float)hp * rectTransform.sizeDelta.x / (float)hpMax;
					genericGraphic.SetPosition(zero);
				}
			}
		}

		// Token: 0x0600BC68 RID: 48232 RVA: 0x0034DA44 File Offset: 0x0034BC44
		public void OnActorPassiveSkill(int side, BuffState sourceBuffState)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnActorPassiveSkillInt32BuffState_hotfix != null)
			{
				this.m_OnActorPassiveSkillInt32BuffState_hotfix.call(new object[]
				{
					this,
					side,
					sourceBuffState
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (sourceBuffState == null)
			{
				return;
			}
			CommonUIStateController ctrl;
			Image image;
			Image image2;
			Text text;
			if (side == 0)
			{
				ctrl = this.m_actor0PassiveSkillUIStateController;
				image = this.m_actor0PassiveSkillIconImage;
				image2 = this.m_actor0PassiveSkillTalentIconImage;
				text = this.m_actor0PassiveSkillNameText;
			}
			else
			{
				ctrl = this.m_actor1PassiveSkillUIStateController;
				image = this.m_actor1PassiveSkillIconImage;
				image2 = this.m_actor1PassiveSkillTalentIconImage;
				text = this.m_actor1PassiveSkillNameText;
			}
			if (sourceBuffState.m_sourceType == BuffSourceType.TalentPassiveSkill)
			{
				image.gameObject.SetActive(false);
				image2.gameObject.SetActive(true);
				image2.sprite = AssetUtility.Instance.GetSprite(sourceBuffState.m_buffInfo.Icon);
			}
			else
			{
				image.gameObject.SetActive(true);
				image2.gameObject.SetActive(false);
				image.sprite = AssetUtility.Instance.GetSprite(sourceBuffState.m_buffInfo.Icon);
			}
			text.text = sourceBuffState.m_buffInfo.Name;
			UIUtility.SetUIStateOpenAndClose(ctrl, "Open", "Close", null, false);
		}

		// Token: 0x0600BC69 RID: 48233 RVA: 0x0034DBA8 File Offset: 0x0034BDA8
		public void Close()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Close_hotfix != null)
			{
				this.m_Close_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.m_isOpened)
			{
				return;
			}
			this.m_isOpened = false;
			this.m_isFastCombat = false;
			this.m_battlePreviewStateCtrl.SetToUIState("Close", false, true);
		}

		// Token: 0x0600BC6A RID: 48234 RVA: 0x0034DC34 File Offset: 0x0034BE34
		private void OnOkButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnOkButtonClick_hotfix != null)
			{
				this.m_OnOkButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.ShowOkCancelButton(false);
			if (this.EventOnOk != null)
			{
				this.EventOnOk();
			}
		}

		// Token: 0x0600BC6B RID: 48235 RVA: 0x0034DCB4 File Offset: 0x0034BEB4
		private void OnCancelButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnCancelButtonClick_hotfix != null)
			{
				this.m_OnCancelButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.ShowOkCancelButton(false);
			if (this.EventOnCancel != null)
			{
				this.EventOnCancel();
			}
		}

		// Token: 0x0600BC6C RID: 48236 RVA: 0x0034DD34 File Offset: 0x0034BF34
		private void OnBackgroundButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnBackgroundButtonClick_hotfix != null)
			{
				this.m_OnBackgroundButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_cancelButton.gameObject.activeSelf)
			{
				this.OnCancelButtonClick();
			}
		}

		// Token: 0x14000245 RID: 581
		// (add) Token: 0x0600BC6D RID: 48237 RVA: 0x0034DDB0 File Offset: 0x0034BFB0
		// (remove) Token: 0x0600BC6E RID: 48238 RVA: 0x0034DE4C File Offset: 0x0034C04C
		public event Action EventOnOk
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnOkAction_hotfix != null)
				{
					this.m_add_EventOnOkAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnOk;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnOk, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnOkAction_hotfix != null)
				{
					this.m_remove_EventOnOkAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnOk;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnOk, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000246 RID: 582
		// (add) Token: 0x0600BC6F RID: 48239 RVA: 0x0034DEE8 File Offset: 0x0034C0E8
		// (remove) Token: 0x0600BC70 RID: 48240 RVA: 0x0034DF84 File Offset: 0x0034C184
		public event Action EventOnCancel
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnCancelAction_hotfix != null)
				{
					this.m_add_EventOnCancelAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnCancel;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnCancel, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnCancelAction_hotfix != null)
				{
					this.m_remove_EventOnCancelAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnCancel;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnCancel, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000247 RID: 583
		// (add) Token: 0x0600BC71 RID: 48241 RVA: 0x0034E020 File Offset: 0x0034C220
		// (remove) Token: 0x0600BC72 RID: 48242 RVA: 0x0034E0BC File Offset: 0x0034C2BC
		public event Action EventOnStop
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnStopAction_hotfix != null)
				{
					this.m_add_EventOnStopAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnStop;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnStop, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnStopAction_hotfix != null)
				{
					this.m_remove_EventOnStopAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnStop;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnStop, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x170025B2 RID: 9650
		// (get) Token: 0x0600BC73 RID: 48243 RVA: 0x0034E158 File Offset: 0x0034C358
		// (set) Token: 0x0600BC74 RID: 48244 RVA: 0x0034E178 File Offset: 0x0034C378
		[DoNotToLua]
		public new PreCombatUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new PreCombatUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600BC75 RID: 48245 RVA: 0x0034E184 File Offset: 0x0034C384
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0600BC76 RID: 48246 RVA: 0x0034E190 File Offset: 0x0034C390
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0600BC77 RID: 48247 RVA: 0x0034E198 File Offset: 0x0034C398
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0600BC78 RID: 48248 RVA: 0x0034E1A0 File Offset: 0x0034C3A0
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0600BC79 RID: 48249 RVA: 0x0034E1B4 File Offset: 0x0034C3B4
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0600BC7A RID: 48250 RVA: 0x0034E1BC File Offset: 0x0034C3BC
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0600BC7B RID: 48251 RVA: 0x0034E1C8 File Offset: 0x0034C3C8
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0600BC7C RID: 48252 RVA: 0x0034E1D4 File Offset: 0x0034C3D4
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0600BC7D RID: 48253 RVA: 0x0034E1E0 File Offset: 0x0034C3E0
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0600BC7E RID: 48254 RVA: 0x0034E1EC File Offset: 0x0034C3EC
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0600BC7F RID: 48255 RVA: 0x0034E1F8 File Offset: 0x0034C3F8
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0600BC80 RID: 48256 RVA: 0x0034E204 File Offset: 0x0034C404
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0600BC81 RID: 48257 RVA: 0x0034E210 File Offset: 0x0034C410
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0600BC82 RID: 48258 RVA: 0x0034E21C File Offset: 0x0034C41C
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0600BC83 RID: 48259 RVA: 0x0034E228 File Offset: 0x0034C428
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600BC84 RID: 48260 RVA: 0x0034E230 File Offset: 0x0034C430
		private void __callDele_EventOnOk()
		{
			Action eventOnOk = this.EventOnOk;
			if (eventOnOk != null)
			{
				eventOnOk();
			}
		}

		// Token: 0x0600BC85 RID: 48261 RVA: 0x0034E250 File Offset: 0x0034C450
		private void __clearDele_EventOnOk()
		{
			this.EventOnOk = null;
		}

		// Token: 0x0600BC86 RID: 48262 RVA: 0x0034E25C File Offset: 0x0034C45C
		private void __callDele_EventOnCancel()
		{
			Action eventOnCancel = this.EventOnCancel;
			if (eventOnCancel != null)
			{
				eventOnCancel();
			}
		}

		// Token: 0x0600BC87 RID: 48263 RVA: 0x0034E27C File Offset: 0x0034C47C
		private void __clearDele_EventOnCancel()
		{
			this.EventOnCancel = null;
		}

		// Token: 0x0600BC88 RID: 48264 RVA: 0x0034E288 File Offset: 0x0034C488
		private void __callDele_EventOnStop()
		{
			Action eventOnStop = this.EventOnStop;
			if (eventOnStop != null)
			{
				eventOnStop();
			}
		}

		// Token: 0x0600BC89 RID: 48265 RVA: 0x0034E2A8 File Offset: 0x0034C4A8
		private void __clearDele_EventOnStop()
		{
			this.EventOnStop = null;
		}

		// Token: 0x0600BC8B RID: 48267 RVA: 0x0034E2C4 File Offset: 0x0034C4C4
		private bool InitHotFix(LuaTable A_1)
		{
			this.m_luaObjHelper = new BJLuaObjHelper();
			this.m_luaObjHelper.InitInCS(this, A_1);
			LuaFunction luaFunction = A_1.RawGet("HotFixObject") as LuaFunction;
			bool result;
			if (luaFunction == null)
			{
				global::Debug.LogError("Can't find HotFixObject Func");
				result = false;
			}
			else
			{
				luaFunction.call(new object[]
				{
					this,
					this.m_luaObjHelper
				});
				LuaTable luaObj = this.m_luaObjHelper.GetLuaObj();
				if (luaObj == null)
				{
					result = false;
				}
				else
				{
					this.m_OnDisable_hotfix = (luaObj.RawGet("OnDisable") as LuaFunction);
					this.m_OnBindFiledsCompleted_hotfix = (luaObj.RawGet("OnBindFiledsCompleted") as LuaFunction);
					this.m_InitializeFxPlayer_hotfix = (luaObj.RawGet("Initialize") as LuaFunction);
					this.m_Open_hotfix = (luaObj.RawGet("Open") as LuaFunction);
					this.m_IsOpened_hotfix = (luaObj.RawGet("IsOpened") as LuaFunction);
					this.m_IsFastCombat_hotfix = (luaObj.RawGet("IsFastCombat") as LuaFunction);
					this.m_Show_hotfix = (luaObj.RawGet("Show") as LuaFunction);
					this.m_ShowOkCancelButtonBoolean_hotfix = (luaObj.RawGet("ShowOkCancelButton") as LuaFunction);
					this.m_SetBattleActorInfoBattleActorBattleActorConfigDataTerrainInfoConfigDataTerrainInfoBooleanBooleanInt32ConfigDataSkillInfoInt32_hotfix = (luaObj.RawGet("SetBattleActorInfo") as LuaFunction);
					this.m_SetHeroHpInt32Int32Int32_hotfix = (luaObj.RawGet("SetHeroHp") as LuaFunction);
					this.m_SetSoldierHpInt32Int32Int32_hotfix = (luaObj.RawGet("SetSoldierHp") as LuaFunction);
					this.m_OpenAndShowFastCombatFastCombatActorInfoFastCombatActorInfo_hotfix = (luaObj.RawGet("OpenAndShowFastCombat") as LuaFunction);
					this.m_Co_OpenAndFastCombatFastCombatActorInfoFastCombatActorInfo_hotfix = (luaObj.RawGet("Co_OpenAndFastCombat") as LuaFunction);
					this.m_ShowFastCombatFastCombatActorInfoFastCombatActorInfo_hotfix = (luaObj.RawGet("ShowFastCombat") as LuaFunction);
					this.m_Co_FastCombatFastCombatActorInfoFastCombatActorInfo_hotfix = (luaObj.RawGet("Co_FastCombat") as LuaFunction);
					this.m_Co_PlayDamageInt32FastCombatActorInfo_hotfix = (luaObj.RawGet("Co_PlayDamage") as LuaFunction);
					this.m_Co_PlayDamageGameObjectInt32Int32Int32Int32BooleanInt32Boolean_hotfix = (luaObj.RawGet("Co_PlayDamage") as LuaFunction);
					this.m_PlayDamageFxGameObjectInt32Int32Int32Int32Boolean_hotfix = (luaObj.RawGet("PlayDamageFx") as LuaFunction);
					this.m_OnActorPassiveSkillInt32BuffState_hotfix = (luaObj.RawGet("OnActorPassiveSkill") as LuaFunction);
					this.m_Close_hotfix = (luaObj.RawGet("Close") as LuaFunction);
					this.m_OnOkButtonClick_hotfix = (luaObj.RawGet("OnOkButtonClick") as LuaFunction);
					this.m_OnCancelButtonClick_hotfix = (luaObj.RawGet("OnCancelButtonClick") as LuaFunction);
					this.m_OnBackgroundButtonClick_hotfix = (luaObj.RawGet("OnBackgroundButtonClick") as LuaFunction);
					this.m_add_EventOnOkAction_hotfix = (luaObj.RawGet("add_EventOnOk") as LuaFunction);
					this.m_remove_EventOnOkAction_hotfix = (luaObj.RawGet("remove_EventOnOk") as LuaFunction);
					this.m_add_EventOnCancelAction_hotfix = (luaObj.RawGet("add_EventOnCancel") as LuaFunction);
					this.m_remove_EventOnCancelAction_hotfix = (luaObj.RawGet("remove_EventOnCancel") as LuaFunction);
					this.m_add_EventOnStopAction_hotfix = (luaObj.RawGet("add_EventOnStop") as LuaFunction);
					this.m_remove_EventOnStopAction_hotfix = (luaObj.RawGet("remove_EventOnStop") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600BC8C RID: 48268 RVA: 0x0034E64C File Offset: 0x0034C84C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(PreCombatUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040078DC RID: 30940
		[AutoBind("./BackgroundImage", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_backgroundButton;

		// Token: 0x040078DD RID: 30941
		[AutoBind("./BattlePreview", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_battlePreviewStateCtrl;

		// Token: 0x040078DE RID: 30942
		[AutoBind("./Margin", AutoBindAttribute.InitState.NotInit, false)]
		private RectTransform m_marginTransform;

		// Token: 0x040078DF RID: 30943
		[AutoBind("./Margin/TerrainInfo0/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_actor0TerrainText;

		// Token: 0x040078E0 RID: 30944
		[AutoBind("./Margin/TerrainInfo0/Def/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_actor0TerrainDefText;

		// Token: 0x040078E1 RID: 30945
		[AutoBind("./Margin/TerrainInfo0/Image", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_actor0TerrainImage;

		// Token: 0x040078E2 RID: 30946
		[AutoBind("./Margin/Actor0", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_actor0UIStateController;

		// Token: 0x040078E3 RID: 30947
		[AutoBind("./Margin/Actor0/CharPanel", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_actor0CharUIStateController;

		// Token: 0x040078E4 RID: 30948
		[AutoBind("./Margin/Actor0/CharPanel/CharIcon", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_actor0CharIcon;

		// Token: 0x040078E5 RID: 30949
		[AutoBind("./Margin/Actor0/CharInfoGroup/SkillGroup", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_actor0SkillGo;

		// Token: 0x040078E6 RID: 30950
		[AutoBind("./Margin/Actor0/CharInfoGroup/SkillGroup/SkillIconImage", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_actor0SkillIconImage;

		// Token: 0x040078E7 RID: 30951
		[AutoBind("./Margin/Actor0/CharInfoGroup/TypeIcon", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_actor0TypeIcon;

		// Token: 0x040078E8 RID: 30952
		[AutoBind("./Margin/Actor0/CharInfoGroup/HpGroup/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_actor0HpText;

		// Token: 0x040078E9 RID: 30953
		[AutoBind("./Margin/Actor0/CharInfoGroup/HpGroup/ProgressBar", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_actor0HpProgressBar;

		// Token: 0x040078EA RID: 30954
		[AutoBind("./Margin/Actor0/CharInfoGroup/HpGroup/Fx", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_actor0HeroHpFxGameObeject;

		// Token: 0x040078EB RID: 30955
		[AutoBind("./Margin/Actor0/CharInfoGroup/Proprety1", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_actor0Proprety1NameText;

		// Token: 0x040078EC RID: 30956
		[AutoBind("./Margin/Actor0/CharInfoGroup/Proprety1/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_actor0Proprety1ValueText;

		// Token: 0x040078ED RID: 30957
		[AutoBind("./Margin/Actor0/CharInfoGroup/Proprety2", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_actor0Proprety2NameText;

		// Token: 0x040078EE RID: 30958
		[AutoBind("./Margin/Actor0/CharInfoGroup/Proprety2/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_actor0Proprety2ValueText;

		// Token: 0x040078EF RID: 30959
		[AutoBind("./Margin/Actor0/CharInfoGroup/NameText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_actor0NameText;

		// Token: 0x040078F0 RID: 30960
		[AutoBind("./Margin/Actor0/CharInfoGroup/LvText/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_actor0LvValueText;

		// Token: 0x040078F1 RID: 30961
		[AutoBind("./Margin/Actor0/SituationGroup", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_actor0SituationGroup;

		// Token: 0x040078F2 RID: 30962
		[AutoBind("./Margin/Actor0/SoldierInfoGroup", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_actor0SoldierGroupGameObject;

		// Token: 0x040078F3 RID: 30963
		[AutoBind("./Margin/Actor0/SoldierInfoGroup/TypeIcon", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_actor0SoldierTypeIcon;

		// Token: 0x040078F4 RID: 30964
		[AutoBind("./Margin/Actor0/SoldierInfoGroup/NameText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_actor0SoldierNameText;

		// Token: 0x040078F5 RID: 30965
		[AutoBind("./Margin/Actor0/SoldierInfoGroup/SoldierHpGroup/ProgressBar", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_actor0SoldierHpProgressBar;

		// Token: 0x040078F6 RID: 30966
		[AutoBind("./Margin/Actor0/SoldierInfoGroup/SoldierHpGroup/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_actor0SoldierHpText;

		// Token: 0x040078F7 RID: 30967
		[AutoBind("./Margin/Actor0/SoldierInfoGroup/SoldierHpGroup/Fx", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_actor0SoldierHpFxGameObeject;

		// Token: 0x040078F8 RID: 30968
		[AutoBind("./Margin/Actor0/Damage", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_actor0DamageUIStateController;

		// Token: 0x040078F9 RID: 30969
		[AutoBind("./Margin/Actor0/Damage/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_actor0DamageText;

		// Token: 0x040078FA RID: 30970
		[AutoBind("./Margin/Actor0/Damage/CriticalText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_actor0DamageCriticalText;

		// Token: 0x040078FB RID: 30971
		[AutoBind("./Margin/Actor0/PassiveSkill", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_actor0PassiveSkillUIStateController;

		// Token: 0x040078FC RID: 30972
		[AutoBind("./Margin/Actor0/PassiveSkill/IconImage", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_actor0PassiveSkillIconImage;

		// Token: 0x040078FD RID: 30973
		[AutoBind("./Margin/Actor0/PassiveSkill/TalentIconImage", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_actor0PassiveSkillTalentIconImage;

		// Token: 0x040078FE RID: 30974
		[AutoBind("./Margin/Actor0/PassiveSkill/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_actor0PassiveSkillNameText;

		// Token: 0x040078FF RID: 30975
		[AutoBind("./Margin/TerrainInfo1/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_actor1TerrainText;

		// Token: 0x04007900 RID: 30976
		[AutoBind("./Margin/TerrainInfo1/Def/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_actor1TerrainDefText;

		// Token: 0x04007901 RID: 30977
		[AutoBind("./Margin/TerrainInfo1/Image", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_actor1TerrainImage;

		// Token: 0x04007902 RID: 30978
		[AutoBind("./Margin/Actor1", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_actor1UIStateController;

		// Token: 0x04007903 RID: 30979
		[AutoBind("./Margin/Actor1/CharPanel", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_actor1CharUIStateController;

		// Token: 0x04007904 RID: 30980
		[AutoBind("./Margin/Actor1/CharPanel/CharIcon", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_actor1CharIcon;

		// Token: 0x04007905 RID: 30981
		[AutoBind("./Margin/Actor1/CharInfoGroup/SkillGroup", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_actor1SkillGo;

		// Token: 0x04007906 RID: 30982
		[AutoBind("./Margin/Actor1/CharInfoGroup/SkillGroup/SkillIconImage", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_actor1SkillIconImage;

		// Token: 0x04007907 RID: 30983
		[AutoBind("./Margin/Actor1/CharInfoGroup/TypeIcon", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_actor1TypeIcon;

		// Token: 0x04007908 RID: 30984
		[AutoBind("./Margin/Actor1/CharInfoGroup/HpGroup/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_actor1HpText;

		// Token: 0x04007909 RID: 30985
		[AutoBind("./Margin/Actor1/CharInfoGroup/HpGroup/ProgressBar", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_actor1HpProgressBar;

		// Token: 0x0400790A RID: 30986
		[AutoBind("./Margin/Actor1/CharInfoGroup/HpGroup/Fx", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_actor1HeroHpFxGameObeject;

		// Token: 0x0400790B RID: 30987
		[AutoBind("./Margin/Actor1/CharInfoGroup/Proprety1", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_actor1Proprety1NameText;

		// Token: 0x0400790C RID: 30988
		[AutoBind("./Margin/Actor1/CharInfoGroup/Proprety1/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_actor1Proprety1ValueText;

		// Token: 0x0400790D RID: 30989
		[AutoBind("./Margin/Actor1/CharInfoGroup/Proprety2", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_actor1Proprety2NameText;

		// Token: 0x0400790E RID: 30990
		[AutoBind("./Margin/Actor1/CharInfoGroup/Proprety2/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_actor1Proprety2ValueText;

		// Token: 0x0400790F RID: 30991
		[AutoBind("./Margin/Actor1/CharInfoGroup/NameText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_actor1NameText;

		// Token: 0x04007910 RID: 30992
		[AutoBind("./Margin/Actor1/CharInfoGroup/LvText/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_actor1LvValueText;

		// Token: 0x04007911 RID: 30993
		[AutoBind("./Margin/Actor1/SituationGroup", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_actor1SituationGroup;

		// Token: 0x04007912 RID: 30994
		[AutoBind("./Margin/Actor1/SoldierInfoGroup", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_actor1SoldierGroupGameObject;

		// Token: 0x04007913 RID: 30995
		[AutoBind("./Margin/Actor1/SoldierInfoGroup/TypeIcon", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_actor1SoldierTypeIcon;

		// Token: 0x04007914 RID: 30996
		[AutoBind("./Margin/Actor1/SoldierInfoGroup/NameText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_actor1SoldierNameText;

		// Token: 0x04007915 RID: 30997
		[AutoBind("./Margin/Actor1/SoldierInfoGroup/SoldierHpGroup/ProgressBar", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_actor1SoldierHpProgressBar;

		// Token: 0x04007916 RID: 30998
		[AutoBind("./Margin/Actor1/SoldierInfoGroup/SoldierHpGroup/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_actor1SoldierHpText;

		// Token: 0x04007917 RID: 30999
		[AutoBind("./Margin/Actor1/SoldierInfoGroup/SoldierHpGroup/Fx", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_actor1SoldierHpFxGameObeject;

		// Token: 0x04007918 RID: 31000
		[AutoBind("./Margin/Actor1/Damage", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_actor1DamageUIStateController;

		// Token: 0x04007919 RID: 31001
		[AutoBind("./Margin/Actor1/Damage/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_actor1DamageText;

		// Token: 0x0400791A RID: 31002
		[AutoBind("./Margin/Actor1/Damage/CriticalText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_actor1DamageCriticalText;

		// Token: 0x0400791B RID: 31003
		[AutoBind("./Margin/Actor1/PassiveSkill", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_actor1PassiveSkillUIStateController;

		// Token: 0x0400791C RID: 31004
		[AutoBind("./Margin/Actor1/PassiveSkill/IconImage", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_actor1PassiveSkillIconImage;

		// Token: 0x0400791D RID: 31005
		[AutoBind("./Margin/Actor1/PassiveSkill/TalentIconImage", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_actor1PassiveSkillTalentIconImage;

		// Token: 0x0400791E RID: 31006
		[AutoBind("./Margin/Actor1/PassiveSkill/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_actor1PassiveSkillNameText;

		// Token: 0x0400791F RID: 31007
		[AutoBind("./ButtonGroup/OkButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_okButton;

		// Token: 0x04007920 RID: 31008
		[AutoBind("./ButtonGroup/CancelButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_cancelButton;

		// Token: 0x04007921 RID: 31009
		private int m_armyRelationValue;

		// Token: 0x04007922 RID: 31010
		private int m_totalDamage0;

		// Token: 0x04007923 RID: 31011
		private int m_totalDamage1;

		// Token: 0x04007924 RID: 31012
		private FxPlayer m_fxPlayer;

		// Token: 0x04007925 RID: 31013
		private bool m_isOpened;

		// Token: 0x04007926 RID: 31014
		private bool m_isFastCombat;

		// Token: 0x04007927 RID: 31015
		private HeroPropertyComputer m_propertyComputer = new HeroPropertyComputer();

		// Token: 0x04007928 RID: 31016
		[DoNotToLua]
		private PreCombatUIController.LuaExportHelper luaExportHelper;

		// Token: 0x04007929 RID: 31017
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400792A RID: 31018
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400792B RID: 31019
		private LuaFunction m_OnDisable_hotfix;

		// Token: 0x0400792C RID: 31020
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x0400792D RID: 31021
		private LuaFunction m_InitializeFxPlayer_hotfix;

		// Token: 0x0400792E RID: 31022
		private LuaFunction m_Open_hotfix;

		// Token: 0x0400792F RID: 31023
		private LuaFunction m_IsOpened_hotfix;

		// Token: 0x04007930 RID: 31024
		private LuaFunction m_IsFastCombat_hotfix;

		// Token: 0x04007931 RID: 31025
		private LuaFunction m_Show_hotfix;

		// Token: 0x04007932 RID: 31026
		private LuaFunction m_ShowOkCancelButtonBoolean_hotfix;

		// Token: 0x04007933 RID: 31027
		private LuaFunction m_SetBattleActorInfoBattleActorBattleActorConfigDataTerrainInfoConfigDataTerrainInfoBooleanBooleanInt32ConfigDataSkillInfoInt32_hotfix;

		// Token: 0x04007934 RID: 31028
		private LuaFunction m_SetHeroHpInt32Int32Int32_hotfix;

		// Token: 0x04007935 RID: 31029
		private LuaFunction m_SetSoldierHpInt32Int32Int32_hotfix;

		// Token: 0x04007936 RID: 31030
		private LuaFunction m_OpenAndShowFastCombatFastCombatActorInfoFastCombatActorInfo_hotfix;

		// Token: 0x04007937 RID: 31031
		private LuaFunction m_Co_OpenAndFastCombatFastCombatActorInfoFastCombatActorInfo_hotfix;

		// Token: 0x04007938 RID: 31032
		private LuaFunction m_ShowFastCombatFastCombatActorInfoFastCombatActorInfo_hotfix;

		// Token: 0x04007939 RID: 31033
		private LuaFunction m_Co_FastCombatFastCombatActorInfoFastCombatActorInfo_hotfix;

		// Token: 0x0400793A RID: 31034
		private LuaFunction m_Co_PlayDamageInt32FastCombatActorInfo_hotfix;

		// Token: 0x0400793B RID: 31035
		private LuaFunction m_Co_PlayDamageGameObjectInt32Int32Int32Int32BooleanInt32Boolean_hotfix;

		// Token: 0x0400793C RID: 31036
		private LuaFunction m_PlayDamageFxGameObjectInt32Int32Int32Int32Boolean_hotfix;

		// Token: 0x0400793D RID: 31037
		private LuaFunction m_OnActorPassiveSkillInt32BuffState_hotfix;

		// Token: 0x0400793E RID: 31038
		private LuaFunction m_Close_hotfix;

		// Token: 0x0400793F RID: 31039
		private LuaFunction m_OnOkButtonClick_hotfix;

		// Token: 0x04007940 RID: 31040
		private LuaFunction m_OnCancelButtonClick_hotfix;

		// Token: 0x04007941 RID: 31041
		private LuaFunction m_OnBackgroundButtonClick_hotfix;

		// Token: 0x04007942 RID: 31042
		private LuaFunction m_add_EventOnOkAction_hotfix;

		// Token: 0x04007943 RID: 31043
		private LuaFunction m_remove_EventOnOkAction_hotfix;

		// Token: 0x04007944 RID: 31044
		private LuaFunction m_add_EventOnCancelAction_hotfix;

		// Token: 0x04007945 RID: 31045
		private LuaFunction m_remove_EventOnCancelAction_hotfix;

		// Token: 0x04007946 RID: 31046
		private LuaFunction m_add_EventOnStopAction_hotfix;

		// Token: 0x04007947 RID: 31047
		private LuaFunction m_remove_EventOnStopAction_hotfix;

		// Token: 0x02000AFF RID: 2815
		public new class LuaExportHelper
		{
			// Token: 0x0600BC8D RID: 48269 RVA: 0x0034E6B4 File Offset: 0x0034C8B4
			public LuaExportHelper(PreCombatUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600BC8E RID: 48270 RVA: 0x0034E6C4 File Offset: 0x0034C8C4
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0600BC8F RID: 48271 RVA: 0x0034E6D4 File Offset: 0x0034C8D4
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0600BC90 RID: 48272 RVA: 0x0034E6E4 File Offset: 0x0034C8E4
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600BC91 RID: 48273 RVA: 0x0034E6F4 File Offset: 0x0034C8F4
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600BC92 RID: 48274 RVA: 0x0034E70C File Offset: 0x0034C90C
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0600BC93 RID: 48275 RVA: 0x0034E71C File Offset: 0x0034C91C
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0600BC94 RID: 48276 RVA: 0x0034E72C File Offset: 0x0034C92C
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0600BC95 RID: 48277 RVA: 0x0034E73C File Offset: 0x0034C93C
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0600BC96 RID: 48278 RVA: 0x0034E74C File Offset: 0x0034C94C
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0600BC97 RID: 48279 RVA: 0x0034E75C File Offset: 0x0034C95C
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0600BC98 RID: 48280 RVA: 0x0034E76C File Offset: 0x0034C96C
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0600BC99 RID: 48281 RVA: 0x0034E77C File Offset: 0x0034C97C
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0600BC9A RID: 48282 RVA: 0x0034E78C File Offset: 0x0034C98C
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0600BC9B RID: 48283 RVA: 0x0034E79C File Offset: 0x0034C99C
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0600BC9C RID: 48284 RVA: 0x0034E7AC File Offset: 0x0034C9AC
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x0600BC9D RID: 48285 RVA: 0x0034E7BC File Offset: 0x0034C9BC
			public void __callDele_EventOnOk()
			{
				this.m_owner.__callDele_EventOnOk();
			}

			// Token: 0x0600BC9E RID: 48286 RVA: 0x0034E7CC File Offset: 0x0034C9CC
			public void __clearDele_EventOnOk()
			{
				this.m_owner.__clearDele_EventOnOk();
			}

			// Token: 0x0600BC9F RID: 48287 RVA: 0x0034E7DC File Offset: 0x0034C9DC
			public void __callDele_EventOnCancel()
			{
				this.m_owner.__callDele_EventOnCancel();
			}

			// Token: 0x0600BCA0 RID: 48288 RVA: 0x0034E7EC File Offset: 0x0034C9EC
			public void __clearDele_EventOnCancel()
			{
				this.m_owner.__clearDele_EventOnCancel();
			}

			// Token: 0x0600BCA1 RID: 48289 RVA: 0x0034E7FC File Offset: 0x0034C9FC
			public void __callDele_EventOnStop()
			{
				this.m_owner.__callDele_EventOnStop();
			}

			// Token: 0x0600BCA2 RID: 48290 RVA: 0x0034E80C File Offset: 0x0034CA0C
			public void __clearDele_EventOnStop()
			{
				this.m_owner.__clearDele_EventOnStop();
			}

			// Token: 0x170025B3 RID: 9651
			// (get) Token: 0x0600BCA3 RID: 48291 RVA: 0x0034E81C File Offset: 0x0034CA1C
			// (set) Token: 0x0600BCA4 RID: 48292 RVA: 0x0034E82C File Offset: 0x0034CA2C
			public Button m_backgroundButton
			{
				get
				{
					return this.m_owner.m_backgroundButton;
				}
				set
				{
					this.m_owner.m_backgroundButton = value;
				}
			}

			// Token: 0x170025B4 RID: 9652
			// (get) Token: 0x0600BCA5 RID: 48293 RVA: 0x0034E83C File Offset: 0x0034CA3C
			// (set) Token: 0x0600BCA6 RID: 48294 RVA: 0x0034E84C File Offset: 0x0034CA4C
			public CommonUIStateController m_battlePreviewStateCtrl
			{
				get
				{
					return this.m_owner.m_battlePreviewStateCtrl;
				}
				set
				{
					this.m_owner.m_battlePreviewStateCtrl = value;
				}
			}

			// Token: 0x170025B5 RID: 9653
			// (get) Token: 0x0600BCA7 RID: 48295 RVA: 0x0034E85C File Offset: 0x0034CA5C
			// (set) Token: 0x0600BCA8 RID: 48296 RVA: 0x0034E86C File Offset: 0x0034CA6C
			public RectTransform m_marginTransform
			{
				get
				{
					return this.m_owner.m_marginTransform;
				}
				set
				{
					this.m_owner.m_marginTransform = value;
				}
			}

			// Token: 0x170025B6 RID: 9654
			// (get) Token: 0x0600BCA9 RID: 48297 RVA: 0x0034E87C File Offset: 0x0034CA7C
			// (set) Token: 0x0600BCAA RID: 48298 RVA: 0x0034E88C File Offset: 0x0034CA8C
			public Text m_actor0TerrainText
			{
				get
				{
					return this.m_owner.m_actor0TerrainText;
				}
				set
				{
					this.m_owner.m_actor0TerrainText = value;
				}
			}

			// Token: 0x170025B7 RID: 9655
			// (get) Token: 0x0600BCAB RID: 48299 RVA: 0x0034E89C File Offset: 0x0034CA9C
			// (set) Token: 0x0600BCAC RID: 48300 RVA: 0x0034E8AC File Offset: 0x0034CAAC
			public Text m_actor0TerrainDefText
			{
				get
				{
					return this.m_owner.m_actor0TerrainDefText;
				}
				set
				{
					this.m_owner.m_actor0TerrainDefText = value;
				}
			}

			// Token: 0x170025B8 RID: 9656
			// (get) Token: 0x0600BCAD RID: 48301 RVA: 0x0034E8BC File Offset: 0x0034CABC
			// (set) Token: 0x0600BCAE RID: 48302 RVA: 0x0034E8CC File Offset: 0x0034CACC
			public Image m_actor0TerrainImage
			{
				get
				{
					return this.m_owner.m_actor0TerrainImage;
				}
				set
				{
					this.m_owner.m_actor0TerrainImage = value;
				}
			}

			// Token: 0x170025B9 RID: 9657
			// (get) Token: 0x0600BCAF RID: 48303 RVA: 0x0034E8DC File Offset: 0x0034CADC
			// (set) Token: 0x0600BCB0 RID: 48304 RVA: 0x0034E8EC File Offset: 0x0034CAEC
			public CommonUIStateController m_actor0UIStateController
			{
				get
				{
					return this.m_owner.m_actor0UIStateController;
				}
				set
				{
					this.m_owner.m_actor0UIStateController = value;
				}
			}

			// Token: 0x170025BA RID: 9658
			// (get) Token: 0x0600BCB1 RID: 48305 RVA: 0x0034E8FC File Offset: 0x0034CAFC
			// (set) Token: 0x0600BCB2 RID: 48306 RVA: 0x0034E90C File Offset: 0x0034CB0C
			public CommonUIStateController m_actor0CharUIStateController
			{
				get
				{
					return this.m_owner.m_actor0CharUIStateController;
				}
				set
				{
					this.m_owner.m_actor0CharUIStateController = value;
				}
			}

			// Token: 0x170025BB RID: 9659
			// (get) Token: 0x0600BCB3 RID: 48307 RVA: 0x0034E91C File Offset: 0x0034CB1C
			// (set) Token: 0x0600BCB4 RID: 48308 RVA: 0x0034E92C File Offset: 0x0034CB2C
			public Image m_actor0CharIcon
			{
				get
				{
					return this.m_owner.m_actor0CharIcon;
				}
				set
				{
					this.m_owner.m_actor0CharIcon = value;
				}
			}

			// Token: 0x170025BC RID: 9660
			// (get) Token: 0x0600BCB5 RID: 48309 RVA: 0x0034E93C File Offset: 0x0034CB3C
			// (set) Token: 0x0600BCB6 RID: 48310 RVA: 0x0034E94C File Offset: 0x0034CB4C
			public GameObject m_actor0SkillGo
			{
				get
				{
					return this.m_owner.m_actor0SkillGo;
				}
				set
				{
					this.m_owner.m_actor0SkillGo = value;
				}
			}

			// Token: 0x170025BD RID: 9661
			// (get) Token: 0x0600BCB7 RID: 48311 RVA: 0x0034E95C File Offset: 0x0034CB5C
			// (set) Token: 0x0600BCB8 RID: 48312 RVA: 0x0034E96C File Offset: 0x0034CB6C
			public Image m_actor0SkillIconImage
			{
				get
				{
					return this.m_owner.m_actor0SkillIconImage;
				}
				set
				{
					this.m_owner.m_actor0SkillIconImage = value;
				}
			}

			// Token: 0x170025BE RID: 9662
			// (get) Token: 0x0600BCB9 RID: 48313 RVA: 0x0034E97C File Offset: 0x0034CB7C
			// (set) Token: 0x0600BCBA RID: 48314 RVA: 0x0034E98C File Offset: 0x0034CB8C
			public Image m_actor0TypeIcon
			{
				get
				{
					return this.m_owner.m_actor0TypeIcon;
				}
				set
				{
					this.m_owner.m_actor0TypeIcon = value;
				}
			}

			// Token: 0x170025BF RID: 9663
			// (get) Token: 0x0600BCBB RID: 48315 RVA: 0x0034E99C File Offset: 0x0034CB9C
			// (set) Token: 0x0600BCBC RID: 48316 RVA: 0x0034E9AC File Offset: 0x0034CBAC
			public Text m_actor0HpText
			{
				get
				{
					return this.m_owner.m_actor0HpText;
				}
				set
				{
					this.m_owner.m_actor0HpText = value;
				}
			}

			// Token: 0x170025C0 RID: 9664
			// (get) Token: 0x0600BCBD RID: 48317 RVA: 0x0034E9BC File Offset: 0x0034CBBC
			// (set) Token: 0x0600BCBE RID: 48318 RVA: 0x0034E9CC File Offset: 0x0034CBCC
			public Image m_actor0HpProgressBar
			{
				get
				{
					return this.m_owner.m_actor0HpProgressBar;
				}
				set
				{
					this.m_owner.m_actor0HpProgressBar = value;
				}
			}

			// Token: 0x170025C1 RID: 9665
			// (get) Token: 0x0600BCBF RID: 48319 RVA: 0x0034E9DC File Offset: 0x0034CBDC
			// (set) Token: 0x0600BCC0 RID: 48320 RVA: 0x0034E9EC File Offset: 0x0034CBEC
			public GameObject m_actor0HeroHpFxGameObeject
			{
				get
				{
					return this.m_owner.m_actor0HeroHpFxGameObeject;
				}
				set
				{
					this.m_owner.m_actor0HeroHpFxGameObeject = value;
				}
			}

			// Token: 0x170025C2 RID: 9666
			// (get) Token: 0x0600BCC1 RID: 48321 RVA: 0x0034E9FC File Offset: 0x0034CBFC
			// (set) Token: 0x0600BCC2 RID: 48322 RVA: 0x0034EA0C File Offset: 0x0034CC0C
			public CommonUIStateController m_actor0Proprety1NameText
			{
				get
				{
					return this.m_owner.m_actor0Proprety1NameText;
				}
				set
				{
					this.m_owner.m_actor0Proprety1NameText = value;
				}
			}

			// Token: 0x170025C3 RID: 9667
			// (get) Token: 0x0600BCC3 RID: 48323 RVA: 0x0034EA1C File Offset: 0x0034CC1C
			// (set) Token: 0x0600BCC4 RID: 48324 RVA: 0x0034EA2C File Offset: 0x0034CC2C
			public Text m_actor0Proprety1ValueText
			{
				get
				{
					return this.m_owner.m_actor0Proprety1ValueText;
				}
				set
				{
					this.m_owner.m_actor0Proprety1ValueText = value;
				}
			}

			// Token: 0x170025C4 RID: 9668
			// (get) Token: 0x0600BCC5 RID: 48325 RVA: 0x0034EA3C File Offset: 0x0034CC3C
			// (set) Token: 0x0600BCC6 RID: 48326 RVA: 0x0034EA4C File Offset: 0x0034CC4C
			public CommonUIStateController m_actor0Proprety2NameText
			{
				get
				{
					return this.m_owner.m_actor0Proprety2NameText;
				}
				set
				{
					this.m_owner.m_actor0Proprety2NameText = value;
				}
			}

			// Token: 0x170025C5 RID: 9669
			// (get) Token: 0x0600BCC7 RID: 48327 RVA: 0x0034EA5C File Offset: 0x0034CC5C
			// (set) Token: 0x0600BCC8 RID: 48328 RVA: 0x0034EA6C File Offset: 0x0034CC6C
			public Text m_actor0Proprety2ValueText
			{
				get
				{
					return this.m_owner.m_actor0Proprety2ValueText;
				}
				set
				{
					this.m_owner.m_actor0Proprety2ValueText = value;
				}
			}

			// Token: 0x170025C6 RID: 9670
			// (get) Token: 0x0600BCC9 RID: 48329 RVA: 0x0034EA7C File Offset: 0x0034CC7C
			// (set) Token: 0x0600BCCA RID: 48330 RVA: 0x0034EA8C File Offset: 0x0034CC8C
			public Text m_actor0NameText
			{
				get
				{
					return this.m_owner.m_actor0NameText;
				}
				set
				{
					this.m_owner.m_actor0NameText = value;
				}
			}

			// Token: 0x170025C7 RID: 9671
			// (get) Token: 0x0600BCCB RID: 48331 RVA: 0x0034EA9C File Offset: 0x0034CC9C
			// (set) Token: 0x0600BCCC RID: 48332 RVA: 0x0034EAAC File Offset: 0x0034CCAC
			public Text m_actor0LvValueText
			{
				get
				{
					return this.m_owner.m_actor0LvValueText;
				}
				set
				{
					this.m_owner.m_actor0LvValueText = value;
				}
			}

			// Token: 0x170025C8 RID: 9672
			// (get) Token: 0x0600BCCD RID: 48333 RVA: 0x0034EABC File Offset: 0x0034CCBC
			// (set) Token: 0x0600BCCE RID: 48334 RVA: 0x0034EACC File Offset: 0x0034CCCC
			public CommonUIStateController m_actor0SituationGroup
			{
				get
				{
					return this.m_owner.m_actor0SituationGroup;
				}
				set
				{
					this.m_owner.m_actor0SituationGroup = value;
				}
			}

			// Token: 0x170025C9 RID: 9673
			// (get) Token: 0x0600BCCF RID: 48335 RVA: 0x0034EADC File Offset: 0x0034CCDC
			// (set) Token: 0x0600BCD0 RID: 48336 RVA: 0x0034EAEC File Offset: 0x0034CCEC
			public GameObject m_actor0SoldierGroupGameObject
			{
				get
				{
					return this.m_owner.m_actor0SoldierGroupGameObject;
				}
				set
				{
					this.m_owner.m_actor0SoldierGroupGameObject = value;
				}
			}

			// Token: 0x170025CA RID: 9674
			// (get) Token: 0x0600BCD1 RID: 48337 RVA: 0x0034EAFC File Offset: 0x0034CCFC
			// (set) Token: 0x0600BCD2 RID: 48338 RVA: 0x0034EB0C File Offset: 0x0034CD0C
			public Image m_actor0SoldierTypeIcon
			{
				get
				{
					return this.m_owner.m_actor0SoldierTypeIcon;
				}
				set
				{
					this.m_owner.m_actor0SoldierTypeIcon = value;
				}
			}

			// Token: 0x170025CB RID: 9675
			// (get) Token: 0x0600BCD3 RID: 48339 RVA: 0x0034EB1C File Offset: 0x0034CD1C
			// (set) Token: 0x0600BCD4 RID: 48340 RVA: 0x0034EB2C File Offset: 0x0034CD2C
			public Text m_actor0SoldierNameText
			{
				get
				{
					return this.m_owner.m_actor0SoldierNameText;
				}
				set
				{
					this.m_owner.m_actor0SoldierNameText = value;
				}
			}

			// Token: 0x170025CC RID: 9676
			// (get) Token: 0x0600BCD5 RID: 48341 RVA: 0x0034EB3C File Offset: 0x0034CD3C
			// (set) Token: 0x0600BCD6 RID: 48342 RVA: 0x0034EB4C File Offset: 0x0034CD4C
			public Image m_actor0SoldierHpProgressBar
			{
				get
				{
					return this.m_owner.m_actor0SoldierHpProgressBar;
				}
				set
				{
					this.m_owner.m_actor0SoldierHpProgressBar = value;
				}
			}

			// Token: 0x170025CD RID: 9677
			// (get) Token: 0x0600BCD7 RID: 48343 RVA: 0x0034EB5C File Offset: 0x0034CD5C
			// (set) Token: 0x0600BCD8 RID: 48344 RVA: 0x0034EB6C File Offset: 0x0034CD6C
			public Text m_actor0SoldierHpText
			{
				get
				{
					return this.m_owner.m_actor0SoldierHpText;
				}
				set
				{
					this.m_owner.m_actor0SoldierHpText = value;
				}
			}

			// Token: 0x170025CE RID: 9678
			// (get) Token: 0x0600BCD9 RID: 48345 RVA: 0x0034EB7C File Offset: 0x0034CD7C
			// (set) Token: 0x0600BCDA RID: 48346 RVA: 0x0034EB8C File Offset: 0x0034CD8C
			public GameObject m_actor0SoldierHpFxGameObeject
			{
				get
				{
					return this.m_owner.m_actor0SoldierHpFxGameObeject;
				}
				set
				{
					this.m_owner.m_actor0SoldierHpFxGameObeject = value;
				}
			}

			// Token: 0x170025CF RID: 9679
			// (get) Token: 0x0600BCDB RID: 48347 RVA: 0x0034EB9C File Offset: 0x0034CD9C
			// (set) Token: 0x0600BCDC RID: 48348 RVA: 0x0034EBAC File Offset: 0x0034CDAC
			public CommonUIStateController m_actor0DamageUIStateController
			{
				get
				{
					return this.m_owner.m_actor0DamageUIStateController;
				}
				set
				{
					this.m_owner.m_actor0DamageUIStateController = value;
				}
			}

			// Token: 0x170025D0 RID: 9680
			// (get) Token: 0x0600BCDD RID: 48349 RVA: 0x0034EBBC File Offset: 0x0034CDBC
			// (set) Token: 0x0600BCDE RID: 48350 RVA: 0x0034EBCC File Offset: 0x0034CDCC
			public Text m_actor0DamageText
			{
				get
				{
					return this.m_owner.m_actor0DamageText;
				}
				set
				{
					this.m_owner.m_actor0DamageText = value;
				}
			}

			// Token: 0x170025D1 RID: 9681
			// (get) Token: 0x0600BCDF RID: 48351 RVA: 0x0034EBDC File Offset: 0x0034CDDC
			// (set) Token: 0x0600BCE0 RID: 48352 RVA: 0x0034EBEC File Offset: 0x0034CDEC
			public Text m_actor0DamageCriticalText
			{
				get
				{
					return this.m_owner.m_actor0DamageCriticalText;
				}
				set
				{
					this.m_owner.m_actor0DamageCriticalText = value;
				}
			}

			// Token: 0x170025D2 RID: 9682
			// (get) Token: 0x0600BCE1 RID: 48353 RVA: 0x0034EBFC File Offset: 0x0034CDFC
			// (set) Token: 0x0600BCE2 RID: 48354 RVA: 0x0034EC0C File Offset: 0x0034CE0C
			public CommonUIStateController m_actor0PassiveSkillUIStateController
			{
				get
				{
					return this.m_owner.m_actor0PassiveSkillUIStateController;
				}
				set
				{
					this.m_owner.m_actor0PassiveSkillUIStateController = value;
				}
			}

			// Token: 0x170025D3 RID: 9683
			// (get) Token: 0x0600BCE3 RID: 48355 RVA: 0x0034EC1C File Offset: 0x0034CE1C
			// (set) Token: 0x0600BCE4 RID: 48356 RVA: 0x0034EC2C File Offset: 0x0034CE2C
			public Image m_actor0PassiveSkillIconImage
			{
				get
				{
					return this.m_owner.m_actor0PassiveSkillIconImage;
				}
				set
				{
					this.m_owner.m_actor0PassiveSkillIconImage = value;
				}
			}

			// Token: 0x170025D4 RID: 9684
			// (get) Token: 0x0600BCE5 RID: 48357 RVA: 0x0034EC3C File Offset: 0x0034CE3C
			// (set) Token: 0x0600BCE6 RID: 48358 RVA: 0x0034EC4C File Offset: 0x0034CE4C
			public Image m_actor0PassiveSkillTalentIconImage
			{
				get
				{
					return this.m_owner.m_actor0PassiveSkillTalentIconImage;
				}
				set
				{
					this.m_owner.m_actor0PassiveSkillTalentIconImage = value;
				}
			}

			// Token: 0x170025D5 RID: 9685
			// (get) Token: 0x0600BCE7 RID: 48359 RVA: 0x0034EC5C File Offset: 0x0034CE5C
			// (set) Token: 0x0600BCE8 RID: 48360 RVA: 0x0034EC6C File Offset: 0x0034CE6C
			public Text m_actor0PassiveSkillNameText
			{
				get
				{
					return this.m_owner.m_actor0PassiveSkillNameText;
				}
				set
				{
					this.m_owner.m_actor0PassiveSkillNameText = value;
				}
			}

			// Token: 0x170025D6 RID: 9686
			// (get) Token: 0x0600BCE9 RID: 48361 RVA: 0x0034EC7C File Offset: 0x0034CE7C
			// (set) Token: 0x0600BCEA RID: 48362 RVA: 0x0034EC8C File Offset: 0x0034CE8C
			public Text m_actor1TerrainText
			{
				get
				{
					return this.m_owner.m_actor1TerrainText;
				}
				set
				{
					this.m_owner.m_actor1TerrainText = value;
				}
			}

			// Token: 0x170025D7 RID: 9687
			// (get) Token: 0x0600BCEB RID: 48363 RVA: 0x0034EC9C File Offset: 0x0034CE9C
			// (set) Token: 0x0600BCEC RID: 48364 RVA: 0x0034ECAC File Offset: 0x0034CEAC
			public Text m_actor1TerrainDefText
			{
				get
				{
					return this.m_owner.m_actor1TerrainDefText;
				}
				set
				{
					this.m_owner.m_actor1TerrainDefText = value;
				}
			}

			// Token: 0x170025D8 RID: 9688
			// (get) Token: 0x0600BCED RID: 48365 RVA: 0x0034ECBC File Offset: 0x0034CEBC
			// (set) Token: 0x0600BCEE RID: 48366 RVA: 0x0034ECCC File Offset: 0x0034CECC
			public Image m_actor1TerrainImage
			{
				get
				{
					return this.m_owner.m_actor1TerrainImage;
				}
				set
				{
					this.m_owner.m_actor1TerrainImage = value;
				}
			}

			// Token: 0x170025D9 RID: 9689
			// (get) Token: 0x0600BCEF RID: 48367 RVA: 0x0034ECDC File Offset: 0x0034CEDC
			// (set) Token: 0x0600BCF0 RID: 48368 RVA: 0x0034ECEC File Offset: 0x0034CEEC
			public CommonUIStateController m_actor1UIStateController
			{
				get
				{
					return this.m_owner.m_actor1UIStateController;
				}
				set
				{
					this.m_owner.m_actor1UIStateController = value;
				}
			}

			// Token: 0x170025DA RID: 9690
			// (get) Token: 0x0600BCF1 RID: 48369 RVA: 0x0034ECFC File Offset: 0x0034CEFC
			// (set) Token: 0x0600BCF2 RID: 48370 RVA: 0x0034ED0C File Offset: 0x0034CF0C
			public CommonUIStateController m_actor1CharUIStateController
			{
				get
				{
					return this.m_owner.m_actor1CharUIStateController;
				}
				set
				{
					this.m_owner.m_actor1CharUIStateController = value;
				}
			}

			// Token: 0x170025DB RID: 9691
			// (get) Token: 0x0600BCF3 RID: 48371 RVA: 0x0034ED1C File Offset: 0x0034CF1C
			// (set) Token: 0x0600BCF4 RID: 48372 RVA: 0x0034ED2C File Offset: 0x0034CF2C
			public Image m_actor1CharIcon
			{
				get
				{
					return this.m_owner.m_actor1CharIcon;
				}
				set
				{
					this.m_owner.m_actor1CharIcon = value;
				}
			}

			// Token: 0x170025DC RID: 9692
			// (get) Token: 0x0600BCF5 RID: 48373 RVA: 0x0034ED3C File Offset: 0x0034CF3C
			// (set) Token: 0x0600BCF6 RID: 48374 RVA: 0x0034ED4C File Offset: 0x0034CF4C
			public GameObject m_actor1SkillGo
			{
				get
				{
					return this.m_owner.m_actor1SkillGo;
				}
				set
				{
					this.m_owner.m_actor1SkillGo = value;
				}
			}

			// Token: 0x170025DD RID: 9693
			// (get) Token: 0x0600BCF7 RID: 48375 RVA: 0x0034ED5C File Offset: 0x0034CF5C
			// (set) Token: 0x0600BCF8 RID: 48376 RVA: 0x0034ED6C File Offset: 0x0034CF6C
			public Image m_actor1SkillIconImage
			{
				get
				{
					return this.m_owner.m_actor1SkillIconImage;
				}
				set
				{
					this.m_owner.m_actor1SkillIconImage = value;
				}
			}

			// Token: 0x170025DE RID: 9694
			// (get) Token: 0x0600BCF9 RID: 48377 RVA: 0x0034ED7C File Offset: 0x0034CF7C
			// (set) Token: 0x0600BCFA RID: 48378 RVA: 0x0034ED8C File Offset: 0x0034CF8C
			public Image m_actor1TypeIcon
			{
				get
				{
					return this.m_owner.m_actor1TypeIcon;
				}
				set
				{
					this.m_owner.m_actor1TypeIcon = value;
				}
			}

			// Token: 0x170025DF RID: 9695
			// (get) Token: 0x0600BCFB RID: 48379 RVA: 0x0034ED9C File Offset: 0x0034CF9C
			// (set) Token: 0x0600BCFC RID: 48380 RVA: 0x0034EDAC File Offset: 0x0034CFAC
			public Text m_actor1HpText
			{
				get
				{
					return this.m_owner.m_actor1HpText;
				}
				set
				{
					this.m_owner.m_actor1HpText = value;
				}
			}

			// Token: 0x170025E0 RID: 9696
			// (get) Token: 0x0600BCFD RID: 48381 RVA: 0x0034EDBC File Offset: 0x0034CFBC
			// (set) Token: 0x0600BCFE RID: 48382 RVA: 0x0034EDCC File Offset: 0x0034CFCC
			public Image m_actor1HpProgressBar
			{
				get
				{
					return this.m_owner.m_actor1HpProgressBar;
				}
				set
				{
					this.m_owner.m_actor1HpProgressBar = value;
				}
			}

			// Token: 0x170025E1 RID: 9697
			// (get) Token: 0x0600BCFF RID: 48383 RVA: 0x0034EDDC File Offset: 0x0034CFDC
			// (set) Token: 0x0600BD00 RID: 48384 RVA: 0x0034EDEC File Offset: 0x0034CFEC
			public GameObject m_actor1HeroHpFxGameObeject
			{
				get
				{
					return this.m_owner.m_actor1HeroHpFxGameObeject;
				}
				set
				{
					this.m_owner.m_actor1HeroHpFxGameObeject = value;
				}
			}

			// Token: 0x170025E2 RID: 9698
			// (get) Token: 0x0600BD01 RID: 48385 RVA: 0x0034EDFC File Offset: 0x0034CFFC
			// (set) Token: 0x0600BD02 RID: 48386 RVA: 0x0034EE0C File Offset: 0x0034D00C
			public CommonUIStateController m_actor1Proprety1NameText
			{
				get
				{
					return this.m_owner.m_actor1Proprety1NameText;
				}
				set
				{
					this.m_owner.m_actor1Proprety1NameText = value;
				}
			}

			// Token: 0x170025E3 RID: 9699
			// (get) Token: 0x0600BD03 RID: 48387 RVA: 0x0034EE1C File Offset: 0x0034D01C
			// (set) Token: 0x0600BD04 RID: 48388 RVA: 0x0034EE2C File Offset: 0x0034D02C
			public Text m_actor1Proprety1ValueText
			{
				get
				{
					return this.m_owner.m_actor1Proprety1ValueText;
				}
				set
				{
					this.m_owner.m_actor1Proprety1ValueText = value;
				}
			}

			// Token: 0x170025E4 RID: 9700
			// (get) Token: 0x0600BD05 RID: 48389 RVA: 0x0034EE3C File Offset: 0x0034D03C
			// (set) Token: 0x0600BD06 RID: 48390 RVA: 0x0034EE4C File Offset: 0x0034D04C
			public CommonUIStateController m_actor1Proprety2NameText
			{
				get
				{
					return this.m_owner.m_actor1Proprety2NameText;
				}
				set
				{
					this.m_owner.m_actor1Proprety2NameText = value;
				}
			}

			// Token: 0x170025E5 RID: 9701
			// (get) Token: 0x0600BD07 RID: 48391 RVA: 0x0034EE5C File Offset: 0x0034D05C
			// (set) Token: 0x0600BD08 RID: 48392 RVA: 0x0034EE6C File Offset: 0x0034D06C
			public Text m_actor1Proprety2ValueText
			{
				get
				{
					return this.m_owner.m_actor1Proprety2ValueText;
				}
				set
				{
					this.m_owner.m_actor1Proprety2ValueText = value;
				}
			}

			// Token: 0x170025E6 RID: 9702
			// (get) Token: 0x0600BD09 RID: 48393 RVA: 0x0034EE7C File Offset: 0x0034D07C
			// (set) Token: 0x0600BD0A RID: 48394 RVA: 0x0034EE8C File Offset: 0x0034D08C
			public Text m_actor1NameText
			{
				get
				{
					return this.m_owner.m_actor1NameText;
				}
				set
				{
					this.m_owner.m_actor1NameText = value;
				}
			}

			// Token: 0x170025E7 RID: 9703
			// (get) Token: 0x0600BD0B RID: 48395 RVA: 0x0034EE9C File Offset: 0x0034D09C
			// (set) Token: 0x0600BD0C RID: 48396 RVA: 0x0034EEAC File Offset: 0x0034D0AC
			public Text m_actor1LvValueText
			{
				get
				{
					return this.m_owner.m_actor1LvValueText;
				}
				set
				{
					this.m_owner.m_actor1LvValueText = value;
				}
			}

			// Token: 0x170025E8 RID: 9704
			// (get) Token: 0x0600BD0D RID: 48397 RVA: 0x0034EEBC File Offset: 0x0034D0BC
			// (set) Token: 0x0600BD0E RID: 48398 RVA: 0x0034EECC File Offset: 0x0034D0CC
			public CommonUIStateController m_actor1SituationGroup
			{
				get
				{
					return this.m_owner.m_actor1SituationGroup;
				}
				set
				{
					this.m_owner.m_actor1SituationGroup = value;
				}
			}

			// Token: 0x170025E9 RID: 9705
			// (get) Token: 0x0600BD0F RID: 48399 RVA: 0x0034EEDC File Offset: 0x0034D0DC
			// (set) Token: 0x0600BD10 RID: 48400 RVA: 0x0034EEEC File Offset: 0x0034D0EC
			public GameObject m_actor1SoldierGroupGameObject
			{
				get
				{
					return this.m_owner.m_actor1SoldierGroupGameObject;
				}
				set
				{
					this.m_owner.m_actor1SoldierGroupGameObject = value;
				}
			}

			// Token: 0x170025EA RID: 9706
			// (get) Token: 0x0600BD11 RID: 48401 RVA: 0x0034EEFC File Offset: 0x0034D0FC
			// (set) Token: 0x0600BD12 RID: 48402 RVA: 0x0034EF0C File Offset: 0x0034D10C
			public Image m_actor1SoldierTypeIcon
			{
				get
				{
					return this.m_owner.m_actor1SoldierTypeIcon;
				}
				set
				{
					this.m_owner.m_actor1SoldierTypeIcon = value;
				}
			}

			// Token: 0x170025EB RID: 9707
			// (get) Token: 0x0600BD13 RID: 48403 RVA: 0x0034EF1C File Offset: 0x0034D11C
			// (set) Token: 0x0600BD14 RID: 48404 RVA: 0x0034EF2C File Offset: 0x0034D12C
			public Text m_actor1SoldierNameText
			{
				get
				{
					return this.m_owner.m_actor1SoldierNameText;
				}
				set
				{
					this.m_owner.m_actor1SoldierNameText = value;
				}
			}

			// Token: 0x170025EC RID: 9708
			// (get) Token: 0x0600BD15 RID: 48405 RVA: 0x0034EF3C File Offset: 0x0034D13C
			// (set) Token: 0x0600BD16 RID: 48406 RVA: 0x0034EF4C File Offset: 0x0034D14C
			public Image m_actor1SoldierHpProgressBar
			{
				get
				{
					return this.m_owner.m_actor1SoldierHpProgressBar;
				}
				set
				{
					this.m_owner.m_actor1SoldierHpProgressBar = value;
				}
			}

			// Token: 0x170025ED RID: 9709
			// (get) Token: 0x0600BD17 RID: 48407 RVA: 0x0034EF5C File Offset: 0x0034D15C
			// (set) Token: 0x0600BD18 RID: 48408 RVA: 0x0034EF6C File Offset: 0x0034D16C
			public Text m_actor1SoldierHpText
			{
				get
				{
					return this.m_owner.m_actor1SoldierHpText;
				}
				set
				{
					this.m_owner.m_actor1SoldierHpText = value;
				}
			}

			// Token: 0x170025EE RID: 9710
			// (get) Token: 0x0600BD19 RID: 48409 RVA: 0x0034EF7C File Offset: 0x0034D17C
			// (set) Token: 0x0600BD1A RID: 48410 RVA: 0x0034EF8C File Offset: 0x0034D18C
			public GameObject m_actor1SoldierHpFxGameObeject
			{
				get
				{
					return this.m_owner.m_actor1SoldierHpFxGameObeject;
				}
				set
				{
					this.m_owner.m_actor1SoldierHpFxGameObeject = value;
				}
			}

			// Token: 0x170025EF RID: 9711
			// (get) Token: 0x0600BD1B RID: 48411 RVA: 0x0034EF9C File Offset: 0x0034D19C
			// (set) Token: 0x0600BD1C RID: 48412 RVA: 0x0034EFAC File Offset: 0x0034D1AC
			public CommonUIStateController m_actor1DamageUIStateController
			{
				get
				{
					return this.m_owner.m_actor1DamageUIStateController;
				}
				set
				{
					this.m_owner.m_actor1DamageUIStateController = value;
				}
			}

			// Token: 0x170025F0 RID: 9712
			// (get) Token: 0x0600BD1D RID: 48413 RVA: 0x0034EFBC File Offset: 0x0034D1BC
			// (set) Token: 0x0600BD1E RID: 48414 RVA: 0x0034EFCC File Offset: 0x0034D1CC
			public Text m_actor1DamageText
			{
				get
				{
					return this.m_owner.m_actor1DamageText;
				}
				set
				{
					this.m_owner.m_actor1DamageText = value;
				}
			}

			// Token: 0x170025F1 RID: 9713
			// (get) Token: 0x0600BD1F RID: 48415 RVA: 0x0034EFDC File Offset: 0x0034D1DC
			// (set) Token: 0x0600BD20 RID: 48416 RVA: 0x0034EFEC File Offset: 0x0034D1EC
			public Text m_actor1DamageCriticalText
			{
				get
				{
					return this.m_owner.m_actor1DamageCriticalText;
				}
				set
				{
					this.m_owner.m_actor1DamageCriticalText = value;
				}
			}

			// Token: 0x170025F2 RID: 9714
			// (get) Token: 0x0600BD21 RID: 48417 RVA: 0x0034EFFC File Offset: 0x0034D1FC
			// (set) Token: 0x0600BD22 RID: 48418 RVA: 0x0034F00C File Offset: 0x0034D20C
			public CommonUIStateController m_actor1PassiveSkillUIStateController
			{
				get
				{
					return this.m_owner.m_actor1PassiveSkillUIStateController;
				}
				set
				{
					this.m_owner.m_actor1PassiveSkillUIStateController = value;
				}
			}

			// Token: 0x170025F3 RID: 9715
			// (get) Token: 0x0600BD23 RID: 48419 RVA: 0x0034F01C File Offset: 0x0034D21C
			// (set) Token: 0x0600BD24 RID: 48420 RVA: 0x0034F02C File Offset: 0x0034D22C
			public Image m_actor1PassiveSkillIconImage
			{
				get
				{
					return this.m_owner.m_actor1PassiveSkillIconImage;
				}
				set
				{
					this.m_owner.m_actor1PassiveSkillIconImage = value;
				}
			}

			// Token: 0x170025F4 RID: 9716
			// (get) Token: 0x0600BD25 RID: 48421 RVA: 0x0034F03C File Offset: 0x0034D23C
			// (set) Token: 0x0600BD26 RID: 48422 RVA: 0x0034F04C File Offset: 0x0034D24C
			public Image m_actor1PassiveSkillTalentIconImage
			{
				get
				{
					return this.m_owner.m_actor1PassiveSkillTalentIconImage;
				}
				set
				{
					this.m_owner.m_actor1PassiveSkillTalentIconImage = value;
				}
			}

			// Token: 0x170025F5 RID: 9717
			// (get) Token: 0x0600BD27 RID: 48423 RVA: 0x0034F05C File Offset: 0x0034D25C
			// (set) Token: 0x0600BD28 RID: 48424 RVA: 0x0034F06C File Offset: 0x0034D26C
			public Text m_actor1PassiveSkillNameText
			{
				get
				{
					return this.m_owner.m_actor1PassiveSkillNameText;
				}
				set
				{
					this.m_owner.m_actor1PassiveSkillNameText = value;
				}
			}

			// Token: 0x170025F6 RID: 9718
			// (get) Token: 0x0600BD29 RID: 48425 RVA: 0x0034F07C File Offset: 0x0034D27C
			// (set) Token: 0x0600BD2A RID: 48426 RVA: 0x0034F08C File Offset: 0x0034D28C
			public Button m_okButton
			{
				get
				{
					return this.m_owner.m_okButton;
				}
				set
				{
					this.m_owner.m_okButton = value;
				}
			}

			// Token: 0x170025F7 RID: 9719
			// (get) Token: 0x0600BD2B RID: 48427 RVA: 0x0034F09C File Offset: 0x0034D29C
			// (set) Token: 0x0600BD2C RID: 48428 RVA: 0x0034F0AC File Offset: 0x0034D2AC
			public Button m_cancelButton
			{
				get
				{
					return this.m_owner.m_cancelButton;
				}
				set
				{
					this.m_owner.m_cancelButton = value;
				}
			}

			// Token: 0x170025F8 RID: 9720
			// (get) Token: 0x0600BD2D RID: 48429 RVA: 0x0034F0BC File Offset: 0x0034D2BC
			// (set) Token: 0x0600BD2E RID: 48430 RVA: 0x0034F0CC File Offset: 0x0034D2CC
			public int m_armyRelationValue
			{
				get
				{
					return this.m_owner.m_armyRelationValue;
				}
				set
				{
					this.m_owner.m_armyRelationValue = value;
				}
			}

			// Token: 0x170025F9 RID: 9721
			// (get) Token: 0x0600BD2F RID: 48431 RVA: 0x0034F0DC File Offset: 0x0034D2DC
			// (set) Token: 0x0600BD30 RID: 48432 RVA: 0x0034F0EC File Offset: 0x0034D2EC
			public int m_totalDamage0
			{
				get
				{
					return this.m_owner.m_totalDamage0;
				}
				set
				{
					this.m_owner.m_totalDamage0 = value;
				}
			}

			// Token: 0x170025FA RID: 9722
			// (get) Token: 0x0600BD31 RID: 48433 RVA: 0x0034F0FC File Offset: 0x0034D2FC
			// (set) Token: 0x0600BD32 RID: 48434 RVA: 0x0034F10C File Offset: 0x0034D30C
			public int m_totalDamage1
			{
				get
				{
					return this.m_owner.m_totalDamage1;
				}
				set
				{
					this.m_owner.m_totalDamage1 = value;
				}
			}

			// Token: 0x170025FB RID: 9723
			// (get) Token: 0x0600BD33 RID: 48435 RVA: 0x0034F11C File Offset: 0x0034D31C
			// (set) Token: 0x0600BD34 RID: 48436 RVA: 0x0034F12C File Offset: 0x0034D32C
			public FxPlayer m_fxPlayer
			{
				get
				{
					return this.m_owner.m_fxPlayer;
				}
				set
				{
					this.m_owner.m_fxPlayer = value;
				}
			}

			// Token: 0x170025FC RID: 9724
			// (get) Token: 0x0600BD35 RID: 48437 RVA: 0x0034F13C File Offset: 0x0034D33C
			// (set) Token: 0x0600BD36 RID: 48438 RVA: 0x0034F14C File Offset: 0x0034D34C
			public bool m_isOpened
			{
				get
				{
					return this.m_owner.m_isOpened;
				}
				set
				{
					this.m_owner.m_isOpened = value;
				}
			}

			// Token: 0x170025FD RID: 9725
			// (get) Token: 0x0600BD37 RID: 48439 RVA: 0x0034F15C File Offset: 0x0034D35C
			// (set) Token: 0x0600BD38 RID: 48440 RVA: 0x0034F16C File Offset: 0x0034D36C
			public bool m_isFastCombat
			{
				get
				{
					return this.m_owner.m_isFastCombat;
				}
				set
				{
					this.m_owner.m_isFastCombat = value;
				}
			}

			// Token: 0x170025FE RID: 9726
			// (get) Token: 0x0600BD39 RID: 48441 RVA: 0x0034F17C File Offset: 0x0034D37C
			// (set) Token: 0x0600BD3A RID: 48442 RVA: 0x0034F18C File Offset: 0x0034D38C
			public HeroPropertyComputer m_propertyComputer
			{
				get
				{
					return this.m_owner.m_propertyComputer;
				}
				set
				{
					this.m_owner.m_propertyComputer = value;
				}
			}

			// Token: 0x0600BD3B RID: 48443 RVA: 0x0034F19C File Offset: 0x0034D39C
			public void OnDisable()
			{
				this.m_owner.OnDisable();
			}

			// Token: 0x0600BD3C RID: 48444 RVA: 0x0034F1AC File Offset: 0x0034D3AC
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0600BD3D RID: 48445 RVA: 0x0034F1BC File Offset: 0x0034D3BC
			public void Show()
			{
				this.m_owner.Show();
			}

			// Token: 0x0600BD3E RID: 48446 RVA: 0x0034F1CC File Offset: 0x0034D3CC
			public void ShowOkCancelButton(bool show)
			{
				this.m_owner.ShowOkCancelButton(show);
			}

			// Token: 0x0600BD3F RID: 48447 RVA: 0x0034F1DC File Offset: 0x0034D3DC
			public void SetHeroHp(int side, int hp, int hpMax)
			{
				this.m_owner.SetHeroHp(side, hp, hpMax);
			}

			// Token: 0x0600BD40 RID: 48448 RVA: 0x0034F1EC File Offset: 0x0034D3EC
			public void SetSoldierHp(int side, int hp, int hpMax)
			{
				this.m_owner.SetSoldierHp(side, hp, hpMax);
			}

			// Token: 0x0600BD41 RID: 48449 RVA: 0x0034F1FC File Offset: 0x0034D3FC
			public IEnumerator Co_OpenAndFastCombat(FastCombatActorInfo a0, FastCombatActorInfo a1)
			{
				return this.m_owner.Co_OpenAndFastCombat(a0, a1);
			}

			// Token: 0x0600BD42 RID: 48450 RVA: 0x0034F20C File Offset: 0x0034D40C
			public IEnumerator Co_FastCombat(FastCombatActorInfo a0, FastCombatActorInfo a1)
			{
				return this.m_owner.Co_FastCombat(a0, a1);
			}

			// Token: 0x0600BD43 RID: 48451 RVA: 0x0034F21C File Offset: 0x0034D41C
			public IEnumerator Co_PlayDamage(int side, FastCombatActorInfo a)
			{
				return this.m_owner.Co_PlayDamage(side, a);
			}

			// Token: 0x0600BD44 RID: 48452 RVA: 0x0034F22C File Offset: 0x0034D42C
			public IEnumerator Co_PlayDamage(GameObject fxParent, int side, int beforeHp, int afterHp, int hpMax, bool isHero, int totalDamage, bool isCritical)
			{
				return this.m_owner.Co_PlayDamage(fxParent, side, beforeHp, afterHp, hpMax, isHero, totalDamage, isCritical);
			}

			// Token: 0x0600BD45 RID: 48453 RVA: 0x0034F254 File Offset: 0x0034D454
			public void PlayDamageFx(GameObject fxParent, int side, int hp, int hpMax, int damage, bool isLargeFx)
			{
				this.m_owner.PlayDamageFx(fxParent, side, hp, hpMax, damage, isLargeFx);
			}

			// Token: 0x0600BD46 RID: 48454 RVA: 0x0034F26C File Offset: 0x0034D46C
			public void OnOkButtonClick()
			{
				this.m_owner.OnOkButtonClick();
			}

			// Token: 0x0600BD47 RID: 48455 RVA: 0x0034F27C File Offset: 0x0034D47C
			public void OnCancelButtonClick()
			{
				this.m_owner.OnCancelButtonClick();
			}

			// Token: 0x0600BD48 RID: 48456 RVA: 0x0034F28C File Offset: 0x0034D48C
			public void OnBackgroundButtonClick()
			{
				this.m_owner.OnBackgroundButtonClick();
			}

			// Token: 0x04007948 RID: 31048
			private PreCombatUIController m_owner;
		}
	}
}
