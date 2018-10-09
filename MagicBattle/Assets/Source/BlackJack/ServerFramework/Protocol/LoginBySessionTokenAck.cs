using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ServerFramework.Protocol
{
	// Token: 0x020007E6 RID: 2022
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "LoginBySessionTokenAck")]
	[Serializable]
	public class LoginBySessionTokenAck : IExtensible
	{
		// Token: 0x060066F5 RID: 26357 RVA: 0x001CA9B8 File Offset: 0x001C8BB8
		public LoginBySessionTokenAck()
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

		// Token: 0x17001A6E RID: 6766
		// (get) Token: 0x060066F6 RID: 26358 RVA: 0x001CAA20 File Offset: 0x001C8C20
		// (set) Token: 0x060066F7 RID: 26359 RVA: 0x001CAA28 File Offset: 0x001C8C28
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

		// Token: 0x060066F8 RID: 26360 RVA: 0x001CAA34 File Offset: 0x001C8C34
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060066F9 RID: 26361 RVA: 0x001CAA44 File Offset: 0x001C8C44
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

		// Token: 0x060066FA RID: 26362 RVA: 0x001CAB10 File Offset: 0x001C8D10
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(LoginBySessionTokenAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004D1C RID: 19740
		private int _Result;

		// Token: 0x04004D1D RID: 19741
		private IExtension extensionObject;

		// Token: 0x04004D1E RID: 19742
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004D1F RID: 19743
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004D20 RID: 19744
		private LuaFunction m_ctor_hotfix;
	}
}
