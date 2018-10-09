using System;
using System.Collections.Generic;
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
	// Token: 0x02000AF8 RID: 2808
	[HotFix]
	public class CombatUIController : UIControllerBase
	{
		// Token: 0x0600BB8F RID: 48015 RVA: 0x00349C70 File Offset: 0x00347E70
		private CombatUIController()
		{
		}

		// Token: 0x0600BB90 RID: 48016 RVA: 0x00349C84 File Offset: 0x00347E84
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
			this.m_autoOffButton.onClick.AddListener(new UnityAction(this.OnAutoOffButtonClick));
			this.m_arenaAutoButton.onClick.AddListener(new UnityAction(this.OnArenaAutoButtonClick));
			for (int i = 0; i < this.m_hpStates.Length; i++)
			{
				this.m_hpStates[i] = new CombatUIController.HPState();
				this.m_hpStates[i].m_combatCharUIController = GameObjectUtility.AddControllerToGameObject<CombatCharUIController>((i != 0) ? this.m_char1GameObject : this.m_char0GameObject);
			}
			UIUtility.SetTweenIgnoreTimeScale(this.m_cutsceneSkillUIStateController.gameObject, false);
			UIUtility.SetTweenIgnoreTimeScale(this.m_damage0UIStateController.gameObject, false);
			UIUtility.SetTweenIgnoreTimeScale(this.m_damage1UIStateController.gameObject, false);
			UIUtility.MarginAdjustHorizontal(this.m_marginTransform);
		}

		// Token: 0x0600BB91 RID: 48017 RVA: 0x00349DB0 File Offset: 0x00347FB0
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

		// Token: 0x0600BB92 RID: 48018 RVA: 0x00349E28 File Offset: 0x00348028
		public void StartCombat(bool splitScreen, bool isBoss, int myPlayerTeam)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartCombatBooleanBooleanInt32_hotfix != null)
			{
				this.m_StartCombatBooleanBooleanInt32_hotfix.call(new object[]
				{
					this,
					splitScreen,
					isBoss,
					myPlayerTeam
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_damage0UIStateController.gameObject.SetActive(false);
			this.m_damage1UIStateController.gameObject.SetActive(false);
			this.m_boundaryGameObject.SetActive(splitScreen);
			this.HideCutsceneSkill();
			this.ResetHPStates();
			CommonUIController.Instance.ShowBlackFrame(true);
			this.m_isBoss = isBoss;
			this.m_myPlayerTeam = myPlayerTeam;
			if (isBoss)
			{
				this.m_uiStateController.SetToUIState("Boss", false, true);
			}
			else
			{
				this.m_uiStateController.SetToUIState("Normal", false, true);
			}
		}

		// Token: 0x0600BB93 RID: 48019 RVA: 0x00349F3C File Offset: 0x0034813C
		public void ForceUpdateChar()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ForceUpdateChar_hotfix != null)
			{
				this.m_ForceUpdateChar_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (CombatUIController.HPState hpstate in this.m_hpStates)
			{
				hpstate.m_combatCharUIController.ForceUpdate();
			}
		}

		// Token: 0x0600BB94 RID: 48020 RVA: 0x00349FC8 File Offset: 0x003481C8
		public void PreStopCombat()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PreStopCombat_hotfix != null)
			{
				this.m_PreStopCombat_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_damage0UIStateController.gameObject.SetActive(false);
			this.m_damage1UIStateController.gameObject.SetActive(false);
			this.HideCutsceneSkill();
			UIUtility.PlayAnimation(base.gameObject, "CombatUIStop");
		}

		// Token: 0x0600BB95 RID: 48021 RVA: 0x0034A060 File Offset: 0x00348260
		public void StopCombat()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StopCombat_hotfix != null)
			{
				this.m_StopCombat_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.ResetHPStates();
			CommonUIController.Instance.ShowBlackFrame(false);
		}

		// Token: 0x0600BB96 RID: 48022 RVA: 0x0034A0D4 File Offset: 0x003482D4
		private void ResetHPStates()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ResetHPStates_hotfix != null)
			{
				this.m_ResetHPStates_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (CombatUIController.HPState hpstate in this.m_hpStates)
			{
				hpstate.m_combatCharUIController.DestroyGraphic();
				hpstate.m_totalHpPercent = -1f;
				hpstate.m_heroDamages.Clear();
				hpstate.m_soldierDamages.Clear();
				hpstate.m_isCritical = false;
			}
		}

		// Token: 0x0600BB97 RID: 48023 RVA: 0x0034A188 File Offset: 0x00348388
		private int TeamToSide(int team)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TeamToSideInt32_hotfix != null)
			{
				return Convert.ToInt32(this.m_TeamToSideInt32_hotfix.call(new object[]
				{
					this,
					team
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (team == this.m_myPlayerTeam)
			{
				return 0;
			}
			return 1;
		}

		// Token: 0x0600BB98 RID: 48024 RVA: 0x0034A214 File Offset: 0x00348414
		public void SetHealthPoint(int team, int heroHp, int heroHpMax, int soldierHp, int soldierHpMax)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetHealthPointInt32Int32Int32Int32Int32_hotfix != null)
			{
				this.m_SetHealthPointInt32Int32Int32Int32Int32_hotfix.call(new object[]
				{
					this,
					team,
					heroHp,
					heroHpMax,
					soldierHp,
					soldierHpMax
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = this.TeamToSide(team);
			float fillAmount = 0f;
			if (heroHp > 0 && heroHpMax > 0)
			{
				fillAmount = (float)heroHp / (float)heroHpMax;
			}
			float fillAmount2 = 0f;
			if (soldierHp > 0 && soldierHpMax > 0)
			{
				fillAmount2 = (float)soldierHp / (float)soldierHpMax;
			}
			if (num == 0)
			{
				this.m_heroHp0Image.fillAmount = fillAmount;
				this.m_heroHp0Text.text = heroHp.ToString();
				this.m_soldierHp0Image.fillAmount = fillAmount2;
				this.m_soldierHp0Text.text = soldierHp.ToString();
			}
			else
			{
				if (this.m_isBoss)
				{
					this.m_bossHpImage.fillAmount = fillAmount;
					this.m_bossHpText.text = heroHp.ToString();
				}
				else
				{
					this.m_heroHp1Image.fillAmount = fillAmount;
					this.m_heroHp1Text.text = heroHp.ToString();
				}
				this.m_soldierHp1Image.fillAmount = fillAmount2;
				this.m_soldierHp1Text.text = soldierHp.ToString();
			}
			float totalHpPercent = (float)(heroHp + soldierHp) / (float)(heroHpMax + soldierHpMax);
			this.UpdateHPState(num, totalHpPercent);
			this.UpdateHPState(1 - num, this.m_hpStates[1 - num].m_totalHpPercent);
		}

		// Token: 0x0600BB99 RID: 48025 RVA: 0x0034A400 File Offset: 0x00348600
		private void UpdateHPState(int side, float totalHpPercent)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateHPStateInt32Single_hotfix != null)
			{
				this.m_UpdateHPStateInt32Single_hotfix.call(new object[]
				{
					this,
					side,
					totalHpPercent
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (totalHpPercent < 0f)
			{
				return;
			}
			CombatUIController.HPState hpstate = this.m_hpStates[side];
			CombatUIController.HPState hpstate2 = this.m_hpStates[1 - side];
			string text = "idle_Battle_Normal";
			bool flag = true;
			if (totalHpPercent <= 0.3f)
			{
				text = "idle_Battle_Weak";
			}
			if (hpstate2.m_totalHpPercent >= 0f && totalHpPercent >= hpstate2.m_totalHpPercent + 0.4f)
			{
				text = "idle_Battle_Mighty";
			}
			if (hpstate.m_totalHpPercent >= 0f && totalHpPercent <= hpstate.m_totalHpPercent - 0.4f)
			{
				text = "idle_Injury";
				flag = false;
			}
			if (flag && !hpstate.m_combatCharUIController.HasAnimation(text))
			{
				text = "idle_Battle_Normal";
			}
			if (text != hpstate.m_combatCharUIController.GetAnimationName())
			{
				hpstate.m_combatCharUIController.PlayAnimation(text, flag);
			}
			hpstate.m_totalHpPercent = totalHpPercent;
		}

		// Token: 0x0600BB9A RID: 48026 RVA: 0x0034A554 File Offset: 0x00348754
		public void ShowDamage(int team, bool isHero, int hp, int hpMax, int hpModify, int totalDamage, int combatFrame, DamageNumberType damageNumberType)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowDamageInt32BooleanInt32Int32Int32Int32Int32DamageNumberType_hotfix != null)
			{
				this.m_ShowDamageInt32BooleanInt32Int32Int32Int32Int32DamageNumberType_hotfix.call(new object[]
				{
					this,
					team,
					isHero,
					hp,
					hpMax,
					hpModify,
					totalDamage,
					combatFrame,
					damageNumberType
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (hpMax <= 0)
			{
				return;
			}
			if (hpModify >= 0)
			{
				return;
			}
			int num = this.TeamToSide(team);
			List<CombatUIController.Damage> list = null;
			if (isHero)
			{
				list = this.m_hpStates[num].m_heroDamages;
			}
			else
			{
				list = this.m_hpStates[num].m_soldierDamages;
			}
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			while (list.Count > 0 && combatFrame - list[0].m_combatFrame > Combat.MillisecondToFrame(configDataLoader.Const_HPBarFxAccumulateTime))
			{
				list.RemoveAt(0);
			}
			int num2 = -hpModify;
			if (num2 + hp > hpMax)
			{
				num2 = hpMax - hp;
			}
			float num3 = (float)num2 / (float)hpMax;
			list.Add(new CombatUIController.Damage
			{
				m_combatFrame = combatFrame,
				m_damagePercent = num3
			});
			float num4 = 0f;
			foreach (CombatUIController.Damage damage in list)
			{
				num4 += damage.m_damagePercent;
			}
			bool flag = (num == 0 && UIUtility.IsUITaskRunning(typeof(ChatUITask))) || UIUtility.IsUITaskRunning(typeof(BusinessCardUITask));
			GenericGraphic genericGraphic = null;
			if (num4 >= (float)configDataLoader.Const_HPBarFxAccumulateDamage * 0.01f)
			{
				if (!flag)
				{
					genericGraphic = this.m_fxPlayer.Play("FX/UI_ABS/UIFX_HPBarBreak_L_Pfb.prefab");
				}
				list.Clear();
			}
			else if (!flag)
			{
				genericGraphic = this.m_fxPlayer.Play("FX/UI_ABS/UIFX_HPBarBreak_S_Pfb.prefab");
			}
			if (genericGraphic != null)
			{
				genericGraphic.AutoDelete(true);
				float num5 = num3;
				if (num == 1 && isHero && this.m_isBoss)
				{
					num5 *= 2f;
				}
				genericGraphic.SetPrefabScale(new Vector3(num5, 1f, 1f));
			}
			GameObject gameObject = null;
			if (damageNumberType == DamageNumberType.Critical)
			{
				this.m_hpStates[num].m_isCritical = true;
			}
			if (num == 0)
			{
				this.m_damage0UIStateController.gameObject.SetActive(true);
				if (this.m_hpStates[num].m_isCritical)
				{
					this.m_damage0CriticalText.text = totalDamage.ToString();
					this.m_damage0UIStateController.SetToUIState("Critical", false, true);
				}
				else
				{
					this.m_damage0Text.text = totalDamage.ToString();
					this.m_damage0UIStateController.SetToUIState("Normal", false, true);
				}
				if (genericGraphic != null)
				{
					if (isHero)
					{
						gameObject = this.m_heroHp0FxGameObeject;
					}
					else
					{
						gameObject = this.m_soldierHp0FxGameObeject;
					}
					genericGraphic.SetDirection(1);
				}
			}
			else
			{
				this.m_damage1UIStateController.gameObject.SetActive(true);
				if (this.m_hpStates[num].m_isCritical)
				{
					this.m_damage1CriticalText.text = totalDamage.ToString();
					this.m_damage1UIStateController.SetToUIState("Critical", false, true);
				}
				else
				{
					this.m_damage1Text.text = totalDamage.ToString();
					this.m_damage1UIStateController.SetToUIState("Normal", false, true);
				}
				if (genericGraphic != null)
				{
					if (isHero)
					{
						if (this.m_isBoss)
						{
							gameObject = this.m_bossHpFxGameObeject;
						}
						else
						{
							gameObject = this.m_heroHp1FxGameObeject;
						}
					}
					else
					{
						gameObject = this.m_soldierHp1FxGameObeject;
					}
					genericGraphic.SetDirection(-1);
				}
			}
			if (genericGraphic != null && gameObject != null)
			{
				genericGraphic.SetParent(gameObject);
				RectTransform rectTransform = gameObject.transform as RectTransform;
				if (rectTransform != null)
				{
					Vector3 zero = Vector3.zero;
					zero.x = (float)hp * rectTransform.sizeDelta.x / (float)hpMax;
					if (num == 0)
					{
						zero.x = -zero.x;
					}
					genericGraphic.SetPosition(zero);
				}
			}
		}

		// Token: 0x0600BB9B RID: 48027 RVA: 0x0034AA2C File Offset: 0x00348C2C
		public void SetCharImageInfo(int team, ConfigDataCharImageInfo charImageInfo, ConfigDataCharImageSkinResourceInfo skinResInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetCharImageInfoInt32ConfigDataCharImageInfoConfigDataCharImageSkinResourceInfo_hotfix != null)
			{
				this.m_SetCharImageInfoInt32ConfigDataCharImageInfoConfigDataCharImageSkinResourceInfo_hotfix.call(new object[]
				{
					this,
					team,
					charImageInfo,
					skinResInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (charImageInfo == null)
			{
				return;
			}
			int num = this.TeamToSide(team);
			if (num == 0 || !this.m_isBoss)
			{
				this.m_hpStates[num].m_combatCharUIController.CreateGraphic(charImageInfo, skinResInfo);
				bool flag = (num == 0 && charImageInfo.Direction == 0) || (num == 1 && charImageInfo.Direction == 1);
				this.m_hpStates[num].m_combatCharUIController.SetDirection((!flag) ? -1 : 1);
			}
			else
			{
				this.m_hpStates[num].m_combatCharUIController.DestroyGraphic();
			}
		}

		// Token: 0x0600BB9C RID: 48028 RVA: 0x0034AB50 File Offset: 0x00348D50
		public void ShowCutsceneSkill(ConfigDataSkillInfo skillInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowCutsceneSkillConfigDataSkillInfo_hotfix != null)
			{
				this.m_ShowCutsceneSkillConfigDataSkillInfo_hotfix.call(new object[]
				{
					this,
					skillInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (skillInfo == null)
			{
				return;
			}
			this.m_cutsceneSkillIconImage.sprite = AssetUtility.Instance.GetSprite(skillInfo.Icon);
			this.m_cutsceneSkillNameText.text = skillInfo.Name;
			UIUtility.SetUIStateOpen(this.m_cutsceneSkillUIStateController, "Show", delegate
			{
				this.m_cutsceneSkillUIStateController.gameObject.SetActive(false);
			}, false, true);
		}

		// Token: 0x0600BB9D RID: 48029 RVA: 0x0034AC14 File Offset: 0x00348E14
		public void ShowCutscenePassiveSkill(BuffState sourceBuffState)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowCutscenePassiveSkillBuffState_hotfix != null)
			{
				this.m_ShowCutscenePassiveSkillBuffState_hotfix.call(new object[]
				{
					this,
					sourceBuffState
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (sourceBuffState == null)
			{
				return;
			}
			this.m_cutsceneSkillIconImage.sprite = AssetUtility.Instance.GetSprite(sourceBuffState.m_buffInfo.Icon);
			this.m_cutsceneSkillNameText.text = sourceBuffState.m_buffInfo.Name;
			UIUtility.SetUIStateOpen(this.m_cutsceneSkillUIStateController, "Show", delegate
			{
				this.m_cutsceneSkillUIStateController.gameObject.SetActive(false);
			}, false, true);
		}

		// Token: 0x0600BB9E RID: 48030 RVA: 0x0034ACE0 File Offset: 0x00348EE0
		private void HideCutsceneSkill()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HideCutsceneSkill_hotfix != null)
			{
				this.m_HideCutsceneSkill_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_cutsceneSkillUIStateController.gameObject.SetActive(false);
		}

		// Token: 0x0600BB9F RID: 48031 RVA: 0x0034AD54 File Offset: 0x00348F54
		public void SetAutoBattle(bool on)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetAutoBattleBoolean_hotfix != null)
			{
				this.m_SetAutoBattleBoolean_hotfix.call(new object[]
				{
					this,
					on
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_autoOffButton.gameObject.SetActive(on);
		}

		// Token: 0x0600BBA0 RID: 48032 RVA: 0x0034ADD8 File Offset: 0x00348FD8
		public void SetArenaAutoBattle(bool auto)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetArenaAutoBattleBoolean_hotfix != null)
			{
				this.m_SetArenaAutoBattleBoolean_hotfix.call(new object[]
				{
					this,
					auto
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_arenaAutoButton.gameObject.SetActive(auto);
		}

		// Token: 0x0600BBA1 RID: 48033 RVA: 0x0034AE5C File Offset: 0x0034905C
		private void OnAutoOffButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnAutoOffButtonClick_hotfix != null)
			{
				this.m_OnAutoOffButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnAutoBattle != null)
			{
				this.EventOnAutoBattle(false);
			}
		}

		// Token: 0x0600BBA2 RID: 48034 RVA: 0x0034AED4 File Offset: 0x003490D4
		private void OnArenaAutoButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnArenaAutoButtonClick_hotfix != null)
			{
				this.m_OnArenaAutoButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIController.Instance.ShowMessage(StringTableId.StringTableId_Battle_ArenaAutoBattle, 2f, null, true);
		}

		// Token: 0x14000244 RID: 580
		// (add) Token: 0x0600BBA3 RID: 48035 RVA: 0x0034AF4C File Offset: 0x0034914C
		// (remove) Token: 0x0600BBA4 RID: 48036 RVA: 0x0034AFE8 File Offset: 0x003491E8
		public event Action<bool> EventOnAutoBattle
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnAutoBattleAction`1_hotfix != null)
				{
					this.m_add_EventOnAutoBattleAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<bool> action = this.EventOnAutoBattle;
				Action<bool> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<bool>>(ref this.EventOnAutoBattle, (Action<bool>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnAutoBattleAction`1_hotfix != null)
				{
					this.m_remove_EventOnAutoBattleAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<bool> action = this.EventOnAutoBattle;
				Action<bool> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<bool>>(ref this.EventOnAutoBattle, (Action<bool>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17002589 RID: 9609
		// (get) Token: 0x0600BBA5 RID: 48037 RVA: 0x0034B084 File Offset: 0x00349284
		// (set) Token: 0x0600BBA6 RID: 48038 RVA: 0x0034B0A4 File Offset: 0x003492A4
		[DoNotToLua]
		public new CombatUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new CombatUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600BBA7 RID: 48039 RVA: 0x0034B0B0 File Offset: 0x003492B0
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0600BBA8 RID: 48040 RVA: 0x0034B0BC File Offset: 0x003492BC
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0600BBA9 RID: 48041 RVA: 0x0034B0C4 File Offset: 0x003492C4
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0600BBAA RID: 48042 RVA: 0x0034B0CC File Offset: 0x003492CC
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0600BBAB RID: 48043 RVA: 0x0034B0E0 File Offset: 0x003492E0
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0600BBAC RID: 48044 RVA: 0x0034B0E8 File Offset: 0x003492E8
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0600BBAD RID: 48045 RVA: 0x0034B0F4 File Offset: 0x003492F4
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0600BBAE RID: 48046 RVA: 0x0034B100 File Offset: 0x00349300
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0600BBAF RID: 48047 RVA: 0x0034B10C File Offset: 0x0034930C
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0600BBB0 RID: 48048 RVA: 0x0034B118 File Offset: 0x00349318
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0600BBB1 RID: 48049 RVA: 0x0034B124 File Offset: 0x00349324
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0600BBB2 RID: 48050 RVA: 0x0034B130 File Offset: 0x00349330
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0600BBB3 RID: 48051 RVA: 0x0034B13C File Offset: 0x0034933C
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0600BBB4 RID: 48052 RVA: 0x0034B148 File Offset: 0x00349348
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0600BBB5 RID: 48053 RVA: 0x0034B154 File Offset: 0x00349354
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600BBB6 RID: 48054 RVA: 0x0034B15C File Offset: 0x0034935C
		private void __callDele_EventOnAutoBattle(bool obj)
		{
			Action<bool> eventOnAutoBattle = this.EventOnAutoBattle;
			if (eventOnAutoBattle != null)
			{
				eventOnAutoBattle(obj);
			}
		}

		// Token: 0x0600BBB7 RID: 48055 RVA: 0x0034B180 File Offset: 0x00349380
		private void __clearDele_EventOnAutoBattle(bool obj)
		{
			this.EventOnAutoBattle = null;
		}

		// Token: 0x0600BBBA RID: 48058 RVA: 0x0034B1B4 File Offset: 0x003493B4
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
					this.m_OnBindFiledsCompleted_hotfix = (luaObj.RawGet("OnBindFiledsCompleted") as LuaFunction);
					this.m_InitializeFxPlayer_hotfix = (luaObj.RawGet("Initialize") as LuaFunction);
					this.m_StartCombatBooleanBooleanInt32_hotfix = (luaObj.RawGet("StartCombat") as LuaFunction);
					this.m_ForceUpdateChar_hotfix = (luaObj.RawGet("ForceUpdateChar") as LuaFunction);
					this.m_PreStopCombat_hotfix = (luaObj.RawGet("PreStopCombat") as LuaFunction);
					this.m_StopCombat_hotfix = (luaObj.RawGet("StopCombat") as LuaFunction);
					this.m_ResetHPStates_hotfix = (luaObj.RawGet("ResetHPStates") as LuaFunction);
					this.m_TeamToSideInt32_hotfix = (luaObj.RawGet("TeamToSide") as LuaFunction);
					this.m_SetHealthPointInt32Int32Int32Int32Int32_hotfix = (luaObj.RawGet("SetHealthPoint") as LuaFunction);
					this.m_UpdateHPStateInt32Single_hotfix = (luaObj.RawGet("UpdateHPState") as LuaFunction);
					this.m_ShowDamageInt32BooleanInt32Int32Int32Int32Int32DamageNumberType_hotfix = (luaObj.RawGet("ShowDamage") as LuaFunction);
					this.m_SetCharImageInfoInt32ConfigDataCharImageInfoConfigDataCharImageSkinResourceInfo_hotfix = (luaObj.RawGet("SetCharImageInfo") as LuaFunction);
					this.m_ShowCutsceneSkillConfigDataSkillInfo_hotfix = (luaObj.RawGet("ShowCutsceneSkill") as LuaFunction);
					this.m_ShowCutscenePassiveSkillBuffState_hotfix = (luaObj.RawGet("ShowCutscenePassiveSkill") as LuaFunction);
					this.m_HideCutsceneSkill_hotfix = (luaObj.RawGet("HideCutsceneSkill") as LuaFunction);
					this.m_SetAutoBattleBoolean_hotfix = (luaObj.RawGet("SetAutoBattle") as LuaFunction);
					this.m_SetArenaAutoBattleBoolean_hotfix = (luaObj.RawGet("SetArenaAutoBattle") as LuaFunction);
					this.m_OnAutoOffButtonClick_hotfix = (luaObj.RawGet("OnAutoOffButtonClick") as LuaFunction);
					this.m_OnArenaAutoButtonClick_hotfix = (luaObj.RawGet("OnArenaAutoButtonClick") as LuaFunction);
					this.m_add_EventOnAutoBattleAction`1_hotfix = (luaObj.RawGet("add_EventOnAutoBattle") as LuaFunction);
					this.m_remove_EventOnAutoBattleAction`1_hotfix = (luaObj.RawGet("remove_EventOnAutoBattle") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600BBBB RID: 48059 RVA: 0x0034B474 File Offset: 0x00349674
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(CombatUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04007884 RID: 30852
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_uiStateController;

		// Token: 0x04007885 RID: 30853
		[AutoBind("./Margin", AutoBindAttribute.InitState.NotInit, false)]
		private RectTransform m_marginTransform;

		// Token: 0x04007886 RID: 30854
		[AutoBind("./Margin/AutoOffButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_autoOffButton;

		// Token: 0x04007887 RID: 30855
		[AutoBind("./Margin/ArenaAutoButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_arenaAutoButton;

		// Token: 0x04007888 RID: 30856
		[AutoBind("./CutsceneSkill", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_cutsceneSkillUIStateController;

		// Token: 0x04007889 RID: 30857
		[AutoBind("./CutsceneSkill/Icon/Image", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_cutsceneSkillIconImage;

		// Token: 0x0400788A RID: 30858
		[AutoBind("./CutsceneSkill/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_cutsceneSkillNameText;

		// Token: 0x0400788B RID: 30859
		[AutoBind("./Bottom/HeroHP0/Bar", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_heroHp0Image;

		// Token: 0x0400788C RID: 30860
		[AutoBind("./Bottom/HeroHP0/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_heroHp0Text;

		// Token: 0x0400788D RID: 30861
		[AutoBind("./Bottom/HeroHP0/Fx", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_heroHp0FxGameObeject;

		// Token: 0x0400788E RID: 30862
		[AutoBind("./Bottom/HeroHP1/Bar", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_heroHp1Image;

		// Token: 0x0400788F RID: 30863
		[AutoBind("./Bottom/HeroHP1/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_heroHp1Text;

		// Token: 0x04007890 RID: 30864
		[AutoBind("./Bottom/HeroHP1/Fx", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_heroHp1FxGameObeject;

		// Token: 0x04007891 RID: 30865
		[AutoBind("./Bottom/SoldierHP0/Bar", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_soldierHp0Image;

		// Token: 0x04007892 RID: 30866
		[AutoBind("./Bottom/SoldierHP0/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_soldierHp0Text;

		// Token: 0x04007893 RID: 30867
		[AutoBind("./Bottom/SoldierHP0/Fx", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_soldierHp0FxGameObeject;

		// Token: 0x04007894 RID: 30868
		[AutoBind("./Bottom/SoldierHP1/Bar", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_soldierHp1Image;

		// Token: 0x04007895 RID: 30869
		[AutoBind("./Bottom/SoldierHP1/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_soldierHp1Text;

		// Token: 0x04007896 RID: 30870
		[AutoBind("./Bottom/SoldierHP1/Fx", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_soldierHp1FxGameObeject;

		// Token: 0x04007897 RID: 30871
		[AutoBind("./Bottom/BossHP/Bar", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_bossHpImage;

		// Token: 0x04007898 RID: 30872
		[AutoBind("./Bottom/BossHP/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_bossHpText;

		// Token: 0x04007899 RID: 30873
		[AutoBind("./Bottom/BossHP/Fx", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_bossHpFxGameObeject;

		// Token: 0x0400789A RID: 30874
		[AutoBind("./Bottom/Damage0", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_damage0UIStateController;

		// Token: 0x0400789B RID: 30875
		[AutoBind("./Bottom/Damage1", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_damage1UIStateController;

		// Token: 0x0400789C RID: 30876
		[AutoBind("./Bottom/Damage0/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_damage0Text;

		// Token: 0x0400789D RID: 30877
		[AutoBind("./Bottom/Damage0/CriticalText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_damage0CriticalText;

		// Token: 0x0400789E RID: 30878
		[AutoBind("./Bottom/Damage1/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_damage1Text;

		// Token: 0x0400789F RID: 30879
		[AutoBind("./Bottom/Damage1/CriticalText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_damage1CriticalText;

		// Token: 0x040078A0 RID: 30880
		[AutoBind("./Char/0", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_char0GameObject;

		// Token: 0x040078A1 RID: 30881
		[AutoBind("./Char/1", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_char1GameObject;

		// Token: 0x040078A2 RID: 30882
		[AutoBind("./BackgroundCanvas/Boundary", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_boundaryGameObject;

		// Token: 0x040078A3 RID: 30883
		private CombatUIController.HPState[] m_hpStates = new CombatUIController.HPState[2];

		// Token: 0x040078A4 RID: 30884
		private FxPlayer m_fxPlayer;

		// Token: 0x040078A5 RID: 30885
		private bool m_isBoss;

		// Token: 0x040078A6 RID: 30886
		private int m_myPlayerTeam;

		// Token: 0x040078A7 RID: 30887
		[DoNotToLua]
		private CombatUIController.LuaExportHelper luaExportHelper;

		// Token: 0x040078A8 RID: 30888
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040078A9 RID: 30889
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040078AA RID: 30890
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x040078AB RID: 30891
		private LuaFunction m_InitializeFxPlayer_hotfix;

		// Token: 0x040078AC RID: 30892
		private LuaFunction m_StartCombatBooleanBooleanInt32_hotfix;

		// Token: 0x040078AD RID: 30893
		private LuaFunction m_ForceUpdateChar_hotfix;

		// Token: 0x040078AE RID: 30894
		private LuaFunction m_PreStopCombat_hotfix;

		// Token: 0x040078AF RID: 30895
		private LuaFunction m_StopCombat_hotfix;

		// Token: 0x040078B0 RID: 30896
		private LuaFunction m_ResetHPStates_hotfix;

		// Token: 0x040078B1 RID: 30897
		private LuaFunction m_TeamToSideInt32_hotfix;

		// Token: 0x040078B2 RID: 30898
		private LuaFunction m_SetHealthPointInt32Int32Int32Int32Int32_hotfix;

		// Token: 0x040078B3 RID: 30899
		private LuaFunction m_UpdateHPStateInt32Single_hotfix;

		// Token: 0x040078B4 RID: 30900
		private LuaFunction m_ShowDamageInt32BooleanInt32Int32Int32Int32Int32DamageNumberType_hotfix;

		// Token: 0x040078B5 RID: 30901
		private LuaFunction m_SetCharImageInfoInt32ConfigDataCharImageInfoConfigDataCharImageSkinResourceInfo_hotfix;

		// Token: 0x040078B6 RID: 30902
		private LuaFunction m_ShowCutsceneSkillConfigDataSkillInfo_hotfix;

		// Token: 0x040078B7 RID: 30903
		private LuaFunction m_ShowCutscenePassiveSkillBuffState_hotfix;

		// Token: 0x040078B8 RID: 30904
		private LuaFunction m_HideCutsceneSkill_hotfix;

		// Token: 0x040078B9 RID: 30905
		private LuaFunction m_SetAutoBattleBoolean_hotfix;

		// Token: 0x040078BA RID: 30906
		private LuaFunction m_SetArenaAutoBattleBoolean_hotfix;

		// Token: 0x040078BB RID: 30907
		private LuaFunction m_OnAutoOffButtonClick_hotfix;

		// Token: 0x040078BC RID: 30908
		private LuaFunction m_OnArenaAutoButtonClick_hotfix;

		// Token: 0x040078BD RID: 30909
		private LuaFunction m_add_EventOnAutoBattleAction;

		// Token: 0x040078BE RID: 30910
		private LuaFunction m_remove_EventOnAutoBattleAction;

		// Token: 0x02000AF9 RID: 2809
		public struct Damage
		{
			// Token: 0x040078BF RID: 30911
			public int m_combatFrame;

			// Token: 0x040078C0 RID: 30912
			public float m_damagePercent;
		}

		// Token: 0x02000AFA RID: 2810
		[HotFix]
		public class HPState
		{
			// Token: 0x040078C1 RID: 30913
			public CombatCharUIController m_combatCharUIController;

			// Token: 0x040078C2 RID: 30914
			public float m_totalHpPercent;

			// Token: 0x040078C3 RID: 30915
			public List<CombatUIController.Damage> m_heroDamages = new List<CombatUIController.Damage>();

			// Token: 0x040078C4 RID: 30916
			public List<CombatUIController.Damage> m_soldierDamages = new List<CombatUIController.Damage>();

			// Token: 0x040078C5 RID: 30917
			public bool m_isCritical;
		}

		// Token: 0x02000AFB RID: 2811
		public new class LuaExportHelper
		{
			// Token: 0x0600BBBD RID: 48061 RVA: 0x0034B4FC File Offset: 0x003496FC
			public LuaExportHelper(CombatUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600BBBE RID: 48062 RVA: 0x0034B50C File Offset: 0x0034970C
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0600BBBF RID: 48063 RVA: 0x0034B51C File Offset: 0x0034971C
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0600BBC0 RID: 48064 RVA: 0x0034B52C File Offset: 0x0034972C
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600BBC1 RID: 48065 RVA: 0x0034B53C File Offset: 0x0034973C
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600BBC2 RID: 48066 RVA: 0x0034B554 File Offset: 0x00349754
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0600BBC3 RID: 48067 RVA: 0x0034B564 File Offset: 0x00349764
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0600BBC4 RID: 48068 RVA: 0x0034B574 File Offset: 0x00349774
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0600BBC5 RID: 48069 RVA: 0x0034B584 File Offset: 0x00349784
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0600BBC6 RID: 48070 RVA: 0x0034B594 File Offset: 0x00349794
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0600BBC7 RID: 48071 RVA: 0x0034B5A4 File Offset: 0x003497A4
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0600BBC8 RID: 48072 RVA: 0x0034B5B4 File Offset: 0x003497B4
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0600BBC9 RID: 48073 RVA: 0x0034B5C4 File Offset: 0x003497C4
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0600BBCA RID: 48074 RVA: 0x0034B5D4 File Offset: 0x003497D4
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0600BBCB RID: 48075 RVA: 0x0034B5E4 File Offset: 0x003497E4
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0600BBCC RID: 48076 RVA: 0x0034B5F4 File Offset: 0x003497F4
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x0600BBCD RID: 48077 RVA: 0x0034B604 File Offset: 0x00349804
			public void __callDele_EventOnAutoBattle(bool obj)
			{
				this.m_owner.__callDele_EventOnAutoBattle(obj);
			}

			// Token: 0x0600BBCE RID: 48078 RVA: 0x0034B614 File Offset: 0x00349814
			public void __clearDele_EventOnAutoBattle(bool obj)
			{
				this.m_owner.__clearDele_EventOnAutoBattle(obj);
			}

			// Token: 0x1700258A RID: 9610
			// (get) Token: 0x0600BBCF RID: 48079 RVA: 0x0034B624 File Offset: 0x00349824
			// (set) Token: 0x0600BBD0 RID: 48080 RVA: 0x0034B634 File Offset: 0x00349834
			public CommonUIStateController m_uiStateController
			{
				get
				{
					return this.m_owner.m_uiStateController;
				}
				set
				{
					this.m_owner.m_uiStateController = value;
				}
			}

			// Token: 0x1700258B RID: 9611
			// (get) Token: 0x0600BBD1 RID: 48081 RVA: 0x0034B644 File Offset: 0x00349844
			// (set) Token: 0x0600BBD2 RID: 48082 RVA: 0x0034B654 File Offset: 0x00349854
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

			// Token: 0x1700258C RID: 9612
			// (get) Token: 0x0600BBD3 RID: 48083 RVA: 0x0034B664 File Offset: 0x00349864
			// (set) Token: 0x0600BBD4 RID: 48084 RVA: 0x0034B674 File Offset: 0x00349874
			public Button m_autoOffButton
			{
				get
				{
					return this.m_owner.m_autoOffButton;
				}
				set
				{
					this.m_owner.m_autoOffButton = value;
				}
			}

			// Token: 0x1700258D RID: 9613
			// (get) Token: 0x0600BBD5 RID: 48085 RVA: 0x0034B684 File Offset: 0x00349884
			// (set) Token: 0x0600BBD6 RID: 48086 RVA: 0x0034B694 File Offset: 0x00349894
			public Button m_arenaAutoButton
			{
				get
				{
					return this.m_owner.m_arenaAutoButton;
				}
				set
				{
					this.m_owner.m_arenaAutoButton = value;
				}
			}

			// Token: 0x1700258E RID: 9614
			// (get) Token: 0x0600BBD7 RID: 48087 RVA: 0x0034B6A4 File Offset: 0x003498A4
			// (set) Token: 0x0600BBD8 RID: 48088 RVA: 0x0034B6B4 File Offset: 0x003498B4
			public CommonUIStateController m_cutsceneSkillUIStateController
			{
				get
				{
					return this.m_owner.m_cutsceneSkillUIStateController;
				}
				set
				{
					this.m_owner.m_cutsceneSkillUIStateController = value;
				}
			}

			// Token: 0x1700258F RID: 9615
			// (get) Token: 0x0600BBD9 RID: 48089 RVA: 0x0034B6C4 File Offset: 0x003498C4
			// (set) Token: 0x0600BBDA RID: 48090 RVA: 0x0034B6D4 File Offset: 0x003498D4
			public Image m_cutsceneSkillIconImage
			{
				get
				{
					return this.m_owner.m_cutsceneSkillIconImage;
				}
				set
				{
					this.m_owner.m_cutsceneSkillIconImage = value;
				}
			}

			// Token: 0x17002590 RID: 9616
			// (get) Token: 0x0600BBDB RID: 48091 RVA: 0x0034B6E4 File Offset: 0x003498E4
			// (set) Token: 0x0600BBDC RID: 48092 RVA: 0x0034B6F4 File Offset: 0x003498F4
			public Text m_cutsceneSkillNameText
			{
				get
				{
					return this.m_owner.m_cutsceneSkillNameText;
				}
				set
				{
					this.m_owner.m_cutsceneSkillNameText = value;
				}
			}

			// Token: 0x17002591 RID: 9617
			// (get) Token: 0x0600BBDD RID: 48093 RVA: 0x0034B704 File Offset: 0x00349904
			// (set) Token: 0x0600BBDE RID: 48094 RVA: 0x0034B714 File Offset: 0x00349914
			public Image m_heroHp0Image
			{
				get
				{
					return this.m_owner.m_heroHp0Image;
				}
				set
				{
					this.m_owner.m_heroHp0Image = value;
				}
			}

			// Token: 0x17002592 RID: 9618
			// (get) Token: 0x0600BBDF RID: 48095 RVA: 0x0034B724 File Offset: 0x00349924
			// (set) Token: 0x0600BBE0 RID: 48096 RVA: 0x0034B734 File Offset: 0x00349934
			public Text m_heroHp0Text
			{
				get
				{
					return this.m_owner.m_heroHp0Text;
				}
				set
				{
					this.m_owner.m_heroHp0Text = value;
				}
			}

			// Token: 0x17002593 RID: 9619
			// (get) Token: 0x0600BBE1 RID: 48097 RVA: 0x0034B744 File Offset: 0x00349944
			// (set) Token: 0x0600BBE2 RID: 48098 RVA: 0x0034B754 File Offset: 0x00349954
			public GameObject m_heroHp0FxGameObeject
			{
				get
				{
					return this.m_owner.m_heroHp0FxGameObeject;
				}
				set
				{
					this.m_owner.m_heroHp0FxGameObeject = value;
				}
			}

			// Token: 0x17002594 RID: 9620
			// (get) Token: 0x0600BBE3 RID: 48099 RVA: 0x0034B764 File Offset: 0x00349964
			// (set) Token: 0x0600BBE4 RID: 48100 RVA: 0x0034B774 File Offset: 0x00349974
			public Image m_heroHp1Image
			{
				get
				{
					return this.m_owner.m_heroHp1Image;
				}
				set
				{
					this.m_owner.m_heroHp1Image = value;
				}
			}

			// Token: 0x17002595 RID: 9621
			// (get) Token: 0x0600BBE5 RID: 48101 RVA: 0x0034B784 File Offset: 0x00349984
			// (set) Token: 0x0600BBE6 RID: 48102 RVA: 0x0034B794 File Offset: 0x00349994
			public Text m_heroHp1Text
			{
				get
				{
					return this.m_owner.m_heroHp1Text;
				}
				set
				{
					this.m_owner.m_heroHp1Text = value;
				}
			}

			// Token: 0x17002596 RID: 9622
			// (get) Token: 0x0600BBE7 RID: 48103 RVA: 0x0034B7A4 File Offset: 0x003499A4
			// (set) Token: 0x0600BBE8 RID: 48104 RVA: 0x0034B7B4 File Offset: 0x003499B4
			public GameObject m_heroHp1FxGameObeject
			{
				get
				{
					return this.m_owner.m_heroHp1FxGameObeject;
				}
				set
				{
					this.m_owner.m_heroHp1FxGameObeject = value;
				}
			}

			// Token: 0x17002597 RID: 9623
			// (get) Token: 0x0600BBE9 RID: 48105 RVA: 0x0034B7C4 File Offset: 0x003499C4
			// (set) Token: 0x0600BBEA RID: 48106 RVA: 0x0034B7D4 File Offset: 0x003499D4
			public Image m_soldierHp0Image
			{
				get
				{
					return this.m_owner.m_soldierHp0Image;
				}
				set
				{
					this.m_owner.m_soldierHp0Image = value;
				}
			}

			// Token: 0x17002598 RID: 9624
			// (get) Token: 0x0600BBEB RID: 48107 RVA: 0x0034B7E4 File Offset: 0x003499E4
			// (set) Token: 0x0600BBEC RID: 48108 RVA: 0x0034B7F4 File Offset: 0x003499F4
			public Text m_soldierHp0Text
			{
				get
				{
					return this.m_owner.m_soldierHp0Text;
				}
				set
				{
					this.m_owner.m_soldierHp0Text = value;
				}
			}

			// Token: 0x17002599 RID: 9625
			// (get) Token: 0x0600BBED RID: 48109 RVA: 0x0034B804 File Offset: 0x00349A04
			// (set) Token: 0x0600BBEE RID: 48110 RVA: 0x0034B814 File Offset: 0x00349A14
			public GameObject m_soldierHp0FxGameObeject
			{
				get
				{
					return this.m_owner.m_soldierHp0FxGameObeject;
				}
				set
				{
					this.m_owner.m_soldierHp0FxGameObeject = value;
				}
			}

			// Token: 0x1700259A RID: 9626
			// (get) Token: 0x0600BBEF RID: 48111 RVA: 0x0034B824 File Offset: 0x00349A24
			// (set) Token: 0x0600BBF0 RID: 48112 RVA: 0x0034B834 File Offset: 0x00349A34
			public Image m_soldierHp1Image
			{
				get
				{
					return this.m_owner.m_soldierHp1Image;
				}
				set
				{
					this.m_owner.m_soldierHp1Image = value;
				}
			}

			// Token: 0x1700259B RID: 9627
			// (get) Token: 0x0600BBF1 RID: 48113 RVA: 0x0034B844 File Offset: 0x00349A44
			// (set) Token: 0x0600BBF2 RID: 48114 RVA: 0x0034B854 File Offset: 0x00349A54
			public Text m_soldierHp1Text
			{
				get
				{
					return this.m_owner.m_soldierHp1Text;
				}
				set
				{
					this.m_owner.m_soldierHp1Text = value;
				}
			}

			// Token: 0x1700259C RID: 9628
			// (get) Token: 0x0600BBF3 RID: 48115 RVA: 0x0034B864 File Offset: 0x00349A64
			// (set) Token: 0x0600BBF4 RID: 48116 RVA: 0x0034B874 File Offset: 0x00349A74
			public GameObject m_soldierHp1FxGameObeject
			{
				get
				{
					return this.m_owner.m_soldierHp1FxGameObeject;
				}
				set
				{
					this.m_owner.m_soldierHp1FxGameObeject = value;
				}
			}

			// Token: 0x1700259D RID: 9629
			// (get) Token: 0x0600BBF5 RID: 48117 RVA: 0x0034B884 File Offset: 0x00349A84
			// (set) Token: 0x0600BBF6 RID: 48118 RVA: 0x0034B894 File Offset: 0x00349A94
			public Image m_bossHpImage
			{
				get
				{
					return this.m_owner.m_bossHpImage;
				}
				set
				{
					this.m_owner.m_bossHpImage = value;
				}
			}

			// Token: 0x1700259E RID: 9630
			// (get) Token: 0x0600BBF7 RID: 48119 RVA: 0x0034B8A4 File Offset: 0x00349AA4
			// (set) Token: 0x0600BBF8 RID: 48120 RVA: 0x0034B8B4 File Offset: 0x00349AB4
			public Text m_bossHpText
			{
				get
				{
					return this.m_owner.m_bossHpText;
				}
				set
				{
					this.m_owner.m_bossHpText = value;
				}
			}

			// Token: 0x1700259F RID: 9631
			// (get) Token: 0x0600BBF9 RID: 48121 RVA: 0x0034B8C4 File Offset: 0x00349AC4
			// (set) Token: 0x0600BBFA RID: 48122 RVA: 0x0034B8D4 File Offset: 0x00349AD4
			public GameObject m_bossHpFxGameObeject
			{
				get
				{
					return this.m_owner.m_bossHpFxGameObeject;
				}
				set
				{
					this.m_owner.m_bossHpFxGameObeject = value;
				}
			}

			// Token: 0x170025A0 RID: 9632
			// (get) Token: 0x0600BBFB RID: 48123 RVA: 0x0034B8E4 File Offset: 0x00349AE4
			// (set) Token: 0x0600BBFC RID: 48124 RVA: 0x0034B8F4 File Offset: 0x00349AF4
			public CommonUIStateController m_damage0UIStateController
			{
				get
				{
					return this.m_owner.m_damage0UIStateController;
				}
				set
				{
					this.m_owner.m_damage0UIStateController = value;
				}
			}

			// Token: 0x170025A1 RID: 9633
			// (get) Token: 0x0600BBFD RID: 48125 RVA: 0x0034B904 File Offset: 0x00349B04
			// (set) Token: 0x0600BBFE RID: 48126 RVA: 0x0034B914 File Offset: 0x00349B14
			public CommonUIStateController m_damage1UIStateController
			{
				get
				{
					return this.m_owner.m_damage1UIStateController;
				}
				set
				{
					this.m_owner.m_damage1UIStateController = value;
				}
			}

			// Token: 0x170025A2 RID: 9634
			// (get) Token: 0x0600BBFF RID: 48127 RVA: 0x0034B924 File Offset: 0x00349B24
			// (set) Token: 0x0600BC00 RID: 48128 RVA: 0x0034B934 File Offset: 0x00349B34
			public Text m_damage0Text
			{
				get
				{
					return this.m_owner.m_damage0Text;
				}
				set
				{
					this.m_owner.m_damage0Text = value;
				}
			}

			// Token: 0x170025A3 RID: 9635
			// (get) Token: 0x0600BC01 RID: 48129 RVA: 0x0034B944 File Offset: 0x00349B44
			// (set) Token: 0x0600BC02 RID: 48130 RVA: 0x0034B954 File Offset: 0x00349B54
			public Text m_damage0CriticalText
			{
				get
				{
					return this.m_owner.m_damage0CriticalText;
				}
				set
				{
					this.m_owner.m_damage0CriticalText = value;
				}
			}

			// Token: 0x170025A4 RID: 9636
			// (get) Token: 0x0600BC03 RID: 48131 RVA: 0x0034B964 File Offset: 0x00349B64
			// (set) Token: 0x0600BC04 RID: 48132 RVA: 0x0034B974 File Offset: 0x00349B74
			public Text m_damage1Text
			{
				get
				{
					return this.m_owner.m_damage1Text;
				}
				set
				{
					this.m_owner.m_damage1Text = value;
				}
			}

			// Token: 0x170025A5 RID: 9637
			// (get) Token: 0x0600BC05 RID: 48133 RVA: 0x0034B984 File Offset: 0x00349B84
			// (set) Token: 0x0600BC06 RID: 48134 RVA: 0x0034B994 File Offset: 0x00349B94
			public Text m_damage1CriticalText
			{
				get
				{
					return this.m_owner.m_damage1CriticalText;
				}
				set
				{
					this.m_owner.m_damage1CriticalText = value;
				}
			}

			// Token: 0x170025A6 RID: 9638
			// (get) Token: 0x0600BC07 RID: 48135 RVA: 0x0034B9A4 File Offset: 0x00349BA4
			// (set) Token: 0x0600BC08 RID: 48136 RVA: 0x0034B9B4 File Offset: 0x00349BB4
			public GameObject m_char0GameObject
			{
				get
				{
					return this.m_owner.m_char0GameObject;
				}
				set
				{
					this.m_owner.m_char0GameObject = value;
				}
			}

			// Token: 0x170025A7 RID: 9639
			// (get) Token: 0x0600BC09 RID: 48137 RVA: 0x0034B9C4 File Offset: 0x00349BC4
			// (set) Token: 0x0600BC0A RID: 48138 RVA: 0x0034B9D4 File Offset: 0x00349BD4
			public GameObject m_char1GameObject
			{
				get
				{
					return this.m_owner.m_char1GameObject;
				}
				set
				{
					this.m_owner.m_char1GameObject = value;
				}
			}

			// Token: 0x170025A8 RID: 9640
			// (get) Token: 0x0600BC0B RID: 48139 RVA: 0x0034B9E4 File Offset: 0x00349BE4
			// (set) Token: 0x0600BC0C RID: 48140 RVA: 0x0034B9F4 File Offset: 0x00349BF4
			public GameObject m_boundaryGameObject
			{
				get
				{
					return this.m_owner.m_boundaryGameObject;
				}
				set
				{
					this.m_owner.m_boundaryGameObject = value;
				}
			}

			// Token: 0x170025A9 RID: 9641
			// (get) Token: 0x0600BC0D RID: 48141 RVA: 0x0034BA04 File Offset: 0x00349C04
			// (set) Token: 0x0600BC0E RID: 48142 RVA: 0x0034BA14 File Offset: 0x00349C14
			public CombatUIController.HPState[] m_hpStates
			{
				get
				{
					return this.m_owner.m_hpStates;
				}
				set
				{
					this.m_owner.m_hpStates = value;
				}
			}

			// Token: 0x170025AA RID: 9642
			// (get) Token: 0x0600BC0F RID: 48143 RVA: 0x0034BA24 File Offset: 0x00349C24
			// (set) Token: 0x0600BC10 RID: 48144 RVA: 0x0034BA34 File Offset: 0x00349C34
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

			// Token: 0x170025AB RID: 9643
			// (get) Token: 0x0600BC11 RID: 48145 RVA: 0x0034BA44 File Offset: 0x00349C44
			// (set) Token: 0x0600BC12 RID: 48146 RVA: 0x0034BA54 File Offset: 0x00349C54
			public bool m_isBoss
			{
				get
				{
					return this.m_owner.m_isBoss;
				}
				set
				{
					this.m_owner.m_isBoss = value;
				}
			}

			// Token: 0x170025AC RID: 9644
			// (get) Token: 0x0600BC13 RID: 48147 RVA: 0x0034BA64 File Offset: 0x00349C64
			// (set) Token: 0x0600BC14 RID: 48148 RVA: 0x0034BA74 File Offset: 0x00349C74
			public int m_myPlayerTeam
			{
				get
				{
					return this.m_owner.m_myPlayerTeam;
				}
				set
				{
					this.m_owner.m_myPlayerTeam = value;
				}
			}

			// Token: 0x0600BC15 RID: 48149 RVA: 0x0034BA84 File Offset: 0x00349C84
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0600BC16 RID: 48150 RVA: 0x0034BA94 File Offset: 0x00349C94
			public void ResetHPStates()
			{
				this.m_owner.ResetHPStates();
			}

			// Token: 0x0600BC17 RID: 48151 RVA: 0x0034BAA4 File Offset: 0x00349CA4
			public int TeamToSide(int team)
			{
				return this.m_owner.TeamToSide(team);
			}

			// Token: 0x0600BC18 RID: 48152 RVA: 0x0034BAB4 File Offset: 0x00349CB4
			public void UpdateHPState(int side, float totalHpPercent)
			{
				this.m_owner.UpdateHPState(side, totalHpPercent);
			}

			// Token: 0x0600BC19 RID: 48153 RVA: 0x0034BAC4 File Offset: 0x00349CC4
			public void HideCutsceneSkill()
			{
				this.m_owner.HideCutsceneSkill();
			}

			// Token: 0x0600BC1A RID: 48154 RVA: 0x0034BAD4 File Offset: 0x00349CD4
			public void OnAutoOffButtonClick()
			{
				this.m_owner.OnAutoOffButtonClick();
			}

			// Token: 0x0600BC1B RID: 48155 RVA: 0x0034BAE4 File Offset: 0x00349CE4
			public void OnArenaAutoButtonClick()
			{
				this.m_owner.OnArenaAutoButtonClick();
			}

			// Token: 0x040078C6 RID: 30918
			private CombatUIController m_owner;
		}
	}
}
