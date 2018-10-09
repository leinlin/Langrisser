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
	// Token: 0x020008B3 RID: 2227
	[HotFix]
	public class GiftStoreComponent : GiftStoreComponentCommon
	{
		// Token: 0x06007006 RID: 28678 RVA: 0x001F4FF0 File Offset: 0x001F31F0
		public GiftStoreComponent()
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

		// Token: 0x06007007 RID: 28679 RVA: 0x001F5058 File Offset: 0x001F3258
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

		// Token: 0x06007008 RID: 28680 RVA: 0x001F50D4 File Offset: 0x001F32D4
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

		// Token: 0x06007009 RID: 28681 RVA: 0x001F513C File Offset: 0x001F333C
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

		// Token: 0x0600700A RID: 28682 RVA: 0x001F51A4 File Offset: 0x001F33A4
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
			return this.m_giftStoreDS.ClientVersion;
		}

		// Token: 0x0600700B RID: 28683 RVA: 0x001F521C File Offset: 0x001F341C
		public bool IsGiftStoreItemSellOut(GiftStoreItem item)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsGiftStoreItemSellOutGiftStoreItem_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsGiftStoreItemSellOutGiftStoreItem_hotfix.call(new object[]
				{
					this,
					item
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataGiftStoreItemInfo configDataGiftStoreItemInfo = this.m_configDataLoader.GetConfigDataGiftStoreItemInfo(item.GoodsId);
			DateTime currentTime = this.m_basicInfo.GetCurrentTime();
			return item.NextFlushTime > currentTime && configDataGiftStoreItemInfo.Count != 0 && item.BoughtNums >= configDataGiftStoreItemInfo.Count;
		}

		// Token: 0x0600700C RID: 28684 RVA: 0x001F52E8 File Offset: 0x001F34E8
		public void DeSerialize(DSGiftStoreNtf msg)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DeSerializeDSGiftStoreNtf_hotfix != null)
			{
				this.m_DeSerializeDSGiftStoreNtf_hotfix.call(new object[]
				{
					this,
					msg
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_giftStoreDS.ClearInitedData();
			this.m_giftStoreDS.InitVersion((ushort)msg.Version, (ushort)msg.Version);
			foreach (ProGiftStoreFirstBoughtRecord proGiftStoreFirstBoughtRecord in msg.Records)
			{
				this.m_giftStoreDS.InitFirstBuyGoodsRecord(proGiftStoreFirstBoughtRecord.GoodsId, proGiftStoreFirstBoughtRecord.GoodsRegisterId);
			}
			foreach (ProGiftStoreItem pbItem in msg.BoughtItems)
			{
				GiftStoreItem giftStoreItem = GiftStoreItem.FromPB(pbItem);
				giftStoreItem.Config = this.m_configDataLoader.GetConfigDataGiftStoreItemInfo(giftStoreItem.GoodsId);
				this.m_giftStoreDS.InitBoughtItem(giftStoreItem);
			}
			foreach (ProOrderReward pbOrderReward in msg.OrderRewards)
			{
				this.m_giftStoreDS.InitOrderReward(OrderReward.FromPB(pbOrderReward));
			}
		}

		// Token: 0x0600700D RID: 28685 RVA: 0x001F54A4 File Offset: 0x001F36A4
		public void DeSerialize(GiftStoreOperationalGoodsUpdateNtf msg)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DeSerializeGiftStoreOperationalGoodsUpdateNtf_hotfix != null)
			{
				this.m_DeSerializeGiftStoreOperationalGoodsUpdateNtf_hotfix.call(new object[]
				{
					this,
					msg
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_giftStoreDS.ClearGiftStoreOperationalGoods();
			foreach (ProGiftStoreOperationalGoods pbGoods in msg.OperationalGoodsList)
			{
				this.m_giftStoreDS.InitOperationalGoodsList(GiftStoreOperationalGoods.FromPB(pbGoods));
			}
		}

		// Token: 0x0600700E RID: 28686 RVA: 0x001F5578 File Offset: 0x001F3778
		public void BuyGoods(int goodsId, string registerId, int boughtNums, long nextFlushTime)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BuyGoodsInt32StringInt32Int64_hotfix != null)
			{
				this.m_BuyGoodsInt32StringInt32Int64_hotfix.call(new object[]
				{
					this,
					goodsId,
					registerId,
					boughtNums,
					nextFlushTime
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GiftStoreItem giftStoreItem = this.m_giftStoreDS.FindLocalBoughtItemById(goodsId);
			if (giftStoreItem == null)
			{
				giftStoreItem = new GiftStoreItem();
				giftStoreItem.Config = this.m_configDataLoader.GetConfigDataGiftStoreItemInfo(goodsId);
				giftStoreItem.GoodsId = goodsId;
				giftStoreItem.BoughtNums = boughtNums;
				giftStoreItem.NextFlushTime = new DateTime(nextFlushTime);
				this.m_giftStoreDS.AddBoughtItem(giftStoreItem);
			}
			else
			{
				giftStoreItem.BoughtNums = boughtNums;
				giftStoreItem.NextFlushTime = new DateTime(nextFlushTime);
				this.m_giftStoreDS.SetDirty(true);
			}
			if (!base.HasBought(goodsId))
			{
				base.AddFirstBuyGoodsRecord(goodsId, registerId);
			}
			base.OnBuyGiftStoreGoods(giftStoreItem.Config);
		}

		// Token: 0x17001BC8 RID: 7112
		// (get) Token: 0x0600700F RID: 28687 RVA: 0x001F56B0 File Offset: 0x001F38B0
		// (set) Token: 0x06007010 RID: 28688 RVA: 0x001F56D0 File Offset: 0x001F38D0
		[DoNotToLua]
		public new GiftStoreComponent.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new GiftStoreComponent.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06007011 RID: 28689 RVA: 0x001F56DC File Offset: 0x001F38DC
		private string __callBase_GetName()
		{
			return base.GetName();
		}

		// Token: 0x06007012 RID: 28690 RVA: 0x001F56E4 File Offset: 0x001F38E4
		private void __callBase_Init()
		{
			base.Init();
		}

		// Token: 0x06007013 RID: 28691 RVA: 0x001F56EC File Offset: 0x001F38EC
		private void __callBase_PostInit()
		{
			base.PostInit();
		}

		// Token: 0x06007014 RID: 28692 RVA: 0x001F56F4 File Offset: 0x001F38F4
		private void __callBase_DeInit()
		{
			base.DeInit();
		}

		// Token: 0x06007015 RID: 28693 RVA: 0x001F56FC File Offset: 0x001F38FC
		private void __callBase_Tick(uint deltaMillisecond)
		{
			base.Tick(deltaMillisecond);
		}

		// Token: 0x06007016 RID: 28694 RVA: 0x001F5708 File Offset: 0x001F3908
		private void __callBase_PostDeSerialize()
		{
			base.PostDeSerialize();
		}

		// Token: 0x06007017 RID: 28695 RVA: 0x001F5710 File Offset: 0x001F3910
		private List<GiftStoreItem> __callBase_GetOfferedStoreItems()
		{
			return base.GetOfferedStoreItems();
		}

		// Token: 0x06007018 RID: 28696 RVA: 0x001F5718 File Offset: 0x001F3918
		private bool __callBase_IsOnSaleTime(DateTime saleStartTime, DateTime saleEndTime, DateTime currentTime)
		{
			return base.IsOnSaleTime(saleStartTime, saleEndTime, currentTime);
		}

		// Token: 0x06007019 RID: 28697 RVA: 0x001F5724 File Offset: 0x001F3924
		private bool __callBase_HasBought(int goodsId)
		{
			return base.HasBought(goodsId);
		}

		// Token: 0x0600701A RID: 28698 RVA: 0x001F5730 File Offset: 0x001F3930
		private int __callBase_CanBuyGoods(int goodsId)
		{
			return base.CanBuyGoods(goodsId);
		}

		// Token: 0x0600701B RID: 28699 RVA: 0x001F573C File Offset: 0x001F393C
		private int __callBase_CanAppleSubscribeGoods(int goodsId)
		{
			return base.CanAppleSubscribeGoods(goodsId);
		}

		// Token: 0x0600701C RID: 28700 RVA: 0x001F5748 File Offset: 0x001F3948
		private void __callBase_AddFirstBuyGoodsRecord(int goodsId, string goodsRegisterId)
		{
			base.AddFirstBuyGoodsRecord(goodsId, goodsRegisterId);
		}

		// Token: 0x0600701D RID: 28701 RVA: 0x001F5754 File Offset: 0x001F3954
		private List<OrderReward> __callBase_GetAllOrderRewards()
		{
			return base.GetAllOrderRewards();
		}

		// Token: 0x0600701E RID: 28702 RVA: 0x001F575C File Offset: 0x001F395C
		private void __callBase_RemoveOrderReward(string orderId)
		{
			base.RemoveOrderReward(orderId);
		}

		// Token: 0x0600701F RID: 28703 RVA: 0x001F5768 File Offset: 0x001F3968
		private void __callBase_AddOrderReward(string orderId, OrderReward reward)
		{
			base.AddOrderReward(orderId, reward);
		}

		// Token: 0x06007020 RID: 28704 RVA: 0x001F5774 File Offset: 0x001F3974
		private OrderReward __callBase_FindOrderReward(string orderId)
		{
			return base.FindOrderReward(orderId);
		}

		// Token: 0x06007021 RID: 28705 RVA: 0x001F5780 File Offset: 0x001F3980
		private void __callBase_OnBuyGiftStoreGoods(ConfigDataGiftStoreItemInfo goodsInfo)
		{
			base.OnBuyGiftStoreGoods(goodsInfo);
		}

		// Token: 0x06007022 RID: 28706 RVA: 0x001F578C File Offset: 0x001F398C
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
					this.m_GetDSVersion_hotfix = (luaObj.RawGet("GetDSVersion") as LuaFunction);
					this.m_IsGiftStoreItemSellOutGiftStoreItem_hotfix = (luaObj.RawGet("IsGiftStoreItemSellOut") as LuaFunction);
					this.m_DeSerializeDSGiftStoreNtf_hotfix = (luaObj.RawGet("DeSerialize") as LuaFunction);
					this.m_DeSerializeGiftStoreOperationalGoodsUpdateNtf_hotfix = (luaObj.RawGet("DeSerialize") as LuaFunction);
					this.m_BuyGoodsInt32StringInt32Int64_hotfix = (luaObj.RawGet("BuyGoods") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06007023 RID: 28707 RVA: 0x001F5920 File Offset: 0x001F3B20
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(GiftStoreComponent));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040054CB RID: 21707
		[DoNotToLua]
		private GiftStoreComponent.LuaExportHelper luaExportHelper;

		// Token: 0x040054CC RID: 21708
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040054CD RID: 21709
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040054CE RID: 21710
		private LuaFunction m_ctor_hotfix;

		// Token: 0x040054CF RID: 21711
		private LuaFunction m_Init_hotfix;

		// Token: 0x040054D0 RID: 21712
		private LuaFunction m_PostInit_hotfix;

		// Token: 0x040054D1 RID: 21713
		private LuaFunction m_DeInit_hotfix;

		// Token: 0x040054D2 RID: 21714
		private LuaFunction m_GetDSVersion_hotfix;

		// Token: 0x040054D3 RID: 21715
		private LuaFunction m_IsGiftStoreItemSellOutGiftStoreItem_hotfix;

		// Token: 0x040054D4 RID: 21716
		private LuaFunction m_DeSerializeDSGiftStoreNtf_hotfix;

		// Token: 0x040054D5 RID: 21717
		private LuaFunction m_DeSerializeGiftStoreOperationalGoodsUpdateNtf_hotfix;

		// Token: 0x040054D6 RID: 21718
		private LuaFunction m_BuyGoodsInt32StringInt32Int64_hotfix;

		// Token: 0x020008B4 RID: 2228
		public new class LuaExportHelper
		{
			// Token: 0x06007024 RID: 28708 RVA: 0x001F5988 File Offset: 0x001F3B88
			public LuaExportHelper(GiftStoreComponent owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06007025 RID: 28709 RVA: 0x001F5998 File Offset: 0x001F3B98
			public string __callBase_GetName()
			{
				return this.m_owner.__callBase_GetName();
			}

			// Token: 0x06007026 RID: 28710 RVA: 0x001F59A8 File Offset: 0x001F3BA8
			public void __callBase_Init()
			{
				this.m_owner.__callBase_Init();
			}

			// Token: 0x06007027 RID: 28711 RVA: 0x001F59B8 File Offset: 0x001F3BB8
			public void __callBase_PostInit()
			{
				this.m_owner.__callBase_PostInit();
			}

			// Token: 0x06007028 RID: 28712 RVA: 0x001F59C8 File Offset: 0x001F3BC8
			public void __callBase_DeInit()
			{
				this.m_owner.__callBase_DeInit();
			}

			// Token: 0x06007029 RID: 28713 RVA: 0x001F59D8 File Offset: 0x001F3BD8
			public void __callBase_Tick(uint deltaMillisecond)
			{
				this.m_owner.__callBase_Tick(deltaMillisecond);
			}

			// Token: 0x0600702A RID: 28714 RVA: 0x001F59E8 File Offset: 0x001F3BE8
			public void __callBase_PostDeSerialize()
			{
				this.m_owner.__callBase_PostDeSerialize();
			}

			// Token: 0x0600702B RID: 28715 RVA: 0x001F59F8 File Offset: 0x001F3BF8
			public List<GiftStoreItem> __callBase_GetOfferedStoreItems()
			{
				return this.m_owner.__callBase_GetOfferedStoreItems();
			}

			// Token: 0x0600702C RID: 28716 RVA: 0x001F5A08 File Offset: 0x001F3C08
			public bool __callBase_IsOnSaleTime(DateTime saleStartTime, DateTime saleEndTime, DateTime currentTime)
			{
				return this.m_owner.__callBase_IsOnSaleTime(saleStartTime, saleEndTime, currentTime);
			}

			// Token: 0x0600702D RID: 28717 RVA: 0x001F5A18 File Offset: 0x001F3C18
			public bool __callBase_HasBought(int goodsId)
			{
				return this.m_owner.__callBase_HasBought(goodsId);
			}

			// Token: 0x0600702E RID: 28718 RVA: 0x001F5A28 File Offset: 0x001F3C28
			public int __callBase_CanBuyGoods(int goodsId)
			{
				return this.m_owner.__callBase_CanBuyGoods(goodsId);
			}

			// Token: 0x0600702F RID: 28719 RVA: 0x001F5A38 File Offset: 0x001F3C38
			public int __callBase_CanAppleSubscribeGoods(int goodsId)
			{
				return this.m_owner.__callBase_CanAppleSubscribeGoods(goodsId);
			}

			// Token: 0x06007030 RID: 28720 RVA: 0x001F5A48 File Offset: 0x001F3C48
			public void __callBase_AddFirstBuyGoodsRecord(int goodsId, string goodsRegisterId)
			{
				this.m_owner.__callBase_AddFirstBuyGoodsRecord(goodsId, goodsRegisterId);
			}

			// Token: 0x06007031 RID: 28721 RVA: 0x001F5A58 File Offset: 0x001F3C58
			public List<OrderReward> __callBase_GetAllOrderRewards()
			{
				return this.m_owner.__callBase_GetAllOrderRewards();
			}

			// Token: 0x06007032 RID: 28722 RVA: 0x001F5A68 File Offset: 0x001F3C68
			public void __callBase_RemoveOrderReward(string orderId)
			{
				this.m_owner.__callBase_RemoveOrderReward(orderId);
			}

			// Token: 0x06007033 RID: 28723 RVA: 0x001F5A78 File Offset: 0x001F3C78
			public void __callBase_AddOrderReward(string orderId, OrderReward reward)
			{
				this.m_owner.__callBase_AddOrderReward(orderId, reward);
			}

			// Token: 0x06007034 RID: 28724 RVA: 0x001F5A88 File Offset: 0x001F3C88
			public OrderReward __callBase_FindOrderReward(string orderId)
			{
				return this.m_owner.__callBase_FindOrderReward(orderId);
			}

			// Token: 0x06007035 RID: 28725 RVA: 0x001F5A98 File Offset: 0x001F3C98
			public void __callBase_OnBuyGiftStoreGoods(ConfigDataGiftStoreItemInfo goodsInfo)
			{
				this.m_owner.__callBase_OnBuyGiftStoreGoods(goodsInfo);
			}

			// Token: 0x040054D7 RID: 21719
			private GiftStoreComponent m_owner;
		}
	}
}
