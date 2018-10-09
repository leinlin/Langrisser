using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200083B RID: 2107
	[ProtoContract(Name = "TeamRoomInvitationRefusedAck")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class TeamRoomInvitationRefusedAck : IExtensible
	{
		// Token: 0x0600699F RID: 27039 RVA: 0x001DB9DC File Offset: 0x001D9BDC
		public TeamRoomInvitationRefusedAck()
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

		// Token: 0x17001B22 RID: 6946
		// (get) Token: 0x060069A0 RID: 27040 RVA: 0x001DBA44 File Offset: 0x001D9C44
		// (set) Token: 0x060069A1 RID: 27041 RVA: 0x001DBA4C File Offset: 0x001D9C4C
		[ProtoMember(1, IsRequired = true, Name = "Result", DataFormat = DataFormat.TwosComplement)]
		public int Result
		{
			get
			{
				return this._Result;
			}
			set
			{
				this._Result = value;
			}
		}

		// Token: 0x17001B23 RID: 6947
		// (get) Token: 0x060069A2 RID: 27042 RVA: 0x001DBA58 File Offset: 0x001D9C58
		// (set) Token: 0x060069A3 RID: 27043 RVA: 0x001DBA60 File Offset: 0x001D9C60
		[ProtoMember(2, IsRequired = true, Name = "InviterSessionId", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x17001B24 RID: 6948
		// (get) Token: 0x060069A4 RID: 27044 RVA: 0x001DBA6C File Offset: 0x001D9C6C
		// (set) Token: 0x060069A5 RID: 27045 RVA: 0x001DBA74 File Offset: 0x001D9C74
		[ProtoMember(3, IsRequired = true, Name = "RoomId", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x060069A6 RID: 27046 RVA: 0x001DBA80 File Offset: 0x001D9C80
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060069A7 RID: 27047 RVA: 0x001DBA90 File Offset: 0x001D9C90
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

		// Token: 0x060069A8 RID: 27048 RVA: 0x001DBB5C File Offset: 0x001D9D5C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(TeamRoomInvitationRefusedAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04005164 RID: 20836
		private int _Result;

		// Token: 0x04005165 RID: 20837
		private ulong _InviterSessionId;

		// Token: 0x04005166 RID: 20838
		private int _RoomId;

		// Token: 0x04005167 RID: 20839
		private IExtension extensionObject;

		// Token: 0x04005168 RID: 20840
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04005169 RID: 20841
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400516A RID: 20842
		private LuaFunction m_ctor_hotfix;
	}
}
