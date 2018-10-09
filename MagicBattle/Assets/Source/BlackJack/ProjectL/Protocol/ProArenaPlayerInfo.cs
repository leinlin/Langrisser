using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000661 RID: 1633
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ProArenaPlayerInfo")]
	[Serializable]
	public class ProArenaPlayerInfo : IExtensible
	{
		// Token: 0x06005932 RID: 22834 RVA: 0x0019CCA0 File Offset: 0x0019AEA0
		public ProArenaPlayerInfo()
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

		// Token: 0x17001649 RID: 5705
		// (get) Token: 0x06005933 RID: 22835 RVA: 0x0019CD28 File Offset: 0x0019AF28
		// (set) Token: 0x06005934 RID: 22836 RVA: 0x0019CD30 File Offset: 0x0019AF30
		[ProtoMember(1, IsRequired = true, Name = "DefensiveTeam", DataFormat = DataFormat.Default)]
		public ProArenaPlayerDefensiveTeam DefensiveTeam
		{
			get
			{
				return this._DefensiveTeam;
			}
			set
			{
				this._DefensiveTeam = value;
			}
		}

		// Token: 0x1700164A RID: 5706
		// (get) Token: 0x06005935 RID: 22837 RVA: 0x0019CD3C File Offset: 0x0019AF3C
		[ProtoMember(2, Name = "Opponents", DataFormat = DataFormat.Default)]
		public List<ProArenaOpponent> Opponents
		{
			get
			{
				return this._Opponents;
			}
		}

		// Token: 0x1700164B RID: 5707
		// (get) Token: 0x06005936 RID: 22838 RVA: 0x0019CD44 File Offset: 0x0019AF44
		// (set) Token: 0x06005937 RID: 22839 RVA: 0x0019CD4C File Offset: 0x0019AF4C
		[ProtoMember(3, IsRequired = true, Name = "ArenaLevelId", DataFormat = DataFormat.TwosComplement)]
		public int ArenaLevelId
		{
			get
			{
				return this._ArenaLevelId;
			}
			set
			{
				this._ArenaLevelId = value;
			}
		}

		// Token: 0x1700164C RID: 5708
		// (get) Token: 0x06005938 RID: 22840 RVA: 0x0019CD58 File Offset: 0x0019AF58
		// (set) Token: 0x06005939 RID: 22841 RVA: 0x0019CD60 File Offset: 0x0019AF60
		[ProtoMember(4, IsRequired = true, Name = "ArenaPoints", DataFormat = DataFormat.TwosComplement)]
		public int ArenaPoints
		{
			get
			{
				return this._ArenaPoints;
			}
			set
			{
				this._ArenaPoints = value;
			}
		}

		// Token: 0x1700164D RID: 5709
		// (get) Token: 0x0600593A RID: 22842 RVA: 0x0019CD6C File Offset: 0x0019AF6C
		// (set) Token: 0x0600593B RID: 22843 RVA: 0x0019CD74 File Offset: 0x0019AF74
		[ProtoMember(5, IsRequired = true, Name = "AttackedOpponent", DataFormat = DataFormat.Default)]
		public bool AttackedOpponent
		{
			get
			{
				return this._AttackedOpponent;
			}
			set
			{
				this._AttackedOpponent = value;
			}
		}

		// Token: 0x1700164E RID: 5710
		// (get) Token: 0x0600593C RID: 22844 RVA: 0x0019CD80 File Offset: 0x0019AF80
		// (set) Token: 0x0600593D RID: 22845 RVA: 0x0019CD88 File Offset: 0x0019AF88
		[ProtoMember(6, IsRequired = true, Name = "VictoryPoints", DataFormat = DataFormat.TwosComplement)]
		public int VictoryPoints
		{
			get
			{
				return this._VictoryPoints;
			}
			set
			{
				this._VictoryPoints = value;
			}
		}

		// Token: 0x1700164F RID: 5711
		// (get) Token: 0x0600593E RID: 22846 RVA: 0x0019CD94 File Offset: 0x0019AF94
		// (set) Token: 0x0600593F RID: 22847 RVA: 0x0019CD9C File Offset: 0x0019AF9C
		[ProtoMember(7, IsRequired = true, Name = "WeekLastFlushTime", DataFormat = DataFormat.TwosComplement)]
		public long WeekLastFlushTime
		{
			get
			{
				return this._WeekLastFlushTime;
			}
			set
			{
				this._WeekLastFlushTime = value;
			}
		}

		// Token: 0x17001650 RID: 5712
		// (get) Token: 0x06005940 RID: 22848 RVA: 0x0019CDA8 File Offset: 0x0019AFA8
		[ProtoMember(8, Name = "ReceivedVictoryPointsRewardIndexs", DataFormat = DataFormat.TwosComplement)]
		public List<int> ReceivedVictoryPointsRewardIndexs
		{
			get
			{
				return this._ReceivedVictoryPointsRewardIndexs;
			}
		}

		// Token: 0x17001651 RID: 5713
		// (get) Token: 0x06005941 RID: 22849 RVA: 0x0019CDB0 File Offset: 0x0019AFB0
		[ProtoMember(9, Name = "ThisWeekBattleIds", DataFormat = DataFormat.TwosComplement)]
		public List<int> ThisWeekBattleIds
		{
			get
			{
				return this._ThisWeekBattleIds;
			}
		}

		// Token: 0x17001652 RID: 5714
		// (get) Token: 0x06005942 RID: 22850 RVA: 0x0019CDB8 File Offset: 0x0019AFB8
		// (set) Token: 0x06005943 RID: 22851 RVA: 0x0019CDC0 File Offset: 0x0019AFC0
		[ProtoMember(10, IsRequired = true, Name = "ConsecutiveVictoryNums", DataFormat = DataFormat.TwosComplement)]
		public int ConsecutiveVictoryNums
		{
			get
			{
				return this._ConsecutiveVictoryNums;
			}
			set
			{
				this._ConsecutiveVictoryNums = value;
			}
		}

		// Token: 0x17001653 RID: 5715
		// (get) Token: 0x06005944 RID: 22852 RVA: 0x0019CDCC File Offset: 0x0019AFCC
		// (set) Token: 0x06005945 RID: 22853 RVA: 0x0019CDD4 File Offset: 0x0019AFD4
		[ProtoMember(11, IsRequired = true, Name = "ThisWeekTotalBattleNums", DataFormat = DataFormat.TwosComplement)]
		public int ThisWeekTotalBattleNums
		{
			get
			{
				return this._ThisWeekTotalBattleNums;
			}
			set
			{
				this._ThisWeekTotalBattleNums = value;
			}
		}

		// Token: 0x17001654 RID: 5716
		// (get) Token: 0x06005946 RID: 22854 RVA: 0x0019CDE0 File Offset: 0x0019AFE0
		// (set) Token: 0x06005947 RID: 22855 RVA: 0x0019CDE8 File Offset: 0x0019AFE8
		[ProtoMember(12, IsRequired = true, Name = "ThisWeekVictoryNums", DataFormat = DataFormat.TwosComplement)]
		public int ThisWeekVictoryNums
		{
			get
			{
				return this._ThisWeekVictoryNums;
			}
			set
			{
				this._ThisWeekVictoryNums = value;
			}
		}

		// Token: 0x17001655 RID: 5717
		// (get) Token: 0x06005948 RID: 22856 RVA: 0x0019CDF4 File Offset: 0x0019AFF4
		// (set) Token: 0x06005949 RID: 22857 RVA: 0x0019CDFC File Offset: 0x0019AFFC
		[ProtoMember(13, IsRequired = true, Name = "IsAutoBattle", DataFormat = DataFormat.Default)]
		public bool IsAutoBattle
		{
			get
			{
				return this._IsAutoBattle;
			}
			set
			{
				this._IsAutoBattle = value;
			}
		}

		// Token: 0x17001656 RID: 5718
		// (get) Token: 0x0600594A RID: 22858 RVA: 0x0019CE08 File Offset: 0x0019B008
		// (set) Token: 0x0600594B RID: 22859 RVA: 0x0019CE10 File Offset: 0x0019B010
		[ProtoMember(15, IsRequired = true, Name = "NextFlushOpponentTime", DataFormat = DataFormat.TwosComplement)]
		public long NextFlushOpponentTime
		{
			get
			{
				return this._NextFlushOpponentTime;
			}
			set
			{
				this._NextFlushOpponentTime = value;
			}
		}

		// Token: 0x0600594C RID: 22860 RVA: 0x0019CE1C File Offset: 0x0019B01C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x0600594D RID: 22861 RVA: 0x0019CE2C File Offset: 0x0019B02C
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

		// Token: 0x0600594E RID: 22862 RVA: 0x0019CEF8 File Offset: 0x0019B0F8
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ProArenaPlayerInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040042E3 RID: 17123
		private ProArenaPlayerDefensiveTeam _DefensiveTeam;

		// Token: 0x040042E4 RID: 17124
		private readonly List<ProArenaOpponent> _Opponents = new List<ProArenaOpponent>();

		// Token: 0x040042E5 RID: 17125
		private int _ArenaLevelId;

		// Token: 0x040042E6 RID: 17126
		private int _ArenaPoints;

		// Token: 0x040042E7 RID: 17127
		private bool _AttackedOpponent;

		// Token: 0x040042E8 RID: 17128
		private int _VictoryPoints;

		// Token: 0x040042E9 RID: 17129
		private long _WeekLastFlushTime;

		// Token: 0x040042EA RID: 17130
		private readonly List<int> _ReceivedVictoryPointsRewardIndexs = new List<int>();

		// Token: 0x040042EB RID: 17131
		private readonly List<int> _ThisWeekBattleIds = new List<int>();

		// Token: 0x040042EC RID: 17132
		private int _ConsecutiveVictoryNums;

		// Token: 0x040042ED RID: 17133
		private int _ThisWeekTotalBattleNums;

		// Token: 0x040042EE RID: 17134
		private int _ThisWeekVictoryNums;

		// Token: 0x040042EF RID: 17135
		private bool _IsAutoBattle;

		// Token: 0x040042F0 RID: 17136
		private long _NextFlushOpponentTime;

		// Token: 0x040042F1 RID: 17137
		private IExtension extensionObject;

		// Token: 0x040042F2 RID: 17138
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040042F3 RID: 17139
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040042F4 RID: 17140
		private LuaFunction m_ctor_hotfix;
	}
}
