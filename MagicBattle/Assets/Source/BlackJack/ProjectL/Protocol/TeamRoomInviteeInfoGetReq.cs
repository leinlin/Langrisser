using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200083C RID: 2108
	[ProtoContract(Name = "TeamRoomInviteeInfoGetReq")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class TeamRoomInviteeInfoGetReq : IExtensible
	{
		// Token: 0x060069A9 RID: 27049 RVA: 0x001DBBC4 File Offset: 0x001D9DC4
		public TeamRoomInviteeInfoGetReq()
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

		// Token: 0x17001B25 RID: 6949
		// (get) Token: 0x060069AA RID: 27050 RVA: 0x001DBC38 File Offset: 0x001D9E38
		[ProtoMember(1, Name = "InviteeUserIds", DataFormat = DataFormat.Default)]
		public List<string> InviteeUserIds
		{
			get
			{
				return this._InviteeUserIds;
			}
		}

		// Token: 0x17001B26 RID: 6950
		// (get) Token: 0x060069AB RID: 27051 RVA: 0x001DBC40 File Offset: 0x001D9E40
		// (set) Token: 0x060069AC RID: 27052 RVA: 0x001DBC48 File Offset: 0x001D9E48
		[ProtoMember(2, IsRequired = true, Name = "Type", DataFormat = DataFormat.TwosComplement)]
		public int Type
		{
			get
			{
				return this._Type;
			}
			set
			{
				this._Type = value;
			}
		}

		// Token: 0x060069AD RID: 27053 RVA: 0x001DBC54 File Offset: 0x001D9E54
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060069AE RID: 27054 RVA: 0x001DBC64 File Offset: 0x001D9E64
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

		// Token: 0x060069AF RID: 27055 RVA: 0x001DBD30 File Offset: 0x001D9F30
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(TeamRoomInviteeInfoGetReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400516B RID: 20843
		private readonly List<string> _InviteeUserIds = new List<string>();

		// Token: 0x0400516C RID: 20844
		private int _Type;

		// Token: 0x0400516D RID: 20845
		private IExtension extensionObject;

		// Token: 0x0400516E RID: 20846
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400516F RID: 20847
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04005170 RID: 20848
		private LuaFunction m_ctor_hotfix;
	}
}
