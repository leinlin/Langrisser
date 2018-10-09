using System;
using System.Collections.Generic;
using System.Threading;
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
	// Token: 0x02000B80 RID: 2944
	[HotFix]
	public class ClimbTowerLevelInfoUIController : UIControllerBase
	{
		// Token: 0x0600C86D RID: 51309 RVA: 0x00377BAC File Offset: 0x00375DAC
		private ClimbTowerLevelInfoUIController()
		{
		}

		// Token: 0x0600C86E RID: 51310 RVA: 0x00377BB4 File Offset: 0x00375DB4
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
			this.m_startButton.onClick.AddListener(new UnityAction(this.OnStartButtonClick));
			this.m_backgroundButton.onClick.AddListener(new UnityAction(this.OnBackgroundButtonClick));
			this.m_prefabsGameObject.SetActive(false);
		}

		// Token: 0x0600C86F RID: 51311 RVA: 0x00377C60 File Offset: 0x00375E60
		public void Open(bool hasRecommendHero)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OpenBoolean_hotfix != null)
			{
				this.m_OpenBoolean_hotfix.call(new object[]
				{
					this,
					hasRecommendHero
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetUIStateOpen(this.m_uiStateController, (!hasRecommendHero) ? "Show" : "RecommendShow", null, false, true);
		}

		// Token: 0x0600C870 RID: 51312 RVA: 0x00377CF4 File Offset: 0x00375EF4
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
			string stateName;
			if (UIUtility.GetUIStateCurrentStateName(this.m_uiStateController) == "RecommendShow")
			{
				stateName = "RecommendClose";
			}
			else
			{
				stateName = "Close";
			}
			UIUtility.SetUIStateClose(this.m_uiStateController, stateName, onEnd, false, true);
		}

		// Token: 0x0600C871 RID: 51313 RVA: 0x00377DA0 File Offset: 0x00375FA0
		public void SetTowerLevel(ConfigDataTowerFloorInfo floorInfo, ConfigDataTowerLevelInfo levelInfo, ConfigDataTowerBattleRuleInfo ruleInfo, ConfigDataTowerBonusHeroGroupInfo bonusHeroGroupInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetTowerLevelConfigDataTowerFloorInfoConfigDataTowerLevelInfoConfigDataTowerBattleRuleInfoConfigDataTowerBonusHeroGroupInfo_hotfix != null)
			{
				this.m_SetTowerLevelConfigDataTowerFloorInfoConfigDataTowerLevelInfoConfigDataTowerBattleRuleInfoConfigDataTowerBonusHeroGroupInfo_hotfix.call(new object[]
				{
					this,
					floorInfo,
					levelInfo,
					ruleInfo,
					bonusHeroGroupInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (levelInfo == null)
			{
				return;
			}
			this.m_nameText.text = floorInfo.Name;
			this.m_hardText.text = floorInfo.MonsterLevel.ToString();
			this.m_image.sprite = AssetUtility.Instance.GetSprite(levelInfo.ThumbImage);
			this.m_costEnergyText.text = floorInfo.EnergySuccess.ToString();
			this.SetConditions(this.m_winConditionGroupTransform, levelInfo.BattleInfo.WinDesc, 0);
			if (ruleInfo != null && ruleInfo.SkillInfo != null)
			{
				this.SetConditions(this.m_ruleConditionGroupTransform, ruleInfo.Desc, 1);
			}
			else
			{
				GameObjectUtility.DestroyChildren(this.m_ruleConditionGroupTransform.gameObject);
			}
			if (bonusHeroGroupInfo != null)
			{
				this.m_recommendHeroDescText.text = UIUtility.GetDescText(floorInfo.BonusHeroDesc, floorInfo.BonusHeroDescParam);
				this.SetRecommendHeros(bonusHeroGroupInfo.BonusHeroIdList);
			}
			GameObject assetInContainer = base.GetAssetInContainer<GameObject>("RewardGoods");
			GameObjectUtility.DestroyChildren(this.m_rewardGroupTransform.gameObject);
			RewardGoodsUIController.CreateRewardGoodsList(floorInfo.RewardList, this.m_rewardGroupTransform, assetInContainer, null, true, 0, true);
		}

		// Token: 0x0600C872 RID: 51314 RVA: 0x00377F64 File Offset: 0x00376164
		private void SetRecommendHeros(List<int> heroIds)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetRecommendHerosList`1_hotfix != null)
			{
				this.m_SetRecommendHerosList`1_hotfix.call(new object[]
				{
					this,
					heroIds
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetGameObjectChildrenActiveCount(this.m_recommendHeroGroupTransform.gameObject, heroIds.Count);
			for (int i = 0; i < heroIds.Count; i++)
			{
				UnchartedScoreRecommendHeroListItemUIController unchartedScoreRecommendHeroListItemUIController;
				if (i < this.m_recommendHeroGroupTransform.childCount)
				{
					unchartedScoreRecommendHeroListItemUIController = this.m_recommendHeroGroupTransform.GetChild(i).GetComponent<UnchartedScoreRecommendHeroListItemUIController>();
				}
				else
				{
					GameObject go = UnityEngine.Object.Instantiate<GameObject>(this.m_recommendHeroItemPrefab, this.m_recommendHeroGroupTransform, false);
					unchartedScoreRecommendHeroListItemUIController = GameObjectUtility.AddControllerToGameObject<UnchartedScoreRecommendHeroListItemUIController>(go);
				}
				unchartedScoreRecommendHeroListItemUIController.SetHero(heroIds[i]);
			}
		}

		// Token: 0x0600C873 RID: 51315 RVA: 0x00378054 File Offset: 0x00376254
		private void SetConditions(Transform parent, string conditionStrs, int stateType)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetConditionsTransformStringInt32_hotfix != null)
			{
				this.m_SetConditionsTransformStringInt32_hotfix.call(new object[]
				{
					this,
					parent,
					conditionStrs,
					stateType
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GameObjectUtility.DestroyChildren(parent.gameObject);
			char[] separator = new char[]
			{
				'\r',
				'\n'
			};
			string[] array = conditionStrs.Split(separator);
			foreach (string str in array)
			{
				this.AddCondition(parent, str, stateType);
			}
		}

		// Token: 0x0600C874 RID: 51316 RVA: 0x00378130 File Offset: 0x00376330
		private void AddCondition(Transform parent, string str, int stateType)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddConditionTransformStringInt32_hotfix != null)
			{
				this.m_AddConditionTransformStringInt32_hotfix.call(new object[]
				{
					this,
					parent,
					str,
					stateType
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.m_conditionPrefab, parent, false);
			Text component = gameObject.GetComponent<Text>();
			if (component != null)
			{
				component.text = str;
			}
			CommonUIStateController component2 = gameObject.GetComponent<CommonUIStateController>();
			if (component2 != null)
			{
				component2.SetToUIState((stateType != 0) ? "Rule" : "Win", false, true);
			}
		}

		// Token: 0x0600C875 RID: 51317 RVA: 0x00378218 File Offset: 0x00376418
		private void OnBackgroundButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnBackgroundButtonClick_hotfix != null)
			{
				this.m_OnBackgroundButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnClose != null)
			{
				this.EventOnClose();
			}
		}

		// Token: 0x0600C876 RID: 51318 RVA: 0x00378290 File Offset: 0x00376490
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
			if (this.EventOnStartBattle != null)
			{
				this.EventOnStartBattle();
			}
		}

		// Token: 0x1400026B RID: 619
		// (add) Token: 0x0600C877 RID: 51319 RVA: 0x00378308 File Offset: 0x00376508
		// (remove) Token: 0x0600C878 RID: 51320 RVA: 0x003783A4 File Offset: 0x003765A4
		public event Action EventOnStartBattle
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnStartBattleAction_hotfix != null)
				{
					this.m_add_EventOnStartBattleAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnStartBattle;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnStartBattle, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnStartBattleAction_hotfix != null)
				{
					this.m_remove_EventOnStartBattleAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnStartBattle;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnStartBattle, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1400026C RID: 620
		// (add) Token: 0x0600C879 RID: 51321 RVA: 0x00378440 File Offset: 0x00376640
		// (remove) Token: 0x0600C87A RID: 51322 RVA: 0x003784DC File Offset: 0x003766DC
		public event Action EventOnClose
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnCloseAction_hotfix != null)
				{
					this.m_add_EventOnCloseAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnClose;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnClose, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnCloseAction_hotfix != null)
				{
					this.m_remove_EventOnCloseAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnClose;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnClose, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x170027DB RID: 10203
		// (get) Token: 0x0600C87B RID: 51323 RVA: 0x00378578 File Offset: 0x00376778
		// (set) Token: 0x0600C87C RID: 51324 RVA: 0x00378598 File Offset: 0x00376798
		[DoNotToLua]
		public new ClimbTowerLevelInfoUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new ClimbTowerLevelInfoUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600C87D RID: 51325 RVA: 0x003785A4 File Offset: 0x003767A4
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0600C87E RID: 51326 RVA: 0x003785B0 File Offset: 0x003767B0
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0600C87F RID: 51327 RVA: 0x003785B8 File Offset: 0x003767B8
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0600C880 RID: 51328 RVA: 0x003785C0 File Offset: 0x003767C0
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0600C881 RID: 51329 RVA: 0x003785D4 File Offset: 0x003767D4
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0600C882 RID: 51330 RVA: 0x003785DC File Offset: 0x003767DC
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0600C883 RID: 51331 RVA: 0x003785E8 File Offset: 0x003767E8
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0600C884 RID: 51332 RVA: 0x003785F4 File Offset: 0x003767F4
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0600C885 RID: 51333 RVA: 0x00378600 File Offset: 0x00376800
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0600C886 RID: 51334 RVA: 0x0037860C File Offset: 0x0037680C
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0600C887 RID: 51335 RVA: 0x00378618 File Offset: 0x00376818
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0600C888 RID: 51336 RVA: 0x00378624 File Offset: 0x00376824
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0600C889 RID: 51337 RVA: 0x00378630 File Offset: 0x00376830
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0600C88A RID: 51338 RVA: 0x0037863C File Offset: 0x0037683C
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0600C88B RID: 51339 RVA: 0x00378648 File Offset: 0x00376848
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600C88C RID: 51340 RVA: 0x00378650 File Offset: 0x00376850
		private void __callDele_EventOnStartBattle()
		{
			Action eventOnStartBattle = this.EventOnStartBattle;
			if (eventOnStartBattle != null)
			{
				eventOnStartBattle();
			}
		}

		// Token: 0x0600C88D RID: 51341 RVA: 0x00378670 File Offset: 0x00376870
		private void __clearDele_EventOnStartBattle()
		{
			this.EventOnStartBattle = null;
		}

		// Token: 0x0600C88E RID: 51342 RVA: 0x0037867C File Offset: 0x0037687C
		private void __callDele_EventOnClose()
		{
			Action eventOnClose = this.EventOnClose;
			if (eventOnClose != null)
			{
				eventOnClose();
			}
		}

		// Token: 0x0600C88F RID: 51343 RVA: 0x0037869C File Offset: 0x0037689C
		private void __clearDele_EventOnClose()
		{
			this.EventOnClose = null;
		}

		// Token: 0x0600C890 RID: 51344 RVA: 0x003786A8 File Offset: 0x003768A8
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
					this.m_OpenBoolean_hotfix = (luaObj.RawGet("Open") as LuaFunction);
					this.m_CloseAction_hotfix = (luaObj.RawGet("Close") as LuaFunction);
					this.m_SetTowerLevelConfigDataTowerFloorInfoConfigDataTowerLevelInfoConfigDataTowerBattleRuleInfoConfigDataTowerBonusHeroGroupInfo_hotfix = (luaObj.RawGet("SetTowerLevel") as LuaFunction);
					this.m_SetRecommendHerosList`1_hotfix = (luaObj.RawGet("SetRecommendHeros") as LuaFunction);
					this.m_SetConditionsTransformStringInt32_hotfix = (luaObj.RawGet("SetConditions") as LuaFunction);
					this.m_AddConditionTransformStringInt32_hotfix = (luaObj.RawGet("AddCondition") as LuaFunction);
					this.m_OnBackgroundButtonClick_hotfix = (luaObj.RawGet("OnBackgroundButtonClick") as LuaFunction);
					this.m_OnStartButtonClick_hotfix = (luaObj.RawGet("OnStartButtonClick") as LuaFunction);
					this.m_add_EventOnStartBattleAction_hotfix = (luaObj.RawGet("add_EventOnStartBattle") as LuaFunction);
					this.m_remove_EventOnStartBattleAction_hotfix = (luaObj.RawGet("remove_EventOnStartBattle") as LuaFunction);
					this.m_add_EventOnCloseAction_hotfix = (luaObj.RawGet("add_EventOnClose") as LuaFunction);
					this.m_remove_EventOnCloseAction_hotfix = (luaObj.RawGet("remove_EventOnClose") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600C891 RID: 51345 RVA: 0x003788A0 File Offset: 0x00376AA0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ClimbTowerLevelInfoUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04007EAA RID: 32426
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_uiStateController;

		// Token: 0x04007EAB RID: 32427
		[AutoBind("./Panel/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_nameText;

		// Token: 0x04007EAC RID: 32428
		[AutoBind("./Panel/Image", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_image;

		// Token: 0x04007EAD RID: 32429
		[AutoBind("./Panel/Hard/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_hardText;

		// Token: 0x04007EAE RID: 32430
		[AutoBind("./Panel/StartButton/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_costEnergyText;

		// Token: 0x04007EAF RID: 32431
		[AutoBind("./Panel/WinCondition/ConditionGroup", AutoBindAttribute.InitState.NotInit, false)]
		private Transform m_winConditionGroupTransform;

		// Token: 0x04007EB0 RID: 32432
		[AutoBind("./Panel/Rule/ConditionGroup", AutoBindAttribute.InitState.NotInit, false)]
		private Transform m_ruleConditionGroupTransform;

		// Token: 0x04007EB1 RID: 32433
		[AutoBind("./Panel/RewardGroup", AutoBindAttribute.InitState.NotInit, false)]
		private Transform m_rewardGroupTransform;

		// Token: 0x04007EB2 RID: 32434
		[AutoBind("./RecommendPanel/HeroScrollView/Viewport/HeroGroup", AutoBindAttribute.InitState.NotInit, false)]
		private Transform m_recommendHeroGroupTransform;

		// Token: 0x04007EB3 RID: 32435
		[AutoBind("./RecommendPanel/InfoText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_recommendHeroDescText;

		// Token: 0x04007EB4 RID: 32436
		[AutoBind("./Panel/StartButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_startButton;

		// Token: 0x04007EB5 RID: 32437
		[AutoBind("./BackgroundButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_backgroundButton;

		// Token: 0x04007EB6 RID: 32438
		[AutoBind("./Prefabs", AutoBindAttribute.InitState.Inactive, false)]
		private GameObject m_prefabsGameObject;

		// Token: 0x04007EB7 RID: 32439
		[AutoBind("./Prefabs/ConditionText", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_conditionPrefab;

		// Token: 0x04007EB8 RID: 32440
		[AutoBind("./Prefabs/RecommendHeroItem", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_recommendHeroItemPrefab;

		// Token: 0x04007EB9 RID: 32441
		[DoNotToLua]
		private ClimbTowerLevelInfoUIController.LuaExportHelper luaExportHelper;

		// Token: 0x04007EBA RID: 32442
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04007EBB RID: 32443
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04007EBC RID: 32444
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x04007EBD RID: 32445
		private LuaFunction m_OpenBoolean_hotfix;

		// Token: 0x04007EBE RID: 32446
		private LuaFunction m_CloseAction_hotfix;

		// Token: 0x04007EBF RID: 32447
		private LuaFunction m_SetTowerLevelConfigDataTowerFloorInfoConfigDataTowerLevelInfoConfigDataTowerBattleRuleInfoConfigDataTowerBonusHeroGroupInfo_hotfix;

		// Token: 0x04007EC0 RID: 32448
		private LuaFunction m_SetRecommendHerosList;

		// Token: 0x04007EC1 RID: 32449
		private LuaFunction m_SetConditionsTransformStringInt32_hotfix;

		// Token: 0x04007EC2 RID: 32450
		private LuaFunction m_AddConditionTransformStringInt32_hotfix;

		// Token: 0x04007EC3 RID: 32451
		private LuaFunction m_OnBackgroundButtonClick_hotfix;

		// Token: 0x04007EC4 RID: 32452
		private LuaFunction m_OnStartButtonClick_hotfix;

		// Token: 0x04007EC5 RID: 32453
		private LuaFunction m_add_EventOnStartBattleAction_hotfix;

		// Token: 0x04007EC6 RID: 32454
		private LuaFunction m_remove_EventOnStartBattleAction_hotfix;

		// Token: 0x04007EC7 RID: 32455
		private LuaFunction m_add_EventOnCloseAction_hotfix;

		// Token: 0x04007EC8 RID: 32456
		private LuaFunction m_remove_EventOnCloseAction_hotfix;

		// Token: 0x02000B81 RID: 2945
		public new class LuaExportHelper
		{
			// Token: 0x0600C892 RID: 51346 RVA: 0x00378908 File Offset: 0x00376B08
			public LuaExportHelper(ClimbTowerLevelInfoUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600C893 RID: 51347 RVA: 0x00378918 File Offset: 0x00376B18
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0600C894 RID: 51348 RVA: 0x00378928 File Offset: 0x00376B28
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0600C895 RID: 51349 RVA: 0x00378938 File Offset: 0x00376B38
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600C896 RID: 51350 RVA: 0x00378948 File Offset: 0x00376B48
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600C897 RID: 51351 RVA: 0x00378960 File Offset: 0x00376B60
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0600C898 RID: 51352 RVA: 0x00378970 File Offset: 0x00376B70
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0600C899 RID: 51353 RVA: 0x00378980 File Offset: 0x00376B80
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0600C89A RID: 51354 RVA: 0x00378990 File Offset: 0x00376B90
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0600C89B RID: 51355 RVA: 0x003789A0 File Offset: 0x00376BA0
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0600C89C RID: 51356 RVA: 0x003789B0 File Offset: 0x00376BB0
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0600C89D RID: 51357 RVA: 0x003789C0 File Offset: 0x00376BC0
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0600C89E RID: 51358 RVA: 0x003789D0 File Offset: 0x00376BD0
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0600C89F RID: 51359 RVA: 0x003789E0 File Offset: 0x00376BE0
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0600C8A0 RID: 51360 RVA: 0x003789F0 File Offset: 0x00376BF0
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0600C8A1 RID: 51361 RVA: 0x00378A00 File Offset: 0x00376C00
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x0600C8A2 RID: 51362 RVA: 0x00378A10 File Offset: 0x00376C10
			public void __callDele_EventOnStartBattle()
			{
				this.m_owner.__callDele_EventOnStartBattle();
			}

			// Token: 0x0600C8A3 RID: 51363 RVA: 0x00378A20 File Offset: 0x00376C20
			public void __clearDele_EventOnStartBattle()
			{
				this.m_owner.__clearDele_EventOnStartBattle();
			}

			// Token: 0x0600C8A4 RID: 51364 RVA: 0x00378A30 File Offset: 0x00376C30
			public void __callDele_EventOnClose()
			{
				this.m_owner.__callDele_EventOnClose();
			}

			// Token: 0x0600C8A5 RID: 51365 RVA: 0x00378A40 File Offset: 0x00376C40
			public void __clearDele_EventOnClose()
			{
				this.m_owner.__clearDele_EventOnClose();
			}

			// Token: 0x170027DC RID: 10204
			// (get) Token: 0x0600C8A6 RID: 51366 RVA: 0x00378A50 File Offset: 0x00376C50
			// (set) Token: 0x0600C8A7 RID: 51367 RVA: 0x00378A60 File Offset: 0x00376C60
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

			// Token: 0x170027DD RID: 10205
			// (get) Token: 0x0600C8A8 RID: 51368 RVA: 0x00378A70 File Offset: 0x00376C70
			// (set) Token: 0x0600C8A9 RID: 51369 RVA: 0x00378A80 File Offset: 0x00376C80
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

			// Token: 0x170027DE RID: 10206
			// (get) Token: 0x0600C8AA RID: 51370 RVA: 0x00378A90 File Offset: 0x00376C90
			// (set) Token: 0x0600C8AB RID: 51371 RVA: 0x00378AA0 File Offset: 0x00376CA0
			public Image m_image
			{
				get
				{
					return this.m_owner.m_image;
				}
				set
				{
					this.m_owner.m_image = value;
				}
			}

			// Token: 0x170027DF RID: 10207
			// (get) Token: 0x0600C8AC RID: 51372 RVA: 0x00378AB0 File Offset: 0x00376CB0
			// (set) Token: 0x0600C8AD RID: 51373 RVA: 0x00378AC0 File Offset: 0x00376CC0
			public Text m_hardText
			{
				get
				{
					return this.m_owner.m_hardText;
				}
				set
				{
					this.m_owner.m_hardText = value;
				}
			}

			// Token: 0x170027E0 RID: 10208
			// (get) Token: 0x0600C8AE RID: 51374 RVA: 0x00378AD0 File Offset: 0x00376CD0
			// (set) Token: 0x0600C8AF RID: 51375 RVA: 0x00378AE0 File Offset: 0x00376CE0
			public Text m_costEnergyText
			{
				get
				{
					return this.m_owner.m_costEnergyText;
				}
				set
				{
					this.m_owner.m_costEnergyText = value;
				}
			}

			// Token: 0x170027E1 RID: 10209
			// (get) Token: 0x0600C8B0 RID: 51376 RVA: 0x00378AF0 File Offset: 0x00376CF0
			// (set) Token: 0x0600C8B1 RID: 51377 RVA: 0x00378B00 File Offset: 0x00376D00
			public Transform m_winConditionGroupTransform
			{
				get
				{
					return this.m_owner.m_winConditionGroupTransform;
				}
				set
				{
					this.m_owner.m_winConditionGroupTransform = value;
				}
			}

			// Token: 0x170027E2 RID: 10210
			// (get) Token: 0x0600C8B2 RID: 51378 RVA: 0x00378B10 File Offset: 0x00376D10
			// (set) Token: 0x0600C8B3 RID: 51379 RVA: 0x00378B20 File Offset: 0x00376D20
			public Transform m_ruleConditionGroupTransform
			{
				get
				{
					return this.m_owner.m_ruleConditionGroupTransform;
				}
				set
				{
					this.m_owner.m_ruleConditionGroupTransform = value;
				}
			}

			// Token: 0x170027E3 RID: 10211
			// (get) Token: 0x0600C8B4 RID: 51380 RVA: 0x00378B30 File Offset: 0x00376D30
			// (set) Token: 0x0600C8B5 RID: 51381 RVA: 0x00378B40 File Offset: 0x00376D40
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

			// Token: 0x170027E4 RID: 10212
			// (get) Token: 0x0600C8B6 RID: 51382 RVA: 0x00378B50 File Offset: 0x00376D50
			// (set) Token: 0x0600C8B7 RID: 51383 RVA: 0x00378B60 File Offset: 0x00376D60
			public Transform m_recommendHeroGroupTransform
			{
				get
				{
					return this.m_owner.m_recommendHeroGroupTransform;
				}
				set
				{
					this.m_owner.m_recommendHeroGroupTransform = value;
				}
			}

			// Token: 0x170027E5 RID: 10213
			// (get) Token: 0x0600C8B8 RID: 51384 RVA: 0x00378B70 File Offset: 0x00376D70
			// (set) Token: 0x0600C8B9 RID: 51385 RVA: 0x00378B80 File Offset: 0x00376D80
			public Text m_recommendHeroDescText
			{
				get
				{
					return this.m_owner.m_recommendHeroDescText;
				}
				set
				{
					this.m_owner.m_recommendHeroDescText = value;
				}
			}

			// Token: 0x170027E6 RID: 10214
			// (get) Token: 0x0600C8BA RID: 51386 RVA: 0x00378B90 File Offset: 0x00376D90
			// (set) Token: 0x0600C8BB RID: 51387 RVA: 0x00378BA0 File Offset: 0x00376DA0
			public Button m_startButton
			{
				get
				{
					return this.m_owner.m_startButton;
				}
				set
				{
					this.m_owner.m_startButton = value;
				}
			}

			// Token: 0x170027E7 RID: 10215
			// (get) Token: 0x0600C8BC RID: 51388 RVA: 0x00378BB0 File Offset: 0x00376DB0
			// (set) Token: 0x0600C8BD RID: 51389 RVA: 0x00378BC0 File Offset: 0x00376DC0
			public Button m_backgroundButton
			{
				get
				{
					return this.m_owner.m_backgroundButton;
				}
				set
				{
					this.m_owner.m_backgroundButton = value;
				}
			}

			// Token: 0x170027E8 RID: 10216
			// (get) Token: 0x0600C8BE RID: 51390 RVA: 0x00378BD0 File Offset: 0x00376DD0
			// (set) Token: 0x0600C8BF RID: 51391 RVA: 0x00378BE0 File Offset: 0x00376DE0
			public GameObject m_prefabsGameObject
			{
				get
				{
					return this.m_owner.m_prefabsGameObject;
				}
				set
				{
					this.m_owner.m_prefabsGameObject = value;
				}
			}

			// Token: 0x170027E9 RID: 10217
			// (get) Token: 0x0600C8C0 RID: 51392 RVA: 0x00378BF0 File Offset: 0x00376DF0
			// (set) Token: 0x0600C8C1 RID: 51393 RVA: 0x00378C00 File Offset: 0x00376E00
			public GameObject m_conditionPrefab
			{
				get
				{
					return this.m_owner.m_conditionPrefab;
				}
				set
				{
					this.m_owner.m_conditionPrefab = value;
				}
			}

			// Token: 0x170027EA RID: 10218
			// (get) Token: 0x0600C8C2 RID: 51394 RVA: 0x00378C10 File Offset: 0x00376E10
			// (set) Token: 0x0600C8C3 RID: 51395 RVA: 0x00378C20 File Offset: 0x00376E20
			public GameObject m_recommendHeroItemPrefab
			{
				get
				{
					return this.m_owner.m_recommendHeroItemPrefab;
				}
				set
				{
					this.m_owner.m_recommendHeroItemPrefab = value;
				}
			}

			// Token: 0x0600C8C4 RID: 51396 RVA: 0x00378C30 File Offset: 0x00376E30
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0600C8C5 RID: 51397 RVA: 0x00378C40 File Offset: 0x00376E40
			public void SetRecommendHeros(List<int> heroIds)
			{
				this.m_owner.SetRecommendHeros(heroIds);
			}

			// Token: 0x0600C8C6 RID: 51398 RVA: 0x00378C50 File Offset: 0x00376E50
			public void SetConditions(Transform parent, string conditionStrs, int stateType)
			{
				this.m_owner.SetConditions(parent, conditionStrs, stateType);
			}

			// Token: 0x0600C8C7 RID: 51399 RVA: 0x00378C60 File Offset: 0x00376E60
			public void AddCondition(Transform parent, string str, int stateType)
			{
				this.m_owner.AddCondition(parent, str, stateType);
			}

			// Token: 0x0600C8C8 RID: 51400 RVA: 0x00378C70 File Offset: 0x00376E70
			public void OnBackgroundButtonClick()
			{
				this.m_owner.OnBackgroundButtonClick();
			}

			// Token: 0x0600C8C9 RID: 51401 RVA: 0x00378C80 File Offset: 0x00376E80
			public void OnStartButtonClick()
			{
				this.m_owner.OnStartButtonClick();
			}

			// Token: 0x04007EC9 RID: 32457
			private ClimbTowerLevelInfoUIController m_owner;
		}
	}
}
