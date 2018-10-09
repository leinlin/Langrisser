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
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000A52 RID: 2642
	[HotFix]
	public class BagListUITask : UITask
	{
		// Token: 0x0600A46B RID: 42091 RVA: 0x002E4404 File Offset: 0x002E2604
		public BagListUITask(string name) : base(name)
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

		// Token: 0x0600A46C RID: 42092 RVA: 0x002E4588 File Offset: 0x002E2788
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
			this.GetUIStateFromIntent(intent);
			return base.OnStart(intent);
		}

		// Token: 0x0600A46D RID: 42093 RVA: 0x002E4614 File Offset: 0x002E2814
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
			this.SaveUIStateToIntent();
			base.OnStop();
		}

		// Token: 0x0600A46E RID: 42094 RVA: 0x002E4680 File Offset: 0x002E2880
		private void SaveUIStateToIntent()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SaveUIStateToIntent_hotfix != null)
			{
				this.m_SaveUIStateToIntent_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIIntentReturnable uiintentReturnable = this.m_currIntent as UIIntentReturnable;
			if (uiintentReturnable == null)
			{
				return;
			}
			uiintentReturnable.SetParam("DisplayType", (int)this.m_displayType);
			uiintentReturnable.SetParam("ClickBagItemInstanceId", this.m_clickBagItemInstanceId);
		}

		// Token: 0x0600A46F RID: 42095 RVA: 0x002E4720 File Offset: 0x002E2920
		private void GetUIStateFromIntent(UIIntent uiIntent)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetUIStateFromIntentUIIntent_hotfix != null)
			{
				this.m_GetUIStateFromIntentUIIntent_hotfix.call(new object[]
				{
					this,
					uiIntent
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIIntentReturnable uiintentReturnable = uiIntent as UIIntentReturnable;
			if (uiintentReturnable == null)
			{
				return;
			}
			int structParam = uiintentReturnable.GetStructParam<int>("DisplayType");
			if (structParam != 0)
			{
				this.m_displayType = (BagListUIController.DisplayType)structParam;
			}
			this.m_clickBagItemInstanceId = uiintentReturnable.GetStructParam<ulong>("ClickBagItemInstanceId");
		}

		// Token: 0x0600A470 RID: 42096 RVA: 0x002E47C8 File Offset: 0x002E29C8
		protected override bool IsNeedLoadStaticRes()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsNeedLoadStaticRes_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsNeedLoadStaticRes_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_curMode == this.BagMode)
			{
				return base.IsNeedLoadStaticRes();
			}
			return (this.m_curMode == this.AlchemyMode && this.m_alchemyUIController == null) || base.IsNeedLoadStaticRes();
		}

		// Token: 0x0600A471 RID: 42097 RVA: 0x002E4880 File Offset: 0x002E2A80
		protected override List<UITaskBase.LayerDesc> CollectAllStaticResDescForLoad()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CollectAllStaticResDescForLoad_hotfix != null)
			{
				return (List<UITaskBase.LayerDesc>)this.m_CollectAllStaticResDescForLoad_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<UITaskBase.LayerDesc> list = new List<UITaskBase.LayerDesc>();
			if (this.m_curMode == this.BagMode)
			{
				return base.CollectAllStaticResDescForLoad();
			}
			if (this.m_curMode == this.AlchemyMode)
			{
				list.Add(new UITaskBase.LayerDesc
				{
					m_layerName = this.LayerDescArray[1].m_layerName,
					m_layerResPath = this.LayerDescArray[1].m_layerResPath,
					m_isUILayer = this.LayerDescArray[1].m_isUILayer,
					m_index = this.LayerDescArray[1].m_index
				});
				return list;
			}
			return base.CollectAllStaticResDescForLoad();
		}

		// Token: 0x0600A472 RID: 42098 RVA: 0x002E4988 File Offset: 0x002E2B88
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
			if (this.m_curMode == this.BagMode)
			{
				if (this.m_bagListUIController == null)
				{
					this.m_bagListUIController = (this.m_uiCtrlArray[0] as BagListUIController);
					if (!(this.m_bagListUIController != null))
					{
						Debug.LogError("BagListUIController is null");
						return;
					}
					this.m_bagListUIController.EventOnReturn += this.BagListUIController_OnReturn;
					this.m_bagListUIController.EventOnAddAllItem += this.BagListUIController_OnAddAllItem;
					this.m_bagListUIController.EventOnAddAllEquipment += this.BagListUIController_OnAddAllEquipment;
					this.m_bagListUIController.EventOnClearBag += this.BagListUIController_OnClearBag;
					this.m_bagListUIController.EventOnSpeedUp += this.BagListUIController_OnSpeedUp;
					this.m_bagListUIController.EventOnAddItem += this.BagListUIController_OnAddItem;
					this.m_bagListUIController.EventOnUse += this.BagListUIController_OnUseItem;
					this.m_bagListUIController.EventOnShowGetPath += this.Bag_OnShowGetPath;
					this.m_bagListUIController.EventOnEquipmentForge += this.BagListUIController_OnGotoEquipmentForge;
					this.m_bagListUIController.EventOnAlchemyButtonClick += this.BagListUIController_OnAlchemyButtonClick;
				}
			}
			else if (this.m_curMode == this.AlchemyMode && this.m_alchemyUIController == null)
			{
				this.m_alchemyUIController = (this.m_uiCtrlArray[1] as AlchemyUIController);
				if (!(this.m_alchemyUIController != null))
				{
					Debug.LogError("AlchemyUIController is null");
					return;
				}
				this.m_alchemyUIController.EventOnReturn += this.AlchemyUIController_OnReturn;
				this.m_alchemyUIController.EventOnShowHelp += this.AlchemyUIController_OnShowHelp;
				this.m_alchemyUIController.EventOnAlchemyButtonClick += this.AlchemyUIController_OnAlchemyButtonClick;
			}
		}

		// Token: 0x0600A473 RID: 42099 RVA: 0x002E4BD4 File Offset: 0x002E2DD4
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
			if (this.m_bagListUIController != null)
			{
				this.m_bagListUIController.EventOnReturn -= this.BagListUIController_OnReturn;
				this.m_bagListUIController.EventOnAddAllItem -= this.BagListUIController_OnAddAllItem;
				this.m_bagListUIController.EventOnAddAllEquipment -= this.BagListUIController_OnAddAllEquipment;
				this.m_bagListUIController.EventOnSpeedUp -= this.BagListUIController_OnSpeedUp;
				this.m_bagListUIController.EventOnClearBag -= this.BagListUIController_OnClearBag;
				this.m_bagListUIController.EventOnAddItem -= this.BagListUIController_OnAddItem;
				this.m_bagListUIController.EventOnUse -= this.BagListUIController_OnUseItem;
				this.m_bagListUIController.EventOnShowGetPath -= this.Bag_OnShowGetPath;
				this.m_bagListUIController.EventOnEquipmentForge -= this.BagListUIController_OnGotoEquipmentForge;
				this.m_bagListUIController.EventOnAlchemyButtonClick -= this.BagListUIController_OnAlchemyButtonClick;
				this.m_bagListUIController = null;
			}
			if (this.m_alchemyUIController != null)
			{
				this.m_alchemyUIController.EventOnReturn -= this.AlchemyUIController_OnReturn;
				this.m_alchemyUIController.EventOnShowHelp -= this.AlchemyUIController_OnShowHelp;
				this.m_alchemyUIController.EventOnAlchemyButtonClick -= this.AlchemyUIController_OnAlchemyButtonClick;
				this.m_alchemyUIController = null;
			}
		}

		// Token: 0x0600A474 RID: 42100 RVA: 0x002E4D98 File Offset: 0x002E2F98
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
				this.m_bagListUIController.Open();
			}
			if (this.m_isNeedShowFadeIn)
			{
				CommonUIController.Instance.HideFadeOutLoadingFadeIn();
				this.m_isNeedShowFadeIn = false;
			}
			this.PushAndPopLayerByState();
			if (this.m_curMode == this.BagMode)
			{
				this.m_bagListUIController.UpdateViewInBagList(this.m_displayType, this.m_clickBagItemInstanceId);
			}
			else if (this.m_curMode == this.AlchemyMode)
			{
				this.m_alchemyUIController.UpdateView();
			}
		}

		// Token: 0x0600A475 RID: 42101 RVA: 0x002E4E84 File Offset: 0x002E3084
		private void PushAndPopLayerByState()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PushAndPopLayerByState_hotfix != null)
			{
				this.m_PushAndPopLayerByState_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_curMode == this.BagMode)
			{
				SceneLayerBase sceneLayerBase = this.m_layerArray[0];
				if (sceneLayerBase.State != SceneLayerBase.LayerState.InStack)
				{
					SceneManager.Instance.PushLayer(sceneLayerBase);
				}
				this.m_curLayerDescIndex = 0;
			}
			else if (this.m_curMode == this.AlchemyMode)
			{
				SceneLayerBase sceneLayerBase2 = this.m_layerArray[1];
				if (sceneLayerBase2.State != SceneLayerBase.LayerState.InStack)
				{
					SceneManager.Instance.PushLayer(sceneLayerBase2);
				}
				this.m_curLayerDescIndex = 1;
			}
			for (int i = 0; i < this.m_layerArray.Length; i++)
			{
				if (i != this.m_curLayerDescIndex)
				{
					SceneLayerBase sceneLayerBase3 = this.m_layerArray[i];
					if (sceneLayerBase3 != null && sceneLayerBase3.State == SceneLayerBase.LayerState.InStack)
					{
						SceneManager.Instance.PopLayer(sceneLayerBase3);
					}
				}
			}
		}

		// Token: 0x0600A476 RID: 42102 RVA: 0x002E4FBC File Offset: 0x002E31BC
		private void BagListUIController_OnReturn()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BagListUIController_OnReturn_hotfix != null)
			{
				this.m_BagListUIController_OnReturn_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIController.Instance.StartShowFadeOutLoadingFadeIn(delegate
			{
				CommonUIController.Instance.HideFadeOutLoadingFadeIn();
				this.m_bagListUIController.ResetBagUIView();
				this.m_displayType = BagListUIController.DisplayType.Item;
				this.m_clickBagItemInstanceId = 0UL;
				UIIntentReturnable uiintentReturnable = this.m_currIntent as UIIntentReturnable;
				if (uiintentReturnable != null)
				{
					uiintentReturnable.SetParam("DisplayType", null);
					uiintentReturnable.SetParam("ClickBagItemInstanceId", null);
				}
				base.Pause();
				base.ReturnPrevUITask();
			}, FadeStyle.Black, -1f, -1f);
		}

		// Token: 0x0600A477 RID: 42103 RVA: 0x002E5040 File Offset: 0x002E3240
		private void BagListUIController_OnAddAllItem()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BagListUIController_OnAddAllItem_hotfix != null)
			{
				this.m_BagListUIController_OnAddAllItem_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!LoginUITask.IsGMUser)
			{
				return;
			}
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			string text = "ADD_ITEM ";
			foreach (KeyValuePair<int, ConfigDataItemInfo> keyValuePair in configDataLoader.GetAllConfigDataItemInfo())
			{
				string text2 = text;
				text = string.Concat(new object[]
				{
					text2,
					6,
					",",
					keyValuePair.Value.ID,
					",10;"
				});
			}
			foreach (KeyValuePair<int, ConfigDataJobMaterialInfo> keyValuePair2 in configDataLoader.GetAllConfigDataJobMaterialInfo())
			{
				string text2 = text;
				text = string.Concat(new object[]
				{
					text2,
					5,
					",",
					keyValuePair2.Value.ID,
					",10;"
				});
			}
			foreach (KeyValuePair<int, ConfigDataEnchantStoneInfo> keyValuePair3 in configDataLoader.GetAllConfigDataEnchantStoneInfo())
			{
				string text2 = text;
				text = string.Concat(new object[]
				{
					text2,
					13,
					",",
					keyValuePair3.Value.ID,
					",10;"
				});
			}
			GmCommandNetTask gmCommandNetTask = new GmCommandNetTask(text);
			gmCommandNetTask.EventOnStop += delegate(Task task)
			{
				GmCommandNetTask gmCommandNetTask2 = task as GmCommandNetTask;
				if (gmCommandNetTask2.Result == 0)
				{
					this.UpdateView();
				}
				else
				{
					CommonUIController.Instance.ShowErrorMessage(gmCommandNetTask2.Result, 2f, null, true);
				}
			};
			gmCommandNetTask.Start(null);
		}

		// Token: 0x0600A478 RID: 42104 RVA: 0x002E527C File Offset: 0x002E347C
		private void BagListUIController_OnSpeedUp(int slot, ulong equipmentInstanceId, BagListUIController.DisplayType displayType)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BagListUIController_OnSpeedUpInt32UInt64DisplayType_hotfix != null)
			{
				this.m_BagListUIController_OnSpeedUpInt32UInt64DisplayType_hotfix.call(new object[]
				{
					this,
					slot,
					equipmentInstanceId,
					displayType
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_bagListUIController == null)
			{
				return;
			}
			if (displayType == BagListUIController.DisplayType.Equipment)
			{
				this.m_bagListUIController.StartCoroutine(TestUIController.TenLevelUpEquipment(equipmentInstanceId, null));
			}
		}

		// Token: 0x0600A479 RID: 42105 RVA: 0x002E5338 File Offset: 0x002E3538
		private void BagListUIController_OnAddAllEquipment()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BagListUIController_OnAddAllEquipment_hotfix != null)
			{
				this.m_BagListUIController_OnAddAllEquipment_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!LoginUITask.IsGMUser)
			{
				return;
			}
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			string text = "ADD_ITEM ";
			foreach (KeyValuePair<int, ConfigDataEquipmentInfo> keyValuePair in configDataLoader.GetAllConfigDataEquipmentInfo())
			{
				string text2 = text;
				text = string.Concat(new object[]
				{
					text2,
					7,
					",",
					keyValuePair.Value.ID,
					",1;"
				});
			}
			GmCommandNetTask gmCommandNetTask = new GmCommandNetTask(text);
			gmCommandNetTask.EventOnStop += delegate(Task task)
			{
				GmCommandNetTask gmCommandNetTask2 = task as GmCommandNetTask;
				if (gmCommandNetTask2.Result == 0)
				{
					this.UpdateView();
				}
				else
				{
					CommonUIController.Instance.ShowErrorMessage(gmCommandNetTask2.Result, 2f, null, true);
				}
			};
			gmCommandNetTask.Start(null);
		}

		// Token: 0x0600A47A RID: 42106 RVA: 0x002E5464 File Offset: 0x002E3664
		private void BagListUIController_OnAddItem(string str)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BagListUIController_OnAddItemString_hotfix != null)
			{
				this.m_BagListUIController_OnAddItemString_hotfix.call(new object[]
				{
					this,
					str
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!LoginUITask.IsGMUser)
			{
				return;
			}
			string cmd = "ADD_ITEM " + str;
			GmCommandNetTask gmCommandNetTask = new GmCommandNetTask(cmd);
			gmCommandNetTask.EventOnStop += delegate(Task task)
			{
				GmCommandNetTask gmCommandNetTask2 = task as GmCommandNetTask;
				if (gmCommandNetTask2.Result == 0)
				{
					this.UpdateView();
				}
				else
				{
					CommonUIController.Instance.ShowErrorMessage(gmCommandNetTask2.Result, 2f, null, true);
				}
			};
			gmCommandNetTask.Start(null);
		}

		// Token: 0x0600A47B RID: 42107 RVA: 0x002E550C File Offset: 0x002E370C
		private void BagListUIController_OnClearBag()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BagListUIController_OnClearBag_hotfix != null)
			{
				this.m_BagListUIController_OnClearBag_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!LoginUITask.IsGMUser)
			{
				return;
			}
			GmCommandNetTask gmCommandNetTask = new GmCommandNetTask("CLEAR_BAG");
			gmCommandNetTask.EventOnStop += delegate(Task task)
			{
				GmCommandNetTask gmCommandNetTask2 = task as GmCommandNetTask;
				if (gmCommandNetTask2.Result == 0)
				{
					this.UpdateView();
				}
				else
				{
					CommonUIController.Instance.ShowErrorMessage(gmCommandNetTask2.Result, 2f, null, true);
				}
			};
			gmCommandNetTask.Start(null);
		}

		// Token: 0x0600A47C RID: 42108 RVA: 0x002E559C File Offset: 0x002E379C
		private void BagListUIController_OnUseItem(GoodsType type, int id, int count, BagListUIController.DisplayType displayType)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BagListUIController_OnUseItemGoodsTypeInt32Int32DisplayType_hotfix != null)
			{
				this.m_BagListUIController_OnUseItemGoodsTypeInt32Int32DisplayType_hotfix.call(new object[]
				{
					this,
					type,
					id,
					count,
					displayType
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			BagItemBase bagItemByType = projectLPlayerContext.GetBagItemByType(type, id);
			this.m_displayType = displayType;
			this.m_clickBagItemInstanceId = bagItemByType.InstanceId;
			BagItemUseNetTask bagItemUseNetTask = new BagItemUseNetTask(type, id, count);
			bagItemUseNetTask.EventOnStop += delegate(Task task)
			{
				BagItemUseNetTask bagItemUseNetTask2 = task as BagItemUseNetTask;
				if (bagItemUseNetTask2.Result == 0)
				{
					this.UpdateView();
					this.ShowRewardGoodsUITask(bagItemUseNetTask2.ItemID, bagItemUseNetTask2.Count, bagItemUseNetTask2.Reward);
				}
				else
				{
					CommonUIController.Instance.ShowErrorMessage(bagItemUseNetTask2.Result, 2f, null, true);
				}
			};
			bagItemUseNetTask.Start(null);
		}

		// Token: 0x0600A47D RID: 42109 RVA: 0x002E568C File Offset: 0x002E388C
		private void ShowRewardGoodsUITask(int itemId, int count, List<Goods> goods)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowRewardGoodsUITaskInt32Int32List`1_hotfix != null)
			{
				this.m_ShowRewardGoodsUITaskInt32Int32List`1_hotfix.call(new object[]
				{
					this,
					itemId,
					count,
					goods
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			ConfigDataItemInfo configDataItemInfo = configDataLoader.GetConfigDataItemInfo(itemId);
			if (configDataItemInfo != null && configDataItemInfo.FuncType == ItemFuncType.ItemFuncType_Energy)
			{
				Goods item = new Goods
				{
					GoodsType = GoodsType.GoodsType_Energy,
					Count = configDataItemInfo.FuncTypeParam1 * count
				};
				if (goods == null)
				{
					goods = new List<Goods>
					{
						item
					};
				}
				else
				{
					goods.Add(item);
				}
			}
			if (goods != null && goods.Count > 0)
			{
				GetRewardGoodsUITask.StartUITask(goods);
			}
		}

		// Token: 0x0600A47E RID: 42110 RVA: 0x002E57A4 File Offset: 0x002E39A4
		private void BagListUIController_OnSellItem(ulong instanceId, int count)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BagListUIController_OnSellItemUInt64Int32_hotfix != null)
			{
				this.m_BagListUIController_OnSellItemUInt64Int32_hotfix.call(new object[]
				{
					this,
					instanceId,
					count2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int count = count2;
			BagListUITask $this = this;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			int maxCount = projectLPlayerContext.GetBagItemCountByInstanceId(instanceId);
			BagItemSellNetTask bagItemSellNetTask = new BagItemSellNetTask(instanceId, count);
			bagItemSellNetTask.EventOnStop += delegate(Task task)
			{
				BagItemSellNetTask bagItemSellNetTask2 = task as BagItemSellNetTask;
				if (bagItemSellNetTask2.Result == 0)
				{
					$this.UpdateView();
					if (maxCount == count)
					{
						$this.m_bagListUIController.CloseBagInfoPanel();
					}
				}
				else
				{
					CommonUIController.Instance.ShowErrorMessage(bagItemSellNetTask2.Result, 2f, null, true);
				}
			};
			bagItemSellNetTask.Start(null);
		}

		// Token: 0x0600A47F RID: 42111 RVA: 0x002E587C File Offset: 0x002E3A7C
		private void BagListUIController_OnGotoEquipmentForge(int slot, ulong equipmentInstanceId, BagListUIController.DisplayType displayType)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BagListUIController_OnGotoEquipmentForgeInt32UInt64DisplayType_hotfix != null)
			{
				this.m_BagListUIController_OnGotoEquipmentForgeInt32UInt64DisplayType_hotfix.call(new object[]
				{
					this,
					slot2,
					equipmentInstanceId2,
					displayType
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int slot = slot2;
			ulong equipmentInstanceId = equipmentInstanceId2;
			BagListUITask $this = this;
			this.m_displayType = displayType;
			this.m_clickBagItemInstanceId = equipmentInstanceId;
			CommonUIController.Instance.StartShowFadeOutLoadingFadeIn(delegate
			{
				UIIntentReturnable uiintentReturnable = new UIIntentReturnable($this.m_currIntent, typeof(EquipmentForgeUITask).Name, null);
				uiintentReturnable.SetParam("slot", slot);
				uiintentReturnable.SetParam("id", equipmentInstanceId);
				uiintentReturnable.SetParam("state", EquipmentForgeUIController.ForgeState.Enhance);
				UIManager.Instance.StartUITask(uiintentReturnable, true, false, new Action($this.EquipmentForgeUITask_OnLoadAllResCompleted));
			}, FadeStyle.Black, -1f, -1f);
		}

		// Token: 0x0600A480 RID: 42112 RVA: 0x002E595C File Offset: 0x002E3B5C
		private void EquipmentForgeUITask_OnLoadAllResCompleted()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_EquipmentForgeUITask_OnLoadAllResCompleted_hotfix != null)
			{
				this.m_EquipmentForgeUITask_OnLoadAllResCompleted_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIController.Instance.HideFadeOutLoadingFadeIn();
			UITaskBase uitaskBase = UIUtility.FindUITaskWithType(typeof(EquipmentForgeUITask));
			if (uitaskBase != null)
			{
				base.Pause();
				uitaskBase.ReturnFromRedirectPipLineOnLoadAllResCompleted();
			}
		}

		// Token: 0x0600A481 RID: 42113 RVA: 0x002E59E8 File Offset: 0x002E3BE8
		private void BagListUIController_OnAlchemyButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BagListUIController_OnAlchemyButtonClick_hotfix != null)
			{
				this.m_BagListUIController_OnAlchemyButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (!projectLPlayerContext.IsGameFunctionOpened(GameFunctionType.GameFunctionType_DecomposeBagItems))
			{
				CommonUIController.Instance.ShowMessage(UIUtility.GetGameFunctionOpenMessage(GameFunctionType.GameFunctionType_DecomposeBagItems), 2f, null, true);
			}
			else
			{
				CommonUIController.Instance.StartShowFadeOutLoadingFadeIn(delegate
				{
					this.m_isNeedShowFadeIn = true;
					this.m_curMode = this.AlchemyMode;
					base.StartUpdatePipeLine(null, false, false, true);
				}, FadeStyle.Black, -1f, -1f);
			}
		}

		// Token: 0x0600A482 RID: 42114 RVA: 0x002E5AA4 File Offset: 0x002E3CA4
		private void Bag_OnShowGetPath(BagItemBase goods, BagListUIController.DisplayType displayType)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Bag_OnShowGetPathBagItemBaseDisplayType_hotfix != null)
			{
				this.m_Bag_OnShowGetPathBagItemBaseDisplayType_hotfix.call(new object[]
				{
					this,
					goods,
					displayType
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_displayType = displayType;
			this.m_clickBagItemInstanceId = goods.InstanceId;
			GetPathUITask.StartUITask(goods.GoodsTypeId, goods.ContentId, new Action<GetPathData, NeedGoods>(this.Bag_OnGotoGetPath), 0);
		}

		// Token: 0x0600A483 RID: 42115 RVA: 0x002E5B58 File Offset: 0x002E3D58
		private void Bag_OnGotoGetPath(GetPathData getPath, NeedGoods needGoods = null)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Bag_OnGotoGetPathGetPathDataNeedGoods_hotfix != null)
			{
				this.m_Bag_OnGotoGetPathGetPathDataNeedGoods_hotfix.call(new object[]
				{
					this,
					getPath,
					needGoods
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.Pause();
			WorldUITask.StartGetPathTargetUITask(getPath, this.m_currIntent, null);
		}

		// Token: 0x0600A484 RID: 42116 RVA: 0x002E5BEC File Offset: 0x002E3DEC
		private void AlchemyUIController_OnReturn()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AlchemyUIController_OnReturn_hotfix != null)
			{
				this.m_AlchemyUIController_OnReturn_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIController.Instance.StartShowFadeOutLoadingFadeIn(delegate
			{
				this.m_alchemyUIController.ResetAlchemyUIView();
				this.m_isNeedShowFadeIn = true;
				this.m_curMode = this.BagMode;
				base.StartUpdatePipeLine(null, false, false, true);
			}, FadeStyle.Black, -1f, -1f);
		}

		// Token: 0x0600A485 RID: 42117 RVA: 0x002E5C70 File Offset: 0x002E3E70
		private void AlchemyUIController_OnShowHelp()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AlchemyUIController_OnShowHelp_hotfix != null)
			{
				this.m_AlchemyUIController_OnShowHelp_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIController.Instance.ShowExplanation(ExplanationId.ExplanationId_Alchemy);
		}

		// Token: 0x0600A486 RID: 42118 RVA: 0x002E5CDC File Offset: 0x002E3EDC
		private void AlchemyUIController_OnAlchemyButtonClick(List<ProGoods> proGoods, Action<List<Goods>> OnSucceed)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AlchemyUIController_OnAlchemyButtonClickList`1Action`1_hotfix != null)
			{
				this.m_AlchemyUIController_OnAlchemyButtonClickList`1Action`1_hotfix.call(new object[]
				{
					this,
					proGoods,
					OnSucceed2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Action<List<Goods>> OnSucceed = OnSucceed2;
			BagListUITask $this = this;
			BagItemDecomposeNetTask bagItemDecomposeNetTask = new BagItemDecomposeNetTask(proGoods);
			bagItemDecomposeNetTask.EventOnStop += delegate(Task task)
			{
				BagItemDecomposeNetTask bagItemDecomposeNetTask2 = task as BagItemDecomposeNetTask;
				if (bagItemDecomposeNetTask2.Result == 0)
				{
					$this.StartUpdatePipeLine(null, false, false, true);
					OnSucceed(bagItemDecomposeNetTask2.Reward);
				}
				else
				{
					CommonUIController.Instance.ShowErrorMessage(bagItemDecomposeNetTask2.Result, 2f, null, true);
				}
			};
			bagItemDecomposeNetTask.Start(null);
		}

		// Token: 0x17002165 RID: 8549
		// (get) Token: 0x0600A487 RID: 42119 RVA: 0x002E5D94 File Offset: 0x002E3F94
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

		// Token: 0x17002166 RID: 8550
		// (get) Token: 0x0600A488 RID: 42120 RVA: 0x002E5E08 File Offset: 0x002E4008
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

		// Token: 0x17002167 RID: 8551
		// (get) Token: 0x0600A489 RID: 42121 RVA: 0x002E5E7C File Offset: 0x002E407C
		// (set) Token: 0x0600A48A RID: 42122 RVA: 0x002E5E9C File Offset: 0x002E409C
		[DoNotToLua]
		public new BagListUITask.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new BagListUITask.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600A48B RID: 42123 RVA: 0x002E5EA8 File Offset: 0x002E40A8
		private bool __callBase_OnStart(UIIntent intent)
		{
			return base.OnStart(intent);
		}

		// Token: 0x0600A48C RID: 42124 RVA: 0x002E5EB4 File Offset: 0x002E40B4
		private void __callBase_OnStop()
		{
			base.OnStop();
		}

		// Token: 0x0600A48D RID: 42125 RVA: 0x002E5EBC File Offset: 0x002E40BC
		private void __callBase_OnPause()
		{
			base.OnPause();
		}

		// Token: 0x0600A48E RID: 42126 RVA: 0x002E5EC4 File Offset: 0x002E40C4
		private bool __callBase_OnResume(UIIntent intent)
		{
			return base.OnResume(intent);
		}

		// Token: 0x0600A48F RID: 42127 RVA: 0x002E5ED0 File Offset: 0x002E40D0
		private bool __callBase_OnNewIntent(UIIntent intent)
		{
			return base.OnNewIntent(intent);
		}

		// Token: 0x0600A490 RID: 42128 RVA: 0x002E5EDC File Offset: 0x002E40DC
		private void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
		{
			base.EnableUIInput(isEnable, isGlobalEnable);
		}

		// Token: 0x0600A491 RID: 42129 RVA: 0x002E5EE8 File Offset: 0x002E40E8
		private bool __callBase_IsNeedLoadDynamicRes()
		{
			return base.IsNeedLoadDynamicRes();
		}

		// Token: 0x0600A492 RID: 42130 RVA: 0x002E5EF0 File Offset: 0x002E40F0
		private List<string> __callBase_CollectAllDynamicResForLoad()
		{
			return base.CollectAllDynamicResForLoad();
		}

		// Token: 0x0600A493 RID: 42131 RVA: 0x002E5EF8 File Offset: 0x002E40F8
		private void __callBase_RegisterPlayerContextEvents()
		{
			base.RegisterPlayerContextEvents();
		}

		// Token: 0x0600A494 RID: 42132 RVA: 0x002E5F00 File Offset: 0x002E4100
		private void __callBase_UnregisterPlayerContextEvents()
		{
			base.UnregisterPlayerContextEvents();
		}

		// Token: 0x0600A495 RID: 42133 RVA: 0x002E5F08 File Offset: 0x002E4108
		private void __callBase_PostUpdateView()
		{
			base.PostUpdateView();
		}

		// Token: 0x0600A496 RID: 42134 RVA: 0x002E5F10 File Offset: 0x002E4110
		private void __callBase_CollectPreloadResourceList()
		{
			base.CollectPreloadResourceList();
		}

		// Token: 0x0600A497 RID: 42135 RVA: 0x002E5F18 File Offset: 0x002E4118
		private void __callBase_ClearAssetList()
		{
			base.ClearAssetList();
		}

		// Token: 0x0600A498 RID: 42136 RVA: 0x002E5F20 File Offset: 0x002E4120
		private void __callBase_CollectAsset(string assetName)
		{
			base.CollectAsset(assetName);
		}

		// Token: 0x0600A499 RID: 42137 RVA: 0x002E5F2C File Offset: 0x002E412C
		private void __callBase_CollectSpriteAsset(string assetName)
		{
			base.CollectSpriteAsset(assetName);
		}

		// Token: 0x0600A49A RID: 42138 RVA: 0x002E5F38 File Offset: 0x002E4138
		private void __callBase_CollectFxAsset(string assetName)
		{
			base.CollectFxAsset(assetName);
		}

		// Token: 0x0600A49B RID: 42139 RVA: 0x002E5F44 File Offset: 0x002E4144
		private void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
		{
			base.StartLoadCustomAssets(onLoadCompleted);
		}

		// Token: 0x0600A49C RID: 42140 RVA: 0x002E5F50 File Offset: 0x002E4150
		private bool __callBase_IsLoadingCustomAssets()
		{
			return base.IsLoadingCustomAssets();
		}

		// Token: 0x0600A49D RID: 42141 RVA: 0x002E5F58 File Offset: 0x002E4158
		private bool __callBase_IsPipeLineRunning()
		{
			return base.IsPipeLineRunning();
		}

		// Token: 0x0600A49E RID: 42142 RVA: 0x002E5F60 File Offset: 0x002E4160
		private bool __callBase_IsOpeningUI()
		{
			return base.IsOpeningUI();
		}

		// Token: 0x0600A49F RID: 42143 RVA: 0x002E5F68 File Offset: 0x002E4168
		private UITaskBase __callBase_ReturnPrevUITask()
		{
			return base.ReturnPrevUITask();
		}

		// Token: 0x0600A4A0 RID: 42144 RVA: 0x002E5F70 File Offset: 0x002E4170
		private void __callBase_ClearUnusedDynamicResourceCache()
		{
			base.ClearUnusedDynamicResourceCache();
		}

		// Token: 0x0600A4A1 RID: 42145 RVA: 0x002E5F78 File Offset: 0x002E4178
		private void __callBase_OnMemoryWarning()
		{
			base.OnMemoryWarning();
		}

		// Token: 0x0600A4AA RID: 42154 RVA: 0x002E61A0 File Offset: 0x002E43A0
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
					this.m_SaveUIStateToIntent_hotfix = (luaObj.RawGet("SaveUIStateToIntent") as LuaFunction);
					this.m_GetUIStateFromIntentUIIntent_hotfix = (luaObj.RawGet("GetUIStateFromIntent") as LuaFunction);
					this.m_IsNeedLoadStaticRes_hotfix = (luaObj.RawGet("IsNeedLoadStaticRes") as LuaFunction);
					this.m_CollectAllStaticResDescForLoad_hotfix = (luaObj.RawGet("CollectAllStaticResDescForLoad") as LuaFunction);
					this.m_InitAllUIControllers_hotfix = (luaObj.RawGet("InitAllUIControllers") as LuaFunction);
					this.m_ClearAllContextAndRes_hotfix = (luaObj.RawGet("ClearAllContextAndRes") as LuaFunction);
					this.m_UpdateView_hotfix = (luaObj.RawGet("UpdateView") as LuaFunction);
					this.m_PushAndPopLayerByState_hotfix = (luaObj.RawGet("PushAndPopLayerByState") as LuaFunction);
					this.m_BagListUIController_OnReturn_hotfix = (luaObj.RawGet("BagListUIController_OnReturn") as LuaFunction);
					this.m_BagListUIController_OnAddAllItem_hotfix = (luaObj.RawGet("BagListUIController_OnAddAllItem") as LuaFunction);
					this.m_BagListUIController_OnSpeedUpInt32UInt64DisplayType_hotfix = (luaObj.RawGet("BagListUIController_OnSpeedUp") as LuaFunction);
					this.m_BagListUIController_OnAddAllEquipment_hotfix = (luaObj.RawGet("BagListUIController_OnAddAllEquipment") as LuaFunction);
					this.m_BagListUIController_OnAddItemString_hotfix = (luaObj.RawGet("BagListUIController_OnAddItem") as LuaFunction);
					this.m_BagListUIController_OnClearBag_hotfix = (luaObj.RawGet("BagListUIController_OnClearBag") as LuaFunction);
					this.m_BagListUIController_OnUseItemGoodsTypeInt32Int32DisplayType_hotfix = (luaObj.RawGet("BagListUIController_OnUseItem") as LuaFunction);
					this.m_ShowRewardGoodsUITaskInt32Int32List`1_hotfix = (luaObj.RawGet("ShowRewardGoodsUITask") as LuaFunction);
					this.m_BagListUIController_OnSellItemUInt64Int32_hotfix = (luaObj.RawGet("BagListUIController_OnSellItem") as LuaFunction);
					this.m_BagListUIController_OnGotoEquipmentForgeInt32UInt64DisplayType_hotfix = (luaObj.RawGet("BagListUIController_OnGotoEquipmentForge") as LuaFunction);
					this.m_EquipmentForgeUITask_OnLoadAllResCompleted_hotfix = (luaObj.RawGet("EquipmentForgeUITask_OnLoadAllResCompleted") as LuaFunction);
					this.m_BagListUIController_OnAlchemyButtonClick_hotfix = (luaObj.RawGet("BagListUIController_OnAlchemyButtonClick") as LuaFunction);
					this.m_Bag_OnShowGetPathBagItemBaseDisplayType_hotfix = (luaObj.RawGet("Bag_OnShowGetPath") as LuaFunction);
					this.m_Bag_OnGotoGetPathGetPathDataNeedGoods_hotfix = (luaObj.RawGet("Bag_OnGotoGetPath") as LuaFunction);
					this.m_AlchemyUIController_OnReturn_hotfix = (luaObj.RawGet("AlchemyUIController_OnReturn") as LuaFunction);
					this.m_AlchemyUIController_OnShowHelp_hotfix = (luaObj.RawGet("AlchemyUIController_OnShowHelp") as LuaFunction);
					this.m_AlchemyUIController_OnAlchemyButtonClickList`1Action`1_hotfix = (luaObj.RawGet("AlchemyUIController_OnAlchemyButtonClick") as LuaFunction);
					this.m_get_LayerDescArray_hotfix = (luaObj.RawGet("get_LayerDescArray") as LuaFunction);
					this.m_get_UICtrlDescArray_hotfix = (luaObj.RawGet("get_UICtrlDescArray") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600A4AB RID: 42155 RVA: 0x002E6540 File Offset: 0x002E4740
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BagListUITask));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04006DAF RID: 28079
		private UITaskBase.LayerDesc[] m_layerDescArray = new UITaskBase.LayerDesc[]
		{
			new UITaskBase.LayerDesc
			{
				m_layerName = "BagListUILayer",
				m_layerResPath = "Assets/GameProject/RuntimeAssets/UI/Bag_ABS/Prefab/BagListUIPrefab.prefab",
				m_isUILayer = true
			},
			new UITaskBase.LayerDesc
			{
				m_layerName = "AlchemyUILayer",
				m_layerResPath = "Assets/GameProject/RuntimeAssets/UI/Bag_ABS/Prefab/AlchemyUIPrefab.prefab",
				m_isUILayer = true,
				m_isLazyLoad = true
			}
		};

		// Token: 0x04006DB0 RID: 28080
		private UITaskBase.UIControllerDesc[] m_uiCtrlDescArray = new UITaskBase.UIControllerDesc[]
		{
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "BagListUILayer",
				m_attachPath = "./",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.BagListUIController"),
				m_ctrlName = "BagListUIController"
			},
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "AlchemyUILayer",
				m_attachPath = "./",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.AlchemyUIController"),
				m_ctrlName = "AlchemyUIController"
			}
		};

		// Token: 0x04006DB1 RID: 28081
		public string BagMode = "Bag";

		// Token: 0x04006DB2 RID: 28082
		public string AlchemyMode = "Alchemy";

		// Token: 0x04006DB3 RID: 28083
		private string m_curMode = "Bag";

		// Token: 0x04006DB4 RID: 28084
		private BagListUIController m_bagListUIController;

		// Token: 0x04006DB5 RID: 28085
		private AlchemyUIController m_alchemyUIController;

		// Token: 0x04006DB6 RID: 28086
		private int m_curLayerDescIndex;

		// Token: 0x04006DB7 RID: 28087
		private bool m_isNeedShowFadeIn;

		// Token: 0x04006DB8 RID: 28088
		private BagListUIController.DisplayType m_displayType = BagListUIController.DisplayType.Item;

		// Token: 0x04006DB9 RID: 28089
		private ulong m_clickBagItemInstanceId;

		// Token: 0x04006DBA RID: 28090
		[DoNotToLua]
		private BagListUITask.LuaExportHelper luaExportHelper;

		// Token: 0x04006DBB RID: 28091
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04006DBC RID: 28092
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04006DBD RID: 28093
		private LuaFunction m_ctorString_hotfix;

		// Token: 0x04006DBE RID: 28094
		private LuaFunction m_OnStartUIIntent_hotfix;

		// Token: 0x04006DBF RID: 28095
		private LuaFunction m_OnStop_hotfix;

		// Token: 0x04006DC0 RID: 28096
		private LuaFunction m_SaveUIStateToIntent_hotfix;

		// Token: 0x04006DC1 RID: 28097
		private LuaFunction m_GetUIStateFromIntentUIIntent_hotfix;

		// Token: 0x04006DC2 RID: 28098
		private LuaFunction m_IsNeedLoadStaticRes_hotfix;

		// Token: 0x04006DC3 RID: 28099
		private LuaFunction m_CollectAllStaticResDescForLoad_hotfix;

		// Token: 0x04006DC4 RID: 28100
		private LuaFunction m_InitAllUIControllers_hotfix;

		// Token: 0x04006DC5 RID: 28101
		private LuaFunction m_ClearAllContextAndRes_hotfix;

		// Token: 0x04006DC6 RID: 28102
		private LuaFunction m_UpdateView_hotfix;

		// Token: 0x04006DC7 RID: 28103
		private LuaFunction m_PushAndPopLayerByState_hotfix;

		// Token: 0x04006DC8 RID: 28104
		private LuaFunction m_BagListUIController_OnReturn_hotfix;

		// Token: 0x04006DC9 RID: 28105
		private LuaFunction m_BagListUIController_OnAddAllItem_hotfix;

		// Token: 0x04006DCA RID: 28106
		private LuaFunction m_BagListUIController_OnSpeedUpInt32UInt64DisplayType_hotfix;

		// Token: 0x04006DCB RID: 28107
		private LuaFunction m_BagListUIController_OnAddAllEquipment_hotfix;

		// Token: 0x04006DCC RID: 28108
		private LuaFunction m_BagListUIController_OnAddItemString_hotfix;

		// Token: 0x04006DCD RID: 28109
		private LuaFunction m_BagListUIController_OnClearBag_hotfix;

		// Token: 0x04006DCE RID: 28110
		private LuaFunction m_BagListUIController_OnUseItemGoodsTypeInt32Int32DisplayType_hotfix;

		// Token: 0x04006DCF RID: 28111
		private LuaFunction m_ShowRewardGoodsUITaskInt32Int32List;

		// Token: 0x04006DD0 RID: 28112
		private LuaFunction m_BagListUIController_OnSellItemUInt64Int32_hotfix;

		// Token: 0x04006DD1 RID: 28113
		private LuaFunction m_BagListUIController_OnGotoEquipmentForgeInt32UInt64DisplayType_hotfix;

		// Token: 0x04006DD2 RID: 28114
		private LuaFunction m_EquipmentForgeUITask_OnLoadAllResCompleted_hotfix;

		// Token: 0x04006DD3 RID: 28115
		private LuaFunction m_BagListUIController_OnAlchemyButtonClick_hotfix;

		// Token: 0x04006DD4 RID: 28116
		private LuaFunction m_Bag_OnShowGetPathBagItemBaseDisplayType_hotfix;

		// Token: 0x04006DD5 RID: 28117
		private LuaFunction m_Bag_OnGotoGetPathGetPathDataNeedGoods_hotfix;

		// Token: 0x04006DD6 RID: 28118
		private LuaFunction m_AlchemyUIController_OnReturn_hotfix;

		// Token: 0x04006DD7 RID: 28119
		private LuaFunction m_AlchemyUIController_OnShowHelp_hotfix;

		// Token: 0x04006DD8 RID: 28120
		private LuaFunction m_AlchemyUIController_OnAlchemyButtonClickList`1Action;

		// Token: 0x04006DD9 RID: 28121
		private LuaFunction m_get_LayerDescArray_hotfix;

		// Token: 0x04006DDA RID: 28122
		private LuaFunction m_get_UICtrlDescArray_hotfix;

		// Token: 0x02000A53 RID: 2643
		public new class LuaExportHelper
		{
			// Token: 0x0600A4AC RID: 42156 RVA: 0x002E65A8 File Offset: 0x002E47A8
			public LuaExportHelper(BagListUITask owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600A4AD RID: 42157 RVA: 0x002E65B8 File Offset: 0x002E47B8
			public bool __callBase_OnStart(UIIntent intent)
			{
				return this.m_owner.__callBase_OnStart(intent);
			}

			// Token: 0x0600A4AE RID: 42158 RVA: 0x002E65C8 File Offset: 0x002E47C8
			public void __callBase_OnStop()
			{
				this.m_owner.__callBase_OnStop();
			}

			// Token: 0x0600A4AF RID: 42159 RVA: 0x002E65D8 File Offset: 0x002E47D8
			public void __callBase_OnPause()
			{
				this.m_owner.__callBase_OnPause();
			}

			// Token: 0x0600A4B0 RID: 42160 RVA: 0x002E65E8 File Offset: 0x002E47E8
			public bool __callBase_OnResume(UIIntent intent)
			{
				return this.m_owner.__callBase_OnResume(intent);
			}

			// Token: 0x0600A4B1 RID: 42161 RVA: 0x002E65F8 File Offset: 0x002E47F8
			public bool __callBase_OnNewIntent(UIIntent intent)
			{
				return this.m_owner.__callBase_OnNewIntent(intent);
			}

			// Token: 0x0600A4B2 RID: 42162 RVA: 0x002E6608 File Offset: 0x002E4808
			public void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
			{
				this.m_owner.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			}

			// Token: 0x0600A4B3 RID: 42163 RVA: 0x002E6618 File Offset: 0x002E4818
			public bool __callBase_IsNeedLoadDynamicRes()
			{
				return this.m_owner.__callBase_IsNeedLoadDynamicRes();
			}

			// Token: 0x0600A4B4 RID: 42164 RVA: 0x002E6628 File Offset: 0x002E4828
			public List<string> __callBase_CollectAllDynamicResForLoad()
			{
				return this.m_owner.__callBase_CollectAllDynamicResForLoad();
			}

			// Token: 0x0600A4B5 RID: 42165 RVA: 0x002E6638 File Offset: 0x002E4838
			public void __callBase_RegisterPlayerContextEvents()
			{
				this.m_owner.__callBase_RegisterPlayerContextEvents();
			}

			// Token: 0x0600A4B6 RID: 42166 RVA: 0x002E6648 File Offset: 0x002E4848
			public void __callBase_UnregisterPlayerContextEvents()
			{
				this.m_owner.__callBase_UnregisterPlayerContextEvents();
			}

			// Token: 0x0600A4B7 RID: 42167 RVA: 0x002E6658 File Offset: 0x002E4858
			public void __callBase_PostUpdateView()
			{
				this.m_owner.__callBase_PostUpdateView();
			}

			// Token: 0x0600A4B8 RID: 42168 RVA: 0x002E6668 File Offset: 0x002E4868
			public void __callBase_CollectPreloadResourceList()
			{
				this.m_owner.__callBase_CollectPreloadResourceList();
			}

			// Token: 0x0600A4B9 RID: 42169 RVA: 0x002E6678 File Offset: 0x002E4878
			public void __callBase_ClearAssetList()
			{
				this.m_owner.__callBase_ClearAssetList();
			}

			// Token: 0x0600A4BA RID: 42170 RVA: 0x002E6688 File Offset: 0x002E4888
			public void __callBase_CollectAsset(string assetName)
			{
				this.m_owner.__callBase_CollectAsset(assetName);
			}

			// Token: 0x0600A4BB RID: 42171 RVA: 0x002E6698 File Offset: 0x002E4898
			public void __callBase_CollectSpriteAsset(string assetName)
			{
				this.m_owner.__callBase_CollectSpriteAsset(assetName);
			}

			// Token: 0x0600A4BC RID: 42172 RVA: 0x002E66A8 File Offset: 0x002E48A8
			public void __callBase_CollectFxAsset(string assetName)
			{
				this.m_owner.__callBase_CollectFxAsset(assetName);
			}

			// Token: 0x0600A4BD RID: 42173 RVA: 0x002E66B8 File Offset: 0x002E48B8
			public void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
			{
				this.m_owner.__callBase_StartLoadCustomAssets(onLoadCompleted);
			}

			// Token: 0x0600A4BE RID: 42174 RVA: 0x002E66C8 File Offset: 0x002E48C8
			public bool __callBase_IsLoadingCustomAssets()
			{
				return this.m_owner.__callBase_IsLoadingCustomAssets();
			}

			// Token: 0x0600A4BF RID: 42175 RVA: 0x002E66D8 File Offset: 0x002E48D8
			public bool __callBase_IsPipeLineRunning()
			{
				return this.m_owner.__callBase_IsPipeLineRunning();
			}

			// Token: 0x0600A4C0 RID: 42176 RVA: 0x002E66E8 File Offset: 0x002E48E8
			public bool __callBase_IsOpeningUI()
			{
				return this.m_owner.__callBase_IsOpeningUI();
			}

			// Token: 0x0600A4C1 RID: 42177 RVA: 0x002E66F8 File Offset: 0x002E48F8
			public UITaskBase __callBase_ReturnPrevUITask()
			{
				return this.m_owner.__callBase_ReturnPrevUITask();
			}

			// Token: 0x0600A4C2 RID: 42178 RVA: 0x002E6708 File Offset: 0x002E4908
			public void __callBase_ClearUnusedDynamicResourceCache()
			{
				this.m_owner.__callBase_ClearUnusedDynamicResourceCache();
			}

			// Token: 0x0600A4C3 RID: 42179 RVA: 0x002E6718 File Offset: 0x002E4918
			public void __callBase_OnMemoryWarning()
			{
				this.m_owner.__callBase_OnMemoryWarning();
			}

			// Token: 0x17002168 RID: 8552
			// (get) Token: 0x0600A4C4 RID: 42180 RVA: 0x002E6728 File Offset: 0x002E4928
			// (set) Token: 0x0600A4C5 RID: 42181 RVA: 0x002E6738 File Offset: 0x002E4938
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

			// Token: 0x17002169 RID: 8553
			// (get) Token: 0x0600A4C6 RID: 42182 RVA: 0x002E6748 File Offset: 0x002E4948
			// (set) Token: 0x0600A4C7 RID: 42183 RVA: 0x002E6758 File Offset: 0x002E4958
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

			// Token: 0x1700216A RID: 8554
			// (get) Token: 0x0600A4C8 RID: 42184 RVA: 0x002E6768 File Offset: 0x002E4968
			// (set) Token: 0x0600A4C9 RID: 42185 RVA: 0x002E6778 File Offset: 0x002E4978
			public string m_curMode
			{
				get
				{
					return this.m_owner.m_curMode;
				}
				set
				{
					this.m_owner.m_curMode = value;
				}
			}

			// Token: 0x1700216B RID: 8555
			// (get) Token: 0x0600A4CA RID: 42186 RVA: 0x002E6788 File Offset: 0x002E4988
			// (set) Token: 0x0600A4CB RID: 42187 RVA: 0x002E6798 File Offset: 0x002E4998
			public BagListUIController m_bagListUIController
			{
				get
				{
					return this.m_owner.m_bagListUIController;
				}
				set
				{
					this.m_owner.m_bagListUIController = value;
				}
			}

			// Token: 0x1700216C RID: 8556
			// (get) Token: 0x0600A4CC RID: 42188 RVA: 0x002E67A8 File Offset: 0x002E49A8
			// (set) Token: 0x0600A4CD RID: 42189 RVA: 0x002E67B8 File Offset: 0x002E49B8
			public AlchemyUIController m_alchemyUIController
			{
				get
				{
					return this.m_owner.m_alchemyUIController;
				}
				set
				{
					this.m_owner.m_alchemyUIController = value;
				}
			}

			// Token: 0x1700216D RID: 8557
			// (get) Token: 0x0600A4CE RID: 42190 RVA: 0x002E67C8 File Offset: 0x002E49C8
			// (set) Token: 0x0600A4CF RID: 42191 RVA: 0x002E67D8 File Offset: 0x002E49D8
			public int m_curLayerDescIndex
			{
				get
				{
					return this.m_owner.m_curLayerDescIndex;
				}
				set
				{
					this.m_owner.m_curLayerDescIndex = value;
				}
			}

			// Token: 0x1700216E RID: 8558
			// (get) Token: 0x0600A4D0 RID: 42192 RVA: 0x002E67E8 File Offset: 0x002E49E8
			// (set) Token: 0x0600A4D1 RID: 42193 RVA: 0x002E67F8 File Offset: 0x002E49F8
			public bool m_isNeedShowFadeIn
			{
				get
				{
					return this.m_owner.m_isNeedShowFadeIn;
				}
				set
				{
					this.m_owner.m_isNeedShowFadeIn = value;
				}
			}

			// Token: 0x1700216F RID: 8559
			// (get) Token: 0x0600A4D2 RID: 42194 RVA: 0x002E6808 File Offset: 0x002E4A08
			// (set) Token: 0x0600A4D3 RID: 42195 RVA: 0x002E6818 File Offset: 0x002E4A18
			public BagListUIController.DisplayType m_displayType
			{
				get
				{
					return this.m_owner.m_displayType;
				}
				set
				{
					this.m_owner.m_displayType = value;
				}
			}

			// Token: 0x17002170 RID: 8560
			// (get) Token: 0x0600A4D4 RID: 42196 RVA: 0x002E6828 File Offset: 0x002E4A28
			// (set) Token: 0x0600A4D5 RID: 42197 RVA: 0x002E6838 File Offset: 0x002E4A38
			public ulong m_clickBagItemInstanceId
			{
				get
				{
					return this.m_owner.m_clickBagItemInstanceId;
				}
				set
				{
					this.m_owner.m_clickBagItemInstanceId = value;
				}
			}

			// Token: 0x17002171 RID: 8561
			// (get) Token: 0x0600A4D6 RID: 42198 RVA: 0x002E6848 File Offset: 0x002E4A48
			public UITaskBase.LayerDesc[] LayerDescArray
			{
				get
				{
					return this.m_owner.LayerDescArray;
				}
			}

			// Token: 0x17002172 RID: 8562
			// (get) Token: 0x0600A4D7 RID: 42199 RVA: 0x002E6858 File Offset: 0x002E4A58
			public UITaskBase.UIControllerDesc[] UICtrlDescArray
			{
				get
				{
					return this.m_owner.UICtrlDescArray;
				}
			}

			// Token: 0x0600A4D8 RID: 42200 RVA: 0x002E6868 File Offset: 0x002E4A68
			public bool OnStart(UIIntent intent)
			{
				return this.m_owner.OnStart(intent);
			}

			// Token: 0x0600A4D9 RID: 42201 RVA: 0x002E6878 File Offset: 0x002E4A78
			public void OnStop()
			{
				this.m_owner.OnStop();
			}

			// Token: 0x0600A4DA RID: 42202 RVA: 0x002E6888 File Offset: 0x002E4A88
			public void SaveUIStateToIntent()
			{
				this.m_owner.SaveUIStateToIntent();
			}

			// Token: 0x0600A4DB RID: 42203 RVA: 0x002E6898 File Offset: 0x002E4A98
			public void GetUIStateFromIntent(UIIntent uiIntent)
			{
				this.m_owner.GetUIStateFromIntent(uiIntent);
			}

			// Token: 0x0600A4DC RID: 42204 RVA: 0x002E68A8 File Offset: 0x002E4AA8
			public bool IsNeedLoadStaticRes()
			{
				return this.m_owner.IsNeedLoadStaticRes();
			}

			// Token: 0x0600A4DD RID: 42205 RVA: 0x002E68B8 File Offset: 0x002E4AB8
			public List<UITaskBase.LayerDesc> CollectAllStaticResDescForLoad()
			{
				return this.m_owner.CollectAllStaticResDescForLoad();
			}

			// Token: 0x0600A4DE RID: 42206 RVA: 0x002E68C8 File Offset: 0x002E4AC8
			public void InitAllUIControllers()
			{
				this.m_owner.InitAllUIControllers();
			}

			// Token: 0x0600A4DF RID: 42207 RVA: 0x002E68D8 File Offset: 0x002E4AD8
			public void ClearAllContextAndRes()
			{
				this.m_owner.ClearAllContextAndRes();
			}

			// Token: 0x0600A4E0 RID: 42208 RVA: 0x002E68E8 File Offset: 0x002E4AE8
			public void UpdateView()
			{
				this.m_owner.UpdateView();
			}

			// Token: 0x0600A4E1 RID: 42209 RVA: 0x002E68F8 File Offset: 0x002E4AF8
			public void PushAndPopLayerByState()
			{
				this.m_owner.PushAndPopLayerByState();
			}

			// Token: 0x0600A4E2 RID: 42210 RVA: 0x002E6908 File Offset: 0x002E4B08
			public void BagListUIController_OnReturn()
			{
				this.m_owner.BagListUIController_OnReturn();
			}

			// Token: 0x0600A4E3 RID: 42211 RVA: 0x002E6918 File Offset: 0x002E4B18
			public void BagListUIController_OnAddAllItem()
			{
				this.m_owner.BagListUIController_OnAddAllItem();
			}

			// Token: 0x0600A4E4 RID: 42212 RVA: 0x002E6928 File Offset: 0x002E4B28
			public void BagListUIController_OnSpeedUp(int slot, ulong equipmentInstanceId, BagListUIController.DisplayType displayType)
			{
				this.m_owner.BagListUIController_OnSpeedUp(slot, equipmentInstanceId, displayType);
			}

			// Token: 0x0600A4E5 RID: 42213 RVA: 0x002E6938 File Offset: 0x002E4B38
			public void BagListUIController_OnAddAllEquipment()
			{
				this.m_owner.BagListUIController_OnAddAllEquipment();
			}

			// Token: 0x0600A4E6 RID: 42214 RVA: 0x002E6948 File Offset: 0x002E4B48
			public void BagListUIController_OnAddItem(string str)
			{
				this.m_owner.BagListUIController_OnAddItem(str);
			}

			// Token: 0x0600A4E7 RID: 42215 RVA: 0x002E6958 File Offset: 0x002E4B58
			public void BagListUIController_OnClearBag()
			{
				this.m_owner.BagListUIController_OnClearBag();
			}

			// Token: 0x0600A4E8 RID: 42216 RVA: 0x002E6968 File Offset: 0x002E4B68
			public void BagListUIController_OnUseItem(GoodsType type, int id, int count, BagListUIController.DisplayType displayType)
			{
				this.m_owner.BagListUIController_OnUseItem(type, id, count, displayType);
			}

			// Token: 0x0600A4E9 RID: 42217 RVA: 0x002E697C File Offset: 0x002E4B7C
			public void ShowRewardGoodsUITask(int itemId, int count, List<Goods> goods)
			{
				this.m_owner.ShowRewardGoodsUITask(itemId, count, goods);
			}

			// Token: 0x0600A4EA RID: 42218 RVA: 0x002E698C File Offset: 0x002E4B8C
			public void BagListUIController_OnSellItem(ulong instanceId, int count)
			{
				this.m_owner.BagListUIController_OnSellItem(instanceId, count);
			}

			// Token: 0x0600A4EB RID: 42219 RVA: 0x002E699C File Offset: 0x002E4B9C
			public void BagListUIController_OnGotoEquipmentForge(int slot, ulong equipmentInstanceId, BagListUIController.DisplayType displayType)
			{
				this.m_owner.BagListUIController_OnGotoEquipmentForge(slot, equipmentInstanceId, displayType);
			}

			// Token: 0x0600A4EC RID: 42220 RVA: 0x002E69AC File Offset: 0x002E4BAC
			public void EquipmentForgeUITask_OnLoadAllResCompleted()
			{
				this.m_owner.EquipmentForgeUITask_OnLoadAllResCompleted();
			}

			// Token: 0x0600A4ED RID: 42221 RVA: 0x002E69BC File Offset: 0x002E4BBC
			public void BagListUIController_OnAlchemyButtonClick()
			{
				this.m_owner.BagListUIController_OnAlchemyButtonClick();
			}

			// Token: 0x0600A4EE RID: 42222 RVA: 0x002E69CC File Offset: 0x002E4BCC
			public void Bag_OnShowGetPath(BagItemBase goods, BagListUIController.DisplayType displayType)
			{
				this.m_owner.Bag_OnShowGetPath(goods, displayType);
			}

			// Token: 0x0600A4EF RID: 42223 RVA: 0x002E69DC File Offset: 0x002E4BDC
			public void Bag_OnGotoGetPath(GetPathData getPath, NeedGoods needGoods)
			{
				this.m_owner.Bag_OnGotoGetPath(getPath, needGoods);
			}

			// Token: 0x0600A4F0 RID: 42224 RVA: 0x002E69EC File Offset: 0x002E4BEC
			public void AlchemyUIController_OnReturn()
			{
				this.m_owner.AlchemyUIController_OnReturn();
			}

			// Token: 0x0600A4F1 RID: 42225 RVA: 0x002E69FC File Offset: 0x002E4BFC
			public void AlchemyUIController_OnShowHelp()
			{
				this.m_owner.AlchemyUIController_OnShowHelp();
			}

			// Token: 0x0600A4F2 RID: 42226 RVA: 0x002E6A0C File Offset: 0x002E4C0C
			public void AlchemyUIController_OnAlchemyButtonClick(List<ProGoods> proGoods, Action<List<Goods>> OnSucceed)
			{
				this.m_owner.AlchemyUIController_OnAlchemyButtonClick(proGoods, OnSucceed);
			}

			// Token: 0x04006DDB RID: 28123
			private BagListUITask m_owner;
		}
	}
}
