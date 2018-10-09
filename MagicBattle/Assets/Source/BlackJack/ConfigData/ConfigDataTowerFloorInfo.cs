using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x020002A4 RID: 676
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ConfigDataTowerFloorInfo")]
	[Serializable]
	public class ConfigDataTowerFloorInfo : IExtensible
	{
		// Token: 0x06002C53 RID: 11347 RVA: 0x000B4F44 File Offset: 0x000B3144
		public ConfigDataTowerFloorInfo()
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

		// Token: 0x17000C38 RID: 3128
		// (get) Token: 0x06002C54 RID: 11348 RVA: 0x000B4FCC File Offset: 0x000B31CC
		// (set) Token: 0x06002C55 RID: 11349 RVA: 0x000B4FD4 File Offset: 0x000B31D4
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

		// Token: 0x17000C39 RID: 3129
		// (get) Token: 0x06002C56 RID: 11350 RVA: 0x000B4FE0 File Offset: 0x000B31E0
		// (set) Token: 0x06002C57 RID: 11351 RVA: 0x000B4FE8 File Offset: 0x000B31E8
		[ProtoMember(3, IsRequired = true, Name = "BigFloorName", DataFormat = DataFormat.Default)]
		public string BigFloorName
		{
			get
			{
				return this._BigFloorName;
			}
			set
			{
				this._BigFloorName = value;
			}
		}

		// Token: 0x17000C3A RID: 3130
		// (get) Token: 0x06002C58 RID: 11352 RVA: 0x000B4FF4 File Offset: 0x000B31F4
		// (set) Token: 0x06002C59 RID: 11353 RVA: 0x000B4FFC File Offset: 0x000B31FC
		[ProtoMember(4, IsRequired = true, Name = "Name", DataFormat = DataFormat.Default)]
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

		// Token: 0x17000C3B RID: 3131
		// (get) Token: 0x06002C5A RID: 11354 RVA: 0x000B5008 File Offset: 0x000B3208
		[ProtoMember(5, Name = "RewardList", DataFormat = DataFormat.Default)]
		public List<Goods> RewardList
		{
			get
			{
				return this._RewardList;
			}
		}

		// Token: 0x17000C3C RID: 3132
		// (get) Token: 0x06002C5B RID: 11355 RVA: 0x000B5010 File Offset: 0x000B3210
		[ProtoMember(6, Name = "RandomLevelIdList", DataFormat = DataFormat.TwosComplement)]
		public List<int> RandomLevelIdList
		{
			get
			{
				return this._RandomLevelIdList;
			}
		}

		// Token: 0x17000C3D RID: 3133
		// (get) Token: 0x06002C5C RID: 11356 RVA: 0x000B5018 File Offset: 0x000B3218
		// (set) Token: 0x06002C5D RID: 11357 RVA: 0x000B5020 File Offset: 0x000B3220
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

		// Token: 0x17000C3E RID: 3134
		// (get) Token: 0x06002C5E RID: 11358 RVA: 0x000B502C File Offset: 0x000B322C
		// (set) Token: 0x06002C5F RID: 11359 RVA: 0x000B5034 File Offset: 0x000B3234
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

		// Token: 0x17000C3F RID: 3135
		// (get) Token: 0x06002C60 RID: 11360 RVA: 0x000B5040 File Offset: 0x000B3240
		// (set) Token: 0x06002C61 RID: 11361 RVA: 0x000B5048 File Offset: 0x000B3248
		[ProtoMember(9, IsRequired = true, Name = "MonsterLevel", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x17000C40 RID: 3136
		// (get) Token: 0x06002C62 RID: 11362 RVA: 0x000B5054 File Offset: 0x000B3254
		// (set) Token: 0x06002C63 RID: 11363 RVA: 0x000B505C File Offset: 0x000B325C
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

		// Token: 0x17000C41 RID: 3137
		// (get) Token: 0x06002C64 RID: 11364 RVA: 0x000B5068 File Offset: 0x000B3268
		// (set) Token: 0x06002C65 RID: 11365 RVA: 0x000B5070 File Offset: 0x000B3270
		[ProtoMember(11, IsRequired = true, Name = "BonusSkill_ID", DataFormat = DataFormat.TwosComplement)]
		public int BonusSkill_ID
		{
			get
			{
				return this._BonusSkill_ID;
			}
			set
			{
				this._BonusSkill_ID = value;
			}
		}

		// Token: 0x17000C42 RID: 3138
		// (get) Token: 0x06002C66 RID: 11366 RVA: 0x000B507C File Offset: 0x000B327C
		// (set) Token: 0x06002C67 RID: 11367 RVA: 0x000B5084 File Offset: 0x000B3284
		[ProtoMember(12, IsRequired = true, Name = "HasBonusHero", DataFormat = DataFormat.TwosComplement)]
		public int HasBonusHero
		{
			get
			{
				return this._HasBonusHero;
			}
			set
			{
				this._HasBonusHero = value;
			}
		}

		// Token: 0x17000C43 RID: 3139
		// (get) Token: 0x06002C68 RID: 11368 RVA: 0x000B5090 File Offset: 0x000B3290
		// (set) Token: 0x06002C69 RID: 11369 RVA: 0x000B5098 File Offset: 0x000B3298
		[ProtoMember(13, IsRequired = true, Name = "BonusHeroDesc", DataFormat = DataFormat.Default)]
		public string BonusHeroDesc
		{
			get
			{
				return this._BonusHeroDesc;
			}
			set
			{
				this._BonusHeroDesc = value;
			}
		}

		// Token: 0x17000C44 RID: 3140
		// (get) Token: 0x06002C6A RID: 11370 RVA: 0x000B50A4 File Offset: 0x000B32A4
		[ProtoMember(14, Name = "BonusHeroDescParam", DataFormat = DataFormat.Default)]
		public List<string> BonusHeroDescParam
		{
			get
			{
				return this._BonusHeroDescParam;
			}
		}

		// Token: 0x06002C6B RID: 11371 RVA: 0x000B50AC File Offset: 0x000B32AC
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06002C6C RID: 11372 RVA: 0x000B50BC File Offset: 0x000B32BC
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

		// Token: 0x06002C6D RID: 11373 RVA: 0x000B5188 File Offset: 0x000B3388
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataTowerFloorInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04001B55 RID: 6997
		private int _ID;

		// Token: 0x04001B56 RID: 6998
		private string _BigFloorName;

		// Token: 0x04001B57 RID: 6999
		private string _Name;

		// Token: 0x04001B58 RID: 7000
		private readonly List<Goods> _RewardList = new List<Goods>();

		// Token: 0x04001B59 RID: 7001
		private readonly List<int> _RandomLevelIdList = new List<int>();

		// Token: 0x04001B5A RID: 7002
		private int _EnergySuccess;

		// Token: 0x04001B5B RID: 7003
		private int _EnergyFail;

		// Token: 0x04001B5C RID: 7004
		private int _MonsterLevel;

		// Token: 0x04001B5D RID: 7005
		private int _PlayerExp;

		// Token: 0x04001B5E RID: 7006
		private int _BonusSkill_ID;

		// Token: 0x04001B5F RID: 7007
		private int _HasBonusHero;

		// Token: 0x04001B60 RID: 7008
		private string _BonusHeroDesc;

		// Token: 0x04001B61 RID: 7009
		private readonly List<string> _BonusHeroDescParam = new List<string>();

		// Token: 0x04001B62 RID: 7010
		private IExtension extensionObject;

		// Token: 0x04001B63 RID: 7011
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04001B64 RID: 7012
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04001B65 RID: 7013
		private LuaFunction m_ctor_hotfix;
	}
}
