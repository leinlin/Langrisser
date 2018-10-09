using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x02000284 RID: 644
	[CustomLuaClass]
	[ProtoContract(Name = "ConfigDataScenarioInfo")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ConfigDataScenarioInfo : IExtensible
	{
		// Token: 0x0600299D RID: 10653 RVA: 0x000B0134 File Offset: 0x000AE334
		public ConfigDataScenarioInfo()
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

		// Token: 0x17000B16 RID: 2838
		// (get) Token: 0x0600299E RID: 10654 RVA: 0x000B01B0 File Offset: 0x000AE3B0
		// (set) Token: 0x0600299F RID: 10655 RVA: 0x000B01B8 File Offset: 0x000AE3B8
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

		// Token: 0x17000B17 RID: 2839
		// (get) Token: 0x060029A0 RID: 10656 RVA: 0x000B01C4 File Offset: 0x000AE3C4
		// (set) Token: 0x060029A1 RID: 10657 RVA: 0x000B01CC File Offset: 0x000AE3CC
		[ProtoMember(3, IsRequired = true, Name = "Chapter", DataFormat = DataFormat.Default)]
		public string Chapter
		{
			get
			{
				return this._Chapter;
			}
			set
			{
				this._Chapter = value;
			}
		}

		// Token: 0x17000B18 RID: 2840
		// (get) Token: 0x060029A2 RID: 10658 RVA: 0x000B01D8 File Offset: 0x000AE3D8
		// (set) Token: 0x060029A3 RID: 10659 RVA: 0x000B01E0 File Offset: 0x000AE3E0
		[ProtoMember(4, IsRequired = true, Name = "ChapterStrKey", DataFormat = DataFormat.Default)]
		public string ChapterStrKey
		{
			get
			{
				return this._ChapterStrKey;
			}
			set
			{
				this._ChapterStrKey = value;
			}
		}

		// Token: 0x17000B19 RID: 2841
		// (get) Token: 0x060029A4 RID: 10660 RVA: 0x000B01EC File Offset: 0x000AE3EC
		// (set) Token: 0x060029A5 RID: 10661 RVA: 0x000B01F4 File Offset: 0x000AE3F4
		[ProtoMember(5, IsRequired = true, Name = "Name", DataFormat = DataFormat.Default)]
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

		// Token: 0x17000B1A RID: 2842
		// (get) Token: 0x060029A6 RID: 10662 RVA: 0x000B0200 File Offset: 0x000AE400
		// (set) Token: 0x060029A7 RID: 10663 RVA: 0x000B0208 File Offset: 0x000AE408
		[ProtoMember(6, IsRequired = true, Name = "NameStrKey", DataFormat = DataFormat.Default)]
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

		// Token: 0x17000B1B RID: 2843
		// (get) Token: 0x060029A8 RID: 10664 RVA: 0x000B0214 File Offset: 0x000AE414
		// (set) Token: 0x060029A9 RID: 10665 RVA: 0x000B021C File Offset: 0x000AE41C
		[ProtoMember(7, IsRequired = true, Name = "Desc", DataFormat = DataFormat.Default)]
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

		// Token: 0x17000B1C RID: 2844
		// (get) Token: 0x060029AA RID: 10666 RVA: 0x000B0228 File Offset: 0x000AE428
		// (set) Token: 0x060029AB RID: 10667 RVA: 0x000B0230 File Offset: 0x000AE430
		[ProtoMember(8, IsRequired = true, Name = "DescStrKey", DataFormat = DataFormat.Default)]
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

		// Token: 0x17000B1D RID: 2845
		// (get) Token: 0x060029AC RID: 10668 RVA: 0x000B023C File Offset: 0x000AE43C
		// (set) Token: 0x060029AD RID: 10669 RVA: 0x000B0244 File Offset: 0x000AE444
		[ProtoMember(9, IsRequired = true, Name = "Waypoint_ID", DataFormat = DataFormat.TwosComplement)]
		public int Waypoint_ID
		{
			get
			{
				return this._Waypoint_ID;
			}
			set
			{
				this._Waypoint_ID = value;
			}
		}

		// Token: 0x17000B1E RID: 2846
		// (get) Token: 0x060029AE RID: 10670 RVA: 0x000B0250 File Offset: 0x000AE450
		// (set) Token: 0x060029AF RID: 10671 RVA: 0x000B0258 File Offset: 0x000AE458
		[ProtoMember(10, IsRequired = true, Name = "NextScenario_ID", DataFormat = DataFormat.TwosComplement)]
		public int NextScenario_ID
		{
			get
			{
				return this._NextScenario_ID;
			}
			set
			{
				this._NextScenario_ID = value;
			}
		}

		// Token: 0x17000B1F RID: 2847
		// (get) Token: 0x060029B0 RID: 10672 RVA: 0x000B0264 File Offset: 0x000AE464
		// (set) Token: 0x060029B1 RID: 10673 RVA: 0x000B026C File Offset: 0x000AE46C
		[ProtoMember(11, IsRequired = true, Name = "MonsterLevel", DataFormat = DataFormat.TwosComplement)]
		public int MonsterLevel
		{
			get
			{
				return this._MonsterLevel;
			}
			set
			{
				this._MonsterLevel = value;
			}
		}

		// Token: 0x17000B20 RID: 2848
		// (get) Token: 0x060029B2 RID: 10674 RVA: 0x000B0278 File Offset: 0x000AE478
		// (set) Token: 0x060029B3 RID: 10675 RVA: 0x000B0280 File Offset: 0x000AE480
		[ProtoMember(12, IsRequired = true, Name = "Battle_ID", DataFormat = DataFormat.TwosComplement)]
		public int Battle_ID
		{
			get
			{
				return this._Battle_ID;
			}
			set
			{
				this._Battle_ID = value;
			}
		}

		// Token: 0x17000B21 RID: 2849
		// (get) Token: 0x060029B4 RID: 10676 RVA: 0x000B028C File Offset: 0x000AE48C
		// (set) Token: 0x060029B5 RID: 10677 RVA: 0x000B0294 File Offset: 0x000AE494
		[ProtoMember(13, IsRequired = true, Name = "DialogBefore_ID", DataFormat = DataFormat.TwosComplement)]
		public int DialogBefore_ID
		{
			get
			{
				return this._DialogBefore_ID;
			}
			set
			{
				this._DialogBefore_ID = value;
			}
		}

		// Token: 0x17000B22 RID: 2850
		// (get) Token: 0x060029B6 RID: 10678 RVA: 0x000B02A0 File Offset: 0x000AE4A0
		// (set) Token: 0x060029B7 RID: 10679 RVA: 0x000B02A8 File Offset: 0x000AE4A8
		[ProtoMember(14, IsRequired = true, Name = "DialogAfter_ID", DataFormat = DataFormat.TwosComplement)]
		public int DialogAfter_ID
		{
			get
			{
				return this._DialogAfter_ID;
			}
			set
			{
				this._DialogAfter_ID = value;
			}
		}

		// Token: 0x17000B23 RID: 2851
		// (get) Token: 0x060029B8 RID: 10680 RVA: 0x000B02B4 File Offset: 0x000AE4B4
		[ProtoMember(15, Name = "UnlockCondition", DataFormat = DataFormat.Default)]
		public List<ScenarioInfoUnlockCondition> UnlockCondition
		{
			get
			{
				return this._UnlockCondition;
			}
		}

		// Token: 0x17000B24 RID: 2852
		// (get) Token: 0x060029B9 RID: 10681 RVA: 0x000B02BC File Offset: 0x000AE4BC
		// (set) Token: 0x060029BA RID: 10682 RVA: 0x000B02C4 File Offset: 0x000AE4C4
		[ProtoMember(16, IsRequired = true, Name = "PlayerExpReward", DataFormat = DataFormat.TwosComplement)]
		public int PlayerExpReward
		{
			get
			{
				return this._PlayerExpReward;
			}
			set
			{
				this._PlayerExpReward = value;
			}
		}

		// Token: 0x17000B25 RID: 2853
		// (get) Token: 0x060029BB RID: 10683 RVA: 0x000B02D0 File Offset: 0x000AE4D0
		// (set) Token: 0x060029BC RID: 10684 RVA: 0x000B02D8 File Offset: 0x000AE4D8
		[ProtoMember(17, IsRequired = true, Name = "HeroExpReward", DataFormat = DataFormat.TwosComplement)]
		public int HeroExpReward
		{
			get
			{
				return this._HeroExpReward;
			}
			set
			{
				this._HeroExpReward = value;
			}
		}

		// Token: 0x17000B26 RID: 2854
		// (get) Token: 0x060029BD RID: 10685 RVA: 0x000B02E4 File Offset: 0x000AE4E4
		// (set) Token: 0x060029BE RID: 10686 RVA: 0x000B02EC File Offset: 0x000AE4EC
		[ProtoMember(18, IsRequired = true, Name = "GoldReward", DataFormat = DataFormat.TwosComplement)]
		public int GoldReward
		{
			get
			{
				return this._GoldReward;
			}
			set
			{
				this._GoldReward = value;
			}
		}

		// Token: 0x17000B27 RID: 2855
		// (get) Token: 0x060029BF RID: 10687 RVA: 0x000B02F8 File Offset: 0x000AE4F8
		// (set) Token: 0x060029C0 RID: 10688 RVA: 0x000B0300 File Offset: 0x000AE500
		[ProtoMember(19, IsRequired = true, Name = "EnergySuccess", DataFormat = DataFormat.TwosComplement)]
		public int EnergySuccess
		{
			get
			{
				return this._EnergySuccess;
			}
			set
			{
				this._EnergySuccess = value;
			}
		}

		// Token: 0x17000B28 RID: 2856
		// (get) Token: 0x060029C1 RID: 10689 RVA: 0x000B030C File Offset: 0x000AE50C
		// (set) Token: 0x060029C2 RID: 10690 RVA: 0x000B0314 File Offset: 0x000AE514
		[ProtoMember(20, IsRequired = true, Name = "EnergyFail", DataFormat = DataFormat.TwosComplement)]
		public int EnergyFail
		{
			get
			{
				return this._EnergyFail;
			}
			set
			{
				this._EnergyFail = value;
			}
		}

		// Token: 0x17000B29 RID: 2857
		// (get) Token: 0x060029C3 RID: 10691 RVA: 0x000B0320 File Offset: 0x000AE520
		[ProtoMember(21, Name = "FirstReward", DataFormat = DataFormat.Default)]
		public List<Goods> FirstReward
		{
			get
			{
				return this._FirstReward;
			}
		}

		// Token: 0x17000B2A RID: 2858
		// (get) Token: 0x060029C4 RID: 10692 RVA: 0x000B0328 File Offset: 0x000AE528
		// (set) Token: 0x060029C5 RID: 10693 RVA: 0x000B0330 File Offset: 0x000AE530
		[ProtoMember(22, IsRequired = true, Name = "Drop_ID", DataFormat = DataFormat.TwosComplement)]
		public int Drop_ID
		{
			get
			{
				return this._Drop_ID;
			}
			set
			{
				this._Drop_ID = value;
			}
		}

		// Token: 0x17000B2B RID: 2859
		// (get) Token: 0x060029C6 RID: 10694 RVA: 0x000B033C File Offset: 0x000AE53C
		// (set) Token: 0x060029C7 RID: 10695 RVA: 0x000B0344 File Offset: 0x000AE544
		[ProtoMember(23, IsRequired = true, Name = "Strategy", DataFormat = DataFormat.Default)]
		public string Strategy
		{
			get
			{
				return this._Strategy;
			}
			set
			{
				this._Strategy = value;
			}
		}

		// Token: 0x17000B2C RID: 2860
		// (get) Token: 0x060029C8 RID: 10696 RVA: 0x000B0350 File Offset: 0x000AE550
		// (set) Token: 0x060029C9 RID: 10697 RVA: 0x000B0358 File Offset: 0x000AE558
		[ProtoMember(24, IsRequired = true, Name = "IsOpened", DataFormat = DataFormat.Default)]
		public bool IsOpened
		{
			get
			{
				return this._IsOpened;
			}
			set
			{
				this._IsOpened = value;
			}
		}

		// Token: 0x060029CA RID: 10698 RVA: 0x000B0364 File Offset: 0x000AE564
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060029CB RID: 10699 RVA: 0x000B0374 File Offset: 0x000AE574
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

		// Token: 0x060029CC RID: 10700 RVA: 0x000B0440 File Offset: 0x000AE640
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataScenarioInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400199D RID: 6557
		private int _ID;

		// Token: 0x0400199E RID: 6558
		private string _Chapter;

		// Token: 0x0400199F RID: 6559
		private string _ChapterStrKey;

		// Token: 0x040019A0 RID: 6560
		private string _Name;

		// Token: 0x040019A1 RID: 6561
		private string _NameStrKey;

		// Token: 0x040019A2 RID: 6562
		private string _Desc;

		// Token: 0x040019A3 RID: 6563
		private string _DescStrKey;

		// Token: 0x040019A4 RID: 6564
		private int _Waypoint_ID;

		// Token: 0x040019A5 RID: 6565
		private int _NextScenario_ID;

		// Token: 0x040019A6 RID: 6566
		private int _MonsterLevel;

		// Token: 0x040019A7 RID: 6567
		private int _Battle_ID;

		// Token: 0x040019A8 RID: 6568
		private int _DialogBefore_ID;

		// Token: 0x040019A9 RID: 6569
		private int _DialogAfter_ID;

		// Token: 0x040019AA RID: 6570
		private readonly List<ScenarioInfoUnlockCondition> _UnlockCondition = new List<ScenarioInfoUnlockCondition>();

		// Token: 0x040019AB RID: 6571
		private int _PlayerExpReward;

		// Token: 0x040019AC RID: 6572
		private int _HeroExpReward;

		// Token: 0x040019AD RID: 6573
		private int _GoldReward;

		// Token: 0x040019AE RID: 6574
		private int _EnergySuccess;

		// Token: 0x040019AF RID: 6575
		private int _EnergyFail;

		// Token: 0x040019B0 RID: 6576
		private readonly List<Goods> _FirstReward = new List<Goods>();

		// Token: 0x040019B1 RID: 6577
		private int _Drop_ID;

		// Token: 0x040019B2 RID: 6578
		private string _Strategy;

		// Token: 0x040019B3 RID: 6579
		private bool _IsOpened;

		// Token: 0x040019B4 RID: 6580
		private IExtension extensionObject;

		// Token: 0x040019B5 RID: 6581
		public ConfigDataWaypointInfo m_waypointInfo;

		// Token: 0x040019B6 RID: 6582
		public ConfigDataScenarioInfo m_nextScenarioInfo;

		// Token: 0x040019B7 RID: 6583
		public ConfigDataBattleInfo m_battleInfo;

		// Token: 0x040019B8 RID: 6584
		public ConfigDataDialogInfo m_dialogInfoBefore;

		// Token: 0x040019B9 RID: 6585
		public ConfigDataDialogInfo m_dialogInfoAfter;

		// Token: 0x040019BA RID: 6586
		public int m_scenarioDepth;

		// Token: 0x040019BB RID: 6587
		public ConfigDataRegionInfo m_regionInfo;

		// Token: 0x040019BC RID: 6588
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040019BD RID: 6589
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040019BE RID: 6590
		private LuaFunction m_ctor_hotfix;
	}
}
