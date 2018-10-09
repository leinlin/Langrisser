using System;
using System.Collections.Generic;
using System.Threading;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Misc;
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000FF5 RID: 4085
	[HotFix]
	public class UnchartedScoreLevelListItemUIController : UIControllerBase
	{
		// Token: 0x0601486B RID: 84075 RVA: 0x00535E94 File Offset: 0x00534094
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
			this.m_startButton1.onClick.AddListener(new UnityAction(this.OnStartButtonClick));
			this.m_startButton2.onClick.AddListener(new UnityAction(this.OnStartButtonClick));
			this.m_lockedButton.onClick.AddListener(new UnityAction(this.OnLockedButtonClick));
		}

		// Token: 0x0601486C RID: 84076 RVA: 0x00535F50 File Offset: 0x00534150
		public void SetUnchartedScoreLevelInfo(ConfigDataScoreLevelInfo levelInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetUnchartedScoreLevelInfoConfigDataScoreLevelInfo_hotfix != null)
			{
				this.m_SetUnchartedScoreLevelInfoConfigDataScoreLevelInfo_hotfix.call(new object[]
				{
					this,
					levelInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_unchartedChallengeLevelInfo = null;
			this.m_unchartedScoreLevelInfo = levelInfo;
			this.m_uiStateController.SetToUIState("Score", false, true);
			GameObjectUtility.DestroyChildren(this.m_rewardGroupTransform.gameObject);
			Goods goods = new Goods();
			goods.GoodsType = GoodsType.GoodsType_Item;
			goods.Id = levelInfo.UnchartedScoreInfo.ScoreItemId;
			goods.Count = levelInfo.ScoreBase;
			GameObject assetInContainer = base.GetAssetInContainer<GameObject>("RewardGoods");
			RewardGoodsUIController.CreateRewardGoods(goods, this.m_rewardGroupTransform, assetInContainer, true, 0);
			List<Goods> list = new List<Goods>();
			UIUtility.AppendRandomDropRewardGoodsToList(levelInfo.DropID, list);
			this.SetLevelInfo(levelInfo.Name, levelInfo.MonsterLevel, levelInfo.EnergySuccess, list, levelInfo.ItemDropCountDisplay, false);
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			this.m_levelNameText.text = configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_UnchartedScore_MonsterLevel);
			this.m_lockedText.text = string.Format(configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Msg_AchieveLevelOpen), levelInfo.PlayerLevelMin);
		}

		// Token: 0x0601486D RID: 84077 RVA: 0x005360B4 File Offset: 0x005342B4
		public void SetUnchartedChallengeLevelInfo(ConfigDataChallengeLevelInfo levelInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetUnchartedChallengeLevelInfoConfigDataChallengeLevelInfo_hotfix != null)
			{
				this.m_SetUnchartedChallengeLevelInfoConfigDataChallengeLevelInfo_hotfix.call(new object[]
				{
					this,
					levelInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_unchartedScoreLevelInfo = null;
			this.m_unchartedChallengeLevelInfo = levelInfo;
			this.m_uiStateController.SetToUIState("Challenge", false, true);
			GameObjectUtility.DestroyChildren(this.m_rewardGroupTransform.gameObject);
			List<Goods> rewardList = new List<Goods>(levelInfo.CommonRewardList);
			this.SetLevelInfo(levelInfo.Name, levelInfo.MonsterLevel, levelInfo.EnergySuccess, rewardList, levelInfo.ItemDropCountDisplay, true);
			this.m_levelNameText.text = levelInfo.Name;
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			this.m_lockedText.text = configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_UnchartedScore_NeedCompletePrevLevel);
		}

		// Token: 0x0601486E RID: 84078 RVA: 0x005361B8 File Offset: 0x005343B8
		private void SetLevelInfo(string name, int monsterLevel, int energy, List<Goods> rewardList, int rewardDisplayCount, bool showRewardGoodCount)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetLevelInfoStringInt32Int32List`1Int32Boolean_hotfix != null)
			{
				this.m_SetLevelInfoStringInt32Int32List`1Int32Boolean_hotfix.call(new object[]
				{
					this,
					name,
					monsterLevel,
					energy,
					rewardList,
					rewardDisplayCount,
					showRewardGoodCount
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_levelText.text = monsterLevel.ToString();
			this.m_energyText.text = energy.ToString();
			if (rewardList.Count > rewardDisplayCount)
			{
				rewardList.RemoveRange(rewardDisplayCount, rewardList.Count - rewardDisplayCount);
			}
			GameObject assetInContainer = base.GetAssetInContainer<GameObject>("RewardGoods");
			RewardGoodsUIController.CreateRewardGoodsList(rewardList, this.m_rewardGroupTransform, assetInContainer, null, showRewardGoodCount, 0, true);
		}

		// Token: 0x0601486F RID: 84079 RVA: 0x005362E8 File Offset: 0x005344E8
		public ConfigDataScoreLevelInfo GetUnchartedScoreLevelInfo()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetUnchartedScoreLevelInfo_hotfix != null)
			{
				return (ConfigDataScoreLevelInfo)this.m_GetUnchartedScoreLevelInfo_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_unchartedScoreLevelInfo;
		}

		// Token: 0x06014870 RID: 84080 RVA: 0x0053635C File Offset: 0x0053455C
		public ConfigDataChallengeLevelInfo GetUnchartedChallengeLevelInfo()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetUnchartedChallengeLevelInfo_hotfix != null)
			{
				return (ConfigDataChallengeLevelInfo)this.m_GetUnchartedChallengeLevelInfo_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_unchartedChallengeLevelInfo;
		}

		// Token: 0x06014871 RID: 84081 RVA: 0x005363D0 File Offset: 0x005345D0
		public void SetLocked(bool locked)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetLockedBoolean_hotfix != null)
			{
				this.m_SetLockedBoolean_hotfix.call(new object[]
				{
					this,
					locked
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_lockedButton.gameObject.SetActive(locked);
		}

		// Token: 0x06014872 RID: 84082 RVA: 0x00536454 File Offset: 0x00534654
		public void SetOpenDayLocked(int day)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetOpenDayLockedInt32_hotfix != null)
			{
				this.m_SetOpenDayLockedInt32_hotfix.call(new object[]
				{
					this,
					day
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.SetLocked(true);
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			this.m_lockedText.text = string.Format(configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_UnchartedScore_LevelOpenDay), day);
		}

		// Token: 0x06014873 RID: 84083 RVA: 0x005364FC File Offset: 0x005346FC
		public void SetCompleted()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetCompleted_hotfix != null)
			{
				this.m_SetCompleted_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.SetLocked(false);
			this.m_uiStateController.SetToUIState("ChallengeGray", false, true);
		}

		// Token: 0x06014874 RID: 84084 RVA: 0x00536578 File Offset: 0x00534778
		private void OnStartButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnStartButtonClick_hotfix != null)
			{
				this.m_OnStartButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnStartButtonClick != null)
			{
				this.EventOnStartButtonClick(this);
			}
		}

		// Token: 0x06014875 RID: 84085 RVA: 0x005365F0 File Offset: 0x005347F0
		private void OnLockedButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnLockedButtonClick_hotfix != null)
			{
				this.m_OnLockedButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIController.Instance.ShowMessage(this.m_lockedText.text, 2f, null, true);
		}

		// Token: 0x14000487 RID: 1159
		// (add) Token: 0x06014876 RID: 84086 RVA: 0x0053666C File Offset: 0x0053486C
		// (remove) Token: 0x06014877 RID: 84087 RVA: 0x00536708 File Offset: 0x00534908
		public event Action<UnchartedScoreLevelListItemUIController> EventOnStartButtonClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnStartButtonClickAction`1_hotfix != null)
				{
					this.m_add_EventOnStartButtonClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<UnchartedScoreLevelListItemUIController> action = this.EventOnStartButtonClick;
				Action<UnchartedScoreLevelListItemUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<UnchartedScoreLevelListItemUIController>>(ref this.EventOnStartButtonClick, (Action<UnchartedScoreLevelListItemUIController>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnStartButtonClickAction`1_hotfix != null)
				{
					this.m_remove_EventOnStartButtonClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<UnchartedScoreLevelListItemUIController> action = this.EventOnStartButtonClick;
				Action<UnchartedScoreLevelListItemUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<UnchartedScoreLevelListItemUIController>>(ref this.EventOnStartButtonClick, (Action<UnchartedScoreLevelListItemUIController>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17003CD3 RID: 15571
		// (get) Token: 0x06014878 RID: 84088 RVA: 0x005367A4 File Offset: 0x005349A4
		// (set) Token: 0x06014879 RID: 84089 RVA: 0x005367C4 File Offset: 0x005349C4
		[DoNotToLua]
		public new UnchartedScoreLevelListItemUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new UnchartedScoreLevelListItemUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0601487A RID: 84090 RVA: 0x005367D0 File Offset: 0x005349D0
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0601487B RID: 84091 RVA: 0x005367DC File Offset: 0x005349DC
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0601487C RID: 84092 RVA: 0x005367E4 File Offset: 0x005349E4
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0601487D RID: 84093 RVA: 0x005367EC File Offset: 0x005349EC
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0601487E RID: 84094 RVA: 0x00536800 File Offset: 0x00534A00
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0601487F RID: 84095 RVA: 0x00536808 File Offset: 0x00534A08
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x06014880 RID: 84096 RVA: 0x00536814 File Offset: 0x00534A14
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x06014881 RID: 84097 RVA: 0x00536820 File Offset: 0x00534A20
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x06014882 RID: 84098 RVA: 0x0053682C File Offset: 0x00534A2C
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x06014883 RID: 84099 RVA: 0x00536838 File Offset: 0x00534A38
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x06014884 RID: 84100 RVA: 0x00536844 File Offset: 0x00534A44
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x06014885 RID: 84101 RVA: 0x00536850 File Offset: 0x00534A50
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x06014886 RID: 84102 RVA: 0x0053685C File Offset: 0x00534A5C
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x06014887 RID: 84103 RVA: 0x00536868 File Offset: 0x00534A68
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x06014888 RID: 84104 RVA: 0x00536874 File Offset: 0x00534A74
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x06014889 RID: 84105 RVA: 0x0053687C File Offset: 0x00534A7C
		private void __callDele_EventOnStartButtonClick(UnchartedScoreLevelListItemUIController obj)
		{
			Action<UnchartedScoreLevelListItemUIController> eventOnStartButtonClick = this.EventOnStartButtonClick;
			if (eventOnStartButtonClick != null)
			{
				eventOnStartButtonClick(obj);
			}
		}

		// Token: 0x0601488A RID: 84106 RVA: 0x005368A0 File Offset: 0x00534AA0
		private void __clearDele_EventOnStartButtonClick(UnchartedScoreLevelListItemUIController obj)
		{
			this.EventOnStartButtonClick = null;
		}

		// Token: 0x0601488B RID: 84107 RVA: 0x005368AC File Offset: 0x00534AAC
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
					this.m_SetUnchartedScoreLevelInfoConfigDataScoreLevelInfo_hotfix = (luaObj.RawGet("SetUnchartedScoreLevelInfo") as LuaFunction);
					this.m_SetUnchartedChallengeLevelInfoConfigDataChallengeLevelInfo_hotfix = (luaObj.RawGet("SetUnchartedChallengeLevelInfo") as LuaFunction);
					this.m_SetLevelInfoStringInt32Int32List`1Int32Boolean_hotfix = (luaObj.RawGet("SetLevelInfo") as LuaFunction);
					this.m_GetUnchartedScoreLevelInfo_hotfix = (luaObj.RawGet("GetUnchartedScoreLevelInfo") as LuaFunction);
					this.m_GetUnchartedChallengeLevelInfo_hotfix = (luaObj.RawGet("GetUnchartedChallengeLevelInfo") as LuaFunction);
					this.m_SetLockedBoolean_hotfix = (luaObj.RawGet("SetLocked") as LuaFunction);
					this.m_SetOpenDayLockedInt32_hotfix = (luaObj.RawGet("SetOpenDayLocked") as LuaFunction);
					this.m_SetCompleted_hotfix = (luaObj.RawGet("SetCompleted") as LuaFunction);
					this.m_OnStartButtonClick_hotfix = (luaObj.RawGet("OnStartButtonClick") as LuaFunction);
					this.m_OnLockedButtonClick_hotfix = (luaObj.RawGet("OnLockedButtonClick") as LuaFunction);
					this.m_add_EventOnStartButtonClickAction`1_hotfix = (luaObj.RawGet("add_EventOnStartButtonClick") as LuaFunction);
					this.m_remove_EventOnStartButtonClickAction`1_hotfix = (luaObj.RawGet("remove_EventOnStartButtonClick") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0601488C RID: 84108 RVA: 0x00536AA4 File Offset: 0x00534CA4
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(UnchartedScoreLevelListItemUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400B493 RID: 46227
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_uiStateController;

		// Token: 0x0400B494 RID: 46228
		[AutoBind("./Level/TitleText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_levelNameText;

		// Token: 0x0400B495 RID: 46229
		[AutoBind("./Level/TitleText/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_levelText;

		// Token: 0x0400B496 RID: 46230
		[AutoBind("./EnergyValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_energyText;

		// Token: 0x0400B497 RID: 46231
		[AutoBind("./Locked", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_lockedButton;

		// Token: 0x0400B498 RID: 46232
		[AutoBind("./Locked/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_lockedText;

		// Token: 0x0400B499 RID: 46233
		[AutoBind("./StartButton1", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_startButton1;

		// Token: 0x0400B49A RID: 46234
		[AutoBind("./StartButton2", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_startButton2;

		// Token: 0x0400B49B RID: 46235
		[AutoBind("./RewardGroup", AutoBindAttribute.InitState.NotInit, false)]
		private Transform m_rewardGroupTransform;

		// Token: 0x0400B49C RID: 46236
		private ConfigDataScoreLevelInfo m_unchartedScoreLevelInfo;

		// Token: 0x0400B49D RID: 46237
		private ConfigDataChallengeLevelInfo m_unchartedChallengeLevelInfo;

		// Token: 0x0400B49E RID: 46238
		[DoNotToLua]
		private UnchartedScoreLevelListItemUIController.LuaExportHelper luaExportHelper;

		// Token: 0x0400B49F RID: 46239
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400B4A0 RID: 46240
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400B4A1 RID: 46241
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x0400B4A2 RID: 46242
		private LuaFunction m_SetUnchartedScoreLevelInfoConfigDataScoreLevelInfo_hotfix;

		// Token: 0x0400B4A3 RID: 46243
		private LuaFunction m_SetUnchartedChallengeLevelInfoConfigDataChallengeLevelInfo_hotfix;

		// Token: 0x0400B4A4 RID: 46244
		private LuaFunction m_SetLevelInfoStringInt32Int32List;

		// Token: 0x0400B4A5 RID: 46245
		private LuaFunction m_GetUnchartedScoreLevelInfo_hotfix;

		// Token: 0x0400B4A6 RID: 46246
		private LuaFunction m_GetUnchartedChallengeLevelInfo_hotfix;

		// Token: 0x0400B4A7 RID: 46247
		private LuaFunction m_SetLockedBoolean_hotfix;

		// Token: 0x0400B4A8 RID: 46248
		private LuaFunction m_SetOpenDayLockedInt32_hotfix;

		// Token: 0x0400B4A9 RID: 46249
		private LuaFunction m_SetCompleted_hotfix;

		// Token: 0x0400B4AA RID: 46250
		private LuaFunction m_OnStartButtonClick_hotfix;

		// Token: 0x0400B4AB RID: 46251
		private LuaFunction m_OnLockedButtonClick_hotfix;

		// Token: 0x0400B4AC RID: 46252
		private LuaFunction m_add_EventOnStartButtonClickAction;

		// Token: 0x0400B4AD RID: 46253
		private LuaFunction m_remove_EventOnStartButtonClickAction;

		// Token: 0x02000FF6 RID: 4086
		public new class LuaExportHelper
		{
			// Token: 0x0601488D RID: 84109 RVA: 0x00536B0C File Offset: 0x00534D0C
			public LuaExportHelper(UnchartedScoreLevelListItemUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0601488E RID: 84110 RVA: 0x00536B1C File Offset: 0x00534D1C
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0601488F RID: 84111 RVA: 0x00536B2C File Offset: 0x00534D2C
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x06014890 RID: 84112 RVA: 0x00536B3C File Offset: 0x00534D3C
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x06014891 RID: 84113 RVA: 0x00536B4C File Offset: 0x00534D4C
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x06014892 RID: 84114 RVA: 0x00536B64 File Offset: 0x00534D64
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x06014893 RID: 84115 RVA: 0x00536B74 File Offset: 0x00534D74
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x06014894 RID: 84116 RVA: 0x00536B84 File Offset: 0x00534D84
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x06014895 RID: 84117 RVA: 0x00536B94 File Offset: 0x00534D94
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x06014896 RID: 84118 RVA: 0x00536BA4 File Offset: 0x00534DA4
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x06014897 RID: 84119 RVA: 0x00536BB4 File Offset: 0x00534DB4
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x06014898 RID: 84120 RVA: 0x00536BC4 File Offset: 0x00534DC4
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x06014899 RID: 84121 RVA: 0x00536BD4 File Offset: 0x00534DD4
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0601489A RID: 84122 RVA: 0x00536BE4 File Offset: 0x00534DE4
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0601489B RID: 84123 RVA: 0x00536BF4 File Offset: 0x00534DF4
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0601489C RID: 84124 RVA: 0x00536C04 File Offset: 0x00534E04
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x0601489D RID: 84125 RVA: 0x00536C14 File Offset: 0x00534E14
			public void __callDele_EventOnStartButtonClick(UnchartedScoreLevelListItemUIController obj)
			{
				this.m_owner.__callDele_EventOnStartButtonClick(obj);
			}

			// Token: 0x0601489E RID: 84126 RVA: 0x00536C24 File Offset: 0x00534E24
			public void __clearDele_EventOnStartButtonClick(UnchartedScoreLevelListItemUIController obj)
			{
				this.m_owner.__clearDele_EventOnStartButtonClick(obj);
			}

			// Token: 0x17003CD4 RID: 15572
			// (get) Token: 0x0601489F RID: 84127 RVA: 0x00536C34 File Offset: 0x00534E34
			// (set) Token: 0x060148A0 RID: 84128 RVA: 0x00536C44 File Offset: 0x00534E44
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

			// Token: 0x17003CD5 RID: 15573
			// (get) Token: 0x060148A1 RID: 84129 RVA: 0x00536C54 File Offset: 0x00534E54
			// (set) Token: 0x060148A2 RID: 84130 RVA: 0x00536C64 File Offset: 0x00534E64
			public Text m_levelNameText
			{
				get
				{
					return this.m_owner.m_levelNameText;
				}
				set
				{
					this.m_owner.m_levelNameText = value;
				}
			}

			// Token: 0x17003CD6 RID: 15574
			// (get) Token: 0x060148A3 RID: 84131 RVA: 0x00536C74 File Offset: 0x00534E74
			// (set) Token: 0x060148A4 RID: 84132 RVA: 0x00536C84 File Offset: 0x00534E84
			public Text m_levelText
			{
				get
				{
					return this.m_owner.m_levelText;
				}
				set
				{
					this.m_owner.m_levelText = value;
				}
			}

			// Token: 0x17003CD7 RID: 15575
			// (get) Token: 0x060148A5 RID: 84133 RVA: 0x00536C94 File Offset: 0x00534E94
			// (set) Token: 0x060148A6 RID: 84134 RVA: 0x00536CA4 File Offset: 0x00534EA4
			public Text m_energyText
			{
				get
				{
					return this.m_owner.m_energyText;
				}
				set
				{
					this.m_owner.m_energyText = value;
				}
			}

			// Token: 0x17003CD8 RID: 15576
			// (get) Token: 0x060148A7 RID: 84135 RVA: 0x00536CB4 File Offset: 0x00534EB4
			// (set) Token: 0x060148A8 RID: 84136 RVA: 0x00536CC4 File Offset: 0x00534EC4
			public Button m_lockedButton
			{
				get
				{
					return this.m_owner.m_lockedButton;
				}
				set
				{
					this.m_owner.m_lockedButton = value;
				}
			}

			// Token: 0x17003CD9 RID: 15577
			// (get) Token: 0x060148A9 RID: 84137 RVA: 0x00536CD4 File Offset: 0x00534ED4
			// (set) Token: 0x060148AA RID: 84138 RVA: 0x00536CE4 File Offset: 0x00534EE4
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

			// Token: 0x17003CDA RID: 15578
			// (get) Token: 0x060148AB RID: 84139 RVA: 0x00536CF4 File Offset: 0x00534EF4
			// (set) Token: 0x060148AC RID: 84140 RVA: 0x00536D04 File Offset: 0x00534F04
			public Button m_startButton1
			{
				get
				{
					return this.m_owner.m_startButton1;
				}
				set
				{
					this.m_owner.m_startButton1 = value;
				}
			}

			// Token: 0x17003CDB RID: 15579
			// (get) Token: 0x060148AD RID: 84141 RVA: 0x00536D14 File Offset: 0x00534F14
			// (set) Token: 0x060148AE RID: 84142 RVA: 0x00536D24 File Offset: 0x00534F24
			public Button m_startButton2
			{
				get
				{
					return this.m_owner.m_startButton2;
				}
				set
				{
					this.m_owner.m_startButton2 = value;
				}
			}

			// Token: 0x17003CDC RID: 15580
			// (get) Token: 0x060148AF RID: 84143 RVA: 0x00536D34 File Offset: 0x00534F34
			// (set) Token: 0x060148B0 RID: 84144 RVA: 0x00536D44 File Offset: 0x00534F44
			public Transform m_rewardGroupTransform
			{
				get
				{
					return this.m_owner.m_rewardGroupTransform;
				}
				set
				{
					this.m_owner.m_rewardGroupTransform = value;
				}
			}

			// Token: 0x17003CDD RID: 15581
			// (get) Token: 0x060148B1 RID: 84145 RVA: 0x00536D54 File Offset: 0x00534F54
			// (set) Token: 0x060148B2 RID: 84146 RVA: 0x00536D64 File Offset: 0x00534F64
			public ConfigDataScoreLevelInfo m_unchartedScoreLevelInfo
			{
				get
				{
					return this.m_owner.m_unchartedScoreLevelInfo;
				}
				set
				{
					this.m_owner.m_unchartedScoreLevelInfo = value;
				}
			}

			// Token: 0x17003CDE RID: 15582
			// (get) Token: 0x060148B3 RID: 84147 RVA: 0x00536D74 File Offset: 0x00534F74
			// (set) Token: 0x060148B4 RID: 84148 RVA: 0x00536D84 File Offset: 0x00534F84
			public ConfigDataChallengeLevelInfo m_unchartedChallengeLevelInfo
			{
				get
				{
					return this.m_owner.m_unchartedChallengeLevelInfo;
				}
				set
				{
					this.m_owner.m_unchartedChallengeLevelInfo = value;
				}
			}

			// Token: 0x060148B5 RID: 84149 RVA: 0x00536D94 File Offset: 0x00534F94
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x060148B6 RID: 84150 RVA: 0x00536DA4 File Offset: 0x00534FA4
			public void SetLevelInfo(string name, int monsterLevel, int energy, List<Goods> rewardList, int rewardDisplayCount, bool showRewardGoodCount)
			{
				this.m_owner.SetLevelInfo(name, monsterLevel, energy, rewardList, rewardDisplayCount, showRewardGoodCount);
			}

			// Token: 0x060148B7 RID: 84151 RVA: 0x00536DBC File Offset: 0x00534FBC
			public void OnStartButtonClick()
			{
				this.m_owner.OnStartButtonClick();
			}

			// Token: 0x060148B8 RID: 84152 RVA: 0x00536DCC File Offset: 0x00534FCC
			public void OnLockedButtonClick()
			{
				this.m_owner.OnLockedButtonClick();
			}

			// Token: 0x0400B4AE RID: 46254
			private UnchartedScoreLevelListItemUIController m_owner;
		}
	}
}
