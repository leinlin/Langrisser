using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020006A0 RID: 1696
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "CheckOnlineReq")]
	[Serializable]
	public class CheckOnlineReq : IExtensible
	{
		// Token: 0x06005C01 RID: 23553 RVA: 0x001A49A8 File Offset: 0x001A2BA8
		public CheckOnlineReq()
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

		// Token: 0x06005C02 RID: 23554 RVA: 0x001A4A10 File Offset: 0x001A2C10
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005C03 RID: 23555 RVA: 0x001A4A20 File Offset: 0x001A2C20
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

		// Token: 0x06005C04 RID: 23556 RVA: 0x001A4AEC File Offset: 0x001A2CEC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(CheckOnlineReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040044DD RID: 17629
		private IExtension extensionObject;

		// Token: 0x040044DE RID: 17630
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040044DF RID: 17631
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040044E0 RID: 17632
		private LuaFunction m_ctor_hotfix;
	}
}
