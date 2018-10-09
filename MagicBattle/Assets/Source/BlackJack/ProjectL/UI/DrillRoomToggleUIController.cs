using System;
using System.Runtime.CompilerServices;
using System.Threading;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000C5B RID: 3163
	[HotFix]
	public class DrillRoomToggleUIController : UIControllerBase
	{
		// Token: 0x0600E0D3 RID: 57555 RVA: 0x003C9698 File Offset: 0x003C7898
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
			this.m_toggle.onValueChanged.AddListener(new UnityAction<bool>(this.OnToggleValueChange));
			this.m_lockGreyButton.onClick.AddListener(new UnityAction(this.OnLockButtonClick));
		}

		// Token: 0x0600E0D4 RID: 57556 RVA: 0x003C9744 File Offset: 0x003C7944
		public void InitRoomToggleInfo(int roomId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitRoomToggleInfoInt32_hotfix != null)
			{
				this.m_InitRoomToggleInfoInt32_hotfix.call(new object[]
				{
					this,
					roomId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			TrainingRoom trainingRoomById = projectLPlayerContext.GetTrainingRoomById(roomId);
			if (trainingRoomById == null)
			{
				return;
			}
			this.Room = trainingRoomById;
			bool locked = trainingRoomById.Locked;
			if (locked)
			{
				this.m_stateCtrl.SetToUIState("Grey", false, true);
			}
			else
			{
				this.m_stateCtrl.SetToUIState("Normal", false, true);
			}
			this.m_lvValueText.text = trainingRoomById.Level.ToString();
			this.m_toggle.interactable = !locked;
			this.m_redMark.SetActive(projectLPlayerContext.CanTrainingRoomLevelup(trainingRoomById));
		}

		// Token: 0x0600E0D5 RID: 57557 RVA: 0x003C9850 File Offset: 0x003C7A50
		private void OnToggleValueChange(bool isOn)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnToggleValueChangeBoolean_hotfix != null)
			{
				this.m_OnToggleValueChangeBoolean_hotfix.call(new object[]
				{
					this,
					isOn
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (isOn && this.EventOnToggleClick != null)
			{
				this.EventOnToggleClick(this);
			}
		}

		// Token: 0x0600E0D6 RID: 57558 RVA: 0x003C98E0 File Offset: 0x003C7AE0
		private void OnLockButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnLockButtonClick_hotfix != null)
			{
				this.m_OnLockButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			ConfigDataAnikiLevelInfo configDataAnikiLevelInfo = configDataLoader.GetConfigDataAnikiLevelInfo(this.Room.Config.LevelToUnlock);
			CommonUIController.Instance.ShowMessage(string.Format(configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Msg_LevelFinishUnlock), configDataAnikiLevelInfo.m_groupInfo.Name), 2f, null, true);
		}

		// Token: 0x140002D0 RID: 720
		// (add) Token: 0x0600E0D7 RID: 57559 RVA: 0x003C9994 File Offset: 0x003C7B94
		// (remove) Token: 0x0600E0D8 RID: 57560 RVA: 0x003C9A30 File Offset: 0x003C7C30
		public event Action<DrillRoomToggleUIController> EventOnToggleClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnToggleClickAction`1_hotfix != null)
				{
					this.m_add_EventOnToggleClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<DrillRoomToggleUIController> action = this.EventOnToggleClick;
				Action<DrillRoomToggleUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<DrillRoomToggleUIController>>(ref this.EventOnToggleClick, (Action<DrillRoomToggleUIController>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnToggleClickAction`1_hotfix != null)
				{
					this.m_remove_EventOnToggleClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<DrillRoomToggleUIController> action = this.EventOnToggleClick;
				Action<DrillRoomToggleUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<DrillRoomToggleUIController>>(ref this.EventOnToggleClick, (Action<DrillRoomToggleUIController>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17002BB1 RID: 11185
		// (get) Token: 0x0600E0DA RID: 57562 RVA: 0x003C9B44 File Offset: 0x003C7D44
		// (set) Token: 0x0600E0D9 RID: 57561 RVA: 0x003C9ACC File Offset: 0x003C7CCC
		public TrainingRoom Room
		{
			[CompilerGenerated]
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_Room_hotfix != null)
				{
					return (TrainingRoom)this.m_get_Room_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.<Room>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_set_RoomTrainingRoom_hotfix != null)
				{
					this.m_set_RoomTrainingRoom_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				this.<Room>k__BackingField = value;
			}
		}

		// Token: 0x17002BB2 RID: 11186
		// (get) Token: 0x0600E0DB RID: 57563 RVA: 0x003C9BB8 File Offset: 0x003C7DB8
		// (set) Token: 0x0600E0DC RID: 57564 RVA: 0x003C9BD8 File Offset: 0x003C7DD8
		[DoNotToLua]
		public new DrillRoomToggleUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new DrillRoomToggleUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600E0DD RID: 57565 RVA: 0x003C9BE4 File Offset: 0x003C7DE4
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0600E0DE RID: 57566 RVA: 0x003C9BF0 File Offset: 0x003C7DF0
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0600E0DF RID: 57567 RVA: 0x003C9BF8 File Offset: 0x003C7DF8
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0600E0E0 RID: 57568 RVA: 0x003C9C00 File Offset: 0x003C7E00
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0600E0E1 RID: 57569 RVA: 0x003C9C14 File Offset: 0x003C7E14
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0600E0E2 RID: 57570 RVA: 0x003C9C1C File Offset: 0x003C7E1C
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0600E0E3 RID: 57571 RVA: 0x003C9C28 File Offset: 0x003C7E28
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0600E0E4 RID: 57572 RVA: 0x003C9C34 File Offset: 0x003C7E34
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0600E0E5 RID: 57573 RVA: 0x003C9C40 File Offset: 0x003C7E40
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0600E0E6 RID: 57574 RVA: 0x003C9C4C File Offset: 0x003C7E4C
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0600E0E7 RID: 57575 RVA: 0x003C9C58 File Offset: 0x003C7E58
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0600E0E8 RID: 57576 RVA: 0x003C9C64 File Offset: 0x003C7E64
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0600E0E9 RID: 57577 RVA: 0x003C9C70 File Offset: 0x003C7E70
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0600E0EA RID: 57578 RVA: 0x003C9C7C File Offset: 0x003C7E7C
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0600E0EB RID: 57579 RVA: 0x003C9C88 File Offset: 0x003C7E88
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600E0EC RID: 57580 RVA: 0x003C9C90 File Offset: 0x003C7E90
		private void __callDele_EventOnToggleClick(DrillRoomToggleUIController obj)
		{
			Action<DrillRoomToggleUIController> eventOnToggleClick = this.EventOnToggleClick;
			if (eventOnToggleClick != null)
			{
				eventOnToggleClick(obj);
			}
		}

		// Token: 0x0600E0ED RID: 57581 RVA: 0x003C9CB4 File Offset: 0x003C7EB4
		private void __clearDele_EventOnToggleClick(DrillRoomToggleUIController obj)
		{
			this.EventOnToggleClick = null;
		}

		// Token: 0x0600E0EE RID: 57582 RVA: 0x003C9CC0 File Offset: 0x003C7EC0
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
					this.m_InitRoomToggleInfoInt32_hotfix = (luaObj.RawGet("InitRoomToggleInfo") as LuaFunction);
					this.m_OnToggleValueChangeBoolean_hotfix = (luaObj.RawGet("OnToggleValueChange") as LuaFunction);
					this.m_OnLockButtonClick_hotfix = (luaObj.RawGet("OnLockButtonClick") as LuaFunction);
					this.m_add_EventOnToggleClickAction`1_hotfix = (luaObj.RawGet("add_EventOnToggleClick") as LuaFunction);
					this.m_remove_EventOnToggleClickAction`1_hotfix = (luaObj.RawGet("remove_EventOnToggleClick") as LuaFunction);
					this.m_set_RoomTrainingRoom_hotfix = (luaObj.RawGet("set_Room") as LuaFunction);
					this.m_get_Room_hotfix = (luaObj.RawGet("get_Room") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600E0EF RID: 57583 RVA: 0x003C9E3C File Offset: 0x003C803C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(DrillRoomToggleUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04008896 RID: 34966
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_toggle;

		// Token: 0x04008897 RID: 34967
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_stateCtrl;

		// Token: 0x04008898 RID: 34968
		[AutoBind("./Value", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_lvValueText;

		// Token: 0x04008899 RID: 34969
		[AutoBind("./ImageGrey", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_lockGreyButton;

		// Token: 0x0400889A RID: 34970
		[AutoBind("./RedMark", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_redMark;

		// Token: 0x0400889C RID: 34972
		[DoNotToLua]
		private DrillRoomToggleUIController.LuaExportHelper luaExportHelper;

		// Token: 0x0400889D RID: 34973
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400889E RID: 34974
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400889F RID: 34975
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x040088A0 RID: 34976
		private LuaFunction m_InitRoomToggleInfoInt32_hotfix;

		// Token: 0x040088A1 RID: 34977
		private LuaFunction m_OnToggleValueChangeBoolean_hotfix;

		// Token: 0x040088A2 RID: 34978
		private LuaFunction m_OnLockButtonClick_hotfix;

		// Token: 0x040088A3 RID: 34979
		private LuaFunction m_add_EventOnToggleClickAction;

		// Token: 0x040088A4 RID: 34980
		private LuaFunction m_remove_EventOnToggleClickAction;

		// Token: 0x040088A5 RID: 34981
		private LuaFunction m_set_RoomTrainingRoom_hotfix;

		// Token: 0x040088A6 RID: 34982
		private LuaFunction m_get_Room_hotfix;

		// Token: 0x02000C5C RID: 3164
		public new class LuaExportHelper
		{
			// Token: 0x0600E0F0 RID: 57584 RVA: 0x003C9EA4 File Offset: 0x003C80A4
			public LuaExportHelper(DrillRoomToggleUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600E0F1 RID: 57585 RVA: 0x003C9EB4 File Offset: 0x003C80B4
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0600E0F2 RID: 57586 RVA: 0x003C9EC4 File Offset: 0x003C80C4
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0600E0F3 RID: 57587 RVA: 0x003C9ED4 File Offset: 0x003C80D4
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600E0F4 RID: 57588 RVA: 0x003C9EE4 File Offset: 0x003C80E4
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600E0F5 RID: 57589 RVA: 0x003C9EFC File Offset: 0x003C80FC
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0600E0F6 RID: 57590 RVA: 0x003C9F0C File Offset: 0x003C810C
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0600E0F7 RID: 57591 RVA: 0x003C9F1C File Offset: 0x003C811C
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0600E0F8 RID: 57592 RVA: 0x003C9F2C File Offset: 0x003C812C
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0600E0F9 RID: 57593 RVA: 0x003C9F3C File Offset: 0x003C813C
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0600E0FA RID: 57594 RVA: 0x003C9F4C File Offset: 0x003C814C
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0600E0FB RID: 57595 RVA: 0x003C9F5C File Offset: 0x003C815C
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0600E0FC RID: 57596 RVA: 0x003C9F6C File Offset: 0x003C816C
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0600E0FD RID: 57597 RVA: 0x003C9F7C File Offset: 0x003C817C
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0600E0FE RID: 57598 RVA: 0x003C9F8C File Offset: 0x003C818C
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0600E0FF RID: 57599 RVA: 0x003C9F9C File Offset: 0x003C819C
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x0600E100 RID: 57600 RVA: 0x003C9FAC File Offset: 0x003C81AC
			public void __callDele_EventOnToggleClick(DrillRoomToggleUIController obj)
			{
				this.m_owner.__callDele_EventOnToggleClick(obj);
			}

			// Token: 0x0600E101 RID: 57601 RVA: 0x003C9FBC File Offset: 0x003C81BC
			public void __clearDele_EventOnToggleClick(DrillRoomToggleUIController obj)
			{
				this.m_owner.__clearDele_EventOnToggleClick(obj);
			}

			// Token: 0x17002BB3 RID: 11187
			// (get) Token: 0x0600E102 RID: 57602 RVA: 0x003C9FCC File Offset: 0x003C81CC
			// (set) Token: 0x0600E103 RID: 57603 RVA: 0x003C9FDC File Offset: 0x003C81DC
			public Toggle m_toggle
			{
				get
				{
					return this.m_owner.m_toggle;
				}
				set
				{
					this.m_owner.m_toggle = value;
				}
			}

			// Token: 0x17002BB4 RID: 11188
			// (get) Token: 0x0600E104 RID: 57604 RVA: 0x003C9FEC File Offset: 0x003C81EC
			// (set) Token: 0x0600E105 RID: 57605 RVA: 0x003C9FFC File Offset: 0x003C81FC
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

			// Token: 0x17002BB5 RID: 11189
			// (get) Token: 0x0600E106 RID: 57606 RVA: 0x003CA00C File Offset: 0x003C820C
			// (set) Token: 0x0600E107 RID: 57607 RVA: 0x003CA01C File Offset: 0x003C821C
			public Text m_lvValueText
			{
				get
				{
					return this.m_owner.m_lvValueText;
				}
				set
				{
					this.m_owner.m_lvValueText = value;
				}
			}

			// Token: 0x17002BB6 RID: 11190
			// (get) Token: 0x0600E108 RID: 57608 RVA: 0x003CA02C File Offset: 0x003C822C
			// (set) Token: 0x0600E109 RID: 57609 RVA: 0x003CA03C File Offset: 0x003C823C
			public Button m_lockGreyButton
			{
				get
				{
					return this.m_owner.m_lockGreyButton;
				}
				set
				{
					this.m_owner.m_lockGreyButton = value;
				}
			}

			// Token: 0x17002BB7 RID: 11191
			// (get) Token: 0x0600E10A RID: 57610 RVA: 0x003CA04C File Offset: 0x003C824C
			// (set) Token: 0x0600E10B RID: 57611 RVA: 0x003CA05C File Offset: 0x003C825C
			public GameObject m_redMark
			{
				get
				{
					return this.m_owner.m_redMark;
				}
				set
				{
					this.m_owner.m_redMark = value;
				}
			}

			// Token: 0x17002BB8 RID: 11192
			// (set) Token: 0x0600E10C RID: 57612 RVA: 0x003CA06C File Offset: 0x003C826C
			public TrainingRoom Room
			{
				set
				{
					this.m_owner.Room = value;
				}
			}

			// Token: 0x0600E10D RID: 57613 RVA: 0x003CA07C File Offset: 0x003C827C
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0600E10E RID: 57614 RVA: 0x003CA08C File Offset: 0x003C828C
			public void OnToggleValueChange(bool isOn)
			{
				this.m_owner.OnToggleValueChange(isOn);
			}

			// Token: 0x0600E10F RID: 57615 RVA: 0x003CA09C File Offset: 0x003C829C
			public void OnLockButtonClick()
			{
				this.m_owner.OnLockButtonClick();
			}

			// Token: 0x040088A7 RID: 34983
			private DrillRoomToggleUIController m_owner;
		}
	}
}
