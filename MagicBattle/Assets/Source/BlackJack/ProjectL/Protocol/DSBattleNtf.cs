using System;
using System.Collections.Generic;
using System.ComponentModel;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200071C RID: 1820
	[ProtoContract(Name = "DSBattleNtf")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class DSBattleNtf : IExtensible
	{
		// Token: 0x06006048 RID: 24648 RVA: 0x001B3248 File Offset: 0x001B1448
		public DSBattleNtf()
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

		// Token: 0x1700188B RID: 6283
		// (get) Token: 0x06006049 RID: 24649 RVA: 0x001B32C4 File Offset: 0x001B14C4
		// (set) Token: 0x0600604A RID: 24650 RVA: 0x001B32CC File Offset: 0x001B14CC
		[ProtoMember(1, IsRequired = true, Name = "Version", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x1700188C RID: 6284
		// (get) Token: 0x0600604B RID: 24651 RVA: 0x001B32D8 File Offset: 0x001B14D8
		[ProtoMember(2, Name = "Teams", DataFormat = DataFormat.Default)]
		public List<ProTeam> Teams
		{
			get
			{
				return this._Teams;
			}
		}

		// Token: 0x1700188D RID: 6285
		// (get) Token: 0x0600604C RID: 24652 RVA: 0x001B32E0 File Offset: 0x001B14E0
		// (set) Token: 0x0600604D RID: 24653 RVA: 0x001B32E8 File Offset: 0x001B14E8
		[ProtoMember(3, IsRequired = true, Name = "ProcessingBattleInfo", DataFormat = DataFormat.Default)]
		public ProBattleProcessing ProcessingBattleInfo
		{
			get
			{
				return this._ProcessingBattleInfo;
			}
			set
			{
				this._ProcessingBattleInfo = value;
			}
		}

		// Token: 0x1700188E RID: 6286
		// (get) Token: 0x0600604E RID: 24654 RVA: 0x001B32F4 File Offset: 0x001B14F4
		[ProtoMember(4, Name = "GotBattleTreasureIds", DataFormat = DataFormat.TwosComplement)]
		public List<int> GotBattleTreasureIds
		{
			get
			{
				return this._GotBattleTreasureIds;
			}
		}

		// Token: 0x1700188F RID: 6287
		// (get) Token: 0x0600604F RID: 24655 RVA: 0x001B32FC File Offset: 0x001B14FC
		// (set) Token: 0x06006050 RID: 24656 RVA: 0x001B3304 File Offset: 0x001B1504
		[DefaultValue(0)]
		[ProtoMember(5, IsRequired = false, Name = "ArenaBattleStatus", DataFormat = DataFormat.TwosComplement)]
		public int ArenaBattleStatus
		{
			get
			{
				return this._ArenaBattleStatus;
			}
			set
			{
				this._ArenaBattleStatus = value;
			}
		}

		// Token: 0x17001890 RID: 6288
		// (get) Token: 0x06006051 RID: 24657 RVA: 0x001B3310 File Offset: 0x001B1510
		// (set) Token: 0x06006052 RID: 24658 RVA: 0x001B3318 File Offset: 0x001B1518
		[ProtoMember(6, IsRequired = false, Name = "ArenaBattleId", DataFormat = DataFormat.TwosComplement)]
		[DefaultValue(0)]
		public int ArenaBattleId
		{
			get
			{
				return this._ArenaBattleId;
			}
			set
			{
				this._ArenaBattleId = value;
			}
		}

		// Token: 0x17001891 RID: 6289
		// (get) Token: 0x06006053 RID: 24659 RVA: 0x001B3324 File Offset: 0x001B1524
		// (set) Token: 0x06006054 RID: 24660 RVA: 0x001B332C File Offset: 0x001B152C
		[DefaultValue(0)]
		[ProtoMember(7, IsRequired = false, Name = "ArenaBattleRandomSeed", DataFormat = DataFormat.TwosComplement)]
		public int ArenaBattleRandomSeed
		{
			get
			{
				return this._ArenaBattleRandomSeed;
			}
			set
			{
				this._ArenaBattleRandomSeed = value;
			}
		}

		// Token: 0x17001892 RID: 6290
		// (get) Token: 0x06006055 RID: 24661 RVA: 0x001B3338 File Offset: 0x001B1538
		// (set) Token: 0x06006056 RID: 24662 RVA: 0x001B3340 File Offset: 0x001B1540
		[ProtoMember(8, IsRequired = true, Name = "BattleRoomId", DataFormat = DataFormat.TwosComplement)]
		public ulong BattleRoomId
		{
			get
			{
				return this._BattleRoomId;
			}
			set
			{
				this._BattleRoomId = value;
			}
		}

		// Token: 0x06006057 RID: 24663 RVA: 0x001B334C File Offset: 0x001B154C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06006058 RID: 24664 RVA: 0x001B335C File Offset: 0x001B155C
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

		// Token: 0x06006059 RID: 24665 RVA: 0x001B3428 File Offset: 0x001B1628
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(DSBattleNtf));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004811 RID: 18449
		private uint _Version;

		// Token: 0x04004812 RID: 18450
		private readonly List<ProTeam> _Teams = new List<ProTeam>();

		// Token: 0x04004813 RID: 18451
		private ProBattleProcessing _ProcessingBattleInfo;

		// Token: 0x04004814 RID: 18452
		private readonly List<int> _GotBattleTreasureIds = new List<int>();

		// Token: 0x04004815 RID: 18453
		private int _ArenaBattleStatus;

		// Token: 0x04004816 RID: 18454
		private int _ArenaBattleId;

		// Token: 0x04004817 RID: 18455
		private int _ArenaBattleRandomSeed;

		// Token: 0x04004818 RID: 18456
		private ulong _BattleRoomId;

		// Token: 0x04004819 RID: 18457
		private IExtension extensionObject;

		// Token: 0x0400481A RID: 18458
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400481B RID: 18459
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400481C RID: 18460
		private LuaFunction m_ctor_hotfix;
	}
}
