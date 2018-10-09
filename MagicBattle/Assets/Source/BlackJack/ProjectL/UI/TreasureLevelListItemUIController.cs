using System;
using System.Threading;
using BlackJack.BJFramework.Runtime;
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
	// Token: 0x02000FCF RID: 4047
	[HotFix]
	public class TreasureLevelListItemUIController : UIControllerBase
	{
		// Token: 0x060143E0 RID: 82912 RVA: 0x005265F0 File Offset: 0x005247F0
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

		// Token: 0x060143E1 RID: 82913 RVA: 0x00526690 File Offset: 0x00524890
		public void SetTreasureLevelInfo(ConfigDataTreasureLevelInfo levelInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetTreasureLevelInfoConfigDataTreasureLevelInfo_hotfix != null)
			{
				this.m_SetTreasureLevelInfoConfigDataTreasureLevelInfo_hotfix.call(new object[]
				{
					this,
					levelInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_treasureLevelInfo = levelInfo;
			this.m_levelText.text = levelInfo.MonsterLevel.ToString();
			this.m_energyText.text = levelInfo.EnergySuccess.ToString();
			this.m_ticketText.text = levelInfo.TicketCost.ToString();
			GameObjectUtility.DestroyChildren(this.m_rewardGroupGameObject);
			GameObject assetInContainer = base.GetAssetInContainer<GameObject>("RewardGoods");
			RewardGoodsUIController.CreateRewardGoodsList(levelInfo.RewardList, this.m_rewardGroupGameObject.transform, assetInContainer, null, false, 0, true);
		}

		// Token: 0x060143E2 RID: 82914 RVA: 0x00526798 File Offset: 0x00524998
		public ConfigDataTreasureLevelInfo GetTreasureLevelInfo()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetTreasureLevelInfo_hotfix != null)
			{
				return (ConfigDataTreasureLevelInfo)this.m_GetTreasureLevelInfo_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_treasureLevelInfo;
		}

		// Token: 0x060143E3 RID: 82915 RVA: 0x0052680C File Offset: 0x00524A0C
		public void SetLocked(bool locked, ConfigDataTreasureLevelInfo levelnfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetLockedBooleanConfigDataTreasureLevelInfo_hotfix != null)
			{
				this.m_SetLockedBooleanConfigDataTreasureLevelInfo_hotfix.call(new object[]
				{
					this,
					locked,
					levelnfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (locked)
			{
				IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
				this.m_lockedText.text = string.Format(configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Msg_AchieveLevelOpen), levelnfo.OpenPlayerLevel);
			}
			this.m_lockedButton.gameObject.SetActive(locked);
		}

		// Token: 0x060143E4 RID: 82916 RVA: 0x005268DC File Offset: 0x00524ADC
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

		// Token: 0x060143E5 RID: 82917 RVA: 0x00526954 File Offset: 0x00524B54
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
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			string txt = string.Format(configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Msg_AchieveLevelOpen), this.m_treasureLevelInfo.OpenPlayerLevel);
			CommonUIController.Instance.ShowMessage(txt, 2f, null, true);
		}

		// Token: 0x1400047A RID: 1146
		// (add) Token: 0x060143E6 RID: 82918 RVA: 0x005269F8 File Offset: 0x00524BF8
		// (remove) Token: 0x060143E7 RID: 82919 RVA: 0x00526A94 File Offset: 0x00524C94
		public event Action<TreasureLevelListItemUIController> EventOnStartButtonClick
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
				Action<TreasureLevelListItemUIController> action = this.EventOnStartButtonClick;
				Action<TreasureLevelListItemUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<TreasureLevelListItemUIController>>(ref this.EventOnStartButtonClick, (Action<TreasureLevelListItemUIController>)Delegate.Combine(action2, value), action);
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
				Action<TreasureLevelListItemUIController> action = this.EventOnStartButtonClick;
				Action<TreasureLevelListItemUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<TreasureLevelListItemUIController>>(ref this.EventOnStartButtonClick, (Action<TreasureLevelListItemUIController>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17003C44 RID: 15428
		// (get) Token: 0x060143E8 RID: 82920 RVA: 0x00526B30 File Offset: 0x00524D30
		// (set) Token: 0x060143E9 RID: 82921 RVA: 0x00526B50 File Offset: 0x00524D50
		[DoNotToLua]
		public new TreasureLevelListItemUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new TreasureLevelListItemUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x060143EA RID: 82922 RVA: 0x00526B5C File Offset: 0x00524D5C
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x060143EB RID: 82923 RVA: 0x00526B68 File Offset: 0x00524D68
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x060143EC RID: 82924 RVA: 0x00526B70 File Offset: 0x00524D70
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x060143ED RID: 82925 RVA: 0x00526B78 File Offset: 0x00524D78
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x060143EE RID: 82926 RVA: 0x00526B8C File Offset: 0x00524D8C
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x060143EF RID: 82927 RVA: 0x00526B94 File Offset: 0x00524D94
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x060143F0 RID: 82928 RVA: 0x00526BA0 File Offset: 0x00524DA0
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x060143F1 RID: 82929 RVA: 0x00526BAC File Offset: 0x00524DAC
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x060143F2 RID: 82930 RVA: 0x00526BB8 File Offset: 0x00524DB8
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x060143F3 RID: 82931 RVA: 0x00526BC4 File Offset: 0x00524DC4
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x060143F4 RID: 82932 RVA: 0x00526BD0 File Offset: 0x00524DD0
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x060143F5 RID: 82933 RVA: 0x00526BDC File Offset: 0x00524DDC
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x060143F6 RID: 82934 RVA: 0x00526BE8 File Offset: 0x00524DE8
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x060143F7 RID: 82935 RVA: 0x00526BF4 File Offset: 0x00524DF4
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x060143F8 RID: 82936 RVA: 0x00526C00 File Offset: 0x00524E00
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x060143F9 RID: 82937 RVA: 0x00526C08 File Offset: 0x00524E08
		private void __callDele_EventOnStartButtonClick(TreasureLevelListItemUIController obj)
		{
			Action<TreasureLevelListItemUIController> eventOnStartButtonClick = this.EventOnStartButtonClick;
			if (eventOnStartButtonClick != null)
			{
				eventOnStartButtonClick(obj);
			}
		}

		// Token: 0x060143FA RID: 82938 RVA: 0x00526C2C File Offset: 0x00524E2C
		private void __clearDele_EventOnStartButtonClick(TreasureLevelListItemUIController obj)
		{
			this.EventOnStartButtonClick = null;
		}

		// Token: 0x060143FB RID: 82939 RVA: 0x00526C38 File Offset: 0x00524E38
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
					this.m_SetTreasureLevelInfoConfigDataTreasureLevelInfo_hotfix = (luaObj.RawGet("SetTreasureLevelInfo") as LuaFunction);
					this.m_GetTreasureLevelInfo_hotfix = (luaObj.RawGet("GetTreasureLevelInfo") as LuaFunction);
					this.m_SetLockedBooleanConfigDataTreasureLevelInfo_hotfix = (luaObj.RawGet("SetLocked") as LuaFunction);
					this.m_OnStartButtonClick_hotfix = (luaObj.RawGet("OnStartButtonClick") as LuaFunction);
					this.m_OnLockedButtonClick_hotfix = (luaObj.RawGet("OnLockedButtonClick") as LuaFunction);
					this.m_add_EventOnStartButtonClickAction`1_hotfix = (luaObj.RawGet("add_EventOnStartButtonClick") as LuaFunction);
					this.m_remove_EventOnStartButtonClickAction`1_hotfix = (luaObj.RawGet("remove_EventOnStartButtonClick") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x060143FC RID: 82940 RVA: 0x00526DB4 File Offset: 0x00524FB4
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(TreasureLevelListItemUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400B2A5 RID: 45733
		[AutoBind("./Level/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_levelText;

		// Token: 0x0400B2A6 RID: 45734
		[AutoBind("./EnergyValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_energyText;

		// Token: 0x0400B2A7 RID: 45735
		[AutoBind("./TicketValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_ticketText;

		// Token: 0x0400B2A8 RID: 45736
		[AutoBind("./Locked", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_lockedButton;

		// Token: 0x0400B2A9 RID: 45737
		[AutoBind("./Locked/TextGroup", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_lockedText;

		// Token: 0x0400B2AA RID: 45738
		[AutoBind("./StartButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_startButton;

		// Token: 0x0400B2AB RID: 45739
		[AutoBind("./RewardGroup", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_rewardGroupGameObject;

		// Token: 0x0400B2AC RID: 45740
		private ConfigDataTreasureLevelInfo m_treasureLevelInfo;

		// Token: 0x0400B2AD RID: 45741
		[DoNotToLua]
		private TreasureLevelListItemUIController.LuaExportHelper luaExportHelper;

		// Token: 0x0400B2AE RID: 45742
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400B2AF RID: 45743
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400B2B0 RID: 45744
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x0400B2B1 RID: 45745
		private LuaFunction m_SetTreasureLevelInfoConfigDataTreasureLevelInfo_hotfix;

		// Token: 0x0400B2B2 RID: 45746
		private LuaFunction m_GetTreasureLevelInfo_hotfix;

		// Token: 0x0400B2B3 RID: 45747
		private LuaFunction m_SetLockedBooleanConfigDataTreasureLevelInfo_hotfix;

		// Token: 0x0400B2B4 RID: 45748
		private LuaFunction m_OnStartButtonClick_hotfix;

		// Token: 0x0400B2B5 RID: 45749
		private LuaFunction m_OnLockedButtonClick_hotfix;

		// Token: 0x0400B2B6 RID: 45750
		private LuaFunction m_add_EventOnStartButtonClickAction;

		// Token: 0x0400B2B7 RID: 45751
		private LuaFunction m_remove_EventOnStartButtonClickAction;

		// Token: 0x02000FD0 RID: 4048
		public new class LuaExportHelper
		{
			// Token: 0x060143FD RID: 82941 RVA: 0x00526E1C File Offset: 0x0052501C
			public LuaExportHelper(TreasureLevelListItemUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x060143FE RID: 82942 RVA: 0x00526E2C File Offset: 0x0052502C
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x060143FF RID: 82943 RVA: 0x00526E3C File Offset: 0x0052503C
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x06014400 RID: 82944 RVA: 0x00526E4C File Offset: 0x0052504C
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x06014401 RID: 82945 RVA: 0x00526E5C File Offset: 0x0052505C
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x06014402 RID: 82946 RVA: 0x00526E74 File Offset: 0x00525074
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x06014403 RID: 82947 RVA: 0x00526E84 File Offset: 0x00525084
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x06014404 RID: 82948 RVA: 0x00526E94 File Offset: 0x00525094
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x06014405 RID: 82949 RVA: 0x00526EA4 File Offset: 0x005250A4
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x06014406 RID: 82950 RVA: 0x00526EB4 File Offset: 0x005250B4
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x06014407 RID: 82951 RVA: 0x00526EC4 File Offset: 0x005250C4
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x06014408 RID: 82952 RVA: 0x00526ED4 File Offset: 0x005250D4
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x06014409 RID: 82953 RVA: 0x00526EE4 File Offset: 0x005250E4
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0601440A RID: 82954 RVA: 0x00526EF4 File Offset: 0x005250F4
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0601440B RID: 82955 RVA: 0x00526F04 File Offset: 0x00525104
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0601440C RID: 82956 RVA: 0x00526F14 File Offset: 0x00525114
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x0601440D RID: 82957 RVA: 0x00526F24 File Offset: 0x00525124
			public void __callDele_EventOnStartButtonClick(TreasureLevelListItemUIController obj)
			{
				this.m_owner.__callDele_EventOnStartButtonClick(obj);
			}

			// Token: 0x0601440E RID: 82958 RVA: 0x00526F34 File Offset: 0x00525134
			public void __clearDele_EventOnStartButtonClick(TreasureLevelListItemUIController obj)
			{
				this.m_owner.__clearDele_EventOnStartButtonClick(obj);
			}

			// Token: 0x17003C45 RID: 15429
			// (get) Token: 0x0601440F RID: 82959 RVA: 0x00526F44 File Offset: 0x00525144
			// (set) Token: 0x06014410 RID: 82960 RVA: 0x00526F54 File Offset: 0x00525154
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

			// Token: 0x17003C46 RID: 15430
			// (get) Token: 0x06014411 RID: 82961 RVA: 0x00526F64 File Offset: 0x00525164
			// (set) Token: 0x06014412 RID: 82962 RVA: 0x00526F74 File Offset: 0x00525174
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

			// Token: 0x17003C47 RID: 15431
			// (get) Token: 0x06014413 RID: 82963 RVA: 0x00526F84 File Offset: 0x00525184
			// (set) Token: 0x06014414 RID: 82964 RVA: 0x00526F94 File Offset: 0x00525194
			public Text m_ticketText
			{
				get
				{
					return this.m_owner.m_ticketText;
				}
				set
				{
					this.m_owner.m_ticketText = value;
				}
			}

			// Token: 0x17003C48 RID: 15432
			// (get) Token: 0x06014415 RID: 82965 RVA: 0x00526FA4 File Offset: 0x005251A4
			// (set) Token: 0x06014416 RID: 82966 RVA: 0x00526FB4 File Offset: 0x005251B4
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

			// Token: 0x17003C49 RID: 15433
			// (get) Token: 0x06014417 RID: 82967 RVA: 0x00526FC4 File Offset: 0x005251C4
			// (set) Token: 0x06014418 RID: 82968 RVA: 0x00526FD4 File Offset: 0x005251D4
			public Text m_lockedText
			{
				get
				{
					return this.m_owner.m_lockedText;
				}
				set
				{
					this.m_owner.m_lockedText = value;
				}
			}

			// Token: 0x17003C4A RID: 15434
			// (get) Token: 0x06014419 RID: 82969 RVA: 0x00526FE4 File Offset: 0x005251E4
			// (set) Token: 0x0601441A RID: 82970 RVA: 0x00526FF4 File Offset: 0x005251F4
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

			// Token: 0x17003C4B RID: 15435
			// (get) Token: 0x0601441B RID: 82971 RVA: 0x00527004 File Offset: 0x00525204
			// (set) Token: 0x0601441C RID: 82972 RVA: 0x00527014 File Offset: 0x00525214
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

			// Token: 0x17003C4C RID: 15436
			// (get) Token: 0x0601441D RID: 82973 RVA: 0x00527024 File Offset: 0x00525224
			// (set) Token: 0x0601441E RID: 82974 RVA: 0x00527034 File Offset: 0x00525234
			public ConfigDataTreasureLevelInfo m_treasureLevelInfo
			{
				get
				{
					return this.m_owner.m_treasureLevelInfo;
				}
				set
				{
					this.m_owner.m_treasureLevelInfo = value;
				}
			}

			// Token: 0x0601441F RID: 82975 RVA: 0x00527044 File Offset: 0x00525244
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x06014420 RID: 82976 RVA: 0x00527054 File Offset: 0x00525254
			public void OnStartButtonClick()
			{
				this.m_owner.OnStartButtonClick();
			}

			// Token: 0x06014421 RID: 82977 RVA: 0x00527064 File Offset: 0x00525264
			public void OnLockedButtonClick()
			{
				this.m_owner.OnLockedButtonClick();
			}

			// Token: 0x0400B2B8 RID: 45752
			private TreasureLevelListItemUIController m_owner;
		}
	}
}
