using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x0200029F RID: 671
	[HotFix(true, m_isCtorOnly = true)]
	[CustomLuaClass]
	[ProtoContract(Name = "ConfigDataThearchyTrialLevelInfo")]
	[Serializable]
	public class ConfigDataThearchyTrialLevelInfo : IExtensible
	{
		// Token: 0x06002BFE RID: 11262 RVA: 0x000B4454 File Offset: 0x000B2654
		public ConfigDataThearchyTrialLevelInfo()
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

		// Token: 0x17000C17 RID: 3095
		// (get) Token: 0x06002BFF RID: 11263 RVA: 0x000B44BC File Offset: 0x000B26BC
		// (set) Token: 0x06002C00 RID: 11264 RVA: 0x000B44C4 File Offset: 0x000B26C4
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

		// Token: 0x17000C18 RID: 3096
		// (get) Token: 0x06002C01 RID: 11265 RVA: 0x000B44D0 File Offset: 0x000B26D0
		// (set) Token: 0x06002C02 RID: 11266 RVA: 0x000B44D8 File Offset: 0x000B26D8
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

		// Token: 0x17000C19 RID: 3097
		// (get) Token: 0x06002C03 RID: 11267 RVA: 0x000B44E4 File Offset: 0x000B26E4
		// (set) Token: 0x06002C04 RID: 11268 RVA: 0x000B44EC File Offset: 0x000B26EC
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

		// Token: 0x17000C1A RID: 3098
		// (get) Token: 0x06002C05 RID: 11269 RVA: 0x000B44F8 File Offset: 0x000B26F8
		// (set) Token: 0x06002C06 RID: 11270 RVA: 0x000B4500 File Offset: 0x000B2700
		[ProtoMember(5, IsRequired = true, Name = "PreLevel", DataFormat = DataFormat.TwosComplement)]
		public int PreLevel
		{
			get
			{
				return this._PreLevel;
			}
			set
			{
				this._PreLevel = value;
			}
		}

		// Token: 0x17000C1B RID: 3099
		// (get) Token: 0x06002C07 RID: 11271 RVA: 0x000B450C File Offset: 0x000B270C
		// (set) Token: 0x06002C08 RID: 11272 RVA: 0x000B4514 File Offset: 0x000B2714
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

		// Token: 0x17000C1C RID: 3100
		// (get) Token: 0x06002C09 RID: 11273 RVA: 0x000B4520 File Offset: 0x000B2720
		// (set) Token: 0x06002C0A RID: 11274 RVA: 0x000B4528 File Offset: 0x000B2728
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

		// Token: 0x17000C1D RID: 3101
		// (get) Token: 0x06002C0B RID: 11275 RVA: 0x000B4534 File Offset: 0x000B2734
		// (set) Token: 0x06002C0C RID: 11276 RVA: 0x000B453C File Offset: 0x000B273C
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

		// Token: 0x17000C1E RID: 3102
		// (get) Token: 0x06002C0D RID: 11277 RVA: 0x000B4548 File Offset: 0x000B2748
		// (set) Token: 0x06002C0E RID: 11278 RVA: 0x000B4550 File Offset: 0x000B2750
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

		// Token: 0x17000C1F RID: 3103
		// (get) Token: 0x06002C0F RID: 11279 RVA: 0x000B455C File Offset: 0x000B275C
		// (set) Token: 0x06002C10 RID: 11280 RVA: 0x000B4564 File Offset: 0x000B2764
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

		// Token: 0x17000C20 RID: 3104
		// (get) Token: 0x06002C11 RID: 11281 RVA: 0x000B4570 File Offset: 0x000B2770
		// (set) Token: 0x06002C12 RID: 11282 RVA: 0x000B4578 File Offset: 0x000B2778
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

		// Token: 0x17000C21 RID: 3105
		// (get) Token: 0x06002C13 RID: 11283 RVA: 0x000B4584 File Offset: 0x000B2784
		// (set) Token: 0x06002C14 RID: 11284 RVA: 0x000B458C File Offset: 0x000B278C
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

		// Token: 0x17000C22 RID: 3106
		// (get) Token: 0x06002C15 RID: 11285 RVA: 0x000B4598 File Offset: 0x000B2798
		// (set) Token: 0x06002C16 RID: 11286 RVA: 0x000B45A0 File Offset: 0x000B27A0
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

		// Token: 0x17000C23 RID: 3107
		// (get) Token: 0x06002C17 RID: 11287 RVA: 0x000B45AC File Offset: 0x000B27AC
		// (set) Token: 0x06002C18 RID: 11288 RVA: 0x000B45B4 File Offset: 0x000B27B4
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

		// Token: 0x17000C24 RID: 3108
		// (get) Token: 0x06002C19 RID: 11289 RVA: 0x000B45C0 File Offset: 0x000B27C0
		// (set) Token: 0x06002C1A RID: 11290 RVA: 0x000B45C8 File Offset: 0x000B27C8
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

		// Token: 0x17000C25 RID: 3109
		// (get) Token: 0x06002C1B RID: 11291 RVA: 0x000B45D4 File Offset: 0x000B27D4
		// (set) Token: 0x06002C1C RID: 11292 RVA: 0x000B45DC File Offset: 0x000B27DC
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

		// Token: 0x17000C26 RID: 3110
		// (get) Token: 0x06002C1D RID: 11293 RVA: 0x000B45E8 File Offset: 0x000B27E8
		// (set) Token: 0x06002C1E RID: 11294 RVA: 0x000B45F0 File Offset: 0x000B27F0
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

		// Token: 0x17000C27 RID: 3111
		// (get) Token: 0x06002C1F RID: 11295 RVA: 0x000B45FC File Offset: 0x000B27FC
		// (set) Token: 0x06002C20 RID: 11296 RVA: 0x000B4604 File Offset: 0x000B2804
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

		// Token: 0x17000C28 RID: 3112
		// (get) Token: 0x06002C21 RID: 11297 RVA: 0x000B4610 File Offset: 0x000B2810
		// (set) Token: 0x06002C22 RID: 11298 RVA: 0x000B4618 File Offset: 0x000B2818
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

		// Token: 0x17000C29 RID: 3113
		// (get) Token: 0x06002C23 RID: 11299 RVA: 0x000B4624 File Offset: 0x000B2824
		// (set) Token: 0x06002C24 RID: 11300 RVA: 0x000B462C File Offset: 0x000B282C
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

		// Token: 0x17000C2A RID: 3114
		// (get) Token: 0x06002C25 RID: 11301 RVA: 0x000B4638 File Offset: 0x000B2838
		// (set) Token: 0x06002C26 RID: 11302 RVA: 0x000B4640 File Offset: 0x000B2840
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

		// Token: 0x06002C27 RID: 11303 RVA: 0x000B464C File Offset: 0x000B284C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06002C28 RID: 11304 RVA: 0x000B465C File Offset: 0x000B285C
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

		// Token: 0x06002C29 RID: 11305 RVA: 0x000B4728 File Offset: 0x000B2928
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataThearchyTrialLevelInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04001B1C RID: 6940
		private int _ID;

		// Token: 0x04001B1D RID: 6941
		private string _Name;

		// Token: 0x04001B1E RID: 6942
		private string _TeamName;

		// Token: 0x04001B1F RID: 6943
		private int _PreLevel;

		// Token: 0x04001B20 RID: 6944
		private int _TicketCost;

		// Token: 0x04001B21 RID: 6945
		private int _EnergySuccess;

		// Token: 0x04001B22 RID: 6946
		private int _EnergyFail;

		// Token: 0x04001B23 RID: 6947
		private int _TeamEnergyCost;

		// Token: 0x04001B24 RID: 6948
		private int _MonsterLevel;

		// Token: 0x04001B25 RID: 6949
		private int _Battle_ID;

		// Token: 0x04001B26 RID: 6950
		private int _PlayerExp;

		// Token: 0x04001B27 RID: 6951
		private int _HeroExp;

		// Token: 0x04001B28 RID: 6952
		private int _Gold;

		// Token: 0x04001B29 RID: 6953
		private int _Drop_ID;

		// Token: 0x04001B2A RID: 6954
		private int _TeamDrop_ID;

		// Token: 0x04001B2B RID: 6955
		private int _OperationalActivityDrop_ID;

		// Token: 0x04001B2C RID: 6956
		private int _DayBonusDrop_ID;

		// Token: 0x04001B2D RID: 6957
		private int _DisplayRewardCount;

		// Token: 0x04001B2E RID: 6958
		private string _Icon;

		// Token: 0x04001B2F RID: 6959
		private string _Strategy;

		// Token: 0x04001B30 RID: 6960
		private IExtension extensionObject;

		// Token: 0x04001B31 RID: 6961
		public ConfigDataBattleInfo m_battleInfo;

		// Token: 0x04001B32 RID: 6962
		public ConfigDataThearchyTrialInfo m_groupInfo;

		// Token: 0x04001B33 RID: 6963
		public ConfigDataRandomDropRewardInfo m_randomDropInfo;

		// Token: 0x04001B34 RID: 6964
		public ConfigDataRandomDropRewardInfo m_activityRandomDropInfo;

		// Token: 0x04001B35 RID: 6965
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04001B36 RID: 6966
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04001B37 RID: 6967
		private LuaFunction m_ctor_hotfix;
	}
}
