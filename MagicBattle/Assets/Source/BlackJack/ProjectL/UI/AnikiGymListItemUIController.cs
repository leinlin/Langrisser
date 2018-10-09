using System;
using System.Threading;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Misc;
using BlackJack.ProjectL.PlayerContext;
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x020009CC RID: 2508
	[HotFix]
	public class AnikiGymListItemUIController : UIControllerBase
	{
		// Token: 0x06009265 RID: 37477 RVA: 0x002A50A0 File Offset: 0x002A32A0
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
			this.m_toggle.onValueChanged.AddListener(new UnityAction<bool>(this.OnToggleValueChanged));
			this.m_notOpenButton.onClick.AddListener(new UnityAction(this.OnNotOpenButtonClick));
		}

		// Token: 0x06009266 RID: 37478 RVA: 0x002A5140 File Offset: 0x002A3340
		public void SetAnikiGymInfo(ConfigDataAnikiGymInfo anikiGymInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetAnikiGymInfoConfigDataAnikiGymInfo_hotfix != null)
			{
				this.m_SetAnikiGymInfoConfigDataAnikiGymInfo_hotfix.call(new object[]
				{
					this,
					anikiGymInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_anikiGymInfo = anikiGymInfo;
			Text nameText = this.m_nameText;
			string name = anikiGymInfo.Name;
			this.m_nameTextGray.text = name;
			nameText.text = name;
			Image iconImage = this.m_iconImage;
			Sprite sprite = AssetUtility.Instance.GetSprite(anikiGymInfo.Icon);
			this.m_iconImageGray.sprite = sprite;
			iconImage.sprite = sprite;
			this.m_openTimeText.text = anikiGymInfo.OpenDesc;
		}

		// Token: 0x06009267 RID: 37479 RVA: 0x002A5210 File Offset: 0x002A3410
		public ConfigDataAnikiGymInfo GetAnikiGymInfo()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetAnikiGymInfo_hotfix != null)
			{
				return (ConfigDataAnikiGymInfo)this.m_GetAnikiGymInfo_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_anikiGymInfo;
		}

		// Token: 0x06009268 RID: 37480 RVA: 0x002A5284 File Offset: 0x002A3484
		public void SetLocked(bool locked)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetLockedBoolean_hotfix != null)
			{
				this.m_SetLockedBoolean_hotfix.call(new object[]
				{
					this,
					locked
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_isLocked = locked;
			this.m_uiStateController.SetToUIState((!locked) ? "Normal" : "Gray", false, true);
		}

		// Token: 0x06009269 RID: 37481 RVA: 0x002A5320 File Offset: 0x002A3520
		public bool IsLocked()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsLocked_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsLocked_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_isLocked;
		}

		// Token: 0x0600926A RID: 37482 RVA: 0x002A5394 File Offset: 0x002A3594
		public void SetSelected(bool selected)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetSelectedBoolean_hotfix != null)
			{
				this.m_SetSelectedBoolean_hotfix.call(new object[]
				{
					this,
					selected
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_toggle.isOn = selected;
		}

		// Token: 0x0600926B RID: 37483 RVA: 0x002A5410 File Offset: 0x002A3610
		public bool IsSelected()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsSelected_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsSelected_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_toggle.isOn;
		}

		// Token: 0x0600926C RID: 37484 RVA: 0x002A5488 File Offset: 0x002A3688
		public void SetExpireTime(DateTime expireTime)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetExpireTimeDateTime_hotfix != null)
			{
				this.m_SetExpireTimeDateTime_hotfix.call(new object[]
				{
					this,
					expireTime
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_expireTime = expireTime;
			this.UpdateRemainTime();
			if (this.m_expireTime != DateTime.MaxValue)
			{
				this.m_updateCountdown = 1f;
			}
		}

		// Token: 0x0600926D RID: 37485 RVA: 0x002A5528 File Offset: 0x002A3728
		private void UpdateRemainTime()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateRemainTime_hotfix != null)
			{
				this.m_UpdateRemainTime_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_expireTime != DateTime.MaxValue)
			{
				ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
				TimeSpan timeSpan = this.m_expireTime - projectLPlayerContext.GetServerTime();
				if (timeSpan.Ticks > 0L)
				{
					this.m_timeGameObject.SetActive(true);
					this.m_timeText.text = string.Format("{0:D2}:{1:D2}:{2:D2}", timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds);
				}
				else
				{
					this.m_timeGameObject.SetActive(false);
				}
			}
			else
			{
				this.m_timeGameObject.SetActive(false);
			}
		}

		// Token: 0x0600926E RID: 37486 RVA: 0x002A5634 File Offset: 0x002A3834
		private void Update()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Update_hotfix != null)
			{
				this.m_Update_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_updateCountdown > 0f)
			{
				this.m_updateCountdown -= Time.unscaledDeltaTime;
				if (this.m_updateCountdown <= 0f)
				{
					this.m_updateCountdown += 1f;
					this.UpdateRemainTime();
				}
			}
		}

		// Token: 0x0600926F RID: 37487 RVA: 0x002A56E0 File Offset: 0x002A38E0
		private void OnToggleValueChanged(bool on)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnToggleValueChangedBoolean_hotfix != null)
			{
				this.m_OnToggleValueChangedBoolean_hotfix.call(new object[]
				{
					this,
					on
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnToggleValueChanged != null)
			{
				this.EventOnToggleValueChanged(on, this);
			}
		}

		// Token: 0x06009270 RID: 37488 RVA: 0x002A5768 File Offset: 0x002A3968
		private void OnNotOpenButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnNotOpenButtonClick_hotfix != null)
			{
				this.m_OnNotOpenButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIController.Instance.ShowMessage(StringTableId.StringTableId_Msg_AnikiGymNotOpen, 2f, null, true);
		}

		// Token: 0x1400019D RID: 413
		// (add) Token: 0x06009271 RID: 37489 RVA: 0x002A57E0 File Offset: 0x002A39E0
		// (remove) Token: 0x06009272 RID: 37490 RVA: 0x002A587C File Offset: 0x002A3A7C
		public event Action<bool, AnikiGymListItemUIController> EventOnToggleValueChanged
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnToggleValueChangedAction`2_hotfix != null)
				{
					this.m_add_EventOnToggleValueChangedAction`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<bool, AnikiGymListItemUIController> action = this.EventOnToggleValueChanged;
				Action<bool, AnikiGymListItemUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<bool, AnikiGymListItemUIController>>(ref this.EventOnToggleValueChanged, (Action<bool, AnikiGymListItemUIController>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnToggleValueChangedAction`2_hotfix != null)
				{
					this.m_remove_EventOnToggleValueChangedAction`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<bool, AnikiGymListItemUIController> action = this.EventOnToggleValueChanged;
				Action<bool, AnikiGymListItemUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<bool, AnikiGymListItemUIController>>(ref this.EventOnToggleValueChanged, (Action<bool, AnikiGymListItemUIController>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17001E4E RID: 7758
		// (get) Token: 0x06009273 RID: 37491 RVA: 0x002A5918 File Offset: 0x002A3B18
		// (set) Token: 0x06009274 RID: 37492 RVA: 0x002A5938 File Offset: 0x002A3B38
		[DoNotToLua]
		public new AnikiGymListItemUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new AnikiGymListItemUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06009275 RID: 37493 RVA: 0x002A5944 File Offset: 0x002A3B44
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x06009276 RID: 37494 RVA: 0x002A5950 File Offset: 0x002A3B50
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x06009277 RID: 37495 RVA: 0x002A5958 File Offset: 0x002A3B58
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x06009278 RID: 37496 RVA: 0x002A5960 File Offset: 0x002A3B60
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x06009279 RID: 37497 RVA: 0x002A5974 File Offset: 0x002A3B74
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0600927A RID: 37498 RVA: 0x002A597C File Offset: 0x002A3B7C
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0600927B RID: 37499 RVA: 0x002A5988 File Offset: 0x002A3B88
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0600927C RID: 37500 RVA: 0x002A5994 File Offset: 0x002A3B94
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0600927D RID: 37501 RVA: 0x002A59A0 File Offset: 0x002A3BA0
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0600927E RID: 37502 RVA: 0x002A59AC File Offset: 0x002A3BAC
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0600927F RID: 37503 RVA: 0x002A59B8 File Offset: 0x002A3BB8
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x06009280 RID: 37504 RVA: 0x002A59C4 File Offset: 0x002A3BC4
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x06009281 RID: 37505 RVA: 0x002A59D0 File Offset: 0x002A3BD0
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x06009282 RID: 37506 RVA: 0x002A59DC File Offset: 0x002A3BDC
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x06009283 RID: 37507 RVA: 0x002A59E8 File Offset: 0x002A3BE8
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x06009284 RID: 37508 RVA: 0x002A59F0 File Offset: 0x002A3BF0
		private void __callDele_EventOnToggleValueChanged(bool arg1, AnikiGymListItemUIController arg2)
		{
			Action<bool, AnikiGymListItemUIController> eventOnToggleValueChanged = this.EventOnToggleValueChanged;
			if (eventOnToggleValueChanged != null)
			{
				eventOnToggleValueChanged(arg1, arg2);
			}
		}

		// Token: 0x06009285 RID: 37509 RVA: 0x002A5A14 File Offset: 0x002A3C14
		private void __clearDele_EventOnToggleValueChanged(bool arg1, AnikiGymListItemUIController arg2)
		{
			this.EventOnToggleValueChanged = null;
		}

		// Token: 0x06009286 RID: 37510 RVA: 0x002A5A20 File Offset: 0x002A3C20
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
					this.m_SetAnikiGymInfoConfigDataAnikiGymInfo_hotfix = (luaObj.RawGet("SetAnikiGymInfo") as LuaFunction);
					this.m_GetAnikiGymInfo_hotfix = (luaObj.RawGet("GetAnikiGymInfo") as LuaFunction);
					this.m_SetLockedBoolean_hotfix = (luaObj.RawGet("SetLocked") as LuaFunction);
					this.m_IsLocked_hotfix = (luaObj.RawGet("IsLocked") as LuaFunction);
					this.m_SetSelectedBoolean_hotfix = (luaObj.RawGet("SetSelected") as LuaFunction);
					this.m_IsSelected_hotfix = (luaObj.RawGet("IsSelected") as LuaFunction);
					this.m_SetExpireTimeDateTime_hotfix = (luaObj.RawGet("SetExpireTime") as LuaFunction);
					this.m_UpdateRemainTime_hotfix = (luaObj.RawGet("UpdateRemainTime") as LuaFunction);
					this.m_Update_hotfix = (luaObj.RawGet("Update") as LuaFunction);
					this.m_OnToggleValueChangedBoolean_hotfix = (luaObj.RawGet("OnToggleValueChanged") as LuaFunction);
					this.m_OnNotOpenButtonClick_hotfix = (luaObj.RawGet("OnNotOpenButtonClick") as LuaFunction);
					this.m_add_EventOnToggleValueChangedAction`2_hotfix = (luaObj.RawGet("add_EventOnToggleValueChanged") as LuaFunction);
					this.m_remove_EventOnToggleValueChangedAction`2_hotfix = (luaObj.RawGet("remove_EventOnToggleValueChanged") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06009287 RID: 37511 RVA: 0x002A5C30 File Offset: 0x002A3E30
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(AnikiGymListItemUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400664B RID: 26187
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_toggle;

		// Token: 0x0400664C RID: 26188
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_uiStateController;

		// Token: 0x0400664D RID: 26189
		[AutoBind("./NameText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_nameText;

		// Token: 0x0400664E RID: 26190
		[AutoBind("./NameTextGray", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_nameTextGray;

		// Token: 0x0400664F RID: 26191
		[AutoBind("./BGImage", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_iconImage;

		// Token: 0x04006650 RID: 26192
		[AutoBind("./BGImageGray", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_iconImageGray;

		// Token: 0x04006651 RID: 26193
		[AutoBind("./OpenTime/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_openTimeText;

		// Token: 0x04006652 RID: 26194
		[AutoBind("./Time", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_timeGameObject;

		// Token: 0x04006653 RID: 26195
		[AutoBind("./Time/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_timeText;

		// Token: 0x04006654 RID: 26196
		[AutoBind("./NotOpenButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_notOpenButton;

		// Token: 0x04006655 RID: 26197
		private ConfigDataAnikiGymInfo m_anikiGymInfo;

		// Token: 0x04006656 RID: 26198
		private bool m_isLocked;

		// Token: 0x04006657 RID: 26199
		private DateTime m_expireTime = DateTime.MaxValue;

		// Token: 0x04006658 RID: 26200
		private float m_updateCountdown;

		// Token: 0x04006659 RID: 26201
		[DoNotToLua]
		private AnikiGymListItemUIController.LuaExportHelper luaExportHelper;

		// Token: 0x0400665A RID: 26202
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400665B RID: 26203
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400665C RID: 26204
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x0400665D RID: 26205
		private LuaFunction m_SetAnikiGymInfoConfigDataAnikiGymInfo_hotfix;

		// Token: 0x0400665E RID: 26206
		private LuaFunction m_GetAnikiGymInfo_hotfix;

		// Token: 0x0400665F RID: 26207
		private LuaFunction m_SetLockedBoolean_hotfix;

		// Token: 0x04006660 RID: 26208
		private LuaFunction m_IsLocked_hotfix;

		// Token: 0x04006661 RID: 26209
		private LuaFunction m_SetSelectedBoolean_hotfix;

		// Token: 0x04006662 RID: 26210
		private LuaFunction m_IsSelected_hotfix;

		// Token: 0x04006663 RID: 26211
		private LuaFunction m_SetExpireTimeDateTime_hotfix;

		// Token: 0x04006664 RID: 26212
		private LuaFunction m_UpdateRemainTime_hotfix;

		// Token: 0x04006665 RID: 26213
		private LuaFunction m_Update_hotfix;

		// Token: 0x04006666 RID: 26214
		private LuaFunction m_OnToggleValueChangedBoolean_hotfix;

		// Token: 0x04006667 RID: 26215
		private LuaFunction m_OnNotOpenButtonClick_hotfix;

		// Token: 0x04006668 RID: 26216
		private LuaFunction m_add_EventOnToggleValueChangedAction;

		// Token: 0x04006669 RID: 26217
		private LuaFunction m_remove_EventOnToggleValueChangedAction;

		// Token: 0x020009CD RID: 2509
		public new class LuaExportHelper
		{
			// Token: 0x06009288 RID: 37512 RVA: 0x002A5C98 File Offset: 0x002A3E98
			public LuaExportHelper(AnikiGymListItemUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06009289 RID: 37513 RVA: 0x002A5CA8 File Offset: 0x002A3EA8
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0600928A RID: 37514 RVA: 0x002A5CB8 File Offset: 0x002A3EB8
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0600928B RID: 37515 RVA: 0x002A5CC8 File Offset: 0x002A3EC8
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600928C RID: 37516 RVA: 0x002A5CD8 File Offset: 0x002A3ED8
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600928D RID: 37517 RVA: 0x002A5CF0 File Offset: 0x002A3EF0
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0600928E RID: 37518 RVA: 0x002A5D00 File Offset: 0x002A3F00
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0600928F RID: 37519 RVA: 0x002A5D10 File Offset: 0x002A3F10
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x06009290 RID: 37520 RVA: 0x002A5D20 File Offset: 0x002A3F20
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x06009291 RID: 37521 RVA: 0x002A5D30 File Offset: 0x002A3F30
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x06009292 RID: 37522 RVA: 0x002A5D40 File Offset: 0x002A3F40
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x06009293 RID: 37523 RVA: 0x002A5D50 File Offset: 0x002A3F50
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x06009294 RID: 37524 RVA: 0x002A5D60 File Offset: 0x002A3F60
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x06009295 RID: 37525 RVA: 0x002A5D70 File Offset: 0x002A3F70
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x06009296 RID: 37526 RVA: 0x002A5D80 File Offset: 0x002A3F80
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x06009297 RID: 37527 RVA: 0x002A5D90 File Offset: 0x002A3F90
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x06009298 RID: 37528 RVA: 0x002A5DA0 File Offset: 0x002A3FA0
			public void __callDele_EventOnToggleValueChanged(bool arg1, AnikiGymListItemUIController arg2)
			{
				this.m_owner.__callDele_EventOnToggleValueChanged(arg1, arg2);
			}

			// Token: 0x06009299 RID: 37529 RVA: 0x002A5DB0 File Offset: 0x002A3FB0
			public void __clearDele_EventOnToggleValueChanged(bool arg1, AnikiGymListItemUIController arg2)
			{
				this.m_owner.__clearDele_EventOnToggleValueChanged(arg1, arg2);
			}

			// Token: 0x17001E4F RID: 7759
			// (get) Token: 0x0600929A RID: 37530 RVA: 0x002A5DC0 File Offset: 0x002A3FC0
			// (set) Token: 0x0600929B RID: 37531 RVA: 0x002A5DD0 File Offset: 0x002A3FD0
			public Toggle m_toggle
			{
				get
				{
					return this.m_owner.m_toggle;
				}
				set
				{
					this.m_owner.m_toggle = value;
				}
			}

			// Token: 0x17001E50 RID: 7760
			// (get) Token: 0x0600929C RID: 37532 RVA: 0x002A5DE0 File Offset: 0x002A3FE0
			// (set) Token: 0x0600929D RID: 37533 RVA: 0x002A5DF0 File Offset: 0x002A3FF0
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

			// Token: 0x17001E51 RID: 7761
			// (get) Token: 0x0600929E RID: 37534 RVA: 0x002A5E00 File Offset: 0x002A4000
			// (set) Token: 0x0600929F RID: 37535 RVA: 0x002A5E10 File Offset: 0x002A4010
			public Text m_nameText
			{
				get
				{
					return this.m_owner.m_nameText;
				}
				set
				{
					this.m_owner.m_nameText = value;
				}
			}

			// Token: 0x17001E52 RID: 7762
			// (get) Token: 0x060092A0 RID: 37536 RVA: 0x002A5E20 File Offset: 0x002A4020
			// (set) Token: 0x060092A1 RID: 37537 RVA: 0x002A5E30 File Offset: 0x002A4030
			public Text m_nameTextGray
			{
				get
				{
					return this.m_owner.m_nameTextGray;
				}
				set
				{
					this.m_owner.m_nameTextGray = value;
				}
			}

			// Token: 0x17001E53 RID: 7763
			// (get) Token: 0x060092A2 RID: 37538 RVA: 0x002A5E40 File Offset: 0x002A4040
			// (set) Token: 0x060092A3 RID: 37539 RVA: 0x002A5E50 File Offset: 0x002A4050
			public Image m_iconImage
			{
				get
				{
					return this.m_owner.m_iconImage;
				}
				set
				{
					this.m_owner.m_iconImage = value;
				}
			}

			// Token: 0x17001E54 RID: 7764
			// (get) Token: 0x060092A4 RID: 37540 RVA: 0x002A5E60 File Offset: 0x002A4060
			// (set) Token: 0x060092A5 RID: 37541 RVA: 0x002A5E70 File Offset: 0x002A4070
			public Image m_iconImageGray
			{
				get
				{
					return this.m_owner.m_iconImageGray;
				}
				set
				{
					this.m_owner.m_iconImageGray = value;
				}
			}

			// Token: 0x17001E55 RID: 7765
			// (get) Token: 0x060092A6 RID: 37542 RVA: 0x002A5E80 File Offset: 0x002A4080
			// (set) Token: 0x060092A7 RID: 37543 RVA: 0x002A5E90 File Offset: 0x002A4090
			public Text m_openTimeText
			{
				get
				{
					return this.m_owner.m_openTimeText;
				}
				set
				{
					this.m_owner.m_openTimeText = value;
				}
			}

			// Token: 0x17001E56 RID: 7766
			// (get) Token: 0x060092A8 RID: 37544 RVA: 0x002A5EA0 File Offset: 0x002A40A0
			// (set) Token: 0x060092A9 RID: 37545 RVA: 0x002A5EB0 File Offset: 0x002A40B0
			public GameObject m_timeGameObject
			{
				get
				{
					return this.m_owner.m_timeGameObject;
				}
				set
				{
					this.m_owner.m_timeGameObject = value;
				}
			}

			// Token: 0x17001E57 RID: 7767
			// (get) Token: 0x060092AA RID: 37546 RVA: 0x002A5EC0 File Offset: 0x002A40C0
			// (set) Token: 0x060092AB RID: 37547 RVA: 0x002A5ED0 File Offset: 0x002A40D0
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

			// Token: 0x17001E58 RID: 7768
			// (get) Token: 0x060092AC RID: 37548 RVA: 0x002A5EE0 File Offset: 0x002A40E0
			// (set) Token: 0x060092AD RID: 37549 RVA: 0x002A5EF0 File Offset: 0x002A40F0
			public Button m_notOpenButton
			{
				get
				{
					return this.m_owner.m_notOpenButton;
				}
				set
				{
					this.m_owner.m_notOpenButton = value;
				}
			}

			// Token: 0x17001E59 RID: 7769
			// (get) Token: 0x060092AE RID: 37550 RVA: 0x002A5F00 File Offset: 0x002A4100
			// (set) Token: 0x060092AF RID: 37551 RVA: 0x002A5F10 File Offset: 0x002A4110
			public ConfigDataAnikiGymInfo m_anikiGymInfo
			{
				get
				{
					return this.m_owner.m_anikiGymInfo;
				}
				set
				{
					this.m_owner.m_anikiGymInfo = value;
				}
			}

			// Token: 0x17001E5A RID: 7770
			// (get) Token: 0x060092B0 RID: 37552 RVA: 0x002A5F20 File Offset: 0x002A4120
			// (set) Token: 0x060092B1 RID: 37553 RVA: 0x002A5F30 File Offset: 0x002A4130
			public bool m_isLocked
			{
				get
				{
					return this.m_owner.m_isLocked;
				}
				set
				{
					this.m_owner.m_isLocked = value;
				}
			}

			// Token: 0x17001E5B RID: 7771
			// (get) Token: 0x060092B2 RID: 37554 RVA: 0x002A5F40 File Offset: 0x002A4140
			// (set) Token: 0x060092B3 RID: 37555 RVA: 0x002A5F50 File Offset: 0x002A4150
			public DateTime m_expireTime
			{
				get
				{
					return this.m_owner.m_expireTime;
				}
				set
				{
					this.m_owner.m_expireTime = value;
				}
			}

			// Token: 0x17001E5C RID: 7772
			// (get) Token: 0x060092B4 RID: 37556 RVA: 0x002A5F60 File Offset: 0x002A4160
			// (set) Token: 0x060092B5 RID: 37557 RVA: 0x002A5F70 File Offset: 0x002A4170
			public float m_updateCountdown
			{
				get
				{
					return this.m_owner.m_updateCountdown;
				}
				set
				{
					this.m_owner.m_updateCountdown = value;
				}
			}

			// Token: 0x060092B6 RID: 37558 RVA: 0x002A5F80 File Offset: 0x002A4180
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x060092B7 RID: 37559 RVA: 0x002A5F90 File Offset: 0x002A4190
			public void UpdateRemainTime()
			{
				this.m_owner.UpdateRemainTime();
			}

			// Token: 0x060092B8 RID: 37560 RVA: 0x002A5FA0 File Offset: 0x002A41A0
			public void Update()
			{
				this.m_owner.Update();
			}

			// Token: 0x060092B9 RID: 37561 RVA: 0x002A5FB0 File Offset: 0x002A41B0
			public void OnToggleValueChanged(bool on)
			{
				this.m_owner.OnToggleValueChanged(on);
			}

			// Token: 0x060092BA RID: 37562 RVA: 0x002A5FC0 File Offset: 0x002A41C0
			public void OnNotOpenButtonClick()
			{
				this.m_owner.OnNotOpenButtonClick();
			}

			// Token: 0x0400666A RID: 26218
			private AnikiGymListItemUIController m_owner;
		}
	}
}
