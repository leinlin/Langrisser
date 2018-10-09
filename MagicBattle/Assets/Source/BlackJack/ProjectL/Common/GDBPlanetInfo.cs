using System;
using System.Collections.Generic;
using System.ComponentModel;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x0200032B RID: 811
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "GDBPlanetInfo")]
	[Serializable]
	public class GDBPlanetInfo : IExtensible
	{
		// Token: 0x0600300B RID: 12299 RVA: 0x000BE068 File Offset: 0x000BC268
		public GDBPlanetInfo()
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

		// Token: 0x17000D9B RID: 3483
		// (get) Token: 0x0600300C RID: 12300 RVA: 0x000BE0F0 File Offset: 0x000BC2F0
		// (set) Token: 0x0600300D RID: 12301 RVA: 0x000BE0F8 File Offset: 0x000BC2F8
		[ProtoMember(1, IsRequired = true, Name = "Id", DataFormat = DataFormat.TwosComplement)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				this._Id = value;
			}
		}

		// Token: 0x17000D9C RID: 3484
		// (get) Token: 0x0600300E RID: 12302 RVA: 0x000BE104 File Offset: 0x000BC304
		// (set) Token: 0x0600300F RID: 12303 RVA: 0x000BE10C File Offset: 0x000BC30C
		[DefaultValue("")]
		[ProtoMember(2, IsRequired = false, Name = "name", DataFormat = DataFormat.Default)]
		public string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				this._name = value;
			}
		}

		// Token: 0x17000D9D RID: 3485
		// (get) Token: 0x06003010 RID: 12304 RVA: 0x000BE118 File Offset: 0x000BC318
		// (set) Token: 0x06003011 RID: 12305 RVA: 0x000BE120 File Offset: 0x000BC320
		[ProtoMember(3, IsRequired = true, Name = "locationX", DataFormat = DataFormat.TwosComplement)]
		public double LocationX
		{
			get
			{
				return this._locationX;
			}
			set
			{
				this._locationX = value;
			}
		}

		// Token: 0x17000D9E RID: 3486
		// (get) Token: 0x06003012 RID: 12306 RVA: 0x000BE12C File Offset: 0x000BC32C
		// (set) Token: 0x06003013 RID: 12307 RVA: 0x000BE134 File Offset: 0x000BC334
		[ProtoMember(4, IsRequired = true, Name = "locationZ", DataFormat = DataFormat.TwosComplement)]
		public double LocationZ
		{
			get
			{
				return this._locationZ;
			}
			set
			{
				this._locationZ = value;
			}
		}

		// Token: 0x17000D9F RID: 3487
		// (get) Token: 0x06003014 RID: 12308 RVA: 0x000BE140 File Offset: 0x000BC340
		// (set) Token: 0x06003015 RID: 12309 RVA: 0x000BE148 File Offset: 0x000BC348
		[ProtoMember(5, IsRequired = true, Name = "type", DataFormat = DataFormat.TwosComplement)]
		public uint Type
		{
			get
			{
				return this._type;
			}
			set
			{
				this._type = value;
			}
		}

		// Token: 0x17000DA0 RID: 3488
		// (get) Token: 0x06003016 RID: 12310 RVA: 0x000BE154 File Offset: 0x000BC354
		// (set) Token: 0x06003017 RID: 12311 RVA: 0x000BE15C File Offset: 0x000BC35C
		[ProtoMember(6, IsRequired = true, Name = "radius", DataFormat = DataFormat.TwosComplement)]
		public uint Radius
		{
			get
			{
				return this._radius;
			}
			set
			{
				this._radius = value;
			}
		}

		// Token: 0x17000DA1 RID: 3489
		// (get) Token: 0x06003018 RID: 12312 RVA: 0x000BE168 File Offset: 0x000BC368
		// (set) Token: 0x06003019 RID: 12313 RVA: 0x000BE170 File Offset: 0x000BC370
		[ProtoMember(7, IsRequired = true, Name = "orbitRadius", DataFormat = DataFormat.TwosComplement)]
		public ulong OrbitRadius
		{
			get
			{
				return this._orbitRadius;
			}
			set
			{
				this._orbitRadius = value;
			}
		}

		// Token: 0x17000DA2 RID: 3490
		// (get) Token: 0x0600301A RID: 12314 RVA: 0x000BE17C File Offset: 0x000BC37C
		// (set) Token: 0x0600301B RID: 12315 RVA: 0x000BE184 File Offset: 0x000BC384
		[ProtoMember(8, IsRequired = true, Name = "orbitalPeriod", DataFormat = DataFormat.TwosComplement)]
		public double OrbitalPeriod
		{
			get
			{
				return this._orbitalPeriod;
			}
			set
			{
				this._orbitalPeriod = value;
			}
		}

		// Token: 0x17000DA3 RID: 3491
		// (get) Token: 0x0600301C RID: 12316 RVA: 0x000BE190 File Offset: 0x000BC390
		// (set) Token: 0x0600301D RID: 12317 RVA: 0x000BE198 File Offset: 0x000BC398
		[ProtoMember(9, IsRequired = true, Name = "eccentricity", DataFormat = DataFormat.FixedSize)]
		public float Eccentricity
		{
			get
			{
				return this._eccentricity;
			}
			set
			{
				this._eccentricity = value;
			}
		}

		// Token: 0x17000DA4 RID: 3492
		// (get) Token: 0x0600301E RID: 12318 RVA: 0x000BE1A4 File Offset: 0x000BC3A4
		// (set) Token: 0x0600301F RID: 12319 RVA: 0x000BE1AC File Offset: 0x000BC3AC
		[ProtoMember(10, IsRequired = true, Name = "mass", DataFormat = DataFormat.TwosComplement)]
		public double Mass
		{
			get
			{
				return this._mass;
			}
			set
			{
				this._mass = value;
			}
		}

		// Token: 0x17000DA5 RID: 3493
		// (get) Token: 0x06003020 RID: 12320 RVA: 0x000BE1B8 File Offset: 0x000BC3B8
		// (set) Token: 0x06003021 RID: 12321 RVA: 0x000BE1C0 File Offset: 0x000BC3C0
		[ProtoMember(11, IsRequired = true, Name = "gravity", DataFormat = DataFormat.FixedSize)]
		public float Gravity
		{
			get
			{
				return this._gravity;
			}
			set
			{
				this._gravity = value;
			}
		}

		// Token: 0x17000DA6 RID: 3494
		// (get) Token: 0x06003022 RID: 12322 RVA: 0x000BE1CC File Offset: 0x000BC3CC
		// (set) Token: 0x06003023 RID: 12323 RVA: 0x000BE1D4 File Offset: 0x000BC3D4
		[ProtoMember(12, IsRequired = true, Name = "escapeVelocity", DataFormat = DataFormat.FixedSize)]
		public float EscapeVelocity
		{
			get
			{
				return this._escapeVelocity;
			}
			set
			{
				this._escapeVelocity = value;
			}
		}

		// Token: 0x17000DA7 RID: 3495
		// (get) Token: 0x06003024 RID: 12324 RVA: 0x000BE1E0 File Offset: 0x000BC3E0
		// (set) Token: 0x06003025 RID: 12325 RVA: 0x000BE1E8 File Offset: 0x000BC3E8
		[ProtoMember(13, IsRequired = true, Name = "temperature", DataFormat = DataFormat.TwosComplement)]
		public uint Temperature
		{
			get
			{
				return this._temperature;
			}
			set
			{
				this._temperature = value;
			}
		}

		// Token: 0x17000DA8 RID: 3496
		// (get) Token: 0x06003026 RID: 12326 RVA: 0x000BE1F4 File Offset: 0x000BC3F4
		// (set) Token: 0x06003027 RID: 12327 RVA: 0x000BE1FC File Offset: 0x000BC3FC
		[ProtoMember(14, IsRequired = true, Name = "artResourcesId", DataFormat = DataFormat.TwosComplement)]
		public uint ArtResourcesId
		{
			get
			{
				return this._artResourcesId;
			}
			set
			{
				this._artResourcesId = value;
			}
		}

		// Token: 0x17000DA9 RID: 3497
		// (get) Token: 0x06003028 RID: 12328 RVA: 0x000BE208 File Offset: 0x000BC408
		[ProtoMember(15, Name = "moons", DataFormat = DataFormat.Default)]
		public List<GDBMoonInfo> Moons
		{
			get
			{
				return this._moons;
			}
		}

		// Token: 0x17000DAA RID: 3498
		// (get) Token: 0x06003029 RID: 12329 RVA: 0x000BE210 File Offset: 0x000BC410
		// (set) Token: 0x0600302A RID: 12330 RVA: 0x000BE218 File Offset: 0x000BC418
		[ProtoMember(16, IsRequired = true, Name = "isNeedLocalization", DataFormat = DataFormat.Default)]
		public bool IsNeedLocalization
		{
			get
			{
				return this._isNeedLocalization;
			}
			set
			{
				this._isNeedLocalization = value;
			}
		}

		// Token: 0x17000DAB RID: 3499
		// (get) Token: 0x0600302B RID: 12331 RVA: 0x000BE224 File Offset: 0x000BC424
		// (set) Token: 0x0600302C RID: 12332 RVA: 0x000BE22C File Offset: 0x000BC42C
		[DefaultValue("")]
		[ProtoMember(17, IsRequired = false, Name = "localizationKey", DataFormat = DataFormat.Default)]
		public string LocalizationKey
		{
			get
			{
				return this._localizationKey;
			}
			set
			{
				this._localizationKey = value;
			}
		}

		// Token: 0x0600302D RID: 12333 RVA: 0x000BE238 File Offset: 0x000BC438
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x0600302E RID: 12334 RVA: 0x000BE248 File Offset: 0x000BC448
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

		// Token: 0x0600302F RID: 12335 RVA: 0x000BE314 File Offset: 0x000BC514
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(GDBPlanetInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040024B9 RID: 9401
		private int _Id;

		// Token: 0x040024BA RID: 9402
		private string _name = string.Empty;

		// Token: 0x040024BB RID: 9403
		private double _locationX;

		// Token: 0x040024BC RID: 9404
		private double _locationZ;

		// Token: 0x040024BD RID: 9405
		private uint _type;

		// Token: 0x040024BE RID: 9406
		private uint _radius;

		// Token: 0x040024BF RID: 9407
		private ulong _orbitRadius;

		// Token: 0x040024C0 RID: 9408
		private double _orbitalPeriod;

		// Token: 0x040024C1 RID: 9409
		private float _eccentricity;

		// Token: 0x040024C2 RID: 9410
		private double _mass;

		// Token: 0x040024C3 RID: 9411
		private float _gravity;

		// Token: 0x040024C4 RID: 9412
		private float _escapeVelocity;

		// Token: 0x040024C5 RID: 9413
		private uint _temperature;

		// Token: 0x040024C6 RID: 9414
		private uint _artResourcesId;

		// Token: 0x040024C7 RID: 9415
		private readonly List<GDBMoonInfo> _moons = new List<GDBMoonInfo>();

		// Token: 0x040024C8 RID: 9416
		private bool _isNeedLocalization;

		// Token: 0x040024C9 RID: 9417
		private string _localizationKey = string.Empty;

		// Token: 0x040024CA RID: 9418
		private IExtension extensionObject;

		// Token: 0x040024CB RID: 9419
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040024CC RID: 9420
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040024CD RID: 9421
		private LuaFunction m_ctor_hotfix;
	}
}
