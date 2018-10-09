using System;
using System.ComponentModel;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x02000327 RID: 807
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "GDBSolarSystemSimpleInfo")]
	[Serializable]
	public class GDBSolarSystemSimpleInfo : IExtensible
	{
		// Token: 0x06002FB9 RID: 12217 RVA: 0x000BD6DC File Offset: 0x000BB8DC
		public GDBSolarSystemSimpleInfo()
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

		// Token: 0x17000D78 RID: 3448
		// (get) Token: 0x06002FBA RID: 12218 RVA: 0x000BD750 File Offset: 0x000BB950
		// (set) Token: 0x06002FBB RID: 12219 RVA: 0x000BD758 File Offset: 0x000BB958
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

		// Token: 0x17000D79 RID: 3449
		// (get) Token: 0x06002FBC RID: 12220 RVA: 0x000BD764 File Offset: 0x000BB964
		// (set) Token: 0x06002FBD RID: 12221 RVA: 0x000BD76C File Offset: 0x000BB96C
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

		// Token: 0x17000D7A RID: 3450
		// (get) Token: 0x06002FBE RID: 12222 RVA: 0x000BD778 File Offset: 0x000BB978
		// (set) Token: 0x06002FBF RID: 12223 RVA: 0x000BD780 File Offset: 0x000BB980
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

		// Token: 0x17000D7B RID: 3451
		// (get) Token: 0x06002FC0 RID: 12224 RVA: 0x000BD78C File Offset: 0x000BB98C
		// (set) Token: 0x06002FC1 RID: 12225 RVA: 0x000BD794 File Offset: 0x000BB994
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

		// Token: 0x17000D7C RID: 3452
		// (get) Token: 0x06002FC2 RID: 12226 RVA: 0x000BD7A0 File Offset: 0x000BB9A0
		// (set) Token: 0x06002FC3 RID: 12227 RVA: 0x000BD7A8 File Offset: 0x000BB9A8
		[ProtoMember(5, IsRequired = true, Name = "isNeedLocalization", DataFormat = DataFormat.Default)]
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

		// Token: 0x17000D7D RID: 3453
		// (get) Token: 0x06002FC4 RID: 12228 RVA: 0x000BD7B4 File Offset: 0x000BB9B4
		// (set) Token: 0x06002FC5 RID: 12229 RVA: 0x000BD7BC File Offset: 0x000BB9BC
		[ProtoMember(6, IsRequired = false, Name = "localizationKey", DataFormat = DataFormat.Default)]
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

		// Token: 0x06002FC6 RID: 12230 RVA: 0x000BD7C8 File Offset: 0x000BB9C8
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06002FC7 RID: 12231 RVA: 0x000BD7D8 File Offset: 0x000BB9D8
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

		// Token: 0x06002FC8 RID: 12232 RVA: 0x000BD8A4 File Offset: 0x000BBAA4
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(GDBSolarSystemSimpleInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04002486 RID: 9350
		private int _Id;

		// Token: 0x04002487 RID: 9351
		private string _name;

		// Token: 0x04002488 RID: 9352
		private float _gLocationX;

		// Token: 0x04002489 RID: 9353
		private float _gLocationZ;

		// Token: 0x0400248A RID: 9354
		private bool _isNeedLocalization;

		// Token: 0x0400248B RID: 9355
		private string _localizationKey = string.Empty;

		// Token: 0x0400248C RID: 9356
		private IExtension extensionObject;

		// Token: 0x0400248D RID: 9357
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400248E RID: 9358
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400248F RID: 9359
		private LuaFunction m_ctor_hotfix;
	}
}
