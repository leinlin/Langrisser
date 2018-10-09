using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using SLua;
using UnityEngine;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000F16 RID: 3862
	[HotFix]
	public class BoxItemInfoUIController : UIControllerBase
	{
		// Token: 0x06013283 RID: 78467 RVA: 0x004E1E74 File Offset: 0x004E0074
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
		}

		// Token: 0x06013284 RID: 78468 RVA: 0x004E1EE8 File Offset: 0x004E00E8
		public void SetBoxItemInfo(Goods good, bool isPresent)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetBoxItemInfoGoodsBoolean_hotfix != null)
			{
				this.m_SetBoxItemInfoGoodsBoolean_hotfix.call(new object[]
				{
					this,
					good,
					isPresent
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GameObject assetInContainer = base.GetAssetInContainer<GameObject>("BoxItem");
			RewardGoodsUIController.CreateRewardGoods(good, this.m_itemGoodsDummy.transform, assetInContainer, false, 0);
			string format = this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Store_ItemCount);
			this.m_itemNameText.text = string.Format(format, UIUtility.GetGoodsName(good.GoodsType, good.Id), good.Count.ToString());
			if (isPresent)
			{
				this.m_presentLogo.SetActive(true);
			}
		}

		// Token: 0x170039B8 RID: 14776
		// (get) Token: 0x06013285 RID: 78469 RVA: 0x004E1FE4 File Offset: 0x004E01E4
		// (set) Token: 0x06013286 RID: 78470 RVA: 0x004E2004 File Offset: 0x004E0204
		[DoNotToLua]
		public new BoxItemInfoUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new BoxItemInfoUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06013287 RID: 78471 RVA: 0x004E2010 File Offset: 0x004E0210
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x06013288 RID: 78472 RVA: 0x004E201C File Offset: 0x004E021C
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x06013289 RID: 78473 RVA: 0x004E2024 File Offset: 0x004E0224
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0601328A RID: 78474 RVA: 0x004E202C File Offset: 0x004E022C
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0601328B RID: 78475 RVA: 0x004E2040 File Offset: 0x004E0240
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0601328C RID: 78476 RVA: 0x004E2048 File Offset: 0x004E0248
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0601328D RID: 78477 RVA: 0x004E2054 File Offset: 0x004E0254
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0601328E RID: 78478 RVA: 0x004E2060 File Offset: 0x004E0260
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0601328F RID: 78479 RVA: 0x004E206C File Offset: 0x004E026C
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x06013290 RID: 78480 RVA: 0x004E2078 File Offset: 0x004E0278
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x06013291 RID: 78481 RVA: 0x004E2084 File Offset: 0x004E0284
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x06013292 RID: 78482 RVA: 0x004E2090 File Offset: 0x004E0290
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x06013293 RID: 78483 RVA: 0x004E209C File Offset: 0x004E029C
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x06013294 RID: 78484 RVA: 0x004E20A8 File Offset: 0x004E02A8
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x06013295 RID: 78485 RVA: 0x004E20B4 File Offset: 0x004E02B4
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x06013296 RID: 78486 RVA: 0x004E20BC File Offset: 0x004E02BC
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
					this.m_SetBoxItemInfoGoodsBoolean_hotfix = (luaObj.RawGet("SetBoxItemInfo") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06013297 RID: 78487 RVA: 0x004E21A0 File Offset: 0x004E03A0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BoxItemInfoUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400AA8E RID: 43662
		[AutoBind("./ItemGoodsDummy", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_itemGoodsDummy;

		// Token: 0x0400AA8F RID: 43663
		[AutoBind("./NameText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_itemNameText;

		// Token: 0x0400AA90 RID: 43664
		[AutoBind("./PresentImage", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_presentLogo;

		// Token: 0x0400AA91 RID: 43665
		private IConfigDataLoader m_configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;

		// Token: 0x0400AA92 RID: 43666
		[DoNotToLua]
		private BoxItemInfoUIController.LuaExportHelper luaExportHelper;

		// Token: 0x0400AA93 RID: 43667
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400AA94 RID: 43668
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400AA95 RID: 43669
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x0400AA96 RID: 43670
		private LuaFunction m_SetBoxItemInfoGoodsBoolean_hotfix;

		// Token: 0x02000F17 RID: 3863
		public new class LuaExportHelper
		{
			// Token: 0x06013298 RID: 78488 RVA: 0x004E2208 File Offset: 0x004E0408
			public LuaExportHelper(BoxItemInfoUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06013299 RID: 78489 RVA: 0x004E2218 File Offset: 0x004E0418
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0601329A RID: 78490 RVA: 0x004E2228 File Offset: 0x004E0428
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0601329B RID: 78491 RVA: 0x004E2238 File Offset: 0x004E0438
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0601329C RID: 78492 RVA: 0x004E2248 File Offset: 0x004E0448
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0601329D RID: 78493 RVA: 0x004E2260 File Offset: 0x004E0460
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0601329E RID: 78494 RVA: 0x004E2270 File Offset: 0x004E0470
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0601329F RID: 78495 RVA: 0x004E2280 File Offset: 0x004E0480
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x060132A0 RID: 78496 RVA: 0x004E2290 File Offset: 0x004E0490
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x060132A1 RID: 78497 RVA: 0x004E22A0 File Offset: 0x004E04A0
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x060132A2 RID: 78498 RVA: 0x004E22B0 File Offset: 0x004E04B0
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x060132A3 RID: 78499 RVA: 0x004E22C0 File Offset: 0x004E04C0
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x060132A4 RID: 78500 RVA: 0x004E22D0 File Offset: 0x004E04D0
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x060132A5 RID: 78501 RVA: 0x004E22E0 File Offset: 0x004E04E0
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x060132A6 RID: 78502 RVA: 0x004E22F0 File Offset: 0x004E04F0
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x060132A7 RID: 78503 RVA: 0x004E2300 File Offset: 0x004E0500
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x170039B9 RID: 14777
			// (get) Token: 0x060132A8 RID: 78504 RVA: 0x004E2310 File Offset: 0x004E0510
			// (set) Token: 0x060132A9 RID: 78505 RVA: 0x004E2320 File Offset: 0x004E0520
			public GameObject m_itemGoodsDummy
			{
				get
				{
					return this.m_owner.m_itemGoodsDummy;
				}
				set
				{
					this.m_owner.m_itemGoodsDummy = value;
				}
			}

			// Token: 0x170039BA RID: 14778
			// (get) Token: 0x060132AA RID: 78506 RVA: 0x004E2330 File Offset: 0x004E0530
			// (set) Token: 0x060132AB RID: 78507 RVA: 0x004E2340 File Offset: 0x004E0540
			public Text m_itemNameText
			{
				get
				{
					return this.m_owner.m_itemNameText;
				}
				set
				{
					this.m_owner.m_itemNameText = value;
				}
			}

			// Token: 0x170039BB RID: 14779
			// (get) Token: 0x060132AC RID: 78508 RVA: 0x004E2350 File Offset: 0x004E0550
			// (set) Token: 0x060132AD RID: 78509 RVA: 0x004E2360 File Offset: 0x004E0560
			public GameObject m_presentLogo
			{
				get
				{
					return this.m_owner.m_presentLogo;
				}
				set
				{
					this.m_owner.m_presentLogo = value;
				}
			}

			// Token: 0x170039BC RID: 14780
			// (get) Token: 0x060132AE RID: 78510 RVA: 0x004E2370 File Offset: 0x004E0570
			// (set) Token: 0x060132AF RID: 78511 RVA: 0x004E2380 File Offset: 0x004E0580
			public IConfigDataLoader m_configDataLoader
			{
				get
				{
					return this.m_owner.m_configDataLoader;
				}
				set
				{
					this.m_owner.m_configDataLoader = value;
				}
			}

			// Token: 0x060132B0 RID: 78512 RVA: 0x004E2390 File Offset: 0x004E0590
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0400AA97 RID: 43671
			private BoxItemInfoUIController m_owner;
		}
	}
}
