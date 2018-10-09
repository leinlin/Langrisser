using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x02000291 RID: 657
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ConfigDataSST_0_CN")]
	[Serializable]
	public class ConfigDataSST_0_CN : IExtensible
	{
		// Token: 0x06002B5B RID: 11099 RVA: 0x000B2890 File Offset: 0x000B0A90
		public ConfigDataSST_0_CN()
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

		// Token: 0x17000BDF RID: 3039
		// (get) Token: 0x06002B5C RID: 11100 RVA: 0x000B28F8 File Offset: 0x000B0AF8
		// (set) Token: 0x06002B5D RID: 11101 RVA: 0x000B2900 File Offset: 0x000B0B00
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

		// Token: 0x17000BE0 RID: 3040
		// (get) Token: 0x06002B5E RID: 11102 RVA: 0x000B290C File Offset: 0x000B0B0C
		// (set) Token: 0x06002B5F RID: 11103 RVA: 0x000B2914 File Offset: 0x000B0B14
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

		// Token: 0x06002B60 RID: 11104 RVA: 0x000B2920 File Offset: 0x000B0B20
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06002B61 RID: 11105 RVA: 0x000B2930 File Offset: 0x000B0B30
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

		// Token: 0x06002B62 RID: 11106 RVA: 0x000B29FC File Offset: 0x000B0BFC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataSST_0_CN));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04001AAB RID: 6827
		private int _ID;

		// Token: 0x04001AAC RID: 6828
		private string _Value;

		// Token: 0x04001AAD RID: 6829
		private IExtension extensionObject;

		// Token: 0x04001AAE RID: 6830
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04001AAF RID: 6831
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04001AB0 RID: 6832
		private LuaFunction m_ctor_hotfix;
	}
}
