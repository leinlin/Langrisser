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
	// Token: 0x020008D5 RID: 2261
	[HotFix]
	public class PlayerBasicInfoComponent : PlayerBasicInfoComponentCommon
	{
		// Token: 0x06007483 RID: 29827 RVA: 0x002015E8 File Offset: 0x001FF7E8
		public PlayerBasicInfoComponent()
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

		// Token: 0x06007484 RID: 29828 RVA: 0x00201650 File Offset: 0x001FF850
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
			this.m_playerContext = (base.Owner as ProjectLPlayerContext);
			this.m_configDataLoader = (GameManager.Instance.ConfigDataLoader as IConfigDataLoader);
			base.Init();
		}

		// Token: 0x06007485 RID: 29829 RVA: 0x002016DC File Offset: 0x001FF8DC
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

		// Token: 0x06007486 RID: 29830 RVA: 0x00201744 File Offset: 0x001FF944
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

		// Token: 0x06007487 RID: 29831 RVA: 0x002017AC File Offset: 0x001FF9AC
		public override DateTime GetCurrentTime()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetCurrentTime_hotfix != null)
			{
				return (DateTime)this.m_GetCurrentTime_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_playerContext.GetServerTime();
		}

		// Token: 0x06007488 RID: 29832 RVA: 0x00201824 File Offset: 0x001FFA24
		public void DeSerialize(PlayerInfoInitAck msg)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DeSerializePlayerInfoInitAck_hotfix != null)
			{
				this.m_DeSerializePlayerInfoInitAck_hotfix.call(new object[]
				{
					this,
					msg
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (string.IsNullOrEmpty(msg.CharactorNickName))
			{
				this.m_playerBasicDS.PlayerName = string.Empty;
			}
			else
			{
				this.m_playerBasicDS.PlayerName = msg.CharactorNickName;
			}
			if (string.IsNullOrEmpty(msg.GameUserId))
			{
				this.m_playerBasicDS.UserId = string.Empty;
			}
			else
			{
				this.m_playerBasicDS.UserId = msg.GameUserId;
			}
			this.m_playerContext.SetNeedBattleReportLog(msg.IsNeedBattleReportLog);
		}

		// Token: 0x06007489 RID: 29833 RVA: 0x00201914 File Offset: 0x001FFB14
		public void DeSerialize(DSPlayerBasicNtf msg)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DeSerializeDSPlayerBasicNtf_hotfix != null)
			{
				this.m_DeSerializeDSPlayerBasicNtf_hotfix.call(new object[]
				{
					this,
					msg
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_playerBasicDS.ClearInitedData();
			this.m_playerBasicDS.PlayerLevel = msg.PlayerLevel;
			this.m_playerBasicDS.RechargeCrystal = (int)msg.RechargeCsystal;
			this.m_playerBasicDS.RechargeRMB = msg.RechargeRMB;
			this.m_playerBasicDS.Exp = msg.ExpCurr;
			this.m_playerBasicDS.Energy = msg.Energy;
			this.m_playerBasicDS.Gold = (int)msg.Gold;
			this.m_playerBasicDS.Crystal = (int)msg.Crystal;
			this.m_playerBasicDS.LastSignTime = new DateTime(msg.LastSignTime);
			this.m_playerBasicDS.SignDays = msg.SignDays;
			this.m_playerBasicDS.HeadIcon = msg.HeadIcon;
			this.m_playerBasicDS.BuyEngryNums = msg.BuyEngryNums;
			this.m_playerBasicDS.NextFlushPlayerActionTime = new DateTime(msg.PlayerActionNextFlushTime);
			this.m_playerBasicDS.ArenaTickets = msg.ArenaTickets;
			this.m_playerBasicDS.ArenaHonour = msg.ArenaHonour;
			List<int> bits = this.m_playerBasicDS.GuideCompleteFlags.Bits;
			bits.Clear();
			bits.AddRange(msg.GuideCompleteFlags);
			this.m_playerBasicDS.EnergyFlushTime = new DateTime(msg.EnergyFlushTime);
			this.m_playerBasicDS.CreateTime = new DateTime(msg.CreateTime);
			this.m_playerBasicDS.CreateTimeUtc = this.m_playerBasicDS.CreateTime.ToUniversalTime();
			this.m_playerBasicDS.BuyArenaTicketsNums = msg.BuyArenaTicketsNums;
			this.m_playerBasicDS.FriendshipPoints = msg.FriendshipPoints;
			this.m_playerBasicDS.SkinTickets = msg.SkinTickets;
			this.m_playerBasicDS.MemoryEssence = msg.MemoryEssence;
			this.m_playerBasicDS.BrillianceMithralStone = msg.BrillianceMithralStone;
			this.m_playerBasicDS.MithralStone = msg.MithralStone;
			this.m_vipLevel = msg.VipLevel;
			this.m_playerBasicDS.GuildMedal = msg.GuildMedal;
			this.m_playerBasicDS.MemoryStoreOpen = msg.MemoryStoreOpen;
			this.m_playerBasicDS.InitVersion((ushort)msg.Version, (ushort)msg.Version);
			Debug.Log(string.Format("PlayerBasicInfoComponent::DSPlayerBasicNtf has crystal {0}", this.m_playerBasicDS.Crystal));
			Debug.Log(string.Format("PlayerBasicInfoComponent::DeSerialize current energy is {0}", this.m_playerBasicDS.Energy));
		}

		// Token: 0x0600748A RID: 29834 RVA: 0x00201BE0 File Offset: 0x001FFDE0
		public void EveryDaySign(int signDays, long lastSignTime)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_EveryDaySignInt32Int64_hotfix != null)
			{
				this.m_EveryDaySignInt32Int64_hotfix.call(new object[]
				{
					this,
					signDays,
					lastSignTime
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_playerBasicDS.SetSignDays(signDays);
			this.m_playerBasicDS.SetLastSignTime(new DateTime(lastSignTime));
		}

		// Token: 0x0600748B RID: 29835 RVA: 0x00201C80 File Offset: 0x001FFE80
		public override int CheckPlayerName(string name)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CheckPlayerNameString_hotfix != null)
			{
				return Convert.ToInt32(this.m_CheckPlayerNameString_hotfix.call(new object[]
				{
					this,
					name
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = base.CheckPlayerName(name);
			if (num != 0)
			{
				return num;
			}
			if (name.Length > this.m_configDataLoader.ConfigableConstId_PlayerNameMaxLength)
			{
				return -4;
			}
			return 0;
		}

		// Token: 0x0600748C RID: 29836 RVA: 0x00201D28 File Offset: 0x001FFF28
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
			return this.m_playerBasicDS.ClientVersion;
		}

		// Token: 0x0600748D RID: 29837 RVA: 0x00201DA0 File Offset: 0x001FFFA0
		public DataSectionPlayerBasicInfo GetPlayerBasicInfo()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetPlayerBasicInfo_hotfix != null)
			{
				return (DataSectionPlayerBasicInfo)this.m_GetPlayerBasicInfo_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_playerBasicDS;
		}

		// Token: 0x0600748E RID: 29838 RVA: 0x00201E14 File Offset: 0x00200014
		public DateTime GetEnergyReachMaxTime()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetEnergyReachMaxTime_hotfix != null)
			{
				return (DateTime)this.m_GetEnergyReachMaxTime_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (base.IsReachEnergyMax((long)this.m_playerBasicDS.Energy))
			{
				return DateTime.MinValue;
			}
			int num = this.m_configDataLoader.ConfigableConstId_EnergyMax - this.m_playerBasicDS.Energy;
			return this.m_playerBasicDS.EnergyFlushTime.AddSeconds((double)(num * this.m_configDataLoader.ConfigableConstId_EnergyAddPeriod));
		}

		// Token: 0x0600748F RID: 29839 RVA: 0x00201ED4 File Offset: 0x002000D4
		public override int DecreaseEnergy(int energyCost, GameFunctionType causeId = GameFunctionType.GameFunctionType_None, string location = null)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DecreaseEnergyInt32GameFunctionTypeString_hotfix != null)
			{
				return Convert.ToInt32(this.m_DecreaseEnergyInt32GameFunctionTypeString_hotfix.call(new object[]
				{
					this,
					energyCost,
					causeId,
					location
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = base.DecreaseEnergy(energyCost, causeId, location);
			Debug.Log(string.Format("PlayerBasicInfoComponent::DecreaseEnergy decrease {0} energy on {1} function by {2}, current energy is {3}", new object[]
			{
				energyCost,
				causeId,
				location,
				num
			}));
			this.m_playerContext.ResetPushNotification();
			return num;
		}

		// Token: 0x06007490 RID: 29840 RVA: 0x00201FBC File Offset: 0x002001BC
		public override int IncreamentEnergy(long energyAddNums, bool canAboveMaxEnergy, GameFunctionType causeId = GameFunctionType.GameFunctionType_None, string location = null)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IncreamentEnergyInt64BooleanGameFunctionTypeString_hotfix != null)
			{
				return Convert.ToInt32(this.m_IncreamentEnergyInt64BooleanGameFunctionTypeString_hotfix.call(new object[]
				{
					this,
					energyAddNums,
					canAboveMaxEnergy,
					causeId,
					location
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = base.IncreamentEnergy(energyAddNums, canAboveMaxEnergy, causeId, location);
			Debug.Log(string.Format("PlayerBasicInfoComponent::IncreamentEnergy increase {0} energy on {1} function by {2}, current energy is {3}", new object[]
			{
				energyAddNums,
				causeId,
				location,
				num
			}));
			if (canAboveMaxEnergy)
			{
				this.m_playerContext.ResetPushNotification();
			}
			return num;
		}

		// Token: 0x06007491 RID: 29841 RVA: 0x002020BC File Offset: 0x002002BC
		public override int AddArenaTickets(int nums, bool arenaGiven = true, GameFunctionType causeId = GameFunctionType.GameFunctionType_None, string location = null)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddArenaTicketsInt32BooleanGameFunctionTypeString_hotfix != null)
			{
				return Convert.ToInt32(this.m_AddArenaTicketsInt32BooleanGameFunctionTypeString_hotfix.call(new object[]
				{
					this,
					nums,
					arenaGiven,
					causeId,
					location
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			bool flag = base.IsArenaTicketsFull();
			int num = base.AddArenaTickets(nums, arenaGiven, causeId, location);
			Debug.Log(string.Format("PlayerBasicInfoComponent::AddArenaTickets increase {0} ticket on {1} function by {2}, current tickets is {3}", new object[]
			{
				nums,
				causeId,
				location,
				num
			}));
			if (!arenaGiven && flag != base.IsArenaTicketsFull())
			{
				this.m_playerContext.ResetPushNotification();
			}
			return num;
		}

		// Token: 0x06007492 RID: 29842 RVA: 0x002021D0 File Offset: 0x002003D0
		protected override void OnLevelChange(int upLevel, int addExp)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnLevelChangeInt32Int32_hotfix != null)
			{
				this.m_OnLevelChangeInt32Int32_hotfix.call(new object[]
				{
					this,
					upLevel,
					addExp
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.OnLevelChange(upLevel, addExp);
			Debug.Log(string.Format("add exp = {0}, current player Level = {0} exp = {1}", addExp, this.m_playerBasicDS.PlayerLevel, this.m_playerBasicDS.Exp));
		}

		// Token: 0x17001BD9 RID: 7129
		// (get) Token: 0x06007493 RID: 29843 RVA: 0x00202290 File Offset: 0x00200490
		// (set) Token: 0x06007494 RID: 29844 RVA: 0x002022B0 File Offset: 0x002004B0
		[DoNotToLua]
		public new PlayerBasicInfoComponent.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new PlayerBasicInfoComponent.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06007495 RID: 29845 RVA: 0x002022BC File Offset: 0x002004BC
		private string __callBase_GetName()
		{
			return base.GetName();
		}

		// Token: 0x06007496 RID: 29846 RVA: 0x002022C4 File Offset: 0x002004C4
		private void __callBase_Init()
		{
			base.Init();
		}

		// Token: 0x06007497 RID: 29847 RVA: 0x002022CC File Offset: 0x002004CC
		private void __callBase_PostInit()
		{
			base.PostInit();
		}

		// Token: 0x06007498 RID: 29848 RVA: 0x002022D4 File Offset: 0x002004D4
		private void __callBase_DeInit()
		{
			base.DeInit();
		}

		// Token: 0x06007499 RID: 29849 RVA: 0x002022DC File Offset: 0x002004DC
		private void __callBase_Tick(uint deltaMillisecond)
		{
			base.Tick(deltaMillisecond);
		}

		// Token: 0x0600749A RID: 29850 RVA: 0x002022E8 File Offset: 0x002004E8
		private void __callBase_PostDeSerialize()
		{
			base.PostDeSerialize();
		}

		// Token: 0x0600749B RID: 29851 RVA: 0x002022F0 File Offset: 0x002004F0
		private void __callBase_TryUpdateSignedDays()
		{
			base.TryUpdateSignedDays();
		}

		// Token: 0x0600749C RID: 29852 RVA: 0x002022F8 File Offset: 0x002004F8
		private bool __callBase_IsGameFunctionOpened(GameFunctionType gameFunctionType)
		{
			return base.IsGameFunctionOpened(gameFunctionType);
		}

		// Token: 0x0600749D RID: 29853 RVA: 0x00202304 File Offset: 0x00200504
		private DateTime __callBase_GetCreateTime()
		{
			return base.GetCreateTime();
		}

		// Token: 0x0600749E RID: 29854 RVA: 0x0020230C File Offset: 0x0020050C
		private DateTime __callBase_GetCreateTimeUtc()
		{
			return base.GetCreateTimeUtc();
		}

		// Token: 0x0600749F RID: 29855 RVA: 0x00202314 File Offset: 0x00200514
		private DateTime __callBase_GetLastLogoutTime()
		{
			return base.GetLastLogoutTime();
		}

		// Token: 0x060074A0 RID: 29856 RVA: 0x0020231C File Offset: 0x0020051C
		private DateTime __callBase_GetLoginTime()
		{
			return base.GetLoginTime();
		}

		// Token: 0x060074A1 RID: 29857 RVA: 0x00202324 File Offset: 0x00200524
		private string __callBase_GetPlayerName()
		{
			return base.GetPlayerName();
		}

		// Token: 0x060074A2 RID: 29858 RVA: 0x0020232C File Offset: 0x0020052C
		private string __callBase_GetUserId()
		{
			return base.GetUserId();
		}

		// Token: 0x060074A3 RID: 29859 RVA: 0x00202334 File Offset: 0x00200534
		private bool __callBase_IsMe(string userId)
		{
			return base.IsMe(userId);
		}

		// Token: 0x060074A4 RID: 29860 RVA: 0x00202340 File Offset: 0x00200540
		private int __callBase_GetCurrentLevelExp()
		{
			return base.GetCurrentLevelExp();
		}

		// Token: 0x060074A5 RID: 29861 RVA: 0x00202348 File Offset: 0x00200548
		private int __callBase_GetRechargedCsystal()
		{
			return base.GetRechargedCsystal();
		}

		// Token: 0x060074A6 RID: 29862 RVA: 0x00202350 File Offset: 0x00200550
		private long __callBase_GetRechargeRMB()
		{
			return base.GetRechargeRMB();
		}

		// Token: 0x060074A7 RID: 29863 RVA: 0x00202358 File Offset: 0x00200558
		private int __callBase_GetHeadIcon()
		{
			return base.GetHeadIcon();
		}

		// Token: 0x060074A8 RID: 29864 RVA: 0x00202360 File Offset: 0x00200560
		private int __callBase_GetDefaultHeadIcon()
		{
			return base.GetDefaultHeadIcon();
		}

		// Token: 0x060074A9 RID: 29865 RVA: 0x00202368 File Offset: 0x00200568
		private int __callBase_GetHeadPortrait()
		{
			return base.GetHeadPortrait();
		}

		// Token: 0x060074AA RID: 29866 RVA: 0x00202370 File Offset: 0x00200570
		private int __callBase_GetHeadFrame()
		{
			return base.GetHeadFrame();
		}

		// Token: 0x060074AB RID: 29867 RVA: 0x00202378 File Offset: 0x00200578
		private bool __callBase_IsPlayerLevelMax()
		{
			return base.IsPlayerLevelMax();
		}

		// Token: 0x060074AC RID: 29868 RVA: 0x00202380 File Offset: 0x00200580
		private int __callBase_AddPlayerExp(int exp)
		{
			return base.AddPlayerExp(exp);
		}

		// Token: 0x060074AD RID: 29869 RVA: 0x0020238C File Offset: 0x0020058C
		private void __callBase_OnLevelChange(int upLevel, int addExp)
		{
			base.OnLevelChange(upLevel, addExp);
		}

		// Token: 0x060074AE RID: 29870 RVA: 0x00202398 File Offset: 0x00200598
		private int __callBase_AddGold(int nums, GameFunctionType causeId, string location)
		{
			return base.AddGold(nums, causeId, location);
		}

		// Token: 0x060074AF RID: 29871 RVA: 0x002023A4 File Offset: 0x002005A4
		private bool __callBase_IsGoldEnough(int useGoldCount)
		{
			return base.IsGoldEnough(useGoldCount);
		}

		// Token: 0x060074B0 RID: 29872 RVA: 0x002023B0 File Offset: 0x002005B0
		private bool __callBase_IsGoldOverFlow(int addNums)
		{
			return base.IsGoldOverFlow(addNums);
		}

		// Token: 0x060074B1 RID: 29873 RVA: 0x002023BC File Offset: 0x002005BC
		private int __callBase_GetGold()
		{
			return base.GetGold();
		}

		// Token: 0x060074B2 RID: 29874 RVA: 0x002023C4 File Offset: 0x002005C4
		private int __callBase_AddBrillianceMithralStone(int nums)
		{
			return base.AddBrillianceMithralStone(nums);
		}

		// Token: 0x060074B3 RID: 29875 RVA: 0x002023D0 File Offset: 0x002005D0
		private int __callBase_AddMithralStone(int nums)
		{
			return base.AddMithralStone(nums);
		}

		// Token: 0x060074B4 RID: 29876 RVA: 0x002023DC File Offset: 0x002005DC
		private bool __callBase_IsMithralStoneEnough(int nums)
		{
			return base.IsMithralStoneEnough(nums);
		}

		// Token: 0x060074B5 RID: 29877 RVA: 0x002023E8 File Offset: 0x002005E8
		private bool __callBase_IsBrillianceMithralStoneEnough(int nums)
		{
			return base.IsBrillianceMithralStoneEnough(nums);
		}

		// Token: 0x060074B6 RID: 29878 RVA: 0x002023F4 File Offset: 0x002005F4
		private int __callBase_IsCurrencyEnough(GoodsType currencyType, int consumeNums)
		{
			return base.IsCurrencyEnough(currencyType, consumeNums);
		}

		// Token: 0x060074B7 RID: 29879 RVA: 0x00202400 File Offset: 0x00200600
		private int __callBase_AddCurrency(GoodsType currencyType, int nums, GameFunctionType causeId, string location)
		{
			return base.AddCurrency(currencyType, nums, causeId, location);
		}

		// Token: 0x060074B8 RID: 29880 RVA: 0x00202410 File Offset: 0x00200610
		private long __callBase_AddRechargeRMB(int nums, DateTime rechargeTime, bool needSync2Client)
		{
			return base.AddRechargeRMB(nums, rechargeTime, needSync2Client);
		}

		// Token: 0x060074B9 RID: 29881 RVA: 0x0020241C File Offset: 0x0020061C
		private int __callBase_AddCrystal(int nums, GameFunctionType causeId, string location)
		{
			return base.AddCrystal(nums, causeId, location);
		}

		// Token: 0x060074BA RID: 29882 RVA: 0x00202428 File Offset: 0x00200628
		private bool __callBase_IsCrystalEnough(int consumeNums)
		{
			return base.IsCrystalEnough(consumeNums);
		}

		// Token: 0x060074BB RID: 29883 RVA: 0x00202434 File Offset: 0x00200634
		private void __callBase_InitEnergy(long secondPast)
		{
			base.InitEnergy(secondPast);
		}

		// Token: 0x060074BC RID: 29884 RVA: 0x00202440 File Offset: 0x00200640
		private bool __callBase_IsReachEnergyMax(long currentEnergy)
		{
			return base.IsReachEnergyMax(currentEnergy);
		}

		// Token: 0x060074BD RID: 29885 RVA: 0x0020244C File Offset: 0x0020064C
		private void __callBase_FlushEnergy()
		{
			base.FlushEnergy();
		}

		// Token: 0x060074BE RID: 29886 RVA: 0x00202454 File Offset: 0x00200654
		private bool __callBase_CanFlushEnergy()
		{
			return base.CanFlushEnergy();
		}

		// Token: 0x060074BF RID: 29887 RVA: 0x0020245C File Offset: 0x0020065C
		private bool __callBase_CanFlushPlayerAction()
		{
			return base.CanFlushPlayerAction();
		}

		// Token: 0x060074C0 RID: 29888 RVA: 0x00202464 File Offset: 0x00200664
		private void __callBase_ResetPlayerActionNextFlushTime()
		{
			base.ResetPlayerActionNextFlushTime();
		}

		// Token: 0x060074C1 RID: 29889 RVA: 0x0020246C File Offset: 0x0020066C
		private int __callBase_IncreamentEnergy(long energyAddNums, bool canAboveMaxEnergy, GameFunctionType causeId, string location)
		{
			return base.IncreamentEnergy(energyAddNums, canAboveMaxEnergy, causeId, location);
		}

		// Token: 0x060074C2 RID: 29890 RVA: 0x0020247C File Offset: 0x0020067C
		private int __callBase_DecreaseEnergy(int energyCost, GameFunctionType causeId, string location)
		{
			return base.DecreaseEnergy(energyCost, causeId, location);
		}

		// Token: 0x060074C3 RID: 29891 RVA: 0x00202488 File Offset: 0x00200688
		private bool __callBase_IsEnergyEnough(int consumeEnergy)
		{
			return base.IsEnergyEnough(consumeEnergy);
		}

		// Token: 0x060074C4 RID: 29892 RVA: 0x00202494 File Offset: 0x00200694
		private int __callBase_GetEnergy()
		{
			return base.GetEnergy();
		}

		// Token: 0x060074C5 RID: 29893 RVA: 0x0020249C File Offset: 0x0020069C
		private DateTime __callBase_GetCurrentTime()
		{
			return base.GetCurrentTime();
		}

		// Token: 0x060074C6 RID: 29894 RVA: 0x002024A4 File Offset: 0x002006A4
		private bool __callBase_IsSigned()
		{
			return base.IsSigned();
		}

		// Token: 0x060074C7 RID: 29895 RVA: 0x002024AC File Offset: 0x002006AC
		private int __callBase_CanSignToday()
		{
			return base.CanSignToday();
		}

		// Token: 0x060074C8 RID: 29896 RVA: 0x002024B4 File Offset: 0x002006B4
		private int __callBase_CanBuyEnergy()
		{
			return base.CanBuyEnergy();
		}

		// Token: 0x060074C9 RID: 29897 RVA: 0x002024BC File Offset: 0x002006BC
		private int __callBase_BuyEnergy()
		{
			return base.BuyEnergy();
		}

		// Token: 0x060074CA RID: 29898 RVA: 0x002024C4 File Offset: 0x002006C4
		private int __callBase_CanBuyArenaTickets()
		{
			return base.CanBuyArenaTickets();
		}

		// Token: 0x060074CB RID: 29899 RVA: 0x002024CC File Offset: 0x002006CC
		private int __callBase_BuyArenaTickets()
		{
			return base.BuyArenaTickets();
		}

		// Token: 0x060074CC RID: 29900 RVA: 0x002024D4 File Offset: 0x002006D4
		private DateTime __callBase_GetNextFlushPlayerActionTime()
		{
			return base.GetNextFlushPlayerActionTime();
		}

		// Token: 0x060074CD RID: 29901 RVA: 0x002024DC File Offset: 0x002006DC
		private bool __callBase_FlushPlayerAction()
		{
			return base.FlushPlayerAction();
		}

		// Token: 0x060074CE RID: 29902 RVA: 0x002024E4 File Offset: 0x002006E4
		private void __callBase_OnPlayerActionFlushEvent()
		{
			base.OnPlayerActionFlushEvent();
		}

		// Token: 0x060074CF RID: 29903 RVA: 0x002024EC File Offset: 0x002006EC
		private bool __callBase_IsArenaTicketsEnough(int consumeNums)
		{
			return base.IsArenaTicketsEnough(consumeNums);
		}

		// Token: 0x060074D0 RID: 29904 RVA: 0x002024F8 File Offset: 0x002006F8
		private bool __callBase_IsArenaTicketsFull()
		{
			return base.IsArenaTicketsFull();
		}

		// Token: 0x060074D1 RID: 29905 RVA: 0x00202500 File Offset: 0x00200700
		private int __callBase_AddArenaTickets(int nums, bool arenaGiven, GameFunctionType causeId, string location)
		{
			return base.AddArenaTickets(nums, arenaGiven, causeId, location);
		}

		// Token: 0x060074D2 RID: 29906 RVA: 0x00202510 File Offset: 0x00200710
		private int __callBase_GetAreanaTicketNums()
		{
			return base.GetAreanaTicketNums();
		}

		// Token: 0x060074D3 RID: 29907 RVA: 0x00202518 File Offset: 0x00200718
		private int __callBase_AddRechargedCrystal(int nums)
		{
			return base.AddRechargedCrystal(nums);
		}

		// Token: 0x060074D4 RID: 29908 RVA: 0x00202524 File Offset: 0x00200724
		private int __callBase_AddArenaHonour(int nums, GameFunctionType causeId, string location)
		{
			return base.AddArenaHonour(nums, causeId, location);
		}

		// Token: 0x060074D5 RID: 29909 RVA: 0x00202530 File Offset: 0x00200730
		private int __callBase_GetArenaHonour()
		{
			return base.GetArenaHonour();
		}

		// Token: 0x060074D6 RID: 29910 RVA: 0x00202538 File Offset: 0x00200738
		private int __callBase_AddRealTimePVPHonor(int nums, GameFunctionType causeId, string location)
		{
			return base.AddRealTimePVPHonor(nums, causeId, location);
		}

		// Token: 0x060074D7 RID: 29911 RVA: 0x00202544 File Offset: 0x00200744
		private int __callBase_GetRealTimePVPHonor()
		{
			return base.GetRealTimePVPHonor();
		}

		// Token: 0x060074D8 RID: 29912 RVA: 0x0020254C File Offset: 0x0020074C
		private int __callBase_GetFriendshipPoints()
		{
			return base.GetFriendshipPoints();
		}

		// Token: 0x060074D9 RID: 29913 RVA: 0x00202554 File Offset: 0x00200754
		private int __callBase_GetSkinTickets()
		{
			return base.GetSkinTickets();
		}

		// Token: 0x060074DA RID: 29914 RVA: 0x0020255C File Offset: 0x0020075C
		private int __callBase_AddFriendshipPoints(int nums, GameFunctionType causeId, string location)
		{
			return base.AddFriendshipPoints(nums, causeId, location);
		}

		// Token: 0x060074DB RID: 29915 RVA: 0x00202568 File Offset: 0x00200768
		private int __callBase_AddSkinTickets(int nums, GameFunctionType causeId, string location)
		{
			return base.AddSkinTickets(nums, causeId, location);
		}

		// Token: 0x060074DC RID: 29916 RVA: 0x00202574 File Offset: 0x00200774
		private int __callBase_AddMemoryEssence(int nums, GameFunctionType causeId, string location)
		{
			return base.AddMemoryEssence(nums, causeId, location);
		}

		// Token: 0x060074DD RID: 29917 RVA: 0x00202580 File Offset: 0x00200780
		private int __callBase_AddBrillianceMithralStone(int nums, GameFunctionType causeId, string location)
		{
			return base.AddBrillianceMithralStone(nums, causeId, location);
		}

		// Token: 0x060074DE RID: 29918 RVA: 0x0020258C File Offset: 0x0020078C
		private int __callBase_AddMithralStone(int nums, GameFunctionType causeId, string location)
		{
			return base.AddMithralStone(nums, causeId, location);
		}

		// Token: 0x060074DF RID: 29919 RVA: 0x00202598 File Offset: 0x00200798
		private int __callBase_AddGuildMedal(int nums, GameFunctionType causeId, string location)
		{
			return base.AddGuildMedal(nums, causeId, location);
		}

		// Token: 0x060074E0 RID: 29920 RVA: 0x002025A4 File Offset: 0x002007A4
		private bool __callBase_IsGuildMedalEnough(int consumeNums)
		{
			return base.IsGuildMedalEnough(consumeNums);
		}

		// Token: 0x060074E1 RID: 29921 RVA: 0x002025B0 File Offset: 0x002007B0
		private bool __callBase_IsFriendshipPointsEnough(int consumeNums)
		{
			return base.IsFriendshipPointsEnough(consumeNums);
		}

		// Token: 0x060074E2 RID: 29922 RVA: 0x002025BC File Offset: 0x002007BC
		private bool __callBase_IsArenaHonourEnough(int consumeNums)
		{
			return base.IsArenaHonourEnough(consumeNums);
		}

		// Token: 0x060074E3 RID: 29923 RVA: 0x002025C8 File Offset: 0x002007C8
		private bool __callBase_IsRealTimePVPHonorEnough(int consumeNums)
		{
			return base.IsRealTimePVPHonorEnough(consumeNums);
		}

		// Token: 0x060074E4 RID: 29924 RVA: 0x002025D4 File Offset: 0x002007D4
		private bool __callBase_IsSkinTicketEnough(int consumeNums)
		{
			return base.IsSkinTicketEnough(consumeNums);
		}

		// Token: 0x060074E5 RID: 29925 RVA: 0x002025E0 File Offset: 0x002007E0
		private bool __callBase_IsMemoryEssenceEnough(int consumeNums)
		{
			return base.IsMemoryEssenceEnough(consumeNums);
		}

		// Token: 0x060074E6 RID: 29926 RVA: 0x002025EC File Offset: 0x002007EC
		private int __callBase_CanSetUserGuide(List<int> completeStepIds)
		{
			return base.CanSetUserGuide(completeStepIds);
		}

		// Token: 0x060074E7 RID: 29927 RVA: 0x002025F8 File Offset: 0x002007F8
		private int __callBase_SetUserGuide(List<int> completeStepIds)
		{
			return base.SetUserGuide(completeStepIds);
		}

		// Token: 0x060074E8 RID: 29928 RVA: 0x00202604 File Offset: 0x00200804
		private void __callBase_CleanUserGuide(List<int> completeStepIds)
		{
			base.CleanUserGuide(completeStepIds);
		}

		// Token: 0x060074E9 RID: 29929 RVA: 0x00202610 File Offset: 0x00200810
		private void __callBase_CompleteAllUserGuides()
		{
			base.CompleteAllUserGuides();
		}

		// Token: 0x060074EA RID: 29930 RVA: 0x00202618 File Offset: 0x00200818
		private bool __callBase_IsUserGuideCompleted(int stepId)
		{
			return base.IsUserGuideCompleted(stepId);
		}

		// Token: 0x060074EB RID: 29931 RVA: 0x00202624 File Offset: 0x00200824
		private int __callBase_GetLevel()
		{
			return base.GetLevel();
		}

		// Token: 0x060074EC RID: 29932 RVA: 0x0020262C File Offset: 0x0020082C
		private int __callBase_GetRechargedCrystal()
		{
			return base.GetRechargedCrystal();
		}

		// Token: 0x060074ED RID: 29933 RVA: 0x00202634 File Offset: 0x00200834
		private int __callBase_GetCrystal()
		{
			return base.GetCrystal();
		}

		// Token: 0x060074EE RID: 29934 RVA: 0x0020263C File Offset: 0x0020083C
		private bool __callBase_CheckRankingListAddPlayerLevel()
		{
			return base.CheckRankingListAddPlayerLevel();
		}

		// Token: 0x060074EF RID: 29935 RVA: 0x00202644 File Offset: 0x00200844
		private RankingPlayerInfo __callBase_CreateRankingPlayerInfo(int championHeroId)
		{
			return base.CreateRankingPlayerInfo(championHeroId);
		}

		// Token: 0x060074F0 RID: 29936 RVA: 0x00202650 File Offset: 0x00200850
		private void __callBase_OnRankingListPlayerInfoChange()
		{
			base.OnRankingListPlayerInfoChange();
		}

		// Token: 0x060074F1 RID: 29937 RVA: 0x00202658 File Offset: 0x00200858
		private void __callBase_OpenGameRating()
		{
			base.OpenGameRating();
		}

		// Token: 0x060074F2 RID: 29938 RVA: 0x00202660 File Offset: 0x00200860
		private bool __callBase_IsOpenGameRating()
		{
			return base.IsOpenGameRating();
		}

		// Token: 0x060074F3 RID: 29939 RVA: 0x00202668 File Offset: 0x00200868
		private void __callBase_SetMemoryStoreOpenStatus(bool open)
		{
			base.SetMemoryStoreOpenStatus(open);
		}

		// Token: 0x060074F4 RID: 29940 RVA: 0x00202674 File Offset: 0x00200874
		private bool __callBase_IsMemoryStoreOpen()
		{
			return base.IsMemoryStoreOpen();
		}

		// Token: 0x060074F5 RID: 29941 RVA: 0x0020267C File Offset: 0x0020087C
		private int __callBase_GetLevelUpAddEnergyFromConfig()
		{
			return base.GetLevelUpAddEnergyFromConfig();
		}

		// Token: 0x060074F6 RID: 29942 RVA: 0x00202684 File Offset: 0x00200884
		private int __callBase_GetNextLevelExpFromConfig()
		{
			return base.GetNextLevelExpFromConfig();
		}

		// Token: 0x060074F7 RID: 29943 RVA: 0x0020268C File Offset: 0x0020088C
		private int __callBase_CanSetHeadPortraitAndHeadFrame(int headPortraitId, int headFrameId)
		{
			return base.CanSetHeadPortraitAndHeadFrame(headPortraitId, headFrameId);
		}

		// Token: 0x060074F8 RID: 29944 RVA: 0x00202698 File Offset: 0x00200898
		private int __callBase_SetHeadPortraitAndHeadFrame(int headPortraitId, int headFrameId)
		{
			return base.SetHeadPortraitAndHeadFrame(headPortraitId, headFrameId);
		}

		// Token: 0x060074F9 RID: 29945 RVA: 0x002026A4 File Offset: 0x002008A4
		private int __callBase_CanSetHeadPortrait(int headPortraitId)
		{
			return base.CanSetHeadPortrait(headPortraitId);
		}

		// Token: 0x060074FA RID: 29946 RVA: 0x002026B0 File Offset: 0x002008B0
		private int __callBase_SetHeadPortrait(int headPortraitId)
		{
			return base.SetHeadPortrait(headPortraitId);
		}

		// Token: 0x060074FB RID: 29947 RVA: 0x002026BC File Offset: 0x002008BC
		private int __callBase_CanSetHeadFrame(int headFrameId)
		{
			return base.CanSetHeadFrame(headFrameId);
		}

		// Token: 0x060074FC RID: 29948 RVA: 0x002026C8 File Offset: 0x002008C8
		private int __callBase_SetHeadFrame(int headFrameId)
		{
			return base.SetHeadFrame(headFrameId);
		}

		// Token: 0x060074FD RID: 29949 RVA: 0x002026D4 File Offset: 0x002008D4
		private void __callBase_OnHeadIconChange()
		{
			base.OnHeadIconChange();
		}

		// Token: 0x060074FE RID: 29950 RVA: 0x002026DC File Offset: 0x002008DC
		private int __callBase_CanChangePlayerName(string newName)
		{
			return base.CanChangePlayerName(newName);
		}

		// Token: 0x060074FF RID: 29951 RVA: 0x002026E8 File Offset: 0x002008E8
		private int __callBase_ChangePlayerName(string newName)
		{
			return base.ChangePlayerName(newName);
		}

		// Token: 0x06007500 RID: 29952 RVA: 0x002026F4 File Offset: 0x002008F4
		private int __callBase_TryChangePlayerName(string newName)
		{
			return base.TryChangePlayerName(newName);
		}

		// Token: 0x06007501 RID: 29953 RVA: 0x00202700 File Offset: 0x00200900
		private int __callBase_CheckPlayerName(string name)
		{
			return base.CheckPlayerName(name);
		}

		// Token: 0x06007502 RID: 29954 RVA: 0x0020270C File Offset: 0x0020090C
		private void __callBase_DoShare()
		{
			base.DoShare();
		}

		// Token: 0x06007503 RID: 29955 RVA: 0x00202714 File Offset: 0x00200914
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
					this.m_GetCurrentTime_hotfix = (luaObj.RawGet("GetCurrentTime") as LuaFunction);
					this.m_DeSerializePlayerInfoInitAck_hotfix = (luaObj.RawGet("DeSerialize") as LuaFunction);
					this.m_DeSerializeDSPlayerBasicNtf_hotfix = (luaObj.RawGet("DeSerialize") as LuaFunction);
					this.m_EveryDaySignInt32Int64_hotfix = (luaObj.RawGet("EveryDaySign") as LuaFunction);
					this.m_CheckPlayerNameString_hotfix = (luaObj.RawGet("CheckPlayerName") as LuaFunction);
					this.m_GetDSVersion_hotfix = (luaObj.RawGet("GetDSVersion") as LuaFunction);
					this.m_GetPlayerBasicInfo_hotfix = (luaObj.RawGet("GetPlayerBasicInfo") as LuaFunction);
					this.m_GetEnergyReachMaxTime_hotfix = (luaObj.RawGet("GetEnergyReachMaxTime") as LuaFunction);
					this.m_DecreaseEnergyInt32GameFunctionTypeString_hotfix = (luaObj.RawGet("DecreaseEnergy") as LuaFunction);
					this.m_IncreamentEnergyInt64BooleanGameFunctionTypeString_hotfix = (luaObj.RawGet("IncreamentEnergy") as LuaFunction);
					this.m_AddArenaTicketsInt32BooleanGameFunctionTypeString_hotfix = (luaObj.RawGet("AddArenaTickets") as LuaFunction);
					this.m_OnLevelChangeInt32Int32_hotfix = (luaObj.RawGet("OnLevelChange") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06007504 RID: 29956 RVA: 0x00202958 File Offset: 0x00200B58
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(PlayerBasicInfoComponent));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040055B5 RID: 21941
		private ProjectLPlayerContext m_playerContext;

		// Token: 0x040055B6 RID: 21942
		public int m_vipLevel;

		// Token: 0x040055B7 RID: 21943
		[DoNotToLua]
		private PlayerBasicInfoComponent.LuaExportHelper luaExportHelper;

		// Token: 0x040055B8 RID: 21944
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040055B9 RID: 21945
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040055BA RID: 21946
		private LuaFunction m_ctor_hotfix;

		// Token: 0x040055BB RID: 21947
		private LuaFunction m_Init_hotfix;

		// Token: 0x040055BC RID: 21948
		private LuaFunction m_PostInit_hotfix;

		// Token: 0x040055BD RID: 21949
		private LuaFunction m_DeInit_hotfix;

		// Token: 0x040055BE RID: 21950
		private LuaFunction m_GetCurrentTime_hotfix;

		// Token: 0x040055BF RID: 21951
		private LuaFunction m_DeSerializePlayerInfoInitAck_hotfix;

		// Token: 0x040055C0 RID: 21952
		private LuaFunction m_DeSerializeDSPlayerBasicNtf_hotfix;

		// Token: 0x040055C1 RID: 21953
		private LuaFunction m_EveryDaySignInt32Int64_hotfix;

		// Token: 0x040055C2 RID: 21954
		private LuaFunction m_CheckPlayerNameString_hotfix;

		// Token: 0x040055C3 RID: 21955
		private LuaFunction m_GetDSVersion_hotfix;

		// Token: 0x040055C4 RID: 21956
		private LuaFunction m_GetPlayerBasicInfo_hotfix;

		// Token: 0x040055C5 RID: 21957
		private LuaFunction m_GetEnergyReachMaxTime_hotfix;

		// Token: 0x040055C6 RID: 21958
		private LuaFunction m_DecreaseEnergyInt32GameFunctionTypeString_hotfix;

		// Token: 0x040055C7 RID: 21959
		private LuaFunction m_IncreamentEnergyInt64BooleanGameFunctionTypeString_hotfix;

		// Token: 0x040055C8 RID: 21960
		private LuaFunction m_AddArenaTicketsInt32BooleanGameFunctionTypeString_hotfix;

		// Token: 0x040055C9 RID: 21961
		private LuaFunction m_OnLevelChangeInt32Int32_hotfix;

		// Token: 0x020008D6 RID: 2262
		public new class LuaExportHelper
		{
			// Token: 0x06007505 RID: 29957 RVA: 0x002029C0 File Offset: 0x00200BC0
			public LuaExportHelper(PlayerBasicInfoComponent owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06007506 RID: 29958 RVA: 0x002029D0 File Offset: 0x00200BD0
			public string __callBase_GetName()
			{
				return this.m_owner.__callBase_GetName();
			}

			// Token: 0x06007507 RID: 29959 RVA: 0x002029E0 File Offset: 0x00200BE0
			public void __callBase_Init()
			{
				this.m_owner.__callBase_Init();
			}

			// Token: 0x06007508 RID: 29960 RVA: 0x002029F0 File Offset: 0x00200BF0
			public void __callBase_PostInit()
			{
				this.m_owner.__callBase_PostInit();
			}

			// Token: 0x06007509 RID: 29961 RVA: 0x00202A00 File Offset: 0x00200C00
			public void __callBase_DeInit()
			{
				this.m_owner.__callBase_DeInit();
			}

			// Token: 0x0600750A RID: 29962 RVA: 0x00202A10 File Offset: 0x00200C10
			public void __callBase_Tick(uint deltaMillisecond)
			{
				this.m_owner.__callBase_Tick(deltaMillisecond);
			}

			// Token: 0x0600750B RID: 29963 RVA: 0x00202A20 File Offset: 0x00200C20
			public void __callBase_PostDeSerialize()
			{
				this.m_owner.__callBase_PostDeSerialize();
			}

			// Token: 0x0600750C RID: 29964 RVA: 0x00202A30 File Offset: 0x00200C30
			public void __callBase_TryUpdateSignedDays()
			{
				this.m_owner.__callBase_TryUpdateSignedDays();
			}

			// Token: 0x0600750D RID: 29965 RVA: 0x00202A40 File Offset: 0x00200C40
			public bool __callBase_IsGameFunctionOpened(GameFunctionType gameFunctionType)
			{
				return this.m_owner.__callBase_IsGameFunctionOpened(gameFunctionType);
			}

			// Token: 0x0600750E RID: 29966 RVA: 0x00202A50 File Offset: 0x00200C50
			public DateTime __callBase_GetCreateTime()
			{
				return this.m_owner.__callBase_GetCreateTime();
			}

			// Token: 0x0600750F RID: 29967 RVA: 0x00202A60 File Offset: 0x00200C60
			public DateTime __callBase_GetCreateTimeUtc()
			{
				return this.m_owner.__callBase_GetCreateTimeUtc();
			}

			// Token: 0x06007510 RID: 29968 RVA: 0x00202A70 File Offset: 0x00200C70
			public DateTime __callBase_GetLastLogoutTime()
			{
				return this.m_owner.__callBase_GetLastLogoutTime();
			}

			// Token: 0x06007511 RID: 29969 RVA: 0x00202A80 File Offset: 0x00200C80
			public DateTime __callBase_GetLoginTime()
			{
				return this.m_owner.__callBase_GetLoginTime();
			}

			// Token: 0x06007512 RID: 29970 RVA: 0x00202A90 File Offset: 0x00200C90
			public string __callBase_GetPlayerName()
			{
				return this.m_owner.__callBase_GetPlayerName();
			}

			// Token: 0x06007513 RID: 29971 RVA: 0x00202AA0 File Offset: 0x00200CA0
			public string __callBase_GetUserId()
			{
				return this.m_owner.__callBase_GetUserId();
			}

			// Token: 0x06007514 RID: 29972 RVA: 0x00202AB0 File Offset: 0x00200CB0
			public bool __callBase_IsMe(string userId)
			{
				return this.m_owner.__callBase_IsMe(userId);
			}

			// Token: 0x06007515 RID: 29973 RVA: 0x00202AC0 File Offset: 0x00200CC0
			public int __callBase_GetCurrentLevelExp()
			{
				return this.m_owner.__callBase_GetCurrentLevelExp();
			}

			// Token: 0x06007516 RID: 29974 RVA: 0x00202AD0 File Offset: 0x00200CD0
			public int __callBase_GetRechargedCsystal()
			{
				return this.m_owner.__callBase_GetRechargedCsystal();
			}

			// Token: 0x06007517 RID: 29975 RVA: 0x00202AE0 File Offset: 0x00200CE0
			public long __callBase_GetRechargeRMB()
			{
				return this.m_owner.__callBase_GetRechargeRMB();
			}

			// Token: 0x06007518 RID: 29976 RVA: 0x00202AF0 File Offset: 0x00200CF0
			public int __callBase_GetHeadIcon()
			{
				return this.m_owner.__callBase_GetHeadIcon();
			}

			// Token: 0x06007519 RID: 29977 RVA: 0x00202B00 File Offset: 0x00200D00
			public int __callBase_GetDefaultHeadIcon()
			{
				return this.m_owner.__callBase_GetDefaultHeadIcon();
			}

			// Token: 0x0600751A RID: 29978 RVA: 0x00202B10 File Offset: 0x00200D10
			public int __callBase_GetHeadPortrait()
			{
				return this.m_owner.__callBase_GetHeadPortrait();
			}

			// Token: 0x0600751B RID: 29979 RVA: 0x00202B20 File Offset: 0x00200D20
			public int __callBase_GetHeadFrame()
			{
				return this.m_owner.__callBase_GetHeadFrame();
			}

			// Token: 0x0600751C RID: 29980 RVA: 0x00202B30 File Offset: 0x00200D30
			public bool __callBase_IsPlayerLevelMax()
			{
				return this.m_owner.__callBase_IsPlayerLevelMax();
			}

			// Token: 0x0600751D RID: 29981 RVA: 0x00202B40 File Offset: 0x00200D40
			public int __callBase_AddPlayerExp(int exp)
			{
				return this.m_owner.__callBase_AddPlayerExp(exp);
			}

			// Token: 0x0600751E RID: 29982 RVA: 0x00202B50 File Offset: 0x00200D50
			public void __callBase_OnLevelChange(int upLevel, int addExp)
			{
				this.m_owner.__callBase_OnLevelChange(upLevel, addExp);
			}

			// Token: 0x0600751F RID: 29983 RVA: 0x00202B60 File Offset: 0x00200D60
			public int __callBase_AddGold(int nums, GameFunctionType causeId, string location)
			{
				return this.m_owner.__callBase_AddGold(nums, causeId, location);
			}

			// Token: 0x06007520 RID: 29984 RVA: 0x00202B70 File Offset: 0x00200D70
			public bool __callBase_IsGoldEnough(int useGoldCount)
			{
				return this.m_owner.__callBase_IsGoldEnough(useGoldCount);
			}

			// Token: 0x06007521 RID: 29985 RVA: 0x00202B80 File Offset: 0x00200D80
			public bool __callBase_IsGoldOverFlow(int addNums)
			{
				return this.m_owner.__callBase_IsGoldOverFlow(addNums);
			}

			// Token: 0x06007522 RID: 29986 RVA: 0x00202B90 File Offset: 0x00200D90
			public int __callBase_GetGold()
			{
				return this.m_owner.__callBase_GetGold();
			}

			// Token: 0x06007523 RID: 29987 RVA: 0x00202BA0 File Offset: 0x00200DA0
			public int __callBase_AddBrillianceMithralStone(int nums)
			{
				return this.m_owner.__callBase_AddBrillianceMithralStone(nums);
			}

			// Token: 0x06007524 RID: 29988 RVA: 0x00202BB0 File Offset: 0x00200DB0
			public int __callBase_AddMithralStone(int nums)
			{
				return this.m_owner.__callBase_AddMithralStone(nums);
			}

			// Token: 0x06007525 RID: 29989 RVA: 0x00202BC0 File Offset: 0x00200DC0
			public bool __callBase_IsMithralStoneEnough(int nums)
			{
				return this.m_owner.__callBase_IsMithralStoneEnough(nums);
			}

			// Token: 0x06007526 RID: 29990 RVA: 0x00202BD0 File Offset: 0x00200DD0
			public bool __callBase_IsBrillianceMithralStoneEnough(int nums)
			{
				return this.m_owner.__callBase_IsBrillianceMithralStoneEnough(nums);
			}

			// Token: 0x06007527 RID: 29991 RVA: 0x00202BE0 File Offset: 0x00200DE0
			public int __callBase_IsCurrencyEnough(GoodsType currencyType, int consumeNums)
			{
				return this.m_owner.__callBase_IsCurrencyEnough(currencyType, consumeNums);
			}

			// Token: 0x06007528 RID: 29992 RVA: 0x00202BF0 File Offset: 0x00200DF0
			public int __callBase_AddCurrency(GoodsType currencyType, int nums, GameFunctionType causeId, string location)
			{
				return this.m_owner.__callBase_AddCurrency(currencyType, nums, causeId, location);
			}

			// Token: 0x06007529 RID: 29993 RVA: 0x00202C04 File Offset: 0x00200E04
			public long __callBase_AddRechargeRMB(int nums, DateTime rechargeTime, bool needSync2Client)
			{
				return this.m_owner.__callBase_AddRechargeRMB(nums, rechargeTime, needSync2Client);
			}

			// Token: 0x0600752A RID: 29994 RVA: 0x00202C14 File Offset: 0x00200E14
			public int __callBase_AddCrystal(int nums, GameFunctionType causeId, string location)
			{
				return this.m_owner.__callBase_AddCrystal(nums, causeId, location);
			}

			// Token: 0x0600752B RID: 29995 RVA: 0x00202C24 File Offset: 0x00200E24
			public bool __callBase_IsCrystalEnough(int consumeNums)
			{
				return this.m_owner.__callBase_IsCrystalEnough(consumeNums);
			}

			// Token: 0x0600752C RID: 29996 RVA: 0x00202C34 File Offset: 0x00200E34
			public void __callBase_InitEnergy(long secondPast)
			{
				this.m_owner.__callBase_InitEnergy(secondPast);
			}

			// Token: 0x0600752D RID: 29997 RVA: 0x00202C44 File Offset: 0x00200E44
			public bool __callBase_IsReachEnergyMax(long currentEnergy)
			{
				return this.m_owner.__callBase_IsReachEnergyMax(currentEnergy);
			}

			// Token: 0x0600752E RID: 29998 RVA: 0x00202C54 File Offset: 0x00200E54
			public void __callBase_FlushEnergy()
			{
				this.m_owner.__callBase_FlushEnergy();
			}

			// Token: 0x0600752F RID: 29999 RVA: 0x00202C64 File Offset: 0x00200E64
			public bool __callBase_CanFlushEnergy()
			{
				return this.m_owner.__callBase_CanFlushEnergy();
			}

			// Token: 0x06007530 RID: 30000 RVA: 0x00202C74 File Offset: 0x00200E74
			public bool __callBase_CanFlushPlayerAction()
			{
				return this.m_owner.__callBase_CanFlushPlayerAction();
			}

			// Token: 0x06007531 RID: 30001 RVA: 0x00202C84 File Offset: 0x00200E84
			public void __callBase_ResetPlayerActionNextFlushTime()
			{
				this.m_owner.__callBase_ResetPlayerActionNextFlushTime();
			}

			// Token: 0x06007532 RID: 30002 RVA: 0x00202C94 File Offset: 0x00200E94
			public int __callBase_IncreamentEnergy(long energyAddNums, bool canAboveMaxEnergy, GameFunctionType causeId, string location)
			{
				return this.m_owner.__callBase_IncreamentEnergy(energyAddNums, canAboveMaxEnergy, causeId, location);
			}

			// Token: 0x06007533 RID: 30003 RVA: 0x00202CA8 File Offset: 0x00200EA8
			public int __callBase_DecreaseEnergy(int energyCost, GameFunctionType causeId, string location)
			{
				return this.m_owner.__callBase_DecreaseEnergy(energyCost, causeId, location);
			}

			// Token: 0x06007534 RID: 30004 RVA: 0x00202CB8 File Offset: 0x00200EB8
			public bool __callBase_IsEnergyEnough(int consumeEnergy)
			{
				return this.m_owner.__callBase_IsEnergyEnough(consumeEnergy);
			}

			// Token: 0x06007535 RID: 30005 RVA: 0x00202CC8 File Offset: 0x00200EC8
			public int __callBase_GetEnergy()
			{
				return this.m_owner.__callBase_GetEnergy();
			}

			// Token: 0x06007536 RID: 30006 RVA: 0x00202CD8 File Offset: 0x00200ED8
			public DateTime __callBase_GetCurrentTime()
			{
				return this.m_owner.__callBase_GetCurrentTime();
			}

			// Token: 0x06007537 RID: 30007 RVA: 0x00202CE8 File Offset: 0x00200EE8
			public bool __callBase_IsSigned()
			{
				return this.m_owner.__callBase_IsSigned();
			}

			// Token: 0x06007538 RID: 30008 RVA: 0x00202CF8 File Offset: 0x00200EF8
			public int __callBase_CanSignToday()
			{
				return this.m_owner.__callBase_CanSignToday();
			}

			// Token: 0x06007539 RID: 30009 RVA: 0x00202D08 File Offset: 0x00200F08
			public int __callBase_CanBuyEnergy()
			{
				return this.m_owner.__callBase_CanBuyEnergy();
			}

			// Token: 0x0600753A RID: 30010 RVA: 0x00202D18 File Offset: 0x00200F18
			public int __callBase_BuyEnergy()
			{
				return this.m_owner.__callBase_BuyEnergy();
			}

			// Token: 0x0600753B RID: 30011 RVA: 0x00202D28 File Offset: 0x00200F28
			public int __callBase_CanBuyArenaTickets()
			{
				return this.m_owner.__callBase_CanBuyArenaTickets();
			}

			// Token: 0x0600753C RID: 30012 RVA: 0x00202D38 File Offset: 0x00200F38
			public int __callBase_BuyArenaTickets()
			{
				return this.m_owner.__callBase_BuyArenaTickets();
			}

			// Token: 0x0600753D RID: 30013 RVA: 0x00202D48 File Offset: 0x00200F48
			public DateTime __callBase_GetNextFlushPlayerActionTime()
			{
				return this.m_owner.__callBase_GetNextFlushPlayerActionTime();
			}

			// Token: 0x0600753E RID: 30014 RVA: 0x00202D58 File Offset: 0x00200F58
			public bool __callBase_FlushPlayerAction()
			{
				return this.m_owner.__callBase_FlushPlayerAction();
			}

			// Token: 0x0600753F RID: 30015 RVA: 0x00202D68 File Offset: 0x00200F68
			public void __callBase_OnPlayerActionFlushEvent()
			{
				this.m_owner.__callBase_OnPlayerActionFlushEvent();
			}

			// Token: 0x06007540 RID: 30016 RVA: 0x00202D78 File Offset: 0x00200F78
			public bool __callBase_IsArenaTicketsEnough(int consumeNums)
			{
				return this.m_owner.__callBase_IsArenaTicketsEnough(consumeNums);
			}

			// Token: 0x06007541 RID: 30017 RVA: 0x00202D88 File Offset: 0x00200F88
			public bool __callBase_IsArenaTicketsFull()
			{
				return this.m_owner.__callBase_IsArenaTicketsFull();
			}

			// Token: 0x06007542 RID: 30018 RVA: 0x00202D98 File Offset: 0x00200F98
			public int __callBase_AddArenaTickets(int nums, bool arenaGiven, GameFunctionType causeId, string location)
			{
				return this.m_owner.__callBase_AddArenaTickets(nums, arenaGiven, causeId, location);
			}

			// Token: 0x06007543 RID: 30019 RVA: 0x00202DAC File Offset: 0x00200FAC
			public int __callBase_GetAreanaTicketNums()
			{
				return this.m_owner.__callBase_GetAreanaTicketNums();
			}

			// Token: 0x06007544 RID: 30020 RVA: 0x00202DBC File Offset: 0x00200FBC
			public int __callBase_AddRechargedCrystal(int nums)
			{
				return this.m_owner.__callBase_AddRechargedCrystal(nums);
			}

			// Token: 0x06007545 RID: 30021 RVA: 0x00202DCC File Offset: 0x00200FCC
			public int __callBase_AddArenaHonour(int nums, GameFunctionType causeId, string location)
			{
				return this.m_owner.__callBase_AddArenaHonour(nums, causeId, location);
			}

			// Token: 0x06007546 RID: 30022 RVA: 0x00202DDC File Offset: 0x00200FDC
			public int __callBase_GetArenaHonour()
			{
				return this.m_owner.__callBase_GetArenaHonour();
			}

			// Token: 0x06007547 RID: 30023 RVA: 0x00202DEC File Offset: 0x00200FEC
			public int __callBase_AddRealTimePVPHonor(int nums, GameFunctionType causeId, string location)
			{
				return this.m_owner.__callBase_AddRealTimePVPHonor(nums, causeId, location);
			}

			// Token: 0x06007548 RID: 30024 RVA: 0x00202DFC File Offset: 0x00200FFC
			public int __callBase_GetRealTimePVPHonor()
			{
				return this.m_owner.__callBase_GetRealTimePVPHonor();
			}

			// Token: 0x06007549 RID: 30025 RVA: 0x00202E0C File Offset: 0x0020100C
			public int __callBase_GetFriendshipPoints()
			{
				return this.m_owner.__callBase_GetFriendshipPoints();
			}

			// Token: 0x0600754A RID: 30026 RVA: 0x00202E1C File Offset: 0x0020101C
			public int __callBase_GetSkinTickets()
			{
				return this.m_owner.__callBase_GetSkinTickets();
			}

			// Token: 0x0600754B RID: 30027 RVA: 0x00202E2C File Offset: 0x0020102C
			public int __callBase_AddFriendshipPoints(int nums, GameFunctionType causeId, string location)
			{
				return this.m_owner.__callBase_AddFriendshipPoints(nums, causeId, location);
			}

			// Token: 0x0600754C RID: 30028 RVA: 0x00202E3C File Offset: 0x0020103C
			public int __callBase_AddSkinTickets(int nums, GameFunctionType causeId, string location)
			{
				return this.m_owner.__callBase_AddSkinTickets(nums, causeId, location);
			}

			// Token: 0x0600754D RID: 30029 RVA: 0x00202E4C File Offset: 0x0020104C
			public int __callBase_AddMemoryEssence(int nums, GameFunctionType causeId, string location)
			{
				return this.m_owner.__callBase_AddMemoryEssence(nums, causeId, location);
			}

			// Token: 0x0600754E RID: 30030 RVA: 0x00202E5C File Offset: 0x0020105C
			public int __callBase_AddBrillianceMithralStone(int nums, GameFunctionType causeId, string location)
			{
				return this.m_owner.__callBase_AddBrillianceMithralStone(nums, causeId, location);
			}

			// Token: 0x0600754F RID: 30031 RVA: 0x00202E6C File Offset: 0x0020106C
			public int __callBase_AddMithralStone(int nums, GameFunctionType causeId, string location)
			{
				return this.m_owner.__callBase_AddMithralStone(nums, causeId, location);
			}

			// Token: 0x06007550 RID: 30032 RVA: 0x00202E7C File Offset: 0x0020107C
			public int __callBase_AddGuildMedal(int nums, GameFunctionType causeId, string location)
			{
				return this.m_owner.__callBase_AddGuildMedal(nums, causeId, location);
			}

			// Token: 0x06007551 RID: 30033 RVA: 0x00202E8C File Offset: 0x0020108C
			public bool __callBase_IsGuildMedalEnough(int consumeNums)
			{
				return this.m_owner.__callBase_IsGuildMedalEnough(consumeNums);
			}

			// Token: 0x06007552 RID: 30034 RVA: 0x00202E9C File Offset: 0x0020109C
			public bool __callBase_IsFriendshipPointsEnough(int consumeNums)
			{
				return this.m_owner.__callBase_IsFriendshipPointsEnough(consumeNums);
			}

			// Token: 0x06007553 RID: 30035 RVA: 0x00202EAC File Offset: 0x002010AC
			public bool __callBase_IsArenaHonourEnough(int consumeNums)
			{
				return this.m_owner.__callBase_IsArenaHonourEnough(consumeNums);
			}

			// Token: 0x06007554 RID: 30036 RVA: 0x00202EBC File Offset: 0x002010BC
			public bool __callBase_IsRealTimePVPHonorEnough(int consumeNums)
			{
				return this.m_owner.__callBase_IsRealTimePVPHonorEnough(consumeNums);
			}

			// Token: 0x06007555 RID: 30037 RVA: 0x00202ECC File Offset: 0x002010CC
			public bool __callBase_IsSkinTicketEnough(int consumeNums)
			{
				return this.m_owner.__callBase_IsSkinTicketEnough(consumeNums);
			}

			// Token: 0x06007556 RID: 30038 RVA: 0x00202EDC File Offset: 0x002010DC
			public bool __callBase_IsMemoryEssenceEnough(int consumeNums)
			{
				return this.m_owner.__callBase_IsMemoryEssenceEnough(consumeNums);
			}

			// Token: 0x06007557 RID: 30039 RVA: 0x00202EEC File Offset: 0x002010EC
			public int __callBase_CanSetUserGuide(List<int> completeStepIds)
			{
				return this.m_owner.__callBase_CanSetUserGuide(completeStepIds);
			}

			// Token: 0x06007558 RID: 30040 RVA: 0x00202EFC File Offset: 0x002010FC
			public int __callBase_SetUserGuide(List<int> completeStepIds)
			{
				return this.m_owner.__callBase_SetUserGuide(completeStepIds);
			}

			// Token: 0x06007559 RID: 30041 RVA: 0x00202F0C File Offset: 0x0020110C
			public void __callBase_CleanUserGuide(List<int> completeStepIds)
			{
				this.m_owner.__callBase_CleanUserGuide(completeStepIds);
			}

			// Token: 0x0600755A RID: 30042 RVA: 0x00202F1C File Offset: 0x0020111C
			public void __callBase_CompleteAllUserGuides()
			{
				this.m_owner.__callBase_CompleteAllUserGuides();
			}

			// Token: 0x0600755B RID: 30043 RVA: 0x00202F2C File Offset: 0x0020112C
			public bool __callBase_IsUserGuideCompleted(int stepId)
			{
				return this.m_owner.__callBase_IsUserGuideCompleted(stepId);
			}

			// Token: 0x0600755C RID: 30044 RVA: 0x00202F3C File Offset: 0x0020113C
			public int __callBase_GetLevel()
			{
				return this.m_owner.__callBase_GetLevel();
			}

			// Token: 0x0600755D RID: 30045 RVA: 0x00202F4C File Offset: 0x0020114C
			public int __callBase_GetRechargedCrystal()
			{
				return this.m_owner.__callBase_GetRechargedCrystal();
			}

			// Token: 0x0600755E RID: 30046 RVA: 0x00202F5C File Offset: 0x0020115C
			public int __callBase_GetCrystal()
			{
				return this.m_owner.__callBase_GetCrystal();
			}

			// Token: 0x0600755F RID: 30047 RVA: 0x00202F6C File Offset: 0x0020116C
			public bool __callBase_CheckRankingListAddPlayerLevel()
			{
				return this.m_owner.__callBase_CheckRankingListAddPlayerLevel();
			}

			// Token: 0x06007560 RID: 30048 RVA: 0x00202F7C File Offset: 0x0020117C
			public RankingPlayerInfo __callBase_CreateRankingPlayerInfo(int championHeroId)
			{
				return this.m_owner.__callBase_CreateRankingPlayerInfo(championHeroId);
			}

			// Token: 0x06007561 RID: 30049 RVA: 0x00202F8C File Offset: 0x0020118C
			public void __callBase_OnRankingListPlayerInfoChange()
			{
				this.m_owner.__callBase_OnRankingListPlayerInfoChange();
			}

			// Token: 0x06007562 RID: 30050 RVA: 0x00202F9C File Offset: 0x0020119C
			public void __callBase_OpenGameRating()
			{
				this.m_owner.__callBase_OpenGameRating();
			}

			// Token: 0x06007563 RID: 30051 RVA: 0x00202FAC File Offset: 0x002011AC
			public bool __callBase_IsOpenGameRating()
			{
				return this.m_owner.__callBase_IsOpenGameRating();
			}

			// Token: 0x06007564 RID: 30052 RVA: 0x00202FBC File Offset: 0x002011BC
			public void __callBase_SetMemoryStoreOpenStatus(bool open)
			{
				this.m_owner.__callBase_SetMemoryStoreOpenStatus(open);
			}

			// Token: 0x06007565 RID: 30053 RVA: 0x00202FCC File Offset: 0x002011CC
			public bool __callBase_IsMemoryStoreOpen()
			{
				return this.m_owner.__callBase_IsMemoryStoreOpen();
			}

			// Token: 0x06007566 RID: 30054 RVA: 0x00202FDC File Offset: 0x002011DC
			public int __callBase_GetLevelUpAddEnergyFromConfig()
			{
				return this.m_owner.__callBase_GetLevelUpAddEnergyFromConfig();
			}

			// Token: 0x06007567 RID: 30055 RVA: 0x00202FEC File Offset: 0x002011EC
			public int __callBase_GetNextLevelExpFromConfig()
			{
				return this.m_owner.__callBase_GetNextLevelExpFromConfig();
			}

			// Token: 0x06007568 RID: 30056 RVA: 0x00202FFC File Offset: 0x002011FC
			public int __callBase_CanSetHeadPortraitAndHeadFrame(int headPortraitId, int headFrameId)
			{
				return this.m_owner.__callBase_CanSetHeadPortraitAndHeadFrame(headPortraitId, headFrameId);
			}

			// Token: 0x06007569 RID: 30057 RVA: 0x0020300C File Offset: 0x0020120C
			public int __callBase_SetHeadPortraitAndHeadFrame(int headPortraitId, int headFrameId)
			{
				return this.m_owner.__callBase_SetHeadPortraitAndHeadFrame(headPortraitId, headFrameId);
			}

			// Token: 0x0600756A RID: 30058 RVA: 0x0020301C File Offset: 0x0020121C
			public int __callBase_CanSetHeadPortrait(int headPortraitId)
			{
				return this.m_owner.__callBase_CanSetHeadPortrait(headPortraitId);
			}

			// Token: 0x0600756B RID: 30059 RVA: 0x0020302C File Offset: 0x0020122C
			public int __callBase_SetHeadPortrait(int headPortraitId)
			{
				return this.m_owner.__callBase_SetHeadPortrait(headPortraitId);
			}

			// Token: 0x0600756C RID: 30060 RVA: 0x0020303C File Offset: 0x0020123C
			public int __callBase_CanSetHeadFrame(int headFrameId)
			{
				return this.m_owner.__callBase_CanSetHeadFrame(headFrameId);
			}

			// Token: 0x0600756D RID: 30061 RVA: 0x0020304C File Offset: 0x0020124C
			public int __callBase_SetHeadFrame(int headFrameId)
			{
				return this.m_owner.__callBase_SetHeadFrame(headFrameId);
			}

			// Token: 0x0600756E RID: 30062 RVA: 0x0020305C File Offset: 0x0020125C
			public void __callBase_OnHeadIconChange()
			{
				this.m_owner.__callBase_OnHeadIconChange();
			}

			// Token: 0x0600756F RID: 30063 RVA: 0x0020306C File Offset: 0x0020126C
			public int __callBase_CanChangePlayerName(string newName)
			{
				return this.m_owner.__callBase_CanChangePlayerName(newName);
			}

			// Token: 0x06007570 RID: 30064 RVA: 0x0020307C File Offset: 0x0020127C
			public int __callBase_ChangePlayerName(string newName)
			{
				return this.m_owner.__callBase_ChangePlayerName(newName);
			}

			// Token: 0x06007571 RID: 30065 RVA: 0x0020308C File Offset: 0x0020128C
			public int __callBase_TryChangePlayerName(string newName)
			{
				return this.m_owner.__callBase_TryChangePlayerName(newName);
			}

			// Token: 0x06007572 RID: 30066 RVA: 0x0020309C File Offset: 0x0020129C
			public int __callBase_CheckPlayerName(string name)
			{
				return this.m_owner.__callBase_CheckPlayerName(name);
			}

			// Token: 0x06007573 RID: 30067 RVA: 0x002030AC File Offset: 0x002012AC
			public void __callBase_DoShare()
			{
				this.m_owner.__callBase_DoShare();
			}

			// Token: 0x17001BDA RID: 7130
			// (get) Token: 0x06007574 RID: 30068 RVA: 0x002030BC File Offset: 0x002012BC
			// (set) Token: 0x06007575 RID: 30069 RVA: 0x002030CC File Offset: 0x002012CC
			public ProjectLPlayerContext m_playerContext
			{
				get
				{
					return this.m_owner.m_playerContext;
				}
				set
				{
					this.m_owner.m_playerContext = value;
				}
			}

			// Token: 0x06007576 RID: 30070 RVA: 0x002030DC File Offset: 0x002012DC
			public void OnLevelChange(int upLevel, int addExp)
			{
				this.m_owner.OnLevelChange(upLevel, addExp);
			}

			// Token: 0x040055CA RID: 21962
			private PlayerBasicInfoComponent m_owner;
		}
	}
}
