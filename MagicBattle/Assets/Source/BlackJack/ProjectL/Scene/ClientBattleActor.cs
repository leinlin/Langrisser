using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Battle;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Misc;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;

namespace BlackJack.ProjectL.Scene
{
	// Token: 0x0200092A RID: 2346
	[HotFix]
	public class ClientBattleActor : Entity
	{
		// Token: 0x06008869 RID: 34921 RVA: 0x00279348 File Offset: 0x00277548
		public ClientBattleActor()
		{
			this.m_graphicStates = new ClientBattleActor.GraphicState[3];
			for (int i = 0; i < this.m_graphicStates.Length; i++)
			{
				this.m_graphicStates[i] = new ClientBattleActor.GraphicState();
			}
			this.m_buffs = new List<ClientActorBuff>();
			this.m_attachFxs = new List<GenericGraphic>();
			this.m_isVisible = true;
			this.m_isTeleportDisappear = false;
			this.m_idleAnimationName = "idle";
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ctor_hotfix != null)
			{
				this.m_ctor_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x0600886A RID: 34922 RVA: 0x00279410 File Offset: 0x00277610
		public void Initialize(ClientBattle battle, BattleActor actor)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitializeClientBattleBattleActor_hotfix != null)
			{
				this.m_InitializeClientBattleBattleActor_hotfix.call(new object[]
				{
					this,
					battle,
					actor
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_clientBattle = battle;
			this.m_battleActor = actor;
			this.m_id = battle.GetNextEntityId();
			this.m_deleteMeCountdown = 0;
			this.m_acts = new List<ClientActorAct>();
			this.m_heroHealthPoint = actor.HeroHealthPoint;
			this.m_soldierTotalHealthPoint = actor.SoldierTotalHealthPoint;
			this.m_heroHealthPointMax = actor.HeroBattleProperty.HealthPointMax;
			this.m_soldierTotalHealthPointMax = actor.SoldierBattleProperty.HealthPointMax;
			this.m_fightTags = actor.FightTags;
			for (int i = 0; i < this.m_graphicStates.Length; i++)
			{
				this.m_graphicStates[i].m_graphic = null;
				this.m_graphicStates[i].m_hideCountdown = 0f;
			}
			if (actor.HeroInfo != null)
			{
				this.CreateHeroGraphic();
			}
			if (actor.SoldierInfo != null)
			{
				this.CreateSoldierGraphics();
			}
			if (actor.Team != null)
			{
				GameObject go = UnityEngine.Object.Instantiate<GameObject>(battle.BattleActorUIPrefab, battle.BattleActorUIRoot.transform, false);
				this.m_uiController = GameObjectUtility.AddControllerToGameObject<BattleActorUIController>(go);
				this.m_uiController.SetArmyInfo(actor.HeroArmyInfo);
				this.m_uiController.SetPlayerIndex(actor.PlayerIndex);
				bool flag = false;
				if (this.TeamNumber == this.m_clientBattle.GetMyPlayerTeamNumber() && this.m_clientBattle.IsTeamBattle())
				{
					flag = (actor.PlayerIndex >= 0 && actor.PlayerIndex != this.m_clientBattle.GetMyPlayerIndex());
				}
				this.SetHpBarType(this.TeamNumber, actor.IsAINpc() || flag);
			}
			this.m_isVisible = true;
			this.m_idleAnimationName = "idle";
			this.m_isGraphicSkillFade = false;
			this.m_isActionFinishedGray = false;
			this.m_isGuarding = false;
		}

		// Token: 0x0600886B RID: 34923 RVA: 0x00279640 File Offset: 0x00277840
		public void InitializeEnd()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitializeEnd_hotfix != null)
			{
				this.m_InitializeEnd_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_heroHealthPoint = this.m_battleActor.HeroHealthPoint;
			this.m_soldierTotalHealthPoint = this.m_battleActor.SoldierTotalHealthPoint;
			this.m_heroHealthPointMax = this.m_battleActor.HeroBattleProperty.HealthPointMax;
			this.m_soldierTotalHealthPointMax = this.m_battleActor.SoldierBattleProperty.HealthPointMax;
			this.m_fightTags = this.m_battleActor.FightTags;
			this.UpdateHpAndBuffUI();
			this.m_soldierGraphicCount = this.ComputeSoldierGraphicCount();
			this.UpdateGraphicVisible();
			this.PlayIdleAnimation();
			this.Locate(this.m_position, this.m_direction);
		}

		// Token: 0x0600886C RID: 34924 RVA: 0x00279730 File Offset: 0x00277930
		public void PostRebuildBattle()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PostRebuildBattle_hotfix != null)
			{
				this.m_PostRebuildBattle_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.UpdateHpAndBuffUI();
			this.UpdateGraphicVisible();
			this.PlayIdleAnimation();
			this.Locate(this.m_position, this.m_direction);
		}

		// Token: 0x0600886D RID: 34925 RVA: 0x002797B4 File Offset: 0x002779B4
		private void CreateHeroGraphic()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CreateHeroGraphic_hotfix != null)
			{
				this.m_CreateHeroGraphic_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BattleActor battleActor = this.m_battleActor;
			if (battleActor.HeroInfo == null)
			{
				return;
			}
			string text = string.Empty;
			if (battleActor.HeroModelSkinResourceInfo != null)
			{
				text = battleActor.HeroModelSkinResourceInfo.Model;
			}
			if (string.IsNullOrEmpty(text))
			{
				text = battleActor.JobConnectionInfo.Model;
			}
			float scale = (float)battleActor.JobConnectionInfo.BF_ModelScale * 0.01f;
			GenericGraphic genericGraphic = this.m_graphicStates[0].m_graphic = this.m_clientBattle.CreateBattleGraphic(text, scale);
			if (genericGraphic != null)
			{
				float height = (float)battleActor.JobConnectionInfo.Height * 0.01732f;
				float footHeight = (float)battleActor.JobConnectionInfo.FootHeight * 0.01732f * 0.25f;
				genericGraphic.SetHeight(height, footHeight);
				genericGraphic.SetName("Hero_" + this.m_id);
				genericGraphic.SetReplaceAnimations(battleActor.JobConnectionInfo.ReplaceAnims);
				AssetUtility.Instance.AddAssetToLruCache((this.TeamNumber != 0) ? 2 : 1, text);
			}
		}

