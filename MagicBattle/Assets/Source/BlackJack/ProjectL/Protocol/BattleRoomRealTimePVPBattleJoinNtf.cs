using System;
using System.Collections.Generic;
using System.ComponentModel;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020005FF RID: 1535
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "BattleRoomRealTimePVPBattleJoinNtf")]
	[Serializable]
	public class BattleRoomRealTimePVPBattleJoinNtf : IExtensible
	{
		// Token: 0x06005527 RID: 21799 RVA: 0x00190D14 File Offset: 0x0018EF14
		public BattleRoomRealTimePVPBattleJoinNtf()
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

		// Token: 0x170014EB RID: 5355
		// (get) Token: 0x06005528 RID: 21800 RVA: 0x00190D88 File Offset: 0x0018EF88
		// (set) Token: 0x06005529 RID: 21801 RVA: 0x00190D90 File Offset: 0x0018EF90
		[ProtoMember(1, IsRequired = true, Name = "RoomId", DataFormat = DataFormat.TwosComplement)]
		public ulong RoomId
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

		// Token: 0x170014EC RID: 5356
		// (get) Token: 0x0600552A RID: 21802 RVA: 0x00190D9C File Offset: 0x0018EF9C
		// (set) Token: 0x0600552B RID: 21803 RVA: 0x00190DA4 File Offset: 0x0018EFA4
		[ProtoMember(2, IsRequired = true, Name = "BattleId", DataFormat = DataFormat.TwosComplement)]
		public int BattleId
		{
			get
			{
				return this._BattleId;
			}
			set
			{
				this._BattleId = value;
			}
		}

		// Token: 0x170014ED RID: 5357
		// (get) Token: 0x0600552C RID: 21804 RVA: 0x00190DB0 File Offset: 0x0018EFB0
		[ProtoMember(3, Name = "Players", DataFormat = DataFormat.Default)]
		public List<ProBattleRoomPlayer> Players
		{
			get
			{
				return this._Players;
			}
		}

		// Token: 0x170014EE RID: 5358
		// (get) Token: 0x0600552D RID: 21805 RVA: 0x00190DB8 File Offset: 0x0018EFB8
		// (set) Token: 0x0600552E RID: 21806 RVA: 0x00190DC0 File Offset: 0x0018EFC0
		[ProtoMember(4, IsRequired = true, Name = "RandomSeed", DataFormat = DataFormat.TwosComplement)]
		public int RandomSeed
		{
			get
			{
				return this._RandomSeed;
			}
			set
			{
				this._RandomSeed = value;
			}
		}

		// Token: 0x170014EF RID: 5359
		// (get) Token: 0x0600552F RID: 21807 RVA: 0x00190DCC File Offset: 0x0018EFCC
		// (set) Token: 0x06005530 RID: 21808 RVA: 0x00190DD4 File Offset: 0x0018EFD4
		[ProtoMember(5, IsRequired = true, Name = "ReadyTimeOut", DataFormat = DataFormat.TwosComplement)]
		public long ReadyTimeOut
		{
			get
			{
				return this._ReadyTimeOut;
			}
			set
			{
				this._ReadyTimeOut = value;
			}
		}

		// Token: 0x170014F0 RID: 5360
		// (get) Token: 0x06005531 RID: 21809 RVA: 0x00190DE0 File Offset: 0x0018EFE0
		// (set) Token: 0x06005532 RID: 21810 RVA: 0x00190DE8 File Offset: 0x0018EFE8
		[ProtoMember(6, IsRequired = true, Name = "BattleRoomType", DataFormat = DataFormat.TwosComplement)]
		public int BattleRoomType
		{
			get
			{
				return this._BattleRoomType;
			}
			set
			{
				this._BattleRoomType = value;
			}
		}

		// Token: 0x170014F1 RID: 5361
		// (get) Token: 0x06005533 RID: 21811 RVA: 0x00190DF4 File Offset: 0x0018EFF4
		// (set) Token: 0x06005534 RID: 21812 RVA: 0x00190DFC File Offset: 0x0018EFFC
		[ProtoMember(7, IsRequired = false, Name = "RealTimePVPRoomData", DataFormat = DataFormat.Default)]
		[DefaultValue(null)]
		public BattleRoomDataChangeNtf RealTimePVPRoomData
		{
			get
			{
				return this._RealTimePVPRoomData;
			}
			set
			{
				this._RealTimePVPRoomData = value;
			}
		}

		// Token: 0x06005535 RID: 21813 RVA: 0x00190E08 File Offset: 0x0018F008
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005536 RID: 21814 RVA: 0x00190E18 File Offset: 0x0018F018
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

		// Token: 0x06005537 RID: 21815 RVA: 0x00190EE4 File Offset: 0x0018F0E4
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BattleRoomRealTimePVPBattleJoinNtf));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04003FFD RID: 16381
		private ulong _RoomId;

		// Token: 0x04003FFE RID: 16382
		private int _BattleId;

		// Token: 0x04003FFF RID: 16383
		private readonly List<ProBattleRoomPlayer> _Players = new List<ProBattleRoomPlayer>();

		// Token: 0x04004000 RID: 16384
		private int _RandomSeed;

		// Token: 0x04004001 RID: 16385
		private long _ReadyTimeOut;

		// Token: 0x04004002 RID: 16386
		private int _BattleRoomType;

		// Token: 0x04004003 RID: 16387
		private BattleRoomDataChangeNtf _RealTimePVPRoomData;

		// Token: 0x04004004 RID: 16388
		private IExtension extensionObject;

		// Token: 0x04004005 RID: 16389
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004006 RID: 16390
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004007 RID: 16391
		private LuaFunction m_ctor_hotfix;
	}
}
