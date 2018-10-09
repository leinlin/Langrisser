using System;
using System.Threading;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Misc;
using BlackJack.ProjectL.PlayerContext;
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000D6F RID: 3439
	[HotFix]
	public class EquipmentBreakNeedItemUIController : UIControllerBase
	{
		// Token: 0x0600FF4A RID: 65354 RVA: 0x0042FD6C File Offset: 0x0042DF6C
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
			this.m_button.onClick.AddListener(new UnityAction(this.OnClick));
		}

		// Token: 0x0600FF4B RID: 65355 RVA: 0x0042FDF0 File Offset: 0x0042DFF0
		public void InitEquipmentBreakNeedItem(Goods goods)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitEquipmentBreakNeedItemGoods_hotfix != null)
			{
				this.m_InitEquipmentBreakNeedItemGoods_hotfix.call(new object[]
				{
					this,
					goods
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIStateController component = base.gameObject.GetComponent<CommonUIStateController>();
			if (goods == null || goods.GoodsType != GoodsType.GoodsType_Item)
			{
				component.SetToUIState("NotHave", false, true);
				this.m_iconSSREffect.SetActive(false);
				this.m_goods = null;
				return;
			}
			component.SetToUIState("Have", false, true);
			this.m_goods = goods;
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			ConfigDataItemInfo configDataItemInfo = configDataLoader.GetConfigDataItemInfo(goods.Id);
			this.m_icon.sprite = AssetUtility.Instance.GetSprite(configDataItemInfo.Icon);
			this.m_iconBg.sprite = AssetUtility.Instance.GetSprite(UIUtility.GetGoodsFrameNameByRank(configDataItemInfo.Rank));
			this.m_iconSSREffect.SetActive(UIUtility.IsRankSSR(configDataItemInfo.Rank));
			int bagItemCountByType = projectLPlayerContext.GetBagItemCountByType(goods.GoodsType, goods.Id);
			this.m_haveCount.text = bagItemCountByType.ToString();
			this.m_needCount.text = goods.Count.ToString();
			if (bagItemCountByType < goods.Count)
			{
				this.m_countStateCtrl.SetToUIState("Red", false, true);
			}
			else
			{
				this.m_countStateCtrl.SetToUIState("White", false, true);
			}
		}

		// Token: 0x0600FF4C RID: 65356 RVA: 0x0042FFB4 File Offset: 0x0042E1B4
		private void OnClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnClick_hotfix != null)
			{
				this.m_OnClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnClick != null && this.m_goods != null)
			{
				this.EventOnClick(this.m_goods.GoodsType, this.m_goods.Id, this.m_goods.Count);
			}
		}

		// Token: 0x1400035D RID: 861
		// (add) Token: 0x0600FF4D RID: 65357 RVA: 0x00430058 File Offset: 0x0042E258
		// (remove) Token: 0x0600FF4E RID: 65358 RVA: 0x004300F4 File Offset: 0x0042E2F4
		public event Action<GoodsType, int, int> EventOnClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnClickAction`3_hotfix != null)
				{
					this.m_add_EventOnClickAction`3_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<GoodsType, int, int> action = this.EventOnClick;
				Action<GoodsType, int, int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<GoodsType, int, int>>(ref this.EventOnClick, (Action<GoodsType, int, int>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnClickAction`3_hotfix != null)
				{
					this.m_remove_EventOnClickAction`3_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<GoodsType, int, int> action = this.EventOnClick;
				Action<GoodsType, int, int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<GoodsType, int, int>>(ref this.EventOnClick, (Action<GoodsType, int, int>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1700311C RID: 12572
		// (get) Token: 0x0600FF4F RID: 65359 RVA: 0x00430190 File Offset: 0x0042E390
		// (set) Token: 0x0600FF50 RID: 65360 RVA: 0x004301B0 File Offset: 0x0042E3B0
		[DoNotToLua]
		public new EquipmentBreakNeedItemUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new EquipmentBreakNeedItemUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600FF51 RID: 65361 RVA: 0x004301BC File Offset: 0x0042E3BC
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0600FF52 RID: 65362 RVA: 0x004301C8 File Offset: 0x0042E3C8
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0600FF53 RID: 65363 RVA: 0x004301D0 File Offset: 0x0042E3D0
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0600FF54 RID: 65364 RVA: 0x004301D8 File Offset: 0x0042E3D8
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0600FF55 RID: 65365 RVA: 0x004301EC File Offset: 0x0042E3EC
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0600FF56 RID: 65366 RVA: 0x004301F4 File Offset: 0x0042E3F4
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0600FF57 RID: 65367 RVA: 0x00430200 File Offset: 0x0042E400
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0600FF58 RID: 65368 RVA: 0x0043020C File Offset: 0x0042E40C
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0600FF59 RID: 65369 RVA: 0x00430218 File Offset: 0x0042E418
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0600FF5A RID: 65370 RVA: 0x00430224 File Offset: 0x0042E424
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0600FF5B RID: 65371 RVA: 0x00430230 File Offset: 0x0042E430
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0600FF5C RID: 65372 RVA: 0x0043023C File Offset: 0x0042E43C
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0600FF5D RID: 65373 RVA: 0x00430248 File Offset: 0x0042E448
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0600FF5E RID: 65374 RVA: 0x00430254 File Offset: 0x0042E454
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0600FF5F RID: 65375 RVA: 0x00430260 File Offset: 0x0042E460
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600FF60 RID: 65376 RVA: 0x00430268 File Offset: 0x0042E468
		private void __callDele_EventOnClick(GoodsType arg1, int arg2, int arg3)
		{
			Action<GoodsType, int, int> eventOnClick = this.EventOnClick;
			if (eventOnClick != null)
			{
				eventOnClick(arg1, arg2, arg3);
			}
		}

		// Token: 0x0600FF61 RID: 65377 RVA: 0x0043028C File Offset: 0x0042E48C
		private void __clearDele_EventOnClick(GoodsType arg1, int arg2, int arg3)
		{
			this.EventOnClick = null;
		}

		// Token: 0x0600FF62 RID: 65378 RVA: 0x00430298 File Offset: 0x0042E498
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
					this.m_InitEquipmentBreakNeedItemGoods_hotfix = (luaObj.RawGet("InitEquipmentBreakNeedItem") as LuaFunction);
					this.m_OnClick_hotfix = (luaObj.RawGet("OnClick") as LuaFunction);
					this.m_add_EventOnClickAction`3_hotfix = (luaObj.RawGet("add_EventOnClick") as LuaFunction);
					this.m_remove_EventOnClickAction`3_hotfix = (luaObj.RawGet("remove_EventOnClick") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600FF63 RID: 65379 RVA: 0x004303C8 File Offset: 0x0042E5C8
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(EquipmentBreakNeedItemUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04009560 RID: 38240
		[AutoBind("./IconBg", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_iconBg;

		// Token: 0x04009561 RID: 38241
		[AutoBind("./SSREffect", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_iconSSREffect;

		// Token: 0x04009562 RID: 38242
		[AutoBind("./Icon", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_icon;

		// Token: 0x04009563 RID: 38243
		[AutoBind("./ValueGroup/HaveCount", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_haveCount;

		// Token: 0x04009564 RID: 38244
		[AutoBind("./ValueGroup/NeedCount", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_needCount;

		// Token: 0x04009565 RID: 38245
		[AutoBind("./ValueGroup", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_countStateCtrl;

		// Token: 0x04009566 RID: 38246
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_button;

		// Token: 0x04009567 RID: 38247
		public Goods m_goods;

		// Token: 0x04009568 RID: 38248
		[DoNotToLua]
		private EquipmentBreakNeedItemUIController.LuaExportHelper luaExportHelper;

		// Token: 0x04009569 RID: 38249
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400956A RID: 38250
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400956B RID: 38251
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x0400956C RID: 38252
		private LuaFunction m_InitEquipmentBreakNeedItemGoods_hotfix;

		// Token: 0x0400956D RID: 38253
		private LuaFunction m_OnClick_hotfix;

		// Token: 0x0400956E RID: 38254
		private LuaFunction m_add_EventOnClickAction;

		// Token: 0x0400956F RID: 38255
		private LuaFunction m_remove_EventOnClickAction;

		// Token: 0x02000D70 RID: 3440
		public new class LuaExportHelper
		{
			// Token: 0x0600FF64 RID: 65380 RVA: 0x00430430 File Offset: 0x0042E630
			public LuaExportHelper(EquipmentBreakNeedItemUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600FF65 RID: 65381 RVA: 0x00430440 File Offset: 0x0042E640
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0600FF66 RID: 65382 RVA: 0x00430450 File Offset: 0x0042E650
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0600FF67 RID: 65383 RVA: 0x00430460 File Offset: 0x0042E660
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600FF68 RID: 65384 RVA: 0x00430470 File Offset: 0x0042E670
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600FF69 RID: 65385 RVA: 0x00430488 File Offset: 0x0042E688
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0600FF6A RID: 65386 RVA: 0x00430498 File Offset: 0x0042E698
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0600FF6B RID: 65387 RVA: 0x004304A8 File Offset: 0x0042E6A8
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0600FF6C RID: 65388 RVA: 0x004304B8 File Offset: 0x0042E6B8
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0600FF6D RID: 65389 RVA: 0x004304C8 File Offset: 0x0042E6C8
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0600FF6E RID: 65390 RVA: 0x004304D8 File Offset: 0x0042E6D8
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0600FF6F RID: 65391 RVA: 0x004304E8 File Offset: 0x0042E6E8
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0600FF70 RID: 65392 RVA: 0x004304F8 File Offset: 0x0042E6F8
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0600FF71 RID: 65393 RVA: 0x00430508 File Offset: 0x0042E708
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0600FF72 RID: 65394 RVA: 0x00430518 File Offset: 0x0042E718
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0600FF73 RID: 65395 RVA: 0x00430528 File Offset: 0x0042E728
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x0600FF74 RID: 65396 RVA: 0x00430538 File Offset: 0x0042E738
			public void __callDele_EventOnClick(GoodsType arg1, int arg2, int arg3)
			{
				this.m_owner.__callDele_EventOnClick(arg1, arg2, arg3);
			}

			// Token: 0x0600FF75 RID: 65397 RVA: 0x00430548 File Offset: 0x0042E748
			public void __clearDele_EventOnClick(GoodsType arg1, int arg2, int arg3)
			{
				this.m_owner.__clearDele_EventOnClick(arg1, arg2, arg3);
			}

			// Token: 0x1700311D RID: 12573
			// (get) Token: 0x0600FF76 RID: 65398 RVA: 0x00430558 File Offset: 0x0042E758
			// (set) Token: 0x0600FF77 RID: 65399 RVA: 0x00430568 File Offset: 0x0042E768
			public Image m_iconBg
			{
				get
				{
					return this.m_owner.m_iconBg;
				}
				set
				{
					this.m_owner.m_iconBg = value;
				}
			}

			// Token: 0x1700311E RID: 12574
			// (get) Token: 0x0600FF78 RID: 65400 RVA: 0x00430578 File Offset: 0x0042E778
			// (set) Token: 0x0600FF79 RID: 65401 RVA: 0x00430588 File Offset: 0x0042E788
			public GameObject m_iconSSREffect
			{
				get
				{
					return this.m_owner.m_iconSSREffect;
				}
				set
				{
					this.m_owner.m_iconSSREffect = value;
				}
			}

			// Token: 0x1700311F RID: 12575
			// (get) Token: 0x0600FF7A RID: 65402 RVA: 0x00430598 File Offset: 0x0042E798
			// (set) Token: 0x0600FF7B RID: 65403 RVA: 0x004305A8 File Offset: 0x0042E7A8
			public Image m_icon
			{
				get
				{
					return this.m_owner.m_icon;
				}
				set
				{
					this.m_owner.m_icon = value;
				}
			}

			// Token: 0x17003120 RID: 12576
			// (get) Token: 0x0600FF7C RID: 65404 RVA: 0x004305B8 File Offset: 0x0042E7B8
			// (set) Token: 0x0600FF7D RID: 65405 RVA: 0x004305C8 File Offset: 0x0042E7C8
			public Text m_haveCount
			{
				get
				{
					return this.m_owner.m_haveCount;
				}
				set
				{
					this.m_owner.m_haveCount = value;
				}
			}

			// Token: 0x17003121 RID: 12577
			// (get) Token: 0x0600FF7E RID: 65406 RVA: 0x004305D8 File Offset: 0x0042E7D8
			// (set) Token: 0x0600FF7F RID: 65407 RVA: 0x004305E8 File Offset: 0x0042E7E8
			public Text m_needCount
			{
				get
				{
					return this.m_owner.m_needCount;
				}
				set
				{
					this.m_owner.m_needCount = value;
				}
			}

			// Token: 0x17003122 RID: 12578
			// (get) Token: 0x0600FF80 RID: 65408 RVA: 0x004305F8 File Offset: 0x0042E7F8
			// (set) Token: 0x0600FF81 RID: 65409 RVA: 0x00430608 File Offset: 0x0042E808
			public CommonUIStateController m_countStateCtrl
			{
				get
				{
					return this.m_owner.m_countStateCtrl;
				}
				set
				{
					this.m_owner.m_countStateCtrl = value;
				}
			}

			// Token: 0x17003123 RID: 12579
			// (get) Token: 0x0600FF82 RID: 65410 RVA: 0x00430618 File Offset: 0x0042E818
			// (set) Token: 0x0600FF83 RID: 65411 RVA: 0x00430628 File Offset: 0x0042E828
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

			// Token: 0x0600FF84 RID: 65412 RVA: 0x00430638 File Offset: 0x0042E838
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0600FF85 RID: 65413 RVA: 0x00430648 File Offset: 0x0042E848
			public void OnClick()
			{
				this.m_owner.OnClick();
			}

			// Token: 0x04009570 RID: 38256
			private EquipmentBreakNeedItemUIController m_owner;
		}
	}
}
