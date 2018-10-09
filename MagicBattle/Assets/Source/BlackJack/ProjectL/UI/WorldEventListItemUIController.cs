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
	// Token: 0x02001035 RID: 4149
	[HotFix]
	public class WorldEventListItemUIController : UIControllerBase
	{
		// Token: 0x060151D4 RID: 86484 RVA: 0x00557128 File Offset: 0x00555328
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
			this.m_button.onClick.AddListener(new UnityAction(this.OnClick));
		}

		// Token: 0x060151D5 RID: 86485 RVA: 0x005571AC File Offset: 0x005553AC
		public void SetEventInfo(ConfigDataWaypointInfo waypointInfo, ConfigDataEventInfo eventInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetEventInfoConfigDataWaypointInfoConfigDataEventInfo_hotfix != null)
			{
				this.m_SetEventInfoConfigDataWaypointInfoConfigDataEventInfo_hotfix.call(new object[]
				{
					this,
					waypointInfo,
					eventInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_wayPointInfo = waypointInfo;
			this.m_eventInfo = eventInfo;
			this.m_titleText.text = eventInfo.Name;
			this.m_energyText.text = eventInfo.EnergySuccess.ToString();
			this.m_levelText.text = eventInfo.MonsterLevel.ToString();
			this.m_iconImage.sprite = AssetUtility.Instance.GetSprite(eventInfo.Icon);
		}

		// Token: 0x060151D6 RID: 86486 RVA: 0x005572A4 File Offset: 0x005554A4
		public void SetExpireTime(long expireTime)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetExpireTimeInt64_hotfix != null)
			{
				this.m_SetExpireTimeInt64_hotfix.call(new object[]
				{
					this,
					expireTime
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_expireTime = new DateTime(expireTime);
			this.UpdateRemainTime();
			if (this.m_expireTime != DateTime.MaxValue)
			{
				this.m_updateCountdown = 1f;
			}
		}

		// Token: 0x060151D7 RID: 86487 RVA: 0x00557348 File Offset: 0x00555548
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

		// Token: 0x060151D8 RID: 86488 RVA: 0x00557454 File Offset: 0x00555654
		public ConfigDataWaypointInfo GetWaypointInfo()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetWaypointInfo_hotfix != null)
			{
				return (ConfigDataWaypointInfo)this.m_GetWaypointInfo_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_wayPointInfo;
		}

		// Token: 0x060151D9 RID: 86489 RVA: 0x005574C8 File Offset: 0x005556C8
		public ConfigDataEventInfo GetEventInfo()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetEventInfo_hotfix != null)
			{
				return (ConfigDataEventInfo)this.m_GetEventInfo_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_eventInfo;
		}

		// Token: 0x060151DA RID: 86490 RVA: 0x0055753C File Offset: 0x0055573C
		private void OnClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnClick_hotfix != null)
			{
				this.m_OnClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnClick != null)
			{
				this.EventOnClick(this);
			}
		}

		// Token: 0x060151DB RID: 86491 RVA: 0x005575B4 File Offset: 0x005557B4
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

		// Token: 0x140004C8 RID: 1224
		// (add) Token: 0x060151DC RID: 86492 RVA: 0x00557660 File Offset: 0x00555860
		// (remove) Token: 0x060151DD RID: 86493 RVA: 0x005576FC File Offset: 0x005558FC
		public event Action<WorldEventListItemUIController> EventOnClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnClickAction`1_hotfix != null)
				{
					this.m_add_EventOnClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<WorldEventListItemUIController> action = this.EventOnClick;
				Action<WorldEventListItemUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<WorldEventListItemUIController>>(ref this.EventOnClick, (Action<WorldEventListItemUIController>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnClickAction`1_hotfix != null)
				{
					this.m_remove_EventOnClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<WorldEventListItemUIController> action = this.EventOnClick;
				Action<WorldEventListItemUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<WorldEventListItemUIController>>(ref this.EventOnClick, (Action<WorldEventListItemUIController>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17003E12 RID: 15890
		// (get) Token: 0x060151DE RID: 86494 RVA: 0x00557798 File Offset: 0x00555998
		// (set) Token: 0x060151DF RID: 86495 RVA: 0x005577B8 File Offset: 0x005559B8
		[DoNotToLua]
		public new WorldEventListItemUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new WorldEventListItemUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x060151E0 RID: 86496 RVA: 0x005577C4 File Offset: 0x005559C4
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x060151E1 RID: 86497 RVA: 0x005577D0 File Offset: 0x005559D0
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x060151E2 RID: 86498 RVA: 0x005577D8 File Offset: 0x005559D8
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x060151E3 RID: 86499 RVA: 0x005577E0 File Offset: 0x005559E0
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x060151E4 RID: 86500 RVA: 0x005577F4 File Offset: 0x005559F4
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x060151E5 RID: 86501 RVA: 0x005577FC File Offset: 0x005559FC
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x060151E6 RID: 86502 RVA: 0x00557808 File Offset: 0x00555A08
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x060151E7 RID: 86503 RVA: 0x00557814 File Offset: 0x00555A14
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x060151E8 RID: 86504 RVA: 0x00557820 File Offset: 0x00555A20
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x060151E9 RID: 86505 RVA: 0x0055782C File Offset: 0x00555A2C
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x060151EA RID: 86506 RVA: 0x00557838 File Offset: 0x00555A38
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x060151EB RID: 86507 RVA: 0x00557844 File Offset: 0x00555A44
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x060151EC RID: 86508 RVA: 0x00557850 File Offset: 0x00555A50
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x060151ED RID: 86509 RVA: 0x0055785C File Offset: 0x00555A5C
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x060151EE RID: 86510 RVA: 0x00557868 File Offset: 0x00555A68
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x060151EF RID: 86511 RVA: 0x00557870 File Offset: 0x00555A70
		private void __callDele_EventOnClick(WorldEventListItemUIController obj)
		{
			Action<WorldEventListItemUIController> eventOnClick = this.EventOnClick;
			if (eventOnClick != null)
			{
				eventOnClick(obj);
			}
		}

		// Token: 0x060151F0 RID: 86512 RVA: 0x00557894 File Offset: 0x00555A94
		private void __clearDele_EventOnClick(WorldEventListItemUIController obj)
		{
			this.EventOnClick = null;
		}

		// Token: 0x060151F1 RID: 86513 RVA: 0x005578A0 File Offset: 0x00555AA0
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
					this.m_SetEventInfoConfigDataWaypointInfoConfigDataEventInfo_hotfix = (luaObj.RawGet("SetEventInfo") as LuaFunction);
					this.m_SetExpireTimeInt64_hotfix = (luaObj.RawGet("SetExpireTime") as LuaFunction);
					this.m_UpdateRemainTime_hotfix = (luaObj.RawGet("UpdateRemainTime") as LuaFunction);
					this.m_GetWaypointInfo_hotfix = (luaObj.RawGet("GetWaypointInfo") as LuaFunction);
					this.m_GetEventInfo_hotfix = (luaObj.RawGet("GetEventInfo") as LuaFunction);
					this.m_OnClick_hotfix = (luaObj.RawGet("OnClick") as LuaFunction);
					this.m_Update_hotfix = (luaObj.RawGet("Update") as LuaFunction);
					this.m_add_EventOnClickAction`1_hotfix = (luaObj.RawGet("add_EventOnClick") as LuaFunction);
					this.m_remove_EventOnClickAction`1_hotfix = (luaObj.RawGet("remove_EventOnClick") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x060151F2 RID: 86514 RVA: 0x00557A4C File Offset: 0x00555C4C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(WorldEventListItemUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400B84C RID: 47180
		[AutoBind("./Panel", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_button;

		// Token: 0x0400B84D RID: 47181
		[AutoBind("./Panel/Icon", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_iconImage;

		// Token: 0x0400B84E RID: 47182
		[AutoBind("./Panel/Title/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_titleText;

		// Token: 0x0400B84F RID: 47183
		[AutoBind("./Panel/Energy/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_energyText;

		// Token: 0x0400B850 RID: 47184
		[AutoBind("./Panel/Level/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_levelText;

		// Token: 0x0400B851 RID: 47185
		[AutoBind("./Panel/Time", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_timeGameObject;

		// Token: 0x0400B852 RID: 47186
		[AutoBind("./Panel/Time/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_timeText;

		// Token: 0x0400B853 RID: 47187
		private ConfigDataWaypointInfo m_wayPointInfo;

		// Token: 0x0400B854 RID: 47188
		private ConfigDataEventInfo m_eventInfo;

		// Token: 0x0400B855 RID: 47189
		private DateTime m_expireTime = DateTime.MaxValue;

		// Token: 0x0400B856 RID: 47190
		private float m_updateCountdown;

		// Token: 0x0400B857 RID: 47191
		[DoNotToLua]
		private WorldEventListItemUIController.LuaExportHelper luaExportHelper;

		// Token: 0x0400B858 RID: 47192
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400B859 RID: 47193
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400B85A RID: 47194
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x0400B85B RID: 47195
		private LuaFunction m_SetEventInfoConfigDataWaypointInfoConfigDataEventInfo_hotfix;

		// Token: 0x0400B85C RID: 47196
		private LuaFunction m_SetExpireTimeInt64_hotfix;

		// Token: 0x0400B85D RID: 47197
		private LuaFunction m_UpdateRemainTime_hotfix;

		// Token: 0x0400B85E RID: 47198
		private LuaFunction m_GetWaypointInfo_hotfix;

		// Token: 0x0400B85F RID: 47199
		private LuaFunction m_GetEventInfo_hotfix;

		// Token: 0x0400B860 RID: 47200
		private LuaFunction m_OnClick_hotfix;

		// Token: 0x0400B861 RID: 47201
		private LuaFunction m_Update_hotfix;

		// Token: 0x0400B862 RID: 47202
		private LuaFunction m_add_EventOnClickAction;

		// Token: 0x0400B863 RID: 47203
		private LuaFunction m_remove_EventOnClickAction;

		// Token: 0x02001036 RID: 4150
		public new class LuaExportHelper
		{
			// Token: 0x060151F3 RID: 86515 RVA: 0x00557AB4 File Offset: 0x00555CB4
			public LuaExportHelper(WorldEventListItemUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x060151F4 RID: 86516 RVA: 0x00557AC4 File Offset: 0x00555CC4
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x060151F5 RID: 86517 RVA: 0x00557AD4 File Offset: 0x00555CD4
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x060151F6 RID: 86518 RVA: 0x00557AE4 File Offset: 0x00555CE4
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x060151F7 RID: 86519 RVA: 0x00557AF4 File Offset: 0x00555CF4
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x060151F8 RID: 86520 RVA: 0x00557B0C File Offset: 0x00555D0C
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x060151F9 RID: 86521 RVA: 0x00557B1C File Offset: 0x00555D1C
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x060151FA RID: 86522 RVA: 0x00557B2C File Offset: 0x00555D2C
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x060151FB RID: 86523 RVA: 0x00557B3C File Offset: 0x00555D3C
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x060151FC RID: 86524 RVA: 0x00557B4C File Offset: 0x00555D4C
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x060151FD RID: 86525 RVA: 0x00557B5C File Offset: 0x00555D5C
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x060151FE RID: 86526 RVA: 0x00557B6C File Offset: 0x00555D6C
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x060151FF RID: 86527 RVA: 0x00557B7C File Offset: 0x00555D7C
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x06015200 RID: 86528 RVA: 0x00557B8C File Offset: 0x00555D8C
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x06015201 RID: 86529 RVA: 0x00557B9C File Offset: 0x00555D9C
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x06015202 RID: 86530 RVA: 0x00557BAC File Offset: 0x00555DAC
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x06015203 RID: 86531 RVA: 0x00557BBC File Offset: 0x00555DBC
			public void __callDele_EventOnClick(WorldEventListItemUIController obj)
			{
				this.m_owner.__callDele_EventOnClick(obj);
			}

			// Token: 0x06015204 RID: 86532 RVA: 0x00557BCC File Offset: 0x00555DCC
			public void __clearDele_EventOnClick(WorldEventListItemUIController obj)
			{
				this.m_owner.__clearDele_EventOnClick(obj);
			}

			// Token: 0x17003E13 RID: 15891
			// (get) Token: 0x06015205 RID: 86533 RVA: 0x00557BDC File Offset: 0x00555DDC
			// (set) Token: 0x06015206 RID: 86534 RVA: 0x00557BEC File Offset: 0x00555DEC
			public Button m_button
			{
				get
				{
					return this.m_owner.m_button;
				}
				set
				{
					this.m_owner.m_button = value;
				}
			}

			// Token: 0x17003E14 RID: 15892
			// (get) Token: 0x06015207 RID: 86535 RVA: 0x00557BFC File Offset: 0x00555DFC
			// (set) Token: 0x06015208 RID: 86536 RVA: 0x00557C0C File Offset: 0x00555E0C
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

			// Token: 0x17003E15 RID: 15893
			// (get) Token: 0x06015209 RID: 86537 RVA: 0x00557C1C File Offset: 0x00555E1C
			// (set) Token: 0x0601520A RID: 86538 RVA: 0x00557C2C File Offset: 0x00555E2C
			public Text m_titleText
			{
				get
				{
					return this.m_owner.m_titleText;
				}
				set
				{
					this.m_owner.m_titleText = value;
				}
			}

			// Token: 0x17003E16 RID: 15894
			// (get) Token: 0x0601520B RID: 86539 RVA: 0x00557C3C File Offset: 0x00555E3C
			// (set) Token: 0x0601520C RID: 86540 RVA: 0x00557C4C File Offset: 0x00555E4C
			public Text m_energyText
			{
				get
				{
					return this.m_owner.m_energyText;
				}
				set
				{
					this.m_owner.m_energyText = value;
				}
			}

			// Token: 0x17003E17 RID: 15895
			// (get) Token: 0x0601520D RID: 86541 RVA: 0x00557C5C File Offset: 0x00555E5C
			// (set) Token: 0x0601520E RID: 86542 RVA: 0x00557C6C File Offset: 0x00555E6C
			public Text m_levelText
			{
				get
				{
					return this.m_owner.m_levelText;
				}
				set
				{
					this.m_owner.m_levelText = value;
				}
			}

			// Token: 0x17003E18 RID: 15896
			// (get) Token: 0x0601520F RID: 86543 RVA: 0x00557C7C File Offset: 0x00555E7C
			// (set) Token: 0x06015210 RID: 86544 RVA: 0x00557C8C File Offset: 0x00555E8C
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

			// Token: 0x17003E19 RID: 15897
			// (get) Token: 0x06015211 RID: 86545 RVA: 0x00557C9C File Offset: 0x00555E9C
			// (set) Token: 0x06015212 RID: 86546 RVA: 0x00557CAC File Offset: 0x00555EAC
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

			// Token: 0x17003E1A RID: 15898
			// (get) Token: 0x06015213 RID: 86547 RVA: 0x00557CBC File Offset: 0x00555EBC
			// (set) Token: 0x06015214 RID: 86548 RVA: 0x00557CCC File Offset: 0x00555ECC
			public ConfigDataWaypointInfo m_wayPointInfo
			{
				get
				{
					return this.m_owner.m_wayPointInfo;
				}
				set
				{
					this.m_owner.m_wayPointInfo = value;
				}
			}

			// Token: 0x17003E1B RID: 15899
			// (get) Token: 0x06015215 RID: 86549 RVA: 0x00557CDC File Offset: 0x00555EDC
			// (set) Token: 0x06015216 RID: 86550 RVA: 0x00557CEC File Offset: 0x00555EEC
			public ConfigDataEventInfo m_eventInfo
			{
				get
				{
					return this.m_owner.m_eventInfo;
				}
				set
				{
					this.m_owner.m_eventInfo = value;
				}
			}

			// Token: 0x17003E1C RID: 15900
			// (get) Token: 0x06015217 RID: 86551 RVA: 0x00557CFC File Offset: 0x00555EFC
			// (set) Token: 0x06015218 RID: 86552 RVA: 0x00557D0C File Offset: 0x00555F0C
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

			// Token: 0x17003E1D RID: 15901
			// (get) Token: 0x06015219 RID: 86553 RVA: 0x00557D1C File Offset: 0x00555F1C
			// (set) Token: 0x0601521A RID: 86554 RVA: 0x00557D2C File Offset: 0x00555F2C
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

			// Token: 0x0601521B RID: 86555 RVA: 0x00557D3C File Offset: 0x00555F3C
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0601521C RID: 86556 RVA: 0x00557D4C File Offset: 0x00555F4C
			public void UpdateRemainTime()
			{
				this.m_owner.UpdateRemainTime();
			}

			// Token: 0x0601521D RID: 86557 RVA: 0x00557D5C File Offset: 0x00555F5C
			public void OnClick()
			{
				this.m_owner.OnClick();
			}

			// Token: 0x0601521E RID: 86558 RVA: 0x00557D6C File Offset: 0x00555F6C
			public void Update()
			{
				this.m_owner.Update();
			}

			// Token: 0x0400B864 RID: 47204
			private WorldEventListItemUIController m_owner;
		}
	}
}
