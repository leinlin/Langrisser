using System;
using System.Collections.Generic;
using System.Threading;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Misc;
using BlackJack.ProjectL.Scene;
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x0200101E RID: 4126
	[HotFix]
	public class WorldEventMissionUIController : UIControllerBase
	{
		// Token: 0x06014DE4 RID: 85476 RVA: 0x00549984 File Offset: 0x00547B84
		private WorldEventMissionUIController()
		{
		}

		// Token: 0x06014DE5 RID: 85477 RVA: 0x0054998C File Offset: 0x00547B8C
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
			this.m_backgroundButton.onClick.AddListener(new UnityAction(this.OnBackgroundButtonClick));
			this.m_enterButton.onClick.AddListener(new UnityAction(this.OnEnterButtonClick));
			this.m_cancelButton.onClick.AddListener(new UnityAction(this.OnCancelButtonClick));
		}

		// Token: 0x06014DE6 RID: 85478 RVA: 0x00549A48 File Offset: 0x00547C48
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
			UIUtility.SetUIStateOpen(this.m_uiStateController, "Show", null, false, true);
		}

		// Token: 0x06014DE7 RID: 85479 RVA: 0x00549ABC File Offset: 0x00547CBC
		public void SetEvent(ConfigDataEventInfo eventInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetEventConfigDataEventInfo_hotfix != null)
			{
				this.m_SetEventConfigDataEventInfo_hotfix.call(new object[]
				{
					this,
					eventInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (eventInfo == null)
			{
				return;
			}
			this.m_nameText.text = eventInfo.Name;
			this.m_descText.text = eventInfo.Desc;
			this.m_monsterLevelText.text = eventInfo.MonsterLevel.ToString();
			this.m_energyText.text = eventInfo.EnergySuccess.ToString();
			this.m_dangerUIStateController.SetToUIState((!eventInfo.IsDanger) ? "Normal" : "Danger", false, true);
			this.m_missionUIStateController.SetToUIState((!eventInfo.IsDanger) ? "Normal" : "Danger", false, true);
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			ConfigDataCharImageInfo configDataCharImageInfo = configDataLoader.GetConfigDataCharImageInfo(eventInfo.CharImage_ID);
			this.CreateCharImage(configDataCharImageInfo);
		}

		// Token: 0x06014DE8 RID: 85480 RVA: 0x00549C08 File Offset: 0x00547E08
		public void SetRewards(List<Goods> goodsList)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetRewardsList`1_hotfix != null)
			{
				this.m_SetRewardsList`1_hotfix.call(new object[]
				{
					this,
					goodsList
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GameObjectUtility.DestroyChildren(this.m_rewardGoodsGameObject);
			if (goodsList == null)
			{
				return;
			}
			GameObject assetInContainer = base.GetAssetInContainer<GameObject>("RewardGoods");
			RewardGoodsUIController.CreateRewardGoodsList(goodsList, this.m_rewardGoodsGameObject.transform, assetInContainer, null, true, 0, true);
		}

		// Token: 0x06014DE9 RID: 85481 RVA: 0x00549CAC File Offset: 0x00547EAC
		private void CreateCharImage(ConfigDataCharImageInfo charImageInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CreateCharImageConfigDataCharImageInfo_hotfix != null)
			{
				this.m_CreateCharImageConfigDataCharImageInfo_hotfix.call(new object[]
				{
					this,
					charImageInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.DestroyCharImage();
			if (charImageInfo == null)
			{
				return;
			}
			if (!string.IsNullOrEmpty(charImageInfo.Spine))
			{
				this.m_spineGraphic = new UISpineGraphic();
				this.m_spineGraphic.Create(charImageInfo.Spine);
				this.m_spineGraphic.SetParent(this.m_charGameObject);
				this.m_spineGraphic.PlayAnimation("idle_Normal", true, 0);
				this.m_spineGraphic.ForceUpdate();
			}
			else if (!string.IsNullOrEmpty(charImageInfo.Image))
			{
				this.m_charImage.sprite = AssetUtility.Instance.GetSprite(charImageInfo.Image);
				this.m_charImage.gameObject.SetActive(this.m_charImage.sprite != null);
			}
		}

		// Token: 0x06014DEA RID: 85482 RVA: 0x00549DD8 File Offset: 0x00547FD8
		private void DestroyCharImage()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DestroyCharImage_hotfix != null)
			{
				this.m_DestroyCharImage_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_spineGraphic != null)
			{
				this.m_spineGraphic.Destroy();
				this.m_spineGraphic = null;
			}
			this.m_charImage.gameObject.SetActive(false);
		}

		// Token: 0x06014DEB RID: 85483 RVA: 0x00549E68 File Offset: 0x00548068
		private void OnBackgroundButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnBackgroundButtonClick_hotfix != null)
			{
				this.m_OnBackgroundButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.OnCancelButtonClick();
		}

		// Token: 0x06014DEC RID: 85484 RVA: 0x00549ED0 File Offset: 0x005480D0
		private void OnEnterButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnEnterButtonClick_hotfix != null)
			{
				this.m_OnEnterButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIController.Instance.StartFadeOut(delegate
			{
				if (this.EventOnEnterMission != null)
				{
					this.EventOnEnterMission();
				}
			}, FadeStyle.Black, -1f);
		}

		// Token: 0x06014DED RID: 85485 RVA: 0x00549F4C File Offset: 0x0054814C
		private void OnCancelButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnCancelButtonClick_hotfix != null)
			{
				this.m_OnCancelButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetUIStateClose(this.m_uiStateController, "Close", delegate
			{
				if (this.EventOnClose != null)
				{
					this.EventOnClose();
				}
			}, true, true);
		}

		// Token: 0x14000499 RID: 1177
		// (add) Token: 0x06014DEE RID: 85486 RVA: 0x00549FCC File Offset: 0x005481CC
		// (remove) Token: 0x06014DEF RID: 85487 RVA: 0x0054A068 File Offset: 0x00548268
		public event Action EventOnEnterMission
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnEnterMissionAction_hotfix != null)
				{
					this.m_add_EventOnEnterMissionAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnEnterMission;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnEnterMission, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnEnterMissionAction_hotfix != null)
				{
					this.m_remove_EventOnEnterMissionAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnEnterMission;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnEnterMission, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1400049A RID: 1178
		// (add) Token: 0x06014DF0 RID: 85488 RVA: 0x0054A104 File Offset: 0x00548304
		// (remove) Token: 0x06014DF1 RID: 85489 RVA: 0x0054A1A0 File Offset: 0x005483A0
		public event Action EventOnClose
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnCloseAction_hotfix != null)
				{
					this.m_add_EventOnCloseAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnClose;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnClose, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnCloseAction_hotfix != null)
				{
					this.m_remove_EventOnCloseAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnClose;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnClose, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17003D92 RID: 15762
		// (get) Token: 0x06014DF2 RID: 85490 RVA: 0x0054A23C File Offset: 0x0054843C
		// (set) Token: 0x06014DF3 RID: 85491 RVA: 0x0054A25C File Offset: 0x0054845C
		[DoNotToLua]
		public new WorldEventMissionUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new WorldEventMissionUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06014DF4 RID: 85492 RVA: 0x0054A268 File Offset: 0x00548468
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x06014DF5 RID: 85493 RVA: 0x0054A274 File Offset: 0x00548474
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x06014DF6 RID: 85494 RVA: 0x0054A27C File Offset: 0x0054847C
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x06014DF7 RID: 85495 RVA: 0x0054A284 File Offset: 0x00548484
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x06014DF8 RID: 85496 RVA: 0x0054A298 File Offset: 0x00548498
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x06014DF9 RID: 85497 RVA: 0x0054A2A0 File Offset: 0x005484A0
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x06014DFA RID: 85498 RVA: 0x0054A2AC File Offset: 0x005484AC
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x06014DFB RID: 85499 RVA: 0x0054A2B8 File Offset: 0x005484B8
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x06014DFC RID: 85500 RVA: 0x0054A2C4 File Offset: 0x005484C4
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x06014DFD RID: 85501 RVA: 0x0054A2D0 File Offset: 0x005484D0
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x06014DFE RID: 85502 RVA: 0x0054A2DC File Offset: 0x005484DC
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x06014DFF RID: 85503 RVA: 0x0054A2E8 File Offset: 0x005484E8
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x06014E00 RID: 85504 RVA: 0x0054A2F4 File Offset: 0x005484F4
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x06014E01 RID: 85505 RVA: 0x0054A300 File Offset: 0x00548500
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x06014E02 RID: 85506 RVA: 0x0054A30C File Offset: 0x0054850C
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x06014E03 RID: 85507 RVA: 0x0054A314 File Offset: 0x00548514
		private void __callDele_EventOnEnterMission()
		{
			Action eventOnEnterMission = this.EventOnEnterMission;
			if (eventOnEnterMission != null)
			{
				eventOnEnterMission();
			}
		}

		// Token: 0x06014E04 RID: 85508 RVA: 0x0054A334 File Offset: 0x00548534
		private void __clearDele_EventOnEnterMission()
		{
			this.EventOnEnterMission = null;
		}

		// Token: 0x06014E05 RID: 85509 RVA: 0x0054A340 File Offset: 0x00548540
		private void __callDele_EventOnClose()
		{
			Action eventOnClose = this.EventOnClose;
			if (eventOnClose != null)
			{
				eventOnClose();
			}
		}

		// Token: 0x06014E06 RID: 85510 RVA: 0x0054A360 File Offset: 0x00548560
		private void __clearDele_EventOnClose()
		{
			this.EventOnClose = null;
		}

		// Token: 0x06014E09 RID: 85513 RVA: 0x0054A39C File Offset: 0x0054859C
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
					this.m_Open_hotfix = (luaObj.RawGet("Open") as LuaFunction);
					this.m_SetEventConfigDataEventInfo_hotfix = (luaObj.RawGet("SetEvent") as LuaFunction);
					this.m_SetRewardsList`1_hotfix = (luaObj.RawGet("SetRewards") as LuaFunction);
					this.m_CreateCharImageConfigDataCharImageInfo_hotfix = (luaObj.RawGet("CreateCharImage") as LuaFunction);
					this.m_DestroyCharImage_hotfix = (luaObj.RawGet("DestroyCharImage") as LuaFunction);
					this.m_OnBackgroundButtonClick_hotfix = (luaObj.RawGet("OnBackgroundButtonClick") as LuaFunction);
					this.m_OnEnterButtonClick_hotfix = (luaObj.RawGet("OnEnterButtonClick") as LuaFunction);
					this.m_OnCancelButtonClick_hotfix = (luaObj.RawGet("OnCancelButtonClick") as LuaFunction);
					this.m_add_EventOnEnterMissionAction_hotfix = (luaObj.RawGet("add_EventOnEnterMission") as LuaFunction);
					this.m_remove_EventOnEnterMissionAction_hotfix = (luaObj.RawGet("remove_EventOnEnterMission") as LuaFunction);
					this.m_add_EventOnCloseAction_hotfix = (luaObj.RawGet("add_EventOnClose") as LuaFunction);
					this.m_remove_EventOnCloseAction_hotfix = (luaObj.RawGet("remove_EventOnClose") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06014E0A RID: 85514 RVA: 0x0054A594 File Offset: 0x00548794
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(WorldEventMissionUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400B6A8 RID: 46760
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_uiStateController;

		// Token: 0x0400B6A9 RID: 46761
		[AutoBind("./DangerOrNormal", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_dangerUIStateController;

		// Token: 0x0400B6AA RID: 46762
		[AutoBind("./Mission/Name/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_nameText;

		// Token: 0x0400B6AB RID: 46763
		[AutoBind("./Mission/Desc/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_descText;

		// Token: 0x0400B6AC RID: 46764
		[AutoBind("./Mission/MonsterLevel/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_monsterLevelText;

		// Token: 0x0400B6AD RID: 46765
		[AutoBind("./Mission/Energy/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_energyText;

		// Token: 0x0400B6AE RID: 46766
		[AutoBind("./Mission/Reward/Goods", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_rewardGoodsGameObject;

		// Token: 0x0400B6AF RID: 46767
		[AutoBind("./BackgroundButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_backgroundButton;

		// Token: 0x0400B6B0 RID: 46768
		[AutoBind("./Mission/EnterButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_enterButton;

		// Token: 0x0400B6B1 RID: 46769
		[AutoBind("./Mission/CancelButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_cancelButton;

		// Token: 0x0400B6B2 RID: 46770
		[AutoBind("./Mission", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_missionUIStateController;

		// Token: 0x0400B6B3 RID: 46771
		[AutoBind("./Char/0", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_charGameObject;

		// Token: 0x0400B6B4 RID: 46772
		[AutoBind("./Char/0/Image", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_charImage;

		// Token: 0x0400B6B5 RID: 46773
		private UISpineGraphic m_spineGraphic;

		// Token: 0x0400B6B6 RID: 46774
		[DoNotToLua]
		private WorldEventMissionUIController.LuaExportHelper luaExportHelper;

		// Token: 0x0400B6B7 RID: 46775
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400B6B8 RID: 46776
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400B6B9 RID: 46777
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x0400B6BA RID: 46778
		private LuaFunction m_Open_hotfix;

		// Token: 0x0400B6BB RID: 46779
		private LuaFunction m_SetEventConfigDataEventInfo_hotfix;

		// Token: 0x0400B6BC RID: 46780
		private LuaFunction m_SetRewardsList;

		// Token: 0x0400B6BD RID: 46781
		private LuaFunction m_CreateCharImageConfigDataCharImageInfo_hotfix;

		// Token: 0x0400B6BE RID: 46782
		private LuaFunction m_DestroyCharImage_hotfix;

		// Token: 0x0400B6BF RID: 46783
		private LuaFunction m_OnBackgroundButtonClick_hotfix;

		// Token: 0x0400B6C0 RID: 46784
		private LuaFunction m_OnEnterButtonClick_hotfix;

		// Token: 0x0400B6C1 RID: 46785
		private LuaFunction m_OnCancelButtonClick_hotfix;

		// Token: 0x0400B6C2 RID: 46786
		private LuaFunction m_add_EventOnEnterMissionAction_hotfix;

		// Token: 0x0400B6C3 RID: 46787
		private LuaFunction m_remove_EventOnEnterMissionAction_hotfix;

		// Token: 0x0400B6C4 RID: 46788
		private LuaFunction m_add_EventOnCloseAction_hotfix;

		// Token: 0x0400B6C5 RID: 46789
		private LuaFunction m_remove_EventOnCloseAction_hotfix;

		// Token: 0x0200101F RID: 4127
		public new class LuaExportHelper
		{
			// Token: 0x06014E0B RID: 85515 RVA: 0x0054A5FC File Offset: 0x005487FC
			public LuaExportHelper(WorldEventMissionUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06014E0C RID: 85516 RVA: 0x0054A60C File Offset: 0x0054880C
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x06014E0D RID: 85517 RVA: 0x0054A61C File Offset: 0x0054881C
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x06014E0E RID: 85518 RVA: 0x0054A62C File Offset: 0x0054882C
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x06014E0F RID: 85519 RVA: 0x0054A63C File Offset: 0x0054883C
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x06014E10 RID: 85520 RVA: 0x0054A654 File Offset: 0x00548854
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x06014E11 RID: 85521 RVA: 0x0054A664 File Offset: 0x00548864
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x06014E12 RID: 85522 RVA: 0x0054A674 File Offset: 0x00548874
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x06014E13 RID: 85523 RVA: 0x0054A684 File Offset: 0x00548884
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x06014E14 RID: 85524 RVA: 0x0054A694 File Offset: 0x00548894
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x06014E15 RID: 85525 RVA: 0x0054A6A4 File Offset: 0x005488A4
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x06014E16 RID: 85526 RVA: 0x0054A6B4 File Offset: 0x005488B4
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x06014E17 RID: 85527 RVA: 0x0054A6C4 File Offset: 0x005488C4
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x06014E18 RID: 85528 RVA: 0x0054A6D4 File Offset: 0x005488D4
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x06014E19 RID: 85529 RVA: 0x0054A6E4 File Offset: 0x005488E4
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x06014E1A RID: 85530 RVA: 0x0054A6F4 File Offset: 0x005488F4
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x06014E1B RID: 85531 RVA: 0x0054A704 File Offset: 0x00548904
			public void __callDele_EventOnEnterMission()
			{
				this.m_owner.__callDele_EventOnEnterMission();
			}

			// Token: 0x06014E1C RID: 85532 RVA: 0x0054A714 File Offset: 0x00548914
			public void __clearDele_EventOnEnterMission()
			{
				this.m_owner.__clearDele_EventOnEnterMission();
			}

			// Token: 0x06014E1D RID: 85533 RVA: 0x0054A724 File Offset: 0x00548924
			public void __callDele_EventOnClose()
			{
				this.m_owner.__callDele_EventOnClose();
			}

			// Token: 0x06014E1E RID: 85534 RVA: 0x0054A734 File Offset: 0x00548934
			public void __clearDele_EventOnClose()
			{
				this.m_owner.__clearDele_EventOnClose();
			}

			// Token: 0x17003D93 RID: 15763
			// (get) Token: 0x06014E1F RID: 85535 RVA: 0x0054A744 File Offset: 0x00548944
			// (set) Token: 0x06014E20 RID: 85536 RVA: 0x0054A754 File Offset: 0x00548954
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

			// Token: 0x17003D94 RID: 15764
			// (get) Token: 0x06014E21 RID: 85537 RVA: 0x0054A764 File Offset: 0x00548964
			// (set) Token: 0x06014E22 RID: 85538 RVA: 0x0054A774 File Offset: 0x00548974
			public CommonUIStateController m_dangerUIStateController
			{
				get
				{
					return this.m_owner.m_dangerUIStateController;
				}
				set
				{
					this.m_owner.m_dangerUIStateController = value;
				}
			}

			// Token: 0x17003D95 RID: 15765
			// (get) Token: 0x06014E23 RID: 85539 RVA: 0x0054A784 File Offset: 0x00548984
			// (set) Token: 0x06014E24 RID: 85540 RVA: 0x0054A794 File Offset: 0x00548994
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

			// Token: 0x17003D96 RID: 15766
			// (get) Token: 0x06014E25 RID: 85541 RVA: 0x0054A7A4 File Offset: 0x005489A4
			// (set) Token: 0x06014E26 RID: 85542 RVA: 0x0054A7B4 File Offset: 0x005489B4
			public Text m_descText
			{
				get
				{
					return this.m_owner.m_descText;
				}
				set
				{
					this.m_owner.m_descText = value;
				}
			}

			// Token: 0x17003D97 RID: 15767
			// (get) Token: 0x06014E27 RID: 85543 RVA: 0x0054A7C4 File Offset: 0x005489C4
			// (set) Token: 0x06014E28 RID: 85544 RVA: 0x0054A7D4 File Offset: 0x005489D4
			public Text m_monsterLevelText
			{
				get
				{
					return this.m_owner.m_monsterLevelText;
				}
				set
				{
					this.m_owner.m_monsterLevelText = value;
				}
			}

			// Token: 0x17003D98 RID: 15768
			// (get) Token: 0x06014E29 RID: 85545 RVA: 0x0054A7E4 File Offset: 0x005489E4
			// (set) Token: 0x06014E2A RID: 85546 RVA: 0x0054A7F4 File Offset: 0x005489F4
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

			// Token: 0x17003D99 RID: 15769
			// (get) Token: 0x06014E2B RID: 85547 RVA: 0x0054A804 File Offset: 0x00548A04
			// (set) Token: 0x06014E2C RID: 85548 RVA: 0x0054A814 File Offset: 0x00548A14
			public GameObject m_rewardGoodsGameObject
			{
				get
				{
					return this.m_owner.m_rewardGoodsGameObject;
				}
				set
				{
					this.m_owner.m_rewardGoodsGameObject = value;
				}
			}

			// Token: 0x17003D9A RID: 15770
			// (get) Token: 0x06014E2D RID: 85549 RVA: 0x0054A824 File Offset: 0x00548A24
			// (set) Token: 0x06014E2E RID: 85550 RVA: 0x0054A834 File Offset: 0x00548A34
			public Button m_backgroundButton
			{
				get
				{
					return this.m_owner.m_backgroundButton;
				}
				set
				{
					this.m_owner.m_backgroundButton = value;
				}
			}

			// Token: 0x17003D9B RID: 15771
			// (get) Token: 0x06014E2F RID: 85551 RVA: 0x0054A844 File Offset: 0x00548A44
			// (set) Token: 0x06014E30 RID: 85552 RVA: 0x0054A854 File Offset: 0x00548A54
			public Button m_enterButton
			{
				get
				{
					return this.m_owner.m_enterButton;
				}
				set
				{
					this.m_owner.m_enterButton = value;
				}
			}

			// Token: 0x17003D9C RID: 15772
			// (get) Token: 0x06014E31 RID: 85553 RVA: 0x0054A864 File Offset: 0x00548A64
			// (set) Token: 0x06014E32 RID: 85554 RVA: 0x0054A874 File Offset: 0x00548A74
			public Button m_cancelButton
			{
				get
				{
					return this.m_owner.m_cancelButton;
				}
				set
				{
					this.m_owner.m_cancelButton = value;
				}
			}

			// Token: 0x17003D9D RID: 15773
			// (get) Token: 0x06014E33 RID: 85555 RVA: 0x0054A884 File Offset: 0x00548A84
			// (set) Token: 0x06014E34 RID: 85556 RVA: 0x0054A894 File Offset: 0x00548A94
			public CommonUIStateController m_missionUIStateController
			{
				get
				{
					return this.m_owner.m_missionUIStateController;
				}
				set
				{
					this.m_owner.m_missionUIStateController = value;
				}
			}

			// Token: 0x17003D9E RID: 15774
			// (get) Token: 0x06014E35 RID: 85557 RVA: 0x0054A8A4 File Offset: 0x00548AA4
			// (set) Token: 0x06014E36 RID: 85558 RVA: 0x0054A8B4 File Offset: 0x00548AB4
			public GameObject m_charGameObject
			{
				get
				{
					return this.m_owner.m_charGameObject;
				}
				set
				{
					this.m_owner.m_charGameObject = value;
				}
			}

			// Token: 0x17003D9F RID: 15775
			// (get) Token: 0x06014E37 RID: 85559 RVA: 0x0054A8C4 File Offset: 0x00548AC4
			// (set) Token: 0x06014E38 RID: 85560 RVA: 0x0054A8D4 File Offset: 0x00548AD4
			public Image m_charImage
			{
				get
				{
					return this.m_owner.m_charImage;
				}
				set
				{
					this.m_owner.m_charImage = value;
				}
			}

			// Token: 0x17003DA0 RID: 15776
			// (get) Token: 0x06014E39 RID: 85561 RVA: 0x0054A8E4 File Offset: 0x00548AE4
			// (set) Token: 0x06014E3A RID: 85562 RVA: 0x0054A8F4 File Offset: 0x00548AF4
			public UISpineGraphic m_spineGraphic
			{
				get
				{
					return this.m_owner.m_spineGraphic;
				}
				set
				{
					this.m_owner.m_spineGraphic = value;
				}
			}

			// Token: 0x06014E3B RID: 85563 RVA: 0x0054A904 File Offset: 0x00548B04
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x06014E3C RID: 85564 RVA: 0x0054A914 File Offset: 0x00548B14
			public void CreateCharImage(ConfigDataCharImageInfo charImageInfo)
			{
				this.m_owner.CreateCharImage(charImageInfo);
			}

			// Token: 0x06014E3D RID: 85565 RVA: 0x0054A924 File Offset: 0x00548B24
			public void DestroyCharImage()
			{
				this.m_owner.DestroyCharImage();
			}

			// Token: 0x06014E3E RID: 85566 RVA: 0x0054A934 File Offset: 0x00548B34
			public void OnBackgroundButtonClick()
			{
				this.m_owner.OnBackgroundButtonClick();
			}

			// Token: 0x06014E3F RID: 85567 RVA: 0x0054A944 File Offset: 0x00548B44
			public void OnEnterButtonClick()
			{
				this.m_owner.OnEnterButtonClick();
			}

			// Token: 0x06014E40 RID: 85568 RVA: 0x0054A954 File Offset: 0x00548B54
			public void OnCancelButtonClick()
			{
				this.m_owner.OnCancelButtonClick();
			}

			// Token: 0x0400B6C6 RID: 46790
			private WorldEventMissionUIController m_owner;
		}
	}
}
