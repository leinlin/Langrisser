using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x02000297 RID: 663
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ConfigDataStringTable")]
	[Serializable]
	public class ConfigDataStringTable : IExtensible
	{
		// Token: 0x06002B8E RID: 11150 RVA: 0x000B33B0 File Offset: 0x000B15B0
		public ConfigDataStringTable()
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

		// Token: 0x17000BED RID: 3053
		// (get) Token: 0x06002B8F RID: 11151 RVA: 0x000B3418 File Offset: 0x000B1618
		// (set) Token: 0x06002B90 RID: 11152 RVA: 0x000B3420 File Offset: 0x000B1620
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

		// Token: 0x17000BEE RID: 3054
		// (get) Token: 0x06002B91 RID: 11153 RVA: 0x000B342C File Offset: 0x000B162C
		// (set) Token: 0x06002B92 RID: 11154 RVA: 0x000B3434 File Offset: 0x000B1634
		[ProtoMember(4, IsRequired = true, Name = "Value", DataFormat = DataFormat.Default)]
		public string Value
		{
			get
			{
				return this._Value;
			}
			set
			{
				this._Value = value;
			}
		}

		// Token: 0x17000BEF RID: 3055
		// (get) Token: 0x06002B93 RID: 11155 RVA: 0x000B3440 File Offset: 0x000B1640
		// (set) Token: 0x06002B94 RID: 11156 RVA: 0x000B3448 File Offset: 0x000B1648
		[ProtoMember(5, IsRequired = true, Name = "ValueStrKey", DataFormat = DataFormat.Default)]
		public string ValueStrKey
		{
			get
			{
				return this._ValueStrKey;
			}
			set
			{
				this._ValueStrKey = value;
			}
		}

		// Token: 0x06002B95 RID: 11157 RVA: 0x000B3454 File Offset: 0x000B1654
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06002B96 RID: 11158 RVA: 0x000B3464 File Offset: 0x000B1664
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

		// Token: 0x06002B97 RID: 11159 RVA: 0x000B3530 File Offset: 0x000B1730
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataStringTable));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04001AD1 RID: 6865
		private int _ID;

		// Token: 0x04001AD2 RID: 6866
		private string _Value;

		// Token: 0x04001AD3 RID: 6867
		private string _ValueStrKey;

		// Token: 0x04001AD4 RID: 6868
		private IExtension extensionObject;

		// Token: 0x04001AD5 RID: 6869
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04001AD6 RID: 6870
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04001AD7 RID: 6871
		private LuaFunction m_ctor_hotfix;
	}
}
