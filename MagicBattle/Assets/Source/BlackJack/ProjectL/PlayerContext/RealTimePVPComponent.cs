using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.PlayerContext
{
	// Token: 0x020008DB RID: 2267
	[HotFix]
	public class RealTimePVPComponent : RealTimePVPComponentCommon
	{
		// Token: 0x060075DB RID: 30171 RVA: 0x00204574 File Offset: 0x00202774
		public RealTimePVPComponent()
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

		// Token: 0x060075DC RID: 30172 RVA: 0x002045DC File Offset: 0x002027DC
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

		// Token: 0x060075DD RID: 30173 RVA: 0x00204658 File Offset: 0x00202858
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

		// Token: 0x060075DE RID: 30174 RVA: 0x002046C0 File Offset: 0x002028C0
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

		// Token: 0x060075DF RID: 30175 RVA: 0x00204728 File Offset: 0x00202928
		public void DeSerialize(DSRealTimePVPNtf msg)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DeSerializeDSRealTimePVPNtf_hotfix != null)
			{
				this.m_DeSerializeDSRealTimePVPNtf_hotfix.call(new object[]
				{
					this,
					msg
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_realTimePVP.ClearInitedData();
			this.m_realTimePVP.InitVersion((ushort)msg.Version, (ushort)msg.Version);
			this.m_realTimePVP.IsPromotion = msg.RealTimePVP.IsPromotion;
			foreach (ProRealTimePVPBattleReport report in msg.RealTimePVP.PromotionReports)
			{
				this.m_realTimePVP.PromotionReports.AddLast(report.ToMemory());
			}
			foreach (ProRealTimePVPBattleReport report2 in msg.RealTimePVP.Reports)
			{
				this.m_realTimePVP.Reports.AddLast(report2.ToMemory());
			}
			this.m_realTimePVP.FriendlyCareerMatchStats = msg.RealTimePVP.FriendlyCareerMatchStats.ToMemory();
			this.m_realTimePVP.FriendlyMatchStats = msg.RealTimePVP.FriendlyMatchStats.ToMemory();
			this.m_realTimePVP.LadderCareerMatchStats = msg.RealTimePVP.LadderCareerMatchStats.ToMemory();
			this.m_realTimePVP.LadderMatchStats = msg.RealTimePVP.LadderMatchStats.ToMemory();
			this.m_realTimePVP.WinsBonusIdAcquired.AddRange(msg.RealTimePVP.WinsBonusIdAcquired);
		}

		// Token: 0x060075E0 RID: 30176 RVA: 0x00204920 File Offset: 0x00202B20
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
			return this.m_realTimePVP.ClientVersion;
		}

		// Token: 0x060075E1 RID: 30177 RVA: 0x00204998 File Offset: 0x00202B98
		public RealTimePVPMatchStats GetLadderMatchStats()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetLadderMatchStats_hotfix != null)
			{
				return (RealTimePVPMatchStats)this.m_GetLadderMatchStats_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_realTimePVP.LadderMatchStats;
		}

		// Token: 0x060075E2 RID: 30178 RVA: 0x00204A10 File Offset: 0x00202C10
		public RealTimePVPMatchStats GetFriendlyMatchStats()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetFriendlyMatchStats_hotfix != null)
			{
				return (RealTimePVPMatchStats)this.m_GetFriendlyMatchStats_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_realTimePVP.FriendlyMatchStats;
		}

		// Token: 0x17001BDD RID: 7133
		// (get) Token: 0x060075E3 RID: 30179 RVA: 0x00204A88 File Offset: 0x00202C88
		// (set) Token: 0x060075E4 RID: 30180 RVA: 0x00204AFC File Offset: 0x00202CFC
		public int Dan
		{
			[CompilerGenerated]
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_Dan_hotfix != null)
				{
					return Convert.ToInt32(this.m_get_Dan_hotfix.call(new object[]
					{
						this
					}));
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.<Dan>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_set_DanInt32_hotfix != null)
				{
					this.m_set_DanInt32_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				this.<Dan>k__BackingField = value;
			}
		}

		// Token: 0x17001BDE RID: 7134
		// (get) Token: 0x060075E5 RID: 30181 RVA: 0x00204B74 File Offset: 0x00202D74
		// (set) Token: 0x060075E6 RID: 30182 RVA: 0x00204BE8 File Offset: 0x00202DE8
		public int Score
		{
			[CompilerGenerated]
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_Score_hotfix != null)
				{
					return Convert.ToInt32(this.m_get_Score_hotfix.call(new object[]
					{
						this
					}));
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.<Score>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_set_ScoreInt32_hotfix != null)
				{
					this.m_set_ScoreInt32_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				this.<Score>k__BackingField = value;
			}
		}

		// Token: 0x17001BDF RID: 7135
		// (get) Token: 0x060075E7 RID: 30183 RVA: 0x00204C60 File Offset: 0x00202E60
		// (set) Token: 0x060075E8 RID: 30184 RVA: 0x00204C80 File Offset: 0x00202E80
		[DoNotToLua]
		public new RealTimePVPComponent.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new RealTimePVPComponent.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x060075E9 RID: 30185 RVA: 0x00204C8C File Offset: 0x00202E8C
		private string __callBase_GetName()
		{
			return base.GetName();
		}

		// Token: 0x060075EA RID: 30186 RVA: 0x00204C94 File Offset: 0x00202E94
		private void __callBase_Init()
		{
			base.Init();
		}

		// Token: 0x060075EB RID: 30187 RVA: 0x00204C9C File Offset: 0x00202E9C
		private void __callBase_PostInit()
		{
			base.PostInit();
		}

		// Token: 0x060075EC RID: 30188 RVA: 0x00204CA4 File Offset: 0x00202EA4
		private void __callBase_DeInit()
		{
			base.DeInit();
		}

		// Token: 0x060075ED RID: 30189 RVA: 0x00204CAC File Offset: 0x00202EAC
		private void __callBase_Tick(uint deltaMillisecond)
		{
			base.Tick(deltaMillisecond);
		}

		// Token: 0x060075EE RID: 30190 RVA: 0x00204CB8 File Offset: 0x00202EB8
		private void __callBase_PostDeSerialize()
		{
			base.PostDeSerialize();
		}

		// Token: 0x060075EF RID: 30191 RVA: 0x00204CC0 File Offset: 0x00202EC0
		private void __callBase_RealTimeArenaDanUpdate(int dan)
		{
			base.RealTimeArenaDanUpdate(dan);
		}

		// Token: 0x060075F0 RID: 30192 RVA: 0x00204CCC File Offset: 0x00202ECC
		private void __callBase_RealTimeArenaBattleFinish(BattleMode mode, bool win)
		{
			base.RealTimeArenaBattleFinish(mode, win);
		}

		// Token: 0x060075F1 RID: 30193 RVA: 0x00204CD8 File Offset: 0x00202ED8
		private void __callBase_RealTimeArenaBattleStart(BattleMode mode)
		{
			base.RealTimeArenaBattleStart(mode);
		}

		// Token: 0x060075F2 RID: 30194 RVA: 0x00204CE4 File Offset: 0x00202EE4
		private int __callBase_IsRealTimePVPUnlocked()
		{
			return base.IsRealTimePVPUnlocked();
		}

		// Token: 0x060075F3 RID: 30195 RVA: 0x00204CEC File Offset: 0x00202EEC
		private int __callBase_IsRealTimePVPArenaAvailable(BattleMode Mode)
		{
			return base.IsRealTimePVPArenaAvailable(Mode);
		}

		// Token: 0x060075F4 RID: 30196 RVA: 0x00204CF8 File Offset: 0x00202EF8
		private void __callBase_OnFlushRealTimePVP()
		{
			base.OnFlushRealTimePVP();
		}

		// Token: 0x060075F5 RID: 30197 RVA: 0x00204D00 File Offset: 0x00202F00
		private void __callBase_StartNewSeason()
		{
			base.StartNewSeason();
		}

		// Token: 0x060075F6 RID: 30198 RVA: 0x00204D08 File Offset: 0x00202F08
		private bool __callBase_IsPromotion()
		{
			return base.IsPromotion();
		}

		// Token: 0x060075F7 RID: 30199 RVA: 0x00204D10 File Offset: 0x00202F10
		private LinkedList<RealTimePVPBattleReport> __callBase_GetPromotionBattleReports()
		{
			return base.GetPromotionBattleReports();
		}

		// Token: 0x060075F8 RID: 30200 RVA: 0x00204D18 File Offset: 0x00202F18
		private LinkedList<RealTimePVPBattleReport> __callBase_GetBattleReports()
		{
			return base.GetBattleReports();
		}

		// Token: 0x060075F9 RID: 30201 RVA: 0x00204D20 File Offset: 0x00202F20
		private void __callBase_StartPromotion()
		{
			base.StartPromotion();
		}

		// Token: 0x060075FA RID: 30202 RVA: 0x00204D28 File Offset: 0x00202F28
		private void __callBase_EndPromotion()
		{
			base.EndPromotion();
		}

		// Token: 0x060075FB RID: 30203 RVA: 0x00204D30 File Offset: 0x00202F30
		private void __callBase_SavePromotionReport(RealTimePVPBattleReport Report)
		{
			base.SavePromotionReport(Report);
		}

		// Token: 0x060075FC RID: 30204 RVA: 0x00204D3C File Offset: 0x00202F3C
		private void __callBase_SaveReport(RealTimePVPBattleReport Report)
		{
			base.SaveReport(Report);
		}

		// Token: 0x060075FD RID: 30205 RVA: 0x00204D48 File Offset: 0x00202F48
		private int __callBase_CheckAcquireWinsBonus(int BonusId)
		{
			return base.CheckAcquireWinsBonus(BonusId);
		}

		// Token: 0x060075FE RID: 30206 RVA: 0x00204D54 File Offset: 0x00202F54
		private int __callBase_AcquireWinsBonus(int BonusId)
		{
			return base.AcquireWinsBonus(BonusId);
		}

		// Token: 0x060075FF RID: 30207 RVA: 0x00204D60 File Offset: 0x00202F60
		private int __callBase_GetConsecutiveWins(BattleMode Mode)
		{
			return base.GetConsecutiveWins(Mode);
		}

		// Token: 0x06007600 RID: 30208 RVA: 0x00204D6C File Offset: 0x00202F6C
		private int __callBase_GetConsecutiveLosses(BattleMode Mode)
		{
			return base.GetConsecutiveLosses(Mode);
		}

		// Token: 0x06007601 RID: 30209 RVA: 0x00204D78 File Offset: 0x00202F78
		private RealTimePVPMatchStats __callBase_GetLadderCareerMatchStats()
		{
			return base.GetLadderCareerMatchStats();
		}

		// Token: 0x06007602 RID: 30210 RVA: 0x00204D80 File Offset: 0x00202F80
		private bool __callBase_TryGetBotParamsForNovice(BattleMode Mode, int MyScore, out int LevelMin, out int LevelMax, out int ScoreMin, out int ScoreMax)
		{
			return base.TryGetBotParamsForNovice(Mode, MyScore, out LevelMin, out LevelMax, out ScoreMin, out ScoreMax);
		}

		// Token: 0x06007603 RID: 30211 RVA: 0x00204D94 File Offset: 0x00202F94
		private bool __callBase_TryGetBotParamsForLoser(BattleMode Mode, int MyScore, int Dan, out int LevelMin, out int LevelMax, out int ScoreMin, out int ScoreMax)
		{
			return base.TryGetBotParamsForLoser(Mode, MyScore, Dan, out LevelMin, out LevelMax, out ScoreMin, out ScoreMax);
		}

		// Token: 0x06007604 RID: 30212 RVA: 0x00204DA8 File Offset: 0x00202FA8
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
					this.m_DeSerializeDSRealTimePVPNtf_hotfix = (luaObj.RawGet("DeSerialize") as LuaFunction);
					this.m_GetDSVersion_hotfix = (luaObj.RawGet("GetDSVersion") as LuaFunction);
					this.m_GetLadderMatchStats_hotfix = (luaObj.RawGet("GetLadderMatchStats") as LuaFunction);
					this.m_GetFriendlyMatchStats_hotfix = (luaObj.RawGet("GetFriendlyMatchStats") as LuaFunction);
					this.m_get_Dan_hotfix = (luaObj.RawGet("get_Dan") as LuaFunction);
					this.m_set_DanInt32_hotfix = (luaObj.RawGet("set_Dan") as LuaFunction);
					this.m_get_Score_hotfix = (luaObj.RawGet("get_Score") as LuaFunction);
					this.m_set_ScoreInt32_hotfix = (luaObj.RawGet("set_Score") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06007605 RID: 30213 RVA: 0x00204F88 File Offset: 0x00203188
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(RealTimePVPComponent));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040055EB RID: 21995
		[DoNotToLua]
		private RealTimePVPComponent.LuaExportHelper luaExportHelper;

		// Token: 0x040055EC RID: 21996
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040055ED RID: 21997
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040055EE RID: 21998
		private LuaFunction m_ctor_hotfix;

		// Token: 0x040055EF RID: 21999
		private LuaFunction m_Init_hotfix;

		// Token: 0x040055F0 RID: 22000
		private LuaFunction m_PostInit_hotfix;

		// Token: 0x040055F1 RID: 22001
		private LuaFunction m_DeInit_hotfix;

		// Token: 0x040055F2 RID: 22002
		private LuaFunction m_DeSerializeDSRealTimePVPNtf_hotfix;

		// Token: 0x040055F3 RID: 22003
		private LuaFunction m_GetDSVersion_hotfix;

		// Token: 0x040055F4 RID: 22004
		private LuaFunction m_GetLadderMatchStats_hotfix;

		// Token: 0x040055F5 RID: 22005
		private LuaFunction m_GetFriendlyMatchStats_hotfix;

		// Token: 0x040055F6 RID: 22006
		private LuaFunction m_get_Dan_hotfix;

		// Token: 0x040055F7 RID: 22007
		private LuaFunction m_set_DanInt32_hotfix;

		// Token: 0x040055F8 RID: 22008
		private LuaFunction m_get_Score_hotfix;

		// Token: 0x040055F9 RID: 22009
		private LuaFunction m_set_ScoreInt32_hotfix;

		// Token: 0x020008DC RID: 2268
		public new class LuaExportHelper
		{
			// Token: 0x06007606 RID: 30214 RVA: 0x00204FF0 File Offset: 0x002031F0
			public LuaExportHelper(RealTimePVPComponent owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06007607 RID: 30215 RVA: 0x00205000 File Offset: 0x00203200
			public string __callBase_GetName()
			{
				return this.m_owner.__callBase_GetName();
			}

			// Token: 0x06007608 RID: 30216 RVA: 0x00205010 File Offset: 0x00203210
			public void __callBase_Init()
			{
				this.m_owner.__callBase_Init();
			}

			// Token: 0x06007609 RID: 30217 RVA: 0x00205020 File Offset: 0x00203220
			public void __callBase_PostInit()
			{
				this.m_owner.__callBase_PostInit();
			}

			// Token: 0x0600760A RID: 30218 RVA: 0x00205030 File Offset: 0x00203230
			public void __callBase_DeInit()
			{
				this.m_owner.__callBase_DeInit();
			}

			// Token: 0x0600760B RID: 30219 RVA: 0x00205040 File Offset: 0x00203240
			public void __callBase_Tick(uint deltaMillisecond)
			{
				this.m_owner.__callBase_Tick(deltaMillisecond);
			}

			// Token: 0x0600760C RID: 30220 RVA: 0x00205050 File Offset: 0x00203250
			public void __callBase_PostDeSerialize()
			{
				this.m_owner.__callBase_PostDeSerialize();
			}

			// Token: 0x0600760D RID: 30221 RVA: 0x00205060 File Offset: 0x00203260
			public void __callBase_RealTimeArenaDanUpdate(int dan)
			{
				this.m_owner.__callBase_RealTimeArenaDanUpdate(dan);
			}

			// Token: 0x0600760E RID: 30222 RVA: 0x00205070 File Offset: 0x00203270
			public void __callBase_RealTimeArenaBattleFinish(BattleMode mode, bool win)
			{
				this.m_owner.__callBase_RealTimeArenaBattleFinish(mode, win);
			}

			// Token: 0x0600760F RID: 30223 RVA: 0x00205080 File Offset: 0x00203280
			public void __callBase_RealTimeArenaBattleStart(BattleMode mode)
			{
				this.m_owner.__callBase_RealTimeArenaBattleStart(mode);
			}

			// Token: 0x06007610 RID: 30224 RVA: 0x00205090 File Offset: 0x00203290
			public int __callBase_IsRealTimePVPUnlocked()
			{
				return this.m_owner.__callBase_IsRealTimePVPUnlocked();
			}

			// Token: 0x06007611 RID: 30225 RVA: 0x002050A0 File Offset: 0x002032A0
			public int __callBase_IsRealTimePVPArenaAvailable(BattleMode Mode)
			{
				return this.m_owner.__callBase_IsRealTimePVPArenaAvailable(Mode);
			}

			// Token: 0x06007612 RID: 30226 RVA: 0x002050B0 File Offset: 0x002032B0
			public void __callBase_OnFlushRealTimePVP()
			{
				this.m_owner.__callBase_OnFlushRealTimePVP();
			}

			// Token: 0x06007613 RID: 30227 RVA: 0x002050C0 File Offset: 0x002032C0
			public void __callBase_StartNewSeason()
			{
				this.m_owner.__callBase_StartNewSeason();
			}

			// Token: 0x06007614 RID: 30228 RVA: 0x002050D0 File Offset: 0x002032D0
			public bool __callBase_IsPromotion()
			{
				return this.m_owner.__callBase_IsPromotion();
			}

			// Token: 0x06007615 RID: 30229 RVA: 0x002050E0 File Offset: 0x002032E0
			public LinkedList<RealTimePVPBattleReport> __callBase_GetPromotionBattleReports()
			{
				return this.m_owner.__callBase_GetPromotionBattleReports();
			}

			// Token: 0x06007616 RID: 30230 RVA: 0x002050F0 File Offset: 0x002032F0
			public LinkedList<RealTimePVPBattleReport> __callBase_GetBattleReports()
			{
				return this.m_owner.__callBase_GetBattleReports();
			}

			// Token: 0x06007617 RID: 30231 RVA: 0x00205100 File Offset: 0x00203300
			public void __callBase_StartPromotion()
			{
				this.m_owner.__callBase_StartPromotion();
			}

			// Token: 0x06007618 RID: 30232 RVA: 0x00205110 File Offset: 0x00203310
			public void __callBase_EndPromotion()
			{
				this.m_owner.__callBase_EndPromotion();
			}

			// Token: 0x06007619 RID: 30233 RVA: 0x00205120 File Offset: 0x00203320
			public void __callBase_SavePromotionReport(RealTimePVPBattleReport Report)
			{
				this.m_owner.__callBase_SavePromotionReport(Report);
			}

			// Token: 0x0600761A RID: 30234 RVA: 0x00205130 File Offset: 0x00203330
			public void __callBase_SaveReport(RealTimePVPBattleReport Report)
			{
				this.m_owner.__callBase_SaveReport(Report);
			}

			// Token: 0x0600761B RID: 30235 RVA: 0x00205140 File Offset: 0x00203340
			public int __callBase_CheckAcquireWinsBonus(int BonusId)
			{
				return this.m_owner.__callBase_CheckAcquireWinsBonus(BonusId);
			}

			// Token: 0x0600761C RID: 30236 RVA: 0x00205150 File Offset: 0x00203350
			public int __callBase_AcquireWinsBonus(int BonusId)
			{
				return this.m_owner.__callBase_AcquireWinsBonus(BonusId);
			}

			// Token: 0x0600761D RID: 30237 RVA: 0x00205160 File Offset: 0x00203360
			public int __callBase_GetConsecutiveWins(BattleMode Mode)
			{
				return this.m_owner.__callBase_GetConsecutiveWins(Mode);
			}

			// Token: 0x0600761E RID: 30238 RVA: 0x00205170 File Offset: 0x00203370
			public int __callBase_GetConsecutiveLosses(BattleMode Mode)
			{
				return this.m_owner.__callBase_GetConsecutiveLosses(Mode);
			}

			// Token: 0x0600761F RID: 30239 RVA: 0x00205180 File Offset: 0x00203380
			public RealTimePVPMatchStats __callBase_GetLadderCareerMatchStats()
			{
				return this.m_owner.__callBase_GetLadderCareerMatchStats();
			}

			// Token: 0x06007620 RID: 30240 RVA: 0x00205190 File Offset: 0x00203390
			public bool __callBase_TryGetBotParamsForNovice(BattleMode Mode, int MyScore, out int LevelMin, out int LevelMax, out int ScoreMin, out int ScoreMax)
			{
				return this.m_owner.__callBase_TryGetBotParamsForNovice(Mode, MyScore, out LevelMin, out LevelMax, out ScoreMin, out ScoreMax);
			}

			// Token: 0x06007621 RID: 30241 RVA: 0x002051A8 File Offset: 0x002033A8
			public bool __callBase_TryGetBotParamsForLoser(BattleMode Mode, int MyScore, int Dan, out int LevelMin, out int LevelMax, out int ScoreMin, out int ScoreMax)
			{
				return this.m_owner.__callBase_TryGetBotParamsForLoser(Mode, MyScore, Dan, out LevelMin, out LevelMax, out ScoreMin, out ScoreMax);
			}

			// Token: 0x040055FA RID: 22010
			private RealTimePVPComponent m_owner;
		}
	}
}
