using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x02000278 RID: 632
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ConfigDataRealTimePVPDanInfo")]
	[Serializable]
	public class ConfigDataRealTimePVPDanInfo : IExtensible
	{
		// Token: 0x06002889 RID: 10377 RVA: 0x000AE388 File Offset: 0x000AC588
		public ConfigDataRealTimePVPDanInfo()
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

		// Token: 0x17000A9A RID: 2714
		// (get) Token: 0x0600288A RID: 10378 RVA: 0x000AE43C File Offset: 0x000AC63C
		// (set) Token: 0x0600288B RID: 10379 RVA: 0x000AE444 File Offset: 0x000AC644
		[ProtoMember(2, IsRequired = true, Name = "ID", DataFormat = DataFormat.TwosComplement)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				this._ID = value;
			}
		}

		// Token: 0x17000A9B RID: 2715
		// (get) Token: 0x0600288C RID: 10380 RVA: 0x000AE450 File Offset: 0x000AC650
		// (set) Token: 0x0600288D RID: 10381 RVA: 0x000AE458 File Offset: 0x000AC658
		[ProtoMember(3, IsRequired = true, Name = "Name", DataFormat = DataFormat.Default)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				this._Name = value;
			}
		}

		// Token: 0x17000A9C RID: 2716
		// (get) Token: 0x0600288E RID: 10382 RVA: 0x000AE464 File Offset: 0x000AC664
		// (set) Token: 0x0600288F RID: 10383 RVA: 0x000AE46C File Offset: 0x000AC66C
		[ProtoMember(4, IsRequired = true, Name = "NameStrKey", DataFormat = DataFormat.Default)]
		public string NameStrKey
		{
			get
			{
				return this._NameStrKey;
			}
			set
			{
				this._NameStrKey = value;
			}
		}

		// Token: 0x17000A9D RID: 2717
		// (get) Token: 0x06002890 RID: 10384 RVA: 0x000AE478 File Offset: 0x000AC678
		// (set) Token: 0x06002891 RID: 10385 RVA: 0x000AE480 File Offset: 0x000AC680
		[ProtoMember(5, IsRequired = true, Name = "BPRule", DataFormat = DataFormat.TwosComplement)]
		public int BPRule
		{
			get
			{
				return this._BPRule;
			}
			set
			{
				this._BPRule = value;
			}
		}

		// Token: 0x17000A9E RID: 2718
		// (get) Token: 0x06002892 RID: 10386 RVA: 0x000AE48C File Offset: 0x000AC68C
		// (set) Token: 0x06002893 RID: 10387 RVA: 0x000AE494 File Offset: 0x000AC694
		[ProtoMember(6, IsRequired = true, Name = "RelegationScore", DataFormat = DataFormat.TwosComplement)]
		public int RelegationScore
		{
			get
			{
				return this._RelegationScore;
			}
			set
			{
				this._RelegationScore = value;
			}
		}

		// Token: 0x17000A9F RID: 2719
		// (get) Token: 0x06002894 RID: 10388 RVA: 0x000AE4A0 File Offset: 0x000AC6A0
		// (set) Token: 0x06002895 RID: 10389 RVA: 0x000AE4A8 File Offset: 0x000AC6A8
		[ProtoMember(7, IsRequired = true, Name = "PromotionScore", DataFormat = DataFormat.TwosComplement)]
		public int PromotionScore
		{
			get
			{
				return this._PromotionScore;
			}
			set
			{
				this._PromotionScore = value;
			}
		}

		// Token: 0x17000AA0 RID: 2720
		// (get) Token: 0x06002896 RID: 10390 RVA: 0x000AE4B4 File Offset: 0x000AC6B4
		// (set) Token: 0x06002897 RID: 10391 RVA: 0x000AE4BC File Offset: 0x000AC6BC
		[ProtoMember(8, IsRequired = true, Name = "PostSeasonScoreDecrease", DataFormat = DataFormat.TwosComplement)]
		public int PostSeasonScoreDecrease
		{
			get
			{
				return this._PostSeasonScoreDecrease;
			}
			set
			{
				this._PostSeasonScoreDecrease = value;
			}
		}

		// Token: 0x17000AA1 RID: 2721
		// (get) Token: 0x06002898 RID: 10392 RVA: 0x000AE4C8 File Offset: 0x000AC6C8
		[ProtoMember(9, Name = "ConsecutiveWinScoreBonus", DataFormat = DataFormat.Default)]
		public List<RealTimePVPConsecutiveWins> ConsecutiveWinScoreBonus
		{
			get
			{
				return this._ConsecutiveWinScoreBonus;
			}
		}

		// Token: 0x17000AA2 RID: 2722
		// (get) Token: 0x06002899 RID: 10393 RVA: 0x000AE4D0 File Offset: 0x000AC6D0
		[ProtoMember(10, Name = "ConsecutiveLossScoreProtection", DataFormat = DataFormat.Default)]
		public List<RealTimePVPConsecutiveLosses> ConsecutiveLossScoreProtection
		{
			get
			{
				return this._ConsecutiveLossScoreProtection;
			}
		}

		// Token: 0x17000AA3 RID: 2723
		// (get) Token: 0x0600289A RID: 10394 RVA: 0x000AE4D8 File Offset: 0x000AC6D8
		// (set) Token: 0x0600289B RID: 10395 RVA: 0x000AE4E0 File Offset: 0x000AC6E0
		[ProtoMember(11, IsRequired = true, Name = "WinBasicScore", DataFormat = DataFormat.TwosComplement)]
		public int WinBasicScore
		{
			get
			{
				return this._WinBasicScore;
			}
			set
			{
				this._WinBasicScore = value;
			}
		}

		// Token: 0x17000AA4 RID: 2724
		// (get) Token: 0x0600289C RID: 10396 RVA: 0x000AE4EC File Offset: 0x000AC6EC
		// (set) Token: 0x0600289D RID: 10397 RVA: 0x000AE4F4 File Offset: 0x000AC6F4
		[ProtoMember(12, IsRequired = true, Name = "DanDiffUpperBound", DataFormat = DataFormat.TwosComplement)]
		public int DanDiffUpperBound
		{
			get
			{
				return this._DanDiffUpperBound;
			}
			set
			{
				this._DanDiffUpperBound = value;
			}
		}

		// Token: 0x17000AA5 RID: 2725
		// (get) Token: 0x0600289E RID: 10398 RVA: 0x000AE500 File Offset: 0x000AC700
		// (set) Token: 0x0600289F RID: 10399 RVA: 0x000AE508 File Offset: 0x000AC708
		[ProtoMember(13, IsRequired = true, Name = "DanDiffLowerBound", DataFormat = DataFormat.TwosComplement)]
		public int DanDiffLowerBound
		{
			get
			{
				return this._DanDiffLowerBound;
			}
			set
			{
				this._DanDiffLowerBound = value;
			}
		}

		// Token: 0x17000AA6 RID: 2726
		// (get) Token: 0x060028A0 RID: 10400 RVA: 0x000AE514 File Offset: 0x000AC714
		[ProtoMember(14, Name = "WaitingTimeAdjustment", DataFormat = DataFormat.Default)]
		public List<WaitingTimeInfo> WaitingTimeAdjustment
		{
			get
			{
				return this._WaitingTimeAdjustment;
			}
		}

		// Token: 0x17000AA7 RID: 2727
		// (get) Token: 0x060028A1 RID: 10401 RVA: 0x000AE51C File Offset: 0x000AC71C
		[ProtoMember(15, Name = "ConsecutiveWinsMatchmakingAdjustment", DataFormat = DataFormat.Default)]
		public List<RealTimePVPConsecutiveWinsMatchmakingInfo> ConsecutiveWinsMatchmakingAdjustment
		{
			get
			{
				return this._ConsecutiveWinsMatchmakingAdjustment;
			}
		}

		// Token: 0x17000AA8 RID: 2728
		// (get) Token: 0x060028A2 RID: 10402 RVA: 0x000AE524 File Offset: 0x000AC724
		[ProtoMember(16, Name = "ConsecutiveLossesMatchmakingAdjustment", DataFormat = DataFormat.Default)]
		public List<RealTimePVPConsecutiveLossesMatchmakingInfo> ConsecutiveLossesMatchmakingAdjustment
		{
			get
			{
				return this._ConsecutiveLossesMatchmakingAdjustment;
			}
		}

		// Token: 0x17000AA9 RID: 2729
		// (get) Token: 0x060028A3 RID: 10403 RVA: 0x000AE52C File Offset: 0x000AC72C
		[ProtoMember(17, Name = "MatchmakingFailAdjustment", DataFormat = DataFormat.Default)]
		public List<RealTimePVPMatchmakingFailInfo> MatchmakingFailAdjustment
		{
			get
			{
				return this._MatchmakingFailAdjustment;
			}
		}

		// Token: 0x17000AAA RID: 2730
		// (get) Token: 0x060028A4 RID: 10404 RVA: 0x000AE534 File Offset: 0x000AC734
		// (set) Token: 0x060028A5 RID: 10405 RVA: 0x000AE53C File Offset: 0x000AC73C
		[ProtoMember(18, IsRequired = true, Name = "PromotionChallengeCount", DataFormat = DataFormat.TwosComplement)]
		public int PromotionChallengeCount
		{
			get
			{
				return this._PromotionChallengeCount;
			}
			set
			{
				this._PromotionChallengeCount = value;
			}
		}

		// Token: 0x17000AAB RID: 2731
		// (get) Token: 0x060028A6 RID: 10406 RVA: 0x000AE548 File Offset: 0x000AC748
		// (set) Token: 0x060028A7 RID: 10407 RVA: 0x000AE550 File Offset: 0x000AC750
		[ProtoMember(19, IsRequired = true, Name = "PromotionChallengeWinsRequired", DataFormat = DataFormat.TwosComplement)]
		public int PromotionChallengeWinsRequired
		{
			get
			{
				return this._PromotionChallengeWinsRequired;
			}
			set
			{
				this._PromotionChallengeWinsRequired = value;
			}
		}

		// Token: 0x17000AAC RID: 2732
		// (get) Token: 0x060028A8 RID: 10408 RVA: 0x000AE55C File Offset: 0x000AC75C
		// (set) Token: 0x060028A9 RID: 10409 RVA: 0x000AE564 File Offset: 0x000AC764
		[ProtoMember(20, IsRequired = true, Name = "Icon", DataFormat = DataFormat.Default)]
		public string Icon
		{
			get
			{
				return this._Icon;
			}
			set
			{
				this._Icon = value;
			}
		}

		// Token: 0x17000AAD RID: 2733
		// (get) Token: 0x060028AA RID: 10410 RVA: 0x000AE570 File Offset: 0x000AC770
		[ProtoMember(21, Name = "FriendlyWaitingTimeAdjustment", DataFormat = DataFormat.Default)]
		public List<FriendlyWaitingTimeInfo> FriendlyWaitingTimeAdjustment
		{
			get
			{
				return this._FriendlyWaitingTimeAdjustment;
			}
		}

		// Token: 0x17000AAE RID: 2734
		// (get) Token: 0x060028AB RID: 10411 RVA: 0x000AE578 File Offset: 0x000AC778
		// (set) Token: 0x060028AC RID: 10412 RVA: 0x000AE580 File Offset: 0x000AC780
		[ProtoMember(26, IsRequired = true, Name = "LossBasicScore", DataFormat = DataFormat.TwosComplement)]
		public int LossBasicScore
		{
			get
			{
				return this._LossBasicScore;
			}
			set
			{
				this._LossBasicScore = value;
			}
		}

		// Token: 0x060028AD RID: 10413 RVA: 0x000AE58C File Offset: 0x000AC78C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060028AE RID: 10414 RVA: 0x000AE59C File Offset: 0x000AC79C
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
					result = true;
				}
			}
			return result;
		}

		// Token: 0x060028AF RID: 10415 RVA: 0x000AE668 File Offset: 0x000AC868
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataRealTimePVPDanInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040018E9 RID: 6377
		private int _ID;

		// Token: 0x040018EA RID: 6378
		private string _Name;

		// Token: 0x040018EB RID: 6379
		private string _NameStrKey;

		// Token: 0x040018EC RID: 6380
		private int _BPRule;

		// Token: 0x040018ED RID: 6381
		private int _RelegationScore;

		// Token: 0x040018EE RID: 6382
		private int _PromotionScore;

		// Token: 0x040018EF RID: 6383
		private int _PostSeasonScoreDecrease;

		// Token: 0x040018F0 RID: 6384
		private readonly List<RealTimePVPConsecutiveWins> _ConsecutiveWinScoreBonus = new List<RealTimePVPConsecutiveWins>();

		// Token: 0x040018F1 RID: 6385
		private readonly List<RealTimePVPConsecutiveLosses> _ConsecutiveLossScoreProtection = new List<RealTimePVPConsecutiveLosses>();

		// Token: 0x040018F2 RID: 6386
		private int _WinBasicScore;

		// Token: 0x040018F3 RID: 6387
		private int _DanDiffUpperBound;

		// Token: 0x040018F4 RID: 6388
		private int _DanDiffLowerBound;

		// Token: 0x040018F5 RID: 6389
		private readonly List<WaitingTimeInfo> _WaitingTimeAdjustment = new List<WaitingTimeInfo>();

		// Token: 0x040018F6 RID: 6390
		private readonly List<RealTimePVPConsecutiveWinsMatchmakingInfo> _ConsecutiveWinsMatchmakingAdjustment = new List<RealTimePVPConsecutiveWinsMatchmakingInfo>();

		// Token: 0x040018F7 RID: 6391
		private readonly List<RealTimePVPConsecutiveLossesMatchmakingInfo> _ConsecutiveLossesMatchmakingAdjustment = new List<RealTimePVPConsecutiveLossesMatchmakingInfo>();

		// Token: 0x040018F8 RID: 6392
		private readonly List<RealTimePVPMatchmakingFailInfo> _MatchmakingFailAdjustment = new List<RealTimePVPMatchmakingFailInfo>();

		// Token: 0x040018F9 RID: 6393
		private int _PromotionChallengeCount;

		// Token: 0x040018FA RID: 6394
		private int _PromotionChallengeWinsRequired;

		// Token: 0x040018FB RID: 6395
		private string _Icon;

		// Token: 0x040018FC RID: 6396
		private readonly List<FriendlyWaitingTimeInfo> _FriendlyWaitingTimeAdjustment = new List<FriendlyWaitingTimeInfo>();

		// Token: 0x040018FD RID: 6397
		private int _LossBasicScore;

		// Token: 0x040018FE RID: 6398
		private IExtension extensionObject;

		// Token: 0x040018FF RID: 6399
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04001900 RID: 6400
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04001901 RID: 6401
		private LuaFunction m_ctor_hotfix;
	}
}
