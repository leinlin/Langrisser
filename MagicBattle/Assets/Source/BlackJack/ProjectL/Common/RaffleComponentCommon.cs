using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.ConfigData;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x02000497 RID: 1175
	[HotFix]
	public class RaffleComponentCommon : IComponentBase
	{
		// Token: 0x06004725 RID: 18213 RVA: 0x0015E45C File Offset: 0x0015C65C
		public RaffleComponentCommon()
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

		// Token: 0x06004726 RID: 18214 RVA: 0x0015E4D0 File Offset: 0x0015C6D0
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
			return "Raffle";
		}

		// Token: 0x06004727 RID: 18215 RVA: 0x0015E544 File Offset: 0x0015C744
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

		// Token: 0x06004728 RID: 18216 RVA: 0x0015E5A4 File Offset: 0x0015C7A4
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
			this.m_operationalActivity = (this.Owner.GetOwnerComponent("OperationalActivity") as OperationalActivityCompomentCommon);
		}

		// Token: 0x06004729 RID: 18217 RVA: 0x0015E658 File Offset: 0x0015C858
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

		// Token: 0x0600472A RID: 18218 RVA: 0x0015E6B8 File Offset: 0x0015C8B8
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

		// Token: 0x0600472B RID: 18219 RVA: 0x0015E728 File Offset: 0x0015C928
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

		// Token: 0x0600472C RID: 18220 RVA: 0x0015E7A8 File Offset: 0x0015C9A8
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

		// Token: 0x0600472D RID: 18221 RVA: 0x0015E818 File Offset: 0x0015CA18
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

		// Token: 0x170011ED RID: 4589
		// (get) Token: 0x0600472E RID: 18222 RVA: 0x0015E878 File Offset: 0x0015CA78
		// (set) Token: 0x0600472F RID: 18223 RVA: 0x0015E8EC File Offset: 0x0015CAEC
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

		// Token: 0x06004730 RID: 18224 RVA: 0x0015E964 File Offset: 0x0015CB64
		public void RemoveRafflePool(int poolId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_RemoveRafflePoolInt32_hotfix != null)
			{
				this.m_RemoveRafflePoolInt32_hotfix.call(new object[]
				{
					this,
					poolId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_RaffleDS.RemoveRafflePool(poolId);
		}

		// Token: 0x06004731 RID: 18225 RVA: 0x0015E9E0 File Offset: 0x0015CBE0
		protected void InitRafflePoolConfigs(List<RafflePool> rafflePools)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitRafflePoolConfigsList`1_hotfix != null)
			{
				this.m_InitRafflePoolConfigsList`1_hotfix.call(new object[]
				{
					this,
					rafflePools
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (RafflePool rafflePool in rafflePools)
			{
				rafflePool.Config = this.m_configDataLoader.GetConfigDataRafflePoolInfo(rafflePool.PoolId);
			}
		}

		// Token: 0x06004732 RID: 18226 RVA: 0x0015EAAC File Offset: 0x0015CCAC
		public int IsRafflePoolOnActivityTime(int rafflePoolId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsRafflePoolOnActivityTimeInt32_hotfix != null)
			{
				return Convert.ToInt32(this.m_IsRafflePoolOnActivityTimeInt32_hotfix.call(new object[]
				{
					this,
					rafflePoolId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.FindOperationalActivityByRafflePoolId(rafflePoolId) == null)
			{
				return -4900;
			}
			return 0;
		}

		// Token: 0x06004733 RID: 18227 RVA: 0x0015EB40 File Offset: 0x0015CD40
		public OperationalActivityBase FindOperationalActivityByRafflePoolId(int activityCardPoolId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FindOperationalActivityByRafflePoolIdInt32_hotfix != null)
			{
				return (OperationalActivityBase)this.m_FindOperationalActivityByRafflePoolIdInt32_hotfix.call(new object[]
				{
					this,
					activityCardPoolId
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_operationalActivity.FindOperationalActivityByRafflePoolId(activityCardPoolId);
		}

		// Token: 0x06004734 RID: 18228 RVA: 0x0015EBC8 File Offset: 0x0015CDC8
		public List<int> GetAllOpenActivityRafflePool()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetAllOpenActivityRafflePool_hotfix != null)
			{
				return (List<int>)this.m_GetAllOpenActivityRafflePool_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<int> list = new List<int>();
			List<OperationalActivityBase> list2 = this.m_operationalActivity.FindOperationalActivitiesByType(OperationalActivityType.OperationalActivityType_Raffle);
			foreach (OperationalActivityBase operationalActivityBase in list2)
			{
				foreach (ActivityParam activityParam in operationalActivityBase.Config.OperationalActivityParms)
				{
					if (!list.Contains(activityParam.Parm1))
					{
						list.Add(activityParam.Parm1);
					}
				}
			}
			return list;
		}

		// Token: 0x06004735 RID: 18229 RVA: 0x0015ECF8 File Offset: 0x0015CEF8
		public RafflePool GetRafflePool(int poolId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetRafflePoolInt32_hotfix != null)
			{
				return (RafflePool)this.m_GetRafflePoolInt32_hotfix.call(new object[]
				{
					this,
					poolId
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			RafflePool rafflePool = this.m_RaffleDS.GetRafflePool(poolId);
			if (rafflePool == null)
			{
				ConfigDataRafflePoolInfo configDataRafflePoolInfo = this.m_configDataLoader.GetConfigDataRafflePoolInfo(poolId);
				if (configDataRafflePoolInfo == null)
				{
					return null;
				}
				OperationalActivityBase operationalActivityBase = this.m_operationalActivity.FindOperationalActivityByRafflePoolId(poolId);
				if (operationalActivityBase == null)
				{
					return null;
				}
				rafflePool = new RafflePool(poolId)
				{
					Config = configDataRafflePoolInfo
				};
				rafflePool.ActivityInstanceId = operationalActivityBase.InstanceId;
				this.m_RaffleDS.RafflePools.Add(rafflePool.PoolId, rafflePool);
				this.m_RaffleDS.SetDirty(true);
			}
			return rafflePool;
		}

		// Token: 0x06004736 RID: 18230 RVA: 0x0015EDF4 File Offset: 0x0015CFF4
		public bool IsRaffleItemsAllDrawed(RafflePool pool)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsRaffleItemsAllDrawedRafflePool_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsRaffleItemsAllDrawedRafflePool_hotfix.call(new object[]
				{
					this,
					pool2
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			RafflePool pool = pool2;
			return pool.Config.RaffleItems.All((RaffleItem t) => pool.DrawedRaffleIds.Contains(t.RaffleID));
		}

		// Token: 0x06004737 RID: 18231 RVA: 0x0015EEA0 File Offset: 0x0015D0A0
		public bool IsDrawItemsEnough(GoodsType goodsType, int drawItemId, int count)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsDrawItemsEnoughGoodsTypeInt32Int32_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsDrawItemsEnoughGoodsTypeInt32Int32_hotfix.call(new object[]
				{
					this,
					goodsType,
					drawItemId,
					count
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (goodsType == GoodsType.GoodsType_Crystal)
			{
				return this.m_basicInfo.IsCrystalEnough(count);
			}
			if (goodsType == GoodsType.GoodsType_Item)
			{
				return this.m_bag.IsBagItemEnough(GoodsType.GoodsType_Item, drawItemId, count);
			}
			throw new Exception(string.Format("Invaild raffle draw goodsType:{0}", goodsType));
		}

		// Token: 0x06004738 RID: 18232 RVA: 0x0015EF80 File Offset: 0x0015D180
		public int GetDrawItemCost(RafflePool pool)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetDrawItemCostRafflePool_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetDrawItemCostRafflePool_hotfix.call(new object[]
				{
					this,
					pool
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int result = 0;
			foreach (Int32Pair int32Pair in pool.Config.Costs)
			{
				if (pool.DrawedCount + 1 >= int32Pair.Key)
				{
					result = int32Pair.Value;
				}
			}
			return result;
		}

		// Token: 0x06004739 RID: 18233 RVA: 0x0015F068 File Offset: 0x0015D268
		public bool CanFreeDraw(RafflePool pool)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanFreeDrawRafflePool_hotfix != null)
			{
				return Convert.ToBoolean(this.m_CanFreeDrawRafflePool_hotfix.call(new object[]
				{
					this,
					pool
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return pool.FreeDrawedCount < pool.Config.FreeDrawCount;
		}

		// Token: 0x0600473A RID: 18234 RVA: 0x0015F0F8 File Offset: 0x0015D2F8
		public int CanDraw(int poolId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanDrawInt32_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanDrawInt32_hotfix.call(new object[]
				{
					this,
					poolId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.IsRafflePoolOnActivityTime(poolId) != 0)
			{
				return -4900;
			}
			RafflePool rafflePool = this.GetRafflePool(poolId);
			if (rafflePool == null)
			{
				return -4901;
			}
			if (this.m_bag.IsBagFullByCurrentSize())
			{
				return -500;
			}
			if (this.IsRaffleItemsAllDrawed(rafflePool))
			{
				return -2218;
			}
			if (this.CanFreeDraw(rafflePool))
			{
				return 0;
			}
			int drawItemCost = this.GetDrawItemCost(rafflePool);
			if (!this.IsDrawItemsEnough(rafflePool.Config.GoodsType, rafflePool.Config.DrawItemID, drawItemCost))
			{
				return -2219;
			}
			return 0;
		}

		// Token: 0x0600473B RID: 18235 RVA: 0x0015F204 File Offset: 0x0015D404
		protected void DrawCostItem(RafflePool rafflePool, int raffleId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DrawCostItemRafflePoolInt32_hotfix != null)
			{
				this.m_DrawCostItemRafflePoolInt32_hotfix.call(new object[]
				{
					this,
					rafflePool,
					raffleId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.CanFreeDraw(rafflePool))
			{
				rafflePool.FreeDrawedCount++;
				rafflePool.DrawedRaffleIds.Add(raffleId);
				this.m_RaffleDS.SetDirty(true);
			}
			else
			{
				int drawItemCost = this.GetDrawItemCost(rafflePool);
				rafflePool.DrawedCount++;
				rafflePool.DrawedRaffleIds.Add(raffleId);
				this.m_RaffleDS.SetDirty(true);
				if (rafflePool.Config.GoodsType == GoodsType.GoodsType_Crystal)
				{
					this.m_basicInfo.AddCrystal(-drawItemCost, GameFunctionType.GameFunctionType_Raffle, rafflePool.PoolId.ToString());
				}
				else if (rafflePool.Config.GoodsType == GoodsType.GoodsType_Item)
				{
					this.m_bag.RemoveBagItemByType(GoodsType.GoodsType_Item, rafflePool.Config.DrawItemID, drawItemCost, GameFunctionType.GameFunctionType_Raffle, rafflePool.PoolId.ToString());
				}
			}
		}

		// Token: 0x0600473C RID: 18236 RVA: 0x0015F368 File Offset: 0x0015D568
		public RaffleItem GetRaffleItem(RafflePool pool, int raffleId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetRaffleItemRafflePoolInt32_hotfix != null)
			{
				return (RaffleItem)this.m_GetRaffleItemRafflePoolInt32_hotfix.call(new object[]
				{
					this,
					pool,
					raffleId2
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int raffleId = raffleId2;
			return (pool != null) ? pool.Config.RaffleItems.Find((RaffleItem e) => e.RaffleID == raffleId) : null;
		}

		// Token: 0x0600473D RID: 18237 RVA: 0x0015F42C File Offset: 0x0015D62C
		public int GetFreeDrawedCount(RafflePool pool)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetFreeDrawedCountRafflePool_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetFreeDrawedCountRafflePool_hotfix.call(new object[]
				{
					this,
					pool
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return (pool != null) ? pool.FreeDrawedCount : int.MaxValue;
		}

		// Token: 0x0600473E RID: 18238 RVA: 0x0015F4C0 File Offset: 0x0015D6C0
		public int GetDrawedCount(RafflePool pool)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetDrawedCountRafflePool_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetDrawedCountRafflePool_hotfix.call(new object[]
				{
					this,
					pool
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return (pool != null) ? pool.DrawedCount : int.MaxValue;
		}

		// Token: 0x0600473F RID: 18239 RVA: 0x0015F554 File Offset: 0x0015D754
		public int GetAllDrawedCount(RafflePool pool)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetAllDrawedCountRafflePool_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetAllDrawedCountRafflePool_hotfix.call(new object[]
				{
					this,
					pool
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return (pool != null) ? (pool.DrawedCount + pool.FreeDrawedCount) : int.MaxValue;
		}

		// Token: 0x170011EE RID: 4590
		// (get) Token: 0x06004740 RID: 18240 RVA: 0x0015F5F0 File Offset: 0x0015D7F0
		// (set) Token: 0x06004741 RID: 18241 RVA: 0x0015F610 File Offset: 0x0015D810
		[DoNotToLua]
		public RaffleComponentCommon.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new RaffleComponentCommon.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06004742 RID: 18242 RVA: 0x0015F61C File Offset: 0x0015D81C
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
					this.m_RemoveRafflePoolInt32_hotfix = (luaObj.RawGet("RemoveRafflePool") as LuaFunction);
					this.m_InitRafflePoolConfigsList`1_hotfix = (luaObj.RawGet("InitRafflePoolConfigs") as LuaFunction);
					this.m_IsRafflePoolOnActivityTimeInt32_hotfix = (luaObj.RawGet("IsRafflePoolOnActivityTime") as LuaFunction);
					this.m_FindOperationalActivityByRafflePoolIdInt32_hotfix = (luaObj.RawGet("FindOperationalActivityByRafflePoolId") as LuaFunction);
					this.m_GetAllOpenActivityRafflePool_hotfix = (luaObj.RawGet("GetAllOpenActivityRafflePool") as LuaFunction);
					this.m_GetRafflePoolInt32_hotfix = (luaObj.RawGet("GetRafflePool") as LuaFunction);
					this.m_IsRaffleItemsAllDrawedRafflePool_hotfix = (luaObj.RawGet("IsRaffleItemsAllDrawed") as LuaFunction);
					this.m_IsDrawItemsEnoughGoodsTypeInt32Int32_hotfix = (luaObj.RawGet("IsDrawItemsEnough") as LuaFunction);
					this.m_GetDrawItemCostRafflePool_hotfix = (luaObj.RawGet("GetDrawItemCost") as LuaFunction);
					this.m_CanFreeDrawRafflePool_hotfix = (luaObj.RawGet("CanFreeDraw") as LuaFunction);
					this.m_CanDrawInt32_hotfix = (luaObj.RawGet("CanDraw") as LuaFunction);
					this.m_DrawCostItemRafflePoolInt32_hotfix = (luaObj.RawGet("DrawCostItem") as LuaFunction);
					this.m_GetRaffleItemRafflePoolInt32_hotfix = (luaObj.RawGet("GetRaffleItem") as LuaFunction);
					this.m_GetFreeDrawedCountRafflePool_hotfix = (luaObj.RawGet("GetFreeDrawedCount") as LuaFunction);
					this.m_GetDrawedCountRafflePool_hotfix = (luaObj.RawGet("GetDrawedCount") as LuaFunction);
					this.m_GetAllDrawedCountRafflePool_hotfix = (luaObj.RawGet("GetAllDrawedCount") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06004743 RID: 18243 RVA: 0x0015F974 File Offset: 0x0015DB74
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(RaffleComponentCommon));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040035D8 RID: 13784
		protected PlayerBasicInfoComponentCommon m_basicInfo;

		// Token: 0x040035D9 RID: 13785
		protected IConfigDataLoader m_configDataLoader;

		// Token: 0x040035DA RID: 13786
		protected BagComponentCommon m_bag;

		// Token: 0x040035DB RID: 13787
		protected OperationalActivityCompomentCommon m_operationalActivity;

		// Token: 0x040035DC RID: 13788
		protected DataSectionRaffle m_RaffleDS = new DataSectionRaffle();

		// Token: 0x040035DD RID: 13789
		[DoNotToLua]
		private RaffleComponentCommon.LuaExportHelper luaExportHelper;

		// Token: 0x040035DE RID: 13790
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040035DF RID: 13791
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040035E0 RID: 13792
		private LuaFunction m_ctor_hotfix;

		// Token: 0x040035E1 RID: 13793
		private LuaFunction m_GetName_hotfix;

		// Token: 0x040035E2 RID: 13794
		private LuaFunction m_Init_hotfix;

		// Token: 0x040035E3 RID: 13795
		private LuaFunction m_PostInit_hotfix;

		// Token: 0x040035E4 RID: 13796
		private LuaFunction m_DeInit_hotfix;

		// Token: 0x040035E5 RID: 13797
		private LuaFunction m_TickUInt32_hotfix;

		// Token: 0x040035E6 RID: 13798
		private LuaFunction m_SerializeT_hotfix;

		// Token: 0x040035E7 RID: 13799
		private LuaFunction m_DeSerializeT_hotfix;

		// Token: 0x040035E8 RID: 13800
		private LuaFunction m_PostDeSerialize_hotfix;

		// Token: 0x040035E9 RID: 13801
		private LuaFunction m_get_Owner_hotfix;

		// Token: 0x040035EA RID: 13802
		private LuaFunction m_set_OwnerIComponentOwner_hotfix;

		// Token: 0x040035EB RID: 13803
		private LuaFunction m_RemoveRafflePoolInt32_hotfix;

		// Token: 0x040035EC RID: 13804
		private LuaFunction m_InitRafflePoolConfigsList;

		// Token: 0x040035ED RID: 13805
		private LuaFunction m_IsRafflePoolOnActivityTimeInt32_hotfix;

		// Token: 0x040035EE RID: 13806
		private LuaFunction m_FindOperationalActivityByRafflePoolIdInt32_hotfix;

		// Token: 0x040035EF RID: 13807
		private LuaFunction m_GetAllOpenActivityRafflePool_hotfix;

		// Token: 0x040035F0 RID: 13808
		private LuaFunction m_GetRafflePoolInt32_hotfix;

		// Token: 0x040035F1 RID: 13809
		private LuaFunction m_IsRaffleItemsAllDrawedRafflePool_hotfix;

		// Token: 0x040035F2 RID: 13810
		private LuaFunction m_IsDrawItemsEnoughGoodsTypeInt32Int32_hotfix;

		// Token: 0x040035F3 RID: 13811
		private LuaFunction m_GetDrawItemCostRafflePool_hotfix;

		// Token: 0x040035F4 RID: 13812
		private LuaFunction m_CanFreeDrawRafflePool_hotfix;

		// Token: 0x040035F5 RID: 13813
		private LuaFunction m_CanDrawInt32_hotfix;

		// Token: 0x040035F6 RID: 13814
		private LuaFunction m_DrawCostItemRafflePoolInt32_hotfix;

		// Token: 0x040035F7 RID: 13815
		private LuaFunction m_GetRaffleItemRafflePoolInt32_hotfix;

		// Token: 0x040035F8 RID: 13816
		private LuaFunction m_GetFreeDrawedCountRafflePool_hotfix;

		// Token: 0x040035F9 RID: 13817
		private LuaFunction m_GetDrawedCountRafflePool_hotfix;

		// Token: 0x040035FA RID: 13818
		private LuaFunction m_GetAllDrawedCountRafflePool_hotfix;

		// Token: 0x02000498 RID: 1176
		public class LuaExportHelper
		{
			// Token: 0x06004744 RID: 18244 RVA: 0x0015F9DC File Offset: 0x0015DBDC
			public LuaExportHelper(RaffleComponentCommon owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x170011EF RID: 4591
			// (get) Token: 0x06004745 RID: 18245 RVA: 0x0015F9EC File Offset: 0x0015DBEC
			// (set) Token: 0x06004746 RID: 18246 RVA: 0x0015F9FC File Offset: 0x0015DBFC
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

			// Token: 0x170011F0 RID: 4592
			// (get) Token: 0x06004747 RID: 18247 RVA: 0x0015FA0C File Offset: 0x0015DC0C
			// (set) Token: 0x06004748 RID: 18248 RVA: 0x0015FA1C File Offset: 0x0015DC1C
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

			// Token: 0x170011F1 RID: 4593
			// (get) Token: 0x06004749 RID: 18249 RVA: 0x0015FA2C File Offset: 0x0015DC2C
			// (set) Token: 0x0600474A RID: 18250 RVA: 0x0015FA3C File Offset: 0x0015DC3C
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

			// Token: 0x170011F2 RID: 4594
			// (get) Token: 0x0600474B RID: 18251 RVA: 0x0015FA4C File Offset: 0x0015DC4C
			// (set) Token: 0x0600474C RID: 18252 RVA: 0x0015FA5C File Offset: 0x0015DC5C
			public OperationalActivityCompomentCommon m_operationalActivity
			{
				get
				{
					return this.m_owner.m_operationalActivity;
				}
				set
				{
					this.m_owner.m_operationalActivity = value;
				}
			}

			// Token: 0x170011F3 RID: 4595
			// (get) Token: 0x0600474D RID: 18253 RVA: 0x0015FA6C File Offset: 0x0015DC6C
			// (set) Token: 0x0600474E RID: 18254 RVA: 0x0015FA7C File Offset: 0x0015DC7C
			public DataSectionRaffle m_RaffleDS
			{
				get
				{
					return this.m_owner.m_RaffleDS;
				}
				set
				{
					this.m_owner.m_RaffleDS = value;
				}
			}

			// Token: 0x0600474F RID: 18255 RVA: 0x0015FA8C File Offset: 0x0015DC8C
			public void InitRafflePoolConfigs(List<RafflePool> rafflePools)
			{
				this.m_owner.InitRafflePoolConfigs(rafflePools);
			}

			// Token: 0x06004750 RID: 18256 RVA: 0x0015FA9C File Offset: 0x0015DC9C
			public void DrawCostItem(RafflePool rafflePool, int raffleId)
			{
				this.m_owner.DrawCostItem(rafflePool, raffleId);
			}

			// Token: 0x040035FB RID: 13819
			private RaffleComponentCommon m_owner;
		}
	}
}
