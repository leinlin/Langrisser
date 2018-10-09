using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x0200026C RID: 620
	[HotFix(true, m_isCtorOnly = true)]
	[CustomLuaClass]
	[ProtoContract(Name = "ConfigDataPVPBattleInfo")]
	[Serializable]
	public class ConfigDataPVPBattleInfo : IExtensible
	{
		// Token: 0x060027B1 RID: 10161 RVA: 0x000AC848 File Offset: 0x000AAA48
		public ConfigDataPVPBattleInfo()
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

		// Token: 0x17000A3D RID: 2621
		// (get) Token: 0x060027B2 RID: 10162 RVA: 0x000AC8FC File Offset: 0x000AAAFC
		// (set) Token: 0x060027B3 RID: 10163 RVA: 0x000AC904 File Offset: 0x000AAB04
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

		// Token: 0x17000A3E RID: 2622
		// (get) Token: 0x060027B4 RID: 10164 RVA: 0x000AC910 File Offset: 0x000AAB10
		// (set) Token: 0x060027B5 RID: 10165 RVA: 0x000AC918 File Offset: 0x000AAB18
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

		// Token: 0x17000A3F RID: 2623
		// (get) Token: 0x060027B6 RID: 10166 RVA: 0x000AC924 File Offset: 0x000AAB24
		// (set) Token: 0x060027B7 RID: 10167 RVA: 0x000AC92C File Offset: 0x000AAB2C
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

		// Token: 0x17000A40 RID: 2624
		// (get) Token: 0x060027B8 RID: 10168 RVA: 0x000AC938 File Offset: 0x000AAB38
		// (set) Token: 0x060027B9 RID: 10169 RVA: 0x000AC940 File Offset: 0x000AAB40
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

		// Token: 0x17000A41 RID: 2625
		// (get) Token: 0x060027BA RID: 10170 RVA: 0x000AC94C File Offset: 0x000AAB4C
		// (set) Token: 0x060027BB RID: 10171 RVA: 0x000AC954 File Offset: 0x000AAB54
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

		// Token: 0x17000A42 RID: 2626
		// (get) Token: 0x060027BC RID: 10172 RVA: 0x000AC960 File Offset: 0x000AAB60
		// (set) Token: 0x060027BD RID: 10173 RVA: 0x000AC968 File Offset: 0x000AAB68
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

		// Token: 0x17000A43 RID: 2627
		// (get) Token: 0x060027BE RID: 10174 RVA: 0x000AC974 File Offset: 0x000AAB74
		// (set) Token: 0x060027BF RID: 10175 RVA: 0x000AC97C File Offset: 0x000AAB7C
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

		// Token: 0x17000A44 RID: 2628
		// (get) Token: 0x060027C0 RID: 10176 RVA: 0x000AC988 File Offset: 0x000AAB88
		// (set) Token: 0x060027C1 RID: 10177 RVA: 0x000AC990 File Offset: 0x000AAB90
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

		// Token: 0x17000A45 RID: 2629
		// (get) Token: 0x060027C2 RID: 10178 RVA: 0x000AC99C File Offset: 0x000AAB9C
		// (set) Token: 0x060027C3 RID: 10179 RVA: 0x000AC9A4 File Offset: 0x000AABA4
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

		// Token: 0x17000A46 RID: 2630
		// (get) Token: 0x060027C4 RID: 10180 RVA: 0x000AC9B0 File Offset: 0x000AABB0
		// (set) Token: 0x060027C5 RID: 10181 RVA: 0x000AC9B8 File Offset: 0x000AABB8
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

		// Token: 0x17000A47 RID: 2631
		// (get) Token: 0x060027C6 RID: 10182 RVA: 0x000AC9C4 File Offset: 0x000AABC4
		// (set) Token: 0x060027C7 RID: 10183 RVA: 0x000AC9CC File Offset: 0x000AABCC
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

		// Token: 0x17000A48 RID: 2632
		// (get) Token: 0x060027C8 RID: 10184 RVA: 0x000AC9D8 File Offset: 0x000AABD8
		// (set) Token: 0x060027C9 RID: 10185 RVA: 0x000AC9E0 File Offset: 0x000AABE0
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

		// Token: 0x17000A49 RID: 2633
		// (get) Token: 0x060027CA RID: 10186 RVA: 0x000AC9EC File Offset: 0x000AABEC
		// (set) Token: 0x060027CB RID: 10187 RVA: 0x000AC9F4 File Offset: 0x000AABF4
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

		// Token: 0x17000A4A RID: 2634
		// (get) Token: 0x060027CC RID: 10188 RVA: 0x000ACA00 File Offset: 0x000AAC00
		// (set) Token: 0x060027CD RID: 10189 RVA: 0x000ACA08 File Offset: 0x000AAC08
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

		// Token: 0x17000A4B RID: 2635
		// (get) Token: 0x060027CE RID: 10190 RVA: 0x000ACA14 File Offset: 0x000AAC14
		// (set) Token: 0x060027CF RID: 10191 RVA: 0x000ACA1C File Offset: 0x000AAC1C
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

		// Token: 0x17000A4C RID: 2636
		// (get) Token: 0x060027D0 RID: 10192 RVA: 0x000ACA28 File Offset: 0x000AAC28
		// (set) Token: 0x060027D1 RID: 10193 RVA: 0x000ACA30 File Offset: 0x000AAC30
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

		// Token: 0x17000A4D RID: 2637
		// (get) Token: 0x060027D2 RID: 10194 RVA: 0x000ACA3C File Offset: 0x000AAC3C
		// (set) Token: 0x060027D3 RID: 10195 RVA: 0x000ACA44 File Offset: 0x000AAC44
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

		// Token: 0x17000A4E RID: 2638
		// (get) Token: 0x060027D4 RID: 10196 RVA: 0x000ACA50 File Offset: 0x000AAC50
		// (set) Token: 0x060027D5 RID: 10197 RVA: 0x000ACA58 File Offset: 0x000AAC58
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

		// Token: 0x17000A4F RID: 2639
		// (get) Token: 0x060027D6 RID: 10198 RVA: 0x000ACA64 File Offset: 0x000AAC64
		[ProtoMember(20, Name = "WinConditions_ID", DataFormat = DataFormat.TwosComplement)]
		public List<int> WinConditions_ID
		{
			get
			{
				return this._WinConditions_ID;
			}
		}

		// Token: 0x17000A50 RID: 2640
		// (get) Token: 0x060027D7 RID: 10199 RVA: 0x000ACA6C File Offset: 0x000AAC6C
		[ProtoMember(21, Name = "LoseConditions_ID", DataFormat = DataFormat.TwosComplement)]
		public List<int> LoseConditions_ID
		{
			get
			{
				return this._LoseConditions_ID;
			}
		}

		// Token: 0x17000A51 RID: 2641
		// (get) Token: 0x060027D8 RID: 10200 RVA: 0x000ACA74 File Offset: 0x000AAC74
		[ProtoMember(22, Name = "EventTriggers_ID", DataFormat = DataFormat.TwosComplement)]
		public List<int> EventTriggers_ID
		{
			get
			{
				return this._EventTriggers_ID;
			}
		}

		// Token: 0x17000A52 RID: 2642
		// (get) Token: 0x060027D9 RID: 10201 RVA: 0x000ACA7C File Offset: 0x000AAC7C
		// (set) Token: 0x060027DA RID: 10202 RVA: 0x000ACA84 File Offset: 0x000AAC84
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

		// Token: 0x17000A53 RID: 2643
		// (get) Token: 0x060027DB RID: 10203 RVA: 0x000ACA90 File Offset: 0x000AAC90
		[ProtoMember(24, Name = "AttackPositions", DataFormat = DataFormat.Default)]
		public List<ParamPosition> AttackPositions
		{
			get
			{
				return this._AttackPositions;
			}
		}

		// Token: 0x17000A54 RID: 2644
		// (get) Token: 0x060027DC RID: 10204 RVA: 0x000ACA98 File Offset: 0x000AAC98
		[ProtoMember(25, Name = "AttackDirs", DataFormat = DataFormat.TwosComplement)]
		public List<int> AttackDirs
		{
			get
			{
				return this._AttackDirs;
			}
		}

		// Token: 0x17000A55 RID: 2645
		// (get) Token: 0x060027DD RID: 10205 RVA: 0x000ACAA0 File Offset: 0x000AACA0
		// (set) Token: 0x060027DE RID: 10206 RVA: 0x000ACAA8 File Offset: 0x000AACA8
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

		// Token: 0x17000A56 RID: 2646
		// (get) Token: 0x060027DF RID: 10207 RVA: 0x000ACAB4 File Offset: 0x000AACB4
		[ProtoMember(27, Name = "DefendPositions", DataFormat = DataFormat.Default)]
		public List<ParamPosition> DefendPositions
		{
			get
			{
				return this._DefendPositions;
			}
		}

		// Token: 0x17000A57 RID: 2647
		// (get) Token: 0x060027E0 RID: 10208 RVA: 0x000ACABC File Offset: 0x000AACBC
		[ProtoMember(28, Name = "DefendDirs", DataFormat = DataFormat.TwosComplement)]
		public List<int> DefendDirs
		{
			get
			{
				return this._DefendDirs;
			}
		}

		// Token: 0x060027E1 RID: 10209 RVA: 0x000ACAC4 File Offset: 0x000AACC4
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060027E2 RID: 10210 RVA: 0x000ACAD4 File Offset: 0x000AACD4
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

		// Token: 0x060027E3 RID: 10211 RVA: 0x000ACBA0 File Offset: 0x000AADA0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataPVPBattleInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04001854 RID: 6228
		private int _ID;

		// Token: 0x04001855 RID: 6229
		private string _Name;

		// Token: 0x04001856 RID: 6230
		private string _NameStrKey;

		// Token: 0x04001857 RID: 6231
		private string _Desc;

		// Token: 0x04001858 RID: 6232
		private string _DescStrKey;

		// Token: 0x04001859 RID: 6233
		private string _WinDesc;

		// Token: 0x0400185A RID: 6234
		private string _WinDescStrKey;

		// Token: 0x0400185B RID: 6235
		private string _LoseDesc;

		// Token: 0x0400185C RID: 6236
		private string _LoseDescStrKey;

		// Token: 0x0400185D RID: 6237
		private int _Battlefield_ID;

		// Token: 0x0400185E RID: 6238
		private int _CameraX;

		// Token: 0x0400185F RID: 6239
		private int _CameraY;

		// Token: 0x04001860 RID: 6240
		private int _DefendCameraX;

		// Token: 0x04001861 RID: 6241
		private int _DefendCameraY;

		// Token: 0x04001862 RID: 6242
		private string _PrepareMusic;

		// Token: 0x04001863 RID: 6243
		private string _BattleMusic;

		// Token: 0x04001864 RID: 6244
		private string _DefendBattleMusic;

		// Token: 0x04001865 RID: 6245
		private int _TurnMax;

		// Token: 0x04001866 RID: 6246
		private readonly List<int> _WinConditions_ID = new List<int>();

		// Token: 0x04001867 RID: 6247
		private readonly List<int> _LoseConditions_ID = new List<int>();

		// Token: 0x04001868 RID: 6248
		private readonly List<int> _EventTriggers_ID = new List<int>();

		// Token: 0x04001869 RID: 6249
		private int _AttackNumber;

		// Token: 0x0400186A RID: 6250
		private readonly List<ParamPosition> _AttackPositions = new List<ParamPosition>();

		// Token: 0x0400186B RID: 6251
		private readonly List<int> _AttackDirs = new List<int>();

		// Token: 0x0400186C RID: 6252
		private int _DefendNumber;

		// Token: 0x0400186D RID: 6253
		private readonly List<ParamPosition> _DefendPositions = new List<ParamPosition>();

		// Token: 0x0400186E RID: 6254
		private readonly List<int> _DefendDirs = new List<int>();

		// Token: 0x0400186F RID: 6255
		private IExtension extensionObject;

		// Token: 0x04001870 RID: 6256
		public ConfigDataBattlefieldInfo m_battlefieldInfo;

		// Token: 0x04001871 RID: 6257
		public ConfigDataBattleWinConditionInfo[] m_battleWinConditionInfos;

		// Token: 0x04001872 RID: 6258
		public ConfigDataBattleLoseConditionInfo[] m_battleLoseConditionInfos;

		// Token: 0x04001873 RID: 6259
		public ConfigDataBattleEventTriggerInfo[] m_battleEventTriggerInfos;

		// Token: 0x04001874 RID: 6260
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04001875 RID: 6261
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04001876 RID: 6262
		private LuaFunction m_ctor_hotfix;
	}
}
