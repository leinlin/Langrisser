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
	// Token: 0x02000A72 RID: 2674
	[HotFix]
	public class BattleDialogBoxUIController : UIControllerBase
	{
		// Token: 0x0600A7C9 RID: 42953 RVA: 0x002EEFFC File Offset: 0x002ED1FC
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

		// Token: 0x0600A7CA RID: 42954 RVA: 0x002EF088 File Offset: 0x002ED288
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

		// Token: 0x0600A7CB RID: 42955 RVA: 0x002EF114 File Offset: 0x002ED314
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

		// Token: 0x0600A7CC RID: 42956 RVA: 0x002EF1A0 File Offset: 0x002ED3A0
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

		// Token: 0x0600A7CD RID: 42957 RVA: 0x002EF214 File Offset: 0x002ED414
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

		// Token: 0x0600A7CE RID: 42958 RVA: 0x002EF370 File Offset: 0x002ED570
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

		// Token: 0x0600A7CF RID: 42959 RVA: 0x002EF3EC File Offset: 0x002ED5EC
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

		// Token: 0x0600A7D0 RID: 42960 RVA: 0x002EF4A4 File Offset: 0x002ED6A4
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

		// Token: 0x0600A7D1 RID: 42961 RVA: 0x002EF51C File Offset: 0x002ED71C
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

		// Token: 0x0600A7D2 RID: 42962 RVA: 0x002EF598 File Offset: 0x002ED798
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
			this.m_time += Time.unscaledDeltaTime;
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

		// Token: 0x1700220D RID: 8717
		// (get) Token: 0x0600A7D3 RID: 42963 RVA: 0x002EF684 File Offset: 0x002ED884
		// (set) Token: 0x0600A7D4 RID: 42964 RVA: 0x002EF6A4 File Offset: 0x002ED8A4
		[DoNotToLua]
		public new BattleDialogBoxUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new BattleDialogBoxUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600A7D5 RID: 42965 RVA: 0x002EF6B0 File Offset: 0x002ED8B0
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0600A7D6 RID: 42966 RVA: 0x002EF6BC File Offset: 0x002ED8BC
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0600A7D7 RID: 42967 RVA: 0x002EF6C4 File Offset: 0x002ED8C4
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0600A7D8 RID: 42968 RVA: 0x002EF6CC File Offset: 0x002ED8CC
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0600A7D9 RID: 42969 RVA: 0x002EF6E0 File Offset: 0x002ED8E0
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0600A7DA RID: 42970 RVA: 0x002EF6E8 File Offset: 0x002ED8E8
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0600A7DB RID: 42971 RVA: 0x002EF6F4 File Offset: 0x002ED8F4
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0600A7DC RID: 42972 RVA: 0x002EF700 File Offset: 0x002ED900
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0600A7DD RID: 42973 RVA: 0x002EF70C File Offset: 0x002ED90C
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0600A7DE RID: 42974 RVA: 0x002EF718 File Offset: 0x002ED918
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0600A7DF RID: 42975 RVA: 0x002EF724 File Offset: 0x002ED924
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0600A7E0 RID: 42976 RVA: 0x002EF730 File Offset: 0x002ED930
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0600A7E1 RID: 42977 RVA: 0x002EF73C File Offset: 0x002ED93C
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0600A7E2 RID: 42978 RVA: 0x002EF748 File Offset: 0x002ED948
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0600A7E3 RID: 42979 RVA: 0x002EF754 File Offset: 0x002ED954
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600A7E4 RID: 42980 RVA: 0x002EF75C File Offset: 0x002ED95C
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

		// Token: 0x0600A7E5 RID: 42981 RVA: 0x002EF908 File Offset: 0x002EDB08
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BattleDialogBoxUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04006F02 RID: 28418
		private const int WordsSpeed = 30;

		// Token: 0x04006F03 RID: 28419
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_uiStateController;

		// Token: 0x04006F04 RID: 28420
		[AutoBind("./Text", AutoBindAttribute.InitState.NotInit, false)]
		private DialogText m_text;

		// Token: 0x04006F05 RID: 28421
		[AutoBind("./PenGroup", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_waitGameObject;

		// Token: 0x04006F06 RID: 28422
		[AutoBind("./NameGroup/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_nameText;

		// Token: 0x04006F07 RID: 28423
		private float m_time;

		// Token: 0x04006F08 RID: 28424
		private float m_voicePlayTime;

		// Token: 0x04006F09 RID: 28425
		private int m_wordsDisplayLength;

		// Token: 0x04006F0A RID: 28426
		private int m_wordsDisplayLengthMax;

		// Token: 0x04006F0B RID: 28427
		private string m_openStateName;

		// Token: 0x04006F0C RID: 28428
		private string m_closeStateName;

		// Token: 0x04006F0D RID: 28429
		private bool m_isOpened;

		// Token: 0x04006F0E RID: 28430
		[DoNotToLua]
		private BattleDialogBoxUIController.LuaExportHelper luaExportHelper;

		// Token: 0x04006F0F RID: 28431
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04006F10 RID: 28432
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04006F11 RID: 28433
		private LuaFunction m_ShowBoolean_hotfix;

		// Token: 0x04006F12 RID: 28434
		private LuaFunction m_OpenAction_hotfix;

		// Token: 0x04006F13 RID: 28435
		private LuaFunction m_CloseAction_hotfix;

		// Token: 0x04006F14 RID: 28436
		private LuaFunction m_IsOpened_hotfix;

		// Token: 0x04006F15 RID: 28437
		private LuaFunction m_SetStyleInt32Int32_hotfix;

		// Token: 0x04006F16 RID: 28438
		private LuaFunction m_SetNameString_hotfix;

		// Token: 0x04006F17 RID: 28439
		private LuaFunction m_SetWordsString_hotfix;

		// Token: 0x04006F18 RID: 28440
		private LuaFunction m_SetVoicePlayTimeSingle_hotfix;

		// Token: 0x04006F19 RID: 28441
		private LuaFunction m_GetWordsDisplayTime_hotfix;

		// Token: 0x04006F1A RID: 28442
		private LuaFunction m_Update_hotfix;

		// Token: 0x02000A73 RID: 2675
		public new class LuaExportHelper
		{
			// Token: 0x0600A7E6 RID: 42982 RVA: 0x002EF970 File Offset: 0x002EDB70
			public LuaExportHelper(BattleDialogBoxUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600A7E7 RID: 42983 RVA: 0x002EF980 File Offset: 0x002EDB80
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0600A7E8 RID: 42984 RVA: 0x002EF990 File Offset: 0x002EDB90
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0600A7E9 RID: 42985 RVA: 0x002EF9A0 File Offset: 0x002EDBA0
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600A7EA RID: 42986 RVA: 0x002EF9B0 File Offset: 0x002EDBB0
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600A7EB RID: 42987 RVA: 0x002EF9C8 File Offset: 0x002EDBC8
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0600A7EC RID: 42988 RVA: 0x002EF9D8 File Offset: 0x002EDBD8
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0600A7ED RID: 42989 RVA: 0x002EF9E8 File Offset: 0x002EDBE8
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0600A7EE RID: 42990 RVA: 0x002EF9F8 File Offset: 0x002EDBF8
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0600A7EF RID: 42991 RVA: 0x002EFA08 File Offset: 0x002EDC08
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0600A7F0 RID: 42992 RVA: 0x002EFA18 File Offset: 0x002EDC18
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0600A7F1 RID: 42993 RVA: 0x002EFA28 File Offset: 0x002EDC28
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0600A7F2 RID: 42994 RVA: 0x002EFA38 File Offset: 0x002EDC38
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0600A7F3 RID: 42995 RVA: 0x002EFA48 File Offset: 0x002EDC48
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0600A7F4 RID: 42996 RVA: 0x002EFA58 File Offset: 0x002EDC58
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0600A7F5 RID: 42997 RVA: 0x002EFA68 File Offset: 0x002EDC68
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x1700220E RID: 8718
			// (get) Token: 0x0600A7F6 RID: 42998 RVA: 0x002EFA78 File Offset: 0x002EDC78
			public static int WordsSpeed
			{
				get
				{
					return 30;
				}
			}

			// Token: 0x1700220F RID: 8719
			// (get) Token: 0x0600A7F7 RID: 42999 RVA: 0x002EFA7C File Offset: 0x002EDC7C
			// (set) Token: 0x0600A7F8 RID: 43000 RVA: 0x002EFA8C File Offset: 0x002EDC8C
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

			// Token: 0x17002210 RID: 8720
			// (get) Token: 0x0600A7F9 RID: 43001 RVA: 0x002EFA9C File Offset: 0x002EDC9C
			// (set) Token: 0x0600A7FA RID: 43002 RVA: 0x002EFAAC File Offset: 0x002EDCAC
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

			// Token: 0x17002211 RID: 8721
			// (get) Token: 0x0600A7FB RID: 43003 RVA: 0x002EFABC File Offset: 0x002EDCBC
			// (set) Token: 0x0600A7FC RID: 43004 RVA: 0x002EFACC File Offset: 0x002EDCCC
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

			// Token: 0x17002212 RID: 8722
			// (get) Token: 0x0600A7FD RID: 43005 RVA: 0x002EFADC File Offset: 0x002EDCDC
			// (set) Token: 0x0600A7FE RID: 43006 RVA: 0x002EFAEC File Offset: 0x002EDCEC
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

			// Token: 0x17002213 RID: 8723
			// (get) Token: 0x0600A7FF RID: 43007 RVA: 0x002EFAFC File Offset: 0x002EDCFC
			// (set) Token: 0x0600A800 RID: 43008 RVA: 0x002EFB0C File Offset: 0x002EDD0C
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

			// Token: 0x17002214 RID: 8724
			// (get) Token: 0x0600A801 RID: 43009 RVA: 0x002EFB1C File Offset: 0x002EDD1C
			// (set) Token: 0x0600A802 RID: 43010 RVA: 0x002EFB2C File Offset: 0x002EDD2C
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

			// Token: 0x17002215 RID: 8725
			// (get) Token: 0x0600A803 RID: 43011 RVA: 0x002EFB3C File Offset: 0x002EDD3C
			// (set) Token: 0x0600A804 RID: 43012 RVA: 0x002EFB4C File Offset: 0x002EDD4C
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

			// Token: 0x17002216 RID: 8726
			// (get) Token: 0x0600A805 RID: 43013 RVA: 0x002EFB5C File Offset: 0x002EDD5C
			// (set) Token: 0x0600A806 RID: 43014 RVA: 0x002EFB6C File Offset: 0x002EDD6C
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

			// Token: 0x17002217 RID: 8727
			// (get) Token: 0x0600A807 RID: 43015 RVA: 0x002EFB7C File Offset: 0x002EDD7C
			// (set) Token: 0x0600A808 RID: 43016 RVA: 0x002EFB8C File Offset: 0x002EDD8C
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

			// Token: 0x17002218 RID: 8728
			// (get) Token: 0x0600A809 RID: 43017 RVA: 0x002EFB9C File Offset: 0x002EDD9C
			// (set) Token: 0x0600A80A RID: 43018 RVA: 0x002EFBAC File Offset: 0x002EDDAC
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

			// Token: 0x17002219 RID: 8729
			// (get) Token: 0x0600A80B RID: 43019 RVA: 0x002EFBBC File Offset: 0x002EDDBC
			// (set) Token: 0x0600A80C RID: 43020 RVA: 0x002EFBCC File Offset: 0x002EDDCC
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

			// Token: 0x0600A80D RID: 43021 RVA: 0x002EFBDC File Offset: 0x002EDDDC
			public void Update()
			{
				this.m_owner.Update();
			}

			// Token: 0x04006F1B RID: 28443
			private BattleDialogBoxUIController m_owner;
		}
	}
}
