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
	// Token: 0x02001037 RID: 4151
	[HotFix]
	public class PastScenarioListItemUIController : UIControllerBase
	{
		// Token: 0x06015220 RID: 86560 RVA: 0x00557D84 File Offset: 0x00555F84
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
		}

		// Token: 0x06015221 RID: 86561 RVA: 0x00557E08 File Offset: 0x00556008
		public void SetScenarioInfo(ConfigDataScenarioInfo scenarioInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetScenarioInfoConfigDataScenarioInfo_hotfix != null)
			{
				this.m_SetScenarioInfoConfigDataScenarioInfo_hotfix.call(new object[]
				{
					this,
					scenarioInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_scenarioInfo = scenarioInfo;
			this.m_nameText.text = scenarioInfo.Name;
			this.m_levelText.text = scenarioInfo.MonsterLevel.ToString();
			this.m_energyText.text = scenarioInfo.EnergySuccess.ToString();
			GameObjectUtility.DestroyChildren(this.m_rewardGoodsListGameObject);
			List<Goods> goods = new List<Goods>();
			UIUtility.AppendRandomDropRewardGoodsToList(scenarioInfo.Drop_ID, goods);
			GameObject assetInContainer = base.GetAssetInContainer<GameObject>("RewardGoods");
			RewardGoodsUIController.CreateRewardGoodsList(goods, this.m_rewardGoodsListGameObject.transform, assetInContainer, null, false, 0, true);
		}

		// Token: 0x06015222 RID: 86562 RVA: 0x00557F10 File Offset: 0x00556110
		public ConfigDataScenarioInfo GetScenarioInfo()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetScenarioInfo_hotfix != null)
			{
				return (ConfigDataScenarioInfo)this.m_GetScenarioInfo_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_scenarioInfo;
		}

		// Token: 0x06015223 RID: 86563 RVA: 0x00557F84 File Offset: 0x00556184
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
			if (this.EventOnStart != null)
			{
				this.EventOnStart(this);
			}
		}

		// Token: 0x140004C9 RID: 1225
		// (add) Token: 0x06015224 RID: 86564 RVA: 0x00557FFC File Offset: 0x005561FC
		// (remove) Token: 0x06015225 RID: 86565 RVA: 0x00558098 File Offset: 0x00556298
		public event Action<PastScenarioListItemUIController> EventOnStart
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnStartAction`1_hotfix != null)
				{
					this.m_add_EventOnStartAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<PastScenarioListItemUIController> action = this.EventOnStart;
				Action<PastScenarioListItemUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<PastScenarioListItemUIController>>(ref this.EventOnStart, (Action<PastScenarioListItemUIController>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnStartAction`1_hotfix != null)
				{
					this.m_remove_EventOnStartAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<PastScenarioListItemUIController> action = this.EventOnStart;
				Action<PastScenarioListItemUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<PastScenarioListItemUIController>>(ref this.EventOnStart, (Action<PastScenarioListItemUIController>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17003E1E RID: 15902
		// (get) Token: 0x06015226 RID: 86566 RVA: 0x00558134 File Offset: 0x00556334
		// (set) Token: 0x06015227 RID: 86567 RVA: 0x00558154 File Offset: 0x00556354
		[DoNotToLua]
		public new PastScenarioListItemUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new PastScenarioListItemUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06015228 RID: 86568 RVA: 0x00558160 File Offset: 0x00556360
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x06015229 RID: 86569 RVA: 0x0055816C File Offset: 0x0055636C
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0601522A RID: 86570 RVA: 0x00558174 File Offset: 0x00556374
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0601522B RID: 86571 RVA: 0x0055817C File Offset: 0x0055637C
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0601522C RID: 86572 RVA: 0x00558190 File Offset: 0x00556390
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0601522D RID: 86573 RVA: 0x00558198 File Offset: 0x00556398
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0601522E RID: 86574 RVA: 0x005581A4 File Offset: 0x005563A4
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0601522F RID: 86575 RVA: 0x005581B0 File Offset: 0x005563B0
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x06015230 RID: 86576 RVA: 0x005581BC File Offset: 0x005563BC
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x06015231 RID: 86577 RVA: 0x005581C8 File Offset: 0x005563C8
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x06015232 RID: 86578 RVA: 0x005581D4 File Offset: 0x005563D4
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x06015233 RID: 86579 RVA: 0x005581E0 File Offset: 0x005563E0
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x06015234 RID: 86580 RVA: 0x005581EC File Offset: 0x005563EC
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x06015235 RID: 86581 RVA: 0x005581F8 File Offset: 0x005563F8
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x06015236 RID: 86582 RVA: 0x00558204 File Offset: 0x00556404
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x06015237 RID: 86583 RVA: 0x0055820C File Offset: 0x0055640C
		private void __callDele_EventOnStart(PastScenarioListItemUIController obj)
		{
			Action<PastScenarioListItemUIController> eventOnStart = this.EventOnStart;
			if (eventOnStart != null)
			{
				eventOnStart(obj);
			}
		}

		// Token: 0x06015238 RID: 86584 RVA: 0x00558230 File Offset: 0x00556430
		private void __clearDele_EventOnStart(PastScenarioListItemUIController obj)
		{
			this.EventOnStart = null;
		}

		// Token: 0x06015239 RID: 86585 RVA: 0x0055823C File Offset: 0x0055643C
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
					this.m_SetScenarioInfoConfigDataScenarioInfo_hotfix = (luaObj.RawGet("SetScenarioInfo") as LuaFunction);
					this.m_GetScenarioInfo_hotfix = (luaObj.RawGet("GetScenarioInfo") as LuaFunction);
					this.m_OnStartButtonClick_hotfix = (luaObj.RawGet("OnStartButtonClick") as LuaFunction);
					this.m_add_EventOnStartAction`1_hotfix = (luaObj.RawGet("add_EventOnStart") as LuaFunction);
					this.m_remove_EventOnStartAction`1_hotfix = (luaObj.RawGet("remove_EventOnStart") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0601523A RID: 86586 RVA: 0x00558384 File Offset: 0x00556584
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(PastScenarioListItemUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400B866 RID: 47206
		[AutoBind("./StartButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_startButton;

		// Token: 0x0400B867 RID: 47207
		[AutoBind("./NameText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_nameText;

		// Token: 0x0400B868 RID: 47208
		[AutoBind("./Level/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_levelText;

		// Token: 0x0400B869 RID: 47209
		[AutoBind("./Energy/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_energyText;

		// Token: 0x0400B86A RID: 47210
		[AutoBind("./RewardGoodsList", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_rewardGoodsListGameObject;

		// Token: 0x0400B86B RID: 47211
		private ConfigDataScenarioInfo m_scenarioInfo;

		// Token: 0x0400B86C RID: 47212
		[DoNotToLua]
		private PastScenarioListItemUIController.LuaExportHelper luaExportHelper;

		// Token: 0x0400B86D RID: 47213
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400B86E RID: 47214
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400B86F RID: 47215
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x0400B870 RID: 47216
		private LuaFunction m_SetScenarioInfoConfigDataScenarioInfo_hotfix;

		// Token: 0x0400B871 RID: 47217
		private LuaFunction m_GetScenarioInfo_hotfix;

		// Token: 0x0400B872 RID: 47218
		private LuaFunction m_OnStartButtonClick_hotfix;

		// Token: 0x0400B873 RID: 47219
		private LuaFunction m_add_EventOnStartAction;

		// Token: 0x0400B874 RID: 47220
		private LuaFunction m_remove_EventOnStartAction;

		// Token: 0x02001038 RID: 4152
		public new class LuaExportHelper
		{
			// Token: 0x0601523B RID: 86587 RVA: 0x005583EC File Offset: 0x005565EC
			public LuaExportHelper(PastScenarioListItemUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0601523C RID: 86588 RVA: 0x005583FC File Offset: 0x005565FC
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0601523D RID: 86589 RVA: 0x0055840C File Offset: 0x0055660C
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0601523E RID: 86590 RVA: 0x0055841C File Offset: 0x0055661C
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0601523F RID: 86591 RVA: 0x0055842C File Offset: 0x0055662C
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x06015240 RID: 86592 RVA: 0x00558444 File Offset: 0x00556644
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x06015241 RID: 86593 RVA: 0x00558454 File Offset: 0x00556654
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x06015242 RID: 86594 RVA: 0x00558464 File Offset: 0x00556664
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x06015243 RID: 86595 RVA: 0x00558474 File Offset: 0x00556674
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x06015244 RID: 86596 RVA: 0x00558484 File Offset: 0x00556684
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x06015245 RID: 86597 RVA: 0x00558494 File Offset: 0x00556694
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x06015246 RID: 86598 RVA: 0x005584A4 File Offset: 0x005566A4
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x06015247 RID: 86599 RVA: 0x005584B4 File Offset: 0x005566B4
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x06015248 RID: 86600 RVA: 0x005584C4 File Offset: 0x005566C4
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x06015249 RID: 86601 RVA: 0x005584D4 File Offset: 0x005566D4
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0601524A RID: 86602 RVA: 0x005584E4 File Offset: 0x005566E4
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x0601524B RID: 86603 RVA: 0x005584F4 File Offset: 0x005566F4
			public void __callDele_EventOnStart(PastScenarioListItemUIController obj)
			{
				this.m_owner.__callDele_EventOnStart(obj);
			}

			// Token: 0x0601524C RID: 86604 RVA: 0x00558504 File Offset: 0x00556704
			public void __clearDele_EventOnStart(PastScenarioListItemUIController obj)
			{
				this.m_owner.__clearDele_EventOnStart(obj);
			}

			// Token: 0x17003E1F RID: 15903
			// (get) Token: 0x0601524D RID: 86605 RVA: 0x00558514 File Offset: 0x00556714
			// (set) Token: 0x0601524E RID: 86606 RVA: 0x00558524 File Offset: 0x00556724
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

			// Token: 0x17003E20 RID: 15904
			// (get) Token: 0x0601524F RID: 86607 RVA: 0x00558534 File Offset: 0x00556734
			// (set) Token: 0x06015250 RID: 86608 RVA: 0x00558544 File Offset: 0x00556744
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

			// Token: 0x17003E21 RID: 15905
			// (get) Token: 0x06015251 RID: 86609 RVA: 0x00558554 File Offset: 0x00556754
			// (set) Token: 0x06015252 RID: 86610 RVA: 0x00558564 File Offset: 0x00556764
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

			// Token: 0x17003E22 RID: 15906
			// (get) Token: 0x06015253 RID: 86611 RVA: 0x00558574 File Offset: 0x00556774
			// (set) Token: 0x06015254 RID: 86612 RVA: 0x00558584 File Offset: 0x00556784
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

			// Token: 0x17003E23 RID: 15907
			// (get) Token: 0x06015255 RID: 86613 RVA: 0x00558594 File Offset: 0x00556794
			// (set) Token: 0x06015256 RID: 86614 RVA: 0x005585A4 File Offset: 0x005567A4
			public GameObject m_rewardGoodsListGameObject
			{
				get
				{
					return this.m_owner.m_rewardGoodsListGameObject;
				}
				set
				{
					this.m_owner.m_rewardGoodsListGameObject = value;
				}
			}

			// Token: 0x17003E24 RID: 15908
			// (get) Token: 0x06015257 RID: 86615 RVA: 0x005585B4 File Offset: 0x005567B4
			// (set) Token: 0x06015258 RID: 86616 RVA: 0x005585C4 File Offset: 0x005567C4
			public ConfigDataScenarioInfo m_scenarioInfo
			{
				get
				{
					return this.m_owner.m_scenarioInfo;
				}
				set
				{
					this.m_owner.m_scenarioInfo = value;
				}
			}

			// Token: 0x06015259 RID: 86617 RVA: 0x005585D4 File Offset: 0x005567D4
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0601525A RID: 86618 RVA: 0x005585E4 File Offset: 0x005567E4
			public void OnStartButtonClick()
			{
				this.m_owner.OnStartButtonClick();
			}

			// Token: 0x0400B875 RID: 47221
			private PastScenarioListItemUIController m_owner;
		}
	}
}
