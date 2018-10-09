using System;
using System.Collections.Generic;
using System.ComponentModel;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x02000328 RID: 808
	[ProtoContract(Name = "GDBSolarSystemInfo")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class GDBSolarSystemInfo : IExtensible
	{
		// Token: 0x06002FC9 RID: 12233 RVA: 0x000BD90C File Offset: 0x000BBB0C
		public GDBSolarSystemInfo()
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

		// Token: 0x17000D7E RID: 3454
		// (get) Token: 0x06002FCA RID: 12234 RVA: 0x000BD9AC File Offset: 0x000BBBAC
		// (set) Token: 0x06002FCB RID: 12235 RVA: 0x000BD9B4 File Offset: 0x000BBBB4
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

		// Token: 0x17000D7F RID: 3455
		// (get) Token: 0x06002FCC RID: 12236 RVA: 0x000BD9C0 File Offset: 0x000BBBC0
		// (set) Token: 0x06002FCD RID: 12237 RVA: 0x000BD9C8 File Offset: 0x000BBBC8
		[ProtoMember(2, IsRequired = true, Name = "name", DataFormat = DataFormat.Default)]
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

		// Token: 0x17000D80 RID: 3456
		// (get) Token: 0x06002FCE RID: 12238 RVA: 0x000BD9D4 File Offset: 0x000BBBD4
		// (set) Token: 0x06002FCF RID: 12239 RVA: 0x000BD9DC File Offset: 0x000BBBDC
		[ProtoMember(3, IsRequired = true, Name = "gLocationX", DataFormat = DataFormat.FixedSize)]
		public float GLocationX
		{
			get
			{
				return this._gLocationX;
			}
			set
			{
				this._gLocationX = value;
			}
		}

		// Token: 0x17000D81 RID: 3457
		// (get) Token: 0x06002FD0 RID: 12240 RVA: 0x000BD9E8 File Offset: 0x000BBBE8
		// (set) Token: 0x06002FD1 RID: 12241 RVA: 0x000BD9F0 File Offset: 0x000BBBF0
		[ProtoMember(4, IsRequired = true, Name = "gLocationZ", DataFormat = DataFormat.FixedSize)]
		public float GLocationZ
		{
			get
			{
				return this._gLocationZ;
			}
			set
			{
				this._gLocationZ = value;
			}
		}

		// Token: 0x17000D82 RID: 3458
		// (get) Token: 0x06002FD2 RID: 12242 RVA: 0x000BD9FC File Offset: 0x000BBBFC
		// (set) Token: 0x06002FD3 RID: 12243 RVA: 0x000BDA04 File Offset: 0x000BBC04
		[ProtoMember(5, IsRequired = true, Name = "star", DataFormat = DataFormat.Default)]
		public GDBStarInfo Star
		{
			get
			{
				return this._star;
			}
			set
			{
				this._star = value;
			}
		}

		// Token: 0x17000D83 RID: 3459
		// (get) Token: 0x06002FD4 RID: 12244 RVA: 0x000BDA10 File Offset: 0x000BBC10
		[ProtoMember(6, Name = "planets", DataFormat = DataFormat.Default)]
		public List<GDBPlanetInfo> Planets
		{
			get
			{
				return this._planets;
			}
		}

		// Token: 0x17000D84 RID: 3460
		// (get) Token: 0x06002FD5 RID: 12245 RVA: 0x000BDA18 File Offset: 0x000BBC18
		// (set) Token: 0x06002FD6 RID: 12246 RVA: 0x000BDA20 File Offset: 0x000BBC20
		[ProtoMember(7, IsRequired = true, Name = "asteroidBeltInfo", DataFormat = DataFormat.Default)]
		public GDBAsteroidBeltInfo AsteroidBeltInfo
		{
			get
			{
				return this._asteroidBeltInfo;
			}
			set
			{
				this._asteroidBeltInfo = value;
			}
		}

		// Token: 0x17000D85 RID: 3461
		// (get) Token: 0x06002FD7 RID: 12247 RVA: 0x000BDA2C File Offset: 0x000BBC2C
		[ProtoMember(8, Name = "spaceStations", DataFormat = DataFormat.Default)]
		public List<GDBSpaceStationInfo> SpaceStations
		{
			get
			{
				return this._spaceStations;
			}
		}

		// Token: 0x17000D86 RID: 3462
		// (get) Token: 0x06002FD8 RID: 12248 RVA: 0x000BDA34 File Offset: 0x000BBC34
		[ProtoMember(9, Name = "starGates", DataFormat = DataFormat.Default)]
		public List<GDBStargateInfo> StarGates
		{
			get
			{
				return this._starGates;
			}
		}

		// Token: 0x17000D87 RID: 3463
		// (get) Token: 0x06002FD9 RID: 12249 RVA: 0x000BDA3C File Offset: 0x000BBC3C
		[ProtoMember(10, Name = "staticScenes", DataFormat = DataFormat.Default)]
		public List<GDBSceneDummyInfo> StaticScenes
		{
			get
			{
				return this._staticScenes;
			}
		}

		// Token: 0x17000D88 RID: 3464
		// (get) Token: 0x06002FDA RID: 12250 RVA: 0x000BDA44 File Offset: 0x000BBC44
		// (set) Token: 0x06002FDB RID: 12251 RVA: 0x000BDA4C File Offset: 0x000BBC4C
		[ProtoMember(11, IsRequired = true, Name = "templateId", DataFormat = DataFormat.TwosComplement)]
		public int TemplateId
		{
			get
			{
				return this._templateId;
			}
			set
			{
				this._templateId = value;
			}
		}

		// Token: 0x17000D89 RID: 3465
		// (get) Token: 0x06002FDC RID: 12252 RVA: 0x000BDA58 File Offset: 0x000BBC58
		// (set) Token: 0x06002FDD RID: 12253 RVA: 0x000BDA60 File Offset: 0x000BBC60
		[ProtoMember(12, IsRequired = true, Name = "isNeedLocalization", DataFormat = DataFormat.Default)]
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

		// Token: 0x17000D8A RID: 3466
		// (get) Token: 0x06002FDE RID: 12254 RVA: 0x000BDA6C File Offset: 0x000BBC6C
		// (set) Token: 0x06002FDF RID: 12255 RVA: 0x000BDA74 File Offset: 0x000BBC74
		[DefaultValue("")]
		[ProtoMember(13, IsRequired = false, Name = "localizationKey", DataFormat = DataFormat.Default)]
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

		// Token: 0x06002FE0 RID: 12256 RVA: 0x000BDA80 File Offset: 0x000BBC80
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06002FE1 RID: 12257 RVA: 0x000BDA90 File Offset: 0x000BBC90
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

		// Token: 0x06002FE2 RID: 12258 RVA: 0x000BDB5C File Offset: 0x000BBD5C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(GDBSolarSystemInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04002490 RID: 9360
		private int _Id;

		// Token: 0x04002491 RID: 9361
		private string _name;

		// Token: 0x04002492 RID: 9362
		private float _gLocationX;

		// Token: 0x04002493 RID: 9363
		private float _gLocationZ;

		// Token: 0x04002494 RID: 9364
		private GDBStarInfo _star;

		// Token: 0x04002495 RID: 9365
		private readonly List<GDBPlanetInfo> _planets = new List<GDBPlanetInfo>();

		// Token: 0x04002496 RID: 9366
		private GDBAsteroidBeltInfo _asteroidBeltInfo;

		// Token: 0x04002497 RID: 9367
		private readonly List<GDBSpaceStationInfo> _spaceStations = new List<GDBSpaceStationInfo>();

		// Token: 0x04002498 RID: 9368
		private readonly List<GDBStargateInfo> _starGates = new List<GDBStargateInfo>();

		// Token: 0x04002499 RID: 9369
		private readonly List<GDBSceneDummyInfo> _staticScenes = new List<GDBSceneDummyInfo>();

		// Token: 0x0400249A RID: 9370
		private int _templateId;

		// Token: 0x0400249B RID: 9371
		private bool _isNeedLocalization;

		// Token: 0x0400249C RID: 9372
		private string _localizationKey = string.Empty;

		// Token: 0x0400249D RID: 9373
		private IExtension extensionObject;

		// Token: 0x0400249E RID: 9374
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400249F RID: 9375
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040024A0 RID: 9376
		private LuaFunction m_ctor_hotfix;
	}
}
