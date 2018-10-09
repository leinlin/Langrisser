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
using BlackJack.ProjectL.PlayerContext;
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x020009AA RID: 2474
	[HotFix]
	public class OpenServiceActivityUIController : UIControllerBase
	{
		// Token: 0x06008F0D RID: 36621 RVA: 0x0029AF58 File Offset: 0x00299158
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
			this.m_returnButton.onClick.AddListener(new UnityAction(this.OnReturnButtonClick));
			this.m_heroCharUIController = GameObjectUtility.AddControllerToGameObject<HeroCharUIController>(this.m_charGameObject);
			this.m_playerContext = (GameManager.Instance.PlayerContext as ProjectLPlayerContext);
			this.m_configDataLoader = (GameManager.Instance.ConfigDataLoader as IConfigDataLoader);
			base.gameObject.SetActive(true);
		}

		// Token: 0x06008F0E RID: 36622 RVA: 0x0029B024 File Offset: 0x00299224
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
			UIUtility.SetUIStateOpen(this.m_openServiceActivityStateCtrl, "Show", null, false, true);
		}

		// Token: 0x06008F0F RID: 36623 RVA: 0x0029B098 File Offset: 0x00299298
		public void UpdateViewInOpenServiceActivity()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateViewInOpenServiceActivity_hotfix != null)
			{
				this.m_UpdateViewInOpenServiceActivity_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataHeroInfo configDataHeroInfo = this.m_configDataLoader.GetConfigDataHeroInfo(14);
			if (this.m_heroCharUIController.GetCharImageInfo() != configDataHeroInfo.GetCharImageInfo(configDataHeroInfo.Star))
			{
				this.m_heroCharUIController.CreateGraphic(configDataHeroInfo);
				this.m_heroCharUIController.PlayAnimation("idle_Normal", true);
			}
			if (this.m_curSelectday == 0)
			{
				this.m_curSelectday = this.m_playerContext.GetDaysAfterCreation();
				if (this.m_curSelectday > 7)
				{
					this.m_curSelectday = 7;
				}
			}
			this.InitDayButtons();
			this.InitMissionPanel();
			this.InitIntegralPanel();
		}

		// Token: 0x06008F10 RID: 36624 RVA: 0x0029B180 File Offset: 0x00299380
		private void InitDayButtons()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitDayButtons_hotfix != null)
			{
				this.m_InitDayButtons_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Transform transform = this.m_daysButtonContent.transform;
			for (int i = 0; i < transform.childCount; i++)
			{
				Transform child = transform.GetChild(i);
				DayButtonUIController dayButtonUIController = child.GetComponent<DayButtonUIController>();
				if (dayButtonUIController == null)
				{
					dayButtonUIController = GameObjectUtility.AddControllerToGameObject<DayButtonUIController>(child.gameObject);
					dayButtonUIController.EventOnDayButtonClick += this.OnDayButtonClick;
				}
				dayButtonUIController.InitDayButtonInfo(i + 1);
				if (this.m_curSelectday == i + 1)
				{
					this.m_curSelectDayButtonCtrl = dayButtonUIController;
					dayButtonUIController.ShowSelectFrame(true);
				}
				else
				{
					dayButtonUIController.ShowSelectFrame(false);
				}
			}
		}

		// Token: 0x06008F11 RID: 36625 RVA: 0x0029B270 File Offset: 0x00299470
		private void OnDayButtonClick(DayButtonUIController ctrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnDayButtonClickDayButtonUIController_hotfix != null)
			{
				this.m_OnDayButtonClickDayButtonUIController_hotfix.call(new object[]
				{
					this,
					ctrl
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_curSelectDayButtonCtrl != null)
			{
				this.m_curSelectDayButtonCtrl.ShowSelectFrame(false);
			}
			this.m_curSelectDayButtonCtrl = ctrl;
			ctrl.ShowSelectFrame(true);
			this.m_curSelectday = ctrl.Day;
			this.InitMissionPanel();
		}

		// Token: 0x06008F12 RID: 36626 RVA: 0x0029B320 File Offset: 0x00299520
		private void InitMissionPanel()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitMissionPanel_hotfix != null)
			{
				this.m_InitMissionPanel_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<int> list = new List<int>();
			Dictionary<int, List<int>> noviceMissions = this.m_playerContext.GetNoviceMissions();
			if (!noviceMissions.ContainsKey(this.m_curSelectday))
			{
				return;
			}
			list.AddRange(noviceMissions[this.m_curSelectday]);
			List<Mission> noviceProcessingMissions = this.m_playerContext.GetNoviceProcessingMissions();
			List<Mission> finishedAndGetRewardNoviceMissions = this.m_playerContext.GetFinishedAndGetRewardNoviceMissions();
			List<Mission> list2 = new List<Mission>();
			foreach (Mission mission in noviceProcessingMissions)
			{
				if (list.Contains(mission.MissionId))
				{
					if (this.m_playerContext.CanGetMissionRewarding(mission))
					{
						list2.Insert(0, mission);
					}
					else
					{
						list2.Add(mission);
					}
				}
			}
			int count = list2.Count;
			foreach (Mission mission2 in finishedAndGetRewardNoviceMissions)
			{
				if (list.Contains(mission2.MissionId))
				{
					list2.Add(mission2);
				}
			}
			Transform transform = this.m_missionsScrollViewContent.transform;
			UIUtility.SetGameObjectChildrenActiveCount(this.m_missionsScrollViewContent, list2.Count);
			for (int i = 0; i < list2.Count; i++)
			{
				OpenServiceMissonUIController openServiceMissonUIController;
				if (i < transform.childCount)
				{
					Transform child = transform.GetChild(i);
					openServiceMissonUIController = child.GetComponent<OpenServiceMissonUIController>();
					if (openServiceMissonUIController == null)
					{
						openServiceMissonUIController = GameObjectUtility.AddControllerToGameObject<OpenServiceMissonUIController>(child.gameObject);
						openServiceMissonUIController.EventOnGotoButtonClick += this.OnMissionGotoButtonClick;
						openServiceMissonUIController.EventOnGetButtonClick += this.OnMissionGetButtonClick;
					}
				}
				else
				{
					GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.m_missonItemPrefab);
					openServiceMissonUIController = GameObjectUtility.AddControllerToGameObject<OpenServiceMissonUIController>(gameObject);
					gameObject.transform.SetParent(this.m_missionsScrollViewContent.transform, false);
					openServiceMissonUIController.EventOnGotoButtonClick += this.OnMissionGotoButtonClick;
					openServiceMissonUIController.EventOnGetButtonClick += this.OnMissionGetButtonClick;
				}
				openServiceMissonUIController.InitOpenServiceMissonInfo(list2[i], i >= count);
			}
			this.m_missionsScrollRect.normalizedPosition = Vector2.one;
		}

		// Token: 0x06008F13 RID: 36627 RVA: 0x0029B5E0 File Offset: 0x002997E0
		private void OnMissionGotoButtonClick(GetPathData pathInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnMissionGotoButtonClickGetPathData_hotfix != null)
			{
				this.m_OnMissionGotoButtonClickGetPathData_hotfix.call(new object[]
				{
					this,
					pathInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnMissionGoto != null)
			{
				this.EventOnMissionGoto(pathInfo);
			}
		}

		// Token: 0x06008F14 RID: 36628 RVA: 0x0029B668 File Offset: 0x00299868
		private void OnMissionGetButtonClick(OpenServiceMissonUIController ctrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnMissionGetButtonClickOpenServiceMissonUIController_hotfix != null)
			{
				this.m_OnMissionGetButtonClickOpenServiceMissonUIController_hotfix.call(new object[]
				{
					this,
					ctrl
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnMissionGet != null)
			{
				this.EventOnMissionGet(ctrl);
			}
		}

		// Token: 0x06008F15 RID: 36629 RVA: 0x0029B6F0 File Offset: 0x002998F0
		private void InitIntegralPanel()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitIntegralPanel_hotfix != null)
			{
				this.m_InitIntegralPanel_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<ConfigDataNoviceRewardInfo> novicePointsRewardsConfig = this.m_playerContext.GetNovicePointsRewardsConfig();
			Transform transform = this.m_integralContentGroup.transform;
			for (int i = 0; i < transform.childCount; i++)
			{
				Transform child = transform.GetChild(i);
				IntegralGoodsUIController integralGoodsUIController = child.GetComponent<IntegralGoodsUIController>();
				if (integralGoodsUIController == null)
				{
					integralGoodsUIController = GameObjectUtility.AddControllerToGameObject<IntegralGoodsUIController>(child.gameObject);
					integralGoodsUIController.EventOnIntegralGoodsClick += this.OnIntegralGoodsClick;
				}
				if (i < novicePointsRewardsConfig.Count)
				{
					integralGoodsUIController.InitIntegralGoodsInfo(novicePointsRewardsConfig[i], i);
				}
			}
			this.m_integralGroupCountValueText.text = this.m_playerContext.GetNoviceMissionPoints().ToString();
		}

		// Token: 0x06008F16 RID: 36630 RVA: 0x0029B7FC File Offset: 0x002999FC
		private void OnIntegralGoodsClick(IntegralGoodsUIController ctrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnIntegralGoodsClickIntegralGoodsUIController_hotfix != null)
			{
				this.m_OnIntegralGoodsClickIntegralGoodsUIController_hotfix.call(new object[]
				{
					this,
					ctrl
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnIntegralGoodsClick != null)
			{
				this.EventOnIntegralGoodsClick(ctrl);
			}
		}

		// Token: 0x06008F17 RID: 36631 RVA: 0x0029B884 File Offset: 0x00299A84
		public void SetResidueTime(TimeSpan ts)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetResidueTimeTimeSpan_hotfix != null)
			{
				this.m_SetResidueTimeTimeSpan_hotfix.call(new object[]
				{
					this,
					ts
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (ts.Days > 0)
			{
				this.m_residueTimeValueText.text = ts.Days + this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Time_Day);
			}
			else
			{
				this.m_residueTimeValueText.text = ts.Hours + this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Time_Hour);
			}
		}

		// Token: 0x06008F18 RID: 36632 RVA: 0x0029B960 File Offset: 0x00299B60
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
			if (this.EventOnReturn != null)
			{
				this.EventOnReturn();
			}
		}

		// Token: 0x1400018B RID: 395
		// (add) Token: 0x06008F19 RID: 36633 RVA: 0x0029B9D8 File Offset: 0x00299BD8
		// (remove) Token: 0x06008F1A RID: 36634 RVA: 0x0029BA74 File Offset: 0x00299C74
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

		// Token: 0x1400018C RID: 396
		// (add) Token: 0x06008F1B RID: 36635 RVA: 0x0029BB10 File Offset: 0x00299D10
		// (remove) Token: 0x06008F1C RID: 36636 RVA: 0x0029BBAC File Offset: 0x00299DAC
		public event Action<GetPathData> EventOnMissionGoto
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnMissionGotoAction`1_hotfix != null)
				{
					this.m_add_EventOnMissionGotoAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<GetPathData> action = this.EventOnMissionGoto;
				Action<GetPathData> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<GetPathData>>(ref this.EventOnMissionGoto, (Action<GetPathData>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnMissionGotoAction`1_hotfix != null)
				{
					this.m_remove_EventOnMissionGotoAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<GetPathData> action = this.EventOnMissionGoto;
				Action<GetPathData> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<GetPathData>>(ref this.EventOnMissionGoto, (Action<GetPathData>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1400018D RID: 397
		// (add) Token: 0x06008F1D RID: 36637 RVA: 0x0029BC48 File Offset: 0x00299E48
		// (remove) Token: 0x06008F1E RID: 36638 RVA: 0x0029BCE4 File Offset: 0x00299EE4
		public event Action<OpenServiceMissonUIController> EventOnMissionGet
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnMissionGetAction`1_hotfix != null)
				{
					this.m_add_EventOnMissionGetAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<OpenServiceMissonUIController> action = this.EventOnMissionGet;
				Action<OpenServiceMissonUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<OpenServiceMissonUIController>>(ref this.EventOnMissionGet, (Action<OpenServiceMissonUIController>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnMissionGetAction`1_hotfix != null)
				{
					this.m_remove_EventOnMissionGetAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<OpenServiceMissonUIController> action = this.EventOnMissionGet;
				Action<OpenServiceMissonUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<OpenServiceMissonUIController>>(ref this.EventOnMissionGet, (Action<OpenServiceMissonUIController>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1400018E RID: 398
		// (add) Token: 0x06008F1F RID: 36639 RVA: 0x0029BD80 File Offset: 0x00299F80
		// (remove) Token: 0x06008F20 RID: 36640 RVA: 0x0029BE1C File Offset: 0x0029A01C
		public event Action<IntegralGoodsUIController> EventOnIntegralGoodsClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnIntegralGoodsClickAction`1_hotfix != null)
				{
					this.m_add_EventOnIntegralGoodsClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<IntegralGoodsUIController> action = this.EventOnIntegralGoodsClick;
				Action<IntegralGoodsUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<IntegralGoodsUIController>>(ref this.EventOnIntegralGoodsClick, (Action<IntegralGoodsUIController>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnIntegralGoodsClickAction`1_hotfix != null)
				{
					this.m_remove_EventOnIntegralGoodsClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<IntegralGoodsUIController> action = this.EventOnIntegralGoodsClick;
				Action<IntegralGoodsUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<IntegralGoodsUIController>>(ref this.EventOnIntegralGoodsClick, (Action<IntegralGoodsUIController>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17001DE0 RID: 7648
		// (get) Token: 0x06008F21 RID: 36641 RVA: 0x0029BEB8 File Offset: 0x0029A0B8
		// (set) Token: 0x06008F22 RID: 36642 RVA: 0x0029BED8 File Offset: 0x0029A0D8
		[DoNotToLua]
		public new OpenServiceActivityUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new OpenServiceActivityUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06008F23 RID: 36643 RVA: 0x0029BEE4 File Offset: 0x0029A0E4
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x06008F24 RID: 36644 RVA: 0x0029BEF0 File Offset: 0x0029A0F0
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x06008F25 RID: 36645 RVA: 0x0029BEF8 File Offset: 0x0029A0F8
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x06008F26 RID: 36646 RVA: 0x0029BF00 File Offset: 0x0029A100
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x06008F27 RID: 36647 RVA: 0x0029BF14 File Offset: 0x0029A114
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x06008F28 RID: 36648 RVA: 0x0029BF1C File Offset: 0x0029A11C
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x06008F29 RID: 36649 RVA: 0x0029BF28 File Offset: 0x0029A128
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x06008F2A RID: 36650 RVA: 0x0029BF34 File Offset: 0x0029A134
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x06008F2B RID: 36651 RVA: 0x0029BF40 File Offset: 0x0029A140
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x06008F2C RID: 36652 RVA: 0x0029BF4C File Offset: 0x0029A14C
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x06008F2D RID: 36653 RVA: 0x0029BF58 File Offset: 0x0029A158
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x06008F2E RID: 36654 RVA: 0x0029BF64 File Offset: 0x0029A164
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x06008F2F RID: 36655 RVA: 0x0029BF70 File Offset: 0x0029A170
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x06008F30 RID: 36656 RVA: 0x0029BF7C File Offset: 0x0029A17C
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x06008F31 RID: 36657 RVA: 0x0029BF88 File Offset: 0x0029A188
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x06008F32 RID: 36658 RVA: 0x0029BF90 File Offset: 0x0029A190
		private void __callDele_EventOnReturn()
		{
			Action eventOnReturn = this.EventOnReturn;
			if (eventOnReturn != null)
			{
				eventOnReturn();
			}
		}

		// Token: 0x06008F33 RID: 36659 RVA: 0x0029BFB0 File Offset: 0x0029A1B0
		private void __clearDele_EventOnReturn()
		{
			this.EventOnReturn = null;
		}

		// Token: 0x06008F34 RID: 36660 RVA: 0x0029BFBC File Offset: 0x0029A1BC
		private void __callDele_EventOnMissionGoto(GetPathData obj)
		{
			Action<GetPathData> eventOnMissionGoto = this.EventOnMissionGoto;
			if (eventOnMissionGoto != null)
			{
				eventOnMissionGoto(obj);
			}
		}

		// Token: 0x06008F35 RID: 36661 RVA: 0x0029BFE0 File Offset: 0x0029A1E0
		private void __clearDele_EventOnMissionGoto(GetPathData obj)
		{
			this.EventOnMissionGoto = null;
		}

		// Token: 0x06008F36 RID: 36662 RVA: 0x0029BFEC File Offset: 0x0029A1EC
		private void __callDele_EventOnMissionGet(OpenServiceMissonUIController obj)
		{
			Action<OpenServiceMissonUIController> eventOnMissionGet = this.EventOnMissionGet;
			if (eventOnMissionGet != null)
			{
				eventOnMissionGet(obj);
			}
		}

		// Token: 0x06008F37 RID: 36663 RVA: 0x0029C010 File Offset: 0x0029A210
		private void __clearDele_EventOnMissionGet(OpenServiceMissonUIController obj)
		{
			this.EventOnMissionGet = null;
		}

		// Token: 0x06008F38 RID: 36664 RVA: 0x0029C01C File Offset: 0x0029A21C
		private void __callDele_EventOnIntegralGoodsClick(IntegralGoodsUIController obj)
		{
			Action<IntegralGoodsUIController> eventOnIntegralGoodsClick = this.EventOnIntegralGoodsClick;
			if (eventOnIntegralGoodsClick != null)
			{
				eventOnIntegralGoodsClick(obj);
			}
		}

		// Token: 0x06008F39 RID: 36665 RVA: 0x0029C040 File Offset: 0x0029A240
		private void __clearDele_EventOnIntegralGoodsClick(IntegralGoodsUIController obj)
		{
			this.EventOnIntegralGoodsClick = null;
		}

		// Token: 0x06008F3A RID: 36666 RVA: 0x0029C04C File Offset: 0x0029A24C
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
					this.m_UpdateViewInOpenServiceActivity_hotfix = (luaObj.RawGet("UpdateViewInOpenServiceActivity") as LuaFunction);
					this.m_InitDayButtons_hotfix = (luaObj.RawGet("InitDayButtons") as LuaFunction);
					this.m_OnDayButtonClickDayButtonUIController_hotfix = (luaObj.RawGet("OnDayButtonClick") as LuaFunction);
					this.m_InitMissionPanel_hotfix = (luaObj.RawGet("InitMissionPanel") as LuaFunction);
					this.m_OnMissionGotoButtonClickGetPathData_hotfix = (luaObj.RawGet("OnMissionGotoButtonClick") as LuaFunction);
					this.m_OnMissionGetButtonClickOpenServiceMissonUIController_hotfix = (luaObj.RawGet("OnMissionGetButtonClick") as LuaFunction);
					this.m_InitIntegralPanel_hotfix = (luaObj.RawGet("InitIntegralPanel") as LuaFunction);
					this.m_OnIntegralGoodsClickIntegralGoodsUIController_hotfix = (luaObj.RawGet("OnIntegralGoodsClick") as LuaFunction);
					this.m_SetResidueTimeTimeSpan_hotfix = (luaObj.RawGet("SetResidueTime") as LuaFunction);
					this.m_OnReturnButtonClick_hotfix = (luaObj.RawGet("OnReturnButtonClick") as LuaFunction);
					this.m_add_EventOnReturnAction_hotfix = (luaObj.RawGet("add_EventOnReturn") as LuaFunction);
					this.m_remove_EventOnReturnAction_hotfix = (luaObj.RawGet("remove_EventOnReturn") as LuaFunction);
					this.m_add_EventOnMissionGotoAction`1_hotfix = (luaObj.RawGet("add_EventOnMissionGoto") as LuaFunction);
					this.m_remove_EventOnMissionGotoAction`1_hotfix = (luaObj.RawGet("remove_EventOnMissionGoto") as LuaFunction);
					this.m_add_EventOnMissionGetAction`1_hotfix = (luaObj.RawGet("add_EventOnMissionGet") as LuaFunction);
					this.m_remove_EventOnMissionGetAction`1_hotfix = (luaObj.RawGet("remove_EventOnMissionGet") as LuaFunction);
					this.m_add_EventOnIntegralGoodsClickAction`1_hotfix = (luaObj.RawGet("add_EventOnIntegralGoodsClick") as LuaFunction);
					this.m_remove_EventOnIntegralGoodsClickAction`1_hotfix = (luaObj.RawGet("remove_EventOnIntegralGoodsClick") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06008F3B RID: 36667 RVA: 0x0029C2F4 File Offset: 0x0029A4F4
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(OpenServiceActivityUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400651F RID: 25887
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_openServiceActivityStateCtrl;

		// Token: 0x04006520 RID: 25888
		[AutoBind("./ReturnButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_returnButton;

		// Token: 0x04006521 RID: 25889
		[AutoBind("./CharGroup", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_charGameObject;

		// Token: 0x04006522 RID: 25890
		[AutoBind("./Detail/TitleToggleGroup/Content", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_daysButtonContent;

		// Token: 0x04006523 RID: 25891
		[AutoBind("./Detail/QuestGroup/ScrollView", AutoBindAttribute.InitState.NotInit, false)]
		private ScrollRect m_missionsScrollRect;

		// Token: 0x04006524 RID: 25892
		[AutoBind("./Detail/QuestGroup/ScrollView/Viewport/Content", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_missionsScrollViewContent;

		// Token: 0x04006525 RID: 25893
		[AutoBind("./Prefab/MissonItem", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_missonItemPrefab;

		// Token: 0x04006526 RID: 25894
		[AutoBind("./Detail/UnderCountGroup/CountGroup", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_integralContentGroup;

		// Token: 0x04006527 RID: 25895
		[AutoBind("./Detail/UnderCountGroup/NowCountGroup/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_integralGroupCountValueText;

		// Token: 0x04006528 RID: 25896
		[AutoBind("./Detail/ResidueTimeGroup/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_residueTimeValueText;

		// Token: 0x04006529 RID: 25897
		private ProjectLPlayerContext m_playerContext;

		// Token: 0x0400652A RID: 25898
		private IConfigDataLoader m_configDataLoader;

		// Token: 0x0400652B RID: 25899
		private int m_curSelectday;

		// Token: 0x0400652C RID: 25900
		private HeroCharUIController m_heroCharUIController;

		// Token: 0x0400652D RID: 25901
		private DayButtonUIController m_curSelectDayButtonCtrl;

		// Token: 0x0400652E RID: 25902
		[DoNotToLua]
		private OpenServiceActivityUIController.LuaExportHelper luaExportHelper;

		// Token: 0x0400652F RID: 25903
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04006530 RID: 25904
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04006531 RID: 25905
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x04006532 RID: 25906
		private LuaFunction m_Open_hotfix;

		// Token: 0x04006533 RID: 25907
		private LuaFunction m_UpdateViewInOpenServiceActivity_hotfix;

		// Token: 0x04006534 RID: 25908
		private LuaFunction m_InitDayButtons_hotfix;

		// Token: 0x04006535 RID: 25909
		private LuaFunction m_OnDayButtonClickDayButtonUIController_hotfix;

		// Token: 0x04006536 RID: 25910
		private LuaFunction m_InitMissionPanel_hotfix;

		// Token: 0x04006537 RID: 25911
		private LuaFunction m_OnMissionGotoButtonClickGetPathData_hotfix;

		// Token: 0x04006538 RID: 25912
		private LuaFunction m_OnMissionGetButtonClickOpenServiceMissonUIController_hotfix;

		// Token: 0x04006539 RID: 25913
		private LuaFunction m_InitIntegralPanel_hotfix;

		// Token: 0x0400653A RID: 25914
		private LuaFunction m_OnIntegralGoodsClickIntegralGoodsUIController_hotfix;

		// Token: 0x0400653B RID: 25915
		private LuaFunction m_SetResidueTimeTimeSpan_hotfix;

		// Token: 0x0400653C RID: 25916
		private LuaFunction m_OnReturnButtonClick_hotfix;

		// Token: 0x0400653D RID: 25917
		private LuaFunction m_add_EventOnReturnAction_hotfix;

		// Token: 0x0400653E RID: 25918
		private LuaFunction m_remove_EventOnReturnAction_hotfix;

		// Token: 0x0400653F RID: 25919
		private LuaFunction m_add_EventOnMissionGotoAction;

		// Token: 0x04006540 RID: 25920
		private LuaFunction m_remove_EventOnMissionGotoAction;

		// Token: 0x04006541 RID: 25921
		private LuaFunction m_add_EventOnMissionGetAction;

		// Token: 0x04006542 RID: 25922
		private LuaFunction m_remove_EventOnMissionGetAction;

		// Token: 0x04006543 RID: 25923
		private LuaFunction m_add_EventOnIntegralGoodsClickAction;

		// Token: 0x04006544 RID: 25924
		private LuaFunction m_remove_EventOnIntegralGoodsClickAction;

		// Token: 0x020009AB RID: 2475
		public new class LuaExportHelper
		{
			// Token: 0x06008F3C RID: 36668 RVA: 0x0029C35C File Offset: 0x0029A55C
			public LuaExportHelper(OpenServiceActivityUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06008F3D RID: 36669 RVA: 0x0029C36C File Offset: 0x0029A56C
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x06008F3E RID: 36670 RVA: 0x0029C37C File Offset: 0x0029A57C
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x06008F3F RID: 36671 RVA: 0x0029C38C File Offset: 0x0029A58C
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x06008F40 RID: 36672 RVA: 0x0029C39C File Offset: 0x0029A59C
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x06008F41 RID: 36673 RVA: 0x0029C3B4 File Offset: 0x0029A5B4
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x06008F42 RID: 36674 RVA: 0x0029C3C4 File Offset: 0x0029A5C4
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x06008F43 RID: 36675 RVA: 0x0029C3D4 File Offset: 0x0029A5D4
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x06008F44 RID: 36676 RVA: 0x0029C3E4 File Offset: 0x0029A5E4
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x06008F45 RID: 36677 RVA: 0x0029C3F4 File Offset: 0x0029A5F4
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x06008F46 RID: 36678 RVA: 0x0029C404 File Offset: 0x0029A604
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x06008F47 RID: 36679 RVA: 0x0029C414 File Offset: 0x0029A614
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x06008F48 RID: 36680 RVA: 0x0029C424 File Offset: 0x0029A624
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x06008F49 RID: 36681 RVA: 0x0029C434 File Offset: 0x0029A634
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x06008F4A RID: 36682 RVA: 0x0029C444 File Offset: 0x0029A644
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x06008F4B RID: 36683 RVA: 0x0029C454 File Offset: 0x0029A654
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x06008F4C RID: 36684 RVA: 0x0029C464 File Offset: 0x0029A664
			public void __callDele_EventOnReturn()
			{
				this.m_owner.__callDele_EventOnReturn();
			}

			// Token: 0x06008F4D RID: 36685 RVA: 0x0029C474 File Offset: 0x0029A674
			public void __clearDele_EventOnReturn()
			{
				this.m_owner.__clearDele_EventOnReturn();
			}

			// Token: 0x06008F4E RID: 36686 RVA: 0x0029C484 File Offset: 0x0029A684
			public void __callDele_EventOnMissionGoto(GetPathData obj)
			{
				this.m_owner.__callDele_EventOnMissionGoto(obj);
			}

			// Token: 0x06008F4F RID: 36687 RVA: 0x0029C494 File Offset: 0x0029A694
			public void __clearDele_EventOnMissionGoto(GetPathData obj)
			{
				this.m_owner.__clearDele_EventOnMissionGoto(obj);
			}

			// Token: 0x06008F50 RID: 36688 RVA: 0x0029C4A4 File Offset: 0x0029A6A4
			public void __callDele_EventOnMissionGet(OpenServiceMissonUIController obj)
			{
				this.m_owner.__callDele_EventOnMissionGet(obj);
			}

			// Token: 0x06008F51 RID: 36689 RVA: 0x0029C4B4 File Offset: 0x0029A6B4
			public void __clearDele_EventOnMissionGet(OpenServiceMissonUIController obj)
			{
				this.m_owner.__clearDele_EventOnMissionGet(obj);
			}

			// Token: 0x06008F52 RID: 36690 RVA: 0x0029C4C4 File Offset: 0x0029A6C4
			public void __callDele_EventOnIntegralGoodsClick(IntegralGoodsUIController obj)
			{
				this.m_owner.__callDele_EventOnIntegralGoodsClick(obj);
			}

			// Token: 0x06008F53 RID: 36691 RVA: 0x0029C4D4 File Offset: 0x0029A6D4
			public void __clearDele_EventOnIntegralGoodsClick(IntegralGoodsUIController obj)
			{
				this.m_owner.__clearDele_EventOnIntegralGoodsClick(obj);
			}

			// Token: 0x17001DE1 RID: 7649
			// (get) Token: 0x06008F54 RID: 36692 RVA: 0x0029C4E4 File Offset: 0x0029A6E4
			// (set) Token: 0x06008F55 RID: 36693 RVA: 0x0029C4F4 File Offset: 0x0029A6F4
			public CommonUIStateController m_openServiceActivityStateCtrl
			{
				get
				{
					return this.m_owner.m_openServiceActivityStateCtrl;
				}
				set
				{
					this.m_owner.m_openServiceActivityStateCtrl = value;
				}
			}

			// Token: 0x17001DE2 RID: 7650
			// (get) Token: 0x06008F56 RID: 36694 RVA: 0x0029C504 File Offset: 0x0029A704
			// (set) Token: 0x06008F57 RID: 36695 RVA: 0x0029C514 File Offset: 0x0029A714
			public Button m_returnButton
			{
				get
				{
					return this.m_owner.m_returnButton;
				}
				set
				{
					this.m_owner.m_returnButton = value;
				}
			}

			// Token: 0x17001DE3 RID: 7651
			// (get) Token: 0x06008F58 RID: 36696 RVA: 0x0029C524 File Offset: 0x0029A724
			// (set) Token: 0x06008F59 RID: 36697 RVA: 0x0029C534 File Offset: 0x0029A734
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

			// Token: 0x17001DE4 RID: 7652
			// (get) Token: 0x06008F5A RID: 36698 RVA: 0x0029C544 File Offset: 0x0029A744
			// (set) Token: 0x06008F5B RID: 36699 RVA: 0x0029C554 File Offset: 0x0029A754
			public GameObject m_daysButtonContent
			{
				get
				{
					return this.m_owner.m_daysButtonContent;
				}
				set
				{
					this.m_owner.m_daysButtonContent = value;
				}
			}

			// Token: 0x17001DE5 RID: 7653
			// (get) Token: 0x06008F5C RID: 36700 RVA: 0x0029C564 File Offset: 0x0029A764
			// (set) Token: 0x06008F5D RID: 36701 RVA: 0x0029C574 File Offset: 0x0029A774
			public ScrollRect m_missionsScrollRect
			{
				get
				{
					return this.m_owner.m_missionsScrollRect;
				}
				set
				{
					this.m_owner.m_missionsScrollRect = value;
				}
			}

			// Token: 0x17001DE6 RID: 7654
			// (get) Token: 0x06008F5E RID: 36702 RVA: 0x0029C584 File Offset: 0x0029A784
			// (set) Token: 0x06008F5F RID: 36703 RVA: 0x0029C594 File Offset: 0x0029A794
			public GameObject m_missionsScrollViewContent
			{
				get
				{
					return this.m_owner.m_missionsScrollViewContent;
				}
				set
				{
					this.m_owner.m_missionsScrollViewContent = value;
				}
			}

			// Token: 0x17001DE7 RID: 7655
			// (get) Token: 0x06008F60 RID: 36704 RVA: 0x0029C5A4 File Offset: 0x0029A7A4
			// (set) Token: 0x06008F61 RID: 36705 RVA: 0x0029C5B4 File Offset: 0x0029A7B4
			public GameObject m_missonItemPrefab
			{
				get
				{
					return this.m_owner.m_missonItemPrefab;
				}
				set
				{
					this.m_owner.m_missonItemPrefab = value;
				}
			}

			// Token: 0x17001DE8 RID: 7656
			// (get) Token: 0x06008F62 RID: 36706 RVA: 0x0029C5C4 File Offset: 0x0029A7C4
			// (set) Token: 0x06008F63 RID: 36707 RVA: 0x0029C5D4 File Offset: 0x0029A7D4
			public GameObject m_integralContentGroup
			{
				get
				{
					return this.m_owner.m_integralContentGroup;
				}
				set
				{
					this.m_owner.m_integralContentGroup = value;
				}
			}

			// Token: 0x17001DE9 RID: 7657
			// (get) Token: 0x06008F64 RID: 36708 RVA: 0x0029C5E4 File Offset: 0x0029A7E4
			// (set) Token: 0x06008F65 RID: 36709 RVA: 0x0029C5F4 File Offset: 0x0029A7F4
			public Text m_integralGroupCountValueText
			{
				get
				{
					return this.m_owner.m_integralGroupCountValueText;
				}
				set
				{
					this.m_owner.m_integralGroupCountValueText = value;
				}
			}

			// Token: 0x17001DEA RID: 7658
			// (get) Token: 0x06008F66 RID: 36710 RVA: 0x0029C604 File Offset: 0x0029A804
			// (set) Token: 0x06008F67 RID: 36711 RVA: 0x0029C614 File Offset: 0x0029A814
			public Text m_residueTimeValueText
			{
				get
				{
					return this.m_owner.m_residueTimeValueText;
				}
				set
				{
					this.m_owner.m_residueTimeValueText = value;
				}
			}

			// Token: 0x17001DEB RID: 7659
			// (get) Token: 0x06008F68 RID: 36712 RVA: 0x0029C624 File Offset: 0x0029A824
			// (set) Token: 0x06008F69 RID: 36713 RVA: 0x0029C634 File Offset: 0x0029A834
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

			// Token: 0x17001DEC RID: 7660
			// (get) Token: 0x06008F6A RID: 36714 RVA: 0x0029C644 File Offset: 0x0029A844
			// (set) Token: 0x06008F6B RID: 36715 RVA: 0x0029C654 File Offset: 0x0029A854
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

			// Token: 0x17001DED RID: 7661
			// (get) Token: 0x06008F6C RID: 36716 RVA: 0x0029C664 File Offset: 0x0029A864
			// (set) Token: 0x06008F6D RID: 36717 RVA: 0x0029C674 File Offset: 0x0029A874
			public int m_curSelectday
			{
				get
				{
					return this.m_owner.m_curSelectday;
				}
				set
				{
					this.m_owner.m_curSelectday = value;
				}
			}

			// Token: 0x17001DEE RID: 7662
			// (get) Token: 0x06008F6E RID: 36718 RVA: 0x0029C684 File Offset: 0x0029A884
			// (set) Token: 0x06008F6F RID: 36719 RVA: 0x0029C694 File Offset: 0x0029A894
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

			// Token: 0x17001DEF RID: 7663
			// (get) Token: 0x06008F70 RID: 36720 RVA: 0x0029C6A4 File Offset: 0x0029A8A4
			// (set) Token: 0x06008F71 RID: 36721 RVA: 0x0029C6B4 File Offset: 0x0029A8B4
			public DayButtonUIController m_curSelectDayButtonCtrl
			{
				get
				{
					return this.m_owner.m_curSelectDayButtonCtrl;
				}
				set
				{
					this.m_owner.m_curSelectDayButtonCtrl = value;
				}
			}

			// Token: 0x06008F72 RID: 36722 RVA: 0x0029C6C4 File Offset: 0x0029A8C4
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x06008F73 RID: 36723 RVA: 0x0029C6D4 File Offset: 0x0029A8D4
			public void InitDayButtons()
			{
				this.m_owner.InitDayButtons();
			}

			// Token: 0x06008F74 RID: 36724 RVA: 0x0029C6E4 File Offset: 0x0029A8E4
			public void OnDayButtonClick(DayButtonUIController ctrl)
			{
				this.m_owner.OnDayButtonClick(ctrl);
			}

			// Token: 0x06008F75 RID: 36725 RVA: 0x0029C6F4 File Offset: 0x0029A8F4
			public void InitMissionPanel()
			{
				this.m_owner.InitMissionPanel();
			}

			// Token: 0x06008F76 RID: 36726 RVA: 0x0029C704 File Offset: 0x0029A904
			public void OnMissionGotoButtonClick(GetPathData pathInfo)
			{
				this.m_owner.OnMissionGotoButtonClick(pathInfo);
			}

			// Token: 0x06008F77 RID: 36727 RVA: 0x0029C714 File Offset: 0x0029A914
			public void OnMissionGetButtonClick(OpenServiceMissonUIController ctrl)
			{
				this.m_owner.OnMissionGetButtonClick(ctrl);
			}

			// Token: 0x06008F78 RID: 36728 RVA: 0x0029C724 File Offset: 0x0029A924
			public void InitIntegralPanel()
			{
				this.m_owner.InitIntegralPanel();
			}

			// Token: 0x06008F79 RID: 36729 RVA: 0x0029C734 File Offset: 0x0029A934
			public void OnIntegralGoodsClick(IntegralGoodsUIController ctrl)
			{
				this.m_owner.OnIntegralGoodsClick(ctrl);
			}

			// Token: 0x06008F7A RID: 36730 RVA: 0x0029C744 File Offset: 0x0029A944
			public void OnReturnButtonClick()
			{
				this.m_owner.OnReturnButtonClick();
			}

			// Token: 0x04006545 RID: 25925
			private OpenServiceActivityUIController m_owner;
		}
	}
}
