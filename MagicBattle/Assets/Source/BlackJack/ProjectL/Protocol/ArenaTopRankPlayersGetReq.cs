using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020005BC RID: 1468
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ArenaTopRankPlayersGetReq")]
	[Serializable]
	public class ArenaTopRankPlayersGetReq : IExtensible
	{
		// Token: 0x06005301 RID: 21249 RVA: 0x0018913C File Offset: 0x0018733C
		public ArenaTopRankPlayersGetReq()
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

		// Token: 0x06005302 RID: 21250 RVA: 0x001891A4 File Offset: 0x001873A4
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005303 RID: 21251 RVA: 0x001891B4 File Offset: 0x001873B4
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

		// Token: 0x06005304 RID: 21252 RVA: 0x00189280 File Offset: 0x00187480
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ArenaTopRankPlayersGetReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04003E5A RID: 15962
		private IExtension extensionObject;

		// Token: 0x04003E5B RID: 15963
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04003E5C RID: 15964
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04003E5D RID: 15965
		private LuaFunction m_ctor_hotfix;
	}
}
