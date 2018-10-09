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
	// Token: 0x02000E73 RID: 3699
	[HotFix]
	public class MemoryCorridorLevelListItemUIController : UIControllerBase
	{
		// Token: 0x06011F31 RID: 73521 RVA: 0x004A27E4 File Offset: 0x004A09E4
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

		// Token: 0x06011F32 RID: 73522 RVA: 0x004A2884 File Offset: 0x004A0A84
		public void SetMemoryCorridorLevelInfo(ConfigDataMemoryCorridorLevelInfo levelInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetMemoryCorridorLevelInfoConfigDataMemoryCorridorLevelInfo_hotfix != null)
			{
				this.m_SetMemoryCorridorLevelInfoConfigDataMemoryCorridorLevelInfo_hotfix.call(new object[]
				{
					this,
					levelInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_memoryCorridorLevelInfo = levelInfo;
			this.m_levelText.text = levelInfo.MonsterLevel.ToString();
			this.m_energyText.text = levelInfo.EnergySuccess.ToString();
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

		// Token: 0x06011F33 RID: 73523 RVA: 0x004A29A4 File Offset: 0x004A0BA4
		public ConfigDataMemoryCorridorLevelInfo GetMemoryCorridorLevelInfo()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetMemoryCorridorLevelInfo_hotfix != null)
			{
				return (ConfigDataMemoryCorridorLevelInfo)this.m_GetMemoryCorridorLevelInfo_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_memoryCorridorLevelInfo;
		}

		// Token: 0x06011F34 RID: 73524 RVA: 0x004A2A18 File Offset: 0x004A0C18
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
				this.m_lockedText.text = string.Format(configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Msg_AchieveLevelOpen), this.m_memoryCorridorLevelInfo.OpenPlayerLevel);
			}
			this.m_lockedButton.gameObject.SetActive(locked);
		}

		// Token: 0x06011F35 RID: 73525 RVA: 0x004A2AE8 File Offset: 0x004A0CE8
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

		// Token: 0x06011F36 RID: 73526 RVA: 0x004A2B60 File Offset: 0x004A0D60
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
			string txt = string.Format(configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Msg_AchieveLevelOpen), this.m_memoryCorridorLevelInfo.OpenPlayerLevel);
			CommonUIController.Instance.ShowMessage(txt, 2f, null, true);
		}

		// Token: 0x140003DD RID: 989
		// (add) Token: 0x06011F37 RID: 73527 RVA: 0x004A2C04 File Offset: 0x004A0E04
		// (remove) Token: 0x06011F38 RID: 73528 RVA: 0x004A2CA0 File Offset: 0x004A0EA0
		public event Action<MemoryCorridorLevelListItemUIController> EventOnStartButtonClick
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
				Action<MemoryCorridorLevelListItemUIController> action = this.EventOnStartButtonClick;
				Action<MemoryCorridorLevelListItemUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<MemoryCorridorLevelListItemUIController>>(ref this.EventOnStartButtonClick, (Action<MemoryCorridorLevelListItemUIController>)Delegate.Combine(action2, value), action);
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
				Action<MemoryCorridorLevelListItemUIController> action = this.EventOnStartButtonClick;
				Action<MemoryCorridorLevelListItemUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<MemoryCorridorLevelListItemUIController>>(ref this.EventOnStartButtonClick, (Action<MemoryCorridorLevelListItemUIController>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x170036DD RID: 14045
		// (get) Token: 0x06011F39 RID: 73529 RVA: 0x004A2D3C File Offset: 0x004A0F3C
		// (set) Token: 0x06011F3A RID: 73530 RVA: 0x004A2D5C File Offset: 0x004A0F5C
		[DoNotToLua]
		public new MemoryCorridorLevelListItemUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new MemoryCorridorLevelListItemUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06011F3B RID: 73531 RVA: 0x004A2D68 File Offset: 0x004A0F68
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x06011F3C RID: 73532 RVA: 0x004A2D74 File Offset: 0x004A0F74
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x06011F3D RID: 73533 RVA: 0x004A2D7C File Offset: 0x004A0F7C
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x06011F3E RID: 73534 RVA: 0x004A2D84 File Offset: 0x004A0F84
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x06011F3F RID: 73535 RVA: 0x004A2D98 File Offset: 0x004A0F98
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x06011F40 RID: 73536 RVA: 0x004A2DA0 File Offset: 0x004A0FA0
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x06011F41 RID: 73537 RVA: 0x004A2DAC File Offset: 0x004A0FAC
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x06011F42 RID: 73538 RVA: 0x004A2DB8 File Offset: 0x004A0FB8
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x06011F43 RID: 73539 RVA: 0x004A2DC4 File Offset: 0x004A0FC4
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x06011F44 RID: 73540 RVA: 0x004A2DD0 File Offset: 0x004A0FD0
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x06011F45 RID: 73541 RVA: 0x004A2DDC File Offset: 0x004A0FDC
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x06011F46 RID: 73542 RVA: 0x004A2DE8 File Offset: 0x004A0FE8
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x06011F47 RID: 73543 RVA: 0x004A2DF4 File Offset: 0x004A0FF4
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x06011F48 RID: 73544 RVA: 0x004A2E00 File Offset: 0x004A1000
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x06011F49 RID: 73545 RVA: 0x004A2E0C File Offset: 0x004A100C
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x06011F4A RID: 73546 RVA: 0x004A2E14 File Offset: 0x004A1014
		private void __callDele_EventOnStartButtonClick(MemoryCorridorLevelListItemUIController obj)
		{
			Action<MemoryCorridorLevelListItemUIController> eventOnStartButtonClick = this.EventOnStartButtonClick;
			if (eventOnStartButtonClick != null)
			{
				eventOnStartButtonClick(obj);
			}
		}

		// Token: 0x06011F4B RID: 73547 RVA: 0x004A2E38 File Offset: 0x004A1038
		private void __clearDele_EventOnStartButtonClick(MemoryCorridorLevelListItemUIController obj)
		{
			this.EventOnStartButtonClick = null;
		}

		// Token: 0x06011F4C RID: 73548 RVA: 0x004A2E44 File Offset: 0x004A1044
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
					this.m_SetMemoryCorridorLevelInfoConfigDataMemoryCorridorLevelInfo_hotfix = (luaObj.RawGet("SetMemoryCorridorLevelInfo") as LuaFunction);
					this.m_GetMemoryCorridorLevelInfo_hotfix = (luaObj.RawGet("GetMemoryCorridorLevelInfo") as LuaFunction);
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

		// Token: 0x06011F4D RID: 73549 RVA: 0x004A2FC0 File Offset: 0x004A11C0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(MemoryCorridorLevelListItemUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400A2D4 RID: 41684
		[AutoBind("./Level/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_levelText;

		// Token: 0x0400A2D5 RID: 41685
		[AutoBind("./EnergyValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_energyText;

		// Token: 0x0400A2D6 RID: 41686
		[AutoBind("./Locked", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_lockedButton;

		// Token: 0x0400A2D7 RID: 41687
		[AutoBind("./StartButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_startButton;

		// Token: 0x0400A2D8 RID: 41688
		[AutoBind("./RewardGroup", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_rewardGroupGameObject;

		// Token: 0x0400A2D9 RID: 41689
		[AutoBind("./Locked/TextGroup", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_lockedText;

		// Token: 0x0400A2DA RID: 41690
		private ConfigDataMemoryCorridorLevelInfo m_memoryCorridorLevelInfo;

		// Token: 0x0400A2DB RID: 41691
		[DoNotToLua]
		private MemoryCorridorLevelListItemUIController.LuaExportHelper luaExportHelper;

		// Token: 0x0400A2DC RID: 41692
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400A2DD RID: 41693
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400A2DE RID: 41694
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x0400A2DF RID: 41695
		private LuaFunction m_SetMemoryCorridorLevelInfoConfigDataMemoryCorridorLevelInfo_hotfix;

		// Token: 0x0400A2E0 RID: 41696
		private LuaFunction m_GetMemoryCorridorLevelInfo_hotfix;

		// Token: 0x0400A2E1 RID: 41697
		private LuaFunction m_SetLockedBoolean_hotfix;

		// Token: 0x0400A2E2 RID: 41698
		private LuaFunction m_OnStartButtonClick_hotfix;

		// Token: 0x0400A2E3 RID: 41699
		private LuaFunction m_OnLockedButtonClick_hotfix;

		// Token: 0x0400A2E4 RID: 41700
		private LuaFunction m_add_EventOnStartButtonClickAction;

		// Token: 0x0400A2E5 RID: 41701
		private LuaFunction m_remove_EventOnStartButtonClickAction;

		// Token: 0x02000E74 RID: 3700
		public new class LuaExportHelper
		{
			// Token: 0x06011F4E RID: 73550 RVA: 0x004A3028 File Offset: 0x004A1228
			public LuaExportHelper(MemoryCorridorLevelListItemUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06011F4F RID: 73551 RVA: 0x004A3038 File Offset: 0x004A1238
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x06011F50 RID: 73552 RVA: 0x004A3048 File Offset: 0x004A1248
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x06011F51 RID: 73553 RVA: 0x004A3058 File Offset: 0x004A1258
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x06011F52 RID: 73554 RVA: 0x004A3068 File Offset: 0x004A1268
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x06011F53 RID: 73555 RVA: 0x004A3080 File Offset: 0x004A1280
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x06011F54 RID: 73556 RVA: 0x004A3090 File Offset: 0x004A1290
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x06011F55 RID: 73557 RVA: 0x004A30A0 File Offset: 0x004A12A0
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x06011F56 RID: 73558 RVA: 0x004A30B0 File Offset: 0x004A12B0
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x06011F57 RID: 73559 RVA: 0x004A30C0 File Offset: 0x004A12C0
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x06011F58 RID: 73560 RVA: 0x004A30D0 File Offset: 0x004A12D0
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x06011F59 RID: 73561 RVA: 0x004A30E0 File Offset: 0x004A12E0
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x06011F5A RID: 73562 RVA: 0x004A30F0 File Offset: 0x004A12F0
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x06011F5B RID: 73563 RVA: 0x004A3100 File Offset: 0x004A1300
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x06011F5C RID: 73564 RVA: 0x004A3110 File Offset: 0x004A1310
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x06011F5D RID: 73565 RVA: 0x004A3120 File Offset: 0x004A1320
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x06011F5E RID: 73566 RVA: 0x004A3130 File Offset: 0x004A1330
			public void __callDele_EventOnStartButtonClick(MemoryCorridorLevelListItemUIController obj)
			{
				this.m_owner.__callDele_EventOnStartButtonClick(obj);
			}

			// Token: 0x06011F5F RID: 73567 RVA: 0x004A3140 File Offset: 0x004A1340
			public void __clearDele_EventOnStartButtonClick(MemoryCorridorLevelListItemUIController obj)
			{
				this.m_owner.__clearDele_EventOnStartButtonClick(obj);
			}

			// Token: 0x170036DE RID: 14046
			// (get) Token: 0x06011F60 RID: 73568 RVA: 0x004A3150 File Offset: 0x004A1350
			// (set) Token: 0x06011F61 RID: 73569 RVA: 0x004A3160 File Offset: 0x004A1360
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

			// Token: 0x170036DF RID: 14047
			// (get) Token: 0x06011F62 RID: 73570 RVA: 0x004A3170 File Offset: 0x004A1370
			// (set) Token: 0x06011F63 RID: 73571 RVA: 0x004A3180 File Offset: 0x004A1380
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

			// Token: 0x170036E0 RID: 14048
			// (get) Token: 0x06011F64 RID: 73572 RVA: 0x004A3190 File Offset: 0x004A1390
			// (set) Token: 0x06011F65 RID: 73573 RVA: 0x004A31A0 File Offset: 0x004A13A0
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

			// Token: 0x170036E1 RID: 14049
			// (get) Token: 0x06011F66 RID: 73574 RVA: 0x004A31B0 File Offset: 0x004A13B0
			// (set) Token: 0x06011F67 RID: 73575 RVA: 0x004A31C0 File Offset: 0x004A13C0
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

			// Token: 0x170036E2 RID: 14050
			// (get) Token: 0x06011F68 RID: 73576 RVA: 0x004A31D0 File Offset: 0x004A13D0
			// (set) Token: 0x06011F69 RID: 73577 RVA: 0x004A31E0 File Offset: 0x004A13E0
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

			// Token: 0x170036E3 RID: 14051
			// (get) Token: 0x06011F6A RID: 73578 RVA: 0x004A31F0 File Offset: 0x004A13F0
			// (set) Token: 0x06011F6B RID: 73579 RVA: 0x004A3200 File Offset: 0x004A1400
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

			// Token: 0x170036E4 RID: 14052
			// (get) Token: 0x06011F6C RID: 73580 RVA: 0x004A3210 File Offset: 0x004A1410
			// (set) Token: 0x06011F6D RID: 73581 RVA: 0x004A3220 File Offset: 0x004A1420
			public ConfigDataMemoryCorridorLevelInfo m_memoryCorridorLevelInfo
			{
				get
				{
					return this.m_owner.m_memoryCorridorLevelInfo;
				}
				set
				{
					this.m_owner.m_memoryCorridorLevelInfo = value;
				}
			}

			// Token: 0x06011F6E RID: 73582 RVA: 0x004A3230 File Offset: 0x004A1430
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x06011F6F RID: 73583 RVA: 0x004A3240 File Offset: 0x004A1440
			public void OnStartButtonClick()
			{
				this.m_owner.OnStartButtonClick();
			}

			// Token: 0x06011F70 RID: 73584 RVA: 0x004A3250 File Offset: 0x004A1450
			public void OnLockedButtonClick()
			{
				this.m_owner.OnLockedButtonClick();
			}

			// Token: 0x0400A2E6 RID: 41702
			private MemoryCorridorLevelListItemUIController m_owner;
		}
	}
}
