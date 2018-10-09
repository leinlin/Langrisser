using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Misc;
using BlackJack.ProjectL.PlayerContext;
using SLua;
using UnityEngine;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000C82 RID: 3202
	[HotFix]
	public class FettersInformationLifeItemUIController : UIControllerBase
	{
		// Token: 0x0600E691 RID: 59025 RVA: 0x003DD8FC File Offset: 0x003DBAFC
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
			base.gameObject.SetActive(true);
		}

		// Token: 0x0600E692 RID: 59026 RVA: 0x003DD970 File Offset: 0x003DBB70
		public void InitLifeItem(int biographyId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitLifeItemInt32_hotfix != null)
			{
				this.m_InitLifeItemInt32_hotfix.call(new object[]
				{
					this,
					biographyId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			this.m_heroBiographyInfo = configDataLoader.GetConfigDataHeroBiographyInfo(biographyId);
			if (this.m_heroBiographyInfo == null)
			{
				return;
			}
			this.m_isLock = (projectLPlayerContext.CanUnlockHeroBiography(biographyId) != 0);
			this.UpdateIsNewValue();
			if (this.m_isLock)
			{
				this.m_uiStateCtrl.SetToUIState("Lock", false, true);
				int parm = this.m_heroBiographyInfo.UnlockConditions[0].Parm2;
				this.m_lockText.text = string.Format(configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Msg_FavorabilityLimit), parm);
			}
			else
			{
				this.m_uiStateCtrl.SetToUIState("Unlock", false, true);
				this.m_unlockContentText.text = this.m_heroBiographyInfo.Desc;
				this.m_unlockTitleText.text = this.m_heroBiographyInfo.Title;
				bool? isNew = this.IsNew;
				if (isNew.Value)
				{
					this.m_uiStateCtrl.SetToUIState("New", false, true);
				}
				bool? isNew2 = this.IsNew;
				if (isNew2.Value)
				{
					LocalAccountConfig.Instance.AddHaveReadHeroBiography(biographyId);
				}
			}
		}

		// Token: 0x0600E693 RID: 59027 RVA: 0x003DDB10 File Offset: 0x003DBD10
		public void UpdateIsNewValue()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateIsNewValue_hotfix != null)
			{
				this.m_UpdateIsNewValue_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_isLock)
			{
				return;
			}
			if (this.m_heroBiographyInfo != null)
			{
				this.IsNew = new bool?(!this.IsBiographyRead(this.m_heroBiographyInfo.ID));
			}
		}

		// Token: 0x0600E694 RID: 59028 RVA: 0x003DDBA8 File Offset: 0x003DBDA8
		public bool IsNewTagActive()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsNewTagActive_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsNewTagActive_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIStateDesc currentUIState = this.m_uiStateCtrl.GetCurrentUIState();
			return currentUIState != null && currentUIState.StateName == "New";
		}

		// Token: 0x0600E695 RID: 59029 RVA: 0x003DDC3C File Offset: 0x003DBE3C
		private bool IsBiographyRead(int id)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsBiographyReadInt32_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsBiographyReadInt32_hotfix.call(new object[]
				{
					this,
					id
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<int> list;
			if (LocalAccountConfig.Instance.Data.HaveReadHeroBiographyIds != null)
			{
				list = new List<int>(LocalAccountConfig.Instance.Data.HaveReadHeroBiographyIds);
			}
			else
			{
				list = new List<int>();
			}
			return list.Count != 0 && list.Contains(id);
		}

		// Token: 0x17002CCD RID: 11469
		// (get) Token: 0x0600E696 RID: 59030 RVA: 0x003DDD00 File Offset: 0x003DBF00
		// (set) Token: 0x0600E697 RID: 59031 RVA: 0x003DDD20 File Offset: 0x003DBF20
		[DoNotToLua]
		public new FettersInformationLifeItemUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new FettersInformationLifeItemUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600E698 RID: 59032 RVA: 0x003DDD2C File Offset: 0x003DBF2C
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0600E699 RID: 59033 RVA: 0x003DDD38 File Offset: 0x003DBF38
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0600E69A RID: 59034 RVA: 0x003DDD40 File Offset: 0x003DBF40
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0600E69B RID: 59035 RVA: 0x003DDD48 File Offset: 0x003DBF48
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0600E69C RID: 59036 RVA: 0x003DDD5C File Offset: 0x003DBF5C
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0600E69D RID: 59037 RVA: 0x003DDD64 File Offset: 0x003DBF64
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0600E69E RID: 59038 RVA: 0x003DDD70 File Offset: 0x003DBF70
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0600E69F RID: 59039 RVA: 0x003DDD7C File Offset: 0x003DBF7C
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0600E6A0 RID: 59040 RVA: 0x003DDD88 File Offset: 0x003DBF88
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0600E6A1 RID: 59041 RVA: 0x003DDD94 File Offset: 0x003DBF94
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0600E6A2 RID: 59042 RVA: 0x003DDDA0 File Offset: 0x003DBFA0
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0600E6A3 RID: 59043 RVA: 0x003DDDAC File Offset: 0x003DBFAC
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0600E6A4 RID: 59044 RVA: 0x003DDDB8 File Offset: 0x003DBFB8
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0600E6A5 RID: 59045 RVA: 0x003DDDC4 File Offset: 0x003DBFC4
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0600E6A6 RID: 59046 RVA: 0x003DDDD0 File Offset: 0x003DBFD0
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600E6A7 RID: 59047 RVA: 0x003DDDD8 File Offset: 0x003DBFD8
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
					this.m_InitLifeItemInt32_hotfix = (luaObj.RawGet("InitLifeItem") as LuaFunction);
					this.m_UpdateIsNewValue_hotfix = (luaObj.RawGet("UpdateIsNewValue") as LuaFunction);
					this.m_IsNewTagActive_hotfix = (luaObj.RawGet("IsNewTagActive") as LuaFunction);
					this.m_IsBiographyReadInt32_hotfix = (luaObj.RawGet("IsBiographyRead") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600E6A8 RID: 59048 RVA: 0x003DDF08 File Offset: 0x003DC108
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(FettersInformationLifeItemUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04008B05 RID: 35589
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_uiStateCtrl;

		// Token: 0x04008B06 RID: 35590
		[AutoBind("./DescText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_unlockContentText;

		// Token: 0x04008B07 RID: 35591
		[AutoBind("./Title/Title/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_unlockTitleText;

		// Token: 0x04008B08 RID: 35592
		[AutoBind("./Lock/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_lockText;

		// Token: 0x04008B09 RID: 35593
		public ConfigDataHeroBiographyInfo m_heroBiographyInfo;

		// Token: 0x04008B0A RID: 35594
		public bool? IsNew;

		// Token: 0x04008B0B RID: 35595
		private bool m_isLock;

		// Token: 0x04008B0C RID: 35596
		[DoNotToLua]
		private FettersInformationLifeItemUIController.LuaExportHelper luaExportHelper;

		// Token: 0x04008B0D RID: 35597
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04008B0E RID: 35598
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04008B0F RID: 35599
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x04008B10 RID: 35600
		private LuaFunction m_InitLifeItemInt32_hotfix;

		// Token: 0x04008B11 RID: 35601
		private LuaFunction m_UpdateIsNewValue_hotfix;

		// Token: 0x04008B12 RID: 35602
		private LuaFunction m_IsNewTagActive_hotfix;

		// Token: 0x04008B13 RID: 35603
		private LuaFunction m_IsBiographyReadInt32_hotfix;

		// Token: 0x02000C83 RID: 3203
		public new class LuaExportHelper
		{
			// Token: 0x0600E6A9 RID: 59049 RVA: 0x003DDF70 File Offset: 0x003DC170
			public LuaExportHelper(FettersInformationLifeItemUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600E6AA RID: 59050 RVA: 0x003DDF80 File Offset: 0x003DC180
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0600E6AB RID: 59051 RVA: 0x003DDF90 File Offset: 0x003DC190
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0600E6AC RID: 59052 RVA: 0x003DDFA0 File Offset: 0x003DC1A0
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600E6AD RID: 59053 RVA: 0x003DDFB0 File Offset: 0x003DC1B0
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600E6AE RID: 59054 RVA: 0x003DDFC8 File Offset: 0x003DC1C8
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0600E6AF RID: 59055 RVA: 0x003DDFD8 File Offset: 0x003DC1D8
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0600E6B0 RID: 59056 RVA: 0x003DDFE8 File Offset: 0x003DC1E8
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0600E6B1 RID: 59057 RVA: 0x003DDFF8 File Offset: 0x003DC1F8
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0600E6B2 RID: 59058 RVA: 0x003DE008 File Offset: 0x003DC208
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0600E6B3 RID: 59059 RVA: 0x003DE018 File Offset: 0x003DC218
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0600E6B4 RID: 59060 RVA: 0x003DE028 File Offset: 0x003DC228
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0600E6B5 RID: 59061 RVA: 0x003DE038 File Offset: 0x003DC238
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0600E6B6 RID: 59062 RVA: 0x003DE048 File Offset: 0x003DC248
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0600E6B7 RID: 59063 RVA: 0x003DE058 File Offset: 0x003DC258
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0600E6B8 RID: 59064 RVA: 0x003DE068 File Offset: 0x003DC268
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x17002CCE RID: 11470
			// (get) Token: 0x0600E6B9 RID: 59065 RVA: 0x003DE078 File Offset: 0x003DC278
			// (set) Token: 0x0600E6BA RID: 59066 RVA: 0x003DE088 File Offset: 0x003DC288
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

			// Token: 0x17002CCF RID: 11471
			// (get) Token: 0x0600E6BB RID: 59067 RVA: 0x003DE098 File Offset: 0x003DC298
			// (set) Token: 0x0600E6BC RID: 59068 RVA: 0x003DE0A8 File Offset: 0x003DC2A8
			public Text m_unlockContentText
			{
				get
				{
					return this.m_owner.m_unlockContentText;
				}
				set
				{
					this.m_owner.m_unlockContentText = value;
				}
			}

			// Token: 0x17002CD0 RID: 11472
			// (get) Token: 0x0600E6BD RID: 59069 RVA: 0x003DE0B8 File Offset: 0x003DC2B8
			// (set) Token: 0x0600E6BE RID: 59070 RVA: 0x003DE0C8 File Offset: 0x003DC2C8
			public Text m_unlockTitleText
			{
				get
				{
					return this.m_owner.m_unlockTitleText;
				}
				set
				{
					this.m_owner.m_unlockTitleText = value;
				}
			}

			// Token: 0x17002CD1 RID: 11473
			// (get) Token: 0x0600E6BF RID: 59071 RVA: 0x003DE0D8 File Offset: 0x003DC2D8
			// (set) Token: 0x0600E6C0 RID: 59072 RVA: 0x003DE0E8 File Offset: 0x003DC2E8
			public Text m_lockText
			{
				get
				{
					return this.m_owner.m_lockText;
				}
				set
				{
					this.m_owner.m_lockText = value;
				}
			}

			// Token: 0x17002CD2 RID: 11474
			// (get) Token: 0x0600E6C1 RID: 59073 RVA: 0x003DE0F8 File Offset: 0x003DC2F8
			// (set) Token: 0x0600E6C2 RID: 59074 RVA: 0x003DE108 File Offset: 0x003DC308
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

			// Token: 0x0600E6C3 RID: 59075 RVA: 0x003DE118 File Offset: 0x003DC318
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0600E6C4 RID: 59076 RVA: 0x003DE128 File Offset: 0x003DC328
			public bool IsBiographyRead(int id)
			{
				return this.m_owner.IsBiographyRead(id);
			}

			// Token: 0x04008B14 RID: 35604
			private FettersInformationLifeItemUIController m_owner;
		}
	}
}
