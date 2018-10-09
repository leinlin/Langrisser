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
	// Token: 0x020008CF RID: 2255
	[HotFix]
	public class NoviceComponent : NoviceComponentCommon
	{
		// Token: 0x060073FE RID: 29694 RVA: 0x001FF740 File Offset: 0x001FD940
		public NoviceComponent()
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

		// Token: 0x060073FF RID: 29695 RVA: 0x001FF7A8 File Offset: 0x001FD9A8
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
			base.m_configDataLoader = (GameManager.Instance.ConfigDataLoader as IConfigDataLoader);
			base.Init();
		}

		// Token: 0x06007400 RID: 29696 RVA: 0x001FF824 File Offset: 0x001FDA24
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

		// Token: 0x06007401 RID: 29697 RVA: 0x001FF88C File Offset: 0x001FDA8C
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

		// Token: 0x06007402 RID: 29698 RVA: 0x001FF8F4 File Offset: 0x001FDAF4
		public void DeSerialize(DSNoviceNtf ntf)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DeSerializeDSNoviceNtf_hotfix != null)
			{
				this.m_DeSerializeDSNoviceNtf_hotfix.call(new object[]
				{
					this,
					ntf
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_noviceDS.ClearInitedData();
			this.m_noviceDS.MissionPoints = ntf.Novice.MissionPoints;
			this.m_noviceDS.RewardClaimedSlots.AddRange(ntf.Novice.RewardClaimedSlots);
			this.m_noviceDS.InitVersion((ushort)ntf.Version, (ushort)ntf.Version);
		}

		// Token: 0x06007403 RID: 29699 RVA: 0x001FF9BC File Offset: 0x001FDBBC
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
			return this.m_noviceDS.ClientVersion;
		}

		// Token: 0x17001BD7 RID: 7127
		// (get) Token: 0x06007404 RID: 29700 RVA: 0x001FFA34 File Offset: 0x001FDC34
		// (set) Token: 0x06007405 RID: 29701 RVA: 0x001FFA54 File Offset: 0x001FDC54
		[DoNotToLua]
		public new NoviceComponent.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new NoviceComponent.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06007406 RID: 29702 RVA: 0x001FFA60 File Offset: 0x001FDC60
		private string __callBase_GetName()
		{
			return base.GetName();
		}

		// Token: 0x06007407 RID: 29703 RVA: 0x001FFA68 File Offset: 0x001FDC68
		private void __callBase_Init()
		{
			base.Init();
		}

		// Token: 0x06007408 RID: 29704 RVA: 0x001FFA70 File Offset: 0x001FDC70
		private void __callBase_PostInit()
		{
			base.PostInit();
		}

		// Token: 0x06007409 RID: 29705 RVA: 0x001FFA78 File Offset: 0x001FDC78
		private void __callBase_DeInit()
		{
			base.DeInit();
		}

		// Token: 0x0600740A RID: 29706 RVA: 0x001FFA80 File Offset: 0x001FDC80
		private void __callBase_Tick(uint deltaMillisecond)
		{
			base.Tick(deltaMillisecond);
		}

		// Token: 0x0600740B RID: 29707 RVA: 0x001FFA8C File Offset: 0x001FDC8C
		private void __callBase_PostDeSerialize()
		{
			base.PostDeSerialize();
		}

		// Token: 0x0600740C RID: 29708 RVA: 0x001FFA94 File Offset: 0x001FDC94
		private int __callBase_GetMissionPoints()
		{
			return base.GetMissionPoints();
		}

		// Token: 0x0600740D RID: 29709 RVA: 0x001FFA9C File Offset: 0x001FDC9C
		private void __callBase_AddMissionPoints(int Delta)
		{
			base.AddMissionPoints(Delta);
		}

		// Token: 0x0600740E RID: 29710 RVA: 0x001FFAA8 File Offset: 0x001FDCA8
		private List<int> __callBase_GetRewardClaimedSlots()
		{
			return base.GetRewardClaimedSlots();
		}

		// Token: 0x0600740F RID: 29711 RVA: 0x001FFAB0 File Offset: 0x001FDCB0
		private bool __callBase_IsRewardClaimed(int Slot)
		{
			return base.IsRewardClaimed(Slot);
		}

		// Token: 0x06007410 RID: 29712 RVA: 0x001FFABC File Offset: 0x001FDCBC
		private int __callBase_CanClaimReward(int Slot)
		{
			return base.CanClaimReward(Slot);
		}

		// Token: 0x06007411 RID: 29713 RVA: 0x001FFAC8 File Offset: 0x001FDCC8
		private int __callBase_ClaimReward(int Slot, bool NoCheck)
		{
			return base.ClaimReward(Slot, NoCheck);
		}

		// Token: 0x06007412 RID: 29714 RVA: 0x001FFAD4 File Offset: 0x001FDCD4
		private List<ConfigDataNoviceRewardInfo> __callBase_GetNovicePointsRewardsConfig()
		{
			return base.GetNovicePointsRewardsConfig();
		}

		// Token: 0x06007413 RID: 29715 RVA: 0x001FFADC File Offset: 0x001FDCDC
		private int __callBase_GetDaysAfterCreation()
		{
			return base.GetDaysAfterCreation();
		}

		// Token: 0x06007414 RID: 29716 RVA: 0x001FFAE4 File Offset: 0x001FDCE4
		private List<Mission> __callBase_GetProcessingMissions()
		{
			return base.GetProcessingMissions();
		}

		// Token: 0x06007415 RID: 29717 RVA: 0x001FFAEC File Offset: 0x001FDCEC
		private List<Mission> __callBase_GetFinishedMissions()
		{
			return base.GetFinishedMissions();
		}

		// Token: 0x06007416 RID: 29718 RVA: 0x001FFAF4 File Offset: 0x001FDCF4
		private int __callBase_GetMissionDay(ConfigDataMissionInfo Mission)
		{
			return base.GetMissionDay(Mission);
		}

		// Token: 0x06007417 RID: 29719 RVA: 0x001FFB00 File Offset: 0x001FDD00
		private Dictionary<int, List<int>> __callBase_GetMissions()
		{
			return base.GetMissions();
		}

		// Token: 0x06007418 RID: 29720 RVA: 0x001FFB08 File Offset: 0x001FDD08
		private TimeSpan __callBase_GetMissionsEndTime()
		{
			return base.GetMissionsEndTime();
		}

		// Token: 0x06007419 RID: 29721 RVA: 0x001FFB10 File Offset: 0x001FDD10
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
					this.m_DeSerializeDSNoviceNtf_hotfix = (luaObj.RawGet("DeSerialize") as LuaFunction);
					this.m_GetDSVersion_hotfix = (luaObj.RawGet("GetDSVersion") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600741A RID: 29722 RVA: 0x001FFC58 File Offset: 0x001FDE58
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(NoviceComponent));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04005592 RID: 21906
		[DoNotToLua]
		private NoviceComponent.LuaExportHelper luaExportHelper;

		// Token: 0x04005593 RID: 21907
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04005594 RID: 21908
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04005595 RID: 21909
		private LuaFunction m_ctor_hotfix;

		// Token: 0x04005596 RID: 21910
		private LuaFunction m_Init_hotfix;

		// Token: 0x04005597 RID: 21911
		private LuaFunction m_PostInit_hotfix;

		// Token: 0x04005598 RID: 21912
		private LuaFunction m_DeInit_hotfix;

		// Token: 0x04005599 RID: 21913
		private LuaFunction m_DeSerializeDSNoviceNtf_hotfix;

		// Token: 0x0400559A RID: 21914
		private LuaFunction m_GetDSVersion_hotfix;

		// Token: 0x020008D0 RID: 2256
		public new class LuaExportHelper
		{
			// Token: 0x0600741B RID: 29723 RVA: 0x001FFCC0 File Offset: 0x001FDEC0
			public LuaExportHelper(NoviceComponent owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600741C RID: 29724 RVA: 0x001FFCD0 File Offset: 0x001FDED0
			public string __callBase_GetName()
			{
				return this.m_owner.__callBase_GetName();
			}

			// Token: 0x0600741D RID: 29725 RVA: 0x001FFCE0 File Offset: 0x001FDEE0
			public void __callBase_Init()
			{
				this.m_owner.__callBase_Init();
			}

			// Token: 0x0600741E RID: 29726 RVA: 0x001FFCF0 File Offset: 0x001FDEF0
			public void __callBase_PostInit()
			{
				this.m_owner.__callBase_PostInit();
			}

			// Token: 0x0600741F RID: 29727 RVA: 0x001FFD00 File Offset: 0x001FDF00
			public void __callBase_DeInit()
			{
				this.m_owner.__callBase_DeInit();
			}

			// Token: 0x06007420 RID: 29728 RVA: 0x001FFD10 File Offset: 0x001FDF10
			public void __callBase_Tick(uint deltaMillisecond)
			{
				this.m_owner.__callBase_Tick(deltaMillisecond);
			}

			// Token: 0x06007421 RID: 29729 RVA: 0x001FFD20 File Offset: 0x001FDF20
			public void __callBase_PostDeSerialize()
			{
				this.m_owner.__callBase_PostDeSerialize();
			}

			// Token: 0x06007422 RID: 29730 RVA: 0x001FFD30 File Offset: 0x001FDF30
			public int __callBase_GetMissionPoints()
			{
				return this.m_owner.__callBase_GetMissionPoints();
			}

			// Token: 0x06007423 RID: 29731 RVA: 0x001FFD40 File Offset: 0x001FDF40
			public void __callBase_AddMissionPoints(int Delta)
			{
				this.m_owner.__callBase_AddMissionPoints(Delta);
			}

			// Token: 0x06007424 RID: 29732 RVA: 0x001FFD50 File Offset: 0x001FDF50
			public List<int> __callBase_GetRewardClaimedSlots()
			{
				return this.m_owner.__callBase_GetRewardClaimedSlots();
			}

			// Token: 0x06007425 RID: 29733 RVA: 0x001FFD60 File Offset: 0x001FDF60
			public bool __callBase_IsRewardClaimed(int Slot)
			{
				return this.m_owner.__callBase_IsRewardClaimed(Slot);
			}

			// Token: 0x06007426 RID: 29734 RVA: 0x001FFD70 File Offset: 0x001FDF70
			public int __callBase_CanClaimReward(int Slot)
			{
				return this.m_owner.__callBase_CanClaimReward(Slot);
			}

			// Token: 0x06007427 RID: 29735 RVA: 0x001FFD80 File Offset: 0x001FDF80
			public int __callBase_ClaimReward(int Slot, bool NoCheck)
			{
				return this.m_owner.__callBase_ClaimReward(Slot, NoCheck);
			}

			// Token: 0x06007428 RID: 29736 RVA: 0x001FFD90 File Offset: 0x001FDF90
			public List<ConfigDataNoviceRewardInfo> __callBase_GetNovicePointsRewardsConfig()
			{
				return this.m_owner.__callBase_GetNovicePointsRewardsConfig();
			}

			// Token: 0x06007429 RID: 29737 RVA: 0x001FFDA0 File Offset: 0x001FDFA0
			public int __callBase_GetDaysAfterCreation()
			{
				return this.m_owner.__callBase_GetDaysAfterCreation();
			}

			// Token: 0x0600742A RID: 29738 RVA: 0x001FFDB0 File Offset: 0x001FDFB0
			public List<Mission> __callBase_GetProcessingMissions()
			{
				return this.m_owner.__callBase_GetProcessingMissions();
			}

			// Token: 0x0600742B RID: 29739 RVA: 0x001FFDC0 File Offset: 0x001FDFC0
			public List<Mission> __callBase_GetFinishedMissions()
			{
				return this.m_owner.__callBase_GetFinishedMissions();
			}

			// Token: 0x0600742C RID: 29740 RVA: 0x001FFDD0 File Offset: 0x001FDFD0
			public int __callBase_GetMissionDay(ConfigDataMissionInfo Mission)
			{
				return this.m_owner.__callBase_GetMissionDay(Mission);
			}

			// Token: 0x0600742D RID: 29741 RVA: 0x001FFDE0 File Offset: 0x001FDFE0
			public Dictionary<int, List<int>> __callBase_GetMissions()
			{
				return this.m_owner.__callBase_GetMissions();
			}

			// Token: 0x0600742E RID: 29742 RVA: 0x001FFDF0 File Offset: 0x001FDFF0
			public TimeSpan __callBase_GetMissionsEndTime()
			{
				return this.m_owner.__callBase_GetMissionsEndTime();
			}

			// Token: 0x0400559B RID: 21915
			private NoviceComponent m_owner;
		}
	}
}
