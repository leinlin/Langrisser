using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x02000296 RID: 662
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ConfigDataStoreInfo")]
	[Serializable]
	public class ConfigDataStoreInfo : IExtensible
	{
		// Token: 0x06002B82 RID: 11138 RVA: 0x000B31B4 File Offset: 0x000B13B4
		public ConfigDataStoreInfo()
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

		// Token: 0x17000BE9 RID: 3049
		// (get) Token: 0x06002B83 RID: 11139 RVA: 0x000B321C File Offset: 0x000B141C
		// (set) Token: 0x06002B84 RID: 11140 RVA: 0x000B3224 File Offset: 0x000B1424
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

		// Token: 0x17000BEA RID: 3050
		// (get) Token: 0x06002B85 RID: 11141 RVA: 0x000B3230 File Offset: 0x000B1430
		// (set) Token: 0x06002B86 RID: 11142 RVA: 0x000B3238 File Offset: 0x000B1438
		[ProtoMember(3, IsRequired = true, Name = "StoreID", DataFormat = DataFormat.TwosComplement)]
		public StoreId StoreID
		{
			get
			{
				return this._StoreID;
			}
			set
			{
				this._StoreID = value;
			}
		}

		// Token: 0x17000BEB RID: 3051
		// (get) Token: 0x06002B87 RID: 11143 RVA: 0x000B3244 File Offset: 0x000B1444
		// (set) Token: 0x06002B88 RID: 11144 RVA: 0x000B324C File Offset: 0x000B144C
		[ProtoMember(4, IsRequired = true, Name = "Type", DataFormat = DataFormat.TwosComplement)]
		public StoreType Type
		{
			get
			{
				return this._Type;
			}
			set
			{
				this._Type = value;
			}
		}

		// Token: 0x17000BEC RID: 3052
		// (get) Token: 0x06002B89 RID: 11145 RVA: 0x000B3258 File Offset: 0x000B1458
		// (set) Token: 0x06002B8A RID: 11146 RVA: 0x000B3260 File Offset: 0x000B1460
		[ProtoMember(5, IsRequired = true, Name = "StoreName", DataFormat = DataFormat.Default)]
		public string StoreName
		{
			get
			{
				return this._StoreName;
			}
			set
			{
				this._StoreName = value;
			}
		}

		// Token: 0x06002B8B RID: 11147 RVA: 0x000B326C File Offset: 0x000B146C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06002B8C RID: 11148 RVA: 0x000B327C File Offset: 0x000B147C
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

		// Token: 0x06002B8D RID: 11149 RVA: 0x000B3348 File Offset: 0x000B1548
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataStoreInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04001AC9 RID: 6857
		private int _ID;

		// Token: 0x04001ACA RID: 6858
		private StoreId _StoreID;

		// Token: 0x04001ACB RID: 6859
		private StoreType _Type;

		// Token: 0x04001ACC RID: 6860
		private string _StoreName;

		// Token: 0x04001ACD RID: 6861
		private IExtension extensionObject;

		// Token: 0x04001ACE RID: 6862
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04001ACF RID: 6863
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04001AD0 RID: 6864
		private LuaFunction m_ctor_hotfix;
	}
}
