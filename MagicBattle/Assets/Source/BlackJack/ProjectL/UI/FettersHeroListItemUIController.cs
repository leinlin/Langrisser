using System;
using System.Threading;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Misc;
using BlackJack.ProjectL.PlayerContext;
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000C8D RID: 3213
	[HotFix]
	public class FettersHeroListItemUIController : UIControllerBase
	{
		// Token: 0x0600E7AB RID: 59307 RVA: 0x003E0B40 File Offset: 0x003DED40
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

		// Token: 0x0600E7AC RID: 59308 RVA: 0x003E0BD4 File Offset: 0x003DEDD4
		public void InitFettersHeroListItem(Hero hero)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitFettersHeroListItemHero_hotfix != null)
			{
				this.m_InitFettersHeroListItemHero_hotfix.call(new object[]
				{
					this,
					hero
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_hero = hero;
			UIUtility.SetGameObjectChildrenActiveCount(this.m_heroStar, this.m_hero.StarLevel);
			this.m_heroLvText.text = this.m_hero.Level.ToString();
			this.m_frameImg.sprite = AssetUtility.Instance.GetSprite(UIUtility.GetHeroItemFrameNameByRank(hero.HeroInfo.GetRank(hero.StarLevel)));
			this.m_ssrFrameEffect.SetActive(this.m_hero.HeroInfo.GetRank(this.m_hero.StarLevel) >= 4);
			this.m_heroIconImg.sprite = AssetUtility.Instance.GetSprite(AssetUtility.MakeSpriteAssetName(this.m_hero.HeroInfo.GetCharImageInfo(this.m_hero.StarLevel).CardHeadImage, "_1"));
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			bool active = projectLPlayerContext.IsHeroFetterHasNewOrLevelUp(hero);
			this.m_redMark.SetActive(active);
			int sex = this.m_hero.HeroInfo.Sex;
			if (sex == 1)
			{
				this.m_stateCtrl.SetToUIState("Male", false, true);
				this.m_favorabilityValueTextRed.text = this.m_hero.FavorabilityLevel.ToString();
			}
			else if (sex == 2)
			{
				this.m_stateCtrl.SetToUIState("Female", false, true);
				this.m_favorabilityValueTextPink.text = this.m_hero.FavorabilityLevel.ToString();
			}
		}

		// Token: 0x0600E7AD RID: 59309 RVA: 0x003E0DD4 File Offset: 0x003DEFD4
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
			if (this.EventOnClick != null)
			{
				this.EventOnClick(this.m_hero);
			}
		}

		// Token: 0x140002F6 RID: 758
		// (add) Token: 0x0600E7AE RID: 59310 RVA: 0x003E0E50 File Offset: 0x003DF050
		// (remove) Token: 0x0600E7AF RID: 59311 RVA: 0x003E0EEC File Offset: 0x003DF0EC
		public event Action<Hero> EventOnClick
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
				Action<Hero> action = this.EventOnClick;
				Action<Hero> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<Hero>>(ref this.EventOnClick, (Action<Hero>)Delegate.Combine(action2, value), action);
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
				Action<Hero> action = this.EventOnClick;
				Action<Hero> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<Hero>>(ref this.EventOnClick, (Action<Hero>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17002CF6 RID: 11510
		// (get) Token: 0x0600E7B0 RID: 59312 RVA: 0x003E0F88 File Offset: 0x003DF188
		// (set) Token: 0x0600E7B1 RID: 59313 RVA: 0x003E0FA8 File Offset: 0x003DF1A8
		[DoNotToLua]
		public new FettersHeroListItemUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new FettersHeroListItemUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600E7B2 RID: 59314 RVA: 0x003E0FB4 File Offset: 0x003DF1B4
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0600E7B3 RID: 59315 RVA: 0x003E0FC0 File Offset: 0x003DF1C0
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0600E7B4 RID: 59316 RVA: 0x003E0FC8 File Offset: 0x003DF1C8
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0600E7B5 RID: 59317 RVA: 0x003E0FD0 File Offset: 0x003DF1D0
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0600E7B6 RID: 59318 RVA: 0x003E0FE4 File Offset: 0x003DF1E4
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0600E7B7 RID: 59319 RVA: 0x003E0FEC File Offset: 0x003DF1EC
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0600E7B8 RID: 59320 RVA: 0x003E0FF8 File Offset: 0x003DF1F8
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0600E7B9 RID: 59321 RVA: 0x003E1004 File Offset: 0x003DF204
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0600E7BA RID: 59322 RVA: 0x003E1010 File Offset: 0x003DF210
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0600E7BB RID: 59323 RVA: 0x003E101C File Offset: 0x003DF21C
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0600E7BC RID: 59324 RVA: 0x003E1028 File Offset: 0x003DF228
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0600E7BD RID: 59325 RVA: 0x003E1034 File Offset: 0x003DF234
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0600E7BE RID: 59326 RVA: 0x003E1040 File Offset: 0x003DF240
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0600E7BF RID: 59327 RVA: 0x003E104C File Offset: 0x003DF24C
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0600E7C0 RID: 59328 RVA: 0x003E1058 File Offset: 0x003DF258
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600E7C1 RID: 59329 RVA: 0x003E1060 File Offset: 0x003DF260
		private void __callDele_EventOnClick(Hero obj)
		{
			Action<Hero> eventOnClick = this.EventOnClick;
			if (eventOnClick != null)
			{
				eventOnClick(obj);
			}
		}

		// Token: 0x0600E7C2 RID: 59330 RVA: 0x003E1084 File Offset: 0x003DF284
		private void __clearDele_EventOnClick(Hero obj)
		{
			this.EventOnClick = null;
		}

		// Token: 0x0600E7C3 RID: 59331 RVA: 0x003E1090 File Offset: 0x003DF290
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
					this.m_InitFettersHeroListItemHero_hotfix = (luaObj.RawGet("InitFettersHeroListItem") as LuaFunction);
					this.m_OnHeroItemClick_hotfix = (luaObj.RawGet("OnHeroItemClick") as LuaFunction);
					this.m_add_EventOnClickAction`1_hotfix = (luaObj.RawGet("add_EventOnClick") as LuaFunction);
					this.m_remove_EventOnClickAction`1_hotfix = (luaObj.RawGet("remove_EventOnClick") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600E7C4 RID: 59332 RVA: 0x003E11C0 File Offset: 0x003DF3C0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(FettersHeroListItemUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04008B6F RID: 35695
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_stateCtrl;

		// Token: 0x04008B70 RID: 35696
		[AutoBind("./HeroStars", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_heroStar;

		// Token: 0x04008B71 RID: 35697
		[AutoBind("./HeroLvText/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_heroLvText;

		// Token: 0x04008B72 RID: 35698
		[AutoBind("./SSRFrameEffect", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_ssrFrameEffect;

		// Token: 0x04008B73 RID: 35699
		[AutoBind("./FrameImg", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_frameImg;

		// Token: 0x04008B74 RID: 35700
		[AutoBind("./HeroIcon", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_heroIconImg;

		// Token: 0x04008B75 RID: 35701
		[AutoBind("./RedMark", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_redMark;

		// Token: 0x04008B76 RID: 35702
		[AutoBind("./HeartImage/ValueTextRed", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_favorabilityValueTextRed;

		// Token: 0x04008B77 RID: 35703
		[AutoBind("./HeartImage/ValueTextPink", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_favorabilityValueTextPink;

		// Token: 0x04008B78 RID: 35704
		public Hero m_hero;

		// Token: 0x04008B79 RID: 35705
		[DoNotToLua]
		private FettersHeroListItemUIController.LuaExportHelper luaExportHelper;

		// Token: 0x04008B7A RID: 35706
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04008B7B RID: 35707
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04008B7C RID: 35708
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x04008B7D RID: 35709
		private LuaFunction m_InitFettersHeroListItemHero_hotfix;

		// Token: 0x04008B7E RID: 35710
		private LuaFunction m_OnHeroItemClick_hotfix;

		// Token: 0x04008B7F RID: 35711
		private LuaFunction m_add_EventOnClickAction;

		// Token: 0x04008B80 RID: 35712
		private LuaFunction m_remove_EventOnClickAction;

		// Token: 0x02000C8E RID: 3214
		public new class LuaExportHelper
		{
			// Token: 0x0600E7C5 RID: 59333 RVA: 0x003E1228 File Offset: 0x003DF428
			public LuaExportHelper(FettersHeroListItemUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600E7C6 RID: 59334 RVA: 0x003E1238 File Offset: 0x003DF438
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0600E7C7 RID: 59335 RVA: 0x003E1248 File Offset: 0x003DF448
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0600E7C8 RID: 59336 RVA: 0x003E1258 File Offset: 0x003DF458
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600E7C9 RID: 59337 RVA: 0x003E1268 File Offset: 0x003DF468
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600E7CA RID: 59338 RVA: 0x003E1280 File Offset: 0x003DF480
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0600E7CB RID: 59339 RVA: 0x003E1290 File Offset: 0x003DF490
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0600E7CC RID: 59340 RVA: 0x003E12A0 File Offset: 0x003DF4A0
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0600E7CD RID: 59341 RVA: 0x003E12B0 File Offset: 0x003DF4B0
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0600E7CE RID: 59342 RVA: 0x003E12C0 File Offset: 0x003DF4C0
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0600E7CF RID: 59343 RVA: 0x003E12D0 File Offset: 0x003DF4D0
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0600E7D0 RID: 59344 RVA: 0x003E12E0 File Offset: 0x003DF4E0
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0600E7D1 RID: 59345 RVA: 0x003E12F0 File Offset: 0x003DF4F0
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0600E7D2 RID: 59346 RVA: 0x003E1300 File Offset: 0x003DF500
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0600E7D3 RID: 59347 RVA: 0x003E1310 File Offset: 0x003DF510
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0600E7D4 RID: 59348 RVA: 0x003E1320 File Offset: 0x003DF520
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x0600E7D5 RID: 59349 RVA: 0x003E1330 File Offset: 0x003DF530
			public void __callDele_EventOnClick(Hero obj)
			{
				this.m_owner.__callDele_EventOnClick(obj);
			}

			// Token: 0x0600E7D6 RID: 59350 RVA: 0x003E1340 File Offset: 0x003DF540
			public void __clearDele_EventOnClick(Hero obj)
			{
				this.m_owner.__clearDele_EventOnClick(obj);
			}

			// Token: 0x17002CF7 RID: 11511
			// (get) Token: 0x0600E7D7 RID: 59351 RVA: 0x003E1350 File Offset: 0x003DF550
			// (set) Token: 0x0600E7D8 RID: 59352 RVA: 0x003E1360 File Offset: 0x003DF560
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

			// Token: 0x17002CF8 RID: 11512
			// (get) Token: 0x0600E7D9 RID: 59353 RVA: 0x003E1370 File Offset: 0x003DF570
			// (set) Token: 0x0600E7DA RID: 59354 RVA: 0x003E1380 File Offset: 0x003DF580
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

			// Token: 0x17002CF9 RID: 11513
			// (get) Token: 0x0600E7DB RID: 59355 RVA: 0x003E1390 File Offset: 0x003DF590
			// (set) Token: 0x0600E7DC RID: 59356 RVA: 0x003E13A0 File Offset: 0x003DF5A0
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

			// Token: 0x17002CFA RID: 11514
			// (get) Token: 0x0600E7DD RID: 59357 RVA: 0x003E13B0 File Offset: 0x003DF5B0
			// (set) Token: 0x0600E7DE RID: 59358 RVA: 0x003E13C0 File Offset: 0x003DF5C0
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

			// Token: 0x17002CFB RID: 11515
			// (get) Token: 0x0600E7DF RID: 59359 RVA: 0x003E13D0 File Offset: 0x003DF5D0
			// (set) Token: 0x0600E7E0 RID: 59360 RVA: 0x003E13E0 File Offset: 0x003DF5E0
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

			// Token: 0x17002CFC RID: 11516
			// (get) Token: 0x0600E7E1 RID: 59361 RVA: 0x003E13F0 File Offset: 0x003DF5F0
			// (set) Token: 0x0600E7E2 RID: 59362 RVA: 0x003E1400 File Offset: 0x003DF600
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

			// Token: 0x17002CFD RID: 11517
			// (get) Token: 0x0600E7E3 RID: 59363 RVA: 0x003E1410 File Offset: 0x003DF610
			// (set) Token: 0x0600E7E4 RID: 59364 RVA: 0x003E1420 File Offset: 0x003DF620
			public GameObject m_redMark
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

			// Token: 0x17002CFE RID: 11518
			// (get) Token: 0x0600E7E5 RID: 59365 RVA: 0x003E1430 File Offset: 0x003DF630
			// (set) Token: 0x0600E7E6 RID: 59366 RVA: 0x003E1440 File Offset: 0x003DF640
			public Text m_favorabilityValueTextRed
			{
				get
				{
					return this.m_owner.m_favorabilityValueTextRed;
				}
				set
				{
					this.m_owner.m_favorabilityValueTextRed = value;
				}
			}

			// Token: 0x17002CFF RID: 11519
			// (get) Token: 0x0600E7E7 RID: 59367 RVA: 0x003E1450 File Offset: 0x003DF650
			// (set) Token: 0x0600E7E8 RID: 59368 RVA: 0x003E1460 File Offset: 0x003DF660
			public Text m_favorabilityValueTextPink
			{
				get
				{
					return this.m_owner.m_favorabilityValueTextPink;
				}
				set
				{
					this.m_owner.m_favorabilityValueTextPink = value;
				}
			}

			// Token: 0x0600E7E9 RID: 59369 RVA: 0x003E1470 File Offset: 0x003DF670
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0600E7EA RID: 59370 RVA: 0x003E1480 File Offset: 0x003DF680
			public void OnHeroItemClick()
			{
				this.m_owner.OnHeroItemClick();
			}

			// Token: 0x04008B81 RID: 35713
			private FettersHeroListItemUIController m_owner;
		}
	}
}
