using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Battle;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Misc;
using BlackJack.ProjectL.Scene;
using SLua;
using UnityEngine;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000A95 RID: 2709
	[HotFix]
	public class BattlePrepareStageActor
	{
		// Token: 0x0600AC46 RID: 44102 RVA: 0x002FDC3C File Offset: 0x002FBE3C
		public BattlePrepareStageActor(ClientBattle clientBattle)
		{
			this.m_clientBattle = clientBattle;
			this.m_tweenFromColor = (this.m_tweenToColor = new Colori(byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue));
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ctorClientBattle_hotfix != null)
			{
				this.m_ctorClientBattle_hotfix.call(new object[]
				{
					this,
					clientBattle
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x0600AC47 RID: 44103 RVA: 0x002FDCFC File Offset: 0x002FBEFC
		public void Destroy()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Destroy_hotfix != null)
			{
				this.m_Destroy_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.DestroyGraphic();
			this.DestroyUI();
		}

		// Token: 0x0600AC48 RID: 44104 RVA: 0x002FDD68 File Offset: 0x002FBF68
		private void DestroyGraphic()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DestroyGraphic_hotfix != null)
			{
				this.m_DestroyGraphic_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			for (int i = 0; i < this.m_graphics.Length; i++)
			{
				if (this.m_graphics[i] != null)
				{
					this.m_clientBattle.DestroyBattleGraphic(this.m_graphics[i]);
					this.m_graphics[i] = null;
				}
			}
		}

		// Token: 0x0600AC49 RID: 44105 RVA: 0x002FDE0C File Offset: 0x002FC00C
		private void DestroyUI()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DestroyUI_hotfix != null)
			{
				this.m_DestroyUI_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_uiController != null)
			{
				UnityEngine.Object.Destroy(this.m_uiController.gameObject);
				this.m_uiController = null;
			}
		}

		// Token: 0x0600AC4A RID: 44106 RVA: 0x002FDE94 File Offset: 0x002FC094
		public void Setup(BattleHero hero, int team, StagePositionType posType, StageActorTagType tagType, int behaviorId, int groupId, int playerIndex, bool isSkipGraphic)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetupBattleHeroInt32StagePositionTypeStageActorTagTypeInt32Int32Int32Boolean_hotfix != null)
			{
				this.m_SetupBattleHeroInt32StagePositionTypeStageActorTagTypeInt32Int32Int32Boolean_hotfix.call(new object[]
				{
					this,
					hero,
					team,
					posType,
					tagType,
					behaviorId,
					groupId,
					playerIndex,
					isSkipGraphic
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_hero = hero;
			this.m_team = team;
			this.m_stagePositionType = posType;
			this.m_tagType = tagType;
			this.m_behaviorId = behaviorId;
			this.m_groupId = groupId;
			this.m_playerIndex = playerIndex;
			this.m_soldierCount = 2;
			if (isSkipGraphic)
			{
				return;
			}
			this.DestroyGraphic();
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			ConfigDataJobConnectionInfo jobConnectionInfo = hero.GetActiveJob().JobConnectionInfo;
			if (jobConnectionInfo != null)
			{
				ConfigDataModelSkinResourceInfo heroActiveJobModelSkinResourceInfo = hero.GetHeroActiveJobModelSkinResourceInfo(configDataLoader);
				string text = string.Empty;
				if (heroActiveJobModelSkinResourceInfo != null)
				{
					text = heroActiveJobModelSkinResourceInfo.Model;
				}
				if (string.IsNullOrEmpty(text))
				{
					text = jobConnectionInfo.Model;
				}
				this.m_graphics[0] = this.m_clientBattle.CreateBattleGraphic(text, (float)jobConnectionInfo.BF_ModelScale * 0.01f);
				if (this.m_graphics[0] != null)
				{
					this.m_graphics[0].SetReplaceAnimations(jobConnectionInfo.ReplaceAnims);
				}
			}
			ConfigDataSoldierInfo selectedSoldierInfo = hero.SelectedSoldierInfo;
			if (selectedSoldierInfo != null)
			{
				ConfigDataModelSkinResourceInfo selectedSoldierModelSkinResourceInfo = hero.GetSelectedSoldierModelSkinResourceInfo(configDataLoader);
				string text2 = string.Empty;
				if (selectedSoldierModelSkinResourceInfo != null)
				{
					text2 = selectedSoldierModelSkinResourceInfo.Model;
				}
				if (string.IsNullOrEmpty(text2))
				{
					if (team == 0)
					{
						text2 = selectedSoldierInfo.Model;
					}
					else
					{
						text2 = selectedSoldierInfo.Model2;
					}
				}
				for (int i = 0; i < 2; i++)
				{
					this.m_graphics[i + 1] = this.m_clientBattle.CreateBattleGraphic(text2, (float)selectedSoldierInfo.BF_ModelScale * 0.01f);
					if (this.m_graphics[i + 1] != null)
					{
						this.m_graphics[i + 1].SetReplaceAnimations(selectedSoldierInfo.ReplaceAnims);
					}
				}
			}
			this.PlayAnimation("idle", true);
			this.DestroyUI();
			GameObject go = UnityEngine.Object.Instantiate<GameObject>(this.m_clientBattle.BattleActorUIPrefab, this.m_clientBattle.BattleActorUIRoot.transform, false);
			this.m_uiController = GameObjectUtility.AddControllerToGameObject<BattleActorUIController>(go);
			this.m_uiController.SetHp(1, 1);
			this.m_uiController.SetPlayerIndex(playerIndex);
			this.m_uiController.ShowPlayerIndexTag(posType == StagePositionType.Teammate);
			int hpBarType = 0;
			if (team == 0)
			{
				if (this.IsAINpc())
				{
					hpBarType = 2;
				}
			}
			else if (team == 1)
			{
				hpBarType = 1;
			}
			if (posType == StagePositionType.Teammate)
			{
				hpBarType = 2;
			}
			this.m_uiController.SetHpBarType(hpBarType);
			this.m_uiController.SetArmyInfo(jobConnectionInfo.m_jobInfo.m_armyInfo);
			this.m_uiController.ShowTag(tagType);
		}

		// Token: 0x0600AC4B RID: 44107 RVA: 0x002FE1D4 File Offset: 0x002FC3D4
		public BattleHero GetHero()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetHero_hotfix != null)
			{
				return (BattleHero)this.m_GetHero_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_hero;
		}

		// Token: 0x0600AC4C RID: 44108 RVA: 0x002FE248 File Offset: 0x002FC448
		public int GetHeroId()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetHeroId_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetHeroId_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_hero != null)
			{
				return this.m_hero.HeroId;
			}
			return 0;
		}

		// Token: 0x0600AC4D RID: 44109 RVA: 0x002FE2CC File Offset: 0x002FC4CC
		public int GetSoldierId()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetSoldierId_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetSoldierId_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_hero != null)
			{
				return this.m_hero.SelectedSoldierId;
			}
			return 0;
		}

		// Token: 0x0600AC4E RID: 44110 RVA: 0x002FE350 File Offset: 0x002FC550
		public void SetHp(int heroHp, int heroHpMax, int soldierHp, int soldierHpMax)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetHpInt32Int32Int32Int32_hotfix != null)
			{
				this.m_SetHpInt32Int32Int32Int32_hotfix.call(new object[]
				{
					this,
					heroHp,
					heroHpMax,
					soldierHp,
					soldierHpMax
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_heroHealthPoint = heroHp;
			this.m_soldierHealthPoint = soldierHp;
			this.m_soldierCount = this.ComputeSoldierGraphicCount(soldierHp, soldierHpMax);
			this.UpdateGraphicVisible();
			if (this.m_uiController != null)
			{
				this.m_uiController.SetHp(heroHp + soldierHp, heroHpMax + soldierHpMax);
			}
		}

		// Token: 0x0600AC4F RID: 44111 RVA: 0x002FE438 File Offset: 0x002FC638
		public int GetHeroHp()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetHeroHp_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetHeroHp_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_heroHealthPoint;
		}

		// Token: 0x0600AC50 RID: 44112 RVA: 0x002FE4AC File Offset: 0x002FC6AC
		public int GetSoldierHp()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetSoldierHp_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetSoldierHp_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_soldierHealthPoint;
		}

		// Token: 0x0600AC51 RID: 44113 RVA: 0x002FE520 File Offset: 0x002FC720
		public void SetExtraTalentSkillInfo(ConfigDataSkillInfo skillInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetExtraTalentSkillInfoConfigDataSkillInfo_hotfix != null)
			{
				this.m_SetExtraTalentSkillInfoConfigDataSkillInfo_hotfix.call(new object[]
				{
					this,
					skillInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_extraTalentSkillInfo = skillInfo;
		}

		// Token: 0x0600AC52 RID: 44114 RVA: 0x002FE598 File Offset: 0x002FC798
		public ConfigDataSkillInfo GetExtraTalentSkillInfo()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetExtraTalentSkillInfo_hotfix != null)
			{
				return (ConfigDataSkillInfo)this.m_GetExtraTalentSkillInfo_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_extraTalentSkillInfo;
		}

		// Token: 0x0600AC53 RID: 44115 RVA: 0x002FE60C File Offset: 0x002FC80C
		private void PlayAnimation(string name, bool loop)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayAnimationStringBoolean_hotfix != null)
			{
				this.m_PlayAnimationStringBoolean_hotfix.call(new object[]
				{
					this,
					name,
					loop
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (GenericGraphic genericGraphic in this.m_graphics)
			{
				if (genericGraphic != null)
				{
					genericGraphic.PlayAnimation(name, loop);
				}
			}
		}

		// Token: 0x0600AC54 RID: 44116 RVA: 0x002FE6BC File Offset: 0x002FC8BC
		public void SetPosition(GridPosition p, int dir)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetPositionGridPositionInt32_hotfix != null)
			{
				this.m_SetPositionGridPositionInt32_hotfix.call(new object[]
				{
					this,
					p,
					dir
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_position = p;
			this.m_direction = dir;
			this.TickGraphic(0f);
		}

		// Token: 0x0600AC55 RID: 44117 RVA: 0x002FE758 File Offset: 0x002FC958
		public void SetGray(bool isGray)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetGrayBoolean_hotfix != null)
			{
				this.m_SetGrayBoolean_hotfix.call(new object[]
				{
					this,
					isGray
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_isGray = isGray;
			foreach (GenericGraphic genericGraphic in this.m_graphics)
			{
				if (genericGraphic != null)
				{
					if (isGray)
					{
						genericGraphic.SetColor(new Colori(200, 200, 200, byte.MaxValue));
						genericGraphic.SetSaturation(0f);
					}
					else
					{
						genericGraphic.SetColor(new Colori(byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue));
						genericGraphic.SetSaturation(1f);
					}
				}
			}
		}

		// Token: 0x0600AC56 RID: 44118 RVA: 0x002FE854 File Offset: 0x002FCA54
		public void SetChooseEffect(bool canChoose)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetChooseEffectBoolean_hotfix != null)
			{
				this.m_SetChooseEffectBoolean_hotfix.call(new object[]
				{
					this,
					canChoose
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (GenericGraphic genericGraphic in this.m_graphics)
			{
				if (genericGraphic != null)
				{
					if (canChoose)
					{
						genericGraphic.SetEffect(GraphicEffect.Highlight_White, 0f, 0f);
					}
					else
					{
						genericGraphic.ClearEffect(GraphicEffect.Highlight_White);
					}
				}
			}
		}

		// Token: 0x0600AC57 RID: 44119 RVA: 0x002FE90C File Offset: 0x002FCB0C
		public bool IsGray()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsGray_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsGray_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_isGray;
		}

		// Token: 0x0600AC58 RID: 44120 RVA: 0x002FE980 File Offset: 0x002FCB80
		public void ForceUpdateSpine()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ForceUpdateSpine_hotfix != null)
			{
				this.m_ForceUpdateSpine_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			for (int i = 0; i < this.m_graphics.Length; i++)
			{
				if (this.m_graphics[i] != null)
				{
					this.m_graphics[i].ForceUpdateSpine();
				}
			}
		}

		// Token: 0x0600AC59 RID: 44121 RVA: 0x002FEA14 File Offset: 0x002FCC14
		public GridPosition GetPosition()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetPosition_hotfix != null)
			{
				return (GridPosition)this.m_GetPosition_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_position;
		}

		// Token: 0x0600AC5A RID: 44122 RVA: 0x002FEA88 File Offset: 0x002FCC88
		public int GetDirection()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetDirection_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetDirection_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_direction;
		}

		// Token: 0x0600AC5B RID: 44123 RVA: 0x002FEAFC File Offset: 0x002FCCFC
		public int GetTeam()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetTeam_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetTeam_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_team;
		}

		// Token: 0x0600AC5C RID: 44124 RVA: 0x002FEB70 File Offset: 0x002FCD70
		public int GetPlayerIndex()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetPlayerIndex_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetPlayerIndex_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_playerIndex;
		}

		// Token: 0x0600AC5D RID: 44125 RVA: 0x002FEBE4 File Offset: 0x002FCDE4
		public StageActorTagType GetTagType()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetTagType_hotfix != null)
			{
				return (StageActorTagType)this.m_GetTagType_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_tagType;
		}

		// Token: 0x0600AC5E RID: 44126 RVA: 0x002FEC58 File Offset: 0x002FCE58
		public StagePositionType GetPositionType()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetPositionType_hotfix != null)
			{
				return (StagePositionType)this.m_GetPositionType_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_stagePositionType;
		}

		// Token: 0x0600AC5F RID: 44127 RVA: 0x002FECCC File Offset: 0x002FCECC
		public int GetBehaviorId()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetBehaviorId_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetBehaviorId_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_behaviorId;
		}

		// Token: 0x0600AC60 RID: 44128 RVA: 0x002FED40 File Offset: 0x002FCF40
		public int GetGroupId()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetGroupId_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetGroupId_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_groupId;
		}

		// Token: 0x0600AC61 RID: 44129 RVA: 0x002FEDB4 File Offset: 0x002FCFB4
		public bool IsNpc()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsNpc_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsNpc_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_tagType == StageActorTagType.Npc;
		}

		// Token: 0x0600AC62 RID: 44130 RVA: 0x002FEE2C File Offset: 0x002FD02C
		public bool IsAINpc()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsAINpc_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsAINpc_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.IsNpc() && this.m_behaviorId >= 0;
		}

		// Token: 0x0600AC63 RID: 44131 RVA: 0x002FEEB4 File Offset: 0x002FD0B4
		public bool IsTeammate()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsTeammate_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsTeammate_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_stagePositionType == StagePositionType.Teammate;
		}

		// Token: 0x0600AC64 RID: 44132 RVA: 0x002FEF2C File Offset: 0x002FD12C
		public bool IsEnforce()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsEnforce_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsEnforce_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_tagType == StageActorTagType.Enforce;
		}

		// Token: 0x0600AC65 RID: 44133 RVA: 0x002FEFA4 File Offset: 0x002FD1A4
		public void TweenColor(Colori c)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TweenColorColori_hotfix != null)
			{
				this.m_TweenColorColori_hotfix.call(new object[]
				{
					this,
					c
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_tweenFromColor = this.m_tweenToColor;
			this.m_tweenToColor = c;
			this.m_tweenColorTime = 0.1f;
		}

		// Token: 0x0600AC66 RID: 44134 RVA: 0x002FF034 File Offset: 0x002FD234
		public BattleActorUIController GetUIController()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetUIController_hotfix != null)
			{
				return (BattleActorUIController)this.m_GetUIController_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_uiController;
		}

		// Token: 0x0600AC67 RID: 44135 RVA: 0x002FF0A8 File Offset: 0x002FD2A8
		public void TickGraphic(float dt)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TickGraphicSingle_hotfix != null)
			{
				this.m_TickGraphicSingle_hotfix.call(new object[]
				{
					this,
					dt
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Vector2 a = this.m_clientBattle.GridPositionToWorldPosition(this.m_position);
			int num = this.m_clientBattle.Battle.Map.Width / 2;
			int num2 = this.m_direction;
			if (num2 == 0)
			{
				num2 = ((this.m_position.x > num) ? -1 : 1);
			}
			for (int i = 0; i < this.m_graphics.Length; i++)
			{
				if (this.m_graphics[i] != null)
				{
					this.m_graphics[i].SetPosition(this.ComputeGraphicPosition(a + this.ComputeGraphicOffset(i, num2)));
					this.m_graphics[i].SetDirection(num2);
				}
			}
			if (this.m_tweenColorTime > 0f)
			{
				this.m_tweenColorTime -= dt;
				if (this.m_tweenColorTime < 0f)
				{
					this.m_tweenColorTime = 0f;
				}
				Colori color = Colori.Lerp(this.m_tweenToColor, this.m_tweenFromColor, this.m_tweenColorTime / 0.1f);
				foreach (GenericGraphic genericGraphic in this.m_graphics)
				{
					if (genericGraphic != null)
					{
						genericGraphic.SetColor(color);
					}
				}
			}
			foreach (GenericGraphic genericGraphic2 in this.m_graphics)
			{
				if (genericGraphic2 != null)
				{
					genericGraphic2.Tick(dt);
				}
			}
			if (this.m_uiController != null)
			{
				this.m_uiController.transform.localPosition = new Vector3(a.x, a.y, 0f);
			}
		}

		// Token: 0x0600AC68 RID: 44136 RVA: 0x002FF2C0 File Offset: 0x002FD4C0
		public void Pause(bool pause)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PauseBoolean_hotfix != null)
			{
				this.m_PauseBoolean_hotfix.call(new object[]
				{
					this,
					pause
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (GenericGraphic genericGraphic in this.m_graphics)
			{
				if (genericGraphic != null)
				{
					genericGraphic.Pause(pause);
				}
			}
		}

		// Token: 0x0600AC69 RID: 44137 RVA: 0x002FF35C File Offset: 0x002FD55C
		private Vector3 ComputeGraphicPosition(Vector2 p)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ComputeGraphicPositionVector2_hotfix != null)
			{
				return (Vector3)this.m_ComputeGraphicPositionVector2_hotfix.call(new object[]
				{
					this,
					p
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return new Vector3(p.x, p.y, p.y * 0.01f);
		}

		// Token: 0x0600AC6A RID: 44138 RVA: 0x002FF3F8 File Offset: 0x002FD5F8
		private Vector2 ComputeGraphicOffset(int idx, int dir)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ComputeGraphicOffsetInt32Int32_hotfix != null)
			{
				return (Vector2)this.m_ComputeGraphicOffsetInt32Int32_hotfix.call(new object[]
				{
					this,
					idx,
					dir
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			bool hasHeroAndSoldier = this.m_hero.HeroId != 0 && this.m_hero.SelectedSoldierId != 0;
			return ClientBattleActor.ComputeGraphicOffset(idx, dir, this.m_soldierCount, hasHeroAndSoldier);
		}

		// Token: 0x0600AC6B RID: 44139 RVA: 0x002FF4B8 File Offset: 0x002FD6B8
		private int ComputeSoldierGraphicCount(int soldierHp, int soldierHpMax)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ComputeSoldierGraphicCountInt32Int32_hotfix != null)
			{
				return Convert.ToInt32(this.m_ComputeSoldierGraphicCountInt32Int32_hotfix.call(new object[]
				{
					this,
					soldierHp,
					soldierHpMax
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int result = 0;
			if (soldierHp * 2 > soldierHpMax)
			{
				result = 2;
			}
			else if (soldierHp > 0)
			{
				result = 1;
			}
			return result;
		}

		// Token: 0x0600AC6C RID: 44140 RVA: 0x002FF560 File Offset: 0x002FD760
		private void UpdateGraphicVisible()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateGraphicVisible_hotfix != null)
			{
				this.m_UpdateGraphicVisible_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			for (int i = 0; i < this.m_graphics.Length; i++)
			{
				GenericGraphic genericGraphic = this.m_graphics[i];
				if (genericGraphic != null)
				{
					bool flag = i == 0 || i <= this.m_soldierCount;
					genericGraphic.SetVisible(flag);
					if (flag)
					{
						genericGraphic.ForceUpdateSpine();
					}
				}
			}
		}

		// Token: 0x17002305 RID: 8965
		// (get) Token: 0x0600AC6D RID: 44141 RVA: 0x002FF614 File Offset: 0x002FD814
		// (set) Token: 0x0600AC6E RID: 44142 RVA: 0x002FF634 File Offset: 0x002FD834
		[DoNotToLua]
		public BattlePrepareStageActor.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new BattlePrepareStageActor.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600AC6F RID: 44143 RVA: 0x002FF640 File Offset: 0x002FD840
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
					this.m_ctorClientBattle_hotfix = (luaObj.RawGet("ctor") as LuaFunction);
					this.m_Destroy_hotfix = (luaObj.RawGet("Destroy") as LuaFunction);
					this.m_DestroyGraphic_hotfix = (luaObj.RawGet("DestroyGraphic") as LuaFunction);
					this.m_DestroyUI_hotfix = (luaObj.RawGet("DestroyUI") as LuaFunction);
					this.m_SetupBattleHeroInt32StagePositionTypeStageActorTagTypeInt32Int32Int32Boolean_hotfix = (luaObj.RawGet("Setup") as LuaFunction);
					this.m_GetHero_hotfix = (luaObj.RawGet("GetHero") as LuaFunction);
					this.m_GetHeroId_hotfix = (luaObj.RawGet("GetHeroId") as LuaFunction);
					this.m_GetSoldierId_hotfix = (luaObj.RawGet("GetSoldierId") as LuaFunction);
					this.m_SetHpInt32Int32Int32Int32_hotfix = (luaObj.RawGet("SetHp") as LuaFunction);
					this.m_GetHeroHp_hotfix = (luaObj.RawGet("GetHeroHp") as LuaFunction);
					this.m_GetSoldierHp_hotfix = (luaObj.RawGet("GetSoldierHp") as LuaFunction);
					this.m_SetExtraTalentSkillInfoConfigDataSkillInfo_hotfix = (luaObj.RawGet("SetExtraTalentSkillInfo") as LuaFunction);
					this.m_GetExtraTalentSkillInfo_hotfix = (luaObj.RawGet("GetExtraTalentSkillInfo") as LuaFunction);
					this.m_PlayAnimationStringBoolean_hotfix = (luaObj.RawGet("PlayAnimation") as LuaFunction);
					this.m_SetPositionGridPositionInt32_hotfix = (luaObj.RawGet("SetPosition") as LuaFunction);
					this.m_SetGrayBoolean_hotfix = (luaObj.RawGet("SetGray") as LuaFunction);
					this.m_SetChooseEffectBoolean_hotfix = (luaObj.RawGet("SetChooseEffect") as LuaFunction);
					this.m_IsGray_hotfix = (luaObj.RawGet("IsGray") as LuaFunction);
					this.m_ForceUpdateSpine_hotfix = (luaObj.RawGet("ForceUpdateSpine") as LuaFunction);
					this.m_GetPosition_hotfix = (luaObj.RawGet("GetPosition") as LuaFunction);
					this.m_GetDirection_hotfix = (luaObj.RawGet("GetDirection") as LuaFunction);
					this.m_GetTeam_hotfix = (luaObj.RawGet("GetTeam") as LuaFunction);
					this.m_GetPlayerIndex_hotfix = (luaObj.RawGet("GetPlayerIndex") as LuaFunction);
					this.m_GetTagType_hotfix = (luaObj.RawGet("GetTagType") as LuaFunction);
					this.m_GetPositionType_hotfix = (luaObj.RawGet("GetPositionType") as LuaFunction);
					this.m_GetBehaviorId_hotfix = (luaObj.RawGet("GetBehaviorId") as LuaFunction);
					this.m_GetGroupId_hotfix = (luaObj.RawGet("GetGroupId") as LuaFunction);
					this.m_IsNpc_hotfix = (luaObj.RawGet("IsNpc") as LuaFunction);
					this.m_IsAINpc_hotfix = (luaObj.RawGet("IsAINpc") as LuaFunction);
					this.m_IsTeammate_hotfix = (luaObj.RawGet("IsTeammate") as LuaFunction);
					this.m_IsEnforce_hotfix = (luaObj.RawGet("IsEnforce") as LuaFunction);
					this.m_TweenColorColori_hotfix = (luaObj.RawGet("TweenColor") as LuaFunction);
					this.m_GetUIController_hotfix = (luaObj.RawGet("GetUIController") as LuaFunction);
					this.m_TickGraphicSingle_hotfix = (luaObj.RawGet("TickGraphic") as LuaFunction);
					this.m_PauseBoolean_hotfix = (luaObj.RawGet("Pause") as LuaFunction);
					this.m_ComputeGraphicPositionVector2_hotfix = (luaObj.RawGet("ComputeGraphicPosition") as LuaFunction);
					this.m_ComputeGraphicOffsetInt32Int32_hotfix = (luaObj.RawGet("ComputeGraphicOffset") as LuaFunction);
					this.m_ComputeSoldierGraphicCountInt32Int32_hotfix = (luaObj.RawGet("ComputeSoldierGraphicCount") as LuaFunction);
					this.m_UpdateGraphicVisible_hotfix = (luaObj.RawGet("UpdateGraphicVisible") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600AC70 RID: 44144 RVA: 0x002FFAC4 File Offset: 0x002FDCC4
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BattlePrepareStageActor));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040070C9 RID: 28873
		private GridPosition m_position;

		// Token: 0x040070CA RID: 28874
		private int m_direction;

		// Token: 0x040070CB RID: 28875
		private int m_team;

		// Token: 0x040070CC RID: 28876
		private int m_playerIndex;

		// Token: 0x040070CD RID: 28877
		private BattleHero m_hero;

		// Token: 0x040070CE RID: 28878
		private int m_behaviorId;

		// Token: 0x040070CF RID: 28879
		private int m_groupId;

		// Token: 0x040070D0 RID: 28880
		private StageActorTagType m_tagType;

		// Token: 0x040070D1 RID: 28881
		private StagePositionType m_stagePositionType;

		// Token: 0x040070D2 RID: 28882
		private bool m_isGray;

		// Token: 0x040070D3 RID: 28883
		private int m_heroHealthPoint = -1;

		// Token: 0x040070D4 RID: 28884
		private int m_soldierHealthPoint = -1;

		// Token: 0x040070D5 RID: 28885
		private ConfigDataSkillInfo m_extraTalentSkillInfo;

		// Token: 0x040070D6 RID: 28886
		private ClientBattle m_clientBattle;

		// Token: 0x040070D7 RID: 28887
		private GenericGraphic[] m_graphics = new GenericGraphic[3];

		// Token: 0x040070D8 RID: 28888
		private int m_soldierCount;

		// Token: 0x040070D9 RID: 28889
		private Colori m_tweenFromColor;

		// Token: 0x040070DA RID: 28890
		private Colori m_tweenToColor;

		// Token: 0x040070DB RID: 28891
		private float m_tweenColorTime;

		// Token: 0x040070DC RID: 28892
		private BattleActorUIController m_uiController;

		// Token: 0x040070DD RID: 28893
		[DoNotToLua]
		private BattlePrepareStageActor.LuaExportHelper luaExportHelper;

		// Token: 0x040070DE RID: 28894
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040070DF RID: 28895
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040070E0 RID: 28896
		private LuaFunction m_ctorClientBattle_hotfix;

		// Token: 0x040070E1 RID: 28897
		private LuaFunction m_Destroy_hotfix;

		// Token: 0x040070E2 RID: 28898
		private LuaFunction m_DestroyGraphic_hotfix;

		// Token: 0x040070E3 RID: 28899
		private LuaFunction m_DestroyUI_hotfix;

		// Token: 0x040070E4 RID: 28900
		private LuaFunction m_SetupBattleHeroInt32StagePositionTypeStageActorTagTypeInt32Int32Int32Boolean_hotfix;

		// Token: 0x040070E5 RID: 28901
		private LuaFunction m_GetHero_hotfix;

		// Token: 0x040070E6 RID: 28902
		private LuaFunction m_GetHeroId_hotfix;

		// Token: 0x040070E7 RID: 28903
		private LuaFunction m_GetSoldierId_hotfix;

		// Token: 0x040070E8 RID: 28904
		private LuaFunction m_SetHpInt32Int32Int32Int32_hotfix;

		// Token: 0x040070E9 RID: 28905
		private LuaFunction m_GetHeroHp_hotfix;

		// Token: 0x040070EA RID: 28906
		private LuaFunction m_GetSoldierHp_hotfix;

		// Token: 0x040070EB RID: 28907
		private LuaFunction m_SetExtraTalentSkillInfoConfigDataSkillInfo_hotfix;

		// Token: 0x040070EC RID: 28908
		private LuaFunction m_GetExtraTalentSkillInfo_hotfix;

		// Token: 0x040070ED RID: 28909
		private LuaFunction m_PlayAnimationStringBoolean_hotfix;

		// Token: 0x040070EE RID: 28910
		private LuaFunction m_SetPositionGridPositionInt32_hotfix;

		// Token: 0x040070EF RID: 28911
		private LuaFunction m_SetGrayBoolean_hotfix;

		// Token: 0x040070F0 RID: 28912
		private LuaFunction m_SetChooseEffectBoolean_hotfix;

		// Token: 0x040070F1 RID: 28913
		private LuaFunction m_IsGray_hotfix;

		// Token: 0x040070F2 RID: 28914
		private LuaFunction m_ForceUpdateSpine_hotfix;

		// Token: 0x040070F3 RID: 28915
		private LuaFunction m_GetPosition_hotfix;

		// Token: 0x040070F4 RID: 28916
		private LuaFunction m_GetDirection_hotfix;

		// Token: 0x040070F5 RID: 28917
		private LuaFunction m_GetTeam_hotfix;

		// Token: 0x040070F6 RID: 28918
		private LuaFunction m_GetPlayerIndex_hotfix;

		// Token: 0x040070F7 RID: 28919
		private LuaFunction m_GetTagType_hotfix;

		// Token: 0x040070F8 RID: 28920
		private LuaFunction m_GetPositionType_hotfix;

		// Token: 0x040070F9 RID: 28921
		private LuaFunction m_GetBehaviorId_hotfix;

		// Token: 0x040070FA RID: 28922
		private LuaFunction m_GetGroupId_hotfix;

		// Token: 0x040070FB RID: 28923
		private LuaFunction m_IsNpc_hotfix;

		// Token: 0x040070FC RID: 28924
		private LuaFunction m_IsAINpc_hotfix;

		// Token: 0x040070FD RID: 28925
		private LuaFunction m_IsTeammate_hotfix;

		// Token: 0x040070FE RID: 28926
		private LuaFunction m_IsEnforce_hotfix;

		// Token: 0x040070FF RID: 28927
		private LuaFunction m_TweenColorColori_hotfix;

		// Token: 0x04007100 RID: 28928
		private LuaFunction m_GetUIController_hotfix;

		// Token: 0x04007101 RID: 28929
		private LuaFunction m_TickGraphicSingle_hotfix;

		// Token: 0x04007102 RID: 28930
		private LuaFunction m_PauseBoolean_hotfix;

		// Token: 0x04007103 RID: 28931
		private LuaFunction m_ComputeGraphicPositionVector2_hotfix;

		// Token: 0x04007104 RID: 28932
		private LuaFunction m_ComputeGraphicOffsetInt32Int32_hotfix;

		// Token: 0x04007105 RID: 28933
		private LuaFunction m_ComputeSoldierGraphicCountInt32Int32_hotfix;

		// Token: 0x04007106 RID: 28934
		private LuaFunction m_UpdateGraphicVisible_hotfix;

		// Token: 0x02000A96 RID: 2710
		public class LuaExportHelper
		{
			// Token: 0x0600AC71 RID: 44145 RVA: 0x002FFB2C File Offset: 0x002FDD2C
			public LuaExportHelper(BattlePrepareStageActor owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x17002306 RID: 8966
			// (get) Token: 0x0600AC72 RID: 44146 RVA: 0x002FFB3C File Offset: 0x002FDD3C
			// (set) Token: 0x0600AC73 RID: 44147 RVA: 0x002FFB4C File Offset: 0x002FDD4C
			public GridPosition m_position
			{
				get
				{
					return this.m_owner.m_position;
				}
				set
				{
					this.m_owner.m_position = value;
				}
			}

			// Token: 0x17002307 RID: 8967
			// (get) Token: 0x0600AC74 RID: 44148 RVA: 0x002FFB5C File Offset: 0x002FDD5C
			// (set) Token: 0x0600AC75 RID: 44149 RVA: 0x002FFB6C File Offset: 0x002FDD6C
			public int m_direction
			{
				get
				{
					return this.m_owner.m_direction;
				}
				set
				{
					this.m_owner.m_direction = value;
				}
			}

			// Token: 0x17002308 RID: 8968
			// (get) Token: 0x0600AC76 RID: 44150 RVA: 0x002FFB7C File Offset: 0x002FDD7C
			// (set) Token: 0x0600AC77 RID: 44151 RVA: 0x002FFB8C File Offset: 0x002FDD8C
			public int m_team
			{
				get
				{
					return this.m_owner.m_team;
				}
				set
				{
					this.m_owner.m_team = value;
				}
			}

			// Token: 0x17002309 RID: 8969
			// (get) Token: 0x0600AC78 RID: 44152 RVA: 0x002FFB9C File Offset: 0x002FDD9C
			// (set) Token: 0x0600AC79 RID: 44153 RVA: 0x002FFBAC File Offset: 0x002FDDAC
			public int m_playerIndex
			{
				get
				{
					return this.m_owner.m_playerIndex;
				}
				set
				{
					this.m_owner.m_playerIndex = value;
				}
			}

			// Token: 0x1700230A RID: 8970
			// (get) Token: 0x0600AC7A RID: 44154 RVA: 0x002FFBBC File Offset: 0x002FDDBC
			// (set) Token: 0x0600AC7B RID: 44155 RVA: 0x002FFBCC File Offset: 0x002FDDCC
			public BattleHero m_hero
			{
				get
				{
					return this.m_owner.m_hero;
				}
				set
				{
					this.m_owner.m_hero = value;
				}
			}

			// Token: 0x1700230B RID: 8971
			// (get) Token: 0x0600AC7C RID: 44156 RVA: 0x002FFBDC File Offset: 0x002FDDDC
			// (set) Token: 0x0600AC7D RID: 44157 RVA: 0x002FFBEC File Offset: 0x002FDDEC
			public int m_behaviorId
			{
				get
				{
					return this.m_owner.m_behaviorId;
				}
				set
				{
					this.m_owner.m_behaviorId = value;
				}
			}

			// Token: 0x1700230C RID: 8972
			// (get) Token: 0x0600AC7E RID: 44158 RVA: 0x002FFBFC File Offset: 0x002FDDFC
			// (set) Token: 0x0600AC7F RID: 44159 RVA: 0x002FFC0C File Offset: 0x002FDE0C
			public int m_groupId
			{
				get
				{
					return this.m_owner.m_groupId;
				}
				set
				{
					this.m_owner.m_groupId = value;
				}
			}

			// Token: 0x1700230D RID: 8973
			// (get) Token: 0x0600AC80 RID: 44160 RVA: 0x002FFC1C File Offset: 0x002FDE1C
			// (set) Token: 0x0600AC81 RID: 44161 RVA: 0x002FFC2C File Offset: 0x002FDE2C
			public StageActorTagType m_tagType
			{
				get
				{
					return this.m_owner.m_tagType;
				}
				set
				{
					this.m_owner.m_tagType = value;
				}
			}

			// Token: 0x1700230E RID: 8974
			// (get) Token: 0x0600AC82 RID: 44162 RVA: 0x002FFC3C File Offset: 0x002FDE3C
			// (set) Token: 0x0600AC83 RID: 44163 RVA: 0x002FFC4C File Offset: 0x002FDE4C
			public StagePositionType m_stagePositionType
			{
				get
				{
					return this.m_owner.m_stagePositionType;
				}
				set
				{
					this.m_owner.m_stagePositionType = value;
				}
			}

			// Token: 0x1700230F RID: 8975
			// (get) Token: 0x0600AC84 RID: 44164 RVA: 0x002FFC5C File Offset: 0x002FDE5C
			// (set) Token: 0x0600AC85 RID: 44165 RVA: 0x002FFC6C File Offset: 0x002FDE6C
			public bool m_isGray
			{
				get
				{
					return this.m_owner.m_isGray;
				}
				set
				{
					this.m_owner.m_isGray = value;
				}
			}

			// Token: 0x17002310 RID: 8976
			// (get) Token: 0x0600AC86 RID: 44166 RVA: 0x002FFC7C File Offset: 0x002FDE7C
			// (set) Token: 0x0600AC87 RID: 44167 RVA: 0x002FFC8C File Offset: 0x002FDE8C
			public int m_heroHealthPoint
			{
				get
				{
					return this.m_owner.m_heroHealthPoint;
				}
				set
				{
					this.m_owner.m_heroHealthPoint = value;
				}
			}

			// Token: 0x17002311 RID: 8977
			// (get) Token: 0x0600AC88 RID: 44168 RVA: 0x002FFC9C File Offset: 0x002FDE9C
			// (set) Token: 0x0600AC89 RID: 44169 RVA: 0x002FFCAC File Offset: 0x002FDEAC
			public int m_soldierHealthPoint
			{
				get
				{
					return this.m_owner.m_soldierHealthPoint;
				}
				set
				{
					this.m_owner.m_soldierHealthPoint = value;
				}
			}

			// Token: 0x17002312 RID: 8978
			// (get) Token: 0x0600AC8A RID: 44170 RVA: 0x002FFCBC File Offset: 0x002FDEBC
			// (set) Token: 0x0600AC8B RID: 44171 RVA: 0x002FFCCC File Offset: 0x002FDECC
			public ConfigDataSkillInfo m_extraTalentSkillInfo
			{
				get
				{
					return this.m_owner.m_extraTalentSkillInfo;
				}
				set
				{
					this.m_owner.m_extraTalentSkillInfo = value;
				}
			}

			// Token: 0x17002313 RID: 8979
			// (get) Token: 0x0600AC8C RID: 44172 RVA: 0x002FFCDC File Offset: 0x002FDEDC
			// (set) Token: 0x0600AC8D RID: 44173 RVA: 0x002FFCEC File Offset: 0x002FDEEC
			public ClientBattle m_clientBattle
			{
				get
				{
					return this.m_owner.m_clientBattle;
				}
				set
				{
					this.m_owner.m_clientBattle = value;
				}
			}

			// Token: 0x17002314 RID: 8980
			// (get) Token: 0x0600AC8E RID: 44174 RVA: 0x002FFCFC File Offset: 0x002FDEFC
			// (set) Token: 0x0600AC8F RID: 44175 RVA: 0x002FFD0C File Offset: 0x002FDF0C
			public GenericGraphic[] m_graphics
			{
				get
				{
					return this.m_owner.m_graphics;
				}
				set
				{
					this.m_owner.m_graphics = value;
				}
			}

			// Token: 0x17002315 RID: 8981
			// (get) Token: 0x0600AC90 RID: 44176 RVA: 0x002FFD1C File Offset: 0x002FDF1C
			// (set) Token: 0x0600AC91 RID: 44177 RVA: 0x002FFD2C File Offset: 0x002FDF2C
			public int m_soldierCount
			{
				get
				{
					return this.m_owner.m_soldierCount;
				}
				set
				{
					this.m_owner.m_soldierCount = value;
				}
			}

			// Token: 0x17002316 RID: 8982
			// (get) Token: 0x0600AC92 RID: 44178 RVA: 0x002FFD3C File Offset: 0x002FDF3C
			// (set) Token: 0x0600AC93 RID: 44179 RVA: 0x002FFD4C File Offset: 0x002FDF4C
			public Colori m_tweenFromColor
			{
				get
				{
					return this.m_owner.m_tweenFromColor;
				}
				set
				{
					this.m_owner.m_tweenFromColor = value;
				}
			}

			// Token: 0x17002317 RID: 8983
			// (get) Token: 0x0600AC94 RID: 44180 RVA: 0x002FFD5C File Offset: 0x002FDF5C
			// (set) Token: 0x0600AC95 RID: 44181 RVA: 0x002FFD6C File Offset: 0x002FDF6C
			public Colori m_tweenToColor
			{
				get
				{
					return this.m_owner.m_tweenToColor;
				}
				set
				{
					this.m_owner.m_tweenToColor = value;
				}
			}

			// Token: 0x17002318 RID: 8984
			// (get) Token: 0x0600AC96 RID: 44182 RVA: 0x002FFD7C File Offset: 0x002FDF7C
			// (set) Token: 0x0600AC97 RID: 44183 RVA: 0x002FFD8C File Offset: 0x002FDF8C
			public float m_tweenColorTime
			{
				get
				{
					return this.m_owner.m_tweenColorTime;
				}
				set
				{
					this.m_owner.m_tweenColorTime = value;
				}
			}

			// Token: 0x17002319 RID: 8985
			// (get) Token: 0x0600AC98 RID: 44184 RVA: 0x002FFD9C File Offset: 0x002FDF9C
			// (set) Token: 0x0600AC99 RID: 44185 RVA: 0x002FFDAC File Offset: 0x002FDFAC
			public BattleActorUIController m_uiController
			{
				get
				{
					return this.m_owner.m_uiController;
				}
				set
				{
					this.m_owner.m_uiController = value;
				}
			}

			// Token: 0x0600AC9A RID: 44186 RVA: 0x002FFDBC File Offset: 0x002FDFBC
			public void DestroyGraphic()
			{
				this.m_owner.DestroyGraphic();
			}

			// Token: 0x0600AC9B RID: 44187 RVA: 0x002FFDCC File Offset: 0x002FDFCC
			public void DestroyUI()
			{
				this.m_owner.DestroyUI();
			}

			// Token: 0x0600AC9C RID: 44188 RVA: 0x002FFDDC File Offset: 0x002FDFDC
			public void PlayAnimation(string name, bool loop)
			{
				this.m_owner.PlayAnimation(name, loop);
			}

			// Token: 0x0600AC9D RID: 44189 RVA: 0x002FFDEC File Offset: 0x002FDFEC
			public Vector3 ComputeGraphicPosition(Vector2 p)
			{
				return this.m_owner.ComputeGraphicPosition(p);
			}

			// Token: 0x0600AC9E RID: 44190 RVA: 0x002FFDFC File Offset: 0x002FDFFC
			public Vector2 ComputeGraphicOffset(int idx, int dir)
			{
				return this.m_owner.ComputeGraphicOffset(idx, dir);
			}

			// Token: 0x0600AC9F RID: 44191 RVA: 0x002FFE0C File Offset: 0x002FE00C
			public int ComputeSoldierGraphicCount(int soldierHp, int soldierHpMax)
			{
				return this.m_owner.ComputeSoldierGraphicCount(soldierHp, soldierHpMax);
			}

			// Token: 0x0600ACA0 RID: 44192 RVA: 0x002FFE1C File Offset: 0x002FE01C
			public void UpdateGraphicVisible()
			{
				this.m_owner.UpdateGraphicVisible();
			}

			// Token: 0x04007107 RID: 28935
			private BattlePrepareStageActor m_owner;
		}
	}
}
