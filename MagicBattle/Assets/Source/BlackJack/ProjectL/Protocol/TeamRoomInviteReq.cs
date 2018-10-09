using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000838 RID: 2104
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "TeamRoomInviteReq")]
	[Serializable]
	public class TeamRoomInviteReq : IExtensible
	{
		// Token: 0x0600698A RID: 27018 RVA: 0x001DB474 File Offset: 0x001D9674
		public TeamRoomInviteReq()
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

		// Token: 0x17001B1D RID: 6941
		// (get) Token: 0x0600698B RID: 27019 RVA: 0x001DB4E8 File Offset: 0x001D96E8
		[ProtoMember(1, Name = "InviteeUserIds", DataFormat = DataFormat.Default)]
		public List<string> InviteeUserIds
		{
			get
			{
				return this._InviteeUserIds;
			}
		}

		// Token: 0x0600698C RID: 27020 RVA: 0x001DB4F0 File Offset: 0x001D96F0
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x0600698D RID: 27021 RVA: 0x001DB500 File Offset: 0x001D9700
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

		// Token: 0x0600698E RID: 27022 RVA: 0x001DB5CC File Offset: 0x001D97CC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(TeamRoomInviteReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04005153 RID: 20819
		private readonly List<string> _InviteeUserIds = new List<string>();

		// Token: 0x04005154 RID: 20820
		private IExtension extensionObject;

		// Token: 0x04005155 RID: 20821
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04005156 RID: 20822
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04005157 RID: 20823
		private LuaFunction m_ctor_hotfix;
	}
}
