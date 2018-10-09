using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x02000299 RID: 665
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ConfigDataST_CN")]
	[Serializable]
	public class ConfigDataST_CN : IExtensible
	{
		// Token: 0x06002BA0 RID: 11168 RVA: 0x000B376C File Offset: 0x000B196C
		public ConfigDataST_CN()
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

		// Token: 0x17000BF2 RID: 3058
		// (get) Token: 0x06002BA1 RID: 11169 RVA: 0x000B37D4 File Offset: 0x000B19D4
		// (set) Token: 0x06002BA2 RID: 11170 RVA: 0x000B37DC File Offset: 0x000B19DC
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

		// Token: 0x17000BF3 RID: 3059
		// (get) Token: 0x06002BA3 RID: 11171 RVA: 0x000B37E8 File Offset: 0x000B19E8
		// (set) Token: 0x06002BA4 RID: 11172 RVA: 0x000B37F0 File Offset: 0x000B19F0
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

		// Token: 0x06002BA5 RID: 11173 RVA: 0x000B37FC File Offset: 0x000B19FC
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06002BA6 RID: 11174 RVA: 0x000B380C File Offset: 0x000B1A0C
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

		// Token: 0x06002BA7 RID: 11175 RVA: 0x000B38D8 File Offset: 0x000B1AD8
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataST_CN));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04001ADE RID: 6878
		private int _ID;

		// Token: 0x04001ADF RID: 6879
		private string _Value;

		// Token: 0x04001AE0 RID: 6880
		private IExtension extensionObject;

		// Token: 0x04001AE1 RID: 6881
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04001AE2 RID: 6882
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04001AE3 RID: 6883
		private LuaFunction m_ctor_hotfix;
	}
}
