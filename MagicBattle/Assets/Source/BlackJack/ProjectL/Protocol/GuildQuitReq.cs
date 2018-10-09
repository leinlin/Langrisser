using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000777 RID: 1911
	[ProtoContract(Name = "GuildQuitReq")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class GuildQuitReq : IExtensible
	{
		// Token: 0x06006329 RID: 25385 RVA: 0x001BDAB0 File Offset: 0x001BBCB0
		public GuildQuitReq()
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

		// Token: 0x0600632A RID: 25386 RVA: 0x001BDB18 File Offset: 0x001BBD18
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x0600632B RID: 25387 RVA: 0x001BDB28 File Offset: 0x001BBD28
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

		// Token: 0x0600632C RID: 25388 RVA: 0x001BDBF4 File Offset: 0x001BBDF4
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(GuildQuitReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004A4D RID: 19021
		private IExtension extensionObject;

		// Token: 0x04004A4E RID: 19022
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004A4F RID: 19023
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004A50 RID: 19024
		private LuaFunction m_ctor_hotfix;
	}
}
