using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x020002AC RID: 684
	[HotFix(true, m_isCtorOnly = true)]
	[CustomLuaClass]
	[ProtoContract(Name = "ConfigDataTreasureLevelInfo")]
	[Serializable]
	public class ConfigDataTreasureLevelInfo : IExtensible
	{
		// Token: 0x06002CDA RID: 11482 RVA: 0x000B613C File Offset: 0x000B433C
		public ConfigDataTreasureLevelInfo()
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

		// Token: 0x17000C72 RID: 3186
		// (get) Token: 0x06002CDB RID: 11483 RVA: 0x000B61B8 File Offset: 0x000B43B8
		// (set) Token: 0x06002CDC RID: 11484 RVA: 0x000B61C0 File Offset: 0x000B43C0
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

		// Token: 0x17000C73 RID: 3187
		// (get) Token: 0x06002CDD RID: 11485 RVA: 0x000B61CC File Offset: 0x000B43CC
		// (set) Token: 0x06002CDE RID: 11486 RVA: 0x000B61D4 File Offset: 0x000B43D4
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

		// Token: 0x17000C74 RID: 3188
		// (get) Token: 0x06002CDF RID: 11487 RVA: 0x000B61E0 File Offset: 0x000B43E0
		// (set) Token: 0x06002CE0 RID: 11488 RVA: 0x000B61E8 File Offset: 0x000B43E8
		[ProtoMember(4, IsRequired = true, Name = "IconResource", DataFormat = DataFormat.Default)]
		public string IconResource
		{
			get
			{
				return this._IconResource;
			}
			set
			{
				this._IconResource = value;
			}
		}

		// Token: 0x17000C75 RID: 3189
		// (get) Token: 0x06002CE1 RID: 11489 RVA: 0x000B61F4 File Offset: 0x000B43F4
		// (set) Token: 0x06002CE2 RID: 11490 RVA: 0x000B61FC File Offset: 0x000B43FC
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

		// Token: 0x17000C76 RID: 3190
		// (get) Token: 0x06002CE3 RID: 11491 RVA: 0x000B6208 File Offset: 0x000B4408
		// (set) Token: 0x06002CE4 RID: 11492 RVA: 0x000B6210 File Offset: 0x000B4410
		[ProtoMember(6, IsRequired = true, Name = "EnergyFail", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x17000C77 RID: 3191
		// (get) Token: 0x06002CE5 RID: 11493 RVA: 0x000B621C File Offset: 0x000B441C
		// (set) Token: 0x06002CE6 RID: 11494 RVA: 0x000B6224 File Offset: 0x000B4424
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

		// Token: 0x17000C78 RID: 3192
		// (get) Token: 0x06002CE7 RID: 11495 RVA: 0x000B6230 File Offset: 0x000B4430
		// (set) Token: 0x06002CE8 RID: 11496 RVA: 0x000B6238 File Offset: 0x000B4438
		[ProtoMember(8, IsRequired = true, Name = "TicketCost", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x17000C79 RID: 3193
		// (get) Token: 0x06002CE9 RID: 11497 RVA: 0x000B6244 File Offset: 0x000B4444
		// (set) Token: 0x06002CEA RID: 11498 RVA: 0x000B624C File Offset: 0x000B444C
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

		// Token: 0x17000C7A RID: 3194
		// (get) Token: 0x06002CEB RID: 11499 RVA: 0x000B6258 File Offset: 0x000B4458
		// (set) Token: 0x06002CEC RID: 11500 RVA: 0x000B6260 File Offset: 0x000B4460
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

		// Token: 0x17000C7B RID: 3195
		// (get) Token: 0x06002CED RID: 11501 RVA: 0x000B626C File Offset: 0x000B446C
		// (set) Token: 0x06002CEE RID: 11502 RVA: 0x000B6274 File Offset: 0x000B4474
		[ProtoMember(11, IsRequired = true, Name = "PlayerExp", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x17000C7C RID: 3196
		// (get) Token: 0x06002CEF RID: 11503 RVA: 0x000B6280 File Offset: 0x000B4480
		// (set) Token: 0x06002CF0 RID: 11504 RVA: 0x000B6288 File Offset: 0x000B4488
		[ProtoMember(12, IsRequired = true, Name = "HeroExp", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x17000C7D RID: 3197
		// (get) Token: 0x06002CF1 RID: 11505 RVA: 0x000B6294 File Offset: 0x000B4494
		[ProtoMember(13, Name = "Bandits_ID", DataFormat = DataFormat.TwosComplement)]
		public List<int> Bandits_ID
		{
			get
			{
				return this._Bandits_ID;
			}
		}

		// Token: 0x17000C7E RID: 3198
		// (get) Token: 0x06002CF2 RID: 11506 RVA: 0x000B629C File Offset: 0x000B449C
		[ProtoMember(14, Name = "RewardList", DataFormat = DataFormat.Default)]
		public List<Goods> RewardList
		{
			get
			{
				return this._RewardList;
			}
		}

		// Token: 0x17000C7F RID: 3199
		// (get) Token: 0x06002CF3 RID: 11507 RVA: 0x000B62A4 File Offset: 0x000B44A4
		// (set) Token: 0x06002CF4 RID: 11508 RVA: 0x000B62AC File Offset: 0x000B44AC
		[ProtoMember(15, IsRequired = true, Name = "Strategy", DataFormat = DataFormat.Default)]
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

		// Token: 0x06002CF5 RID: 11509 RVA: 0x000B62B8 File Offset: 0x000B44B8
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06002CF6 RID: 11510 RVA: 0x000B62C8 File Offset: 0x000B44C8
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

		// Token: 0x06002CF7 RID: 11511 RVA: 0x000B6394 File Offset: 0x000B4594
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataTreasureLevelInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04001BB3 RID: 7091
		private int _ID;

		// Token: 0x04001BB4 RID: 7092
		private string _Name;

		// Token: 0x04001BB5 RID: 7093
		private string _IconResource;

		// Token: 0x04001BB6 RID: 7094
		private int _OpenPlayerLevel;

		// Token: 0x04001BB7 RID: 7095
		private int _EnergyFail;

		// Token: 0x04001BB8 RID: 7096
		private int _EnergySuccess;

		// Token: 0x04001BB9 RID: 7097
		private int _TicketCost;

		// Token: 0x04001BBA RID: 7098
		private int _Battle_ID;

		// Token: 0x04001BBB RID: 7099
		private int _MonsterLevel;

		// Token: 0x04001BBC RID: 7100
		private int _PlayerExp;

		// Token: 0x04001BBD RID: 7101
		private int _HeroExp;

		// Token: 0x04001BBE RID: 7102
		private readonly List<int> _Bandits_ID = new List<int>();

		// Token: 0x04001BBF RID: 7103
		private readonly List<Goods> _RewardList = new List<Goods>();

		// Token: 0x04001BC0 RID: 7104
		private string _Strategy;

		// Token: 0x04001BC1 RID: 7105
		private IExtension extensionObject;

		// Token: 0x04001BC2 RID: 7106
		public List<ConfigDataBanditInfo> m_banditInfos;

		// Token: 0x04001BC3 RID: 7107
		public ConfigDataBattleInfo m_battleInfo;

		// Token: 0x04001BC4 RID: 7108
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04001BC5 RID: 7109
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04001BC6 RID: 7110
		private LuaFunction m_ctor_hotfix;
	}
}
