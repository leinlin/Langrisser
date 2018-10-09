using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x02000277 RID: 631
	[HotFix(true, m_isCtorOnly = true)]
	[CustomLuaClass]
	[ProtoContract(Name = "ConfigDataRealTimePVPBattleInfo")]
	[Serializable]
	public class ConfigDataRealTimePVPBattleInfo : IExtensible
	{
		// Token: 0x06002856 RID: 10326 RVA: 0x000ADFC8 File Offset: 0x000AC1C8
		public ConfigDataRealTimePVPBattleInfo()
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

		// Token: 0x17000A7F RID: 2687
		// (get) Token: 0x06002857 RID: 10327 RVA: 0x000AE07C File Offset: 0x000AC27C
		// (set) Token: 0x06002858 RID: 10328 RVA: 0x000AE084 File Offset: 0x000AC284
		[ProtoMember(2, IsRequired = true, Name = "ID", DataFormat = DataFormat.TwosComplement)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				this._ID = value;
			}
		}

		// Token: 0x17000A80 RID: 2688
		// (get) Token: 0x06002859 RID: 10329 RVA: 0x000AE090 File Offset: 0x000AC290
		// (set) Token: 0x0600285A RID: 10330 RVA: 0x000AE098 File Offset: 0x000AC298
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

		// Token: 0x17000A81 RID: 2689
		// (get) Token: 0x0600285B RID: 10331 RVA: 0x000AE0A4 File Offset: 0x000AC2A4
		// (set) Token: 0x0600285C RID: 10332 RVA: 0x000AE0AC File Offset: 0x000AC2AC
		[ProtoMember(4, IsRequired = true, Name = "NameStrKey", DataFormat = DataFormat.Default)]
		public string NameStrKey
		{
			get
			{
				return this._NameStrKey;
			}
			set
			{
				this._NameStrKey = value;
			}
		}

		// Token: 0x17000A82 RID: 2690
		// (get) Token: 0x0600285D RID: 10333 RVA: 0x000AE0B8 File Offset: 0x000AC2B8
		// (set) Token: 0x0600285E RID: 10334 RVA: 0x000AE0C0 File Offset: 0x000AC2C0
		[ProtoMember(5, IsRequired = true, Name = "Desc", DataFormat = DataFormat.Default)]
		public string Desc
		{
			get
			{
				return this._Desc;
			}
			set
			{
				this._Desc = value;
			}
		}

		// Token: 0x17000A83 RID: 2691
		// (get) Token: 0x0600285F RID: 10335 RVA: 0x000AE0CC File Offset: 0x000AC2CC
		// (set) Token: 0x06002860 RID: 10336 RVA: 0x000AE0D4 File Offset: 0x000AC2D4
		[ProtoMember(6, IsRequired = true, Name = "DescStrKey", DataFormat = DataFormat.Default)]
		public string DescStrKey
		{
			get
			{
				return this._DescStrKey;
			}
			set
			{
				this._DescStrKey = value;
			}
		}

		// Token: 0x17000A84 RID: 2692
		// (get) Token: 0x06002861 RID: 10337 RVA: 0x000AE0E0 File Offset: 0x000AC2E0
		// (set) Token: 0x06002862 RID: 10338 RVA: 0x000AE0E8 File Offset: 0x000AC2E8
		[ProtoMember(7, IsRequired = true, Name = "WinDesc", DataFormat = DataFormat.Default)]
		public string WinDesc
		{
			get
			{
				return this._WinDesc;
			}
			set
			{
				this._WinDesc = value;
			}
		}

		// Token: 0x17000A85 RID: 2693
		// (get) Token: 0x06002863 RID: 10339 RVA: 0x000AE0F4 File Offset: 0x000AC2F4
		// (set) Token: 0x06002864 RID: 10340 RVA: 0x000AE0FC File Offset: 0x000AC2FC
		[ProtoMember(8, IsRequired = true, Name = "WinDescStrKey", DataFormat = DataFormat.Default)]
		public string WinDescStrKey
		{
			get
			{
				return this._WinDescStrKey;
			}
			set
			{
				this._WinDescStrKey = value;
			}
		}

		// Token: 0x17000A86 RID: 2694
		// (get) Token: 0x06002865 RID: 10341 RVA: 0x000AE108 File Offset: 0x000AC308
		// (set) Token: 0x06002866 RID: 10342 RVA: 0x000AE110 File Offset: 0x000AC310
		[ProtoMember(9, IsRequired = true, Name = "LoseDesc", DataFormat = DataFormat.Default)]
		public string LoseDesc
		{
			get
			{
				return this._LoseDesc;
			}
			set
			{
				this._LoseDesc = value;
			}
		}

		// Token: 0x17000A87 RID: 2695
		// (get) Token: 0x06002867 RID: 10343 RVA: 0x000AE11C File Offset: 0x000AC31C
		// (set) Token: 0x06002868 RID: 10344 RVA: 0x000AE124 File Offset: 0x000AC324
		[ProtoMember(10, IsRequired = true, Name = "LoseDescStrKey", DataFormat = DataFormat.Default)]
		public string LoseDescStrKey
		{
			get
			{
				return this._LoseDescStrKey;
			}
			set
			{
				this._LoseDescStrKey = value;
			}
		}

		// Token: 0x17000A88 RID: 2696
		// (get) Token: 0x06002869 RID: 10345 RVA: 0x000AE130 File Offset: 0x000AC330
		// (set) Token: 0x0600286A RID: 10346 RVA: 0x000AE138 File Offset: 0x000AC338
		[ProtoMember(11, IsRequired = true, Name = "Battlefield_ID", DataFormat = DataFormat.TwosComplement)]
		public int Battlefield_ID
		{
			get
			{
				return this._Battlefield_ID;
			}
			set
			{
				this._Battlefield_ID = value;
			}
		}

		// Token: 0x17000A89 RID: 2697
		// (get) Token: 0x0600286B RID: 10347 RVA: 0x000AE144 File Offset: 0x000AC344
		// (set) Token: 0x0600286C RID: 10348 RVA: 0x000AE14C File Offset: 0x000AC34C
		[ProtoMember(12, IsRequired = true, Name = "CameraX", DataFormat = DataFormat.TwosComplement)]
		public int CameraX
		{
			get
			{
				return this._CameraX;
			}
			set
			{
				this._CameraX = value;
			}
		}

		// Token: 0x17000A8A RID: 2698
		// (get) Token: 0x0600286D RID: 10349 RVA: 0x000AE158 File Offset: 0x000AC358
		// (set) Token: 0x0600286E RID: 10350 RVA: 0x000AE160 File Offset: 0x000AC360
		[ProtoMember(13, IsRequired = true, Name = "CameraY", DataFormat = DataFormat.TwosComplement)]
		public int CameraY
		{
			get
			{
				return this._CameraY;
			}
			set
			{
				this._CameraY = value;
			}
		}

		// Token: 0x17000A8B RID: 2699
		// (get) Token: 0x0600286F RID: 10351 RVA: 0x000AE16C File Offset: 0x000AC36C
		// (set) Token: 0x06002870 RID: 10352 RVA: 0x000AE174 File Offset: 0x000AC374
		[ProtoMember(14, IsRequired = true, Name = "DefendCameraX", DataFormat = DataFormat.TwosComplement)]
		public int DefendCameraX
		{
			get
			{
				return this._DefendCameraX;
			}
			set
			{
				this._DefendCameraX = value;
			}
		}

		// Token: 0x17000A8C RID: 2700
		// (get) Token: 0x06002871 RID: 10353 RVA: 0x000AE180 File Offset: 0x000AC380
		// (set) Token: 0x06002872 RID: 10354 RVA: 0x000AE188 File Offset: 0x000AC388
		[ProtoMember(15, IsRequired = true, Name = "DefendCameraY", DataFormat = DataFormat.TwosComplement)]
		public int DefendCameraY
		{
			get
			{
				return this._DefendCameraY;
			}
			set
			{
				this._DefendCameraY = value;
			}
		}

		// Token: 0x17000A8D RID: 2701
		// (get) Token: 0x06002873 RID: 10355 RVA: 0x000AE194 File Offset: 0x000AC394
		// (set) Token: 0x06002874 RID: 10356 RVA: 0x000AE19C File Offset: 0x000AC39C
		[ProtoMember(16, IsRequired = true, Name = "PrepareMusic", DataFormat = DataFormat.Default)]
		public string PrepareMusic
		{
			get
			{
				return this._PrepareMusic;
			}
			set
			{
				this._PrepareMusic = value;
			}
		}

		// Token: 0x17000A8E RID: 2702
		// (get) Token: 0x06002875 RID: 10357 RVA: 0x000AE1A8 File Offset: 0x000AC3A8
		// (set) Token: 0x06002876 RID: 10358 RVA: 0x000AE1B0 File Offset: 0x000AC3B0
		[ProtoMember(17, IsRequired = true, Name = "BattleMusic", DataFormat = DataFormat.Default)]
		public string BattleMusic
		{
			get
			{
				return this._BattleMusic;
			}
			set
			{
				this._BattleMusic = value;
			}
		}

		// Token: 0x17000A8F RID: 2703
		// (get) Token: 0x06002877 RID: 10359 RVA: 0x000AE1BC File Offset: 0x000AC3BC
		// (set) Token: 0x06002878 RID: 10360 RVA: 0x000AE1C4 File Offset: 0x000AC3C4
		[ProtoMember(18, IsRequired = true, Name = "DefendBattleMusic", DataFormat = DataFormat.Default)]
		public string DefendBattleMusic
		{
			get
			{
				return this._DefendBattleMusic;
			}
			set
			{
				this._DefendBattleMusic = value;
			}
		}

		// Token: 0x17000A90 RID: 2704
		// (get) Token: 0x06002879 RID: 10361 RVA: 0x000AE1D0 File Offset: 0x000AC3D0
		// (set) Token: 0x0600287A RID: 10362 RVA: 0x000AE1D8 File Offset: 0x000AC3D8
		[ProtoMember(19, IsRequired = true, Name = "TurnMax", DataFormat = DataFormat.TwosComplement)]
		public int TurnMax
		{
			get
			{
				return this._TurnMax;
			}
			set
			{
				this._TurnMax = value;
			}
		}

		// Token: 0x17000A91 RID: 2705
		// (get) Token: 0x0600287B RID: 10363 RVA: 0x000AE1E4 File Offset: 0x000AC3E4
		[ProtoMember(20, Name = "WinConditions_ID", DataFormat = DataFormat.TwosComplement)]
		public List<int> WinConditions_ID
		{
			get
			{
				return this._WinConditions_ID;
			}
		}

		// Token: 0x17000A92 RID: 2706
		// (get) Token: 0x0600287C RID: 10364 RVA: 0x000AE1EC File Offset: 0x000AC3EC
		[ProtoMember(21, Name = "LoseConditions_ID", DataFormat = DataFormat.TwosComplement)]
		public List<int> LoseConditions_ID
		{
			get
			{
				return this._LoseConditions_ID;
			}
		}

		// Token: 0x17000A93 RID: 2707
		// (get) Token: 0x0600287D RID: 10365 RVA: 0x000AE1F4 File Offset: 0x000AC3F4
		[ProtoMember(22, Name = "EventTriggers_ID", DataFormat = DataFormat.TwosComplement)]
		public List<int> EventTriggers_ID
		{
			get
			{
				return this._EventTriggers_ID;
			}
		}

		// Token: 0x17000A94 RID: 2708
		// (get) Token: 0x0600287E RID: 10366 RVA: 0x000AE1FC File Offset: 0x000AC3FC
		// (set) Token: 0x0600287F RID: 10367 RVA: 0x000AE204 File Offset: 0x000AC404
		[ProtoMember(23, IsRequired = true, Name = "AttackNumber", DataFormat = DataFormat.TwosComplement)]
		public int AttackNumber
		{
			get
			{
				return this._AttackNumber;
			}
			set
			{
				this._AttackNumber = value;
			}
		}

		// Token: 0x17000A95 RID: 2709
		// (get) Token: 0x06002880 RID: 10368 RVA: 0x000AE210 File Offset: 0x000AC410
		[ProtoMember(24, Name = "AttackPositions", DataFormat = DataFormat.Default)]
		public List<ParamPosition> AttackPositions
		{
			get
			{
				return this._AttackPositions;
			}
		}

		// Token: 0x17000A96 RID: 2710
		// (get) Token: 0x06002881 RID: 10369 RVA: 0x000AE218 File Offset: 0x000AC418
		[ProtoMember(25, Name = "AttackDirs", DataFormat = DataFormat.TwosComplement)]
		public List<int> AttackDirs
		{
			get
			{
				return this._AttackDirs;
			}
		}

		// Token: 0x17000A97 RID: 2711
		// (get) Token: 0x06002882 RID: 10370 RVA: 0x000AE220 File Offset: 0x000AC420
		// (set) Token: 0x06002883 RID: 10371 RVA: 0x000AE228 File Offset: 0x000AC428
		[ProtoMember(26, IsRequired = true, Name = "DefendNumber", DataFormat = DataFormat.TwosComplement)]
		public int DefendNumber
		{
			get
			{
				return this._DefendNumber;
			}
			set
			{
				this._DefendNumber = value;
			}
		}

		// Token: 0x17000A98 RID: 2712
		// (get) Token: 0x06002884 RID: 10372 RVA: 0x000AE234 File Offset: 0x000AC434
		[ProtoMember(27, Name = "DefendPositions", DataFormat = DataFormat.Default)]
		public List<ParamPosition> DefendPositions
		{
			get
			{
				return this._DefendPositions;
			}
		}

		// Token: 0x17000A99 RID: 2713
		// (get) Token: 0x06002885 RID: 10373 RVA: 0x000AE23C File Offset: 0x000AC43C
		[ProtoMember(28, Name = "DefendDirs", DataFormat = DataFormat.TwosComplement)]
		public List<int> DefendDirs
		{
			get
			{
				return this._DefendDirs;
			}
		}

		// Token: 0x06002886 RID: 10374 RVA: 0x000AE244 File Offset: 0x000AC444
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06002887 RID: 10375 RVA: 0x000AE254 File Offset: 0x000AC454
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

		// Token: 0x06002888 RID: 10376 RVA: 0x000AE320 File Offset: 0x000AC520
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataRealTimePVPBattleInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040018C6 RID: 6342
		private int _ID;

		// Token: 0x040018C7 RID: 6343
		private string _Name;

		// Token: 0x040018C8 RID: 6344
		private string _NameStrKey;

		// Token: 0x040018C9 RID: 6345
		private string _Desc;

		// Token: 0x040018CA RID: 6346
		private string _DescStrKey;

		// Token: 0x040018CB RID: 6347
		private string _WinDesc;

		// Token: 0x040018CC RID: 6348
		private string _WinDescStrKey;

		// Token: 0x040018CD RID: 6349
		private string _LoseDesc;

		// Token: 0x040018CE RID: 6350
		private string _LoseDescStrKey;

		// Token: 0x040018CF RID: 6351
		private int _Battlefield_ID;

		// Token: 0x040018D0 RID: 6352
		private int _CameraX;

		// Token: 0x040018D1 RID: 6353
		private int _CameraY;

		// Token: 0x040018D2 RID: 6354
		private int _DefendCameraX;

		// Token: 0x040018D3 RID: 6355
		private int _DefendCameraY;

		// Token: 0x040018D4 RID: 6356
		private string _PrepareMusic;

		// Token: 0x040018D5 RID: 6357
		private string _BattleMusic;

		// Token: 0x040018D6 RID: 6358
		private string _DefendBattleMusic;

		// Token: 0x040018D7 RID: 6359
		private int _TurnMax;

		// Token: 0x040018D8 RID: 6360
		private readonly List<int> _WinConditions_ID = new List<int>();

		// Token: 0x040018D9 RID: 6361
		private readonly List<int> _LoseConditions_ID = new List<int>();

		// Token: 0x040018DA RID: 6362
		private readonly List<int> _EventTriggers_ID = new List<int>();

		// Token: 0x040018DB RID: 6363
		private int _AttackNumber;

		// Token: 0x040018DC RID: 6364
		private readonly List<ParamPosition> _AttackPositions = new List<ParamPosition>();

		// Token: 0x040018DD RID: 6365
		private readonly List<int> _AttackDirs = new List<int>();

		// Token: 0x040018DE RID: 6366
		private int _DefendNumber;

		// Token: 0x040018DF RID: 6367
		private readonly List<ParamPosition> _DefendPositions = new List<ParamPosition>();

		// Token: 0x040018E0 RID: 6368
		private readonly List<int> _DefendDirs = new List<int>();

		// Token: 0x040018E1 RID: 6369
		private IExtension extensionObject;

		// Token: 0x040018E2 RID: 6370
		public ConfigDataBattlefieldInfo m_battlefieldInfo;

		// Token: 0x040018E3 RID: 6371
		public ConfigDataBattleWinConditionInfo[] m_battleWinConditionInfos;

		// Token: 0x040018E4 RID: 6372
		public ConfigDataBattleLoseConditionInfo[] m_battleLoseConditionInfos;

		// Token: 0x040018E5 RID: 6373
		public ConfigDataBattleEventTriggerInfo[] m_battleEventTriggerInfos;

		// Token: 0x040018E6 RID: 6374
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040018E7 RID: 6375
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040018E8 RID: 6376
		private LuaFunction m_ctor_hotfix;
	}
}
