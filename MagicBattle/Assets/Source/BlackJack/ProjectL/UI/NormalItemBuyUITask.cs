using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Scene;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.PlayerContext;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000D4F RID: 3407
	public class NormalItemBuyUITask : UITask
	{
		// Token: 0x0600FA09 RID: 64009 RVA: 0x0041CDEC File Offset: 0x0041AFEC
		public NormalItemBuyUITask(string name) : base(name)
		{
		}

		// Token: 0x0600FA0A RID: 64010 RVA: 0x0041CEDC File Offset: 0x0041B0DC
		public static NormalItemBuyUITask StartUITask(StoreId storeId, int itemId)
		{
			UIIntentCustom uiintentCustom = new UIIntentCustom(typeof(NormalItemBuyUITask).Name, null);
			uiintentCustom.SetParam("storeId", storeId);
			uiintentCustom.SetParam("fixedStoreItemId", itemId);
			UIManager instance = UIManager.Instance;
			UIIntent intent = uiintentCustom;
			bool pushIntentToStack = true;
			bool clearIntentStack = false;
			if (NormalItemBuyUITask.<>f__mg$cache0 == null)
			{
				NormalItemBuyUITask.<>f__mg$cache0 = new Action(NormalItemBuyUITask.OnLoadAllResCompletedCallback);
			}
			return instance.StartUITask(intent, pushIntentToStack, clearIntentStack, NormalItemBuyUITask.<>f__mg$cache0) as NormalItemBuyUITask;
		}

		// Token: 0x0600FA0B RID: 64011 RVA: 0x0041CF50 File Offset: 0x0041B150
		public static void OnLoadAllResCompletedCallback()
		{
			CommonUIController.Instance.HideFadeOutLoadingFadeIn();
			UITaskBase uitaskBase = UIUtility.FindUITaskWithType(typeof(NormalItemBuyUITask));
			if (uitaskBase != null)
			{
				uitaskBase.ReturnFromRedirectPipLineOnLoadAllResCompleted();
			}
		}

		// Token: 0x0600FA0C RID: 64012 RVA: 0x0041CF84 File Offset: 0x0041B184
		protected override bool OnStart(UIIntent intent)
		{
			return base.OnStart(intent);
		}

		// Token: 0x0600FA0D RID: 64013 RVA: 0x0041CF90 File Offset: 0x0041B190
		protected override void InitLayerStateOnLoadAllResCompleted()
		{
			base.InitLayerStateOnLoadAllResCompleted();
			foreach (SceneLayerBase sceneLayerBase in this.m_layerArray)
			{
				if (sceneLayerBase.State != SceneLayerBase.LayerState.InStack)
				{
					SceneManager.Instance.PushLayer(sceneLayerBase);
				}
			}
		}

		// Token: 0x0600FA0E RID: 64014 RVA: 0x0041CFDC File Offset: 0x0041B1DC
		protected override void InitAllUIControllers()
		{
			base.InitAllUIControllers();
			this.m_configDataLoader = (GameManager.Instance.ConfigDataLoader as IConfigDataLoader);
			this.m_playerContext = (GameManager.Instance.PlayerContext as ProjectLPlayerContext);
			this.m_itemSelfChooseBuyUIController = (this.m_uiCtrlArray[0] as NormalItemSelfChooseBuyUIController);
			this.m_itemSelfChooseBuyUIController.Init(this);
			this.m_normalItemBuyUIController = (this.m_uiCtrlArray[1] as NormalItemBuyUIController);
			this.m_normalItemBuyUIController.Init(this);
			UIIntentCustom uiintentCustom = this.m_currIntent as UIIntentCustom;
			StoreId structParam = uiintentCustom.GetStructParam<StoreId>("storeId");
			int structParam2 = uiintentCustom.GetStructParam<int>("fixedStoreItemId");
			ConfigDataFixedStoreItemInfo configDataFixedStoreItemInfo = this.m_configDataLoader.GetConfigDataFixedStoreItemInfo(structParam2);
			if (configDataFixedStoreItemInfo.ItemType == GoodsType.GoodsType_Item)
			{
				ConfigDataItemInfo configDataItemInfo = this.m_configDataLoader.GetConfigDataItemInfo(configDataFixedStoreItemInfo.ItemId);
				if (configDataItemInfo.FuncType == ItemFuncType.ItemFuncType_SelfSelectedBox)
				{
					this.m_normalItemBuyUIController.gameObject.SetActive(false);
					this.m_itemSelfChooseBuyUIController.SetSelfChooseItemBuyPlane(structParam, structParam2);
				}
				else
				{
					this.m_normalItemBuyUIController.ShowItemBuyPanel(structParam, structParam2);
					this.m_itemSelfChooseBuyUIController.gameObject.SetActive(false);
				}
			}
			else
			{
				this.m_normalItemBuyUIController.ShowItemBuyPanel(structParam, structParam2);
				this.m_itemSelfChooseBuyUIController.gameObject.SetActive(false);
			}
			this.m_normalItemBuyUIController.EventOnBuySuccess += this.OnBuyItemSuccess;
			this.m_itemSelfChooseBuyUIController.EventOnSelfBoxChoose += this.OnSelfBoxChoose;
		}

		// Token: 0x0600FA0F RID: 64015 RVA: 0x0041D148 File Offset: 0x0041B348
		protected override void UpdateView()
		{
		}

		// Token: 0x0600FA10 RID: 64016 RVA: 0x0041D14C File Offset: 0x0041B34C
		public bool IsSelfChoosePlaneActive()
		{
			return this.m_itemSelfChooseBuyUIController.gameObject.activeSelf;
		}

		// Token: 0x0600FA11 RID: 64017 RVA: 0x0041D160 File Offset: 0x0041B360
		private void OnBuyItemSuccess()
		{
			if (this.EventOnBuySuccess != null)
			{
				this.EventOnBuySuccess();
			}
			this.m_normalItemBuyUIController.ClosePanel(delegate
			{
				base.Stop();
			});
		}

		// Token: 0x0600FA12 RID: 64018 RVA: 0x0041D190 File Offset: 0x0041B390
		private void OnSelfBoxChoose(StoreId storeID, int fixedStoreItemId, int selfIndex)
		{
			this.m_normalItemBuyUIController.gameObject.SetActive(true);
			this.m_normalItemBuyUIController.ShowSelfChooseITemBuyPlane(storeID, fixedStoreItemId, selfIndex);
		}

		// Token: 0x1400034C RID: 844
		// (add) Token: 0x0600FA13 RID: 64019 RVA: 0x0041D1B4 File Offset: 0x0041B3B4
		// (remove) Token: 0x0600FA14 RID: 64020 RVA: 0x0041D1EC File Offset: 0x0041B3EC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public event Action EventOnBuySuccess;

		// Token: 0x17002FAB RID: 12203
		// (get) Token: 0x0600FA15 RID: 64021 RVA: 0x0041D224 File Offset: 0x0041B424
		protected override UITaskBase.LayerDesc[] LayerDescArray
		{
			get
			{
				return this.m_layerDescArray;
			}
		}

		// Token: 0x17002FAC RID: 12204
		// (get) Token: 0x0600FA16 RID: 64022 RVA: 0x0041D22C File Offset: 0x0041B42C
		protected override UITaskBase.UIControllerDesc[] UICtrlDescArray
		{
			get
			{
				return this.m_uiCtrlDescArray;
			}
		}

		// Token: 0x040092CC RID: 37580
		private UITaskBase.LayerDesc[] m_layerDescArray = new UITaskBase.LayerDesc[]
		{
			new UITaskBase.LayerDesc
			{
				m_layerName = "NormalItemSelfChooseUILayer",
				m_layerResPath = "Assets/GameProject/RuntimeAssets/UI/Guild_ABS/Prefab/NormalItemSelfChoosePrefab.prefab",
				m_isUILayer = true
			},
			new UITaskBase.LayerDesc
			{
				m_layerName = "NormalItemBuyUILayer",
				m_layerResPath = "Assets/GameProject/RuntimeAssets/UI/Guild_ABS/Prefab/NormalItemBuyPrefab.prefab",
				m_isUILayer = true
			}
		};

		// Token: 0x040092CD RID: 37581
		private UITaskBase.UIControllerDesc[] m_uiCtrlDescArray = new UITaskBase.UIControllerDesc[]
		{
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "NormalItemSelfChooseUILayer",
				m_attachPath = "./",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.NormalItemSelfChooseBuyUIController"),
				m_ctrlName = "NormalItemSelfChooseBuyUIController"
			},
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "NormalItemBuyUILayer",
				m_attachPath = "./",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.NormalItemBuyUIController"),
				m_ctrlName = "NormalItemBuyUIController"
			}
		};

		// Token: 0x040092CE RID: 37582
		private ProjectLPlayerContext m_playerContext;

		// Token: 0x040092CF RID: 37583
		private IConfigDataLoader m_configDataLoader;

		// Token: 0x040092D0 RID: 37584
		private NormalItemBuyUIController m_normalItemBuyUIController;

		// Token: 0x040092D1 RID: 37585
		private NormalItemSelfChooseBuyUIController m_itemSelfChooseBuyUIController;

		// Token: 0x040092D2 RID: 37586
		[CompilerGenerated]
		private static Action <>f__mg$cache0;
	}
}
