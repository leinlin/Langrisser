using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000600 RID: 1536
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "BattleRoomGuildMassiveCombatBattleJoinNtf")]
	[Serializable]
	public class BattleRoomGuildMassiveCombatBattleJoinNtf : IExtensible
	{
		// Token: 0x06005538 RID: 21816 RVA: 0x00190F4C File Offset: 0x0018F14C
		public BattleRoomGuildMassiveCombatBattleJoinNtf()
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

		// Token: 0x170014F2 RID: 5362
		// (get) Token: 0x06005539 RID: 21817 RVA: 0x00190FC8 File Offset: 0x0018F1C8
		// (set) Token: 0x0600553A RID: 21818 RVA: 0x00190FD0 File Offset: 0x0018F1D0
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

		// Token: 0x170014F3 RID: 5363
		// (get) Token: 0x0600553B RID: 21819 RVA: 0x00190FDC File Offset: 0x0018F1DC
		// (set) Token: 0x0600553C RID: 21820 RVA: 0x00190FE4 File Offset: 0x0018F1E4
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

		// Token: 0x170014F4 RID: 5364
		// (get) Token: 0x0600553D RID: 21821 RVA: 0x00190FF0 File Offset: 0x0018F1F0
		[ProtoMember(3, Name = "Players", DataFormat = DataFormat.Default)]
		public List<ProBattleRoomPlayer> Players
		{
			get
			{
				return this._Players;
			}
		}

		// Token: 0x170014F5 RID: 5365
		// (get) Token: 0x0600553E RID: 21822 RVA: 0x00190FF8 File Offset: 0x0018F1F8
		// (set) Token: 0x0600553F RID: 21823 RVA: 0x00191000 File Offset: 0x0018F200
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

		// Token: 0x170014F6 RID: 5366
		// (get) Token: 0x06005540 RID: 21824 RVA: 0x0019100C File Offset: 0x0018F20C
		// (set) Token: 0x06005541 RID: 21825 RVA: 0x00191014 File Offset: 0x0018F214
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

		// Token: 0x170014F7 RID: 5367
		// (get) Token: 0x06005542 RID: 21826 RVA: 0x00191020 File Offset: 0x0018F220
		// (set) Token: 0x06005543 RID: 21827 RVA: 0x00191028 File Offset: 0x0018F228
		[ProtoMember(6, IsRequired = true, Name = "GuildMassiveCombatRandomSeed", DataFormat = DataFormat.TwosComplement)]
		public int GuildMassiveCombatRandomSeed
		{
			get
			{
				return this._GuildMassiveCombatRandomSeed;
			}
			set
			{
				this._GuildMassiveCombatRandomSeed = value;
			}
		}

		// Token: 0x170014F8 RID: 5368
		// (get) Token: 0x06005544 RID: 21828 RVA: 0x00191034 File Offset: 0x0018F234
		[ProtoMember(7, Name = "PreferredHeroTagIds", DataFormat = DataFormat.TwosComplement)]
		public List<int> PreferredHeroTagIds
		{
			get
			{
				return this._PreferredHeroTagIds;
			}
		}

		// Token: 0x06005545 RID: 21829 RVA: 0x0019103C File Offset: 0x0018F23C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005546 RID: 21830 RVA: 0x0019104C File Offset: 0x0018F24C
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

		// Token: 0x06005547 RID: 21831 RVA: 0x00191118 File Offset: 0x0018F318
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BattleRoomGuildMassiveCombatBattleJoinNtf));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004008 RID: 16392
		private ulong _RoomId;

		// Token: 0x04004009 RID: 16393
		private int _BattleId;

		// Token: 0x0400400A RID: 16394
		private readonly List<ProBattleRoomPlayer> _Players = new List<ProBattleRoomPlayer>();

		// Token: 0x0400400B RID: 16395
		private int _RandomSeed;

		// Token: 0x0400400C RID: 16396
		private long _ReadyTimeOut;

		// Token: 0x0400400D RID: 16397
		private int _GuildMassiveCombatRandomSeed;

		// Token: 0x0400400E RID: 16398
		private readonly List<int> _PreferredHeroTagIds = new List<int>();

		// Token: 0x0400400F RID: 16399
		private IExtension extensionObject;

		// Token: 0x04004010 RID: 16400
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004011 RID: 16401
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004012 RID: 16402
		private LuaFunction m_ctor_hotfix;
	}
}
