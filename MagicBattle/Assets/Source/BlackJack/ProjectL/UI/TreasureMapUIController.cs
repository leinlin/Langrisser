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
	// Token: 0x02000FCB RID: 4043
	[HotFix]
	public class TreasureMapUIController : UIControllerBase
	{
		// Token: 0x06014369 RID: 82793 RVA: 0x00524BE8 File Offset: 0x00522DE8
		private TreasureMapUIController()
		{
		}

		// Token: 0x0601436A RID: 82794 RVA: 0x00524C08 File Offset: 0x00522E08
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
			this.m_helpButton.onClick.AddListener(new UnityAction(this.OnHelpButtonClick));
			this.m_addTicketButton.onClick.AddListener(new UnityAction(this.OnAddTicketButtonClick));
			this.m_actors[0] = new TreasureMapBackgroundActor();
			this.m_actors[0].Create("Spine/General/Goblin_ABS/Goblin_3_Prefab.prefab", this.m_char0GameObject);
			this.m_actors[1] = new TreasureMapBackgroundActor();
			this.m_actors[1].Create("Spine/General/Goblin_ABS/Goblin_4_Prefab.prefab", this.m_char1GameObject);
			this.m_actors[2] = new TreasureMapBackgroundActor();
			this.m_actors[2].Create("Spine/General/Goblin_ABS/Goblin_1_Prefab.prefab", this.m_char2GameObject);
			this.m_actors[3] = new TreasureMapBackgroundActor();
			this.m_actors[3].Create("Spine/General/Goblin_ABS/Goblin_2_Prefab.prefab", this.m_char3GameObject);
			this.m_prefabsGameObject.SetActive(false);
		}

		// Token: 0x0601436B RID: 82795 RVA: 0x00524D64 File Offset: 0x00522F64
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
			this.ResetScrollViewToTop();
			UIUtility.SetUIStateOpen(this.m_uiStateController, "Show", null, false, true);
		}

		// Token: 0x0601436C RID: 82796 RVA: 0x00524DE0 File Offset: 0x00522FE0
		private void ResetScrollViewToTop()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ResetScrollViewToTop_hotfix != null)
			{
				this.m_ResetScrollViewToTop_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_levelListScrollRect.normalizedPosition = Vector2.one;
		}

		// Token: 0x0601436D RID: 82797 RVA: 0x00524E50 File Offset: 0x00523050
		public void SetTicketCount(int haveCount, int allCount)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetTicketCountInt32Int32_hotfix != null)
			{
				this.m_SetTicketCountInt32Int32_hotfix.call(new object[]
				{
					this,
					haveCount,
					allCount
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (haveCount == 0)
			{
				if (allCount == 0)
				{
					this.m_ticketText.text = "<color=red>" + haveCount + "</color>/∞";
				}
				else
				{
					this.m_ticketText.text = string.Concat(new object[]
					{
						"<color=red>",
						haveCount,
						"</color>/",
						allCount
					});
				}
			}
			else if (allCount == 0)
			{
				this.m_ticketText.text = haveCount + "/∞";
			}
			else
			{
				this.m_ticketText.text = haveCount + "/" + allCount;
			}
		}

		// Token: 0x0601436E RID: 82798 RVA: 0x00524F88 File Offset: 0x00523188
		public void AddTreasureLevelButton(ConfigDataTreasureLevelInfo levelnfo, bool opened)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddTreasureLevelButtonConfigDataTreasureLevelInfoBoolean_hotfix != null)
			{
				this.m_AddTreasureLevelButtonConfigDataTreasureLevelInfoBoolean_hotfix.call(new object[]
				{
					this,
					levelnfo,
					opened
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GameObject go = UnityEngine.Object.Instantiate<GameObject>(this.m_treasureLevelListItemPrefab, this.m_levelListScrollRect.content, false);
			TreasureLevelListItemUIController treasureLevelListItemUIController = GameObjectUtility.AddControllerToGameObject<TreasureLevelListItemUIController>(go);
			treasureLevelListItemUIController.SetTreasureLevelInfo(levelnfo);
			treasureLevelListItemUIController.SetLocked(!opened, levelnfo);
			treasureLevelListItemUIController.EventOnStartButtonClick += this.ThreasureLevelListItem_OnStartButtonClick;
			this.m_treasureLevelListItems.Add(treasureLevelListItemUIController);
		}

		// Token: 0x0601436F RID: 82799 RVA: 0x00525058 File Offset: 0x00523258
		public void ClearTreasureLevelButtons()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ClearTreasureLevelButtons_hotfix != null)
			{
				this.m_ClearTreasureLevelButtons_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GameObjectUtility.DestroyComponentList<TreasureLevelListItemUIController>(this.m_treasureLevelListItems);
			this.m_treasureLevelListItems.Clear();
		}

		// Token: 0x06014370 RID: 82800 RVA: 0x005250D0 File Offset: 0x005232D0
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

		// Token: 0x06014371 RID: 82801 RVA: 0x00525148 File Offset: 0x00523348
		private void OnHelpButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnHelpButtonClick_hotfix != null)
			{
				this.m_OnHelpButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnShowHelp != null)
			{
				this.EventOnShowHelp();
			}
		}

		// Token: 0x06014372 RID: 82802 RVA: 0x005251C0 File Offset: 0x005233C0
		private void OnAddTicketButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnAddTicketButtonClick_hotfix != null)
			{
				this.m_OnAddTicketButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnAddTicket != null)
			{
				this.EventOnAddTicket();
			}
		}

		// Token: 0x06014373 RID: 82803 RVA: 0x00525238 File Offset: 0x00523438
		private void ThreasureLevelListItem_OnStartButtonClick(TreasureLevelListItemUIController ctrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ThreasureLevelListItem_OnStartButtonClickTreasureLevelListItemUIController_hotfix != null)
			{
				this.m_ThreasureLevelListItem_OnStartButtonClickTreasureLevelListItemUIController_hotfix.call(new object[]
				{
					this,
					ctrl
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnStartTreasureLevel != null)
			{
				this.EventOnStartTreasureLevel(ctrl.GetTreasureLevelInfo());
			}
		}

		// Token: 0x14000476 RID: 1142
		// (add) Token: 0x06014374 RID: 82804 RVA: 0x005252C4 File Offset: 0x005234C4
		// (remove) Token: 0x06014375 RID: 82805 RVA: 0x00525360 File Offset: 0x00523560
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

		// Token: 0x14000477 RID: 1143
		// (add) Token: 0x06014376 RID: 82806 RVA: 0x005253FC File Offset: 0x005235FC
		// (remove) Token: 0x06014377 RID: 82807 RVA: 0x00525498 File Offset: 0x00523698
		public event Action EventOnShowHelp
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnShowHelpAction_hotfix != null)
				{
					this.m_add_EventOnShowHelpAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnShowHelp;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnShowHelp, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnShowHelpAction_hotfix != null)
				{
					this.m_remove_EventOnShowHelpAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnShowHelp;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnShowHelp, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000478 RID: 1144
		// (add) Token: 0x06014378 RID: 82808 RVA: 0x00525534 File Offset: 0x00523734
		// (remove) Token: 0x06014379 RID: 82809 RVA: 0x005255D0 File Offset: 0x005237D0
		public event Action EventOnAddTicket
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnAddTicketAction_hotfix != null)
				{
					this.m_add_EventOnAddTicketAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnAddTicket;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnAddTicket, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnAddTicketAction_hotfix != null)
				{
					this.m_remove_EventOnAddTicketAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnAddTicket;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnAddTicket, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000479 RID: 1145
		// (add) Token: 0x0601437A RID: 82810 RVA: 0x0052566C File Offset: 0x0052386C
		// (remove) Token: 0x0601437B RID: 82811 RVA: 0x00525708 File Offset: 0x00523908
		public event Action<ConfigDataTreasureLevelInfo> EventOnStartTreasureLevel
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnStartTreasureLevelAction`1_hotfix != null)
				{
					this.m_add_EventOnStartTreasureLevelAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<ConfigDataTreasureLevelInfo> action = this.EventOnStartTreasureLevel;
				Action<ConfigDataTreasureLevelInfo> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<ConfigDataTreasureLevelInfo>>(ref this.EventOnStartTreasureLevel, (Action<ConfigDataTreasureLevelInfo>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnStartTreasureLevelAction`1_hotfix != null)
				{
					this.m_remove_EventOnStartTreasureLevelAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<ConfigDataTreasureLevelInfo> action = this.EventOnStartTreasureLevel;
				Action<ConfigDataTreasureLevelInfo> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<ConfigDataTreasureLevelInfo>>(ref this.EventOnStartTreasureLevel, (Action<ConfigDataTreasureLevelInfo>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17003C33 RID: 15411
		// (get) Token: 0x0601437C RID: 82812 RVA: 0x005257A4 File Offset: 0x005239A4
		// (set) Token: 0x0601437D RID: 82813 RVA: 0x005257C4 File Offset: 0x005239C4
		[DoNotToLua]
		public new TreasureMapUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new TreasureMapUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0601437E RID: 82814 RVA: 0x005257D0 File Offset: 0x005239D0
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0601437F RID: 82815 RVA: 0x005257DC File Offset: 0x005239DC
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x06014380 RID: 82816 RVA: 0x005257E4 File Offset: 0x005239E4
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x06014381 RID: 82817 RVA: 0x005257EC File Offset: 0x005239EC
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x06014382 RID: 82818 RVA: 0x00525800 File Offset: 0x00523A00
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x06014383 RID: 82819 RVA: 0x00525808 File Offset: 0x00523A08
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x06014384 RID: 82820 RVA: 0x00525814 File Offset: 0x00523A14
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x06014385 RID: 82821 RVA: 0x00525820 File Offset: 0x00523A20
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x06014386 RID: 82822 RVA: 0x0052582C File Offset: 0x00523A2C
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x06014387 RID: 82823 RVA: 0x00525838 File Offset: 0x00523A38
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x06014388 RID: 82824 RVA: 0x00525844 File Offset: 0x00523A44
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x06014389 RID: 82825 RVA: 0x00525850 File Offset: 0x00523A50
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0601438A RID: 82826 RVA: 0x0052585C File Offset: 0x00523A5C
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0601438B RID: 82827 RVA: 0x00525868 File Offset: 0x00523A68
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0601438C RID: 82828 RVA: 0x00525874 File Offset: 0x00523A74
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0601438D RID: 82829 RVA: 0x0052587C File Offset: 0x00523A7C
		private void __callDele_EventOnReturn()
		{
			Action eventOnReturn = this.EventOnReturn;
			if (eventOnReturn != null)
			{
				eventOnReturn();
			}
		}

		// Token: 0x0601438E RID: 82830 RVA: 0x0052589C File Offset: 0x00523A9C
		private void __clearDele_EventOnReturn()
		{
			this.EventOnReturn = null;
		}

		// Token: 0x0601438F RID: 82831 RVA: 0x005258A8 File Offset: 0x00523AA8
		private void __callDele_EventOnShowHelp()
		{
			Action eventOnShowHelp = this.EventOnShowHelp;
			if (eventOnShowHelp != null)
			{
				eventOnShowHelp();
			}
		}

		// Token: 0x06014390 RID: 82832 RVA: 0x005258C8 File Offset: 0x00523AC8
		private void __clearDele_EventOnShowHelp()
		{
			this.EventOnShowHelp = null;
		}

		// Token: 0x06014391 RID: 82833 RVA: 0x005258D4 File Offset: 0x00523AD4
		private void __callDele_EventOnAddTicket()
		{
			Action eventOnAddTicket = this.EventOnAddTicket;
			if (eventOnAddTicket != null)
			{
				eventOnAddTicket();
			}
		}

		// Token: 0x06014392 RID: 82834 RVA: 0x005258F4 File Offset: 0x00523AF4
		private void __clearDele_EventOnAddTicket()
		{
			this.EventOnAddTicket = null;
		}

		// Token: 0x06014393 RID: 82835 RVA: 0x00525900 File Offset: 0x00523B00
		private void __callDele_EventOnStartTreasureLevel(ConfigDataTreasureLevelInfo obj)
		{
			Action<ConfigDataTreasureLevelInfo> eventOnStartTreasureLevel = this.EventOnStartTreasureLevel;
			if (eventOnStartTreasureLevel != null)
			{
				eventOnStartTreasureLevel(obj);
			}
		}

		// Token: 0x06014394 RID: 82836 RVA: 0x00525924 File Offset: 0x00523B24
		private void __clearDele_EventOnStartTreasureLevel(ConfigDataTreasureLevelInfo obj)
		{
			this.EventOnStartTreasureLevel = null;
		}

		// Token: 0x06014395 RID: 82837 RVA: 0x00525930 File Offset: 0x00523B30
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
					this.m_ResetScrollViewToTop_hotfix = (luaObj.RawGet("ResetScrollViewToTop") as LuaFunction);
					this.m_SetTicketCountInt32Int32_hotfix = (luaObj.RawGet("SetTicketCount") as LuaFunction);
					this.m_AddTreasureLevelButtonConfigDataTreasureLevelInfoBoolean_hotfix = (luaObj.RawGet("AddTreasureLevelButton") as LuaFunction);
					this.m_ClearTreasureLevelButtons_hotfix = (luaObj.RawGet("ClearTreasureLevelButtons") as LuaFunction);
					this.m_OnReturnButtonClick_hotfix = (luaObj.RawGet("OnReturnButtonClick") as LuaFunction);
					this.m_OnHelpButtonClick_hotfix = (luaObj.RawGet("OnHelpButtonClick") as LuaFunction);
					this.m_OnAddTicketButtonClick_hotfix = (luaObj.RawGet("OnAddTicketButtonClick") as LuaFunction);
					this.m_ThreasureLevelListItem_OnStartButtonClickTreasureLevelListItemUIController_hotfix = (luaObj.RawGet("ThreasureLevelListItem_OnStartButtonClick") as LuaFunction);
					this.m_add_EventOnReturnAction_hotfix = (luaObj.RawGet("add_EventOnReturn") as LuaFunction);
					this.m_remove_EventOnReturnAction_hotfix = (luaObj.RawGet("remove_EventOnReturn") as LuaFunction);
					this.m_add_EventOnShowHelpAction_hotfix = (luaObj.RawGet("add_EventOnShowHelp") as LuaFunction);
					this.m_remove_EventOnShowHelpAction_hotfix = (luaObj.RawGet("remove_EventOnShowHelp") as LuaFunction);
					this.m_add_EventOnAddTicketAction_hotfix = (luaObj.RawGet("add_EventOnAddTicket") as LuaFunction);
					this.m_remove_EventOnAddTicketAction_hotfix = (luaObj.RawGet("remove_EventOnAddTicket") as LuaFunction);
					this.m_add_EventOnStartTreasureLevelAction`1_hotfix = (luaObj.RawGet("add_EventOnStartTreasureLevel") as LuaFunction);
					this.m_remove_EventOnStartTreasureLevelAction`1_hotfix = (luaObj.RawGet("remove_EventOnStartTreasureLevel") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06014396 RID: 82838 RVA: 0x00525BA4 File Offset: 0x00523DA4
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(TreasureMapUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400B274 RID: 45684
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_uiStateController;

		// Token: 0x0400B275 RID: 45685
		[AutoBind("./ReturnButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_returnButton;

		// Token: 0x0400B276 RID: 45686
		[AutoBind("./HelpButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_helpButton;

		// Token: 0x0400B277 RID: 45687
		[AutoBind("./PlayerResource/Ticket/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_ticketText;

		// Token: 0x0400B278 RID: 45688
		[AutoBind("./PlayerResource/Ticket/AddButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_addTicketButton;

		// Token: 0x0400B279 RID: 45689
		[AutoBind("./LevelList/ScrollView", AutoBindAttribute.InitState.NotInit, false)]
		private ScrollRect m_levelListScrollRect;

		// Token: 0x0400B27A RID: 45690
		[AutoBind("./Background/Char", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_char0GameObject;

		// Token: 0x0400B27B RID: 45691
		[AutoBind("./Background/Char1", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_char1GameObject;

		// Token: 0x0400B27C RID: 45692
		[AutoBind("./Background/Char2", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_char2GameObject;

		// Token: 0x0400B27D RID: 45693
		[AutoBind("./Background/Char3", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_char3GameObject;

		// Token: 0x0400B27E RID: 45694
		[AutoBind("./Prefabs", AutoBindAttribute.InitState.Inactive, false)]
		private GameObject m_prefabsGameObject;

		// Token: 0x0400B27F RID: 45695
		[AutoBind("./Prefabs/TreasureLevelListItem", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_treasureLevelListItemPrefab;

		// Token: 0x0400B280 RID: 45696
		private List<TreasureLevelListItemUIController> m_treasureLevelListItems = new List<TreasureLevelListItemUIController>();

		// Token: 0x0400B281 RID: 45697
		private TreasureMapBackgroundActor[] m_actors = new TreasureMapBackgroundActor[4];

		// Token: 0x0400B282 RID: 45698
		[DoNotToLua]
		private TreasureMapUIController.LuaExportHelper luaExportHelper;

		// Token: 0x0400B283 RID: 45699
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400B284 RID: 45700
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400B285 RID: 45701
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x0400B286 RID: 45702
		private LuaFunction m_Open_hotfix;

		// Token: 0x0400B287 RID: 45703
		private LuaFunction m_ResetScrollViewToTop_hotfix;

		// Token: 0x0400B288 RID: 45704
		private LuaFunction m_SetTicketCountInt32Int32_hotfix;

		// Token: 0x0400B289 RID: 45705
		private LuaFunction m_AddTreasureLevelButtonConfigDataTreasureLevelInfoBoolean_hotfix;

		// Token: 0x0400B28A RID: 45706
		private LuaFunction m_ClearTreasureLevelButtons_hotfix;

		// Token: 0x0400B28B RID: 45707
		private LuaFunction m_OnReturnButtonClick_hotfix;

		// Token: 0x0400B28C RID: 45708
		private LuaFunction m_OnHelpButtonClick_hotfix;

		// Token: 0x0400B28D RID: 45709
		private LuaFunction m_OnAddTicketButtonClick_hotfix;

		// Token: 0x0400B28E RID: 45710
		private LuaFunction m_ThreasureLevelListItem_OnStartButtonClickTreasureLevelListItemUIController_hotfix;

		// Token: 0x0400B28F RID: 45711
		private LuaFunction m_add_EventOnReturnAction_hotfix;

		// Token: 0x0400B290 RID: 45712
		private LuaFunction m_remove_EventOnReturnAction_hotfix;

		// Token: 0x0400B291 RID: 45713
		private LuaFunction m_add_EventOnShowHelpAction_hotfix;

		// Token: 0x0400B292 RID: 45714
		private LuaFunction m_remove_EventOnShowHelpAction_hotfix;

		// Token: 0x0400B293 RID: 45715
		private LuaFunction m_add_EventOnAddTicketAction_hotfix;

		// Token: 0x0400B294 RID: 45716
		private LuaFunction m_remove_EventOnAddTicketAction_hotfix;

		// Token: 0x0400B295 RID: 45717
		private LuaFunction m_add_EventOnStartTreasureLevelAction;

		// Token: 0x0400B296 RID: 45718
		private LuaFunction m_remove_EventOnStartTreasureLevelAction;

		// Token: 0x02000FCC RID: 4044
		public new class LuaExportHelper
		{
			// Token: 0x06014397 RID: 82839 RVA: 0x00525C0C File Offset: 0x00523E0C
			public LuaExportHelper(TreasureMapUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06014398 RID: 82840 RVA: 0x00525C1C File Offset: 0x00523E1C
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x06014399 RID: 82841 RVA: 0x00525C2C File Offset: 0x00523E2C
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0601439A RID: 82842 RVA: 0x00525C3C File Offset: 0x00523E3C
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0601439B RID: 82843 RVA: 0x00525C4C File Offset: 0x00523E4C
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0601439C RID: 82844 RVA: 0x00525C64 File Offset: 0x00523E64
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0601439D RID: 82845 RVA: 0x00525C74 File Offset: 0x00523E74
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0601439E RID: 82846 RVA: 0x00525C84 File Offset: 0x00523E84
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0601439F RID: 82847 RVA: 0x00525C94 File Offset: 0x00523E94
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x060143A0 RID: 82848 RVA: 0x00525CA4 File Offset: 0x00523EA4
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x060143A1 RID: 82849 RVA: 0x00525CB4 File Offset: 0x00523EB4
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x060143A2 RID: 82850 RVA: 0x00525CC4 File Offset: 0x00523EC4
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x060143A3 RID: 82851 RVA: 0x00525CD4 File Offset: 0x00523ED4
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x060143A4 RID: 82852 RVA: 0x00525CE4 File Offset: 0x00523EE4
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x060143A5 RID: 82853 RVA: 0x00525CF4 File Offset: 0x00523EF4
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x060143A6 RID: 82854 RVA: 0x00525D04 File Offset: 0x00523F04
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x060143A7 RID: 82855 RVA: 0x00525D14 File Offset: 0x00523F14
			public void __callDele_EventOnReturn()
			{
				this.m_owner.__callDele_EventOnReturn();
			}

			// Token: 0x060143A8 RID: 82856 RVA: 0x00525D24 File Offset: 0x00523F24
			public void __clearDele_EventOnReturn()
			{
				this.m_owner.__clearDele_EventOnReturn();
			}

			// Token: 0x060143A9 RID: 82857 RVA: 0x00525D34 File Offset: 0x00523F34
			public void __callDele_EventOnShowHelp()
			{
				this.m_owner.__callDele_EventOnShowHelp();
			}

			// Token: 0x060143AA RID: 82858 RVA: 0x00525D44 File Offset: 0x00523F44
			public void __clearDele_EventOnShowHelp()
			{
				this.m_owner.__clearDele_EventOnShowHelp();
			}

			// Token: 0x060143AB RID: 82859 RVA: 0x00525D54 File Offset: 0x00523F54
			public void __callDele_EventOnAddTicket()
			{
				this.m_owner.__callDele_EventOnAddTicket();
			}

			// Token: 0x060143AC RID: 82860 RVA: 0x00525D64 File Offset: 0x00523F64
			public void __clearDele_EventOnAddTicket()
			{
				this.m_owner.__clearDele_EventOnAddTicket();
			}

			// Token: 0x060143AD RID: 82861 RVA: 0x00525D74 File Offset: 0x00523F74
			public void __callDele_EventOnStartTreasureLevel(ConfigDataTreasureLevelInfo obj)
			{
				this.m_owner.__callDele_EventOnStartTreasureLevel(obj);
			}

			// Token: 0x060143AE RID: 82862 RVA: 0x00525D84 File Offset: 0x00523F84
			public void __clearDele_EventOnStartTreasureLevel(ConfigDataTreasureLevelInfo obj)
			{
				this.m_owner.__clearDele_EventOnStartTreasureLevel(obj);
			}

			// Token: 0x17003C34 RID: 15412
			// (get) Token: 0x060143AF RID: 82863 RVA: 0x00525D94 File Offset: 0x00523F94
			// (set) Token: 0x060143B0 RID: 82864 RVA: 0x00525DA4 File Offset: 0x00523FA4
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

			// Token: 0x17003C35 RID: 15413
			// (get) Token: 0x060143B1 RID: 82865 RVA: 0x00525DB4 File Offset: 0x00523FB4
			// (set) Token: 0x060143B2 RID: 82866 RVA: 0x00525DC4 File Offset: 0x00523FC4
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

			// Token: 0x17003C36 RID: 15414
			// (get) Token: 0x060143B3 RID: 82867 RVA: 0x00525DD4 File Offset: 0x00523FD4
			// (set) Token: 0x060143B4 RID: 82868 RVA: 0x00525DE4 File Offset: 0x00523FE4
			public Button m_helpButton
			{
				get
				{
					return this.m_owner.m_helpButton;
				}
				set
				{
					this.m_owner.m_helpButton = value;
				}
			}

			// Token: 0x17003C37 RID: 15415
			// (get) Token: 0x060143B5 RID: 82869 RVA: 0x00525DF4 File Offset: 0x00523FF4
			// (set) Token: 0x060143B6 RID: 82870 RVA: 0x00525E04 File Offset: 0x00524004
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

			// Token: 0x17003C38 RID: 15416
			// (get) Token: 0x060143B7 RID: 82871 RVA: 0x00525E14 File Offset: 0x00524014
			// (set) Token: 0x060143B8 RID: 82872 RVA: 0x00525E24 File Offset: 0x00524024
			public Button m_addTicketButton
			{
				get
				{
					return this.m_owner.m_addTicketButton;
				}
				set
				{
					this.m_owner.m_addTicketButton = value;
				}
			}

			// Token: 0x17003C39 RID: 15417
			// (get) Token: 0x060143B9 RID: 82873 RVA: 0x00525E34 File Offset: 0x00524034
			// (set) Token: 0x060143BA RID: 82874 RVA: 0x00525E44 File Offset: 0x00524044
			public ScrollRect m_levelListScrollRect
			{
				get
				{
					return this.m_owner.m_levelListScrollRect;
				}
				set
				{
					this.m_owner.m_levelListScrollRect = value;
				}
			}

			// Token: 0x17003C3A RID: 15418
			// (get) Token: 0x060143BB RID: 82875 RVA: 0x00525E54 File Offset: 0x00524054
			// (set) Token: 0x060143BC RID: 82876 RVA: 0x00525E64 File Offset: 0x00524064
			public GameObject m_char0GameObject
			{
				get
				{
					return this.m_owner.m_char0GameObject;
				}
				set
				{
					this.m_owner.m_char0GameObject = value;
				}
			}

			// Token: 0x17003C3B RID: 15419
			// (get) Token: 0x060143BD RID: 82877 RVA: 0x00525E74 File Offset: 0x00524074
			// (set) Token: 0x060143BE RID: 82878 RVA: 0x00525E84 File Offset: 0x00524084
			public GameObject m_char1GameObject
			{
				get
				{
					return this.m_owner.m_char1GameObject;
				}
				set
				{
					this.m_owner.m_char1GameObject = value;
				}
			}

			// Token: 0x17003C3C RID: 15420
			// (get) Token: 0x060143BF RID: 82879 RVA: 0x00525E94 File Offset: 0x00524094
			// (set) Token: 0x060143C0 RID: 82880 RVA: 0x00525EA4 File Offset: 0x005240A4
			public GameObject m_char2GameObject
			{
				get
				{
					return this.m_owner.m_char2GameObject;
				}
				set
				{
					this.m_owner.m_char2GameObject = value;
				}
			}

			// Token: 0x17003C3D RID: 15421
			// (get) Token: 0x060143C1 RID: 82881 RVA: 0x00525EB4 File Offset: 0x005240B4
			// (set) Token: 0x060143C2 RID: 82882 RVA: 0x00525EC4 File Offset: 0x005240C4
			public GameObject m_char3GameObject
			{
				get
				{
					return this.m_owner.m_char3GameObject;
				}
				set
				{
					this.m_owner.m_char3GameObject = value;
				}
			}

			// Token: 0x17003C3E RID: 15422
			// (get) Token: 0x060143C3 RID: 82883 RVA: 0x00525ED4 File Offset: 0x005240D4
			// (set) Token: 0x060143C4 RID: 82884 RVA: 0x00525EE4 File Offset: 0x005240E4
			public GameObject m_prefabsGameObject
			{
				get
				{
					return this.m_owner.m_prefabsGameObject;
				}
				set
				{
					this.m_owner.m_prefabsGameObject = value;
				}
			}

			// Token: 0x17003C3F RID: 15423
			// (get) Token: 0x060143C5 RID: 82885 RVA: 0x00525EF4 File Offset: 0x005240F4
			// (set) Token: 0x060143C6 RID: 82886 RVA: 0x00525F04 File Offset: 0x00524104
			public GameObject m_treasureLevelListItemPrefab
			{
				get
				{
					return this.m_owner.m_treasureLevelListItemPrefab;
				}
				set
				{
					this.m_owner.m_treasureLevelListItemPrefab = value;
				}
			}

			// Token: 0x17003C40 RID: 15424
			// (get) Token: 0x060143C7 RID: 82887 RVA: 0x00525F14 File Offset: 0x00524114
			// (set) Token: 0x060143C8 RID: 82888 RVA: 0x00525F24 File Offset: 0x00524124
			public List<TreasureLevelListItemUIController> m_treasureLevelListItems
			{
				get
				{
					return this.m_owner.m_treasureLevelListItems;
				}
				set
				{
					this.m_owner.m_treasureLevelListItems = value;
				}
			}

			// Token: 0x17003C41 RID: 15425
			// (get) Token: 0x060143C9 RID: 82889 RVA: 0x00525F34 File Offset: 0x00524134
			// (set) Token: 0x060143CA RID: 82890 RVA: 0x00525F44 File Offset: 0x00524144
			public TreasureMapBackgroundActor[] m_actors
			{
				get
				{
					return this.m_owner.m_actors;
				}
				set
				{
					this.m_owner.m_actors = value;
				}
			}

			// Token: 0x060143CB RID: 82891 RVA: 0x00525F54 File Offset: 0x00524154
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x060143CC RID: 82892 RVA: 0x00525F64 File Offset: 0x00524164
			public void ResetScrollViewToTop()
			{
				this.m_owner.ResetScrollViewToTop();
			}

			// Token: 0x060143CD RID: 82893 RVA: 0x00525F74 File Offset: 0x00524174
			public void OnReturnButtonClick()
			{
				this.m_owner.OnReturnButtonClick();
			}

			// Token: 0x060143CE RID: 82894 RVA: 0x00525F84 File Offset: 0x00524184
			public void OnHelpButtonClick()
			{
				this.m_owner.OnHelpButtonClick();
			}

			// Token: 0x060143CF RID: 82895 RVA: 0x00525F94 File Offset: 0x00524194
			public void OnAddTicketButtonClick()
			{
				this.m_owner.OnAddTicketButtonClick();
			}

			// Token: 0x060143D0 RID: 82896 RVA: 0x00525FA4 File Offset: 0x005241A4
			public void ThreasureLevelListItem_OnStartButtonClick(TreasureLevelListItemUIController ctrl)
			{
				this.m_owner.ThreasureLevelListItem_OnStartButtonClick(ctrl);
			}

			// Token: 0x0400B297 RID: 45719
			private TreasureMapUIController m_owner;
		}
	}
}
