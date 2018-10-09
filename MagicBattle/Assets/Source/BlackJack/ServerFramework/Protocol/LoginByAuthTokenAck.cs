using System;
using System.ComponentModel;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ServerFramework.Protocol
{
	// Token: 0x020007E2 RID: 2018
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "LoginByAuthTokenAck")]
	[Serializable]
	public class LoginByAuthTokenAck : IExtensible
	{
		// Token: 0x060066D1 RID: 26321 RVA: 0x001CA234 File Offset: 0x001C8434
		public LoginByAuthTokenAck()
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

		// Token: 0x17001A64 RID: 6756
		// (get) Token: 0x060066D2 RID: 26322 RVA: 0x001CA2A8 File Offset: 0x001C84A8
		// (set) Token: 0x060066D3 RID: 26323 RVA: 0x001CA2B0 File Offset: 0x001C84B0
		[ProtoMember(1, IsRequired = true, Name = "Result", DataFormat = DataFormat.TwosComplement)]
		public int Result
		{
			get
			{
				return this._Result;
			}
			set
			{
				this._Result = value;
			}
		}

		// Token: 0x17001A65 RID: 6757
		// (get) Token: 0x060066D4 RID: 26324 RVA: 0x001CA2BC File Offset: 0x001C84BC
		// (set) Token: 0x060066D5 RID: 26325 RVA: 0x001CA2C4 File Offset: 0x001C84C4
		[ProtoMember(2, IsRequired = true, Name = "NeedRedirect", DataFormat = DataFormat.Default)]
		public bool NeedRedirect
		{
			get
			{
				return this._NeedRedirect;
			}
			set
			{
				this._NeedRedirect = value;
			}
		}

		// Token: 0x17001A66 RID: 6758
		// (get) Token: 0x060066D6 RID: 26326 RVA: 0x001CA2D0 File Offset: 0x001C84D0
		// (set) Token: 0x060066D7 RID: 26327 RVA: 0x001CA2D8 File Offset: 0x001C84D8
		[DefaultValue("")]
		[ProtoMember(3, IsRequired = false, Name = "SessionToken", DataFormat = DataFormat.Default)]
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

		// Token: 0x060066D8 RID: 26328 RVA: 0x001CA2E4 File Offset: 0x001C84E4
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060066D9 RID: 26329 RVA: 0x001CA2F4 File Offset: 0x001C84F4
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

		// Token: 0x060066DA RID: 26330 RVA: 0x001CA3C0 File Offset: 0x001C85C0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(LoginByAuthTokenAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004D02 RID: 19714
		private int _Result;

		// Token: 0x04004D03 RID: 19715
		private bool _NeedRedirect;

		// Token: 0x04004D04 RID: 19716
		private string _SessionToken = string.Empty;

		// Token: 0x04004D05 RID: 19717
		private IExtension extensionObject;

		// Token: 0x04004D06 RID: 19718
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004D07 RID: 19719
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004D08 RID: 19720
		private LuaFunction m_ctor_hotfix;
	}
}
