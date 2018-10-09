using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020005E4 RID: 1508
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "TeamBattleRoomCreateReq")]
	[Serializable]
	public class TeamBattleRoomCreateReq : IExtensible
	{
		// Token: 0x0600544C RID: 21580 RVA: 0x0018DB4C File Offset: 0x0018BD4C
		public TeamBattleRoomCreateReq()
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

		// Token: 0x0600544D RID: 21581 RVA: 0x0018DBB4 File Offset: 0x0018BDB4
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x0600544E RID: 21582 RVA: 0x0018DBC4 File Offset: 0x0018BDC4
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

		// Token: 0x0600544F RID: 21583 RVA: 0x0018DC90 File Offset: 0x0018BE90
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(TeamBattleRoomCreateReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04003F56 RID: 16214
		private IExtension extensionObject;

		// Token: 0x04003F57 RID: 16215
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04003F58 RID: 16216
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04003F59 RID: 16217
		private LuaFunction m_ctor_hotfix;
	}
}
