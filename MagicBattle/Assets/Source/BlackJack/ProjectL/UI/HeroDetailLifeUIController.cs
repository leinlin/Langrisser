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
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000DA9 RID: 3497
	[HotFix]
	public class HeroDetailLifeUIController : UIControllerBase
	{
		// Token: 0x060108AB RID: 67755 RVA: 0x0044D294 File Offset: 0x0044B494
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
			this.m_toggleLife.onValueChanged.AddListener(new UnityAction<bool>(this.OnToggleLifeValueChange));
			this.m_toggleVoice.onValueChanged.AddListener(new UnityAction<bool>(this.OnToggleVoiceValueChange));
			base.gameObject.SetActive(true);
			this.m_configDataLoader = (GameManager.Instance.ConfigDataLoader as IConfigDataLoader);
			UIUtility.MarginAdjustHorizontal(this.m_marginTransform);
		}

		// Token: 0x060108AC RID: 67756 RVA: 0x0044D360 File Offset: 0x0044B560
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

		// Token: 0x060108AD RID: 67757 RVA: 0x0044D3C0 File Offset: 0x0044B5C0
		public void UpdateViewInLife(Hero hero)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateViewInLifeHero_hotfix != null)
			{
				this.m_UpdateViewInLifeHero_hotfix.call(new object[]
				{
					this,
					hero
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_hero = hero;
			this.m_heroInformationInfo = this.m_hero.HeroInfo.m_informationInfo;
			this.m_toggleLife.isOn = true;
			this.isInVoiceTab = false;
			this.UpdateToggleNewTag();
			this.UpdateHeroLifeList();
		}

		// Token: 0x060108AE RID: 67758 RVA: 0x0044D46C File Offset: 0x0044B66C
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

		// Token: 0x060108AF RID: 67759 RVA: 0x0044D5A4 File Offset: 0x0044B7A4
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

		// Token: 0x060108B0 RID: 67760 RVA: 0x0044D730 File Offset: 0x0044B930
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

		// Token: 0x060108B1 RID: 67761 RVA: 0x0044D7BC File Offset: 0x0044B9BC
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

		// Token: 0x060108B2 RID: 67762 RVA: 0x0044D8C8 File Offset: 0x0044BAC8
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
			if (!this.isInVoiceTab)
			{
				return;
			}
			this.isInVoiceTab = false;
			if (isOn)
			{
				this.UpdateToggleNewTag();
				this.UpdateHeroLifeList();
				this.ResetScrollViewPosition();
			}
		}

		// Token: 0x060108B3 RID: 67763 RVA: 0x0044D964 File Offset: 0x0044BB64
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
			if (this.isInVoiceTab)
			{
				return;
			}
			this.isInVoiceTab = true;
			if (isOn)
			{
				this.UpdateToggleNewTag();
				this.UpdateHeroVoiceList();
				this.ResetScrollViewPosition();
			}
		}

		// Token: 0x060108B4 RID: 67764 RVA: 0x0044DA00 File Offset: 0x0044BC00
		public void SetCommonUIState(string stateName)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetCommonUIStateString_hotfix != null)
			{
				this.m_SetCommonUIStateString_hotfix.call(new object[]
				{
					this,
					stateName
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIStateController component = base.gameObject.GetComponent<CommonUIStateController>();
			UIUtility.SetUIStateOpen(component, stateName, null, true, true);
		}

		// Token: 0x060108B5 RID: 67765 RVA: 0x0044DA88 File Offset: 0x0044BC88
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

		// Token: 0x14000380 RID: 896
		// (add) Token: 0x060108B6 RID: 67766 RVA: 0x0044DB08 File Offset: 0x0044BD08
		// (remove) Token: 0x060108B7 RID: 67767 RVA: 0x0044DBA4 File Offset: 0x0044BDA4
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

		// Token: 0x1700332A RID: 13098
		// (get) Token: 0x060108B8 RID: 67768 RVA: 0x0044DC40 File Offset: 0x0044BE40
		// (set) Token: 0x060108B9 RID: 67769 RVA: 0x0044DC60 File Offset: 0x0044BE60
		[DoNotToLua]
		public new HeroDetailLifeUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new HeroDetailLifeUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x060108BA RID: 67770 RVA: 0x0044DC6C File Offset: 0x0044BE6C
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x060108BB RID: 67771 RVA: 0x0044DC78 File Offset: 0x0044BE78
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x060108BC RID: 67772 RVA: 0x0044DC80 File Offset: 0x0044BE80
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x060108BD RID: 67773 RVA: 0x0044DC88 File Offset: 0x0044BE88
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x060108BE RID: 67774 RVA: 0x0044DC9C File Offset: 0x0044BE9C
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x060108BF RID: 67775 RVA: 0x0044DCA4 File Offset: 0x0044BEA4
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x060108C0 RID: 67776 RVA: 0x0044DCB0 File Offset: 0x0044BEB0
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x060108C1 RID: 67777 RVA: 0x0044DCBC File Offset: 0x0044BEBC
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x060108C2 RID: 67778 RVA: 0x0044DCC8 File Offset: 0x0044BEC8
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x060108C3 RID: 67779 RVA: 0x0044DCD4 File Offset: 0x0044BED4
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x060108C4 RID: 67780 RVA: 0x0044DCE0 File Offset: 0x0044BEE0
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x060108C5 RID: 67781 RVA: 0x0044DCEC File Offset: 0x0044BEEC
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x060108C6 RID: 67782 RVA: 0x0044DCF8 File Offset: 0x0044BEF8
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x060108C7 RID: 67783 RVA: 0x0044DD04 File Offset: 0x0044BF04
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x060108C8 RID: 67784 RVA: 0x0044DD10 File Offset: 0x0044BF10
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x060108C9 RID: 67785 RVA: 0x0044DD18 File Offset: 0x0044BF18
		private void __callDele_EventOnVoiceItemClick(int obj)
		{
			Action<int> eventOnVoiceItemClick = this.EventOnVoiceItemClick;
			if (eventOnVoiceItemClick != null)
			{
				eventOnVoiceItemClick(obj);
			}
		}

		// Token: 0x060108CA RID: 67786 RVA: 0x0044DD3C File Offset: 0x0044BF3C
		private void __clearDele_EventOnVoiceItemClick(int obj)
		{
			this.EventOnVoiceItemClick = null;
		}

		// Token: 0x060108CB RID: 67787 RVA: 0x0044DD48 File Offset: 0x0044BF48
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
					this.m_UpdateViewInLifeHero_hotfix = (luaObj.RawGet("UpdateViewInLife") as LuaFunction);
					this.m_UpdateHeroLifeList_hotfix = (luaObj.RawGet("UpdateHeroLifeList") as LuaFunction);
					this.m_UpdateHeroVoiceList_hotfix = (luaObj.RawGet("UpdateHeroVoiceList") as LuaFunction);
					this.m_UpdateToggleNewTag_hotfix = (luaObj.RawGet("UpdateToggleNewTag") as LuaFunction);
					this.m_OnPeofermanceVoiceButtonClickFettersInformationVoiceItemUIController_hotfix = (luaObj.RawGet("OnPeofermanceVoiceButtonClick") as LuaFunction);
					this.m_OnToggleLifeValueChangeBoolean_hotfix = (luaObj.RawGet("OnToggleLifeValueChange") as LuaFunction);
					this.m_OnToggleVoiceValueChangeBoolean_hotfix = (luaObj.RawGet("OnToggleVoiceValueChange") as LuaFunction);
					this.m_SetCommonUIStateString_hotfix = (luaObj.RawGet("SetCommonUIState") as LuaFunction);
					this.m_ResetScrollViewPosition_hotfix = (luaObj.RawGet("ResetScrollViewPosition") as LuaFunction);
					this.m_add_EventOnVoiceItemClickAction`1_hotfix = (luaObj.RawGet("add_EventOnVoiceItemClick") as LuaFunction);
					this.m_remove_EventOnVoiceItemClickAction`1_hotfix = (luaObj.RawGet("remove_EventOnVoiceItemClick") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x060108CC RID: 67788 RVA: 0x0044DF40 File Offset: 0x0044C140
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(HeroDetailLifeUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04009943 RID: 39235
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private RectTransform m_marginTransform;

		// Token: 0x04009944 RID: 39236
		[AutoBind("./ToggleGroup/ToggleLife", AutoBindAttribute.InitState.NotInit, false)]
		private ToggleEx m_toggleLife;

		// Token: 0x04009945 RID: 39237
		[AutoBind("./ToggleGroup/ToggleVoice", AutoBindAttribute.InitState.NotInit, false)]
		private ToggleEx m_toggleVoice;

		// Token: 0x04009946 RID: 39238
		[AutoBind("./ToggleGroup/ToggleLife/RedPoint", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_toggleLifeRedPoint;

		// Token: 0x04009947 RID: 39239
		[AutoBind("./ToggleGroup/ToggleVoice/RedPoint", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_toggleVoiceRedPoint;

		// Token: 0x04009948 RID: 39240
		[AutoBind("./LifeIntroductionScrollView", AutoBindAttribute.InitState.NotInit, false)]
		private ScrollRect m_lifeScrollRect;

		// Token: 0x04009949 RID: 39241
		[AutoBind("./VoiceScrollView", AutoBindAttribute.InitState.NotInit, false)]
		private ScrollRect m_voiceScrollRect;

		// Token: 0x0400994A RID: 39242
		[AutoBind("./LifeIntroductionScrollView/Viewport/Content", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_lifeContent;

		// Token: 0x0400994B RID: 39243
		[AutoBind("./VoiceScrollView/Viewport/Content", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_voiceContent;

		// Token: 0x0400994C RID: 39244
		[AutoBind("./VoiceScrollView/CV/NameText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_voiceCVNameText;

		// Token: 0x0400994E RID: 39246
		private Hero m_hero;

		// Token: 0x0400994F RID: 39247
		private ConfigDataHeroInformationInfo m_heroInformationInfo;

		// Token: 0x04009950 RID: 39248
		private List<FettersInformationLifeItemUIController> biographyCtrlList = new List<FettersInformationLifeItemUIController>();

		// Token: 0x04009951 RID: 39249
		private List<FettersInformationVoiceItemUIController> voiceCtrlList = new List<FettersInformationVoiceItemUIController>();

		// Token: 0x04009952 RID: 39250
		private bool isInVoiceTab;

		// Token: 0x04009953 RID: 39251
		private IConfigDataLoader m_configDataLoader;

		// Token: 0x04009954 RID: 39252
		[DoNotToLua]
		private HeroDetailLifeUIController.LuaExportHelper luaExportHelper;

		// Token: 0x04009955 RID: 39253
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04009956 RID: 39254
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04009957 RID: 39255
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x04009958 RID: 39256
		private LuaFunction m_OnDisable_hotfix;

		// Token: 0x04009959 RID: 39257
		private LuaFunction m_UpdateViewInLifeHero_hotfix;

		// Token: 0x0400995A RID: 39258
		private LuaFunction m_UpdateHeroLifeList_hotfix;

		// Token: 0x0400995B RID: 39259
		private LuaFunction m_UpdateHeroVoiceList_hotfix;

		// Token: 0x0400995C RID: 39260
		private LuaFunction m_UpdateToggleNewTag_hotfix;

		// Token: 0x0400995D RID: 39261
		private LuaFunction m_OnPeofermanceVoiceButtonClickFettersInformationVoiceItemUIController_hotfix;

		// Token: 0x0400995E RID: 39262
		private LuaFunction m_OnToggleLifeValueChangeBoolean_hotfix;

		// Token: 0x0400995F RID: 39263
		private LuaFunction m_OnToggleVoiceValueChangeBoolean_hotfix;

		// Token: 0x04009960 RID: 39264
		private LuaFunction m_SetCommonUIStateString_hotfix;

		// Token: 0x04009961 RID: 39265
		private LuaFunction m_ResetScrollViewPosition_hotfix;

		// Token: 0x04009962 RID: 39266
		private LuaFunction m_add_EventOnVoiceItemClickAction;

		// Token: 0x04009963 RID: 39267
		private LuaFunction m_remove_EventOnVoiceItemClickAction;

		// Token: 0x02000DAA RID: 3498
		public new class LuaExportHelper
		{
			// Token: 0x060108CD RID: 67789 RVA: 0x0044DFA8 File Offset: 0x0044C1A8
			public LuaExportHelper(HeroDetailLifeUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x060108CE RID: 67790 RVA: 0x0044DFB8 File Offset: 0x0044C1B8
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x060108CF RID: 67791 RVA: 0x0044DFC8 File Offset: 0x0044C1C8
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x060108D0 RID: 67792 RVA: 0x0044DFD8 File Offset: 0x0044C1D8
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x060108D1 RID: 67793 RVA: 0x0044DFE8 File Offset: 0x0044C1E8
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x060108D2 RID: 67794 RVA: 0x0044E000 File Offset: 0x0044C200
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x060108D3 RID: 67795 RVA: 0x0044E010 File Offset: 0x0044C210
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x060108D4 RID: 67796 RVA: 0x0044E020 File Offset: 0x0044C220
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x060108D5 RID: 67797 RVA: 0x0044E030 File Offset: 0x0044C230
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x060108D6 RID: 67798 RVA: 0x0044E040 File Offset: 0x0044C240
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x060108D7 RID: 67799 RVA: 0x0044E050 File Offset: 0x0044C250
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x060108D8 RID: 67800 RVA: 0x0044E060 File Offset: 0x0044C260
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x060108D9 RID: 67801 RVA: 0x0044E070 File Offset: 0x0044C270
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x060108DA RID: 67802 RVA: 0x0044E080 File Offset: 0x0044C280
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x060108DB RID: 67803 RVA: 0x0044E090 File Offset: 0x0044C290
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x060108DC RID: 67804 RVA: 0x0044E0A0 File Offset: 0x0044C2A0
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x060108DD RID: 67805 RVA: 0x0044E0B0 File Offset: 0x0044C2B0
			public void __callDele_EventOnVoiceItemClick(int obj)
			{
				this.m_owner.__callDele_EventOnVoiceItemClick(obj);
			}

			// Token: 0x060108DE RID: 67806 RVA: 0x0044E0C0 File Offset: 0x0044C2C0
			public void __clearDele_EventOnVoiceItemClick(int obj)
			{
				this.m_owner.__clearDele_EventOnVoiceItemClick(obj);
			}

			// Token: 0x1700332B RID: 13099
			// (get) Token: 0x060108DF RID: 67807 RVA: 0x0044E0D0 File Offset: 0x0044C2D0
			// (set) Token: 0x060108E0 RID: 67808 RVA: 0x0044E0E0 File Offset: 0x0044C2E0
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

			// Token: 0x1700332C RID: 13100
			// (get) Token: 0x060108E1 RID: 67809 RVA: 0x0044E0F0 File Offset: 0x0044C2F0
			// (set) Token: 0x060108E2 RID: 67810 RVA: 0x0044E100 File Offset: 0x0044C300
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

			// Token: 0x1700332D RID: 13101
			// (get) Token: 0x060108E3 RID: 67811 RVA: 0x0044E110 File Offset: 0x0044C310
			// (set) Token: 0x060108E4 RID: 67812 RVA: 0x0044E120 File Offset: 0x0044C320
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

			// Token: 0x1700332E RID: 13102
			// (get) Token: 0x060108E5 RID: 67813 RVA: 0x0044E130 File Offset: 0x0044C330
			// (set) Token: 0x060108E6 RID: 67814 RVA: 0x0044E140 File Offset: 0x0044C340
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

			// Token: 0x1700332F RID: 13103
			// (get) Token: 0x060108E7 RID: 67815 RVA: 0x0044E150 File Offset: 0x0044C350
			// (set) Token: 0x060108E8 RID: 67816 RVA: 0x0044E160 File Offset: 0x0044C360
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

			// Token: 0x17003330 RID: 13104
			// (get) Token: 0x060108E9 RID: 67817 RVA: 0x0044E170 File Offset: 0x0044C370
			// (set) Token: 0x060108EA RID: 67818 RVA: 0x0044E180 File Offset: 0x0044C380
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

			// Token: 0x17003331 RID: 13105
			// (get) Token: 0x060108EB RID: 67819 RVA: 0x0044E190 File Offset: 0x0044C390
			// (set) Token: 0x060108EC RID: 67820 RVA: 0x0044E1A0 File Offset: 0x0044C3A0
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

			// Token: 0x17003332 RID: 13106
			// (get) Token: 0x060108ED RID: 67821 RVA: 0x0044E1B0 File Offset: 0x0044C3B0
			// (set) Token: 0x060108EE RID: 67822 RVA: 0x0044E1C0 File Offset: 0x0044C3C0
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

			// Token: 0x17003333 RID: 13107
			// (get) Token: 0x060108EF RID: 67823 RVA: 0x0044E1D0 File Offset: 0x0044C3D0
			// (set) Token: 0x060108F0 RID: 67824 RVA: 0x0044E1E0 File Offset: 0x0044C3E0
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

			// Token: 0x17003334 RID: 13108
			// (get) Token: 0x060108F1 RID: 67825 RVA: 0x0044E1F0 File Offset: 0x0044C3F0
			// (set) Token: 0x060108F2 RID: 67826 RVA: 0x0044E200 File Offset: 0x0044C400
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

			// Token: 0x17003335 RID: 13109
			// (get) Token: 0x060108F3 RID: 67827 RVA: 0x0044E210 File Offset: 0x0044C410
			// (set) Token: 0x060108F4 RID: 67828 RVA: 0x0044E220 File Offset: 0x0044C420
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

			// Token: 0x17003336 RID: 13110
			// (get) Token: 0x060108F5 RID: 67829 RVA: 0x0044E230 File Offset: 0x0044C430
			// (set) Token: 0x060108F6 RID: 67830 RVA: 0x0044E240 File Offset: 0x0044C440
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

			// Token: 0x17003337 RID: 13111
			// (get) Token: 0x060108F7 RID: 67831 RVA: 0x0044E250 File Offset: 0x0044C450
			// (set) Token: 0x060108F8 RID: 67832 RVA: 0x0044E260 File Offset: 0x0044C460
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

			// Token: 0x17003338 RID: 13112
			// (get) Token: 0x060108F9 RID: 67833 RVA: 0x0044E270 File Offset: 0x0044C470
			// (set) Token: 0x060108FA RID: 67834 RVA: 0x0044E280 File Offset: 0x0044C480
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

			// Token: 0x17003339 RID: 13113
			// (get) Token: 0x060108FB RID: 67835 RVA: 0x0044E290 File Offset: 0x0044C490
			// (set) Token: 0x060108FC RID: 67836 RVA: 0x0044E2A0 File Offset: 0x0044C4A0
			public bool isInVoiceTab
			{
				get
				{
					return this.m_owner.isInVoiceTab;
				}
				set
				{
					this.m_owner.isInVoiceTab = value;
				}
			}

			// Token: 0x1700333A RID: 13114
			// (get) Token: 0x060108FD RID: 67837 RVA: 0x0044E2B0 File Offset: 0x0044C4B0
			// (set) Token: 0x060108FE RID: 67838 RVA: 0x0044E2C0 File Offset: 0x0044C4C0
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

			// Token: 0x060108FF RID: 67839 RVA: 0x0044E2D0 File Offset: 0x0044C4D0
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x06010900 RID: 67840 RVA: 0x0044E2E0 File Offset: 0x0044C4E0
			public void OnDisable()
			{
				this.m_owner.OnDisable();
			}

			// Token: 0x06010901 RID: 67841 RVA: 0x0044E2F0 File Offset: 0x0044C4F0
			public void UpdateHeroLifeList()
			{
				this.m_owner.UpdateHeroLifeList();
			}

			// Token: 0x06010902 RID: 67842 RVA: 0x0044E300 File Offset: 0x0044C500
			public void UpdateHeroVoiceList()
			{
				this.m_owner.UpdateHeroVoiceList();
			}

			// Token: 0x06010903 RID: 67843 RVA: 0x0044E310 File Offset: 0x0044C510
			public void UpdateToggleNewTag()
			{
				this.m_owner.UpdateToggleNewTag();
			}

			// Token: 0x06010904 RID: 67844 RVA: 0x0044E320 File Offset: 0x0044C520
			public void OnPeofermanceVoiceButtonClick(FettersInformationVoiceItemUIController ctrl)
			{
				this.m_owner.OnPeofermanceVoiceButtonClick(ctrl);
			}

			// Token: 0x06010905 RID: 67845 RVA: 0x0044E330 File Offset: 0x0044C530
			public void OnToggleLifeValueChange(bool isOn)
			{
				this.m_owner.OnToggleLifeValueChange(isOn);
			}

			// Token: 0x06010906 RID: 67846 RVA: 0x0044E340 File Offset: 0x0044C540
			public void OnToggleVoiceValueChange(bool isOn)
			{
				this.m_owner.OnToggleVoiceValueChange(isOn);
			}

			// Token: 0x06010907 RID: 67847 RVA: 0x0044E350 File Offset: 0x0044C550
			public void ResetScrollViewPosition()
			{
				this.m_owner.ResetScrollViewPosition();
			}

			// Token: 0x04009964 RID: 39268
			private HeroDetailLifeUIController m_owner;
		}
	}
}
