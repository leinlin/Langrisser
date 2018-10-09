using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x02000255 RID: 597
	[HotFix(true, m_isCtorOnly = true)]
	[CustomLuaClass]
	[ProtoContract(Name = "ConfigDataHeroTrainningLevelInfo")]
	[Serializable]
	public class ConfigDataHeroTrainningLevelInfo : IExtensible
	{
		// Token: 0x06002550 RID: 9552 RVA: 0x000A8C54 File Offset: 0x000A6E54
		public ConfigDataHeroTrainningLevelInfo()
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

		// Token: 0x1700092D RID: 2349
		// (get) Token: 0x06002551 RID: 9553 RVA: 0x000A8CBC File Offset: 0x000A6EBC
		// (set) Token: 0x06002552 RID: 9554 RVA: 0x000A8CC4 File Offset: 0x000A6EC4
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

		// Token: 0x1700092E RID: 2350
		// (get) Token: 0x06002553 RID: 9555 RVA: 0x000A8CD0 File Offset: 0x000A6ED0
		// (set) Token: 0x06002554 RID: 9556 RVA: 0x000A8CD8 File Offset: 0x000A6ED8
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

		// Token: 0x1700092F RID: 2351
		// (get) Token: 0x06002555 RID: 9557 RVA: 0x000A8CE4 File Offset: 0x000A6EE4
		// (set) Token: 0x06002556 RID: 9558 RVA: 0x000A8CEC File Offset: 0x000A6EEC
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

		// Token: 0x17000930 RID: 2352
		// (get) Token: 0x06002557 RID: 9559 RVA: 0x000A8CF8 File Offset: 0x000A6EF8
		// (set) Token: 0x06002558 RID: 9560 RVA: 0x000A8D00 File Offset: 0x000A6F00
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

		// Token: 0x17000931 RID: 2353
		// (get) Token: 0x06002559 RID: 9561 RVA: 0x000A8D0C File Offset: 0x000A6F0C
		// (set) Token: 0x0600255A RID: 9562 RVA: 0x000A8D14 File Offset: 0x000A6F14
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

		// Token: 0x17000932 RID: 2354
		// (get) Token: 0x0600255B RID: 9563 RVA: 0x000A8D20 File Offset: 0x000A6F20
		// (set) Token: 0x0600255C RID: 9564 RVA: 0x000A8D28 File Offset: 0x000A6F28
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

		// Token: 0x17000933 RID: 2355
		// (get) Token: 0x0600255D RID: 9565 RVA: 0x000A8D34 File Offset: 0x000A6F34
		// (set) Token: 0x0600255E RID: 9566 RVA: 0x000A8D3C File Offset: 0x000A6F3C
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

		// Token: 0x17000934 RID: 2356
		// (get) Token: 0x0600255F RID: 9567 RVA: 0x000A8D48 File Offset: 0x000A6F48
		// (set) Token: 0x06002560 RID: 9568 RVA: 0x000A8D50 File Offset: 0x000A6F50
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

		// Token: 0x17000935 RID: 2357
		// (get) Token: 0x06002561 RID: 9569 RVA: 0x000A8D5C File Offset: 0x000A6F5C
		// (set) Token: 0x06002562 RID: 9570 RVA: 0x000A8D64 File Offset: 0x000A6F64
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

		// Token: 0x17000936 RID: 2358
		// (get) Token: 0x06002563 RID: 9571 RVA: 0x000A8D70 File Offset: 0x000A6F70
		// (set) Token: 0x06002564 RID: 9572 RVA: 0x000A8D78 File Offset: 0x000A6F78
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

		// Token: 0x17000937 RID: 2359
		// (get) Token: 0x06002565 RID: 9573 RVA: 0x000A8D84 File Offset: 0x000A6F84
		// (set) Token: 0x06002566 RID: 9574 RVA: 0x000A8D8C File Offset: 0x000A6F8C
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

		// Token: 0x17000938 RID: 2360
		// (get) Token: 0x06002567 RID: 9575 RVA: 0x000A8D98 File Offset: 0x000A6F98
		// (set) Token: 0x06002568 RID: 9576 RVA: 0x000A8DA0 File Offset: 0x000A6FA0
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

		// Token: 0x17000939 RID: 2361
		// (get) Token: 0x06002569 RID: 9577 RVA: 0x000A8DAC File Offset: 0x000A6FAC
		// (set) Token: 0x0600256A RID: 9578 RVA: 0x000A8DB4 File Offset: 0x000A6FB4
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

		// Token: 0x1700093A RID: 2362
		// (get) Token: 0x0600256B RID: 9579 RVA: 0x000A8DC0 File Offset: 0x000A6FC0
		// (set) Token: 0x0600256C RID: 9580 RVA: 0x000A8DC8 File Offset: 0x000A6FC8
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

		// Token: 0x1700093B RID: 2363
		// (get) Token: 0x0600256D RID: 9581 RVA: 0x000A8DD4 File Offset: 0x000A6FD4
		// (set) Token: 0x0600256E RID: 9582 RVA: 0x000A8DDC File Offset: 0x000A6FDC
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

		// Token: 0x1700093C RID: 2364
		// (get) Token: 0x0600256F RID: 9583 RVA: 0x000A8DE8 File Offset: 0x000A6FE8
		// (set) Token: 0x06002570 RID: 9584 RVA: 0x000A8DF0 File Offset: 0x000A6FF0
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

		// Token: 0x1700093D RID: 2365
		// (get) Token: 0x06002571 RID: 9585 RVA: 0x000A8DFC File Offset: 0x000A6FFC
		// (set) Token: 0x06002572 RID: 9586 RVA: 0x000A8E04 File Offset: 0x000A7004
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

		// Token: 0x1700093E RID: 2366
		// (get) Token: 0x06002573 RID: 9587 RVA: 0x000A8E10 File Offset: 0x000A7010
		// (set) Token: 0x06002574 RID: 9588 RVA: 0x000A8E18 File Offset: 0x000A7018
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

		// Token: 0x1700093F RID: 2367
		// (get) Token: 0x06002575 RID: 9589 RVA: 0x000A8E24 File Offset: 0x000A7024
		// (set) Token: 0x06002576 RID: 9590 RVA: 0x000A8E2C File Offset: 0x000A702C
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

		// Token: 0x17000940 RID: 2368
		// (get) Token: 0x06002577 RID: 9591 RVA: 0x000A8E38 File Offset: 0x000A7038
		// (set) Token: 0x06002578 RID: 9592 RVA: 0x000A8E40 File Offset: 0x000A7040
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

		// Token: 0x06002579 RID: 9593 RVA: 0x000A8E4C File Offset: 0x000A704C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x0600257A RID: 9594 RVA: 0x000A8E5C File Offset: 0x000A705C
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

		// Token: 0x0600257B RID: 9595 RVA: 0x000A8F28 File Offset: 0x000A7128
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataHeroTrainningLevelInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040016CF RID: 5839
		private int _ID;

		// Token: 0x040016D0 RID: 5840
		private string _Name;

		// Token: 0x040016D1 RID: 5841
		private string _TeamName;

		// Token: 0x040016D2 RID: 5842
		private int _OpenPlayerLevel;

		// Token: 0x040016D3 RID: 5843
		private int _TicketCost;

		// Token: 0x040016D4 RID: 5844
		private int _EnergySuccess;

		// Token: 0x040016D5 RID: 5845
		private int _EnergyFail;

		// Token: 0x040016D6 RID: 5846
		private int _TeamEnergyCost;

		// Token: 0x040016D7 RID: 5847
		private int _MonsterLevel;

		// Token: 0x040016D8 RID: 5848
		private int _Battle_ID;

		// Token: 0x040016D9 RID: 5849
		private int _PlayerExp;

		// Token: 0x040016DA RID: 5850
		private int _HeroExp;

		// Token: 0x040016DB RID: 5851
		private int _Gold;

		// Token: 0x040016DC RID: 5852
		private int _Drop_ID;

		// Token: 0x040016DD RID: 5853
		private int _TeamDrop_ID;

		// Token: 0x040016DE RID: 5854
		private int _OperationalActivityDrop_ID;

		// Token: 0x040016DF RID: 5855
		private int _DayBonusDrop_ID;

		// Token: 0x040016E0 RID: 5856
		private int _DisplayRewardCount;

		// Token: 0x040016E1 RID: 5857
		private string _Icon;

		// Token: 0x040016E2 RID: 5858
		private string _Strategy;

		// Token: 0x040016E3 RID: 5859
		private IExtension extensionObject;

		// Token: 0x040016E4 RID: 5860
		public ConfigDataBattleInfo m_battleInfo;

		// Token: 0x040016E5 RID: 5861
		public ConfigDataHeroTrainningInfo m_groupInfo;

		// Token: 0x040016E6 RID: 5862
		public ConfigDataRandomDropRewardInfo m_randomDropInfo;

		// Token: 0x040016E7 RID: 5863
		public ConfigDataRandomDropRewardInfo m_activityRandomDropInfo;

		// Token: 0x040016E8 RID: 5864
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040016E9 RID: 5865
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040016EA RID: 5866
		private LuaFunction m_ctor_hotfix;
	}
}
