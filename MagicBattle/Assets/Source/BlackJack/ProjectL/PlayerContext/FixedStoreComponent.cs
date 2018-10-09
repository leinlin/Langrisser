using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.PlayerContext
{
	// Token: 0x020008A9 RID: 2217
	[HotFix]
	public class FixedStoreComponent : FixedStoreComponentCommon
	{
		// Token: 0x06006F66 RID: 28518 RVA: 0x001F27A4 File Offset: 0x001F09A4
		public FixedStoreComponent()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ctor_hotfix != null)
			{
				this.m_ctor_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x06006F67 RID: 28519 RVA: 0x001F280C File Offset: 0x001F0A0C
		public override void Init()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Init_hotfix != null)
			{
				this.m_Init_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_configDataLoader = (GameManager.Instance.ConfigDataLoader as IConfigDataLoader);
			base.Init();
		}

		// Token: 0x06006F68 RID: 28520 RVA: 0x001F2888 File Offset: 0x001F0A88
		public override void PostInit()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PostInit_hotfix != null)
			{
				this.m_PostInit_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.PostInit();
		}

		// Token: 0x06006F69 RID: 28521 RVA: 0x001F28F0 File Offset: 0x001F0AF0
		public override void DeInit()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DeInit_hotfix != null)
			{
				this.m_DeInit_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.DeInit();
		}

		// Token: 0x06006F6A RID: 28522 RVA: 0x001F2958 File Offset: 0x001F0B58
		public void DeSerialize(DSFixedStoreNtf ntf)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DeSerializeDSFixedStoreNtf_hotfix != null)
			{
				this.m_DeSerializeDSFixedStoreNtf_hotfix.call(new object[]
				{
					this,
					ntf
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.InitStores(ntf.Stores);
			this.m_fixedStoreDS.InitVersion((ushort)ntf.Version, (ushort)ntf.Version);
		}

		// Token: 0x06006F6B RID: 28523 RVA: 0x001F29F0 File Offset: 0x001F0BF0
		public void InitStores(List<ProFixedStore> pbStores)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitStoresList`1_hotfix != null)
			{
				this.m_InitStoresList`1_hotfix.call(new object[]
				{
					this,
					pbStores
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_fixedStoreDS.ClearInitedData();
			this.m_fixedStoreDS.InitStores(FixedStore.PBFixedStoresToFixedStores(pbStores));
		}

		// Token: 0x06006F6C RID: 28524 RVA: 0x001F2A7C File Offset: 0x001F0C7C
		public bool IsStoreInfoEmpty()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsStoreInfoEmpty_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsStoreInfoEmpty_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_fixedStoreDS.Stores.Count == 0;
		}

		// Token: 0x06006F6D RID: 28525 RVA: 0x001F2AFC File Offset: 0x001F0CFC
		public FixedStore FindStoreById(int storeId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FindStoreByIdInt32_hotfix != null)
			{
				return (FixedStore)this.m_FindStoreByIdInt32_hotfix.call(new object[]
				{
					this,
					storeId
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_fixedStoreDS.FindStore(storeId);
		}

		// Token: 0x06006F6E RID: 28526 RVA: 0x001F2B84 File Offset: 0x001F0D84
		public void InitStoreInfo(ProFixedStore pbStore)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitStoreInfoProFixedStore_hotfix != null)
			{
				this.m_InitStoreInfoProFixedStore_hotfix.call(new object[]
				{
					this,
					pbStore
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.FindStoreById(pbStore.StoreId) == null)
			{
				this.m_fixedStoreDS.InitStore(FixedStore.PBFixedStoreToFixedStore(pbStore));
			}
		}

		// Token: 0x06006F6F RID: 28527 RVA: 0x001F2C18 File Offset: 0x001F0E18
		public int CanBuyGoods(int storeId, int goodsId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanBuyGoodsInt32Int32_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanBuyGoodsInt32Int32_hotfix.call(new object[]
				{
					this,
					storeId,
					goodsId2
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int goodsId = goodsId2;
			Dictionary<int, FixedStoreInfo> stores = this.m_configDataLoader.FixedStoreData.Stores;
			if (!stores.ContainsKey(storeId))
			{
				return -1300;
			}
			if (!stores[storeId].StoreItems.ContainsKey(goodsId))
			{
				return -1301;
			}
			FixedStoreItem item = null;
			FixedStore fixedStore = this.FindStoreById(storeId);
			if (fixedStore != null)
			{
				item = fixedStore.Items.Find((FixedStoreItem t) => t.Id == goodsId);
			}
			ConfigDataFixedStoreItemInfo itemConfig = this.m_configDataLoader.FixedStoreData.Stores[storeId].StoreItems[goodsId];
			return base.CanBuyFixedStoreItem(itemConfig, item);
		}

		// Token: 0x06006F70 RID: 28528 RVA: 0x001F2D50 File Offset: 0x001F0F50
		public void BuyStoreItem(int storeId, int goodsId, long nextFlushTime, bool isReseted)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BuyStoreItemInt32Int32Int64Boolean_hotfix != null)
			{
				this.m_BuyStoreItemInt32Int32Int64Boolean_hotfix.call(new object[]
				{
					this,
					storeId,
					goodsId2,
					nextFlushTime,
					isReseted
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int goodsId = goodsId2;
			FixedStore fixedStore = this.m_fixedStoreDS.FindStore(storeId);
			if (fixedStore == null)
			{
				fixedStore = new FixedStore();
				fixedStore.Id = storeId;
				this.m_fixedStoreDS.AddStore(fixedStore);
			}
			ConfigDataFixedStoreItemInfo configDataFixedStoreItemInfo = this.m_configDataLoader.FixedStoreData.Stores[storeId].StoreItems[goodsId];
			FixedStoreItem fixedStoreItem = fixedStore.Items.Find((FixedStoreItem t) => t.Id == goodsId);
			if (fixedStoreItem == null)
			{
				fixedStoreItem = new FixedStoreItem();
				fixedStoreItem.Id = goodsId;
				fixedStoreItem.IsFirstBuy = true;
				fixedStoreItem.BoughtCount = 0;
				fixedStore.Items.Add(fixedStoreItem);
			}
			int num = base.CaculateCurrencyCount(configDataFixedStoreItemInfo, fixedStoreItem.IsFirstBuy);
			this.m_basicInfo.AddCurrency(configDataFixedStoreItemInfo.CurrencyType, -num, GameFunctionType.GameFunctionType_None, null);
			fixedStoreItem.NextFlushTime = nextFlushTime;
			if (isReseted)
			{
				fixedStoreItem.BoughtCount = 0;
			}
			base.BuyStoreItem(storeId, fixedStoreItem, 1);
		}

		// Token: 0x06006F71 RID: 28529 RVA: 0x001F2EE0 File Offset: 0x001F10E0
		public ushort GetDSVersion()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetDSVersion_hotfix != null)
			{
				return Convert.ToUInt16(this.m_GetDSVersion_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_fixedStoreDS.ClientVersion;
		}

		// Token: 0x17001BBC RID: 7100
		// (get) Token: 0x06006F72 RID: 28530 RVA: 0x001F2F58 File Offset: 0x001F1158
		// (set) Token: 0x06006F73 RID: 28531 RVA: 0x001F2F78 File Offset: 0x001F1178
		[DoNotToLua]
		public new FixedStoreComponent.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new FixedStoreComponent.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06006F74 RID: 28532 RVA: 0x001F2F84 File Offset: 0x001F1184
		private string __callBase_GetName()
		{
			return base.GetName();
		}

		// Token: 0x06006F75 RID: 28533 RVA: 0x001F2F8C File Offset: 0x001F118C
		private void __callBase_Init()
		{
			base.Init();
		}

		// Token: 0x06006F76 RID: 28534 RVA: 0x001F2F94 File Offset: 0x001F1194
		private void __callBase_PostInit()
		{
			base.PostInit();
		}

		// Token: 0x06006F77 RID: 28535 RVA: 0x001F2F9C File Offset: 0x001F119C
		private void __callBase_DeInit()
		{
			base.DeInit();
		}

		// Token: 0x06006F78 RID: 28536 RVA: 0x001F2FA4 File Offset: 0x001F11A4
		private void __callBase_Tick(uint deltaMillisecond)
		{
			base.Tick(deltaMillisecond);
		}

		// Token: 0x06006F79 RID: 28537 RVA: 0x001F2FB0 File Offset: 0x001F11B0
		private void __callBase_PostDeSerialize()
		{
			base.PostDeSerialize();
		}

		// Token: 0x06006F7A RID: 28538 RVA: 0x001F2FB8 File Offset: 0x001F11B8
		private bool __callBase_IsSoldOut(ConfigDataFixedStoreItemInfo itemConfig, FixedStoreItem item)
		{
			return base.IsSoldOut(itemConfig, item);
		}

		// Token: 0x06006F7B RID: 28539 RVA: 0x001F2FC4 File Offset: 0x001F11C4
		private bool __callBase_IsInSaleTime(ConfigDataFixedStoreItemInfo itemConfig)
		{
			return base.IsInSaleTime(itemConfig);
		}

		// Token: 0x06006F7C RID: 28540 RVA: 0x001F2FD0 File Offset: 0x001F11D0
		private int __callBase_CanBuyGoods(int storeId, int goodsId, int selectedIndex)
		{
			return base.CanBuyGoods(storeId, goodsId, selectedIndex);
		}

		// Token: 0x06006F7D RID: 28541 RVA: 0x001F2FDC File Offset: 0x001F11DC
		private int __callBase_CanBuyFixedStoreItem(ConfigDataFixedStoreItemInfo itemConfig, FixedStoreItem item)
		{
			return base.CanBuyFixedStoreItem(itemConfig, item);
		}

		// Token: 0x06006F7E RID: 28542 RVA: 0x001F2FE8 File Offset: 0x001F11E8
		private int __callBase_CaculateCurrencyCount(ConfigDataFixedStoreItemInfo storeItemConfig, bool isFirstBuy)
		{
			return base.CaculateCurrencyCount(storeItemConfig, isFirstBuy);
		}

		// Token: 0x06006F7F RID: 28543 RVA: 0x001F2FF4 File Offset: 0x001F11F4
		private bool __callBase_IsOnDiscountPeriod(ConfigDataFixedStoreItemInfo storeItemConfig)
		{
			return base.IsOnDiscountPeriod(storeItemConfig);
		}

		// Token: 0x06006F80 RID: 28544 RVA: 0x001F3000 File Offset: 0x001F1200
		private FixedStore __callBase_GetStore(int storeId)
		{
			return base.GetStore(storeId);
		}

		// Token: 0x06006F81 RID: 28545 RVA: 0x001F300C File Offset: 0x001F120C
		private void __callBase_BuyStoreItem(int storeId, FixedStoreItem storeItem, int count)
		{
			base.BuyStoreItem(storeId, storeItem, count);
		}

		// Token: 0x06006F82 RID: 28546 RVA: 0x001F3018 File Offset: 0x001F1218
		private bool InitHotFix(LuaTable A_1)
		{
			this.m_luaObjHelper = new BJLuaObjHelper();
			this.m_luaObjHelper.InitInCS(this, A_1);
			LuaFunction luaFunction = A_1.RawGet("HotFixObject") as LuaFunction;
			bool result;
			if (luaFunction == null)
			{
				Debug.LogError("Can't find HotFixObject Func");
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
					this.m_ctor_hotfix = (luaObj.RawGet("ctor") as LuaFunction);
					this.m_Init_hotfix = (luaObj.RawGet("Init") as LuaFunction);
					this.m_PostInit_hotfix = (luaObj.RawGet("PostInit") as LuaFunction);
					this.m_DeInit_hotfix = (luaObj.RawGet("DeInit") as LuaFunction);
					this.m_DeSerializeDSFixedStoreNtf_hotfix = (luaObj.RawGet("DeSerialize") as LuaFunction);
					this.m_InitStoresList`1_hotfix = (luaObj.RawGet("InitStores") as LuaFunction);
					this.m_IsStoreInfoEmpty_hotfix = (luaObj.RawGet("IsStoreInfoEmpty") as LuaFunction);
					this.m_FindStoreByIdInt32_hotfix = (luaObj.RawGet("FindStoreById") as LuaFunction);
					this.m_InitStoreInfoProFixedStore_hotfix = (luaObj.RawGet("InitStoreInfo") as LuaFunction);
					this.m_CanBuyGoodsInt32Int32_hotfix = (luaObj.RawGet("CanBuyGoods") as LuaFunction);
					this.m_BuyStoreItemInt32Int32Int64Boolean_hotfix = (luaObj.RawGet("BuyStoreItem") as LuaFunction);
					this.m_GetDSVersion_hotfix = (luaObj.RawGet("GetDSVersion") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06006F83 RID: 28547 RVA: 0x001F31F8 File Offset: 0x001F13F8
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(FixedStoreComponent));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04005482 RID: 21634
		[DoNotToLua]
		private FixedStoreComponent.LuaExportHelper luaExportHelper;

		// Token: 0x04005483 RID: 21635
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04005484 RID: 21636
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04005485 RID: 21637
		private LuaFunction m_ctor_hotfix;

		// Token: 0x04005486 RID: 21638
		private LuaFunction m_Init_hotfix;

		// Token: 0x04005487 RID: 21639
		private LuaFunction m_PostInit_hotfix;

		// Token: 0x04005488 RID: 21640
		private LuaFunction m_DeInit_hotfix;

		// Token: 0x04005489 RID: 21641
		private LuaFunction m_DeSerializeDSFixedStoreNtf_hotfix;

		// Token: 0x0400548A RID: 21642
		private LuaFunction m_InitStoresList;

		// Token: 0x0400548B RID: 21643
		private LuaFunction m_IsStoreInfoEmpty_hotfix;

		// Token: 0x0400548C RID: 21644
		private LuaFunction m_FindStoreByIdInt32_hotfix;

		// Token: 0x0400548D RID: 21645
		private LuaFunction m_InitStoreInfoProFixedStore_hotfix;

		// Token: 0x0400548E RID: 21646
		private LuaFunction m_CanBuyGoodsInt32Int32_hotfix;

		// Token: 0x0400548F RID: 21647
		private LuaFunction m_BuyStoreItemInt32Int32Int64Boolean_hotfix;

		// Token: 0x04005490 RID: 21648
		private LuaFunction m_GetDSVersion_hotfix;

		// Token: 0x020008AA RID: 2218
		public new class LuaExportHelper
		{
			// Token: 0x06006F84 RID: 28548 RVA: 0x001F3260 File Offset: 0x001F1460
			public LuaExportHelper(FixedStoreComponent owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06006F85 RID: 28549 RVA: 0x001F3270 File Offset: 0x001F1470
			public string __callBase_GetName()
			{
				return this.m_owner.__callBase_GetName();
			}

			// Token: 0x06006F86 RID: 28550 RVA: 0x001F3280 File Offset: 0x001F1480
			public void __callBase_Init()
			{
				this.m_owner.__callBase_Init();
			}

			// Token: 0x06006F87 RID: 28551 RVA: 0x001F3290 File Offset: 0x001F1490
			public void __callBase_PostInit()
			{
				this.m_owner.__callBase_PostInit();
			}

			// Token: 0x06006F88 RID: 28552 RVA: 0x001F32A0 File Offset: 0x001F14A0
			public void __callBase_DeInit()
			{
				this.m_owner.__callBase_DeInit();
			}

			// Token: 0x06006F89 RID: 28553 RVA: 0x001F32B0 File Offset: 0x001F14B0
			public void __callBase_Tick(uint deltaMillisecond)
			{
				this.m_owner.__callBase_Tick(deltaMillisecond);
			}

			// Token: 0x06006F8A RID: 28554 RVA: 0x001F32C0 File Offset: 0x001F14C0
			public void __callBase_PostDeSerialize()
			{
				this.m_owner.__callBase_PostDeSerialize();
			}

			// Token: 0x06006F8B RID: 28555 RVA: 0x001F32D0 File Offset: 0x001F14D0
			public bool __callBase_IsSoldOut(ConfigDataFixedStoreItemInfo itemConfig, FixedStoreItem item)
			{
				return this.m_owner.__callBase_IsSoldOut(itemConfig, item);
			}

			// Token: 0x06006F8C RID: 28556 RVA: 0x001F32E0 File Offset: 0x001F14E0
			public bool __callBase_IsInSaleTime(ConfigDataFixedStoreItemInfo itemConfig)
			{
				return this.m_owner.__callBase_IsInSaleTime(itemConfig);
			}

			// Token: 0x06006F8D RID: 28557 RVA: 0x001F32F0 File Offset: 0x001F14F0
			public int __callBase_CanBuyGoods(int storeId, int goodsId, int selectedIndex)
			{
				return this.m_owner.__callBase_CanBuyGoods(storeId, goodsId, selectedIndex);
			}

			// Token: 0x06006F8E RID: 28558 RVA: 0x001F3300 File Offset: 0x001F1500
			public int __callBase_CanBuyFixedStoreItem(ConfigDataFixedStoreItemInfo itemConfig, FixedStoreItem item)
			{
				return this.m_owner.__callBase_CanBuyFixedStoreItem(itemConfig, item);
			}

			// Token: 0x06006F8F RID: 28559 RVA: 0x001F3310 File Offset: 0x001F1510
			public int __callBase_CaculateCurrencyCount(ConfigDataFixedStoreItemInfo storeItemConfig, bool isFirstBuy)
			{
				return this.m_owner.__callBase_CaculateCurrencyCount(storeItemConfig, isFirstBuy);
			}

			// Token: 0x06006F90 RID: 28560 RVA: 0x001F3320 File Offset: 0x001F1520
			public bool __callBase_IsOnDiscountPeriod(ConfigDataFixedStoreItemInfo storeItemConfig)
			{
				return this.m_owner.__callBase_IsOnDiscountPeriod(storeItemConfig);
			}

			// Token: 0x06006F91 RID: 28561 RVA: 0x001F3330 File Offset: 0x001F1530
			public FixedStore __callBase_GetStore(int storeId)
			{
				return this.m_owner.__callBase_GetStore(storeId);
			}

			// Token: 0x06006F92 RID: 28562 RVA: 0x001F3340 File Offset: 0x001F1540
			public void __callBase_BuyStoreItem(int storeId, FixedStoreItem storeItem, int count)
			{
				this.m_owner.__callBase_BuyStoreItem(storeId, storeItem, count);
			}

			// Token: 0x04005491 RID: 21649
			private FixedStoreComponent m_owner;
		}
	}
}
