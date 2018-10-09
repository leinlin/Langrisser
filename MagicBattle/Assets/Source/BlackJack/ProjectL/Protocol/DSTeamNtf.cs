using System;
using System.Collections.Generic;
using System.ComponentModel;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000730 RID: 1840
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "DSTeamNtf")]
	[Serializable]
	public class DSTeamNtf : IExtensible
	{
		// Token: 0x060060F6 RID: 24822 RVA: 0x001B5854 File Offset: 0x001B3A54
		public DSTeamNtf()
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

		// Token: 0x170018C7 RID: 6343
		// (get) Token: 0x060060F7 RID: 24823 RVA: 0x001B58C8 File Offset: 0x001B3AC8
		// (set) Token: 0x060060F8 RID: 24824 RVA: 0x001B58D0 File Offset: 0x001B3AD0
		[DefaultValue(0)]
		[ProtoMember(1, IsRequired = false, Name = "RoomId", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x170018C8 RID: 6344
		// (get) Token: 0x060060F9 RID: 24825 RVA: 0x001B58DC File Offset: 0x001B3ADC
		// (set) Token: 0x060060FA RID: 24826 RVA: 0x001B58E4 File Offset: 0x001B3AE4
		[DefaultValue(0)]
		[ProtoMember(2, IsRequired = false, Name = "GameFunctionTypeId", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x170018C9 RID: 6345
		// (get) Token: 0x060060FB RID: 24827 RVA: 0x001B58F0 File Offset: 0x001B3AF0
		// (set) Token: 0x060060FC RID: 24828 RVA: 0x001B58F8 File Offset: 0x001B3AF8
		[ProtoMember(3, IsRequired = false, Name = "LocationId", DataFormat = DataFormat.TwosComplement)]
		[DefaultValue(0)]
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

		// Token: 0x170018CA RID: 6346
		// (get) Token: 0x060060FD RID: 24829 RVA: 0x001B5904 File Offset: 0x001B3B04
		// (set) Token: 0x060060FE RID: 24830 RVA: 0x001B590C File Offset: 0x001B3B0C
		[DefaultValue(0)]
		[ProtoMember(4, IsRequired = false, Name = "WaitingFunctionTypeId", DataFormat = DataFormat.TwosComplement)]
		public int WaitingFunctionTypeId
		{
			get
			{
				return this._WaitingFunctionTypeId;
			}
			set
			{
				this._WaitingFunctionTypeId = value;
			}
		}

		// Token: 0x170018CB RID: 6347
		// (get) Token: 0x060060FF RID: 24831 RVA: 0x001B5918 File Offset: 0x001B3B18
		// (set) Token: 0x06006100 RID: 24832 RVA: 0x001B5920 File Offset: 0x001B3B20
		[ProtoMember(5, IsRequired = false, Name = "WaitingLocationId", DataFormat = DataFormat.TwosComplement)]
		[DefaultValue(0)]
		public int WaitingLocationId
		{
			get
			{
				return this._WaitingLocationId;
			}
			set
			{
				this._WaitingLocationId = value;
			}
		}

		// Token: 0x170018CC RID: 6348
		// (get) Token: 0x06006101 RID: 24833 RVA: 0x001B592C File Offset: 0x001B3B2C
		[ProtoMember(6, Name = "InviteInfos", DataFormat = DataFormat.Default)]
		public List<ProTeamRoomInviteInfo> InviteInfos
		{
			get
			{
				return this._InviteInfos;
			}
		}

		// Token: 0x170018CD RID: 6349
		// (get) Token: 0x06006102 RID: 24834 RVA: 0x001B5934 File Offset: 0x001B3B34
		// (set) Token: 0x06006103 RID: 24835 RVA: 0x001B593C File Offset: 0x001B3B3C
		[ProtoMember(7, IsRequired = false, Name = "LastInviteSendTime", DataFormat = DataFormat.TwosComplement)]
		[DefaultValue(0L)]
		public long LastInviteSendTime
		{
			get
			{
				return this._LastInviteSendTime;
			}
			set
			{
				this._LastInviteSendTime = value;
			}
		}

		// Token: 0x06006104 RID: 24836 RVA: 0x001B5948 File Offset: 0x001B3B48
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06006105 RID: 24837 RVA: 0x001B5958 File Offset: 0x001B3B58
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

		// Token: 0x06006106 RID: 24838 RVA: 0x001B5A24 File Offset: 0x001B3C24
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(DSTeamNtf));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400489D RID: 18589
		private int _RoomId;

		// Token: 0x0400489E RID: 18590
		private int _GameFunctionTypeId;

		// Token: 0x0400489F RID: 18591
		private int _LocationId;

		// Token: 0x040048A0 RID: 18592
		private int _WaitingFunctionTypeId;

		// Token: 0x040048A1 RID: 18593
		private int _WaitingLocationId;

		// Token: 0x040048A2 RID: 18594
		private readonly List<ProTeamRoomInviteInfo> _InviteInfos = new List<ProTeamRoomInviteInfo>();

		// Token: 0x040048A3 RID: 18595
		private long _LastInviteSendTime;

		// Token: 0x040048A4 RID: 18596
		private IExtension extensionObject;

		// Token: 0x040048A5 RID: 18597
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040048A6 RID: 18598
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040048A7 RID: 18599
		private LuaFunction m_ctor_hotfix;
	}
}
