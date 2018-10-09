using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.TaskNs;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000E7D RID: 3709
	[HotFix]
	public class MissionUITask : UITask
	{
		// Token: 0x060120C6 RID: 73926 RVA: 0x004A7648 File Offset: 0x004A5848
		public MissionUITask(string name) : base(name)
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

		// Token: 0x060120C7 RID: 73927 RVA: 0x004A773C File Offset: 0x004A593C
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
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			foreach (Mission mission in projectLPlayerContext.GetAllCompletedMissionList())
			{
				if (mission != null && mission.Config != null)
				{
					foreach (Goods goods in mission.Config.Reward)
					{
						base.CollectSpriteAsset(UIUtility.GetGoodsIconName(goods.GoodsType, goods.Id));
					}
				}
			}
			foreach (Mission mission2 in projectLPlayerContext.GetAllProcessingMissionList())
			{
				if (mission2 != null && mission2.Config != null)
				{
					foreach (Goods goods2 in mission2.Config.Reward)
					{
						base.CollectSpriteAsset(UIUtility.GetGoodsIconName(goods2.GoodsType, goods2.Id));
					}
				}
			}
			foreach (Mission mission3 in projectLPlayerContext.GetAllFinishedMissionList())
			{
				if (mission3 != null && mission3.Config != null)
				{
					foreach (Goods goods3 in mission3.Config.Reward)
					{
						base.CollectSpriteAsset(UIUtility.GetGoodsIconName(goods3.GoodsType, goods3.Id));
					}
				}
			}
			return base.IsNeedLoadDynamicRes();
		}

		// Token: 0x060120C8 RID: 73928 RVA: 0x004A7A0C File Offset: 0x004A5C0C
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
			if (this.m_missionUIController == null)
			{
				if (this.m_uiCtrlArray.Length > 0)
				{
					this.m_missionUIController = (this.m_uiCtrlArray[0] as MissionUIController);
				}
				if (!(this.m_missionUIController != null))
				{
					Debug.LogError("MissionUIController is null");
					return;
				}
				this.m_missionUIController.EventOnClose += this.MissionUIController_OnClose;
				this.m_missionUIController.EventOnGetRewardButtonClick += this.MissionUIController_OnGetReward;
				this.m_missionUIController.EventOnGotoLayerButtonClick += this.MissionUIController_OnShowGotoLayer;
			}
		}

		// Token: 0x060120C9 RID: 73929 RVA: 0x004A7B0C File Offset: 0x004A5D0C
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
			if (this.m_missionUIController != null)
			{
				this.m_missionUIController.EventOnClose -= this.MissionUIController_OnClose;
				this.m_missionUIController.EventOnGetRewardButtonClick -= this.MissionUIController_OnGetReward;
				this.m_missionUIController.EventOnGotoLayerButtonClick -= this.MissionUIController_OnShowGotoLayer;
				this.m_missionUIController = null;
			}
		}

		// Token: 0x060120CA RID: 73930 RVA: 0x004A7BD0 File Offset: 0x004A5DD0
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

		// Token: 0x060120CB RID: 73931 RVA: 0x004A7C54 File Offset: 0x004A5E54
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

		// Token: 0x060120CC RID: 73932 RVA: 0x004A7CBC File Offset: 0x004A5EBC
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
			this.m_missionUIController.ShowMissionListByMissionColumnType();
		}

		// Token: 0x060120CD RID: 73933 RVA: 0x004A7D28 File Offset: 0x004A5F28
		private void MissionUIController_OnClose()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_MissionUIController_OnClose_hotfix != null)
			{
				this.m_MissionUIController_OnClose_hotfix.call(new object[]
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

		// Token: 0x060120CE RID: 73934 RVA: 0x004A7DAC File Offset: 0x004A5FAC
		private void MissionUIController_OnGetReward(int missionId, Action OnSucceed)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_MissionUIController_OnGetRewardInt32Action_hotfix != null)
			{
				this.m_MissionUIController_OnGetRewardInt32Action_hotfix.call(new object[]
				{
					this,
					missionId,
					OnSucceed2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Action OnSucceed = OnSucceed2;
			MissionUITask $this = this;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			int num = projectLPlayerContext.CanGainMissionReward(missionId);
			if (num == 0)
			{
				MissionRewardGetNetTask missionRewardGetNetTask = new MissionRewardGetNetTask(missionId);
				missionRewardGetNetTask.EventOnStop += delegate(Task task)
				{
					$this.UpdateView();
					MissionRewardGetNetTask missionRewardGetNetTask2 = task as MissionRewardGetNetTask;
					if (missionRewardGetNetTask2.Result == 0)
					{
						OnSucceed();
					}
					else if (missionRewardGetNetTask2.Result == -500)
					{
						BagFullUITask.StartUITask($this.m_currIntent);
					}
					else
					{
						CommonUIController.Instance.ShowErrorMessage(missionRewardGetNetTask2.Result, 2f, null, true);
					}
				};
				missionRewardGetNetTask.Start(null);
			}
			else if (num == -500)
			{
				BagFullUITask.StartUITask(this.m_currIntent);
			}
			else
			{
				this.UpdateView();
				CommonUIController.Instance.ShowErrorMessage(num, 2f, null, true);
			}
		}

		// Token: 0x060120CF RID: 73935 RVA: 0x004A7EB8 File Offset: 0x004A60B8
		private void MissionUIController_OnShowGotoLayer(GetPathData getPathInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_MissionUIController_OnShowGotoLayerGetPathData_hotfix != null)
			{
				this.m_MissionUIController_OnShowGotoLayerGetPathData_hotfix.call(new object[]
				{
					this,
					getPathInfo2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GetPathData getPathInfo = getPathInfo2;
			MissionUITask $this = this;
			int? num = new int?(0);
			FadeStyle style = FadeStyle.Black;
			int num2 = WorldUITask.CanGotoGetPath(getPathInfo, ref style);
			if (num2 <= 0)
			{
				num = new int?(num2);
				if (num == 0)
				{
					CommonUIController.Instance.StartFadeOut(delegate
					{
						$this.Pause();
						WorldUITask.StartGetPathTargetUITask(getPathInfo, $this.m_currIntent, null);
					}, style, -1f);
				}
				else
				{
					CommonUIController.Instance.ShowErrorMessage(num.Value, 2f, null, true);
				}
				return;
			}
		}

		// Token: 0x1700371C RID: 14108
		// (get) Token: 0x060120D0 RID: 73936 RVA: 0x004A7FBC File Offset: 0x004A61BC
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

		// Token: 0x1700371D RID: 14109
		// (get) Token: 0x060120D1 RID: 73937 RVA: 0x004A8030 File Offset: 0x004A6230
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

		// Token: 0x1700371E RID: 14110
		// (get) Token: 0x060120D2 RID: 73938 RVA: 0x004A80A4 File Offset: 0x004A62A4
		// (set) Token: 0x060120D3 RID: 73939 RVA: 0x004A80C4 File Offset: 0x004A62C4
		[DoNotToLua]
		public new MissionUITask.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new MissionUITask.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x060120D4 RID: 73940 RVA: 0x004A80D0 File Offset: 0x004A62D0
		private bool __callBase_OnStart(UIIntent intent)
		{
			return base.OnStart(intent);
		}

		// Token: 0x060120D5 RID: 73941 RVA: 0x004A80DC File Offset: 0x004A62DC
		private void __callBase_OnStop()
		{
			base.OnStop();
		}

		// Token: 0x060120D6 RID: 73942 RVA: 0x004A80E4 File Offset: 0x004A62E4
		private void __callBase_OnPause()
		{
			base.OnPause();
		}

		// Token: 0x060120D7 RID: 73943 RVA: 0x004A80EC File Offset: 0x004A62EC
		private bool __callBase_OnResume(UIIntent intent)
		{
			return base.OnResume(intent);
		}

		// Token: 0x060120D8 RID: 73944 RVA: 0x004A80F8 File Offset: 0x004A62F8
		private bool __callBase_OnNewIntent(UIIntent intent)
		{
			return base.OnNewIntent(intent);
		}

		// Token: 0x060120D9 RID: 73945 RVA: 0x004A8104 File Offset: 0x004A6304
		private void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
		{
			base.EnableUIInput(isEnable, isGlobalEnable);
		}

		// Token: 0x060120DA RID: 73946 RVA: 0x004A8110 File Offset: 0x004A6310
		private bool __callBase_IsNeedLoadDynamicRes()
		{
			return base.IsNeedLoadDynamicRes();
		}

		// Token: 0x060120DB RID: 73947 RVA: 0x004A8118 File Offset: 0x004A6318
		private List<string> __callBase_CollectAllDynamicResForLoad()
		{
			return base.CollectAllDynamicResForLoad();
		}

		// Token: 0x060120DC RID: 73948 RVA: 0x004A8120 File Offset: 0x004A6320
		private void __callBase_RegisterPlayerContextEvents()
		{
			base.RegisterPlayerContextEvents();
		}

		// Token: 0x060120DD RID: 73949 RVA: 0x004A8128 File Offset: 0x004A6328
		private void __callBase_UnregisterPlayerContextEvents()
		{
			base.UnregisterPlayerContextEvents();
		}

		// Token: 0x060120DE RID: 73950 RVA: 0x004A8130 File Offset: 0x004A6330
		private void __callBase_PostUpdateView()
		{
			base.PostUpdateView();
		}

		// Token: 0x060120DF RID: 73951 RVA: 0x004A8138 File Offset: 0x004A6338
		private void __callBase_CollectPreloadResourceList()
		{
			base.CollectPreloadResourceList();
		}

		// Token: 0x060120E0 RID: 73952 RVA: 0x004A8140 File Offset: 0x004A6340
		private void __callBase_ClearAssetList()
		{
			base.ClearAssetList();
		}

		// Token: 0x060120E1 RID: 73953 RVA: 0x004A8148 File Offset: 0x004A6348
		private void __callBase_CollectAsset(string assetName)
		{
			base.CollectAsset(assetName);
		}

		// Token: 0x060120E2 RID: 73954 RVA: 0x004A8154 File Offset: 0x004A6354
		private void __callBase_CollectSpriteAsset(string assetName)
		{
			base.CollectSpriteAsset(assetName);
		}

		// Token: 0x060120E3 RID: 73955 RVA: 0x004A8160 File Offset: 0x004A6360
		private void __callBase_CollectFxAsset(string assetName)
		{
			base.CollectFxAsset(assetName);
		}

		// Token: 0x060120E4 RID: 73956 RVA: 0x004A816C File Offset: 0x004A636C
		private void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
		{
			base.StartLoadCustomAssets(onLoadCompleted);
		}

		// Token: 0x060120E5 RID: 73957 RVA: 0x004A8178 File Offset: 0x004A6378
		private bool __callBase_IsLoadingCustomAssets()
		{
			return base.IsLoadingCustomAssets();
		}

		// Token: 0x060120E6 RID: 73958 RVA: 0x004A8180 File Offset: 0x004A6380
		private bool __callBase_IsPipeLineRunning()
		{
			return base.IsPipeLineRunning();
		}

		// Token: 0x060120E7 RID: 73959 RVA: 0x004A8188 File Offset: 0x004A6388
		private bool __callBase_IsOpeningUI()
		{
			return base.IsOpeningUI();
		}

		// Token: 0x060120E8 RID: 73960 RVA: 0x004A8190 File Offset: 0x004A6390
		private UITaskBase __callBase_ReturnPrevUITask()
		{
			return base.ReturnPrevUITask();
		}

		// Token: 0x060120E9 RID: 73961 RVA: 0x004A8198 File Offset: 0x004A6398
		private void __callBase_ClearUnusedDynamicResourceCache()
		{
			base.ClearUnusedDynamicResourceCache();
		}

		// Token: 0x060120EA RID: 73962 RVA: 0x004A81A0 File Offset: 0x004A63A0
		private void __callBase_OnMemoryWarning()
		{
			base.OnMemoryWarning();
		}

		// Token: 0x060120EC RID: 73964 RVA: 0x004A81C4 File Offset: 0x004A63C4
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
					this.m_IsNeedLoadDynamicRes_hotfix = (luaObj.RawGet("IsNeedLoadDynamicRes") as LuaFunction);
					this.m_InitAllUIControllers_hotfix = (luaObj.RawGet("InitAllUIControllers") as LuaFunction);
					this.m_ClearAllContextAndRes_hotfix = (luaObj.RawGet("ClearAllContextAndRes") as LuaFunction);
					this.m_OnStartUIIntent_hotfix = (luaObj.RawGet("OnStart") as LuaFunction);
					this.m_OnStop_hotfix = (luaObj.RawGet("OnStop") as LuaFunction);
					this.m_UpdateView_hotfix = (luaObj.RawGet("UpdateView") as LuaFunction);
					this.m_MissionUIController_OnClose_hotfix = (luaObj.RawGet("MissionUIController_OnClose") as LuaFunction);
					this.m_MissionUIController_OnGetRewardInt32Action_hotfix = (luaObj.RawGet("MissionUIController_OnGetReward") as LuaFunction);
					this.m_MissionUIController_OnShowGotoLayerGetPathData_hotfix = (luaObj.RawGet("MissionUIController_OnShowGotoLayer") as LuaFunction);
					this.m_get_LayerDescArray_hotfix = (luaObj.RawGet("get_LayerDescArray") as LuaFunction);
					this.m_get_UICtrlDescArray_hotfix = (luaObj.RawGet("get_UICtrlDescArray") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x060120ED RID: 73965 RVA: 0x004A83A4 File Offset: 0x004A65A4
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(MissionUITask));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400A362 RID: 41826
		private UITaskBase.LayerDesc[] m_layerDescArray = new UITaskBase.LayerDesc[]
		{
			new UITaskBase.LayerDesc
			{
				m_layerName = "MissionUILayer",
				m_layerResPath = "Assets/GameProject/RuntimeAssets/UI/Mission_ABS/Prefab/MissionUIPrefab.prefab",
				m_isUILayer = true
			}
		};

		// Token: 0x0400A363 RID: 41827
		private UITaskBase.UIControllerDesc[] m_uiCtrlDescArray = new UITaskBase.UIControllerDesc[]
		{
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "MissionUILayer",
				m_attachPath = "./",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.MissionUIController"),
				m_ctrlName = "MissonUIController"
			}
		};

		// Token: 0x0400A364 RID: 41828
		private MissionUIController m_missionUIController;

		// Token: 0x0400A365 RID: 41829
		[DoNotToLua]
		private MissionUITask.LuaExportHelper luaExportHelper;

		// Token: 0x0400A366 RID: 41830
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400A367 RID: 41831
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400A368 RID: 41832
		private LuaFunction m_ctorString_hotfix;

		// Token: 0x0400A369 RID: 41833
		private LuaFunction m_IsNeedLoadDynamicRes_hotfix;

		// Token: 0x0400A36A RID: 41834
		private LuaFunction m_InitAllUIControllers_hotfix;

		// Token: 0x0400A36B RID: 41835
		private LuaFunction m_ClearAllContextAndRes_hotfix;

		// Token: 0x0400A36C RID: 41836
		private LuaFunction m_OnStartUIIntent_hotfix;

		// Token: 0x0400A36D RID: 41837
		private LuaFunction m_OnStop_hotfix;

		// Token: 0x0400A36E RID: 41838
		private LuaFunction m_UpdateView_hotfix;

		// Token: 0x0400A36F RID: 41839
		private LuaFunction m_MissionUIController_OnClose_hotfix;

		// Token: 0x0400A370 RID: 41840
		private LuaFunction m_MissionUIController_OnGetRewardInt32Action_hotfix;

		// Token: 0x0400A371 RID: 41841
		private LuaFunction m_MissionUIController_OnShowGotoLayerGetPathData_hotfix;

		// Token: 0x0400A372 RID: 41842
		private LuaFunction m_get_LayerDescArray_hotfix;

		// Token: 0x0400A373 RID: 41843
		private LuaFunction m_get_UICtrlDescArray_hotfix;

		// Token: 0x02000E7E RID: 3710
		public new class LuaExportHelper
		{
			// Token: 0x060120EE RID: 73966 RVA: 0x004A840C File Offset: 0x004A660C
			public LuaExportHelper(MissionUITask owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x060120EF RID: 73967 RVA: 0x004A841C File Offset: 0x004A661C
			public bool __callBase_OnStart(UIIntent intent)
			{
				return this.m_owner.__callBase_OnStart(intent);
			}

			// Token: 0x060120F0 RID: 73968 RVA: 0x004A842C File Offset: 0x004A662C
			public void __callBase_OnStop()
			{
				this.m_owner.__callBase_OnStop();
			}

			// Token: 0x060120F1 RID: 73969 RVA: 0x004A843C File Offset: 0x004A663C
			public void __callBase_OnPause()
			{
				this.m_owner.__callBase_OnPause();
			}

			// Token: 0x060120F2 RID: 73970 RVA: 0x004A844C File Offset: 0x004A664C
			public bool __callBase_OnResume(UIIntent intent)
			{
				return this.m_owner.__callBase_OnResume(intent);
			}

			// Token: 0x060120F3 RID: 73971 RVA: 0x004A845C File Offset: 0x004A665C
			public bool __callBase_OnNewIntent(UIIntent intent)
			{
				return this.m_owner.__callBase_OnNewIntent(intent);
			}

			// Token: 0x060120F4 RID: 73972 RVA: 0x004A846C File Offset: 0x004A666C
			public void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
			{
				this.m_owner.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			}

			// Token: 0x060120F5 RID: 73973 RVA: 0x004A847C File Offset: 0x004A667C
			public bool __callBase_IsNeedLoadDynamicRes()
			{
				return this.m_owner.__callBase_IsNeedLoadDynamicRes();
			}

			// Token: 0x060120F6 RID: 73974 RVA: 0x004A848C File Offset: 0x004A668C
			public List<string> __callBase_CollectAllDynamicResForLoad()
			{
				return this.m_owner.__callBase_CollectAllDynamicResForLoad();
			}

			// Token: 0x060120F7 RID: 73975 RVA: 0x004A849C File Offset: 0x004A669C
			public void __callBase_RegisterPlayerContextEvents()
			{
				this.m_owner.__callBase_RegisterPlayerContextEvents();
			}

			// Token: 0x060120F8 RID: 73976 RVA: 0x004A84AC File Offset: 0x004A66AC
			public void __callBase_UnregisterPlayerContextEvents()
			{
				this.m_owner.__callBase_UnregisterPlayerContextEvents();
			}

			// Token: 0x060120F9 RID: 73977 RVA: 0x004A84BC File Offset: 0x004A66BC
			public void __callBase_PostUpdateView()
			{
				this.m_owner.__callBase_PostUpdateView();
			}

			// Token: 0x060120FA RID: 73978 RVA: 0x004A84CC File Offset: 0x004A66CC
			public void __callBase_CollectPreloadResourceList()
			{
				this.m_owner.__callBase_CollectPreloadResourceList();
			}

			// Token: 0x060120FB RID: 73979 RVA: 0x004A84DC File Offset: 0x004A66DC
			public void __callBase_ClearAssetList()
			{
				this.m_owner.__callBase_ClearAssetList();
			}

			// Token: 0x060120FC RID: 73980 RVA: 0x004A84EC File Offset: 0x004A66EC
			public void __callBase_CollectAsset(string assetName)
			{
				this.m_owner.__callBase_CollectAsset(assetName);
			}

			// Token: 0x060120FD RID: 73981 RVA: 0x004A84FC File Offset: 0x004A66FC
			public void __callBase_CollectSpriteAsset(string assetName)
			{
				this.m_owner.__callBase_CollectSpriteAsset(assetName);
			}

			// Token: 0x060120FE RID: 73982 RVA: 0x004A850C File Offset: 0x004A670C
			public void __callBase_CollectFxAsset(string assetName)
			{
				this.m_owner.__callBase_CollectFxAsset(assetName);
			}

			// Token: 0x060120FF RID: 73983 RVA: 0x004A851C File Offset: 0x004A671C
			public void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
			{
				this.m_owner.__callBase_StartLoadCustomAssets(onLoadCompleted);
			}

			// Token: 0x06012100 RID: 73984 RVA: 0x004A852C File Offset: 0x004A672C
			public bool __callBase_IsLoadingCustomAssets()
			{
				return this.m_owner.__callBase_IsLoadingCustomAssets();
			}

			// Token: 0x06012101 RID: 73985 RVA: 0x004A853C File Offset: 0x004A673C
			public bool __callBase_IsPipeLineRunning()
			{
				return this.m_owner.__callBase_IsPipeLineRunning();
			}

			// Token: 0x06012102 RID: 73986 RVA: 0x004A854C File Offset: 0x004A674C
			public bool __callBase_IsOpeningUI()
			{
				return this.m_owner.__callBase_IsOpeningUI();
			}

			// Token: 0x06012103 RID: 73987 RVA: 0x004A855C File Offset: 0x004A675C
			public UITaskBase __callBase_ReturnPrevUITask()
			{
				return this.m_owner.__callBase_ReturnPrevUITask();
			}

			// Token: 0x06012104 RID: 73988 RVA: 0x004A856C File Offset: 0x004A676C
			public void __callBase_ClearUnusedDynamicResourceCache()
			{
				this.m_owner.__callBase_ClearUnusedDynamicResourceCache();
			}

			// Token: 0x06012105 RID: 73989 RVA: 0x004A857C File Offset: 0x004A677C
			public void __callBase_OnMemoryWarning()
			{
				this.m_owner.__callBase_OnMemoryWarning();
			}

			// Token: 0x1700371F RID: 14111
			// (get) Token: 0x06012106 RID: 73990 RVA: 0x004A858C File Offset: 0x004A678C
			// (set) Token: 0x06012107 RID: 73991 RVA: 0x004A859C File Offset: 0x004A679C
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

			// Token: 0x17003720 RID: 14112
			// (get) Token: 0x06012108 RID: 73992 RVA: 0x004A85AC File Offset: 0x004A67AC
			// (set) Token: 0x06012109 RID: 73993 RVA: 0x004A85BC File Offset: 0x004A67BC
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

			// Token: 0x17003721 RID: 14113
			// (get) Token: 0x0601210A RID: 73994 RVA: 0x004A85CC File Offset: 0x004A67CC
			// (set) Token: 0x0601210B RID: 73995 RVA: 0x004A85DC File Offset: 0x004A67DC
			public MissionUIController m_missionUIController
			{
				get
				{
					return this.m_owner.m_missionUIController;
				}
				set
				{
					this.m_owner.m_missionUIController = value;
				}
			}

			// Token: 0x17003722 RID: 14114
			// (get) Token: 0x0601210C RID: 73996 RVA: 0x004A85EC File Offset: 0x004A67EC
			public UITaskBase.LayerDesc[] LayerDescArray
			{
				get
				{
					return this.m_owner.LayerDescArray;
				}
			}

			// Token: 0x17003723 RID: 14115
			// (get) Token: 0x0601210D RID: 73997 RVA: 0x004A85FC File Offset: 0x004A67FC
			public UITaskBase.UIControllerDesc[] UICtrlDescArray
			{
				get
				{
					return this.m_owner.UICtrlDescArray;
				}
			}

			// Token: 0x0601210E RID: 73998 RVA: 0x004A860C File Offset: 0x004A680C
			public bool IsNeedLoadDynamicRes()
			{
				return this.m_owner.IsNeedLoadDynamicRes();
			}

			// Token: 0x0601210F RID: 73999 RVA: 0x004A861C File Offset: 0x004A681C
			public void InitAllUIControllers()
			{
				this.m_owner.InitAllUIControllers();
			}

			// Token: 0x06012110 RID: 74000 RVA: 0x004A862C File Offset: 0x004A682C
			public void ClearAllContextAndRes()
			{
				this.m_owner.ClearAllContextAndRes();
			}

			// Token: 0x06012111 RID: 74001 RVA: 0x004A863C File Offset: 0x004A683C
			public bool OnStart(UIIntent intent)
			{
				return this.m_owner.OnStart(intent);
			}

			// Token: 0x06012112 RID: 74002 RVA: 0x004A864C File Offset: 0x004A684C
			public void OnStop()
			{
				this.m_owner.OnStop();
			}

			// Token: 0x06012113 RID: 74003 RVA: 0x004A865C File Offset: 0x004A685C
			public void UpdateView()
			{
				this.m_owner.UpdateView();
			}

			// Token: 0x06012114 RID: 74004 RVA: 0x004A866C File Offset: 0x004A686C
			public void MissionUIController_OnClose()
			{
				this.m_owner.MissionUIController_OnClose();
			}

			// Token: 0x06012115 RID: 74005 RVA: 0x004A867C File Offset: 0x004A687C
			public void MissionUIController_OnGetReward(int missionId, Action OnSucceed)
			{
				this.m_owner.MissionUIController_OnGetReward(missionId, OnSucceed);
			}

			// Token: 0x06012116 RID: 74006 RVA: 0x004A868C File Offset: 0x004A688C
			public void MissionUIController_OnShowGotoLayer(GetPathData getPathInfo)
			{
				this.m_owner.MissionUIController_OnShowGotoLayer(getPathInfo);
			}

			// Token: 0x0400A374 RID: 41844
			private MissionUITask m_owner;
		}
	}
}
