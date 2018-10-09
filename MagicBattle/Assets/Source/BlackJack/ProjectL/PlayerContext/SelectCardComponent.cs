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
	// Token: 0x020008E3 RID: 2275
	[HotFix]
	public class SelectCardComponent : SelectCardComponentCommon
	{
		// Token: 0x060076D0 RID: 30416 RVA: 0x00207B74 File Offset: 0x00205D74
		public SelectCardComponent()
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

		// Token: 0x060076D1 RID: 30417 RVA: 0x00207BDC File Offset: 0x00205DDC
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

		// Token: 0x060076D2 RID: 30418 RVA: 0x00207C58 File Offset: 0x00205E58
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

		// Token: 0x060076D3 RID: 30419 RVA: 0x00207CC0 File Offset: 0x00205EC0
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

		// Token: 0x060076D4 RID: 30420 RVA: 0x00207D28 File Offset: 0x00205F28
		public void DeSerialize(DSSelectCardNtf msg)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DeSerializeDSSelectCardNtf_hotfix != null)
			{
				this.m_DeSerializeDSSelectCardNtf_hotfix.call(new object[]
				{
					this,
					msg
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_selectCardDS.ClearInitedData();
			List<CardPool> cardPools = CardPool.PBActivityCardPoolsToCardPools(msg.CardPools);
			base.InitCardPoolConfigs(cardPools);
			this.m_selectCardDS.InitCardPools(cardPools);
			this.m_selectCardDS.InitVersion((ushort)msg.Version, (ushort)msg.Version);
		}

		// Token: 0x060076D5 RID: 30421 RVA: 0x00207DDC File Offset: 0x00205FDC
		public List<CardPool> GetActivityCardPool()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetActivityCardPool_hotfix != null)
			{
				return (List<CardPool>)this.m_GetActivityCardPool_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<CardPool> list = new List<CardPool>();
			List<int> allOpenActivityCardPool = base.GetAllOpenActivityCardPool();
			foreach (int cardPoolId in allOpenActivityCardPool)
			{
				CardPool cardPoolById = base.GetCardPoolById(cardPoolId, true);
				if (cardPoolById != null)
				{
					list.Add(cardPoolById);
				}
			}
			return list;
		}

		// Token: 0x060076D6 RID: 30422 RVA: 0x00207EB0 File Offset: 0x002060B0
		public void SelectCard(int cardPoolId, bool isSingleSelect, bool isUsingTicket, int guaranteedAccumulatedValue, int guaranteedSelectCardCount)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SelectCardInt32BooleanBooleanInt32Int32_hotfix != null)
			{
				this.m_SelectCardInt32BooleanBooleanInt32Int32_hotfix.call(new object[]
				{
					this,
					cardPoolId,
					isSingleSelect,
					isUsingTicket,
					guaranteedAccumulatedValue,
					guaranteedSelectCardCount
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CardPool cardPool = this.m_selectCardDS.FindCardPool(cardPoolId);
			if (cardPool == null)
			{
				ConfigDataCardPoolInfo configDataCardPoolInfo = this.m_configDataLoader.GetConfigDataCardPoolInfo(cardPoolId);
				if (configDataCardPoolInfo == null)
				{
					return;
				}
				cardPool = new CardPool(cardPoolId);
				cardPool.Config = configDataCardPoolInfo;
			}
			if (isSingleSelect)
			{
				if (this.m_selectCardDS.IsFirstSingleSelectCard(cardPool))
				{
					this.m_selectCardDS.FinishFirstSingleSelect(cardPool);
				}
			}
			else if (this.m_selectCardDS.IsFirstTenSelectCard(cardPool))
			{
				this.m_selectCardDS.FinishFirstTenSelect(cardPool);
			}
			this.m_selectCardDS.AddSelectCount(cardPool, 1);
			this.m_selectCardDS.SetGuaranteedAccumulatedValue(guaranteedAccumulatedValue);
			this.m_selectCardDS.SetGuaranteedSelectCardCount(guaranteedSelectCardCount);
			base.SelectCardSpendTicketsOrCrystal(cardPool, isSingleSelect, isUsingTicket);
			if (cardPool.Config.PoolType == CardPoolType.CardPoolType_ActivityCardPool && base.IsActivityCardPoolOnActivityTime(cardPoolId) != 0)
			{
				return;
			}
			this.m_selectCardDS.AddCardPool(cardPool);
		}

		// Token: 0x060076D7 RID: 30423 RVA: 0x00208038 File Offset: 0x00206238
		public string GetActivityTimeByPoolId(int poolId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetActivityTimeByPoolIdInt32_hotfix != null)
			{
				return (string)this.m_GetActivityTimeByPoolIdInt32_hotfix.call(new object[]
				{
					this,
					poolId
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			OperationalActivityBase operationalActivityBase = base.FindOperationalActivityByActivityCardPoolId(poolId);
			string result = null;
			if (operationalActivityBase != null)
			{
				result = operationalActivityBase.OperationStartTime + " - " + operationalActivityBase.OperationEndTime;
			}
			return result;
		}

		// Token: 0x060076D8 RID: 30424 RVA: 0x002080E8 File Offset: 0x002062E8
		public int CanSelectCard(int cardPoolId, bool isSingleSelect, bool isUsingTickets)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanSelectCardInt32BooleanBoolean_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanSelectCardInt32BooleanBoolean_hotfix.call(new object[]
				{
					this,
					cardPoolId,
					isSingleSelect,
					isUsingTickets
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CardPool cardPool = this.m_selectCardDS.FindCardPool(cardPoolId);
			if (cardPool == null)
			{
				ConfigDataCardPoolInfo configDataCardPoolInfo = this.m_configDataLoader.GetConfigDataCardPoolInfo(cardPoolId);
				if (configDataCardPoolInfo == null)
				{
					return -1503;
				}
				if (configDataCardPoolInfo.PoolType == CardPoolType.CardPoolType_ActivityCardPool)
				{
					OperationalActivityBase operationalActivityBase = this.m_operationalActivity.FindOperationalActivityByActivityCardPoolId(cardPoolId);
					if (operationalActivityBase == null)
					{
						return -1500;
					}
					cardPool = new CardPool(cardPoolId);
					cardPool.ActivityInstanceId = operationalActivityBase.InstanceId;
				}
				else
				{
					cardPool = new CardPool(cardPoolId);
				}
				cardPool.Config = configDataCardPoolInfo;
			}
			return base.CanSelectCard(cardPool, isSingleSelect, isUsingTickets);
		}

		// Token: 0x060076D9 RID: 30425 RVA: 0x00208204 File Offset: 0x00206404
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
			return this.m_selectCardDS.Version;
		}

		// Token: 0x17001BE3 RID: 7139
		// (get) Token: 0x060076DA RID: 30426 RVA: 0x0020827C File Offset: 0x0020647C
		// (set) Token: 0x060076DB RID: 30427 RVA: 0x0020829C File Offset: 0x0020649C
		[DoNotToLua]
		public new SelectCardComponent.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new SelectCardComponent.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x060076DC RID: 30428 RVA: 0x002082A8 File Offset: 0x002064A8
		private string __callBase_GetName()
		{
			return base.GetName();
		}

		// Token: 0x060076DD RID: 30429 RVA: 0x002082B0 File Offset: 0x002064B0
		private void __callBase_Init()
		{
			base.Init();
		}

		// Token: 0x060076DE RID: 30430 RVA: 0x002082B8 File Offset: 0x002064B8
		private void __callBase_PostInit()
		{
			base.PostInit();
		}

		// Token: 0x060076DF RID: 30431 RVA: 0x002082C0 File Offset: 0x002064C0
		private void __callBase_DeInit()
		{
			base.DeInit();
		}

		// Token: 0x060076E0 RID: 30432 RVA: 0x002082C8 File Offset: 0x002064C8
		private void __callBase_Tick(uint deltaMillisecond)
		{
			base.Tick(deltaMillisecond);
		}

		// Token: 0x060076E1 RID: 30433 RVA: 0x002082D4 File Offset: 0x002064D4
		private void __callBase_PostDeSerialize()
		{
			base.PostDeSerialize();
		}

		// Token: 0x060076E2 RID: 30434 RVA: 0x002082DC File Offset: 0x002064DC
		private void __callBase_RemoveCardPool(int cardPool)
		{
			base.RemoveCardPool(cardPool);
		}

		// Token: 0x060076E3 RID: 30435 RVA: 0x002082E8 File Offset: 0x002064E8
		private void __callBase_InitCardPoolConfigs(List<CardPool> cardPools)
		{
			base.InitCardPoolConfigs(cardPools);
		}

		// Token: 0x060076E4 RID: 30436 RVA: 0x002082F4 File Offset: 0x002064F4
		private int __callBase_IsActivityCardPoolOnActivityTime(int activityCardPoolId)
		{
			return base.IsActivityCardPoolOnActivityTime(activityCardPoolId);
		}

		// Token: 0x060076E5 RID: 30437 RVA: 0x00208300 File Offset: 0x00206500
		private OperationalActivityBase __callBase_FindOperationalActivityByActivityCardPoolId(int activityCardPoolId)
		{
			return base.FindOperationalActivityByActivityCardPoolId(activityCardPoolId);
		}

		// Token: 0x060076E6 RID: 30438 RVA: 0x0020830C File Offset: 0x0020650C
		private List<int> __callBase_GetAllOpenActivityCardPool()
		{
			return base.GetAllOpenActivityCardPool();
		}

		// Token: 0x060076E7 RID: 30439 RVA: 0x00208314 File Offset: 0x00206514
		private bool __callBase_IsUsedOutActivityCardPoolSelectOpportunity(CardPool cardPool)
		{
			return base.IsUsedOutActivityCardPoolSelectOpportunity(cardPool);
		}

		// Token: 0x060076E8 RID: 30440 RVA: 0x00208320 File Offset: 0x00206520
		private CardPool __callBase_GetCardPoolById(int cardPoolId, bool ignoreActivityCheck)
		{
			return base.GetCardPoolById(cardPoolId, ignoreActivityCheck);
		}

		// Token: 0x060076E9 RID: 30441 RVA: 0x0020832C File Offset: 0x0020652C
		private bool __callBase_IsTicketsEnough(int ticketId, int ticketCount)
		{
			return base.IsTicketsEnough(ticketId, ticketCount);
		}

		// Token: 0x060076EA RID: 30442 RVA: 0x00208338 File Offset: 0x00206538
		private int __callBase_GetCrystalCount(CardPool cardPool, bool isSingleSelect, out bool isTenSelectDiscount)
		{
			return base.GetCrystalCount(cardPool, isSingleSelect, out isTenSelectDiscount);
		}

		// Token: 0x060076EB RID: 30443 RVA: 0x00208344 File Offset: 0x00206544
		private void __callBase_SelectCardUseTickets(CardPool cardPool, bool isSingleSelect)
		{
			base.SelectCardUseTickets(cardPool, isSingleSelect);
		}

		// Token: 0x060076EC RID: 30444 RVA: 0x00208350 File Offset: 0x00206550
		private void __callBase_SelectCardUseCrystal(CardPool cardPool, bool isSingleSelect)
		{
			base.SelectCardUseCrystal(cardPool, isSingleSelect);
		}

		// Token: 0x060076ED RID: 30445 RVA: 0x0020835C File Offset: 0x0020655C
		private int __callBase_CanSelectCard(CardPool cardPool, bool isSingleSelect, bool isUsingTickets)
		{
			return base.CanSelectCard(cardPool, isSingleSelect, isUsingTickets);
		}

		// Token: 0x060076EE RID: 30446 RVA: 0x00208368 File Offset: 0x00206568
		private bool __callBase_IsCrystalOrActivityCardPool(CardPoolType cardPoolType)
		{
			return base.IsCrystalOrActivityCardPool(cardPoolType);
		}

		// Token: 0x060076EF RID: 30447 RVA: 0x00208374 File Offset: 0x00206574
		private int __callBase_CanUseTicketSelectCard(CardPool cardPool, int ticketNums)
		{
			return base.CanUseTicketSelectCard(cardPool, ticketNums);
		}

		// Token: 0x060076F0 RID: 30448 RVA: 0x00208380 File Offset: 0x00206580
		private void __callBase_SelectCardSpendTicketsOrCrystal(CardPool cardPool, bool isSingleSelect, bool isUsingTickets)
		{
			base.SelectCardSpendTicketsOrCrystal(cardPool, isSingleSelect, isUsingTickets);
		}

		// Token: 0x060076F1 RID: 30449 RVA: 0x0020838C File Offset: 0x0020658C
		private void __callBase_SelectHeroCard(int heroId)
		{
			base.SelectHeroCard(heroId);
		}

		// Token: 0x060076F2 RID: 30450 RVA: 0x00208398 File Offset: 0x00206598
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
					this.m_DeSerializeDSSelectCardNtf_hotfix = (luaObj.RawGet("DeSerialize") as LuaFunction);
					this.m_GetActivityCardPool_hotfix = (luaObj.RawGet("GetActivityCardPool") as LuaFunction);
					this.m_SelectCardInt32BooleanBooleanInt32Int32_hotfix = (luaObj.RawGet("SelectCard") as LuaFunction);
					this.m_GetActivityTimeByPoolIdInt32_hotfix = (luaObj.RawGet("GetActivityTimeByPoolId") as LuaFunction);
					this.m_CanSelectCardInt32BooleanBoolean_hotfix = (luaObj.RawGet("CanSelectCard") as LuaFunction);
					this.m_GetDSVersion_hotfix = (luaObj.RawGet("GetDSVersion") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x060076F3 RID: 30451 RVA: 0x00208544 File Offset: 0x00206744
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(SelectCardComponent));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400562E RID: 22062
		[DoNotToLua]
		private SelectCardComponent.LuaExportHelper luaExportHelper;

		// Token: 0x0400562F RID: 22063
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04005630 RID: 22064
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04005631 RID: 22065
		private LuaFunction m_ctor_hotfix;

		// Token: 0x04005632 RID: 22066
		private LuaFunction m_Init_hotfix;

		// Token: 0x04005633 RID: 22067
		private LuaFunction m_PostInit_hotfix;

		// Token: 0x04005634 RID: 22068
		private LuaFunction m_DeInit_hotfix;

		// Token: 0x04005635 RID: 22069
		private LuaFunction m_DeSerializeDSSelectCardNtf_hotfix;

		// Token: 0x04005636 RID: 22070
		private LuaFunction m_GetActivityCardPool_hotfix;

		// Token: 0x04005637 RID: 22071
		private LuaFunction m_SelectCardInt32BooleanBooleanInt32Int32_hotfix;

		// Token: 0x04005638 RID: 22072
		private LuaFunction m_GetActivityTimeByPoolIdInt32_hotfix;

		// Token: 0x04005639 RID: 22073
		private LuaFunction m_CanSelectCardInt32BooleanBoolean_hotfix;

		// Token: 0x0400563A RID: 22074
		private LuaFunction m_GetDSVersion_hotfix;

		// Token: 0x020008E4 RID: 2276
		public new class LuaExportHelper
		{
			// Token: 0x060076F4 RID: 30452 RVA: 0x002085AC File Offset: 0x002067AC
			public LuaExportHelper(SelectCardComponent owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x060076F5 RID: 30453 RVA: 0x002085BC File Offset: 0x002067BC
			public string __callBase_GetName()
			{
				return this.m_owner.__callBase_GetName();
			}

			// Token: 0x060076F6 RID: 30454 RVA: 0x002085CC File Offset: 0x002067CC
			public void __callBase_Init()
			{
				this.m_owner.__callBase_Init();
			}

			// Token: 0x060076F7 RID: 30455 RVA: 0x002085DC File Offset: 0x002067DC
			public void __callBase_PostInit()
			{
				this.m_owner.__callBase_PostInit();
			}

			// Token: 0x060076F8 RID: 30456 RVA: 0x002085EC File Offset: 0x002067EC
			public void __callBase_DeInit()
			{
				this.m_owner.__callBase_DeInit();
			}

			// Token: 0x060076F9 RID: 30457 RVA: 0x002085FC File Offset: 0x002067FC
			public void __callBase_Tick(uint deltaMillisecond)
			{
				this.m_owner.__callBase_Tick(deltaMillisecond);
			}

			// Token: 0x060076FA RID: 30458 RVA: 0x0020860C File Offset: 0x0020680C
			public void __callBase_PostDeSerialize()
			{
				this.m_owner.__callBase_PostDeSerialize();
			}

			// Token: 0x060076FB RID: 30459 RVA: 0x0020861C File Offset: 0x0020681C
			public void __callBase_RemoveCardPool(int cardPool)
			{
				this.m_owner.__callBase_RemoveCardPool(cardPool);
			}

			// Token: 0x060076FC RID: 30460 RVA: 0x0020862C File Offset: 0x0020682C
			public void __callBase_InitCardPoolConfigs(List<CardPool> cardPools)
			{
				this.m_owner.__callBase_InitCardPoolConfigs(cardPools);
			}

			// Token: 0x060076FD RID: 30461 RVA: 0x0020863C File Offset: 0x0020683C
			public int __callBase_IsActivityCardPoolOnActivityTime(int activityCardPoolId)
			{
				return this.m_owner.__callBase_IsActivityCardPoolOnActivityTime(activityCardPoolId);
			}

			// Token: 0x060076FE RID: 30462 RVA: 0x0020864C File Offset: 0x0020684C
			public OperationalActivityBase __callBase_FindOperationalActivityByActivityCardPoolId(int activityCardPoolId)
			{
				return this.m_owner.__callBase_FindOperationalActivityByActivityCardPoolId(activityCardPoolId);
			}

			// Token: 0x060076FF RID: 30463 RVA: 0x0020865C File Offset: 0x0020685C
			public List<int> __callBase_GetAllOpenActivityCardPool()
			{
				return this.m_owner.__callBase_GetAllOpenActivityCardPool();
			}

			// Token: 0x06007700 RID: 30464 RVA: 0x0020866C File Offset: 0x0020686C
			public bool __callBase_IsUsedOutActivityCardPoolSelectOpportunity(CardPool cardPool)
			{
				return this.m_owner.__callBase_IsUsedOutActivityCardPoolSelectOpportunity(cardPool);
			}

			// Token: 0x06007701 RID: 30465 RVA: 0x0020867C File Offset: 0x0020687C
			public CardPool __callBase_GetCardPoolById(int cardPoolId, bool ignoreActivityCheck)
			{
				return this.m_owner.__callBase_GetCardPoolById(cardPoolId, ignoreActivityCheck);
			}

			// Token: 0x06007702 RID: 30466 RVA: 0x0020868C File Offset: 0x0020688C
			public bool __callBase_IsTicketsEnough(int ticketId, int ticketCount)
			{
				return this.m_owner.__callBase_IsTicketsEnough(ticketId, ticketCount);
			}

			// Token: 0x06007703 RID: 30467 RVA: 0x0020869C File Offset: 0x0020689C
			public int __callBase_GetCrystalCount(CardPool cardPool, bool isSingleSelect, out bool isTenSelectDiscount)
			{
				return this.m_owner.__callBase_GetCrystalCount(cardPool, isSingleSelect, out isTenSelectDiscount);
			}

			// Token: 0x06007704 RID: 30468 RVA: 0x002086AC File Offset: 0x002068AC
			public void __callBase_SelectCardUseTickets(CardPool cardPool, bool isSingleSelect)
			{
				this.m_owner.__callBase_SelectCardUseTickets(cardPool, isSingleSelect);
			}

			// Token: 0x06007705 RID: 30469 RVA: 0x002086BC File Offset: 0x002068BC
			public void __callBase_SelectCardUseCrystal(CardPool cardPool, bool isSingleSelect)
			{
				this.m_owner.__callBase_SelectCardUseCrystal(cardPool, isSingleSelect);
			}

			// Token: 0x06007706 RID: 30470 RVA: 0x002086CC File Offset: 0x002068CC
			public int __callBase_CanSelectCard(CardPool cardPool, bool isSingleSelect, bool isUsingTickets)
			{
				return this.m_owner.__callBase_CanSelectCard(cardPool, isSingleSelect, isUsingTickets);
			}

			// Token: 0x06007707 RID: 30471 RVA: 0x002086DC File Offset: 0x002068DC
			public bool __callBase_IsCrystalOrActivityCardPool(CardPoolType cardPoolType)
			{
				return this.m_owner.__callBase_IsCrystalOrActivityCardPool(cardPoolType);
			}

			// Token: 0x06007708 RID: 30472 RVA: 0x002086EC File Offset: 0x002068EC
			public int __callBase_CanUseTicketSelectCard(CardPool cardPool, int ticketNums)
			{
				return this.m_owner.__callBase_CanUseTicketSelectCard(cardPool, ticketNums);
			}

			// Token: 0x06007709 RID: 30473 RVA: 0x002086FC File Offset: 0x002068FC
			public void __callBase_SelectCardSpendTicketsOrCrystal(CardPool cardPool, bool isSingleSelect, bool isUsingTickets)
			{
				this.m_owner.__callBase_SelectCardSpendTicketsOrCrystal(cardPool, isSingleSelect, isUsingTickets);
			}

			// Token: 0x0600770A RID: 30474 RVA: 0x0020870C File Offset: 0x0020690C
			public void __callBase_SelectHeroCard(int heroId)
			{
				this.m_owner.__callBase_SelectHeroCard(heroId);
			}

			// Token: 0x0400563B RID: 22075
			private SelectCardComponent m_owner;
		}
	}
}
