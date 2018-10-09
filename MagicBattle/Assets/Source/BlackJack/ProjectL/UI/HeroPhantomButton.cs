using System;
using System.Threading;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Misc;
using BlackJack.ProjectL.PlayerContext;
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000FE5 RID: 4069
	[HotFix]
	public class HeroPhantomButton : UIControllerBase
	{
		// Token: 0x0601467C RID: 83580 RVA: 0x0052FDD8 File Offset: 0x0052DFD8
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
			this.m_button.onClick.AddListener(new UnityAction(this.OnButtonClick));
		}

		// Token: 0x0601467D RID: 83581 RVA: 0x0052FE5C File Offset: 0x0052E05C
		public void SetHeroPhantomInfo(ConfigDataHeroPhantomInfo heroPhantomInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetHeroPhantomInfoConfigDataHeroPhantomInfo_hotfix != null)
			{
				this.m_SetHeroPhantomInfoConfigDataHeroPhantomInfo_hotfix.call(new object[]
				{
					this,
					heroPhantomInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_heroPhantomInfo = heroPhantomInfo;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			bool flag = projectLPlayerContext.IsHeroPhantomOpened(heroPhantomInfo.ID);
			this.m_uiStateController.SetToUIState((!flag) ? "Grey" : "Normal", false, true);
			this.m_image.sprite = AssetUtility.Instance.GetSprite(heroPhantomInfo.Image);
			DateTime dateTime = Convert.ToDateTime(heroPhantomInfo.OpenDateTime);
			DateTime dateTime2 = Convert.ToDateTime(heroPhantomInfo.CloseDateTime);
			this.m_timeText.text = string.Format(configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Uncharted_LimitTime), new object[]
			{
				dateTime.Month,
				dateTime.Day,
				dateTime.Hour,
				dateTime.Minute,
				dateTime2.Month,
				dateTime2.Day,
				dateTime2.Hour,
				dateTime2.Minute
			});
			int num = 0;
			foreach (ConfigDataHeroPhantomLevelInfo configDataHeroPhantomLevelInfo in heroPhantomInfo.m_levels)
			{
				if (configDataHeroPhantomLevelInfo.m_achievements != null)
				{
					num += configDataHeroPhantomLevelInfo.m_achievements.Length;
				}
			}
			int heroPhantomCompleteAchievementCount = projectLPlayerContext.GetHeroPhantomCompleteAchievementCount(heroPhantomInfo.ID);
			this.m_achievementCountText.text = heroPhantomCompleteAchievementCount + "/" + num;
		}

		// Token: 0x0601467E RID: 83582 RVA: 0x00530088 File Offset: 0x0052E288
		public ConfigDataHeroPhantomInfo GetHeroPhantomInfo()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetHeroPhantomInfo_hotfix != null)
			{
				return (ConfigDataHeroPhantomInfo)this.m_GetHeroPhantomInfo_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_heroPhantomInfo;
		}

		// Token: 0x0601467F RID: 83583 RVA: 0x005300FC File Offset: 0x0052E2FC
		private void OnButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnButtonClick_hotfix != null)
			{
				this.m_OnButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (UIUtility.GetUIStateCurrentStateName(this.m_uiStateController) == "Normal")
			{
				if (this.EventOnStartHeroPhantom != null)
				{
					this.EventOnStartHeroPhantom(this);
				}
			}
			else
			{
				CommonUIController.Instance.ShowMessage(StringTableId.StringTableId_Uncharted_NotOpenTime, 2f, null, true);
			}
		}

		// Token: 0x1400047E RID: 1150
		// (add) Token: 0x06014680 RID: 83584 RVA: 0x005301A8 File Offset: 0x0052E3A8
		// (remove) Token: 0x06014681 RID: 83585 RVA: 0x00530244 File Offset: 0x0052E444
		public event Action<HeroPhantomButton> EventOnStartHeroPhantom
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnStartHeroPhantomAction`1_hotfix != null)
				{
					this.m_add_EventOnStartHeroPhantomAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<HeroPhantomButton> action = this.EventOnStartHeroPhantom;
				Action<HeroPhantomButton> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<HeroPhantomButton>>(ref this.EventOnStartHeroPhantom, (Action<HeroPhantomButton>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnStartHeroPhantomAction`1_hotfix != null)
				{
					this.m_remove_EventOnStartHeroPhantomAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<HeroPhantomButton> action = this.EventOnStartHeroPhantom;
				Action<HeroPhantomButton> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<HeroPhantomButton>>(ref this.EventOnStartHeroPhantom, (Action<HeroPhantomButton>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17003C8B RID: 15499
		// (get) Token: 0x06014682 RID: 83586 RVA: 0x005302E0 File Offset: 0x0052E4E0
		// (set) Token: 0x06014683 RID: 83587 RVA: 0x00530300 File Offset: 0x0052E500
		[DoNotToLua]
		public new HeroPhantomButton.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new HeroPhantomButton.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06014684 RID: 83588 RVA: 0x0053030C File Offset: 0x0052E50C
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x06014685 RID: 83589 RVA: 0x00530318 File Offset: 0x0052E518
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x06014686 RID: 83590 RVA: 0x00530320 File Offset: 0x0052E520
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x06014687 RID: 83591 RVA: 0x00530328 File Offset: 0x0052E528
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x06014688 RID: 83592 RVA: 0x0053033C File Offset: 0x0052E53C
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x06014689 RID: 83593 RVA: 0x00530344 File Offset: 0x0052E544
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0601468A RID: 83594 RVA: 0x00530350 File Offset: 0x0052E550
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0601468B RID: 83595 RVA: 0x0053035C File Offset: 0x0052E55C
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0601468C RID: 83596 RVA: 0x00530368 File Offset: 0x0052E568
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0601468D RID: 83597 RVA: 0x00530374 File Offset: 0x0052E574
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0601468E RID: 83598 RVA: 0x00530380 File Offset: 0x0052E580
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0601468F RID: 83599 RVA: 0x0053038C File Offset: 0x0052E58C
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x06014690 RID: 83600 RVA: 0x00530398 File Offset: 0x0052E598
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x06014691 RID: 83601 RVA: 0x005303A4 File Offset: 0x0052E5A4
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x06014692 RID: 83602 RVA: 0x005303B0 File Offset: 0x0052E5B0
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x06014693 RID: 83603 RVA: 0x005303B8 File Offset: 0x0052E5B8
		private void __callDele_EventOnStartHeroPhantom(HeroPhantomButton obj)
		{
			Action<HeroPhantomButton> eventOnStartHeroPhantom = this.EventOnStartHeroPhantom;
			if (eventOnStartHeroPhantom != null)
			{
				eventOnStartHeroPhantom(obj);
			}
		}

		// Token: 0x06014694 RID: 83604 RVA: 0x005303DC File Offset: 0x0052E5DC
		private void __clearDele_EventOnStartHeroPhantom(HeroPhantomButton obj)
		{
			this.EventOnStartHeroPhantom = null;
		}

		// Token: 0x06014695 RID: 83605 RVA: 0x005303E8 File Offset: 0x0052E5E8
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
					this.m_SetHeroPhantomInfoConfigDataHeroPhantomInfo_hotfix = (luaObj.RawGet("SetHeroPhantomInfo") as LuaFunction);
					this.m_GetHeroPhantomInfo_hotfix = (luaObj.RawGet("GetHeroPhantomInfo") as LuaFunction);
					this.m_OnButtonClick_hotfix = (luaObj.RawGet("OnButtonClick") as LuaFunction);
					this.m_add_EventOnStartHeroPhantomAction`1_hotfix = (luaObj.RawGet("add_EventOnStartHeroPhantom") as LuaFunction);
					this.m_remove_EventOnStartHeroPhantomAction`1_hotfix = (luaObj.RawGet("remove_EventOnStartHeroPhantom") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06014696 RID: 83606 RVA: 0x00530530 File Offset: 0x0052E730
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(HeroPhantomButton));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400B3DD RID: 46045
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_button;

		// Token: 0x0400B3DE RID: 46046
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_uiStateController;

		// Token: 0x0400B3DF RID: 46047
		[AutoBind("./BGImage", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_image;

		// Token: 0x0400B3E0 RID: 46048
		[AutoBind("./InfoTextGroup/TimeText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_timeText;

		// Token: 0x0400B3E1 RID: 46049
		[AutoBind("./InfoTextGroup/NumberText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_achievementCountText;

		// Token: 0x0400B3E3 RID: 46051
		private ConfigDataHeroPhantomInfo m_heroPhantomInfo;

		// Token: 0x0400B3E4 RID: 46052
		[DoNotToLua]
		private HeroPhantomButton.LuaExportHelper luaExportHelper;

		// Token: 0x0400B3E5 RID: 46053
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400B3E6 RID: 46054
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400B3E7 RID: 46055
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x0400B3E8 RID: 46056
		private LuaFunction m_SetHeroPhantomInfoConfigDataHeroPhantomInfo_hotfix;

		// Token: 0x0400B3E9 RID: 46057
		private LuaFunction m_GetHeroPhantomInfo_hotfix;

		// Token: 0x0400B3EA RID: 46058
		private LuaFunction m_OnButtonClick_hotfix;

		// Token: 0x0400B3EB RID: 46059
		private LuaFunction m_add_EventOnStartHeroPhantomAction;

		// Token: 0x0400B3EC RID: 46060
		private LuaFunction m_remove_EventOnStartHeroPhantomAction;

		// Token: 0x02000FE6 RID: 4070
		public new class LuaExportHelper
		{
			// Token: 0x06014697 RID: 83607 RVA: 0x00530598 File Offset: 0x0052E798
			public LuaExportHelper(HeroPhantomButton owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06014698 RID: 83608 RVA: 0x005305A8 File Offset: 0x0052E7A8
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x06014699 RID: 83609 RVA: 0x005305B8 File Offset: 0x0052E7B8
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0601469A RID: 83610 RVA: 0x005305C8 File Offset: 0x0052E7C8
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0601469B RID: 83611 RVA: 0x005305D8 File Offset: 0x0052E7D8
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0601469C RID: 83612 RVA: 0x005305F0 File Offset: 0x0052E7F0
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0601469D RID: 83613 RVA: 0x00530600 File Offset: 0x0052E800
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0601469E RID: 83614 RVA: 0x00530610 File Offset: 0x0052E810
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0601469F RID: 83615 RVA: 0x00530620 File Offset: 0x0052E820
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x060146A0 RID: 83616 RVA: 0x00530630 File Offset: 0x0052E830
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x060146A1 RID: 83617 RVA: 0x00530640 File Offset: 0x0052E840
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x060146A2 RID: 83618 RVA: 0x00530650 File Offset: 0x0052E850
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x060146A3 RID: 83619 RVA: 0x00530660 File Offset: 0x0052E860
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x060146A4 RID: 83620 RVA: 0x00530670 File Offset: 0x0052E870
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x060146A5 RID: 83621 RVA: 0x00530680 File Offset: 0x0052E880
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x060146A6 RID: 83622 RVA: 0x00530690 File Offset: 0x0052E890
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x060146A7 RID: 83623 RVA: 0x005306A0 File Offset: 0x0052E8A0
			public void __callDele_EventOnStartHeroPhantom(HeroPhantomButton obj)
			{
				this.m_owner.__callDele_EventOnStartHeroPhantom(obj);
			}

			// Token: 0x060146A8 RID: 83624 RVA: 0x005306B0 File Offset: 0x0052E8B0
			public void __clearDele_EventOnStartHeroPhantom(HeroPhantomButton obj)
			{
				this.m_owner.__clearDele_EventOnStartHeroPhantom(obj);
			}

			// Token: 0x17003C8C RID: 15500
			// (get) Token: 0x060146A9 RID: 83625 RVA: 0x005306C0 File Offset: 0x0052E8C0
			// (set) Token: 0x060146AA RID: 83626 RVA: 0x005306D0 File Offset: 0x0052E8D0
			public Button m_button
			{
				get
				{
					return this.m_owner.m_button;
				}
				set
				{
					this.m_owner.m_button = value;
				}
			}

			// Token: 0x17003C8D RID: 15501
			// (get) Token: 0x060146AB RID: 83627 RVA: 0x005306E0 File Offset: 0x0052E8E0
			// (set) Token: 0x060146AC RID: 83628 RVA: 0x005306F0 File Offset: 0x0052E8F0
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

			// Token: 0x17003C8E RID: 15502
			// (get) Token: 0x060146AD RID: 83629 RVA: 0x00530700 File Offset: 0x0052E900
			// (set) Token: 0x060146AE RID: 83630 RVA: 0x00530710 File Offset: 0x0052E910
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

			// Token: 0x17003C8F RID: 15503
			// (get) Token: 0x060146AF RID: 83631 RVA: 0x00530720 File Offset: 0x0052E920
			// (set) Token: 0x060146B0 RID: 83632 RVA: 0x00530730 File Offset: 0x0052E930
			public Text m_timeText
			{
				get
				{
					return this.m_owner.m_timeText;
				}
				set
				{
					this.m_owner.m_timeText = value;
				}
			}

			// Token: 0x17003C90 RID: 15504
			// (get) Token: 0x060146B1 RID: 83633 RVA: 0x00530740 File Offset: 0x0052E940
			// (set) Token: 0x060146B2 RID: 83634 RVA: 0x00530750 File Offset: 0x0052E950
			public Text m_achievementCountText
			{
				get
				{
					return this.m_owner.m_achievementCountText;
				}
				set
				{
					this.m_owner.m_achievementCountText = value;
				}
			}

			// Token: 0x17003C91 RID: 15505
			// (get) Token: 0x060146B3 RID: 83635 RVA: 0x00530760 File Offset: 0x0052E960
			// (set) Token: 0x060146B4 RID: 83636 RVA: 0x00530770 File Offset: 0x0052E970
			public ConfigDataHeroPhantomInfo m_heroPhantomInfo
			{
				get
				{
					return this.m_owner.m_heroPhantomInfo;
				}
				set
				{
					this.m_owner.m_heroPhantomInfo = value;
				}
			}

			// Token: 0x060146B5 RID: 83637 RVA: 0x00530780 File Offset: 0x0052E980
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x060146B6 RID: 83638 RVA: 0x00530790 File Offset: 0x0052E990
			public void OnButtonClick()
			{
				this.m_owner.OnButtonClick();
			}

			// Token: 0x0400B3ED RID: 46061
			private HeroPhantomButton m_owner;
		}
	}
}
