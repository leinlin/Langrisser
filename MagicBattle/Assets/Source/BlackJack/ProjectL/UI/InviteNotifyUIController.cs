using System;
using System.Threading;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000BCC RID: 3020
	[HotFix]
	public class InviteNotifyUIController : UIControllerBase
	{
		// Token: 0x0600D02B RID: 53291 RVA: 0x00390C14 File Offset: 0x0038EE14
		private InviteNotifyUIController()
		{
		}

		// Token: 0x0600D02C RID: 53292 RVA: 0x00390C1C File Offset: 0x0038EE1C
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
			this.m_iconButton.onClick.AddListener(new UnityAction(this.OnIconButtonClick));
			this.m_acceptButton.onClick.AddListener(new UnityAction(this.OnAcceptButtonClick));
			this.m_refuseButton.onClick.AddListener(new UnityAction(this.OnRefuseButtonClick));
			this.m_backgroundButton.onClick.AddListener(new UnityAction(this.OnBackgroundButtonClick));
		}

		// Token: 0x0600D02D RID: 53293 RVA: 0x00390CF4 File Offset: 0x0038EEF4
		public void OpenIcon()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OpenIcon_hotfix != null)
			{
				this.m_OpenIcon_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetUIStateOpen(this.m_iconUIStateController, "Show", null, false, true);
			this.m_panelUIStateController.gameObject.SetActive(false);
		}

		// Token: 0x0600D02E RID: 53294 RVA: 0x00390D78 File Offset: 0x0038EF78
		public void OpenPanel()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OpenPanel_hotfix != null)
			{
				this.m_OpenPanel_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetUIStateOpen(this.m_panelUIStateController, "Show", null, false, true);
			this.m_isPanelOpened = true;
			this.UpdateBackgroundButtonActive();
		}

		// Token: 0x0600D02F RID: 53295 RVA: 0x00390DF8 File Offset: 0x0038EFF8
		private void ClosePanel()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ClosePanel_hotfix != null)
			{
				this.m_ClosePanel_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetUIStateOpen(this.m_panelUIStateController, "Close", null, false, true);
			this.m_isPanelOpened = false;
			this.UpdateBackgroundButtonActive();
		}

		// Token: 0x0600D030 RID: 53296 RVA: 0x00390E78 File Offset: 0x0038F078
		public bool IsPanelOpened()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsPanelOpened_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsPanelOpened_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_isPanelOpened;
		}

		// Token: 0x0600D031 RID: 53297 RVA: 0x00390EEC File Offset: 0x0038F0EC
		public void Close(Action onEnd = null)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CloseAction_hotfix != null)
			{
				this.m_CloseAction_hotfix.call(new object[]
				{
					this,
					onEnd
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_isPanelOpened = false;
			UIUtility.SetUIStateClose(this.m_iconUIStateController, "Close", null, false, true);
			UIUtility.SetUIStateClose(this.m_panelUIStateController, "Close", onEnd, false, true);
		}

		// Token: 0x0600D032 RID: 53298 RVA: 0x00390F8C File Offset: 0x0038F18C
		public void SetTeamRoomInviteInfo(TeamRoomInviteInfo info, int count, bool inBattle)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetTeamRoomInviteInfoTeamRoomInviteInfoInt32Boolean_hotfix != null)
			{
				this.m_SetTeamRoomInviteInfoTeamRoomInviteInfoInt32Boolean_hotfix.call(new object[]
				{
					this,
					info,
					count,
					inBattle
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_playerNameText.text = info.Name;
			this.m_playerLevelText.text = info.Level.ToString();
			this.m_battleNameText.text = TeamUIController.GetGameFunctionName((GameFunctionType)info.GameFunctionTypeId, info.LocationId) + TeamUIController.GetLocationName((GameFunctionType)info.GameFunctionTypeId, info.LocationId);
			this.m_countText.text = count.ToString();
			this.m_acceptButton.gameObject.SetActive(!inBattle);
			this.UpdateBackgroundButtonActive();
		}

		// Token: 0x0600D033 RID: 53299 RVA: 0x003910B0 File Offset: 0x0038F2B0
		public void SetPVPInviteInfo(PVPInviteInfo info, int count, bool isBattle)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetPVPInviteInfoPVPInviteInfoInt32Boolean_hotfix != null)
			{
				this.m_SetPVPInviteInfoPVPInviteInfoInt32Boolean_hotfix.call(new object[]
				{
					this,
					info,
					count,
					isBattle
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			this.m_playerNameText.text = info.Inviter.Name;
			this.m_playerLevelText.text = info.Inviter.Level.ToString();
			this.m_battleNameText.text = configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Friend_PVPInviteNotify);
			this.m_countText.text = count.ToString();
			this.m_acceptButton.gameObject.SetActive(!isBattle);
			this.UpdateBackgroundButtonActive();
		}

		// Token: 0x0600D034 RID: 53300 RVA: 0x003911D0 File Offset: 0x0038F3D0
		private void UpdateBackgroundButtonActive()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateBackgroundButtonActive_hotfix != null)
			{
				this.m_UpdateBackgroundButtonActive_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_backgroundButton.gameObject.SetActive(this.m_isPanelOpened && !this.m_acceptButton.gameObject.activeSelf);
		}

		// Token: 0x0600D035 RID: 53301 RVA: 0x00391264 File Offset: 0x0038F464
		private void OnAcceptButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnAcceptButtonClick_hotfix != null)
			{
				this.m_OnAcceptButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.m_isPanelOpened)
			{
				return;
			}
			if (this.EventOnAccept != null)
			{
				this.EventOnAccept();
			}
		}

		// Token: 0x0600D036 RID: 53302 RVA: 0x003912E8 File Offset: 0x0038F4E8
		private void OnRefuseButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnRefuseButtonClick_hotfix != null)
			{
				this.m_OnRefuseButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.m_isPanelOpened)
			{
				return;
			}
			if (this.EventOnRefuse != null)
			{
				this.EventOnRefuse();
			}
		}

		// Token: 0x0600D037 RID: 53303 RVA: 0x0039136C File Offset: 0x0038F56C
		private void OnBackgroundButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnBackgroundButtonClick_hotfix != null)
			{
				this.m_OnBackgroundButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.m_isPanelOpened)
			{
				return;
			}
			this.ClosePanel();
		}

		// Token: 0x0600D038 RID: 53304 RVA: 0x003913E0 File Offset: 0x0038F5E0
		private void OnIconButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnIconButtonClick_hotfix != null)
			{
				this.m_OnIconButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnClickIcon != null)
			{
				this.EventOnClickIcon();
			}
		}

		// Token: 0x1400027D RID: 637
		// (add) Token: 0x0600D039 RID: 53305 RVA: 0x00391458 File Offset: 0x0038F658
		// (remove) Token: 0x0600D03A RID: 53306 RVA: 0x003914F4 File Offset: 0x0038F6F4
		public event Action EventOnAccept
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnAcceptAction_hotfix != null)
				{
					this.m_add_EventOnAcceptAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnAccept;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnAccept, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnAcceptAction_hotfix != null)
				{
					this.m_remove_EventOnAcceptAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnAccept;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnAccept, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1400027E RID: 638
		// (add) Token: 0x0600D03B RID: 53307 RVA: 0x00391590 File Offset: 0x0038F790
		// (remove) Token: 0x0600D03C RID: 53308 RVA: 0x0039162C File Offset: 0x0038F82C
		public event Action EventOnRefuse
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnRefuseAction_hotfix != null)
				{
					this.m_add_EventOnRefuseAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnRefuse;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnRefuse, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnRefuseAction_hotfix != null)
				{
					this.m_remove_EventOnRefuseAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnRefuse;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnRefuse, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1400027F RID: 639
		// (add) Token: 0x0600D03D RID: 53309 RVA: 0x003916C8 File Offset: 0x0038F8C8
		// (remove) Token: 0x0600D03E RID: 53310 RVA: 0x00391764 File Offset: 0x0038F964
		public event Action EventOnClickIcon
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnClickIconAction_hotfix != null)
				{
					this.m_add_EventOnClickIconAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnClickIcon;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnClickIcon, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnClickIconAction_hotfix != null)
				{
					this.m_remove_EventOnClickIconAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnClickIcon;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnClickIcon, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17002908 RID: 10504
		// (get) Token: 0x0600D03F RID: 53311 RVA: 0x00391800 File Offset: 0x0038FA00
		// (set) Token: 0x0600D040 RID: 53312 RVA: 0x00391820 File Offset: 0x0038FA20
		[DoNotToLua]
		public new InviteNotifyUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new InviteNotifyUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600D041 RID: 53313 RVA: 0x0039182C File Offset: 0x0038FA2C
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0600D042 RID: 53314 RVA: 0x00391838 File Offset: 0x0038FA38
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0600D043 RID: 53315 RVA: 0x00391840 File Offset: 0x0038FA40
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0600D044 RID: 53316 RVA: 0x00391848 File Offset: 0x0038FA48
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0600D045 RID: 53317 RVA: 0x0039185C File Offset: 0x0038FA5C
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0600D046 RID: 53318 RVA: 0x00391864 File Offset: 0x0038FA64
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0600D047 RID: 53319 RVA: 0x00391870 File Offset: 0x0038FA70
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0600D048 RID: 53320 RVA: 0x0039187C File Offset: 0x0038FA7C
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0600D049 RID: 53321 RVA: 0x00391888 File Offset: 0x0038FA88
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0600D04A RID: 53322 RVA: 0x00391894 File Offset: 0x0038FA94
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0600D04B RID: 53323 RVA: 0x003918A0 File Offset: 0x0038FAA0
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0600D04C RID: 53324 RVA: 0x003918AC File Offset: 0x0038FAAC
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0600D04D RID: 53325 RVA: 0x003918B8 File Offset: 0x0038FAB8
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0600D04E RID: 53326 RVA: 0x003918C4 File Offset: 0x0038FAC4
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0600D04F RID: 53327 RVA: 0x003918D0 File Offset: 0x0038FAD0
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600D050 RID: 53328 RVA: 0x003918D8 File Offset: 0x0038FAD8
		private void __callDele_EventOnAccept()
		{
			Action eventOnAccept = this.EventOnAccept;
			if (eventOnAccept != null)
			{
				eventOnAccept();
			}
		}

		// Token: 0x0600D051 RID: 53329 RVA: 0x003918F8 File Offset: 0x0038FAF8
		private void __clearDele_EventOnAccept()
		{
			this.EventOnAccept = null;
		}

		// Token: 0x0600D052 RID: 53330 RVA: 0x00391904 File Offset: 0x0038FB04
		private void __callDele_EventOnRefuse()
		{
			Action eventOnRefuse = this.EventOnRefuse;
			if (eventOnRefuse != null)
			{
				eventOnRefuse();
			}
		}

		// Token: 0x0600D053 RID: 53331 RVA: 0x00391924 File Offset: 0x0038FB24
		private void __clearDele_EventOnRefuse()
		{
			this.EventOnRefuse = null;
		}

		// Token: 0x0600D054 RID: 53332 RVA: 0x00391930 File Offset: 0x0038FB30
		private void __callDele_EventOnClickIcon()
		{
			Action eventOnClickIcon = this.EventOnClickIcon;
			if (eventOnClickIcon != null)
			{
				eventOnClickIcon();
			}
		}

		// Token: 0x0600D055 RID: 53333 RVA: 0x00391950 File Offset: 0x0038FB50
		private void __clearDele_EventOnClickIcon()
		{
			this.EventOnClickIcon = null;
		}

		// Token: 0x0600D056 RID: 53334 RVA: 0x0039195C File Offset: 0x0038FB5C
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
					this.m_OpenIcon_hotfix = (luaObj.RawGet("OpenIcon") as LuaFunction);
					this.m_OpenPanel_hotfix = (luaObj.RawGet("OpenPanel") as LuaFunction);
					this.m_ClosePanel_hotfix = (luaObj.RawGet("ClosePanel") as LuaFunction);
					this.m_IsPanelOpened_hotfix = (luaObj.RawGet("IsPanelOpened") as LuaFunction);
					this.m_CloseAction_hotfix = (luaObj.RawGet("Close") as LuaFunction);
					this.m_SetTeamRoomInviteInfoTeamRoomInviteInfoInt32Boolean_hotfix = (luaObj.RawGet("SetTeamRoomInviteInfo") as LuaFunction);
					this.m_SetPVPInviteInfoPVPInviteInfoInt32Boolean_hotfix = (luaObj.RawGet("SetPVPInviteInfo") as LuaFunction);
					this.m_UpdateBackgroundButtonActive_hotfix = (luaObj.RawGet("UpdateBackgroundButtonActive") as LuaFunction);
					this.m_OnAcceptButtonClick_hotfix = (luaObj.RawGet("OnAcceptButtonClick") as LuaFunction);
					this.m_OnRefuseButtonClick_hotfix = (luaObj.RawGet("OnRefuseButtonClick") as LuaFunction);
					this.m_OnBackgroundButtonClick_hotfix = (luaObj.RawGet("OnBackgroundButtonClick") as LuaFunction);
					this.m_OnIconButtonClick_hotfix = (luaObj.RawGet("OnIconButtonClick") as LuaFunction);
					this.m_add_EventOnAcceptAction_hotfix = (luaObj.RawGet("add_EventOnAccept") as LuaFunction);
					this.m_remove_EventOnAcceptAction_hotfix = (luaObj.RawGet("remove_EventOnAccept") as LuaFunction);
					this.m_add_EventOnRefuseAction_hotfix = (luaObj.RawGet("add_EventOnRefuse") as LuaFunction);
					this.m_remove_EventOnRefuseAction_hotfix = (luaObj.RawGet("remove_EventOnRefuse") as LuaFunction);
					this.m_add_EventOnClickIconAction_hotfix = (luaObj.RawGet("add_EventOnClickIcon") as LuaFunction);
					this.m_remove_EventOnClickIconAction_hotfix = (luaObj.RawGet("remove_EventOnClickIcon") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600D057 RID: 53335 RVA: 0x00391BEC File Offset: 0x0038FDEC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(InviteNotifyUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040081A8 RID: 33192
		[AutoBind("./IconButton", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_iconUIStateController;

		// Token: 0x040081A9 RID: 33193
		[AutoBind("./IconButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_iconButton;

		// Token: 0x040081AA RID: 33194
		[AutoBind("./IconButton/RedPoint/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_countText;

		// Token: 0x040081AB RID: 33195
		[AutoBind("./Panel", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_panelUIStateController;

		// Token: 0x040081AC RID: 33196
		[AutoBind("./Panel/FrameImage/AcceptButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_acceptButton;

		// Token: 0x040081AD RID: 33197
		[AutoBind("./Panel/FrameImage/RefuseButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_refuseButton;

		// Token: 0x040081AE RID: 33198
		[AutoBind("./BackgroundButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_backgroundButton;

		// Token: 0x040081AF RID: 33199
		[AutoBind("./Panel/FrameImage/PlayerInfo/NameText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_playerNameText;

		// Token: 0x040081B0 RID: 33200
		[AutoBind("./Panel/FrameImage/PlayerInfo/LvValue", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_playerLevelText;

		// Token: 0x040081B1 RID: 33201
		[AutoBind("./Panel/FrameImage/PlayerInfo/FBNameText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_battleNameText;

		// Token: 0x040081B2 RID: 33202
		private bool m_isPanelOpened;

		// Token: 0x040081B3 RID: 33203
		[DoNotToLua]
		private InviteNotifyUIController.LuaExportHelper luaExportHelper;

		// Token: 0x040081B4 RID: 33204
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040081B5 RID: 33205
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040081B6 RID: 33206
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x040081B7 RID: 33207
		private LuaFunction m_OpenIcon_hotfix;

		// Token: 0x040081B8 RID: 33208
		private LuaFunction m_OpenPanel_hotfix;

		// Token: 0x040081B9 RID: 33209
		private LuaFunction m_ClosePanel_hotfix;

		// Token: 0x040081BA RID: 33210
		private LuaFunction m_IsPanelOpened_hotfix;

		// Token: 0x040081BB RID: 33211
		private LuaFunction m_CloseAction_hotfix;

		// Token: 0x040081BC RID: 33212
		private LuaFunction m_SetTeamRoomInviteInfoTeamRoomInviteInfoInt32Boolean_hotfix;

		// Token: 0x040081BD RID: 33213
		private LuaFunction m_SetPVPInviteInfoPVPInviteInfoInt32Boolean_hotfix;

		// Token: 0x040081BE RID: 33214
		private LuaFunction m_UpdateBackgroundButtonActive_hotfix;

		// Token: 0x040081BF RID: 33215
		private LuaFunction m_OnAcceptButtonClick_hotfix;

		// Token: 0x040081C0 RID: 33216
		private LuaFunction m_OnRefuseButtonClick_hotfix;

		// Token: 0x040081C1 RID: 33217
		private LuaFunction m_OnBackgroundButtonClick_hotfix;

		// Token: 0x040081C2 RID: 33218
		private LuaFunction m_OnIconButtonClick_hotfix;

		// Token: 0x040081C3 RID: 33219
		private LuaFunction m_add_EventOnAcceptAction_hotfix;

		// Token: 0x040081C4 RID: 33220
		private LuaFunction m_remove_EventOnAcceptAction_hotfix;

		// Token: 0x040081C5 RID: 33221
		private LuaFunction m_add_EventOnRefuseAction_hotfix;

		// Token: 0x040081C6 RID: 33222
		private LuaFunction m_remove_EventOnRefuseAction_hotfix;

		// Token: 0x040081C7 RID: 33223
		private LuaFunction m_add_EventOnClickIconAction_hotfix;

		// Token: 0x040081C8 RID: 33224
		private LuaFunction m_remove_EventOnClickIconAction_hotfix;

		// Token: 0x02000BCD RID: 3021
		public new class LuaExportHelper
		{
			// Token: 0x0600D058 RID: 53336 RVA: 0x00391C54 File Offset: 0x0038FE54
			public LuaExportHelper(InviteNotifyUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600D059 RID: 53337 RVA: 0x00391C64 File Offset: 0x0038FE64
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0600D05A RID: 53338 RVA: 0x00391C74 File Offset: 0x0038FE74
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0600D05B RID: 53339 RVA: 0x00391C84 File Offset: 0x0038FE84
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600D05C RID: 53340 RVA: 0x00391C94 File Offset: 0x0038FE94
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600D05D RID: 53341 RVA: 0x00391CAC File Offset: 0x0038FEAC
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0600D05E RID: 53342 RVA: 0x00391CBC File Offset: 0x0038FEBC
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0600D05F RID: 53343 RVA: 0x00391CCC File Offset: 0x0038FECC
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0600D060 RID: 53344 RVA: 0x00391CDC File Offset: 0x0038FEDC
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0600D061 RID: 53345 RVA: 0x00391CEC File Offset: 0x0038FEEC
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0600D062 RID: 53346 RVA: 0x00391CFC File Offset: 0x0038FEFC
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0600D063 RID: 53347 RVA: 0x00391D0C File Offset: 0x0038FF0C
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0600D064 RID: 53348 RVA: 0x00391D1C File Offset: 0x0038FF1C
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0600D065 RID: 53349 RVA: 0x00391D2C File Offset: 0x0038FF2C
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0600D066 RID: 53350 RVA: 0x00391D3C File Offset: 0x0038FF3C
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0600D067 RID: 53351 RVA: 0x00391D4C File Offset: 0x0038FF4C
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x0600D068 RID: 53352 RVA: 0x00391D5C File Offset: 0x0038FF5C
			public void __callDele_EventOnAccept()
			{
				this.m_owner.__callDele_EventOnAccept();
			}

			// Token: 0x0600D069 RID: 53353 RVA: 0x00391D6C File Offset: 0x0038FF6C
			public void __clearDele_EventOnAccept()
			{
				this.m_owner.__clearDele_EventOnAccept();
			}

			// Token: 0x0600D06A RID: 53354 RVA: 0x00391D7C File Offset: 0x0038FF7C
			public void __callDele_EventOnRefuse()
			{
				this.m_owner.__callDele_EventOnRefuse();
			}

			// Token: 0x0600D06B RID: 53355 RVA: 0x00391D8C File Offset: 0x0038FF8C
			public void __clearDele_EventOnRefuse()
			{
				this.m_owner.__clearDele_EventOnRefuse();
			}

			// Token: 0x0600D06C RID: 53356 RVA: 0x00391D9C File Offset: 0x0038FF9C
			public void __callDele_EventOnClickIcon()
			{
				this.m_owner.__callDele_EventOnClickIcon();
			}

			// Token: 0x0600D06D RID: 53357 RVA: 0x00391DAC File Offset: 0x0038FFAC
			public void __clearDele_EventOnClickIcon()
			{
				this.m_owner.__clearDele_EventOnClickIcon();
			}

			// Token: 0x17002909 RID: 10505
			// (get) Token: 0x0600D06E RID: 53358 RVA: 0x00391DBC File Offset: 0x0038FFBC
			// (set) Token: 0x0600D06F RID: 53359 RVA: 0x00391DCC File Offset: 0x0038FFCC
			public CommonUIStateController m_iconUIStateController
			{
				get
				{
					return this.m_owner.m_iconUIStateController;
				}
				set
				{
					this.m_owner.m_iconUIStateController = value;
				}
			}

			// Token: 0x1700290A RID: 10506
			// (get) Token: 0x0600D070 RID: 53360 RVA: 0x00391DDC File Offset: 0x0038FFDC
			// (set) Token: 0x0600D071 RID: 53361 RVA: 0x00391DEC File Offset: 0x0038FFEC
			public Button m_iconButton
			{
				get
				{
					return this.m_owner.m_iconButton;
				}
				set
				{
					this.m_owner.m_iconButton = value;
				}
			}

			// Token: 0x1700290B RID: 10507
			// (get) Token: 0x0600D072 RID: 53362 RVA: 0x00391DFC File Offset: 0x0038FFFC
			// (set) Token: 0x0600D073 RID: 53363 RVA: 0x00391E0C File Offset: 0x0039000C
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

			// Token: 0x1700290C RID: 10508
			// (get) Token: 0x0600D074 RID: 53364 RVA: 0x00391E1C File Offset: 0x0039001C
			// (set) Token: 0x0600D075 RID: 53365 RVA: 0x00391E2C File Offset: 0x0039002C
			public CommonUIStateController m_panelUIStateController
			{
				get
				{
					return this.m_owner.m_panelUIStateController;
				}
				set
				{
					this.m_owner.m_panelUIStateController = value;
				}
			}

			// Token: 0x1700290D RID: 10509
			// (get) Token: 0x0600D076 RID: 53366 RVA: 0x00391E3C File Offset: 0x0039003C
			// (set) Token: 0x0600D077 RID: 53367 RVA: 0x00391E4C File Offset: 0x0039004C
			public Button m_acceptButton
			{
				get
				{
					return this.m_owner.m_acceptButton;
				}
				set
				{
					this.m_owner.m_acceptButton = value;
				}
			}

			// Token: 0x1700290E RID: 10510
			// (get) Token: 0x0600D078 RID: 53368 RVA: 0x00391E5C File Offset: 0x0039005C
			// (set) Token: 0x0600D079 RID: 53369 RVA: 0x00391E6C File Offset: 0x0039006C
			public Button m_refuseButton
			{
				get
				{
					return this.m_owner.m_refuseButton;
				}
				set
				{
					this.m_owner.m_refuseButton = value;
				}
			}

			// Token: 0x1700290F RID: 10511
			// (get) Token: 0x0600D07A RID: 53370 RVA: 0x00391E7C File Offset: 0x0039007C
			// (set) Token: 0x0600D07B RID: 53371 RVA: 0x00391E8C File Offset: 0x0039008C
			public Button m_backgroundButton
			{
				get
				{
					return this.m_owner.m_backgroundButton;
				}
				set
				{
					this.m_owner.m_backgroundButton = value;
				}
			}

			// Token: 0x17002910 RID: 10512
			// (get) Token: 0x0600D07C RID: 53372 RVA: 0x00391E9C File Offset: 0x0039009C
			// (set) Token: 0x0600D07D RID: 53373 RVA: 0x00391EAC File Offset: 0x003900AC
			public Text m_playerNameText
			{
				get
				{
					return this.m_owner.m_playerNameText;
				}
				set
				{
					this.m_owner.m_playerNameText = value;
				}
			}

			// Token: 0x17002911 RID: 10513
			// (get) Token: 0x0600D07E RID: 53374 RVA: 0x00391EBC File Offset: 0x003900BC
			// (set) Token: 0x0600D07F RID: 53375 RVA: 0x00391ECC File Offset: 0x003900CC
			public Text m_playerLevelText
			{
				get
				{
					return this.m_owner.m_playerLevelText;
				}
				set
				{
					this.m_owner.m_playerLevelText = value;
				}
			}

			// Token: 0x17002912 RID: 10514
			// (get) Token: 0x0600D080 RID: 53376 RVA: 0x00391EDC File Offset: 0x003900DC
			// (set) Token: 0x0600D081 RID: 53377 RVA: 0x00391EEC File Offset: 0x003900EC
			public Text m_battleNameText
			{
				get
				{
					return this.m_owner.m_battleNameText;
				}
				set
				{
					this.m_owner.m_battleNameText = value;
				}
			}

			// Token: 0x17002913 RID: 10515
			// (get) Token: 0x0600D082 RID: 53378 RVA: 0x00391EFC File Offset: 0x003900FC
			// (set) Token: 0x0600D083 RID: 53379 RVA: 0x00391F0C File Offset: 0x0039010C
			public bool m_isPanelOpened
			{
				get
				{
					return this.m_owner.m_isPanelOpened;
				}
				set
				{
					this.m_owner.m_isPanelOpened = value;
				}
			}

			// Token: 0x0600D084 RID: 53380 RVA: 0x00391F1C File Offset: 0x0039011C
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0600D085 RID: 53381 RVA: 0x00391F2C File Offset: 0x0039012C
			public void ClosePanel()
			{
				this.m_owner.ClosePanel();
			}

			// Token: 0x0600D086 RID: 53382 RVA: 0x00391F3C File Offset: 0x0039013C
			public void UpdateBackgroundButtonActive()
			{
				this.m_owner.UpdateBackgroundButtonActive();
			}

			// Token: 0x0600D087 RID: 53383 RVA: 0x00391F4C File Offset: 0x0039014C
			public void OnAcceptButtonClick()
			{
				this.m_owner.OnAcceptButtonClick();
			}

			// Token: 0x0600D088 RID: 53384 RVA: 0x00391F5C File Offset: 0x0039015C
			public void OnRefuseButtonClick()
			{
				this.m_owner.OnRefuseButtonClick();
			}

			// Token: 0x0600D089 RID: 53385 RVA: 0x00391F6C File Offset: 0x0039016C
			public void OnBackgroundButtonClick()
			{
				this.m_owner.OnBackgroundButtonClick();
			}

			// Token: 0x0600D08A RID: 53386 RVA: 0x00391F7C File Offset: 0x0039017C
			public void OnIconButtonClick()
			{
				this.m_owner.OnIconButtonClick();
			}

			// Token: 0x040081C9 RID: 33225
			private InviteNotifyUIController m_owner;
		}
	}
}
