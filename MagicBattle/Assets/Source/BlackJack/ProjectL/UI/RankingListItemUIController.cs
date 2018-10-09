using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Misc;
using BlackJack.UtilityTools;
using SLua;
using UnityEngine;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000EB3 RID: 3763
	[HotFix]
	public class RankingListItemUIController : UIControllerBase
	{
		// Token: 0x06012640 RID: 75328 RVA: 0x004B8E08 File Offset: 0x004B7008
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
			this.ScrollItemBaseUICtrl = base.GetComponent<ScrollItemBaseUIController>();
		}

		// Token: 0x06012641 RID: 75329 RVA: 0x004B8E7C File Offset: 0x004B707C
		public void Init()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Init_hotfix != null)
			{
				this.m_Init_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.ScrollItemBaseUICtrl.Init(this, true);
		}

		// Token: 0x06012642 RID: 75330 RVA: 0x004B8EEC File Offset: 0x004B70EC
		public void RegisterItemClickEvent(Action<UIControllerBase> action)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_RegisterItemClickEventAction`1_hotfix != null)
			{
				this.m_RegisterItemClickEventAction`1_hotfix.call(new object[]
				{
					this,
					action
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.ScrollItemBaseUICtrl.EventOnUIItemClick = action;
		}

		// Token: 0x06012643 RID: 75331 RVA: 0x004B8F68 File Offset: 0x004B7168
		public void RegisterItemNeedFillEvent(Action<UIControllerBase> action)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_RegisterItemNeedFillEventAction`1_hotfix != null)
			{
				this.m_RegisterItemNeedFillEventAction`1_hotfix.call(new object[]
				{
					this,
					action
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.ScrollItemBaseUICtrl.EventOnUIItemNeedFill = action;
		}

		// Token: 0x06012644 RID: 75332 RVA: 0x004B8FE4 File Offset: 0x004B71E4
		public int GetItemIndex()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetItemIndex_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetItemIndex_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.ScrollItemBaseUICtrl.ItemIndex;
		}

		// Token: 0x06012645 RID: 75333 RVA: 0x004B905C File Offset: 0x004B725C
		public void UpdateItemInfo(RankingListType rankType, int headIconId, int rankLevel, int lv, string playerName, int score, string heroName = "")
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateItemInfoRankingListTypeInt32Int32Int32StringInt32String_hotfix != null)
			{
				this.m_UpdateItemInfoRankingListTypeInt32Int32Int32StringInt32String_hotfix.call(new object[]
				{
					this,
					rankType,
					headIconId,
					rankLevel,
					lv,
					playerName,
					score,
					heroName
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			string playerHeadIconImageName = UIUtility.GetPlayerHeadIconImageName(HeadIconTools.GetHeadPortrait(headIconId));
			Sprite sprite = AssetUtility.Instance.GetSprite(playerHeadIconImageName);
			this.HeadIconImage.sprite = sprite;
			this.PlayerLevelText.text = lv.ToString();
			this.PlayerNameText.text = playerName;
			if (rankLevel == 2147483647)
			{
				IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
				this.RankValueImage.gameObject.SetActive(false);
				this.RankValueText.gameObject.SetActive(true);
				this.RankValueText.text = configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Ranking_UnReach);
			}
			else if (rankLevel > 3)
			{
				this.RankValueImage.gameObject.SetActive(false);
				this.RankValueText.gameObject.SetActive(true);
				this.RankValueText.text = rankLevel.ToString();
			}
			else
			{
				this.RankValueImage.gameObject.SetActive(true);
				this.RankValueText.gameObject.SetActive(false);
				this.RankValueImage.sprite = this.GetRankLevelSprite(rankLevel);
			}
			this.UpdateDetailInfo(rankType, heroName, score);
		}

		// Token: 0x06012646 RID: 75334 RVA: 0x004B9254 File Offset: 0x004B7454
		protected Sprite GetRankLevelSprite(int rankLevel)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetRankLevelSpriteInt32_hotfix != null)
			{
				return (Sprite)this.m_GetRankLevelSpriteInt32_hotfix.call(new object[]
				{
					this,
					rankLevel
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			string name = string.Empty;
			if (rankLevel == 1)
			{
				name = "UI/Common_New_ABS/Icon/Icon_One.png";
			}
			else if (rankLevel == 2)
			{
				name = "UI/Common_New_ABS/Icon/Icon_Two.png";
			}
			else if (rankLevel == 3)
			{
				name = "UI/Common_New_ABS/Icon/Icon_Three.png";
			}
			return AssetUtility.Instance.GetSprite(name);
		}

		// Token: 0x06012647 RID: 75335 RVA: 0x004B9314 File Offset: 0x004B7514
		protected void UpdateDetailInfo(RankingListType rankType, string heroName, int score)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateDetailInfoRankingListTypeStringInt32_hotfix != null)
			{
				this.m_UpdateDetailInfoRankingListTypeStringInt32_hotfix.call(new object[]
				{
					this,
					rankType,
					heroName,
					score
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			switch (rankType)
			{
			case RankingListType.TopHero:
				this.DetailGroupStateCtrl.SetToUIState("TopHero", false, true);
				this.TopHeroScoreValueText.text = score.ToString();
				break;
			case RankingListType.AllHero:
				this.DetailGroupStateCtrl.SetToUIState("AllHero", false, true);
				this.AllHeroScoreValueText.text = score.ToString();
				break;
			case RankingListType.ChampionHero:
			{
				IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
				string format = configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Ranking_HeroPowerWithName);
				this.DetailGroupStateCtrl.SetToUIState("ChampionHero", false, true);
				this.ChampionHeroScoreTitleText.text = string.Format(format, heroName);
				this.ChampionHeroScoreValueText.text = score.ToString();
				break;
			}
			case RankingListType.RiftChapterStar:
				this.DetailGroupStateCtrl.SetToUIState("RiftChapterStar", false, true);
				this.RiftChapterStarScoreValueText.text = score.ToString();
				break;
			case RankingListType.RiftAchievement:
				this.DetailGroupStateCtrl.SetToUIState("RiftAchievement", false, true);
				this.RiftAchievementScoreValueText.text = score.ToString();
				break;
			case RankingListType.SingleHero:
			{
				IConfigDataLoader configDataLoader2 = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
				this.DetailGroupStateCtrl.SetToUIState("ChampionHero", false, true);
				this.ChampionHeroScoreTitleText.text = configDataLoader2.UtilityGetStringByStringTable(StringTableId.StringTableId_Ranking_HeroPowerWithoutName);
				this.ChampionHeroScoreValueText.text = score.ToString();
				break;
			}
			}
		}

		// Token: 0x170037CB RID: 14283
		// (get) Token: 0x06012648 RID: 75336 RVA: 0x004B9538 File Offset: 0x004B7738
		// (set) Token: 0x06012649 RID: 75337 RVA: 0x004B9558 File Offset: 0x004B7758
		[DoNotToLua]
		public new RankingListItemUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new RankingListItemUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0601264A RID: 75338 RVA: 0x004B9564 File Offset: 0x004B7764
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0601264B RID: 75339 RVA: 0x004B9570 File Offset: 0x004B7770
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0601264C RID: 75340 RVA: 0x004B9578 File Offset: 0x004B7778
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0601264D RID: 75341 RVA: 0x004B9580 File Offset: 0x004B7780
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0601264E RID: 75342 RVA: 0x004B9594 File Offset: 0x004B7794
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0601264F RID: 75343 RVA: 0x004B959C File Offset: 0x004B779C
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x06012650 RID: 75344 RVA: 0x004B95A8 File Offset: 0x004B77A8
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x06012651 RID: 75345 RVA: 0x004B95B4 File Offset: 0x004B77B4
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x06012652 RID: 75346 RVA: 0x004B95C0 File Offset: 0x004B77C0
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x06012653 RID: 75347 RVA: 0x004B95CC File Offset: 0x004B77CC
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x06012654 RID: 75348 RVA: 0x004B95D8 File Offset: 0x004B77D8
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x06012655 RID: 75349 RVA: 0x004B95E4 File Offset: 0x004B77E4
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x06012656 RID: 75350 RVA: 0x004B95F0 File Offset: 0x004B77F0
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x06012657 RID: 75351 RVA: 0x004B95FC File Offset: 0x004B77FC
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x06012658 RID: 75352 RVA: 0x004B9608 File Offset: 0x004B7808
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x06012659 RID: 75353 RVA: 0x004B9610 File Offset: 0x004B7810
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
					this.m_Init_hotfix = (luaObj.RawGet("Init") as LuaFunction);
					this.m_RegisterItemClickEventAction`1_hotfix = (luaObj.RawGet("RegisterItemClickEvent") as LuaFunction);
					this.m_RegisterItemNeedFillEventAction`1_hotfix = (luaObj.RawGet("RegisterItemNeedFillEvent") as LuaFunction);
					this.m_GetItemIndex_hotfix = (luaObj.RawGet("GetItemIndex") as LuaFunction);
					this.m_UpdateItemInfoRankingListTypeInt32Int32Int32StringInt32String_hotfix = (luaObj.RawGet("UpdateItemInfo") as LuaFunction);
					this.m_GetRankLevelSpriteInt32_hotfix = (luaObj.RawGet("GetRankLevelSprite") as LuaFunction);
					this.m_UpdateDetailInfoRankingListTypeStringInt32_hotfix = (luaObj.RawGet("UpdateDetailInfo") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0601265A RID: 75354 RVA: 0x004B978C File Offset: 0x004B798C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(RankingListItemUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400A588 RID: 42376
		public ScrollItemBaseUIController ScrollItemBaseUICtrl;

		// Token: 0x0400A589 RID: 42377
		[AutoBind("./Rank/RankValueText", AutoBindAttribute.InitState.NotInit, false)]
		public Text RankValueText;

		// Token: 0x0400A58A RID: 42378
		[AutoBind("./Rank/RankValueImage", AutoBindAttribute.InitState.NotInit, false)]
		public Image RankValueImage;

		// Token: 0x0400A58B RID: 42379
		[AutoBind("./HeadIconImage", AutoBindAttribute.InitState.NotInit, false)]
		public Image HeadIconImage;

		// Token: 0x0400A58C RID: 42380
		[AutoBind("./LevelValue", AutoBindAttribute.InitState.NotInit, false)]
		public Text PlayerLevelText;

		// Token: 0x0400A58D RID: 42381
		[AutoBind("./NameText", AutoBindAttribute.InitState.NotInit, false)]
		public Text PlayerNameText;

		// Token: 0x0400A58E RID: 42382
		[AutoBind("./DetailGroup", AutoBindAttribute.InitState.NotInit, false)]
		public CommonUIStateController DetailGroupStateCtrl;

		// Token: 0x0400A58F RID: 42383
		[AutoBind("./DetailGroup/TopHero/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		public Text TopHeroScoreValueText;

		// Token: 0x0400A590 RID: 42384
		[AutoBind("./DetailGroup/AllHero/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		public Text AllHeroScoreValueText;

		// Token: 0x0400A591 RID: 42385
		[AutoBind("./DetailGroup/ChampionHero/TitleText", AutoBindAttribute.InitState.NotInit, false)]
		public Text ChampionHeroScoreTitleText;

		// Token: 0x0400A592 RID: 42386
		[AutoBind("./DetailGroup/ChampionHero/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		public Text ChampionHeroScoreValueText;

		// Token: 0x0400A593 RID: 42387
		[AutoBind("./DetailGroup/RiftChapterStar/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		public Text RiftChapterStarScoreValueText;

		// Token: 0x0400A594 RID: 42388
		[AutoBind("./DetailGroup/RiftAchievement/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		public Text RiftAchievementScoreValueText;

		// Token: 0x0400A595 RID: 42389
		[DoNotToLua]
		private RankingListItemUIController.LuaExportHelper luaExportHelper;

		// Token: 0x0400A596 RID: 42390
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400A597 RID: 42391
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400A598 RID: 42392
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x0400A599 RID: 42393
		private LuaFunction m_Init_hotfix;

		// Token: 0x0400A59A RID: 42394
		private LuaFunction m_RegisterItemClickEventAction;

		// Token: 0x0400A59B RID: 42395
		private LuaFunction m_RegisterItemNeedFillEventAction;

		// Token: 0x0400A59C RID: 42396
		private LuaFunction m_GetItemIndex_hotfix;

		// Token: 0x0400A59D RID: 42397
		private LuaFunction m_UpdateItemInfoRankingListTypeInt32Int32Int32StringInt32String_hotfix;

		// Token: 0x0400A59E RID: 42398
		private LuaFunction m_GetRankLevelSpriteInt32_hotfix;

		// Token: 0x0400A59F RID: 42399
		private LuaFunction m_UpdateDetailInfoRankingListTypeStringInt32_hotfix;

		// Token: 0x02000EB4 RID: 3764
		public new class LuaExportHelper
		{
			// Token: 0x0601265B RID: 75355 RVA: 0x004B97F4 File Offset: 0x004B79F4
			public LuaExportHelper(RankingListItemUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0601265C RID: 75356 RVA: 0x004B9804 File Offset: 0x004B7A04
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0601265D RID: 75357 RVA: 0x004B9814 File Offset: 0x004B7A14
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0601265E RID: 75358 RVA: 0x004B9824 File Offset: 0x004B7A24
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0601265F RID: 75359 RVA: 0x004B9834 File Offset: 0x004B7A34
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x06012660 RID: 75360 RVA: 0x004B984C File Offset: 0x004B7A4C
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x06012661 RID: 75361 RVA: 0x004B985C File Offset: 0x004B7A5C
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x06012662 RID: 75362 RVA: 0x004B986C File Offset: 0x004B7A6C
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x06012663 RID: 75363 RVA: 0x004B987C File Offset: 0x004B7A7C
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x06012664 RID: 75364 RVA: 0x004B988C File Offset: 0x004B7A8C
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x06012665 RID: 75365 RVA: 0x004B989C File Offset: 0x004B7A9C
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x06012666 RID: 75366 RVA: 0x004B98AC File Offset: 0x004B7AAC
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x06012667 RID: 75367 RVA: 0x004B98BC File Offset: 0x004B7ABC
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x06012668 RID: 75368 RVA: 0x004B98CC File Offset: 0x004B7ACC
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x06012669 RID: 75369 RVA: 0x004B98DC File Offset: 0x004B7ADC
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0601266A RID: 75370 RVA: 0x004B98EC File Offset: 0x004B7AEC
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x0601266B RID: 75371 RVA: 0x004B98FC File Offset: 0x004B7AFC
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0601266C RID: 75372 RVA: 0x004B990C File Offset: 0x004B7B0C
			public Sprite GetRankLevelSprite(int rankLevel)
			{
				return this.m_owner.GetRankLevelSprite(rankLevel);
			}

			// Token: 0x0601266D RID: 75373 RVA: 0x004B991C File Offset: 0x004B7B1C
			public void UpdateDetailInfo(RankingListType rankType, string heroName, int score)
			{
				this.m_owner.UpdateDetailInfo(rankType, heroName, score);
			}

			// Token: 0x0400A5A0 RID: 42400
			private RankingListItemUIController m_owner;
		}
	}
}
