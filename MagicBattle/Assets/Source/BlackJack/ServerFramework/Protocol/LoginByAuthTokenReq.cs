using System;
using System.ComponentModel;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ServerFramework.Protocol
{
	// Token: 0x020007E5 RID: 2021
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "LoginByAuthTokenReq")]
	[Serializable]
	public class LoginByAuthTokenReq : IExtensible
	{
		// Token: 0x060066E5 RID: 26341 RVA: 0x001CA794 File Offset: 0x001C8994
		public LoginByAuthTokenReq()
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

		// Token: 0x17001A68 RID: 6760
		// (get) Token: 0x060066E6 RID: 26342 RVA: 0x001CA7FC File Offset: 0x001C89FC
		// (set) Token: 0x060066E7 RID: 26343 RVA: 0x001CA804 File Offset: 0x001C8A04
		[ProtoMember(1, IsRequired = true, Name = "AuthToken", DataFormat = DataFormat.Default)]
		public string AuthToken
		{
			get
			{
				return this._AuthToken;
			}
			set
			{
				this._AuthToken = value;
			}
		}

		// Token: 0x17001A69 RID: 6761
		// (get) Token: 0x060066E8 RID: 26344 RVA: 0x001CA810 File Offset: 0x001C8A10
		// (set) Token: 0x060066E9 RID: 26345 RVA: 0x001CA818 File Offset: 0x001C8A18
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

		// Token: 0x17001A6A RID: 6762
		// (get) Token: 0x060066EA RID: 26346 RVA: 0x001CA824 File Offset: 0x001C8A24
		// (set) Token: 0x060066EB RID: 26347 RVA: 0x001CA82C File Offset: 0x001C8A2C
		[ProtoMember(3, IsRequired = true, Name = "ClientDeviceId", DataFormat = DataFormat.Default)]
		public string ClientDeviceId
		{
			get
			{
				return this._ClientDeviceId;
			}
			set
			{
				this._ClientDeviceId = value;
			}
		}

		// Token: 0x17001A6B RID: 6763
		// (get) Token: 0x060066EC RID: 26348 RVA: 0x001CA838 File Offset: 0x001C8A38
		// (set) Token: 0x060066ED RID: 26349 RVA: 0x001CA840 File Offset: 0x001C8A40
		[ProtoMember(4, IsRequired = true, Name = "Localization", DataFormat = DataFormat.Default)]
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

		// Token: 0x17001A6C RID: 6764
		// (get) Token: 0x060066EE RID: 26350 RVA: 0x001CA84C File Offset: 0x001C8A4C
		// (set) Token: 0x060066EF RID: 26351 RVA: 0x001CA854 File Offset: 0x001C8A54
		[DefaultValue(0)]
		[ProtoMember(5, IsRequired = false, Name = "CurrChannelId", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x17001A6D RID: 6765
		// (get) Token: 0x060066F0 RID: 26352 RVA: 0x001CA860 File Offset: 0x001C8A60
		// (set) Token: 0x060066F1 RID: 26353 RVA: 0x001CA868 File Offset: 0x001C8A68
		[DefaultValue(0)]
		[ProtoMember(6, IsRequired = false, Name = "BornChannelId", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x060066F2 RID: 26354 RVA: 0x001CA874 File Offset: 0x001C8A74
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060066F3 RID: 26355 RVA: 0x001CA884 File Offset: 0x001C8A84
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

		// Token: 0x060066F4 RID: 26356 RVA: 0x001CA950 File Offset: 0x001C8B50
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(LoginByAuthTokenReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004D12 RID: 19730
		private string _AuthToken;

		// Token: 0x04004D13 RID: 19731
		private string _ClientVersion;

		// Token: 0x04004D14 RID: 19732
		private string _ClientDeviceId;

		// Token: 0x04004D15 RID: 19733
		private string _Localization;

		// Token: 0x04004D16 RID: 19734
		private int _CurrChannelId;

		// Token: 0x04004D17 RID: 19735
		private int _BornChannelId;

		// Token: 0x04004D18 RID: 19736
		private IExtension extensionObject;

		// Token: 0x04004D19 RID: 19737
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004D1A RID: 19738
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004D1B RID: 19739
		private LuaFunction m_ctor_hotfix;
	}
}