		// Token: 0x0600886E RID: 34926 RVA: 0x00279918 File Offset: 0x00277B18
		private void CreateSoldierGraphics()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CreateSoldierGraphics_hotfix != null)
			{
				this.m_CreateSoldierGraphics_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BattleActor battleActor = this.m_battleActor;
			if (battleActor.SoldierInfo == null)
			{
				return;
			}
			string text = string.Empty;
			if (battleActor.SoldierModelSkinResourceInfo != null)
			{
				text = battleActor.SoldierModelSkinResourceInfo.Model;
			}
			if (string.IsNullOrEmpty(text))
			{
				if (this.TeamNumber == this.m_clientBattle.GetMyPlayerTeamNumber())
				{
					text = battleActor.SoldierInfo.Model;
				}
				else
				{
					text = battleActor.SoldierInfo.Model2;
				}
			}
			int i = 0;
			while (i < 2)
			{
				ClientBattleActor.GraphicState graphicState = this.m_graphicStates[i + 1];
				if (graphicState.m_graphic == null)
				{
					goto IL_111;
				}
				if (!(graphicState.m_graphic.AssetName == text))
				{
					this.m_clientBattle.DestroyBattleGraphic(graphicState.m_graphic);
					graphicState.m_graphic = null;
					goto IL_111;
				}
				IL_1F3:
				i++;
				continue;
				IL_111:
				float scale = (float)battleActor.SoldierInfo.BF_ModelScale * 0.01f;
				GenericGraphic genericGraphic = graphicState.m_graphic = this.m_clientBattle.CreateBattleGraphic(text, scale);
				if (genericGraphic != null)
				{
					float height = (float)battleActor.SoldierInfo.Height * 0.01732f;
					float footHeight = (float)battleActor.SoldierInfo.FootHeight * 0.01732f * 0.25f;
					genericGraphic.SetHeight(height, footHeight);
					genericGraphic.SetName(string.Concat(new object[]
					{
						"Soldier",
						i,
						"_",
						this.m_id
					}));
					genericGraphic.SetReplaceAnimations(battleActor.SoldierInfo.ReplaceAnims);
					AssetUtility.Instance.AddAssetToLruCache((this.TeamNumber != this.m_clientBattle.GetMyPlayerTeamNumber()) ? 4 : 3, text);
					goto IL_1F3;
				}
				goto IL_1F3;
			}
		}

		// Token: 0x0600886F RID: 34927 RVA: 0x00279B24 File Offset: 0x00277D24
		public override void Dispose()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Dispose_hotfix != null)
			{
				this.m_Dispose_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (ClientBattleActor.GraphicState graphicState in this.m_graphicStates)
			{
				if (graphicState.m_graphic != null)
				{
					this.m_clientBattle.DestroyBattleGraphic(graphicState.m_graphic);
					graphicState.m_graphic = null;
				}
			}
			if (this.m_uiController != null)
			{
				UnityEngine.Object.Destroy(this.m_uiController.gameObject);
				this.m_uiController = null;
			}
			this.m_buffs.Clear();
			this.ClearAttachFx();
			this.m_acts.Clear();
		}

		// Token: 0x06008870 RID: 34928 RVA: 0x00279C0C File Offset: 0x00277E0C
		public override void Tick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Tick_hotfix != null)
			{
				this.m_Tick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			bool flag = false;
			int step = 0;
			while (this.m_acts.Count > 0 && !this.TickAct(this.m_acts[0]))
			{
				step = this.m_acts[0].m_step;
				this.m_acts.RemoveAt(0);
				this.m_actFrame = 0;
				flag = true;
			}
			if (flag && this.m_acts.Count <= 0 && !this.IsDead() && !this.m_clientBattle.HasWaitingAct(this.m_battleActor, step))
			{
				this.PlayIdleAnimation();
				this.m_clientBattle.ClientBattleListener.OnClientActorNoAct(this);
			}
			if (this.m_deleteMeCountdown > 0)
			{
				this.m_deleteMeCountdown--;
				if (this.m_deleteMeCountdown <= 0)
				{
					base.DeleteMe();
				}
			}
		}

		// Token: 0x06008871 RID: 34929 RVA: 0x00279D40 File Offset: 0x00277F40
		public override void TickGraphic(float dt)
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
			if (this.m_clientBattle.IsRebuildingBattle())
			{
				return;
			}
			float maxDistanceDelta = (float)this.m_clientBattle.ConfigDataLoader.Const_BattleActorMoveSpeed * dt;
			Vector2 vector = this.m_clientBattle.GridPositionToWorldPosition(this.m_position);
			this.m_graphicPosition = Vector2.MoveTowards(this.m_graphicPosition, vector, maxDistanceDelta);
			for (int i = 0; i < this.m_graphicStates.Length; i++)
			{
				ClientBattleActor.GraphicState graphicState = this.m_graphicStates[i];
				GenericGraphic graphic = graphicState.m_graphic;
				if (graphic != null)
				{
					if (graphicState.m_hideCountdown > 0f)
					{
						graphicState.m_hideCountdown -= dt;
						if (graphicState.m_hideCountdown <= 0f)
						{
							graphicState.m_hideCountdown = -1f;
							graphic.SetVisible(false);
						}
					}
					Vector2 p = Vector2.MoveTowards(graphic.GetPosition(), vector + this.ComputeGraphicOffset(i), maxDistanceDelta);
					graphic.SetPosition(this.ComputeGraphicPosition(p, 0f));
					graphic.SetDirection(this.m_direction);
					graphic.Tick(dt);
				}
			}
			Vector3 position = this.ComputeGraphicPosition(this.m_graphicPosition, -20f);
			foreach (ClientActorBuff clientActorBuff in this.m_buffs)
			{
				if (clientActorBuff.m_fx != null)
				{
					clientActorBuff.m_fx.SetPosition(position);
				}
			}
			if (this.m_attachFxs != null)
			{
				int j = 0;
				while (j < this.m_attachFxs.Count)
				{
					GenericGraphic genericGraphic = this.m_attachFxs[j];
					if (genericGraphic.IsFxLifeEnd())
					{
						this.m_attachFxs.RemoveAt(j);
						genericGraphic.DeleteMe();
					}
					else
					{
						genericGraphic.SetPosition(position);
						j++;
					}
				}
			}
			if (this.m_uiController != null)
			{
				this.m_uiController.gameObject.SetActive(this.m_isVisible && !this.m_isGraphicSkillFade);
				this.m_uiController.transform.localPosition = new Vector3(this.m_graphicPosition.x, this.m_graphicPosition.y, 0f);
			}
		}

		// Token: 0x06008872 RID: 34930 RVA: 0x0027A000 File Offset: 0x00278200
		private Vector3 ComputeGraphicPosition(Vector2 p, float zoffset)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ComputeGraphicPositionVector2Single_hotfix != null)
			{
				return (Vector3)this.m_ComputeGraphicPositionVector2Single_hotfix.call(new object[]
				{
					this,
					p,
					zoffset
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_isGraphicSkillFade)
			{
				zoffset += 30f;
			}
			if (this.m_isGuarding)
			{
				zoffset += -1f;
			}
			return new Vector3(p.x, p.y, p.y * 0.01f + zoffset);
		}

		// Token: 0x06008873 RID: 34931 RVA: 0x0027A0D8 File Offset: 0x002782D8
		public override void Draw()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Draw_hotfix != null)
			{
				this.m_Draw_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_graphicStates[0].m_graphic != null)
			{
				float num = (float)this.m_battleActor.JobConnectionInfo.Height * 0.01732f;
				float num2 = (float)this.m_battleActor.JobConnectionInfo.FootHeight * 0.01732f * 0.25f;
				Vector3 position = this.m_graphicStates[0].m_graphic.GetPosition();
				global::Debug.DrawLine(position + new Vector3(0f, num2, 0f), position + new Vector3(0f, num + num2, 0f), Color.gray);
			}
		}

		// Token: 0x06008874 RID: 34932 RVA: 0x0027A1CC File Offset: 0x002783CC
		public override void DoPause(bool pause)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DoPauseBoolean_hotfix != null)
			{
				this.m_DoPauseBoolean_hotfix.call(new object[]
				{
					this,
					pause
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (ClientBattleActor.GraphicState graphicState in this.m_graphicStates)
			{
				if (graphicState.m_graphic != null)
				{
					graphicState.m_graphic.Pause(pause);
				}
			}
		}

		// Token: 0x06008875 RID: 34933 RVA: 0x0027A274 File Offset: 0x00278474
		public bool IsDead()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsDead_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsDead_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_heroHealthPoint <= 0;
		}

		// Token: 0x06008876 RID: 34934 RVA: 0x0027A2EC File Offset: 0x002784EC
		public int GetTotalHealthPoint()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetTotalHealthPoint_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetTotalHealthPoint_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_heroHealthPoint + this.m_soldierTotalHealthPoint;
		}

		// Token: 0x06008877 RID: 34935 RVA: 0x0027A368 File Offset: 0x00278568
		public int GetTotalHealthPointMax()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetTotalHealthPointMax_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetTotalHealthPointMax_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_heroHealthPointMax + this.m_soldierTotalHealthPointMax;
		}

		// Token: 0x06008878 RID: 34936 RVA: 0x0027A3E4 File Offset: 0x002785E4
		private bool HasFightTag(FightTag ft)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HasFightTagFightTag_hotfix != null)
			{
				return Convert.ToBoolean(this.m_HasFightTagFightTag_hotfix.call(new object[]
				{
					this,
					ft
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return MathUtility.GetBit(this.m_fightTags, (int)ft);
		}

		// Token: 0x06008879 RID: 34937 RVA: 0x0027A46C File Offset: 0x0027866C
		public void Locate(GridPosition p, int dir)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_LocateGridPositionInt32_hotfix != null)
			{
				this.m_LocateGridPositionInt32_hotfix.call(new object[]
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
			if (this.m_clientBattle.IsRebuildingBattle())
			{
				return;
			}
			this.m_graphicPosition = this.m_clientBattle.GridPositionToWorldPosition(p);
			for (int i = 0; i < this.m_graphicStates.Length; i++)
			{
				GenericGraphic graphic = this.m_graphicStates[i].m_graphic;
				if (graphic != null)
				{
					graphic.SetPosition(this.ComputeGraphicPosition(this.m_graphicPosition + this.ComputeGraphicOffset(i), 0f));
					graphic.SetDirection(this.m_direction);
					graphic.ForceUpdateSpine();
				}
			}
			this.TickGraphic(0f);
		}

		// Token: 0x0600887A RID: 34938 RVA: 0x0027A58C File Offset: 0x0027878C
		private void FaceTo(GridPosition p)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FaceToGridPosition_hotfix != null)
			{
				this.m_FaceToGridPosition_hotfix.call(new object[]
				{
					this,
					p
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (p == this.m_position)
			{
				return;
			}
			int num = p.x - this.m_position.x;
			if (num > 0)
			{
				this.m_direction = 1;
			}
			else if (num < 0)
			{
				this.m_direction = -1;
			}
		}

		// Token: 0x0600887B RID: 34939 RVA: 0x0027A644 File Offset: 0x00278844
		public void AddAct(ClientActorAct act)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddActClientActorAct_hotfix != null)
			{
				this.m_AddActClientActorAct_hotfix.call(new object[]
				{
					this,
					act
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_acts.Add(act);
		}

		// Token: 0x0600887C RID: 34940 RVA: 0x0027A6C0 File Offset: 0x002788C0
		public bool HasAct()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HasAct_hotfix != null)
			{
				return Convert.ToBoolean(this.m_HasAct_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_acts.Count > 0;
		}

		// Token: 0x0600887D RID: 34941 RVA: 0x0027A73C File Offset: 0x0027893C
		private void PlayAnimation(string name, bool loop, bool onAll)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayAnimationStringBooleanBoolean_hotfix != null)
			{
				this.m_PlayAnimationStringBooleanBoolean_hotfix.call(new object[]
				{
					this,
					name,
					loop,
					onAll
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (string.IsNullOrEmpty(name))
			{
				return;
			}
			if (this.m_clientBattle.IsRebuildingBattle())
			{
				return;
			}
			foreach (ClientBattleActor.GraphicState graphicState in this.m_graphicStates)
			{
				GenericGraphic graphic = graphicState.m_graphic;
				if (graphic != null && graphicState.m_hideCountdown == 0f)
				{
					graphic.PlayAnimation(name, loop);
					if (!onAll)
					{
						break;
					}
				}
			}
		}

		// Token: 0x0600887E RID: 34942 RVA: 0x0027A838 File Offset: 0x00278A38
		private int GetHeroAnimationDuration(string name)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetHeroAnimationDurationString_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetHeroAnimationDurationString_hotfix.call(new object[]
				{
					this,
					name
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (string.IsNullOrEmpty(name))
			{
				return 0;
			}
			if (this.m_graphicStates[0].m_graphic != null)
			{
				return (int)(this.m_graphicStates[0].m_graphic.GetAnimationDuration(name) * 1000f);
			}
			return 0;
		}

		// Token: 0x0600887F RID: 34943 RVA: 0x0027A8F0 File Offset: 0x00278AF0
		private bool IsHeroPlayAnimation()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsHeroPlayAnimation_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsHeroPlayAnimation_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_graphicStates[0].m_graphic != null && this.m_graphicStates[0].m_graphic.IsPlayAnimation(0);
		}

		// Token: 0x06008880 RID: 34944 RVA: 0x0027A984 File Offset: 0x00278B84
		private void PlayDeathFx(int deathType)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayDeathFxInt32_hotfix != null)
			{
				this.m_PlayDeathFxInt32_hotfix.call(new object[]
				{
					this,
					deathType
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_clientBattle.IsRebuildingBattle())
			{
				return;
			}
			foreach (ClientBattleActor.GraphicState graphicState in this.m_graphicStates)
			{
				GenericGraphic graphic = graphicState.m_graphic;
				if (graphic != null && graphic.IsVisible() && graphicState.m_hideCountdown == 0f)
				{
					graphic.PlayFx("FX/Common_ABS/CommonFX/common_die.prefab", 0);
				}
			}
		}

		// Token: 0x06008881 RID: 34945 RVA: 0x0027AA58 File Offset: 0x00278C58
		private void PlayIdleAnimation()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayIdleAnimation_hotfix != null)
			{
				this.m_PlayIdleAnimation_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.HasFightTag(FightTag.FightTag_Stun))
			{
				this.PlayAnimation("stun", true, true);
			}
			else if (this.m_isIdleRun)
			{
				this.PlayAnimation("run", true, true);
			}
			else
			{
				this.PlayAnimation(this.m_idleAnimationName, true, true);
			}
		}

		// Token: 0x06008882 RID: 34946 RVA: 0x0027AB04 File Offset: 0x00278D04
		private void PlayHeroFx(string name)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayHeroFxString_hotfix != null)
			{
				this.m_PlayHeroFxString_hotfix.call(new object[]
				{
					this,
					name
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (string.IsNullOrEmpty(name))
			{
				return;
			}
			if (this.m_clientBattle.IsRebuildingBattle())
			{
				return;
			}
			ClientBattleActor.GraphicState graphicState = this.m_graphicStates[0];
			if (graphicState.m_hideCountdown == 0f && graphicState.m_graphic != null && graphicState.m_graphic.IsVisible())
			{
				graphicState.m_graphic.PlayFx(name, 0);
			}
		}

		// Token: 0x06008883 RID: 34947 RVA: 0x0027ABD4 File Offset: 0x00278DD4
		private void PlayFx(string name, GridPosition p)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayFxStringGridPosition_hotfix != null)
			{
				this.m_PlayFxStringGridPosition_hotfix.call(new object[]
				{
					this,
					name,
					p
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (string.IsNullOrEmpty(name))
			{
				return;
			}
			if (this.m_clientBattle.IsRebuildingBattle())
			{
				return;
			}
			GenericGraphic genericGraphic = this.m_clientBattle.BattleFxPlayer.Play(name);
			if (genericGraphic != null)
			{
				Vector2 p2 = this.m_clientBattle.GridPositionToWorldPosition(p);
				genericGraphic.SetPosition(this.ComputeGraphicPosition(p2, -20f));
				genericGraphic.AutoDelete(true);
				AssetUtility.Instance.AddAssetToLruCache(5, name);
			}
		}

		// Token: 0x06008884 RID: 34948 RVA: 0x0027ACBC File Offset: 0x00278EBC
		private void PlayAttachFx(string name)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayAttachFxString_hotfix != null)
			{
				this.m_PlayAttachFxString_hotfix.call(new object[]
				{
					this,
					name
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (string.IsNullOrEmpty(name))
			{
				return;
			}
			if (this.m_clientBattle.IsRebuildingBattle())
			{
				return;
			}
			GenericGraphic genericGraphic = this.m_clientBattle.BattleFxPlayer.Play(name);
			if (genericGraphic != null)
			{
				Vector2 p = this.m_clientBattle.GridPositionToWorldPosition(this.m_position);
				genericGraphic.SetPosition(this.ComputeGraphicPosition(p, -20f));
				genericGraphic.AutoDelete(false);
				this.m_attachFxs.Add(genericGraphic);
				AssetUtility.Instance.AddAssetToLruCache(5, name);
			}
		}

		// Token: 0x06008885 RID: 34949 RVA: 0x0027ADA4 File Offset: 0x00278FA4
		public void ClearAttachFx()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ClearAttachFx_hotfix != null)
			{
				this.m_ClearAttachFx_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (GenericGraphic genericGraphic in this.m_attachFxs)
			{
				genericGraphic.DeleteMe();
			}
			this.m_attachFxs.Clear();
		}

		// Token: 0x06008886 RID: 34950 RVA: 0x0027AE60 File Offset: 0x00279060
		public void SetGraphicEffect(GraphicEffect e, float param1 = 0f, float param2 = 0f)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetGraphicEffectGraphicEffectSingleSingle_hotfix != null)
			{
				this.m_SetGraphicEffectGraphicEffectSingleSingle_hotfix.call(new object[]
				{
					this,
					e,
					param1,
					param2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_clientBattle.IsRebuildingBattle())
			{
				return;
			}
			foreach (ClientBattleActor.GraphicState graphicState in this.m_graphicStates)
			{
				GenericGraphic graphic = graphicState.m_graphic;
				if (graphic != null && graphicState.m_hideCountdown == 0f)
				{
					graphic.SetEffect(e, param1, param2);
				}
			}
		}

		// Token: 0x06008887 RID: 34951 RVA: 0x0027AF48 File Offset: 0x00279148
		public void ClearGraphicEffect(GraphicEffect e)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ClearGraphicEffectGraphicEffect_hotfix != null)
			{
				this.m_ClearGraphicEffectGraphicEffect_hotfix.call(new object[]
				{
					this,
					e
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (ClientBattleActor.GraphicState graphicState in this.m_graphicStates)
			{
				GenericGraphic graphic = graphicState.m_graphic;
				if (graphic != null && graphicState.m_hideCountdown == 0f)
				{
					graphic.ClearEffect(e);
				}
			}
		}

		// Token: 0x06008888 RID: 34952 RVA: 0x0027AFFC File Offset: 0x002791FC
		private void PlaySound(string name)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlaySoundString_hotfix != null)
			{
				this.m_PlaySoundString_hotfix.call(new object[]
				{
					this,
					name
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (string.IsNullOrEmpty(name))
			{
				return;
			}
			if (this.m_clientBattle.IsRebuildingBattle())
			{
				return;
			}
			this.m_clientBattle.PlaySound(name);
		}

		// Token: 0x06008889 RID: 34953 RVA: 0x0027B098 File Offset: 0x00279298
		private void PlaySound(SoundTableId id)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlaySoundSoundTableId_hotfix != null)
			{
				this.m_PlaySoundSoundTableId_hotfix.call(new object[]
				{
					this,
					id
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_clientBattle.IsRebuildingBattle())
			{
				return;
			}
			this.m_clientBattle.PlaySound(id);
		}

		// Token: 0x0600888A RID: 34954 RVA: 0x0027B128 File Offset: 0x00279328
		public void SetGraphicActionFinishedEffect(bool finished)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetGraphicActionFinishedEffectBoolean_hotfix != null)
			{
				this.m_SetGraphicActionFinishedEffectBoolean_hotfix.call(new object[]
				{
					this,
					finished
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_isActionFinishedGray = finished;
			foreach (ClientBattleActor.GraphicState graphicState in this.m_graphicStates)
			{
				GenericGraphic graphic = graphicState.m_graphic;
				if (graphic != null && graphicState.m_hideCountdown == 0f)
				{
					if (finished)
					{
						graphic.SetColor(new Colori(200, 200, 200, byte.MaxValue));
						graphic.SetSaturation(0f);
					}
					else
					{
						graphic.SetColor(new Colori(byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue));
						graphic.SetSaturation(1f);
					}
				}
			}
		}

		// Token: 0x0600888B RID: 34955 RVA: 0x0027B23C File Offset: 0x0027943C
		private void SetGraphicColor(Colori c)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetGraphicColorColori_hotfix != null)
			{
				this.m_SetGraphicColorColori_hotfix.call(new object[]
				{
					this,
					c
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (ClientBattleActor.GraphicState graphicState in this.m_graphicStates)
			{
				GenericGraphic graphic = graphicState.m_graphic;
				if (graphic != null && graphicState.m_hideCountdown == 0f)
				{
					graphic.SetColor(c);
				}
			}
		}

		// Token: 0x0600888C RID: 34956 RVA: 0x0027B2F0 File Offset: 0x002794F0
		private void AttachBuff(BuffState buffState)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AttachBuffBuffState_hotfix != null)
			{
				this.m_AttachBuffBuffState_hotfix.call(new object[]
				{
					this,
					buffState
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (buffState == null)
			{
				return;
			}
			ClientActorBuff clientActorBuff = new ClientActorBuff();
			clientActorBuff.m_buffState = buffState;
			this.PlayAttachFx(buffState.m_buffInfo.Effect_Attach);
			clientActorBuff.m_fx = this.m_clientBattle.BattleFxPlayer.Play(buffState.m_buffInfo.Effect_Process);
			if (clientActorBuff.m_fx != null)
			{
				clientActorBuff.m_fx.SetPosition(this.ComputeGraphicPosition(this.m_graphicPosition, -20f));
				clientActorBuff.m_fx.AutoDelete(false);
			}
			this.m_buffs.Add(clientActorBuff);
			List<ClientActorBuff> buffs = this.m_buffs;
			if (ClientBattleActor.<>f__mg$cache0 == null)
			{
				ClientBattleActor.<>f__mg$cache0 = new Comparison<ClientActorBuff>(ClientBattleActor.CompareBuffDisplayOrder);
			}
			buffs.Sort(ClientBattleActor.<>f__mg$cache0);
			this.UpdateHpAndBuffUI();
		}

		// Token: 0x0600888D RID: 34957 RVA: 0x0027B414 File Offset: 0x00279614
		private static int CompareBuffDisplayOrder(ClientActorBuff b0, ClientActorBuff b1)
		{
			return b0.m_buffState.m_displayOrder - b1.m_buffState.m_displayOrder;
		}

		// Token: 0x0600888E RID: 34958 RVA: 0x0027B430 File Offset: 0x00279630
		private void DetachBuff(BuffState buffState)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DetachBuffBuffState_hotfix != null)
			{
				this.m_DetachBuffBuffState_hotfix.call(new object[]
				{
					this,
					buffState
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (buffState == null)
			{
				return;
			}
			for (int i = 0; i < this.m_buffs.Count; i++)
			{
				ClientActorBuff clientActorBuff = this.m_buffs[i];
				if (clientActorBuff.m_buffState == buffState)
				{
					if (clientActorBuff.m_fx != null)
					{
						clientActorBuff.m_fx.DeleteMe();
					}
					this.m_buffs.RemoveAt(i);
					break;
				}
			}
			this.UpdateHpAndBuffUI();
		}

		// Token: 0x0600888F RID: 34959 RVA: 0x0027B50C File Offset: 0x0027970C
		private void SetHpBarType(int team, bool isAINpcOrTeamMate)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetHpBarTypeInt32Boolean_hotfix != null)
			{
				this.m_SetHpBarTypeInt32Boolean_hotfix.call(new object[]
				{
					this,
					team,
					isAINpcOrTeamMate
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_uiController != null)
			{
				int hpBarType = 0;
				if (team == this.m_clientBattle.GetMyPlayerTeamNumber())
				{
					if (isAINpcOrTeamMate)
					{
						hpBarType = 2;
					}
				}
				else
				{
					hpBarType = 1;
				}
				this.m_uiController.SetHpBarType(hpBarType);
			}
		}

		// Token: 0x06008890 RID: 34960 RVA: 0x0027B5CC File Offset: 0x002797CC
		public void StartIdleRun()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartIdleRun_hotfix != null)
			{
				this.m_StartIdleRun_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_isIdleRun = true;
		}

		// Token: 0x06008891 RID: 34961 RVA: 0x0027B634 File Offset: 0x00279834
		public void StopIdleRun()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StopIdleRun_hotfix != null)
			{
				this.m_StopIdleRun_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_isIdleRun)
			{
				this.m_isIdleRun = false;
				if (!this.IsDead())
				{
					this.PlayIdleAnimation();
				}
			}
		}

		// Token: 0x06008892 RID: 34962 RVA: 0x0027B6B8 File Offset: 0x002798B8
		public void CancelTeleportDisappear()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CancelTeleportDisappear_hotfix != null)
			{
				this.m_CancelTeleportDisappear_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_isTeleportDisappear)
			{
				this.m_isTeleportDisappear = false;
				this.SetVisible(true);
			}
		}

		// Token: 0x06008893 RID: 34963 RVA: 0x0027B734 File Offset: 0x00279934
		public void SetVisible(bool visible)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetVisibleBoolean_hotfix != null)
			{
				this.m_SetVisibleBoolean_hotfix.call(new object[]
				{
					this,
					visible
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_isVisible = visible;
			if (this.m_clientBattle.IsRebuildingBattle())
			{
				return;
			}
			this.UpdateGraphicVisible();
			this.TickGraphic(0f);
		}

		// Token: 0x06008894 RID: 34964 RVA: 0x0027B7D0 File Offset: 0x002799D0
		public bool IsVisible()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsVisible_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsVisible_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_isVisible;
		}

		// Token: 0x06008895 RID: 34965 RVA: 0x0027B844 File Offset: 0x00279A44
		private int ComputeSoldierGraphicCount()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ComputeSoldierGraphicCount_hotfix != null)
			{
				return Convert.ToInt32(this.m_ComputeSoldierGraphicCount_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int result = 0;
			if (this.m_soldierTotalHealthPoint * 2 > this.m_soldierTotalHealthPointMax)
			{
				result = 2;
			}
			else if (this.m_soldierTotalHealthPoint > 0)
			{
				result = 1;
			}
			return result;
		}

		// Token: 0x06008896 RID: 34966 RVA: 0x0027B8DC File Offset: 0x00279ADC
		private void UpdateSoldierGraphicCount()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateSoldierGraphicCount_hotfix != null)
			{
				this.m_UpdateSoldierGraphicCount_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int soldierGraphicCount = this.m_soldierGraphicCount;
			int num = this.ComputeSoldierGraphicCount();
			if (soldierGraphicCount == num)
			{
				return;
			}
			this.m_soldierGraphicCount = num;
			if (this.m_clientBattle.IsRebuildingBattle())
			{
				return;
			}
			if (num > soldierGraphicCount)
			{
				this.UpdateGraphicVisible();
				for (int i = soldierGraphicCount; i < num; i++)
				{
					ClientBattleActor.GraphicState graphicState = this.m_graphicStates[i + 1];
					if (graphicState.m_graphic != null)
					{
						graphicState.m_graphic.PlayAnimation("idle", true);
						graphicState.m_graphic.SetEffect(GraphicEffect.FadeIn, 0.5f, 0f);
						graphicState.m_hideCountdown = 0f;
					}
				}
				this.SetGraphicActionFinishedEffect(this.m_isActionFinishedGray);
			}
			else
			{
				for (int j = num; j < soldierGraphicCount; j++)
				{
					ClientBattleActor.GraphicState graphicState2 = this.m_graphicStates[j + 1];
					if (graphicState2.m_graphic != null)
					{
						if (!this.m_clientBattle.IsRebuildingBattle())
						{
							graphicState2.m_graphic.PlayFx("FX/Common_ABS/CommonFX/common_die.prefab", 0);
						}
						graphicState2.m_hideCountdown = 0.2f;
					}
				}
			}
		}

		// Token: 0x06008897 RID: 34967 RVA: 0x0027BA40 File Offset: 0x00279C40
		public int GetSoldierGraphicCount()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetSoldierGraphicCount_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetSoldierGraphicCount_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_soldierGraphicCount;
		}

		// Token: 0x06008898 RID: 34968 RVA: 0x0027BAB4 File Offset: 0x00279CB4
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
			if (this.m_clientBattle.IsRebuildingBattle())
			{
				return;
			}
			for (int i = 0; i < this.m_graphicStates.Length; i++)
			{
				GenericGraphic graphic = this.m_graphicStates[i].m_graphic;
				if (graphic != null)
				{
					bool flag = this.m_isVisible && (i == 0 || i <= this.m_soldierGraphicCount);
					graphic.SetVisible(flag);
					if (flag)
					{
						graphic.ForceUpdateSpine();
					}
				}
			}
		}

		// Token: 0x06008899 RID: 34969 RVA: 0x0027BB8C File Offset: 0x00279D8C
		private Vector2 ComputeGraphicOffset(int idx)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ComputeGraphicOffsetInt32_hotfix != null)
			{
				return (Vector2)this.m_ComputeGraphicOffsetInt32_hotfix.call(new object[]
				{
					this,
					idx
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			bool hasHeroAndSoldier = this.m_battleActor.HeroInfo != null && this.m_battleActor.SoldierInfo != null;
			return ClientBattleActor.ComputeGraphicOffset(idx, this.m_direction, this.m_soldierGraphicCount, hasHeroAndSoldier);
		}

		// Token: 0x0600889A RID: 34970 RVA: 0x0027BC40 File Offset: 0x00279E40
		public static Vector2 ComputeGraphicOffset(int idx, int dir, int soldierCount, bool hasHeroAndSoldier)
		{
			Vector2 zero = Vector2.zero;
			float num = 0.25f;
			if (!hasHeroAndSoldier)
			{
				num = 0f;
			}
			if (soldierCount != 0)
			{
				if (soldierCount == 1)
				{
					if (idx == 0)
					{
						zero.x -= num;
					}
					else
					{
						zero.x += num;
						zero.y += 0.01f;
					}
				}
				else if (idx == 0)
				{
					zero.x -= num;
				}
				else
				{
					zero.x += num;
					if (idx == 1)
					{
						zero.y -= 0.1f;
					}
					else
					{
						zero.y += 0.2f;
					}
				}
			}
			zero.x *= 2f * (float)dir;
			zero.y *= 2f;
			zero.y -= 0.5f;
			return zero;
		}

		// Token: 0x0600889B RID: 34971 RVA: 0x0027BD50 File Offset: 0x00279F50
		public GenericGraphic GetGraphic(int idx)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetGraphicInt32_hotfix != null)
			{
				return (GenericGraphic)this.m_GetGraphicInt32_hotfix.call(new object[]
				{
					this,
					idx
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (idx < 0 || idx >= this.m_graphicStates.Length)
			{
				return null;
			}
			return this.m_graphicStates[idx].m_graphic;
		}

		// Token: 0x0600889C RID: 34972 RVA: 0x0027BDF0 File Offset: 0x00279FF0
		public Vector2 GetGraphicPosition()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetGraphicPosition_hotfix != null)
			{
				return (Vector2)this.m_GetGraphicPosition_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_graphicPosition;
		}

		// Token: 0x0600889D RID: 34973 RVA: 0x0027BE64 File Offset: 0x0027A064
		public void SetGraphicSkillFade(bool fade)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetGraphicSkillFadeBoolean_hotfix != null)
			{
				this.m_SetGraphicSkillFadeBoolean_hotfix.call(new object[]
				{
					this,
					fade
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (fade != this.m_isGraphicSkillFade)
			{
				this.m_isGraphicSkillFade = fade;
				this.Locate(this.m_position, this.m_direction);
			}
		}

		// Token: 0x0600889E RID: 34974 RVA: 0x0027BEFC File Offset: 0x0027A0FC
		public bool IsGraphicSkillFade()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsGraphicSkillFade_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsGraphicSkillFade_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_isGraphicSkillFade;
		}

		// Token: 0x0600889F RID: 34975 RVA: 0x0027BF70 File Offset: 0x0027A170
		private void UpdateHpAndBuffUI()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateHpAndBuffUI_hotfix != null)
			{
				this.m_UpdateHpAndBuffUI_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_clientBattle.IsRebuildingBattle())
			{
				return;
			}
			if (this.m_uiController != null)
			{
				this.m_uiController.SetHp(this.GetTotalHealthPoint(), this.GetTotalHealthPointMax());
				this.m_uiController.SetBuff(this.m_battleActor, this.m_buffs);
			}
			foreach (ClientActorBuff clientActorBuff in this.m_buffs)
			{
				if (clientActorBuff.m_fx != null)
				{
					clientActorBuff.m_fx.SetVisible(this.m_battleActor.IsBuffEffective(clientActorBuff.m_buffState));
				}
			}
		}

		// Token: 0x060088A0 RID: 34976 RVA: 0x0027C090 File Offset: 0x0027A290
		public void ShowPlayerIndex(bool show)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowPlayerIndexBoolean_hotfix != null)
			{
				this.m_ShowPlayerIndexBoolean_hotfix.call(new object[]
				{
					this,
					show
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_uiController != null)
			{
				this.m_uiController.ShowPlayerIndexTag(show);
			}
		}

		// Token: 0x17001CC5 RID: 7365
		// (get) Token: 0x060088A1 RID: 34977 RVA: 0x0027C120 File Offset: 0x0027A320
		public GridPosition Position
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_Position_hotfix != null)
				{
					return (GridPosition)this.m_get_Position_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_position;
			}
		}

		// Token: 0x17001CC6 RID: 7366
		// (get) Token: 0x060088A2 RID: 34978 RVA: 0x0027C194 File Offset: 0x0027A394
		public int Direction
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_Direction_hotfix != null)
				{
					return Convert.ToInt32(this.m_get_Direction_hotfix.call(new object[]
					{
						this
					}));
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_direction;
			}
		}

		// Token: 0x17001CC7 RID: 7367
		// (get) Token: 0x060088A3 RID: 34979 RVA: 0x0027C208 File Offset: 0x0027A408
		public BattleActor BattleActor
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_BattleActor_hotfix != null)
				{
					return (BattleActor)this.m_get_BattleActor_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_battleActor;
			}
		}

		// Token: 0x17001CC8 RID: 7368
		// (get) Token: 0x060088A4 RID: 34980 RVA: 0x0027C27C File Offset: 0x0027A47C
		public int TeamNumber
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_TeamNumber_hotfix != null)
				{
					return Convert.ToInt32(this.m_get_TeamNumber_hotfix.call(new object[]
					{
						this
					}));
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_battleActor.TeamNumber;
			}
		}

		// Token: 0x17001CC9 RID: 7369
		// (get) Token: 0x060088A5 RID: 34981 RVA: 0x0027C2F4 File Offset: 0x0027A4F4
		public int HeroHealthPoint
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_HeroHealthPoint_hotfix != null)
				{
					return Convert.ToInt32(this.m_get_HeroHealthPoint_hotfix.call(new object[]
					{
						this
					}));
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_heroHealthPoint;
			}
		}

		// Token: 0x17001CCA RID: 7370
		// (get) Token: 0x060088A6 RID: 34982 RVA: 0x0027C368 File Offset: 0x0027A568
		public int SoldierTotalHealthPoint
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_SoldierTotalHealthPoint_hotfix != null)
				{
					return Convert.ToInt32(this.m_get_SoldierTotalHealthPoint_hotfix.call(new object[]
					{
						this
					}));
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_soldierTotalHealthPoint;
			}
		}

		// Token: 0x060088A7 RID: 34983 RVA: 0x0027C3DC File Offset: 0x0027A5DC
		private bool TickAct(ClientActorAct act)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TickActClientActorAct_hotfix != null)
			{
				return Convert.ToBoolean(this.m_TickActClientActorAct_hotfix.call(new object[]
				{
					this,
					act
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (act == null)
			{
				return false;
			}
			bool result = false;
			Type type = act.GetType();
			if (type == typeof(ClientActorActActive))
			{
				result = this.TickAct((ClientActorActActive)act);
			}
			else if (type == typeof(ClientActorActActionBegin))
			{
				result = this.TickAct((ClientActorActActionBegin)act);
			}
			else if (type == typeof(ClientActorActActionEnd))
			{
				result = this.TickAct((ClientActorActActionEnd)act);
			}
			else if (type == typeof(ClientActorActMove))
			{
				result = this.TickAct((ClientActorActMove)act);
			}
			else if (type == typeof(ClientActorActTryMove))
			{
				result = this.TickAct((ClientActorActTryMove)act);
			}
			else if (type == typeof(ClientActorActPerformMove))
			{
				result = this.TickAct((ClientActorActPerformMove)act);
			}
			else if (type == typeof(ClientActorActPunchMove))
			{
				result = this.TickAct((ClientActorActPunchMove)act);
			}
			else if (type == typeof(ClientActorActExchangeMove))
			{
				result = this.TickAct((ClientActorActExchangeMove)act);
			}
			else if (type == typeof(ClientActorActSetDir))
			{
				result = this.TickAct((ClientActorActSetDir)act);
			}
			else if (type == typeof(ClientActorActPlayFx))
			{
				result = this.TickAct((ClientActorActPlayFx)act);
			}
			else if (type == typeof(ClientActorActPlayAnimation))
			{
				result = this.TickAct((ClientActorActPlayAnimation)act);
			}
			else if (type == typeof(ClientActorActChangeIdleAnimation))
			{
				result = this.TickAct((ClientActorActChangeIdleAnimation)act);
			}
			else if (type == typeof(ClientActorActTarget))
			{
				result = this.TickAct((ClientActorActTarget)act);
			}
			else if (type == typeof(ClientActorActSkill))
			{
				result = this.TickAct((ClientActorActSkill)act);
			}
			else if (type == typeof(ClientActorActSkillHit))
			{
				result = this.TickAct((ClientActorActSkillHit)act);
			}
			else if (type == typeof(ClientActorActAttachBuff))
			{
				result = this.TickAct((ClientActorActAttachBuff)act);
			}
			else if (type == typeof(ClientActorActDetachBuff))
			{
				result = this.TickAct((ClientActorActDetachBuff)act);
			}
			else if (type == typeof(ClientActorActImmune))
			{
				result = this.TickAct((ClientActorActImmune)act);
			}
			else if (type == typeof(ClientActorActPassiveSkill))
			{
				result = this.TickAct((ClientActorActPassiveSkill)act);
			}
			else if (type == typeof(ClientActorActPassiveSkillHit))
			{
				result = this.TickAct((ClientActorActPassiveSkillHit)act);
			}
			else if (type == typeof(ClientActorActBuffHit))
			{
				result = this.TickAct((ClientActorActBuffHit)act);
			}
			else if (type == typeof(ClientActorActTerrainHit))
			{
				result = this.TickAct((ClientActorActTerrainHit)act);
			}
			else if (type == typeof(ClientActorActTeleportDisappear))
			{
				result = this.TickAct((ClientActorActTeleportDisappear)act);
			}
			else if (type == typeof(ClientActorActTeleportAppear))
			{
				result = this.TickAct((ClientActorActTeleportAppear)act);
			}
			else if (type == typeof(ClientActorActSummon))
			{
				result = this.TickAct((ClientActorActSummon)act);
			}
			else if (type == typeof(ClientActorActDie))
			{
				result = this.TickAct((ClientActorActDie)act);
			}
			else if (type == typeof(ClientActorActAppear))
			{
				result = this.TickAct((ClientActorActAppear)act);
			}
			else if (type == typeof(ClientActorActDisappear))
			{
				result = this.TickAct((ClientActorActDisappear)act);
			}
			else if (type == typeof(ClientActorActChangeTeam))
			{
				result = this.TickAct((ClientActorActChangeTeam)act);
			}
			else if (type == typeof(ClientActorActChangeArmy))
			{
				result = this.TickAct((ClientActorActChangeArmy)act);
			}
			else if (type == typeof(ClientActorActReplace))
			{
				result = this.TickAct((ClientActorActReplace)act);
			}
			else if (type == typeof(ClientActorActCameraFocus))
			{
				result = this.TickAct((ClientActorActCameraFocus)act);
			}
			else if (type == typeof(ClientActorActGainBattleTreasure))
			{
				result = this.TickAct((ClientActorActGainBattleTreasure)act);
			}
			else if (type == typeof(ClientActorActStartGuard))
			{
				result = this.TickAct((ClientActorActStartGuard)act);
			}
			else if (type == typeof(ClientActorActStopGuard))
			{
				result = this.TickAct((ClientActorActStopGuard)act);
			}
			else if (type == typeof(ClientActorActBeforeStartCombat))
			{
				result = this.TickAct((ClientActorActBeforeStartCombat)act);
			}
			else if (type == typeof(ClientNullActorActCancelCombat))
			{
				result = this.TickAct((ClientNullActorActCancelCombat)act);
			}
			else if (type == typeof(ClientActorActStartCombat))
			{
				result = this.TickAct((ClientActorActStartCombat)act);
			}
			else if (type == typeof(ClientActorActStopCombat))
			{
				result = this.TickAct((ClientActorActStopCombat)act);
			}
			else if (type == typeof(ClientNullActorActStartBattle))
			{
				result = this.TickAct((ClientNullActorActStartBattle)act);
			}
			else if (type == typeof(ClientNullActorActBattleWinCondition))
			{
				result = this.TickAct((ClientNullActorActBattleWinCondition)act);
			}
			else if (type == typeof(ClientNullActorActBattleLoseCondition))
			{
				result = this.TickAct((ClientNullActorActBattleLoseCondition)act);
			}
			else if (type == typeof(ClientNullActorActNextTurn))
			{
				result = this.TickAct((ClientNullActorActNextTurn)act);
			}
			else if (type == typeof(ClientNullActorActNextTeam))
			{
				result = this.TickAct((ClientNullActorActNextTeam)act);
			}
			else if (type == typeof(ClientNullActorActNextPlayer))
			{
				result = this.TickAct((ClientNullActorActNextPlayer)act);
			}
			else if (type == typeof(ClientNullActorActNextActor))
			{
				result = this.TickAct((ClientNullActorActNextActor)act);
			}
			else if (type == typeof(ClientNullActorActFastCombat))
			{
				result = this.TickAct((ClientNullActorActFastCombat)act);
			}
			else if (type == typeof(ClientNullActorActBattleDialog))
			{
				result = this.TickAct((ClientNullActorActBattleDialog)act);
			}
			else if (type == typeof(ClientNullActorActStartBattlePerform))
			{
				result = this.TickAct((ClientNullActorActStartBattlePerform)act);
			}
			else if (type == typeof(ClientNullActorActStopBattlePerform))
			{
				result = this.TickAct((ClientNullActorActStopBattlePerform)act);
			}
			else if (type == typeof(ClientNullActorActChangeMapTerrain))
			{
				result = this.TickAct((ClientNullActorActChangeMapTerrain)act);
			}
			else if (type == typeof(ClientNullActorActCameraFocus))
			{
				result = this.TickAct((ClientNullActorActCameraFocus)act);
			}
			else if (type == typeof(ClientNullActorActPlayMusic))
			{
				result = this.TickAct((ClientNullActorActPlayMusic)act);
			}
			else if (type == typeof(ClientNullActorActPlaySound))
			{
				result = this.TickAct((ClientNullActorActPlaySound)act);
			}
			else if (type == typeof(ClientNullActorActPlayFx))
			{
				result = this.TickAct((ClientNullActorActPlayFx)act);
			}
			else if (type == typeof(ClientNullActorActWaitTime))
			{
				result = this.TickAct((ClientNullActorActWaitTime)act);
			}
			this.m_actFrame++;
			return result;
		}

		// Token: 0x060088A8 RID: 34984 RVA: 0x0027CBE4 File Offset: 0x0027ADE4
		private bool TickAct(ClientActorActActive act)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TickActClientActorActActive_hotfix != null)
			{
				return Convert.ToBoolean(this.m_TickActClientActorActActive_hotfix.call(new object[]
				{
					this,
					act
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_actFrame == 0 && act.m_newStep)
			{
				this.m_clientBattle.CameraFocusActor(this);
			}
			if (!this.m_clientBattle.IsCameraFocusing())
			{
				if (!this.HasFightTag(FightTag.FightTag_Stun))
				{
					this.m_clientBattle.OnActorActive(this, act.m_newStep, act.m_step);
				}
				return false;
			}
			return true;
		}

		// Token: 0x060088A9 RID: 34985 RVA: 0x0027CCBC File Offset: 0x0027AEBC
		private bool TickAct(ClientActorActActionBegin act)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TickActClientActorActActionBegin_hotfix != null)
			{
				return Convert.ToBoolean(this.m_TickActClientActorActActionBegin_hotfix.call(new object[]
				{
					this,
					act
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_actFrame == 0)
			{
				if (this.m_battleActor.PlayerIndex < 0 || this.m_battleActor.PlayerIndex == this.m_clientBattle.GetMyPlayerIndex())
				{
					return false;
				}
				this.m_clientBattle.CameraFocusActor(this);
			}
			return this.m_clientBattle.IsCameraFocusing();
		}

		// Token: 0x060088AA RID: 34986 RVA: 0x0027CD98 File Offset: 0x0027AF98
		private bool TickAct(ClientActorActActionEnd act)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TickActClientActorActActionEnd_hotfix != null)
			{
				return Convert.ToBoolean(this.m_TickActClientActorActActionEnd_hotfix.call(new object[]
				{
					this,
					act
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_actFrame == 0)
			{
				this.UpdateHpAndBuffUI();
				if (this.m_isIdleRun)
				{
					this.StopIdleRun();
				}
				else if (!this.IsDead())
				{
					this.PlayIdleAnimation();
				}
				return false;
			}
			return true;
		}

		// Token: 0x060088AB RID: 34987 RVA: 0x0027CE50 File Offset: 0x0027B050
		private void InitMoveAct(GridPosition pos, int dir, bool sound, bool endDelay = true)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitMoveActGridPositionInt32BooleanBoolean_hotfix != null)
			{
				this.m_InitMoveActGridPositionInt32BooleanBoolean_hotfix.call(new object[]
				{
					this,
					pos,
					dir,
					sound,
					endDelay
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_clientBattle.IsRebuildingBattle())
			{
				this.m_tempActFrame = 0;
				this.m_position = pos;
				this.m_direction = dir;
			}
			else
			{
				Vector2 a = this.m_clientBattle.GridPositionToWorldPosition(this.m_position);
				Vector2 b = this.m_clientBattle.GridPositionToWorldPosition(pos);
				float num = Vector2.Distance(a, b);
				if (this.m_direction != dir && this.ComputeSoldierGraphicCount() > 0 && this.m_battleActor.HeroInfo != null)
				{
					num += 1f;
				}
				int num2 = (int)(num * 1000f / (float)this.m_clientBattle.ConfigDataLoader.Const_BattleActorMoveSpeed);
				if (this.m_acts.Count <= 1 && endDelay)
				{
					num2 += 100;
				}
				this.m_tempActFrame = ClientBattle.MillisecondToFrame(num2);
				this.m_position = pos;
				this.m_direction = dir;
				this.PlayAnimation("run", true, true);
				if (sound)
				{
					MoveType moveType = this.m_battleActor.GetMoveType();
					if (moveType == MoveType.MoveType_Ride)
					{
						this.PlaySound(SoundTableId.SoundTableId_BattleMoveRide);
					}
					else if (moveType == MoveType.MoveType_Fly)
					{
						this.PlaySound(SoundTableId.SoundTableId_BattleMoveFly);
					}
					else
					{
						this.PlaySound(SoundTableId.SoundTableId_BattleMoveWalk);
					}
				}
			}
		}

		// Token: 0x060088AC RID: 34988 RVA: 0x0027D018 File Offset: 0x0027B218
		private int ComputeMoveTime(GridPosition p0, GridPosition p1)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ComputeMoveTimeGridPositionGridPosition_hotfix != null)
			{
				return Convert.ToInt32(this.m_ComputeMoveTimeGridPositionGridPosition_hotfix.call(new object[]
				{
					this,
					p0,
					p1
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Vector2 a = this.m_clientBattle.GridPositionToWorldPosition(p0);
			Vector2 b = this.m_clientBattle.GridPositionToWorldPosition(p1);
			float num = Vector2.Distance(a, b);
			return (int)(num * 1000f / (float)this.m_clientBattle.ConfigDataLoader.Const_BattleActorMoveSpeed);
		}

		// Token: 0x060088AD RID: 34989 RVA: 0x0027D0E0 File Offset: 0x0027B2E0
		private bool TickAct(ClientActorActMove act)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TickActClientActorActMove_hotfix != null)
			{
				return Convert.ToBoolean(this.m_TickActClientActorActMove_hotfix.call(new object[]
				{
					this,
					act
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_actFrame == 0)
			{
				this.InitMoveAct(act.m_position, act.m_direction, act.m_sound, true);
				this.m_clientBattle.CameraFollowActor(this);
				this.m_clientBattle.ClientBattleListener.OnClientActorMove(this);
			}
			if (this.m_actFrame >= this.m_tempActFrame)
			{
				this.m_clientBattle.CameraFollowActor(null);
				return false;
			}
			return true;
		}

		// Token: 0x060088AE RID: 34990 RVA: 0x0027D1C0 File Offset: 0x0027B3C0
		private bool TickAct(ClientActorActTryMove act)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TickActClientActorActTryMove_hotfix != null)
			{
				return Convert.ToBoolean(this.m_TickActClientActorActTryMove_hotfix.call(new object[]
				{
					this,
					act
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_actFrame == 0)
			{
				this.InitMoveAct(act.m_position, act.m_direction, act.m_sound, true);
				this.m_clientBattle.CameraFollowActor(this);
				this.m_clientBattle.ClientBattleListener.OnClientActorTryMove(this);
			}
			if (this.m_actFrame >= this.m_tempActFrame)
			{
				this.m_clientBattle.CameraFollowActor(null);
				return false;
			}
			return true;
		}

		// Token: 0x060088AF RID: 34991 RVA: 0x0027D2A0 File Offset: 0x0027B4A0
		private bool TickAct(ClientActorActPerformMove act)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TickActClientActorActPerformMove_hotfix != null)
			{
				return Convert.ToBoolean(this.m_TickActClientActorActPerformMove_hotfix.call(new object[]
				{
					this,
					act
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_actFrame == 0)
			{
				this.InitMoveAct(act.m_position, act.m_direction, act.m_sound, true);
				if (act.m_cameraFollow)
				{
					this.m_clientBattle.CameraFollowActor(this);
				}
				this.m_clientBattle.ClientBattleListener.OnClientActorMove(this);
			}
			if (this.m_actFrame >= this.m_tempActFrame)
			{
				if (act.m_cameraFollow)
				{
					this.m_clientBattle.CameraFollowActor(null);
				}
				if (this.m_acts.Count <= 1)
				{
					this.PlayIdleAnimation();
				}
				return false;
			}
			return true;
		}

		// Token: 0x060088B0 RID: 34992 RVA: 0x0027D3AC File Offset: 0x0027B5AC
		private bool TickAct(ClientActorActPunchMove act)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TickActClientActorActPunchMove_hotfix != null)
			{
				return Convert.ToBoolean(this.m_TickActClientActorActPunchMove_hotfix.call(new object[]
				{
					this,
					act
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_actFrame == 0)
			{
				this.m_tempActFrame = 0;
				if (this.m_clientBattle.IsRebuildingBattle())
				{
					this.m_position = act.m_position;
					this.m_direction = act.m_direction;
					return false;
				}
			}
			int num = (!act.m_isDragExchange) ? 400 : 0;
			if (this.m_actFrame == ClientBattle.MillisecondToFrame(num))
			{
				int num2 = this.ComputeMoveTime(this.m_position, act.m_position);
				this.m_tempActFrame = this.m_actFrame + ClientBattle.MillisecondToFrame(num2 + num + num);
				this.m_position = act.m_position;
				this.m_direction = act.m_direction;
				if (!act.m_isDragExchange)
				{
					this.PlayAnimation("hurt", false, true);
					this.PlayAttachFx(act.m_fxName);
				}
			}
			return this.m_tempActFrame == 0 || this.m_actFrame < this.m_tempActFrame;
		}

		// Token: 0x060088B1 RID: 34993 RVA: 0x0027D514 File Offset: 0x0027B714
		private bool TickAct(ClientActorActExchangeMove act)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TickActClientActorActExchangeMove_hotfix != null)
			{
				return Convert.ToBoolean(this.m_TickActClientActorActExchangeMove_hotfix.call(new object[]
				{
					this,
					act
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_actFrame == 0)
			{
				if (act.m_moveType == 0)
				{
					this.Locate(act.m_position, act.m_direction);
					this.m_tempActFrame = ClientBattle.MillisecondToFrame(300);
				}
				else if (act.m_moveType == 1)
				{
					int val = this.ComputeMoveTime(this.m_position, act.m_position);
					this.m_tempActFrame = ClientBattle.MillisecondToFrame(Math.Max(val, 300));
					this.m_position = act.m_position;
					this.m_direction = act.m_direction;
				}
				this.PlayAttachFx(act.m_fxName);
			}
			return this.m_actFrame < this.m_tempActFrame;
		}

		// Token: 0x060088B2 RID: 34994 RVA: 0x0027D63C File Offset: 0x0027B83C
		private bool TickAct(ClientActorActSetDir act)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TickActClientActorActSetDir_hotfix != null)
			{
				return Convert.ToBoolean(this.m_TickActClientActorActSetDir_hotfix.call(new object[]
				{
					this,
					act
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_actFrame == 0)
			{
				this.m_direction = act.m_direction;
			}
			return false;
		}

		// Token: 0x060088B3 RID: 34995 RVA: 0x0027D6D0 File Offset: 0x0027B8D0
		private bool TickAct(ClientActorActPlayFx act)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TickActClientActorActPlayFx_hotfix != null)
			{
				return Convert.ToBoolean(this.m_TickActClientActorActPlayFx_hotfix.call(new object[]
				{
					this,
					act
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_actFrame == 0)
			{
				if (act.m_attachMode == 0)
				{
					this.PlayHeroFx(act.m_fxName);
				}
				else
				{
					this.PlayAttachFx(act.m_fxName);
				}
			}
			return false;
		}

		// Token: 0x060088B4 RID: 34996 RVA: 0x0027D780 File Offset: 0x0027B980
		private bool TickAct(ClientActorActPlayAnimation act)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TickActClientActorActPlayAnimation_hotfix != null)
			{
				return Convert.ToBoolean(this.m_TickActClientActorActPlayAnimation_hotfix.call(new object[]
				{
					this,
					act
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_actFrame == 0)
			{
				if (this.m_clientBattle.IsRebuildingBattle())
				{
					return false;
				}
				bool flag = act.m_animationTime > 0;
				this.PlayAnimation(act.m_animationName, flag, false);
				int ms = act.m_animationTime;
				if (!flag)
				{
					ms = this.GetHeroAnimationDuration(act.m_animationName);
				}
				this.m_tempActFrame = ClientBattle.MillisecondToFrame(ms);
			}
			if (this.m_actFrame >= this.m_tempActFrame)
			{
				this.PlayIdleAnimation();
				return false;
			}
			return true;
		}

		// Token: 0x060088B5 RID: 34997 RVA: 0x0027D874 File Offset: 0x0027BA74
		private bool TickAct(ClientActorActChangeIdleAnimation act)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TickActClientActorActChangeIdleAnimation_hotfix != null)
			{
				return Convert.ToBoolean(this.m_TickActClientActorActChangeIdleAnimation_hotfix.call(new object[]
				{
					this,
					act
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_actFrame == 0)
			{
				if (!string.IsNullOrEmpty(act.m_idleAnimationName))
				{
					this.m_idleAnimationName = act.m_idleAnimationName;
				}
				else
				{
					this.m_idleAnimationName = "idle";
				}
			}
			return false;
		}

		// Token: 0x060088B6 RID: 34998 RVA: 0x0027D928 File Offset: 0x0027BB28
		private bool TickAct(ClientActorActTarget act)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TickActClientActorActTarget_hotfix != null)
			{
				return Convert.ToBoolean(this.m_TickActClientActorActTarget_hotfix.call(new object[]
				{
					this,
					act
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_actFrame == 0)
			{
				this.FaceTo(act.m_targetPosition);
				if (this.m_clientBattle.IsBattlePerforming())
				{
					return false;
				}
				if (this.m_clientBattle.IsRebuildingBattle())
				{
					return false;
				}
				this.PlayAnimation("run", true, true);
				this.m_clientBattle.ClientBattleListener.OnClientActorTarget(this, act.m_skillInfo, act.m_targetPosition, act.m_armyRelationValue);
			}
			return this.m_actFrame < ClientBattle.MillisecondToFrame(500);
		}

		// Token: 0x060088B7 RID: 34999 RVA: 0x0027DA28 File Offset: 0x0027BC28
		private bool TickAct(ClientActorActSkill act)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TickActClientActorActSkill_hotfix != null)
			{
				return Convert.ToBoolean(this.m_TickActClientActorActSkill_hotfix.call(new object[]
				{
					this,
					act
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = ClientBattleActor.ComputeSkillCastTime(act.m_skillInfo);
			int num2 = Combat.MillisecondToFrame(num);
			if (this.m_actFrame == 0)
			{
				this.FaceTo(act.m_targetPosition);
				if (this.m_isIdleRun)
				{
					this.StopIdleRun();
				}
				else
				{
					this.PlayIdleAnimation();
				}
				if (act.m_skillInfo.Time_Sing > 0)
				{
					this.PlayAnimation("sing", true, false);
					this.PlayHeroFx(act.m_skillInfo.Effect_Sing);
				}
				int num3 = ClientBattleActor.ComputeSkillHitTime(act.m_skillInfo, act.m_hits);
				this.m_tempActFrame = ClientBattle.MillisecondToFrame(Math.Max(num3 + this.m_clientBattle.ConfigDataLoader.Const_DamagePostDelay, num + act.m_skillInfo.Time_End));
			}
			if (this.m_actFrame == Combat.MillisecondToFrame(act.m_skillInfo.Time_Sing))
			{
				this.PlayHeroFx(act.m_skillInfo.Effect_PreCast);
			}
			if (this.m_actFrame == Math.Max(num2 - 1, 0))
			{
				this.m_clientBattle.OnActorCastSkill(this, act.m_skillInfo, act.m_targetPosition);
			}
			if (this.m_actFrame == num2)
			{
				this.PlayAnimation(act.m_skillInfo.Anim_Cast, false, false);
				this.m_clientBattle.CameraFocusPosition(act.m_targetPosition);
			}
			if (this.m_actFrame >= num2)
			{
				if (this.m_actFrame == Combat.MillisecondToFrame(num + act.m_skillInfo.Time_EffCast1))
				{
					this.PlayHeroFx(act.m_skillInfo.Effect_Cast1);
				}
				if (this.m_actFrame == Combat.MillisecondToFrame(num + act.m_skillInfo.Time_EffCast2))
				{
					this.PlayHeroFx(act.m_skillInfo.Effect_Cast2);
				}
				if (this.m_actFrame == Combat.MillisecondToFrame(num + act.m_skillInfo.Time_EffMagic1))
				{
					this.PlayFx(act.m_skillInfo.Effect_Magic1, act.m_targetPosition);
					if (act.m_skillInfo.SkillType == SkillType.SkillType_BF_Teleport && act.m_targetPosition == this.m_position)
					{
						this.SetVisible(false);
					}
				}
				if (this.m_actFrame == Combat.MillisecondToFrame(num + act.m_skillInfo.Time_EffMagic2) && act.m_skillInfo.SkillType != SkillType.SkillType_BF_Teleport)
				{
					this.PlayFx(act.m_skillInfo.Effect_Magic2, act.m_targetPosition);
				}
				if (this.m_actFrame == ClientBattle.MillisecondToFrame(num + act.m_skillInfo.Time_Hit))
				{
				}
				if (this.m_actFrame == ClientBattle.MillisecondToFrame(num + act.m_skillInfo.Time_End))
				{
				}
				if (act.m_hits != null)
				{
					this.TickSkillHits(act.m_skillInfo, act.m_hits);
				}
				if (!this.IsHeroPlayAnimation())
				{
					this.PlayIdleAnimation();
				}
				if (this.m_actFrame >= this.m_tempActFrame)
				{
					this.m_clientBattle.OnActorCastSkillEnd(this, act.m_skillInfo);
					return false;
				}
			}
			return true;
		}

		// Token: 0x060088B8 RID: 35000 RVA: 0x0027DD80 File Offset: 0x0027BF80
		private bool TickAct(ClientActorActSkillHit act)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TickActClientActorActSkillHit_hotfix != null)
			{
				return Convert.ToBoolean(this.m_TickActClientActorActSkillHit_hotfix.call(new object[]
				{
					this,
					act
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_actFrame == 0)
			{
				this.m_direction = act.m_direction;
				int num = ClientBattleActor.ComputeSkillHitTime(act.m_skillInfo, act.m_hits);
				this.m_tempActFrame = ClientBattle.MillisecondToFrame(num + this.m_clientBattle.ConfigDataLoader.Const_DamagePostDelay);
			}
			if (!this.TickSkillHits(act.m_skillInfo, act.m_hits))
			{
				return false;
			}
			if (!this.IsHeroPlayAnimation())
			{
				this.PlayIdleAnimation();
			}
			return this.m_actFrame < this.m_tempActFrame;
		}

		// Token: 0x060088B9 RID: 35001 RVA: 0x0027DE80 File Offset: 0x0027C080
		private static int ComputeSkillCastTime(ConfigDataSkillInfo skillInfo)
		{
			if (skillInfo == null)
			{
				return 0;
			}
			int num = skillInfo.Time_Sing;
			if (!string.IsNullOrEmpty(skillInfo.Effect_PreCast))
			{
				IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
				num += configDataLoader.Const_SkillPreCastDelay;
			}
			return num;
		}

		// Token: 0x060088BA RID: 35002 RVA: 0x0027DEC8 File Offset: 0x0027C0C8
		private static int ComputeSkillHitTime(ConfigDataSkillInfo skillInfo, List<ClientActorHitInfo> hits)
		{
			if (skillInfo == null)
			{
				return 0;
			}
			int num = ClientBattleActor.ComputeSkillCastTime(skillInfo);
			int num2 = num + skillInfo.Time_Hit;
			if (hits != null)
			{
				int num3 = 0;
				for (int i = 0; i < hits.Count; i++)
				{
					hits[i].m_frame = ClientBattle.MillisecondToFrame(num2);
					if (i == hits.Count - 1)
					{
						break;
					}
					if (skillInfo.Time_MultiHit.Count > 0)
					{
						num2 += skillInfo.Time_MultiHit[num3 % skillInfo.Time_MultiHit.Count];
						num3++;
					}
				}
			}
			return num2;
		}

		// Token: 0x060088BB RID: 35003 RVA: 0x0027DF64 File Offset: 0x0027C164
		private bool TickSkillHits(ConfigDataSkillInfo skillInfo, List<ClientActorHitInfo> hits)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TickSkillHitsConfigDataSkillInfoList`1_hotfix != null)
			{
				return Convert.ToBoolean(this.m_TickSkillHitsConfigDataSkillInfoList`1_hotfix.call(new object[]
				{
					this,
					skillInfo,
					hits
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (skillInfo == null || hits == null)
			{
				return true;
			}
			for (int i = 0; i < hits.Count; i++)
			{
				ClientActorHitInfo clientActorHitInfo = hits[i];
				if (this.m_actFrame == clientActorHitInfo.m_frame)
				{
					this.m_heroHealthPoint = clientActorHitInfo.m_heroHp;
					this.m_soldierTotalHealthPoint = clientActorHitInfo.m_soldierHp;
					this.UpdateHpAndBuffUI();
					this.m_clientBattle.ClientBattleListener.OnClientActorSkillHit(this, skillInfo, clientActorHitInfo.m_heroHpModify, clientActorHitInfo.m_soldierHpModify, clientActorHitInfo.m_damageNumberType);
					this.PlayAttachFx(skillInfo.Effect_Hit);
					if (i == 0 && skillInfo.IsDamageSkill() && clientActorHitInfo.m_damageNumberType != DamageNumberType.Heal)
					{
						this.PlayAnimation("hurt", false, true);
					}
					if (i == hits.Count - 1)
					{
						if (this.IsDead())
						{
							return false;
						}
						this.UpdateSoldierGraphicCount();
					}
				}
			}
			return true;
		}

		// Token: 0x060088BC RID: 35004 RVA: 0x0027E0C8 File Offset: 0x0027C2C8
		private bool TickAct(ClientActorActAttachBuff act)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TickActClientActorActAttachBuff_hotfix != null)
			{
				return Convert.ToBoolean(this.m_TickActClientActorActAttachBuff_hotfix.call(new object[]
				{
					this,
					act
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_actFrame == 0)
			{
				this.m_heroHealthPointMax = act.m_heroHpMax;
				this.m_soldierTotalHealthPointMax = act.m_soldierHpMax;
				this.m_fightTags = act.m_fightTags;
				this.AttachBuff(act.m_buffState);
			}
			return false;
		}

		// Token: 0x060088BD RID: 35005 RVA: 0x0027E180 File Offset: 0x0027C380
		private bool TickAct(ClientActorActDetachBuff act)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TickActClientActorActDetachBuff_hotfix != null)
			{
				return Convert.ToBoolean(this.m_TickActClientActorActDetachBuff_hotfix.call(new object[]
				{
					this,
					act
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_actFrame == 0)
			{
				this.m_heroHealthPointMax = act.m_heroHpMax;
				this.m_soldierTotalHealthPointMax = act.m_soldierHpMax;
				this.m_fightTags = act.m_fightTags;
				this.DetachBuff(act.m_buffState);
			}
			return false;
		}

		// Token: 0x060088BE RID: 35006 RVA: 0x0027E238 File Offset: 0x0027C438
		private bool TickAct(ClientActorActImmune act)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TickActClientActorActImmune_hotfix != null)
			{
				return Convert.ToBoolean(this.m_TickActClientActorActImmune_hotfix.call(new object[]
				{
					this,
					act
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_actFrame == 0)
			{
				if (this.m_clientBattle.IsRebuildingBattle())
				{
					return false;
				}
				this.m_clientBattle.ClientBattleListener.OnClientActorImmune(this);
			}
			return this.m_actFrame < ClientBattle.MillisecondToFrame(500);
		}

		// Token: 0x060088BF RID: 35007 RVA: 0x0027E2FC File Offset: 0x0027C4FC
		private bool TickAct(ClientActorActPassiveSkill act)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TickActClientActorActPassiveSkill_hotfix != null)
			{
				return Convert.ToBoolean(this.m_TickActClientActorActPassiveSkill_hotfix.call(new object[]
				{
					this,
					act
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_actFrame == 0)
			{
				if (this.m_clientBattle.IsRebuildingBattle())
				{
					return false;
				}
				this.PlayAttachFx(act.m_sourceBuffState.m_buffInfo.Effect_Acting);
				this.m_clientBattle.ClientBattleListener.OnClientActorPassiveSkill(this, act.m_sourceBuffState);
				this.PlayAnimation("cast", false, false);
				if (act.m_hitSelf)
				{
					this.PlayAttachFx(act.m_sourceBuffState.m_buffInfo.Effect_ActingTarget);
				}
				int ms = Math.Max(this.GetHeroAnimationDuration("cast"), 1200);
				this.m_tempActFrame = ClientBattle.MillisecondToFrame(ms);
			}
			return this.m_actFrame < this.m_tempActFrame;
		}

		// Token: 0x060088C0 RID: 35008 RVA: 0x0027E428 File Offset: 0x0027C628
		private bool TickAct(ClientActorActPassiveSkillHit act)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TickActClientActorActPassiveSkillHit_hotfix != null)
			{
				return Convert.ToBoolean(this.m_TickActClientActorActPassiveSkillHit_hotfix.call(new object[]
				{
					this,
					act
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_actFrame == 0)
			{
				if (this.m_clientBattle.IsRebuildingBattle())
				{
					return false;
				}
				this.PlayAttachFx(act.m_sourceBuffState.m_buffInfo.Effect_ActingTarget);
			}
			return this.m_actFrame < ClientBattle.MillisecondToFrame(400);
		}

		// Token: 0x060088C1 RID: 35009 RVA: 0x0027E4F0 File Offset: 0x0027C6F0
		private bool TickAct(ClientActorActBuffHit act)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TickActClientActorActBuffHit_hotfix != null)
			{
				return Convert.ToBoolean(this.m_TickActClientActorActBuffHit_hotfix.call(new object[]
				{
					this,
					act
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_actFrame == 0)
			{
				this.m_heroHealthPoint = act.m_heroHp;
				this.m_soldierTotalHealthPoint = act.m_soldierHp;
				this.UpdateHpAndBuffUI();
				this.m_clientBattle.ClientBattleListener.OnClientActorBuffHit(this, act.m_buffState.m_buffInfo, act.m_heroHpModify, act.m_soldierHpModify, act.m_damageNumberType);
				this.PlayAttachFx(act.m_buffState.m_buffInfo.Effect_ActingTarget);
				if (act.m_damageNumberType == DamageNumberType.Heal)
				{
					this.PlayIdleAnimation();
				}
				else
				{
					this.PlayAnimation("hurt", false, true);
				}
				if (this.IsDead())
				{
					return false;
				}
				this.UpdateSoldierGraphicCount();
				this.m_tempActFrame = ClientBattle.MillisecondToFrame(this.m_clientBattle.ConfigDataLoader.Const_BuffHitPostDelay);
			}
			return this.m_actFrame < this.m_tempActFrame;
		}

		// Token: 0x060088C2 RID: 35010 RVA: 0x0027E640 File Offset: 0x0027C840
		private bool TickAct(ClientActorActTerrainHit act)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TickActClientActorActTerrainHit_hotfix != null)
			{
				return Convert.ToBoolean(this.m_TickActClientActorActTerrainHit_hotfix.call(new object[]
				{
					this,
					act
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_actFrame == 0)
			{
				this.m_heroHealthPoint = act.m_heroHp;
				this.m_soldierTotalHealthPoint = act.m_soldierHp;
				this.UpdateHpAndBuffUI();
				this.m_clientBattle.ClientBattleListener.OnClientActorTerrainHit(this, act.m_terrainInfo, act.m_heroHpModify, act.m_soldierHpModify, act.m_damageNumberType);
				if (act.m_damageNumberType == DamageNumberType.Heal)
				{
					this.PlayIdleAnimation();
				}
				else
				{
					this.PlayAnimation("hurt", false, true);
				}
				if (this.IsDead())
				{
					return false;
				}
				this.UpdateSoldierGraphicCount();
				this.m_tempActFrame = ClientBattle.MillisecondToFrame(this.m_clientBattle.ConfigDataLoader.Const_BuffHitPostDelay);
			}
			return this.m_actFrame < this.m_tempActFrame;
		}

		// Token: 0x060088C3 RID: 35011 RVA: 0x0027E774 File Offset: 0x0027C974
		private bool TickAct(ClientActorActTeleportDisappear act)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TickActClientActorActTeleportDisappear_hotfix != null)
			{
				return Convert.ToBoolean(this.m_TickActClientActorActTeleportDisappear_hotfix.call(new object[]
				{
					this,
					act
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = ClientBattleActor.ComputeSkillCastTime(act.m_skillInfo);
			if (this.m_actFrame == ClientBattle.MillisecondToFrame(num + act.m_skillInfo.Time_EffMagic1))
			{
				this.SetVisible(false);
				this.m_isTeleportDisappear = true;
			}
			return this.m_actFrame != ClientBattle.MillisecondToFrame(num + act.m_skillInfo.Time_EffMagic1 + 500);
		}

		// Token: 0x060088C4 RID: 35012 RVA: 0x0027E850 File Offset: 0x0027CA50
		private bool TickAct(ClientActorActTeleportAppear act)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TickActClientActorActTeleportAppear_hotfix != null)
			{
				return Convert.ToBoolean(this.m_TickActClientActorActTeleportAppear_hotfix.call(new object[]
				{
					this,
					act
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_actFrame == 0)
			{
				this.Locate(act.m_position, this.m_direction);
				this.m_clientBattle.CameraFocusActor(this);
			}
			if (this.m_actFrame == ClientBattle.MillisecondToFrame(act.m_skillInfo.Time_EffMagic2 - act.m_skillInfo.Time_EffMagic1))
			{
				this.SetVisible(true);
				this.m_isTeleportDisappear = false;
				this.PlayAttachFx(act.m_skillInfo.Effect_Magic2);
				this.m_clientBattle.ClientBattleListener.OnClientActorAppear(this);
			}
			if (this.m_actFrame == ClientBattle.MillisecondToFrame(act.m_skillInfo.Time_Hit - act.m_skillInfo.Time_EffMagic1))
			{
				this.PlayAttachFx(act.m_skillInfo.Effect_Hit);
			}
			return this.m_actFrame != ClientBattle.MillisecondToFrame(act.m_skillInfo.Time_Hit - act.m_skillInfo.Time_EffMagic1 + 500);
		}

		// Token: 0x060088C5 RID: 35013 RVA: 0x0027E9B4 File Offset: 0x0027CBB4
		private bool TickAct(ClientActorActSummon act)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TickActClientActorActSummon_hotfix != null)
			{
				return Convert.ToBoolean(this.m_TickActClientActorActSummon_hotfix.call(new object[]
				{
					this,
					act
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = ClientBattleActor.ComputeSkillCastTime(act.m_skillInfo);
			if (this.m_actFrame == ClientBattle.MillisecondToFrame(num + act.m_skillInfo.Time_EffMagic1))
			{
				this.SetVisible(true);
				this.PlayAttachFx(act.m_skillInfo.Effect_Hit);
				this.m_clientBattle.ClientBattleListener.OnClientActorAppear(this);
			}
			return this.m_actFrame != ClientBattle.MillisecondToFrame(num + act.m_skillInfo.Time_EffMagic1 + 500);
		}

		// Token: 0x060088C6 RID: 35014 RVA: 0x0027EAA8 File Offset: 0x0027CCA8
		private bool TickAct(ClientActorActDie act)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TickActClientActorActDie_hotfix != null)
			{
				return Convert.ToBoolean(this.m_TickActClientActorActDie_hotfix.call(new object[]
				{
					this,
					act
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_actFrame == 0)
			{
				this.m_heroHealthPoint = (this.m_soldierTotalHealthPoint = 0);
				this.UpdateHpAndBuffUI();
				this.PlayDeathFx(this.m_battleActor.GetDeathAnimType());
				this.m_clientBattle.ClientBattleListener.OnClientActorDie(this);
			}
			if (this.m_actFrame == ClientBattle.MillisecondToFrame(200))
			{
				this.SetVisible(false);
			}
			if (this.m_actFrame >= ClientBattle.MillisecondToFrame(300))
			{
				base.DeleteMe();
				return false;
			}
			return true;
		}

		// Token: 0x060088C7 RID: 35015 RVA: 0x0027EBA4 File Offset: 0x0027CDA4
		private bool TickAct(ClientActorActAppear act)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TickActClientActorActAppear_hotfix != null)
			{
				return Convert.ToBoolean(this.m_TickActClientActorActAppear_hotfix.call(new object[]
				{
					this,
					act
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_actFrame == 0)
			{
				this.SetVisible(true);
				this.PlayAttachFx(act.m_fxName);
				if (act.m_effectType == 1)
				{
					this.SetGraphicEffect(GraphicEffect.FadeIn, 0.5f, 0f);
				}
				this.m_clientBattle.ClientBattleListener.OnClientActorAppear(this);
			}
			return this.m_actFrame != ClientBattle.MillisecondToFrame(500);
		}

		// Token: 0x060088C8 RID: 35016 RVA: 0x0027EC84 File Offset: 0x0027CE84
		private bool TickAct(ClientActorActDisappear act)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TickActClientActorActDisappear_hotfix != null)
			{
				return Convert.ToBoolean(this.m_TickActClientActorActDisappear_hotfix.call(new object[]
				{
					this,
					act
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_actFrame == 0)
			{
				this.PlayFx(act.m_fxName, this.m_position);
				if (act.m_effectType == 1)
				{
					this.SetGraphicEffect(GraphicEffect.FadeOut, 0.5f, 0f);
				}
				else
				{
					this.SetVisible(false);
				}
			}
			if (this.m_actFrame >= ClientBattle.MillisecondToFrame(500))
			{
				this.SetVisible(false);
				base.DeleteMe();
				return false;
			}
			return true;
		}

		// Token: 0x060088C9 RID: 35017 RVA: 0x0027ED6C File Offset: 0x0027CF6C
		private bool TickAct(ClientActorActChangeTeam act)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TickActClientActorActChangeTeam_hotfix != null)
			{
				return Convert.ToBoolean(this.m_TickActClientActorActChangeTeam_hotfix.call(new object[]
				{
					this,
					act
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_actFrame == 0)
			{
				this.CreateSoldierGraphics();
				this.UpdateGraphicVisible();
				this.PlayIdleAnimation();
				this.Locate(this.m_position, this.m_direction);
				this.SetHpBarType(act.m_team, act.m_isAINpc);
			}
			return this.m_actFrame < ClientBattle.MillisecondToFrame(500);
		}

		// Token: 0x060088CA RID: 35018 RVA: 0x0027EE44 File Offset: 0x0027D044
		private bool TickAct(ClientActorActChangeArmy act)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TickActClientActorActChangeArmy_hotfix != null)
			{
				return Convert.ToBoolean(this.m_TickActClientActorActChangeArmy_hotfix.call(new object[]
				{
					this,
					act
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_actFrame == 0 && this.m_uiController != null)
			{
				this.m_uiController.SetArmyInfo(act.m_heroArmyInfo);
			}
			return false;
		}

		// Token: 0x060088CB RID: 35019 RVA: 0x0027EEF0 File Offset: 0x0027D0F0
		private bool TickAct(ClientActorActReplace act)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TickActClientActorActReplace_hotfix != null)
			{
				return Convert.ToBoolean(this.m_TickActClientActorActReplace_hotfix.call(new object[]
				{
					this,
					act
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_actFrame == 0)
			{
				this.PlayFx(act.m_fxName, this.m_position);
				this.SetVisible(false);
				ClientBattleActor actor = this.m_clientBattle.GetActor(act.m_newActor);
				if (actor != null)
				{
					actor.SetVisible(true);
				}
			}
			if (this.m_actFrame >= ClientBattle.MillisecondToFrame(500))
			{
				base.DeleteMe();
				return false;
			}
			return true;
		}

		// Token: 0x060088CC RID: 35020 RVA: 0x0027EFD0 File Offset: 0x0027D1D0
		private bool TickAct(ClientActorActCameraFocus act)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TickActClientActorActCameraFocus_hotfix != null)
			{
				return Convert.ToBoolean(this.m_TickActClientActorActCameraFocus_hotfix.call(new object[]
				{
					this,
					act
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_actFrame == 0)
			{
				this.m_clientBattle.CameraFocusActor(this);
			}
			return this.m_clientBattle.IsCameraFocusing();
		}

		// Token: 0x060088CD RID: 35021 RVA: 0x0027F078 File Offset: 0x0027D278
		private bool TickAct(ClientActorActGainBattleTreasure act)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TickActClientActorActGainBattleTreasure_hotfix != null)
			{
				return Convert.ToBoolean(this.m_TickActClientActorActGainBattleTreasure_hotfix.call(new object[]
				{
					this,
					act
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_actFrame == 0)
			{
				this.m_clientBattle.StartBattleTreasureDialog(act.m_battleTreasureInfo);
				this.m_tempActFrame = -1;
			}
			if (this.m_tempActFrame < 0 && !this.m_clientBattle.IsWaitBattleTreasureDialog())
			{
				ClientBattleTreasure treasure = this.m_clientBattle.GetTreasure(act.m_battleTreasureInfo);
				if (treasure != null)
				{
					treasure.Open();
				}
				this.m_tempActFrame = this.m_actFrame + ClientBattle.MillisecondToFrame(1500);
			}
			if (this.m_actFrame == this.m_tempActFrame)
			{
				ClientBattleTreasure treasure2 = this.m_clientBattle.GetTreasure(act.m_battleTreasureInfo);
				if (treasure2 != null)
				{
					treasure2.SetOpened(true);
				}
				this.m_clientBattle.StartBattleTreasureReward(act.m_battleTreasureInfo);
			}
			return this.m_tempActFrame <= 0 || this.m_actFrame <= this.m_tempActFrame || this.m_clientBattle.IsWaitBattleTreasureReward();
		}

		// Token: 0x060088CE RID: 35022 RVA: 0x0027F1DC File Offset: 0x0027D3DC
		private bool TickAct(ClientActorActStartGuard act)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TickActClientActorActStartGuard_hotfix != null)
			{
				return Convert.ToBoolean(this.m_TickActClientActorActStartGuard_hotfix.call(new object[]
				{
					this,
					act
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_actFrame == 0)
			{
				this.InitMoveAct(act.m_position, act.m_direction, true, false);
				this.m_isGuarding = true;
				ClientBattleActor actor = this.m_clientBattle.GetActor(act.m_targetActor);
				if (actor != null)
				{
					actor.SetGraphicColor(new Colori(150, 150, 150, byte.MaxValue));
					if (this.m_uiController != null)
					{
						this.m_uiController.transform.SetAsLastSibling();
					}
				}
			}
			if (this.m_actFrame == this.m_tempActFrame)
			{
				ClientBattleActor actor2 = this.m_clientBattle.GetActor(act.m_targetActor);
				if (actor2 != null)
				{
					this.m_clientBattle.ClientBattleListener.OnClientActorGuard(this, actor2);
				}
			}
			return this.m_actFrame < this.m_tempActFrame + ClientBattle.MillisecondToFrame(800);
		}

		// Token: 0x060088CF RID: 35023 RVA: 0x0027F330 File Offset: 0x0027D530
		private bool TickAct(ClientActorActStopGuard act)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TickActClientActorActStopGuard_hotfix != null)
			{
				return Convert.ToBoolean(this.m_TickActClientActorActStopGuard_hotfix.call(new object[]
				{
					this,
					act
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_actFrame == 0)
			{
				this.m_tempActFrame = -1;
			}
			if (this.m_actFrame == ClientBattle.MillisecondToFrame(300))
			{
				this.InitMoveAct(act.m_position, act.m_direction, true, true);
				this.m_tempActFrame += this.m_actFrame;
				ClientBattleActor actor = this.m_clientBattle.GetActor(act.m_targetActor);
				if (actor != null)
				{
					actor.SetGraphicActionFinishedEffect(this.m_isActionFinishedGray);
				}
			}
			if (this.m_tempActFrame >= 0 && this.m_actFrame >= this.m_tempActFrame)
			{
				this.m_isGuarding = false;
				return false;
			}
			return true;
		}

		// Token: 0x060088D0 RID: 35024 RVA: 0x0027F448 File Offset: 0x0027D648
		private bool TickAct(ClientActorActBeforeStartCombat act)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TickActClientActorActBeforeStartCombat_hotfix != null)
			{
				return Convert.ToBoolean(this.m_TickActClientActorActBeforeStartCombat_hotfix.call(new object[]
				{
					this,
					act
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_actFrame == 0)
			{
				this.m_direction = act.m_direction;
			}
			return false;
		}

		// Token: 0x060088D1 RID: 35025 RVA: 0x0027F4DC File Offset: 0x0027D6DC
		private bool TickAct(ClientNullActorActCancelCombat act)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TickActClientNullActorActCancelCombat_hotfix != null)
			{
				return Convert.ToBoolean(this.m_TickActClientNullActorActCancelCombat_hotfix.call(new object[]
				{
					this,
					act
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_actFrame == 0)
			{
				this.m_clientBattle.ClientBattleListener.OnCancelCombat();
			}
			return false;
		}

		// Token: 0x060088D2 RID: 35026 RVA: 0x0027F574 File Offset: 0x0027D774
		private bool TickAct(ClientActorActStartCombat act)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TickActClientActorActStartCombat_hotfix != null)
			{
				return Convert.ToBoolean(this.m_TickActClientActorActStartCombat_hotfix.call(new object[]
				{
					this,
					act
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_actFrame == 0)
			{
				this.m_direction = act.m_direction;
				if (this.HasFightTag(FightTag.FightTag_Stun))
				{
					this.PlayAnimation("stun", true, true);
				}
				else
				{
					this.PlayAnimation("run", true, true);
				}
				this.m_clientBattle.OnActorPreStartCombat(this);
			}
			return this.m_actFrame < ClientBattle.MillisecondToFrame(700);
		}

		// Token: 0x060088D3 RID: 35027 RVA: 0x0027F658 File Offset: 0x0027D858
		private bool TickAct(ClientActorActStopCombat act)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TickActClientActorActStopCombat_hotfix != null)
			{
				return Convert.ToBoolean(this.m_TickActClientActorActStopCombat_hotfix.call(new object[]
				{
					this,
					act
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_actFrame == 0)
			{
				if (this.m_isIdleRun)
				{
					this.StopIdleRun();
				}
				this.PlayIdleAnimation();
			}
			if (this.m_actFrame >= ClientBattle.MillisecondToFrame(300))
			{
				this.m_heroHealthPoint = act.m_heroHp;
				this.m_soldierTotalHealthPoint = act.m_soldierHp;
				this.UpdateHpAndBuffUI();
				this.UpdateSoldierGraphicCount();
				this.m_clientBattle.OnActorStopCombatEnd(this);
				return false;
			}
			return true;
		}

		// Token: 0x060088D4 RID: 35028 RVA: 0x0027F740 File Offset: 0x0027D940
		private bool TickAct(ClientNullActorActStartBattle act)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TickActClientNullActorActStartBattle_hotfix != null)
			{
				return Convert.ToBoolean(this.m_TickActClientNullActorActStartBattle_hotfix.call(new object[]
				{
					this,
					act
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_actFrame == 0)
			{
				this.m_clientBattle.ClientBattleListener.OnStartBattle();
			}
			int ms = this.m_clientBattle.ConfigDataLoader.UtilityGetConfigableConst(ConfigableConstId.ConfigableConstId_Battle_StartDelay);
			return this.m_actFrame < ClientBattle.MillisecondToFrame(ms);
		}

		// Token: 0x060088D5 RID: 35029 RVA: 0x0027F800 File Offset: 0x0027DA00
		private bool TickAct(ClientNullActorActBattleWinCondition act)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TickActClientNullActorActBattleWinCondition_hotfix != null)
			{
				return Convert.ToBoolean(this.m_TickActClientNullActorActBattleWinCondition_hotfix.call(new object[]
				{
					this,
					act
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_actFrame == 0)
			{
				this.m_tempActFrame = -1;
				this.m_clientBattle.CameraFocusPosition(act.m_targetPosition);
				this.m_clientBattle.ClientBattleListener.OnShowBattleWinCondition(act.m_winConditionInfo, act.m_targetPosition);
			}
			if (this.m_tempActFrame < 0)
			{
				if (!this.m_clientBattle.IsCameraFocusing())
				{
					this.m_tempActFrame = this.m_actFrame + ClientBattle.MillisecondToFrame(1000);
				}
			}
			else if (this.m_tempActFrame > 0 && this.m_actFrame > this.m_tempActFrame)
			{
				this.m_clientBattle.ClientBattleListener.OnHideBattleWinCondition(act.m_winConditionInfo, act.m_targetPosition);
				return false;
			}
			return true;
		}

		// Token: 0x060088D6 RID: 35030 RVA: 0x0027F930 File Offset: 0x0027DB30
		private bool TickAct(ClientNullActorActBattleLoseCondition act)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TickActClientNullActorActBattleLoseCondition_hotfix != null)
			{
				return Convert.ToBoolean(this.m_TickActClientNullActorActBattleLoseCondition_hotfix.call(new object[]
				{
					this,
					act
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_actFrame == 0)
			{
				this.m_tempActFrame = -1;
				this.m_clientBattle.CameraFocusPosition(act.m_targetPosition);
				this.m_clientBattle.ClientBattleListener.OnShowBattleLoseCondition(act.m_loseConditionInfo, act.m_targetPosition);
			}
			if (this.m_tempActFrame < 0)
			{
				if (!this.m_clientBattle.IsCameraFocusing())
				{
					this.m_tempActFrame = this.m_actFrame + ClientBattle.MillisecondToFrame(1000);
				}
			}
			else if (this.m_tempActFrame > 0 && this.m_actFrame > this.m_tempActFrame)
			{
				this.m_clientBattle.ClientBattleListener.OnHideBattleLoseCondition(act.m_loseConditionInfo, act.m_targetPosition);
				return false;
			}
			return true;
		}

		// Token: 0x060088D7 RID: 35031 RVA: 0x0027FA60 File Offset: 0x0027DC60
		private bool TickAct(ClientNullActorActNextTurn act)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TickActClientNullActorActNextTurn_hotfix != null)
			{
				return Convert.ToBoolean(this.m_TickActClientNullActorActNextTurn_hotfix.call(new object[]
				{
					this,
					act
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_actFrame == 0)
			{
				this.m_clientBattle.ClientBattleListener.OnNextTurn(act.m_turn);
			}
			int ms = this.m_clientBattle.ConfigDataLoader.UtilityGetConfigableConst(ConfigableConstId.ConfigableConstId_Battle_NextTurnTime);
			if (this.m_actFrame >= ClientBattle.MillisecondToFrame(ms))
			{
				this.m_clientBattle.ClientBattleListener.OnNextTurnAnimationEnd(act.m_turn);
				return false;
			}
			return true;
		}

		// Token: 0x060088D8 RID: 35032 RVA: 0x0027FB3C File Offset: 0x0027DD3C
		private bool TickAct(ClientNullActorActNextTeam act)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TickActClientNullActorActNextTeam_hotfix != null)
			{
				return Convert.ToBoolean(this.m_TickActClientNullActorActNextTeam_hotfix.call(new object[]
				{
					this,
					act
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_actFrame == 0)
			{
				this.m_clientBattle.ClientBattleListener.OnNextTeam(act.m_team);
				this.m_tempActFrame = 0;
				if (act.m_team != this.m_clientBattle.GetMyPlayerTeamNumber())
				{
					this.m_clientBattle.CameraFocusActor(act.m_focusActor);
					int ms = this.m_clientBattle.ConfigDataLoader.UtilityGetConfigableConst(ConfigableConstId.ConfigableConstId_Battle_NextTeamTime);
					this.m_tempActFrame = ClientBattle.MillisecondToFrame(ms);
				}
			}
			return this.m_actFrame < this.m_tempActFrame;
		}

		// Token: 0x060088D9 RID: 35033 RVA: 0x0027FC3C File Offset: 0x0027DE3C
		private bool TickAct(ClientNullActorActNextPlayer act)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TickActClientNullActorActNextPlayer_hotfix != null)
			{
				return Convert.ToBoolean(this.m_TickActClientNullActorActNextPlayer_hotfix.call(new object[]
				{
					this,
					act
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_actFrame == 0)
			{
				this.m_clientBattle.ClientBattleListener.OnNextPlayer(act.m_playerIndex);
				this.m_tempActFrame = 0;
				if (act.m_playerIndex >= 0)
				{
					this.m_clientBattle.CameraFocusActor(act.m_focusActor);
					int ms = this.m_clientBattle.ConfigDataLoader.UtilityGetConfigableConst(ConfigableConstId.ConfigableConstId_Battle_NextPlayerTime);
					this.m_tempActFrame = ClientBattle.MillisecondToFrame(ms);
				}
			}
			return this.m_actFrame < this.m_tempActFrame;
		}

		// Token: 0x060088DA RID: 35034 RVA: 0x0027FD30 File Offset: 0x0027DF30
		private bool TickAct(ClientNullActorActNextActor act)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TickActClientNullActorActNextActor_hotfix != null)
			{
				return Convert.ToBoolean(this.m_TickActClientNullActorActNextActor_hotfix.call(new object[]
				{
					this,
					act
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_actFrame == 0)
			{
				this.m_clientBattle.ClientBattleListener.OnNextActor(act.m_nextActor);
			}
			return false;
		}

		// Token: 0x060088DB RID: 35035 RVA: 0x0027FDD0 File Offset: 0x0027DFD0
		private bool TickAct(ClientNullActorActFastCombat act)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TickActClientNullActorActFastCombat_hotfix != null)
			{
				return Convert.ToBoolean(this.m_TickActClientNullActorActFastCombat_hotfix.call(new object[]
				{
					this,
					act
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_actFrame == 0)
			{
				this.m_clientBattle.StartFastCombat(act.m_fastCombatActorInfoA, act.m_fastCombatActorInfoB);
			}
			return this.m_clientBattle.IsWaitFastCombat();
		}

		// Token: 0x060088DC RID: 35036 RVA: 0x0027FE84 File Offset: 0x0027E084
		private bool TickAct(ClientNullActorActBattleDialog act)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TickActClientNullActorActBattleDialog_hotfix != null)
			{
				return Convert.ToBoolean(this.m_TickActClientNullActorActBattleDialog_hotfix.call(new object[]
				{
					this,
					act
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_actFrame == 0)
			{
				this.m_clientBattle.StartBattleDialog(act.m_battleDialogInfo);
			}
			return this.m_clientBattle.IsWaitBattleDialog();
		}

		// Token: 0x060088DD RID: 35037 RVA: 0x0027FF30 File Offset: 0x0027E130
		private bool TickAct(ClientNullActorActStartBattlePerform act)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TickActClientNullActorActStartBattlePerform_hotfix != null)
			{
				return Convert.ToBoolean(this.m_TickActClientNullActorActStartBattlePerform_hotfix.call(new object[]
				{
					this,
					act
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_clientBattle.StartBattlePerform();
			return false;
		}

		// Token: 0x060088DE RID: 35038 RVA: 0x0027FFB8 File Offset: 0x0027E1B8
		private bool TickAct(ClientNullActorActStopBattlePerform act)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TickActClientNullActorActStopBattlePerform_hotfix != null)
			{
				return Convert.ToBoolean(this.m_TickActClientNullActorActStopBattlePerform_hotfix.call(new object[]
				{
					this,
					act
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_clientBattle.StopBattlePerform();
			return false;
		}

		// Token: 0x060088DF RID: 35039 RVA: 0x00280040 File Offset: 0x0027E240
		private bool TickAct(ClientNullActorActChangeMapTerrain act)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TickActClientNullActorActChangeMapTerrain_hotfix != null)
			{
				return Convert.ToBoolean(this.m_TickActClientNullActorActChangeMapTerrain_hotfix.call(new object[]
				{
					this,
					act
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_actFrame == 0)
			{
				this.m_clientBattle.ChangeMapTerrainFx(act.m_position, act.m_terrainInfo);
			}
			return false;
		}

		// Token: 0x060088E0 RID: 35040 RVA: 0x002800E0 File Offset: 0x0027E2E0
		private bool TickAct(ClientNullActorActCameraFocus act)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TickActClientNullActorActCameraFocus_hotfix != null)
			{
				return Convert.ToBoolean(this.m_TickActClientNullActorActCameraFocus_hotfix.call(new object[]
				{
					this,
					act
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_actFrame == 0)
			{
				this.m_clientBattle.CameraFocusPosition(act.m_position);
			}
			return this.m_clientBattle.IsCameraFocusing();
		}

		// Token: 0x060088E1 RID: 35041 RVA: 0x0028018C File Offset: 0x0027E38C
		private bool TickAct(ClientNullActorActPlayMusic act)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TickActClientNullActorActPlayMusic_hotfix != null)
			{
				return Convert.ToBoolean(this.m_TickActClientNullActorActPlayMusic_hotfix.call(new object[]
				{
					this,
					act
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_actFrame == 0)
			{
				AudioUtility.PlaySound(act.m_musicName);
			}
			return false;
		}

		// Token: 0x060088E2 RID: 35042 RVA: 0x00280220 File Offset: 0x0027E420
		private bool TickAct(ClientNullActorActPlaySound act)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TickActClientNullActorActPlaySound_hotfix != null)
			{
				return Convert.ToBoolean(this.m_TickActClientNullActorActPlaySound_hotfix.call(new object[]
				{
					this,
					act
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_actFrame == 0)
			{
				this.PlaySound(act.m_soundName);
			}
			return false;
		}

		// Token: 0x060088E3 RID: 35043 RVA: 0x002802B4 File Offset: 0x0027E4B4
		private bool TickAct(ClientNullActorActPlayFx act)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TickActClientNullActorActPlayFx_hotfix != null)
			{
				return Convert.ToBoolean(this.m_TickActClientNullActorActPlayFx_hotfix.call(new object[]
				{
					this,
					act
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_actFrame == 0)
			{
				this.PlayFx(act.m_fxName, act.m_position);
			}
			return false;
		}

		// Token: 0x060088E4 RID: 35044 RVA: 0x00280350 File Offset: 0x0027E550
		private bool TickAct(ClientNullActorActWaitTime act)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TickActClientNullActorActWaitTime_hotfix != null)
			{
				return Convert.ToBoolean(this.m_TickActClientNullActorActWaitTime_hotfix.call(new object[]
				{
					this,
					act
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_actFrame < ClientBattle.MillisecondToFrame(act.m_time);
		}

		// Token: 0x17001CCB RID: 7371
		// (get) Token: 0x060088E5 RID: 35045 RVA: 0x002803E8 File Offset: 0x0027E5E8
		// (set) Token: 0x060088E6 RID: 35046 RVA: 0x00280408 File Offset: 0x0027E608
		[DoNotToLua]
		public new ClientBattleActor.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new ClientBattleActor.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x060088E7 RID: 35047 RVA: 0x00280414 File Offset: 0x0027E614
		private void __callBase_Dispose()
		{
			base.Dispose();
		}

		// Token: 0x060088E8 RID: 35048 RVA: 0x0028041C File Offset: 0x0027E61C
		private void __callBase_Tick()
		{
			base.Tick();
		}

		// Token: 0x060088E9 RID: 35049 RVA: 0x00280424 File Offset: 0x0027E624
		private void __callBase_TickGraphic(float dt)
		{
			base.TickGraphic(dt);
		}

		// Token: 0x060088EA RID: 35050 RVA: 0x00280430 File Offset: 0x0027E630
		private void __callBase_Draw()
		{
			base.Draw();
		}

		// Token: 0x060088EB RID: 35051 RVA: 0x00280438 File Offset: 0x0027E638
		private void __callBase_Pause(bool pause)
		{
			base.Pause(pause);
		}

		// Token: 0x060088EC RID: 35052 RVA: 0x00280444 File Offset: 0x0027E644
		private void __callBase_DoPause(bool pause)
		{
			base.DoPause(pause);
		}

		// Token: 0x060088ED RID: 35053 RVA: 0x00280450 File Offset: 0x0027E650
		private void __callBase_DeleteMe()
		{
			base.DeleteMe();
		}

		// Token: 0x060088EE RID: 35054 RVA: 0x00280458 File Offset: 0x0027E658
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
					this.m_ctor_hotfix = (luaObj.RawGet("ctor") as LuaFunction);
					this.m_InitializeClientBattleBattleActor_hotfix = (luaObj.RawGet("Initialize") as LuaFunction);
					this.m_InitializeEnd_hotfix = (luaObj.RawGet("InitializeEnd") as LuaFunction);
					this.m_PostRebuildBattle_hotfix = (luaObj.RawGet("PostRebuildBattle") as LuaFunction);
					this.m_CreateHeroGraphic_hotfix = (luaObj.RawGet("CreateHeroGraphic") as LuaFunction);
					this.m_CreateSoldierGraphics_hotfix = (luaObj.RawGet("CreateSoldierGraphics") as LuaFunction);
					this.m_Dispose_hotfix = (luaObj.RawGet("Dispose") as LuaFunction);
					this.m_Tick_hotfix = (luaObj.RawGet("Tick") as LuaFunction);
					this.m_TickGraphicSingle_hotfix = (luaObj.RawGet("TickGraphic") as LuaFunction);
					this.m_ComputeGraphicPositionVector2Single_hotfix = (luaObj.RawGet("ComputeGraphicPosition") as LuaFunction);
					this.m_Draw_hotfix = (luaObj.RawGet("Draw") as LuaFunction);
					this.m_DoPauseBoolean_hotfix = (luaObj.RawGet("DoPause") as LuaFunction);
					this.m_IsDead_hotfix = (luaObj.RawGet("IsDead") as LuaFunction);
					this.m_GetTotalHealthPoint_hotfix = (luaObj.RawGet("GetTotalHealthPoint") as LuaFunction);
					this.m_GetTotalHealthPointMax_hotfix = (luaObj.RawGet("GetTotalHealthPointMax") as LuaFunction);
					this.m_HasFightTagFightTag_hotfix = (luaObj.RawGet("HasFightTag") as LuaFunction);
					this.m_LocateGridPositionInt32_hotfix = (luaObj.RawGet("Locate") as LuaFunction);
					this.m_FaceToGridPosition_hotfix = (luaObj.RawGet("FaceTo") as LuaFunction);
					this.m_AddActClientActorAct_hotfix = (luaObj.RawGet("AddAct") as LuaFunction);
					this.m_HasAct_hotfix = (luaObj.RawGet("HasAct") as LuaFunction);
					this.m_PlayAnimationStringBooleanBoolean_hotfix = (luaObj.RawGet("PlayAnimation") as LuaFunction);
					this.m_GetHeroAnimationDurationString_hotfix = (luaObj.RawGet("GetHeroAnimationDuration") as LuaFunction);
					this.m_IsHeroPlayAnimation_hotfix = (luaObj.RawGet("IsHeroPlayAnimation") as LuaFunction);
					this.m_PlayDeathFxInt32_hotfix = (luaObj.RawGet("PlayDeathFx") as LuaFunction);
					this.m_PlayIdleAnimation_hotfix = (luaObj.RawGet("PlayIdleAnimation") as LuaFunction);
					this.m_PlayHeroFxString_hotfix = (luaObj.RawGet("PlayHeroFx") as LuaFunction);
					this.m_PlayFxStringGridPosition_hotfix = (luaObj.RawGet("PlayFx") as LuaFunction);
					this.m_PlayAttachFxString_hotfix = (luaObj.RawGet("PlayAttachFx") as LuaFunction);
					this.m_ClearAttachFx_hotfix = (luaObj.RawGet("ClearAttachFx") as LuaFunction);
					this.m_SetGraphicEffectGraphicEffectSingleSingle_hotfix = (luaObj.RawGet("SetGraphicEffect") as LuaFunction);
					this.m_ClearGraphicEffectGraphicEffect_hotfix = (luaObj.RawGet("ClearGraphicEffect") as LuaFunction);
					this.m_PlaySoundString_hotfix = (luaObj.RawGet("PlaySound") as LuaFunction);
					this.m_PlaySoundSoundTableId_hotfix = (luaObj.RawGet("PlaySound") as LuaFunction);
					this.m_SetGraphicActionFinishedEffectBoolean_hotfix = (luaObj.RawGet("SetGraphicActionFinishedEffect") as LuaFunction);
					this.m_SetGraphicColorColori_hotfix = (luaObj.RawGet("SetGraphicColor") as LuaFunction);
					this.m_AttachBuffBuffState_hotfix = (luaObj.RawGet("AttachBuff") as LuaFunction);
					this.m_DetachBuffBuffState_hotfix = (luaObj.RawGet("DetachBuff") as LuaFunction);
					this.m_SetHpBarTypeInt32Boolean_hotfix = (luaObj.RawGet("SetHpBarType") as LuaFunction);
					this.m_StartIdleRun_hotfix = (luaObj.RawGet("StartIdleRun") as LuaFunction);
					this.m_StopIdleRun_hotfix = (luaObj.RawGet("StopIdleRun") as LuaFunction);
					this.m_CancelTeleportDisappear_hotfix = (luaObj.RawGet("CancelTeleportDisappear") as LuaFunction);
					this.m_SetVisibleBoolean_hotfix = (luaObj.RawGet("SetVisible") as LuaFunction);
					this.m_IsVisible_hotfix = (luaObj.RawGet("IsVisible") as LuaFunction);
					this.m_ComputeSoldierGraphicCount_hotfix = (luaObj.RawGet("ComputeSoldierGraphicCount") as LuaFunction);
					this.m_UpdateSoldierGraphicCount_hotfix = (luaObj.RawGet("UpdateSoldierGraphicCount") as LuaFunction);
					this.m_GetSoldierGraphicCount_hotfix = (luaObj.RawGet("GetSoldierGraphicCount") as LuaFunction);
					this.m_UpdateGraphicVisible_hotfix = (luaObj.RawGet("UpdateGraphicVisible") as LuaFunction);
					this.m_ComputeGraphicOffsetInt32_hotfix = (luaObj.RawGet("ComputeGraphicOffset") as LuaFunction);
					this.m_GetGraphicInt32_hotfix = (luaObj.RawGet("GetGraphic") as LuaFunction);
					this.m_GetGraphicPosition_hotfix = (luaObj.RawGet("GetGraphicPosition") as LuaFunction);
					this.m_SetGraphicSkillFadeBoolean_hotfix = (luaObj.RawGet("SetGraphicSkillFade") as LuaFunction);
					this.m_IsGraphicSkillFade_hotfix = (luaObj.RawGet("IsGraphicSkillFade") as LuaFunction);
					this.m_UpdateHpAndBuffUI_hotfix = (luaObj.RawGet("UpdateHpAndBuffUI") as LuaFunction);
					this.m_ShowPlayerIndexBoolean_hotfix = (luaObj.RawGet("ShowPlayerIndex") as LuaFunction);
					this.m_get_Position_hotfix = (luaObj.RawGet("get_Position") as LuaFunction);
					this.m_get_Direction_hotfix = (luaObj.RawGet("get_Direction") as LuaFunction);
					this.m_get_BattleActor_hotfix = (luaObj.RawGet("get_BattleActor") as LuaFunction);
					this.m_get_TeamNumber_hotfix = (luaObj.RawGet("get_TeamNumber") as LuaFunction);
					this.m_get_HeroHealthPoint_hotfix = (luaObj.RawGet("get_HeroHealthPoint") as LuaFunction);
					this.m_get_SoldierTotalHealthPoint_hotfix = (luaObj.RawGet("get_SoldierTotalHealthPoint") as LuaFunction);
					this.m_TickActClientActorAct_hotfix = (luaObj.RawGet("TickAct") as LuaFunction);
					this.m_TickActClientActorActActive_hotfix = (luaObj.RawGet("TickAct") as LuaFunction);
					this.m_TickActClientActorActActionBegin_hotfix = (luaObj.RawGet("TickAct") as LuaFunction);
					this.m_TickActClientActorActActionEnd_hotfix = (luaObj.RawGet("TickAct") as LuaFunction);
					this.m_InitMoveActGridPositionInt32BooleanBoolean_hotfix = (luaObj.RawGet("InitMoveAct") as LuaFunction);
					this.m_ComputeMoveTimeGridPositionGridPosition_hotfix = (luaObj.RawGet("ComputeMoveTime") as LuaFunction);
					this.m_TickActClientActorActMove_hotfix = (luaObj.RawGet("TickAct") as LuaFunction);
					this.m_TickActClientActorActTryMove_hotfix = (luaObj.RawGet("TickAct") as LuaFunction);
					this.m_TickActClientActorActPerformMove_hotfix = (luaObj.RawGet("TickAct") as LuaFunction);
					this.m_TickActClientActorActPunchMove_hotfix = (luaObj.RawGet("TickAct") as LuaFunction);
					this.m_TickActClientActorActExchangeMove_hotfix = (luaObj.RawGet("TickAct") as LuaFunction);
					this.m_TickActClientActorActSetDir_hotfix = (luaObj.RawGet("TickAct") as LuaFunction);
					this.m_TickActClientActorActPlayFx_hotfix = (luaObj.RawGet("TickAct") as LuaFunction);
					this.m_TickActClientActorActPlayAnimation_hotfix = (luaObj.RawGet("TickAct") as LuaFunction);
					this.m_TickActClientActorActChangeIdleAnimation_hotfix = (luaObj.RawGet("TickAct") as LuaFunction);
					this.m_TickActClientActorActTarget_hotfix = (luaObj.RawGet("TickAct") as LuaFunction);
					this.m_TickActClientActorActSkill_hotfix = (luaObj.RawGet("TickAct") as LuaFunction);
					this.m_TickActClientActorActSkillHit_hotfix = (luaObj.RawGet("TickAct") as LuaFunction);
					this.m_TickSkillHitsConfigDataSkillInfoList`1_hotfix = (luaObj.RawGet("TickSkillHits") as LuaFunction);
					this.m_TickActClientActorActAttachBuff_hotfix = (luaObj.RawGet("TickAct") as LuaFunction);
					this.m_TickActClientActorActDetachBuff_hotfix = (luaObj.RawGet("TickAct") as LuaFunction);
					this.m_TickActClientActorActImmune_hotfix = (luaObj.RawGet("TickAct") as LuaFunction);
					this.m_TickActClientActorActPassiveSkill_hotfix = (luaObj.RawGet("TickAct") as LuaFunction);
					this.m_TickActClientActorActPassiveSkillHit_hotfix = (luaObj.RawGet("TickAct") as LuaFunction);
					this.m_TickActClientActorActBuffHit_hotfix = (luaObj.RawGet("TickAct") as LuaFunction);
					this.m_TickActClientActorActTerrainHit_hotfix = (luaObj.RawGet("TickAct") as LuaFunction);
					this.m_TickActClientActorActTeleportDisappear_hotfix = (luaObj.RawGet("TickAct") as LuaFunction);
					this.m_TickActClientActorActTeleportAppear_hotfix = (luaObj.RawGet("TickAct") as LuaFunction);
					this.m_TickActClientActorActSummon_hotfix = (luaObj.RawGet("TickAct") as LuaFunction);
					this.m_TickActClientActorActDie_hotfix = (luaObj.RawGet("TickAct") as LuaFunction);
					this.m_TickActClientActorActAppear_hotfix = (luaObj.RawGet("TickAct") as LuaFunction);
					this.m_TickActClientActorActDisappear_hotfix = (luaObj.RawGet("TickAct") as LuaFunction);
					this.m_TickActClientActorActChangeTeam_hotfix = (luaObj.RawGet("TickAct") as LuaFunction);
					this.m_TickActClientActorActChangeArmy_hotfix = (luaObj.RawGet("TickAct") as LuaFunction);
					this.m_TickActClientActorActReplace_hotfix = (luaObj.RawGet("TickAct") as LuaFunction);
					this.m_TickActClientActorActCameraFocus_hotfix = (luaObj.RawGet("TickAct") as LuaFunction);
					this.m_TickActClientActorActGainBattleTreasure_hotfix = (luaObj.RawGet("TickAct") as LuaFunction);
					this.m_TickActClientActorActStartGuard_hotfix = (luaObj.RawGet("TickAct") as LuaFunction);
					this.m_TickActClientActorActStopGuard_hotfix = (luaObj.RawGet("TickAct") as LuaFunction);
					this.m_TickActClientActorActBeforeStartCombat_hotfix = (luaObj.RawGet("TickAct") as LuaFunction);
					this.m_TickActClientNullActorActCancelCombat_hotfix = (luaObj.RawGet("TickAct") as LuaFunction);
					this.m_TickActClientActorActStartCombat_hotfix = (luaObj.RawGet("TickAct") as LuaFunction);
					this.m_TickActClientActorActStopCombat_hotfix = (luaObj.RawGet("TickAct") as LuaFunction);
					this.m_TickActClientNullActorActStartBattle_hotfix = (luaObj.RawGet("TickAct") as LuaFunction);
					this.m_TickActClientNullActorActBattleWinCondition_hotfix = (luaObj.RawGet("TickAct") as LuaFunction);
					this.m_TickActClientNullActorActBattleLoseCondition_hotfix = (luaObj.RawGet("TickAct") as LuaFunction);
					this.m_TickActClientNullActorActNextTurn_hotfix = (luaObj.RawGet("TickAct") as LuaFunction);
					this.m_TickActClientNullActorActNextTeam_hotfix = (luaObj.RawGet("TickAct") as LuaFunction);
					this.m_TickActClientNullActorActNextPlayer_hotfix = (luaObj.RawGet("TickAct") as LuaFunction);
					this.m_TickActClientNullActorActNextActor_hotfix = (luaObj.RawGet("TickAct") as LuaFunction);
					this.m_TickActClientNullActorActFastCombat_hotfix = (luaObj.RawGet("TickAct") as LuaFunction);
					this.m_TickActClientNullActorActBattleDialog_hotfix = (luaObj.RawGet("TickAct") as LuaFunction);
					this.m_TickActClientNullActorActStartBattlePerform_hotfix = (luaObj.RawGet("TickAct") as LuaFunction);
					this.m_TickActClientNullActorActStopBattlePerform_hotfix = (luaObj.RawGet("TickAct") as LuaFunction);
					this.m_TickActClientNullActorActChangeMapTerrain_hotfix = (luaObj.RawGet("TickAct") as LuaFunction);
					this.m_TickActClientNullActorActCameraFocus_hotfix = (luaObj.RawGet("TickAct") as LuaFunction);
					this.m_TickActClientNullActorActPlayMusic_hotfix = (luaObj.RawGet("TickAct") as LuaFunction);
					this.m_TickActClientNullActorActPlaySound_hotfix = (luaObj.RawGet("TickAct") as LuaFunction);
					this.m_TickActClientNullActorActPlayFx_hotfix = (luaObj.RawGet("TickAct") as LuaFunction);
					this.m_TickActClientNullActorActWaitTime_hotfix = (luaObj.RawGet("TickAct") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x060088EF RID: 35055 RVA: 0x002810C4 File Offset: 0x0027F2C4
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ClientBattleActor));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04006112 RID: 24850
		private ClientBattle m_clientBattle;

		// Token: 0x04006113 RID: 24851
		private BattleActor m_battleActor;

		// Token: 0x04006114 RID: 24852
		private int m_heroHealthPoint;

		// Token: 0x04006115 RID: 24853
		private int m_soldierTotalHealthPoint;

		// Token: 0x04006116 RID: 24854
		private int m_heroHealthPointMax;

		// Token: 0x04006117 RID: 24855
		private int m_soldierTotalHealthPointMax;

		// Token: 0x04006118 RID: 24856
		private uint m_fightTags;

		// Token: 0x04006119 RID: 24857
		private ClientBattleActor.GraphicState[] m_graphicStates;

		// Token: 0x0400611A RID: 24858
		private int m_soldierGraphicCount;

		// Token: 0x0400611B RID: 24859
		private Vector2 m_graphicPosition;

		// Token: 0x0400611C RID: 24860
		private bool m_isGraphicSkillFade;

		// Token: 0x0400611D RID: 24861
		private bool m_isActionFinishedGray;

		// Token: 0x0400611E RID: 24862
		private BattleActorUIController m_uiController;

		// Token: 0x0400611F RID: 24863
		private List<ClientActorBuff> m_buffs;

		// Token: 0x04006120 RID: 24864
		private List<GenericGraphic> m_attachFxs;

		// Token: 0x04006121 RID: 24865
		private GridPosition m_position;

		// Token: 0x04006122 RID: 24866
		private int m_direction;

		// Token: 0x04006123 RID: 24867
		private bool m_isVisible;

		// Token: 0x04006124 RID: 24868
		private bool m_isIdleRun;

		// Token: 0x04006125 RID: 24869
		private bool m_isGuarding;

		// Token: 0x04006126 RID: 24870
		private bool m_isTeleportDisappear;

		// Token: 0x04006127 RID: 24871
		private string m_idleAnimationName;

		// Token: 0x04006128 RID: 24872
		private List<ClientActorAct> m_acts;

		// Token: 0x04006129 RID: 24873
		private int m_actFrame;

		// Token: 0x0400612A RID: 24874
		private int m_tempActFrame;

		// Token: 0x0400612B RID: 24875
		private int m_deleteMeCountdown;

		// Token: 0x0400612C RID: 24876
		[DoNotToLua]
		private ClientBattleActor.LuaExportHelper luaExportHelper;

		// Token: 0x0400612D RID: 24877
		[CompilerGenerated]
		private static Comparison<ClientActorBuff> <>f__mg$cache0;

		// Token: 0x0400612E RID: 24878
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400612F RID: 24879
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04006130 RID: 24880
		private LuaFunction m_ctor_hotfix;

		// Token: 0x04006131 RID: 24881
		private LuaFunction m_InitializeClientBattleBattleActor_hotfix;

		// Token: 0x04006132 RID: 24882
		private LuaFunction m_InitializeEnd_hotfix;

		// Token: 0x04006133 RID: 24883
		private LuaFunction m_PostRebuildBattle_hotfix;

		// Token: 0x04006134 RID: 24884
		private LuaFunction m_CreateHeroGraphic_hotfix;

		// Token: 0x04006135 RID: 24885
		private LuaFunction m_CreateSoldierGraphics_hotfix;

		// Token: 0x04006136 RID: 24886
		private LuaFunction m_Dispose_hotfix;

		// Token: 0x04006137 RID: 24887
		private LuaFunction m_Tick_hotfix;

		// Token: 0x04006138 RID: 24888
		private LuaFunction m_TickGraphicSingle_hotfix;

		// Token: 0x04006139 RID: 24889
		private LuaFunction m_ComputeGraphicPositionVector2Single_hotfix;

		// Token: 0x0400613A RID: 24890
		private LuaFunction m_Draw_hotfix;

		// Token: 0x0400613B RID: 24891
		private LuaFunction m_DoPauseBoolean_hotfix;

		// Token: 0x0400613C RID: 24892
		private LuaFunction m_IsDead_hotfix;

		// Token: 0x0400613D RID: 24893
		private LuaFunction m_GetTotalHealthPoint_hotfix;

		// Token: 0x0400613E RID: 24894
		private LuaFunction m_GetTotalHealthPointMax_hotfix;

		// Token: 0x0400613F RID: 24895
		private LuaFunction m_HasFightTagFightTag_hotfix;

		// Token: 0x04006140 RID: 24896
		private LuaFunction m_LocateGridPositionInt32_hotfix;

		// Token: 0x04006141 RID: 24897
		private LuaFunction m_FaceToGridPosition_hotfix;

		// Token: 0x04006142 RID: 24898
		private LuaFunction m_AddActClientActorAct_hotfix;

		// Token: 0x04006143 RID: 24899
		private LuaFunction m_HasAct_hotfix;

		// Token: 0x04006144 RID: 24900
		private LuaFunction m_PlayAnimationStringBooleanBoolean_hotfix;

		// Token: 0x04006145 RID: 24901
		private LuaFunction m_GetHeroAnimationDurationString_hotfix;

		// Token: 0x04006146 RID: 24902
		private LuaFunction m_IsHeroPlayAnimation_hotfix;

		// Token: 0x04006147 RID: 24903
		private LuaFunction m_PlayDeathFxInt32_hotfix;

		// Token: 0x04006148 RID: 24904
		private LuaFunction m_PlayIdleAnimation_hotfix;

		// Token: 0x04006149 RID: 24905
		private LuaFunction m_PlayHeroFxString_hotfix;

		// Token: 0x0400614A RID: 24906
		private LuaFunction m_PlayFxStringGridPosition_hotfix;

		// Token: 0x0400614B RID: 24907
		private LuaFunction m_PlayAttachFxString_hotfix;

		// Token: 0x0400614C RID: 24908
		private LuaFunction m_ClearAttachFx_hotfix;

		// Token: 0x0400614D RID: 24909
		private LuaFunction m_SetGraphicEffectGraphicEffectSingleSingle_hotfix;

		// Token: 0x0400614E RID: 24910
		private LuaFunction m_ClearGraphicEffectGraphicEffect_hotfix;

		// Token: 0x0400614F RID: 24911
		private LuaFunction m_PlaySoundString_hotfix;

		// Token: 0x04006150 RID: 24912
		private LuaFunction m_PlaySoundSoundTableId_hotfix;

		// Token: 0x04006151 RID: 24913
		private LuaFunction m_SetGraphicActionFinishedEffectBoolean_hotfix;

		// Token: 0x04006152 RID: 24914
		private LuaFunction m_SetGraphicColorColori_hotfix;

		// Token: 0x04006153 RID: 24915
		private LuaFunction m_AttachBuffBuffState_hotfix;

		// Token: 0x04006154 RID: 24916
		private LuaFunction m_DetachBuffBuffState_hotfix;

		// Token: 0x04006155 RID: 24917
		private LuaFunction m_SetHpBarTypeInt32Boolean_hotfix;

		// Token: 0x04006156 RID: 24918
		private LuaFunction m_StartIdleRun_hotfix;

		// Token: 0x04006157 RID: 24919
		private LuaFunction m_StopIdleRun_hotfix;

		// Token: 0x04006158 RID: 24920
		private LuaFunction m_CancelTeleportDisappear_hotfix;

		// Token: 0x04006159 RID: 24921
		private LuaFunction m_SetVisibleBoolean_hotfix;

		// Token: 0x0400615A RID: 24922
		private LuaFunction m_IsVisible_hotfix;

		// Token: 0x0400615B RID: 24923
		private LuaFunction m_ComputeSoldierGraphicCount_hotfix;

		// Token: 0x0400615C RID: 24924
		private LuaFunction m_UpdateSoldierGraphicCount_hotfix;

		// Token: 0x0400615D RID: 24925
		private LuaFunction m_GetSoldierGraphicCount_hotfix;

		// Token: 0x0400615E RID: 24926
		private LuaFunction m_UpdateGraphicVisible_hotfix;

		// Token: 0x0400615F RID: 24927
		private LuaFunction m_ComputeGraphicOffsetInt32_hotfix;

		// Token: 0x04006160 RID: 24928
		private LuaFunction m_GetGraphicInt32_hotfix;

		// Token: 0x04006161 RID: 24929
		private LuaFunction m_GetGraphicPosition_hotfix;

		// Token: 0x04006162 RID: 24930
		private LuaFunction m_SetGraphicSkillFadeBoolean_hotfix;

		// Token: 0x04006163 RID: 24931
		private LuaFunction m_IsGraphicSkillFade_hotfix;

		// Token: 0x04006164 RID: 24932
		private LuaFunction m_UpdateHpAndBuffUI_hotfix;

		// Token: 0x04006165 RID: 24933
		private LuaFunction m_ShowPlayerIndexBoolean_hotfix;

		// Token: 0x04006166 RID: 24934
		private LuaFunction m_get_Position_hotfix;

		// Token: 0x04006167 RID: 24935
		private LuaFunction m_get_Direction_hotfix;

		// Token: 0x04006168 RID: 24936
		private LuaFunction m_get_BattleActor_hotfix;

		// Token: 0x04006169 RID: 24937
		private LuaFunction m_get_TeamNumber_hotfix;

		// Token: 0x0400616A RID: 24938
		private LuaFunction m_get_HeroHealthPoint_hotfix;

		// Token: 0x0400616B RID: 24939
		private LuaFunction m_get_SoldierTotalHealthPoint_hotfix;

		// Token: 0x0400616C RID: 24940
		private LuaFunction m_TickActClientActorAct_hotfix;

		// Token: 0x0400616D RID: 24941
		private LuaFunction m_TickActClientActorActActive_hotfix;

		// Token: 0x0400616E RID: 24942
		private LuaFunction m_TickActClientActorActActionBegin_hotfix;

		// Token: 0x0400616F RID: 24943
		private LuaFunction m_TickActClientActorActActionEnd_hotfix;

		// Token: 0x04006170 RID: 24944
		private LuaFunction m_InitMoveActGridPositionInt32BooleanBoolean_hotfix;

		// Token: 0x04006171 RID: 24945
		private LuaFunction m_ComputeMoveTimeGridPositionGridPosition_hotfix;

		// Token: 0x04006172 RID: 24946
		private LuaFunction m_TickActClientActorActMove_hotfix;

		// Token: 0x04006173 RID: 24947
		private LuaFunction m_TickActClientActorActTryMove_hotfix;

		// Token: 0x04006174 RID: 24948
		private LuaFunction m_TickActClientActorActPerformMove_hotfix;

		// Token: 0x04006175 RID: 24949
		private LuaFunction m_TickActClientActorActPunchMove_hotfix;

		// Token: 0x04006176 RID: 24950
		private LuaFunction m_TickActClientActorActExchangeMove_hotfix;

		// Token: 0x04006177 RID: 24951
		private LuaFunction m_TickActClientActorActSetDir_hotfix;

		// Token: 0x04006178 RID: 24952
		private LuaFunction m_TickActClientActorActPlayFx_hotfix;

		// Token: 0x04006179 RID: 24953
		private LuaFunction m_TickActClientActorActPlayAnimation_hotfix;

		// Token: 0x0400617A RID: 24954
		private LuaFunction m_TickActClientActorActChangeIdleAnimation_hotfix;

		// Token: 0x0400617B RID: 24955
		private LuaFunction m_TickActClientActorActTarget_hotfix;

		// Token: 0x0400617C RID: 24956
		private LuaFunction m_TickActClientActorActSkill_hotfix;

		// Token: 0x0400617D RID: 24957
		private LuaFunction m_TickActClientActorActSkillHit_hotfix;

		// Token: 0x0400617E RID: 24958
		private LuaFunction m_TickSkillHitsConfigDataSkillInfoList;

		// Token: 0x0400617F RID: 24959
		private LuaFunction m_TickActClientActorActAttachBuff_hotfix;

		// Token: 0x04006180 RID: 24960
		private LuaFunction m_TickActClientActorActDetachBuff_hotfix;

		// Token: 0x04006181 RID: 24961
		private LuaFunction m_TickActClientActorActImmune_hotfix;

		// Token: 0x04006182 RID: 24962
		private LuaFunction m_TickActClientActorActPassiveSkill_hotfix;

		// Token: 0x04006183 RID: 24963
		private LuaFunction m_TickActClientActorActPassiveSkillHit_hotfix;

		// Token: 0x04006184 RID: 24964
		private LuaFunction m_TickActClientActorActBuffHit_hotfix;

		// Token: 0x04006185 RID: 24965
		private LuaFunction m_TickActClientActorActTerrainHit_hotfix;

		// Token: 0x04006186 RID: 24966
		private LuaFunction m_TickActClientActorActTeleportDisappear_hotfix;

		// Token: 0x04006187 RID: 24967
		private LuaFunction m_TickActClientActorActTeleportAppear_hotfix;

		// Token: 0x04006188 RID: 24968
		private LuaFunction m_TickActClientActorActSummon_hotfix;

		// Token: 0x04006189 RID: 24969
		private LuaFunction m_TickActClientActorActDie_hotfix;

		// Token: 0x0400618A RID: 24970
		private LuaFunction m_TickActClientActorActAppear_hotfix;

		// Token: 0x0400618B RID: 24971
		private LuaFunction m_TickActClientActorActDisappear_hotfix;

		// Token: 0x0400618C RID: 24972
		private LuaFunction m_TickActClientActorActChangeTeam_hotfix;

		// Token: 0x0400618D RID: 24973
		private LuaFunction m_TickActClientActorActChangeArmy_hotfix;

		// Token: 0x0400618E RID: 24974
		private LuaFunction m_TickActClientActorActReplace_hotfix;

		// Token: 0x0400618F RID: 24975
		private LuaFunction m_TickActClientActorActCameraFocus_hotfix;

		// Token: 0x04006190 RID: 24976
		private LuaFunction m_TickActClientActorActGainBattleTreasure_hotfix;

		// Token: 0x04006191 RID: 24977
		private LuaFunction m_TickActClientActorActStartGuard_hotfix;

		// Token: 0x04006192 RID: 24978
		private LuaFunction m_TickActClientActorActStopGuard_hotfix;

		// Token: 0x04006193 RID: 24979
		private LuaFunction m_TickActClientActorActBeforeStartCombat_hotfix;

		// Token: 0x04006194 RID: 24980
		private LuaFunction m_TickActClientNullActorActCancelCombat_hotfix;

		// Token: 0x04006195 RID: 24981
		private LuaFunction m_TickActClientActorActStartCombat_hotfix;

		// Token: 0x04006196 RID: 24982
		private LuaFunction m_TickActClientActorActStopCombat_hotfix;

		// Token: 0x04006197 RID: 24983
		private LuaFunction m_TickActClientNullActorActStartBattle_hotfix;

		// Token: 0x04006198 RID: 24984
		private LuaFunction m_TickActClientNullActorActBattleWinCondition_hotfix;

		// Token: 0x04006199 RID: 24985
		private LuaFunction m_TickActClientNullActorActBattleLoseCondition_hotfix;

		// Token: 0x0400619A RID: 24986
		private LuaFunction m_TickActClientNullActorActNextTurn_hotfix;

		// Token: 0x0400619B RID: 24987
		private LuaFunction m_TickActClientNullActorActNextTeam_hotfix;

		// Token: 0x0400619C RID: 24988
		private LuaFunction m_TickActClientNullActorActNextPlayer_hotfix;

		// Token: 0x0400619D RID: 24989
		private LuaFunction m_TickActClientNullActorActNextActor_hotfix;

		// Token: 0x0400619E RID: 24990
		private LuaFunction m_TickActClientNullActorActFastCombat_hotfix;

		// Token: 0x0400619F RID: 24991
		private LuaFunction m_TickActClientNullActorActBattleDialog_hotfix;

		// Token: 0x040061A0 RID: 24992
		private LuaFunction m_TickActClientNullActorActStartBattlePerform_hotfix;

		// Token: 0x040061A1 RID: 24993
		private LuaFunction m_TickActClientNullActorActStopBattlePerform_hotfix;

		// Token: 0x040061A2 RID: 24994
		private LuaFunction m_TickActClientNullActorActChangeMapTerrain_hotfix;

		// Token: 0x040061A3 RID: 24995
		private LuaFunction m_TickActClientNullActorActCameraFocus_hotfix;

		// Token: 0x040061A4 RID: 24996
		private LuaFunction m_TickActClientNullActorActPlayMusic_hotfix;

		// Token: 0x040061A5 RID: 24997
		private LuaFunction m_TickActClientNullActorActPlaySound_hotfix;

		// Token: 0x040061A6 RID: 24998
		private LuaFunction m_TickActClientNullActorActPlayFx_hotfix;

		// Token: 0x040061A7 RID: 24999
		private LuaFunction m_TickActClientNullActorActWaitTime_hotfix;

		// Token: 0x0200092B RID: 2347
		[CustomLuaClass]
		public class GraphicState
		{
			// Token: 0x040061A8 RID: 25000
			public GenericGraphic m_graphic;

			// Token: 0x040061A9 RID: 25001
			public float m_hideCountdown;
		}

		// Token: 0x0200092C RID: 2348
		public new class LuaExportHelper
		{
			// Token: 0x060088F1 RID: 35057 RVA: 0x00281134 File Offset: 0x0027F334
			public LuaExportHelper(ClientBattleActor owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x060088F2 RID: 35058 RVA: 0x00281144 File Offset: 0x0027F344
			public void __callBase_Dispose()
			{
				this.m_owner.__callBase_Dispose();
			}

			// Token: 0x060088F3 RID: 35059 RVA: 0x00281154 File Offset: 0x0027F354
			public void __callBase_Tick()
			{
				this.m_owner.__callBase_Tick();
			}

			// Token: 0x060088F4 RID: 35060 RVA: 0x00281164 File Offset: 0x0027F364
			public void __callBase_TickGraphic(float dt)
			{
				this.m_owner.__callBase_TickGraphic(dt);
			}

			// Token: 0x060088F5 RID: 35061 RVA: 0x00281174 File Offset: 0x0027F374
			public void __callBase_Draw()
			{
				this.m_owner.__callBase_Draw();
			}

			// Token: 0x060088F6 RID: 35062 RVA: 0x00281184 File Offset: 0x0027F384
			public void __callBase_Pause(bool pause)
			{
				this.m_owner.__callBase_Pause(pause);
			}

			// Token: 0x060088F7 RID: 35063 RVA: 0x00281194 File Offset: 0x0027F394
			public void __callBase_DoPause(bool pause)
			{
				this.m_owner.__callBase_DoPause(pause);
			}

			// Token: 0x060088F8 RID: 35064 RVA: 0x002811A4 File Offset: 0x0027F3A4
			public void __callBase_DeleteMe()
			{
				this.m_owner.__callBase_DeleteMe();
			}

			// Token: 0x17001CCC RID: 7372
			// (get) Token: 0x060088F9 RID: 35065 RVA: 0x002811B4 File Offset: 0x0027F3B4
			// (set) Token: 0x060088FA RID: 35066 RVA: 0x002811C4 File Offset: 0x0027F3C4
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

			// Token: 0x17001CCD RID: 7373
			// (get) Token: 0x060088FB RID: 35067 RVA: 0x002811D4 File Offset: 0x0027F3D4
			// (set) Token: 0x060088FC RID: 35068 RVA: 0x002811E4 File Offset: 0x0027F3E4
			public BattleActor m_battleActor
			{
				get
				{
					return this.m_owner.m_battleActor;
				}
				set
				{
					this.m_owner.m_battleActor = value;
				}
			}

			// Token: 0x17001CCE RID: 7374
			// (get) Token: 0x060088FD RID: 35069 RVA: 0x002811F4 File Offset: 0x0027F3F4
			// (set) Token: 0x060088FE RID: 35070 RVA: 0x00281204 File Offset: 0x0027F404
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

			// Token: 0x17001CCF RID: 7375
			// (get) Token: 0x060088FF RID: 35071 RVA: 0x00281214 File Offset: 0x0027F414
			// (set) Token: 0x06008900 RID: 35072 RVA: 0x00281224 File Offset: 0x0027F424
			public int m_soldierTotalHealthPoint
			{
				get
				{
					return this.m_owner.m_soldierTotalHealthPoint;
				}
				set
				{
					this.m_owner.m_soldierTotalHealthPoint = value;
				}
			}

			// Token: 0x17001CD0 RID: 7376
			// (get) Token: 0x06008901 RID: 35073 RVA: 0x00281234 File Offset: 0x0027F434
			// (set) Token: 0x06008902 RID: 35074 RVA: 0x00281244 File Offset: 0x0027F444
			public int m_heroHealthPointMax
			{
				get
				{
					return this.m_owner.m_heroHealthPointMax;
				}
				set
				{
					this.m_owner.m_heroHealthPointMax = value;
				}
			}

			// Token: 0x17001CD1 RID: 7377
			// (get) Token: 0x06008903 RID: 35075 RVA: 0x00281254 File Offset: 0x0027F454
			// (set) Token: 0x06008904 RID: 35076 RVA: 0x00281264 File Offset: 0x0027F464
			public int m_soldierTotalHealthPointMax
			{
				get
				{
					return this.m_owner.m_soldierTotalHealthPointMax;
				}
				set
				{
					this.m_owner.m_soldierTotalHealthPointMax = value;
				}
			}

			// Token: 0x17001CD2 RID: 7378
			// (get) Token: 0x06008905 RID: 35077 RVA: 0x00281274 File Offset: 0x0027F474
			// (set) Token: 0x06008906 RID: 35078 RVA: 0x00281284 File Offset: 0x0027F484
			public uint m_fightTags
			{
				get
				{
					return this.m_owner.m_fightTags;
				}
				set
				{
					this.m_owner.m_fightTags = value;
				}
			}

			// Token: 0x17001CD3 RID: 7379
			// (get) Token: 0x06008907 RID: 35079 RVA: 0x00281294 File Offset: 0x0027F494
			// (set) Token: 0x06008908 RID: 35080 RVA: 0x002812A4 File Offset: 0x0027F4A4
			public ClientBattleActor.GraphicState[] m_graphicStates
			{
				get
				{
					return this.m_owner.m_graphicStates;
				}
				set
				{
					this.m_owner.m_graphicStates = value;
				}
			}

			// Token: 0x17001CD4 RID: 7380
			// (get) Token: 0x06008909 RID: 35081 RVA: 0x002812B4 File Offset: 0x0027F4B4
			// (set) Token: 0x0600890A RID: 35082 RVA: 0x002812C4 File Offset: 0x0027F4C4
			public int m_soldierGraphicCount
			{
				get
				{
					return this.m_owner.m_soldierGraphicCount;
				}
				set
				{
					this.m_owner.m_soldierGraphicCount = value;
				}
			}

			// Token: 0x17001CD5 RID: 7381
			// (get) Token: 0x0600890B RID: 35083 RVA: 0x002812D4 File Offset: 0x0027F4D4
			// (set) Token: 0x0600890C RID: 35084 RVA: 0x002812E4 File Offset: 0x0027F4E4
			public Vector2 m_graphicPosition
			{
				get
				{
					return this.m_owner.m_graphicPosition;
				}
				set
				{
					this.m_owner.m_graphicPosition = value;
				}
			}

			// Token: 0x17001CD6 RID: 7382
			// (get) Token: 0x0600890D RID: 35085 RVA: 0x002812F4 File Offset: 0x0027F4F4
			// (set) Token: 0x0600890E RID: 35086 RVA: 0x00281304 File Offset: 0x0027F504
			public bool m_isGraphicSkillFade
			{
				get
				{
					return this.m_owner.m_isGraphicSkillFade;
				}
				set
				{
					this.m_owner.m_isGraphicSkillFade = value;
				}
			}

			// Token: 0x17001CD7 RID: 7383
			// (get) Token: 0x0600890F RID: 35087 RVA: 0x00281314 File Offset: 0x0027F514
			// (set) Token: 0x06008910 RID: 35088 RVA: 0x00281324 File Offset: 0x0027F524
			public bool m_isActionFinishedGray
			{
				get
				{
					return this.m_owner.m_isActionFinishedGray;
				}
				set
				{
					this.m_owner.m_isActionFinishedGray = value;
				}
			}

			// Token: 0x17001CD8 RID: 7384
			// (get) Token: 0x06008911 RID: 35089 RVA: 0x00281334 File Offset: 0x0027F534
			// (set) Token: 0x06008912 RID: 35090 RVA: 0x00281344 File Offset: 0x0027F544
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

			// Token: 0x17001CD9 RID: 7385
			// (get) Token: 0x06008913 RID: 35091 RVA: 0x00281354 File Offset: 0x0027F554
			// (set) Token: 0x06008914 RID: 35092 RVA: 0x00281364 File Offset: 0x0027F564
			public List<ClientActorBuff> m_buffs
			{
				get
				{
					return this.m_owner.m_buffs;
				}
				set
				{
					this.m_owner.m_buffs = value;
				}
			}

			// Token: 0x17001CDA RID: 7386
			// (get) Token: 0x06008915 RID: 35093 RVA: 0x00281374 File Offset: 0x0027F574
			// (set) Token: 0x06008916 RID: 35094 RVA: 0x00281384 File Offset: 0x0027F584
			public List<GenericGraphic> m_attachFxs
			{
				get
				{
					return this.m_owner.m_attachFxs;
				}
				set
				{
					this.m_owner.m_attachFxs = value;
				}
			}

			// Token: 0x17001CDB RID: 7387
			// (get) Token: 0x06008917 RID: 35095 RVA: 0x00281394 File Offset: 0x0027F594
			// (set) Token: 0x06008918 RID: 35096 RVA: 0x002813A4 File Offset: 0x0027F5A4
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

			// Token: 0x17001CDC RID: 7388
			// (get) Token: 0x06008919 RID: 35097 RVA: 0x002813B4 File Offset: 0x0027F5B4
			// (set) Token: 0x0600891A RID: 35098 RVA: 0x002813C4 File Offset: 0x0027F5C4
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

			// Token: 0x17001CDD RID: 7389
			// (get) Token: 0x0600891B RID: 35099 RVA: 0x002813D4 File Offset: 0x0027F5D4
			// (set) Token: 0x0600891C RID: 35100 RVA: 0x002813E4 File Offset: 0x0027F5E4
			public bool m_isVisible
			{
				get
				{
					return this.m_owner.m_isVisible;
				}
				set
				{
					this.m_owner.m_isVisible = value;
				}
			}

			// Token: 0x17001CDE RID: 7390
			// (get) Token: 0x0600891D RID: 35101 RVA: 0x002813F4 File Offset: 0x0027F5F4
			// (set) Token: 0x0600891E RID: 35102 RVA: 0x00281404 File Offset: 0x0027F604
			public bool m_isIdleRun
			{
				get
				{
					return this.m_owner.m_isIdleRun;
				}
				set
				{
					this.m_owner.m_isIdleRun = value;
				}
			}

			// Token: 0x17001CDF RID: 7391
			// (get) Token: 0x0600891F RID: 35103 RVA: 0x00281414 File Offset: 0x0027F614
			// (set) Token: 0x06008920 RID: 35104 RVA: 0x00281424 File Offset: 0x0027F624
			public bool m_isGuarding
			{
				get
				{
					return this.m_owner.m_isGuarding;
				}
				set
				{
					this.m_owner.m_isGuarding = value;
				}
			}

			// Token: 0x17001CE0 RID: 7392
			// (get) Token: 0x06008921 RID: 35105 RVA: 0x00281434 File Offset: 0x0027F634
			// (set) Token: 0x06008922 RID: 35106 RVA: 0x00281444 File Offset: 0x0027F644
			public bool m_isTeleportDisappear
			{
				get
				{
					return this.m_owner.m_isTeleportDisappear;
				}
				set
				{
					this.m_owner.m_isTeleportDisappear = value;
				}
			}

			// Token: 0x17001CE1 RID: 7393
			// (get) Token: 0x06008923 RID: 35107 RVA: 0x00281454 File Offset: 0x0027F654
			// (set) Token: 0x06008924 RID: 35108 RVA: 0x00281464 File Offset: 0x0027F664
			public string m_idleAnimationName
			{
				get
				{
					return this.m_owner.m_idleAnimationName;
				}
				set
				{
					this.m_owner.m_idleAnimationName = value;
				}
			}

			// Token: 0x17001CE2 RID: 7394
			// (get) Token: 0x06008925 RID: 35109 RVA: 0x00281474 File Offset: 0x0027F674
			// (set) Token: 0x06008926 RID: 35110 RVA: 0x00281484 File Offset: 0x0027F684
			public List<ClientActorAct> m_acts
			{
				get
				{
					return this.m_owner.m_acts;
				}
				set
				{
					this.m_owner.m_acts = value;
				}
			}

			// Token: 0x17001CE3 RID: 7395
			// (get) Token: 0x06008927 RID: 35111 RVA: 0x00281494 File Offset: 0x0027F694
			// (set) Token: 0x06008928 RID: 35112 RVA: 0x002814A4 File Offset: 0x0027F6A4
			public int m_actFrame
			{
				get
				{
					return this.m_owner.m_actFrame;
				}
				set
				{
					this.m_owner.m_actFrame = value;
				}
			}

			// Token: 0x17001CE4 RID: 7396
			// (get) Token: 0x06008929 RID: 35113 RVA: 0x002814B4 File Offset: 0x0027F6B4
			// (set) Token: 0x0600892A RID: 35114 RVA: 0x002814C4 File Offset: 0x0027F6C4
			public int m_tempActFrame
			{
				get
				{
					return this.m_owner.m_tempActFrame;
				}
				set
				{
					this.m_owner.m_tempActFrame = value;
				}
			}

			// Token: 0x17001CE5 RID: 7397
			// (get) Token: 0x0600892B RID: 35115 RVA: 0x002814D4 File Offset: 0x0027F6D4
			// (set) Token: 0x0600892C RID: 35116 RVA: 0x002814E4 File Offset: 0x0027F6E4
			public int m_deleteMeCountdown
			{
				get
				{
					return this.m_owner.m_deleteMeCountdown;
				}
				set
				{
					this.m_owner.m_deleteMeCountdown = value;
				}
			}

			// Token: 0x0600892D RID: 35117 RVA: 0x002814F4 File Offset: 0x0027F6F4
			public void CreateHeroGraphic()
			{
				this.m_owner.CreateHeroGraphic();
			}

			// Token: 0x0600892E RID: 35118 RVA: 0x00281504 File Offset: 0x0027F704
			public void CreateSoldierGraphics()
			{
				this.m_owner.CreateSoldierGraphics();
			}

			// Token: 0x0600892F RID: 35119 RVA: 0x00281514 File Offset: 0x0027F714
			public Vector3 ComputeGraphicPosition(Vector2 p, float zoffset)
			{
				return this.m_owner.ComputeGraphicPosition(p, zoffset);
			}

			// Token: 0x06008930 RID: 35120 RVA: 0x00281524 File Offset: 0x0027F724
			public bool HasFightTag(FightTag ft)
			{
				return this.m_owner.HasFightTag(ft);
			}

			// Token: 0x06008931 RID: 35121 RVA: 0x00281534 File Offset: 0x0027F734
			public void FaceTo(GridPosition p)
			{
				this.m_owner.FaceTo(p);
			}

			// Token: 0x06008932 RID: 35122 RVA: 0x00281544 File Offset: 0x0027F744
			public void PlayAnimation(string name, bool loop, bool onAll)
			{
				this.m_owner.PlayAnimation(name, loop, onAll);
			}

			// Token: 0x06008933 RID: 35123 RVA: 0x00281554 File Offset: 0x0027F754
			public int GetHeroAnimationDuration(string name)
			{
				return this.m_owner.GetHeroAnimationDuration(name);
			}

			// Token: 0x06008934 RID: 35124 RVA: 0x00281564 File Offset: 0x0027F764
			public bool IsHeroPlayAnimation()
			{
				return this.m_owner.IsHeroPlayAnimation();
			}

			// Token: 0x06008935 RID: 35125 RVA: 0x00281574 File Offset: 0x0027F774
			public void PlayDeathFx(int deathType)
			{
				this.m_owner.PlayDeathFx(deathType);
			}

			// Token: 0x06008936 RID: 35126 RVA: 0x00281584 File Offset: 0x0027F784
			public void PlayIdleAnimation()
			{
				this.m_owner.PlayIdleAnimation();
			}

			// Token: 0x06008937 RID: 35127 RVA: 0x00281594 File Offset: 0x0027F794
			public void PlayHeroFx(string name)
			{
				this.m_owner.PlayHeroFx(name);
			}

			// Token: 0x06008938 RID: 35128 RVA: 0x002815A4 File Offset: 0x0027F7A4
			public void PlayFx(string name, GridPosition p)
			{
				this.m_owner.PlayFx(name, p);
			}

			// Token: 0x06008939 RID: 35129 RVA: 0x002815B4 File Offset: 0x0027F7B4
			public void PlayAttachFx(string name)
			{
				this.m_owner.PlayAttachFx(name);
			}

			// Token: 0x0600893A RID: 35130 RVA: 0x002815C4 File Offset: 0x0027F7C4
			public void PlaySound(string name)
			{
				this.m_owner.PlaySound(name);
			}

			// Token: 0x0600893B RID: 35131 RVA: 0x002815D4 File Offset: 0x0027F7D4
			public void PlaySound(SoundTableId id)
			{
				this.m_owner.PlaySound(id);
			}

			// Token: 0x0600893C RID: 35132 RVA: 0x002815E4 File Offset: 0x0027F7E4
			public void SetGraphicColor(Colori c)
			{
				this.m_owner.SetGraphicColor(c);
			}

			// Token: 0x0600893D RID: 35133 RVA: 0x002815F4 File Offset: 0x0027F7F4
			public void AttachBuff(BuffState buffState)
			{
				this.m_owner.AttachBuff(buffState);
			}

			// Token: 0x0600893E RID: 35134 RVA: 0x00281604 File Offset: 0x0027F804
			public static int CompareBuffDisplayOrder(ClientActorBuff b0, ClientActorBuff b1)
			{
				return ClientBattleActor.CompareBuffDisplayOrder(b0, b1);
			}

			// Token: 0x0600893F RID: 35135 RVA: 0x00281610 File Offset: 0x0027F810
			public void DetachBuff(BuffState buffState)
			{
				this.m_owner.DetachBuff(buffState);
			}

			// Token: 0x06008940 RID: 35136 RVA: 0x00281620 File Offset: 0x0027F820
			public void SetHpBarType(int team, bool isAINpcOrTeamMate)
			{
				this.m_owner.SetHpBarType(team, isAINpcOrTeamMate);
			}

			// Token: 0x06008941 RID: 35137 RVA: 0x00281630 File Offset: 0x0027F830
			public int ComputeSoldierGraphicCount()
			{
				return this.m_owner.ComputeSoldierGraphicCount();
			}

			// Token: 0x06008942 RID: 35138 RVA: 0x00281640 File Offset: 0x0027F840
			public void UpdateSoldierGraphicCount()
			{
				this.m_owner.UpdateSoldierGraphicCount();
			}

			// Token: 0x06008943 RID: 35139 RVA: 0x00281650 File Offset: 0x0027F850
			public void UpdateGraphicVisible()
			{
				this.m_owner.UpdateGraphicVisible();
			}

			// Token: 0x06008944 RID: 35140 RVA: 0x00281660 File Offset: 0x0027F860
			public Vector2 ComputeGraphicOffset(int idx)
			{
				return this.m_owner.ComputeGraphicOffset(idx);
			}

			// Token: 0x06008945 RID: 35141 RVA: 0x00281670 File Offset: 0x0027F870
			public void UpdateHpAndBuffUI()
			{
				this.m_owner.UpdateHpAndBuffUI();
			}

			// Token: 0x06008946 RID: 35142 RVA: 0x00281680 File Offset: 0x0027F880
			public bool TickAct(ClientActorAct act)
			{
				return this.m_owner.TickAct(act);
			}

			// Token: 0x06008947 RID: 35143 RVA: 0x00281690 File Offset: 0x0027F890
			public bool TickAct(ClientActorActActive act)
			{
				return this.m_owner.TickAct(act);
			}

			// Token: 0x06008948 RID: 35144 RVA: 0x002816A0 File Offset: 0x0027F8A0
			public bool TickAct(ClientActorActActionBegin act)
			{
				return this.m_owner.TickAct(act);
			}

			// Token: 0x06008949 RID: 35145 RVA: 0x002816B0 File Offset: 0x0027F8B0
			public bool TickAct(ClientActorActActionEnd act)
			{
				return this.m_owner.TickAct(act);
			}

			// Token: 0x0600894A RID: 35146 RVA: 0x002816C0 File Offset: 0x0027F8C0
			public void InitMoveAct(GridPosition pos, int dir, bool sound, bool endDelay)
			{
				this.m_owner.InitMoveAct(pos, dir, sound, endDelay);
			}

			// Token: 0x0600894B RID: 35147 RVA: 0x002816D4 File Offset: 0x0027F8D4
			public int ComputeMoveTime(GridPosition p0, GridPosition p1)
			{
				return this.m_owner.ComputeMoveTime(p0, p1);
			}

			// Token: 0x0600894C RID: 35148 RVA: 0x002816E4 File Offset: 0x0027F8E4
			public bool TickAct(ClientActorActMove act)
			{
				return this.m_owner.TickAct(act);
			}

			// Token: 0x0600894D RID: 35149 RVA: 0x002816F4 File Offset: 0x0027F8F4
			public bool TickAct(ClientActorActTryMove act)
			{
				return this.m_owner.TickAct(act);
			}

			// Token: 0x0600894E RID: 35150 RVA: 0x00281704 File Offset: 0x0027F904
			public bool TickAct(ClientActorActPerformMove act)
			{
				return this.m_owner.TickAct(act);
			}

			// Token: 0x0600894F RID: 35151 RVA: 0x00281714 File Offset: 0x0027F914
			public bool TickAct(ClientActorActPunchMove act)
			{
				return this.m_owner.TickAct(act);
			}

			// Token: 0x06008950 RID: 35152 RVA: 0x00281724 File Offset: 0x0027F924
			public bool TickAct(ClientActorActExchangeMove act)
			{
				return this.m_owner.TickAct(act);
			}

			// Token: 0x06008951 RID: 35153 RVA: 0x00281734 File Offset: 0x0027F934
			public bool TickAct(ClientActorActSetDir act)
			{
				return this.m_owner.TickAct(act);
			}

			// Token: 0x06008952 RID: 35154 RVA: 0x00281744 File Offset: 0x0027F944
			public bool TickAct(ClientActorActPlayFx act)
			{
				return this.m_owner.TickAct(act);
			}

			// Token: 0x06008953 RID: 35155 RVA: 0x00281754 File Offset: 0x0027F954
			public bool TickAct(ClientActorActPlayAnimation act)
			{
				return this.m_owner.TickAct(act);
			}

			// Token: 0x06008954 RID: 35156 RVA: 0x00281764 File Offset: 0x0027F964
			public bool TickAct(ClientActorActChangeIdleAnimation act)
			{
				return this.m_owner.TickAct(act);
			}

			// Token: 0x06008955 RID: 35157 RVA: 0x00281774 File Offset: 0x0027F974
			public bool TickAct(ClientActorActTarget act)
			{
				return this.m_owner.TickAct(act);
			}

			// Token: 0x06008956 RID: 35158 RVA: 0x00281784 File Offset: 0x0027F984
			public bool TickAct(ClientActorActSkill act)
			{
				return this.m_owner.TickAct(act);
			}

			// Token: 0x06008957 RID: 35159 RVA: 0x00281794 File Offset: 0x0027F994
			public bool TickAct(ClientActorActSkillHit act)
			{
				return this.m_owner.TickAct(act);
			}

			// Token: 0x06008958 RID: 35160 RVA: 0x002817A4 File Offset: 0x0027F9A4
			public static int ComputeSkillCastTime(ConfigDataSkillInfo skillInfo)
			{
				return ClientBattleActor.ComputeSkillCastTime(skillInfo);
			}

			// Token: 0x06008959 RID: 35161 RVA: 0x002817AC File Offset: 0x0027F9AC
			public static int ComputeSkillHitTime(ConfigDataSkillInfo skillInfo, List<ClientActorHitInfo> hits)
			{
				return ClientBattleActor.ComputeSkillHitTime(skillInfo, hits);
			}

			// Token: 0x0600895A RID: 35162 RVA: 0x002817B8 File Offset: 0x0027F9B8
			public bool TickSkillHits(ConfigDataSkillInfo skillInfo, List<ClientActorHitInfo> hits)
			{
				return this.m_owner.TickSkillHits(skillInfo, hits);
			}

			// Token: 0x0600895B RID: 35163 RVA: 0x002817C8 File Offset: 0x0027F9C8
			public bool TickAct(ClientActorActAttachBuff act)
			{
				return this.m_owner.TickAct(act);
			}

			// Token: 0x0600895C RID: 35164 RVA: 0x002817D8 File Offset: 0x0027F9D8
			public bool TickAct(ClientActorActDetachBuff act)
			{
				return this.m_owner.TickAct(act);
			}

			// Token: 0x0600895D RID: 35165 RVA: 0x002817E8 File Offset: 0x0027F9E8
			public bool TickAct(ClientActorActImmune act)
			{
				return this.m_owner.TickAct(act);
			}

			// Token: 0x0600895E RID: 35166 RVA: 0x002817F8 File Offset: 0x0027F9F8
			public bool TickAct(ClientActorActPassiveSkill act)
			{
				return this.m_owner.TickAct(act);
			}

			// Token: 0x0600895F RID: 35167 RVA: 0x00281808 File Offset: 0x0027FA08
			public bool TickAct(ClientActorActPassiveSkillHit act)
			{
				return this.m_owner.TickAct(act);
			}

			// Token: 0x06008960 RID: 35168 RVA: 0x00281818 File Offset: 0x0027FA18
			public bool TickAct(ClientActorActBuffHit act)
			{
				return this.m_owner.TickAct(act);
			}

			// Token: 0x06008961 RID: 35169 RVA: 0x00281828 File Offset: 0x0027FA28
			public bool TickAct(ClientActorActTerrainHit act)
			{
				return this.m_owner.TickAct(act);
			}

			// Token: 0x06008962 RID: 35170 RVA: 0x00281838 File Offset: 0x0027FA38
			public bool TickAct(ClientActorActTeleportDisappear act)
			{
				return this.m_owner.TickAct(act);
			}

			// Token: 0x06008963 RID: 35171 RVA: 0x00281848 File Offset: 0x0027FA48
			public bool TickAct(ClientActorActTeleportAppear act)
			{
				return this.m_owner.TickAct(act);
			}

			// Token: 0x06008964 RID: 35172 RVA: 0x00281858 File Offset: 0x0027FA58
			public bool TickAct(ClientActorActSummon act)
			{
				return this.m_owner.TickAct(act);
			}

			// Token: 0x06008965 RID: 35173 RVA: 0x00281868 File Offset: 0x0027FA68
			public bool TickAct(ClientActorActDie act)
			{
				return this.m_owner.TickAct(act);
			}

			// Token: 0x06008966 RID: 35174 RVA: 0x00281878 File Offset: 0x0027FA78
			public bool TickAct(ClientActorActAppear act)
			{
				return this.m_owner.TickAct(act);
			}

			// Token: 0x06008967 RID: 35175 RVA: 0x00281888 File Offset: 0x0027FA88
			public bool TickAct(ClientActorActDisappear act)
			{
				return this.m_owner.TickAct(act);
			}

			// Token: 0x06008968 RID: 35176 RVA: 0x00281898 File Offset: 0x0027FA98
			public bool TickAct(ClientActorActChangeTeam act)
			{
				return this.m_owner.TickAct(act);
			}

			// Token: 0x06008969 RID: 35177 RVA: 0x002818A8 File Offset: 0x0027FAA8
			public bool TickAct(ClientActorActChangeArmy act)
			{
				return this.m_owner.TickAct(act);
			}

			// Token: 0x0600896A RID: 35178 RVA: 0x002818B8 File Offset: 0x0027FAB8
			public bool TickAct(ClientActorActReplace act)
			{
				return this.m_owner.TickAct(act);
			}

			// Token: 0x0600896B RID: 35179 RVA: 0x002818C8 File Offset: 0x0027FAC8
			public bool TickAct(ClientActorActCameraFocus act)
			{
				return this.m_owner.TickAct(act);
			}

			// Token: 0x0600896C RID: 35180 RVA: 0x002818D8 File Offset: 0x0027FAD8
			public bool TickAct(ClientActorActGainBattleTreasure act)
			{
				return this.m_owner.TickAct(act);
			}

			// Token: 0x0600896D RID: 35181 RVA: 0x002818E8 File Offset: 0x0027FAE8
			public bool TickAct(ClientActorActStartGuard act)
			{
				return this.m_owner.TickAct(act);
			}

			// Token: 0x0600896E RID: 35182 RVA: 0x002818F8 File Offset: 0x0027FAF8
			public bool TickAct(ClientActorActStopGuard act)
			{
				return this.m_owner.TickAct(act);
			}

			// Token: 0x0600896F RID: 35183 RVA: 0x00281908 File Offset: 0x0027FB08
			public bool TickAct(ClientActorActBeforeStartCombat act)
			{
				return this.m_owner.TickAct(act);
			}

			// Token: 0x06008970 RID: 35184 RVA: 0x00281918 File Offset: 0x0027FB18
			public bool TickAct(ClientNullActorActCancelCombat act)
			{
				return this.m_owner.TickAct(act);
			}

			// Token: 0x06008971 RID: 35185 RVA: 0x00281928 File Offset: 0x0027FB28
			public bool TickAct(ClientActorActStartCombat act)
			{
				return this.m_owner.TickAct(act);
			}

			// Token: 0x06008972 RID: 35186 RVA: 0x00281938 File Offset: 0x0027FB38
			public bool TickAct(ClientActorActStopCombat act)
			{
				return this.m_owner.TickAct(act);
			}

			// Token: 0x06008973 RID: 35187 RVA: 0x00281948 File Offset: 0x0027FB48
			public bool TickAct(ClientNullActorActStartBattle act)
			{
				return this.m_owner.TickAct(act);
			}

			// Token: 0x06008974 RID: 35188 RVA: 0x00281958 File Offset: 0x0027FB58
			public bool TickAct(ClientNullActorActBattleWinCondition act)
			{
				return this.m_owner.TickAct(act);
			}

			// Token: 0x06008975 RID: 35189 RVA: 0x00281968 File Offset: 0x0027FB68
			public bool TickAct(ClientNullActorActBattleLoseCondition act)
			{
				return this.m_owner.TickAct(act);
			}

			// Token: 0x06008976 RID: 35190 RVA: 0x00281978 File Offset: 0x0027FB78
			public bool TickAct(ClientNullActorActNextTurn act)
			{
				return this.m_owner.TickAct(act);
			}

			// Token: 0x06008977 RID: 35191 RVA: 0x00281988 File Offset: 0x0027FB88
			public bool TickAct(ClientNullActorActNextTeam act)
			{
				return this.m_owner.TickAct(act);
			}

			// Token: 0x06008978 RID: 35192 RVA: 0x00281998 File Offset: 0x0027FB98
			public bool TickAct(ClientNullActorActNextPlayer act)
			{
				return this.m_owner.TickAct(act);
			}

			// Token: 0x06008979 RID: 35193 RVA: 0x002819A8 File Offset: 0x0027FBA8
			public bool TickAct(ClientNullActorActNextActor act)
			{
				return this.m_owner.TickAct(act);
			}

			// Token: 0x0600897A RID: 35194 RVA: 0x002819B8 File Offset: 0x0027FBB8
			public bool TickAct(ClientNullActorActFastCombat act)
			{
				return this.m_owner.TickAct(act);
			}

			// Token: 0x0600897B RID: 35195 RVA: 0x002819C8 File Offset: 0x0027FBC8
			public bool TickAct(ClientNullActorActBattleDialog act)
			{
				return this.m_owner.TickAct(act);
			}

			// Token: 0x0600897C RID: 35196 RVA: 0x002819D8 File Offset: 0x0027FBD8
			public bool TickAct(ClientNullActorActStartBattlePerform act)
			{
				return this.m_owner.TickAct(act);
			}

			// Token: 0x0600897D RID: 35197 RVA: 0x002819E8 File Offset: 0x0027FBE8
			public bool TickAct(ClientNullActorActStopBattlePerform act)
			{
				return this.m_owner.TickAct(act);
			}

			// Token: 0x0600897E RID: 35198 RVA: 0x002819F8 File Offset: 0x0027FBF8
			public bool TickAct(ClientNullActorActChangeMapTerrain act)
			{
				return this.m_owner.TickAct(act);
			}

			// Token: 0x0600897F RID: 35199 RVA: 0x00281A08 File Offset: 0x0027FC08
			public bool TickAct(ClientNullActorActCameraFocus act)
			{
				return this.m_owner.TickAct(act);
			}

			// Token: 0x06008980 RID: 35200 RVA: 0x00281A18 File Offset: 0x0027FC18
			public bool TickAct(ClientNullActorActPlayMusic act)
			{
				return this.m_owner.TickAct(act);
			}

			// Token: 0x06008981 RID: 35201 RVA: 0x00281A28 File Offset: 0x0027FC28
			public bool TickAct(ClientNullActorActPlaySound act)
			{
				return this.m_owner.TickAct(act);
			}

			// Token: 0x06008982 RID: 35202 RVA: 0x00281A38 File Offset: 0x0027FC38
			public bool TickAct(ClientNullActorActPlayFx act)
			{
				return this.m_owner.TickAct(act);
			}

			// Token: 0x06008983 RID: 35203 RVA: 0x00281A48 File Offset: 0x0027FC48
			public bool TickAct(ClientNullActorActWaitTime act)
			{
				return this.m_owner.TickAct(act);
			}

			// Token: 0x040061AA RID: 25002
			private ClientBattleActor m_owner;
		}
	}
}
