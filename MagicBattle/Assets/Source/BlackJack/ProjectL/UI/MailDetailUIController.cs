using System;
using System.Collections.Generic;
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
	// Token: 0x02000E60 RID: 3680
	[HotFix]
	public class MailDetailUIController : UIControllerBase
	{
		// Token: 0x06011D54 RID: 73044 RVA: 0x0049C748 File Offset: 0x0049A948
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
			this.GetButton.onClick.AddListener(new UnityAction(this.OnGetAttachmentButtonClick));
			this.GotoButton.onClick.AddListener(new UnityAction(this.OnGotoButtonClick));
			this.ItemUICtrlPrefab = base.GetAssetInContainer<GameObject>("RewardGoods");
			this.m_playerContext = (GameManager.Instance.PlayerContext as ProjectLPlayerContext);
		}

		// Token: 0x06011D55 RID: 73045 RVA: 0x0049C80C File Offset: 0x0049AA0C
		public void UpdateMailDetail(Mail mailInfo, bool haveMail)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateMailDetailMailBoolean_hotfix != null)
			{
				this.m_UpdateMailDetailMailBoolean_hotfix.call(new object[]
				{
					this,
					mailInfo,
					haveMail
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_currentMailInfo = mailInfo;
			if (this.m_currentMailInfo != null && haveMail)
			{
				this.TitleText.text = mailInfo.Title;
				double mailExpiredTime = this.m_playerContext.GetMailExpiredTime(mailInfo);
				TimeSpan timeSpan = TimeSpan.FromSeconds(mailExpiredTime);
				string text = UIUtility.TimeSpanToString(timeSpan);
				this.TimeOutText.text = text;
				bool flag = this.m_playerContext.IsExistMailAttacments(mailInfo);
				bool flag2 = this.m_playerContext.HasGotMailAttachments(mailInfo);
				this.GetButton.gameObject.SetActive(flag);
				if (flag)
				{
					if (flag2)
					{
						this.BgUIState.SetToUIState("GetItem", false, true);
						this.GetButton.SetDisableState();
						this.GetButton.interactable = false;
					}
					else
					{
						this.BgUIState.SetToUIState("Normal", false, true);
						this.GetButton.SetNormalState();
						this.GetButton.interactable = true;
					}
					this.SmallContextText.text = mailInfo.Content;
				}
				else
				{
					this.BgUIState.SetToUIState("NoReward", false, true);
					this.ContextText.text = mailInfo.Content;
				}
				this.GotoButton.gameObject.SetActive(false);
				this.ShowAttachmentsUI(mailInfo);
			}
			else
			{
				this.BgUIState.SetToUIState("None", false, true);
				this.ChooseTextGo.SetActive(haveMail);
				this.NoneTextGo.SetActive(!haveMail);
			}
		}

		// Token: 0x06011D56 RID: 73046 RVA: 0x0049C9F0 File Offset: 0x0049ABF0
		private void ShowAttachmentsUI(Mail mailInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowAttachmentsUIMail_hotfix != null)
			{
				this.m_ShowAttachmentsUIMail_hotfix.call(new object[]
				{
					this,
					mailInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (RewardGoodsUIController rewardGoodsUIController in this.m_attachmentUICtrlList)
			{
				rewardGoodsUIController.gameObject.SetActive(false);
			}
			List<Goods> attachments = mailInfo.Attachments;
			if (attachments == null)
			{
				return;
			}
			for (int i = 0; i < attachments.Count; i++)
			{
				RewardGoodsUIController rewardGoodsUIController2;
				if (i >= this.m_attachmentUICtrlList.Count)
				{
					GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.ItemUICtrlPrefab);
					PrefabControllerCreater.CreateAllControllers(gameObject);
					gameObject.transform.SetParent(this.RewardRoot.transform, false);
					rewardGoodsUIController2 = GameObjectUtility.AddControllerToGameObject<RewardGoodsUIController>(gameObject);
					this.m_attachmentUICtrlList.Add(rewardGoodsUIController2);
				}
				else
				{
					rewardGoodsUIController2 = this.m_attachmentUICtrlList[i];
				}
				rewardGoodsUIController2.gameObject.SetActive(true);
				rewardGoodsUIController2.SetReward(attachments[i], 0, true);
			}
		}

		// Token: 0x06011D57 RID: 73047 RVA: 0x0049CB60 File Offset: 0x0049AD60
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
			if (this.EventOnGotoButtonClick != null)
			{
				this.EventOnGotoButtonClick(this.m_currentMailInfo);
			}
		}

		// Token: 0x06011D58 RID: 73048 RVA: 0x0049CBDC File Offset: 0x0049ADDC
		private void OnGetAttachmentButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnGetAttachmentButtonClick_hotfix != null)
			{
				this.m_OnGetAttachmentButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnGetAttachmentButtonClick != null)
			{
				this.EventOnGetAttachmentButtonClick(this.m_currentMailInfo);
			}
		}

		// Token: 0x140003D2 RID: 978
		// (add) Token: 0x06011D59 RID: 73049 RVA: 0x0049CC58 File Offset: 0x0049AE58
		// (remove) Token: 0x06011D5A RID: 73050 RVA: 0x0049CCF4 File Offset: 0x0049AEF4
		public event Action<Mail> EventOnGetAttachmentButtonClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnGetAttachmentButtonClickAction`1_hotfix != null)
				{
					this.m_add_EventOnGetAttachmentButtonClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<Mail> action = this.EventOnGetAttachmentButtonClick;
				Action<Mail> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<Mail>>(ref this.EventOnGetAttachmentButtonClick, (Action<Mail>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnGetAttachmentButtonClickAction`1_hotfix != null)
				{
					this.m_remove_EventOnGetAttachmentButtonClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<Mail> action = this.EventOnGetAttachmentButtonClick;
				Action<Mail> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<Mail>>(ref this.EventOnGetAttachmentButtonClick, (Action<Mail>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140003D3 RID: 979
		// (add) Token: 0x06011D5B RID: 73051 RVA: 0x0049CD90 File Offset: 0x0049AF90
		// (remove) Token: 0x06011D5C RID: 73052 RVA: 0x0049CE2C File Offset: 0x0049B02C
		public event Action<Mail> EventOnGotoButtonClick
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
				Action<Mail> action = this.EventOnGotoButtonClick;
				Action<Mail> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<Mail>>(ref this.EventOnGotoButtonClick, (Action<Mail>)Delegate.Combine(action2, value), action);
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
				Action<Mail> action = this.EventOnGotoButtonClick;
				Action<Mail> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<Mail>>(ref this.EventOnGotoButtonClick, (Action<Mail>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x170036AD RID: 13997
		// (get) Token: 0x06011D5D RID: 73053 RVA: 0x0049CEC8 File Offset: 0x0049B0C8
		// (set) Token: 0x06011D5E RID: 73054 RVA: 0x0049CEE8 File Offset: 0x0049B0E8
		[DoNotToLua]
		public new MailDetailUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new MailDetailUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06011D5F RID: 73055 RVA: 0x0049CEF4 File Offset: 0x0049B0F4
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x06011D60 RID: 73056 RVA: 0x0049CF00 File Offset: 0x0049B100
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x06011D61 RID: 73057 RVA: 0x0049CF08 File Offset: 0x0049B108
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x06011D62 RID: 73058 RVA: 0x0049CF10 File Offset: 0x0049B110
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x06011D63 RID: 73059 RVA: 0x0049CF24 File Offset: 0x0049B124
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x06011D64 RID: 73060 RVA: 0x0049CF2C File Offset: 0x0049B12C
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x06011D65 RID: 73061 RVA: 0x0049CF38 File Offset: 0x0049B138
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x06011D66 RID: 73062 RVA: 0x0049CF44 File Offset: 0x0049B144
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x06011D67 RID: 73063 RVA: 0x0049CF50 File Offset: 0x0049B150
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x06011D68 RID: 73064 RVA: 0x0049CF5C File Offset: 0x0049B15C
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x06011D69 RID: 73065 RVA: 0x0049CF68 File Offset: 0x0049B168
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x06011D6A RID: 73066 RVA: 0x0049CF74 File Offset: 0x0049B174
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x06011D6B RID: 73067 RVA: 0x0049CF80 File Offset: 0x0049B180
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x06011D6C RID: 73068 RVA: 0x0049CF8C File Offset: 0x0049B18C
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x06011D6D RID: 73069 RVA: 0x0049CF98 File Offset: 0x0049B198
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x06011D6E RID: 73070 RVA: 0x0049CFA0 File Offset: 0x0049B1A0
		private void __callDele_EventOnGetAttachmentButtonClick(Mail obj)
		{
			Action<Mail> eventOnGetAttachmentButtonClick = this.EventOnGetAttachmentButtonClick;
			if (eventOnGetAttachmentButtonClick != null)
			{
				eventOnGetAttachmentButtonClick(obj);
			}
		}

		// Token: 0x06011D6F RID: 73071 RVA: 0x0049CFC4 File Offset: 0x0049B1C4
		private void __clearDele_EventOnGetAttachmentButtonClick(Mail obj)
		{
			this.EventOnGetAttachmentButtonClick = null;
		}

		// Token: 0x06011D70 RID: 73072 RVA: 0x0049CFD0 File Offset: 0x0049B1D0
		private void __callDele_EventOnGotoButtonClick(Mail obj)
		{
			Action<Mail> eventOnGotoButtonClick = this.EventOnGotoButtonClick;
			if (eventOnGotoButtonClick != null)
			{
				eventOnGotoButtonClick(obj);
			}
		}

		// Token: 0x06011D71 RID: 73073 RVA: 0x0049CFF4 File Offset: 0x0049B1F4
		private void __clearDele_EventOnGotoButtonClick(Mail obj)
		{
			this.EventOnGotoButtonClick = null;
		}

		// Token: 0x06011D72 RID: 73074 RVA: 0x0049D000 File Offset: 0x0049B200
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
					this.m_UpdateMailDetailMailBoolean_hotfix = (luaObj.RawGet("UpdateMailDetail") as LuaFunction);
					this.m_ShowAttachmentsUIMail_hotfix = (luaObj.RawGet("ShowAttachmentsUI") as LuaFunction);
					this.m_OnGotoButtonClick_hotfix = (luaObj.RawGet("OnGotoButtonClick") as LuaFunction);
					this.m_OnGetAttachmentButtonClick_hotfix = (luaObj.RawGet("OnGetAttachmentButtonClick") as LuaFunction);
					this.m_add_EventOnGetAttachmentButtonClickAction`1_hotfix = (luaObj.RawGet("add_EventOnGetAttachmentButtonClick") as LuaFunction);
					this.m_remove_EventOnGetAttachmentButtonClickAction`1_hotfix = (luaObj.RawGet("remove_EventOnGetAttachmentButtonClick") as LuaFunction);
					this.m_add_EventOnGotoButtonClickAction`1_hotfix = (luaObj.RawGet("add_EventOnGotoButtonClick") as LuaFunction);
					this.m_remove_EventOnGotoButtonClickAction`1_hotfix = (luaObj.RawGet("remove_EventOnGotoButtonClick") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06011D73 RID: 73075 RVA: 0x0049D194 File Offset: 0x0049B394
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(MailDetailUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400A222 RID: 41506
		private Mail m_currentMailInfo;

		// Token: 0x0400A223 RID: 41507
		private ProjectLPlayerContext m_playerContext;

		// Token: 0x0400A224 RID: 41508
		private List<RewardGoodsUIController> m_attachmentUICtrlList = new List<RewardGoodsUIController>();

		// Token: 0x0400A227 RID: 41511
		private GameObject ItemUICtrlPrefab;

		// Token: 0x0400A228 RID: 41512
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		public CommonUIStateController BgUIState;

		// Token: 0x0400A229 RID: 41513
		[AutoBind("./MailDetail_Title/Text", AutoBindAttribute.InitState.NotInit, false)]
		public Text TitleText;

		// Token: 0x0400A22A RID: 41514
		[AutoBind("./TimeOutTextPanel/TimeOutText", AutoBindAttribute.InitState.NotInit, false)]
		public Text TimeOutText;

		// Token: 0x0400A22B RID: 41515
		[AutoBind("./MailDetail/ListScrollView/Viewport/Content/Text", AutoBindAttribute.InitState.NotInit, false)]
		public Text ContextText;

		// Token: 0x0400A22C RID: 41516
		[AutoBind("./MailDetail/ListScrollViewSmall/Viewport/Content/Text", AutoBindAttribute.InitState.NotInit, false)]
		public Text SmallContextText;

		// Token: 0x0400A22D RID: 41517
		[AutoBind("./MailDetail/RewardItem/Content", AutoBindAttribute.InitState.NotInit, false)]
		public GameObject RewardRoot;

		// Token: 0x0400A22E RID: 41518
		[AutoBind("./MailDetail/GetButton", AutoBindAttribute.InitState.NotInit, false)]
		public ButtonEx GetButton;

		// Token: 0x0400A22F RID: 41519
		[AutoBind("./MailDetail/GotoButton", AutoBindAttribute.InitState.NotInit, false)]
		public Button GotoButton;

		// Token: 0x0400A230 RID: 41520
		[AutoBind("./NoMailPanel/ChooseText", AutoBindAttribute.InitState.NotInit, false)]
		public GameObject ChooseTextGo;

		// Token: 0x0400A231 RID: 41521
		[AutoBind("./NoMailPanel/NoneText", AutoBindAttribute.InitState.NotInit, false)]
		public GameObject NoneTextGo;

		// Token: 0x0400A232 RID: 41522
		[DoNotToLua]
		private MailDetailUIController.LuaExportHelper luaExportHelper;

		// Token: 0x0400A233 RID: 41523
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400A234 RID: 41524
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400A235 RID: 41525
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x0400A236 RID: 41526
		private LuaFunction m_UpdateMailDetailMailBoolean_hotfix;

		// Token: 0x0400A237 RID: 41527
		private LuaFunction m_ShowAttachmentsUIMail_hotfix;

		// Token: 0x0400A238 RID: 41528
		private LuaFunction m_OnGotoButtonClick_hotfix;

		// Token: 0x0400A239 RID: 41529
		private LuaFunction m_OnGetAttachmentButtonClick_hotfix;

		// Token: 0x0400A23A RID: 41530
		private LuaFunction m_add_EventOnGetAttachmentButtonClickAction;

		// Token: 0x0400A23B RID: 41531
		private LuaFunction m_remove_EventOnGetAttachmentButtonClickAction;

		// Token: 0x0400A23C RID: 41532
		private LuaFunction m_add_EventOnGotoButtonClickAction;

		// Token: 0x0400A23D RID: 41533
		private LuaFunction m_remove_EventOnGotoButtonClickAction;

		// Token: 0x02000E61 RID: 3681
		public new class LuaExportHelper
		{
			// Token: 0x06011D74 RID: 73076 RVA: 0x0049D1FC File Offset: 0x0049B3FC
			public LuaExportHelper(MailDetailUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06011D75 RID: 73077 RVA: 0x0049D20C File Offset: 0x0049B40C
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x06011D76 RID: 73078 RVA: 0x0049D21C File Offset: 0x0049B41C
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x06011D77 RID: 73079 RVA: 0x0049D22C File Offset: 0x0049B42C
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x06011D78 RID: 73080 RVA: 0x0049D23C File Offset: 0x0049B43C
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x06011D79 RID: 73081 RVA: 0x0049D254 File Offset: 0x0049B454
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x06011D7A RID: 73082 RVA: 0x0049D264 File Offset: 0x0049B464
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x06011D7B RID: 73083 RVA: 0x0049D274 File Offset: 0x0049B474
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x06011D7C RID: 73084 RVA: 0x0049D284 File Offset: 0x0049B484
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x06011D7D RID: 73085 RVA: 0x0049D294 File Offset: 0x0049B494
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x06011D7E RID: 73086 RVA: 0x0049D2A4 File Offset: 0x0049B4A4
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x06011D7F RID: 73087 RVA: 0x0049D2B4 File Offset: 0x0049B4B4
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x06011D80 RID: 73088 RVA: 0x0049D2C4 File Offset: 0x0049B4C4
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x06011D81 RID: 73089 RVA: 0x0049D2D4 File Offset: 0x0049B4D4
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x06011D82 RID: 73090 RVA: 0x0049D2E4 File Offset: 0x0049B4E4
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x06011D83 RID: 73091 RVA: 0x0049D2F4 File Offset: 0x0049B4F4
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x06011D84 RID: 73092 RVA: 0x0049D304 File Offset: 0x0049B504
			public void __callDele_EventOnGetAttachmentButtonClick(Mail obj)
			{
				this.m_owner.__callDele_EventOnGetAttachmentButtonClick(obj);
			}

			// Token: 0x06011D85 RID: 73093 RVA: 0x0049D314 File Offset: 0x0049B514
			public void __clearDele_EventOnGetAttachmentButtonClick(Mail obj)
			{
				this.m_owner.__clearDele_EventOnGetAttachmentButtonClick(obj);
			}

			// Token: 0x06011D86 RID: 73094 RVA: 0x0049D324 File Offset: 0x0049B524
			public void __callDele_EventOnGotoButtonClick(Mail obj)
			{
				this.m_owner.__callDele_EventOnGotoButtonClick(obj);
			}

			// Token: 0x06011D87 RID: 73095 RVA: 0x0049D334 File Offset: 0x0049B534
			public void __clearDele_EventOnGotoButtonClick(Mail obj)
			{
				this.m_owner.__clearDele_EventOnGotoButtonClick(obj);
			}

			// Token: 0x170036AE RID: 13998
			// (get) Token: 0x06011D88 RID: 73096 RVA: 0x0049D344 File Offset: 0x0049B544
			// (set) Token: 0x06011D89 RID: 73097 RVA: 0x0049D354 File Offset: 0x0049B554
			public Mail m_currentMailInfo
			{
				get
				{
					return this.m_owner.m_currentMailInfo;
				}
				set
				{
					this.m_owner.m_currentMailInfo = value;
				}
			}

			// Token: 0x170036AF RID: 13999
			// (get) Token: 0x06011D8A RID: 73098 RVA: 0x0049D364 File Offset: 0x0049B564
			// (set) Token: 0x06011D8B RID: 73099 RVA: 0x0049D374 File Offset: 0x0049B574
			public ProjectLPlayerContext m_playerContext
			{
				get
				{
					return this.m_owner.m_playerContext;
				}
				set
				{
					this.m_owner.m_playerContext = value;
				}
			}

			// Token: 0x170036B0 RID: 14000
			// (get) Token: 0x06011D8C RID: 73100 RVA: 0x0049D384 File Offset: 0x0049B584
			// (set) Token: 0x06011D8D RID: 73101 RVA: 0x0049D394 File Offset: 0x0049B594
			public List<RewardGoodsUIController> m_attachmentUICtrlList
			{
				get
				{
					return this.m_owner.m_attachmentUICtrlList;
				}
				set
				{
					this.m_owner.m_attachmentUICtrlList = value;
				}
			}

			// Token: 0x170036B1 RID: 14001
			// (get) Token: 0x06011D8E RID: 73102 RVA: 0x0049D3A4 File Offset: 0x0049B5A4
			// (set) Token: 0x06011D8F RID: 73103 RVA: 0x0049D3B4 File Offset: 0x0049B5B4
			public GameObject ItemUICtrlPrefab
			{
				get
				{
					return this.m_owner.ItemUICtrlPrefab;
				}
				set
				{
					this.m_owner.ItemUICtrlPrefab = value;
				}
			}

			// Token: 0x06011D90 RID: 73104 RVA: 0x0049D3C4 File Offset: 0x0049B5C4
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x06011D91 RID: 73105 RVA: 0x0049D3D4 File Offset: 0x0049B5D4
			public void ShowAttachmentsUI(Mail mailInfo)
			{
				this.m_owner.ShowAttachmentsUI(mailInfo);
			}

			// Token: 0x06011D92 RID: 73106 RVA: 0x0049D3E4 File Offset: 0x0049B5E4
			public void OnGotoButtonClick()
			{
				this.m_owner.OnGotoButtonClick();
			}

			// Token: 0x06011D93 RID: 73107 RVA: 0x0049D3F4 File Offset: 0x0049B5F4
			public void OnGetAttachmentButtonClick()
			{
				this.m_owner.OnGetAttachmentButtonClick();
			}

			// Token: 0x0400A23E RID: 41534
			private MailDetailUIController m_owner;
		}
	}
}
