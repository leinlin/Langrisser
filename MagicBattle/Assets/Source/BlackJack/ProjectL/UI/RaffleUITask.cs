using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Scene;
using BlackJack.BJFramework.Runtime.TaskNs;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectLBasic;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000EAD RID: 3757
	[HotFix]
	public class RaffleUITask : UITask
	{
		// Token: 0x060125A9 RID: 75177 RVA: 0x004B6950 File Offset: 0x004B4B50
		public RaffleUITask(string name) : base(name)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ctorString_hotfix != null)
			{
				this.m_ctorString_hotfix.call(new object[]
				{
					this,
					name
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x060125AA RID: 75178 RVA: 0x004B6AEC File Offset: 0x004B4CEC
		protected override bool OnStart(UIIntent intent)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnStartUIIntent_hotfix != null)
			{
				return Convert.ToBoolean(this.m_OnStartUIIntent_hotfix.call(new object[]
				{
					this,
					intent
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return base.OnStart(intent);
		}

		// Token: 0x060125AB RID: 75179 RVA: 0x004B6B70 File Offset: 0x004B4D70
		protected override void OnStop()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnStop_hotfix != null)
			{
				this.m_OnStop_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.OnStop();
		}

		// Token: 0x060125AC RID: 75180 RVA: 0x004B6BD8 File Offset: 0x004B4DD8
		protected override void OnPause()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnPause_hotfix != null)
			{
				this.m_OnPause_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.OnPause();
		}

		// Token: 0x060125AD RID: 75181 RVA: 0x004B6C40 File Offset: 0x004B4E40
		protected override bool OnResume(UIIntent intent)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnResumeUIIntent_hotfix != null)
			{
				return Convert.ToBoolean(this.m_OnResumeUIIntent_hotfix.call(new object[]
				{
					this,
					intent
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.InitLayerStateOnResume();
			return base.OnResume(intent);
		}

		// Token: 0x060125AE RID: 75182 RVA: 0x004B6CCC File Offset: 0x004B4ECC
		protected override bool IsNeedUpdateDataCache()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsNeedUpdateDataCache_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsNeedUpdateDataCache_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_currPipeLineCtx.m_isInitPipeLine || this.m_currPipeLineCtx.m_isTaskResume;
		}

		// Token: 0x060125AF RID: 75183 RVA: 0x004B6D5C File Offset: 0x004B4F5C
		protected override void UpdateDataCache()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateDataCache_hotfix != null)
			{
				this.m_UpdateDataCache_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIIntentCustom uiintentCustom = this.m_currIntent as UIIntentCustom;
			int structParam = uiintentCustom.GetStructParam<int>(RaffleUITask.ParamKey_PoolId);
			this.m_rafflePool = this.PlayerCtx.GetRafflePool(structParam);
			if (this.m_rafflePool == null || !this.PlayerCtx.IsRafflePoolOnActivityTime(structParam))
			{
				this.OnBgButtonClick();
			}
		}

		// Token: 0x060125B0 RID: 75184 RVA: 0x004B6E08 File Offset: 0x004B5008
		protected override bool IsNeedLoadDynamicRes()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsNeedLoadDynamicRes_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsNeedLoadDynamicRes_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.ClearAssetList();
			if (this.m_rafflePool == null)
			{
				return false;
			}
			if (this.m_currPipeLineCtx.m_isInitPipeLine || this.m_currPipeLineCtx.m_isTaskResume)
			{
				foreach (RaffleItem raffleItem in this.m_rafflePool.Config.RaffleItems)
				{
					base.CollectSpriteAsset(UIUtility.GetGoodsIconName(raffleItem.GoodsType, raffleItem.ItemID));
				}
			}
			base.CollectSpriteAsset(UIUtility.GetGoodsIconName(this.m_rafflePool.Config.GoodsType, this.m_rafflePool.Config.DrawItemID));
			return base.IsNeedLoadDynamicRes();
		}

		// Token: 0x060125B1 RID: 75185 RVA: 0x004B6F44 File Offset: 0x004B5144
		protected override void InitLayerStateOnLoadAllResCompleted()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitLayerStateOnLoadAllResCompleted_hotfix != null)
			{
				this.m_InitLayerStateOnLoadAllResCompleted_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.InitLayerStateOnLoadAllResCompleted();
			this.m_rewardPanelLayer = this.m_layerArray[1];
			if (this.m_rewardPanelLayer.State != SceneLayerBase.LayerState.InStack)
			{
				SceneManager.Instance.PushLayer(this.m_rewardPanelLayer);
			}
		}

		// Token: 0x060125B2 RID: 75186 RVA: 0x004B6FDC File Offset: 0x004B51DC
		protected void InitLayerStateOnResume()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitLayerStateOnResume_hotfix != null)
			{
				this.m_InitLayerStateOnResume_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.MainLayer.State != SceneLayerBase.LayerState.InStack)
			{
				SceneManager.Instance.PushLayer(this.MainLayer);
			}
			if (this.m_rewardPanelLayer.State != SceneLayerBase.LayerState.InStack)
			{
				SceneManager.Instance.PushLayer(this.m_rewardPanelLayer);
			}
		}

		// Token: 0x060125B3 RID: 75187 RVA: 0x004B7080 File Offset: 0x004B5280
		protected override void InitAllUIControllers()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitAllUIControllers_hotfix != null)
			{
				this.m_InitAllUIControllers_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.InitAllUIControllers();
			if (this.m_uiCtrlArray.Length != 0)
			{
				this.m_mainCtrl = (this.m_uiCtrlArray[0] as RaffleUIController);
			}
			if (this.m_mainCtrl != null)
			{
				RaffleUIController mainCtrl = this.m_mainCtrl;
				mainCtrl.EventOnBgButtonClick = (Action)Delegate.Combine(mainCtrl.EventOnBgButtonClick, new Action(this.OnBgButtonClick));
				RaffleUIController mainCtrl2 = this.m_mainCtrl;
				mainCtrl2.EventOnDoRaffleButtonClick = (Action)Delegate.Combine(mainCtrl2.EventOnDoRaffleButtonClick, new Action(this.OnDoRaffleButtonClick));
				RaffleUIController mainCtrl3 = this.m_mainCtrl;
				mainCtrl3.EventOnShowHelpButtonClick = (Action)Delegate.Combine(mainCtrl3.EventOnShowHelpButtonClick, new Action(this.OnShowHelpButtonClick));
				RaffleUIController mainCtrl4 = this.m_mainCtrl;
				mainCtrl4.EvetnOnRewardPanelButtonClick = (Action)Delegate.Combine(mainCtrl4.EvetnOnRewardPanelButtonClick, new Action(this.OnRewardPanelButtonClick));
				RaffleUIController mainCtrl5 = this.m_mainCtrl;
				mainCtrl5.EventOnLevelEffectBgButtonClick = (Action)Delegate.Combine(mainCtrl5.EventOnLevelEffectBgButtonClick, new Action(this.OnLevelEffectBgButtonClick));
			}
			this.m_raffle3dUICtrl = (this.m_uiCtrlArray[1] as Raffle3DUIController);
			if (this.m_raffle3dUICtrl != null)
			{
				this.m_raffle3dUICtrl.LayerCamera = this.MainLayer.LayerCamera;
			}
			this.m_rewardPanelCtrl = (this.m_uiCtrlArray[2] as RaffleRewardUIController);
			if (this.m_rewardPanelCtrl != null)
			{
				RaffleRewardUIController rewardPanelCtrl = this.m_rewardPanelCtrl;
				rewardPanelCtrl.EventOnCloseButtonClick = (Action)Delegate.Combine(rewardPanelCtrl.EventOnCloseButtonClick, new Action(this.OnRewardPanelCloseButtonClick));
			}
		}

		// Token: 0x060125B4 RID: 75188 RVA: 0x004B7260 File Offset: 0x004B5460
		protected override void UpdateView()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateView_hotfix != null)
			{
				this.m_UpdateView_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_rafflePool == null)
			{
				return;
			}
			if (this.m_currPipeLineCtx.m_isInitPipeLine || this.m_currPipeLineCtx.m_isTaskResume)
			{
				this.m_rewardPanelCtrl.UpdateRaffleRewardPanel(this.m_rafflePool, true);
				this.m_rewardPanelCtrl.gameObject.SetActive(false);
				this.m_raffle3dUICtrl.ShowDrawIdleAnimation();
				UIUtility.SetUIStateOpen(this.m_mainCtrl.UIStateCtrl, "Show", null, true, true);
			}
			if (this.IsPipelineStateMaskNeedUpdate(RaffleUITask.PipeLineStateMaskType.ShowRewardPanel))
			{
				this.m_rewardPanelCtrl.ShowRaffleRewardPanel(true, null);
				this.m_rewardPanelCtrl.UpdateRaffleRewardPanel(this.m_rafflePool, false);
			}
			this.m_mainCtrl.UpdateRafflePanel(this.m_rafflePool);
			if (this.IsPipelineStateMaskNeedUpdate(RaffleUITask.PipeLineStateMaskType.ShowDrawAnimation))
			{
				this.UpdateDrawAnimation();
			}
		}

		// Token: 0x060125B5 RID: 75189 RVA: 0x004B7380 File Offset: 0x004B5580
		protected void UpdateDrawAnimation()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateDrawAnimation_hotfix != null)
			{
				this.m_UpdateDrawAnimation_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			switch (this.m_drawAniamtionState)
			{
			case RaffleUITask.DrawAnimationState.Idle:
				UIUtility.SetUIStateOpen(this.m_mainCtrl.UIStateCtrl, "Normal", null, true, true);
				break;
			case RaffleUITask.DrawAnimationState.Drawing:
			{
				UIUtility.SetUIStateOpen(this.m_mainCtrl.UIStateCtrl, "Animation", null, true, true);
				RaffleItem raffleItem = this.PlayerCtx.GetRaffleItem(this.m_rafflePool, this.m_drawnRaffleId);
				this.m_raffle3dUICtrl.ShowRaffeDrawingAnimation(raffleItem.RaffleLevel, delegate
				{
					this.m_raffle3dUICtrl.ShowDrawIdleAnimation();
					this.EnablePipelineStateMask(RaffleUITask.PipeLineStateMaskType.ShowDrawAnimation);
					this.m_drawAniamtionState = RaffleUITask.DrawAnimationState.RewardLevel;
					base.StartUpdatePipeLine(this.m_currIntent, true, false, true);
				});
				break;
			}
			case RaffleUITask.DrawAnimationState.RewardLevel:
			{
				RaffleItem raffleItem2 = this.PlayerCtx.GetRaffleItem(this.m_rafflePool, this.m_drawnRaffleId);
				this.m_mainCtrl.ShowDrawRewardLevelEffect(raffleItem2.RaffleLevel, true);
				break;
			}
			case RaffleUITask.DrawAnimationState.RewardDetail:
				this.m_getRewardGoodsUITask = GetRewardGoodsUITask.StartUITask(this.m_drawnGoods);
				this.m_getRewardGoodsUITask.EventOnClose += this.OnRewardGoodsUITaskClose;
				break;
			}
		}

		// Token: 0x060125B6 RID: 75190 RVA: 0x004B74D0 File Offset: 0x004B56D0
		protected override void ClearContextOnPause()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ClearContextOnPause_hotfix != null)
			{
				this.m_ClearContextOnPause_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.ClearContextOnPause();
			this.m_rafflePool = null;
			this.m_drawAniamtionState = RaffleUITask.DrawAnimationState.Idle;
			this.m_drawnGoods.Clear();
			this.m_drawnRaffleId = 0;
		}

		// Token: 0x060125B7 RID: 75191 RVA: 0x004B7558 File Offset: 0x004B5758
		protected void OnBgButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnBgButtonClick_hotfix != null)
			{
				this.m_OnBgButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_drawAniamtionState != RaffleUITask.DrawAnimationState.Idle)
			{
				return;
			}
			CommonUIController.Instance.StartShowFadeOutLoadingFadeIn(delegate
			{
				CommonUIController.Instance.HideFadeOutLoadingFadeIn();
				base.Pause();
				base.ReturnPrevUITask();
			}, FadeStyle.Black, -1f, -1f);
		}

		// Token: 0x060125B8 RID: 75192 RVA: 0x004B75E8 File Offset: 0x004B57E8
		protected void OnShowHelpButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnShowHelpButtonClick_hotfix != null)
			{
				this.m_OnShowHelpButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIController.Instance.ShowExplanation(ExplanationId.ExplanationId_Raffle);
		}

		// Token: 0x060125B9 RID: 75193 RVA: 0x004B7654 File Offset: 0x004B5854
		protected void OnRewardPanelButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnRewardPanelButtonClick_hotfix != null)
			{
				this.m_OnRewardPanelButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.EnablePipelineStateMask(RaffleUITask.PipeLineStateMaskType.ShowRewardPanel);
			base.StartUpdatePipeLine(this.m_currIntent, false, false, true);
		}

		// Token: 0x060125BA RID: 75194 RVA: 0x004B76CC File Offset: 0x004B58CC
		protected void OnDoRaffleButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnDoRaffleButtonClick_hotfix != null)
			{
				this.m_OnDoRaffleButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = this.PlayerCtx.CanDraw(this.m_rafflePool.PoolId);
			if (num != -2219)
			{
				if (num != -500)
				{
					if (num != 0)
					{
						this.ShowErrorTipWnd(num);
					}
					else
					{
						RaffleDrawNetTask raffleDrawNetTask = new RaffleDrawNetTask(this.m_rafflePool.PoolId);
						raffleDrawNetTask.EventOnStop += delegate(Task task)
						{
							RaffleDrawNetTask returnTask = task as RaffleDrawNetTask;
							if (returnTask.Result == 0)
							{
								if (!this.IsSrBox(returnTask.DrawnGoods))
								{
									this.StartDrawAnimation(returnTask.DrawnRaffleId, new List<Goods>
									{
										returnTask.DrawnGoods
									});
								}
								else
								{
									this.OpenSrBox(returnTask.DrawnGoods, delegate(List<Goods> goods)
									{
										if (goods != null && goods.Count > 0)
										{
											this.StartDrawAnimation(returnTask.DrawnRaffleId, goods);
										}
									});
								}
								return;
							}
							this.ShowErrorTipWnd(returnTask.Result);
						};
						raffleDrawNetTask.Start(null);
					}
				}
				else
				{
					BagFullUITask.StartUITask(this.m_currIntent);
				}
			}
			else if (this.m_rafflePool.Config.GoodsType == GoodsType.GoodsType_Crystal)
			{
				this.ShowNotEnoughCrystalMsgBox();
			}
			else
			{
				this.ShowNotEoughItemMsgBox();
			}
		}

		// Token: 0x060125BB RID: 75195 RVA: 0x004B77DC File Offset: 0x004B59DC
		protected void StartDrawAnimation(int raffleId, List<Goods> goods)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartDrawAnimationInt32List`1_hotfix != null)
			{
				this.m_StartDrawAnimationInt32List`1_hotfix.call(new object[]
				{
					this,
					raffleId,
					goods
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.EnablePipelineStateMask(RaffleUITask.PipeLineStateMaskType.ShowDrawAnimation);
			this.m_drawnRaffleId = raffleId;
			this.m_drawnGoods = goods;
			this.m_drawAniamtionState = RaffleUITask.DrawAnimationState.Drawing;
			base.StartUpdatePipeLine(this.m_currIntent, true, false, true);
		}

		// Token: 0x060125BC RID: 75196 RVA: 0x004B7888 File Offset: 0x004B5A88
		protected void OpenSrBox(Goods goods, Action<List<Goods>> onEnd)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OpenSrBoxGoodsAction`1_hotfix != null)
			{
				this.m_OpenSrBoxGoodsAction`1_hotfix.call(new object[]
				{
					this,
					goods,
					onEnd2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Action<List<Goods>> onEnd = onEnd2;
			BagItemUseNetTask bagItemUseNetTask = new BagItemUseNetTask(goods.GoodsType, goods.Id, goods.Count);
			bagItemUseNetTask.EventOnStop += delegate(Task task)
			{
				BagItemUseNetTask bagItemUseNetTask2 = task as BagItemUseNetTask;
				if (bagItemUseNetTask2.Result == 0)
				{
					onEnd(bagItemUseNetTask2.Reward);
				}
				else
				{
					CommonUIController.Instance.ShowErrorMessage(bagItemUseNetTask2.Result, 2f, null, true);
					onEnd(null);
				}
			};
			bagItemUseNetTask.Start(null);
		}

		// Token: 0x060125BD RID: 75197 RVA: 0x004B7948 File Offset: 0x004B5B48
		protected bool IsSrBox(Goods goods)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsSrBoxGoods_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsSrBoxGoods_hotfix.call(new object[]
				{
					this,
					goods
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (goods.GoodsType == GoodsType.GoodsType_Item)
			{
				ConfigDataItemInfo configDataItemInfo = (GameManager.Instance.ConfigDataLoader as ClientConfigDataLoader).GetConfigDataItemInfo(goods.Id);
				if (configDataItemInfo != null && (configDataItemInfo.FuncType == ItemFuncType.ItemFuncType_StaticBox || configDataItemInfo.FuncType == ItemFuncType.ItemFuncType_RandomBox))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x060125BE RID: 75198 RVA: 0x004B7A10 File Offset: 0x004B5C10
		protected void OnRechargeDialogResult(DialogBoxResult result)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnRechargeDialogResultDialogBoxResult_hotfix != null)
			{
				this.m_OnRechargeDialogResultDialogBoxResult_hotfix.call(new object[]
				{
					this,
					result
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (result != DialogBoxResult.Cancel)
			{
				if (result == DialogBoxResult.Ok)
				{
					base.Pause();
					StoreUITask.StartUITask(this.m_currIntent, StoreId.StoreId_Recharge, null, false);
				}
			}
		}

		// Token: 0x060125BF RID: 75199 RVA: 0x004B7AC0 File Offset: 0x004B5CC0
		protected void OnNotEnoughItemDialogResult(DialogBoxResult result)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnNotEnoughItemDialogResultDialogBoxResult_hotfix != null)
			{
				this.m_OnNotEnoughItemDialogResultDialogBoxResult_hotfix.call(new object[]
				{
					this,
					result
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (result != DialogBoxResult.Cancel)
			{
				if (result != DialogBoxResult.Ok)
				{
				}
			}
		}

		// Token: 0x060125C0 RID: 75200 RVA: 0x004B7B54 File Offset: 0x004B5D54
		protected void OnRewardPanelCloseButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnRewardPanelCloseButtonClick_hotfix != null)
			{
				this.m_OnRewardPanelCloseButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_rewardPanelCtrl.ShowRaffleRewardPanel(false, null);
		}

		// Token: 0x060125C1 RID: 75201 RVA: 0x004B7BC4 File Offset: 0x004B5DC4
		protected void OnLevelEffectBgButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnLevelEffectBgButtonClick_hotfix != null)
			{
				this.m_OnLevelEffectBgButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			RaffleItem raffleItem = this.PlayerCtx.GetRaffleItem(this.m_rafflePool, this.m_drawnRaffleId);
			this.m_mainCtrl.ShowDrawRewardLevelEffect(raffleItem.RaffleLevel, false);
			this.EnablePipelineStateMask(RaffleUITask.PipeLineStateMaskType.ShowDrawAnimation);
			this.m_drawAniamtionState = RaffleUITask.DrawAnimationState.RewardDetail;
			base.StartUpdatePipeLine(this.m_currIntent, true, false, true);
		}

		// Token: 0x060125C2 RID: 75202 RVA: 0x004B7C6C File Offset: 0x004B5E6C
		protected void OnRewardGoodsUITaskClose()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnRewardGoodsUITaskClose_hotfix != null)
			{
				this.m_OnRewardGoodsUITaskClose_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_getRewardGoodsUITask.EventOnClose -= this.OnRewardGoodsUITaskClose;
			this.EnablePipelineStateMask(RaffleUITask.PipeLineStateMaskType.ShowDrawAnimation);
			this.m_drawAniamtionState = RaffleUITask.DrawAnimationState.Idle;
			base.StartUpdatePipeLine(this.m_currIntent, true, false, true);
		}

		// Token: 0x060125C3 RID: 75203 RVA: 0x004B7D04 File Offset: 0x004B5F04
		protected void ShowErrorTipWnd(int errorCode)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowErrorTipWndInt32_hotfix != null)
			{
				this.m_ShowErrorTipWndInt32_hotfix.call(new object[]
				{
					this,
					errorCode
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIController.Instance.ShowErrorMessage(errorCode, 2f, null, true);
		}

		// Token: 0x060125C4 RID: 75204 RVA: 0x004B7D88 File Offset: 0x004B5F88
		protected bool IsPipelineStateMaskNeedUpdate(RaffleUITask.PipeLineStateMaskType state)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsPipelineStateMaskNeedUpdatePipeLineStateMaskType_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsPipelineStateMaskNeedUpdatePipeLineStateMaskType_hotfix.call(new object[]
				{
					this,
					state
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_currPipeLineCtx.IsNeedUpdate((int)state);
		}

		// Token: 0x060125C5 RID: 75205 RVA: 0x004B7E10 File Offset: 0x004B6010
		protected void EnablePipelineStateMask(RaffleUITask.PipeLineStateMaskType state)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_EnablePipelineStateMaskPipeLineStateMaskType_hotfix != null)
			{
				this.m_EnablePipelineStateMaskPipeLineStateMaskType_hotfix.call(new object[]
				{
					this,
					state
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_currPipeLineCtx.AddUpdateMask((int)state);
		}

		// Token: 0x060125C6 RID: 75206 RVA: 0x004B7E8C File Offset: 0x004B608C
		protected void ShowNotEnoughCrystalMsgBox()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowNotEnoughCrystalMsgBox_hotfix != null)
			{
				this.m_ShowNotEnoughCrystalMsgBox_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			string msgText = this.ConfigDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Raffle_NotEnoughCrystal);
			string okText = this.ConfigDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Raffle_NotEnoughCrystalRechargeConfirm);
			string cancelText = this.ConfigDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_DialogBox_Cancel);
			CommonUIController.Instance.ShowDialogBox(msgText, new Action<DialogBoxResult>(this.OnRechargeDialogResult), okText, cancelText);
		}

		// Token: 0x060125C7 RID: 75207 RVA: 0x004B7F38 File Offset: 0x004B6138
		protected void ShowNotEoughItemMsgBox()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowNotEoughItemMsgBox_hotfix != null)
			{
				this.m_ShowNotEoughItemMsgBox_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			string format = this.ConfigDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Raffle_NotEnoughItem);
			string okText = this.ConfigDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_DialogBox_Ok);
			string msgText = string.Format(format, UIUtility.GetGoodsName(this.m_rafflePool.Config.GoodsType, this.m_rafflePool.Config.DrawItemID));
			CommonUIController.Instance.ShowDialogBox(msgText, new Action<DialogBoxResult>(this.OnNotEnoughItemDialogResult), okText, null);
		}

		// Token: 0x170037B7 RID: 14263
		// (get) Token: 0x060125C8 RID: 75208 RVA: 0x004B8000 File Offset: 0x004B6200
		protected ProjectLPlayerContext PlayerCtx
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_PlayerCtx_hotfix != null)
				{
					return (ProjectLPlayerContext)this.m_get_PlayerCtx_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			}
		}

		// Token: 0x170037B8 RID: 14264
		// (get) Token: 0x060125C9 RID: 75209 RVA: 0x004B807C File Offset: 0x004B627C
		protected IConfigDataLoader ConfigDataLoader
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_ConfigDataLoader_hotfix != null)
				{
					return (IConfigDataLoader)this.m_get_ConfigDataLoader_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			}
		}

		// Token: 0x170037B9 RID: 14265
		// (get) Token: 0x060125CA RID: 75210 RVA: 0x004B80F8 File Offset: 0x004B62F8
		protected override UITaskBase.LayerDesc[] LayerDescArray
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_LayerDescArray_hotfix != null)
				{
					return (UITaskBase.LayerDesc[])this.m_get_LayerDescArray_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_layerDescArray;
			}
		}

		// Token: 0x170037BA RID: 14266
		// (get) Token: 0x060125CB RID: 75211 RVA: 0x004B816C File Offset: 0x004B636C
		protected override UITaskBase.UIControllerDesc[] UICtrlDescArray
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_UICtrlDescArray_hotfix != null)
				{
					return (UITaskBase.UIControllerDesc[])this.m_get_UICtrlDescArray_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_uiCtrlDescArray;
			}
		}

		// Token: 0x170037BB RID: 14267
		// (get) Token: 0x060125CC RID: 75212 RVA: 0x004B81E0 File Offset: 0x004B63E0
		// (set) Token: 0x060125CD RID: 75213 RVA: 0x004B8200 File Offset: 0x004B6400
		[DoNotToLua]
		public new RaffleUITask.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new RaffleUITask.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x060125CE RID: 75214 RVA: 0x004B820C File Offset: 0x004B640C
		private bool __callBase_OnStart(UIIntent intent)
		{
			return base.OnStart(intent);
		}

		// Token: 0x060125CF RID: 75215 RVA: 0x004B8218 File Offset: 0x004B6418
		private void __callBase_OnStop()
		{
			base.OnStop();
		}

		// Token: 0x060125D0 RID: 75216 RVA: 0x004B8220 File Offset: 0x004B6420
		private void __callBase_OnPause()
		{
			base.OnPause();
		}

		// Token: 0x060125D1 RID: 75217 RVA: 0x004B8228 File Offset: 0x004B6428
		private bool __callBase_OnResume(UIIntent intent)
		{
			return base.OnResume(intent);
		}

		// Token: 0x060125D2 RID: 75218 RVA: 0x004B8234 File Offset: 0x004B6434
		private bool __callBase_OnNewIntent(UIIntent intent)
		{
			return base.OnNewIntent(intent);
		}

		// Token: 0x060125D3 RID: 75219 RVA: 0x004B8240 File Offset: 0x004B6440
		private void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
		{
			base.EnableUIInput(isEnable, isGlobalEnable);
		}

		// Token: 0x060125D4 RID: 75220 RVA: 0x004B824C File Offset: 0x004B644C
		private bool __callBase_IsNeedLoadDynamicRes()
		{
			return base.IsNeedLoadDynamicRes();
		}

		// Token: 0x060125D5 RID: 75221 RVA: 0x004B8254 File Offset: 0x004B6454
		private List<string> __callBase_CollectAllDynamicResForLoad()
		{
			return base.CollectAllDynamicResForLoad();
		}

		// Token: 0x060125D6 RID: 75222 RVA: 0x004B825C File Offset: 0x004B645C
		private void __callBase_RegisterPlayerContextEvents()
		{
			base.RegisterPlayerContextEvents();
		}

		// Token: 0x060125D7 RID: 75223 RVA: 0x004B8264 File Offset: 0x004B6464
		private void __callBase_UnregisterPlayerContextEvents()
		{
			base.UnregisterPlayerContextEvents();
		}

		// Token: 0x060125D8 RID: 75224 RVA: 0x004B826C File Offset: 0x004B646C
		private void __callBase_PostUpdateView()
		{
			base.PostUpdateView();
		}

		// Token: 0x060125D9 RID: 75225 RVA: 0x004B8274 File Offset: 0x004B6474
		private void __callBase_CollectPreloadResourceList()
		{
			base.CollectPreloadResourceList();
		}

		// Token: 0x060125DA RID: 75226 RVA: 0x004B827C File Offset: 0x004B647C
		private void __callBase_ClearAssetList()
		{
			base.ClearAssetList();
		}

		// Token: 0x060125DB RID: 75227 RVA: 0x004B8284 File Offset: 0x004B6484
		private void __callBase_CollectAsset(string assetName)
		{
			base.CollectAsset(assetName);
		}

		// Token: 0x060125DC RID: 75228 RVA: 0x004B8290 File Offset: 0x004B6490
		private void __callBase_CollectSpriteAsset(string assetName)
		{
			base.CollectSpriteAsset(assetName);
		}

		// Token: 0x060125DD RID: 75229 RVA: 0x004B829C File Offset: 0x004B649C
		private void __callBase_CollectFxAsset(string assetName)
		{
			base.CollectFxAsset(assetName);
		}

		// Token: 0x060125DE RID: 75230 RVA: 0x004B82A8 File Offset: 0x004B64A8
		private void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
		{
			base.StartLoadCustomAssets(onLoadCompleted);
		}

		// Token: 0x060125DF RID: 75231 RVA: 0x004B82B4 File Offset: 0x004B64B4
		private bool __callBase_IsLoadingCustomAssets()
		{
			return base.IsLoadingCustomAssets();
		}

		// Token: 0x060125E0 RID: 75232 RVA: 0x004B82BC File Offset: 0x004B64BC
		private bool __callBase_IsPipeLineRunning()
		{
			return base.IsPipeLineRunning();
		}

		// Token: 0x060125E1 RID: 75233 RVA: 0x004B82C4 File Offset: 0x004B64C4
		private bool __callBase_IsOpeningUI()
		{
			return base.IsOpeningUI();
		}

		// Token: 0x060125E2 RID: 75234 RVA: 0x004B82CC File Offset: 0x004B64CC
		private UITaskBase __callBase_ReturnPrevUITask()
		{
			return base.ReturnPrevUITask();
		}

		// Token: 0x060125E3 RID: 75235 RVA: 0x004B82D4 File Offset: 0x004B64D4
		private void __callBase_ClearUnusedDynamicResourceCache()
		{
			base.ClearUnusedDynamicResourceCache();
		}

		// Token: 0x060125E4 RID: 75236 RVA: 0x004B82DC File Offset: 0x004B64DC
		private void __callBase_OnMemoryWarning()
		{
			base.OnMemoryWarning();
		}

		// Token: 0x060125E9 RID: 75241 RVA: 0x004B83E4 File Offset: 0x004B65E4
		private bool InitHotFix(LuaTable A_1)
		{
			this.m_luaObjHelper = new BJLuaObjHelper();
			this.m_luaObjHelper.InitInCS(this, A_1);
			LuaFunction luaFunction = A_1.RawGet("HotFixObject") as LuaFunction;
			bool result;
			if (luaFunction == null)
			{
				Debug.LogError("Can't find HotFixObject Func");
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
					this.m_ctorString_hotfix = (luaObj.RawGet("ctor") as LuaFunction);
					this.m_OnStartUIIntent_hotfix = (luaObj.RawGet("OnStart") as LuaFunction);
					this.m_OnStop_hotfix = (luaObj.RawGet("OnStop") as LuaFunction);
					this.m_OnPause_hotfix = (luaObj.RawGet("OnPause") as LuaFunction);
					this.m_OnResumeUIIntent_hotfix = (luaObj.RawGet("OnResume") as LuaFunction);
					this.m_IsNeedUpdateDataCache_hotfix = (luaObj.RawGet("IsNeedUpdateDataCache") as LuaFunction);
					this.m_UpdateDataCache_hotfix = (luaObj.RawGet("UpdateDataCache") as LuaFunction);
					this.m_IsNeedLoadDynamicRes_hotfix = (luaObj.RawGet("IsNeedLoadDynamicRes") as LuaFunction);
					this.m_InitLayerStateOnLoadAllResCompleted_hotfix = (luaObj.RawGet("InitLayerStateOnLoadAllResCompleted") as LuaFunction);
					this.m_InitLayerStateOnResume_hotfix = (luaObj.RawGet("InitLayerStateOnResume") as LuaFunction);
					this.m_InitAllUIControllers_hotfix = (luaObj.RawGet("InitAllUIControllers") as LuaFunction);
					this.m_UpdateView_hotfix = (luaObj.RawGet("UpdateView") as LuaFunction);
					this.m_UpdateDrawAnimation_hotfix = (luaObj.RawGet("UpdateDrawAnimation") as LuaFunction);
					this.m_ClearContextOnPause_hotfix = (luaObj.RawGet("ClearContextOnPause") as LuaFunction);
					this.m_OnBgButtonClick_hotfix = (luaObj.RawGet("OnBgButtonClick") as LuaFunction);
					this.m_OnShowHelpButtonClick_hotfix = (luaObj.RawGet("OnShowHelpButtonClick") as LuaFunction);
					this.m_OnRewardPanelButtonClick_hotfix = (luaObj.RawGet("OnRewardPanelButtonClick") as LuaFunction);
					this.m_OnDoRaffleButtonClick_hotfix = (luaObj.RawGet("OnDoRaffleButtonClick") as LuaFunction);
					this.m_StartDrawAnimationInt32List`1_hotfix = (luaObj.RawGet("StartDrawAnimation") as LuaFunction);
					this.m_OpenSrBoxGoodsAction`1_hotfix = (luaObj.RawGet("OpenSrBox") as LuaFunction);
					this.m_IsSrBoxGoods_hotfix = (luaObj.RawGet("IsSrBox") as LuaFunction);
					this.m_OnRechargeDialogResultDialogBoxResult_hotfix = (luaObj.RawGet("OnRechargeDialogResult") as LuaFunction);
					this.m_OnNotEnoughItemDialogResultDialogBoxResult_hotfix = (luaObj.RawGet("OnNotEnoughItemDialogResult") as LuaFunction);
					this.m_OnRewardPanelCloseButtonClick_hotfix = (luaObj.RawGet("OnRewardPanelCloseButtonClick") as LuaFunction);
					this.m_OnLevelEffectBgButtonClick_hotfix = (luaObj.RawGet("OnLevelEffectBgButtonClick") as LuaFunction);
					this.m_OnRewardGoodsUITaskClose_hotfix = (luaObj.RawGet("OnRewardGoodsUITaskClose") as LuaFunction);
					this.m_ShowErrorTipWndInt32_hotfix = (luaObj.RawGet("ShowErrorTipWnd") as LuaFunction);
					this.m_IsPipelineStateMaskNeedUpdatePipeLineStateMaskType_hotfix = (luaObj.RawGet("IsPipelineStateMaskNeedUpdate") as LuaFunction);
					this.m_EnablePipelineStateMaskPipeLineStateMaskType_hotfix = (luaObj.RawGet("EnablePipelineStateMask") as LuaFunction);
					this.m_ShowNotEnoughCrystalMsgBox_hotfix = (luaObj.RawGet("ShowNotEnoughCrystalMsgBox") as LuaFunction);
					this.m_ShowNotEoughItemMsgBox_hotfix = (luaObj.RawGet("ShowNotEoughItemMsgBox") as LuaFunction);
					this.m_get_PlayerCtx_hotfix = (luaObj.RawGet("get_PlayerCtx") as LuaFunction);
					this.m_get_ConfigDataLoader_hotfix = (luaObj.RawGet("get_ConfigDataLoader") as LuaFunction);
					this.m_get_LayerDescArray_hotfix = (luaObj.RawGet("get_LayerDescArray") as LuaFunction);
					this.m_get_UICtrlDescArray_hotfix = (luaObj.RawGet("get_UICtrlDescArray") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x060125EA RID: 75242 RVA: 0x004B8804 File Offset: 0x004B6A04
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(RaffleUITask));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400A549 RID: 42313
		protected GetRewardGoodsUITask m_getRewardGoodsUITask;

		// Token: 0x0400A54A RID: 42314
		protected SceneLayerBase m_rewardPanelLayer;

		// Token: 0x0400A54B RID: 42315
		protected RaffleUIController m_mainCtrl;

		// Token: 0x0400A54C RID: 42316
		protected Raffle3DUIController m_raffle3dUICtrl;

		// Token: 0x0400A54D RID: 42317
		protected RaffleRewardUIController m_rewardPanelCtrl;

		// Token: 0x0400A54E RID: 42318
		protected RafflePool m_rafflePool;

		// Token: 0x0400A54F RID: 42319
		protected RaffleUITask.DrawAnimationState m_drawAniamtionState;

		// Token: 0x0400A550 RID: 42320
		protected int m_drawnRaffleId;

		// Token: 0x0400A551 RID: 42321
		protected List<Goods> m_drawnGoods = new List<Goods>();

		// Token: 0x0400A552 RID: 42322
		public Action EventOnClose;

		// Token: 0x0400A553 RID: 42323
		public static string ParamKey_PoolId = "PoolId";

		// Token: 0x0400A554 RID: 42324
		private UITaskBase.LayerDesc[] m_layerDescArray = new UITaskBase.LayerDesc[]
		{
			new UITaskBase.LayerDesc
			{
				m_layerName = "RaffleUILayer",
				m_layerResPath = "Assets/GameProject/RuntimeAssets/UI/Activity_ABS/Prefab/RaffleUIPanel.prefab",
				m_isUILayer = true
			},
			new UITaskBase.LayerDesc
			{
				m_layerName = "RaffleRewardPanelUILayer",
				m_layerResPath = "Assets/GameProject/RuntimeAssets/UI/Activity_ABS/Prefab/RaffleRewardUIPrefab.prefab",
				m_isUILayer = true
			}
		};

		// Token: 0x0400A555 RID: 42325
		private UITaskBase.UIControllerDesc[] m_uiCtrlDescArray = new UITaskBase.UIControllerDesc[]
		{
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "RaffleUILayer",
				m_attachPath = "RaffleUIPanel",
				m_ctrlTypeDNName = new TypeDNName("Assembly-CSharp@ BlackJack.ProjectL.UI.RaffleUIController"),
				m_ctrlName = "RaffleUIController"
			},
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "RaffleUILayer",
				m_attachPath = "./LayoutRoot/3DViewRect",
				m_ctrlTypeDNName = new TypeDNName("Assembly-CSharp@ BlackJack.ProjectL.UI.Raffle3DUIController"),
				m_ctrlName = "Raffle3DUIController"
			},
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "RaffleRewardPanelUILayer",
				m_attachPath = "RaffleRewardUIPrefab",
				m_ctrlTypeDNName = new TypeDNName("Assembly-CSharp@ BlackJack.ProjectL.UI.RaffleRewardUIController"),
				m_ctrlName = "RaffleRewardUIController"
			}
		};

		// Token: 0x0400A556 RID: 42326
		[DoNotToLua]
		private RaffleUITask.LuaExportHelper luaExportHelper;

		// Token: 0x0400A557 RID: 42327
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400A558 RID: 42328
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400A559 RID: 42329
		private LuaFunction m_ctorString_hotfix;

		// Token: 0x0400A55A RID: 42330
		private LuaFunction m_OnStartUIIntent_hotfix;

		// Token: 0x0400A55B RID: 42331
		private LuaFunction m_OnStop_hotfix;

		// Token: 0x0400A55C RID: 42332
		private LuaFunction m_OnPause_hotfix;

		// Token: 0x0400A55D RID: 42333
		private LuaFunction m_OnResumeUIIntent_hotfix;

		// Token: 0x0400A55E RID: 42334
		private LuaFunction m_IsNeedUpdateDataCache_hotfix;

		// Token: 0x0400A55F RID: 42335
		private LuaFunction m_UpdateDataCache_hotfix;

		// Token: 0x0400A560 RID: 42336
		private LuaFunction m_IsNeedLoadDynamicRes_hotfix;

		// Token: 0x0400A561 RID: 42337
		private LuaFunction m_InitLayerStateOnLoadAllResCompleted_hotfix;

		// Token: 0x0400A562 RID: 42338
		private LuaFunction m_InitLayerStateOnResume_hotfix;

		// Token: 0x0400A563 RID: 42339
		private LuaFunction m_InitAllUIControllers_hotfix;

		// Token: 0x0400A564 RID: 42340
		private LuaFunction m_UpdateView_hotfix;

		// Token: 0x0400A565 RID: 42341
		private LuaFunction m_UpdateDrawAnimation_hotfix;

		// Token: 0x0400A566 RID: 42342
		private LuaFunction m_ClearContextOnPause_hotfix;

		// Token: 0x0400A567 RID: 42343
		private LuaFunction m_OnBgButtonClick_hotfix;

		// Token: 0x0400A568 RID: 42344
		private LuaFunction m_OnShowHelpButtonClick_hotfix;

		// Token: 0x0400A569 RID: 42345
		private LuaFunction m_OnRewardPanelButtonClick_hotfix;

		// Token: 0x0400A56A RID: 42346
		private LuaFunction m_OnDoRaffleButtonClick_hotfix;

		// Token: 0x0400A56B RID: 42347
		private LuaFunction m_StartDrawAnimationInt32List;

		// Token: 0x0400A56C RID: 42348
		private LuaFunction m_OpenSrBoxGoodsAction;

		// Token: 0x0400A56D RID: 42349
		private LuaFunction m_IsSrBoxGoods_hotfix;

		// Token: 0x0400A56E RID: 42350
		private LuaFunction m_OnRechargeDialogResultDialogBoxResult_hotfix;

		// Token: 0x0400A56F RID: 42351
		private LuaFunction m_OnNotEnoughItemDialogResultDialogBoxResult_hotfix;

		// Token: 0x0400A570 RID: 42352
		private LuaFunction m_OnRewardPanelCloseButtonClick_hotfix;

		// Token: 0x0400A571 RID: 42353
		private LuaFunction m_OnLevelEffectBgButtonClick_hotfix;

		// Token: 0x0400A572 RID: 42354
		private LuaFunction m_OnRewardGoodsUITaskClose_hotfix;

		// Token: 0x0400A573 RID: 42355
		private LuaFunction m_ShowErrorTipWndInt32_hotfix;

		// Token: 0x0400A574 RID: 42356
		private LuaFunction m_IsPipelineStateMaskNeedUpdatePipeLineStateMaskType_hotfix;

		// Token: 0x0400A575 RID: 42357
		private LuaFunction m_EnablePipelineStateMaskPipeLineStateMaskType_hotfix;

		// Token: 0x0400A576 RID: 42358
		private LuaFunction m_ShowNotEnoughCrystalMsgBox_hotfix;

		// Token: 0x0400A577 RID: 42359
		private LuaFunction m_ShowNotEoughItemMsgBox_hotfix;

		// Token: 0x0400A578 RID: 42360
		private LuaFunction m_get_PlayerCtx_hotfix;

		// Token: 0x0400A579 RID: 42361
		private LuaFunction m_get_ConfigDataLoader_hotfix;

		// Token: 0x0400A57A RID: 42362
		private LuaFunction m_get_LayerDescArray_hotfix;

		// Token: 0x0400A57B RID: 42363
		private LuaFunction m_get_UICtrlDescArray_hotfix;

		// Token: 0x02000EAE RID: 3758
		public enum PipeLineStateMaskType
		{
			// Token: 0x0400A57D RID: 42365
			ShowRewardPanel,
			// Token: 0x0400A57E RID: 42366
			ShowDrawAnimation
		}

		// Token: 0x02000EAF RID: 3759
		public enum DrawAnimationState
		{
			// Token: 0x0400A580 RID: 42368
			Idle,
			// Token: 0x0400A581 RID: 42369
			Drawing,
			// Token: 0x0400A582 RID: 42370
			RewardLevel,
			// Token: 0x0400A583 RID: 42371
			RewardDetail
		}

		// Token: 0x02000EB0 RID: 3760
		public new class LuaExportHelper
		{
			// Token: 0x060125EB RID: 75243 RVA: 0x004B886C File Offset: 0x004B6A6C
			public LuaExportHelper(RaffleUITask owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x060125EC RID: 75244 RVA: 0x004B887C File Offset: 0x004B6A7C
			public bool __callBase_OnStart(UIIntent intent)
			{
				return this.m_owner.__callBase_OnStart(intent);
			}

			// Token: 0x060125ED RID: 75245 RVA: 0x004B888C File Offset: 0x004B6A8C
			public void __callBase_OnStop()
			{
				this.m_owner.__callBase_OnStop();
			}

			// Token: 0x060125EE RID: 75246 RVA: 0x004B889C File Offset: 0x004B6A9C
			public void __callBase_OnPause()
			{
				this.m_owner.__callBase_OnPause();
			}

			// Token: 0x060125EF RID: 75247 RVA: 0x004B88AC File Offset: 0x004B6AAC
			public bool __callBase_OnResume(UIIntent intent)
			{
				return this.m_owner.__callBase_OnResume(intent);
			}

			// Token: 0x060125F0 RID: 75248 RVA: 0x004B88BC File Offset: 0x004B6ABC
			public bool __callBase_OnNewIntent(UIIntent intent)
			{
				return this.m_owner.__callBase_OnNewIntent(intent);
			}

			// Token: 0x060125F1 RID: 75249 RVA: 0x004B88CC File Offset: 0x004B6ACC
			public void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
			{
				this.m_owner.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			}

			// Token: 0x060125F2 RID: 75250 RVA: 0x004B88DC File Offset: 0x004B6ADC
			public bool __callBase_IsNeedLoadDynamicRes()
			{
				return this.m_owner.__callBase_IsNeedLoadDynamicRes();
			}

			// Token: 0x060125F3 RID: 75251 RVA: 0x004B88EC File Offset: 0x004B6AEC
			public List<string> __callBase_CollectAllDynamicResForLoad()
			{
				return this.m_owner.__callBase_CollectAllDynamicResForLoad();
			}

			// Token: 0x060125F4 RID: 75252 RVA: 0x004B88FC File Offset: 0x004B6AFC
			public void __callBase_RegisterPlayerContextEvents()
			{
				this.m_owner.__callBase_RegisterPlayerContextEvents();
			}

			// Token: 0x060125F5 RID: 75253 RVA: 0x004B890C File Offset: 0x004B6B0C
			public void __callBase_UnregisterPlayerContextEvents()
			{
				this.m_owner.__callBase_UnregisterPlayerContextEvents();
			}

			// Token: 0x060125F6 RID: 75254 RVA: 0x004B891C File Offset: 0x004B6B1C
			public void __callBase_PostUpdateView()
			{
				this.m_owner.__callBase_PostUpdateView();
			}

			// Token: 0x060125F7 RID: 75255 RVA: 0x004B892C File Offset: 0x004B6B2C
			public void __callBase_CollectPreloadResourceList()
			{
				this.m_owner.__callBase_CollectPreloadResourceList();
			}

			// Token: 0x060125F8 RID: 75256 RVA: 0x004B893C File Offset: 0x004B6B3C
			public void __callBase_ClearAssetList()
			{
				this.m_owner.__callBase_ClearAssetList();
			}

			// Token: 0x060125F9 RID: 75257 RVA: 0x004B894C File Offset: 0x004B6B4C
			public void __callBase_CollectAsset(string assetName)
			{
				this.m_owner.__callBase_CollectAsset(assetName);
			}

			// Token: 0x060125FA RID: 75258 RVA: 0x004B895C File Offset: 0x004B6B5C
			public void __callBase_CollectSpriteAsset(string assetName)
			{
				this.m_owner.__callBase_CollectSpriteAsset(assetName);
			}

			// Token: 0x060125FB RID: 75259 RVA: 0x004B896C File Offset: 0x004B6B6C
			public void __callBase_CollectFxAsset(string assetName)
			{
				this.m_owner.__callBase_CollectFxAsset(assetName);
			}

			// Token: 0x060125FC RID: 75260 RVA: 0x004B897C File Offset: 0x004B6B7C
			public void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
			{
				this.m_owner.__callBase_StartLoadCustomAssets(onLoadCompleted);
			}

			// Token: 0x060125FD RID: 75261 RVA: 0x004B898C File Offset: 0x004B6B8C
			public bool __callBase_IsLoadingCustomAssets()
			{
				return this.m_owner.__callBase_IsLoadingCustomAssets();
			}

			// Token: 0x060125FE RID: 75262 RVA: 0x004B899C File Offset: 0x004B6B9C
			public bool __callBase_IsPipeLineRunning()
			{
				return this.m_owner.__callBase_IsPipeLineRunning();
			}

			// Token: 0x060125FF RID: 75263 RVA: 0x004B89AC File Offset: 0x004B6BAC
			public bool __callBase_IsOpeningUI()
			{
				return this.m_owner.__callBase_IsOpeningUI();
			}

			// Token: 0x06012600 RID: 75264 RVA: 0x004B89BC File Offset: 0x004B6BBC
			public UITaskBase __callBase_ReturnPrevUITask()
			{
				return this.m_owner.__callBase_ReturnPrevUITask();
			}

			// Token: 0x06012601 RID: 75265 RVA: 0x004B89CC File Offset: 0x004B6BCC
			public void __callBase_ClearUnusedDynamicResourceCache()
			{
				this.m_owner.__callBase_ClearUnusedDynamicResourceCache();
			}

			// Token: 0x06012602 RID: 75266 RVA: 0x004B89DC File Offset: 0x004B6BDC
			public void __callBase_OnMemoryWarning()
			{
				this.m_owner.__callBase_OnMemoryWarning();
			}

			// Token: 0x170037BC RID: 14268
			// (get) Token: 0x06012603 RID: 75267 RVA: 0x004B89EC File Offset: 0x004B6BEC
			// (set) Token: 0x06012604 RID: 75268 RVA: 0x004B89FC File Offset: 0x004B6BFC
			public GetRewardGoodsUITask m_getRewardGoodsUITask
			{
				get
				{
					return this.m_owner.m_getRewardGoodsUITask;
				}
				set
				{
					this.m_owner.m_getRewardGoodsUITask = value;
				}
			}

			// Token: 0x170037BD RID: 14269
			// (get) Token: 0x06012605 RID: 75269 RVA: 0x004B8A0C File Offset: 0x004B6C0C
			// (set) Token: 0x06012606 RID: 75270 RVA: 0x004B8A1C File Offset: 0x004B6C1C
			public SceneLayerBase m_rewardPanelLayer
			{
				get
				{
					return this.m_owner.m_rewardPanelLayer;
				}
				set
				{
					this.m_owner.m_rewardPanelLayer = value;
				}
			}

			// Token: 0x170037BE RID: 14270
			// (get) Token: 0x06012607 RID: 75271 RVA: 0x004B8A2C File Offset: 0x004B6C2C
			// (set) Token: 0x06012608 RID: 75272 RVA: 0x004B8A3C File Offset: 0x004B6C3C
			public RaffleUIController m_mainCtrl
			{
				get
				{
					return this.m_owner.m_mainCtrl;
				}
				set
				{
					this.m_owner.m_mainCtrl = value;
				}
			}

			// Token: 0x170037BF RID: 14271
			// (get) Token: 0x06012609 RID: 75273 RVA: 0x004B8A4C File Offset: 0x004B6C4C
			// (set) Token: 0x0601260A RID: 75274 RVA: 0x004B8A5C File Offset: 0x004B6C5C
			public Raffle3DUIController m_raffle3dUICtrl
			{
				get
				{
					return this.m_owner.m_raffle3dUICtrl;
				}
				set
				{
					this.m_owner.m_raffle3dUICtrl = value;
				}
			}

			// Token: 0x170037C0 RID: 14272
			// (get) Token: 0x0601260B RID: 75275 RVA: 0x004B8A6C File Offset: 0x004B6C6C
			// (set) Token: 0x0601260C RID: 75276 RVA: 0x004B8A7C File Offset: 0x004B6C7C
			public RaffleRewardUIController m_rewardPanelCtrl
			{
				get
				{
					return this.m_owner.m_rewardPanelCtrl;
				}
				set
				{
					this.m_owner.m_rewardPanelCtrl = value;
				}
			}

			// Token: 0x170037C1 RID: 14273
			// (get) Token: 0x0601260D RID: 75277 RVA: 0x004B8A8C File Offset: 0x004B6C8C
			// (set) Token: 0x0601260E RID: 75278 RVA: 0x004B8A9C File Offset: 0x004B6C9C
			public RafflePool m_rafflePool
			{
				get
				{
					return this.m_owner.m_rafflePool;
				}
				set
				{
					this.m_owner.m_rafflePool = value;
				}
			}

			// Token: 0x170037C2 RID: 14274
			// (get) Token: 0x0601260F RID: 75279 RVA: 0x004B8AAC File Offset: 0x004B6CAC
			// (set) Token: 0x06012610 RID: 75280 RVA: 0x004B8ABC File Offset: 0x004B6CBC
			public RaffleUITask.DrawAnimationState m_drawAniamtionState
			{
				get
				{
					return this.m_owner.m_drawAniamtionState;
				}
				set
				{
					this.m_owner.m_drawAniamtionState = value;
				}
			}

			// Token: 0x170037C3 RID: 14275
			// (get) Token: 0x06012611 RID: 75281 RVA: 0x004B8ACC File Offset: 0x004B6CCC
			// (set) Token: 0x06012612 RID: 75282 RVA: 0x004B8ADC File Offset: 0x004B6CDC
			public int m_drawnRaffleId
			{
				get
				{
					return this.m_owner.m_drawnRaffleId;
				}
				set
				{
					this.m_owner.m_drawnRaffleId = value;
				}
			}

			// Token: 0x170037C4 RID: 14276
			// (get) Token: 0x06012613 RID: 75283 RVA: 0x004B8AEC File Offset: 0x004B6CEC
			// (set) Token: 0x06012614 RID: 75284 RVA: 0x004B8AFC File Offset: 0x004B6CFC
			public List<Goods> m_drawnGoods
			{
				get
				{
					return this.m_owner.m_drawnGoods;
				}
				set
				{
					this.m_owner.m_drawnGoods = value;
				}
			}

			// Token: 0x170037C5 RID: 14277
			// (get) Token: 0x06012615 RID: 75285 RVA: 0x004B8B0C File Offset: 0x004B6D0C
			// (set) Token: 0x06012616 RID: 75286 RVA: 0x004B8B1C File Offset: 0x004B6D1C
			public UITaskBase.LayerDesc[] m_layerDescArray
			{
				get
				{
					return this.m_owner.m_layerDescArray;
				}
				set
				{
					this.m_owner.m_layerDescArray = value;
				}
			}

			// Token: 0x170037C6 RID: 14278
			// (get) Token: 0x06012617 RID: 75287 RVA: 0x004B8B2C File Offset: 0x004B6D2C
			// (set) Token: 0x06012618 RID: 75288 RVA: 0x004B8B3C File Offset: 0x004B6D3C
			public UITaskBase.UIControllerDesc[] m_uiCtrlDescArray
			{
				get
				{
					return this.m_owner.m_uiCtrlDescArray;
				}
				set
				{
					this.m_owner.m_uiCtrlDescArray = value;
				}
			}

			// Token: 0x170037C7 RID: 14279
			// (get) Token: 0x06012619 RID: 75289 RVA: 0x004B8B4C File Offset: 0x004B6D4C
			public ProjectLPlayerContext PlayerCtx
			{
				get
				{
					return this.m_owner.PlayerCtx;
				}
			}

			// Token: 0x170037C8 RID: 14280
			// (get) Token: 0x0601261A RID: 75290 RVA: 0x004B8B5C File Offset: 0x004B6D5C
			public IConfigDataLoader ConfigDataLoader
			{
				get
				{
					return this.m_owner.ConfigDataLoader;
				}
			}

			// Token: 0x170037C9 RID: 14281
			// (get) Token: 0x0601261B RID: 75291 RVA: 0x004B8B6C File Offset: 0x004B6D6C
			public UITaskBase.LayerDesc[] LayerDescArray
			{
				get
				{
					return this.m_owner.LayerDescArray;
				}
			}

			// Token: 0x170037CA RID: 14282
			// (get) Token: 0x0601261C RID: 75292 RVA: 0x004B8B7C File Offset: 0x004B6D7C
			public UITaskBase.UIControllerDesc[] UICtrlDescArray
			{
				get
				{
					return this.m_owner.UICtrlDescArray;
				}
			}

			// Token: 0x0601261D RID: 75293 RVA: 0x004B8B8C File Offset: 0x004B6D8C
			public bool OnStart(UIIntent intent)
			{
				return this.m_owner.OnStart(intent);
			}

			// Token: 0x0601261E RID: 75294 RVA: 0x004B8B9C File Offset: 0x004B6D9C
			public void OnStop()
			{
				this.m_owner.OnStop();
			}

			// Token: 0x0601261F RID: 75295 RVA: 0x004B8BAC File Offset: 0x004B6DAC
			public void OnPause()
			{
				this.m_owner.OnPause();
			}

			// Token: 0x06012620 RID: 75296 RVA: 0x004B8BBC File Offset: 0x004B6DBC
			public bool OnResume(UIIntent intent)
			{
				return this.m_owner.OnResume(intent);
			}

			// Token: 0x06012621 RID: 75297 RVA: 0x004B8BCC File Offset: 0x004B6DCC
			public bool IsNeedUpdateDataCache()
			{
				return this.m_owner.IsNeedUpdateDataCache();
			}

			// Token: 0x06012622 RID: 75298 RVA: 0x004B8BDC File Offset: 0x004B6DDC
			public void UpdateDataCache()
			{
				this.m_owner.UpdateDataCache();
			}

			// Token: 0x06012623 RID: 75299 RVA: 0x004B8BEC File Offset: 0x004B6DEC
			public bool IsNeedLoadDynamicRes()
			{
				return this.m_owner.IsNeedLoadDynamicRes();
			}

			// Token: 0x06012624 RID: 75300 RVA: 0x004B8BFC File Offset: 0x004B6DFC
			public void InitLayerStateOnLoadAllResCompleted()
			{
				this.m_owner.InitLayerStateOnLoadAllResCompleted();
			}

			// Token: 0x06012625 RID: 75301 RVA: 0x004B8C0C File Offset: 0x004B6E0C
			public void InitLayerStateOnResume()
			{
				this.m_owner.InitLayerStateOnResume();
			}

			// Token: 0x06012626 RID: 75302 RVA: 0x004B8C1C File Offset: 0x004B6E1C
			public void InitAllUIControllers()
			{
				this.m_owner.InitAllUIControllers();
			}

			// Token: 0x06012627 RID: 75303 RVA: 0x004B8C2C File Offset: 0x004B6E2C
			public void UpdateView()
			{
				this.m_owner.UpdateView();
			}

			// Token: 0x06012628 RID: 75304 RVA: 0x004B8C3C File Offset: 0x004B6E3C
			public void UpdateDrawAnimation()
			{
				this.m_owner.UpdateDrawAnimation();
			}

			// Token: 0x06012629 RID: 75305 RVA: 0x004B8C4C File Offset: 0x004B6E4C
			public void ClearContextOnPause()
			{
				this.m_owner.ClearContextOnPause();
			}

			// Token: 0x0601262A RID: 75306 RVA: 0x004B8C5C File Offset: 0x004B6E5C
			public void OnBgButtonClick()
			{
				this.m_owner.OnBgButtonClick();
			}

			// Token: 0x0601262B RID: 75307 RVA: 0x004B8C6C File Offset: 0x004B6E6C
			public void OnShowHelpButtonClick()
			{
				this.m_owner.OnShowHelpButtonClick();
			}

			// Token: 0x0601262C RID: 75308 RVA: 0x004B8C7C File Offset: 0x004B6E7C
			public void OnRewardPanelButtonClick()
			{
				this.m_owner.OnRewardPanelButtonClick();
			}

			// Token: 0x0601262D RID: 75309 RVA: 0x004B8C8C File Offset: 0x004B6E8C
			public void OnDoRaffleButtonClick()
			{
				this.m_owner.OnDoRaffleButtonClick();
			}

			// Token: 0x0601262E RID: 75310 RVA: 0x004B8C9C File Offset: 0x004B6E9C
			public void StartDrawAnimation(int raffleId, List<Goods> goods)
			{
				this.m_owner.StartDrawAnimation(raffleId, goods);
			}

			// Token: 0x0601262F RID: 75311 RVA: 0x004B8CAC File Offset: 0x004B6EAC
			public void OpenSrBox(Goods goods, Action<List<Goods>> onEnd)
			{
				this.m_owner.OpenSrBox(goods, onEnd);
			}

			// Token: 0x06012630 RID: 75312 RVA: 0x004B8CBC File Offset: 0x004B6EBC
			public bool IsSrBox(Goods goods)
			{
				return this.m_owner.IsSrBox(goods);
			}

			// Token: 0x06012631 RID: 75313 RVA: 0x004B8CCC File Offset: 0x004B6ECC
			public void OnRechargeDialogResult(DialogBoxResult result)
			{
				this.m_owner.OnRechargeDialogResult(result);
			}

			// Token: 0x06012632 RID: 75314 RVA: 0x004B8CDC File Offset: 0x004B6EDC
			public void OnNotEnoughItemDialogResult(DialogBoxResult result)
			{
				this.m_owner.OnNotEnoughItemDialogResult(result);
			}

			// Token: 0x06012633 RID: 75315 RVA: 0x004B8CEC File Offset: 0x004B6EEC
			public void OnRewardPanelCloseButtonClick()
			{
				this.m_owner.OnRewardPanelCloseButtonClick();
			}

			// Token: 0x06012634 RID: 75316 RVA: 0x004B8CFC File Offset: 0x004B6EFC
			public void OnLevelEffectBgButtonClick()
			{
				this.m_owner.OnLevelEffectBgButtonClick();
			}

			// Token: 0x06012635 RID: 75317 RVA: 0x004B8D0C File Offset: 0x004B6F0C
			public void OnRewardGoodsUITaskClose()
			{
				this.m_owner.OnRewardGoodsUITaskClose();
			}

			// Token: 0x06012636 RID: 75318 RVA: 0x004B8D1C File Offset: 0x004B6F1C
			public void ShowErrorTipWnd(int errorCode)
			{
				this.m_owner.ShowErrorTipWnd(errorCode);
			}

			// Token: 0x06012637 RID: 75319 RVA: 0x004B8D2C File Offset: 0x004B6F2C
			public bool IsPipelineStateMaskNeedUpdate(RaffleUITask.PipeLineStateMaskType state)
			{
				return this.m_owner.IsPipelineStateMaskNeedUpdate(state);
			}

			// Token: 0x06012638 RID: 75320 RVA: 0x004B8D3C File Offset: 0x004B6F3C
			public void EnablePipelineStateMask(RaffleUITask.PipeLineStateMaskType state)
			{
				this.m_owner.EnablePipelineStateMask(state);
			}

			// Token: 0x06012639 RID: 75321 RVA: 0x004B8D4C File Offset: 0x004B6F4C
			public void ShowNotEnoughCrystalMsgBox()
			{
				this.m_owner.ShowNotEnoughCrystalMsgBox();
			}

			// Token: 0x0601263A RID: 75322 RVA: 0x004B8D5C File Offset: 0x004B6F5C
			public void ShowNotEoughItemMsgBox()
			{
				this.m_owner.ShowNotEoughItemMsgBox();
			}

			// Token: 0x0400A584 RID: 42372
			private RaffleUITask m_owner;
		}
	}
}
