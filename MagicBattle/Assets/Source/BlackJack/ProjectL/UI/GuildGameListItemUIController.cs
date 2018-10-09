using System;
using System.Threading;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000CED RID: 3309
	[HotFix]
	public class GuildGameListItemUIController : UIControllerBase
	{
		// Token: 0x0600F211 RID: 61969 RVA: 0x0040483C File Offset: 0x00402A3C
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

		// Token: 0x0600F212 RID: 61970 RVA: 0x004048C0 File Offset: 0x00402AC0
		public void InitGuildGameListItemInfo()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitGuildGameListItemInfo_hotfix != null)
			{
				this.m_InitGuildGameListItemInfo_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			int num = configDataLoader.ConfigableConstId_GuildMassiveCombatAvailableCountPerWeek - projectLPlayerContext.GetFinishedGuildMassiveCombatThisWeek();
			Guild guildInfo = projectLPlayerContext.GetGuildInfo();
			GuildMemberCacheObject guildMemberCacheObject = guildInfo.FindMember(projectLPlayerContext.GetUserId());
			GuildTitle guildTitle;
			if (guildMemberCacheObject != null)
			{
				guildTitle = guildMemberCacheObject.Member.Title;
			}
			else
			{
				guildTitle = GuildTitle.None;
			}
			if (guildTitle == GuildTitle.President || guildTitle == GuildTitle.VP)
			{
				if (num != 0)
				{
					this.m_stateCtrl.SetToUIState("Normal", false, true);
					this.m_numberText.text = num + "/" + configDataLoader.ConfigableConstId_GuildMassiveCombatAvailableCountPerWeek;
				}
				else
				{
					this.m_stateCtrl.SetToUIState("Lock", false, true);
					this.m_lockedText.text = configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Guild_GuildMassiveCombatCountZero);
				}
			}
			else if (num != 0)
			{
				if (guildInfo.MassiveCombat != null && guildInfo.MassiveCombat.RecentCombat != null)
				{
					this.m_stateCtrl.SetToUIState("Normal", false, true);
					this.m_numberText.text = num + "/" + configDataLoader.ConfigableConstId_GuildMassiveCombatAvailableCountPerWeek;
				}
				else
				{
					this.m_stateCtrl.SetToUIState("Lock", false, true);
					this.m_lockedText.text = configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Guild_WaitOpenGuildMassiveCombat);
				}
			}
			else
			{
				this.m_stateCtrl.SetToUIState("Lock", false, true);
				this.m_lockedText.text = configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Guild_GuildMassiveCombatCountZero);
			}
		}

		// Token: 0x0600F213 RID: 61971 RVA: 0x00404AB4 File Offset: 0x00402CB4
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

		// Token: 0x1400032E RID: 814
		// (add) Token: 0x0600F214 RID: 61972 RVA: 0x00404B2C File Offset: 0x00402D2C
		// (remove) Token: 0x0600F215 RID: 61973 RVA: 0x00404BC8 File Offset: 0x00402DC8
		public event Action<GuildGameListItemUIController> EventOnClick
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
				Action<GuildGameListItemUIController> action = this.EventOnClick;
				Action<GuildGameListItemUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<GuildGameListItemUIController>>(ref this.EventOnClick, (Action<GuildGameListItemUIController>)Delegate.Combine(action2, value), action);
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
				Action<GuildGameListItemUIController> action = this.EventOnClick;
				Action<GuildGameListItemUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<GuildGameListItemUIController>>(ref this.EventOnClick, (Action<GuildGameListItemUIController>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17002E82 RID: 11906
		// (get) Token: 0x0600F216 RID: 61974 RVA: 0x00404C64 File Offset: 0x00402E64
		// (set) Token: 0x0600F217 RID: 61975 RVA: 0x00404C84 File Offset: 0x00402E84
		[DoNotToLua]
		public new GuildGameListItemUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new GuildGameListItemUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600F218 RID: 61976 RVA: 0x00404C90 File Offset: 0x00402E90
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0600F219 RID: 61977 RVA: 0x00404C9C File Offset: 0x00402E9C
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0600F21A RID: 61978 RVA: 0x00404CA4 File Offset: 0x00402EA4
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0600F21B RID: 61979 RVA: 0x00404CAC File Offset: 0x00402EAC
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0600F21C RID: 61980 RVA: 0x00404CC0 File Offset: 0x00402EC0
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0600F21D RID: 61981 RVA: 0x00404CC8 File Offset: 0x00402EC8
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0600F21E RID: 61982 RVA: 0x00404CD4 File Offset: 0x00402ED4
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0600F21F RID: 61983 RVA: 0x00404CE0 File Offset: 0x00402EE0
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0600F220 RID: 61984 RVA: 0x00404CEC File Offset: 0x00402EEC
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0600F221 RID: 61985 RVA: 0x00404CF8 File Offset: 0x00402EF8
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0600F222 RID: 61986 RVA: 0x00404D04 File Offset: 0x00402F04
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0600F223 RID: 61987 RVA: 0x00404D10 File Offset: 0x00402F10
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0600F224 RID: 61988 RVA: 0x00404D1C File Offset: 0x00402F1C
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0600F225 RID: 61989 RVA: 0x00404D28 File Offset: 0x00402F28
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0600F226 RID: 61990 RVA: 0x00404D34 File Offset: 0x00402F34
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600F227 RID: 61991 RVA: 0x00404D3C File Offset: 0x00402F3C
		private void __callDele_EventOnClick(GuildGameListItemUIController obj)
		{
			Action<GuildGameListItemUIController> eventOnClick = this.EventOnClick;
			if (eventOnClick != null)
			{
				eventOnClick(obj);
			}
		}

		// Token: 0x0600F228 RID: 61992 RVA: 0x00404D60 File Offset: 0x00402F60
		private void __clearDele_EventOnClick(GuildGameListItemUIController obj)
		{
			this.EventOnClick = null;
		}

		// Token: 0x0600F229 RID: 61993 RVA: 0x00404D6C File Offset: 0x00402F6C
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
					this.m_InitGuildGameListItemInfo_hotfix = (luaObj.RawGet("InitGuildGameListItemInfo") as LuaFunction);
					this.m_OnClick_hotfix = (luaObj.RawGet("OnClick") as LuaFunction);
					this.m_add_EventOnClickAction`1_hotfix = (luaObj.RawGet("add_EventOnClick") as LuaFunction);
					this.m_remove_EventOnClickAction`1_hotfix = (luaObj.RawGet("remove_EventOnClick") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600F22A RID: 61994 RVA: 0x00404E9C File Offset: 0x0040309C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(GuildGameListItemUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04008FBD RID: 36797
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_stateCtrl;

		// Token: 0x04008FBE RID: 36798
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_button;

		// Token: 0x04008FBF RID: 36799
		[AutoBind("./DailyReward/NumberText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_numberText;

		// Token: 0x04008FC0 RID: 36800
		[AutoBind("./Locked/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_lockedText;

		// Token: 0x04008FC1 RID: 36801
		[DoNotToLua]
		private GuildGameListItemUIController.LuaExportHelper luaExportHelper;

		// Token: 0x04008FC2 RID: 36802
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04008FC3 RID: 36803
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04008FC4 RID: 36804
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x04008FC5 RID: 36805
		private LuaFunction m_InitGuildGameListItemInfo_hotfix;

		// Token: 0x04008FC6 RID: 36806
		private LuaFunction m_OnClick_hotfix;

		// Token: 0x04008FC7 RID: 36807
		private LuaFunction m_add_EventOnClickAction;

		// Token: 0x04008FC8 RID: 36808
		private LuaFunction m_remove_EventOnClickAction;

		// Token: 0x02000CEE RID: 3310
		public new class LuaExportHelper
		{
			// Token: 0x0600F22B RID: 61995 RVA: 0x00404F04 File Offset: 0x00403104
			public LuaExportHelper(GuildGameListItemUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600F22C RID: 61996 RVA: 0x00404F14 File Offset: 0x00403114
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0600F22D RID: 61997 RVA: 0x00404F24 File Offset: 0x00403124
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0600F22E RID: 61998 RVA: 0x00404F34 File Offset: 0x00403134
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600F22F RID: 61999 RVA: 0x00404F44 File Offset: 0x00403144
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600F230 RID: 62000 RVA: 0x00404F5C File Offset: 0x0040315C
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0600F231 RID: 62001 RVA: 0x00404F6C File Offset: 0x0040316C
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0600F232 RID: 62002 RVA: 0x00404F7C File Offset: 0x0040317C
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0600F233 RID: 62003 RVA: 0x00404F8C File Offset: 0x0040318C
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0600F234 RID: 62004 RVA: 0x00404F9C File Offset: 0x0040319C
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0600F235 RID: 62005 RVA: 0x00404FAC File Offset: 0x004031AC
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0600F236 RID: 62006 RVA: 0x00404FBC File Offset: 0x004031BC
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0600F237 RID: 62007 RVA: 0x00404FCC File Offset: 0x004031CC
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0600F238 RID: 62008 RVA: 0x00404FDC File Offset: 0x004031DC
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0600F239 RID: 62009 RVA: 0x00404FEC File Offset: 0x004031EC
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0600F23A RID: 62010 RVA: 0x00404FFC File Offset: 0x004031FC
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x0600F23B RID: 62011 RVA: 0x0040500C File Offset: 0x0040320C
			public void __callDele_EventOnClick(GuildGameListItemUIController obj)
			{
				this.m_owner.__callDele_EventOnClick(obj);
			}

			// Token: 0x0600F23C RID: 62012 RVA: 0x0040501C File Offset: 0x0040321C
			public void __clearDele_EventOnClick(GuildGameListItemUIController obj)
			{
				this.m_owner.__clearDele_EventOnClick(obj);
			}

			// Token: 0x17002E83 RID: 11907
			// (get) Token: 0x0600F23D RID: 62013 RVA: 0x0040502C File Offset: 0x0040322C
			// (set) Token: 0x0600F23E RID: 62014 RVA: 0x0040503C File Offset: 0x0040323C
			public CommonUIStateController m_stateCtrl
			{
				get
				{
					return this.m_owner.m_stateCtrl;
				}
				set
				{
					this.m_owner.m_stateCtrl = value;
				}
			}

			// Token: 0x17002E84 RID: 11908
			// (get) Token: 0x0600F23F RID: 62015 RVA: 0x0040504C File Offset: 0x0040324C
			// (set) Token: 0x0600F240 RID: 62016 RVA: 0x0040505C File Offset: 0x0040325C
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

			// Token: 0x17002E85 RID: 11909
			// (get) Token: 0x0600F241 RID: 62017 RVA: 0x0040506C File Offset: 0x0040326C
			// (set) Token: 0x0600F242 RID: 62018 RVA: 0x0040507C File Offset: 0x0040327C
			public Text m_numberText
			{
				get
				{
					return this.m_owner.m_numberText;
				}
				set
				{
					this.m_owner.m_numberText = value;
				}
			}

			// Token: 0x17002E86 RID: 11910
			// (get) Token: 0x0600F243 RID: 62019 RVA: 0x0040508C File Offset: 0x0040328C
			// (set) Token: 0x0600F244 RID: 62020 RVA: 0x0040509C File Offset: 0x0040329C
			public Text m_lockedText
			{
				get
				{
					return this.m_owner.m_lockedText;
				}
				set
				{
					this.m_owner.m_lockedText = value;
				}
			}

			// Token: 0x0600F245 RID: 62021 RVA: 0x004050AC File Offset: 0x004032AC
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0600F246 RID: 62022 RVA: 0x004050BC File Offset: 0x004032BC
			public void OnClick()
			{
				this.m_owner.OnClick();
			}

			// Token: 0x04008FC9 RID: 36809
			private GuildGameListItemUIController m_owner;
		}
	}
}
