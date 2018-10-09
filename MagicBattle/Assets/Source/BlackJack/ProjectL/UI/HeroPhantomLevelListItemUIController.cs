using System;
using System.Collections.Generic;
using System.Threading;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Misc;
using BlackJack.ProjectL.PlayerContext;
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000E20 RID: 3616
	[HotFix]
	public class HeroPhantomLevelListItemUIController : UIControllerBase
	{
		// Token: 0x060116E5 RID: 71397 RVA: 0x0048438C File Offset: 0x0048258C
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
			this.m_startButton.onClick.AddListener(new UnityAction(this.OnStartButtonClick));
			this.m_achievementButton.onClick.AddListener(new UnityAction(this.OnAchievementButtonClick));
			this.m_lockedButton.onClick.AddListener(new UnityAction(this.OnLockedButtonClick));
		}

		// Token: 0x060116E6 RID: 71398 RVA: 0x00484448 File Offset: 0x00482648
		public void SetHeroPhantomLevelInfo(ConfigDataHeroPhantomLevelInfo levelInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetHeroPhantomLevelInfoConfigDataHeroPhantomLevelInfo_hotfix != null)
			{
				this.m_SetHeroPhantomLevelInfoConfigDataHeroPhantomLevelInfo_hotfix.call(new object[]
				{
					this,
					levelInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			this.m_heroPhantomLevelInfo = levelInfo;
			this.m_levelText.text = levelInfo.MonsterLevel.ToString();
			this.m_energyText.text = levelInfo.EnergySuccess.ToString();
			this.m_achievementCount.text = projectLPlayerContext.GetHeroPhantomLevelCompleteAchievementCount(levelInfo.ID) + "/" + levelInfo.m_achievements.Length;
			this.m_firstCleanUIStateController.SetToUIState((!projectLPlayerContext.IsHeroPhantomLevelFirstCleanComplete(levelInfo.ID)) ? "Normal" : "Clean", false, true);
			GameObject assetInContainer = base.GetAssetInContainer<GameObject>("RewardGoods");
			GameObjectUtility.DestroyChildren(this.m_firstRewardGroupGameObject);
			List<Goods> list = new List<Goods>();
			if (levelInfo.FirstClearDropItems.Count > 0)
			{
				list.Add(levelInfo.FirstClearDropItems[0]);
			}
			RewardGoodsUIController.CreateRewardGoodsList(list, this.m_firstRewardGroupGameObject.transform, assetInContainer, null, true, 0, true);
			GameObjectUtility.DestroyChildren(this.m_rewardGroupGameObject);
			List<Goods> list2 = new List<Goods>();
			UIUtility.AppendRandomDropRewardGoodsToList(levelInfo.DropID, list2);
			if (list2.Count > levelInfo.DisplayRewardCount)
			{
				list2.RemoveRange(levelInfo.DisplayRewardCount, list2.Count - levelInfo.DisplayRewardCount);
			}
			RewardGoodsUIController.CreateRewardGoodsList(list2, this.m_rewardGroupGameObject.transform, assetInContainer, null, false, 0, true);
		}

		// Token: 0x060116E7 RID: 71399 RVA: 0x0048462C File Offset: 0x0048282C
		public ConfigDataHeroPhantomLevelInfo GetHeroPhantomLevelInfo()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetHeroPhantomLevelInfo_hotfix != null)
			{
				return (ConfigDataHeroPhantomLevelInfo)this.m_GetHeroPhantomLevelInfo_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_heroPhantomLevelInfo;
		}

		// Token: 0x060116E8 RID: 71400 RVA: 0x004846A0 File Offset: 0x004828A0
		public void SetLocked(bool locked)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetLockedBoolean_hotfix != null)
			{
				this.m_SetLockedBoolean_hotfix.call(new object[]
				{
					this,
					locked
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_lockedButton.gameObject.SetActive(locked);
		}

		// Token: 0x060116E9 RID: 71401 RVA: 0x00484724 File Offset: 0x00482924
		private void OnStartButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnStartButtonClick_hotfix != null)
			{
				this.m_OnStartButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnStartButtonClick != null)
			{
				this.EventOnStartButtonClick(this);
			}
		}

		// Token: 0x060116EA RID: 71402 RVA: 0x0048479C File Offset: 0x0048299C
		private void OnAchievementButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnAchievementButtonClick_hotfix != null)
			{
				this.m_OnAchievementButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnAchievementButtonClick != null)
			{
				this.EventOnAchievementButtonClick(this);
			}
		}

		// Token: 0x060116EB RID: 71403 RVA: 0x00484814 File Offset: 0x00482A14
		private void OnLockedButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnLockedButtonClick_hotfix != null)
			{
				this.m_OnLockedButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIController.Instance.ShowMessage(StringTableId.StringTableId_Msg_PreLevelCompleteOpen, 2f, null, true);
		}

		// Token: 0x140003C0 RID: 960
		// (add) Token: 0x060116EC RID: 71404 RVA: 0x0048488C File Offset: 0x00482A8C
		// (remove) Token: 0x060116ED RID: 71405 RVA: 0x00484928 File Offset: 0x00482B28
		public event Action<HeroPhantomLevelListItemUIController> EventOnStartButtonClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnStartButtonClickAction`1_hotfix != null)
				{
					this.m_add_EventOnStartButtonClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<HeroPhantomLevelListItemUIController> action = this.EventOnStartButtonClick;
				Action<HeroPhantomLevelListItemUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<HeroPhantomLevelListItemUIController>>(ref this.EventOnStartButtonClick, (Action<HeroPhantomLevelListItemUIController>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnStartButtonClickAction`1_hotfix != null)
				{
					this.m_remove_EventOnStartButtonClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<HeroPhantomLevelListItemUIController> action = this.EventOnStartButtonClick;
				Action<HeroPhantomLevelListItemUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<HeroPhantomLevelListItemUIController>>(ref this.EventOnStartButtonClick, (Action<HeroPhantomLevelListItemUIController>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140003C1 RID: 961
		// (add) Token: 0x060116EE RID: 71406 RVA: 0x004849C4 File Offset: 0x00482BC4
		// (remove) Token: 0x060116EF RID: 71407 RVA: 0x00484A60 File Offset: 0x00482C60
		public event Action<HeroPhantomLevelListItemUIController> EventOnAchievementButtonClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnAchievementButtonClickAction`1_hotfix != null)
				{
					this.m_add_EventOnAchievementButtonClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<HeroPhantomLevelListItemUIController> action = this.EventOnAchievementButtonClick;
				Action<HeroPhantomLevelListItemUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<HeroPhantomLevelListItemUIController>>(ref this.EventOnAchievementButtonClick, (Action<HeroPhantomLevelListItemUIController>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnAchievementButtonClickAction`1_hotfix != null)
				{
					this.m_remove_EventOnAchievementButtonClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<HeroPhantomLevelListItemUIController> action = this.EventOnAchievementButtonClick;
				Action<HeroPhantomLevelListItemUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<HeroPhantomLevelListItemUIController>>(ref this.EventOnAchievementButtonClick, (Action<HeroPhantomLevelListItemUIController>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x170035A8 RID: 13736
		// (get) Token: 0x060116F0 RID: 71408 RVA: 0x00484AFC File Offset: 0x00482CFC
		// (set) Token: 0x060116F1 RID: 71409 RVA: 0x00484B1C File Offset: 0x00482D1C
		[DoNotToLua]
		public new HeroPhantomLevelListItemUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new HeroPhantomLevelListItemUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x060116F2 RID: 71410 RVA: 0x00484B28 File Offset: 0x00482D28
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x060116F3 RID: 71411 RVA: 0x00484B34 File Offset: 0x00482D34
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x060116F4 RID: 71412 RVA: 0x00484B3C File Offset: 0x00482D3C
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x060116F5 RID: 71413 RVA: 0x00484B44 File Offset: 0x00482D44
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x060116F6 RID: 71414 RVA: 0x00484B58 File Offset: 0x00482D58
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x060116F7 RID: 71415 RVA: 0x00484B60 File Offset: 0x00482D60
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x060116F8 RID: 71416 RVA: 0x00484B6C File Offset: 0x00482D6C
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x060116F9 RID: 71417 RVA: 0x00484B78 File Offset: 0x00482D78
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x060116FA RID: 71418 RVA: 0x00484B84 File Offset: 0x00482D84
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x060116FB RID: 71419 RVA: 0x00484B90 File Offset: 0x00482D90
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x060116FC RID: 71420 RVA: 0x00484B9C File Offset: 0x00482D9C
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x060116FD RID: 71421 RVA: 0x00484BA8 File Offset: 0x00482DA8
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x060116FE RID: 71422 RVA: 0x00484BB4 File Offset: 0x00482DB4
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x060116FF RID: 71423 RVA: 0x00484BC0 File Offset: 0x00482DC0
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x06011700 RID: 71424 RVA: 0x00484BCC File Offset: 0x00482DCC
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x06011701 RID: 71425 RVA: 0x00484BD4 File Offset: 0x00482DD4
		private void __callDele_EventOnStartButtonClick(HeroPhantomLevelListItemUIController obj)
		{
			Action<HeroPhantomLevelListItemUIController> eventOnStartButtonClick = this.EventOnStartButtonClick;
			if (eventOnStartButtonClick != null)
			{
				eventOnStartButtonClick(obj);
			}
		}

		// Token: 0x06011702 RID: 71426 RVA: 0x00484BF8 File Offset: 0x00482DF8
		private void __clearDele_EventOnStartButtonClick(HeroPhantomLevelListItemUIController obj)
		{
			this.EventOnStartButtonClick = null;
		}

		// Token: 0x06011703 RID: 71427 RVA: 0x00484C04 File Offset: 0x00482E04
		private void __callDele_EventOnAchievementButtonClick(HeroPhantomLevelListItemUIController obj)
		{
			Action<HeroPhantomLevelListItemUIController> eventOnAchievementButtonClick = this.EventOnAchievementButtonClick;
			if (eventOnAchievementButtonClick != null)
			{
				eventOnAchievementButtonClick(obj);
			}
		}

		// Token: 0x06011704 RID: 71428 RVA: 0x00484C28 File Offset: 0x00482E28
		private void __clearDele_EventOnAchievementButtonClick(HeroPhantomLevelListItemUIController obj)
		{
			this.EventOnAchievementButtonClick = null;
		}

		// Token: 0x06011705 RID: 71429 RVA: 0x00484C34 File Offset: 0x00482E34
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
					this.m_SetHeroPhantomLevelInfoConfigDataHeroPhantomLevelInfo_hotfix = (luaObj.RawGet("SetHeroPhantomLevelInfo") as LuaFunction);
					this.m_GetHeroPhantomLevelInfo_hotfix = (luaObj.RawGet("GetHeroPhantomLevelInfo") as LuaFunction);
					this.m_SetLockedBoolean_hotfix = (luaObj.RawGet("SetLocked") as LuaFunction);
					this.m_OnStartButtonClick_hotfix = (luaObj.RawGet("OnStartButtonClick") as LuaFunction);
					this.m_OnAchievementButtonClick_hotfix = (luaObj.RawGet("OnAchievementButtonClick") as LuaFunction);
					this.m_OnLockedButtonClick_hotfix = (luaObj.RawGet("OnLockedButtonClick") as LuaFunction);
					this.m_add_EventOnStartButtonClickAction`1_hotfix = (luaObj.RawGet("add_EventOnStartButtonClick") as LuaFunction);
					this.m_remove_EventOnStartButtonClickAction`1_hotfix = (luaObj.RawGet("remove_EventOnStartButtonClick") as LuaFunction);
					this.m_add_EventOnAchievementButtonClickAction`1_hotfix = (luaObj.RawGet("add_EventOnAchievementButtonClick") as LuaFunction);
					this.m_remove_EventOnAchievementButtonClickAction`1_hotfix = (luaObj.RawGet("remove_EventOnAchievementButtonClick") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06011706 RID: 71430 RVA: 0x00484DFC File Offset: 0x00482FFC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(HeroPhantomLevelListItemUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04009F5B RID: 40795
		[AutoBind("./Level/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_levelText;

		// Token: 0x04009F5C RID: 40796
		[AutoBind("./EnergyValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_energyText;

		// Token: 0x04009F5D RID: 40797
		[AutoBind("./Locked", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_lockedButton;

		// Token: 0x04009F5E RID: 40798
		[AutoBind("./AchievementButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_achievementButton;

		// Token: 0x04009F5F RID: 40799
		[AutoBind("./AchievementCount", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_achievementCount;

		// Token: 0x04009F60 RID: 40800
		[AutoBind("./StartButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_startButton;

		// Token: 0x04009F61 RID: 40801
		[AutoBind("./RewardGroup", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_rewardGroupGameObject;

		// Token: 0x04009F62 RID: 40802
		[AutoBind("./FirstClean", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_firstCleanUIStateController;

		// Token: 0x04009F63 RID: 40803
		[AutoBind("./FirstClean/RewardDummy", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_firstRewardGroupGameObject;

		// Token: 0x04009F64 RID: 40804
		private ConfigDataHeroPhantomLevelInfo m_heroPhantomLevelInfo;

		// Token: 0x04009F65 RID: 40805
		[DoNotToLua]
		private HeroPhantomLevelListItemUIController.LuaExportHelper luaExportHelper;

		// Token: 0x04009F66 RID: 40806
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04009F67 RID: 40807
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04009F68 RID: 40808
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x04009F69 RID: 40809
		private LuaFunction m_SetHeroPhantomLevelInfoConfigDataHeroPhantomLevelInfo_hotfix;

		// Token: 0x04009F6A RID: 40810
		private LuaFunction m_GetHeroPhantomLevelInfo_hotfix;

		// Token: 0x04009F6B RID: 40811
		private LuaFunction m_SetLockedBoolean_hotfix;

		// Token: 0x04009F6C RID: 40812
		private LuaFunction m_OnStartButtonClick_hotfix;

		// Token: 0x04009F6D RID: 40813
		private LuaFunction m_OnAchievementButtonClick_hotfix;

		// Token: 0x04009F6E RID: 40814
		private LuaFunction m_OnLockedButtonClick_hotfix;

		// Token: 0x04009F6F RID: 40815
		private LuaFunction m_add_EventOnStartButtonClickAction;

		// Token: 0x04009F70 RID: 40816
		private LuaFunction m_remove_EventOnStartButtonClickAction;

		// Token: 0x04009F71 RID: 40817
		private LuaFunction m_add_EventOnAchievementButtonClickAction;

		// Token: 0x04009F72 RID: 40818
		private LuaFunction m_remove_EventOnAchievementButtonClickAction;

		// Token: 0x02000E21 RID: 3617
		public new class LuaExportHelper
		{
			// Token: 0x06011707 RID: 71431 RVA: 0x00484E64 File Offset: 0x00483064
			public LuaExportHelper(HeroPhantomLevelListItemUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06011708 RID: 71432 RVA: 0x00484E74 File Offset: 0x00483074
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x06011709 RID: 71433 RVA: 0x00484E84 File Offset: 0x00483084
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0601170A RID: 71434 RVA: 0x00484E94 File Offset: 0x00483094
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0601170B RID: 71435 RVA: 0x00484EA4 File Offset: 0x004830A4
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0601170C RID: 71436 RVA: 0x00484EBC File Offset: 0x004830BC
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0601170D RID: 71437 RVA: 0x00484ECC File Offset: 0x004830CC
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0601170E RID: 71438 RVA: 0x00484EDC File Offset: 0x004830DC
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0601170F RID: 71439 RVA: 0x00484EEC File Offset: 0x004830EC
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x06011710 RID: 71440 RVA: 0x00484EFC File Offset: 0x004830FC
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x06011711 RID: 71441 RVA: 0x00484F0C File Offset: 0x0048310C
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x06011712 RID: 71442 RVA: 0x00484F1C File Offset: 0x0048311C
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x06011713 RID: 71443 RVA: 0x00484F2C File Offset: 0x0048312C
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x06011714 RID: 71444 RVA: 0x00484F3C File Offset: 0x0048313C
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x06011715 RID: 71445 RVA: 0x00484F4C File Offset: 0x0048314C
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x06011716 RID: 71446 RVA: 0x00484F5C File Offset: 0x0048315C
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x06011717 RID: 71447 RVA: 0x00484F6C File Offset: 0x0048316C
			public void __callDele_EventOnStartButtonClick(HeroPhantomLevelListItemUIController obj)
			{
				this.m_owner.__callDele_EventOnStartButtonClick(obj);
			}

			// Token: 0x06011718 RID: 71448 RVA: 0x00484F7C File Offset: 0x0048317C
			public void __clearDele_EventOnStartButtonClick(HeroPhantomLevelListItemUIController obj)
			{
				this.m_owner.__clearDele_EventOnStartButtonClick(obj);
			}

			// Token: 0x06011719 RID: 71449 RVA: 0x00484F8C File Offset: 0x0048318C
			public void __callDele_EventOnAchievementButtonClick(HeroPhantomLevelListItemUIController obj)
			{
				this.m_owner.__callDele_EventOnAchievementButtonClick(obj);
			}

			// Token: 0x0601171A RID: 71450 RVA: 0x00484F9C File Offset: 0x0048319C
			public void __clearDele_EventOnAchievementButtonClick(HeroPhantomLevelListItemUIController obj)
			{
				this.m_owner.__clearDele_EventOnAchievementButtonClick(obj);
			}

			// Token: 0x170035A9 RID: 13737
			// (get) Token: 0x0601171B RID: 71451 RVA: 0x00484FAC File Offset: 0x004831AC
			// (set) Token: 0x0601171C RID: 71452 RVA: 0x00484FBC File Offset: 0x004831BC
			public Text m_levelText
			{
				get
				{
					return this.m_owner.m_levelText;
				}
				set
				{
					this.m_owner.m_levelText = value;
				}
			}

			// Token: 0x170035AA RID: 13738
			// (get) Token: 0x0601171D RID: 71453 RVA: 0x00484FCC File Offset: 0x004831CC
			// (set) Token: 0x0601171E RID: 71454 RVA: 0x00484FDC File Offset: 0x004831DC
			public Text m_energyText
			{
				get
				{
					return this.m_owner.m_energyText;
				}
				set
				{
					this.m_owner.m_energyText = value;
				}
			}

			// Token: 0x170035AB RID: 13739
			// (get) Token: 0x0601171F RID: 71455 RVA: 0x00484FEC File Offset: 0x004831EC
			// (set) Token: 0x06011720 RID: 71456 RVA: 0x00484FFC File Offset: 0x004831FC
			public Button m_lockedButton
			{
				get
				{
					return this.m_owner.m_lockedButton;
				}
				set
				{
					this.m_owner.m_lockedButton = value;
				}
			}

			// Token: 0x170035AC RID: 13740
			// (get) Token: 0x06011721 RID: 71457 RVA: 0x0048500C File Offset: 0x0048320C
			// (set) Token: 0x06011722 RID: 71458 RVA: 0x0048501C File Offset: 0x0048321C
			public Button m_achievementButton
			{
				get
				{
					return this.m_owner.m_achievementButton;
				}
				set
				{
					this.m_owner.m_achievementButton = value;
				}
			}

			// Token: 0x170035AD RID: 13741
			// (get) Token: 0x06011723 RID: 71459 RVA: 0x0048502C File Offset: 0x0048322C
			// (set) Token: 0x06011724 RID: 71460 RVA: 0x0048503C File Offset: 0x0048323C
			public Text m_achievementCount
			{
				get
				{
					return this.m_owner.m_achievementCount;
				}
				set
				{
					this.m_owner.m_achievementCount = value;
				}
			}

			// Token: 0x170035AE RID: 13742
			// (get) Token: 0x06011725 RID: 71461 RVA: 0x0048504C File Offset: 0x0048324C
			// (set) Token: 0x06011726 RID: 71462 RVA: 0x0048505C File Offset: 0x0048325C
			public Button m_startButton
			{
				get
				{
					return this.m_owner.m_startButton;
				}
				set
				{
					this.m_owner.m_startButton = value;
				}
			}

			// Token: 0x170035AF RID: 13743
			// (get) Token: 0x06011727 RID: 71463 RVA: 0x0048506C File Offset: 0x0048326C
			// (set) Token: 0x06011728 RID: 71464 RVA: 0x0048507C File Offset: 0x0048327C
			public GameObject m_rewardGroupGameObject
			{
				get
				{
					return this.m_owner.m_rewardGroupGameObject;
				}
				set
				{
					this.m_owner.m_rewardGroupGameObject = value;
				}
			}

			// Token: 0x170035B0 RID: 13744
			// (get) Token: 0x06011729 RID: 71465 RVA: 0x0048508C File Offset: 0x0048328C
			// (set) Token: 0x0601172A RID: 71466 RVA: 0x0048509C File Offset: 0x0048329C
			public CommonUIStateController m_firstCleanUIStateController
			{
				get
				{
					return this.m_owner.m_firstCleanUIStateController;
				}
				set
				{
					this.m_owner.m_firstCleanUIStateController = value;
				}
			}

			// Token: 0x170035B1 RID: 13745
			// (get) Token: 0x0601172B RID: 71467 RVA: 0x004850AC File Offset: 0x004832AC
			// (set) Token: 0x0601172C RID: 71468 RVA: 0x004850BC File Offset: 0x004832BC
			public GameObject m_firstRewardGroupGameObject
			{
				get
				{
					return this.m_owner.m_firstRewardGroupGameObject;
				}
				set
				{
					this.m_owner.m_firstRewardGroupGameObject = value;
				}
			}

			// Token: 0x170035B2 RID: 13746
			// (get) Token: 0x0601172D RID: 71469 RVA: 0x004850CC File Offset: 0x004832CC
			// (set) Token: 0x0601172E RID: 71470 RVA: 0x004850DC File Offset: 0x004832DC
			public ConfigDataHeroPhantomLevelInfo m_heroPhantomLevelInfo
			{
				get
				{
					return this.m_owner.m_heroPhantomLevelInfo;
				}
				set
				{
					this.m_owner.m_heroPhantomLevelInfo = value;
				}
			}

			// Token: 0x0601172F RID: 71471 RVA: 0x004850EC File Offset: 0x004832EC
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x06011730 RID: 71472 RVA: 0x004850FC File Offset: 0x004832FC
			public void OnStartButtonClick()
			{
				this.m_owner.OnStartButtonClick();
			}

			// Token: 0x06011731 RID: 71473 RVA: 0x0048510C File Offset: 0x0048330C
			public void OnAchievementButtonClick()
			{
				this.m_owner.OnAchievementButtonClick();
			}

			// Token: 0x06011732 RID: 71474 RVA: 0x0048511C File Offset: 0x0048331C
			public void OnLockedButtonClick()
			{
				this.m_owner.OnLockedButtonClick();
			}

			// Token: 0x04009F73 RID: 40819
			private HeroPhantomLevelListItemUIController m_owner;
		}
	}
}
