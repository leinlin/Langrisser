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
	// Token: 0x02001018 RID: 4120
	[HotFix]
	public class EnergyStatusUIController : UIControllerBase
	{
		// Token: 0x06014D03 RID: 85251 RVA: 0x00547198 File Offset: 0x00545398
		private EnergyStatusUIController()
		{
		}

		// Token: 0x06014D04 RID: 85252 RVA: 0x005471A0 File Offset: 0x005453A0
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
			this.m_backgroundButton.onClick.AddListener(new UnityAction(this.OnBackgroundButtonClick));
		}

		// Token: 0x06014D05 RID: 85253 RVA: 0x00547224 File Offset: 0x00545424
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
			UIUtility.SetUIStateOpen(this.m_uiStateController, "Show", null, false, true);
		}

		// Token: 0x06014D06 RID: 85254 RVA: 0x00547298 File Offset: 0x00545498
		public void SetNow(DateTime time)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetNowDateTime_hotfix != null)
			{
				this.m_SetNowDateTime_hotfix.call(new object[]
				{
					this,
					time
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_nowText.text = string.Format("{0:d2}:{1:d2}:{2:d2}", time.Hour, time.Minute, time.Second);
		}

		// Token: 0x06014D07 RID: 85255 RVA: 0x00547344 File Offset: 0x00545544
		public void SetRecoverTime(TimeSpan ts)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetRecoverTimeTimeSpan_hotfix != null)
			{
				this.m_SetRecoverTimeTimeSpan_hotfix.call(new object[]
				{
					this,
					ts
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_recoverTimeText.text = string.Format(string.Format("{0:d2}:{1:d2}:{2:d2}", ts.Hours, ts.Minutes, ts.Seconds), new object[0]);
		}

		// Token: 0x06014D08 RID: 85256 RVA: 0x005473F8 File Offset: 0x005455F8
		public void SetRecoverAllTime(TimeSpan ts)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetRecoverAllTimeTimeSpan_hotfix != null)
			{
				this.m_SetRecoverAllTimeTimeSpan_hotfix.call(new object[]
				{
					this,
					ts
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_recoverAllTimeText.text = string.Format(string.Format("{0:d2}:{1:d2}:{2:d2}", ts.Hours, ts.Minutes, ts.Seconds), new object[0]);
		}

		// Token: 0x06014D09 RID: 85257 RVA: 0x005474AC File Offset: 0x005456AC
		public void SetEnergyStatusPosition(Vector3 p)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetEnergyStatusPositionVector3_hotfix != null)
			{
				this.m_SetEnergyStatusPositionVector3_hotfix.call(new object[]
				{
					this,
					p
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			RectTransform rectTransform = this.m_energyStatusPanel.transform as RectTransform;
			rectTransform.position = p;
			rectTransform.anchoredPosition -= new Vector2(0f, 120f);
		}

		// Token: 0x06014D0A RID: 85258 RVA: 0x00547554 File Offset: 0x00545754
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
			UIUtility.SetUIStateClose(this.m_uiStateController, "Close", delegate
			{
				if (this.EventOnClose != null)
				{
					this.EventOnClose();
				}
			}, false, true);
		}

		// Token: 0x14000495 RID: 1173
		// (add) Token: 0x06014D0B RID: 85259 RVA: 0x005475D4 File Offset: 0x005457D4
		// (remove) Token: 0x06014D0C RID: 85260 RVA: 0x00547670 File Offset: 0x00545870
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

		// Token: 0x17003D79 RID: 15737
		// (get) Token: 0x06014D0D RID: 85261 RVA: 0x0054770C File Offset: 0x0054590C
		// (set) Token: 0x06014D0E RID: 85262 RVA: 0x0054772C File Offset: 0x0054592C
		[DoNotToLua]
		public new EnergyStatusUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new EnergyStatusUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06014D0F RID: 85263 RVA: 0x00547738 File Offset: 0x00545938
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x06014D10 RID: 85264 RVA: 0x00547744 File Offset: 0x00545944
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x06014D11 RID: 85265 RVA: 0x0054774C File Offset: 0x0054594C
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x06014D12 RID: 85266 RVA: 0x00547754 File Offset: 0x00545954
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x06014D13 RID: 85267 RVA: 0x00547768 File Offset: 0x00545968
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x06014D14 RID: 85268 RVA: 0x00547770 File Offset: 0x00545970
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x06014D15 RID: 85269 RVA: 0x0054777C File Offset: 0x0054597C
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x06014D16 RID: 85270 RVA: 0x00547788 File Offset: 0x00545988
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x06014D17 RID: 85271 RVA: 0x00547794 File Offset: 0x00545994
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x06014D18 RID: 85272 RVA: 0x005477A0 File Offset: 0x005459A0
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x06014D19 RID: 85273 RVA: 0x005477AC File Offset: 0x005459AC
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x06014D1A RID: 85274 RVA: 0x005477B8 File Offset: 0x005459B8
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x06014D1B RID: 85275 RVA: 0x005477C4 File Offset: 0x005459C4
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x06014D1C RID: 85276 RVA: 0x005477D0 File Offset: 0x005459D0
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x06014D1D RID: 85277 RVA: 0x005477DC File Offset: 0x005459DC
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x06014D1E RID: 85278 RVA: 0x005477E4 File Offset: 0x005459E4
		private void __callDele_EventOnClose()
		{
			Action eventOnClose = this.EventOnClose;
			if (eventOnClose != null)
			{
				eventOnClose();
			}
		}

		// Token: 0x06014D1F RID: 85279 RVA: 0x00547804 File Offset: 0x00545A04
		private void __clearDele_EventOnClose()
		{
			this.EventOnClose = null;
		}

		// Token: 0x06014D21 RID: 85281 RVA: 0x00547828 File Offset: 0x00545A28
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
					this.m_SetNowDateTime_hotfix = (luaObj.RawGet("SetNow") as LuaFunction);
					this.m_SetRecoverTimeTimeSpan_hotfix = (luaObj.RawGet("SetRecoverTime") as LuaFunction);
					this.m_SetRecoverAllTimeTimeSpan_hotfix = (luaObj.RawGet("SetRecoverAllTime") as LuaFunction);
					this.m_SetEnergyStatusPositionVector3_hotfix = (luaObj.RawGet("SetEnergyStatusPosition") as LuaFunction);
					this.m_OnBackgroundButtonClick_hotfix = (luaObj.RawGet("OnBackgroundButtonClick") as LuaFunction);
					this.m_add_EventOnCloseAction_hotfix = (luaObj.RawGet("add_EventOnClose") as LuaFunction);
					this.m_remove_EventOnCloseAction_hotfix = (luaObj.RawGet("remove_EventOnClose") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06014D22 RID: 85282 RVA: 0x005479BC File Offset: 0x00545BBC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(EnergyStatusUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400B662 RID: 46690
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_uiStateController;

		// Token: 0x0400B663 RID: 46691
		[AutoBind("./Panel/Now/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_nowText;

		// Token: 0x0400B664 RID: 46692
		[AutoBind("./Panel/RecoverTime/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_recoverTimeText;

		// Token: 0x0400B665 RID: 46693
		[AutoBind("./Panel/RecoverAllTime/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_recoverAllTimeText;

		// Token: 0x0400B666 RID: 46694
		[AutoBind("./BackgroundButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_backgroundButton;

		// Token: 0x0400B667 RID: 46695
		[AutoBind("./Panel", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_energyStatusPanel;

		// Token: 0x0400B668 RID: 46696
		[DoNotToLua]
		private EnergyStatusUIController.LuaExportHelper luaExportHelper;

		// Token: 0x0400B669 RID: 46697
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400B66A RID: 46698
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400B66B RID: 46699
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x0400B66C RID: 46700
		private LuaFunction m_Open_hotfix;

		// Token: 0x0400B66D RID: 46701
		private LuaFunction m_SetNowDateTime_hotfix;

		// Token: 0x0400B66E RID: 46702
		private LuaFunction m_SetRecoverTimeTimeSpan_hotfix;

		// Token: 0x0400B66F RID: 46703
		private LuaFunction m_SetRecoverAllTimeTimeSpan_hotfix;

		// Token: 0x0400B670 RID: 46704
		private LuaFunction m_SetEnergyStatusPositionVector3_hotfix;

		// Token: 0x0400B671 RID: 46705
		private LuaFunction m_OnBackgroundButtonClick_hotfix;

		// Token: 0x0400B672 RID: 46706
		private LuaFunction m_add_EventOnCloseAction_hotfix;

		// Token: 0x0400B673 RID: 46707
		private LuaFunction m_remove_EventOnCloseAction_hotfix;

		// Token: 0x02001019 RID: 4121
		public new class LuaExportHelper
		{
			// Token: 0x06014D23 RID: 85283 RVA: 0x00547A24 File Offset: 0x00545C24
			public LuaExportHelper(EnergyStatusUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06014D24 RID: 85284 RVA: 0x00547A34 File Offset: 0x00545C34
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x06014D25 RID: 85285 RVA: 0x00547A44 File Offset: 0x00545C44
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x06014D26 RID: 85286 RVA: 0x00547A54 File Offset: 0x00545C54
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x06014D27 RID: 85287 RVA: 0x00547A64 File Offset: 0x00545C64
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x06014D28 RID: 85288 RVA: 0x00547A7C File Offset: 0x00545C7C
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x06014D29 RID: 85289 RVA: 0x00547A8C File Offset: 0x00545C8C
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x06014D2A RID: 85290 RVA: 0x00547A9C File Offset: 0x00545C9C
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x06014D2B RID: 85291 RVA: 0x00547AAC File Offset: 0x00545CAC
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x06014D2C RID: 85292 RVA: 0x00547ABC File Offset: 0x00545CBC
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x06014D2D RID: 85293 RVA: 0x00547ACC File Offset: 0x00545CCC
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x06014D2E RID: 85294 RVA: 0x00547ADC File Offset: 0x00545CDC
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x06014D2F RID: 85295 RVA: 0x00547AEC File Offset: 0x00545CEC
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x06014D30 RID: 85296 RVA: 0x00547AFC File Offset: 0x00545CFC
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x06014D31 RID: 85297 RVA: 0x00547B0C File Offset: 0x00545D0C
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x06014D32 RID: 85298 RVA: 0x00547B1C File Offset: 0x00545D1C
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x06014D33 RID: 85299 RVA: 0x00547B2C File Offset: 0x00545D2C
			public void __callDele_EventOnClose()
			{
				this.m_owner.__callDele_EventOnClose();
			}

			// Token: 0x06014D34 RID: 85300 RVA: 0x00547B3C File Offset: 0x00545D3C
			public void __clearDele_EventOnClose()
			{
				this.m_owner.__clearDele_EventOnClose();
			}

			// Token: 0x17003D7A RID: 15738
			// (get) Token: 0x06014D35 RID: 85301 RVA: 0x00547B4C File Offset: 0x00545D4C
			// (set) Token: 0x06014D36 RID: 85302 RVA: 0x00547B5C File Offset: 0x00545D5C
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

			// Token: 0x17003D7B RID: 15739
			// (get) Token: 0x06014D37 RID: 85303 RVA: 0x00547B6C File Offset: 0x00545D6C
			// (set) Token: 0x06014D38 RID: 85304 RVA: 0x00547B7C File Offset: 0x00545D7C
			public Text m_nowText
			{
				get
				{
					return this.m_owner.m_nowText;
				}
				set
				{
					this.m_owner.m_nowText = value;
				}
			}

			// Token: 0x17003D7C RID: 15740
			// (get) Token: 0x06014D39 RID: 85305 RVA: 0x00547B8C File Offset: 0x00545D8C
			// (set) Token: 0x06014D3A RID: 85306 RVA: 0x00547B9C File Offset: 0x00545D9C
			public Text m_recoverTimeText
			{
				get
				{
					return this.m_owner.m_recoverTimeText;
				}
				set
				{
					this.m_owner.m_recoverTimeText = value;
				}
			}

			// Token: 0x17003D7D RID: 15741
			// (get) Token: 0x06014D3B RID: 85307 RVA: 0x00547BAC File Offset: 0x00545DAC
			// (set) Token: 0x06014D3C RID: 85308 RVA: 0x00547BBC File Offset: 0x00545DBC
			public Text m_recoverAllTimeText
			{
				get
				{
					return this.m_owner.m_recoverAllTimeText;
				}
				set
				{
					this.m_owner.m_recoverAllTimeText = value;
				}
			}

			// Token: 0x17003D7E RID: 15742
			// (get) Token: 0x06014D3D RID: 85309 RVA: 0x00547BCC File Offset: 0x00545DCC
			// (set) Token: 0x06014D3E RID: 85310 RVA: 0x00547BDC File Offset: 0x00545DDC
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

			// Token: 0x17003D7F RID: 15743
			// (get) Token: 0x06014D3F RID: 85311 RVA: 0x00547BEC File Offset: 0x00545DEC
			// (set) Token: 0x06014D40 RID: 85312 RVA: 0x00547BFC File Offset: 0x00545DFC
			public GameObject m_energyStatusPanel
			{
				get
				{
					return this.m_owner.m_energyStatusPanel;
				}
				set
				{
					this.m_owner.m_energyStatusPanel = value;
				}
			}

			// Token: 0x06014D41 RID: 85313 RVA: 0x00547C0C File Offset: 0x00545E0C
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x06014D42 RID: 85314 RVA: 0x00547C1C File Offset: 0x00545E1C
			public void OnBackgroundButtonClick()
			{
				this.m_owner.OnBackgroundButtonClick();
			}

			// Token: 0x0400B674 RID: 46708
			private EnergyStatusUIController m_owner;
		}
	}
}
