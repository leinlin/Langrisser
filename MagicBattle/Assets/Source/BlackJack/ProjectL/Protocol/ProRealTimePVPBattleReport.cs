using System;
using System.Collections.Generic;
using System.ComponentModel;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200069B RID: 1691
	[ProtoContract(Name = "ProRealTimePVPBattleReport")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ProRealTimePVPBattleReport : IExtensible
	{
		// Token: 0x06005BC1 RID: 23489 RVA: 0x001A3F70 File Offset: 0x001A2170
		public ProRealTimePVPBattleReport()
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

		// Token: 0x1700172F RID: 5935
		// (get) Token: 0x06005BC2 RID: 23490 RVA: 0x001A3FEC File Offset: 0x001A21EC
		// (set) Token: 0x06005BC3 RID: 23491 RVA: 0x001A3FF4 File Offset: 0x001A21F4
		[DefaultValue(0)]
		[ProtoMember(1, IsRequired = false, Name = "Version", DataFormat = DataFormat.TwosComplement)]
		public int Version
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

		// Token: 0x17001730 RID: 5936
		// (get) Token: 0x06005BC4 RID: 23492 RVA: 0x001A4000 File Offset: 0x001A2200
		// (set) Token: 0x06005BC5 RID: 23493 RVA: 0x001A4008 File Offset: 0x001A2208
		[ProtoMember(2, IsRequired = false, Name = "InstanceId", DataFormat = DataFormat.TwosComplement)]
		[DefaultValue(0f)]
		public ulong InstanceId
		{
			get
			{
				return this._InstanceId;
			}
			set
			{
				this._InstanceId = value;
			}
		}

		// Token: 0x17001731 RID: 5937
		// (get) Token: 0x06005BC6 RID: 23494 RVA: 0x001A4014 File Offset: 0x001A2214
		// (set) Token: 0x06005BC7 RID: 23495 RVA: 0x001A401C File Offset: 0x001A221C
		[DefaultValue(0)]
		[ProtoMember(3, IsRequired = false, Name = "BattleType", DataFormat = DataFormat.TwosComplement)]
		public int BattleType
		{
			get
			{
				return this._BattleType;
			}
			set
			{
				this._BattleType = value;
			}
		}

		// Token: 0x17001732 RID: 5938
		// (get) Token: 0x06005BC8 RID: 23496 RVA: 0x001A4028 File Offset: 0x001A2228
		// (set) Token: 0x06005BC9 RID: 23497 RVA: 0x001A4030 File Offset: 0x001A2230
		[ProtoMember(4, IsRequired = false, Name = "BattleId", DataFormat = DataFormat.TwosComplement)]
		[DefaultValue(0)]
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

		// Token: 0x17001733 RID: 5939
		// (get) Token: 0x06005BCA RID: 23498 RVA: 0x001A403C File Offset: 0x001A223C
		// (set) Token: 0x06005BCB RID: 23499 RVA: 0x001A4044 File Offset: 0x001A2244
		[DefaultValue(0)]
		[ProtoMember(5, IsRequired = false, Name = "RandomSeed", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x17001734 RID: 5940
		// (get) Token: 0x06005BCC RID: 23500 RVA: 0x001A4050 File Offset: 0x001A2250
		// (set) Token: 0x06005BCD RID: 23501 RVA: 0x001A4058 File Offset: 0x001A2258
		[DefaultValue(0)]
		[ProtoMember(6, IsRequired = false, Name = "BPRule", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x17001735 RID: 5941
		// (get) Token: 0x06005BCE RID: 23502 RVA: 0x001A4064 File Offset: 0x001A2264
		[ProtoMember(7, Name = "Commands", DataFormat = DataFormat.Default)]
		public List<ProBattleCommand> Commands
		{
			get
			{
				return this._Commands;
			}
		}

		// Token: 0x17001736 RID: 5942
		// (get) Token: 0x06005BCF RID: 23503 RVA: 0x001A406C File Offset: 0x001A226C
		// (set) Token: 0x06005BD0 RID: 23504 RVA: 0x001A4074 File Offset: 0x001A2274
		[DefaultValue(0)]
		[ProtoMember(8, IsRequired = false, Name = "ReportType", DataFormat = DataFormat.TwosComplement)]
		public int ReportType
		{
			get
			{
				return this._ReportType;
			}
			set
			{
				this._ReportType = value;
			}
		}

		// Token: 0x17001737 RID: 5943
		// (get) Token: 0x06005BD1 RID: 23505 RVA: 0x001A4080 File Offset: 0x001A2280
		[ProtoMember(9, Name = "Datas", DataFormat = DataFormat.Default)]
		public List<ProRealTimePVPBattleReportPlayerData> Datas
		{
			get
			{
				return this._Datas;
			}
		}

		// Token: 0x17001738 RID: 5944
		// (get) Token: 0x06005BD2 RID: 23506 RVA: 0x001A4088 File Offset: 0x001A2288
		// (set) Token: 0x06005BD3 RID: 23507 RVA: 0x001A4090 File Offset: 0x001A2290
		[ProtoMember(10, IsRequired = true, Name = "Win", DataFormat = DataFormat.Default)]
		public bool Win
		{
			get
			{
				return this._Win;
			}
			set
			{
				this._Win = value;
			}
		}

		// Token: 0x17001739 RID: 5945
		// (get) Token: 0x06005BD4 RID: 23508 RVA: 0x001A409C File Offset: 0x001A229C
		// (set) Token: 0x06005BD5 RID: 23509 RVA: 0x001A40A4 File Offset: 0x001A22A4
		[ProtoMember(11, IsRequired = false, Name = "CreateTime", DataFormat = DataFormat.TwosComplement)]
		[DefaultValue(0L)]
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

		// Token: 0x1700173A RID: 5946
		// (get) Token: 0x06005BD6 RID: 23510 RVA: 0x001A40B0 File Offset: 0x001A22B0
		// (set) Token: 0x06005BD7 RID: 23511 RVA: 0x001A40B8 File Offset: 0x001A22B8
		[ProtoMember(12, IsRequired = true, Name = "IsCancel", DataFormat = DataFormat.Default)]
		public bool IsCancel
		{
			get
			{
				return this._IsCancel;
			}
			set
			{
				this._IsCancel = value;
			}
		}

		// Token: 0x06005BD8 RID: 23512 RVA: 0x001A40C4 File Offset: 0x001A22C4
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005BD9 RID: 23513 RVA: 0x001A40D4 File Offset: 0x001A22D4
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

		// Token: 0x06005BDA RID: 23514 RVA: 0x001A41A0 File Offset: 0x001A23A0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ProRealTimePVPBattleReport));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040044B1 RID: 17585
		private int _Version;

		// Token: 0x040044B2 RID: 17586
		private ulong _InstanceId;

		// Token: 0x040044B3 RID: 17587
		private int _BattleType;

		// Token: 0x040044B4 RID: 17588
		private int _BattleId;

		// Token: 0x040044B5 RID: 17589
		private int _RandomSeed;

		// Token: 0x040044B6 RID: 17590
		private int _BPRule;

		// Token: 0x040044B7 RID: 17591
		private readonly List<ProBattleCommand> _Commands = new List<ProBattleCommand>();

		// Token: 0x040044B8 RID: 17592
		private int _ReportType;

		// Token: 0x040044B9 RID: 17593
		private readonly List<ProRealTimePVPBattleReportPlayerData> _Datas = new List<ProRealTimePVPBattleReportPlayerData>();

		// Token: 0x040044BA RID: 17594
		private bool _Win;

		// Token: 0x040044BB RID: 17595
		private long _CreateTime;

		// Token: 0x040044BC RID: 17596
		private bool _IsCancel;

		// Token: 0x040044BD RID: 17597
		private IExtension extensionObject;

		// Token: 0x040044BE RID: 17598
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040044BF RID: 17599
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040044C0 RID: 17600
		private LuaFunction m_ctor_hotfix;
	}
}
