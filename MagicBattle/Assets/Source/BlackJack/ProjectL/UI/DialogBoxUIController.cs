using System;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.Art;
using SLua;
using UnityEngine;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000C35 RID: 3125
	[HotFix]
	public class DialogBoxUIController : UIControllerBase
	{
		// Token: 0x0600DB63 RID: 56163 RVA: 0x003B7DA0 File Offset: 0x003B5FA0
		public void Show(bool show)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowBoolean_hotfix != null)
			{
				this.m_ShowBoolean_hotfix.call(new object[]
				{
					this,
					show
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.gameObject.SetActive(show);
			if (!show)
			{
				this.m_isOpened = false;
			}
		}

		// Token: 0x0600DB64 RID: 56164 RVA: 0x003B7E2C File Offset: 0x003B602C
		public void Open(Action onFinished = null)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OpenAction_hotfix != null)
			{
				this.m_OpenAction_hotfix.call(new object[]
				{
					this,
					onFinished
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetUIStateOpen(this.m_uiStateController, this.m_openStateName, onFinished, false, true);
			this.m_isOpened = true;
		}

		// Token: 0x0600DB65 RID: 56165 RVA: 0x003B7EB8 File Offset: 0x003B60B8
		public void Close(Action onFinished = null)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CloseAction_hotfix != null)
			{
				this.m_CloseAction_hotfix.call(new object[]
				{
					this,
					onFinished
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetUIStateClose(this.m_uiStateController, this.m_closeStateName, onFinished, false, true);
			this.m_isOpened = false;
		}

		// Token: 0x0600DB66 RID: 56166 RVA: 0x003B7F44 File Offset: 0x003B6144
		public bool IsOpened()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsOpened_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsOpened_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_isOpened;
		}

		// Token: 0x0600DB67 RID: 56167 RVA: 0x003B7FB8 File Offset: 0x003B61B8
		public void SetStyle(int positionType, int frameType)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetStyleInt32Int32_hotfix != null)
			{
				this.m_SetStyleInt32Int32_hotfix.call(new object[]
				{
					this,
					positionType,
					frameType
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_openStateName = string.Empty;
			this.m_closeStateName = string.Empty;
			if (positionType == 0)
			{
				this.m_openStateName = "Left";
				this.m_closeStateName = "Left";
			}
			else
			{
				this.m_openStateName = "Right";
				this.m_closeStateName = "Right";
			}
			if (frameType == 0)
			{
				this.m_openStateName += "Normal";
				this.m_closeStateName += "Normal";
			}
			else
			{
				this.m_openStateName += "Intense";
				this.m_closeStateName += "Intense";
			}
			this.m_openStateName += "In";
			this.m_closeStateName += "Out";
		}

		// Token: 0x0600DB68 RID: 56168 RVA: 0x003B8114 File Offset: 0x003B6314
		public void SetName(string name)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetNameString_hotfix != null)
			{
				this.m_SetNameString_hotfix.call(new object[]
				{
					this,
					name
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_nameText.text = name;
		}

		// Token: 0x0600DB69 RID: 56169 RVA: 0x003B8190 File Offset: 0x003B6390
		public void SetWords(string txt)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetWordsString_hotfix != null)
			{
				this.m_SetWordsString_hotfix.call(new object[]
				{
					this,
					txt
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_text.text = txt;
			this.m_text.SetDisplayCharacterCount(0);
			this.m_time = 0f;
			this.m_wordsDisplayLength = 0;
			this.m_wordsDisplayLengthMax = this.m_text.GetDisplayCharacterCountMax(txt);
			this.m_waitGameObject.SetActive(false);
		}

		// Token: 0x0600DB6A RID: 56170 RVA: 0x003B8248 File Offset: 0x003B6448
		public void SetVoicePlayTime(float voicePlayTime)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetVoicePlayTimeSingle_hotfix != null)
			{
				this.m_SetVoicePlayTimeSingle_hotfix.call(new object[]
				{
					this,
					voicePlayTime
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_voicePlayTime = voicePlayTime;
		}

		// Token: 0x0600DB6B RID: 56171 RVA: 0x003B82C0 File Offset: 0x003B64C0
		public float GetWordsDisplayTime()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetWordsDisplayTime_hotfix != null)
			{
				return Convert.ToSingle(this.m_GetWordsDisplayTime_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return (float)this.m_wordsDisplayLengthMax / 30f;
		}

		// Token: 0x0600DB6C RID: 56172 RVA: 0x003B833C File Offset: 0x003B653C
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
			this.m_time += Time.deltaTime;
			int num = (int)(this.m_time * 30f);
			if (num > this.m_wordsDisplayLengthMax)
			{
				num = this.m_wordsDisplayLengthMax;
			}
			if (num != this.m_wordsDisplayLength)
			{
				this.m_wordsDisplayLength = num;
				this.m_text.SetDisplayCharacterCount(num);
			}
			if (!this.m_waitGameObject.activeSelf && num >= this.m_wordsDisplayLengthMax && this.m_time >= this.m_voicePlayTime)
			{
				this.m_waitGameObject.SetActive(true);
			}
		}

		// Token: 0x17002A98 RID: 10904
		// (get) Token: 0x0600DB6D RID: 56173 RVA: 0x003B8428 File Offset: 0x003B6628
		// (set) Token: 0x0600DB6E RID: 56174 RVA: 0x003B8448 File Offset: 0x003B6648
		[DoNotToLua]
		public new DialogBoxUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new DialogBoxUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600DB6F RID: 56175 RVA: 0x003B8454 File Offset: 0x003B6654
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0600DB70 RID: 56176 RVA: 0x003B8460 File Offset: 0x003B6660
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0600DB71 RID: 56177 RVA: 0x003B8468 File Offset: 0x003B6668
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0600DB72 RID: 56178 RVA: 0x003B8470 File Offset: 0x003B6670
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0600DB73 RID: 56179 RVA: 0x003B8484 File Offset: 0x003B6684
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0600DB74 RID: 56180 RVA: 0x003B848C File Offset: 0x003B668C
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0600DB75 RID: 56181 RVA: 0x003B8498 File Offset: 0x003B6698
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0600DB76 RID: 56182 RVA: 0x003B84A4 File Offset: 0x003B66A4
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0600DB77 RID: 56183 RVA: 0x003B84B0 File Offset: 0x003B66B0
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0600DB78 RID: 56184 RVA: 0x003B84BC File Offset: 0x003B66BC
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0600DB79 RID: 56185 RVA: 0x003B84C8 File Offset: 0x003B66C8
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0600DB7A RID: 56186 RVA: 0x003B84D4 File Offset: 0x003B66D4
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0600DB7B RID: 56187 RVA: 0x003B84E0 File Offset: 0x003B66E0
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0600DB7C RID: 56188 RVA: 0x003B84EC File Offset: 0x003B66EC
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0600DB7D RID: 56189 RVA: 0x003B84F8 File Offset: 0x003B66F8
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600DB7E RID: 56190 RVA: 0x003B8500 File Offset: 0x003B6700
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
					this.m_ShowBoolean_hotfix = (luaObj.RawGet("Show") as LuaFunction);
					this.m_OpenAction_hotfix = (luaObj.RawGet("Open") as LuaFunction);
					this.m_CloseAction_hotfix = (luaObj.RawGet("Close") as LuaFunction);
					this.m_IsOpened_hotfix = (luaObj.RawGet("IsOpened") as LuaFunction);
					this.m_SetStyleInt32Int32_hotfix = (luaObj.RawGet("SetStyle") as LuaFunction);
					this.m_SetNameString_hotfix = (luaObj.RawGet("SetName") as LuaFunction);
					this.m_SetWordsString_hotfix = (luaObj.RawGet("SetWords") as LuaFunction);
					this.m_SetVoicePlayTimeSingle_hotfix = (luaObj.RawGet("SetVoicePlayTime") as LuaFunction);
					this.m_GetWordsDisplayTime_hotfix = (luaObj.RawGet("GetWordsDisplayTime") as LuaFunction);
					this.m_Update_hotfix = (luaObj.RawGet("Update") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600DB7F RID: 56191 RVA: 0x003B86AC File Offset: 0x003B68AC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(DialogBoxUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04008665 RID: 34405
		private const int WordsSpeed = 30;

		// Token: 0x04008666 RID: 34406
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_uiStateController;

		// Token: 0x04008667 RID: 34407
		[AutoBind("./Text", AutoBindAttribute.InitState.NotInit, false)]
		private DialogText m_text;

		// Token: 0x04008668 RID: 34408
		[AutoBind("./PenGroup", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_waitGameObject;

		// Token: 0x04008669 RID: 34409
		[AutoBind("./NameGroup/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_nameText;

		// Token: 0x0400866A RID: 34410
		private float m_time;

		// Token: 0x0400866B RID: 34411
		private float m_voicePlayTime;

		// Token: 0x0400866C RID: 34412
		private int m_wordsDisplayLength;

		// Token: 0x0400866D RID: 34413
		private int m_wordsDisplayLengthMax;

		// Token: 0x0400866E RID: 34414
		private string m_openStateName;

		// Token: 0x0400866F RID: 34415
		private string m_closeStateName;

		// Token: 0x04008670 RID: 34416
		private bool m_isOpened;

		// Token: 0x04008671 RID: 34417
		[DoNotToLua]
		private DialogBoxUIController.LuaExportHelper luaExportHelper;

		// Token: 0x04008672 RID: 34418
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04008673 RID: 34419
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04008674 RID: 34420
		private LuaFunction m_ShowBoolean_hotfix;

		// Token: 0x04008675 RID: 34421
		private LuaFunction m_OpenAction_hotfix;

		// Token: 0x04008676 RID: 34422
		private LuaFunction m_CloseAction_hotfix;

		// Token: 0x04008677 RID: 34423
		private LuaFunction m_IsOpened_hotfix;

		// Token: 0x04008678 RID: 34424
		private LuaFunction m_SetStyleInt32Int32_hotfix;

		// Token: 0x04008679 RID: 34425
		private LuaFunction m_SetNameString_hotfix;

		// Token: 0x0400867A RID: 34426
		private LuaFunction m_SetWordsString_hotfix;

		// Token: 0x0400867B RID: 34427
		private LuaFunction m_SetVoicePlayTimeSingle_hotfix;

		// Token: 0x0400867C RID: 34428
		private LuaFunction m_GetWordsDisplayTime_hotfix;

		// Token: 0x0400867D RID: 34429
		private LuaFunction m_Update_hotfix;

		// Token: 0x02000C36 RID: 3126
		public new class LuaExportHelper
		{
			// Token: 0x0600DB80 RID: 56192 RVA: 0x003B8714 File Offset: 0x003B6914
			public LuaExportHelper(DialogBoxUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600DB81 RID: 56193 RVA: 0x003B8724 File Offset: 0x003B6924
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0600DB82 RID: 56194 RVA: 0x003B8734 File Offset: 0x003B6934
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0600DB83 RID: 56195 RVA: 0x003B8744 File Offset: 0x003B6944
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600DB84 RID: 56196 RVA: 0x003B8754 File Offset: 0x003B6954
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600DB85 RID: 56197 RVA: 0x003B876C File Offset: 0x003B696C
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0600DB86 RID: 56198 RVA: 0x003B877C File Offset: 0x003B697C
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0600DB87 RID: 56199 RVA: 0x003B878C File Offset: 0x003B698C
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0600DB88 RID: 56200 RVA: 0x003B879C File Offset: 0x003B699C
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0600DB89 RID: 56201 RVA: 0x003B87AC File Offset: 0x003B69AC
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0600DB8A RID: 56202 RVA: 0x003B87BC File Offset: 0x003B69BC
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0600DB8B RID: 56203 RVA: 0x003B87CC File Offset: 0x003B69CC
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0600DB8C RID: 56204 RVA: 0x003B87DC File Offset: 0x003B69DC
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0600DB8D RID: 56205 RVA: 0x003B87EC File Offset: 0x003B69EC
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0600DB8E RID: 56206 RVA: 0x003B87FC File Offset: 0x003B69FC
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0600DB8F RID: 56207 RVA: 0x003B880C File Offset: 0x003B6A0C
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x17002A99 RID: 10905
			// (get) Token: 0x0600DB90 RID: 56208 RVA: 0x003B881C File Offset: 0x003B6A1C
			public static int WordsSpeed
			{
				get
				{
					return 30;
				}
			}

			// Token: 0x17002A9A RID: 10906
			// (get) Token: 0x0600DB91 RID: 56209 RVA: 0x003B8820 File Offset: 0x003B6A20
			// (set) Token: 0x0600DB92 RID: 56210 RVA: 0x003B8830 File Offset: 0x003B6A30
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

			// Token: 0x17002A9B RID: 10907
			// (get) Token: 0x0600DB93 RID: 56211 RVA: 0x003B8840 File Offset: 0x003B6A40
			// (set) Token: 0x0600DB94 RID: 56212 RVA: 0x003B8850 File Offset: 0x003B6A50
			public DialogText m_text
			{
				get
				{
					return this.m_owner.m_text;
				}
				set
				{
					this.m_owner.m_text = value;
				}
			}

			// Token: 0x17002A9C RID: 10908
			// (get) Token: 0x0600DB95 RID: 56213 RVA: 0x003B8860 File Offset: 0x003B6A60
			// (set) Token: 0x0600DB96 RID: 56214 RVA: 0x003B8870 File Offset: 0x003B6A70
			public GameObject m_waitGameObject
			{
				get
				{
					return this.m_owner.m_waitGameObject;
				}
				set
				{
					this.m_owner.m_waitGameObject = value;
				}
			}

			// Token: 0x17002A9D RID: 10909
			// (get) Token: 0x0600DB97 RID: 56215 RVA: 0x003B8880 File Offset: 0x003B6A80
			// (set) Token: 0x0600DB98 RID: 56216 RVA: 0x003B8890 File Offset: 0x003B6A90
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

			// Token: 0x17002A9E RID: 10910
			// (get) Token: 0x0600DB99 RID: 56217 RVA: 0x003B88A0 File Offset: 0x003B6AA0
			// (set) Token: 0x0600DB9A RID: 56218 RVA: 0x003B88B0 File Offset: 0x003B6AB0
			public float m_time
			{
				get
				{
					return this.m_owner.m_time;
				}
				set
				{
					this.m_owner.m_time = value;
				}
			}

			// Token: 0x17002A9F RID: 10911
			// (get) Token: 0x0600DB9B RID: 56219 RVA: 0x003B88C0 File Offset: 0x003B6AC0
			// (set) Token: 0x0600DB9C RID: 56220 RVA: 0x003B88D0 File Offset: 0x003B6AD0
			public float m_voicePlayTime
			{
				get
				{
					return this.m_owner.m_voicePlayTime;
				}
				set
				{
					this.m_owner.m_voicePlayTime = value;
				}
			}

			// Token: 0x17002AA0 RID: 10912
			// (get) Token: 0x0600DB9D RID: 56221 RVA: 0x003B88E0 File Offset: 0x003B6AE0
			// (set) Token: 0x0600DB9E RID: 56222 RVA: 0x003B88F0 File Offset: 0x003B6AF0
			public int m_wordsDisplayLength
			{
				get
				{
					return this.m_owner.m_wordsDisplayLength;
				}
				set
				{
					this.m_owner.m_wordsDisplayLength = value;
				}
			}

			// Token: 0x17002AA1 RID: 10913
			// (get) Token: 0x0600DB9F RID: 56223 RVA: 0x003B8900 File Offset: 0x003B6B00
			// (set) Token: 0x0600DBA0 RID: 56224 RVA: 0x003B8910 File Offset: 0x003B6B10
			public int m_wordsDisplayLengthMax
			{
				get
				{
					return this.m_owner.m_wordsDisplayLengthMax;
				}
				set
				{
					this.m_owner.m_wordsDisplayLengthMax = value;
				}
			}

			// Token: 0x17002AA2 RID: 10914
			// (get) Token: 0x0600DBA1 RID: 56225 RVA: 0x003B8920 File Offset: 0x003B6B20
			// (set) Token: 0x0600DBA2 RID: 56226 RVA: 0x003B8930 File Offset: 0x003B6B30
			public string m_openStateName
			{
				get
				{
					return this.m_owner.m_openStateName;
				}
				set
				{
					this.m_owner.m_openStateName = value;
				}
			}

			// Token: 0x17002AA3 RID: 10915
			// (get) Token: 0x0600DBA3 RID: 56227 RVA: 0x003B8940 File Offset: 0x003B6B40
			// (set) Token: 0x0600DBA4 RID: 56228 RVA: 0x003B8950 File Offset: 0x003B6B50
			public string m_closeStateName
			{
				get
				{
					return this.m_owner.m_closeStateName;
				}
				set
				{
					this.m_owner.m_closeStateName = value;
				}
			}

			// Token: 0x17002AA4 RID: 10916
			// (get) Token: 0x0600DBA5 RID: 56229 RVA: 0x003B8960 File Offset: 0x003B6B60
			// (set) Token: 0x0600DBA6 RID: 56230 RVA: 0x003B8970 File Offset: 0x003B6B70
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

			// Token: 0x0600DBA7 RID: 56231 RVA: 0x003B8980 File Offset: 0x003B6B80
			public void Update()
			{
				this.m_owner.Update();
			}

			// Token: 0x0400867E RID: 34430
			private DialogBoxUIController m_owner;
		}
	}
}
