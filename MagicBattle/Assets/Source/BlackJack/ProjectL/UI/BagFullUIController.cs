using System;
using System.Threading;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.PlayerContext;
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000A49 RID: 2633
	[HotFix]
	public class BagFullUIController : UIControllerBase
	{
		// Token: 0x0600A251 RID: 41553 RVA: 0x002DCA88 File Offset: 0x002DAC88
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
			this.m_bgButton.onClick.AddListener(new UnityAction(this.OnReturnButtonClick));
			this.m_returnButton.onClick.AddListener(new UnityAction(this.OnReturnButtonClick));
			this.m_gotoBagButton.onClick.AddListener(new UnityAction(this.OnGotoBagButtonClick));
		}

		// Token: 0x0600A252 RID: 41554 RVA: 0x002DCB44 File Offset: 0x002DAD44
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
			this.m_stateCtrl.SetToUIState("Show", false, true);
			this.m_isOpened = true;
		}

		// Token: 0x0600A253 RID: 41555 RVA: 0x002DCBD0 File Offset: 0x002DADD0
		public void Close(Action onEnd)
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
			UIUtility.SetUIStateClose(this.m_stateCtrl, "Close", onEnd, false, true);
			this.m_isOpened = false;
		}

		// Token: 0x0600A254 RID: 41556 RVA: 0x002DCC5C File Offset: 0x002DAE5C
		public void UpdateView()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateView_hotfix != null)
			{
				this.m_UpdateView_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			int num = configDataLoader.UtilityGetConfigableConst(ConfigableConstId.ConfigableConstId_BagMaxCapacity);
			int bagSize = projectLPlayerContext.GetBagSize();
			this.m_countText.text = bagSize + "/" + num;
			if (bagSize <= num)
			{
				this.m_countStateCtrl.SetToUIState("Normal", false, true);
			}
			else
			{
				this.m_countStateCtrl.SetToUIState("Full", false, true);
			}
			this.m_countText.text = bagSize.ToString();
			this.m_countMaxText.text = num.ToString();
		}

		// Token: 0x0600A255 RID: 41557 RVA: 0x002DCD70 File Offset: 0x002DAF70
		private void OnReturnButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnReturnButtonClick_hotfix != null)
			{
				this.m_OnReturnButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.m_isOpened)
			{
				return;
			}
			if (this.EventOnReturn != null)
			{
				this.EventOnReturn();
			}
		}

		// Token: 0x0600A256 RID: 41558 RVA: 0x002DCDF4 File Offset: 0x002DAFF4
		private void OnGotoBagButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnGotoBagButtonClick_hotfix != null)
			{
				this.m_OnGotoBagButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.m_isOpened)
			{
				return;
			}
			if (this.EventOnGotoBag != null)
			{
				this.EventOnGotoBag();
			}
		}

		// Token: 0x140001E2 RID: 482
		// (add) Token: 0x0600A257 RID: 41559 RVA: 0x002DCE78 File Offset: 0x002DB078
		// (remove) Token: 0x0600A258 RID: 41560 RVA: 0x002DCF14 File Offset: 0x002DB114
		public event Action EventOnReturn
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnReturnAction_hotfix != null)
				{
					this.m_add_EventOnReturnAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnReturn;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnReturn, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnReturnAction_hotfix != null)
				{
					this.m_remove_EventOnReturnAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnReturn;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnReturn, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140001E3 RID: 483
		// (add) Token: 0x0600A259 RID: 41561 RVA: 0x002DCFB0 File Offset: 0x002DB1B0
		// (remove) Token: 0x0600A25A RID: 41562 RVA: 0x002DD04C File Offset: 0x002DB24C
		public event Action EventOnGotoBag
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnGotoBagAction_hotfix != null)
				{
					this.m_add_EventOnGotoBagAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnGotoBag;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnGotoBag, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnGotoBagAction_hotfix != null)
				{
					this.m_remove_EventOnGotoBagAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnGotoBag;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnGotoBag, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17002102 RID: 8450
		// (get) Token: 0x0600A25B RID: 41563 RVA: 0x002DD0E8 File Offset: 0x002DB2E8
		// (set) Token: 0x0600A25C RID: 41564 RVA: 0x002DD108 File Offset: 0x002DB308
		[DoNotToLua]
		public new BagFullUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new BagFullUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600A25D RID: 41565 RVA: 0x002DD114 File Offset: 0x002DB314
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0600A25E RID: 41566 RVA: 0x002DD120 File Offset: 0x002DB320
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0600A25F RID: 41567 RVA: 0x002DD128 File Offset: 0x002DB328
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0600A260 RID: 41568 RVA: 0x002DD130 File Offset: 0x002DB330
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0600A261 RID: 41569 RVA: 0x002DD144 File Offset: 0x002DB344
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0600A262 RID: 41570 RVA: 0x002DD14C File Offset: 0x002DB34C
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0600A263 RID: 41571 RVA: 0x002DD158 File Offset: 0x002DB358
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0600A264 RID: 41572 RVA: 0x002DD164 File Offset: 0x002DB364
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0600A265 RID: 41573 RVA: 0x002DD170 File Offset: 0x002DB370
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0600A266 RID: 41574 RVA: 0x002DD17C File Offset: 0x002DB37C
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0600A267 RID: 41575 RVA: 0x002DD188 File Offset: 0x002DB388
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0600A268 RID: 41576 RVA: 0x002DD194 File Offset: 0x002DB394
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0600A269 RID: 41577 RVA: 0x002DD1A0 File Offset: 0x002DB3A0
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0600A26A RID: 41578 RVA: 0x002DD1AC File Offset: 0x002DB3AC
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0600A26B RID: 41579 RVA: 0x002DD1B8 File Offset: 0x002DB3B8
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600A26C RID: 41580 RVA: 0x002DD1C0 File Offset: 0x002DB3C0
		private void __callDele_EventOnReturn()
		{
			Action eventOnReturn = this.EventOnReturn;
			if (eventOnReturn != null)
			{
				eventOnReturn();
			}
		}

		// Token: 0x0600A26D RID: 41581 RVA: 0x002DD1E0 File Offset: 0x002DB3E0
		private void __clearDele_EventOnReturn()
		{
			this.EventOnReturn = null;
		}

		// Token: 0x0600A26E RID: 41582 RVA: 0x002DD1EC File Offset: 0x002DB3EC
		private void __callDele_EventOnGotoBag()
		{
			Action eventOnGotoBag = this.EventOnGotoBag;
			if (eventOnGotoBag != null)
			{
				eventOnGotoBag();
			}
		}

		// Token: 0x0600A26F RID: 41583 RVA: 0x002DD20C File Offset: 0x002DB40C
		private void __clearDele_EventOnGotoBag()
		{
			this.EventOnGotoBag = null;
		}

		// Token: 0x0600A270 RID: 41584 RVA: 0x002DD218 File Offset: 0x002DB418
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
					this.m_CloseAction_hotfix = (luaObj.RawGet("Close") as LuaFunction);
					this.m_UpdateView_hotfix = (luaObj.RawGet("UpdateView") as LuaFunction);
					this.m_OnReturnButtonClick_hotfix = (luaObj.RawGet("OnReturnButtonClick") as LuaFunction);
					this.m_OnGotoBagButtonClick_hotfix = (luaObj.RawGet("OnGotoBagButtonClick") as LuaFunction);
					this.m_add_EventOnReturnAction_hotfix = (luaObj.RawGet("add_EventOnReturn") as LuaFunction);
					this.m_remove_EventOnReturnAction_hotfix = (luaObj.RawGet("remove_EventOnReturn") as LuaFunction);
					this.m_add_EventOnGotoBagAction_hotfix = (luaObj.RawGet("add_EventOnGotoBag") as LuaFunction);
					this.m_remove_EventOnGotoBagAction_hotfix = (luaObj.RawGet("remove_EventOnGotoBag") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600A271 RID: 41585 RVA: 0x002DD3C4 File Offset: 0x002DB5C4
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BagFullUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04006CC2 RID: 27842
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_stateCtrl;

		// Token: 0x04006CC3 RID: 27843
		[AutoBind("./BgButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_bgButton;

		// Token: 0x04006CC4 RID: 27844
		[AutoBind("./Panel/CancelButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_returnButton;

		// Token: 0x04006CC5 RID: 27845
		[AutoBind("./Panel/GotoBagButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_gotoBagButton;

		// Token: 0x04006CC6 RID: 27846
		[AutoBind("./Panel/CountLimit", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_countStateCtrl;

		// Token: 0x04006CC7 RID: 27847
		[AutoBind("./Panel/CountLimit/CountText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_countText;

		// Token: 0x04006CC8 RID: 27848
		[AutoBind("./Panel/CountLimit/MaxText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_countMaxText;

		// Token: 0x04006CC9 RID: 27849
		private bool m_isOpened;

		// Token: 0x04006CCA RID: 27850
		[DoNotToLua]
		private BagFullUIController.LuaExportHelper luaExportHelper;

		// Token: 0x04006CCB RID: 27851
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04006CCC RID: 27852
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04006CCD RID: 27853
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x04006CCE RID: 27854
		private LuaFunction m_Open_hotfix;

		// Token: 0x04006CCF RID: 27855
		private LuaFunction m_CloseAction_hotfix;

		// Token: 0x04006CD0 RID: 27856
		private LuaFunction m_UpdateView_hotfix;

		// Token: 0x04006CD1 RID: 27857
		private LuaFunction m_OnReturnButtonClick_hotfix;

		// Token: 0x04006CD2 RID: 27858
		private LuaFunction m_OnGotoBagButtonClick_hotfix;

		// Token: 0x04006CD3 RID: 27859
		private LuaFunction m_add_EventOnReturnAction_hotfix;

		// Token: 0x04006CD4 RID: 27860
		private LuaFunction m_remove_EventOnReturnAction_hotfix;

		// Token: 0x04006CD5 RID: 27861
		private LuaFunction m_add_EventOnGotoBagAction_hotfix;

		// Token: 0x04006CD6 RID: 27862
		private LuaFunction m_remove_EventOnGotoBagAction_hotfix;

		// Token: 0x02000A4A RID: 2634
		public new class LuaExportHelper
		{
			// Token: 0x0600A272 RID: 41586 RVA: 0x002DD42C File Offset: 0x002DB62C
			public LuaExportHelper(BagFullUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600A273 RID: 41587 RVA: 0x002DD43C File Offset: 0x002DB63C
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0600A274 RID: 41588 RVA: 0x002DD44C File Offset: 0x002DB64C
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0600A275 RID: 41589 RVA: 0x002DD45C File Offset: 0x002DB65C
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600A276 RID: 41590 RVA: 0x002DD46C File Offset: 0x002DB66C
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600A277 RID: 41591 RVA: 0x002DD484 File Offset: 0x002DB684
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0600A278 RID: 41592 RVA: 0x002DD494 File Offset: 0x002DB694
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0600A279 RID: 41593 RVA: 0x002DD4A4 File Offset: 0x002DB6A4
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0600A27A RID: 41594 RVA: 0x002DD4B4 File Offset: 0x002DB6B4
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0600A27B RID: 41595 RVA: 0x002DD4C4 File Offset: 0x002DB6C4
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0600A27C RID: 41596 RVA: 0x002DD4D4 File Offset: 0x002DB6D4
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0600A27D RID: 41597 RVA: 0x002DD4E4 File Offset: 0x002DB6E4
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0600A27E RID: 41598 RVA: 0x002DD4F4 File Offset: 0x002DB6F4
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0600A27F RID: 41599 RVA: 0x002DD504 File Offset: 0x002DB704
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0600A280 RID: 41600 RVA: 0x002DD514 File Offset: 0x002DB714
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0600A281 RID: 41601 RVA: 0x002DD524 File Offset: 0x002DB724
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x0600A282 RID: 41602 RVA: 0x002DD534 File Offset: 0x002DB734
			public void __callDele_EventOnReturn()
			{
				this.m_owner.__callDele_EventOnReturn();
			}

			// Token: 0x0600A283 RID: 41603 RVA: 0x002DD544 File Offset: 0x002DB744
			public void __clearDele_EventOnReturn()
			{
				this.m_owner.__clearDele_EventOnReturn();
			}

			// Token: 0x0600A284 RID: 41604 RVA: 0x002DD554 File Offset: 0x002DB754
			public void __callDele_EventOnGotoBag()
			{
				this.m_owner.__callDele_EventOnGotoBag();
			}

			// Token: 0x0600A285 RID: 41605 RVA: 0x002DD564 File Offset: 0x002DB764
			public void __clearDele_EventOnGotoBag()
			{
				this.m_owner.__clearDele_EventOnGotoBag();
			}

			// Token: 0x17002103 RID: 8451
			// (get) Token: 0x0600A286 RID: 41606 RVA: 0x002DD574 File Offset: 0x002DB774
			// (set) Token: 0x0600A287 RID: 41607 RVA: 0x002DD584 File Offset: 0x002DB784
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

			// Token: 0x17002104 RID: 8452
			// (get) Token: 0x0600A288 RID: 41608 RVA: 0x002DD594 File Offset: 0x002DB794
			// (set) Token: 0x0600A289 RID: 41609 RVA: 0x002DD5A4 File Offset: 0x002DB7A4
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

			// Token: 0x17002105 RID: 8453
			// (get) Token: 0x0600A28A RID: 41610 RVA: 0x002DD5B4 File Offset: 0x002DB7B4
			// (set) Token: 0x0600A28B RID: 41611 RVA: 0x002DD5C4 File Offset: 0x002DB7C4
			public Button m_returnButton
			{
				get
				{
					return this.m_owner.m_returnButton;
				}
				set
				{
					this.m_owner.m_returnButton = value;
				}
			}

			// Token: 0x17002106 RID: 8454
			// (get) Token: 0x0600A28C RID: 41612 RVA: 0x002DD5D4 File Offset: 0x002DB7D4
			// (set) Token: 0x0600A28D RID: 41613 RVA: 0x002DD5E4 File Offset: 0x002DB7E4
			public Button m_gotoBagButton
			{
				get
				{
					return this.m_owner.m_gotoBagButton;
				}
				set
				{
					this.m_owner.m_gotoBagButton = value;
				}
			}

			// Token: 0x17002107 RID: 8455
			// (get) Token: 0x0600A28E RID: 41614 RVA: 0x002DD5F4 File Offset: 0x002DB7F4
			// (set) Token: 0x0600A28F RID: 41615 RVA: 0x002DD604 File Offset: 0x002DB804
			public CommonUIStateController m_countStateCtrl
			{
				get
				{
					return this.m_owner.m_countStateCtrl;
				}
				set
				{
					this.m_owner.m_countStateCtrl = value;
				}
			}

			// Token: 0x17002108 RID: 8456
			// (get) Token: 0x0600A290 RID: 41616 RVA: 0x002DD614 File Offset: 0x002DB814
			// (set) Token: 0x0600A291 RID: 41617 RVA: 0x002DD624 File Offset: 0x002DB824
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

			// Token: 0x17002109 RID: 8457
			// (get) Token: 0x0600A292 RID: 41618 RVA: 0x002DD634 File Offset: 0x002DB834
			// (set) Token: 0x0600A293 RID: 41619 RVA: 0x002DD644 File Offset: 0x002DB844
			public Text m_countMaxText
			{
				get
				{
					return this.m_owner.m_countMaxText;
				}
				set
				{
					this.m_owner.m_countMaxText = value;
				}
			}

			// Token: 0x1700210A RID: 8458
			// (get) Token: 0x0600A294 RID: 41620 RVA: 0x002DD654 File Offset: 0x002DB854
			// (set) Token: 0x0600A295 RID: 41621 RVA: 0x002DD664 File Offset: 0x002DB864
			public bool m_isOpened
			{
				get
				{
					return this.m_owner.m_isOpened;
				}
				set
				{
					this.m_owner.m_isOpened = value;
				}
			}

			// Token: 0x0600A296 RID: 41622 RVA: 0x002DD674 File Offset: 0x002DB874
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0600A297 RID: 41623 RVA: 0x002DD684 File Offset: 0x002DB884
			public void OnReturnButtonClick()
			{
				this.m_owner.OnReturnButtonClick();
			}

			// Token: 0x0600A298 RID: 41624 RVA: 0x002DD694 File Offset: 0x002DB894
			public void OnGotoBagButtonClick()
			{
				this.m_owner.OnGotoBagButtonClick();
			}

			// Token: 0x04006CD7 RID: 27863
			private BagFullUIController m_owner;
		}
	}
}
