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
	// Token: 0x02000C13 RID: 3091
	[HotFix]
	public class CooperateBattleLevelListItemUIController : UIControllerBase
	{
		// Token: 0x0600D92B RID: 55595 RVA: 0x003AFBAC File Offset: 0x003ADDAC
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

		// Token: 0x0600D92C RID: 55596 RVA: 0x003AFC4C File Offset: 0x003ADE4C
		public void SetCooperateBattleLevelInfo(ConfigDataCooperateBattleLevelInfo levelInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetCooperateBattleLevelInfoConfigDataCooperateBattleLevelInfo_hotfix != null)
			{
				this.m_SetCooperateBattleLevelInfoConfigDataCooperateBattleLevelInfo_hotfix.call(new object[]
				{
					this,
					levelInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_cooperateBattleLevelInfo = levelInfo;
			this.m_nameText.text = levelInfo.Name;
			this.m_levelText.text = levelInfo.MonsterLevel.ToString();
			this.m_energyText.text = levelInfo.EnergySuccess.ToString();
			GameObjectUtility.DestroyChildren(this.m_rewardGroupGameObject);
			GameObject assetInContainer = base.GetAssetInContainer<GameObject>("RewardGoods");
			List<Goods> list = new List<Goods>();
			UIUtility.AppendRandomDropRewardGoodsToList(levelInfo.DropID, list);
			if (list.Count > levelInfo.ItemDropCountDisplay)
			{
				list.RemoveRange(levelInfo.ItemDropCountDisplay, list.Count - levelInfo.ItemDropCountDisplay);
			}
			RewardGoodsUIController.CreateRewardGoodsList(list, this.m_rewardGroupGameObject.transform, assetInContainer, null, false, 0, true);
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			this.m_lockedText.text = string.Format(configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Msg_AchieveLevelOpen), levelInfo.PlayerLevelRequired);
		}

		// Token: 0x0600D92D RID: 55597 RVA: 0x003AFDB4 File Offset: 0x003ADFB4
		public ConfigDataCooperateBattleLevelInfo GetCooperateBattleLevelInfo()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetCooperateBattleLevelInfo_hotfix != null)
			{
				return (ConfigDataCooperateBattleLevelInfo)this.m_GetCooperateBattleLevelInfo_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_cooperateBattleLevelInfo;
		}

		// Token: 0x0600D92E RID: 55598 RVA: 0x003AFE28 File Offset: 0x003AE028
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

		// Token: 0x0600D92F RID: 55599 RVA: 0x003AFEAC File Offset: 0x003AE0AC
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

		// Token: 0x0600D930 RID: 55600 RVA: 0x003AFF24 File Offset: 0x003AE124
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
			CommonUIController.Instance.ShowMessage(string.Format(configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Msg_AchieveLevelOpen), this.m_cooperateBattleLevelInfo.PlayerLevelRequired), 2f, null, true);
		}

		// Token: 0x140002B4 RID: 692
		// (add) Token: 0x0600D931 RID: 55601 RVA: 0x003AFFC8 File Offset: 0x003AE1C8
		// (remove) Token: 0x0600D932 RID: 55602 RVA: 0x003B0064 File Offset: 0x003AE264
		public event Action<CooperateBattleLevelListItemUIController> EventOnStartButtonClick
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
				Action<CooperateBattleLevelListItemUIController> action = this.EventOnStartButtonClick;
				Action<CooperateBattleLevelListItemUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<CooperateBattleLevelListItemUIController>>(ref this.EventOnStartButtonClick, (Action<CooperateBattleLevelListItemUIController>)Delegate.Combine(action2, value), action);
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
				Action<CooperateBattleLevelListItemUIController> action = this.EventOnStartButtonClick;
				Action<CooperateBattleLevelListItemUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<CooperateBattleLevelListItemUIController>>(ref this.EventOnStartButtonClick, (Action<CooperateBattleLevelListItemUIController>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17002A3A RID: 10810
		// (get) Token: 0x0600D933 RID: 55603 RVA: 0x003B0100 File Offset: 0x003AE300
		// (set) Token: 0x0600D934 RID: 55604 RVA: 0x003B0120 File Offset: 0x003AE320
		[DoNotToLua]
		public new CooperateBattleLevelListItemUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new CooperateBattleLevelListItemUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600D935 RID: 55605 RVA: 0x003B012C File Offset: 0x003AE32C
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0600D936 RID: 55606 RVA: 0x003B0138 File Offset: 0x003AE338
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0600D937 RID: 55607 RVA: 0x003B0140 File Offset: 0x003AE340
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0600D938 RID: 55608 RVA: 0x003B0148 File Offset: 0x003AE348
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0600D939 RID: 55609 RVA: 0x003B015C File Offset: 0x003AE35C
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0600D93A RID: 55610 RVA: 0x003B0164 File Offset: 0x003AE364
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0600D93B RID: 55611 RVA: 0x003B0170 File Offset: 0x003AE370
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0600D93C RID: 55612 RVA: 0x003B017C File Offset: 0x003AE37C
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0600D93D RID: 55613 RVA: 0x003B0188 File Offset: 0x003AE388
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0600D93E RID: 55614 RVA: 0x003B0194 File Offset: 0x003AE394
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0600D93F RID: 55615 RVA: 0x003B01A0 File Offset: 0x003AE3A0
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0600D940 RID: 55616 RVA: 0x003B01AC File Offset: 0x003AE3AC
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0600D941 RID: 55617 RVA: 0x003B01B8 File Offset: 0x003AE3B8
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0600D942 RID: 55618 RVA: 0x003B01C4 File Offset: 0x003AE3C4
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0600D943 RID: 55619 RVA: 0x003B01D0 File Offset: 0x003AE3D0
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600D944 RID: 55620 RVA: 0x003B01D8 File Offset: 0x003AE3D8
		private void __callDele_EventOnStartButtonClick(CooperateBattleLevelListItemUIController obj)
		{
			Action<CooperateBattleLevelListItemUIController> eventOnStartButtonClick = this.EventOnStartButtonClick;
			if (eventOnStartButtonClick != null)
			{
				eventOnStartButtonClick(obj);
			}
		}

		// Token: 0x0600D945 RID: 55621 RVA: 0x003B01FC File Offset: 0x003AE3FC
		private void __clearDele_EventOnStartButtonClick(CooperateBattleLevelListItemUIController obj)
		{
			this.EventOnStartButtonClick = null;
		}

		// Token: 0x0600D946 RID: 55622 RVA: 0x003B0208 File Offset: 0x003AE408
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
					this.m_SetCooperateBattleLevelInfoConfigDataCooperateBattleLevelInfo_hotfix = (luaObj.RawGet("SetCooperateBattleLevelInfo") as LuaFunction);
					this.m_GetCooperateBattleLevelInfo_hotfix = (luaObj.RawGet("GetCooperateBattleLevelInfo") as LuaFunction);
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

		// Token: 0x0600D947 RID: 55623 RVA: 0x003B0384 File Offset: 0x003AE584
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(CooperateBattleLevelListItemUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400853A RID: 34106
		[AutoBind("./Level/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_levelText;

		// Token: 0x0400853B RID: 34107
		[AutoBind("./NameText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_nameText;

		// Token: 0x0400853C RID: 34108
		[AutoBind("./EnergyValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_energyText;

		// Token: 0x0400853D RID: 34109
		[AutoBind("./Locked", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_lockedButton;

		// Token: 0x0400853E RID: 34110
		[AutoBind("./Locked/TextGroup", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_lockedText;

		// Token: 0x0400853F RID: 34111
		[AutoBind("./StartButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_startButton;

		// Token: 0x04008540 RID: 34112
		[AutoBind("./RewardGroup", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_rewardGroupGameObject;

		// Token: 0x04008541 RID: 34113
		private ConfigDataCooperateBattleLevelInfo m_cooperateBattleLevelInfo;

		// Token: 0x04008542 RID: 34114
		[DoNotToLua]
		private CooperateBattleLevelListItemUIController.LuaExportHelper luaExportHelper;

		// Token: 0x04008543 RID: 34115
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04008544 RID: 34116
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04008545 RID: 34117
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x04008546 RID: 34118
		private LuaFunction m_SetCooperateBattleLevelInfoConfigDataCooperateBattleLevelInfo_hotfix;

		// Token: 0x04008547 RID: 34119
		private LuaFunction m_GetCooperateBattleLevelInfo_hotfix;

		// Token: 0x04008548 RID: 34120
		private LuaFunction m_SetLockedBoolean_hotfix;

		// Token: 0x04008549 RID: 34121
		private LuaFunction m_OnStartButtonClick_hotfix;

		// Token: 0x0400854A RID: 34122
		private LuaFunction m_OnLockedButtonClick_hotfix;

		// Token: 0x0400854B RID: 34123
		private LuaFunction m_add_EventOnStartButtonClickAction;

		// Token: 0x0400854C RID: 34124
		private LuaFunction m_remove_EventOnStartButtonClickAction;

		// Token: 0x02000C14 RID: 3092
		public new class LuaExportHelper
		{
			// Token: 0x0600D948 RID: 55624 RVA: 0x003B03EC File Offset: 0x003AE5EC
			public LuaExportHelper(CooperateBattleLevelListItemUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600D949 RID: 55625 RVA: 0x003B03FC File Offset: 0x003AE5FC
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0600D94A RID: 55626 RVA: 0x003B040C File Offset: 0x003AE60C
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0600D94B RID: 55627 RVA: 0x003B041C File Offset: 0x003AE61C
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600D94C RID: 55628 RVA: 0x003B042C File Offset: 0x003AE62C
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600D94D RID: 55629 RVA: 0x003B0444 File Offset: 0x003AE644
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0600D94E RID: 55630 RVA: 0x003B0454 File Offset: 0x003AE654
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0600D94F RID: 55631 RVA: 0x003B0464 File Offset: 0x003AE664
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0600D950 RID: 55632 RVA: 0x003B0474 File Offset: 0x003AE674
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0600D951 RID: 55633 RVA: 0x003B0484 File Offset: 0x003AE684
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0600D952 RID: 55634 RVA: 0x003B0494 File Offset: 0x003AE694
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0600D953 RID: 55635 RVA: 0x003B04A4 File Offset: 0x003AE6A4
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0600D954 RID: 55636 RVA: 0x003B04B4 File Offset: 0x003AE6B4
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0600D955 RID: 55637 RVA: 0x003B04C4 File Offset: 0x003AE6C4
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0600D956 RID: 55638 RVA: 0x003B04D4 File Offset: 0x003AE6D4
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0600D957 RID: 55639 RVA: 0x003B04E4 File Offset: 0x003AE6E4
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x0600D958 RID: 55640 RVA: 0x003B04F4 File Offset: 0x003AE6F4
			public void __callDele_EventOnStartButtonClick(CooperateBattleLevelListItemUIController obj)
			{
				this.m_owner.__callDele_EventOnStartButtonClick(obj);
			}

			// Token: 0x0600D959 RID: 55641 RVA: 0x003B0504 File Offset: 0x003AE704
			public void __clearDele_EventOnStartButtonClick(CooperateBattleLevelListItemUIController obj)
			{
				this.m_owner.__clearDele_EventOnStartButtonClick(obj);
			}

			// Token: 0x17002A3B RID: 10811
			// (get) Token: 0x0600D95A RID: 55642 RVA: 0x003B0514 File Offset: 0x003AE714
			// (set) Token: 0x0600D95B RID: 55643 RVA: 0x003B0524 File Offset: 0x003AE724
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

			// Token: 0x17002A3C RID: 10812
			// (get) Token: 0x0600D95C RID: 55644 RVA: 0x003B0534 File Offset: 0x003AE734
			// (set) Token: 0x0600D95D RID: 55645 RVA: 0x003B0544 File Offset: 0x003AE744
			public Text m_nameText
			{
				get
				{
					return this.m_owner.m_nameText;
				}
				set
				{
					this.m_owner.m_nameText = value;
				}
			}

			// Token: 0x17002A3D RID: 10813
			// (get) Token: 0x0600D95E RID: 55646 RVA: 0x003B0554 File Offset: 0x003AE754
			// (set) Token: 0x0600D95F RID: 55647 RVA: 0x003B0564 File Offset: 0x003AE764
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

			// Token: 0x17002A3E RID: 10814
			// (get) Token: 0x0600D960 RID: 55648 RVA: 0x003B0574 File Offset: 0x003AE774
			// (set) Token: 0x0600D961 RID: 55649 RVA: 0x003B0584 File Offset: 0x003AE784
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

			// Token: 0x17002A3F RID: 10815
			// (get) Token: 0x0600D962 RID: 55650 RVA: 0x003B0594 File Offset: 0x003AE794
			// (set) Token: 0x0600D963 RID: 55651 RVA: 0x003B05A4 File Offset: 0x003AE7A4
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

			// Token: 0x17002A40 RID: 10816
			// (get) Token: 0x0600D964 RID: 55652 RVA: 0x003B05B4 File Offset: 0x003AE7B4
			// (set) Token: 0x0600D965 RID: 55653 RVA: 0x003B05C4 File Offset: 0x003AE7C4
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

			// Token: 0x17002A41 RID: 10817
			// (get) Token: 0x0600D966 RID: 55654 RVA: 0x003B05D4 File Offset: 0x003AE7D4
			// (set) Token: 0x0600D967 RID: 55655 RVA: 0x003B05E4 File Offset: 0x003AE7E4
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

			// Token: 0x17002A42 RID: 10818
			// (get) Token: 0x0600D968 RID: 55656 RVA: 0x003B05F4 File Offset: 0x003AE7F4
			// (set) Token: 0x0600D969 RID: 55657 RVA: 0x003B0604 File Offset: 0x003AE804
			public ConfigDataCooperateBattleLevelInfo m_cooperateBattleLevelInfo
			{
				get
				{
					return this.m_owner.m_cooperateBattleLevelInfo;
				}
				set
				{
					this.m_owner.m_cooperateBattleLevelInfo = value;
				}
			}

			// Token: 0x0600D96A RID: 55658 RVA: 0x003B0614 File Offset: 0x003AE814
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0600D96B RID: 55659 RVA: 0x003B0624 File Offset: 0x003AE824
			public void OnStartButtonClick()
			{
				this.m_owner.OnStartButtonClick();
			}

			// Token: 0x0600D96C RID: 55660 RVA: 0x003B0634 File Offset: 0x003AE834
			public void OnLockedButtonClick()
			{
				this.m_owner.OnLockedButtonClick();
			}

			// Token: 0x0400854D RID: 34125
			private CooperateBattleLevelListItemUIController m_owner;
		}
	}
}
