using System;
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
	// Token: 0x02000E62 RID: 3682
	[HotFix]
	public class MailItemUIController : UIControllerBase
	{
		// Token: 0x06011D95 RID: 73109 RVA: 0x0049D424 File Offset: 0x0049B624
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
			this.MailItemButton.onClick.AddListener(new UnityAction(this.OnMailItemClick));
		}

		// Token: 0x06011D96 RID: 73110 RVA: 0x0049D4A8 File Offset: 0x0049B6A8
		public void UpdateMailInfo(Mail mailInfo, bool isSelected = false)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateMailInfoMailBoolean_hotfix != null)
			{
				this.m_UpdateMailInfoMailBoolean_hotfix.call(new object[]
				{
					this,
					mailInfo,
					isSelected
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.gameObject.SetActive(true);
			this.CurrentMailInfo = mailInfo;
			this.MailTitleText.text = mailInfo.Title;
			this.SendTimeText.text = UIUtility.DateTimeToString(mailInfo.SendTime);
			this.SetStateIconSpriteByMailState(mailInfo);
			this.SelectedImage.gameObject.SetActive(isSelected);
		}

		// Token: 0x06011D97 RID: 73111 RVA: 0x0049D57C File Offset: 0x0049B77C
		private void SetStateIconSpriteByMailState(Mail mailInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetStateIconSpriteByMailStateMail_hotfix != null)
			{
				this.m_SetStateIconSpriteByMailStateMail_hotfix.call(new object[]
				{
					this,
					mailInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			bool flag = this.m_playerCtx.IsMailReaded(mailInfo);
			bool flag2 = this.m_playerCtx.IsExistMailAttacments(mailInfo);
			bool flag3 = this.m_playerCtx.HasGotMailAttachments(mailInfo);
			if (flag2)
			{
				if (flag3)
				{
					this.m_uiStateCtrl.SetToUIState("Open", false, true);
				}
				else
				{
					this.m_uiStateCtrl.SetToUIState("Lock", false, true);
				}
			}
			else if (flag)
			{
				this.m_uiStateCtrl.SetToUIState("Read", false, true);
			}
			else
			{
				this.m_uiStateCtrl.SetToUIState("GMT", false, true);
			}
		}

		// Token: 0x06011D98 RID: 73112 RVA: 0x0049D67C File Offset: 0x0049B87C
		private void OnMailItemClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnMailItemClick_hotfix != null)
			{
				this.m_OnMailItemClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnMailItemButtonClick != null)
			{
				this.EventOnMailItemButtonClick(this);
			}
		}

		// Token: 0x140003D4 RID: 980
		// (add) Token: 0x06011D99 RID: 73113 RVA: 0x0049D6F4 File Offset: 0x0049B8F4
		// (remove) Token: 0x06011D9A RID: 73114 RVA: 0x0049D790 File Offset: 0x0049B990
		public event Action<MailItemUIController> EventOnMailItemButtonClick
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
				Action<MailItemUIController> action = this.EventOnMailItemButtonClick;
				Action<MailItemUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<MailItemUIController>>(ref this.EventOnMailItemButtonClick, (Action<MailItemUIController>)Delegate.Combine(action2, value), action);
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
				Action<MailItemUIController> action = this.EventOnMailItemButtonClick;
				Action<MailItemUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<MailItemUIController>>(ref this.EventOnMailItemButtonClick, (Action<MailItemUIController>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x170036B2 RID: 14002
		// (get) Token: 0x06011D9B RID: 73115 RVA: 0x0049D82C File Offset: 0x0049BA2C
		// (set) Token: 0x06011D9C RID: 73116 RVA: 0x0049D84C File Offset: 0x0049BA4C
		[DoNotToLua]
		public new MailItemUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new MailItemUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06011D9D RID: 73117 RVA: 0x0049D858 File Offset: 0x0049BA58
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x06011D9E RID: 73118 RVA: 0x0049D864 File Offset: 0x0049BA64
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x06011D9F RID: 73119 RVA: 0x0049D86C File Offset: 0x0049BA6C
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x06011DA0 RID: 73120 RVA: 0x0049D874 File Offset: 0x0049BA74
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x06011DA1 RID: 73121 RVA: 0x0049D888 File Offset: 0x0049BA88
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x06011DA2 RID: 73122 RVA: 0x0049D890 File Offset: 0x0049BA90
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x06011DA3 RID: 73123 RVA: 0x0049D89C File Offset: 0x0049BA9C
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x06011DA4 RID: 73124 RVA: 0x0049D8A8 File Offset: 0x0049BAA8
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x06011DA5 RID: 73125 RVA: 0x0049D8B4 File Offset: 0x0049BAB4
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x06011DA6 RID: 73126 RVA: 0x0049D8C0 File Offset: 0x0049BAC0
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x06011DA7 RID: 73127 RVA: 0x0049D8CC File Offset: 0x0049BACC
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x06011DA8 RID: 73128 RVA: 0x0049D8D8 File Offset: 0x0049BAD8
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x06011DA9 RID: 73129 RVA: 0x0049D8E4 File Offset: 0x0049BAE4
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x06011DAA RID: 73130 RVA: 0x0049D8F0 File Offset: 0x0049BAF0
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x06011DAB RID: 73131 RVA: 0x0049D8FC File Offset: 0x0049BAFC
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x06011DAC RID: 73132 RVA: 0x0049D904 File Offset: 0x0049BB04
		private void __callDele_EventOnMailItemButtonClick(MailItemUIController obj)
		{
			Action<MailItemUIController> eventOnMailItemButtonClick = this.EventOnMailItemButtonClick;
			if (eventOnMailItemButtonClick != null)
			{
				eventOnMailItemButtonClick(obj);
			}
		}

		// Token: 0x06011DAD RID: 73133 RVA: 0x0049D928 File Offset: 0x0049BB28
		private void __clearDele_EventOnMailItemButtonClick(MailItemUIController obj)
		{
			this.EventOnMailItemButtonClick = null;
		}

		// Token: 0x06011DAE RID: 73134 RVA: 0x0049D934 File Offset: 0x0049BB34
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
					this.m_UpdateMailInfoMailBoolean_hotfix = (luaObj.RawGet("UpdateMailInfo") as LuaFunction);
					this.m_SetStateIconSpriteByMailStateMail_hotfix = (luaObj.RawGet("SetStateIconSpriteByMailState") as LuaFunction);
					this.m_OnMailItemClick_hotfix = (luaObj.RawGet("OnMailItemClick") as LuaFunction);
					this.m_add_EventOnMailItemButtonClickAction`1_hotfix = (luaObj.RawGet("add_EventOnMailItemButtonClick") as LuaFunction);
					this.m_remove_EventOnMailItemButtonClickAction`1_hotfix = (luaObj.RawGet("remove_EventOnMailItemButtonClick") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06011DAF RID: 73135 RVA: 0x0049DA7C File Offset: 0x0049BC7C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(MailItemUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400A23F RID: 41535
		public Mail CurrentMailInfo;

		// Token: 0x0400A240 RID: 41536
		private ProjectLPlayerContext m_playerCtx = GameManager.Instance.PlayerContext as ProjectLPlayerContext;

		// Token: 0x0400A242 RID: 41538
		[AutoBind(".", AutoBindAttribute.InitState.NotInit, false)]
		public Button MailItemButton;

		// Token: 0x0400A243 RID: 41539
		[AutoBind(".", AutoBindAttribute.InitState.NotInit, false)]
		public CommonUIStateController m_uiStateCtrl;

		// Token: 0x0400A244 RID: 41540
		[AutoBind("./MailTitleText", AutoBindAttribute.InitState.NotInit, false)]
		public Text MailTitleText;

		// Token: 0x0400A245 RID: 41541
		[AutoBind("./SendTimeText", AutoBindAttribute.InitState.NotInit, false)]
		public Text SendTimeText;

		// Token: 0x0400A246 RID: 41542
		[AutoBind("./SelectedImage", AutoBindAttribute.InitState.NotInit, false)]
		public Image SelectedImage;

		// Token: 0x0400A247 RID: 41543
		[DoNotToLua]
		private MailItemUIController.LuaExportHelper luaExportHelper;

		// Token: 0x0400A248 RID: 41544
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400A249 RID: 41545
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400A24A RID: 41546
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x0400A24B RID: 41547
		private LuaFunction m_UpdateMailInfoMailBoolean_hotfix;

		// Token: 0x0400A24C RID: 41548
		private LuaFunction m_SetStateIconSpriteByMailStateMail_hotfix;

		// Token: 0x0400A24D RID: 41549
		private LuaFunction m_OnMailItemClick_hotfix;

		// Token: 0x0400A24E RID: 41550
		private LuaFunction m_add_EventOnMailItemButtonClickAction;

		// Token: 0x0400A24F RID: 41551
		private LuaFunction m_remove_EventOnMailItemButtonClickAction;

		// Token: 0x02000E63 RID: 3683
		public new class LuaExportHelper
		{
			// Token: 0x06011DB0 RID: 73136 RVA: 0x0049DAE4 File Offset: 0x0049BCE4
			public LuaExportHelper(MailItemUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06011DB1 RID: 73137 RVA: 0x0049DAF4 File Offset: 0x0049BCF4
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x06011DB2 RID: 73138 RVA: 0x0049DB04 File Offset: 0x0049BD04
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x06011DB3 RID: 73139 RVA: 0x0049DB14 File Offset: 0x0049BD14
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x06011DB4 RID: 73140 RVA: 0x0049DB24 File Offset: 0x0049BD24
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x06011DB5 RID: 73141 RVA: 0x0049DB3C File Offset: 0x0049BD3C
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x06011DB6 RID: 73142 RVA: 0x0049DB4C File Offset: 0x0049BD4C
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x06011DB7 RID: 73143 RVA: 0x0049DB5C File Offset: 0x0049BD5C
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x06011DB8 RID: 73144 RVA: 0x0049DB6C File Offset: 0x0049BD6C
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x06011DB9 RID: 73145 RVA: 0x0049DB7C File Offset: 0x0049BD7C
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x06011DBA RID: 73146 RVA: 0x0049DB8C File Offset: 0x0049BD8C
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x06011DBB RID: 73147 RVA: 0x0049DB9C File Offset: 0x0049BD9C
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x06011DBC RID: 73148 RVA: 0x0049DBAC File Offset: 0x0049BDAC
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x06011DBD RID: 73149 RVA: 0x0049DBBC File Offset: 0x0049BDBC
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x06011DBE RID: 73150 RVA: 0x0049DBCC File Offset: 0x0049BDCC
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x06011DBF RID: 73151 RVA: 0x0049DBDC File Offset: 0x0049BDDC
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x06011DC0 RID: 73152 RVA: 0x0049DBEC File Offset: 0x0049BDEC
			public void __callDele_EventOnMailItemButtonClick(MailItemUIController obj)
			{
				this.m_owner.__callDele_EventOnMailItemButtonClick(obj);
			}

			// Token: 0x06011DC1 RID: 73153 RVA: 0x0049DBFC File Offset: 0x0049BDFC
			public void __clearDele_EventOnMailItemButtonClick(MailItemUIController obj)
			{
				this.m_owner.__clearDele_EventOnMailItemButtonClick(obj);
			}

			// Token: 0x170036B3 RID: 14003
			// (get) Token: 0x06011DC2 RID: 73154 RVA: 0x0049DC0C File Offset: 0x0049BE0C
			// (set) Token: 0x06011DC3 RID: 73155 RVA: 0x0049DC1C File Offset: 0x0049BE1C
			public ProjectLPlayerContext m_playerCtx
			{
				get
				{
					return this.m_owner.m_playerCtx;
				}
				set
				{
					this.m_owner.m_playerCtx = value;
				}
			}

			// Token: 0x06011DC4 RID: 73156 RVA: 0x0049DC2C File Offset: 0x0049BE2C
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x06011DC5 RID: 73157 RVA: 0x0049DC3C File Offset: 0x0049BE3C
			public void SetStateIconSpriteByMailState(Mail mailInfo)
			{
				this.m_owner.SetStateIconSpriteByMailState(mailInfo);
			}

			// Token: 0x06011DC6 RID: 73158 RVA: 0x0049DC4C File Offset: 0x0049BE4C
			public void OnMailItemClick()
			{
				this.m_owner.OnMailItemClick();
			}

			// Token: 0x0400A250 RID: 41552
			private MailItemUIController m_owner;
		}
	}
}
