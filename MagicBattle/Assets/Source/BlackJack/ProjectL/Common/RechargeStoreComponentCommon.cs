using System;
using System.Runtime.CompilerServices;
using System.Threading;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.ConfigData;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x020004A2 RID: 1186
	[HotFix]
	public class RechargeStoreComponentCommon : IComponentBase
	{
		// Token: 0x060047C7 RID: 18375 RVA: 0x001629A8 File Offset: 0x00160BA8
		public RechargeStoreComponentCommon()
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

		// Token: 0x060047C8 RID: 18376 RVA: 0x00162A1C File Offset: 0x00160C1C
		public string GetName()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetName_hotfix != null)
			{
				return (string)this.m_GetName_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return "RechargeStore";
		}

		// Token: 0x060047C9 RID: 18377 RVA: 0x00162A90 File Offset: 0x00160C90
		public virtual void Init()
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
		}

		// Token: 0x060047CA RID: 18378 RVA: 0x00162AF0 File Offset: 0x00160CF0
		public virtual void PostInit()
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
			this.m_basicInfo = (this.Owner.GetOwnerComponent("PlayerBasicInfo") as PlayerBasicInfoComponentCommon);
		}

		// Token: 0x060047CB RID: 18379 RVA: 0x00162B6C File Offset: 0x00160D6C
		public virtual void DeInit()
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
		}

		// Token: 0x060047CC RID: 18380 RVA: 0x00162BCC File Offset: 0x00160DCC
		public virtual void Tick(uint deltaMillisecond)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TickUInt32_hotfix != null)
			{
				this.m_TickUInt32_hotfix.call(new object[]
				{
					this,
					deltaMillisecond
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x060047CD RID: 18381 RVA: 0x00162C3C File Offset: 0x00160E3C
		public virtual bool Serialize<T>(T dest)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SerializeT_hotfix != null)
			{
				return Convert.ToBoolean(this.m_SerializeT_hotfix.call(new object[]
				{
					this,
					dest
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return false;
		}

		// Token: 0x060047CE RID: 18382 RVA: 0x00162CBC File Offset: 0x00160EBC
		public virtual void DeSerialize<T>(T source)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DeSerializeT_hotfix != null)
			{
				this.m_DeSerializeT_hotfix.call(new object[]
				{
					this,
					source
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x060047CF RID: 18383 RVA: 0x00162D2C File Offset: 0x00160F2C
		public virtual void PostDeSerialize()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PostDeSerialize_hotfix != null)
			{
				this.m_PostDeSerialize_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x17001202 RID: 4610
		// (get) Token: 0x060047D0 RID: 18384 RVA: 0x00162D8C File Offset: 0x00160F8C
		// (set) Token: 0x060047D1 RID: 18385 RVA: 0x00162E00 File Offset: 0x00161000
		public IComponentOwner Owner
		{
			[CompilerGenerated]
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_Owner_hotfix != null)
				{
					return (IComponentOwner)this.m_get_Owner_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.<Owner>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_set_OwnerIComponentOwner_hotfix != null)
				{
					this.m_set_OwnerIComponentOwner_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				this.<Owner>k__BackingField = value;
			}
		}

		// Token: 0x060047D2 RID: 18386 RVA: 0x00162E78 File Offset: 0x00161078
		public bool IsGoodsBought(int goodsId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsGoodsBoughtInt32_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsGoodsBoughtInt32_hotfix.call(new object[]
				{
					this,
					goodsId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_rechargeStoreDS.IsGoodsBought(goodsId);
		}

		// Token: 0x060047D3 RID: 18387 RVA: 0x00162F00 File Offset: 0x00161100
		public int CaculateGotCrystalNums(int goodsId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CaculateGotCrystalNumsInt32_hotfix != null)
			{
				return Convert.ToInt32(this.m_CaculateGotCrystalNumsInt32_hotfix.call(new object[]
				{
					this,
					goodsId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataRechargeStoreItemInfo configDataRechargeStoreItemInfo = this.m_configDataLoader.GetConfigDataRechargeStoreItemInfo(goodsId);
			if (configDataRechargeStoreItemInfo == null)
			{
				return 0;
			}
			if (this.IsGoodsBought(goodsId))
			{
				return configDataRechargeStoreItemInfo.RepeatlyBoughtReward + configDataRechargeStoreItemInfo.GotCrystalNums;
			}
			return configDataRechargeStoreItemInfo.FirstBoughtReward + configDataRechargeStoreItemInfo.GotCrystalNums;
		}

		// Token: 0x060047D4 RID: 18388 RVA: 0x00162FB8 File Offset: 0x001611B8
		protected void BuyGoods(int goodsId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BuyGoodsInt32_hotfix != null)
			{
				this.m_BuyGoodsInt32_hotfix.call(new object[]
				{
					this,
					goodsId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_rechargeStoreDS.BuyGoods(goodsId);
			if (this.BuyRechargeStoreGoodsEvent != null)
			{
				this.BuyRechargeStoreGoodsEvent(goodsId);
			}
			if (this.BuyStoreItemEvent != null)
			{
				this.BuyStoreItemEvent(11, goodsId);
			}
		}

		// Token: 0x1400005B RID: 91
		// (add) Token: 0x060047D5 RID: 18389 RVA: 0x00163064 File Offset: 0x00161264
		// (remove) Token: 0x060047D6 RID: 18390 RVA: 0x00163100 File Offset: 0x00161300
		public event Action<int> BuyRechargeStoreGoodsEvent
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_BuyRechargeStoreGoodsEventAction`1_hotfix != null)
				{
					this.m_add_BuyRechargeStoreGoodsEventAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int> action = this.BuyRechargeStoreGoodsEvent;
				Action<int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int>>(ref this.BuyRechargeStoreGoodsEvent, (Action<int>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_BuyRechargeStoreGoodsEventAction`1_hotfix != null)
				{
					this.m_remove_BuyRechargeStoreGoodsEventAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int> action = this.BuyRechargeStoreGoodsEvent;
				Action<int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int>>(ref this.BuyRechargeStoreGoodsEvent, (Action<int>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1400005C RID: 92
		// (add) Token: 0x060047D7 RID: 18391 RVA: 0x0016319C File Offset: 0x0016139C
		// (remove) Token: 0x060047D8 RID: 18392 RVA: 0x00163238 File Offset: 0x00161438
		public event Action<int, int> BuyStoreItemEvent
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_BuyStoreItemEventAction`2_hotfix != null)
				{
					this.m_add_BuyStoreItemEventAction`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int, int> action = this.BuyStoreItemEvent;
				Action<int, int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int, int>>(ref this.BuyStoreItemEvent, (Action<int, int>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_BuyStoreItemEventAction`2_hotfix != null)
				{
					this.m_remove_BuyStoreItemEventAction`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int, int> action = this.BuyStoreItemEvent;
				Action<int, int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int, int>>(ref this.BuyStoreItemEvent, (Action<int, int>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17001203 RID: 4611
		// (get) Token: 0x060047D9 RID: 18393 RVA: 0x001632D4 File Offset: 0x001614D4
		// (set) Token: 0x060047DA RID: 18394 RVA: 0x001632F4 File Offset: 0x001614F4
		[DoNotToLua]
		public RechargeStoreComponentCommon.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new RechargeStoreComponentCommon.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x060047DB RID: 18395 RVA: 0x00163300 File Offset: 0x00161500
		private void __callDele_BuyRechargeStoreGoodsEvent(int obj)
		{
			Action<int> buyRechargeStoreGoodsEvent = this.BuyRechargeStoreGoodsEvent;
			if (buyRechargeStoreGoodsEvent != null)
			{
				buyRechargeStoreGoodsEvent(obj);
			}
		}

		// Token: 0x060047DC RID: 18396 RVA: 0x00163324 File Offset: 0x00161524
		private void __clearDele_BuyRechargeStoreGoodsEvent(int obj)
		{
			this.BuyRechargeStoreGoodsEvent = null;
		}

		// Token: 0x060047DD RID: 18397 RVA: 0x00163330 File Offset: 0x00161530
		private void __callDele_BuyStoreItemEvent(int arg1, int arg2)
		{
			Action<int, int> buyStoreItemEvent = this.BuyStoreItemEvent;
			if (buyStoreItemEvent != null)
			{
				buyStoreItemEvent(arg1, arg2);
			}
		}

		// Token: 0x060047DE RID: 18398 RVA: 0x00163354 File Offset: 0x00161554
		private void __clearDele_BuyStoreItemEvent(int arg1, int arg2)
		{
			this.BuyStoreItemEvent = null;
		}

		// Token: 0x060047DF RID: 18399 RVA: 0x00163360 File Offset: 0x00161560
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
					this.m_GetName_hotfix = (luaObj.RawGet("GetName") as LuaFunction);
					this.m_Init_hotfix = (luaObj.RawGet("Init") as LuaFunction);
					this.m_PostInit_hotfix = (luaObj.RawGet("PostInit") as LuaFunction);
					this.m_DeInit_hotfix = (luaObj.RawGet("DeInit") as LuaFunction);
					this.m_TickUInt32_hotfix = (luaObj.RawGet("Tick") as LuaFunction);
					this.m_SerializeT_hotfix = (luaObj.RawGet("Serialize") as LuaFunction);
					this.m_DeSerializeT_hotfix = (luaObj.RawGet("DeSerialize") as LuaFunction);
					this.m_PostDeSerialize_hotfix = (luaObj.RawGet("PostDeSerialize") as LuaFunction);
					this.m_get_Owner_hotfix = (luaObj.RawGet("get_Owner") as LuaFunction);
					this.m_set_OwnerIComponentOwner_hotfix = (luaObj.RawGet("set_Owner") as LuaFunction);
					this.m_IsGoodsBoughtInt32_hotfix = (luaObj.RawGet("IsGoodsBought") as LuaFunction);
					this.m_CaculateGotCrystalNumsInt32_hotfix = (luaObj.RawGet("CaculateGotCrystalNums") as LuaFunction);
					this.m_BuyGoodsInt32_hotfix = (luaObj.RawGet("BuyGoods") as LuaFunction);
					this.m_add_BuyRechargeStoreGoodsEventAction`1_hotfix = (luaObj.RawGet("add_BuyRechargeStoreGoodsEvent") as LuaFunction);
					this.m_remove_BuyRechargeStoreGoodsEventAction`1_hotfix = (luaObj.RawGet("remove_BuyRechargeStoreGoodsEvent") as LuaFunction);
					this.m_add_BuyStoreItemEventAction`2_hotfix = (luaObj.RawGet("add_BuyStoreItemEvent") as LuaFunction);
					this.m_remove_BuyStoreItemEventAction`2_hotfix = (luaObj.RawGet("remove_BuyStoreItemEvent") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x060047E0 RID: 18400 RVA: 0x001635D4 File Offset: 0x001617D4
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(RechargeStoreComponentCommon));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04003654 RID: 13908
		protected IConfigDataLoader m_configDataLoader;

		// Token: 0x04003655 RID: 13909
		protected DataSectionRechargeStore m_rechargeStoreDS = new DataSectionRechargeStore();

		// Token: 0x04003656 RID: 13910
		protected PlayerBasicInfoComponentCommon m_basicInfo;

		// Token: 0x04003659 RID: 13913
		[DoNotToLua]
		private RechargeStoreComponentCommon.LuaExportHelper luaExportHelper;

		// Token: 0x0400365A RID: 13914
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400365B RID: 13915
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400365C RID: 13916
		private LuaFunction m_ctor_hotfix;

		// Token: 0x0400365D RID: 13917
		private LuaFunction m_GetName_hotfix;

		// Token: 0x0400365E RID: 13918
		private LuaFunction m_Init_hotfix;

		// Token: 0x0400365F RID: 13919
		private LuaFunction m_PostInit_hotfix;

		// Token: 0x04003660 RID: 13920
		private LuaFunction m_DeInit_hotfix;

		// Token: 0x04003661 RID: 13921
		private LuaFunction m_TickUInt32_hotfix;

		// Token: 0x04003662 RID: 13922
		private LuaFunction m_SerializeT_hotfix;

		// Token: 0x04003663 RID: 13923
		private LuaFunction m_DeSerializeT_hotfix;

		// Token: 0x04003664 RID: 13924
		private LuaFunction m_PostDeSerialize_hotfix;

		// Token: 0x04003665 RID: 13925
		private LuaFunction m_get_Owner_hotfix;

		// Token: 0x04003666 RID: 13926
		private LuaFunction m_set_OwnerIComponentOwner_hotfix;

		// Token: 0x04003667 RID: 13927
		private LuaFunction m_IsGoodsBoughtInt32_hotfix;

		// Token: 0x04003668 RID: 13928
		private LuaFunction m_CaculateGotCrystalNumsInt32_hotfix;

		// Token: 0x04003669 RID: 13929
		private LuaFunction m_BuyGoodsInt32_hotfix;

		// Token: 0x0400366A RID: 13930
		private LuaFunction m_add_BuyRechargeStoreGoodsEventAction;

		// Token: 0x0400366B RID: 13931
		private LuaFunction m_remove_BuyRechargeStoreGoodsEventAction;

		// Token: 0x0400366C RID: 13932
		private LuaFunction m_add_BuyStoreItemEventAction;

		// Token: 0x0400366D RID: 13933
		private LuaFunction m_remove_BuyStoreItemEventAction;

		// Token: 0x020004A3 RID: 1187
		public class LuaExportHelper
		{
			// Token: 0x060047E1 RID: 18401 RVA: 0x0016363C File Offset: 0x0016183C
			public LuaExportHelper(RechargeStoreComponentCommon owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x060047E2 RID: 18402 RVA: 0x0016364C File Offset: 0x0016184C
			public void __callDele_BuyRechargeStoreGoodsEvent(int obj)
			{
				this.m_owner.__callDele_BuyRechargeStoreGoodsEvent(obj);
			}

			// Token: 0x060047E3 RID: 18403 RVA: 0x0016365C File Offset: 0x0016185C
			public void __clearDele_BuyRechargeStoreGoodsEvent(int obj)
			{
				this.m_owner.__clearDele_BuyRechargeStoreGoodsEvent(obj);
			}

			// Token: 0x060047E4 RID: 18404 RVA: 0x0016366C File Offset: 0x0016186C
			public void __callDele_BuyStoreItemEvent(int arg1, int arg2)
			{
				this.m_owner.__callDele_BuyStoreItemEvent(arg1, arg2);
			}

			// Token: 0x060047E5 RID: 18405 RVA: 0x0016367C File Offset: 0x0016187C
			public void __clearDele_BuyStoreItemEvent(int arg1, int arg2)
			{
				this.m_owner.__clearDele_BuyStoreItemEvent(arg1, arg2);
			}

			// Token: 0x17001204 RID: 4612
			// (get) Token: 0x060047E6 RID: 18406 RVA: 0x0016368C File Offset: 0x0016188C
			// (set) Token: 0x060047E7 RID: 18407 RVA: 0x0016369C File Offset: 0x0016189C
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

			// Token: 0x17001205 RID: 4613
			// (get) Token: 0x060047E8 RID: 18408 RVA: 0x001636AC File Offset: 0x001618AC
			// (set) Token: 0x060047E9 RID: 18409 RVA: 0x001636BC File Offset: 0x001618BC
			public DataSectionRechargeStore m_rechargeStoreDS
			{
				get
				{
					return this.m_owner.m_rechargeStoreDS;
				}
				set
				{
					this.m_owner.m_rechargeStoreDS = value;
				}
			}

			// Token: 0x17001206 RID: 4614
			// (get) Token: 0x060047EA RID: 18410 RVA: 0x001636CC File Offset: 0x001618CC
			// (set) Token: 0x060047EB RID: 18411 RVA: 0x001636DC File Offset: 0x001618DC
			public PlayerBasicInfoComponentCommon m_basicInfo
			{
				get
				{
					return this.m_owner.m_basicInfo;
				}
				set
				{
					this.m_owner.m_basicInfo = value;
				}
			}

			// Token: 0x060047EC RID: 18412 RVA: 0x001636EC File Offset: 0x001618EC
			public void BuyGoods(int goodsId)
			{
				this.m_owner.BuyGoods(goodsId);
			}

			// Token: 0x0400366E RID: 13934
			private RechargeStoreComponentCommon m_owner;
		}
	}
}
