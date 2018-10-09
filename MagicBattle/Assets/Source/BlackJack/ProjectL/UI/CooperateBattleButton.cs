using System;
using System.Threading;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Misc;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.UtilityTools;
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000FE7 RID: 4071
	[HotFix]
	public class CooperateBattleButton : UIControllerBase
	{
		// Token: 0x060146B8 RID: 83640 RVA: 0x005307A8 File Offset: 0x0052E9A8
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

		// Token: 0x060146B9 RID: 83641 RVA: 0x0053082C File Offset: 0x0052EA2C
		public void SetCooperateBattleInfo(ConfigDataCooperateBattleInfo cooperateBattleInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetCooperateBattleInfoConfigDataCooperateBattleInfo_hotfix != null)
			{
				this.m_SetCooperateBattleInfoConfigDataCooperateBattleInfo_hotfix.call(new object[]
				{
					this,
					cooperateBattleInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_cooperateBattleInfo = cooperateBattleInfo;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			bool flag = projectLPlayerContext.IsGameFunctionOpened(GameFunctionType.GameFunctionType_CooperateBattle) && projectLPlayerContext.IsCooperateBattleOpened(cooperateBattleInfo.ID);
			this.m_uiStateController.SetToUIState((!flag) ? "Grey" : "Normal", false, true);
			DateTime serverTime = projectLPlayerContext.GetServerTime();
			DateTime dateTime = DateTime.MaxValue;
			DateTime dateTime2 = DateTime.MaxValue;
			int num = cooperateBattleInfo.OpenDaysOfWeek.BinarySearch(serverTime.Date.DayOfWeek);
			if (num >= 0)
			{
				dateTime = serverTime.StartOfWeek(serverTime.Date.DayOfWeek).Add(cooperateBattleInfo.OpenTimeSpan);
				dateTime2 = serverTime.StartOfWeek(serverTime.Date.DayOfWeek).Add(cooperateBattleInfo.CloseTimeSpan);
			}
			else
			{
				num = ~num;
				if (num < cooperateBattleInfo.OpenDaysOfWeek.Count)
				{
					dateTime = serverTime.StartOfWeek(cooperateBattleInfo.OpenDaysOfWeek[num]).Add(cooperateBattleInfo.OpenTimeSpan);
					dateTime2 = serverTime.StartOfWeek(cooperateBattleInfo.OpenDaysOfWeek[num]).Add(cooperateBattleInfo.CloseTimeSpan);
				}
				else
				{
					dateTime = serverTime.StartOfWeek(cooperateBattleInfo.OpenDaysOfWeek[num % cooperateBattleInfo.OpenDaysOfWeek.Count]).Add(cooperateBattleInfo.OpenTimeSpan).AddDays(7.0);
					dateTime2 = serverTime.StartOfWeek(cooperateBattleInfo.OpenDaysOfWeek[num % cooperateBattleInfo.OpenDaysOfWeek.Count]).Add(cooperateBattleInfo.CloseTimeSpan).AddDays(7.0);
				}
			}
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
			int cooperateBattleDailyChallengeNums = projectLPlayerContext.GetCooperateBattleDailyChallengeNums(cooperateBattleInfo.ID);
			int dailyBonusMaxNums = projectLPlayerContext.GetDailyBonusMaxNums(GameFunctionType.GameFunctionType_CooperateBattle);
			UIUtility.SetDailyRewardCount(this.m_numberText, cooperateBattleDailyChallengeNums, dailyBonusMaxNums);
			Image bgImage = this.m_bgImage;
			Sprite sprite = AssetUtility.Instance.GetSprite(cooperateBattleInfo.Image);
			this.m_bgGreyImage.sprite = sprite;
			bgImage.sprite = sprite;
		}

		// Token: 0x060146BA RID: 83642 RVA: 0x00530B74 File Offset: 0x0052ED74
		public ConfigDataCooperateBattleInfo GetCooperateBattleInfo()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetCooperateBattleInfo_hotfix != null)
			{
				return (ConfigDataCooperateBattleInfo)this.m_GetCooperateBattleInfo_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_cooperateBattleInfo;
		}

		// Token: 0x060146BB RID: 83643 RVA: 0x00530BE8 File Offset: 0x0052EDE8
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
				if (this.EventOnStartCooperateBattle != null)
				{
					this.EventOnStartCooperateBattle(this);
				}
			}
			else
			{
				ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
				if (!projectLPlayerContext.IsGameFunctionOpened(GameFunctionType.GameFunctionType_CooperateBattle))
				{
					CommonUIController.Instance.ShowMessage(UIUtility.GetGameFunctionOpenMessage(GameFunctionType.GameFunctionType_CooperateBattle), 2f, null, true);
				}
				else
				{
					CommonUIController.Instance.ShowMessage(StringTableId.StringTableId_Uncharted_NotOpenTime, 2f, null, true);
				}
			}
		}

		// Token: 0x1400047F RID: 1151
		// (add) Token: 0x060146BC RID: 83644 RVA: 0x00530CD0 File Offset: 0x0052EED0
		// (remove) Token: 0x060146BD RID: 83645 RVA: 0x00530D6C File Offset: 0x0052EF6C
		public event Action<CooperateBattleButton> EventOnStartCooperateBattle
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnStartCooperateBattleAction`1_hotfix != null)
				{
					this.m_add_EventOnStartCooperateBattleAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<CooperateBattleButton> action = this.EventOnStartCooperateBattle;
				Action<CooperateBattleButton> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<CooperateBattleButton>>(ref this.EventOnStartCooperateBattle, (Action<CooperateBattleButton>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnStartCooperateBattleAction`1_hotfix != null)
				{
					this.m_remove_EventOnStartCooperateBattleAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<CooperateBattleButton> action = this.EventOnStartCooperateBattle;
				Action<CooperateBattleButton> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<CooperateBattleButton>>(ref this.EventOnStartCooperateBattle, (Action<CooperateBattleButton>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17003C92 RID: 15506
		// (get) Token: 0x060146BE RID: 83646 RVA: 0x00530E08 File Offset: 0x0052F008
		// (set) Token: 0x060146BF RID: 83647 RVA: 0x00530E28 File Offset: 0x0052F028
		[DoNotToLua]
		public new CooperateBattleButton.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new CooperateBattleButton.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x060146C0 RID: 83648 RVA: 0x00530E34 File Offset: 0x0052F034
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x060146C1 RID: 83649 RVA: 0x00530E40 File Offset: 0x0052F040
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x060146C2 RID: 83650 RVA: 0x00530E48 File Offset: 0x0052F048
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x060146C3 RID: 83651 RVA: 0x00530E50 File Offset: 0x0052F050
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x060146C4 RID: 83652 RVA: 0x00530E64 File Offset: 0x0052F064
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x060146C5 RID: 83653 RVA: 0x00530E6C File Offset: 0x0052F06C
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x060146C6 RID: 83654 RVA: 0x00530E78 File Offset: 0x0052F078
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x060146C7 RID: 83655 RVA: 0x00530E84 File Offset: 0x0052F084
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x060146C8 RID: 83656 RVA: 0x00530E90 File Offset: 0x0052F090
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x060146C9 RID: 83657 RVA: 0x00530E9C File Offset: 0x0052F09C
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x060146CA RID: 83658 RVA: 0x00530EA8 File Offset: 0x0052F0A8
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x060146CB RID: 83659 RVA: 0x00530EB4 File Offset: 0x0052F0B4
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x060146CC RID: 83660 RVA: 0x00530EC0 File Offset: 0x0052F0C0
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x060146CD RID: 83661 RVA: 0x00530ECC File Offset: 0x0052F0CC
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x060146CE RID: 83662 RVA: 0x00530ED8 File Offset: 0x0052F0D8
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x060146CF RID: 83663 RVA: 0x00530EE0 File Offset: 0x0052F0E0
		private void __callDele_EventOnStartCooperateBattle(CooperateBattleButton obj)
		{
			Action<CooperateBattleButton> eventOnStartCooperateBattle = this.EventOnStartCooperateBattle;
			if (eventOnStartCooperateBattle != null)
			{
				eventOnStartCooperateBattle(obj);
			}
		}

		// Token: 0x060146D0 RID: 83664 RVA: 0x00530F04 File Offset: 0x0052F104
		private void __clearDele_EventOnStartCooperateBattle(CooperateBattleButton obj)
		{
			this.EventOnStartCooperateBattle = null;
		}

		// Token: 0x060146D1 RID: 83665 RVA: 0x00530F10 File Offset: 0x0052F110
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
					this.m_SetCooperateBattleInfoConfigDataCooperateBattleInfo_hotfix = (luaObj.RawGet("SetCooperateBattleInfo") as LuaFunction);
					this.m_GetCooperateBattleInfo_hotfix = (luaObj.RawGet("GetCooperateBattleInfo") as LuaFunction);
					this.m_OnButtonClick_hotfix = (luaObj.RawGet("OnButtonClick") as LuaFunction);
					this.m_add_EventOnStartCooperateBattleAction`1_hotfix = (luaObj.RawGet("add_EventOnStartCooperateBattle") as LuaFunction);
					this.m_remove_EventOnStartCooperateBattleAction`1_hotfix = (luaObj.RawGet("remove_EventOnStartCooperateBattle") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x060146D2 RID: 83666 RVA: 0x00531058 File Offset: 0x0052F258
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(CooperateBattleButton));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400B3EE RID: 46062
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_button;

		// Token: 0x0400B3EF RID: 46063
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_uiStateController;

		// Token: 0x0400B3F0 RID: 46064
		[AutoBind("./BGImage", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_bgImage;

		// Token: 0x0400B3F1 RID: 46065
		[AutoBind("./Locked", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_bgGreyImage;

		// Token: 0x0400B3F2 RID: 46066
		[AutoBind("./TimeText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_timeText;

		// Token: 0x0400B3F3 RID: 46067
		[AutoBind("./TimeTextGrey", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_timeGreyText;

		// Token: 0x0400B3F4 RID: 46068
		[AutoBind("./DailyReward/NumberText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_numberText;

		// Token: 0x0400B3F6 RID: 46070
		private ConfigDataCooperateBattleInfo m_cooperateBattleInfo;

		// Token: 0x0400B3F7 RID: 46071
		[DoNotToLua]
		private CooperateBattleButton.LuaExportHelper luaExportHelper;

		// Token: 0x0400B3F8 RID: 46072
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400B3F9 RID: 46073
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400B3FA RID: 46074
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x0400B3FB RID: 46075
		private LuaFunction m_SetCooperateBattleInfoConfigDataCooperateBattleInfo_hotfix;

		// Token: 0x0400B3FC RID: 46076
		private LuaFunction m_GetCooperateBattleInfo_hotfix;

		// Token: 0x0400B3FD RID: 46077
		private LuaFunction m_OnButtonClick_hotfix;

		// Token: 0x0400B3FE RID: 46078
		private LuaFunction m_add_EventOnStartCooperateBattleAction;

		// Token: 0x0400B3FF RID: 46079
		private LuaFunction m_remove_EventOnStartCooperateBattleAction;

		// Token: 0x02000FE8 RID: 4072
		public new class LuaExportHelper
		{
			// Token: 0x060146D3 RID: 83667 RVA: 0x005310C0 File Offset: 0x0052F2C0
			public LuaExportHelper(CooperateBattleButton owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x060146D4 RID: 83668 RVA: 0x005310D0 File Offset: 0x0052F2D0
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x060146D5 RID: 83669 RVA: 0x005310E0 File Offset: 0x0052F2E0
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x060146D6 RID: 83670 RVA: 0x005310F0 File Offset: 0x0052F2F0
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x060146D7 RID: 83671 RVA: 0x00531100 File Offset: 0x0052F300
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x060146D8 RID: 83672 RVA: 0x00531118 File Offset: 0x0052F318
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x060146D9 RID: 83673 RVA: 0x00531128 File Offset: 0x0052F328
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x060146DA RID: 83674 RVA: 0x00531138 File Offset: 0x0052F338
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x060146DB RID: 83675 RVA: 0x00531148 File Offset: 0x0052F348
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x060146DC RID: 83676 RVA: 0x00531158 File Offset: 0x0052F358
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x060146DD RID: 83677 RVA: 0x00531168 File Offset: 0x0052F368
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x060146DE RID: 83678 RVA: 0x00531178 File Offset: 0x0052F378
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x060146DF RID: 83679 RVA: 0x00531188 File Offset: 0x0052F388
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x060146E0 RID: 83680 RVA: 0x00531198 File Offset: 0x0052F398
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x060146E1 RID: 83681 RVA: 0x005311A8 File Offset: 0x0052F3A8
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x060146E2 RID: 83682 RVA: 0x005311B8 File Offset: 0x0052F3B8
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x060146E3 RID: 83683 RVA: 0x005311C8 File Offset: 0x0052F3C8
			public void __callDele_EventOnStartCooperateBattle(CooperateBattleButton obj)
			{
				this.m_owner.__callDele_EventOnStartCooperateBattle(obj);
			}

			// Token: 0x060146E4 RID: 83684 RVA: 0x005311D8 File Offset: 0x0052F3D8
			public void __clearDele_EventOnStartCooperateBattle(CooperateBattleButton obj)
			{
				this.m_owner.__clearDele_EventOnStartCooperateBattle(obj);
			}

			// Token: 0x17003C93 RID: 15507
			// (get) Token: 0x060146E5 RID: 83685 RVA: 0x005311E8 File Offset: 0x0052F3E8
			// (set) Token: 0x060146E6 RID: 83686 RVA: 0x005311F8 File Offset: 0x0052F3F8
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

			// Token: 0x17003C94 RID: 15508
			// (get) Token: 0x060146E7 RID: 83687 RVA: 0x00531208 File Offset: 0x0052F408
			// (set) Token: 0x060146E8 RID: 83688 RVA: 0x00531218 File Offset: 0x0052F418
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

			// Token: 0x17003C95 RID: 15509
			// (get) Token: 0x060146E9 RID: 83689 RVA: 0x00531228 File Offset: 0x0052F428
			// (set) Token: 0x060146EA RID: 83690 RVA: 0x00531238 File Offset: 0x0052F438
			public Image m_bgImage
			{
				get
				{
					return this.m_owner.m_bgImage;
				}
				set
				{
					this.m_owner.m_bgImage = value;
				}
			}

			// Token: 0x17003C96 RID: 15510
			// (get) Token: 0x060146EB RID: 83691 RVA: 0x00531248 File Offset: 0x0052F448
			// (set) Token: 0x060146EC RID: 83692 RVA: 0x00531258 File Offset: 0x0052F458
			public Image m_bgGreyImage
			{
				get
				{
					return this.m_owner.m_bgGreyImage;
				}
				set
				{
					this.m_owner.m_bgGreyImage = value;
				}
			}

			// Token: 0x17003C97 RID: 15511
			// (get) Token: 0x060146ED RID: 83693 RVA: 0x00531268 File Offset: 0x0052F468
			// (set) Token: 0x060146EE RID: 83694 RVA: 0x00531278 File Offset: 0x0052F478
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

			// Token: 0x17003C98 RID: 15512
			// (get) Token: 0x060146EF RID: 83695 RVA: 0x00531288 File Offset: 0x0052F488
			// (set) Token: 0x060146F0 RID: 83696 RVA: 0x00531298 File Offset: 0x0052F498
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

			// Token: 0x17003C99 RID: 15513
			// (get) Token: 0x060146F1 RID: 83697 RVA: 0x005312A8 File Offset: 0x0052F4A8
			// (set) Token: 0x060146F2 RID: 83698 RVA: 0x005312B8 File Offset: 0x0052F4B8
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

			// Token: 0x17003C9A RID: 15514
			// (get) Token: 0x060146F3 RID: 83699 RVA: 0x005312C8 File Offset: 0x0052F4C8
			// (set) Token: 0x060146F4 RID: 83700 RVA: 0x005312D8 File Offset: 0x0052F4D8
			public ConfigDataCooperateBattleInfo m_cooperateBattleInfo
			{
				get
				{
					return this.m_owner.m_cooperateBattleInfo;
				}
				set
				{
					this.m_owner.m_cooperateBattleInfo = value;
				}
			}

			// Token: 0x060146F5 RID: 83701 RVA: 0x005312E8 File Offset: 0x0052F4E8
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x060146F6 RID: 83702 RVA: 0x005312F8 File Offset: 0x0052F4F8
			public void OnButtonClick()
			{
				this.m_owner.OnButtonClick();
			}

			// Token: 0x0400B400 RID: 46080
			private CooperateBattleButton m_owner;
		}
	}
}
