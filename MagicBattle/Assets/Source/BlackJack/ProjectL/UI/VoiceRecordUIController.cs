using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using SLua;
using UnityEngine;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000B7B RID: 2939
	[HotFix]
	public class VoiceRecordUIController : UIControllerBase
	{
		// Token: 0x0600C7D2 RID: 51154 RVA: 0x00375FD8 File Offset: 0x003741D8
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
		}

		// Token: 0x0600C7D3 RID: 51155 RVA: 0x00376040 File Offset: 0x00374240
		public void ShowVoiceRecordTip()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowVoiceRecordTip_hotfix != null)
			{
				this.m_ShowVoiceRecordTip_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.voiceRecordStateUICtrl.SetToUIState("Send", false, true);
		}

		// Token: 0x0600C7D4 RID: 51156 RVA: 0x003760B4 File Offset: 0x003742B4
		public void HideVoiceRecordTip()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HideVoiceRecordTip_hotfix != null)
			{
				this.m_HideVoiceRecordTip_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.voiceRecordStateUICtrl.SetToUIState("Hide", false, true);
		}

		// Token: 0x0600C7D5 RID: 51157 RVA: 0x00376128 File Offset: 0x00374328
		public void ShowVoiceCancelTip()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowVoiceCancelTip_hotfix != null)
			{
				this.m_ShowVoiceCancelTip_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.voiceRecordStateUICtrl.SetToUIState("Cancel", false, true);
		}

		// Token: 0x0600C7D6 RID: 51158 RVA: 0x0037619C File Offset: 0x0037439C
		public void ShowVoiceShortTip()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowVoiceShortTip_hotfix != null)
			{
				this.m_ShowVoiceShortTip_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.voiceRecordStateUICtrl.SetToUIState("Short", false, true);
		}

		// Token: 0x0600C7D7 RID: 51159 RVA: 0x00376210 File Offset: 0x00374410
		public void UpdateVoiceRecordTime(float time)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateVoiceRecordTimeSingle_hotfix != null)
			{
				this.m_UpdateVoiceRecordTimeSingle_hotfix.call(new object[]
				{
					this,
					time
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			time = Mathf.Clamp(time, 0f, 20f);
			this.recordTimeProgressBar.fillAmount = 1f - time / 20f;
			this.voiceTimeText.text = string.Format(this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Chat_VoiceRecordCountDownTip), (int)(20f - time));
		}

		// Token: 0x170027CA RID: 10186
		// (get) Token: 0x0600C7D8 RID: 51160 RVA: 0x003762D8 File Offset: 0x003744D8
		// (set) Token: 0x0600C7D9 RID: 51161 RVA: 0x003762F8 File Offset: 0x003744F8
		[DoNotToLua]
		public new VoiceRecordUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new VoiceRecordUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600C7DA RID: 51162 RVA: 0x00376304 File Offset: 0x00374504
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0600C7DB RID: 51163 RVA: 0x00376310 File Offset: 0x00374510
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0600C7DC RID: 51164 RVA: 0x00376318 File Offset: 0x00374518
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0600C7DD RID: 51165 RVA: 0x00376320 File Offset: 0x00374520
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0600C7DE RID: 51166 RVA: 0x00376334 File Offset: 0x00374534
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0600C7DF RID: 51167 RVA: 0x0037633C File Offset: 0x0037453C
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0600C7E0 RID: 51168 RVA: 0x00376348 File Offset: 0x00374548
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0600C7E1 RID: 51169 RVA: 0x00376354 File Offset: 0x00374554
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0600C7E2 RID: 51170 RVA: 0x00376360 File Offset: 0x00374560
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0600C7E3 RID: 51171 RVA: 0x0037636C File Offset: 0x0037456C
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0600C7E4 RID: 51172 RVA: 0x00376378 File Offset: 0x00374578
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0600C7E5 RID: 51173 RVA: 0x00376384 File Offset: 0x00374584
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0600C7E6 RID: 51174 RVA: 0x00376390 File Offset: 0x00374590
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0600C7E7 RID: 51175 RVA: 0x0037639C File Offset: 0x0037459C
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0600C7E8 RID: 51176 RVA: 0x003763A8 File Offset: 0x003745A8
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600C7E9 RID: 51177 RVA: 0x003763B0 File Offset: 0x003745B0
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
					this.m_ShowVoiceRecordTip_hotfix = (luaObj.RawGet("ShowVoiceRecordTip") as LuaFunction);
					this.m_HideVoiceRecordTip_hotfix = (luaObj.RawGet("HideVoiceRecordTip") as LuaFunction);
					this.m_ShowVoiceCancelTip_hotfix = (luaObj.RawGet("ShowVoiceCancelTip") as LuaFunction);
					this.m_ShowVoiceShortTip_hotfix = (luaObj.RawGet("ShowVoiceShortTip") as LuaFunction);
					this.m_UpdateVoiceRecordTimeSingle_hotfix = (luaObj.RawGet("UpdateVoiceRecordTime") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600C7EA RID: 51178 RVA: 0x003764F8 File Offset: 0x003746F8
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(VoiceRecordUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04007E79 RID: 32377
		[AutoBind("./SoundMessage/Send/Text", AutoBindAttribute.InitState.NotInit, false)]
		public Text voiceTimeText;

		// Token: 0x04007E7A RID: 32378
		[AutoBind("./SoundMessage", AutoBindAttribute.InitState.NotInit, false)]
		public CommonUIStateController voiceRecordStateUICtrl;

		// Token: 0x04007E7B RID: 32379
		[AutoBind("./SoundMessage/Send/ProgressBar", AutoBindAttribute.InitState.NotInit, false)]
		public Image recordTimeProgressBar;

		// Token: 0x04007E7C RID: 32380
		private IConfigDataLoader m_configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;

		// Token: 0x04007E7D RID: 32381
		[DoNotToLua]
		private VoiceRecordUIController.LuaExportHelper luaExportHelper;

		// Token: 0x04007E7E RID: 32382
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04007E7F RID: 32383
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04007E80 RID: 32384
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x04007E81 RID: 32385
		private LuaFunction m_ShowVoiceRecordTip_hotfix;

		// Token: 0x04007E82 RID: 32386
		private LuaFunction m_HideVoiceRecordTip_hotfix;

		// Token: 0x04007E83 RID: 32387
		private LuaFunction m_ShowVoiceCancelTip_hotfix;

		// Token: 0x04007E84 RID: 32388
		private LuaFunction m_ShowVoiceShortTip_hotfix;

		// Token: 0x04007E85 RID: 32389
		private LuaFunction m_UpdateVoiceRecordTimeSingle_hotfix;

		// Token: 0x02000B7C RID: 2940
		public new class LuaExportHelper
		{
			// Token: 0x0600C7EB RID: 51179 RVA: 0x00376560 File Offset: 0x00374760
			public LuaExportHelper(VoiceRecordUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600C7EC RID: 51180 RVA: 0x00376570 File Offset: 0x00374770
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0600C7ED RID: 51181 RVA: 0x00376580 File Offset: 0x00374780
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0600C7EE RID: 51182 RVA: 0x00376590 File Offset: 0x00374790
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600C7EF RID: 51183 RVA: 0x003765A0 File Offset: 0x003747A0
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600C7F0 RID: 51184 RVA: 0x003765B8 File Offset: 0x003747B8
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0600C7F1 RID: 51185 RVA: 0x003765C8 File Offset: 0x003747C8
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0600C7F2 RID: 51186 RVA: 0x003765D8 File Offset: 0x003747D8
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0600C7F3 RID: 51187 RVA: 0x003765E8 File Offset: 0x003747E8
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0600C7F4 RID: 51188 RVA: 0x003765F8 File Offset: 0x003747F8
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0600C7F5 RID: 51189 RVA: 0x00376608 File Offset: 0x00374808
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0600C7F6 RID: 51190 RVA: 0x00376618 File Offset: 0x00374818
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0600C7F7 RID: 51191 RVA: 0x00376628 File Offset: 0x00374828
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0600C7F8 RID: 51192 RVA: 0x00376638 File Offset: 0x00374838
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0600C7F9 RID: 51193 RVA: 0x00376648 File Offset: 0x00374848
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0600C7FA RID: 51194 RVA: 0x00376658 File Offset: 0x00374858
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x170027CB RID: 10187
			// (get) Token: 0x0600C7FB RID: 51195 RVA: 0x00376668 File Offset: 0x00374868
			// (set) Token: 0x0600C7FC RID: 51196 RVA: 0x00376678 File Offset: 0x00374878
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

			// Token: 0x0600C7FD RID: 51197 RVA: 0x00376688 File Offset: 0x00374888
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x04007E86 RID: 32390
			private VoiceRecordUIController m_owner;
		}
	}
}
