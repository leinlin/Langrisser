using System;
using System.ComponentModel;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200060D RID: 1549
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "BattleRoomDataChangeNtf")]
	[Serializable]
	public class BattleRoomDataChangeNtf : IExtensible
	{
		// Token: 0x060055AF RID: 21935 RVA: 0x0019281C File Offset: 0x00190A1C
		public BattleRoomDataChangeNtf()
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

		// Token: 0x1700151A RID: 5402
		// (get) Token: 0x060055B0 RID: 21936 RVA: 0x00192884 File Offset: 0x00190A84
		// (set) Token: 0x060055B1 RID: 21937 RVA: 0x0019288C File Offset: 0x00190A8C
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

		// Token: 0x1700151B RID: 5403
		// (get) Token: 0x060055B2 RID: 21938 RVA: 0x00192898 File Offset: 0x00190A98
		// (set) Token: 0x060055B3 RID: 21939 RVA: 0x001928A0 File Offset: 0x00190AA0
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

		// Token: 0x1700151C RID: 5404
		// (get) Token: 0x060055B4 RID: 21940 RVA: 0x001928AC File Offset: 0x00190AAC
		// (set) Token: 0x060055B5 RID: 21941 RVA: 0x001928B4 File Offset: 0x00190AB4
		[ProtoMember(3, IsRequired = true, Name = "BPTurn", DataFormat = DataFormat.TwosComplement)]
		public int BPTurn
		{
			get
			{
				return this._BPTurn;
			}
			set
			{
				this._BPTurn = value;
			}
		}

		// Token: 0x1700151D RID: 5405
		// (get) Token: 0x060055B6 RID: 21942 RVA: 0x001928C0 File Offset: 0x00190AC0
		// (set) Token: 0x060055B7 RID: 21943 RVA: 0x001928C8 File Offset: 0x00190AC8
		[ProtoMember(4, IsRequired = true, Name = "BPStatus", DataFormat = DataFormat.TwosComplement)]
		public int BPStatus
		{
			get
			{
				return this._BPStatus;
			}
			set
			{
				this._BPStatus = value;
			}
		}

		// Token: 0x1700151E RID: 5406
		// (get) Token: 0x060055B8 RID: 21944 RVA: 0x001928D4 File Offset: 0x00190AD4
		// (set) Token: 0x060055B9 RID: 21945 RVA: 0x001928DC File Offset: 0x00190ADC
		[ProtoMember(5, IsRequired = true, Name = "BPRule", DataFormat = DataFormat.TwosComplement)]
		public int BPRule
		{
			get
			{
				return this._BPRule;
			}
			set
			{
				this._BPRule = value;
			}
		}

		// Token: 0x1700151F RID: 5407
		// (get) Token: 0x060055BA RID: 21946 RVA: 0x001928E8 File Offset: 0x00190AE8
		// (set) Token: 0x060055BB RID: 21947 RVA: 0x001928F0 File Offset: 0x00190AF0
		[ProtoMember(6, IsRequired = true, Name = "LastestTurnChangeTime", DataFormat = DataFormat.TwosComplement)]
		public long LastestTurnChangeTime
		{
			get
			{
				return this._LastestTurnChangeTime;
			}
			set
			{
				this._LastestTurnChangeTime = value;
			}
		}

		// Token: 0x17001520 RID: 5408
		// (get) Token: 0x060055BC RID: 21948 RVA: 0x001928FC File Offset: 0x00190AFC
		// (set) Token: 0x060055BD RID: 21949 RVA: 0x00192904 File Offset: 0x00190B04
		[ProtoMember(7, IsRequired = true, Name = "Mode", DataFormat = DataFormat.TwosComplement)]
		public int Mode
		{
			get
			{
				return this._Mode;
			}
			set
			{
				this._Mode = value;
			}
		}

		// Token: 0x17001521 RID: 5409
		// (get) Token: 0x060055BE RID: 21950 RVA: 0x00192910 File Offset: 0x00190B10
		// (set) Token: 0x060055BF RID: 21951 RVA: 0x00192918 File Offset: 0x00190B18
		[ProtoMember(8, IsRequired = false, Name = "RealtimePVPBattleInstanceId", DataFormat = DataFormat.TwosComplement)]
		[DefaultValue(0f)]
		public ulong RealtimePVPBattleInstanceId
		{
			get
			{
				return this._RealtimePVPBattleInstanceId;
			}
			set
			{
				this._RealtimePVPBattleInstanceId = value;
			}
		}

		// Token: 0x060055C0 RID: 21952 RVA: 0x00192924 File Offset: 0x00190B24
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060055C1 RID: 21953 RVA: 0x00192934 File Offset: 0x00190B34
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

		// Token: 0x060055C2 RID: 21954 RVA: 0x00192A00 File Offset: 0x00190C00
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BattleRoomDataChangeNtf));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004064 RID: 16484
		private ulong _RoomId;

		// Token: 0x04004065 RID: 16485
		private int _BattleId;

		// Token: 0x04004066 RID: 16486
		private int _BPTurn;

		// Token: 0x04004067 RID: 16487
		private int _BPStatus;

		// Token: 0x04004068 RID: 16488
		private int _BPRule;

		// Token: 0x04004069 RID: 16489
		private long _LastestTurnChangeTime;

		// Token: 0x0400406A RID: 16490
		private int _Mode;

		// Token: 0x0400406B RID: 16491
		private ulong _RealtimePVPBattleInstanceId;

		// Token: 0x0400406C RID: 16492
		private IExtension extensionObject;

		// Token: 0x0400406D RID: 16493
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400406E RID: 16494
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400406F RID: 16495
		private LuaFunction m_ctor_hotfix;
	}
}
