using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x02000292 RID: 658
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ConfigDataSST_0_EN")]
	[Serializable]
	public class ConfigDataSST_0_EN : IExtensible
	{
		// Token: 0x06002B63 RID: 11107 RVA: 0x000B2A64 File Offset: 0x000B0C64
		public ConfigDataSST_0_EN()
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

		// Token: 0x17000BE1 RID: 3041
		// (get) Token: 0x06002B64 RID: 11108 RVA: 0x000B2ACC File Offset: 0x000B0CCC
		// (set) Token: 0x06002B65 RID: 11109 RVA: 0x000B2AD4 File Offset: 0x000B0CD4
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

		// Token: 0x17000BE2 RID: 3042
		// (get) Token: 0x06002B66 RID: 11110 RVA: 0x000B2AE0 File Offset: 0x000B0CE0
		// (set) Token: 0x06002B67 RID: 11111 RVA: 0x000B2AE8 File Offset: 0x000B0CE8
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

		// Token: 0x06002B68 RID: 11112 RVA: 0x000B2AF4 File Offset: 0x000B0CF4
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06002B69 RID: 11113 RVA: 0x000B2B04 File Offset: 0x000B0D04
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

		// Token: 0x06002B6A RID: 11114 RVA: 0x000B2BD0 File Offset: 0x000B0DD0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataSST_0_EN));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04001AB1 RID: 6833
		private int _ID;

		// Token: 0x04001AB2 RID: 6834
		private string _Value;

		// Token: 0x04001AB3 RID: 6835
		private IExtension extensionObject;

		// Token: 0x04001AB4 RID: 6836
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04001AB5 RID: 6837
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04001AB6 RID: 6838
		private LuaFunction m_ctor_hotfix;
	}
}
