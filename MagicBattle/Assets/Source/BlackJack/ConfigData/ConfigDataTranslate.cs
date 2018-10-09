using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x020002AB RID: 683
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ConfigDataTranslate")]
	[Serializable]
	public class ConfigDataTranslate : IExtensible
	{
		// Token: 0x06002CD0 RID: 11472 RVA: 0x000B5F54 File Offset: 0x000B4154
		public ConfigDataTranslate()
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

		// Token: 0x17000C6F RID: 3183
		// (get) Token: 0x06002CD1 RID: 11473 RVA: 0x000B5FBC File Offset: 0x000B41BC
		// (set) Token: 0x06002CD2 RID: 11474 RVA: 0x000B5FC4 File Offset: 0x000B41C4
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

		// Token: 0x17000C70 RID: 3184
		// (get) Token: 0x06002CD3 RID: 11475 RVA: 0x000B5FD0 File Offset: 0x000B41D0
		// (set) Token: 0x06002CD4 RID: 11476 RVA: 0x000B5FD8 File Offset: 0x000B41D8
		[ProtoMember(3, IsRequired = true, Name = "Chinese", DataFormat = DataFormat.Default)]
		public string Chinese
		{
			get
			{
				return this._Chinese;
			}
			set
			{
				this._Chinese = value;
			}
		}

		// Token: 0x17000C71 RID: 3185
		// (get) Token: 0x06002CD5 RID: 11477 RVA: 0x000B5FE4 File Offset: 0x000B41E4
		// (set) Token: 0x06002CD6 RID: 11478 RVA: 0x000B5FEC File Offset: 0x000B41EC
		[ProtoMember(4, IsRequired = true, Name = "TargetLanguage", DataFormat = DataFormat.Default)]
		public string TargetLanguage
		{
			get
			{
				return this._TargetLanguage;
			}
			set
			{
				this._TargetLanguage = value;
			}
		}

		// Token: 0x06002CD7 RID: 11479 RVA: 0x000B5FF8 File Offset: 0x000B41F8
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06002CD8 RID: 11480 RVA: 0x000B6008 File Offset: 0x000B4208
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

		// Token: 0x06002CD9 RID: 11481 RVA: 0x000B60D4 File Offset: 0x000B42D4
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataTranslate));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04001BAC RID: 7084
		private int _ID;

		// Token: 0x04001BAD RID: 7085
		private string _Chinese;

		// Token: 0x04001BAE RID: 7086
		private string _TargetLanguage;

		// Token: 0x04001BAF RID: 7087
		private IExtension extensionObject;

		// Token: 0x04001BB0 RID: 7088
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04001BB1 RID: 7089
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04001BB2 RID: 7090
		private LuaFunction m_ctor_hotfix;
	}
}
