using System;
using System.Runtime.CompilerServices;
using System.Threading;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Misc;
using BlackJack.ProjectL.PlayerContext;
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x020009AE RID: 2478
	[HotFix]
	public class OpenServiceMissonUIController : UIControllerBase
	{
		// Token: 0x06008FB7 RID: 36791 RVA: 0x0029D12C File Offset: 0x0029B32C
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
			this.m_gotoButton.onClick.AddListener(new UnityAction(this.OnGotoButtonClick));
			this.m_getButton.onClick.AddListener(new UnityAction(this.OnGetButtonClick));
			base.gameObject.SetActive(true);
		}

		// Token: 0x06008FB8 RID: 36792 RVA: 0x0029D1D8 File Offset: 0x0029B3D8
		public void InitOpenServiceMissonInfo(Mission mission, bool hasGot)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitOpenServiceMissonInfoMissionBoolean_hotfix != null)
			{
				this.m_InitOpenServiceMissonInfoMissionBoolean_hotfix.call(new object[]
				{
					this,
					mission,
					hasGot
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.Mission = mission;
			this.SetOpenServiceMissionInfo();
			this.SetOpenServiceMissionState(hasGot);
		}

		// Token: 0x06008FB9 RID: 36793 RVA: 0x0029D26C File Offset: 0x0029B46C
		private void SetOpenServiceMissionInfo()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetOpenServiceMissionInfo_hotfix != null)
			{
				this.m_SetOpenServiceMissionInfo_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_infoText.text = this.Mission.Config.Title;
			if (this.Mission.Config.Reward.Count > 0)
			{
				RewardGoodsUIController rewardGoodsUIController;
				if (this.m_itemDummy.transform.childCount != 0)
				{
					GameObject gameObject = this.m_itemDummy.transform.GetChild(0).gameObject;
					gameObject.SetActive(true);
					rewardGoodsUIController = gameObject.GetComponent<RewardGoodsUIController>();
					if (rewardGoodsUIController == null)
					{
						rewardGoodsUIController = GameObjectUtility.AddControllerToGameObject<RewardGoodsUIController>(gameObject);
					}
				}
				else
				{
					GameObject gameObject2 = base.GetAssetInContainer<GameObject>("RewardGoods");
					gameObject2 = UnityEngine.Object.Instantiate<GameObject>(gameObject2);
					gameObject2.transform.SetParent(this.m_itemDummy.transform, false);
					rewardGoodsUIController = GameObjectUtility.AddControllerToGameObject<RewardGoodsUIController>(gameObject2);
				}
				rewardGoodsUIController.SetReward(this.Mission.Config.Reward[0], 1, false);
				rewardGoodsUIController.ShowCount(true);
			}
			else if (this.m_itemDummy.transform.childCount != 0)
			{
				Transform child = this.m_itemDummy.transform.GetChild(0);
				child.gameObject.SetActive(false);
			}
		}

		// Token: 0x06008FBA RID: 36794 RVA: 0x0029D3E4 File Offset: 0x0029B5E4
		private void SetOpenServiceMissionState(bool hasGot)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetOpenServiceMissionStateBoolean_hotfix != null)
			{
				this.m_SetOpenServiceMissionStateBoolean_hotfix.call(new object[]
				{
					this,
					hasGot
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			long missionCompleteProcess = projectLPlayerContext.GetMissionCompleteProcess(this.Mission);
			long num = (long)projectLPlayerContext.GetMissionMaxProcess(this.Mission);
			if (hasGot)
			{
				this.m_buttonGroupStateCtrl.SetToUIState("Got", false, true);
				this.m_progressBar.fillAmount = 1f;
				this.m_progressBarValueStateCtrl.SetToUIState("White", false, true);
				this.m_progressHaveCount.text = num.ToString();
				this.m_progressNeedCount.text = num.ToString();
				this.m_progressDoneText.SetActive(true);
			}
			else
			{
				if (missionCompleteProcess < num)
				{
					this.m_buttonGroupStateCtrl.SetToUIState("Go", false, true);
				}
				else
				{
					this.m_buttonGroupStateCtrl.SetToUIState("CanGet", false, true);
				}
				this.m_progressBar.fillAmount = (float)missionCompleteProcess / (float)num;
				if (missionCompleteProcess < num)
				{
					this.m_progressBarValueStateCtrl.SetToUIState("Red", false, true);
				}
				else
				{
					this.m_progressBarValueStateCtrl.SetToUIState("White", false, true);
				}
				this.m_progressHaveCount.text = missionCompleteProcess.ToString();
				this.m_progressNeedCount.text = num.ToString();
				this.m_progressDoneText.SetActive(missionCompleteProcess >= num);
			}
		}

		// Token: 0x06008FBB RID: 36795 RVA: 0x0029D5AC File Offset: 0x0029B7AC
		private void OnGotoButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnGotoButtonClick_hotfix != null)
			{
				this.m_OnGotoButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.Mission.Config.GetPathList.Count == 0)
			{
				return;
			}
			if (this.EventOnGotoButtonClick != null)
			{
				this.EventOnGotoButtonClick(this.Mission.Config.GetPathList[0]);
			}
		}

		// Token: 0x06008FBC RID: 36796 RVA: 0x0029D654 File Offset: 0x0029B854
		private void OnGetButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnGetButtonClick_hotfix != null)
			{
				this.m_OnGetButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnGetButtonClick != null)
			{
				this.EventOnGetButtonClick(this);
			}
		}

		// Token: 0x06008FBD RID: 36797 RVA: 0x0029D6CC File Offset: 0x0029B8CC
		public void PlayGetRewardEffect(Action OnStateFinish)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayGetRewardEffectAction_hotfix != null)
			{
				this.m_PlayGetRewardEffectAction_hotfix.call(new object[]
				{
					this,
					OnStateFinish2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Action OnStateFinish = OnStateFinish2;
			UIUtility.SetUIStateOpen(this.m_buttonGroupStateCtrl, "Change", delegate
			{
				if (OnStateFinish != null)
				{
					OnStateFinish();
				}
			}, true, true);
		}

		// Token: 0x14000190 RID: 400
		// (add) Token: 0x06008FBE RID: 36798 RVA: 0x0029D768 File Offset: 0x0029B968
		// (remove) Token: 0x06008FBF RID: 36799 RVA: 0x0029D804 File Offset: 0x0029BA04
		public event Action<GetPathData> EventOnGotoButtonClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnGotoButtonClickAction`1_hotfix != null)
				{
					this.m_add_EventOnGotoButtonClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<GetPathData> action = this.EventOnGotoButtonClick;
				Action<GetPathData> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<GetPathData>>(ref this.EventOnGotoButtonClick, (Action<GetPathData>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnGotoButtonClickAction`1_hotfix != null)
				{
					this.m_remove_EventOnGotoButtonClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<GetPathData> action = this.EventOnGotoButtonClick;
				Action<GetPathData> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<GetPathData>>(ref this.EventOnGotoButtonClick, (Action<GetPathData>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000191 RID: 401
		// (add) Token: 0x06008FC0 RID: 36800 RVA: 0x0029D8A0 File Offset: 0x0029BAA0
		// (remove) Token: 0x06008FC1 RID: 36801 RVA: 0x0029D93C File Offset: 0x0029BB3C
		public event Action<OpenServiceMissonUIController> EventOnGetButtonClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnGetButtonClickAction`1_hotfix != null)
				{
					this.m_add_EventOnGetButtonClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<OpenServiceMissonUIController> action = this.EventOnGetButtonClick;
				Action<OpenServiceMissonUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<OpenServiceMissonUIController>>(ref this.EventOnGetButtonClick, (Action<OpenServiceMissonUIController>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnGetButtonClickAction`1_hotfix != null)
				{
					this.m_remove_EventOnGetButtonClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<OpenServiceMissonUIController> action = this.EventOnGetButtonClick;
				Action<OpenServiceMissonUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<OpenServiceMissonUIController>>(ref this.EventOnGetButtonClick, (Action<OpenServiceMissonUIController>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17001DF7 RID: 7671
		// (get) Token: 0x06008FC3 RID: 36803 RVA: 0x0029DA50 File Offset: 0x0029BC50
		// (set) Token: 0x06008FC2 RID: 36802 RVA: 0x0029D9D8 File Offset: 0x0029BBD8
		public Mission Mission
		{
			[CompilerGenerated]
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_Mission_hotfix != null)
				{
					return (Mission)this.m_get_Mission_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.<Mission>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_set_MissionMission_hotfix != null)
				{
					this.m_set_MissionMission_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				this.<Mission>k__BackingField = value;
			}
		}

		// Token: 0x17001DF8 RID: 7672
		// (get) Token: 0x06008FC4 RID: 36804 RVA: 0x0029DAC4 File Offset: 0x0029BCC4
		// (set) Token: 0x06008FC5 RID: 36805 RVA: 0x0029DAE4 File Offset: 0x0029BCE4
		[DoNotToLua]
		public new OpenServiceMissonUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new OpenServiceMissonUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06008FC6 RID: 36806 RVA: 0x0029DAF0 File Offset: 0x0029BCF0
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x06008FC7 RID: 36807 RVA: 0x0029DAFC File Offset: 0x0029BCFC
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x06008FC8 RID: 36808 RVA: 0x0029DB04 File Offset: 0x0029BD04
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x06008FC9 RID: 36809 RVA: 0x0029DB0C File Offset: 0x0029BD0C
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x06008FCA RID: 36810 RVA: 0x0029DB20 File Offset: 0x0029BD20
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x06008FCB RID: 36811 RVA: 0x0029DB28 File Offset: 0x0029BD28
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x06008FCC RID: 36812 RVA: 0x0029DB34 File Offset: 0x0029BD34
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x06008FCD RID: 36813 RVA: 0x0029DB40 File Offset: 0x0029BD40
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x06008FCE RID: 36814 RVA: 0x0029DB4C File Offset: 0x0029BD4C
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x06008FCF RID: 36815 RVA: 0x0029DB58 File Offset: 0x0029BD58
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x06008FD0 RID: 36816 RVA: 0x0029DB64 File Offset: 0x0029BD64
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x06008FD1 RID: 36817 RVA: 0x0029DB70 File Offset: 0x0029BD70
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x06008FD2 RID: 36818 RVA: 0x0029DB7C File Offset: 0x0029BD7C
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x06008FD3 RID: 36819 RVA: 0x0029DB88 File Offset: 0x0029BD88
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x06008FD4 RID: 36820 RVA: 0x0029DB94 File Offset: 0x0029BD94
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x06008FD5 RID: 36821 RVA: 0x0029DB9C File Offset: 0x0029BD9C
		private void __callDele_EventOnGotoButtonClick(GetPathData obj)
		{
			Action<GetPathData> eventOnGotoButtonClick = this.EventOnGotoButtonClick;
			if (eventOnGotoButtonClick != null)
			{
				eventOnGotoButtonClick(obj);
			}
		}

		// Token: 0x06008FD6 RID: 36822 RVA: 0x0029DBC0 File Offset: 0x0029BDC0
		private void __clearDele_EventOnGotoButtonClick(GetPathData obj)
		{
			this.EventOnGotoButtonClick = null;
		}

		// Token: 0x06008FD7 RID: 36823 RVA: 0x0029DBCC File Offset: 0x0029BDCC
		private void __callDele_EventOnGetButtonClick(OpenServiceMissonUIController obj)
		{
			Action<OpenServiceMissonUIController> eventOnGetButtonClick = this.EventOnGetButtonClick;
			if (eventOnGetButtonClick != null)
			{
				eventOnGetButtonClick(obj);
			}
		}

		// Token: 0x06008FD8 RID: 36824 RVA: 0x0029DBF0 File Offset: 0x0029BDF0
		private void __clearDele_EventOnGetButtonClick(OpenServiceMissonUIController obj)
		{
			this.EventOnGetButtonClick = null;
		}

		// Token: 0x06008FD9 RID: 36825 RVA: 0x0029DBFC File Offset: 0x0029BDFC
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
					this.m_InitOpenServiceMissonInfoMissionBoolean_hotfix = (luaObj.RawGet("InitOpenServiceMissonInfo") as LuaFunction);
					this.m_SetOpenServiceMissionInfo_hotfix = (luaObj.RawGet("SetOpenServiceMissionInfo") as LuaFunction);
					this.m_SetOpenServiceMissionStateBoolean_hotfix = (luaObj.RawGet("SetOpenServiceMissionState") as LuaFunction);
					this.m_OnGotoButtonClick_hotfix = (luaObj.RawGet("OnGotoButtonClick") as LuaFunction);
					this.m_OnGetButtonClick_hotfix = (luaObj.RawGet("OnGetButtonClick") as LuaFunction);
					this.m_PlayGetRewardEffectAction_hotfix = (luaObj.RawGet("PlayGetRewardEffect") as LuaFunction);
					this.m_add_EventOnGotoButtonClickAction`1_hotfix = (luaObj.RawGet("add_EventOnGotoButtonClick") as LuaFunction);
					this.m_remove_EventOnGotoButtonClickAction`1_hotfix = (luaObj.RawGet("remove_EventOnGotoButtonClick") as LuaFunction);
					this.m_add_EventOnGetButtonClickAction`1_hotfix = (luaObj.RawGet("add_EventOnGetButtonClick") as LuaFunction);
					this.m_remove_EventOnGetButtonClickAction`1_hotfix = (luaObj.RawGet("remove_EventOnGetButtonClick") as LuaFunction);
					this.m_set_MissionMission_hotfix = (luaObj.RawGet("set_Mission") as LuaFunction);
					this.m_get_Mission_hotfix = (luaObj.RawGet("get_Mission") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06008FDA RID: 36826 RVA: 0x0029DDF4 File Offset: 0x0029BFF4
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(OpenServiceMissonUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400655A RID: 25946
		[AutoBind("./InfoText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_infoText;

		// Token: 0x0400655B RID: 25947
		[AutoBind("./ItemDummy", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_itemDummy;

		// Token: 0x0400655C RID: 25948
		[AutoBind("./ProgressBarBGImage/ProgressBar", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_progressBar;

		// Token: 0x0400655D RID: 25949
		[AutoBind("./ProgressBarBGImage/ProgressBarValueGroup", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_progressBarValueStateCtrl;

		// Token: 0x0400655E RID: 25950
		[AutoBind("./ProgressBarBGImage/ProgressBarValueGroup/HaveCount", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_progressHaveCount;

		// Token: 0x0400655F RID: 25951
		[AutoBind("./ProgressBarBGImage/ProgressBarValueGroup/NeedCount", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_progressNeedCount;

		// Token: 0x04006560 RID: 25952
		[AutoBind("./ProgressBarBGImage/DoneText", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_progressDoneText;

		// Token: 0x04006561 RID: 25953
		[AutoBind("./ButtonGroup", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_buttonGroupStateCtrl;

		// Token: 0x04006562 RID: 25954
		[AutoBind("./ButtonGroup/GoToButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_gotoButton;

		// Token: 0x04006563 RID: 25955
		[AutoBind("./ButtonGroup/GetButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_getButton;

		// Token: 0x04006565 RID: 25957
		[DoNotToLua]
		private OpenServiceMissonUIController.LuaExportHelper luaExportHelper;

		// Token: 0x04006566 RID: 25958
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04006567 RID: 25959
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04006568 RID: 25960
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x04006569 RID: 25961
		private LuaFunction m_InitOpenServiceMissonInfoMissionBoolean_hotfix;

		// Token: 0x0400656A RID: 25962
		private LuaFunction m_SetOpenServiceMissionInfo_hotfix;

		// Token: 0x0400656B RID: 25963
		private LuaFunction m_SetOpenServiceMissionStateBoolean_hotfix;

		// Token: 0x0400656C RID: 25964
		private LuaFunction m_OnGotoButtonClick_hotfix;

		// Token: 0x0400656D RID: 25965
		private LuaFunction m_OnGetButtonClick_hotfix;

		// Token: 0x0400656E RID: 25966
		private LuaFunction m_PlayGetRewardEffectAction_hotfix;

		// Token: 0x0400656F RID: 25967
		private LuaFunction m_add_EventOnGotoButtonClickAction;

		// Token: 0x04006570 RID: 25968
		private LuaFunction m_remove_EventOnGotoButtonClickAction;

		// Token: 0x04006571 RID: 25969
		private LuaFunction m_add_EventOnGetButtonClickAction;

		// Token: 0x04006572 RID: 25970
		private LuaFunction m_remove_EventOnGetButtonClickAction;

		// Token: 0x04006573 RID: 25971
		private LuaFunction m_set_MissionMission_hotfix;

		// Token: 0x04006574 RID: 25972
		private LuaFunction m_get_Mission_hotfix;

		// Token: 0x020009AF RID: 2479
		public new class LuaExportHelper
		{
			// Token: 0x06008FDB RID: 36827 RVA: 0x0029DE5C File Offset: 0x0029C05C
			public LuaExportHelper(OpenServiceMissonUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06008FDC RID: 36828 RVA: 0x0029DE6C File Offset: 0x0029C06C
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x06008FDD RID: 36829 RVA: 0x0029DE7C File Offset: 0x0029C07C
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x06008FDE RID: 36830 RVA: 0x0029DE8C File Offset: 0x0029C08C
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x06008FDF RID: 36831 RVA: 0x0029DE9C File Offset: 0x0029C09C
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x06008FE0 RID: 36832 RVA: 0x0029DEB4 File Offset: 0x0029C0B4
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x06008FE1 RID: 36833 RVA: 0x0029DEC4 File Offset: 0x0029C0C4
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x06008FE2 RID: 36834 RVA: 0x0029DED4 File Offset: 0x0029C0D4
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x06008FE3 RID: 36835 RVA: 0x0029DEE4 File Offset: 0x0029C0E4
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x06008FE4 RID: 36836 RVA: 0x0029DEF4 File Offset: 0x0029C0F4
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x06008FE5 RID: 36837 RVA: 0x0029DF04 File Offset: 0x0029C104
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x06008FE6 RID: 36838 RVA: 0x0029DF14 File Offset: 0x0029C114
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x06008FE7 RID: 36839 RVA: 0x0029DF24 File Offset: 0x0029C124
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x06008FE8 RID: 36840 RVA: 0x0029DF34 File Offset: 0x0029C134
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x06008FE9 RID: 36841 RVA: 0x0029DF44 File Offset: 0x0029C144
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x06008FEA RID: 36842 RVA: 0x0029DF54 File Offset: 0x0029C154
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x06008FEB RID: 36843 RVA: 0x0029DF64 File Offset: 0x0029C164
			public void __callDele_EventOnGotoButtonClick(GetPathData obj)
			{
				this.m_owner.__callDele_EventOnGotoButtonClick(obj);
			}

			// Token: 0x06008FEC RID: 36844 RVA: 0x0029DF74 File Offset: 0x0029C174
			public void __clearDele_EventOnGotoButtonClick(GetPathData obj)
			{
				this.m_owner.__clearDele_EventOnGotoButtonClick(obj);
			}

			// Token: 0x06008FED RID: 36845 RVA: 0x0029DF84 File Offset: 0x0029C184
			public void __callDele_EventOnGetButtonClick(OpenServiceMissonUIController obj)
			{
				this.m_owner.__callDele_EventOnGetButtonClick(obj);
			}

			// Token: 0x06008FEE RID: 36846 RVA: 0x0029DF94 File Offset: 0x0029C194
			public void __clearDele_EventOnGetButtonClick(OpenServiceMissonUIController obj)
			{
				this.m_owner.__clearDele_EventOnGetButtonClick(obj);
			}

			// Token: 0x17001DF9 RID: 7673
			// (get) Token: 0x06008FEF RID: 36847 RVA: 0x0029DFA4 File Offset: 0x0029C1A4
			// (set) Token: 0x06008FF0 RID: 36848 RVA: 0x0029DFB4 File Offset: 0x0029C1B4
			public Text m_infoText
			{
				get
				{
					return this.m_owner.m_infoText;
				}
				set
				{
					this.m_owner.m_infoText = value;
				}
			}

			// Token: 0x17001DFA RID: 7674
			// (get) Token: 0x06008FF1 RID: 36849 RVA: 0x0029DFC4 File Offset: 0x0029C1C4
			// (set) Token: 0x06008FF2 RID: 36850 RVA: 0x0029DFD4 File Offset: 0x0029C1D4
			public GameObject m_itemDummy
			{
				get
				{
					return this.m_owner.m_itemDummy;
				}
				set
				{
					this.m_owner.m_itemDummy = value;
				}
			}

			// Token: 0x17001DFB RID: 7675
			// (get) Token: 0x06008FF3 RID: 36851 RVA: 0x0029DFE4 File Offset: 0x0029C1E4
			// (set) Token: 0x06008FF4 RID: 36852 RVA: 0x0029DFF4 File Offset: 0x0029C1F4
			public Image m_progressBar
			{
				get
				{
					return this.m_owner.m_progressBar;
				}
				set
				{
					this.m_owner.m_progressBar = value;
				}
			}

			// Token: 0x17001DFC RID: 7676
			// (get) Token: 0x06008FF5 RID: 36853 RVA: 0x0029E004 File Offset: 0x0029C204
			// (set) Token: 0x06008FF6 RID: 36854 RVA: 0x0029E014 File Offset: 0x0029C214
			public CommonUIStateController m_progressBarValueStateCtrl
			{
				get
				{
					return this.m_owner.m_progressBarValueStateCtrl;
				}
				set
				{
					this.m_owner.m_progressBarValueStateCtrl = value;
				}
			}

			// Token: 0x17001DFD RID: 7677
			// (get) Token: 0x06008FF7 RID: 36855 RVA: 0x0029E024 File Offset: 0x0029C224
			// (set) Token: 0x06008FF8 RID: 36856 RVA: 0x0029E034 File Offset: 0x0029C234
			public Text m_progressHaveCount
			{
				get
				{
					return this.m_owner.m_progressHaveCount;
				}
				set
				{
					this.m_owner.m_progressHaveCount = value;
				}
			}

			// Token: 0x17001DFE RID: 7678
			// (get) Token: 0x06008FF9 RID: 36857 RVA: 0x0029E044 File Offset: 0x0029C244
			// (set) Token: 0x06008FFA RID: 36858 RVA: 0x0029E054 File Offset: 0x0029C254
			public Text m_progressNeedCount
			{
				get
				{
					return this.m_owner.m_progressNeedCount;
				}
				set
				{
					this.m_owner.m_progressNeedCount = value;
				}
			}

			// Token: 0x17001DFF RID: 7679
			// (get) Token: 0x06008FFB RID: 36859 RVA: 0x0029E064 File Offset: 0x0029C264
			// (set) Token: 0x06008FFC RID: 36860 RVA: 0x0029E074 File Offset: 0x0029C274
			public GameObject m_progressDoneText
			{
				get
				{
					return this.m_owner.m_progressDoneText;
				}
				set
				{
					this.m_owner.m_progressDoneText = value;
				}
			}

			// Token: 0x17001E00 RID: 7680
			// (get) Token: 0x06008FFD RID: 36861 RVA: 0x0029E084 File Offset: 0x0029C284
			// (set) Token: 0x06008FFE RID: 36862 RVA: 0x0029E094 File Offset: 0x0029C294
			public CommonUIStateController m_buttonGroupStateCtrl
			{
				get
				{
					return this.m_owner.m_buttonGroupStateCtrl;
				}
				set
				{
					this.m_owner.m_buttonGroupStateCtrl = value;
				}
			}

			// Token: 0x17001E01 RID: 7681
			// (get) Token: 0x06008FFF RID: 36863 RVA: 0x0029E0A4 File Offset: 0x0029C2A4
			// (set) Token: 0x06009000 RID: 36864 RVA: 0x0029E0B4 File Offset: 0x0029C2B4
			public Button m_gotoButton
			{
				get
				{
					return this.m_owner.m_gotoButton;
				}
				set
				{
					this.m_owner.m_gotoButton = value;
				}
			}

			// Token: 0x17001E02 RID: 7682
			// (get) Token: 0x06009001 RID: 36865 RVA: 0x0029E0C4 File Offset: 0x0029C2C4
			// (set) Token: 0x06009002 RID: 36866 RVA: 0x0029E0D4 File Offset: 0x0029C2D4
			public Button m_getButton
			{
				get
				{
					return this.m_owner.m_getButton;
				}
				set
				{
					this.m_owner.m_getButton = value;
				}
			}

			// Token: 0x17001E03 RID: 7683
			// (set) Token: 0x06009003 RID: 36867 RVA: 0x0029E0E4 File Offset: 0x0029C2E4
			public Mission Mission
			{
				set
				{
					this.m_owner.Mission = value;
				}
			}

			// Token: 0x06009004 RID: 36868 RVA: 0x0029E0F4 File Offset: 0x0029C2F4
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x06009005 RID: 36869 RVA: 0x0029E104 File Offset: 0x0029C304
			public void SetOpenServiceMissionInfo()
			{
				this.m_owner.SetOpenServiceMissionInfo();
			}

			// Token: 0x06009006 RID: 36870 RVA: 0x0029E114 File Offset: 0x0029C314
			public void SetOpenServiceMissionState(bool hasGot)
			{
				this.m_owner.SetOpenServiceMissionState(hasGot);
			}

			// Token: 0x06009007 RID: 36871 RVA: 0x0029E124 File Offset: 0x0029C324
			public void OnGotoButtonClick()
			{
				this.m_owner.OnGotoButtonClick();
			}

			// Token: 0x06009008 RID: 36872 RVA: 0x0029E134 File Offset: 0x0029C334
			public void OnGetButtonClick()
			{
				this.m_owner.OnGetButtonClick();
			}

			// Token: 0x04006575 RID: 25973
			private OpenServiceMissonUIController m_owner;
		}
	}
}
