using System;
using System.Collections.Generic;
using System.Threading;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000E64 RID: 3684
	[HotFix]
	public class MailListUIController : UIControllerBase
	{
		// Token: 0x06011DC8 RID: 73160 RVA: 0x0049DC70 File Offset: 0x0049BE70
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
			PrefabControllerCreater.CreateAllControllers(this.m_mailDetailGo);
			this.m_mailDetailUICtrl = this.m_mailDetailGo.GetComponent<MailDetailUIController>();
			this.m_listScrollRect.onValueChanged.AddListener(delegate(Vector2 vector2)
			{
				RectTransform component = this.m_mailListPointBgContent.GetComponent<RectTransform>();
				RectTransform component2 = this.m_mailListContent.GetComponent<RectTransform>();
				component.anchoredPosition = component2.anchoredPosition;
			});
			this.m_closeButton.onClick.AddListener(new UnityAction(this.OnCloseButtonClick));
			this.m_bgButton.onClick.AddListener(new UnityAction(this.OnCloseButtonClick));
			this.m_getAllButton.onClick.AddListener(new UnityAction(this.OnGetAllButtonClick));
		}

		// Token: 0x06011DC9 RID: 73161 RVA: 0x0049DD64 File Offset: 0x0049BF64
		public void Open()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Open_hotfix != null)
			{
				this.m_Open_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetUIStateOpen(this.m_stateCtrl, "Show", null, false, true);
		}

		// Token: 0x06011DCA RID: 73162 RVA: 0x0049DDD8 File Offset: 0x0049BFD8
		public void UpdateMailInfoList(List<Mail> mailInfoList, Mail selectedMail = null, bool needReSetScrollView = false)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateMailInfoListList`1MailBoolean_hotfix != null)
			{
				this.m_UpdateMailInfoListList`1MailBoolean_hotfix.call(new object[]
				{
					this,
					mailInfoList,
					selectedMail,
					needReSetScrollView
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (MailItemUIController mailItemUIController in this.m_itemUICtrlList)
			{
				mailItemUIController.gameObject.SetActive(false);
			}
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			for (int i = 0; i < mailInfoList.Count; i++)
			{
				Mail mail = mailInfoList[i];
				MailItemUIController mailItemUIController2;
				if (i >= this.m_itemUICtrlList.Count)
				{
					GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.m_mailItemPrefab);
					PrefabControllerCreater.CreateAllControllers(gameObject);
					gameObject.transform.SetParent(this.m_mailItemPrefab.transform.parent, false);
					mailItemUIController2 = gameObject.GetComponent<MailItemUIController>();
					mailItemUIController2.EventOnMailItemButtonClick += this.OnMailItemButtonClick;
					this.m_itemUICtrlList.Add(mailItemUIController2);
				}
				else
				{
					mailItemUIController2 = this.m_itemUICtrlList[i];
				}
				mailItemUIController2.UpdateMailInfo(mail, mail == selectedMail);
			}
			int num = projectLPlayerContext.CanAutoGetMailAttachment();
			this.m_getAllButton.gameObject.SetActive(num == 0 || num == -500);
			if (needReSetScrollView)
			{
				this.ReSetScrollViewToTop();
			}
			int num2 = 6;
			if (this.m_mailListPointBgContent.transform.childCount >= mailInfoList.Count + num2)
			{
				UIUtility.SetGameObjectChildrenActiveCount(this.m_mailListPointBgContent, mailInfoList.Count + num2);
			}
			else
			{
				List<GameObject> list = new List<GameObject>();
				int num3 = mailInfoList.Count - this.m_mailListPointBgContent.transform.childCount + num2;
				for (int j = 0; j < num3; j++)
				{
					GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.m_mailListPointItem);
					gameObject2.SetActive(true);
					gameObject2.transform.SetParent(this.m_mailListPointBgContent.transform, false);
					list.Add(gameObject2);
				}
			}
		}

		// Token: 0x06011DCB RID: 73163 RVA: 0x0049E060 File Offset: 0x0049C260
		public void ReSetScrollViewToTop()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ReSetScrollViewToTop_hotfix != null)
			{
				this.m_ReSetScrollViewToTop_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_listScrollRect.normalizedPosition = Vector2.one;
		}

		// Token: 0x06011DCC RID: 73164 RVA: 0x0049E0D0 File Offset: 0x0049C2D0
		public void UpdateCurrentSelectedMailDetail(Mail mailInfo, bool listIsEmpty)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateCurrentSelectedMailDetailMailBoolean_hotfix != null)
			{
				this.m_UpdateCurrentSelectedMailDetailMailBoolean_hotfix.call(new object[]
				{
					this,
					mailInfo,
					listIsEmpty
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_mailDetailUICtrl.UpdateMailDetail(mailInfo, !listIsEmpty);
		}

		// Token: 0x06011DCD RID: 73165 RVA: 0x0049E160 File Offset: 0x0049C360
		private void OnMailItemButtonClick(MailItemUIController obj)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnMailItemButtonClickMailItemUIController_hotfix != null)
			{
				this.m_OnMailItemButtonClickMailItemUIController_hotfix.call(new object[]
				{
					this,
					obj
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_curMailItemCtrl != obj)
			{
				this.m_curMailItemCtrl = obj;
			}
			if (this.EventOnMailItemButtonClick != null)
			{
				this.EventOnMailItemButtonClick(obj.CurrentMailInfo);
			}
		}

		// Token: 0x06011DCE RID: 73166 RVA: 0x0049E204 File Offset: 0x0049C404
		private void OnCloseButtonClick()
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
			UIUtility.SetUIStateClose(this.m_stateCtrl, "Close", delegate
			{
				if (this.EventOnCloseButtonClick != null)
				{
					this.EventOnCloseButtonClick();
				}
				this.m_curMailItemCtrl = null;
			}, false, true);
		}

		// Token: 0x06011DCF RID: 73167 RVA: 0x0049E284 File Offset: 0x0049C484
		private void OnGetAllButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnGetAllButtonClick_hotfix != null)
			{
				this.m_OnGetAllButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnGetAllAttachments != null)
			{
				this.EventOnGetAllAttachments();
			}
		}

		// Token: 0x140003D5 RID: 981
		// (add) Token: 0x06011DD0 RID: 73168 RVA: 0x0049E2FC File Offset: 0x0049C4FC
		// (remove) Token: 0x06011DD1 RID: 73169 RVA: 0x0049E398 File Offset: 0x0049C598
		public event Action<Mail> EventOnMailItemButtonClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnMailItemButtonClickAction`1_hotfix != null)
				{
					this.m_add_EventOnMailItemButtonClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<Mail> action = this.EventOnMailItemButtonClick;
				Action<Mail> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<Mail>>(ref this.EventOnMailItemButtonClick, (Action<Mail>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnMailItemButtonClickAction`1_hotfix != null)
				{
					this.m_remove_EventOnMailItemButtonClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<Mail> action = this.EventOnMailItemButtonClick;
				Action<Mail> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<Mail>>(ref this.EventOnMailItemButtonClick, (Action<Mail>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140003D6 RID: 982
		// (add) Token: 0x06011DD2 RID: 73170 RVA: 0x0049E434 File Offset: 0x0049C634
		// (remove) Token: 0x06011DD3 RID: 73171 RVA: 0x0049E4D0 File Offset: 0x0049C6D0
		public event Action EventOnCloseButtonClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnCloseButtonClickAction_hotfix != null)
				{
					this.m_add_EventOnCloseButtonClickAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnCloseButtonClick;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnCloseButtonClick, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnCloseButtonClickAction_hotfix != null)
				{
					this.m_remove_EventOnCloseButtonClickAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnCloseButtonClick;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnCloseButtonClick, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140003D7 RID: 983
		// (add) Token: 0x06011DD4 RID: 73172 RVA: 0x0049E56C File Offset: 0x0049C76C
		// (remove) Token: 0x06011DD5 RID: 73173 RVA: 0x0049E608 File Offset: 0x0049C808
		public event Action EventOnGetAllAttachments
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnGetAllAttachmentsAction_hotfix != null)
				{
					this.m_add_EventOnGetAllAttachmentsAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnGetAllAttachments;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnGetAllAttachments, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnGetAllAttachmentsAction_hotfix != null)
				{
					this.m_remove_EventOnGetAllAttachmentsAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnGetAllAttachments;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnGetAllAttachments, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x170036B4 RID: 14004
		// (get) Token: 0x06011DD6 RID: 73174 RVA: 0x0049E6A4 File Offset: 0x0049C8A4
		// (set) Token: 0x06011DD7 RID: 73175 RVA: 0x0049E6C4 File Offset: 0x0049C8C4
		[DoNotToLua]
		public new MailListUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new MailListUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06011DD8 RID: 73176 RVA: 0x0049E6D0 File Offset: 0x0049C8D0
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x06011DD9 RID: 73177 RVA: 0x0049E6DC File Offset: 0x0049C8DC
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x06011DDA RID: 73178 RVA: 0x0049E6E4 File Offset: 0x0049C8E4
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x06011DDB RID: 73179 RVA: 0x0049E6EC File Offset: 0x0049C8EC
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x06011DDC RID: 73180 RVA: 0x0049E700 File Offset: 0x0049C900
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x06011DDD RID: 73181 RVA: 0x0049E708 File Offset: 0x0049C908
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x06011DDE RID: 73182 RVA: 0x0049E714 File Offset: 0x0049C914
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x06011DDF RID: 73183 RVA: 0x0049E720 File Offset: 0x0049C920
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x06011DE0 RID: 73184 RVA: 0x0049E72C File Offset: 0x0049C92C
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x06011DE1 RID: 73185 RVA: 0x0049E738 File Offset: 0x0049C938
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x06011DE2 RID: 73186 RVA: 0x0049E744 File Offset: 0x0049C944
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x06011DE3 RID: 73187 RVA: 0x0049E750 File Offset: 0x0049C950
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x06011DE4 RID: 73188 RVA: 0x0049E75C File Offset: 0x0049C95C
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x06011DE5 RID: 73189 RVA: 0x0049E768 File Offset: 0x0049C968
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x06011DE6 RID: 73190 RVA: 0x0049E774 File Offset: 0x0049C974
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x06011DE7 RID: 73191 RVA: 0x0049E77C File Offset: 0x0049C97C
		private void __callDele_EventOnMailItemButtonClick(Mail obj)
		{
			Action<Mail> eventOnMailItemButtonClick = this.EventOnMailItemButtonClick;
			if (eventOnMailItemButtonClick != null)
			{
				eventOnMailItemButtonClick(obj);
			}
		}

		// Token: 0x06011DE8 RID: 73192 RVA: 0x0049E7A0 File Offset: 0x0049C9A0
		private void __clearDele_EventOnMailItemButtonClick(Mail obj)
		{
			this.EventOnMailItemButtonClick = null;
		}

		// Token: 0x06011DE9 RID: 73193 RVA: 0x0049E7AC File Offset: 0x0049C9AC
		private void __callDele_EventOnCloseButtonClick()
		{
			Action eventOnCloseButtonClick = this.EventOnCloseButtonClick;
			if (eventOnCloseButtonClick != null)
			{
				eventOnCloseButtonClick();
			}
		}

		// Token: 0x06011DEA RID: 73194 RVA: 0x0049E7CC File Offset: 0x0049C9CC
		private void __clearDele_EventOnCloseButtonClick()
		{
			this.EventOnCloseButtonClick = null;
		}

		// Token: 0x06011DEB RID: 73195 RVA: 0x0049E7D8 File Offset: 0x0049C9D8
		private void __callDele_EventOnGetAllAttachments()
		{
			Action eventOnGetAllAttachments = this.EventOnGetAllAttachments;
			if (eventOnGetAllAttachments != null)
			{
				eventOnGetAllAttachments();
			}
		}

		// Token: 0x06011DEC RID: 73196 RVA: 0x0049E7F8 File Offset: 0x0049C9F8
		private void __clearDele_EventOnGetAllAttachments()
		{
			this.EventOnGetAllAttachments = null;
		}

		// Token: 0x06011DEF RID: 73199 RVA: 0x0049E858 File Offset: 0x0049CA58
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
					this.m_Open_hotfix = (luaObj.RawGet("Open") as LuaFunction);
					this.m_UpdateMailInfoListList`1MailBoolean_hotfix = (luaObj.RawGet("UpdateMailInfoList") as LuaFunction);
					this.m_ReSetScrollViewToTop_hotfix = (luaObj.RawGet("ReSetScrollViewToTop") as LuaFunction);
					this.m_UpdateCurrentSelectedMailDetailMailBoolean_hotfix = (luaObj.RawGet("UpdateCurrentSelectedMailDetail") as LuaFunction);
					this.m_OnMailItemButtonClickMailItemUIController_hotfix = (luaObj.RawGet("OnMailItemButtonClick") as LuaFunction);
					this.m_OnCloseButtonClick_hotfix = (luaObj.RawGet("OnCloseButtonClick") as LuaFunction);
					this.m_OnGetAllButtonClick_hotfix = (luaObj.RawGet("OnGetAllButtonClick") as LuaFunction);
					this.m_add_EventOnMailItemButtonClickAction`1_hotfix = (luaObj.RawGet("add_EventOnMailItemButtonClick") as LuaFunction);
					this.m_remove_EventOnMailItemButtonClickAction`1_hotfix = (luaObj.RawGet("remove_EventOnMailItemButtonClick") as LuaFunction);
					this.m_add_EventOnCloseButtonClickAction_hotfix = (luaObj.RawGet("add_EventOnCloseButtonClick") as LuaFunction);
					this.m_remove_EventOnCloseButtonClickAction_hotfix = (luaObj.RawGet("remove_EventOnCloseButtonClick") as LuaFunction);
					this.m_add_EventOnGetAllAttachmentsAction_hotfix = (luaObj.RawGet("add_EventOnGetAllAttachments") as LuaFunction);
					this.m_remove_EventOnGetAllAttachmentsAction_hotfix = (luaObj.RawGet("remove_EventOnGetAllAttachments") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06011DF0 RID: 73200 RVA: 0x0049EA68 File Offset: 0x0049CC68
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(MailListUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400A251 RID: 41553
		private List<MailItemUIController> m_itemUICtrlList = new List<MailItemUIController>();

		// Token: 0x0400A252 RID: 41554
		public MailDetailUIController m_mailDetailUICtrl;

		// Token: 0x0400A253 RID: 41555
		public MailItemUIController m_curMailItemCtrl;

		// Token: 0x0400A257 RID: 41559
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_stateCtrl;

		// Token: 0x0400A258 RID: 41560
		[AutoBind("./BGButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_bgButton;

		// Token: 0x0400A259 RID: 41561
		[AutoBind("./MailPanel/ListScrollView/Viewport/Content/MailItem", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_mailItemPrefab;

		// Token: 0x0400A25A RID: 41562
		[AutoBind("./MailPanel/MailDetailPanel", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_mailDetailGo;

		// Token: 0x0400A25B RID: 41563
		[AutoBind("./MailPanel/ListScrollView", AutoBindAttribute.InitState.NotInit, false)]
		private ScrollRect m_listScrollRect;

		// Token: 0x0400A25C RID: 41564
		[AutoBind("./MailPanel/ListScrollView/Viewport/Content", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_mailListContent;

		// Token: 0x0400A25D RID: 41565
		[AutoBind("./MailPanel/ListScrollView/BGViewport/BGContent", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_mailListPointBgContent;

		// Token: 0x0400A25E RID: 41566
		[AutoBind("./MailPanel/ListScrollView/BGViewport/BGContent/Point", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_mailListPointItem;

		// Token: 0x0400A25F RID: 41567
		[AutoBind("./MailPanel/CloseButton ", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_closeButton;

		// Token: 0x0400A260 RID: 41568
		[AutoBind("./MailPanel/GetAllButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_getAllButton;

		// Token: 0x0400A261 RID: 41569
		[DoNotToLua]
		private MailListUIController.LuaExportHelper luaExportHelper;

		// Token: 0x0400A262 RID: 41570
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400A263 RID: 41571
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400A264 RID: 41572
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x0400A265 RID: 41573
		private LuaFunction m_Open_hotfix;

		// Token: 0x0400A266 RID: 41574
		private LuaFunction m_UpdateMailInfoListList;

		// Token: 0x0400A267 RID: 41575
		private LuaFunction m_ReSetScrollViewToTop_hotfix;

		// Token: 0x0400A268 RID: 41576
		private LuaFunction m_UpdateCurrentSelectedMailDetailMailBoolean_hotfix;

		// Token: 0x0400A269 RID: 41577
		private LuaFunction m_OnMailItemButtonClickMailItemUIController_hotfix;

		// Token: 0x0400A26A RID: 41578
		private LuaFunction m_OnCloseButtonClick_hotfix;

		// Token: 0x0400A26B RID: 41579
		private LuaFunction m_OnGetAllButtonClick_hotfix;

		// Token: 0x0400A26C RID: 41580
		private LuaFunction m_add_EventOnMailItemButtonClickAction;

		// Token: 0x0400A26D RID: 41581
		private LuaFunction m_remove_EventOnMailItemButtonClickAction;

		// Token: 0x0400A26E RID: 41582
		private LuaFunction m_add_EventOnCloseButtonClickAction_hotfix;

		// Token: 0x0400A26F RID: 41583
		private LuaFunction m_remove_EventOnCloseButtonClickAction_hotfix;

		// Token: 0x0400A270 RID: 41584
		private LuaFunction m_add_EventOnGetAllAttachmentsAction_hotfix;

		// Token: 0x0400A271 RID: 41585
		private LuaFunction m_remove_EventOnGetAllAttachmentsAction_hotfix;

		// Token: 0x02000E65 RID: 3685
		public new class LuaExportHelper
		{
			// Token: 0x06011DF1 RID: 73201 RVA: 0x0049EAD0 File Offset: 0x0049CCD0
			public LuaExportHelper(MailListUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06011DF2 RID: 73202 RVA: 0x0049EAE0 File Offset: 0x0049CCE0
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x06011DF3 RID: 73203 RVA: 0x0049EAF0 File Offset: 0x0049CCF0
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x06011DF4 RID: 73204 RVA: 0x0049EB00 File Offset: 0x0049CD00
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x06011DF5 RID: 73205 RVA: 0x0049EB10 File Offset: 0x0049CD10
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x06011DF6 RID: 73206 RVA: 0x0049EB28 File Offset: 0x0049CD28
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x06011DF7 RID: 73207 RVA: 0x0049EB38 File Offset: 0x0049CD38
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x06011DF8 RID: 73208 RVA: 0x0049EB48 File Offset: 0x0049CD48
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x06011DF9 RID: 73209 RVA: 0x0049EB58 File Offset: 0x0049CD58
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x06011DFA RID: 73210 RVA: 0x0049EB68 File Offset: 0x0049CD68
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x06011DFB RID: 73211 RVA: 0x0049EB78 File Offset: 0x0049CD78
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x06011DFC RID: 73212 RVA: 0x0049EB88 File Offset: 0x0049CD88
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x06011DFD RID: 73213 RVA: 0x0049EB98 File Offset: 0x0049CD98
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x06011DFE RID: 73214 RVA: 0x0049EBA8 File Offset: 0x0049CDA8
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x06011DFF RID: 73215 RVA: 0x0049EBB8 File Offset: 0x0049CDB8
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x06011E00 RID: 73216 RVA: 0x0049EBC8 File Offset: 0x0049CDC8
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x06011E01 RID: 73217 RVA: 0x0049EBD8 File Offset: 0x0049CDD8
			public void __callDele_EventOnMailItemButtonClick(Mail obj)
			{
				this.m_owner.__callDele_EventOnMailItemButtonClick(obj);
			}

			// Token: 0x06011E02 RID: 73218 RVA: 0x0049EBE8 File Offset: 0x0049CDE8
			public void __clearDele_EventOnMailItemButtonClick(Mail obj)
			{
				this.m_owner.__clearDele_EventOnMailItemButtonClick(obj);
			}

			// Token: 0x06011E03 RID: 73219 RVA: 0x0049EBF8 File Offset: 0x0049CDF8
			public void __callDele_EventOnCloseButtonClick()
			{
				this.m_owner.__callDele_EventOnCloseButtonClick();
			}

			// Token: 0x06011E04 RID: 73220 RVA: 0x0049EC08 File Offset: 0x0049CE08
			public void __clearDele_EventOnCloseButtonClick()
			{
				this.m_owner.__clearDele_EventOnCloseButtonClick();
			}

			// Token: 0x06011E05 RID: 73221 RVA: 0x0049EC18 File Offset: 0x0049CE18
			public void __callDele_EventOnGetAllAttachments()
			{
				this.m_owner.__callDele_EventOnGetAllAttachments();
			}

			// Token: 0x06011E06 RID: 73222 RVA: 0x0049EC28 File Offset: 0x0049CE28
			public void __clearDele_EventOnGetAllAttachments()
			{
				this.m_owner.__clearDele_EventOnGetAllAttachments();
			}

			// Token: 0x170036B5 RID: 14005
			// (get) Token: 0x06011E07 RID: 73223 RVA: 0x0049EC38 File Offset: 0x0049CE38
			// (set) Token: 0x06011E08 RID: 73224 RVA: 0x0049EC48 File Offset: 0x0049CE48
			public List<MailItemUIController> m_itemUICtrlList
			{
				get
				{
					return this.m_owner.m_itemUICtrlList;
				}
				set
				{
					this.m_owner.m_itemUICtrlList = value;
				}
			}

			// Token: 0x170036B6 RID: 14006
			// (get) Token: 0x06011E09 RID: 73225 RVA: 0x0049EC58 File Offset: 0x0049CE58
			// (set) Token: 0x06011E0A RID: 73226 RVA: 0x0049EC68 File Offset: 0x0049CE68
			public CommonUIStateController m_stateCtrl
			{
				get
				{
					return this.m_owner.m_stateCtrl;
				}
				set
				{
					this.m_owner.m_stateCtrl = value;
				}
			}

			// Token: 0x170036B7 RID: 14007
			// (get) Token: 0x06011E0B RID: 73227 RVA: 0x0049EC78 File Offset: 0x0049CE78
			// (set) Token: 0x06011E0C RID: 73228 RVA: 0x0049EC88 File Offset: 0x0049CE88
			public Button m_bgButton
			{
				get
				{
					return this.m_owner.m_bgButton;
				}
				set
				{
					this.m_owner.m_bgButton = value;
				}
			}

			// Token: 0x170036B8 RID: 14008
			// (get) Token: 0x06011E0D RID: 73229 RVA: 0x0049EC98 File Offset: 0x0049CE98
			// (set) Token: 0x06011E0E RID: 73230 RVA: 0x0049ECA8 File Offset: 0x0049CEA8
			public GameObject m_mailItemPrefab
			{
				get
				{
					return this.m_owner.m_mailItemPrefab;
				}
				set
				{
					this.m_owner.m_mailItemPrefab = value;
				}
			}

			// Token: 0x170036B9 RID: 14009
			// (get) Token: 0x06011E0F RID: 73231 RVA: 0x0049ECB8 File Offset: 0x0049CEB8
			// (set) Token: 0x06011E10 RID: 73232 RVA: 0x0049ECC8 File Offset: 0x0049CEC8
			public GameObject m_mailDetailGo
			{
				get
				{
					return this.m_owner.m_mailDetailGo;
				}
				set
				{
					this.m_owner.m_mailDetailGo = value;
				}
			}

			// Token: 0x170036BA RID: 14010
			// (get) Token: 0x06011E11 RID: 73233 RVA: 0x0049ECD8 File Offset: 0x0049CED8
			// (set) Token: 0x06011E12 RID: 73234 RVA: 0x0049ECE8 File Offset: 0x0049CEE8
			public ScrollRect m_listScrollRect
			{
				get
				{
					return this.m_owner.m_listScrollRect;
				}
				set
				{
					this.m_owner.m_listScrollRect = value;
				}
			}

			// Token: 0x170036BB RID: 14011
			// (get) Token: 0x06011E13 RID: 73235 RVA: 0x0049ECF8 File Offset: 0x0049CEF8
			// (set) Token: 0x06011E14 RID: 73236 RVA: 0x0049ED08 File Offset: 0x0049CF08
			public GameObject m_mailListContent
			{
				get
				{
					return this.m_owner.m_mailListContent;
				}
				set
				{
					this.m_owner.m_mailListContent = value;
				}
			}

			// Token: 0x170036BC RID: 14012
			// (get) Token: 0x06011E15 RID: 73237 RVA: 0x0049ED18 File Offset: 0x0049CF18
			// (set) Token: 0x06011E16 RID: 73238 RVA: 0x0049ED28 File Offset: 0x0049CF28
			public GameObject m_mailListPointBgContent
			{
				get
				{
					return this.m_owner.m_mailListPointBgContent;
				}
				set
				{
					this.m_owner.m_mailListPointBgContent = value;
				}
			}

			// Token: 0x170036BD RID: 14013
			// (get) Token: 0x06011E17 RID: 73239 RVA: 0x0049ED38 File Offset: 0x0049CF38
			// (set) Token: 0x06011E18 RID: 73240 RVA: 0x0049ED48 File Offset: 0x0049CF48
			public GameObject m_mailListPointItem
			{
				get
				{
					return this.m_owner.m_mailListPointItem;
				}
				set
				{
					this.m_owner.m_mailListPointItem = value;
				}
			}

			// Token: 0x170036BE RID: 14014
			// (get) Token: 0x06011E19 RID: 73241 RVA: 0x0049ED58 File Offset: 0x0049CF58
			// (set) Token: 0x06011E1A RID: 73242 RVA: 0x0049ED68 File Offset: 0x0049CF68
			public Button m_closeButton
			{
				get
				{
					return this.m_owner.m_closeButton;
				}
				set
				{
					this.m_owner.m_closeButton = value;
				}
			}

			// Token: 0x170036BF RID: 14015
			// (get) Token: 0x06011E1B RID: 73243 RVA: 0x0049ED78 File Offset: 0x0049CF78
			// (set) Token: 0x06011E1C RID: 73244 RVA: 0x0049ED88 File Offset: 0x0049CF88
			public Button m_getAllButton
			{
				get
				{
					return this.m_owner.m_getAllButton;
				}
				set
				{
					this.m_owner.m_getAllButton = value;
				}
			}

			// Token: 0x06011E1D RID: 73245 RVA: 0x0049ED98 File Offset: 0x0049CF98
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x06011E1E RID: 73246 RVA: 0x0049EDA8 File Offset: 0x0049CFA8
			public void OnMailItemButtonClick(MailItemUIController obj)
			{
				this.m_owner.OnMailItemButtonClick(obj);
			}

			// Token: 0x06011E1F RID: 73247 RVA: 0x0049EDB8 File Offset: 0x0049CFB8
			public void OnCloseButtonClick()
			{
				this.m_owner.OnCloseButtonClick();
			}

			// Token: 0x06011E20 RID: 73248 RVA: 0x0049EDC8 File Offset: 0x0049CFC8
			public void OnGetAllButtonClick()
			{
				this.m_owner.OnGetAllButtonClick();
			}

			// Token: 0x0400A272 RID: 41586
			private MailListUIController m_owner;
		}
	}
}
