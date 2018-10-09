using System;
using System.Collections.Generic;
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
	// Token: 0x02000E28 RID: 3624
	[HotFix]
	public class HeroTrainningLevelListItemUIController : UIControllerBase
	{
		// Token: 0x06011808 RID: 71688 RVA: 0x00487B58 File Offset: 0x00485D58
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

		// Token: 0x06011809 RID: 71689 RVA: 0x00487BF8 File Offset: 0x00485DF8
		public void SetHeroTrainningLevelInfo(ConfigDataHeroTrainningLevelInfo levelInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetHeroTrainningLevelInfoConfigDataHeroTrainningLevelInfo_hotfix != null)
			{
				this.m_SetHeroTrainningLevelInfoConfigDataHeroTrainningLevelInfo_hotfix.call(new object[]
				{
					this,
					levelInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_heroTrainningLevelInfo = levelInfo;
			this.m_levelText.text = levelInfo.MonsterLevel.ToString();
			this.m_energyText.text = levelInfo.EnergySuccess.ToString();
			this.m_levelNameText.text = levelInfo.Name;
			this.m_iconImage.sprite = AssetUtility.Instance.GetSprite(levelInfo.Icon);
			GameObjectUtility.DestroyChildren(this.m_rewardGroupGameObject);
			GameObject assetInContainer = base.GetAssetInContainer<GameObject>("RewardGoods");
			List<Goods> list = new List<Goods>();
			UIUtility.AppendRandomDropRewardGoodsToList(levelInfo.Drop_ID, list);
			if (list.Count > levelInfo.DisplayRewardCount)
			{
				list.RemoveRange(levelInfo.DisplayRewardCount, list.Count - levelInfo.DisplayRewardCount);
			}
			RewardGoodsUIController.CreateRewardGoodsList(list, this.m_rewardGroupGameObject.transform, assetInContainer, null, false, 0, true);
		}

		// Token: 0x0601180A RID: 71690 RVA: 0x00487D44 File Offset: 0x00485F44
		public ConfigDataHeroTrainningLevelInfo GetHeroTrainningLevelInfo()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetHeroTrainningLevelInfo_hotfix != null)
			{
				return (ConfigDataHeroTrainningLevelInfo)this.m_GetHeroTrainningLevelInfo_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_heroTrainningLevelInfo;
		}

		// Token: 0x0601180B RID: 71691 RVA: 0x00487DB8 File Offset: 0x00485FB8
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
			if (this.m_lockedText != null)
			{
				IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
				this.m_lockedText.text = string.Format(configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Msg_AchieveLevelOpen), this.m_heroTrainningLevelInfo.OpenPlayerLevel);
			}
			this.m_lockedButton.gameObject.SetActive(locked);
		}

		// Token: 0x0601180C RID: 71692 RVA: 0x00487E88 File Offset: 0x00486088
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

		// Token: 0x0601180D RID: 71693 RVA: 0x00487F00 File Offset: 0x00486100
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
			string txt = string.Format(configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Msg_AchieveLevelOpen), this.m_heroTrainningLevelInfo.OpenPlayerLevel);
			CommonUIController.Instance.ShowMessage(txt, 2f, null, true);
		}

		// Token: 0x140003C6 RID: 966
		// (add) Token: 0x0601180E RID: 71694 RVA: 0x00487FA4 File Offset: 0x004861A4
		// (remove) Token: 0x0601180F RID: 71695 RVA: 0x00488040 File Offset: 0x00486240
		public event Action<HeroTrainningLevelListItemUIController> EventOnStartButtonClick
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
				Action<HeroTrainningLevelListItemUIController> action = this.EventOnStartButtonClick;
				Action<HeroTrainningLevelListItemUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<HeroTrainningLevelListItemUIController>>(ref this.EventOnStartButtonClick, (Action<HeroTrainningLevelListItemUIController>)Delegate.Combine(action2, value), action);
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
				Action<HeroTrainningLevelListItemUIController> action = this.EventOnStartButtonClick;
				Action<HeroTrainningLevelListItemUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<HeroTrainningLevelListItemUIController>>(ref this.EventOnStartButtonClick, (Action<HeroTrainningLevelListItemUIController>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x170035CB RID: 13771
		// (get) Token: 0x06011810 RID: 71696 RVA: 0x004880DC File Offset: 0x004862DC
		// (set) Token: 0x06011811 RID: 71697 RVA: 0x004880FC File Offset: 0x004862FC
		[DoNotToLua]
		public new HeroTrainningLevelListItemUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new HeroTrainningLevelListItemUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06011812 RID: 71698 RVA: 0x00488108 File Offset: 0x00486308
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x06011813 RID: 71699 RVA: 0x00488114 File Offset: 0x00486314
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x06011814 RID: 71700 RVA: 0x0048811C File Offset: 0x0048631C
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x06011815 RID: 71701 RVA: 0x00488124 File Offset: 0x00486324
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x06011816 RID: 71702 RVA: 0x00488138 File Offset: 0x00486338
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x06011817 RID: 71703 RVA: 0x00488140 File Offset: 0x00486340
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x06011818 RID: 71704 RVA: 0x0048814C File Offset: 0x0048634C
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x06011819 RID: 71705 RVA: 0x00488158 File Offset: 0x00486358
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0601181A RID: 71706 RVA: 0x00488164 File Offset: 0x00486364
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0601181B RID: 71707 RVA: 0x00488170 File Offset: 0x00486370
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0601181C RID: 71708 RVA: 0x0048817C File Offset: 0x0048637C
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0601181D RID: 71709 RVA: 0x00488188 File Offset: 0x00486388
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0601181E RID: 71710 RVA: 0x00488194 File Offset: 0x00486394
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0601181F RID: 71711 RVA: 0x004881A0 File Offset: 0x004863A0
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x06011820 RID: 71712 RVA: 0x004881AC File Offset: 0x004863AC
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x06011821 RID: 71713 RVA: 0x004881B4 File Offset: 0x004863B4
		private void __callDele_EventOnStartButtonClick(HeroTrainningLevelListItemUIController obj)
		{
			Action<HeroTrainningLevelListItemUIController> eventOnStartButtonClick = this.EventOnStartButtonClick;
			if (eventOnStartButtonClick != null)
			{
				eventOnStartButtonClick(obj);
			}
		}

		// Token: 0x06011822 RID: 71714 RVA: 0x004881D8 File Offset: 0x004863D8
		private void __clearDele_EventOnStartButtonClick(HeroTrainningLevelListItemUIController obj)
		{
			this.EventOnStartButtonClick = null;
		}

		// Token: 0x06011823 RID: 71715 RVA: 0x004881E4 File Offset: 0x004863E4
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
					this.m_SetHeroTrainningLevelInfoConfigDataHeroTrainningLevelInfo_hotfix = (luaObj.RawGet("SetHeroTrainningLevelInfo") as LuaFunction);
					this.m_GetHeroTrainningLevelInfo_hotfix = (luaObj.RawGet("GetHeroTrainningLevelInfo") as LuaFunction);
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

		// Token: 0x06011824 RID: 71716 RVA: 0x00488360 File Offset: 0x00486560
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(HeroTrainningLevelListItemUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04009FBC RID: 40892
		[AutoBind("./Text/TitleText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_levelNameText;

		// Token: 0x04009FBD RID: 40893
		[AutoBind("./IconImage", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_iconImage;

		// Token: 0x04009FBE RID: 40894
		[AutoBind("./Text/LVNumberText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_levelText;

		// Token: 0x04009FBF RID: 40895
		[AutoBind("./Text/EnergyValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_energyText;

		// Token: 0x04009FC0 RID: 40896
		[AutoBind("./Locked", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_lockedButton;

		// Token: 0x04009FC1 RID: 40897
		[AutoBind("./StartButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_startButton;

		// Token: 0x04009FC2 RID: 40898
		[AutoBind("./RewardGroup", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_rewardGroupGameObject;

		// Token: 0x04009FC3 RID: 40899
		[AutoBind("./Locked/LockText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_lockedText;

		// Token: 0x04009FC4 RID: 40900
		private ConfigDataHeroTrainningLevelInfo m_heroTrainningLevelInfo;

		// Token: 0x04009FC5 RID: 40901
		[DoNotToLua]
		private HeroTrainningLevelListItemUIController.LuaExportHelper luaExportHelper;

		// Token: 0x04009FC6 RID: 40902
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04009FC7 RID: 40903
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04009FC8 RID: 40904
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x04009FC9 RID: 40905
		private LuaFunction m_SetHeroTrainningLevelInfoConfigDataHeroTrainningLevelInfo_hotfix;

		// Token: 0x04009FCA RID: 40906
		private LuaFunction m_GetHeroTrainningLevelInfo_hotfix;

		// Token: 0x04009FCB RID: 40907
		private LuaFunction m_SetLockedBoolean_hotfix;

		// Token: 0x04009FCC RID: 40908
		private LuaFunction m_OnStartButtonClick_hotfix;

		// Token: 0x04009FCD RID: 40909
		private LuaFunction m_OnLockedButtonClick_hotfix;

		// Token: 0x04009FCE RID: 40910
		private LuaFunction m_add_EventOnStartButtonClickAction;

		// Token: 0x04009FCF RID: 40911
		private LuaFunction m_remove_EventOnStartButtonClickAction;

		// Token: 0x02000E29 RID: 3625
		public new class LuaExportHelper
		{
			// Token: 0x06011825 RID: 71717 RVA: 0x004883C8 File Offset: 0x004865C8
			public LuaExportHelper(HeroTrainningLevelListItemUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06011826 RID: 71718 RVA: 0x004883D8 File Offset: 0x004865D8
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x06011827 RID: 71719 RVA: 0x004883E8 File Offset: 0x004865E8
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x06011828 RID: 71720 RVA: 0x004883F8 File Offset: 0x004865F8
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x06011829 RID: 71721 RVA: 0x00488408 File Offset: 0x00486608
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0601182A RID: 71722 RVA: 0x00488420 File Offset: 0x00486620
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0601182B RID: 71723 RVA: 0x00488430 File Offset: 0x00486630
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0601182C RID: 71724 RVA: 0x00488440 File Offset: 0x00486640
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0601182D RID: 71725 RVA: 0x00488450 File Offset: 0x00486650
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0601182E RID: 71726 RVA: 0x00488460 File Offset: 0x00486660
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0601182F RID: 71727 RVA: 0x00488470 File Offset: 0x00486670
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x06011830 RID: 71728 RVA: 0x00488480 File Offset: 0x00486680
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x06011831 RID: 71729 RVA: 0x00488490 File Offset: 0x00486690
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x06011832 RID: 71730 RVA: 0x004884A0 File Offset: 0x004866A0
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x06011833 RID: 71731 RVA: 0x004884B0 File Offset: 0x004866B0
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x06011834 RID: 71732 RVA: 0x004884C0 File Offset: 0x004866C0
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x06011835 RID: 71733 RVA: 0x004884D0 File Offset: 0x004866D0
			public void __callDele_EventOnStartButtonClick(HeroTrainningLevelListItemUIController obj)
			{
				this.m_owner.__callDele_EventOnStartButtonClick(obj);
			}

			// Token: 0x06011836 RID: 71734 RVA: 0x004884E0 File Offset: 0x004866E0
			public void __clearDele_EventOnStartButtonClick(HeroTrainningLevelListItemUIController obj)
			{
				this.m_owner.__clearDele_EventOnStartButtonClick(obj);
			}

			// Token: 0x170035CC RID: 13772
			// (get) Token: 0x06011837 RID: 71735 RVA: 0x004884F0 File Offset: 0x004866F0
			// (set) Token: 0x06011838 RID: 71736 RVA: 0x00488500 File Offset: 0x00486700
			public Text m_levelNameText
			{
				get
				{
					return this.m_owner.m_levelNameText;
				}
				set
				{
					this.m_owner.m_levelNameText = value;
				}
			}

			// Token: 0x170035CD RID: 13773
			// (get) Token: 0x06011839 RID: 71737 RVA: 0x00488510 File Offset: 0x00486710
			// (set) Token: 0x0601183A RID: 71738 RVA: 0x00488520 File Offset: 0x00486720
			public Image m_iconImage
			{
				get
				{
					return this.m_owner.m_iconImage;
				}
				set
				{
					this.m_owner.m_iconImage = value;
				}
			}

			// Token: 0x170035CE RID: 13774
			// (get) Token: 0x0601183B RID: 71739 RVA: 0x00488530 File Offset: 0x00486730
			// (set) Token: 0x0601183C RID: 71740 RVA: 0x00488540 File Offset: 0x00486740
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

			// Token: 0x170035CF RID: 13775
			// (get) Token: 0x0601183D RID: 71741 RVA: 0x00488550 File Offset: 0x00486750
			// (set) Token: 0x0601183E RID: 71742 RVA: 0x00488560 File Offset: 0x00486760
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

			// Token: 0x170035D0 RID: 13776
			// (get) Token: 0x0601183F RID: 71743 RVA: 0x00488570 File Offset: 0x00486770
			// (set) Token: 0x06011840 RID: 71744 RVA: 0x00488580 File Offset: 0x00486780
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

			// Token: 0x170035D1 RID: 13777
			// (get) Token: 0x06011841 RID: 71745 RVA: 0x00488590 File Offset: 0x00486790
			// (set) Token: 0x06011842 RID: 71746 RVA: 0x004885A0 File Offset: 0x004867A0
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

			// Token: 0x170035D2 RID: 13778
			// (get) Token: 0x06011843 RID: 71747 RVA: 0x004885B0 File Offset: 0x004867B0
			// (set) Token: 0x06011844 RID: 71748 RVA: 0x004885C0 File Offset: 0x004867C0
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

			// Token: 0x170035D3 RID: 13779
			// (get) Token: 0x06011845 RID: 71749 RVA: 0x004885D0 File Offset: 0x004867D0
			// (set) Token: 0x06011846 RID: 71750 RVA: 0x004885E0 File Offset: 0x004867E0
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

			// Token: 0x170035D4 RID: 13780
			// (get) Token: 0x06011847 RID: 71751 RVA: 0x004885F0 File Offset: 0x004867F0
			// (set) Token: 0x06011848 RID: 71752 RVA: 0x00488600 File Offset: 0x00486800
			public ConfigDataHeroTrainningLevelInfo m_heroTrainningLevelInfo
			{
				get
				{
					return this.m_owner.m_heroTrainningLevelInfo;
				}
				set
				{
					this.m_owner.m_heroTrainningLevelInfo = value;
				}
			}

			// Token: 0x06011849 RID: 71753 RVA: 0x00488610 File Offset: 0x00486810
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0601184A RID: 71754 RVA: 0x00488620 File Offset: 0x00486820
			public void OnStartButtonClick()
			{
				this.m_owner.OnStartButtonClick();
			}

			// Token: 0x0601184B RID: 71755 RVA: 0x00488630 File Offset: 0x00486830
			public void OnLockedButtonClick()
			{
				this.m_owner.OnLockedButtonClick();
			}

			// Token: 0x04009FD0 RID: 40912
			private HeroTrainningLevelListItemUIController m_owner;
		}
	}
}
