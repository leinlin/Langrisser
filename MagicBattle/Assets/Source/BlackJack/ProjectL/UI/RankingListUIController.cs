using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using MarchingBytes;
using SLua;
using UnityEngine;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000EB5 RID: 3765
	[HotFix]
	public class RankingListUIController : UIControllerBase
	{
		// Token: 0x0601266F RID: 75375 RVA: 0x004B9934 File Offset: 0x004B7B34
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
			GameObject assetInContainer = base.GetAssetInContainer<GameObject>("RankingListItemUIPrefab");
			this.m_itemTemplete = UnityEngine.Object.Instantiate<GameObject>(assetInContainer);
			PrefabControllerCreater.CreateAllControllers(this.m_itemTemplete);
			this.m_itemTemplete.transform.SetParent(this.ItemRoot.transform, false);
			base.OnBindFiledsCompleted();
		}

		// Token: 0x06012670 RID: 75376 RVA: 0x004B99DC File Offset: 0x004B7BDC
		public void CreateItemListPool(int poolSize)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CreateItemListPoolInt32_hotfix != null)
			{
				this.m_CreateItemListPoolInt32_hotfix.call(new object[]
				{
					this,
					poolSize
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			PoolInfo poolInfoByName = this.RankListItemPool.GetPoolInfoByName("RankingListItemUIPrefab");
			poolInfoByName.poolSize = poolSize;
			poolInfoByName.prefab = this.m_itemTemplete;
			this.RankListItemPool.CreatePools();
			Stack<PoolObject> objectPoolByName = this.RankListItemPool.GetObjectPoolByName("RankingListItemUIPrefab");
			foreach (PoolObject poolObject in objectPoolByName)
			{
				RankingListItemUIController component = poolObject.GetComponent<RankingListItemUIController>();
				component.Init();
				component.RegisterItemNeedFillEvent(new Action<UIControllerBase>(this.OnRankItemFill));
			}
		}

		// Token: 0x06012671 RID: 75377 RVA: 0x004B9AF4 File Offset: 0x004B7CF4
		public void UpdateRankingListInfo(RankingListInfo rankList)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateRankingListInfoRankingListInfo_hotfix != null)
			{
				this.m_UpdateRankingListInfoRankingListInfo_hotfix.call(new object[]
				{
					this,
					rankList
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_cachedRankList = rankList;
			this.RankListScrollRect.totalCount = rankList.PlayerList.Count;
			this.RankListScrollRect.RefillCells(0);
			this.RankListStateCtrl.SetToUIState("Show", false, true);
			this.UpdateSelfRankInfo();
		}

		// Token: 0x06012672 RID: 75378 RVA: 0x004B9BA8 File Offset: 0x004B7DA8
		protected void UpdateSelfRankInfo()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateSelfRankInfo_hotfix != null)
			{
				this.m_UpdateSelfRankInfo_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			string heroName = string.Empty;
			if (this.m_cachedRankList.Type == RankingListType.ChampionHero)
			{
				IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
				ConfigDataHeroInfo configDataHeroInfo = configDataLoader.GetConfigDataHeroInfo(this.m_cachedRankList.ChampionHeroId);
				if (configDataHeroInfo != null)
				{
					heroName = configDataHeroInfo.Name;
				}
			}
			this.SelfRankItemUICtrl.UpdateItemInfo(this.m_cachedRankList.Type, projectLPlayerContext.GetPlayerHeadIcon(), this.m_cachedRankList.CurrRank, projectLPlayerContext.GetPlayerLevel(), projectLPlayerContext.GetPlayerName(), this.m_cachedRankList.Score, heroName);
			this.SelfRankItemUICtrl.UpdateCompareInfo(this.m_cachedRankList.LastRank, this.m_cachedRankList.CurrRank);
		}

		// Token: 0x06012673 RID: 75379 RVA: 0x004B9CC0 File Offset: 0x004B7EC0
		protected void OnRankItemFill(UIControllerBase itemCtrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnRankItemFillUIControllerBase_hotfix != null)
			{
				this.m_OnRankItemFillUIControllerBase_hotfix.call(new object[]
				{
					this,
					itemCtrl
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			RankingListItemUIController rankingListItemUIController = itemCtrl as RankingListItemUIController;
			int itemIndex = rankingListItemUIController.GetItemIndex();
			if (itemIndex >= this.m_cachedRankList.PlayerList.Count)
			{
				return;
			}
			RankingTargetPlayerInfo rankingTargetPlayerInfo = this.m_cachedRankList.PlayerList[itemIndex];
			string heroName = string.Empty;
			if (this.m_cachedRankList.Type == RankingListType.ChampionHero)
			{
				IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
				ConfigDataHeroInfo configDataHeroInfo = configDataLoader.GetConfigDataHeroInfo(rankingTargetPlayerInfo.PlayerInfo.ChampionHeroId);
				if (configDataHeroInfo != null)
				{
					heroName = configDataHeroInfo.Name;
				}
			}
			rankingListItemUIController.UpdateItemInfo(this.m_cachedRankList.Type, rankingTargetPlayerInfo.PlayerInfo.HeadIcon, itemIndex + 1, rankingTargetPlayerInfo.PlayerInfo.Level, rankingTargetPlayerInfo.PlayerInfo.Name, rankingTargetPlayerInfo.Score, heroName);
		}

		// Token: 0x170037CC RID: 14284
		// (get) Token: 0x06012674 RID: 75380 RVA: 0x004B9DF0 File Offset: 0x004B7FF0
		// (set) Token: 0x06012675 RID: 75381 RVA: 0x004B9E10 File Offset: 0x004B8010
		[DoNotToLua]
		public new RankingListUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new RankingListUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06012676 RID: 75382 RVA: 0x004B9E1C File Offset: 0x004B801C
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x06012677 RID: 75383 RVA: 0x004B9E28 File Offset: 0x004B8028
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x06012678 RID: 75384 RVA: 0x004B9E30 File Offset: 0x004B8030
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x06012679 RID: 75385 RVA: 0x004B9E38 File Offset: 0x004B8038
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0601267A RID: 75386 RVA: 0x004B9E4C File Offset: 0x004B804C
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0601267B RID: 75387 RVA: 0x004B9E54 File Offset: 0x004B8054
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0601267C RID: 75388 RVA: 0x004B9E60 File Offset: 0x004B8060
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0601267D RID: 75389 RVA: 0x004B9E6C File Offset: 0x004B806C
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0601267E RID: 75390 RVA: 0x004B9E78 File Offset: 0x004B8078
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0601267F RID: 75391 RVA: 0x004B9E84 File Offset: 0x004B8084
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x06012680 RID: 75392 RVA: 0x004B9E90 File Offset: 0x004B8090
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x06012681 RID: 75393 RVA: 0x004B9E9C File Offset: 0x004B809C
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x06012682 RID: 75394 RVA: 0x004B9EA8 File Offset: 0x004B80A8
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x06012683 RID: 75395 RVA: 0x004B9EB4 File Offset: 0x004B80B4
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x06012684 RID: 75396 RVA: 0x004B9EC0 File Offset: 0x004B80C0
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x06012685 RID: 75397 RVA: 0x004B9EC8 File Offset: 0x004B80C8
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
					this.m_CreateItemListPoolInt32_hotfix = (luaObj.RawGet("CreateItemListPool") as LuaFunction);
					this.m_UpdateRankingListInfoRankingListInfo_hotfix = (luaObj.RawGet("UpdateRankingListInfo") as LuaFunction);
					this.m_UpdateSelfRankInfo_hotfix = (luaObj.RawGet("UpdateSelfRankInfo") as LuaFunction);
					this.m_OnRankItemFillUIControllerBase_hotfix = (luaObj.RawGet("OnRankItemFill") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06012686 RID: 75398 RVA: 0x004B9FF8 File Offset: 0x004B81F8
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(RankingListUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400A5A1 RID: 42401
		protected GameObject m_itemTemplete;

		// Token: 0x0400A5A2 RID: 42402
		protected RankingListInfo m_cachedRankList;

		// Token: 0x0400A5A3 RID: 42403
		protected const string RankListItemPrefabName = "RankingListItemUIPrefab";

		// Token: 0x0400A5A4 RID: 42404
		[AutoBind("./ItemRoot", AutoBindAttribute.InitState.NotInit, false)]
		public Transform ItemRoot;

		// Token: 0x0400A5A5 RID: 42405
		[AutoBind("./RankingListScrollView", AutoBindAttribute.InitState.NotInit, false)]
		public EasyObjectPool RankListItemPool;

		// Token: 0x0400A5A6 RID: 42406
		[AutoBind("./PlayerInfoGroup", AutoBindAttribute.InitState.NotInit, false)]
		public SelfRankingListItemUIController SelfRankItemUICtrl;

		// Token: 0x0400A5A7 RID: 42407
		[AutoBind("./RankingListScrollView", AutoBindAttribute.InitState.NotInit, false)]
		public LoopVerticalScrollRect RankListScrollRect;

		// Token: 0x0400A5A8 RID: 42408
		[AutoBind("./RankingListScrollView", AutoBindAttribute.InitState.NotInit, false)]
		public CommonUIStateController RankListStateCtrl;

		// Token: 0x0400A5A9 RID: 42409
		[DoNotToLua]
		private RankingListUIController.LuaExportHelper luaExportHelper;

		// Token: 0x0400A5AA RID: 42410
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400A5AB RID: 42411
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400A5AC RID: 42412
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x0400A5AD RID: 42413
		private LuaFunction m_CreateItemListPoolInt32_hotfix;

		// Token: 0x0400A5AE RID: 42414
		private LuaFunction m_UpdateRankingListInfoRankingListInfo_hotfix;

		// Token: 0x0400A5AF RID: 42415
		private LuaFunction m_UpdateSelfRankInfo_hotfix;

		// Token: 0x0400A5B0 RID: 42416
		private LuaFunction m_OnRankItemFillUIControllerBase_hotfix;

		// Token: 0x02000EB6 RID: 3766
		public new class LuaExportHelper
		{
			// Token: 0x06012687 RID: 75399 RVA: 0x004BA060 File Offset: 0x004B8260
			public LuaExportHelper(RankingListUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06012688 RID: 75400 RVA: 0x004BA070 File Offset: 0x004B8270
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x06012689 RID: 75401 RVA: 0x004BA080 File Offset: 0x004B8280
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0601268A RID: 75402 RVA: 0x004BA090 File Offset: 0x004B8290
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0601268B RID: 75403 RVA: 0x004BA0A0 File Offset: 0x004B82A0
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0601268C RID: 75404 RVA: 0x004BA0B8 File Offset: 0x004B82B8
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0601268D RID: 75405 RVA: 0x004BA0C8 File Offset: 0x004B82C8
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0601268E RID: 75406 RVA: 0x004BA0D8 File Offset: 0x004B82D8
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0601268F RID: 75407 RVA: 0x004BA0E8 File Offset: 0x004B82E8
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x06012690 RID: 75408 RVA: 0x004BA0F8 File Offset: 0x004B82F8
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x06012691 RID: 75409 RVA: 0x004BA108 File Offset: 0x004B8308
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x06012692 RID: 75410 RVA: 0x004BA118 File Offset: 0x004B8318
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x06012693 RID: 75411 RVA: 0x004BA128 File Offset: 0x004B8328
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x06012694 RID: 75412 RVA: 0x004BA138 File Offset: 0x004B8338
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x06012695 RID: 75413 RVA: 0x004BA148 File Offset: 0x004B8348
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x06012696 RID: 75414 RVA: 0x004BA158 File Offset: 0x004B8358
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x170037CD RID: 14285
			// (get) Token: 0x06012697 RID: 75415 RVA: 0x004BA168 File Offset: 0x004B8368
			// (set) Token: 0x06012698 RID: 75416 RVA: 0x004BA178 File Offset: 0x004B8378
			public GameObject m_itemTemplete
			{
				get
				{
					return this.m_owner.m_itemTemplete;
				}
				set
				{
					this.m_owner.m_itemTemplete = value;
				}
			}

			// Token: 0x170037CE RID: 14286
			// (get) Token: 0x06012699 RID: 75417 RVA: 0x004BA188 File Offset: 0x004B8388
			// (set) Token: 0x0601269A RID: 75418 RVA: 0x004BA198 File Offset: 0x004B8398
			public RankingListInfo m_cachedRankList
			{
				get
				{
					return this.m_owner.m_cachedRankList;
				}
				set
				{
					this.m_owner.m_cachedRankList = value;
				}
			}

			// Token: 0x170037CF RID: 14287
			// (get) Token: 0x0601269B RID: 75419 RVA: 0x004BA1A8 File Offset: 0x004B83A8
			public static string RankListItemPrefabName
			{
				get
				{
					return "RankingListItemUIPrefab";
				}
			}

			// Token: 0x0601269C RID: 75420 RVA: 0x004BA1B0 File Offset: 0x004B83B0
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0601269D RID: 75421 RVA: 0x004BA1C0 File Offset: 0x004B83C0
			public void UpdateSelfRankInfo()
			{
				this.m_owner.UpdateSelfRankInfo();
			}

			// Token: 0x0601269E RID: 75422 RVA: 0x004BA1D0 File Offset: 0x004B83D0
			public void OnRankItemFill(UIControllerBase itemCtrl)
			{
				this.m_owner.OnRankItemFill(itemCtrl);
			}

			// Token: 0x0400A5B1 RID: 42417
			private RankingListUIController m_owner;
		}
	}
}
