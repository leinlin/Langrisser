using System;
using System.Collections.Generic;
using System.ComponentModel;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x02000324 RID: 804
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "GDBStarfieldsInfo")]
	[Serializable]
	public class GDBStarfieldsInfo : IExtensible
	{
		// Token: 0x06002F85 RID: 12165 RVA: 0x000BD004 File Offset: 0x000BB204
		public GDBStarfieldsInfo()
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

		// Token: 0x17000D62 RID: 3426
		// (get) Token: 0x06002F86 RID: 12166 RVA: 0x000BD08C File Offset: 0x000BB28C
		// (set) Token: 0x06002F87 RID: 12167 RVA: 0x000BD094 File Offset: 0x000BB294
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

		// Token: 0x17000D63 RID: 3427
		// (get) Token: 0x06002F88 RID: 12168 RVA: 0x000BD0A0 File Offset: 0x000BB2A0
		// (set) Token: 0x06002F89 RID: 12169 RVA: 0x000BD0A8 File Offset: 0x000BB2A8
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

		// Token: 0x17000D64 RID: 3428
		// (get) Token: 0x06002F8A RID: 12170 RVA: 0x000BD0B4 File Offset: 0x000BB2B4
		// (set) Token: 0x06002F8B RID: 12171 RVA: 0x000BD0BC File Offset: 0x000BB2BC
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

		// Token: 0x17000D65 RID: 3429
		// (get) Token: 0x06002F8C RID: 12172 RVA: 0x000BD0C8 File Offset: 0x000BB2C8
		// (set) Token: 0x06002F8D RID: 12173 RVA: 0x000BD0D0 File Offset: 0x000BB2D0
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

		// Token: 0x17000D66 RID: 3430
		// (get) Token: 0x06002F8E RID: 12174 RVA: 0x000BD0DC File Offset: 0x000BB2DC
		[ProtoMember(5, Name = "stargroups", DataFormat = DataFormat.Default)]
		public List<GDBStargroupInfo> Stargroups
		{
			get
			{
				return this._stargroups;
			}
		}

		// Token: 0x17000D67 RID: 3431
		// (get) Token: 0x06002F8F RID: 12175 RVA: 0x000BD0E4 File Offset: 0x000BB2E4
		[ProtoMember(6, Name = "LinkList", DataFormat = DataFormat.Default)]
		public List<GDBLinkInfo> LinkList
		{
			get
			{
				return this._LinkList;
			}
		}

		// Token: 0x17000D68 RID: 3432
		// (get) Token: 0x06002F90 RID: 12176 RVA: 0x000BD0EC File Offset: 0x000BB2EC
		// (set) Token: 0x06002F91 RID: 12177 RVA: 0x000BD0F4 File Offset: 0x000BB2F4
		[ProtoMember(7, IsRequired = true, Name = "isNeedLocalization", DataFormat = DataFormat.Default)]
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

		// Token: 0x17000D69 RID: 3433
		// (get) Token: 0x06002F92 RID: 12178 RVA: 0x000BD100 File Offset: 0x000BB300
		// (set) Token: 0x06002F93 RID: 12179 RVA: 0x000BD108 File Offset: 0x000BB308
		[ProtoMember(8, IsRequired = false, Name = "localizationKey", DataFormat = DataFormat.Default)]
		[DefaultValue("")]
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

		// Token: 0x06002F94 RID: 12180 RVA: 0x000BD114 File Offset: 0x000BB314
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06002F95 RID: 12181 RVA: 0x000BD124 File Offset: 0x000BB324
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

		// Token: 0x06002F96 RID: 12182 RVA: 0x000BD1F0 File Offset: 0x000BB3F0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(GDBStarfieldsInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04002464 RID: 9316
		private int _Id;

		// Token: 0x04002465 RID: 9317
		private string _name;

		// Token: 0x04002466 RID: 9318
		private float _gLocationX;

		// Token: 0x04002467 RID: 9319
		private float _gLocationZ;

		// Token: 0x04002468 RID: 9320
		private readonly List<GDBStargroupInfo> _stargroups = new List<GDBStargroupInfo>();

		// Token: 0x04002469 RID: 9321
		private readonly List<GDBLinkInfo> _LinkList = new List<GDBLinkInfo>();

		// Token: 0x0400246A RID: 9322
		private bool _isNeedLocalization;

		// Token: 0x0400246B RID: 9323
		private string _localizationKey = string.Empty;

		// Token: 0x0400246C RID: 9324
		private IExtension extensionObject;

		// Token: 0x0400246D RID: 9325
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400246E RID: 9326
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400246F RID: 9327
		private LuaFunction m_ctor_hotfix;
	}
}
