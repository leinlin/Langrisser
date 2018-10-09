using System;
using System.Threading;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.PlayerContext;
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000C54 RID: 3156
	[HotFix]
	public class TrainingDifficultItemUIController : UIControllerBase
	{
		// Token: 0x0600DFA5 RID: 57253 RVA: 0x003C5744 File Offset: 0x003C3944
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
			base.gameObject.GetComponent<Button>().onClick.AddListener(new UnityAction(this.OnItemClick));
			base.gameObject.SetActive(true);
		}

		// Token: 0x0600DFA6 RID: 57254 RVA: 0x003C57D8 File Offset: 0x003C39D8
		public void InitDifficultItem(int unlockPlayerLevel, int difficult)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitDifficultItemInt32Int32_hotfix != null)
			{
				this.m_InitDifficultItemInt32Int32_hotfix.call(new object[]
				{
					this,
					unlockPlayerLevel,
					difficult
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.DifficultLevel = difficult;
			this.m_unlockPlayerLevel = unlockPlayerLevel;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			int playerLevel = projectLPlayerContext.GetPlayerLevel();
			this.m_isLock = (playerLevel < unlockPlayerLevel);
			if (this.m_isLock)
			{
				this.m_uiStateCtrl.SetToUIState("Lock", false, true);
			}
			else
			{
				this.m_uiStateCtrl.SetToUIState("Normal", false, true);
			}
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			this.m_unLockText.text = string.Format(configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Msg_PlayerLevelUnlock), unlockPlayerLevel);
			this.m_newImage.SetActive(this.m_isNew);
		}

		// Token: 0x0600DFA7 RID: 57255 RVA: 0x003C5900 File Offset: 0x003C3B00
		private void OnItemClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnItemClick_hotfix != null)
			{
				this.m_OnItemClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_isLock)
			{
				IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
				string txt = string.Format(configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Msg_PlayerLevelUnlock), this.m_unlockPlayerLevel);
				CommonUIController.Instance.ShowMessage(txt, 2f, null, true);
				return;
			}
			this.m_isNew = false;
			if (this.EventOnItemClick != null)
			{
				this.EventOnItemClick(this);
			}
		}

		// Token: 0x0600DFA8 RID: 57256 RVA: 0x003C59C8 File Offset: 0x003C3BC8
		public void ShowSelectFrame(bool isShow)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowSelectFrameBoolean_hotfix != null)
			{
				this.m_ShowSelectFrameBoolean_hotfix.call(new object[]
				{
					this,
					isShow
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_selectImage.SetActive(isShow);
		}

		// Token: 0x140002C8 RID: 712
		// (add) Token: 0x0600DFA9 RID: 57257 RVA: 0x003C5A44 File Offset: 0x003C3C44
		// (remove) Token: 0x0600DFAA RID: 57258 RVA: 0x003C5AE0 File Offset: 0x003C3CE0
		public event Action<TrainingDifficultItemUIController> EventOnItemClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnItemClickAction`1_hotfix != null)
				{
					this.m_add_EventOnItemClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<TrainingDifficultItemUIController> action = this.EventOnItemClick;
				Action<TrainingDifficultItemUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<TrainingDifficultItemUIController>>(ref this.EventOnItemClick, (Action<TrainingDifficultItemUIController>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnItemClickAction`1_hotfix != null)
				{
					this.m_remove_EventOnItemClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<TrainingDifficultItemUIController> action = this.EventOnItemClick;
				Action<TrainingDifficultItemUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<TrainingDifficultItemUIController>>(ref this.EventOnItemClick, (Action<TrainingDifficultItemUIController>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17002B73 RID: 11123
		// (get) Token: 0x0600DFAB RID: 57259 RVA: 0x003C5B7C File Offset: 0x003C3D7C
		// (set) Token: 0x0600DFAC RID: 57260 RVA: 0x003C5B9C File Offset: 0x003C3D9C
		[DoNotToLua]
		public new TrainingDifficultItemUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new TrainingDifficultItemUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600DFAD RID: 57261 RVA: 0x003C5BA8 File Offset: 0x003C3DA8
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0600DFAE RID: 57262 RVA: 0x003C5BB4 File Offset: 0x003C3DB4
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0600DFAF RID: 57263 RVA: 0x003C5BBC File Offset: 0x003C3DBC
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0600DFB0 RID: 57264 RVA: 0x003C5BC4 File Offset: 0x003C3DC4
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0600DFB1 RID: 57265 RVA: 0x003C5BD8 File Offset: 0x003C3DD8
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0600DFB2 RID: 57266 RVA: 0x003C5BE0 File Offset: 0x003C3DE0
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0600DFB3 RID: 57267 RVA: 0x003C5BEC File Offset: 0x003C3DEC
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0600DFB4 RID: 57268 RVA: 0x003C5BF8 File Offset: 0x003C3DF8
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0600DFB5 RID: 57269 RVA: 0x003C5C04 File Offset: 0x003C3E04
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0600DFB6 RID: 57270 RVA: 0x003C5C10 File Offset: 0x003C3E10
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0600DFB7 RID: 57271 RVA: 0x003C5C1C File Offset: 0x003C3E1C
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0600DFB8 RID: 57272 RVA: 0x003C5C28 File Offset: 0x003C3E28
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0600DFB9 RID: 57273 RVA: 0x003C5C34 File Offset: 0x003C3E34
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0600DFBA RID: 57274 RVA: 0x003C5C40 File Offset: 0x003C3E40
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0600DFBB RID: 57275 RVA: 0x003C5C4C File Offset: 0x003C3E4C
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600DFBC RID: 57276 RVA: 0x003C5C54 File Offset: 0x003C3E54
		private void __callDele_EventOnItemClick(TrainingDifficultItemUIController obj)
		{
			Action<TrainingDifficultItemUIController> eventOnItemClick = this.EventOnItemClick;
			if (eventOnItemClick != null)
			{
				eventOnItemClick(obj);
			}
		}

		// Token: 0x0600DFBD RID: 57277 RVA: 0x003C5C78 File Offset: 0x003C3E78
		private void __clearDele_EventOnItemClick(TrainingDifficultItemUIController obj)
		{
			this.EventOnItemClick = null;
		}

		// Token: 0x0600DFBE RID: 57278 RVA: 0x003C5C84 File Offset: 0x003C3E84
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
					this.m_InitDifficultItemInt32Int32_hotfix = (luaObj.RawGet("InitDifficultItem") as LuaFunction);
					this.m_OnItemClick_hotfix = (luaObj.RawGet("OnItemClick") as LuaFunction);
					this.m_ShowSelectFrameBoolean_hotfix = (luaObj.RawGet("ShowSelectFrame") as LuaFunction);
					this.m_add_EventOnItemClickAction`1_hotfix = (luaObj.RawGet("add_EventOnItemClick") as LuaFunction);
					this.m_remove_EventOnItemClickAction`1_hotfix = (luaObj.RawGet("remove_EventOnItemClick") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600DFBF RID: 57279 RVA: 0x003C5DCC File Offset: 0x003C3FCC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(TrainingDifficultItemUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04008816 RID: 34838
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_uiStateCtrl;

		// Token: 0x04008817 RID: 34839
		[AutoBind("./UnLockText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_unLockText;

		// Token: 0x04008818 RID: 34840
		[AutoBind("./NewImage", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_newImage;

		// Token: 0x04008819 RID: 34841
		[AutoBind("./SelectImage", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_selectImage;

		// Token: 0x0400881A RID: 34842
		private bool m_isLock;

		// Token: 0x0400881B RID: 34843
		private bool m_isNew;

		// Token: 0x0400881C RID: 34844
		public int DifficultLevel;

		// Token: 0x0400881D RID: 34845
		private int m_unlockPlayerLevel;

		// Token: 0x0400881E RID: 34846
		[DoNotToLua]
		private TrainingDifficultItemUIController.LuaExportHelper luaExportHelper;

		// Token: 0x0400881F RID: 34847
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04008820 RID: 34848
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04008821 RID: 34849
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x04008822 RID: 34850
		private LuaFunction m_InitDifficultItemInt32Int32_hotfix;

		// Token: 0x04008823 RID: 34851
		private LuaFunction m_OnItemClick_hotfix;

		// Token: 0x04008824 RID: 34852
		private LuaFunction m_ShowSelectFrameBoolean_hotfix;

		// Token: 0x04008825 RID: 34853
		private LuaFunction m_add_EventOnItemClickAction;

		// Token: 0x04008826 RID: 34854
		private LuaFunction m_remove_EventOnItemClickAction;

		// Token: 0x02000C55 RID: 3157
		public new class LuaExportHelper
		{
			// Token: 0x0600DFC0 RID: 57280 RVA: 0x003C5E34 File Offset: 0x003C4034
			public LuaExportHelper(TrainingDifficultItemUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600DFC1 RID: 57281 RVA: 0x003C5E44 File Offset: 0x003C4044
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0600DFC2 RID: 57282 RVA: 0x003C5E54 File Offset: 0x003C4054
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0600DFC3 RID: 57283 RVA: 0x003C5E64 File Offset: 0x003C4064
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600DFC4 RID: 57284 RVA: 0x003C5E74 File Offset: 0x003C4074
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600DFC5 RID: 57285 RVA: 0x003C5E8C File Offset: 0x003C408C
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0600DFC6 RID: 57286 RVA: 0x003C5E9C File Offset: 0x003C409C
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0600DFC7 RID: 57287 RVA: 0x003C5EAC File Offset: 0x003C40AC
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0600DFC8 RID: 57288 RVA: 0x003C5EBC File Offset: 0x003C40BC
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0600DFC9 RID: 57289 RVA: 0x003C5ECC File Offset: 0x003C40CC
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0600DFCA RID: 57290 RVA: 0x003C5EDC File Offset: 0x003C40DC
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0600DFCB RID: 57291 RVA: 0x003C5EEC File Offset: 0x003C40EC
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0600DFCC RID: 57292 RVA: 0x003C5EFC File Offset: 0x003C40FC
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0600DFCD RID: 57293 RVA: 0x003C5F0C File Offset: 0x003C410C
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0600DFCE RID: 57294 RVA: 0x003C5F1C File Offset: 0x003C411C
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0600DFCF RID: 57295 RVA: 0x003C5F2C File Offset: 0x003C412C
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x0600DFD0 RID: 57296 RVA: 0x003C5F3C File Offset: 0x003C413C
			public void __callDele_EventOnItemClick(TrainingDifficultItemUIController obj)
			{
				this.m_owner.__callDele_EventOnItemClick(obj);
			}

			// Token: 0x0600DFD1 RID: 57297 RVA: 0x003C5F4C File Offset: 0x003C414C
			public void __clearDele_EventOnItemClick(TrainingDifficultItemUIController obj)
			{
				this.m_owner.__clearDele_EventOnItemClick(obj);
			}

			// Token: 0x17002B74 RID: 11124
			// (get) Token: 0x0600DFD2 RID: 57298 RVA: 0x003C5F5C File Offset: 0x003C415C
			// (set) Token: 0x0600DFD3 RID: 57299 RVA: 0x003C5F6C File Offset: 0x003C416C
			public CommonUIStateController m_uiStateCtrl
			{
				get
				{
					return this.m_owner.m_uiStateCtrl;
				}
				set
				{
					this.m_owner.m_uiStateCtrl = value;
				}
			}

			// Token: 0x17002B75 RID: 11125
			// (get) Token: 0x0600DFD4 RID: 57300 RVA: 0x003C5F7C File Offset: 0x003C417C
			// (set) Token: 0x0600DFD5 RID: 57301 RVA: 0x003C5F8C File Offset: 0x003C418C
			public Text m_unLockText
			{
				get
				{
					return this.m_owner.m_unLockText;
				}
				set
				{
					this.m_owner.m_unLockText = value;
				}
			}

			// Token: 0x17002B76 RID: 11126
			// (get) Token: 0x0600DFD6 RID: 57302 RVA: 0x003C5F9C File Offset: 0x003C419C
			// (set) Token: 0x0600DFD7 RID: 57303 RVA: 0x003C5FAC File Offset: 0x003C41AC
			public GameObject m_newImage
			{
				get
				{
					return this.m_owner.m_newImage;
				}
				set
				{
					this.m_owner.m_newImage = value;
				}
			}

			// Token: 0x17002B77 RID: 11127
			// (get) Token: 0x0600DFD8 RID: 57304 RVA: 0x003C5FBC File Offset: 0x003C41BC
			// (set) Token: 0x0600DFD9 RID: 57305 RVA: 0x003C5FCC File Offset: 0x003C41CC
			public GameObject m_selectImage
			{
				get
				{
					return this.m_owner.m_selectImage;
				}
				set
				{
					this.m_owner.m_selectImage = value;
				}
			}

			// Token: 0x17002B78 RID: 11128
			// (get) Token: 0x0600DFDA RID: 57306 RVA: 0x003C5FDC File Offset: 0x003C41DC
			// (set) Token: 0x0600DFDB RID: 57307 RVA: 0x003C5FEC File Offset: 0x003C41EC
			public bool m_isLock
			{
				get
				{
					return this.m_owner.m_isLock;
				}
				set
				{
					this.m_owner.m_isLock = value;
				}
			}

			// Token: 0x17002B79 RID: 11129
			// (get) Token: 0x0600DFDC RID: 57308 RVA: 0x003C5FFC File Offset: 0x003C41FC
			// (set) Token: 0x0600DFDD RID: 57309 RVA: 0x003C600C File Offset: 0x003C420C
			public bool m_isNew
			{
				get
				{
					return this.m_owner.m_isNew;
				}
				set
				{
					this.m_owner.m_isNew = value;
				}
			}

			// Token: 0x17002B7A RID: 11130
			// (get) Token: 0x0600DFDE RID: 57310 RVA: 0x003C601C File Offset: 0x003C421C
			// (set) Token: 0x0600DFDF RID: 57311 RVA: 0x003C602C File Offset: 0x003C422C
			public int m_unlockPlayerLevel
			{
				get
				{
					return this.m_owner.m_unlockPlayerLevel;
				}
				set
				{
					this.m_owner.m_unlockPlayerLevel = value;
				}
			}

			// Token: 0x0600DFE0 RID: 57312 RVA: 0x003C603C File Offset: 0x003C423C
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0600DFE1 RID: 57313 RVA: 0x003C604C File Offset: 0x003C424C
			public void OnItemClick()
			{
				this.m_owner.OnItemClick();
			}

			// Token: 0x04008827 RID: 34855
			private TrainingDifficultItemUIController m_owner;
		}
	}
}
