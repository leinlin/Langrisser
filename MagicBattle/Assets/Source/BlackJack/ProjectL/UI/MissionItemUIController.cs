using System;
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
	// Token: 0x02000E7B RID: 3707
	[HotFix]
	public class MissionItemUIController : UIControllerBase
	{
		// Token: 0x0601207A RID: 73850 RVA: 0x004A6950 File Offset: 0x004A4B50
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
			this.m_getButton.onClick.AddListener(new UnityAction(this.OnGetButtonClick));
			base.gameObject.SetActive(true);
			this.playerCtx = (GameManager.Instance.PlayerContext as ProjectLPlayerContext);
		}

		// Token: 0x0601207B RID: 73851 RVA: 0x004A69F0 File Offset: 0x004A4BF0
		public void InitMissionItem(Mission mission, bool isMissionFinished, bool isMissionCompleted)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitMissionItemMissionBooleanBoolean_hotfix != null)
			{
				this.m_InitMissionItemMissionBooleanBoolean_hotfix.call(new object[]
				{
					this,
					mission,
					isMissionFinished,
					isMissionCompleted
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_mission = mission;
			this.m_isMissionFinished = isMissionFinished;
			this.m_isMissionCompleted = isMissionCompleted;
			this.SetMissionInfo();
		}

		// Token: 0x0601207C RID: 73852 RVA: 0x004A6A9C File Offset: 0x004A4C9C
		private void SetMissionInfo()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetMissionInfo_hotfix != null)
			{
				this.m_SetMissionInfo_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_titleText.text = this.m_mission.Config.Title;
			this.m_descText.text = this.m_mission.Config.Desc;
			GameObjectUtility.DestroyChildren(this.m_rewardListGo);
			GameObject assetInContainer = base.GetAssetInContainer<GameObject>("RewardItem");
			RewardGoodsUIController.CreateRewardGoodsList(this.m_mission.Config.Reward, this.m_rewardListGo.transform, assetInContainer, null, true, 0, false);
			int missionMaxProcess = this.playerCtx.GetMissionMaxProcess(this.m_mission);
			if (this.m_isMissionCompleted)
			{
				this.m_countText.text = UIUtility.AddColorTag(this.playerCtx.GetMissionCompleteProcess(this.m_mission) + "/" + missionMaxProcess, UIUtility.MyGreenColor);
			}
			else
			{
				this.m_countText.text = UIUtility.AddColorTag(this.playerCtx.GetMissionCompleteProcess(this.m_mission) + string.Empty, Color.red) + "/" + missionMaxProcess;
			}
			CommonUIStateController component = base.gameObject.GetComponent<CommonUIStateController>();
			if (this.m_isMissionFinished)
			{
				component.SetToUIState("Finished", false, true);
			}
			else if (this.m_isMissionCompleted)
			{
				component.SetToUIState("Get", false, true);
			}
			else
			{
				component.SetToUIState("PorgressBar", false, true);
				this.m_progressImg.fillAmount = (float)this.playerCtx.GetMissionCompleteProcess(this.m_mission) / (float)missionMaxProcess;
			}
			this.m_achievementIconGo.SetActive(this.m_mission.Config.MissionColumn == MissionColumnType.MissionColumnType_Achievements);
		}

		// Token: 0x0601207D RID: 73853 RVA: 0x004A6CA4 File Offset: 0x004A4EA4
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
				this.EventOnGetButtonClick(this.m_mission.MissionId);
			}
		}

		// Token: 0x0601207E RID: 73854 RVA: 0x004A6D28 File Offset: 0x004A4F28
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
			if (this.m_mission.Config.GetPathList.Count == 0)
			{
				global::Debug.LogError("No Path");
				return;
			}
			if (this.EventOnGotoButtonClick != null)
			{
				this.EventOnGotoButtonClick(this.m_mission.Config.GetPathList[0]);
			}
		}

		// Token: 0x140003E1 RID: 993
		// (add) Token: 0x0601207F RID: 73855 RVA: 0x004A6DDC File Offset: 0x004A4FDC
		// (remove) Token: 0x06012080 RID: 73856 RVA: 0x004A6E78 File Offset: 0x004A5078
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

		// Token: 0x140003E2 RID: 994
		// (add) Token: 0x06012081 RID: 73857 RVA: 0x004A6F14 File Offset: 0x004A5114
		// (remove) Token: 0x06012082 RID: 73858 RVA: 0x004A6FB0 File Offset: 0x004A51B0
		public event Action<int> EventOnGetButtonClick
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
				Action<int> action = this.EventOnGetButtonClick;
				Action<int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int>>(ref this.EventOnGetButtonClick, (Action<int>)Delegate.Combine(action2, value), action);
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
				Action<int> action = this.EventOnGetButtonClick;
				Action<int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int>>(ref this.EventOnGetButtonClick, (Action<int>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17003711 RID: 14097
		// (get) Token: 0x06012083 RID: 73859 RVA: 0x004A704C File Offset: 0x004A524C
		// (set) Token: 0x06012084 RID: 73860 RVA: 0x004A706C File Offset: 0x004A526C
		[DoNotToLua]
		public new MissionItemUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new MissionItemUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06012085 RID: 73861 RVA: 0x004A7078 File Offset: 0x004A5278
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x06012086 RID: 73862 RVA: 0x004A7084 File Offset: 0x004A5284
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x06012087 RID: 73863 RVA: 0x004A708C File Offset: 0x004A528C
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x06012088 RID: 73864 RVA: 0x004A7094 File Offset: 0x004A5294
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x06012089 RID: 73865 RVA: 0x004A70A8 File Offset: 0x004A52A8
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0601208A RID: 73866 RVA: 0x004A70B0 File Offset: 0x004A52B0
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0601208B RID: 73867 RVA: 0x004A70BC File Offset: 0x004A52BC
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0601208C RID: 73868 RVA: 0x004A70C8 File Offset: 0x004A52C8
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0601208D RID: 73869 RVA: 0x004A70D4 File Offset: 0x004A52D4
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0601208E RID: 73870 RVA: 0x004A70E0 File Offset: 0x004A52E0
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0601208F RID: 73871 RVA: 0x004A70EC File Offset: 0x004A52EC
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x06012090 RID: 73872 RVA: 0x004A70F8 File Offset: 0x004A52F8
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x06012091 RID: 73873 RVA: 0x004A7104 File Offset: 0x004A5304
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x06012092 RID: 73874 RVA: 0x004A7110 File Offset: 0x004A5310
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x06012093 RID: 73875 RVA: 0x004A711C File Offset: 0x004A531C
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x06012094 RID: 73876 RVA: 0x004A7124 File Offset: 0x004A5324
		private void __callDele_EventOnGotoButtonClick(GetPathData obj)
		{
			Action<GetPathData> eventOnGotoButtonClick = this.EventOnGotoButtonClick;
			if (eventOnGotoButtonClick != null)
			{
				eventOnGotoButtonClick(obj);
			}
		}

		// Token: 0x06012095 RID: 73877 RVA: 0x004A7148 File Offset: 0x004A5348
		private void __clearDele_EventOnGotoButtonClick(GetPathData obj)
		{
			this.EventOnGotoButtonClick = null;
		}

		// Token: 0x06012096 RID: 73878 RVA: 0x004A7154 File Offset: 0x004A5354
		private void __callDele_EventOnGetButtonClick(int obj)
		{
			Action<int> eventOnGetButtonClick = this.EventOnGetButtonClick;
			if (eventOnGetButtonClick != null)
			{
				eventOnGetButtonClick(obj);
			}
		}

		// Token: 0x06012097 RID: 73879 RVA: 0x004A7178 File Offset: 0x004A5378
		private void __clearDele_EventOnGetButtonClick(int obj)
		{
			this.EventOnGetButtonClick = null;
		}

		// Token: 0x06012098 RID: 73880 RVA: 0x004A7184 File Offset: 0x004A5384
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
					this.m_InitMissionItemMissionBooleanBoolean_hotfix = (luaObj.RawGet("InitMissionItem") as LuaFunction);
					this.m_SetMissionInfo_hotfix = (luaObj.RawGet("SetMissionInfo") as LuaFunction);
					this.m_OnGetButtonClick_hotfix = (luaObj.RawGet("OnGetButtonClick") as LuaFunction);
					this.m_OnGotoButtonClick_hotfix = (luaObj.RawGet("OnGotoButtonClick") as LuaFunction);
					this.m_add_EventOnGotoButtonClickAction`1_hotfix = (luaObj.RawGet("add_EventOnGotoButtonClick") as LuaFunction);
					this.m_remove_EventOnGotoButtonClickAction`1_hotfix = (luaObj.RawGet("remove_EventOnGotoButtonClick") as LuaFunction);
					this.m_add_EventOnGetButtonClickAction`1_hotfix = (luaObj.RawGet("add_EventOnGetButtonClick") as LuaFunction);
					this.m_remove_EventOnGetButtonClickAction`1_hotfix = (luaObj.RawGet("remove_EventOnGetButtonClick") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06012099 RID: 73881 RVA: 0x004A7318 File Offset: 0x004A5518
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(MissionItemUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400A34A RID: 41802
		[AutoBind("./IconImage", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_achievementIconGo;

		// Token: 0x0400A34B RID: 41803
		[AutoBind("./Detail/TitleText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_titleText;

		// Token: 0x0400A34C RID: 41804
		[AutoBind("./Detail/DescText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_descText;

		// Token: 0x0400A34D RID: 41805
		[AutoBind("./Detail/CountText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_countText;

		// Token: 0x0400A34E RID: 41806
		[AutoBind("./Detail/GetButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_getButton;

		// Token: 0x0400A34F RID: 41807
		[AutoBind("./Detail/ProgressBar/ProgressImg", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_progressImg;

		// Token: 0x0400A350 RID: 41808
		[AutoBind("./Detail/RewardList", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_rewardListGo;

		// Token: 0x0400A351 RID: 41809
		public Mission m_mission;

		// Token: 0x0400A352 RID: 41810
		private bool m_isMissionFinished;

		// Token: 0x0400A353 RID: 41811
		private bool m_isMissionCompleted;

		// Token: 0x0400A354 RID: 41812
		private ProjectLPlayerContext playerCtx;

		// Token: 0x0400A355 RID: 41813
		[DoNotToLua]
		private MissionItemUIController.LuaExportHelper luaExportHelper;

		// Token: 0x0400A356 RID: 41814
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400A357 RID: 41815
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400A358 RID: 41816
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x0400A359 RID: 41817
		private LuaFunction m_InitMissionItemMissionBooleanBoolean_hotfix;

		// Token: 0x0400A35A RID: 41818
		private LuaFunction m_SetMissionInfo_hotfix;

		// Token: 0x0400A35B RID: 41819
		private LuaFunction m_OnGetButtonClick_hotfix;

		// Token: 0x0400A35C RID: 41820
		private LuaFunction m_OnGotoButtonClick_hotfix;

		// Token: 0x0400A35D RID: 41821
		private LuaFunction m_add_EventOnGotoButtonClickAction;

		// Token: 0x0400A35E RID: 41822
		private LuaFunction m_remove_EventOnGotoButtonClickAction;

		// Token: 0x0400A35F RID: 41823
		private LuaFunction m_add_EventOnGetButtonClickAction;

		// Token: 0x0400A360 RID: 41824
		private LuaFunction m_remove_EventOnGetButtonClickAction;

		// Token: 0x02000E7C RID: 3708
		public new class LuaExportHelper
		{
			// Token: 0x0601209A RID: 73882 RVA: 0x004A7380 File Offset: 0x004A5580
			public LuaExportHelper(MissionItemUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0601209B RID: 73883 RVA: 0x004A7390 File Offset: 0x004A5590
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0601209C RID: 73884 RVA: 0x004A73A0 File Offset: 0x004A55A0
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0601209D RID: 73885 RVA: 0x004A73B0 File Offset: 0x004A55B0
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0601209E RID: 73886 RVA: 0x004A73C0 File Offset: 0x004A55C0
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0601209F RID: 73887 RVA: 0x004A73D8 File Offset: 0x004A55D8
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x060120A0 RID: 73888 RVA: 0x004A73E8 File Offset: 0x004A55E8
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x060120A1 RID: 73889 RVA: 0x004A73F8 File Offset: 0x004A55F8
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x060120A2 RID: 73890 RVA: 0x004A7408 File Offset: 0x004A5608
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x060120A3 RID: 73891 RVA: 0x004A7418 File Offset: 0x004A5618
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x060120A4 RID: 73892 RVA: 0x004A7428 File Offset: 0x004A5628
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x060120A5 RID: 73893 RVA: 0x004A7438 File Offset: 0x004A5638
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x060120A6 RID: 73894 RVA: 0x004A7448 File Offset: 0x004A5648
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x060120A7 RID: 73895 RVA: 0x004A7458 File Offset: 0x004A5658
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x060120A8 RID: 73896 RVA: 0x004A7468 File Offset: 0x004A5668
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x060120A9 RID: 73897 RVA: 0x004A7478 File Offset: 0x004A5678
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x060120AA RID: 73898 RVA: 0x004A7488 File Offset: 0x004A5688
			public void __callDele_EventOnGotoButtonClick(GetPathData obj)
			{
				this.m_owner.__callDele_EventOnGotoButtonClick(obj);
			}

			// Token: 0x060120AB RID: 73899 RVA: 0x004A7498 File Offset: 0x004A5698
			public void __clearDele_EventOnGotoButtonClick(GetPathData obj)
			{
				this.m_owner.__clearDele_EventOnGotoButtonClick(obj);
			}

			// Token: 0x060120AC RID: 73900 RVA: 0x004A74A8 File Offset: 0x004A56A8
			public void __callDele_EventOnGetButtonClick(int obj)
			{
				this.m_owner.__callDele_EventOnGetButtonClick(obj);
			}

			// Token: 0x060120AD RID: 73901 RVA: 0x004A74B8 File Offset: 0x004A56B8
			public void __clearDele_EventOnGetButtonClick(int obj)
			{
				this.m_owner.__clearDele_EventOnGetButtonClick(obj);
			}

			// Token: 0x17003712 RID: 14098
			// (get) Token: 0x060120AE RID: 73902 RVA: 0x004A74C8 File Offset: 0x004A56C8
			// (set) Token: 0x060120AF RID: 73903 RVA: 0x004A74D8 File Offset: 0x004A56D8
			public GameObject m_achievementIconGo
			{
				get
				{
					return this.m_owner.m_achievementIconGo;
				}
				set
				{
					this.m_owner.m_achievementIconGo = value;
				}
			}

			// Token: 0x17003713 RID: 14099
			// (get) Token: 0x060120B0 RID: 73904 RVA: 0x004A74E8 File Offset: 0x004A56E8
			// (set) Token: 0x060120B1 RID: 73905 RVA: 0x004A74F8 File Offset: 0x004A56F8
			public Text m_titleText
			{
				get
				{
					return this.m_owner.m_titleText;
				}
				set
				{
					this.m_owner.m_titleText = value;
				}
			}

			// Token: 0x17003714 RID: 14100
			// (get) Token: 0x060120B2 RID: 73906 RVA: 0x004A7508 File Offset: 0x004A5708
			// (set) Token: 0x060120B3 RID: 73907 RVA: 0x004A7518 File Offset: 0x004A5718
			public Text m_descText
			{
				get
				{
					return this.m_owner.m_descText;
				}
				set
				{
					this.m_owner.m_descText = value;
				}
			}

			// Token: 0x17003715 RID: 14101
			// (get) Token: 0x060120B4 RID: 73908 RVA: 0x004A7528 File Offset: 0x004A5728
			// (set) Token: 0x060120B5 RID: 73909 RVA: 0x004A7538 File Offset: 0x004A5738
			public Text m_countText
			{
				get
				{
					return this.m_owner.m_countText;
				}
				set
				{
					this.m_owner.m_countText = value;
				}
			}

			// Token: 0x17003716 RID: 14102
			// (get) Token: 0x060120B6 RID: 73910 RVA: 0x004A7548 File Offset: 0x004A5748
			// (set) Token: 0x060120B7 RID: 73911 RVA: 0x004A7558 File Offset: 0x004A5758
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

			// Token: 0x17003717 RID: 14103
			// (get) Token: 0x060120B8 RID: 73912 RVA: 0x004A7568 File Offset: 0x004A5768
			// (set) Token: 0x060120B9 RID: 73913 RVA: 0x004A7578 File Offset: 0x004A5778
			public Image m_progressImg
			{
				get
				{
					return this.m_owner.m_progressImg;
				}
				set
				{
					this.m_owner.m_progressImg = value;
				}
			}

			// Token: 0x17003718 RID: 14104
			// (get) Token: 0x060120BA RID: 73914 RVA: 0x004A7588 File Offset: 0x004A5788
			// (set) Token: 0x060120BB RID: 73915 RVA: 0x004A7598 File Offset: 0x004A5798
			public GameObject m_rewardListGo
			{
				get
				{
					return this.m_owner.m_rewardListGo;
				}
				set
				{
					this.m_owner.m_rewardListGo = value;
				}
			}

			// Token: 0x17003719 RID: 14105
			// (get) Token: 0x060120BC RID: 73916 RVA: 0x004A75A8 File Offset: 0x004A57A8
			// (set) Token: 0x060120BD RID: 73917 RVA: 0x004A75B8 File Offset: 0x004A57B8
			public bool m_isMissionFinished
			{
				get
				{
					return this.m_owner.m_isMissionFinished;
				}
				set
				{
					this.m_owner.m_isMissionFinished = value;
				}
			}

			// Token: 0x1700371A RID: 14106
			// (get) Token: 0x060120BE RID: 73918 RVA: 0x004A75C8 File Offset: 0x004A57C8
			// (set) Token: 0x060120BF RID: 73919 RVA: 0x004A75D8 File Offset: 0x004A57D8
			public bool m_isMissionCompleted
			{
				get
				{
					return this.m_owner.m_isMissionCompleted;
				}
				set
				{
					this.m_owner.m_isMissionCompleted = value;
				}
			}

			// Token: 0x1700371B RID: 14107
			// (get) Token: 0x060120C0 RID: 73920 RVA: 0x004A75E8 File Offset: 0x004A57E8
			// (set) Token: 0x060120C1 RID: 73921 RVA: 0x004A75F8 File Offset: 0x004A57F8
			public ProjectLPlayerContext playerCtx
			{
				get
				{
					return this.m_owner.playerCtx;
				}
				set
				{
					this.m_owner.playerCtx = value;
				}
			}

			// Token: 0x060120C2 RID: 73922 RVA: 0x004A7608 File Offset: 0x004A5808
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x060120C3 RID: 73923 RVA: 0x004A7618 File Offset: 0x004A5818
			public void SetMissionInfo()
			{
				this.m_owner.SetMissionInfo();
			}

			// Token: 0x060120C4 RID: 73924 RVA: 0x004A7628 File Offset: 0x004A5828
			public void OnGetButtonClick()
			{
				this.m_owner.OnGetButtonClick();
			}

			// Token: 0x060120C5 RID: 73925 RVA: 0x004A7638 File Offset: 0x004A5838
			public void OnGotoButtonClick()
			{
				this.m_owner.OnGotoButtonClick();
			}

			// Token: 0x0400A361 RID: 41825
			private MissionItemUIController m_owner;
		}
	}
}
