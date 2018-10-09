using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000603 RID: 1539
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "BattleRoomTeamBattleStartNtf")]
	[Serializable]
	public class BattleRoomTeamBattleStartNtf : IExtensible
	{
		// Token: 0x06005557 RID: 21847 RVA: 0x00191528 File Offset: 0x0018F728
		public BattleRoomTeamBattleStartNtf()
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

		// Token: 0x06005558 RID: 21848 RVA: 0x00191590 File Offset: 0x0018F790
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005559 RID: 21849 RVA: 0x001915A0 File Offset: 0x0018F7A0
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

		// Token: 0x0600555A RID: 21850 RVA: 0x0019166C File Offset: 0x0018F86C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BattleRoomTeamBattleStartNtf));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400401F RID: 16415
		private IExtension extensionObject;

		// Token: 0x04004020 RID: 16416
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004021 RID: 16417
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004022 RID: 16418
		private LuaFunction m_ctor_hotfix;
	}
}
