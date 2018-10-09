using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.TaskNs;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectLBasic;
using PD.SDK;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x020009A0 RID: 2464
	[HotFix]
	public class ActivityUITask : UITask
	{
		// Token: 0x06008E8D RID: 36493 RVA: 0x00298E2C File Offset: 0x0029702C
		public ActivityUITask(string name) : base(name)
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

		// Token: 0x06008E8E RID: 36494 RVA: 0x00298F40 File Offset: 0x00297140
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
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			base.CollectSpriteAsset("UI/Common_New_ABS/Icon/Icon_Plus_01.png");
			base.CollectSpriteAsset("UI/Common_New_ABS/Icon/Icon_Equal_01.png");
			base.CollectSpriteAsset("UI/Activity_ABS/Icon_activity.png");
			base.CollectSpriteAsset("UI/Activity_ABS/Icon_Repair.png");
			foreach (OperationalActivityBase operationalActivityBase in projectLPlayerContext.GetAllCurrentActivity())
			{
				ConfigDataOperationalActivityInfo config = operationalActivityBase.Config;
				base.CollectSpriteAsset(config.AdvertisingImage);
				switch (config.ActivityType)
				{
				case OperationalActivityType.OperationalActivityType_PlayerLevelUp:
				case OperationalActivityType.OperationalActivityType_LimitedTimeExchange:
				case OperationalActivityType.OperationalActivityType_SpecificDaysLogin:
				case OperationalActivityType.OperationalActivityType_AccumulateDaysLogin:
				case OperationalActivityType.OperationalActivityType_AccumulateRecharge:
					foreach (ActivityParam activityParam in config.OperationalActivityParms)
					{
						int parm = activityParam.Parm2;
						this.CollectPoolItemsAssets(parm);
					}
					break;
				case OperationalActivityType.OperationalActivityType_Raffle:
				{
					int parm2 = config.OperationalActivityParms[0].Parm1;
					ConfigDataRafflePoolInfo configDataRafflePoolInfo = configDataLoader.GetConfigDataRafflePoolInfo(parm2);
					foreach (RaffleItem raffleItem in configDataRafflePoolInfo.RaffleItems)
					{
						base.CollectSpriteAsset(UIUtility.GetGoodsIconName(raffleItem.GoodsType, raffleItem.ItemID));
					}
					break;
				}
				}
			}
			return base.IsNeedLoadDynamicRes();
		}

		// Token: 0x06008E8F RID: 36495 RVA: 0x002991E8 File Offset: 0x002973E8
		private void CollectPoolItemsAssets(int operationalActivityItemGroupId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CollectPoolItemsAssetsInt32_hotfix != null)
			{
				this.m_CollectPoolItemsAssetsInt32_hotfix.call(new object[]
				{
					this,
					operationalActivityItemGroupId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			ConfigDataOperationalActivityItemGroupInfo configDataOperationalActivityItemGroupInfo = configDataLoader.GetConfigDataOperationalActivityItemGroupInfo(operationalActivityItemGroupId);
			if (configDataOperationalActivityItemGroupInfo == null)
			{
				return;
			}
			foreach (Goods goods in configDataOperationalActivityItemGroupInfo.ItemList)
			{
				base.CollectSpriteAsset(UIUtility.GetGoodsIconName(goods.GoodsType, goods.Id));
			}
		}

		// Token: 0x06008E90 RID: 36496 RVA: 0x002992D8 File Offset: 0x002974D8
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
			if (this.m_activityUIController == null)
			{
				if (this.m_uiCtrlArray.Length > 0)
				{
					this.m_activityUIController = (this.m_uiCtrlArray[0] as ActivityUIController);
				}
				if (!(this.m_activityUIController != null))
				{
					global::Debug.LogError("ActivityUIController is null");
					return;
				}
				this.m_activityUIController.EventOnReturn += this.ActivityUIController_OnReturn;
				this.m_activityUIController.EventOnGainReward += this.ActivityUIController_OnGainReward;
				this.m_activityUIController.EventOnExchangeItemGroup += this.ActivityUIController_OnExchangeItemGroup;
				this.m_activityUIController.EventOnAddActivity += this.ActivityUIController_OnAddActivity;
				this.m_activityUIController.EventOnGoToButtonClick += this.ActivityUIController_OnGoToButtonClick;
				this.m_activityUIController.EventOnCrystalNotEnough += this.ActivityUIController_OnCrystalNotEnough;
				this.m_activityUIController.EventOnGetRewardButtonClick += this.ActivityUIController_OnGetRewardButtonClick;
			}
		}

		// Token: 0x06008E91 RID: 36497 RVA: 0x00299434 File Offset: 0x00297634
		protected override void ClearAllContextAndRes()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ClearAllContextAndRes_hotfix != null)
			{
				this.m_ClearAllContextAndRes_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.ClearAllContextAndRes();
			if (this.m_activityUIController != null)
			{
				this.m_activityUIController.EventOnReturn -= this.ActivityUIController_OnReturn;
				this.m_activityUIController.EventOnGainReward -= this.ActivityUIController_OnGainReward;
				this.m_activityUIController.EventOnExchangeItemGroup -= this.ActivityUIController_OnExchangeItemGroup;
				this.m_activityUIController.EventOnAddActivity -= this.ActivityUIController_OnAddActivity;
				this.m_activityUIController.EventOnGoToButtonClick -= this.ActivityUIController_OnGoToButtonClick;
				this.m_activityUIController.EventOnCrystalNotEnough -= this.ActivityUIController_OnCrystalNotEnough;
				this.m_activityUIController = null;
			}
		}

		// Token: 0x06008E92 RID: 36498 RVA: 0x0029953C File Offset: 0x0029773C
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
			if (base.IsOpeningUI())
			{
				this.m_activityUIController.Open();
				this.m_activityUIController.UpdateViewInActivity();
			}
			if (this.m_activityUIController.m_activityIsOn)
			{
				this.m_activityUIController.SetCurrentActivity(false);
			}
			UIIntentCustom uiintentCustom = this.m_currIntent as UIIntentCustom;
			object obj;
			if (uiintentCustom != null && uiintentCustom.TryGetParam("ActivityId", out obj) && obj != null)
			{
				this.m_activityUIController.OpenSpecificActivity((int)obj);
				uiintentCustom.SetParam("ActivityId", null);
			}
		}

		// Token: 0x06008E93 RID: 36499 RVA: 0x00299620 File Offset: 0x00297820
		private void ActivityUIController_OnGainReward(ulong activityInstanceID, int rewardIndex, List<Goods> gainGoodsList)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ActivityUIController_OnGainRewardUInt64Int32List`1_hotfix != null)
			{
				this.m_ActivityUIController_OnGainRewardUInt64Int32List`1_hotfix.call(new object[]
				{
					this,
					activityInstanceID,
					rewardIndex,
					gainGoodsList2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<Goods> gainGoodsList = gainGoodsList2;
			ActivityUITask $this = this;
			ActivityGainRewardNetTask activityGainRewardNetTask = new ActivityGainRewardNetTask(activityInstanceID, rewardIndex);
			activityGainRewardNetTask.EventOnStop += delegate(Task task)
			{
				ActivityGainRewardNetTask activityGainRewardNetTask2 = task as ActivityGainRewardNetTask;
				if (activityGainRewardNetTask2.Result == 0)
				{
					$this.UpdateView();
					CommonUIController.Instance.StartCoroutine($this.GetGainListGoods(gainGoodsList));
				}
				else if (activityGainRewardNetTask2.Result == -500)
				{
					BagFullUITask.StartUITask($this.m_currIntent);
				}
				else
				{
					CommonUIController.Instance.ShowErrorMessage(activityGainRewardNetTask2.Result, 2f, null, true);
				}
			};
			activityGainRewardNetTask.Start(null);
		}

		// Token: 0x06008E94 RID: 36500 RVA: 0x002996E8 File Offset: 0x002978E8
		[DebuggerHidden]
		private IEnumerator GetGainListGoods(List<Goods> gainGoodsList)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetGainListGoodsList`1_hotfix != null)
			{
				return (IEnumerator)this.m_GetGainListGoodsList`1_hotfix.call(new object[]
				{
					this,
					gainGoodsList
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ActivityUITask.<GetGainListGoods>c__Iterator0 <GetGainListGoods>c__Iterator = new ActivityUITask.<GetGainListGoods>c__Iterator0();
			<GetGainListGoods>c__Iterator.gainGoodsList = gainGoodsList;
			<GetGainListGoods>c__Iterator.$this = this;
			return <GetGainListGoods>c__Iterator;
		}

		// Token: 0x06008E95 RID: 36501 RVA: 0x0029977C File Offset: 0x0029797C
		[DebuggerHidden]
		private IEnumerator DisposeBoxOpenNetTask(GoodsType type, int id, int count)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DisposeBoxOpenNetTaskGoodsTypeInt32Int32_hotfix != null)
			{
				return (IEnumerator)this.m_DisposeBoxOpenNetTaskGoodsTypeInt32Int32_hotfix.call(new object[]
				{
					this,
					type,
					id,
					count
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ActivityUITask.<DisposeBoxOpenNetTask>c__Iterator1 <DisposeBoxOpenNetTask>c__Iterator = new ActivityUITask.<DisposeBoxOpenNetTask>c__Iterator1();
			<DisposeBoxOpenNetTask>c__Iterator.type = type;
			<DisposeBoxOpenNetTask>c__Iterator.id = id;
			<DisposeBoxOpenNetTask>c__Iterator.count = count;
			<DisposeBoxOpenNetTask>c__Iterator.$this = this;
			return <DisposeBoxOpenNetTask>c__Iterator;
		}

		// Token: 0x06008E96 RID: 36502 RVA: 0x0029983C File Offset: 0x00297A3C
		private void ActivityUIController_OnExchangeItemGroup(ulong activityInstanceID, int itemGroupIndex, List<Goods> gainGoodsList)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ActivityUIController_OnExchangeItemGroupUInt64Int32List`1_hotfix != null)
			{
				this.m_ActivityUIController_OnExchangeItemGroupUInt64Int32List`1_hotfix.call(new object[]
				{
					this,
					activityInstanceID,
					itemGroupIndex,
					gainGoodsList2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<Goods> gainGoodsList = gainGoodsList2;
			ActivityUITask $this = this;
			ActivityExchangeItemGroupNetTask activityExchangeItemGroupNetTask = new ActivityExchangeItemGroupNetTask(activityInstanceID, itemGroupIndex);
			activityExchangeItemGroupNetTask.EventOnStop += delegate(Task task)
			{
				ActivityExchangeItemGroupNetTask activityExchangeItemGroupNetTask2 = task as ActivityExchangeItemGroupNetTask;
				if (activityExchangeItemGroupNetTask2.Result == 0)
				{
					$this.UpdateView();
					GetRewardGoodsUITask.StartUITask(gainGoodsList);
				}
				else
				{
					CommonUIController.Instance.ShowErrorMessage(activityExchangeItemGroupNetTask2.Result, 2f, null, true);
				}
			};
			activityExchangeItemGroupNetTask.Start(null);
		}

		// Token: 0x06008E97 RID: 36503 RVA: 0x00299904 File Offset: 0x00297B04
		private void ActivityUIController_OnAddActivity(string gmCmd)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ActivityUIController_OnAddActivityString_hotfix != null)
			{
				this.m_ActivityUIController_OnAddActivityString_hotfix.call(new object[]
				{
					this,
					gmCmd
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!LoginUITask.IsGMUser)
			{
				return;
			}
			string cmd = "POST_GLOBALOPERATIONALACTIVITY " + gmCmd;
			GmCommandNetTask gmCommandNetTask = new GmCommandNetTask(cmd);
			gmCommandNetTask.EventOnStop += delegate(Task task)
			{
				GmCommandNetTask gmCommandNetTask2 = task as GmCommandNetTask;
				if (gmCommandNetTask2.Result == 0)
				{
					this.m_activityUIController.UpdateViewInActivity();
				}
				else
				{
					CommonUIController.Instance.ShowErrorMessage(gmCommandNetTask2.Result, 2f, null, true);
				}
			};
			gmCommandNetTask.Start(null);
		}

		// Token: 0x06008E98 RID: 36504 RVA: 0x002999AC File Offset: 0x00297BAC
		private void ActivityUIController_OnReturn()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ActivityUIController_OnReturn_hotfix != null)
			{
				this.m_ActivityUIController_OnReturn_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIController.Instance.StartShowFadeOutLoadingFadeIn(delegate
			{
				CommonUIController.Instance.HideFadeOutLoadingFadeIn();
				base.Pause();
				base.ReturnPrevUITask();
			}, FadeStyle.Black, -1f, -1f);
		}

		// Token: 0x06008E99 RID: 36505 RVA: 0x00299A30 File Offset: 0x00297C30
		protected void ActivityUIController_OnGetRewardButtonClick(OperationalActivityBase activity)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ActivityUIController_OnGetRewardButtonClickOperationalActivityBase_hotfix != null)
			{
				this.m_ActivityUIController_OnGetRewardButtonClickOperationalActivityBase_hotfix.call(new object[]
				{
					this,
					activity
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			OperationalActivityType activityType = activity.ActivityType;
			if (activityType != OperationalActivityType.OperationalActivityType_Redeem)
			{
				if (activityType == OperationalActivityType.OperationalActivityType_PBTCBTFansRewards)
				{
					PBTCBTFansClaimReqNetTask pbtcbtfansClaimReqNetTask = new PBTCBTFansClaimReqNetTask();
					pbtcbtfansClaimReqNetTask.EventOnStop += delegate(Task task)
					{
						PBTCBTFansClaimReqNetTask pbtcbtfansClaimReqNetTask2 = task as PBTCBTFansClaimReqNetTask;
						if (pbtcbtfansClaimReqNetTask2.Result == 0)
						{
							this.UpdateView();
							GetRewardGoodsUITask.StartUITask(pbtcbtfansClaimReqNetTask2.goodsList);
						}
						else
						{
							CommonUIController.Instance.ShowErrorMessage(pbtcbtfansClaimReqNetTask2.Result, 2f, null, true);
						}
					};
					pbtcbtfansClaimReqNetTask.Start(null);
				}
			}
			else
			{
				RedeemClaimReqNetTask redeemClaimReqNetTask = new RedeemClaimReqNetTask();
				redeemClaimReqNetTask.EventOnStop += delegate(Task task)
				{
					RedeemClaimReqNetTask redeemClaimReqNetTask2 = task as RedeemClaimReqNetTask;
					this.UpdateView();
					if (redeemClaimReqNetTask2.CrystalVal > 0)
					{
						Goods item = new Goods
						{
							GoodsType = GoodsType.GoodsType_Crystal,
							Count = redeemClaimReqNetTask2.CrystalVal
						};
						GetRewardGoodsUITask.StartUITask(new List<Goods>
						{
							item
						});
					}
					else
					{
						CommonUIController.Instance.ShowMessage(StringTableId.StringTableId_Activity_Redeem_Error, 2f, null, true);
					}
				};
				redeemClaimReqNetTask.Start(null);
			}
		}

		// Token: 0x06008E9A RID: 36506 RVA: 0x00299B08 File Offset: 0x00297D08
		protected void ActivityUIController_OnGoToButtonClick(OperationalActivityBase activity)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ActivityUIController_OnGoToButtonClickOperationalActivityBase_hotfix != null)
			{
				this.m_ActivityUIController_OnGoToButtonClickOperationalActivityBase_hotfix.call(new object[]
				{
					this,
					activity
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			switch (activity.ActivityType)
			{
			case OperationalActivityType.OperationalActivityType_ActivitySelectCard:
			{
				ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
				if (!projectLPlayerContext.IsGameFunctionOpened(GameFunctionType.GameFunctionType_SelectCard))
				{
					CommonUIController.Instance.ShowMessage(UIUtility.GetGameFunctionOpenMessage(GameFunctionType.GameFunctionType_SelectCard), 2f, null, true);
					return;
				}
				int parm = activity.Config.OperationalActivityParms[0].Parm1;
				CardPool cardPoolById = projectLPlayerContext.GetCardPoolById(parm);
				if (cardPoolById != null)
				{
					this.StartSelectCardUITask(parm, this.m_currIntent);
				}
				else
				{
					base.StartUpdatePipeLine(null, false, false, true);
				}
				break;
			}
			case OperationalActivityType.OperationalActivityType_Raffle:
			{
				UIIntentReturnable uiintentReturnable = new UIIntentReturnable(this.m_currIntent, typeof(RaffleUITask).Name, null);
				uiintentReturnable.SetParam(RaffleUITask.ParamKey_PoolId, activity.Config.OperationalActivityParms[0].Parm1);
				UIManager.Instance.StartUITask(uiintentReturnable, true, false, null);
				break;
			}
			case OperationalActivityType.OperationalActivityType_UnchartedScore:
				CommonUIController.Instance.StartFadeOut(delegate
				{
					base.Pause();
					WorldUITask.StartGetPathTargetUITask(new GetPathData
					{
						PathType = GetPathType.GetPathType_Uncharted2
					}, this.m_currIntent, null);
				}, FadeStyle.Black, -1f);
				break;
			case OperationalActivityType.OperationalActivityType_Web:
				if (activity.Config.OperationalActivityParms != null && activity.Config.OperationalActivityParms.Count > 0)
				{
					int parm2 = activity.Config.OperationalActivityParms[0].Parm1;
					JsonData jsonData = new JsonData();
					jsonData["tag"] = parm2.ToString();
					PDSDK.Instance.callWebView(string.Empty, 1, 0, "activity", jsonData.ToJson());
				}
				break;
			case OperationalActivityType.OperationalActivityType_BuyItemGuide:
				if (activity.Config.OperationalActivityParms.Count > 0)
				{
					StoreId parm3 = (StoreId)activity.Config.OperationalActivityParms[0].Parm1;
					int parm4 = activity.Config.OperationalActivityParms[0].Parm2;
					StoreUITask.StartUITask(this.m_currIntent, parm3, new int?(parm4), false);
				}
				break;
			}
		}

		// Token: 0x06008E9B RID: 36507 RVA: 0x00299D88 File Offset: 0x00297F88
		private void StartSelectCardUITask(int cardPoolId = 0, UIIntent fromIntent = null)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartSelectCardUITaskInt32UIIntent_hotfix != null)
			{
				this.m_StartSelectCardUITaskInt32UIIntent_hotfix.call(new object[]
				{
					this,
					cardPoolId,
					fromIntent
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIIntentReturnable intent = new UIIntentReturnable((fromIntent == null) ? this.m_currIntent : fromIntent, typeof(SelectCardUITask).Name, null);
			if (cardPoolId > 0)
			{
				intent.SetParam("CardPoolID", cardPoolId);
			}
			CommonUIController.Instance.StartShowFadeOutLoadingFadeIn(delegate
			{
				UIManager.Instance.StartUITask(intent, true, false, new Action(this.SelectCardUITask_OnLoadAllResCompleted));
			}, FadeStyle.White, -1f, -1f);
		}

		// Token: 0x06008E9C RID: 36508 RVA: 0x00299E80 File Offset: 0x00298080
		private void SelectCardUITask_OnLoadAllResCompleted()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SelectCardUITask_OnLoadAllResCompleted_hotfix != null)
			{
				this.m_SelectCardUITask_OnLoadAllResCompleted_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIController.Instance.HideFadeOutLoadingFadeIn();
			UITaskBase uitaskBase = UIUtility.FindUITaskWithType(typeof(SelectCardUITask));
			if (uitaskBase != null)
			{
				base.Pause();
				uitaskBase.ReturnFromRedirectPipLineOnLoadAllResCompleted();
			}
		}

		// Token: 0x06008E9D RID: 36509 RVA: 0x00299F0C File Offset: 0x0029810C
		private void ActivityUIController_OnCrystalNotEnough()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ActivityUIController_OnCrystalNotEnough_hotfix != null)
			{
				this.m_ActivityUIController_OnCrystalNotEnough_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIController.Instance.ShowDialogBox(StringTableId.StringTableId_Msg_CrystalNotEnough, delegate(DialogBoxResult dialogResult)
			{
				if (dialogResult == DialogBoxResult.Ok)
				{
					StoreUITask.StartUITask(this.m_currIntent, StoreId.StoreId_Recharge, null, false);
				}
			}, (StringTableId)0, (StringTableId)0);
		}

		// Token: 0x17001DD2 RID: 7634
		// (get) Token: 0x06008E9E RID: 36510 RVA: 0x00299F8C File Offset: 0x0029818C
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

		// Token: 0x17001DD3 RID: 7635
		// (get) Token: 0x06008E9F RID: 36511 RVA: 0x0029A000 File Offset: 0x00298200
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

		// Token: 0x17001DD4 RID: 7636
		// (get) Token: 0x06008EA0 RID: 36512 RVA: 0x0029A074 File Offset: 0x00298274
		// (set) Token: 0x06008EA1 RID: 36513 RVA: 0x0029A094 File Offset: 0x00298294
		[DoNotToLua]
		public new ActivityUITask.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new ActivityUITask.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06008EA2 RID: 36514 RVA: 0x0029A0A0 File Offset: 0x002982A0
		private bool __callBase_OnStart(UIIntent intent)
		{
			return base.OnStart(intent);
		}

		// Token: 0x06008EA3 RID: 36515 RVA: 0x0029A0AC File Offset: 0x002982AC
		private void __callBase_OnStop()
		{
			base.OnStop();
		}

		// Token: 0x06008EA4 RID: 36516 RVA: 0x0029A0B4 File Offset: 0x002982B4
		private void __callBase_OnPause()
		{
			base.OnPause();
		}

		// Token: 0x06008EA5 RID: 36517 RVA: 0x0029A0BC File Offset: 0x002982BC
		private bool __callBase_OnResume(UIIntent intent)
		{
			return base.OnResume(intent);
		}

		// Token: 0x06008EA6 RID: 36518 RVA: 0x0029A0C8 File Offset: 0x002982C8
		private bool __callBase_OnNewIntent(UIIntent intent)
		{
			return base.OnNewIntent(intent);
		}

		// Token: 0x06008EA7 RID: 36519 RVA: 0x0029A0D4 File Offset: 0x002982D4
		private void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
		{
			base.EnableUIInput(isEnable, isGlobalEnable);
		}

		// Token: 0x06008EA8 RID: 36520 RVA: 0x0029A0E0 File Offset: 0x002982E0
		private bool __callBase_IsNeedLoadDynamicRes()
		{
			return base.IsNeedLoadDynamicRes();
		}

		// Token: 0x06008EA9 RID: 36521 RVA: 0x0029A0E8 File Offset: 0x002982E8
		private List<string> __callBase_CollectAllDynamicResForLoad()
		{
			return base.CollectAllDynamicResForLoad();
		}

		// Token: 0x06008EAA RID: 36522 RVA: 0x0029A0F0 File Offset: 0x002982F0
		private void __callBase_RegisterPlayerContextEvents()
		{
			base.RegisterPlayerContextEvents();
		}

		// Token: 0x06008EAB RID: 36523 RVA: 0x0029A0F8 File Offset: 0x002982F8
		private void __callBase_UnregisterPlayerContextEvents()
		{
			base.UnregisterPlayerContextEvents();
		}

		// Token: 0x06008EAC RID: 36524 RVA: 0x0029A100 File Offset: 0x00298300
		private void __callBase_PostUpdateView()
		{
			base.PostUpdateView();
		}

		// Token: 0x06008EAD RID: 36525 RVA: 0x0029A108 File Offset: 0x00298308
		private void __callBase_CollectPreloadResourceList()
		{
			base.CollectPreloadResourceList();
		}

		// Token: 0x06008EAE RID: 36526 RVA: 0x0029A110 File Offset: 0x00298310
		private void __callBase_ClearAssetList()
		{
			base.ClearAssetList();
		}

		// Token: 0x06008EAF RID: 36527 RVA: 0x0029A118 File Offset: 0x00298318
		private void __callBase_CollectAsset(string assetName)
		{
			base.CollectAsset(assetName);
		}

		// Token: 0x06008EB0 RID: 36528 RVA: 0x0029A124 File Offset: 0x00298324
		private void __callBase_CollectSpriteAsset(string assetName)
		{
			base.CollectSpriteAsset(assetName);
		}

		// Token: 0x06008EB1 RID: 36529 RVA: 0x0029A130 File Offset: 0x00298330
		private void __callBase_CollectFxAsset(string assetName)
		{
			base.CollectFxAsset(assetName);
		}

		// Token: 0x06008EB2 RID: 36530 RVA: 0x0029A13C File Offset: 0x0029833C
		private void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
		{
			base.StartLoadCustomAssets(onLoadCompleted);
		}

		// Token: 0x06008EB3 RID: 36531 RVA: 0x0029A148 File Offset: 0x00298348
		private bool __callBase_IsLoadingCustomAssets()
		{
			return base.IsLoadingCustomAssets();
		}

		// Token: 0x06008EB4 RID: 36532 RVA: 0x0029A150 File Offset: 0x00298350
		private bool __callBase_IsPipeLineRunning()
		{
			return base.IsPipeLineRunning();
		}

		// Token: 0x06008EB5 RID: 36533 RVA: 0x0029A158 File Offset: 0x00298358
		private bool __callBase_IsOpeningUI()
		{
			return base.IsOpeningUI();
		}

		// Token: 0x06008EB6 RID: 36534 RVA: 0x0029A160 File Offset: 0x00298360
		private UITaskBase __callBase_ReturnPrevUITask()
		{
			return base.ReturnPrevUITask();
		}

		// Token: 0x06008EB7 RID: 36535 RVA: 0x0029A168 File Offset: 0x00298368
		private void __callBase_ClearUnusedDynamicResourceCache()
		{
			base.ClearUnusedDynamicResourceCache();
		}

		// Token: 0x06008EB8 RID: 36536 RVA: 0x0029A170 File Offset: 0x00298370
		private void __callBase_OnMemoryWarning()
		{
			base.OnMemoryWarning();
		}

		// Token: 0x06008EBF RID: 36543 RVA: 0x0029A2F8 File Offset: 0x002984F8
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
					this.m_ctorString_hotfix = (luaObj.RawGet("ctor") as LuaFunction);
					this.m_IsNeedLoadDynamicRes_hotfix = (luaObj.RawGet("IsNeedLoadDynamicRes") as LuaFunction);
					this.m_CollectPoolItemsAssetsInt32_hotfix = (luaObj.RawGet("CollectPoolItemsAssets") as LuaFunction);
					this.m_InitAllUIControllers_hotfix = (luaObj.RawGet("InitAllUIControllers") as LuaFunction);
					this.m_ClearAllContextAndRes_hotfix = (luaObj.RawGet("ClearAllContextAndRes") as LuaFunction);
					this.m_UpdateView_hotfix = (luaObj.RawGet("UpdateView") as LuaFunction);
					this.m_ActivityUIController_OnGainRewardUInt64Int32List`1_hotfix = (luaObj.RawGet("ActivityUIController_OnGainReward") as LuaFunction);
					this.m_GetGainListGoodsList`1_hotfix = (luaObj.RawGet("GetGainListGoods") as LuaFunction);
					this.m_DisposeBoxOpenNetTaskGoodsTypeInt32Int32_hotfix = (luaObj.RawGet("DisposeBoxOpenNetTask") as LuaFunction);
					this.m_ActivityUIController_OnExchangeItemGroupUInt64Int32List`1_hotfix = (luaObj.RawGet("ActivityUIController_OnExchangeItemGroup") as LuaFunction);
					this.m_ActivityUIController_OnAddActivityString_hotfix = (luaObj.RawGet("ActivityUIController_OnAddActivity") as LuaFunction);
					this.m_ActivityUIController_OnReturn_hotfix = (luaObj.RawGet("ActivityUIController_OnReturn") as LuaFunction);
					this.m_ActivityUIController_OnGetRewardButtonClickOperationalActivityBase_hotfix = (luaObj.RawGet("ActivityUIController_OnGetRewardButtonClick") as LuaFunction);
					this.m_ActivityUIController_OnGoToButtonClickOperationalActivityBase_hotfix = (luaObj.RawGet("ActivityUIController_OnGoToButtonClick") as LuaFunction);
					this.m_StartSelectCardUITaskInt32UIIntent_hotfix = (luaObj.RawGet("StartSelectCardUITask") as LuaFunction);
					this.m_SelectCardUITask_OnLoadAllResCompleted_hotfix = (luaObj.RawGet("SelectCardUITask_OnLoadAllResCompleted") as LuaFunction);
					this.m_ActivityUIController_OnCrystalNotEnough_hotfix = (luaObj.RawGet("ActivityUIController_OnCrystalNotEnough") as LuaFunction);
					this.m_get_LayerDescArray_hotfix = (luaObj.RawGet("get_LayerDescArray") as LuaFunction);
					this.m_get_UICtrlDescArray_hotfix = (luaObj.RawGet("get_UICtrlDescArray") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06008EC0 RID: 36544 RVA: 0x0029A588 File Offset: 0x00298788
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ActivityUITask));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040064E2 RID: 25826
		private UITaskBase.LayerDesc[] m_layerDescArray = new UITaskBase.LayerDesc[]
		{
			new UITaskBase.LayerDesc
			{
				m_layerName = "ActivityUILayer",
				m_layerResPath = "Assets/GameProject/RuntimeAssets/UI/Activity_ABS/Prefab/ActivityUIPrefab.prefab",
				m_isUILayer = true
			}
		};

		// Token: 0x040064E3 RID: 25827
		private UITaskBase.UIControllerDesc[] m_uiCtrlDescArray = new UITaskBase.UIControllerDesc[]
		{
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "ActivityUILayer",
				m_attachPath = "./",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.ActivityUIController"),
				m_ctrlName = "ActivityUIController"
			}
		};

		// Token: 0x040064E4 RID: 25828
		private IConfigDataLoader m_configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;

		// Token: 0x040064E5 RID: 25829
		private List<Goods> m_gainGoodList = new List<Goods>();

		// Token: 0x040064E6 RID: 25830
		private ActivityUIController m_activityUIController;

		// Token: 0x040064E7 RID: 25831
		public const string ParamsKey_ActivityId = "ActivityId";

		// Token: 0x040064E8 RID: 25832
		[DoNotToLua]
		private ActivityUITask.LuaExportHelper luaExportHelper;

		// Token: 0x040064E9 RID: 25833
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040064EA RID: 25834
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040064EB RID: 25835
		private LuaFunction m_ctorString_hotfix;

		// Token: 0x040064EC RID: 25836
		private LuaFunction m_IsNeedLoadDynamicRes_hotfix;

		// Token: 0x040064ED RID: 25837
		private LuaFunction m_CollectPoolItemsAssetsInt32_hotfix;

		// Token: 0x040064EE RID: 25838
		private LuaFunction m_InitAllUIControllers_hotfix;

		// Token: 0x040064EF RID: 25839
		private LuaFunction m_ClearAllContextAndRes_hotfix;

		// Token: 0x040064F0 RID: 25840
		private LuaFunction m_UpdateView_hotfix;

		// Token: 0x040064F1 RID: 25841
		private LuaFunction m_ActivityUIController_OnGainRewardUInt64Int32List;

		// Token: 0x040064F2 RID: 25842
		private LuaFunction m_GetGainListGoodsList;

		// Token: 0x040064F3 RID: 25843
		private LuaFunction m_DisposeBoxOpenNetTaskGoodsTypeInt32Int32_hotfix;

		// Token: 0x040064F4 RID: 25844
		private LuaFunction m_ActivityUIController_OnExchangeItemGroupUInt64Int32List;

		// Token: 0x040064F5 RID: 25845
		private LuaFunction m_ActivityUIController_OnAddActivityString_hotfix;

		// Token: 0x040064F6 RID: 25846
		private LuaFunction m_ActivityUIController_OnReturn_hotfix;

		// Token: 0x040064F7 RID: 25847
		private LuaFunction m_ActivityUIController_OnGetRewardButtonClickOperationalActivityBase_hotfix;

		// Token: 0x040064F8 RID: 25848
		private LuaFunction m_ActivityUIController_OnGoToButtonClickOperationalActivityBase_hotfix;

		// Token: 0x040064F9 RID: 25849
		private LuaFunction m_StartSelectCardUITaskInt32UIIntent_hotfix;

		// Token: 0x040064FA RID: 25850
		private LuaFunction m_SelectCardUITask_OnLoadAllResCompleted_hotfix;

		// Token: 0x040064FB RID: 25851
		private LuaFunction m_ActivityUIController_OnCrystalNotEnough_hotfix;

		// Token: 0x040064FC RID: 25852
		private LuaFunction m_get_LayerDescArray_hotfix;

		// Token: 0x040064FD RID: 25853
		private LuaFunction m_get_UICtrlDescArray_hotfix;

		// Token: 0x020009A1 RID: 2465
		public new class LuaExportHelper
		{
			// Token: 0x06008EC1 RID: 36545 RVA: 0x0029A5F0 File Offset: 0x002987F0
			public LuaExportHelper(ActivityUITask owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06008EC2 RID: 36546 RVA: 0x0029A600 File Offset: 0x00298800
			public bool __callBase_OnStart(UIIntent intent)
			{
				return this.m_owner.__callBase_OnStart(intent);
			}

			// Token: 0x06008EC3 RID: 36547 RVA: 0x0029A610 File Offset: 0x00298810
			public void __callBase_OnStop()
			{
				this.m_owner.__callBase_OnStop();
			}

			// Token: 0x06008EC4 RID: 36548 RVA: 0x0029A620 File Offset: 0x00298820
			public void __callBase_OnPause()
			{
				this.m_owner.__callBase_OnPause();
			}

			// Token: 0x06008EC5 RID: 36549 RVA: 0x0029A630 File Offset: 0x00298830
			public bool __callBase_OnResume(UIIntent intent)
			{
				return this.m_owner.__callBase_OnResume(intent);
			}

			// Token: 0x06008EC6 RID: 36550 RVA: 0x0029A640 File Offset: 0x00298840
			public bool __callBase_OnNewIntent(UIIntent intent)
			{
				return this.m_owner.__callBase_OnNewIntent(intent);
			}

			// Token: 0x06008EC7 RID: 36551 RVA: 0x0029A650 File Offset: 0x00298850
			public void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
			{
				this.m_owner.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			}

			// Token: 0x06008EC8 RID: 36552 RVA: 0x0029A660 File Offset: 0x00298860
			public bool __callBase_IsNeedLoadDynamicRes()
			{
				return this.m_owner.__callBase_IsNeedLoadDynamicRes();
			}

			// Token: 0x06008EC9 RID: 36553 RVA: 0x0029A670 File Offset: 0x00298870
			public List<string> __callBase_CollectAllDynamicResForLoad()
			{
				return this.m_owner.__callBase_CollectAllDynamicResForLoad();
			}

			// Token: 0x06008ECA RID: 36554 RVA: 0x0029A680 File Offset: 0x00298880
			public void __callBase_RegisterPlayerContextEvents()
			{
				this.m_owner.__callBase_RegisterPlayerContextEvents();
			}

			// Token: 0x06008ECB RID: 36555 RVA: 0x0029A690 File Offset: 0x00298890
			public void __callBase_UnregisterPlayerContextEvents()
			{
				this.m_owner.__callBase_UnregisterPlayerContextEvents();
			}

			// Token: 0x06008ECC RID: 36556 RVA: 0x0029A6A0 File Offset: 0x002988A0
			public void __callBase_PostUpdateView()
			{
				this.m_owner.__callBase_PostUpdateView();
			}

			// Token: 0x06008ECD RID: 36557 RVA: 0x0029A6B0 File Offset: 0x002988B0
			public void __callBase_CollectPreloadResourceList()
			{
				this.m_owner.__callBase_CollectPreloadResourceList();
			}

			// Token: 0x06008ECE RID: 36558 RVA: 0x0029A6C0 File Offset: 0x002988C0
			public void __callBase_ClearAssetList()
			{
				this.m_owner.__callBase_ClearAssetList();
			}

			// Token: 0x06008ECF RID: 36559 RVA: 0x0029A6D0 File Offset: 0x002988D0
			public void __callBase_CollectAsset(string assetName)
			{
				this.m_owner.__callBase_CollectAsset(assetName);
			}

			// Token: 0x06008ED0 RID: 36560 RVA: 0x0029A6E0 File Offset: 0x002988E0
			public void __callBase_CollectSpriteAsset(string assetName)
			{
				this.m_owner.__callBase_CollectSpriteAsset(assetName);
			}

			// Token: 0x06008ED1 RID: 36561 RVA: 0x0029A6F0 File Offset: 0x002988F0
			public void __callBase_CollectFxAsset(string assetName)
			{
				this.m_owner.__callBase_CollectFxAsset(assetName);
			}

			// Token: 0x06008ED2 RID: 36562 RVA: 0x0029A700 File Offset: 0x00298900
			public void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
			{
				this.m_owner.__callBase_StartLoadCustomAssets(onLoadCompleted);
			}

			// Token: 0x06008ED3 RID: 36563 RVA: 0x0029A710 File Offset: 0x00298910
			public bool __callBase_IsLoadingCustomAssets()
			{
				return this.m_owner.__callBase_IsLoadingCustomAssets();
			}

			// Token: 0x06008ED4 RID: 36564 RVA: 0x0029A720 File Offset: 0x00298920
			public bool __callBase_IsPipeLineRunning()
			{
				return this.m_owner.__callBase_IsPipeLineRunning();
			}

			// Token: 0x06008ED5 RID: 36565 RVA: 0x0029A730 File Offset: 0x00298930
			public bool __callBase_IsOpeningUI()
			{
				return this.m_owner.__callBase_IsOpeningUI();
			}

			// Token: 0x06008ED6 RID: 36566 RVA: 0x0029A740 File Offset: 0x00298940
			public UITaskBase __callBase_ReturnPrevUITask()
			{
				return this.m_owner.__callBase_ReturnPrevUITask();
			}

			// Token: 0x06008ED7 RID: 36567 RVA: 0x0029A750 File Offset: 0x00298950
			public void __callBase_ClearUnusedDynamicResourceCache()
			{
				this.m_owner.__callBase_ClearUnusedDynamicResourceCache();
			}

			// Token: 0x06008ED8 RID: 36568 RVA: 0x0029A760 File Offset: 0x00298960
			public void __callBase_OnMemoryWarning()
			{
				this.m_owner.__callBase_OnMemoryWarning();
			}

			// Token: 0x17001DD5 RID: 7637
			// (get) Token: 0x06008ED9 RID: 36569 RVA: 0x0029A770 File Offset: 0x00298970
			// (set) Token: 0x06008EDA RID: 36570 RVA: 0x0029A780 File Offset: 0x00298980
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

			// Token: 0x17001DD6 RID: 7638
			// (get) Token: 0x06008EDB RID: 36571 RVA: 0x0029A790 File Offset: 0x00298990
			// (set) Token: 0x06008EDC RID: 36572 RVA: 0x0029A7A0 File Offset: 0x002989A0
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

			// Token: 0x17001DD7 RID: 7639
			// (get) Token: 0x06008EDD RID: 36573 RVA: 0x0029A7B0 File Offset: 0x002989B0
			// (set) Token: 0x06008EDE RID: 36574 RVA: 0x0029A7C0 File Offset: 0x002989C0
			public IConfigDataLoader m_configDataLoader
			{
				get
				{
					return this.m_owner.m_configDataLoader;
				}
				set
				{
					this.m_owner.m_configDataLoader = value;
				}
			}

			// Token: 0x17001DD8 RID: 7640
			// (get) Token: 0x06008EDF RID: 36575 RVA: 0x0029A7D0 File Offset: 0x002989D0
			// (set) Token: 0x06008EE0 RID: 36576 RVA: 0x0029A7E0 File Offset: 0x002989E0
			public List<Goods> m_gainGoodList
			{
				get
				{
					return this.m_owner.m_gainGoodList;
				}
				set
				{
					this.m_owner.m_gainGoodList = value;
				}
			}

			// Token: 0x17001DD9 RID: 7641
			// (get) Token: 0x06008EE1 RID: 36577 RVA: 0x0029A7F0 File Offset: 0x002989F0
			// (set) Token: 0x06008EE2 RID: 36578 RVA: 0x0029A800 File Offset: 0x00298A00
			public ActivityUIController m_activityUIController
			{
				get
				{
					return this.m_owner.m_activityUIController;
				}
				set
				{
					this.m_owner.m_activityUIController = value;
				}
			}

			// Token: 0x17001DDA RID: 7642
			// (get) Token: 0x06008EE3 RID: 36579 RVA: 0x0029A810 File Offset: 0x00298A10
			public UITaskBase.LayerDesc[] LayerDescArray
			{
				get
				{
					return this.m_owner.LayerDescArray;
				}
			}

			// Token: 0x17001DDB RID: 7643
			// (get) Token: 0x06008EE4 RID: 36580 RVA: 0x0029A820 File Offset: 0x00298A20
			public UITaskBase.UIControllerDesc[] UICtrlDescArray
			{
				get
				{
					return this.m_owner.UICtrlDescArray;
				}
			}

			// Token: 0x06008EE5 RID: 36581 RVA: 0x0029A830 File Offset: 0x00298A30
			public bool IsNeedLoadDynamicRes()
			{
				return this.m_owner.IsNeedLoadDynamicRes();
			}

			// Token: 0x06008EE6 RID: 36582 RVA: 0x0029A840 File Offset: 0x00298A40
			public void CollectPoolItemsAssets(int operationalActivityItemGroupId)
			{
				this.m_owner.CollectPoolItemsAssets(operationalActivityItemGroupId);
			}

			// Token: 0x06008EE7 RID: 36583 RVA: 0x0029A850 File Offset: 0x00298A50
			public void InitAllUIControllers()
			{
				this.m_owner.InitAllUIControllers();
			}

			// Token: 0x06008EE8 RID: 36584 RVA: 0x0029A860 File Offset: 0x00298A60
			public void ClearAllContextAndRes()
			{
				this.m_owner.ClearAllContextAndRes();
			}

			// Token: 0x06008EE9 RID: 36585 RVA: 0x0029A870 File Offset: 0x00298A70
			public void UpdateView()
			{
				this.m_owner.UpdateView();
			}

			// Token: 0x06008EEA RID: 36586 RVA: 0x0029A880 File Offset: 0x00298A80
			public void ActivityUIController_OnGainReward(ulong activityInstanceID, int rewardIndex, List<Goods> gainGoodsList)
			{
				this.m_owner.ActivityUIController_OnGainReward(activityInstanceID, rewardIndex, gainGoodsList);
			}

			// Token: 0x06008EEB RID: 36587 RVA: 0x0029A890 File Offset: 0x00298A90
			public IEnumerator GetGainListGoods(List<Goods> gainGoodsList)
			{
				return this.m_owner.GetGainListGoods(gainGoodsList);
			}

			// Token: 0x06008EEC RID: 36588 RVA: 0x0029A8A0 File Offset: 0x00298AA0
			public IEnumerator DisposeBoxOpenNetTask(GoodsType type, int id, int count)
			{
				return this.m_owner.DisposeBoxOpenNetTask(type, id, count);
			}

			// Token: 0x06008EED RID: 36589 RVA: 0x0029A8B0 File Offset: 0x00298AB0
			public void ActivityUIController_OnExchangeItemGroup(ulong activityInstanceID, int itemGroupIndex, List<Goods> gainGoodsList)
			{
				this.m_owner.ActivityUIController_OnExchangeItemGroup(activityInstanceID, itemGroupIndex, gainGoodsList);
			}

			// Token: 0x06008EEE RID: 36590 RVA: 0x0029A8C0 File Offset: 0x00298AC0
			public void ActivityUIController_OnAddActivity(string gmCmd)
			{
				this.m_owner.ActivityUIController_OnAddActivity(gmCmd);
			}

			// Token: 0x06008EEF RID: 36591 RVA: 0x0029A8D0 File Offset: 0x00298AD0
			public void ActivityUIController_OnReturn()
			{
				this.m_owner.ActivityUIController_OnReturn();
			}

			// Token: 0x06008EF0 RID: 36592 RVA: 0x0029A8E0 File Offset: 0x00298AE0
			public void ActivityUIController_OnGetRewardButtonClick(OperationalActivityBase activity)
			{
				this.m_owner.ActivityUIController_OnGetRewardButtonClick(activity);
			}

			// Token: 0x06008EF1 RID: 36593 RVA: 0x0029A8F0 File Offset: 0x00298AF0
			public void ActivityUIController_OnGoToButtonClick(OperationalActivityBase activity)
			{
				this.m_owner.ActivityUIController_OnGoToButtonClick(activity);
			}

			// Token: 0x06008EF2 RID: 36594 RVA: 0x0029A900 File Offset: 0x00298B00
			public void StartSelectCardUITask(int cardPoolId, UIIntent fromIntent)
			{
				this.m_owner.StartSelectCardUITask(cardPoolId, fromIntent);
			}

			// Token: 0x06008EF3 RID: 36595 RVA: 0x0029A910 File Offset: 0x00298B10
			public void SelectCardUITask_OnLoadAllResCompleted()
			{
				this.m_owner.SelectCardUITask_OnLoadAllResCompleted();
			}

			// Token: 0x06008EF4 RID: 36596 RVA: 0x0029A920 File Offset: 0x00298B20
			public void ActivityUIController_OnCrystalNotEnough()
			{
				this.m_owner.ActivityUIController_OnCrystalNotEnough();
			}

			// Token: 0x040064FE RID: 25854
			private ActivityUITask m_owner;
		}
	}
}
