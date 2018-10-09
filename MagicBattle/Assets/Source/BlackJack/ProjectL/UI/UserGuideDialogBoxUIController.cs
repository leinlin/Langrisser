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
	// Token: 0x02001004 RID: 4100
	[HotFix]
	public class UserGuideDialogBoxUIController : UIControllerBase
	{
		// Token: 0x06014A58 RID: 84568 RVA: 0x0053BCB4 File Offset: 0x00539EB4
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

		// Token: 0x06014A59 RID: 84569 RVA: 0x0053BD40 File Offset: 0x00539F40
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

		// Token: 0x06014A5A RID: 84570 RVA: 0x0053BDCC File Offset: 0x00539FCC
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

		// Token: 0x06014A5B RID: 84571 RVA: 0x0053BE58 File Offset: 0x0053A058
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

		// Token: 0x06014A5C RID: 84572 RVA: 0x0053BECC File Offset: 0x0053A0CC
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

		// Token: 0x06014A5D RID: 84573 RVA: 0x0053C028 File Offset: 0x0053A228
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

		// Token: 0x06014A5E RID: 84574 RVA: 0x0053C0A4 File Offset: 0x0053A2A4
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

		// Token: 0x06014A5F RID: 84575 RVA: 0x0053C15C File Offset: 0x0053A35C
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

		// Token: 0x06014A60 RID: 84576 RVA: 0x0053C1D4 File Offset: 0x0053A3D4
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

		// Token: 0x06014A61 RID: 84577 RVA: 0x0053C250 File Offset: 0x0053A450
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

		// Token: 0x17003D0E RID: 15630
		// (get) Token: 0x06014A62 RID: 84578 RVA: 0x0053C33C File Offset: 0x0053A53C
		// (set) Token: 0x06014A63 RID: 84579 RVA: 0x0053C35C File Offset: 0x0053A55C
		[DoNotToLua]
		public new UserGuideDialogBoxUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new UserGuideDialogBoxUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06014A64 RID: 84580 RVA: 0x0053C368 File Offset: 0x0053A568
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x06014A65 RID: 84581 RVA: 0x0053C374 File Offset: 0x0053A574
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x06014A66 RID: 84582 RVA: 0x0053C37C File Offset: 0x0053A57C
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x06014A67 RID: 84583 RVA: 0x0053C384 File Offset: 0x0053A584
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x06014A68 RID: 84584 RVA: 0x0053C398 File Offset: 0x0053A598
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x06014A69 RID: 84585 RVA: 0x0053C3A0 File Offset: 0x0053A5A0
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x06014A6A RID: 84586 RVA: 0x0053C3AC File Offset: 0x0053A5AC
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x06014A6B RID: 84587 RVA: 0x0053C3B8 File Offset: 0x0053A5B8
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x06014A6C RID: 84588 RVA: 0x0053C3C4 File Offset: 0x0053A5C4
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x06014A6D RID: 84589 RVA: 0x0053C3D0 File Offset: 0x0053A5D0
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x06014A6E RID: 84590 RVA: 0x0053C3DC File Offset: 0x0053A5DC
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x06014A6F RID: 84591 RVA: 0x0053C3E8 File Offset: 0x0053A5E8
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x06014A70 RID: 84592 RVA: 0x0053C3F4 File Offset: 0x0053A5F4
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x06014A71 RID: 84593 RVA: 0x0053C400 File Offset: 0x0053A600
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x06014A72 RID: 84594 RVA: 0x0053C40C File Offset: 0x0053A60C
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x06014A73 RID: 84595 RVA: 0x0053C414 File Offset: 0x0053A614
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

		// Token: 0x06014A74 RID: 84596 RVA: 0x0053C5C0 File Offset: 0x0053A7C0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(UserGuideDialogBoxUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400B534 RID: 46388
		private const int WordsSpeed = 30;

		// Token: 0x0400B535 RID: 46389
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_uiStateController;

		// Token: 0x0400B536 RID: 46390
		[AutoBind("./Text", AutoBindAttribute.InitState.NotInit, false)]
		private DialogText m_text;

		// Token: 0x0400B537 RID: 46391
		[AutoBind("./PenGroup", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_waitGameObject;

		// Token: 0x0400B538 RID: 46392
		[AutoBind("./NameGroup/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_nameText;

		// Token: 0x0400B539 RID: 46393
		private float m_time;

		// Token: 0x0400B53A RID: 46394
		private float m_voicePlayTime;

		// Token: 0x0400B53B RID: 46395
		private int m_wordsDisplayLength;

		// Token: 0x0400B53C RID: 46396
		private int m_wordsDisplayLengthMax;

		// Token: 0x0400B53D RID: 46397
		private string m_openStateName;

		// Token: 0x0400B53E RID: 46398
		private string m_closeStateName;

		// Token: 0x0400B53F RID: 46399
		private bool m_isOpened;

		// Token: 0x0400B540 RID: 46400
		[DoNotToLua]
		private UserGuideDialogBoxUIController.LuaExportHelper luaExportHelper;

		// Token: 0x0400B541 RID: 46401
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400B542 RID: 46402
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400B543 RID: 46403
		private LuaFunction m_ShowBoolean_hotfix;

		// Token: 0x0400B544 RID: 46404
		private LuaFunction m_OpenAction_hotfix;

		// Token: 0x0400B545 RID: 46405
		private LuaFunction m_CloseAction_hotfix;

		// Token: 0x0400B546 RID: 46406
		private LuaFunction m_IsOpened_hotfix;

		// Token: 0x0400B547 RID: 46407
		private LuaFunction m_SetStyleInt32Int32_hotfix;

		// Token: 0x0400B548 RID: 46408
		private LuaFunction m_SetNameString_hotfix;

		// Token: 0x0400B549 RID: 46409
		private LuaFunction m_SetWordsString_hotfix;

		// Token: 0x0400B54A RID: 46410
		private LuaFunction m_SetVoicePlayTimeSingle_hotfix;

		// Token: 0x0400B54B RID: 46411
		private LuaFunction m_GetWordsDisplayTime_hotfix;

		// Token: 0x0400B54C RID: 46412
		private LuaFunction m_Update_hotfix;

		// Token: 0x02001005 RID: 4101
		public new class LuaExportHelper
		{
			// Token: 0x06014A75 RID: 84597 RVA: 0x0053C628 File Offset: 0x0053A828
			public LuaExportHelper(UserGuideDialogBoxUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06014A76 RID: 84598 RVA: 0x0053C638 File Offset: 0x0053A838
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x06014A77 RID: 84599 RVA: 0x0053C648 File Offset: 0x0053A848
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x06014A78 RID: 84600 RVA: 0x0053C658 File Offset: 0x0053A858
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x06014A79 RID: 84601 RVA: 0x0053C668 File Offset: 0x0053A868
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x06014A7A RID: 84602 RVA: 0x0053C680 File Offset: 0x0053A880
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x06014A7B RID: 84603 RVA: 0x0053C690 File Offset: 0x0053A890
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x06014A7C RID: 84604 RVA: 0x0053C6A0 File Offset: 0x0053A8A0
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x06014A7D RID: 84605 RVA: 0x0053C6B0 File Offset: 0x0053A8B0
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x06014A7E RID: 84606 RVA: 0x0053C6C0 File Offset: 0x0053A8C0
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x06014A7F RID: 84607 RVA: 0x0053C6D0 File Offset: 0x0053A8D0
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x06014A80 RID: 84608 RVA: 0x0053C6E0 File Offset: 0x0053A8E0
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x06014A81 RID: 84609 RVA: 0x0053C6F0 File Offset: 0x0053A8F0
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x06014A82 RID: 84610 RVA: 0x0053C700 File Offset: 0x0053A900
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x06014A83 RID: 84611 RVA: 0x0053C710 File Offset: 0x0053A910
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x06014A84 RID: 84612 RVA: 0x0053C720 File Offset: 0x0053A920
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x17003D0F RID: 15631
			// (get) Token: 0x06014A85 RID: 84613 RVA: 0x0053C730 File Offset: 0x0053A930
			public static int WordsSpeed
			{
				get
				{
					return 30;
				}
			}

			// Token: 0x17003D10 RID: 15632
			// (get) Token: 0x06014A86 RID: 84614 RVA: 0x0053C734 File Offset: 0x0053A934
			// (set) Token: 0x06014A87 RID: 84615 RVA: 0x0053C744 File Offset: 0x0053A944
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

			// Token: 0x17003D11 RID: 15633
			// (get) Token: 0x06014A88 RID: 84616 RVA: 0x0053C754 File Offset: 0x0053A954
			// (set) Token: 0x06014A89 RID: 84617 RVA: 0x0053C764 File Offset: 0x0053A964
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

			// Token: 0x17003D12 RID: 15634
			// (get) Token: 0x06014A8A RID: 84618 RVA: 0x0053C774 File Offset: 0x0053A974
			// (set) Token: 0x06014A8B RID: 84619 RVA: 0x0053C784 File Offset: 0x0053A984
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

			// Token: 0x17003D13 RID: 15635
			// (get) Token: 0x06014A8C RID: 84620 RVA: 0x0053C794 File Offset: 0x0053A994
			// (set) Token: 0x06014A8D RID: 84621 RVA: 0x0053C7A4 File Offset: 0x0053A9A4
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

			// Token: 0x17003D14 RID: 15636
			// (get) Token: 0x06014A8E RID: 84622 RVA: 0x0053C7B4 File Offset: 0x0053A9B4
			// (set) Token: 0x06014A8F RID: 84623 RVA: 0x0053C7C4 File Offset: 0x0053A9C4
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

			// Token: 0x17003D15 RID: 15637
			// (get) Token: 0x06014A90 RID: 84624 RVA: 0x0053C7D4 File Offset: 0x0053A9D4
			// (set) Token: 0x06014A91 RID: 84625 RVA: 0x0053C7E4 File Offset: 0x0053A9E4
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

			// Token: 0x17003D16 RID: 15638
			// (get) Token: 0x06014A92 RID: 84626 RVA: 0x0053C7F4 File Offset: 0x0053A9F4
			// (set) Token: 0x06014A93 RID: 84627 RVA: 0x0053C804 File Offset: 0x0053AA04
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

			// Token: 0x17003D17 RID: 15639
			// (get) Token: 0x06014A94 RID: 84628 RVA: 0x0053C814 File Offset: 0x0053AA14
			// (set) Token: 0x06014A95 RID: 84629 RVA: 0x0053C824 File Offset: 0x0053AA24
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

			// Token: 0x17003D18 RID: 15640
			// (get) Token: 0x06014A96 RID: 84630 RVA: 0x0053C834 File Offset: 0x0053AA34
			// (set) Token: 0x06014A97 RID: 84631 RVA: 0x0053C844 File Offset: 0x0053AA44
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

			// Token: 0x17003D19 RID: 15641
			// (get) Token: 0x06014A98 RID: 84632 RVA: 0x0053C854 File Offset: 0x0053AA54
			// (set) Token: 0x06014A99 RID: 84633 RVA: 0x0053C864 File Offset: 0x0053AA64
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

			// Token: 0x17003D1A RID: 15642
			// (get) Token: 0x06014A9A RID: 84634 RVA: 0x0053C874 File Offset: 0x0053AA74
			// (set) Token: 0x06014A9B RID: 84635 RVA: 0x0053C884 File Offset: 0x0053AA84
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

			// Token: 0x06014A9C RID: 84636 RVA: 0x0053C894 File Offset: 0x0053AA94
			public void Update()
			{
				this.m_owner.Update();
			}

			// Token: 0x0400B54D RID: 46413
			private UserGuideDialogBoxUIController m_owner;
		}
	}
}
