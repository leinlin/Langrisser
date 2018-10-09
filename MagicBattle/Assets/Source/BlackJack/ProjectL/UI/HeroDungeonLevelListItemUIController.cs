using System;
using System.Threading;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Misc;
using BlackJack.ProjectL.PlayerContext;
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000E18 RID: 3608
	[HotFix]
	public class HeroDungeonLevelListItemUIController : UIControllerBase
	{
		// Token: 0x0601159B RID: 71067 RVA: 0x00480034 File Offset: 0x0047E234
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

		// Token: 0x0601159C RID: 71068 RVA: 0x004800B8 File Offset: 0x0047E2B8
		public void SetDungeonInfo(ConfigDataHeroDungeonLevelInfo levelInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetDungeonInfoConfigDataHeroDungeonLevelInfo_hotfix != null)
			{
				this.m_SetDungeonInfoConfigDataHeroDungeonLevelInfo_hotfix.call(new object[]
				{
					this,
					levelInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (levelInfo == null)
			{
				return;
			}
			bool flag = this.m_playerContext.IsLevelChallenged(levelInfo.ID);
			this.m_levelInfo = levelInfo;
			int num = this.m_playerContext.CanUnLockHeroDungeonLevel(levelInfo.ID);
			if (num == 0)
			{
				int heroDungeonLevelStars = this.m_playerContext.GetHeroDungeonLevelStars(levelInfo);
				int heroDungeonLevelAchievementCount = this.m_playerContext.GetHeroDungeonLevelAchievementCount(levelInfo);
				this.m_nameText.text = levelInfo.Name;
				this.m_trophyValueText.text = string.Concat(new object[]
				{
					"<color=yellow>",
					heroDungeonLevelAchievementCount.ToString(),
					"</color>/",
					levelInfo.m_achievements.Length
				});
				this.m_trophyGameObject.SetActive(levelInfo.m_achievements.Length > 0);
				this.m_star1GameObject.SetActive(heroDungeonLevelStars >= 1);
				this.m_star2GameObject.SetActive(heroDungeonLevelStars >= 2);
				this.m_star3GameObject.SetActive(heroDungeonLevelStars >= 3);
				if (flag)
				{
					if (heroDungeonLevelStars >= 3 && heroDungeonLevelAchievementCount >= levelInfo.m_achievements.Length)
					{
						this.m_uiStateController.SetToUIState("Perfect", false, true);
					}
					else if (this.m_playerContext.GetHeroDungeonLevelStars(levelInfo) >= 1)
					{
						this.m_uiStateController.SetToUIState("Clear", false, true);
					}
					else
					{
						this.m_uiStateController.SetToUIState("Normal", false, true);
					}
				}
				else
				{
					this.m_uiStateController.SetToUIState("New", false, true);
				}
				bool flag2 = levelInfo.HeroFragment_ID != 0;
				if (flag2)
				{
					this.m_pieceImage.sprite = AssetUtility.Instance.GetSprite(UIUtility.GetGoodsIconName(GoodsType.GoodsType_Item, levelInfo.HeroFragment_ID));
					this.m_pieceImage.material = AssetUtility.Instance.GetAsset<Material>(UIUtility.GetGoodsIconMaterialName(GoodsType.GoodsType_Item, levelInfo.HeroFragment_ID));
				}
				this.m_pieceImage.gameObject.SetActive(flag2);
				int heroDungeonLevelCanChallengeNum = this.m_playerContext.GetHeroDungeonLevelCanChallengeNum(levelInfo);
				this.m_lastCountValueText.text = heroDungeonLevelCanChallengeNum.ToString();
				this.m_pieceImage.color = ((heroDungeonLevelCanChallengeNum == 0) ? Color.grey : Color.white);
			}
			else if (num == -2901)
			{
				this.m_preLevelNotCompleteText.text = string.Format(this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Msg_PreLevelCompleteOpen), new object[0]);
				this.m_uiStateController.SetToUIState("PreLevelLock", false, true);
			}
			else if (num == -2903)
			{
				this.m_favorLevelNotEnoughText.text = string.Format(this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_UnlockCondition_HeroDungeonLevel), levelInfo.UnlockConditions[0].Param2);
				this.m_uiStateController.SetToUIState("FavorLevelLock", false, true);
			}
		}

		// Token: 0x0601159D RID: 71069 RVA: 0x004803F4 File Offset: 0x0047E5F4
		public ConfigDataHeroDungeonLevelInfo GetDungeonInfo()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetDungeonInfo_hotfix != null)
			{
				return (ConfigDataHeroDungeonLevelInfo)this.m_GetDungeonInfo_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_levelInfo;
		}

		// Token: 0x0601159E RID: 71070 RVA: 0x00480468 File Offset: 0x0047E668
		public void SetIndex(int index)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetIndexInt32_hotfix != null)
			{
				this.m_SetIndexInt32_hotfix.call(new object[]
				{
					this,
					index
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_index = index;
		}

		// Token: 0x0601159F RID: 71071 RVA: 0x004804E0 File Offset: 0x0047E6E0
		public int GetIndex()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetIndex_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetIndex_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_index;
		}

		// Token: 0x060115A0 RID: 71072 RVA: 0x00480554 File Offset: 0x0047E754
		public bool IsFavorLevelLock()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsFavorLevelLock_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsFavorLevelLock_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_uiStateController.GetCurrentUIState().StateName == "FavorLevelLock";
		}

		// Token: 0x060115A1 RID: 71073 RVA: 0x004805DC File Offset: 0x0047E7DC
		public bool IsPreLevelLock()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsPreLevelLock_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsPreLevelLock_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_uiStateController.GetCurrentUIState().StateName == "PreLevelLock";
		}

		// Token: 0x060115A2 RID: 71074 RVA: 0x00480664 File Offset: 0x0047E864
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

		// Token: 0x140003BC RID: 956
		// (add) Token: 0x060115A3 RID: 71075 RVA: 0x004806DC File Offset: 0x0047E8DC
		// (remove) Token: 0x060115A4 RID: 71076 RVA: 0x00480778 File Offset: 0x0047E978
		public event Action<HeroDungeonLevelListItemUIController> EventOnClick
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
				Action<HeroDungeonLevelListItemUIController> action = this.EventOnClick;
				Action<HeroDungeonLevelListItemUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<HeroDungeonLevelListItemUIController>>(ref this.EventOnClick, (Action<HeroDungeonLevelListItemUIController>)Delegate.Combine(action2, value), action);
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
				Action<HeroDungeonLevelListItemUIController> action = this.EventOnClick;
				Action<HeroDungeonLevelListItemUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<HeroDungeonLevelListItemUIController>>(ref this.EventOnClick, (Action<HeroDungeonLevelListItemUIController>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17003575 RID: 13685
		// (get) Token: 0x060115A5 RID: 71077 RVA: 0x00480814 File Offset: 0x0047EA14
		// (set) Token: 0x060115A6 RID: 71078 RVA: 0x00480834 File Offset: 0x0047EA34
		[DoNotToLua]
		public new HeroDungeonLevelListItemUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new HeroDungeonLevelListItemUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x060115A7 RID: 71079 RVA: 0x00480840 File Offset: 0x0047EA40
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x060115A8 RID: 71080 RVA: 0x0048084C File Offset: 0x0047EA4C
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x060115A9 RID: 71081 RVA: 0x00480854 File Offset: 0x0047EA54
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x060115AA RID: 71082 RVA: 0x0048085C File Offset: 0x0047EA5C
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x060115AB RID: 71083 RVA: 0x00480870 File Offset: 0x0047EA70
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x060115AC RID: 71084 RVA: 0x00480878 File Offset: 0x0047EA78
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x060115AD RID: 71085 RVA: 0x00480884 File Offset: 0x0047EA84
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x060115AE RID: 71086 RVA: 0x00480890 File Offset: 0x0047EA90
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x060115AF RID: 71087 RVA: 0x0048089C File Offset: 0x0047EA9C
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x060115B0 RID: 71088 RVA: 0x004808A8 File Offset: 0x0047EAA8
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x060115B1 RID: 71089 RVA: 0x004808B4 File Offset: 0x0047EAB4
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x060115B2 RID: 71090 RVA: 0x004808C0 File Offset: 0x0047EAC0
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x060115B3 RID: 71091 RVA: 0x004808CC File Offset: 0x0047EACC
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x060115B4 RID: 71092 RVA: 0x004808D8 File Offset: 0x0047EAD8
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x060115B5 RID: 71093 RVA: 0x004808E4 File Offset: 0x0047EAE4
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x060115B6 RID: 71094 RVA: 0x004808EC File Offset: 0x0047EAEC
		private void __callDele_EventOnClick(HeroDungeonLevelListItemUIController obj)
		{
			Action<HeroDungeonLevelListItemUIController> eventOnClick = this.EventOnClick;
			if (eventOnClick != null)
			{
				eventOnClick(obj);
			}
		}

		// Token: 0x060115B7 RID: 71095 RVA: 0x00480910 File Offset: 0x0047EB10
		private void __clearDele_EventOnClick(HeroDungeonLevelListItemUIController obj)
		{
			this.EventOnClick = null;
		}

		// Token: 0x060115B8 RID: 71096 RVA: 0x0048091C File Offset: 0x0047EB1C
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
					this.m_SetDungeonInfoConfigDataHeroDungeonLevelInfo_hotfix = (luaObj.RawGet("SetDungeonInfo") as LuaFunction);
					this.m_GetDungeonInfo_hotfix = (luaObj.RawGet("GetDungeonInfo") as LuaFunction);
					this.m_SetIndexInt32_hotfix = (luaObj.RawGet("SetIndex") as LuaFunction);
					this.m_GetIndex_hotfix = (luaObj.RawGet("GetIndex") as LuaFunction);
					this.m_IsFavorLevelLock_hotfix = (luaObj.RawGet("IsFavorLevelLock") as LuaFunction);
					this.m_IsPreLevelLock_hotfix = (luaObj.RawGet("IsPreLevelLock") as LuaFunction);
					this.m_OnClick_hotfix = (luaObj.RawGet("OnClick") as LuaFunction);
					this.m_add_EventOnClickAction`1_hotfix = (luaObj.RawGet("add_EventOnClick") as LuaFunction);
					this.m_remove_EventOnClickAction`1_hotfix = (luaObj.RawGet("remove_EventOnClick") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x060115B9 RID: 71097 RVA: 0x00480AC8 File Offset: 0x0047ECC8
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(HeroDungeonLevelListItemUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04009EE4 RID: 40676
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_button;

		// Token: 0x04009EE5 RID: 40677
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_uiStateController;

		// Token: 0x04009EE6 RID: 40678
		[AutoBind("./Detail/NameText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_nameText;

		// Token: 0x04009EE7 RID: 40679
		[AutoBind("./Detail/StarImage1", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_star1GameObject;

		// Token: 0x04009EE8 RID: 40680
		[AutoBind("./Detail/StarImage2", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_star2GameObject;

		// Token: 0x04009EE9 RID: 40681
		[AutoBind("./Detail/StarImage3", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_star3GameObject;

		// Token: 0x04009EEA RID: 40682
		[AutoBind("./Detail/Trophy", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_trophyGameObject;

		// Token: 0x04009EEB RID: 40683
		[AutoBind("./Detail/Trophy/TrophyValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_trophyValueText;

		// Token: 0x04009EEC RID: 40684
		[AutoBind("./Lock/FavorLevelNotEnoughText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_favorLevelNotEnoughText;

		// Token: 0x04009EED RID: 40685
		[AutoBind("./Lock/PreLevelNotCompleteText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_preLevelNotCompleteText;

		// Token: 0x04009EEE RID: 40686
		[AutoBind("./Detail/PieceImage", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_pieceImage;

		// Token: 0x04009EEF RID: 40687
		[AutoBind("./Detail/CountDetail/CountValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_lastCountValueText;

		// Token: 0x04009EF0 RID: 40688
		private ConfigDataHeroDungeonLevelInfo m_levelInfo;

		// Token: 0x04009EF1 RID: 40689
		private int m_index;

		// Token: 0x04009EF2 RID: 40690
		private ProjectLPlayerContext m_playerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;

		// Token: 0x04009EF3 RID: 40691
		private IConfigDataLoader m_configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;

		// Token: 0x04009EF4 RID: 40692
		[DoNotToLua]
		private HeroDungeonLevelListItemUIController.LuaExportHelper luaExportHelper;

		// Token: 0x04009EF5 RID: 40693
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04009EF6 RID: 40694
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04009EF7 RID: 40695
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x04009EF8 RID: 40696
		private LuaFunction m_SetDungeonInfoConfigDataHeroDungeonLevelInfo_hotfix;

		// Token: 0x04009EF9 RID: 40697
		private LuaFunction m_GetDungeonInfo_hotfix;

		// Token: 0x04009EFA RID: 40698
		private LuaFunction m_SetIndexInt32_hotfix;

		// Token: 0x04009EFB RID: 40699
		private LuaFunction m_GetIndex_hotfix;

		// Token: 0x04009EFC RID: 40700
		private LuaFunction m_IsFavorLevelLock_hotfix;

		// Token: 0x04009EFD RID: 40701
		private LuaFunction m_IsPreLevelLock_hotfix;

		// Token: 0x04009EFE RID: 40702
		private LuaFunction m_OnClick_hotfix;

		// Token: 0x04009EFF RID: 40703
		private LuaFunction m_add_EventOnClickAction;

		// Token: 0x04009F00 RID: 40704
		private LuaFunction m_remove_EventOnClickAction;

		// Token: 0x02000E19 RID: 3609
		public new class LuaExportHelper
		{
			// Token: 0x060115BA RID: 71098 RVA: 0x00480B30 File Offset: 0x0047ED30
			public LuaExportHelper(HeroDungeonLevelListItemUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x060115BB RID: 71099 RVA: 0x00480B40 File Offset: 0x0047ED40
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x060115BC RID: 71100 RVA: 0x00480B50 File Offset: 0x0047ED50
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x060115BD RID: 71101 RVA: 0x00480B60 File Offset: 0x0047ED60
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x060115BE RID: 71102 RVA: 0x00480B70 File Offset: 0x0047ED70
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x060115BF RID: 71103 RVA: 0x00480B88 File Offset: 0x0047ED88
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x060115C0 RID: 71104 RVA: 0x00480B98 File Offset: 0x0047ED98
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x060115C1 RID: 71105 RVA: 0x00480BA8 File Offset: 0x0047EDA8
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x060115C2 RID: 71106 RVA: 0x00480BB8 File Offset: 0x0047EDB8
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x060115C3 RID: 71107 RVA: 0x00480BC8 File Offset: 0x0047EDC8
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x060115C4 RID: 71108 RVA: 0x00480BD8 File Offset: 0x0047EDD8
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x060115C5 RID: 71109 RVA: 0x00480BE8 File Offset: 0x0047EDE8
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x060115C6 RID: 71110 RVA: 0x00480BF8 File Offset: 0x0047EDF8
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x060115C7 RID: 71111 RVA: 0x00480C08 File Offset: 0x0047EE08
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x060115C8 RID: 71112 RVA: 0x00480C18 File Offset: 0x0047EE18
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x060115C9 RID: 71113 RVA: 0x00480C28 File Offset: 0x0047EE28
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x060115CA RID: 71114 RVA: 0x00480C38 File Offset: 0x0047EE38
			public void __callDele_EventOnClick(HeroDungeonLevelListItemUIController obj)
			{
				this.m_owner.__callDele_EventOnClick(obj);
			}

			// Token: 0x060115CB RID: 71115 RVA: 0x00480C48 File Offset: 0x0047EE48
			public void __clearDele_EventOnClick(HeroDungeonLevelListItemUIController obj)
			{
				this.m_owner.__clearDele_EventOnClick(obj);
			}

			// Token: 0x17003576 RID: 13686
			// (get) Token: 0x060115CC RID: 71116 RVA: 0x00480C58 File Offset: 0x0047EE58
			// (set) Token: 0x060115CD RID: 71117 RVA: 0x00480C68 File Offset: 0x0047EE68
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

			// Token: 0x17003577 RID: 13687
			// (get) Token: 0x060115CE RID: 71118 RVA: 0x00480C78 File Offset: 0x0047EE78
			// (set) Token: 0x060115CF RID: 71119 RVA: 0x00480C88 File Offset: 0x0047EE88
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

			// Token: 0x17003578 RID: 13688
			// (get) Token: 0x060115D0 RID: 71120 RVA: 0x00480C98 File Offset: 0x0047EE98
			// (set) Token: 0x060115D1 RID: 71121 RVA: 0x00480CA8 File Offset: 0x0047EEA8
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

			// Token: 0x17003579 RID: 13689
			// (get) Token: 0x060115D2 RID: 71122 RVA: 0x00480CB8 File Offset: 0x0047EEB8
			// (set) Token: 0x060115D3 RID: 71123 RVA: 0x00480CC8 File Offset: 0x0047EEC8
			public GameObject m_star1GameObject
			{
				get
				{
					return this.m_owner.m_star1GameObject;
				}
				set
				{
					this.m_owner.m_star1GameObject = value;
				}
			}

			// Token: 0x1700357A RID: 13690
			// (get) Token: 0x060115D4 RID: 71124 RVA: 0x00480CD8 File Offset: 0x0047EED8
			// (set) Token: 0x060115D5 RID: 71125 RVA: 0x00480CE8 File Offset: 0x0047EEE8
			public GameObject m_star2GameObject
			{
				get
				{
					return this.m_owner.m_star2GameObject;
				}
				set
				{
					this.m_owner.m_star2GameObject = value;
				}
			}

			// Token: 0x1700357B RID: 13691
			// (get) Token: 0x060115D6 RID: 71126 RVA: 0x00480CF8 File Offset: 0x0047EEF8
			// (set) Token: 0x060115D7 RID: 71127 RVA: 0x00480D08 File Offset: 0x0047EF08
			public GameObject m_star3GameObject
			{
				get
				{
					return this.m_owner.m_star3GameObject;
				}
				set
				{
					this.m_owner.m_star3GameObject = value;
				}
			}

			// Token: 0x1700357C RID: 13692
			// (get) Token: 0x060115D8 RID: 71128 RVA: 0x00480D18 File Offset: 0x0047EF18
			// (set) Token: 0x060115D9 RID: 71129 RVA: 0x00480D28 File Offset: 0x0047EF28
			public GameObject m_trophyGameObject
			{
				get
				{
					return this.m_owner.m_trophyGameObject;
				}
				set
				{
					this.m_owner.m_trophyGameObject = value;
				}
			}

			// Token: 0x1700357D RID: 13693
			// (get) Token: 0x060115DA RID: 71130 RVA: 0x00480D38 File Offset: 0x0047EF38
			// (set) Token: 0x060115DB RID: 71131 RVA: 0x00480D48 File Offset: 0x0047EF48
			public Text m_trophyValueText
			{
				get
				{
					return this.m_owner.m_trophyValueText;
				}
				set
				{
					this.m_owner.m_trophyValueText = value;
				}
			}

			// Token: 0x1700357E RID: 13694
			// (get) Token: 0x060115DC RID: 71132 RVA: 0x00480D58 File Offset: 0x0047EF58
			// (set) Token: 0x060115DD RID: 71133 RVA: 0x00480D68 File Offset: 0x0047EF68
			public Text m_favorLevelNotEnoughText
			{
				get
				{
					return this.m_owner.m_favorLevelNotEnoughText;
				}
				set
				{
					this.m_owner.m_favorLevelNotEnoughText = value;
				}
			}

			// Token: 0x1700357F RID: 13695
			// (get) Token: 0x060115DE RID: 71134 RVA: 0x00480D78 File Offset: 0x0047EF78
			// (set) Token: 0x060115DF RID: 71135 RVA: 0x00480D88 File Offset: 0x0047EF88
			public Text m_preLevelNotCompleteText
			{
				get
				{
					return this.m_owner.m_preLevelNotCompleteText;
				}
				set
				{
					this.m_owner.m_preLevelNotCompleteText = value;
				}
			}

			// Token: 0x17003580 RID: 13696
			// (get) Token: 0x060115E0 RID: 71136 RVA: 0x00480D98 File Offset: 0x0047EF98
			// (set) Token: 0x060115E1 RID: 71137 RVA: 0x00480DA8 File Offset: 0x0047EFA8
			public Image m_pieceImage
			{
				get
				{
					return this.m_owner.m_pieceImage;
				}
				set
				{
					this.m_owner.m_pieceImage = value;
				}
			}

			// Token: 0x17003581 RID: 13697
			// (get) Token: 0x060115E2 RID: 71138 RVA: 0x00480DB8 File Offset: 0x0047EFB8
			// (set) Token: 0x060115E3 RID: 71139 RVA: 0x00480DC8 File Offset: 0x0047EFC8
			public Text m_lastCountValueText
			{
				get
				{
					return this.m_owner.m_lastCountValueText;
				}
				set
				{
					this.m_owner.m_lastCountValueText = value;
				}
			}

			// Token: 0x17003582 RID: 13698
			// (get) Token: 0x060115E4 RID: 71140 RVA: 0x00480DD8 File Offset: 0x0047EFD8
			// (set) Token: 0x060115E5 RID: 71141 RVA: 0x00480DE8 File Offset: 0x0047EFE8
			public ConfigDataHeroDungeonLevelInfo m_levelInfo
			{
				get
				{
					return this.m_owner.m_levelInfo;
				}
				set
				{
					this.m_owner.m_levelInfo = value;
				}
			}

			// Token: 0x17003583 RID: 13699
			// (get) Token: 0x060115E6 RID: 71142 RVA: 0x00480DF8 File Offset: 0x0047EFF8
			// (set) Token: 0x060115E7 RID: 71143 RVA: 0x00480E08 File Offset: 0x0047F008
			public int m_index
			{
				get
				{
					return this.m_owner.m_index;
				}
				set
				{
					this.m_owner.m_index = value;
				}
			}

			// Token: 0x17003584 RID: 13700
			// (get) Token: 0x060115E8 RID: 71144 RVA: 0x00480E18 File Offset: 0x0047F018
			// (set) Token: 0x060115E9 RID: 71145 RVA: 0x00480E28 File Offset: 0x0047F028
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

			// Token: 0x17003585 RID: 13701
			// (get) Token: 0x060115EA RID: 71146 RVA: 0x00480E38 File Offset: 0x0047F038
			// (set) Token: 0x060115EB RID: 71147 RVA: 0x00480E48 File Offset: 0x0047F048
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

			// Token: 0x060115EC RID: 71148 RVA: 0x00480E58 File Offset: 0x0047F058
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x060115ED RID: 71149 RVA: 0x00480E68 File Offset: 0x0047F068
			public void OnClick()
			{
				this.m_owner.OnClick();
			}

			// Token: 0x04009F01 RID: 40705
			private HeroDungeonLevelListItemUIController m_owner;
		}
	}
}
