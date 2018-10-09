using System;
using System.Threading;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectLBasic;
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000BE4 RID: 3044
	[HotFix]
	public class PlayerResourceUIController : UIControllerBase
	{
		// Token: 0x0600D27E RID: 53886 RVA: 0x00397A60 File Offset: 0x00395C60
		private PlayerResourceUIController()
		{
		}

		// Token: 0x0600D27F RID: 53887 RVA: 0x00397A68 File Offset: 0x00395C68
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
			this.m_goldText = Utility.FindChildComponent<Text>(base.gameObject, "Gold/Text", false);
			this.m_addGoldButton = Utility.FindChildComponent<Button>(base.gameObject, "Gold/AddButton", false);
			this.m_crystalText = Utility.FindChildComponent<Text>(base.gameObject, "Crystal/Text", false);
			this.m_addCrystalButton = Utility.FindChildComponent<Button>(base.gameObject, "Crystal/AddButton", false);
			this.m_energyText = Utility.FindChildComponent<Text>(base.gameObject, "Energy/Text", false);
			this.m_addEnergyButton = Utility.FindChildComponent<Button>(base.gameObject, "Energy/AddButton", false);
			this.m_energyStatusButton = Utility.FindChildComponent<Button>(base.gameObject, "Energy/StatusButton", false);
			if (this.m_addGoldButton != null)
			{
				this.m_addGoldButton.onClick.AddListener(new UnityAction(this.OnAddGoldButtonClick));
			}
			if (this.m_addCrystalButton != null)
			{
				this.m_addCrystalButton.onClick.AddListener(new UnityAction(this.OnAddCrystalButtonClick));
			}
			if (this.m_addEnergyButton != null)
			{
				this.m_addEnergyButton.onClick.AddListener(new UnityAction(this.OnAddEnergyButtonClick));
			}
			if (this.m_energyStatusButton != null)
			{
				this.m_energyStatusButton.onClick.AddListener(new UnityAction(this.OnEnergyStatusButtonClick));
			}
		}

		// Token: 0x0600D280 RID: 53888 RVA: 0x00397C24 File Offset: 0x00395E24
		private void OnEnable()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnEnable_hotfix != null)
			{
				this.m_OnEnable_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnPlayerInfoChangeNtf += this.PlayerContext_OnPlayerInfoChangeNtf;
			}
		}

		// Token: 0x0600D281 RID: 53889 RVA: 0x00397CAC File Offset: 0x00395EAC
		private void OnDisable()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnDisable_hotfix != null)
			{
				this.m_OnDisable_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnPlayerInfoChangeNtf -= this.PlayerContext_OnPlayerInfoChangeNtf;
			}
		}

		// Token: 0x0600D282 RID: 53890 RVA: 0x00397D34 File Offset: 0x00395F34
		private void OnDestroy()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnDestroy_hotfix != null)
			{
				this.m_OnDestroy_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_buyEnergyUITask != null)
			{
				this.m_buyEnergyUITask.Stop();
				this.m_buyEnergyUITask = null;
			}
		}

		// Token: 0x0600D283 RID: 53891 RVA: 0x00397DB4 File Offset: 0x00395FB4
		public void UpdatePlayerResource()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdatePlayerResource_hotfix != null)
			{
				this.m_UpdatePlayerResource_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			this.SetGoldCount(projectLPlayerContext.GetGold());
			this.SetCrystalCount(projectLPlayerContext.GetCrystal());
			this.SetEnergy(projectLPlayerContext.GetEnergy(), projectLPlayerContext.GetEnergyMax());
		}

		// Token: 0x0600D284 RID: 53892 RVA: 0x00397E50 File Offset: 0x00396050
		private void SetGoldCount(int count)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetGoldCountInt32_hotfix != null)
			{
				this.m_SetGoldCountInt32_hotfix.call(new object[]
				{
					this,
					count
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_goldText != null)
			{
				this.m_goldText.text = count.ToString();
			}
		}

		// Token: 0x0600D285 RID: 53893 RVA: 0x00397EEC File Offset: 0x003960EC
		private void SetCrystalCount(int count)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetCrystalCountInt32_hotfix != null)
			{
				this.m_SetCrystalCountInt32_hotfix.call(new object[]
				{
					this,
					count
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_crystalText != null)
			{
				this.m_crystalText.text = count.ToString();
			}
		}

		// Token: 0x0600D286 RID: 53894 RVA: 0x00397F88 File Offset: 0x00396188
		private void SetEnergy(int count, int max)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetEnergyInt32Int32_hotfix != null)
			{
				this.m_SetEnergyInt32Int32_hotfix.call(new object[]
				{
					this,
					count,
					max
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_energyText != null)
			{
				this.m_energyText.text = count + "/" + max;
			}
		}

		// Token: 0x0600D287 RID: 53895 RVA: 0x0039803C File Offset: 0x0039623C
		private void OnAddGoldButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnAddGoldButtonClick_hotfix != null)
			{
				this.m_OnAddGoldButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnAddGold != null)
			{
				this.EventOnAddGold();
			}
		}

		// Token: 0x0600D288 RID: 53896 RVA: 0x003980B4 File Offset: 0x003962B4
		private void OnAddCrystalButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnAddCrystalButtonClick_hotfix != null)
			{
				this.m_OnAddCrystalButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnAddCrystal != null)
			{
				this.EventOnAddCrystal();
			}
		}

		// Token: 0x0600D289 RID: 53897 RVA: 0x0039812C File Offset: 0x0039632C
		private void OnAddEnergyButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnAddEnergyButtonClick_hotfix != null)
			{
				this.m_OnAddEnergyButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_buyEnergyUITask = BuyEnergyUITask.StartUITask(false);
		}

		// Token: 0x0600D28A RID: 53898 RVA: 0x00398198 File Offset: 0x00396398
		private void OnEnergyStatusButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnEnergyStatusButtonClick_hotfix != null)
			{
				this.m_OnEnergyStatusButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			RectTransform rectTransform = this.m_energyStatusButton.transform as RectTransform;
			Vector3 position = rectTransform.position;
			EnergyStatusUITask.StartUITask(position);
		}

		// Token: 0x0600D28B RID: 53899 RVA: 0x00398218 File Offset: 0x00396418
		private void PlayerContext_OnPlayerInfoChangeNtf()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayerContext_OnPlayerInfoChangeNtf_hotfix != null)
			{
				this.m_PlayerContext_OnPlayerInfoChangeNtf_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.UpdatePlayerResource();
		}

		// Token: 0x1400028A RID: 650
		// (add) Token: 0x0600D28C RID: 53900 RVA: 0x00398280 File Offset: 0x00396480
		// (remove) Token: 0x0600D28D RID: 53901 RVA: 0x0039831C File Offset: 0x0039651C
		public event Action EventOnAddGold
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnAddGoldAction_hotfix != null)
				{
					this.m_add_EventOnAddGoldAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnAddGold;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnAddGold, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnAddGoldAction_hotfix != null)
				{
					this.m_remove_EventOnAddGoldAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnAddGold;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnAddGold, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1400028B RID: 651
		// (add) Token: 0x0600D28E RID: 53902 RVA: 0x003983B8 File Offset: 0x003965B8
		// (remove) Token: 0x0600D28F RID: 53903 RVA: 0x00398454 File Offset: 0x00396654
		public event Action EventOnAddCrystal
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnAddCrystalAction_hotfix != null)
				{
					this.m_add_EventOnAddCrystalAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnAddCrystal;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnAddCrystal, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnAddCrystalAction_hotfix != null)
				{
					this.m_remove_EventOnAddCrystalAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnAddCrystal;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnAddCrystal, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17002957 RID: 10583
		// (get) Token: 0x0600D290 RID: 53904 RVA: 0x003984F0 File Offset: 0x003966F0
		// (set) Token: 0x0600D291 RID: 53905 RVA: 0x00398510 File Offset: 0x00396710
		[DoNotToLua]
		public new PlayerResourceUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new PlayerResourceUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600D292 RID: 53906 RVA: 0x0039851C File Offset: 0x0039671C
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0600D293 RID: 53907 RVA: 0x00398528 File Offset: 0x00396728
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0600D294 RID: 53908 RVA: 0x00398530 File Offset: 0x00396730
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0600D295 RID: 53909 RVA: 0x00398538 File Offset: 0x00396738
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0600D296 RID: 53910 RVA: 0x0039854C File Offset: 0x0039674C
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0600D297 RID: 53911 RVA: 0x00398554 File Offset: 0x00396754
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0600D298 RID: 53912 RVA: 0x00398560 File Offset: 0x00396760
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0600D299 RID: 53913 RVA: 0x0039856C File Offset: 0x0039676C
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0600D29A RID: 53914 RVA: 0x00398578 File Offset: 0x00396778
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0600D29B RID: 53915 RVA: 0x00398584 File Offset: 0x00396784
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0600D29C RID: 53916 RVA: 0x00398590 File Offset: 0x00396790
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0600D29D RID: 53917 RVA: 0x0039859C File Offset: 0x0039679C
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0600D29E RID: 53918 RVA: 0x003985A8 File Offset: 0x003967A8
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0600D29F RID: 53919 RVA: 0x003985B4 File Offset: 0x003967B4
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0600D2A0 RID: 53920 RVA: 0x003985C0 File Offset: 0x003967C0
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600D2A1 RID: 53921 RVA: 0x003985C8 File Offset: 0x003967C8
		private void __callDele_EventOnAddGold()
		{
			Action eventOnAddGold = this.EventOnAddGold;
			if (eventOnAddGold != null)
			{
				eventOnAddGold();
			}
		}

		// Token: 0x0600D2A2 RID: 53922 RVA: 0x003985E8 File Offset: 0x003967E8
		private void __clearDele_EventOnAddGold()
		{
			this.EventOnAddGold = null;
		}

		// Token: 0x0600D2A3 RID: 53923 RVA: 0x003985F4 File Offset: 0x003967F4
		private void __callDele_EventOnAddCrystal()
		{
			Action eventOnAddCrystal = this.EventOnAddCrystal;
			if (eventOnAddCrystal != null)
			{
				eventOnAddCrystal();
			}
		}

		// Token: 0x0600D2A4 RID: 53924 RVA: 0x00398614 File Offset: 0x00396814
		private void __clearDele_EventOnAddCrystal()
		{
			this.EventOnAddCrystal = null;
		}

		// Token: 0x0600D2A5 RID: 53925 RVA: 0x00398620 File Offset: 0x00396820
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
					this.m_OnEnable_hotfix = (luaObj.RawGet("OnEnable") as LuaFunction);
					this.m_OnDisable_hotfix = (luaObj.RawGet("OnDisable") as LuaFunction);
					this.m_OnDestroy_hotfix = (luaObj.RawGet("OnDestroy") as LuaFunction);
					this.m_UpdatePlayerResource_hotfix = (luaObj.RawGet("UpdatePlayerResource") as LuaFunction);
					this.m_SetGoldCountInt32_hotfix = (luaObj.RawGet("SetGoldCount") as LuaFunction);
					this.m_SetCrystalCountInt32_hotfix = (luaObj.RawGet("SetCrystalCount") as LuaFunction);
					this.m_SetEnergyInt32Int32_hotfix = (luaObj.RawGet("SetEnergy") as LuaFunction);
					this.m_OnAddGoldButtonClick_hotfix = (luaObj.RawGet("OnAddGoldButtonClick") as LuaFunction);
					this.m_OnAddCrystalButtonClick_hotfix = (luaObj.RawGet("OnAddCrystalButtonClick") as LuaFunction);
					this.m_OnAddEnergyButtonClick_hotfix = (luaObj.RawGet("OnAddEnergyButtonClick") as LuaFunction);
					this.m_OnEnergyStatusButtonClick_hotfix = (luaObj.RawGet("OnEnergyStatusButtonClick") as LuaFunction);
					this.m_PlayerContext_OnPlayerInfoChangeNtf_hotfix = (luaObj.RawGet("PlayerContext_OnPlayerInfoChangeNtf") as LuaFunction);
					this.m_add_EventOnAddGoldAction_hotfix = (luaObj.RawGet("add_EventOnAddGold") as LuaFunction);
					this.m_remove_EventOnAddGoldAction_hotfix = (luaObj.RawGet("remove_EventOnAddGold") as LuaFunction);
					this.m_add_EventOnAddCrystalAction_hotfix = (luaObj.RawGet("add_EventOnAddCrystal") as LuaFunction);
					this.m_remove_EventOnAddCrystalAction_hotfix = (luaObj.RawGet("remove_EventOnAddCrystal") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600D2A6 RID: 53926 RVA: 0x0039887C File Offset: 0x00396A7C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(PlayerResourceUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400827E RID: 33406
		private Text m_goldText;

		// Token: 0x0400827F RID: 33407
		private Button m_addGoldButton;

		// Token: 0x04008280 RID: 33408
		private Text m_crystalText;

		// Token: 0x04008281 RID: 33409
		private Button m_addCrystalButton;

		// Token: 0x04008282 RID: 33410
		private Text m_energyText;

		// Token: 0x04008283 RID: 33411
		private Button m_addEnergyButton;

		// Token: 0x04008284 RID: 33412
		private Button m_energyStatusButton;

		// Token: 0x04008285 RID: 33413
		private BuyEnergyUITask m_buyEnergyUITask;

		// Token: 0x04008286 RID: 33414
		[DoNotToLua]
		private PlayerResourceUIController.LuaExportHelper luaExportHelper;

		// Token: 0x04008287 RID: 33415
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04008288 RID: 33416
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04008289 RID: 33417
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x0400828A RID: 33418
		private LuaFunction m_OnEnable_hotfix;

		// Token: 0x0400828B RID: 33419
		private LuaFunction m_OnDisable_hotfix;

		// Token: 0x0400828C RID: 33420
		private LuaFunction m_OnDestroy_hotfix;

		// Token: 0x0400828D RID: 33421
		private LuaFunction m_UpdatePlayerResource_hotfix;

		// Token: 0x0400828E RID: 33422
		private LuaFunction m_SetGoldCountInt32_hotfix;

		// Token: 0x0400828F RID: 33423
		private LuaFunction m_SetCrystalCountInt32_hotfix;

		// Token: 0x04008290 RID: 33424
		private LuaFunction m_SetEnergyInt32Int32_hotfix;

		// Token: 0x04008291 RID: 33425
		private LuaFunction m_OnAddGoldButtonClick_hotfix;

		// Token: 0x04008292 RID: 33426
		private LuaFunction m_OnAddCrystalButtonClick_hotfix;

		// Token: 0x04008293 RID: 33427
		private LuaFunction m_OnAddEnergyButtonClick_hotfix;

		// Token: 0x04008294 RID: 33428
		private LuaFunction m_OnEnergyStatusButtonClick_hotfix;

		// Token: 0x04008295 RID: 33429
		private LuaFunction m_PlayerContext_OnPlayerInfoChangeNtf_hotfix;

		// Token: 0x04008296 RID: 33430
		private LuaFunction m_add_EventOnAddGoldAction_hotfix;

		// Token: 0x04008297 RID: 33431
		private LuaFunction m_remove_EventOnAddGoldAction_hotfix;

		// Token: 0x04008298 RID: 33432
		private LuaFunction m_add_EventOnAddCrystalAction_hotfix;

		// Token: 0x04008299 RID: 33433
		private LuaFunction m_remove_EventOnAddCrystalAction_hotfix;

		// Token: 0x02000BE5 RID: 3045
		public new class LuaExportHelper
		{
			// Token: 0x0600D2A7 RID: 53927 RVA: 0x003988E4 File Offset: 0x00396AE4
			public LuaExportHelper(PlayerResourceUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600D2A8 RID: 53928 RVA: 0x003988F4 File Offset: 0x00396AF4
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0600D2A9 RID: 53929 RVA: 0x00398904 File Offset: 0x00396B04
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0600D2AA RID: 53930 RVA: 0x00398914 File Offset: 0x00396B14
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600D2AB RID: 53931 RVA: 0x00398924 File Offset: 0x00396B24
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600D2AC RID: 53932 RVA: 0x0039893C File Offset: 0x00396B3C
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0600D2AD RID: 53933 RVA: 0x0039894C File Offset: 0x00396B4C
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0600D2AE RID: 53934 RVA: 0x0039895C File Offset: 0x00396B5C
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0600D2AF RID: 53935 RVA: 0x0039896C File Offset: 0x00396B6C
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0600D2B0 RID: 53936 RVA: 0x0039897C File Offset: 0x00396B7C
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0600D2B1 RID: 53937 RVA: 0x0039898C File Offset: 0x00396B8C
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0600D2B2 RID: 53938 RVA: 0x0039899C File Offset: 0x00396B9C
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0600D2B3 RID: 53939 RVA: 0x003989AC File Offset: 0x00396BAC
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0600D2B4 RID: 53940 RVA: 0x003989BC File Offset: 0x00396BBC
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0600D2B5 RID: 53941 RVA: 0x003989CC File Offset: 0x00396BCC
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0600D2B6 RID: 53942 RVA: 0x003989DC File Offset: 0x00396BDC
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x0600D2B7 RID: 53943 RVA: 0x003989EC File Offset: 0x00396BEC
			public void __callDele_EventOnAddGold()
			{
				this.m_owner.__callDele_EventOnAddGold();
			}

			// Token: 0x0600D2B8 RID: 53944 RVA: 0x003989FC File Offset: 0x00396BFC
			public void __clearDele_EventOnAddGold()
			{
				this.m_owner.__clearDele_EventOnAddGold();
			}

			// Token: 0x0600D2B9 RID: 53945 RVA: 0x00398A0C File Offset: 0x00396C0C
			public void __callDele_EventOnAddCrystal()
			{
				this.m_owner.__callDele_EventOnAddCrystal();
			}

			// Token: 0x0600D2BA RID: 53946 RVA: 0x00398A1C File Offset: 0x00396C1C
			public void __clearDele_EventOnAddCrystal()
			{
				this.m_owner.__clearDele_EventOnAddCrystal();
			}

			// Token: 0x17002958 RID: 10584
			// (get) Token: 0x0600D2BB RID: 53947 RVA: 0x00398A2C File Offset: 0x00396C2C
			// (set) Token: 0x0600D2BC RID: 53948 RVA: 0x00398A3C File Offset: 0x00396C3C
			public Text m_goldText
			{
				get
				{
					return this.m_owner.m_goldText;
				}
				set
				{
					this.m_owner.m_goldText = value;
				}
			}

			// Token: 0x17002959 RID: 10585
			// (get) Token: 0x0600D2BD RID: 53949 RVA: 0x00398A4C File Offset: 0x00396C4C
			// (set) Token: 0x0600D2BE RID: 53950 RVA: 0x00398A5C File Offset: 0x00396C5C
			public Button m_addGoldButton
			{
				get
				{
					return this.m_owner.m_addGoldButton;
				}
				set
				{
					this.m_owner.m_addGoldButton = value;
				}
			}

			// Token: 0x1700295A RID: 10586
			// (get) Token: 0x0600D2BF RID: 53951 RVA: 0x00398A6C File Offset: 0x00396C6C
			// (set) Token: 0x0600D2C0 RID: 53952 RVA: 0x00398A7C File Offset: 0x00396C7C
			public Text m_crystalText
			{
				get
				{
					return this.m_owner.m_crystalText;
				}
				set
				{
					this.m_owner.m_crystalText = value;
				}
			}

			// Token: 0x1700295B RID: 10587
			// (get) Token: 0x0600D2C1 RID: 53953 RVA: 0x00398A8C File Offset: 0x00396C8C
			// (set) Token: 0x0600D2C2 RID: 53954 RVA: 0x00398A9C File Offset: 0x00396C9C
			public Button m_addCrystalButton
			{
				get
				{
					return this.m_owner.m_addCrystalButton;
				}
				set
				{
					this.m_owner.m_addCrystalButton = value;
				}
			}

			// Token: 0x1700295C RID: 10588
			// (get) Token: 0x0600D2C3 RID: 53955 RVA: 0x00398AAC File Offset: 0x00396CAC
			// (set) Token: 0x0600D2C4 RID: 53956 RVA: 0x00398ABC File Offset: 0x00396CBC
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

			// Token: 0x1700295D RID: 10589
			// (get) Token: 0x0600D2C5 RID: 53957 RVA: 0x00398ACC File Offset: 0x00396CCC
			// (set) Token: 0x0600D2C6 RID: 53958 RVA: 0x00398ADC File Offset: 0x00396CDC
			public Button m_addEnergyButton
			{
				get
				{
					return this.m_owner.m_addEnergyButton;
				}
				set
				{
					this.m_owner.m_addEnergyButton = value;
				}
			}

			// Token: 0x1700295E RID: 10590
			// (get) Token: 0x0600D2C7 RID: 53959 RVA: 0x00398AEC File Offset: 0x00396CEC
			// (set) Token: 0x0600D2C8 RID: 53960 RVA: 0x00398AFC File Offset: 0x00396CFC
			public Button m_energyStatusButton
			{
				get
				{
					return this.m_owner.m_energyStatusButton;
				}
				set
				{
					this.m_owner.m_energyStatusButton = value;
				}
			}

			// Token: 0x1700295F RID: 10591
			// (get) Token: 0x0600D2C9 RID: 53961 RVA: 0x00398B0C File Offset: 0x00396D0C
			// (set) Token: 0x0600D2CA RID: 53962 RVA: 0x00398B1C File Offset: 0x00396D1C
			public BuyEnergyUITask m_buyEnergyUITask
			{
				get
				{
					return this.m_owner.m_buyEnergyUITask;
				}
				set
				{
					this.m_owner.m_buyEnergyUITask = value;
				}
			}

			// Token: 0x0600D2CB RID: 53963 RVA: 0x00398B2C File Offset: 0x00396D2C
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0600D2CC RID: 53964 RVA: 0x00398B3C File Offset: 0x00396D3C
			public void OnEnable()
			{
				this.m_owner.OnEnable();
			}

			// Token: 0x0600D2CD RID: 53965 RVA: 0x00398B4C File Offset: 0x00396D4C
			public void OnDisable()
			{
				this.m_owner.OnDisable();
			}

			// Token: 0x0600D2CE RID: 53966 RVA: 0x00398B5C File Offset: 0x00396D5C
			public void OnDestroy()
			{
				this.m_owner.OnDestroy();
			}

			// Token: 0x0600D2CF RID: 53967 RVA: 0x00398B6C File Offset: 0x00396D6C
			public void SetGoldCount(int count)
			{
				this.m_owner.SetGoldCount(count);
			}

			// Token: 0x0600D2D0 RID: 53968 RVA: 0x00398B7C File Offset: 0x00396D7C
			public void SetCrystalCount(int count)
			{
				this.m_owner.SetCrystalCount(count);
			}

			// Token: 0x0600D2D1 RID: 53969 RVA: 0x00398B8C File Offset: 0x00396D8C
			public void SetEnergy(int count, int max)
			{
				this.m_owner.SetEnergy(count, max);
			}

			// Token: 0x0600D2D2 RID: 53970 RVA: 0x00398B9C File Offset: 0x00396D9C
			public void OnAddGoldButtonClick()
			{
				this.m_owner.OnAddGoldButtonClick();
			}

			// Token: 0x0600D2D3 RID: 53971 RVA: 0x00398BAC File Offset: 0x00396DAC
			public void OnAddCrystalButtonClick()
			{
				this.m_owner.OnAddCrystalButtonClick();
			}

			// Token: 0x0600D2D4 RID: 53972 RVA: 0x00398BBC File Offset: 0x00396DBC
			public void OnAddEnergyButtonClick()
			{
				this.m_owner.OnAddEnergyButtonClick();
			}

			// Token: 0x0600D2D5 RID: 53973 RVA: 0x00398BCC File Offset: 0x00396DCC
			public void OnEnergyStatusButtonClick()
			{
				this.m_owner.OnEnergyStatusButtonClick();
			}

			// Token: 0x0600D2D6 RID: 53974 RVA: 0x00398BDC File Offset: 0x00396DDC
			public void PlayerContext_OnPlayerInfoChangeNtf()
			{
				this.m_owner.PlayerContext_OnPlayerInfoChangeNtf();
			}

			// Token: 0x0400829A RID: 33434
			private PlayerResourceUIController m_owner;
		}
	}
}
