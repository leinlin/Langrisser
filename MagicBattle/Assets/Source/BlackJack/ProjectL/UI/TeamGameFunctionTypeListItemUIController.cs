using System;
using System.Threading;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000F80 RID: 3968
	[HotFix]
	public class TeamGameFunctionTypeListItemUIController : UIControllerBase
	{
		// Token: 0x06013D4A RID: 81226 RVA: 0x0050D8B0 File Offset: 0x0050BAB0
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
			this.m_lockButton.onClick.AddListener(new UnityAction(this.OnLockButtonClick));
		}

		// Token: 0x06013D4B RID: 81227 RVA: 0x0050D950 File Offset: 0x0050BB50
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
			Text nameTextChosen = this.m_nameTextChosen;
			this.m_nameTextLock.text = name;
			this.m_nameTextUnchosen.text = name;
			nameTextChosen.text = name;
		}

		// Token: 0x06013D4C RID: 81228 RVA: 0x0050D9E8 File Offset: 0x0050BBE8
		public string GetName()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetName_hotfix != null)
			{
				return (string)this.m_GetName_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_nameTextChosen.text;
		}

		// Token: 0x06013D4D RID: 81229 RVA: 0x0050DA60 File Offset: 0x0050BC60
		public void SetGameFunctionType(GameFunctionType type)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetGameFunctionTypeGameFunctionType_hotfix != null)
			{
				this.m_SetGameFunctionTypeGameFunctionType_hotfix.call(new object[]
				{
					this,
					type
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_gameFunctionType = type;
		}

		// Token: 0x06013D4E RID: 81230 RVA: 0x0050DAD8 File Offset: 0x0050BCD8
		public GameFunctionType GetGameFunctionType()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetGameFunctionType_hotfix != null)
			{
				return (GameFunctionType)this.m_GetGameFunctionType_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_gameFunctionType;
		}

		// Token: 0x06013D4F RID: 81231 RVA: 0x0050DB4C File Offset: 0x0050BD4C
		public void SetChapterId(int chatperId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetChapterIdInt32_hotfix != null)
			{
				this.m_SetChapterIdInt32_hotfix.call(new object[]
				{
					this,
					chatperId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_chapterId = chatperId;
		}

		// Token: 0x06013D50 RID: 81232 RVA: 0x0050DBC4 File Offset: 0x0050BDC4
		public int GetChapterId()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetChapterId_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetChapterId_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_chapterId;
		}

		// Token: 0x06013D51 RID: 81233 RVA: 0x0050DC38 File Offset: 0x0050BE38
		public void SetLocked(bool isLocked)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetLockedBoolean_hotfix != null)
			{
				this.m_SetLockedBoolean_hotfix.call(new object[]
				{
					this,
					isLocked
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_uiStateController.SetToUIState((!isLocked) ? "Normal" : "Lock", false, true);
			this.m_isLocked = isLocked;
		}

		// Token: 0x06013D52 RID: 81234 RVA: 0x0050DCD4 File Offset: 0x0050BED4
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

		// Token: 0x06013D53 RID: 81235 RVA: 0x0050DD48 File Offset: 0x0050BF48
		public void SetToggleValue(bool on)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetToggleValueBoolean_hotfix != null)
			{
				this.m_SetToggleValueBoolean_hotfix.call(new object[]
				{
					this,
					on
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_toggle.isOn = on;
		}

		// Token: 0x06013D54 RID: 81236 RVA: 0x0050DDC4 File Offset: 0x0050BFC4
		public bool GetToggleValue()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetToggleValue_hotfix != null)
			{
				return Convert.ToBoolean(this.m_GetToggleValue_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_toggle.isOn;
		}

		// Token: 0x06013D55 RID: 81237 RVA: 0x0050DE3C File Offset: 0x0050C03C
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

		// Token: 0x06013D56 RID: 81238 RVA: 0x0050DEC4 File Offset: 0x0050C0C4
		private void OnLockButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnLockButtonClick_hotfix != null)
			{
				this.m_OnLockButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			CommonUIController.Instance.ShowMessage(configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Team_GameFunctionNotOpen), 2f, null, true);
		}

		// Token: 0x1400045E RID: 1118
		// (add) Token: 0x06013D57 RID: 81239 RVA: 0x0050DF50 File Offset: 0x0050C150
		// (remove) Token: 0x06013D58 RID: 81240 RVA: 0x0050DFEC File Offset: 0x0050C1EC
		public event Action<bool, TeamGameFunctionTypeListItemUIController> EventOnToggleValueChanged
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
				Action<bool, TeamGameFunctionTypeListItemUIController> action = this.EventOnToggleValueChanged;
				Action<bool, TeamGameFunctionTypeListItemUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<bool, TeamGameFunctionTypeListItemUIController>>(ref this.EventOnToggleValueChanged, (Action<bool, TeamGameFunctionTypeListItemUIController>)Delegate.Combine(action2, value), action);
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
				Action<bool, TeamGameFunctionTypeListItemUIController> action = this.EventOnToggleValueChanged;
				Action<bool, TeamGameFunctionTypeListItemUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<bool, TeamGameFunctionTypeListItemUIController>>(ref this.EventOnToggleValueChanged, (Action<bool, TeamGameFunctionTypeListItemUIController>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17003B4C RID: 15180
		// (get) Token: 0x06013D59 RID: 81241 RVA: 0x0050E088 File Offset: 0x0050C288
		// (set) Token: 0x06013D5A RID: 81242 RVA: 0x0050E0A8 File Offset: 0x0050C2A8
		[DoNotToLua]
		public new TeamGameFunctionTypeListItemUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new TeamGameFunctionTypeListItemUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06013D5B RID: 81243 RVA: 0x0050E0B4 File Offset: 0x0050C2B4
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x06013D5C RID: 81244 RVA: 0x0050E0C0 File Offset: 0x0050C2C0
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x06013D5D RID: 81245 RVA: 0x0050E0C8 File Offset: 0x0050C2C8
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x06013D5E RID: 81246 RVA: 0x0050E0D0 File Offset: 0x0050C2D0
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x06013D5F RID: 81247 RVA: 0x0050E0E4 File Offset: 0x0050C2E4
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x06013D60 RID: 81248 RVA: 0x0050E0EC File Offset: 0x0050C2EC
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x06013D61 RID: 81249 RVA: 0x0050E0F8 File Offset: 0x0050C2F8
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x06013D62 RID: 81250 RVA: 0x0050E104 File Offset: 0x0050C304
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x06013D63 RID: 81251 RVA: 0x0050E110 File Offset: 0x0050C310
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x06013D64 RID: 81252 RVA: 0x0050E11C File Offset: 0x0050C31C
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x06013D65 RID: 81253 RVA: 0x0050E128 File Offset: 0x0050C328
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x06013D66 RID: 81254 RVA: 0x0050E134 File Offset: 0x0050C334
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x06013D67 RID: 81255 RVA: 0x0050E140 File Offset: 0x0050C340
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x06013D68 RID: 81256 RVA: 0x0050E14C File Offset: 0x0050C34C
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x06013D69 RID: 81257 RVA: 0x0050E158 File Offset: 0x0050C358
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x06013D6A RID: 81258 RVA: 0x0050E160 File Offset: 0x0050C360
		private void __callDele_EventOnToggleValueChanged(bool arg1, TeamGameFunctionTypeListItemUIController arg2)
		{
			Action<bool, TeamGameFunctionTypeListItemUIController> eventOnToggleValueChanged = this.EventOnToggleValueChanged;
			if (eventOnToggleValueChanged != null)
			{
				eventOnToggleValueChanged(arg1, arg2);
			}
		}

		// Token: 0x06013D6B RID: 81259 RVA: 0x0050E184 File Offset: 0x0050C384
		private void __clearDele_EventOnToggleValueChanged(bool arg1, TeamGameFunctionTypeListItemUIController arg2)
		{
			this.EventOnToggleValueChanged = null;
		}

		// Token: 0x06013D6C RID: 81260 RVA: 0x0050E190 File Offset: 0x0050C390
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
					this.m_SetNameString_hotfix = (luaObj.RawGet("SetName") as LuaFunction);
					this.m_GetName_hotfix = (luaObj.RawGet("GetName") as LuaFunction);
					this.m_SetGameFunctionTypeGameFunctionType_hotfix = (luaObj.RawGet("SetGameFunctionType") as LuaFunction);
					this.m_GetGameFunctionType_hotfix = (luaObj.RawGet("GetGameFunctionType") as LuaFunction);
					this.m_SetChapterIdInt32_hotfix = (luaObj.RawGet("SetChapterId") as LuaFunction);
					this.m_GetChapterId_hotfix = (luaObj.RawGet("GetChapterId") as LuaFunction);
					this.m_SetLockedBoolean_hotfix = (luaObj.RawGet("SetLocked") as LuaFunction);
					this.m_IsLocked_hotfix = (luaObj.RawGet("IsLocked") as LuaFunction);
					this.m_SetToggleValueBoolean_hotfix = (luaObj.RawGet("SetToggleValue") as LuaFunction);
					this.m_GetToggleValue_hotfix = (luaObj.RawGet("GetToggleValue") as LuaFunction);
					this.m_OnToggleValueChangedBoolean_hotfix = (luaObj.RawGet("OnToggleValueChanged") as LuaFunction);
					this.m_OnLockButtonClick_hotfix = (luaObj.RawGet("OnLockButtonClick") as LuaFunction);
					this.m_add_EventOnToggleValueChangedAction`2_hotfix = (luaObj.RawGet("add_EventOnToggleValueChanged") as LuaFunction);
					this.m_remove_EventOnToggleValueChangedAction`2_hotfix = (luaObj.RawGet("remove_EventOnToggleValueChanged") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06013D6D RID: 81261 RVA: 0x0050E3BC File Offset: 0x0050C5BC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(TeamGameFunctionTypeListItemUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400AF6C RID: 44908
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_toggle;

		// Token: 0x0400AF6D RID: 44909
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_uiStateController;

		// Token: 0x0400AF6E RID: 44910
		[AutoBind("./NameTextChosen", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_nameTextChosen;

		// Token: 0x0400AF6F RID: 44911
		[AutoBind("./NameTextUnchosen", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_nameTextUnchosen;

		// Token: 0x0400AF70 RID: 44912
		[AutoBind("./NameTextLock", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_nameTextLock;

		// Token: 0x0400AF71 RID: 44913
		[AutoBind("./LockState", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_lockButton;

		// Token: 0x0400AF72 RID: 44914
		private bool m_isLocked;

		// Token: 0x0400AF73 RID: 44915
		private GameFunctionType m_gameFunctionType;

		// Token: 0x0400AF74 RID: 44916
		private int m_chapterId;

		// Token: 0x0400AF75 RID: 44917
		[DoNotToLua]
		private TeamGameFunctionTypeListItemUIController.LuaExportHelper luaExportHelper;

		// Token: 0x0400AF76 RID: 44918
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400AF77 RID: 44919
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400AF78 RID: 44920
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x0400AF79 RID: 44921
		private LuaFunction m_SetNameString_hotfix;

		// Token: 0x0400AF7A RID: 44922
		private LuaFunction m_GetName_hotfix;

		// Token: 0x0400AF7B RID: 44923
		private LuaFunction m_SetGameFunctionTypeGameFunctionType_hotfix;

		// Token: 0x0400AF7C RID: 44924
		private LuaFunction m_GetGameFunctionType_hotfix;

		// Token: 0x0400AF7D RID: 44925
		private LuaFunction m_SetChapterIdInt32_hotfix;

		// Token: 0x0400AF7E RID: 44926
		private LuaFunction m_GetChapterId_hotfix;

		// Token: 0x0400AF7F RID: 44927
		private LuaFunction m_SetLockedBoolean_hotfix;

		// Token: 0x0400AF80 RID: 44928
		private LuaFunction m_IsLocked_hotfix;

		// Token: 0x0400AF81 RID: 44929
		private LuaFunction m_SetToggleValueBoolean_hotfix;

		// Token: 0x0400AF82 RID: 44930
		private LuaFunction m_GetToggleValue_hotfix;

		// Token: 0x0400AF83 RID: 44931
		private LuaFunction m_OnToggleValueChangedBoolean_hotfix;

		// Token: 0x0400AF84 RID: 44932
		private LuaFunction m_OnLockButtonClick_hotfix;

		// Token: 0x0400AF85 RID: 44933
		private LuaFunction m_add_EventOnToggleValueChangedAction;

		// Token: 0x0400AF86 RID: 44934
		private LuaFunction m_remove_EventOnToggleValueChangedAction;

		// Token: 0x02000F81 RID: 3969
		public new class LuaExportHelper
		{
			// Token: 0x06013D6E RID: 81262 RVA: 0x0050E424 File Offset: 0x0050C624
			public LuaExportHelper(TeamGameFunctionTypeListItemUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06013D6F RID: 81263 RVA: 0x0050E434 File Offset: 0x0050C634
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x06013D70 RID: 81264 RVA: 0x0050E444 File Offset: 0x0050C644
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x06013D71 RID: 81265 RVA: 0x0050E454 File Offset: 0x0050C654
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x06013D72 RID: 81266 RVA: 0x0050E464 File Offset: 0x0050C664
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x06013D73 RID: 81267 RVA: 0x0050E47C File Offset: 0x0050C67C
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x06013D74 RID: 81268 RVA: 0x0050E48C File Offset: 0x0050C68C
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x06013D75 RID: 81269 RVA: 0x0050E49C File Offset: 0x0050C69C
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x06013D76 RID: 81270 RVA: 0x0050E4AC File Offset: 0x0050C6AC
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x06013D77 RID: 81271 RVA: 0x0050E4BC File Offset: 0x0050C6BC
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x06013D78 RID: 81272 RVA: 0x0050E4CC File Offset: 0x0050C6CC
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x06013D79 RID: 81273 RVA: 0x0050E4DC File Offset: 0x0050C6DC
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x06013D7A RID: 81274 RVA: 0x0050E4EC File Offset: 0x0050C6EC
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x06013D7B RID: 81275 RVA: 0x0050E4FC File Offset: 0x0050C6FC
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x06013D7C RID: 81276 RVA: 0x0050E50C File Offset: 0x0050C70C
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x06013D7D RID: 81277 RVA: 0x0050E51C File Offset: 0x0050C71C
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x06013D7E RID: 81278 RVA: 0x0050E52C File Offset: 0x0050C72C
			public void __callDele_EventOnToggleValueChanged(bool arg1, TeamGameFunctionTypeListItemUIController arg2)
			{
				this.m_owner.__callDele_EventOnToggleValueChanged(arg1, arg2);
			}

			// Token: 0x06013D7F RID: 81279 RVA: 0x0050E53C File Offset: 0x0050C73C
			public void __clearDele_EventOnToggleValueChanged(bool arg1, TeamGameFunctionTypeListItemUIController arg2)
			{
				this.m_owner.__clearDele_EventOnToggleValueChanged(arg1, arg2);
			}

			// Token: 0x17003B4D RID: 15181
			// (get) Token: 0x06013D80 RID: 81280 RVA: 0x0050E54C File Offset: 0x0050C74C
			// (set) Token: 0x06013D81 RID: 81281 RVA: 0x0050E55C File Offset: 0x0050C75C
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

			// Token: 0x17003B4E RID: 15182
			// (get) Token: 0x06013D82 RID: 81282 RVA: 0x0050E56C File Offset: 0x0050C76C
			// (set) Token: 0x06013D83 RID: 81283 RVA: 0x0050E57C File Offset: 0x0050C77C
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

			// Token: 0x17003B4F RID: 15183
			// (get) Token: 0x06013D84 RID: 81284 RVA: 0x0050E58C File Offset: 0x0050C78C
			// (set) Token: 0x06013D85 RID: 81285 RVA: 0x0050E59C File Offset: 0x0050C79C
			public Text m_nameTextChosen
			{
				get
				{
					return this.m_owner.m_nameTextChosen;
				}
				set
				{
					this.m_owner.m_nameTextChosen = value;
				}
			}

			// Token: 0x17003B50 RID: 15184
			// (get) Token: 0x06013D86 RID: 81286 RVA: 0x0050E5AC File Offset: 0x0050C7AC
			// (set) Token: 0x06013D87 RID: 81287 RVA: 0x0050E5BC File Offset: 0x0050C7BC
			public Text m_nameTextUnchosen
			{
				get
				{
					return this.m_owner.m_nameTextUnchosen;
				}
				set
				{
					this.m_owner.m_nameTextUnchosen = value;
				}
			}

			// Token: 0x17003B51 RID: 15185
			// (get) Token: 0x06013D88 RID: 81288 RVA: 0x0050E5CC File Offset: 0x0050C7CC
			// (set) Token: 0x06013D89 RID: 81289 RVA: 0x0050E5DC File Offset: 0x0050C7DC
			public Text m_nameTextLock
			{
				get
				{
					return this.m_owner.m_nameTextLock;
				}
				set
				{
					this.m_owner.m_nameTextLock = value;
				}
			}

			// Token: 0x17003B52 RID: 15186
			// (get) Token: 0x06013D8A RID: 81290 RVA: 0x0050E5EC File Offset: 0x0050C7EC
			// (set) Token: 0x06013D8B RID: 81291 RVA: 0x0050E5FC File Offset: 0x0050C7FC
			public Button m_lockButton
			{
				get
				{
					return this.m_owner.m_lockButton;
				}
				set
				{
					this.m_owner.m_lockButton = value;
				}
			}

			// Token: 0x17003B53 RID: 15187
			// (get) Token: 0x06013D8C RID: 81292 RVA: 0x0050E60C File Offset: 0x0050C80C
			// (set) Token: 0x06013D8D RID: 81293 RVA: 0x0050E61C File Offset: 0x0050C81C
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

			// Token: 0x17003B54 RID: 15188
			// (get) Token: 0x06013D8E RID: 81294 RVA: 0x0050E62C File Offset: 0x0050C82C
			// (set) Token: 0x06013D8F RID: 81295 RVA: 0x0050E63C File Offset: 0x0050C83C
			public GameFunctionType m_gameFunctionType
			{
				get
				{
					return this.m_owner.m_gameFunctionType;
				}
				set
				{
					this.m_owner.m_gameFunctionType = value;
				}
			}

			// Token: 0x17003B55 RID: 15189
			// (get) Token: 0x06013D90 RID: 81296 RVA: 0x0050E64C File Offset: 0x0050C84C
			// (set) Token: 0x06013D91 RID: 81297 RVA: 0x0050E65C File Offset: 0x0050C85C
			public int m_chapterId
			{
				get
				{
					return this.m_owner.m_chapterId;
				}
				set
				{
					this.m_owner.m_chapterId = value;
				}
			}

			// Token: 0x06013D92 RID: 81298 RVA: 0x0050E66C File Offset: 0x0050C86C
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x06013D93 RID: 81299 RVA: 0x0050E67C File Offset: 0x0050C87C
			public void OnToggleValueChanged(bool on)
			{
				this.m_owner.OnToggleValueChanged(on);
			}

			// Token: 0x06013D94 RID: 81300 RVA: 0x0050E68C File Offset: 0x0050C88C
			public void OnLockButtonClick()
			{
				this.m_owner.OnLockButtonClick();
			}

			// Token: 0x0400AF87 RID: 44935
			private TeamGameFunctionTypeListItemUIController m_owner;
		}
	}
}
