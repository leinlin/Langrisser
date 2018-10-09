using System;
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
	// Token: 0x02000DB8 RID: 3512
	[HotFix]
	public class HeroItemUIController : UIControllerBase
	{
		// Token: 0x06010AF2 RID: 68338 RVA: 0x00454C88 File Offset: 0x00452E88
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
			base.gameObject.GetComponent<Button>().onClick.AddListener(new UnityAction(this.OnHeroItemClick));
			base.gameObject.SetActive(true);
		}

		// Token: 0x06010AF3 RID: 68339 RVA: 0x00454D1C File Offset: 0x00452F1C
		public void InitValuesInHeroItemUnlocked(Hero hero, int heroLvText, int heroStarNum)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitValuesInHeroItemUnlockedHeroInt32Int32_hotfix != null)
			{
				this.m_InitValuesInHeroItemUnlockedHeroInt32Int32_hotfix.call(new object[]
				{
					this,
					hero,
					heroLvText,
					heroStarNum
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_hero == hero)
			{
				return;
			}
			this.m_hero = hero.GetHeroCopy();
			this.InitValuesInHeroItem(heroLvText, heroStarNum, 0, 1, 0);
		}

		// Token: 0x06010AF4 RID: 68340 RVA: 0x00454DD0 File Offset: 0x00452FD0
		public void InitValuesInHeroItemLocked(Hero hero, int starNums, int collectCurNum, int collectTotalNum)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitValuesInHeroItemLockedHeroInt32Int32Int32_hotfix != null)
			{
				this.m_InitValuesInHeroItemLockedHeroInt32Int32Int32_hotfix.call(new object[]
				{
					this,
					hero,
					starNums,
					collectCurNum,
					collectTotalNum
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_hero == hero)
			{
				return;
			}
			this.m_hero = hero.GetHeroCopy();
			this.InitValuesInHeroItem(1, starNums, collectCurNum, collectTotalNum, 1);
		}

		// Token: 0x06010AF5 RID: 68341 RVA: 0x00454E98 File Offset: 0x00453098
		private void InitValuesInHeroItem(int lvText = 1, int starNum = 1, int curNum = 0, int totalNum = 1, int state = 0)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitValuesInHeroItemInt32Int32Int32Int32Int32_hotfix != null)
			{
				this.m_InitValuesInHeroItemInt32Int32Int32Int32Int32_hotfix.call(new object[]
				{
					this,
					lvText,
					starNum,
					curNum,
					totalNum,
					state
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_hero.HeroInfo != null)
			{
				ConfigDataCharImageInfo charImageInfo = this.m_hero.HeroInfo.GetCharImageInfo(this.m_hero.StarLevel);
				if (charImageInfo != null)
				{
					this.m_heroIconImg.sprite = AssetUtility.Instance.GetSprite(AssetUtility.MakeSpriteAssetName(charImageInfo.CardHeadImage, "_1"));
				}
				IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
				ConfigDataArmyInfo configDataArmyInfo = configDataLoader.GetConfigDataArmyInfo(this.m_hero.GetActiveJob().JobConnectionInfo.m_jobInfo.Army_ID);
				this.m_heroTypeImg.sprite = AssetUtility.Instance.GetSprite(configDataArmyInfo.Icon);
			}
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (state != 0)
			{
				if (state == 1)
				{
					if (curNum >= totalNum)
					{
						this.m_uiStateCtrl.SetToUIState("NotGetAndGlowing", false, true);
						this.m_curHeroItemState = HeroItemUIController.HeroItemState.NotGetAndGlowing;
					}
					else
					{
						this.m_uiStateCtrl.SetToUIState("NotGet", false, true);
						this.m_curHeroItemState = HeroItemUIController.HeroItemState.NotGet;
					}
					this.m_heroCollectProgressText.text = curNum + "/" + totalNum;
					this.m_heroCollectProgressImg.fillAmount = (float)curNum / (float)totalNum;
					this.m_heroIconImg.color = Color.gray;
					this.m_redMark.gameObject.SetActive(curNum >= totalNum);
				}
			}
			else
			{
				this.m_uiStateCtrl.SetToUIState("Get", false, true);
				this.m_curHeroItemState = HeroItemUIController.HeroItemState.Get;
				this.m_heroLvText.text = lvText.ToString();
				UIUtility.SetGameObjectChildrenActiveCount(this.m_heroStar, starNum);
				this.m_frameImg.sprite = AssetUtility.Instance.GetSprite(UIUtility.GetHeroItemFrameNameByRank(this.m_hero.HeroInfo.GetRank(this.m_hero.StarLevel)));
				this.m_ssrFrameEffect.SetActive(this.m_hero.HeroInfo.GetRank(this.m_hero.StarLevel) >= 4);
				if (projectLPlayerContext.IsHeroShowRedMark(this.m_hero.HeroId, this.m_hero.GetActiveJob().JobConnectionInfo.ID))
				{
					this.m_redMark.gameObject.SetActive(true);
				}
				else
				{
					this.m_redMark.gameObject.SetActive(false);
				}
			}
		}

		// Token: 0x06010AF6 RID: 68342 RVA: 0x004551A4 File Offset: 0x004533A4
		public void ShowSelectFrameImage(bool isShow)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowSelectFrameImageBoolean_hotfix != null)
			{
				this.m_ShowSelectFrameImageBoolean_hotfix.call(new object[]
				{
					this,
					isShow
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_selectFrameImg.gameObject.SetActive(isShow);
		}

		// Token: 0x06010AF7 RID: 68343 RVA: 0x00455228 File Offset: 0x00453428
		private void OnHeroItemClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnHeroItemClick_hotfix != null)
			{
				this.m_OnHeroItemClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnHeroItemClick != null)
			{
				this.EventOnHeroItemClick(this);
			}
		}

		// Token: 0x1400038C RID: 908
		// (add) Token: 0x06010AF8 RID: 68344 RVA: 0x004552A0 File Offset: 0x004534A0
		// (remove) Token: 0x06010AF9 RID: 68345 RVA: 0x0045533C File Offset: 0x0045353C
		public event Action<HeroItemUIController> EventOnHeroItemClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnHeroItemClickAction`1_hotfix != null)
				{
					this.m_add_EventOnHeroItemClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<HeroItemUIController> action = this.EventOnHeroItemClick;
				Action<HeroItemUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<HeroItemUIController>>(ref this.EventOnHeroItemClick, (Action<HeroItemUIController>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnHeroItemClickAction`1_hotfix != null)
				{
					this.m_remove_EventOnHeroItemClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<HeroItemUIController> action = this.EventOnHeroItemClick;
				Action<HeroItemUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<HeroItemUIController>>(ref this.EventOnHeroItemClick, (Action<HeroItemUIController>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17003397 RID: 13207
		// (get) Token: 0x06010AFA RID: 68346 RVA: 0x004553D8 File Offset: 0x004535D8
		// (set) Token: 0x06010AFB RID: 68347 RVA: 0x004553F8 File Offset: 0x004535F8
		[DoNotToLua]
		public new HeroItemUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new HeroItemUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06010AFC RID: 68348 RVA: 0x00455404 File Offset: 0x00453604
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x06010AFD RID: 68349 RVA: 0x00455410 File Offset: 0x00453610
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x06010AFE RID: 68350 RVA: 0x00455418 File Offset: 0x00453618
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x06010AFF RID: 68351 RVA: 0x00455420 File Offset: 0x00453620
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x06010B00 RID: 68352 RVA: 0x00455434 File Offset: 0x00453634
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x06010B01 RID: 68353 RVA: 0x0045543C File Offset: 0x0045363C
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x06010B02 RID: 68354 RVA: 0x00455448 File Offset: 0x00453648
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x06010B03 RID: 68355 RVA: 0x00455454 File Offset: 0x00453654
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x06010B04 RID: 68356 RVA: 0x00455460 File Offset: 0x00453660
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x06010B05 RID: 68357 RVA: 0x0045546C File Offset: 0x0045366C
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x06010B06 RID: 68358 RVA: 0x00455478 File Offset: 0x00453678
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x06010B07 RID: 68359 RVA: 0x00455484 File Offset: 0x00453684
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x06010B08 RID: 68360 RVA: 0x00455490 File Offset: 0x00453690
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x06010B09 RID: 68361 RVA: 0x0045549C File Offset: 0x0045369C
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x06010B0A RID: 68362 RVA: 0x004554A8 File Offset: 0x004536A8
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x06010B0B RID: 68363 RVA: 0x004554B0 File Offset: 0x004536B0
		private void __callDele_EventOnHeroItemClick(HeroItemUIController obj)
		{
			Action<HeroItemUIController> eventOnHeroItemClick = this.EventOnHeroItemClick;
			if (eventOnHeroItemClick != null)
			{
				eventOnHeroItemClick(obj);
			}
		}

		// Token: 0x06010B0C RID: 68364 RVA: 0x004554D4 File Offset: 0x004536D4
		private void __clearDele_EventOnHeroItemClick(HeroItemUIController obj)
		{
			this.EventOnHeroItemClick = null;
		}

		// Token: 0x06010B0D RID: 68365 RVA: 0x004554E0 File Offset: 0x004536E0
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
					this.m_InitValuesInHeroItemUnlockedHeroInt32Int32_hotfix = (luaObj.RawGet("InitValuesInHeroItemUnlocked") as LuaFunction);
					this.m_InitValuesInHeroItemLockedHeroInt32Int32Int32_hotfix = (luaObj.RawGet("InitValuesInHeroItemLocked") as LuaFunction);
					this.m_InitValuesInHeroItemInt32Int32Int32Int32Int32_hotfix = (luaObj.RawGet("InitValuesInHeroItem") as LuaFunction);
					this.m_ShowSelectFrameImageBoolean_hotfix = (luaObj.RawGet("ShowSelectFrameImage") as LuaFunction);
					this.m_OnHeroItemClick_hotfix = (luaObj.RawGet("OnHeroItemClick") as LuaFunction);
					this.m_add_EventOnHeroItemClickAction`1_hotfix = (luaObj.RawGet("add_EventOnHeroItemClick") as LuaFunction);
					this.m_remove_EventOnHeroItemClickAction`1_hotfix = (luaObj.RawGet("remove_EventOnHeroItemClick") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06010B0E RID: 68366 RVA: 0x0045565C File Offset: 0x0045385C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(HeroItemUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04009A31 RID: 39473
		[AutoBind("./CollectProgressBar/Image", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_heroCollectProgressImg;

		// Token: 0x04009A32 RID: 39474
		[AutoBind("./CollectProgressBar/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_heroCollectProgressText;

		// Token: 0x04009A33 RID: 39475
		[AutoBind("./SelectFrameImg", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_selectFrameImg;

		// Token: 0x04009A34 RID: 39476
		[AutoBind("./HeroStars", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_heroStar;

		// Token: 0x04009A35 RID: 39477
		[AutoBind("./HeroTypeImg", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_heroTypeImg;

		// Token: 0x04009A36 RID: 39478
		[AutoBind("./HeroLvText/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_heroLvText;

		// Token: 0x04009A37 RID: 39479
		[AutoBind("./SSRFrameEffect", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_ssrFrameEffect;

		// Token: 0x04009A38 RID: 39480
		[AutoBind("./FrameImg", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_frameImg;

		// Token: 0x04009A39 RID: 39481
		[AutoBind("./HeroIcon", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_heroIconImg;

		// Token: 0x04009A3A RID: 39482
		[AutoBind("./RedMark", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_redMark;

		// Token: 0x04009A3B RID: 39483
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_uiStateCtrl;

		// Token: 0x04009A3C RID: 39484
		public HeroItemUIController.HeroItemState m_curHeroItemState;

		// Token: 0x04009A3D RID: 39485
		public Hero m_hero;

		// Token: 0x04009A3E RID: 39486
		[DoNotToLua]
		private HeroItemUIController.LuaExportHelper luaExportHelper;

		// Token: 0x04009A3F RID: 39487
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04009A40 RID: 39488
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04009A41 RID: 39489
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x04009A42 RID: 39490
		private LuaFunction m_InitValuesInHeroItemUnlockedHeroInt32Int32_hotfix;

		// Token: 0x04009A43 RID: 39491
		private LuaFunction m_InitValuesInHeroItemLockedHeroInt32Int32Int32_hotfix;

		// Token: 0x04009A44 RID: 39492
		private LuaFunction m_InitValuesInHeroItemInt32Int32Int32Int32Int32_hotfix;

		// Token: 0x04009A45 RID: 39493
		private LuaFunction m_ShowSelectFrameImageBoolean_hotfix;

		// Token: 0x04009A46 RID: 39494
		private LuaFunction m_OnHeroItemClick_hotfix;

		// Token: 0x04009A47 RID: 39495
		private LuaFunction m_add_EventOnHeroItemClickAction;

		// Token: 0x04009A48 RID: 39496
		private LuaFunction m_remove_EventOnHeroItemClickAction;

		// Token: 0x02000DB9 RID: 3513
		public enum HeroItemState
		{
			// Token: 0x04009A4A RID: 39498
			Get,
			// Token: 0x04009A4B RID: 39499
			NotGet,
			// Token: 0x04009A4C RID: 39500
			NotGetAndGlowing
		}

		// Token: 0x02000DBA RID: 3514
		public new class LuaExportHelper
		{
			// Token: 0x06010B0F RID: 68367 RVA: 0x004556C4 File Offset: 0x004538C4
			public LuaExportHelper(HeroItemUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06010B10 RID: 68368 RVA: 0x004556D4 File Offset: 0x004538D4
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x06010B11 RID: 68369 RVA: 0x004556E4 File Offset: 0x004538E4
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x06010B12 RID: 68370 RVA: 0x004556F4 File Offset: 0x004538F4
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x06010B13 RID: 68371 RVA: 0x00455704 File Offset: 0x00453904
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x06010B14 RID: 68372 RVA: 0x0045571C File Offset: 0x0045391C
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x06010B15 RID: 68373 RVA: 0x0045572C File Offset: 0x0045392C
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x06010B16 RID: 68374 RVA: 0x0045573C File Offset: 0x0045393C
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x06010B17 RID: 68375 RVA: 0x0045574C File Offset: 0x0045394C
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x06010B18 RID: 68376 RVA: 0x0045575C File Offset: 0x0045395C
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x06010B19 RID: 68377 RVA: 0x0045576C File Offset: 0x0045396C
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x06010B1A RID: 68378 RVA: 0x0045577C File Offset: 0x0045397C
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x06010B1B RID: 68379 RVA: 0x0045578C File Offset: 0x0045398C
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x06010B1C RID: 68380 RVA: 0x0045579C File Offset: 0x0045399C
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x06010B1D RID: 68381 RVA: 0x004557AC File Offset: 0x004539AC
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x06010B1E RID: 68382 RVA: 0x004557BC File Offset: 0x004539BC
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x06010B1F RID: 68383 RVA: 0x004557CC File Offset: 0x004539CC
			public void __callDele_EventOnHeroItemClick(HeroItemUIController obj)
			{
				this.m_owner.__callDele_EventOnHeroItemClick(obj);
			}

			// Token: 0x06010B20 RID: 68384 RVA: 0x004557DC File Offset: 0x004539DC
			public void __clearDele_EventOnHeroItemClick(HeroItemUIController obj)
			{
				this.m_owner.__clearDele_EventOnHeroItemClick(obj);
			}

			// Token: 0x17003398 RID: 13208
			// (get) Token: 0x06010B21 RID: 68385 RVA: 0x004557EC File Offset: 0x004539EC
			// (set) Token: 0x06010B22 RID: 68386 RVA: 0x004557FC File Offset: 0x004539FC
			public Image m_heroCollectProgressImg
			{
				get
				{
					return this.m_owner.m_heroCollectProgressImg;
				}
				set
				{
					this.m_owner.m_heroCollectProgressImg = value;
				}
			}

			// Token: 0x17003399 RID: 13209
			// (get) Token: 0x06010B23 RID: 68387 RVA: 0x0045580C File Offset: 0x00453A0C
			// (set) Token: 0x06010B24 RID: 68388 RVA: 0x0045581C File Offset: 0x00453A1C
			public Text m_heroCollectProgressText
			{
				get
				{
					return this.m_owner.m_heroCollectProgressText;
				}
				set
				{
					this.m_owner.m_heroCollectProgressText = value;
				}
			}

			// Token: 0x1700339A RID: 13210
			// (get) Token: 0x06010B25 RID: 68389 RVA: 0x0045582C File Offset: 0x00453A2C
			// (set) Token: 0x06010B26 RID: 68390 RVA: 0x0045583C File Offset: 0x00453A3C
			public Image m_selectFrameImg
			{
				get
				{
					return this.m_owner.m_selectFrameImg;
				}
				set
				{
					this.m_owner.m_selectFrameImg = value;
				}
			}

			// Token: 0x1700339B RID: 13211
			// (get) Token: 0x06010B27 RID: 68391 RVA: 0x0045584C File Offset: 0x00453A4C
			// (set) Token: 0x06010B28 RID: 68392 RVA: 0x0045585C File Offset: 0x00453A5C
			public GameObject m_heroStar
			{
				get
				{
					return this.m_owner.m_heroStar;
				}
				set
				{
					this.m_owner.m_heroStar = value;
				}
			}

			// Token: 0x1700339C RID: 13212
			// (get) Token: 0x06010B29 RID: 68393 RVA: 0x0045586C File Offset: 0x00453A6C
			// (set) Token: 0x06010B2A RID: 68394 RVA: 0x0045587C File Offset: 0x00453A7C
			public Image m_heroTypeImg
			{
				get
				{
					return this.m_owner.m_heroTypeImg;
				}
				set
				{
					this.m_owner.m_heroTypeImg = value;
				}
			}

			// Token: 0x1700339D RID: 13213
			// (get) Token: 0x06010B2B RID: 68395 RVA: 0x0045588C File Offset: 0x00453A8C
			// (set) Token: 0x06010B2C RID: 68396 RVA: 0x0045589C File Offset: 0x00453A9C
			public Text m_heroLvText
			{
				get
				{
					return this.m_owner.m_heroLvText;
				}
				set
				{
					this.m_owner.m_heroLvText = value;
				}
			}

			// Token: 0x1700339E RID: 13214
			// (get) Token: 0x06010B2D RID: 68397 RVA: 0x004558AC File Offset: 0x00453AAC
			// (set) Token: 0x06010B2E RID: 68398 RVA: 0x004558BC File Offset: 0x00453ABC
			public GameObject m_ssrFrameEffect
			{
				get
				{
					return this.m_owner.m_ssrFrameEffect;
				}
				set
				{
					this.m_owner.m_ssrFrameEffect = value;
				}
			}

			// Token: 0x1700339F RID: 13215
			// (get) Token: 0x06010B2F RID: 68399 RVA: 0x004558CC File Offset: 0x00453ACC
			// (set) Token: 0x06010B30 RID: 68400 RVA: 0x004558DC File Offset: 0x00453ADC
			public Image m_frameImg
			{
				get
				{
					return this.m_owner.m_frameImg;
				}
				set
				{
					this.m_owner.m_frameImg = value;
				}
			}

			// Token: 0x170033A0 RID: 13216
			// (get) Token: 0x06010B31 RID: 68401 RVA: 0x004558EC File Offset: 0x00453AEC
			// (set) Token: 0x06010B32 RID: 68402 RVA: 0x004558FC File Offset: 0x00453AFC
			public Image m_heroIconImg
			{
				get
				{
					return this.m_owner.m_heroIconImg;
				}
				set
				{
					this.m_owner.m_heroIconImg = value;
				}
			}

			// Token: 0x170033A1 RID: 13217
			// (get) Token: 0x06010B33 RID: 68403 RVA: 0x0045590C File Offset: 0x00453B0C
			// (set) Token: 0x06010B34 RID: 68404 RVA: 0x0045591C File Offset: 0x00453B1C
			public Image m_redMark
			{
				get
				{
					return this.m_owner.m_redMark;
				}
				set
				{
					this.m_owner.m_redMark = value;
				}
			}

			// Token: 0x170033A2 RID: 13218
			// (get) Token: 0x06010B35 RID: 68405 RVA: 0x0045592C File Offset: 0x00453B2C
			// (set) Token: 0x06010B36 RID: 68406 RVA: 0x0045593C File Offset: 0x00453B3C
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

			// Token: 0x06010B37 RID: 68407 RVA: 0x0045594C File Offset: 0x00453B4C
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x06010B38 RID: 68408 RVA: 0x0045595C File Offset: 0x00453B5C
			public void InitValuesInHeroItem(int lvText, int starNum, int curNum, int totalNum, int state)
			{
				this.m_owner.InitValuesInHeroItem(lvText, starNum, curNum, totalNum, state);
			}

			// Token: 0x06010B39 RID: 68409 RVA: 0x00455970 File Offset: 0x00453B70
			public void OnHeroItemClick()
			{
				this.m_owner.OnHeroItemClick();
			}

			// Token: 0x04009A4D RID: 39501
			private HeroItemUIController m_owner;
		}
	}
}
