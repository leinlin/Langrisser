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
	// Token: 0x02000CCE RID: 3278
	[HotFix]
	public class GoddessDialogBoxUIController : UIControllerBase
	{
		// Token: 0x0600EE3E RID: 60990 RVA: 0x003F9D80 File Offset: 0x003F7F80
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
			UIUtility.SetUIStateOpen(this.m_uiStateController, "Open", null, false, true);
			this.m_isOpened = true;
		}

		// Token: 0x0600EE3F RID: 60991 RVA: 0x003F9DFC File Offset: 0x003F7FFC
		public void Close()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Close_hotfix != null)
			{
				this.m_Close_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetUIStateClose(this.m_uiStateController, "Close", null, false, true);
			this.m_isOpened = false;
		}

		// Token: 0x0600EE40 RID: 60992 RVA: 0x003F9E78 File Offset: 0x003F8078
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

		// Token: 0x0600EE41 RID: 60993 RVA: 0x003F9EEC File Offset: 0x003F80EC
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

		// Token: 0x0600EE42 RID: 60994 RVA: 0x003F9FA4 File Offset: 0x003F81A4
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

		// Token: 0x0600EE43 RID: 60995 RVA: 0x003FA01C File Offset: 0x003F821C
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

		// Token: 0x0600EE44 RID: 60996 RVA: 0x003FA098 File Offset: 0x003F8298
		public void DisplayAllWords()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DisplayAllWords_hotfix != null)
			{
				this.m_DisplayAllWords_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_time = Math.Max(this.GetWordsDisplayTime(), this.m_voicePlayTime);
			this.Update();
		}

		// Token: 0x0600EE45 RID: 60997 RVA: 0x003FA118 File Offset: 0x003F8318
		public bool IsAllWordsDisplayed()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsAllWordsDisplayed_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsAllWordsDisplayed_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_wordsDisplayLength == this.m_wordsDisplayLengthMax;
		}

		// Token: 0x0600EE46 RID: 60998 RVA: 0x003FA194 File Offset: 0x003F8394
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

		// Token: 0x17002DF0 RID: 11760
		// (get) Token: 0x0600EE47 RID: 60999 RVA: 0x003FA280 File Offset: 0x003F8480
		// (set) Token: 0x0600EE48 RID: 61000 RVA: 0x003FA2A0 File Offset: 0x003F84A0
		[DoNotToLua]
		public new GoddessDialogBoxUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new GoddessDialogBoxUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600EE49 RID: 61001 RVA: 0x003FA2AC File Offset: 0x003F84AC
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0600EE4A RID: 61002 RVA: 0x003FA2B8 File Offset: 0x003F84B8
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0600EE4B RID: 61003 RVA: 0x003FA2C0 File Offset: 0x003F84C0
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0600EE4C RID: 61004 RVA: 0x003FA2C8 File Offset: 0x003F84C8
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0600EE4D RID: 61005 RVA: 0x003FA2DC File Offset: 0x003F84DC
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0600EE4E RID: 61006 RVA: 0x003FA2E4 File Offset: 0x003F84E4
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0600EE4F RID: 61007 RVA: 0x003FA2F0 File Offset: 0x003F84F0
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0600EE50 RID: 61008 RVA: 0x003FA2FC File Offset: 0x003F84FC
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0600EE51 RID: 61009 RVA: 0x003FA308 File Offset: 0x003F8508
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0600EE52 RID: 61010 RVA: 0x003FA314 File Offset: 0x003F8514
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0600EE53 RID: 61011 RVA: 0x003FA320 File Offset: 0x003F8520
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0600EE54 RID: 61012 RVA: 0x003FA32C File Offset: 0x003F852C
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0600EE55 RID: 61013 RVA: 0x003FA338 File Offset: 0x003F8538
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0600EE56 RID: 61014 RVA: 0x003FA344 File Offset: 0x003F8544
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0600EE57 RID: 61015 RVA: 0x003FA350 File Offset: 0x003F8550
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600EE58 RID: 61016 RVA: 0x003FA358 File Offset: 0x003F8558
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
					this.m_Open_hotfix = (luaObj.RawGet("Open") as LuaFunction);
					this.m_Close_hotfix = (luaObj.RawGet("Close") as LuaFunction);
					this.m_IsOpened_hotfix = (luaObj.RawGet("IsOpened") as LuaFunction);
					this.m_SetWordsString_hotfix = (luaObj.RawGet("SetWords") as LuaFunction);
					this.m_SetVoicePlayTimeSingle_hotfix = (luaObj.RawGet("SetVoicePlayTime") as LuaFunction);
					this.m_GetWordsDisplayTime_hotfix = (luaObj.RawGet("GetWordsDisplayTime") as LuaFunction);
					this.m_DisplayAllWords_hotfix = (luaObj.RawGet("DisplayAllWords") as LuaFunction);
					this.m_IsAllWordsDisplayed_hotfix = (luaObj.RawGet("IsAllWordsDisplayed") as LuaFunction);
					this.m_Update_hotfix = (luaObj.RawGet("Update") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600EE59 RID: 61017 RVA: 0x003FA4EC File Offset: 0x003F86EC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(GoddessDialogBoxUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04008E56 RID: 36438
		private const int WordsSpeed = 30;

		// Token: 0x04008E57 RID: 36439
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_uiStateController;

		// Token: 0x04008E58 RID: 36440
		[AutoBind("./Text", AutoBindAttribute.InitState.NotInit, false)]
		private DialogText m_text;

		// Token: 0x04008E59 RID: 36441
		[AutoBind("./Arrow", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_waitGameObject;

		// Token: 0x04008E5A RID: 36442
		private float m_time;

		// Token: 0x04008E5B RID: 36443
		private float m_voicePlayTime;

		// Token: 0x04008E5C RID: 36444
		private int m_wordsDisplayLength;

		// Token: 0x04008E5D RID: 36445
		private int m_wordsDisplayLengthMax;

		// Token: 0x04008E5E RID: 36446
		private bool m_isOpened;

		// Token: 0x04008E5F RID: 36447
		[DoNotToLua]
		private GoddessDialogBoxUIController.LuaExportHelper luaExportHelper;

		// Token: 0x04008E60 RID: 36448
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04008E61 RID: 36449
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04008E62 RID: 36450
		private LuaFunction m_Open_hotfix;

		// Token: 0x04008E63 RID: 36451
		private LuaFunction m_Close_hotfix;

		// Token: 0x04008E64 RID: 36452
		private LuaFunction m_IsOpened_hotfix;

		// Token: 0x04008E65 RID: 36453
		private LuaFunction m_SetWordsString_hotfix;

		// Token: 0x04008E66 RID: 36454
		private LuaFunction m_SetVoicePlayTimeSingle_hotfix;

		// Token: 0x04008E67 RID: 36455
		private LuaFunction m_GetWordsDisplayTime_hotfix;

		// Token: 0x04008E68 RID: 36456
		private LuaFunction m_DisplayAllWords_hotfix;

		// Token: 0x04008E69 RID: 36457
		private LuaFunction m_IsAllWordsDisplayed_hotfix;

		// Token: 0x04008E6A RID: 36458
		private LuaFunction m_Update_hotfix;

		// Token: 0x02000CCF RID: 3279
		public new class LuaExportHelper
		{
			// Token: 0x0600EE5A RID: 61018 RVA: 0x003FA554 File Offset: 0x003F8754
			public LuaExportHelper(GoddessDialogBoxUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600EE5B RID: 61019 RVA: 0x003FA564 File Offset: 0x003F8764
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0600EE5C RID: 61020 RVA: 0x003FA574 File Offset: 0x003F8774
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0600EE5D RID: 61021 RVA: 0x003FA584 File Offset: 0x003F8784
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600EE5E RID: 61022 RVA: 0x003FA594 File Offset: 0x003F8794
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600EE5F RID: 61023 RVA: 0x003FA5AC File Offset: 0x003F87AC
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0600EE60 RID: 61024 RVA: 0x003FA5BC File Offset: 0x003F87BC
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0600EE61 RID: 61025 RVA: 0x003FA5CC File Offset: 0x003F87CC
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0600EE62 RID: 61026 RVA: 0x003FA5DC File Offset: 0x003F87DC
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0600EE63 RID: 61027 RVA: 0x003FA5EC File Offset: 0x003F87EC
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0600EE64 RID: 61028 RVA: 0x003FA5FC File Offset: 0x003F87FC
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0600EE65 RID: 61029 RVA: 0x003FA60C File Offset: 0x003F880C
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0600EE66 RID: 61030 RVA: 0x003FA61C File Offset: 0x003F881C
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0600EE67 RID: 61031 RVA: 0x003FA62C File Offset: 0x003F882C
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0600EE68 RID: 61032 RVA: 0x003FA63C File Offset: 0x003F883C
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0600EE69 RID: 61033 RVA: 0x003FA64C File Offset: 0x003F884C
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x17002DF1 RID: 11761
			// (get) Token: 0x0600EE6A RID: 61034 RVA: 0x003FA65C File Offset: 0x003F885C
			public static int WordsSpeed
			{
				get
				{
					return 30;
				}
			}

			// Token: 0x17002DF2 RID: 11762
			// (get) Token: 0x0600EE6B RID: 61035 RVA: 0x003FA660 File Offset: 0x003F8860
			// (set) Token: 0x0600EE6C RID: 61036 RVA: 0x003FA670 File Offset: 0x003F8870
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

			// Token: 0x17002DF3 RID: 11763
			// (get) Token: 0x0600EE6D RID: 61037 RVA: 0x003FA680 File Offset: 0x003F8880
			// (set) Token: 0x0600EE6E RID: 61038 RVA: 0x003FA690 File Offset: 0x003F8890
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

			// Token: 0x17002DF4 RID: 11764
			// (get) Token: 0x0600EE6F RID: 61039 RVA: 0x003FA6A0 File Offset: 0x003F88A0
			// (set) Token: 0x0600EE70 RID: 61040 RVA: 0x003FA6B0 File Offset: 0x003F88B0
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

			// Token: 0x17002DF5 RID: 11765
			// (get) Token: 0x0600EE71 RID: 61041 RVA: 0x003FA6C0 File Offset: 0x003F88C0
			// (set) Token: 0x0600EE72 RID: 61042 RVA: 0x003FA6D0 File Offset: 0x003F88D0
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

			// Token: 0x17002DF6 RID: 11766
			// (get) Token: 0x0600EE73 RID: 61043 RVA: 0x003FA6E0 File Offset: 0x003F88E0
			// (set) Token: 0x0600EE74 RID: 61044 RVA: 0x003FA6F0 File Offset: 0x003F88F0
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

			// Token: 0x17002DF7 RID: 11767
			// (get) Token: 0x0600EE75 RID: 61045 RVA: 0x003FA700 File Offset: 0x003F8900
			// (set) Token: 0x0600EE76 RID: 61046 RVA: 0x003FA710 File Offset: 0x003F8910
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

			// Token: 0x17002DF8 RID: 11768
			// (get) Token: 0x0600EE77 RID: 61047 RVA: 0x003FA720 File Offset: 0x003F8920
			// (set) Token: 0x0600EE78 RID: 61048 RVA: 0x003FA730 File Offset: 0x003F8930
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

			// Token: 0x17002DF9 RID: 11769
			// (get) Token: 0x0600EE79 RID: 61049 RVA: 0x003FA740 File Offset: 0x003F8940
			// (set) Token: 0x0600EE7A RID: 61050 RVA: 0x003FA750 File Offset: 0x003F8950
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

			// Token: 0x0600EE7B RID: 61051 RVA: 0x003FA760 File Offset: 0x003F8960
			public void Update()
			{
				this.m_owner.Update();
			}

			// Token: 0x04008E6B RID: 36459
			private GoddessDialogBoxUIController m_owner;
		}
	}
}
