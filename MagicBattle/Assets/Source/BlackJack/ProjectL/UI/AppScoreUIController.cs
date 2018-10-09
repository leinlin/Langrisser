using System;
using System.Threading;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x020009D2 RID: 2514
	[HotFix]
	public class AppScoreUIController : UIControllerBase
	{
		// Token: 0x06009367 RID: 37735 RVA: 0x002A815C File Offset: 0x002A635C
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
			this.m_scorePanelCloseButton.onClick.AddListener(new UnityAction(this.OnScorePanelCloseButtonClick));
			this.m_scorePanelScoreButton.onClick.AddListener(new UnityAction(this.OnScorePanelScoreButtonClick));
		}

		// Token: 0x06009368 RID: 37736 RVA: 0x002A81FC File Offset: 0x002A63FC
		public void PlayOpenTween()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayOpenTween_hotfix != null)
			{
				this.m_PlayOpenTween_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetUIStateOpen(this.m_commonUIStateCtrl, "Show", null, false, true);
		}

		// Token: 0x06009369 RID: 37737 RVA: 0x002A8270 File Offset: 0x002A6470
		private void OnScorePanelCloseButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnScorePanelCloseButtonClick_hotfix != null)
			{
				this.m_OnScorePanelCloseButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetUIStateClose(this.m_commonUIStateCtrl, "Close", delegate
			{
				if (this.EventOnClose != null)
				{
					this.EventOnClose();
				}
			}, false, true);
		}

		// Token: 0x0600936A RID: 37738 RVA: 0x002A82F0 File Offset: 0x002A64F0
		private void OnScorePanelScoreButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnScorePanelScoreButtonClick_hotfix != null)
			{
				this.m_OnScorePanelScoreButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetUIStateClose(this.m_commonUIStateCtrl, "Close", delegate
			{
				if (this.EventOnGoScore != null)
				{
					this.EventOnGoScore();
				}
			}, false, true);
		}

		// Token: 0x1400019F RID: 415
		// (add) Token: 0x0600936B RID: 37739 RVA: 0x002A8370 File Offset: 0x002A6570
		// (remove) Token: 0x0600936C RID: 37740 RVA: 0x002A840C File Offset: 0x002A660C
		public event Action EventOnClose
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnCloseAction_hotfix != null)
				{
					this.m_add_EventOnCloseAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnClose;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnClose, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnCloseAction_hotfix != null)
				{
					this.m_remove_EventOnCloseAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnClose;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnClose, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140001A0 RID: 416
		// (add) Token: 0x0600936D RID: 37741 RVA: 0x002A84A8 File Offset: 0x002A66A8
		// (remove) Token: 0x0600936E RID: 37742 RVA: 0x002A8544 File Offset: 0x002A6744
		public event Action EventOnGoScore
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnGoScoreAction_hotfix != null)
				{
					this.m_add_EventOnGoScoreAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnGoScore;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnGoScore, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnGoScoreAction_hotfix != null)
				{
					this.m_remove_EventOnGoScoreAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnGoScore;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnGoScore, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17001E71 RID: 7793
		// (get) Token: 0x0600936F RID: 37743 RVA: 0x002A85E0 File Offset: 0x002A67E0
		// (set) Token: 0x06009370 RID: 37744 RVA: 0x002A8600 File Offset: 0x002A6800
		[DoNotToLua]
		public new AppScoreUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new AppScoreUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06009371 RID: 37745 RVA: 0x002A860C File Offset: 0x002A680C
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x06009372 RID: 37746 RVA: 0x002A8618 File Offset: 0x002A6818
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x06009373 RID: 37747 RVA: 0x002A8620 File Offset: 0x002A6820
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x06009374 RID: 37748 RVA: 0x002A8628 File Offset: 0x002A6828
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x06009375 RID: 37749 RVA: 0x002A863C File Offset: 0x002A683C
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x06009376 RID: 37750 RVA: 0x002A8644 File Offset: 0x002A6844
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x06009377 RID: 37751 RVA: 0x002A8650 File Offset: 0x002A6850
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x06009378 RID: 37752 RVA: 0x002A865C File Offset: 0x002A685C
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x06009379 RID: 37753 RVA: 0x002A8668 File Offset: 0x002A6868
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0600937A RID: 37754 RVA: 0x002A8674 File Offset: 0x002A6874
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0600937B RID: 37755 RVA: 0x002A8680 File Offset: 0x002A6880
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0600937C RID: 37756 RVA: 0x002A868C File Offset: 0x002A688C
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0600937D RID: 37757 RVA: 0x002A8698 File Offset: 0x002A6898
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0600937E RID: 37758 RVA: 0x002A86A4 File Offset: 0x002A68A4
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0600937F RID: 37759 RVA: 0x002A86B0 File Offset: 0x002A68B0
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x06009380 RID: 37760 RVA: 0x002A86B8 File Offset: 0x002A68B8
		private void __callDele_EventOnClose()
		{
			Action eventOnClose = this.EventOnClose;
			if (eventOnClose != null)
			{
				eventOnClose();
			}
		}

		// Token: 0x06009381 RID: 37761 RVA: 0x002A86D8 File Offset: 0x002A68D8
		private void __clearDele_EventOnClose()
		{
			this.EventOnClose = null;
		}

		// Token: 0x06009382 RID: 37762 RVA: 0x002A86E4 File Offset: 0x002A68E4
		private void __callDele_EventOnGoScore()
		{
			Action eventOnGoScore = this.EventOnGoScore;
			if (eventOnGoScore != null)
			{
				eventOnGoScore();
			}
		}

		// Token: 0x06009383 RID: 37763 RVA: 0x002A8704 File Offset: 0x002A6904
		private void __clearDele_EventOnGoScore()
		{
			this.EventOnGoScore = null;
		}

		// Token: 0x06009386 RID: 37766 RVA: 0x002A8740 File Offset: 0x002A6940
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
					this.m_PlayOpenTween_hotfix = (luaObj.RawGet("PlayOpenTween") as LuaFunction);
					this.m_OnScorePanelCloseButtonClick_hotfix = (luaObj.RawGet("OnScorePanelCloseButtonClick") as LuaFunction);
					this.m_OnScorePanelScoreButtonClick_hotfix = (luaObj.RawGet("OnScorePanelScoreButtonClick") as LuaFunction);
					this.m_add_EventOnCloseAction_hotfix = (luaObj.RawGet("add_EventOnClose") as LuaFunction);
					this.m_remove_EventOnCloseAction_hotfix = (luaObj.RawGet("remove_EventOnClose") as LuaFunction);
					this.m_add_EventOnGoScoreAction_hotfix = (luaObj.RawGet("add_EventOnGoScore") as LuaFunction);
					this.m_remove_EventOnGoScoreAction_hotfix = (luaObj.RawGet("remove_EventOnGoScore") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06009387 RID: 37767 RVA: 0x002A88BC File Offset: 0x002A6ABC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(AppScoreUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040066A0 RID: 26272
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_commonUIStateCtrl;

		// Token: 0x040066A1 RID: 26273
		[AutoBind("./Detail/CloseButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_scorePanelCloseButton;

		// Token: 0x040066A2 RID: 26274
		[AutoBind("./Detail/ScoreButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_scorePanelScoreButton;

		// Token: 0x040066A3 RID: 26275
		[DoNotToLua]
		private AppScoreUIController.LuaExportHelper luaExportHelper;

		// Token: 0x040066A4 RID: 26276
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040066A5 RID: 26277
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040066A6 RID: 26278
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x040066A7 RID: 26279
		private LuaFunction m_PlayOpenTween_hotfix;

		// Token: 0x040066A8 RID: 26280
		private LuaFunction m_OnScorePanelCloseButtonClick_hotfix;

		// Token: 0x040066A9 RID: 26281
		private LuaFunction m_OnScorePanelScoreButtonClick_hotfix;

		// Token: 0x040066AA RID: 26282
		private LuaFunction m_add_EventOnCloseAction_hotfix;

		// Token: 0x040066AB RID: 26283
		private LuaFunction m_remove_EventOnCloseAction_hotfix;

		// Token: 0x040066AC RID: 26284
		private LuaFunction m_add_EventOnGoScoreAction_hotfix;

		// Token: 0x040066AD RID: 26285
		private LuaFunction m_remove_EventOnGoScoreAction_hotfix;

		// Token: 0x020009D3 RID: 2515
		public new class LuaExportHelper
		{
			// Token: 0x06009388 RID: 37768 RVA: 0x002A8924 File Offset: 0x002A6B24
			public LuaExportHelper(AppScoreUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06009389 RID: 37769 RVA: 0x002A8934 File Offset: 0x002A6B34
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0600938A RID: 37770 RVA: 0x002A8944 File Offset: 0x002A6B44
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0600938B RID: 37771 RVA: 0x002A8954 File Offset: 0x002A6B54
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600938C RID: 37772 RVA: 0x002A8964 File Offset: 0x002A6B64
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600938D RID: 37773 RVA: 0x002A897C File Offset: 0x002A6B7C
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0600938E RID: 37774 RVA: 0x002A898C File Offset: 0x002A6B8C
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0600938F RID: 37775 RVA: 0x002A899C File Offset: 0x002A6B9C
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x06009390 RID: 37776 RVA: 0x002A89AC File Offset: 0x002A6BAC
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x06009391 RID: 37777 RVA: 0x002A89BC File Offset: 0x002A6BBC
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x06009392 RID: 37778 RVA: 0x002A89CC File Offset: 0x002A6BCC
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x06009393 RID: 37779 RVA: 0x002A89DC File Offset: 0x002A6BDC
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x06009394 RID: 37780 RVA: 0x002A89EC File Offset: 0x002A6BEC
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x06009395 RID: 37781 RVA: 0x002A89FC File Offset: 0x002A6BFC
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x06009396 RID: 37782 RVA: 0x002A8A0C File Offset: 0x002A6C0C
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x06009397 RID: 37783 RVA: 0x002A8A1C File Offset: 0x002A6C1C
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x06009398 RID: 37784 RVA: 0x002A8A2C File Offset: 0x002A6C2C
			public void __callDele_EventOnClose()
			{
				this.m_owner.__callDele_EventOnClose();
			}

			// Token: 0x06009399 RID: 37785 RVA: 0x002A8A3C File Offset: 0x002A6C3C
			public void __clearDele_EventOnClose()
			{
				this.m_owner.__clearDele_EventOnClose();
			}

			// Token: 0x0600939A RID: 37786 RVA: 0x002A8A4C File Offset: 0x002A6C4C
			public void __callDele_EventOnGoScore()
			{
				this.m_owner.__callDele_EventOnGoScore();
			}

			// Token: 0x0600939B RID: 37787 RVA: 0x002A8A5C File Offset: 0x002A6C5C
			public void __clearDele_EventOnGoScore()
			{
				this.m_owner.__clearDele_EventOnGoScore();
			}

			// Token: 0x17001E72 RID: 7794
			// (get) Token: 0x0600939C RID: 37788 RVA: 0x002A8A6C File Offset: 0x002A6C6C
			// (set) Token: 0x0600939D RID: 37789 RVA: 0x002A8A7C File Offset: 0x002A6C7C
			public CommonUIStateController m_commonUIStateCtrl
			{
				get
				{
					return this.m_owner.m_commonUIStateCtrl;
				}
				set
				{
					this.m_owner.m_commonUIStateCtrl = value;
				}
			}

			// Token: 0x17001E73 RID: 7795
			// (get) Token: 0x0600939E RID: 37790 RVA: 0x002A8A8C File Offset: 0x002A6C8C
			// (set) Token: 0x0600939F RID: 37791 RVA: 0x002A8A9C File Offset: 0x002A6C9C
			public Button m_scorePanelCloseButton
			{
				get
				{
					return this.m_owner.m_scorePanelCloseButton;
				}
				set
				{
					this.m_owner.m_scorePanelCloseButton = value;
				}
			}

			// Token: 0x17001E74 RID: 7796
			// (get) Token: 0x060093A0 RID: 37792 RVA: 0x002A8AAC File Offset: 0x002A6CAC
			// (set) Token: 0x060093A1 RID: 37793 RVA: 0x002A8ABC File Offset: 0x002A6CBC
			public Button m_scorePanelScoreButton
			{
				get
				{
					return this.m_owner.m_scorePanelScoreButton;
				}
				set
				{
					this.m_owner.m_scorePanelScoreButton = value;
				}
			}

			// Token: 0x060093A2 RID: 37794 RVA: 0x002A8ACC File Offset: 0x002A6CCC
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x060093A3 RID: 37795 RVA: 0x002A8ADC File Offset: 0x002A6CDC
			public void OnScorePanelCloseButtonClick()
			{
				this.m_owner.OnScorePanelCloseButtonClick();
			}

			// Token: 0x060093A4 RID: 37796 RVA: 0x002A8AEC File Offset: 0x002A6CEC
			public void OnScorePanelScoreButtonClick()
			{
				this.m_owner.OnScorePanelScoreButtonClick();
			}

			// Token: 0x040066AE RID: 26286
			private AppScoreUIController m_owner;
		}
	}
}
