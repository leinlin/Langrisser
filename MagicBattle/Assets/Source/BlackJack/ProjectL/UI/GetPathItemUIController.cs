using System;
using System.Runtime.CompilerServices;
using System.Threading;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.PlayerContext;
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000BBB RID: 3003
	[HotFix]
	public class GetPathItemUIController : UIControllerBase
	{
		// Token: 0x0600CE54 RID: 52820 RVA: 0x0038C038 File Offset: 0x0038A238
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
			this.m_button.onClick.AddListener(new UnityAction(this.OnGotoButtonClick));
		}

		// Token: 0x0600CE55 RID: 52821 RVA: 0x0038C0BC File Offset: 0x0038A2BC
		public void SetGetPath(GetPathData getPathInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetGetPathGetPathData_hotfix != null)
			{
				this.m_SetGetPathGetPathData_hotfix.call(new object[]
				{
					this,
					getPathInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			this.GetPathInfo = getPathInfo;
			ConfigDataStringTableForListInfo configDataStringTableForListInfo = configDataLoader.GetConfigDataStringTableForListInfo(getPathInfo.Name);
			this.m_nameText.text = configDataStringTableForListInfo.Content;
			int num = 0;
			int num2 = 0;
			bool flag = false;
			bool flag2 = true;
			switch (getPathInfo.PathType)
			{
			case GetPathType.GetPathType_Rift:
			{
				flag2 = projectLPlayerContext.IsGameFunctionOpened(GameFunctionType.GameFunctionType_Rift);
				RiftLevelStatus riftLevelStatus = projectLPlayerContext.GetRiftLevelStatus(getPathInfo.ID);
				flag2 = (flag2 && riftLevelStatus == RiftLevelStatus.Open);
				ConfigDataRiftLevelInfo configDataRiftLevelInfo = configDataLoader.GetConfigDataRiftLevelInfo(getPathInfo.ID);
				num = projectLPlayerContext.GetRiftLevelCanChallengeNums(configDataRiftLevelInfo);
				num2 = projectLPlayerContext.GetRiftLevelCanChallengeMaxNums(configDataRiftLevelInfo);
				flag = true;
				break;
			}
			case GetPathType.GetPathType_Aniki:
				flag2 = projectLPlayerContext.IsGameFunctionOpened(GameFunctionType.GameFunctionType_AnikiGym);
				break;
			case GetPathType.GetPathType_ThearchyTrial:
				flag2 = projectLPlayerContext.IsGameFunctionOpened(GameFunctionType.GameFunctionType_ThearchyTrial);
				break;
			case GetPathType.GetPathType_Summon1:
			case GetPathType.GetPathType_Summon2:
			case GetPathType.GetPathType_Summon3:
				flag2 = projectLPlayerContext.IsGameFunctionOpened(GameFunctionType.GameFunctionType_SelectCard);
				break;
			case GetPathType.GetPathType_MemoryCorridor:
				flag2 = projectLPlayerContext.IsGameFunctionOpened(GameFunctionType.GameFunctionType_MemoryCorridor);
				break;
			case GetPathType.GetPathType_HeroTraining:
				flag2 = projectLPlayerContext.IsGameFunctionOpened(GameFunctionType.GameFunctionType_HeroTrainning);
				break;
			case GetPathType.GetPathType_Drill1:
			case GetPathType.GetPathType_Drill2:
				flag2 = projectLPlayerContext.IsGameFunctionOpened(GameFunctionType.GameFunctionType_TrainingGround);
				break;
			case GetPathType.GetPathType_Fetter:
				flag2 = projectLPlayerContext.IsGameFunctionOpened(GameFunctionType.GameFunctionType_Fetters);
				break;
			case GetPathType.GetPathType_Arena:
				flag2 = projectLPlayerContext.IsGameFunctionOpened(GameFunctionType.GameFunctionType_ArenaBattle);
				break;
			case GetPathType.GetPathType_Friend:
				flag2 = projectLPlayerContext.IsGameFunctionOpened(GameFunctionType.GameFunctionType_Friend);
				break;
			case GetPathType.GetPathType_TreasureMap:
				flag2 = projectLPlayerContext.IsGameFunctionOpened(GameFunctionType.GameFunctionType_TreasureMap);
				break;
			case GetPathType.GetPathType_Mission:
				flag2 = projectLPlayerContext.IsGameFunctionOpened(GameFunctionType.GameFunctionType_Mission);
				break;
			case GetPathType.GetPathType_HeroDungeon:
			{
				ConfigDataHeroDungeonLevelInfo configDataHeroDungeonLevelInfo = configDataLoader.GetConfigDataHeroDungeonLevelInfo(getPathInfo.ID);
				flag2 = (configDataHeroDungeonLevelInfo != null && projectLPlayerContext.IsGameFunctionOpened(GameFunctionType.GameFunctionType_HeroDungeon) && (projectLPlayerContext.CanAttackHeroDungeonLevel(getPathInfo.ID) == 0 || projectLPlayerContext.CanAttackHeroDungeonLevel(getPathInfo.ID) == -2905));
				num = projectLPlayerContext.GetHeroDungeonLevelCanChallengeNum(configDataHeroDungeonLevelInfo);
				num2 = projectLPlayerContext.GetHeroDungeonLevelCanChallengeMaxNum(configDataHeroDungeonLevelInfo);
				flag = true;
				break;
			}
			}
			if (flag2)
			{
				if (flag)
				{
					this.m_stateCtrl.SetToUIState("Number", false, true);
					this.m_timesValue.text = num.ToString();
					this.m_timesAllValue.text = num2.ToString();
					if (num != 0)
					{
						this.m_timesStateCtrl.SetToUIState("Normal", false, true);
					}
					else
					{
						this.m_timesStateCtrl.SetToUIState("None", false, true);
					}
				}
				else
				{
					this.m_stateCtrl.SetToUIState("Normal", false, true);
				}
			}
			else
			{
				this.m_stateCtrl.SetToUIState("Lock", false, true);
			}
		}

		// Token: 0x0600CE56 RID: 52822 RVA: 0x0038C404 File Offset: 0x0038A604
		private void OnGotoButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnGotoButtonClick_hotfix != null)
			{
				this.m_OnGotoButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnGotoButtonClick != null)
			{
				this.EventOnGotoButtonClick(this.GetPathInfo);
			}
		}

		// Token: 0x14000279 RID: 633
		// (add) Token: 0x0600CE57 RID: 52823 RVA: 0x0038C480 File Offset: 0x0038A680
		// (remove) Token: 0x0600CE58 RID: 52824 RVA: 0x0038C51C File Offset: 0x0038A71C
		public event Action<GetPathData> EventOnGotoButtonClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnGotoButtonClickAction`1_hotfix != null)
				{
					this.m_add_EventOnGotoButtonClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<GetPathData> action = this.EventOnGotoButtonClick;
				Action<GetPathData> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<GetPathData>>(ref this.EventOnGotoButtonClick, (Action<GetPathData>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnGotoButtonClickAction`1_hotfix != null)
				{
					this.m_remove_EventOnGotoButtonClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<GetPathData> action = this.EventOnGotoButtonClick;
				Action<GetPathData> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<GetPathData>>(ref this.EventOnGotoButtonClick, (Action<GetPathData>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x170028CA RID: 10442
		// (get) Token: 0x0600CE5A RID: 52826 RVA: 0x0038C630 File Offset: 0x0038A830
		// (set) Token: 0x0600CE59 RID: 52825 RVA: 0x0038C5B8 File Offset: 0x0038A7B8
		public GetPathData GetPathInfo
		{
			[CompilerGenerated]
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_GetPathInfo_hotfix != null)
				{
					return (GetPathData)this.m_get_GetPathInfo_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.<GetPathInfo>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_set_GetPathInfoGetPathData_hotfix != null)
				{
					this.m_set_GetPathInfoGetPathData_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				this.<GetPathInfo>k__BackingField = value;
			}
		}

		// Token: 0x170028CB RID: 10443
		// (get) Token: 0x0600CE5B RID: 52827 RVA: 0x0038C6A4 File Offset: 0x0038A8A4
		// (set) Token: 0x0600CE5C RID: 52828 RVA: 0x0038C6C4 File Offset: 0x0038A8C4
		[DoNotToLua]
		public new GetPathItemUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new GetPathItemUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600CE5D RID: 52829 RVA: 0x0038C6D0 File Offset: 0x0038A8D0
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0600CE5E RID: 52830 RVA: 0x0038C6DC File Offset: 0x0038A8DC
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0600CE5F RID: 52831 RVA: 0x0038C6E4 File Offset: 0x0038A8E4
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0600CE60 RID: 52832 RVA: 0x0038C6EC File Offset: 0x0038A8EC
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0600CE61 RID: 52833 RVA: 0x0038C700 File Offset: 0x0038A900
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0600CE62 RID: 52834 RVA: 0x0038C708 File Offset: 0x0038A908
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0600CE63 RID: 52835 RVA: 0x0038C714 File Offset: 0x0038A914
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0600CE64 RID: 52836 RVA: 0x0038C720 File Offset: 0x0038A920
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0600CE65 RID: 52837 RVA: 0x0038C72C File Offset: 0x0038A92C
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0600CE66 RID: 52838 RVA: 0x0038C738 File Offset: 0x0038A938
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0600CE67 RID: 52839 RVA: 0x0038C744 File Offset: 0x0038A944
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0600CE68 RID: 52840 RVA: 0x0038C750 File Offset: 0x0038A950
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0600CE69 RID: 52841 RVA: 0x0038C75C File Offset: 0x0038A95C
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0600CE6A RID: 52842 RVA: 0x0038C768 File Offset: 0x0038A968
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0600CE6B RID: 52843 RVA: 0x0038C774 File Offset: 0x0038A974
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600CE6C RID: 52844 RVA: 0x0038C77C File Offset: 0x0038A97C
		private void __callDele_EventOnGotoButtonClick(GetPathData obj)
		{
			Action<GetPathData> eventOnGotoButtonClick = this.EventOnGotoButtonClick;
			if (eventOnGotoButtonClick != null)
			{
				eventOnGotoButtonClick(obj);
			}
		}

		// Token: 0x0600CE6D RID: 52845 RVA: 0x0038C7A0 File Offset: 0x0038A9A0
		private void __clearDele_EventOnGotoButtonClick(GetPathData obj)
		{
			this.EventOnGotoButtonClick = null;
		}

		// Token: 0x0600CE6E RID: 52846 RVA: 0x0038C7AC File Offset: 0x0038A9AC
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
					this.m_SetGetPathGetPathData_hotfix = (luaObj.RawGet("SetGetPath") as LuaFunction);
					this.m_OnGotoButtonClick_hotfix = (luaObj.RawGet("OnGotoButtonClick") as LuaFunction);
					this.m_add_EventOnGotoButtonClickAction`1_hotfix = (luaObj.RawGet("add_EventOnGotoButtonClick") as LuaFunction);
					this.m_remove_EventOnGotoButtonClickAction`1_hotfix = (luaObj.RawGet("remove_EventOnGotoButtonClick") as LuaFunction);
					this.m_set_GetPathInfoGetPathData_hotfix = (luaObj.RawGet("set_GetPathInfo") as LuaFunction);
					this.m_get_GetPathInfo_hotfix = (luaObj.RawGet("get_GetPathInfo") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600CE6F RID: 52847 RVA: 0x0038C910 File Offset: 0x0038AB10
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(GetPathItemUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04008117 RID: 33047
		[AutoBind("./TitleText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_nameText;

		// Token: 0x04008118 RID: 33048
		[AutoBind("./Button", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_button;

		// Token: 0x04008119 RID: 33049
		[AutoBind("./Times", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_timesStateCtrl;

		// Token: 0x0400811A RID: 33050
		[AutoBind("./Times/Value", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_timesValue;

		// Token: 0x0400811B RID: 33051
		[AutoBind("./Times/ALL", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_timesAllValue;

		// Token: 0x0400811C RID: 33052
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_stateCtrl;

		// Token: 0x0400811E RID: 33054
		[DoNotToLua]
		private GetPathItemUIController.LuaExportHelper luaExportHelper;

		// Token: 0x0400811F RID: 33055
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04008120 RID: 33056
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04008121 RID: 33057
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x04008122 RID: 33058
		private LuaFunction m_SetGetPathGetPathData_hotfix;

		// Token: 0x04008123 RID: 33059
		private LuaFunction m_OnGotoButtonClick_hotfix;

		// Token: 0x04008124 RID: 33060
		private LuaFunction m_add_EventOnGotoButtonClickAction;

		// Token: 0x04008125 RID: 33061
		private LuaFunction m_remove_EventOnGotoButtonClickAction;

		// Token: 0x04008126 RID: 33062
		private LuaFunction m_set_GetPathInfoGetPathData_hotfix;

		// Token: 0x04008127 RID: 33063
		private LuaFunction m_get_GetPathInfo_hotfix;

		// Token: 0x02000BBC RID: 3004
		public new class LuaExportHelper
		{
			// Token: 0x0600CE70 RID: 52848 RVA: 0x0038C978 File Offset: 0x0038AB78
			public LuaExportHelper(GetPathItemUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600CE71 RID: 52849 RVA: 0x0038C988 File Offset: 0x0038AB88
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0600CE72 RID: 52850 RVA: 0x0038C998 File Offset: 0x0038AB98
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0600CE73 RID: 52851 RVA: 0x0038C9A8 File Offset: 0x0038ABA8
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600CE74 RID: 52852 RVA: 0x0038C9B8 File Offset: 0x0038ABB8
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600CE75 RID: 52853 RVA: 0x0038C9D0 File Offset: 0x0038ABD0
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0600CE76 RID: 52854 RVA: 0x0038C9E0 File Offset: 0x0038ABE0
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0600CE77 RID: 52855 RVA: 0x0038C9F0 File Offset: 0x0038ABF0
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0600CE78 RID: 52856 RVA: 0x0038CA00 File Offset: 0x0038AC00
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0600CE79 RID: 52857 RVA: 0x0038CA10 File Offset: 0x0038AC10
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0600CE7A RID: 52858 RVA: 0x0038CA20 File Offset: 0x0038AC20
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0600CE7B RID: 52859 RVA: 0x0038CA30 File Offset: 0x0038AC30
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0600CE7C RID: 52860 RVA: 0x0038CA40 File Offset: 0x0038AC40
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0600CE7D RID: 52861 RVA: 0x0038CA50 File Offset: 0x0038AC50
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0600CE7E RID: 52862 RVA: 0x0038CA60 File Offset: 0x0038AC60
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0600CE7F RID: 52863 RVA: 0x0038CA70 File Offset: 0x0038AC70
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x0600CE80 RID: 52864 RVA: 0x0038CA80 File Offset: 0x0038AC80
			public void __callDele_EventOnGotoButtonClick(GetPathData obj)
			{
				this.m_owner.__callDele_EventOnGotoButtonClick(obj);
			}

			// Token: 0x0600CE81 RID: 52865 RVA: 0x0038CA90 File Offset: 0x0038AC90
			public void __clearDele_EventOnGotoButtonClick(GetPathData obj)
			{
				this.m_owner.__clearDele_EventOnGotoButtonClick(obj);
			}

			// Token: 0x170028CC RID: 10444
			// (get) Token: 0x0600CE82 RID: 52866 RVA: 0x0038CAA0 File Offset: 0x0038ACA0
			// (set) Token: 0x0600CE83 RID: 52867 RVA: 0x0038CAB0 File Offset: 0x0038ACB0
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

			// Token: 0x170028CD RID: 10445
			// (get) Token: 0x0600CE84 RID: 52868 RVA: 0x0038CAC0 File Offset: 0x0038ACC0
			// (set) Token: 0x0600CE85 RID: 52869 RVA: 0x0038CAD0 File Offset: 0x0038ACD0
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

			// Token: 0x170028CE RID: 10446
			// (get) Token: 0x0600CE86 RID: 52870 RVA: 0x0038CAE0 File Offset: 0x0038ACE0
			// (set) Token: 0x0600CE87 RID: 52871 RVA: 0x0038CAF0 File Offset: 0x0038ACF0
			public CommonUIStateController m_timesStateCtrl
			{
				get
				{
					return this.m_owner.m_timesStateCtrl;
				}
				set
				{
					this.m_owner.m_timesStateCtrl = value;
				}
			}

			// Token: 0x170028CF RID: 10447
			// (get) Token: 0x0600CE88 RID: 52872 RVA: 0x0038CB00 File Offset: 0x0038AD00
			// (set) Token: 0x0600CE89 RID: 52873 RVA: 0x0038CB10 File Offset: 0x0038AD10
			public Text m_timesValue
			{
				get
				{
					return this.m_owner.m_timesValue;
				}
				set
				{
					this.m_owner.m_timesValue = value;
				}
			}

			// Token: 0x170028D0 RID: 10448
			// (get) Token: 0x0600CE8A RID: 52874 RVA: 0x0038CB20 File Offset: 0x0038AD20
			// (set) Token: 0x0600CE8B RID: 52875 RVA: 0x0038CB30 File Offset: 0x0038AD30
			public Text m_timesAllValue
			{
				get
				{
					return this.m_owner.m_timesAllValue;
				}
				set
				{
					this.m_owner.m_timesAllValue = value;
				}
			}

			// Token: 0x170028D1 RID: 10449
			// (get) Token: 0x0600CE8C RID: 52876 RVA: 0x0038CB40 File Offset: 0x0038AD40
			// (set) Token: 0x0600CE8D RID: 52877 RVA: 0x0038CB50 File Offset: 0x0038AD50
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

			// Token: 0x170028D2 RID: 10450
			// (set) Token: 0x0600CE8E RID: 52878 RVA: 0x0038CB60 File Offset: 0x0038AD60
			public GetPathData GetPathInfo
			{
				set
				{
					this.m_owner.GetPathInfo = value;
				}
			}

			// Token: 0x0600CE8F RID: 52879 RVA: 0x0038CB70 File Offset: 0x0038AD70
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0600CE90 RID: 52880 RVA: 0x0038CB80 File Offset: 0x0038AD80
			public void OnGotoButtonClick()
			{
				this.m_owner.OnGotoButtonClick();
			}

			// Token: 0x04008128 RID: 33064
			private GetPathItemUIController m_owner;
		}
	}
}
