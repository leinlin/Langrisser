using System;
using System.Collections;
using System.Diagnostics;
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
	// Token: 0x02000D77 RID: 3447
	[HotFix]
	public class HeroBreakEffectUIController : UIControllerBase
	{
		// Token: 0x0600FFF7 RID: 65527 RVA: 0x00431E00 File Offset: 0x00430000
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
			this.m_heroBreakEffectReturnButton.onClick.AddListener(new UnityAction(this.OnReturnButtonClick));
			base.gameObject.SetActive(true);
			this.m_heroCharUIController = GameObjectUtility.AddControllerToGameObject<HeroCharUIController>(this.m_heroCharGameObject);
			this.m_playerContext = (GameManager.Instance.PlayerContext as ProjectLPlayerContext);
			this.m_configDataLoader = (GameManager.Instance.ConfigDataLoader as IConfigDataLoader);
		}

		// Token: 0x0600FFF8 RID: 65528 RVA: 0x00431ECC File Offset: 0x004300CC
		public void HeroBreakEffectUpdateView(int heroId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HeroBreakEffectUpdateViewInt32_hotfix != null)
			{
				this.m_HeroBreakEffectUpdateViewInt32_hotfix.call(new object[]
				{
					this,
					heroId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_hero = this.m_playerContext.GetHero(heroId);
			this.SetBreakHeroInfo();
			string stateName = "Show" + this.m_hero.StarLevel;
			this.m_stateCtrl.SetToUIState(stateName, false, true);
			base.StartCoroutine(this.ShowStarEffect());
		}

		// Token: 0x0600FFF9 RID: 65529 RVA: 0x00431F8C File Offset: 0x0043018C
		private void SetBreakHeroInfo()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetBreakHeroInfo_hotfix != null)
			{
				this.m_SetBreakHeroInfo_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_heroCharUIController.GetCharImageInfo() != this.m_hero.HeroInfo.GetCharImageInfo(this.m_hero.StarLevel))
			{
				this.m_heroCharUIController.CreateGraphic(this.m_hero, HeroCharUIController.PerformanceState.Break, false, null);
				this.m_heroCharUIController.PlayAnimation("idle_Normal", false);
			}
			HeroPropertyComputer heroPropertyComputer = new HeroPropertyComputer();
			heroPropertyComputer.Init(this.m_configDataLoader);
			HeroPropertyComputer heroPropertyComputer2 = heroPropertyComputer;
			Hero hero = this.m_hero;
			int jobRelatedId = this.m_hero.GetActiveJob().JobRelatedId;
			int starLevel = this.m_hero.StarLevel - 1;
			int starLevel2 = this.m_hero.StarLevel;
			heroPropertyComputer2.ComputeHeroProperties(hero, jobRelatedId, -1, -1, starLevel, starLevel2, -1, -1);
			this.m_heroBreakSuccessInfoHpText.text = heroPropertyComputer.Property0.HealthPointMax.ToString();
			this.m_heroBreakSuccessInfoHpAddText.text = (heroPropertyComputer.Property1.HealthPointMax - heroPropertyComputer.Property0.HealthPointMax).ToString();
			this.m_heroBreakSuccessInfoATText.text = heroPropertyComputer.Property0.Attack.ToString();
			this.m_heroBreakSuccessInfoATAddText.text = (heroPropertyComputer.Property1.Attack - heroPropertyComputer.Property0.Attack).ToString();
			this.m_heroBreakSuccessInfoMagicText.text = heroPropertyComputer.Property0.Magic.ToString();
			this.m_heroBreakSuccessInfoMagicAddText.text = (heroPropertyComputer.Property1.Magic - heroPropertyComputer.Property0.Magic).ToString();
			this.m_heroBreakSuccessInfoDFText.text = heroPropertyComputer.Property0.Defense.ToString();
			this.m_heroBreakSuccessInfoDFAddText.text = (heroPropertyComputer.Property1.Defense - heroPropertyComputer.Property0.Defense).ToString();
			this.m_heroBreakSuccessInfoMagicDFText.text = heroPropertyComputer.Property0.MagicDefense.ToString();
			this.m_heroBreakSuccessInfoMagicDFAddText.text = (heroPropertyComputer.Property1.MagicDefense - heroPropertyComputer.Property0.MagicDefense).ToString();
			this.m_heroBreakSuccessInfoDexText.text = heroPropertyComputer.Property0.Dexterity.ToString();
			this.m_heroBreakSuccessInfoDexAddText.text = (heroPropertyComputer.Property1.Dexterity - heroPropertyComputer.Property0.Dexterity).ToString();
			UIUtility.ReverseShowGameObjectChildrenByActive(this.m_heroStarGroup, this.m_hero.StarLevel - 1);
			ConfigDataSkillInfo talentSkillInfo = this.m_hero.GetActiveJob().JobConnectionInfo.GetTalentSkillInfo(this.m_hero.StarLevel - 1);
			if (talentSkillInfo != null)
			{
				this.m_talent1Icon.sprite = AssetUtility.Instance.GetSprite(talentSkillInfo.Icon);
				this.m_talent1NameText.text = talentSkillInfo.Name;
				this.m_talent1DescText.text = talentSkillInfo.Desc;
			}
			ConfigDataSkillInfo talentSkillInfo2 = this.m_hero.GetActiveJob().JobConnectionInfo.GetTalentSkillInfo(this.m_hero.StarLevel);
			if (talentSkillInfo2 != null)
			{
				this.m_talent2Icon.sprite = AssetUtility.Instance.GetSprite(talentSkillInfo2.Icon);
				this.m_talent2NameText.text = talentSkillInfo2.Name;
				this.m_talent2DescText.text = talentSkillInfo2.Desc;
			}
		}

		// Token: 0x0600FFFA RID: 65530 RVA: 0x00432368 File Offset: 0x00430568
		[DebuggerHidden]
		private IEnumerator ShowStarEffect()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowStarEffect_hotfix != null)
			{
				return (IEnumerator)this.m_ShowStarEffect_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			HeroBreakEffectUIController.<ShowStarEffect>c__Iterator0 <ShowStarEffect>c__Iterator = new HeroBreakEffectUIController.<ShowStarEffect>c__Iterator0();
			<ShowStarEffect>c__Iterator.$this = this;
			return <ShowStarEffect>c__Iterator;
		}

		// Token: 0x0600FFFB RID: 65531 RVA: 0x004323E4 File Offset: 0x004305E4
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
			this.m_heroCharBreakSuccessEffect.SetActive(false);
			if (this.EventOnReturn != null)
			{
				this.EventOnReturn();
			}
		}

		// Token: 0x0600FFFC RID: 65532 RVA: 0x00432468 File Offset: 0x00430668
		public void Open()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Open_hotfix != null)
			{
				this.m_Open_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x0600FFFD RID: 65533 RVA: 0x004324C8 File Offset: 0x004306C8
		public void Close()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Close_hotfix != null)
			{
				this.m_Close_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x1400035E RID: 862
		// (add) Token: 0x0600FFFE RID: 65534 RVA: 0x00432528 File Offset: 0x00430728
		// (remove) Token: 0x0600FFFF RID: 65535 RVA: 0x004325C4 File Offset: 0x004307C4
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

		// Token: 0x17003130 RID: 12592
		// (get) Token: 0x06010000 RID: 65536 RVA: 0x00432660 File Offset: 0x00430860
		// (set) Token: 0x06010001 RID: 65537 RVA: 0x00432680 File Offset: 0x00430880
		[DoNotToLua]
		public new HeroBreakEffectUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new HeroBreakEffectUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06010002 RID: 65538 RVA: 0x0043268C File Offset: 0x0043088C
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x06010003 RID: 65539 RVA: 0x00432698 File Offset: 0x00430898
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x06010004 RID: 65540 RVA: 0x004326A0 File Offset: 0x004308A0
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x06010005 RID: 65541 RVA: 0x004326A8 File Offset: 0x004308A8
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x06010006 RID: 65542 RVA: 0x004326BC File Offset: 0x004308BC
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x06010007 RID: 65543 RVA: 0x004326C4 File Offset: 0x004308C4
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x06010008 RID: 65544 RVA: 0x004326D0 File Offset: 0x004308D0
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x06010009 RID: 65545 RVA: 0x004326DC File Offset: 0x004308DC
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0601000A RID: 65546 RVA: 0x004326E8 File Offset: 0x004308E8
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0601000B RID: 65547 RVA: 0x004326F4 File Offset: 0x004308F4
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0601000C RID: 65548 RVA: 0x00432700 File Offset: 0x00430900
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0601000D RID: 65549 RVA: 0x0043270C File Offset: 0x0043090C
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0601000E RID: 65550 RVA: 0x00432718 File Offset: 0x00430918
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0601000F RID: 65551 RVA: 0x00432724 File Offset: 0x00430924
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x06010010 RID: 65552 RVA: 0x00432730 File Offset: 0x00430930
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x06010011 RID: 65553 RVA: 0x00432738 File Offset: 0x00430938
		private void __callDele_EventOnReturn()
		{
			Action eventOnReturn = this.EventOnReturn;
			if (eventOnReturn != null)
			{
				eventOnReturn();
			}
		}

		// Token: 0x06010012 RID: 65554 RVA: 0x00432758 File Offset: 0x00430958
		private void __clearDele_EventOnReturn()
		{
			this.EventOnReturn = null;
		}

		// Token: 0x06010013 RID: 65555 RVA: 0x00432764 File Offset: 0x00430964
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
					this.m_HeroBreakEffectUpdateViewInt32_hotfix = (luaObj.RawGet("HeroBreakEffectUpdateView") as LuaFunction);
					this.m_SetBreakHeroInfo_hotfix = (luaObj.RawGet("SetBreakHeroInfo") as LuaFunction);
					this.m_ShowStarEffect_hotfix = (luaObj.RawGet("ShowStarEffect") as LuaFunction);
					this.m_OnReturnButtonClick_hotfix = (luaObj.RawGet("OnReturnButtonClick") as LuaFunction);
					this.m_Open_hotfix = (luaObj.RawGet("Open") as LuaFunction);
					this.m_Close_hotfix = (luaObj.RawGet("Close") as LuaFunction);
					this.m_add_EventOnReturnAction_hotfix = (luaObj.RawGet("add_EventOnReturn") as LuaFunction);
					this.m_remove_EventOnReturnAction_hotfix = (luaObj.RawGet("remove_EventOnReturn") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06010014 RID: 65556 RVA: 0x004328F8 File Offset: 0x00430AF8
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(HeroBreakEffectUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400959C RID: 38300
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_stateCtrl;

		// Token: 0x0400959D RID: 38301
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_heroCharGameObject;

		// Token: 0x0400959E RID: 38302
		[AutoBind("./Char/0/U_BreakSuccess", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_heroCharBreakSuccessEffect;

		// Token: 0x0400959F RID: 38303
		[AutoBind("./ClickScreenContinue", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_heroBreakEffectReturnButton;

		// Token: 0x040095A0 RID: 38304
		[AutoBind("./BreakSuccessInfoPanel/Detail/Hp/NowNumberText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_heroBreakSuccessInfoHpText;

		// Token: 0x040095A1 RID: 38305
		[AutoBind("./BreakSuccessInfoPanel/Detail/Hp/AddNumberText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_heroBreakSuccessInfoHpAddText;

		// Token: 0x040095A2 RID: 38306
		[AutoBind("./BreakSuccessInfoPanel/Detail/AT/NowNumberText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_heroBreakSuccessInfoATText;

		// Token: 0x040095A3 RID: 38307
		[AutoBind("./BreakSuccessInfoPanel/Detail/AT/AddNumberText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_heroBreakSuccessInfoATAddText;

		// Token: 0x040095A4 RID: 38308
		[AutoBind("./BreakSuccessInfoPanel/Detail/Magic/NowNumberText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_heroBreakSuccessInfoMagicText;

		// Token: 0x040095A5 RID: 38309
		[AutoBind("./BreakSuccessInfoPanel/Detail/Magic/AddNumberText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_heroBreakSuccessInfoMagicAddText;

		// Token: 0x040095A6 RID: 38310
		[AutoBind("./BreakSuccessInfoPanel/Detail/DF/NowNumberText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_heroBreakSuccessInfoDFText;

		// Token: 0x040095A7 RID: 38311
		[AutoBind("./BreakSuccessInfoPanel/Detail/DF/AddNumberText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_heroBreakSuccessInfoDFAddText;

		// Token: 0x040095A8 RID: 38312
		[AutoBind("./BreakSuccessInfoPanel/Detail/MagicDF/NowNumberText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_heroBreakSuccessInfoMagicDFText;

		// Token: 0x040095A9 RID: 38313
		[AutoBind("./BreakSuccessInfoPanel/Detail/MagicDF/AddNumberText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_heroBreakSuccessInfoMagicDFAddText;

		// Token: 0x040095AA RID: 38314
		[AutoBind("./BreakSuccessInfoPanel/Detail/Dex/NowNumberText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_heroBreakSuccessInfoDexText;

		// Token: 0x040095AB RID: 38315
		[AutoBind("./BreakSuccessInfoPanel/Detail/Dex/AddNumberText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_heroBreakSuccessInfoDexAddText;

		// Token: 0x040095AC RID: 38316
		[AutoBind("./UnderGroup/StarGroup", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_heroStarGroup;

		// Token: 0x040095AD RID: 38317
		[AutoBind("./BigStar/BigStarEffect/U_StarGold_3.8", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_bigStarEffect;

		// Token: 0x040095AE RID: 38318
		[AutoBind("./BigStar/U_StarGold_trail", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_bigStarTrailEffect;

		// Token: 0x040095AF RID: 38319
		[AutoBind("./TalentLevelUpPanel/FrameImage/Talent1/BgImage/InfoGroup/Icon/Image", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_talent1Icon;

		// Token: 0x040095B0 RID: 38320
		[AutoBind("./TalentLevelUpPanel/FrameImage/Talent1/BgImage/InfoGroup/Desc/NameText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_talent1NameText;

		// Token: 0x040095B1 RID: 38321
		[AutoBind("./TalentLevelUpPanel/FrameImage/Talent1/BgImage/InfoGroup/Desc/DescText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_talent1DescText;

		// Token: 0x040095B2 RID: 38322
		[AutoBind("./TalentLevelUpPanel/FrameImage/Talent2/BgImage/InfoGroup/Icon/Image", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_talent2Icon;

		// Token: 0x040095B3 RID: 38323
		[AutoBind("./TalentLevelUpPanel/FrameImage/Talent2/BgImage/InfoGroup/Desc/NameText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_talent2NameText;

		// Token: 0x040095B4 RID: 38324
		[AutoBind("./TalentLevelUpPanel/FrameImage/Talent2/BgImage/InfoGroup/Desc/DescText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_talent2DescText;

		// Token: 0x040095B6 RID: 38326
		private Hero m_hero;

		// Token: 0x040095B7 RID: 38327
		private HeroCharUIController m_heroCharUIController;

		// Token: 0x040095B8 RID: 38328
		private ProjectLPlayerContext m_playerContext;

		// Token: 0x040095B9 RID: 38329
		private IConfigDataLoader m_configDataLoader;

		// Token: 0x040095BA RID: 38330
		[DoNotToLua]
		private HeroBreakEffectUIController.LuaExportHelper luaExportHelper;

		// Token: 0x040095BB RID: 38331
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040095BC RID: 38332
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040095BD RID: 38333
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x040095BE RID: 38334
		private LuaFunction m_HeroBreakEffectUpdateViewInt32_hotfix;

		// Token: 0x040095BF RID: 38335
		private LuaFunction m_SetBreakHeroInfo_hotfix;

		// Token: 0x040095C0 RID: 38336
		private LuaFunction m_ShowStarEffect_hotfix;

		// Token: 0x040095C1 RID: 38337
		private LuaFunction m_OnReturnButtonClick_hotfix;

		// Token: 0x040095C2 RID: 38338
		private LuaFunction m_Open_hotfix;

		// Token: 0x040095C3 RID: 38339
		private LuaFunction m_Close_hotfix;

		// Token: 0x040095C4 RID: 38340
		private LuaFunction m_add_EventOnReturnAction_hotfix;

		// Token: 0x040095C5 RID: 38341
		private LuaFunction m_remove_EventOnReturnAction_hotfix;

		// Token: 0x02000D78 RID: 3448
		public new class LuaExportHelper
		{
			// Token: 0x06010015 RID: 65557 RVA: 0x00432960 File Offset: 0x00430B60
			public LuaExportHelper(HeroBreakEffectUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06010016 RID: 65558 RVA: 0x00432970 File Offset: 0x00430B70
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x06010017 RID: 65559 RVA: 0x00432980 File Offset: 0x00430B80
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x06010018 RID: 65560 RVA: 0x00432990 File Offset: 0x00430B90
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x06010019 RID: 65561 RVA: 0x004329A0 File Offset: 0x00430BA0
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0601001A RID: 65562 RVA: 0x004329B8 File Offset: 0x00430BB8
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0601001B RID: 65563 RVA: 0x004329C8 File Offset: 0x00430BC8
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0601001C RID: 65564 RVA: 0x004329D8 File Offset: 0x00430BD8
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0601001D RID: 65565 RVA: 0x004329E8 File Offset: 0x00430BE8
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0601001E RID: 65566 RVA: 0x004329F8 File Offset: 0x00430BF8
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0601001F RID: 65567 RVA: 0x00432A08 File Offset: 0x00430C08
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x06010020 RID: 65568 RVA: 0x00432A18 File Offset: 0x00430C18
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x06010021 RID: 65569 RVA: 0x00432A28 File Offset: 0x00430C28
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x06010022 RID: 65570 RVA: 0x00432A38 File Offset: 0x00430C38
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x06010023 RID: 65571 RVA: 0x00432A48 File Offset: 0x00430C48
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x06010024 RID: 65572 RVA: 0x00432A58 File Offset: 0x00430C58
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x06010025 RID: 65573 RVA: 0x00432A68 File Offset: 0x00430C68
			public void __callDele_EventOnReturn()
			{
				this.m_owner.__callDele_EventOnReturn();
			}

			// Token: 0x06010026 RID: 65574 RVA: 0x00432A78 File Offset: 0x00430C78
			public void __clearDele_EventOnReturn()
			{
				this.m_owner.__clearDele_EventOnReturn();
			}

			// Token: 0x17003131 RID: 12593
			// (get) Token: 0x06010027 RID: 65575 RVA: 0x00432A88 File Offset: 0x00430C88
			// (set) Token: 0x06010028 RID: 65576 RVA: 0x00432A98 File Offset: 0x00430C98
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

			// Token: 0x17003132 RID: 12594
			// (get) Token: 0x06010029 RID: 65577 RVA: 0x00432AA8 File Offset: 0x00430CA8
			// (set) Token: 0x0601002A RID: 65578 RVA: 0x00432AB8 File Offset: 0x00430CB8
			public GameObject m_heroCharGameObject
			{
				get
				{
					return this.m_owner.m_heroCharGameObject;
				}
				set
				{
					this.m_owner.m_heroCharGameObject = value;
				}
			}

			// Token: 0x17003133 RID: 12595
			// (get) Token: 0x0601002B RID: 65579 RVA: 0x00432AC8 File Offset: 0x00430CC8
			// (set) Token: 0x0601002C RID: 65580 RVA: 0x00432AD8 File Offset: 0x00430CD8
			public GameObject m_heroCharBreakSuccessEffect
			{
				get
				{
					return this.m_owner.m_heroCharBreakSuccessEffect;
				}
				set
				{
					this.m_owner.m_heroCharBreakSuccessEffect = value;
				}
			}

			// Token: 0x17003134 RID: 12596
			// (get) Token: 0x0601002D RID: 65581 RVA: 0x00432AE8 File Offset: 0x00430CE8
			// (set) Token: 0x0601002E RID: 65582 RVA: 0x00432AF8 File Offset: 0x00430CF8
			public Button m_heroBreakEffectReturnButton
			{
				get
				{
					return this.m_owner.m_heroBreakEffectReturnButton;
				}
				set
				{
					this.m_owner.m_heroBreakEffectReturnButton = value;
				}
			}

			// Token: 0x17003135 RID: 12597
			// (get) Token: 0x0601002F RID: 65583 RVA: 0x00432B08 File Offset: 0x00430D08
			// (set) Token: 0x06010030 RID: 65584 RVA: 0x00432B18 File Offset: 0x00430D18
			public Text m_heroBreakSuccessInfoHpText
			{
				get
				{
					return this.m_owner.m_heroBreakSuccessInfoHpText;
				}
				set
				{
					this.m_owner.m_heroBreakSuccessInfoHpText = value;
				}
			}

			// Token: 0x17003136 RID: 12598
			// (get) Token: 0x06010031 RID: 65585 RVA: 0x00432B28 File Offset: 0x00430D28
			// (set) Token: 0x06010032 RID: 65586 RVA: 0x00432B38 File Offset: 0x00430D38
			public Text m_heroBreakSuccessInfoHpAddText
			{
				get
				{
					return this.m_owner.m_heroBreakSuccessInfoHpAddText;
				}
				set
				{
					this.m_owner.m_heroBreakSuccessInfoHpAddText = value;
				}
			}

			// Token: 0x17003137 RID: 12599
			// (get) Token: 0x06010033 RID: 65587 RVA: 0x00432B48 File Offset: 0x00430D48
			// (set) Token: 0x06010034 RID: 65588 RVA: 0x00432B58 File Offset: 0x00430D58
			public Text m_heroBreakSuccessInfoATText
			{
				get
				{
					return this.m_owner.m_heroBreakSuccessInfoATText;
				}
				set
				{
					this.m_owner.m_heroBreakSuccessInfoATText = value;
				}
			}

			// Token: 0x17003138 RID: 12600
			// (get) Token: 0x06010035 RID: 65589 RVA: 0x00432B68 File Offset: 0x00430D68
			// (set) Token: 0x06010036 RID: 65590 RVA: 0x00432B78 File Offset: 0x00430D78
			public Text m_heroBreakSuccessInfoATAddText
			{
				get
				{
					return this.m_owner.m_heroBreakSuccessInfoATAddText;
				}
				set
				{
					this.m_owner.m_heroBreakSuccessInfoATAddText = value;
				}
			}

			// Token: 0x17003139 RID: 12601
			// (get) Token: 0x06010037 RID: 65591 RVA: 0x00432B88 File Offset: 0x00430D88
			// (set) Token: 0x06010038 RID: 65592 RVA: 0x00432B98 File Offset: 0x00430D98
			public Text m_heroBreakSuccessInfoMagicText
			{
				get
				{
					return this.m_owner.m_heroBreakSuccessInfoMagicText;
				}
				set
				{
					this.m_owner.m_heroBreakSuccessInfoMagicText = value;
				}
			}

			// Token: 0x1700313A RID: 12602
			// (get) Token: 0x06010039 RID: 65593 RVA: 0x00432BA8 File Offset: 0x00430DA8
			// (set) Token: 0x0601003A RID: 65594 RVA: 0x00432BB8 File Offset: 0x00430DB8
			public Text m_heroBreakSuccessInfoMagicAddText
			{
				get
				{
					return this.m_owner.m_heroBreakSuccessInfoMagicAddText;
				}
				set
				{
					this.m_owner.m_heroBreakSuccessInfoMagicAddText = value;
				}
			}

			// Token: 0x1700313B RID: 12603
			// (get) Token: 0x0601003B RID: 65595 RVA: 0x00432BC8 File Offset: 0x00430DC8
			// (set) Token: 0x0601003C RID: 65596 RVA: 0x00432BD8 File Offset: 0x00430DD8
			public Text m_heroBreakSuccessInfoDFText
			{
				get
				{
					return this.m_owner.m_heroBreakSuccessInfoDFText;
				}
				set
				{
					this.m_owner.m_heroBreakSuccessInfoDFText = value;
				}
			}

			// Token: 0x1700313C RID: 12604
			// (get) Token: 0x0601003D RID: 65597 RVA: 0x00432BE8 File Offset: 0x00430DE8
			// (set) Token: 0x0601003E RID: 65598 RVA: 0x00432BF8 File Offset: 0x00430DF8
			public Text m_heroBreakSuccessInfoDFAddText
			{
				get
				{
					return this.m_owner.m_heroBreakSuccessInfoDFAddText;
				}
				set
				{
					this.m_owner.m_heroBreakSuccessInfoDFAddText = value;
				}
			}

			// Token: 0x1700313D RID: 12605
			// (get) Token: 0x0601003F RID: 65599 RVA: 0x00432C08 File Offset: 0x00430E08
			// (set) Token: 0x06010040 RID: 65600 RVA: 0x00432C18 File Offset: 0x00430E18
			public Text m_heroBreakSuccessInfoMagicDFText
			{
				get
				{
					return this.m_owner.m_heroBreakSuccessInfoMagicDFText;
				}
				set
				{
					this.m_owner.m_heroBreakSuccessInfoMagicDFText = value;
				}
			}

			// Token: 0x1700313E RID: 12606
			// (get) Token: 0x06010041 RID: 65601 RVA: 0x00432C28 File Offset: 0x00430E28
			// (set) Token: 0x06010042 RID: 65602 RVA: 0x00432C38 File Offset: 0x00430E38
			public Text m_heroBreakSuccessInfoMagicDFAddText
			{
				get
				{
					return this.m_owner.m_heroBreakSuccessInfoMagicDFAddText;
				}
				set
				{
					this.m_owner.m_heroBreakSuccessInfoMagicDFAddText = value;
				}
			}

			// Token: 0x1700313F RID: 12607
			// (get) Token: 0x06010043 RID: 65603 RVA: 0x00432C48 File Offset: 0x00430E48
			// (set) Token: 0x06010044 RID: 65604 RVA: 0x00432C58 File Offset: 0x00430E58
			public Text m_heroBreakSuccessInfoDexText
			{
				get
				{
					return this.m_owner.m_heroBreakSuccessInfoDexText;
				}
				set
				{
					this.m_owner.m_heroBreakSuccessInfoDexText = value;
				}
			}

			// Token: 0x17003140 RID: 12608
			// (get) Token: 0x06010045 RID: 65605 RVA: 0x00432C68 File Offset: 0x00430E68
			// (set) Token: 0x06010046 RID: 65606 RVA: 0x00432C78 File Offset: 0x00430E78
			public Text m_heroBreakSuccessInfoDexAddText
			{
				get
				{
					return this.m_owner.m_heroBreakSuccessInfoDexAddText;
				}
				set
				{
					this.m_owner.m_heroBreakSuccessInfoDexAddText = value;
				}
			}

			// Token: 0x17003141 RID: 12609
			// (get) Token: 0x06010047 RID: 65607 RVA: 0x00432C88 File Offset: 0x00430E88
			// (set) Token: 0x06010048 RID: 65608 RVA: 0x00432C98 File Offset: 0x00430E98
			public GameObject m_heroStarGroup
			{
				get
				{
					return this.m_owner.m_heroStarGroup;
				}
				set
				{
					this.m_owner.m_heroStarGroup = value;
				}
			}

			// Token: 0x17003142 RID: 12610
			// (get) Token: 0x06010049 RID: 65609 RVA: 0x00432CA8 File Offset: 0x00430EA8
			// (set) Token: 0x0601004A RID: 65610 RVA: 0x00432CB8 File Offset: 0x00430EB8
			public GameObject m_bigStarEffect
			{
				get
				{
					return this.m_owner.m_bigStarEffect;
				}
				set
				{
					this.m_owner.m_bigStarEffect = value;
				}
			}

			// Token: 0x17003143 RID: 12611
			// (get) Token: 0x0601004B RID: 65611 RVA: 0x00432CC8 File Offset: 0x00430EC8
			// (set) Token: 0x0601004C RID: 65612 RVA: 0x00432CD8 File Offset: 0x00430ED8
			public GameObject m_bigStarTrailEffect
			{
				get
				{
					return this.m_owner.m_bigStarTrailEffect;
				}
				set
				{
					this.m_owner.m_bigStarTrailEffect = value;
				}
			}

			// Token: 0x17003144 RID: 12612
			// (get) Token: 0x0601004D RID: 65613 RVA: 0x00432CE8 File Offset: 0x00430EE8
			// (set) Token: 0x0601004E RID: 65614 RVA: 0x00432CF8 File Offset: 0x00430EF8
			public Image m_talent1Icon
			{
				get
				{
					return this.m_owner.m_talent1Icon;
				}
				set
				{
					this.m_owner.m_talent1Icon = value;
				}
			}

			// Token: 0x17003145 RID: 12613
			// (get) Token: 0x0601004F RID: 65615 RVA: 0x00432D08 File Offset: 0x00430F08
			// (set) Token: 0x06010050 RID: 65616 RVA: 0x00432D18 File Offset: 0x00430F18
			public Text m_talent1NameText
			{
				get
				{
					return this.m_owner.m_talent1NameText;
				}
				set
				{
					this.m_owner.m_talent1NameText = value;
				}
			}

			// Token: 0x17003146 RID: 12614
			// (get) Token: 0x06010051 RID: 65617 RVA: 0x00432D28 File Offset: 0x00430F28
			// (set) Token: 0x06010052 RID: 65618 RVA: 0x00432D38 File Offset: 0x00430F38
			public Text m_talent1DescText
			{
				get
				{
					return this.m_owner.m_talent1DescText;
				}
				set
				{
					this.m_owner.m_talent1DescText = value;
				}
			}

			// Token: 0x17003147 RID: 12615
			// (get) Token: 0x06010053 RID: 65619 RVA: 0x00432D48 File Offset: 0x00430F48
			// (set) Token: 0x06010054 RID: 65620 RVA: 0x00432D58 File Offset: 0x00430F58
			public Image m_talent2Icon
			{
				get
				{
					return this.m_owner.m_talent2Icon;
				}
				set
				{
					this.m_owner.m_talent2Icon = value;
				}
			}

			// Token: 0x17003148 RID: 12616
			// (get) Token: 0x06010055 RID: 65621 RVA: 0x00432D68 File Offset: 0x00430F68
			// (set) Token: 0x06010056 RID: 65622 RVA: 0x00432D78 File Offset: 0x00430F78
			public Text m_talent2NameText
			{
				get
				{
					return this.m_owner.m_talent2NameText;
				}
				set
				{
					this.m_owner.m_talent2NameText = value;
				}
			}

			// Token: 0x17003149 RID: 12617
			// (get) Token: 0x06010057 RID: 65623 RVA: 0x00432D88 File Offset: 0x00430F88
			// (set) Token: 0x06010058 RID: 65624 RVA: 0x00432D98 File Offset: 0x00430F98
			public Text m_talent2DescText
			{
				get
				{
					return this.m_owner.m_talent2DescText;
				}
				set
				{
					this.m_owner.m_talent2DescText = value;
				}
			}

			// Token: 0x1700314A RID: 12618
			// (get) Token: 0x06010059 RID: 65625 RVA: 0x00432DA8 File Offset: 0x00430FA8
			// (set) Token: 0x0601005A RID: 65626 RVA: 0x00432DB8 File Offset: 0x00430FB8
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

			// Token: 0x1700314B RID: 12619
			// (get) Token: 0x0601005B RID: 65627 RVA: 0x00432DC8 File Offset: 0x00430FC8
			// (set) Token: 0x0601005C RID: 65628 RVA: 0x00432DD8 File Offset: 0x00430FD8
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

			// Token: 0x1700314C RID: 12620
			// (get) Token: 0x0601005D RID: 65629 RVA: 0x00432DE8 File Offset: 0x00430FE8
			// (set) Token: 0x0601005E RID: 65630 RVA: 0x00432DF8 File Offset: 0x00430FF8
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

			// Token: 0x1700314D RID: 12621
			// (get) Token: 0x0601005F RID: 65631 RVA: 0x00432E08 File Offset: 0x00431008
			// (set) Token: 0x06010060 RID: 65632 RVA: 0x00432E18 File Offset: 0x00431018
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

			// Token: 0x06010061 RID: 65633 RVA: 0x00432E28 File Offset: 0x00431028
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x06010062 RID: 65634 RVA: 0x00432E38 File Offset: 0x00431038
			public void SetBreakHeroInfo()
			{
				this.m_owner.SetBreakHeroInfo();
			}

			// Token: 0x06010063 RID: 65635 RVA: 0x00432E48 File Offset: 0x00431048
			public IEnumerator ShowStarEffect()
			{
				return this.m_owner.ShowStarEffect();
			}

			// Token: 0x06010064 RID: 65636 RVA: 0x00432E58 File Offset: 0x00431058
			public void OnReturnButtonClick()
			{
				this.m_owner.OnReturnButtonClick();
			}

			// Token: 0x040095C6 RID: 38342
			private HeroBreakEffectUIController m_owner;
		}
	}
}
