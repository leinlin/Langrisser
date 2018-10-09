using System;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x020009F0 RID: 2544
	[HotFix]
	public class ManualUIController : UIControllerBase
	{
		// Token: 0x060096EF RID: 38639 RVA: 0x002B2344 File Offset: 0x002B0544
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
			this.m_equipmentButton.onClick.AddListener(new UnityAction(this.OnEquipmentClick));
			this.m_heroButton.onClick.AddListener(new UnityAction(this.OnHeroClick));
			this.m_returnButton.onClick.AddListener(new UnityAction(this.OnReturnClick));
			this.m_detailButton.onClick.AddListener(new UnityAction(this.OnDetailClick));
		}

		// Token: 0x060096F0 RID: 38640 RVA: 0x002B241C File Offset: 0x002B061C
		public void SetTask(ArchiveUITask task)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetTaskArchiveUITask_hotfix != null)
			{
				this.m_SetTaskArchiveUITask_hotfix.call(new object[]
				{
					this,
					task
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_task = task;
		}

		// Token: 0x060096F1 RID: 38641 RVA: 0x002B2494 File Offset: 0x002B0694
		protected void OnEquipmentClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnEquipmentClick_hotfix != null)
			{
				this.m_OnEquipmentClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIController.Instance.StartShowFadeOutLoadingFadeIn(delegate
			{
				this.m_task.m_heroArchiveUIController.gameObject.SetActive(false);
				this.m_task.m_equipmentArchiveUIController.gameObject.SetActive(true);
				this.m_task.m_manualUIController.gameObject.SetActive(false);
				this.m_task.m_heroShowUIController.gameObject.SetActive(false);
				this.m_task.m_equipmentArchiveUIController.EnterController();
				CommonUIController.Instance.HideFadeOutLoadingFadeIn();
			}, FadeStyle.Black, -1f, -1f);
		}

		// Token: 0x060096F2 RID: 38642 RVA: 0x002B2518 File Offset: 0x002B0718
		protected void OnHeroClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnHeroClick_hotfix != null)
			{
				this.m_OnHeroClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIController.Instance.StartShowFadeOutLoadingFadeIn(delegate
			{
				this.m_task.m_heroArchiveUIController.gameObject.SetActive(true);
				this.m_task.m_equipmentArchiveUIController.gameObject.SetActive(false);
				this.m_task.m_manualUIController.gameObject.SetActive(false);
				this.m_task.m_heroShowUIController.gameObject.SetActive(false);
				this.m_task.m_heroArchiveUIController.EnterController();
				CommonUIController.Instance.HideFadeOutLoadingFadeIn();
			}, FadeStyle.Black, -1f, -1f);
		}

		// Token: 0x060096F3 RID: 38643 RVA: 0x002B259C File Offset: 0x002B079C
		protected void OnReturnClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnReturnClick_hotfix != null)
			{
				this.m_OnReturnClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_task.Stop();
			this.m_task.ReturnLastTask();
		}

		// Token: 0x060096F4 RID: 38644 RVA: 0x002B2614 File Offset: 0x002B0814
		protected void OnDetailClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnDetailClick_hotfix != null)
			{
				this.m_OnDetailClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIController.Instance.ShowExplanation(ExplanationId.ExplanationId_Archive);
		}

		// Token: 0x17001F24 RID: 7972
		// (get) Token: 0x060096F5 RID: 38645 RVA: 0x002B2680 File Offset: 0x002B0880
		// (set) Token: 0x060096F6 RID: 38646 RVA: 0x002B26A0 File Offset: 0x002B08A0
		[DoNotToLua]
		public new ManualUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new ManualUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x060096F7 RID: 38647 RVA: 0x002B26AC File Offset: 0x002B08AC
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x060096F8 RID: 38648 RVA: 0x002B26B8 File Offset: 0x002B08B8
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x060096F9 RID: 38649 RVA: 0x002B26C0 File Offset: 0x002B08C0
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x060096FA RID: 38650 RVA: 0x002B26C8 File Offset: 0x002B08C8
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x060096FB RID: 38651 RVA: 0x002B26DC File Offset: 0x002B08DC
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x060096FC RID: 38652 RVA: 0x002B26E4 File Offset: 0x002B08E4
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x060096FD RID: 38653 RVA: 0x002B26F0 File Offset: 0x002B08F0
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x060096FE RID: 38654 RVA: 0x002B26FC File Offset: 0x002B08FC
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x060096FF RID: 38655 RVA: 0x002B2708 File Offset: 0x002B0908
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x06009700 RID: 38656 RVA: 0x002B2714 File Offset: 0x002B0914
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x06009701 RID: 38657 RVA: 0x002B2720 File Offset: 0x002B0920
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x06009702 RID: 38658 RVA: 0x002B272C File Offset: 0x002B092C
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x06009703 RID: 38659 RVA: 0x002B2738 File Offset: 0x002B0938
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x06009704 RID: 38660 RVA: 0x002B2744 File Offset: 0x002B0944
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x06009705 RID: 38661 RVA: 0x002B2750 File Offset: 0x002B0950
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x06009708 RID: 38664 RVA: 0x002B2858 File Offset: 0x002B0A58
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
					this.m_SetTaskArchiveUITask_hotfix = (luaObj.RawGet("SetTask") as LuaFunction);
					this.m_OnEquipmentClick_hotfix = (luaObj.RawGet("OnEquipmentClick") as LuaFunction);
					this.m_OnHeroClick_hotfix = (luaObj.RawGet("OnHeroClick") as LuaFunction);
					this.m_OnReturnClick_hotfix = (luaObj.RawGet("OnReturnClick") as LuaFunction);
					this.m_OnDetailClick_hotfix = (luaObj.RawGet("OnDetailClick") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06009709 RID: 38665 RVA: 0x002B29A0 File Offset: 0x002B0BA0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ManualUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040067F1 RID: 26609
		[AutoBind("./EquipmentPanel/EquipmentButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_equipmentButton;

		// Token: 0x040067F2 RID: 26610
		[AutoBind("./HeroPanel/HeroButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_heroButton;

		// Token: 0x040067F3 RID: 26611
		[AutoBind("./ReturnButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_returnButton;

		// Token: 0x040067F4 RID: 26612
		[AutoBind("./DetailButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_detailButton;

		// Token: 0x040067F5 RID: 26613
		private ArchiveUITask m_task;

		// Token: 0x040067F6 RID: 26614
		[DoNotToLua]
		private ManualUIController.LuaExportHelper luaExportHelper;

		// Token: 0x040067F7 RID: 26615
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040067F8 RID: 26616
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040067F9 RID: 26617
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x040067FA RID: 26618
		private LuaFunction m_SetTaskArchiveUITask_hotfix;

		// Token: 0x040067FB RID: 26619
		private LuaFunction m_OnEquipmentClick_hotfix;

		// Token: 0x040067FC RID: 26620
		private LuaFunction m_OnHeroClick_hotfix;

		// Token: 0x040067FD RID: 26621
		private LuaFunction m_OnReturnClick_hotfix;

		// Token: 0x040067FE RID: 26622
		private LuaFunction m_OnDetailClick_hotfix;

		// Token: 0x020009F1 RID: 2545
		public new class LuaExportHelper
		{
			// Token: 0x0600970A RID: 38666 RVA: 0x002B2A08 File Offset: 0x002B0C08
			public LuaExportHelper(ManualUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600970B RID: 38667 RVA: 0x002B2A18 File Offset: 0x002B0C18
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0600970C RID: 38668 RVA: 0x002B2A28 File Offset: 0x002B0C28
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0600970D RID: 38669 RVA: 0x002B2A38 File Offset: 0x002B0C38
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600970E RID: 38670 RVA: 0x002B2A48 File Offset: 0x002B0C48
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600970F RID: 38671 RVA: 0x002B2A60 File Offset: 0x002B0C60
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x06009710 RID: 38672 RVA: 0x002B2A70 File Offset: 0x002B0C70
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x06009711 RID: 38673 RVA: 0x002B2A80 File Offset: 0x002B0C80
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x06009712 RID: 38674 RVA: 0x002B2A90 File Offset: 0x002B0C90
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x06009713 RID: 38675 RVA: 0x002B2AA0 File Offset: 0x002B0CA0
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x06009714 RID: 38676 RVA: 0x002B2AB0 File Offset: 0x002B0CB0
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x06009715 RID: 38677 RVA: 0x002B2AC0 File Offset: 0x002B0CC0
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x06009716 RID: 38678 RVA: 0x002B2AD0 File Offset: 0x002B0CD0
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x06009717 RID: 38679 RVA: 0x002B2AE0 File Offset: 0x002B0CE0
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x06009718 RID: 38680 RVA: 0x002B2AF0 File Offset: 0x002B0CF0
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x06009719 RID: 38681 RVA: 0x002B2B00 File Offset: 0x002B0D00
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x17001F25 RID: 7973
			// (get) Token: 0x0600971A RID: 38682 RVA: 0x002B2B10 File Offset: 0x002B0D10
			// (set) Token: 0x0600971B RID: 38683 RVA: 0x002B2B20 File Offset: 0x002B0D20
			public Button m_equipmentButton
			{
				get
				{
					return this.m_owner.m_equipmentButton;
				}
				set
				{
					this.m_owner.m_equipmentButton = value;
				}
			}

			// Token: 0x17001F26 RID: 7974
			// (get) Token: 0x0600971C RID: 38684 RVA: 0x002B2B30 File Offset: 0x002B0D30
			// (set) Token: 0x0600971D RID: 38685 RVA: 0x002B2B40 File Offset: 0x002B0D40
			public Button m_heroButton
			{
				get
				{
					return this.m_owner.m_heroButton;
				}
				set
				{
					this.m_owner.m_heroButton = value;
				}
			}

			// Token: 0x17001F27 RID: 7975
			// (get) Token: 0x0600971E RID: 38686 RVA: 0x002B2B50 File Offset: 0x002B0D50
			// (set) Token: 0x0600971F RID: 38687 RVA: 0x002B2B60 File Offset: 0x002B0D60
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

			// Token: 0x17001F28 RID: 7976
			// (get) Token: 0x06009720 RID: 38688 RVA: 0x002B2B70 File Offset: 0x002B0D70
			// (set) Token: 0x06009721 RID: 38689 RVA: 0x002B2B80 File Offset: 0x002B0D80
			public Button m_detailButton
			{
				get
				{
					return this.m_owner.m_detailButton;
				}
				set
				{
					this.m_owner.m_detailButton = value;
				}
			}

			// Token: 0x17001F29 RID: 7977
			// (get) Token: 0x06009722 RID: 38690 RVA: 0x002B2B90 File Offset: 0x002B0D90
			// (set) Token: 0x06009723 RID: 38691 RVA: 0x002B2BA0 File Offset: 0x002B0DA0
			public ArchiveUITask m_task
			{
				get
				{
					return this.m_owner.m_task;
				}
				set
				{
					this.m_owner.m_task = value;
				}
			}

			// Token: 0x06009724 RID: 38692 RVA: 0x002B2BB0 File Offset: 0x002B0DB0
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x06009725 RID: 38693 RVA: 0x002B2BC0 File Offset: 0x002B0DC0
			public void OnEquipmentClick()
			{
				this.m_owner.OnEquipmentClick();
			}

			// Token: 0x06009726 RID: 38694 RVA: 0x002B2BD0 File Offset: 0x002B0DD0
			public void OnHeroClick()
			{
				this.m_owner.OnHeroClick();
			}

			// Token: 0x06009727 RID: 38695 RVA: 0x002B2BE0 File Offset: 0x002B0DE0
			public void OnReturnClick()
			{
				this.m_owner.OnReturnClick();
			}

			// Token: 0x06009728 RID: 38696 RVA: 0x002B2BF0 File Offset: 0x002B0DF0
			public void OnDetailClick()
			{
				this.m_owner.OnDetailClick();
			}

			// Token: 0x040067FF RID: 26623
			private ManualUIController m_owner;
		}
	}
}
