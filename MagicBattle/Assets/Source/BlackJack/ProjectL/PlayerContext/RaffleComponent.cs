using System;
using System.Collections.Generic;
using System.Linq;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.PlayerContext
{
	// Token: 0x020008D7 RID: 2263
	[HotFix]
	public class RaffleComponent : RaffleComponentCommon
	{
		// Token: 0x06007577 RID: 30071 RVA: 0x002030EC File Offset: 0x002012EC
		public RaffleComponent()
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

		// Token: 0x06007578 RID: 30072 RVA: 0x00203154 File Offset: 0x00201354
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

		// Token: 0x06007579 RID: 30073 RVA: 0x002031D0 File Offset: 0x002013D0
		public void DeSerialize(DSRaffleNtf msg)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DeSerializeDSRaffleNtf_hotfix != null)
			{
				this.m_DeSerializeDSRaffleNtf_hotfix.call(new object[]
				{
					this,
					msg
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_RaffleDS.ClearInitedData();
			List<RafflePool> rafflePools = RafflePool.PBRafflePoolsToRafflePools(msg.RafflePools);
			base.InitRafflePoolConfigs(rafflePools);
			this.m_RaffleDS.InitRafflePools(rafflePools);
			this.m_RaffleDS.InitVersion((ushort)msg.Version, (ushort)msg.Version);
		}

		// Token: 0x0600757A RID: 30074 RVA: 0x00203284 File Offset: 0x00201484
		public List<RafflePool> GetOpenRafflePools()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetOpenRafflePools_hotfix != null)
			{
				return (List<RafflePool>)this.m_GetOpenRafflePools_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<int> allOpenActivityRafflePool = base.GetAllOpenActivityRafflePool();
			return (from rafflePool in allOpenActivityRafflePool.Select(new Func<int, RafflePool>(base.GetRafflePool))
			where rafflePool != null
			select rafflePool).ToList<RafflePool>();
		}

		// Token: 0x0600757B RID: 30075 RVA: 0x00203330 File Offset: 0x00201530
		public void Drawed(int poolId, int raffleId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DrawedInt32Int32_hotfix != null)
			{
				this.m_DrawedInt32Int32_hotfix.call(new object[]
				{
					this,
					poolId,
					raffleId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			RafflePool rafflePool = base.GetRafflePool(poolId);
			base.DrawCostItem(rafflePool, raffleId);
		}

		// Token: 0x0600757C RID: 30076 RVA: 0x002033C0 File Offset: 0x002015C0
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
			return this.m_RaffleDS.Version;
		}

		// Token: 0x17001BDB RID: 7131
		// (get) Token: 0x0600757D RID: 30077 RVA: 0x00203438 File Offset: 0x00201638
		// (set) Token: 0x0600757E RID: 30078 RVA: 0x00203458 File Offset: 0x00201658
		[DoNotToLua]
		public new RaffleComponent.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new RaffleComponent.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600757F RID: 30079 RVA: 0x00203464 File Offset: 0x00201664
		private string __callBase_GetName()
		{
			return base.GetName();
		}

		// Token: 0x06007580 RID: 30080 RVA: 0x0020346C File Offset: 0x0020166C
		private void __callBase_Init()
		{
			base.Init();
		}

		// Token: 0x06007581 RID: 30081 RVA: 0x00203474 File Offset: 0x00201674
		private void __callBase_PostInit()
		{
			base.PostInit();
		}

		// Token: 0x06007582 RID: 30082 RVA: 0x0020347C File Offset: 0x0020167C
		private void __callBase_DeInit()
		{
			base.DeInit();
		}

		// Token: 0x06007583 RID: 30083 RVA: 0x00203484 File Offset: 0x00201684
		private void __callBase_Tick(uint deltaMillisecond)
		{
			base.Tick(deltaMillisecond);
		}

		// Token: 0x06007584 RID: 30084 RVA: 0x00203490 File Offset: 0x00201690
		private void __callBase_PostDeSerialize()
		{
			base.PostDeSerialize();
		}

		// Token: 0x06007585 RID: 30085 RVA: 0x00203498 File Offset: 0x00201698
		private void __callBase_RemoveRafflePool(int poolId)
		{
			base.RemoveRafflePool(poolId);
		}

		// Token: 0x06007586 RID: 30086 RVA: 0x002034A4 File Offset: 0x002016A4
		private void __callBase_InitRafflePoolConfigs(List<RafflePool> rafflePools)
		{
			base.InitRafflePoolConfigs(rafflePools);
		}

		// Token: 0x06007587 RID: 30087 RVA: 0x002034B0 File Offset: 0x002016B0
		private int __callBase_IsRafflePoolOnActivityTime(int rafflePoolId)
		{
			return base.IsRafflePoolOnActivityTime(rafflePoolId);
		}

		// Token: 0x06007588 RID: 30088 RVA: 0x002034BC File Offset: 0x002016BC
		private OperationalActivityBase __callBase_FindOperationalActivityByRafflePoolId(int activityCardPoolId)
		{
			return base.FindOperationalActivityByRafflePoolId(activityCardPoolId);
		}

		// Token: 0x06007589 RID: 30089 RVA: 0x002034C8 File Offset: 0x002016C8
		private List<int> __callBase_GetAllOpenActivityRafflePool()
		{
			return base.GetAllOpenActivityRafflePool();
		}

		// Token: 0x0600758A RID: 30090 RVA: 0x002034D0 File Offset: 0x002016D0
		private RafflePool __callBase_GetRafflePool(int poolId)
		{
			return base.GetRafflePool(poolId);
		}

		// Token: 0x0600758B RID: 30091 RVA: 0x002034DC File Offset: 0x002016DC
		private bool __callBase_IsRaffleItemsAllDrawed(RafflePool pool)
		{
			return base.IsRaffleItemsAllDrawed(pool);
		}

		// Token: 0x0600758C RID: 30092 RVA: 0x002034E8 File Offset: 0x002016E8
		private bool __callBase_IsDrawItemsEnough(GoodsType goodsType, int drawItemId, int count)
		{
			return base.IsDrawItemsEnough(goodsType, drawItemId, count);
		}

		// Token: 0x0600758D RID: 30093 RVA: 0x002034F4 File Offset: 0x002016F4
		private int __callBase_GetDrawItemCost(RafflePool pool)
		{
			return base.GetDrawItemCost(pool);
		}

		// Token: 0x0600758E RID: 30094 RVA: 0x00203500 File Offset: 0x00201700
		private bool __callBase_CanFreeDraw(RafflePool pool)
		{
			return base.CanFreeDraw(pool);
		}

		// Token: 0x0600758F RID: 30095 RVA: 0x0020350C File Offset: 0x0020170C
		private int __callBase_CanDraw(int poolId)
		{
			return base.CanDraw(poolId);
		}

		// Token: 0x06007590 RID: 30096 RVA: 0x00203518 File Offset: 0x00201718
		private void __callBase_DrawCostItem(RafflePool rafflePool, int raffleId)
		{
			base.DrawCostItem(rafflePool, raffleId);
		}

		// Token: 0x06007591 RID: 30097 RVA: 0x00203524 File Offset: 0x00201724
		private RaffleItem __callBase_GetRaffleItem(RafflePool pool, int raffleId)
		{
			return base.GetRaffleItem(pool, raffleId);
		}

		// Token: 0x06007592 RID: 30098 RVA: 0x00203530 File Offset: 0x00201730
		private int __callBase_GetFreeDrawedCount(RafflePool pool)
		{
			return base.GetFreeDrawedCount(pool);
		}

		// Token: 0x06007593 RID: 30099 RVA: 0x0020353C File Offset: 0x0020173C
		private int __callBase_GetDrawedCount(RafflePool pool)
		{
			return base.GetDrawedCount(pool);
		}

		// Token: 0x06007594 RID: 30100 RVA: 0x00203548 File Offset: 0x00201748
		private int __callBase_GetAllDrawedCount(RafflePool pool)
		{
			return base.GetAllDrawedCount(pool);
		}

		// Token: 0x06007596 RID: 30102 RVA: 0x00203560 File Offset: 0x00201760
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
					this.m_DeSerializeDSRaffleNtf_hotfix = (luaObj.RawGet("DeSerialize") as LuaFunction);
					this.m_GetOpenRafflePools_hotfix = (luaObj.RawGet("GetOpenRafflePools") as LuaFunction);
					this.m_DrawedInt32Int32_hotfix = (luaObj.RawGet("Drawed") as LuaFunction);
					this.m_GetDSVersion_hotfix = (luaObj.RawGet("GetDSVersion") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06007597 RID: 30103 RVA: 0x002036A8 File Offset: 0x002018A8
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(RaffleComponent));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040055CB RID: 21963
		[DoNotToLua]
		private RaffleComponent.LuaExportHelper luaExportHelper;

		// Token: 0x040055CD RID: 21965
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040055CE RID: 21966
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040055CF RID: 21967
		private LuaFunction m_ctor_hotfix;

		// Token: 0x040055D0 RID: 21968
		private LuaFunction m_Init_hotfix;

		// Token: 0x040055D1 RID: 21969
		private LuaFunction m_DeSerializeDSRaffleNtf_hotfix;

		// Token: 0x040055D2 RID: 21970
		private LuaFunction m_GetOpenRafflePools_hotfix;

		// Token: 0x040055D3 RID: 21971
		private LuaFunction m_DrawedInt32Int32_hotfix;

		// Token: 0x040055D4 RID: 21972
		private LuaFunction m_GetDSVersion_hotfix;

		// Token: 0x020008D8 RID: 2264
		public new class LuaExportHelper
		{
			// Token: 0x06007598 RID: 30104 RVA: 0x00203710 File Offset: 0x00201910
			public LuaExportHelper(RaffleComponent owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06007599 RID: 30105 RVA: 0x00203720 File Offset: 0x00201920
			public string __callBase_GetName()
			{
				return this.m_owner.__callBase_GetName();
			}

			// Token: 0x0600759A RID: 30106 RVA: 0x00203730 File Offset: 0x00201930
			public void __callBase_Init()
			{
				this.m_owner.__callBase_Init();
			}

			// Token: 0x0600759B RID: 30107 RVA: 0x00203740 File Offset: 0x00201940
			public void __callBase_PostInit()
			{
				this.m_owner.__callBase_PostInit();
			}

			// Token: 0x0600759C RID: 30108 RVA: 0x00203750 File Offset: 0x00201950
			public void __callBase_DeInit()
			{
				this.m_owner.__callBase_DeInit();
			}

			// Token: 0x0600759D RID: 30109 RVA: 0x00203760 File Offset: 0x00201960
			public void __callBase_Tick(uint deltaMillisecond)
			{
				this.m_owner.__callBase_Tick(deltaMillisecond);
			}

			// Token: 0x0600759E RID: 30110 RVA: 0x00203770 File Offset: 0x00201970
			public void __callBase_PostDeSerialize()
			{
				this.m_owner.__callBase_PostDeSerialize();
			}

			// Token: 0x0600759F RID: 30111 RVA: 0x00203780 File Offset: 0x00201980
			public void __callBase_RemoveRafflePool(int poolId)
			{
				this.m_owner.__callBase_RemoveRafflePool(poolId);
			}

			// Token: 0x060075A0 RID: 30112 RVA: 0x00203790 File Offset: 0x00201990
			public void __callBase_InitRafflePoolConfigs(List<RafflePool> rafflePools)
			{
				this.m_owner.__callBase_InitRafflePoolConfigs(rafflePools);
			}

			// Token: 0x060075A1 RID: 30113 RVA: 0x002037A0 File Offset: 0x002019A0
			public int __callBase_IsRafflePoolOnActivityTime(int rafflePoolId)
			{
				return this.m_owner.__callBase_IsRafflePoolOnActivityTime(rafflePoolId);
			}

			// Token: 0x060075A2 RID: 30114 RVA: 0x002037B0 File Offset: 0x002019B0
			public OperationalActivityBase __callBase_FindOperationalActivityByRafflePoolId(int activityCardPoolId)
			{
				return this.m_owner.__callBase_FindOperationalActivityByRafflePoolId(activityCardPoolId);
			}

			// Token: 0x060075A3 RID: 30115 RVA: 0x002037C0 File Offset: 0x002019C0
			public List<int> __callBase_GetAllOpenActivityRafflePool()
			{
				return this.m_owner.__callBase_GetAllOpenActivityRafflePool();
			}

			// Token: 0x060075A4 RID: 30116 RVA: 0x002037D0 File Offset: 0x002019D0
			public RafflePool __callBase_GetRafflePool(int poolId)
			{
				return this.m_owner.__callBase_GetRafflePool(poolId);
			}

			// Token: 0x060075A5 RID: 30117 RVA: 0x002037E0 File Offset: 0x002019E0
			public bool __callBase_IsRaffleItemsAllDrawed(RafflePool pool)
			{
				return this.m_owner.__callBase_IsRaffleItemsAllDrawed(pool);
			}

			// Token: 0x060075A6 RID: 30118 RVA: 0x002037F0 File Offset: 0x002019F0
			public bool __callBase_IsDrawItemsEnough(GoodsType goodsType, int drawItemId, int count)
			{
				return this.m_owner.__callBase_IsDrawItemsEnough(goodsType, drawItemId, count);
			}

			// Token: 0x060075A7 RID: 30119 RVA: 0x00203800 File Offset: 0x00201A00
			public int __callBase_GetDrawItemCost(RafflePool pool)
			{
				return this.m_owner.__callBase_GetDrawItemCost(pool);
			}

			// Token: 0x060075A8 RID: 30120 RVA: 0x00203810 File Offset: 0x00201A10
			public bool __callBase_CanFreeDraw(RafflePool pool)
			{
				return this.m_owner.__callBase_CanFreeDraw(pool);
			}

			// Token: 0x060075A9 RID: 30121 RVA: 0x00203820 File Offset: 0x00201A20
			public int __callBase_CanDraw(int poolId)
			{
				return this.m_owner.__callBase_CanDraw(poolId);
			}

			// Token: 0x060075AA RID: 30122 RVA: 0x00203830 File Offset: 0x00201A30
			public void __callBase_DrawCostItem(RafflePool rafflePool, int raffleId)
			{
				this.m_owner.__callBase_DrawCostItem(rafflePool, raffleId);
			}

			// Token: 0x060075AB RID: 30123 RVA: 0x00203840 File Offset: 0x00201A40
			public RaffleItem __callBase_GetRaffleItem(RafflePool pool, int raffleId)
			{
				return this.m_owner.__callBase_GetRaffleItem(pool, raffleId);
			}

			// Token: 0x060075AC RID: 30124 RVA: 0x00203850 File Offset: 0x00201A50
			public int __callBase_GetFreeDrawedCount(RafflePool pool)
			{
				return this.m_owner.__callBase_GetFreeDrawedCount(pool);
			}

			// Token: 0x060075AD RID: 30125 RVA: 0x00203860 File Offset: 0x00201A60
			public int __callBase_GetDrawedCount(RafflePool pool)
			{
				return this.m_owner.__callBase_GetDrawedCount(pool);
			}

			// Token: 0x060075AE RID: 30126 RVA: 0x00203870 File Offset: 0x00201A70
			public int __callBase_GetAllDrawedCount(RafflePool pool)
			{
				return this.m_owner.__callBase_GetAllDrawedCount(pool);
			}

			// Token: 0x040055D5 RID: 21973
			private RaffleComponent m_owner;
		}
	}
}
