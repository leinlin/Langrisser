using System;
using System.ComponentModel;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x0200032C RID: 812
	[ProtoContract(Name = "GDBMoonInfo")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class GDBMoonInfo : IExtensible
	{
		// Token: 0x06003030 RID: 12336 RVA: 0x000BE37C File Offset: 0x000BC57C
		public GDBMoonInfo()
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

		// Token: 0x17000DAC RID: 3500
		// (get) Token: 0x06003031 RID: 12337 RVA: 0x000BE3F8 File Offset: 0x000BC5F8
		// (set) Token: 0x06003032 RID: 12338 RVA: 0x000BE400 File Offset: 0x000BC600
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

		// Token: 0x17000DAD RID: 3501
		// (get) Token: 0x06003033 RID: 12339 RVA: 0x000BE40C File Offset: 0x000BC60C
		// (set) Token: 0x06003034 RID: 12340 RVA: 0x000BE414 File Offset: 0x000BC614
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

		// Token: 0x17000DAE RID: 3502
		// (get) Token: 0x06003035 RID: 12341 RVA: 0x000BE420 File Offset: 0x000BC620
		// (set) Token: 0x06003036 RID: 12342 RVA: 0x000BE428 File Offset: 0x000BC628
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

		// Token: 0x17000DAF RID: 3503
		// (get) Token: 0x06003037 RID: 12343 RVA: 0x000BE434 File Offset: 0x000BC634
		// (set) Token: 0x06003038 RID: 12344 RVA: 0x000BE43C File Offset: 0x000BC63C
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

		// Token: 0x17000DB0 RID: 3504
		// (get) Token: 0x06003039 RID: 12345 RVA: 0x000BE448 File Offset: 0x000BC648
		// (set) Token: 0x0600303A RID: 12346 RVA: 0x000BE450 File Offset: 0x000BC650
		[ProtoMember(5, IsRequired = true, Name = "radius", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x17000DB1 RID: 3505
		// (get) Token: 0x0600303B RID: 12347 RVA: 0x000BE45C File Offset: 0x000BC65C
		// (set) Token: 0x0600303C RID: 12348 RVA: 0x000BE464 File Offset: 0x000BC664
		[ProtoMember(6, IsRequired = true, Name = "orbitRadius", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x17000DB2 RID: 3506
		// (get) Token: 0x0600303D RID: 12349 RVA: 0x000BE470 File Offset: 0x000BC670
		// (set) Token: 0x0600303E RID: 12350 RVA: 0x000BE478 File Offset: 0x000BC678
		[ProtoMember(7, IsRequired = true, Name = "orbitalPeriod", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x17000DB3 RID: 3507
		// (get) Token: 0x0600303F RID: 12351 RVA: 0x000BE484 File Offset: 0x000BC684
		// (set) Token: 0x06003040 RID: 12352 RVA: 0x000BE48C File Offset: 0x000BC68C
		[ProtoMember(8, IsRequired = true, Name = "eccentricity", DataFormat = DataFormat.FixedSize)]
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

		// Token: 0x17000DB4 RID: 3508
		// (get) Token: 0x06003041 RID: 12353 RVA: 0x000BE498 File Offset: 0x000BC698
		// (set) Token: 0x06003042 RID: 12354 RVA: 0x000BE4A0 File Offset: 0x000BC6A0
		[ProtoMember(9, IsRequired = true, Name = "mass", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x17000DB5 RID: 3509
		// (get) Token: 0x06003043 RID: 12355 RVA: 0x000BE4AC File Offset: 0x000BC6AC
		// (set) Token: 0x06003044 RID: 12356 RVA: 0x000BE4B4 File Offset: 0x000BC6B4
		[ProtoMember(10, IsRequired = true, Name = "gravity", DataFormat = DataFormat.FixedSize)]
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

		// Token: 0x17000DB6 RID: 3510
		// (get) Token: 0x06003045 RID: 12357 RVA: 0x000BE4C0 File Offset: 0x000BC6C0
		// (set) Token: 0x06003046 RID: 12358 RVA: 0x000BE4C8 File Offset: 0x000BC6C8
		[ProtoMember(11, IsRequired = true, Name = "escapeVelocity", DataFormat = DataFormat.FixedSize)]
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

		// Token: 0x17000DB7 RID: 3511
		// (get) Token: 0x06003047 RID: 12359 RVA: 0x000BE4D4 File Offset: 0x000BC6D4
		// (set) Token: 0x06003048 RID: 12360 RVA: 0x000BE4DC File Offset: 0x000BC6DC
		[ProtoMember(12, IsRequired = true, Name = "temperature", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x17000DB8 RID: 3512
		// (get) Token: 0x06003049 RID: 12361 RVA: 0x000BE4E8 File Offset: 0x000BC6E8
		// (set) Token: 0x0600304A RID: 12362 RVA: 0x000BE4F0 File Offset: 0x000BC6F0
		[ProtoMember(13, IsRequired = true, Name = "artResourcesId", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x17000DB9 RID: 3513
		// (get) Token: 0x0600304B RID: 12363 RVA: 0x000BE4FC File Offset: 0x000BC6FC
		// (set) Token: 0x0600304C RID: 12364 RVA: 0x000BE504 File Offset: 0x000BC704
		[ProtoMember(14, IsRequired = true, Name = "isNeedLocalization", DataFormat = DataFormat.Default)]
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

		// Token: 0x17000DBA RID: 3514
		// (get) Token: 0x0600304D RID: 12365 RVA: 0x000BE510 File Offset: 0x000BC710
		// (set) Token: 0x0600304E RID: 12366 RVA: 0x000BE518 File Offset: 0x000BC718
		[DefaultValue("")]
		[ProtoMember(15, IsRequired = false, Name = "localizationKey", DataFormat = DataFormat.Default)]
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

		// Token: 0x0600304F RID: 12367 RVA: 0x000BE524 File Offset: 0x000BC724
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06003050 RID: 12368 RVA: 0x000BE534 File Offset: 0x000BC734
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

		// Token: 0x06003051 RID: 12369 RVA: 0x000BE600 File Offset: 0x000BC800
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(GDBMoonInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040024CE RID: 9422
		private int _Id;

		// Token: 0x040024CF RID: 9423
		private string _name = string.Empty;

		// Token: 0x040024D0 RID: 9424
		private double _locationX;

		// Token: 0x040024D1 RID: 9425
		private double _locationZ;

		// Token: 0x040024D2 RID: 9426
		private uint _radius;

		// Token: 0x040024D3 RID: 9427
		private ulong _orbitRadius;

		// Token: 0x040024D4 RID: 9428
		private double _orbitalPeriod;

		// Token: 0x040024D5 RID: 9429
		private float _eccentricity;

		// Token: 0x040024D6 RID: 9430
		private double _mass;

		// Token: 0x040024D7 RID: 9431
		private float _gravity;

		// Token: 0x040024D8 RID: 9432
		private float _escapeVelocity;

		// Token: 0x040024D9 RID: 9433
		private uint _temperature;

		// Token: 0x040024DA RID: 9434
		private uint _artResourcesId;

		// Token: 0x040024DB RID: 9435
		private bool _isNeedLocalization;

		// Token: 0x040024DC RID: 9436
		private string _localizationKey = string.Empty;

		// Token: 0x040024DD RID: 9437
		private IExtension extensionObject;

		// Token: 0x040024DE RID: 9438
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040024DF RID: 9439
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040024E0 RID: 9440
		private LuaFunction m_ctor_hotfix;
	}
}
