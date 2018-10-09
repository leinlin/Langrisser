using System;
using System.Collections.Generic;
using System.Threading;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Misc;
using BlackJack.ProjectL.PlayerContext;
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000C80 RID: 3200
	[HotFix]
	public class FettersInformationUIController : UIControllerBase
	{
		// Token: 0x0600E622 RID: 58914 RVA: 0x003DC368 File Offset: 0x003DA568
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
			this.m_returnButton.onClick.AddListener(new UnityAction(this.OnReturnButtonClick));
			this.m_toggleLife.onValueChanged.AddListener(new UnityAction<bool>(this.OnToggleLifeValueChange));
			this.m_toggleVoice.onValueChanged.AddListener(new UnityAction<bool>(this.OnToggleVoiceValueChange));
			base.gameObject.SetActive(true);
			this.m_configDataLoader = (GameManager.Instance.ConfigDataLoader as IConfigDataLoader);
		}

		// Token: 0x0600E623 RID: 58915 RVA: 0x003DC444 File Offset: 0x003DA644
		private void OnDisable()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnDisable_hotfix != null)
			{
				this.m_OnDisable_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x0600E624 RID: 58916 RVA: 0x003DC4A4 File Offset: 0x003DA6A4
		public void UpdateViewInFettersInformation(Hero hero)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateViewInFettersInformationHero_hotfix != null)
			{
				this.m_UpdateViewInFettersInformationHero_hotfix.call(new object[]
				{
					this,
					hero
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_hero = hero;
			this.m_heroInformationInfo = this.m_hero.HeroInfo.m_informationInfo;
			this.m_heroNameText.text = this.m_hero.HeroInfo.Name;
			this.m_heroEngNameText.text = this.m_hero.HeroInfo.Name_Eng;
			this.m_heroRankImage.sprite = AssetUtility.Instance.GetSprite(UIUtility.GetRankImage(this.m_hero.HeroInfo.GetRank(hero.StarLevel)));
			this.m_toggleLife.isOn = true;
			this.UpdateToggleNewTag();
			this.UpdateHeroLifeList();
			this.m_commonUIStateCtrl.SetToUIState("Show", false, true);
		}

		// Token: 0x0600E625 RID: 58917 RVA: 0x003DC5C4 File Offset: 0x003DA7C4
		private void UpdateHeroLifeList()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateHeroLifeList_hotfix != null)
			{
				this.m_UpdateHeroLifeList_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GameObjectUtility.DestroyChildren(this.m_lifeContent);
			if (this.m_heroInformationInfo == null)
			{
				return;
			}
			List<int> heroBiographies_ID = this.m_heroInformationInfo.HeroBiographies_ID;
			this.biographyCtrlList.Clear();
			GameObject assetInContainer = base.GetAssetInContainer<GameObject>("LifeItem");
			foreach (int biographyId in heroBiographies_ID)
			{
				GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(assetInContainer);
				PrefabControllerCreater.CreateAllControllers(gameObject);
				FettersInformationLifeItemUIController component = gameObject.GetComponent<FettersInformationLifeItemUIController>();
				component.InitLifeItem(biographyId);
				gameObject.transform.SetParent(this.m_lifeContent.transform, false);
				if (!this.biographyCtrlList.Contains(component))
				{
					this.biographyCtrlList.Add(component);
				}
			}
		}

		// Token: 0x0600E626 RID: 58918 RVA: 0x003DC6FC File Offset: 0x003DA8FC
		private void UpdateHeroVoiceList()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateHeroVoiceList_hotfix != null)
			{
				this.m_UpdateHeroVoiceList_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_voiceCVNameText.text = this.m_hero.HeroInfo.GetCharImageInfo(this.m_hero.StarLevel).CVName;
			GameObjectUtility.DestroyChildren(this.m_voiceContent);
			if (this.m_heroInformationInfo == null)
			{
				return;
			}
			this.voiceCtrlList.Clear();
			ConfigDataPerformanceInfo configDataPerformanceInfo = this.m_configDataLoader.GetConfigDataPerformanceInfo(this.m_heroInformationInfo.HeroPerformance_ID);
			if (configDataPerformanceInfo == null)
			{
				return;
			}
			GameObject assetInContainer = base.GetAssetInContainer<GameObject>("VoiceItem");
			foreach (int heroPerformanceId in configDataPerformanceInfo.HeroPerformances_ID)
			{
				GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(assetInContainer);
				PrefabControllerCreater.CreateAllControllers(gameObject);
				FettersInformationVoiceItemUIController component = gameObject.GetComponent<FettersInformationVoiceItemUIController>();
				component.InitVoiceItem(heroPerformanceId);
				component.EventOnVoiceButtonClick += this.OnPeofermanceVoiceButtonClick;
				gameObject.transform.SetParent(this.m_voiceContent.transform, false);
				if (!this.voiceCtrlList.Contains(component))
				{
					this.voiceCtrlList.Add(component);
				}
			}
		}

		// Token: 0x0600E627 RID: 58919 RVA: 0x003DC888 File Offset: 0x003DAA88
		private void UpdateToggleNewTag()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateToggleNewTag_hotfix != null)
			{
				this.m_UpdateToggleNewTag_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_toggleLifeRedPoint.SetActive(FettersInformationUIController.HaveNewBiography(this.m_heroInformationInfo));
			this.m_toggleVoiceRedPoint.SetActive(FettersInformationUIController.HaveNewVoice(this.m_heroInformationInfo));
		}

		// Token: 0x0600E628 RID: 58920 RVA: 0x003DC914 File Offset: 0x003DAB14
		private void OnPeofermanceVoiceButtonClick(FettersInformationVoiceItemUIController ctrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnPeofermanceVoiceButtonClickFettersInformationVoiceItemUIController_hotfix != null)
			{
				this.m_OnPeofermanceVoiceButtonClickFettersInformationVoiceItemUIController_hotfix.call(new object[]
				{
					this,
					ctrl
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnVoiceItemClick != null)
			{
				this.EventOnVoiceItemClick(ctrl.HeroPerformanceInfo.ID);
			}
			ctrl.InitVoiceItem(ctrl.HeroPerformanceInfo.ID);
			bool active = false;
			foreach (FettersInformationVoiceItemUIController fettersInformationVoiceItemUIController in this.voiceCtrlList)
			{
				if (fettersInformationVoiceItemUIController.IsNewTagActive())
				{
					active = true;
					break;
				}
			}
			this.m_toggleVoiceRedPoint.SetActive(active);
		}

		// Token: 0x0600E629 RID: 58921 RVA: 0x003DCA20 File Offset: 0x003DAC20
		private void OnReturnButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnReturnButtonClick_hotfix != null)
			{
				this.m_OnReturnButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnReturn != null)
			{
				CommonUIController.Instance.EnableInput(false);
				this.m_commonUIStateCtrl.SetActionForUIStateFinshed("Close", delegate
				{
					CommonUIController.Instance.EnableInput(true);
					this.ResetScrollViewPosition();
					this.EventOnReturn();
				});
				this.m_commonUIStateCtrl.SetToUIState("Close", false, true);
			}
		}

		// Token: 0x0600E62A RID: 58922 RVA: 0x003DCAC8 File Offset: 0x003DACC8
		private void OnToggleLifeValueChange(bool isOn)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnToggleLifeValueChangeBoolean_hotfix != null)
			{
				this.m_OnToggleLifeValueChangeBoolean_hotfix.call(new object[]
				{
					this,
					isOn
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (isOn)
			{
				this.UpdateToggleNewTag();
				this.UpdateHeroLifeList();
				this.ResetScrollViewPosition();
			}
		}

		// Token: 0x0600E62B RID: 58923 RVA: 0x003DCB50 File Offset: 0x003DAD50
		private void OnToggleVoiceValueChange(bool isOn)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnToggleVoiceValueChangeBoolean_hotfix != null)
			{
				this.m_OnToggleVoiceValueChangeBoolean_hotfix.call(new object[]
				{
					this,
					isOn
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (isOn)
			{
				this.UpdateToggleNewTag();
				this.UpdateHeroVoiceList();
				this.ResetScrollViewPosition();
			}
		}

		// Token: 0x0600E62C RID: 58924 RVA: 0x003DCBD8 File Offset: 0x003DADD8
		public static bool HaveNewInfomation(ConfigDataHeroInformationInfo heroInfomationInfo)
		{
			return heroInfomationInfo != null && (FettersInformationUIController.HaveNewBiography(heroInfomationInfo) || FettersInformationUIController.HaveNewVoice(heroInfomationInfo));
		}

		// Token: 0x0600E62D RID: 58925 RVA: 0x003DCBF8 File Offset: 0x003DADF8
		public static bool HaveNewBiography(ConfigDataHeroInformationInfo heroInfomationInfo)
		{
			if (heroInfomationInfo == null)
			{
				return false;
			}
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			List<int> heroBiographies_ID = heroInfomationInfo.HeroBiographies_ID;
			if (heroBiographies_ID.Count != 0)
			{
				List<int> list;
				if (LocalAccountConfig.Instance.Data.HaveReadHeroBiographyIds != null)
				{
					list = new List<int>(LocalAccountConfig.Instance.Data.HaveReadHeroBiographyIds);
				}
				else
				{
					list = new List<int>();
				}
				foreach (int num in heroBiographies_ID)
				{
					if (projectLPlayerContext.CanUnlockHeroBiography(num) == 0)
					{
						if (!list.Contains(num))
						{
							return true;
						}
					}
				}
				return false;
			}
			return false;
		}

		// Token: 0x0600E62E RID: 58926 RVA: 0x003DCCD0 File Offset: 0x003DAED0
		public static bool HaveNewVoice(ConfigDataHeroInformationInfo heroInfomationInfo)
		{
			if (heroInfomationInfo == null)
			{
				return false;
			}
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			ConfigDataPerformanceInfo configDataPerformanceInfo = configDataLoader.GetConfigDataPerformanceInfo(heroInfomationInfo.HeroPerformance_ID);
			if (configDataPerformanceInfo == null)
			{
				return false;
			}
			List<int> heroPerformances_ID = configDataPerformanceInfo.HeroPerformances_ID;
			if (heroPerformances_ID.Count != 0)
			{
				List<int> list;
				if (LocalAccountConfig.Instance.Data.HaveReadHeroPerformanceIds != null)
				{
					list = new List<int>(LocalAccountConfig.Instance.Data.HaveReadHeroPerformanceIds);
				}
				else
				{
					list = new List<int>();
				}
				foreach (int num in heroPerformances_ID)
				{
					if (projectLPlayerContext.CanUnlockHeroPerformance(num) == 0)
					{
						if (!list.Contains(num))
						{
							return true;
						}
					}
				}
				return false;
			}
			return false;
		}

		// Token: 0x0600E62F RID: 58927 RVA: 0x003DCDD4 File Offset: 0x003DAFD4
		private void ResetScrollViewPosition()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ResetScrollViewPosition_hotfix != null)
			{
				this.m_ResetScrollViewPosition_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_lifeScrollRect.normalizedPosition = Vector2.one;
			this.m_voiceScrollRect.normalizedPosition = Vector2.one;
		}

		// Token: 0x140002EE RID: 750
		// (add) Token: 0x0600E630 RID: 58928 RVA: 0x003DCE54 File Offset: 0x003DB054
		// (remove) Token: 0x0600E631 RID: 58929 RVA: 0x003DCEF0 File Offset: 0x003DB0F0
		public event Action EventOnReturn
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnReturnAction_hotfix != null)
				{
					this.m_add_EventOnReturnAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnReturn;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnReturn, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnReturnAction_hotfix != null)
				{
					this.m_remove_EventOnReturnAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnReturn;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnReturn, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140002EF RID: 751
		// (add) Token: 0x0600E632 RID: 58930 RVA: 0x003DCF8C File Offset: 0x003DB18C
		// (remove) Token: 0x0600E633 RID: 58931 RVA: 0x003DD028 File Offset: 0x003DB228
		public event Action<int> EventOnVoiceItemClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnVoiceItemClickAction`1_hotfix != null)
				{
					this.m_add_EventOnVoiceItemClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int> action = this.EventOnVoiceItemClick;
				Action<int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int>>(ref this.EventOnVoiceItemClick, (Action<int>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnVoiceItemClickAction`1_hotfix != null)
				{
					this.m_remove_EventOnVoiceItemClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int> action = this.EventOnVoiceItemClick;
				Action<int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int>>(ref this.EventOnVoiceItemClick, (Action<int>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17002CB9 RID: 11449
		// (get) Token: 0x0600E634 RID: 58932 RVA: 0x003DD0C4 File Offset: 0x003DB2C4
		// (set) Token: 0x0600E635 RID: 58933 RVA: 0x003DD0E4 File Offset: 0x003DB2E4
		[DoNotToLua]
		public new FettersInformationUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new FettersInformationUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600E636 RID: 58934 RVA: 0x003DD0F0 File Offset: 0x003DB2F0
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0600E637 RID: 58935 RVA: 0x003DD0FC File Offset: 0x003DB2FC
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0600E638 RID: 58936 RVA: 0x003DD104 File Offset: 0x003DB304
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0600E639 RID: 58937 RVA: 0x003DD10C File Offset: 0x003DB30C
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0600E63A RID: 58938 RVA: 0x003DD120 File Offset: 0x003DB320
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0600E63B RID: 58939 RVA: 0x003DD128 File Offset: 0x003DB328
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0600E63C RID: 58940 RVA: 0x003DD134 File Offset: 0x003DB334
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0600E63D RID: 58941 RVA: 0x003DD140 File Offset: 0x003DB340
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0600E63E RID: 58942 RVA: 0x003DD14C File Offset: 0x003DB34C
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0600E63F RID: 58943 RVA: 0x003DD158 File Offset: 0x003DB358
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0600E640 RID: 58944 RVA: 0x003DD164 File Offset: 0x003DB364
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0600E641 RID: 58945 RVA: 0x003DD170 File Offset: 0x003DB370
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0600E642 RID: 58946 RVA: 0x003DD17C File Offset: 0x003DB37C
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0600E643 RID: 58947 RVA: 0x003DD188 File Offset: 0x003DB388
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0600E644 RID: 58948 RVA: 0x003DD194 File Offset: 0x003DB394
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600E645 RID: 58949 RVA: 0x003DD19C File Offset: 0x003DB39C
		private void __callDele_EventOnReturn()
		{
			Action eventOnReturn = this.EventOnReturn;
			if (eventOnReturn != null)
			{
				eventOnReturn();
			}
		}

		// Token: 0x0600E646 RID: 58950 RVA: 0x003DD1BC File Offset: 0x003DB3BC
		private void __clearDele_EventOnReturn()
		{
			this.EventOnReturn = null;
		}

		// Token: 0x0600E647 RID: 58951 RVA: 0x003DD1C8 File Offset: 0x003DB3C8
		private void __callDele_EventOnVoiceItemClick(int obj)
		{
			Action<int> eventOnVoiceItemClick = this.EventOnVoiceItemClick;
			if (eventOnVoiceItemClick != null)
			{
				eventOnVoiceItemClick(obj);
			}
		}

		// Token: 0x0600E648 RID: 58952 RVA: 0x003DD1EC File Offset: 0x003DB3EC
		private void __clearDele_EventOnVoiceItemClick(int obj)
		{
			this.EventOnVoiceItemClick = null;
		}

		// Token: 0x0600E64A RID: 58954 RVA: 0x003DD218 File Offset: 0x003DB418
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
					this.m_OnDisable_hotfix = (luaObj.RawGet("OnDisable") as LuaFunction);
					this.m_UpdateViewInFettersInformationHero_hotfix = (luaObj.RawGet("UpdateViewInFettersInformation") as LuaFunction);
					this.m_UpdateHeroLifeList_hotfix = (luaObj.RawGet("UpdateHeroLifeList") as LuaFunction);
					this.m_UpdateHeroVoiceList_hotfix = (luaObj.RawGet("UpdateHeroVoiceList") as LuaFunction);
					this.m_UpdateToggleNewTag_hotfix = (luaObj.RawGet("UpdateToggleNewTag") as LuaFunction);
					this.m_OnPeofermanceVoiceButtonClickFettersInformationVoiceItemUIController_hotfix = (luaObj.RawGet("OnPeofermanceVoiceButtonClick") as LuaFunction);
					this.m_OnReturnButtonClick_hotfix = (luaObj.RawGet("OnReturnButtonClick") as LuaFunction);
					this.m_OnToggleLifeValueChangeBoolean_hotfix = (luaObj.RawGet("OnToggleLifeValueChange") as LuaFunction);
					this.m_OnToggleVoiceValueChangeBoolean_hotfix = (luaObj.RawGet("OnToggleVoiceValueChange") as LuaFunction);
					this.m_ResetScrollViewPosition_hotfix = (luaObj.RawGet("ResetScrollViewPosition") as LuaFunction);
					this.m_add_EventOnReturnAction_hotfix = (luaObj.RawGet("add_EventOnReturn") as LuaFunction);
					this.m_remove_EventOnReturnAction_hotfix = (luaObj.RawGet("remove_EventOnReturn") as LuaFunction);
					this.m_add_EventOnVoiceItemClickAction`1_hotfix = (luaObj.RawGet("add_EventOnVoiceItemClick") as LuaFunction);
					this.m_remove_EventOnVoiceItemClickAction`1_hotfix = (luaObj.RawGet("remove_EventOnVoiceItemClick") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600E64B RID: 58955 RVA: 0x003DD444 File Offset: 0x003DB644
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(FettersInformationUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04008ADF RID: 35551
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_commonUIStateCtrl;

		// Token: 0x04008AE0 RID: 35552
		[AutoBind("./ReturnButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_returnButton;

		// Token: 0x04008AE1 RID: 35553
		[AutoBind("./InfoPanel/ToggleGroup/ToggleLife", AutoBindAttribute.InitState.NotInit, false)]
		private ToggleEx m_toggleLife;

		// Token: 0x04008AE2 RID: 35554
		[AutoBind("./InfoPanel/ToggleGroup/ToggleVoice", AutoBindAttribute.InitState.NotInit, false)]
		private ToggleEx m_toggleVoice;

		// Token: 0x04008AE3 RID: 35555
		[AutoBind("./InfoPanel/ToggleGroup/ToggleLife/RedPoint", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_toggleLifeRedPoint;

		// Token: 0x04008AE4 RID: 35556
		[AutoBind("./InfoPanel/ToggleGroup/ToggleVoice/RedPoint", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_toggleVoiceRedPoint;

		// Token: 0x04008AE5 RID: 35557
		[AutoBind("./InfoPanel/LifeIntroductionScrollView", AutoBindAttribute.InitState.NotInit, false)]
		private ScrollRect m_lifeScrollRect;

		// Token: 0x04008AE6 RID: 35558
		[AutoBind("./InfoPanel/VoiceScrollView", AutoBindAttribute.InitState.NotInit, false)]
		private ScrollRect m_voiceScrollRect;

		// Token: 0x04008AE7 RID: 35559
		[AutoBind("./InfoPanel/LifeIntroductionScrollView/Viewport/Content", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_lifeContent;

		// Token: 0x04008AE8 RID: 35560
		[AutoBind("./InfoPanel/VoiceScrollView/Viewport/Content", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_voiceContent;

		// Token: 0x04008AE9 RID: 35561
		[AutoBind("./InfoPanel/VoiceScrollView/CV/NameText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_voiceCVNameText;

		// Token: 0x04008AEA RID: 35562
		[AutoBind("./NameInfo/NameText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_heroNameText;

		// Token: 0x04008AEB RID: 35563
		[AutoBind("./NameInfo/EngNameText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_heroEngNameText;

		// Token: 0x04008AEC RID: 35564
		[AutoBind("./NameInfo/Image", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_heroRankImage;

		// Token: 0x04008AED RID: 35565
		private Hero m_hero;

		// Token: 0x04008AEE RID: 35566
		private ConfigDataHeroInformationInfo m_heroInformationInfo;

		// Token: 0x04008AEF RID: 35567
		private List<FettersInformationLifeItemUIController> biographyCtrlList = new List<FettersInformationLifeItemUIController>();

		// Token: 0x04008AF0 RID: 35568
		private List<FettersInformationVoiceItemUIController> voiceCtrlList = new List<FettersInformationVoiceItemUIController>();

		// Token: 0x04008AF1 RID: 35569
		private IConfigDataLoader m_configDataLoader;

		// Token: 0x04008AF2 RID: 35570
		[DoNotToLua]
		private FettersInformationUIController.LuaExportHelper luaExportHelper;

		// Token: 0x04008AF3 RID: 35571
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04008AF4 RID: 35572
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04008AF5 RID: 35573
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x04008AF6 RID: 35574
		private LuaFunction m_OnDisable_hotfix;

		// Token: 0x04008AF7 RID: 35575
		private LuaFunction m_UpdateViewInFettersInformationHero_hotfix;

		// Token: 0x04008AF8 RID: 35576
		private LuaFunction m_UpdateHeroLifeList_hotfix;

		// Token: 0x04008AF9 RID: 35577
		private LuaFunction m_UpdateHeroVoiceList_hotfix;

		// Token: 0x04008AFA RID: 35578
		private LuaFunction m_UpdateToggleNewTag_hotfix;

		// Token: 0x04008AFB RID: 35579
		private LuaFunction m_OnPeofermanceVoiceButtonClickFettersInformationVoiceItemUIController_hotfix;

		// Token: 0x04008AFC RID: 35580
		private LuaFunction m_OnReturnButtonClick_hotfix;

		// Token: 0x04008AFD RID: 35581
		private LuaFunction m_OnToggleLifeValueChangeBoolean_hotfix;

		// Token: 0x04008AFE RID: 35582
		private LuaFunction m_OnToggleVoiceValueChangeBoolean_hotfix;

		// Token: 0x04008AFF RID: 35583
		private LuaFunction m_ResetScrollViewPosition_hotfix;

		// Token: 0x04008B00 RID: 35584
		private LuaFunction m_add_EventOnReturnAction_hotfix;

		// Token: 0x04008B01 RID: 35585
		private LuaFunction m_remove_EventOnReturnAction_hotfix;

		// Token: 0x04008B02 RID: 35586
		private LuaFunction m_add_EventOnVoiceItemClickAction;

		// Token: 0x04008B03 RID: 35587
		private LuaFunction m_remove_EventOnVoiceItemClickAction;

		// Token: 0x02000C81 RID: 3201
		public new class LuaExportHelper
		{
			// Token: 0x0600E64C RID: 58956 RVA: 0x003DD4AC File Offset: 0x003DB6AC
			public LuaExportHelper(FettersInformationUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600E64D RID: 58957 RVA: 0x003DD4BC File Offset: 0x003DB6BC
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0600E64E RID: 58958 RVA: 0x003DD4CC File Offset: 0x003DB6CC
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0600E64F RID: 58959 RVA: 0x003DD4DC File Offset: 0x003DB6DC
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600E650 RID: 58960 RVA: 0x003DD4EC File Offset: 0x003DB6EC
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600E651 RID: 58961 RVA: 0x003DD504 File Offset: 0x003DB704
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0600E652 RID: 58962 RVA: 0x003DD514 File Offset: 0x003DB714
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0600E653 RID: 58963 RVA: 0x003DD524 File Offset: 0x003DB724
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0600E654 RID: 58964 RVA: 0x003DD534 File Offset: 0x003DB734
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0600E655 RID: 58965 RVA: 0x003DD544 File Offset: 0x003DB744
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0600E656 RID: 58966 RVA: 0x003DD554 File Offset: 0x003DB754
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0600E657 RID: 58967 RVA: 0x003DD564 File Offset: 0x003DB764
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0600E658 RID: 58968 RVA: 0x003DD574 File Offset: 0x003DB774
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0600E659 RID: 58969 RVA: 0x003DD584 File Offset: 0x003DB784
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0600E65A RID: 58970 RVA: 0x003DD594 File Offset: 0x003DB794
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0600E65B RID: 58971 RVA: 0x003DD5A4 File Offset: 0x003DB7A4
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x0600E65C RID: 58972 RVA: 0x003DD5B4 File Offset: 0x003DB7B4
			public void __callDele_EventOnReturn()
			{
				this.m_owner.__callDele_EventOnReturn();
			}

			// Token: 0x0600E65D RID: 58973 RVA: 0x003DD5C4 File Offset: 0x003DB7C4
			public void __clearDele_EventOnReturn()
			{
				this.m_owner.__clearDele_EventOnReturn();
			}

			// Token: 0x0600E65E RID: 58974 RVA: 0x003DD5D4 File Offset: 0x003DB7D4
			public void __callDele_EventOnVoiceItemClick(int obj)
			{
				this.m_owner.__callDele_EventOnVoiceItemClick(obj);
			}

			// Token: 0x0600E65F RID: 58975 RVA: 0x003DD5E4 File Offset: 0x003DB7E4
			public void __clearDele_EventOnVoiceItemClick(int obj)
			{
				this.m_owner.__clearDele_EventOnVoiceItemClick(obj);
			}

			// Token: 0x17002CBA RID: 11450
			// (get) Token: 0x0600E660 RID: 58976 RVA: 0x003DD5F4 File Offset: 0x003DB7F4
			// (set) Token: 0x0600E661 RID: 58977 RVA: 0x003DD604 File Offset: 0x003DB804
			public CommonUIStateController m_commonUIStateCtrl
			{
				get
				{
					return this.m_owner.m_commonUIStateCtrl;
				}
				set
				{
					this.m_owner.m_commonUIStateCtrl = value;
				}
			}

			// Token: 0x17002CBB RID: 11451
			// (get) Token: 0x0600E662 RID: 58978 RVA: 0x003DD614 File Offset: 0x003DB814
			// (set) Token: 0x0600E663 RID: 58979 RVA: 0x003DD624 File Offset: 0x003DB824
			public Button m_returnButton
			{
				get
				{
					return this.m_owner.m_returnButton;
				}
				set
				{
					this.m_owner.m_returnButton = value;
				}
			}

			// Token: 0x17002CBC RID: 11452
			// (get) Token: 0x0600E664 RID: 58980 RVA: 0x003DD634 File Offset: 0x003DB834
			// (set) Token: 0x0600E665 RID: 58981 RVA: 0x003DD644 File Offset: 0x003DB844
			public ToggleEx m_toggleLife
			{
				get
				{
					return this.m_owner.m_toggleLife;
				}
				set
				{
					this.m_owner.m_toggleLife = value;
				}
			}

			// Token: 0x17002CBD RID: 11453
			// (get) Token: 0x0600E666 RID: 58982 RVA: 0x003DD654 File Offset: 0x003DB854
			// (set) Token: 0x0600E667 RID: 58983 RVA: 0x003DD664 File Offset: 0x003DB864
			public ToggleEx m_toggleVoice
			{
				get
				{
					return this.m_owner.m_toggleVoice;
				}
				set
				{
					this.m_owner.m_toggleVoice = value;
				}
			}

			// Token: 0x17002CBE RID: 11454
			// (get) Token: 0x0600E668 RID: 58984 RVA: 0x003DD674 File Offset: 0x003DB874
			// (set) Token: 0x0600E669 RID: 58985 RVA: 0x003DD684 File Offset: 0x003DB884
			public GameObject m_toggleLifeRedPoint
			{
				get
				{
					return this.m_owner.m_toggleLifeRedPoint;
				}
				set
				{
					this.m_owner.m_toggleLifeRedPoint = value;
				}
			}

			// Token: 0x17002CBF RID: 11455
			// (get) Token: 0x0600E66A RID: 58986 RVA: 0x003DD694 File Offset: 0x003DB894
			// (set) Token: 0x0600E66B RID: 58987 RVA: 0x003DD6A4 File Offset: 0x003DB8A4
			public GameObject m_toggleVoiceRedPoint
			{
				get
				{
					return this.m_owner.m_toggleVoiceRedPoint;
				}
				set
				{
					this.m_owner.m_toggleVoiceRedPoint = value;
				}
			}

			// Token: 0x17002CC0 RID: 11456
			// (get) Token: 0x0600E66C RID: 58988 RVA: 0x003DD6B4 File Offset: 0x003DB8B4
			// (set) Token: 0x0600E66D RID: 58989 RVA: 0x003DD6C4 File Offset: 0x003DB8C4
			public ScrollRect m_lifeScrollRect
			{
				get
				{
					return this.m_owner.m_lifeScrollRect;
				}
				set
				{
					this.m_owner.m_lifeScrollRect = value;
				}
			}

			// Token: 0x17002CC1 RID: 11457
			// (get) Token: 0x0600E66E RID: 58990 RVA: 0x003DD6D4 File Offset: 0x003DB8D4
			// (set) Token: 0x0600E66F RID: 58991 RVA: 0x003DD6E4 File Offset: 0x003DB8E4
			public ScrollRect m_voiceScrollRect
			{
				get
				{
					return this.m_owner.m_voiceScrollRect;
				}
				set
				{
					this.m_owner.m_voiceScrollRect = value;
				}
			}

			// Token: 0x17002CC2 RID: 11458
			// (get) Token: 0x0600E670 RID: 58992 RVA: 0x003DD6F4 File Offset: 0x003DB8F4
			// (set) Token: 0x0600E671 RID: 58993 RVA: 0x003DD704 File Offset: 0x003DB904
			public GameObject m_lifeContent
			{
				get
				{
					return this.m_owner.m_lifeContent;
				}
				set
				{
					this.m_owner.m_lifeContent = value;
				}
			}

			// Token: 0x17002CC3 RID: 11459
			// (get) Token: 0x0600E672 RID: 58994 RVA: 0x003DD714 File Offset: 0x003DB914
			// (set) Token: 0x0600E673 RID: 58995 RVA: 0x003DD724 File Offset: 0x003DB924
			public GameObject m_voiceContent
			{
				get
				{
					return this.m_owner.m_voiceContent;
				}
				set
				{
					this.m_owner.m_voiceContent = value;
				}
			}

			// Token: 0x17002CC4 RID: 11460
			// (get) Token: 0x0600E674 RID: 58996 RVA: 0x003DD734 File Offset: 0x003DB934
			// (set) Token: 0x0600E675 RID: 58997 RVA: 0x003DD744 File Offset: 0x003DB944
			public Text m_voiceCVNameText
			{
				get
				{
					return this.m_owner.m_voiceCVNameText;
				}
				set
				{
					this.m_owner.m_voiceCVNameText = value;
				}
			}

			// Token: 0x17002CC5 RID: 11461
			// (get) Token: 0x0600E676 RID: 58998 RVA: 0x003DD754 File Offset: 0x003DB954
			// (set) Token: 0x0600E677 RID: 58999 RVA: 0x003DD764 File Offset: 0x003DB964
			public Text m_heroNameText
			{
				get
				{
					return this.m_owner.m_heroNameText;
				}
				set
				{
					this.m_owner.m_heroNameText = value;
				}
			}

			// Token: 0x17002CC6 RID: 11462
			// (get) Token: 0x0600E678 RID: 59000 RVA: 0x003DD774 File Offset: 0x003DB974
			// (set) Token: 0x0600E679 RID: 59001 RVA: 0x003DD784 File Offset: 0x003DB984
			public Text m_heroEngNameText
			{
				get
				{
					return this.m_owner.m_heroEngNameText;
				}
				set
				{
					this.m_owner.m_heroEngNameText = value;
				}
			}

			// Token: 0x17002CC7 RID: 11463
			// (get) Token: 0x0600E67A RID: 59002 RVA: 0x003DD794 File Offset: 0x003DB994
			// (set) Token: 0x0600E67B RID: 59003 RVA: 0x003DD7A4 File Offset: 0x003DB9A4
			public Image m_heroRankImage
			{
				get
				{
					return this.m_owner.m_heroRankImage;
				}
				set
				{
					this.m_owner.m_heroRankImage = value;
				}
			}

			// Token: 0x17002CC8 RID: 11464
			// (get) Token: 0x0600E67C RID: 59004 RVA: 0x003DD7B4 File Offset: 0x003DB9B4
			// (set) Token: 0x0600E67D RID: 59005 RVA: 0x003DD7C4 File Offset: 0x003DB9C4
			public Hero m_hero
			{
				get
				{
					return this.m_owner.m_hero;
				}
				set
				{
					this.m_owner.m_hero = value;
				}
			}

			// Token: 0x17002CC9 RID: 11465
			// (get) Token: 0x0600E67E RID: 59006 RVA: 0x003DD7D4 File Offset: 0x003DB9D4
			// (set) Token: 0x0600E67F RID: 59007 RVA: 0x003DD7E4 File Offset: 0x003DB9E4
			public ConfigDataHeroInformationInfo m_heroInformationInfo
			{
				get
				{
					return this.m_owner.m_heroInformationInfo;
				}
				set
				{
					this.m_owner.m_heroInformationInfo = value;
				}
			}

			// Token: 0x17002CCA RID: 11466
			// (get) Token: 0x0600E680 RID: 59008 RVA: 0x003DD7F4 File Offset: 0x003DB9F4
			// (set) Token: 0x0600E681 RID: 59009 RVA: 0x003DD804 File Offset: 0x003DBA04
			public List<FettersInformationLifeItemUIController> biographyCtrlList
			{
				get
				{
					return this.m_owner.biographyCtrlList;
				}
				set
				{
					this.m_owner.biographyCtrlList = value;
				}
			}

			// Token: 0x17002CCB RID: 11467
			// (get) Token: 0x0600E682 RID: 59010 RVA: 0x003DD814 File Offset: 0x003DBA14
			// (set) Token: 0x0600E683 RID: 59011 RVA: 0x003DD824 File Offset: 0x003DBA24
			public List<FettersInformationVoiceItemUIController> voiceCtrlList
			{
				get
				{
					return this.m_owner.voiceCtrlList;
				}
				set
				{
					this.m_owner.voiceCtrlList = value;
				}
			}

			// Token: 0x17002CCC RID: 11468
			// (get) Token: 0x0600E684 RID: 59012 RVA: 0x003DD834 File Offset: 0x003DBA34
			// (set) Token: 0x0600E685 RID: 59013 RVA: 0x003DD844 File Offset: 0x003DBA44
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

			// Token: 0x0600E686 RID: 59014 RVA: 0x003DD854 File Offset: 0x003DBA54
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0600E687 RID: 59015 RVA: 0x003DD864 File Offset: 0x003DBA64
			public void OnDisable()
			{
				this.m_owner.OnDisable();
			}

			// Token: 0x0600E688 RID: 59016 RVA: 0x003DD874 File Offset: 0x003DBA74
			public void UpdateHeroLifeList()
			{
				this.m_owner.UpdateHeroLifeList();
			}

			// Token: 0x0600E689 RID: 59017 RVA: 0x003DD884 File Offset: 0x003DBA84
			public void UpdateHeroVoiceList()
			{
				this.m_owner.UpdateHeroVoiceList();
			}

			// Token: 0x0600E68A RID: 59018 RVA: 0x003DD894 File Offset: 0x003DBA94
			public void UpdateToggleNewTag()
			{
				this.m_owner.UpdateToggleNewTag();
			}

			// Token: 0x0600E68B RID: 59019 RVA: 0x003DD8A4 File Offset: 0x003DBAA4
			public void OnPeofermanceVoiceButtonClick(FettersInformationVoiceItemUIController ctrl)
			{
				this.m_owner.OnPeofermanceVoiceButtonClick(ctrl);
			}

			// Token: 0x0600E68C RID: 59020 RVA: 0x003DD8B4 File Offset: 0x003DBAB4
			public void OnReturnButtonClick()
			{
				this.m_owner.OnReturnButtonClick();
			}

			// Token: 0x0600E68D RID: 59021 RVA: 0x003DD8C4 File Offset: 0x003DBAC4
			public void OnToggleLifeValueChange(bool isOn)
			{
				this.m_owner.OnToggleLifeValueChange(isOn);
			}

			// Token: 0x0600E68E RID: 59022 RVA: 0x003DD8D4 File Offset: 0x003DBAD4
			public void OnToggleVoiceValueChange(bool isOn)
			{
				this.m_owner.OnToggleVoiceValueChange(isOn);
			}

			// Token: 0x0600E68F RID: 59023 RVA: 0x003DD8E4 File Offset: 0x003DBAE4
			public void ResetScrollViewPosition()
			{
				this.m_owner.ResetScrollViewPosition();
			}

			// Token: 0x04008B04 RID: 35588
			private FettersInformationUIController m_owner;
		}
	}
}
