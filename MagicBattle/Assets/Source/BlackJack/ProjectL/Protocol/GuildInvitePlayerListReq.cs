using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200076D RID: 1901
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "GuildInvitePlayerListReq")]
	[Serializable]
	public class GuildInvitePlayerListReq : IExtensible
	{
		// Token: 0x060062D2 RID: 25298 RVA: 0x001BC818 File Offset: 0x001BAA18
		public GuildInvitePlayerListReq()
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

		// Token: 0x060062D3 RID: 25299 RVA: 0x001BC880 File Offset: 0x001BAA80
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060062D4 RID: 25300 RVA: 0x001BC890 File Offset: 0x001BAA90
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

		// Token: 0x060062D5 RID: 25301 RVA: 0x001BC95C File Offset: 0x001BAB5C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(GuildInvitePlayerListReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004A0D RID: 18957
		private IExtension extensionObject;

		// Token: 0x04004A0E RID: 18958
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004A0F RID: 18959
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004A10 RID: 18960
		private LuaFunction m_ctor_hotfix;
	}
}
