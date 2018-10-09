using System;
using System.Runtime.CompilerServices;
using System.Threading;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.ConfigData;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x0200049B RID: 1179
	[HotFix]
	public class RandomStoreComponentCommon : IComponentBase
	{
		// Token: 0x06004755 RID: 18261 RVA: 0x0015FAE4 File Offset: 0x0015DCE4
		public RandomStoreComponentCommon()
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

		// Token: 0x06004756 RID: 18262 RVA: 0x0015FB58 File Offset: 0x0015DD58
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
			return "RandomStore";
		}

		// Token: 0x06004757 RID: 18263 RVA: 0x0015FBCC File Offset: 0x0015DDCC
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

		// Token: 0x06004758 RID: 18264 RVA: 0x0015FC2C File Offset: 0x0015DE2C
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
			this.m_bag = (this.Owner.GetOwnerComponent("Bag") as BagComponentCommon);
			this.m_basicInfo.PlayerActionFlushEvent += this.OnFlushManualFlushNums;
		}

		// Token: 0x06004759 RID: 18265 RVA: 0x0015FCDC File Offset: 0x0015DEDC
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

		// Token: 0x0600475A RID: 18266 RVA: 0x0015FD3C File Offset: 0x0015DF3C
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

		// Token: 0x0600475B RID: 18267 RVA: 0x0015FDAC File Offset: 0x0015DFAC
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

		// Token: 0x0600475C RID: 18268 RVA: 0x0015FE2C File Offset: 0x0015E02C
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

		// Token: 0x0600475D RID: 18269 RVA: 0x0015FE9C File Offset: 0x0015E09C
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

		// Token: 0x170011F4 RID: 4596
		// (get) Token: 0x0600475E RID: 18270 RVA: 0x0015FEFC File Offset: 0x0015E0FC
		// (set) Token: 0x0600475F RID: 18271 RVA: 0x0015FF70 File Offset: 0x0015E170
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

		// Token: 0x06004760 RID: 18272 RVA: 0x0015FFE8 File Offset: 0x0015E1E8
		public void OnFlushManualFlushNums()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnFlushManualFlushNums_hotfix != null)
			{
				this.m_OnFlushManualFlushNums_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (RandomStore store in this.m_randomStoreDS.Stores)
			{
				this.m_randomStoreDS.SetManualFlushNums(store, 0);
			}
		}

		// Token: 0x06004761 RID: 18273 RVA: 0x001600A4 File Offset: 0x0015E2A4
		public bool CanAutoFlushStore(RandomStore store)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanAutoFlushStoreRandomStore_hotfix != null)
			{
				return Convert.ToBoolean(this.m_CanAutoFlushStoreRandomStore_hotfix.call(new object[]
				{
					this,
					store
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_basicInfo.GetCurrentTime() >= store.NextFlushTime;
		}

		// Token: 0x06004762 RID: 18274 RVA: 0x00160138 File Offset: 0x0015E338
		protected bool IsBoughtStoreItem(RandomStoreItem storeItem)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsBoughtStoreItemRandomStoreItem_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsBoughtStoreItemRandomStoreItem_hotfix.call(new object[]
				{
					this,
					storeItem
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return storeItem.Bought;
		}

		// Token: 0x06004763 RID: 18275 RVA: 0x001601C0 File Offset: 0x0015E3C0
		protected int CanManualFlushStore(RandomStore store, ConfigDataRandomStoreInfo storeInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanManualFlushStoreRandomStoreConfigDataRandomStoreInfo_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanManualFlushStoreRandomStoreConfigDataRandomStoreInfo_hotfix.call(new object[]
				{
					this,
					store,
					storeInfo
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (store.ManualFlushNums >= this.m_configDataLoader.ConfigableConstId_RandomStoreManualFlushMaxNums)
			{
				return -1105;
			}
			return this.m_basicInfo.IsCurrencyEnough(storeInfo.CurrencyType, storeInfo.Price);
		}

		// Token: 0x06004764 RID: 18276 RVA: 0x00160280 File Offset: 0x0015E480
		public virtual int CanBuyRandomStoreItem(int storeId, int index, int selectedIndex)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanBuyRandomStoreItemInt32Int32Int32_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanBuyRandomStoreItemInt32Int32Int32_hotfix.call(new object[]
				{
					this,
					storeId,
					index,
					selectedIndex
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			RandomStore randomStore = this.m_randomStoreDS.FindStore(storeId);
			if (randomStore == null)
			{
				return -1100;
			}
			if (index < 0 || index >= randomStore.Items.Count)
			{
				return -1101;
			}
			RandomStoreItem storeItem = this.m_randomStoreDS.GetStoreItem(randomStore, index);
			if (this.IsBoughtStoreItem(storeItem))
			{
				return -1102;
			}
			ConfigDataRandomStoreItemInfo configDataRandomStoreItemInfo = this.m_configDataLoader.GetConfigDataRandomStoreItemInfo(storeItem.Id);
			int num = this.m_basicInfo.IsCurrencyEnough(configDataRandomStoreItemInfo.CurrencyType, configDataRandomStoreItemInfo.Price);
			if (num != 0)
			{
				return num;
			}
			if (configDataRandomStoreItemInfo.ItemType == GoodsType.GoodsType_Item)
			{
				ConfigDataItemInfo configDataItemInfo = this.m_configDataLoader.GetConfigDataItemInfo(configDataRandomStoreItemInfo.ItemID);
				if (configDataItemInfo.FuncType == ItemFuncType.ItemFuncType_SelfSelectedBox)
				{
					ConfigDataSelfSelectedBoxInfo configDataSelfSelectedBoxInfo = this.m_configDataLoader.GetConfigDataSelfSelectedBoxInfo(configDataItemInfo.FuncTypeParam1);
					if (configDataSelfSelectedBoxInfo.Reward.Count <= selectedIndex || selectedIndex < 0)
					{
						return -539;
					}
				}
				else if (selectedIndex != -1)
				{
					return -540;
				}
			}
			else if (selectedIndex != -1)
			{
				return -540;
			}
			if (this.m_bag.IsBagFullByCurrentSize())
			{
				return -500;
			}
			return 0;
		}

		// Token: 0x06004765 RID: 18277 RVA: 0x00160440 File Offset: 0x0015E640
		protected void OnBuyStoreItem(int storeId, int goodsId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnBuyStoreItemInt32Int32_hotfix != null)
			{
				this.m_OnBuyStoreItemInt32Int32_hotfix.call(new object[]
				{
					this,
					storeId,
					goodsId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.BuyStoreItemEvent != null)
			{
				this.BuyStoreItemEvent(storeId, goodsId);
			}
		}

		// Token: 0x14000057 RID: 87
		// (add) Token: 0x06004766 RID: 18278 RVA: 0x001604D8 File Offset: 0x0015E6D8
		// (remove) Token: 0x06004767 RID: 18279 RVA: 0x00160574 File Offset: 0x0015E774
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

		// Token: 0x170011F5 RID: 4597
		// (get) Token: 0x06004768 RID: 18280 RVA: 0x00160610 File Offset: 0x0015E810
		// (set) Token: 0x06004769 RID: 18281 RVA: 0x00160630 File Offset: 0x0015E830
		[DoNotToLua]
		public RandomStoreComponentCommon.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new RandomStoreComponentCommon.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600476A RID: 18282 RVA: 0x0016063C File Offset: 0x0015E83C
		private void __callDele_BuyStoreItemEvent(int arg1, int arg2)
		{
			Action<int, int> buyStoreItemEvent = this.BuyStoreItemEvent;
			if (buyStoreItemEvent != null)
			{
				buyStoreItemEvent(arg1, arg2);
			}
		}

		// Token: 0x0600476B RID: 18283 RVA: 0x00160660 File Offset: 0x0015E860
		private void __clearDele_BuyStoreItemEvent(int arg1, int arg2)
		{
			this.BuyStoreItemEvent = null;
		}

		// Token: 0x0600476C RID: 18284 RVA: 0x0016066C File Offset: 0x0015E86C
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
					this.m_OnFlushManualFlushNums_hotfix = (luaObj.RawGet("OnFlushManualFlushNums") as LuaFunction);
					this.m_CanAutoFlushStoreRandomStore_hotfix = (luaObj.RawGet("CanAutoFlushStore") as LuaFunction);
					this.m_IsBoughtStoreItemRandomStoreItem_hotfix = (luaObj.RawGet("IsBoughtStoreItem") as LuaFunction);
					this.m_CanManualFlushStoreRandomStoreConfigDataRandomStoreInfo_hotfix = (luaObj.RawGet("CanManualFlushStore") as LuaFunction);
					this.m_CanBuyRandomStoreItemInt32Int32Int32_hotfix = (luaObj.RawGet("CanBuyRandomStoreItem") as LuaFunction);
					this.m_OnBuyStoreItemInt32Int32_hotfix = (luaObj.RawGet("OnBuyStoreItem") as LuaFunction);
					this.m_add_BuyStoreItemEventAction`2_hotfix = (luaObj.RawGet("add_BuyStoreItemEvent") as LuaFunction);
					this.m_remove_BuyStoreItemEventAction`2_hotfix = (luaObj.RawGet("remove_BuyStoreItemEvent") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600476D RID: 18285 RVA: 0x001608FC File Offset: 0x0015EAFC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(RandomStoreComponentCommon));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040035FF RID: 13823
		protected IConfigDataLoader m_configDataLoader;

		// Token: 0x04003600 RID: 13824
		protected PlayerBasicInfoComponentCommon m_basicInfo;

		// Token: 0x04003601 RID: 13825
		protected BagComponentCommon m_bag;

		// Token: 0x04003602 RID: 13826
		protected DataSectionRandomStore m_randomStoreDS = new DataSectionRandomStore();

		// Token: 0x04003604 RID: 13828
		[DoNotToLua]
		private RandomStoreComponentCommon.LuaExportHelper luaExportHelper;

		// Token: 0x04003605 RID: 13829
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04003606 RID: 13830
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04003607 RID: 13831
		private LuaFunction m_ctor_hotfix;

		// Token: 0x04003608 RID: 13832
		private LuaFunction m_GetName_hotfix;

		// Token: 0x04003609 RID: 13833
		private LuaFunction m_Init_hotfix;

		// Token: 0x0400360A RID: 13834
		private LuaFunction m_PostInit_hotfix;

		// Token: 0x0400360B RID: 13835
		private LuaFunction m_DeInit_hotfix;

		// Token: 0x0400360C RID: 13836
		private LuaFunction m_TickUInt32_hotfix;

		// Token: 0x0400360D RID: 13837
		private LuaFunction m_SerializeT_hotfix;

		// Token: 0x0400360E RID: 13838
		private LuaFunction m_DeSerializeT_hotfix;

		// Token: 0x0400360F RID: 13839
		private LuaFunction m_PostDeSerialize_hotfix;

		// Token: 0x04003610 RID: 13840
		private LuaFunction m_get_Owner_hotfix;

		// Token: 0x04003611 RID: 13841
		private LuaFunction m_set_OwnerIComponentOwner_hotfix;

		// Token: 0x04003612 RID: 13842
		private LuaFunction m_OnFlushManualFlushNums_hotfix;

		// Token: 0x04003613 RID: 13843
		private LuaFunction m_CanAutoFlushStoreRandomStore_hotfix;

		// Token: 0x04003614 RID: 13844
		private LuaFunction m_IsBoughtStoreItemRandomStoreItem_hotfix;

		// Token: 0x04003615 RID: 13845
		private LuaFunction m_CanManualFlushStoreRandomStoreConfigDataRandomStoreInfo_hotfix;

		// Token: 0x04003616 RID: 13846
		private LuaFunction m_CanBuyRandomStoreItemInt32Int32Int32_hotfix;

		// Token: 0x04003617 RID: 13847
		private LuaFunction m_OnBuyStoreItemInt32Int32_hotfix;

		// Token: 0x04003618 RID: 13848
		private LuaFunction m_add_BuyStoreItemEventAction;

		// Token: 0x04003619 RID: 13849
		private LuaFunction m_remove_BuyStoreItemEventAction;

		// Token: 0x0200049C RID: 1180
		public class LuaExportHelper
		{
			// Token: 0x0600476E RID: 18286 RVA: 0x00160964 File Offset: 0x0015EB64
			public LuaExportHelper(RandomStoreComponentCommon owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600476F RID: 18287 RVA: 0x00160974 File Offset: 0x0015EB74
			public void __callDele_BuyStoreItemEvent(int arg1, int arg2)
			{
				this.m_owner.__callDele_BuyStoreItemEvent(arg1, arg2);
			}

			// Token: 0x06004770 RID: 18288 RVA: 0x00160984 File Offset: 0x0015EB84
			public void __clearDele_BuyStoreItemEvent(int arg1, int arg2)
			{
				this.m_owner.__clearDele_BuyStoreItemEvent(arg1, arg2);
			}

			// Token: 0x170011F6 RID: 4598
			// (get) Token: 0x06004771 RID: 18289 RVA: 0x00160994 File Offset: 0x0015EB94
			// (set) Token: 0x06004772 RID: 18290 RVA: 0x001609A4 File Offset: 0x0015EBA4
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

			// Token: 0x170011F7 RID: 4599
			// (get) Token: 0x06004773 RID: 18291 RVA: 0x001609B4 File Offset: 0x0015EBB4
			// (set) Token: 0x06004774 RID: 18292 RVA: 0x001609C4 File Offset: 0x0015EBC4
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

			// Token: 0x170011F8 RID: 4600
			// (get) Token: 0x06004775 RID: 18293 RVA: 0x001609D4 File Offset: 0x0015EBD4
			// (set) Token: 0x06004776 RID: 18294 RVA: 0x001609E4 File Offset: 0x0015EBE4
			public BagComponentCommon m_bag
			{
				get
				{
					return this.m_owner.m_bag;
				}
				set
				{
					this.m_owner.m_bag = value;
				}
			}

			// Token: 0x170011F9 RID: 4601
			// (get) Token: 0x06004777 RID: 18295 RVA: 0x001609F4 File Offset: 0x0015EBF4
			// (set) Token: 0x06004778 RID: 18296 RVA: 0x00160A04 File Offset: 0x0015EC04
			public DataSectionRandomStore m_randomStoreDS
			{
				get
				{
					return this.m_owner.m_randomStoreDS;
				}
				set
				{
					this.m_owner.m_randomStoreDS = value;
				}
			}

			// Token: 0x06004779 RID: 18297 RVA: 0x00160A14 File Offset: 0x0015EC14
			public bool IsBoughtStoreItem(RandomStoreItem storeItem)
			{
				return this.m_owner.IsBoughtStoreItem(storeItem);
			}

			// Token: 0x0600477A RID: 18298 RVA: 0x00160A24 File Offset: 0x0015EC24
			public int CanManualFlushStore(RandomStore store, ConfigDataRandomStoreInfo storeInfo)
			{
				return this.m_owner.CanManualFlushStore(store, storeInfo);
			}

			// Token: 0x0600477B RID: 18299 RVA: 0x00160A34 File Offset: 0x0015EC34
			public void OnBuyStoreItem(int storeId, int goodsId)
			{
				this.m_owner.OnBuyStoreItem(storeId, goodsId);
			}

			// Token: 0x0400361A RID: 13850
			private RandomStoreComponentCommon m_owner;
		}
	}
}
