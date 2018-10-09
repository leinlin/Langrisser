using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x02000294 RID: 660
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ConfigDataSST_1_EN")]
	[Serializable]
	public class ConfigDataSST_1_EN : IExtensible
	{
		// Token: 0x06002B73 RID: 11123 RVA: 0x000B2E0C File Offset: 0x000B100C
		public ConfigDataSST_1_EN()
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

		// Token: 0x17000BE5 RID: 3045
		// (get) Token: 0x06002B74 RID: 11124 RVA: 0x000B2E74 File Offset: 0x000B1074
		// (set) Token: 0x06002B75 RID: 11125 RVA: 0x000B2E7C File Offset: 0x000B107C
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

		// Token: 0x17000BE6 RID: 3046
		// (get) Token: 0x06002B76 RID: 11126 RVA: 0x000B2E88 File Offset: 0x000B1088
		// (set) Token: 0x06002B77 RID: 11127 RVA: 0x000B2E90 File Offset: 0x000B1090
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

		// Token: 0x06002B78 RID: 11128 RVA: 0x000B2E9C File Offset: 0x000B109C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06002B79 RID: 11129 RVA: 0x000B2EAC File Offset: 0x000B10AC
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

		// Token: 0x06002B7A RID: 11130 RVA: 0x000B2F78 File Offset: 0x000B1178
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataSST_1_EN));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04001ABD RID: 6845
		private int _ID;

		// Token: 0x04001ABE RID: 6846
		private string _Value;

		// Token: 0x04001ABF RID: 6847
		private IExtension extensionObject;

		// Token: 0x04001AC0 RID: 6848
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04001AC1 RID: 6849
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04001AC2 RID: 6850
		private LuaFunction m_ctor_hotfix;
	}
}
