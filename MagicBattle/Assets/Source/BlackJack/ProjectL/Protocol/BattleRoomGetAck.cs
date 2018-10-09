using System;
using System.Collections.Generic;
using System.ComponentModel;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020005FB RID: 1531
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "BattleRoomGetAck")]
	[Serializable]
	public class BattleRoomGetAck : IExtensible
	{
		// Token: 0x060054E3 RID: 21731 RVA: 0x00190418 File Offset: 0x0018E618
		public BattleRoomGetAck()
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

		// Token: 0x170014CE RID: 5326
		// (get) Token: 0x060054E4 RID: 21732 RVA: 0x001904AC File Offset: 0x0018E6AC
		// (set) Token: 0x060054E5 RID: 21733 RVA: 0x001904B4 File Offset: 0x0018E6B4
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

		// Token: 0x170014CF RID: 5327
		// (get) Token: 0x060054E6 RID: 21734 RVA: 0x001904C0 File Offset: 0x0018E6C0
		[ProtoMember(2, Name = "Players", DataFormat = DataFormat.Default)]
		public List<ProBattleRoomPlayer> Players
		{
			get
			{
				return this._Players;
			}
		}

		// Token: 0x170014D0 RID: 5328
		// (get) Token: 0x060054E7 RID: 21735 RVA: 0x001904C8 File Offset: 0x0018E6C8
		// (set) Token: 0x060054E8 RID: 21736 RVA: 0x001904D0 File Offset: 0x0018E6D0
		[DefaultValue(0)]
		[ProtoMember(3, IsRequired = false, Name = "BattleId", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x170014D1 RID: 5329
		// (get) Token: 0x060054E9 RID: 21737 RVA: 0x001904DC File Offset: 0x0018E6DC
		// (set) Token: 0x060054EA RID: 21738 RVA: 0x001904E4 File Offset: 0x0018E6E4
		[ProtoMember(4, IsRequired = false, Name = "BattleRoomType", DataFormat = DataFormat.TwosComplement)]
		[DefaultValue(0)]
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

		// Token: 0x170014D2 RID: 5330
		// (get) Token: 0x060054EB RID: 21739 RVA: 0x001904F0 File Offset: 0x0018E6F0
		// (set) Token: 0x060054EC RID: 21740 RVA: 0x001904F8 File Offset: 0x0018E6F8
		[ProtoMember(5, IsRequired = false, Name = "LeaderIndex", DataFormat = DataFormat.TwosComplement)]
		[DefaultValue(0)]
		public int LeaderIndex
		{
			get
			{
				return this._LeaderIndex;
			}
			set
			{
				this._LeaderIndex = value;
			}
		}

		// Token: 0x170014D3 RID: 5331
		// (get) Token: 0x060054ED RID: 21741 RVA: 0x00190504 File Offset: 0x0018E704
		// (set) Token: 0x060054EE RID: 21742 RVA: 0x0019050C File Offset: 0x0018E70C
		[ProtoMember(6, IsRequired = false, Name = "GameFunctionTypeId", DataFormat = DataFormat.TwosComplement)]
		[DefaultValue(0)]
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

		// Token: 0x170014D4 RID: 5332
		// (get) Token: 0x060054EF RID: 21743 RVA: 0x00190518 File Offset: 0x0018E718
		// (set) Token: 0x060054F0 RID: 21744 RVA: 0x00190520 File Offset: 0x0018E720
		[DefaultValue(0)]
		[ProtoMember(7, IsRequired = false, Name = "LocationId", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x170014D5 RID: 5333
		// (get) Token: 0x060054F1 RID: 21745 RVA: 0x0019052C File Offset: 0x0018E72C
		// (set) Token: 0x060054F2 RID: 21746 RVA: 0x00190534 File Offset: 0x0018E734
		[ProtoMember(8, IsRequired = false, Name = "ArmyRandomSeed", DataFormat = DataFormat.TwosComplement)]
		[DefaultValue(0)]
		public int ArmyRandomSeed
		{
			get
			{
				return this._ArmyRandomSeed;
			}
			set
			{
				this._ArmyRandomSeed = value;
			}
		}

		// Token: 0x170014D6 RID: 5334
		// (get) Token: 0x060054F3 RID: 21747 RVA: 0x00190540 File Offset: 0x0018E740
		// (set) Token: 0x060054F4 RID: 21748 RVA: 0x00190548 File Offset: 0x0018E748
		[ProtoMember(9, IsRequired = false, Name = "RandomSeed", DataFormat = DataFormat.TwosComplement)]
		[DefaultValue(0)]
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

		// Token: 0x170014D7 RID: 5335
		// (get) Token: 0x060054F5 RID: 21749 RVA: 0x00190554 File Offset: 0x0018E754
		// (set) Token: 0x060054F6 RID: 21750 RVA: 0x0019055C File Offset: 0x0018E75C
		[ProtoMember(10, IsRequired = false, Name = "BattleRoomStatus", DataFormat = DataFormat.TwosComplement)]
		[DefaultValue(0)]
		public int BattleRoomStatus
		{
			get
			{
				return this._BattleRoomStatus;
			}
			set
			{
				this._BattleRoomStatus = value;
			}
		}

		// Token: 0x170014D8 RID: 5336
		// (get) Token: 0x060054F7 RID: 21751 RVA: 0x00190568 File Offset: 0x0018E768
		// (set) Token: 0x060054F8 RID: 21752 RVA: 0x00190570 File Offset: 0x0018E770
		[ProtoMember(11, IsRequired = true, Name = "ReadyTimeOut", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x170014D9 RID: 5337
		// (get) Token: 0x060054F9 RID: 21753 RVA: 0x0019057C File Offset: 0x0018E77C
		[ProtoMember(12, Name = "AllSetupInfos", DataFormat = DataFormat.Default)]
		public List<ProBattleHeroSetupInfo> AllSetupInfos
		{
			get
			{
				return this._AllSetupInfos;
			}
		}

		// Token: 0x170014DA RID: 5338
		// (get) Token: 0x060054FA RID: 21754 RVA: 0x00190584 File Offset: 0x0018E784
		[ProtoMember(13, Name = "Commands", DataFormat = DataFormat.Default)]
		public List<ProBattleCommand> Commands
		{
			get
			{
				return this._Commands;
			}
		}

		// Token: 0x170014DB RID: 5339
		// (get) Token: 0x060054FB RID: 21755 RVA: 0x0019058C File Offset: 0x0018E78C
		// (set) Token: 0x060054FC RID: 21756 RVA: 0x00190594 File Offset: 0x0018E794
		[ProtoMember(14, IsRequired = false, Name = "RealTimePVPRoomData", DataFormat = DataFormat.Default)]
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

		// Token: 0x170014DC RID: 5340
		// (get) Token: 0x060054FD RID: 21757 RVA: 0x001905A0 File Offset: 0x0018E7A0
		// (set) Token: 0x060054FE RID: 21758 RVA: 0x001905A8 File Offset: 0x0018E7A8
		[DefaultValue(0L)]
		[ProtoMember(15, IsRequired = false, Name = "LastPlayerBeginActionTime", DataFormat = DataFormat.TwosComplement)]
		public long LastPlayerBeginActionTime
		{
			get
			{
				return this._LastPlayerBeginActionTime;
			}
			set
			{
				this._LastPlayerBeginActionTime = value;
			}
		}

		// Token: 0x170014DD RID: 5341
		// (get) Token: 0x060054FF RID: 21759 RVA: 0x001905B4 File Offset: 0x0018E7B4
		[ProtoMember(16, Name = "PreferredHeroTagIds", DataFormat = DataFormat.TwosComplement)]
		public List<int> PreferredHeroTagIds
		{
			get
			{
				return this._PreferredHeroTagIds;
			}
		}

		// Token: 0x06005500 RID: 21760 RVA: 0x001905BC File Offset: 0x0018E7BC
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005501 RID: 21761 RVA: 0x001905CC File Offset: 0x0018E7CC
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

		// Token: 0x06005502 RID: 21762 RVA: 0x00190698 File Offset: 0x0018E898
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BattleRoomGetAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04003FD0 RID: 16336
		private int _Result;

		// Token: 0x04003FD1 RID: 16337
		private readonly List<ProBattleRoomPlayer> _Players = new List<ProBattleRoomPlayer>();

		// Token: 0x04003FD2 RID: 16338
		private int _BattleId;

		// Token: 0x04003FD3 RID: 16339
		private int _BattleRoomType;

		// Token: 0x04003FD4 RID: 16340
		private int _LeaderIndex;

		// Token: 0x04003FD5 RID: 16341
		private int _GameFunctionTypeId;

		// Token: 0x04003FD6 RID: 16342
		private int _LocationId;

		// Token: 0x04003FD7 RID: 16343
		private int _ArmyRandomSeed;

		// Token: 0x04003FD8 RID: 16344
		private int _RandomSeed;

		// Token: 0x04003FD9 RID: 16345
		private int _BattleRoomStatus;

		// Token: 0x04003FDA RID: 16346
		private long _ReadyTimeOut;

		// Token: 0x04003FDB RID: 16347
		private readonly List<ProBattleHeroSetupInfo> _AllSetupInfos = new List<ProBattleHeroSetupInfo>();

		// Token: 0x04003FDC RID: 16348
		private readonly List<ProBattleCommand> _Commands = new List<ProBattleCommand>();

		// Token: 0x04003FDD RID: 16349
		private BattleRoomDataChangeNtf _RealTimePVPRoomData;

		// Token: 0x04003FDE RID: 16350
		private long _LastPlayerBeginActionTime;

		// Token: 0x04003FDF RID: 16351
		private readonly List<int> _PreferredHeroTagIds = new List<int>();

		// Token: 0x04003FE0 RID: 16352
		private IExtension extensionObject;

		// Token: 0x04003FE1 RID: 16353
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04003FE2 RID: 16354
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04003FE3 RID: 16355
		private LuaFunction m_ctor_hotfix;
	}
}
