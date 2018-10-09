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
	// Token: 0x02000FC5 RID: 4037
	[HotFix]
	public class ThearchyLevelListItemUIController : UIControllerBase
	{
		// Token: 0x060142BB RID: 82619 RVA: 0x00522B84 File Offset: 0x00520D84
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
			this.m_lockedButton.onClick.AddListener(new UnityAction(this.OnLockedButtonClick));
		}

		// Token: 0x060142BC RID: 82620 RVA: 0x00522C24 File Offset: 0x00520E24
		public void SetThearchyLevelInfo(ConfigDataThearchyTrialLevelInfo levelInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetThearchyLevelInfoConfigDataThearchyTrialLevelInfo_hotfix != null)
			{
				this.m_SetThearchyLevelInfoConfigDataThearchyTrialLevelInfo_hotfix.call(new object[]
				{
					this,
					levelInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_thearchyLevelInfo = levelInfo;
			this.m_levelText.text = levelInfo.MonsterLevel.ToString();
			this.m_energyText.text = levelInfo.EnergySuccess.ToString();
			GameObjectUtility.DestroyChildren(this.m_rewardGroupGameObject);
			GameObject assetInContainer = base.GetAssetInContainer<GameObject>("RewardGoods");
			List<Goods> list = new List<Goods>();
			UIUtility.AppendRandomDropRewardGoodsToList(levelInfo.Drop_ID, list);
			if (list.Count > levelInfo.DisplayRewardCount)
			{
				list.RemoveRange(levelInfo.DisplayRewardCount, list.Count - levelInfo.DisplayRewardCount);
			}
			RewardGoodsUIController.CreateRewardGoodsList(list, this.m_rewardGroupGameObject.transform, assetInContainer, null, false, 0, false);
		}

		// Token: 0x060142BD RID: 82621 RVA: 0x00522D44 File Offset: 0x00520F44
		public ConfigDataThearchyTrialLevelInfo GetThearchyLevelInfo()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetThearchyLevelInfo_hotfix != null)
			{
				return (ConfigDataThearchyTrialLevelInfo)this.m_GetThearchyLevelInfo_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_thearchyLevelInfo;
		}

		// Token: 0x060142BE RID: 82622 RVA: 0x00522DB8 File Offset: 0x00520FB8
		public void SetLocked(bool locked)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetLockedBoolean_hotfix != null)
			{
				this.m_SetLockedBoolean_hotfix.call(new object[]
				{
					this,
					locked
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_lockedButton.gameObject.SetActive(locked);
		}

		// Token: 0x060142BF RID: 82623 RVA: 0x00522E3C File Offset: 0x0052103C
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
			if (this.EventOnStartButtonClick != null)
			{
				this.EventOnStartButtonClick(this);
			}
		}

		// Token: 0x060142C0 RID: 82624 RVA: 0x00522EB4 File Offset: 0x005210B4
		private void OnLockedButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnLockedButtonClick_hotfix != null)
			{
				this.m_OnLockedButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIController.Instance.ShowMessage(StringTableId.StringTableId_Msg_PreLevelCompleteOpen, 2f, null, true);
		}

		// Token: 0x14000475 RID: 1141
		// (add) Token: 0x060142C1 RID: 82625 RVA: 0x00522F2C File Offset: 0x0052112C
		// (remove) Token: 0x060142C2 RID: 82626 RVA: 0x00522FC8 File Offset: 0x005211C8
		public event Action<ThearchyLevelListItemUIController> EventOnStartButtonClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnStartButtonClickAction`1_hotfix != null)
				{
					this.m_add_EventOnStartButtonClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<ThearchyLevelListItemUIController> action = this.EventOnStartButtonClick;
				Action<ThearchyLevelListItemUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<ThearchyLevelListItemUIController>>(ref this.EventOnStartButtonClick, (Action<ThearchyLevelListItemUIController>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnStartButtonClickAction`1_hotfix != null)
				{
					this.m_remove_EventOnStartButtonClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<ThearchyLevelListItemUIController> action = this.EventOnStartButtonClick;
				Action<ThearchyLevelListItemUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<ThearchyLevelListItemUIController>>(ref this.EventOnStartButtonClick, (Action<ThearchyLevelListItemUIController>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17003C20 RID: 15392
		// (get) Token: 0x060142C3 RID: 82627 RVA: 0x00523064 File Offset: 0x00521264
		// (set) Token: 0x060142C4 RID: 82628 RVA: 0x00523084 File Offset: 0x00521284
		[DoNotToLua]
		public new ThearchyLevelListItemUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new ThearchyLevelListItemUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x060142C5 RID: 82629 RVA: 0x00523090 File Offset: 0x00521290
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x060142C6 RID: 82630 RVA: 0x0052309C File Offset: 0x0052129C
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x060142C7 RID: 82631 RVA: 0x005230A4 File Offset: 0x005212A4
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x060142C8 RID: 82632 RVA: 0x005230AC File Offset: 0x005212AC
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x060142C9 RID: 82633 RVA: 0x005230C0 File Offset: 0x005212C0
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x060142CA RID: 82634 RVA: 0x005230C8 File Offset: 0x005212C8
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x060142CB RID: 82635 RVA: 0x005230D4 File Offset: 0x005212D4
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x060142CC RID: 82636 RVA: 0x005230E0 File Offset: 0x005212E0
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x060142CD RID: 82637 RVA: 0x005230EC File Offset: 0x005212EC
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x060142CE RID: 82638 RVA: 0x005230F8 File Offset: 0x005212F8
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x060142CF RID: 82639 RVA: 0x00523104 File Offset: 0x00521304
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x060142D0 RID: 82640 RVA: 0x00523110 File Offset: 0x00521310
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x060142D1 RID: 82641 RVA: 0x0052311C File Offset: 0x0052131C
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x060142D2 RID: 82642 RVA: 0x00523128 File Offset: 0x00521328
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x060142D3 RID: 82643 RVA: 0x00523134 File Offset: 0x00521334
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x060142D4 RID: 82644 RVA: 0x0052313C File Offset: 0x0052133C
		private void __callDele_EventOnStartButtonClick(ThearchyLevelListItemUIController obj)
		{
			Action<ThearchyLevelListItemUIController> eventOnStartButtonClick = this.EventOnStartButtonClick;
			if (eventOnStartButtonClick != null)
			{
				eventOnStartButtonClick(obj);
			}
		}

		// Token: 0x060142D5 RID: 82645 RVA: 0x00523160 File Offset: 0x00521360
		private void __clearDele_EventOnStartButtonClick(ThearchyLevelListItemUIController obj)
		{
			this.EventOnStartButtonClick = null;
		}

		// Token: 0x060142D6 RID: 82646 RVA: 0x0052316C File Offset: 0x0052136C
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
					this.m_SetThearchyLevelInfoConfigDataThearchyTrialLevelInfo_hotfix = (luaObj.RawGet("SetThearchyLevelInfo") as LuaFunction);
					this.m_GetThearchyLevelInfo_hotfix = (luaObj.RawGet("GetThearchyLevelInfo") as LuaFunction);
					this.m_SetLockedBoolean_hotfix = (luaObj.RawGet("SetLocked") as LuaFunction);
					this.m_OnStartButtonClick_hotfix = (luaObj.RawGet("OnStartButtonClick") as LuaFunction);
					this.m_OnLockedButtonClick_hotfix = (luaObj.RawGet("OnLockedButtonClick") as LuaFunction);
					this.m_add_EventOnStartButtonClickAction`1_hotfix = (luaObj.RawGet("add_EventOnStartButtonClick") as LuaFunction);
					this.m_remove_EventOnStartButtonClickAction`1_hotfix = (luaObj.RawGet("remove_EventOnStartButtonClick") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x060142D7 RID: 82647 RVA: 0x005232E8 File Offset: 0x005214E8
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ThearchyLevelListItemUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400B23E RID: 45630
		[AutoBind("./Level/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_levelText;

		// Token: 0x0400B23F RID: 45631
		[AutoBind("./EnergyValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_energyText;

		// Token: 0x0400B240 RID: 45632
		[AutoBind("./Locked", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_lockedButton;

		// Token: 0x0400B241 RID: 45633
		[AutoBind("./StartButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_startButton;

		// Token: 0x0400B242 RID: 45634
		[AutoBind("./RewardGroup", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_rewardGroupGameObject;

		// Token: 0x0400B243 RID: 45635
		private ConfigDataThearchyTrialLevelInfo m_thearchyLevelInfo;

		// Token: 0x0400B244 RID: 45636
		[DoNotToLua]
		private ThearchyLevelListItemUIController.LuaExportHelper luaExportHelper;

		// Token: 0x0400B245 RID: 45637
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400B246 RID: 45638
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400B247 RID: 45639
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x0400B248 RID: 45640
		private LuaFunction m_SetThearchyLevelInfoConfigDataThearchyTrialLevelInfo_hotfix;

		// Token: 0x0400B249 RID: 45641
		private LuaFunction m_GetThearchyLevelInfo_hotfix;

		// Token: 0x0400B24A RID: 45642
		private LuaFunction m_SetLockedBoolean_hotfix;

		// Token: 0x0400B24B RID: 45643
		private LuaFunction m_OnStartButtonClick_hotfix;

		// Token: 0x0400B24C RID: 45644
		private LuaFunction m_OnLockedButtonClick_hotfix;

		// Token: 0x0400B24D RID: 45645
		private LuaFunction m_add_EventOnStartButtonClickAction;

		// Token: 0x0400B24E RID: 45646
		private LuaFunction m_remove_EventOnStartButtonClickAction;

		// Token: 0x02000FC6 RID: 4038
		public new class LuaExportHelper
		{
			// Token: 0x060142D8 RID: 82648 RVA: 0x00523350 File Offset: 0x00521550
			public LuaExportHelper(ThearchyLevelListItemUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x060142D9 RID: 82649 RVA: 0x00523360 File Offset: 0x00521560
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x060142DA RID: 82650 RVA: 0x00523370 File Offset: 0x00521570
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x060142DB RID: 82651 RVA: 0x00523380 File Offset: 0x00521580
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x060142DC RID: 82652 RVA: 0x00523390 File Offset: 0x00521590
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x060142DD RID: 82653 RVA: 0x005233A8 File Offset: 0x005215A8
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x060142DE RID: 82654 RVA: 0x005233B8 File Offset: 0x005215B8
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x060142DF RID: 82655 RVA: 0x005233C8 File Offset: 0x005215C8
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x060142E0 RID: 82656 RVA: 0x005233D8 File Offset: 0x005215D8
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x060142E1 RID: 82657 RVA: 0x005233E8 File Offset: 0x005215E8
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x060142E2 RID: 82658 RVA: 0x005233F8 File Offset: 0x005215F8
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x060142E3 RID: 82659 RVA: 0x00523408 File Offset: 0x00521608
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x060142E4 RID: 82660 RVA: 0x00523418 File Offset: 0x00521618
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x060142E5 RID: 82661 RVA: 0x00523428 File Offset: 0x00521628
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x060142E6 RID: 82662 RVA: 0x00523438 File Offset: 0x00521638
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x060142E7 RID: 82663 RVA: 0x00523448 File Offset: 0x00521648
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x060142E8 RID: 82664 RVA: 0x00523458 File Offset: 0x00521658
			public void __callDele_EventOnStartButtonClick(ThearchyLevelListItemUIController obj)
			{
				this.m_owner.__callDele_EventOnStartButtonClick(obj);
			}

			// Token: 0x060142E9 RID: 82665 RVA: 0x00523468 File Offset: 0x00521668
			public void __clearDele_EventOnStartButtonClick(ThearchyLevelListItemUIController obj)
			{
				this.m_owner.__clearDele_EventOnStartButtonClick(obj);
			}

			// Token: 0x17003C21 RID: 15393
			// (get) Token: 0x060142EA RID: 82666 RVA: 0x00523478 File Offset: 0x00521678
			// (set) Token: 0x060142EB RID: 82667 RVA: 0x00523488 File Offset: 0x00521688
			public Text m_levelText
			{
				get
				{
					return this.m_owner.m_levelText;
				}
				set
				{
					this.m_owner.m_levelText = value;
				}
			}

			// Token: 0x17003C22 RID: 15394
			// (get) Token: 0x060142EC RID: 82668 RVA: 0x00523498 File Offset: 0x00521698
			// (set) Token: 0x060142ED RID: 82669 RVA: 0x005234A8 File Offset: 0x005216A8
			public Text m_energyText
			{
				get
				{
					return this.m_owner.m_energyText;
				}
				set
				{
					this.m_owner.m_energyText = value;
				}
			}

			// Token: 0x17003C23 RID: 15395
			// (get) Token: 0x060142EE RID: 82670 RVA: 0x005234B8 File Offset: 0x005216B8
			// (set) Token: 0x060142EF RID: 82671 RVA: 0x005234C8 File Offset: 0x005216C8
			public Button m_lockedButton
			{
				get
				{
					return this.m_owner.m_lockedButton;
				}
				set
				{
					this.m_owner.m_lockedButton = value;
				}
			}

			// Token: 0x17003C24 RID: 15396
			// (get) Token: 0x060142F0 RID: 82672 RVA: 0x005234D8 File Offset: 0x005216D8
			// (set) Token: 0x060142F1 RID: 82673 RVA: 0x005234E8 File Offset: 0x005216E8
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

			// Token: 0x17003C25 RID: 15397
			// (get) Token: 0x060142F2 RID: 82674 RVA: 0x005234F8 File Offset: 0x005216F8
			// (set) Token: 0x060142F3 RID: 82675 RVA: 0x00523508 File Offset: 0x00521708
			public GameObject m_rewardGroupGameObject
			{
				get
				{
					return this.m_owner.m_rewardGroupGameObject;
				}
				set
				{
					this.m_owner.m_rewardGroupGameObject = value;
				}
			}

			// Token: 0x17003C26 RID: 15398
			// (get) Token: 0x060142F4 RID: 82676 RVA: 0x00523518 File Offset: 0x00521718
			// (set) Token: 0x060142F5 RID: 82677 RVA: 0x00523528 File Offset: 0x00521728
			public ConfigDataThearchyTrialLevelInfo m_thearchyLevelInfo
			{
				get
				{
					return this.m_owner.m_thearchyLevelInfo;
				}
				set
				{
					this.m_owner.m_thearchyLevelInfo = value;
				}
			}

			// Token: 0x060142F6 RID: 82678 RVA: 0x00523538 File Offset: 0x00521738
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x060142F7 RID: 82679 RVA: 0x00523548 File Offset: 0x00521748
			public void OnStartButtonClick()
			{
				this.m_owner.OnStartButtonClick();
			}

			// Token: 0x060142F8 RID: 82680 RVA: 0x00523558 File Offset: 0x00521758
			public void OnLockedButtonClick()
			{
				this.m_owner.OnLockedButtonClick();
			}

			// Token: 0x0400B24F RID: 45647
			private ThearchyLevelListItemUIController m_owner;
		}
	}
}
