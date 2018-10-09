using System;
using System.Threading;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using PD.SDK;
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000E30 RID: 3632
	[HotFix]
	public class CreateCharacterUIController : UIControllerBase
	{
		// Token: 0x060118E8 RID: 71912 RVA: 0x0048B2F0 File Offset: 0x004894F0
		private CreateCharacterUIController()
		{
		}

		// Token: 0x060118E9 RID: 71913 RVA: 0x0048B2F8 File Offset: 0x004894F8
		private void Start()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Start_hotfix != null)
			{
				this.m_Start_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			PDSDK.Instance.printGameEventLog("25.5", string.Empty);
		}

		// Token: 0x060118EA RID: 71914 RVA: 0x0048B36C File Offset: 0x0048956C
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
			this.m_createButton.onClick.AddListener(new UnityAction(this.OnCreateButtonClick));
			this.m_autoButton.onClick.AddListener(new UnityAction(this.OnAutoButtonClick));
			this.m_messageGameObject.SetActive(false);
			this.m_characterNameInputField.onEndEdit.AddListener(new UnityAction<string>(this.CharacterNameInputField_OnEndEdit));
		}

		// Token: 0x060118EB RID: 71915 RVA: 0x0048B434 File Offset: 0x00489634
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
			float deltaTime = Time.deltaTime;
			if (this.m_hideMessageTime > 0f)
			{
				this.m_hideMessageTime -= deltaTime;
				if (this.m_hideMessageTime <= 0f)
				{
					this.HideMessage();
				}
			}
		}

		// Token: 0x060118EC RID: 71916 RVA: 0x0048B4D0 File Offset: 0x004896D0
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

		// Token: 0x060118ED RID: 71917 RVA: 0x0048B544 File Offset: 0x00489744
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
			UIUtility.SetUIStateClose(this.m_uiStateController, "Close", onEnd, false, true);
		}

		// Token: 0x060118EE RID: 71918 RVA: 0x0048B5C8 File Offset: 0x004897C8
		public void SetCharacterNameLimit(int count)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetCharacterNameLimitInt32_hotfix != null)
			{
				this.m_SetCharacterNameLimitInt32_hotfix.call(new object[]
				{
					this,
					count
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_characterNameInputField.characterLimit = UIUtility.GetInputFieldCharacterLimit(count);
			this.m_characterNameLimit = count;
		}

		// Token: 0x060118EF RID: 71919 RVA: 0x0048B650 File Offset: 0x00489850
		public void SetCharacterName(string name)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetCharacterNameString_hotfix != null)
			{
				this.m_SetCharacterNameString_hotfix.call(new object[]
				{
					this,
					name
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (string.IsNullOrEmpty(name))
			{
				this.m_characterNameInputField.text = string.Empty;
			}
			else
			{
				this.m_characterNameInputField.text = name;
			}
		}

		// Token: 0x060118F0 RID: 71920 RVA: 0x0048B6EC File Offset: 0x004898EC
		public string GetCharacterName()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetCharacterName_hotfix != null)
			{
				return (string)this.m_GetCharacterName_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_characterNameInputField.text;
		}

		// Token: 0x060118F1 RID: 71921 RVA: 0x0048B764 File Offset: 0x00489964
		public void ShowMessage(string text, int time = 0)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowMessageStringInt32_hotfix != null)
			{
				this.m_ShowMessageStringInt32_hotfix.call(new object[]
				{
					this,
					text,
					time
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_messageText.text = text;
			this.m_hideMessageTime = (float)time;
			if (!this.m_messageGameObject.activeSelf)
			{
				this.m_messageGameObject.SetActive(true);
				UIUtility.ReplayTween(this.m_messageGameObject, null);
			}
		}

		// Token: 0x060118F2 RID: 71922 RVA: 0x0048B820 File Offset: 0x00489A20
		public void ShowMessage(StringTableId id, int time = 0)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowMessageStringTableIdInt32_hotfix != null)
			{
				this.m_ShowMessageStringTableIdInt32_hotfix.call(new object[]
				{
					this,
					id,
					time
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			this.ShowMessage(configDataLoader.UtilityGetStringByStringTable(id), time);
		}

		// Token: 0x060118F3 RID: 71923 RVA: 0x0048B8C0 File Offset: 0x00489AC0
		public void HideMessage()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HideMessage_hotfix != null)
			{
				this.m_HideMessage_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_messageGameObject.activeSelf)
			{
				UIUtility.ReversePlayTween(this.m_messageGameObject, delegate
				{
					this.m_messageGameObject.SetActive(false);
				});
			}
			this.m_hideMessageTime = 0f;
		}

		// Token: 0x060118F4 RID: 71924 RVA: 0x0048B954 File Offset: 0x00489B54
		private void OnCreateButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnCreateButtonClick_hotfix != null)
			{
				this.m_OnCreateButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnCreate != null)
			{
				this.EventOnCreate();
			}
		}

		// Token: 0x060118F5 RID: 71925 RVA: 0x0048B9CC File Offset: 0x00489BCC
		private void OnAutoButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnAutoButtonClick_hotfix != null)
			{
				this.m_OnAutoButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnAutoName != null)
			{
				this.EventOnAutoName();
			}
			PDSDK.Instance.printGameEventLog("26", string.Empty);
		}

		// Token: 0x060118F6 RID: 71926 RVA: 0x0048BA58 File Offset: 0x00489C58
		private void CharacterNameInputField_OnEndEdit(string str)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CharacterNameInputField_OnEndEditString_hotfix != null)
			{
				this.m_CharacterNameInputField_OnEndEditString_hotfix.call(new object[]
				{
					this,
					str
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_characterNameLimit > 0 && str.Length > this.m_characterNameLimit)
			{
				this.m_characterNameInputField.text = str.Substring(0, this.m_characterNameLimit);
			}
		}

		// Token: 0x140003C7 RID: 967
		// (add) Token: 0x060118F7 RID: 71927 RVA: 0x0048BB00 File Offset: 0x00489D00
		// (remove) Token: 0x060118F8 RID: 71928 RVA: 0x0048BB9C File Offset: 0x00489D9C
		public event Action EventOnCreate
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnCreateAction_hotfix != null)
				{
					this.m_add_EventOnCreateAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnCreate;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnCreate, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnCreateAction_hotfix != null)
				{
					this.m_remove_EventOnCreateAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnCreate;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnCreate, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140003C8 RID: 968
		// (add) Token: 0x060118F9 RID: 71929 RVA: 0x0048BC38 File Offset: 0x00489E38
		// (remove) Token: 0x060118FA RID: 71930 RVA: 0x0048BCD4 File Offset: 0x00489ED4
		public event Action EventOnAutoName
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnAutoNameAction_hotfix != null)
				{
					this.m_add_EventOnAutoNameAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnAutoName;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnAutoName, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnAutoNameAction_hotfix != null)
				{
					this.m_remove_EventOnAutoNameAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnAutoName;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnAutoName, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x170035F2 RID: 13810
		// (get) Token: 0x060118FB RID: 71931 RVA: 0x0048BD70 File Offset: 0x00489F70
		// (set) Token: 0x060118FC RID: 71932 RVA: 0x0048BD90 File Offset: 0x00489F90
		[DoNotToLua]
		public new CreateCharacterUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new CreateCharacterUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x060118FD RID: 71933 RVA: 0x0048BD9C File Offset: 0x00489F9C
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x060118FE RID: 71934 RVA: 0x0048BDA8 File Offset: 0x00489FA8
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x060118FF RID: 71935 RVA: 0x0048BDB0 File Offset: 0x00489FB0
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x06011900 RID: 71936 RVA: 0x0048BDB8 File Offset: 0x00489FB8
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x06011901 RID: 71937 RVA: 0x0048BDCC File Offset: 0x00489FCC
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x06011902 RID: 71938 RVA: 0x0048BDD4 File Offset: 0x00489FD4
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x06011903 RID: 71939 RVA: 0x0048BDE0 File Offset: 0x00489FE0
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x06011904 RID: 71940 RVA: 0x0048BDEC File Offset: 0x00489FEC
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x06011905 RID: 71941 RVA: 0x0048BDF8 File Offset: 0x00489FF8
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x06011906 RID: 71942 RVA: 0x0048BE04 File Offset: 0x0048A004
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x06011907 RID: 71943 RVA: 0x0048BE10 File Offset: 0x0048A010
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x06011908 RID: 71944 RVA: 0x0048BE1C File Offset: 0x0048A01C
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x06011909 RID: 71945 RVA: 0x0048BE28 File Offset: 0x0048A028
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0601190A RID: 71946 RVA: 0x0048BE34 File Offset: 0x0048A034
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0601190B RID: 71947 RVA: 0x0048BE40 File Offset: 0x0048A040
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0601190C RID: 71948 RVA: 0x0048BE48 File Offset: 0x0048A048
		private void __callDele_EventOnCreate()
		{
			Action eventOnCreate = this.EventOnCreate;
			if (eventOnCreate != null)
			{
				eventOnCreate();
			}
		}

		// Token: 0x0601190D RID: 71949 RVA: 0x0048BE68 File Offset: 0x0048A068
		private void __clearDele_EventOnCreate()
		{
			this.EventOnCreate = null;
		}

		// Token: 0x0601190E RID: 71950 RVA: 0x0048BE74 File Offset: 0x0048A074
		private void __callDele_EventOnAutoName()
		{
			Action eventOnAutoName = this.EventOnAutoName;
			if (eventOnAutoName != null)
			{
				eventOnAutoName();
			}
		}

		// Token: 0x0601190F RID: 71951 RVA: 0x0048BE94 File Offset: 0x0048A094
		private void __clearDele_EventOnAutoName()
		{
			this.EventOnAutoName = null;
		}

		// Token: 0x06011911 RID: 71953 RVA: 0x0048BEB0 File Offset: 0x0048A0B0
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
					this.m_Start_hotfix = (luaObj.RawGet("Start") as LuaFunction);
					this.m_OnBindFiledsCompleted_hotfix = (luaObj.RawGet("OnBindFiledsCompleted") as LuaFunction);
					this.m_Update_hotfix = (luaObj.RawGet("Update") as LuaFunction);
					this.m_Open_hotfix = (luaObj.RawGet("Open") as LuaFunction);
					this.m_CloseAction_hotfix = (luaObj.RawGet("Close") as LuaFunction);
					this.m_SetCharacterNameLimitInt32_hotfix = (luaObj.RawGet("SetCharacterNameLimit") as LuaFunction);
					this.m_SetCharacterNameString_hotfix = (luaObj.RawGet("SetCharacterName") as LuaFunction);
					this.m_GetCharacterName_hotfix = (luaObj.RawGet("GetCharacterName") as LuaFunction);
					this.m_ShowMessageStringInt32_hotfix = (luaObj.RawGet("ShowMessage") as LuaFunction);
					this.m_ShowMessageStringTableIdInt32_hotfix = (luaObj.RawGet("ShowMessage") as LuaFunction);
					this.m_HideMessage_hotfix = (luaObj.RawGet("HideMessage") as LuaFunction);
					this.m_OnCreateButtonClick_hotfix = (luaObj.RawGet("OnCreateButtonClick") as LuaFunction);
					this.m_OnAutoButtonClick_hotfix = (luaObj.RawGet("OnAutoButtonClick") as LuaFunction);
					this.m_CharacterNameInputField_OnEndEditString_hotfix = (luaObj.RawGet("CharacterNameInputField_OnEndEdit") as LuaFunction);
					this.m_add_EventOnCreateAction_hotfix = (luaObj.RawGet("add_EventOnCreate") as LuaFunction);
					this.m_remove_EventOnCreateAction_hotfix = (luaObj.RawGet("remove_EventOnCreate") as LuaFunction);
					this.m_add_EventOnAutoNameAction_hotfix = (luaObj.RawGet("add_EventOnAutoName") as LuaFunction);
					this.m_remove_EventOnAutoNameAction_hotfix = (luaObj.RawGet("remove_EventOnAutoName") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06011912 RID: 71954 RVA: 0x0048C124 File Offset: 0x0048A324
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(CreateCharacterUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400A00D RID: 40973
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_uiStateController;

		// Token: 0x0400A00E RID: 40974
		[AutoBind("./CharacterName/InputField", AutoBindAttribute.InitState.NotInit, false)]
		private InputField m_characterNameInputField;

		// Token: 0x0400A00F RID: 40975
		[AutoBind("./CreateButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_createButton;

		// Token: 0x0400A010 RID: 40976
		[AutoBind("./AutoButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_autoButton;

		// Token: 0x0400A011 RID: 40977
		[AutoBind("./Message", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_messageGameObject;

		// Token: 0x0400A012 RID: 40978
		[AutoBind("./Message/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_messageText;

		// Token: 0x0400A013 RID: 40979
		private int m_characterNameLimit;

		// Token: 0x0400A014 RID: 40980
		private float m_hideMessageTime;

		// Token: 0x0400A015 RID: 40981
		[DoNotToLua]
		private CreateCharacterUIController.LuaExportHelper luaExportHelper;

		// Token: 0x0400A016 RID: 40982
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400A017 RID: 40983
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400A018 RID: 40984
		private LuaFunction m_Start_hotfix;

		// Token: 0x0400A019 RID: 40985
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x0400A01A RID: 40986
		private LuaFunction m_Update_hotfix;

		// Token: 0x0400A01B RID: 40987
		private LuaFunction m_Open_hotfix;

		// Token: 0x0400A01C RID: 40988
		private LuaFunction m_CloseAction_hotfix;

		// Token: 0x0400A01D RID: 40989
		private LuaFunction m_SetCharacterNameLimitInt32_hotfix;

		// Token: 0x0400A01E RID: 40990
		private LuaFunction m_SetCharacterNameString_hotfix;

		// Token: 0x0400A01F RID: 40991
		private LuaFunction m_GetCharacterName_hotfix;

		// Token: 0x0400A020 RID: 40992
		private LuaFunction m_ShowMessageStringInt32_hotfix;

		// Token: 0x0400A021 RID: 40993
		private LuaFunction m_ShowMessageStringTableIdInt32_hotfix;

		// Token: 0x0400A022 RID: 40994
		private LuaFunction m_HideMessage_hotfix;

		// Token: 0x0400A023 RID: 40995
		private LuaFunction m_OnCreateButtonClick_hotfix;

		// Token: 0x0400A024 RID: 40996
		private LuaFunction m_OnAutoButtonClick_hotfix;

		// Token: 0x0400A025 RID: 40997
		private LuaFunction m_CharacterNameInputField_OnEndEditString_hotfix;

		// Token: 0x0400A026 RID: 40998
		private LuaFunction m_add_EventOnCreateAction_hotfix;

		// Token: 0x0400A027 RID: 40999
		private LuaFunction m_remove_EventOnCreateAction_hotfix;

		// Token: 0x0400A028 RID: 41000
		private LuaFunction m_add_EventOnAutoNameAction_hotfix;

		// Token: 0x0400A029 RID: 41001
		private LuaFunction m_remove_EventOnAutoNameAction_hotfix;

		// Token: 0x02000E31 RID: 3633
		public new class LuaExportHelper
		{
			// Token: 0x06011913 RID: 71955 RVA: 0x0048C18C File Offset: 0x0048A38C
			public LuaExportHelper(CreateCharacterUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06011914 RID: 71956 RVA: 0x0048C19C File Offset: 0x0048A39C
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x06011915 RID: 71957 RVA: 0x0048C1AC File Offset: 0x0048A3AC
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x06011916 RID: 71958 RVA: 0x0048C1BC File Offset: 0x0048A3BC
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x06011917 RID: 71959 RVA: 0x0048C1CC File Offset: 0x0048A3CC
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x06011918 RID: 71960 RVA: 0x0048C1E4 File Offset: 0x0048A3E4
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x06011919 RID: 71961 RVA: 0x0048C1F4 File Offset: 0x0048A3F4
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0601191A RID: 71962 RVA: 0x0048C204 File Offset: 0x0048A404
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0601191B RID: 71963 RVA: 0x0048C214 File Offset: 0x0048A414
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0601191C RID: 71964 RVA: 0x0048C224 File Offset: 0x0048A424
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0601191D RID: 71965 RVA: 0x0048C234 File Offset: 0x0048A434
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0601191E RID: 71966 RVA: 0x0048C244 File Offset: 0x0048A444
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0601191F RID: 71967 RVA: 0x0048C254 File Offset: 0x0048A454
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x06011920 RID: 71968 RVA: 0x0048C264 File Offset: 0x0048A464
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x06011921 RID: 71969 RVA: 0x0048C274 File Offset: 0x0048A474
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x06011922 RID: 71970 RVA: 0x0048C284 File Offset: 0x0048A484
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x06011923 RID: 71971 RVA: 0x0048C294 File Offset: 0x0048A494
			public void __callDele_EventOnCreate()
			{
				this.m_owner.__callDele_EventOnCreate();
			}

			// Token: 0x06011924 RID: 71972 RVA: 0x0048C2A4 File Offset: 0x0048A4A4
			public void __clearDele_EventOnCreate()
			{
				this.m_owner.__clearDele_EventOnCreate();
			}

			// Token: 0x06011925 RID: 71973 RVA: 0x0048C2B4 File Offset: 0x0048A4B4
			public void __callDele_EventOnAutoName()
			{
				this.m_owner.__callDele_EventOnAutoName();
			}

			// Token: 0x06011926 RID: 71974 RVA: 0x0048C2C4 File Offset: 0x0048A4C4
			public void __clearDele_EventOnAutoName()
			{
				this.m_owner.__clearDele_EventOnAutoName();
			}

			// Token: 0x170035F3 RID: 13811
			// (get) Token: 0x06011927 RID: 71975 RVA: 0x0048C2D4 File Offset: 0x0048A4D4
			// (set) Token: 0x06011928 RID: 71976 RVA: 0x0048C2E4 File Offset: 0x0048A4E4
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

			// Token: 0x170035F4 RID: 13812
			// (get) Token: 0x06011929 RID: 71977 RVA: 0x0048C2F4 File Offset: 0x0048A4F4
			// (set) Token: 0x0601192A RID: 71978 RVA: 0x0048C304 File Offset: 0x0048A504
			public InputField m_characterNameInputField
			{
				get
				{
					return this.m_owner.m_characterNameInputField;
				}
				set
				{
					this.m_owner.m_characterNameInputField = value;
				}
			}

			// Token: 0x170035F5 RID: 13813
			// (get) Token: 0x0601192B RID: 71979 RVA: 0x0048C314 File Offset: 0x0048A514
			// (set) Token: 0x0601192C RID: 71980 RVA: 0x0048C324 File Offset: 0x0048A524
			public Button m_createButton
			{
				get
				{
					return this.m_owner.m_createButton;
				}
				set
				{
					this.m_owner.m_createButton = value;
				}
			}

			// Token: 0x170035F6 RID: 13814
			// (get) Token: 0x0601192D RID: 71981 RVA: 0x0048C334 File Offset: 0x0048A534
			// (set) Token: 0x0601192E RID: 71982 RVA: 0x0048C344 File Offset: 0x0048A544
			public Button m_autoButton
			{
				get
				{
					return this.m_owner.m_autoButton;
				}
				set
				{
					this.m_owner.m_autoButton = value;
				}
			}

			// Token: 0x170035F7 RID: 13815
			// (get) Token: 0x0601192F RID: 71983 RVA: 0x0048C354 File Offset: 0x0048A554
			// (set) Token: 0x06011930 RID: 71984 RVA: 0x0048C364 File Offset: 0x0048A564
			public GameObject m_messageGameObject
			{
				get
				{
					return this.m_owner.m_messageGameObject;
				}
				set
				{
					this.m_owner.m_messageGameObject = value;
				}
			}

			// Token: 0x170035F8 RID: 13816
			// (get) Token: 0x06011931 RID: 71985 RVA: 0x0048C374 File Offset: 0x0048A574
			// (set) Token: 0x06011932 RID: 71986 RVA: 0x0048C384 File Offset: 0x0048A584
			public Text m_messageText
			{
				get
				{
					return this.m_owner.m_messageText;
				}
				set
				{
					this.m_owner.m_messageText = value;
				}
			}

			// Token: 0x170035F9 RID: 13817
			// (get) Token: 0x06011933 RID: 71987 RVA: 0x0048C394 File Offset: 0x0048A594
			// (set) Token: 0x06011934 RID: 71988 RVA: 0x0048C3A4 File Offset: 0x0048A5A4
			public int m_characterNameLimit
			{
				get
				{
					return this.m_owner.m_characterNameLimit;
				}
				set
				{
					this.m_owner.m_characterNameLimit = value;
				}
			}

			// Token: 0x170035FA RID: 13818
			// (get) Token: 0x06011935 RID: 71989 RVA: 0x0048C3B4 File Offset: 0x0048A5B4
			// (set) Token: 0x06011936 RID: 71990 RVA: 0x0048C3C4 File Offset: 0x0048A5C4
			public float m_hideMessageTime
			{
				get
				{
					return this.m_owner.m_hideMessageTime;
				}
				set
				{
					this.m_owner.m_hideMessageTime = value;
				}
			}

			// Token: 0x06011937 RID: 71991 RVA: 0x0048C3D4 File Offset: 0x0048A5D4
			public void Start()
			{
				this.m_owner.Start();
			}

			// Token: 0x06011938 RID: 71992 RVA: 0x0048C3E4 File Offset: 0x0048A5E4
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x06011939 RID: 71993 RVA: 0x0048C3F4 File Offset: 0x0048A5F4
			public void Update()
			{
				this.m_owner.Update();
			}

			// Token: 0x0601193A RID: 71994 RVA: 0x0048C404 File Offset: 0x0048A604
			public void OnCreateButtonClick()
			{
				this.m_owner.OnCreateButtonClick();
			}

			// Token: 0x0601193B RID: 71995 RVA: 0x0048C414 File Offset: 0x0048A614
			public void OnAutoButtonClick()
			{
				this.m_owner.OnAutoButtonClick();
			}

			// Token: 0x0601193C RID: 71996 RVA: 0x0048C424 File Offset: 0x0048A624
			public void CharacterNameInputField_OnEndEdit(string str)
			{
				this.m_owner.CharacterNameInputField_OnEndEdit(str);
			}

			// Token: 0x0400A02A RID: 41002
			private CreateCharacterUIController m_owner;
		}
	}
}
