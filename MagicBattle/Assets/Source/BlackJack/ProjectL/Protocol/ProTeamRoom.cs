using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000677 RID: 1655
	[ProtoContract(Name = "ProTeamRoom")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ProTeamRoom : IExtensible
	{
		// Token: 0x06005A2E RID: 23086 RVA: 0x0019F84C File Offset: 0x0019DA4C
		public ProTeamRoom()
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

		// Token: 0x170016A2 RID: 5794
		// (get) Token: 0x06005A2F RID: 23087 RVA: 0x0019F8C0 File Offset: 0x0019DAC0
		// (set) Token: 0x06005A30 RID: 23088 RVA: 0x0019F8C8 File Offset: 0x0019DAC8
		[ProtoMember(1, IsRequired = true, Name = "RoomId", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x170016A3 RID: 5795
		// (get) Token: 0x06005A31 RID: 23089 RVA: 0x0019F8D4 File Offset: 0x0019DAD4
		// (set) Token: 0x06005A32 RID: 23090 RVA: 0x0019F8DC File Offset: 0x0019DADC
		[ProtoMember(2, IsRequired = true, Name = "LeaderPosition", DataFormat = DataFormat.TwosComplement)]
		public int LeaderPosition
		{
			get
			{
				return this._LeaderPosition;
			}
			set
			{
				this._LeaderPosition = value;
			}
		}

		// Token: 0x170016A4 RID: 5796
		// (get) Token: 0x06005A33 RID: 23091 RVA: 0x0019F8E8 File Offset: 0x0019DAE8
		[ProtoMember(3, Name = "Players", DataFormat = DataFormat.Default)]
		public List<ProTeamRoomPlayer> Players
		{
			get
			{
				return this._Players;
			}
		}

		// Token: 0x170016A5 RID: 5797
		// (get) Token: 0x06005A34 RID: 23092 RVA: 0x0019F8F0 File Offset: 0x0019DAF0
		// (set) Token: 0x06005A35 RID: 23093 RVA: 0x0019F8F8 File Offset: 0x0019DAF8
		[ProtoMember(4, IsRequired = true, Name = "LeaderKickOutTime", DataFormat = DataFormat.TwosComplement)]
		public long LeaderKickOutTime
		{
			get
			{
				return this._LeaderKickOutTime;
			}
			set
			{
				this._LeaderKickOutTime = value;
			}
		}

		// Token: 0x170016A6 RID: 5798
		// (get) Token: 0x06005A36 RID: 23094 RVA: 0x0019F904 File Offset: 0x0019DB04
		// (set) Token: 0x06005A37 RID: 23095 RVA: 0x0019F90C File Offset: 0x0019DB0C
		[ProtoMember(5, IsRequired = true, Name = "Setting", DataFormat = DataFormat.Default)]
		public ProTeamRoomSetting Setting
		{
			get
			{
				return this._Setting;
			}
			set
			{
				this._Setting = value;
			}
		}

		// Token: 0x06005A38 RID: 23096 RVA: 0x0019F918 File Offset: 0x0019DB18
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005A39 RID: 23097 RVA: 0x0019F928 File Offset: 0x0019DB28
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

		// Token: 0x06005A3A RID: 23098 RVA: 0x0019F9F4 File Offset: 0x0019DBF4
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ProTeamRoom));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004394 RID: 17300
		private int _RoomId;

		// Token: 0x04004395 RID: 17301
		private int _LeaderPosition;

		// Token: 0x04004396 RID: 17302
		private readonly List<ProTeamRoomPlayer> _Players = new List<ProTeamRoomPlayer>();

		// Token: 0x04004397 RID: 17303
		private long _LeaderKickOutTime;

		// Token: 0x04004398 RID: 17304
		private ProTeamRoomSetting _Setting;

		// Token: 0x04004399 RID: 17305
		private IExtension extensionObject;

		// Token: 0x0400439A RID: 17306
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400439B RID: 17307
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400439C RID: 17308
		private LuaFunction m_ctor_hotfix;
	}
}
