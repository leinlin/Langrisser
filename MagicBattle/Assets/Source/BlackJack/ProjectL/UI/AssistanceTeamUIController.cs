using System;
using System.Collections.Generic;
using System.Threading;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.Scene;
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000C5F RID: 3167
	[HotFix]
	public class AssistanceTeamUIController : UIControllerBase
	{
		// Token: 0x0600E153 RID: 57683 RVA: 0x003CAB08 File Offset: 0x003C8D08
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
			base.gameObject.SetActive(true);
			this.m_trainingButton.onClick.AddListener(new UnityAction(this.OnTrainingButtonClick));
			this.m_stopButton.onClick.AddListener(new UnityAction(this.OnStopButtonClick));
			this.m_getRewardButton.onClick.AddListener(new UnityAction(this.OnGetRewardButtonClick));
			this.m_playerContext = (GameManager.Instance.PlayerContext as ProjectLPlayerContext);
		}

		// Token: 0x0600E154 RID: 57684 RVA: 0x003CABE4 File Offset: 0x003C8DE4
		public void InitAssistanceTeamInfo(HeroAssistantsTaskAssignment task, int slot)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitAssistanceTeamInfoHeroAssistantsTaskAssignmentInt32_hotfix != null)
			{
				this.m_InitAssistanceTeamInfoHeroAssistantsTaskAssignmentInt32_hotfix.call(new object[]
				{
					this,
					task,
					slot
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_heroAssistantsTask = task;
			this.m_slot = slot;
			if (task == null)
			{
				this.m_stateCtrl.SetToUIState("None", false, true);
			}
			else
			{
				if (task.EndTime <= this.m_playerContext.GetServerTime())
				{
					this.m_stateCtrl.SetToUIState("Finish", false, true);
					this.SetSoldierSpine();
					this.m_playerHeroGraphic.PlayAnimation("idle", true, 0);
				}
				else
				{
					this.m_stateCtrl.SetToUIState("Processing", false, true);
					this.SetSoldierSpine();
					this.m_playerHeroGraphic.PlayAnimation("run", true, 0);
				}
				List<HeroAssistantsTask> heroAssistantsTasksByWeekDay = this.m_playerContext.GetHeroAssistantsTasksByWeekDay(this.m_heroAssistantsTask.Task.Weekday);
				int num = heroAssistantsTasksByWeekDay.FindIndex((HeroAssistantsTask t) => t == this.m_heroAssistantsTask.Task) + 1;
				if (num == -1)
				{
					global::Debug.LogError("Task Difficulty Error, TaskId:" + this.m_heroAssistantsTask.TaskId);
					num = 1;
				}
				this.m_difficultyText.text = num.ToString();
			}
			this.m_charGameObject.SetActive(task != null);
		}

		// Token: 0x0600E155 RID: 57685 RVA: 0x003CAD88 File Offset: 0x003C8F88
		public void SetTimeText(TimeSpan ts)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetTimeTextTimeSpan_hotfix != null)
			{
				this.m_SetTimeTextTimeSpan_hotfix.call(new object[]
				{
					this,
					ts
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!(this.m_heroAssistantsTask.EndTime <= this.m_playerContext.GetServerTime()))
			{
				this.m_timeStateText.text = string.Format("{0:d2}:{1:d2}:{2:d2}", ts.Hours, ts.Minutes, ts.Seconds);
				return;
			}
			UIStateDesc currentUIState = this.m_stateCtrl.GetCurrentUIState();
			if (currentUIState.StateName == "Finish")
			{
				return;
			}
			this.m_stateCtrl.SetToUIState("Finish", false, true);
			this.m_playerHeroGraphic.PlayAnimation("idle", true, 0);
		}

		// Token: 0x0600E156 RID: 57686 RVA: 0x003CAE98 File Offset: 0x003C9098
		private void SetSoldierSpine()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetSoldierSpine_hotfix != null)
			{
				this.m_SetSoldierSpine_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int heroId = this.m_heroAssistantsTask.AssignedHeroIds[0];
			Hero hero = this.m_playerContext.GetHero(heroId);
			ConfigDataJobConnectionInfo jobConnectionInfo = hero.GetActiveJob().JobConnectionInfo;
			string model = jobConnectionInfo.Model;
			float scale = (float)jobConnectionInfo.UI_ModelScale * 0.008f;
			Vector2 offset = new Vector2((float)jobConnectionInfo.UI_ModelOffsetX, (float)jobConnectionInfo.UI_ModelOffsetY) * 1.4f;
			List<ReplaceAnim> replaceAnims = jobConnectionInfo.ReplaceAnims;
			HeroDetailUIController.CreateSpineGraphic(ref this.m_playerHeroGraphic, model, this.m_charGameObject, 1, offset, scale, replaceAnims);
		}

		// Token: 0x0600E157 RID: 57687 RVA: 0x003CAF7C File Offset: 0x003C917C
		private void OnTrainingButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnTrainingButtonClick_hotfix != null)
			{
				this.m_OnTrainingButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnTrainingButtonClick != null)
			{
				this.EventOnTrainingButtonClick(this.m_slot);
			}
		}

		// Token: 0x0600E158 RID: 57688 RVA: 0x003CAFF8 File Offset: 0x003C91F8
		private void OnStopButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnStopButtonClick_hotfix != null)
			{
				this.m_OnStopButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnStopButtonClick != null)
			{
				this.EventOnStopButtonClick(this);
			}
		}

		// Token: 0x0600E159 RID: 57689 RVA: 0x003CB070 File Offset: 0x003C9270
		private void OnGetRewardButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnGetRewardButtonClick_hotfix != null)
			{
				this.m_OnGetRewardButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnGetRewardButtonClick != null)
			{
				this.EventOnGetRewardButtonClick(this);
			}
		}

		// Token: 0x140002D2 RID: 722
		// (add) Token: 0x0600E15A RID: 57690 RVA: 0x003CB0E8 File Offset: 0x003C92E8
		// (remove) Token: 0x0600E15B RID: 57691 RVA: 0x003CB184 File Offset: 0x003C9384
		public event Action<int> EventOnTrainingButtonClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnTrainingButtonClickAction`1_hotfix != null)
				{
					this.m_add_EventOnTrainingButtonClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int> action = this.EventOnTrainingButtonClick;
				Action<int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int>>(ref this.EventOnTrainingButtonClick, (Action<int>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnTrainingButtonClickAction`1_hotfix != null)
				{
					this.m_remove_EventOnTrainingButtonClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int> action = this.EventOnTrainingButtonClick;
				Action<int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int>>(ref this.EventOnTrainingButtonClick, (Action<int>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140002D3 RID: 723
		// (add) Token: 0x0600E15C RID: 57692 RVA: 0x003CB220 File Offset: 0x003C9420
		// (remove) Token: 0x0600E15D RID: 57693 RVA: 0x003CB2BC File Offset: 0x003C94BC
		public event Action<AssistanceTeamUIController> EventOnStopButtonClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnStopButtonClickAction`1_hotfix != null)
				{
					this.m_add_EventOnStopButtonClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<AssistanceTeamUIController> action = this.EventOnStopButtonClick;
				Action<AssistanceTeamUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<AssistanceTeamUIController>>(ref this.EventOnStopButtonClick, (Action<AssistanceTeamUIController>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnStopButtonClickAction`1_hotfix != null)
				{
					this.m_remove_EventOnStopButtonClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<AssistanceTeamUIController> action = this.EventOnStopButtonClick;
				Action<AssistanceTeamUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<AssistanceTeamUIController>>(ref this.EventOnStopButtonClick, (Action<AssistanceTeamUIController>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140002D4 RID: 724
		// (add) Token: 0x0600E15E RID: 57694 RVA: 0x003CB358 File Offset: 0x003C9558
		// (remove) Token: 0x0600E15F RID: 57695 RVA: 0x003CB3F4 File Offset: 0x003C95F4
		public event Action<AssistanceTeamUIController> EventOnGetRewardButtonClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnGetRewardButtonClickAction`1_hotfix != null)
				{
					this.m_add_EventOnGetRewardButtonClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<AssistanceTeamUIController> action = this.EventOnGetRewardButtonClick;
				Action<AssistanceTeamUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<AssistanceTeamUIController>>(ref this.EventOnGetRewardButtonClick, (Action<AssistanceTeamUIController>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnGetRewardButtonClickAction`1_hotfix != null)
				{
					this.m_remove_EventOnGetRewardButtonClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<AssistanceTeamUIController> action = this.EventOnGetRewardButtonClick;
				Action<AssistanceTeamUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<AssistanceTeamUIController>>(ref this.EventOnGetRewardButtonClick, (Action<AssistanceTeamUIController>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17002BC3 RID: 11203
		// (get) Token: 0x0600E160 RID: 57696 RVA: 0x003CB490 File Offset: 0x003C9690
		// (set) Token: 0x0600E161 RID: 57697 RVA: 0x003CB4B0 File Offset: 0x003C96B0
		[DoNotToLua]
		public new AssistanceTeamUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new AssistanceTeamUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600E162 RID: 57698 RVA: 0x003CB4BC File Offset: 0x003C96BC
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0600E163 RID: 57699 RVA: 0x003CB4C8 File Offset: 0x003C96C8
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0600E164 RID: 57700 RVA: 0x003CB4D0 File Offset: 0x003C96D0
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0600E165 RID: 57701 RVA: 0x003CB4D8 File Offset: 0x003C96D8
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0600E166 RID: 57702 RVA: 0x003CB4EC File Offset: 0x003C96EC
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0600E167 RID: 57703 RVA: 0x003CB4F4 File Offset: 0x003C96F4
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0600E168 RID: 57704 RVA: 0x003CB500 File Offset: 0x003C9700
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0600E169 RID: 57705 RVA: 0x003CB50C File Offset: 0x003C970C
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0600E16A RID: 57706 RVA: 0x003CB518 File Offset: 0x003C9718
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0600E16B RID: 57707 RVA: 0x003CB524 File Offset: 0x003C9724
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0600E16C RID: 57708 RVA: 0x003CB530 File Offset: 0x003C9730
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0600E16D RID: 57709 RVA: 0x003CB53C File Offset: 0x003C973C
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0600E16E RID: 57710 RVA: 0x003CB548 File Offset: 0x003C9748
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0600E16F RID: 57711 RVA: 0x003CB554 File Offset: 0x003C9754
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0600E170 RID: 57712 RVA: 0x003CB560 File Offset: 0x003C9760
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600E171 RID: 57713 RVA: 0x003CB568 File Offset: 0x003C9768
		private void __callDele_EventOnTrainingButtonClick(int obj)
		{
			Action<int> eventOnTrainingButtonClick = this.EventOnTrainingButtonClick;
			if (eventOnTrainingButtonClick != null)
			{
				eventOnTrainingButtonClick(obj);
			}
		}

		// Token: 0x0600E172 RID: 57714 RVA: 0x003CB58C File Offset: 0x003C978C
		private void __clearDele_EventOnTrainingButtonClick(int obj)
		{
			this.EventOnTrainingButtonClick = null;
		}

		// Token: 0x0600E173 RID: 57715 RVA: 0x003CB598 File Offset: 0x003C9798
		private void __callDele_EventOnStopButtonClick(AssistanceTeamUIController obj)
		{
			Action<AssistanceTeamUIController> eventOnStopButtonClick = this.EventOnStopButtonClick;
			if (eventOnStopButtonClick != null)
			{
				eventOnStopButtonClick(obj);
			}
		}

		// Token: 0x0600E174 RID: 57716 RVA: 0x003CB5BC File Offset: 0x003C97BC
		private void __clearDele_EventOnStopButtonClick(AssistanceTeamUIController obj)
		{
			this.EventOnStopButtonClick = null;
		}

		// Token: 0x0600E175 RID: 57717 RVA: 0x003CB5C8 File Offset: 0x003C97C8
		private void __callDele_EventOnGetRewardButtonClick(AssistanceTeamUIController obj)
		{
			Action<AssistanceTeamUIController> eventOnGetRewardButtonClick = this.EventOnGetRewardButtonClick;
			if (eventOnGetRewardButtonClick != null)
			{
				eventOnGetRewardButtonClick(obj);
			}
		}

		// Token: 0x0600E176 RID: 57718 RVA: 0x003CB5EC File Offset: 0x003C97EC
		private void __clearDele_EventOnGetRewardButtonClick(AssistanceTeamUIController obj)
		{
			this.EventOnGetRewardButtonClick = null;
		}

		// Token: 0x0600E178 RID: 57720 RVA: 0x003CB608 File Offset: 0x003C9808
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
					this.m_InitAssistanceTeamInfoHeroAssistantsTaskAssignmentInt32_hotfix = (luaObj.RawGet("InitAssistanceTeamInfo") as LuaFunction);
					this.m_SetTimeTextTimeSpan_hotfix = (luaObj.RawGet("SetTimeText") as LuaFunction);
					this.m_SetSoldierSpine_hotfix = (luaObj.RawGet("SetSoldierSpine") as LuaFunction);
					this.m_OnTrainingButtonClick_hotfix = (luaObj.RawGet("OnTrainingButtonClick") as LuaFunction);
					this.m_OnStopButtonClick_hotfix = (luaObj.RawGet("OnStopButtonClick") as LuaFunction);
					this.m_OnGetRewardButtonClick_hotfix = (luaObj.RawGet("OnGetRewardButtonClick") as LuaFunction);
					this.m_add_EventOnTrainingButtonClickAction`1_hotfix = (luaObj.RawGet("add_EventOnTrainingButtonClick") as LuaFunction);
					this.m_remove_EventOnTrainingButtonClickAction`1_hotfix = (luaObj.RawGet("remove_EventOnTrainingButtonClick") as LuaFunction);
					this.m_add_EventOnStopButtonClickAction`1_hotfix = (luaObj.RawGet("add_EventOnStopButtonClick") as LuaFunction);
					this.m_remove_EventOnStopButtonClickAction`1_hotfix = (luaObj.RawGet("remove_EventOnStopButtonClick") as LuaFunction);
					this.m_add_EventOnGetRewardButtonClickAction`1_hotfix = (luaObj.RawGet("add_EventOnGetRewardButtonClick") as LuaFunction);
					this.m_remove_EventOnGetRewardButtonClickAction`1_hotfix = (luaObj.RawGet("remove_EventOnGetRewardButtonClick") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600E179 RID: 57721 RVA: 0x003CB800 File Offset: 0x003C9A00
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(AssistanceTeamUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040088C0 RID: 35008
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_stateCtrl;

		// Token: 0x040088C1 RID: 35009
		[AutoBind("./Char", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_charGameObject;

		// Token: 0x040088C2 RID: 35010
		[AutoBind("./TrainingButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_trainingButton;

		// Token: 0x040088C3 RID: 35011
		[AutoBind("./StopButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_stopButton;

		// Token: 0x040088C4 RID: 35012
		[AutoBind("./GetRewardButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_getRewardButton;

		// Token: 0x040088C5 RID: 35013
		[AutoBind("./DifficultyText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_difficultyText;

		// Token: 0x040088C6 RID: 35014
		[AutoBind("./TimeStateText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_timeStateText;

		// Token: 0x040088C7 RID: 35015
		private UISpineGraphic m_playerHeroGraphic;

		// Token: 0x040088C8 RID: 35016
		public int m_slot;

		// Token: 0x040088C9 RID: 35017
		public HeroAssistantsTaskAssignment m_heroAssistantsTask;

		// Token: 0x040088CA RID: 35018
		private ProjectLPlayerContext m_playerContext;

		// Token: 0x040088CB RID: 35019
		[DoNotToLua]
		private AssistanceTeamUIController.LuaExportHelper luaExportHelper;

		// Token: 0x040088CC RID: 35020
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040088CD RID: 35021
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040088CE RID: 35022
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x040088CF RID: 35023
		private LuaFunction m_InitAssistanceTeamInfoHeroAssistantsTaskAssignmentInt32_hotfix;

		// Token: 0x040088D0 RID: 35024
		private LuaFunction m_SetTimeTextTimeSpan_hotfix;

		// Token: 0x040088D1 RID: 35025
		private LuaFunction m_SetSoldierSpine_hotfix;

		// Token: 0x040088D2 RID: 35026
		private LuaFunction m_OnTrainingButtonClick_hotfix;

		// Token: 0x040088D3 RID: 35027
		private LuaFunction m_OnStopButtonClick_hotfix;

		// Token: 0x040088D4 RID: 35028
		private LuaFunction m_OnGetRewardButtonClick_hotfix;

		// Token: 0x040088D5 RID: 35029
		private LuaFunction m_add_EventOnTrainingButtonClickAction;

		// Token: 0x040088D6 RID: 35030
		private LuaFunction m_remove_EventOnTrainingButtonClickAction;

		// Token: 0x040088D7 RID: 35031
		private LuaFunction m_add_EventOnStopButtonClickAction;

		// Token: 0x040088D8 RID: 35032
		private LuaFunction m_remove_EventOnStopButtonClickAction;

		// Token: 0x040088D9 RID: 35033
		private LuaFunction m_add_EventOnGetRewardButtonClickAction;

		// Token: 0x040088DA RID: 35034
		private LuaFunction m_remove_EventOnGetRewardButtonClickAction;

		// Token: 0x02000C60 RID: 3168
		public new class LuaExportHelper
		{
			// Token: 0x0600E17A RID: 57722 RVA: 0x003CB868 File Offset: 0x003C9A68
			public LuaExportHelper(AssistanceTeamUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600E17B RID: 57723 RVA: 0x003CB878 File Offset: 0x003C9A78
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0600E17C RID: 57724 RVA: 0x003CB888 File Offset: 0x003C9A88
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0600E17D RID: 57725 RVA: 0x003CB898 File Offset: 0x003C9A98
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600E17E RID: 57726 RVA: 0x003CB8A8 File Offset: 0x003C9AA8
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600E17F RID: 57727 RVA: 0x003CB8C0 File Offset: 0x003C9AC0
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0600E180 RID: 57728 RVA: 0x003CB8D0 File Offset: 0x003C9AD0
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0600E181 RID: 57729 RVA: 0x003CB8E0 File Offset: 0x003C9AE0
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0600E182 RID: 57730 RVA: 0x003CB8F0 File Offset: 0x003C9AF0
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0600E183 RID: 57731 RVA: 0x003CB900 File Offset: 0x003C9B00
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0600E184 RID: 57732 RVA: 0x003CB910 File Offset: 0x003C9B10
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0600E185 RID: 57733 RVA: 0x003CB920 File Offset: 0x003C9B20
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0600E186 RID: 57734 RVA: 0x003CB930 File Offset: 0x003C9B30
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0600E187 RID: 57735 RVA: 0x003CB940 File Offset: 0x003C9B40
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0600E188 RID: 57736 RVA: 0x003CB950 File Offset: 0x003C9B50
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0600E189 RID: 57737 RVA: 0x003CB960 File Offset: 0x003C9B60
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x0600E18A RID: 57738 RVA: 0x003CB970 File Offset: 0x003C9B70
			public void __callDele_EventOnTrainingButtonClick(int obj)
			{
				this.m_owner.__callDele_EventOnTrainingButtonClick(obj);
			}

			// Token: 0x0600E18B RID: 57739 RVA: 0x003CB980 File Offset: 0x003C9B80
			public void __clearDele_EventOnTrainingButtonClick(int obj)
			{
				this.m_owner.__clearDele_EventOnTrainingButtonClick(obj);
			}

			// Token: 0x0600E18C RID: 57740 RVA: 0x003CB990 File Offset: 0x003C9B90
			public void __callDele_EventOnStopButtonClick(AssistanceTeamUIController obj)
			{
				this.m_owner.__callDele_EventOnStopButtonClick(obj);
			}

			// Token: 0x0600E18D RID: 57741 RVA: 0x003CB9A0 File Offset: 0x003C9BA0
			public void __clearDele_EventOnStopButtonClick(AssistanceTeamUIController obj)
			{
				this.m_owner.__clearDele_EventOnStopButtonClick(obj);
			}

			// Token: 0x0600E18E RID: 57742 RVA: 0x003CB9B0 File Offset: 0x003C9BB0
			public void __callDele_EventOnGetRewardButtonClick(AssistanceTeamUIController obj)
			{
				this.m_owner.__callDele_EventOnGetRewardButtonClick(obj);
			}

			// Token: 0x0600E18F RID: 57743 RVA: 0x003CB9C0 File Offset: 0x003C9BC0
			public void __clearDele_EventOnGetRewardButtonClick(AssistanceTeamUIController obj)
			{
				this.m_owner.__clearDele_EventOnGetRewardButtonClick(obj);
			}

			// Token: 0x17002BC4 RID: 11204
			// (get) Token: 0x0600E190 RID: 57744 RVA: 0x003CB9D0 File Offset: 0x003C9BD0
			// (set) Token: 0x0600E191 RID: 57745 RVA: 0x003CB9E0 File Offset: 0x003C9BE0
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

			// Token: 0x17002BC5 RID: 11205
			// (get) Token: 0x0600E192 RID: 57746 RVA: 0x003CB9F0 File Offset: 0x003C9BF0
			// (set) Token: 0x0600E193 RID: 57747 RVA: 0x003CBA00 File Offset: 0x003C9C00
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

			// Token: 0x17002BC6 RID: 11206
			// (get) Token: 0x0600E194 RID: 57748 RVA: 0x003CBA10 File Offset: 0x003C9C10
			// (set) Token: 0x0600E195 RID: 57749 RVA: 0x003CBA20 File Offset: 0x003C9C20
			public Button m_trainingButton
			{
				get
				{
					return this.m_owner.m_trainingButton;
				}
				set
				{
					this.m_owner.m_trainingButton = value;
				}
			}

			// Token: 0x17002BC7 RID: 11207
			// (get) Token: 0x0600E196 RID: 57750 RVA: 0x003CBA30 File Offset: 0x003C9C30
			// (set) Token: 0x0600E197 RID: 57751 RVA: 0x003CBA40 File Offset: 0x003C9C40
			public Button m_stopButton
			{
				get
				{
					return this.m_owner.m_stopButton;
				}
				set
				{
					this.m_owner.m_stopButton = value;
				}
			}

			// Token: 0x17002BC8 RID: 11208
			// (get) Token: 0x0600E198 RID: 57752 RVA: 0x003CBA50 File Offset: 0x003C9C50
			// (set) Token: 0x0600E199 RID: 57753 RVA: 0x003CBA60 File Offset: 0x003C9C60
			public Button m_getRewardButton
			{
				get
				{
					return this.m_owner.m_getRewardButton;
				}
				set
				{
					this.m_owner.m_getRewardButton = value;
				}
			}

			// Token: 0x17002BC9 RID: 11209
			// (get) Token: 0x0600E19A RID: 57754 RVA: 0x003CBA70 File Offset: 0x003C9C70
			// (set) Token: 0x0600E19B RID: 57755 RVA: 0x003CBA80 File Offset: 0x003C9C80
			public Text m_difficultyText
			{
				get
				{
					return this.m_owner.m_difficultyText;
				}
				set
				{
					this.m_owner.m_difficultyText = value;
				}
			}

			// Token: 0x17002BCA RID: 11210
			// (get) Token: 0x0600E19C RID: 57756 RVA: 0x003CBA90 File Offset: 0x003C9C90
			// (set) Token: 0x0600E19D RID: 57757 RVA: 0x003CBAA0 File Offset: 0x003C9CA0
			public Text m_timeStateText
			{
				get
				{
					return this.m_owner.m_timeStateText;
				}
				set
				{
					this.m_owner.m_timeStateText = value;
				}
			}

			// Token: 0x17002BCB RID: 11211
			// (get) Token: 0x0600E19E RID: 57758 RVA: 0x003CBAB0 File Offset: 0x003C9CB0
			// (set) Token: 0x0600E19F RID: 57759 RVA: 0x003CBAC0 File Offset: 0x003C9CC0
			public UISpineGraphic m_playerHeroGraphic
			{
				get
				{
					return this.m_owner.m_playerHeroGraphic;
				}
				set
				{
					this.m_owner.m_playerHeroGraphic = value;
				}
			}

			// Token: 0x17002BCC RID: 11212
			// (get) Token: 0x0600E1A0 RID: 57760 RVA: 0x003CBAD0 File Offset: 0x003C9CD0
			// (set) Token: 0x0600E1A1 RID: 57761 RVA: 0x003CBAE0 File Offset: 0x003C9CE0
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

			// Token: 0x0600E1A2 RID: 57762 RVA: 0x003CBAF0 File Offset: 0x003C9CF0
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0600E1A3 RID: 57763 RVA: 0x003CBB00 File Offset: 0x003C9D00
			public void SetSoldierSpine()
			{
				this.m_owner.SetSoldierSpine();
			}

			// Token: 0x0600E1A4 RID: 57764 RVA: 0x003CBB10 File Offset: 0x003C9D10
			public void OnTrainingButtonClick()
			{
				this.m_owner.OnTrainingButtonClick();
			}

			// Token: 0x0600E1A5 RID: 57765 RVA: 0x003CBB20 File Offset: 0x003C9D20
			public void OnStopButtonClick()
			{
				this.m_owner.OnStopButtonClick();
			}

			// Token: 0x0600E1A6 RID: 57766 RVA: 0x003CBB30 File Offset: 0x003C9D30
			public void OnGetRewardButtonClick()
			{
				this.m_owner.OnGetRewardButtonClick();
			}

			// Token: 0x040088DB RID: 35035
			private AssistanceTeamUIController m_owner;
		}
	}
}
