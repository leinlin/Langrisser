using System;
using System.ComponentModel;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x02000331 RID: 817
	[ProtoContract(Name = "GDBLinkInfo")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class GDBLinkInfo : IExtensible
	{
		// Token: 0x06003091 RID: 12433 RVA: 0x000BEF20 File Offset: 0x000BD120
		public GDBLinkInfo()
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

		// Token: 0x17000DD3 RID: 3539
		// (get) Token: 0x06003092 RID: 12434 RVA: 0x000BEF88 File Offset: 0x000BD188
		// (set) Token: 0x06003093 RID: 12435 RVA: 0x000BEF90 File Offset: 0x000BD190
		[DefaultValue(0)]
		[ProtoMember(1, IsRequired = false, Name = "FromStarfieldID", DataFormat = DataFormat.TwosComplement)]
		public int FromStarfieldID
		{
			get
			{
				return this._FromStarfieldID;
			}
			set
			{
				this._FromStarfieldID = value;
			}
		}

		// Token: 0x17000DD4 RID: 3540
		// (get) Token: 0x06003094 RID: 12436 RVA: 0x000BEF9C File Offset: 0x000BD19C
		// (set) Token: 0x06003095 RID: 12437 RVA: 0x000BEFA4 File Offset: 0x000BD1A4
		[DefaultValue(0)]
		[ProtoMember(2, IsRequired = false, Name = "FromStargroupID", DataFormat = DataFormat.TwosComplement)]
		public int FromStargroupID
		{
			get
			{
				return this._FromStargroupID;
			}
			set
			{
				this._FromStargroupID = value;
			}
		}

		// Token: 0x17000DD5 RID: 3541
		// (get) Token: 0x06003096 RID: 12438 RVA: 0x000BEFB0 File Offset: 0x000BD1B0
		// (set) Token: 0x06003097 RID: 12439 RVA: 0x000BEFB8 File Offset: 0x000BD1B8
		[ProtoMember(3, IsRequired = true, Name = "FromSolarSystemID", DataFormat = DataFormat.TwosComplement)]
		public int FromSolarSystemID
		{
			get
			{
				return this._FromSolarSystemID;
			}
			set
			{
				this._FromSolarSystemID = value;
			}
		}

		// Token: 0x17000DD6 RID: 3542
		// (get) Token: 0x06003098 RID: 12440 RVA: 0x000BEFC4 File Offset: 0x000BD1C4
		// (set) Token: 0x06003099 RID: 12441 RVA: 0x000BEFCC File Offset: 0x000BD1CC
		[ProtoMember(4, IsRequired = true, Name = "FromStargateID", DataFormat = DataFormat.TwosComplement)]
		public int FromStargateID
		{
			get
			{
				return this._FromStargateID;
			}
			set
			{
				this._FromStargateID = value;
			}
		}

		// Token: 0x17000DD7 RID: 3543
		// (get) Token: 0x0600309A RID: 12442 RVA: 0x000BEFD8 File Offset: 0x000BD1D8
		// (set) Token: 0x0600309B RID: 12443 RVA: 0x000BEFE0 File Offset: 0x000BD1E0
		[ProtoMember(5, IsRequired = false, Name = "ToStarfieldID", DataFormat = DataFormat.TwosComplement)]
		[DefaultValue(0)]
		public int ToStarfieldID
		{
			get
			{
				return this._ToStarfieldID;
			}
			set
			{
				this._ToStarfieldID = value;
			}
		}

		// Token: 0x17000DD8 RID: 3544
		// (get) Token: 0x0600309C RID: 12444 RVA: 0x000BEFEC File Offset: 0x000BD1EC
		// (set) Token: 0x0600309D RID: 12445 RVA: 0x000BEFF4 File Offset: 0x000BD1F4
		[ProtoMember(6, IsRequired = false, Name = "ToStargroupID", DataFormat = DataFormat.TwosComplement)]
		[DefaultValue(0)]
		public int ToStargroupID
		{
			get
			{
				return this._ToStargroupID;
			}
			set
			{
				this._ToStargroupID = value;
			}
		}

		// Token: 0x17000DD9 RID: 3545
		// (get) Token: 0x0600309E RID: 12446 RVA: 0x000BF000 File Offset: 0x000BD200
		// (set) Token: 0x0600309F RID: 12447 RVA: 0x000BF008 File Offset: 0x000BD208
		[ProtoMember(7, IsRequired = true, Name = "ToSolarSystemID", DataFormat = DataFormat.TwosComplement)]
		public int ToSolarSystemID
		{
			get
			{
				return this._ToSolarSystemID;
			}
			set
			{
				this._ToSolarSystemID = value;
			}
		}

		// Token: 0x17000DDA RID: 3546
		// (get) Token: 0x060030A0 RID: 12448 RVA: 0x000BF014 File Offset: 0x000BD214
		// (set) Token: 0x060030A1 RID: 12449 RVA: 0x000BF01C File Offset: 0x000BD21C
		[ProtoMember(8, IsRequired = true, Name = "ToStargateID", DataFormat = DataFormat.TwosComplement)]
		public int ToStargateID
		{
			get
			{
				return this._ToStargateID;
			}
			set
			{
				this._ToStargateID = value;
			}
		}

		// Token: 0x060030A2 RID: 12450 RVA: 0x000BF028 File Offset: 0x000BD228
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060030A3 RID: 12451 RVA: 0x000BF038 File Offset: 0x000BD238
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

		// Token: 0x060030A4 RID: 12452 RVA: 0x000BF104 File Offset: 0x000BD304
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(GDBLinkInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04002509 RID: 9481
		private int _FromStarfieldID;

		// Token: 0x0400250A RID: 9482
		private int _FromStargroupID;

		// Token: 0x0400250B RID: 9483
		private int _FromSolarSystemID;

		// Token: 0x0400250C RID: 9484
		private int _FromStargateID;

		// Token: 0x0400250D RID: 9485
		private int _ToStarfieldID;

		// Token: 0x0400250E RID: 9486
		private int _ToStargroupID;

		// Token: 0x0400250F RID: 9487
		private int _ToSolarSystemID;

		// Token: 0x04002510 RID: 9488
		private int _ToStargateID;

		// Token: 0x04002511 RID: 9489
		private IExtension extensionObject;

		// Token: 0x04002512 RID: 9490
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04002513 RID: 9491
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04002514 RID: 9492
		private LuaFunction m_ctor_hotfix;
	}
}
