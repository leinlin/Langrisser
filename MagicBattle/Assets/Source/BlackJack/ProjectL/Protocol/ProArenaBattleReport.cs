using System;
using System.Collections.Generic;
using System.ComponentModel;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000660 RID: 1632
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ProArenaBattleReport")]
	[Serializable]
	public class ProArenaBattleReport : IExtensible
	{
		// Token: 0x06005907 RID: 22791 RVA: 0x0019C914 File Offset: 0x0019AB14
		public ProArenaBattleReport()
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

		// Token: 0x17001633 RID: 5683
		// (get) Token: 0x06005908 RID: 22792 RVA: 0x0019C9E0 File Offset: 0x0019ABE0
		// (set) Token: 0x06005909 RID: 22793 RVA: 0x0019C9E8 File Offset: 0x0019ABE8
		[DefaultValue(0)]
		[ProtoMember(1, IsRequired = false, Name = "Version", DataFormat = DataFormat.TwosComplement)]
		public int Version
		{
			get
			{
				return this._Version;
			}
			set
			{
				this._Version = value;
			}
		}

		// Token: 0x17001634 RID: 5684
		// (get) Token: 0x0600590A RID: 22794 RVA: 0x0019C9F4 File Offset: 0x0019ABF4
		// (set) Token: 0x0600590B RID: 22795 RVA: 0x0019C9FC File Offset: 0x0019ABFC
		[DefaultValue(0f)]
		[ProtoMember(2, IsRequired = false, Name = "InstanceId", DataFormat = DataFormat.TwosComplement)]
		public ulong InstanceId
		{
			get
			{
				return this._InstanceId;
			}
			set
			{
				this._InstanceId = value;
			}
		}

		// Token: 0x17001635 RID: 5685
		// (get) Token: 0x0600590C RID: 22796 RVA: 0x0019CA08 File Offset: 0x0019AC08
		// (set) Token: 0x0600590D RID: 22797 RVA: 0x0019CA10 File Offset: 0x0019AC10
		[ProtoMember(3, IsRequired = false, Name = "BattleType", DataFormat = DataFormat.TwosComplement)]
		[DefaultValue(0)]
		public int BattleType
		{
			get
			{
				return this._BattleType;
			}
			set
			{
				this._BattleType = value;
			}
		}

		// Token: 0x17001636 RID: 5686
		// (get) Token: 0x0600590E RID: 22798 RVA: 0x0019CA1C File Offset: 0x0019AC1C
		// (set) Token: 0x0600590F RID: 22799 RVA: 0x0019CA24 File Offset: 0x0019AC24
		[ProtoMember(4, IsRequired = false, Name = "BattleId", DataFormat = DataFormat.TwosComplement)]
		[DefaultValue(0)]
		public int BattleId
		{
			get
			{
				return this._BattleId;
			}
			set
			{
				this._BattleId = value;
			}
		}

		// Token: 0x17001637 RID: 5687
		// (get) Token: 0x06005910 RID: 22800 RVA: 0x0019CA30 File Offset: 0x0019AC30
		// (set) Token: 0x06005911 RID: 22801 RVA: 0x0019CA38 File Offset: 0x0019AC38
		[ProtoMember(5, IsRequired = false, Name = "RandomSeed", DataFormat = DataFormat.TwosComplement)]
		[DefaultValue(0)]
		public int RandomSeed
		{
			get
			{
				return this._RandomSeed;
			}
			set
			{
				this._RandomSeed = value;
			}
		}

		// Token: 0x17001638 RID: 5688
		// (get) Token: 0x06005912 RID: 22802 RVA: 0x0019CA44 File Offset: 0x0019AC44
		[ProtoMember(6, Name = "Commands", DataFormat = DataFormat.Default)]
		public List<ProBattleCommand> Commands
		{
			get
			{
				return this._Commands;
			}
		}

		// Token: 0x17001639 RID: 5689
		// (get) Token: 0x06005913 RID: 22803 RVA: 0x0019CA4C File Offset: 0x0019AC4C
		// (set) Token: 0x06005914 RID: 22804 RVA: 0x0019CA54 File Offset: 0x0019AC54
		[DefaultValue(0)]
		[ProtoMember(7, IsRequired = false, Name = "Status", DataFormat = DataFormat.TwosComplement)]
		public int Status
		{
			get
			{
				return this._Status;
			}
			set
			{
				this._Status = value;
			}
		}

		// Token: 0x1700163A RID: 5690
		// (get) Token: 0x06005915 RID: 22805 RVA: 0x0019CA60 File Offset: 0x0019AC60
		// (set) Token: 0x06005916 RID: 22806 RVA: 0x0019CA68 File Offset: 0x0019AC68
		[ProtoMember(8, IsRequired = false, Name = "ArenaDefenderRuleId", DataFormat = DataFormat.TwosComplement)]
		[DefaultValue(0)]
		public int ArenaDefenderRuleId
		{
			get
			{
				return this._ArenaDefenderRuleId;
			}
			set
			{
				this._ArenaDefenderRuleId = value;
			}
		}

		// Token: 0x1700163B RID: 5691
		// (get) Token: 0x06005917 RID: 22807 RVA: 0x0019CA74 File Offset: 0x0019AC74
		// (set) Token: 0x06005918 RID: 22808 RVA: 0x0019CA7C File Offset: 0x0019AC7C
		[ProtoMember(9, IsRequired = false, Name = "DefenderUserId", DataFormat = DataFormat.Default)]
		[DefaultValue("")]
		public string DefenderUserId
		{
			get
			{
				return this._DefenderUserId;
			}
			set
			{
				this._DefenderUserId = value;
			}
		}

		// Token: 0x1700163C RID: 5692
		// (get) Token: 0x06005919 RID: 22809 RVA: 0x0019CA88 File Offset: 0x0019AC88
		// (set) Token: 0x0600591A RID: 22810 RVA: 0x0019CA90 File Offset: 0x0019AC90
		[ProtoMember(10, IsRequired = false, Name = "DefenderName", DataFormat = DataFormat.Default)]
		[DefaultValue("")]
		public string DefenderName
		{
			get
			{
				return this._DefenderName;
			}
			set
			{
				this._DefenderName = value;
			}
		}

		// Token: 0x1700163D RID: 5693
		// (get) Token: 0x0600591B RID: 22811 RVA: 0x0019CA9C File Offset: 0x0019AC9C
		// (set) Token: 0x0600591C RID: 22812 RVA: 0x0019CAA4 File Offset: 0x0019ACA4
		[ProtoMember(11, IsRequired = false, Name = "DefenderLevel", DataFormat = DataFormat.TwosComplement)]
		[DefaultValue(0)]
		public int DefenderLevel
		{
			get
			{
				return this._DefenderLevel;
			}
			set
			{
				this._DefenderLevel = value;
			}
		}

		// Token: 0x1700163E RID: 5694
		// (get) Token: 0x0600591D RID: 22813 RVA: 0x0019CAB0 File Offset: 0x0019ACB0
		[ProtoMember(12, Name = "DefenderHeroes", DataFormat = DataFormat.Default)]
		public List<ProBattleHero> DefenderHeroes
		{
			get
			{
				return this._DefenderHeroes;
			}
		}

		// Token: 0x1700163F RID: 5695
		// (get) Token: 0x0600591E RID: 22814 RVA: 0x0019CAB8 File Offset: 0x0019ACB8
		// (set) Token: 0x0600591F RID: 22815 RVA: 0x0019CAC0 File Offset: 0x0019ACC0
		[DefaultValue("")]
		[ProtoMember(13, IsRequired = false, Name = "AttackerUserId", DataFormat = DataFormat.Default)]
		public string AttackerUserId
		{
			get
			{
				return this._AttackerUserId;
			}
			set
			{
				this._AttackerUserId = value;
			}
		}

		// Token: 0x17001640 RID: 5696
		// (get) Token: 0x06005920 RID: 22816 RVA: 0x0019CACC File Offset: 0x0019ACCC
		// (set) Token: 0x06005921 RID: 22817 RVA: 0x0019CAD4 File Offset: 0x0019ACD4
		[ProtoMember(14, IsRequired = false, Name = "AttackerName", DataFormat = DataFormat.Default)]
		[DefaultValue("")]
		public string AttackerName
		{
			get
			{
				return this._AttackerName;
			}
			set
			{
				this._AttackerName = value;
			}
		}

		// Token: 0x17001641 RID: 5697
		// (get) Token: 0x06005922 RID: 22818 RVA: 0x0019CAE0 File Offset: 0x0019ACE0
		// (set) Token: 0x06005923 RID: 22819 RVA: 0x0019CAE8 File Offset: 0x0019ACE8
		[ProtoMember(15, IsRequired = false, Name = "AttackerLevel", DataFormat = DataFormat.TwosComplement)]
		[DefaultValue(0)]
		public int AttackerLevel
		{
			get
			{
				return this._AttackerLevel;
			}
			set
			{
				this._AttackerLevel = value;
			}
		}

		// Token: 0x17001642 RID: 5698
		// (get) Token: 0x06005924 RID: 22820 RVA: 0x0019CAF4 File Offset: 0x0019ACF4
		[ProtoMember(16, Name = "AttackerHeroes", DataFormat = DataFormat.Default)]
		public List<ProBattleHero> AttackerHeroes
		{
			get
			{
				return this._AttackerHeroes;
			}
		}

		// Token: 0x17001643 RID: 5699
		// (get) Token: 0x06005925 RID: 22821 RVA: 0x0019CAFC File Offset: 0x0019ACFC
		// (set) Token: 0x06005926 RID: 22822 RVA: 0x0019CB04 File Offset: 0x0019AD04
		[DefaultValue(0)]
		[ProtoMember(17, IsRequired = false, Name = "AttackerGotArenaPoints", DataFormat = DataFormat.TwosComplement)]
		public int AttackerGotArenaPoints
		{
			get
			{
				return this._AttackerGotArenaPoints;
			}
			set
			{
				this._AttackerGotArenaPoints = value;
			}
		}

		// Token: 0x17001644 RID: 5700
		// (get) Token: 0x06005927 RID: 22823 RVA: 0x0019CB10 File Offset: 0x0019AD10
		// (set) Token: 0x06005928 RID: 22824 RVA: 0x0019CB18 File Offset: 0x0019AD18
		[DefaultValue(0)]
		[ProtoMember(18, IsRequired = false, Name = "DefenderGotArenaPoints", DataFormat = DataFormat.TwosComplement)]
		public int DefenderGotArenaPoints
		{
			get
			{
				return this._DefenderGotArenaPoints;
			}
			set
			{
				this._DefenderGotArenaPoints = value;
			}
		}

		// Token: 0x17001645 RID: 5701
		// (get) Token: 0x06005929 RID: 22825 RVA: 0x0019CB24 File Offset: 0x0019AD24
		// (set) Token: 0x0600592A RID: 22826 RVA: 0x0019CB2C File Offset: 0x0019AD2C
		[DefaultValue(0L)]
		[ProtoMember(19, IsRequired = false, Name = "CreateTime", DataFormat = DataFormat.TwosComplement)]
		public long CreateTime
		{
			get
			{
				return this._CreateTime;
			}
			set
			{
				this._CreateTime = value;
			}
		}

		// Token: 0x17001646 RID: 5702
		// (get) Token: 0x0600592B RID: 22827 RVA: 0x0019CB38 File Offset: 0x0019AD38
		// (set) Token: 0x0600592C RID: 22828 RVA: 0x0019CB40 File Offset: 0x0019AD40
		[ProtoMember(20, IsRequired = false, Name = "OpponentHeadIcon", DataFormat = DataFormat.TwosComplement)]
		[DefaultValue(0)]
		public int OpponentHeadIcon
		{
			get
			{
				return this._OpponentHeadIcon;
			}
			set
			{
				this._OpponentHeadIcon = value;
			}
		}

		// Token: 0x17001647 RID: 5703
		// (get) Token: 0x0600592D RID: 22829 RVA: 0x0019CB4C File Offset: 0x0019AD4C
		[ProtoMember(21, Name = "DefenderTechs", DataFormat = DataFormat.Default)]
		public List<ProTrainingTech> DefenderTechs
		{
			get
			{
				return this._DefenderTechs;
			}
		}

		// Token: 0x17001648 RID: 5704
		// (get) Token: 0x0600592E RID: 22830 RVA: 0x0019CB54 File Offset: 0x0019AD54
		[ProtoMember(22, Name = "AttackerTechs", DataFormat = DataFormat.Default)]
		public List<ProTrainingTech> AttackerTechs
		{
			get
			{
				return this._AttackerTechs;
			}
		}

		// Token: 0x0600592F RID: 22831 RVA: 0x0019CB5C File Offset: 0x0019AD5C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005930 RID: 22832 RVA: 0x0019CB6C File Offset: 0x0019AD6C
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

		// Token: 0x06005931 RID: 22833 RVA: 0x0019CC38 File Offset: 0x0019AE38
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ProArenaBattleReport));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040042C9 RID: 17097
		private int _Version;

		// Token: 0x040042CA RID: 17098
		private ulong _InstanceId;

		// Token: 0x040042CB RID: 17099
		private int _BattleType;

		// Token: 0x040042CC RID: 17100
		private int _BattleId;

		// Token: 0x040042CD RID: 17101
		private int _RandomSeed;

		// Token: 0x040042CE RID: 17102
		private readonly List<ProBattleCommand> _Commands = new List<ProBattleCommand>();

		// Token: 0x040042CF RID: 17103
		private int _Status;

		// Token: 0x040042D0 RID: 17104
		private int _ArenaDefenderRuleId;

		// Token: 0x040042D1 RID: 17105
		private string _DefenderUserId = string.Empty;

		// Token: 0x040042D2 RID: 17106
		private string _DefenderName = string.Empty;

		// Token: 0x040042D3 RID: 17107
		private int _DefenderLevel;

		// Token: 0x040042D4 RID: 17108
		private readonly List<ProBattleHero> _DefenderHeroes = new List<ProBattleHero>();

		// Token: 0x040042D5 RID: 17109
		private string _AttackerUserId = string.Empty;

		// Token: 0x040042D6 RID: 17110
		private string _AttackerName = string.Empty;

		// Token: 0x040042D7 RID: 17111
		private int _AttackerLevel;

		// Token: 0x040042D8 RID: 17112
		private readonly List<ProBattleHero> _AttackerHeroes = new List<ProBattleHero>();

		// Token: 0x040042D9 RID: 17113
		private int _AttackerGotArenaPoints;

		// Token: 0x040042DA RID: 17114
		private int _DefenderGotArenaPoints;

		// Token: 0x040042DB RID: 17115
		private long _CreateTime;

		// Token: 0x040042DC RID: 17116
		private int _OpponentHeadIcon;

		// Token: 0x040042DD RID: 17117
		private readonly List<ProTrainingTech> _DefenderTechs = new List<ProTrainingTech>();

		// Token: 0x040042DE RID: 17118
		private readonly List<ProTrainingTech> _AttackerTechs = new List<ProTrainingTech>();

		// Token: 0x040042DF RID: 17119
		private IExtension extensionObject;

		// Token: 0x040042E0 RID: 17120
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040042E1 RID: 17121
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040042E2 RID: 17122
		private LuaFunction m_ctor_hotfix;
	}
}
