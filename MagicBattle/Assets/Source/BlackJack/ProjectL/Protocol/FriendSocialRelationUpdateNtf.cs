using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020006BB RID: 1723
	[ProtoContract(Name = "FriendSocialRelationUpdateNtf")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class FriendSocialRelationUpdateNtf : IExtensible
	{
		// Token: 0x06005D31 RID: 23857 RVA: 0x001A7F04 File Offset: 0x001A6104
		public FriendSocialRelationUpdateNtf()
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

		// Token: 0x170017B1 RID: 6065
		// (get) Token: 0x06005D32 RID: 23858 RVA: 0x001A7FAC File Offset: 0x001A61AC
		// (set) Token: 0x06005D33 RID: 23859 RVA: 0x001A7FB4 File Offset: 0x001A61B4
		[ProtoMember(1, IsRequired = true, Name = "Flag", DataFormat = DataFormat.TwosComplement)]
		public int Flag
		{
			get
			{
				return this._Flag;
			}
			set
			{
				this._Flag = value;
			}
		}

		// Token: 0x170017B2 RID: 6066
		// (get) Token: 0x06005D34 RID: 23860 RVA: 0x001A7FC0 File Offset: 0x001A61C0
		[ProtoMember(2, Name = "Friends", DataFormat = DataFormat.Default)]
		public List<ProUserSummary> Friends
		{
			get
			{
				return this._Friends;
			}
		}

		// Token: 0x170017B3 RID: 6067
		// (get) Token: 0x06005D35 RID: 23861 RVA: 0x001A7FC8 File Offset: 0x001A61C8
		[ProtoMember(3, Name = "Blacklist", DataFormat = DataFormat.Default)]
		public List<ProUserSummary> Blacklist
		{
			get
			{
				return this._Blacklist;
			}
		}

		// Token: 0x170017B4 RID: 6068
		// (get) Token: 0x06005D36 RID: 23862 RVA: 0x001A7FD0 File Offset: 0x001A61D0
		[ProtoMember(4, Name = "Invite", DataFormat = DataFormat.Default)]
		public List<ProUserSummary> Invite
		{
			get
			{
				return this._Invite;
			}
		}

		// Token: 0x170017B5 RID: 6069
		// (get) Token: 0x06005D37 RID: 23863 RVA: 0x001A7FD8 File Offset: 0x001A61D8
		[ProtoMember(5, Name = "Invited", DataFormat = DataFormat.Default)]
		public List<ProUserSummary> Invited
		{
			get
			{
				return this._Invited;
			}
		}

		// Token: 0x170017B6 RID: 6070
		// (get) Token: 0x06005D38 RID: 23864 RVA: 0x001A7FE0 File Offset: 0x001A61E0
		[ProtoMember(6, Name = "RecentContactsChat", DataFormat = DataFormat.Default)]
		public List<ProUserSummary> RecentContactsChat
		{
			get
			{
				return this._RecentContactsChat;
			}
		}

		// Token: 0x170017B7 RID: 6071
		// (get) Token: 0x06005D39 RID: 23865 RVA: 0x001A7FE8 File Offset: 0x001A61E8
		[ProtoMember(7, Name = "RecentContactsTeamBattle", DataFormat = DataFormat.Default)]
		public List<ProUserSummary> RecentContactsTeamBattle
		{
			get
			{
				return this._RecentContactsTeamBattle;
			}
		}

		// Token: 0x06005D3A RID: 23866 RVA: 0x001A7FF0 File Offset: 0x001A61F0
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005D3B RID: 23867 RVA: 0x001A8000 File Offset: 0x001A6200
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

		// Token: 0x06005D3C RID: 23868 RVA: 0x001A80CC File Offset: 0x001A62CC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(FriendSocialRelationUpdateNtf));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040045B3 RID: 17843
		private int _Flag;

		// Token: 0x040045B4 RID: 17844
		private readonly List<ProUserSummary> _Friends = new List<ProUserSummary>();

		// Token: 0x040045B5 RID: 17845
		private readonly List<ProUserSummary> _Blacklist = new List<ProUserSummary>();

		// Token: 0x040045B6 RID: 17846
		private readonly List<ProUserSummary> _Invite = new List<ProUserSummary>();

		// Token: 0x040045B7 RID: 17847
		private readonly List<ProUserSummary> _Invited = new List<ProUserSummary>();

		// Token: 0x040045B8 RID: 17848
		private readonly List<ProUserSummary> _RecentContactsChat = new List<ProUserSummary>();

		// Token: 0x040045B9 RID: 17849
		private readonly List<ProUserSummary> _RecentContactsTeamBattle = new List<ProUserSummary>();

		// Token: 0x040045BA RID: 17850
		private IExtension extensionObject;

		// Token: 0x040045BB RID: 17851
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040045BC RID: 17852
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040045BD RID: 17853
		private LuaFunction m_ctor_hotfix;
	}
}
