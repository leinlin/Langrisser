using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x0200023B RID: 571
	[CustomLuaClass]
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ConfigDataGuildMassiveCombatDifficultyInfo")]
	[Serializable]
	public class ConfigDataGuildMassiveCombatDifficultyInfo : IExtensible
	{
		// Token: 0x06002335 RID: 9013 RVA: 0x000A4CD0 File Offset: 0x000A2ED0
		public ConfigDataGuildMassiveCombatDifficultyInfo()
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

		// Token: 0x17000836 RID: 2102
		// (get) Token: 0x06002336 RID: 9014 RVA: 0x000A4D64 File Offset: 0x000A2F64
		// (set) Token: 0x06002337 RID: 9015 RVA: 0x000A4D6C File Offset: 0x000A2F6C
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

		// Token: 0x17000837 RID: 2103
		// (get) Token: 0x06002338 RID: 9016 RVA: 0x000A4D78 File Offset: 0x000A2F78
		// (set) Token: 0x06002339 RID: 9017 RVA: 0x000A4D80 File Offset: 0x000A2F80
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

		// Token: 0x17000838 RID: 2104
		// (get) Token: 0x0600233A RID: 9018 RVA: 0x000A4D8C File Offset: 0x000A2F8C
		// (set) Token: 0x0600233B RID: 9019 RVA: 0x000A4D94 File Offset: 0x000A2F94
		[ProtoMember(4, IsRequired = true, Name = "Desc", DataFormat = DataFormat.Default)]
		public string Desc
		{
			get
			{
				return this._Desc;
			}
			set
			{
				this._Desc = value;
			}
		}

		// Token: 0x17000839 RID: 2105
		// (get) Token: 0x0600233C RID: 9020 RVA: 0x000A4DA0 File Offset: 0x000A2FA0
		// (set) Token: 0x0600233D RID: 9021 RVA: 0x000A4DA8 File Offset: 0x000A2FA8
		[ProtoMember(5, IsRequired = true, Name = "SuggestedLevel", DataFormat = DataFormat.Default)]
		public string SuggestedLevel
		{
			get
			{
				return this._SuggestedLevel;
			}
			set
			{
				this._SuggestedLevel = value;
			}
		}

		// Token: 0x1700083A RID: 2106
		// (get) Token: 0x0600233E RID: 9022 RVA: 0x000A4DB4 File Offset: 0x000A2FB4
		[ProtoMember(6, Name = "Requirements", DataFormat = DataFormat.Default)]
		public List<LevelAndMembers> Requirements
		{
			get
			{
				return this._Requirements;
			}
		}

		// Token: 0x1700083B RID: 2107
		// (get) Token: 0x0600233F RID: 9023 RVA: 0x000A4DBC File Offset: 0x000A2FBC
		[ProtoMember(7, Name = "StrongholdList", DataFormat = DataFormat.TwosComplement)]
		public List<int> StrongholdList
		{
			get
			{
				return this._StrongholdList;
			}
		}

		// Token: 0x1700083C RID: 2108
		// (get) Token: 0x06002340 RID: 9024 RVA: 0x000A4DC4 File Offset: 0x000A2FC4
		[ProtoMember(8, Name = "RewardsInfo", DataFormat = DataFormat.Default)]
		public List<Rewards> RewardsInfo
		{
			get
			{
				return this._RewardsInfo;
			}
		}

		// Token: 0x1700083D RID: 2109
		// (get) Token: 0x06002341 RID: 9025 RVA: 0x000A4DCC File Offset: 0x000A2FCC
		// (set) Token: 0x06002342 RID: 9026 RVA: 0x000A4DD4 File Offset: 0x000A2FD4
		[ProtoMember(9, IsRequired = true, Name = "BonusGuildCoins", DataFormat = DataFormat.TwosComplement)]
		public int BonusGuildCoins
		{
			get
			{
				return this._BonusGuildCoins;
			}
			set
			{
				this._BonusGuildCoins = value;
			}
		}

		// Token: 0x1700083E RID: 2110
		// (get) Token: 0x06002343 RID: 9027 RVA: 0x000A4DE0 File Offset: 0x000A2FE0
		// (set) Token: 0x06002344 RID: 9028 RVA: 0x000A4DE8 File Offset: 0x000A2FE8
		[ProtoMember(10, IsRequired = true, Name = "IndividualPointsRewardsInfo", DataFormat = DataFormat.TwosComplement)]
		public int IndividualPointsRewardsInfo
		{
			get
			{
				return this._IndividualPointsRewardsInfo;
			}
			set
			{
				this._IndividualPointsRewardsInfo = value;
			}
		}

		// Token: 0x1700083F RID: 2111
		// (get) Token: 0x06002345 RID: 9029 RVA: 0x000A4DF4 File Offset: 0x000A2FF4
		// (set) Token: 0x06002346 RID: 9030 RVA: 0x000A4DFC File Offset: 0x000A2FFC
		[ProtoMember(11, IsRequired = true, Name = "StrongholdRewardMailTemplateId", DataFormat = DataFormat.TwosComplement)]
		public int StrongholdRewardMailTemplateId
		{
			get
			{
				return this._StrongholdRewardMailTemplateId;
			}
			set
			{
				this._StrongholdRewardMailTemplateId = value;
			}
		}

		// Token: 0x17000840 RID: 2112
		// (get) Token: 0x06002347 RID: 9031 RVA: 0x000A4E08 File Offset: 0x000A3008
		// (set) Token: 0x06002348 RID: 9032 RVA: 0x000A4E10 File Offset: 0x000A3010
		[ProtoMember(12, IsRequired = true, Name = "IndividualRewardMailTemplateId", DataFormat = DataFormat.TwosComplement)]
		public int IndividualRewardMailTemplateId
		{
			get
			{
				return this._IndividualRewardMailTemplateId;
			}
			set
			{
				this._IndividualRewardMailTemplateId = value;
			}
		}

		// Token: 0x06002349 RID: 9033 RVA: 0x000A4E1C File Offset: 0x000A301C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x0600234A RID: 9034 RVA: 0x000A4E2C File Offset: 0x000A302C
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

		// Token: 0x0600234B RID: 9035 RVA: 0x000A4EF8 File Offset: 0x000A30F8
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataGuildMassiveCombatDifficultyInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400154F RID: 5455
		private int _ID;

		// Token: 0x04001550 RID: 5456
		private string _Name;

		// Token: 0x04001551 RID: 5457
		private string _Desc;

		// Token: 0x04001552 RID: 5458
		private string _SuggestedLevel;

		// Token: 0x04001553 RID: 5459
		private readonly List<LevelAndMembers> _Requirements = new List<LevelAndMembers>();

		// Token: 0x04001554 RID: 5460
		private readonly List<int> _StrongholdList = new List<int>();

		// Token: 0x04001555 RID: 5461
		private readonly List<Rewards> _RewardsInfo = new List<Rewards>();

		// Token: 0x04001556 RID: 5462
		private int _BonusGuildCoins;

		// Token: 0x04001557 RID: 5463
		private int _IndividualPointsRewardsInfo;

		// Token: 0x04001558 RID: 5464
		private int _StrongholdRewardMailTemplateId;

		// Token: 0x04001559 RID: 5465
		private int _IndividualRewardMailTemplateId;

		// Token: 0x0400155A RID: 5466
		private IExtension extensionObject;

		// Token: 0x0400155B RID: 5467
		public List<Rewards> SortedRewardsInfo = new List<Rewards>();

		// Token: 0x0400155C RID: 5468
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400155D RID: 5469
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400155E RID: 5470
		private LuaFunction m_ctor_hotfix;
	}
}
