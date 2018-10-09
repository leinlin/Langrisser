using System;
using System.Collections.Generic;
using System.ComponentModel;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020006C0 RID: 1728
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "FriendInviteAcceptAck")]
	[Serializable]
	public class FriendInviteAcceptAck : IExtensible
	{
		// Token: 0x06005D58 RID: 23896 RVA: 0x001A8870 File Offset: 0x001A6A70
		public FriendInviteAcceptAck()
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

		// Token: 0x170017BF RID: 6079
		// (get) Token: 0x06005D59 RID: 23897 RVA: 0x001A88E4 File Offset: 0x001A6AE4
		// (set) Token: 0x06005D5A RID: 23898 RVA: 0x001A88EC File Offset: 0x001A6AEC
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

		// Token: 0x170017C0 RID: 6080
		// (get) Token: 0x06005D5B RID: 23899 RVA: 0x001A88F8 File Offset: 0x001A6AF8
		// (set) Token: 0x06005D5C RID: 23900 RVA: 0x001A8900 File Offset: 0x001A6B00
		[ProtoMember(2, IsRequired = true, Name = "Req", DataFormat = DataFormat.Default)]
		public FriendInviteAcceptReq Req
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

		// Token: 0x170017C1 RID: 6081
		// (get) Token: 0x06005D5D RID: 23901 RVA: 0x001A890C File Offset: 0x001A6B0C
		[ProtoMember(3, Name = "AcceptedUsers", DataFormat = DataFormat.Default)]
		public List<ProUserSummary> AcceptedUsers
		{
			get
			{
				return this._AcceptedUsers;
			}
		}

		// Token: 0x170017C2 RID: 6082
		// (get) Token: 0x06005D5E RID: 23902 RVA: 0x001A8914 File Offset: 0x001A6B14
		// (set) Token: 0x06005D5F RID: 23903 RVA: 0x001A891C File Offset: 0x001A6B1C
		[ProtoMember(4, IsRequired = false, Name = "FailedUser", DataFormat = DataFormat.Default)]
		[DefaultValue(null)]
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

		// Token: 0x06005D60 RID: 23904 RVA: 0x001A8928 File Offset: 0x001A6B28
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005D61 RID: 23905 RVA: 0x001A8938 File Offset: 0x001A6B38
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

		// Token: 0x06005D62 RID: 23906 RVA: 0x001A8A04 File Offset: 0x001A6C04
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(FriendInviteAcceptAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040045D5 RID: 17877
		private int _Result;

		// Token: 0x040045D6 RID: 17878
		private FriendInviteAcceptReq _Req;

		// Token: 0x040045D7 RID: 17879
		private readonly List<ProUserSummary> _AcceptedUsers = new List<ProUserSummary>();

		// Token: 0x040045D8 RID: 17880
		private ProUserSummary _FailedUser;

		// Token: 0x040045D9 RID: 17881
		private IExtension extensionObject;

		// Token: 0x040045DA RID: 17882
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040045DB RID: 17883
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040045DC RID: 17884
		private LuaFunction m_ctor_hotfix;
	}
}
