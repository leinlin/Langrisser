using System;
using System.Threading;
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
	// Token: 0x02000EE0 RID: 3808
	[HotFix]
	public class RiftLevelButton : UIControllerBase
	{
		// Token: 0x06012BF2 RID: 76786 RVA: 0x004CC0C8 File Offset: 0x004CA2C8
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
			this.m_button.onClick.AddListener(new UnityAction(this.OnClick));
		}

		// Token: 0x06012BF3 RID: 76787 RVA: 0x004CC14C File Offset: 0x004CA34C
		public void SetRiftLevelInfo(ConfigDataRiftLevelInfo riftLevelInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetRiftLevelInfoConfigDataRiftLevelInfo_hotfix != null)
			{
				this.m_SetRiftLevelInfoConfigDataRiftLevelInfo_hotfix.call(new object[]
				{
					this,
					riftLevelInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (riftLevelInfo == null)
			{
				return;
			}
			this.m_riftLevelInfo = riftLevelInfo;
			this.m_nameNumText.text = riftLevelInfo.NameNum;
			Image image = this.m_image;
			Sprite sprite = AssetUtility.Instance.GetSprite(riftLevelInfo.Icon);
			this.m_image1.sprite = sprite;
			image.sprite = sprite;
		}

		// Token: 0x06012BF4 RID: 76788 RVA: 0x004CC204 File Offset: 0x004CA404
		public ConfigDataRiftLevelInfo GetRiftLevel()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetRiftLevel_hotfix != null)
			{
				return (ConfigDataRiftLevelInfo)this.m_GetRiftLevel_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_riftLevelInfo;
		}

		// Token: 0x06012BF5 RID: 76789 RVA: 0x004CC278 File Offset: 0x004CA478
		public void SetStatus(RiftLevelStatus status, bool isNew, bool isClear, bool isAllTreasureGot)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetStatusRiftLevelStatusBooleanBooleanBoolean_hotfix != null)
			{
				this.m_SetStatusRiftLevelStatusBooleanBooleanBoolean_hotfix.call(new object[]
				{
					this,
					status,
					isNew,
					isClear,
					isAllTreasureGot
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (isNew)
			{
				this.m_uiStateController.SetToUIState("New", false, true);
			}
			else if (isClear)
			{
				if (isAllTreasureGot)
				{
					this.m_uiStateController.SetToUIState("Perfect", false, true);
				}
				else
				{
					this.m_uiStateController.SetToUIState("Clear", false, true);
				}
			}
			else if (status == RiftLevelStatus.Close)
			{
				this.m_uiStateController.SetToUIState("Condition", false, true);
			}
			else if (status == RiftLevelStatus.CloseLock)
			{
				this.m_uiStateController.SetToUIState("NotOpen", false, true);
			}
			else if (status == RiftLevelStatus.Lock)
			{
				this.m_uiStateController.SetToUIState("Locked", false, true);
			}
			else
			{
				this.m_uiStateController.SetToUIState("Played", false, true);
			}
			this.m_challengeCountText.gameObject.SetActive(status == RiftLevelStatus.Open);
			this.m_status = status;
		}

		// Token: 0x06012BF6 RID: 76790 RVA: 0x004CC3F8 File Offset: 0x004CA5F8
		public RiftLevelStatus GetStatus()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetStatus_hotfix != null)
			{
				return (RiftLevelStatus)this.m_GetStatus_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_status;
		}

		// Token: 0x06012BF7 RID: 76791 RVA: 0x004CC46C File Offset: 0x004CA66C
		public void SetStar(int star)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetStarInt32_hotfix != null)
			{
				this.m_SetStarInt32_hotfix.call(new object[]
				{
					this,
					star
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_star1GameObject.SetActive(star >= 1);
			this.m_star2GameObject.SetActive(star >= 2);
			this.m_star3GameObject.SetActive(star >= 3);
		}

		// Token: 0x06012BF8 RID: 76792 RVA: 0x004CC514 File Offset: 0x004CA714
		public void SetChallengeCount(int count, int countMax)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetChallengeCountInt32Int32_hotfix != null)
			{
				this.m_SetChallengeCountInt32Int32_hotfix.call(new object[]
				{
					this,
					count,
					countMax
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_challengeCountText.text = string.Concat(new object[]
			{
				this.m_riftLevelInfo.Name,
				" ",
				count,
				"/",
				countMax
			});
			this.m_challengeCountText.gameObject.SetActive(LocalConfig.Instance.Data.IsDeveloper);
		}

		// Token: 0x06012BF9 RID: 76793 RVA: 0x004CC5FC File Offset: 0x004CA7FC
		public void SetAchievementCount(int count, int countMax)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetAchievementCountInt32Int32_hotfix != null)
			{
				this.m_SetAchievementCountInt32Int32_hotfix.call(new object[]
				{
					this,
					count,
					countMax
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_achievementCountText.text = count + "/" + countMax;
		}

		// Token: 0x06012BFA RID: 76794 RVA: 0x004CC6A0 File Offset: 0x004CA8A0
		private void OnClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnClick_hotfix != null)
			{
				this.m_OnClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnClick != null)
			{
				this.EventOnClick(this);
			}
		}

		// Token: 0x14000412 RID: 1042
		// (add) Token: 0x06012BFB RID: 76795 RVA: 0x004CC718 File Offset: 0x004CA918
		// (remove) Token: 0x06012BFC RID: 76796 RVA: 0x004CC7B4 File Offset: 0x004CA9B4
		public event Action<RiftLevelButton> EventOnClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnClickAction`1_hotfix != null)
				{
					this.m_add_EventOnClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<RiftLevelButton> action = this.EventOnClick;
				Action<RiftLevelButton> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<RiftLevelButton>>(ref this.EventOnClick, (Action<RiftLevelButton>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnClickAction`1_hotfix != null)
				{
					this.m_remove_EventOnClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<RiftLevelButton> action = this.EventOnClick;
				Action<RiftLevelButton> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<RiftLevelButton>>(ref this.EventOnClick, (Action<RiftLevelButton>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17003896 RID: 14486
		// (get) Token: 0x06012BFD RID: 76797 RVA: 0x004CC850 File Offset: 0x004CAA50
		// (set) Token: 0x06012BFE RID: 76798 RVA: 0x004CC870 File Offset: 0x004CAA70
		[DoNotToLua]
		public new RiftLevelButton.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new RiftLevelButton.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06012BFF RID: 76799 RVA: 0x004CC87C File Offset: 0x004CAA7C
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x06012C00 RID: 76800 RVA: 0x004CC888 File Offset: 0x004CAA88
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x06012C01 RID: 76801 RVA: 0x004CC890 File Offset: 0x004CAA90
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x06012C02 RID: 76802 RVA: 0x004CC898 File Offset: 0x004CAA98
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x06012C03 RID: 76803 RVA: 0x004CC8AC File Offset: 0x004CAAAC
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x06012C04 RID: 76804 RVA: 0x004CC8B4 File Offset: 0x004CAAB4
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x06012C05 RID: 76805 RVA: 0x004CC8C0 File Offset: 0x004CAAC0
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x06012C06 RID: 76806 RVA: 0x004CC8CC File Offset: 0x004CAACC
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x06012C07 RID: 76807 RVA: 0x004CC8D8 File Offset: 0x004CAAD8
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x06012C08 RID: 76808 RVA: 0x004CC8E4 File Offset: 0x004CAAE4
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x06012C09 RID: 76809 RVA: 0x004CC8F0 File Offset: 0x004CAAF0
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x06012C0A RID: 76810 RVA: 0x004CC8FC File Offset: 0x004CAAFC
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x06012C0B RID: 76811 RVA: 0x004CC908 File Offset: 0x004CAB08
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x06012C0C RID: 76812 RVA: 0x004CC914 File Offset: 0x004CAB14
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x06012C0D RID: 76813 RVA: 0x004CC920 File Offset: 0x004CAB20
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x06012C0E RID: 76814 RVA: 0x004CC928 File Offset: 0x004CAB28
		private void __callDele_EventOnClick(RiftLevelButton obj)
		{
			Action<RiftLevelButton> eventOnClick = this.EventOnClick;
			if (eventOnClick != null)
			{
				eventOnClick(obj);
			}
		}

		// Token: 0x06012C0F RID: 76815 RVA: 0x004CC94C File Offset: 0x004CAB4C
		private void __clearDele_EventOnClick(RiftLevelButton obj)
		{
			this.EventOnClick = null;
		}

		// Token: 0x06012C10 RID: 76816 RVA: 0x004CC958 File Offset: 0x004CAB58
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
					this.m_SetRiftLevelInfoConfigDataRiftLevelInfo_hotfix = (luaObj.RawGet("SetRiftLevelInfo") as LuaFunction);
					this.m_GetRiftLevel_hotfix = (luaObj.RawGet("GetRiftLevel") as LuaFunction);
					this.m_SetStatusRiftLevelStatusBooleanBooleanBoolean_hotfix = (luaObj.RawGet("SetStatus") as LuaFunction);
					this.m_GetStatus_hotfix = (luaObj.RawGet("GetStatus") as LuaFunction);
					this.m_SetStarInt32_hotfix = (luaObj.RawGet("SetStar") as LuaFunction);
					this.m_SetChallengeCountInt32Int32_hotfix = (luaObj.RawGet("SetChallengeCount") as LuaFunction);
					this.m_SetAchievementCountInt32Int32_hotfix = (luaObj.RawGet("SetAchievementCount") as LuaFunction);
					this.m_OnClick_hotfix = (luaObj.RawGet("OnClick") as LuaFunction);
					this.m_add_EventOnClickAction`1_hotfix = (luaObj.RawGet("add_EventOnClick") as LuaFunction);
					this.m_remove_EventOnClickAction`1_hotfix = (luaObj.RawGet("remove_EventOnClick") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06012C11 RID: 76817 RVA: 0x004CCB20 File Offset: 0x004CAD20
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(RiftLevelButton));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400A7E5 RID: 42981
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_button;

		// Token: 0x0400A7E6 RID: 42982
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_uiStateController;

		// Token: 0x0400A7E7 RID: 42983
		[AutoBind("./NameNum/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_nameNumText;

		// Token: 0x0400A7E8 RID: 42984
		[AutoBind("./ChallengeCountText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_challengeCountText;

		// Token: 0x0400A7E9 RID: 42985
		[AutoBind("./StarsandCup/Star1/Star", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_star1GameObject;

		// Token: 0x0400A7EA RID: 42986
		[AutoBind("./StarsandCup/Star2/Star", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_star2GameObject;

		// Token: 0x0400A7EB RID: 42987
		[AutoBind("./StarsandCup/Star3/Star", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_star3GameObject;

		// Token: 0x0400A7EC RID: 42988
		[AutoBind("./StarsandCup/Cup/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_achievementCountText;

		// Token: 0x0400A7ED RID: 42989
		[AutoBind("./StoryImage", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_image;

		// Token: 0x0400A7EE RID: 42990
		[AutoBind("./StoryNormalImage", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_image1;

		// Token: 0x0400A7EF RID: 42991
		private ConfigDataRiftLevelInfo m_riftLevelInfo;

		// Token: 0x0400A7F0 RID: 42992
		private RiftLevelStatus m_status;

		// Token: 0x0400A7F1 RID: 42993
		[DoNotToLua]
		private RiftLevelButton.LuaExportHelper luaExportHelper;

		// Token: 0x0400A7F2 RID: 42994
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400A7F3 RID: 42995
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400A7F4 RID: 42996
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x0400A7F5 RID: 42997
		private LuaFunction m_SetRiftLevelInfoConfigDataRiftLevelInfo_hotfix;

		// Token: 0x0400A7F6 RID: 42998
		private LuaFunction m_GetRiftLevel_hotfix;

		// Token: 0x0400A7F7 RID: 42999
		private LuaFunction m_SetStatusRiftLevelStatusBooleanBooleanBoolean_hotfix;

		// Token: 0x0400A7F8 RID: 43000
		private LuaFunction m_GetStatus_hotfix;

		// Token: 0x0400A7F9 RID: 43001
		private LuaFunction m_SetStarInt32_hotfix;

		// Token: 0x0400A7FA RID: 43002
		private LuaFunction m_SetChallengeCountInt32Int32_hotfix;

		// Token: 0x0400A7FB RID: 43003
		private LuaFunction m_SetAchievementCountInt32Int32_hotfix;

		// Token: 0x0400A7FC RID: 43004
		private LuaFunction m_OnClick_hotfix;

		// Token: 0x0400A7FD RID: 43005
		private LuaFunction m_add_EventOnClickAction;

		// Token: 0x0400A7FE RID: 43006
		private LuaFunction m_remove_EventOnClickAction;

		// Token: 0x02000EE1 RID: 3809
		public new class LuaExportHelper
		{
			// Token: 0x06012C12 RID: 76818 RVA: 0x004CCB88 File Offset: 0x004CAD88
			public LuaExportHelper(RiftLevelButton owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06012C13 RID: 76819 RVA: 0x004CCB98 File Offset: 0x004CAD98
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x06012C14 RID: 76820 RVA: 0x004CCBA8 File Offset: 0x004CADA8
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x06012C15 RID: 76821 RVA: 0x004CCBB8 File Offset: 0x004CADB8
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x06012C16 RID: 76822 RVA: 0x004CCBC8 File Offset: 0x004CADC8
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x06012C17 RID: 76823 RVA: 0x004CCBE0 File Offset: 0x004CADE0
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x06012C18 RID: 76824 RVA: 0x004CCBF0 File Offset: 0x004CADF0
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x06012C19 RID: 76825 RVA: 0x004CCC00 File Offset: 0x004CAE00
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x06012C1A RID: 76826 RVA: 0x004CCC10 File Offset: 0x004CAE10
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x06012C1B RID: 76827 RVA: 0x004CCC20 File Offset: 0x004CAE20
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x06012C1C RID: 76828 RVA: 0x004CCC30 File Offset: 0x004CAE30
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x06012C1D RID: 76829 RVA: 0x004CCC40 File Offset: 0x004CAE40
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x06012C1E RID: 76830 RVA: 0x004CCC50 File Offset: 0x004CAE50
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x06012C1F RID: 76831 RVA: 0x004CCC60 File Offset: 0x004CAE60
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x06012C20 RID: 76832 RVA: 0x004CCC70 File Offset: 0x004CAE70
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x06012C21 RID: 76833 RVA: 0x004CCC80 File Offset: 0x004CAE80
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x06012C22 RID: 76834 RVA: 0x004CCC90 File Offset: 0x004CAE90
			public void __callDele_EventOnClick(RiftLevelButton obj)
			{
				this.m_owner.__callDele_EventOnClick(obj);
			}

			// Token: 0x06012C23 RID: 76835 RVA: 0x004CCCA0 File Offset: 0x004CAEA0
			public void __clearDele_EventOnClick(RiftLevelButton obj)
			{
				this.m_owner.__clearDele_EventOnClick(obj);
			}

			// Token: 0x17003897 RID: 14487
			// (get) Token: 0x06012C24 RID: 76836 RVA: 0x004CCCB0 File Offset: 0x004CAEB0
			// (set) Token: 0x06012C25 RID: 76837 RVA: 0x004CCCC0 File Offset: 0x004CAEC0
			public Button m_button
			{
				get
				{
					return this.m_owner.m_button;
				}
				set
				{
					this.m_owner.m_button = value;
				}
			}

			// Token: 0x17003898 RID: 14488
			// (get) Token: 0x06012C26 RID: 76838 RVA: 0x004CCCD0 File Offset: 0x004CAED0
			// (set) Token: 0x06012C27 RID: 76839 RVA: 0x004CCCE0 File Offset: 0x004CAEE0
			public CommonUIStateController m_uiStateController
			{
				get
				{
					return this.m_owner.m_uiStateController;
				}
				set
				{
					this.m_owner.m_uiStateController = value;
				}
			}

			// Token: 0x17003899 RID: 14489
			// (get) Token: 0x06012C28 RID: 76840 RVA: 0x004CCCF0 File Offset: 0x004CAEF0
			// (set) Token: 0x06012C29 RID: 76841 RVA: 0x004CCD00 File Offset: 0x004CAF00
			public Text m_nameNumText
			{
				get
				{
					return this.m_owner.m_nameNumText;
				}
				set
				{
					this.m_owner.m_nameNumText = value;
				}
			}

			// Token: 0x1700389A RID: 14490
			// (get) Token: 0x06012C2A RID: 76842 RVA: 0x004CCD10 File Offset: 0x004CAF10
			// (set) Token: 0x06012C2B RID: 76843 RVA: 0x004CCD20 File Offset: 0x004CAF20
			public Text m_challengeCountText
			{
				get
				{
					return this.m_owner.m_challengeCountText;
				}
				set
				{
					this.m_owner.m_challengeCountText = value;
				}
			}

			// Token: 0x1700389B RID: 14491
			// (get) Token: 0x06012C2C RID: 76844 RVA: 0x004CCD30 File Offset: 0x004CAF30
			// (set) Token: 0x06012C2D RID: 76845 RVA: 0x004CCD40 File Offset: 0x004CAF40
			public GameObject m_star1GameObject
			{
				get
				{
					return this.m_owner.m_star1GameObject;
				}
				set
				{
					this.m_owner.m_star1GameObject = value;
				}
			}

			// Token: 0x1700389C RID: 14492
			// (get) Token: 0x06012C2E RID: 76846 RVA: 0x004CCD50 File Offset: 0x004CAF50
			// (set) Token: 0x06012C2F RID: 76847 RVA: 0x004CCD60 File Offset: 0x004CAF60
			public GameObject m_star2GameObject
			{
				get
				{
					return this.m_owner.m_star2GameObject;
				}
				set
				{
					this.m_owner.m_star2GameObject = value;
				}
			}

			// Token: 0x1700389D RID: 14493
			// (get) Token: 0x06012C30 RID: 76848 RVA: 0x004CCD70 File Offset: 0x004CAF70
			// (set) Token: 0x06012C31 RID: 76849 RVA: 0x004CCD80 File Offset: 0x004CAF80
			public GameObject m_star3GameObject
			{
				get
				{
					return this.m_owner.m_star3GameObject;
				}
				set
				{
					this.m_owner.m_star3GameObject = value;
				}
			}

			// Token: 0x1700389E RID: 14494
			// (get) Token: 0x06012C32 RID: 76850 RVA: 0x004CCD90 File Offset: 0x004CAF90
			// (set) Token: 0x06012C33 RID: 76851 RVA: 0x004CCDA0 File Offset: 0x004CAFA0
			public Text m_achievementCountText
			{
				get
				{
					return this.m_owner.m_achievementCountText;
				}
				set
				{
					this.m_owner.m_achievementCountText = value;
				}
			}

			// Token: 0x1700389F RID: 14495
			// (get) Token: 0x06012C34 RID: 76852 RVA: 0x004CCDB0 File Offset: 0x004CAFB0
			// (set) Token: 0x06012C35 RID: 76853 RVA: 0x004CCDC0 File Offset: 0x004CAFC0
			public Image m_image
			{
				get
				{
					return this.m_owner.m_image;
				}
				set
				{
					this.m_owner.m_image = value;
				}
			}

			// Token: 0x170038A0 RID: 14496
			// (get) Token: 0x06012C36 RID: 76854 RVA: 0x004CCDD0 File Offset: 0x004CAFD0
			// (set) Token: 0x06012C37 RID: 76855 RVA: 0x004CCDE0 File Offset: 0x004CAFE0
			public Image m_image1
			{
				get
				{
					return this.m_owner.m_image1;
				}
				set
				{
					this.m_owner.m_image1 = value;
				}
			}

			// Token: 0x170038A1 RID: 14497
			// (get) Token: 0x06012C38 RID: 76856 RVA: 0x004CCDF0 File Offset: 0x004CAFF0
			// (set) Token: 0x06012C39 RID: 76857 RVA: 0x004CCE00 File Offset: 0x004CB000
			public ConfigDataRiftLevelInfo m_riftLevelInfo
			{
				get
				{
					return this.m_owner.m_riftLevelInfo;
				}
				set
				{
					this.m_owner.m_riftLevelInfo = value;
				}
			}

			// Token: 0x170038A2 RID: 14498
			// (get) Token: 0x06012C3A RID: 76858 RVA: 0x004CCE10 File Offset: 0x004CB010
			// (set) Token: 0x06012C3B RID: 76859 RVA: 0x004CCE20 File Offset: 0x004CB020
			public RiftLevelStatus m_status
			{
				get
				{
					return this.m_owner.m_status;
				}
				set
				{
					this.m_owner.m_status = value;
				}
			}

			// Token: 0x06012C3C RID: 76860 RVA: 0x004CCE30 File Offset: 0x004CB030
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x06012C3D RID: 76861 RVA: 0x004CCE40 File Offset: 0x004CB040
			public void OnClick()
			{
				this.m_owner.OnClick();
			}

			// Token: 0x0400A7FF RID: 43007
			private RiftLevelButton m_owner;
		}
	}
}
