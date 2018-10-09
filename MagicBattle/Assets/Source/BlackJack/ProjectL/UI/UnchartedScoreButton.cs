using System;
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
	// Token: 0x02000FE9 RID: 4073
	[HotFix]
	public class UnchartedScoreButton : UIControllerBase
	{
		// Token: 0x060146F8 RID: 83704 RVA: 0x00531310 File Offset: 0x0052F510
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
			this.m_button.onClick.AddListener(new UnityAction(this.OnButtonClick));
		}

		// Token: 0x060146F9 RID: 83705 RVA: 0x00531394 File Offset: 0x0052F594
		public void SetUnchartedScoreInfo(ConfigDataUnchartedScoreInfo unchartedScoreInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetUnchartedScoreInfoConfigDataUnchartedScoreInfo_hotfix != null)
			{
				this.m_SetUnchartedScoreInfoConfigDataUnchartedScoreInfo_hotfix.call(new object[]
				{
					this,
					unchartedScoreInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_unchartedScoreInfo = unchartedScoreInfo;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			bool flag = projectLPlayerContext.IsUnchartedScoreOpened(unchartedScoreInfo.ID);
			this.m_uiStateController.SetToUIState((!flag) ? "Grey" : "Normal", false, true);
			Image image = this.m_image;
			Sprite sprite = AssetUtility.Instance.GetSprite(unchartedScoreInfo.PageImage);
			this.m_imageGrey.sprite = sprite;
			image.sprite = sprite;
			DateTime dateTime;
			DateTime dateTime2;
			projectLPlayerContext.GetUnchartedScoreOpenTime(unchartedScoreInfo.ID, out dateTime, out dateTime2);
			Text timeText = this.m_timeText;
			string text = string.Format(configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Uncharted_LimitTime), new object[]
			{
				dateTime.Month,
				dateTime.Day,
				dateTime.Hour,
				dateTime.Minute,
				dateTime2.Month,
				dateTime2.Day,
				dateTime2.Hour,
				dateTime2.Minute
			});
			this.m_timeGreyText.text = text;
			timeText.text = text;
			int unchartedScoreDailyRewardRestCount = projectLPlayerContext.GetUnchartedScoreDailyRewardRestCount(unchartedScoreInfo.ID);
			int scoreLevelBonusCount = unchartedScoreInfo.ScoreLevelBonusCount;
			UIUtility.SetDailyRewardCount(this.m_numberText, unchartedScoreDailyRewardRestCount, scoreLevelBonusCount);
		}

		// Token: 0x060146FA RID: 83706 RVA: 0x00531564 File Offset: 0x0052F764
		public ConfigDataUnchartedScoreInfo GetUnchartedScoreInfo()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetUnchartedScoreInfo_hotfix != null)
			{
				return (ConfigDataUnchartedScoreInfo)this.m_GetUnchartedScoreInfo_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_unchartedScoreInfo;
		}

		// Token: 0x060146FB RID: 83707 RVA: 0x005315D8 File Offset: 0x0052F7D8
		private void OnButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnButtonClick_hotfix != null)
			{
				this.m_OnButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (UIUtility.GetUIStateCurrentStateName(this.m_uiStateController) == "Normal")
			{
				if (this.EventOnStartUnchartedScore != null)
				{
					this.EventOnStartUnchartedScore(this);
				}
			}
			else
			{
				CommonUIController.Instance.ShowMessage(StringTableId.StringTableId_Uncharted_NotOpenTime, 2f, null, true);
			}
		}

		// Token: 0x14000480 RID: 1152
		// (add) Token: 0x060146FC RID: 83708 RVA: 0x00531684 File Offset: 0x0052F884
		// (remove) Token: 0x060146FD RID: 83709 RVA: 0x00531720 File Offset: 0x0052F920
		public event Action<UnchartedScoreButton> EventOnStartUnchartedScore
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnStartUnchartedScoreAction`1_hotfix != null)
				{
					this.m_add_EventOnStartUnchartedScoreAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<UnchartedScoreButton> action = this.EventOnStartUnchartedScore;
				Action<UnchartedScoreButton> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<UnchartedScoreButton>>(ref this.EventOnStartUnchartedScore, (Action<UnchartedScoreButton>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnStartUnchartedScoreAction`1_hotfix != null)
				{
					this.m_remove_EventOnStartUnchartedScoreAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<UnchartedScoreButton> action = this.EventOnStartUnchartedScore;
				Action<UnchartedScoreButton> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<UnchartedScoreButton>>(ref this.EventOnStartUnchartedScore, (Action<UnchartedScoreButton>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17003C9B RID: 15515
		// (get) Token: 0x060146FE RID: 83710 RVA: 0x005317BC File Offset: 0x0052F9BC
		// (set) Token: 0x060146FF RID: 83711 RVA: 0x005317DC File Offset: 0x0052F9DC
		[DoNotToLua]
		public new UnchartedScoreButton.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new UnchartedScoreButton.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06014700 RID: 83712 RVA: 0x005317E8 File Offset: 0x0052F9E8
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x06014701 RID: 83713 RVA: 0x005317F4 File Offset: 0x0052F9F4
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x06014702 RID: 83714 RVA: 0x005317FC File Offset: 0x0052F9FC
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x06014703 RID: 83715 RVA: 0x00531804 File Offset: 0x0052FA04
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x06014704 RID: 83716 RVA: 0x00531818 File Offset: 0x0052FA18
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x06014705 RID: 83717 RVA: 0x00531820 File Offset: 0x0052FA20
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x06014706 RID: 83718 RVA: 0x0053182C File Offset: 0x0052FA2C
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x06014707 RID: 83719 RVA: 0x00531838 File Offset: 0x0052FA38
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x06014708 RID: 83720 RVA: 0x00531844 File Offset: 0x0052FA44
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x06014709 RID: 83721 RVA: 0x00531850 File Offset: 0x0052FA50
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0601470A RID: 83722 RVA: 0x0053185C File Offset: 0x0052FA5C
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0601470B RID: 83723 RVA: 0x00531868 File Offset: 0x0052FA68
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0601470C RID: 83724 RVA: 0x00531874 File Offset: 0x0052FA74
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0601470D RID: 83725 RVA: 0x00531880 File Offset: 0x0052FA80
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0601470E RID: 83726 RVA: 0x0053188C File Offset: 0x0052FA8C
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0601470F RID: 83727 RVA: 0x00531894 File Offset: 0x0052FA94
		private void __callDele_EventOnStartUnchartedScore(UnchartedScoreButton obj)
		{
			Action<UnchartedScoreButton> eventOnStartUnchartedScore = this.EventOnStartUnchartedScore;
			if (eventOnStartUnchartedScore != null)
			{
				eventOnStartUnchartedScore(obj);
			}
		}

		// Token: 0x06014710 RID: 83728 RVA: 0x005318B8 File Offset: 0x0052FAB8
		private void __clearDele_EventOnStartUnchartedScore(UnchartedScoreButton obj)
		{
			this.EventOnStartUnchartedScore = null;
		}

		// Token: 0x06014711 RID: 83729 RVA: 0x005318C4 File Offset: 0x0052FAC4
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
					this.m_SetUnchartedScoreInfoConfigDataUnchartedScoreInfo_hotfix = (luaObj.RawGet("SetUnchartedScoreInfo") as LuaFunction);
					this.m_GetUnchartedScoreInfo_hotfix = (luaObj.RawGet("GetUnchartedScoreInfo") as LuaFunction);
					this.m_OnButtonClick_hotfix = (luaObj.RawGet("OnButtonClick") as LuaFunction);
					this.m_add_EventOnStartUnchartedScoreAction`1_hotfix = (luaObj.RawGet("add_EventOnStartUnchartedScore") as LuaFunction);
					this.m_remove_EventOnStartUnchartedScoreAction`1_hotfix = (luaObj.RawGet("remove_EventOnStartUnchartedScore") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06014712 RID: 83730 RVA: 0x00531A0C File Offset: 0x0052FC0C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(UnchartedScoreButton));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400B401 RID: 46081
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_button;

		// Token: 0x0400B402 RID: 46082
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_uiStateController;

		// Token: 0x0400B403 RID: 46083
		[AutoBind("./BGImage", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_image;

		// Token: 0x0400B404 RID: 46084
		[AutoBind("./BGImageGrey", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_imageGrey;

		// Token: 0x0400B405 RID: 46085
		[AutoBind("./InfoTextGroup/TimeText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_timeText;

		// Token: 0x0400B406 RID: 46086
		[AutoBind("./InfoTextGroup/TimeTextGrey", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_timeGreyText;

		// Token: 0x0400B407 RID: 46087
		[AutoBind("./InfoTextGroup/NumberText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_numberText;

		// Token: 0x0400B409 RID: 46089
		private ConfigDataUnchartedScoreInfo m_unchartedScoreInfo;

		// Token: 0x0400B40A RID: 46090
		[DoNotToLua]
		private UnchartedScoreButton.LuaExportHelper luaExportHelper;

		// Token: 0x0400B40B RID: 46091
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400B40C RID: 46092
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400B40D RID: 46093
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x0400B40E RID: 46094
		private LuaFunction m_SetUnchartedScoreInfoConfigDataUnchartedScoreInfo_hotfix;

		// Token: 0x0400B40F RID: 46095
		private LuaFunction m_GetUnchartedScoreInfo_hotfix;

		// Token: 0x0400B410 RID: 46096
		private LuaFunction m_OnButtonClick_hotfix;

		// Token: 0x0400B411 RID: 46097
		private LuaFunction m_add_EventOnStartUnchartedScoreAction;

		// Token: 0x0400B412 RID: 46098
		private LuaFunction m_remove_EventOnStartUnchartedScoreAction;

		// Token: 0x02000FEA RID: 4074
		public new class LuaExportHelper
		{
			// Token: 0x06014713 RID: 83731 RVA: 0x00531A74 File Offset: 0x0052FC74
			public LuaExportHelper(UnchartedScoreButton owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06014714 RID: 83732 RVA: 0x00531A84 File Offset: 0x0052FC84
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x06014715 RID: 83733 RVA: 0x00531A94 File Offset: 0x0052FC94
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x06014716 RID: 83734 RVA: 0x00531AA4 File Offset: 0x0052FCA4
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x06014717 RID: 83735 RVA: 0x00531AB4 File Offset: 0x0052FCB4
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x06014718 RID: 83736 RVA: 0x00531ACC File Offset: 0x0052FCCC
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x06014719 RID: 83737 RVA: 0x00531ADC File Offset: 0x0052FCDC
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0601471A RID: 83738 RVA: 0x00531AEC File Offset: 0x0052FCEC
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0601471B RID: 83739 RVA: 0x00531AFC File Offset: 0x0052FCFC
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0601471C RID: 83740 RVA: 0x00531B0C File Offset: 0x0052FD0C
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0601471D RID: 83741 RVA: 0x00531B1C File Offset: 0x0052FD1C
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0601471E RID: 83742 RVA: 0x00531B2C File Offset: 0x0052FD2C
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0601471F RID: 83743 RVA: 0x00531B3C File Offset: 0x0052FD3C
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x06014720 RID: 83744 RVA: 0x00531B4C File Offset: 0x0052FD4C
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x06014721 RID: 83745 RVA: 0x00531B5C File Offset: 0x0052FD5C
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x06014722 RID: 83746 RVA: 0x00531B6C File Offset: 0x0052FD6C
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x06014723 RID: 83747 RVA: 0x00531B7C File Offset: 0x0052FD7C
			public void __callDele_EventOnStartUnchartedScore(UnchartedScoreButton obj)
			{
				this.m_owner.__callDele_EventOnStartUnchartedScore(obj);
			}

			// Token: 0x06014724 RID: 83748 RVA: 0x00531B8C File Offset: 0x0052FD8C
			public void __clearDele_EventOnStartUnchartedScore(UnchartedScoreButton obj)
			{
				this.m_owner.__clearDele_EventOnStartUnchartedScore(obj);
			}

			// Token: 0x17003C9C RID: 15516
			// (get) Token: 0x06014725 RID: 83749 RVA: 0x00531B9C File Offset: 0x0052FD9C
			// (set) Token: 0x06014726 RID: 83750 RVA: 0x00531BAC File Offset: 0x0052FDAC
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

			// Token: 0x17003C9D RID: 15517
			// (get) Token: 0x06014727 RID: 83751 RVA: 0x00531BBC File Offset: 0x0052FDBC
			// (set) Token: 0x06014728 RID: 83752 RVA: 0x00531BCC File Offset: 0x0052FDCC
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

			// Token: 0x17003C9E RID: 15518
			// (get) Token: 0x06014729 RID: 83753 RVA: 0x00531BDC File Offset: 0x0052FDDC
			// (set) Token: 0x0601472A RID: 83754 RVA: 0x00531BEC File Offset: 0x0052FDEC
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

			// Token: 0x17003C9F RID: 15519
			// (get) Token: 0x0601472B RID: 83755 RVA: 0x00531BFC File Offset: 0x0052FDFC
			// (set) Token: 0x0601472C RID: 83756 RVA: 0x00531C0C File Offset: 0x0052FE0C
			public Image m_imageGrey
			{
				get
				{
					return this.m_owner.m_imageGrey;
				}
				set
				{
					this.m_owner.m_imageGrey = value;
				}
			}

			// Token: 0x17003CA0 RID: 15520
			// (get) Token: 0x0601472D RID: 83757 RVA: 0x00531C1C File Offset: 0x0052FE1C
			// (set) Token: 0x0601472E RID: 83758 RVA: 0x00531C2C File Offset: 0x0052FE2C
			public Text m_timeText
			{
				get
				{
					return this.m_owner.m_timeText;
				}
				set
				{
					this.m_owner.m_timeText = value;
				}
			}

			// Token: 0x17003CA1 RID: 15521
			// (get) Token: 0x0601472F RID: 83759 RVA: 0x00531C3C File Offset: 0x0052FE3C
			// (set) Token: 0x06014730 RID: 83760 RVA: 0x00531C4C File Offset: 0x0052FE4C
			public Text m_timeGreyText
			{
				get
				{
					return this.m_owner.m_timeGreyText;
				}
				set
				{
					this.m_owner.m_timeGreyText = value;
				}
			}

			// Token: 0x17003CA2 RID: 15522
			// (get) Token: 0x06014731 RID: 83761 RVA: 0x00531C5C File Offset: 0x0052FE5C
			// (set) Token: 0x06014732 RID: 83762 RVA: 0x00531C6C File Offset: 0x0052FE6C
			public Text m_numberText
			{
				get
				{
					return this.m_owner.m_numberText;
				}
				set
				{
					this.m_owner.m_numberText = value;
				}
			}

			// Token: 0x17003CA3 RID: 15523
			// (get) Token: 0x06014733 RID: 83763 RVA: 0x00531C7C File Offset: 0x0052FE7C
			// (set) Token: 0x06014734 RID: 83764 RVA: 0x00531C8C File Offset: 0x0052FE8C
			public ConfigDataUnchartedScoreInfo m_unchartedScoreInfo
			{
				get
				{
					return this.m_owner.m_unchartedScoreInfo;
				}
				set
				{
					this.m_owner.m_unchartedScoreInfo = value;
				}
			}

			// Token: 0x06014735 RID: 83765 RVA: 0x00531C9C File Offset: 0x0052FE9C
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x06014736 RID: 83766 RVA: 0x00531CAC File Offset: 0x0052FEAC
			public void OnButtonClick()
			{
				this.m_owner.OnButtonClick();
			}

			// Token: 0x0400B413 RID: 46099
			private UnchartedScoreButton m_owner;
		}
	}
}
