using System;
using System.Threading;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.Scene;
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000C41 RID: 3137
	[HotFix]
	public class SoldierManualItemUIController : UIControllerBase
	{
		// Token: 0x0600DCD9 RID: 56537 RVA: 0x003BCB78 File Offset: 0x003BAD78
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
			base.gameObject.GetComponent<Button>().onClick.AddListener(new UnityAction(this.OnSoldierItemClick));
			base.gameObject.SetActive(true);
		}

		// Token: 0x0600DCDA RID: 56538 RVA: 0x003BCC0C File Offset: 0x003BAE0C
		public void InitSoldierItem(ConfigDataSoldierInfo soldierInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitSoldierItemConfigDataSoldierInfo_hotfix != null)
			{
				this.m_InitSoldierItemConfigDataSoldierInfo_hotfix.call(new object[]
				{
					this,
					soldierInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.SoldierInfo = soldierInfo;
			this.m_soldierNameText.text = soldierInfo.Name;
			float scale = (float)soldierInfo.UI_ModelScale * 0.01f;
			Vector2 offset = new Vector2((float)soldierInfo.UI_ModelOffsetX, (float)soldierInfo.UI_ModelOffsetY);
			HeroDetailUIController.CreateSpineGraphic(ref this.m_graphic, soldierInfo.Model, this.m_soldierGraphic, 1, offset, scale, soldierInfo.ReplaceAnims);
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			bool flag = projectLPlayerContext.IsExistSoliderId(soldierInfo.ID);
			this.m_lockObj.SetActive(!flag);
			if (!flag)
			{
				this.m_graphic.SetColor(UIUtility.MyGrayColor);
			}
		}

		// Token: 0x0600DCDB RID: 56539 RVA: 0x003BCD1C File Offset: 0x003BAF1C
		private void OnSoldierItemClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnSoldierItemClick_hotfix != null)
			{
				this.m_OnSoldierItemClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnSoldierItemClick != null)
			{
				this.EventOnSoldierItemClick(this);
			}
		}

		// Token: 0x0600DCDC RID: 56540 RVA: 0x003BCD94 File Offset: 0x003BAF94
		public void SetClickImageActive(bool isShow)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetClickImageActiveBoolean_hotfix != null)
			{
				this.m_SetClickImageActiveBoolean_hotfix.call(new object[]
				{
					this,
					isShow
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_clickImage.SetActive(isShow);
		}

		// Token: 0x140002BC RID: 700
		// (add) Token: 0x0600DCDD RID: 56541 RVA: 0x003BCE10 File Offset: 0x003BB010
		// (remove) Token: 0x0600DCDE RID: 56542 RVA: 0x003BCEAC File Offset: 0x003BB0AC
		public event Action<SoldierManualItemUIController> EventOnSoldierItemClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnSoldierItemClickAction`1_hotfix != null)
				{
					this.m_add_EventOnSoldierItemClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<SoldierManualItemUIController> action = this.EventOnSoldierItemClick;
				Action<SoldierManualItemUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<SoldierManualItemUIController>>(ref this.EventOnSoldierItemClick, (Action<SoldierManualItemUIController>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnSoldierItemClickAction`1_hotfix != null)
				{
					this.m_remove_EventOnSoldierItemClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<SoldierManualItemUIController> action = this.EventOnSoldierItemClick;
				Action<SoldierManualItemUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<SoldierManualItemUIController>>(ref this.EventOnSoldierItemClick, (Action<SoldierManualItemUIController>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17002ADD RID: 10973
		// (get) Token: 0x0600DCDF RID: 56543 RVA: 0x003BCF48 File Offset: 0x003BB148
		// (set) Token: 0x0600DCE0 RID: 56544 RVA: 0x003BCF68 File Offset: 0x003BB168
		[DoNotToLua]
		public new SoldierManualItemUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new SoldierManualItemUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600DCE1 RID: 56545 RVA: 0x003BCF74 File Offset: 0x003BB174
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0600DCE2 RID: 56546 RVA: 0x003BCF80 File Offset: 0x003BB180
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0600DCE3 RID: 56547 RVA: 0x003BCF88 File Offset: 0x003BB188
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0600DCE4 RID: 56548 RVA: 0x003BCF90 File Offset: 0x003BB190
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0600DCE5 RID: 56549 RVA: 0x003BCFA4 File Offset: 0x003BB1A4
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0600DCE6 RID: 56550 RVA: 0x003BCFAC File Offset: 0x003BB1AC
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0600DCE7 RID: 56551 RVA: 0x003BCFB8 File Offset: 0x003BB1B8
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0600DCE8 RID: 56552 RVA: 0x003BCFC4 File Offset: 0x003BB1C4
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0600DCE9 RID: 56553 RVA: 0x003BCFD0 File Offset: 0x003BB1D0
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0600DCEA RID: 56554 RVA: 0x003BCFDC File Offset: 0x003BB1DC
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0600DCEB RID: 56555 RVA: 0x003BCFE8 File Offset: 0x003BB1E8
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0600DCEC RID: 56556 RVA: 0x003BCFF4 File Offset: 0x003BB1F4
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0600DCED RID: 56557 RVA: 0x003BD000 File Offset: 0x003BB200
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0600DCEE RID: 56558 RVA: 0x003BD00C File Offset: 0x003BB20C
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0600DCEF RID: 56559 RVA: 0x003BD018 File Offset: 0x003BB218
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600DCF0 RID: 56560 RVA: 0x003BD020 File Offset: 0x003BB220
		private void __callDele_EventOnSoldierItemClick(SoldierManualItemUIController obj)
		{
			Action<SoldierManualItemUIController> eventOnSoldierItemClick = this.EventOnSoldierItemClick;
			if (eventOnSoldierItemClick != null)
			{
				eventOnSoldierItemClick(obj);
			}
		}

		// Token: 0x0600DCF1 RID: 56561 RVA: 0x003BD044 File Offset: 0x003BB244
		private void __clearDele_EventOnSoldierItemClick(SoldierManualItemUIController obj)
		{
			this.EventOnSoldierItemClick = null;
		}

		// Token: 0x0600DCF2 RID: 56562 RVA: 0x003BD050 File Offset: 0x003BB250
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
					this.m_InitSoldierItemConfigDataSoldierInfo_hotfix = (luaObj.RawGet("InitSoldierItem") as LuaFunction);
					this.m_OnSoldierItemClick_hotfix = (luaObj.RawGet("OnSoldierItemClick") as LuaFunction);
					this.m_SetClickImageActiveBoolean_hotfix = (luaObj.RawGet("SetClickImageActive") as LuaFunction);
					this.m_add_EventOnSoldierItemClickAction`1_hotfix = (luaObj.RawGet("add_EventOnSoldierItemClick") as LuaFunction);
					this.m_remove_EventOnSoldierItemClickAction`1_hotfix = (luaObj.RawGet("remove_EventOnSoldierItemClick") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600DCF3 RID: 56563 RVA: 0x003BD198 File Offset: 0x003BB398
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(SoldierManualItemUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040086F8 RID: 34552
		[AutoBind("./NameText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_soldierNameText;

		// Token: 0x040086F9 RID: 34553
		[AutoBind("./ClickImage", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_clickImage;

		// Token: 0x040086FA RID: 34554
		[AutoBind("./LockImage", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_lockObj;

		// Token: 0x040086FB RID: 34555
		[AutoBind("./Char", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_soldierGraphic;

		// Token: 0x040086FC RID: 34556
		private UISpineGraphic m_graphic;

		// Token: 0x040086FD RID: 34557
		public ConfigDataSoldierInfo SoldierInfo;

		// Token: 0x040086FE RID: 34558
		[DoNotToLua]
		private SoldierManualItemUIController.LuaExportHelper luaExportHelper;

		// Token: 0x040086FF RID: 34559
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04008700 RID: 34560
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04008701 RID: 34561
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x04008702 RID: 34562
		private LuaFunction m_InitSoldierItemConfigDataSoldierInfo_hotfix;

		// Token: 0x04008703 RID: 34563
		private LuaFunction m_OnSoldierItemClick_hotfix;

		// Token: 0x04008704 RID: 34564
		private LuaFunction m_SetClickImageActiveBoolean_hotfix;

		// Token: 0x04008705 RID: 34565
		private LuaFunction m_add_EventOnSoldierItemClickAction;

		// Token: 0x04008706 RID: 34566
		private LuaFunction m_remove_EventOnSoldierItemClickAction;

		// Token: 0x02000C42 RID: 3138
		public new class LuaExportHelper
		{
			// Token: 0x0600DCF4 RID: 56564 RVA: 0x003BD200 File Offset: 0x003BB400
			public LuaExportHelper(SoldierManualItemUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600DCF5 RID: 56565 RVA: 0x003BD210 File Offset: 0x003BB410
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0600DCF6 RID: 56566 RVA: 0x003BD220 File Offset: 0x003BB420
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0600DCF7 RID: 56567 RVA: 0x003BD230 File Offset: 0x003BB430
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600DCF8 RID: 56568 RVA: 0x003BD240 File Offset: 0x003BB440
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600DCF9 RID: 56569 RVA: 0x003BD258 File Offset: 0x003BB458
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0600DCFA RID: 56570 RVA: 0x003BD268 File Offset: 0x003BB468
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0600DCFB RID: 56571 RVA: 0x003BD278 File Offset: 0x003BB478
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0600DCFC RID: 56572 RVA: 0x003BD288 File Offset: 0x003BB488
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0600DCFD RID: 56573 RVA: 0x003BD298 File Offset: 0x003BB498
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0600DCFE RID: 56574 RVA: 0x003BD2A8 File Offset: 0x003BB4A8
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0600DCFF RID: 56575 RVA: 0x003BD2B8 File Offset: 0x003BB4B8
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0600DD00 RID: 56576 RVA: 0x003BD2C8 File Offset: 0x003BB4C8
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0600DD01 RID: 56577 RVA: 0x003BD2D8 File Offset: 0x003BB4D8
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0600DD02 RID: 56578 RVA: 0x003BD2E8 File Offset: 0x003BB4E8
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0600DD03 RID: 56579 RVA: 0x003BD2F8 File Offset: 0x003BB4F8
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x0600DD04 RID: 56580 RVA: 0x003BD308 File Offset: 0x003BB508
			public void __callDele_EventOnSoldierItemClick(SoldierManualItemUIController obj)
			{
				this.m_owner.__callDele_EventOnSoldierItemClick(obj);
			}

			// Token: 0x0600DD05 RID: 56581 RVA: 0x003BD318 File Offset: 0x003BB518
			public void __clearDele_EventOnSoldierItemClick(SoldierManualItemUIController obj)
			{
				this.m_owner.__clearDele_EventOnSoldierItemClick(obj);
			}

			// Token: 0x17002ADE RID: 10974
			// (get) Token: 0x0600DD06 RID: 56582 RVA: 0x003BD328 File Offset: 0x003BB528
			// (set) Token: 0x0600DD07 RID: 56583 RVA: 0x003BD338 File Offset: 0x003BB538
			public Text m_soldierNameText
			{
				get
				{
					return this.m_owner.m_soldierNameText;
				}
				set
				{
					this.m_owner.m_soldierNameText = value;
				}
			}

			// Token: 0x17002ADF RID: 10975
			// (get) Token: 0x0600DD08 RID: 56584 RVA: 0x003BD348 File Offset: 0x003BB548
			// (set) Token: 0x0600DD09 RID: 56585 RVA: 0x003BD358 File Offset: 0x003BB558
			public GameObject m_clickImage
			{
				get
				{
					return this.m_owner.m_clickImage;
				}
				set
				{
					this.m_owner.m_clickImage = value;
				}
			}

			// Token: 0x17002AE0 RID: 10976
			// (get) Token: 0x0600DD0A RID: 56586 RVA: 0x003BD368 File Offset: 0x003BB568
			// (set) Token: 0x0600DD0B RID: 56587 RVA: 0x003BD378 File Offset: 0x003BB578
			public GameObject m_lockObj
			{
				get
				{
					return this.m_owner.m_lockObj;
				}
				set
				{
					this.m_owner.m_lockObj = value;
				}
			}

			// Token: 0x17002AE1 RID: 10977
			// (get) Token: 0x0600DD0C RID: 56588 RVA: 0x003BD388 File Offset: 0x003BB588
			// (set) Token: 0x0600DD0D RID: 56589 RVA: 0x003BD398 File Offset: 0x003BB598
			public GameObject m_soldierGraphic
			{
				get
				{
					return this.m_owner.m_soldierGraphic;
				}
				set
				{
					this.m_owner.m_soldierGraphic = value;
				}
			}

			// Token: 0x17002AE2 RID: 10978
			// (get) Token: 0x0600DD0E RID: 56590 RVA: 0x003BD3A8 File Offset: 0x003BB5A8
			// (set) Token: 0x0600DD0F RID: 56591 RVA: 0x003BD3B8 File Offset: 0x003BB5B8
			public UISpineGraphic m_graphic
			{
				get
				{
					return this.m_owner.m_graphic;
				}
				set
				{
					this.m_owner.m_graphic = value;
				}
			}

			// Token: 0x0600DD10 RID: 56592 RVA: 0x003BD3C8 File Offset: 0x003BB5C8
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0600DD11 RID: 56593 RVA: 0x003BD3D8 File Offset: 0x003BB5D8
			public void OnSoldierItemClick()
			{
				this.m_owner.OnSoldierItemClick();
			}

			// Token: 0x04008707 RID: 34567
			private SoldierManualItemUIController m_owner;
		}
	}
}
