using System;
using System.Runtime.CompilerServices;
using System.Threading;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000D8C RID: 3468
	[HotFix]
	public class HeroCommentItemUIController : UIControllerBase
	{
		// Token: 0x060102FE RID: 66302 RVA: 0x0043B41C File Offset: 0x0043961C
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
			this.m_playerNameBtn.onClick.AddListener(new UnityAction(this.OnPlayerNameButtonClick));
			this.m_playerPraisedBtn.onClick.AddListener(new UnityAction(this.OnPlayerPraisedButtonClick));
			base.gameObject.SetActive(true);
		}

		// Token: 0x060102FF RID: 66303 RVA: 0x0043B4C8 File Offset: 0x004396C8
		public void InitCommentItem(HeroCommentEntry comment, bool isShowPraisedIcon)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitCommentItemHeroCommentEntryBoolean_hotfix != null)
			{
				this.m_InitCommentItemHeroCommentEntryBoolean_hotfix.call(new object[]
				{
					this,
					comment,
					isShowPraisedIcon
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.Comment = comment;
			this.CommenterId = comment.CommenterUserId;
			this.CommentInstanceId = comment.InstanceId;
			this.m_playerLvText.text = "LV." + comment.CommenterLevel;
			this.m_playerNameText.text = comment.CommenterName;
			this.m_playerCommentText.text = comment.Content;
			this.m_playerPraisedNumText.text = comment.PraiseNums.ToString();
			this.m_playerPraisedIcon.SetActive(isShowPraisedIcon);
		}

		// Token: 0x06010300 RID: 66304 RVA: 0x0043B5D4 File Offset: 0x004397D4
		private void OnPlayerNameButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnPlayerNameButtonClick_hotfix != null)
			{
				this.m_OnPlayerNameButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnNameClick != null)
			{
				this.EventOnNameClick(this.Comment);
			}
		}

		// Token: 0x06010301 RID: 66305 RVA: 0x0043B650 File Offset: 0x00439850
		private void OnPlayerPraisedButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnPlayerPraisedButtonClick_hotfix != null)
			{
				this.m_OnPlayerPraisedButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnPraisedBtnClick != null)
			{
				this.EventOnPraisedBtnClick(this.CommentInstanceId);
			}
		}

		// Token: 0x14000369 RID: 873
		// (add) Token: 0x06010302 RID: 66306 RVA: 0x0043B6CC File Offset: 0x004398CC
		// (remove) Token: 0x06010303 RID: 66307 RVA: 0x0043B768 File Offset: 0x00439968
		public event Action<HeroCommentEntry> EventOnNameClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnNameClickAction`1_hotfix != null)
				{
					this.m_add_EventOnNameClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<HeroCommentEntry> action = this.EventOnNameClick;
				Action<HeroCommentEntry> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<HeroCommentEntry>>(ref this.EventOnNameClick, (Action<HeroCommentEntry>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnNameClickAction`1_hotfix != null)
				{
					this.m_remove_EventOnNameClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<HeroCommentEntry> action = this.EventOnNameClick;
				Action<HeroCommentEntry> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<HeroCommentEntry>>(ref this.EventOnNameClick, (Action<HeroCommentEntry>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1400036A RID: 874
		// (add) Token: 0x06010304 RID: 66308 RVA: 0x0043B804 File Offset: 0x00439A04
		// (remove) Token: 0x06010305 RID: 66309 RVA: 0x0043B8A0 File Offset: 0x00439AA0
		public event Action<ulong> EventOnPraisedBtnClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnPraisedBtnClickAction`1_hotfix != null)
				{
					this.m_add_EventOnPraisedBtnClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<ulong> action = this.EventOnPraisedBtnClick;
				Action<ulong> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<ulong>>(ref this.EventOnPraisedBtnClick, (Action<ulong>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnPraisedBtnClickAction`1_hotfix != null)
				{
					this.m_remove_EventOnPraisedBtnClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<ulong> action = this.EventOnPraisedBtnClick;
				Action<ulong> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<ulong>>(ref this.EventOnPraisedBtnClick, (Action<ulong>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x170031D8 RID: 12760
		// (get) Token: 0x06010307 RID: 66311 RVA: 0x0043B9B4 File Offset: 0x00439BB4
		// (set) Token: 0x06010306 RID: 66310 RVA: 0x0043B93C File Offset: 0x00439B3C
		public HeroCommentEntry Comment
		{
			[CompilerGenerated]
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_Comment_hotfix != null)
				{
					return (HeroCommentEntry)this.m_get_Comment_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.<Comment>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_set_CommentHeroCommentEntry_hotfix != null)
				{
					this.m_set_CommentHeroCommentEntry_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				this.<Comment>k__BackingField = value;
			}
		}

		// Token: 0x170031D9 RID: 12761
		// (get) Token: 0x06010309 RID: 66313 RVA: 0x0043BAA0 File Offset: 0x00439CA0
		// (set) Token: 0x06010308 RID: 66312 RVA: 0x0043BA28 File Offset: 0x00439C28
		public string CommenterId
		{
			[CompilerGenerated]
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_CommenterId_hotfix != null)
				{
					return (string)this.m_get_CommenterId_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.<CommenterId>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_set_CommenterIdString_hotfix != null)
				{
					this.m_set_CommenterIdString_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				this.<CommenterId>k__BackingField = value;
			}
		}

		// Token: 0x170031DA RID: 12762
		// (get) Token: 0x0601030B RID: 66315 RVA: 0x0043BB8C File Offset: 0x00439D8C
		// (set) Token: 0x0601030A RID: 66314 RVA: 0x0043BB14 File Offset: 0x00439D14
		public ulong CommentInstanceId
		{
			[CompilerGenerated]
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_CommentInstanceId_hotfix != null)
				{
					return Convert.ToUInt64(this.m_get_CommentInstanceId_hotfix.call(new object[]
					{
						this
					}));
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.<CommentInstanceId>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_set_CommentInstanceIdUInt64_hotfix != null)
				{
					this.m_set_CommentInstanceIdUInt64_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				this.<CommentInstanceId>k__BackingField = value;
			}
		}

		// Token: 0x170031DB RID: 12763
		// (get) Token: 0x0601030C RID: 66316 RVA: 0x0043BC00 File Offset: 0x00439E00
		// (set) Token: 0x0601030D RID: 66317 RVA: 0x0043BC20 File Offset: 0x00439E20
		[DoNotToLua]
		public new HeroCommentItemUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new HeroCommentItemUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0601030E RID: 66318 RVA: 0x0043BC2C File Offset: 0x00439E2C
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0601030F RID: 66319 RVA: 0x0043BC38 File Offset: 0x00439E38
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x06010310 RID: 66320 RVA: 0x0043BC40 File Offset: 0x00439E40
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x06010311 RID: 66321 RVA: 0x0043BC48 File Offset: 0x00439E48
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x06010312 RID: 66322 RVA: 0x0043BC5C File Offset: 0x00439E5C
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x06010313 RID: 66323 RVA: 0x0043BC64 File Offset: 0x00439E64
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x06010314 RID: 66324 RVA: 0x0043BC70 File Offset: 0x00439E70
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x06010315 RID: 66325 RVA: 0x0043BC7C File Offset: 0x00439E7C
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x06010316 RID: 66326 RVA: 0x0043BC88 File Offset: 0x00439E88
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x06010317 RID: 66327 RVA: 0x0043BC94 File Offset: 0x00439E94
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x06010318 RID: 66328 RVA: 0x0043BCA0 File Offset: 0x00439EA0
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x06010319 RID: 66329 RVA: 0x0043BCAC File Offset: 0x00439EAC
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0601031A RID: 66330 RVA: 0x0043BCB8 File Offset: 0x00439EB8
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0601031B RID: 66331 RVA: 0x0043BCC4 File Offset: 0x00439EC4
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0601031C RID: 66332 RVA: 0x0043BCD0 File Offset: 0x00439ED0
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0601031D RID: 66333 RVA: 0x0043BCD8 File Offset: 0x00439ED8
		private void __callDele_EventOnNameClick(HeroCommentEntry obj)
		{
			Action<HeroCommentEntry> eventOnNameClick = this.EventOnNameClick;
			if (eventOnNameClick != null)
			{
				eventOnNameClick(obj);
			}
		}

		// Token: 0x0601031E RID: 66334 RVA: 0x0043BCFC File Offset: 0x00439EFC
		private void __clearDele_EventOnNameClick(HeroCommentEntry obj)
		{
			this.EventOnNameClick = null;
		}

		// Token: 0x0601031F RID: 66335 RVA: 0x0043BD08 File Offset: 0x00439F08
		private void __callDele_EventOnPraisedBtnClick(ulong obj)
		{
			Action<ulong> eventOnPraisedBtnClick = this.EventOnPraisedBtnClick;
			if (eventOnPraisedBtnClick != null)
			{
				eventOnPraisedBtnClick(obj);
			}
		}

		// Token: 0x06010320 RID: 66336 RVA: 0x0043BD2C File Offset: 0x00439F2C
		private void __clearDele_EventOnPraisedBtnClick(ulong obj)
		{
			this.EventOnPraisedBtnClick = null;
		}

		// Token: 0x06010321 RID: 66337 RVA: 0x0043BD38 File Offset: 0x00439F38
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
					this.m_InitCommentItemHeroCommentEntryBoolean_hotfix = (luaObj.RawGet("InitCommentItem") as LuaFunction);
					this.m_OnPlayerNameButtonClick_hotfix = (luaObj.RawGet("OnPlayerNameButtonClick") as LuaFunction);
					this.m_OnPlayerPraisedButtonClick_hotfix = (luaObj.RawGet("OnPlayerPraisedButtonClick") as LuaFunction);
					this.m_add_EventOnNameClickAction`1_hotfix = (luaObj.RawGet("add_EventOnNameClick") as LuaFunction);
					this.m_remove_EventOnNameClickAction`1_hotfix = (luaObj.RawGet("remove_EventOnNameClick") as LuaFunction);
					this.m_add_EventOnPraisedBtnClickAction`1_hotfix = (luaObj.RawGet("add_EventOnPraisedBtnClick") as LuaFunction);
					this.m_remove_EventOnPraisedBtnClickAction`1_hotfix = (luaObj.RawGet("remove_EventOnPraisedBtnClick") as LuaFunction);
					this.m_set_CommentHeroCommentEntry_hotfix = (luaObj.RawGet("set_Comment") as LuaFunction);
					this.m_get_Comment_hotfix = (luaObj.RawGet("get_Comment") as LuaFunction);
					this.m_set_CommenterIdString_hotfix = (luaObj.RawGet("set_CommenterId") as LuaFunction);
					this.m_get_CommenterId_hotfix = (luaObj.RawGet("get_CommenterId") as LuaFunction);
					this.m_set_CommentInstanceIdUInt64_hotfix = (luaObj.RawGet("set_CommentInstanceId") as LuaFunction);
					this.m_get_CommentInstanceId_hotfix = (luaObj.RawGet("get_CommentInstanceId") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06010322 RID: 66338 RVA: 0x0043BF48 File Offset: 0x0043A148
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(HeroCommentItemUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040096DE RID: 38622
		[AutoBind("./PraisedIcon", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_playerPraisedIcon;

		// Token: 0x040096DF RID: 38623
		[AutoBind("./LVText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_playerLvText;

		// Token: 0x040096E0 RID: 38624
		[AutoBind("./NameText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_playerNameText;

		// Token: 0x040096E1 RID: 38625
		[AutoBind("./NameText", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_playerNameBtn;

		// Token: 0x040096E2 RID: 38626
		[AutoBind("./CommentText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_playerCommentText;

		// Token: 0x040096E3 RID: 38627
		[AutoBind("./PraisedNumText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_playerPraisedNumText;

		// Token: 0x040096E4 RID: 38628
		[AutoBind("./PraisedButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_playerPraisedBtn;

		// Token: 0x040096E8 RID: 38632
		[DoNotToLua]
		private HeroCommentItemUIController.LuaExportHelper luaExportHelper;

		// Token: 0x040096E9 RID: 38633
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040096EA RID: 38634
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040096EB RID: 38635
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x040096EC RID: 38636
		private LuaFunction m_InitCommentItemHeroCommentEntryBoolean_hotfix;

		// Token: 0x040096ED RID: 38637
		private LuaFunction m_OnPlayerNameButtonClick_hotfix;

		// Token: 0x040096EE RID: 38638
		private LuaFunction m_OnPlayerPraisedButtonClick_hotfix;

		// Token: 0x040096EF RID: 38639
		private LuaFunction m_add_EventOnNameClickAction;

		// Token: 0x040096F0 RID: 38640
		private LuaFunction m_remove_EventOnNameClickAction;

		// Token: 0x040096F1 RID: 38641
		private LuaFunction m_add_EventOnPraisedBtnClickAction;

		// Token: 0x040096F2 RID: 38642
		private LuaFunction m_remove_EventOnPraisedBtnClickAction;

		// Token: 0x040096F3 RID: 38643
		private LuaFunction m_set_CommentHeroCommentEntry_hotfix;

		// Token: 0x040096F4 RID: 38644
		private LuaFunction m_get_Comment_hotfix;

		// Token: 0x040096F5 RID: 38645
		private LuaFunction m_set_CommenterIdString_hotfix;

		// Token: 0x040096F6 RID: 38646
		private LuaFunction m_get_CommenterId_hotfix;

		// Token: 0x040096F7 RID: 38647
		private LuaFunction m_set_CommentInstanceIdUInt64_hotfix;

		// Token: 0x040096F8 RID: 38648
		private LuaFunction m_get_CommentInstanceId_hotfix;

		// Token: 0x02000D8D RID: 3469
		public new class LuaExportHelper
		{
			// Token: 0x06010323 RID: 66339 RVA: 0x0043BFB0 File Offset: 0x0043A1B0
			public LuaExportHelper(HeroCommentItemUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06010324 RID: 66340 RVA: 0x0043BFC0 File Offset: 0x0043A1C0
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x06010325 RID: 66341 RVA: 0x0043BFD0 File Offset: 0x0043A1D0
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x06010326 RID: 66342 RVA: 0x0043BFE0 File Offset: 0x0043A1E0
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x06010327 RID: 66343 RVA: 0x0043BFF0 File Offset: 0x0043A1F0
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x06010328 RID: 66344 RVA: 0x0043C008 File Offset: 0x0043A208
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x06010329 RID: 66345 RVA: 0x0043C018 File Offset: 0x0043A218
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0601032A RID: 66346 RVA: 0x0043C028 File Offset: 0x0043A228
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0601032B RID: 66347 RVA: 0x0043C038 File Offset: 0x0043A238
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0601032C RID: 66348 RVA: 0x0043C048 File Offset: 0x0043A248
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0601032D RID: 66349 RVA: 0x0043C058 File Offset: 0x0043A258
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0601032E RID: 66350 RVA: 0x0043C068 File Offset: 0x0043A268
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0601032F RID: 66351 RVA: 0x0043C078 File Offset: 0x0043A278
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x06010330 RID: 66352 RVA: 0x0043C088 File Offset: 0x0043A288
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x06010331 RID: 66353 RVA: 0x0043C098 File Offset: 0x0043A298
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x06010332 RID: 66354 RVA: 0x0043C0A8 File Offset: 0x0043A2A8
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x06010333 RID: 66355 RVA: 0x0043C0B8 File Offset: 0x0043A2B8
			public void __callDele_EventOnNameClick(HeroCommentEntry obj)
			{
				this.m_owner.__callDele_EventOnNameClick(obj);
			}

			// Token: 0x06010334 RID: 66356 RVA: 0x0043C0C8 File Offset: 0x0043A2C8
			public void __clearDele_EventOnNameClick(HeroCommentEntry obj)
			{
				this.m_owner.__clearDele_EventOnNameClick(obj);
			}

			// Token: 0x06010335 RID: 66357 RVA: 0x0043C0D8 File Offset: 0x0043A2D8
			public void __callDele_EventOnPraisedBtnClick(ulong obj)
			{
				this.m_owner.__callDele_EventOnPraisedBtnClick(obj);
			}

			// Token: 0x06010336 RID: 66358 RVA: 0x0043C0E8 File Offset: 0x0043A2E8
			public void __clearDele_EventOnPraisedBtnClick(ulong obj)
			{
				this.m_owner.__clearDele_EventOnPraisedBtnClick(obj);
			}

			// Token: 0x170031DC RID: 12764
			// (get) Token: 0x06010337 RID: 66359 RVA: 0x0043C0F8 File Offset: 0x0043A2F8
			// (set) Token: 0x06010338 RID: 66360 RVA: 0x0043C108 File Offset: 0x0043A308
			public GameObject m_playerPraisedIcon
			{
				get
				{
					return this.m_owner.m_playerPraisedIcon;
				}
				set
				{
					this.m_owner.m_playerPraisedIcon = value;
				}
			}

			// Token: 0x170031DD RID: 12765
			// (get) Token: 0x06010339 RID: 66361 RVA: 0x0043C118 File Offset: 0x0043A318
			// (set) Token: 0x0601033A RID: 66362 RVA: 0x0043C128 File Offset: 0x0043A328
			public Text m_playerLvText
			{
				get
				{
					return this.m_owner.m_playerLvText;
				}
				set
				{
					this.m_owner.m_playerLvText = value;
				}
			}

			// Token: 0x170031DE RID: 12766
			// (get) Token: 0x0601033B RID: 66363 RVA: 0x0043C138 File Offset: 0x0043A338
			// (set) Token: 0x0601033C RID: 66364 RVA: 0x0043C148 File Offset: 0x0043A348
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

			// Token: 0x170031DF RID: 12767
			// (get) Token: 0x0601033D RID: 66365 RVA: 0x0043C158 File Offset: 0x0043A358
			// (set) Token: 0x0601033E RID: 66366 RVA: 0x0043C168 File Offset: 0x0043A368
			public Button m_playerNameBtn
			{
				get
				{
					return this.m_owner.m_playerNameBtn;
				}
				set
				{
					this.m_owner.m_playerNameBtn = value;
				}
			}

			// Token: 0x170031E0 RID: 12768
			// (get) Token: 0x0601033F RID: 66367 RVA: 0x0043C178 File Offset: 0x0043A378
			// (set) Token: 0x06010340 RID: 66368 RVA: 0x0043C188 File Offset: 0x0043A388
			public Text m_playerCommentText
			{
				get
				{
					return this.m_owner.m_playerCommentText;
				}
				set
				{
					this.m_owner.m_playerCommentText = value;
				}
			}

			// Token: 0x170031E1 RID: 12769
			// (get) Token: 0x06010341 RID: 66369 RVA: 0x0043C198 File Offset: 0x0043A398
			// (set) Token: 0x06010342 RID: 66370 RVA: 0x0043C1A8 File Offset: 0x0043A3A8
			public Text m_playerPraisedNumText
			{
				get
				{
					return this.m_owner.m_playerPraisedNumText;
				}
				set
				{
					this.m_owner.m_playerPraisedNumText = value;
				}
			}

			// Token: 0x170031E2 RID: 12770
			// (get) Token: 0x06010343 RID: 66371 RVA: 0x0043C1B8 File Offset: 0x0043A3B8
			// (set) Token: 0x06010344 RID: 66372 RVA: 0x0043C1C8 File Offset: 0x0043A3C8
			public Button m_playerPraisedBtn
			{
				get
				{
					return this.m_owner.m_playerPraisedBtn;
				}
				set
				{
					this.m_owner.m_playerPraisedBtn = value;
				}
			}

			// Token: 0x170031E3 RID: 12771
			// (set) Token: 0x06010345 RID: 66373 RVA: 0x0043C1D8 File Offset: 0x0043A3D8
			public HeroCommentEntry Comment
			{
				set
				{
					this.m_owner.Comment = value;
				}
			}

			// Token: 0x170031E4 RID: 12772
			// (set) Token: 0x06010346 RID: 66374 RVA: 0x0043C1E8 File Offset: 0x0043A3E8
			public string CommenterId
			{
				set
				{
					this.m_owner.CommenterId = value;
				}
			}

			// Token: 0x170031E5 RID: 12773
			// (set) Token: 0x06010347 RID: 66375 RVA: 0x0043C1F8 File Offset: 0x0043A3F8
			public ulong CommentInstanceId
			{
				set
				{
					this.m_owner.CommentInstanceId = value;
				}
			}

			// Token: 0x06010348 RID: 66376 RVA: 0x0043C208 File Offset: 0x0043A408
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x06010349 RID: 66377 RVA: 0x0043C218 File Offset: 0x0043A418
			public void OnPlayerNameButtonClick()
			{
				this.m_owner.OnPlayerNameButtonClick();
			}

			// Token: 0x0601034A RID: 66378 RVA: 0x0043C228 File Offset: 0x0043A428
			public void OnPlayerPraisedButtonClick()
			{
				this.m_owner.OnPlayerPraisedButtonClick();
			}

			// Token: 0x040096F9 RID: 38649
			private HeroCommentItemUIController m_owner;
		}
	}
}
