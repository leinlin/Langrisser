using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x0200023D RID: 573
	[ProtoContract(Name = "ConfigDataGuildMassiveCombatLevelInfo")]
	[CustomLuaClass]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ConfigDataGuildMassiveCombatLevelInfo : IExtensible
	{
		// Token: 0x06002357 RID: 9047 RVA: 0x000A515C File Offset: 0x000A335C
		public ConfigDataGuildMassiveCombatLevelInfo()
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

		// Token: 0x17000845 RID: 2117
		// (get) Token: 0x06002358 RID: 9048 RVA: 0x000A51C4 File Offset: 0x000A33C4
		// (set) Token: 0x06002359 RID: 9049 RVA: 0x000A51CC File Offset: 0x000A33CC
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

		// Token: 0x17000846 RID: 2118
		// (get) Token: 0x0600235A RID: 9050 RVA: 0x000A51D8 File Offset: 0x000A33D8
		// (set) Token: 0x0600235B RID: 9051 RVA: 0x000A51E0 File Offset: 0x000A33E0
		[ProtoMember(3, IsRequired = true, Name = "BattleId", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x17000847 RID: 2119
		// (get) Token: 0x0600235C RID: 9052 RVA: 0x000A51EC File Offset: 0x000A33EC
		// (set) Token: 0x0600235D RID: 9053 RVA: 0x000A51F4 File Offset: 0x000A33F4
		[ProtoMember(4, IsRequired = true, Name = "MiniMapResources", DataFormat = DataFormat.Default)]
		public string MiniMapResources
		{
			get
			{
				return this._MiniMapResources;
			}
			set
			{
				this._MiniMapResources = value;
			}
		}

		// Token: 0x17000848 RID: 2120
		// (get) Token: 0x0600235E RID: 9054 RVA: 0x000A5200 File Offset: 0x000A3400
		// (set) Token: 0x0600235F RID: 9055 RVA: 0x000A5208 File Offset: 0x000A3408
		[ProtoMember(5, IsRequired = true, Name = "Strategy", DataFormat = DataFormat.Default)]
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

		// Token: 0x06002360 RID: 9056 RVA: 0x000A5214 File Offset: 0x000A3414
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06002361 RID: 9057 RVA: 0x000A5224 File Offset: 0x000A3424
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

		// Token: 0x06002362 RID: 9058 RVA: 0x000A52F0 File Offset: 0x000A34F0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataGuildMassiveCombatLevelInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04001567 RID: 5479
		private int _ID;

		// Token: 0x04001568 RID: 5480
		private int _BattleId;

		// Token: 0x04001569 RID: 5481
		private string _MiniMapResources;

		// Token: 0x0400156A RID: 5482
		private string _Strategy;

		// Token: 0x0400156B RID: 5483
		private IExtension extensionObject;

		// Token: 0x0400156C RID: 5484
		public ConfigDataBattleInfo m_battleInfo;

		// Token: 0x0400156D RID: 5485
		public ConfigDataGuildMassiveCombatStrongholdInfo m_strongholdInfo;

		// Token: 0x0400156E RID: 5486
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400156F RID: 5487
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04001570 RID: 5488
		private LuaFunction m_ctor_hotfix;
	}
}
