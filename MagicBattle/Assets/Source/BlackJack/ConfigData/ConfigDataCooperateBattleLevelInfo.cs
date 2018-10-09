using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x02000223 RID: 547
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ConfigDataCooperateBattleLevelInfo")]
	[CustomLuaClass]
	[Serializable]
	public class ConfigDataCooperateBattleLevelInfo : IExtensible
	{
		// Token: 0x06002078 RID: 8312 RVA: 0x000A0AB0 File Offset: 0x0009ECB0
		public ConfigDataCooperateBattleLevelInfo()
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

		// Token: 0x170006EE RID: 1774
		// (get) Token: 0x06002079 RID: 8313 RVA: 0x000A0B18 File Offset: 0x0009ED18
		// (set) Token: 0x0600207A RID: 8314 RVA: 0x000A0B20 File Offset: 0x0009ED20
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

		// Token: 0x170006EF RID: 1775
		// (get) Token: 0x0600207B RID: 8315 RVA: 0x000A0B2C File Offset: 0x0009ED2C
		// (set) Token: 0x0600207C RID: 8316 RVA: 0x000A0B34 File Offset: 0x0009ED34
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

		// Token: 0x170006F0 RID: 1776
		// (get) Token: 0x0600207D RID: 8317 RVA: 0x000A0B40 File Offset: 0x0009ED40
		// (set) Token: 0x0600207E RID: 8318 RVA: 0x000A0B48 File Offset: 0x0009ED48
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

		// Token: 0x170006F1 RID: 1777
		// (get) Token: 0x0600207F RID: 8319 RVA: 0x000A0B54 File Offset: 0x0009ED54
		// (set) Token: 0x06002080 RID: 8320 RVA: 0x000A0B5C File Offset: 0x0009ED5C
		[ProtoMember(5, IsRequired = true, Name = "PlayerLevelRequired", DataFormat = DataFormat.TwosComplement)]
		public int PlayerLevelRequired
		{
			get
			{
				return this._PlayerLevelRequired;
			}
			set
			{
				this._PlayerLevelRequired = value;
			}
		}

		// Token: 0x170006F2 RID: 1778
		// (get) Token: 0x06002081 RID: 8321 RVA: 0x000A0B68 File Offset: 0x0009ED68
		// (set) Token: 0x06002082 RID: 8322 RVA: 0x000A0B70 File Offset: 0x0009ED70
		[ProtoMember(6, IsRequired = true, Name = "EnergySuccess", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x170006F3 RID: 1779
		// (get) Token: 0x06002083 RID: 8323 RVA: 0x000A0B7C File Offset: 0x0009ED7C
		// (set) Token: 0x06002084 RID: 8324 RVA: 0x000A0B84 File Offset: 0x0009ED84
		[ProtoMember(7, IsRequired = true, Name = "EnergyFail", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x170006F4 RID: 1780
		// (get) Token: 0x06002085 RID: 8325 RVA: 0x000A0B90 File Offset: 0x0009ED90
		// (set) Token: 0x06002086 RID: 8326 RVA: 0x000A0B98 File Offset: 0x0009ED98
		[ProtoMember(8, IsRequired = true, Name = "MonsterLevel", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x170006F5 RID: 1781
		// (get) Token: 0x06002087 RID: 8327 RVA: 0x000A0BA4 File Offset: 0x0009EDA4
		// (set) Token: 0x06002088 RID: 8328 RVA: 0x000A0BAC File Offset: 0x0009EDAC
		[ProtoMember(9, IsRequired = true, Name = "Battle_ID", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x170006F6 RID: 1782
		// (get) Token: 0x06002089 RID: 8329 RVA: 0x000A0BB8 File Offset: 0x0009EDB8
		// (set) Token: 0x0600208A RID: 8330 RVA: 0x000A0BC0 File Offset: 0x0009EDC0
		[ProtoMember(10, IsRequired = true, Name = "PlayerExp", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x170006F7 RID: 1783
		// (get) Token: 0x0600208B RID: 8331 RVA: 0x000A0BCC File Offset: 0x0009EDCC
		// (set) Token: 0x0600208C RID: 8332 RVA: 0x000A0BD4 File Offset: 0x0009EDD4
		[ProtoMember(11, IsRequired = true, Name = "HeroExp", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x170006F8 RID: 1784
		// (get) Token: 0x0600208D RID: 8333 RVA: 0x000A0BE0 File Offset: 0x0009EDE0
		// (set) Token: 0x0600208E RID: 8334 RVA: 0x000A0BE8 File Offset: 0x0009EDE8
		[ProtoMember(12, IsRequired = true, Name = "Gold", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x170006F9 RID: 1785
		// (get) Token: 0x0600208F RID: 8335 RVA: 0x000A0BF4 File Offset: 0x0009EDF4
		// (set) Token: 0x06002090 RID: 8336 RVA: 0x000A0BFC File Offset: 0x0009EDFC
		[ProtoMember(13, IsRequired = true, Name = "DropID", DataFormat = DataFormat.TwosComplement)]
		public int DropID
		{
			get
			{
				return this._DropID;
			}
			set
			{
				this._DropID = value;
			}
		}

		// Token: 0x170006FA RID: 1786
		// (get) Token: 0x06002091 RID: 8337 RVA: 0x000A0C08 File Offset: 0x0009EE08
		// (set) Token: 0x06002092 RID: 8338 RVA: 0x000A0C10 File Offset: 0x0009EE10
		[ProtoMember(14, IsRequired = true, Name = "ItemDropCountDisplay", DataFormat = DataFormat.TwosComplement)]
		public int ItemDropCountDisplay
		{
			get
			{
				return this._ItemDropCountDisplay;
			}
			set
			{
				this._ItemDropCountDisplay = value;
			}
		}

		// Token: 0x170006FB RID: 1787
		// (get) Token: 0x06002093 RID: 8339 RVA: 0x000A0C1C File Offset: 0x0009EE1C
		// (set) Token: 0x06002094 RID: 8340 RVA: 0x000A0C24 File Offset: 0x0009EE24
		[ProtoMember(15, IsRequired = true, Name = "Icon", DataFormat = DataFormat.Default)]
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

		// Token: 0x170006FC RID: 1788
		// (get) Token: 0x06002095 RID: 8341 RVA: 0x000A0C30 File Offset: 0x0009EE30
		// (set) Token: 0x06002096 RID: 8342 RVA: 0x000A0C38 File Offset: 0x0009EE38
		[ProtoMember(16, IsRequired = true, Name = "DayBonusDrop_ID", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x170006FD RID: 1789
		// (get) Token: 0x06002097 RID: 8343 RVA: 0x000A0C44 File Offset: 0x0009EE44
		// (set) Token: 0x06002098 RID: 8344 RVA: 0x000A0C4C File Offset: 0x0009EE4C
		[ProtoMember(17, IsRequired = true, Name = "TeamDrop_ID", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x06002099 RID: 8345 RVA: 0x000A0C58 File Offset: 0x0009EE58
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x0600209A RID: 8346 RVA: 0x000A0C68 File Offset: 0x0009EE68
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

		// Token: 0x0600209B RID: 8347 RVA: 0x000A0D34 File Offset: 0x0009EF34
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataCooperateBattleLevelInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040013A1 RID: 5025
		private int _ID;

		// Token: 0x040013A2 RID: 5026
		private string _Name;

		// Token: 0x040013A3 RID: 5027
		private string _TeamName;

		// Token: 0x040013A4 RID: 5028
		private int _PlayerLevelRequired;

		// Token: 0x040013A5 RID: 5029
		private int _EnergySuccess;

		// Token: 0x040013A6 RID: 5030
		private int _EnergyFail;

		// Token: 0x040013A7 RID: 5031
		private int _MonsterLevel;

		// Token: 0x040013A8 RID: 5032
		private int _Battle_ID;

		// Token: 0x040013A9 RID: 5033
		private int _PlayerExp;

		// Token: 0x040013AA RID: 5034
		private int _HeroExp;

		// Token: 0x040013AB RID: 5035
		private int _Gold;

		// Token: 0x040013AC RID: 5036
		private int _DropID;

		// Token: 0x040013AD RID: 5037
		private int _ItemDropCountDisplay;

		// Token: 0x040013AE RID: 5038
		private string _Icon;

		// Token: 0x040013AF RID: 5039
		private int _DayBonusDrop_ID;

		// Token: 0x040013B0 RID: 5040
		private int _TeamDrop_ID;

		// Token: 0x040013B1 RID: 5041
		private IExtension extensionObject;

		// Token: 0x040013B2 RID: 5042
		public ConfigDataBattleInfo m_battleInfo;

		// Token: 0x040013B3 RID: 5043
		public ConfigDataCooperateBattleInfo m_groupInfo;

		// Token: 0x040013B4 RID: 5044
		public ConfigDataRandomDropRewardInfo m_randomDropInfo;

		// Token: 0x040013B5 RID: 5045
		public ConfigDataRandomDropRewardInfo m_teamRandomDropInfo;

		// Token: 0x040013B6 RID: 5046
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040013B7 RID: 5047
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040013B8 RID: 5048
		private LuaFunction m_ctor_hotfix;
	}
}
