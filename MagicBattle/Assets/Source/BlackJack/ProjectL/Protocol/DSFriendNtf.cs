using System;
using System.Collections.Generic;
using System.ComponentModel;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000731 RID: 1841
	[ProtoContract(Name = "DSFriendNtf")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class DSFriendNtf : IExtensible
	{
		// Token: 0x06006107 RID: 24839 RVA: 0x001B5A8C File Offset: 0x001B3C8C
		public DSFriendNtf()
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

		// Token: 0x170018CE RID: 6350
		// (get) Token: 0x06006108 RID: 24840 RVA: 0x001B5B14 File Offset: 0x001B3D14
		// (set) Token: 0x06006109 RID: 24841 RVA: 0x001B5B1C File Offset: 0x001B3D1C
		[ProtoMember(1, IsRequired = true, Name = "Likes", DataFormat = DataFormat.TwosComplement)]
		public int Likes
		{
			get
			{
				return this._Likes;
			}
			set
			{
				this._Likes = value;
			}
		}

		// Token: 0x170018CF RID: 6351
		// (get) Token: 0x0600610A RID: 24842 RVA: 0x001B5B28 File Offset: 0x001B3D28
		[ProtoMember(2, Name = "LikedUsers", DataFormat = DataFormat.Default)]
		public List<string> LikedUsers
		{
			get
			{
				return this._LikedUsers;
			}
		}

		// Token: 0x170018D0 RID: 6352
		// (get) Token: 0x0600610B RID: 24843 RVA: 0x001B5B30 File Offset: 0x001B3D30
		[ProtoMember(3, Name = "FriendshipPointsSent", DataFormat = DataFormat.Default)]
		public List<string> FriendshipPointsSent
		{
			get
			{
				return this._FriendshipPointsSent;
			}
		}

		// Token: 0x170018D1 RID: 6353
		// (get) Token: 0x0600610C RID: 24844 RVA: 0x001B5B38 File Offset: 0x001B3D38
		[ProtoMember(4, Name = "FriendshipPointsReceived", DataFormat = DataFormat.Default)]
		public List<string> FriendshipPointsReceived
		{
			get
			{
				return this._FriendshipPointsReceived;
			}
		}

		// Token: 0x170018D2 RID: 6354
		// (get) Token: 0x0600610D RID: 24845 RVA: 0x001B5B40 File Offset: 0x001B3D40
		// (set) Token: 0x0600610E RID: 24846 RVA: 0x001B5B48 File Offset: 0x001B3D48
		[ProtoMember(5, IsRequired = true, Name = "FriendshipPointsFromFightWithFriendsToday", DataFormat = DataFormat.TwosComplement)]
		public int FriendshipPointsFromFightWithFriendsToday
		{
			get
			{
				return this._FriendshipPointsFromFightWithFriendsToday;
			}
			set
			{
				this._FriendshipPointsFromFightWithFriendsToday = value;
			}
		}

		// Token: 0x170018D3 RID: 6355
		// (get) Token: 0x0600610F RID: 24847 RVA: 0x001B5B54 File Offset: 0x001B3D54
		// (set) Token: 0x06006110 RID: 24848 RVA: 0x001B5B5C File Offset: 0x001B3D5C
		[ProtoMember(6, IsRequired = true, Name = "FriendshipPointsClaimedToday", DataFormat = DataFormat.TwosComplement)]
		public int FriendshipPointsClaimedToday
		{
			get
			{
				return this._FriendshipPointsClaimedToday;
			}
			set
			{
				this._FriendshipPointsClaimedToday = value;
			}
		}

		// Token: 0x170018D4 RID: 6356
		// (get) Token: 0x06006111 RID: 24849 RVA: 0x001B5B68 File Offset: 0x001B3D68
		// (set) Token: 0x06006112 RID: 24850 RVA: 0x001B5B70 File Offset: 0x001B3D70
		[ProtoMember(7, IsRequired = true, Name = "SetInfo", DataFormat = DataFormat.Default)]
		public ProBusinessCardInfoSet SetInfo
		{
			get
			{
				return this._SetInfo;
			}
			set
			{
				this._SetInfo = value;
			}
		}

		// Token: 0x170018D5 RID: 6357
		// (get) Token: 0x06006113 RID: 24851 RVA: 0x001B5B7C File Offset: 0x001B3D7C
		// (set) Token: 0x06006114 RID: 24852 RVA: 0x001B5B84 File Offset: 0x001B3D84
		[ProtoMember(8, IsRequired = true, Name = "Version", DataFormat = DataFormat.TwosComplement)]
		public uint Version
		{
			get
			{
				return this._Version;
			}
			set
			{
				this._Version = value;
			}
		}

		// Token: 0x170018D6 RID: 6358
		// (get) Token: 0x06006115 RID: 24853 RVA: 0x001B5B90 File Offset: 0x001B3D90
		// (set) Token: 0x06006116 RID: 24854 RVA: 0x001B5B98 File Offset: 0x001B3D98
		[ProtoMember(9, IsRequired = false, Name = "BannedTime", DataFormat = DataFormat.TwosComplement)]
		[DefaultValue(0L)]
		public long BannedTime
		{
			get
			{
				return this._BannedTime;
			}
			set
			{
				this._BannedTime = value;
			}
		}

		// Token: 0x06006117 RID: 24855 RVA: 0x001B5BA4 File Offset: 0x001B3DA4
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06006118 RID: 24856 RVA: 0x001B5BB4 File Offset: 0x001B3DB4
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

		// Token: 0x06006119 RID: 24857 RVA: 0x001B5C80 File Offset: 0x001B3E80
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(DSFriendNtf));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040048A8 RID: 18600
		private int _Likes;

		// Token: 0x040048A9 RID: 18601
		private readonly List<string> _LikedUsers = new List<string>();

		// Token: 0x040048AA RID: 18602
		private readonly List<string> _FriendshipPointsSent = new List<string>();

		// Token: 0x040048AB RID: 18603
		private readonly List<string> _FriendshipPointsReceived = new List<string>();

		// Token: 0x040048AC RID: 18604
		private int _FriendshipPointsFromFightWithFriendsToday;

		// Token: 0x040048AD RID: 18605
		private int _FriendshipPointsClaimedToday;

		// Token: 0x040048AE RID: 18606
		private ProBusinessCardInfoSet _SetInfo;

		// Token: 0x040048AF RID: 18607
		private uint _Version;

		// Token: 0x040048B0 RID: 18608
		private long _BannedTime;

		// Token: 0x040048B1 RID: 18609
		private IExtension extensionObject;

		// Token: 0x040048B2 RID: 18610
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040048B3 RID: 18611
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040048B4 RID: 18612
		private LuaFunction m_ctor_hotfix;
	}
}
