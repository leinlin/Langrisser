using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x0200029D RID: 669
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ConfigDataTerrainInfo")]
	[Serializable]
	public class ConfigDataTerrainInfo : IExtensible
	{
		// Token: 0x06002BC1 RID: 11201 RVA: 0x000B3ED0 File Offset: 0x000B20D0
		public ConfigDataTerrainInfo()
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

		// Token: 0x17000BFB RID: 3067
		// (get) Token: 0x06002BC2 RID: 11202 RVA: 0x000B3F38 File Offset: 0x000B2138
		// (set) Token: 0x06002BC3 RID: 11203 RVA: 0x000B3F40 File Offset: 0x000B2140
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

		// Token: 0x17000BFC RID: 3068
		// (get) Token: 0x06002BC4 RID: 11204 RVA: 0x000B3F4C File Offset: 0x000B214C
		// (set) Token: 0x06002BC5 RID: 11205 RVA: 0x000B3F54 File Offset: 0x000B2154
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

		// Token: 0x17000BFD RID: 3069
		// (get) Token: 0x06002BC6 RID: 11206 RVA: 0x000B3F60 File Offset: 0x000B2160
		// (set) Token: 0x06002BC7 RID: 11207 RVA: 0x000B3F68 File Offset: 0x000B2168
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

		// Token: 0x17000BFE RID: 3070
		// (get) Token: 0x06002BC8 RID: 11208 RVA: 0x000B3F74 File Offset: 0x000B2174
		// (set) Token: 0x06002BC9 RID: 11209 RVA: 0x000B3F7C File Offset: 0x000B217C
		[ProtoMember(5, IsRequired = true, Name = "MovePoint_Ride", DataFormat = DataFormat.TwosComplement)]
		public int MovePoint_Ride
		{
			get
			{
				return this._MovePoint_Ride;
			}
			set
			{
				this._MovePoint_Ride = value;
			}
		}

		// Token: 0x17000BFF RID: 3071
		// (get) Token: 0x06002BCA RID: 11210 RVA: 0x000B3F88 File Offset: 0x000B2188
		// (set) Token: 0x06002BCB RID: 11211 RVA: 0x000B3F90 File Offset: 0x000B2190
		[ProtoMember(6, IsRequired = true, Name = "MovePoint_Walk", DataFormat = DataFormat.TwosComplement)]
		public int MovePoint_Walk
		{
			get
			{
				return this._MovePoint_Walk;
			}
			set
			{
				this._MovePoint_Walk = value;
			}
		}

		// Token: 0x17000C00 RID: 3072
		// (get) Token: 0x06002BCC RID: 11212 RVA: 0x000B3F9C File Offset: 0x000B219C
		// (set) Token: 0x06002BCD RID: 11213 RVA: 0x000B3FA4 File Offset: 0x000B21A4
		[ProtoMember(7, IsRequired = true, Name = "MovePoint_Water", DataFormat = DataFormat.TwosComplement)]
		public int MovePoint_Water
		{
			get
			{
				return this._MovePoint_Water;
			}
			set
			{
				this._MovePoint_Water = value;
			}
		}

		// Token: 0x17000C01 RID: 3073
		// (get) Token: 0x06002BCE RID: 11214 RVA: 0x000B3FB0 File Offset: 0x000B21B0
		// (set) Token: 0x06002BCF RID: 11215 RVA: 0x000B3FB8 File Offset: 0x000B21B8
		[ProtoMember(8, IsRequired = true, Name = "MovePoint_Fly", DataFormat = DataFormat.TwosComplement)]
		public int MovePoint_Fly
		{
			get
			{
				return this._MovePoint_Fly;
			}
			set
			{
				this._MovePoint_Fly = value;
			}
		}

		// Token: 0x17000C02 RID: 3074
		// (get) Token: 0x06002BD0 RID: 11216 RVA: 0x000B3FC4 File Offset: 0x000B21C4
		// (set) Token: 0x06002BD1 RID: 11217 RVA: 0x000B3FCC File Offset: 0x000B21CC
		[ProtoMember(9, IsRequired = true, Name = "BattleBonus", DataFormat = DataFormat.TwosComplement)]
		public int BattleBonus
		{
			get
			{
				return this._BattleBonus;
			}
			set
			{
				this._BattleBonus = value;
			}
		}

		// Token: 0x17000C03 RID: 3075
		// (get) Token: 0x06002BD2 RID: 11218 RVA: 0x000B3FD8 File Offset: 0x000B21D8
		// (set) Token: 0x06002BD3 RID: 11219 RVA: 0x000B3FE0 File Offset: 0x000B21E0
		[ProtoMember(10, IsRequired = true, Name = "Damage", DataFormat = DataFormat.TwosComplement)]
		public int Damage
		{
			get
			{
				return this._Damage;
			}
			set
			{
				this._Damage = value;
			}
		}

		// Token: 0x17000C04 RID: 3076
		// (get) Token: 0x06002BD4 RID: 11220 RVA: 0x000B3FEC File Offset: 0x000B21EC
		// (set) Token: 0x06002BD5 RID: 11221 RVA: 0x000B3FF4 File Offset: 0x000B21F4
		[ProtoMember(11, IsRequired = true, Name = "Fx", DataFormat = DataFormat.Default)]
		public string Fx
		{
			get
			{
				return this._Fx;
			}
			set
			{
				this._Fx = value;
			}
		}

		// Token: 0x17000C05 RID: 3077
		// (get) Token: 0x06002BD6 RID: 11222 RVA: 0x000B4000 File Offset: 0x000B2200
		// (set) Token: 0x06002BD7 RID: 11223 RVA: 0x000B4008 File Offset: 0x000B2208
		[ProtoMember(12, IsRequired = true, Name = "InfoImage", DataFormat = DataFormat.Default)]
		public string InfoImage
		{
			get
			{
				return this._InfoImage;
			}
			set
			{
				this._InfoImage = value;
			}
		}

		// Token: 0x17000C06 RID: 3078
		// (get) Token: 0x06002BD8 RID: 11224 RVA: 0x000B4014 File Offset: 0x000B2214
		// (set) Token: 0x06002BD9 RID: 11225 RVA: 0x000B401C File Offset: 0x000B221C
		[ProtoMember(13, IsRequired = true, Name = "MapTileImage", DataFormat = DataFormat.Default)]
		public string MapTileImage
		{
			get
			{
				return this._MapTileImage;
			}
			set
			{
				this._MapTileImage = value;
			}
		}

		// Token: 0x17000C07 RID: 3079
		// (get) Token: 0x06002BDA RID: 11226 RVA: 0x000B4028 File Offset: 0x000B2228
		// (set) Token: 0x06002BDB RID: 11227 RVA: 0x000B4030 File Offset: 0x000B2230
		[ProtoMember(14, IsRequired = true, Name = "Background", DataFormat = DataFormat.Default)]
		public string Background
		{
			get
			{
				return this._Background;
			}
			set
			{
				this._Background = value;
			}
		}

		// Token: 0x17000C08 RID: 3080
		// (get) Token: 0x06002BDC RID: 11228 RVA: 0x000B403C File Offset: 0x000B223C
		// (set) Token: 0x06002BDD RID: 11229 RVA: 0x000B4044 File Offset: 0x000B2244
		[ProtoMember(15, IsRequired = true, Name = "ColorR", DataFormat = DataFormat.TwosComplement)]
		public int ColorR
		{
			get
			{
				return this._ColorR;
			}
			set
			{
				this._ColorR = value;
			}
		}

		// Token: 0x17000C09 RID: 3081
		// (get) Token: 0x06002BDE RID: 11230 RVA: 0x000B4050 File Offset: 0x000B2250
		// (set) Token: 0x06002BDF RID: 11231 RVA: 0x000B4058 File Offset: 0x000B2258
		[ProtoMember(16, IsRequired = true, Name = "ColorG", DataFormat = DataFormat.TwosComplement)]
		public int ColorG
		{
			get
			{
				return this._ColorG;
			}
			set
			{
				this._ColorG = value;
			}
		}

		// Token: 0x17000C0A RID: 3082
		// (get) Token: 0x06002BE0 RID: 11232 RVA: 0x000B4064 File Offset: 0x000B2264
		// (set) Token: 0x06002BE1 RID: 11233 RVA: 0x000B406C File Offset: 0x000B226C
		[ProtoMember(17, IsRequired = true, Name = "ColorB", DataFormat = DataFormat.TwosComplement)]
		public int ColorB
		{
			get
			{
				return this._ColorB;
			}
			set
			{
				this._ColorB = value;
			}
		}

		// Token: 0x06002BE2 RID: 11234 RVA: 0x000B4078 File Offset: 0x000B2278
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06002BE3 RID: 11235 RVA: 0x000B4088 File Offset: 0x000B2288
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

		// Token: 0x06002BE4 RID: 11236 RVA: 0x000B4154 File Offset: 0x000B2354
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataTerrainInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04001AF7 RID: 6903
		private int _ID;

		// Token: 0x04001AF8 RID: 6904
		private string _Name;

		// Token: 0x04001AF9 RID: 6905
		private string _Desc;

		// Token: 0x04001AFA RID: 6906
		private int _MovePoint_Ride;

		// Token: 0x04001AFB RID: 6907
		private int _MovePoint_Walk;

		// Token: 0x04001AFC RID: 6908
		private int _MovePoint_Water;

		// Token: 0x04001AFD RID: 6909
		private int _MovePoint_Fly;

		// Token: 0x04001AFE RID: 6910
		private int _BattleBonus;

		// Token: 0x04001AFF RID: 6911
		private int _Damage;

		// Token: 0x04001B00 RID: 6912
		private string _Fx;

		// Token: 0x04001B01 RID: 6913
		private string _InfoImage;

		// Token: 0x04001B02 RID: 6914
		private string _MapTileImage;

		// Token: 0x04001B03 RID: 6915
		private string _Background;

		// Token: 0x04001B04 RID: 6916
		private int _ColorR;

		// Token: 0x04001B05 RID: 6917
		private int _ColorG;

		// Token: 0x04001B06 RID: 6918
		private int _ColorB;

		// Token: 0x04001B07 RID: 6919
		private IExtension extensionObject;

		// Token: 0x04001B08 RID: 6920
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04001B09 RID: 6921
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04001B0A RID: 6922
		private LuaFunction m_ctor_hotfix;
	}
}
