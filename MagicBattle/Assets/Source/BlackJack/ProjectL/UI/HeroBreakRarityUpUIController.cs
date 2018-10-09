using System;
using System.Threading;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Misc;
using BlackJack.ProjectL.PlayerContext;
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000D7D RID: 3453
	[HotFix]
	public class HeroBreakRarityUpUIController : UIControllerBase
	{
		// Token: 0x060100BD RID: 65725 RVA: 0x00433CD0 File Offset: 0x00431ED0
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
			this.m_heroBreakEffectReturnButton.onClick.AddListener(new UnityAction(this.OnReturnButtonClick));
			base.gameObject.SetActive(true);
			this.m_heroCharUIController = GameObjectUtility.AddControllerToGameObject<HeroCharUIController>(this.m_heroCharGameObject);
			this.m_playerContext = (GameManager.Instance.PlayerContext as ProjectLPlayerContext);
		}

		// Token: 0x060100BE RID: 65726 RVA: 0x00433D84 File Offset: 0x00431F84
		public void HeroBreakRarityUpUpdateView(int heroId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HeroBreakRarityUpUpdateViewInt32_hotfix != null)
			{
				this.m_HeroBreakRarityUpUpdateViewInt32_hotfix.call(new object[]
				{
					this,
					heroId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_hero = this.m_playerContext.GetHero(heroId);
			if (this.m_heroCharUIController.GetCharImageInfo() != this.m_hero.HeroInfo.GetCharImageInfo(this.m_hero.StarLevel))
			{
				this.m_heroCharUIController.CreateGraphic(this.m_hero, HeroCharUIController.PerformanceState.Break, false, null);
				this.m_heroCharUIController.PlayAnimation("idle_Normal", false);
			}
			string stateName = null;
			switch (this.m_hero.HeroInfo.GetRank(this.m_hero.StarLevel))
			{
			case 2:
				stateName = "NtoR";
				break;
			case 3:
				stateName = "RtoSR";
				break;
			case 4:
				stateName = "SRtoSSR";
				break;
			}
			this.m_heroBreakEffectReturnButton.interactable = false;
			this.m_stateCtrl.SetActionForUIStateFinshed(stateName, delegate
			{
				this.m_heroBreakEffectReturnButton.interactable = true;
			});
			this.m_stateCtrl.SetToUIState(stateName, false, true);
		}

		// Token: 0x060100BF RID: 65727 RVA: 0x00433EEC File Offset: 0x004320EC
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

		// Token: 0x060100C0 RID: 65728 RVA: 0x00433F64 File Offset: 0x00432164
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
		}

		// Token: 0x060100C1 RID: 65729 RVA: 0x00433FC4 File Offset: 0x004321C4
		public void Close()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Close_hotfix != null)
			{
				this.m_Close_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x1400035F RID: 863
		// (add) Token: 0x060100C2 RID: 65730 RVA: 0x00434024 File Offset: 0x00432224
		// (remove) Token: 0x060100C3 RID: 65731 RVA: 0x004340C0 File Offset: 0x004322C0
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

		// Token: 0x1700315A RID: 12634
		// (get) Token: 0x060100C4 RID: 65732 RVA: 0x0043415C File Offset: 0x0043235C
		// (set) Token: 0x060100C5 RID: 65733 RVA: 0x0043417C File Offset: 0x0043237C
		[DoNotToLua]
		public new HeroBreakRarityUpUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new HeroBreakRarityUpUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x060100C6 RID: 65734 RVA: 0x00434188 File Offset: 0x00432388
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x060100C7 RID: 65735 RVA: 0x00434194 File Offset: 0x00432394
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x060100C8 RID: 65736 RVA: 0x0043419C File Offset: 0x0043239C
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x060100C9 RID: 65737 RVA: 0x004341A4 File Offset: 0x004323A4
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x060100CA RID: 65738 RVA: 0x004341B8 File Offset: 0x004323B8
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x060100CB RID: 65739 RVA: 0x004341C0 File Offset: 0x004323C0
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x060100CC RID: 65740 RVA: 0x004341CC File Offset: 0x004323CC
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x060100CD RID: 65741 RVA: 0x004341D8 File Offset: 0x004323D8
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x060100CE RID: 65742 RVA: 0x004341E4 File Offset: 0x004323E4
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x060100CF RID: 65743 RVA: 0x004341F0 File Offset: 0x004323F0
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x060100D0 RID: 65744 RVA: 0x004341FC File Offset: 0x004323FC
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x060100D1 RID: 65745 RVA: 0x00434208 File Offset: 0x00432408
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x060100D2 RID: 65746 RVA: 0x00434214 File Offset: 0x00432414
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x060100D3 RID: 65747 RVA: 0x00434220 File Offset: 0x00432420
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x060100D4 RID: 65748 RVA: 0x0043422C File Offset: 0x0043242C
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x060100D5 RID: 65749 RVA: 0x00434234 File Offset: 0x00432434
		private void __callDele_EventOnReturn()
		{
			Action eventOnReturn = this.EventOnReturn;
			if (eventOnReturn != null)
			{
				eventOnReturn();
			}
		}

		// Token: 0x060100D6 RID: 65750 RVA: 0x00434254 File Offset: 0x00432454
		private void __clearDele_EventOnReturn()
		{
			this.EventOnReturn = null;
		}

		// Token: 0x060100D8 RID: 65752 RVA: 0x00434270 File Offset: 0x00432470
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
					this.m_HeroBreakRarityUpUpdateViewInt32_hotfix = (luaObj.RawGet("HeroBreakRarityUpUpdateView") as LuaFunction);
					this.m_OnReturnButtonClick_hotfix = (luaObj.RawGet("OnReturnButtonClick") as LuaFunction);
					this.m_Open_hotfix = (luaObj.RawGet("Open") as LuaFunction);
					this.m_Close_hotfix = (luaObj.RawGet("Close") as LuaFunction);
					this.m_add_EventOnReturnAction_hotfix = (luaObj.RawGet("add_EventOnReturn") as LuaFunction);
					this.m_remove_EventOnReturnAction_hotfix = (luaObj.RawGet("remove_EventOnReturn") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x060100D9 RID: 65753 RVA: 0x004343D4 File Offset: 0x004325D4
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(HeroBreakRarityUpUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040095E0 RID: 38368
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_stateCtrl;

		// Token: 0x040095E1 RID: 38369
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_heroCharGameObject;

		// Token: 0x040095E2 RID: 38370
		[AutoBind("./ClickScreenContinue", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_heroBreakEffectReturnButton;

		// Token: 0x040095E4 RID: 38372
		private Hero m_hero;

		// Token: 0x040095E5 RID: 38373
		private HeroCharUIController m_heroCharUIController;

		// Token: 0x040095E6 RID: 38374
		private ProjectLPlayerContext m_playerContext;

		// Token: 0x040095E7 RID: 38375
		[DoNotToLua]
		private HeroBreakRarityUpUIController.LuaExportHelper luaExportHelper;

		// Token: 0x040095E8 RID: 38376
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040095E9 RID: 38377
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040095EA RID: 38378
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x040095EB RID: 38379
		private LuaFunction m_HeroBreakRarityUpUpdateViewInt32_hotfix;

		// Token: 0x040095EC RID: 38380
		private LuaFunction m_OnReturnButtonClick_hotfix;

		// Token: 0x040095ED RID: 38381
		private LuaFunction m_Open_hotfix;

		// Token: 0x040095EE RID: 38382
		private LuaFunction m_Close_hotfix;

		// Token: 0x040095EF RID: 38383
		private LuaFunction m_add_EventOnReturnAction_hotfix;

		// Token: 0x040095F0 RID: 38384
		private LuaFunction m_remove_EventOnReturnAction_hotfix;

		// Token: 0x02000D7E RID: 3454
		public new class LuaExportHelper
		{
			// Token: 0x060100DA RID: 65754 RVA: 0x0043443C File Offset: 0x0043263C
			public LuaExportHelper(HeroBreakRarityUpUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x060100DB RID: 65755 RVA: 0x0043444C File Offset: 0x0043264C
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x060100DC RID: 65756 RVA: 0x0043445C File Offset: 0x0043265C
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x060100DD RID: 65757 RVA: 0x0043446C File Offset: 0x0043266C
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x060100DE RID: 65758 RVA: 0x0043447C File Offset: 0x0043267C
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x060100DF RID: 65759 RVA: 0x00434494 File Offset: 0x00432694
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x060100E0 RID: 65760 RVA: 0x004344A4 File Offset: 0x004326A4
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x060100E1 RID: 65761 RVA: 0x004344B4 File Offset: 0x004326B4
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x060100E2 RID: 65762 RVA: 0x004344C4 File Offset: 0x004326C4
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x060100E3 RID: 65763 RVA: 0x004344D4 File Offset: 0x004326D4
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x060100E4 RID: 65764 RVA: 0x004344E4 File Offset: 0x004326E4
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x060100E5 RID: 65765 RVA: 0x004344F4 File Offset: 0x004326F4
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x060100E6 RID: 65766 RVA: 0x00434504 File Offset: 0x00432704
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x060100E7 RID: 65767 RVA: 0x00434514 File Offset: 0x00432714
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x060100E8 RID: 65768 RVA: 0x00434524 File Offset: 0x00432724
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x060100E9 RID: 65769 RVA: 0x00434534 File Offset: 0x00432734
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x060100EA RID: 65770 RVA: 0x00434544 File Offset: 0x00432744
			public void __callDele_EventOnReturn()
			{
				this.m_owner.__callDele_EventOnReturn();
			}

			// Token: 0x060100EB RID: 65771 RVA: 0x00434554 File Offset: 0x00432754
			public void __clearDele_EventOnReturn()
			{
				this.m_owner.__clearDele_EventOnReturn();
			}

			// Token: 0x1700315B RID: 12635
			// (get) Token: 0x060100EC RID: 65772 RVA: 0x00434564 File Offset: 0x00432764
			// (set) Token: 0x060100ED RID: 65773 RVA: 0x00434574 File Offset: 0x00432774
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

			// Token: 0x1700315C RID: 12636
			// (get) Token: 0x060100EE RID: 65774 RVA: 0x00434584 File Offset: 0x00432784
			// (set) Token: 0x060100EF RID: 65775 RVA: 0x00434594 File Offset: 0x00432794
			public GameObject m_heroCharGameObject
			{
				get
				{
					return this.m_owner.m_heroCharGameObject;
				}
				set
				{
					this.m_owner.m_heroCharGameObject = value;
				}
			}

			// Token: 0x1700315D RID: 12637
			// (get) Token: 0x060100F0 RID: 65776 RVA: 0x004345A4 File Offset: 0x004327A4
			// (set) Token: 0x060100F1 RID: 65777 RVA: 0x004345B4 File Offset: 0x004327B4
			public Button m_heroBreakEffectReturnButton
			{
				get
				{
					return this.m_owner.m_heroBreakEffectReturnButton;
				}
				set
				{
					this.m_owner.m_heroBreakEffectReturnButton = value;
				}
			}

			// Token: 0x1700315E RID: 12638
			// (get) Token: 0x060100F2 RID: 65778 RVA: 0x004345C4 File Offset: 0x004327C4
			// (set) Token: 0x060100F3 RID: 65779 RVA: 0x004345D4 File Offset: 0x004327D4
			public Hero m_hero
			{
				get
				{
					return this.m_owner.m_hero;
				}
				set
				{
					this.m_owner.m_hero = value;
				}
			}

			// Token: 0x1700315F RID: 12639
			// (get) Token: 0x060100F4 RID: 65780 RVA: 0x004345E4 File Offset: 0x004327E4
			// (set) Token: 0x060100F5 RID: 65781 RVA: 0x004345F4 File Offset: 0x004327F4
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

			// Token: 0x17003160 RID: 12640
			// (get) Token: 0x060100F6 RID: 65782 RVA: 0x00434604 File Offset: 0x00432804
			// (set) Token: 0x060100F7 RID: 65783 RVA: 0x00434614 File Offset: 0x00432814
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

			// Token: 0x060100F8 RID: 65784 RVA: 0x00434624 File Offset: 0x00432824
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x060100F9 RID: 65785 RVA: 0x00434634 File Offset: 0x00432834
			public void OnReturnButtonClick()
			{
				this.m_owner.OnReturnButtonClick();
			}

			// Token: 0x040095F1 RID: 38385
			private HeroBreakRarityUpUIController m_owner;
		}
	}
}
