using System;
using System.Threading;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Misc;
using BlackJack.ProjectL.Protocol;
using BlackJack.UtilityTools;
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000CB8 RID: 3256
	[HotFix]
	public class FriendGroupUIController : UIControllerBase
	{
		// Token: 0x0600EC35 RID: 60469 RVA: 0x003F1C70 File Offset: 0x003EFE70
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
			this.m_chatButton.onClick.AddListener(new UnityAction(this.OnChatButtonClick));
			this.m_watchStaffButton.onClick.AddListener(new UnityAction(this.OnWatchStaffButtonClick));
		}

		// Token: 0x0600EC36 RID: 60470 RVA: 0x003F1D10 File Offset: 0x003EFF10
		public void SetGroupInfo(ProChatGroupCompactInfo groupInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetGroupInfoProChatGroupCompactInfo_hotfix != null)
			{
				this.m_SetGroupInfoProChatGroupCompactInfo_hotfix.call(new object[]
				{
					this,
					groupInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_groupInfo = groupInfo;
			this.m_groupIconImage.sprite = AssetUtility.Instance.GetSprite(UIUtility.GetPlayerSmallHeadIconImageName(HeadIconTools.GetHeadPortrait(groupInfo.Owner.HeadIcon)));
			UIUtility.SetPlayerHeadFrame(this.m_groupHeadFrameTransform, HeadIconTools.GetHeadFrame(groupInfo.Owner.HeadIcon), true, "Normal");
			this.m_onlinePlayerNumText.text = string.Format(this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Friend_OnlineCount), groupInfo.OnlineUserCount);
			this.m_groupNameText.text = groupInfo.ChatGroupName;
		}

		// Token: 0x0600EC37 RID: 60471 RVA: 0x003F1E10 File Offset: 0x003F0010
		public ProChatGroupCompactInfo GetGroupInfo()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetGroupInfo_hotfix != null)
			{
				return (ProChatGroupCompactInfo)this.m_GetGroupInfo_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_groupInfo;
		}

		// Token: 0x0600EC38 RID: 60472 RVA: 0x003F1E84 File Offset: 0x003F0084
		private void OnChatButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnChatButtonClick_hotfix != null)
			{
				this.m_OnChatButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnChatButtonClick != null)
			{
				this.EventOnChatButtonClick(this);
			}
		}

		// Token: 0x0600EC39 RID: 60473 RVA: 0x003F1EFC File Offset: 0x003F00FC
		private void OnWatchStaffButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnWatchStaffButtonClick_hotfix != null)
			{
				this.m_OnWatchStaffButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnWatchGroupStaffButtonClick != null)
			{
				this.EventOnWatchGroupStaffButtonClick(this);
			}
		}

		// Token: 0x1400031C RID: 796
		// (add) Token: 0x0600EC3A RID: 60474 RVA: 0x003F1F74 File Offset: 0x003F0174
		// (remove) Token: 0x0600EC3B RID: 60475 RVA: 0x003F2010 File Offset: 0x003F0210
		public event Action<FriendGroupUIController> EventOnWatchGroupStaffButtonClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnWatchGroupStaffButtonClickAction`1_hotfix != null)
				{
					this.m_add_EventOnWatchGroupStaffButtonClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<FriendGroupUIController> action = this.EventOnWatchGroupStaffButtonClick;
				Action<FriendGroupUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<FriendGroupUIController>>(ref this.EventOnWatchGroupStaffButtonClick, (Action<FriendGroupUIController>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnWatchGroupStaffButtonClickAction`1_hotfix != null)
				{
					this.m_remove_EventOnWatchGroupStaffButtonClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<FriendGroupUIController> action = this.EventOnWatchGroupStaffButtonClick;
				Action<FriendGroupUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<FriendGroupUIController>>(ref this.EventOnWatchGroupStaffButtonClick, (Action<FriendGroupUIController>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1400031D RID: 797
		// (add) Token: 0x0600EC3C RID: 60476 RVA: 0x003F20AC File Offset: 0x003F02AC
		// (remove) Token: 0x0600EC3D RID: 60477 RVA: 0x003F2148 File Offset: 0x003F0348
		public event Action<FriendGroupUIController> EventOnChatButtonClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnChatButtonClickAction`1_hotfix != null)
				{
					this.m_add_EventOnChatButtonClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<FriendGroupUIController> action = this.EventOnChatButtonClick;
				Action<FriendGroupUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<FriendGroupUIController>>(ref this.EventOnChatButtonClick, (Action<FriendGroupUIController>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnChatButtonClickAction`1_hotfix != null)
				{
					this.m_remove_EventOnChatButtonClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<FriendGroupUIController> action = this.EventOnChatButtonClick;
				Action<FriendGroupUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<FriendGroupUIController>>(ref this.EventOnChatButtonClick, (Action<FriendGroupUIController>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17002DA5 RID: 11685
		// (get) Token: 0x0600EC3E RID: 60478 RVA: 0x003F21E4 File Offset: 0x003F03E4
		// (set) Token: 0x0600EC3F RID: 60479 RVA: 0x003F2204 File Offset: 0x003F0404
		[DoNotToLua]
		public new FriendGroupUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new FriendGroupUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600EC40 RID: 60480 RVA: 0x003F2210 File Offset: 0x003F0410
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0600EC41 RID: 60481 RVA: 0x003F221C File Offset: 0x003F041C
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0600EC42 RID: 60482 RVA: 0x003F2224 File Offset: 0x003F0424
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0600EC43 RID: 60483 RVA: 0x003F222C File Offset: 0x003F042C
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0600EC44 RID: 60484 RVA: 0x003F2240 File Offset: 0x003F0440
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0600EC45 RID: 60485 RVA: 0x003F2248 File Offset: 0x003F0448
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0600EC46 RID: 60486 RVA: 0x003F2254 File Offset: 0x003F0454
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0600EC47 RID: 60487 RVA: 0x003F2260 File Offset: 0x003F0460
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0600EC48 RID: 60488 RVA: 0x003F226C File Offset: 0x003F046C
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0600EC49 RID: 60489 RVA: 0x003F2278 File Offset: 0x003F0478
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0600EC4A RID: 60490 RVA: 0x003F2284 File Offset: 0x003F0484
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0600EC4B RID: 60491 RVA: 0x003F2290 File Offset: 0x003F0490
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0600EC4C RID: 60492 RVA: 0x003F229C File Offset: 0x003F049C
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0600EC4D RID: 60493 RVA: 0x003F22A8 File Offset: 0x003F04A8
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0600EC4E RID: 60494 RVA: 0x003F22B4 File Offset: 0x003F04B4
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600EC4F RID: 60495 RVA: 0x003F22BC File Offset: 0x003F04BC
		private void __callDele_EventOnWatchGroupStaffButtonClick(FriendGroupUIController obj)
		{
			Action<FriendGroupUIController> eventOnWatchGroupStaffButtonClick = this.EventOnWatchGroupStaffButtonClick;
			if (eventOnWatchGroupStaffButtonClick != null)
			{
				eventOnWatchGroupStaffButtonClick(obj);
			}
		}

		// Token: 0x0600EC50 RID: 60496 RVA: 0x003F22E0 File Offset: 0x003F04E0
		private void __clearDele_EventOnWatchGroupStaffButtonClick(FriendGroupUIController obj)
		{
			this.EventOnWatchGroupStaffButtonClick = null;
		}

		// Token: 0x0600EC51 RID: 60497 RVA: 0x003F22EC File Offset: 0x003F04EC
		private void __callDele_EventOnChatButtonClick(FriendGroupUIController obj)
		{
			Action<FriendGroupUIController> eventOnChatButtonClick = this.EventOnChatButtonClick;
			if (eventOnChatButtonClick != null)
			{
				eventOnChatButtonClick(obj);
			}
		}

		// Token: 0x0600EC52 RID: 60498 RVA: 0x003F2310 File Offset: 0x003F0510
		private void __clearDele_EventOnChatButtonClick(FriendGroupUIController obj)
		{
			this.EventOnChatButtonClick = null;
		}

		// Token: 0x0600EC53 RID: 60499 RVA: 0x003F231C File Offset: 0x003F051C
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
					this.m_SetGroupInfoProChatGroupCompactInfo_hotfix = (luaObj.RawGet("SetGroupInfo") as LuaFunction);
					this.m_GetGroupInfo_hotfix = (luaObj.RawGet("GetGroupInfo") as LuaFunction);
					this.m_OnChatButtonClick_hotfix = (luaObj.RawGet("OnChatButtonClick") as LuaFunction);
					this.m_OnWatchStaffButtonClick_hotfix = (luaObj.RawGet("OnWatchStaffButtonClick") as LuaFunction);
					this.m_add_EventOnWatchGroupStaffButtonClickAction`1_hotfix = (luaObj.RawGet("add_EventOnWatchGroupStaffButtonClick") as LuaFunction);
					this.m_remove_EventOnWatchGroupStaffButtonClickAction`1_hotfix = (luaObj.RawGet("remove_EventOnWatchGroupStaffButtonClick") as LuaFunction);
					this.m_add_EventOnChatButtonClickAction`1_hotfix = (luaObj.RawGet("add_EventOnChatButtonClick") as LuaFunction);
					this.m_remove_EventOnChatButtonClickAction`1_hotfix = (luaObj.RawGet("remove_EventOnChatButtonClick") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600EC54 RID: 60500 RVA: 0x003F24B0 File Offset: 0x003F06B0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(FriendGroupUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04008D66 RID: 36198
		[AutoBind("./GroupIconImage", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_groupIconImage;

		// Token: 0x04008D67 RID: 36199
		[AutoBind("./GroupIconImage/HeadFrameDummy", AutoBindAttribute.InitState.NotInit, false)]
		private Transform m_groupHeadFrameTransform;

		// Token: 0x04008D68 RID: 36200
		[AutoBind("./ChatButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_chatButton;

		// Token: 0x04008D69 RID: 36201
		[AutoBind("./WatchStaffButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_watchStaffButton;

		// Token: 0x04008D6A RID: 36202
		[AutoBind("./StateGroup/OnLineText2", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_onlinePlayerNumText;

		// Token: 0x04008D6B RID: 36203
		[AutoBind("./GroupNameText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_groupNameText;

		// Token: 0x04008D6C RID: 36204
		private IConfigDataLoader m_configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;

		// Token: 0x04008D6D RID: 36205
		private ProChatGroupCompactInfo m_groupInfo;

		// Token: 0x04008D6E RID: 36206
		[DoNotToLua]
		private FriendGroupUIController.LuaExportHelper luaExportHelper;

		// Token: 0x04008D6F RID: 36207
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04008D70 RID: 36208
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04008D71 RID: 36209
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x04008D72 RID: 36210
		private LuaFunction m_SetGroupInfoProChatGroupCompactInfo_hotfix;

		// Token: 0x04008D73 RID: 36211
		private LuaFunction m_GetGroupInfo_hotfix;

		// Token: 0x04008D74 RID: 36212
		private LuaFunction m_OnChatButtonClick_hotfix;

		// Token: 0x04008D75 RID: 36213
		private LuaFunction m_OnWatchStaffButtonClick_hotfix;

		// Token: 0x04008D76 RID: 36214
		private LuaFunction m_add_EventOnWatchGroupStaffButtonClickAction;

		// Token: 0x04008D77 RID: 36215
		private LuaFunction m_remove_EventOnWatchGroupStaffButtonClickAction;

		// Token: 0x04008D78 RID: 36216
		private LuaFunction m_add_EventOnChatButtonClickAction;

		// Token: 0x04008D79 RID: 36217
		private LuaFunction m_remove_EventOnChatButtonClickAction;

		// Token: 0x02000CB9 RID: 3257
		public new class LuaExportHelper
		{
			// Token: 0x0600EC55 RID: 60501 RVA: 0x003F2518 File Offset: 0x003F0718
			public LuaExportHelper(FriendGroupUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600EC56 RID: 60502 RVA: 0x003F2528 File Offset: 0x003F0728
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0600EC57 RID: 60503 RVA: 0x003F2538 File Offset: 0x003F0738
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0600EC58 RID: 60504 RVA: 0x003F2548 File Offset: 0x003F0748
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600EC59 RID: 60505 RVA: 0x003F2558 File Offset: 0x003F0758
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600EC5A RID: 60506 RVA: 0x003F2570 File Offset: 0x003F0770
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0600EC5B RID: 60507 RVA: 0x003F2580 File Offset: 0x003F0780
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0600EC5C RID: 60508 RVA: 0x003F2590 File Offset: 0x003F0790
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0600EC5D RID: 60509 RVA: 0x003F25A0 File Offset: 0x003F07A0
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0600EC5E RID: 60510 RVA: 0x003F25B0 File Offset: 0x003F07B0
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0600EC5F RID: 60511 RVA: 0x003F25C0 File Offset: 0x003F07C0
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0600EC60 RID: 60512 RVA: 0x003F25D0 File Offset: 0x003F07D0
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0600EC61 RID: 60513 RVA: 0x003F25E0 File Offset: 0x003F07E0
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0600EC62 RID: 60514 RVA: 0x003F25F0 File Offset: 0x003F07F0
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0600EC63 RID: 60515 RVA: 0x003F2600 File Offset: 0x003F0800
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0600EC64 RID: 60516 RVA: 0x003F2610 File Offset: 0x003F0810
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x0600EC65 RID: 60517 RVA: 0x003F2620 File Offset: 0x003F0820
			public void __callDele_EventOnWatchGroupStaffButtonClick(FriendGroupUIController obj)
			{
				this.m_owner.__callDele_EventOnWatchGroupStaffButtonClick(obj);
			}

			// Token: 0x0600EC66 RID: 60518 RVA: 0x003F2630 File Offset: 0x003F0830
			public void __clearDele_EventOnWatchGroupStaffButtonClick(FriendGroupUIController obj)
			{
				this.m_owner.__clearDele_EventOnWatchGroupStaffButtonClick(obj);
			}

			// Token: 0x0600EC67 RID: 60519 RVA: 0x003F2640 File Offset: 0x003F0840
			public void __callDele_EventOnChatButtonClick(FriendGroupUIController obj)
			{
				this.m_owner.__callDele_EventOnChatButtonClick(obj);
			}

			// Token: 0x0600EC68 RID: 60520 RVA: 0x003F2650 File Offset: 0x003F0850
			public void __clearDele_EventOnChatButtonClick(FriendGroupUIController obj)
			{
				this.m_owner.__clearDele_EventOnChatButtonClick(obj);
			}

			// Token: 0x17002DA6 RID: 11686
			// (get) Token: 0x0600EC69 RID: 60521 RVA: 0x003F2660 File Offset: 0x003F0860
			// (set) Token: 0x0600EC6A RID: 60522 RVA: 0x003F2670 File Offset: 0x003F0870
			public Image m_groupIconImage
			{
				get
				{
					return this.m_owner.m_groupIconImage;
				}
				set
				{
					this.m_owner.m_groupIconImage = value;
				}
			}

			// Token: 0x17002DA7 RID: 11687
			// (get) Token: 0x0600EC6B RID: 60523 RVA: 0x003F2680 File Offset: 0x003F0880
			// (set) Token: 0x0600EC6C RID: 60524 RVA: 0x003F2690 File Offset: 0x003F0890
			public Transform m_groupHeadFrameTransform
			{
				get
				{
					return this.m_owner.m_groupHeadFrameTransform;
				}
				set
				{
					this.m_owner.m_groupHeadFrameTransform = value;
				}
			}

			// Token: 0x17002DA8 RID: 11688
			// (get) Token: 0x0600EC6D RID: 60525 RVA: 0x003F26A0 File Offset: 0x003F08A0
			// (set) Token: 0x0600EC6E RID: 60526 RVA: 0x003F26B0 File Offset: 0x003F08B0
			public Button m_chatButton
			{
				get
				{
					return this.m_owner.m_chatButton;
				}
				set
				{
					this.m_owner.m_chatButton = value;
				}
			}

			// Token: 0x17002DA9 RID: 11689
			// (get) Token: 0x0600EC6F RID: 60527 RVA: 0x003F26C0 File Offset: 0x003F08C0
			// (set) Token: 0x0600EC70 RID: 60528 RVA: 0x003F26D0 File Offset: 0x003F08D0
			public Button m_watchStaffButton
			{
				get
				{
					return this.m_owner.m_watchStaffButton;
				}
				set
				{
					this.m_owner.m_watchStaffButton = value;
				}
			}

			// Token: 0x17002DAA RID: 11690
			// (get) Token: 0x0600EC71 RID: 60529 RVA: 0x003F26E0 File Offset: 0x003F08E0
			// (set) Token: 0x0600EC72 RID: 60530 RVA: 0x003F26F0 File Offset: 0x003F08F0
			public Text m_onlinePlayerNumText
			{
				get
				{
					return this.m_owner.m_onlinePlayerNumText;
				}
				set
				{
					this.m_owner.m_onlinePlayerNumText = value;
				}
			}

			// Token: 0x17002DAB RID: 11691
			// (get) Token: 0x0600EC73 RID: 60531 RVA: 0x003F2700 File Offset: 0x003F0900
			// (set) Token: 0x0600EC74 RID: 60532 RVA: 0x003F2710 File Offset: 0x003F0910
			public Text m_groupNameText
			{
				get
				{
					return this.m_owner.m_groupNameText;
				}
				set
				{
					this.m_owner.m_groupNameText = value;
				}
			}

			// Token: 0x17002DAC RID: 11692
			// (get) Token: 0x0600EC75 RID: 60533 RVA: 0x003F2720 File Offset: 0x003F0920
			// (set) Token: 0x0600EC76 RID: 60534 RVA: 0x003F2730 File Offset: 0x003F0930
			public IConfigDataLoader m_configDataLoader
			{
				get
				{
					return this.m_owner.m_configDataLoader;
				}
				set
				{
					this.m_owner.m_configDataLoader = value;
				}
			}

			// Token: 0x17002DAD RID: 11693
			// (get) Token: 0x0600EC77 RID: 60535 RVA: 0x003F2740 File Offset: 0x003F0940
			// (set) Token: 0x0600EC78 RID: 60536 RVA: 0x003F2750 File Offset: 0x003F0950
			public ProChatGroupCompactInfo m_groupInfo
			{
				get
				{
					return this.m_owner.m_groupInfo;
				}
				set
				{
					this.m_owner.m_groupInfo = value;
				}
			}

			// Token: 0x0600EC79 RID: 60537 RVA: 0x003F2760 File Offset: 0x003F0960
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0600EC7A RID: 60538 RVA: 0x003F2770 File Offset: 0x003F0970
			public void OnChatButtonClick()
			{
				this.m_owner.OnChatButtonClick();
			}

			// Token: 0x0600EC7B RID: 60539 RVA: 0x003F2780 File Offset: 0x003F0980
			public void OnWatchStaffButtonClick()
			{
				this.m_owner.OnWatchStaffButtonClick();
			}

			// Token: 0x04008D7A RID: 36218
			private FriendGroupUIController m_owner;
		}
	}
}
