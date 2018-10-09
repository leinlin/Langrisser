using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000716 RID: 1814
	[ProtoContract(Name = "DSPlayerBasicNtf")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class DSPlayerBasicNtf : IExtensible
	{
		// Token: 0x06005FDE RID: 24542 RVA: 0x001B24C4 File Offset: 0x001B06C4
		public DSPlayerBasicNtf()
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

		// Token: 0x1700185E RID: 6238
		// (get) Token: 0x06005FDF RID: 24543 RVA: 0x001B2538 File Offset: 0x001B0738
		// (set) Token: 0x06005FE0 RID: 24544 RVA: 0x001B2540 File Offset: 0x001B0740
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

		// Token: 0x1700185F RID: 6239
		// (get) Token: 0x06005FE1 RID: 24545 RVA: 0x001B254C File Offset: 0x001B074C
		// (set) Token: 0x06005FE2 RID: 24546 RVA: 0x001B2554 File Offset: 0x001B0754
		[ProtoMember(2, IsRequired = true, Name = "PlayerLevel", DataFormat = DataFormat.TwosComplement)]
		public int PlayerLevel
		{
			get
			{
				return this._PlayerLevel;
			}
			set
			{
				this._PlayerLevel = value;
			}
		}

		// Token: 0x17001860 RID: 6240
		// (get) Token: 0x06005FE3 RID: 24547 RVA: 0x001B2560 File Offset: 0x001B0760
		// (set) Token: 0x06005FE4 RID: 24548 RVA: 0x001B2568 File Offset: 0x001B0768
		[ProtoMember(3, IsRequired = true, Name = "RechargeCsystal", DataFormat = DataFormat.TwosComplement)]
		public long RechargeCsystal
		{
			get
			{
				return this._RechargeCsystal;
			}
			set
			{
				this._RechargeCsystal = value;
			}
		}

		// Token: 0x17001861 RID: 6241
		// (get) Token: 0x06005FE5 RID: 24549 RVA: 0x001B2574 File Offset: 0x001B0774
		// (set) Token: 0x06005FE6 RID: 24550 RVA: 0x001B257C File Offset: 0x001B077C
		[ProtoMember(4, IsRequired = true, Name = "ExpCurr", DataFormat = DataFormat.TwosComplement)]
		public int ExpCurr
		{
			get
			{
				return this._ExpCurr;
			}
			set
			{
				this._ExpCurr = value;
			}
		}

		// Token: 0x17001862 RID: 6242
		// (get) Token: 0x06005FE7 RID: 24551 RVA: 0x001B2588 File Offset: 0x001B0788
		// (set) Token: 0x06005FE8 RID: 24552 RVA: 0x001B2590 File Offset: 0x001B0790
		[ProtoMember(5, IsRequired = true, Name = "Energy", DataFormat = DataFormat.TwosComplement)]
		public int Energy
		{
			get
			{
				return this._Energy;
			}
			set
			{
				this._Energy = value;
			}
		}

		// Token: 0x17001863 RID: 6243
		// (get) Token: 0x06005FE9 RID: 24553 RVA: 0x001B259C File Offset: 0x001B079C
		// (set) Token: 0x06005FEA RID: 24554 RVA: 0x001B25A4 File Offset: 0x001B07A4
		[ProtoMember(6, IsRequired = true, Name = "Gold", DataFormat = DataFormat.TwosComplement)]
		public long Gold
		{
			get
			{
				return this._Gold;
			}
			set
			{
				this._Gold = value;
			}
		}

		// Token: 0x17001864 RID: 6244
		// (get) Token: 0x06005FEB RID: 24555 RVA: 0x001B25B0 File Offset: 0x001B07B0
		// (set) Token: 0x06005FEC RID: 24556 RVA: 0x001B25B8 File Offset: 0x001B07B8
		[ProtoMember(7, IsRequired = true, Name = "Crystal", DataFormat = DataFormat.TwosComplement)]
		public long Crystal
		{
			get
			{
				return this._Crystal;
			}
			set
			{
				this._Crystal = value;
			}
		}

		// Token: 0x17001865 RID: 6245
		// (get) Token: 0x06005FED RID: 24557 RVA: 0x001B25C4 File Offset: 0x001B07C4
		// (set) Token: 0x06005FEE RID: 24558 RVA: 0x001B25CC File Offset: 0x001B07CC
		[ProtoMember(8, IsRequired = true, Name = "LastSignTime", DataFormat = DataFormat.TwosComplement)]
		public long LastSignTime
		{
			get
			{
				return this._LastSignTime;
			}
			set
			{
				this._LastSignTime = value;
			}
		}

		// Token: 0x17001866 RID: 6246
		// (get) Token: 0x06005FEF RID: 24559 RVA: 0x001B25D8 File Offset: 0x001B07D8
		// (set) Token: 0x06005FF0 RID: 24560 RVA: 0x001B25E0 File Offset: 0x001B07E0
		[ProtoMember(9, IsRequired = true, Name = "SignDays", DataFormat = DataFormat.TwosComplement)]
		public int SignDays
		{
			get
			{
				return this._SignDays;
			}
			set
			{
				this._SignDays = value;
			}
		}

		// Token: 0x17001867 RID: 6247
		// (get) Token: 0x06005FF1 RID: 24561 RVA: 0x001B25EC File Offset: 0x001B07EC
		// (set) Token: 0x06005FF2 RID: 24562 RVA: 0x001B25F4 File Offset: 0x001B07F4
		[ProtoMember(10, IsRequired = true, Name = "HeadIcon", DataFormat = DataFormat.TwosComplement)]
		public int HeadIcon
		{
			get
			{
				return this._HeadIcon;
			}
			set
			{
				this._HeadIcon = value;
			}
		}

		// Token: 0x17001868 RID: 6248
		// (get) Token: 0x06005FF3 RID: 24563 RVA: 0x001B2600 File Offset: 0x001B0800
		// (set) Token: 0x06005FF4 RID: 24564 RVA: 0x001B2608 File Offset: 0x001B0808
		[ProtoMember(11, IsRequired = true, Name = "BuyEngryNums", DataFormat = DataFormat.TwosComplement)]
		public int BuyEngryNums
		{
			get
			{
				return this._BuyEngryNums;
			}
			set
			{
				this._BuyEngryNums = value;
			}
		}

		// Token: 0x17001869 RID: 6249
		// (get) Token: 0x06005FF5 RID: 24565 RVA: 0x001B2614 File Offset: 0x001B0814
		// (set) Token: 0x06005FF6 RID: 24566 RVA: 0x001B261C File Offset: 0x001B081C
		[ProtoMember(12, IsRequired = true, Name = "PlayerActionNextFlushTime", DataFormat = DataFormat.TwosComplement)]
		public long PlayerActionNextFlushTime
		{
			get
			{
				return this._PlayerActionNextFlushTime;
			}
			set
			{
				this._PlayerActionNextFlushTime = value;
			}
		}

		// Token: 0x1700186A RID: 6250
		// (get) Token: 0x06005FF7 RID: 24567 RVA: 0x001B2628 File Offset: 0x001B0828
		[ProtoMember(13, Name = "GuideCompleteFlags", DataFormat = DataFormat.TwosComplement)]
		public List<int> GuideCompleteFlags
		{
			get
			{
				return this._GuideCompleteFlags;
			}
		}

		// Token: 0x1700186B RID: 6251
		// (get) Token: 0x06005FF8 RID: 24568 RVA: 0x001B2630 File Offset: 0x001B0830
		// (set) Token: 0x06005FF9 RID: 24569 RVA: 0x001B2638 File Offset: 0x001B0838
		[ProtoMember(14, IsRequired = true, Name = "ArenaTickets", DataFormat = DataFormat.TwosComplement)]
		public int ArenaTickets
		{
			get
			{
				return this._ArenaTickets;
			}
			set
			{
				this._ArenaTickets = value;
			}
		}

		// Token: 0x1700186C RID: 6252
		// (get) Token: 0x06005FFA RID: 24570 RVA: 0x001B2644 File Offset: 0x001B0844
		// (set) Token: 0x06005FFB RID: 24571 RVA: 0x001B264C File Offset: 0x001B084C
		[ProtoMember(15, IsRequired = true, Name = "ArenaHonour", DataFormat = DataFormat.TwosComplement)]
		public int ArenaHonour
		{
			get
			{
				return this._ArenaHonour;
			}
			set
			{
				this._ArenaHonour = value;
			}
		}

		// Token: 0x1700186D RID: 6253
		// (get) Token: 0x06005FFC RID: 24572 RVA: 0x001B2658 File Offset: 0x001B0858
		// (set) Token: 0x06005FFD RID: 24573 RVA: 0x001B2660 File Offset: 0x001B0860
		[ProtoMember(16, IsRequired = true, Name = "BuyArenaTicketsNums", DataFormat = DataFormat.TwosComplement)]
		public int BuyArenaTicketsNums
		{
			get
			{
				return this._BuyArenaTicketsNums;
			}
			set
			{
				this._BuyArenaTicketsNums = value;
			}
		}

		// Token: 0x1700186E RID: 6254
		// (get) Token: 0x06005FFE RID: 24574 RVA: 0x001B266C File Offset: 0x001B086C
		// (set) Token: 0x06005FFF RID: 24575 RVA: 0x001B2674 File Offset: 0x001B0874
		[ProtoMember(17, IsRequired = true, Name = "EnergyFlushTime", DataFormat = DataFormat.TwosComplement)]
		public long EnergyFlushTime
		{
			get
			{
				return this._EnergyFlushTime;
			}
			set
			{
				this._EnergyFlushTime = value;
			}
		}

		// Token: 0x1700186F RID: 6255
		// (get) Token: 0x06006000 RID: 24576 RVA: 0x001B2680 File Offset: 0x001B0880
		// (set) Token: 0x06006001 RID: 24577 RVA: 0x001B2688 File Offset: 0x001B0888
		[ProtoMember(18, IsRequired = true, Name = "CreateTime", DataFormat = DataFormat.TwosComplement)]
		public long CreateTime
		{
			get
			{
				return this._CreateTime;
			}
			set
			{
				this._CreateTime = value;
			}
		}

		// Token: 0x17001870 RID: 6256
		// (get) Token: 0x06006002 RID: 24578 RVA: 0x001B2694 File Offset: 0x001B0894
		// (set) Token: 0x06006003 RID: 24579 RVA: 0x001B269C File Offset: 0x001B089C
		[ProtoMember(19, IsRequired = true, Name = "FriendshipPoints", DataFormat = DataFormat.TwosComplement)]
		public int FriendshipPoints
		{
			get
			{
				return this._FriendshipPoints;
			}
			set
			{
				this._FriendshipPoints = value;
			}
		}

		// Token: 0x17001871 RID: 6257
		// (get) Token: 0x06006004 RID: 24580 RVA: 0x001B26A8 File Offset: 0x001B08A8
		// (set) Token: 0x06006005 RID: 24581 RVA: 0x001B26B0 File Offset: 0x001B08B0
		[ProtoMember(20, IsRequired = true, Name = "OpenGameRating", DataFormat = DataFormat.Default)]
		public bool OpenGameRating
		{
			get
			{
				return this._OpenGameRating;
			}
			set
			{
				this._OpenGameRating = value;
			}
		}

		// Token: 0x17001872 RID: 6258
		// (get) Token: 0x06006006 RID: 24582 RVA: 0x001B26BC File Offset: 0x001B08BC
		// (set) Token: 0x06006007 RID: 24583 RVA: 0x001B26C4 File Offset: 0x001B08C4
		[ProtoMember(21, IsRequired = true, Name = "RechargeRMB", DataFormat = DataFormat.TwosComplement)]
		public long RechargeRMB
		{
			get
			{
				return this._RechargeRMB;
			}
			set
			{
				this._RechargeRMB = value;
			}
		}

		// Token: 0x17001873 RID: 6259
		// (get) Token: 0x06006008 RID: 24584 RVA: 0x001B26D0 File Offset: 0x001B08D0
		// (set) Token: 0x06006009 RID: 24585 RVA: 0x001B26D8 File Offset: 0x001B08D8
		[ProtoMember(22, IsRequired = true, Name = "SkinTickets", DataFormat = DataFormat.TwosComplement)]
		public int SkinTickets
		{
			get
			{
				return this._SkinTickets;
			}
			set
			{
				this._SkinTickets = value;
			}
		}

		// Token: 0x17001874 RID: 6260
		// (get) Token: 0x0600600A RID: 24586 RVA: 0x001B26E4 File Offset: 0x001B08E4
		// (set) Token: 0x0600600B RID: 24587 RVA: 0x001B26EC File Offset: 0x001B08EC
		[ProtoMember(23, IsRequired = true, Name = "RealTimePVPHonor", DataFormat = DataFormat.TwosComplement)]
		public int RealTimePVPHonor
		{
			get
			{
				return this._RealTimePVPHonor;
			}
			set
			{
				this._RealTimePVPHonor = value;
			}
		}

		// Token: 0x17001875 RID: 6261
		// (get) Token: 0x0600600C RID: 24588 RVA: 0x001B26F8 File Offset: 0x001B08F8
		// (set) Token: 0x0600600D RID: 24589 RVA: 0x001B2700 File Offset: 0x001B0900
		[ProtoMember(24, IsRequired = true, Name = "MemoryEssence", DataFormat = DataFormat.TwosComplement)]
		public int MemoryEssence
		{
			get
			{
				return this._MemoryEssence;
			}
			set
			{
				this._MemoryEssence = value;
			}
		}

		// Token: 0x17001876 RID: 6262
		// (get) Token: 0x0600600E RID: 24590 RVA: 0x001B270C File Offset: 0x001B090C
		// (set) Token: 0x0600600F RID: 24591 RVA: 0x001B2714 File Offset: 0x001B0914
		[ProtoMember(25, IsRequired = true, Name = "MithralStone", DataFormat = DataFormat.TwosComplement)]
		public int MithralStone
		{
			get
			{
				return this._MithralStone;
			}
			set
			{
				this._MithralStone = value;
			}
		}

		// Token: 0x17001877 RID: 6263
		// (get) Token: 0x06006010 RID: 24592 RVA: 0x001B2720 File Offset: 0x001B0920
		// (set) Token: 0x06006011 RID: 24593 RVA: 0x001B2728 File Offset: 0x001B0928
		[ProtoMember(26, IsRequired = true, Name = "BrillianceMithralStone", DataFormat = DataFormat.TwosComplement)]
		public int BrillianceMithralStone
		{
			get
			{
				return this._BrillianceMithralStone;
			}
			set
			{
				this._BrillianceMithralStone = value;
			}
		}

		// Token: 0x17001878 RID: 6264
		// (get) Token: 0x06006012 RID: 24594 RVA: 0x001B2734 File Offset: 0x001B0934
		// (set) Token: 0x06006013 RID: 24595 RVA: 0x001B273C File Offset: 0x001B093C
		[ProtoMember(27, IsRequired = true, Name = "VipLevel", DataFormat = DataFormat.TwosComplement)]
		public int VipLevel
		{
			get
			{
				return this._VipLevel;
			}
			set
			{
				this._VipLevel = value;
			}
		}

		// Token: 0x17001879 RID: 6265
		// (get) Token: 0x06006014 RID: 24596 RVA: 0x001B2748 File Offset: 0x001B0948
		// (set) Token: 0x06006015 RID: 24597 RVA: 0x001B2750 File Offset: 0x001B0950
		[ProtoMember(28, IsRequired = true, Name = "MemoryStoreOpen", DataFormat = DataFormat.Default)]
		public bool MemoryStoreOpen
		{
			get
			{
				return this._MemoryStoreOpen;
			}
			set
			{
				this._MemoryStoreOpen = value;
			}
		}

		// Token: 0x1700187A RID: 6266
		// (get) Token: 0x06006016 RID: 24598 RVA: 0x001B275C File Offset: 0x001B095C
		// (set) Token: 0x06006017 RID: 24599 RVA: 0x001B2764 File Offset: 0x001B0964
		[ProtoMember(29, IsRequired = true, Name = "GuildMedal", DataFormat = DataFormat.TwosComplement)]
		public int GuildMedal
		{
			get
			{
				return this._GuildMedal;
			}
			set
			{
				this._GuildMedal = value;
			}
		}

		// Token: 0x06006018 RID: 24600 RVA: 0x001B2770 File Offset: 0x001B0970
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06006019 RID: 24601 RVA: 0x001B2780 File Offset: 0x001B0980
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

		// Token: 0x0600601A RID: 24602 RVA: 0x001B284C File Offset: 0x001B0A4C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(DSPlayerBasicNtf));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040047CC RID: 18380
		private uint _Version;

		// Token: 0x040047CD RID: 18381
		private int _PlayerLevel;

		// Token: 0x040047CE RID: 18382
		private long _RechargeCsystal;

		// Token: 0x040047CF RID: 18383
		private int _ExpCurr;

		// Token: 0x040047D0 RID: 18384
		private int _Energy;

		// Token: 0x040047D1 RID: 18385
		private long _Gold;

		// Token: 0x040047D2 RID: 18386
		private long _Crystal;

		// Token: 0x040047D3 RID: 18387
		private long _LastSignTime;

		// Token: 0x040047D4 RID: 18388
		private int _SignDays;

		// Token: 0x040047D5 RID: 18389
		private int _HeadIcon;

		// Token: 0x040047D6 RID: 18390
		private int _BuyEngryNums;

		// Token: 0x040047D7 RID: 18391
		private long _PlayerActionNextFlushTime;

		// Token: 0x040047D8 RID: 18392
		private readonly List<int> _GuideCompleteFlags = new List<int>();

		// Token: 0x040047D9 RID: 18393
		private int _ArenaTickets;

		// Token: 0x040047DA RID: 18394
		private int _ArenaHonour;

		// Token: 0x040047DB RID: 18395
		private int _BuyArenaTicketsNums;

		// Token: 0x040047DC RID: 18396
		private long _EnergyFlushTime;

		// Token: 0x040047DD RID: 18397
		private long _CreateTime;

		// Token: 0x040047DE RID: 18398
		private int _FriendshipPoints;

		// Token: 0x040047DF RID: 18399
		private bool _OpenGameRating;

		// Token: 0x040047E0 RID: 18400
		private long _RechargeRMB;

		// Token: 0x040047E1 RID: 18401
		private int _SkinTickets;

		// Token: 0x040047E2 RID: 18402
		private int _RealTimePVPHonor;

		// Token: 0x040047E3 RID: 18403
		private int _MemoryEssence;

		// Token: 0x040047E4 RID: 18404
		private int _MithralStone;

		// Token: 0x040047E5 RID: 18405
		private int _BrillianceMithralStone;

		// Token: 0x040047E6 RID: 18406
		private int _VipLevel;

		// Token: 0x040047E7 RID: 18407
		private bool _MemoryStoreOpen;

		// Token: 0x040047E8 RID: 18408
		private int _GuildMedal;

		// Token: 0x040047E9 RID: 18409
		private IExtension extensionObject;

		// Token: 0x040047EA RID: 18410
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040047EB RID: 18411
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040047EC RID: 18412
		private LuaFunction m_ctor_hotfix;
	}
}
