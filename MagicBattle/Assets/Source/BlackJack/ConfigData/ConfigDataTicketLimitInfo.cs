using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x020002A1 RID: 673
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ConfigDataTicketLimitInfo")]
	[Serializable]
	public class ConfigDataTicketLimitInfo : IExtensible
	{
		// Token: 0x06002C32 RID: 11314 RVA: 0x000B4964 File Offset: 0x000B2B64
		public ConfigDataTicketLimitInfo()
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

		// Token: 0x17000C2D RID: 3117
		// (get) Token: 0x06002C33 RID: 11315 RVA: 0x000B49CC File Offset: 0x000B2BCC
		// (set) Token: 0x06002C34 RID: 11316 RVA: 0x000B49D4 File Offset: 0x000B2BD4
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

		// Token: 0x17000C2E RID: 3118
		// (get) Token: 0x06002C35 RID: 11317 RVA: 0x000B49E0 File Offset: 0x000B2BE0
		// (set) Token: 0x06002C36 RID: 11318 RVA: 0x000B49E8 File Offset: 0x000B2BE8
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

		// Token: 0x17000C2F RID: 3119
		// (get) Token: 0x06002C37 RID: 11319 RVA: 0x000B49F4 File Offset: 0x000B2BF4
		// (set) Token: 0x06002C38 RID: 11320 RVA: 0x000B49FC File Offset: 0x000B2BFC
		[ProtoMember(4, IsRequired = true, Name = "MaxNums", DataFormat = DataFormat.TwosComplement)]
		public int MaxNums
		{
			get
			{
				return this._MaxNums;
			}
			set
			{
				this._MaxNums = value;
			}
		}

		// Token: 0x17000C30 RID: 3120
		// (get) Token: 0x06002C39 RID: 11321 RVA: 0x000B4A08 File Offset: 0x000B2C08
		// (set) Token: 0x06002C3A RID: 11322 RVA: 0x000B4A10 File Offset: 0x000B2C10
		[ProtoMember(5, IsRequired = true, Name = "TicketId", DataFormat = DataFormat.TwosComplement)]
		public int TicketId
		{
			get
			{
				return this._TicketId;
			}
			set
			{
				this._TicketId = value;
			}
		}

		// Token: 0x06002C3B RID: 11323 RVA: 0x000B4A1C File Offset: 0x000B2C1C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06002C3C RID: 11324 RVA: 0x000B4A2C File Offset: 0x000B2C2C
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

		// Token: 0x06002C3D RID: 11325 RVA: 0x000B4AF8 File Offset: 0x000B2CF8
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataTicketLimitInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04001B3E RID: 6974
		private int _ID;

		// Token: 0x04001B3F RID: 6975
		private GameFunctionType _GameFunctionTypeID;

		// Token: 0x04001B40 RID: 6976
		private int _MaxNums;

		// Token: 0x04001B41 RID: 6977
		private int _TicketId;

		// Token: 0x04001B42 RID: 6978
		private IExtension extensionObject;

		// Token: 0x04001B43 RID: 6979
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04001B44 RID: 6980
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04001B45 RID: 6981
		private LuaFunction m_ctor_hotfix;
	}
}
