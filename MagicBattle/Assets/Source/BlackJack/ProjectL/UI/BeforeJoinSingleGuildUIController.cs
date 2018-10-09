using System;
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
	// Token: 0x02000CDD RID: 3293
	[HotFix]
	public class BeforeJoinSingleGuildUIController : UIControllerBase
	{
		// Token: 0x0600F028 RID: 61480 RVA: 0x003FF69C File Offset: 0x003FD89C
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
			this.m_configDataLoader = (GameManager.Instance.ConfigDataLoader as IConfigDataLoader);
			this.m_playerContext = (GameManager.Instance.PlayerContext as ProjectLPlayerContext);
		}

		// Token: 0x0600F029 RID: 61481 RVA: 0x003FF72C File Offset: 0x003FD92C
		public void Init(GuildSearchInfo guildSearchInfo, Action<BeforeJoinSingleGuildUIController> selectClick)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitGuildSearchInfoAction`1_hotfix != null)
			{
				this.m_InitGuildSearchInfoAction`1_hotfix.call(new object[]
				{
					this,
					guildSearchInfo,
					selectClick
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_guildSearchInfo = guildSearchInfo;
			this.m_guildButton.onClick.AddListener(new UnityAction(this.OnItemClick));
			this.OnEventSelect = selectClick;
			this.Refresh(guildSearchInfo);
		}

		// Token: 0x0600F02A RID: 61482 RVA: 0x003FF7E0 File Offset: 0x003FD9E0
		public void SetSelect(bool isSelect)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetSelectBoolean_hotfix != null)
			{
				this.m_SetSelectBoolean_hotfix.call(new object[]
				{
					this,
					isSelect
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_guildCreateButton.gameObject.SetActive(isSelect);
		}

		// Token: 0x0600F02B RID: 61483 RVA: 0x003FF864 File Offset: 0x003FDA64
		public void SetApply(bool isApply)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetApplyBoolean_hotfix != null)
			{
				this.m_SetApplyBoolean_hotfix.call(new object[]
				{
					this,
					isApply
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_applyGameObject.gameObject.SetActive(isApply);
		}

		// Token: 0x0600F02C RID: 61484 RVA: 0x003FF8E8 File Offset: 0x003FDAE8
		public void Refresh(GuildSearchInfo guildSearchInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_RefreshGuildSearchInfo_hotfix != null)
			{
				this.m_RefreshGuildSearchInfo_hotfix.call(new object[]
				{
					this,
					guildSearchInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_guildCreateButton.gameObject.SetActive(false);
			this.m_sociatyNameText.text = guildSearchInfo.Name;
			if (guildSearchInfo.MemberCount == this.m_configDataLoader.ConfigableConstId_GuildMemberCountMax)
			{
				this.m_peopleValueText.text = string.Format("<color=red>{0}</color>/{1}", guildSearchInfo.MemberCount, this.m_configDataLoader.ConfigableConstId_GuildMemberCountMax);
			}
			else
			{
				this.m_peopleValueText.text = string.Format("{0}/{1}", guildSearchInfo.MemberCount, this.m_configDataLoader.ConfigableConstId_GuildMemberCountMax);
			}
			this.m_LevelRequireText.text = guildSearchInfo.JoinLevel.ToString();
			this.m_vitalityText.text = guildSearchInfo.LastWeekActivities.ToString();
			this.m_applyGameObject.gameObject.SetActive(guildSearchInfo.HaveSendJoinReq);
		}

		// Token: 0x0600F02D RID: 61485 RVA: 0x003FFA4C File Offset: 0x003FDC4C
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
			if (this.OnEventSelect != null)
			{
				this.OnEventSelect(this);
			}
		}

		// Token: 0x17002E39 RID: 11833
		// (get) Token: 0x0600F02E RID: 61486 RVA: 0x003FFAC4 File Offset: 0x003FDCC4
		// (set) Token: 0x0600F02F RID: 61487 RVA: 0x003FFAE4 File Offset: 0x003FDCE4
		[DoNotToLua]
		public new BeforeJoinSingleGuildUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new BeforeJoinSingleGuildUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600F030 RID: 61488 RVA: 0x003FFAF0 File Offset: 0x003FDCF0
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0600F031 RID: 61489 RVA: 0x003FFAFC File Offset: 0x003FDCFC
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0600F032 RID: 61490 RVA: 0x003FFB04 File Offset: 0x003FDD04
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0600F033 RID: 61491 RVA: 0x003FFB0C File Offset: 0x003FDD0C
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0600F034 RID: 61492 RVA: 0x003FFB20 File Offset: 0x003FDD20
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0600F035 RID: 61493 RVA: 0x003FFB28 File Offset: 0x003FDD28
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0600F036 RID: 61494 RVA: 0x003FFB34 File Offset: 0x003FDD34
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0600F037 RID: 61495 RVA: 0x003FFB40 File Offset: 0x003FDD40
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0600F038 RID: 61496 RVA: 0x003FFB4C File Offset: 0x003FDD4C
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0600F039 RID: 61497 RVA: 0x003FFB58 File Offset: 0x003FDD58
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0600F03A RID: 61498 RVA: 0x003FFB64 File Offset: 0x003FDD64
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0600F03B RID: 61499 RVA: 0x003FFB70 File Offset: 0x003FDD70
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0600F03C RID: 61500 RVA: 0x003FFB7C File Offset: 0x003FDD7C
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0600F03D RID: 61501 RVA: 0x003FFB88 File Offset: 0x003FDD88
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0600F03E RID: 61502 RVA: 0x003FFB94 File Offset: 0x003FDD94
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600F03F RID: 61503 RVA: 0x003FFB9C File Offset: 0x003FDD9C
		private void __callDele_OnEventSelect(BeforeJoinSingleGuildUIController obj)
		{
			Action<BeforeJoinSingleGuildUIController> onEventSelect = this.OnEventSelect;
			if (onEventSelect != null)
			{
				onEventSelect(obj);
			}
		}

		// Token: 0x0600F040 RID: 61504 RVA: 0x003FFBC0 File Offset: 0x003FDDC0
		private void __clearDele_OnEventSelect(BeforeJoinSingleGuildUIController obj)
		{
			this.OnEventSelect = null;
		}

		// Token: 0x0600F041 RID: 61505 RVA: 0x003FFBCC File Offset: 0x003FDDCC
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
					this.m_InitGuildSearchInfoAction`1_hotfix = (luaObj.RawGet("Init") as LuaFunction);
					this.m_SetSelectBoolean_hotfix = (luaObj.RawGet("SetSelect") as LuaFunction);
					this.m_SetApplyBoolean_hotfix = (luaObj.RawGet("SetApply") as LuaFunction);
					this.m_RefreshGuildSearchInfo_hotfix = (luaObj.RawGet("Refresh") as LuaFunction);
					this.m_OnItemClick_hotfix = (luaObj.RawGet("OnItemClick") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600F042 RID: 61506 RVA: 0x003FFD14 File Offset: 0x003FDF14
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BeforeJoinSingleGuildUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04008EFF RID: 36607
		[AutoBind(".", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_guildButton;

		// Token: 0x04008F00 RID: 36608
		[AutoBind("./SecletImage", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_guildCreateButton;

		// Token: 0x04008F01 RID: 36609
		[AutoBind("./SociatyNameText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_sociatyNameText;

		// Token: 0x04008F02 RID: 36610
		[AutoBind("./PeopleValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_peopleValueText;

		// Token: 0x04008F03 RID: 36611
		[AutoBind("./LevelText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_LevelRequireText;

		// Token: 0x04008F04 RID: 36612
		[AutoBind("./VitalityText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_vitalityText;

		// Token: 0x04008F05 RID: 36613
		[AutoBind("./Apply", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_applyGameObject;

		// Token: 0x04008F06 RID: 36614
		private Action<BeforeJoinSingleGuildUIController> OnEventSelect;

		// Token: 0x04008F07 RID: 36615
		private ProjectLPlayerContext m_playerContext;

		// Token: 0x04008F08 RID: 36616
		private IConfigDataLoader m_configDataLoader;

		// Token: 0x04008F09 RID: 36617
		public GuildSearchInfo m_guildSearchInfo;

		// Token: 0x04008F0A RID: 36618
		[DoNotToLua]
		private BeforeJoinSingleGuildUIController.LuaExportHelper luaExportHelper;

		// Token: 0x04008F0B RID: 36619
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04008F0C RID: 36620
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04008F0D RID: 36621
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x04008F0E RID: 36622
		private LuaFunction m_InitGuildSearchInfoAction;

		// Token: 0x04008F0F RID: 36623
		private LuaFunction m_SetSelectBoolean_hotfix;

		// Token: 0x04008F10 RID: 36624
		private LuaFunction m_SetApplyBoolean_hotfix;

		// Token: 0x04008F11 RID: 36625
		private LuaFunction m_RefreshGuildSearchInfo_hotfix;

		// Token: 0x04008F12 RID: 36626
		private LuaFunction m_OnItemClick_hotfix;

		// Token: 0x02000CDE RID: 3294
		public new class LuaExportHelper
		{
			// Token: 0x0600F043 RID: 61507 RVA: 0x003FFD7C File Offset: 0x003FDF7C
			public LuaExportHelper(BeforeJoinSingleGuildUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600F044 RID: 61508 RVA: 0x003FFD8C File Offset: 0x003FDF8C
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0600F045 RID: 61509 RVA: 0x003FFD9C File Offset: 0x003FDF9C
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0600F046 RID: 61510 RVA: 0x003FFDAC File Offset: 0x003FDFAC
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600F047 RID: 61511 RVA: 0x003FFDBC File Offset: 0x003FDFBC
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600F048 RID: 61512 RVA: 0x003FFDD4 File Offset: 0x003FDFD4
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0600F049 RID: 61513 RVA: 0x003FFDE4 File Offset: 0x003FDFE4
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0600F04A RID: 61514 RVA: 0x003FFDF4 File Offset: 0x003FDFF4
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0600F04B RID: 61515 RVA: 0x003FFE04 File Offset: 0x003FE004
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0600F04C RID: 61516 RVA: 0x003FFE14 File Offset: 0x003FE014
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0600F04D RID: 61517 RVA: 0x003FFE24 File Offset: 0x003FE024
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0600F04E RID: 61518 RVA: 0x003FFE34 File Offset: 0x003FE034
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0600F04F RID: 61519 RVA: 0x003FFE44 File Offset: 0x003FE044
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0600F050 RID: 61520 RVA: 0x003FFE54 File Offset: 0x003FE054
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0600F051 RID: 61521 RVA: 0x003FFE64 File Offset: 0x003FE064
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0600F052 RID: 61522 RVA: 0x003FFE74 File Offset: 0x003FE074
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x0600F053 RID: 61523 RVA: 0x003FFE84 File Offset: 0x003FE084
			public void __callDele_OnEventSelect(BeforeJoinSingleGuildUIController obj)
			{
				this.m_owner.__callDele_OnEventSelect(obj);
			}

			// Token: 0x0600F054 RID: 61524 RVA: 0x003FFE94 File Offset: 0x003FE094
			public void __clearDele_OnEventSelect(BeforeJoinSingleGuildUIController obj)
			{
				this.m_owner.__clearDele_OnEventSelect(obj);
			}

			// Token: 0x17002E3A RID: 11834
			// (get) Token: 0x0600F055 RID: 61525 RVA: 0x003FFEA4 File Offset: 0x003FE0A4
			// (set) Token: 0x0600F056 RID: 61526 RVA: 0x003FFEB4 File Offset: 0x003FE0B4
			public Button m_guildButton
			{
				get
				{
					return this.m_owner.m_guildButton;
				}
				set
				{
					this.m_owner.m_guildButton = value;
				}
			}

			// Token: 0x17002E3B RID: 11835
			// (get) Token: 0x0600F057 RID: 61527 RVA: 0x003FFEC4 File Offset: 0x003FE0C4
			// (set) Token: 0x0600F058 RID: 61528 RVA: 0x003FFED4 File Offset: 0x003FE0D4
			public Image m_guildCreateButton
			{
				get
				{
					return this.m_owner.m_guildCreateButton;
				}
				set
				{
					this.m_owner.m_guildCreateButton = value;
				}
			}

			// Token: 0x17002E3C RID: 11836
			// (get) Token: 0x0600F059 RID: 61529 RVA: 0x003FFEE4 File Offset: 0x003FE0E4
			// (set) Token: 0x0600F05A RID: 61530 RVA: 0x003FFEF4 File Offset: 0x003FE0F4
			public Text m_sociatyNameText
			{
				get
				{
					return this.m_owner.m_sociatyNameText;
				}
				set
				{
					this.m_owner.m_sociatyNameText = value;
				}
			}

			// Token: 0x17002E3D RID: 11837
			// (get) Token: 0x0600F05B RID: 61531 RVA: 0x003FFF04 File Offset: 0x003FE104
			// (set) Token: 0x0600F05C RID: 61532 RVA: 0x003FFF14 File Offset: 0x003FE114
			public Text m_peopleValueText
			{
				get
				{
					return this.m_owner.m_peopleValueText;
				}
				set
				{
					this.m_owner.m_peopleValueText = value;
				}
			}

			// Token: 0x17002E3E RID: 11838
			// (get) Token: 0x0600F05D RID: 61533 RVA: 0x003FFF24 File Offset: 0x003FE124
			// (set) Token: 0x0600F05E RID: 61534 RVA: 0x003FFF34 File Offset: 0x003FE134
			public Text m_LevelRequireText
			{
				get
				{
					return this.m_owner.m_LevelRequireText;
				}
				set
				{
					this.m_owner.m_LevelRequireText = value;
				}
			}

			// Token: 0x17002E3F RID: 11839
			// (get) Token: 0x0600F05F RID: 61535 RVA: 0x003FFF44 File Offset: 0x003FE144
			// (set) Token: 0x0600F060 RID: 61536 RVA: 0x003FFF54 File Offset: 0x003FE154
			public Text m_vitalityText
			{
				get
				{
					return this.m_owner.m_vitalityText;
				}
				set
				{
					this.m_owner.m_vitalityText = value;
				}
			}

			// Token: 0x17002E40 RID: 11840
			// (get) Token: 0x0600F061 RID: 61537 RVA: 0x003FFF64 File Offset: 0x003FE164
			// (set) Token: 0x0600F062 RID: 61538 RVA: 0x003FFF74 File Offset: 0x003FE174
			public GameObject m_applyGameObject
			{
				get
				{
					return this.m_owner.m_applyGameObject;
				}
				set
				{
					this.m_owner.m_applyGameObject = value;
				}
			}

			// Token: 0x17002E41 RID: 11841
			// (get) Token: 0x0600F063 RID: 61539 RVA: 0x003FFF84 File Offset: 0x003FE184
			// (set) Token: 0x0600F064 RID: 61540 RVA: 0x003FFF94 File Offset: 0x003FE194
			public Action<BeforeJoinSingleGuildUIController> OnEventSelect
			{
				get
				{
					return this.m_owner.OnEventSelect;
				}
				set
				{
					this.m_owner.OnEventSelect = value;
				}
			}

			// Token: 0x17002E42 RID: 11842
			// (get) Token: 0x0600F065 RID: 61541 RVA: 0x003FFFA4 File Offset: 0x003FE1A4
			// (set) Token: 0x0600F066 RID: 61542 RVA: 0x003FFFB4 File Offset: 0x003FE1B4
			public ProjectLPlayerContext m_playerContext
			{
				get
				{
					return this.m_owner.m_playerContext;
				}
				set
				{
					this.m_owner.m_playerContext = value;
				}
			}

			// Token: 0x17002E43 RID: 11843
			// (get) Token: 0x0600F067 RID: 61543 RVA: 0x003FFFC4 File Offset: 0x003FE1C4
			// (set) Token: 0x0600F068 RID: 61544 RVA: 0x003FFFD4 File Offset: 0x003FE1D4
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

			// Token: 0x0600F069 RID: 61545 RVA: 0x003FFFE4 File Offset: 0x003FE1E4
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0600F06A RID: 61546 RVA: 0x003FFFF4 File Offset: 0x003FE1F4
			public void OnItemClick()
			{
				this.m_owner.OnItemClick();
			}

			// Token: 0x04008F13 RID: 36627
			private BeforeJoinSingleGuildUIController m_owner;
		}
	}
}
