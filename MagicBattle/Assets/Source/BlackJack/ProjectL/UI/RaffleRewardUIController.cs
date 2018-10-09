using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using MarchingBytes;
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000EA8 RID: 3752
	[HotFix]
	public class RaffleRewardUIController : UIControllerBase
	{
		// Token: 0x06012536 RID: 75062 RVA: 0x004B505C File Offset: 0x004B325C
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
			this.InitRaffleRewardItemPool();
			this.EasyPool.CreatePools();
			this.CloseButton.onClick.AddListener(new UnityAction(this.OnCloseButtonClick));
			this.BgButton.onClick.AddListener(new UnityAction(this.OnCloseButtonClick));
			base.OnBindFiledsCompleted();
		}

		// Token: 0x06012537 RID: 75063 RVA: 0x004B510C File Offset: 0x004B330C
		protected void InitRaffleRewardItemPool()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitRaffleRewardItemPool_hotfix != null)
			{
				this.m_InitRaffleRewardItemPool_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GameObject assetInContainer = base.GetAssetInContainer<GameObject>("RaffleRewardItemUIPrefab");
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(assetInContainer);
			gameObject.transform.SetParent(this.PrefabRoot, false);
			PrefabControllerCreater.CreateAllControllers(gameObject);
			PoolInfo poolInfoByName = this.EasyPool.GetPoolInfoByName("RaffleRewardItemUIPrefab");
			poolInfoByName.prefab = gameObject;
			poolInfoByName.poolSize = 6;
		}

		// Token: 0x06012538 RID: 75064 RVA: 0x004B51B8 File Offset: 0x004B33B8
		public void UpdateRaffleRewardPanel(RafflePool rafflePool, bool refreshAll)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateRaffleRewardPanelRafflePoolBoolean_hotfix != null)
			{
				this.m_UpdateRaffleRewardPanelRafflePoolBoolean_hotfix.call(new object[]
				{
					this,
					rafflePool,
					refreshAll
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.GainRaffleRewardLevelInfo(rafflePool);
			this.AllocRewardItemCtrl(this.m_raffleRewardLevelInfoDict.Count);
			int num = 0;
			foreach (KeyValuePair<int, List<RaffleItem>> keyValuePair in this.m_raffleRewardLevelInfoDict)
			{
				if (refreshAll)
				{
					this.m_rewardItemCtrlList[num].UpdateRaffleRewardItemInfo(keyValuePair.Key, keyValuePair.Value, rafflePool.DrawedRaffleIds);
				}
				else
				{
					this.m_rewardItemCtrlList[num].UpdateRewardItemGotState(keyValuePair.Value, rafflePool.DrawedRaffleIds);
				}
				num++;
			}
			this.RewardScrollRect.verticalNormalizedPosition = 1f;
		}

		// Token: 0x06012539 RID: 75065 RVA: 0x004B52FC File Offset: 0x004B34FC
		public void ShowRaffleRewardPanel(bool isShow, Action onEnd)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowRaffleRewardPanelBooleanAction_hotfix != null)
			{
				this.m_ShowRaffleRewardPanelBooleanAction_hotfix.call(new object[]
				{
					this,
					isShow,
					onEnd2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Action onEnd = onEnd2;
			RaffleRewardUIController $this = this;
			this.m_isShow = isShow;
			if (isShow)
			{
				base.gameObject.SetActive(true);
				UIUtility.SetUIStateOpen(this.UIStateCtrl, "Show", onEnd, true, true);
			}
			else
			{
				UIUtility.SetUIStateOpen(this.UIStateCtrl, "Close", delegate
				{
					$this.gameObject.SetActive(false);
					if (onEnd != null)
					{
						onEnd();
					}
				}, true, true);
			}
		}

		// Token: 0x0601253A RID: 75066 RVA: 0x004B53E4 File Offset: 0x004B35E4
		public bool IsRaffleRewardPanelShow()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsRaffleRewardPanelShow_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsRaffleRewardPanelShow_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_isShow;
		}

		// Token: 0x0601253B RID: 75067 RVA: 0x004B5458 File Offset: 0x004B3658
		protected void GainRaffleRewardLevelInfo(RafflePool rafflePool)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GainRaffleRewardLevelInfoRafflePool_hotfix != null)
			{
				this.m_GainRaffleRewardLevelInfoRafflePool_hotfix.call(new object[]
				{
					this,
					rafflePool
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_raffleRewardLevelInfoDict.Clear();
			foreach (RaffleItem raffleItem in rafflePool.Config.RaffleItems)
			{
				if (!this.m_raffleRewardLevelInfoDict.ContainsKey(raffleItem.RaffleLevel))
				{
					this.m_raffleRewardLevelInfoDict[raffleItem.RaffleLevel] = new List<RaffleItem>();
				}
				this.m_raffleRewardLevelInfoDict[raffleItem.RaffleLevel].Add(raffleItem);
			}
		}

		// Token: 0x0601253C RID: 75068 RVA: 0x004B5564 File Offset: 0x004B3764
		protected void AllocRewardItemCtrl(int count)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AllocRewardItemCtrlInt32_hotfix != null)
			{
				this.m_AllocRewardItemCtrlInt32_hotfix.call(new object[]
				{
					this,
					count
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			while (this.m_rewardItemCtrlList.Count > count)
			{
				this.EasyPool.ReturnObjectToPool(this.m_rewardItemCtrlList[this.m_rewardItemCtrlList.Count - 1].gameObject);
			}
			while (this.m_rewardItemCtrlList.Count < count)
			{
				RaffleRewardItemUIController componentInChildren = this.EasyPool.GetObjectFromPool("RaffleRewardItemUIPrefab").GetComponentInChildren<RaffleRewardItemUIController>(true);
				componentInChildren.transform.SetParent(this.RewardItemRoot, false);
				this.m_rewardItemCtrlList.Add(componentInChildren);
			}
		}

		// Token: 0x0601253D RID: 75069 RVA: 0x004B5660 File Offset: 0x004B3860
		protected void OnCloseButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnCloseButtonClick_hotfix != null)
			{
				this.m_OnCloseButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnCloseButtonClick != null)
			{
				this.EventOnCloseButtonClick();
			}
		}

		// Token: 0x170037B0 RID: 14256
		// (get) Token: 0x0601253E RID: 75070 RVA: 0x004B56D8 File Offset: 0x004B38D8
		// (set) Token: 0x0601253F RID: 75071 RVA: 0x004B56F8 File Offset: 0x004B38F8
		[DoNotToLua]
		public new RaffleRewardUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new RaffleRewardUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06012540 RID: 75072 RVA: 0x004B5704 File Offset: 0x004B3904
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x06012541 RID: 75073 RVA: 0x004B5710 File Offset: 0x004B3910
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x06012542 RID: 75074 RVA: 0x004B5718 File Offset: 0x004B3918
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x06012543 RID: 75075 RVA: 0x004B5720 File Offset: 0x004B3920
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x06012544 RID: 75076 RVA: 0x004B5734 File Offset: 0x004B3934
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x06012545 RID: 75077 RVA: 0x004B573C File Offset: 0x004B393C
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x06012546 RID: 75078 RVA: 0x004B5748 File Offset: 0x004B3948
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x06012547 RID: 75079 RVA: 0x004B5754 File Offset: 0x004B3954
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x06012548 RID: 75080 RVA: 0x004B5760 File Offset: 0x004B3960
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x06012549 RID: 75081 RVA: 0x004B576C File Offset: 0x004B396C
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0601254A RID: 75082 RVA: 0x004B5778 File Offset: 0x004B3978
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0601254B RID: 75083 RVA: 0x004B5784 File Offset: 0x004B3984
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0601254C RID: 75084 RVA: 0x004B5790 File Offset: 0x004B3990
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0601254D RID: 75085 RVA: 0x004B579C File Offset: 0x004B399C
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0601254E RID: 75086 RVA: 0x004B57A8 File Offset: 0x004B39A8
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0601254F RID: 75087 RVA: 0x004B57B0 File Offset: 0x004B39B0
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
					this.m_InitRaffleRewardItemPool_hotfix = (luaObj.RawGet("InitRaffleRewardItemPool") as LuaFunction);
					this.m_UpdateRaffleRewardPanelRafflePoolBoolean_hotfix = (luaObj.RawGet("UpdateRaffleRewardPanel") as LuaFunction);
					this.m_ShowRaffleRewardPanelBooleanAction_hotfix = (luaObj.RawGet("ShowRaffleRewardPanel") as LuaFunction);
					this.m_IsRaffleRewardPanelShow_hotfix = (luaObj.RawGet("IsRaffleRewardPanelShow") as LuaFunction);
					this.m_GainRaffleRewardLevelInfoRafflePool_hotfix = (luaObj.RawGet("GainRaffleRewardLevelInfo") as LuaFunction);
					this.m_AllocRewardItemCtrlInt32_hotfix = (luaObj.RawGet("AllocRewardItemCtrl") as LuaFunction);
					this.m_OnCloseButtonClick_hotfix = (luaObj.RawGet("OnCloseButtonClick") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06012550 RID: 75088 RVA: 0x004B592C File Offset: 0x004B3B2C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(RaffleRewardUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400A508 RID: 42248
		protected Dictionary<int, List<RaffleItem>> m_raffleRewardLevelInfoDict = new Dictionary<int, List<RaffleItem>>();

		// Token: 0x0400A509 RID: 42249
		protected List<RaffleRewardItemUIController> m_rewardItemCtrlList = new List<RaffleRewardItemUIController>();

		// Token: 0x0400A50A RID: 42250
		public Action EventOnCloseButtonClick;

		// Token: 0x0400A50B RID: 42251
		protected bool m_isShow;

		// Token: 0x0400A50C RID: 42252
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		public CommonUIStateController UIStateCtrl;

		// Token: 0x0400A50D RID: 42253
		[AutoBind("./PrefabRoot", AutoBindAttribute.InitState.NotInit, false)]
		public Transform PrefabRoot;

		// Token: 0x0400A50E RID: 42254
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		public EasyObjectPool EasyPool;

		// Token: 0x0400A50F RID: 42255
		[AutoBind("./LayoutRoot/RewardScrollView/Viewport/RewardItemLayContent", AutoBindAttribute.InitState.NotInit, false)]
		public Transform RewardItemRoot;

		// Token: 0x0400A510 RID: 42256
		[AutoBind("./LayoutRoot/CloseBth", AutoBindAttribute.InitState.NotInit, false)]
		public Button CloseButton;

		// Token: 0x0400A511 RID: 42257
		[AutoBind("./LayoutRoot/RewardScrollView", AutoBindAttribute.InitState.NotInit, false)]
		public ScrollRect RewardScrollRect;

		// Token: 0x0400A512 RID: 42258
		[AutoBind("./BGButton", AutoBindAttribute.InitState.NotInit, false)]
		public Button BgButton;

		// Token: 0x0400A513 RID: 42259
		[DoNotToLua]
		private RaffleRewardUIController.LuaExportHelper luaExportHelper;

		// Token: 0x0400A514 RID: 42260
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400A515 RID: 42261
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400A516 RID: 42262
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x0400A517 RID: 42263
		private LuaFunction m_InitRaffleRewardItemPool_hotfix;

		// Token: 0x0400A518 RID: 42264
		private LuaFunction m_UpdateRaffleRewardPanelRafflePoolBoolean_hotfix;

		// Token: 0x0400A519 RID: 42265
		private LuaFunction m_ShowRaffleRewardPanelBooleanAction_hotfix;

		// Token: 0x0400A51A RID: 42266
		private LuaFunction m_IsRaffleRewardPanelShow_hotfix;

		// Token: 0x0400A51B RID: 42267
		private LuaFunction m_GainRaffleRewardLevelInfoRafflePool_hotfix;

		// Token: 0x0400A51C RID: 42268
		private LuaFunction m_AllocRewardItemCtrlInt32_hotfix;

		// Token: 0x0400A51D RID: 42269
		private LuaFunction m_OnCloseButtonClick_hotfix;

		// Token: 0x02000EA9 RID: 3753
		public new class LuaExportHelper
		{
			// Token: 0x06012551 RID: 75089 RVA: 0x004B5994 File Offset: 0x004B3B94
			public LuaExportHelper(RaffleRewardUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06012552 RID: 75090 RVA: 0x004B59A4 File Offset: 0x004B3BA4
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x06012553 RID: 75091 RVA: 0x004B59B4 File Offset: 0x004B3BB4
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x06012554 RID: 75092 RVA: 0x004B59C4 File Offset: 0x004B3BC4
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x06012555 RID: 75093 RVA: 0x004B59D4 File Offset: 0x004B3BD4
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x06012556 RID: 75094 RVA: 0x004B59EC File Offset: 0x004B3BEC
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x06012557 RID: 75095 RVA: 0x004B59FC File Offset: 0x004B3BFC
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x06012558 RID: 75096 RVA: 0x004B5A0C File Offset: 0x004B3C0C
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x06012559 RID: 75097 RVA: 0x004B5A1C File Offset: 0x004B3C1C
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0601255A RID: 75098 RVA: 0x004B5A2C File Offset: 0x004B3C2C
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0601255B RID: 75099 RVA: 0x004B5A3C File Offset: 0x004B3C3C
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0601255C RID: 75100 RVA: 0x004B5A4C File Offset: 0x004B3C4C
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0601255D RID: 75101 RVA: 0x004B5A5C File Offset: 0x004B3C5C
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0601255E RID: 75102 RVA: 0x004B5A6C File Offset: 0x004B3C6C
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0601255F RID: 75103 RVA: 0x004B5A7C File Offset: 0x004B3C7C
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x06012560 RID: 75104 RVA: 0x004B5A8C File Offset: 0x004B3C8C
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x170037B1 RID: 14257
			// (get) Token: 0x06012561 RID: 75105 RVA: 0x004B5A9C File Offset: 0x004B3C9C
			// (set) Token: 0x06012562 RID: 75106 RVA: 0x004B5AAC File Offset: 0x004B3CAC
			public Dictionary<int, List<RaffleItem>> m_raffleRewardLevelInfoDict
			{
				get
				{
					return this.m_owner.m_raffleRewardLevelInfoDict;
				}
				set
				{
					this.m_owner.m_raffleRewardLevelInfoDict = value;
				}
			}

			// Token: 0x170037B2 RID: 14258
			// (get) Token: 0x06012563 RID: 75107 RVA: 0x004B5ABC File Offset: 0x004B3CBC
			// (set) Token: 0x06012564 RID: 75108 RVA: 0x004B5ACC File Offset: 0x004B3CCC
			public List<RaffleRewardItemUIController> m_rewardItemCtrlList
			{
				get
				{
					return this.m_owner.m_rewardItemCtrlList;
				}
				set
				{
					this.m_owner.m_rewardItemCtrlList = value;
				}
			}

			// Token: 0x170037B3 RID: 14259
			// (get) Token: 0x06012565 RID: 75109 RVA: 0x004B5ADC File Offset: 0x004B3CDC
			// (set) Token: 0x06012566 RID: 75110 RVA: 0x004B5AEC File Offset: 0x004B3CEC
			public bool m_isShow
			{
				get
				{
					return this.m_owner.m_isShow;
				}
				set
				{
					this.m_owner.m_isShow = value;
				}
			}

			// Token: 0x06012567 RID: 75111 RVA: 0x004B5AFC File Offset: 0x004B3CFC
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x06012568 RID: 75112 RVA: 0x004B5B0C File Offset: 0x004B3D0C
			public void InitRaffleRewardItemPool()
			{
				this.m_owner.InitRaffleRewardItemPool();
			}

			// Token: 0x06012569 RID: 75113 RVA: 0x004B5B1C File Offset: 0x004B3D1C
			public void GainRaffleRewardLevelInfo(RafflePool rafflePool)
			{
				this.m_owner.GainRaffleRewardLevelInfo(rafflePool);
			}

			// Token: 0x0601256A RID: 75114 RVA: 0x004B5B2C File Offset: 0x004B3D2C
			public void AllocRewardItemCtrl(int count)
			{
				this.m_owner.AllocRewardItemCtrl(count);
			}

			// Token: 0x0601256B RID: 75115 RVA: 0x004B5B3C File Offset: 0x004B3D3C
			public void OnCloseButtonClick()
			{
				this.m_owner.OnCloseButtonClick();
			}

			// Token: 0x0400A51E RID: 42270
			private RaffleRewardUIController m_owner;
		}
	}
}
