using System;
using System.Collections.Generic;
using System.ComponentModel;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020006BD RID: 1725
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "FriendInviteAck")]
	[Serializable]
	public class FriendInviteAck : IExtensible
	{
		// Token: 0x06005D42 RID: 23874 RVA: 0x001A82F4 File Offset: 0x001A64F4
		public FriendInviteAck()
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

		// Token: 0x170017B9 RID: 6073
		// (get) Token: 0x06005D43 RID: 23875 RVA: 0x001A8368 File Offset: 0x001A6568
		// (set) Token: 0x06005D44 RID: 23876 RVA: 0x001A8370 File Offset: 0x001A6570
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

		// Token: 0x170017BA RID: 6074
		// (get) Token: 0x06005D45 RID: 23877 RVA: 0x001A837C File Offset: 0x001A657C
		// (set) Token: 0x06005D46 RID: 23878 RVA: 0x001A8384 File Offset: 0x001A6584
		[ProtoMember(2, IsRequired = true, Name = "Req", DataFormat = DataFormat.Default)]
		public FriendInviteReq Req
		{
			get
			{
				return this._Req;
			}
			set
			{
				this._Req = value;
			}
		}

		// Token: 0x170017BB RID: 6075
		// (get) Token: 0x06005D47 RID: 23879 RVA: 0x001A8390 File Offset: 0x001A6590
		[ProtoMember(3, Name = "InvitedUsers", DataFormat = DataFormat.Default)]
		public List<ProUserSummary> InvitedUsers
		{
			get
			{
				return this._InvitedUsers;
			}
		}

		// Token: 0x170017BC RID: 6076
		// (get) Token: 0x06005D48 RID: 23880 RVA: 0x001A8398 File Offset: 0x001A6598
		// (set) Token: 0x06005D49 RID: 23881 RVA: 0x001A83A0 File Offset: 0x001A65A0
		[DefaultValue(null)]
		[ProtoMember(4, IsRequired = false, Name = "FailedUser", DataFormat = DataFormat.Default)]
		public ProUserSummary FailedUser
		{
			get
			{
				return this._FailedUser;
			}
			set
			{
				this._FailedUser = value;
			}
		}

		// Token: 0x06005D4A RID: 23882 RVA: 0x001A83AC File Offset: 0x001A65AC
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005D4B RID: 23883 RVA: 0x001A83BC File Offset: 0x001A65BC
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

		// Token: 0x06005D4C RID: 23884 RVA: 0x001A8488 File Offset: 0x001A6688
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(FriendInviteAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040045C3 RID: 17859
		private int _Result;

		// Token: 0x040045C4 RID: 17860
		private FriendInviteReq _Req;

		// Token: 0x040045C5 RID: 17861
		private readonly List<ProUserSummary> _InvitedUsers = new List<ProUserSummary>();

		// Token: 0x040045C6 RID: 17862
		private ProUserSummary _FailedUser;

		// Token: 0x040045C7 RID: 17863
		private IExtension extensionObject;

		// Token: 0x040045C8 RID: 17864
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040045C9 RID: 17865
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040045CA RID: 17866
		private LuaFunction m_ctor_hotfix;
	}
}
