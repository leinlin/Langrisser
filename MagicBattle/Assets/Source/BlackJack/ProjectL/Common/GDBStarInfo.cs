using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x0200032A RID: 810
	[ProtoContract(Name = "GDBStarInfo")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class GDBStarInfo : IExtensible
	{
		// Token: 0x06002FF5 RID: 12277 RVA: 0x000BDE08 File Offset: 0x000BC008
		public GDBStarInfo()
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

		// Token: 0x17000D92 RID: 3474
		// (get) Token: 0x06002FF6 RID: 12278 RVA: 0x000BDE70 File Offset: 0x000BC070
		// (set) Token: 0x06002FF7 RID: 12279 RVA: 0x000BDE78 File Offset: 0x000BC078
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

		// Token: 0x17000D93 RID: 3475
		// (get) Token: 0x06002FF8 RID: 12280 RVA: 0x000BDE84 File Offset: 0x000BC084
		// (set) Token: 0x06002FF9 RID: 12281 RVA: 0x000BDE8C File Offset: 0x000BC08C
		[ProtoMember(2, IsRequired = true, Name = "age", DataFormat = DataFormat.TwosComplement)]
		public uint Age
		{
			get
			{
				return this._age;
			}
			set
			{
				this._age = value;
			}
		}

		// Token: 0x17000D94 RID: 3476
		// (get) Token: 0x06002FFA RID: 12282 RVA: 0x000BDE98 File Offset: 0x000BC098
		// (set) Token: 0x06002FFB RID: 12283 RVA: 0x000BDEA0 File Offset: 0x000BC0A0
		[ProtoMember(3, IsRequired = true, Name = "spectrum", DataFormat = DataFormat.TwosComplement)]
		public uint Spectrum
		{
			get
			{
				return this._spectrum;
			}
			set
			{
				this._spectrum = value;
			}
		}

		// Token: 0x17000D95 RID: 3477
		// (get) Token: 0x06002FFC RID: 12284 RVA: 0x000BDEAC File Offset: 0x000BC0AC
		// (set) Token: 0x06002FFD RID: 12285 RVA: 0x000BDEB4 File Offset: 0x000BC0B4
		[ProtoMember(4, IsRequired = true, Name = "brightness", DataFormat = DataFormat.TwosComplement)]
		public double Brightness
		{
			get
			{
				return this._brightness;
			}
			set
			{
				this._brightness = value;
			}
		}

		// Token: 0x17000D96 RID: 3478
		// (get) Token: 0x06002FFE RID: 12286 RVA: 0x000BDEC0 File Offset: 0x000BC0C0
		// (set) Token: 0x06002FFF RID: 12287 RVA: 0x000BDEC8 File Offset: 0x000BC0C8
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

		// Token: 0x17000D97 RID: 3479
		// (get) Token: 0x06003000 RID: 12288 RVA: 0x000BDED4 File Offset: 0x000BC0D4
		// (set) Token: 0x06003001 RID: 12289 RVA: 0x000BDEDC File Offset: 0x000BC0DC
		[ProtoMember(6, IsRequired = true, Name = "temperature", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x17000D98 RID: 3480
		// (get) Token: 0x06003002 RID: 12290 RVA: 0x000BDEE8 File Offset: 0x000BC0E8
		// (set) Token: 0x06003003 RID: 12291 RVA: 0x000BDEF0 File Offset: 0x000BC0F0
		[ProtoMember(7, IsRequired = true, Name = "artResourcesId", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x17000D99 RID: 3481
		// (get) Token: 0x06003004 RID: 12292 RVA: 0x000BDEFC File Offset: 0x000BC0FC
		// (set) Token: 0x06003005 RID: 12293 RVA: 0x000BDF04 File Offset: 0x000BC104
		[ProtoMember(8, IsRequired = true, Name = "Mass", DataFormat = DataFormat.TwosComplement)]
		public double Mass
		{
			get
			{
				return this._Mass;
			}
			set
			{
				this._Mass = value;
			}
		}

		// Token: 0x17000D9A RID: 3482
		// (get) Token: 0x06003006 RID: 12294 RVA: 0x000BDF10 File Offset: 0x000BC110
		// (set) Token: 0x06003007 RID: 12295 RVA: 0x000BDF18 File Offset: 0x000BC118
		[ProtoMember(9, IsRequired = true, Name = "templateId", DataFormat = DataFormat.TwosComplement)]
		public uint TemplateId
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

		// Token: 0x06003008 RID: 12296 RVA: 0x000BDF24 File Offset: 0x000BC124
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06003009 RID: 12297 RVA: 0x000BDF34 File Offset: 0x000BC134
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

		// Token: 0x0600300A RID: 12298 RVA: 0x000BE000 File Offset: 0x000BC200
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(GDBStarInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040024AC RID: 9388
		private int _Id;

		// Token: 0x040024AD RID: 9389
		private uint _age;

		// Token: 0x040024AE RID: 9390
		private uint _spectrum;

		// Token: 0x040024AF RID: 9391
		private double _brightness;

		// Token: 0x040024B0 RID: 9392
		private uint _radius;

		// Token: 0x040024B1 RID: 9393
		private uint _temperature;

		// Token: 0x040024B2 RID: 9394
		private uint _artResourcesId;

		// Token: 0x040024B3 RID: 9395
		private double _Mass;

		// Token: 0x040024B4 RID: 9396
		private uint _templateId;

		// Token: 0x040024B5 RID: 9397
		private IExtension extensionObject;

		// Token: 0x040024B6 RID: 9398
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040024B7 RID: 9399
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040024B8 RID: 9400
		private LuaFunction m_ctor_hotfix;
	}
}
