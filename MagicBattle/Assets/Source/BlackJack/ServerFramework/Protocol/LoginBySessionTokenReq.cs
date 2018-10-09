using System;
using System.ComponentModel;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ServerFramework.Protocol
{
	// Token: 0x020007E7 RID: 2023
	[ProtoContract(Name = "LoginBySessionTokenReq")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class LoginBySessionTokenReq : IExtensible
	{
		// Token: 0x060066FB RID: 26363 RVA: 0x001CAB78 File Offset: 0x001C8D78
		public LoginBySessionTokenReq()
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

		// Token: 0x17001A6F RID: 6767
		// (get) Token: 0x060066FC RID: 26364 RVA: 0x001CABE0 File Offset: 0x001C8DE0
		// (set) Token: 0x060066FD RID: 26365 RVA: 0x001CABE8 File Offset: 0x001C8DE8
		[ProtoMember(1, IsRequired = true, Name = "SessionToken", DataFormat = DataFormat.Default)]
		public string SessionToken
		{
			get
			{
				return this._SessionToken;
			}
			set
			{
				this._SessionToken = value;
			}
		}

		// Token: 0x17001A70 RID: 6768
		// (get) Token: 0x060066FE RID: 26366 RVA: 0x001CABF4 File Offset: 0x001C8DF4
		// (set) Token: 0x060066FF RID: 26367 RVA: 0x001CABFC File Offset: 0x001C8DFC
		[ProtoMember(2, IsRequired = true, Name = "ClientVersion", DataFormat = DataFormat.Default)]
		public string ClientVersion
		{
			get
			{
				return this._ClientVersion;
			}
			set
			{
				this._ClientVersion = value;
			}
		}

		// Token: 0x17001A71 RID: 6769
		// (get) Token: 0x06006700 RID: 26368 RVA: 0x001CAC08 File Offset: 0x001C8E08
		// (set) Token: 0x06006701 RID: 26369 RVA: 0x001CAC10 File Offset: 0x001C8E10
		[ProtoMember(3, IsRequired = true, Name = "Localization", DataFormat = DataFormat.Default)]
		public string Localization
		{
			get
			{
				return this._Localization;
			}
			set
			{
				this._Localization = value;
			}
		}

		// Token: 0x17001A72 RID: 6770
		// (get) Token: 0x06006702 RID: 26370 RVA: 0x001CAC1C File Offset: 0x001C8E1C
		// (set) Token: 0x06006703 RID: 26371 RVA: 0x001CAC24 File Offset: 0x001C8E24
		[DefaultValue(0)]
		[ProtoMember(4, IsRequired = false, Name = "CurrChannelId", DataFormat = DataFormat.TwosComplement)]
		public int CurrChannelId
		{
			get
			{
				return this._CurrChannelId;
			}
			set
			{
				this._CurrChannelId = value;
			}
		}

		// Token: 0x17001A73 RID: 6771
		// (get) Token: 0x06006704 RID: 26372 RVA: 0x001CAC30 File Offset: 0x001C8E30
		// (set) Token: 0x06006705 RID: 26373 RVA: 0x001CAC38 File Offset: 0x001C8E38
		[DefaultValue(0)]
		[ProtoMember(5, IsRequired = false, Name = "BornChannelId", DataFormat = DataFormat.TwosComplement)]
		public int BornChannelId
		{
			get
			{
				return this._BornChannelId;
			}
			set
			{
				this._BornChannelId = value;
			}
		}

		// Token: 0x06006706 RID: 26374 RVA: 0x001CAC44 File Offset: 0x001C8E44
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06006707 RID: 26375 RVA: 0x001CAC54 File Offset: 0x001C8E54
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

		// Token: 0x06006708 RID: 26376 RVA: 0x001CAD20 File Offset: 0x001C8F20
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(LoginBySessionTokenReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004D21 RID: 19745
		private string _SessionToken;

		// Token: 0x04004D22 RID: 19746
		private string _ClientVersion;

		// Token: 0x04004D23 RID: 19747
		private string _Localization;

		// Token: 0x04004D24 RID: 19748
		private int _CurrChannelId;

		// Token: 0x04004D25 RID: 19749
		private int _BornChannelId;

		// Token: 0x04004D26 RID: 19750
		private IExtension extensionObject;

		// Token: 0x04004D27 RID: 19751
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004D28 RID: 19752
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004D29 RID: 19753
		private LuaFunction m_ctor_hotfix;
	}
}
