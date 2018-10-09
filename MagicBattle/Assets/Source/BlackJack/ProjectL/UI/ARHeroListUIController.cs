using System;
using System.Collections.Generic;
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
	// Token: 0x02000B09 RID: 2825
	[HotFix]
	public class ARHeroListUIController : UIControllerBase
	{
		// Token: 0x0600BDC6 RID: 48582 RVA: 0x00351170 File Offset: 0x0034F370
		private ARHeroListUIController()
		{
		}

		// Token: 0x0600BDC7 RID: 48583 RVA: 0x00351190 File Offset: 0x0034F390
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
			if (!this.m_playerContext.IsMe(this.m_playerContext.BusinessCard.UserId))
			{
				return;
			}
			this.m_battleTypeButton.onClick.AddListener(new UnityAction(this.OnBattleTypeShowClick));
			this.m_heroDrawButton.onClick.AddListener(new UnityAction(this.OnHeroDrawShowClick));
			this.m_teamShowButton.onClick.AddListener(new UnityAction(this.OnTeamShowClick));
			this.m_bgButton.onClick.AddListener(new UnityAction(this.OnBGButtonClick));
			for (int i = 0; i < this.m_heroListInfinityGrid.MinAmount; i++)
			{
				GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.m_heroListItemPrefab);
				ARHeroCardUIController arheroCardUIController = GameObjectUtility.AddControllerToGameObject<ARHeroCardUIController>(gameObject);
				arheroCardUIController.EventOnSelectHeroItem += this.OnHeroItemClick;
				gameObject.transform.SetParent(this.m_heroListInfinityGrid.transform, false);
				this.m_arHeroCardUIControllerList.Add(arheroCardUIController);
			}
			InfinityGridLayoutGroup heroListInfinityGrid = this.m_heroListInfinityGrid;
			heroListInfinityGrid.updateChildrenCallback = (InfinityGridLayoutGroup.UpdateChildrenCallbackDelegate)Delegate.Combine(heroListInfinityGrid.updateChildrenCallback, new InfinityGridLayoutGroup.UpdateChildrenCallbackDelegate(this.UpdateInfinityHeroItemCallback));
			List<Hero> heros = this.m_playerContext.GetHeros();
			heros.Sort((Hero left, Hero right) => right.HeroInfo.Rank - left.HeroInfo.Rank);
			foreach (Hero hero in heros)
			{
				ARHeroListUIController.HeroWrap heroWrap = new ARHeroListUIController.HeroWrap();
				heroWrap.hero = hero;
				this.m_heroWrapList.Add(heroWrap);
			}
			if (this.m_heroWrapList.Count > 0)
			{
				this.SelectHero(this.m_heroWrapList[0]);
			}
		}

		// Token: 0x0600BDC8 RID: 48584 RVA: 0x003513F0 File Offset: 0x0034F5F0
		public void SetUITask(UITask task)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetUITaskUITask_hotfix != null)
			{
				this.m_SetUITaskUITask_hotfix.call(new object[]
				{
					this,
					task
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_task = task;
		}

		// Token: 0x0600BDC9 RID: 48585 RVA: 0x00351468 File Offset: 0x0034F668
		protected void SelectHero(ARHeroListUIController.HeroWrap selectHeroWrap)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SelectHeroHeroWrap_hotfix != null)
			{
				this.m_SelectHeroHeroWrap_hotfix.call(new object[]
				{
					this,
					selectHeroWrap
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_selectHeroWrap != null)
			{
				this.m_selectHeroWrap.isSelect = false;
			}
			this.m_selectHeroWrap = selectHeroWrap;
			this.m_selectHeroWrap.isSelect = true;
		}

		// Token: 0x0600BDCA RID: 48586 RVA: 0x00351504 File Offset: 0x0034F704
		public void Show()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Show_hotfix != null)
			{
				this.m_Show_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.gameObject.SetActive(true);
			this.m_arHeroListAnimation.SetToUIState("Show", false, true);
			this.m_heroListInfinityGrid.SetAmount(this.m_heroWrapList.Count);
		}

		// Token: 0x0600BDCB RID: 48587 RVA: 0x00351598 File Offset: 0x0034F798
		public void RefreshSelectHeroShow()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_RefreshSelectHeroShow_hotfix != null)
			{
				this.m_RefreshSelectHeroShow_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (ARHeroCardUIController arheroCardUIController in this.m_arHeroCardUIControllerList)
			{
				arheroCardUIController.RefreshHeroSelect();
			}
		}

		// Token: 0x0600BDCC RID: 48588 RVA: 0x00351648 File Offset: 0x0034F848
		protected void OnBattleTypeShowClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnBattleTypeShowClick_hotfix != null)
			{
				this.m_OnBattleTypeShowClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_selectHeroWrap == null)
			{
				return;
			}
			CommonUIController.Instance.StartShowFadeOutLoadingFadeIn(delegate
			{
				UIIntentReturnable uiintentReturnable = new UIIntentReturnable(this.m_task.CurrentIntent, typeof(ARUITask).Name, null);
				uiintentReturnable.SetParam("Type", 1);
				uiintentReturnable.SetParam("SelectHeroID", this.m_selectHeroWrap.hero.HeroId);
				UIManager.Instance.StartUITask(uiintentReturnable, true, false, delegate
				{
					CommonUIController.Instance.HideFadeOutLoadingFadeIn();
					UITaskBase uitaskBase = UIUtility.FindUITaskWithType(typeof(ARUITask));
					uitaskBase.ReturnFromRedirectPipLineOnLoadAllResCompleted();
				});
			}, FadeStyle.White, -1f, -1f);
		}

		// Token: 0x0600BDCD RID: 48589 RVA: 0x003516D8 File Offset: 0x0034F8D8
		protected void OnHeroDrawShowClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnHeroDrawShowClick_hotfix != null)
			{
				this.m_OnHeroDrawShowClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_selectHeroWrap == null)
			{
				return;
			}
			CommonUIController.Instance.StartShowFadeOutLoadingFadeIn(delegate
			{
				UIIntentReturnable uiintentReturnable = new UIIntentReturnable(this.m_task.CurrentIntent, typeof(ARUITask).Name, null);
				uiintentReturnable.SetParam("Type", 2);
				uiintentReturnable.SetParam("SelectHeroID", this.m_selectHeroWrap.hero.HeroId);
				UIManager.Instance.StartUITask(uiintentReturnable, true, false, delegate
				{
					CommonUIController.Instance.HideFadeOutLoadingFadeIn();
					UITaskBase uitaskBase = UIUtility.FindUITaskWithType(typeof(ARUITask));
					uitaskBase.ReturnFromRedirectPipLineOnLoadAllResCompleted();
				});
			}, FadeStyle.White, -1f, -1f);
		}

		// Token: 0x0600BDCE RID: 48590 RVA: 0x00351768 File Offset: 0x0034F968
		protected void OnTeamShowClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnTeamShowClick_hotfix != null)
			{
				this.m_OnTeamShowClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_playerContext.BusinessCard.SetInfo.Heroes.Count == 0)
			{
				string value = this.m_configDataLoader.GetConfigDataStringTable(13054).Value;
				CommonUIController.Instance.ShowTip(value);
				return;
			}
			CommonUIController.Instance.StartShowFadeOutLoadingFadeIn(delegate
			{
				UIIntentReturnable uiintentReturnable = new UIIntentReturnable(this.m_task.CurrentIntent, typeof(ARUITask).Name, null);
				uiintentReturnable.SetParam("Type", 3);
				UIManager.Instance.StartUITask(uiintentReturnable, true, false, delegate
				{
					CommonUIController.Instance.HideFadeOutLoadingFadeIn();
					UITaskBase uitaskBase = UIUtility.FindUITaskWithType(typeof(ARUITask));
					uitaskBase.ReturnFromRedirectPipLineOnLoadAllResCompleted();
				});
			}, FadeStyle.White, -1f, -1f);
		}

		// Token: 0x0600BDCF RID: 48591 RVA: 0x0035182C File Offset: 0x0034FA2C
		protected void OnBGButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnBGButtonClick_hotfix != null)
			{
				this.m_OnBGButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.gameObject.SetActive(false);
		}

		// Token: 0x0600BDD0 RID: 48592 RVA: 0x00351898 File Offset: 0x0034FA98
		protected void OnHeroItemClick(ARHeroCardUIController ctrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnHeroItemClickARHeroCardUIController_hotfix != null)
			{
				this.m_OnHeroItemClickARHeroCardUIController_hotfix.call(new object[]
				{
					this,
					ctrl
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.SelectHero(ctrl.m_heroWrap);
			this.RefreshSelectHeroShow();
		}

		// Token: 0x0600BDD1 RID: 48593 RVA: 0x0035191C File Offset: 0x0034FB1C
		private void UpdateInfinityHeroItemCallback(int index, Transform trans)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateInfinityHeroItemCallbackInt32Transform_hotfix != null)
			{
				this.m_UpdateInfinityHeroItemCallbackInt32Transform_hotfix.call(new object[]
				{
					this,
					index,
					trans
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ARHeroListUIController.HeroWrap heroListItemInfo = this.m_heroWrapList[index];
			ARHeroCardUIController component = trans.GetComponent<ARHeroCardUIController>();
			component.SetHeroListItemInfo(heroListItemInfo);
		}

		// Token: 0x17002619 RID: 9753
		// (get) Token: 0x0600BDD2 RID: 48594 RVA: 0x003519B8 File Offset: 0x0034FBB8
		// (set) Token: 0x0600BDD3 RID: 48595 RVA: 0x003519D8 File Offset: 0x0034FBD8
		[DoNotToLua]
		public new ARHeroListUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new ARHeroListUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600BDD4 RID: 48596 RVA: 0x003519E4 File Offset: 0x0034FBE4
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0600BDD5 RID: 48597 RVA: 0x003519F0 File Offset: 0x0034FBF0
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0600BDD6 RID: 48598 RVA: 0x003519F8 File Offset: 0x0034FBF8
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0600BDD7 RID: 48599 RVA: 0x00351A00 File Offset: 0x0034FC00
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0600BDD8 RID: 48600 RVA: 0x00351A14 File Offset: 0x0034FC14
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0600BDD9 RID: 48601 RVA: 0x00351A1C File Offset: 0x0034FC1C
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0600BDDA RID: 48602 RVA: 0x00351A28 File Offset: 0x0034FC28
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0600BDDB RID: 48603 RVA: 0x00351A34 File Offset: 0x0034FC34
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0600BDDC RID: 48604 RVA: 0x00351A40 File Offset: 0x0034FC40
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0600BDDD RID: 48605 RVA: 0x00351A4C File Offset: 0x0034FC4C
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0600BDDE RID: 48606 RVA: 0x00351A58 File Offset: 0x0034FC58
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0600BDDF RID: 48607 RVA: 0x00351A64 File Offset: 0x0034FC64
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0600BDE0 RID: 48608 RVA: 0x00351A70 File Offset: 0x0034FC70
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0600BDE1 RID: 48609 RVA: 0x00351A7C File Offset: 0x0034FC7C
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0600BDE2 RID: 48610 RVA: 0x00351A88 File Offset: 0x0034FC88
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600BDEA RID: 48618 RVA: 0x00351CC0 File Offset: 0x0034FEC0
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
					this.m_SetUITaskUITask_hotfix = (luaObj.RawGet("SetUITask") as LuaFunction);
					this.m_SelectHeroHeroWrap_hotfix = (luaObj.RawGet("SelectHero") as LuaFunction);
					this.m_Show_hotfix = (luaObj.RawGet("Show") as LuaFunction);
					this.m_RefreshSelectHeroShow_hotfix = (luaObj.RawGet("RefreshSelectHeroShow") as LuaFunction);
					this.m_OnBattleTypeShowClick_hotfix = (luaObj.RawGet("OnBattleTypeShowClick") as LuaFunction);
					this.m_OnHeroDrawShowClick_hotfix = (luaObj.RawGet("OnHeroDrawShowClick") as LuaFunction);
					this.m_OnTeamShowClick_hotfix = (luaObj.RawGet("OnTeamShowClick") as LuaFunction);
					this.m_OnBGButtonClick_hotfix = (luaObj.RawGet("OnBGButtonClick") as LuaFunction);
					this.m_OnHeroItemClickARHeroCardUIController_hotfix = (luaObj.RawGet("OnHeroItemClick") as LuaFunction);
					this.m_UpdateInfinityHeroItemCallbackInt32Transform_hotfix = (luaObj.RawGet("UpdateInfinityHeroItemCallback") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600BDEB RID: 48619 RVA: 0x00351E88 File Offset: 0x00350088
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ARHeroListUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040079A0 RID: 31136
		[AutoBind(".", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_arHeroListAnimation;

		// Token: 0x040079A1 RID: 31137
		[AutoBind("./ARHeroSelectPanel/HeroListScrollView/Viewport/Content", AutoBindAttribute.InitState.NotInit, false)]
		private InfinityGridLayoutGroup m_heroListInfinityGrid;

		// Token: 0x040079A2 RID: 31138
		[AutoBind("./ARHeroSelectPanel/SingleAndTeamPanel/BattleTypeButton", AutoBindAttribute.InitState.NotInit, false)]
		private ButtonEx m_battleTypeButton;

		// Token: 0x040079A3 RID: 31139
		[AutoBind("./ARHeroSelectPanel/SingleAndTeamPanel/HeroDrawButton", AutoBindAttribute.InitState.NotInit, false)]
		private ButtonEx m_heroDrawButton;

		// Token: 0x040079A4 RID: 31140
		[AutoBind("./ARHeroSelectPanel/SingleAndTeamPanel/TeamButton", AutoBindAttribute.InitState.NotInit, false)]
		private ButtonEx m_teamShowButton;

		// Token: 0x040079A5 RID: 31141
		[AutoBind("./BlackBGButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_bgButton;

		// Token: 0x040079A6 RID: 31142
		[AutoBind("./Prefab/HeroListItem", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_heroListItemPrefab;

		// Token: 0x040079A7 RID: 31143
		private List<ARHeroListUIController.HeroWrap> m_heroWrapList = new List<ARHeroListUIController.HeroWrap>();

		// Token: 0x040079A8 RID: 31144
		private List<ARHeroCardUIController> m_arHeroCardUIControllerList = new List<ARHeroCardUIController>();

		// Token: 0x040079A9 RID: 31145
		private ARHeroListUIController.HeroWrap m_selectHeroWrap;

		// Token: 0x040079AA RID: 31146
		private ProjectLPlayerContext m_playerContext;

		// Token: 0x040079AB RID: 31147
		private IConfigDataLoader m_configDataLoader;

		// Token: 0x040079AC RID: 31148
		private UITask m_task;

		// Token: 0x040079AD RID: 31149
		[DoNotToLua]
		private ARHeroListUIController.LuaExportHelper luaExportHelper;

		// Token: 0x040079B2 RID: 31154
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040079B3 RID: 31155
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040079B4 RID: 31156
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x040079B5 RID: 31157
		private LuaFunction m_SetUITaskUITask_hotfix;

		// Token: 0x040079B6 RID: 31158
		private LuaFunction m_SelectHeroHeroWrap_hotfix;

		// Token: 0x040079B7 RID: 31159
		private LuaFunction m_Show_hotfix;

		// Token: 0x040079B8 RID: 31160
		private LuaFunction m_RefreshSelectHeroShow_hotfix;

		// Token: 0x040079B9 RID: 31161
		private LuaFunction m_OnBattleTypeShowClick_hotfix;

		// Token: 0x040079BA RID: 31162
		private LuaFunction m_OnHeroDrawShowClick_hotfix;

		// Token: 0x040079BB RID: 31163
		private LuaFunction m_OnTeamShowClick_hotfix;

		// Token: 0x040079BC RID: 31164
		private LuaFunction m_OnBGButtonClick_hotfix;

		// Token: 0x040079BD RID: 31165
		private LuaFunction m_OnHeroItemClickARHeroCardUIController_hotfix;

		// Token: 0x040079BE RID: 31166
		private LuaFunction m_UpdateInfinityHeroItemCallbackInt32Transform_hotfix;

		// Token: 0x02000B0A RID: 2826
		public class HeroWrap
		{
			// Token: 0x040079BF RID: 31167
			public Hero hero;

			// Token: 0x040079C0 RID: 31168
			public bool isSelect;
		}

		// Token: 0x02000B0B RID: 2827
		public new class LuaExportHelper
		{
			// Token: 0x0600BDED RID: 48621 RVA: 0x00351EF8 File Offset: 0x003500F8
			public LuaExportHelper(ARHeroListUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600BDEE RID: 48622 RVA: 0x00351F08 File Offset: 0x00350108
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0600BDEF RID: 48623 RVA: 0x00351F18 File Offset: 0x00350118
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0600BDF0 RID: 48624 RVA: 0x00351F28 File Offset: 0x00350128
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600BDF1 RID: 48625 RVA: 0x00351F38 File Offset: 0x00350138
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600BDF2 RID: 48626 RVA: 0x00351F50 File Offset: 0x00350150
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0600BDF3 RID: 48627 RVA: 0x00351F60 File Offset: 0x00350160
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0600BDF4 RID: 48628 RVA: 0x00351F70 File Offset: 0x00350170
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0600BDF5 RID: 48629 RVA: 0x00351F80 File Offset: 0x00350180
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0600BDF6 RID: 48630 RVA: 0x00351F90 File Offset: 0x00350190
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0600BDF7 RID: 48631 RVA: 0x00351FA0 File Offset: 0x003501A0
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0600BDF8 RID: 48632 RVA: 0x00351FB0 File Offset: 0x003501B0
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0600BDF9 RID: 48633 RVA: 0x00351FC0 File Offset: 0x003501C0
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0600BDFA RID: 48634 RVA: 0x00351FD0 File Offset: 0x003501D0
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0600BDFB RID: 48635 RVA: 0x00351FE0 File Offset: 0x003501E0
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0600BDFC RID: 48636 RVA: 0x00351FF0 File Offset: 0x003501F0
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x1700261A RID: 9754
			// (get) Token: 0x0600BDFD RID: 48637 RVA: 0x00352000 File Offset: 0x00350200
			// (set) Token: 0x0600BDFE RID: 48638 RVA: 0x00352010 File Offset: 0x00350210
			public CommonUIStateController m_arHeroListAnimation
			{
				get
				{
					return this.m_owner.m_arHeroListAnimation;
				}
				set
				{
					this.m_owner.m_arHeroListAnimation = value;
				}
			}

			// Token: 0x1700261B RID: 9755
			// (get) Token: 0x0600BDFF RID: 48639 RVA: 0x00352020 File Offset: 0x00350220
			// (set) Token: 0x0600BE00 RID: 48640 RVA: 0x00352030 File Offset: 0x00350230
			public InfinityGridLayoutGroup m_heroListInfinityGrid
			{
				get
				{
					return this.m_owner.m_heroListInfinityGrid;
				}
				set
				{
					this.m_owner.m_heroListInfinityGrid = value;
				}
			}

			// Token: 0x1700261C RID: 9756
			// (get) Token: 0x0600BE01 RID: 48641 RVA: 0x00352040 File Offset: 0x00350240
			// (set) Token: 0x0600BE02 RID: 48642 RVA: 0x00352050 File Offset: 0x00350250
			public ButtonEx m_battleTypeButton
			{
				get
				{
					return this.m_owner.m_battleTypeButton;
				}
				set
				{
					this.m_owner.m_battleTypeButton = value;
				}
			}

			// Token: 0x1700261D RID: 9757
			// (get) Token: 0x0600BE03 RID: 48643 RVA: 0x00352060 File Offset: 0x00350260
			// (set) Token: 0x0600BE04 RID: 48644 RVA: 0x00352070 File Offset: 0x00350270
			public ButtonEx m_heroDrawButton
			{
				get
				{
					return this.m_owner.m_heroDrawButton;
				}
				set
				{
					this.m_owner.m_heroDrawButton = value;
				}
			}

			// Token: 0x1700261E RID: 9758
			// (get) Token: 0x0600BE05 RID: 48645 RVA: 0x00352080 File Offset: 0x00350280
			// (set) Token: 0x0600BE06 RID: 48646 RVA: 0x00352090 File Offset: 0x00350290
			public ButtonEx m_teamShowButton
			{
				get
				{
					return this.m_owner.m_teamShowButton;
				}
				set
				{
					this.m_owner.m_teamShowButton = value;
				}
			}

			// Token: 0x1700261F RID: 9759
			// (get) Token: 0x0600BE07 RID: 48647 RVA: 0x003520A0 File Offset: 0x003502A0
			// (set) Token: 0x0600BE08 RID: 48648 RVA: 0x003520B0 File Offset: 0x003502B0
			public Button m_bgButton
			{
				get
				{
					return this.m_owner.m_bgButton;
				}
				set
				{
					this.m_owner.m_bgButton = value;
				}
			}

			// Token: 0x17002620 RID: 9760
			// (get) Token: 0x0600BE09 RID: 48649 RVA: 0x003520C0 File Offset: 0x003502C0
			// (set) Token: 0x0600BE0A RID: 48650 RVA: 0x003520D0 File Offset: 0x003502D0
			public GameObject m_heroListItemPrefab
			{
				get
				{
					return this.m_owner.m_heroListItemPrefab;
				}
				set
				{
					this.m_owner.m_heroListItemPrefab = value;
				}
			}

			// Token: 0x17002621 RID: 9761
			// (get) Token: 0x0600BE0B RID: 48651 RVA: 0x003520E0 File Offset: 0x003502E0
			// (set) Token: 0x0600BE0C RID: 48652 RVA: 0x003520F0 File Offset: 0x003502F0
			public List<ARHeroListUIController.HeroWrap> m_heroWrapList
			{
				get
				{
					return this.m_owner.m_heroWrapList;
				}
				set
				{
					this.m_owner.m_heroWrapList = value;
				}
			}

			// Token: 0x17002622 RID: 9762
			// (get) Token: 0x0600BE0D RID: 48653 RVA: 0x00352100 File Offset: 0x00350300
			// (set) Token: 0x0600BE0E RID: 48654 RVA: 0x00352110 File Offset: 0x00350310
			public List<ARHeroCardUIController> m_arHeroCardUIControllerList
			{
				get
				{
					return this.m_owner.m_arHeroCardUIControllerList;
				}
				set
				{
					this.m_owner.m_arHeroCardUIControllerList = value;
				}
			}

			// Token: 0x17002623 RID: 9763
			// (get) Token: 0x0600BE0F RID: 48655 RVA: 0x00352120 File Offset: 0x00350320
			// (set) Token: 0x0600BE10 RID: 48656 RVA: 0x00352130 File Offset: 0x00350330
			public ARHeroListUIController.HeroWrap m_selectHeroWrap
			{
				get
				{
					return this.m_owner.m_selectHeroWrap;
				}
				set
				{
					this.m_owner.m_selectHeroWrap = value;
				}
			}

			// Token: 0x17002624 RID: 9764
			// (get) Token: 0x0600BE11 RID: 48657 RVA: 0x00352140 File Offset: 0x00350340
			// (set) Token: 0x0600BE12 RID: 48658 RVA: 0x00352150 File Offset: 0x00350350
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

			// Token: 0x17002625 RID: 9765
			// (get) Token: 0x0600BE13 RID: 48659 RVA: 0x00352160 File Offset: 0x00350360
			// (set) Token: 0x0600BE14 RID: 48660 RVA: 0x00352170 File Offset: 0x00350370
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

			// Token: 0x17002626 RID: 9766
			// (get) Token: 0x0600BE15 RID: 48661 RVA: 0x00352180 File Offset: 0x00350380
			// (set) Token: 0x0600BE16 RID: 48662 RVA: 0x00352190 File Offset: 0x00350390
			public UITask m_task
			{
				get
				{
					return this.m_owner.m_task;
				}
				set
				{
					this.m_owner.m_task = value;
				}
			}

			// Token: 0x0600BE17 RID: 48663 RVA: 0x003521A0 File Offset: 0x003503A0
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0600BE18 RID: 48664 RVA: 0x003521B0 File Offset: 0x003503B0
			public void SelectHero(ARHeroListUIController.HeroWrap selectHeroWrap)
			{
				this.m_owner.SelectHero(selectHeroWrap);
			}

			// Token: 0x0600BE19 RID: 48665 RVA: 0x003521C0 File Offset: 0x003503C0
			public void OnBattleTypeShowClick()
			{
				this.m_owner.OnBattleTypeShowClick();
			}

			// Token: 0x0600BE1A RID: 48666 RVA: 0x003521D0 File Offset: 0x003503D0
			public void OnHeroDrawShowClick()
			{
				this.m_owner.OnHeroDrawShowClick();
			}

			// Token: 0x0600BE1B RID: 48667 RVA: 0x003521E0 File Offset: 0x003503E0
			public void OnTeamShowClick()
			{
				this.m_owner.OnTeamShowClick();
			}

			// Token: 0x0600BE1C RID: 48668 RVA: 0x003521F0 File Offset: 0x003503F0
			public void OnBGButtonClick()
			{
				this.m_owner.OnBGButtonClick();
			}

			// Token: 0x0600BE1D RID: 48669 RVA: 0x00352200 File Offset: 0x00350400
			public void OnHeroItemClick(ARHeroCardUIController ctrl)
			{
				this.m_owner.OnHeroItemClick(ctrl);
			}

			// Token: 0x0600BE1E RID: 48670 RVA: 0x00352210 File Offset: 0x00350410
			public void UpdateInfinityHeroItemCallback(int index, Transform trans)
			{
				this.m_owner.UpdateInfinityHeroItemCallback(index, trans);
			}

			// Token: 0x040079C1 RID: 31169
			private ARHeroListUIController m_owner;
		}
	}
}
