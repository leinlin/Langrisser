using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x0200025F RID: 607
	[ProtoContract(Name = "ConfigDataMemoryCorridorLevelInfo")]
	[CustomLuaClass]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ConfigDataMemoryCorridorLevelInfo : IExtensible
	{
		// Token: 0x060026C0 RID: 9920 RVA: 0x000AAAD8 File Offset: 0x000A8CD8
		public ConfigDataMemoryCorridorLevelInfo()
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

		// Token: 0x170009DA RID: 2522
		// (get) Token: 0x060026C1 RID: 9921 RVA: 0x000AAB40 File Offset: 0x000A8D40
		// (set) Token: 0x060026C2 RID: 9922 RVA: 0x000AAB48 File Offset: 0x000A8D48
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

		// Token: 0x170009DB RID: 2523
		// (get) Token: 0x060026C3 RID: 9923 RVA: 0x000AAB54 File Offset: 0x000A8D54
		// (set) Token: 0x060026C4 RID: 9924 RVA: 0x000AAB5C File Offset: 0x000A8D5C
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

		// Token: 0x170009DC RID: 2524
		// (get) Token: 0x060026C5 RID: 9925 RVA: 0x000AAB68 File Offset: 0x000A8D68
		// (set) Token: 0x060026C6 RID: 9926 RVA: 0x000AAB70 File Offset: 0x000A8D70
		[ProtoMember(4, IsRequired = true, Name = "TeamName", DataFormat = DataFormat.Default)]
		public string TeamName
		{
			get
			{
				return this._TeamName;
			}
			set
			{
				this._TeamName = value;
			}
		}

		// Token: 0x170009DD RID: 2525
		// (get) Token: 0x060026C7 RID: 9927 RVA: 0x000AAB7C File Offset: 0x000A8D7C
		// (set) Token: 0x060026C8 RID: 9928 RVA: 0x000AAB84 File Offset: 0x000A8D84
		[ProtoMember(5, IsRequired = true, Name = "OpenPlayerLevel", DataFormat = DataFormat.TwosComplement)]
		public int OpenPlayerLevel
		{
			get
			{
				return this._OpenPlayerLevel;
			}
			set
			{
				this._OpenPlayerLevel = value;
			}
		}

		// Token: 0x170009DE RID: 2526
		// (get) Token: 0x060026C9 RID: 9929 RVA: 0x000AAB90 File Offset: 0x000A8D90
		// (set) Token: 0x060026CA RID: 9930 RVA: 0x000AAB98 File Offset: 0x000A8D98
		[ProtoMember(6, IsRequired = true, Name = "TicketCost", DataFormat = DataFormat.TwosComplement)]
		public int TicketCost
		{
			get
			{
				return this._TicketCost;
			}
			set
			{
				this._TicketCost = value;
			}
		}

		// Token: 0x170009DF RID: 2527
		// (get) Token: 0x060026CB RID: 9931 RVA: 0x000AABA4 File Offset: 0x000A8DA4
		// (set) Token: 0x060026CC RID: 9932 RVA: 0x000AABAC File Offset: 0x000A8DAC
		[ProtoMember(7, IsRequired = true, Name = "EnergySuccess", DataFormat = DataFormat.TwosComplement)]
		public int EnergySuccess
		{
			get
			{
				return this._EnergySuccess;
			}
			set
			{
				this._EnergySuccess = value;
			}
		}

		// Token: 0x170009E0 RID: 2528
		// (get) Token: 0x060026CD RID: 9933 RVA: 0x000AABB8 File Offset: 0x000A8DB8
		// (set) Token: 0x060026CE RID: 9934 RVA: 0x000AABC0 File Offset: 0x000A8DC0
		[ProtoMember(8, IsRequired = true, Name = "EnergyFail", DataFormat = DataFormat.TwosComplement)]
		public int EnergyFail
		{
			get
			{
				return this._EnergyFail;
			}
			set
			{
				this._EnergyFail = value;
			}
		}

		// Token: 0x170009E1 RID: 2529
		// (get) Token: 0x060026CF RID: 9935 RVA: 0x000AABCC File Offset: 0x000A8DCC
		// (set) Token: 0x060026D0 RID: 9936 RVA: 0x000AABD4 File Offset: 0x000A8DD4
		[ProtoMember(9, IsRequired = true, Name = "TeamEnergyCost", DataFormat = DataFormat.TwosComplement)]
		public int TeamEnergyCost
		{
			get
			{
				return this._TeamEnergyCost;
			}
			set
			{
				this._TeamEnergyCost = value;
			}
		}

		// Token: 0x170009E2 RID: 2530
		// (get) Token: 0x060026D1 RID: 9937 RVA: 0x000AABE0 File Offset: 0x000A8DE0
		// (set) Token: 0x060026D2 RID: 9938 RVA: 0x000AABE8 File Offset: 0x000A8DE8
		[ProtoMember(10, IsRequired = true, Name = "MonsterLevel", DataFormat = DataFormat.TwosComplement)]
		public int MonsterLevel
		{
			get
			{
				return this._MonsterLevel;
			}
			set
			{
				this._MonsterLevel = value;
			}
		}

		// Token: 0x170009E3 RID: 2531
		// (get) Token: 0x060026D3 RID: 9939 RVA: 0x000AABF4 File Offset: 0x000A8DF4
		// (set) Token: 0x060026D4 RID: 9940 RVA: 0x000AABFC File Offset: 0x000A8DFC
		[ProtoMember(11, IsRequired = true, Name = "Battle_ID", DataFormat = DataFormat.TwosComplement)]
		public int Battle_ID
		{
			get
			{
				return this._Battle_ID;
			}
			set
			{
				this._Battle_ID = value;
			}
		}

		// Token: 0x170009E4 RID: 2532
		// (get) Token: 0x060026D5 RID: 9941 RVA: 0x000AAC08 File Offset: 0x000A8E08
		// (set) Token: 0x060026D6 RID: 9942 RVA: 0x000AAC10 File Offset: 0x000A8E10
		[ProtoMember(12, IsRequired = true, Name = "PlayerExp", DataFormat = DataFormat.TwosComplement)]
		public int PlayerExp
		{
			get
			{
				return this._PlayerExp;
			}
			set
			{
				this._PlayerExp = value;
			}
		}

		// Token: 0x170009E5 RID: 2533
		// (get) Token: 0x060026D7 RID: 9943 RVA: 0x000AAC1C File Offset: 0x000A8E1C
		// (set) Token: 0x060026D8 RID: 9944 RVA: 0x000AAC24 File Offset: 0x000A8E24
		[ProtoMember(13, IsRequired = true, Name = "HeroExp", DataFormat = DataFormat.TwosComplement)]
		public int HeroExp
		{
			get
			{
				return this._HeroExp;
			}
			set
			{
				this._HeroExp = value;
			}
		}

		// Token: 0x170009E6 RID: 2534
		// (get) Token: 0x060026D9 RID: 9945 RVA: 0x000AAC30 File Offset: 0x000A8E30
		// (set) Token: 0x060026DA RID: 9946 RVA: 0x000AAC38 File Offset: 0x000A8E38
		[ProtoMember(14, IsRequired = true, Name = "Gold", DataFormat = DataFormat.TwosComplement)]
		public int Gold
		{
			get
			{
				return this._Gold;
			}
			set
			{
				this._Gold = value;
			}
		}

		// Token: 0x170009E7 RID: 2535
		// (get) Token: 0x060026DB RID: 9947 RVA: 0x000AAC44 File Offset: 0x000A8E44
		// (set) Token: 0x060026DC RID: 9948 RVA: 0x000AAC4C File Offset: 0x000A8E4C
		[ProtoMember(15, IsRequired = true, Name = "Drop_ID", DataFormat = DataFormat.TwosComplement)]
		public int Drop_ID
		{
			get
			{
				return this._Drop_ID;
			}
			set
			{
				this._Drop_ID = value;
			}
		}

		// Token: 0x170009E8 RID: 2536
		// (get) Token: 0x060026DD RID: 9949 RVA: 0x000AAC58 File Offset: 0x000A8E58
		// (set) Token: 0x060026DE RID: 9950 RVA: 0x000AAC60 File Offset: 0x000A8E60
		[ProtoMember(16, IsRequired = true, Name = "TeamDrop_ID", DataFormat = DataFormat.TwosComplement)]
		public int TeamDrop_ID
		{
			get
			{
				return this._TeamDrop_ID;
			}
			set
			{
				this._TeamDrop_ID = value;
			}
		}

		// Token: 0x170009E9 RID: 2537
		// (get) Token: 0x060026DF RID: 9951 RVA: 0x000AAC6C File Offset: 0x000A8E6C
		// (set) Token: 0x060026E0 RID: 9952 RVA: 0x000AAC74 File Offset: 0x000A8E74
		[ProtoMember(17, IsRequired = true, Name = "OperationalActivityDrop_ID", DataFormat = DataFormat.TwosComplement)]
		public int OperationalActivityDrop_ID
		{
			get
			{
				return this._OperationalActivityDrop_ID;
			}
			set
			{
				this._OperationalActivityDrop_ID = value;
			}
		}

		// Token: 0x170009EA RID: 2538
		// (get) Token: 0x060026E1 RID: 9953 RVA: 0x000AAC80 File Offset: 0x000A8E80
		// (set) Token: 0x060026E2 RID: 9954 RVA: 0x000AAC88 File Offset: 0x000A8E88
		[ProtoMember(18, IsRequired = true, Name = "DayBonusDrop_ID", DataFormat = DataFormat.TwosComplement)]
		public int DayBonusDrop_ID
		{
			get
			{
				return this._DayBonusDrop_ID;
			}
			set
			{
				this._DayBonusDrop_ID = value;
			}
		}

		// Token: 0x170009EB RID: 2539
		// (get) Token: 0x060026E3 RID: 9955 RVA: 0x000AAC94 File Offset: 0x000A8E94
		// (set) Token: 0x060026E4 RID: 9956 RVA: 0x000AAC9C File Offset: 0x000A8E9C
		[ProtoMember(19, IsRequired = true, Name = "DisplayRewardCount", DataFormat = DataFormat.TwosComplement)]
		public int DisplayRewardCount
		{
			get
			{
				return this._DisplayRewardCount;
			}
			set
			{
				this._DisplayRewardCount = value;
			}
		}

		// Token: 0x170009EC RID: 2540
		// (get) Token: 0x060026E5 RID: 9957 RVA: 0x000AACA8 File Offset: 0x000A8EA8
		// (set) Token: 0x060026E6 RID: 9958 RVA: 0x000AACB0 File Offset: 0x000A8EB0
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

		// Token: 0x170009ED RID: 2541
		// (get) Token: 0x060026E7 RID: 9959 RVA: 0x000AACBC File Offset: 0x000A8EBC
		// (set) Token: 0x060026E8 RID: 9960 RVA: 0x000AACC4 File Offset: 0x000A8EC4
		[ProtoMember(21, IsRequired = true, Name = "Strategy", DataFormat = DataFormat.Default)]
		public string Strategy
		{
			get
			{
				return this._Strategy;
			}
			set
			{
				this._Strategy = value;
			}
		}

		// Token: 0x060026E9 RID: 9961 RVA: 0x000AACD0 File Offset: 0x000A8ED0
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060026EA RID: 9962 RVA: 0x000AACE0 File Offset: 0x000A8EE0
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

		// Token: 0x060026EB RID: 9963 RVA: 0x000AADAC File Offset: 0x000A8FAC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataMemoryCorridorLevelInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040017B5 RID: 6069
		private int _ID;

		// Token: 0x040017B6 RID: 6070
		private string _Name;

		// Token: 0x040017B7 RID: 6071
		private string _TeamName;

		// Token: 0x040017B8 RID: 6072
		private int _OpenPlayerLevel;

		// Token: 0x040017B9 RID: 6073
		private int _TicketCost;

		// Token: 0x040017BA RID: 6074
		private int _EnergySuccess;

		// Token: 0x040017BB RID: 6075
		private int _EnergyFail;

		// Token: 0x040017BC RID: 6076
		private int _TeamEnergyCost;

		// Token: 0x040017BD RID: 6077
		private int _MonsterLevel;

		// Token: 0x040017BE RID: 6078
		private int _Battle_ID;

		// Token: 0x040017BF RID: 6079
		private int _PlayerExp;

		// Token: 0x040017C0 RID: 6080
		private int _HeroExp;

		// Token: 0x040017C1 RID: 6081
		private int _Gold;

		// Token: 0x040017C2 RID: 6082
		private int _Drop_ID;

		// Token: 0x040017C3 RID: 6083
		private int _TeamDrop_ID;

		// Token: 0x040017C4 RID: 6084
		private int _OperationalActivityDrop_ID;

		// Token: 0x040017C5 RID: 6085
		private int _DayBonusDrop_ID;

		// Token: 0x040017C6 RID: 6086
		private int _DisplayRewardCount;

		// Token: 0x040017C7 RID: 6087
		private string _Icon;

		// Token: 0x040017C8 RID: 6088
		private string _Strategy;

		// Token: 0x040017C9 RID: 6089
		private IExtension extensionObject;

		// Token: 0x040017CA RID: 6090
		public ConfigDataBattleInfo m_battleInfo;

		// Token: 0x040017CB RID: 6091
		public ConfigDataMemoryCorridorInfo m_groupInfo;

		// Token: 0x040017CC RID: 6092
		public ConfigDataRandomDropRewardInfo m_randomDropInfo;

		// Token: 0x040017CD RID: 6093
		public ConfigDataRandomDropRewardInfo m_activityRandomDropInfo;

		// Token: 0x040017CE RID: 6094
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040017CF RID: 6095
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040017D0 RID: 6096
		private LuaFunction m_ctor_hotfix;
	}
}
