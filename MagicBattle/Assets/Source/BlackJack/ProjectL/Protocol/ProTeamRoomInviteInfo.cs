using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200067C RID: 1660
	[ProtoContract(Name = "ProTeamRoomInviteInfo")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ProTeamRoomInviteInfo : IExtensible
	{
		// Token: 0x06005A6D RID: 23149 RVA: 0x001A0274 File Offset: 0x0019E474
		public ProTeamRoomInviteInfo()
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

		// Token: 0x170016B9 RID: 5817
		// (get) Token: 0x06005A6E RID: 23150 RVA: 0x001A02DC File Offset: 0x0019E4DC
		// (set) Token: 0x06005A6F RID: 23151 RVA: 0x001A02E4 File Offset: 0x0019E4E4
		[ProtoMember(1, IsRequired = true, Name = "SessionId", DataFormat = DataFormat.TwosComplement)]
		public ulong SessionId
		{
			get
			{
				return this._SessionId;
			}
			set
			{
				this._SessionId = value;
			}
		}

		// Token: 0x170016BA RID: 5818
		// (get) Token: 0x06005A70 RID: 23152 RVA: 0x001A02F0 File Offset: 0x0019E4F0
		// (set) Token: 0x06005A71 RID: 23153 RVA: 0x001A02F8 File Offset: 0x0019E4F8
		[ProtoMember(2, IsRequired = true, Name = "ChannelId", DataFormat = DataFormat.TwosComplement)]
		public int ChannelId
		{
			get
			{
				return this._ChannelId;
			}
			set
			{
				this._ChannelId = value;
			}
		}

		// Token: 0x170016BB RID: 5819
		// (get) Token: 0x06005A72 RID: 23154 RVA: 0x001A0304 File Offset: 0x0019E504
		// (set) Token: 0x06005A73 RID: 23155 RVA: 0x001A030C File Offset: 0x0019E50C
		[ProtoMember(3, IsRequired = true, Name = "Name", DataFormat = DataFormat.Default)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				this._Name = value;
			}
		}

		// Token: 0x170016BC RID: 5820
		// (get) Token: 0x06005A74 RID: 23156 RVA: 0x001A0318 File Offset: 0x0019E518
		// (set) Token: 0x06005A75 RID: 23157 RVA: 0x001A0320 File Offset: 0x0019E520
		[ProtoMember(4, IsRequired = true, Name = "Level", DataFormat = DataFormat.TwosComplement)]
		public int Level
		{
			get
			{
				return this._Level;
			}
			set
			{
				this._Level = value;
			}
		}

		// Token: 0x170016BD RID: 5821
		// (get) Token: 0x06005A76 RID: 23158 RVA: 0x001A032C File Offset: 0x0019E52C
		// (set) Token: 0x06005A77 RID: 23159 RVA: 0x001A0334 File Offset: 0x0019E534
		[ProtoMember(5, IsRequired = true, Name = "RoomId", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x170016BE RID: 5822
		// (get) Token: 0x06005A78 RID: 23160 RVA: 0x001A0340 File Offset: 0x0019E540
		// (set) Token: 0x06005A79 RID: 23161 RVA: 0x001A0348 File Offset: 0x0019E548
		[ProtoMember(6, IsRequired = true, Name = "GameFunctionTypeId", DataFormat = DataFormat.TwosComplement)]
		public int GameFunctionTypeId
		{
			get
			{
				return this._GameFunctionTypeId;
			}
			set
			{
				this._GameFunctionTypeId = value;
			}
		}

		// Token: 0x170016BF RID: 5823
		// (get) Token: 0x06005A7A RID: 23162 RVA: 0x001A0354 File Offset: 0x0019E554
		// (set) Token: 0x06005A7B RID: 23163 RVA: 0x001A035C File Offset: 0x0019E55C
		[ProtoMember(7, IsRequired = true, Name = "LocationId", DataFormat = DataFormat.TwosComplement)]
		public int LocationId
		{
			get
			{
				return this._LocationId;
			}
			set
			{
				this._LocationId = value;
			}
		}

		// Token: 0x170016C0 RID: 5824
		// (get) Token: 0x06005A7C RID: 23164 RVA: 0x001A0368 File Offset: 0x0019E568
		// (set) Token: 0x06005A7D RID: 23165 RVA: 0x001A0370 File Offset: 0x0019E570
		[ProtoMember(8, IsRequired = true, Name = "TimeOut", DataFormat = DataFormat.TwosComplement)]
		public long TimeOut
		{
			get
			{
				return this._TimeOut;
			}
			set
			{
				this._TimeOut = value;
			}
		}

		// Token: 0x06005A7E RID: 23166 RVA: 0x001A037C File Offset: 0x0019E57C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005A7F RID: 23167 RVA: 0x001A038C File Offset: 0x0019E58C
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

		// Token: 0x06005A80 RID: 23168 RVA: 0x001A0458 File Offset: 0x0019E658
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ProTeamRoomInviteInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040043BF RID: 17343
		private ulong _SessionId;

		// Token: 0x040043C0 RID: 17344
		private int _ChannelId;

		// Token: 0x040043C1 RID: 17345
		private string _Name;

		// Token: 0x040043C2 RID: 17346
		private int _Level;

		// Token: 0x040043C3 RID: 17347
		private int _RoomId;

		// Token: 0x040043C4 RID: 17348
		private int _GameFunctionTypeId;

		// Token: 0x040043C5 RID: 17349
		private int _LocationId;

		// Token: 0x040043C6 RID: 17350
		private long _TimeOut;

		// Token: 0x040043C7 RID: 17351
		private IExtension extensionObject;

		// Token: 0x040043C8 RID: 17352
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040043C9 RID: 17353
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040043CA RID: 17354
		private LuaFunction m_ctor_hotfix;
	}
}
