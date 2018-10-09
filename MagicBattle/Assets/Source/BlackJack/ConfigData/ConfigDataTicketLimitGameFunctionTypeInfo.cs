using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x020002A0 RID: 672
	[ProtoContract(Name = "ConfigDataTicketLimitGameFunctionTypeInfo")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ConfigDataTicketLimitGameFunctionTypeInfo : IExtensible
	{
		// Token: 0x06002C2A RID: 11306 RVA: 0x000B4790 File Offset: 0x000B2990
		public ConfigDataTicketLimitGameFunctionTypeInfo()
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

		// Token: 0x17000C2B RID: 3115
		// (get) Token: 0x06002C2B RID: 11307 RVA: 0x000B47F8 File Offset: 0x000B29F8
		// (set) Token: 0x06002C2C RID: 11308 RVA: 0x000B4800 File Offset: 0x000B2A00
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

		// Token: 0x17000C2C RID: 3116
		// (get) Token: 0x06002C2D RID: 11309 RVA: 0x000B480C File Offset: 0x000B2A0C
		// (set) Token: 0x06002C2E RID: 11310 RVA: 0x000B4814 File Offset: 0x000B2A14
		[ProtoMember(3, IsRequired = true, Name = "GameFunctionTypeID", DataFormat = DataFormat.TwosComplement)]
		public GameFunctionType GameFunctionTypeID
		{
			get
			{
				return this._GameFunctionTypeID;
			}
			set
			{
				this._GameFunctionTypeID = value;
			}
		}

		// Token: 0x06002C2F RID: 11311 RVA: 0x000B4820 File Offset: 0x000B2A20
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06002C30 RID: 11312 RVA: 0x000B4830 File Offset: 0x000B2A30
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

		// Token: 0x06002C31 RID: 11313 RVA: 0x000B48FC File Offset: 0x000B2AFC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataTicketLimitGameFunctionTypeInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04001B38 RID: 6968
		private int _ID;

		// Token: 0x04001B39 RID: 6969
		private GameFunctionType _GameFunctionTypeID;

		// Token: 0x04001B3A RID: 6970
		private IExtension extensionObject;

		// Token: 0x04001B3B RID: 6971
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04001B3C RID: 6972
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04001B3D RID: 6973
		private LuaFunction m_ctor_hotfix;
	}
}
