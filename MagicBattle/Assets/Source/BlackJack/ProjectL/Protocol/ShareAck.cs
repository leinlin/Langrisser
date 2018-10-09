using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000709 RID: 1801
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ShareAck")]
	[Serializable]
	public class ShareAck : IExtensible
	{
		// Token: 0x06005F8B RID: 24459 RVA: 0x001B0DC8 File Offset: 0x001AEFC8
		public ShareAck()
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

		// Token: 0x06005F8C RID: 24460 RVA: 0x001B0E30 File Offset: 0x001AF030
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005F8D RID: 24461 RVA: 0x001B0E40 File Offset: 0x001AF040
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

		// Token: 0x06005F8E RID: 24462 RVA: 0x001B0F0C File Offset: 0x001AF10C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ShareAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004788 RID: 18312
		private IExtension extensionObject;

		// Token: 0x04004789 RID: 18313
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400478A RID: 18314
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400478B RID: 18315
		private LuaFunction m_ctor_hotfix;
	}
}
