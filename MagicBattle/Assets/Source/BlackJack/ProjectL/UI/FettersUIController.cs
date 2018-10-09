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
	// Token: 0x02000C8B RID: 3211
	[HotFix]
	public class FettersUIController : UIControllerBase
	{
		// Token: 0x0600E72A RID: 59178 RVA: 0x003DF148 File Offset: 0x003DD348
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
			this.m_helpButton.onClick.AddListener(new UnityAction(this.OnHelpButtonClick));
			this.m_informationButton.onClick.AddListener(new UnityAction(this.OnInformationButtonClick));
			this.m_fettersButton.onClick.AddListener(new UnityAction(this.OnFettersButtonClick));
			this.m_heroCharUIController = GameObjectUtility.AddControllerToGameObject<HeroCharUIController>(this.m_charGameObjectRoot);
			base.gameObject.SetActive(true);
			this.m_playerContext = (GameManager.Instance.PlayerContext as ProjectLPlayerContext);
			this.m_configDataLoader = (GameManager.Instance.ConfigDataLoader as IConfigDataLoader);
			UIUtility.MarginAdjustHorizontal(this.m_marginTransform);
		}

		// Token: 0x0600E72B RID: 59179 RVA: 0x003DF274 File Offset: 0x003DD474
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

		// Token: 0x0600E72C RID: 59180 RVA: 0x003DF2D4 File Offset: 0x003DD4D4
		public void UpdateViewInFetters(Hero hero)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateViewInFettersHero_hotfix != null)
			{
				this.m_UpdateViewInFettersHero_hotfix.call(new object[]
				{
					this,
					hero
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GameObjectUtility.DestroyChildren(this.m_scrollViewContent);
			this.m_hero = hero;
			List<Hero> list = new List<Hero>();
			list.AddRange(this.m_playerContext.GetHeros());
			list.Sort(new Comparison<Hero>(this.HeroListItemCompare));
			list.Remove(this.m_hero);
			foreach (Hero hero2 in list)
			{
				GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.m_listItemPrefab);
				gameObject.name = string.Format("Hero_{0}", hero2.HeroInfo.ID);
				PrefabControllerCreater.CreateAllControllers(gameObject);
				FettersHeroListItemUIController component = gameObject.GetComponent<FettersHeroListItemUIController>();
				component.EventOnClick += this.OnListItemClick;
				component.InitFettersHeroListItem(hero2);
				gameObject.transform.SetParent(this.m_scrollViewContent.transform, false);
				this.m_heroCtrlList.Add(component);
			}
			if (this.m_heroCharUIController.GetCharImageInfo() != this.m_hero.HeroInfo.GetCharImageInfo(this.m_hero.StarLevel))
			{
				this.m_heroCharUIController.CreateGraphic(this.m_hero, HeroCharUIController.PerformanceState.All, true, null);
				this.m_heroCharUIController.PlayAnimation("idle_Normal", true);
			}
			this.m_favorabilityTotalValueText.text = this.m_hero.FavorabilityLevel.ToString();
			int num = 0;
			int num2 = 0;
			ConfigDataHeroInformationInfo informationInfo = this.m_hero.HeroInfo.m_informationInfo;
			if (informationInfo != null && informationInfo.HeroFetters_ID.Count > 0)
			{
				foreach (int key in informationInfo.HeroFetters_ID)
				{
					ConfigDataHeroFetterInfo configDataHeroFetterInfo = this.m_configDataLoader.GetConfigDataHeroFetterInfo(key);
					num += configDataHeroFetterInfo.MaxLevel;
				}
				foreach (KeyValuePair<int, int> keyValuePair in this.m_hero.Fetters)
				{
					num2 += keyValuePair.Value;
				}
				if (num == 0)
				{
					this.m_fettersButtonPercentText.text = "0%";
				}
				else
				{
					this.m_fettersButtonPercentText.text = num2 * 100 / num + "%";
				}
			}
			else
			{
				this.m_fettersButtonPercentText.text = "0%";
			}
			this.m_fettersButtonNewImage.SetActive(this.m_playerContext.IsHeroFetterHasNewOrLevelUp(this.m_hero));
			this.m_informationButtonNewImage.SetActive(FettersInformationUIController.HaveNewInfomation(informationInfo));
			if (this.isFirstIn)
			{
				this.m_commonUIStateCtrl.SetToUIState("Show", false, true);
				this.isFirstIn = false;
			}
		}

		// Token: 0x0600E72D RID: 59181 RVA: 0x003DF650 File Offset: 0x003DD850
		private void OnListItemClick(Hero hero)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnListItemClickHero_hotfix != null)
			{
				this.m_OnListItemClickHero_hotfix.call(new object[]
				{
					this,
					hero
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnListItemClick != null)
			{
				this.EventOnListItemClick(hero);
			}
		}

		// Token: 0x0600E72E RID: 59182 RVA: 0x003DF6D8 File Offset: 0x003DD8D8
		private int HeroListItemCompare(Hero h1, Hero h2)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HeroListItemCompareHeroHero_hotfix != null)
			{
				return Convert.ToInt32(this.m_HeroListItemCompareHeroHero_hotfix.call(new object[]
				{
					this,
					h1,
					h2
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = h2.FavorabilityLevel - h1.FavorabilityLevel;
			if (num != 0)
			{
				return num;
			}
			int num2 = h2.Level - h1.Level;
			if (num2 != 0)
			{
				return num2;
			}
			int num3 = h2.StarLevel - h1.StarLevel;
			if (num3 != 0)
			{
				return num3;
			}
			return h1.HeroId - h2.HeroId;
		}

		// Token: 0x0600E72F RID: 59183 RVA: 0x003DF7B4 File Offset: 0x003DD9B4
		public void GoToInformationPanel(bool isGotoOrReturn)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GoToInformationPanelBoolean_hotfix != null)
			{
				this.m_GoToInformationPanelBoolean_hotfix.call(new object[]
				{
					this,
					isGotoOrReturn
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (isGotoOrReturn)
			{
				this.m_infoPanelCommonUIStateCtrl.SetToUIState("Out", false, true);
			}
			else
			{
				this.m_infoPanelCommonUIStateCtrl.SetToUIState("In", false, true);
			}
		}

		// Token: 0x0600E730 RID: 59184 RVA: 0x003DF854 File Offset: 0x003DDA54
		public void PlayHeroPerformance(int heroPerformanceId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayHeroPerformanceInt32_hotfix != null)
			{
				this.m_PlayHeroPerformanceInt32_hotfix.call(new object[]
				{
					this,
					heroPerformanceId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_heroCharUIController.PlayOneSpecifiedPerformance(heroPerformanceId);
		}

		// Token: 0x0600E731 RID: 59185 RVA: 0x003DF8D4 File Offset: 0x003DDAD4
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
				this.EventOnReturn();
			}
			this.isFirstIn = true;
			this.ResetScrollViewPosition();
		}

		// Token: 0x0600E732 RID: 59186 RVA: 0x003DF958 File Offset: 0x003DDB58
		private void OnHelpButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnHelpButtonClick_hotfix != null)
			{
				this.m_OnHelpButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnShowHelp != null)
			{
				this.EventOnShowHelp();
			}
		}

		// Token: 0x0600E733 RID: 59187 RVA: 0x003DF9D0 File Offset: 0x003DDBD0
		private void OnInformationButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnInformationButtonClick_hotfix != null)
			{
				this.m_OnInformationButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnInformationButtonClick != null)
			{
				this.EventOnInformationButtonClick(this.m_hero);
			}
			this.ResetScrollViewPosition();
		}

		// Token: 0x0600E734 RID: 59188 RVA: 0x003DFA54 File Offset: 0x003DDC54
		private void OnFettersButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnFettersButtonClick_hotfix != null)
			{
				this.m_OnFettersButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnFettersButtonClick != null)
			{
				this.EventOnFettersButtonClick(this.m_hero);
			}
			this.ResetScrollViewPosition();
		}

		// Token: 0x0600E735 RID: 59189 RVA: 0x003DFAD8 File Offset: 0x003DDCD8
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
			this.m_scrollRect.normalizedPosition = Vector2.one;
		}

		// Token: 0x140002F1 RID: 753
		// (add) Token: 0x0600E736 RID: 59190 RVA: 0x003DFB48 File Offset: 0x003DDD48
		// (remove) Token: 0x0600E737 RID: 59191 RVA: 0x003DFBE4 File Offset: 0x003DDDE4
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

		// Token: 0x140002F2 RID: 754
		// (add) Token: 0x0600E738 RID: 59192 RVA: 0x003DFC80 File Offset: 0x003DDE80
		// (remove) Token: 0x0600E739 RID: 59193 RVA: 0x003DFD1C File Offset: 0x003DDF1C
		public event Action EventOnShowHelp
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnShowHelpAction_hotfix != null)
				{
					this.m_add_EventOnShowHelpAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnShowHelp;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnShowHelp, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnShowHelpAction_hotfix != null)
				{
					this.m_remove_EventOnShowHelpAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnShowHelp;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnShowHelp, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140002F3 RID: 755
		// (add) Token: 0x0600E73A RID: 59194 RVA: 0x003DFDB8 File Offset: 0x003DDFB8
		// (remove) Token: 0x0600E73B RID: 59195 RVA: 0x003DFE54 File Offset: 0x003DE054
		public event Action<Hero> EventOnListItemClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnListItemClickAction`1_hotfix != null)
				{
					this.m_add_EventOnListItemClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<Hero> action = this.EventOnListItemClick;
				Action<Hero> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<Hero>>(ref this.EventOnListItemClick, (Action<Hero>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnListItemClickAction`1_hotfix != null)
				{
					this.m_remove_EventOnListItemClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<Hero> action = this.EventOnListItemClick;
				Action<Hero> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<Hero>>(ref this.EventOnListItemClick, (Action<Hero>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140002F4 RID: 756
		// (add) Token: 0x0600E73C RID: 59196 RVA: 0x003DFEF0 File Offset: 0x003DE0F0
		// (remove) Token: 0x0600E73D RID: 59197 RVA: 0x003DFF8C File Offset: 0x003DE18C
		public event Action<Hero> EventOnFettersButtonClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnFettersButtonClickAction`1_hotfix != null)
				{
					this.m_add_EventOnFettersButtonClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<Hero> action = this.EventOnFettersButtonClick;
				Action<Hero> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<Hero>>(ref this.EventOnFettersButtonClick, (Action<Hero>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnFettersButtonClickAction`1_hotfix != null)
				{
					this.m_remove_EventOnFettersButtonClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<Hero> action = this.EventOnFettersButtonClick;
				Action<Hero> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<Hero>>(ref this.EventOnFettersButtonClick, (Action<Hero>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140002F5 RID: 757
		// (add) Token: 0x0600E73E RID: 59198 RVA: 0x003E0028 File Offset: 0x003DE228
		// (remove) Token: 0x0600E73F RID: 59199 RVA: 0x003E00C4 File Offset: 0x003DE2C4
		public event Action<Hero> EventOnInformationButtonClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnInformationButtonClickAction`1_hotfix != null)
				{
					this.m_add_EventOnInformationButtonClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<Hero> action = this.EventOnInformationButtonClick;
				Action<Hero> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<Hero>>(ref this.EventOnInformationButtonClick, (Action<Hero>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnInformationButtonClickAction`1_hotfix != null)
				{
					this.m_remove_EventOnInformationButtonClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<Hero> action = this.EventOnInformationButtonClick;
				Action<Hero> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<Hero>>(ref this.EventOnInformationButtonClick, (Action<Hero>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17002CE0 RID: 11488
		// (get) Token: 0x0600E740 RID: 59200 RVA: 0x003E0160 File Offset: 0x003DE360
		// (set) Token: 0x0600E741 RID: 59201 RVA: 0x003E0180 File Offset: 0x003DE380
		[DoNotToLua]
		public new FettersUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new FettersUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600E742 RID: 59202 RVA: 0x003E018C File Offset: 0x003DE38C
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0600E743 RID: 59203 RVA: 0x003E0198 File Offset: 0x003DE398
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0600E744 RID: 59204 RVA: 0x003E01A0 File Offset: 0x003DE3A0
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0600E745 RID: 59205 RVA: 0x003E01A8 File Offset: 0x003DE3A8
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0600E746 RID: 59206 RVA: 0x003E01BC File Offset: 0x003DE3BC
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0600E747 RID: 59207 RVA: 0x003E01C4 File Offset: 0x003DE3C4
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0600E748 RID: 59208 RVA: 0x003E01D0 File Offset: 0x003DE3D0
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0600E749 RID: 59209 RVA: 0x003E01DC File Offset: 0x003DE3DC
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0600E74A RID: 59210 RVA: 0x003E01E8 File Offset: 0x003DE3E8
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0600E74B RID: 59211 RVA: 0x003E01F4 File Offset: 0x003DE3F4
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0600E74C RID: 59212 RVA: 0x003E0200 File Offset: 0x003DE400
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0600E74D RID: 59213 RVA: 0x003E020C File Offset: 0x003DE40C
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0600E74E RID: 59214 RVA: 0x003E0218 File Offset: 0x003DE418
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0600E74F RID: 59215 RVA: 0x003E0224 File Offset: 0x003DE424
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0600E750 RID: 59216 RVA: 0x003E0230 File Offset: 0x003DE430
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600E751 RID: 59217 RVA: 0x003E0238 File Offset: 0x003DE438
		private void __callDele_EventOnReturn()
		{
			Action eventOnReturn = this.EventOnReturn;
			if (eventOnReturn != null)
			{
				eventOnReturn();
			}
		}

		// Token: 0x0600E752 RID: 59218 RVA: 0x003E0258 File Offset: 0x003DE458
		private void __clearDele_EventOnReturn()
		{
			this.EventOnReturn = null;
		}

		// Token: 0x0600E753 RID: 59219 RVA: 0x003E0264 File Offset: 0x003DE464
		private void __callDele_EventOnShowHelp()
		{
			Action eventOnShowHelp = this.EventOnShowHelp;
			if (eventOnShowHelp != null)
			{
				eventOnShowHelp();
			}
		}

		// Token: 0x0600E754 RID: 59220 RVA: 0x003E0284 File Offset: 0x003DE484
		private void __clearDele_EventOnShowHelp()
		{
			this.EventOnShowHelp = null;
		}

		// Token: 0x0600E755 RID: 59221 RVA: 0x003E0290 File Offset: 0x003DE490
		private void __callDele_EventOnListItemClick(Hero obj)
		{
			Action<Hero> eventOnListItemClick = this.EventOnListItemClick;
			if (eventOnListItemClick != null)
			{
				eventOnListItemClick(obj);
			}
		}

		// Token: 0x0600E756 RID: 59222 RVA: 0x003E02B4 File Offset: 0x003DE4B4
		private void __clearDele_EventOnListItemClick(Hero obj)
		{
			this.EventOnListItemClick = null;
		}

		// Token: 0x0600E757 RID: 59223 RVA: 0x003E02C0 File Offset: 0x003DE4C0
		private void __callDele_EventOnFettersButtonClick(Hero obj)
		{
			Action<Hero> eventOnFettersButtonClick = this.EventOnFettersButtonClick;
			if (eventOnFettersButtonClick != null)
			{
				eventOnFettersButtonClick(obj);
			}
		}

		// Token: 0x0600E758 RID: 59224 RVA: 0x003E02E4 File Offset: 0x003DE4E4
		private void __clearDele_EventOnFettersButtonClick(Hero obj)
		{
			this.EventOnFettersButtonClick = null;
		}

		// Token: 0x0600E759 RID: 59225 RVA: 0x003E02F0 File Offset: 0x003DE4F0
		private void __callDele_EventOnInformationButtonClick(Hero obj)
		{
			Action<Hero> eventOnInformationButtonClick = this.EventOnInformationButtonClick;
			if (eventOnInformationButtonClick != null)
			{
				eventOnInformationButtonClick(obj);
			}
		}

		// Token: 0x0600E75A RID: 59226 RVA: 0x003E0314 File Offset: 0x003DE514
		private void __clearDele_EventOnInformationButtonClick(Hero obj)
		{
			this.EventOnInformationButtonClick = null;
		}

		// Token: 0x0600E75B RID: 59227 RVA: 0x003E0320 File Offset: 0x003DE520
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
					this.m_UpdateViewInFettersHero_hotfix = (luaObj.RawGet("UpdateViewInFetters") as LuaFunction);
					this.m_OnListItemClickHero_hotfix = (luaObj.RawGet("OnListItemClick") as LuaFunction);
					this.m_HeroListItemCompareHeroHero_hotfix = (luaObj.RawGet("HeroListItemCompare") as LuaFunction);
					this.m_GoToInformationPanelBoolean_hotfix = (luaObj.RawGet("GoToInformationPanel") as LuaFunction);
					this.m_PlayHeroPerformanceInt32_hotfix = (luaObj.RawGet("PlayHeroPerformance") as LuaFunction);
					this.m_OnReturnButtonClick_hotfix = (luaObj.RawGet("OnReturnButtonClick") as LuaFunction);
					this.m_OnHelpButtonClick_hotfix = (luaObj.RawGet("OnHelpButtonClick") as LuaFunction);
					this.m_OnInformationButtonClick_hotfix = (luaObj.RawGet("OnInformationButtonClick") as LuaFunction);
					this.m_OnFettersButtonClick_hotfix = (luaObj.RawGet("OnFettersButtonClick") as LuaFunction);
					this.m_ResetScrollViewPosition_hotfix = (luaObj.RawGet("ResetScrollViewPosition") as LuaFunction);
					this.m_add_EventOnReturnAction_hotfix = (luaObj.RawGet("add_EventOnReturn") as LuaFunction);
					this.m_remove_EventOnReturnAction_hotfix = (luaObj.RawGet("remove_EventOnReturn") as LuaFunction);
					this.m_add_EventOnShowHelpAction_hotfix = (luaObj.RawGet("add_EventOnShowHelp") as LuaFunction);
					this.m_remove_EventOnShowHelpAction_hotfix = (luaObj.RawGet("remove_EventOnShowHelp") as LuaFunction);
					this.m_add_EventOnListItemClickAction`1_hotfix = (luaObj.RawGet("add_EventOnListItemClick") as LuaFunction);
					this.m_remove_EventOnListItemClickAction`1_hotfix = (luaObj.RawGet("remove_EventOnListItemClick") as LuaFunction);
					this.m_add_EventOnFettersButtonClickAction`1_hotfix = (luaObj.RawGet("add_EventOnFettersButtonClick") as LuaFunction);
					this.m_remove_EventOnFettersButtonClickAction`1_hotfix = (luaObj.RawGet("remove_EventOnFettersButtonClick") as LuaFunction);
					this.m_add_EventOnInformationButtonClickAction`1_hotfix = (luaObj.RawGet("add_EventOnInformationButtonClick") as LuaFunction);
					this.m_remove_EventOnInformationButtonClickAction`1_hotfix = (luaObj.RawGet("remove_EventOnInformationButtonClick") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600E75C RID: 59228 RVA: 0x003E05F8 File Offset: 0x003DE7F8
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(FettersUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04008B3F RID: 35647
		[AutoBind("./Margin", AutoBindAttribute.InitState.NotInit, false)]
		private RectTransform m_marginTransform;

		// Token: 0x04008B40 RID: 35648
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_commonUIStateCtrl;

		// Token: 0x04008B41 RID: 35649
		[AutoBind("./ReturnButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_returnButton;

		// Token: 0x04008B42 RID: 35650
		[AutoBind("./HelpButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_helpButton;

		// Token: 0x04008B43 RID: 35651
		[AutoBind("./Margin/Fetters", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_fettersButton;

		// Token: 0x04008B44 RID: 35652
		[AutoBind("./Margin/Fetters/NewImage", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_fettersButtonNewImage;

		// Token: 0x04008B45 RID: 35653
		[AutoBind("./Margin/Fetters/PercentText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_fettersButtonPercentText;

		// Token: 0x04008B46 RID: 35654
		[AutoBind("./Margin/Information", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_informationButton;

		// Token: 0x04008B47 RID: 35655
		[AutoBind("./Margin/Information/NewImage", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_informationButtonNewImage;

		// Token: 0x04008B48 RID: 35656
		[AutoBind("./Favorability/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_favorabilityTotalValueText;

		// Token: 0x04008B49 RID: 35657
		[AutoBind("./HeroCharPanel", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_charGameObjectRoot;

		// Token: 0x04008B4A RID: 35658
		[AutoBind("./Margin/HeroListScrollView", AutoBindAttribute.InitState.NotInit, false)]
		private ScrollRect m_scrollRect;

		// Token: 0x04008B4B RID: 35659
		[AutoBind("./Margin/HeroListScrollView/Viewport/Content", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_scrollViewContent;

		// Token: 0x04008B4C RID: 35660
		[AutoBind("./Prefab/ListItem", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_listItemPrefab;

		// Token: 0x04008B4D RID: 35661
		[AutoBind("./ChangeInfoPanel", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_infoPanelCommonUIStateCtrl;

		// Token: 0x04008B4E RID: 35662
		private List<FettersHeroListItemUIController> m_heroCtrlList = new List<FettersHeroListItemUIController>();

		// Token: 0x04008B4F RID: 35663
		private HeroCharUIController m_heroCharUIController;

		// Token: 0x04008B50 RID: 35664
		private Hero m_hero;

		// Token: 0x04008B51 RID: 35665
		private ProjectLPlayerContext m_playerContext;

		// Token: 0x04008B52 RID: 35666
		private IConfigDataLoader m_configDataLoader;

		// Token: 0x04008B53 RID: 35667
		private bool isFirstIn = true;

		// Token: 0x04008B54 RID: 35668
		[DoNotToLua]
		private FettersUIController.LuaExportHelper luaExportHelper;

		// Token: 0x04008B55 RID: 35669
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04008B56 RID: 35670
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04008B57 RID: 35671
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x04008B58 RID: 35672
		private LuaFunction m_OnDisable_hotfix;

		// Token: 0x04008B59 RID: 35673
		private LuaFunction m_UpdateViewInFettersHero_hotfix;

		// Token: 0x04008B5A RID: 35674
		private LuaFunction m_OnListItemClickHero_hotfix;

		// Token: 0x04008B5B RID: 35675
		private LuaFunction m_HeroListItemCompareHeroHero_hotfix;

		// Token: 0x04008B5C RID: 35676
		private LuaFunction m_GoToInformationPanelBoolean_hotfix;

		// Token: 0x04008B5D RID: 35677
		private LuaFunction m_PlayHeroPerformanceInt32_hotfix;

		// Token: 0x04008B5E RID: 35678
		private LuaFunction m_OnReturnButtonClick_hotfix;

		// Token: 0x04008B5F RID: 35679
		private LuaFunction m_OnHelpButtonClick_hotfix;

		// Token: 0x04008B60 RID: 35680
		private LuaFunction m_OnInformationButtonClick_hotfix;

		// Token: 0x04008B61 RID: 35681
		private LuaFunction m_OnFettersButtonClick_hotfix;

		// Token: 0x04008B62 RID: 35682
		private LuaFunction m_ResetScrollViewPosition_hotfix;

		// Token: 0x04008B63 RID: 35683
		private LuaFunction m_add_EventOnReturnAction_hotfix;

		// Token: 0x04008B64 RID: 35684
		private LuaFunction m_remove_EventOnReturnAction_hotfix;

		// Token: 0x04008B65 RID: 35685
		private LuaFunction m_add_EventOnShowHelpAction_hotfix;

		// Token: 0x04008B66 RID: 35686
		private LuaFunction m_remove_EventOnShowHelpAction_hotfix;

		// Token: 0x04008B67 RID: 35687
		private LuaFunction m_add_EventOnListItemClickAction;

		// Token: 0x04008B68 RID: 35688
		private LuaFunction m_remove_EventOnListItemClickAction;

		// Token: 0x04008B69 RID: 35689
		private LuaFunction m_add_EventOnFettersButtonClickAction;

		// Token: 0x04008B6A RID: 35690
		private LuaFunction m_remove_EventOnFettersButtonClickAction;

		// Token: 0x04008B6B RID: 35691
		private LuaFunction m_add_EventOnInformationButtonClickAction;

		// Token: 0x04008B6C RID: 35692
		private LuaFunction m_remove_EventOnInformationButtonClickAction;

		// Token: 0x02000C8C RID: 3212
		public new class LuaExportHelper
		{
			// Token: 0x0600E75D RID: 59229 RVA: 0x003E0660 File Offset: 0x003DE860
			public LuaExportHelper(FettersUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600E75E RID: 59230 RVA: 0x003E0670 File Offset: 0x003DE870
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0600E75F RID: 59231 RVA: 0x003E0680 File Offset: 0x003DE880
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0600E760 RID: 59232 RVA: 0x003E0690 File Offset: 0x003DE890
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600E761 RID: 59233 RVA: 0x003E06A0 File Offset: 0x003DE8A0
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600E762 RID: 59234 RVA: 0x003E06B8 File Offset: 0x003DE8B8
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0600E763 RID: 59235 RVA: 0x003E06C8 File Offset: 0x003DE8C8
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0600E764 RID: 59236 RVA: 0x003E06D8 File Offset: 0x003DE8D8
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0600E765 RID: 59237 RVA: 0x003E06E8 File Offset: 0x003DE8E8
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0600E766 RID: 59238 RVA: 0x003E06F8 File Offset: 0x003DE8F8
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0600E767 RID: 59239 RVA: 0x003E0708 File Offset: 0x003DE908
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0600E768 RID: 59240 RVA: 0x003E0718 File Offset: 0x003DE918
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0600E769 RID: 59241 RVA: 0x003E0728 File Offset: 0x003DE928
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0600E76A RID: 59242 RVA: 0x003E0738 File Offset: 0x003DE938
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0600E76B RID: 59243 RVA: 0x003E0748 File Offset: 0x003DE948
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0600E76C RID: 59244 RVA: 0x003E0758 File Offset: 0x003DE958
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x0600E76D RID: 59245 RVA: 0x003E0768 File Offset: 0x003DE968
			public void __callDele_EventOnReturn()
			{
				this.m_owner.__callDele_EventOnReturn();
			}

			// Token: 0x0600E76E RID: 59246 RVA: 0x003E0778 File Offset: 0x003DE978
			public void __clearDele_EventOnReturn()
			{
				this.m_owner.__clearDele_EventOnReturn();
			}

			// Token: 0x0600E76F RID: 59247 RVA: 0x003E0788 File Offset: 0x003DE988
			public void __callDele_EventOnShowHelp()
			{
				this.m_owner.__callDele_EventOnShowHelp();
			}

			// Token: 0x0600E770 RID: 59248 RVA: 0x003E0798 File Offset: 0x003DE998
			public void __clearDele_EventOnShowHelp()
			{
				this.m_owner.__clearDele_EventOnShowHelp();
			}

			// Token: 0x0600E771 RID: 59249 RVA: 0x003E07A8 File Offset: 0x003DE9A8
			public void __callDele_EventOnListItemClick(Hero obj)
			{
				this.m_owner.__callDele_EventOnListItemClick(obj);
			}

			// Token: 0x0600E772 RID: 59250 RVA: 0x003E07B8 File Offset: 0x003DE9B8
			public void __clearDele_EventOnListItemClick(Hero obj)
			{
				this.m_owner.__clearDele_EventOnListItemClick(obj);
			}

			// Token: 0x0600E773 RID: 59251 RVA: 0x003E07C8 File Offset: 0x003DE9C8
			public void __callDele_EventOnFettersButtonClick(Hero obj)
			{
				this.m_owner.__callDele_EventOnFettersButtonClick(obj);
			}

			// Token: 0x0600E774 RID: 59252 RVA: 0x003E07D8 File Offset: 0x003DE9D8
			public void __clearDele_EventOnFettersButtonClick(Hero obj)
			{
				this.m_owner.__clearDele_EventOnFettersButtonClick(obj);
			}

			// Token: 0x0600E775 RID: 59253 RVA: 0x003E07E8 File Offset: 0x003DE9E8
			public void __callDele_EventOnInformationButtonClick(Hero obj)
			{
				this.m_owner.__callDele_EventOnInformationButtonClick(obj);
			}

			// Token: 0x0600E776 RID: 59254 RVA: 0x003E07F8 File Offset: 0x003DE9F8
			public void __clearDele_EventOnInformationButtonClick(Hero obj)
			{
				this.m_owner.__clearDele_EventOnInformationButtonClick(obj);
			}

			// Token: 0x17002CE1 RID: 11489
			// (get) Token: 0x0600E777 RID: 59255 RVA: 0x003E0808 File Offset: 0x003DEA08
			// (set) Token: 0x0600E778 RID: 59256 RVA: 0x003E0818 File Offset: 0x003DEA18
			public RectTransform m_marginTransform
			{
				get
				{
					return this.m_owner.m_marginTransform;
				}
				set
				{
					this.m_owner.m_marginTransform = value;
				}
			}

			// Token: 0x17002CE2 RID: 11490
			// (get) Token: 0x0600E779 RID: 59257 RVA: 0x003E0828 File Offset: 0x003DEA28
			// (set) Token: 0x0600E77A RID: 59258 RVA: 0x003E0838 File Offset: 0x003DEA38
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

			// Token: 0x17002CE3 RID: 11491
			// (get) Token: 0x0600E77B RID: 59259 RVA: 0x003E0848 File Offset: 0x003DEA48
			// (set) Token: 0x0600E77C RID: 59260 RVA: 0x003E0858 File Offset: 0x003DEA58
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

			// Token: 0x17002CE4 RID: 11492
			// (get) Token: 0x0600E77D RID: 59261 RVA: 0x003E0868 File Offset: 0x003DEA68
			// (set) Token: 0x0600E77E RID: 59262 RVA: 0x003E0878 File Offset: 0x003DEA78
			public Button m_helpButton
			{
				get
				{
					return this.m_owner.m_helpButton;
				}
				set
				{
					this.m_owner.m_helpButton = value;
				}
			}

			// Token: 0x17002CE5 RID: 11493
			// (get) Token: 0x0600E77F RID: 59263 RVA: 0x003E0888 File Offset: 0x003DEA88
			// (set) Token: 0x0600E780 RID: 59264 RVA: 0x003E0898 File Offset: 0x003DEA98
			public Button m_fettersButton
			{
				get
				{
					return this.m_owner.m_fettersButton;
				}
				set
				{
					this.m_owner.m_fettersButton = value;
				}
			}

			// Token: 0x17002CE6 RID: 11494
			// (get) Token: 0x0600E781 RID: 59265 RVA: 0x003E08A8 File Offset: 0x003DEAA8
			// (set) Token: 0x0600E782 RID: 59266 RVA: 0x003E08B8 File Offset: 0x003DEAB8
			public GameObject m_fettersButtonNewImage
			{
				get
				{
					return this.m_owner.m_fettersButtonNewImage;
				}
				set
				{
					this.m_owner.m_fettersButtonNewImage = value;
				}
			}

			// Token: 0x17002CE7 RID: 11495
			// (get) Token: 0x0600E783 RID: 59267 RVA: 0x003E08C8 File Offset: 0x003DEAC8
			// (set) Token: 0x0600E784 RID: 59268 RVA: 0x003E08D8 File Offset: 0x003DEAD8
			public Text m_fettersButtonPercentText
			{
				get
				{
					return this.m_owner.m_fettersButtonPercentText;
				}
				set
				{
					this.m_owner.m_fettersButtonPercentText = value;
				}
			}

			// Token: 0x17002CE8 RID: 11496
			// (get) Token: 0x0600E785 RID: 59269 RVA: 0x003E08E8 File Offset: 0x003DEAE8
			// (set) Token: 0x0600E786 RID: 59270 RVA: 0x003E08F8 File Offset: 0x003DEAF8
			public Button m_informationButton
			{
				get
				{
					return this.m_owner.m_informationButton;
				}
				set
				{
					this.m_owner.m_informationButton = value;
				}
			}

			// Token: 0x17002CE9 RID: 11497
			// (get) Token: 0x0600E787 RID: 59271 RVA: 0x003E0908 File Offset: 0x003DEB08
			// (set) Token: 0x0600E788 RID: 59272 RVA: 0x003E0918 File Offset: 0x003DEB18
			public GameObject m_informationButtonNewImage
			{
				get
				{
					return this.m_owner.m_informationButtonNewImage;
				}
				set
				{
					this.m_owner.m_informationButtonNewImage = value;
				}
			}

			// Token: 0x17002CEA RID: 11498
			// (get) Token: 0x0600E789 RID: 59273 RVA: 0x003E0928 File Offset: 0x003DEB28
			// (set) Token: 0x0600E78A RID: 59274 RVA: 0x003E0938 File Offset: 0x003DEB38
			public Text m_favorabilityTotalValueText
			{
				get
				{
					return this.m_owner.m_favorabilityTotalValueText;
				}
				set
				{
					this.m_owner.m_favorabilityTotalValueText = value;
				}
			}

			// Token: 0x17002CEB RID: 11499
			// (get) Token: 0x0600E78B RID: 59275 RVA: 0x003E0948 File Offset: 0x003DEB48
			// (set) Token: 0x0600E78C RID: 59276 RVA: 0x003E0958 File Offset: 0x003DEB58
			public GameObject m_charGameObjectRoot
			{
				get
				{
					return this.m_owner.m_charGameObjectRoot;
				}
				set
				{
					this.m_owner.m_charGameObjectRoot = value;
				}
			}

			// Token: 0x17002CEC RID: 11500
			// (get) Token: 0x0600E78D RID: 59277 RVA: 0x003E0968 File Offset: 0x003DEB68
			// (set) Token: 0x0600E78E RID: 59278 RVA: 0x003E0978 File Offset: 0x003DEB78
			public ScrollRect m_scrollRect
			{
				get
				{
					return this.m_owner.m_scrollRect;
				}
				set
				{
					this.m_owner.m_scrollRect = value;
				}
			}

			// Token: 0x17002CED RID: 11501
			// (get) Token: 0x0600E78F RID: 59279 RVA: 0x003E0988 File Offset: 0x003DEB88
			// (set) Token: 0x0600E790 RID: 59280 RVA: 0x003E0998 File Offset: 0x003DEB98
			public GameObject m_scrollViewContent
			{
				get
				{
					return this.m_owner.m_scrollViewContent;
				}
				set
				{
					this.m_owner.m_scrollViewContent = value;
				}
			}

			// Token: 0x17002CEE RID: 11502
			// (get) Token: 0x0600E791 RID: 59281 RVA: 0x003E09A8 File Offset: 0x003DEBA8
			// (set) Token: 0x0600E792 RID: 59282 RVA: 0x003E09B8 File Offset: 0x003DEBB8
			public GameObject m_listItemPrefab
			{
				get
				{
					return this.m_owner.m_listItemPrefab;
				}
				set
				{
					this.m_owner.m_listItemPrefab = value;
				}
			}

			// Token: 0x17002CEF RID: 11503
			// (get) Token: 0x0600E793 RID: 59283 RVA: 0x003E09C8 File Offset: 0x003DEBC8
			// (set) Token: 0x0600E794 RID: 59284 RVA: 0x003E09D8 File Offset: 0x003DEBD8
			public CommonUIStateController m_infoPanelCommonUIStateCtrl
			{
				get
				{
					return this.m_owner.m_infoPanelCommonUIStateCtrl;
				}
				set
				{
					this.m_owner.m_infoPanelCommonUIStateCtrl = value;
				}
			}

			// Token: 0x17002CF0 RID: 11504
			// (get) Token: 0x0600E795 RID: 59285 RVA: 0x003E09E8 File Offset: 0x003DEBE8
			// (set) Token: 0x0600E796 RID: 59286 RVA: 0x003E09F8 File Offset: 0x003DEBF8
			public List<FettersHeroListItemUIController> m_heroCtrlList
			{
				get
				{
					return this.m_owner.m_heroCtrlList;
				}
				set
				{
					this.m_owner.m_heroCtrlList = value;
				}
			}

			// Token: 0x17002CF1 RID: 11505
			// (get) Token: 0x0600E797 RID: 59287 RVA: 0x003E0A08 File Offset: 0x003DEC08
			// (set) Token: 0x0600E798 RID: 59288 RVA: 0x003E0A18 File Offset: 0x003DEC18
			public HeroCharUIController m_heroCharUIController
			{
				get
				{
					return this.m_owner.m_heroCharUIController;
				}
				set
				{
					this.m_owner.m_heroCharUIController = value;
				}
			}

			// Token: 0x17002CF2 RID: 11506
			// (get) Token: 0x0600E799 RID: 59289 RVA: 0x003E0A28 File Offset: 0x003DEC28
			// (set) Token: 0x0600E79A RID: 59290 RVA: 0x003E0A38 File Offset: 0x003DEC38
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

			// Token: 0x17002CF3 RID: 11507
			// (get) Token: 0x0600E79B RID: 59291 RVA: 0x003E0A48 File Offset: 0x003DEC48
			// (set) Token: 0x0600E79C RID: 59292 RVA: 0x003E0A58 File Offset: 0x003DEC58
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

			// Token: 0x17002CF4 RID: 11508
			// (get) Token: 0x0600E79D RID: 59293 RVA: 0x003E0A68 File Offset: 0x003DEC68
			// (set) Token: 0x0600E79E RID: 59294 RVA: 0x003E0A78 File Offset: 0x003DEC78
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

			// Token: 0x17002CF5 RID: 11509
			// (get) Token: 0x0600E79F RID: 59295 RVA: 0x003E0A88 File Offset: 0x003DEC88
			// (set) Token: 0x0600E7A0 RID: 59296 RVA: 0x003E0A98 File Offset: 0x003DEC98
			public bool isFirstIn
			{
				get
				{
					return this.m_owner.isFirstIn;
				}
				set
				{
					this.m_owner.isFirstIn = value;
				}
			}

			// Token: 0x0600E7A1 RID: 59297 RVA: 0x003E0AA8 File Offset: 0x003DECA8
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0600E7A2 RID: 59298 RVA: 0x003E0AB8 File Offset: 0x003DECB8
			public void OnDisable()
			{
				this.m_owner.OnDisable();
			}

			// Token: 0x0600E7A3 RID: 59299 RVA: 0x003E0AC8 File Offset: 0x003DECC8
			public void OnListItemClick(Hero hero)
			{
				this.m_owner.OnListItemClick(hero);
			}

			// Token: 0x0600E7A4 RID: 59300 RVA: 0x003E0AD8 File Offset: 0x003DECD8
			public int HeroListItemCompare(Hero h1, Hero h2)
			{
				return this.m_owner.HeroListItemCompare(h1, h2);
			}

			// Token: 0x0600E7A5 RID: 59301 RVA: 0x003E0AE8 File Offset: 0x003DECE8
			public void OnReturnButtonClick()
			{
				this.m_owner.OnReturnButtonClick();
			}

			// Token: 0x0600E7A6 RID: 59302 RVA: 0x003E0AF8 File Offset: 0x003DECF8
			public void OnHelpButtonClick()
			{
				this.m_owner.OnHelpButtonClick();
			}

			// Token: 0x0600E7A7 RID: 59303 RVA: 0x003E0B08 File Offset: 0x003DED08
			public void OnInformationButtonClick()
			{
				this.m_owner.OnInformationButtonClick();
			}

			// Token: 0x0600E7A8 RID: 59304 RVA: 0x003E0B18 File Offset: 0x003DED18
			public void OnFettersButtonClick()
			{
				this.m_owner.OnFettersButtonClick();
			}

			// Token: 0x0600E7A9 RID: 59305 RVA: 0x003E0B28 File Offset: 0x003DED28
			public void ResetScrollViewPosition()
			{
				this.m_owner.ResetScrollViewPosition();
			}

			// Token: 0x04008B6D RID: 35693
			private FettersUIController m_owner;
		}
	}
}
