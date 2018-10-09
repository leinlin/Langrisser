using System;
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
	// Token: 0x020009E6 RID: 2534
	[HotFix]
	public class HeroHeadUIController : UIControllerBase
	{
		// Token: 0x0600962D RID: 38445 RVA: 0x002AFED4 File Offset: 0x002AE0D4
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
			this.m_heroHeadButton.onClick.AddListener(new UnityAction(this.OnHeroHeadClick));
		}

		// Token: 0x0600962E RID: 38446 RVA: 0x002AFF58 File Offset: 0x002AE158
		public void SetHeroWrap(HeroArchiveUIController.HeroWrap heroWrap)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetHeroWrapHeroWrap_hotfix != null)
			{
				this.m_SetHeroWrapHeroWrap_hotfix.call(new object[]
				{
					this,
					heroWrap
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_heroWrap = heroWrap;
		}

		// Token: 0x0600962F RID: 38447 RVA: 0x002AFFD0 File Offset: 0x002AE1D0
		public void RefreshDisplay()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_RefreshDisplay_hotfix != null)
			{
				this.m_RefreshDisplay_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataCharImageInfo charImageInfo = this.m_heroWrap.hero.GetCharImageInfo(this.m_heroWrap.hero.Star);
			this.m_heroNameText.text = this.m_heroWrap.hero.Name;
			this.m_cardIamge.sprite = AssetUtility.Instance.GetSprite(charImageInfo.SummonHeadImage);
			if (this.m_heroWrap.isUnlocked)
			{
				this.m_heroHeadAnimation.SetToUIState("Normal", false, true);
			}
			else
			{
				this.m_heroHeadAnimation.SetToUIState("Unknow", false, true);
			}
			this.m_selectImage.gameObject.SetActive(this.m_heroWrap.isSelect);
		}

		// Token: 0x06009630 RID: 38448 RVA: 0x002B00DC File Offset: 0x002AE2DC
		public void OnHeroHeadClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnHeroHeadClick_hotfix != null)
			{
				this.m_OnHeroHeadClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.OnHeroHeadClickEvent != null)
			{
				this.OnHeroHeadClickEvent(this);
			}
		}

		// Token: 0x06009631 RID: 38449 RVA: 0x002B0154 File Offset: 0x002AE354
		public void Selected(bool isSelect)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SelectedBoolean_hotfix != null)
			{
				this.m_SelectedBoolean_hotfix.call(new object[]
				{
					this,
					isSelect
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_heroWrap.isSelect = isSelect;
			this.RefreshDisplay();
		}

		// Token: 0x140001A3 RID: 419
		// (add) Token: 0x06009632 RID: 38450 RVA: 0x002B01D8 File Offset: 0x002AE3D8
		// (remove) Token: 0x06009633 RID: 38451 RVA: 0x002B0274 File Offset: 0x002AE474
		public event Action<HeroHeadUIController> OnHeroHeadClickEvent
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_OnHeroHeadClickEventAction`1_hotfix != null)
				{
					this.m_add_OnHeroHeadClickEventAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<HeroHeadUIController> action = this.OnHeroHeadClickEvent;
				Action<HeroHeadUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<HeroHeadUIController>>(ref this.OnHeroHeadClickEvent, (Action<HeroHeadUIController>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_OnHeroHeadClickEventAction`1_hotfix != null)
				{
					this.m_remove_OnHeroHeadClickEventAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<HeroHeadUIController> action = this.OnHeroHeadClickEvent;
				Action<HeroHeadUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<HeroHeadUIController>>(ref this.OnHeroHeadClickEvent, (Action<HeroHeadUIController>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17001EFF RID: 7935
		// (get) Token: 0x06009634 RID: 38452 RVA: 0x002B0310 File Offset: 0x002AE510
		// (set) Token: 0x06009635 RID: 38453 RVA: 0x002B0330 File Offset: 0x002AE530
		[DoNotToLua]
		public new HeroHeadUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new HeroHeadUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06009636 RID: 38454 RVA: 0x002B033C File Offset: 0x002AE53C
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x06009637 RID: 38455 RVA: 0x002B0348 File Offset: 0x002AE548
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x06009638 RID: 38456 RVA: 0x002B0350 File Offset: 0x002AE550
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x06009639 RID: 38457 RVA: 0x002B0358 File Offset: 0x002AE558
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0600963A RID: 38458 RVA: 0x002B036C File Offset: 0x002AE56C
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0600963B RID: 38459 RVA: 0x002B0374 File Offset: 0x002AE574
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0600963C RID: 38460 RVA: 0x002B0380 File Offset: 0x002AE580
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0600963D RID: 38461 RVA: 0x002B038C File Offset: 0x002AE58C
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0600963E RID: 38462 RVA: 0x002B0398 File Offset: 0x002AE598
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0600963F RID: 38463 RVA: 0x002B03A4 File Offset: 0x002AE5A4
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x06009640 RID: 38464 RVA: 0x002B03B0 File Offset: 0x002AE5B0
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x06009641 RID: 38465 RVA: 0x002B03BC File Offset: 0x002AE5BC
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x06009642 RID: 38466 RVA: 0x002B03C8 File Offset: 0x002AE5C8
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x06009643 RID: 38467 RVA: 0x002B03D4 File Offset: 0x002AE5D4
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x06009644 RID: 38468 RVA: 0x002B03E0 File Offset: 0x002AE5E0
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x06009645 RID: 38469 RVA: 0x002B03E8 File Offset: 0x002AE5E8
		private void __callDele_OnHeroHeadClickEvent(HeroHeadUIController obj)
		{
			Action<HeroHeadUIController> onHeroHeadClickEvent = this.OnHeroHeadClickEvent;
			if (onHeroHeadClickEvent != null)
			{
				onHeroHeadClickEvent(obj);
			}
		}

		// Token: 0x06009646 RID: 38470 RVA: 0x002B040C File Offset: 0x002AE60C
		private void __clearDele_OnHeroHeadClickEvent(HeroHeadUIController obj)
		{
			this.OnHeroHeadClickEvent = null;
		}

		// Token: 0x06009647 RID: 38471 RVA: 0x002B0418 File Offset: 0x002AE618
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
					this.m_SetHeroWrapHeroWrap_hotfix = (luaObj.RawGet("SetHeroWrap") as LuaFunction);
					this.m_RefreshDisplay_hotfix = (luaObj.RawGet("RefreshDisplay") as LuaFunction);
					this.m_OnHeroHeadClick_hotfix = (luaObj.RawGet("OnHeroHeadClick") as LuaFunction);
					this.m_SelectedBoolean_hotfix = (luaObj.RawGet("Selected") as LuaFunction);
					this.m_add_OnHeroHeadClickEventAction`1_hotfix = (luaObj.RawGet("add_OnHeroHeadClickEvent") as LuaFunction);
					this.m_remove_OnHeroHeadClickEventAction`1_hotfix = (luaObj.RawGet("remove_OnHeroHeadClickEvent") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06009648 RID: 38472 RVA: 0x002B057C File Offset: 0x002AE77C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(HeroHeadUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040067A1 RID: 26529
		[AutoBind(".", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_heroHeadButton;

		// Token: 0x040067A2 RID: 26530
		[AutoBind(".", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_heroHeadAnimation;

		// Token: 0x040067A3 RID: 26531
		[AutoBind("./SelectImage", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_selectImage;

		// Token: 0x040067A4 RID: 26532
		[AutoBind("./CardImage", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_cardIamge;

		// Token: 0x040067A5 RID: 26533
		[AutoBind("./HeroNameText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_heroNameText;

		// Token: 0x040067A6 RID: 26534
		public HeroArchiveUIController.HeroWrap m_heroWrap;

		// Token: 0x040067A7 RID: 26535
		[DoNotToLua]
		private HeroHeadUIController.LuaExportHelper luaExportHelper;

		// Token: 0x040067A8 RID: 26536
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040067A9 RID: 26537
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040067AA RID: 26538
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x040067AB RID: 26539
		private LuaFunction m_SetHeroWrapHeroWrap_hotfix;

		// Token: 0x040067AC RID: 26540
		private LuaFunction m_RefreshDisplay_hotfix;

		// Token: 0x040067AD RID: 26541
		private LuaFunction m_OnHeroHeadClick_hotfix;

		// Token: 0x040067AE RID: 26542
		private LuaFunction m_SelectedBoolean_hotfix;

		// Token: 0x040067AF RID: 26543
		private LuaFunction m_add_OnHeroHeadClickEventAction;

		// Token: 0x040067B0 RID: 26544
		private LuaFunction m_remove_OnHeroHeadClickEventAction;

		// Token: 0x020009E7 RID: 2535
		public new class LuaExportHelper
		{
			// Token: 0x06009649 RID: 38473 RVA: 0x002B05E4 File Offset: 0x002AE7E4
			public LuaExportHelper(HeroHeadUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600964A RID: 38474 RVA: 0x002B05F4 File Offset: 0x002AE7F4
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0600964B RID: 38475 RVA: 0x002B0604 File Offset: 0x002AE804
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0600964C RID: 38476 RVA: 0x002B0614 File Offset: 0x002AE814
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600964D RID: 38477 RVA: 0x002B0624 File Offset: 0x002AE824
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600964E RID: 38478 RVA: 0x002B063C File Offset: 0x002AE83C
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0600964F RID: 38479 RVA: 0x002B064C File Offset: 0x002AE84C
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x06009650 RID: 38480 RVA: 0x002B065C File Offset: 0x002AE85C
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x06009651 RID: 38481 RVA: 0x002B066C File Offset: 0x002AE86C
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x06009652 RID: 38482 RVA: 0x002B067C File Offset: 0x002AE87C
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x06009653 RID: 38483 RVA: 0x002B068C File Offset: 0x002AE88C
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x06009654 RID: 38484 RVA: 0x002B069C File Offset: 0x002AE89C
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x06009655 RID: 38485 RVA: 0x002B06AC File Offset: 0x002AE8AC
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x06009656 RID: 38486 RVA: 0x002B06BC File Offset: 0x002AE8BC
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x06009657 RID: 38487 RVA: 0x002B06CC File Offset: 0x002AE8CC
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x06009658 RID: 38488 RVA: 0x002B06DC File Offset: 0x002AE8DC
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x06009659 RID: 38489 RVA: 0x002B06EC File Offset: 0x002AE8EC
			public void __callDele_OnHeroHeadClickEvent(HeroHeadUIController obj)
			{
				this.m_owner.__callDele_OnHeroHeadClickEvent(obj);
			}

			// Token: 0x0600965A RID: 38490 RVA: 0x002B06FC File Offset: 0x002AE8FC
			public void __clearDele_OnHeroHeadClickEvent(HeroHeadUIController obj)
			{
				this.m_owner.__clearDele_OnHeroHeadClickEvent(obj);
			}

			// Token: 0x17001F00 RID: 7936
			// (get) Token: 0x0600965B RID: 38491 RVA: 0x002B070C File Offset: 0x002AE90C
			// (set) Token: 0x0600965C RID: 38492 RVA: 0x002B071C File Offset: 0x002AE91C
			public Button m_heroHeadButton
			{
				get
				{
					return this.m_owner.m_heroHeadButton;
				}
				set
				{
					this.m_owner.m_heroHeadButton = value;
				}
			}

			// Token: 0x17001F01 RID: 7937
			// (get) Token: 0x0600965D RID: 38493 RVA: 0x002B072C File Offset: 0x002AE92C
			// (set) Token: 0x0600965E RID: 38494 RVA: 0x002B073C File Offset: 0x002AE93C
			public CommonUIStateController m_heroHeadAnimation
			{
				get
				{
					return this.m_owner.m_heroHeadAnimation;
				}
				set
				{
					this.m_owner.m_heroHeadAnimation = value;
				}
			}

			// Token: 0x17001F02 RID: 7938
			// (get) Token: 0x0600965F RID: 38495 RVA: 0x002B074C File Offset: 0x002AE94C
			// (set) Token: 0x06009660 RID: 38496 RVA: 0x002B075C File Offset: 0x002AE95C
			public Image m_selectImage
			{
				get
				{
					return this.m_owner.m_selectImage;
				}
				set
				{
					this.m_owner.m_selectImage = value;
				}
			}

			// Token: 0x17001F03 RID: 7939
			// (get) Token: 0x06009661 RID: 38497 RVA: 0x002B076C File Offset: 0x002AE96C
			// (set) Token: 0x06009662 RID: 38498 RVA: 0x002B077C File Offset: 0x002AE97C
			public Image m_cardIamge
			{
				get
				{
					return this.m_owner.m_cardIamge;
				}
				set
				{
					this.m_owner.m_cardIamge = value;
				}
			}

			// Token: 0x17001F04 RID: 7940
			// (get) Token: 0x06009663 RID: 38499 RVA: 0x002B078C File Offset: 0x002AE98C
			// (set) Token: 0x06009664 RID: 38500 RVA: 0x002B079C File Offset: 0x002AE99C
			public Text m_heroNameText
			{
				get
				{
					return this.m_owner.m_heroNameText;
				}
				set
				{
					this.m_owner.m_heroNameText = value;
				}
			}

			// Token: 0x06009665 RID: 38501 RVA: 0x002B07AC File Offset: 0x002AE9AC
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x040067B1 RID: 26545
			private HeroHeadUIController m_owner;
		}
	}
}
