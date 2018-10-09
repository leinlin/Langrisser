using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200083A RID: 2106
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "TeamRoomInvitationRefusedReq")]
	[Serializable]
	public class TeamRoomInvitationRefusedReq : IExtensible
	{
		// Token: 0x06006995 RID: 27029 RVA: 0x001DB7F4 File Offset: 0x001D99F4
		public TeamRoomInvitationRefusedReq()
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

		// Token: 0x17001B1F RID: 6943
		// (get) Token: 0x06006996 RID: 27030 RVA: 0x001DB85C File Offset: 0x001D9A5C
		// (set) Token: 0x06006997 RID: 27031 RVA: 0x001DB864 File Offset: 0x001D9A64
		[ProtoMember(1, IsRequired = true, Name = "InviterSessionId", DataFormat = DataFormat.TwosComplement)]
		public ulong InviterSessionId
		{
			get
			{
				return this._InviterSessionId;
			}
			set
			{
				this._InviterSessionId = value;
			}
		}

		// Token: 0x17001B20 RID: 6944
		// (get) Token: 0x06006998 RID: 27032 RVA: 0x001DB870 File Offset: 0x001D9A70
		// (set) Token: 0x06006999 RID: 27033 RVA: 0x001DB878 File Offset: 0x001D9A78
		[ProtoMember(2, IsRequired = true, Name = "RoomId", DataFormat = DataFormat.TwosComplement)]
		public int RoomId
		{
			get
			{
				return this._RoomId;
			}
			set
			{
				this._RoomId = value;
			}
		}

		// Token: 0x17001B21 RID: 6945
		// (get) Token: 0x0600699A RID: 27034 RVA: 0x001DB884 File Offset: 0x001D9A84
		// (set) Token: 0x0600699B RID: 27035 RVA: 0x001DB88C File Offset: 0x001D9A8C
		[ProtoMember(3, IsRequired = true, Name = "InviterChannelId", DataFormat = DataFormat.TwosComplement)]
		public int InviterChannelId
		{
			get
			{
				return this._InviterChannelId;
			}
			set
			{
				this._InviterChannelId = value;
			}
		}

		// Token: 0x0600699C RID: 27036 RVA: 0x001DB898 File Offset: 0x001D9A98
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x0600699D RID: 27037 RVA: 0x001DB8A8 File Offset: 0x001D9AA8
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

		// Token: 0x0600699E RID: 27038 RVA: 0x001DB974 File Offset: 0x001D9B74
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(TeamRoomInvitationRefusedReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400515D RID: 20829
		private ulong _InviterSessionId;

		// Token: 0x0400515E RID: 20830
		private int _RoomId;

		// Token: 0x0400515F RID: 20831
		private int _InviterChannelId;

		// Token: 0x04005160 RID: 20832
		private IExtension extensionObject;

		// Token: 0x04005161 RID: 20833
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04005162 RID: 20834
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04005163 RID: 20835
		private LuaFunction m_ctor_hotfix;
	}
}
